using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl : Member
    {
        A.Decl ADecl { get; }
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

            public override string FullName => ADecl.Name.Text;
        }

        public sealed class Parameter : Local
        {
            private readonly LazyExpr? lazyDefault;

            public Parameter(FuncBlock parent, A.Decl.Parameter ADecl, LazyExpr? lazyDefault)
                : base(parent, ADecl)
            {
                Assert(ADecl is A.With.Type);
                parent.Funcy.AddParameter(this);
                this.lazyDefault = lazyDefault;
            }

            public Expr? Default => lazyDefault?.Expr;

            public override Type Type =>
                type ??= Resolver.ResolveType(Parent.Content, ((A.With.Type)ADecl).Type);
        }

        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {SelfName}")]
        public sealed class SelfParameter : Local
        {
            public SelfParameter(FuncBlock parent, Type type)
                : base(parent, new A.Decl.SelfValue(new A.Name.ArtificalId(parent.Funcy.AFuncy.Name.Tree, Names.Core.SelfValue)))
            {
                parent.Funcy.AddParameter(this);
                parent.Head.Declare(this, Names.Core.SelfValue);
                Type = type;
            }

            public static string SelfName => Names.Core.SelfValue;

            public override Type Type { get; }
        }

        public sealed class LetVar : Local
        {
            private readonly LazyExpr value;

            public LetVar(FuncBlock parent, A.Decl ADecl, bool writeable)
                : base(parent, ADecl)
            {
                Assert(ADecl is A.With.OptionalType);
                Assert(ADecl is A.With.Value);
                value = Resolver.ResolveExpression(Parent, ((A.With.Value)ADecl).Value);
                Writeable = writeable;
                parent.Funcy.AddLocal(this);
            }

            public bool Writeable { get; }

            public override Type Type
            {
                get
                {
                    if (type == null)
                    {
                        //TODO: typecheck
                        var aType = ((A.With.OptionalType)ADecl).Type;
                        if (aType != null)
                        {
                            type = Resolver.ResolveType(Parent.Content, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => value.Expr;
        }

        public sealed class Field : Declaration
        {
            private readonly LazyExpr value;

            public Field(ClassBlock parent, A.Decl aDecl, bool writeable)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.OptionalType);
                Assert(aDecl is A.With.Value);
                value = Resolver.ResolveExpression(parent, ((A.With.Value)aDecl).Value);
                Writeable = writeable;
                parent.Classy.AddField(this);
            }

            public bool Writeable { get; }
            public uint Offset { get; set; } = uint.MaxValue;

            public override Type Type
            {
                get
                {
                    if (type == null)
                    {
                        //TODO: typecheck
                        var aType = ((A.With.OptionalType)ADecl).Type;
                        if (aType != null)
                        {
                            type = Resolver.ResolveType(Parent.Content, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => value.Expr;

            public override string FullName => ADecl.Name.Text;
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
                lazyValue = Resolver.ResolveExpression(parent, ALetVar.Value);
                Writeable = writeable;
                parent.Members.Add(this);
            }

            public bool Writeable { get; }

            public override Type Type
            {
                get
                {
                    if (type == null)
                    {
                        //TODO: typecheck
                        var aType = ALetVar.Type;
                        if (aType != null)
                        {
                            type = Resolver.ResolveType(Parent.Content, aType);
                        }
                        else
                        {
                            type = Value.Type;
                        }
                    }

                    return type;
                }
            }

            public Expr Value => lazyValue.Expr;

            public override string FullName => $"{Parent.FullName()}.{ADecl.Name}";
        }

        public sealed class Alias : Declaration, Typy
        {
            public Alias(Block parent, A.Decl.Alias aDecl)
                : base(parent, aDecl)
            {
                Assert(ADecl is A.With.Type);
                parent.Content.Declare(this);
            }

            public override string FullName => $"{Parent.FullName()}.{ADecl.Name}";


            public override Type Type =>
                type ??= Resolver.ResolveType(Parent.Content, ((A.With.Type)ADecl).Type);

        }


        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {FullName}")]
        public abstract class Declaration : Decl
        {
            protected Type? type = null;
            private DeclAttr? attr;

            public Declaration(Block parent, A.Decl aDecl)
            {
                Parent = parent;
                ADecl = aDecl;
            }

            public Block Parent { get; }
            public A.Decl ADecl { get; }
            public abstract Type Type { get; }
            public string Name => ADecl.Name.Text;
            public abstract string FullName { get; }

            public Module Module => Parent.Content.Module;
            public Resolver Resolver => Parent.Content.Module.Resolver;

            public bool IsNative => (Attr & DeclAttr.Native) != 0;
            public bool IsShared => (Attr & DeclAttr.Shared) != 0;
            public virtual bool IsStatic => (Attr & DeclAttr.Static) != 0;
            public bool IsVirtual => (Attr & DeclAttr.Virtual) != 0;
            public bool IsAbstract => (Attr & DeclAttr.Abstract) != 0;
            public bool IsOverride => (Attr & DeclAttr.Override) != 0;
            public bool IsSealed => (Attr & DeclAttr.Sealed) != 0;

            public bool Validated { get; set; }

            public DeclAttr Attr
            {
                get
                {
                    if (!attr.HasValue)
                    {
                        attr = DeclAttr.None;
                        if (this.IsWith(Names.Attr.Native)) attr |= DeclAttr.Native;
                        if (this.IsWith(Names.Attr.Shared)) attr |= DeclAttr.Shared;
                        if (this.IsWith(Names.Attr.Static)) attr |= DeclAttr.Static;
                        if (this.IsWith(Names.Attr.Abstract)) attr |= DeclAttr.Abstract;
                        if (this.IsWith(Names.Attr.Virtual)) attr |= DeclAttr.Virtual;
                        if (this.IsWith(Names.Attr.Override)) attr |= DeclAttr.Override;
                        if (this.IsWith(Names.Attr.Sealed)) attr |= DeclAttr.Sealed;
                    }
                    return attr.Value;
                }
            }
        }
    }
}
