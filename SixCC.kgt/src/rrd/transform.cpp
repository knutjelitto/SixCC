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

#include "../errors.h"
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

	list = new struct list();

	for (auto term : alt->terms)
	{
		struct node* node;

		if (!transform_term(term, &node))
		{
			goto error;
		}

		list->push_back(node);
	}

	*r = node_create_seq(list);

	return 1;

error:

	list_free(*list);

	return 0;
}

static int transform_alts(const ast_alts& alts, struct node** r)
{
	assert(r != nullptr);

	list* list;

	list = new struct list();

	for (auto alt : alts)
	{
		struct node* node;

		if (!transform_terms(alt, &node))
		{
			goto error;
		}

		list->push_back(node);
	}

	*r = node_create_alt(list);

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
		case AST_EMPTY:
			*r = nullptr;
			return 1;

		case AST_RULE:
			*r = node_create_name(term->rule()->name);
			return 1;

		case AST_LITERAL:
			*r = node_create_literal(term->text());
			return 1;

		case AST_TOKEN:
			*r = node_create_name(term->text());
			return 1;

		case AST_PROSE:
			*r = node_create_prose(term->text());
			return 1;

		case AST_GROUP:
			return transform_alts(term->group(), r);

		default:
			Error::notreached();
	}
}

static int optional_term(const ast_term* term, struct node** r)
{
	assert(r != nullptr);

	struct node* n;

	if (!single_term(term, &n))
	{
		return 0;
	}

	struct list* list = new struct list();

	list->push_back(n);

	*r = node_create_alt_skippable(list);

	return 1;
}

static int oneormore_term(const ast_term* term, struct node** r)
{
	assert(r != nullptr);

	struct node* n;

	if (!single_term(term, &n))
	{
		return 0;
	}

	*r = node_create_loop(n, nullptr);

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

	*r = node_create_loop(nullptr, n);

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
		loop = node_create_loop(n, nullptr);
		loop->loop.min = term->min - 1;
		loop->loop.max = term->max - 1;
	}
	else
	{
		loop = node_create_loop(nullptr, n);
		loop->loop.min = term->min;
		loop->loop.max = term->max;
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

	*r = node_create_loop(nullptr, n);

	(*r)->loop.min = term->min;

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

