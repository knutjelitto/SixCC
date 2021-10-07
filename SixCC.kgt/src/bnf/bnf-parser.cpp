/*
 * Automatically generated from the files:
 *	src/bnf/parser.sid
 * and
 *	src/parser.act
 * by:
 *	sid
 */
#define _CRT_SECURE_NO_WARNINGS

#ifndef FORM
#define FORM bnf
#endif

#if true

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
#include "lexer.h"
#include "../parsing-support.h"
#include "parser.h"
#include "io.h"

#if false
    static void err(struct lex_state_s *lex_state, const char *fmt, ...)
    {
        parsing_error error{};
        va_list ap{};

        assert(lex_state != NULL);

        error.line = lex_state->lx.start.line;
        error.col  = lex_state->lx.start.col;

        va_start(ap, fmt);
        vsnprintf(error.description, PARSING_ERROR_DESCRIPTION_SIZE, fmt, ap);
        va_end(ap);

        lex_state->errors->add(error);
    }

    static void
    err_expected(struct lex_state_s *lex_state, const char *token)
    {
        err(lex_state, "Syntax error: expected %s", token);
    }

    static void
    err_unimplemented(struct lex_state_s *lex_state, const char *s)
    {
        err(lex_state, "Unimplemented: %s", s);
    }
#endif

    static const char * pattern_buffer(struct lex_state_s *lex_state)
    {
        const char *s;

        assert(lex_state != NULL);

        /* TODO */
        *lex_state->p++ = '\0';

        s = xstrdup(lex_state->a);

        lex_state->p = lex_state->a;

        return s;
    }

//#line 293 "src/bnf/parser.c"
#endif


#ifndef ERROR_TERMINAL
#error "-s no-numeric-terminals given and ERROR_TERMINAL is not defined"
#endif

/* BEGINNING OF FUNCTION DECLARATIONS */

static void prod_factor(lex_state, act_state, map_term *);
static void prod_list_Hof_Hterms(lex_state, act_state, map_term *);
static void prod_list_Hof_Hrules(lex_state, act_state, map_rule *);
static void prod_list_Hof_Halts(lex_state, act_state, map_alt *);
static void prod_body(lex_state, act_state);
extern void prod_bnf(lex_state, act_state, map_rule *);
static void prod_term(lex_state, act_state, map_term *);
static void prod_rule(lex_state, act_state, map_rule *);
static void prod_90(lex_state, act_state, map_rule *);
static void prod_91(lex_state, act_state, map_term *, map_alt *);
static void prod_92(lex_state, act_state, map_term *);
static void prod_93(lex_state, act_state, map_term *);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void
prod_factor(lex_state lex_state, act_state act_state, map_term *ZOt)
{
    map_term ZIt;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        prod_term (lex_state, act_state, &ZIt);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOt = ZIt;
}

