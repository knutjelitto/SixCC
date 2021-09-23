using SixCC.Runtime.Lexing;

namespace SixCC.Runtime.Structures
{
    public interface IDfaSet
    {
        Dfa this[int stateId] { get; }

        Dfa Spacing { get; }
    }
}