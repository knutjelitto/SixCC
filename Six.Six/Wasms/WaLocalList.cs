namespace Six.Six.Wasms
{
    public class WaLocalList : WaListOf<WaLocal>
    {
        public WaLocalList(WaFunction function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
