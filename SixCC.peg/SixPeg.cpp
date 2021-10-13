#include "pch.h"
#include "SixPeg.h"

using namespace std;
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


static const char* const bnf_ckecker =
R"::::::::::(
<aaa> ::= ::=)::::::::::";

static const char* const wsn_wsn =
R"::::::::::(
SYNTAX     = { PRODUCTION } .
PRODUCTION = IDENTIFIER "=" EXPRESSION "." .
EXPRESSION = TERM { "|" TERM } .
TERM       = FACTOR { FACTOR } .
FACTOR     = IDENTIFIER
           | LITERAL
           | "[" EXPRESSION "]"
           | "(" EXPRESSION ")"
           | "{" EXPRESSION "}" .
IDENTIFIER = letter { letter } .
LITERAL    = """" character { character } """" .
)::::::::::";


#include "grammar/bnf.peg"
#include "grammar/wsn.peg"

namespace sixpeg
{
    namespace internal
    {
        struct grammar_info
        {
            std::string name;
            const bool enabled;
            const string grammar_source;
            void (*setup)(parser& parser);
            parser* parser;
            std::vector<std::string> samples;
        };

        static void setup_bnf(parser& parser);
        static void setup_wsn(parser& parser);

        static grammar_info infos[] =
        {
            { "bnf", true, bnfpeg, setup_bnf, nullptr, {bnf_bnf, bnf_expr, bnf_postal, bnf_ckecker}},
            { "wsn", true, wsnpeg, setup_wsn, nullptr, {wsn_wsn}},
        };

        static grammar_info& find(string name)
        {
            for (auto& i : infos)
            {
                if (i.name == name)
                {
                    return i;
                }
            }

            throw "";
        }

        static grammar_info& get_parser(string name)
        {
            grammar_info& info = find(name);

            if (info.parser != nullptr)
            {
                return info;
            }

            parser* parser = new peg::parser();

            parser->log = [](size_t line, size_t col, const std::string& msg)
            {
                std::cerr << line << ":" << col << ": " << msg << "\n";
            };

            parser->enable_packrat_parsing(); // Enable packrat parsing.

            if (!parser->load_grammar(info.grammar_source))
            {
                return info;
            }

            info.parser = parser;

            return info;
        }

        void setup_wsn(parser& parser)
        {
        }

        void setup_bnf(parser& parser)
        {
            parser["bnf"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 2);
                assert(vs.choice() == 0);

                auto id = vs.token_to_string();
                return id;
            };

            parser["rulelist"] = [](const SemanticValues& vs)
            {
                assert(vs.size() >= 0);

                auto id = vs.token_to_string();
                return id;
            };

            parser["rule"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 2);

                auto name = any_cast<ast::term*>(vs[0]);
                auto term = any_cast<ast::term*>(vs[1]);

                return new ast::rule(name, term);
            };

            parser["lhs"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 1);

                return any_cast<ast::term*>(vs[0]);
            };

            parser["rhs"] = [](const SemanticValues& vs)
            {
                assert(vs.size() <= 1);

                auto x = vs.token_to_string();

                if (vs.size() == 0)
                {
                    return ast::term::empty();
                }
                return any_cast<ast::term*>(vs[0]);
            };

            parser["alternates"] = [](const SemanticValues& vs)
            {
                assert(vs.size() >= 1);

                auto alt = ast::term::alt();

                for (auto v : vs)
                {
                    alt->push_back(any_cast<ast::term*>(v));
                }

                return alt;
            };

            parser["sequence"] = [](const SemanticValues& vs)
            {
                assert(vs.size() >= 1);

                auto seq = ast::term::seq();

                for (auto v : vs)
                {
                    seq->push_back(any_cast<ast::term*>(v));
                }

                return seq;
            };

            parser["element"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 1);

                return std::any_cast<ast::term*>(vs[0]);
            };

            parser["id"] = [](const SemanticValues& vs)
            {
                assert(vs.token_to_string().size() >= 2);

                auto name = vs.token_to_string();

                return ast::term::token(name.substr(1, name.size() - 2));
            };

            parser["literal"] = [](const SemanticValues& vs)
            {
                assert(vs.token_to_string().size() >= 2);

                auto text = vs.token_to_string();

                return ast::term::literal(text.substr(1, text.size() - 2));
            };
        }
    }

    void bnf(void)
    {
        using namespace internal;

        grammar_info& info = get_parser("bnf");

        std::string val;

        for (auto sample : info.samples)
        {
            if (!info.parser->parse(sample, val))
            {
                std::cerr << "syntax error" << std::endl;
            }
        }
    }

}