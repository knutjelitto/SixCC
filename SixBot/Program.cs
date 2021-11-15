using SixBot.Ast;
using static SixBot.Ast.AstBuilder;

try
{
    Do(new E1().Grammar());
    Do(new Json().Grammar());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.Write("any key ... ");
Console.ReadKey(true);

static void Do(Grammar grammar)
{
    grammar.Dump($"{grammar.Name}-dump.txt");
}

class E1 : GrammarBuilder
{
    public E1() : base("E1") { }

    protected override void Build()
    {
        Rule("E",
                N("E") + T("+") + N("E")
            | T("e")
        );
    }
}

class Json : GrammarBuilder
{
    public Json() : base("Json") { }

    protected override void Build()
    {
        Rule("json",
            N("element")
        );

        Rule("value",
              N("object")
            | N("array")
            | N("string")
            | N("number")
            | T("true")
            | T("false")
            | T("null")
        );

        Rule("object",
              T('{') + N("ws") + T('}')
            | T('{') + N("members") + T('}')
        );

        Rule("members",
              N("member")
            | N("member") + T(',') + N("members")
        );

        Rule("member",
              N("ws") + N("string") + N("ws") + T(':') + N("element")
        );

        Rule("array",
              T('[') + N("ws") + T(']')
            | T('[') + N("elements") + T(']')
        );

        Rule("elements",
              N("element")
            | N("element") + T(',') + N("elements")
        );

        Rule("element",
              N("ws") + N("value") + N("ws")
        );

        Rule("string",
              T(T('"') + N("characters") + T('"'))
        );

        Rule("characters",
              Empty
            | N("character") + N("characters")
        );

        Rule("character",
              Range(0x0020, 0x10FFFF) - T('"') - T('\\')
            | T('\\') + N("escape")
        );

        Rule("escape",
              T('"')
            | T('\\')
            | T('/')
            | T('b')
            | T('f')
            | T('n')
            | T('t')
            | T('t')
            | T('u') + N("hex") + N("hex") + N("hex") + N("hex")
        );

        Rule("hex",
              N("digit")
            | Range('A', 'F')
            | Range('a', 'f')
        );

        Rule("number",
              T(N("integer") + N("fraction") + N("exponent"))
        );

        Rule("integer",
              N("digit")
            | N("onenine") + N("digits")
            | T('-') + N("digit")
            | T('-') + N("onenine") + N("digits")
        );

        Rule("digits",
              N("digit")
            | N("digit") + N("digits")
        );

        Rule("digit",
              T('0')
            | N("onenine")
        );

        Rule("onenine",
              Range('1', '9')
        );

        Rule("fraction",
              Empty
            | T('.') + N("digits")
        );

        Rule("exponent",
              T('E') + N("sign") + N("digits")
            | T('e') + N("sign") + N("digits")
        );

        Rule("sign",
              Empty
            | T('+')
            | T('-')
        );

        Rule("ws",
              Empty
            | T(0x0020) + N("ws")
            | T(0x000A) + N("ws")
            | T(0x000D) + N("ws")
            | T(0x0009) + N("ws")
        );

#if false
        Rule("number",
              Empty
        );

        Rule("ws",
              Empty
        );
#endif
    }
}
