using Six.Six.Sema;

namespace Six.Six.Wasms
{
    public class WaParameter
    {
        public WaParameter(WaFunction function, string name, WasmType type)
        {
            Function = function;
            Name = name;
            Type = type;
        }

        public int Index { get; set; }
        public WaFunction Function { get; }
        public string Name { get; }
        public WasmType Type { get; }
    }
}
