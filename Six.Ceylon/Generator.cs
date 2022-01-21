using Six.Core.Errors;
using Six.Gen.Ebnf;
using Six.Gen;

namespace Six.Ceylon
{
    public static class Generator
    {
        private static string LoadGrammar()
        {
            return Loader.LoadEmbedded(typeof(Generator).Assembly, "Six.Ceylon.Grammar.six");
        }

        public static void Run()
        {
            var name = "Ceylon";
            try
            {
                var content = LoadGrammar();

                var ast = Input.Builder.Build(name, content );

                using (var writer = $"{ast.Name}-ast.txt".Writer())
                {
                    var dumper = new Ast.AstDumper(writer, ast);
                    dumper.Dump();
                }

                using (var generator = new EbnfCsGenerator(name))
                {
                    generator.Generate(ast.Name, content);

                    var ebnf = generator.Grammar;

                    if (ebnf != null)
                    {
                        using (var writer = $"{ebnf.Name}-ebnf.txt".Writer())
                        {
                            new EbnfDumper(ebnf).Dump(writer);
                        }

                        var generated = generator.ToString();

                        using (var writer = $"{ebnf.Name}.gen.cs".Writer())
                        {
                            writer.Write(generated);
                        }
                    }
                }
            }
            catch (DiagnosticException ex)
            {
                Console.WriteLine("=== errors ===");
                ex.Report();
            }
        }
    }
}
