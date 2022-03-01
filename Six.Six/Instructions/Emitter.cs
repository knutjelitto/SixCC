using Six.Core;
using System.Collections;

namespace Six.Six.Instructions
{
    public class Emitter : IReadOnlyList<Insn>
    {
        private readonly List<Insn> insns = new();

        public void Add(Insn insn)
        {
            insns.Add(insn);
        }

        public void Dump(Writer writer)
        {
            foreach (var insn in insns)
            {
                writer.WriteLine($"{insn}");
            }
        }

        public Insn this[int index] => insns[index];
        public int Count => insns.Count;
        public IEnumerator<Insn> GetEnumerator() => insns.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)insns).GetEnumerator();
    }
}
