namespace Six.Six.Wasms
{
    public abstract class WaInstruction
    {
        public WaInstruction(WaFunction function)
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
