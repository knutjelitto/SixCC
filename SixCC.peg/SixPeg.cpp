#include "pch.h"
#include "SixPeg.h"

using namespace std;
using namespace peg;

namespace sixpeg
{
    namespace internal
    {
#       include "grammar/bnf.peg"
#       include "grammar/bnf.samples"
#       include "grammar/wsn.peg"
#       include "grammar/wsn.samples"
#       include "grammar/antlr4.peg"
#       include "grammar/antlr4.samples"

        void setup_bnf(parser& parser);
        void setup_wsn(parser& parser);
        void setup_antlr4(parser& parser);

        struct sample_info
        {
            const string name;
            const bool enabled;
            const string text;
        };
        struct grammar_info
        {
            const string name;
            const bool enabled;
            const string grammar_source;
            void (*setup)(parser& parser);
            parser* parser;
            const vector<sample_info> samples;
        };

        static grammar_info infos[] =
        {
            { "bnf", true, bnfpeg, setup_bnf, nullptr, {
                {"checker",     true,   bnf_ckecker},
                {"bnf",         true,   bnf_bnf},
                {"expr",        true,   bnf_expr},
                {"postal",      true,   bnf_postal},
            }},
            { "wsn", true, wsnpeg, setup_wsn, nullptr, {
                {"checker",     true,   wsn_checker},
                {"wsn",         true,   wsn_wsn},
                {"bnf",         true,   wsn_bnf},
                {"c-language",  true,   wsn_c_language},
            }},
            { "antlr4", true, antlr4peg, setup_antlr4, nullptr, {
                {"checker",     true,   antlr4_checker},
                {"antlr4",      true,   antlr4_antlr4},
            }},
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

            parser->log = [&](size_t line, size_t col, const std::string& msg)
            {
                cerr << name << "(" << line << "," << col << "): " << msg << endl;
            };

            parser->enable_packrat_parsing(); // Enable packrat parsing.

            if (!parser->load_grammar(info.grammar_source))
            {
                return info;
            }

            info.setup(*parser);

            info.parser = parser;

            return info;
        }
    }

    void checker(void)
    {
        using namespace internal;

        for (auto& i : infos)
        {
            auto& info = get_parser(i.name);

            cout << info.name << ":";
            if (info.parser == nullptr)
            {
                cerr << " -parser-defect-" << endl;
                continue;
            }
            for (auto sample : info.samples)
            {
                if (!sample.enabled)
                {
                    continue;
                }
                cout << " " << sample.name;

                info.parser->log = [&](size_t line, size_t col, const std::string& msg)
                {
                    cerr << endl << sample.name << "(" << line << "," << col << "): " << msg << endl;
                };

                ast::grammar* grammar = nullptr;
                if (!info.parser->parse(sample.text, grammar))
                {
                    std::cerr << "syntax error" << std::endl;
                }
            }
            cout << endl;
        }
    }
}