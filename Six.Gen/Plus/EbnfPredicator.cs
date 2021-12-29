namespace Six.Gen.Ebnf
{
    internal abstract class EbnfPredicator<Operator> : EbnfWalker<Operator>
        where Operator : CoreOp
    {
        protected EbnfPredicator(Func<Operator, bool> getter, Action<Operator, bool> setter)
        {
            this.getter = getter;
            this.setter = setter;
        }

        protected bool Changed = false;
        private readonly Func<Operator, bool> getter;
        private readonly Action<Operator, bool> setter;

        protected void Set(Operator expression, bool newValue)
        {
            if (getter(expression) != newValue)
            {
                Changed = true;
                setter(expression, newValue);
            }
        }

        protected override void Walk(EbnfGrammar grammar)
        {
            Changed = true;
            while (Changed)
            {
                Changed = false;
                base.Walk(grammar);
            }
        }
    }
}
