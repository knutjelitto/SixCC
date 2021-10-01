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

    public abstract class ast_core
    {
        public ast_core(ast_type type, int invisible)
        {
            this.type = type;
            this.invisible = invisible;
            min = 1;
            max = 1;
        }

        public ast_type type;
        public uint min;
        public uint max; /* false (0) for unlimited */

        public int invisible;
    }

    /*
     * A term is a sequential list of items within an alt. Each item may be
     * a terminal literal, a production rule name, or a group of terms.
     *
     * A term may be repeated a number of times, as in the EBNF x * 3 construct.
     *
     * a + b + c ;
     */
    public class ast_term : ast_core
    {
        public ast_term(ast_type type, int invisible)
            : base(type, invisible)
        {
        }

        public ast_term? next;
    };


    public class ast_empty : ast_term
    {
        public ast_empty(int invisible)
            : base(ast_type.TYPE_EMPTY, invisible)
        {
        }
    }

    public class ast_ci_literal_term : ast_term
    {
        public ast_ci_literal_term(int invisible, string literal) : base(ast_type.TYPE_CI_LITERAL, invisible)
        {
            this.literal = literal;
        }

        public string literal;
    }

    public class ast_cs_literal_term : ast_term
    {
        public ast_cs_literal_term(int invisible, string literal) : base(ast_type.TYPE_CS_LITERAL, invisible)
        {
            this.literal = literal;
        }

        public string literal;
    }

    public class ast_token_term : ast_term
    {
        public ast_token_term(int invisible, string token) : base(ast_type.TYPE_TOKEN, invisible)
        {
            this.token = token;
        }

        public string token;
    }

    public class ast_prose_term : ast_term
    {
        public ast_prose_term(int invisible, string prose) : base(ast_type.TYPE_PROSE, invisible)
        {
            this.prose = prose;
        }

        public string prose;
    }

    public class ast_group_term : ast_term
    {
        public ast_group_term(int invisible, ast_alt group)
            : base(ast_type.TYPE_RULE, invisible)
        {
            this.group = group;
        }

        public ast_alt group;
    }

    public class ast_rule_term : ast_term
    {
        public ast_rule_term(int invisible, ast_rule rule)
            : base(ast_type.TYPE_RULE, invisible)
        {
            this.rule = rule;
        }

        public ast_rule rule;
    }

    /*
     * A grammar is a list of production rules. Each rule maps a name onto a list
     * of alternatives:
     *
     * name1 := alt1 | alt2 | alt3 ;
     * name2 := alt1 ;
     */
    public class ast_rule
    {
        public ast_rule(string name, ast_alt alts)
        {
            this.name = name; ;
            this.alts = alts;
            next = null;
        }


        public string name;

        public ast_alt alts;

        public ast_rule? next;
    }

    /*
     * An alternative is one of several choices:
     *
     * a | b | c
     */
    public class ast_alt
    {
        public ast_alt(int invisible, ast_term terms)
        {
            this.invisible = invisible;
            this.terms = terms;
            next = null;
        }

        public ast_term terms;

        /* TODO: struct ast_term *negs; - negative terms here */

        public int invisible;

        public ast_alt? next;
    };

    internal static class ast
    {
        public static bool isalphastr(string t)
        {
            return t.Any(c => char.IsLetter(c));
        }

        public static ast_term ast_make_rule_term(int invisible, ast_rule rule)
        {
            return new ast_rule_term(invisible, rule);
        }

        public static ast_term ast_make_char_term(int invisible, char c)
        {
            return new ast_cs_literal_term(invisible, c.ToString());
        }

        public static ast_term ast_make_literal_term(int invisible, string literal, int ci)
        {
            if (!isalphastr(literal) || ci != 0)
            {
                return new ast_ci_literal_term(invisible, literal);
            }
            return new ast_cs_literal_term(invisible, literal);
        }

        public static ast_term ast_make_token_term(int invisible, string token)
        {
            return new ast_token_term(invisible, token);
        }

        public static ast_term ast_make_prose_term(int invisible, string prose)
        {
            return new ast_prose_term(invisible, prose);
        }

        public static ast_term ast_make_group_term(int invisible, ast_alt group)
        {
            return new ast_group_term(invisible, group);
        }

        public static ast_alt ast_make_alt(int invisible, ast_term terms)
        {
            return new ast_alt(invisible, terms);
        }

        public static ast_rule ast_make_rule(string name, ast_alt alts)
        {
            return new ast_rule(name, alts);
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
