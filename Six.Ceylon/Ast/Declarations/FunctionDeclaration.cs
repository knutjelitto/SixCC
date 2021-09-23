using System.Collections.Generic;
using System.Linq;

namespace Six.Ceylon.Ast
{
    public sealed class FunctionDeclaration : Node, Declaration
    {
        public FunctionDeclaration(FunctionHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public FunctionHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class FunctionHeader : Node
    {
        public FunctionHeader(Annotations annotations, Type prefix, Name name, TypeParameters? typeParameters, ParametersList parameters, TypeConstraints? constraints)
        {
            Annotations = annotations;
            Prefix = prefix;
            Name = name;
            TypeParameters = typeParameters;
            Parameters = parameters;
            Constraints = constraints;
        }

        public Annotations Annotations { get; }
        public Type Prefix { get; }
        public Name Name { get; }
        public TypeParameters? TypeParameters { get; }
        public ParametersList Parameters { get; }
        public TypeConstraints? Constraints { get; }
    }

    public sealed class FunctionBlock : Node
    {
        public FunctionBlock(Block? block)
        {
            Block = block;
        }

        public Block? Block { get; }
    }

}
