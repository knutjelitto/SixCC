/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_TXT_H
#define KGT_TXT_H

#include <string>

struct txt
{
	txt() : p(nullptr), n(0)
	{
	}
	const char* p;
	size_t n;
};

int escputt(const struct txt* t, FILE* f, int (*e)(int, FILE*));
int escputs(const char* s, FILE* f, int (*e)(int, FILE*));
bool is_binary_literal(const struct txt* t);
bool isalphastr(const struct txt* t);
bool txt_any(const struct txt* t, bool (*predicate)(int c));
int txtcasecmp(const struct txt *t1, const struct txt *t2);
int txtcmp(const struct txt *t1, const struct txt *t2);

#endif

