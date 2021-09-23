using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class SwitchCaseElseStatement : Node, Statement
    {
        public SwitchCaseElseStatement(Switch @switch, SwitchCases cases, ElsePart? elsePart)
        {
            Switch = @switch;
            Cases = cases;
            ElsePart = elsePart;
        }

        public Switch Switch { get; }
        public SwitchCases Cases { get; }
        public ElsePart? ElsePart { get; }
    }

    public sealed class CaseStatementCase : Node
    {
        public CaseStatementCase(CaseCondition condition, BlockDefinition block)
        {
            Condition = condition;
            Block = block;
        }

        public CaseCondition Condition { get; }
        public BlockDefinition Block { get; }
    }
    public sealed class SwitchCases : NodeList<CaseStatementCase>
    {
        public SwitchCases(IEnumerable<CaseStatementCase> items) : base(items)
        {
        }
    }
}
