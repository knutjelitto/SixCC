/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_REWRITE_H
#define KGT_REWRITE_H

#include "compiler_specific.h"

struct ast_rule;

WARN_UNUSED_RESULT bool rewrite_ci_literals(ast_grammar& grammar);
void rewrite_invisible(ast_grammar& grammar);

#endif

