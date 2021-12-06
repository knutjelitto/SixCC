using System.Text;

using Six.Ast;

namespace Six.Gen.Ebnf
{
    internal class OpNamer : EbnfWalker
    {
        const string LeftAngle = "❬";
        const string RightAngle = "❭";

        private readonly StringBuilder builder = new();

        public string NameOf(Operator op)
        {
            builder.Clear();
            Walk(op);
            return builder.ToString();
        }

        private void Write(string str)
        {
            builder.Append(str);
        }

        private void Left()
        {
            Write(LeftAngle);
        }

        private void Right()
        {
            Write(RightAngle);
        }

        private void Arguments(Operator op, string separator)
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
            Left();
            Arguments(op, "|");
            Right();
        }

        protected override void Visit(AnyOp op)
        {
            Write("·");
        }

        protected override void Visit(CharacterOp op)
        {
            Write(op.Codepoint.ToString().Esc());
        }

        protected override void Visit(OptionalOp op)
        {
            Walk(op.Argument);
            Write("?");
        }

        protected override void Visit(PlusOp op)
        {
            Walk(op.Argument);
            Write("+");
        }

        protected override void Visit(RangeOp op)
        {
            Left();
            Write(op.Codepoint1.ToString().Esc());
            Write("⤍");
            Write(op.Codepoint2.ToString().Esc());
            Right();
        }

        protected override void Visit(DiffOp op)
        {
            Left();
            Walk(op.Arguments[0]);
            Write("-");
            Walk(op.Arguments[1]);
            Right();
        }

        protected override void Visit(RefOp op)
        {
            Write($"⤇{op.Name}");
        }

        protected override void Visit(RuleOp op)
        {
            Write(op.Name);
        }

        protected override void Visit(SeqOp op)
        {
            Left();
            if (op.Arguments.Count > 0)
            {
                Arguments(op, "»");
            }
            else
            {
                Write("𝛆");
            }
            Right();
        }

        protected override void Visit(StarOp op)
        {
            Walk(op.Argument);
            Write("*");
        }

        protected override void Visit(StringOp op)
        {
            Write(op.Text.Esc());
        }

        protected override void Visit(TokenOp op)
        {
            Write("«");
            Walk(op.Argument);
            Write("»");
        }
    }
}
