namespace Six.Ceylon.Ast
{
    public interface QualifiedClass : AstNode
    { 
    }

    public record Instantiation(QualifiedClass Class, ArgumentList? Arguments) : AstNode;
}
