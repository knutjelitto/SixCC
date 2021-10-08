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
#if false
#else
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
            if ((*rrd_node)->seq().size() == 1)
            {
                struct node* dead;

                dead = *rrd_node;
                *rrd_node = (*rrd_node)->seqx()->node;
                dead->xxx_list = nullptr;
                node_free(dead);

                *changed = 1;
            }
            break;
    }
#endif
}

