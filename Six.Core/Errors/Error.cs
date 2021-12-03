namespace Six.Core.Errors
{
    public abstract class Error : Diagnostic
    {
        protected Error() : base(Level.Error)
        {
        }
    }
}
