using System;
using System.Collections.Generic;
using System.Text;

namespace SixCC.Sdk.Simple
{
    public class ScannerException : ApplicationException
    {
        public ScannerException(string message) : base(message)
        {
        }
    }
}
