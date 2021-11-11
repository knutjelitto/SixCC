using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixBot.Ast
{
    internal class Literal : Expression
    {
        public Literal(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
