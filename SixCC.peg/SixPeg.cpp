#include "pch.h"
#include "SixPeg.h"

using namespace peg;
using namespace std;

const char* const bnf_bnf =
R"::::::::::(
<syntax> ::= <rule> | <rule> <syntax>

<rule> ::= "<" <rule-name> ">" "::=" <expression> <line-end>

<expression> ::= <list> | <list> "|" <expression>

<line-end> ::= <EOL> | <line-end>

<list> ::= <term> | <term> <list>

<term> ::= <literal> | "<" <rule-name> ">"

<literal> ::= '"' <text> '"' | "'" <text> "'"
)::::::::::";

const char* const bnf_expr =
R"::::::::::(
<expr>  ::=  <term> "+" <expr>
        |    <term>

<term>  ::=  <factor> "*" <term>
        |    <factor>

<factor>
        ::= "(" <expr> ")"
        |   <const>

<const> ::= <integer>
)::::::::::";

namespace sixpeg
{
    void bnf(void)
    {
        parser parser;

        parser.log = [](size_t line, size_t col, const string& msg)
        {
            cerr << line << ":" << col << ": " << msg << "\n";
        };

        bool ok = parser.load_grammar(R"(
#
# A simple BNF grammar
#
        
bnf             <- rulelist EOF

rulelist        <- rule*

rule            <- lhs '::=' rhs

rulestart       <- lhs '::='

lhs             <- id

rhs             <- alternates?

alternates      <- sequence ('|' sequence)*

sequence        <- element*

element         <- text
                /  !rulestart id

%whitespace     <- [ \t\n\r]*

id              <- < '<' [a-zA-Z][a-zA-Z0-9]* ('-' [a-zA-Z0-9]+)* '>' >

text            <- < ['] [^']* ['] >
                /  < ["] [^"]* ["] >

EOF             <- !.
)");

        if (!ok)
        {
            return;
        }

        parser["bnf"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 2);
            assert(vs.choice() == 0);

            auto id = vs.token_to_string();
            return id;
        };

        parser["rulelist"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();
            return id;
        };

        parser["rule"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 2);

            auto x1 = vs[0];
            auto x2 = vs[1];

            auto id = vs.token_to_string();
            return id;
        };

        parser["id"] = [](const SemanticValues& vs)
        {
            //assert(vs.size() == 1);

            auto id = vs.token_to_string();
            return id;
        };

        parser["text"] = [](const SemanticValues& vs)
        {
            auto text = vs.token_to_string();

            assert(text.size() >= 2);

            text = text.substr(1, text.size() - 2);

            return text;
        };

        // (4) Parse
        parser.enable_packrat_parsing(); // Enable packrat parsing.

        string val;
        if (!parser.parse(bnf_bnf, val))
        {
            cerr << "syntax error" << endl;
        }
    }
}