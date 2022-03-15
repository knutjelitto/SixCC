using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public class Layout
    {
        private readonly List<Field> fields = new();
        private readonly List<Decl.Field> declaredFields = new();

        public Layout(Decl.Classy classy)
        {
            Classy = classy;
        }

        public Decl.Classy Classy { get; }
        public Module Module => Classy.Scope.Module;
        public Resolver Resolver => Module.Resolver;

        public void Add(Decl.Field declaredField)
        {
            declaredFields.Add(declaredField);
        }

        public void Finish()
        {
            foreach (var attribute in declaredFields)
            {
                var type = Resolver.LowerType(attribute.Type);
            }
        }

        public class Field
        {
            public Field(Field? prevField, Decl.Attribute attribute)
            {
                Prev = prevField;
                Attribute = attribute;
            }

            public Field? Prev { get; }
            public Decl.Attribute Attribute { get; }
        }
    }
}
