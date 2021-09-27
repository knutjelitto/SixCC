using SixCC.Writing;

namespace SixCC.Sdk.Earley
{
    internal static class EarleyDumper
    {
        public static void Dump(Writer writer, EarleyChart chart)
        {
            foreach (var set in chart)
            {
                writer.WriteLine($"Set[{set.ID}]");
                using (writer.Indent())
                {
                    foreach (var item in set.Items)
                    {
                        writer.Write($"Item[{item.ID}] {item.Dfa.Symbol} <{item.OriginSet.ID}>");

                        if (item.Dfa.IsTerminal)
                        {
                            writer.WriteLine($" `{chart.Parser.Source.GetText(item.OriginSet.ID, set.ID - item.OriginSet.ID)}´");
                        }
                        else
                        {
                            writer.WriteLine();
                            using (writer.Indent())
                            {
                                foreach (var state in item.Dfa.States)
                                {
                                    var l1 = item.State == state ? "[" : " ";
                                    var l2 = state.IsFinal ? "|" : ".";
                                    var r2 = state.IsFinal ? "|" : ".";
                                    var r1 = item.State == state ? "]" : " ";

                                    var from = string.Empty;
                                    if (state == item.State)
                                    {
                                        from = item.From == null ? string.Empty : $" <- {string.Join(", ", item.From)}";
                                    }

                                    writer.Write($"{l1}{l2}{state.ID}{r2}{r1}{from}");
                                    writer.WriteLine();
                                    using (writer.Indent())
                                    {
                                        foreach (var transition in state.Transitions)
                                        {
                                            writer.Write($"{transition.Stringize()}");
                                            writer.WriteLine();

                                        }
                                    }
                                }
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
