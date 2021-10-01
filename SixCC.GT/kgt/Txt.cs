namespace SixCC.GT.kgt
{
    internal static class Txt
    {
        public static int txtcasecmp(string t1, string t2)
        {
            return string.Compare(t1, t2, true);
        }
        public static int txtcmp(string t1, string t2)
        {
            return string.Compare(t1, t2, false);
        }
    }
}
