/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Tab Atkins Jr. Railroad Diagram Output.
 * See https://github.com/tabatkins/railroad-diagrams
 */

#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/rewrite.h"
#include "../rrd/node.h"
#include "../rrd/list.h"

#include "io.h"

static void print_indent(iwriter* writer, int n)
{
	assert(writer != nullptr);

	for (int i = 0; i < n; i++)
	{
		writer->puts("  ");
	}
}

/* javascript/json */
static int escputc(int c, iwriter* writer)
{
	size_t i;

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

	assert(writer != nullptr);

	for (i = 0; i < sizeof a / sizeof * a; i++)
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

int normal(const list& list)
{
	/*
	 * This is an imperfect heuristic to guess which item in a list
	 * is the most visually sensible default.
	 */

	if (list.size() == 2)
	{
		const struct node* a = list[0];
		const struct node* b = list[1];

		if (a == nullptr && b->type == NODE_RULE)
		{
			return 1;
		}

		if (a->type == NODE_RULE && b == nullptr)
		{
			return 0;
		}
	}

	return 0;
}

WARN_UNUSED_RESULT static int node_walk(iwriter* writer, const struct node* n, int depth)
{
	assert(writer != nullptr);

	if (n == nullptr)
	{
		print_indent(writer, depth);
		writer->puts("Skip()");
		return 1;
	}

	switch (n->type)
	{
		case NODE_LITERAL:
			print_indent(writer, depth);
			writer->puts("Terminal(\"");
			writer->escape(n->literal(), escputc);
			writer->puts("\")");

			break;

		case NODE_RULE:
			print_indent(writer, depth);
			writer->puts("NonTerminal(\"");
			writer->escape(n->name(), escputc);
			writer->puts("\")");

			break;

		case NODE_PROSE:
#if true
			print_indent(writer, depth);
			writer->puts("unimplemented-Prose(\"");
			writer->escape(n->prose(), escputc);
			writer->puts("\")");

			break;
#else
			fprintf(stderr, "unimplemented\n");
			return 0;
#endif

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		{
			bool more = false;

			print_indent(writer, depth);
			writer->printf("Choice(%d,\n", normal(n->alt()));

			if (n->type == NODE_ALT_SKIPPABLE)
			{
				print_indent(writer, depth + 1);
				writer->puts("Skip(),\n");
			}

			for (auto node : n->alt())
			{
				if (more)
				{
					writer->puts(",");
					writer->puts("\n");
				}
				more = true;
				if (!node_walk(writer, node, depth + 1))
				{
					return 0;
				}
			}
			writer->puts(")");

			break;
		}

		case NODE_SEQ:
		{
			bool more = false;
			
			print_indent(writer, depth);
			writer->puts("Sequence(\n");
			for (auto node : n->seq())
			{
				if (more)
				{
					writer->puts(",");
					writer->puts("\n");
				}
				more = true;
				if (!node_walk(writer, node, depth + 1))
				{
					return 0;
				}
			}
			writer->puts(")");

			break;
		}

		case NODE_LOOP:
			print_indent(writer, depth);
			writer->printf("%s(\n", n->loop.min == 0 ? "ZeroOrMore" : "OneOrMore");

			if (!node_walk(writer, n->loop.forward, depth + 1))
			{
				return 0;
			}
			writer->puts(",\n");

			if (!node_walk(writer, n->loop.backward, depth + 1))
			{
				return 0;
			}
			writer->puts(")");

			break;
	}
	return 1;
}

WARN_UNUSED_RESULT int rrta_output(const ast_grammar& grammar)
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

		writer->puts("add('");
		writer->escape(rule->name, escputc);
		writer->puts("', Diagram(\n");

		if (!node_walk(writer, rrd, 1))
		{
			return 0;
		}
		writer->puts("));\n");
		writer->puts("\n");

		node_free(rrd);
	}
	return 1;
}

