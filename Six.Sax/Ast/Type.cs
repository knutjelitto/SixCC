using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Sax.Ast
{
    public interface Type : Node, Generic.Argument
    {
        public sealed record Union(IRNode Tree, Type Left, Type Right) : Type;
        public sealed record Constructor(IRNode Tree, Type Type, Arguments Arguments) : Type;
        public sealed record Array(IRNode Tree, Type Type) : Type;
    }

    public sealed record Types(IRNode Tree, IEnumerable<Type> Items) : Many<Type>(Tree, Items);
}
