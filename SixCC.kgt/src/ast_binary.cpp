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

static bool walk_alts(const ast_alts& alts);

static int walk_term(const struct ast_term* term)
{
    assert(term != nullptr);

    switch (term->type)
    {
        case AST_LITERAL:
            return is_binary_literal(term->text());

        case AST_GROUP:
            return walk_alts(term->group());

        default:
            return false;
    }
}

static bool walk_alts(const ast_alts& alts)
{
    for (auto alt : alts)
    {
        for (auto term : alt->terms)
        {
            if (walk_term(term))
            {
                return true;
            }
        }
    }

    return false;
}

bool ast_maybe_binary(const ast_grammar& grammar)
{
    for (auto rule : grammar.rules)
    {
        if (walk_alts(rule->alts))
        {
            return true;
        }
    }

    return false;
}

