namespace Six.Gen.Ebnf
{
    public abstract class Operator : IReadOnlyList<Operator>
    {
        public List<Operator> Arguments { get; }

        public Operator(params Operator[] arguments)
            : this(arguments.AsEnumerable())
        {
        }

        public Operator(IEnumerable<Operator> arguments)
        {
            Arguments = arguments.ToList();
        }

        private void DumpInner(Writer writer)
        {
            foreach (var op in Arguments)
            {
                op.Dump(writer);
            }
        }

        protected virtual string DumpHead => GetType().Name;

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
