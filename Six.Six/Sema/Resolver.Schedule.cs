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
        private readonly Queue<Action> pendingTypes = new();
        private readonly Queue<Action> pendingExpressions = new();

        public void ScheduleType(Action action)
        {
            Schedule(pendingTypes, action);
        }

        public void ScheduleExpr(Action action)
        {
            Schedule(pendingExpressions, action);
        }

        public void Resolve()
        {
            while (pendingTypes.Count > 0 || pendingExpressions.Count > 0)
            {
                ResolveTypes();
                ResolveExpressions();
            }
        }

        private void PerformAction(Action action)
        {
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

        private void ResolveTypes()
        {
            while (pendingTypes.Count > 0)
            {
                PerformAction(pendingTypes.Dequeue());
            }
        }

        private void ResolveExpressions()
        {
            while (pendingTypes.Count == 0 && pendingExpressions.Count > 0)
            {
                PerformAction(pendingExpressions.Dequeue());
            }
        }

        private void Schedule(Queue<Action> scheduled, Action action)
        {
            if (functions.Count > 0)
            {
                var function = CurrentFunction;

                scheduled.Enqueue(() =>
                {
                    using (UseFuncy(function))
                    {
                        action();
                    }
                });
            }
            else
            {
                scheduled.Enqueue(action);
            }
        }
    }
}
