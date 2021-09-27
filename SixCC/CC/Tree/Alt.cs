using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal class Alt : Family, Expression
    {
        public Alt(ILocation location, IEnumerable<Expression> children)
            : base(location, children)
        {
        }

        public new List<Expression> Children => base.Children.Cast<Expression>().ToList();
        public override string Head => "|";
    }
}
