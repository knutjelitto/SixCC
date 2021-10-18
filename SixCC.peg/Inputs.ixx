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
        struct Parser
        {
            Parser(string format);
            virtual void setup() = 0;
            bool create(string format);
            void* p = nullptr;
        };

        struct SixgParser : Parser
        {
            SixgParser() : Parser("sixg")
            {
            }
            void setup() override;
        };

        struct BnfParser : Parser
        {
            BnfParser() : Parser("bnf")
            {
            }
            void setup() override;
        };

        struct WsnParser : Parser
        {
            WsnParser() : Parser("wsn")
            {
            }
            void setup() override;
        };

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
            std::function<Parser* (void)> create;
            parser* parser;
            std::vector<sample_info> samples;
        };

        export input_info infos[] =
        {
            { "sixg", true, "sixg.peg", []() {return new SixgParser(); }, nullptr, {
                {"minimal",         true,   "minimal.sixg"},
                {"checker",         true,   "checker.sixg"},
                {"bnf",             true,   "bnf.sixg"},
                {"sixg",            true,   "sixg.sixg"},
            }},
            { "bnf", true, "bnf.peg", []() {return new BnfParser(); }, nullptr, {
                {"minimal",         true,   "minimal.bnf"},
                {"checker",         true,   "checker.bnf"},
                {"bnf",             true,   "bnf.bnf"},
                {"expr",            true,   "expr.bnf"},
                {"postal",          true,   "postal.bnf"},
            }},
            { "wsn", true, "wsn.peg", []() {return new WsnParser(); }, nullptr, {
                {"minimal",         true,   "minimal.wsn"},
                {"checker",         true,   "checker.wsn"},
                {"wsn",             true,   "wsn.wsn"},
                {"bnf",             true,   "bnf.wsn"},
                {"c-language",      true,   "c.wsn"},
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

        Parser::Parser(string format)
        {
            create(format);
        }

        bool Parser::create(string name)
        {
            if (p != nullptr)
            {
                return true;
            }

            parser* parser = new peg::parser();

            parser->log = [&](size_t line, size_t col, const std::string& msg)
            {
                cerr << name << "(" << line << "," << col << "): " << msg << endl;
            };

            parser->enable_packrat_parsing(); // Enable packrat parsing.

            std::string pegfilename = "inputs/" + name + "/" + name + ".peg";
            std::string pegsource = read_file_content(pegfilename);

            if (!parser->load_grammar(pegsource))
            {
                return false;
            }

            p = parser;

            setup();

            return true;
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

            std::string pegfilename = "inputs/" + name + "/" + name + ".peg";
            std::string pegsource = read_file_content(pegfilename);

            if (!parser->load_grammar(pegsource))
            {
                return false;
            }

            info.create()->setup(*parser);

            info.parser = parser;

            return true;
        }
    }
}