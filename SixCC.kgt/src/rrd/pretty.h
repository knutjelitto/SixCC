/*
 * Copyright 2014-2017 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_RRD_PRETTY_H
#define KGT_RRD_PRETTY_H

struct node;

node* rrd_pretty_ci(int *changed, node **);
node* rrd_pretty_affixes(int *changed, node **);
node* rrd_pretty_bottom(int *changed, node **);
node* rrd_pretty_redundant(int *changed, node **);
node* rrd_pretty_skippable(int *changed, node **);
node* rrd_pretty_collapse(int *changed, node **);
node* rrd_pretty_nested(int *changed, node **);
node* rrd_pretty_roll(int *changed, node **);

void rrd_pretty(node **);

#endif
