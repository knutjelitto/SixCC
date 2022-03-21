﻿using Six.Core;
using Six.Core.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = Six.Six.Ast;

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
            var diagnostic1 = new SemanticError(named.GetLocation(), $"identifier '{named.Name}' already introduced elsewhere");
            var diagnostic2 = new SemanticError(already.GetLocation(), $"identifier '{already.Name}' introduced here");

            return new DiagnosticException(diagnostic1, diagnostic2);
        }

        public DiagnosticException CantResolve(A.TreeNode tree, string name)
        {
            var diagnostic = new SemanticError(tree.GetLocation(), $"the name '{name}' doesn't exist in the current context");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException CantResolveInCore(string what, string name)
        {
            var diagnostic = new InternalError($"can't resolve {what} ``{name}´´ in ``{Module.CoreNamespace}´´");

            return new DiagnosticException(diagnostic);
        }

        public DiagnosticException TypeMismatch(A.TreeNode tree, Type expected, Type actual)
        {
            return TypeMismatch(tree.GetLocation(), expected, actual);
        }

        public DiagnosticException TypeMismatch(ILocation location, Type expected, Type actual)
        {
            var diagnostic = new SemanticError(location, $"expected type ``{expected}´´ but found ``{actual}´´");

            return new DiagnosticException(diagnostic);
        }

    }
}
