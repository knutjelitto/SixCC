using SixBot.Ast;
using static SixBot.Ast.AstBuilder;

var grammar = E1();

Console.Write("any key ... ");
Console.ReadKey(true);

static Grammar E1()
{
    return Grammar("E",
        "E" <=
        (
              N("E") + T("+") + N("E")
            | T("e")
        )
    );
}