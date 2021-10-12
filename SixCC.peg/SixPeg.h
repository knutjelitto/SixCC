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
        class term
        {
        public:
            const int min = 1;
            const int max = 1;

            static term&& tokenx(const std::string& text)
            {
                term x;
                x.variant.emplace<token>(token{ text });
                return std::move(x);
            }

        private:
            struct alt : std::vector<term>
            {};

            struct seq : std::vector<term>
            {};

            struct token : std::string
            {
                token(const std::string& text) : std::string(text) {}
            };

            struct literal : std::string
            {};

            struct iliteral : std::string
            {};

            struct comment : std::string
            {};

            std::variant<std::monostate, alt, seq, token, literal, iliteral, comment> variant;
        };


        class rule
        {
            const std::string name;
            const term term;
        };

        class grammar : std::vector<rule>
        {
            const std::string name;
        };
    }

    IMEX void bnf();
}


