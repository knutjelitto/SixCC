/*
 * Copyright 2021 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

#ifndef KGT_PARSING_SUPPORT_H
#define KGT_PARSING_SUPPORT_H

#include <string>
#include <stdexcept>
#include "parsing-error.h"

#ifndef FORM
#error FORM must be defined
#endif

#define PASTE(a, b) a ## b
#define CAT(a, b)   PASTE(a, b)

#define LX_PREFIX CAT(lx_, FORM)

#define LX_TOKEN  CAT(LX_PREFIX, _token)
#define LX_STATE  CAT(LX_PREFIX, _lx)
#define LX_NEXT   CAT(LX_PREFIX, _next)
#define LX_INIT   CAT(LX_PREFIX, _init)

 /* XXX: get rid of this; use same %entry% for all grammars */
#define FORM_ENTRY CAT(prod_, FORM)

/* XXX: workarounds for SID's identifier escaping */
#define prod_iso_Hebnf FORM_ENTRY
#define TOK_CI__LITERAL TOK_CI_LITERAL
#define TOK_CS__LITERAL TOK_CS_LITERAL

typedef char map_char;
typedef const char* map_string;
typedef struct txt map_txt;
typedef unsigned int map_count;

typedef struct ast_term* map_term;
typedef struct ast_alt* map_alt;

struct act_state_s
{
	enum LX_TOKEN lex_tok;
	enum LX_TOKEN lex_tok_save;
	int invisible;
};

struct lex_state_s
{
    struct LX_STATE lx;
    struct lx_dynbuf buf;

    void* opaque;
    int (*f)(void* opaque);

    /* TODO: use lx's generated conveniences for the pattern buffer */
    char a[512];
    char* p;

    parsing_errors* errors;

    inline operator error_context() const
    {
        return error_context{ lx.start.line, lx.start.col, errors };
    }
};

#define CURRENT_TERMINAL (act_state->lex_tok)
#define ERROR_TERMINAL   (TOK_ERROR)
#define ADVANCE_LEXER    do { act_state->lex_tok = LX_NEXT(&lex_state->lx); } while (0)
#define SAVE_LEXER(tok)  do { act_state->lex_tok_save = act_state->lex_tok; \
                                  act_state->lex_tok = tok;                     } while (0)
#define RESTORE_LEXER    do { act_state->lex_tok = act_state->lex_tok_save; } while (0)

extern int allow_undefined;

#endif
