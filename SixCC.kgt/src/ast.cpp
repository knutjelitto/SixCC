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

struct ast_term* ast_make_empty_term(int invisible)
{
    return new ast_term_empty(invisible);
}

struct ast_term * ast_make_rule_term(int invisible, struct ast_rule *rule)
{
    assert(rule != nullptr);

    return new ast_term_rule(invisible, rule);
}


struct ast_term* ast_make_literal_term(int invisible, const text& literal, bool ci)
{
    ci = ci && isalphastr(literal);

    return ci
        ? (ast_term*)new ast_term_ci_literal(invisible, literal)
        : (ast_term*)new ast_term_cs_literal(invisible, literal);
}

struct ast_term* ast_make_char_term(int invisible, char c)
{
    return new ast_term_cs_literal(invisible, text(c));
}

struct ast_term * ast_make_token_term(int invisible, const text& token)
{
    return new ast_term_token(invisible, token);
}

struct ast_term * ast_make_prose_term(int invisible, const text& prose)
{
    return new ast_term_prose(invisible, prose);
}

struct ast_term* ast_make_group_term(int invisible, struct ast_alt* group)
{
    return new ast_term_group(invisible, group);
}

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms)
{
    return new ast_alt(invisible, terms);
}

struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts)
{
    return new ast_rule(name, alts);
}

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const char* name)
{
    assert(name != nullptr);

    const struct ast_rule* rule;

    for (rule = grammar; rule != nullptr; rule = rule->next)
    {
        if (0 == strcmp(rule->name().chars(), name))
        {
            return (struct ast_rule*)rule;
        }
    }

    return nullptr;
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
