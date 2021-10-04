/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Extended Backus-Naur Form Output, pretty-printed to HTML.
 *
 * This is my own made-up dialect. It's intended for ease
 * of human consumption (i.e. in documentation), rather than
 * to be parsed by machine.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../rrd/node.h"

#include "io.h"

extern const char *css_file;

static void output_alt(const struct ast_alt *alt);

static int xml_escputc(int c)
{
    const char* name;

    switch (c)
    {
        case '&': return writer->puts("&amp;");
        case '<': return writer->puts("&lt;");
        case '>': return writer->puts("&gt;");

        case '\a': name = "BEL"; break;
        case '\b': name = "BS";  break;
        case '\f': name = "FF";  break;
        case '\n': name = "LF";  break;
        case '\r': name = "CR";  break;
        case '\t': name = "TAB"; break;
        case '\v': name = "VT";  break;

        default:
            if (!isprint((unsigned char)c))
            {
                return writer->printf("&#x3008;<tspan class='hex'>%02X</tspan>&#x3009;", (unsigned char)c);
            }

            return writer->printf("%c", c);
    }

    return writer->printf("&#x3008;<tspan class='esc'>%s</tspan>&#x3009;", name);
}

static int atomic(const struct ast_term* term)
{
    assert(term != NULL);

    switch (term->type)
    {
        case TYPE_EMPTY:
        case TYPE_RULE:
        case TYPE_CI_LITERAL:
        case TYPE_CS_LITERAL:
        case TYPE_TOKEN:
        case TYPE_PROSE:
            return 1;

        case TYPE_GROUP:
            if (term->u.group->next != NULL)
            {
                return 0;
            }

            if (term->u.group->terms->next != NULL)
            {
                return 0;
            }

            return atomic(term->u.group->terms);
    }

    assert(!"unreached");
}

static const char * rep(unsigned min, unsigned max)
{
    if (min == 1 && max == 1)
    {
        /* no operator */
        return "\0";
    }

    if (min == 1 && max == 1)
    {
        return "()";
    }

    if (min == 0 && max == 1)
    {
        return "[]";
    }

    if (min == 0 && max == 0)
    {
        return "{}";
    }

    return "()";
}

static void output_literal(const char* prefix, const struct txt* t)
{
    size_t i;

    assert(t != NULL);
    assert(t->p != NULL);

    writer->printf("<tt class='literal %s'>&quot;", prefix);

    for (i = 0; i < t->n; i++)
    {
        xml_escputc(t->p[i]);
    }

    writer->printf("&quot;</tt>");
}

static void output_term(const struct ast_term* term)
{
    const char* r;

    assert(term != NULL);
    assert(!term->invisible);

    r = rep(term->min, term->max);

    if (!r[0] && !atomic(term))
    {
        r = "()";
    }

    if (r[0])
    {
        writer->printf("<span class='rep'>%c</span> ", r[0]);
    }

    /* TODO: escaping */

    switch (term->type)
    {
        case TYPE_EMPTY:
            writer->printf("<span class='empty'>&epsilon;</span>");
            break;

        case TYPE_RULE:
            writer->printf("<a href='#%s' class='rule' data-min='%u' data-max='%u'>", term->u.rule->name, term->min, term->max);
            writer->printf("%s", term->u.rule->name);
            writer->printf("</a>");
            break;

        case TYPE_CI_LITERAL:
            output_literal("ci", &term->u.literal);
            break;

        case TYPE_CS_LITERAL:
            output_literal("cs", &term->u.literal);
            break;

        case TYPE_TOKEN:
            writer->printf("<span class='token'>");
            writer->printf("%s", term->u.token);
            writer->printf("</span>");
            break;

        case TYPE_PROSE:
            writer->printf("<span class='prose'>");
            writer->printf("%s", term->u.prose);
            writer->printf("</span>");
            break;

        case TYPE_GROUP:
        {
            const struct ast_alt* alt;

            for (alt = term->u.group; alt != NULL; alt = alt->next)
            {
                output_alt(alt);

                if (alt->next != NULL)
                {
                    writer->printf("<span class='pipe'> | </span>");
                }
            }
        }

        break;
    }

    if (r[0])
    {
        writer->printf(" <span class='rep'>%c</span>", r[1]);
    }

    if (term->max > 1)
    {
        writer->printf("<sub class='rep'>{%u, %u}</sub>", term->min, term->max);
    }
}

