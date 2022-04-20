using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Floating<TInsn, TValue> : Number<TInsn, TValue>
        where TInsn : Insn.Num.Fnn<TValue>
        where TValue : struct
    {
        public Floating(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
            AddPrefix("-", Neg);
            AddPrefix("+", Pos);
        }

        public Primitive.Unop Neg(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            return new Primitive.Unop(this, Impl.Neg, args[0]);
        }

        public Primitive.Unop Pos(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            return new Primitive.Unop(this, Impl.Nop, args[0]);
        }
    }
}
