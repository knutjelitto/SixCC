using Six.Gen.Ebnf;

namespace Six.Gen.Typing
{
    public class ClassType : TypeCore
    {
        public ClassType(string name) : base(name)
        {
        }

        public override string TypeName => "C" + Name.CsId();

        public TypeCore? Generic { get; set; }

        public string GenericsName => Generic == null ? string.Empty : $"<{Generic.TypeName}>";

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
