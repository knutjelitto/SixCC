/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * AST node rewriting
 */

#include <assert.h>
#include <limits.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <ctype.h>

#include "errors.h"
#include "txt.h"
#include "ast.h"
#include "rewrite.h"
#include "xalloc.h"
#include "compiler_specific.h"

static bool walk_alts(const struct ast_alt *alts);

static void add_alt(int invisible, struct ast_alt **alt, const text& text)
{
	assert(alt != NULL);

	struct ast_term* term = ast_make_literal_term(invisible, text, false);

	struct ast_alt* nuw = ast_make_alt(invisible, term);
	nuw->next = *alt;
	*alt = nuw;
}

WARN_UNUSED_RESULT static bool permute_cases(int invisible, struct ast_alt** alt, const text& text)
{
#if true
	Error::notimplemented();
#else
	assert(alt != NULL);

	size_t i, j;
	unsigned long num_alphas, perm_count;
	unsigned long alpha_inds[CHAR_BIT * sizeof i - 1]; /* - 1 because we shift (1 << n) by this size */

	const char* p = text.chars();
	int n = text.length();

	num_alphas = 0;
	for (i = 0; i < n; i++)
	{
		if (!isalpha((unsigned char)p[i]))
		{
			continue;
		}

		if (num_alphas + 1 > sizeof alpha_inds / sizeof * alpha_inds)
		{
			fprintf(stderr, "Too many alpha characters in case-insensitive string "
				"\"%.*s\", max is %u\n",
				text.length(), text.chars(),
				(unsigned)(sizeof alpha_inds / sizeof * alpha_inds));
			return false;
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

		add_alt(invisible, alt, text);
	}
	return true;
#endif
}

WARN_UNUSED_RESULT static bool rewrite_ci(const struct ast_term* term)
{
#if true
	Error::notimplemented();
#else
	assert(term->type == TYPE_CI_LITERAL);

	/* case is normalised during AST creation */
	for (int i = 0; i < term->text().length(); i++)
	{
		if (!isalpha((unsigned char)term->text(i)))
		{
			continue;
		}

		assert(islower((unsigned char)term->text(i)));
	}

	assert(term->text().length() > 0);
	text tmp = term->text();

	/* we repurpose the existing node, which breaks abstraction for freeing */
	term->type = TYPE_GROUP;
	term->u.group = NULL;

	/* invisibility of nuw alts is inherited from term->invisible itself */
	bool success = permute_cases(term->invisible, &term->u.group, &tmp);

	return success;
#endif
}

WARN_UNUSED_RESULT static bool walk_term(const struct ast_term* term)
{
	assert(term != NULL);

	switch (term->type)
	{
		case TYPE_EMPTY:
		case TYPE_CS_LITERAL:
		case TYPE_TOKEN:
		case TYPE_PROSE:
			break;
		case TYPE_RULE:
			/* (struct ast_term).u.rule is just for the name; don't recurr into it */
			break;

		case TYPE_GROUP:
			return walk_alts(term->group());

		case TYPE_CI_LITERAL:
			return rewrite_ci(term);
	}

	return true;
}

WARN_UNUSED_RESULT static bool walk_alts(const struct ast_alt* alts)
{
	const struct ast_alt* alt;
	struct ast_term* term;

	for (alt = alts; alt != NULL; alt = alt->next)
	{
		for (term = alt->terms; term != NULL; term = term->next)
		{
			if (!walk_term(term))
			{
				return false;
			}
		}
	}

	return true;
}

WARN_UNUSED_RESULT bool rewrite_ci_literals(struct ast_rule* grammar)
{
	struct ast_rule* rule;

	for (rule = grammar; rule != NULL; rule = rule->next)
	{
		if (!walk_alts(rule->alts))
		{
			return false;
		}
	}
	return true;
}

