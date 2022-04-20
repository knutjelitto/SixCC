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
            public Local(Block parent, A.Decl ADecl)
                : base(parent, ADecl)
            {
            }

            public int Index { get; set; }

            public override string FullName => Name;
        }

        public class Parameter : Local
        {
            private readonly LazyExpr? lazyDefault;
            private readonly LazyType lazyType;

            public Parameter(FuncBlock parent, A.Decl.Parameter aDecl, LazyExpr? lazyDefault)
                : base(parent, aDecl)
            {
                this.lazyDefault = lazyDefault;
                lazyType = Resolver.T.ResolveTypeLazy(parent, aDecl.Type);
            }

            public Expr? Default => lazyDefault?.Value;

            public override Type Type => lazyType.Value;
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
            private readonly LazyType lazyType;

            public LetVar(CodeBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent, aDecl)
            {
                lazyValue = Resolver.E.ResolveExpression(Parent, aDecl.Value);
                lazyType = Resolver.T.ResolveTypeLazy(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
            }

            public bool Writeable { get; }

            public override Type Type => lazyType.Value;

            public Expr Value => lazyValue.Value;
        }

        public sealed class Field : Declaration
        {
            private readonly LazyExpr lazyValue;
            private readonly LazyType lazyType;

            public Field(ClassBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent, aDecl)
            {
                lazyValue = Resolver.E.ResolveExpression(parent, aDecl.Value);
                lazyType = Resolver.T.ResolveTypeLazy(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
            }

            public bool Writeable { get; }
            public uint Offset { get; set; } = uint.MaxValue;

            public override Type Type => lazyType.Value;

            public Expr Value => lazyValue.Value;

            public override string FullName => Name;

            public string StaticName => $"{Parent.FullName()}.{Name}";
        }

        public sealed class Global : Declaration
        {
            private readonly LazyExpr lazyValue;
            private readonly LazyType lazyType;

            public Global(NamespaceBlock parent, A.Decl.LetVar aDecl, bool writeable)
                : base(parent, aDecl)
            {
                Assert(aDecl.Type != null);

                lazyValue = Resolver.E.ResolveExpression(parent, aDecl.Value);
                lazyType = Resolver.T.ResolveTypeLazy(parent, lazyValue, aDecl.Type);
                Writeable = writeable;
                FullName = $"{Parent.FullName()}.{Name}";
            }

            public bool Writeable { get; }

            public override Type Type => lazyType.Value;

            public Expr Value => lazyValue.Value;

            public override string FullName { get; }
        }

        public sealed class Alias : Declaration, Type
        {
            private readonly LazyType lazyType;

            public Alias(Block parent, A.Decl.Alias aDecl)
                : base(parent, aDecl)
            {
                lazyType = Resolver.T.ResolveTypeLazy(parent, aDecl.Type);
            }

            public override string FullName => $"{Parent.FullName()}.{Name}";

            public override Type Type => lazyType.Value;

        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {FullName}")]
        public abstract class Declaration : Decl
        {
            protected Type? type = null;
            private DeclAttr? attr;

            protected Declaration(Block parent, A.Decl aDecl, string? name = null)
            {
                Parent = parent;
                Name = name ?? aDecl.Name.Text;
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
        }
    }
}
