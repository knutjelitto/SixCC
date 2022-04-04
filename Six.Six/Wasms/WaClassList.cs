namespace Six.Six.Wasms
{
    public class WaClassList : WaListOf<WaClass>
    {
        public WaClassList(WaModule module)
            : base(module)
        {
            Module = module;
        }

        public WaModule Module { get; }
    }
}
