using Six.Ceylon.Ast;
using Six.Ceylon.Errors;
using Six.Tools;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;

namespace Six.Ceylon
{
    public class Dumper
    {
        private readonly Dictionary<System.Type, Dump> refs = new();

        public Dumper(IndentWriter writer, Compiler compiler)
        {
            Writer = writer;
            Compiler = compiler;
        }

        public IndentWriter Writer { get; }
        public Compiler Compiler { get; }

        public void Write(INode? node)
        {
            if (node == null)
            {
                return;
            }

            var type = node.GetType();
            if (!type.IsSealed)
            {
                throw new ErrorException(new ReferenceMessageError(node,  $"type `{type.Name}` must be concrete and sealed"));
            }
            if (!refs.TryGetValue(type, out var dump))
            {
                dump = new Dump(this, type);
                refs.Add(type, dump);
            }
            dump.Write(node);
        }

        private class Dump
        {
            private readonly List<Report> reports = new();

            public Dump(Dumper dumper, System.Type type)
            {
                if (typeof(Literal).IsAssignableFrom(type))
                {
                    reports.Add(new LiteralReport(dumper, type));
                }
                else if (typeof(Terminal).IsAssignableFrom(type))
                {
                    reports.Add(new KeywordReport(dumper));
                }
                else
                {
                    reports.Add(new TreeReport(dumper, type));
                }
            }

            public void Write(INode node)
            {
                foreach (var report in reports)
                {
                    report.Write(node);
                }
            }

            public abstract class Report
            {
                public Report(Dumper dumper)
                {
                    Dumper = dumper;
                }

                public Dumper Dumper { get; }
                public IndentWriter Writer => Dumper.Writer;
                public abstract void Write(INode node);
            }

            public class LiteralReport : Report
            {
                public LiteralReport(Dumper dumper, System.Type literal) : base(dumper)
                {
                    Literal = literal;
                }

                public System.Type Literal { get; }

                public override void Write(INode node)
                {
                    Writer.WriteLine($"{Literal.Name}: {node}");
                }
            }

            public class KeywordReport : Report
            {
                public KeywordReport(Dumper dumper) : base(dumper)
                {
                }

                public override void Write(INode node)
                {
                    Writer.WriteLine($"'{node}'");
                }
            }

            public class TreeReport : Report
            {
                private readonly List<System.Action<INode>> properties = new();

                public TreeReport(Dumper dumper, System.Type tree) : base(dumper)
                {
                    Tree = tree;

                    var infos = tree.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    foreach (var info in infos)
                    {
                        if (typeof(SourceReference).IsAssignableFrom(info.PropertyType))
                        {
                            continue;
                        }
                        if (info.Name == "Items" && typeof(IEnumerable<INode>).IsAssignableFrom(info.PropertyType))
                        {
                            void property(INode node)
                            {
                                var items = (info.GetValue(node) as IEnumerable<INode>)!;
                                foreach (var item in items)
                                {
                                    dumper.Write(item);
                                }
                            }
                            properties.Add(property);
                        }
                        else if (typeof(Literal).IsAssignableFrom(info.PropertyType))
                        {
                            void property(INode node)
                            {
                                Writer.WriteLine($"{info.Name}: {info.GetValue(node)}");
                            }
                            properties.Add(property);
                        }
                        else if (typeof(INode).IsAssignableFrom(info.PropertyType))
                        {
                            void property(INode node)
                            {
                                Writer.WriteLine($"{info.Name}:");
                                using (Writer.Indent())
                                {
                                    dumper.Write((INode?)info.GetValue(node));
                                }
                            }
                            properties.Add(property);
                        }
                        else if (info.PropertyType.IsEnum)
                        {
                            void property(INode node)
                            {
                                Writer.WriteLine($"{info.Name}: {info.GetValue(node)}");
                            }
                            properties.Add(property);
                        }
                        else if (typeof(bool).IsAssignableFrom(info.PropertyType))
                        {
                            void property(INode node)
                            {
                                Writer.WriteLine($"{info.Name}: {info.GetValue(node)}");
                            }
                            properties.Add(property);
                        }
                        else
                        {
                            throw new ErrorException(new MessageError($"can't interpret property `{info.Name}` of `{tree.Name}` (`{info.PropertyType.Name}`)"));
                        }
                    }
                }

                public System.Type Tree { get; }

                public override void Write(INode node)
                {
                    Writer.WriteLine($"{Tree.Name}");
                    using (Writer.Indent())
                    {
                        foreach (var property in properties)
                        {
                            property(node);
                        }
                    }
                }
            }
        }
    }
}
