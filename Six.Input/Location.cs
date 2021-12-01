using Six.Core;

namespace Six.Input
{
    [DebuggerDisplay("{DbgOut()}")]
    public class Location : ILocation
    {
        private Location(ISource source, int offset, int length)
        {
            Source = source;
            Offset = offset;
            Length = length;
        }

        public ISource Source { get; }
        public int Offset { get; }
        public int Length { get; }

        public static Location From(ISource source, int start)
        {
            return new Location(source, start, 0);
        }

        public static Location From(ISource source, int offset, int length)
        {
            return new Location(source, offset, length);
        }

        public string GetText()
        {
            return Source.GetText(Offset, Length);
        }

        public string DbgOut()
        {
            var (lineNo, colNo) = Source.GetLineAndColumn(Offset);

            return $"{Source.Name}:{lineNo}:{colNo}";
        }
    }
}
