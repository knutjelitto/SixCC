/*
 * Automatically generated from the files:
 *	src/iso-ebnf/parser.sid
 * and
 *	src/parser.act
 * by:
 *	sid
 */
#define _CRT_SECURE_NO_WARNINGS

#ifndef FORM
#define FORM iso_ebnf
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
        assert(lex_state != nullptr);

        parsing_error error{};
        va_list ap{};

        error.line = lex_state->lx.start.line;
        error.col  = lex_state->lx.start.col;

        va_start(ap, fmt);
        vsnprintf(error.description, PARSING_ERROR_DESCRIPTION_SIZE, fmt, ap);
        va_end(ap);

        lex_state->errors->add(error);
    }

    static void err_expected(struct lex_state_s *lex_state, const char *token)
    {
        err(lex_state, "Syntax error: expected %s", token);
    }

    static void err_unimplemented(struct lex_state_s *lex_state, const char *s)
    {
        err(lex_state, "Unimplemented: %s", s);
    }
#endif

    static const char *pattern_buffer(struct lex_state_s *lex_state)
    {
        const char *s;

        assert(lex_state != nullptr);

        /* TODO */
        *lex_state->p++ = '\0';

        s = xstrdup(lex_state->a);

        lex_state->p = lex_state->a;

        return s;
    }

//#line 293 "src/iso-ebnf/parser.c"
#endif


#ifndef ERROR_TERMINAL
#error "-s no-numeric-terminals given and ERROR_TERMINAL is not defined"
#endif

/* BEGINNING OF FUNCTION DECLARATIONS */

