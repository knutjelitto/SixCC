using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public class Props
    {
        private readonly Dictionary<string, Member> pairs = new();

        public Member? Get(string name)
        {
            if (pairs.TryGetValue(name, out var result))
            {
                return result;
            }
            return null;
        }

        public T? Get<T>(string name) where T : Member => (T?)Get(name);

        public void Set(string name, Member value)
        {
            pairs[name] = value;
        }

        public bool TrySet(string name, Member value)
        {
            if (pairs.ContainsKey(name))
            {
                return false;
            }
            pairs[name] = value;
            return true;
        }
    }
}
