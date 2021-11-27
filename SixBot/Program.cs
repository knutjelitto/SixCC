using SixBot;

var grammars = new Six.Input.Checker().Run(true).ToList();

new EParser().Match("e+e+e");

var expressionGrammar = grammars.Where(g => g is not null && g.Name == "Expression").SingleOrDefault();

if (expressionGrammar is not null)
{
    var transformer = new Six.Gen.Ebnf.EbnfTransformer(expressionGrammar);
    var transformed = transformer.Transform();

    using (var writer = Six.Ast.GrammarExtensions.Writer($"{expressionGrammar.Name}-ebnf.txt"))
    {
        new Six.Gen.Ebnf.EbnfDumper(transformed).Dump(writer);
    }
}

try
{
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.Write("any key ... ");
Console.ReadKey(true);
