using Six.Six.Instructions;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public abstract class Funcy : Declaration
        {
            private List<Type>? paramTypes = null;
            public readonly FuncMembers Members;

            protected Funcy(Block parent, string name, A.Decl.Funcy aDecl)
                : base(parent, aDecl)
            {
                Block = new FuncBlock(parent, this, name);
                AFuncy = aDecl;
                Members = new FuncMembers();
                //parent.DeclareContent(this, name);
            }

            public FuncBlock Block { get; }
            public A.Decl.Funcy AFuncy { get; }

            public IReadOnlyList<Local> Parameters => Members.Parameters;
            public IReadOnlyList<Local> Locals => Members.Locals;
            public IReadOnlyList<Funcy> Functions => Members.Functions;

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

            public abstract Type ResultType { get; }

            public Type.Callable CallableType => (Type.Callable)Type;

            public void AddParameter(Decl.Parameter parameter)
            {
                Members.AddParameter(parameter);
            }

            public void AddParameter(Decl.SelfParameter parameter)
            {
                Members.AddParameter(parameter);
            }
        }

        public sealed class Function : Funcy
        {
            private readonly LazyType lazyResultType;

            public Function(Block parent, A.Decl.Funcy aDecl, string? name)
                : base(parent, name ?? aDecl.Name.Text, aDecl)
            {
                var type = ((A.With.Type)aDecl).Type;

                if (type is A.Reference reference && reference.Name.Text == "void")
                {
                    lazyResultType = new LazyType(() => new Type.Void(Module));
                }
                else
                {
                    lazyResultType = Resolver.T.ResolveTypeLazy(parent, type);
                }
            }

            public override Type ResultType => lazyResultType.Value;
        }

        public sealed class Constructor : Funcy
        {
            private readonly LazyType lazyResultType;

            public Constructor(ClassBlock parent, A.Decl.Funcy aFuncyDecl)
                : base(parent, aFuncyDecl.Name.Text, aFuncyDecl)
            {
                lazyResultType = new LazyType(() => parent.Classy);
            }

            public override bool IsStatic => true;

            public override Type ResultType => lazyResultType.Value;
        }

        public sealed class Attribute : Funcy
        {
            private readonly LazyType lazyResultType;

            public Attribute(Block parent, A.Decl.Attribute aDecl)
                : base(parent, aDecl.Name.Text, aDecl)
            {
                lazyResultType = Resolver.T.ResolveTypeLazy(parent, aDecl.Type);

                FullName = $"{parent.FullName()}.{Name}";
            }

            public override string FullName { get; }

            public override Type ResultType => lazyResultType.Value;
        }
    }
}
