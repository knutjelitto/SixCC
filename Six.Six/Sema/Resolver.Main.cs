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
        public Resolver(Module global)
        {
            Module = global;
        }

        public Module Module { get; }

        public Builtins.Builtins Builtins => Module.Builtins;

        public void Walk(A.Unit.Code code)
        {
            CodeUnit(code);
        }

        private void CodeUnit(A.Unit.Code code)
        {
            var @namespace = Module.Open(code.Namespace);

            WalkDeclarations(@namespace, code.Declarations);
        }
    }
}
