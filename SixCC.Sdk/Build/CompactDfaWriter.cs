using SixCC.Sdk.Automata;
using SixCC.Sdk.Commons;
using SixCC.Sdk.Grammars;

namespace SixCC.Sdk.Build
{
    public class CompactDfaWriter
    {
        private readonly Grammar Grammar;
        private readonly BinWriter writer;

        public CompactDfaWriter(Grammar grammar)
        {
            Grammar = grammar;
            writer = new BinWriter();
        }

        public byte[] Write()
        {
            var dfas = Grammar.Dfas.Concat(Enumerable.Repeat(Grammar.SpacingDfa, 1)).ToList();
            var sets = new UniqueList<Integers>();

            for (var i = 0; i < dfas.Count; ++i)
            {
                var dfa = dfas[i];

                foreach (var state in dfa.States)
                {
                    foreach (var transition in state.Transitions)
                    {
                        transition.SetId = sets.MaybeAlreadyAdd(transition.Set);
                    }
                }
            }

            writer.Write(Grammar.StateToDfa.Count);
            writer.Write(Grammar.StateToDfa);

            writer.Write(sets.Count);
            foreach (var set in sets)
            {
                var intervals = set.GetIntervals().ToList();
                writer.Write(intervals.Count);
                foreach (var (min, max) in intervals)
                {
                    writer.Write(min);
                    writer.Write(max);
                }
            }

            writer.Write(dfas.Count);
            foreach (var dfa in dfas)
            {
                writer.Write(dfa.States.Count);
                foreach (var state in dfa.States)
                {
                    writer.Write(state.Final);
                    writer.Write(state.Payload + 1);
                }
                foreach (var state in dfa.States)
                {
                    writer.Write(state.Transitions.Count);
                    foreach (var transition in state.Transitions)
                    {
                        writer.Write(transition.SetId);
                        writer.Write(transition.TargetId);
                    }
                }
            }

            return writer.ToArray();
        }
    }
}
