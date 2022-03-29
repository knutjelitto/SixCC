using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Builtins
{
    public sealed class Boolean : BuiltinCore
    {
        public Boolean(Builtins builtins)
            : base(builtins, Names.Core.Boolean, WasmDef.Boolean)
        {
            prefix.Add("!", Not);
            infix.Add("&", And);
            infix.Add("|", Or);
            infix.Add("^", Xor);
        }

        public override Insn Load(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        public override Insn Store(uint offset)
        {
            Assert(false);
            throw new NotImplementedException();
        }

        public Primitive Not(Expr arg)
        {
            Assert(IsThis(arg));

            var ones = new Primitive.ConstS32(this, -1);
            return Xor(ones, arg);
        }

        public Primitive And(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Insn.Boolean.And, arg1, arg2);
        }

        public Primitive Or(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Insn.Boolean.Or, arg1, arg2);
        }

        public Primitive Xor(Expr arg1, Expr arg2)
        {
            Assert(IsThis(arg1));
            Assert(IsThis(arg2));

            return new Primitive.Binop(this, Insn.Boolean.Xor, arg1, arg2);
        }
    }
}
