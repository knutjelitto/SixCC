using Six.Runtime.Types;
using System;

namespace Six.Sax.Ast
{
    public interface Name : Node, Expression, IComparable<Name>
    {
        string Text { get; }

        public sealed class Id : Name, IComparable<Id>
        {
            public Id(IRNode tree)
            {
                Assert(tree is RToken);

                Tree = tree;
                Text = ((RToken)tree).Text;
            }

            public IRNode Tree { get; }
            public string Text { get; }

            public int CompareTo(Id? other)
            {
                Assert(other != null);

                return Text.CompareTo(other.Text);
            }

            public int CompareTo(Name? other)
            {
                Assert(other != null && other is Id);

                return Text.CompareTo(((Id)other).Text);
            }

            public override bool Equals(object? obj)
            {
                return obj is Id that && that.Text == Text;
            }

            public override int GetHashCode()
            {
                return Text.GetHashCode();
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }

    public sealed record Names(IRNode Tree, IEnumerable<Name> Items) : Many<Name>(Tree, Items);
}
