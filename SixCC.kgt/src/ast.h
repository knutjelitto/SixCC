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

struct ast_term;
struct ast_alt;
struct ast_rule;

struct ast_rules : std::vector<ast_rule*>
{
    void destroy();
};

struct ast_terms : std::vector<ast_term*>
{
    void destroy();
};

struct ast_alts : std::vector<ast_alt*>
{
    void destroy();
};

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
    static int ctor_count;
    static int dtor_count;

    ast_term(ast_term_type type, int invisible);
    ast_term(ast_term_type type, int invisible, const text& text);
    ast_term(ast_term_type type, int invisible, struct ast_rule* rule);
    ast_term(ast_term_type type, int invisible, struct ast_alt* group);

    ~ast_term();

    void destroy();

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

    static ast_term* make_token(int invisible, const text& text)
    {
        return new ast_term(TYPE_TOKEN, invisible, text);
    }

    static ast_term* make_prose(int invisible, const text& text)
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

    const struct ast_rule* rule() const
    {
        return xxx_rule;
    }

    void set_rule(ast_rule* new_rule)
    {
        assert(type == TYPE_RULE);
        xxx_rule = new_rule;
    }

    const ast_alts& group() const
    {
        assert(type == TYPE_GROUP);
        return xxx_group;
    }

private:
    const struct text xxx_characters;
    struct ast_rule* xxx_rule = nullptr; /* just for sake of the name */
    struct ast_alts xxx_group;
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

    void destroy()
    {
        terms.destroy();
        assert(terms.size() == 0);
        delete this;
    }

    int invisible;
    struct ast_terms terms;

    struct ast_alt* next = nullptr;
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
    ast_rule(const text name, ast_alt* group)
        : name(name)
    {
        for (auto alt = group; alt != nullptr; alt = alt->next)
        {
            alts.push_back(alt);
        }
        for (auto alt : alts)
        {
            alt->next = nullptr;
        }
    }

    void destroy()
    {
        alts.destroy();
        delete this;
    }

    const text name;
    ast_alts alts;
};

struct ast_grammar
{
    void destroy()
    {
        rules.destroy();
    }

    ast_rules rules;
};

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms);
struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts);

struct ast_rule* ast_find_rule(const ast_grammar& grammar, const text& name);

void ast_free_rule(struct ast_rule *rule);
void ast_free_alt(struct ast_alt* alt);
void ast_free_alts(ast_alts& alt);
void ast_free_term(struct ast_term *term);

bool ast_maybe_binary(const ast_grammar&);

#endif
