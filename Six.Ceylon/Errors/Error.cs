using Antlr4.Runtime.Tree;
using Six.Ceylon.Ast;
using System.IO;

namespace Six.Ceylon.Errors
{
    public abstract class Error
    {
        public abstract void Report(TextWriter writer);
    }

    public abstract class SourceReferenceError : Error
    {
        public SourceReferenceError(INode node)
        {
            Node = node;
        }

        public INode Node { get; }

        public string SourceReference
        {
            get
            {
                var reference = Node.SourceReference!;

                return $"{reference.File}({reference.LineNo},{reference.ColumnNo})";
            }
        }
    }

    public class ReferenceMessageError : SourceReferenceError
    {
        public ReferenceMessageError(INode node, string message)
            : base(node)
        {
            Message = message;
        }

        public string Message { get; }

        public override void Report(TextWriter writer)
        {
            writer.WriteLine($"{SourceReference}: {Message}");
        }
    }

    public class CantVisitError : ReferenceMessageError
    {
        public CantVisitError(INode node)
            : base(node, $"visiting for `{node.GetType().Name}` not implemented")
        {
        }
    }

    public class MessageError : Error
    {
        public MessageError(string message)
        {
            Message = message;
        }

        public string Message { get; }

        public override void Report(TextWriter writer)
        {
            writer.WriteLine($"error: {Message}");
            throw new System.NotImplementedException();
        }
    }
}
