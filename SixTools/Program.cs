// See https://aka.ms/new-console-template for more information

using Pegasus.Common;
using SixTools.Formats;
using SixTools.Grammars;
using SixTools.Helpers;

//EmbeddedResources.List();

var samples = new[] { "abnf.sixg", "checker.sixg", "sixg.sixg", "wsn.sixg", "bnf.sixg" };

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
            using var writer = FFile(outPath, sampleName, formatter.DebugExtension);
            formatter.Format(parsed, new SixTools.Writer(writer));
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

static string FName(string path, string sampleName, string extension)
{
    return Path.Combine(path, Path.GetFileNameWithoutExtension(sampleName) + extension);
}

static TextWriter FFile(string path, string sampleName, string extension)
{
    return new StreamWriter(FName(path, sampleName, extension));
}
