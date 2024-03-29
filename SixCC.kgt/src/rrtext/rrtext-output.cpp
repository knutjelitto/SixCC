﻿/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Railroad Diagram ASCII-Art Output
 *
 * Output a plaintext diagram of the abstract representation of railroads
 */

#define _CRT_SECURE_NO_WARNINGS
#define _BSD_SOURCE
#define _DEFAULT_SOURCE

#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdarg.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"
#include "../compiler_specific.h"
#include "../strings.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/rrd.h"
#include "../rrd/list.h"
#include "../rrd/tnode.h"

#include "io.h"

struct render_context
{
	char **lines = nullptr;
	char *scratch = nullptr;
	/* in character indicies */
	unsigned x = 0;
	unsigned y = 0;
};

static void node_walk_render(const struct tnode *n, struct render_context *ctx);

static void bprintf(struct render_context* ctx, const char* fmt, ...)
{
	assert(ctx != nullptr);
	assert(ctx->scratch != nullptr);
	assert(ctx->x >= 0 && ctx->x <= 10000);
	assert(ctx->y >= 0 && ctx->y <= 10000);

	va_list ap{};
	va_start(ap, fmt);
	unsigned n = vsprintf(ctx->scratch, fmt, ap);
	assert(n <= 10000);
	va_end(ap);

	assert(ctx->x >= 0 && ctx->x <= 10000);
	assert(ctx->y >= 0 && ctx->y <= 10000);
	memcpy(ctx->lines[ctx->y] + ctx->x, ctx->scratch, n);

	ctx->x += n;
}

/* made-up to suit text output */
static void escputc(struct render_context* ctx, char c)
{
	assert(ctx != nullptr);

	switch (c)
	{
		case '\\': bprintf(ctx, "\\\\"); return;
		case '\"': bprintf(ctx, "\\\""); return;

		case '\a': bprintf(ctx, "\\a"); return;
		case '\b': bprintf(ctx, "\\b"); return;
		case '\f': bprintf(ctx, "\\f"); return;
		case '\n': bprintf(ctx, "\\n"); return;
		case '\r': bprintf(ctx, "\\r"); return;
		case '\t': bprintf(ctx, "\\t"); return;
		case '\v': bprintf(ctx, "\\v"); return;

		default:
			break;
	}

	if (!isprint((unsigned char)c))
	{
		bprintf(ctx, "\\x%02x", (unsigned char)c);
		return;
	}

	bprintf(ctx, "%c", c);
}

static void center(unsigned *lhs, unsigned *rhs, unsigned space, unsigned w)
{
	assert(lhs != nullptr);
	assert(rhs != nullptr);
	assert(space >= w);

	*lhs = (space - w) / 2;
	*rhs = (space - w) - *lhs;
}

static void justify(render_context* ctx, const tnode* tnode, unsigned space)
{
	assert(tnode != nullptr);
	assert(space >= tnode->w);

	unsigned lhs, rhs;
	unsigned i;

	center(&lhs, &rhs, space, tnode->w);

	for (i = 0; i < lhs; i++)
	{
		bprintf(ctx, tnode->type == TNODE_ELLIPSIS ? " " : "\x12");
	}

	node_walk_render(tnode, ctx);

	for (i = 0; i < rhs; i++)
	{
		bprintf(ctx, tnode->type == TNODE_ELLIPSIS ? " " : "\x12");
	}
}

static void bars(struct render_context* ctx, unsigned n, unsigned w)
{
	unsigned i;
	unsigned x;

	x = ctx->x;

	for (i = 0; i < n; i++)
	{
		bprintf(ctx, "\x0F");
		ctx->x += w - 2;
		bprintf(ctx, "\x0F");
		ctx->y++;
		ctx->x = x;
	}
}

static const char* tile[][2] =
{
	{ nullptr, nullptr },    /* \x00 */
	{ "^", "\xe2\x95\xb0" }, /* \x01 '╰' */
	{ ",", "\xe2\x95\xad" }, /* \x02 '╭' */
	{ ".", "\xe2\x95\xae" }, /* \x03 '╮' */
	{ "v", "\xe2\x95\xad" }, /* \x04 '╭' */
	{ "+", "\xe2\x94\xbc" }, /* \x05 '┼' */
	{ "`", "\xe2\x95\xb0" }, /* \x06 '╰' */

	/* whitespace, not used because of rtrim() */
	{ nullptr, nullptr }, /* \x07 */
	{ nullptr, nullptr }, /* \x08 */
	{ nullptr, nullptr }, /* \x09 */
	{ nullptr, nullptr }, /* \x0A */
	{ nullptr, nullptr }, /* \x0B */
	{ nullptr, nullptr }, /* \x0C */
	{ nullptr, nullptr }, /* \x0D */

	{ "'", "\xe2\x95\xaf" }, /* \x0E '╯' */
	{ "|", "\xe2\x94\x82" }, /* \x0F '│' */
	{ ">", "\xe2\x95\xad" }, /* \x10 '╭' */
	{ "<", "\xe2\x95\xaf" }, /* \x11 '╯' */

	{ "-", "\xe2\x94\x80" }, /* \x12 '─' */
	{ "|", "\xe2\x94\x9c" }, /* \x13 '├' */
	{ "|", "\xe2\x94\xa4" }, /* \x14 '┤' */
	{ ">", "\xe2\x95\xb0" }, /* \x15 '╰' */
	{ "<", "\xe2\x95\xae" }, /* \x17 '╮' */
	{ "<", "\xe2\x94\xbc" }, /* \x18 '┼' */
	{ "v", "\xe2\x95\xae" }, /* \x19 '╮' */
	{ ">", "\xe2\x94\xbc" }, /* \x1A '┼' */
	{ "^", "\xe2\x95\xaf" }  /* \x1B '╯' */
};

