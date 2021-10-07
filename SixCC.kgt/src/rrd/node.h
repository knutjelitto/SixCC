/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_NODE_H
#define KGT_RRD_NODE_H

#include "../txt.h"

enum rrd_features
{
	FEATURE_RRD_CI_LITERAL = 1 << 0
};

enum node_type
{
	NODE_CI_LITERAL,
	NODE_CS_LITERAL,
	NODE_RULE,
	NODE_PROSE,
	NODE_ALT,
	NODE_ALT_SKIPPABLE,
	NODE_SEQ,
	NODE_LOOP
};

struct node
{
	enum node_type type;
	int invisible;

	struct
	{
		text literal; /* TODO: point to ast_literal instead */
		text name;   /* TODO: point to ast_rule instead */
		text prose;

		struct list* alt;
		struct list* seq;

		struct
		{
			struct node* forward;
			struct node* backward;
			unsigned int min;
			unsigned int max;
		} loop;
	} u;
};

struct node* node_create_ci_literal(int invisible, const text& literal);
struct node* node_create_cs_literal(int invisible, const text& literal);
struct node* node_create_name(int invisible, const text& name);
struct node* node_create_name(int invisible, const text& name);
struct node* node_create_prose(int invisible, const text& name);
struct node* node_create_alt(int invisible, struct list* alt);
struct node* node_create_alt_skippable(int invisible, struct list* alt);
struct node* node_create_seq(int invisible, struct list* seq);
struct node* node_create_loop(int invisible, struct node* forward, struct node* backward);

void node_make_seq(int invisible, struct node **n);
bool node_compare(const struct node *a, const struct node *b);
void loop_flip(struct node *n);

void node_free(struct node*);

#endif

