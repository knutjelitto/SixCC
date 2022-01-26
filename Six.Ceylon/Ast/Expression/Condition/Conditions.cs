using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class Conditions : IReadOnlyList<Condition>
    {
        private readonly List<Condition> items;

        public Conditions(IEnumerable<Condition> items)
        {
            this.items = items.ToList();
        }

        public Condition this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<Condition> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
