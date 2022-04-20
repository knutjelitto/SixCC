using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaFunctionTypeList : WithWriter, Wamber
    {
        private readonly Dictionary<WaFuncSignature, WaFunctionType> functionTypes = new();

        public WaFunctionTypeList(WaModule module)
            : base(module.Writer)
        {
            Module = module;
        }

        public WaModule Module { get; }


        public void Prepare()
        {
            foreach (var sign in functionTypes.Values)
            {
                sign.Prepare();
            }
        }

        public void Emit()
        {
            if (functionTypes.Count > 0)
            {
                wl();
                foreach (var sign in functionTypes.Values.OrderBy(sign => sign.Index))
                {
                    sign.Emit();
                }
            }
        }

        public WaFunctionType Get(WaFuncSignature signature)
        {
            if (!functionTypes.TryGetValue(signature, out var functionType))
            {
                var index = (uint)functionTypes.Count;

                functionType = new WaFunctionType(this, signature, index);

                functionTypes.Add(signature, functionType);
            }

            return functionType;
        }

        public WaFunctionType Add(WaFunction function)
        {
            return Get(function.Signature);
        }
    }
}
