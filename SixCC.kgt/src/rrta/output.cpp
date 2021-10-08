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

int normal(const struct list* list)
{
	/*
	 * This is an imperfect heuristic to guess which item in a list
	 * is the most visually sensible default.
	 */

	if (list_count(list) == 2)
	{
		const struct node* a = list->node;
		const struct node* b = list->next->node;

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
		writer->printf("Skip()");
		return 1;
	}

	switch (n->type)
	{
		const struct list* p;

		case NODE_CI_LITERAL:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_CS_LITERAL:
			print_indent(writer, depth);
			writer->printf("Terminal(\"");
			writer->escape(n->literal(), escputc);
			writer->printf("\")");

			break;

		case NODE_RULE:
			print_indent(writer, depth);
			writer->printf("NonTerminal(\"");
			writer->escape(n->name(), escputc);
			writer->printf("\")");

			break;

		case NODE_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			print_indent(writer, depth);
			writer->printf("Choice(%d,\n", normal(n->altx()));

			if (n->type == NODE_ALT_SKIPPABLE)
			{
				print_indent(writer, depth + 1);
				writer->printf("Skip(),\n");
			}

			for (p = n->altx(); p != nullptr; p = p->next)
			{
				if (!node_walk(writer, p->node, depth + 1))
				{
					return 0;
				}
				if (p->next != nullptr)
				{
					writer->printf(",");
					writer->printf("\n");
				}
			}
			writer->printf(")");

			break;

		case NODE_SEQ:
			print_indent(writer, depth);
			writer->printf("Sequence(\n");
			for (p = n->seqx(); p != nullptr; p = p->next)
			{
				if (!node_walk(writer, p->node, depth + 1))
				{
					return 0;
				}
				if (p->next != nullptr)
				{
					writer->printf(",");
					writer->printf("\n");
				}
			}
			writer->printf(")");

			break;

		case NODE_LOOP:
			print_indent(writer, depth);
			writer->printf("%s(\n", n->u.loop.min == 0 ? "ZeroOrMore" : "OneOrMore");

			if (!node_walk(writer, n->u.loop.forward, depth + 1))
			{
				return 0;
			}
			writer->printf(",\n");

			if (!node_walk(writer, n->u.loop.backward, depth + 1))
			{
				return 0;
			}
			writer->printf(")");

			break;
	}
	return 1;
}

WARN_UNUSED_RESULT int rrta_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	for (p = grammar; p != nullptr; p = p->next)
	{
		struct node* rrd;

		if (!ast_to_rrd(p, &rrd))
		{
			perror("ast_to_rrd");
			return 0;
		}

		if (prettify)
		{
			rrd_pretty(&rrd);
		}

		/* TODO: pass in unsupported bitmap */
		if (!rewrite_rrd_ci_literals(rrd))
		{
			return 0;
		}

		writer->printf("add('");
		writer->escape(p->name(), escputc);
		writer->printf("', Diagram(\n");

		if (!node_walk(writer, rrd, 1))
		{
			return 0;
		}
		writer->printf("));\n");
		writer->printf("\n");

		node_free(rrd);
	}
	return 1;
}