static void prod_factor(lex_state, act_state, map_term *);
extern void prod_iso_Hebnf(lex_state, act_state, map_rule *);
static void prod_list_Hof_Hterms(lex_state, act_state, map_term *);
static void prod_list_Hof_Hrules(lex_state, act_state, map_rule *);
static void prod_list_Hof_Halts(lex_state, act_state, map_alt *);
static void prod_body(lex_state, act_state);
static void prod_term(lex_state, act_state, map_term *);
static void prod_rule(lex_state, act_state, map_rule *);
static void prod_repeatable_Hfactor(lex_state, act_state, map_term *);
static void prod_95(lex_state, act_state, map_rule *);
static void prod_96(lex_state, act_state, map_term *, map_alt *);
static void prod_97(lex_state, act_state);
static void prod_98(lex_state, act_state, map_term *);
static void prod_99(lex_state, act_state, map_term *);
static void prod_list_Hof_Hexcepts(lex_state, act_state, map_term *);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void
prod_factor(lex_state lex_state, act_state act_state, map_term *ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL) {
    case (TOK_STARTGROUP):
        {
            map_alt ZIa;

            ADVANCE_LEXER;
            prod_list_Hof_Halts (lex_state, act_state, &ZIa);
            switch (CURRENT_TERMINAL) {
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

        (ZIt) = ast_make_group_term(act_state->invisible, (ZIa));
    
//#line 351 "src/iso-ebnf/parser.c"
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
            prod_list_Hof_Halts (lex_state, act_state, &ZIa);
            switch (CURRENT_TERMINAL) {
            case (TOK_ENDOPT):
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

        (ZIt) = ast_make_group_term(act_state->invisible, (ZIa));
    
//#line 380 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-group-term */
            /* BEGINNING OF ACTION: rep-zero-or-one */
            {
//#line 544 "src/parser.act"

        (ZImin) = 0;
        (ZImax) = 1;

        /* workaround for SID's ! = f(); */
        (void) (ZImin);
        (void) (ZImax);
    
//#line 394 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: rep-zero-or-one */
            /* BEGINNING OF ACTION: set-repeat */
            {
//#line 553 "src/parser.act"

        assert((ZImax) >= (ZImin) || !(ZImax));

        (ZIt)->min = (ZImin);
        (ZIt)->max = (ZImax);
    
//#line 406 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
        }
        break;
    case (TOK_STARTSTAR):
        {
            map_alt ZIa;
            map_count ZImin;
            map_count ZImax;

            ADVANCE_LEXER;
            prod_list_Hof_Halts (lex_state, act_state, &ZIa);
            switch (CURRENT_TERMINAL) {
            case (TOK_ENDSTAR):
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

        (ZIt) = ast_make_group_term(act_state->invisible, (ZIa));
    
//#line 435 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-group-term */
            /* BEGINNING OF ACTION: rep-zero-or-more */
            {
//#line 535 "src/parser.act"

        (ZImin) = 0;
        (ZImax) = 0;

        /* workaround for SID's ! = f(); */
        (void) (ZImin);
        (void) (ZImax);
    
//#line 449 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: rep-zero-or-more */
            /* BEGINNING OF ACTION: set-repeat */
            {
//#line 553 "src/parser.act"

        assert((ZImax) >= (ZImin) || !(ZImax));

        (ZIt)->min = (ZImin);
        (ZIt)->max = (ZImax);
    
//#line 461 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
        }
        break;
    default:
        {
            prod_term (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
        }
        break;
    case (ERROR_TERMINAL):
        return;
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOt = ZIt;
}

void prod_iso_Hebnf(lex_state lex_state, act_state act_state, map_rule* ZOl)
{
    map_rule ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        prod_list_Hof_Hrules(lex_state, act_state, &ZIl);
        switch (CURRENT_TERMINAL)
        {
            case (TOK_EOF):
                break;
            case (ERROR_TERMINAL):
                RESTORE_LEXER;
                goto ZL1;
            default:
                goto ZL1;
        }
        ADVANCE_LEXER;
    }
    goto ZL0;
ZL1:
    {
        /* BEGINNING OF ACTION: make-empty-rule */
        {
            //#line 674 "src/parser.act"

            (ZIl) = nullptr;

            //#line 516 "src/iso-ebnf/parser.c"
        }
        /* END OF ACTION: make-empty-rule */
        /* BEGINNING OF ACTION: err-syntax */
        {
            //#line 717 "src/parser.act"

            err(*lex_state, "Syntax error");
            throw std::logic_error("bail out");
            err_exit();

            //#line 526 "src/iso-ebnf/parser.c"
        }
        /* END OF ACTION: err-syntax */
    }
ZL0:
    *ZOl = ZIl;
}

static void
prod_list_Hof_Hterms(lex_state lex_state, act_state act_state, map_term *ZOl)
{
    map_term ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        prod_repeatable_Hfactor (lex_state, act_state, &ZIl);
        prod_98 (lex_state, act_state, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
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
        prod_95 (lex_state, act_state, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
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

        prod_list_Hof_Hexcepts (lex_state, act_state, &ZIt);
        prod_96 (lex_state, act_state, &ZIt, &ZIl);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOl = ZIl;
}

static void
prod_body(lex_state lex_state, act_state act_state)
{
ZL2_body:;
    switch (CURRENT_TERMINAL) {
    case (TOK_CHAR):
        {
            map_char ZIc;

            /* BEGINNING OF INLINE: 73 */
            {
                {
                    switch (CURRENT_TERMINAL) {
                    case (TOK_CHAR):
                        /* BEGINNING OF EXTRACT: CHAR */
                        {
//#line 340 "src/parser.act"

        assert(strlen(lex_state->buf.a) == 1);

        ZIc = lex_state->buf.a[0];
    
//#line 630 "src/iso-ebnf/parser.c"
                        }
                        /* END OF EXTRACT: CHAR */
                        break;
                    default:
                        goto ZL1;
                    }
                    ADVANCE_LEXER;
                }
            }
            /* END OF INLINE: 73 */
            /* BEGINNING OF ACTION: pattern-char */
            {
//#line 520 "src/parser.act"

        /* TODO */
        *lex_state->p++ = (ZIc);
    
//#line 648 "src/iso-ebnf/parser.c"
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
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
}

static void
prod_term(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_IDENT):
        {
            map_string ZIs;

            /* BEGINNING OF EXTRACT: IDENT */
            {
                //#line 346 "src/parser.act"

                /*
                * This rtrim() is for EBNF, which would require n-token lookahead
                * in order to lex just an ident (as ident may contain whitespace).
                *
                * I'm trimming here (for all grammars) because it's simpler than
                * doing this for just EBNF specifically, and harmless to others.
                */
                rtrim(lex_state->buf.a);

                ZIs = xstrdup(lex_state->buf.a);

                //#line 696 "src/iso-ebnf/parser.c"
            }
            /* END OF EXTRACT: IDENT */
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

                (ZIt) = ast_make_rule_term(act_state->invisible, r);

                //#line 720 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-rule-term */
        }
        break;
        case (TOK_CHAR): case (TOK_CS__LITERAL): case (TOK_PROSE):
        {
            prod_body(lex_state, act_state);
            prod_99(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
        }
        break;
        default:
        {
            /* BEGINNING OF ACTION: make-empty-term */
            {
                //#line 580 "src/parser.act"

                (ZIt) = ast_make_empty_term(act_state->invisible);

                //#line 743 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-empty-term */
        }
        break;
        case (ERROR_TERMINAL):
            return;
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOt = ZIt;
}

static void
prod_rule(lex_state lex_state, act_state act_state, map_rule *ZOr)
{
    map_rule ZIr;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        map_string ZIs;
        map_alt ZIa;

        switch (CURRENT_TERMINAL) {
        case (TOK_IDENT):
            /* BEGINNING OF EXTRACT: IDENT */
            {
//#line 346 "src/parser.act"

        /*
         * This rtrim() is for EBNF, which would require n-token lookahead
         * in order to lex just an ident (as ident may contain whitespace).
         *
         * I'm trimming here (for all grammars) because it's simpler than
         * doing this for just EBNF specifically, and harmless to others.
         */
        rtrim(lex_state->buf.a);

        ZIs = xstrdup(lex_state->buf.a);
    
//#line 792 "src/iso-ebnf/parser.c"
            }
            /* END OF EXTRACT: IDENT */
            break;
        default:
            goto ZL1;
        }
        ADVANCE_LEXER;
        /* BEGINNING OF INLINE: 90 */
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
        ZL3:;
            {
                /* BEGINNING OF ACTION: err-expected-equals */
                {
//#line 730 "src/parser.act"

        err_expected(*lex_state, "production rule assignment");
    
//#line 820 "src/iso-ebnf/parser.c"
                }
                /* END OF ACTION: err-expected-equals */
            }
        ZL2:;
        }
        /* END OF INLINE: 90 */
        prod_list_Hof_Halts (lex_state, act_state, &ZIa);
        if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
            RESTORE_LEXER;
            goto ZL1;
        }
        /* BEGINNING OF ACTION: make-rule */
        {
//#line 670 "src/parser.act"

        (ZIr) = ast_make_rule((ZIs), (ZIa));
    
//#line 838 "src/iso-ebnf/parser.c"
        }
        /* END OF ACTION: make-rule */
        /* BEGINNING OF INLINE: 91 */
        {
            {
                switch (CURRENT_TERMINAL) {
                case (TOK_SEP):
                    break;
                default:
                    goto ZL5;
                }
                ADVANCE_LEXER;
            }
            goto ZL4;
        ZL5:;
            {
                /* BEGINNING OF ACTION: err-expected-sep */
                {
//#line 726 "src/parser.act"

        err_expected(*lex_state, "production rule separator");
    
//#line 861 "src/iso-ebnf/parser.c"
                }
                /* END OF ACTION: err-expected-sep */
            }
        ZL4:;
        }
        /* END OF INLINE: 91 */
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOr = ZIr;
}

static void
prod_repeatable_Hfactor(lex_state lex_state, act_state act_state, map_term *ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL) {
    case (TOK_COUNT):
        {
            map_count ZIn;

            /* BEGINNING OF EXTRACT: COUNT */
            {
//#line 363 "src/parser.act"

        ZIn = strtoul(lex_state->buf.a, nullptr, 10);
        /* TODO: range check */
    
//#line 894 "src/iso-ebnf/parser.c"
            }
            /* END OF EXTRACT: COUNT */
            ADVANCE_LEXER;
            switch (CURRENT_TERMINAL) {
            case (TOK_STAR):
                break;
            default:
                goto ZL1;
            }
            ADVANCE_LEXER;
            prod_factor (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: mul-repeat */
            {
//#line 560 "src/parser.act"

        assert((ZIn) > 0);

        /*
         * This multiplies a term's {min,max} pair as if the term were
         * repeated multiple times inline. Possible situations here are:
         *
         *   {0,0} * n => {0,0}
         *   {0,1} * n => {0,n}
         *   {1,0} * n => {n,0}
         *   {i,j} * n => {in,jn} where j >= i
         *
         * Note a max of 0 indicates no limit on the number of repetitions.
         */

        (ZIt)->min *= (ZIn);
        (ZIt)->max *= (ZIn);
    
//#line 931 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: mul-repeat */
        }
        break;
    default:
        {
            prod_factor (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
        }
        break;
    case (ERROR_TERMINAL):
        return;
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOt = ZIt;
}

static void
prod_95(lex_state lex_state, act_state act_state, map_rule* ZIl)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_IDENT):
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

                if (ast_find_rule((ZIr), (*ZIl)->name))
                {
                    err(*lex_state, "production rule <%s> already exists", (*ZIl)->name);
                    return;
                }

                assert((*ZIl)->next == nullptr);
                (*ZIl)->next = (ZIr);

                //#line 981 "src/iso-ebnf/parser.c"
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
prod_96(lex_state lex_state, act_state act_state, map_term* ZIt, map_alt* ZOl)
{
    map_alt ZIl;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_ALT):
        {
            map_alt ZIa;

            /* BEGINNING OF INLINE: 87 */
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
            ZL3:;
            {
                /* BEGINNING OF ACTION: err-expected-alt */
                {
                    //#line 722 "src/parser.act"

                    err_expected(*lex_state, "alternative separator");

                    //#line 1027 "src/iso-ebnf/parser.c"
                }
                /* END OF ACTION: err-expected-alt */
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
            /* BEGINNING OF ACTION: make-alt */
            {
                //#line 666 "src/parser.act"

                (ZIl) = ast_make_alt(act_state->invisible, (*ZIt));

                //#line 1045 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-alt */
            /* BEGINNING OF ACTION: add-alt-to-list */
            {
                //#line 684 "src/parser.act"

                assert((ZIl)->next == nullptr);
                (ZIl)->next = (ZIa);

                //#line 1055 "src/iso-ebnf/parser.c"
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

                //#line 1068 "src/iso-ebnf/parser.c"
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
prod_97(lex_state lex_state, act_state act_state)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_EXCEPT):
        {
            map_term ZIt;

            ADVANCE_LEXER;
            prod_list_Hof_Hterms(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: err-unimplemented-except */
            {
                //#line 734 "src/parser.act"

                err_unimplemented(*lex_state, "\"except\" productions");

                //#line 1104 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: err-unimplemented-except */
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
prod_98(lex_state lex_state, act_state act_state, map_term *ZIl)
{
    switch (CURRENT_TERMINAL) {
    case (TOK_CAT):
        {
            map_term ZIt;

            ADVANCE_LEXER;
            prod_list_Hof_Hterms (lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: add-term-to-list */
            {
//#line 679 "src/parser.act"

        assert((*ZIl)->next == nullptr);
        (*ZIl)->next = (ZIt);
    
//#line 1141 "src/iso-ebnf/parser.c"
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
ZL1:;
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
}

static void
prod_99(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_CS__LITERAL):
        {
            map_txt ZIx;

            /* BEGINNING OF EXTRACT: CS_LITERAL */
            {
                //#line 378 "src/parser.act"

                ZIx.p = pattern_buffer(lex_state);
                ZIx.n = strlen(ZIx.p);

                //#line 1174 "src/iso-ebnf/parser.c"
            }
            /* END OF EXTRACT: CS_LITERAL */
            ADVANCE_LEXER;
            /* BEGINNING OF ACTION: make-cs-literal-term */
            {
                //#line 613 "src/parser.act"

                (ZIt) = ast_make_literal_term(act_state->invisible, &(ZIx), 0);

                //#line 1184 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-cs-literal-term */
        }
        break;
        case (TOK_PROSE):
        {
            map_string ZIs;

            /* BEGINNING OF EXTRACT: PROSE */
            {
                //#line 383 "src/parser.act"

                ZIs = pattern_buffer(lex_state);

                //#line 1199 "src/iso-ebnf/parser.c"
            }
            /* END OF EXTRACT: PROSE */
            ADVANCE_LEXER;
            /* BEGINNING OF ACTION: make-prose-term */
            {
                //#line 621 "src/parser.act"

                const char* s;

                s = xstrdup(trim((char*)(ZIs)));

                free((void*)(ZIs));

                if (!strcmp(s, "kgt:invisible"))
                {
                    act_state->invisible = 1;

                    (ZIt) = ast_make_empty_term(act_state->invisible);
                }
                else if (!strcmp(s, "kgt:visible"))
                {
                    act_state->invisible = 0;

                    (ZIt) = ast_make_empty_term(act_state->invisible);
                }
                else
                {
                    (ZIt) = ast_make_prose_term(act_state->invisible, s);
                }

                //#line 1225 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-prose-term */
        }
        break;
        case (ERROR_TERMINAL):
            return;
        default:
            goto ZL1;
    }
    goto ZL0;
ZL1:;
    SAVE_LEXER((ERROR_TERMINAL));
    return;
ZL0:;
    *ZOt = ZIt;
}

static void prod_list_Hof_Hexcepts(lex_state lex_state, act_state act_state, map_term* ZOl)
{
    map_term ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        prod_list_Hof_Hterms(lex_state, act_state, &ZIl);
        prod_97(lex_state, act_state);
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

/* BEGINNING OF TRAILER */

//#line 738 "src/parser.act"


    static int lgetc(struct LX_STATE *lx)
    {
        const struct lex_state_s *lex_state;

        assert(lx != nullptr);
        assert(lx->getc_opaque != nullptr);

        lex_state = (lex_state_s*)(lx->getc_opaque);

        assert(lex_state->f != nullptr);

        return lex_state->f(lex_state->opaque);
    }

    struct ast_rule* iso_ebnf_input(int (*f)(void* opaque), void* opaque, parsing_errors* errors)
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
        FORM_ENTRY(lex_state, act_state, &g);

        /* TODO: handle error */

        /* substitute placeholder rules for the real thing */
        {
            const struct ast_rule* p;
            const struct ast_alt* q;
            struct ast_term* t;
            struct ast_rule* r;

            for (p = g; p != nullptr; p = p->next)
            {
                for (q = p->alts; q != nullptr; q = q->next)
                {
                    for (t = q->terms; t != nullptr; t = t->next)
                    {
                        if (t->type != TYPE_RULE)
                        {
                            continue;
                        }

                        r = ast_find_rule(g, t->u.rule->name);
                        if (r != nullptr)
                        {
                            ast_free_rule((ast_rule*)t->u.rule);
                            t->u.rule = r;
                            continue;
                        }

                        if (!allow_undefined)
                        {
                            err(*lex_state, "production rule <%s> not defined", t->u.rule->name);
                            /* XXX: would leak the ast_rule here */
                            continue;
                        }

                        {
                            const char* token;

                            token = t->u.rule->name;

                            ast_free_rule((struct ast_rule*)t->u.rule);

                            t->type = TYPE_TOKEN;
                            t->u.token = token;
                        }
                    }
                }
            }
        }

        return g;
    }

//#line 1393 "src/iso-ebnf/parser.c"

/* END OF FILE */
