using Six.Six.Sema;
using Six.Six.Types;
using Six.Six.Wasms;
using Six.Six.Wasms.Instructions;

using Type = Six.Six.Sema.Type;

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0051 // Remove unused private members

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

            DefineModuleCtor();
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


        public void DefineModuleCtor()
        {
            Instructeur.CreateModuleCtor(Module.ModuleCtor);
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

        private WaFunction CreateGetClass(Decl.Classy decl)
        {
            var name = $"{decl.FullName}.{Sema.Module.GetClass}";

            var function = WaFunction.From(Module, name);

            var type = Instructeur.Lower(Module.SemaModule.Builtins.Address).Wasm;

            function.AddResult(new WaResult(type));

            Instructeur.CreateGetClass(function, decl);

            return function;
        }

        private WaClass CreateClass(Decl.Classy decl)
        {
            var clazz = WaClass.From(Module, decl.FullName);

            clazz.AddFunction(CreateGetClass(decl));

            if (decl is Decl.Class klass)
            {
                if (!klass.IsNative)
                {
                    clazz.AddFunction(CreateInitCtor(decl));
                }
#if false
                var needDefaultCtor = decl.Members.Functions.All(f => f.Name != Sema.Module.DefaultCtor);

                if (needDefaultCtor)
                {
                    var function = CreateDefaultCtor(klass);

                    clazz.AddFunction(function);
                }
#endif
            }

            if (decl.Extends != null)
            {
                clazz.AddBaseClass(WaClass.From(Module, decl.Extends.FullName));
            }

            foreach (var innerClass in decl.Members.Classes)
            {
                var inner = CreateClass(innerClass);

                clazz.AddClass(inner);
            }


            foreach (var field in decl.Fields.Where(f => f.IsStatic))
            {
                var staticField = clazz.AddStaticField(new WaStaticField(clazz, field.StaticName, Instructeur.Lower(field.Type).Wasm));
                Instructeur.Walk(staticField.Instructions, field.Value);
            }

            foreach (var field in decl.Layout.MemberFields)
            {
                clazz.AddMemberField(new WaMemberField(clazz, field.Name, field.Offset, field.Size, Instructeur.Lower(field.Type).Wasm));
            }

            foreach (var funcy in decl.Members.Functions)
            {
                var function = CreateFunction(funcy);

                clazz.AddFunction(function);
            }

            CreateClassDispatch(clazz, decl);

            return clazz;
        }

        private void CreateClassDispatch(WaClass clazz, Decl.Classy decl)
        {
            foreach (var slot in decl.Layout.Slots)
            {
                clazz.Dispatches.Add(new WaDispatch(clazz, slot.FullName));
            }
        }
    }
}
