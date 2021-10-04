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

static void
print_indent(FILE *f, int n)
{
	int i;

	assert(f != NULL);

	for (i = 0; i < n; i++) {
		fprintf(f, "  ");
	}
}

/* javascript/json */
static int escputc(int c, FILE* f)
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

	assert(f != NULL);

	for (i = 0; i < sizeof a / sizeof * a; i++)
	{
		if (a[i].c == c)
		{
			return fputs(a[i].s, f);
		}
	}

	if (!isprint((unsigned char)c))
	{
		return fprintf(f, "\\u%04x", (unsigned char)c);
	}

	return fprintf(f, "%c", c);
}

int normal(const struct list *list)
{
	/*
	 * This is an imperfect heuristic to guess which item in a list
	 * is the most visually sensible default.
	 */

	if (list_count(list) == 2) {
		const struct node *a = list->node;
		const struct node *b = list->next->node;

		if (a == NULL && b->type == NODE_RULE) {
			return 1;
		}

		if (a->type == NODE_RULE && b == NULL) {
			return 0;
		}
	}

	return 0;
}

WARN_UNUSED_RESULT static int node_walk(FILE* f, const struct node* n, int depth)
{
	assert(f != NULL);

	if (n == NULL)
	{
		print_indent(f, depth);
		fprintf(f, "Skip()");
		return 1;
	}

	switch (n->type)
	{
		const struct list* p;

		case NODE_CI_LITERAL:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_CS_LITERAL:
			print_indent(f, depth);
			fprintf(f, "Terminal(\"");
			escputt(&n->u.literal, f, escputc);
			fprintf(f, "\")");

			break;

		case NODE_RULE:
			print_indent(f, depth);
			fprintf(f, "NonTerminal(\"");
			escputs(n->u.name, f, escputc);
			fprintf(f, "\")");

			break;

		case NODE_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			print_indent(f, depth);
			fprintf(f, "Choice(%d,\n", normal(n->u.alt));

			if (n->type == NODE_ALT_SKIPPABLE)
			{
				print_indent(f, depth + 1);
				fprintf(f, "Skip(),\n");
			}

			for (p = n->u.alt; p != NULL; p = p->next)
			{
				if (!node_walk(f, p->node, depth + 1))
					return 0;
				if (p->next != NULL)
				{
					fprintf(f, ",");
					fprintf(f, "\n");
				}
			}
			fprintf(f, ")");

			break;

		case NODE_SEQ:
			print_indent(f, depth);
			fprintf(f, "Sequence(\n");
			for (p = n->u.seq; p != NULL; p = p->next)
			{
				if (!node_walk(f, p->node, depth + 1))
					return 0;
				if (p->next != NULL)
				{
					fprintf(f, ",");
					fprintf(f, "\n");
				}
			}
			fprintf(f, ")");

			break;

		case NODE_LOOP:
			print_indent(f, depth);
			fprintf(f, "%s(\n", n->u.loop.min == 0 ? "ZeroOrMore" : "OneOrMore");

			if (!node_walk(f, n->u.loop.forward, depth + 1))
				return 0;
			fprintf(f, ",\n");

			if (!node_walk(f, n->u.loop.backward, depth + 1))
				return 0;
			fprintf(f, ")");

			break;
	}
	return 1;
}

WARN_UNUSED_RESULT int rrta_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	for (p = grammar; p != NULL; p = p->next)
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

		printf("add('");
		escputs(p->name, stdout, escputc);
		printf("', Diagram(\n");

		if (!node_walk(stdout, rrd, 1))
		{
			return 0;
		}
		printf("));\n");
		printf("\n");

		node_free(rrd);
	}
	return 1;
}

