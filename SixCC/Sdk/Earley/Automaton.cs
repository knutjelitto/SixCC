using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Earley
{
    public class Automaton
    {
        public Automaton(string name, List<Automata.DFA> dfas)
        {
            Debug.Assert(dfas.Count > 0);
            Debug.Assert(dfas.All(d => d.Symbol.Length > 0));
            Debug.Assert(dfas.Select((d, i) => (d, i)).All(p => p.d.ID == p.i));
            Name = name;
            Dfas = dfas;
        }

        public string Name { get; }
        public Automata.DFA Start => Dfas[0];
        public List<Automata.DFA> Dfas { get; }
    }
}
