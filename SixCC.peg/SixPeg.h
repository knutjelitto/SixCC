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

            virtual void accept(outvisitor& visitor)
            {}
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
            group_term(term* term) : core_term(termtype::group), term(term)
            {
            }

            const term* term;
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

        class token_term final : public core_term
        {
        public:
            token_term(const std::string& text) : core_term(termtype::token), text(text)
            {}

            const std::string text;
        };

        class literal_term final : public core_term
        {
        public:
            literal_term(const std::string text) : core_term(termtype::literal), text(text)
            {}

            const std::string text;
        };

        class iliteral_term final : public core_term
        {
        public:
            iliteral_term(const std::string text) : core_term(termtype::iliteral), text(text)
            {}

            const std::string text;
        };

        class comment_term final : public core_term
        {
        public:
            comment_term(const std::string text) : core_term(termtype::comment), text(text)
            {}

            const std::string text;
        };

        class prose_term final : public core_term
        {
        public:
            prose_term(const std::string text) : core_term(termtype::prose), text(text)
            {}

            const std::string text;
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
                u.core.max = min;
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

            union
            {
                empty_term empty1;
            };

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

            void accept(outvisitor& visitor, int level, bool first) const;
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

            void accept(outvisitor& visitor, int level, bool first) const;
        };

        class grammar
        {
        public:
            std::vector<rule*> rules;

            void accept(outvisitor& visitor) const;
        };
    

        class outvisitor
        {
        public:
            virtual void enter()
            {
            }
            virtual void leave()
            {
            }
            virtual void visit()
            {
            }

            virtual void enter(const grammar& grammar, int level, bool first)
            {
                enter();
            }
            virtual void leave(const grammar& grammar, int level, bool first)
            {
                leave();
            }
            virtual void visit(const grammar& grammar, int level, bool first)
            {
                visit();
            }

            virtual void enter(const rule& rule, int level, bool first)
            {
                enter();
            }
            virtual void leave(const rule& rule, int level, bool first)
            {
                leave();
            }
            virtual void visit(const rule& rule, int level, bool first)
            {
                visit();
            }

            virtual void enter(const empty_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const empty_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const empty_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const group_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const group_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const group_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const alt_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const alt_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const alt_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const seq_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const seq_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const seq_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const token_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const token_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const token_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const literal_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const literal_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const literal_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const iliteral_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const iliteral_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const iliteral_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const comment_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const comment_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const comment_term& term, int level, bool first)
            {
                visit();
            }

            virtual void enter(const prose_term& term, int level, bool first)
            {
                enter();
            }
            virtual void leave(const prose_term& term, int level, bool first)
            {
                leave();
            }
            virtual void visit(const prose_term& term, int level, bool first)
            {
                visit();
            }
        };

        inline void term::accept(outvisitor& visitor, int level, bool first) const
        {
            switch (type)
            {
                case termtype::empty:
                    visitor.enter(u.empty, level, first);
                    visitor.visit(u.empty, level, first);
                    visitor.leave(u.empty, level, first);
                    break;
                case termtype::group:
                    visitor.enter(u.group, level, first);
                    visitor.visit(u.group, level, first);
                    u.group.term->accept(visitor, level + 1, true);
                    visitor.leave(u.group, level, first);
                    break;
                case termtype::alt:
                {
                    visitor.enter(u.alt, level, first);
                    visitor.visit(u.alt, level, first);
                    bool afirst = true;
                    for (auto term : u.alt.terms)
                    {
                        term->accept(visitor, level + 1, afirst);
                        afirst = false;
                    }
                    visitor.leave(u.alt, level, first);
                    break;
                }
                case termtype::seq:
                {
                    visitor.enter(u.seq, level, first);
                    visitor.visit(u.seq, level, first);
                    bool sfirst = true;
                    for (auto term : u.seq.terms)
                    {
                        term->accept(visitor, level + 1, sfirst);
                        sfirst = false;
                    }
                    visitor.leave(u.seq, level, first);
                    break;
                }
                case termtype::token:
                    visitor.enter(u.token, level, first);
                    visitor.visit(u.token, level, first);
                    visitor.leave(u.token, level, first);
                    break;
                case termtype::literal:
                    visitor.enter(u.literal, level, first);
                    visitor.visit(u.literal, level, first);
                    visitor.leave(u.literal, level, first);
                    break;
                case termtype::iliteral:
                    visitor.enter(u.iliteral, level, first);
                    visitor.visit(u.iliteral, level, first);
                    visitor.leave(u.iliteral, level, first);
                    break;
                case termtype::comment:
                    visitor.enter(u.comment, level, first);
                    visitor.visit(u.comment, level, first);
                    visitor.leave(u.comment, level, first);
                    break;
                case termtype::prose:
                    visitor.enter(u.prose, level, first);
                    visitor.visit(u.prose, level, first);
                    visitor.leave(u.prose, level, first);
                    break;
            }
        }

        inline void grammar::accept(outvisitor& visitor) const
        {
            visitor.enter(*this, 0, true);
            visitor.visit(*this, 0, true);
            bool first = true;
            for (auto rule : rules)
            {
                rule->accept(visitor, 0, first);
                first = false;
            }
            visitor.leave(*this, 0, true);
        }

        inline void rule::accept(outvisitor& visitor, int level, bool first) const
        {
            visitor.enter(*this, level, first);
            visitor.visit(*this, level, first);
            term->accept(visitor, level + 1, first);
            visitor.leave(*this, level, first);
        }

        namespace internal
        {
            grammar* simplify(grammar* grammar);
        }
    }

    IMEX ast::grammar* parse(std::string language, std::string name, std::string text);
    IMEX ast::grammar* parse(std::string language, std::string filename);
}