static void tile_puts(const char* s, int utf8)
{
	const char* p;

	for (p = s; *p != '\0'; p++)
	{
		if ((unsigned char)*p < sizeof(tile) / sizeof(*tile))
		{
			writer->puts(tile[(unsigned)*p][utf8]);
			continue;
		}

		writer->putc(*p);
	}
}

static void render_tline(struct render_context* ctx, tline tline, int rhs)
{
	const char* a;

	assert(ctx != nullptr);

	switch (tline)
	{
		case TLINE_A: a = "\x11\x01"; break;
		case TLINE_a: a = "\x1A\x15"; break;
		case TLINE_B: a = "\x02\x03"; break;
		case TLINE_C: a = "\x16\x04"; break;
		case TLINE_c: a = "\x18\x10"; break;
		case TLINE_D: a = "\x17\x05"; break;
		case TLINE_d: a = "\x05\x19"; break;
		case TLINE_E: a = "\x06\x0E"; break;
		case TLINE_F: a = "\x0F\x0F"; break;
		case TLINE_G: a = "\x01\x11"; break;
		case TLINE_g: a = "\x15\x1A"; break;
		case TLINE_H: a = "\x04\x16"; break;
		case TLINE_h: a = "\x10\x18"; break;
		case TLINE_I: a = "\x01\x11"; break;
		case TLINE_i: a = "\x15\x1A"; break;
		case TLINE_J: a = "\x12\x12"; break;

		default:
			a = "??";
			break;
	}

	bprintf(ctx, "%c", a[rhs]);
}

static void render_vlist(const struct tnode* n, struct render_context* ctx)
{
	unsigned x, y;
	size_t j;

	assert(n != nullptr);
	assert(n->type == TNODE_VLIST);
	assert(ctx != nullptr);

	x = ctx->x;
	y = ctx->y;

	/*
	 * .o is in terms of indicies; here we would iterate and add the y-distance
	 * for each of those nodes. That'd be .a for the topmost node, plus the height
	 * of each subsequent node and the depth of each node above it.
	 */
	assert(n->vlist.o <= 1); /* currently only implemented for one node above the line */
	if (n->vlist.o == 1)
	{
		ctx->y -= n->a;
	}

	/*
	 * A vlist of 0 items is a special case, meaning to draw
	 * a horizontal line only.
	 */
	if (n->vlist.n == 0)
	{
		size_t i;

		for (i = 0; i < n->w; i++)
		{
			bprintf(ctx, "\x12");
		}
	}
	else
	{
		for (j = 0; j < n->vlist.n; j++)
		{
			ctx->x = x;

			render_tline(ctx, n->vlist.b[j], 0);
			justify(ctx, n->vlist.a[j], n->w - 2);
			render_tline(ctx, n->vlist.b[j], 1);

			if (j + 1 < n->vlist.n)
			{
				ctx->y++;
				ctx->x = x;
				bars(ctx, n->vlist.a[j]->d + n->vlist.a[j + 1]->a, n->w);
			}
		}
	}

	ctx->y = y;
}

static void render_hlist(const tnode* n, render_context* ctx)
{
	assert(n != nullptr);
	assert(n->type == TNODE_HLIST);
	assert(ctx != nullptr);

	bool more = false;
	for (auto tn : n->hlist)
	{
		if (more)
		{
			bprintf(ctx, "\x12\x12");
		}
		else
		{
			more = true;
		}
		node_walk_render(tn, ctx);
	}
}

static void render_comment(struct render_context* ctx, const struct tnode* tnode)
{
	assert(ctx != nullptr);
	assert(tnode != nullptr);
	assert(tnode->type == TNODE_COMMENT);

	unsigned x, y;
	unsigned lhs, rhs;

	x = ctx->x;
	y = ctx->y;

	justify(ctx, tnode->commented, tnode->w);

	assert(tnode->text.length() <= tnode->w);
	center(&lhs, &rhs, tnode->w, tnode->text.length());

	ctx->x = x + lhs;
	ctx->y = y + tnode->d - 1;

	bprintf(ctx, "%s", tnode->text.chars());

	ctx->x += rhs;
	ctx->y = y;

	assert(ctx->x == x + tnode->w);
}

