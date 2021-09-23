using System;
using System.Diagnostics;

namespace Six.Tools
{
    public class Disposable : IDisposable
    {
        [DebuggerStepThrough]
        public Disposable(Action onDispose)
        {
            OnDispose = onDispose;
        }

        public Action OnDispose { get; }

        public void Dispose()
        {
            OnDispose();
        }
    }
}
