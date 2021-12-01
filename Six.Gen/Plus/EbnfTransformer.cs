namespace Six.Gen.Ebnf
{
    public abstract class EbnfTransformer
    {
        protected void Transform(EbnfGrammar grammar)
        {
            foreach (var op in grammar.Inner)
            {
                Transform(op);
            }    
        }

        protected Operator Transform(Operator expression)
        {
            switch (expression)
            {
                case AltOp expr:
                    return Visit(expr);
                case AndOp expr:
                    return Visit(expr);
                case AnyOp expr:
                    return Visit(expr);
                case CharacterOp expr:
                    return Visit(expr);
                case EpsilonOp expr:
                    return Visit(expr);
                case NotOp expr:
                    return Visit(expr);
                case PlusOp expr:
                    return Visit(expr);
                case RangeOp expr:
                    return Visit(expr);
                case RefOp expr:
                    return Visit(expr);
                case RuleOp expr:
                    return Visit(expr);
                case SeqOp expr:
                    return Visit(expr);
                case StringOp expr:
                    return Visit(expr);
                case TokenOp expr:
                    return Visit(expr);
                case StarOp expr:
                    return Visit(expr);
                case OptionalOp expr:
                    return Visit(expr);
                default:
                    throw new NotImplementedException($"can't visit expression of type {expression.GetType()}");
            }
        }

        protected virtual Operator Visit(AltOp op)
        {
            return op;
        }

        protected virtual Operator Visit(AndOp op)
        {
            return op;
        }

        protected virtual Operator Visit(AnyOp op)
        {
            return op;
        }

        protected virtual Operator Visit(CharacterOp op)
        {
            return op;
        }

        protected virtual Operator Visit(EpsilonOp op)
        {
            return op;
        }

        protected virtual Operator Visit(NotOp op)
        {
            return op;
        }

        protected virtual Operator Visit(OptionalOp op)
        {
            return op;
        }

        protected virtual Operator Visit(PlusOp op)
        {
            return op;
        }

        protected virtual Operator Visit(RangeOp op)
        {
            return op;
        }

        protected virtual Operator Visit(RefOp op)
        {
            return op;
        }

        protected virtual Operator Visit(RuleOp op)
        {
            return op;
        }

        protected virtual Operator Visit(SeqOp op)
        {
            return op;
        }

        protected virtual Operator Visit(StarOp op)
        {
            return op;
        }

        protected virtual Operator Visit(StringOp op)
        {
            return op;
        }

        protected virtual Operator Visit(TokenOp op)
        {
            return op;
        }
    }
}
