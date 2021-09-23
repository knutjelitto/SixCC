using SixCC.Sdk.Output;

namespace SixCC.Sdk.Grammars
{
    public class Option : Symbol
    {
        public Option(string name, string value)
            : base(name)
        {
            Value = (Symbol)value;
        }

        public Symbol Value { get; }
    }
}
