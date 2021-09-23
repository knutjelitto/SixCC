using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public sealed class ClassDeclaration : Node, Declaration
    {
        public ClassDeclaration(ClassHeader header, Definition definition)
        {
            Header = header;
            Definition = definition;
        }

        public ClassHeader Header { get; }
        public Definition Definition { get; }
    }

    public sealed class ClassHeader : Node
    {
        public ClassHeader(Annotations annotations, Name name, TypeParameters? typeParameters, Parameters? parameters, ClassInheritance inheritance, TypeConstraints? constraints)
        {
            Annotations = annotations;
            Name = name;
            TypeParameters = typeParameters;
            Parameters = parameters;
            Inheritance = inheritance;
            Constraints = constraints;
        }

        public Annotations Annotations { get; }
        public Name Name { get; }
        public TypeParameters? TypeParameters { get; }
        public Parameters? Parameters { get; }
        public ClassInheritance Inheritance { get; }
        public TypeConstraints? Constraints { get; }
    }

    public sealed class ClassDefinition : Node, Definition
    {
        public ClassDefinition(ClassSpecifier specifier)
        {
            Specifier = specifier;
        }

        public ClassSpecifier Specifier { get; }
    }

    public abstract class ClassSpecifier : Node, Definition
    {
    }

    public sealed class ExtensionSpecifier : ClassSpecifier
    {
        public ExtensionSpecifier(Extension extension)
        {
            Extension = extension;
        }

        public Extension Extension { get; }
    }

    public sealed class ConstructionSpecifier : ClassSpecifier
    {
        public ConstructionSpecifier(Construction construction)
        {
            Construction = construction;
        }

        public Construction Construction { get; }
    }

    public sealed class ClassInheritance : Node
    {
        public ClassInheritance(CaseTypes? caseTypes, ExtendedType? extended, SatisfiedTypes? satisfiedTypes)
        {
            CaseTypes = caseTypes;
            Extended = extended;
            SatisfiedTypes = satisfiedTypes;
        }

        public CaseTypes? CaseTypes { get; }
        public ExtendedType? Extended { get; }
        public SatisfiedTypes? SatisfiedTypes { get; }
    }
}
