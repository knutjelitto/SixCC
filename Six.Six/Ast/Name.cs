using Six.Runtime.Types;
using System;

namespace Six.Six.Ast
{
    public interface Name : TreeNode, Expression, IComparable<Name>
    {
        string Text { get; }

        int IComparable<Name>.CompareTo(Name? other)
        {
            Assert(other != null);

            return Text.CompareTo(other.Text);
        }

        bool Equals(object? obj)
        {
            return obj is Name that && that.Text == Text;
        }

        int GetHashCode()
        {
            return Text.GetHashCode();
        }

        string? ToString()
        {
            return Text;
        }

        public sealed class Id : Name
        {
            public Id(IRLocated tree)
            {
                Tree = tree;
                Text = tree.Text;
            }

            public IRNode Tree { get; }
            public string Text { get; }
        }

        public sealed class ArtificalId : Name
        {
            public ArtificalId(string text)
            {
                Text = text;
            }

            public IRNode Tree => throw new System.InvalidOperationException();
            public string Text { get; }
        }
    }

    public sealed record Names(IRNode Tree, IEnumerable<Name> Items) : Many<Name>(Tree, Items);
}
