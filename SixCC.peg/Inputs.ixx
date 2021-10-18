#pragma warning(disable : 5201)
#include "include/peglib.h"

export module Inputs;

import <fstream>;
import <functional>;

import Ast;
import Outputs;
import Files;

namespace sixpeg
{
    using namespace ast;
    using namespace std;
    using namespace peg;

    namespace input
    {
        void setup_bnf(parser& parser);
        void setup_wsn(parser& parser);
        void setup_antlr4(parser& parser);

        export struct sample_info
        {
            std::string name;
            bool enabled;
            std::string filename;
        };

        export struct input_info
        {
            std::string name;
            bool enabled;
            std::string grammar_source;
            std::function<void(parser& parser)> setup;
            parser* parser;
            std::vector<sample_info> samples;
        };

        export input_info infos[] =
        {
            { "bnf", true, "bnf.peg", setup_bnf, nullptr, {
                {"checker",         true,   "checker.bnf"},
                {"checker",         true,   "minimal.bnf"},
                {"bnf",             true,   "bnf.bnf"},
                {"expr",            true,   "expr.bnf"},
                {"postal",          true,   "postal.bnf"},
            }},
            { "wsn", true, "wsn.peg", setup_wsn, nullptr, {
                {"minimal",         true,   "minimal.wsn"},
                {"checker",         true,   "checker.wsn"},
                {"wsn",             true,   "wsn.wsn"},
                {"bnf",             true,   "bnf.wsn"},
                {"c-language",      true,   "c.wsn"},
            }},
            { "antlr4", true, "antlr4.peg", setup_antlr4, nullptr, {
                {"minimal",         true,   "minimal.g4"},
                {"checker",         true,   "checker.g4"},
                {"bnf",             true,   "bnf.g4"},
            }},
        };

        export bool find(std::string name, input_info& info)
        {
            for (auto& i : infos)
            {
                if (i.name == name)
                {
                    info = i;
                    return true;
                }
            }
            return false;
        }

        export bool get_parser(std::string name, input_info& info)
        {
            if (!find(name, info))
            {
                return false;
            }

            if (info.parser != nullptr)
            {
                return true;
            }

            parser* parser = new peg::parser();

            parser->log = [&](size_t line, size_t col, const std::string& msg)
            {
                cerr << name << "(" << line << "," << col << "): " << msg << endl;
            };

            parser->enable_packrat_parsing(); // Enable packrat parsing.

            std::string pegfilename = "inputs/" + info.name + "/" + info.grammar_source;
            std::string pegsource = read_file_content(pegfilename);

            if (!parser->load_grammar(pegsource))
            {
                return false;
            }

            info.setup(*parser);

            info.parser = parser;

            return true;
        }
    }
}