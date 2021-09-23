namespace Six.Ceylon.Ast
{
    public sealed class ObjectExpression : Node, Expression
    {
        public ObjectExpression(ObjectInheritance inheritance, Definition body)
        {
            Inheritance = inheritance;
            Body = body;
        }

        public ObjectInheritance Inheritance { get; }
        public Definition Body { get; }
    }
}
