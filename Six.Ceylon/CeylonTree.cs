namespace Six.Ceylon
{
    public partial class CeylonTree
    {
        public partial class CPackagePath
        {
            public override string ToString()
            {
                return string.Join(".", Elements.AsEnumerable());
            }
        }

        public partial class CLowerIdentifier
        {
            public override string ToString()
            {
                var text = GetText();
                if (text.StartsWith("'") && text.EndsWith("'"))
                {
                    return text[1..^1];
                }
                return text;
            }
        }

        public partial class CUpperIdentifier
        {
            public override string ToString()
            {
                var text = GetText();
                if (text.StartsWith("'") && text.EndsWith("'"))
                {
                    return text[1..^1];
                }
                return text;
            }
        }
    }
}
