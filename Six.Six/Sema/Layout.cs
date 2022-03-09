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

        public Layout(Layout? baseLayout)
        {
            Base = baseLayout;
        }

        public Layout? Base { get; }

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
