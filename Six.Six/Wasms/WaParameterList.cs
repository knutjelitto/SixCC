namespace Six.Six.Wasms
{
    public class WaParameterList : WaListOf<WaParameter>
    {
        public WaParameterList(WaFunction function)
            : base(function)
        {
            Function = function;
        }

        public WaFunction Function { get; }
    }
}
