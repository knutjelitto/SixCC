namespace Six.Six.Wasms
{
    public class WaLocalList : WaListOf<WaLocal>
    {
        public WaLocalList(WaFunction function)
            : base(function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
