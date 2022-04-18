using Six.Six.Types;
using System;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public abstract class ResolverCore
    {
        protected ResolverCore(Module module, Resolver resolver)
        {
            Module = module;
            Resolver = resolver;
        }

        public Module Module { get; }
        public Resolver Resolver { get; }
        public Errors Errors => Module.Errors;
        public Builtins Builtins => Module.Builtins;
        public TypeChecker Checker => Module.Checker;

        public ExpressionResolver E => Resolver.E;
        public StatementResolver S => Resolver.S;
        public TypeResolver T => Resolver.T;
        public DeclarationResolver D => Resolver.D;
        public BodyResolver B => Resolver.B;
        public Members M => Resolver.M;
    }
}
