using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class Any : Expression
    {
        public static readonly Any Instance = new Any();

        private Any() { }

        public override bool IsAtomic => true;

        public override string ToName() => ".";
    }
}
