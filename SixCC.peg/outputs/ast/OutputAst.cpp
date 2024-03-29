export module Outputs:Ast;

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

    struct astwriter : outvisitor
    {
        astwriter(sixpeg::indenter& indenter) : outvisitor(), writer(indenter)
        {
        }

        void write(grammar& grammar)
        {
            outvisitor::visit(grammar);
        }

        void visit(rule& rule) override
        {
            writer << rule.name << endl;
            ++writer;
            outvisitor::visit(*rule.term);
            --writer;
        }

        void visit(empty_term& term) override
        {
            writer << "-empty-" << endl;
        }

        void visit(group_term& term) override
        {
            if (term.min == 0 && term.max == 1)
            {
                writer << "optional" << endl;
            }
            else if (term.min == 0 && term.max == 0)
            {
                writer << "zero-or-more" << endl;
            }
            else if (term.min == 1 && term.max == 0)
            {
                writer << "one-or-more" << endl;
            }
            else if (term.min == 1 && term.max == 1)
            {
                writer << "group" << endl;
            }
            else
            {
                writer << "group(" << term.min << "," << term.max << ")" << endl;
            }
            ++writer;
            outvisitor::visit(*term.term);
            --writer;
        }

        void visit(seq_term& seq) override
        {
            writer << "seq" << endl;
            ++writer;
            outvisitor::visit_terms(seq.terms);
            --writer;
        }

        void visit(alt_term& alt) override
        {
            writer << "alt" << endl;
            ++writer;
            outvisitor::visit_terms(alt.terms);
            --writer;
        }

        void visit(token_term& term) override
        {
            writer << "token " << term.text << endl;
        }

        void visit(literal_term& term) override
        {
            writer << "literal \"" << term.text << "\"" << endl;
        }

        void visit(iliteral_term& term) override
        {
            writer << "iliteral \"" << term.text << "\"" << endl;
        }

        void visit(comment_term& term) override
        {
            writer << "comment " << term.text << endl;
        }

        void visit(prose_term& term) override
        {
            writer << "prose " << term.text << endl;
        }

        indenter writer;
    };

    export void ast_output(ast::grammar* grammar, indenter& indenter)
    {
        astwriter writer(indenter);

        writer.write(*grammar);
    }
}