using SixCC.Sdk.Automata;

namespace SixCC.Sdk.Earley
{
    public static class Tools
    {
        public static bool Matches(this Transition transition, EarleyItem item)
        {
            return transition.Set.Contains(item.Dfa.ID);
        }
    }
}
