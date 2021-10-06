/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_XALLOC_H
#define KGT_XALLOC_H

#include <stddef.h>
#include "txt.h"

struct txt;

void ok_exit();
void err_exit();
void *xmalloc(size_t size);
char* xstrdup(const char* s);
char* xstrdup(const text& s);
struct txt xtxtdup(const struct txt *t);
void xerror(const char *msg, ...);

#endif

