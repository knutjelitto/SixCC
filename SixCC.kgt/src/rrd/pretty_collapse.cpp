/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>

#include "../txt.h"

#include "pretty.h"
#include "node.h"
#include "list.h"

void rrd_pretty_collapse(int* changed, struct node** rrd_node)
{
    assert(rrd_node != nullptr);

    if (*rrd_node == nullptr)
    {
        return;
    }

    switch ((*rrd_node)->type)
    {
        case NODE_CI_LITERAL:
        case NODE_CS_LITERAL:
        case NODE_RULE:
        case NODE_PROSE:
        case NODE_LOOP:
            break;

        case NODE_ALT:
        {
            node* node = (*rrd_node)->alt().single_or_default();

            if (node != nullptr)
            {
                *rrd_node = node;

                *changed = 1;
            }
            break;
        }

        case NODE_ALT_SKIPPABLE:
            break;

        case NODE_SEQ:
        {
            node* node = (*rrd_node)->seq().single_or_default();

            if (node != nullptr)
            {
                *rrd_node = node;

                *changed = 1;
            }
            break;
        }
    }
}
