using Six.Runtime;

namespace Six.Six.Wasms
{
    public class FunctionTypes : WithWriter
    {
        private readonly Dictionary<string, uint> functionTypes = new();

        public FunctionTypes(Module module)
            : base(module.Writer)
        {
            Module = module;
        }

        public Module Module { get; }

        public void Emit()
        {
            if (functionTypes.Count > 0)
            {
                wl();
                foreach (var (funcType, index) in functionTypes.OrderBy(kv => kv.Value))
                {
                    wl($"(type $funcType{index} {funcType})");
                }
            }
        }

        public void Add(Function function)
        {
            var funcType = $"(func {function.Signature})";

            if (!functionTypes.TryGetValue(funcType, out var _))
            {
                var index = (uint)functionTypes.Count;

                functionTypes.Add(funcType, index);
            }
        }

        public string FindType(Function function)
        {
            var funcType = $"(func {function.Signature})";

            if (!functionTypes.TryGetValue(funcType, out var index))
            {
                index = (uint)functionTypes.Count;

                functionTypes.Add(funcType, index);
            }

            return $"$funcType{index}";
        }
    }
}
