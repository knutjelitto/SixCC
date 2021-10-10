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

static void redundant_alt(int* changed, struct node** np)
{
	assert(np != nullptr);
	assert(*np != nullptr);
	struct node* n = *np;
	assert(n->type == NODE_ALT || n->type == NODE_ALT_SKIPPABLE);

#if false
#else

	list& alt = n->alt();

	if (alt.size() == 2 && n->type == NODE_ALT_SKIPPABLE)
	{
		struct node** loop;

		loop = nullptr;

		for (int i = 0; i < alt.size(); i += 1)
		{
			if (alt[i] != nullptr && alt[i]->type == NODE_LOOP)
			{
				loop = &alt[i];
			}
		}

		if (loop != nullptr)
		{
			struct node* l = *loop;

			/* special case: if an optional loop has an empty half, we can elide the NODE_ALT */
			if (l->loop.forward == nullptr)
			{
				*np = *loop;
				*loop = nullptr;
				node_free(n);

				*changed = 1;
			}
			else if (l->loop.backward == nullptr)
			{
				loop_flip(l);

				*np = *loop;
				*loop = nullptr;
				*changed = 1;
			}
		}
	}
#endif
}

static void redundant_loop(int* changed, struct node* n, struct node** np)
{
#if true
#else
	struct node** inner = nullptr;
	struct node* loop;

	if (n->loop.forward != nullptr && n->loop.forward->type == NODE_LOOP && n->loop.backward == nullptr)
	{
		loop = n->loop.forward;
		if (loop->loop.forward == nullptr || loop->loop.backward == nullptr)
		{
			inner = &n->loop.forward;
		}
	}
	else if (n->loop.backward != nullptr && n->loop.backward->type == NODE_LOOP && n->loop.forward == nullptr)
	{
		loop = n->loop.backward;
		if (loop->loop.forward == nullptr)
		{
			inner = &n->loop.backward;
		}
		else if (loop->loop.backward == nullptr)
		{
			loop_flip(loop);
			inner = &n->loop.backward;
		}
	}

	if (inner)
	{
		*np = *inner;
		*inner = nullptr;
		node_free(n);
		*changed = 1;
	}
#endif
}

node* rrd_pretty_redundant(int* changed, node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

#if false
#else
	switch ((*rrd)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			redundant_alt(changed, rrd);
			break;

		case NODE_LOOP:
			redundant_loop(changed, *rrd, rrd);
			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_SEQ:
			break;
	}
#endif

	return *rrd;
}

