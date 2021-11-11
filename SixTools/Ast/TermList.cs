using System.Collections;

namespace SixTools.Ast
{
    public class TermList : Term, IList<Term>
    {
        public TermList(IEnumerable<Term> terms)
        {
            Terms = terms.ToList();
        }

        public Term this[int index] { get => Terms[index]; set => Terms[index] = value; }

        protected List<Term> Terms { get; }

        public override bool IsAtomic => Terms.Count == 1 && Terms[0].IsAtomic;

        public int Count => Terms.Count;

        public bool IsReadOnly { get; }

        public void Add(Term item)
        {
            Terms.Add(item);
        }

        public void Clear()
        {
            Terms.Clear();
        }

        public bool Contains(Term item)
        {
            return Terms.Contains(item);
        }

        public void CopyTo(Term[] array, int arrayIndex)
        {
            Terms.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Term> GetEnumerator()
        {
            return Terms.GetEnumerator();
        }

        public int IndexOf(Term item)
        {
            return Terms.IndexOf(item);
        }

        public void Insert(int index, Term item)
        {
            Terms.Insert(index, item);
        }

        public bool Remove(Term item)
        {
            return Terms.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Terms.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Terms).GetEnumerator();
        }
    }
}
