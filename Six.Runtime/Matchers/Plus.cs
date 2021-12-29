namespace Six.Runtime.Matchers
{
    public sealed class Plus : Structural
    {
        public Plus(ImplementationCore core, int id, string name)
            : base(core, id, name)
        {
        }

        public override void MatchCore(Context context)
        {
            var already = new HashSet<Cursor>();
            var todo = new Queue<Cursor>();

            already.Add(context.Start);
            todo.Enqueue(context.Start);

            while (todo.Count > 0)
            {
                var next = todo.Dequeue();

                this[0].Match(next, Success);
            }

            void Success(Cursor success)
            {
                if (already.Add(success))
                {
                    context.Success(success);
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
