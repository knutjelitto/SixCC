using Six.Core.Errors;
using System;
using static System.Formats.Asn1.AsnWriter;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public partial class Resolver
    {
        private readonly Queue<Action> scheduled = new();

        public void Schedule(Action action)
        {
            scheduled.Enqueue(action);
        }

        public void Resolve()
        {
            while (scheduled.Count > 0)
            {
                var action = scheduled.Dequeue();

                try
                {
                    action();
                }
                catch (DiagnosticException diagnostics)
                {
                    foreach (var diagnostic in diagnostics.Diagnostics)
                    {
                        Module.Add(diagnostic);
                    }
                }
            }
        }
    }
}
