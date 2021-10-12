/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../bitmap.h"
#include "../rrd/node.h"
#include "../compiler_specific.h"

#include "io.h"

WARN_UNUSED_RESULT static int output_term(const struct ast_term *term);

static void output_byte(char c)
{
	writer->printf("%%x%02X", (unsigned char) c);
}

static void output_range(char lo, char hi)
{
	writer->printf("%%x%02X-%02X", (unsigned char) lo, (unsigned char) hi);
}

static bool needesc(int c)
{
	if (!isprint((unsigned char)c))
	{
		return true;
	}

	switch (c)
	{
		case '"':
		case '\a':
		case '\f':
		case '\n':
		case '\r':
		case '\t':
		case '\v':
			return true;

		default:
			return false;
	}
}

WARN_UNUSED_RESULT static int output_string(char prefix, const struct text& t)
{
	size_t i;

	if (t.length() == 1 && needesc(t[0]))
	{
		output_byte(t[0]);
		return 1;
	}

	if (t.any(needesc))
	{
		fprintf(stderr, "unsupported: escaping special characters within a literal\n");
		return 0;
	}

	if (t.any([](int c) { return isalpha(c) != 0; }))
	{
		writer->printf("%%%c", prefix);
	}

	writer->putc('\"');

	/* TODO: bail out on non-printable characters */

	for (i = 0; i < t.length(); i++)
	{
		writer->putc(t[i]);
	}

	writer->putc('\"');

	return 1;
}

WARN_UNUSED_RESULT static int output_terms(const ast_terms& terms)
{
	bool more = false;
	for (auto term : terms)
	{
		if (more)
		{
			writer->putc(' ');
		}
		else
		{
			more = true;
		}
		if (!output_term(term))
		{
			return 0;
		}
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_alts(const ast_alts& alts)
{
	bool more = false;
	for (auto alt : alts)
	{
		if (more)
		{
			writer->puts(" / ");
		}
		else
		{
			more = true;
		}

		if (!output_terms(alt->terms))
		{
			return 0;
		}
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_group(const ast_alts& group)
{
	if (group.size() >= 2)
	{
		writer->puts("(");
	}

	if (!output_alts(group))
	{
		return 0;
	}

	if (group.size() >= 2)
	{
		writer->puts(")");
	}

	return 1;
}

static void output_repetition(unsigned int min, unsigned int max)
{
	if (min == 0 && max == 1)
	{
		__assume(false);
		assert(!"unreached");
	}

	if (min == 1 && max == 1)
	{
		/* no operator */
		return;
	}

	if (min != 0 && min == max)
	{
		writer->printf("%u", min);
		return;
	}

	if (min > 0)
	{
		writer->printf("%u", min);
	}

	writer->puts("*");

	if (max > 0)
	{
		writer->printf("%u", max);
	}
}

static int atomic(const struct ast_term* term)
{
	assert(term != nullptr);

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

	__assume(false);
	assert(!"unreached");
}

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	assert(term != nullptr);

	int a = atomic(term);

	if (term->min == 0 && term->max == 1)
	{
		writer->puts("[ ");
	}
	else
	{
		output_repetition(term->min, term->max);

		if (!a)
		{
			writer->puts("( ");
		}
	}

	switch (term->type)
	{
		case TYPE_EMPTY:
			writer->puts("\"\"");
			break;

		case TYPE_RULE:
			writer->puts(term->rule()->name);
			break;

		case TYPE_CI_LITERAL:
			if (!output_string('i', term->text()))
			{
				return 0;
			}
			break;

		case TYPE_CS_LITERAL:
			if (!output_string('s', term->text()))
			{
				return 0;
			}
			break;

		case TYPE_TOKEN:
			writer->puts(term->text());
			break;

		case TYPE_PROSE:
			/* TODO: escaping to somehow avoid > */
			writer->printf("< %s >", term->text().chars());
			break;

		case TYPE_GROUP:
			if (!output_group(term->group()))
			{
				return 0;
			}
			break;
	}

	if (term->min == 0 && term->max == 1)
	{
		writer->puts(" ]");
	}
	else if (!a)
	{
		writer->puts(" )");
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule *rule)
{
	writer->printf("%s = ", rule->name.chars());

	if (!output_alts(rule->alts))
	{
		return 0;
	}

	writer->puts("\n");
	writer->puts("\n");

	return 1;
}

WARN_UNUSED_RESULT int abnf_output(const ast_grammar& grammar)
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

