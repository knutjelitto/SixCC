using Six.Six.Sema;
using Six.Six.Wasms;
using Six.Six.Wasms.Instructions;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Instructions
{
    public class WaWalker
    {
        public WaWalker(WaModule module, Emitter emitter)
        {
            Module = module;
            Emitter = emitter;
        }

        public WaModule Module { get; }
        public Emitter Emitter { get; }

        public void Add(Decl.Funcy funcy)
        {
            var function = CreateFunction(funcy);

            Module.Add(function);
        }

        public void Add(Decl.Classy classy)
        {
            var clazz = CreateClass(classy);

            Module.Add(clazz);
        }

        public WaFunction CreateFunction(Decl.Funcy funcy)
        {
            var function = WaFunction.From(Module, funcy.FullName);

            foreach (var inner in funcy.InnerFunctions())
            {
                var innerFunction = CreateFunction(inner);

                function.Add(innerFunction);
            }

            foreach (var param in funcy.Parameters.Cast<Decl.Local>())
            {
                var type = Emitter.Lower(param.Type).Wasm;

                function.Add(new WaParameter(function, param.Name, type));
            }

            foreach (var local in funcy.Locals)
            {
                var type = Emitter.Lower(local.Type).Wasm;

                function.Add(new WaLocal(function, local.Name, type));
            }

            if (funcy.Resolver.ResolveType(funcy.ResultType) is not Type.Void)
            {
                var type = Emitter.Lower(funcy.ResultType).Wasm;

                function.Add(new WaResult(type));
            }

            if (!funcy.HasBody)
            {
                function.Add(new WiInsn(function, Insn.Unreachable));
            }
            else
            {
                var instructeur = new WaInstructeur(Module, funcy, function);

                instructeur.Walk();
            }

            return function;
        }

        private WaClass CreateClass(Decl.Classy decl)
        {
            var clazz = WaClass.From(Module, decl.FullName);

            var count = 0;

            foreach (var field in decl.Block.Members.OfType<Decl.Field>())
            {
                clazz.Add(new WaField(field.Name, Emitter.Lower(field.Type).Wasm));

                count += 1;
            }

            foreach (var x in decl.Block.Members.OfType<Decl.Funcy>())
            {
                var function = CreateFunction(x);

                clazz.Add(function);

                count += 1;
            }

            Assert(count == decl.Block.Members.Count);

            return clazz;
        }
    }
}
