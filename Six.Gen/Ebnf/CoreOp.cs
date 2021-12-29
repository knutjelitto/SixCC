using Six.Rex;
using System.Text;

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
        public FA? DFA { get; set; }

        public SortedSet<Instance> Instances { get; private set; } = new();
        public bool IsReached { get; set; }
        public bool IsSpare { get; set; }
        public bool MaybeAlias { get; set; }

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
            writer.WriteLine($"{DumpHead}{Attributes}");
            using (writer.Indent())
            {
                DumpInner(writer);
            }
        }

        public string Attributes
        {
            get
            {
                var builder = new StringBuilder();
                if (Instances.Count > 0)
                {
                    builder.Append($"[#{Instances.Count}]");
                }
                if (MaybeAlias)
                {
                    builder.Append($"[A]");
                }
                return builder.Length > 0 ? $" {builder}" : string.Empty;
            }
        }
    }
}
