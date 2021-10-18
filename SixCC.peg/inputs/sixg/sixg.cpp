#pragma warning(disable : 5201)
#include "../../include/peglib.h"

module Inputs;

import <any>;
import <cassert>;
import <iostream>;
import Ast;

namespace sixpeg::input
{
    using namespace std;
    using namespace peg;
    using namespace ast;
        
    void setup_sixg(parser& parser);

    void SixgParser::setup()
    {
        setup_sixg(*(parser*)p);
    }

    void setup_sixg(parser& parser)
    {
        parser["grammar"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 3);

            auto name = any_cast<term*>(vs[0]);
            auto rules = any_cast<vector<rule*>>(vs[1]);

            auto g = new grammar();

            for (auto rule : rules)
            {
                g->add(rule);
            }

            return g;
        };

        parser["rule_list"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 0);

            vector<rule*> rule_list;

            for (auto rulev : vs)
            {
                auto rule = any_cast<ast::rule*>(rulev);

                rule_list.push_back(rule);
            }

            return rule_list;
        };

        parser["rule"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 2);

            auto name = any_cast<string>(vs[0]);
            auto expression = any_cast<term*>(vs[1]);

            return new ast::rule(name, expression);
        };

        parser["rule_identifier"] = [](const SemanticValues& vs)
        {
            assert(vs.token_to_string().size() >= 1);

            auto id = vs.token_to_string();

            return id;
        };

        parser["expression"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 1);

            return any_cast<term*>(vs[0]);
        };

        parser["alternatives"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 1);

            auto alts = term::alt();
            for (auto altv : vs)
            {
                auto alt = any_cast<term*>(altv);
                alts->ualt.terms.push_back(alt);
            }

            return alts;
        };

        parser["sequence"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 0);

            auto seqs = term::seq();
            for (auto seqv : vs)
            {
                auto seq = any_cast<term*>(seqv);
                seqs->useq.terms.push_back(seq);
            }

            return seqs;
        };

        parser["element"] = [](const SemanticValues& vs)
        {
            assert(vs.size() >= 1 && vs.size() <= 2);

            return any_cast<term*>(vs[0]);
        };


        parser["atom"] = [](const SemanticValues& vs)
        {
            assert(vs.choice() >= 0 && vs.choice() <= 4);

            switch (vs.choice())
            {
                case 0:
                case 1:
                case 2:
                    return any_cast<term*>(vs[0]);
                case 3:
                    return term::group(any_cast<term*>(vs[0]));
                case 4:
                    return (term*)nullptr;
            }

            return any_cast<term*>(vs[0]);
        };

        parser["string"] = [](const SemanticValues& vs)
        {
            assert(vs.token_to_string().size() >= 2);

            auto id = vs.token_to_string();

            return term::literal(id);
        };

        parser["range"] = [](const SemanticValues& vs)
        {
            assert(vs.size() == 2);

            return any_cast<term*>(vs[0]);
        };


        parser["identifier"] = [](const SemanticValues& vs)
        {
            assert(vs.token_to_string().size() >= 1);

            auto id = vs.token_to_string();

            return term::token(id);
        };
    }
}