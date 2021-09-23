namespace Six.Ceylon.Ast
{
    public sealed class InfixExpression : Node, Expression
    {
        public InfixExpression(Terminal @operator, Expression operand1, Expression operand2)
        {
            Operator = @operator;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public Terminal Operator { get; }
        public Expression Operand1 { get; }
        public Expression Operand2 { get; }
    }
}
