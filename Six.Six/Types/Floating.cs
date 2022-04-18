using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Floating<TInsn, TValue> : Number<TInsn, TValue>
        where TInsn : Insn.Num.Fnn<TValue>
        where TValue : struct
    {
        public Floating(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
            prefix.Add("-", Neg);
            prefix.Add("+", Pos);
        }

        public Primitive.Unop Neg(Expr arg)
        {
            IsThis(arg);

            return new Primitive.Unop(this, Impl.Neg, arg);
        }

        public Primitive.Unop Pos(Expr arg)
        {
            IsThis(arg);

            return new Primitive.Unop(this, Impl.Nop, arg);
        }
    }
}
