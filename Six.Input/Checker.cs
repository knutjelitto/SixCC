using Six.Ast;
using Six.Input.Errors;
using System.Reflection;

namespace Six.Input
{
    public class Checker
    {
        public IEnumerable<Grammar?> Run(bool basic)
        {
            foreach (var name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine($"{name}");
                yield return Run(basic, name);
            }
        }

        private Grammar? Run(bool basic, string name)
        {
            var content = string.Empty;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return Run(basic, name, content);
        }

        public Grammar? Run(bool basic, string name, string content)
        {
            try
            {
                var source = new Source(name, content);
                var lexer = new Lexer(source);
                var tokens = new Tokens(lexer);
                var parser = new Parser(tokens);
                var grammar = parser.Parse();
                grammar.DumpTree($"{grammar.Name}-tree.txt");

                if (basic)
                {
                    return grammar;
                }

                var grammar2 = new BnfTransformer(grammar).Transform();
                grammar2.DumpAst($"{grammar.Name}-ast.txt");

                return grammar2;
            }
            catch (DiagnosticException ex)
            {
                ex.Diagnostic.Report(new Writer(Console.Out));
            }

            return null;
        }
    }
}
