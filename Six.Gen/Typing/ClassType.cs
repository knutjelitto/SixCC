namespace Six.Gen.Typing
{
    public sealed class ClassType : TypeCore
    {
        public ClassType(string name) : base(name)
        {
        }

        public override string TypeName => "C" + Name.CsId();

        public override bool Equals(object obj)
        {
            return obj is ClassType that && Name == that.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
