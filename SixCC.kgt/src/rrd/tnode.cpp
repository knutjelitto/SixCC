/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#define _BSD_SOURCE
#define _DEFAULT_SOURCE
#define _CRT_SECURE_NO_WARNINGS

#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdarg.h>
#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../bitmap.h"
#include "../xalloc.h"

#include "../rrd/rrd.h"
#include "../rrd/pretty.h"
#include "../rrd/node.h"
#include "../rrd/rrd.h"
#include "../rrd/list.h"

#include "tnode.h"

#include "../xalloc.h"

static struct tnode * tnode_create_node(const struct node *node, int rtl, const struct dim *dim);

static struct tnode * tnode_create_comment(const struct tnode *tnode, const text& text, const struct dim *dim);

static struct tnode * tnode_create_ellipsis(const struct dim *dim);

static void swap(struct tnode **a, struct tnode **b)
{
	struct tnode *tmp;

	assert(a != nullptr);
	assert(b != nullptr);

	tmp = *a;
	*a = *b;
	*b = tmp;
}

static int isnamed(char c)
{
	/*
	 * These correspond to the values rendered as named
	 * characters in SVG output (i.e. <TAB> and friends),
	 * and as common escapes ("\t" and so on) for text output.
	 */
	switch (c) {
	case '\a':
	case '\b':
	case '\f':
	case '\n':
	case '\r':
	case '\t':
	case '\v':
		return 1;

	default:
		return 0;
	}
}

static void tnode_free_vlist(struct tnode_vlist* list)
{
	size_t i;

	assert(list != nullptr);

	for (i = 0; i < list->n; i++)
	{
		tnode_free(list->a[i]);
	}

	delete[] list->a;
	delete[] list->b;
}

static void tnode_free_hlist(struct tnode_hlist* list)
{
	size_t i;

	assert(list != nullptr);

	for (i = 0; i < list->n; i++)
	{
		tnode_free(list->a[i]);
	}

	delete[]list->a;
}

void tnode_free(struct tnode *n)
{
	if (n == nullptr)
	{
		return;
	}

	switch (n->type)
	{
	case TNODE_RTL_ARROW:
	case TNODE_LTR_ARROW:
	case TNODE_ELLIPSIS:
	case TNODE_RULE:
		break;

	case TNODE_CI_LITERAL:
	case TNODE_CS_LITERAL:
		break;

	case TNODE_PROSE:
		break;

	case TNODE_COMMENT:
		tnode_free((struct tnode*)n->u.comment.tnode);
		break;

	case TNODE_VLIST:
		tnode_free_vlist(&n->u.vlist);
		break;

	case TNODE_HLIST:
		tnode_free_hlist(&n->u.hlist);
		break;
	}

	delete n;
}

static int char_terminal(const struct node* node, unsigned char* c)
{
	assert(c != nullptr);

	if (node == nullptr)
	{
		return 0;
	}

	/* we collate ranges for case-sensitive strings only */
	if (node->type != NODE_CS_LITERAL)
	{
		return 0;
	}

	if (node->u.literal.length() != 1)
	{
		return 0;
	}

	*c = (unsigned char)node->u.literal[0];

	return 1;
}

static void
collate_ranges(struct bm *bm, const struct list *list)
{
	const struct list *p;

	assert(bm != nullptr);
	assert(list != nullptr);

	bm_clear(bm);

	for (p = list; p != nullptr; p = p->next) {
		unsigned char c;

		if (!char_terminal(p->node, &c)) {
			continue;
		}

		bm_set(bm, c);
	}
}

static const struct node *
find_node(const struct list *list, char d)
{
	const struct list *p;

	for (p = list; p != nullptr; p = p->next) {
		unsigned char c;

		if (!char_terminal(p->node, &c)) {
			continue;
		}

		if (c == (unsigned char) d) {
			return p->node;
		}
	}

	__assume(false);
	assert(!"unreached");
}

static struct tnode_vlist tnode_create_alt_list(const struct list* list, int rtl, const struct dim* dim)
{
	const struct list* p;
	struct tnode_vlist nuw;
	size_t i;
	struct bm bm;
	int hi, lo;

	assert(dim != nullptr);

	nuw.n = list_count(list); /* worst case */
	if (nuw.n == 0)
	{
		nuw.a = nullptr;
		return nuw;
	}

