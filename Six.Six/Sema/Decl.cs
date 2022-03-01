using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
    {
        A.Decl ADecl { get; }
        A.Name Name => ADecl.Name;
        Type? Type { get; }

        public class Classy : Declaration
        {
            public Classy(Scope container, A.Decl aDecl)
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
        }

        public class Function : Funcy
        {
            public Function(FuncyScope container, A.Decl.Funcy aDecl)
                : base(container, aDecl)
            {
            }

            public Type? Result { get; set; } = null;
        }

        public abstract class Local : Declaration
        {
            public Local(DeclarationScope Container, A.Decl ADecl, uint index)
                : base(Container, ADecl)
            {
                Index = index;
            }

            public uint Index { get; }
        }

        public sealed class Parameter : Local
        {
            public Parameter(FuncyScope Container, A.Decl ADecl, uint index)
                : base(Container, ADecl, index)
            {
            }

            public Expr.Concrete? Default { get; set; }
        }

        public sealed class Let : Local
        {
            public Let(DeclarationScope Container, A.Decl ADecl, uint index)
                : base(Container, ADecl, index)
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
    }
}
