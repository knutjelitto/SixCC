﻿using Six.Six.Instructions;
using Six.Six.Sema;
using System;

namespace Six.Six.Builtins
{
    public class S32 : I32<Insn.S32Impl, int>
    {
        protected override Insn.S32Impl Impl => Insn.S32;

        public S32(Builtins builtins) : base(builtins, Names.Core.S32)
        {
            prefix.Add("-", Neg);
        }

        public Expr.Primitive Neg(Expr right)
        {
            Assert(IsThis(right));

            var zero = new Expr.ConstS32(this, 0);
            return Sub(zero, right);
        }

        public override Expr.Primitive Not(Expr arg)
        {
            Assert(IsThis(arg));

            var ones = new Expr.ConstS32(this, -1);
            return Xor(ones, arg);
        }

    }
}
