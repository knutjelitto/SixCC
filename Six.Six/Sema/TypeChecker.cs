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

        public bool Distinct(Type type1, Type type2)
        {
            return !CanAssign(type1, type2) && !CanAssign(type2, type1);
        }

        public bool CanAssign(Type toType, Type fromType)
        {
            if (ReferenceEquals(toType, fromType))
            {
                return true;
            }

            if (toType is Type.Reference toRef)
            {
                if (fromType is Type.Reference fromRef)
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
                            return false;
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
                if (fromType is Type.Intersection isection)
                {
                    return isection.Any(from => CanAssign(toType, from));
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
