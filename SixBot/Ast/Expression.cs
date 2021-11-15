namespace SixBot.Ast
{
    internal abstract class Expression
    {
        public abstract bool IsAtomic { get; }

        /// <summary>
        /// true, if this is strutural a regex.
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
            return new Substract(left, right);
        }
    }
}
