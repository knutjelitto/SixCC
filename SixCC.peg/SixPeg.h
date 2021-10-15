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
            term(empty_term&& empty) : type(empty.type), u(move(empty))
            {}

            term(group_term&& group) : type(group.type), u(move(group))
            {}

            term(token_term&& token) : type(token.type), u(move(token))
            {}

            term(literal_term&& term) : type(term.type), u(move(term))
            {}

            term(iliteral_term&& term) : type(term.type), u(move(term))
            {}

            term(comment_term&& term) : type(term.type), u(move(term))
            {}

            term(prose_term&& term) : type(term.type), u(move(term))
            {}

            term(alt_term&& term) : type(term.type), u(move(term))
            {}

            term(seq_term&& term) : type(term.type), u(move(term))
            {}

        public:
            const termtype type;

            void loop(int min, int max)
            {
                u.core.min = min;
                u.core.max = max;
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
                        u.group.~group_term();
                        break;
                    case termtype::alt:
                        u.alt.~alt_term();
                        break;
                    case termtype::seq:
                        u.seq.~seq_term();
                        break;
                    case termtype::token:
                        u.token.~token_term();
                        break;
                    case termtype::literal:
                        u.literal.~literal_term();
                        break;
                    case termtype::iliteral:
                        u.iliteral.~iliteral_term();
                        break;
                    case termtype::comment:
                        u.comment.~comment_term();
                        break;
                    case termtype::prose:
                        u.prose.~prose_term();
                        break;
                }
            }

            union terms_union
            {
                terms_union(empty_term&& empty) : empty(empty)
                {}
                terms_union(group_term&& group) : group(group)
                {}
                terms_union(token_term&& token) : token(token)
                {}
                terms_union(literal_term&& literal) : literal(literal)
                {}
                terms_union(iliteral_term&& iliteral) : iliteral(iliteral)
                {}
                terms_union(comment_term&& comment) : comment(comment)
                {}
                terms_union(prose_term&& prose) : prose(prose)
                {}
                terms_union(alt_term&& alt) : alt(alt)
                {}
                terms_union(seq_term&& seq) : seq(seq)
                {}

                ~terms_union()
                {}

                core_term core;
                empty_term empty;
                group_term group;
                token_term token;
                literal_term literal;
                iliteral_term iliteral;
                comment_term comment;
                prose_term prose;
                alt_term alt;
                seq_term seq;
            } u;

            void accept(outvisitor& visitor);
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

            void accept(outvisitor& visitor);
        };

        class grammar
        {
        public:
            std::vector<rule*> rules;

            void accept(outvisitor& visitor);
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
                    term->accept(*this);
                }
            }

            virtual void visit(std::vector<rule*>& rules)
            {
                int count = 0;
                for (auto rule : rules)
                {
                    visit(*rule);

                    if (++count == 2)
                    {
                        break;
                    }
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
        };

        inline void term::accept(outvisitor& visitor)
        {
            switch (type)
            {
                case termtype::empty:
                    visitor.visit(u.empty);
                    break;
                case termtype::group:
                    visitor.visit(u.group);
                    u.group.term->accept(visitor);
                    break;
                case termtype::alt:
                    visitor.visit(u.alt);
                    break;
                case termtype::seq:
                    visitor.visit(u.seq);
                    break;
                case termtype::token:
                    visitor.visit(u.token);
                    break;
                case termtype::literal:
                    visitor.visit(u.literal);
                    break;
                case termtype::iliteral:
                    visitor.visit(u.iliteral);
                    break;
                case termtype::comment:
                    visitor.visit(u.comment);
                    break;
                case termtype::prose:
                    visitor.visit(u.prose);
                    break;
            }
        }

        inline void grammar::accept(outvisitor& visitor)
        {
            for (auto rule : rules)
            {
                rule->accept(visitor);
            }
        }

        inline void rule::accept(outvisitor& visitor)
        {
            term->accept(visitor);
        }

        namespace internal
        {
            grammar* simplify(grammar* grammar);
        }
    }

    IMEX ast::grammar* parse(std::string language, std::string name, std::string text);
    IMEX ast::grammar* parse(std::string language, std::string filename);
}
