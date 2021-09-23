using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Earley
{
    public class EarleyItem
    {
        public HashSet<FromTransition> From = new(0);

        public EarleyItem(EarleySet set, DFA dfa, State state, EarleySet originSet)
        {
            Set = set;
            Dfa = dfa;
            State = state;
            OriginSet = originSet;
            ID = -1;
        }

        public int ID { get; set; }
        public EarleySet Set { get; }
        public DFA Dfa { get; }
        public State State { get; }
        public EarleySet OriginSet { get; }

        public bool IsEmpty => Set.ID == OriginSet.ID;

        public virtual bool IsFinal => State.Final;

        public EarleyItem AddFrom(EarleyItem finished, EarleyItem item)
        {
            From.Add(new FromTransition(finished, item));
            return this;
        }

        public override string ToString()
        {
            return $"Set[{Set.ID}] Item[{ID}] {Dfa.Symbol}[{State.ID}] <{OriginSet.ID}>";
        }
    }
}
