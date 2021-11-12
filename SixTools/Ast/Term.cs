
namespace SixTools.Ast
{
    public enum RepetitionSuffix
    {
        None,
        ZeroOrOne,
        ZeroOrMore,
        OneOrMore,
    }

    public abstract class Term
    {
        public abstract bool IsAtomic { get; }
    }

    public class ErrorTerm : Term
    {
        public ErrorTerm(string msg)
        {
            Msg = msg;
        }

        public override bool IsAtomic => true;

        public string Msg { get; }
    }

    public class TerminalTerm : Term
    {
        public TerminalTerm(Term inner)
        {
            Inner = inner;
        }

        public Term Inner { get; set; }

        public override bool IsAtomic => true;
    }

    public abstract class GroupTerm : Term
    {
        public GroupTerm(Term term, int min, int max)
        {
            Inner = term;
            Min = min;
            Max = max;
        }

        public Term Inner { get; set; }
        public int Min { get; }
        public int Max { get; }

        public override bool IsAtomic => Min == 1 && Max == 1 && Inner.IsAtomic;
    }

    public class ClampedTerm : GroupTerm
    {
        public ClampedTerm(Term inner)
            : base(inner, 1, 1)
        {
        }
    }

    public class ZeroOrOneTerm : GroupTerm
    {
        public ZeroOrOneTerm(Term inner)
            : base(inner, 0, 1)
        {
        }
    }

    public class OneOrMoreTerm : GroupTerm
    {
        public OneOrMoreTerm(Term inner)
            : base(inner, 1, 0)
        {
        }
    }

    public class ZeroOrMoreTerm : GroupTerm
    {
        public ZeroOrMoreTerm(Term inner)
            : base(inner, 0, 0)
        {
        }
    }

    public class LoopTerm : GroupTerm
    {
        public LoopTerm(Term inner, int min, int max)
            : base(inner, min, max)
        {
            Assert(Min >= 0);
            Assert(Max > 1 && Max >= Min);
        }
    }

    public class AlternativesTerm : TermList
    {
        public AlternativesTerm(Term first, IEnumerable<Term> rest)
            : base(Enumerable.Repeat(first, 1).Concat(rest))
        {
            Assert(Terms.Count >= 2);
        }

        public AlternativesTerm(IEnumerable<Term> terms)
            : base(terms)
        {
            Assert(Terms.Count >= 2);
        }
    }

    public class SequenceTerm : TermList
    {
        public SequenceTerm(IEnumerable<Term> terms)
            : base(terms)
        {
        }
    }

    public class EpsilonTerm : Term
    {
        public override bool IsAtomic => false;
    }

    public class AnyTerm : Term
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

    public class TokenTerm : TextTerm
    {
        public TokenTerm(string text)
            : base(text)
        {
            IsReference = false;
        }

        public bool IsReference { get; set; }
    }

    public class CommentTerm : TextTerm
    {
        public CommentTerm(string text)
            : base(text)
        {
        }
    }

    public class ProseTerm : TextTerm
    {
        public ProseTerm(string text)
            : base(text)
        {
        }
    }

    public class LiteralTerm : TextTerm
    {
        public LiteralTerm(IEnumerable<string> texts)
            : this(string.Join(string.Empty, texts))
        {
            foreach (var t in texts)
            {
                if (t.Length > 1)
                {
                    Assert(true);
                }
            }
        }

        public LiteralTerm(string text)
            : base(text)
        {
        }
        public LiteralTerm(char text)
            : base(text.ToString())
        {
        }
    }

    public class NotTerm : Term
    {
        public NotTerm(Term term)
        {
            Inner = term;
        }

        public Term Inner { get; set; }

        public override bool IsAtomic => Inner.IsAtomic;
    }

    public class RangeTerm : Term
    {
        public RangeTerm(LiteralTerm start, LiteralTerm stop)
        {
            Start = start;
            Stop = stop;
        }

        public LiteralTerm Start { get; }
        public LiteralTerm Stop { get; }

        public override bool IsAtomic => false;
    }
}