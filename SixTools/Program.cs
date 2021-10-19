// See https://aka.ms/new-console-template for more information

using SixTools.Formats;
using SixTools.Grammars;

var sample = new Samples().Get("bnf.sixg");

var parser = new SixgParser();
var grammar = parser.Parse(sample);

grammar.Shrink();

var format = new AstDump(grammar, new SixTools.Writer(Console.Out));
format.Format();

Console.Write("any (really almost any) key .. ");
Console.ReadKey(true);
