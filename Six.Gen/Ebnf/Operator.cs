namespace Six.Gen.Ebnf
{
    public abstract class Operator : IReadOnlyList<Operator>
    {
        public Operator(ILocation location, params Operator[] arguments)
            : this(location, arguments.AsEnumerable())
        {
        }

        public Operator(ILocation location, IEnumerable<Operator> arguments)
        {
            Location = location;
            Arguments = arguments.ToList();
        }

        public void Set(params Operator[] arguments)
        {
            Arguments = arguments.ToList();
        }

        public void Set(ILocation location)
        {
            Location = location;
        }

        public ILocation Location { get; private set; }
        public int Id { get; set; } = -1;
        public bool RuleReached { get; set; }
        public bool TokenReached { get; set; }
        public List<Operator> Arguments { get; protected set; }
        public Operator Argument
        {
            get
            {
                Assert(Arguments.Count == 1);
                return Arguments[0];
            }
        }
        public bool HasArguments => Arguments.Count > 0;

        private void DumpInner(Writer writer)
        {
            foreach (var op in Arguments)
            {
                op.Dump(writer);
            }
        }
        protected abstract string DumpHead { get; }

        public virtual void Dump(Writer writer)
        {
            writer.WriteLine($"{DumpHead}{Reached}");
            using (writer.Indent())
            {
                DumpInner(writer);
            }
        }

        public string Reached
        {
            get
            {
                if (RuleReached || TokenReached)
                {
                    return " [" + (RuleReached ? "R" : "") + (TokenReached ? "T" : "") + "]";
                }
                return string.Empty;
            }
        }

        public Operator this[int index] => Arguments[index];
        public int Count => Arguments.Count;
        public IEnumerator<Operator> GetEnumerator() => Arguments.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Arguments).GetEnumerator();
    }
}
