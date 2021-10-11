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

/*
 * This transformation combines two equivalent nodes:
 *
 *                       loop
 *                __________________
 *               /                  \
 *
 *  ||-- A B C -->------------------v--||
 *               |                  |
 *               ^-- C B A -- "|" --<
 *
 * by pushing one of them to the loop's .forward list:
 *
 *                       loop
 *                __________________
 *               /                  \
 *
 *  ||-- A B ---->-- C -------------v--||
 *               |                  |
 *               ^-- B A ---- "|" --<
 */
static void roll_prefix(int* changed, list& list, int loop_index)
{
	assert(list.size() >= 2);
	assert(1 <= loop_index && loop_index < list.size());
	assert(list[loop_index]->type == NODE_LOOP);

	// node before loop
	node* candidate = list[loop_index - 1];
	// the loop itself
	node* loop = list[loop_index];

	/* if loop .backward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->loop.backward);

	assert(loop->loop.backward != nullptr);
	assert(loop->loop.backward->type == NODE_SEQ);

	struct list& blist = loop->loop.backward->seq();

	/* find node at tail of .backward */
	node* candidate2 = blist.last_or_default();
	if (candidate2 == nullptr)
	{
		return;
	}

	if (!node_compare(candidate, candidate2))
	{
		return;
	}

	// remove equivalent nodes from their lists
	blist.pop_back();
	list.drop(loop_index - 1);


	/* if loop .forward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->loop.forward);

	assert(loop->loop.forward != nullptr);
	assert(loop->loop.forward->type == NODE_SEQ);
	assert(loop->loop.forward->seq().size() > 0);

	struct list& flist = loop->loop.forward->seq();

	/* if destination is a skip node, destroy that node first */
	/* TODO: centralise */
	if (flist.first() == nullptr)
	{
		flist.pop_front();
	}

	/*
	 * Nominate one of the equivalent nodes (either would do),
	 * remove it from its current list, and prepend to .forward
	 * instead.
	 */
	 /* TODO: centralise? list_transplant() */
	{
		flist.push_front(candidate);
	}

	/* we don't have empty lists */
	if (blist.size() == 0)
	{
		loop->loop.backward = nullptr;
	}

	*changed = 1;
}

/*
 * This transformation combines two equivalent nodes:
 *
 *              loop
 *       __________________
 *      /                  \
 *
 *  ||-->------------------v-- C B A --||
 *      |                  |
 *      ^-- "|" -- A B C --<
 *
 * by pushing one of them to the loop's .backward list:
 *
 *              loop
 *       __________________
 *      /                  \
 *
 *  ||-->------------- C --v-- B A ----||
 *      |                  |
 *      ^-- "|" ---- A B --<
 */
static void roll_suffix(int* changed, list& list, int loop_index)
{
	assert(list.size() >= 2);
	assert(0 <= loop_index && loop_index < list.size() - 1);
	assert(list[loop_index]->type == NODE_LOOP);

	// node after loop
	node* candidate = list[loop_index + 1];
	// the loop itself
	node* loop = list[loop_index];

	/* if loop .backward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->loop.backward);

	assert(loop->loop.backward != nullptr);
	assert(loop->loop.backward->type == NODE_SEQ);

	struct list& blist = loop->loop.backward->seq();

	/* find node at head of .backward */
	node* candidate2 = blist.first_or_default();
	if (candidate2 == nullptr)
	{
		return;
	}

	if (!node_compare(candidate, candidate2))
	{
		return;
	}

	// remove equivalent nodes from their lists
	blist.pop_front();
	list.drop(loop_index + 1);
		
	/* if loop .forward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->loop.forward);

	assert(loop->loop.forward != nullptr);
	assert(loop->loop.forward->type == NODE_SEQ);
	assert(loop->loop.forward->seq().size() > 0);

	struct list& flist = loop->loop.forward->seq();

	/* if destination is a skip node, destroy that node first */
	if (flist.first() == nullptr)
	{
		flist.pop_front();
	}

	/*
	 * Nominate one of the equivalent nodes (either would do),
	 * remove it from its current list, and append to .forward
	 * instead.
	 */
	{
		flist.push_back(candidate);
	}

	/* we don't have empty lists */
	if (blist.size() == 0)
	{
		loop->loop.backward = nullptr;
	}

	*changed = 1;
}

node* rrd_pretty_roll(int* changed, node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

	switch ((*rrd)->type)
	{
		case NODE_SEQ:
		{
			list& seq = (*rrd)->seq();

			/*
			 * Here we're looking one node ahead for the prefix to a loop,
			 * and passing the address of the subsquent loop node
			 * rather than searching from the head each time.
			 */
			for (int i = 1; i < seq.size(); ++i)
			{
				if (seq[i] != nullptr && seq[i]->type == NODE_LOOP)
				{
					roll_prefix(changed, seq, i);
					if (*changed)
					{
						break;
					}
				}
			}

			/*
			 * The suffix is the node immediately following a loop.
			 */
			for (int i = 1; i < seq.size(); ++i)
			{
				if (seq[i-1] != nullptr && seq[i-1]->type == NODE_LOOP)
				{
					roll_suffix(changed, seq, i-1);
					if (*changed)
					{
						break;
					}
				}
			}

			break;
		}

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		case NODE_LOOP:
			break;
	}

	return *rrd;
}

