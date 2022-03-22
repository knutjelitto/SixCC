using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public abstract class I32<TInsn, TValue> : Integral<TInsn, TValue>
        where TInsn : Insn.Inn<TValue>
        where TValue : struct
    {
        protected I32(Builtins builtins, string name)
            : base(builtins, name, WasmDef.I32)
        {
            infix.Add("%", Rem);
        }

        public Expr.Primitive Rem(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Expr.Binop(this, Impl.Rem, arg1, arg2);
        }
    }
}
