using Six.Six.Builtins;
using Six.Six.Instructions;
using System;

namespace Six.Six.Sema
{
    public interface Expr : Entity
    {
        public sealed record Delayed : Expr
        {
            public Concrete? Resolved { get; set; } = null;
        }

        public interface Concrete : Expr
        {
            Type? Type { get; set; }
        }

        public abstract record ConcreteExpr : Concrete
        {
            public ConcreteExpr()
            {
            }

            public ConcreteExpr(Type? type)
            {
                Type = NominalType = type;
            }

            public virtual Type? NominalType { get; set; }

            public virtual Type? Type { get; set; }
        }

        public abstract record Primitive : ConcreteExpr
        {
            public Primitive(Type Type) : base(Type)
            {
            }
        }

        public abstract record Const(Builtin Builtin, Insn Insn) : Primitive(Builtin);

        public sealed record ConstI32(Builtin Builtin, int Value) : Const(Builtin, Insn.I32.Const(Value));
        public sealed record ConstU32(Builtin Builtin, uint Value) : Const(Builtin, Insn.U32.Const(Value));
        public sealed record ConstI64(Builtin Builtin, long Value) : Const(Builtin, Insn.I64.Const(Value));
        public sealed record ConstU64(Builtin Builtin, ulong Value) : Const(Builtin, Insn.U64.Const(Value));

        public sealed record Binop(Builtin Builtin, Insn Insn, Concrete Arg1, Concrete Arg2)
            : Primitive(Builtin);

        public sealed record Unop(Builtin Builtin, Insn Insn, Concrete Arg)
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

        public sealed record PrimitiveReference(Decl.Primitive PrimitiveDecl)
            : ClassyReference(PrimitiveDecl);

        public sealed record ObjectReference(Decl.Object ObjectDecl)
            : ClassyReference(ObjectDecl);

        public sealed record ClassReference(Decl.Class ClassDecl)
            : ClassyReference(ClassDecl);

        public sealed record InterfaceReference(Decl.Interface InterfaceDecl)
            : ClassyReference(InterfaceDecl);

        public abstract record Reference(Decl Decl)
            : ConcreteExpr
        {
            public override Type? Type => Decl.Type;
        }

        public sealed record CallFunction(FunctionReference Function, List<Concrete> Arguments)
            : Primitive(Function.Type!)
        {
            public override Type? Type { get => Function.Type; set => Function.Type = value; }
        }
            
        public sealed record CallIndirect(Concrete Value, Type.Callable Callable, List<Concrete> Arguments)
            : Primitive(Callable)
        {
        }

        public sealed record SelectAttribute(ClassyReference Reference, Decl.Attribute Attribute, Type Type)
            : Primitive(Type);

        public sealed record SelectParameter(ClassyReference Reference, Decl.Attribute Attribute, Type Type)
            : Primitive(Type);

        public sealed record CallMember(Type.Callable Callable, Expr Make, params Expr[] Arguments)
            : ConcreteExpr
        {
            public override Type? Type => Callable.Result;
        }
    }
}
