using Six.Runtime.Matchers;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Runtime
{
    public class ImplementationCore
    {
        private Matcher? __start = null;
        private DfaRule? __whitespace = null;

        public ImplementationCore()
        {
            __Matchers = Array.Empty<Matcher>();
        }

        protected ImplementationCore(Matcher[] matchers)
        {
            Assert(matchers.Length >= 2);
            __Matchers = matchers;
        }

        public Matcher[] __Matchers { get; }

        public Matcher __Start
        { 
            get => __start ??= __Matchers[0];
            protected set => __start = value;
        }

        protected DfaRule __Whitespace
        {
            get => __whitespace ??= (DfaRule)__Matchers[1];
            set
            {
                __whitespace = value;
            }
        }

        [DebuggerStepThrough]
        public Cursor __MatchWhite(Cursor start)
        {
            if (__Whitespace.Dfa!.TryMatch(start, out var next))
            {
                return next;
            }
            return start;
        }
    }
}
