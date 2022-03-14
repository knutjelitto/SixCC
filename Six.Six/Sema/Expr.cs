using Six.Six.Builtins;
using Six.Six.Instructions;
using System;

namespace Six.Six.Sema
{
    public interface Expr : Expression
    {
        Type Type { get; }
    }

    public sealed record LazyExpr : Expression
    {
        private Expr? expr = null;
        private readonly Func<Expr> resolver;

        public LazyExpr(Module module, Func<Expr> resolver)
        {
            Module = module;
            this.resolver = resolver;
        }

        public Module Module { get; }
        public Builtins.Builtins Builtins => Module.Builtins;

        public Expr Expr => expr ??= resolver();
    }

    public interface Expression : Entity
    {
        public abstract record ConcreteExpr : Expr
        {
            public ConcreteExpr(Type type)
            {
                Type = type;
            }

            public virtual Type Type { get; set; }
        }

        public abstract record Primitive : ConcreteExpr
        {
            public Primitive(Type Type)
                : base(Type)
            {
            }
        }

        public abstract record Const(Builtin Builtin, Insn Insn) : Primitive(Builtin);

        public sealed record ConstI32(Builtin Builtin, int Value) : Const(Builtin, Insn.I32.Const(Value));
        public sealed record ConstU32(Builtin Builtin, uint Value) : Const(Builtin, Insn.U32.Const(Value));
        public sealed record ConstI64(Builtin Builtin, long Value) : Const(Builtin, Insn.I64.Const(Value));
        public sealed record ConstU64(Builtin Builtin, ulong Value) : Const(Builtin, Insn.U64.Const(Value));

        //TODO:
        public sealed record AllocClass(Decl.Class Class) : Primitive(Class.Type);

        public sealed record Binop(Builtin Builtin, Insn Insn, Expr Arg1, Expr Arg2)
            : Primitive(Builtin);

        public sealed record Unop(Builtin Builtin, Insn Insn, Expr Arg)
            : Primitive(Builtin);

        public sealed record FunctionReference(Decl.Function FunctionDecl)
            : Reference(FunctionDecl);

        public sealed record ConstructorReference(Decl.Constructor ConstructorDecl)
            : Reference(ConstructorDecl);

        public sealed record ParameterReference(Decl.Local ParameterDecl)
            : Reference(ParameterDecl);

        public sealed record LocalReference(Decl.Local LocalDecl)
            : Reference(LocalDecl);

        public sealed record AttributeReference(Decl.Attribute AttributeDecl)
            : Reference(AttributeDecl);

        public abstract record ClassyReference(Decl.Classy ClassyDecl)
            : Reference(ClassyDecl);

        public sealed record ObjectReference(Decl.Object ObjectDecl)
            : ClassyReference(ObjectDecl);

        public sealed record ClassReference(Decl.Class ClassDecl)
            : ClassyReference(ClassDecl);

        public sealed record InterfaceReference(Decl.Interface InterfaceDecl)
            : ClassyReference(InterfaceDecl);

        public abstract record Reference(Decl Decl) : Expr
        {
            public Type Type => Decl.Type;
        }

        public sealed record CallFunction(FunctionReference Function, List<Expr> Arguments)
            : Primitive(Function.Type!)
        {
            public override Type Type => Function.FunctionDecl.ResultType;
        }


        public sealed record CallConstructor(Decl.Class Class, Decl.Constructor Ctor, List<Expr> Arguments)
            : Primitive(Ctor.Type)
        {
            public override Type Type => Ctor.ResultType;
        }
        public sealed record CallIndirect(Expr Value, Type.Callable Callable, List<Expr> Arguments)
            : Primitive(Callable)
        {
            public override Type Type => Callable.Result;
        }

        public sealed record SelectAttribute(Reference Reference, Decl.Attribute Attribute)
            : Primitive(Attribute.Type);

        public sealed record CallMember(Type.Callable Callable, Expression Make, params Expression[] Arguments)
            : Expr
        {
            public Type Type => Callable.Result;
        }

        public sealed record AndThen(LazyExpr And, LazyExpr Then) : Expr
        {
            public Type Type => And.Builtins.Boolean;
        }

        public sealed record If(LazyExpr Condition, LazyExpr Then, LazyExpr Else) : Expr
        {
            public Type Type
            {
                get
                {
                    Assert(ReferenceEquals(Then.Expr.Type, Else.Expr.Type));
                    return Then.Expr.Type;
                }
            }
        }
    }
}
