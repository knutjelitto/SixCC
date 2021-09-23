namespace Six.Ceylon.Ast
{
    public interface Qualifier : INode
    {
    }

    public sealed class SuperQualifier : Node, Qualifier
    {
    }

    public class ThisQualifier : Node, Qualifier
    {
    }

    public sealed class PackageQualifier : Node, Qualifier
    {
    }
}
