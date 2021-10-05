/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stdio.h>
#include <string.h>
#include <stdarg.h>
#include <stdlib.h>

#include "xalloc.h"
#include "txt.h"

void err_exit()
{
	printf("press return ... ");
	getchar();
	exit(EXIT_FAILURE);
}

void ok_exit()
{
	printf("press return ... ");
	getchar();
	exit(EXIT_SUCCESS);
}

void* xmalloc(size_t size)
{
	void* nuw;

	nuw = malloc(size);
	if (nuw == nullptr)
	{
		perror("malloc");
		err_exit();
	}

	return nuw;
}

char* xstrdup(const char* s)
{
	size_t len = strlen(s);
	char* nuw = (char*)xmalloc(len + 1);
	if (nuw == nullptr)
	{
		perror("xstrdup");
		err_exit();
	}
	errno_t err = strncpy_s(nuw, len + 1, s, len + 1);
	assert(err == 0);
	return nuw;
}

struct txt xtxtdup(const struct txt *t)
{
	struct txt nuw;

	assert(t != NULL);
	assert(t->p != NULL);

	nuw.n = t->n;
	nuw.p = (char*)xmalloc(nuw.n);

	memcpy((void *) nuw.p, t->p, nuw.n);

	return nuw;
}

void xerror(const char *msg, ...)
{
	va_list ap{};

	fprintf(stderr, "kgt: ");

	va_start(ap, msg);
	vfprintf(stderr, msg, ap);
	va_end(ap);

	fputc('\n', stderr);

	err_exit();
}
