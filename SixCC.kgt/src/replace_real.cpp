/*
 * Copyright 2014-2019 Katherine Flavel
 *
 * See LICENCE for the full copyright terms.
 */

/*
 * AST node rewriting
 */

#include <vector>

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

void replace_real(ast_grammar& grammar, error_context lex_state)
{
    /* substitute placeholder rules for the real thing */
    {
        struct ast_alt* alt;
        struct ast_rule* replacement;

        for (auto rule : grammar.rules)
        {
            for (alt = rule->alts; alt != nullptr; alt = alt->next)
            {
                std::vector<ast_term*> vterms;

                for (auto term : alt->terms)
                {
                    vterms.push_back(term);
                }

                for (int i = 0; i < vterms.size(); i += 1)
                {
                    ast_term* term = vterms[i];

                    if (term->type != TYPE_RULE)
                    {
                        continue;
                    }

                    replacement = ast_find_rule(grammar, term->rule()->name);
                    if (replacement != nullptr)
                    {
                        ast_free_rule((struct ast_rule*)term->rule());
                        term->set_rule(replacement);
                        continue;
                    }

                    if (!allow_undefined)
                    {
                        err_undefined(lex_state, term->rule()->name);
                        /* XXX: would leak the ast_rule here */
                        continue;
                    }

                    ast_term* new_term = ast_term::make_token(term->invisible, term->rule()->name);

                    vterms[i] = new_term;
                    ast_free_rule((struct ast_rule*)term->rule());
                    delete term;
                }

                if (vterms.size() > 0)
                {
                    alt->terms.clear();
                    alt->terms.insert(alt->terms.begin(), vterms.begin(), vterms.end());
                }

#if false
                for (term = alt->terms; term != nullptr; term = term->next)
                {
                    if (term->type != TYPE_RULE)
                    {
                        continue;
                    }

                    replacement = ast_find_rule(grammar, term->rule()->name());
                    if (replacement != nullptr)
                    {
                        ast_free_rule((struct ast_rule*)term->rule());
                        term->set_rule(replacement);
                        continue;
                    }

                    if (!allow_undefined)
                    {
                        err_undefined(lex_state, term->rule()->name());
                        /* XXX: would leak the ast_rule here */
                        continue;
                    }

                    {
                        const char* token = xstrdup(term->rule()->name());

                        ast_free_rule((struct ast_rule*)term->rule());

                        term->type = TYPE_TOKEN;
                        term->u.token = token;
                    }
                }
#endif
            }
        }
    }

}