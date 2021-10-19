// See https://aka.ms/new-console-template for more information

using SixTools.Formats;
using SixTools.Grammars;

var sample = new Samples().Get("sixg.sixg");

var parser = new SixgParser();
var grammar = parser.Parse(sample);

grammar.Shrink();

//var format = new SixgFormat(grammar, new SixTools.Writer(Console.Out));
var format = new HtmlFormat(grammar, new SixTools.Writer(Console.Out), true);
format.Format();

Console.Write("any (really almost any) key .. ");
Console.ReadKey(true);
