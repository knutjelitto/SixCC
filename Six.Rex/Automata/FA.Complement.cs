namespace Six.Rex
{
    public partial class FA
    {
        private static partial class Operations
        {
            public static FA Complement(FA dfa)
            {
                EnsureDfa(dfa);

                for (var i = 0; i < dfa.States.Count; ++i)
                {
                    dfa.States[i].IsFinal = !dfa.States[i].IsFinal;
                }

                return dfa;
            }
        }
    }
}
