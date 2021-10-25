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

node* rrd_pretty_collapse(int* changed, node** rrd)
{
    assert(rrd != nullptr);

    if (*rrd == nullptr)
    {
        return *rrd;
    }

    switch ((*rrd)->type)
    {
        case NODE_LITERAL:
        case NODE_RULE:
        case NODE_PROSE:
        case NODE_LOOP:
            break;

        case NODE_ALT:
        {
            node* node = (*rrd)->alt().single_or_default();

            if (node != nullptr)
            {
                *rrd = node;

                *changed = 1;
            }
            break;
        }

        case NODE_ALT_SKIPPABLE:
            break;

        case NODE_SEQ:
        {
            node* node = (*rrd)->seq().single_or_default();

            if (node != nullptr)
            {
                *rrd = node;

                *changed = 1;
            }
            break;
        }
    }

    return *rrd;
}
