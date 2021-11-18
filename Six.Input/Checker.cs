using Six.Input.Errors;
using System.Reflection;

namespace Six.Input
{
    public class Checker
    {
        public void Run()
        {
            foreach (var name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                Console.WriteLine($"{name}");
                Run(name);
            }
        }

        private void Run(string name)
        {
            var content = string.Empty;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name)!)
            using (var reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            Run(name, content);
        }

        private void Run(string name, string content)
        {
            try
            {
                var source = new Source(name, content);
                var lexer = new Lexer(source);
                var tokens = new Tokens(lexer);
                var parser = new Parser(tokens);
                var grammar = parser.Grammar();
            }
            catch (DiagnosticException ex)
            {
                ex.Diagnostic.Report(new Writer(Console.Out));
            }
        }
    }
}
