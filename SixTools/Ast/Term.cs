using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixTools.Ast
{
    public class Term
    {
    }

    public class TermEmpty : Term
    {
    }

    public class TermGroup : Term
    {
        public TermGroup(Term term, int min = 1, int max = 1)
        {
            Term = term;
            Min = min;
            Max = max;
        }

        public Term Term { get; set; }
        public int Min { get; }
        public int Max { get; }
    }

    public class TermOptional : TermGroup
    {
        public TermOptional(Term inner)
            : base(inner, 0, 1)
        { }
    }

    public class TermOneOrMore : TermGroup
    {
        public TermOneOrMore(Term inner) : base(inner, 1, 0)
        {
        }
    }

    public class TermZeroOrMore : TermGroup
    {
        public TermZeroOrMore(Term inner) : base(inner, 0, 0)
        {
        }
    }

    public class TermAlternatives : Term
    {
        public TermAlternatives(Term first, IEnumerable<Term> rest)
        {
            Terms = new List<Term> { first };
            Terms.AddRange(rest);
        }

        public List<Term> Terms { get; }
    }

    public class TermSequence : Term
    {
        public TermSequence(IEnumerable<Term> terms)
        {
            Terms = terms.ToList();
        }

        public List<Term> Terms { get; }
    }

    public class TermIdentifier : Term
    {
        public TermIdentifier(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class TermLiteral : Term
    {
        public TermLiteral(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class TermNot : Term
    {
        public TermNot(Term term)
        {
            Term = term;
        }

        public Term Term { get; }
    }

    public class TermRange : Term
    {
        public TermRange(TermLiteral start, TermLiteral stop)
        {
            Start = start;
            Stop = stop;
        }

        public TermLiteral Start { get; }
        public TermLiteral Stop { get; }
    }
}
