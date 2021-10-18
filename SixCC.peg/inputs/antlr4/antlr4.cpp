#pragma warning(disable : 5201)
#include "../../include/peglib.h"

module Inputs;

import <any>;
import <cassert>;
import Ast;

namespace sixpeg::input
{
    using namespace std;
    using namespace peg;
    using namespace ast;

    void setup_antlr4(parser& parser)
    {
        parser["LITERAL"] = [](const SemanticValues& vs)
        {
            assert(vs.token_to_string().size() >= 2);

            auto text = vs.token_to_string();

            return term::literal(text.substr(1, text.size() - 2));
        };

        parser["IDENTIFIER"] = [](const SemanticValues& vs)
        {
            assert(vs.token_to_string().size() >= 1);

            return term::token(vs.token_to_string());
        };

        parser["FACTOR"] = [](const SemanticValues& vs)
        {
            assert(vs.choice() >= 0 && vs.choice() < 5);

            switch (vs.choice())
            {
                case 0:
                case 1:
                    return any_cast<term*>(vs[0]);
                case 2:
                    return term::option(any_cast<term*>(vs[0]));
                case 3:
                    return term::group(any_cast<term*>(vs[0]));
                case 4:
                    return term::kleene(any_cast<term*>(vs[0]));
                default:
                    throw "internal error: not reached reached!";
            }
        };

        parser["TERM"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 1);

            auto seq = term::seq();

            for (auto& v : vs)
            {
                seq->useq.terms.push_back(any_cast<term*>(v));
            }

            return seq;
        };

        parser["EXPRESSION"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 1);

            auto alt = term::alt();

            for (auto& v : vs)
            {
                alt->ualt.terms.push_back(any_cast<term*>(v));
            }

            return alt;
        };

        parser["PRODUCTION"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 2);

            auto id = any_cast<term*>(vs[0]);
            auto expr = any_cast<term*>(vs[1]);

            auto rule = new ast::rule(id->utoken.text, expr);

            return rule;
        };

        parser["SYNTAX"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 0);

            auto grammar = new ast::grammar();

            for (auto& v : vs)
            {
                grammar->rules.push_back(any_cast<ast::rule*>(v));
            }

            return grammar;
        };
    }
}