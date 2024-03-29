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

	if (c == '\"' || (unsigned char)c == '\\' || (unsigned char)c < ' ')
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


WARN_UNUSED_RESULT static int output_alts(const ast_alts& alts);

WARN_UNUSED_RESULT static int output_term_rule(const struct ast_rule *rule)
{
	writer->puts(",");
	output_string("rule");
	writer->puts(":");
	output_string(rule->name);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_token(const text& token)
{
	writer->puts(",");
	output_string("token");
	writer->puts(":");
	output_string(token);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_prose(const text& prose)
{
	writer->puts(",");
	output_string("prose");
	writer->puts(":");
	output_string(prose);
	return 1;
}

WARN_UNUSED_RESULT static int output_term_group(const ast_alts& group)
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

WARN_UNUSED_RESULT static int output_term_literal(const text& literal)
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
		case AST_EMPTY: output_string("empty"); break;
		case AST_RULE: output_string("rule"); break;
		case AST_LITERAL: output_string("cs_literal"); break;
		case AST_TOKEN: output_string("token"); break;
		case AST_PROSE: output_string("prose"); break;
		case AST_GROUP: output_string("group"); break;
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

	switch (term->type)
	{
		case AST_EMPTY:
			break;
		case AST_RULE:
			if (!output_term_rule(term->rule()))
			{
				return 0;
			}
			break;
		case AST_LITERAL:
			if (!output_term_literal(term->text()))
			{
				return 0;
			}
			break;
		case AST_TOKEN:
			if (!output_term_token(term->text()))
			{
				return 0;
			}
			break;
		case AST_PROSE:
			if (!output_term_prose(term->text()))
			{
				return 0;
			}
			break;
		case AST_GROUP:
			if (!output_term_group(term->group()))
			{
				return 0;
			}
			break;
	}

	writer->puts("}");
	return 1;
}

WARN_UNUSED_RESULT static int output_alt(const struct ast_alt* alt)
{
	writer->puts("{");
	output_string("$isa");
	writer->puts(":");
	output_string("alt");

	if (alt->terms.size() > 0)
	{
		writer->puts(",");
		output_string("terms");
		writer->puts(":");
		writer->puts("[");

		bool more = false;
		for (auto term : alt->terms)
		{
			if (more)
			{
				writer->puts(",");
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

		writer->puts("]");
	}
	writer->puts("}");

	return 1;
}

WARN_UNUSED_RESULT static int output_alts(const ast_alts& alts)
{
	writer->puts("[");

	bool more = false;
	for (auto alt : alts)
	{
		if (more)
		{
			writer->puts(",");
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

	if (rule->alts.size() > 0)
	{
		writer->puts(",");
		output_string("alts");
		writer->puts(":");
		if (!output_alts(rule->alts))
		{
			return 0;
		}
	}

	writer->puts("}");

	return 1;
}

WARN_UNUSED_RESULT int json_output(const ast_grammar& grammar)
{
	writer->puts("[");

	bool more = false;
	for (auto rule : grammar.rules)
	{
		if (more)
		{
			writer->puts(",");
		}
		else
		{
			more = true;
		}

		if (!output_rule(rule))
		{
			return 0;
		}
	}

	writer->puts("]\n");

	return 1;
}
