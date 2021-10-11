/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * SID Output.
 *
 * TODO: fprintf(fout), instead of stdout
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
//#include <strings.h>
#include <assert.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"
#include "../compiler_specific.h"

#include "io.h"

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt *);

static void output_section(const char *section)
{
	writer->printf("\n%%%s%%\n\n", section);
}

static void output_literal(const text& text)
{
	char c;

	c = memchr(text.chars(), '\"', text.length()) ? '\'' : '\"';
	writer->printf("%c%.*s%c; ", c, text.length(), text.chars(), c);
}

WARN_UNUSED_RESULT static int output_basic(const struct ast_term* term)
{
	assert(term != nullptr);
	assert(!term->invisible);

	switch (term->type)
	{
		case TYPE_EMPTY:
			writer->puts("$$; ");
			break;

		case TYPE_RULE:
			writer->printf("%s; ", term->rule()->name().chars());
			break;

		case TYPE_CI_LITERAL:
#if true
			writer->printf(" unimplemented-ci-literal<%s>", term->text().chars());
			break;
#else
			fprintf(stderr, "unimplemented\n");
			return 0;
#endif

		case TYPE_CS_LITERAL:
			output_literal(term->text());
			break;

		case TYPE_TOKEN:
			writer->printf("%s; ", term->text().chars());
			break;

		case TYPE_PROSE:
#if true
			writer->printf(" unimplemented-prose<%s>", term->text().chars());
			break;
#else
			fprintf(stderr, "unimplemented\n");
			return 0;
#endif

		case TYPE_GROUP:
			writer->puts("{ ");
			if (!output_alt(term->group()))
			{
				return 0;
			}
			writer->puts("}; ");
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	assert(term != nullptr);
	assert(!term->invisible);

	/* SID cannot express term repetition; TODO: semantic checks for this */
	/* TODO: can output repetition as [ ... ] local rules with a stub to call them X times? */
	assert(term->min <= 1);
	assert(term->max <= 1);

	if (term->min == 0)
	{
		writer->puts("{ $$; || ");
	}

	if (!output_basic(term))
	{
		return 0;
	}

	if (term->min == 0)
	{
		writer->puts("}; ");
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	assert(alt != nullptr);
	assert(!alt->invisible);

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
	const struct ast_alt* alt;

	writer->printf("\t%s = {\n\t\t", rule->name().chars());

	for (alt = rule->alts; alt != nullptr; alt = alt->next)
	{
		if (!output_alt(alt))
		{
			return 0;
		}

		writer->printf("\n");

		if (alt->next != nullptr)
		{
			writer->printf("\t||\n\t\t");
		}
	}

	writer->printf("\t};\n\n");
	return 1;
}

static bool is_equal(const struct ast_term* a, const struct ast_term* b)
{
	if (a->type != b->type)
	{
		return 0;
	}

	switch (a->type)
	{
		case TYPE_EMPTY:      return true;
		case TYPE_RULE:       return a->rule()->name().eq(b->rule()->name());
		case TYPE_CI_LITERAL: return a->text().cieq(b->text());
		case TYPE_CS_LITERAL: return a->text().eq(b->text());
		case TYPE_TOKEN:      return a->text().eq(b->text());
		case TYPE_PROSE:      return a->text().eq(b->text());

		case TYPE_GROUP:
			/* unimplemented */
			return 0;
	}

	assert(!"unreached");
}

WARN_UNUSED_RESULT static int output_terminals(const struct ast_rule* grammar)
{
	const struct ast_rule* rule;
	struct ast_term* found = nullptr;

	/* List terminals */
	for (rule = grammar; rule != nullptr; rule = rule->next)
	{
		struct ast_alt* alt;

		for (alt = rule->alts; alt != nullptr; alt = alt->next)
		{
			struct ast_term* aterm;

			assert(alt != nullptr);
			assert(!alt->invisible);

			for (auto term : alt->terms)
			{
				assert(term != nullptr);
				assert(!term->invisible);

				switch (term->type)
				{
					case TYPE_EMPTY:
					case TYPE_GROUP:
						continue;

					case TYPE_RULE:
					case TYPE_TOKEN:
					case TYPE_PROSE:
						continue;

					case TYPE_CI_LITERAL:
					case TYPE_CS_LITERAL:
						aterm = term;
						break;
				}

				assert(aterm->type == TYPE_CI_LITERAL || aterm->type == TYPE_CS_LITERAL);

				struct ast_term* t;

				for (t = found; t != nullptr; t = t->next)
				{
					if (is_equal(t, aterm))
					{
						break;
					}
				}

				if (t != nullptr)
				{
					continue;
				}

				t = aterm->type == TYPE_CI_LITERAL 
					? ast_term::make_ci_literal(0, aterm->text())
					: ast_term::make_cs_literal(0, aterm->text());
				t->next = found;
				found = t;
			}
		}
	}

	/* Output list */
	{
		struct ast_term* next;
		struct ast_term* t;

		for (t = found; t != nullptr; t = next)
		{
			next = t->next;
			writer->printf("\t");
			if (!output_basic(t))
			{
				return 0;
			}
			writer->printf("\n");
			delete t;
		}
	}
	return 1;
}

WARN_UNUSED_RESULT int sid_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	output_section("types");

	output_section("terminals");

	if (!output_terminals(grammar))
	{
		return 0;
	}

	output_section("rules");

	/* TODO list rule declartations */

	for (p = grammar; p != nullptr; p = p->next)
	{
		if (!output_rule(p))
		{
			return 0;
		}
	}

	output_section("entry");

	writer->printf("\t%s;\n\n", grammar->name().chars());
	return 1;
}
