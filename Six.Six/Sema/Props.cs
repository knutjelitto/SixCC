using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public interface WithProps
    {
        Props Props { get; }
    }

    public class Props
    {
        private readonly Dictionary<string, Entity> pairs = new();

        public Entity? Get(string name)
        {
            if (pairs.TryGetValue(name, out var result))
            {
                return result;
            }
            return null;
        }

        public T? Get<T>(string name) where T : Entity => (T?)Get(name);

        public bool TrySet(string name, Entity? value)
        {
            if (value == null || pairs.ContainsKey(name))
            {
                return false;
            }
            pairs[name] = value;
            return true;
        }
    }
}
