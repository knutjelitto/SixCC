/*
 * Automatically generated from the files:
 *	src/abnf/parser.sid
 * and
 *	src/parser.act
 * by:
 *	sid
 */
#define _CRT_SECURE_NO_WARNINGS

#ifndef FORM
#define FORM abnf
#endif

#include <string>

#include <assert.h>
#include <limits.h>
#include <string.h>
#include <stdlib.h>
#include <stdarg.h>
#include <stdio.h>
#include <errno.h>
#include <ctype.h>

#include "../errors.h"
#include "../txt.h"
#include "../ast.h"
#include "../xalloc.h"
#include "../strings.h"
#include "lexer.h"
#include "../parsing-support.h"
#include "parser.h"
#include "io.h"

static text pattern_buffer(struct lex_state_s* lex_state)
{
    assert(lex_state != nullptr);

    return text(lex_state->a, lex_state->p - lex_state->a);
}

struct base_info
{
    int base;
    const char* prefix;
    const char* max;
    const char* name;
};

struct base_info bases[] =
{
    { 2, "%b", "11111111", "binary"},
    { 10, "%d", "255", "decimal"},
    { 16, "%h", "FF", "hex"},
};


static const base_info& prefix(int base)
{
    switch (base)
    {
        case  2: return bases[0];
        case 10: return bases[1];
        case 16: return bases[2];
    }

    Error::notreached();
}

static const base_info& prefix(LX_TOKEN tok)
{
    switch (tok)
    {
        case TOK_BINSTR:
        case TOK_BINRANGE:
            return bases[0];
        case TOK_DECSTR:
        case TOK_DECRANGE:
            return bases[1];
        case TOK_HEXSTR:
        case TOK_HEXRANGE:
            return bases[2];
    }

    Error::notreached();
}

static bool conversion_error(lex_state lex_state, const base_info& info)
{
    err(*lex_state, "%s sequence <%s> out of range: expected %s0..%s%s inclusive",
        info.name, lex_state->buf.a, info.prefix, info.prefix, info.max);

    return false;
}

static bool string(lex_state lex_state, text& result, const base_info& info)
{
    auto p = lex_state->buf.a;

    {
        const char* s;
        size_t z;

        s = info.prefix;
        z = strlen(s);

        assert(0 == strncmp(p, s, z));

        p += z;
    }

    std::string accu;

    for (;;)
    {
        unsigned long n;
        char* e;

        n = strtoul(p, &e, info.base);
        if (n == ULONG_MAX || n > UCHAR_MAX)
        {
            return conversion_error(lex_state, info);
        }

        accu.push_back((char)n);

        if (*e == '\0')
        {
            break;
        }

        assert(*e == '.');

        p = e + 1;
    }

    result = text(accu);
    return true;
}

static bool range(lex_state lex_state, unsigned char* a, unsigned char* b, base_info& info)
{
    unsigned long m, n;
    char* e;

    assert(a != nullptr);
    assert(b != nullptr);

    auto p = lex_state->buf.a;

    {
        const char* s;
        size_t z;

        s = info.prefix;
        z = strlen(s);

        assert(0 == strncmp(p, s, z));

        p += z;
    }

    m = strtoul(p, &e, info.base);
    if (m == ULONG_MAX || m > UCHAR_MAX)
    {
        return conversion_error(lex_state, info);
    }

    p = e;

    assert(*p == '-');
    p++;

    n = strtoul(p, &e, info.base);
    if (n == ULONG_MAX || n > UCHAR_MAX)
    {
        return conversion_error(lex_state, info);
    }

    assert(*e == '\0');

    *a = m;
    *b = n;

    return true;
}

#ifndef ERROR_TERMINAL
#error "-s no-numeric-terminals given and ERROR_TERMINAL is not defined"
#endif

/* BEGINNING OF FUNCTION DECLARATIONS */

