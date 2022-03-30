using Six.Six.Instructions;
using Six.Six.Sema;

using W = Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class I32<TInsn, TValue> : Integral<TInsn, TValue>
        where TInsn : Insn.Inn<TValue>
        where TValue : struct
    {
        protected I32(Builtins builtins, string name)
            : base(builtins, name, W.WasmType.I32)
        {
            infix.Add("%", Rem);
        }

        public Primitive Rem(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Impl.Rem, arg1, arg2);
        }
    }
}
