namespace SixBot.Ast
{
    internal abstract class Expression
    {
        public static Seq operator+(Expression left, Expression right)
        {
            if (left is Seq seq)
            {
                return new Seq(seq.Expressions.Concat(Enumerable.Repeat(right, 1)).ToArray());
            }
            else
            {
                return new Seq(left, right);
            }
        }

        public static Alt operator |(Expression left, Expression right)
        {
            if (left is Alt seq)
            {
                return new Alt(seq.Expressions.Concat(Enumerable.Repeat(right, 1)).ToArray());
            }
            else
            {
                return new Alt(left, right);
            }
        }

        public static Terminal operator -(Expression left, Expression right)
        {
            return new Terminal(new Substract(left, right));
        }

    }
}
