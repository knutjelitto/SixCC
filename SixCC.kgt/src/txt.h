/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_TXT_H
#define KGT_TXT_H

#include <string>
#include <cassert>
#include <algorithm>

#include "compiler_specific.h"
#include "xalloc.h"

class text : private std::string
{
public:
	inline text()
		: std::string()
	{}

	inline text(const char* chars)
		: std::string(chars)
	{}

	inline text(const char* chars, size_t length)
		: std::string(chars, length)
	{}

	inline text(const char c)
		: std::string(c, 1)
	{}

	inline text(const std::string& chars)
		: std::string(chars)
	{}

	inline text(const text& other)
		: std::string(other.chars())
	{
	}

	inline char operator[](int index) const
	{
		return std::string::operator[](index);
	}

	inline const char* const chars() const
	{
		return c_str();
	}

	inline int length() const
	{
		return size();
	}

	inline bool any(bool (*predicate)(int c)) const
	{
		for (int i = 0; i < size(); i++)
		{
			if (predicate(std::string::operator[](i)))
			{
				return true;
			}
		}

		return false;
	}

	inline text tolower() const
	{
		std::string data(*this);
		std::transform(
			data.begin(), 
			data.end(),
			data.begin(),
			[](unsigned char c)
		{
			return std::tolower(c);
		});

		return text(data);
	}

	inline text ltrim() const
	{
		int offset = 0;
		while (offset < size() && std::isspace(std::string::operator[](offset++)))
		{
			;
		}

		return text(c_str() + offset, size() - offset);
	}

	inline text rtrim() const
	{
		int offset = size();
		while (offset > 0 && std::isspace(std::string::operator[](--offset)))
		{
			;
		}
		return text(c_str(), offset);
	}

	inline text trim()
	{
		return rtrim().ltrim();
	}


private:
};

bool is_binary_literal(const text& text);
bool isalphastr(const text& t);
bool txt_any(const struct txt* t, bool (*predicate)(int c));
int txtcasecmp(const struct txt *t1, const struct txt *t2);
int txtcmp(const struct txt *t1, const struct txt *t2);

WARN_UNUSED_RESULT int cat(const char* in, const char* indent);

#include "iwriter.h"

#endif

