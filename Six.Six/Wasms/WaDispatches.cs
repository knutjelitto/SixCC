using Six.Core;
using Six.Runtime;

namespace Six.Six.Wasms
{
    public class WaDispatches : WithWriter, Wamber
    {
        private readonly List<WaDispatch> items = new();

        public WaDispatches(WaClass clazz)
            : base(clazz.Writer)
        {
            Class = clazz;
        }

        public int Index { get; set; } = -1;
        public int Count => items.Count;

        public WaClass Class { get; }

        public void Add(WaDispatch dispatch)
        {
            items.Add(dispatch);
        }

        public bool AreTheSame(WaDispatches other)
        {
            return items.SequenceEqual(other.items);
        }

        public void Prepare()
        {
            Assert(Index >= 0);
            for (var i = 0; i < items.Count; i++)
            {
                items[i].Index = Index + i;
                items[i].Prepare();
            }
        }

        public void Emit()
        {
            wl($"(; {Class.Name} ;)");
            foreach (var dispatch in items)
            {
                dispatch.Emit();
            }
        }
    }
}
