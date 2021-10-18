export module Outputs:Wsn;

import <stdexcept>;
import <iostream>;
import <string>;

import Ast;
import Visitor;
import Indenter;

namespace sixpeg::output
{
    using namespace std;
    using namespace ast;

    struct wsnwriter : outvisitor
    {
        wsnwriter(indenter& indenter) : outvisitor(), writer(indenter)
        {
        }

        void write(grammar& grammar)
        {
            int max_lenght = 0;

            for (auto rule : grammar.rules)
            {
                if (rule->name.size() > max_lenght)
                {
                    max_lenght = (int)rule->name.size();
                }
            }

            name_width = max_lenght;

            outvisitor::visit(grammar);
        }

        void visit(rule& rule) override
        {
            writer << rule.name;
            writer << string(name_width - rule.name.size(), ' ');
            writer << " =";
            if (rule.term->type == termtype::alt)
            {
                bool more = false;
                for (auto term : rule.term->ualt.terms)
                {
                    if (more)
                    {
                        writer << endl;
                        writer << string(name_width, ' ');
                        writer << " |";
                    }
                    more = true;
                    outvisitor::visit(*term);
                }
            }
            else
            {
                outvisitor::visit(*rule.term);
            }
            writer << " ." << endl;
        }

        void visit(group_term& term) override
        {
            if (term.min == 1 && term.max == 1)
            {
                writer << " (";
            }
            else if (term.min == 0 && term.max == 1)
            {
                writer << " [";
            }
            else if (term.min == 0 && term.max == 0)
            {
                writer << " {";
            }
            else
            {
                throw std::logic_error("internal error: group not implemented");
            }

            outvisitor::visit(*term.term);

            if (term.min == 1 && term.max == 1)
            {
                writer << " )";
            }
            else if (term.min == 0 && term.max == 1)
            {
                writer << " ]";
            }
            else if (term.min == 0 && term.max == 0)
            {
                writer << " }";
            }
            else
            {
                throw std::logic_error("internal error: group not implemented");
            }

        }

        void visit(seq_term& term) override
        {
            for (auto term : term.terms)
            {
                outvisitor::visit(*term);
            }
        }

        void visit(alt_term& term) override
        {
            bool more = false;
            for (auto term : term.terms)
            {
                if (more)
                {
                    writer << " |";
                }
                more = true;
                outvisitor::visit(*term);
            }
        }

        void visit(token_term& term) override
        {
            writer << " " << term.text;
        }

        void visit(literal_term& term) override
        {
            writer << " \"" << term.text << "\"";
        }

        void visit(iliteral_term& term) override
        {
            unexpected();
        }

        void visit(comment_term& term) override
        {
            unexpected();
        }

        void visit(prose_term& term) override
        {
            unexpected();
        }

        void visit(empty_term& term) override
        {
            unexpected();
        }

        indenter writer;
        int name_width = -1;
        bool top = false;

    };

    export void wsn_output(ast::grammar* grammar, sixpeg::indenter& indenter)
    {
        wsnwriter writer(indenter);

        writer.write(*grammar);
    }
}