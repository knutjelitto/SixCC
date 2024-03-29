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


bool list::eq(const list& other) const
{
    if (size() == other.size())
    {
        for (int i = 0; i < size(); i += 1)
        {
            if (!node_compare((*this)[i], other[i]))
            {
                return false;
            }
        }
        return true;
    }
    return false;
}

struct node* list_pop_front(struct list& list)
{
    return list.pop();
}

void list_free(list& list)
{
    list.clear();
}

unsigned list_count(const list& list)
{
    return list.size();
}

