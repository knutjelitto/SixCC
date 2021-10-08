/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_NODE_H
#define KGT_RRD_NODE_H

#include "../txt.h"

typedef enum
{
	FEATURE_RRD_CI_LITERAL = 1 << 0
} rrd_features;

typedef enum
{
	NODE_CI_LITERAL = 42,
	NODE_CS_LITERAL,
	NODE_RULE,
	NODE_PROSE,
	NODE_ALT,
	NODE_ALT_SKIPPABLE,
	NODE_SEQ,
	NODE_LOOP
} node_type;

struct node
{
	node(node_type type, int invisible)
		: type(type), invisible(invisible)
	{
	}

	node(node_type type, int invisible, const text& text)
		: type(type), invisible(invisible), xxx_text(text)
	{
	}

	node(node_type type, int invisible, struct list* list)
		: type(type), invisible(invisible), xxx_list(list)
	{
	}

	node_type type;
	int invisible;

	text xxx_text;
	struct list* xxx_list;

	void tolower()
	{
		xxx_text = xxx_text.tolower();
	}

	const text& literal() const
	{
		assert(type == NODE_CI_LITERAL || type == NODE_CS_LITERAL);

		return xxx_text;
	}

	const text& name() const
	{
		assert(type == NODE_RULE);

		return xxx_text;
	}

	const text& prose() const
	{
		assert(type == NODE_PROSE);

		return xxx_text;
	}

	struct list* alt() const
	{
		assert(type == NODE_ALT || type == NODE_ALT_SKIPPABLE);

		return xxx_list;
	}

	struct list* seq() const
	{
		assert(type == NODE_SEQ);

		return xxx_list;
	}

	void list_free();

	struct
	{
		struct
		{
			struct node* forward;
			struct node* backward;
			unsigned int min;
			unsigned int max;
		} loop;
	} u;

private:
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

