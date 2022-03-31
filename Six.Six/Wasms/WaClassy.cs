using Six.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Wasms
{
    public abstract class WaClassy : WithWriter
    {
        protected readonly WaFieldList Fields;
        protected readonly WaFunctionList Functions;

        protected WaClassy(WaModule module, string name)
            : base(module.Writer)
        {
            Module = module;
            Name = name;
            Fields = new WaFieldList(this);
            Functions = new WaFunctionList();
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
            foreach (var function in Functions)
            {
                function.Prepare();
            }
        }

        public void Emit()
        {
            foreach (var function in Functions)
            {
                wl();
                function.Emit();
            }
        }
    }

    public sealed class WaClass : WaClassy
    {
        public WaClass(WaModule module, string name)
            : base(module, name)
        {
        }
    }

    public sealed class WaInterface : WaClassy
    {
        public WaInterface(WaModule module, string name)
            : base(module, name)
        {
        }
    }

    public sealed class WaObject : WaClassy
    {
        public WaObject(WaModule module, string name)
            : base(module, name)
        {
        }
    }
}
