using SixCC.Sdk.Automata;
using SixCC.Sdk.Ebnf;
using SixCC.Writing;

namespace SixCC.CC.Dumping
{
    internal static class GrammarDumper
    {
        public static void Dump(Writer writer, Grammar grammar)
        {
            writer.WriteLine($"grammar {grammar.Name}");
            using (writer.Indent())
            {
                foreach (var rule in grammar.Rules)
                {
                    writer.WriteLine();
                    DumpRule(rule);
                }
            }

            void DumpRule(Rule rule)
            {
                var attrList = new List<string>();
                if (rule.IsCallable)
                {
                    attrList.Add($"callable");
                }
                if (rule.IsNullable)
                {
                    //attrList.Add("ε");
                    attrList.Add("nullable");
                }
                if (rule.Usages.Count == 0)
                {
                    attrList.Add("unused");
                }
                if (rule.IsFragment)
                {
                    attrList.Add($"fragment");
                }
                else if (rule.IsTerminal)
                {
                    attrList.Add($"terminal");
                }
                else
                {
                    attrList.Add($"nonterminal");
                }
                string attrs;
                if (attrList.Count == 0)
                {
                    attrs = string.Empty;
                }
                else
                {
                    attrs = $" [{string.Join(",", attrList)}]";
                }

                writer.WriteLine($"[{rule.Number}] {rule.Name}{attrs}");
                writer.WriteLine();

                if (rule.Symbol is Alternative alternation)
                {
                    foreach (var sequence in alternation.Sequences)
                    {
                        if (sequence is Sequence seq)
                        {
                            writer.WriteLine($"  | {string.Join(" ", seq.Symbols)}");
                        }
                        else
                        {
                            writer.WriteLine($"  | {sequence}");
                        }
                    }
                }
                else
                {
                    writer.WriteLine($"  | {rule.Symbol}");
                }

                var unicode = new UnicodeFactory();
                var syms = grammar.Rules.Where(rule => !rule.IsFragment).Select(rule => rule.Name).ToList();
                var symbols = new SymbolFactory(syms);

                using (writer.Indent())
                {
                    writer.WriteLine();
                    if (rule.IsTerminal)
                    {
                        rule.Symbol.GetTerminalNfa(unicode).ToFinalDfa().Dump(writer);
                    }
                    else
                    {
                        rule.Symbol.GetNonterminalNfa(symbols).ToFinalDfa().Dump(writer);
                    }
                }
            }
        }
    }
}
