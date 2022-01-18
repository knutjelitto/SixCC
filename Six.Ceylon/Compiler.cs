using Six.Runtime;

namespace Six.Ceylon
{
    public class Compiler
    {
        private readonly Parser parser = new CeylonParser();

        public void BuildModule(Module module)
        {
            Console.Write("?");
            var ok = Ok(Parse(module.ModuleFile));
            Console.WriteLine();
        }

        private bool Parse(SourceFile file)
        {
            var source = Source.FromString(file.Fullname, file.Content);
            parser.Reset();
            return parser.Parse(source);
        }

        private bool Ok(bool ok)
        {
            if (ok)
            {
                Console.Write("\b|");
            }
            else
            {
                Console.Write("\b×");
            }

            return ok;
        }
    }
}
