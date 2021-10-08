/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_AST_H
#define KGT_AST_H

#include "txt.h"

struct ast_alt;
struct txt;

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

#ifdef min
#undef min
#undef max
#endif

/*
 * A term is a sequential list of items within an alt. Each item may be
 * a terminal literal, a production rule name, or a group of terms.
 *
 * A term may be repeated a number of times, as in the EBNF x * 3 construct.
 *
 * a + b + c ;
 */
struct ast_term
{
    ast_term(ast_term_type type, int invisible)
        : type(type), invisible(invisible), next(nullptr), min(1), max(1)
    {
        min = 1;
        max = 1;
    }

    ast_term(ast_term_type type, int invisible, const text& text)
        : type(type), invisible(invisible), next(nullptr), min(1), max(1), xxx_characters(text)
    {
    }

    ast_term(ast_term_type type, int invisible, const struct ast_rule* rule)
        : type(type), invisible(invisible), next(nullptr), min(1), max(1), xxx_rule(rule)
    {
    }

    ast_term(ast_term_type type, int invisible, struct ast_alt* group)
        : type(type), invisible(invisible), next(nullptr), min(1), max(1), xxx_group(group)
    {
    }

    const ast_term_type type;
    int invisible;
    struct ast_term* next;
    unsigned int min;
    unsigned int max; /* false (0) for unlimited */

    const class text& text() const
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

    void set_rule(const struct ast_rule* new_rule)
    {
        assert(type == TYPE_RULE);
        xxx_rule = new_rule;
    }

    const struct ast_alt* group() const
    {
        return xxx_group;
    }

private:
    const class text xxx_characters;
    const struct ast_rule* xxx_rule; /* just for sake of the name */
    const struct ast_alt* xxx_group;
};

struct ast_term_empty : ast_term
{
    ast_term_empty(int invisible)
        : ast_term(TYPE_EMPTY, invisible)
    {
    }
};

struct ast_term_rule : ast_term
{
    ast_term_rule(int invisible, const struct ast_rule* rule)
        : ast_term(TYPE_RULE, invisible, rule)
    {
    }
};

struct ast_term_text : ast_term
{
    ast_term_text(ast_term_type type, int invisible, const class text& text)
        : ast_term(type, invisible, text)
    {
    }
};

struct ast_term_cs_literal : ast_term_text
{
    ast_term_cs_literal(int invisible, const class text& text)
        : ast_term_text(TYPE_CS_LITERAL, invisible, text)
    {
    }
};

struct ast_term_ci_literal : ast_term_text
{
    ast_term_ci_literal(int invisible, const class text& text)
        : ast_term_text(TYPE_CI_LITERAL, invisible, text)
    {
    }
};

struct ast_term_token : ast_term_text
{
    ast_term_token(int invisible, const class text& text)
        : ast_term_text(TYPE_TOKEN, invisible, text)
    {
    }
};

struct ast_term_prose : ast_term_text
{
    ast_term_prose(int invisible, const class text& prose)
        : ast_term_text(TYPE_PROSE, invisible, prose)
    {
    }
};

struct ast_term_group : ast_term
{
    ast_term_group(int invisible, struct ast_alt* group)
        : ast_term(TYPE_GROUP, invisible, group)
    {
    }
};

/*
 * An alternative is one of several choices:
 *
 * a | b | c
 */
struct ast_alt
{
    ast_alt() = delete;

    ast_alt(int invisible, ast_term* terms)
        : invisible(invisible), terms(terms), next(nullptr)
    {
    }

    int invisible;
    struct ast_term* terms;

    struct ast_alt* next;
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
        : xxx_name(name), alts(alts), next(nullptr)
    {
    }

    const text& name() const
    {
        return xxx_name;
    }

    const text xxx_name;
    struct ast_alt* alts;
    struct ast_rule* next;
};

struct ast_term* ast_make_empty_term(int invisible);
struct ast_term* ast_make_rule_term(int invisible, struct ast_rule* rule);
struct ast_term* ast_make_char_term(int invisible, char c);
struct ast_term* ast_make_literal_term(int invisible, const text& literal, bool ci);
struct ast_term* ast_make_token_term(int invisible, const text& token);
struct ast_term* ast_make_prose_term(int invisible, const text& prose);
struct ast_term* ast_make_group_term(int invisible, struct ast_alt* group);

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms);
struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts);

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const char* name);
struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const text& name);

void ast_free_rule(struct ast_rule *rule);
void ast_free_alt(struct ast_alt *alt);
void ast_free_term(struct ast_term *term);

bool ast_maybe_binary(const struct ast_rule *ast);

#endif
