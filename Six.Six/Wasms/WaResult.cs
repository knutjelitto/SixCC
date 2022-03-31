namespace Six.Six.Wasms
{
    public class WaResult : Wamber
    {
        public WaResult(WasmType type)
        {
            Type = type;
        }

        public WasmType Type { get; }

        public void Prepare()
        {
        }

        public void Emit()
        {
        }
    }
}
