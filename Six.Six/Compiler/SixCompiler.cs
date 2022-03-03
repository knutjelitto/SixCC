using System;
using Six.Core;
using Six.Runtime;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Six.Six.Instructions;
using S = Six.Six.Sema;

namespace Six.Six.Compiler
{
    public class SixCompiler : Compiler<SixParser>
    {
        private readonly S.Module Module;
        private readonly CompilerConfiguration Configuration;
        private readonly SixVisitor visitor;

        private readonly List<SourceFile> files = new();

        public SixCompiler(S.Module module, CompilerConfiguration configuration)
        {
            Module = module;
            Configuration = configuration;

            if (Configuration.WithRuleIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }

            visitor = new SixVisitor(Module.Resolver);
        }

        private void Emit()
        {
            using (var writer = $"{parser.__Name}.wat".Writer())
            {
                var emitter = new Emitter(Module, writer);
                emitter.Emit();
            }
        }

        private void Report()
        {
            if (ruleIndex != null)
            {
                using (var writer = $"{parser.__Name}-RulesIndex.txt".Writer())
                {
                    ruleIndex.Dump(writer);
                }
            }

            using (var writer = $"{parser.__Name}-Global.txt".Writer())
            {
                Module.Dump(writer);
            }

            Module.DumpEntities();


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
                foreach (var folder in module.Folders)
                {
                    ok = ok && BuildFolder(folder);

                    if (!ok)
                    {
                        break;
                    }
                }

                if (ok)
                {
                    Module.Resolver.Resolve();

                    Emit();

                    Report();
                }
            }

            Module.WhenDiagnostics();

            return ok;
        }

        private bool BuildFolder(Folder folder)
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
                 visitor.Walk(file);

                if (Configuration.DumpSppf && file.Sppf != null)
                {
                    using (var writer = $"{file.ShortPath}.sppf".Writer())
                    {
                        SppfDumper.Dump(file.Sppf, writer);
                    }
                }

                if (Configuration.DumpTree && file.Tree != null)
                {
                    using (var writer = $"{file.ShortPath}.tree".Writer())
                    {
                        TypedDumper.Dump(file.Tree, writer);
                    }
                }

                if (Configuration.DumpAst && file.Tree?.Value != null)
                {
                    using (var writer = $"{file.ShortPath}.ast".Writer())
                    {
                        new AstDumper(writer, new Reflector()).Dump(file.Tree.Value);
                    }
                }

                if (file.Tree?.Value is Ast.Unit.Code root)
                {
                    Module.Resolver.Walk(root);
                }
            }

            return ok;
        }
    }
}
