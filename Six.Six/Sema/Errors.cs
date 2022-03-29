using Six.Core;
using Six.Core.Errors;

using A = Six.Six.Ast;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Sema
{
    public class Errors
    {
        public Errors(Module module)
        {
            Module = module;
        }

        public Module Module { get; }

        public DiagnosticException DupError(Decl named, Decl already)
        {
            var diagnostic1 = new SemanticError(named.Location, $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.Location, $"identifier '{already.Name}' introduced here");

            return new DiagnosticException(diagnostic1, diagnostic2);
        }

        public DiagnosticException CantResolve(A.TreeNode tree, string name)
        {
            var diagnostic = new SemanticError(tree.GetLocation(), $"the name '{name}' doesn't exist in the current context");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException CantResolveMember(ILocation location, string name)
        {
            var diagnostic = new SemanticError(location, $"member '{name}' not found");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException CantResolveInCore(string what, string name)
        {
            var diagnostic = new InternalError($"can't resolve {what} ``{name}´´ in ``{Module.CoreNamespace}´´");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException TypeMismatch(ILocation location, Type expected, Type actual)
        {
            var diagnostic = new SemanticError(location, $"expected type '{expected}' but found '{actual}'");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException MustBeAnInterface(A.Type tree)
        {
            var diagnostic = new SemanticError(tree.GetLocation(), $"{Names.Nouns.Interface} type expected here");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException TooBigInteger(A.TreeNode tree, string? what = null)
        {
            if (what != null)
            {
                return new DiagnosticException(new SemanticError(tree.GetLocation(), $"value is too big to fit any integer"));
            }
            return new DiagnosticException(new SemanticError(tree.GetLocation(), $"value is too big to fit '{what}'"));
        }

        public DiagnosticException SubjectShouldNotBeMarkedAs(Decl.Funcy funcy, string subject, string attribute)
        {
            var diagnostic = new SemanticError(funcy.Location, $"{subject} '{funcy.Name}' shouldn't be marked as '{attribute}'");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException SubjectMustBeImplemented(Decl.Funcy funcy, string subject)
        {
            var diagnostic = new SemanticError(funcy.Location, $"{subject} '{funcy.Name}' must have an implementation");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException SubjectShouldNotBeImplemented(Decl.Funcy funcy, string subject)
        {
            var diagnostic = new SemanticError(funcy.Location, $"{subject} '{funcy.Name}' can't be implemented here");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException AbstractNotImplemented(Decl.Classy classy, Decl.Funcy funcy, string subject)
        {
            var diagnostic = new SemanticError(classy.Location, $"{subject} '{funcy.Name}' is not implemented");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException CanNotCreateInstanceOfAbstractClass(Decl.Classy classy, string subject)
        {
            var diagnostic = new SemanticError(classy.Location, $"can not create instance of {Names.Attr.Abstract} {subject} '{classy.Name}'");

            return new DiagnosticException(diagnostic);
        }
    }
}
