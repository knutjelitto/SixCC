using Six.Core;
using Six.Runtime;
using Six.Six.Sema;

namespace Six.Six.Instructions
{
    public class FunctionTable : WithWriter
    {
        private readonly Dictionary<string, (uint index, Decl.Funcy function)> table = new();

        public FunctionTable(Emitter emitter, string name)
            : base(emitter.Writer)
        {
            Emitter = emitter;
            Name = name;
        }

        public Emitter Emitter { get; }
        public string Name { get; }
    }
}
