/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * RFC 5511 RBNF Output.
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

WARN_UNUSED_RESULT static int output_term(const struct ast_term *term);

WARN_UNUSED_RESULT static int output_group_alt(const struct ast_alt* alt)
{
	for (auto term : alt->terms)
	{
		if (!output_term(term))
		{
			return 0;
		}
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_group(const ast_alts& group)
{
	bool more = false;
	for (auto alt : group)
	{
		if (more)
		{
			writer->printf(" |");
		}
		else
		{
			more = true;
		}
		if (!output_group_alt(alt))
		{
			return 0;
		}
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	const char* s, * e;
	size_t i;

	struct
	{
		unsigned int min;
		unsigned int max;
		const char* s;
		const char* e;
	} a[] = {
		{ 1 , 1 , " (" , " ) "     } ,
		{ 1 , 1 , ""   , ""        } ,
		{ 0 , 1 , " [" , " ] "     } ,
		{ 0 , 0 , " [" , " ... ] " }
	};

	assert(term != NULL);

	s = NULL;
	e = NULL;

	for (i = 0; i < sizeof a / sizeof * a; i++)
	{
		if (i == 0 && term->type != AST_GROUP)
		{
			continue;
		}

		if (term->min == a[i].min && term->min == a[i].min)
		{
			s = a[i].s;
			e = a[i].e;
			break;
		}
	}

	/* RBNF cannot express min/max repetition; TODO: semantic checks for this */
	assert(s != NULL && e != NULL);

	/* TODO: RBNF cannot express literal <>::= etc. maybe output those as rule names */

	writer->printf("%s", s);

	switch (term->type)
	{
		case AST_EMPTY:
			writer->puts(" \"\"");
			break;

		case AST_RULE:
			writer->printf(" <%s>", term->rule()->name.chars());
			break;

		case AST_LITERAL:
#if true
			writer->printf(" unimplemented-literal<%s>", term->text().chars());
			break;
#else
			fprintf(stderr, "unimplemented\n");
			return 0;
#endif

		case AST_TOKEN:
			writer->printf(" <%s>", term->text().chars());
			break;

		case AST_PROSE:
#if true
			writer->printf(" unimplemented-prose<%s>", term->text().chars());
			break;
#else
			fprintf(stderr, "unimplemented\n");
			return 0;
#endif

		case AST_GROUP:
			if (!output_group(term->group()))
			{
				return 0;
			}
			break;
	}

	writer->printf("%s", e);
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	assert(alt != NULL);

	for (auto term : alt->terms)
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
	writer->printf("<%s> ::=", rule->name.chars());

	bool more = false;
	for (auto alt : rule->alts)
	{
		if (more)
		{
			writer->printf("\t|");
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

	writer->printf("\n");
	return 1;
}

WARN_UNUSED_RESULT int rbnf_output(const ast_grammar& grammar)
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

