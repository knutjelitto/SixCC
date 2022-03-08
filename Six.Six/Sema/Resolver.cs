using Six.Core;
using System;
using A = Six.Six.Ast;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        private readonly Stack<Decl.Memby> membies = new();

        private Decl.Funcy CurrentFunction => membies.Peek() as Decl.Funcy ?? throw new InvalidCastException();
        private Decl.Memby CurrentMemby => membies.Peek();

        private IDisposable UseMemby(Decl.Memby memby)
        {
            membies.Push(memby);
            return new Disposable(() => membies.Pop());
        }

        private bool InFuncy => membies.Count > 0 && membies.Peek() is Decl.Funcy;
        private bool InClassy => membies.Count > 0 && membies.Peek() is Decl.Classy;
        private bool InMemby => membies.Count > 0 && membies.Peek() is Decl.Memby;
    }
}
