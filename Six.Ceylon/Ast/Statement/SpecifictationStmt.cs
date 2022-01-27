namespace Six.Ceylon.Ast
{
    public class SpecificationStmt : Statement
    {
        public SpecificationStmt(IExpression primary, IExpression specification)
        {
            Primary = primary;
            Specification = specification;
        }

        public IExpression Primary { get; }
        public IExpression Specification { get; }
    }
}
