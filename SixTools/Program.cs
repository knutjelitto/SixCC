// See https://aka.ms/new-console-template for more information

using SixTools.Formats;
using SixTools.Grammars;

var sampleName = "sixg.sixg";

var sample = new Samples().Get(sampleName);

var parser = new SixgParser();
var parsed = parser.Parse(sample);

parsed.Shrink();
parsed.ResolveReference();

Console.WriteLine($"X: {Environment.CurrentDirectory}");
var outPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "../../../../..", "SixTmp", "tools"));
Console.WriteLine($"X: {outPath}");
if (!Directory.Exists(outPath))
{
    _ = Directory.CreateDirectory(outPath);
}

#pragma warning disable IDE0059 // Unnecessary assignment of a value
var format1 = new SixgFormat(parsed, new SixTools.Writer(Console.Out));
#pragma warning restore IDE0059 // Unnecessary assignment of a value

using (var writer = FFile(outPath, sampleName, "html"))
{
    var format = new HtmlFormat(parsed, new SixTools.Writer(writer), true);
    format.Format();
}

Console.Write("any (really almost any) key .. ");
Console.ReadKey(true);

static string FName(string path, string sampleName, string extension)
{
    return Path.Combine(path, sampleName + "." + extension);
}

static TextWriter FFile(string path, string sampleName, string extension)
{
    return new StreamWriter(FName(path, sampleName, extension));
}
