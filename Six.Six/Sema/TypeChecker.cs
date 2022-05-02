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

            if (toType is Decl.Classy toClassy)
            {
                if (fromType is Decl.Classy fromClassy)
                {
                    if (toClassy is Decl.Interface iface)
                    {
                        if (fromClassy is Decl.Class clazz)
                        {
                            foreach (var x in clazz.Layout.Interfaces)
                            {
                                if (ReferenceEquals(iface, x.Iface))
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
                    else
                    {
                        return CanAssign(toClassy, fromClassy);
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
            else if (toType is Type.Builtin toBuiltin)
            {
                if (fromType is Decl.Classy fromRef)
                {
                    return CanAssign(toType, fromRef.Decl.Type);
                }

                Assert(false);
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
