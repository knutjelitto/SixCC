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
#include "iso-ebnf-lexer.h"
#include "../parsing-support.h"
#include "iso-ebnf-parser.h"
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

static void prod_factor(lex_state, act_state, map_term*);
static void prod_iso_ebnf(lex_state, act_state, ast_grammar&);
static void prod_list_of_terms(lex_state, act_state, map_term*);
static void prod_list_of_rules(lex_state, act_state, ast_grammar&);
static void prod_list_of_alts(lex_state, act_state, map_alt*);
static void prod_body(lex_state, act_state);
static void prod_term(lex_state, act_state, map_term*);
static void prod_rule(lex_state, act_state, ast_grammar&);
static void prod_repeatable_factor(lex_state, act_state, map_term*);
static void prod_95(lex_state, act_state, ast_grammar&);
static void prod_96(lex_state, act_state, map_term*, map_alt*);
static void prod_97(lex_state, act_state);
static void prod_98(lex_state, act_state, map_term*);
static void prod_99(lex_state, act_state, map_term*);
static void prod_list_of_excepts(lex_state, act_state, map_term*);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void prod_factor(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_STARTGROUP):
        {
            ADVANCE_LEXER;

            map_alt ZIa;
            prod_list_of_alts(lex_state, act_state, &ZIa);

            switch (CURRENT_TERMINAL)
            {
                case (TOK_ENDGROUP):
                    break;
                case (ERROR_TERMINAL):
                    RESTORE_LEXER;
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
                default:
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
            }
            ADVANCE_LEXER;

            ZIt = ast_term::make_group(act_state->invisible, ZIa);
            break;
        }
        case (TOK_STARTOPT):
        {
            ADVANCE_LEXER;
            
            map_alt ZIa;
            prod_list_of_alts(lex_state, act_state, &ZIa);
            
            switch (CURRENT_TERMINAL)
            {
                case (TOK_ENDOPT):
                    break;
                case (ERROR_TERMINAL):
                    RESTORE_LEXER;
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
                default:
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
            }
            ADVANCE_LEXER;

            ZIt = ast_term::make_group(act_state->invisible, ZIa);
            ZIt->min = 0;
            ZIt->max = 1;
            break;
        }
        case (TOK_STARTSTAR):
        {
            ADVANCE_LEXER;

            map_alt ZIa;
            prod_list_of_alts(lex_state, act_state, &ZIa);
         
            switch (CURRENT_TERMINAL)
            {
                case (TOK_ENDSTAR):
                    break;
                case (ERROR_TERMINAL):
                    RESTORE_LEXER;
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
                default:
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
            }
            ADVANCE_LEXER;

            ZIt = ast_term::make_group(act_state->invisible, ZIa);
            ZIt->min = 0;
            ZIt->max = 0;
            break;
        }
        default:
        {
            prod_term(lex_state, act_state, &ZIt);
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER(ERROR_TERMINAL);
                return;
            }
            break;
        }
        case (ERROR_TERMINAL):
            return;
    }
    *ZOt = ZIt;
}

static void prod_iso_ebnf(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
    prod_list_of_rules(lex_state, act_state, grammar);
    switch (CURRENT_TERMINAL)
    {
        case TOK_EOF:
            ADVANCE_LEXER;
            break;
        case ERROR_TERMINAL:
            RESTORE_LEXER;
            /*fallthrough*/
        default:
            err(*lex_state, "Syntax error");
            throw std::logic_error("bail out");
    }
}

static void prod_list_of_terms(lex_state lex_state, act_state act_state, map_term* ZOl)
{
    map_term ZIl;

    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
    prod_repeatable_factor(lex_state, act_state, &ZIl);
    prod_98(lex_state, act_state, &ZIl);
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        RESTORE_LEXER;
        SAVE_LEXER(ERROR_TERMINAL);
        return;
    }

    *ZOl = ZIl;
}

static void prod_list_of_rules(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
    prod_rule(lex_state, act_state, grammar);
    prod_95(lex_state, act_state, grammar);
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        RESTORE_LEXER;
        SAVE_LEXER((ERROR_TERMINAL));
        return;
    }
}

