namespace Six.Sax.Sema
{
    public interface Ref : It
    {
        public interface Value : Ref
        {
        }

        public interface Type : Ref
        {
        }
    }
}
