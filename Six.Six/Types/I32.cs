using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class I32<TInsn, TValue> : Integral<TInsn, TValue>
        where TInsn : Insn.Num.Inn<TValue>
        where TValue : struct
    {
        protected I32(Builtins builtins, string name)
            : base(builtins, name, WasmType.I32)
        {
            prefix.Add("+", Pos);

            infix.Add("%", Rem);
            infix.Add("<<", Shl);
            infix.Add(">>", Shr);
        }

        public Primitive.Unop Pos(Expr arg)
        {
            IsThis(arg);

            return new Primitive.Unop(this, Impl.Nop, arg);
        }

        public Primitive Rem(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Rem, arg1, arg2);
        }

        public Primitive Shl(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Shl, arg1, arg2);
        }

        public Primitive Shr(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Shr, arg1, arg2);
        }
    }
}
