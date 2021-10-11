/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_HTML5_IO_H
#define KGT_HTML5_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

extern int prettify;

WARN_UNUSED_RESULT int svg_html5_output(const ast_grammar& grammar);
WARN_UNUSED_RESULT int svg_xhtml5_output(const ast_grammar& grammar);

#endif
