/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <string.h>
#include <stddef.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>

#include "../txt.h"
#include "../xalloc.h"

#include "pretty.h"
#include "node.h"
#include "list.h"

static void ci_alt(int* changed, struct node* n)
{
	assert(n->type == NODE_ALT || n->type == NODE_ALT_SKIPPABLE);

	/*
	 * If every text node in an alt list is a single character,
	 * convert them to case-sensitive expansions. Then the ellipsis
	 * replacements happens per usual during tnode rewriting.
	 * The end effect is to produce an ellipsis for uppercase
	 * and an ellipsis for lowercase.
	 */
	struct list list;

	for (auto node : n->alt())
	{
		if (node == nullptr)
		{
			continue;
		}

		switch (node->type)
		{
			case NODE_LITERAL:
				if (node->literal().length() != 1)
				{
					return;
				}

				break;

			case NODE_RULE:
			case NODE_PROSE:
			case NODE_ALT:
			case NODE_ALT_SKIPPABLE:
			case NODE_SEQ:
			case NODE_LOOP:
				break;
		}
	}

	for (auto node : n->alt())
	{
		if (node == nullptr)
		{
			continue;
		}

		text t;

		switch (node->type)
		{
			case NODE_LITERAL:
			case NODE_RULE:
			case NODE_PROSE:
			case NODE_ALT:
			case NODE_ALT_SKIPPABLE:
			case NODE_SEQ:
			case NODE_LOOP:
				break;
		}

	}

	/* append list */
	{
		n->alt().append(list);
	}
}

node* rrd_pretty_ci(int* changed, node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

	switch ((*rrd)->type)
	{
		case NODE_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_SEQ:
		case NODE_LOOP:
			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			ci_alt(changed, *rrd);
			break;
	}

	return *rrd;
}

