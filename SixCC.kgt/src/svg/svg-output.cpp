/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Railroad Diagram SVG Output
 *
 * Output a SVG diagram of the abstract representation of railroads.
 * The subset of SVG here is intended to suit RFC 7996.
 */

#define _BSD_SOURCE
#define _DEFAULT_SOURCE

#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include <math.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/rrd.h"
#include "../rrd/list.h"
#include "../rrd/tnode.h"

#include "io.h"
#include "path.h"

extern const char *css_file;

struct render_context
{
	render_context(const ast_grammar& grammar) : grammar(grammar)
	{
	}

	int x = 0;
	int y = 0;
	path *paths = nullptr;
	const ast_grammar& grammar;
};

static void node_walk_render(const struct tnode *n, struct render_context *ctx, const char *base);

static int svg_escputc(int c, iwriter* writer)
{
	assert(writer != nullptr);

	const char* name;

	switch (c)
	{
		case '&': return writer->puts("&amp;");
		case '<': return writer->puts("&lt;");
		case '>': return writer->puts("&gt;");

		case '\a': name = "BEL"; break;
		case '\b': name = "BS";  break;
		case '\f': name = "FF";  break;
		case '\n': name = "LF";  break;
		case '\r': name = "CR";  break;
		case '\t': name = "TAB"; break;
		case '\v': name = "VT";  break;

		default:
			if (!isprint((unsigned char)c))
			{
				return writer->printf("&#x3008;<tspan class='hex'>%02X</tspan>&#x3009;", (unsigned char)c);
			}

			return writer->printf("%c", c);
	}

	return writer->printf("&#x3008;<tspan class='esc'>%s</tspan>&#x3009;", name);
}

static void svg_text(struct render_context* ctx, unsigned w, const text& t, const char* klass)
{
	unsigned mid;

	assert(ctx != nullptr);

	mid = w / 2;

	writer->printf("    <text x='%u' y='%u' text-anchor='middle'", ctx->x + mid, ctx->y + 5);

	if (klass != nullptr)
	{
		writer->printf(" class='%s'", klass);
	}

	writer->puts(">");

	writer->escape(t, svg_escputc);

	writer->puts("</text>\n");
}

static void svg_string(struct render_context *ctx, unsigned w, const text& text, const char * klass)
{
	assert(ctx != nullptr);

	svg_text(ctx, w, text, klass);
}

static void svg_rect(struct render_context *ctx, unsigned w, unsigned r, const char * klass)
{
	writer->printf("    <rect x='%u' y='%u' height='%u' width='%u' rx='%u' ry='%u'",
		ctx->x, ctx->y - 10,
		20, w,
		r, r);

	if (klass != nullptr) {
		writer->printf(" class='%s'", klass);
	}

	writer->printf("/>\n");
}

static void svg_textbox(struct render_context *ctx, const text& text, unsigned w, unsigned r, const char * klass)
{
	svg_rect(ctx, w, r, klass);
	svg_text(ctx, w, text, klass);

	ctx->x += w;
}

static void svg_prose(struct render_context *ctx, const text& text, unsigned w)
{
	assert(ctx != nullptr);

	svg_string(ctx, w, text, "prose");

	ctx->x += w;
}

static void svg_ellipsis(struct render_context *ctx, unsigned w, unsigned h)
{
	ctx->x += 10;
	ctx->y -= 10;

	writer->printf("    <line x1='%u' y1='%u' x2='%u' y2='%u' class='ellipsis'/>",
		ctx->x - 5, ctx->y + 5,
		ctx->x + w - 5, ctx->y + h + 5);

	ctx->x += w;
	ctx->y += 10;
}

static void svg_arrow(struct render_context *ctx, unsigned x, unsigned y, int rtl)
{
	unsigned h = 6;

	assert(ctx != nullptr);

	/* XXX: should be markers, but aren't for RFC 7996 */
	/* 2 for optical correction */
	writer->printf("    <path d='M%d %u l%d %u v%d z' class='arrow'/>\n",
		(int) x + (rtl ? -2 : 2), y, rtl ? 4 : -4, h / 2, -h);
}

