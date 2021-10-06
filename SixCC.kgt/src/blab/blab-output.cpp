/*
 * Copyright 2018 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Blab grammar-based data generator
 * https://github.com/aoh/blab
 *
 * This is an EBNF-like dialect with regexp-style operators.
 * It isn't formally specified; output here is an attempt to match
 * the current syntax at the time of writing.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../compiler_specific.h"

#include "io.h"

WARN_UNUSED_RESULT static int output_term(const struct ast_term *term);

int blab_escputc(int c)
{
	switch (c)
	{
		case '\"': return writer->puts("\\\"");
		case '\\': return writer->puts("\\\\");
		case '\n': return writer->puts("\\n");
		case '\r': return writer->puts("\\r");
		case '\t': return writer->puts("\\t");
		case '\'': return writer->puts("\\\'");

		default:
			break;
	}

	if (!isprint((unsigned char)c))
	{
		return writer->printf("\\x%02x", (unsigned char)c);
	}

	return writer->printf("%c", c);
}

WARN_UNUSED_RESULT static int output_group_alt(const struct ast_alt* alt)
{
	const struct ast_term* term;

	for (term = alt->terms; term != NULL; term = term->next)
	{
		if (!output_term(term))
			return 0;
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_group(const struct ast_alt* group)
{
	const struct ast_alt* alt;

	for (alt = group; alt != NULL; alt = alt->next)
	{
		if (!output_group_alt(alt))
			return 0;

		if (alt->next != NULL)
		{
			writer->printf(" |");
		}
	}
	return 1;
}

static void output_repetition(unsigned int min, unsigned int max)
{
	if (min == 0 && max == 0)
	{
		writer->printf("*");
	}
	else if (min == 0 && max == 1)
	{
		writer->printf("?");
	}
	else if (min == 1 && max == 0)
	{
		writer->printf("+");
	}
	else if (min == 1 && max == 1)
	{
		/* no operator */
	}
	else if (min == max)
	{
		writer->printf("{%u}", min);
	}
	else if (max == 0)
	{
		writer->printf("{%u,}", min);
	}
	else
	{
		writer->printf("{%u,%u}", min, max);
	}
}

static int atomic(const struct ast_term* term)
{
	assert(term != NULL);

	if (term->min == 1 && term->max == 1)
	{
		return 1;
	}

	switch (term->type)
	{
		case TYPE_EMPTY:
		case TYPE_RULE:
		case TYPE_CI_LITERAL:
		case TYPE_CS_LITERAL:
		case TYPE_TOKEN:
		case TYPE_PROSE:
			return 1;

		case TYPE_GROUP:
			return 0;
	}

	assert(!"unreached");
}

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	int a;

	assert(term != NULL);
	assert(!term->invisible);

	a = atomic(term);

	if (!a)
	{
		writer->printf(" (");
	}

	switch (term->type)
	{
		case TYPE_EMPTY:
			writer->puts(" \"\"");
			break;

		case TYPE_RULE:
			writer->putc(' ');
			writer->puts(term->u.rule->name);
			break;

		case TYPE_CI_LITERAL:
		{
			size_t i;

			writer->putc(' ');

			/* XXX: the tokenization here is wrong; this should be a single token */

			for (i = 0; i < term->u.literal.n; i++)
			{
				char uc, lc;

				uc = toupper((unsigned char)term->u.literal.p[i]);
				lc = tolower((unsigned char)term->u.literal.p[i]);

				if (uc == lc)
				{
					writer->putc('[');
					(void)blab_escputc(term->u.literal.p[i]);
					writer->putc(']');
					continue;
				}

				if (uc != lc)
				{
					writer->putc('[');
					(void)blab_escputc(lc);
					(void)blab_escputc(uc);
					writer->putc(']');
				}
			}
		}
		break;

		case TYPE_CS_LITERAL:
		{
			size_t i;

			writer->puts(" \"");

			for (i = 0; i < term->u.literal.n; i++)
			{
				(void)blab_escputc(term->u.literal.p[i]);
			}

			writer->putc('\"');
		}
		break;

		case TYPE_TOKEN:
			writer->putc(' ');
			writer->puts(term->u.token);
			break;

		case TYPE_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case TYPE_GROUP:
			if (!output_group(term->u.group))
			{
				return 0;
			}
			break;
	}

	if (!a)
	{
		writer->printf(" )");
	}

	output_repetition(term->min, term->max);
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	const struct ast_term* term;

	assert(!alt->invisible);

	for (term = alt->terms; term != NULL; term = term->next)
	{
		if (!output_term(term))
			return 0;

		if (term->next)
		{
			writer->putc(' ');
		}
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule)
{
	const struct ast_alt* alt;

	writer->printf("%s =", rule->name.chars());
	for (alt = rule->alts; alt != NULL; alt = alt->next)
	{
		if (!output_alt(alt))
			return 0;

		if (alt->next != NULL)
		{
			writer->printf("\n\t|");
		}
	}

	writer->printf("\n");
	writer->printf("\n");
	return 1;
}

WARN_UNUSED_RESULT
int
blab_output(const struct ast_rule *grammar)
{
	const struct ast_rule *p;

	for (p = grammar; p != NULL; p = p->next) {
		if (!output_rule(p))
			return 0;
	}
	return 1;
}

