using SixCC.Runtime.Lexing;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Dumping
{
    public class DfaDumper
    {
        public void Dump(IndentWriter writer, Dfa dfa)
        {
            foreach (var state in dfa.States)
            {
                Dump(writer, state);
            }
        }

        public void Dump(IndentWriter writer, DfaState state)
        {
            var finA = state.Final ? "(" : ".";
            var finB = state.Final ? ")" : ".";
            var pay = state.Payload >= 0 ? $"  «{state.Payload}»" : string.Empty;

            writer.WriteLine($"{finA}{state.Id}{finB}{pay}");
            writer.Indent(() =>
            {
                foreach (var transition in state.Transitions)
                {
                    writer.WriteLine($"{transition.Target.Id} <= {Str(transition.Set)}");
                }
            });
        }

        private string Str(Set set)
        {
            return set.ToString();
        }
    }
}
