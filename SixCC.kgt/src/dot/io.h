/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_DOT_IO_H
#define KGT_DOT_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

WARN_UNUSED_RESULT int dot_output(const ast_grammar& grammar);

#endif

