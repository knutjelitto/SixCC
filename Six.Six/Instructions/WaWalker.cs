using Six.Six.Sema;
using Six.Six.Wasms;

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
            var clazz = CreateClassy(classy);

            Module.Add(clazz);
        }

        public WaFunction CreateFunction(Decl.Funcy funcy)
        {
            var function = new WaFunction(Module, funcy.FullName);

            foreach (var param in funcy.Parameters.Cast<Decl.Local>())
            {
                var type = Emitter.Lower(param.Type).Wasm;

                function.Add(new WaParameter(function, param.Name, type));
            }

            if (funcy.Resolver.ResolveType(funcy.ResultType) is not Type.Void)
            {
                function.Add(new WaResult(Emitter.Lower(funcy.ResultType).Wasm));
            }

            return function;
        }

        private WaClassy CreateClassy(Decl.Classy classy)
        {
            var clazz = NewClassy((dynamic)classy);

            foreach (var x in classy.Block.Members.OfType<Decl.Funcy>())
            {
                var function = CreateFunction(x);

                clazz.Add(function);
            }

            return clazz;
        }

        private WaClassy NewClassy(Decl.Class decl)
        {
            return new WaClass(Module, decl.FullName);
        }

        private WaClassy NewClassy(Decl.Interface decl)
        {
            return new WaInterface(Module, decl.FullName);
        }

        private WaClassy NewClassy(Decl.Object decl)
        {
            return new WaObject(Module, decl.FullName);
        }
    }
}
