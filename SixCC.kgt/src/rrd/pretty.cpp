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

static void node_walk(void (*f)(int*, node**), int* changed, node** n)
{
	assert(n != nullptr);
	assert(f != nullptr);

	f(changed, n);

	if (*n == nullptr)
	{
		return;
	}

	struct list** p;

	switch ((*n)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			for (p = &(*n)->u.alt; *p != nullptr; p = &(**p).next)
			{
				node_walk(f, changed, &(*p)->node);
			}
			break;

		case NODE_SEQ:
			for (p = &(*n)->u.seq; *p != nullptr; p = &(**p).next)
			{
				node_walk(f, changed, &(*p)->node);
			}
			break;

		case NODE_LOOP:
			node_walk(f, changed, &(*n)->u.loop.forward);
			node_walk(f, changed, &(*n)->u.loop.backward);
			break;

		case NODE_RULE:
		case NODE_PROSE:
		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
			break;
	}
}

void rrd_pretty(struct node** rrd)
{
	int changed;
	int limit;
	size_t i;

	void (*f[])(int*, struct node**) =
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
}

