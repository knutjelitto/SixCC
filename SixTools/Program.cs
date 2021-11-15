// See https://aka.ms/new-console-template for more information

using Pegasus.Common;
using Six.Core;
using SixTools.Formats;
using SixTools.Grammars;
using SixTools.Helpers;

//EmbeddedResources.List();

var samples = new[] { "CPP14Lexer.g4", "CPP14Parser.g4", "sixg.sixg", "ANTLRv4Parser.g4", "ANTLRv4Lexer.g4", "LexBasic.g4", "abnf.sixg", "checker.sixg", "wsn.sixg", "bnf.sixg", "bnf.wsn", "c-syntax.wsn", "wsn.wsn" };

foreach (var sampleName in samples)
{
    var sample = EmbeddedResources.GetSample(sampleName);

    var parser = ParserSched.Match(sampleName);
    if (parser == null)
    {
        continue;
    }

    try
    {
        var parsed = parser.Parse(sample);

        parsed.Shrink();
        parsed.Resolve();

        var outPath = Formatter.TempPath();

        foreach (var formatter in Formatter.Formatters)
        {
            using (var writer = new Writer(FFile(outPath, sampleName, parser, formatter)))
            {
                formatter.Format(parsed, writer);
            }
        }

        continue;
    }
    catch (FormatException e)
    {
        var cursor = (Cursor)(e.Data["cursor"]!);
        Console.WriteLine($"{sampleName}({cursor.Line}, {cursor.Column}): {e.Message}");

        break;
    }
}

Console.Write("any key .. ");
Console.ReadKey(true);

static string FName(string sampleName, Parser informat, IFormat outformat)
{
    var filename = $"{Path.GetFileNameWithoutExtension(sampleName)}〈{informat.FormatName}→{outformat.FormatName}〉{outformat.DebugExtension}";
    return filename;
}

static TextWriter FFile(string path, string sampleName, Parser informat, IFormat outformat)
{
    return new StreamWriter(Path.Combine(path, FName(sampleName, informat, outformat)));
}
