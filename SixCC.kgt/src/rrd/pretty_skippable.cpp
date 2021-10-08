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
	struct list* p;

	for (p = n->altx(); p != nullptr; p = p->next)
	{
		if (p->node == nullptr)
		{
			n->type = NODE_ALT_SKIPPABLE;
			*changed = 1;
		}
	}

	/* TODO: if you're skippable and you contain nothing, have some other transformation remove it */
}

static void redundant_skip(int* changed, struct list** list)
{
	struct list** p;
	struct list** next;

	/*
	 * If there are skip nodes (nullptr) in a seq or skippable alt,
	 * just remove them - they have no semantic effect.
	 */

	for (p = list; *p != nullptr; p = next)
	{
		next = &(*p)->next;

		if ((*p)->node == nullptr)
		{
			struct list* dead;

			dead = *p;
			*p = (*p)->next;

			dead->next = nullptr;
			list_free(&dead);

			*changed = 1;

			next = p;
		}
	}
}

void rrd_pretty_skippable(int* changed, struct node** n)
{
	assert(n != nullptr);

	if (*n == nullptr)
	{
		return;
	}

	switch ((*n)->type)
	{
		case NODE_ALT:
			skippable_alt(changed, *n);
			break;

		case NODE_ALT_SKIPPABLE:
			redundant_skip(changed, &(*n)->xxx_list);
			break;

		case NODE_SEQ:
			redundant_skip(changed, &(*n)->xxx_list);
			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_LOOP:
			break;
	}
}

