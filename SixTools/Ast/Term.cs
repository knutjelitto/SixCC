namespace SixTools.Ast
{
    public abstract class Term
    {
        public abstract bool IsAtomic { get; }
    }

    public abstract class TermGroup : Term
    {
        public TermGroup(Term term, int min, int max)
        {
            Term = term;
            Min = min;
            Max = max;
        }

        public Term Term { get; set; }
        public int Min { get; }
        public int Max { get; }

        public override bool IsAtomic => Min == 1 && Max == 1 && Term.IsAtomic;
    }

    public class TermClamped : TermGroup
    {
        public TermClamped(Term inner)
            : base(inner, 1, 1)
        {
        }
    }

    public class TermZeroOrOne : TermGroup
    {
        public TermZeroOrOne(Term inner)
            : base(inner, 0, 1)
        {
        }
    }

    public class TermOneOrMore : TermGroup
    {
        public TermOneOrMore(Term inner)
            : base(inner, 1, 0)
        {
        }
    }

    public class TermZeroOrMore : TermGroup
    {
        public TermZeroOrMore(Term inner)
            : base(inner, 0, 0)
        {
        }
    }

    public class TermLoop : TermGroup
    {
        public TermLoop(Term inner, int min, int max)
            : base(inner, min, max)
        {
            Assert(Min >= 0);
            Assert(Max > 1 && Max >= Min);
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

        public override bool IsAtomic => Terms.Count == 1 && Terms[0].IsAtomic;
    }

    public class TermSequence : Term
    {
        public TermSequence(IEnumerable<Term> terms)
        {
            Terms = terms.ToList();
        }

        public List<Term> Terms { get; }

        public override bool IsAtomic => Terms.Count == 1 && Terms[0].IsAtomic;
    }

    public class TermEpsilon : Term
    {
        public override bool IsAtomic => false;
    }

    public class TermAny : Term
    {
        public override bool IsAtomic => true;
    }

    public abstract class TextTerm : Term
    {
        public TextTerm(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public override string ToString()
        {
            return Text;
        }

        public override bool IsAtomic => true;
    }

    public class TermToken : TextTerm
    {
        public TermToken(string text)
            : base(text)
        {
            IsReference = false;
        }

        public bool IsReference { get; set; }
    }

    public class TermComment : TextTerm
    {
        public TermComment(string text)
            : base(text)
        {
        }
    }

    public class TermProse : TextTerm
    {
        public TermProse(string text)
            : base(text)
        {
        }
    }

    public class TermLiteral : TextTerm
    {
        public TermLiteral(string text)
            : base(text)
        {
        }
        public TermLiteral(char text)
            : base(text.ToString())
        {
        }
    }

    public class TermNot : Term
    {
        public TermNot(Term term)
        {
            Term = term;
        }

        public Term Term { get; set; }

        public override bool IsAtomic => Term.IsAtomic;
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

        public override bool IsAtomic => false;
    }
}
