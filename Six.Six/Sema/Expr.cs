using Six.Six.Builtins;
using Six.Six.Instructions;
using System;

namespace Six.Six.Sema
{
    public interface Expr : Entity
    {
        Type Type { get; }

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

        public abstract record Const(Type Type, Insn Insn) : Primitive(Type);

        public sealed record ConstI32(Type Type, int Value) : Const(Type, Insn.I32.Const(Value));
        public sealed record ConstU32(Type Type, uint Value) : Const(Type, Insn.U32.Const(Value));
        public sealed record ConstI64(Type Type, long Value) : Const(Type, Insn.I64.Const(Value));
        public sealed record ConstU64(Type Type, ulong Value) : Const(Type, Insn.U64.Const(Value));
        public sealed record ConstString(Type Type, string Value) : Primitive(Type);

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

        public sealed record GlobalReference(Decl.Global GlobalDecl)
            : Reference(GlobalDecl);

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

        public sealed record CallFunction(Decl.Function Function, List<Expr> Arguments)
            : Primitive(Function.Type)
        {
            public CallFunction(Decl.Function Function) : this(Function, new List<Expr>())
            {
            }

            public override Type Type => Function.ResultType;
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

        public sealed record SelectField(Reference Reference, Decl.Field Field)
            : Primitive(Field.Type);

        public sealed record CallMember(Decl.Classy Classy, Decl.Function Function, Expr Make, params Expr[] Arguments)
            : Expr
        {
            public Type Type => Function.ResultType;
        }

        public sealed record CallInfixMember(Decl.Classy Classy, Decl.Function Function, Expr Arg1, Expr Arg2)
            : Expr
        {
            public Type Type => Function.ResultType;
        }

        public sealed record CallPrefixMember(Decl.Classy Classy, Decl.Function Function, Expr Arg)
            : Expr
        {
            public Type Type => Function.ResultType;
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

    public sealed record LazyExpr : Entity
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
}
