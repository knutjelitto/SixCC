﻿using System;

namespace SixCC.CC.Errors
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
