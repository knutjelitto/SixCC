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
            prefix.Add("~", Not);
            infix.Add("&", And);
            infix.Add("|", Or);
            infix.Add("^", Xor);
        }

        public abstract Primitive Not(Expr arg);

        public Primitive And(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.And, arg1, arg2);
        }

        public Primitive Or(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Or, arg1, arg2);
        }

        public Primitive Xor(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Xor, arg1, arg2);
        }
    }
}
