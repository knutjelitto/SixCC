using Six.Ast;
using Six.Core;
using Six.Core.Errors;
using Six.Samples;

namespace Six.Input
{
    public class Checker
    {
        public IEnumerable<AstGrammar?> Run()
        {
            foreach (var sample in Sampler.LoadSix())
            {
                yield return Run(sample.Name, sample.Content);
            }
        }

        public AstGrammar? Run(string name, string content)
        {
            try
            {
                return Builder.Build(name, content);
            }
            catch (DiagnosticException ex)
            {
                ex.Diagnostic.Report(new Writer(Console.Out));
            }

            return null;
        }
    }
}
