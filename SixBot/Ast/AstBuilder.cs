namespace SixBot.Ast
{
    internal static class AstBuilder
    {
        public static Grammar Grammar(string name, params Rule[] rules)
        {
            return new Grammar(name, rules);
        }

        public static Rule Rule(string name, Expression first, params Expression[] more)
        {
            if (more.Length == 0)
            {
                return new Rule(name, first);
            }
            return new Rule(name, new Alt(Enumerable.Repeat(first, 1).Concat(more).ToArray()));
        }

        public static Alt Alt(params Expression[] expressions)
        {
            return new Alt(expressions);
        }

        public static Seq Seq(params Expression[] expressions)
        {
            return new Seq(expressions);
        }

        public static Terminal T(string literal)
        {
            return new Terminal(literal);
        }

        public static Nonterminal N(string name)
        {
            return new Nonterminal(name);
        }
    }
}
