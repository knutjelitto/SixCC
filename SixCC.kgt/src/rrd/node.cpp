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

void
node_free(struct node *n)
{
    struct list *p;

    if (n == NULL) {
        return;
    }

    switch (n->type) {
    case NODE_CI_LITERAL:
    case NODE_CS_LITERAL:
        /* TODO: free (struct txt).p? */
        break;

    case NODE_RULE:
    case NODE_PROSE:
        break;

    case NODE_ALT:
    case NODE_ALT_SKIPPABLE:
        for (p = n->u.alt; p != NULL; p = p->next) {
            node_free(p->node);
        }
        list_free(&n->u.alt);
        break;

    case NODE_SEQ:
        for (p = n->u.seq; p != NULL; p = p->next) {
            node_free(p->node);
        }
        list_free(&n->u.seq);
        break;

    case NODE_LOOP:
        node_free(n->u.loop.forward);
        node_free(n->u.loop.backward);
        break;
    }

    free(n);
}

struct node *
node_create_ci_literal(int invisible, const struct txt *literal)
{
    struct node *nuw;

    assert(literal != NULL);

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_CI_LITERAL;

    nuw->invisible = invisible;

    nuw->u.literal = *literal;

    return nuw;
}

struct node *
node_create_cs_literal(int invisible, const struct txt *literal)
{
    struct node *nuw;

    assert(literal != NULL);

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_CS_LITERAL;

    nuw->invisible = invisible;

    nuw->u.literal = *literal;

    return nuw;
}

struct node* node_create_name(int invisible, const char *name)
{
    struct node *nuw;

    assert(name != NULL);

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_RULE;

    nuw->invisible = invisible;

    nuw->u.name = name;

    return nuw;
}

struct node *
node_create_prose(int invisible, const char *prose)
{
    struct node *nuw;

    assert(prose != NULL);

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_PROSE;

    nuw->invisible = invisible;

    nuw->u.prose = prose;

    return nuw;
}

struct node *
node_create_alt(int invisible, struct list *alt)
{
    struct node *nuw;

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_ALT;

    nuw->invisible = invisible;

    nuw->u.alt = alt;

    return nuw;
}

struct node *
node_create_alt_skippable(int invisible, struct list *alt)
{
    struct node *nuw;

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_ALT_SKIPPABLE;

    nuw->invisible = invisible;

    nuw->u.alt = alt;

    return nuw;
}

struct node *
node_create_seq(int invisible, struct list *seq)
{
    struct node *nuw;

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_SEQ;

    nuw->invisible = invisible;

    nuw->u.seq = seq;

    return nuw;
}

struct node *
node_create_loop(int invisible, struct node *forward, struct node *backward)
{
    struct node *nuw;

    nuw = (node*)xmalloc(sizeof *nuw);

    nuw->type = NODE_LOOP;

    nuw->invisible = invisible;

    nuw->u.loop.forward  = forward;
    nuw->u.loop.backward = backward;

    nuw->u.loop.min = 0;
    nuw->u.loop.max = 0;

    return nuw;
}

void
node_make_seq(int invisible, struct node **n)
{
    struct list *nuw;

    assert(n != NULL);

    if (*n != NULL && (*n)->type == NODE_SEQ) {
        return;
    }

    nuw = NULL;

    list_push_front(&nuw, *n);

    *n = node_create_seq(invisible, nuw);
}

int
node_compare(const struct node *a, const struct node *b)
{
    if (a == NULL && b == NULL) {
        return 1;
    }

    if (a == NULL || b == NULL) {
        return 0;
    }

    if (a->type != b->type) {
        return 0;
    }

    if (a->invisible != b->invisible) {
        return 0;
    }

    switch (a->type) {
    case NODE_CI_LITERAL:
        return 0 == txtcasecmp(&a->u.literal, &b->u.literal);

    case NODE_CS_LITERAL:
        return 0 == txtcmp(&a->u.literal, &b->u.literal);

    case NODE_RULE:
        return 0 == strcmp(a->u.name, b->u.name);

    case NODE_PROSE:
        return 0 == strcmp(a->u.prose, b->u.prose);

    case NODE_ALT:
    case NODE_ALT_SKIPPABLE:
        return list_compare(a->u.alt, b->u.alt);

    case NODE_SEQ:
        return list_compare(a->u.seq, b->u.seq);

    case NODE_LOOP:
        return node_compare(a->u.loop.forward,  b->u.loop.forward) &&
               node_compare(a->u.loop.backward, b->u.loop.backward);
    }

    return 1;
}

void
loop_flip(struct node *n)
{
    struct node *tmp;

    assert(n != NULL);
    assert(n->type == NODE_LOOP);

    tmp = n->u.loop.backward;
    n->u.loop.backward = n->u.loop.forward;
    n->u.loop.forward  = tmp;
}

