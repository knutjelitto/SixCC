namespace Six.Core.Errors
{
    public class SyntaxError : Error
    {
        public SyntaxError(ILocation location, string message)
        {
            Location = location;
            Message = message;
        }

        public ILocation Location { get; }
        public string Message { get; }

        public override void Report(Writer writer)
        {
            var (line, column) = Location.Source.GetLineAndColumn(Location.Offset);
            writer.WriteLine($"@({line},{column}): {Message}");
        }
    }
}
