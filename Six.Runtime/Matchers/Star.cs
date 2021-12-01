namespace Six.Runtime.Matchers
{
    public record Star(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Cursor current, Continuation continuation)
        {
            var already = new HashSet<Cursor>();
            var todo = new HashSet<Cursor>();
            var added = new HashSet<Cursor>();

            already.Add(current);
            continuation.Success(current);

            todo.Add(current);

            while (todo.Count > 0)
            {
                added.Clear();
                foreach (var cursor in todo)
                {
                    Matchers[0].Match(cursor, new Continuation(cursor, Success, Failure));
                }
                todo.Clear();
                (todo, added) = (added, todo);
            }

            void Success(Cursor success)
            {
                if (already.Add(success))
                {
                    Assert(!added.Contains(success));
                    added.Add(success);
                    continuation.Success(success);
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
