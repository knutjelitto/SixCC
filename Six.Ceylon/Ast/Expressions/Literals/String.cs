namespace Six.Ceylon.Ast
{
    public sealed class String : Literal
    {
        public String(Terminal terminal) : base(terminal)
        {
        }

        public override string ToString()
        {
            var s = Terminal.ToString();
            if (s.Length <= 40)
            {
                return s;
            }
            return s[..36] + "...";
        }
    }
}
