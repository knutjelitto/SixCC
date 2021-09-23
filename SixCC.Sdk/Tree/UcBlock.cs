using System;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    /// <summary>
    /// Represents a Unicode block
    /// </summary>
    public class UcBlock : Atom
    {
        public UcBlock(string text)
        {
            Text = text;
        }

        public string Text { get; }

        public override FA GetFA()
        {
            throw new NotImplementedException();
        }

        public override void Dump(IndentWriter output)
        {
            output.Write(Text);
        }
    }
}
