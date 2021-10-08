/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * parcon.railroad DSL Railroad Diagram Output.
 * http://www.opengroove.org/parcon/parcon-tutorial.html
 *
 * Output adapted from the following example:
 * https://github.com/javawizard/everything/blob/4912dc91f7fe458d2324177d678618c22961ee99/projects/misc/sd-example.py
 */

#include <assert.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdarg.h>
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
	int i;

	assert(writer != nullptr);

	for (i = 0; i < n; i++)
	{
		writer->puts("  ");
	}
}

/* python */
static int escputc(int c, iwriter* writer)
{
	const struct
	{
		int c;
		const char* s;
	} a[] = {
		{ '\\', "\\\\" },
		{ '\"', "\\\"" },

		{ '\a', "\\a"  },
		{ '\b', "\\b"  },
		{ '\f', "\\f"  },
		{ '\n', "\\n"  },
		{ '\r', "\\r"  },
		{ '\t', "\\t"  },
		{ '\v', "\\v"  }
	};

	assert(writer != nullptr);

	for (int i = 0; i < sizeof a / sizeof * a; i++)
	{
		if (a[i].c == c)
		{
			return writer->puts(a[i].s);
		}
	}

	if (!isprint((unsigned char)c))
	{
		return writer->printf("\\%03o", (unsigned char)c);
	}

	return writer->printf("%c", c);
}

static void print_comment(iwriter *f, int depth, const char *fmt, ...)
{
	assert(f != nullptr);
	assert(fmt != nullptr);

	va_list ap{};
	va_start(ap, fmt);

	print_indent(f, depth);
	f->puts("comment(\"");
	f->vprintf(fmt, ap);
	f->puts("\")");

	va_end(ap);
}

WARN_UNUSED_RESULT static int node_walk(iwriter* writer, const struct node* n, int depth)
{
	assert(writer != nullptr);

	if (n == nullptr)
	{
		print_indent(writer, depth);
		writer->puts("Nothing()");

		return 1;
	}

	assert(!n->invisible);

	switch (n->type)
	{
		case NODE_CI_LITERAL:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_CS_LITERAL:
			print_indent(writer, depth);
			writer->printf("text(\"");
			writer->escape(n->literal(), escputc);
			writer->printf("\")");

			break;

		case NODE_RULE:
			print_indent(writer, depth);
			writer->printf("production(\"");
			writer->escape(n->name(), escputc);
			writer->printf("\")");

			break;

		case NODE_PROSE:
			fprintf(stderr, "unimplemented\n");
			return 0;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
		{
			bool more = false;

			print_indent(writer, depth);
			writer->printf("Or(\n");

			if (n->type == NODE_ALT_SKIPPABLE)
			{
				print_indent(writer, depth + 1);
				writer->printf("Nothing(),\n");
			}

			for (auto node : n->alt())
			{
				if (more)
				{
					writer->printf(",");
					writer->printf("\n");
				}
				more = true;
				if (!node_walk(writer, node, depth + 1))
				{
					return 0;
				}
			}
			writer->printf("\n");

			print_indent(writer, depth);
			writer->printf(")");

			break;
		}

		case NODE_SEQ:
		{
			bool more = false;
			print_indent(writer, depth);
			writer->printf("Then(\n");
			for (auto node : n->seq())
			{
				if (more)
				{
					writer->printf(",");
					writer->printf("\n");
				}
				more = true;
				if (!node_walk(writer, node, depth + 1))
				{
					return 0;
				}
			}
			writer->printf("\n");

			print_indent(writer, depth);
			writer->printf(")");

			break;
		}

		case NODE_LOOP:
			print_indent(writer, depth);
			writer->printf("Loop(\n");

			if (!node_walk(writer, n->u.loop.forward, depth + 1))
			{
				return 0;
			}
			writer->printf(",\n");

			if (n->u.loop.max == 1 && n->u.loop.min == 1)
			{
				print_comment(writer, depth + 1, "(exactly once)");
				assert(n->u.loop.backward == nullptr);
			}
			else if (n->u.loop.max == 0 && n->u.loop.min > 0)
			{
				print_comment(writer, depth + 1, "(at least %d times)", n->u.loop.min);
				assert(n->u.loop.backward == nullptr);
			}
			else if (n->u.loop.max > 0 && n->u.loop.min == 0)
			{
				print_comment(writer, depth + 1, "(up to %d times)", n->u.loop.max);
				assert(n->u.loop.backward == nullptr);
			}
			else if (n->u.loop.max > 0 && n->u.loop.min == n->u.loop.max)
			{
				print_comment(writer, depth + 1, "(%d times)", n->u.loop.max);
				assert(n->u.loop.backward == nullptr);
			}
			else if (n->u.loop.max > 1 && n->u.loop.min > 1)
			{
				print_comment(writer, depth + 1, "(%d-%d times)", n->u.loop.min, n->u.loop.max);
				assert(n->u.loop.backward == nullptr);
			}
			else
			{
				if (!node_walk(writer, n->u.loop.backward, depth))
				{
					return 0;
				}
			}

			writer->printf("\n");

			print_indent(writer, depth);
			writer->printf(")");
			break;
	}
	return 1;
}

