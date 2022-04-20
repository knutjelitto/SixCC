using Six.Six.Instructions;
using Six.Six.Sema;
using Six.Six.Wasms;

namespace Six.Six.Types
{
    public abstract class Number<TInsn, TValue> : Xnn<TInsn, TValue>
        where TInsn : Insn.Num.Xnn<TValue>
        where TValue : struct
    {
        public Number(Builtins builtins, string name, WasmType wasm)
            : base(builtins, name, wasm)
        {
            AddInfix("+", Add);
            AddInfix("-", Sub);
            AddInfix("*", Mul);
            AddInfix("/", Div);

            AddInfix("==", EQ);
            AddInfix("!=", NE);

            AddInfix("<=", LE);
            AddInfix("<", LT);
            AddInfix(">=", GE);
            AddInfix(">", GT);
        }

        protected abstract TInsn Impl { get; }

        public override Insn Load(uint offset)
        {
            return Impl.Load(offset);
        }

        public override Insn Store(uint offset)
        {
            return Impl.Store(offset);
        }

        public Primitive Add(List<Expr> args) => Binop(Impl.Add, args);

        public Primitive Sub(List<Expr> args) => Binop(Impl.Sub, args);

        public Primitive Mul(List<Expr> args) => Binop(Impl.Mul, args);

        public Primitive Div(List<Expr> args) => Binop(Impl.Div, args);

        public Primitive EQ(List<Expr> args) => PredBinop(Impl.EQ, args);

        public Primitive NE(List<Expr> args) => PredBinop(Impl.NE, args);

        public Primitive LE(List<Expr> args) => PredBinop(Impl.LE, args);

        public Primitive LT(List<Expr> args) => PredBinop(Impl.LT, args);

        public Primitive GE(List<Expr> args) => PredBinop(Impl.GE, args);

        public Primitive GT(List<Expr> args) => PredBinop(Impl.GT, args);
    }
}
