using Six.Gen.Typing;
using Six.Rex;

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
        public bool IsLoop { get; set; }
        public ClassType? Class { get; set; }
        public InterfaceType? Interface { get; set; }
        public ClassType Base => Class!.Base!;

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

        public virtual void DumpTypes(Writer writer)
        {
            if (Class != null)
            {
                writer.WriteLine($":: {Class}");
            }
            if (Interface != null)
            {
                writer.WriteLine($":: {Interface}");
            }
        }

        public virtual void Dump(Writer writer)
        {
            writer.WriteLine($"{DumpHead}{Attributes}");
            using (writer.Indent())
            {
                DumpTypes(writer);
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
                if (IsLoop)
                {
                    builder.Append($"[L]");
                }
#if true
                if ((this is not RuleOp ruleOp || !ruleOp.Name.StartsWith("%")) && Class == null && Interface == null)
                {
                    builder.Append($"[!untyped]");
                }
#endif
                return builder.Length > 0 ? $" {builder}" : string.Empty;
            }
        }

        public override string ToString()
        {
            return DumpHead;
        }
    }
}
