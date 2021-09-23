using Six.Tools;

namespace Six.Ceylon.Model
{
    public interface FromSource
    {
        FileRef Source { get; }
        Compiler Compiler { get; }
    }
}
