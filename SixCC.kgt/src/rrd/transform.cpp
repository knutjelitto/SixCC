/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * AST to Railroad transformation
 */

#include <assert.h>
#include <string.h>
#include <stddef.h>
#include <errno.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"

#include "rrd.h"
#include "node.h"
#include "list.h"

static int transform_term(const struct ast_term *term, struct node **r);

static int transform_terms(const struct ast_alt* alt, struct node** r)
{
	assert(r != nullptr);

	struct list* list;
	struct list** tail;
	const struct ast_term* term;

	list = new struct list();

	for (term = alt->terms; term != nullptr; term = term->next)
	{
		struct node* node;

		if (!transform_term(term, &node))
		{
			goto error;
		}

		list->add(node);
	}

	*r = node_create_seq(alt->invisible, list);

	return 1;

error:

	list_free(*list);

	return 0;
}

static int transform_alts(const struct ast_alt* alts, struct node** r)
{
	assert(r != nullptr);
	assert(alts != nullptr);

	struct list* list;
	struct list** tail;
	const struct ast_alt* alt;

	list = new struct list();

	for (alt = alts; alt != nullptr; alt = alt->next)
	{
		struct node* node;

		if (!transform_terms(alt, &node))
		{
			goto error;
		}

		list->add(node);
	}

	*r = node_create_alt(alts->invisible, list);

	return 1;

error:

	list_free(*list);

	return 0;
}

static int single_term(const struct ast_term* term, struct node** r)
{
	assert(r != nullptr);

	switch (term->type)
	{
		case TYPE_EMPTY:
			*r = nullptr;
			return 1;

		case TYPE_RULE:
			*r = node_create_name(term->invisible, term->rule()->name());
			return 1;

		case TYPE_CI_LITERAL:
			/* can't create a sequence of alts; the tokenisation would be wrong */
			*r = node_create_ci_literal(term->invisible, term->text());
			return 1;

		case TYPE_CS_LITERAL:
			*r = node_create_cs_literal(term->invisible, term->text());
			return 1;

		case TYPE_TOKEN:
			*r = node_create_name(term->invisible, term->text());
			return 1;

		case TYPE_PROSE:
			*r = node_create_prose(term->invisible, term->text());
			return 1;

		case TYPE_GROUP:
			return transform_alts(term->group(), r);
	}

	__assume(false);
	assert(!"unreached");
}

static int optional_term(const struct ast_term* term, struct node** r)
{
	assert(r != nullptr);

	struct node* n;

	if (!single_term(term, &n))
	{
		return 0;
	}

	struct list* list = new struct list();

	list->add(n);

	*r = node_create_alt_skippable(term->invisible, list);

	return 1;
}

static int oneormore_term(const struct ast_term* term, struct node** r)
{
	struct node* n;

	assert(r != nullptr);

	if (!single_term(term, &n))
	{
		return 0;
	}

	*r = node_create_loop(term->invisible, n, nullptr);

	return 1;
}

static int zeroormore_term(const struct ast_term* term, struct node** r)
{
	struct node* n;

	assert(r != nullptr);

	if (!single_term(term, &n))
	{
		return 0;
	}

	*r = node_create_loop(term->invisible, nullptr, n);

	return 1;
}

static int finite_term(const struct ast_term* term, struct node** r)
{
	struct node* loop;
	struct node* n;

	assert(r != nullptr);
	assert(term->max > 0);

	if (!single_term(term, &n))
	{
		return 0;
	}

	if (term->min > 0)
	{
		loop = node_create_loop(term->invisible, n, nullptr);
		loop->u.loop.min = term->min - 1;
		loop->u.loop.max = term->max - 1;
	}
	else
	{
		loop = node_create_loop(term->invisible, nullptr, n);
		loop->u.loop.min = term->min;
		loop->u.loop.max = term->max;
	}

	*r = loop;

	return 1;
}

static int atleast_term(const struct ast_term* term, struct node** r)
{
	struct node* n;

	assert(r != nullptr);

	if (!single_term(term, &n))
	{
		return 0;
	}

	*r = node_create_loop(term->invisible, nullptr, n);

	(*r)->u.loop.min = term->min;

	return 1;
}

static int transform_term(const struct ast_term* term, struct node** r)
{
	assert(r != nullptr);

	if (term->min == 1 && term->max == 1)
	{
		return single_term(term, r);
	}

	if (term->min == 0 && term->max == 1)
	{
		return optional_term(term, r);
	}

	if (term->min == 1 && term->max == 0)
	{
		return oneormore_term(term, r);
	}

	if (term->min == 0 && term->max == 0)
	{
		return zeroormore_term(term, r);
	}

	if (term->max == 0)
	{
		return atleast_term(term, r);
	}

	return finite_term(term, r);
}

int ast_to_rrd(const struct ast_rule *rule, struct node **r)
{
	assert(rule != nullptr);
	assert(r != nullptr);

	return transform_alts(rule->alts, r);
}

