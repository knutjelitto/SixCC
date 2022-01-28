using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CConditions element)
        {
            // '('
            var items = Walk<List<IExpression>>(element.ConditionList) ?? new List<IExpression>();
            // ')'

            element.Value = new ConditionList(items);
        }

        protected override void Visit(CConditionList element)
        {
            var conditions = new List<IExpression>();

            foreach (var child in element.Children)
            {
                var condition = Walk<IExpression>(child);
                if (condition == null)
                {
                    Assert(true);
                    condition = Walk<IExpression>(child);
                }
                conditions.Add(condition);
            }

            element.Value = conditions;
        }

        protected override void Visit(CExistsCondition element)
        {
            var not = Exists(element.Literal);
            // 'exists'
            var expression = Walk<Ast.IExpression>(element.LetOrExpression);

            element.Value = new ExistsCondition(not, expression);
        }

        protected override void Visit(CNonemptyCondition element)
        {
            var not = Exists(element.Literal);
            // 'nonempty'
            var expression = Walk<Ast.IExpression>(element.LetOrExpression);

            element.Value = new NonemptyCondition(not, expression);
        }

        protected override void Visit(CIsCondition element)
        {
            var not = Exists(element.Literal);
            // 'is'
            var type = Walk<Ast.Typo>(element.Type);
            var variable = Walk<ConditionVariable>(element.IsConditionVariable);

            element.Value = new IsCondition(not, type, variable);
        }

        protected override void Visit(CIsConditionVariable element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var value = Walk<IExpression>(element.ValueSpecifier);

            element.Value = new ConditionVariable(name, value);
        }

    }
}
