using Six.Six.Sema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public static class LayoutExtensions
    {
        public static IEnumerable<Decl.Interface> Closure(this IEnumerable<Decl.Interface> ifaces)
        {
            var todo = new Queue<Decl.Interface>();
            var set = new HashSet<Decl.Interface>();

            foreach (var iface in ifaces)
            {
                todo.Enqueue(iface);
            }

            while (todo.Count > 0)
            {
                var iface = todo.Dequeue();

                if (set.Add(iface))
                {
                    set.Add(iface);
                    foreach (var close in iface.Satisfies)
                    {
                        todo.Enqueue(close);
                    }
                }
            }

            return set;
        }
    }
}
