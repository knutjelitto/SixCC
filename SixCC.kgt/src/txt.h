/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_TXT_H
#define KGT_TXT_H

#include <string>

#include "compiler_specific.h"

struct txt
{
	txt() : p(nullptr), n(0)
	{
	}
	txt(const char* chars, size_t length) : p(chars), n(length)
	{
	}

	const char* p;
	size_t n;
};

struct text
{
	inline text() : str()
	{
	}

	inline text(const txt t) : str(t.p)
	{
	}

	inline text(const char* chars) : str(chars)
	{
	}

	inline const char* const chars() const
	{
		return str.c_str();
	}

	inline int length() const
	{
		return str.size();
	}

private:
	std::string str;
};

bool is_binary_literal(const struct txt* t);
bool isalphastr(const struct txt* t);
bool txt_any(const struct txt* t, bool (*predicate)(int c));
int txtcasecmp(const struct txt *t1, const struct txt *t2);
int txtcmp(const struct txt *t1, const struct txt *t2);

WARN_UNUSED_RESULT int cat(const char* in, const char* indent);

#include "iwriter.h"

#endif

