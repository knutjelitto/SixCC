using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;
using System;

namespace Six.Six.Types
{
    public class Boolean : Builtin
    {
        public Boolean(Builtins builtins, string? name = null)
            : base(builtins, name ?? Names.Core.Boolean, WasmType.Bool)
        {
            AddPrefix("!", Not);

            AddInfix("&", And);
            AddInfix("|", Or);
            AddInfix("^", Xor);
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

        public Primitive Not(List<Expr> args)
        {
            Assert(args.Count == 1);
            Assert(IsThis(args[0]));

            var ones = new Primitive.ConstS32(this, -1);
            return Xor(new List<Expr> { ones, args[0] });
        }

        public Primitive And(List<Expr> args) => Binop(Insn.Boolean.And, args);

        public Primitive Or(List<Expr> args) => Binop(Insn.Boolean.Or, args);

        public Primitive Xor(List<Expr> args) => Binop(Insn.Boolean.Xor, args);

        public class True : Boolean
        {
            public True(Builtins builtins)
                : base(builtins, Names.Core.True)
            {
            }
        }

        public class False : Boolean
        {
            public False(Builtins builtins)
                : base(builtins, Names.Core.False)
            {
            }
        }
    }
}
