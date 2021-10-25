/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_BNF_IO_H
#define KGT_BNF_IO_H

#include "../compiler_specific.h"
#include "../parsing-error.h"
struct ast_rule;

WARN_UNUSED_RESULT int bnf_output(const ast_grammar& grammar);

bool bnf_input(ast_grammar& grammar, int (*f)(void *opaque), void *opaque, parsing_errors* errors);

#endif

