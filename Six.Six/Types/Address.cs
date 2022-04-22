using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public sealed class Address : Builtin
    {
        public Address(Builtins builtins)
            : base(builtins, Names.Core.Address, WasmType.Addr)
        {
            AddMethod(Module.DefaultCtor, 1, DefaultCtor);
        }

        public Primitive DefaultCtor(List<Expr> args)
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
