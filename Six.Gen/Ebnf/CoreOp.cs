namespace Six.Gen.Ebnf
{
    public abstract class CoreOp
    {
        public CoreOp(ILocation location, params CoreOp[] arguments)
            : this(location, arguments.AsEnumerable())
        {
        }

        public CoreOp(ILocation location, IEnumerable<CoreOp> arguments)
        {
            Location = location;
            Arguments = arguments.ToList();
        }

        public void Patch(params CoreOp[] arguments)
        {
            Arguments = arguments.ToList();
        }

        public void Patch(ILocation location)
        {
            Location = location;
        }

        public ILocation Location { get; private set; }
        public int Id { get; set; } = -1;
        public bool IsReached { get; set; }
        public bool TokenReached { get; set; }
        public List<CoreOp> Arguments { get; protected set; }
        public CoreOp Argument
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
                if (IsReached || TokenReached)
                {
                    return " [" + (IsReached ? "R" : "") + (TokenReached ? "T" : "") + "]";
                }
                return string.Empty;
            }
        }
    }
}
