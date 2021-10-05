/*
 * Copyright 2021 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stdarg.h>

#include "parsing-error.h"

void err(error_context error_context, const char* fmt, ...)
{
    parsing_error error{};
    va_list ap{};

    assert(error_context.errors != NULL);

    error.line = error_context.line;
    error.col = error_context.col;

    va_start(ap, fmt);
    vsnprintf(error.description, PARSING_ERROR_DESCRIPTION_SIZE, fmt, ap);
    va_end(ap);

    error_context.errors->add(error);
}

void err_expected(error_context lex_state, const char* token)
{
    err(lex_state, "Syntax error: expected %s", token);
}

void err_unimplemented(error_context lex_state, const char* s)
{
    err(lex_state, "Unimplemented: %s", s);
}


