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

enum node_type
{
	NODE_LITERAL = 42,
	NODE_RULE,
	NODE_PROSE,
	NODE_ALT,
	NODE_ALT_SKIPPABLE,
	NODE_SEQ,
	NODE_LOOP
};

struct list;

struct node final
{
	static int ctor_count;
	static int dtor_count;

	node(node_type type, node* forward, node* backward);
	node(node_type type, const text& text);
	node(node_type type, list* list);

	~node();

	node_type type;

	void tolower()
	{
		xxx_text = xxx_text.tolower();
	}

	void become_alt_skippable();

	const text& literal() const
	{
		assert(type == NODE_LITERAL);

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

	list& alt() const
	{
		assert(type == NODE_ALT || type == NODE_ALT_SKIPPABLE);

		return *xxx_list;
	}

	list& seq() const
	{
		assert(type == NODE_SEQ);

		return *xxx_list;
	}

	list& list() const
	{
		assert(type == NODE_SEQ || type == NODE_ALT || type == NODE_ALT_SKIPPABLE);

		return *xxx_list;
	}

	struct list* altx() const
	{
		assert(type == NODE_ALT || type == NODE_ALT_SKIPPABLE);

		return xxx_list;
	}

	struct list* seqx() const
	{
		assert(type == NODE_SEQ);

		return xxx_list;
	}

	void list_free();

	bool is_list() const
	{
		return type == NODE_SEQ || type == NODE_ALT || type == NODE_ALT_SKIPPABLE;
	}
	bool is_literal() const
	{
		return type == NODE_LITERAL;
	}
	bool is_text() const
	{
		return is_literal() || type == NODE_RULE || type == NODE_PROSE;
	}

	struct
	{
		struct node* forward;
		struct node* backward;
		unsigned int min;
		unsigned int max;
	} loop;

private:

	text xxx_text;
	struct list* xxx_list;

};

node* node_create_literal(const text& literal);
node* node_create_name(const text& name);
node* node_create_prose(const text& name);
node* node_create_alt(list* alt);
node* node_create_alt_skippable(struct list* alt);
node* node_create_seq(list* seq);
node* node_create_loop(node* forward, node* backward);

void node_make_seq(struct node **n);
bool node_compare(const struct node *a, const struct node *b);
void loop_flip(struct node *n);

void node_free(struct node*);

#endif

