using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class SwitchCaseElseExpression : Node, Expression
    {
        public SwitchCaseElseExpression(Switch @switch, CaseExpressions cases, ElseExpressionPart? elsePart)
        {
            Switch = @switch;
            Cases = cases;
            ElsePart = elsePart;
        }

        public Switch Switch { get; }
        public CaseExpressions Cases { get; }
        public ElseExpressionPart? ElsePart { get; }
    }

    public sealed class CaseExpressions : NodeList<CaseExpression>
    {
        public CaseExpressions(IEnumerable<CaseExpression> items) : base(items)
        {
        }
    }
    public sealed class CaseExpression : Node
    {
        public CaseExpression(CaseCondition condition, Expression expression)
        {
            Condition = condition;
            Expression = expression;
        }

        public CaseCondition Condition { get; }
        public Expression Expression { get; }
    }
}
