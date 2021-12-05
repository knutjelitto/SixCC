namespace Six.Core.Errors
{
    public class DiagnosticException : Exception
    {
        public DiagnosticException(params Diagnostic[] diagnostics)
        {
            Diagnostics = diagnostics;
        }

        public Diagnostic[] Diagnostics { get; }

        public void Report(Writer writer)
        {
            foreach (var diagnostic in Diagnostics)
            {
                diagnostic.Report(writer);
            }
        }

        public void Report()
        {
            using (var writer = new Writer(Console.Out))
            {
                Report(writer);
            }
        }
    }
}
