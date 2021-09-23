namespace Six.Tools
{
    public interface IVisitor<T>
    {
        T Visit(IVisitable visitable);
    }
}
