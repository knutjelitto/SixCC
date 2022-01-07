namespace Six.Gen.Typing
{
    public sealed class BaseType : TypeCore
    {
        public BaseType(string name) : base(name)
        {
        }

        public override string TypeName => $"R{Name.CsId()}{GenericsName}";

        public readonly SortedSet<InterfaceType> Generics = new();

        public string GenericsName => Generics.Count == 0 ? string.Empty : $"<{string.Join(",", Generics.Select(g => g.TypeName))}>";

        public override bool Equals(object obj)
        {
            return obj is BaseType that && Name == that.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
