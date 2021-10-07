/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Abstract Railroad Diagram tree dump to Graphivz dot
 */

#include <map>

#include <assert.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../compiler_specific.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/list.h"

#include "io.h"

static std::map<const void*, uint64_t> numbers;

#if true
static void* map(const void* ptr)
{
    return nullptr;
}
#else
static void* map(const void* ptr)
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

static int escputc(int c, iwriter* writer)
{
    assert(writer != nullptr);

    const struct
    {
        int c;
        const char* s;
    } a[] = {
        { '\\', "\\\\"   },
        { '&',  "&amp;"  },
        { '\"', "&quot;" },
        { '<',  "&#x3C;" },
        { '>',  "&#x3E;" }
    };

    for (int i = 0; i < sizeof(a) / sizeof(*a); i++)
    {
        if (a[i].c == c)
        {
            return writer->puts(a[i].s);
        }
    }

    if (!isprint((unsigned char)c))
    {
        return writer->printf("&#x%X;", (unsigned char)c);
    }

    return writer->putc(c);
}

static void rrd_print_dot(const text& prefix, const void* parent, const char* port, const struct node* node)
{
    if (node == NULL)
    {
        return;
    }

    switch (node->type)
    {
        const struct list* p;

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            writer->printf("\t{ rank = same;\n");
            for (p = node->u.alt; p != NULL; p = p->next)
            {
                writer->printf("\t\t\"%s/%p\";\n", prefix.chars(), map((void*)p->node));
            }
            writer->printf("\t};\n");
            break;

        case NODE_SEQ:
            writer->printf("\t{ rank = same;\n");
            for (p = node->u.seq; p != NULL; p = p->next)
            {
                writer->printf("\t\t\"%s/%p\";\n", prefix.chars(), map((void*)p->node));
            }
            writer->printf("\t};\n");
            break;

        default:
            break;
    }

    writer->printf("\t\"%s/%p\"%s -> \"%s/%p\"", prefix.chars(), map(parent), port, prefix.chars(), map((void*)node));
    if (node->invisible)
    {
        writer->printf(" [ color = blue, style = dashed ]");
    }
    writer->printf(";\n");

    writer->printf("\t\"%s/%p\" [ ", prefix.chars(), map((void*)node));
    if (node->invisible)
    {
        writer->printf("color = blue, fontcolor = blue, fillcolor = aliceblue, style = \"rounded,dashed\", ");
    }

    switch (node->type)
    {
        case NODE_CI_LITERAL:
            writer->printf("style = \"%s\", shape = box, label = \"\\\"", node->invisible ? "filled,dashed" : "filled");
            writer->escape(node->u.literal, escputc);
            writer->printf("\\\"\"/i");
            break;

        case NODE_CS_LITERAL:
            writer->printf("style = \"%s\", shape = box, label = \"\\\"", node->invisible ? "filled,dashed" : "filled");
            writer->escape(node->u.literal, escputc);
            writer->printf("\\\"\"");
            break;

        case NODE_RULE:
            writer->printf("label = \"\\<");
                writer->escape(node->u.name, escputc);
            writer->printf("\\>\"");
            break;

        case NODE_PROSE:
            /* TODO: escaping to somehow avoid ? */
            writer->printf("label = \"?");
            writer->escape(node->u.prose, escputc);
            writer->printf("?\"");
            break;

        case NODE_ALT:
            writer->printf("label = \"ALT\"");
            break;

        case NODE_ALT_SKIPPABLE:
            writer->printf("label = \"ALT|&epsilon;\"");
            break;

        case NODE_SEQ:
            writer->printf("label = \"SEQ\"");
            break;

        case NODE_LOOP:
            writer->printf("label = \"<b> &larr;|LOOP "); /* TODO: utf8 */

            if (node->u.loop.min == 1 && node->u.loop.max == 1)
            {
                /* nothing */
            }
            else if (!node->u.loop.max)
            {
                writer->printf("\\{%u,""\\}&times;", node->u.loop.min);
            }
            else if (node->u.loop.min == node->u.loop.max)
            {
                writer->printf("%u&times;", node->u.loop.min);
            }
            else
            {
                writer->printf("\\{%u,%u\\}&times;", node->u.loop.min, node->u.loop.max);
            }

            writer->printf("|<f> &rarr;\"");
            break;

        default:
            writer->printf("label = \"?\", color = red");
    }

    writer->printf(" ];\n");

    switch (node->type)
    {
        const struct list* p;

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            for (p = node->u.alt; p != NULL; p = p->next)
            {
                rrd_print_dot(prefix, node, "", p->node);
            }
            break;

        case NODE_SEQ:
            for (p = node->u.seq; p != NULL; p = p->next)
            {
                rrd_print_dot(prefix, node, "", p->node);
            }
            break;

        case NODE_LOOP:
            rrd_print_dot(prefix, node, ":f", node->u.loop.forward);
            rrd_print_dot(prefix, node, ":b", node->u.loop.backward);
            break;

        default:
            break;
    }
}

WARN_UNUSED_RESULT int rrdot_output(const struct ast_rule* grammar)
{
    numbers.clear();

    const struct ast_rule* p;

    writer->printf("digraph G {\n");
    writer->printf("\tnode [ shape = record, style = rounded ];\n");
    writer->printf("\tedge [ dir = none ];\n");

    for (p = grammar; p != NULL; p = p->next)
    {
        struct node* rrd;

        if (!ast_to_rrd(p, &rrd))
        {
            perror("ast_to_rrd");
            return 0;
        }

        if (prettify)
        {
            rrd_pretty(&rrd);
        }

        writer->printf("\t\"%s/%p\" [ shape = plaintext, label = \"%s\" ];\n", p->name().chars(), map((void*)p), p->name().chars());

        rrd_print_dot(p->name(), p, "", rrd);

        node_free(rrd);
    }

    writer->printf("}\n");
    writer->printf("\n");
    return 1;
}

