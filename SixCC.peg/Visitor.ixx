export module Visitor;

import <stdexcept>;
import <vector>;

import Ast;

export namespace sixpeg::ast
{
    export class outvisitor
    {
    public:
        virtual void unexpected()
        {
            throw std::logic_error("internal error: unexpected term type");
        }

        virtual void visit_terms(std::vector<term*>& terms)
        {
            for (auto term : terms)
            {
                visit(*term);
            }
        }

        virtual void visit(grammar& grammar)
        {
            for (auto rule : grammar.rules)
            {
                visit(*rule);
            }
        }

        virtual void visit(rule& rule) = 0;
        virtual void visit(empty_term& term) = 0;
        virtual void visit(group_term& term) = 0;
        virtual void visit(alt_term& term) = 0;
        virtual void visit(seq_term& term) = 0;
        virtual void visit(token_term& term) = 0;
        virtual void visit(literal_term& term) = 0;
        virtual void visit(iliteral_term& term) = 0;
        virtual void visit(comment_term& term) = 0;
        virtual void visit(prose_term& term) = 0;

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
}