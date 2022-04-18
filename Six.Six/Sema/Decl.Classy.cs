using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public abstract class Classy : Declaration, Type.Declared
        {
            private ClassLayout? layout;
            private Class? extends;
            private List<Interface>? satisfies;

            protected Classy(Block parent, A.Decl.Classy aDecl)
                : base(parent, aDecl)
            {
                Block = new ClassBlock(parent, this);
                AClassy = aDecl;
                parent.DeclareContent(this, aDecl.Name.Text);
            }

            public ClassBlock Block { get; }
            public A.Decl.Classy AClassy { get; }
            public ClassLayout Layout => layout ??= new ClassLayout(this);

            public ClassMembers Members { get; } = new();

            public IReadOnlyList<Field> Fields => Members.Fields;


            public override string FullName => Block.FullName();
            public sealed override Type Type => this;

            public Class? Extends => extends ??= Resolver.T.ResolveExtends(this);
            public List<Interface> Satisfies => satisfies ??= Resolver.T.ResolveSatisfies(this);

            public Decl Decl => this;
        }

        public class Class : Classy
        {
            public Class(Block parent, A.Decl.Class aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);
            }

            public override string ToString() => $"{Name}";
        }

        public class Object : Classy
        {
            public Object(Block parent, A.Decl.Object aDecl)
                : base(parent, aDecl)
            {
                Assert(aDecl is A.With.Extends);
            }

            public override string ToString() => $"{Name}";
        }

        public class Interface : Classy
        {
            public Interface(Block parent, A.Decl.Interface aDecl)
                : base(parent, aDecl)
            {
            }
        }
    }
}
