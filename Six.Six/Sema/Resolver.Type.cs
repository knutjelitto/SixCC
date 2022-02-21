using Six.Core;
using Six.Core.Errors;
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

            try
            {
                this[typeNode].Type = ResolveTypeIntern(container, typeNode);
            }
            catch (DiagnosticException diagnostics)
            {
                foreach (var diagnostic in diagnostics.Diagnostics)
                {
                    Module.Add(diagnostic);
                }
            }
            catch (InvalidProgramException)
            {
                throw;
            }
            catch (Exception)
            {
                Didnt(typeNode, typeNode.GetType().Name);
            }
        }

        private Type ResolveTypeIntern(Container container, A.Type typeNode, bool asTuple = false)
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

                        return new Type.Union(@null, type);
                    }
                case A.Type.Intersection node:
                    {
                        var types = ResolveMany(container, node);
                        return new Type.Intersection(types);
                    }
                case A.Type.Union node:
                    {
                        var types = ResolveMany(container, node);
                        return new Type.Union(types);
                    }
                case A.Type.Constructor node:
                    {
                        return ResolveTypeIntern(container, node.Type);
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
