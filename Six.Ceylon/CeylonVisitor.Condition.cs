using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CConditions element)
        {
            // '('
            var items = Walk<List<Condition>>(element.ConditionListOptional);
            // ')'
        }

        protected override void Visit(CConditionList element)
        {
            var conditions = new List<Condition>();

            foreach (var child in element.Children)
            {
                var condition = Walk<Condition>(child);
                if (condition == null)
                {
                    Assert(true);
                    condition = Walk<Condition>(child);
                }
                conditions.Add(condition!);
            }

            element.Value = conditions;
        }

        protected override void Visit(CExistsCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNonemptyCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIsCondition element)
        {
            var not = Exists(element.LiteralOptional);
            // 'is'
            var type = Walk<Ast.Type>(element.Type);
            var variable = Walk<Variable>(element.IsConditionVariable);

            element.Value = new IsCondition(not, type!, variable!);
        }

        protected override void Visit(CIsConditionVariable element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var value = Walk<Expression>(element.ValueSpecifierOptional);

            element.Value = new Variable(name!, value);
        }

    }
}
