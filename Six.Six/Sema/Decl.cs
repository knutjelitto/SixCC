using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl : Member
    {
        A.Decl ADecl { get; }
        Type Type { get; }
        string Name { get; }
        string FullName { get; }

        Module Module { get; }
        Resolver Resolver { get; }

        bool IsStatic { get; }
        bool IsNative { get; }
        bool IsShared { get; }
        bool IsSealed { get; }

        public abstract class Local : Declaration
        {
            public Local(Block parent, A.Decl ADecl, int index)
                : base(parent, ADecl)
            {
                Index = index;
            }

            public Local(FuncBlock parent, A.Decl ADecl)
                : base(parent, ADecl)
            {
                Index = parent.Funcy.NextLocalSlot;
            }

            public int Index { get; }

            public override string FullName => ADecl.Name.Text;
        }

        public sealed class Parameter : Local
        {
            private readonly LazyExpr? deFault;

            public Parameter(FuncBlock parent, A.Decl.Parameter ADecl, LazyExpr? deFault)
                : base(parent, ADecl)
            {
                Assert(ADecl is A.With.Type);
                parent.Funcy.AddParameter(this);
                this.deFault = deFault;
            }

            public Expr? Default
            { 
                get
                {
                    if (deFault != null)
                    {
                        return deFault.Expr;
                    }
                    return null;
                }
            }

            public override Type Type =>
                type ??= Resolver.ResolveType(Container, ((A.With.Type)ADecl).Type);
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
                : base(parent, ADecl, parent.Funcy.NextLocalSlot)
            {
                Assert(ADecl is A.With.OptionalType);
                Assert(ADecl is A.With.Value);
                value = Resolver.ResolveExpression(Container, ((A.With.Value)ADecl).Value);
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
                            type = Resolver.ResolveType(Container, aType);
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
                value = Resolver.ResolveExpression(parent.Content, ((A.With.Value)aDecl).Value);
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
                            type = Resolver.ResolveType(Container, aType);
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
                lazyValue = Resolver.ResolveExpression(parent.Content, ALetVar.Value);
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


        [DebuggerDisplay("{GetType().Name.ToLowerInvariant()} {Name}")]
        public abstract class Declaration : Decl
        {
            protected Type? type = null;

            public Declaration(Block parent, A.Decl aDecl)
            {
                Parent = parent;
                ADecl = aDecl;
            }

            public Block Parent { get; }
            public Scope Container => Parent.Content;
            public A.Decl ADecl { get; }
            public abstract Type Type { get; }
            public string Name => ADecl.Name.Text;
            public abstract string FullName { get; }

            public Module Module => Container.Module;
            public Resolver Resolver => Container.Module.Resolver;

            public bool IsShared => ADecl.IsShared();
            public bool IsNative => ADecl.IsNative();
            public bool IsStatic => ADecl.IsStatic();

            public bool IsAbstract => ADecl.IsAbstract();
            public bool IsOverride => ADecl.IsOverride();
            public bool IsVirtual => ADecl.IsVirtual();
            public bool IsSealed => ADecl.IsSealed();

            public bool IsPrefinal => ADecl.IsPrefinal();
        }
    }
}
