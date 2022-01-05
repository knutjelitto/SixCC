namespace Six.Gen.Ebnf
{
    internal abstract class EbnfPredicator : EbnfWalker
    {
        protected EbnfPredicator(Func<CoreOp, bool> getter, Action<CoreOp, bool> setter)
        {
            this.getter = getter;
            this.setter = setter;
        }

        protected bool Changed = false;
        private readonly Func<CoreOp, bool> getter;
        private readonly Action<CoreOp, bool> setter;

        protected void Set(CoreOp expression, bool newValue)
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
