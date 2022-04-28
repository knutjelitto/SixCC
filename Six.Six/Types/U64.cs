using Six.Six.Instructions;
using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Types
{
    public sealed class U64 : I64<Insn.Num.U64Impl, ulong>
    {
        protected override Insn.Num.U64Impl Impl => Insn.U64;

        public U64(Builtins builtins)
            : base(builtins, Names.Core.U64)
        {
        }

        public override Primitive Not(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            var ones = new Primitive.ConstU64(this, ulong.MaxValue);
            return Xor(new List<Expr> { ones, args[0] });
        }
    }
}
