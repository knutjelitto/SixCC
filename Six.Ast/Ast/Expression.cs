namespace Six.Ast
{
    public abstract class Expression
    {
        protected Expression(ILocation location)
        {
            Location = location;
        }

        public abstract bool IsSimple { get; }
        public virtual bool IsCompact => this is Compact || this is Terminal;
        public int Id { get; set; } = -1;

        public ILocation Location { get; set; }

    }
}
