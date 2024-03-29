/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRTEXT_IO_H
#define KGT_RRTEXT_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

extern int prettify;

WARN_UNUSED_RESULT int rrutf8_output(const ast_grammar& grammar);
WARN_UNUSED_RESULT int rrtext_output(const ast_grammar& grammar);

#endif
