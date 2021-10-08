/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <algorithm>
#include <cctype>

#include <assert.h>
#include <stddef.h>

#include "txt.h"

 // trim from start (in place)
static inline void ltrim(std::string& s)
{
    s.erase(s.begin(), std::find_if(s.begin(), s.end(), [](unsigned char ch)
        {
            return !std::isspace(ch);
        }));
}

// trim from end (in place)
static inline void rtrim(std::string& s)
{
    s.erase(std::find_if(s.rbegin(), s.rend(), [](unsigned char ch)
        {
            return !std::isspace(ch);
        }).base(), s.end());
}

// trim from both ends (in place)
static inline void trim(std::string& s)
{
    ltrim(s);
    rtrim(s);
}

// trim from start (copying)
static inline std::string ltrim_copy(std::string s)
{
    ltrim(s);
    return s;
}

// trim from end (copying)
static inline std::string rtrim_copy(std::string s)
{
    rtrim(s);
    return s;
}

// trim from both ends (copying)
static inline std::string trim_copy(std::string s)
{
    trim(s);
    return s;
}

text text::tolower() const
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

text text::toupper() const
{
	std::string data(*this);
	std::transform(
		data.begin(),
		data.end(),
		data.begin(),
		[](unsigned char c)
		{
			return std::toupper(c);
		});

	return text(data);
}

text text::ltrim() const
{
    return ltrim_copy(*this);
}

text text::rtrim() const
{
    return rtrim_copy(*this);
}

text text::trim() const
{
    return trim_copy(*this);
}

bool is_binary_literal(const text& t)
{
	return t.any(
		[](int c)
	{
		return !std::isprint(c);
	});
}

bool isalphastr(const text& t)
{
	return t.any(
		[](int c)
		{
		return std::isalpha(c) != 0;
		});
}

