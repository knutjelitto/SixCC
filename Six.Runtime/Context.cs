using Six.Runtime.Matchers;

namespace Six.Runtime
{
    public sealed class Context
    {
        private readonly List<Action<Cursor>> Continues = new();
        public readonly CursorSet Nexts;
        public readonly Matcher Matcher;
        public readonly Cursor Start;
        public Cursor Core;


        [DebuggerStepThrough]
        private Context(Matcher matcher, Cursor start)
        {
            Matcher = matcher;
            Start = start;
            Core = start;
            Nexts = new CursorSet();
        }

        public static void Match(Matcher matcher, Cursor start, Action<Cursor> onNext)
        {
            if (!matcher.Contexts.TryGetValue(start, out var context))
            {
                context = new Context(matcher, start);
                matcher.Contexts.Add(start, context);
                context.Continues.Add(onNext);

                matcher.MatchCore(context);
            }
            else
            {
                context.Continues.Add(onNext);
                foreach (var next in context.Nexts.ToList())
                {
                    onNext(next);
                }
            }
        }

        public void Success(Cursor next)
        {
            var count = Continues.Count;
            Nexts.Add(next);
            for (var i = 0; i < count; i++)
            {
                Continues[i](next);
            }
        }

        public override string ToString()
        {
            return $"context({Start}, [{Nexts}], [#{Continues.Count}], {Matcher})";
        }
    }
}
