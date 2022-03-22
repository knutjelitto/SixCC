namespace Six.Six.Sema
{
    public interface Typy
    {
    }

    public interface Type : Typy, Entity
    {
        public interface Declared : Type
        {
            Decl Decl { get; }
        }

        public interface Builtin : Type
        {
        }

        [DebuggerDisplay("reference <{Decl}>")]
        public abstract class Reference : Declared
        {
            public Reference(Decl decl)
            {
                Decl = decl;
            }

            public Decl Decl { get; }
            
            public override string ToString()
            {
                return $"{Decl.Name}";
            }
        }

        public sealed class AliasReference : Reference
        {
            public AliasReference(Decl.Alias alias) : base(alias)
            {

            }
        }
        
        public abstract class ClassyReference : Reference
        {
            protected ClassyReference(Decl.Classy classy) : base(classy)
            {
                Classy = classy;
            }

            public Decl.Classy Classy { get; }
        }

        public sealed class ClassReference : ClassyReference
        {
            public ClassReference(Decl.Class @class) : base(@class)
            {
                Class = @class;
            }

            public Decl.Class Class { get; }
        }

        public sealed class InterfaceReference : ClassyReference
        {
            public InterfaceReference(Decl.Interface @interface) : base(@interface)
            {
                Interface = @interface;
            }

            public Decl.Interface Interface { get; }
        }

        public sealed class ObjectReference : ClassyReference
        {
            public ObjectReference(Decl.Object @object) : base(@object)
            {
                Object = @object;
            }

            public Decl.Object Object { get; }
        }

        public sealed class Callable : Type
        {
            public Callable(Type result, params Type[] parameters)
                : this(result, parameters.ToList())
            {
            }

            public Callable(Type result, List<Type> parameters)
            {
                Result = result;
                Parameters = parameters;
            }

            public Type Result { get; }
            public IReadOnlyList<Type> Parameters { get; }
        }

        public sealed class Intersection : Type
        {
            private readonly List<Type> types = new();
            
            public Intersection()
            {
            }

            public void Add(Type type)
            {
                types.Add(type);
            }
        }

        public sealed class Tuple : TypeImpl
        {
            public Tuple(params Type[] types)
            {
                Types = types;
            }

            public Type[] Types { get; }
        }

        public sealed class Array : TypeImpl
        {
            public Array(Type type)
            {
                Type = type;
            }

            public Type Type { get; }
        }
     
        public abstract class TypeImpl : Type
        {
        }
    }
}
