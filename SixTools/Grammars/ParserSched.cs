namespace SixTools.Grammars
{
    internal class ParserSched
    {
        public static readonly Parser[] Parsers = new[]
        {
            (Parser)
            new SixgParser(),
            new Antlr4Parser(),
        };

        public static Parser? Match(string sourceName)
        {
            var ext = Path.GetExtension(sourceName);

            foreach (var parser in Parsers)
            {
                if (parser.Extension == ext)
                {
                    return parser;
                }
            }

            return null;
        }

    }
}
