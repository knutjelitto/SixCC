/*
 * Copyright 2021 Knut Jelitto
 *
 * See LICENCE for the full copyright terms.
 */

#pragma once
#ifndef _lexing_support_h
#define _lexing_support_h

 /*
  * .byte is 0-based.
  * .line, .col, and .saved_col are 1-based; 0 means unknown.
  */
struct lx_pos
{
	unsigned byte;
	unsigned line;
	unsigned col;
	unsigned saved_col;
};

#endif
