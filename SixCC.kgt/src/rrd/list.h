/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_LIST_H
#define KGT_RRD_LIST_H

struct node;

struct list
{
	struct node *node;
	struct list *next;
};

void list_push_back(list **list, node *node);
node* list_pop_front(list** list);
void list_append(list **dst, list *src);
int list_compare(const list *a, const list *b);
list** list_tail(list** head);
void list_free(list **list);
unsigned list_count(const list *list);

#endif
