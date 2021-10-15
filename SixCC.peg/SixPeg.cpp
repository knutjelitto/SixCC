#include "pch.h"
#include "SixPeg.h"

#include <fstream>

namespace sixpeg
{
    using namespace std;
    using namespace peg;

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
            string name;
            bool enabled;
            string text;
        };

        struct grammar_info
        {
            string name;
            bool enabled;
            string grammar_source;
            void (*setup)(parser& parser);
            parser* parser;
            vector<sample_info> samples;
        };

        static grammar_info infos[] =
        {
            { "bnf", true, bnfpeg, setup_bnf, nullptr, {
                {"checker",         true,   bnf_ckecker},
                {"bnf",             true,   bnf_bnf},
                {"expr",            true,   bnf_expr},
                {"postal",          true,   bnf_postal},
            }},
            { "wsn", true, wsnpeg, setup_wsn, nullptr, {
                {"checker",         true,   wsn_checker},
                {"wsn",             true,   wsn_wsn},
                {"bnf",             true,   wsn_bnf},
                {"c-language",      true,   wsn_c_language},
            }},
            { "antlr4", true, antlr4peg, setup_antlr4, nullptr, {
                {"minimal",         true,   antlr4_minimal},
                {"checker",         true,   antlr4_checker},
                {"bnf",             true,   antlr4_bnf},
                {"antlr4-parser",   true,   antlr4_antlr4_parser},
                {"antlr4-lexer",    true,   antlr4_antlr4_lexer},
                {"antlr4-lexbasic", true,   antlr4_antlr4_lexbasic},
                {"c++14-parser",    true,   antlr4_cpp14_parser},
                {"c++14-lexer",     true,   antlr4_cpp14_lexer},
            }},
        };

        static bool find(string name, grammar_info& info)
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

        static bool get_parser(string name, grammar_info& info)
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

            if (!parser->load_grammar(info.grammar_source))
            {
                return false;
            }

            info.setup(*parser);

            info.parser = parser;

            return true;
        }
    }

    ast::grammar* parse(string language, string filename)
    {
        ifstream newf(filename);
        string text((istreambuf_iterator<char>(newf)), (istreambuf_iterator<char>()));

        return parse(language, filename, text);
    }

    ast::grammar* parse(string language, string name, string text)
    {
        using namespace internal;

        grammar_info info;

        if (!get_parser(language, info))
        {
            return nullptr;
        }

        info.parser->log = [&](size_t line, size_t col, const std::string& msg)
        {
            cerr << endl << name << "(" << line << "," << col << "): " << msg << endl;
        };

        ast::grammar* grammar = nullptr;

        if (!info.parser->parse(text, grammar))
        {
            cerr << "syntax error" << endl;
        }

        info.parser->log = nullptr;

        return grammar;
    }

    void checker(void)
    {
        using namespace internal;

        for (auto& i : infos)
        {
            grammar_info info;

            if (!get_parser(i.name, info))
            {
                cerr << "internal error" << endl;
                continue;
            }

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

                info.parser->log = nullptr;

            }
            cout << endl;
        }
    }
}