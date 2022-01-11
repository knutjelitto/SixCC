namespace Six.Gen.Typing
{
    public sealed class BaseType : ClassType
    {
        public BaseType(string name) : base(name)
        {
        }

        public override string TypeName => $"R{Name.CsId()}{GenericsName}";

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