static void prod_list_of_alts(lex_state lex_state, act_state act_state, map_alt* ZOl)
{
    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }
 
    map_alt ZIl;
    map_term ZIt;

    prod_list_of_excepts(lex_state, act_state, &ZIt);
    prod_96(lex_state, act_state, &ZIt, &ZIl);
    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        RESTORE_LEXER;
        SAVE_LEXER((ERROR_TERMINAL));
        return;
    }
    *ZOl = ZIl;
}

static void prod_body(lex_state lex_state, act_state act_state)
{
ZL2_body:
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CHAR):
        {
            map_char ZIc;

            switch (CURRENT_TERMINAL)
            {
                case (TOK_CHAR):
                {
                    assert(strlen(lex_state->buf.a) == 1);
                    ZIc = lex_state->buf.a[0];
                    break;
                }
                default:
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
            }
            ADVANCE_LEXER;
            *lex_state->p++ = ZIc;
            goto ZL2_body;
        }
        default:
            break;
    }
}

static void prod_term(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    ast_term* ZIt;

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

            text ZIs(text(lex_state->buf.a).rtrim());

            ADVANCE_LEXER;

            {
                struct ast_rule* r;

                /*
                 * Regardless of whether a rule exists (yet) by this name, we make
                 * a placeholder rule just so that we have an ast_rule struct
                 * at which to point. This saves passing the grammar around, which
                 * keeps the rule-building productions simpler.
                 */
                r = ast_make_rule(ZIs, nullptr);
                if (r == nullptr)
                {
                    perror("ast_make_rule");
                    goto ZL1;
                }

                ZIt = ast_term::make_rule(act_state->invisible, r);
            }
            break;
        }
        case (TOK_CHAR): case (TOK_CS__LITERAL): case (TOK_PROSE):
        {
            prod_body(lex_state, act_state);
            prod_99(lex_state, act_state, &ZIt);
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            break;
        }
        default:
        {
            /* BEGINNING OF ACTION: make-empty-term */
            {
                //#line 580 "src/parser.act"

                (ZIt) = ast_term::make_empty(act_state->invisible);

                //#line 743 "src/iso-ebnf/parser.c"
            }
            /* END OF ACTION: make-empty-term */
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
    *ZOt = ZIt;
}

static void prod_rule(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    ast_rule* rule = nullptr;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    text ZIs;

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
            SAVE_LEXER(ERROR_TERMINAL);
            return;
    }
    ADVANCE_LEXER;
    {
        switch (CURRENT_TERMINAL)
        {
            case (TOK_EQUALS):
                break;
            default:
                goto ZL3;
        }
        ADVANCE_LEXER;
        goto ZL2;
    ZL3:
        {
            err_expected(*lex_state, "production rule assignment");
        }
    ZL2:;
    }

    map_alt ZIa;
    prod_list_of_alts(lex_state, act_state, &ZIa);

    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        RESTORE_LEXER;
        SAVE_LEXER(ERROR_TERMINAL);
        return;
    }
    rule = ast_make_rule(ZIs, ZIa);
    grammar.rules.push_back(rule);

    switch (CURRENT_TERMINAL)
    {
        case (TOK_SEP):
            ADVANCE_LEXER;
            break;
        default:
            err_expected(*lex_state, "production rule separator");
            break;
    }
}

static void prod_repeatable_factor(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_COUNT):
        {
            map_count ZIn = strtoul(lex_state->buf.a, nullptr, 10);

            ADVANCE_LEXER;

            switch (CURRENT_TERMINAL)
            {
                case (TOK_STAR):
                    break;
                default:
                    SAVE_LEXER(ERROR_TERMINAL);
                    return;
            }

            ADVANCE_LEXER;

            prod_factor(lex_state, act_state, &ZIt);

            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER(ERROR_TERMINAL);
                return;
            }
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

            ZIt->min *= ZIn;
            ZIt->max *= ZIn;
            break;
        }
        default:
        {
            prod_factor(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                SAVE_LEXER((ERROR_TERMINAL));
                return;
            }
            break;
        }
        case (ERROR_TERMINAL):
            return;
    }
    *ZOt = ZIt;
}

static void prod_95(lex_state lex_state, act_state act_state, ast_grammar& grammar)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_IDENT):
        {
            prod_list_of_rules(lex_state, act_state, grammar);
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER(ERROR_TERMINAL);
                return;
            }
            break;
        }
        case (ERROR_TERMINAL):
            return;
        default:
            break;
    }
}

