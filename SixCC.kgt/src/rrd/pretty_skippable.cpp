/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>
#include <stdlib.h>
#include <stdio.h>

#include "../txt.h"
#include "../xalloc.h"

#include "pretty.h"
#include "node.h"
#include "list.h"

static void skippable_alt(int* changed, struct node* n)
{
	assert(n->type == NODE_ALT);

	for (auto node : n->alt())
	{
		if (node == nullptr)
		{
			n->become_alt_skippable();
			*changed = 1;
			break;
		}
	}
	/* TODO: if you're skippable and you contain nothing, have some other transformation remove it */
}

static void redundant_skip(int* changed, list& list)
{
	/*
	 * If there are skip nodes (nullptr) in a seq or skippable alt,
	 * just remove them - they have no semantic effect.
	 */

	for (int i = 0; i < list.size();)
	{
		if (list[i] == nullptr)
		{
			list.drop(i);
		}
		else
		{
			i += 1;
		}
	}
}

node* rrd_pretty_skippable(int* changed, node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

	switch ((*rrd)->type)
	{
		case NODE_ALT:
			skippable_alt(changed, *rrd);
			break;

		case NODE_ALT_SKIPPABLE:
			redundant_skip(changed, (*rrd)->alt());
			break;

		case NODE_SEQ:
			redundant_skip(changed, (*rrd)->seq());
			break;

		case NODE_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_LOOP:
			break;
	}

	return *rrd;
}

