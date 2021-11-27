namespace Six.Gen.Ebnf
{
    public class EbnfGrammar : Ast.Grammar<Rule>
    {
        internal EbnfGrammar(string name)
            : base(name, rule => rule.Name)
        {
        }
    }
}
