using System;
using Six.Ceylon.Ast;
using Six.Ceylon.Walking;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class CeylonCompiler : Compiler<CeylonParser>
    {
        private readonly CompilerConfiguration configuration;
        private readonly World world;
        private readonly CeylonVisitor visitor;
        private readonly List<SourceFile> files = new();

        public CeylonCompiler(CompilerConfiguration configuration)
        {
            if (configuration.WithRuleIndex)
            {
                ruleIndex = new RuleIndex(parser.__Core.__Matchers.OfType<PlainRule>().Select(r => r.Name));
            }

            this.configuration = configuration;

            world = new World();
            visitor = new CeylonVisitor(world);
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

            using (var writer = $"{parser.__Name}-Namespaces.txt".Writer())
            {
                world.Global.Dump(writer);
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

            using (world.Use(module))
            {
                var ok = HandleFile(module.ModuleFile);

                Console.WriteLine();

                if (ok)
                {
                    _ = GetModuleDescriptor(module.ModuleFile);

                    foreach (var package in module.Packages)
                    {
                        ok = ok && BuildPackage(package);

                        if (!ok)
                        {
                            break;
                        }
                    }
                }

                return ok;
            }
        }

        public bool BuildPackage(Package package)
        {
            Console.Write($"  {package.Name[(package.Name.IndexOf('.') + 1)..],-26}");

            using (world.Use(package))
            {
                var ok = true;

                if (package.PackageFile != null)
                {
                    ok = HandleFile(package.PackageFile);

                    if (ok)
                    {
                        var packageDescriptor = GetPackageDescriptor(package.PackageFile);
                    }
                }

                if (ok)
                {
                    foreach (var file in package.Files)
                    {
                        ok = ok && HandleFile(file);

                        if (!ok)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine();

                return ok;
            }
        }

        private bool HandleFile(SourceFile file)
        {
            files.Add(file);

            var ok = BuildFile(file);

            if (ok)
            {
                if (configuration.BuildAst)
                {
                    visitor.Walk(file);
                }

                if (configuration.DumpSppf && file.Sppf != null)
                {
                    using (var writer = $"{file.ShortPath}.sppf".Writer())
                    {
                        SppfDumper.Dump(file.Sppf, writer);
                    }
                }
                if (configuration.DumpTree && file.Tree != null)
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
                        new Reflector(writer).Reflect(file.Tree.Value);
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

        private static CPackageDescriptor? GetPackageDescriptor(SourceFile file)
        {
            return GetStart(file)?.CompilationUnit as CPackageDescriptor;
        }
    }
}
