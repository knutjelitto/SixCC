using Six.Six.Instructions;
using Six.Six.Sema;
using W = Six.Six.Wasms;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Six.Types
{
    public sealed class Address : Builtin
    {
        public Address(Builtins builtins)
            : base(builtins, Names.Core.Address, W.WasmType.Addr)
        {
            AddMethod(Module.DefaultCtor, 1, defaultCtor);
        }

        public Primitive defaultCtor(List<Expr> args)
        {
            Assert(args.Count == 1);

            var arg = args[0];

            Assert(Builtins.U32.IsThis(arg));

            return new Primitive.Arged(this, arg);
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
