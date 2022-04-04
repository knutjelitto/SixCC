using Six.Six.Sema;
using Six.Six.Types;
using System;
using Type = Six.Six.Sema.Type;

#pragma warning disable CA1822 // Mark members as static

namespace Six.Six.Instructions
{
    public partial class Emitter
    {
        public Builtin Lower(Type type)
        {
            var lower = Resolver.LowerType(type);

            switch (lower)
            {
                case Builtin builtin:
                    return builtin;
                case Type.ClassReference:
                    return Builtins.Pointer;
                case Type.InterfaceReference:
                    return Builtins.Pointer;
                case Type.Callable:
                    return Builtins.TableIndex;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        public Builtin BuiltinFor(Type type)
        {
            switch (Resolver.LowerType(type))
            {
                case Builtin builtin:
                    return builtin;
                case Type.Callable:
                    return Builtins.TableIndex;
                case Type.Declared declared when declared.Decl.IsNative:
                    return Builtins.Resolve(declared.Decl);
                case Type.Declared declared when declared.Decl is Decl.Classy:
                    return Builtins.Pointer;
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }
    }
}
