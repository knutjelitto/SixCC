using Six.Core;
using Six.Runtime;
using Six.Six.Instructions;
using Six.Six.Sema;
using System;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Wasms
{
    public class WaModule : WithWriter
    {
        public static string GlobalFunctionsTableName => Module.ModuleFunctionsTableName;

        private readonly WaFunctionList Functions;
        private readonly WaClassList Classes;
        private readonly Dictionary<string, WaFunction> FunctionIndex;
        private readonly Dictionary<string, WaClass> ClassIndex;


        private readonly WaGlobalList Globals;
        private readonly WaStringData StringData;
        public readonly WaStaticData StaticData;
        private readonly WaRuntimeData RuntimeData;
        public readonly WaFunctionTable GlobalFunctionTable;
        public readonly WaDispatchTable DispatchTable;
        public readonly WaFunctionTypeList FunctionTypes;

        public readonly WaFunction ModuleCtor;

        public uint NextObjectId = 1;

        public WaModule(Module semaModule, string metaClassName, string stringClassName) : base(new Writer())
        {
            SemaModule = semaModule;

            Functions = new(this);
            Classes = new(this);

            FunctionIndex = new();
            ClassIndex = new();

            ModuleCtor = WaFunction.From(this, $"{Sema.Module.CoreNamespace}.{Sema.Module.ModuleCtor}");

            Globals = new WaGlobalList(this);
            StringData = new(this, Module.LinearMemory);
            StaticData = new(this, Module.LinearMemory);
            RuntimeData = new WaRuntimeData(this, Module.LinearMemory);
            GlobalFunctionTable = new WaFunctionTable(this, GlobalFunctionsTableName);
            DispatchTable = new WaDispatchTable(this, Module.DispatchTableName);
            FunctionTypes = new(this);

            MetaClass = WaClass.From(this, metaClassName);
            StringClass = WaClass.From(this, stringClassName);
        }

        public Module SemaModule { get; }
        public WaClass MetaClass { get; }
        public WaClass StringClass { get; }

        public uint DataStart => 0;
        public uint HeapStart => 
            DataStart +     
            StringData.Size +
            StaticData.Size +
            RuntimeData.Size;

        public WaClass NewClass(string name, Func<WaClass> createClass)
        {
            if (!ClassIndex.TryGetValue(name, out var clazz))
            {
                clazz = createClass();
                ClassIndex.Add(name, clazz);
            }
            return clazz;
        }

        public WaClass FindClass(string name)
        {
            return ClassIndex[name];
        }

        public WaFunction NewFunction(string name, Func<WaFunction> createFunction)
        {
            if (!FunctionIndex.TryGetValue(name, out var function))
            {
                function = createFunction();
                FunctionIndex.Add(name, function);
            }
            return function;
        }

        public WaFunction FindFunction(string name)
        {
            return FunctionIndex[name];
        }

        public WaFunction AddFunction(WaFunction function)
        {
            Functions.Add(function);

            return function;
        }

        public WaClass AddClass(WaClass clazz)
        {
            Classes.Add(clazz);

            return clazz;
        }

        public WaRunType AddType(WaRunType type)
        {
            RuntimeData.Add(type);

            return type;
        }

        public WaDispatches AddDispatches(WaDispatches type)
        {
            DispatchTable.Add(type);

            return type;
        }

        public WaGlobal AddGlobal(WaGlobal global)
        {
            Globals.Add(global);

            return global;
        }

        public WaConstString AddString(string text)
        {
            return StringData.Add(text);
        }

        public WaStaticField AddStaticField(WaStaticField field)
        {
            StaticData.Add(field);

            return field;
        }

        public WaStaticField FindStaticField(string name)
        {
            return StaticData.Where(f => f.Name == name).First();
        }

        public void Prepare()
        {
            foreach (var function in Functions)
            {
                function.Prepare();
            }

            foreach (var classy in Classes)
            {
                classy.Prepare();
            }

            Globals.Prepare();
            StringData.BaseOffset = DataStart;
            StringData.Prepare();
            StaticData.BaseOffset = DataStart + StringData.Size;
            StaticData.Prepare();
            RuntimeData.BaseOffset = DataStart + StringData.Size + StaticData.Size;
            RuntimeData.Prepare();
            ModuleCtor.Prepare();
            GlobalFunctionTable.Prepare();
            DispatchTable.Prepare();
            FunctionTypes.Prepare();
        }

        public void Emit()
        {
            wl("(module");
            indent(() =>
            {
                wl($"(start ${ModuleCtor.Name})");
                wl();
                EmitImports();
                wl();
                wl($"(memory ${Module.LinearMemory} (export \"{Module.LinearMemory}\") 16 16)");
                wl();
                StaticData.Emit();
                wl();
                Globals.Emit();
                wl();
                StringData.Emit();
                wl();
                RuntimeData.Emit();
                wl();
                DispatchTable.Emit();
                wl();
                FunctionTypes.Emit();
                wl();
                GlobalFunctionTable.Emit();
                wl();
                ModuleCtor.Emit();
                wl();
                EmitClassAlloc();
                wl();
                for (var i = 0; i < Functions.Count; i++)
                {
                    if (i > 0) wl();
                    Functions[i].Emit();
                }
                wl();

                for (var i = 0; i < Classes.Count; i++)
                {
                    if (i > 0) wl();
                    Classes[i].Emit();
                }
            });
            wl(")");
        }

        private void EmitImports()
        {
            wl($"(import \"six.core.RT\" \"Print\" (func $six.core.RT.Print (param i32) (result)))");
        }

        private void EmitClassAlloc()
        {
            wl($"(func ${Module.CoreClassAlloc}");
            indent(() =>
            {
                wl($"(export \"{Module.CoreClassAlloc}\")");
                wl($"(param {WasmType.Addr})");
                wl($"(result {WasmType.Addr})");
                wl($"(local {WasmType.Addr} {WasmType.I32})");
                wl("(;-----;)");
                emit(Insn.Local.Get(0));                        // [class-object]
                emit(Insn.U32.Load(WaRef.ObjectOffset + 4));    // [payload-size]
                emit(Insn.Local.Tee(2));                        // [payload-size]
                emit(Insn.U32.Const(WaRef.HeaderSize));         // [payload-size header-size]
                emit(Insn.U32.Add);                             // [alloc-size]
                emit(Insn.Call(Module.CoreAlloc));              // [header]
                emit(Insn.Local.Tee(1));                        // [header]
                emit(Insn.S32.Const(-1));                       // [header -1]
                emit(Insn.U32.Store(WaRef.Head.Heap));         // [] header.dummy = -1
                emit(Insn.Local.Get(1));                        // [header]
                emit(Insn.Local.Get(0));                        // [header class]
                emit(Insn.U32.Store(WaRef.Head.ObjectId));         // [] header.class = clazz
                emit(Insn.Local.Get(1));                        // [header]
                emit(Insn.Local.Get(0));                        // [header class-object]
                emit(Insn.U32.Load(WaRef.ObjectOffset + 8));    // [header dispatch]
                emit(Insn.U32.Store(WaRef.Head.Dispatch));      // [] object.dispatch = dispatch
                emit(Insn.Local.Get(1));                        // [header]
                emit(Insn.Local.Get(2));                        // [header payload-size]
                emit(Insn.U32.Store(WaRef.Head.Size));          // [] header.size = payload-size
                emit(Insn.Local.Get(1));                        // [header]
                emit(Insn.U32.Const(WaRef.HeaderSize));         //
                emit(Insn.U32.Add);                             //
                emit(Insn.Return);
                wl("(;-----;)");
            });
            wl($")");

            void emit(Insn insn)
            {
                wl($"{insn}");
            }
        }

    }
}
