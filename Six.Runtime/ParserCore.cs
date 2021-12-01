namespace Six.Runtime
{
    public abstract class ParserCore
    {
        public readonly string __Name;
        protected readonly ImplementationCore __Core;

        protected ParserCore()
            : this("<noname>", new ImplementationCore())
        {
        }

        protected ParserCore(string name, ImplementationCore core)
        {
            __Name = name;
            __Core = core;
        }

        public void Match(string name, string content)
        {
            var source = new Source(content);
            var cursor = new Cursor(source, 0);
            var successCounter = 0;
            var failureCounter = 0;

            __Core.__Start.Match(cursor, new Continuation(cursor,
                success =>
                {
                    Console.WriteLine($"#{++successCounter} {__Name} {name}@{success.Offset} - OK");
                },
                failure =>
                {
                    Console.WriteLine($"#{++failureCounter} {__Name} {name}@{failure.Offset} - FAIL");
                    if (failure.Offset == 115)
                    {
                        Assert(true);
                    }
                }));
        }
    }
}
