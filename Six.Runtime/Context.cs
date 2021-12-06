namespace Six.Runtime
{
    public class Context
    {
        private readonly Action<Cursor> success;

        public readonly Cursor Start;


        [DebuggerStepThrough]
        public Context(Cursor start, Action<Cursor> success)
        {
            Start = start;
            this.success = success;
        }

        public void Success(Cursor next)
        {
            success(next);
        }

        public override string ToString()
        {
            return $"context({Start})";
        }
    }
}
