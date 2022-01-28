namespace Six.Ceylon.Ast
{
    public class Statement
    {
        public virtual string ItemKind => GetType().Name.ToLowerInvariant();

        public class ConditionalBlock : Statement
        {
            public ConditionalBlock(ConditionList conditions, Block block)
            {
                Conditions = conditions;
                Block = block;
            }

            public ConditionList Conditions { get; }
            public Block Block { get; }
        }

        public sealed class Break : Statement { }

        public sealed class Continue : Statement { }

        public sealed class Return : Statement
        {
            public Return(IExpression? expr)
            {
                Expr = expr;
            }

            public IExpression? Expr { get; }
        }

        public sealed class Throw : Statement
        {
            public Throw(IExpression? expr)
            {
                Expr = expr;
            }

            public IExpression? Expr { get; }
        }

        public sealed class If : Statement
        {
            public If(IEnumerable<ConditionalBlock> conditionals, Block? elseBlock)
            {
                Conditionals = conditionals.ToList();
                ElseBlock = elseBlock;
            }

            public IReadOnlyList<ConditionalBlock> Conditionals { get; }
            public Block? ElseBlock { get; }
        }


        public sealed class For : Statement
        {
            public For(ForIterator? iterator, Block block, Block? elseBlock)
            {
                Iterator = iterator;
                Block = block;
                ElseBlock = elseBlock;
            }

            public ForIterator? Iterator { get; }
            public Block Block { get; }
            public Block? ElseBlock { get; }
        }

        public sealed class ForIterator
        {
            public ForIterator(Pattern variable, Containment? containment)
            {
                Variable = variable;
                Containment = containment;
            }

            public Pattern Variable { get; }
            public Containment? Containment { get; }
        }

        public sealed class Containment
        {
            public Containment(string op, IExpression expr)
            {
                Op = op;
                Expr = expr;
            }

            public string Op { get; }
            public IExpression Expr { get; }
        }

        public sealed class While : ConditionalBlock
        {
            public While(ConditionList conditions, Block block)
                : base(conditions, block)
            {
            }
        }

        public class Specification : Statement
        {
            public Specification(IExpression primary, IExpression value)
            {
                Primary = primary;
                Value = value;
            }

            public IExpression Primary { get; }
            public IExpression Value { get; }
        }

        public class Expression : Statement
        {
            public Expression(IExpression expression)
            {
                Expr = expression;
            }

            public IExpression Expr { get; }
        }

        public class Assertion : Statement
        {
            public Assertion(String? message, ConditionList conditions)
            {
                Message = message;
                Conditions = conditions;
            }

            public String? Message { get; }
            public ConditionList Conditions { get; }
        }
    }
}
