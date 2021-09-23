using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class Annotations : NodeList<Annotation>
    {
        public Annotations(String? docString, IEnumerable<Annotation> items)
            : base(items)
        {
            DocString = docString;
        }

        public String? DocString { get; }
    }

    public sealed class Annotation : Node
    {
        public Annotation(Name name, Arguments? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Name Name { get; }
        public Arguments? Arguments { get; }
    }
}
