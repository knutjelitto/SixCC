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

        public override string ToString()
        {
            return char.ConvertFromUtf32(value);
        }
    }
}
