namespace Six.Ceylon.Ast
{
    public class Type
    {
        //TODO

        public sealed class Union : Type
        {
            public Union(Type left, Type right)
            {
                Left = left;
                Right = right;
            }

            public Type Left { get; }
            public Type Right { get; }
        }
    }
}
