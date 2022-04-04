using Six.Runtime;

namespace Six.Six.Wasms
{
    public sealed class WaDispatch : WithWriter, Wamber
    {
        public WaDispatch(WaClass clazz, string functionName)
            : base(clazz.Writer)
        {
            Class = clazz;
            FunctionName = functionName;
        }

        public WaClass Class { get; }
        public string FunctionName { get; }
        public WaFunction? Function { get; private set; }
        public int Index { get; set; } = -1;

        public void Prepare()
        {
            Assert(Index >= 0);
            Function = Class.Module.FindFunction(FunctionName);
        }

        public void Emit()
        {
            wl($"(; {Index,4} ;) (ref.func ${FunctionName})");
        }

        public override bool Equals(object? obj)
        {
            return obj is WaDispatch other && other.FunctionName == FunctionName;
        }

        public override int GetHashCode()
        {
            return FunctionName.GetHashCode();
        }
    }
}