static void center(unsigned *lhs, unsigned *rhs, unsigned space, unsigned w)
{
	assert(lhs != nullptr);
	assert(rhs != nullptr);
	assert(space >= w);

	*lhs = (space - w) / 2;
	*rhs = (space - w) - *lhs;
}

static void justify(render_context* ctx, const tnode* n, unsigned space, const char* base)
{
	unsigned lhs, rhs;

	if (space < n->w * 10)
	{
		assert(space >= n->w * 10);
	}
	center(&lhs, &rhs, space, n->w * 10);

	if (n->type != TNODE_ELLIPSIS)
	{
		svg_path_h(&ctx->paths, ctx->x, ctx->y, lhs);
	}
	if (debug)
	{
		svg_rect(ctx, lhs, 5, "debug justify");
	}
	ctx->x += lhs;

	node_walk_render(n, ctx, base);

	if (n->type != TNODE_ELLIPSIS)
	{
		svg_path_h(&ctx->paths, ctx->x, ctx->y, rhs);
	}
	if (debug)
	{
		svg_rect(ctx, rhs, 5, "debug justify");
	}
	ctx->x += rhs;
}

static void bars(struct render_context *ctx, unsigned n, unsigned w)
{
	svg_path_v(&ctx->paths, ctx->x, ctx->y, n);
	ctx->x += w;
	svg_path_v(&ctx->paths, ctx->x, ctx->y, n);
}

enum tile
{
	TILE_BL = 1 << 0, /* `- bottom left */
	TILE_TL = 1 << 1, /* .- top left */
	TILE_BR = 1 << 2, /* -' bottom right */
	TILE_TR = 1 << 3, /* -. top right */

	TILE_LINE = 1 << 4, /* horizontal line */

	TILE_BL_N1 = 1 << 5,
	TILE_BR_N1 = 1 << 6,
	TILE_TR_N1 = 1 << 7
};

static void render_tile(struct render_context* ctx, enum tile tile)
{
	int dy;

	switch (tile)
	{
		case TILE_BL_N1: tile = TILE_BL; dy = -10; break;
		case TILE_BR_N1: tile = TILE_BR; dy = -10; break;
		case TILE_TR_N1: tile = TILE_TR; dy = -10; break;

		case TILE_TL:
			dy = 10;
			break;

		case TILE_BR:
		case TILE_TR:
		case TILE_LINE:
			dy = 0;
			break;

		case TILE_BL:
		default:
			__assume(false);
			assert(!"unreached");
			break;
	}

	int y;
	int rx;
	int ry;

	switch (tile)
	{
		case TILE_BL:
			y = 10; rx = 0; ry = y;
			break;
		case TILE_TL:
			y = -10; rx = 0; ry = y;
			break;
		case TILE_BR:
			y = -10; rx = 10; ry = 0;
			break;
		case TILE_TR: 
			y = 10; rx = 10; ry = 0;
			break;

		case TILE_LINE:
			svg_path_h(&ctx->paths, ctx->x, ctx->y + dy, 10);
			ctx->x += 10;
			return;

		default:
			__assume(false);
			assert(!"unreached");
	}

	if (debug)
	{
		char s[16];

		snprintf(s, sizeof s, "%d", tile);

		svg_textbox(ctx, text(s), 10, 0, "debug tile");
		ctx->x -= 10;
	}

	svg_path_q(&ctx->paths, ctx->x, ctx->y + dy, rx, ry, 10, y);
	ctx->x += 10;
}

static void render_tile_bm(struct render_context *ctx, unsigned u)
{
	unsigned v;

	if (u == 0)
	{
		/* nothing to draw */
		ctx->x += 10;
		return;
	}

	for (v = u; v != 0; v &= v - 1)
	{
		render_tile(ctx, (enum tile)(v & -v));

		if ((v & (v - 1)) != 0)
		{
			ctx->x -= 10;
		}
	}
}

