/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * AST node rewriting
 */

#include <assert.h>
#include <limits.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include <ctype.h>

#include "errors.h"
#include "txt.h"
#include "ast.h"
#include "rewrite.h"
#include "xalloc.h"
#include "compiler_specific.h"
#include "parsing-error.h"

extern int allow_undefined; 

void replace_real(ast_rule* g, error_context lex_state)
{
    /* substitute placeholder rules for the real thing */
    {
        const struct ast_rule* p;
        const struct ast_alt* q;
        struct ast_term* t;
        struct ast_rule* r;

        for (p = g; p != NULL; p = p->next)
        {
            for (q = p->alts; q != NULL; q = q->next)
            {
                for (t = q->terms; t != NULL; t = t->next)
                {
                    if (t->type != TYPE_RULE)
                    {
                        continue;
                    }

                    r = ast_find_rule(g, t->u.rule->name);
                    if (r != NULL)
                    {
                        ast_free_rule((struct ast_rule*)t->u.rule);
                        t->u.rule = r;
                        continue;
                    }

                    if (!allow_undefined)
                    {
                        err_undefined(lex_state, t->u.rule->name);
                        /* XXX: would leak the ast_rule here */
                        continue;
                    }

                    {
                        const char* token = xstrdup(t->u.rule->name);

                        ast_free_rule((struct ast_rule*)t->u.rule);

#if true
                        Error::notimplemented();
#else
                        t->type = TYPE_TOKEN;
                        t->u.token = token;
#endif
                    }
                }
            }
        }
    }

}