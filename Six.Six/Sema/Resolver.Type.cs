using Six.Core;
using System;
using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    partial class Resolver
    {
        public void ResolveType(Container container, A.Type? typeNode)
        {
            if (typeNode == null)
            {
                return;
            }

            this[typeNode].Type = ResolveTypeIntern(container, typeNode);
        }

        private Type? ResolveTypeIntern(Container container, A.Type typeNode, bool asTuple = false)
        {
            switch (typeNode)
            {
                case A.Reference node:
                    {
                        return ResolveTypeReference(container, node);
                    }
                case A.Type.Nullable node:
                    {
                        var @null = ResolveInCore(node, Module.Core.Null);
                        var type = ResolveTypeIntern(container, node.Type);

                        if (@null != null && type != null)
                        {
                            return new Type.Union(@null, type);
                        }
                        return null;
                    }
                case A.Type.Intersection node:
                    {
                        var types = ResolveMany(container, node);

                        if (types != null)
                        {
                            return new Type.Intersection(types.ToArray());
                        }

                        Didnt(node, "intersection");
                        return null;
                    }
                case A.Type.Union node:
                    {
                        var types = ResolveMany(container, node);

                        if (types != null)
                        {
                            return new Type.Union(types.ToArray());
                        }

                        Didnt(node, "union");
                        return null;
                    }
                case A.Type.Constructor node:
                    {
                        var type = ResolveTypeIntern(container, node.Type);

                        if (type != null)
                        {
                            return type;
                        }
                        return null;
                    }
                case A.Type.Nothing:
                    {
                        return new Type.Nothing();
                    }
                default:
                    Assert(false);
                    throw new NotImplementedException();
            }
        }

        private Reference ResolveInCore(A.TreeNode node, string name)
        {
            var found = Module.CoreFind(name)
                ?? throw Diagnostic(node, $"can't resolve core type `{name}´");

            var type = this[found].Type
                ?? throw NoTypeYet(node, name);

            return new Reference(Assoc.From(this, found), type, found);
        }
    }
}