static void render_txt(struct render_context* ctx, const text& text)
{
	size_t i;

	for (i = 0; i < text.length(); i++)
	{
		escputc(ctx, text[i]);
	}
}

static void render_string(struct render_context *ctx, const text& text)
{
	render_txt(ctx, text);
}

static void node_walk_render(const struct tnode* n, struct render_context* ctx)
{
	assert(ctx != nullptr);

	switch (n->type)
	{
		case TNODE_RTL_ARROW:
			bprintf(ctx, "%.*s", (int)n->w, "<");
			break;

		case TNODE_LTR_ARROW:
			bprintf(ctx, "%.*s", (int)n->w, ">");
			break;

		case TNODE_ELLIPSIS:
			bprintf(ctx, ":");
			break;

		case TNODE_LITERAL:
			bprintf(ctx, " \"");
			render_txt(ctx, n->text);
			bprintf(ctx, "\" ");
			break;

		case TNODE_PROSE:
			bprintf(ctx, "? ");
			render_string(ctx, n->text);
			bprintf(ctx, " ?");
			break;

		case TNODE_COMMENT:
			render_comment(ctx, n);
			break;

		case TNODE_RULE:
			bprintf(ctx, " ");
			render_string(ctx, n->text);
			bprintf(ctx, " ");
			break;

		case TNODE_VLIST:
			render_vlist(n, ctx);
			break;

		case TNODE_HLIST:
			render_hlist(n, ctx);
			break;
	}
}

static void render_rule(const struct tnode* node, int utf8)
{
	struct render_context ctx;
	unsigned w, h;
	unsigned i;

	w = node->w + 8;
	h = node->a + node->d;

	ctx.lines = (char**)xmalloc(sizeof * ctx.lines * h + 1);
	for (i = 0; i < h; i++)
	{
		ctx.lines[i] = (char*)xmalloc((size_t)w + 1);
		memset(ctx.lines[i], ' ', w);
		ctx.lines[i][w] = '\0';
	}

	ctx.x = 0;
	ctx.y = 0;
	ctx.scratch = (char*)xmalloc(w + 1);

	ctx.y = node->a;
	bprintf(&ctx, "\x0F\x13\x12\x12");

	ctx.x = w - 4;
	bprintf(&ctx, "\x12\x12\x14\x0F");

	ctx.x = 4;
	ctx.y = node->a;
	node_walk_render(node, &ctx);

	for (i = 0; i < h; i++)
	{
		ctx.lines[i] = xstrdup(text(ctx.lines[i]).rtrim().chars());
		writer->puts("    ");
		tile_puts(ctx.lines[i], utf8);
		writer->puts("\n");
		free(ctx.lines[i]);
	}

	free(ctx.lines);
	free(ctx.scratch);
}

static void dim_mono_txt(const text& text, unsigned* w, unsigned* a, unsigned* d)
{
	size_t i;
	unsigned n;

	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	n = 0;

	for (i = 0; i < text.length(); i++)
	{
		switch (text[i])
		{
			case '\\':
			case '\"':
			case '\a':
			case '\b':
			case '\f':
			case '\n':
			case '\r':
			case '\t':
			case '\v':
				n += 2;
				continue;

			default:
				break;
		}

		if (!isprint((unsigned char)text[i]))
		{
			n += 4;
			continue;
		}

		n += 1;
	}

	*w = n + 2;
	*a = 0;
	*d = 1;
}

static void dim_mono_string(const text& text, unsigned *w, unsigned *a, unsigned *d)
{
	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	dim_mono_txt(text, w, a, d);
}

void rr_output(const ast_grammar& grammar, struct dim* dim, int utf8)
{
	assert(dim != nullptr);

	for (auto rule : grammar.rules)
	{
		struct node* rrd;
		struct tnode* tnode;

		if (!ast_to_rrd(rule, &rrd))
		{
			perror("ast_to_rrd");
			return;
		}

		if (prettify)
		{
			rrd_pretty(&rrd);
		}

		tnode = rrd_to_tnode(rrd, dim);

		node_free(rrd);

		writer->printf("%s:\n", rule->name.chars());
		render_rule(tnode, utf8);
		writer->printf("\n");

		tnode_free(tnode);
	}
}

WARN_UNUSED_RESULT int rrutf8_output(const ast_grammar& grammar)
{
	struct dim dim =
	{
		dim_mono_txt,
		dim_mono_string,
		2,
		0,
		2,
		0,
		2,
		1
	};

	rr_output(grammar, &dim, 1);
	return 1;
}

WARN_UNUSED_RESULT int rrtext_output(const ast_grammar& grammar)
{
	struct dim dim =
	{
		dim_mono_txt,
		dim_mono_string,
		2,
		0,
		2,
		0,
		2,
		1
	};

	rr_output(grammar, &dim, 0);
	return 1;
}

