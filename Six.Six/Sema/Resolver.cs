using System;

namespace Six.Six.Sema
{
    public sealed class Resolver
    {
        private readonly Queue<Action> scheduled = new();

        public Resolver(Module global)
        {
            Module = global;
        }

        public Module Module { get; }

        public void Schedule(Action action)
        {
            scheduled.Enqueue(action);
        }

        public void Resolve()
        {
            while (scheduled.Count > 0)
            {
                var action = scheduled.Dequeue();

                action();
            }
        }

        private ulong ConvertNatural(string text)
        {
            if (text.StartsWith('#'))
            {
                ulong value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 16 + (ulong)hexValue(c);
                }
                return value;
            }
            else if (text.StartsWith('$'))
            {
                ulong value = 0;
                foreach (var c in text[1..])
                {
                    value = value * 2 + (ulong)binValue(c);
                }
                return value;
            }
            else
            {
                ulong value = 0;
                foreach (var c in text)
                {
                    value = value * 10 + (ulong)decValue(c);
                }
                return value;
            }

            int binValue(char c)
            {
                Assert('0' <= c && c <= '1');
                return c - '0';
            }

            int decValue(char c)
            {
                Assert('0' <= c && c <= '9');
                return c - '0';
            }

            int hexValue(char c)
            {
                Assert('0' <= c && c <= '9' || 'a' <= c && c <= 'f' || 'A' <= c && c <= 'A');
                if ('0' <= c && c <= '9')
                {
                    return c - '0';
                }
                if ('a' <= c && c <= 'f')
                {
                    return 10 + c - 'a';
                }
                return 10 + c - 'A';
            }
        }
    }
}
