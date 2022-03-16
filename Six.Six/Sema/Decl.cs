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

        public abstract class Classy : WithMembers, Typy
        {
            private Class? extends;
            private Layout? layout;

            private Classy(ClassyScope scope, A.Decl.Classy aDecl)
                : base(scope, aDecl)
            {
                Type = new Type.Reference(this);
            }

            public Classy(Scope parent, A.Decl.Classy aDecl)
                : this(new ClassyScope(parent, aDecl.Name.Text), aDecl)
            {
                parent.Declare(this, aDecl.Name.Text);
            }

            public ClassyScope ClassyScope => (ClassyScope)Container;

            public override Type Type { get; }

            public override string FullName => ClassyScope.FullName;

            public Class? Extends => extends ??= this is Class klass ? Resolver.ResolveExtends(klass) : null;

            public Layout Layout => layout ??= new Layout(this);
        }

        public class Class : Classy
        {
            public Class(Scope parent, A.Decl.Class aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);
            }

            public List<Field> Fields { get; } = new List<Field>();

            public override string ToString() => $"{Name}";
        }

        public class Object : Classy
        {
            public Object(Scope parent, A.Decl.Object aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);
            }

            public override string ToString() => $"{Name}";
        }

        public class Interface : Classy
        {
            public Interface(Scope parent, A.Decl.Interface aDecl)
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
                resultType ??= Resolver.ResolveType(Scope, ((A.With.Type)ADecl).Type);
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
                resultType ??= Resolver.ResolveType(Class.Type);
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
            private readonly LazyExpr? @default;

            public Parameter(FuncyScope Container, A.Decl.Parameter ADecl, int index, LazyExpr? @default)
                : base(Container, ADecl, index)
            {
                Assert(ADecl is A.With.Type);
                this.@default = @default;
            }

            public Expr? Default
            { 
                get
                {
                    if (@default != null)
                    {
                        return @default.Expr;
                    }
                    return null;
                }
            }

            public override Type Type =>
                type ??= Resolver.ResolveType(Container, ((A.With.Type)ADecl).Type);
        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {SelfName}")]
        public sealed class SelfParameter : Local
        {
            public SelfParameter(FuncyScope Container, Type type, int index)
                : base(Container, new A.Decl.SelfValue(new A.Name.ArtificalId(Names.Core.SelfValue)), index)
            {
                Type = type;
            }

            public static string SelfName => Names.Core.SelfValue;

            public override Type Type { get; }
        }

        public sealed class LetVar : Local
        {
            private readonly LazyExpr value;

            public LetVar(Scope Container, A.Decl ADecl, bool writeable, int index)
                : base(Container, ADecl, index)
            {
                Assert(ADecl is A.With.OptionalType);
                Assert(ADecl is A.With.Value);
                value = Resolver.ResolveExpression(Container, ((A.With.Value)ADecl).Value);
                Writeable = writeable;
            }

            public bool Writeable { get; }

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
                            type = Resolver.ResolveType(Container, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => value.Expr;
        }

        public sealed class Field : Declaration
        {
            private readonly LazyExpr value;

            public Field(Scope container, A.Decl aDecl, bool writeable)
                : base(container, aDecl)
            {
                Assert(aDecl is A.With.OptionalType);
                Assert(aDecl is A.With.Value);
                value = Resolver.ResolveExpression(container, ((A.With.Value)aDecl).Value);
                Writeable = writeable;
            }

            public bool Writeable { get; }
            public uint Offset { get; set; } = uint.MaxValue;

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
                            type = Resolver.ResolveType(Container, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => value.Expr;

            public override string FullName => ADecl.Name.Text;
        }

        public sealed class Global : Declaration
        {
            private readonly LazyExpr value;

            public Global(Scope container, A.Decl aDecl, bool writeable)
                : base(container, aDecl)
            {
                Assert(aDecl is A.With.OptionalType);
                Assert(aDecl is A.With.Value);
                value = Resolver.ResolveExpression(container, ((A.With.Value)aDecl).Value);
                Writeable = writeable;
            }

            public bool Writeable { get; }

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
                            type = Resolver.ResolveType(Container, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => value.Expr;

            public override string FullName => $"{Container.FullName}.{ADecl.Name.Text}";
        }

        public sealed class Alias : Declaration, Typy
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
                type ??= Resolver.ResolveType(Scope, ((A.With.Type)ADecl).Type);

        }

        public sealed class Attribute : Declaration
        {
            private Body? body;

            public Attribute(Scope parent, A.Decl aDecl)
                : base(parent, aDecl)
            {
                Assert(ADecl is A.With.Type);
            }

            public override string FullName => $"{Container.FullName}.{ADecl.Name.Text}";

            public override Type Type =>
                type ??= Resolver.ResolveType(Container, ((A.With.Type)ADecl).Type);

            public Body Body =>
                body ??= Resolver.WalkBody(Container, ((A.With.Body)ADecl).Body);
        }

#if false
        public sealed class TypeParameter : Declaration, Typy
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
            public A.TreeNode ANode => ADecl;
            public abstract Type Type { get; }
            public A.Name Name => ADecl.Name;
            public abstract string FullName { get; }

            public Module Module => Container.Module;
            public Resolver Resolver => Container.Module.Resolver;
        }
    }
}
