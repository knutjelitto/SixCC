using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaClassyList : WaListOf<WaClassy>
    {
        public WaClassyList(WaModule module)
        {
            Module = module;
        }

        public WaModule Module { get; }
    }
}
