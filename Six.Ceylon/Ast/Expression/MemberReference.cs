using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class MemberReference : IExpression
    {
        public MemberReference(Identifier name, TypeArguments? arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        public Identifier Name { get; }
        public TypeArguments? Arguments { get; }
    }
}
