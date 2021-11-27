using SixCC.Sdk.Automata;
using SixCC.Sdk.Grammars;
using SixCC.Sdk.LR;
using SixCC.Runtime.Parsing;

namespace SixCC.Sdk.Build
{
    public class SetsBuilder
    {
        public SetsBuilder(Grammar grammar)
        {
            Grammar = grammar;
        }

        public Grammar Grammar { get; }
        public CoreFactory CoreFactory => Grammar.CoreFactory;

        public void Build()
        {
            CoreFactory.Initialize(Grammar.Nonterminals.SelectMany(n => n.Productions).ToList());

            BuildFirstSets();
            BuildCoreFirstSets();

            BuildLR1Sets();
            BuildLR1Table();

            BuildSimpleParseTable();
            BuildDfaSets();
        }

        private void BuildFirstSets()
        {
            foreach (var terminal in Grammar.Terminals)
            {
                terminal.First.Add(terminal);
            }
            foreach (var nonterminal in Grammar.Nonterminals)
            {
                foreach (var production in nonterminal.Productions)
                {
                    if (production.IsEpsilon)
                    {
                        nonterminal.First.WithEpsilon = true;
                    }
                }
            }

            var changed = true;
            while (changed)
            {
                changed = false;
                foreach (var nonterminal in Grammar.Nonterminals)
                {
                    foreach (var production in nonterminal.Productions)
                    {
                        var epsilons = 0;
                        foreach (var symbol in production.Symbols)
                        {
                            foreach (var terminal in symbol.First.ToList())
                            {
                                changed = changed || nonterminal.First.Add(terminal);
                            }
                            if (!symbol.First.WithEpsilon)
                            {
                                break;
                            }
                            epsilons += 1;
                        }
                        if (epsilons == production.Symbols.Count && !nonterminal.First.WithEpsilon)
                        {
                            nonterminal.First.WithEpsilon = true;
                            changed = true;
                        }
                    }
                }
            }
        }

        private void BuildCoreFirstSets()
        {
            foreach (var core in CoreFactory)
            {
                Assert(core.First.IsEmpty);
            }
            foreach (var core in CoreFactory)
            {
                var dot = core.Dot;
                for (; dot < core.Count; dot += 1)
                {
                    foreach (var terminal in core[dot].First)
                    {
                        core.First.Add(terminal);
                    }
                    if (!core[dot].First.WithEpsilon)
                    {
                        break;
                    }
                }

                if (dot == core.Count)
                {
                    core.First.WithEpsilon = true;
                }
            }
            foreach (var core in CoreFactory)
            {
                Assert(!core.First.IsEmpty);
            }
        }

        private void BuildLR1Sets()
        {
            Assert(Grammar.Accept != null);
            Assert(Grammar.Eof != null);

            var start = new LR1(CoreFactory.Get(Grammar.Accept.Productions[0]), true, Grammar.Eof.First);
            var startSet = new LR1Set(start);

            var closer = new LR1Set.Closer2(Grammar.LR1Sets, startSet);
            closer.Go();
        }

        private void BuildLR1Table()
        {
            Assert(Grammar.PSymbols != null);

            var states = Grammar.LR1Sets.Count;
            var symbols = Grammar.PSymbols.Count;

            var table = new TableCell[states, symbols];
            for (var i = 0; i < states; ++i)
            {
                for (var j = 0; j < symbols; ++j)
                {
                    table[i, j] = new TableCell();
                }
            }

            foreach (var state in Grammar.LR1Sets)
            {
                foreach (var item in state)
                {
                    if (item.IsComplete)
                    {
                        var prodId = item.Core.Production.Id;

                        foreach (var terminal in item.Lookahead)
                        {
                            if (ReferenceEquals(terminal, Grammar.Eof) && prodId == 0)
                            {
                                table[state.Id, terminal.Pid].Add(new Accept());
                            }
                            else
                            {
                                table[state.Id, terminal.Pid].Add(new Reduce(item.Core.Production.Id));
                            }
                        }
                    }
                    else if (item.PostDot is Terminal terminal)
                    {
                        table[state.Id, terminal.Pid].Add(new Shift(item.ToState));
                    }
                    else if (item.PostDot is Nonterminal nonterminal)
                    {
                        table[state.Id, nonterminal.Pid].Add(new Shift(item.ToState));
                    }
                }
            }

            Grammar.Table = table;
        }

