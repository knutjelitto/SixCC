using Six.Runtime.Matchers;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Runtime
{
    public class ImplementationCore
    {
        private Matcher? __start = null;
        private WhiteRule? __whitespace = null;
        private DfaRule? __keywords = null;

        public ImplementationCore()
        {
            __Matchers = Array.Empty<Matcher>();
        }

        protected ImplementationCore(Matcher[] matchers)
        {
            Assert(matchers.Length >= 3);
            __Matchers = matchers;
        }

        public void Reset()
        {
            foreach (var matcher in __Matchers)
            {
                matcher.Reset();
            }
        }

        public Matcher[] __Matchers { get; }

        public Matcher __Start
        { 
            get => __start ??= __Matchers[0];
            protected set => __start = value;
        }

        protected WhiteRule __Whitespace
        {
            get => __whitespace ??= (WhiteRule)__Matchers[1];
            set
            {
                __whitespace = value;
            }
        }

        protected DfaRule __Keywords
        {
            get => __keywords ??= (DfaRule)__Matchers[2];
            set
            {
                __keywords = value;
            }
        }

        [DebuggerStepThrough]
        public Cursor __MatchWhite(Cursor start)
        {
#if true
            if (__Whitespace.Whites.TryGetValue(start, out var white))
            {
                return white;
            }
#endif
            var current = start;
            while (__Whitespace.Dfa!.TryMatch(current, out var next))
            {
                current = next;
            }

#if true
            __Whitespace.Whites.Add(start, current);
#endif

            return current;
        }

        [DebuggerStepThrough]
        public Cursor __MatchKeyword(Cursor start)
        {
            if (__Keywords.Dfa!.TryMatch(start, out var next))
            {
                return next;
            }
            return start;
        }
    }
}
