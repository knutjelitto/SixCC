#include "pch.h"
#include "SixPeg.h"

using namespace peg;

static const char* const bnf_bnf =
R"::::::::::(
<syntax> ::= <rule> | <rule> <syntax>

<rule> ::= "<" <rule-name> ">" "::=" <expression> <line-end>

<expression> ::= <list> | <list> "|" <expression>

<line-end> ::= <EOL> | <line-end>

<list> ::= <term> | <term> <list>

<term> ::= <literal> | "<" <rule-name> ">"

<literal> ::= '"' <text> '"' | "'" <text> "'"
)::::::::::";

static const char* const bnf_expr =
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

static const char* const bnf_postal =
R"::::::::::(
<postal-address> ::= <name-part> <street-address> <zip-part>

<name-part> ::= <personal-part> <last-name> <opt-jr-part> <EOL>
            | <personal-part> <name-part>

<personal-part> ::= <first-name> | <initial> "."

<street-address> ::= <opt-apt-num> <house-num> <street-name> <EOL>

<zip-part> ::= <town-name> "," <state-code> <ZIP-code> <EOL>

<opt-jr-part> ::= "Sr." | "Jr." | <roman-numeral> | "-empty-string-makes-problems-"
)::::::::::";

struct grammar_info
{
    std::string name;
    const bool enabled;
    std::vector<std::string> samples;
};

static grammar_info infos[] =
{
    { "bnf", true, {bnf_bnf, bnf_expr, bnf_postal } },
};

namespace sixpeg
{
    void bnf(void)
    {
        parser parser;

        parser.log = [](size_t line, size_t col, const std::string& msg)
        {
            std::cerr << line << ":" << col << ": " << msg << "\n";
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

        parser["lhs"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();

            return id;
        };

        parser["rhs"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();

            return id;
        };

        parser["alternates"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();

            return id;
        };

        parser["sequence"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();

            return id;
        };

        parser["element"] = [](const SemanticValues& vs)
        {
            auto id = vs.token_to_string();

            return id;
        };

        parser["id"] = [](const SemanticValues& vs)
        {
            auto name = vs.token_to_string();

            assert(name.size() >= 2);

            name = name.substr(1, name.size() - 2);

            return name;
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

        std::string val;
        if (!parser.parse(bnf_bnf, val))
        {
            std::cerr << "syntax error" << std::endl;
        }
    }
}