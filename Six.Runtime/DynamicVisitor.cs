using Six.Runtime.Types;

namespace Six.Runtime
{
    public abstract class DynamicVisitor
    {
        public virtual void Walk(IRNode element)
        {
        }

        protected virtual void Visit(RStar element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }

        protected virtual void Visit(RPlus element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }

        protected virtual void Visit(ROptional element)
        {
            if (element.Children.Length == 1)
            {
                Walk(element.Children[0]);
                element.Value = element.Children[0].Value;
            }
            else
            {
                Assert(element.Children.Length == 0);
                element.Value = null;
            }
        }

        protected virtual void Visit(RLiteral element)
        {
        }

        protected virtual void Visit(REof element)
        {
        }

        protected virtual void DefaultImplementation(RNode element)
        {
            WalkChildren(element);
        }

        protected virtual void WalkChildren(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }
    }
}
