using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }
        A.Name Name { get; }
        Type? Type { get; }

        public class Memby : Declaration
        {
            public Memby(Scope container, A.Decl aDecl)
                : base(container, aDecl)
            {
            }
            public List<Member> Members { get; } = new();
        }

        public class Classy : Memby
        {
            public Classy(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(this);
            }
        }

        public class Primitive : Classy
        {
            public Primitive(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(this);
            }
        }

        public class Class : Classy
        {
            public Class(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Scope = container;

                Type = new Type.Reference(this);
            }
            public ClassyScope Scope { get; }
        }

        public class Interface : Classy
        {
            public Interface(ClassyScope container, A.Decl aDecl)
                : base(container, aDecl)
            {
                Type = new Type.Reference(this);
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

        public class Funcy : Memby
        {
            public Funcy(FuncyScope container, A.Decl.Funcy aDecl)
                : base(container, aDecl)
            {
                Scope = container;
            }

            public FuncyScope Scope { get; }

            public List<Local> Parameters { get; } = new();
            public List<Local> Locals { get; } = new();
        }

        public class Function : Funcy
        {
            public Function(Scope parent, A.Decl.Funcy aDecl, string? name)
                : base(new FuncyScope(parent, name ?? aDecl.Name.Text), aDecl)
            {
                parent.Declare(this, name ?? aDecl.Name.Text);
            }

            public Type? Result { get; set; } = null;
        }

        public class Constructor : Funcy
        {
            public Constructor(Scope parent, A.Decl.Funcy aFuncyDecl)
                : base(new FuncyScope(parent, aFuncyDecl.Name.Text), aFuncyDecl)
            {
                parent.Declare(this);
                AFuncyDecl = aFuncyDecl;
            }

            public A.Decl.Funcy AFuncyDecl { get; }

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

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {SelfName}")]
        public sealed class SelfParameter : Local
        {
            public SelfParameter(FuncyScope Container, A.Decl.Funcy ADecl, int index)
                : base(Container, ADecl, index)
            {
            }

            public string SelfName => Module.Core.SelfValue;
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
            public Alias(Scope container, A.Decl.Alias aDecl)
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

    [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {Name}")]
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
