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
    FEATURE_AST_PROSE      = 1 << 0,
} ast_features;

typedef enum ast_term_type
{
    AST_EMPTY = 42,
    AST_RULE,
    AST_LITERAL,
    AST_TOKEN,
    AST_PROSE,
    AST_GROUP
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

    ast_term(ast_term_type type);
    ast_term(ast_term_type type, const text& text);
    ast_term(ast_term_type type, struct ast_rule* rule);
    ast_term(ast_term_type type, struct ast_alt* group);

    ~ast_term();

    void destroy();

    static ast_term* make_empty()
    {
        return new ast_term(AST_EMPTY);
    }

    static ast_term* make_rule(struct ast_rule* rule)
    {
        assert(rule != nullptr);

        return new ast_term(AST_RULE, rule);
    }

    static ast_term* make_cs_literal(const struct text& text)
    {
        return new ast_term(AST_LITERAL, text);
    }

    static ast_term* make_char(char c)
    {
        struct text t(c);
        return make_cs_literal(t);
    }

    static ast_term* make_token(const text& text)
    {
        return new ast_term(AST_TOKEN, text);
    }

    static ast_term* make_prose(const text& text)
    {
        return new ast_term(AST_PROSE, text);
    }

    static ast_term* make_group(struct ast_alt* group)
    {
        return new ast_term(AST_GROUP, group);
    }

    const ast_term_type type;
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
        assert(type == AST_RULE);
        xxx_rule = new_rule;
    }

    const ast_alts& group() const
    {
        assert(type == AST_GROUP);
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
    ast_alt(ast_term* term_list)
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

struct ast_alt* ast_make_alt(struct ast_term* terms);
struct ast_rule* ast_make_rule(const text& name, struct ast_alt* alts);

struct ast_rule* ast_find_rule(const ast_grammar& grammar, const text& name);

void ast_free_rule(struct ast_rule *rule);
void ast_free_alt(struct ast_alt* alt);
void ast_free_alts(ast_alts& alt);
void ast_free_term(struct ast_term *term);

bool ast_maybe_binary(const ast_grammar&);

#endif
