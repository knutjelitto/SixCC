/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_SVG_IO_H
#define KGT_SVG_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

extern int fakeptr;
extern int debug;
extern int prettify;

WARN_UNUSED_RESULT int svg_output(const ast_grammar& grammar);

#endif
