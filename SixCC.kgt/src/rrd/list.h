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
	inline void drop(int index)
	{
		erase(begin() + index);
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

	inline void replace(const list& other)
	{
		clear();
		add(other);
	}

	inline struct node* pop()
	{
		if (size() > 0)
		{
			struct node* node = *begin();
			erase(begin());
			return node;
		}
		return nullptr;
	}

	inline node* single_or_default() const
	{
		if (size() == 1)
		{
			return *begin();
		}
		return nullptr;
	}

	inline struct node* last_or_default() const
	{
		if (size() > 0)
		{
			return *rbegin();
		}
		return nullptr;
	}

	inline struct node* first() const
	{
		return *begin();
	}

	inline struct node* first_or_default() const
	{
		if (size() > 0)
		{
			return *begin();
		}
		return nullptr;
	}

	bool eq(const list& other) const;

private:
	struct node* node;
	struct list* next;
};

node* list_pop_front(list& list);
void list_append(list& dst, list& src);
int list_compare(const list& a, const list& b);
node* list_tail(list& list);
void list_free(list& list);
unsigned list_count(const list& list);

#endif
