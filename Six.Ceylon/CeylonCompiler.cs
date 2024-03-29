﻿using System;
using Six.Ceylon.Ast;
using Six.Ceylon.Sema;
using Six.Ceylon.Visitor;
using Six.Ceylon.Walking;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class CeylonCompiler : Compiler<CeylonParser>
    {
        private readonly CompilerConfiguration Configuration;
        private readonly CeylonVisitor visitor;
        private readonly Typer typer;
        private readonly Sema.Context context;
        private readonly List<SourceFile> files = new();

        public CeylonCompiler(CompilerConfiguration configuration)
        {
            Configuration = configuration;

            if (Configuration.WithRuleIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }

            context = new Sema.Context();
            visitor = new CeylonVisitor();
            typer = new Typer(context);
        }

        public void Report()
        {
            if (ruleIndex != null)
            {
                using (var writer = $"{parser.__Name}-RulesIndex.txt".Writer())
                {
                    ruleIndex.Dump(writer);
                }
            }

            using (var writer = $"{parser.__Name}-Timing.txt".Writer())
            {
                var sorted = files.OrderBy(file => file.ParseLines / file.ParseTime.TotalSeconds);

                var lines = 0;
                var seconds = 0.0;
                var milliSeconds = 0.0;
                foreach (var file in sorted)
                {
                    var ms = Math.Round(file.ParseTime.TotalMilliseconds);
                    var lps = Math.Round(file.ParseLines / file.ParseTime.TotalSeconds);

                    writer.WriteLine($"{file.ParseLines,6} lines - {ms,6} ms - {lps,6} lps - {file.ShortPath}");

                    lines += file.ParseLines;
                    seconds += file.ParseTime.TotalSeconds;
                    milliSeconds += file.ParseTime.TotalMilliseconds;
                }
                var mss = Math.Round(milliSeconds);
                var lpss = Math.Round(lines / seconds);

                writer.WriteLine();
                writer.WriteLine("Total:");
                writer.WriteLine($"{lines,6} lines - {mss,6} ms - {lpss,6} lps");
            }
        }

        public bool BuildModule(Module module)
        {
            Console.Write($"{module.Name,-28}");

            var ok = HandleFile(module.ModuleFile);

            Console.WriteLine();

            if (ok)
            {
                _ = GetModuleDescriptor(module.ModuleFile);

                foreach (var folder in module.Folders)
                {
                    ok = ok && BuildFolder(folder);

                    if (!ok)
                    {
                        break;
                    }
                }

                if (Configuration.BuildTypes)
                {
                    using (var writer = $"{parser.__Name}-Typer.txt".Writer())
                    {
                        typer.Dump(writer);
                    }
                }
            }

            return ok;
        }

        public bool BuildFolder(Folder folder)
        {
            Console.Write($"  {folder.Name[(folder.Name.IndexOf('.') + 1)..],-26}");

            var ok = true;

            foreach (var file in folder.Files)
            {
                ok = ok && HandleFile(file);

                if (!ok)
                {
                    break;
                }
            }

            Console.WriteLine();

            return ok;
        }

        private bool HandleFile(SourceFile file)
        {
            files.Add(file);

            var ok = BuildFile(file);

            if (ok)
            {
                if (Configuration.BuildAst)
                {
                    visitor.Walk(file);
                }

                if (Configuration.DumpSppf && file.Sppf != null)
                {
                    using (var writer = $"{file.ShortPath}.sppf".Writer())
                    {
                        SppfDumper.Dump(file.Sppf, writer);
                    }
                }
                file.Sppf = null;

                if (Configuration.DumpTree && file.Tree != null)
                {
                    using (var writer = $"{file.ShortPath}.tree".Writer())
                    {
                        TypedDumper.Dump(file.Tree, writer);
                    }
                }

                if (file.Tree?.Value != null)
                {
                    using (var writer = $"{file.ShortPath}.ast".Writer())
                    {
                        new Dumper(writer, typer.Ref).Dump(file.Tree.Value);
                    }

                    if (Configuration.BuildTypes)
                    {
                        if (file.Tree?.Value is AstNode root)
                        {
                            typer.Walk(root);
                        }
                    }
                }
            }

            return ok;
        }

        private static CXStart? GetStart(SourceFile file)
        {
            return file.Tree as CXStart;
        }

        private static CModuleDescriptor? GetModuleDescriptor(SourceFile file)
        {
            return GetStart(file)?.CompilationUnit as CModuleDescriptor;
        }
    }
}
