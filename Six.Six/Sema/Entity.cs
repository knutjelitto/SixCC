using A = Six.Six.Ast;

namespace Six.Six.Sema
{
    public interface Entity
    {
        Assoc Assoc { get; }       
    }

    public static class EntityExtensions
    {
        public static Container? Scope(this Entity entity)
        {
            return entity.Assoc.Scope;
        }

        public static WhiteMemberScope? WhiteScope(this Entity entity)
        {
            return entity.Assoc.Scope as WhiteMemberScope;
        }

        public static A.TreeNode Node(this Entity entity)
        {
            return entity.Assoc.Node;
        }
    }
}
