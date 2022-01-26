using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public interface INamespace : IBodyOwner, IDumpable, IEnumerable<INamespace>
    {
        Identifier? Name { get; }

        INamespace Create(Identifier name);
    }
}