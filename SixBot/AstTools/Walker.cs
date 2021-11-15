﻿namespace SixBot.Ast
{
    internal class Walker
    {
        public void Walk(Grammar grammar)
        {
            Visit(grammar);
        }

        public void Walk(Rule rule)
        {
            Visit(rule);
        }

        public void Walk(Expression expression)
        {
            Visit((dynamic)expression);
        }

        protected virtual void Visit(Grammar grammar)
        {
            foreach (var rule in grammar.Rules)
            {
                Walk(rule);
            }
        }

        protected virtual void Visit(Rule rule)
        {
            Walk(rule.Expression);
        }

        private void Visit(Expression expression)
        {
            throw new NotImplementedException($"can't visit expression of type {expression.GetType()}");
        }

        protected virtual void Visit(Reference reference)
        {
        }

        protected virtual void Visit(Alt alt)
        {
            foreach (var expression in alt.Expressions)
            {
                Walk(expression);
            }
        }

        protected virtual void Visit(Seq seq)
        {
            foreach (var expression in seq.Expressions)
            {
                Walk(expression);
            }
        }

        protected virtual void Visit(Nonterminal non)
        {
        }

        protected virtual void Visit(Terminal term)
        {
        }

        protected virtual void Visit(Epsilon epsilon)
        {
        }

        protected virtual void Visit(Undefined undefined)
        {
        }

        protected virtual void Visit(Substract substract)
        {
        }

        protected virtual void Visit(Range range)
        {
        }
    }

    internal class Walker<T>
    {

    }
}
