using System.Text;

using Six.Ast;

namespace Six.Gen.Ebnf
{
    internal class NameWalker : EbnfWalker
    {
        const string LeftParent = "(";
        const string RightParent = ")";
        const string Comma = ",";

        private readonly StringBuilder builder = new();

        public string NameOf(CoreOp op)
        {
            builder.Clear();
            Walk(op);
            return builder.ToString();
        }

        private void Write(string str)
        {
            builder.Append(str);
        }

        private void Left(string head)
        {
            Write(head);
            Write(LeftParent);
        }

        private void Right()
        {
            Write(RightParent);
        }

        private void Arguments(CoreOp op, string separator)
        {
            var more = false;
            foreach (var argument in op.Arguments)
            {
                if (more)
                {
                    Write(separator);
                }
                more = true;
                Walk(argument);
            }
        }

        protected override void Visit(AltOp op)
        {
            Left("alt");
            Arguments(op, "|");
            Right();
        }

        protected override void Visit(AnyOp op)
        {
            Write("any");
        }

        protected override void Visit(OptionalOp op)
        {
            Left("?");
            Walk(op.Argument);
            Right();
        }

        protected override void Visit(RangeOp op)
        {
            Left("range");
            Write(op.Codepoint1.ToString().Esc());
            Write(Comma);
            Write(op.Codepoint2.ToString().Esc());
            Right();
        }

        protected override void Visit(RefOp op)
        {
            Left("ref");
            Write(op.Name);
            Right();
        }

        protected override void Visit(RuleOp op)
        {
            Write(op.Name);
        }

        protected override void Visit(SeqOp op)
        {
            Left("_");
            Arguments(op, Comma);
            Right();
        }

        protected override void Visit(StarOp op)
        {
            Left("*");
            Walk(op.Argument);
            Right();
        }

        protected override void Visit(PlusOp op)
        {
            Left("+");
            Walk(op.Argument);
            Right(); ;
        }

        protected override void Visit(CharacterOp op)
        {
            Write(op.Codepoint.ToString().Esc());
        }

        protected override void Visit(StringOp op)
        {
            Write(op.Text.Esc());
        }

        protected override void Visit(SetOp op)
        {
            Left("set");
            Arguments(op, Comma);
            Right();
        }

        protected override void Visit(TokenOp op)
        {
            Left("tok");
            Walk(op.Argument);
            Right();
        }
    }
}
