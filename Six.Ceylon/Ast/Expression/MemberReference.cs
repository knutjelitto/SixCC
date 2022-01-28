﻿namespace Six.Ceylon.Ast
{
    public class MemberReference : IExpression
    {
        public MemberReference(Identifier name, TypeArgumentList arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public TypeArgumentList Arguments { get; }
    }
}