static void prod_factor(lex_state, act_state, map_term *);
extern void prod_abnf(lex_state, act_state, map_rule *);
static void prod_list_Hof_Hterms(lex_state, act_state, map_term *);
static void prod_list_Hof_Hrules(lex_state, act_state, map_rule *);
static void prod_list_Hof_Halts(lex_state, act_state, map_alt *);
static void prod_body(lex_state, act_state);
static void prod_term(lex_state, act_state, map_term *);
static void prod_rule(lex_state, act_state, map_rule *);
static void prod_87(lex_state, act_state, map_count *);
static void prod_101(lex_state, act_state, map_rule *);
static void prod_102(lex_state, act_state, map_term *, map_alt *);
static void prod_103(lex_state, act_state, map_term *);
static void prod_factor_C_Celement(lex_state, act_state, map_term *);
static void prod_105(lex_state, act_state, map_count *, map_term *);
static void prod_106(lex_state, act_state, map_term *);

/* BEGINNING OF STATIC VARIABLES */


/* BEGINNING OF FUNCTION DEFINITIONS */

static void prod_factor(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_COUNT):
        {
            map_count ZI104;

            /* BEGINNING OF EXTRACT: COUNT */
            {
                //#line 363 "src/parser.act"

                ZI104 = strtoul(lex_state->buf.a, nullptr, 10);
                /* TODO: range check */

        //#line 340 "src/abnf/parser.c"
            }
            /* END OF EXTRACT: COUNT */
            ADVANCE_LEXER;
            prod_105(lex_state, act_state, &ZI104, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
        }
        break;
        case (TOK_STARTOPT):
        {
            map_alt ZIa;
            map_count ZImin;
            map_count ZImax;

            ADVANCE_LEXER;
            prod_list_Hof_Halts(lex_state, act_state, &ZIa);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: rep-zero-or-one */
            {
                //#line 544 "src/parser.act"

                (ZImin) = 0;
                (ZImax) = 1;

                /* workaround for SID's ! = f(); */
                (void)(ZImin);
                (void)(ZImax);

                //#line 374 "src/abnf/parser.c"
            }
            /* END OF ACTION: rep-zero-or-one */
            switch (CURRENT_TERMINAL)
            {
                case (TOK_ENDOPT):
                    break;
                default:
                    goto ZL1;
            }
            ADVANCE_LEXER;
            /* BEGINNING OF ACTION: make-group-term */
            {
                //#line 641 "src/parser.act"

                (ZIt) = new ast_term_group(act_state->invisible, (ZIa));

                //#line 390 "src/abnf/parser.c"
            }
            /* END OF ACTION: make-group-term */
            /* BEGINNING OF ACTION: set-repeat */
            {
                //#line 553 "src/parser.act"

                assert((ZImax) >= (ZImin) || !(ZImax));

                (ZIt)->min = (ZImin);
                (ZIt)->max = (ZImax);

                //#line 402 "src/abnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
        }
        break;
        case (TOK_STARTGROUP): case (TOK_CHAR): case (TOK_IDENT): case (TOK_CI__LITERAL):
        case (TOK_CS__LITERAL): case (TOK_PROSE): case (TOK_BINSTR): case (TOK_DECSTR):
        case (TOK_HEXSTR): case (TOK_BINRANGE): case (TOK_DECRANGE): case (TOK_HEXRANGE):
        {
            prod_factor_C_Celement(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
        }
        break;
        case (TOK_REP):
        {
            map_count ZImin;
            map_count ZI86;
            map_count ZImax;

            /* BEGINNING OF ACTION: rep-zero-or-more */
            {
                //#line 535 "src/parser.act"

                (ZImin) = 0;
                (ZI86) = 0;

                /* workaround for SID's ! = f(); */
                (void)(ZImin);
                (void)(ZI86);

                //#line 435 "src/abnf/parser.c"
            }
            /* END OF ACTION: rep-zero-or-more */
            ADVANCE_LEXER;
            prod_87(lex_state, act_state, &ZImax);
            prod_factor_C_Celement(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: set-repeat */
            {
                //#line 553 "src/parser.act"

                assert((ZImax) >= (ZImin) || !(ZImax));

                (ZIt)->min = (ZImin);
                (ZIt)->max = (ZImax);

                //#line 454 "src/abnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
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

void prod_abnf(lex_state lex_state, act_state act_state, map_rule* ZOl)
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

            //#line 502 "src/abnf/parser.c"
        }
        /* END OF ACTION: make-empty-rule */
        /* BEGINNING OF ACTION: err-syntax */
        {
            //#line 717 "src/parser.act"

            err(*lex_state, "Syntax error");
            throw std::logic_error("bail out");

            //#line 512 "src/abnf/parser.c"
        }
        /* END OF ACTION: err-syntax */
    }
ZL0:
    *ZOl = ZIl;
}

static void prod_list_Hof_Hterms(lex_state lex_state, act_state act_state, map_term* ZOl)
{
    map_term ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        prod_factor(lex_state, act_state, &ZIl);
        prod_103(lex_state, act_state, &ZIl);
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

static void prod_list_Hof_Hrules(lex_state lex_state, act_state act_state, map_rule* ZOl)
{
    map_rule ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        prod_rule(lex_state, act_state, &ZIl);
        prod_101(lex_state, act_state, &ZIl);
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

static void prod_list_Hof_Halts(lex_state lex_state, act_state act_state, map_alt *ZOl)
{
    map_alt ZIl;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
        return;
    }
    {
        map_term ZIt;

        prod_list_Hof_Hterms (lex_state, act_state, &ZIt);
        prod_102 (lex_state, act_state, &ZIt, &ZIl);
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
    switch (CURRENT_TERMINAL)
    {
        case (TOK_CHAR):
        {
            map_char ZIc;

            /* BEGINNING OF INLINE: 75 */
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

                            //#line 616 "src/abnf/parser.c"
                        }
                        /* END OF EXTRACT: CHAR */
                        break;
                        default:
                            goto ZL1;
                    }
                    ADVANCE_LEXER;
                }
            }
            /* END OF INLINE: 75 */
            /* BEGINNING OF ACTION: pattern-char */
            {
                //#line 520 "src/parser.act"

                        /* TODO */
                *lex_state->p++ = (ZIc);

                //#line 634 "src/abnf/parser.c"
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

static void prod_term(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_IDENT):
        {
            map_string ZIx;

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

                ZIx = xstrdup(lex_state->buf.a);

                //#line 682 "src/abnf/parser.c"
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
                r = ast_make_rule((ZIx), nullptr);
                if (r == nullptr)
                {
                    perror("ast_make_rule");
                    goto ZL1;
                }

                (ZIt) = ast_make_rule_term(act_state->invisible, r);

                //#line 706 "src/abnf/parser.c"
            }
            /* END OF ACTION: make-rule-term */
        }
        break;
        case (TOK_CHAR): case (TOK_CI__LITERAL): case (TOK_CS__LITERAL): case (TOK_PROSE):
        {
            prod_body(lex_state, act_state);
            prod_106(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            break;
        }
        case (TOK_BINRANGE):
        case (TOK_DECRANGE):
        case (TOK_HEXRANGE):
        {
            map_char ZIm = 0;
            map_char ZIn = 0;

            auto info = prefix(CURRENT_TERMINAL);
            if (!range(lex_state, (unsigned char*)&ZIm, (unsigned char*)&ZIn, info))
            {
                goto ZL1;
            }
            ADVANCE_LEXER;

            /* BEGINNING OF ACTION: make-range-term */
            {
                struct ast_alt* a;
                int i;

                a = nullptr;

                for (i = (unsigned char)(ZIm); i <= (unsigned char)(ZIn); i++)
                {
                    struct ast_alt* nuw;
                    struct ast_term* t;

                    t = ast_make_char_term(act_state->invisible, i);
                    nuw = ast_make_alt(act_state->invisible, t);

                    nuw->next = a;
                    a = nuw;
                }

                (ZIt) = ast_make_group_term(act_state->invisible, a);
            }
            /* END OF ACTION: make-range-term */
        }
        break;
        case (TOK_BINSTR):
        case (TOK_DECSTR):
        case (TOK_HEXSTR):
        {
            text ZIx;

            if (!string(lex_state, ZIx, prefix(CURRENT_TERMINAL)))
            {
                goto ZL1;
            }

            ADVANCE_LEXER;

            (ZIt) = ast_make_literal_term(act_state->invisible, ZIx, false);
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
prod_rule(lex_state lex_state, act_state act_state, map_rule* ZOr)
{
    map_rule ZIr;

    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
    {
        return;
    }
    {
        map_string ZIs;

        switch (CURRENT_TERMINAL)
        {
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

                //#line 985 "src/abnf/parser.c"
            }
            /* END OF EXTRACT: IDENT */
            break;
            default:
                goto ZL1;
        }
        ADVANCE_LEXER;
        /* BEGINNING OF INLINE: 95 */
        {
            switch (CURRENT_TERMINAL)
            {
                case (TOK_EQUALS):
                {
                    map_alt ZIa;

                    /* BEGINNING OF INLINE: 96 */
                    {
                        {
                            switch (CURRENT_TERMINAL)
                            {
                                case (TOK_EQUALS):
                                    break;
                                default:
                                    goto ZL4;
                            }
                            ADVANCE_LEXER;
                        }
                        goto ZL3;
                    ZL4:
                        {
                            /* BEGINNING OF ACTION: err-expected-equals */
                            {
                                //#line 730 "src/parser.act"

                                err_expected(*lex_state, "production rule assignment");

                                //#line 1020 "src/abnf/parser.c"
                            }
                            /* END OF ACTION: err-expected-equals */
                        }
                    ZL3:;
                    }
                    /* END OF INLINE: 96 */
                    prod_list_Hof_Halts(lex_state, act_state, &ZIa);
                    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
                    {
                        RESTORE_LEXER;
                        goto ZL1;
                    }
                    /* BEGINNING OF ACTION: make-rule */
                    {
                        //#line 670 "src/parser.act"

                        (ZIr) = ast_make_rule((ZIs), (ZIa));

                        //#line 1038 "src/abnf/parser.c"
                    }
                    /* END OF ACTION: make-rule */
                }
                break;
                case (TOK_ALTINC):
                {
                    map_rule ZIl;
                    map_alt ZIa;

                    /* BEGINNING OF INLINE: 97 */
                    {
                        {
                            switch (CURRENT_TERMINAL)
                            {
                                case (TOK_ALTINC):
                                    break;
                                default:
                                    goto ZL6;
                            }
                            ADVANCE_LEXER;
                        }
                        goto ZL5;
                    ZL6:
                        {
                            /* BEGINNING OF ACTION: err-expected-equals */
                            {
                                //#line 730 "src/parser.act"

                                err_expected(*lex_state, "production rule assignment");

                                //#line 1068 "src/abnf/parser.c"
                            }
                            /* END OF ACTION: err-expected-equals */
                        }
                    ZL5:;
                    }
                    /* END OF INLINE: 97 */
                    /* BEGINNING OF ACTION: current-rules */
                    {
                        //#line 699 "src/parser.act"

                        err(*lex_state, "unimplemented");
                        (ZIl) = nullptr;
                        goto ZL1;

                        //#line 1083 "src/abnf/parser.c"
                    }
                    /* END OF ACTION: current-rules */
                    prod_list_Hof_Halts(lex_state, act_state, &ZIa);
                    if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
                    {
                        RESTORE_LEXER;
                        goto ZL1;
                    }
                    /* BEGINNING OF ACTION: find-rule */
                    {
                        //#line 705 "src/parser.act"

                        assert((ZIs) != nullptr);

                        (ZIr) = ast_find_rule((ZIl), (ZIs));

                        //#line 1099 "src/abnf/parser.c"
                    }
                    /* END OF ACTION: find-rule */
                    /* BEGINNING OF ACTION: add-alts */
                    {
                        //#line 711 "src/parser.act"

                        err(*lex_state, "Unimplemented");
                        goto ZL1;

                        //#line 1109 "src/abnf/parser.c"
                    }
                    /* END OF ACTION: add-alts */
                }
                break;
                default:
                    goto ZL1;
            }
        }
        /* END OF INLINE: 95 */
        /* BEGINNING OF INLINE: 98 */
        {
            switch (CURRENT_TERMINAL)
            {
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
                    goto ZL8;
            }
            goto ZL7;
        ZL8:
            {
                /* BEGINNING OF ACTION: err-expected-sep */
                {
                    //#line 726 "src/parser.act"

                    err_expected(*lex_state, "production rule separator");

                    //#line 1144 "src/abnf/parser.c"
                }
                /* END OF ACTION: err-expected-sep */
            }
        ZL7:;
        }
        /* END OF INLINE: 98 */
    }
    goto ZL0;
ZL1:
    SAVE_LEXER((ERROR_TERMINAL));
    return;
ZL0:
    *ZOr = ZIr;
}

static void prod_87(lex_state lex_state, act_state act_state, map_count* ZOmax)
{
    map_count ZImax;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_COUNT):
        {
            /* BEGINNING OF EXTRACT: COUNT */
            {
                //#line 363 "src/parser.act"

                ZImax = strtoul(lex_state->buf.a, nullptr, 10);
                /* TODO: range check */

        //#line 1175 "src/abnf/parser.c"
            }
            /* END OF EXTRACT: COUNT */
            ADVANCE_LEXER;
        }
        break;
        default:
        {
            map_count ZI89;

            /* BEGINNING OF ACTION: rep-zero-or-more */
            {
                //#line 535 "src/parser.act"

                (ZI89) = 0;
                (ZImax) = 0;

                /* workaround for SID's ! = f(); */
                (void)(ZI89);
                (void)(ZImax);

                //#line 1196 "src/abnf/parser.c"
            }
            /* END OF ACTION: rep-zero-or-more */
        }
        break;
        case (ERROR_TERMINAL):
            return;
    }
    *ZOmax = ZImax;
}

static void prod_101(lex_state lex_state, act_state act_state, map_rule* ZIl)
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
                    err_already(*lex_state, (*ZIl)->name);
                    return;
                }

                assert((*ZIl)->next == nullptr);
                (*ZIl)->next = (ZIr);

                //#line 1232 "src/abnf/parser.c"
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

static void prod_102(lex_state lex_state, act_state act_state, map_term *ZIt, map_alt *ZOl)
{
    map_alt ZIl;

    switch (CURRENT_TERMINAL) {
    case (TOK_ALT):
        {
            map_alt ZIa;

            /* BEGINNING OF INLINE: 92 */
            {
                {
                    switch (CURRENT_TERMINAL) {
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
    
//#line 1278 "src/abnf/parser.c"
                    }
                    /* END OF ACTION: err-expected-alt */
                }
            ZL2:;
            }
            /* END OF INLINE: 92 */
            prod_list_Hof_Halts (lex_state, act_state, &ZIa);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL)) {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: make-alt */
            {
//#line 666 "src/parser.act"

        (ZIl) = ast_make_alt(act_state->invisible, (*ZIt));
    
//#line 1296 "src/abnf/parser.c"
            }
            /* END OF ACTION: make-alt */
            /* BEGINNING OF ACTION: add-alt-to-list */
            {
//#line 684 "src/parser.act"

        assert((ZIl)->next == nullptr);
        (ZIl)->next = (ZIa);
    
//#line 1306 "src/abnf/parser.c"
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
    
//#line 1319 "src/abnf/parser.c"
            }
            /* END OF ACTION: make-alt */
        }
        break;
    case (ERROR_TERMINAL):
        return;
    }
    goto ZL0;
ZL1:
    SAVE_LEXER ((ERROR_TERMINAL));
    return;
ZL0:
    *ZOl = ZIl;
}

static void prod_103(lex_state lex_state, act_state act_state, map_term* ZIl)
{
    switch (CURRENT_TERMINAL)
    {
        case (TOK_REP): case (TOK_STARTGROUP): case (TOK_STARTOPT): case (TOK_CHAR):
        case (TOK_IDENT): case (TOK_COUNT): case (TOK_CI__LITERAL): case (TOK_CS__LITERAL):
        case (TOK_PROSE): case (TOK_BINSTR): case (TOK_DECSTR): case (TOK_HEXSTR):
        case (TOK_BINRANGE): case (TOK_DECRANGE): case (TOK_HEXRANGE):
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

                assert((*ZIl)->next == nullptr);
                (*ZIl)->next = (ZIt);

                //#line 1358 "src/abnf/parser.c"
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

static void prod_factor_C_Celement(lex_state lex_state, act_state act_state, map_term *ZOt)
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
    
//#line 1402 "src/abnf/parser.c"
            }
            /* END OF ACTION: make-group-term */
        }
        break;
    case (TOK_CHAR): case (TOK_IDENT): case (TOK_CI__LITERAL): case (TOK_CS__LITERAL):
    case (TOK_PROSE): case (TOK_BINSTR): case (TOK_DECSTR): case (TOK_HEXSTR):
    case (TOK_BINRANGE): case (TOK_DECRANGE): case (TOK_HEXRANGE):
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

static void prod_105(lex_state lex_state, act_state act_state, map_count* ZI104, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_REP):
        {
            map_count ZImax;

            ADVANCE_LEXER;
            prod_87(lex_state, act_state, &ZImax);
            prod_factor_C_Celement(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: set-repeat */
            {
                //#line 553 "src/parser.act"

                assert((ZImax) >= (*ZI104) || !(ZImax));

                (ZIt)->min = (*ZI104);
                (ZIt)->max = (ZImax);

                //#line 1457 "src/abnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
        }
        break;
        case (TOK_STARTGROUP): case (TOK_CHAR): case (TOK_IDENT): case (TOK_CI__LITERAL):
        case (TOK_CS__LITERAL): case (TOK_PROSE): case (TOK_BINSTR): case (TOK_DECSTR):
        case (TOK_HEXSTR): case (TOK_BINRANGE): case (TOK_DECRANGE): case (TOK_HEXRANGE):
        {
            prod_factor_C_Celement(lex_state, act_state, &ZIt);
            if ((CURRENT_TERMINAL) == (ERROR_TERMINAL))
            {
                RESTORE_LEXER;
                goto ZL1;
            }
            /* BEGINNING OF ACTION: set-repeat */
            {
                //#line 553 "src/parser.act"

                assert((*ZI104) >= (*ZI104) || !(*ZI104));

                (ZIt)->min = (*ZI104);
                (ZIt)->max = (*ZI104);

                //#line 1480 "src/abnf/parser.c"
            }
            /* END OF ACTION: set-repeat */
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

static void prod_106(lex_state lex_state, act_state act_state, map_term* ZOt)
{
    map_term ZIt;

    switch (CURRENT_TERMINAL)
    {
        case (TOK_CI__LITERAL):
        {
            /* normalise case-insensitive strings for aesthetic reasons only */
            text ZIx(pattern_buffer(lex_state).tolower());

            ADVANCE_LEXER;

            (ZIt) = ast_make_literal_term(act_state->invisible, ZIx, true);

            break;
        }
        case (TOK_CS__LITERAL):
        {
            text ZIx = pattern_buffer(lex_state);

            ADVANCE_LEXER;

            (ZIt) = ast_make_literal_term(act_state->invisible, ZIx, false);
        
            break;
        }
        case (TOK_PROSE):
        {
            text ZIs = pattern_buffer(lex_state).trim();

            ADVANCE_LEXER;

            /* BEGINNING OF ACTION: make-prose-term */
            {
                if (0 == strcmp(ZIs.chars(), "kgt:invisible"))
                {
                    act_state->invisible = 1;

                    (ZIt) = ast_make_empty_term(act_state->invisible);
                }
                else if (0 == strcmp(ZIs.chars(), "kgt:visible"))
                {
                    act_state->invisible = 0;

                    (ZIt) = ast_make_empty_term(act_state->invisible);
                }
                else
                {
                    (ZIt) = ast_make_prose_term(act_state->invisible, ZIs);
                }
            }
            /* END OF ACTION: make-prose-term */
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

/* BEGINNING OF TRAILER */

//#line 738 "src/parser.act"


static int lgetc(struct LX_STATE* lx)
{
    const struct lex_state_s* lex_state;

    assert(lx != nullptr);
    assert(lx->getc_opaque != nullptr);

    lex_state = (struct lex_state_s*)(lx->getc_opaque);

    assert(lex_state->f != nullptr);

    return lex_state->f(lex_state->opaque);
}

struct ast_rule* abnf_input(int (*f)(void* opaque), void* opaque, parsing_errors* errors)
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
    (void)err_unimplemented;

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

    replace_real(g, *lex_state);

    return g;
}

//#line 1743 "src/abnf/parser.c"

/* END OF FILE */
