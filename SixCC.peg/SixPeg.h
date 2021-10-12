#pragma once

#ifdef SIXCCPEG_EXPORTS
#define IMEX __declspec(dllexport)
#else
#define IMEX __declspec(dllimport)
#endif

#include <string>
#include <vector>
#include <variant>

namespace sixpeg
{
    namespace ast
    {
        struct term
        {
        };

        struct alt : term, std::vector<term>
        {
        };

        struct seq : term, std::vector<term>
        {
        };

        struct token : term, std::string
        {
        };
    }

    IMEX void check1();
    IMEX void bnf();

}


