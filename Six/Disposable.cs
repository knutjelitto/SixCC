using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six
{
    public class Disposable : IDisposable
    {
        public Disposable(Action onDispose)
        {
            if (onDispose is null)
            {
                throw new ArgumentNullException(nameof(onDispose));
            }
            OnDispose = onDispose;
        }

        public Action OnDispose { get; }

        public void Dispose()
        {
            OnDispose();
        }
    }
}
