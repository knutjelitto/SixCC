using System;

namespace Six.Input.Errors
{
    public class DiagnosticException : Exception
    {
        public DiagnosticException(Diagnostic diagnostic)
        {
            Diagnostic = diagnostic;
        }

        public Diagnostic Diagnostic { get; }
    }
}
