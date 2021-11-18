using Microsoft.CodeAnalysis;

namespace Six.Gen
{
    [Generator(LanguageNames.CSharp)]
    public class SixGen : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext initContext)
        {
            var sixgs = initContext.AdditionalTextsProvider.Where(add => add.Path.EndsWith(".six", StringComparison.OrdinalIgnoreCase));

            initContext.RegisterSourceOutput(sixgs, Generate);
        }

        private void Generate(SourceProductionContext context, AdditionalText additional)
        {
            var filename = $"{Path.GetFileName(additional.Path)}";
            var name = $"{Path.GetFileNameWithoutExtension(additional.Path)}";
            //var file = Path.Combine(Path.GetDirectoryName(additional.Path), $"{name}Parser.gen.cs");
            var fileHint = $"{name}Parser.gen.cs";

            using (var writer = new Writer())
            {
                writer.WriteLine("namespace SixBot");
                writer.WriteLine("{");
                using (writer.Indent())
                {
                    writer.WriteLine($"public partial class {name}Parser : Parser");
                    writer.WriteLine("{");
                    using (writer.Indent())
                    {
                        writer.WriteLine($"public override void Print()");
                        writer.WriteLine("{");
                        using (writer.Indent())
                        {
                            writer.WriteLine($"System.Console.WriteLine(\"XXXAdditional text was: {filename}\");");
                        }
                        writer.WriteLine("}");
                    }
                    writer.WriteLine("}");
                }
                writer.WriteLine("}");

                context.AddSource(fileHint, writer.ToString());
            }
        }
    }
}
