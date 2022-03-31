using Six.Runtime;

namespace Six.Six.Wasms
{
    public abstract class WaInstruction : WithWriter, Wamber
    {
        public WaInstruction(WaFunction function)
            : base(function.Writer)
        {
            Function = function;
        }

        public WaFunction Function { get; }

        public virtual void Prepare()
        {
        }

        public abstract void Emit();
    }
}
