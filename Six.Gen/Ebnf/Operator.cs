namespace Six.Gen.Ebnf
{
    public abstract class Operator : IReadOnlyList<Operator>
    {
        public Operator(params Operator[] arguments)
            : this(arguments.AsEnumerable())
        {
        }

        public Operator(IEnumerable<Operator> arguments)
        {
            Arguments = arguments.ToList();
        }

        protected void Set(params Operator[] arguments)
        {
            Arguments = arguments.ToList();
        }

        public int Id { get; set; } = -1;
        public List<Operator> Arguments { get; protected set; }
        public Operator Argument
        {
            get
            {
                Assert(Arguments.Count == 1);
                return Arguments[0];
            }
        }
        public bool Closed => Arguments.Count == 0;

        private void DumpInner(Writer writer)
        {
            foreach (var op in Arguments)
            {
                op.Dump(writer);
            }
        }

        //protected virtual string DumpHead => GetType().Name;
        protected abstract string DumpHead { get; }

        public virtual void Dump(Writer writer)
        {
            writer.WriteLine($"{DumpHead}");
            using (writer.Indent())
            {
                DumpInner(writer);
            }
        }

        public Operator this[int index] => Arguments[index];
        public int Count => Arguments.Count;
        public IEnumerator<Operator> GetEnumerator() => Arguments.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Arguments).GetEnumerator();
    }
}
