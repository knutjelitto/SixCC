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

static void nested_alt(int* changed, struct node* n)
{
	assert(n->type == NODE_ALT || n->type == NODE_ALT_SKIPPABLE);

	list replacement;

	for (node* current : n->alt())
	{
		if (current == nullptr || (current->type != NODE_ALT && current->type != NODE_ALT_SKIPPABLE))
		{
			replacement.push_back(current);
			continue;
		}

		replacement.append(current->alt());

		*changed = 1;
	}

	if (*changed)
	{
		n->alt().replace(replacement);
	}
}

static void nested_seq(int* changed, struct node* n)
{
	assert(n->type == NODE_SEQ);

	list replacement;

	for (node* current : n->seq())
	{
		if (current == nullptr || current->type != NODE_SEQ)
		{
			replacement.push_back(current);
			continue;
		}

		replacement.append(current->seq());

		*changed = 1;
	}

	if (*changed)
	{
		n->seq().replace(replacement);
	}
}

node* rrd_pretty_nested(int* changed, node** rrd)
{
	assert(rrd != nullptr);

	if (*rrd == nullptr)
	{
		return *rrd;
	}

	switch ((*rrd)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			nested_alt(changed, *rrd);
			break;

		case NODE_SEQ:
			nested_seq(changed, *rrd);
			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_LOOP:
			break;
	}

	return *rrd;
}
