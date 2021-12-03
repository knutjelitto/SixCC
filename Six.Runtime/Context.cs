namespace Six.Runtime
{
    public class Context
    {
        public Action<Cursor> Success { get; }
        public Action<Cursor> Failure { get; }
        
        public readonly Cursor Start;


        [DebuggerStepThrough]
        public Context(Cursor start, Action<Cursor> success, Action<Cursor> failure)
        {
            Start = start;
            Success = success;
            Failure = failure;
        }

        public override string ToString()
        {
            return $"context({Start})";
        }
    }
}
