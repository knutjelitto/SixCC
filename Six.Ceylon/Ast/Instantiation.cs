namespace Six.Ceylon.Ast
{
    public interface QualifiedClass { }

    public record Instantiation(QualifiedClass Class, ArgumentList? Arguments)
    {
        public record Qualified;
    }
}