static void
prod_list_Hof_Hterms(lex_state lex_state, act_state act_state, map_term *ZOl)
{
    map_term ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        prod_factor (lex_state, act_state, &ZIl);
        prod_92 (lex_state, act_state, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOl = ZIl;
}

static void
prod_list_Hof_Hrules(lex_state lex_state, act_state act_state, map_rule *ZOl)
{
    map_rule ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        prod_rule (lex_state, act_state, &ZIl);
        prod_90 (lex_state, act_state, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOl = ZIl;
}

static void
prod_list_Hof_Halts(lex_state lex_state, act_state act_state, map_alt *ZOl)
{
    map_alt ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        map_term ZIt;

        prod_list_Hof_Hterms (lex_state, act_state, &ZIt);
        prod_91 (lex_state, act_state, &ZIt, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOl = ZIl;
}

static void
prod_body(lex_state lex_state, act_state act_state)
{
ZL2_body:
    switch (CURRENT_TERMINAL) {
    case (TOK_CHAR):
        {
            map_char ZIc;

            /* BEGINNING OF INLINE: 68 */
            {
                {
                    switch (CURRENT_TERMINAL) {
                    case (TOK_CHAR):
                        /* BEGINNING OF EXTRACT: CHAR */
                        {
//#line 340 "src/parser.act"

        assert(strlen(lex_state->buf.a) == 1);

        ZIc = lex_state->buf.a[0];
    
//#line 439 "src/bnf/parser.c"
                        }
                        /* END OF EXTRACT: CHAR */
                        break;
                    default:
                        goto ZL1;
                    }
                    ADVANCE_LEXER;
                }
            }
            /* END OF INLINE: 68 */
            /* BEGINNING OF ACTION: pattern-char */
            {
//#line 520 "src/parser.act"

        /* TODO */
        *lex_state->p++ = (ZIc);
    
//#line 457 "src/bnf/parser.c"
            }
            /* END OF ACTION: pattern-char */
            /* BEGINNING OF INLINE: body */
            goto ZL2_body;
            /* END OF INLINE: body */
        }
        /* UNREACHED */
    case (ERROR_TERMINAL):
        return;
    default:
        break;
    }
    return;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
}

void
prod_bnf(lex_state lex_state, act_state act_state, map_rule *ZOl)
{
    map_rule ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        prod_list_Hof_Hrules (lex_state, act_state, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:
    {
        /* BEGINNING OF ACTION: make-empty-rule */
        {
//#line 674 "src/parser.act"

        (ZIl) = NULL;
    
//#line 500 "src/bnf/parser.c"
        }
        /* END OF ACTION: make-empty-rule */
        /* BEGINNING OF ACTION: err-syntax */
        {
//#line 717 "src/parser.act"

        err(*lex_state, "Syntax error");
        throw std::logic_error("bail out");

//#line 510 "src/bnf/parser.c"
        }
        /* END OF ACTION: err-syntax */
    }
ZL0:
    *ZOl = ZIl;
}

static void
prod_term(lex_state lex_state, act_state act_state, map_term *ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL) {
    case (TOK_EMPTY):
        {
            ADVANCE_LEXER;
            /* BEGINNING OF ACTION: make-empty-term */
            {
//#line 580 "src/parser.act"

        (ZIt) = ast_make_empty_term(act_state->invisible);
    
//#line 533 "src/bnf/parser.c"
            }
            /* END OF ACTION: make-empty-term */
        }
        break;
    case (TOK_CHAR): case (TOK_NAME): case (TOK_CS__LITERAL):
        {
            prod_body (lex_state, act_state);
            prod_93 (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
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
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOt = ZIt;
}

static void prod_rule(lex_state lex_state, act_state act_state, map_rule *ZOr)
{
    map_rule ZIr;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        map_string ZIs;
        map_alt ZIa;

        prod_body (lex_state, act_state);
        switch (CURRENT_TERMINAL) {
        case (TOK_NAME):
            /* BEGINNING OF EXTRACT: NAME */
            {
//#line 369 "src/parser.act"

        ZIs = pattern_buffer(lex_state);
    
//#line 582 "src/bnf/parser.c"
            }
            /* END OF EXTRACT: NAME */
            break;
        case (ERROR_TERMINAL):
            RESTORE_LEXER;
            goto ZL1;
        default:
            goto ZL1;
        }
        ADVANCE_LEXER;
        /* BEGINNING OF INLINE: 82 */
        {
            {
                switch (CURRENT_TERMINAL) {
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
    
//#line 613 "src/bnf/parser.c"
                }
                /* END OF ACTION: err-expected-equals */
            }
        ZL2:;
        }
        /* END OF INLINE: 82 */
        prod_list_Hof_Halts (lex_state, act_state, &ZIa);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
        /* BEGINNING OF ACTION: make-rule */
        {
//#line 670 "src/parser.act"

        (ZIr) = ast_make_rule((ZIs), (ZIa));
    
//#line 631 "src/bnf/parser.c"
        }
        /* END OF ACTION: make-rule */
        /* BEGINNING OF INLINE: 83 */
        {
            switch (CURRENT_TERMINAL) {
            case (TOK_EOF):
                {
                    ADVANCE_LEXER;
                }
                break;
            case (TOK_SEP):
                {
                    ADVANCE_LEXER;
                }
                break;
            default:
                goto ZL5;
            }
            goto ZL4;
        ZL5:
            {
                /* BEGINNING OF ACTION: err-expected-sep */
                {
//#line 726 "src/parser.act"

        err_expected(*lex_state, "production rule separator");
    
//#line 659 "src/bnf/parser.c"
                }
                /* END OF ACTION: err-expected-sep */
            }
        ZL4:;
        }
        /* END OF INLINE: 83 */
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOr = ZIr;
}

static void
prod_90(lex_state lex_state, act_state act_state, map_rule* ZIl)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CHAR): case (TOK_NAME):
        {
            map_rule ZIr;

            prod_list_Hof_Hrules(lex_state, act_state, &ZIr);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: add-rule-to-list */
            {
                //#line 689 "src/parser.act"

                if (ast_find_rule((ZIr), (*ZIl)->name()))
                {
                    err_already(*lex_state, (*ZIl)->name());
                    return;
                }

                assert((*ZIl)->next == NULL);
                (*ZIl)->next = (ZIr);

                //#line 700 "src/bnf/parser.c"
            }
            /* END OF ACTION: add-rule-to-list */
        }
        break;
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
prod_91(lex_state lex_state, act_state act_state, map_term* ZIt, map_alt* ZOl)
{
    map_alt ZIl;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_ALT):
        {
            map_alt ZIa;

            /* BEGINNING OF INLINE: 78 */
            {
                {
                    switch (CURRENT_TERMINAL)
                    {
                        case (TOK_ALT):
                            break;
                        default:
                            goto ZL3;
                    }
                    ADVANCE_LEXER;
                }
                goto ZL2;
            ZL3:
            {
                /* BEGINNING OF ACTION: err-expected-alt */
                {
                    //#line 722 "src/parser.act"

                    err_expected(*lex_state, "alternative separator");

                    //#line 746 "src/bnf/parser.c"
                }
                /* END OF ACTION: err-expected-alt */
            }
        ZL2:;
            }
            /* END OF INLINE: 78 */
            prod_list_Hof_Halts(lex_state, act_state, &ZIa);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: make-alt */
            {
                //#line 666 "src/parser.act"

                (ZIl) = ast_make_alt(act_state->invisible, (*ZIt));

                //#line 764 "src/bnf/parser.c"
            }
            /* END OF ACTION: make-alt */
            /* BEGINNING OF ACTION: add-alt-to-list */
            {
                //#line 684 "src/parser.act"

                assert((ZIl)->next == NULL);
                (ZIl)->next = (ZIa);

                //#line 774 "src/bnf/parser.c"
            }
            /* END OF ACTION: add-alt-to-list */
        }
        break;
        default:
        {
            /* BEGINNING OF ACTION: make-alt */
            {
                //#line 666 "src/parser.act"

                (ZIl) = ast_make_alt(act_state->invisible, (*ZIt));

                //#line 787 "src/bnf/parser.c"
            }
            /* END OF ACTION: make-alt */
        }
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

static void
prod_92(lex_state lex_state, act_state act_state, map_term *ZIl)
{
    switch (CURRENT_TERMINAL) {
    case (TOK_CHAR): case (TOK_EMPTY): case (TOK_NAME): case (TOK_CS__LITERAL):
        {
            map_term ZIt;

            prod_list_Hof_Hterms (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: add-term-to-list */
            {
//#line 679 "src/parser.act"

        assert((*ZIl)->next == NULL);
        (*ZIl)->next = (ZIt);
    
//#line 823 "src/bnf/parser.c"
            }
            /* END OF ACTION: add-term-to-list */
        }
        break;
    case (ERROR_TERMINAL):
        return;
    default:
        break;
    }
    return;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
}

static void
prod_93(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_CS__LITERAL):
        {
            text ZIx(pattern_buffer(lex_state));

            ADVANCE_LEXER;
                
            ZIt = ast_make_literal_term(act_state->invisible, ZIx, false);
        }
        break;
        case (TOK_NAME):
        {
            map_string ZIs;

            /* BEGINNING OF EXTRACT: NAME */
            {
                //#line 369 "src/parser.act"

                ZIs = pattern_buffer(lex_state);

                //#line 881 "src/bnf/parser.c"
            }
            /* END OF EXTRACT: NAME */
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
                r = ast_make_rule((ZIs), NULL);
                if (r == NULL)
                {
                    perror("ast_make_rule");
                    goto ZL1;
                }

                (ZIt) = ast_make_rule_term(act_state->invisible, r);

                //#line 905 "src/bnf/parser.c"
            }
            /* END OF ACTION: make-rule-term */
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

/* BEGINNING OF TRAILER */

//#line 738 "src/parser.act"


    static int lgetc(struct LX_STATE *lx)
    {
        const struct lex_state_s *lex_state;

        assert(lx != NULL);
        assert(lx->getc_opaque != NULL);

        lex_state = (struct lex_state_s*)lx->getc_opaque;

        assert(lex_state->f != NULL);

        return lex_state->f(lex_state->opaque);
    }

    struct ast_rule* bnf_input(int (*f)(void* opaque), void* opaque, parsing_errors* errors)
    {

        struct act_state_s  act_state_s;
        struct act_state_s* act_state;
        struct lex_state_s  lex_state_s;
        struct lex_state_s* lex_state;

        struct LX_STATE* lx;
        struct ast_rule* g;

        /* for dialects which don't use these */
        (void)ltrim;
        (void)rtrim;
        (void)trim;

        assert(f != NULL);

        g = NULL;

        lex_state = &lex_state_s;
        lex_state->p = lex_state->a;
        lex_state->errors = errors;

        lx = &lex_state->lx;

        LX_INIT(lx);

        lx->lgetc = lgetc;
        lx->getc_opaque = lex_state;

        lex_state->f = f;
        lex_state->opaque = opaque;

        lex_state->buf.a = NULL;
        lex_state->buf.len = 0;

        /* XXX: unneccessary since we're lexing from a string */
        lx->buf_opaque = &lex_state->buf;
        lx->push = CAT(LX_PREFIX, _dynpush);
        lx->clear = CAT(LX_PREFIX, _dynclear);
        lx->free = CAT(LX_PREFIX, _dynfree);

        /* XXX */
        lx->free = NULL;

        /* This is a workaround for ADVANCE_LEXER assuming a pointer */
        act_state = &act_state_s;

        act_state->invisible = 0;

        ADVANCE_LEXER;

        prod_bnf(lex_state, act_state, &g);

        /* TODO: handle error */

        replace_real(g, *lex_state);

        return g;
    }

//#line 1049 "src/bnf/parser.c"

/* END OF FILE */
