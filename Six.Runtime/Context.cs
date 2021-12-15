using Six.Runtime.Matchers;

namespace Six.Runtime
{
    public sealed class Context
    {
        private readonly List<Action<Cursor>> Continues = new();
        public readonly HashSet<Cursor> Nexts = new();
        public readonly Matcher Matcher;
        public readonly Cursor Start;


        [DebuggerStepThrough]
        private Context(Matcher matcher, Cursor start)
        {
            Matcher = matcher;
            Start = start;
            Nexts = new HashSet<Cursor>();
        }

        public static Context From(Matcher matcher, Cursor start, Action<Cursor> @continue)
        {
            if (!matcher.Contexts.TryGetValue(start, out var context))
            {
                context = new Context(matcher, start);
                matcher.Contexts.Add(start, context);
                context.Continues.Add(@continue);

                matcher.MatchCore(context);
            }
            else
            {
                context.Continues.Add(@continue);
                foreach (var next in context.Nexts)
                {
                    @continue(next);
                }
            }

            return context;
        }

        public void Success(Cursor next)
        {
            var count = Continues.Count;
            for (var i = 0; i < count; i++)
            {
                Continues[i](next);
            }
            Nexts.Add(next);
        }

        public override string ToString()
        {
            var nexts = string.Join(',', Nexts.Select(x => x.Offset).OrderBy(x => x));

            return $"context({Start.Offset}, {Matcher}, [{nexts}], [#{Continues.Count}])";
        }
    }
}
