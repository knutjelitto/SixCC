﻿using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Decl : Member
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

        bool Validated { get; set; }

        public abstract class Classy : Declaration, Typy
        {
            private Layout? layout;
            private Class? extends;
            private List<Interface>? satisfies;

            public Classy(Block parent, A.Decl.Classy aDecl)
                : base(parent, aDecl)
            {
                Block = new ClassBlock(this, parent);
                AClassy = aDecl;
                parent.Content.Declare(this, aDecl.Name.Text);
                parent.Members.Add(this);
            }

            public ClassBlock Block { get; }
            public A.Decl.Classy AClassy { get; }

            public IReadOnlyList<Field> Fields { get; } = new List<Field>();

            public Layout Layout
            {
                get
                {
                    if (layout == null)
                    {
                        layout = new Layout(this);
                        layout.Run();
                    }
                    return layout;
                }
            }

            public override string FullName => Block.FullName();

            public Class? Extends => extends ??= Resolver.ResolveExtends(this);
            public List<Interface> Satisfies => satisfies ??= Resolver.ResolveSatisfies(this);

            public void AddField(Field field)
            {
                ((List<Field>)Fields).Add(field);
                Block.Members.Add(field);
            }

        }

        public class Class : Classy
        {
            public Class(Block parent, A.Decl.Class aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);

                Type = new Type.ClassReference(this);
            }

            public override Type Type { get; }

            public override string ToString() => $"{Name}";
        }

        public class Object : Classy
        {
            public Object(Block parent, A.Decl.Object aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);

                Type = new Type.ObjectReference(this);
            }

            public override Type Type { get; }

            public override string ToString() => $"{Name}";
        }

        public class Interface : Classy
        {
            public Interface(Block parent, A.Decl.Interface aDecl)
                : base(parent, aDecl)
            {

                Type = new Type.InterfaceReference(this);
            }

            public override Type Type { get; }
        }

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
            private readonly LazyExpr value;

            public Global(NamespaceBlock parent, A.Decl aDecl, bool writeable)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.OptionalType);
                Assert(aDecl is A.With.Value);
                value = Resolver.ResolveExpression(parent.Content, ((A.With.Value)aDecl).Value);
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

            public bool Validated { get; set; }
        }
    }
}
