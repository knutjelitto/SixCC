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

static void loop_inc(struct node* loop)
{
	assert(loop != nullptr);
	assert(loop->type == NODE_LOOP);

	if (loop->loop.min != 0)
	{
		loop->loop.min++;
	}

	if (loop->loop.max != 0)
	{
		loop->loop.max++;
	}
}

static void list_free_upto(struct list** list, const struct node* end)
{
#if true
#else
	while (*list != nullptr && (*list)->node != end)
	{
		struct node* n;

		n = list_pop_front(list);
		node_free(n);
	}
#endif
}

static int list_walk_upto(struct list** tail, struct list* head, struct list* list, const struct node* end)
{
#if true
	return 0;
#else
	assert(tail != nullptr);

	struct list* p;
	struct list* q;

	for (p = head, q = list; p != nullptr && p->node != end && q != nullptr; p = p->next, q = q->next)
	{
		if (!node_compare(p->node, q->node))
		{
			return 0;
		}
	}

	if (q != nullptr)
	{
		return 0;
	}

	*tail = p;

	return 1;
#endif
}

static void collapse_suffix(int* changed, struct list** head, struct node* loop)
{
#if true
#else
	struct list* p;

	assert(changed != nullptr);
	assert(head != nullptr);
	assert(loop != nullptr);
	assert(loop->type == NODE_LOOP);

	/* if loop .forward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->u.loop.forward);

	assert(loop->u.loop.forward != nullptr);
	assert(loop->u.loop.forward->type == NODE_SEQ);
	assert(loop->u.loop.forward->seqx() != nullptr);

	/* if loop .backward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->u.loop.backward);

	assert(loop->u.loop.backward != nullptr);
	assert(loop->u.loop.backward->type == NODE_SEQ);
	assert(loop->u.loop.backward->seqx() != nullptr);

	/* find end of run; anchored at end of loop's seq */
	{
		p = *head;

		if (!list_walk_upto(&p, p, loop->u.loop.backward->seqx(), nullptr))
		{
			return;
		}
		if (!list_walk_upto(&p, p, loop->u.loop.forward->seqx(), nullptr))
		{
			return;
		}
	}

	/* cut off up to that point */
	list_free_upto(head, p->node);

	loop_inc(loop);

	*changed = 1;
#endif
}

static void collapse_prefix(int* changed, struct list** head, struct node* loop)
{
#if true
#else
	struct list** p;

	assert(changed != nullptr);
	assert(head != nullptr);
	assert(loop != nullptr);
	assert(loop->type == NODE_LOOP);

	/* if loop .forward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->u.loop.forward);

	assert(loop->u.loop.forward != nullptr);
	assert(loop->u.loop.forward->type == NODE_SEQ);
	assert(loop->u.loop.forward->seqx() != nullptr);

	/* if loop .backward isn't a NODE_SEQ, make it one */
	node_make_seq(loop->invisible, &loop->u.loop.backward);

	assert(loop->u.loop.backward != nullptr);
	assert(loop->u.loop.backward->type == NODE_SEQ);
	assert(loop->u.loop.backward->seqx() != nullptr);

	/* find start of run; anchored at loop node */
	{
		for (p = head; *p != nullptr && (*p)->node != loop; p = &(*p)->next)
		{
			struct list* q;

			q = *p;

			if (!list_walk_upto(&q, q, loop->u.loop.forward->seqx(), loop))
			{
				continue;
			}
			if (!list_walk_upto(&q, q, loop->u.loop.backward->seqx(), loop))
			{
				continue;
			}

			if (q->node == loop)
			{
				break;
			}
		}

		if (*p == nullptr || (*p)->node == loop)
		{
			return;
		}
	}

	/* cut off from that point forward, up to the loop node */
	list_free_upto(p, loop);

	loop_inc(loop);

	*changed = 1;
#endif
}

node* rrd_pretty_affixes(int* changed, struct node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

#if true
#else
	switch ((*rrd)->type)
	{
		struct list** p;

		case NODE_SEQ:
			/*
			 * pretty_affix.c is only used for when an affix matches
			 * the entire loop iteration. So all we ever change here
			 * is deleting an affix.
			 * loop bodies are never changed here;
			 * loop counters get incremented.
			 *
			 * TODO: no need to handle when .forward is SKIP,
			 * because pretty_roll does that. So have separate handling
			 * for when when .backward is or isn't SKIP.
			 *
			 */

			for (p = &(*rrd)->xxx_list; *p != nullptr; p = &(*p)->next)
			{
				if ((*p)->node != nullptr && (*p)->node->type == NODE_LOOP)
				{
					if ((*p)->node->u.loop.backward == nullptr)
					{
						/* TODO: collapse_suffix() for forward only */
					}
					else
					{
						collapse_suffix(changed, &(*p)->next, (*p)->node);
					}
					if (*changed)
					{
						break;
					}
				}
			}

			for (p = &(*rrd)->xxx_list; *p != nullptr; p = &(*p)->next)
			{
				if ((*p)->node != nullptr && (*p)->node->type == NODE_LOOP)
				{
					if ((*p)->node->u.loop.backward == nullptr)
					{
						/* TODO: collapse_prefix() for forward only */
					}
					else
					{
						collapse_prefix(changed, &(*rrd)->xxx_list, (*p)->node);
					}
					if (*changed)
					{
						break;
					}
				}
			}

			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		case NODE_LOOP:
			break;
	}
#endif

	return *rrd;
}

