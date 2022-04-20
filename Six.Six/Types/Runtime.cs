using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class Runtime : Builtin
    {
        public Runtime(Builtins builtins)
            : base(builtins, Names.Core.Runtime, WasmType.Void)
        {
            AddMethod(nameof(Print), 1, Print);
            AddMethod(nameof(Identical), 2, Identical);
            AddMethod(nameof(IdentityHash), 1, IdentityHash);
        }

        public Primitive Print(List<Expr> args)
        {
            Assert(args.Count == 1);

            var call = Insn.Call($"six.core.RT.{nameof(Print)}");

            return new Primitive.Unop(this, call, args[0]);
        }

        public Primitive Identical(List<Expr> args)
        {
            Assert(args.Count == 2);

            return new Primitive.Instructions(this, Insn.Boolean.False);
        }

        public Primitive IdentityHash(List<Expr> args)
        {
            Assert(args.Count == 1);

            return new Primitive.Instructions(this, Insn.S32.Const(0));
        }

        public override Insn Load(uint offset)
        {
            return Insn.U32.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Insn.U32.Store(offset);
        }
    }
}
