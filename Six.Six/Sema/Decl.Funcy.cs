using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {

        public abstract class Funcy : Declaration
        {
            private List<Type>? paramTypes = null;

            public Funcy(Block parent, string name, A.Decl.Funcy aDecl)
                : base(parent, aDecl)
            {
                parent.Members.Add(this);
                Block = new FuncBlock(this, parent, name);
                AFuncy = aDecl;
                parent.Content.Declare(this, name);
            }

            public FuncBlock Block { get; }
            public A.Decl.Funcy AFuncy { get; }
            public Scope Scope => Block.Funcy.Container;

            public IReadOnlyList<Local> Parameters { get; } = new List<Local>();
            public IReadOnlyList<Local> Locals { get; } = new List<Local>();
            public int NextLocalSlot => Parameters.Count + Locals.Count;

            public abstract Type ResultType { get; }
            public List<Type> ParamTypes =>
                paramTypes ??= Parameters.Select(param => param.Type).ToList();

            public bool HasBody => AFuncy.Body is not A.Body.Deferred;
            public bool IsConcrete => HasBody && !IsAbstract;

            public override string FullName => Block.FullName();

            public void AddParameter(Local parameter)
            {
                ((List<Local>)Parameters).Add(parameter);
                Block.Members.Add(parameter);
            }

            public void AddLocal(Local local)
            {
                ((List<Local>)Locals).Add(local);
                Block.Members.Add(local);
            }
        }

        public class Function : Funcy
        {
            private Type? resultType = null;

            public Function(Block parent, A.Decl.Funcy aDecl, string? name)
                : base(parent, name ?? aDecl.Name.Text, aDecl)
            {
                Assert(ADecl is A.With.Type);
                Assert(ADecl is A.With.Parameters);
            }

            public override Type Type =>
                type ??= new Type.Callable(ResultType, ParamTypes);

            public override Type ResultType =>
                resultType ??= Resolver.ResolveType(Scope, ((A.With.Type)ADecl).Type);
        }

        public class Constructor : Funcy
        {
            private Type? resultType = null;

            public Constructor(ClassBlock parent, A.Decl.Funcy aFuncyDecl)
                : base(parent, aFuncyDecl.Name.Text, aFuncyDecl)
            {
            }

            public override Type Type =>
                type ??= new Type.Callable(ResultType, ParamTypes);

            public override Type ResultType =>
                resultType ??= Resolver.ResolveType(((ClassBlock)Parent).Classy.Type);
        }

        public sealed class Attribute : Funcy
        {
            public Attribute(Block parent, A.Decl.Attribute aDecl)
                : base(parent, aDecl.Name.Text, aDecl)
            {
                Assert(ADecl is A.With.Type);
            }

            public override string FullName => $"{Parent.FullName()}.{ADecl.Name}";

            public override Type Type =>
                type ??= Resolver.ResolveType(Container, ((A.With.Type)ADecl).Type);

            public override Type ResultType => Type;
        }
    }
}
