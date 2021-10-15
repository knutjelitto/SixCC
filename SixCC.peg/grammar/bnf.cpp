#include "../pch.h"
#include "../SixPeg.h"
#include "../include/peglib.h"

namespace sixpeg
{
    namespace internal
    {
        using namespace std;
        using namespace peg;

        void setup_bnf(parser& parser)
        {
            parser["bnf"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 2);

                auto grammar = any_cast<ast::grammar*>(vs[0]);
                return grammar;
            };

            parser["rulelist"] = [](const SemanticValues& vs)
            {
                assert(vs.size() >= 0);

                ast::grammar* grammar = new ast::grammar();

                for (auto& v : vs)
                {
                    ast::rule* rule = any_cast<ast::rule*>(v);
                    grammar->rules.push_back(rule);
                }

                return grammar;
            };

            parser["rule"] = [](const SemanticValues& vs)
            {
                assert(vs.size() == 2);

                auto name = any_cast<ast::term*>(vs[0]);
                auto term = any_cast<ast::term*>(vs[1]);

                return new ast::rule(name->u.token.text, term);
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

                for (auto& v : vs)
                {
                    alt->u.alt.terms.push_back(any_cast<ast::term*>(v));
                }

                return alt;
            };

            parser["sequence"] = [](const SemanticValues& vs)
            {
                assert(vs.size() >= 1);

                auto seq = ast::term::seq();

                for (auto& v : vs)
                {
                    seq->u.seq.terms.push_back(any_cast<ast::term*>(v));
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
}
