/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Graphviz Dot Diagram Output.
 *
 * TODO: fprintf(fout), instead of stdout
 */

#include <assert.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>

#include "../errors.h"
#include "../txt.h"
#include "../ast.h"

#include "io.h"

extern int fakeptr;

static const void* map(const void* ptr)
{
    if (fakeptr)
        return nullptr;
    return ptr;
}

static void output_alt(const ast_grammar& grammar, const struct ast_alt *alt);

static int escputc(int c, iwriter* writer)
{
    size_t i;

    const struct
    {
        int c;
        const char* s;
    } a[] = {
        { '&',  "&amp;"  },
        { '\"', "&quot;" },
        { '<',  "&#x3C;" },
        { '>',  "&#x3E;" }
    };

    assert(writer != nullptr);

    for (i = 0; i < sizeof(a)/sizeof(*a); i++)
    {
        if (a[i].c == c)
        {
            return writer->puts(a[i].s);
        }
    }

    if (!isprint((unsigned char)c))
    {
        return writer->printf("&#x%X;", (int)(unsigned char)c);
    }

    return writer->putc(c);
}

static void output_group(const ast_grammar& grammar, const struct ast_term* term, const ast_alts& group)
{
    for (auto alt : group)
    {
        writer->printf("\t\"t%p\" -> \"a%p\";\n", map((void*)term), map((void*)alt));

        output_alt(grammar, alt);
    }
}

static void output_term(const ast_grammar& grammar, const struct ast_alt* alt, const struct ast_term* term)
{
    assert(term->max >= term->min || !term->max);

    writer->printf("\t\"a%p\" -> \"t%p\"", map((void*)alt), map((void*)term));
    if (term->invisible)
    {
        writer->printf(" [ color = blue, style = dashed ]");
    }
    writer->printf(";\n");

    writer->printf("\t\"t%p\" [ shape = record, ", map((void*)term));

    if (term->invisible)
    {
        writer->printf("color = blue, fontcolor = blue, style = \"rounded,dashed\", ");
    }

    writer->printf("label = \"");

    if (term->min == 1 && term->max == 1)
    {
        /* nothing */
    }
    else if (!term->max)
    {
        writer->printf("\\{%u,""\\}&times;|", term->min);
    }
    else if (term->min == term->max)
    {
        writer->printf("%u&times;|", term->min);
    }
    else
    {
        writer->printf("\\{%u,%u\\}&times;|", term->min, term->max);
    }

    switch (term->type)
    {
        case TYPE_EMPTY:
            writer->puts("&#x3B5;");
            break;

        case TYPE_RULE:
            writer->escape(term->rule()->name, escputc);
            break;

        case TYPE_CI_LITERAL:
        case TYPE_CS_LITERAL:
            writer->puts("&quot;");
            writer->escape(term->text(), escputc);
            writer->puts("&quot;");
            if (term->type == TYPE_CI_LITERAL)
            {
                writer->puts("/i");
            }
            break;

        case TYPE_TOKEN:
            writer->escape(term->text(), escputc);
            break;

        case TYPE_PROSE:
            writer->puts("?");
            writer->escape(term->text(), escputc);
            writer->puts("?");
            break;

        case TYPE_GROUP:
            writer->printf("()");
            break;
    }

    writer->printf("\" ];\n");

    switch (term->type)
    {
        case TYPE_EMPTY:
            break;

        case TYPE_RULE:
            /* XXX: cross-links to rules are confusing
                    writer->printf("\t\"t%p\" -> \"p%p\" [ dir = forward, color = blue, weight = 0 ];\n",
                        (void *) term, term->u.rule);
            */
            break;

        case TYPE_CI_LITERAL:
        case TYPE_CS_LITERAL:
        case TYPE_TOKEN:
        case TYPE_PROSE:
            writer->printf("\t\"t%p\" [ style = filled",
                map((void*)term));

            if (term->invisible)
            {
                writer->printf(", color = blue, fillcolor = aliceblue, style = \"dashed,filled\" ");
            }

            writer->printf("];\n");
            break;

        case TYPE_GROUP:
            output_group(grammar, term, term->group());
            break;
    }
}

static void output_alt(const ast_grammar& grammar, const struct ast_alt* alt)
{
    writer->printf("\t\"a%p\" [ label = \"|\"", map((void*)alt));

    if (alt->invisible)
    {
        writer->printf(", color = blue ");
    }

    writer->printf("];\n");

    for (auto term : alt->terms)
    {
        output_term(grammar, alt, term);
    }
}

static void output_alts(const ast_grammar& grammar, const struct ast_rule* rule, const ast_alts& alts)
{
    const struct ast_alt* alt;

    for (auto alt : alts)
    {
        writer->printf("\t\"p%p\" -> \"a%p\";\n", map((void*)rule), map((void*)alt));

        output_alt(grammar, alt);
    }
}

static void output_rule(const ast_grammar& grammar, const struct ast_rule* rule)
{
    writer->printf("\t\"p%p\" [ shape = record, label = \"=|%s\" ];\n", map((void*)rule), rule->name.chars());

    output_alts(grammar, rule, rule->alts);
}

WARN_UNUSED_RESULT int dot_output(const ast_grammar& grammar)
{
    writer->printf("digraph G {\n");
    writer->printf("\tnode [ shape = box, style = rounded ];\n");
    writer->printf("\tedge [ dir = none ];\n");

    for (auto rule : grammar.rules)
    {
        output_rule(grammar, rule);
    }

    writer->printf("}\n");
    return 1;
}
