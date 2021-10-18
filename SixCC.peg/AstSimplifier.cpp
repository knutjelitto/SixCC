#pragma warning(disable: 5201)

module Ast;

namespace sixpeg
{
    namespace ast
    {
        static void simplify(term*& term);
        static void simplify(alt_term& alt, term*& term);
        static void simplify(seq_term& seq, term*& term);

        grammar* simplify(grammar* grammar)
        {
            for (auto rule : grammar->rules)
            {
                simplify(rule->term);
            }
            return grammar;
        }

        static void simplify(alt_term& alt, term*& term)
        {
            for (int i = 0; i < alt.terms.size(); i++)
            {
                simplify(alt.terms[i]);
            }

            if (alt.terms.size() == 1)
            {
                term = alt.terms[0];
            }
        }

        static void simplify(seq_term& seq, term*& term)
        {
            for (int i = 0; i < seq.terms.size(); i++)
            {
                simplify(seq.terms[i]);
            }

            if (seq.terms.size() == 1)
            {
                term = seq.terms[0];
            }
        }

        static void simplify(term*& term)
        {
            switch (term->type)
            {
                case termtype::seq:
                    simplify(term->useq, term);
                    break;
                case termtype::alt:
                    simplify(term->ualt, term);
                    break;
                case termtype::group:
                    simplify(term->ugroup.term);
                    break;
                default:
                    break;
            }
        }
    }
}
