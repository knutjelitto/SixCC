namespace Six.Six.Wasms
{
    public abstract class Instruction
    {
        public Instruction(Function function)
        {
            Function = function;
        }

        public Function Function { get; }

        public virtual void Prepare()
        {
        }

        public virtual void Emit()
        {
        }
    }
}
