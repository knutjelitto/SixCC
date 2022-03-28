﻿using Six.Six.Instructions;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public abstract class Funcy : Declaration
        {
            private FuncLayout? layout;
            private List<Type>? paramTypes = null;
            private Type? resultType = null;


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

            public List<Type> ParamTypes =>
                paramTypes ??= Parameters.Select(param => param.Type).ToList();

            public bool HasBody => AFuncy.Body is not A.Body.Deferred;
            public bool IsConcrete => HasBody && !IsAbstract;
            public bool IsDynamic => !IsStatic && (IsVirtual || IsOverride);
            public bool IsObjectMember => !IsStatic && Parent is ClassBlock;

            public override string FullName => Block.FullName();

            public override Type Type =>
                type ??= new Type.Callable(Module, ResultType, ParamTypes);

            public Func<Type> ResultTypeResolver { get; init; } = () => throw new NotImplementedException();
            public Type ResultType => resultType ??= ResultTypeResolver();

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
            public Function(Block parent, A.Decl.Funcy aDecl, string? name)
                : base(parent, name ?? aDecl.Name.Text, aDecl)
            {
                ResultTypeResolver = () => LazyTypeResolver(parent, ((A.With.Type)aDecl).Type);
            }

        }

        public class Constructor : Funcy
        {
            public Constructor(ClassBlock parent, A.Decl.Funcy aFuncyDecl)
                : base(parent, aFuncyDecl.Name.Text, aFuncyDecl)
            {
                ResultTypeResolver = () => Resolver.ResolveType(parent.Classy.Type);
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
