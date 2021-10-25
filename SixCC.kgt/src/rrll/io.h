/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRLL_IO_H
#define KGT_RRLL_IO_H

#include "../compiler_specific.h"

struct ast_grammar;

#define rrll_rrd_unsupported FEATURE_RRD_CI_LITERAL

extern int prettify;

WARN_UNUSED_RESULT int rrll_output(const ast_grammar& grammar);

#endif