	collate_ranges(&bm, list);

	//nuw.a = (struct tnode**)xmalloc(sizeof *nuw.a * nuw.n);
	nuw.a = new tnode* [nuw.n];

	hi = -1;

	i = 0;
	p = list;

	/* TODO: how to handle invisible alts? have the corner tiles hidden?
	at the moment we render an empty line, which makes sense in seqs but not in alts
	*/

	while (p != nullptr)
	{
		unsigned char c;

		if (!char_terminal(p->node, &c))
		{
			nuw.a[i++] = tnode_create_node(p->node, rtl, dim);
			p = p->next;
			continue;
		}

		if (!bm_get(&bm, c))
		{
			/* already output */
			p = p->next;
			continue;
		}

		/* start of range */
		lo = bm_next(&bm, hi, 1);
		if (lo > UCHAR_MAX)
		{
			/* end of list */
			break;
		}

		/* end of range */
		hi = bm_next(&bm, lo, 0);

		if (!isalnum((unsigned char)lo) && isalnum((unsigned char)hi))
		{
			nuw.a[i++] = tnode_create_node(find_node(list, lo), rtl, dim);
			bm_unset(&bm, lo);

			hi = lo;
			p = p->next;
			continue;
		}

		/*
		 * If the range begins or ends on any named item (e.g. <TAB>),
		 * the output would be confusing since it's not immediately
		 * evident which values are included. So we elect to render the
		 * range as invidual elements instead.
		 */
		if (isnamed((unsigned char)lo) || isnamed((unsigned char)hi))
		{
			nuw.a[i++] = tnode_create_node(find_node(list, lo), rtl, dim);
			bm_unset(&bm, lo);

			hi = lo;
			p = p->next;
			continue;
		}

		/* bring down endpoint, if it's past the end of the class */
		if (isalnum((unsigned char)lo))
		{
			size_t i;

			const struct
			{
				int (*is)(int);
				int end;
			} b[] = {
				{ isdigit, '9' },
				{ isupper, 'Z' },
				{ islower, 'z' }
			};

			/* XXX: assumes ASCII */
			for (i = 0; i < sizeof b / sizeof * b; i++)
			{
				if (b[i].is((unsigned char)lo))
				{
					if (!b[i].is((unsigned char)hi))
					{
						hi = b[i].end + 1;
					}
					break;
				}
			}

			assert(i < sizeof b / sizeof * b);
		}

		assert(hi > lo);

		switch (hi - lo)
		{
			case 1:
			case 2:
			case 3:
				nuw.a[i++] = tnode_create_node(find_node(list, lo), rtl, dim);
				bm_unset(&bm, lo);

				hi = lo;
				break;

			default:
				nuw.a[i++] = tnode_create_node(find_node(list, lo), rtl, dim);
				nuw.a[i++] = tnode_create_ellipsis(dim);
				nuw.a[i++] = tnode_create_node(find_node(list, hi - 1), rtl, dim);

				for (int j = lo; j <= hi - 1; j++)
				{
					bm_unset(&bm, j);
				}

				break;
		}
	}

	assert(i <= nuw.n);
	nuw.n = i;

	nuw.b = new enum tline[nuw.n];

	return nuw;
}

static struct tnode_hlist tnode_create_hlist(const struct list* list, int rtl, const struct dim* dim)
{
	const struct list* p;
	struct tnode_hlist nuw;
	size_t i;

	assert(dim != nullptr);

	nuw.n = list_count(list);
	if (nuw.n == 0)
	{
		nuw.a = nullptr;
		return nuw;
	}

	nuw.a = new struct tnode* [nuw.n];

	for (i = 0, p = list; p != nullptr; p = p->next)
	{
		nuw.a[!rtl ? i : nuw.n - i - 1] = tnode_create_node(p->node, rtl, dim);
		i++;
	}

	assert(i == nuw.n);

	return nuw;
}

static const char *
times(unsigned n)
{
	const char *a[] = {
		"never",
		"once", "twice",
		"three times", "four times", "five times", "six times",
		"seven times", "eight times", "nine times", "ten times",
		"eleven times", "twelve times"
	};

	if (n > sizeof a / sizeof *a - 1) {
		return nullptr;
	}

	return a[n];
}

