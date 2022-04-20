using Six.Six.Sema;
using Six.Six.Wasms;
using Six.Six.Wasms.Instructions;
using System;
using Type = Six.Six.Sema.Type;

namespace Six.Six.Instructions
{
    public class WaWalker
    {
        public WaWalker(WaModule module)
        {
            Module = module;
            Instructeur = new WaInstructeur(Module);
        }

        public WaModule Module { get; }
        public WaInstructeur Instructeur { get; }

        public void Walk()
        {
            foreach (var global in Module.SemaModule.GetGlobals())
            {
                AddGlobal(global);
            }

            foreach (var function in Module.SemaModule.GetFunctions())
            {
                AddFunction(function);
            }

            foreach (var classy in Module.SemaModule.GetClassies())
            {
                AddClass(classy);
            }

            AddModuleInitializer();
        }

        public void AddGlobal(Decl.Global glob)
        {
            var global = CreateGlobal(glob);

            Module.AddGlobal(global);
        }

        public void AddFunction(Decl.Funcy funcy)
        {
            var function = CreateFunction(funcy);

            Module.AddFunction(function);
        }

        public void AddClass(Decl.Classy classy)
        {
            var clazz = CreateClass(classy);

            Module.AddClass(clazz);
        }

        public void AddModuleInitializer()
        {
            var name = $"{Sema.Module.CoreNamespace}.{Sema.Module.ModuleCtor}";

            var function = WaFunction.From(Module, name);

            Instructeur.CreateModuleCtor(function);

            Module.AddInitializer(function);
        }

        private WaGlobal CreateGlobal(Decl.Global decl)
        {
            var type = Instructeur.Lower(decl.Type).Wasm;
            var instructions = new WaInstructionList(Module);
            Instructeur.Walk(instructions, decl.Value);

            var global = new WaGlobal(Module, decl.Writeable, decl.FullName, type, instructions);
            
            return global;
        }

        private WaFunction CreateFunction(Decl.Funcy funcy)
        {
            var function = WaFunction.From(Module, funcy.FullName);

            foreach (var inner in funcy.InnerFunctions())
            {
                var innerFunction = CreateFunction(inner);

                function.AddLocal(innerFunction);
            }

            foreach (var param in funcy.Parameters)
            {
                var type = Instructeur.Lower(param.Type).Wasm;

                function.AddParameter(new WaParameter(function, param.Name, type));
            }

            foreach (var local in funcy.Locals)
            {
                var type = Instructeur.Lower(local.Type).Wasm;

                function.AddLocal(new WaLocal(function, local.Name, type));
            }

            if (funcy.ResultType is not Type.Void)
            {
                var type = Instructeur.Lower(funcy.ResultType).Wasm;

                function.AddResult(new WaResult(type));
            }

            if (!funcy.HasBody)
            {
                function.AddInstruction(new WiInsn(function, Insn.Unreachable));
            }
            else
            {
                Instructeur.Walk(function, funcy);
            }

            return function;
        }

        private WaFunction CreateInitCtor(Decl.Classy decl)
        {
            var name = $"{decl.FullName}.{Sema.Module.InitCtor}";

            var function = WaFunction.From(Module, name);

            var type = Instructeur.Lower(decl.Type).Wasm;

            function.AddParameter(new WaParameter(function, Names.Core.SelfValue, type));

            Instructeur.CreateInitCtor(function, decl);

            return function;
        }

        private WaFunction CreateDefaultCtor(Decl.Classy decl)
        {
            var name = $"{decl.FullName}.{Sema.Module.DefaultCtor}";

            var function = WaFunction.From(Module, name);

            var type = Instructeur.Lower(decl.Type).Wasm;

            function.AddParameter(new WaParameter(function, Names.Core.SelfValue, type));
            function.AddResult(new WaResult(type));

            Instructeur.CreateDefaultCtor(function, decl);

            return function;
        }

        private WaClass CreateClass(Decl.Classy decl)
        {
            var clazz = WaClass.From(Module, decl.FullName);

            if (decl.Extends != null)
            {
                clazz.AddBaseClass(WaClass.From(Module, decl.Extends.FullName));
            }

            var count = 0;

            foreach (var innerClass in decl.Members.Classes)
            {
                var inner = CreateClass(innerClass);

                clazz.AddClass(inner);

                count++;
            }

            foreach (var field in decl.Fields)
            {
                if (field.IsStatic)
                {
                    var staticField = clazz.AddStaticField(new WaStaticField(clazz, field.StaticName, Instructeur.Lower(field.Type).Wasm));
                    Instructeur.Walk(staticField.Instructions, field.Value);
                }
                else
                {
                    clazz.AddMemberField(new WaMemberField(clazz, field.Name, Instructeur.Lower(field.Type).Wasm));
                }
            }

            if (decl is Decl.Class klass)
            {
                if (!klass.IsNative)
                {
                    var function = CreateInitCtor(klass);

                    clazz.AddFunction(function);
                }
#if false
                var needDefaultCtor = decl.Block.Members.OfType<Decl.Funcy>().All(f => f.Name != Sema.Module.DefaultCtor);

                if (needDefaultCtor)
                {
                    var function = CreateDefaultCtor(klass);

                    clazz.Add(function);
                }
#endif
            }

            foreach (var funcy in decl.Members.Functions)
            {
                var function = CreateFunction(funcy);

                clazz.AddFunction(function);

                count++;
            }

            CreateClassDispatch(clazz, decl);

            return clazz;
        }

        private void CreateClassDispatch(WaClass clazz, Decl.Classy decl)
        {
            foreach (var slot in decl.Layout.Slots)
            {
                clazz.Dispatches.Add(new WaDispatch(clazz, slot.Funcy.FullName));
            }
        }
    }
}
