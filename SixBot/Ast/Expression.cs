namespace SixBot.Ast
{
    internal abstract class Expression
    {
        public abstract bool IsAtomic { get; }
        public virtual bool IsCompact => this is Compact;

        /// <summary>
        /// true, if this is structural a regex.
        /// </summary>
        public bool IsRegex { get; set; }

        /// <summary>
        /// true, if this expression is only used in compact rules
        /// </summary>
        public bool IsFragment { get; set; }

        public abstract string ToName();


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

        public static Expression operator -(Expression left, Expression right)
        {
            if (left is Set lSet)
            {
                if (right is Literal lit && lit.Text.Count == 1)
                {
                    return new Set(lSet.Points.ExceptWith(Integers.From((int)lit.Text[0])));
                }
                else if (right is Set rSet)
                {
                    return new Set(lSet.Points.ExceptWith(rSet.Points));
                }
            }
            return new Substract(left, right);
        }
    }
}
