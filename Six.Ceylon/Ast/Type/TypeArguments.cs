using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public class TypeArguments : TypeList
    {
        public TypeArguments(IEnumerable<Type> types) : base(types)
        {
        }
    }
}
