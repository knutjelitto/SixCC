using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public class Assoc
    {
        public Assoc(Resolver resolver, A.TreeNode node)
        {
            Resolver = resolver;
            Node = node;
        }

        public static Assoc From(Resolver resolver, A.TreeNode node)
        {
            return resolver[node];
        }

        public Resolver Resolver { get; }
        public A.TreeNode Node { get; }
        public Container? Scope { get; set; }
        public Type? Type { get; set; }
        public Expression? Expr { get; set; }

        public Type? ResolvedType()
        {
            if (Type is Type.Reference reference)
            {
                return Resolver[reference.Decl].ResolvedType();
            }
            else if (Type is Type.Alias alias)
            {
                Assert(alias.Assoc.Node is A.Decl.Alias);
                if (alias.Assoc.Node is A.Decl.Alias aliasNode)
                {
                    return Resolver[aliasNode.Type].ResolvedType();
                }
            }
            return Type;
        }
    }
}
