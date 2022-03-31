using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WAFunctionTypeList : WithWriter
    {
        private readonly Dictionary<string, WaFunctionType> functionTypes = new();

        public WAFunctionTypeList(WaModule module)
            : base(module.Writer)
        {
            Module = module;
        }

        public WaModule Module { get; }

        public void Emit()
        {
            if (functionTypes.Count > 0)
            {
                wl();
                foreach (var (funcType, index) in functionTypes.OrderBy(kv => kv.Value.Index))
                {
                    wl($"(type ${index.Name} {index.Signature})");
                }
            }
        }

        public WaFunctionType Add(WaFunction function)
        {
            var typeSignature = $"(func {function.Signature})";

            if (!functionTypes.TryGetValue(typeSignature, out var functionType))
            {
                var index = (uint)functionTypes.Count;

                functionType = new WaFunctionType(this, typeSignature, index);

                functionTypes.Add(typeSignature, functionType);
            }

            return functionType;
        }
    }
}
