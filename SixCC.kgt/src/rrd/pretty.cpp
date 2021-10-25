/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Railroad diagram beautification
 */

#include <stddef.h>
#include <assert.h>

#include "../txt.h"
#include "../xalloc.h"

#include "node.h"
#include "list.h"
#include "pretty.h"

static void node_walk(node* (*f)(int*, node**), int* changed, node** rrd)
{
	assert(rrd != nullptr);
	assert(f != nullptr);

	f(changed, rrd);

	if (*rrd == nullptr)
	{
		return;
	}

	switch ((*rrd)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		{
			list& alt = (*rrd)->alt();
			for (int i = 0; i < alt.size(); i += 1)
			{
				node_walk(f, changed, &alt[i]);
			}
			break;
		}
		case NODE_SEQ:
		{
			list& seq = (*rrd)->seq();
			for (int i = 0; i < seq.size(); i += 1)
			{
				node_walk(f, changed, &seq[i]);
			}
			break;
		}

		case NODE_LOOP:
			node_walk(f, changed, &(*rrd)->loop.forward);
			node_walk(f, changed, &(*rrd)->loop.backward);
			break;

		case NODE_RULE:
		case NODE_PROSE:
		case NODE_LITERAL:
			break;
	}
}

void rrd_pretty(struct node** rrd)
{
	int changed = 0;
	int limit;
	size_t i;

	node* (*f[])(int*, node**) =
	{
		rrd_pretty_collapse,
		rrd_pretty_skippable,
		rrd_pretty_redundant,
		rrd_pretty_collapse,
		rrd_pretty_roll,
		rrd_pretty_collapse,
		rrd_pretty_nested,
		rrd_pretty_ci,
		rrd_pretty_collapse,
		rrd_pretty_affixes,
		rrd_pretty_collapse,
		rrd_pretty_bottom,
		rrd_pretty_collapse
	};

	limit = 20;

	for (i = 0; i < sizeof f / sizeof * f; i++)
	{
		do
		{
			changed = 0;
			node_walk(f[i], &changed, rrd);
		}
		while (changed && !limit--);
	}

	assert(limit > 0);
}

