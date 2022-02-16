namespace Six.Six.Sema
{
    public record Reference(Declarations Declarations, params Type[] Arguments) : Type, ITyped;
}
