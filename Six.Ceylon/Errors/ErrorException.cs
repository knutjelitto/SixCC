using System;

namespace Six.Ceylon.Errors
{
    public class ErrorException : Exception
    {
        public ErrorException(Error error)
        {
            Error = error;
        }

        public Error Error { get; }
    }
}
