using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Instructions
{
    public class InsnList : IReadOnlyList<Insn>
    {
        private readonly List<Insn> insns = new();

        public void Add(Insn insn)
        {
            insns.Add(insn);
        }

        public Insn this[int index] => insns[index];
        public int Count => insns.Count;
        public IEnumerator<Insn> GetEnumerator() => insns.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)insns).GetEnumerator();
    }
}