WARN_UNUSED_RESULT int rrparcon_output(const struct ast_rule* grammar)
{
	const struct ast_rule* p;

	writer->printf("#!/usr/bin/env python\n");
	writer->printf("# -*- coding: utf-8 -*-\n");
	writer->printf("\n");

	writer->printf("import sys\n");
	writer->printf("from collections import OrderedDict\n");
	writer->printf("\n");
	writer->printf("from parcon.railroad import Then, Or, Token, Loop, Bullet, Nothing\n");
	writer->printf("from parcon.railroad import PRODUCTION, TEXT, DESCRIPTION\n");
	writer->printf("import parcon.railroad.raildraw\n");
	writer->printf("\n");

	writer->printf("comment    = lambda t: Token(DESCRIPTION, t)\n");
	writer->printf("production = lambda t: Token(PRODUCTION, t)\n");
	writer->printf("text       = lambda t: Token(TEXT, t)\n");
	writer->printf("\n");

	writer->printf("productions = OrderedDict([\n");

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
			return 0;

		writer->printf("  (\n");
		writer->printf("    \"");
		writer->escape(p->name(), escputc);
		writer->printf("\",\n");
		writer->printf("    Then(\n");
		writer->printf("      Bullet(),\n");

		if (!node_walk(writer, rrd, 3))
		{
			return 0;
		}
		writer->printf(",");
		writer->printf("\n");

		writer->printf("      Bullet()\n");
		writer->printf("    )\n");
		writer->printf("  )");
		if (p->next != nullptr)
		{
			writer->printf(",");
		}
		writer->printf("\n");

		node_free(rrd);
	}

	writer->printf("])\n");
	writer->printf("\n");

	writer->printf("options = {\n");

	writer->printf("  \"raildraw_arrow_width\":       8,\n"); /* 0 also looks nice */
	writer->printf("  \"raildraw_arrow_height\":      8,\n");
	writer->printf("  \"raildraw_then_before_arrow\": 8,\n");
	writer->printf("  \"raildraw_then_after_arrow\":  0,\n");
	writer->printf("  \"raildraw_or_before\":         8,\n");
	writer->printf("  \"raildraw_or_after\":          8,\n");

	writer->printf("  \"raildraw_token_padding\":     2,\n");
	writer->printf("  \"raildraw_bullet_radius\":     4,\n");
	writer->printf("  \"raildraw_or_radius\":        10,\n");
	writer->printf("  \"raildraw_line_size\":         2,\n");

	writer->printf("  \"raildraw_title_before\":     20,\n");
	writer->printf("  \"raildraw_title_after\":      30,\n");
	writer->printf("  \"raildraw_scale\":             1\n");

	writer->printf("}\n");
	writer->printf("\n");

	writer->printf("# parcon.railroad.raildraw.draw_to_image(sys.argv[1], productions, options, sys.argv[2], True)\n");
	writer->printf("parcon.railroad.raildraw.draw_to_png(productions, options, sys.argv[2], True)\n");
	writer->printf("\n");

	return 1;
}
