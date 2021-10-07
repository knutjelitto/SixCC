/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * RRD node rewriting
 */

#include <assert.h>
#include <limits.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"

#include "../rrd/rrd.h"
#include "../rrd/rewrite.h"
#include "../rrd/node.h"
#include "../rrd/list.h"
#include "../compiler_specific.h"

static void add_alt(int invisible, struct list **list, const text& text)
{
	assert(list != NULL);

	struct node *node;

	node = node_create_cs_literal(invisible, text);

	list_push_front(list, node);
}

/* TODO: centralise */
WARN_UNUSED_RESULT static int permute_cases(int invisible, struct list** list, text& text)
{
	size_t i, j;
	unsigned long num_alphas, perm_count;
	unsigned long alpha_inds[CHAR_BIT * sizeof i - 1]; /* - 1 because we shift (1 << n) by this size */
	size_t n;
	char* p;

	assert(list != NULL);

	p = (char*)text.chars();
	n = text.length();

	num_alphas = 0;
	for (i = 0; i < n; i++)
	{
		if (!isalpha((unsigned char)p[i]))
		{
			continue;
		}

		if (num_alphas + 1 > sizeof alpha_inds / sizeof * alpha_inds)
		{
			fprintf(stderr, "Too many alpha characters in case-invensitive string "
				"\"%.*s\", max is %u\n",
				(int)text.length(), text.chars(),
				(unsigned)(sizeof alpha_inds / sizeof * alpha_inds));
			return 0;
		}


		alpha_inds[num_alphas++] = i;
	}

	perm_count = (1UL << num_alphas); /* this limits us to sizeof perm_count */
	for (i = 0; i < perm_count; i++)
	{
		for (j = 0; j < num_alphas; j++)
		{
			p[alpha_inds[j]] = ((i >> j) & 1UL)
				? tolower((unsigned char)p[alpha_inds[j]])
				: toupper((unsigned char)p[alpha_inds[j]]);
		}

		add_alt(invisible, list, text);
	}
	return 1;
}

WARN_UNUSED_RESULT static int rewrite_ci(struct node* node)
{
	text tmp;

	assert(node->type == NODE_CI_LITERAL);
	assert(node->u.literal.length() > 0);

	/* case is normalised during AST creation */
	for (int i = 0; i < node->u.literal.length(); i++)
	{
		if (!isalpha((unsigned char)node->u.literal[i]))
		{
			continue;
		}

		assert(islower((unsigned char)node->u.literal[i]));
	}

	tmp = node->u.literal;

	/* we repurpose the existing node, which breaks abstraction for freeing */
	node->type = NODE_ALT;
	node->u.alt = NULL;

	/* invisibility of new alts is inherited from n->invisible itself */
	if (!permute_cases(node->invisible, &node->u.alt, tmp))
	{
		return 0;
	}

	return 1;
}

WARN_UNUSED_RESULT static int node_walk(struct node* n)
{
	if (n == NULL)
	{
		return 1;
	}

	switch (n->type)
	{
		const struct list* p;

		case NODE_CI_LITERAL:
			if (!rewrite_ci(n))
				return 0;

			break;

		case NODE_CS_LITERAL:
		case NODE_RULE:
		case NODE_PROSE:

			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			for (p = n->u.alt; p != NULL; p = p->next)
			{
				if (!node_walk(p->node))
					return 0;
			}

			break;

		case NODE_SEQ:
			for (p = n->u.seq; p != NULL; p = p->next)
			{
				if (!node_walk(p->node))
					return 0;
			}

			break;

		case NODE_LOOP:
			if (!node_walk(n->u.loop.forward))
				return 0;
			if (!node_walk(n->u.loop.backward))
				return 0;

			break;
	}
	return 1;
}

WARN_UNUSED_RESULT int rewrite_rrd_ci_literals(struct node *n)
{
	return node_walk(n);
}

