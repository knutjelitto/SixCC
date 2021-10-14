/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Extended Backus-Naur Form Output
 * As defined by ISO/IEC 14977:1996(E)
 *
 * TODO: fprintf(fout), instead of stdout
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>

#include "../txt.h"
#include "../ast.h"
#include "../rrd/node.h"
#include "../compiler_specific.h"

#include "io.h"

WARN_UNUSED_RESULT static int output_term(const struct ast_term *term);
WARN_UNUSED_RESULT static int output_group(const ast_alts& group);
WARN_UNUSED_RESULT static int output_group_alt(const struct ast_alt* alt);
WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt);
WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule);

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
	/* EBNF cannot express minimum term repetition; TODO: semantic checks for this */
	assert(term->min <= 1);

	struct
	{
		unsigned int min;
		unsigned int max;
		const char* s;
		const char* e;
	} a[] = {
		{ 1, 1, " (", " ) " },
		{ 1, 1, "",    ""   },
		{ 0, 1, " [", " ] " },
		{ 0, 0, " {", " } " }
	};

	const char* s = nullptr;
	const char* e = nullptr;

	for (int i = 0; i < sizeof a / sizeof * a; i++)
	{
		if (i == 0 && term->type != TYPE_GROUP)
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

	assert(s != nullptr && e != nullptr);

	writer->printf("%s", s);

	switch (term->type)
	{
		case TYPE_EMPTY:
			writer->puts(" \"\"");
			break;

		case TYPE_RULE:
			writer->putc(' ');
			writer->puts(term->rule()->name);
			break;

		case TYPE_CI_LITERAL:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case TYPE_CS_LITERAL:
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
		}
		break;

		case TYPE_TOKEN:
			writer->putc(' ');
			writer->puts(term->text());
			break;

		case TYPE_PROSE:
			/* TODO: escaping to somehow avoid ? */
			writer->printf(" ? %s ?", term->text().chars());
			break;

		case TYPE_GROUP:
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
	bool more = false;
	for (auto term : alt->terms)
	{
		if (more)
		{
			writer->putc(',');
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

	writer->printf("\n");
	writer->printf("\t;\n");
	writer->printf("\n");
	return 1;
}

WARN_UNUSED_RESULT int iso_ebnf_output(const ast_grammar& grammar)
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

