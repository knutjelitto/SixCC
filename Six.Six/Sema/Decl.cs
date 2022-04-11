using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl : Member
    {
        ILocation Location { get; }
        Type Type { get; }
        string Name { get; }
        string FullName { get; }

        Block Parent { get; }

        Module Module { get; }
        Resolver Resolver { get; }

        bool IsStatic { get; }
        bool IsNative { get; }
        bool IsShared { get; }

        bool Validated { get; set; }

        public abstract class Local : Declaration
        {
            public Local(FuncBlock parent, A.Decl ADecl)
                : base(parent, ADecl)
            {
            }

            public int Index { get; set; }

            public override string FullName => Name;
        }

        public class Parameter : Local
        {
            private readonly LazyExpr? lazyDefault;

            public Parameter(FuncBlock parent, A.Decl.Parameter aDecl, LazyExpr? lazyDefault)
                : base(parent, aDecl)
            {
                this.lazyDefault = lazyDefault;
                TypeResolver = () => LazyTypeResolver(parent, aDecl.Type);
            }

            public Expr? Default => lazyDefault?.Expr;

            public Func<Type> TypeResolver { get; init; }

            public override Type Type => type ??= TypeResolver();
        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {SelfName}")]
        public sealed class SelfParameter : Local
        {
            public SelfParameter(FuncBlock parent, Type type)
                : base(parent, new A.Decl.SelfValue(new A.Name.ArtificalId(parent.Funcy.AFuncy.Name.Tree, Names.Core.SelfValue)))
            {
                Type = type;
            }

            public static string SelfName => Names.Core.SelfValue;

            public override Type Type { get; }
        }

        public sealed class LetVar : Local
        {
            private readonly LazyExpr lazyValue;

            public LetVar(CodeBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent.FuncBlock, aDecl)
            {
                lazyValue = Resolver.E.ResolveExpression(Parent, aDecl.Value);
                TypeResolver = () => LazyTypeResolver(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
            }

            public bool Writeable { get; }

            public Func<Type> TypeResolver { get; init; }

            public override Type Type => type ??= TypeResolver();

            public Expr Value => lazyValue.Expr;
        }

        public sealed class Field : Declaration
        {
            private readonly LazyExpr lazyValue;

            public Field(ClassBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent, aDecl)
            {
                lazyValue = Resolver.E.ResolveExpression(parent, aDecl.Value);
                TypeResolver = () => LazyTypeResolver(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
                parent.Classy.AddField(this);
            }

            public bool Writeable { get; }
            public uint Offset { get; set; } = uint.MaxValue;

            public Func<Type> TypeResolver { get; init; }

            public override Type Type => type ??= TypeResolver();

            public Expr Value => lazyValue.Expr;

            public override string FullName => Name;

            public string StaticName => $"{Parent.FullName()}.{Name}";
        }

        public sealed class Global : Declaration
        {
            private readonly LazyExpr lazyValue;
            public readonly A.Decl.LetVar ALetVar;

            public Global(NamespaceBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent, aDecl)
            {
                Assert(aDecl.Type != null);

                ALetVar = aDecl;
                lazyValue = Resolver.E.ResolveExpression(parent, ALetVar.Value);
                TypeResolver = () => LazyTypeResolver(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
                parent.Members.Add(this);
                FullName = $"{Parent.FullName()}.{Name}";
            }

            public bool Writeable { get; }

            public Func<Type> TypeResolver { get; init; }

            public override Type Type => type ??= TypeResolver();

            public Expr Value => lazyValue.Expr;

            public override string FullName { get; }
        }

        public sealed class Alias : Declaration, Type
        {
            public Alias(Block parent, A.Decl.Alias aDecl)
                : base(parent, aDecl)
            {
                TypeResolver = () => LazyTypeResolver(parent, aDecl.Type);
                parent.DeclareContent(this);
            }

            public override string FullName => $"{Parent.FullName()}.{Name}";

            public Func<Type> TypeResolver { get; init; }

            public override Type Type => type ??= TypeResolver();

        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {FullName}")]
        public abstract class Declaration : Decl
        {
            protected Type? type = null;
            private DeclAttr? attr;

            protected Declaration(Block parent, A.Decl aDecl)
            {
                Parent = parent;
                Name = aDecl.Name.Text;
                Location = aDecl.GetLocation();
                LazyAttr = () => MakeAttr(aDecl);
            }

            public Block Parent { get; }
            public abstract Type Type { get; }
            public string Name { get; }
            public abstract string FullName { get; }
            public ILocation Location { get; }


            public Func<DeclAttr> LazyAttr { get; init; }

            public Module Module => Parent.Module;
            public Resolver Resolver => Parent.Module.Resolver;
            public bool Validated { get; set; }


            public bool IsNative => (Attr & DeclAttr.Native) != 0;
            public bool IsShared => (Attr & DeclAttr.Shared) != 0;
            public virtual bool IsStatic => (Attr & DeclAttr.Static) != 0;
            public bool IsVirtual => (Attr & DeclAttr.Virtual) != 0;
            public bool IsAbstract => (Attr & DeclAttr.Abstract) != 0;
            public bool IsOverride => (Attr & DeclAttr.Override) != 0;
            public bool IsSealed => (Attr & DeclAttr.Sealed) != 0;

            public DeclAttr Attr => attr ??= LazyAttr();

            private static DeclAttr MakeAttr(A.Decl aDecl)
            {
                var attr = DeclAttr.None;
                if (aDecl.IsWith(Names.Attr.Native)) attr |= DeclAttr.Native;
                if (aDecl.IsWith(Names.Attr.Shared)) attr |= DeclAttr.Shared;
                if (aDecl.IsWith(Names.Attr.Static)) attr |= DeclAttr.Static;
                if (aDecl.IsWith(Names.Attr.Abstract)) attr |= DeclAttr.Abstract;
                if (aDecl.IsWith(Names.Attr.Virtual)) attr |= DeclAttr.Virtual;
                if (aDecl.IsWith(Names.Attr.Override)) attr |= DeclAttr.Override;
                if (aDecl.IsWith(Names.Attr.Sealed)) attr |= DeclAttr.Sealed;

                return attr;
            }

            public static Type LazyTypeResolver(Block parent, A.Type aType)
            {
                return parent.Resolver.T.ResolveType(parent.Content, aType);
            }

            public static Type LazyTypeResolver(Block parent, LazyExpr value, A.Type? aType)
            {
                if (aType != null)
                {
                    return parent.Resolver.T.ResolveType(parent.Content, aType);
                }
                else
                {
                    return value.Expr.Type;
                }
            }
        }
    }
}
