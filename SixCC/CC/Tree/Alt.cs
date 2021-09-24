using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal class Alt : Family, Expression
    {
        public Alt(ILocation location, IEnumerable<Cat> children)
            : base(location, children)
        {
        }

        public new List<Cat> Children => base.Children.Cast<Cat>().ToList();
        public override string Head => "|";
    }
}
