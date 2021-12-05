namespace Six.Core.Errors
{
    public class SemanticError : LocatedMessageError
    {
        public SemanticError(ILocation location, string message)
            : base(location, message)
        {
        }
    }
}
