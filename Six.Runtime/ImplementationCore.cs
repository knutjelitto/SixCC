using Six.Runtime.Matchers;

#pragma warning disable IDE1006 // Naming Styles

namespace Six.Runtime
{
    public class ImplementationCore
    {
        private Matcher? __start = null;
        private Matcher? __whitespace = null;

        public ImplementationCore()
        {
            __Matchers = new Matcher[]
            {
                new Epsilon(this, 0, "---start---"),
                new Epsilon(this, 1, "---whitespace---"),
            };
            __Start = __Matchers[0];
            __Whitespace = __Matchers[0];
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

        public Matcher __Whitespace
        {
            get => __whitespace ??= __Matchers[1];
            protected set => __whitespace = value;
        }

        public bool __InToken { get; set; }

        public void __CollectWhitespace(Context context)
        {
            var farthest = context.Start;

            __Whitespace.Match(new Context(context.Start, Success, Failure));

            void Success(Cursor success)
            {
                if (success > farthest)
                {
                    farthest = success;
                }
            }

            void Failure(Cursor failure)
            {
                // ignore: we collect whitespace really greedy
            }

            context.Success(farthest);
        }

        public void __MatchToken(Context context, Dfa.Dfa dfa)
        {
            __MatchToken(context, dfa.Match);
        }

        public void __MatchToken(Context context, Action<Context> match)
        {
            Assert(__Whitespace.Dfa != null);
            __Whitespace.Dfa.Match(new Context(context.Start, AfterWhite, AfterWhite));

            void AfterWhite(Cursor current)
            {
                match(new Context(current,
                    success =>
                    {
                        context.Success(success);
                    },
                    failure =>
                    {
                        context.Failure(failure);
                    }));
            }
        }
    }
}