static void render_tline_inner(struct render_context* ctx, tline tline, int rhs)
{
	unsigned u[2]{};

	assert(ctx != nullptr);

	switch (tline)
	{
		case TLINE_A:
		case TLINE_a:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;
		case TLINE_B:
			u[0] = TILE_TL;
			u[1] = TILE_TR;
			break;
		case TLINE_C:
		case TLINE_c:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;
		case TLINE_D:
		case TLINE_d:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;
		case TLINE_E:
			u[0] = TILE_BL_N1;
			u[1] = TILE_BR;
			break;
		case TLINE_F:
			u[0] = 0;
			u[1] = 0;
			break;
		case TLINE_G:
		case TLINE_g:
			u[0] = TILE_BL_N1;
			u[1] = TILE_BR;
			break;
		case TLINE_H:
		case TLINE_h:
			u[0] = TILE_LINE | TILE_TL;
			u[1] = TILE_LINE | TILE_TR;
			break;
		case TLINE_I:
		case TLINE_i:
			u[0] = TILE_LINE | TILE_BL_N1;
			u[1] = TILE_LINE | TILE_BR;
			break;

		case TLINE_J:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;

		default:
			u[0] = 0;
			u[1] = 0;
		break;
	}

	render_tile_bm(ctx, u[rhs]);
}

static void render_tline_outer(struct render_context* ctx, tline tline, int rhs)
{
	unsigned u[2]{};

	assert(ctx != nullptr);

	switch (tline)
	{
		case TLINE_A:
		case TLINE_a: 
			u[0] = TILE_LINE | TILE_BR;
			u[1] = TILE_LINE | TILE_BL_N1;
			break;
		case TLINE_C:
		case TLINE_c: 
			u[0] = TILE_LINE | TILE_TR;
			u[1] = TILE_LINE | TILE_TL;
			break;
		case TLINE_D:
		case TLINE_d: 
			u[0] = TILE_LINE | TILE_BR | TILE_TR;
			u[1] = TILE_LINE | TILE_BL_N1 | TILE_TL;
			break;
		case TLINE_H:
		case TLINE_h: 
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;
		case TLINE_I:
		case TLINE_i:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;
		case TLINE_J:
			u[0] = TILE_LINE;
			u[1] = TILE_LINE;
			break;

		default: 
			u[0] = 0;
			u[1] = 0;
			break;
	}

	render_tile_bm(ctx, u[rhs]);
}

static void render_vlist(const struct tnode* n, struct render_context* ctx, const char* base)
{
	unsigned x, o, y;
	size_t j;

	assert(n != nullptr);
	assert(n->type == TNODE_VLIST);
	assert(ctx != nullptr);

	o = ctx->y;

	assert(n->vlist.o <= 1); /* currently only implemented for one node above the line */
	if (n->vlist.o == 1)
	{
		ctx->y -= n->a * 10;
	}

	x = ctx->x;
	y = ctx->y;


	/*
	 * A vlist of 0 items is a special case, meaning to draw
	 * a horizontal line only.
	 */
	if (n->vlist.n == 0 && n->w > 0)
	{
		svg_path_h(&ctx->paths, ctx->x, ctx->y, n->w * 10);
	}
	else for (j = 0; j < n->vlist.n; j++)
	{
		ctx->x = x;

		render_tline_outer(ctx, n->vlist.b[j], 0);
		render_tline_inner(ctx, n->vlist.b[j], 0);

		justify(ctx, n->vlist.a[j], n->w * 10 - 40, base);

		render_tline_inner(ctx, n->vlist.b[j], 1);
		render_tline_outer(ctx, n->vlist.b[j], 1);

		ctx->y += 10;

		if (j + 1 < n->vlist.n)
		{
			ctx->y += (n->vlist.a[j]->d + n->vlist.a[j + 1]->a) * 10;
		}
	}

	/* bars above the line */
	if (n->vlist.o > 0)
	{
		unsigned h;

		h = 0;

		for (j = 0; j < n->vlist.o; j++)
		{
			if (j + 1 < n->vlist.n)
			{
				h += (n->vlist.a[j]->d + n->vlist.a[j + 1]->a + 1) * 10;
			}
		}

		ctx->x = x + 10;
		ctx->y = y + 10;

		h -= 20; /* for the tline corner pieces */
		bars(ctx, h, n->w * 10 - 20);
	}

	/* bars below the line */
	if (n->vlist.n > n->vlist.o + 1)
	{
		unsigned h;

		h = 0;

		for (j = n->vlist.o; j < n->vlist.n; j++)
		{
			if (j + 1 < n->vlist.n)
			{
				h += (n->vlist.a[j]->d + n->vlist.a[j + 1]->a + 1) * 10;
			}
		}

		ctx->x = x + 10;
		ctx->y = o + 10;

		h -= 20; /* for the tline corner pieces */
		bars(ctx, h, n->w * 10 - 20);
	}

	ctx->x = x + n->w * 10;
	ctx->y = o;
}

