using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public interface INamespace : IDeclarationsOwner, IDumpable, IEnumerable<INamespace>
    {
        Identifier? Name { get; }

        INamespace Create(Identifier name);
    }
}