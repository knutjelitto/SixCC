using Six.Ceylon.Ast;
using Six.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Six.Ceylon.Model
{
    public class Module : ModelCore
    {
        public Module(Compiler compiler, FileRef source)
            : base(compiler, source)
        {
        }

        public List<Package> Packages { get; } = new();

        public ModuleDescriptor Descriptor => Compiler.Compile(Source).Unit.Declarations.OfType<ModuleDescriptor>().First();
        public DirectoryRef Temp => DirectoryRef.From(@"/SixTmp").AppendDirectory(Descriptor.Name.ToString());

        public void Load()
        {
            Console.WriteLine($"module: {Descriptor.Name}");
            foreach (var package in Packages)
            {
                package.Load();
                if (Compiler.ShouldAbort)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
