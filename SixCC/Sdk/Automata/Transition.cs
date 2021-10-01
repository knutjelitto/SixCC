using SixCC.Core;

namespace SixCC.Sdk.Automata
{
    public class EpsilonTransition : Transition
    {
        public EpsilonTransition(Factory factory, State target)
            : base(factory, IntegerSet.Empty, target)
        {
        }

        public override Transition Clone(State withTarget)
        {
            return new EpsilonTransition(Factory, withTarget);
        }
    }

    public class TerminalTransition : Transition
    {
        public TerminalTransition(Factory factory, IntegerSet set, State target)
            : base(factory, set, target)
        {
        }

        public override Transition Clone(State withTarget)
        {
            return new TerminalTransition(Factory, Set, withTarget);
        }
    }

    public abstract class Transition
    {
        protected Transition(Factory factory, IntegerSet set, State target)
        {
            Factory = factory;
            Set = set;
            Target = target;
            ID = -1;
            SetId = -1;
        }

        public int ID { get; set; }
        public Factory Factory { get; }
        public IntegerSet Set { get; }
        public State Target { get; private set; }

        public int SetId { get; set; }

        public void Retarget(State newTarget)
        {
            Target = newTarget;
        }

        public abstract Transition Clone(State withTarget);

        public virtual string Stringize()
        {
            if (Set.IsEmpty)
            {
                return $"<epsilon> => {Target.ID}";
            }
            return $"{Factory.Stringize(Set)} => {Target.ID}";
        }

        public override string ToString()
        {
            return Stringize();
        }
    }
}