static void render_hlist(const tnode* n, render_context* ctx, const char* base)
{
	assert(n != nullptr);
	assert(n->type == TNODE_HLIST);
	assert(ctx != nullptr);

	bool more = false;
	for (auto tn : n->hlist)
	{
		if (more)
		{
			svg_path_h(&ctx->paths, ctx->x, ctx->y, 20);
			ctx->x += 20;
		}
		else
		{
			more = true;
		}
		node_walk_render(tn, ctx, base);
	}
}

static void node_walk_render(const tnode* n, render_context* ctx, const char* base)
{
	assert(ctx != nullptr);

	if (debug)
	{
		svg_rect(ctx, n->w * 10, 2, "debug node");
	}

	switch (n->type)
	{
		case TNODE_RTL_ARROW:
			svg_path_h(&ctx->paths, ctx->x, ctx->y, 10);
			svg_arrow(ctx, ctx->x + n->w * 5, ctx->y, 1);
			ctx->x += n->w * 10;
			break;

		case TNODE_LTR_ARROW:
			svg_path_h(&ctx->paths, ctx->x, ctx->y, 10);
			svg_arrow(ctx, ctx->x + n->w * 5, ctx->y, 0);
			ctx->x += n->w * 10;
			break;

		case TNODE_ELLIPSIS:
			svg_ellipsis(ctx, 0, (n->a + n->d + 1) * 10);
			break;

		case TNODE_LITERAL:
			svg_textbox(ctx, n->text, n->w * 10, 8, "literal");
			break;

		case TNODE_PROSE:
			svg_prose(ctx, n->text, n->w * 10);
			break;

		case TNODE_COMMENT: {
			unsigned offset = 5;

			ctx->y += n->d * 10;

			/* TODO: - 5 again for loops with a backwards skip (because they're short) */
			if (n->commented->type == TNODE_VLIST &&
				n->commented->vlist.o == 0 &&
				n->commented->vlist.n == 2 &&
				((n->commented->vlist.a[1]->type == TNODE_VLIST && n->commented->vlist.a[1]->vlist.n == 0) || n->commented->vlist.a[1]->type == TNODE_RTL_ARROW || n->commented->vlist.a[1]->type == TNODE_LTR_ARROW))
			{
				offset += 10;
			}

			ctx->y -= offset; /* off-grid */
			svg_string(ctx, n->w * 10, n->text, "comment");
			ctx->y += offset;
			ctx->y -= n->d * 10;
			justify(ctx, n->commented, n->w * 10, base);
			break;
		}

		case TNODE_RULE:
		{
			/*
			 * We don't make something a link if it doesn't have a destination in
			 * the same document. That is, rules need not be defined in the same
			 * grammar.
			 */
			bool dest_exists = !!ast_find_rule(ctx->grammar, n->text);

			if (base != nullptr && dest_exists)
			{
				writer->printf("    <a href='%s#%s'>\n", base, n->text.chars()); /* XXX: escape */
			}

			svg_textbox(ctx, text(n->text), n->w * 10, 0, "rule");

			if (base != nullptr && dest_exists)
			{
				writer->printf("    </a>\n");
			}
			break;
		}

		case TNODE_VLIST:
			/* TODO: .n == 0 skips under loop alts are too close to the line */
			render_vlist(n, ctx, base);
			break;

		case TNODE_HLIST:
			render_hlist(n, ctx, base);
			break;
	}
}

