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

void node::list_free()
{
    assert(type == NODE_SEQ || type == NODE_ALT || type == NODE_ALT_SKIPPABLE);

    list* curr = xxx_list;

    while (curr != nullptr)
    {
        list* next = curr->next;
        curr->next = nullptr;
        delete curr;
        curr = next;
    }

    xxx_list = nullptr;
}

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
            for (p = n->alt(); p != nullptr; p = p->next)
            {
                node_free(p->node);
            }
            n->list_free();
            break;

        case NODE_SEQ:
            for (p = n->seq(); p != nullptr; p = p->next)
            {
                node_free(p->node);
            }
            n->list_free();
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
    return new node(NODE_CI_LITERAL, invisible, literal);
}

struct node *node_create_cs_literal(int invisible, const text& literal)
{
    return new node(NODE_CS_LITERAL, invisible, literal);
}

struct node* node_create_name(int invisible, const text& name)
{
    return new node(NODE_RULE, invisible, name);
}


struct node* node_create_prose(int invisible, const text& prose)
{
    return new node(NODE_PROSE, invisible, prose);
}

struct node* node_create_alt(int invisible, struct list* alt)
{
    return new node(NODE_ALT, invisible, alt);
}

struct node* node_create_alt_skippable(int invisible, struct list* alt)
{
    return new node(NODE_ALT_SKIPPABLE, invisible, alt);
}

struct node* node_create_seq(int invisible, struct list* seq)
{
    return new node(NODE_SEQ, invisible, seq);
}

struct node* node_create_loop(int invisible, struct node* forward, struct node* backward)
{
    struct node* nuw = new node(NODE_LOOP, invisible);

    nuw->u.loop.forward = forward;
    nuw->u.loop.backward = backward;

    nuw->u.loop.min = 0;
    nuw->u.loop.max = 0;

    return nuw;
}

void node_make_seq(int invisible, struct node** node)
{
    assert(node != nullptr);

    if (*node != nullptr && (*node)->type == NODE_SEQ)
    {
        return;
    }

    struct list* nuw = nullptr;

    list_push_back(&nuw, *node);

    *node = node_create_seq(invisible, nuw);
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
            return a->literal().cieq(b->literal());

        case NODE_CS_LITERAL:
            return a->literal().eq(b->literal());

        case NODE_RULE:
            return a->name().eq(b->name());

        case NODE_PROSE:
            return a->prose().eq(b->prose());

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            return list_compare(a->alt(), b->alt());

        case NODE_SEQ:
            return list_compare(a->seq(), b->seq());

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

