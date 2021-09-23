namespace SixCC.CC
{
    public static class Grammars
    {
        public static string Gamma21()
        {
            return ReadResource("Γ2.1");
        }

        public static string SixCC()
        {
            return ReadResource("SixCC");
        }

        public static string Expression()
        {
            return ReadResource("Expression");
        }

        public static string Json()
        {
            return ReadResource("Json");
        }

        public static string Wiki()
        {
            return ReadResource("Wikipedia");
        }

        public static string Bug()
        {
            return ReadResource("Bug");
        }

        public static string List()
        {
            return ReadResource("List");
        }

        public static string Ambiguous()
        {
            return ReadResource("Ambiguous");
        }

        public static string Expr()
        {
            return ReadResource("Expr");
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
