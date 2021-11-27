namespace Six.Core
{
    public interface ILocation
    {
        ISource Source { get; }
        int Offset { get; }
        int Length { get; }

        string GetText();
    }
}
