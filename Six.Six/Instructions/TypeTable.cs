using Six.Runtime;

using Type = Six.Six.Sema.Type;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Instructions
{
    public class TypeTable : WithWriter
    {
        private readonly Dictionary<string, uint> functionTypes = new();

        public TypeTable(Emitter emitter)
            : base(emitter.Writer)
        {
            Emitter = emitter;
        }

        public Emitter Emitter { get; }

        public void Emit()
        {
            if (functionTypes.Count > 0)
            {
                foreach (var (name, index) in functionTypes.OrderBy(kv => kv.Value))
                {
                    wl($"(type $funcType{index} {name})");
                }
            }
        }

        public string FindType(Type.Callable callable)
        {
            var funcType = FuncType(callable);

            if (!functionTypes.TryGetValue(funcType, out var index))
            {
                index = (uint)functionTypes.Count;

                functionTypes.Add(funcType, index);
            }

            return $"$funcType{index}";
        }

        private string FuncType(Type.Callable callable)
        {
            return $"(func {Signature(callable)})";
        }

        private string Signature(Type.Callable callable)
        {
            var builder = new StringBuilder();
            builder.Append("(param");
            foreach (var param in callable.Parameters)
            {
                builder.Append($" {Emitter.WasmTypeFor(param)}");
            }
            builder.Append($") (result");
            if (!Emitter.IsAnythingAkaVoid(callable.Result))
            {
                builder.Append($" {Emitter.WasmTypeFor(callable.Result)}");
            }
            builder.Append(')');

            return builder.ToString();
        }
    }
}
