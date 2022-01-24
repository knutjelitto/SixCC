namespace Six.Runtime.Types
{
    public class RNode : IRNode
    {
        public RNode(params RNode[] children)
        {
            Children = children;
        }

        public RNode[] Children { get; }

        public object? Value { private get; set; } = null;

        public T? GetValue<T>() where T : class => Value as T;

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
