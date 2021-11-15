using Six.Core;
using SixTools.Ast;
using SixTools.Helpers;
using SixTools.Rails;

namespace SixTools.Formats
{
    public class RailDumpFormat : IFormat
    {
        public string DebugExtension => ".txt";
        public string FormatName => "rr-dump";

        public void Format(Grammar grammar, Writer writer)
        {
            new Formatter(grammar, writer).Format();
        }

        private class Formatter
        {
            private readonly Grammar grammar;
            private readonly Writer writer;

            public Formatter(Grammar grammar, Writer writer)
            {
                this.grammar = grammar;
                this.writer = writer;
            }

            public void Format()
            {
                var more = false;
                foreach (var rule in grammar.Rules)
                {
                    if (more)
                    {
                        writer.WriteLine();
                    }
                    more = true;

                    writer.WriteLine($"rule: {rule.Name}");

                    var node = RailMaker.Make(rule.Term);

                    Write(node);
                }
            }

            private void Write(Railroad node)
            {
                using (writer.Indent())
                {
                    switch (node)
                    {
                        case NotRail not:
                            writer.WriteLine("not");
                            Write(not.Node);
                            break;
                        case SequenceRail line:
                            writer.WriteLine("line");
                            Write(line.Nodes);
                            break;
                        case AnyRail:
                            writer.WriteLine("any");
                            break;
                        case TokenRail token:
                            writer.WriteLine($"token {token.Text}");
                            break;
                        case ReferenceRail reference:
                            writer.WriteLine($"reference {reference.Text}");
                            break;
                        case LiteralRail literal:
                            writer.WriteLine($"literal '{Esc.Full(literal.Text)}'");
                            break;
                        case CommentRail comment:
                            writer.WriteLine($"literal '{Esc.Full(comment.Text)}'");
                            break;
                        case ProseRail prose:
                            writer.WriteLine($"literal '{Esc.Full(prose.Text)}'");
                            break;
                        case ChoiceRail alt:
                            writer.WriteLine("switch");
                            Write(alt.Nodes);
                            break;
                        case PlainRail:
                            writer.WriteLine("--plain--");
                            break;
                        case RangeRail range:
                            writer.WriteLine($"range [{range.Start}-{range.Stop}]");
                            break;
                        case LoopRail loop:
                            writer.WriteLine("loop");
                            using (writer.Indent())
                            {
                                writer.WriteLine($".skip: {loop.Skip.ToString().ToLowerInvariant()}");
                                writer.WriteLine(".forward");
                                Write(loop.Forward);
                                writer.WriteLine(".backward");
                                Write(loop.Backward);
                            }
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

            private void Write(IEnumerable<Railroad> nodes)
            {
                foreach (var node in nodes)
                {
                    Write(node);
                }
            }
        }
    }
}