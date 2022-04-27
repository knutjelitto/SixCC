using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Inn<TInsn, TValue> : Integral<TInsn, TValue>
        where TInsn : Insn.Num.Inn<TValue>
        where TValue : struct
    {
        protected Inn(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
            AddPrefix("+", Pos);

            AddInfix("%", Rem);
            AddInfix("<<", Shl);
            AddInfix(">>", Shr);
        }

        public Primitive.Unop Pos(List<Expr> args)
        {
            Assert(args.Count == 1);
            IsThis(args[0]);

            return new Primitive.Unop(this, Impl.Nop, args[0]);
        }

        public Primitive Rem(List<Expr> args) => Binop(Impl.Rem, args);

        public Primitive Shl(List<Expr> args) => Binop(Impl.Shl, args);

        public Primitive Shr(List<Expr> args) => Binop(Impl.Shr, args);
    }
}
