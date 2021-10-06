/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>
#include <ctype.h>

#include "txt.h"

bool txt_any(const struct txt* t, bool (*predicate)(int c))
{
	size_t i;

	assert(t != NULL);

	for (i = 0; i < t->n; i++)
	{
		if (predicate(t->p[i]))
		{
			return true;
		}
	}

	return false;
}

bool is_binary_literal(const struct txt* t)
{
	size_t i;

	assert(t != nullptr);

	for (i = 0; i < t->n; i++)
	{
		if (!isprint((unsigned char)(t->p[i])))
		{
			return true;
		}
	}

	return false;
}

bool isalphastr(const struct txt* t)
{
	size_t i;

	assert(t != nullptr);
	assert(t->p != nullptr);
	assert(t->n == strlen(t->p));

	for (i = 0; i < t->n; i++)
	{
		if (isalpha((unsigned char)t->p[i]))
		{
			return true;
		}
	}

	return false;
}

int txtcasecmp(const struct txt *t1, const struct txt *t2)
{
	size_t i;

	assert(t1 != NULL);
	assert(t2 != NULL);

	if (t1->n < t2->n) {
		return -1;
	}

	if (t1->n > t2->n) {
		return +1;
	}

	for (i = 0; i < t1->n; i++) {
		if (tolower((unsigned char) t1->p[i]) != tolower((unsigned char) t2->p[i])) {
			return (int) (unsigned char) t1->p[i] - (int) (unsigned char) t2->p[i];
		}
	}

	return 0;
}

int txtcmp(const struct txt *t1, const struct txt *t2)
{
	size_t i;

	assert(t1 != NULL);
	assert(t2 != NULL);

	if (t1->n < t2->n) {
		return -1;
	}

	if (t1->n > t2->n) {
		return +1;
	}

	for (i = 0; i < t1->n; i++) {
		if (t1->p[i] != t2->p[i]) {
			return (int) (unsigned char) t1->p[i] - (int) (unsigned char) t2->p[i];
		}
	}

	return 0;
}

