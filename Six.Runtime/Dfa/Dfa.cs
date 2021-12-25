namespace Six.Runtime.Dfa
{
    public class Dfa
    {
        public static readonly Dfa Nope = new();

        public Dfa(params DfaState[] states)
        {
            Assert(states.Length >= 0);
            States = states;
        }

        public void Set(params DfaState[] states)
        {
            Assert(states.Length > 0);
            States = states;
        }

        public DfaState[] States { get; private set; }
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

        public bool TryMatch(Cursor start, out Cursor success)
        {
            var currentState = Start;
            var currentCursor = start;

            while (currentCursor.At != -1)
            {
                var x = (char)currentCursor.At;

                Assert(currentState != null);
                var next = currentState.Match(currentCursor.At);
                if (next == null)
                {
                    if (currentState.Final)
                    {
                        success = currentCursor;
                        return true;
                    }
                    else
                    {
                        success = start;
                        return false;
                    }
                }
                else
                {
                    currentState = next;
                    currentCursor = currentCursor.Advance(1);
                }
            }

            if (currentState.Final)
            {
                success = currentCursor;
                return true;
            }

            success = start;
            return false;
        }

        public IEnumerable<int> GetPayloads()
        {
            return States.Where(state => state.Payload >= 0).Select(state => state.Payload).Distinct();
        }

    }
}
