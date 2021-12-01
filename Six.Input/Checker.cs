using Six.Ast;
using Six.Core;
using Six.Input.Errors;
using Six.Samples;

namespace Six.Input
{
    public class Checker
    {
        public IEnumerable<Grammar?> Run()
        {
            foreach (var sample in Sampler.LoadSix())
            {
                yield return Run(sample.Name, sample.Content);
            }
        }

        public Grammar? Run(string name, string content)
        {
            try
            {
                var source = new Source(name, content);
                var lexer = new Lexer(source);
                var tokens = new Tokens(lexer);
                var parser = new Parser(tokens);
                var grammar = parser.Parse();
                grammar.DumpTree($"{grammar.Name}-tree.txt");

                return grammar;
            }
            catch (DiagnosticException ex)
            {
                ex.Diagnostic.Report(new Writer(Console.Out));
            }

            return null;
        }
    }
}
