using Six.Six.Instructions;
using Six.Six.Types;
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

        public sealed record SelfReference(Decl.Classy ClassyDecl)
            : Reference(ClassyDecl)
        {
            public override string ToString()
            {
                return $"(self)";
            }
        }

        public sealed record AliasReference(Decl.Alias AliasDecl)
            : Reference(AliasDecl);

        public sealed record FieldReference(Decl.Field FieldDecl)
            : Reference(FieldDecl);

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
            protected CallFunction(Decl.Funcy Funcy)
                : this(Funcy, new List<Expr>())
            {
            }

            public override Type Type => Funcy.ResultType;

            public static CallFunction From(Decl.Funcy funcy, params Expr[] arguments)
            {
                Assert(arguments.Length == 0);
                return From(funcy, arguments.ToList());
            }

            public static CallFunction From(Decl.Funcy funcy, List<Expr> arguments)
            {
                if (funcy.IsStatic || funcy.IsLocalFunction || funcy.IsGlobalFunction)
                {
                    return new CallStaticFunction(funcy, arguments);
                }
                else if (funcy.IsClassMember)
                {
                    if (funcy.Parent is ClassBlock classBlock)
                    {
                        var classy = classBlock.Classy;

                        var reference = new SelfReference(classy);

                        if (funcy.IsDynamic)
                        {
                            var slot = classy.Slot(funcy);

                            if (slot == null)
                            {
                                Assert(false);
                                throw new InvalidOperationException();
                            }

                            return new CallDynamicFunction(funcy, reference, (uint)slot.Index, arguments);
                        }
                        else
                        {
                            return new CallMemberFunction(funcy, reference, arguments);
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

        public sealed record CallMemberFunction(Decl.Funcy Funcy, Expr Reference, List<Expr> Arguments)
            : CallFunction(Funcy, Arguments);

        public sealed record CallDynamicFunction(Decl.Funcy Funcy, Expr Reference, uint SlotNo, List<Expr> Arguments)
            : CallFunction(Funcy, Arguments);

        [DebuggerDisplay("{Dbg()}")]
        public sealed record CallConstructor(Decl.Classy Class, Decl.Constructor Ctor, List<Expr> Arguments)
            : Primitive(Ctor.Type)
        {
            public override Type Type => Ctor.ResultType;

            public string Dbg()
            {
                return $"call {Class.Name}.ctor.{Ctor.Name}";
            }
        }

        public sealed record CallIndirect(Expr Value, Type.Callable Callable, List<Expr> Arguments)
            : Primitive(Callable)
        {
            public override Type Type => Callable.Result;
        }

        public abstract record SelectMember(Expr Reference, Type Type)
            : Primitive(Type);

        public sealed record SelectFunction(Expr Reference, Decl.Function Function)
            : SelectMember(Reference, Function.ResultType);

        public sealed record SelectField(Expr Reference, Decl.Field Field)
            : SelectMember(Reference, Field.Type)
        {
            public override string ToString()
            {
                return $"{Reference}.{Field}";
            }
        }

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

        public sealed record AndThen(Type Type, LazyExpr And, LazyExpr Then)
            : Expr
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

            public Expr Condition => LazyCondition.Value;
            public Expr Then => LazyThen.Value;
            public Expr Else => LazyElse.Value;
        }

        public sealed record Return(Type Type, LazyExpr? Expr) : Expr
        {
        }
    }
}