void svg_render_station(unsigned x, unsigned y)
{
	unsigned gap = 4;
	unsigned h = 12;

	/* .5 to overlap the line width */
	writer->printf("    <path d='M%u.5 %u v%u m %u 0 v%d' class='station'/>\n", x, y - h / 2, h, gap, -h);
}

void svg_render_rule(const struct tnode *node, const char *base, const ast_grammar& grammar)
{
	struct render_context ctx(grammar);
	unsigned w;

	w = (node->w + 8) * 10;

	/*
	 * Just to save passing it along through every production;
	 * this is only used informatively, and has nothing to do
	 * with the structure of rendering.
	 */
	ctx.x = 5;
	ctx.y = node->a * 10 + 10;
	svg_render_station(ctx.x, ctx.y);
	ctx.x = 10;
	svg_path_h(&ctx.paths, ctx.x, ctx.y, 20);

	ctx.x = w - 50;
	svg_path_h(&ctx.paths, ctx.x, ctx.y, 20);
	ctx.x += 20;
	svg_render_station(ctx.x, ctx.y);

	ctx.x = 30;
	ctx.y = node->a * 10 + 10;
	node_walk_render(node, &ctx, base);

	/*
	 * Consolidate adjacent nodes of the same type.
	 */
	svg_path_consolidate(&ctx.paths);

	/*
	 * Next we consolidate on-the-fly to render a single path segment
	 * for a individual path with differently-typed items which connect
	 * in a sequence. This is just an effort to produce tidy markup.
	 */

	while (ctx.paths != nullptr) {
		struct path *p;

		p = svg_path_find_start(ctx.paths);

		writer->printf("    <path d='M%d %d", p->x, p->y);

		do {
			unsigned nx, ny;

			switch (p->type) {
			case PATH_H: writer->printf(" h%d", p->u.n); break;
			case PATH_V: writer->printf(" v%d", p->u.n); break;
			case PATH_Q: writer->printf(" q%d %d %d %d", p->u.q[0], p->u.q[1], p->u.q[2], p->u.q[3]); break;
			}

			svg_path_move(p, &nx, &ny);

			svg_path_remove(&ctx.paths, p);

			/* consolidate only when not debugging */
			if (debug) {
				break;
			}

			p = svg_path_find_following(ctx.paths, nx, ny);
		} while (p != nullptr);

		writer->printf("'/>\n");
	}
}

static void dim_prop_string(const text& text, unsigned* w, unsigned* a, unsigned* d)
{
	double n;

	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	n = 0.0;

	/* estimate a proportional width */

	for (int i = 0; i < text.length(); i += 1)
	{
		switch (tolower((unsigned char)text[i]))
		{
			case '|':
				n += 0.3;
				break;

			case 't':
				n += 0.45;
				break;

			case 'f':
			case 'i':
			case 'j':
			case 'l':
				n += 0.5;
				break;

			case '(':
			case ')':
			case 'I':
				n += 0.55;
				break;

			case ' ':
				n += 0.6;
				break;

			case 'm':
				n += 1.25;
				break;

			case 'w':
				n += 1.2;
				break;

			case '1':
				n += 0.75;
				break;

			default:
				n += 0.8;
				break;
		}

		if (isupper((unsigned char)text[i]))
		{
			n += 0.25;
		}
	}

	n = ceil(n);

	/* even numbers only, for sake of visual rhythm */
	if (((unsigned)n & 1) == 1)
	{
		n++;
	}

	*w = n + 1;
	*a = 1;
	*d = 1;
}

