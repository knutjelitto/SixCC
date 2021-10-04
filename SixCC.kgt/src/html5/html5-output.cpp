/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * Railroad Diagram HTML5 Output
 *
 * Output a HTML page of inlined SVG diagrams
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

/* XXX */
extern struct dim svg_dim;
void svg_render_rule(const struct tnode *node, const char *base, const struct ast_rule *grammar);

extern const char *css_file;

WARN_UNUSED_RESULT int cat(const char* in, const char* indent);

WARN_UNUSED_RESULT static int output(const struct ast_rule* grammar, int xml)
{
	const struct ast_rule* p;

	writer->printf(" <head>\n");
	if (xml)
	{
		writer->printf("  <meta charset='UTF-8'/>\n");
	}

	writer->printf("  <style>\n");

	writer->printf("      rect, line, path { stroke-width: 1.5px; stroke: black; fill: transparent; }\n");
	writer->printf("      rect, line, path { stroke-linecap: square; stroke-linejoin: rounded; }\n");
	writer->printf("      path { fill: transparent; }\n");
	writer->printf("      text.literal { font-family: monospace; }\n");
	writer->printf("      a { fill: blue; }\n");
	writer->printf("      a:hover rect { fill: aliceblue; }\n");
	writer->printf("      h2 { font-size: inherit; font-weight: inherit; }\n");
	writer->printf("      line.ellipsis { stroke-dasharray: 1 3.5; }\n");
	writer->printf("      tspan.hex { font-family: monospace; font-size: 90%%; }\n");
	writer->printf("      path.arrow { fill: black; }\n");
	writer->printf("      svg { margin-left: 30px; }\n");

	if (css_file != NULL)
	{
		if (!cat(css_file, "      "))
		{
			return 0;
		}
	}

	writer->printf("  </style>\n");

	writer->printf(" </head>\n");
	writer->printf("\n");

	writer->printf(" <body>\n");

	for (p = grammar; p; p = p->next)
	{
		struct tnode* tnode;
		struct node* rrd;
		unsigned h, w;

		if (!ast_to_rrd(p, &rrd))
		{
			perror("ast_to_rrd");
			return 0;
		}

		if (prettify)
		{
			rrd_pretty(&rrd);
		}

		tnode = rrd_to_tnode(rrd, &svg_dim);

		node_free(rrd);

		writer->printf(" <section>\n");
		writer->printf("  <h2><a name='%s'>%s:</a></h2>\n", p->name, p->name);

		h = (tnode->a + tnode->d + 1) * 10 + 5;
		w = (tnode->w + 6) * 10;

		writer->printf("  <svg");
		if (xml)
		{
			writer->printf(" xmlns='http://www.w3.org/2000/svg'");
		}
		writer->printf(" height='%u' width='%u'>\n", h, w);
		svg_render_rule(tnode, "", grammar);
		writer->printf("  </svg>\n");

		writer->printf(" </section>\n");
		writer->printf("\n");

		tnode_free(tnode);
	}

	writer->printf(" </body>\n");
	return 1;
}

WARN_UNUSED_RESULT int html5_output(const struct ast_rule *grammar)
{
	writer->printf("<!DOCTYPE html>\n");
	writer->printf("<html>\n");
	writer->printf("\n");

	if (!output(grammar, 0))
		return 0;

	writer->printf("</html>\n");
	return 1;
}

WARN_UNUSED_RESULT int xhtml5_output(const struct ast_rule *grammar)
{
	writer->printf("<?xml version='1.0' encoding='utf-8'?>\n");
	writer->printf("<!DOCTYPE html>\n");
	writer->printf("<html xml:lang='en' lang='en'\n");
	writer->printf("  xmlns='http://www.w3.org/1999/xhtml'\n");
	writer->printf("  xmlns:xlink='http://www.w3.org/1999/xlink'>\n");
	writer->printf("\n");

	if (!output(grammar, 1))
		return 0;

	writer->printf("</html>\n");
	return 1;
}

