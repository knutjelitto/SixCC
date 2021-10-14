#pragma once

#ifdef SIXCCPEG_EXPORTS
#define IMEX __declspec(dllexport)
#else
#define IMEX __declspec(dllimport)
#endif

#include <cassert>
#include <string>
#include <vector>
#include <variant>
#include <algorithm>

namespace sixpeg
{
    IMEX void checker();

    namespace ast
    {
        using namespace std;

        enum termtype
        {
            none,
            empty,
            group,
            token,
            literal,
            iliteral,
            comment,
            alt,
            seq,
        };

        class term final
        {
        public:
            static term* empty()
            {
                return new term(termtype::empty);
            }

            static term* alt()
            {
                return new term(termtype::alt);
            }

            static term* seq()
            {
                return new term(termtype::seq);
            }

            static term* token(string&& text)
            {
                return new term(termtype::token, move(text));
            }

            static term* literal(string&& text)
            {
                return new term(termtype::literal, move(text));
            }

            static term* comment(string&& text)
            {
                return new term(termtype::comment, move(text));
            }

            static term* option(ast::term* term)
            {
                return new ast::term(termtype::group, term, 0, 1);
            }

            static term* group(ast::term* term)
            {
                return new ast::term(termtype::group, term, 1, 1);
            }

            static term* kleene(ast::term* term)
            {
                return new ast::term(termtype::group, term, 0, 0);
            }

            void push_back(term* term)
            {
                assert(type == termtype::alt || type == termtype::seq);

                terms.push_back(term);
            }

        private:
            term(termtype type, string&& text) : type(type), text(text)
            {
                assert(type == termtype::token || type == termtype::literal || type == termtype::iliteral || type == termtype::comment);
            }

            term(termtype type) : type(type)
            {
                assert(type == termtype::empty || type == termtype::alt || type == termtype::seq);
            }

            term(termtype type, term* inner, int min, int max) : type(termtype::group), min(min), max(max)
            {
                assert(type == termtype::group);

                terms.push_back(inner);
            }

            termtype type;
            vector<term*> terms;
        public:
            int min = 1;
            int max = 1;
            const string text;
        };

        struct rule
        {
            rule(const string& name, term* term)
                : name(name), term(term)
            {
            }

            const std::string name;
            const term* const term;
        };

        struct grammar : std::vector<rule*>
        {
        };
    }
}
