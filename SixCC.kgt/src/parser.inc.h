#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdlib.h>
#include <stdarg.h>
#include <stdio.h>
#include <errno.h>
#include <ctype.h>

#include "parsing_error.h"
#include "txt.h"
#include "ast.h"
#include "xalloc.h"

#define PASTE(a, b) a ## b
#define CAT(a, b)   PASTE(a, b)

#define LX_PREFIX CAT(lx_, FORM)

#define LX_TOKEN  CAT(LX_PREFIX, _token)
#define LX_STATE  CAT(LX_PREFIX, _lx)
#define LX_NEXT   CAT(LX_PREFIX, _next)
#define LX_INIT   CAT(LX_PREFIX, _init)

#define FORM_INPUT CAT(FORM, _input)

/* XXX: get rid of this; use same %entry% for all grammars */
#define FORM_ENTRY CAT(prod_, FORM)

/* XXX: workarounds for SID's identifier escaping */
#define prod_iso_Hebnf FORM_ENTRY
#define TOK_CI__LITERAL TOK_CI_LITERAL
#define TOK_CS__LITERAL TOK_CS_LITERAL

#include "parser.h"
#include "lexer.h"
#include "io.h"

typedef char         map_char;
typedef const char* map_string;
typedef struct txt   map_txt;
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

    int (*f)(void* opaque);
    void* opaque;

    /* TODO: use lx's generated conveniences for the pattern buffer */
    char a[512];
    char* p;

    parsing_error_queue errors;
};

#define CURRENT_TERMINAL (act_state->lex_tok)
#define ERROR_TERMINAL   (TOK_ERROR)
#define ADVANCE_LEXER    do { act_state->lex_tok = LX_NEXT(&lex_state->lx); } while (0)
#define SAVE_LEXER(tok)  do { act_state->lex_tok_save = act_state->lex_tok; \
                                  act_state->lex_tok = tok;                     } while (0)
#define RESTORE_LEXER    do { act_state->lex_tok = act_state->lex_tok_save; } while (0)

extern int allow_undefined;

static const char*
prefix(int base)
{
    switch (base)
    {
        case 16: return "%x";
        case 10: return "%d";
        case  8: return "%o";
        case  2: return "%b";
        default: return "";
    }
}

static int
string(const char* p, struct txt* t, int base)
{
    char* q;

    assert(p != NULL);
    assert(t != NULL);
    assert(t->p != NULL);
    assert(base > 0);

    {
        const char* s;
        size_t z;

        s = prefix(base);
        z = strlen(s);

        assert(0 == strncmp(p, s, z));

        p += z;
    }

    q = (char*)t->p;

    for (;;)
    {
        unsigned long n;
        char* e;

        n = strtoul(p, &e, base);
        if (n == ULONG_MAX)
        {
            return -1;
        }

        if (n > UCHAR_MAX)
        {
            errno = ERANGE;
            return -1;
        }

        *q++ = (unsigned char)n;

        if (*e == '\0')
        {
            break;
        }

        assert(*e == '.');

        p = e + 1;
    }

    t->n = q - t->p;

    return 0;
}

static int
range(const char* p,
    unsigned char* a, unsigned char* b,
    int base)
{
    unsigned long m, n;
    char* e;

    assert(p != NULL);
    assert(a != NULL);
    assert(b != NULL);
    assert(base > 0);

    {
        const char* s;
        size_t z;

        s = prefix(base);
        z = strlen(s);

        assert(0 == strncmp(p, s, z));

        p += z;
    }

    m = strtoul(p, &e, base);
    if (m == ULONG_MAX)
    {
        return -1;
    }

    p = e;

    assert(*p == '-');
    p++;

    n = strtoul(p, &e, base);
    if (n == ULONG_MAX)
    {
        return -1;
    }

    assert(*e == '\0');

    if (m > UCHAR_MAX || n > UCHAR_MAX)
    {
        errno = ERANGE;
        return -1;
    }

    *a = m;
    *b = n;

    return 0;
}

static const char*
ltrim(const char* s)
{
    while (isspace((unsigned char)*s))
    {
        s++;
    }

    return s;
}

static void
rtrim(char* s)
{
    char* p = s + strlen(s) - 1;

    assert(strlen(s) > 0);

    while (p >= s && isspace((unsigned char)*p))
    {
        *p-- = '\0';
    }
}

static const char*
trim(char* s)
{
    rtrim(s);
    return ltrim(s);
}

static void
err(struct lex_state_s* lex_state, const char* fmt, ...)
{
    parsing_error error;
    va_list ap;

    assert(lex_state != NULL);

    error.line = lex_state->lx.start.line;
    error.col = lex_state->lx.start.col;

    va_start(ap, fmt);
    vsnprintf(error.description, PARSING_ERROR_DESCRIPTION_SIZE, fmt, ap);
    va_end(ap);

    parsing_error_queue_push(&(lex_state->errors), error);
}

static void
err_expected(struct lex_state_s* lex_state, const char* token)
{
    err(lex_state, "Syntax error: expected %s", token);
}

static void
err_unimplemented(struct lex_state_s* lex_state, const char* s)
{
    err(lex_state, "Unimplemented: %s", s);
}

static const char*
pattern_buffer(struct lex_state_s* lex_state)
{
    const char* s;

    assert(lex_state != NULL);

    /* TODO */
    *lex_state->p++ = '\0';

    s = xstrdup(lex_state->a);

    lex_state->p = lex_state->a;

    return s;
}
