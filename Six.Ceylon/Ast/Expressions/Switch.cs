namespace Six.Ceylon.Ast
{
    public sealed class Switch : Node
    {
        public Switch(Switchable switchable)
        {
            Switchable = switchable;
        }

        public Switchable Switchable { get; }
    }

    public interface Switchable : INode
    {
    }
}
