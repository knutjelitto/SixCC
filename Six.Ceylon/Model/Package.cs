using Six.Ceylon.Ast;
using Six.Tools;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Six.Ceylon.Model
{
    public class Package : ModelCore
    {
        private PackageDescriptor? descriptor = null;

        public Package(Compiler compiler, FileRef source, Module module)
            : base(compiler, source)
        {
            Module = module;
        }

        public Module Module { get; }
        public List<Unit> Units { get; } = new();
        public PackageDescriptor Descriptor => descriptor ??= Compiler.Compile(Source).Unit.Declarations.OfType<PackageDescriptor>().First();
        public DirectoryRef Temp => Module.Temp.AppendDirectory(Descriptor.Name.ToString());

        public void Load()
        {
            Compiler.Compile(Source);
            //Console.Write($"  package: {Descriptor.Name} ");
            foreach (var unit in Units)
            {
                unit.Load();
                if (Compiler.ShouldAbort)
                {
                    break;
                }
            }
            //Console.WriteLine();
        }
    }
}
