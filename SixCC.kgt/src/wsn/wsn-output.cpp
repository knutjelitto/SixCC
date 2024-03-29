/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Wirth Syntax Notation Output.
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

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt *alt);
WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule);
WARN_UNUSED_RESULT static int output_term(const struct ast_term* term);

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
		{ 1, 1, " ( ", " )" },
		{ 1, 1, ""   ,""    },
		{ 0, 1, " [ ", " ]" },
		{ 0, 0, " { ", " }" }
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

	/* TODO: for {1,0} output first term inline */

	assert(s != NULL && e != NULL);

	/* EBNF cannot express minimum term repetition; TODO: semantic checks for this */
	assert(term->min <= 1);
	assert(term->max <= 1);

	writer->printf("%s", s);

	switch (term->type)
	{
		case AST_EMPTY:
			writer->puts(" \"\"");
			break;

		case AST_RULE:
			writer->putc(' ');
			writer->puts(term->rule()->name);
			break;

		case AST_LITERAL:
		{
			size_t i;

			writer->puts(" \"");
			for (i = 0; i < term->text().length(); i++)
			{
				if (term->text()[i] == '\"')
				{
					writer->puts("\"\"");
				}
				else
				{
					writer->putc(term->text()[i]);
				}
			}
			writer->putc('\"');
			break;
		}

		case AST_TOKEN:
			writer->printf(" %s", term->text().chars());
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
			if (!output_alt(term->group().front()))
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
	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule)
{
	writer->printf("%s =", rule->name.chars());

	bool more = false;
	for (auto alt : rule->alts)
	{
		if (more)
		{
			writer->printf("\n\t|");
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

	writer->printf(" .\n\n");
	return 1;
}

WARN_UNUSED_RESULT int wsn_output(const ast_grammar& grammar)
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
