using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public sealed class Pointer : BuiltinCore
    {
        public Pointer(Builtins builtins)
            : base(builtins, Names.Core.Pointer, WasmDef.Pointer)
        {
            AddMethod(Module.DefaultCtor, 1, defaultCtor);

            AddMethod("getPointer", 0, getPointer);
            AddMethod("getU32", 0, getU32);
            AddMethod("setVTable", 1, setVTable);
        }

        public Expr.Primitive defaultCtor(List<Expr> args)
        {
            Assert(args.Count == 1);

            var arg = args[0];

            Assert(Builtins.U32.IsThis(arg));

            return new Expr.Arged(this, arg);
        }

        public Expr.Primitive getPointer(List<Expr> args)
        {
            Assert(args.Count == 0);

            return new Expr.Instructions(this, Insn.Ptr.Load(0));
        }

        public Expr.Primitive getU32(List<Expr> args)
        {
            Assert(args.Count == 0);

            return new Expr.Instructions(this, Insn.U32.Load(0));
        }

        public Expr.Primitive setVTable(List<Expr> args)
        {
            Assert(args.Count == 1);

            var arg = args[0];
            Assert(IsThis(arg));

            return new Expr.Instructions(this, Insn.U32.Load(0));
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
