﻿namespace Six.Ast
{
    internal class PredicateBuilder : Walker
    {
        protected PredicateBuilder(Func<Expression, bool> getter, Action<Expression, bool> setter)
        {
            this.getter = getter;
            this.setter = setter;
        }

        protected bool Changed = false;
        private readonly Func<Expression, bool> getter;
        private readonly Action<Expression, bool> setter;

        protected override void Visit(AstGrammar grammar)
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                base.Visit(grammar);
            }
        }

        protected void Set(Expression expression, bool newValue)
        {
            if (getter(expression) != newValue)
{
                Changed = true;
                setter(expression, newValue);
            }
        }
    }
}
