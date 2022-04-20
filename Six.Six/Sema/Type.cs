using System;
using System.Collections;

namespace Six.Six.Sema
{
    public interface Type : Entity
    {
        public interface Declared : Type
        {
            Decl Decl { get; }
        }

        public interface Builtin : Type
        {
        }

        public sealed class Callable : TypeImpl
        {
            public Callable(Module module, Type result, params Type[] parameters)
                : this(module, result, parameters.ToList())
            {
            }

            public Callable(Module module, Type result, List<Type> parameters)
                : base(module)
            {
                Result = result;
                Parameters = parameters;
            }

            public Type Result { get; }
            public IReadOnlyList<Type> Parameters { get; }
        }

        public sealed class Intersection : TypeImpl, IReadOnlyList<Type>
        {
            private readonly List<Type> types = new();
            
            public Intersection(Module module)
                : base(module)
            {
            }

            public void Add(Type distinctType)
            {
                foreach (var type in types)
                {
                    Assert(Checker.Distinct(type, distinctType));
                }
                types.Add(distinctType);
            }

            public void AddRange(IEnumerable<Type> distinctTypes)
            {
                foreach (var distinctType in distinctTypes)
                {
                    Add(distinctType);
                }
            }
            
            public override string ToString()
            {
                return string.Join("&", types);
            }

            public Type this[int index] => types[index];
            public int Count => types.Count;
            public IEnumerator<Type> GetEnumerator() => types.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)types).GetEnumerator();
        }

        public sealed class Tuple : TypeImpl
        {
            public Tuple(Module module, params Type[] types)
                : base(module)
            {
                Types = types;
            }

            public Type[] Types { get; }
        }

        public sealed class Array : TypeImpl
        {
            public Array(Module module, Type type)
                : base(module)
            {
                Type = type;
            }

            public Type Type { get; }
        }

        public sealed class Void : TypeImpl
        {
            public Void(Module module) : base(module)
            {
            }
        }

        public abstract class TypeImpl : Type
        {
            protected TypeImpl(Module module)
            {
                Module = module;
            }

            protected Module Module { get; }
            protected TypeChecker Checker => Module.Checker;
        }
    }
}
