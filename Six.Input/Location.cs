using Six.Core;

namespace Six.Input
{
    public struct Location : ILocation
    {
        public static readonly Location Nowhere = new Location(Source.FromString(string.Empty), 0, 0);

        private Location(Source source, int offset, int length)
        {
            Source = source;
            Offset = offset;
            Length = length;
        }

        public Source Source { get; }
        public int Offset { get; }
        public int Length { get; }

        public static Location From(Source source, int start)
        {
            return new Location(source, start, 0);
        }

        public static Location From(Source source, int offset, int length)
        {
            return new Location(source, offset, length);
        }

        public string GetText()
        {
            return Source.GetText(Offset, Length);
        }

        public override string ToString()
        {
            var (lineNo, colNo) = Source.GetLineAndColumn(Offset);

            return $"{Source.Name}:{lineNo}:{colNo}";
        }
    }
}
