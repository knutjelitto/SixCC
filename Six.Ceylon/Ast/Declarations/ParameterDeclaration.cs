namespace Six.Ceylon.Ast
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ParameterDeclaration : Node, Declaration
    {
        public ParameterDeclaration(Parameter parameter)
        {
            Parameter = parameter;
        }

        public Parameter Parameter { get; }
    }
}
