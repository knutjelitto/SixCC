namespace Six.Gen.Typing
{
    public sealed class InterfaceType : TypeCore
    {
        public InterfaceType(string name) : base(name)
        {
        }

        public override string TypeName => "I" + Name.CsId();

        public override bool Equals(object obj)
        {
            return obj is InterfaceType that && Name == that.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

}
