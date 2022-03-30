namespace Six.Six.Wasms
{
    public class Result
    {
        public Result(WasmType type)
        {
            Type = type;
        }

        public WasmType Type { get; }
    }
}
