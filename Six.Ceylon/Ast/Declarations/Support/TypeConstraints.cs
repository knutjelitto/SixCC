using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class TypeConstraints : NodeList<TypeConstraint>
    {
        public TypeConstraints(IEnumerable<TypeConstraint> items) : base(items)
        {
        }
    }

    public sealed class TypeConstraint : Node
    {
        public TypeConstraint(Name typeName, TypeParameters? parameters, TypeConstraintInheritance inheritance)
        {
            TypeName = typeName;
            Parameters = parameters;
            Inheritance = inheritance;
        }

        public Name TypeName { get; }
        public TypeParameters? Parameters { get; }
        public TypeConstraintInheritance Inheritance { get; }
    }

    public sealed class TypeConstraintInheritance : Node
    {
        public TypeConstraintInheritance(CaseTypes? caseTypes, SatisfiedTypes? satisfiedTypes, AbstractedType? abstractedType)
        {
            CaseTypes = caseTypes;
            SatisfiedTypes = satisfiedTypes;
            AbstractedType = abstractedType;
        }

        public CaseTypes? CaseTypes { get; }
        public SatisfiedTypes? SatisfiedTypes { get; }
        public AbstractedType? AbstractedType { get; }
    }
}
