namespace Six.Gen.Typing
{
    public sealed class SpecialType : ClassType
    {
        public SpecialType(string name) : base(name)
        {
        }

        public override string TypeName => $"X{Name.CsId()}{GenericsName}";

        public override bool Equals(object obj)
        {
            return obj is SpecialType that && Name == that.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
