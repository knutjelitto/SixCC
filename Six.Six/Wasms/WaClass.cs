using Six.Runtime;

namespace Six.Six.Wasms
{
    public sealed class WaClass : WithWriter, Wamber
    {
        public readonly WaConstString NameConst;
        public readonly WaRuntime RuntimeType;
        public readonly WaDispatches Dispatches;

        private readonly WaMemberFieldList MemberFields;
        private readonly WaStaticFieldList StaticFields;
        private readonly WaFunctionList Functions;
        private readonly WaClassList Classes;

        private readonly WaClassList Bases;
        private readonly WaClassList Interfaces;

        private WaClass(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;

            NameConst = module.AddString(Name);
            RuntimeType = module.AddType(new WaRuntime(this));
            Dispatches = module.AddDispatches(new WaDispatches(this));

            MemberFields = new WaMemberFieldList(this);
            StaticFields = new WaStaticFieldList(this);
            Functions = new WaFunctionList(this);
            Classes = new WaClassList(Module);
            
            Bases = new WaClassList(Module);
            Interfaces = new WaClassList(Module);
        }

        public static WaClass From(WaModule module, string name)
        {
            return module.NewClass(name, () => new WaClass(module, name));
        }

        public WaModule Module { get; }
        public string Name { get; }

        public uint FieldsSize => MemberFields.Size;

        public WaClass AddClass(WaClass innerClass)
        {
            Classes.Add(innerClass);

            return innerClass;
        }

        public WaFunction AddFunction(WaFunction function)
        {
            Functions.Add(function);

            return function;
        }

        public WaMemberField AddMemberField(WaMemberField field)
        {
            MemberFields.Add(field);

            return field;
        }

        public WaStaticField AddStaticField(WaStaticField field)
        {
            StaticFields.Add(field);

            return Module.AddStaticField(field);
        }

        public WaClass AddBaseClass(WaClass baseClass)
        {
            Assert(Bases.Count == 0);
            Bases.Add(baseClass);

            return baseClass;
        }

        public void Prepare()
        {
            Classes.Prepare();
            MemberFields.Prepare();
            Functions.Prepare();
        }

        public void Emit()
        {
            foreach (var inner in Classes)
            {
                inner.Emit();
                wl();
            }

            wl($"(; class {Name} ;)");
            indent(() =>
            {
                wl($"(; fields");
                indent(() =>
                {
                    foreach (var field in MemberFields.OfType<WaMemberField>())
                    {
                        wl($" +{field.Offset,-2} {field.Type,-4} {field.Name}");
                    }
                });
                wl($";)");
                wl($"(; functions");
                indent(() =>
                {
                    foreach (var function in Functions)
                    {
                        wl($"{function.Name} {function.Type?.Signature}");
                    }
                });
                wl($";)");
            });
            for (var i = 0; i < Functions.Count; i++)
            {
                wl();
                Functions[i].Emit();
            }
        }

        public override string ToString()
        {
            return $"class {Name}";
        }

        public void EmitDispatch()
        {

        }
    }
}
