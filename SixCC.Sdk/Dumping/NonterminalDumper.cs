using System;
using System.Collections.Generic;
using System.Text;

using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;

namespace SixCC.Sdk.Dumping
{
    public class NonterminalDumper
    {
        public NonterminalDumper(Grammar grammar)
        {
            Grammar = grammar;
        }

        public Grammar Grammar { get; }

        public void Dump(IWriter writer)
        {
            foreach (var nonterminal in Grammar.Nonterminals)
            {
                DumpNonterminal(writer, nonterminal);
            }
        }

        private void DumpNonterminal(IWriter writer, Nonterminal nonterminal)
        {
            writer.WriteLine($"{nonterminal.Name}  {nonterminal.First}");
        }
    }
}
