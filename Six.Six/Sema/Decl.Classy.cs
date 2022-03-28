using Six.Six.Instructions;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public partial interface Decl
    {
        public abstract class Classy : Declaration, Typy
        {
            private ClassLayout? layout;
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
            public ClassLayout Layout => layout ??= new ClassLayout(this);

            public IReadOnlyList<Field> Fields { get; } = new List<Field>();


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

                Type = new Type.ClassReference(Module, this);
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

                Type = new Type.ObjectReference(Module, this);
            }

            public override Type Type { get; }

            public override string ToString() => $"{Name}";
        }

        public class Interface : Classy
        {
            public Interface(Block parent, A.Decl.Interface aDecl)
                : base(parent, aDecl)
            {

                Type = new Type.InterfaceReference(Module, this);
            }

            public override Type Type { get; }
        }
    }
}
