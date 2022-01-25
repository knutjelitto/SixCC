using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public interface IDeclarationBag
    {
        IDeclarationsOwner Owner { get; }
        void Add(Declaration declaration);
        int Count { get; }
        void Dump(Writer writer);
    }
}