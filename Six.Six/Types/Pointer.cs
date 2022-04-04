using Six.Six.Instructions;
using Six.Six.Sema;
using W = Six.Six.Wasms;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Six.Types
{
    public sealed class Pointer : Builtin
    {
        public Pointer(Builtins builtins)
            : base(builtins, Names.Core.Pointer, W.WasmType.Ptr)
        {
            AddMethod(Module.DefaultCtor, 1, defaultCtor);

            AddMethod("getPointer", 0, getPointer);
            AddMethod("getU32", 0, getU32);
            AddMethod("setVTable", 1, setVTable);
        }

        public Primitive defaultCtor(List<Expr> args)
        {
            Assert(args.Count == 1);

            var arg = args[0];

            Assert(Builtins.U32.IsThis(arg));

            return new Primitive.Arged(this, arg);
        }

        public Primitive getPointer(List<Expr> args)
        {
            Assert(args.Count == 0);

            return new Primitive.Instructions(this, Insn.Ptr.Load(0));
        }

        public Primitive getU32(List<Expr> args)
        {
            Assert(args.Count == 0);

            return new Primitive.Instructions(this, Insn.U32.Load(0));
        }

        public Primitive setVTable(List<Expr> args)
        {
            Assert(args.Count == 1);

            var arg = args[0];
            Assert(IsThis(arg));

            return new Primitive.Instructions(this, Insn.U32.Load(0));
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
