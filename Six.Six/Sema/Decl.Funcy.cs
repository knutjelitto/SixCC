using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public abstract class Funcy : Declaration
        {
            private FuncLayout? layout;
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
            public FuncLayout Layout => layout ??= new FuncLayout(this);
            public Scope Scope => Block.Funcy.Parent.Content;
            public uint TableIndex { get; set; } = uint.MaxValue;

            public IReadOnlyList<Local> Parameters => Layout.TypedParameters;

            public abstract Type ResultType { get; }
            public List<Type> ParamTypes =>
                paramTypes ??= Parameters.Select(param => param.Type).ToList();

            public bool HasBody => AFuncy.Body is not A.Body.Deferred;
            public bool IsConcrete => HasBody && !IsAbstract;
            public bool IsDynamic => !IsStatic && (IsVirtual || IsOverride);
            public bool IsObjectMember => !IsStatic && Parent is ClassBlock;

            public override string FullName => Block.FullName();

            public override Type Type =>
                type ??= new Type.Callable(Module, ResultType, ParamTypes);

            public Type.Callable CallableType => (Type.Callable)Type;

            public void AddParameter(Local parameter)
            {
                Layout.AddParameter(parameter);
                Block.Members.Add(parameter);
            }

            public void AddLocal(Local local)
            {
                Layout.AddLocal(local);
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

            public override bool IsStatic => true;

            public override Type ResultType =>
                resultType ??= Resolver.ResolveType(((ClassBlock)Parent).Classy.Type);
        }

        public sealed class Attribute : Funcy
        {
            private Type? resultType = null;

            public Attribute(Block parent, A.Decl.Attribute aDecl)
                : base(parent, aDecl.Name.Text, aDecl)
            {
                Assert(ADecl is A.With.Type);
            }

            public override string FullName => $"{Parent.FullName()}.{ADecl.Name}";

            public override Type ResultType =>
                resultType ??= Resolver.ResolveType(Parent.Content, ((A.With.Type)ADecl).Type);
        }
    }
}
