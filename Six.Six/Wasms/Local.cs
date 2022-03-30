using Six.Six.Sema;

namespace Six.Six.Wasms
{
    public class Local
    {
        public Local(int index, string name, WasmType type)
        {
            Index = index;
            Name = name;
            Type = type;
        }

        public int Index { get; set; }
        public string Name { get; }
        public WasmType Type { get; }
    }
}
