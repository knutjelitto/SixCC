using Six.Six.Instructions;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public enum FuncyKind
        {
            Unknown,
            Global,
            Local,
            Member,
        }

        public abstract class Funcy : Declaration
        {
            private List<Type>? paramTypes = null;
            private Type? resultType = null;
            private readonly FuncMembers Members;

            protected Funcy(Block parent, string name, A.Decl.Funcy aDecl)
                : base(parent, aDecl)
            {
                parent.Members.Add(this);
                Block = new FuncBlock(parent, this, name);
                AFuncy = aDecl;
                Members = new FuncMembers();
                parent.DeclareContent(this, name);
            }

            public FuncBlock Block { get; }
            public A.Decl.Funcy AFuncy { get; }

            public IReadOnlyList<Local> Parameters => Members.Parameters;
            public IReadOnlyList<Local> Locals => Members.Locals;
            public IReadOnlyList<Function> Functions => Members.Functions;

            public List<Type> ParamTypes =>
                paramTypes ??= Parameters.Select(param => param.Type).ToList();

            public bool HasBody => AFuncy.Body is not A.Body.Deferred;
            public bool IsConcrete => HasBody && !IsAbstract;
            public bool IsDynamic => !IsStatic && (IsAbstract || IsVirtual || IsOverride);
            public bool IsClassMember => !IsStatic && Parent is ClassBlock;
            public bool IsLocalFunction => Parent is CodeBlock;
            public bool IsGlobalFunction => Parent is NamespaceBlock;

            public override string FullName => Block.FullName();

            public override Type Type =>
                type ??= new Type.Callable(Module, ResultType, ParamTypes);

            public Func<Type> ResultTypeResolver { get; init; } = () => throw new NotImplementedException();
            public Type ResultType => resultType ??= ResultTypeResolver();

            public Type.Callable CallableType => (Type.Callable)Type;

            public void AddParameter(Local parameter)
            {
                Members.AddParameter(parameter);
            }

            public void AddLocal(Local local)
            {
                Members.AddLocal(local);
            }

            public void AddFunction(Function function)
            {
                Members.AddFunction(function);
            }
        }

        public sealed class Function : Funcy
        {
            public Function(Block parent, A.Decl.Funcy aDecl, string? name)
                : base(parent, name ?? aDecl.Name.Text, aDecl)
            {
                ResultTypeResolver = () =>
                {
                    var type = ((A.With.Type)aDecl).Type;

                    if (type is A.Reference reference && reference.Name.Text == "void")
                    {
                        return new Type.Void(Module);
                    }

                    return LazyTypeResolver(parent, ((A.With.Type)aDecl).Type);
                };
            }
        }

        public sealed class Constructor : Funcy
        {
            public Constructor(ClassBlock parent, A.Decl.Funcy aFuncyDecl)
                : base(parent, aFuncyDecl.Name.Text, aFuncyDecl)
            {
                ResultTypeResolver = () => Resolver.T.ResolveType(parent.Classy.Type);
            }

            public override bool IsStatic => true;
        }

        public sealed class Attribute : Funcy
        {
            public Attribute(Block parent, A.Decl.Attribute aDecl)
                : base(parent, aDecl.Name.Text, aDecl)
            {
                ResultTypeResolver = () => LazyTypeResolver(parent, aDecl.Type);
                FullName = $"{parent.FullName()}.{Name}";
            }

            public override string FullName { get; }
        }
    }
}
