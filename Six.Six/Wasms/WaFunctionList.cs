using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFunctionList : WaListOf<WaFunction>
    {
        public WaFunctionList(IWithWriter withWriter)
            : base(withWriter)
        {
        }
    }
}
