using System.Diagnostics;

namespace Six.Core
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
