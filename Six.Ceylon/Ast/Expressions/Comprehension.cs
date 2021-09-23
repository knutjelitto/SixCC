namespace Six.Ceylon.Ast
{
    public interface Comprehension : Argument {}


    public sealed class ForComprehension : Node, Comprehension
    {
        public ForComprehension(ForIterator iterator, Comprehension comprehension)
        {
            Iterator = iterator;
            Comprehension = comprehension;
        }

        public ForIterator Iterator { get; }
        public Comprehension Comprehension { get; }
    }

    public sealed class IfComprehension : Node, Comprehension
    {
        public IfComprehension(Conditions conditions, Comprehension comprehension)
        {
            Conditions = conditions;
            Comprehension = comprehension;
        }

        public Conditions Conditions { get; }
        public Comprehension Comprehension { get; }
    }
}
