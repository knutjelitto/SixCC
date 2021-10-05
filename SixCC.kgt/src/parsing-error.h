/*
 * Copyright 2021 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_PARSING_ERROR_H
#define KGT_PARSING_ERROR_H

#include <string>
#include <queue>

#define PARSING_ERROR_DESCRIPTION_SIZE (1024)

struct parsing_error
{
	int line;
	int col;
	char description[PARSING_ERROR_DESCRIPTION_SIZE];
};

struct parsing_errors
{
	inline void add(parsing_error error)
	{
		queue.push(error);
	}

	inline bool pop(parsing_error* error)
	{
		if (!queue.empty())
		{
			*error = queue.front();
			queue.pop();
			return true;
		}

		return false;
	}

private:
	std::queue<parsing_error> queue;
};

struct error_context
{
	unsigned int line;
	unsigned int col;
	parsing_errors* errors;
};

void err(error_context error_context, const char* fmt, ...);
void err_expected(error_context lex_state, const char* token);
void err_unimplemented(error_context lex_state, const char* s);

#endif
