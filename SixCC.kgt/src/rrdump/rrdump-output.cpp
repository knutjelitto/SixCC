/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Output a plaintext dump of the railroad tree
 */

#include <assert.h>
#include <stdio.h>
#include <string.h>

#include "../txt.h"
#include "../ast.h"
#include "../compiler_specific.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/list.h"

#include "io.h"

static void print_indent(iwriter* writer, int n)
{
	assert(writer != nullptr);

	int i;

	for (i = 0; i < n; i++)
	{
		writer->puts("    ");
	}
}

static void node_walk(iwriter* f, const struct node* n, int depth)
{
	assert(f != nullptr);

	if (n == nullptr)
	{
		print_indent(f, depth);
		f->puts("SKIP\n");
		return;
	}

	switch (n->type)
	{
		case NODE_LITERAL:
			print_indent(f, depth);
			f->printf("LITERAL: \"%.*s\"\n", (int)n->literal().length(), n->literal().chars());
			break;

		case NODE_RULE:
			print_indent(f, depth);
			f->printf("NAME: <%s>\n", n->name().chars());
			break;

		case NODE_PROSE:
			print_indent(f, depth);
			f->printf("PROSE: ?%s?\n", n->prose().chars());

			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			print_indent(f, depth);
			f->printf("%s: [\n", n->type == NODE_ALT ? "ALT" : "ALT|SKIP");
			for (auto node : n->alt())
			{
				node_walk(f, node, depth + 1);
			}
			print_indent(f, depth);
			f->puts("]\n");

			break;

		case NODE_SEQ:
			print_indent(f, depth);
			f->printf("SEQ: [\n");
			for (auto node : n->seq())
			{
				node_walk(f, node, depth + 1);
			}
			print_indent(f, depth);
			f->puts("]\n");

			break;

		case NODE_LOOP:
			print_indent(f, depth);
			f->printf("LOOP:\n");

			if (n->loop.forward != nullptr)
			{
				print_indent(f, depth + 1);
				f->puts(".forward:\n");
				node_walk(f, n->loop.forward, depth + 2);
			}

			if (n->loop.backward != nullptr)
			{
				print_indent(f, depth + 1);
				f->puts(".backward:\n");
				node_walk(f, n->loop.backward, depth + 2);
			}

			break;
	}
}

WARN_UNUSED_RESULT int rrdump_output(const ast_grammar& grammar)
{
	for (auto rule : grammar.rules)
	{
		struct node* rrd;

		if (!ast_to_rrd(rule, &rrd))
		{
			perror("ast_to_rrd");
			return 0;
		}

		if (!prettify)
		{
			writer->printf("%s:\n", rule->name.chars());
			node_walk(writer, rrd, 1);
			writer->printf("\n");
		}
		else
		{
			writer->printf("%s: (before prettify)\n", rule->name.chars());
			node_walk(writer, rrd, 1);
			writer->printf("\n");

			rrd_pretty(&rrd);

			writer->printf("%s: (after prettify)\n", rule->name.chars());
			node_walk(writer, rrd, 1);
			writer->printf("\n");
		}

		node_free(rrd);
	}
	return 1;
}

