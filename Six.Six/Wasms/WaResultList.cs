namespace Six.Six.Wasms
{
    public class WaResultList : WaListOf<WaResult>
    {
        public WaResultList(WaFunction function)
            : base(function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
