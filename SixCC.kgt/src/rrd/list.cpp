/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stdlib.h>

#include "../txt.h"
#include "../xalloc.h"

#include "list.h"
#include "node.h"

void list_push_front(struct list **list, struct node *node)
{
    struct list *nuw;

    assert(list != nullptr);

    nuw = (struct list*)xmalloc(sizeof *nuw);
    nuw->node = node;
    nuw->next = *list;

    *list = nuw;
}

struct node* list_pop_front(struct list** list)
{
    struct list* n;
    struct node* node;

    if (list == nullptr || *list == nullptr)
    {
        return nullptr;
    }

    n = *list;
    *list = n->next;

    node = n->node;

    free(n);

    return node;
}

void list_cat(struct list** dst, struct list* src)
{
    struct list** p;

    for (p = dst; *p != nullptr; p = &(*p)->next)
        ;

    assert(*p == nullptr);
    src->next = *p;
    *p = src;
}

int list_compare(const struct list *a, const struct list *b)
{
    const struct list *p, *q;

    for (p = a, q = b; p != nullptr && q != nullptr; p = p->next, q = q->next) {
        if (!node_compare(p->node, q->node)) {
            return 0;
        }
    }

    if (p != nullptr || q != nullptr) {
        /* lists are of different length */
        return 0;
    }

    return 1;
}

struct list** list_tail(struct list** head)
{
    struct list** p;

    /* TODO: rewrite legibly */
    for (p = head; *p != nullptr && (*p)->next != nullptr; p = &(*p)->next)
        ;

    if (*p == nullptr)
    {
        return nullptr;
    }

    return p;
}

void list_free(struct list** list)
{
    while (*list != nullptr)
    {
        (void)list_pop_front(list);
    }
}

unsigned list_count(const struct list* list)
{
    const struct list* p;
    unsigned n;

    n = 0;

    for (p = list; p != nullptr; p = p->next)
    {
        n++;
    }

    return n;
}

