using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public interface IBody
    {
        IBodyOwner Owner { get; }
        void Add(Statement statement);
        int Count { get; }
        int StatementCount { get; }
        int DeclarationCount { get; }
        void Dump(Writer writer);
    }
}