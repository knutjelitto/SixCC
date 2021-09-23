using System;

using SixCC.Sdk.Automata;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Tree
{
    public class UcCategory : Atom
    {
        public UcCategory(string text)
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
