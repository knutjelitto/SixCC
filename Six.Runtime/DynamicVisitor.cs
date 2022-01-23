﻿using Six.Runtime.Types;

namespace Six.Runtime
{
    public abstract class DynamicVisitor
    {
        public virtual void Walk(IRNode element)
        {
        }

        protected virtual void Visit(RStar element)
        {
            WalkChilden(element);
        }

        protected virtual void Visit(RPlus element)
        {
            WalkChilden(element);
        }

        protected virtual void Visit(ROptional element)
        {
            WalkChilden(element);
        }

        protected virtual void Visit(RLiteral element)
        {
            WalkChilden(element);
        }

        protected virtual void Visit(REof element)
        {
            WalkChilden(element);
        }

        protected virtual void DefaultImplementation(RNode element)
        {
            WalkChilden(element);
        }

        protected virtual void WalkChilden(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }
    }
}
