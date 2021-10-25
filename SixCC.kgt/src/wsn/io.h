/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_WSN_IO_H
#define KGT_WSN_IO_H

#include "../compiler_specific.h"
#include "../parsing-error.h"
struct ast_grammar;

bool wsn_input(ast_grammar& grammar, int (*f)(void *opaque), void *opaque, parsing_errors* errors);

WARN_UNUSED_RESULT int wsn_output(const ast_grammar& grammar);

#endif

