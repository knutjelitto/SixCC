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

void rrd_pretty_collapse(int* changed, struct node** n)
{
    assert(n != nullptr);

    if (*n == nullptr)
    {
        return;
    }

    switch ((*n)->type)
    {
        case NODE_CI_LITERAL:
        case NODE_CS_LITERAL:
        case NODE_RULE:
        case NODE_PROSE:
        case NODE_LOOP:
            break;

        case NODE_ALT:
            if (list_count((*n)->alt()) == 1)
            {
                struct node* dead;

                dead = *n;
                *n = (*n)->alt()->node;
                dead->xxx_list = nullptr;
                node_free(dead);

                *changed = 1;
            }
            break;

        case NODE_ALT_SKIPPABLE:
            break;

        case NODE_SEQ:
            if (list_count((*n)->seq()) == 1)
            {
                struct node* dead;

                dead = *n;
                *n = (*n)->seq()->node;
                dead->xxx_list = nullptr;
                node_free(dead);

                *changed = 1;
            }
            break;
    }
}

