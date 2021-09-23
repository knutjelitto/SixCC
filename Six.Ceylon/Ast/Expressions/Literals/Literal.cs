namespace Six.Ceylon.Ast
{
    public abstract class Literal : Node, Expression
    {
        public Literal(Terminal terminal)
        {
            Terminal = terminal;
        }

        public Terminal Terminal { get; }

        public override string ToString()
        {
            return Terminal.ToString();
        }
    }
}
