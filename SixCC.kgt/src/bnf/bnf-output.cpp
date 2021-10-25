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
	assert(term->type != AST_GROUP);

	/* TODO: semantic checks ought to find if we can output to this language; groups cannot */
	/* BNF cannot express term repetition; TODO: semantic checks for this */

	assert(term->min == 1);
	assert(term->max == 1);

	switch (term->type)
	{
		case AST_EMPTY:
			writer->puts(" \"\"");
			break;

		case AST_RULE:
			writer->printf(" <%s>", term->rule()->name.chars());
			break;

		case AST_LITERAL:
		{
			char c;

			c = memchr(term->text().chars(), '\"', term->text().length()) ? '\'' : '\"';
			writer->printf(" %c%.*s%c", c, (int)term->text().length(), term->text().chars(), c);
			break;
		}

		case AST_TOKEN:
			writer->printf(" <%s>", term->text().chars());
			break;

		case AST_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case AST_GROUP:
			fprintf(stderr, "not supported\n");
			return 0;
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	for (auto term : alt->terms)
	{
		if (!output_term(term))
		{
			return 0;
		}
	}

	writer->puts("\n");

	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule)
{
	writer->printf("<%s> ::=", rule->name.chars());

	bool more = false;
	for (auto alt : rule->alts)
	{
		if (more)
		{
			writer->puts("\t|");
		}
		else
		{
			more = true;
		}
	
		if (!output_alt(alt))
		{
			return 0;
		}
	}

	writer->puts("\n");
	return 1;
}

WARN_UNUSED_RESULT int bnf_output(const ast_grammar& grammar)
{
	for (auto rule : grammar.rules)
	{
		if (!output_rule(rule))
		{
			return 0;
		}
	}
	return 1;
}
