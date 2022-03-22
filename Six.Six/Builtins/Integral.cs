using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Integral<TInsn, TValue> : Number<TInsn, TValue>
        where TInsn : Insn.Inn<TValue>
        where TValue : struct
    {
        public Integral(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
            prefix.Add("~", Not);
            infix.Add("&", And);
            infix.Add("|", Or);
            infix.Add("^", Xor);
        }

        public abstract Expr.Primitive Not(Expr arg);

        public Expr.Primitive And(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Impl.And, arg1, arg2);
        }

        public Expr.Primitive Or(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Impl.Or, arg1, arg2);
        }

        public Expr.Primitive Xor(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Impl.Xor, arg1, arg2);
        }
    }
}
