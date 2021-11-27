namespace Six.Runtime
{
    public class Continuation
    {
        private Action<Cursor> action { get; set; }

        [DebuggerStepThrough]
        public Continuation(Action<Cursor> action)
        {
            this.action = action;
        }

        public void Add(Action<Cursor> action)
        {
            this.action += action;
        }

        public void Add(Continuation continuation)
        {
            action += continuation.action;
        }

        public void Invoke(Cursor cursor)
        {
            action(cursor);
        }
    }
}
