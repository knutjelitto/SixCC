/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Lukas Lueg Railroad DSL.
 * See https://github.com/lukaslueg/railroad_dsl
 * and the library it uses for rendering: https://github.com/lukaslueg/railroad
 */

#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/rewrite.h"
#include "../rrd/node.h"
#include "../rrd/list.h"
#include "../compiler_specific.h"

#include "io.h"

/* unknown provenance */
static int escputc(int c, iwriter* writer)
{
	assert(writer != nullptr);

	const struct
	{
		int c;
		const char* s;
	} a[] = {
		{ '\\', "\\\\" },
		{ '\"', "\\\"" },
		{ '/',  "\\/"  },

		{ '\b', "\\b"  },
		{ '\f', "\\f"  },
		{ '\n', "\\n"  },
		{ '\r', "\\r"  },
		{ '\t', "\\t"  }
	};

	for (int i = 0; i < sizeof a / sizeof * a; i++)
	{
		if (a[i].c == c)
		{
			return writer->puts(a[i].s);
		}
	}

	if (!isprint((unsigned char)c))
	{
		return writer->printf("\\u%04x", (unsigned char)c);
	}

	return writer->printf("%c", c);
}

/* TODO: centralise */
static size_t loop_label(unsigned min, unsigned max, char* s)
{
	assert(max >= min);
	assert(s != nullptr);

	if (max == 1 && min == 1)
	{
		return sprintf(s, "(exactly once)");
	}
	else if (max == 0 && min > 0)
	{
		return sprintf(s, "(at least %u times)", min);
	}
	else if (max > 0 && min == 0)
	{
		return sprintf(s, "(up to %d times)", max);
	}
	else if (max > 0 && min == max)
	{
		return sprintf(s, "(%u times)", max);
	}
	else if (max > 1 && min > 1)
	{
		return sprintf(s, "(%u-%u times)", min, max);
	}

	*s = '\0';

	return 0;
}

static void node_walk(iwriter* writer, const struct node* n)
{
	assert(writer != nullptr);

	if (n == nullptr)
	{
		writer->printf("!");

		return;
	}

	switch (n->type)
	{
		case NODE_LITERAL:
			writer->printf("\"");
			writer->escape(n->literal(), escputc);
			writer->printf("\"");

			break;

		case NODE_RULE:
			writer->printf("'");
			writer->escape(n->name(), escputc);
			writer->printf("'");

			break;

		case NODE_PROSE:
			/* TODO: escaping to somehow avoid ` */
			writer->printf("`");
			writer->escape(n->prose(), escputc);
			writer->printf("`");

			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		{
			bool more = false;
			writer->printf("<");
			for (auto node : n->alt())
			{
				if (more)
				{
					writer->printf(", ");
				}
				more = true;
				node_walk(writer, node);
			}
			writer->printf(">");

			if (n->type == NODE_ALT_SKIPPABLE)
			{
				writer->printf("?");
			}

			break;
		}

		case NODE_SEQ:
		{
			bool more = false;
			writer->puts("[");
			for (auto node : n->seq())
			{
				if (more)
				{
					writer->printf(" ");
				}
				more = true;
				node_walk(writer, node);
			}
			writer->puts("]");

			break;
		}

		case NODE_LOOP:
		{
			char s[128]; /* XXX */
			size_t r;

			r = loop_label(n->loop.min, n->loop.max, s);

			node_walk(writer, n->loop.forward);
			writer->printf("*");
			if (r > 0)
			{
				writer->printf("[`%s`", s);
			}
			node_walk(writer, n->loop.backward);
			if (r > 0)
			{
				writer->printf("]");
			}
		}

		break;
	}
}

WARN_UNUSED_RESULT int rrll_output(const ast_grammar& grammar)
{
	for (auto rule : grammar.rules)
	{
		struct node* rrd;

		if (!ast_to_rrd(rule, &rrd))
		{
			perror("ast_to_rrd");
			return 0;
		}

		if (prettify)
		{
			rrd_pretty(&rrd);
		}

		writer->printf("[`");
		writer->escape(rule->name, escputc);
		writer->printf("` ");

		node_walk(writer, rrd);
		writer->printf("]\n");

		node_free(rrd);
	}
	return 1;
}

