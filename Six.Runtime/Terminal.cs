namespace Six.Runtime
{
    public abstract record Terminal(IRunImplementation Context, int Id, string Descriptor)
        : Symbol(Context, Id, Descriptor)
    {
    }

    public sealed record UndefinedTerminal(IRunImplementation Context, int Id, string Descriptor)
        : Terminal(Context, Id, Descriptor)
    {
        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{{undefined-terminal {Descriptor}}}";
        }
    }

    public sealed record StringTerminal(IRunImplementation Context, int Id, string Descriptor, string Text)
        : Terminal(Context, Id, Descriptor)
    {
        protected override void MatchCore(Cursor cursor, Continuation continueWith)
        {
            if (Text.Length == 0)
            {
                throw new NotImplementedException();
            }
            if (cursor.Match(Text))
            {
                continueWith.Invoke(cursor.Advance(Text.Length));
            }
        }

        public override string ToString()
        {
            return $"{{string-terminal {Descriptor}}}";
        }
    }
}