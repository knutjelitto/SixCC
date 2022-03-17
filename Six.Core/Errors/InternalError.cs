namespace Six.Core.Errors
{
    public sealed class InternalError : Error
    {
        public InternalError(string message)
        {
            Message = message;
        }

        public string Message { get; }

        public override void Report(Writer writer)
        {
            writer.WriteLine($"internal error: {Message}");
        }
    }
}
