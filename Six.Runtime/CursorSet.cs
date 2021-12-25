namespace Six.Runtime
{
    public class CursorSet : SortedSet<Cursor>
    {
        public override string ToString()
        {
            return string.Join(',', this);
        }
    }
}
