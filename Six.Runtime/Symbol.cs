namespace Six.Runtime
{
    public abstract record Symbol(IRunImplementation Context, int Id, string Descriptor)
    {
        protected record struct Index(int Offset) { }

        protected readonly Dictionary<Cursor, Continuation> Continuations = new();
        protected readonly Dictionary<Cursor, HashSet<Cursor>> Cursors = new();

        public void Match(Cursor cursor, Continuation continueWith)
        {
            var first = false;

            if (!Continuations.TryGetValue(cursor, out var cont))
            {
                cont = continueWith;
                Continuations.Add(cursor, cont);
                first = true;
            }
            else
            {
                cont.Add(continueWith);
            }

            if (Cursors.TryGetValue(cursor, out var cursors))
            {
                foreach (var next in cursors)
                {
                    continueWith.Invoke(next);
                }
            }

            if (first)
            {
                MatchCore(cursor, new Continuation(next =>
                {
                    if (!Cursors.TryGetValue(cursor, out var cursors))
                    {
                        cursors = new HashSet<Cursor>();
                        Cursors.Add(cursor, cursors);
                    }
                    if (!cursors.Contains(next))
                    {
                        cursors.Add(next);
                        Continuations[cursor].Invoke(next);
                    }
                }));
            }
        }

        protected abstract void MatchCore(Cursor cursor, Continuation continueWith);
    }
}
