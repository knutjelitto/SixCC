/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <string.h>
#include <stddef.h>
#include <assert.h>

#include "../txt.h"

#include "pretty.h"
#include "node.h"
#include "list.h"

static int bottom_loop(node** np)
{
    assert(np != nullptr);
    assert(*np != nullptr);

    struct node* n;

    n = *np;

    if (n->loop.forward != nullptr)
    {
        return 0;
    }

    if (n->loop.backward == nullptr || n->loop.backward->type == NODE_LOOP)
    {
        return 0;
    }

    if (n->loop.backward->type == NODE_CI_LITERAL || n->loop.backward->type == NODE_CS_LITERAL || n->loop.backward->type == NODE_RULE)
    {
        return 0;
    }

    if (n->loop.backward->type == NODE_ALT || n->loop.backward->type == NODE_ALT_SKIPPABLE)
    {
        bool c = false;

        for (auto node : n->loop.backward->alt())
        {
            if (node->type == NODE_ALT || node->type == NODE_ALT_SKIPPABLE || node->type == NODE_SEQ || node->type == NODE_LOOP)
            {
                c = true;
            }
        }

        if (!c)
        {
            return 0;
        }
    }

    loop_flip(n);

    /* short-circuit */
    {
        struct list* nuw = new list();

        nuw->push_back(n);
        nuw->push_back(nullptr);

        *np = node_create_alt(n->invisible, nuw);
    }

    return 1;
}

/*
 * for loops with nothing on top and more than one thing on the bottom,
 * flip the loop over and add an alt to skip the loop altogether.
 * this results in a bulkier diagram, but avoids reversing the contents of
 * the sequence.
 */
node* rrd_pretty_bottom(int* changed, struct node** rrd)
{
    assert(rrd != nullptr);

    if (*rrd == nullptr)
    {
        return *rrd;
    }

    switch ((*rrd)->type)
    {
        case NODE_LOOP:
            if (bottom_loop(rrd))
            {
                *changed = 1;
            }
            break;

        case NODE_CI_LITERAL:
        case NODE_CS_LITERAL:
        case NODE_RULE:
        case NODE_PROSE:
        case NODE_ALT:
        case NODE_ALT_SKIPPABLE:
        case NODE_SEQ:
            break;
    }

    return *rrd;
}

