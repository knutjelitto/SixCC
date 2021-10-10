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

	inline void append(const list& other)
	{
		for (struct node* node : other)
		{
			push_back(node);
		}
	}

	inline void replace(const list& other)
	{
		clear();
		append(other);
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

	inline void pop_front()
	{
		erase(begin());
	}

	inline void push_front(node* node)
	{
		insert(begin(), node);
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
};

node* list_pop_front(list& list);
void list_free(list& list);
unsigned list_count(const list& list);

#endif
