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
#include "xalloc.h"

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms)
{
    return new ast_alt(invisible, terms);
}

struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts)
{
    return new ast_rule(name, alts);
}

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const text& name)
{
    const struct ast_rule* rule;

    for (rule = grammar; rule != nullptr; rule = rule->next)
    {
        if (rule->name().eq(name))
        {
            return (struct ast_rule*)rule;
        }
    }

    return nullptr;
}

void ast_free_rule(struct ast_rule *rule)
{
    /* XXX: free contents */
    if (rule != nullptr)
    {
        ast_free_rule(rule->next);
        ast_free_alt(rule->alts);
        delete rule;
    }
}

void ast_free_alt(struct ast_alt *alt)
{
    /* XXX: free contents */
    if (alt != nullptr)
    {
        ast_free_alt(alt->next);
        ast_free_term(alt->terms);
        delete alt;
    }
}

void ast_free_term(struct ast_term *term)
{
    /* XXX: free contents */
    if (term != nullptr)
    {
        ast_free_term(term->next);
        delete term;
    }
}
