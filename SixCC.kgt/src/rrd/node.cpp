/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <string.h>
#include <stdlib.h>

#include "../txt.h"

#include "list.h"
#include "node.h"

#include "../xalloc.h"

int node::ctor_count = 0;
int node::dtor_count = 0;

node::node(node_type type, node* forward, node* backward)
    : type(type)
{
    assert(type == NODE_LOOP);

    loop.forward = forward;
    loop.backward = backward;
    loop.min = 0;
    loop.max = 0;

    ctor_count++;
}

node::node(node_type type, const text& text)
    : type(type), xxx_text(text)
{
    ctor_count++;
}

node::node(node_type type, struct list* list)
    : type(type), xxx_list(list)
{
    ctor_count++;
}

node::~node()
{
    dtor_count++;
}

void node::list_free()
{
    assert(is_list());

    list().clear();
}

void node::become_alt_skippable()
{
    assert(type == NODE_ALT);
    type = NODE_ALT_SKIPPABLE;
}

void node_free(node* n)
{
    if (n == nullptr)
    {
        return;
    }

    switch (n->type)
    {
        case NODE_LITERAL:
            /* TODO: free (struct txt).p? */
            break;

        case NODE_RULE:
        case NODE_PROSE:
            break;

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            for (auto node : n->alt())
            {
                node_free(node);
            }
            n->list_free();
            break;

        case NODE_SEQ:
            for (auto node : n->seq())
            {
                node_free(node);
            }
            n->list_free();
            break;

        case NODE_LOOP:
            node_free(n->loop.forward);
            node_free(n->loop.backward);
            break;
    }

    delete n;
}

node *node_create_literal(const text& literal)
{
    return new node(NODE_LITERAL, literal);
}

node* node_create_name(const text& name)
{
    return new node(NODE_RULE, name);
}

node* node_create_prose(const text& prose)
{
    return new node(NODE_PROSE, prose);
}

node* node_create_alt(list* alt)
{
    return new node(NODE_ALT, alt);
}

node* node_create_alt_skippable(list* alt)
{
    return new node(NODE_ALT_SKIPPABLE, alt);
}

node* node_create_seq(list* seq)
{
    return new node(NODE_SEQ, seq);
}

node* node_create_loop(node* forward, node* backward)
{
    return new node(NODE_LOOP, forward, backward);
}

void node_make_seq(node** node)
{
    assert(node != nullptr);

    if (*node != nullptr && (*node)->type == NODE_SEQ)
    {
        return;
    }

    list* nuw = new list();
    nuw->push_back(*node);

    *node = node_create_seq(nuw);
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

    switch (a->type)
    {
        case NODE_LITERAL:
            return a->literal().eq(b->literal());

        case NODE_RULE:
            return a->name().eq(b->name());

        case NODE_PROSE:
            return a->prose().eq(b->prose());

        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
            return a->alt().eq(b->alt());

        case NODE_SEQ:
            return a->seq().eq(b->seq());

        case NODE_LOOP:
            return node_compare(a->loop.forward, b->loop.forward)
                && node_compare(a->loop.backward, b->loop.backward);
    }

    return true;
}

void loop_flip(struct node* n)
{
    struct node* tmp;

    assert(n != nullptr);
    assert(n->type == NODE_LOOP);

    tmp = n->loop.backward;
    n->loop.backward = n->loop.forward;
    n->loop.forward = tmp;
}

