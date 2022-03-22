using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Floating<TInsn, TValue> : Number<TInsn, TValue>
        where TInsn : Insn.Fnn<TValue>
        where TValue : struct
    {
        public Floating(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
            prefix.Add("-", Neg);
        }

        public Expr.Unop Neg(Expr right)
        {
            IsThis(right);

            return new Expr.Unop(this, Impl.Neg, right);
        }
    }
}
