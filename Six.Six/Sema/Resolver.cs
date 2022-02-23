using Six.Core;
using Six.Core.Errors;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public sealed partial class Resolver
    {
        public Resolver(Module global)
        {
            Module = global;
        }

        public Module Module { get; }
    }
}