static void dim_mono_txt(const text& text, unsigned* w, unsigned* a, unsigned* d)
{
	size_t i;
	double n;

	assert(w != nullptr);
	assert(a != nullptr);
	assert(d != nullptr);

	n = 0.0;

	for (i = 0; i < text.length(); i++)
	{
		if (text[i] == '\t' || text[i] == '\a')
		{
			n += 4.00;
			continue;
		}

		if (!isprint((unsigned char)text[i]))
		{
			n += 2.93; /* <XY> */
			continue;
		}

		n += 1.0;
	}

	n = ceil(n);

	*w = n + 1;
	*a = 1;
	*d = 1;
}

struct dim svg_dim =
{
	dim_mono_txt,
	dim_prop_string,
	0,
	0,
	0,
	1,
	2,
	0
};

WARN_UNUSED_RESULT int svg_output(const ast_grammar& grammar)
{
	struct tnode** a;
	unsigned z;
	unsigned w, h;
	unsigned n;

	n = grammar.rules.size();

	/*
	 * We store all tnodes for sake of calculating the viewport only;
	 * it's a shame this needs to be provided ahead of rendering each
	 * tnode, else we could do that on the fly.
	 */

	a = (struct tnode**)xmalloc(sizeof * a * n);

	w = 0;
	h = 0;

	unsigned i = 0;
	for (auto p : grammar.rules)
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

		a[i] = rrd_to_tnode(rrd, &svg_dim);

		if (a[i]->w > w)
		{
			w = a[i]->w;
		}
		h += a[i]->a + a[i]->d + 6;

		node_free(rrd);

		i += 1;
	}

	w += 12;
	h += 5;

	writer->printf("<?xml version='1.0' encoding='utf-8'?>\n");
	writer->printf("<svg\n");
	writer->printf("  xmlns='http://www.w3.org/2000/svg'\n");
	writer->printf("  xmlns:xlink='http://www.w3.org/1999/xlink'\n");
	writer->printf("\n");
	writer->printf("  width='%u0' height='%u'>\n", w, h * 10 + 60);
	writer->printf("\n");

	writer->printf("  <style>\n");

	writer->printf("    rect, line, path { stroke-width: 1.5px; stroke: black; fill: transparent; }\n");
	writer->printf("    rect, line, path { stroke-linecap: square; stroke-linejoin: rounded; }\n");

	if (debug)
	{
		writer->printf("    rect.debug { stroke: none; opacity: 0.75; }\n");
		writer->printf("    rect.debug.tile { fill: #cccccc; }\n");
		writer->printf("    rect.debug.node { fill: transparent; stroke-width: 1px; stroke: #ccccff; stroke-dasharray: 2 3; }\n");
		writer->printf("    rect.debug.justify { fill: #ccccff; }\n");
		writer->printf("    text.debug.tile { opacity: 0.3; font-family: monospace; font-weight: bold; stroke: none; }\n");
	}

	writer->printf("    path { fill: transparent; }\n");
	writer->printf("    text.literal { font-family: monospace; }\n");
	writer->printf("    line.ellipsis { stroke-dasharray: 1 3.5; }\n");
	writer->printf("    tspan.hex { font-family: monospace; font-size: 90%%; }\n");
	writer->printf("    path.arrow { fill: black; }\n");

	if (css_file != nullptr)
	{
		if (!cat(css_file, "    "))
		{
			return 0;
		}
	}

	writer->printf("  </style>\n");
	writer->printf("\n");

	z = 0;
	i = 0;
	for (auto rule : grammar.rules)
	{
		writer->printf("  <g transform='translate(%u %u)'>\n", 40, z * 10 + 50);
		writer->printf("    <text x='%d' y='%d'>%s:</text>\n", -30, -10, rule->name.chars());

		svg_render_rule(a[i], nullptr, grammar);

		writer->printf("  </g>\n");
		writer->printf("\n");

		z += a[i]->a + a[i]->d + 6;

		i += 1;
	}

	for (int i = 0; i < grammar.rules.size(); i += 1)
	{
		tnode_free(a[i]);
	}

	free(a);

	writer->printf("</svg>\n");
	return 1;
}
