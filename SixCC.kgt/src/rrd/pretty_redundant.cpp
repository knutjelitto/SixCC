/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>

#include "../txt.h"
#include "../xalloc.h"

#include "pretty.h"
#include "node.h"
#include "list.h"

#if true
#else
static void redundant_alt(int* changed, struct node* n, struct node** np)
{
	assert(n->type == NODE_ALT || n->type == NODE_ALT_SKIPPABLE);

	bool isskippable = n->type == NODE_ALT_SKIPPABLE;
	int nc = 0;
	struct list** p;
	struct node** loop;

	loop = nullptr;

	for (p = &n->xxx_list; *p != nullptr; p = &(**p).next)
	{
		nc++;

		if ((*p)->node != nullptr && (*p)->node->type == NODE_LOOP)
		{
			loop = &(*p)->node;
		}
	}

	if (nc == 2 && isskippable && loop != nullptr)
	{
		struct node* l;

		l = *loop;

		/* special case: if an optional loop has an empty half, we can elide the NODE_ALT */
		if (l->u.loop.forward == nullptr)
		{
			*np = *loop;
			*loop = nullptr;
			node_free(n);

			*changed = 1;
		}
		else if (l->u.loop.backward == nullptr)
		{
			loop_flip(l);

			*np = *loop;
			*loop = nullptr;

			/* XXX:
						node_free(n);
			*/

			*changed = 1;
		}
	}
}
#endif

#if true
#else
static void redundant_loop(int* changed, struct node* n, struct node** np)
{
	struct node** inner = nullptr;
	struct node* loop;

	if (n->u.loop.forward != nullptr && n->u.loop.forward->type == NODE_LOOP && n->u.loop.backward == nullptr)
	{
		loop = n->u.loop.forward;
		if (loop->u.loop.forward == nullptr || loop->u.loop.backward == nullptr)
		{
			inner = &n->u.loop.forward;
		}
	}
	else if (n->u.loop.backward != nullptr && n->u.loop.backward->type == NODE_LOOP && n->u.loop.forward == nullptr)
	{
		loop = n->u.loop.backward;
		if (loop->u.loop.forward == nullptr)
		{
			inner = &n->u.loop.backward;
		}
		else if (loop->u.loop.backward == nullptr)
		{
			loop_flip(loop);
			inner = &n->u.loop.backward;
		}
	}

	if (inner)
	{
		*np = *inner;
		*inner = nullptr;
		node_free(n);
		*changed = 1;
	}
}
#endif

void rrd_pretty_redundant(int* changed, struct node** n)
{
#if true
#else
	assert(n != nullptr);

	if (*n == nullptr)
	{
		return;
	}

	switch ((*n)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			redundant_alt(changed, *n, n);
			break;

		case NODE_LOOP:
			redundant_loop(changed, *n, n);
			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_SEQ:
			break;
	}
#endif
}

