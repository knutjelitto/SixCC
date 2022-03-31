namespace Six.Six.Wasms
{
    public class WaLocal : Wamber
    {
        public WaLocal(WaFunction function, string name, WasmType type)
        {
            Function = function;
            Name = name;
            Type = type;
        }

        public WaFunction Function { get; }
        public string Name { get; }
        public WasmType Type { get; }
        public int Index { get; set; } = -1;

        public void Emit()
        {
        }

        public void Prepare()
        {
        }
    }
}
