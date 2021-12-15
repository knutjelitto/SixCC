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
                var start = todo.Dequeue();
                context.Success(start);

                this[0].Match(start, Success);
            }

            void Success(Cursor success)
            {
                if (already.Add(success))
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
