using Six.Runtime;

namespace Six.Six.Wasms
{
    public abstract class WaField : WithWriter, Wamber
    {
        protected WaField(IWithWriter withWriter, string name, WasmType type)
            : base(withWriter.Writer)
        {
            Name = name;
            Type = type;
        }

        public abstract void Prepare();
        public abstract void Emit();

        public string Name { get; }
        public WasmType Type { get; }
    }
}
