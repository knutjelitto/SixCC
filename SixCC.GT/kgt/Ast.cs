namespace SixCC.GT.kgt
{
    public enum ast_features
    {
        FEATURE_AST_CI_LITERAL = 1 << 0,
        FEATURE_AST_PROSE = 1 << 1,
        FEATURE_AST_BINARY = 1 << 2,
        FEATURE_AST_INVISIBLE = 1 << 3
    };

    public enum ast_type
    {
        TYPE_EMPTY,
        TYPE_RULE,
        TYPE_CS_LITERAL,
        TYPE_CI_LITERAL,
        TYPE_TOKEN,
        TYPE_PROSE,
        TYPE_GROUP
    };

    /*
     * A term is a sequential list of items within an alt. Each item may be
     * a terminal literal, a production rule name, or a group of terms.
     *
     * A term may be repeated a number of times, as in the EBNF x * 3 construct.
     *
     * a + b + c ;
     */
    public class ast_term
    {
        public ast_type type;

#if false
        union {
		const struct ast_rule *rule; /* just for sake of the name */
		struct txt literal;
		const char* token;
        const char* prose;
        struct ast_alt *group;
	    }
        u;
#else
        public object? u;
#endif

        public uint min;
        public uint max; /* false (0) for unlimited */

        public int invisible;

        public ast_term? next;
    };

    /*
     * An alternative is one of several choices:
     *
     * a | b | c
     */
    public class ast_alt
    {
        public ast_term? terms;
	    /* TODO: struct ast_term *negs; - negative terms here */

	    public int invisible;

        public ast_alt? next;
    };

    /*
     * A grammar is a list of production rules. Each rule maps a name onto a list
     * of alternatives:
     *
     * name1 := alt1 | alt2 | alt3 ;
     * name2 := alt1 ;
     */
    public class ast_rule
    {
        public string name = string.Empty;

        public ast_alt? alts;

	    public ast_rule? next;
    };

    public static class Ast
    {
        public static bool isalphastr(string t)
        {
            return t.Any(c => char.IsLetter(c));
        }

        public static ast_term ast_make_empty_term(int invisible)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_EMPTY,
                next = null,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_rule_term(int invisible, ast_rule rule)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_RULE,
                next = null,
                u = rule,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_char_term(int invisible, char c)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_CS_LITERAL,
                next = null,
                u = c.ToString(),
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_literal_term(int invisible, string literal, int ci)
        {
            var ia = isalphastr(literal);
            var ty = (ci != 0 || !ia) ? ast_type.TYPE_CI_LITERAL : ast_type.TYPE_CS_LITERAL;

            return new ast_term()
            {
                type = ty,
                next = null,
                u = literal,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_token_term(int invisible, string token)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_TOKEN,
                next = null,
                u = token,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_prose_term(int invisible, string prose)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_PROSE,
                next = null,
                u = prose,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_term ast_make_group_term(int invisible, ast_alt group)
        {
            return new ast_term()
            {
                type = ast_type.TYPE_PROSE,
                next = null,
                u = group,
                min = 1,
                max = 1,
                invisible = invisible,
            };
        }

        public static ast_alt ast_make_alt(int invisible, ast_term terms)
        {
            return new ast_alt()
            {
                terms = terms,
                next = null,
                invisible = invisible,
            };
        }

        public static ast_rule ast_make_rule(string name, ast_alt alts)
        {
            return new ast_rule()
            {
                name = name,
                alts = alts,
                next = null,
            };
        }

        public static ast_rule? ast_find_rule(ast_rule grammar, string name)
        {
            ast_rule? p;

	        for (p = grammar; p != null; p = p.next)
            {
		        if (p.name == name)
                {
			        return p;
		        }
            }

            return null;
        }
    }
}
