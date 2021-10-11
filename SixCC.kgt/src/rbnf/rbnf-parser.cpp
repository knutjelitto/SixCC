/*
 * Automatically generated from the files:
 *	src/rbnf/parser.sid
 * and
 *	src/parser.act
 * by:
 *	sid
 */
#define _CRT_SECURE_NO_WARNINGS

#ifndef FORM
#define FORM rbnf
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
#include "rbnf-lexer.h"
#include "../parsing-support.h"
#include "rbnf-parser.h"
#include "io.h"

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


#ifndef ERROR_TERMINAL
#error "-s no-numeric-terminals given and ERROR_TERMINAL is not defined"
#endif

/* BEGINNING OF FUNCTION DECLARATIONS */

static void prod_factor(lex_state, act_state, map_term *);
static void prod_list_Hof_Hterms(lex_state, act_state, map_term *);
static void prod_list_Hof_Hrules(lex_state, act_state, ast_grammar&);
static void prod_list_Hof_Halts(lex_state, act_state, map_alt *);
static void prod_rbnf(lex_state, act_state, ast_grammar&);
static void prod_body(lex_state, act_state);
static void prod_term(lex_state, act_state, map_term *);
static void prod_rule(lex_state, act_state, ast_grammar&);
static void prod_91(lex_state, act_state, ast_grammar&);
static void prod_92(lex_state, act_state, map_term *, map_alt *);
static void prod_93(lex_state, act_state, map_term *);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void
prod_factor(lex_state lex_state, act_state act_state, map_term* ZOt)
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
            /* BEGINNING OF ACTION: make-group-term */
            {
                //#line 641 "src/parser.act"

                (ZIt) = ast_term::make_group(act_state->invisible, (ZIa));

                //#line 347 "src/rbnf/parser.c"
            }
            /* END OF ACTION: make-group-term */
        }
        break;
        case (TOK_STARTOPT):
        {
            map_alt ZIa;
            map_count ZImin;
            map_count ZImax;

            ADVANCE_LEXER;
            prod_list_Hof_Halts(lex_state, act_state, &ZIa);
            /* BEGINNING OF INLINE: 77 */
            {
                switch (CURRENT_TERMINAL)
                {
                    case (TOK_REP):
                    {
                        ADVANCE_LEXER;
                        /* BEGINNING OF ACTION: rep-zero-or-more */
                        {
                            //#line 535 "src/parser.act"

                            (ZImin) = 0;
                            (ZImax) = 0;

                            /* workaround for SID's ! = f(); */
                            (void)(ZImin);
                            (void)(ZImax);

                            //#line 377 "src/rbnf/parser.c"
                        }
                        /* END OF ACTION: rep-zero-or-more */
                    }
                    break;
                    default:
                    {
                        /* BEGINNING OF ACTION: rep-zero-or-one */
                        {
                            //#line 544 "src/parser.act"

                            (ZImin) = 0;
                            (ZImax) = 1;

                            /* workaround for SID's ! = f(); */
                            (void)(ZImin);
                            (void)(ZImax);

                            //#line 395 "src/rbnf/parser.c"
                        }
                        /* END OF ACTION: rep-zero-or-one */
                    }
                    break;
                    case (ERROR_TERMINAL):
                        RESTORE_LEXER;
                        goto ZL1;
                }
            }
            /* END OF INLINE: 77 */
            switch (CURRENT_TERMINAL)
            {
                case (TOK_ENDOPT):
                    break;
                default:
                    goto ZL1;
            }
            ADVANCE_LEXER;

            (ZIt) = ast_term::make_group(act_state->invisible, (ZIa));

            /* END OF ACTION: make-group-term */
            /* BEGINNING OF ACTION: set-repeat */
            {
                //#line 553 "src/parser.act"

                assert((ZImax) >= (ZImin) || !(ZImax));

                (ZIt)->min = (ZImin);
                (ZIt)->max = (ZImax);

                //#line 431 "src/rbnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
        }
        break;
        case (TOK_CHAR): case (TOK_NAME):
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

static void
prod_list_Hof_Hterms(lex_state lex_state, act_state act_state, map_term* ZOl)
{
    map_term ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        prod_factor(lex_state, act_state, &ZIl);
        prod_93(lex_state, act_state, &ZIl);
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

static void prod_list_Hof_Hrules(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
    prod_rule(lex_state, act_state, grammar);
    prod_91(lex_state, act_state, grammar);
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
        prod_92(lex_state, act_state, &ZIt, &ZIl);
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

static void prod_rbnf(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    prod_list_Hof_Hrules(lex_state, act_state, grammar);
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        RESTORE_LEXER;
        err(*lex_state, "Syntax error");
        throw std::logic_error("bail out");
    }
}

static void prod_body(lex_state lex_state, act_state act_state)
{
ZL2_body:
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CHAR):
        {
            map_char ZIc;

            /* BEGINNING OF INLINE: 70 */
            {
                {
                    switch (CURRENT_TERMINAL)
                    {
                        case (TOK_CHAR):
                            /* BEGINNING OF EXTRACT: CHAR */
                        {
                            //#line 340 "src/parser.act"

                            assert(strlen(lex_state->buf.a) == 1);

                            ZIc = lex_state->buf.a[0];

                            //#line 596 "src/rbnf/parser.c"
                        }
                        /* END OF EXTRACT: CHAR */
                        break;
                        default:
                            goto ZL1;
                    }
                    ADVANCE_LEXER;
                }
            }
            /* END OF INLINE: 70 */
            /* BEGINNING OF ACTION: pattern-char */
            {
                //#line 520 "src/parser.act"

                        /* TODO */
                *lex_state->p++ = (ZIc);

                //#line 614 "src/rbnf/parser.c"
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
    SAVE_LEXER((ERROR_TERMINAL));
    return;
}

static void
prod_term(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        map_string ZIs;

        prod_body(lex_state, act_state);
        switch (CURRENT_TERMINAL)
        {
            case (TOK_NAME):
                /* BEGINNING OF EXTRACT: NAME */
            {
                //#line 369 "src/parser.act"

                ZIs = pattern_buffer(lex_state);

                //#line 653 "src/rbnf/parser.c"
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

            (ZIt) = ast_term::make_rule(act_state->invisible, r);

            //#line 684 "src/rbnf/parser.c"
        }
        /* END OF ACTION: make-rule-term */
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
    map_rule ZIr = nullptr;

    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
    {
        map_string ZIs;
        map_alt ZIa;

        prod_body(lex_state, act_state);
        switch (CURRENT_TERMINAL)
        {
            case (TOK_NAME):
            {
                ZIs = pattern_buffer(lex_state);
                break;
            }
            case (ERROR_TERMINAL):
                RESTORE_LEXER;
                goto ZL1;
            default:
                goto ZL1;
        }
        ADVANCE_LEXER;
                switch (CURRENT_TERMINAL)
                {
                    case (TOK_EQUALS):
                        ADVANCE_LEXER;
                        break;
                    default:
                        err_expected(*lex_state, "production rule assignment");
                        break;
                }
        prod_list_Hof_Halts(lex_state, act_state, &ZIa);
        if (CURRENT_TERMINAL == ERROR_TERMINAL)
        {
            RESTORE_LEXER;
            goto ZL1;
        }
        ZIr = ast_make_rule((ZIs), (ZIa));
        {
            switch (CURRENT_TERMINAL)
            {
                case (TOK_EOF):
                {
                    ADVANCE_LEXER;
                    break;
                }
                case (TOK_SEP):
                {
                    ADVANCE_LEXER;
                    break;
                }
                default:
                    goto ZL5;
            }
            goto ZL4;
        ZL5:
            {
                    err_expected(*lex_state, "production rule separator");
            }
        ZL4:;
        }
        /* END OF INLINE: 85 */
    }
    goto ZL0;
ZL1:
    SAVE_LEXER((ERROR_TERMINAL));
    return;
ZL0:
    if (ZIr != nullptr)
    {
        grammar.rules.push_back(ZIr);
    }
}

static void prod_91(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CHAR):
        case (TOK_NAME):
        {
            map_rule ZIr;

            prod_list_Hof_Hrules(lex_state, act_state, grammar);
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER(ERROR_TERMINAL);
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

static void
prod_92(lex_state lex_state, act_state act_state, map_term* ZIt, map_alt* ZOl)
{
    map_alt ZIl;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_ALT):
        {
            map_alt ZIa;

            /* BEGINNING OF INLINE: 81 */
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

                        //#line 881 "src/rbnf/parser.c"
                    }
                    /* END OF ACTION: err-expected-alt */
                }
            ZL2:;
            }
            /* END OF INLINE: 81 */
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

                //#line 899 "src/rbnf/parser.c"
            }
            /* END OF ACTION: make-alt */
            /* BEGINNING OF ACTION: add-alt-to-list */
            {
                //#line 684 "src/parser.act"

                assert((ZIl)->next == NULL);
                (ZIl)->next = (ZIa);

                //#line 909 "src/rbnf/parser.c"
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

                //#line 922 "src/rbnf/parser.c"
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
prod_93(lex_state lex_state, act_state act_state, map_term* ZIl)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_STARTGROUP): case (TOK_STARTOPT): case (TOK_CHAR): case (TOK_NAME):
        {
            map_term ZIt;

            prod_list_Hof_Hterms(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: add-term-to-list */
            {
                //#line 679 "src/parser.act"

                assert((*ZIl)->next == NULL);
                (*ZIl)->next = (ZIt);

                //#line 958 "src/rbnf/parser.c"
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
    SAVE_LEXER((ERROR_TERMINAL));
    return;
}

/* BEGINNING OF TRAILER */

//#line 738 "src/parser.act"


static int lgetc(struct LX_STATE *lx)
{
    const struct lex_state_s *lex_state;

    assert(lx != NULL);
    assert(lx->getc_opaque != NULL);

    lex_state = (struct lex_state_s*)(lx->getc_opaque);

    assert(lex_state->f != NULL);

    return lex_state->f(lex_state->opaque);
}

bool rbnf_input(ast_grammar& grammar, int (*f)(void* opaque), void* opaque, parsing_errors* errors)
{
    struct act_state_s  act_state_s;
    struct act_state_s* act_state;
    struct lex_state_s  lex_state_s;
    struct lex_state_s* lex_state;

    struct LX_STATE* lx;

    assert(f != NULL);

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
    prod_rbnf(lex_state, act_state, grammar);

    /* TODO: handle error */

    replace_real(grammar, *lex_state);

    return true;
}
