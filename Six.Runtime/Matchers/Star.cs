namespace Six.Runtime.Matchers
{
    public sealed record Star(ImplementationCore Core, int Id, string Name) : Structural(Core, Id, Name)
    {
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

            context.Success(context.Start);

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
