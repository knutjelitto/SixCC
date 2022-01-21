namespace Six.Runtime.Types
{
    public class RNode
    {
        public RNode(params RNode[] children)
        {
            Children = children;
        }

        public RNode[] Children { get; }

        public T Get<T>(int index) => (T)(object)Children[index];

        protected string CommonName()
        {
            return CommonName(GetType());
        }

        protected string CommonName(Type type)
        {
            if (type.IsGenericType)
            {
                var argument = type.GetGenericArguments()[0];
                return $"{type.GetGenericTypeDefinition().Name[..^2]}<{argument.Name}>";
            }
            else
            {
                return type.Name;
            }
        }

        public override string ToString()
        {
            return $"{CommonName()}";
        }
    }
}
