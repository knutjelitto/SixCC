namespace Six.Runtime.Dfa
{
    public class Dfa
    {
        public static readonly Dfa Nope = new();

        public Dfa(params DfaState[] states)
        {
            Assert(states.Length > 0);
            States = states;
        }

        public DfaState[] States { get; }
        public DfaState Start => States[0];

        public void Match(Context context)
        {
            var state = Start;
            var current = context.Start;

            while (current.At != -1)
            {
                Assert(state != null);
                var next = state.Match(current.At);
                if (next == null)
                {
                    if (state.Final)
                    {
                        context.Success(current);
                        return;
                    }
                    return;
                }
                state = next;
                current = current.Advance(1);
            }

            if (state.Final)
            {
                context.Success(current);
                return;
            }

            return;
        }

        public IEnumerable<int> GetPayloads()
        {
            return States.Where(state => state.Payload >= 0).Select(state => state.Payload).Distinct();
        }

    }
}
