namespace Six.Tools
{
    public interface IVisitable
    {
        T Accept<T>(IVisitor<T> visitor);
    }
}
