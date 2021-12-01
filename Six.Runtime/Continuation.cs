namespace Six.Runtime
{
    public class Continuation
    {
        private Action<Cursor> success { get; set; }
        private Action<Cursor> failure { get; set; }
        
        private HashSet<Cursor>? already;

        public readonly Cursor current;


        [DebuggerStepThrough]
        public Continuation(Cursor current, Action<Cursor> success, Action<Cursor> failure)
        {
            this.current = current;
            this.success = success;
            this.failure = failure;
        }

        public void Success(Cursor success)
        {
            this.success(success);
        }

        public void Fail(Cursor failure)
        {
            if (!(already ??= new HashSet<Cursor>()).Contains(failure))
            {
                already.Add(failure);
                this.failure(failure);
            }
        }
    }
}
