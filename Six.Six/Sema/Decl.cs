using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }
        A.Name Name { get; }
        Type? Type { get; }

        public class Classy : Declaration
        {
            public Classy(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(container.Module.Resolver, this);
            }

            public List<Decl> Members { get; } = new();
        }

        public class Primitive : Classy
        {
            public Primitive(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(container.Module.Resolver, this);
            }
        }

        public class Class : Classy
        {
            public Class(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(container.Module.Resolver, this);
            }
        }

        public class Interface : Classy
        {
            public Interface(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(container.Module.Resolver, this);
            }
        }

        public class Object : Classy
        {
            public Object(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(this);
            }
        }

        public class Funcy : Declaration
        {
            public Funcy(FuncyScope container, A.Decl.Funcy aDecl)
                : base(container, aDecl)
            {
            }

            public List<Parameter> Parameters { get; } = new();
            public List<Local> Locals { get; } = new();
            public List<Member> Members { get; } = new();
        }

        public class Function : Funcy
        {
            public Function(FuncyScope container, A.Decl.Funcy aDecl)
                : base(container, aDecl)
            {
            }

            public Type? Result { get; set; } = null;
        }

        public class Constructor : Funcy
        {
            public Constructor(FuncyScope container, A.Decl.Funcy aDecl)
                : base(container, aDecl)
            {
            }
        }

        public abstract class Local : Declaration
        {
            public Local(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl)
            {
                Index = index;
            }

            public int Index { get; }
        }

        public sealed class Parameter : Local
        {
            public Parameter(FuncyScope Container, A.Decl.Parameter ADecl, int index)
                : base(Container, ADecl, index)
            {
            }

            public Expr.Concrete? Default { get; set; }
        }

        public sealed class Let : Local
        {
            public Let(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
            }

            public Expr.Concrete? Value { get; set; }
        }

        public sealed class Var : Local
        {
            public Var(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
            }

            public Expr.Concrete? Value { get; set; }
        }

        public sealed class Alias : Declaration
        {
            public Alias(Scope container, A.Decl aDecl)
                : base(container, aDecl)
            {
            }
        }

        public sealed class Attribute : Declaration
        {
            public Attribute(Scope container, A.Decl aDecl)
                : base(container, aDecl)
            {
            }
        }
    }

    public class Declaration : Decl
    {
        public Declaration(Scope container, A.Decl aDecl)
        {
            Container = container;
            ADecl = aDecl;
        }

        public Scope Container { get; }
        public A.Decl ADecl { get; }
        public Type? Type { get; set; } = null;
        public A.Name Name => ADecl.Name;
    }
}
