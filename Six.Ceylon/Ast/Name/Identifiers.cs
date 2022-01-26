namespace Six.Ceylon.Ast
{
    public class Identifiers : IReadOnlyList<Identifier>
    {
        private List<Identifier> identifiers;

        public Identifiers(IEnumerable<Identifier> ids)
        {
            identifiers = ids.ToList();
        }

        public Identifier this[int index] => identifiers[index];
        public int Count => identifiers.Count;
        public IEnumerator<Identifier> GetEnumerator() => identifiers.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)identifiers).GetEnumerator();
    }
}
