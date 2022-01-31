using Six.Runtime.Types;
using System;

namespace Six.Ceylon.Ast
{
    public abstract class Identifier : AstNode, IComparable<Identifier>
    {
        public Identifier(RToken token, string text)
        {
            Token = token;
            Text = text;
        }

        public RToken Token { get; }
        public string Text { get; }

        public int CompareTo(Identifier? other)
        {
            return Text.CompareTo(other!.Text ?? string.Empty);
        }

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
