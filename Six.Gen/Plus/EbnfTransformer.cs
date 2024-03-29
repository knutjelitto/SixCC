﻿namespace Six.Gen.Ebnf
{
    public abstract class EbnfTransformer<T>
    {
        protected void Transform(EbnfGrammar grammar)
        {
            foreach (var op in grammar.Operators)
            {
                Transform(op);
            }    
        }

        protected T Transform(CoreOp expression)
        {
            switch (expression)
            {
                case AltOp expr:
                    return Visit(expr);
                case AnyOp expr:
                    return Visit(expr);
                case PlusOp expr:
                    return Visit(expr);
                case RangeOp expr:
                    return Visit(expr);
                case SetOp expr:
                    return Visit(expr);
                case RefOp expr:
                    return Visit(expr);
                case StartRuleOp expr:
                    return Visit(expr);
                case WhiteRuleOp expr:
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
                case NotOp expr:
                    return Visit(expr);
                case EofOp expr:
                    return Visit(expr);
                default:
                    throw new NotImplementedException($"can't visit expression of type {expression.GetType()}");
            }
        }

        protected virtual T Visit(AltOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(AnyOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(NotOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(EofOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(OptionalOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(PlusOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(RangeOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(SetOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(RefOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(RuleOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(StartRuleOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(WhiteRuleOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(SeqOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(StarOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(StringOp op)
        {
            throw new NotImplementedException();
        }

        protected virtual T Visit(TokenOp op)
        {
            throw new NotImplementedException();
        }
    }
}
