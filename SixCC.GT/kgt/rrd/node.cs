using static SixCC.GT.kgt.Txt;

namespace SixCC.GT.kgt.rrd
{
    internal enum rrd_features
    {
        FEATURE_RRD_CI_LITERAL = 1 << 0,
    };

    internal enum node_type
    {
        NODE_CI_LITERAL,
        NODE_CS_LITERAL,
        NODE_RULE,
        NODE_PROSE,
        NODE_ALT,
        NODE_ALT_SKIPPABLE,
        NODE_SEQ,
        NODE_LOOP,
    };

    internal abstract class node
    {
        public node(node_type type, int invisible)
        {
            this.type = type;
            this.invisible = invisible;
        }

        public node_type type;
        public int invisible;

        public virtual bool eq(node node)
        {
            return type == node.type && invisible == node.invisible;
        }

        public static bool eq(node? a, node? b)
        {
            if (a == null && b == null)
            {
                return true;
            }

            if (a == null || b == null)
            {
                return false;
            }

            if (a.type != b.type)
            {
                return false;
            }

            if (a.invisible != b.invisible)
            {
                return false;
            }

            return a.eq(b);
        }

        public static int compare(node? a, node? b)
        {
            return eq(a, b) ? 1 : 0;
        }

        public static void make_seq(int invisible, ref node node)
        {
            if (node is seq_node)
            {
                return;
            }

            list? l = null;

            list.push(ref l, node);

            node = new seq_node(invisible, l!);
        }
    }

    internal class ci_literal_node : node
    {
        public ci_literal_node(int invisible, string literal)
            : base(node_type.NODE_CI_LITERAL, invisible)
        {
            this.literal = literal;
        }

        public string literal; /* TODO: point to ast_literal instead */

        public override bool eq(node node)
        {
            return base.eq(node) && txtcasecmp(literal, ((ci_literal_node)node).literal) == 0;
        }
    }

    internal class cs_literal_node : node
    {
        public cs_literal_node(int invisible, string literal)
            : base(node_type.NODE_CS_LITERAL, invisible)
        {
            this.literal = literal;
        }

        public string literal; /* TODO: point to ast_literal instead */

        public override bool eq(node node)
        {
            return base.eq(node) && txtcmp(literal, ((cs_literal_node)node).literal) == 0;
        }
    }

    internal class rule_node : node
    {
        public rule_node(int invisible, string name)
            : base(node_type.NODE_RULE, invisible)
        {
            this.name = name;
        }

        public string name;   /* TODO: point to ast_rule instead */

        public override bool eq(node node)
        {
            return base.eq(node) && txtcmp(name, ((rule_node)node).name) == 0;
        }
    }

    internal class prose_node : node
    {
        public prose_node(int invisible, string prose)
            : base(node_type.NODE_RULE, invisible)
        {
            this.prose = prose;
        }

        public string prose;

        public override bool eq(node node)
        {
            return base.eq(node) && txtcmp(prose, ((prose_node)node).prose) == 0;
        }
    }

    internal class alt_node : node
    {
        public alt_node(int invisible, list alt)
            : base(node_type.NODE_ALT, invisible)
        {
            this.alt = alt;
        }

        public list alt;

        public override bool eq(node node)
        {
            return base.eq(node) && list.eq(alt, ((alt_node)node).alt);
        }
    }

    internal class alt_skipable_node : node
    {
        public alt_skipable_node(int invisible, list alt)
            : base(node_type.NODE_ALT_SKIPPABLE, invisible)
        {
            this.alt = alt;
        }

        public list alt;

        public override bool eq(node node)
        {
            return base.eq(node) && list.eq(alt, ((alt_skipable_node)node).alt);
        }
    }

    internal class seq_node : node
    {
        public seq_node(int invisible, list seq)
            : base(node_type.NODE_SEQ, invisible)
        {
            this.seq = seq;
        }

        public list seq;

        public override bool eq(node node)
        {
            return base.eq(node) && list.eq(seq, ((seq_node)node).seq);
        }
    }

    internal class loop_node : node
    {
        public loop_node(int invisible, node forward, node backward)
            : base(node_type.NODE_LOOP, invisible)
        {
            this.forward = forward;
            this.backward = backward;
            this.min = 0;
            this.max = 0;
        }


        public node forward;
        public node backward;
        public uint min;
        public uint max;

        public override bool eq(node node)
        {
            return base.eq(node)
                && node is loop_node other
                && eq(forward, other.forward)
                && eq(backward, other.backward);
        }

        public void flip()
        {
            var tmp = backward;
            backward = forward;
            forward = tmp;
        }
    }
}
