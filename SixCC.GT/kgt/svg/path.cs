using System.Diagnostics;

namespace SixCC.GT.kgt.svg
{
    public enum path_type
    {
        PATH_H, /* horizontal */
        PATH_V, /* vertical */
        PATH_Q  /* quadratic */
    };

    public abstract class path
    {
        public path(path_type type, uint x, uint y)
        {
            this.type = type;
            this.x = x;
            this.y = y;
            next = null;
        }

        public path_type type;
        public uint x;
        public uint y;

        public path? next;

        public static void h(ref path? paths, uint x, uint y, int n)
        {
            paths = new path_h(x, y, n)
            {
                next = paths
            };
        }

        public static void v(ref path? paths, uint x, uint y, int n)
        {
            paths = new path_v(x, y, n)
            {
                next = paths
            };
        }

        public static void q(ref path? paths, uint x, uint y, int rx, int ry, int mx, int my)
        {
            paths = new path_q(x, y, rx, ry, mx, my)
            {
                next = paths
            };
        }

        public static void move(path n, out uint x, out uint y)
        {
            x = n.x;
            y = n.y;

            switch (n)
            {
                case path_h h:
                    x += (uint)h.n;
                    break;
                case path_v v:
                    y += (uint)v.n;
                    break;
                case path_q q:
                    x += (uint)q.mx;
                    y += (uint)q.my;
                    break;
            }
        }

        public static path? find_preceding(path? paths, path n)
        {
            path? p;

            /*
             * Find any node that ends at the given position.
             */

            for (p = paths; p != null; p = p.next)
            {

                /* self loop */
                if (n == p)
                {
                    continue;
                }

                move(p, out uint nx, out uint ny);

                if (nx == n.x && ny == n.y)
                {
                    return p;
                }
            }

            return null;
        }

        public static path? find_following(path? paths, uint x, uint y)
        {
            path? p;

            /*
             * Find any node which starts from the given position.
             */

            for (p = paths; p != null; p = p.next)
            {
                if (p.x == x && p.y == y)
                {
                    return p;
                }
            }

            return null;
        }

        public static path find_start(path paths)
        {
            path? p;

            /*
             * Find any node which doesn't have a node connecting to it.
             * That is, an entry point to a sequence.
             */

            for (p = paths; p != null; p = p.next)
            {
                if (find_preceding(p.next, p) == null)
                {
                    return p;
                }
            }

            /* then it's a loop; any will do */
            return paths;
        }

        public static void remove(ref path? paths, path node)
        {
            path? prev = null;

            for (var current = paths; current != null; current = current.next)
            {
                if (current == node)
                {
                    if (prev != null)
                    {
                        prev.next = current.next;
                    }
                    else
                    {
                        paths = null;
                    }
                    break;
                }
                prev = current;
            }
        }

        public static void merge(ref path? paths, path p, path q)
        {
            Debug.Assert(p.type != path_type.PATH_Q && p.type == q.type);

            switch (p)
            {
                case path_h h:
                    h.n += ((path_h)q).n;
                    break;
                case path_v v:
                    v.n += ((path_v)q).n;
                    break;
            }

            remove(ref paths, q);
        }

        public static void consolidate(ref path? paths)
        {
            path? p, q;

            for (p = paths; p != null; p = p.next)
            {

                if (p.type == path_type.PATH_Q)
                {
                    /* not implemented */
                    continue;
                }

                move(p, out uint nx, out uint ny);

                q = paths;

                while ((q = find_following(q, nx, ny)) != null)
                {
                    /* XXX: can happen when n=0 */
                    if (p == q)
                    {
                        q = q.next;
                        continue;
                    }

                    if (q.type != p.type)
                    {
                        /*
                         * Search onwards from q->next, so as to not re-visit
                         * differently-typed nodes (which remain in the list)
                         */
                        q = q.next;
                        continue;
                    }
                    merge(ref paths, p, q);

                    move(p, out nx, out ny);

                    /* back to the start, because nx, ny differ now */
                    q = paths;
                }
            }
        }
    }

    public abstract class path_hv : path
    {
        protected path_hv(path_type type, uint x, uint y, int n) : base(type, x, y)
        {
            this.n = n;
        }

        public int n;

    }

    public class path_h : path_hv
    {
        public path_h(uint x, uint y, int n) : base(path_type.PATH_H, x, y, n)
        {
        }
    }

    public class path_v : path_hv
    {
        public path_v(uint x, uint y, int n) : base(path_type.PATH_V, x, y, n)
        {
        }
    }

    public class path_q : path
    {
        public path_q(uint x, uint y, int rx, int ry, int mx, int my) : base(path_type.PATH_Q, x, y)
        {
            this.rx = rx;
            this.ry = ry;
            this.mx = mx;
            this.my = my;
        }

        public int rx;
        public int ry;
        public int mx;
        public int my;
    }
}
