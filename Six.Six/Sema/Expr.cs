﻿using Six.Six.Builtins;
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
        public sealed record ConstString(Type Type, Func<Ptr> Resolve) : Primitive(Type);

        //TODO:
        public sealed record AllocClass(Decl.Class Class) : Primitive(Class.Type);

        public sealed record Arged(BuiltinCore Builtin, Expr Arg)
            : Primitive(Builtin);

        public sealed record Binop(BuiltinCore Builtin, Insn Insn, Expr Arg1, Expr Arg2)
            : Primitive(Builtin);

        public sealed record Unop(BuiltinCore Builtin, Insn Insn, Expr Arg)
            : Primitive(Builtin);

        public sealed record Instructions(BuiltinCore Builtin, params Insn[] Insns)
            : Primitive(Builtin);

        public abstract record Reference(Decl Decl) : Expr
        {
            public Type Type => Decl.Type;
        }

        public sealed record FunctionReference(Decl.Function FunctionDecl)
            : Reference(FunctionDecl);

        public sealed record ConstructorReference(Decl.Constructor ConstructorDecl)
            : Reference(ConstructorDecl);

        public sealed record ParameterReference(Decl.Local ParameterDecl)
            : Reference(ParameterDecl);

        public sealed record LocalReference(Decl.Local LocalDecl)
            : Reference(LocalDecl);

        public sealed record AliasReference(Decl.Alias AliasDecl)
            : Reference(AliasDecl);

        public sealed record FieldReference(Decl.Field FieldDecl)
            : Reference(FieldDecl);

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

        public abstract record CallFunction(Decl.Funcy Funcy, List<Expr> Arguments)
            : Primitive(Funcy.Type)
        {
            public CallFunction(Decl.Funcy Funcy) : this(Funcy, new List<Expr>())
            {
            }

            public override Type Type => Funcy.ResultType;

            public static CallFunction From(Decl.Funcy funcy, params Expr[] arguments)
            {
                return From(funcy, arguments.ToList());
            }

            public static CallFunction From(Decl.Funcy funcy, List<Expr> arguments)
            {
                if (funcy.IsStatic || funcy.IsLocalFunction || funcy.IsGlobalFunction)
                {
                    return new CallStaticFunction(funcy, arguments);
                }
                else if (funcy.IsObjectMember)
                {
                    if (funcy.Parent is ClassBlock classBlock)
                    {
                        if (funcy.IsDynamic)
                        {
                            return new CallDynamicFunction(classBlock.Classy, funcy, arguments);
                        }
                        else
                        {
                            return new CallMemberFunction(classBlock.Classy, funcy, arguments);
                        }
                    }
                    else
                    {
                        Assert(false);
                        throw new NotImplementedException();
                    }
                }
                else
                {
                    Assert(false);
                    throw new NotImplementedException();
                }
            }
        }

        public sealed record CallStaticFunction(Decl.Funcy Funcy, List<Expr> Arguments)
            : CallFunction(Funcy, Arguments);

        public sealed record CallMemberFunction(Decl.Classy Classy, Decl.Funcy Funcy, List<Expr> Arguments)
            : CallFunction(Funcy, Arguments);

        public sealed record CallDynamicFunction(Decl.Classy Classy, Decl.Funcy Funcy, List<Expr> Arguments)
            : CallFunction(Funcy, Arguments);

        public sealed record CallConstructor(Decl.Class Class, Decl.Constructor Ctor, List<Expr> Arguments)
            : Primitive(Ctor.Type)
        {
            public override Type Type => Ctor.ResultType;
        }

        public sealed record CallNativeConstructor(Decl.Class Class, Decl.Constructor Ctor, List<Expr> Arguments)
            : Primitive(Ctor.Type)
        {
            public override Type Type => Ctor.ResultType;
        }

        public sealed record CallIndirect(Expr Value, Type.Callable Callable, List<Expr> Arguments)
            : Primitive(Callable)
        {
            public override Type Type => Callable.Result;
        }

        public sealed record SelectFunction(Reference Reference, Decl.Classy Classy, Decl.Function Function)
            : Primitive(Function.ResultType);

        public sealed record SelectAttribute(Reference Reference, Decl.Classy Classy, Decl.Attribute Attribute, int ScratchLocal = -1)
            : Primitive(Attribute.ResultType);

        public sealed record SelectField(Reference Reference, Decl.Classy Classy, Decl.Field Field)
            : Primitive(Field.Type);

        public sealed record CallMember(Decl.Classy Classy, Decl.Function Function, Expr Make, List<Expr> Arguments)
            : Expr
        {
            public CallMember(Decl.Classy classy, Decl.Function function, Expr make, params Expr[] arguments)
                : this(classy, function, make, arguments.ToList())
            {
            }
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

        public sealed record AndThen(Type Type, LazyExpr And, LazyExpr Then) : Expr
        {
        }

        public sealed record If(LazyExpr LazyCondition, LazyExpr LazyThen, LazyExpr LazyElse) : Expr
        {
            public Type Type
            {
                get
                {
                    Assert(ReferenceEquals(Then.Type, Else.Type));
                    return Then.Type;
                }
            }

            public Expr Condition => LazyCondition.Expr;
            public Expr Then => LazyThen.Expr;
            public Expr Else => LazyElse.Expr;
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
