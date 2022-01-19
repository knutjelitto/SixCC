using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Runtime
{
    public abstract class DynamicVisitor
    {
        public virtual void Walk(RNode element)
        {
        }

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

        protected virtual void VisitChildren(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }
    }
}
