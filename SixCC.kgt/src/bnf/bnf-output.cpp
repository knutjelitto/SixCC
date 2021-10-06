/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Backus-Naur Form Output.
 *
 * TODO: fprintf(fout), instead of stdout
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>

#include "../txt.h"
#include "../ast.h"

#include "io.h"

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	assert(term->type != TYPE_GROUP);
	assert(!term->invisible);

	/* TODO: semantic checks ought to find if we can output to this language; groups cannot */
	/* BNF cannot express term repetition; TODO: semantic checks for this */

	assert(term->min == 1);
	assert(term->max == 1);

	switch (term->type)
	{
		case TYPE_EMPTY:
			writer->puts(" \"\"");
			break;

		case TYPE_RULE:
			writer->printf(" <%s>", term->u.rule->name.chars());
			break;

		case TYPE_CI_LITERAL:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case TYPE_CS_LITERAL:
		{
			char c;

			c = memchr(term->u.literal.p, '\"', term->u.literal.n) ? '\'' : '\"';
			writer->printf(" %c%.*s%c", c, (int)term->u.literal.n, term->u.literal.p, c);
			break;
		}

		case TYPE_TOKEN:
			writer->printf(" <%s>", term->u.token);
			break;

		case TYPE_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case TYPE_GROUP:
			fprintf(stderr, "not supported\n");
			return 0;
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	const struct ast_term* term;

	assert(!alt->invisible);

	for (term = alt->terms; term != nullptr; term = term->next)
	{
		if (!output_term(term))
		{
			return 0;
		}
	}

	writer->printf("\n");

	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule)
{
	const struct ast_alt* alt;

	writer->printf("<%s> ::=", rule->name.chars());

	for (alt = rule->alts; alt != nullptr; alt = alt->next)
	{
		if (!output_alt(alt))
		{
			return 0;
		}

		if (alt->next != nullptr)
		{
			writer->printf("\t|");
		}
	}

	writer->printf("\n");
	return 1;
}

WARN_UNUSED_RESULT int bnf_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	for (p = grammar; p != nullptr; p = p->next)
	{
		if (!output_rule(p))
		{
			return 0;
		}
	}
	return 1;
}
