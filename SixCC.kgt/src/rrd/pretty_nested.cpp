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

	for (auto current = n->alt().begin(); current != n->alt().end(); current = current + 1)
	{
		if (*current == nullptr || ((*current)->type != NODE_ALT && (*current)->type != NODE_ALT_SKIPPABLE))
		{
			replacement.add(*current);
			continue;
		}

		replacement.add((*current)->alt());

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

	for (auto current = n->seq().begin(); current != n->seq().end(); current = current + 1)
	{
		if (*current == nullptr || (*current)->type != NODE_SEQ)
		{
			replacement.add(*current);
			continue;
		}

		replacement.add((*current)->seq());

		*changed = 1;
	}

	if (*changed)
	{
		n->seq().replace(replacement);
	}
}

void rrd_pretty_nested(int* changed, struct node** n)
{
	assert(n != nullptr);

	if (*n == nullptr)
	{
		return;
	}

	switch ((*n)->type)
	{
		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			nested_alt(changed, *n);
			break;

		case NODE_SEQ:
			nested_seq(changed, *n);
			break;

		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_LOOP:
			break;
	}
}

