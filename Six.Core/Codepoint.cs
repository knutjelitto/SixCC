namespace Six.Core
{
    public struct Codepoint
    {
        private readonly int value;

        public Codepoint(int value)
        {
            this.value = value;
        }

        public static explicit operator int(Codepoint cp)
        {
            return cp.value;
        }

        public static string operator +(Codepoint cp1, Codepoint cp2)
        {
            return char.ConvertFromUtf32(cp1.value) + char.ConvertFromUtf32(cp2.value);
        }

        public static string operator +(Codepoint cp1, string s2)
        {
            return char.ConvertFromUtf32(cp1.value) + s2;
        }

        public override bool Equals(object? obj)
        {
            return obj is Codepoint other && value == other.value;
        }

        public override int GetHashCode() => value.GetHashCode();

        public override string ToString()
        {
            return char.ConvertFromUtf32(value);
        }
    }
}
