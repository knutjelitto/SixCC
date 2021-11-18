using System;
using System.IO;

namespace Six.Core
{
    public static class Temp
    {
        private static string temp = string.Empty;

        public static string TempPath(string top)
        {
            if (Find(Path.Combine(Environment.CurrentDirectory, "../../../../..")) ||
                Find("D:/") ||
                Find("C:/Dev/Knut"))
            {
                var outPath = Path.GetFullPath(Path.Combine(temp, top));
                if (!Directory.Exists(outPath))
                {
                    _ = Directory.CreateDirectory(outPath);
                }
                return outPath;
            }

            throw new DirectoryNotFoundException("SixTmp");
        }

        private static bool Find(string test)
        {
            if (temp.Length > 0 && Directory.Exists(temp))
            {
                return true;
            }
            foreach (var sub in Directory.EnumerateDirectories(test, "SixTmp", SearchOption.AllDirectories))
            {
                if (Directory.Exists(sub))
                {
                    temp = Path.GetFullPath(sub);
                    return true;
                }
            }
            return false;
        }
    }
}
