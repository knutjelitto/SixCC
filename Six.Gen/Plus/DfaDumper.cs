using Six.Rex;

namespace Six.Gen
{
    public class FaDfaDumper
    {
        public void Dump(Writer writer, FA dfa)
        {
            foreach (var state in dfa.States)
            {
                Dump(writer, state);
            }
        }

        public void Dump(Writer writer, State state)
        {
            var finA = state.IsFinal ? "(" : ".";
            var finB = state.IsFinal ? ")" : ".";
            var pay = state.IsPayload ? $"  «{state.Payload}»" : string.Empty;

            writer.WriteLine($"{finA}{state.Id}{finB}{pay}");
            writer.Indent(() =>
            {
                foreach (var transition in state.Transitions)
                {
                    writer.WriteLine($"{transition.Target.Id} <= {Str(transition.Set)}");
                }
            });
        }

        private string Str(Integers set)
        {
            if (Integers.Any.Cardinality - set.Cardinality <= 5)
            {                
                return $"¬[{string.Join(", ", set.Not().GetIntervals().Select(i => Str(i)))}]";
            }
            return $"[{string.Join(", ", set.GetIntervals().Select(i => Str(i)))}]";
        }

        private string Str((int min, int max) i)
        {
            return string.Join(", ", Enum(i.min, i.max));
        }

        private IEnumerable<string> Enum(int min, int max)
        {
            if (max - min <= 4)
            {
                for (var i = min; i <= max; i++)
                {
                    yield return CharRep.InRange(i);
                }
            }
            else
            {
                yield return $"{CharRep.InRange(min)} - {CharRep.InRange(max)}";
            }
        }
    }
}
