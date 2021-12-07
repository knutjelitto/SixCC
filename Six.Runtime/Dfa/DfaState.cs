namespace Six.Runtime.Dfa
{
    [DebuggerDisplay("{DD()}")]
    public class DfaState
    {
        public readonly int Id;
        public readonly bool Final;
        public readonly int Payload;

        public DfaTrans[] Transitions = Array.Empty<DfaTrans>();

        public DfaState(int id, bool final, int payload = -1)
        {
            Id = id;
            Final = final;
            Payload = payload;
        }

        public void Set(params DfaTrans[] transitions)
        {
            Transitions = transitions;
        }

        [DebuggerStepThrough]
        public DfaState? Match(int ch)
        {
            foreach (var transition in Transitions)
            {
                if (transition.Set.Match(ch))
                {
                    return transition.Target;
                }
            }

            return null;
        }

        public string DD()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"({Id},{Final},{Payload},({string.Join(",", Transitions)}))";
        }
    }
}
