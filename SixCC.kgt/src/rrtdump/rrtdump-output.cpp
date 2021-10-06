/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Output a plaintext dump of the railroad tnode tree
 */

#include <assert.h>
#include <stdio.h>
#include <string.h>

#include "../txt.h"
#include "../ast.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/list.h"
#include "../rrd/tnode.h"
#include "../compiler_specific.h"

#include "io.h"

static void print_indent(iwriter* writer, int n)
{
	int i;

	assert(writer != nullptr);

	for (i = 0; i < n; i++)
	{
		writer->puts("    ");
	}
}

static void print_coords(iwriter *writer, const struct tnode *n)
{
	writer->printf(" w=%u a=%u d=%u", n->w, n->a, n->d);
}

static void tnode_walk(iwriter* writer, const struct tnode* n, int depth)
{
	assert(writer != nullptr);
	assert(n != nullptr);

	size_t i;

	switch (n->type)
	{
		case TNODE_RTL_ARROW:
			print_indent(writer, depth);
			writer->printf("RTL_ARROW");
			print_coords(writer, n);
			writer->printf("\n");

			break;

		case TNODE_LTR_ARROW:
			print_indent(writer, depth);
			writer->printf("LTR_ARROW");
			print_coords(writer, n);
			writer->printf("\n");

			break;

		case TNODE_ELLIPSIS:
			print_indent(writer, depth);
			writer->printf("ELLIPSIS");
			print_coords(writer, n);
			writer->printf("\n");

			break;

		case TNODE_CI_LITERAL:
		case TNODE_CS_LITERAL:
			print_indent(writer, depth);
			writer->printf("LITERAL");
			print_coords(writer, n);
			writer->printf(": \"%.*s\"%s\n", (int)n->u.literal.n, n->u.literal.p,
				n->type == TNODE_CI_LITERAL ? "/i" : "");

			break;

		case TNODE_PROSE:
			print_indent(writer, depth);
			writer->printf("PROSE");
			print_coords(writer, n);
			writer->printf(": %s\n", n->u.prose);

			break;

		case TNODE_COMMENT:
			print_indent(writer, depth);
			writer->printf("COMMENT");
			print_coords(writer, n);
			writer->printf(" \"%s\"", n->u.comment.s);
			writer->printf(": (\n");
			tnode_walk(writer, n->u.comment.tnode, depth + 1);
			print_indent(writer, depth);
			writer->printf(")\n");

			break;

		case TNODE_RULE:
			print_indent(writer, depth);
			writer->printf("RULE");
			print_coords(writer, n);
			writer->printf(": <%s>\n", n->u.name);

			break;

		case TNODE_VLIST:
			print_indent(writer, depth);
			writer->printf("VLIST");
			print_coords(writer, n);
			writer->printf(" o=%u", n->u.vlist.o); /* XXX: belongs in alt union */
			writer->printf(": [\n");
			for (i = 0; i < n->u.vlist.n; i++)
			{
				/* TODO: show tline for each alt */
				tnode_walk(writer, n->u.vlist.a[i], depth + 1);
			}
			print_indent(writer, depth);
			writer->printf("]\n");

			break;

		case TNODE_HLIST:
			print_indent(writer, depth);
			writer->printf("HLIST");
			print_coords(writer, n);
			writer->printf(": [\n");
			for (i = 0; i < n->u.hlist.n; i++)
			{
				tnode_walk(writer, n->u.hlist.a[i], depth + 1);
			}
			print_indent(writer, depth);
			writer->printf("]\n");

			break;
	}
}

static void
dim_mono_txt(const struct txt *t, unsigned *w, unsigned *a, unsigned *d)
{
	assert(t != nullptr);
	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	*w = t->n;
	*a = 0;
	*d = 1;
}

static void
dim_mono_string(const char *s, unsigned *w, unsigned *a, unsigned *d)
{
	assert(s != nullptr);
	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	*w = strlen(s);
	*a = 0;
	*d = 1;
}

WARN_UNUSED_RESULT int rrtdump_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	struct dim dim = {
		dim_mono_txt,
		dim_mono_string,
		0,
		0,
		0,
		0,
		0,
		0
	};

	for (p = grammar; p != nullptr; p = p->next)
	{
		struct tnode* tnode;
		struct node* rrd;

		if (!ast_to_rrd(p, &rrd))
		{
			perror("ast_to_rrd");
			return 0;
		}

		tnode = rrd_to_tnode(rrd, &dim);

		if (!prettify)
		{
			writer->printf("%s:\n", p->name.chars());
			tnode_walk(writer, tnode, 1);
			writer->printf("\n");
		}
		else
		{
			writer->printf("%s: (before prettify)\n", p->name.chars());
			tnode_walk(writer, tnode, 1);
			writer->printf("\n");

			tnode_free(tnode);

			rrd_pretty(&rrd);

			tnode = rrd_to_tnode(rrd, &dim);

			writer->printf("%s: (after prettify)\n", p->name.chars());
			tnode_walk(writer, tnode, 1);
			writer->printf("\n");
		}

		tnode_free(tnode);
		node_free(rrd);
	}
	return 1;
}

