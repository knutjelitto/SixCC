/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>

#include "txt.h"
#include "ast.h"

ast_term::ast_term(ast_term_type type, int invisible)
    : type(type), invisible(invisible)
{
}

ast_term::ast_term(ast_term_type type, int invisible, const struct text& text)
    : type(type), invisible(invisible), xxx_characters(text)
{
}

ast_term::ast_term(ast_term_type type, int invisible, const struct ast_rule* rule)
    : type(type), invisible(invisible), xxx_rule(rule)
{
}

ast_term::ast_term(ast_term_type type, int invisible, struct ast_alt* group)
    : type(type), invisible(invisible)
{
    for (auto alt = group; alt != nullptr; alt = alt->next)
    {
        xxx_group.push_back(alt);
    }
    for (auto alt : xxx_group)
    {
        alt->next = nullptr;
    }
}
