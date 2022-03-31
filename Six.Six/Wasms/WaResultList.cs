namespace Six.Six.Wasms
{
    public class WaResultList : WaListOf<WaResult>
    {
        public WaResultList(WaFunction function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
