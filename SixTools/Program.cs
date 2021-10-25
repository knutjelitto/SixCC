// See https://aka.ms/new-console-template for more information

using SixTools;
using SixTools.Formats;
using SixTools.Grammars;

//EmbeddedResources.List();

//foreach (var sampleName in new[] { "checker.sixg", "sixg.sixg", "wsn.sixg", "bnf.sixg" })
foreach (var sampleName in new[] { "checker.sixg", "sixg.sixg" })
{
    var sample = EmbeddedResources.GetSample(sampleName);

    var parser = new SixgParser();
    var parsed = parser.Parse(sample);

    parsed.Shrink();
    parsed.Resolve();

    var outPath = Formatter.TempPath();

    foreach (var formatter in Formatter.Formatters)
    {
        using var writer = FFile(outPath, sampleName, formatter.PreferedExtension);
        formatter.Format(parsed, new SixTools.Writer(writer));
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
