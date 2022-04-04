using Six.Runtime;

using Type = Six.Six.Sema.Type;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Instructions
{
    public class TypeTable : WithWriter
    {
        private readonly Dictionary<string, uint> functionTypes = new();

        public TypeTable(Emitter emitter)
            : base(emitter.Writer)
        {
            Emitter = emitter;
        }

        public Emitter Emitter { get; }
    }
}
