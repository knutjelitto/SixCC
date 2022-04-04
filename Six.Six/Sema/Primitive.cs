using Six.Six.Instructions;
using Six.Six.Types;

namespace Six.Six.Sema
{
    public abstract record Primitive : Expr.ConcreteExpr
    {
        public Primitive(Type Type)
            : base(Type)
        {
        }

        public record ToDo : Primitive
        {
            public ToDo(Type type, string text, params Expr[] exprs)
                : base(type)
            {
                Text = text;
                Exprs = exprs;
            }

            public string Text { get; }
            public Expr[] Exprs { get; }
        }

        public record Const(Type Type, Insn Insn) : Primitive(Type);

        public sealed record ConstS32(Type Type, int Value) : Const(Type, Insn.S32.Const(Value));
        public sealed record ConstU32(Type Type, uint Value) : Const(Type, Insn.U32.Const(Value));
        public sealed record ConstS64(Type Type, long Value) : Const(Type, Insn.S64.Const(Value));
        public sealed record ConstU64(Type Type, ulong Value) : Const(Type, Insn.U64.Const(Value));
        public sealed record ConstNatural(Type Type, ulong Value) : Primitive(Type);
        public sealed record ConstString(Type Type, string Value) : Primitive(Type);

        //TODO:
        public sealed record AllocClass(Decl.Class Class) : Primitive(Class.Type);

        public sealed record Arged(Builtin Builtin, Expr Arg)
            : Primitive(Builtin);

        public sealed record Binop(Builtin Builtin, Insn Insn, Expr Arg1, Expr Arg2)
            : Primitive(Builtin);

        public sealed record Unop(Builtin Builtin, Insn Insn, Expr Arg)
            : Primitive(Builtin);

        public sealed record Instructions(Builtin Builtin, params Insn[] Insns)
            : Primitive(Builtin);

    }
}
