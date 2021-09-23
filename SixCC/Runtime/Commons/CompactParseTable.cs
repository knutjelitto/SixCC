using SixCC.Runtime.Structures;

namespace SixCC.Runtime.Commons
{
    public class CompactParseTable : IParseTable
    {
        private readonly CompactState[] states;

        public CompactParseTable(CompactState[] states, int numberOfTerminals, int numberOfSymbols)
        {
            this.states = states;
            NumberOfTerminals = numberOfTerminals;
            NumberOfSymbols = numberOfSymbols;
        }

        public IState this[int stateNo] => states[stateNo];

        public IStateItem this[int stateNo, int symNo] => this[stateNo][symNo];

        public int NumberOfStates => states.Length;
        public int NumberOfTerminals { get; }
        public int NumberOfSymbols { get; }
    }
}