        private void BuildSimpleParseTable()
        {
            Assert(Grammar.PSymbols != null);
            Assert(Grammar.Table != null);

            var fullTable = Grammar.Table;
            var numberOfStates = Grammar.LR1Sets.Count;
            var numberOfTerminals = Grammar.PSymbols.Where(s => s is Terminal).Count();
            var numberOfSymbols = Grammar.PSymbols.Count;

            Assert(fullTable.GetLength(0) == numberOfStates);
            Assert(fullTable.GetLength(1) == numberOfSymbols);

            var table = new ParseAction[numberOfStates, numberOfSymbols];

            for (var stateNo = 0; stateNo < numberOfStates; ++stateNo)
            {
                for (var symNo = 0; symNo < numberOfSymbols; ++symNo)
                {
                    TableAction? action = fullTable[stateNo, symNo].OfType<Shift>().LastOrDefault();
                    if (action == null)
                    {
                        action = fullTable[stateNo, symNo].LastOrDefault();
                    }

                    ParseAction entry;
                    switch (action)
                    {
                        case Accept:
                            entry = ParseAction.Accept;
                            break;
                        case Shift shift:
                            entry = (ParseAction) (shift.State << 2) | ParseAction.Shift;
                            break;
                        case Reduce reduce:
                            entry = (ParseAction) (reduce.Production << 2) | ParseAction.Reduce;
                            break;
                        default:
                            entry = ParseAction.Error;
                            break;
                    }
                    table[stateNo, symNo] = entry;
                }
            }

            Grammar.ParseTable = ParseTable.From(table, numberOfTerminals);
        }

        private void BuildDfaSets()
        {
            Assert(Grammar.ParseTable != null);

            var terminalSets = new List<Integers>();

            for (var stateNo = 0; stateNo < Grammar.ParseTable.NumberOfStates; ++stateNo)
            {
                var terminalSet = new Integers();

                for (var symNo = 0; symNo < Grammar.ParseTable.NumberOfTerminals; ++symNo)
                {
                    switch (Grammar.ParseTable[stateNo][symNo].Action)
                    {
                        case ParseAction.Accept:
                        case ParseAction.Shift:
                        case ParseAction.Reduce:
                            terminalSet.Add(symNo);
                            break;
                    }
                }

                Assert(!terminalSet.IsEmpty);
                terminalSets.Add(terminalSet);
            }

            var ts = new List<(Terminal terminal, int index)>(Grammar.Terminals.Where(t => t.IsPid).Select((t, i) => (t, i)));
            var terminals = Grammar.Terminals.Where(t => t.IsPid).ToList();
            var tDfas = Enumerable.Repeat(FA.None(), terminals.Count).ToArray();

            var result = Parallel.ForEach(ts, x =>
            {
                var terminal = x.terminal;
                var index = x.index;
                var fa = terminal.Raw.Expression.GetFA()!;
                fa = fa.ToDfa();
                fa = fa.Minimize();
                fa = fa.RemoveDead();
  
                foreach (var state in fa.Finals)
                {
                    state.SetPayload(terminal.Id);
                }
                tDfas[index] = fa;
            });

            Assert(result.IsCompleted);

            var terminalDfas = tDfas.ToList();
            var already = new Dictionary<Integers, int>();
            var stateDfas = new List<int>();

            foreach (var terminalSet in terminalSets)
            {
                Assert(!terminalSet.IsEmpty);

                if (!already.TryGetValue(terminalSet, out var index))
                {
                    index = already.Count;

                    already.Add(terminalSet, already.Count);

                }

                stateDfas.Add(index);
            }

            var dfas = Enumerable.Repeat(FA.None(), already.Count).ToArray();

            result = Parallel.ForEach(already, kv =>
            {
                var terminalSet = kv.Key;
                var index = kv.Value;

                FA dfa;
                if (terminalSet.Cardinality == 1)
                {
                    dfa = terminalDfas[terminalSet.Single()].Clone().RemoveDead();
                }
                else
                {
                    dfa = Combine(terminalSet.Select(i => terminalDfas[i]));
                }

                var finals = dfa.Finals.Select(s => s.Payload).Distinct().OrderBy(p => p).ToList();
                var numbers = terminalSet.Distinct().OrderBy(p => p).ToList();
                Assert(finals.SequenceEqual(numbers));

                dfas[index] = dfa;
            });

            FA Combine(IEnumerable<FA> fas)
            {
                var combined = fas.First().Clone();
                foreach (var fa in fas.Skip(1))
                {
                    combined = combined.Union(fa, true);
                }
                return combined;
            }

            Assert(result.IsCompleted);
            Assert(Grammar.Table != null);
            Assert(stateDfas.Count == Grammar.Table.GetLength(0));

            Grammar.Dfas = dfas.ToArray();
            Grammar.StateToDfa = stateDfas;
        }
    }
}
