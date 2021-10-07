/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>
#include <ctype.h>

#include "txt.h"

bool is_binary_literal(const text& t)
{
	return t.any(
		[](int c)
	{
		return !isprint(c);
	});
}

bool isalphastr(const text& t)
{
	return t.any(
		[](int c)
		{
		return isalpha(c) != 0;
		});
}

