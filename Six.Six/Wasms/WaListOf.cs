﻿using Six.Core;
using Six.Runtime;
using System.Collections;

namespace Six.Six.Wasms
{
    public class WaListOf<T> : WithWriter, Wamber, IReadOnlyList<T>
        where T : Wamber
    {
        private readonly List<T> items = new();

        public WaListOf(IWithWriter withWriter)
            : base(withWriter.Writer)
        {
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public virtual void Prepare()
        {
            foreach (var item in items)
            {
                item.Prepare();
            }
        }

        public virtual void Emit()
        {
            foreach (var item in items)
            {
                item.Emit();
            }
        }

        public T this[int index] => items[index];
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();
    }
}
