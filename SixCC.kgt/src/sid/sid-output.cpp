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

	switch (term->type)
	{
		case AST_EMPTY:
			writer->puts("$$; ");
			break;

		case AST_RULE:
			writer->printf("%s; ", term->rule()->name.chars());
			break;

		case AST_LITERAL:
			output_literal(term->text());
			break;

		case AST_TOKEN:
			writer->printf("%s; ", term->text().chars());
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
			writer->puts("{ ");
			if (!output_alt(term->group().front()))
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
	writer->printf("\t%s = {\n\t\t", rule->name.chars());

	bool more = false;
	for (auto alt : rule->alts)
	{
		if (more)
		{
			writer->printf("\t||\n\t\t");
		}
		else
		{
			more = true;
		}

		if (!output_alt(alt))
		{
			return 0;
		}

		writer->printf("\n");
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
		case AST_EMPTY:      return true;
		case AST_RULE:       return a->rule()->name.eq(b->rule()->name);
		case AST_LITERAL: return a->text().eq(b->text());
		case AST_TOKEN:      return a->text().eq(b->text());
		case AST_PROSE:      return a->text().eq(b->text());

		case AST_GROUP:
			/* unimplemented */
			return 0;
	}

	assert(!"unreached");
}

WARN_UNUSED_RESULT static int output_terminals(const ast_grammar& grammar)
{
	struct ast_term* found = nullptr;

	/* List terminals */
	for (auto rule : grammar.rules)
	{
		for (auto alt : rule->alts)
		{
			struct ast_term* aterm;

			assert(alt != nullptr);

			for (auto term : alt->terms)
			{
				assert(term != nullptr);

				switch (term->type)
				{
					case AST_EMPTY:
					case AST_GROUP:
						continue;

					case AST_RULE:
					case AST_TOKEN:
					case AST_PROSE:
						continue;

					case AST_LITERAL:
						aterm = term;
						break;
				}

				assert(aterm->type == AST_LITERAL);

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

				t = ast_term::make_cs_literal(aterm->text());
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

WARN_UNUSED_RESULT int sid_output(const ast_grammar& grammar)
{
	output_section("types");

	output_section("terminals");

	if (!output_terminals(grammar))
	{
		return 0;
	}

	output_section("rules");

	/* TODO list rule declartations */

	for (auto rule : grammar.rules)
	{
		if (!output_rule(rule))
		{
			return 0;
		}
	}

	output_section("entry");

	writer->printf("\t%s;\n\n", grammar.rules.front()->name.chars());
	return 1;
}
