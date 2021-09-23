using Six.Ceylon.Errors;
using Six.Tools;
using System;

namespace Six.Ceylon.Model
{
    public class Unit : ModelCore
    {
        public Unit(Compiler compiler, FileRef source, Package package)
            : base(compiler, source)
        {
            Package = package;
        }

        public Package Package { get; }
        public Module Module => Package.Module;

        public void Load()
        {
            Console.Write($".");
            var unit = Compiler.Compile(Source).Unit;
            FileRef temp = Package.Temp.AppendFile(Source.NameStem + ".txt");

            using (var writer = new FileWriter(temp))
            {
                var dumper = new Dumper(writer, Compiler);
                var visitor = new Visitor();
                var more = false;
                foreach (var declaration in unit.Declarations)
                {
                    if (more)
                    {
                        writer.WriteLine();
                    }
                    else
                    {
                        more = true;
                    }

                    dumper.Write(declaration);
                    visitor.Visit(declaration);

                    if (Compiler.ShouldAbort)
                    {
                        break;
                    }
                }
            }
        }
    }
}
