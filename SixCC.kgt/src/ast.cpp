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
#if true
    return new ast_term_empty(invisible);
#else
    struct ast_term* nuw;

    nuw = (struct ast_term*)xmalloc(sizeof * nuw);
    nuw->type = TYPE_EMPTY;
    nuw->next = nullptr;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
#endif
}

struct ast_term * ast_make_rule_term(int invisible, struct ast_rule *rule)
{
#if true
    return new ast_term_rule(invisible, rule);
#else
    assert(rule != nullptr);

    struct ast_term *nuw;

    nuw = (struct ast_term*)xmalloc(sizeof *nuw);
    nuw->type   = TYPE_RULE;
    nuw->next   = nullptr;
    nuw->u.rule = rule;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
#endif
}

struct ast_term* ast_make_char_term(int invisible, char c)
{
    struct ast_term* nuw;
    char* a;

    a = (char*)xmalloc(1); /* XXX: i don't like this */
    a[0] = c;

    nuw = (struct ast_term*)xmalloc(sizeof * nuw);
    nuw->type = TYPE_CS_LITERAL;
    nuw->next = nullptr;
    nuw->u.literal.p = a;
    nuw->u.literal.n = 1;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
}

struct ast_term* ast_make_literal_term(int invisible, const struct txt* literal, bool ci)
{
    assert(literal != nullptr);
    assert(literal->p != nullptr);

    struct ast_term* nuw;

    nuw = (struct ast_term*)xmalloc(sizeof * nuw);
    nuw->type = (ci && isalphastr(literal)) ? TYPE_CI_LITERAL : TYPE_CS_LITERAL;
    nuw->next = nullptr;
    nuw->u.literal = *literal;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
}

struct ast_term * ast_make_token_term(int invisible, const char *token)
{
#if true
    return new ast_term_token(invisible, token);
#else
    assert(token != nullptr);

    struct ast_term *nuw;

    nuw = (struct ast_term*)xmalloc(sizeof *nuw);
    nuw->type    = TYPE_TOKEN;
    nuw->next    = nullptr;
    nuw->u.token = token;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
#endif
}

struct ast_term * ast_make_prose_term(int invisible, const char *prose)
{
    assert(prose != nullptr);

    struct ast_term *nuw;

    nuw = (struct ast_term*)xmalloc(sizeof *nuw);
    nuw->type    = TYPE_PROSE;
    nuw->next    = nullptr;
    nuw->u.prose = prose;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
}

struct ast_term* ast_make_group_term(int invisible, struct ast_alt* group)
{
    struct ast_term* nuw;

    nuw = (struct ast_term*)xmalloc(sizeof * nuw);
    nuw->type = TYPE_GROUP;
    nuw->next = nullptr;
    nuw->u.group = group;

    nuw->min = 1;
    nuw->max = 1;

    nuw->invisible = invisible;

    return nuw;
}

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms)
{
    struct ast_alt* nuw;

    nuw = (struct ast_alt*)xmalloc(sizeof * nuw);
    nuw->terms = terms;
    nuw->next = nullptr;

    nuw->invisible = invisible;

    return nuw;
}

struct ast_rule* ast_make_rule(const char* name, struct ast_alt* alts)
{
    return ast_make_rule(text(name), alts);
}

struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts)
{
#if true
    return new ast_rule(name, alts);
#else
    assert(name != nullptr);

    struct ast_rule* nuw;

    nuw = (struct ast_rule*)xmalloc(sizeof * nuw);
    nuw->name = name;
    nuw->alts = alts;
    nuw->next = nullptr;

    return nuw;
#endif
}

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const char* name)
{
    assert(name != nullptr);

    const struct ast_rule* p;

    for (p = grammar; p != nullptr; p = p->next)
    {
        if (0 == strcmp(p->name.chars(), name))
        {
            return (struct ast_rule*)p;
        }
    }

    return nullptr;
}

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const text& name)
{
    const struct ast_rule* p;

    for (p = grammar; p != nullptr; p = p->next)
    {
        if (0 == strcmp(p->name.chars(), name.chars()))
        {
            return (struct ast_rule*)p;
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
        free(alt);
    }
}

void ast_free_term(struct ast_term *term)
{
    /* XXX: free contents */
    if (term != nullptr)
    {
        ast_free_term(term->next);
        free(term);
    }
}
