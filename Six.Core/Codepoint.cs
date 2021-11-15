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

        public override bool Equals([NotNullWhen(true)] object? obj)
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
