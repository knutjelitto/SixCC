namespace Six.Ceylon
{
    internal interface IVisitor
    {
    }

    internal interface ITypedVisitor : IVisitor
    {
    }

    internal interface IVisitable<in TVisitor> 
        where TVisitor : IVisitor
    {
        void Accept(TVisitor visitor);
    }

    internal abstract class Base
    {
    }

    internal class Derived : Base, IVisitable<ITypedVisitor>
    {
        public void Accept(ITypedVisitor visitor)
        {
        }
    }
}