static text loop_label(unsigned min, unsigned max)
{
	assert(max >= min || max == 0);

	char s[128];

	const char* h;

	if (min == 0 && max == 0)
	{
		*s = '\0';
		return text();
	}

	if (max == min)
	{
		if (h = times(max), h != nullptr)
		{
			return sprintf(s, "(%s only)", h);
		}
		else
		{
			return sprintf(s, "(%u times)", max);
		}
	}
	else  if (min == 0)
	{
		if (h = times(max), h != nullptr)
		{
			return sprintf(s, "(%s at most)", h);
		}
		else
		{
			return sprintf(s, "(%u times at most)", max);
		}
	}
	else if (max == 0)
	{
		if (h = times(min), h != nullptr)
		{
			return sprintf(s, "(at least %s)", h);
		}
		else
		{
			return sprintf(s, "(at least %u times)", min);
		}
	}
	else
	{
		return sprintf(s, "(%u-%u times)", min, max);
	}

	return text(s);
}

static struct tnode* tnode_create_ellipsis(const struct dim* dim)
{
	assert(dim != nullptr);

	struct tnode* nuw = new tnode();

	nuw->type = TNODE_ELLIPSIS;
	nuw->w = 1;
	nuw->a = 0;
	nuw->d = dim->ellipsis_depth;

	return nuw;
}

static struct tnode* tnode_create_comment(const struct tnode* tnode, const text& text, const struct dim* dim)
{
	assert(tnode != nullptr);
	assert(dim != nullptr);

	unsigned w, a, d;

	struct tnode* new_tnode = new struct tnode();

	new_tnode->type = TNODE_COMMENT;
	new_tnode->u.comment.s = text;
	new_tnode->u.comment.tnode = tnode;

	/* TODO: place comment above or below, depending on tnode type (or pass in);
	 * store in .comment struct as enum */
	new_tnode->w = new_tnode->u.comment.tnode->w;
	new_tnode->a = new_tnode->u.comment.tnode->a;
	new_tnode->d = new_tnode->u.comment.tnode->d + dim->comment_height;

	dim->rule_string(new_tnode->u.comment.s, &w, &a, &d);

	if (new_tnode->w < w)
	{
		new_tnode->w = w;
	}

	new_tnode->a += a;
	new_tnode->d += d;

	return new_tnode;
}

static struct tnode* tnode_create_node(const struct node* node, int rtl, const struct dim* dim)
{
	assert(dim != nullptr);

	struct tnode* nuw = new tnode();

	if (node == nullptr)
	{
		nuw->type = TNODE_VLIST;
		nuw->w = 0;
		nuw->a = 0;
		nuw->d = 1;

		nuw->u.vlist.n = 0;
		nuw->u.vlist.o = 0;
		nuw->u.vlist.a = nullptr;
		nuw->u.vlist.b = nullptr;

		return nuw;
	}

