/*
 * Copyright 2021 John Scott
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_JSON_IO_H
#define KGT_JSON_IO_H

#include "../compiler_specific.h"

struct ast_GRAMMAR;

WARN_UNUSED_RESULT int json_output(const ast_grammar& grammar);

#endif
