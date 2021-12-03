namespace Six.Runtime.Matchers
{
    public record Plus(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            var already = new HashSet<Cursor>();
            var todo = new Queue<Cursor>();
            var succeeded = false;

            already.Add(context.Start);
            todo.Enqueue(context.Start);

            while (todo.Count > 0)
            {
                var next = todo.Dequeue();

                Matchers[0].Match(new Context(next, Success, Failure));
            }

            if (!succeeded)
            {
                context.Failure(context.Start);
            }

            void Success(Cursor success)
            {
                if (already.Add(success))
                {
                    succeeded = true;
                    context.Success(success);
                    todo.Enqueue(success);
                }
            }

            void Failure(Cursor failure)
            {
                // ignore: star can't fail
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
