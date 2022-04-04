namespace Six.Six.Wasms
{
    public sealed class WaFuncSignature
    {
        private WaFuncSignature(string signature)
        {
            Signature = signature;
        }

        public string Signature { get; }

        public override bool Equals(object? obj)
        {
            return obj is WaFuncSignature other && other.Signature == Signature;
        }

        public override int GetHashCode()
        {
            return Signature.GetHashCode();
        }

        public override string ToString()
        {
            return Signature;
        }

        public static WaFuncSignature From(WaFunction function)
        {
            return From(function.Parameters.Select(p => p.Type), function.Results.Select(r => r.Type));
        }

        public static WaFuncSignature From(IEnumerable<WasmType> parameters, WasmType result)
        {
            return From(parameters, Enumerable.Repeat(result, 1));
        }

        public static WaFuncSignature From(IEnumerable<WasmType> parameters, IEnumerable<WasmType> results)
        {
            var builder = new StringBuilder();
            builder.Append("(param");
            foreach (var param in parameters)
            {
                builder.Append($" {param.Type}");
            }
            builder.Append($") (result");
            foreach (var result in results)
            {
                builder.Append($" {result.Type}");
            }
            builder.Append(')');

            var signature = builder.ToString();

            return new WaFuncSignature($"(func {signature})");
        }

    }
}