static void output_alt(const struct ast_alt* alt)
{
    const struct ast_term* term;

    assert(alt != NULL);
    assert(!alt->invisible);

    for (term = alt->terms; term != NULL; term = term->next)
    {
        writer->printf("<span class='alt'>");
        output_term(term);
        writer->printf("</span>\n");

        if (term->next != NULL)
        {
            writer->printf("<span class='cat'> </span>");
        }
    }
}

static void output_rule(const struct ast_rule* rule)
{
    const struct ast_alt* alt;

    writer->printf("  <dl class='bnf'>\n");

    writer->printf("    <dt>");
    writer->printf("<a name='%s'>", rule->name);
    writer->printf("%s", rule->name);
    writer->printf("</a>:");
    writer->printf("</dt>\n");

    writer->printf("    <dd>");

    for (alt = rule->alts; alt != NULL; alt = alt->next)
    {
        if (alt != rule->alts)
        {
            writer->printf("<span class='pipe'> | </span>");
        }

        writer->printf("\n");
        writer->printf("      ");
        output_alt(alt);

        if (alt->next != NULL)
        {
            writer->printf("<br/>\n");
            writer->printf("      ");
        }
    }

    writer->printf("    </dd>\n");

    writer->printf("  </dl>\n");
    writer->printf("\n");
}

WARN_UNUSED_RESULT static int output(const struct ast_rule* grammar, int xml)
{
    const struct ast_rule* p;

    writer->printf(" <head>\n");
    if (xml)
    {
        writer->printf("  <meta charset='UTF-8'/>\n");
    }

    writer->printf("  <style>\n");

    writer->printf("    dl.bnf span.token {\n");
    writer->printf("    	text-transform: uppercase;\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    dl.bnf span.cat {\n");
    writer->printf("    	margin-right: 0.5ex;\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    dl.bnf dd > span.pipe {\n");
    writer->printf("    	float: left;\n");
    writer->printf("    	width: 1ex;\n");
    writer->printf("    	margin-left: -1.8ex;\n");
    writer->printf("    	text-align: right;\n");
    writer->printf("    	padding-right: .8ex; /* about the width of a space */\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    dl.bnf dt {\n");
    writer->printf("    	display: block;\n");
    writer->printf("    	min-width: 8em;\n");
    writer->printf("    	padding-right: 1em;\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    dl.bnf a.rule {\n");
    writer->printf("    	text-decoration: none;\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    dl.bnf a.rule:hover {\n");
    writer->printf("    	text-decoration: underline;\n");
    writer->printf("    }\n");
    writer->printf("    \n");
    writer->printf("    /* page stuff */\n");
    writer->printf("    dl.bnf { margin: 2em 4em; }\n");
    writer->printf("    dl.bnf dt { margin: 0.25em 0; }\n");
    writer->printf("    dl.bnf dd { margin-left: 2em; }\n");

    if (css_file != NULL)
    {
        if (!cat(css_file, "    "))
        {
            return 0;
        }
    }

    writer->printf("  </style>\n");
    writer->printf(" </head>\n");
    writer->printf(" <body>\n");

    for (p = grammar; p != NULL; p = p->next)
    {
        output_rule(p);
    }

    writer->printf(" </body>\n");
    return 1;
}

WARN_UNUSED_RESULT
int
ebnf_html5_output(const struct ast_rule *grammar)
{
    writer->printf("<!DOCTYPE html>\n");
    writer->printf("<html>\n");
    writer->printf("\n");

    if (!output(grammar, 0)) {
        return 0;
    }

    writer->printf("</html>\n");
    return 1;
}

WARN_UNUSED_RESULT int ebnf_xhtml5_output(const struct ast_rule* grammar)
{
    writer->printf("<?xml version='1.0' encoding='utf-8'?>\n");
    writer->printf("<!DOCTYPE html>\n");
    writer->printf("<html xml:lang='en' lang='en'\n");
    writer->printf("  xmlns='http://www.w3.org/1999/xhtml'\n");
    writer->printf("  xmlns:xlink='http://www.w3.org/1999/xlink'>\n");
    writer->printf("\n");

    if (!output(grammar, 1))
    {
        return 0;
    }

    writer->printf("</html>\n");
    return 1;
}

