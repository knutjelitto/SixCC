using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Integral<TInsn, TValue> : Number<TInsn, TValue>
        where TInsn : Insn.Num.Inn<TValue>
        where TValue : struct
    {
        public Integral(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
            AddPrefix("~", Not);

            AddInfix("&", And);
            AddInfix("|", Or);
            AddInfix("^", Xor);
        }

        public abstract Primitive Not(List<Expr> args);

        public Primitive And(List<Expr> args) => Binop(Impl.And, args);

        public Primitive Or(List<Expr> args) => Binop(Impl.Or, args);

        public Primitive Xor(List<Expr> args) => Binop(Impl.Xor, args);
    }
}
