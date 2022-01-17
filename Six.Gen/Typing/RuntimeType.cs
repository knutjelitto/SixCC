namespace Six.Gen.Typing
{
    public sealed class RuntimeType : ClassType
    {
        public RuntimeType(string name) : base(name)
        {
        }

        public override string TypeName => $"R{Name.CsId()}{GenericsName}";

        public override bool Equals(object obj)
        {
            return obj is RuntimeType that && Name == that.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
