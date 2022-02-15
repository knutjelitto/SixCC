using Six.Core.Errors;
using Six.Gen.Ebnf;
using Six.Gen;
using Six.Runtime;
using Six.Core;
using Six.Ast;

namespace Six.Six
{
    public static class Generator
    {
        private static string LoadGrammar()
        {
            return Loader.LoadEmbedded(typeof(Generator).Assembly, "Six.Six.Grammar.six");
        }

        public static void Run()
        {
            var name = "Sax";
            try
            {
                var content = LoadGrammar();

                var ast = Input.Builder.Build(name, content );

                using (var writer = $"{ast.Name}-ast.txt".Writer())
                {
                    var dumper = new AstDumper(writer, ast);
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

                        using (var writer = $"{ebnf.Name}Generated.cs".Writer())
                        {
                            writer.Write(generated);
                        }
                    }
                }
            }
            catch (DiagnosticException ex)
            {
                System.Console.WriteLine("=== errors ===");
                ex.Report();
            }
        }
    }
}
