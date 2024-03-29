/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRPARCON_IO_H
#define KGT_RRPARCON_IO_H

struct ast_grammar;

#define rrparcon_rrd_unsupported FEATURE_RRD_CI_LITERAL

extern int prettify;

WARN_UNUSED_RESULT int rrparcon_output(const ast_grammar& grammar);

#endif
