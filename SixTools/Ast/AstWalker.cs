namespace SixTools.Ast
{
    public abstract class AstWalker
    {
        public virtual void Walk(Grammar grammar)
        {
            Visit(grammar);
            foreach (var rule in grammar.Rules)
            {
                Walk(rule);
            }
        }

        public virtual void Walk(Rule rule)
        {
            Visit(rule);
            Walk(rule.Term);
        }

        protected void Walk(AlternativesTerm term)
        {
            foreach (var sub in term)
            {
                Walk(sub);
            }
        }

        protected void Walk(SequenceTerm term)
        {
            foreach (var sub in term)
            {
                Walk(sub);
            }
        }

        protected virtual void NotImplemented()
        {
            throw new NotImplementedException();
        }

        public void Walk(Term term)
        {
            Visit((dynamic)term);
        }

        public void Visit(Term term)
        {
            throw new NotImplementedException($"visiting term of type {term.GetType()} not implemented");
        }

        public virtual void Visit(Grammar grammar)
        {
            NotImplemented();
        }

        public virtual void Visit(Rule rule)
        {
            NotImplemented();
        }

        public virtual void Visit(AlternativesTerm term)
        {
            Walk(term);
        }

        public virtual void Visit(SequenceTerm term)
        {
            Walk(term);
        }

        public virtual void Visit(TerminalTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(EpsilonTerm term)
        {
            NotImplemented();
        }

        public virtual void Visit(AnyTerm term)
        {
            NotImplemented();
        }

        public virtual void Visit(TokenTerm term)
        {
            NotImplemented();
        }

        public virtual void Visit(LiteralTerm term)
        {
            NotImplemented();
        }

        public virtual void Visit(RangeTerm term)
        {
            NotImplemented();
        }

        public virtual void Visit(NotTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(GroupTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(ClampedTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(ZeroOrOneTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(OneOrMoreTerm term)
        {
            Walk(term.Inner);
        }

        public virtual void Visit(ZeroOrMoreTerm term)
        {
            Walk(term.Inner);
        }
    }
}
