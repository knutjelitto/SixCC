using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public virtual void Visit(Rule rule)
        {
        }

        public abstract void Visit(TermAlternatives term);
        public abstract void Visit(TermSequence term);
        public abstract void Visit(TermGroup term);
        public abstract void Visit(TermEmpty term);
        public abstract void Visit(TermIdentifier term);
        public abstract void Visit(TermLiteral term);
        public abstract void Visit(TermRange term);
    }
}
