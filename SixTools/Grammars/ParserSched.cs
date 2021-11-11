namespace SixTools.Grammars
{
    internal class ParserSched
    {
        public static readonly Parser[] Parsers = new[]
        {
            (Parser)
            new SixgParser(),
            new WsnParser(),
            new Antlr4Parser(),
        };

        public static Parser? Match(string sourceName)
        {
            var ext = Path.GetExtension(sourceName);

            foreach (var parser in Parsers)
            {
                if (parser.PreferedExtension == ext)
                {
                    return parser;
                }
            }

            return null;
        }

    }
}
