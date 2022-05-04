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

        private readonly WaFunctionList Initializers;
        private readonly WaFunctionList Functions;
        private readonly WaClassList Classes;

        private readonly WaGlobalList Globals;
        private readonly WaStringData StringData;
        public readonly WaStaticData StaticData;
        private readonly WaRuntimeData RuntimeData;
        public readonly WaFunctionTable GlobalFunctionTable;
        public readonly WaDispatchTable DispatchTable;
        public readonly WaFunctionTypeList FunctionTypes;

        private readonly Dictionary<string, WaFunction> FunctionIndex;
        private readonly Dictionary<string, WaClass> ClassIndex;

        public WaModule(Module semaModule, string metaClassName, string stringClassName) : base(new Writer())
        {
            SemaModule = semaModule;

            Initializers = new(this);
            Functions = new(this);
            Classes = new(this);

            Globals = new WaGlobalList(this);
            StringData = new(this, Module.DataAndHeapMemory);
            StaticData = new(this, Module.DataAndHeapMemory);
            RuntimeData = new WaRuntimeData(this, Module.DataAndHeapMemory);
            GlobalFunctionTable = new WaFunctionTable(this, GlobalFunctionsTableName);
            DispatchTable = new WaDispatchTable(this, Module.DispatchTableName);
            FunctionTypes = new(this);
            
            FunctionIndex = new();
            ClassIndex = new();

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

        public WaFunction AddInitializer(WaFunction function)
        {
            Initializers.Add(function);

            return function;
        }

        public WaClass AddClass(WaClass clazz)
        {
            Classes.Add(clazz);

            return clazz;
        }

        public WaRuntime AddType(WaRuntime type)
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
            Initializers.Prepare();
            StringData.BaseOffset = DataStart;
            StringData.Prepare();
            StaticData.BaseOffset = DataStart + StringData.Size;
            StaticData.Prepare();
            RuntimeData.BaseOffset = DataStart + StringData.Size + StaticData.Size;
            RuntimeData.Prepare();
            GlobalFunctionTable.Prepare();
            DispatchTable.Prepare();
            FunctionTypes.Prepare();
        }

        public void Emit()
        {
            wl("(module");
            indent(() =>
            {
                Assert(Initializers.Count == 1);
                var initializer = Initializers.Single();

                wl($"(start ${initializer.Name})");
                wl();
                EmitImports();
                wl();
                wl($"(memory ${Module.DataAndHeapMemory} (export \"{Module.DataAndHeapMemory}\") 16 16)");
                wl();
                StringData.Emit();
                wl();
                StaticData.Emit();
                wl();
                RuntimeData.Emit();
                wl();
                DispatchTable.Emit();
                wl();
                FunctionTypes.Emit();
                wl();
                GlobalFunctionTable.Emit();
                wl();
                Globals.Emit();
                wl();
                initializer.Emit();
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
                wl($"(local {WasmType.Addr})");
                wl($"(local {WasmType.I32})");
                wl("(;-----;)");
                emit(Insn.Local.Get(0));                        // [clazz]
                emit(Insn.U32.Load(WaRef.PayloadOffset + 4));   // [payload-size]
                emit(Insn.Local.Tee(2));                        // [payload-size]
                emit(Insn.U32.Const(WaRef.HeaderSize));         // [payload-size header-size]
                emit(Insn.U32.Add);                             // [alloc-size]
                emit(Insn.Call(Module.CoreAlloc));              // [object]
                emit(Insn.Local.Tee(1));                        // [object]
                emit(Insn.S32.Const(-1));                       // [object -1]
                emit(Insn.U32.Store(WaRef.OffsetOfDummy));      // [] object.dummy = -1
                emit(Insn.Local.Get(1));                        // [object]
                emit(Insn.Local.Get(0));                        // [object clazz]
                emit(Insn.U32.Store(WaRef.OffsetOfClass));      // [] object.clazz = clazz
                emit(Insn.Local.Get(1));                        // [object]
                emit(Insn.Local.Get(0));                        // [object clazz]
                emit(Insn.U32.Load(WaRef.PayloadOffset + 8));   // [object clazz.dispatch]
                emit(Insn.U32.Store(WaRef.OffsetOfDispatch));   // [] object.dispatch = clazz.dispatch
                emit(Insn.Local.Get(1));                        // [object]
                emit(Insn.Local.Get(2));                        // [object payload-size]
                emit(Insn.U32.Store(WaRef.OffsetOfSize));       // [] object.dispatch = clazz.dispatch
                emit(Insn.Local.Get(1));                        // [object]
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
