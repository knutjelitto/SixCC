namespace Six.Runtime.Matchers
{
    public sealed record Plus(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
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

                Matchers[0].Match(next, Success);
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
