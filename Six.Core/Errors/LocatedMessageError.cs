namespace Six.Core.Errors
{
    public abstract class LocatedMessageError : Error
    {
        public LocatedMessageError(ILocation location, string message)
        {
            Location = location;
            Message = message;
        }

        public ILocation Location { get; }
        public string Message { get; }

        public override void Report(Writer writer)
        {
            var (line, column) = Location.Source.GetLineAndColumn(Location.Offset);
            writer.WriteLine($"{Location.Source.Name}({line},{column}): {Message}");
        }
    }
}
