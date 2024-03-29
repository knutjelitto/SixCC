﻿namespace Six.Gen.Ebnf
{
    public class EbnfWalker
    {
        protected virtual void Walk(EbnfGrammar grammar)
        {
            foreach (var rule in grammar.Rules)
            {
                Walk(rule);
            }    
        }

        protected void Walk(CoreOp expression)
        {
            switch (expression)
            {
                case AltOp expr:
                    Visit(expr);
                    break;
                case AnyOp expr:
                    Visit(expr);
                    break;
                case PlusOp expr:
                    Visit(expr);
                    break;
                case RangeOp expr:
                    Visit(expr);
                    break;
                case SetOp expr:
                    Visit(expr);
                    break;
                case RefOp expr:
                    Visit(expr);
                    break;
                case RuleOp expr:
                    Visit(expr);
                    break;
                case SeqOp expr:
                    Visit(expr);
                    break;
                case StringOp expr:
                    Visit(expr);
                    break;
                case TokenOp expr:
                    Visit(expr);
                    break;
                case StarOp expr:
                    Visit(expr);
                    break;
                case OptionalOp expr:
                    Visit(expr);
                    break;
                case EofOp expr:
                    Visit(expr);
                    break;
                case NotOp expr:
                    Visit(expr);
                    break;
                default:
                    throw new NotImplementedException($"can't visit expression of type {expression.GetType()}");
            }
        }

        protected virtual void WalkArguments(CoreOp op)
        {
            foreach (var arg in op.Arguments)
            {
                Walk(arg);
            }
        }

        protected virtual void Visit(AltOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(AnyOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(NotOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(EofOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(OptionalOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(PlusOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(RangeOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(SetOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(RefOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(RuleOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(SeqOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(StarOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(StringOp op)
        {
            WalkArguments(op);
        }

        protected virtual void Visit(TokenOp op)
        {
            WalkArguments(op);
        }
    }
}
