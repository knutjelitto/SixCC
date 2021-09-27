namespace SixCC.CC
{
    public class GrammarSource
    {
        public GrammarSource(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; }
        public string Text { get; }
    }

    public static class Grammars
    {
        private static GrammarSource Read(string name)
        {
            return new GrammarSource(name, ReadResource(name));
        }

        public static GrammarSource Gamma21()
        {
            return Read("Gamma21");
        }

        public static GrammarSource SixCC()
        {
            return Read("SixCC");
        }

        public static GrammarSource Expression()
        {
            return Read("Expression");
        }

        public static GrammarSource Json()
        {
            return Read("Json");
        }

        public static GrammarSource Wiki()
        {
            return Read("Wiki");
        }

        public static GrammarSource Bug()
        {
            return Read("Bug");
        }

        public static GrammarSource List()
        {
            return Read("List");
        }

        public static GrammarSource Ambiguous()
        {
            return Read("Ambiguous");
        }

        public static GrammarSource Expr()
        {
            return Read("Expr");
        }

        private static string ReadResource(string grammarName)
        {
            var assembly = typeof(Grammars).Assembly;
            var name = $"{typeof(Grammars).FullName}.{grammarName}.sixg";
            using (var stream = assembly.GetManifestResourceStream(name)!)
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
