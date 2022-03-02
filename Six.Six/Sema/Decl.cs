using Six.Six.Instructions;
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

        public sealed class Let : Local, Emitting
        {
            public Let(Scope Container, A.Decl ADecl, int index)
                : base(Container, ADecl, index)
            {
            }

            public Expr.Concrete? Value { get; set; }

            public void Emit(Emitter emitter)
            {
                if (Value != null)
                {
                    Value.Emit(emitter);
                    emitter.Add(Insn.Local.Set(Index));
                }
                else
                {
                    Assert(false);
                }
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
