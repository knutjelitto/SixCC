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

#include <map>

#include <assert.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"

#include "io.h"

static std::map<void*, uint64_t> numbers;

#if true
static void* map(const void* ptr)
{
    return nullptr;
}
#else
static void* map(void* ptr)
{
    auto found = numbers.find(ptr);
    if (found != numbers.end())
    {
        return (void*)found->second;
    }

    uint64_t num = numbers.size();
    numbers.insert({ ptr, num });
    return (void*)num;
}
#endif

static void output_alt(const struct ast_rule *grammar, const struct ast_alt *alt);

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

    assert(writer != NULL);

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

static void output_group(const struct ast_rule* grammar, const struct ast_term* term, const struct ast_alt* group)
{
    const struct ast_alt* alt;

    for (alt = group; alt != NULL; alt = alt->next)
    {
        writer->printf("\t\"t%p\" -> \"a%p\";\n", map((void*)term), map((void*)alt));

        output_alt(grammar, alt);
    }
}

static void output_term(const struct ast_rule* grammar, const struct ast_alt* alt, const struct ast_term* term)
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
            writer->escape(term->u.rule->name, escputc);
            break;

        case TYPE_CI_LITERAL:
        case TYPE_CS_LITERAL:
            writer->puts("&quot;");
            writer->escape(&term->u.literal, escputc);
            writer->puts("&quot;");
            if (term->type == TYPE_CI_LITERAL)
            {
                writer->puts("/i");
            }
            break;

        case TYPE_TOKEN:
            writer->escape(term->u.token, escputc);
            break;

        case TYPE_PROSE:
            writer->puts("?");
            writer->escape(term->u.prose, escputc);
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
            output_group(grammar, term, term->u.group);
            break;
    }
}

static void output_alt(const struct ast_rule* grammar, const struct ast_alt* alt)
{
    const struct ast_term* term;

    writer->printf("\t\"a%p\" [ label = \"|\"", map((void*)alt));

    if (alt->invisible)
    {
        writer->printf(", color = blue ");
    }

    writer->printf("];\n");

    for (term = alt->terms; term != NULL; term = term->next)
    {
        output_term(grammar, alt, term);
    }
}

static void output_alts(const struct ast_rule* grammar, const struct ast_rule* rule, const struct ast_alt* alts)
{
    const struct ast_alt* alt;

    for (alt = alts; alt != NULL; alt = alt->next)
    {
        writer->printf("\t\"p%p\" -> \"a%p\";\n", map((void*)rule), map((void*)alt));

        output_alt(grammar, alt);
    }
}

static void output_rule(const struct ast_rule* grammar, const struct ast_rule* rule)
{
    writer->printf("\t\"p%p\" [ shape = record, label = \"=|%s\" ];\n", map((void*)rule), rule->name.chars());

    output_alts(grammar, rule, rule->alts);
}

WARN_UNUSED_RESULT int dot_output(const struct ast_rule* grammar)
{
    numbers.clear();

    const struct ast_rule* p;

    writer->printf("digraph G {\n");
    writer->printf("\tnode [ shape = box, style = rounded ];\n");
    writer->printf("\tedge [ dir = none ];\n");

    for (p = grammar; p != NULL; p = p->next)
    {
        output_rule(grammar, p);
    }

    writer->printf("}\n");
    return 1;
}

