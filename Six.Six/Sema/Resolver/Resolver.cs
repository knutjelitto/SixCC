using Six.Six.Instructions;
using Six.Six.Types;
using A = Six.Six.Ast;

#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace Six.Six.Sema
{
    public class Resolver
    {
        public Resolver(Module module)
        {
            Module = module;
            D = new DeclarationResolver(module, this);
            E = new ExpressionResolver(module, this);
            S = new StatementResolver(module, this);
            T = new TypeResolver(module, this);
            B = new BodyResolver(module, this);
            M = new Members();
        }

        public Module Module { get; }

        public DeclarationResolver D { get; }
        public ExpressionResolver E { get; }
        public StatementResolver S { get; }
        public TypeResolver T { get; }
        public BodyResolver B { get; }
        public Members M { get; }

        public void Walk(A.Unit.Code code)
        {
            CodeUnit(code);
        }

        private void CodeUnit(A.Unit.Code code)
        {
            var namespaceBlock = Module.OpenNamespace(code.Namespace);

            foreach (var declaration in code.Declarations)
            {
                D.WalkDeclaration(namespaceBlock, declaration);
            }
        }
    }
}
