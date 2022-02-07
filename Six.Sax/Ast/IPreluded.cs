namespace Six.Sax.Ast
{
    public interface IPreluded : Node
    {
        Prelude Prelude { get; }
    }
}
