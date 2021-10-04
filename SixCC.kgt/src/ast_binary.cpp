/*
 * Copyright 2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#include <assert.h>
#include <stddef.h>
#include <ctype.h>

#include "txt.h"
#include "ast.h"

static bool walk_alts(const struct ast_alt *alts);

static int walk_term(const struct ast_term* term)
{
    assert(term != nullptr);

    switch (term->type)
    {
        case TYPE_CI_LITERAL:
        case TYPE_CS_LITERAL:
            return is_binary_literal(&term->u.literal);

        case TYPE_GROUP:
            return walk_alts(term->u.group);

        default:
            return false;
    }
}

static bool walk_alts(const struct ast_alt* alts)
{
    const struct ast_alt* alt;
    const struct ast_term* term;

    for (alt = alts; alt != nullptr; alt = alt->next)
    {
        for (term = alt->terms; term != nullptr; term = term->next)
        {
            if (walk_term(term))
            {
                return true;
            }
        }
    }

    return false;
}

bool ast_maybe_binary(const struct ast_rule* grammar)
{
    const struct ast_rule* rule;

    for (rule = grammar; rule != nullptr; rule = rule->next)
    {
        if (walk_alts(rule->alts))
        {
            return true;
        }
    }

    return false;
}

