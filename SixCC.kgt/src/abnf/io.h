/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_ABNF_IO_H
#define KGT_ABNF_IO_H

#include "../compiler_specific.h"
#include "../ast.h"
#include "../parsing-error.h"
struct ast_grammar;

/*
 * We don't mark FEATURE_AST_INVISIBLE as unsupported here, because ABNF
 * is supposed to be a source format; it's not presentational.
 */

bool abnf_input(ast_grammar& grammar, int (*f)(void *opaque), void *opaque, parsing_errors* errors);

WARN_UNUSED_RESULT int abnf_output(const ast_grammar& grammar);

#endif

