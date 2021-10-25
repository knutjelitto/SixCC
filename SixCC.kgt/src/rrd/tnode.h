/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_TNODE_H
#define KGT_RRD_TNODE_H

#include <deque>

#include "node.h"
#include "../txt.h"


/*
 * Various combinations of two endpoints (corner pieces) for a line:
 *
 *       .              .
 *      -A---- node ----B-
 *       '              '
 */
typedef enum
{
	TLINE_A, TLINE_a,
	TLINE_B,
	TLINE_C, TLINE_c,
	TLINE_D, TLINE_d,
	TLINE_E,
	TLINE_F,
	TLINE_G, TLINE_g,
	TLINE_H, TLINE_h,
	TLINE_I, TLINE_i,
	TLINE_J
} tline;

/*
 * A list of vertical line segments:
 *
 *       A---- node ----B
 *       |              |
 *  .o --C---- node ----D--
 *       |              |
 *       E---- node ----F
 *       |              |
 *       G---- node ----H
 */
struct tnode_vlist
{
	struct tnode **a;
	tline *b;
	size_t n;
	unsigned o; /* offset, in indicies */
};

/*
 * A list of horizontal line segments:
 *
 *     -- node -- node -- node --
 */
struct tnode_hlist : std::deque<tnode*>
{
};

typedef enum
{
	TNODE_RTL_ARROW = 42,
	TNODE_LTR_ARROW,
	TNODE_ELLIPSIS,
	TNODE_LITERAL,
	TNODE_COMMENT,
	TNODE_PROSE,
	TNODE_RULE,
	TNODE_VLIST,
	TNODE_HLIST
} tnode_type;

struct tnode
{
	tnode_type type;

	/* in abstract rrd units */
	unsigned w;	// width
	unsigned a; // ascender  - height including and above the line
	unsigned d; // descender - depth below the line

	struct text text;
	struct tnode_vlist vlist;
	struct tnode_hlist hlist;
	const struct tnode* commented;
};

struct dim
{
	void (*literal_txt)(const text& text, unsigned *w, unsigned *a, unsigned *d);
	void (*rule_string)(const text& text, unsigned *w, unsigned *a, unsigned *d);
	unsigned literal_padding;
	unsigned rule_padding;
	unsigned prose_padding;
	unsigned comment_height;
	unsigned ci_marker;
	unsigned ellipsis_depth;
};

void tnode_free(tnode *n);

tnode *rrd_to_tnode(const node *node, const dim *dim);

#endif

