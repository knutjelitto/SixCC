/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_LIST_H
#define KGT_RRD_LIST_H

#include <vector>

struct node;

struct list : std::vector<struct node*>
{
	struct node *node;
	struct list *next;

	inline int count()
	{
		return size();
	}

	inline void free()
	{
		clear();
	}

	inline void add(struct node* node)
	{
		push_back(node);
	}

	inline void add(const list& other)
	{
		for (struct node* node : other)
		{
			push_back(node);
		}
	}

	inline struct node* pop()
	{
		struct node* node = *begin();
		erase(begin());
		return node;
	}

	bool eq(const list& other);
};

void list_push_back(list** list, node* node);
node* list_pop_front(list** list);
void list_append(list **dst, list *src);
int list_compare(const list *a, const list *b);
list** list_tail(list** head);
void list_free(list **list);
unsigned list_count(const list *list);

#endif
