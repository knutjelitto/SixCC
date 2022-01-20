using Six.Runtime.Types;

namespace Six.Runtime
{
    public abstract class DynamicVisitor
    {
        public virtual void Walk(RNode element)
        {
        }

#if false
        public virtual void Walk(object element)
        {
        }
#endif

        protected virtual void Visit(RStar element)
        {
            VisitChildren(element);
        }

        protected virtual void Visit(RPlus element)
        {
            VisitChildren(element);
        }

        protected virtual void Visit(ROptional element)
        {
            VisitChildren(element);
        }

        protected virtual void Visit(RString element)
        {
            VisitChildren(element);
        }

        protected virtual void Visit(REof element)
        {
            VisitChildren(element);
        }

        protected virtual void DefaultImplementation(RNode element)
        {
            VisitChildren(element);
        }

        protected virtual void VisitChildren(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }
    }
}
