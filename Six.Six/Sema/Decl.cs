using Six.Six.Instructions;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }
        A.Name Name { get; }
        Type Type { get; }
        string FullName { get; }

        Module Module { get; }
        Resolver Resolver { get; }

        public abstract class WithMembers : Declaration
        {
            public WithMembers(Scope container, A.Decl aDecl)
                : base(container, aDecl)
            {
            }
            public List<Member> Members { get; } = new();
        }

        public abstract class Classy : WithMembers
        {
            private Classy(ClassyScope scope, A.Decl.Classy aDecl)
                : base(scope, aDecl)
            {
                Type = new Type.Reference(this);
                Scope = scope;
            }

            public Classy(Scope parent, A.Decl.Classy aDecl)
                : this(new ClassyScope(parent, aDecl.Name.Text), aDecl)
            {
                parent.Declare(this, aDecl.Name.Text);
            }

            public ClassyScope Scope { get; }

            public override Type Type { get; }

            public override string FullName => Scope.FullName;
        }

        public class Primitive : Classy
        {
            public Primitive(Scope parent, A.Decl.Primitive aDecl)
                : base(parent, aDecl)
            {
            }
        }

        public class Class : Classy
        {
            private Type? extends;

            public Class(Scope parent, A.Decl.Class aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);
            }

            public Layout Layout { get; } = new Layout(null);

            public Type Extends
            {
                get
                {
                    if (extends == null)
                    {
                        if (((A.With.Extends)ADecl).Extends is A.Type extended)
                        {
                            extends = ResolveType(Scope, extended);
                        }
                        else
                        {
                            var basicDecl = Module.CoreFind(ADecl, Names.Core.Basic);
                            extends = new Type.Reference(basicDecl);
                        }
                    }
                    return extends;
                }
            }

            public override string ToString()
            {
                return $"{Name}";
            }
        }

        public class Interface : Classy
        {
            public Interface(Scope parent, A.Decl.Interface aDecl)
                : base(parent, aDecl)
            {
            }
        }

        public class Object : Classy
        {
            public Object(Scope parent, A.Decl.Object aDecl)
                : base(parent, aDecl)
            {
            }
        }

        public abstract class Funcy : WithMembers
        {
            private List<Type>? paramTypes = null;

            private Funcy(FuncyScope scope, A.Decl.Funcy aDecl)
                : base(scope, aDecl)
            {
                Scope = scope;
                AFuncyDecl = aDecl;
            }

            public Funcy(Scope parent, string name, A.Decl.Funcy aDecl)
                : this(new FuncyScope(parent, name), aDecl)
            {
                parent.Declare(this, name);
            }

            public FuncyScope Scope { get; }
            public A.Decl.Funcy AFuncyDecl { get; }

            public List<Local> Parameters { get; } = new();
            public List<Local> Locals { get; } = new();

            public List<Type> ParamTypes =>
                paramTypes ??= Parameters.Select(param => param.Type).ToList();

            public override string FullName => Scope.FullName;
        }

        public class Function : Funcy
        {
            private Type? resultType = null;

            public Function(Scope parent, A.Decl.Funcy aDecl, string? name)
                : base(parent, name ?? aDecl.Name.Text, aDecl)
            {
                Assert(ADecl is A.With.Type);
                Assert(ADecl is A.With.Parameters);
            }

            public override Type Type =>
                type ??= new Type.Callable(ResultType, ParamTypes);

            public Type ResultType =>
                resultType ??= ResolveType(Scope, ((A.With.Type)ADecl).Type);
        }

        public class Constructor : Funcy
        {
            private Type? resultType = null;

            public Constructor(Scope parent, Class @class, A.Decl.Funcy aFuncyDecl)
                : base(parent, aFuncyDecl.Name.Text, aFuncyDecl)
            {
                Class = @class;
            }

            public Class Class { get; }

            public override Type Type =>
                type ??= new Type.Callable(ResultType, ParamTypes);

            public Type ResultType =>
                resultType ??= ResolveType(Class.Type);
        }

        public abstract class Local : Declaration
        {
            public Local(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl)
            {
                Index = index;
            }

            public int Index { get; }

            public override string FullName => ADecl.Name.Text;
        }

        public sealed class Parameter : Local
        {
            public Parameter(FuncyScope Container, A.Decl.Parameter ADecl, int index)
                : base(Container, ADecl, index)
            {
                Assert(ADecl is A.With.Type);
            }

            public Expr.Concrete? Default { get; set; }

            public override Type Type =>
                type ??= ResolveType(Container, ((A.With.Type)ADecl).Type);
        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {SelfName}")]
        public sealed class SelfParameter : Local
        {
            public SelfParameter(FuncyScope Container, A.Decl.Funcy ADecl, Type type, int index)
                : base(Container, ADecl, index)
            {
                Type = type;
            }

            public static string SelfName => Names.Core.SelfValue;

            public override Type Type { get; }
        }

        public abstract class LetVar : Local
        {
            private readonly Expr.Delayed value;

            public LetVar(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
                Assert(ADecl is A.With.OptionalType);
                Assert(ADecl is A.With.Value);
                value = ResolveExpression(Container, ((A.With.Value)ADecl).Value);
            }

            public override Type Type
            {
                get
                {
                    if (type == null)
                    {
                        //TODO: typecheck
                        var aType = ((A.With.OptionalType)ADecl).Type;
                        if (aType != null)
                        {
                            type = ResolveType(Container, aType);
                        }
                        else
                        {
                            Assert(Value.Type != null);
                            type = Value.Type!;
                        }
                    }

                    return type;
                }
            }

            public Expr.Concrete Value
            { 
                get
                {
                    Assert(value.Resolved != null);
                    return value.Resolved!;
                }
            }
        }

        public sealed class Let : LetVar
        {
            public Let(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
            }
        }

        public sealed class Var : LetVar
        {
            public Var(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
            }
        }

        public sealed class Alias : Declaration
        {
            private Alias(DeclarationScope scope, A.Decl.Alias aDecl)
                : base(scope, aDecl)
            {
                Assert(aDecl is A.With.Type);

                Scope = scope;
            }

            public Alias(Scope parent, A.Decl.Alias aDecl)
                : this(new DeclarationScope(parent, aDecl.Name.Text), aDecl)
            {
                parent.Declare(this);
            }

            public DeclarationScope Scope { get; }
            public override string FullName => $"{Container.FullName}.{ADecl.Name.Text}";


            public override Type Type =>
                type ??= ResolveType(Scope, ((A.With.Type)ADecl).Type);

        }

        public sealed class Attribute : Declaration
        {
            public Attribute(Scope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Assert(ADecl is A.With.Type);
            }

            public override string FullName => $"{Container.FullName}.{ADecl.Name.Text}";

            public override Type Type =>
                type ??= ResolveType(Container, ((A.With.Type)ADecl).Type);
        }

#if false
        public sealed class TypeParameter : Declaration
        {
            public TypeParameter(Scope Container, A.Decl.TypeParameter ADecl)
                : base(Container, ADecl)
            {
            }

            public override string FullName => $"{Container.FullName}.{ADecl.Name.Text}";
        }
#endif

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {Name}")]
        public abstract class Declaration : Decl
        {
            protected Type? type = null;

            public Declaration(Scope container, A.Decl aDecl)
            {
                Container = container;
                ADecl = aDecl;
            }

            public Scope Container { get; }
            public A.Decl ADecl { get; }
            public abstract Type Type { get; }
            public A.Name Name => ADecl.Name;
            public abstract string FullName { get; }

            public Module Module => Container.Module;
            public Resolver Resolver => Module.Resolver;

            public Type ResolveType(Scope scope, A.Type tree) => Resolver.ResolveType(scope, tree);
            public Type ResolveType(Type type) => Resolver.ResolveType(type) ?? throw new InvalidOperationException();
            public Expr.Delayed ResolveExpression(Scope scope, A.Expression node) => Resolver.ResolveExpression(scope, node);
        }
    }
}
