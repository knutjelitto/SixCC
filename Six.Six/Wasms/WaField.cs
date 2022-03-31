namespace Six.Six.Wasms
{
    public class WaField : Wamber
    {
        public WaField(string name, WasmType type)
        {
            Name = name;
            Type = type;
        }

        public void Prepare()
        {
        }

        public void Emit()
        {
        }

        public string Name { get; }
        public WasmType Type { get; }
        public uint Offset { get; set; }
    }
}
