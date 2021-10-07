/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <string.h>
//#include <strings.h>
#include <stdlib.h>

#include "../txt.h"

#include "list.h"
#include "node.h"

#include "../xalloc.h"

void node_free(node* n)
{
    struct list* p;

    if (n == nullptr)
    {
        return;
    }

    switch (n->type)
    {
        case NODE_CI_LITERAL:
        case NODE_CS_LITERAL:
            /* TODO: free (struct txt).p? */
            break;

        case NODE_RULE:
        case NODE_PROSE:
            break;

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            for (p = n->u.alt; p != nullptr; p = p->next)
            {
                node_free(p->node);
            }
            list_free(&n->u.alt);
            break;

        case NODE_SEQ:
            for (p = n->u.seq; p != nullptr; p = p->next)
            {
                node_free(p->node);
            }
            list_free(&n->u.seq);
            break;

        case NODE_LOOP:
            node_free(n->u.loop.forward);
            node_free(n->u.loop.backward);
            break;
    }

    delete n;
}

struct node *node_create_ci_literal(int invisible, const text& literal)
{
    struct node* nuw = new node();


    nuw->type = NODE_CI_LITERAL;
    nuw->invisible = invisible;
    nuw->u.literal = literal;

    return nuw;
}

struct node *node_create_cs_literal(int invisible, const text& literal)
{
    struct node *nuw = new node();

    nuw->type = NODE_CS_LITERAL;
    nuw->invisible = invisible;
    nuw->u.literal = literal;

    return nuw;
}

struct node* node_create_name(int invisible, const text& name)
{
    struct node* nuw = new node();

    nuw->type = NODE_RULE;
    nuw->invisible = invisible;
    nuw->u.name = name;

    return nuw;
}


struct node* node_create_prose(int invisible, const text& prose)
{
    struct node* nuw = new node();

    nuw->type = NODE_PROSE;
    nuw->invisible = invisible;
    nuw->u.prose = prose;

    return nuw;
}

struct node* node_create_alt(int invisible, struct list* alt)
{
    struct node* nuw = new node();

    nuw->type = NODE_ALT;
    nuw->invisible = invisible;
    nuw->u.alt = alt;

    return nuw;
}

struct node* node_create_alt_skippable(int invisible, struct list* alt)
{
    struct node* nuw = new node();

    nuw->type = NODE_ALT_SKIPPABLE;
    nuw->invisible = invisible;
    nuw->u.alt = alt;

    return nuw;
}

struct node* node_create_seq(int invisible, struct list* seq)
{
    struct node* nuw = new node();

    nuw->type = NODE_SEQ;
    nuw->invisible = invisible;
    nuw->u.seq = seq;

    return nuw;
}

struct node* node_create_loop(int invisible, struct node* forward, struct node* backward)
{
    struct node* nuw = new node();

    nuw->type = NODE_LOOP;
    nuw->invisible = invisible;

    nuw->u.loop.forward = forward;
    nuw->u.loop.backward = backward;

    nuw->u.loop.min = 0;
    nuw->u.loop.max = 0;

    return nuw;
}

void node_make_seq(int invisible, struct node** n)
{
    assert(n != nullptr);

    struct list* nuw;

    if (*n != nullptr && (*n)->type == NODE_SEQ)
    {
        return;
    }

    nuw = nullptr;

    list_push_front(&nuw, *n);

    *n = node_create_seq(invisible, nuw);
}

bool node_compare(const struct node* a, const struct node* b)
{
    if (a == nullptr && b == nullptr)
    {
        return true;
    }

    if (a == nullptr || b == nullptr)
    {
        return false;
    }

    if (a->type != b->type)
    {
        return false;
    }

    if (a->invisible != b->invisible)
    {
        return false;
    }

    switch (a->type)
    {
        case NODE_CI_LITERAL:
            return a->u.literal.cieq(b->u.literal);

        case NODE_CS_LITERAL:
            return a->u.literal.eq(b->u.literal);

        case NODE_RULE:
            return a->u.name.eq(b->u.name);

        case NODE_PROSE:
            return a->u.prose.eq(b->u.prose);

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            return list_compare(a->u.alt, b->u.alt);

        case NODE_SEQ:
            return list_compare(a->u.seq, b->u.seq);

        case NODE_LOOP:
            return node_compare(a->u.loop.forward, b->u.loop.forward)
                && node_compare(a->u.loop.backward, b->u.loop.backward);
    }

    return true;
}

void loop_flip(struct node* n)
{
    struct node* tmp;

    assert(n != nullptr);
    assert(n->type == NODE_LOOP);

    tmp = n->u.loop.backward;
    n->u.loop.backward = n->u.loop.forward;
    n->u.loop.forward = tmp;
}

