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

enum ast_features
{
    FEATURE_AST_CI_LITERAL = 1 << 0,
    FEATURE_AST_PROSE      = 1 << 1,
    FEATURE_AST_BINARY     = 1 << 2,
    FEATURE_AST_INVISIBLE  = 1 << 3
};

enum ast_term_type
{
	TYPE_EMPTY,
	TYPE_RULE,
	TYPE_CS_LITERAL,
	TYPE_CI_LITERAL,
	TYPE_TOKEN,
	TYPE_PROSE,
	TYPE_GROUP
};

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
		: type(type), next(nullptr), invisible(invisible)
	{
		min = 1;
		max = 1;
	}

	ast_term()
	{
	}

	enum ast_term_type type;
	struct ast_term* next;
	int invisible;
	unsigned int min;
	unsigned int max; /* false (0) for unlimited */

	union xxx
	{
		xxx() {}
		const struct ast_rule *rule; /* just for sake of the name */
		struct txt literal;
		const char *token;
		const char *prose;
		struct ast_alt *group;
	} u;

};

struct ast_term_empty : ast_term
{
	ast_term_empty(int invisible) : ast_term(TYPE_EMPTY, invisible)
	{
	}
};

struct ast_term_rule : ast_term
{
	ast_term_rule(int invisible, const struct ast_rule* rule) : ast_term(TYPE_RULE, invisible)
	{
		u.rule = rule;
	}
};

struct ast_term_cs_literal : ast_term
{
	ast_term_cs_literal(int invisible, struct txt literal) : ast_term(TYPE_CS_LITERAL, invisible)
	{
		u.literal = literal;
	}
};

struct ast_term_ci_literal : ast_term
{
	ast_term_ci_literal(int invisible, struct txt literal) : ast_term(TYPE_CI_LITERAL, invisible)
	{
		u.literal = literal;
	}
};

struct ast_term_token : ast_term
{
	ast_term_token(int invisible, const char* token) : ast_term(TYPE_TOKEN, invisible)
	{
		u.token = token;
	}
};

struct ast_term_prose : ast_term
{
	ast_term_prose(int invisible, const char* prose) : ast_term(TYPE_PROSE, invisible)
	{
		u.prose = prose;
	}
};

struct ast_term_group : ast_term
{
	ast_term_group(int invisible, struct ast_alt* group) : ast_term(TYPE_RULE, invisible)
	{
		u.group = group;
	}
};

/*
 * An alternative is one of several choices:
 *
 * a | b | c
 */
struct ast_alt
{
	struct ast_term* terms;
	/* TODO: struct ast_term *negs; - negative terms here */

	int invisible;

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
	const char* name;
	struct ast_alt* alts;

	struct ast_rule* next;
};

struct ast_term* ast_make_empty_term(int invisible);
struct ast_term* ast_make_rule_term(int invisible, struct ast_rule* rule);
struct ast_term* ast_make_char_term(int invisible, char c);
struct ast_term* ast_make_literal_term(int invisible, const struct txt* literal, int ci);
struct ast_term* ast_make_token_term(int invisible, const char* token);
struct ast_term* ast_make_prose_term(int invisible, const char* prose);
struct ast_term* ast_make_group_term(int invisible, struct ast_alt* group);

struct ast_alt* ast_make_alt(int invisible, struct ast_term* terms);
struct ast_rule* ast_make_rule(const char* name, struct ast_alt* alts);

struct ast_rule* ast_find_rule(const struct ast_rule* grammar, const char* name);

void ast_free_rule(struct ast_rule *rule);
void ast_free_alt(struct ast_alt *alt);
void ast_free_term(struct ast_term *term);

bool ast_maybe_binary(const struct ast_rule *ast);

#endif
