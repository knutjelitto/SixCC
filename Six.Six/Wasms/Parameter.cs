using Six.Six.Sema;

namespace Six.Six.Wasms
{
    public class Parameter
    {
        public Parameter(Function function, string name, WasmType type)
        {
            Function = function;
            Name = name;
            Type = type;
        }

        public int Index { get; set; }
        public Function Function { get; }
        public string Name { get; }
        public WasmType Type { get; }
    }
}
