namespace Six.Gen.Typing
{
    public abstract class TypeCore : IComparable<TypeCore>
    {
        public TypeCore(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract string TypeName { get; }

        public SortedSet<InterfaceType> Interfaces { get; } = new();
        public BaseType? Base { get; set; }

        public string BaseName => Base == null ? string.Empty : Base.TypeName;

        public string InterfaceNames => $"{string.Join(",", Interfaces.Select(b => b.TypeName))}";

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(TypeName);
            if (Base != null || Interfaces.Count > 0)
            {
                builder.Append(":");
                if (Base != null)
                {
                    builder.Append($"{BaseName}");
                    if (Interfaces.Count > 0)
                    {
                        builder.Append(",");
                    }
                }
                if (Interfaces.Count > 0)
                {
                    builder.Append(InterfaceNames);
                }
            }
            return builder.ToString();
        }

        public int CompareTo(TypeCore that)
        {
            return Name.CompareTo(that.Name);
        }
    }
}
