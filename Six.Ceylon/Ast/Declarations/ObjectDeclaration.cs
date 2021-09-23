using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class ObjectDeclaration : Node, Declaration
    {
        public ObjectDeclaration(ObjectHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public ObjectHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class ObjectHeader : Node
    {
        public ObjectHeader(Annotations annotations, Name name, ObjectInheritance inheritance)
        {
            Annotations = annotations;
            Name = name;
            Inheritance = inheritance;
        }

        public Annotations Annotations { get; }
        public Name Name { get; }
        public ObjectInheritance Inheritance { get; }
    }

    public sealed class ObjectInheritance : Node
    {
        public ObjectInheritance(ExtendedType? extended, SatisfiedTypes? satisfied)
        {
            Extended = extended;
            Satisfied = satisfied;
        }

        public ExtendedType? Extended { get; }
        public SatisfiedTypes? Satisfied { get; }
    }
}
