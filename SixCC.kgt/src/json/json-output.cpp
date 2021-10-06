/*
 * Copyright 2021 John Scott
 *
 * See LICENCE for the full copyright terms.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"

#include "io.h"

int escputc(int c, iwriter* writer)
{
	/*
		A simple way to deal with all escaped characters:
		'0020' . '10FFFF' - '"' - '\'
		is to convert them all to the valid '\u' hex hex hex hex format.
	 */

	if ((unsigned char)c == '\"' || (unsigned char)c == '\\' || (unsigned char)c < ' ')
	{
		return writer->printf("\\u00%02x", (unsigned char)c);
	}

	return writer->printf("%c", c);
}

void output_string(const char* string)
{
	writer->puts("\"");
	writer->escape(string, escputc);
	writer->puts("\"");
}

void output_string(const text& string)
{
	writer->puts("\"");
	writer->escape(string, escputc);
	writer->puts("\"");
}

void output_string(const struct txt& string)
{
	writer->puts("\"");
	writer->escape(string.p, escputc);
	writer->puts("\"");
}


WARN_UNUSED_RESULT static int output_alts(const struct ast_alt *alts);

WARN_UNUSED_RESULT static int output_term_rule(const struct ast_rule *rule)
{
	writer->puts(",");
	output_string("rule");
	writer->puts(":");
	output_string(rule->name);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_token(const char* token)
{
	writer->puts(",");
	output_string("token");
	writer->puts(":");
	output_string(token);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_prose(const char* prose)
{
	writer->puts(",");
	output_string("prose");
	writer->puts(":");
	output_string(prose);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_group(const struct ast_alt *group)
{
	writer->puts(",");
	output_string("group");
	writer->puts(":");
	if (!output_alts(group))
	{
		return 0;
	}
	return 1;
}

WARN_UNUSED_RESULT static int output_term_literal(const struct txt literal)
{
	writer->puts(",");
	output_string("literal");
	writer->puts(":");
	output_string(literal);
	return 1;
}

WARN_UNUSED_RESULT static int output_term(const struct ast_term* term)
{
	writer->puts("{");
	output_string("$isa");
	writer->puts(":");
	switch (term->type)
	{
		case TYPE_EMPTY: output_string("empty"); break;
		case TYPE_RULE: output_string("rule"); break;
		case TYPE_CS_LITERAL: output_string("cs_literal"); break;
		case TYPE_CI_LITERAL: output_string("ci_literal"); break;
		case TYPE_TOKEN: output_string("token"); break;
		case TYPE_PROSE: output_string("prose"); break;
		case TYPE_GROUP: output_string("group"); break;
		default: writer->puts("null"); break;
	}

	if (term->min != 1)
	{
		writer->puts(",");
		output_string("min");
		writer->puts(":");
		writer->printf("%d", term->min);
	}

	if (term->max != 1)
	{
		writer->puts(",");
		output_string("max");
		writer->puts(":");
		writer->printf("%d", term->max);
	}

	if (term->invisible != 0)
	{
		writer->puts(",");
		output_string("invisible");
		writer->puts(":true");
	}

	switch (term->type)
	{
		case TYPE_EMPTY:
			break;
		case TYPE_RULE:
			if (!output_term_rule(term->u.rule))
				return 0;
			break;
		case TYPE_CS_LITERAL:
		case TYPE_CI_LITERAL:
			if (!output_term_literal(term->u.literal))
			{
				return 0;
			}
			break;
		case TYPE_TOKEN:
			if (!output_term_token(term->u.token))
			{
				return 0;
			}
			break;
		case TYPE_PROSE:
			if (!output_term_prose(term->u.prose))
				return 0;
			break;
		case TYPE_GROUP:
			if (!output_term_group(term->u.group))
				return 0;
			break;
	}

	writer->puts("}");
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	const struct ast_term* term;

	writer->puts("{");
	output_string("$isa");
	writer->puts(":");
	output_string("alt");

	if (alt->invisible != 0)
	{
		writer->puts(",");
		output_string("invisible");
		writer->puts(":true");
	}

	if (alt->terms)
	{
		writer->puts(",");
		output_string("terms");
		writer->puts(":");
		writer->puts("[");

		for (term = alt->terms; term != NULL; term = term->next)
		{
			if (term != alt->terms)
			{
				writer->puts(",");
			}

			if (!output_term(term))
			{
				return 0;
			}
		}

		writer->puts("]");
	}
	writer->puts("}");

	return 1;
}

WARN_UNUSED_RESULT static int output_alts(const struct ast_alt* alts)
{
	const struct ast_alt* alt;

	writer->puts("[");

	for (alt = alts; alt != NULL; alt = alt->next)
	{
		if (alt != alts)
		{
			writer->puts(",");
		}

		if (!output_alt(alt))
		{
			return 0;
		}
	}

	writer->puts("]");
	return 1;
}

WARN_UNUSED_RESULT static int output_rule(const struct ast_rule* rule)
{
	writer->puts("{");
	output_string("$isa");
	writer->puts(":");
	output_string("rule");

	if (rule->name.length() > 0)
	{
		writer->puts(",");
		output_string("name");
		writer->puts(":");
		output_string(rule->name);
	}

	if (rule->alts)
	{
		writer->puts(",");
		output_string("alts");
		writer->puts(":");
		if (!output_alts(rule->alts))
			return 0;
	}

	writer->puts("}");

	return 1;
}

WARN_UNUSED_RESULT int json_output(const struct ast_rule* grammar)
{
	const struct ast_rule* rule;

	writer->puts("[");

	for (rule = grammar; rule != NULL; rule = rule->next)
	{
		if (rule != grammar)
		{
			writer->puts(",");
		}

		if (!output_rule(rule))
		{
			return 0;
		}
	}

	writer->puts("]\n");

	return 1;
}
