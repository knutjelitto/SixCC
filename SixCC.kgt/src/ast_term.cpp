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

int ast_term::ctor_count = 0;
int ast_term::dtor_count = 0;


ast_term::ast_term(ast_term_type type, int invisible)
    : type(type), invisible(invisible)
{
    ctor_count++;
}

ast_term::ast_term(ast_term_type type, int invisible, const struct text& text)
    : type(type), invisible(invisible), xxx_characters(text)
{
    ctor_count++;
}

ast_term::ast_term(ast_term_type type, int invisible, struct ast_rule* rule)
    : type(type), invisible(invisible), xxx_rule(rule)
{
    ctor_count++;
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
    ctor_count++;
}

ast_term::~ast_term()
{
    dtor_count++;
}

void ast_term::destroy()
{
    if (type == TYPE_RULE)
    {
        assert(xxx_group.size() == 0);
        assert(xxx_characters.size() == 0);
        xxx_rule->destroy();
    }
    else if (type == TYPE_GROUP)
    {
        assert(xxx_rule == nullptr);
        assert(xxx_characters.size() == 0);
        xxx_group.destroy();
    }
}
