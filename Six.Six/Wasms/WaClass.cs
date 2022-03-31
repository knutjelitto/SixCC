using Six.Runtime;

namespace Six.Six.Wasms
{
    public sealed class WaClass : WithWriter, Wamber
    {
        private readonly WaFieldList Fields;
        private readonly WaFunctionList Functions;

        private WaClass(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
            Fields = new WaFieldList(this);
            Functions = new WaFunctionList();
        }

        public static WaClass From(WaModule module, string name)
        {
            if (!module.ClassIndex.TryGetValue(name, out var clazz))
            {
                clazz = new WaClass(module, name);
                module.ClassIndex.Add(name, clazz);
            }
            return clazz;
        }

        public WaModule Module { get; }
        public string Name { get; }

        public WaFunction Add(WaFunction function)
        {
            Functions.Add(function);

            return function;
        }

        public WaField Add(WaField field)
        {
            Fields.Add(field);

            return field;
        }

        public void Prepare()
        {
            Fields.Prepare();
            Functions.Prepare();
        }

        public void Emit()
        {
            wl($"(; structure {Name} ;)");
            indent(() =>
            {
                wl($"(; fields");
                indent(() =>
                {
                    foreach (var field in Fields)
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
    }
}
