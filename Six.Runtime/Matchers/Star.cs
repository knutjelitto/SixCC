namespace Six.Runtime.Matchers
{
    public sealed class Star : Structural
    {
        public Star(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            var todo = new Queue<Cursor>();

            var matcher = this[0];

            todo.Enqueue(context.Start);

            context.Success(context.Start);

            while (todo.Count > 0)
            {
                var next = todo.Dequeue();

                matcher.Match(next, Success);
            }

            void Success(Cursor success)
            {
                if (context.NewSuccess(success))
                {
                    todo.Enqueue(success);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
