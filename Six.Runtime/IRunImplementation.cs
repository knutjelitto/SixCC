namespace Six.Runtime
{
    public interface IRunImplementation
    {
        Slot[] Slots { get; }
        Production[] Productions { get; }
        Symbol[] Symbols { get; }
    }
}
