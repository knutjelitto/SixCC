#include "SixPeg.h"

#include <fstream>
#include <iostream>
#include <functional>
#include <filesystem>

import "include/peglib.h";
import Ast;
import Outputs;
import Inputs;
import Files;

namespace sixpeg
{
    using namespace std;
    using namespace peg;
    using namespace sixpeg::ast;
    using namespace sixpeg::output;

    ghandle parse(std::string language, string name, string text)
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

        ast::grammar* g = nullptr;

        if (!info.parser->parse(text, g) || nullptr == g)
        {
            cerr << "syntax error" << endl;
            assert(g == nullptr);
            info.parser->log = nullptr;

            return g;
        }

        info.parser->log = nullptr;

        return g->simplify();
    }

    bool unparse(std::string format, ghandle grammar)
    {
        sixpeg::output::output(format, (ast::grammar*)grammar);

        return true;
    }

    void check_one_sample(string in_file, string in_format, string out_format)
    {
        using namespace std::filesystem;

        auto grammar = sixpeg::parse(in_format, in_file, read_sample(in_format, in_file));

        path dir = (current_path() / ".." / ".." / "SixTmp" / "peg" / in_format / out_format).lexically_normal();

        create_directories(dir);

        path file = dir / (path(in_file).stem().string() + "." + out_format);

        sixpeg::output::output(out_format, (ast::grammar*)grammar, file.string());
    }

    void check_one()
    {
        check_one_sample("bnf.sixg", "sixg", "wsn");
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
            std::cout << std::endl;
        }
    }
}