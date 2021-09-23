using SixCC.Runtime.Structures;

namespace SixCC.CC.Tree
{
    internal class Alternatives : Family, Expression
    {
        public Alternatives(ILocation location, IEnumerable<Sequence> children)
            : base(location, children)
        {
        }

        public new List<Sequence> Children => base.Children.Cast<Sequence>().ToList();
        public override string Head => "|";
    }
}
