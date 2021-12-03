namespace Six.Runtime.Matchers
{
    public abstract record Matcher(ImplementationCore Core, int Id, string Name)
    {
        public Matcher[] Matchers = Array.Empty<Matcher>();
        public Dfa.Dfa? Dfa = null;

        protected abstract void MatchCore(Context context);

        public virtual void Match(Context context)
        {
            MatchCore(context);
        }

        public void Set(params Matcher[] matchers)
        {
            Matchers = matchers;
        }

        public void Set(Dfa.Dfa dfa)
        {
            Dfa = dfa;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
