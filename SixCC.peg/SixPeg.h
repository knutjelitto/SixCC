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

        enum class termtype
        {
            empty = 42,
            group,
            alt,
            seq,
            token,
            literal,
            iliteral,
            comment,
            prose,
        };

        class term;

        class outvisitor;

        class core_term
        {
        public:
            core_term(termtype type) : type(type)
            {
            }

            termtype type;
            int min = 1;
            int max = 1;
        };

        class empty_term final : public core_term 
        {
        public:
            empty_term() : core_term(termtype::empty)
            {}
        };

        class group_term final : public core_term
        {
        public:
            explicit group_term(term* term) : core_term(termtype::group), term(term)
            {
            }

            term* term;
        };

        class alt_term final : public core_term
        {
        public:
            alt_term(std::vector<term*> terms) : core_term(termtype::alt), terms(terms)
            {}
            alt_term() : core_term(termtype::alt), terms()
            {}

            ~alt_term();

            std::vector<term*> terms;
        };

        class seq_term final : public core_term
        {
        public:
            seq_term(std::vector<term*> terms) : core_term(termtype::seq), terms(terms)
            {}
            seq_term() : core_term(termtype::seq), terms()
            {}

            ~seq_term();

            std::vector<term*> terms;
        };

        class with_text_term : public core_term
        {
        public:
            with_text_term(termtype type, const std::string& text) : core_term(type), text(text)
            {
            }

            const std::string text;
        };

        class token_term final : public with_text_term
        {
        public:
            token_term(const std::string& text) : with_text_term(termtype::token, text)
            {
            }
        };

        class literal_term final : public with_text_term
        {
        public:
            literal_term(const std::string text) : with_text_term(termtype::literal, text)
            {
            }
        };

        class iliteral_term final : public with_text_term
        {
        public:
            iliteral_term(const std::string text) : with_text_term(termtype::iliteral, text)
            {
            }
        };

        class comment_term final : public with_text_term
        {
        public:
            comment_term(const std::string text) : with_text_term(termtype::comment, text)
            {}
        };

        class prose_term final : public with_text_term
        {
        public:
            prose_term(const std::string text) : with_text_term(termtype::prose, text)
            {}
        };

        class term final
        {
        private:
            term(empty_term&& empty) : type(empty.type), uempty(move(empty))
            {
            }
            term(group_term&& group) : type(group.type), ugroup(move(group))
            {
            }
            term(alt_term&& term) : type(term.type), ualt(move(term))
            {
            }
            term(seq_term&& term) : type(term.type), useq(move(term))
            {
            }
            term(token_term&& token) : type(token.type), utoken(move(token))
            {
            }
            term(literal_term&& term) : type(term.type), uliteral(move(term))
            {
            }
            term(iliteral_term&& term) : type(term.type), uiliteral(move(term))
            {
            }
            term(comment_term&& term) : type(term.type), ucomment(move(term))
            {
            }
            term(prose_term&& term) : type(term.type), uprose(move(term))
            {
            }

        public:
            const termtype type;

            void loop(int min, int max)
            {
                core.min = min;
                core.max = max;
            }

            static term* empty()
            {
                return new term(empty_term());
            }

            static term* group(term* t)
            {
                return new term(group_term(t));
            }

            static term* alt()
            {
                return new term(alt_term());
            }

            static term* seq()
            {
                return new term(seq_term());
            }

            static term* option(ast::term* term)
            {
                auto x = group(term);
                x->loop(0, 1);
                return x;
            }

            static term* kleene(ast::term* term)
            {
                auto x = group(term);
                x->loop(0, 0);
                return x;
            }

            static term* token(const std::string& text)
            {
                return new ast::term(token_term(text));
            }

            static term* literal(const std::string& text)
            {
                return new ast::term(literal_term(text));
            }

            static term* iliteral(const std::string& text)
            {
                return new ast::term(iliteral_term(text));
            }

            static term* comment(const std::string& text)
            {
                return new ast::term(comment_term(text));
            }

            static term* prose(const std::string& text)
            {
                return new ast::term(prose_term(text));
            }

            ~term()
            {
                switch (type)
                {
                    case termtype::empty:
                        break;
                    case termtype::group:
                        ugroup.~group_term();
                        break;
                    case termtype::alt:
                        ualt.~alt_term();
                        break;
                    case termtype::seq:
                        useq.~seq_term();
                        break;
                    case termtype::token:
                        utoken.~token_term();
                        break;
                    case termtype::literal:
                        uliteral.~literal_term();
                        break;
                    case termtype::iliteral:
                        uiliteral.~iliteral_term();
                        break;
                    case termtype::comment:
                        ucomment.~comment_term();
                        break;
                    case termtype::prose:
                        uprose.~prose_term();
                        break;
                }
            }

            union
            {
                core_term core;
                empty_term uempty;
                group_term ugroup;
                token_term utoken;
                literal_term uliteral;
                iliteral_term uiliteral;
                comment_term ucomment;
                prose_term uprose;
                alt_term ualt;
                seq_term useq;
            };
        };

        inline alt_term::~alt_term()
        {
            for (auto term : terms)
            {
                delete term;
            }
        }

        inline seq_term::~seq_term()
        {
            for (auto term : terms)
            {
                delete term;
            }
        }

        class rule
        {
        public:
            rule(const string& name, term* term)
                : name(name), term(term)
            {
            }

            const std::string name;
            term* term;
        };

        class grammar
        {
        public:
            std::vector<rule*> rules;
        };
    

        class outvisitor
        {
        public:
            virtual void visit()
            {
            }

            virtual void visit(std::vector<term*>& terms)
            {
                for (auto term : terms)
                {
                    visit(*term);
                }
            }

            virtual void visit(std::vector<rule*>& rules)
            {
                for (auto rule : rules)
                {
                    visit(*rule);
                }
            }

            virtual void visit(grammar& grammar)
            {
                visit(grammar.rules);
            }

            virtual void visit(rule& rule)
            {
                visit();
            }
            virtual void visit(empty_term& term)
            {
                visit();
            }
            virtual void visit(group_term& term)
            {
                visit();
            }
            virtual void visit(alt_term& term)
            {
                visit();
            }
            virtual void visit(seq_term& term)
            {
                visit();
            }
            virtual void visit(token_term& term)
            {
                visit();
            }
            virtual void visit(literal_term& term)
            {
                visit();
            }
            virtual void visit(iliteral_term& term)
            {
                visit();
            }
            virtual void visit(comment_term& term)
            {
                visit();
            }
            virtual void visit(prose_term& term)
            {
                visit();
            }
            virtual void visit(term& term)
            {
                switch (term.type)
                {
                    case termtype::empty:
                        visit(term.uempty);
                        break;
                    case termtype::group:
                        visit(term.ugroup);
                        break;
                    case termtype::alt:
                        visit(term.ualt);
                        break;
                    case termtype::seq:
                        visit(term.useq);
                        break;
                    case termtype::token:
                        visit(term.utoken);
                        break;
                    case termtype::literal:
                        visit(term.uliteral);
                        break;
                    case termtype::iliteral:
                        visit(term.uiliteral);
                        break;
                    case termtype::comment:
                        visit(term.ucomment);
                        break;
                    case termtype::prose:
                        visit(term.uprose);
                        break;
                }
            }
        };

        namespace internal
        {
            grammar* simplify(grammar* grammar);
        }
    }

    IMEX ast::grammar* parse(std::string language, std::string name, std::string text);
    IMEX ast::grammar* parse(std::string language, std::string filename);
}
