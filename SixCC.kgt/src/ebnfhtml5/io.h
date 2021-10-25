/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_EBNFHTML5_IO_H
#define KGT_EBNFHTML5_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

WARN_UNUSED_RESULT int ebnf_html5_output(const ast_grammar& grammar);
WARN_UNUSED_RESULT int ebnf_xhtml5_output(const ast_grammar& grammar);

#endif

