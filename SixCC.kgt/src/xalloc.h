/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_XALLOC_H
#define KGT_XALLOC_H

#include <stddef.h>

struct txt;
struct text;

void ok_exit();
[[noreturn]] void err_exit();
void *xmalloc(size_t size);
char* xstrdup(const char* s);
char* xstrdup(const text& s);
void xerror(const char *msg, ...);

#endif

