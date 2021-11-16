using Six.Ast;

HelloWorldGenerated.HelloWorld.SayHello();

try
{
    Do(new Gamma0().Grammar());
    Do(new Sixg().Grammar());
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
}

class Gamma0 : GrammarBuilder
{
    public Gamma0() : base("𝚪₀") { }

    protected override void Build()
    {
        Define("S",
              Ref("A") + Ref("S") + T("d")
            | Ref("B") + Ref("S")
            | Epsilon
        );

        Define("A", T("a") | T("c"));
        Define("B", T("a") | T("b"));
    }
}

class Sixg : GrammarBuilder
{
    public Sixg() : base("sixg") { }

    protected override void Build()
    {
        Define("start", Ref("grammar"));
        
        Define("whitespace", Ref("skip"));
        
        Define("grammar", T("grammar") + Ref("identifier") + T(";") + Ref("rules"));

        Define("rules", Star(Ref("rule")));

        Define("rule", Ref("identifier") + T(":") + Ref("expression") + T(";"));

        Define("expression", Ref("alternation"));

        Define("alternation", Ref("sequence") + Star(T("|") + Ref("sequence")));

        Define("sequence", Star(Ref("element")));

        Define("element",
              Ref("primary") + Opt(Ref("ebnf"))
            | Ref("range")
        );

        Define("ebnf", Forced(T("*") | T("+") | T("?")) );

        Define("range", Ref("string") + (T("..") | T('⋯')) + Ref("string"));

        Define("primary",
              Ref("identifier")
            | Ref("string")
            | T("(") + Ref("expression") + T(")")
            | T("<") + Ref("expression") + T(">")
        );

        Define("identifier", Forced(Ref("id-begin") + Star(Ref("id-continue"))));

        Define("id-begin", Ref("letter") + Star(Ref("letter-or-digit")));

        Define("id-continue", T("-") + Plus(Ref("letter-or-digit")));

        Define("letter", Range('a', 'z') | Range('A', 'Z'));

        Define("digit", Range('0', '9'));

        Define("letter-or-digit", Ref("letter") | Ref("digit"));

        Define("string", Forced(T("'") + Star(Ref("character")) + T("'")) );

        Define("character",
              Range(0x0020, 0x10FFFF) - T('\'') - T('\\')
            | T('\\') + Ref("escape")
        );

        Define("escape",
              T('\'')
            | T('\\')
            | T('a')
            | T('b')
            | T('f')
            | T('n')
            | T('t')
            | T('v')
            | T('x') + Ref("hex") + Ref("hex")
            | T("u{") + Opt(Ref("hex")) + Opt(Ref("hex")) + Opt(Ref("hex")) + Opt(Ref("hex")) + Opt(Ref("hex")) + Ref("hex") + T("}")
        );

        Define("hex",
              Ref("digit")
            | Range('A', 'F')
            | Range('a', 'f')
        );

        Define("skip", Forced(Ref("space") | Ref("line-end") | Ref("comment")) );

        Define("space", T(' ') | T('\t'));

        Define("line-end",
              T('\r') + T('\n')
            | T('\n')
            | T('\r')
            | T('\u2028')
            | T('\u2029')
        );

        Define("line-ender",
              T('\n')
            | T('\r')
            | T('\u2028')
            | T('\u2029')
        );

        Define("comment", Ref("line-comment") | Ref("block-comment"));

        Define("line-comment", T("//") + Star(Any - Ref("line-ender")) );

        Define("block-comment", T("/*") + Star(Any - T("*/")) + T("*/"));
    }
}

class E1 : GrammarBuilder
{
    public E1() : base("E1") { }

    protected override void Build()
    {
        Define("E",
                Ref("E") + T("+") + Ref("E")
            | T("e")
        );
    }
}

class Json : GrammarBuilder
{
    public Json() : base("Json") { }

    protected override void Build()
    {
        Define("json",
            Ref("element")
        );

        Define("value",
              Ref("object")
            | Ref("array")
            | Ref("string")
            | Ref("number")
            | T("true")
            | T("false")
            | T("null")
        );

        Define("object",
              T('{') + Ref("ws") + T('}')
            | T('{') + Ref("members") + T('}')
        );

        Define("members",
              Ref("member")
            | Ref("member") + T(',') + Ref("members")
        );

        Define("member",
              Ref("ws") + Ref("string") + Ref("ws") + T(':') + Ref("element")
        );

        Define("array",
              T('[') + Ref("ws") + T(']')
            | T('[') + Ref("elements") + T(']')
        );

        Define("elements",
              Ref("element")
            | Ref("element") + T(',') + Ref("elements")
        );

        Define("element",
              Ref("ws") + Ref("value") + Ref("ws")
        );

        Define("string",
              Forced(T('"') + Star(Ref("character")) + T('"'))
        );

        Define("character",
              Range(0x0020, 0x10FFFF) - T('"') - T('\\')
            | T('\\') + Ref("escape")
        );

        Define("escape",
              T('"')
            | T('\\')
            | T('/')
            | T('b')
            | T('f')
            | T('n')
            | T('t')
            | T('v')
            | T('u') + Ref("hex") + Ref("hex") + Ref("hex") + Ref("hex")
        );

        Define("hex",
              Ref("digit")
            | Range('A', 'F')
            | Range('a', 'f')
        );

        Define("number",
              Forced(Ref("integer") + Ref("fraction") + Ref("exponent"))
        );

        Define("integer",
              Ref("digit")
            | Ref("onenine") + Ref("digits")
            | T('-') + Ref("digit")
            | T('-') + Ref("onenine") + Ref("digits")
        );

        Define("digits",
              Ref("digit")
            | Ref("digit") + Ref("digits")
        );

        Define("digit",
              T('0')
            | Ref("onenine")
        );

        Define("onenine",
              Range('1', '9')
        );

        Define("fraction",
              Epsilon
            | T('.') + Ref("digits")
        );

        Define("exponent",
              T('E') + Ref("sign") + Ref("digits")
            | T('e') + Ref("sign") + Ref("digits")
        );

        Define("sign",
              Epsilon
            | T('+')
            | T('-')
        );

        Define("ws",
              Star(
                  T(0x0020)
                | T(0x000A)
                | T(0x000D)
                | T(0x0009)
              )
        );
    }
}
