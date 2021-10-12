/*
 * Copyright 2014-2020 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * AST node rewriting
 * (In this case not so much rewriting, but rather just plain removing;
 * invisible nodes have no semantic effect.)
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

static void walk_alts(const struct ast_alt **alts);

static void walk_term(struct ast_term* term)
{
#if true
	Error::notimplemented();
#else
	assert(term != nullptr);

	switch (term->type)
	{
		case TYPE_EMPTY:
		case TYPE_CS_LITERAL:
		case TYPE_CI_LITERAL:
		case TYPE_RULE:
		case TYPE_TOKEN:
		case TYPE_PROSE:
			break;

		case TYPE_GROUP:
			walk_alts(&term->group());
			break;
	}
#endif
}

static void walk_alts(ast_alts& alts)
{
	auto altp = alts.begin();

	while (altp != alts.end())
	{
		if ((*altp)->invisible)
		{
			delete *altp;
			altp = alts.erase(altp);
			continue;
		}

		ast_terms& terms = (*altp)->terms;
		auto termp = terms.begin();
		while (termp < terms.end())
		{
			if ((*termp)->invisible)
			{
				delete *termp;
				termp = terms.erase(termp);
				continue;
			}
			walk_term(*termp);

			termp++;
		}
	}
}

void rewrite_invisible(ast_grammar& grammar)
{
	for (auto rule : grammar.rules)
	{
		walk_alts(rule->alts);
	}
}