	switch (node->type)
	{
		case NODE_CI_LITERAL:
			nuw->type = TNODE_CI_LITERAL;
			nuw->u.literal = node->u.literal;
			dim->literal_txt(nuw->u.literal, &nuw->w, &nuw->a, &nuw->d);
			nuw->w += dim->literal_padding + dim->ci_marker;
			break;

		case NODE_CS_LITERAL:
			nuw->type = TNODE_CS_LITERAL;
			nuw->u.literal = node->u.literal;
			dim->literal_txt(nuw->u.literal, &nuw->w, &nuw->a, &nuw->d);
			nuw->w += dim->literal_padding;
			break;

		case NODE_RULE:
			nuw->type = TNODE_RULE;
			nuw->u.name = node->u.name;
			dim->rule_string(nuw->u.name, &nuw->w, &nuw->a, &nuw->d);
			nuw->w += dim->rule_padding;
			break;

		case NODE_PROSE:
			nuw->type = TNODE_PROSE;
			nuw->u.prose = node->u.prose;
			dim->rule_string(nuw->u.prose, &nuw->w, &nuw->a, &nuw->d);
			nuw->w += dim->prose_padding;
			break;

		case NODE_ALT:
		case NODE_ALT_SKIPPABLE:
			nuw->type = TNODE_VLIST;

			/*
			 * TODO: decide whether to put the skip above or hang it below.
			 * It looks nicer below when the item being skipped is low in height,
			 * and where adjacent SEQ nodes do not themselves go above the line.
			 */

			if (node->type == NODE_ALT_SKIPPABLE)
			{
				struct list list;

				list.node = nullptr;
				list.next = node->u.alt;

				nuw->u.vlist = tnode_create_alt_list(&list, rtl, dim);
			}
			else
			{
				nuw->u.vlist = tnode_create_alt_list(node->u.alt, rtl, dim);
			}

			{
				unsigned w;
				size_t i;

				w = 0;

				for (i = 0; i < nuw->u.vlist.n; i++)
				{
					if (nuw->u.vlist.a[i]->w > w)
					{
						w = nuw->u.vlist.a[i]->w;
					}
				}

				nuw->w = w + 6;
			}

			{
				unsigned a;
				size_t i;

				i = 0;

				/*
				 * Alt lists hang below the line.
				 * The ascender of this node is the ascender of just the first list item
				 * because the first item is at the top of the list, plus the height of
				 * the skip node above that.
				 */

				a = 0;

				if (node->type == NODE_ALT_SKIPPABLE)
				{
					assert(nuw->u.vlist.n > i);
					assert(nuw->u.vlist.a[i] != nullptr);
					assert(nuw->u.vlist.a[i]->type == TNODE_VLIST && nuw->u.vlist.a[i]->u.vlist.n == 0);
					assert(nuw->u.vlist.a[i]->a + nuw->u.vlist.a[i]->d == 1);

					/* arrows are more helpful here */
					nuw->u.vlist.a[i]->type = rtl ? TNODE_RTL_ARROW : TNODE_LTR_ARROW;
					nuw->u.vlist.a[i]->w = 1;

					a += nuw->u.vlist.a[i]->a + nuw->u.vlist.a[i]->d + 1;
					i++;
				}

				if (nuw->u.vlist.n > i)
				{
					assert(nuw->u.vlist.a[i] != nullptr);

					a += nuw->u.vlist.a[i]->a;
				}

				nuw->a = a;
			}

			{
				nuw->u.vlist.o = 0;

				if (node->type == NODE_ALT_SKIPPABLE)
				{
					nuw->u.vlist.o += 1; /* one alt */
				}
			}

			{
				unsigned d;
				size_t i;

				d = 0;

				for (i = 0; i < nuw->u.vlist.n; i++)
				{
					d += 1 + nuw->u.vlist.a[i]->a + nuw->u.vlist.a[i]->d;
				}

				nuw->d = d - nuw->a - 1;
			}

			{
				size_t i;

				for (i = 0; i < nuw->u.vlist.n; i++)
				{
					enum tline z;

					int sameline = i == nuw->u.vlist.o;
					int aboveline = i < nuw->u.vlist.o;
					int belowline = i > nuw->u.vlist.o;
					int firstalt = i == 0;
					int lastalt = i == nuw->u.vlist.n - 1;

					if (nuw->u.vlist.n == 1)
					{
						z = TLINE_J;
					}
					else if (sameline && nuw->u.vlist.n > 1 && lastalt)
					{
						z = rtl ? TLINE_A : TLINE_a;
					}
					else if (firstalt && aboveline)
					{
						z = TLINE_B;
					}
					else if (firstalt && sameline)
					{
						z = rtl ? TLINE_C : TLINE_c;
					}
					else if (sameline)
					{
						z = rtl ? TLINE_D : TLINE_d;
					}
					else if (belowline && i > 0 && lastalt)
					{
						z = TLINE_E;
					}
					else if (nuw->u.vlist.a[i]->type == TNODE_ELLIPSIS)
					{
						z = TLINE_F;
					}
					else
					{
						z = rtl ? TLINE_G : TLINE_g;
					}

					nuw->u.vlist.b[i] = z;
				}
			}

			break;

		case NODE_SEQ:
			nuw->type = TNODE_HLIST;
			nuw->u.hlist = tnode_create_hlist(node->u.seq, rtl, dim);

			{
				unsigned w;
				size_t i;

				w = 0;

				for (i = 0; i < nuw->u.hlist.n; i++)
				{
					w += nuw->u.hlist.a[i]->w + 2;
				}

				nuw->w = w - 2;
			}

			{
				unsigned a;
				size_t i;

				a = 0;

				for (i = 0; i < nuw->u.hlist.n; i++)
				{
					if (nuw->u.hlist.a[i]->a > a)
					{
						a = nuw->u.hlist.a[i]->a;
					}
				}

				nuw->a = a;
			}

			{
				unsigned d;
				size_t i;

				d = 0;

				for (i = 0; i < nuw->u.hlist.n; i++)
				{
					if (nuw->u.hlist.a[i]->d > d)
					{
						d = nuw->u.hlist.a[i]->d;
					}
				}

				nuw->d = d;
			}

			break;

		case NODE_LOOP:
			nuw->type = TNODE_VLIST;

			nuw->u.vlist.n = 2;
			nuw->u.vlist.a = new struct tnode* [nuw->u.vlist.n];
			nuw->u.vlist.b = new enum tline[nuw->u.vlist.n];

			nuw->u.vlist.a[0] = tnode_create_node(node->u.loop.forward, rtl, dim);
			nuw->u.vlist.a[1] = tnode_create_node(node->u.loop.backward, !rtl, dim);

			nuw->u.vlist.b[0] = rtl ? TLINE_H : TLINE_h;
			nuw->u.vlist.b[1] = TLINE_E;

			if (nuw->u.vlist.a[1]->type == TNODE_VLIST && nuw->u.vlist.a[1]->u.vlist.n == 0)
			{
				/* arrows are helpful when going backwards */
				nuw->u.vlist.a[1]->type = !rtl ? TNODE_RTL_ARROW : TNODE_LTR_ARROW;
				nuw->u.vlist.a[1]->w = 1;
			}

			{
				unsigned w;
				unsigned wf, wb;

				wf = nuw->u.vlist.a[0]->w;
				wb = nuw->u.vlist.a[1]->w;

				w = (wf > wb ? wf : wb) + 6;

				nuw->w = w;
			}

			{
				nuw->a = nuw->u.vlist.a[0]->a;
			}

			{
				nuw->u.vlist.o = 0;
			}

			{
				unsigned d;
				size_t i;

				d = 0;

				for (i = 0; i < nuw->u.vlist.n; i++)
				{
					d += 1 + nuw->u.vlist.a[i]->a + nuw->u.vlist.a[i]->d;
				}

				nuw->d = d - nuw->a - 1;
			}

			/*
			 * An aesthetic optimisation: When the depth of the forward node is large
			 * a loop going beneath it looks bad, because the backward bars are so high.
			 * A height of 2 seems simple enough to potentially render above the line.
			 * We do that only if there isn't already something big above the line.
			 */
			if (nuw->u.vlist.a[0]->d >= 4)
			{
				if (nuw->u.vlist.a[1]->a + nuw->u.vlist.a[1]->d <= 2)
				{
					if (nuw->u.vlist.a[0]->a <= 2 && nuw->u.vlist.a[0]->d > nuw->u.vlist.a[0]->a)
					{
						swap(&nuw->u.vlist.a[0], &nuw->u.vlist.a[1]);

						nuw->u.vlist.b[0] = TLINE_B;
						nuw->u.vlist.b[1] = rtl ? TLINE_I : TLINE_i;

						nuw->u.vlist.o = 1;

						nuw->a += nuw->u.vlist.a[0]->a + nuw->u.vlist.a[0]->d + 1;
						nuw->d -= nuw->u.vlist.a[0]->a + nuw->u.vlist.a[0]->d + 1;
					}
				}
			}

			{
				text label = loop_label(node->u.loop.min, node->u.loop.max);

				if (label.length() > 0)
				{
					nuw = tnode_create_comment(nuw, label, dim);
				}
			}

			break;
	}

	/* TODO:
	we make a tnode subtree above, and then if it is invisible, replace the entire thing
	with a regular skip or arrow or whatever
	TODO: option to show invisible nodes

	we do this after constructing the node in order to find its width
	*/
	if (node->invisible)
	{
		struct tnode* old;

		old = nuw;

		nuw = new tnode();

		nuw->type = TNODE_VLIST;
		nuw->w = old->w;
		nuw->a = old->a;
		nuw->d = old->d;

		nuw->u.vlist.n = 0;
		nuw->u.vlist.o = 0;
		nuw->u.vlist.a = nullptr;
		nuw->u.vlist.b = nullptr;

		tnode_free(old);
	}

	return nuw;
}

struct tnode * rrd_to_tnode(const struct node* node, const struct dim* dim)
{
	struct tnode* n;

	assert(dim != nullptr);

	n = tnode_create_node(node, 0, dim);

	return n;
}

