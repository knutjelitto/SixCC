namespace Six.Six.Wasms
{
    public class WaParameterList : WaListOf<WaParameter>
    {
        public WaParameterList(WaFunction function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
