using Six.Runtime;

namespace Six.Six.Wasms
{
    public abstract class WaInstruction : WithWriter, Wamber
    {
        public WaInstruction(IWithWriter withWriter)
            : base(withWriter.Writer)
        {
        }

        public virtual void Prepare()
        {
        }

        public abstract void Emit();
    }
}
