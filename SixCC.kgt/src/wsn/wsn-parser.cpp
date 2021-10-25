/*
 * Automatically generated from the files:
 *	src/wsn/parser.sid
 * and
 *	src/parser.act
 * by:
 *	sid
 */
#define _CRT_SECURE_NO_WARNINGS

#ifndef FORM
#define FORM wsn
#endif

#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdlib.h>
#include <stdarg.h>
#include <stdio.h>
#include <errno.h>
#include <ctype.h>

#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"
#include "../strings.h"
#include "wsn-lexer.h"
#include "../parsing-support.h"
#include "wsn-parser.h"
#include "io.h"

static const char* pattern_buffer(struct lex_state_s* lex_state)
{
	const char* s;

	assert(lex_state != nullptr);

	/* TODO */
	*lex_state->p++ = '\0';

	s = xstrdup(lex_state->a);

	lex_state->p = lex_state->a;

	return s;
}

#ifndef ERROR_TERMINAL
#error "-s no-numeric-terminals given and ERROR_TERMINAL is not defined"
#endif

/* BEGINNING OF FUNCTION DECLARATIONS */

static void prod_factor(lex_state, act_state, map_term *);
static void prod_list_Hof_Hterms(lex_state, act_state, map_term *);
static void prod_list_Hof_Hrules(lex_state, act_state, ast_grammar&);
static void prod_list_Hof_Halts(lex_state, act_state, map_alt *);
static void prod_body(lex_state, act_state);
static void prod_term(lex_state, act_state, map_term *);
static void prod_rule(lex_state, act_state, ast_grammar&);
static void prod_wsn(lex_state, act_state, ast_grammar&);
static void prod_93(lex_state, act_state, ast_grammar&);
static void prod_94(lex_state, act_state, map_term *, map_alt *);
static void prod_95(lex_state, act_state, map_term *);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void prod_factor(lex_state lex_state, act_state act_state, map_term* ZOt)
{
	map_term ZIt;

	switch (CURRENT_TERMINAL)
	{
		case (TOK_STARTGROUP):
		{
			map_alt ZIa;

			ADVANCE_LEXER;
			prod_list_Hof_Halts(lex_state, act_state, &ZIa);
			switch (CURRENT_TERMINAL)
			{
				case (TOK_ENDGROUP):
					break;
				case (ERROR_TERMINAL):
					RESTORE_LEXER;
					goto ZL1;
				default:
					goto ZL1;
			}
			ADVANCE_LEXER;

			ZIt = ast_term::make_group(ZIa);

			break;
		}
		case (TOK_STARTOPT):
		{
			map_alt ZIa;
			map_count ZImin;
			map_count ZImax;

			ADVANCE_LEXER;
			prod_list_Hof_Halts(lex_state, act_state, &ZIa);
			switch (CURRENT_TERMINAL)
			{
				case (TOK_ENDOPT):
					break;
				case (ERROR_TERMINAL):
					RESTORE_LEXER;
					goto ZL1;
				default:
					goto ZL1;
			}
			ADVANCE_LEXER;

			(ZIt) = ast_term::make_group(ZIa);

			/* BEGINNING OF ACTION: rep-zero-or-one */
			{
				(ZImin) = 0;
				(ZImax) = 1;

				/* workaround for SID's ! = f(); */
				(void)(ZImin);
				(void)(ZImax);
			}
			/* END OF ACTION: rep-zero-or-one */
			/* BEGINNING OF ACTION: set-repeat */
			{
				assert((ZImax) >= (ZImin) || !(ZImax));

				(ZIt)->min = (ZImin);
				(ZIt)->max = (ZImax);
			}
			/* END OF ACTION: set-repeat */
			break;
		}
		case (TOK_STARTSTAR):
		{
			map_alt ZIa;
			map_count ZImin;
			map_count ZImax;

			ADVANCE_LEXER;
			prod_list_Hof_Halts(lex_state, act_state, &ZIa);
			switch (CURRENT_TERMINAL)
			{
				case (TOK_ENDSTAR):
					break;
				case (ERROR_TERMINAL):
					RESTORE_LEXER;
					goto ZL1;
				default:
					goto ZL1;
			}
			ADVANCE_LEXER;

			(ZIt) = ast_term::make_group(ZIa);

			/* END OF ACTION: make-group-term */
			/* BEGINNING OF ACTION: rep-zero-or-more */
			{
				//#line 535 "src/parser.act"

				(ZImin) = 0;
				(ZImax) = 0;

				/* workaround for SID's ! = f(); */
				(void)(ZImin);
				(void)(ZImax);

				//#line 445 "src/wsn/parser.c"
			}
			/* END OF ACTION: rep-zero-or-more */
			/* BEGINNING OF ACTION: set-repeat */
			{
				//#line 553 "src/parser.act"

				assert((ZImax) >= (ZImin) || !(ZImax));

				(ZIt)->min = (ZImin);
				(ZIt)->max = (ZImax);

				//#line 457 "src/wsn/parser.c"
			}
			/* END OF ACTION: set-repeat */
			break;
		}
		case (TOK_ESC): case (TOK_CHAR): case (TOK_IDENT): case (TOK_EMPTY):
		case (TOK_CS__LITERAL):
		{
			prod_term(lex_state, act_state, &ZIt);
			if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
			{
				RESTORE_LEXER;
				goto ZL1;
			}
		}
		break;
		case (ERROR_TERMINAL):
			return;
		default:
			goto ZL1;
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:
	*ZOt = ZIt;
}

static void prod_list_Hof_Hterms(lex_state lex_state, act_state act_state, map_term* ZOl)
{
	map_term ZIl;

	if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
	{
		return;
	}
	prod_factor(lex_state, act_state, &ZIl);
	prod_95(lex_state, act_state, &ZIl);
	if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
	{
		RESTORE_LEXER;
		goto ZL1;
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:
	*ZOl = ZIl;
}

static void prod_list_Hof_Hrules(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
	if (CURRENT_TERMINAL == ERROR_TERMINAL)
	{
		return;
	}
	prod_rule(lex_state, act_state, grammar);
	prod_93(lex_state, act_state, grammar);
	if (CURRENT_TERMINAL == ERROR_TERMINAL)
	{
		RESTORE_LEXER;
		SAVE_LEXER(ERROR_TERMINAL);
		return;
	}
}

static void
prod_list_Hof_Halts(lex_state lex_state, act_state act_state, map_alt* ZOl)
{
	map_alt ZIl;

	if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
	{
		return;
	}
	{
		map_term ZIt;

		prod_list_Hof_Hterms(lex_state, act_state, &ZIt);
		prod_94(lex_state, act_state, &ZIt, &ZIl);
		if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
		{
			RESTORE_LEXER;
			goto ZL1;
		}
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:
	*ZOl = ZIl;
}

static void prod_body(lex_state lex_state, act_state act_state)
{
ZL2_body:
	switch (CURRENT_TERMINAL)
	{
		case (TOK_ESC):
		case (TOK_CHAR):
		{
			map_char ZIc;

			switch (CURRENT_TERMINAL)
			{
				case (TOK_CHAR):
				{
					{
						assert(strlen(lex_state->buf.a) == 1);

						ZIc = lex_state->buf.a[0];
					}

					ADVANCE_LEXER;
					break;
				}
				case (TOK_ESC):
				{
					{
						assert(strlen(lex_state->buf.a) == 2);

						ZIc = lex_state->buf.a[0];
					}
					ADVANCE_LEXER;
					break;
				}
				default:
					goto ZL1;
			}
			/* TODO */
			*lex_state->p++ = (ZIc);
			goto ZL2_body;
		}
		case (ERROR_TERMINAL):
			return;
		default:
			break;
	}
	return;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
}

static void
prod_term(lex_state lex_state, act_state act_state, map_term* ZOt)
{
	map_term ZIt;

	switch (CURRENT_TERMINAL)
	{
		case (TOK_EMPTY):
		{
			ADVANCE_LEXER;
			/* BEGINNING OF ACTION: make-empty-term */
			{
				//#line 580 "src/parser.act"

				(ZIt) = ast_term::make_empty();

				//#line 649 "src/wsn/parser.c"
			}
			/* END OF ACTION: make-empty-term */
		}
		break;
		case (TOK_IDENT):
		{
			/*
			 * This rtrim() is for EBNF, which would require n-token lookahead
			 * in order to lex just an ident (as ident may contain whitespace).
			 *
			 * I'm trimming here (for all grammars) because it's simpler than
			 * doing this for just EBNF specifically, and harmless to others.
			 */
			text ZIs(text(lex_state->buf.a).rtrim());

			ADVANCE_LEXER;
			/* BEGINNING OF ACTION: make-rule-term */
			{
				//#line 584 "src/parser.act"

				struct ast_rule* r;

				/*
				 * Regardless of whether a rule exists (yet) by this name, we make
				 * a placeholder rule just so that we have an ast_rule struct
				 * at which to point. This saves passing the grammar around, which
				 * keeps the rule-building productions simpler.
				 */
				r = ast_make_rule((ZIs), nullptr);
				if (r == nullptr)
				{
					perror("ast_make_rule");
					goto ZL1;
				}

				(ZIt) = ast_term::make_rule(r);

				//#line 701 "src/wsn/parser.c"
			}
			/* END OF ACTION: make-rule-term */
		}
		break;
		case (TOK_ESC): case (TOK_CHAR): case (TOK_CS__LITERAL):
		{
			text ZIx;

			prod_body(lex_state, act_state);

			switch (CURRENT_TERMINAL)
			{
				case (TOK_CS__LITERAL):
				{
					ZIx = text(pattern_buffer(lex_state));
					break;
				}
				case (ERROR_TERMINAL):
					RESTORE_LEXER;
					goto ZL1;
				default:
					goto ZL1;
			}
			ADVANCE_LEXER;
			{
				ZIt = ast_term::make_cs_literal(ZIx);
			}
		}
		break;
		case (ERROR_TERMINAL):
			return;
		default:
			goto ZL1;
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:
	*ZOt = ZIt;
}

static void prod_rule(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
	if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
	{
		return;
	}
	{
		text ZIs;
		map_alt ZIa;

		switch (CURRENT_TERMINAL)
		{
			case (TOK_IDENT):
			{
						/*
						 * This rtrim() is for EBNF, which would require n-token lookahead
						 * in order to lex just an ident (as ident may contain whitespace).
						 *
						 * I'm trimming here (for all grammars) because it's simpler than
						 * doing this for just EBNF specifically, and harmless to others.
						 */
				ZIs = text(lex_state->buf.a).rtrim();

				break;
			}
			default:
				goto ZL1;
		}
		ADVANCE_LEXER;
		/* BEGINNING OF INLINE: 87 */
		{
			{
				switch (CURRENT_TERMINAL)
				{
					case (TOK_EQUALS):
						break;
					default:
						goto ZL3;
				}
				ADVANCE_LEXER;
			}
			goto ZL2;
		ZL3:
		{
			/* BEGINNING OF ACTION: err-expected-equals */
			{
				//#line 730 "src/parser.act"

				err_expected(*lex_state, "production rule assignment");

				//#line 816 "src/wsn/parser.c"
			}
			/* END OF ACTION: err-expected-equals */
		}
	ZL2:;
		}
		/* END OF INLINE: 87 */
		prod_list_Hof_Halts(lex_state, act_state, &ZIa);
		if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
		{
			RESTORE_LEXER;
			goto ZL1;
		}
		/* BEGINNING OF ACTION: make-rule */
		{
			//#line 670 "src/parser.act"

			grammar.rules.push_back(ast_make_rule(ZIs, ZIa));

			//#line 834 "src/wsn/parser.c"
		}
		/* END OF ACTION: make-rule */
		/* BEGINNING OF INLINE: 88 */
		{
			{
				switch (CURRENT_TERMINAL)
				{
					case (TOK_SEP):
						break;
					default:
						goto ZL5;
				}
				ADVANCE_LEXER;
			}
			goto ZL4;
		ZL5:
		{
			/* BEGINNING OF ACTION: err-expected-sep */
			{
				//#line 726 "src/parser.act"

				err_expected(*lex_state, "production rule separator");

				//#line 857 "src/wsn/parser.c"
			}
			/* END OF ACTION: err-expected-sep */
		}
	ZL4:;
		}
		/* END OF INLINE: 88 */
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:;
}

void prod_wsn(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
	if (CURRENT_TERMINAL == ERROR_TERMINAL)
	{
		return;
	}
	prod_list_Hof_Hrules(lex_state, act_state, grammar);
	switch (CURRENT_TERMINAL)
	{
		case (TOK_EOF):
			ADVANCE_LEXER;
			return;
		case (ERROR_TERMINAL):
			RESTORE_LEXER;
			break;
		default:
			break;
	}
	err(*lex_state, "Syntax error");
	throw std::logic_error("bail out");
}

static void prod_93(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
	switch (CURRENT_TERMINAL)
	{
		case (TOK_IDENT):
		{
			prod_list_Hof_Hrules(lex_state, act_state, grammar);
			if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
			{
				RESTORE_LEXER;
				SAVE_LEXER((ERROR_TERMINAL));
				return;
			}
			break;
		}
		case (ERROR_TERMINAL):
			break;
		default:
			break;
	}
}

static void prod_94(lex_state lex_state, act_state act_state, map_term* ZIt, map_alt* ZOl)
{
	map_alt ZIl;

	switch (CURRENT_TERMINAL)
	{
		case (TOK_ALT):
		{
			map_alt ZIa;

			switch (CURRENT_TERMINAL)
			{
				case (TOK_ALT):
					ADVANCE_LEXER;
					break;
				default:
					err_expected(*lex_state, "alternative separator");
					break;
			}
			prod_list_Hof_Halts(lex_state, act_state, &ZIa);
			if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
			{
				RESTORE_LEXER;
				goto ZL1;
			}
			(ZIl) = ast_make_alt(*ZIt);
			assert((ZIl)->next == nullptr);
			(ZIl)->next = (ZIa);
			break;
		}
		default:
			(ZIl) = ast_make_alt(*ZIt);
			break;

		case (ERROR_TERMINAL):
			return;
	}
	goto ZL0;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
ZL0:
	*ZOl = ZIl;
}

static void prod_95(lex_state lex_state, act_state act_state, map_term* ZIl)
{
	switch (CURRENT_TERMINAL)
	{
		case TOK_STARTGROUP:
		case TOK_STARTOPT:
		case TOK_STARTSTAR:
		case TOK_ESC:
		case TOK_CHAR:
		case TOK_IDENT:
		case TOK_EMPTY:
		case TOK_CS__LITERAL:
		{
			map_term ZIt;

			prod_list_Hof_Hterms(lex_state, act_state, &ZIt);
			if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
			{
				RESTORE_LEXER;
				goto ZL1;
			}
			
			assert((*ZIl)->next == nullptr);
			(*ZIl)->next = (ZIt);
			break;
		}
		case (ERROR_TERMINAL):
			return;
		default:
			break;
	}
	return;
ZL1:
	SAVE_LEXER((ERROR_TERMINAL));
	return;
}

static int lgetc(struct LX_STATE *lx)
{
	const struct lex_state_s *lex_state;

	assert(lx != nullptr);
	assert(lx->getc_opaque != nullptr);

	lex_state = (struct lex_state_s*)(lx->getc_opaque);

	assert(lex_state->f != nullptr);

	return lex_state->f(lex_state->opaque);
}

bool wsn_input(ast_grammar& grammar, int (*f)(void* opaque), void* opaque, parsing_errors* errors)
{
	struct act_state_s  act_state_s;
	struct act_state_s* act_state;
	struct lex_state_s  lex_state_s;
	struct lex_state_s* lex_state;

	struct LX_STATE* lx;
	struct ast_rule* g;

	assert(f != nullptr);

	g = nullptr;

	lex_state = &lex_state_s;
	lex_state->p = lex_state->a;
	lex_state->errors = errors;

	lx = &lex_state->lx;

	LX_INIT(lx);

	lx->lgetc = lgetc;
	lx->getc_opaque = lex_state;

	lex_state->f = f;
	lex_state->opaque = opaque;

	lex_state->buf.a = nullptr;
	lex_state->buf.len = 0;

	/* XXX: unneccessary since we're lexing from a string */
	lx->buf_opaque = &lex_state->buf;
	lx->push = CAT(LX_PREFIX, _dynpush);
	lx->clear = CAT(LX_PREFIX, _dynclear);
	lx->free = CAT(LX_PREFIX, _dynfree);

	/* XXX */
	lx->free = nullptr;

	/* This is a workaround for ADVANCE_LEXER assuming a pointer */
	act_state = &act_state_s;

	act_state->invisible = 0;

	ADVANCE_LEXER;
	prod_wsn(lex_state, act_state, grammar);

	/* TODO: handle error */

	replace_real(grammar, *lex_state);

	return true;
}
