﻿namespace Six.Runtime.Matchers
{
    public record Star(ImplementationCore Core, int Id, string Name) : Matcher(Core, Id, Name)
    {
        protected override void MatchCore(Context context)
        {
            var already = new HashSet<Cursor>();
            var todo = new Queue<Cursor>();

            already.Add(context.Start);
            todo.Enqueue(context.Start);

            while (todo.Count > 0)
            {
                var next = todo.Dequeue();
                context.Success(next);

                Matchers[0].Match(new Context(next, Success));
            }

            void Success(Cursor success)
            {
                if (already.Add(success))
                {
                    todo.Enqueue(success);
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
