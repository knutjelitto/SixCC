using Six.Ceylon.Errors;

namespace Six.Ceylon.Ast
{
    public interface INode
    {
        SourceReference? SourceReference { get; set; }
    }
}
