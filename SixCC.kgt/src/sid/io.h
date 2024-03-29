/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_SID_IO_H
#define KGT_SID_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

WARN_UNUSED_RESULT int sid_output(const ast_grammar& grammar);

#endif

