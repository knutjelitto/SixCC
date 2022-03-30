using Six.Six.Sema;
using W = Six.Six.Wasms;

namespace Six.Six.Instructions
{
    public static class WasmsExtensions
    {
        public static W.Function ToFunction(this W.Module module, Decl.Funcy funcy)
        {
            var emitter = funcy.Module.Emitter;

            var function = new W.Function(module, funcy.FullName);

            foreach (var param in funcy.Parameters.Cast<Decl.Parameter>())
            {
                var type = emitter.Lower(param.Type).Wasm;

                function.Add(new W.Parameter(function, param.Name, type));
            }

            return function;
        }
    }
}
