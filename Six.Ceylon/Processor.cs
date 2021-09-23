using Six.Ceylon.Model;
using Six.Tools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using IO = System.IO;

namespace Six.Ceylon
{
    public class Processor
    {
        const string moduleFilename = "module.ceylon";
        const string packageFilename = "package.ceylon";

        private IEnumerable<DirectoryRef> FindModules(DirectoryRef root)
        {
            foreach (var moduleFile in root.Files(moduleFilename, true).OrderBy(f => f.Path))
            {
                if (moduleFile.Path.Contains("/test/") ||
                    moduleFile.Path.Contains("/test-java/") ||
                    moduleFile.Path.Contains("/testsuite/") ||
                    moduleFile.Path.Contains("/dist/") ||
                    moduleFile.Path.Contains("/mine-locale/") ||
                    false)
                {
                    continue;
                }
                yield return moduleFile.Directory;
            }
        }

        public void LoadAllModules(DirectoryRef root)
        {
            var compiler = new Compiler();
            foreach (var moduleRoot in FindModules(root))
            {
                LoadModule(moduleRoot, compiler);
                if (compiler.ShouldAbort)
                {
                    break;
                }
            }
        }

        public void LoadModule(DirectoryRef root, Compiler? compiler = null)
        {
            //Console.WriteLine($"root: {root}");
            if (!root.Exists)
            {
                throw new IO.DirectoryNotFoundException(root.ToString());
            }
            var moduleFile = root.Files(moduleFilename).FirstOrDefault();
            if (moduleFile == null)
            {
                throw new IO.FileNotFoundException(moduleFilename);
            }

            compiler ??= new Compiler();

            var module = new Module(compiler, moduleFile);

            foreach (var packageFile in root.Files(packageFilename, true))
            {
                var package = new Package(compiler, packageFile, module);
                module.Packages.Add(package);

                foreach (var file in PackageFiles(packageFile))
                {
                    var unit = new Unit(compiler, file, package);
                    package.Units.Add(unit);
                }
            }

            module.Load();
        }

        public IEnumerable<FileRef> PackageFiles(FileRef packageFile)
        {
            return
                from file in packageFile.Directory.Files("*.ceylon")
                where file.Name != packageFilename && file.Name != moduleFilename
                select file;
        }

        public void Process()
        {
            var count = 0;
            var skip = 0;
            var take = 5000;
            var compiler = new Compiler();
            var watch = new Stopwatch();
            var files = new List<Compilation>();
            watch.Start();
            files.AddRange(ParseTree(compiler, DirectoryRef.From(@"D:/Languages/Ceylon/eclipse/ceylon"), "eclipse:ceylon", ref count, ref skip, ref take));
            files.AddRange(ParseTree(compiler, DirectoryRef.From(@"D:/Languages/Ceylon/eclipse/ceylon.formatter"), "eclipse:ceylon.formatter", ref count, ref skip, ref take));
            files.AddRange(ParseTree(compiler, DirectoryRef.From(@"D:/Languages/Ceylon/eclipse/ceylon-sdk"), "eclipse:ceylon-sdk", ref count, ref skip, ref take));
            watch.Stop();

            var seconds = files.Sum(f => f.Stats.ParseTime.TotalSeconds);
            var lines = files.Sum(f => f.Stats.Lines);
            Console.WriteLine($"{files.Count} files in {Math.Round(watch.Elapsed.TotalSeconds, 2)} seconds total");
            Console.WriteLine($"{lines} lines in {Math.Round(seconds, 2)} net seconds ({Math.Round(lines / seconds)} lps)");

            var slowest =
                (from file in files.Skip(10)
                 orderby file.Stats.ParseLps ascending
                 select file)
                .Take(50);

            foreach (var slow in slowest)
            {
                Console.WriteLine($"slow|{slow.File} {slow.Stats.ParseLps} lps");
            }
        }

        private List<Compilation> ParseTree(Compiler compiler, DirectoryRef root, string prefix, ref int count, ref int skip, ref int take)
        {
            var files = new List<Compilation>();

            foreach (var file in root.Files("*.ceylon", true))
            {
                if (file.Path.Contains("/templates/") ||
                    file.Path.Contains("/test/") ||
                    file.Path.Contains("/test-samples/"))
                {
                    continue;
                }

                if (--skip >= 0)
                {
                    continue;
                }

                if (take-- <= 0)
                {
                    break;
                }

                var name = $"{prefix}::{file.Path[(root.Path.Length + 1)..]}";

                Console.WriteLine($"{++count}: {name}");

                var sourceFile = compiler.Compile(file);

                files.Add(sourceFile);
            }

            return files;
        }

        private static Compilation ParseFile(Compiler compiler, FileRef file)
        {
            return compiler.Compile(file);
        }
    }
}
