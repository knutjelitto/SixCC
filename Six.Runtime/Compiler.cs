using Six.Core;
using System.Threading.Tasks.Dataflow;

namespace Six.Runtime
{
    public class Job
    {
        public Job(string name, string content)
        {
            Name = name;
            Content = content;
        }

        public string Name { get; }
        public string Content { get; }
    }

    public class Compiler<TParser>
        where TParser : Parser, new()
    {
        private readonly int parserCount;
        private readonly BufferBlock<Parser> parsers;
        private readonly ActionBlock<Job> action;

        public Compiler(int parserCount)
        {
            this.parserCount = parserCount;

            parsers = new();

            var options = new ExecutionDataflowBlockOptions
            {
                EnsureOrdered = false,
                BoundedCapacity = DataflowBlockOptions.Unbounded,
                MaxDegreeOfParallelism = DataflowBlockOptions.Unbounded,
            };
            
            action = new(Compile, options);

            for (var i = 0; i < parserCount; i++)
            {
                parsers.Post(new TParser());
            }

            Assert(parsers.Count == parserCount);
        }

        private void Compile(Job job)
        {
            var source = Source.FromString(job.Name, job.Content);

            var parser = parsers.Receive();
            parser.ParseVerbose(source);
            parser.Reset();
            parsers.Post(parser);
        }

        public void Compile(IEnumerable<Job> sources)
        {
            foreach (var source in sources)
            {
                action.Post(source);
            }

            action.Complete();
            action.Completion.Wait();
        }
    }
}
