using Six.Runtime.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six.Ceylon.Ast
{
    public abstract class Identifier
    {
        public Identifier(RToken token, string text)
        {
            Token = token;
            Text = text;
        }

        public RToken Token { get; }
        public string Text { get; }

        public override bool Equals(object? obj)
        {
            return obj is Identifier that && Text == that.Text;
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }

        public override string ToString() => Text;
    }
}
