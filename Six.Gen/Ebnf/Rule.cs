namespace Six.Gen.Ebnf
{
    public class Rule : Operator
    {
        public Rule(string name, Operator argument)
            : base(argument)
        {
            Name = name;
        }

        public string Name { get; }

        public Operator Argument => Arguments[0];
    }
}
