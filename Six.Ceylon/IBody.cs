using Six.Ceylon.Ast;

namespace Six.Ceylon
{
    public interface IBody
    {
        IBodyOwner Owner { get; }
        void Add(Stmt statement);
        int Count { get; }
        int StatementCount { get; }
        int DeclarationCount { get; }
        void Dump(Writer writer);
    }
}