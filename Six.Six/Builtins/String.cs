using Six.Six.Sema;

namespace Six.Six.Builtins
{
    public sealed class String : Builtin
    {
        public String(Builtins builtins)
            : base(builtins, Names.Core.String)
        { }

        public override string AsWasm => $"i32";
    }
}
