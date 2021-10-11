/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_AST_H
#define KGT_AST_H

#include <deque>
#include <vector>
#include <string>
#include "txt.h"

struct ast_alt;

typedef enum
{
    FEATURE_AST_CI_LITERAL = 1 << 0,
    FEATURE_AST_PROSE      = 1 << 1,
    FEATURE_AST_BINARY     = 1 << 2,
    FEATURE_AST_INVISIBLE  = 1 << 3
} ast_features;

typedef enum ast_term_type
{
    TYPE_EMPTY = 42,
    TYPE_RULE,
    TYPE_CS_LITERAL,
    TYPE_CI_LITERAL,
    TYPE_TOKEN,
    TYPE_PROSE,
    TYPE_GROUP
} ast_term_type;

/*
 * A term is a sequential list of items within an alt. Each item may be
 * a terminal literal, a production rule name, or a group of terms.
 *
 * A term may be repeated a number of times, as in the EBNF x * 3 construct.
 *
 * a + b + c ;
 */
struct ast_term final
{
    ast_term(ast_term_type type, int invisible)
        : type(type), invisible(invisible)
    {
    }

    ast_term(ast_term_type type, int invisible, const text& text)
        : type(type), invisible(invisible), xxx_characters(text)
    {
    }

    ast_term(ast_term_type type, int invisible, const struct ast_rule* rule)
        : type(type), invisible(invisible), xxx_rule(rule)
    {
    }

    ast_term(ast_term_type type, int invisible, struct ast_alt* group)
        : type(type), invisible(invisible), xxx_group(group)
    {
    }

    static ast_term* make_empty(int invisible)
    {
        return new ast_term(TYPE_EMPTY, invisible);
    }

    static ast_term* make_rule(int invisible, struct ast_rule* rule)
    {
        assert(rule != nullptr);

        return new ast_term(TYPE_RULE, invisible, rule);
    }

    static ast_term* make_ci_literal(int invisible, const struct text& text)
    {
        return new ast_term(TYPE_CI_LITERAL, invisible, text);
    }

    static ast_term* make_cs_literal(int invisible, const struct text& text)
    {
        return new ast_term(TYPE_CS_LITERAL, invisible, text);
    }

    static ast_term* make_literal(int invisible, const text& literal, bool ci)
    {
        ci = ci && isalphastr(literal);

        return ci
            ? make_ci_literal(invisible, literal)
            : make_cs_literal(invisible, literal);
    }

    static ast_term* make_char(int invisible, char c)
    {
        struct text t(c);
        return make_cs_literal(invisible, t);
    }

    static ast_term* make_token(int invisible, const struct text& text)
    {
        return new ast_term(TYPE_TOKEN, invisible, text);
    }

    static ast_term* make_prose(int invisible, const struct text& text)
    {
        return new ast_term(TYPE_PROSE, invisible, text);
    }

    static ast_term* make_group(int invisible, struct ast_alt* group)
    {
        return new ast_term(TYPE_GROUP, invisible, group);
    }

    const ast_term_type type;
    int invisible;
    ast_term* next = nullptr;
    unsigned int min = 1;
    unsigned int max = 1; /* false (0) for unlimited */

    const struct text& text() const
    {
        return xxx_characters;
    }

    const char text(int index) const
    {
        return text()[index];
    }

    const struct ast_rule* rule() const
    {
        return xxx_rule;
    }

    void set_rule(const ast_rule* new_rule)
    {
        assert(type == TYPE_RULE);
        xxx_rule = new_rule;
    }

    const ast_alt* group() const
    {
        return xxx_group;
    }

private:
    const struct text xxx_characters;
    const struct ast_rule* xxx_rule; /* just for sake of the name */
    const struct ast_alt* xxx_group;
};

struct ast_terms : std::deque<ast_term*>
{
};

/*
 * An alternative is one of several choices:
 *
 * a | b | c
 */
struct ast_alt
{
    ast_alt(int invisible, ast_term* term_list)
        : invisible(invisible)
    {
        for (auto term = term_list; term != nullptr; term = term->next)
        {
            terms.push_back(term);
        }
        for (auto term : terms)
        {
            term->next = nullptr;
        }
    }

    int invisible;
    struct ast_terms terms;

    struct ast_alt* next = nullptr;
};

struct ast_alts : std::deque<ast_alt*>
{
};

/*
 * A grammar is a list of production rules. Each rule maps a name onto a list
 * of alternatives:
 *
 * name1 := alt1 | alt2 | alt3 ;
 * name2 := alt1 ;
 */
struct ast_rule
{
    ast_rule(const text name, ast_alt* alts)
        : name(name), alts(alts)
    {
    }

    const text name;
    ast_alt* alts;

    ast_rule* next = nullptr;
private:
};

struct ast_rules : std::vector<ast_rule*>
{
};

struct ast_grammar
{
    ast_rules rules;
};

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms);
struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts);

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const text& name);
struct ast_rule* ast_find_rule(const ast_grammar& grammar, const text& name);

void ast_free_rule(struct ast_rule *rule);
void ast_free_alt(struct ast_alt *alt);
void ast_free_term(struct ast_term *term);

bool ast_maybe_binary(const ast_grammar&);

#endif
