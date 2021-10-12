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

void ast_rules::destroy()
{
    for (auto rule : *this)
    {
        rule->destroy();
    }
    clear();
}

void ast_alts::destroy()
{
    for (auto alt : *this)
    {
        alt->destroy();
    }
    clear();
}

void ast_terms::destroy()
{
    for (auto term : *this)
    {
        term->destroy();
    }
    clear();
}

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms)
{
    return new ast_alt(invisible, terms);
}

struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts)
{
    return new ast_rule(name, alts);
}

struct ast_rule* ast_find_rule(const ast_grammar& grammar, const text& name)
{
    for (auto rule : grammar.rules)
    {
        if (rule->name.eq(name))
        {
            return (struct ast_rule*)rule;
        }
    }

    return nullptr;
}

void ast_free_rule(struct ast_rule *rule)
{
    if (rule != nullptr)
    {
        ast_free_alts(rule->alts);
        delete rule;
    }
}

void ast_free_alts(ast_alts& alts)
{
    for (auto alt : alts)
    {
        assert(alt->next == nullptr);
        for (auto term : alt->terms)
        {
            delete term;
        }
        delete alt;
    }
    alts.clear();
}

void ast_free_alt(struct ast_alt* alt)
{
    /* XXX: free contents */
    if (alt != nullptr)
    {
        ast_free_alt(alt->next);
        for (auto term : alt->terms)
        {
            delete term;
        }
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
