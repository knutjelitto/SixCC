using System.Collections.Generic;
using System.Linq;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public abstract class Atom : IExpression
    {
        public Atom()
        {
        }

        public virtual IEnumerable<IExpression> Children => Enumerable.Empty<IExpression>();

        public abstract void Dump(IndentWriter writer);
        public abstract FA GetFA();

        public IEnumerator<IExpression> GetEnumerator()
        {
            return Children.GetEnumerator();
        }
    }
}
