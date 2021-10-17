#include "SixPeg.h"

#include <fstream>

#include "ast.h"
#include "ast/simplifier.h"
#include "files.h"
#include "outputs/outputs.h"
#include "include/peglib.h"

namespace sixpeg
{
    using namespace std;
    using namespace peg;

    namespace input
    {
        void setup_bnf(parser& parser);
        void setup_wsn(parser& parser);
        void setup_antlr4(parser& parser);

        struct sample_info
        {
            string name;
            bool enabled;
            string filename;
        };

        struct input_info
        {
            string name;
            bool enabled;
            string grammar_source;
            void (*setup)(parser& parser);
            parser* parser;
            vector<sample_info> samples;
        };

        static input_info infos[] =
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

        static bool find(string name, input_info& info)
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

        static bool get_parser(string name, input_info& info)
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

            string pegfilename = "inputs/" + info.name + "/" + info.grammar_source;
            string pegsource = read_file_content(pegfilename);

            if (!parser->load_grammar(pegsource))
            {
                return false;
            }

            info.setup(*parser);

            info.parser = parser;

            return true;
        }
    }

    ghandle parse(string language, string name, string text)
    {
        using namespace sixpeg::input;

        input_info info;

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
            assert(grammar == nullptr);
        }

        info.parser->log = nullptr;

        return sixpeg::ast::simplify(grammar);
    }

    bool unparse(std::string format, ghandle grammar)
    {
        sixpeg::output::output(format, (ast::grammar*)grammar);

        return true;
    }

    void check_one()
    {
        string in_format = "wsn";
        string in_file = "wsn.wsn";
        string out_format = "wsn";

        auto grammar = sixpeg::parse(in_format, in_file, read_sample(in_format, in_file));

        sixpeg::unparse(out_format, grammar);
    }

    void check_all()
    {
        using namespace input;

        for (auto& info : infos)
        {
            if (!info.enabled)
            {
                continue;
            }

            cout << info.name << ":";
            if (info.parser == nullptr)
            {
                if (!get_parser(info.name, info))
                {
                    cerr << " -parser-defect-" << endl;
                    continue;
                }
            }
            for (auto sample : info.samples)
            {
                if (!sample.enabled)
                {
                    continue;
                }

                string name = "inputs/" + info.name + "/samples/" + sample.filename;

                cout << " " << sample.filename;

                string text = read_sample(info.name, sample.filename);

                info.parser->log = [&](size_t line, size_t col, const std::string& msg)
                {
                    cerr << endl << name << "(" << line << "," << col << "): " << msg << endl;
                };

                ast::grammar* grammar = nullptr;
                if (!info.parser->parse(text, grammar))
                {
                    std::cerr << "syntax error" << std::endl;
                }

                info.parser->log = nullptr;

            }
            cout << endl;
        }
    }
}