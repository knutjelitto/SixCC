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
	struct list* list;
	struct list* p;

	/*
	 * If every text node in an alt list is a single character,
	 * convert them to case-sensitive expansions. Then the ellipsis
	 * replacements happens per usual during tnode rewriting.
	 * The end effect is to produce an ellipsis for uppercase
	 * and an ellipsis for lowercase.
	 */
	list = nullptr;

	for (p = n->alt(); p != nullptr; p = p->next)
	{
		if (p->node == nullptr)
		{
			continue;
		}

		switch (p->node->type)
		{
			case NODE_CI_LITERAL:
			case NODE_CS_LITERAL:
				if (p->node->literal().length() != 1)
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

	for (p = n->alt(); p != nullptr; p = p->next)
	{
		if (p->node == nullptr)
		{
			continue;
		}

		text t;

		switch (p->node->type)
		{
			case NODE_CI_LITERAL:
			{

				if (!isalpha((unsigned char)p->node->literal()[0]))
				{
					break;
				}

				p->node->type = NODE_CS_LITERAL;
				p->node->tolower();

				struct node* nuw = node_create_cs_literal(p->node->invisible, p->node->literal().toupper());
				list_push_back(&list, nuw);

				*changed = 1;

				break;
			}

			case NODE_CS_LITERAL:
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
		struct list** tail;

		/* TODO: centralise with list_tail() */
		for (tail = &n->xxx_list; *tail != nullptr; tail = &(*tail)->next)
			;

		assert(*tail == nullptr);
		*tail = list;
	}
}

void rrd_pretty_ci(int* changed, struct node** n)
{
	assert(n != nullptr);

	if (*n == nullptr)
	{
		return;
	}

	switch ((*n)->type)
	{
		case NODE_CI_LITERAL:
		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:
		case NODE_SEQ:
		case NODE_LOOP:
			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			ci_alt(changed, *n);
			break;
	}
}

