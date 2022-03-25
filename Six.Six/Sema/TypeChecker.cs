using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Six.Sema
{
    public class TypeChecker
    {
        public TypeChecker(Module module)
        {
            Module = module;
        }

        public Module Module { get; }

        public bool CanAssign(Type toType, Type fromType)
        {
            if (ReferenceEquals(toType, fromType))
            {
                return true;
            }

            if (toType is Type.Reference toRef && fromType is Type.Reference fromRef)
            {
                Assert(toRef.Decl is Typy && fromRef.Decl is Typy);

                if (ReferenceEquals(toRef.Decl, fromRef.Decl))
                {
                    return true;
                }

                if (toRef.Decl is Decl.Interface iface)
                {
                    if (fromRef.Decl is Decl.Class clazz)
                    {
                        foreach (var x in clazz.Layout.InterFaces)
                        {
                            if (ReferenceEquals(iface, x.Interface))
                            {
                                return true;
                            }
                        }
                        Assert(false);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else if (toRef.Decl is Decl.Classy toClass)
                {
                    if (fromRef.Decl is Decl.Classy fromClass)
                    {
                        return CanAssign(toClass, fromClass);
                    }
                    else
                    {
                        Assert(false);
                    }
                }
                else
                {
                    Assert(false);
                }
            }
            else
            {
                Assert(false);
            }

            return false;
        }

        private bool CanAssign(Decl.Classy toClass, Decl.Classy fromClass)
        {
            if (ReferenceEquals(toClass, fromClass))
            {
                return true;
            }
            if (fromClass.Extends != null)
            {
                return CanAssign(toClass, fromClass.Extends);
            }
            return false;
        }
    }
}
