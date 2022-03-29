using Six.Six.Instructions;
using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public abstract class Number<TInsn, TValue> : Xnn<TInsn, TValue>
        where TInsn : Insn.Xnn<TValue>
        where TValue : struct
    {
        public Number(Builtins builtins, string name, WasmDef wasm)
            : base(builtins, name, wasm)
        {
            infix.Add("+", Add);
            infix.Add("-", Sub);
            infix.Add("*", Mul);
            infix.Add("/", Div);

            infix.Add("<=", LE);
            infix.Add("<", LT);
            infix.Add(">=", GE);
            infix.Add(">", GT);
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

        public Primitive Add(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(this, Impl.Add, left, right);
        }

        public Primitive Sub(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(this, Impl.Sub, left, right);
        }

        public Primitive Mul(Expr left, Expr right)
        {
            if (!IsThis(left))
            {
                Assert(false);
            }
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(this, Impl.Mul, left, right);
        }

        public Primitive Div(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(this, Impl.Div, left, right);
        }

        public Primitive LE(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(Builtins.Boolean, Impl.LE, left, right);
        }

        public Primitive LT(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(Builtins.Boolean, Impl.LT, left, right);
        }

        public Primitive GE(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(Builtins.Boolean, Impl.GE, left, right);
        }

        public Primitive GT(Expr left, Expr right)
        {
            Assert(IsThis(left));
            Assert(IsThis(right));

            return new Primitive.Binop(Builtins.Boolean, Impl.GT, left, right);
        }
    }
}
