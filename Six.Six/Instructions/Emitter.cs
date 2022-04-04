using System;

using Six.Core;
using Six.Runtime;
using Six.Six.Sema;
using Six.Six.Types;
using Six.Six.Wasms;
using W = Six.Six.Wasms;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Six.Six.Instructions
{
    public partial class Emitter : WithWriter
    {
        public const string globalFunctionsTableName = "functionsTable";

        private readonly List<string> exports = new();

        private readonly List<Decl.Global> globals = new();
        private readonly Stack<Block> insns = new();
        public readonly WaModule WaModule;
        public readonly WaWalker WaWalker;

        public Emitter(Module module)
            : base(new Writer())
        {
            Module = module;
            WaModule = new WaModule(module, Module.MetaClassName, Module.StringClassName);
            WaWalker = new WaWalker(WaModule, this);
        }

        public Module Module { get; }
        public Resolver Resolver => Module.Resolver;
        public Builtins Builtins => Module.Builtins;
    }
}
