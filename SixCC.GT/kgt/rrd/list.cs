using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCC.GT.kgt.rrd
{
    internal class list
    {
        public node node;
        public list? next = null;

        private list(node node, list? next)
        {
            this.node = node;
            this.next = next;
        }

        public static void push(ref list? list, node node)
        {
            list = new list(node, list);
        }

        public static node? pop(ref list? list)
        {
            if (list == null)
            {
                return null;
            }

            var node = list.node;
            list = list.next;

            return node;
        }

        public static void cat(ref list? dst, list src)
        {
            if (dst == null)
            {
                dst = new list(src.node, null);
            }
            else
            {
                list current = dst;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new list(src.node, null);
            }
        }

        public static bool eq(list a, list b)
        {
            list? p, q;

            for (p = a, q = b; p != null && q != null; p = p.next, q = q.next)
            {
                if (!node.eq(p.node, q.node))
                {
                    return false;
                }
            }

            if (p != null || q != null)
            {
                /* lists are of different length */
                return false;
            }

            return true;
        }

        public static int compare(list a, list b)
        {
            return eq(a, b) ? 1 : 0;
        }
    }
}
