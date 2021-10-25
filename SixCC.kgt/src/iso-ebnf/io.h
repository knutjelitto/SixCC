/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_ISO_EBNF_IO_H
#define KGT_ISO_EBNF_IO_H

#include "../compiler_specific.h"
#include "../parsing-error.h"
struct ast_grammar;

#define iso_ebnf_ast_unsupported (FEATURE_AST_PROSE)

bool iso_ebnf_input(ast_grammar& grammar, int (*f)(void *opaque), void *opaque, parsing_errors* errors);

WARN_UNUSED_RESULT int iso_ebnf_output(const ast_grammar& grammar);

#endif