static void prod_96(lex_state lex_state, act_state act_state, map_term* ZIt, map_alt* ZOl)
{
    map_alt ZIl;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_ALT):
        {
            switch (CURRENT_TERMINAL)
            {
                case (TOK_ALT):
                    ADVANCE_LEXER;
                    break;
                default:
                    err_expected(*lex_state, "alternative separator");
                    break;
            }
            map_alt ZIa;
            prod_list_of_alts(lex_state, act_state, &ZIa);
            
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER(ERROR_TERMINAL);
                return;
            }
            
            ZIl = ast_make_alt(act_state->invisible, *ZIt);
            assert(ZIl->next == nullptr);
            ZIl->next = ZIa;
            break;
        }
        default:
            ZIl = ast_make_alt(act_state->invisible, *ZIt);
            break;
        case (ERROR_TERMINAL):
            return;
    }
    *ZOl = ZIl;
}

static void prod_97(lex_state lex_state, act_state act_state)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_EXCEPT):
        {
            map_term ZIt;

            ADVANCE_LEXER;
            prod_list_of_terms(lex_state, act_state, &ZIt);
            if (CURRENT_TERMINAL == ERROR_TERMINAL)
            {
                RESTORE_LEXER;
                SAVE_LEXER((ERROR_TERMINAL));
                return;
            }
            
            err_unimplemented(*lex_state, "\"except\" productions");
            break;
        }
        default:
            break;
    }
}

static void prod_98(lex_state lex_state, act_state act_state, map_term* ZIl)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CAT):
        {
            map_term ZIt;

            ADVANCE_LEXER;
            prod_list_of_terms(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
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
ZL1:
    SAVE_LEXER((ERROR_TERMINAL));
    return;
}

static void prod_99(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_CS__LITERAL):
        {
            text ZIx(pattern_buffer(lex_state));

            ADVANCE_LEXER;

            ZIt = ast_term::make_literal(act_state->invisible, ZIx, false);
        }
        break;
        case (TOK_PROSE):
        {
            text s = text(pattern_buffer(lex_state)).trim();

            ADVANCE_LEXER;

            if (s.eq("kgt:invisible"))
            {
                act_state->invisible = 1;

                (ZIt) = ast_term::make_empty(act_state->invisible);
            }
            else if (s.eq("kgt:visible"))
            {
                act_state->invisible = 0;

                (ZIt) = ast_term::make_empty(act_state->invisible);
            }
            else
            {
                (ZIt) = ast_term::make_prose(act_state->invisible, s);
            }
            break;
        }
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

static void prod_list_of_excepts(lex_state lex_state, act_state act_state, map_term* ZOl)
{
    map_term ZIl;

    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        return;
    }

    prod_list_of_terms(lex_state, act_state, &ZIl);
    prod_97(lex_state, act_state);

    if (CURRENT_TERMINAL == ERROR_TERMINAL)
    {
        RESTORE_LEXER;
        SAVE_LEXER(ERROR_TERMINAL);
        return;
    }
    *ZOl = ZIl;
}

static int lgetc(struct LX_STATE* lx)
{
    assert(lx != nullptr);
    assert(lx->getc_opaque != nullptr);

    const struct lex_state_s* lex_state;

    lex_state = (lex_state_s*)(lx->getc_opaque);

    assert(lex_state->f != nullptr);

    return lex_state->f(lex_state->opaque);
}

bool iso_ebnf_input(ast_grammar& grammar, int (*f)(void* opaque), void* opaque, parsing_errors* errors)
{
    struct act_state_s  act_state_s;
    struct act_state_s* act_state;
    struct lex_state_s  lex_state_s;
    struct lex_state_s* lex_state;

    struct LX_STATE* lx;

    assert(f != nullptr);

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
    lx->push = lx_iso_ebnf_dynpush;
    lx->clear = lx_iso_ebnf_dynclear;
    lx->free = lx_iso_ebnf_dynfree;

    /* XXX */
    lx->free = nullptr;

    /* This is a workaround for ADVANCE_LEXER assuming a pointer */
    act_state = &act_state_s;

    act_state->invisible = 0;

    ADVANCE_LEXER;

    prod_iso_ebnf(lex_state, act_state, grammar);

    /* TODO: handle error */

    replace_real(grammar, *lex_state);

    return true;
}
