#if false
using Microsoft.CodeAnalysis;

namespace Six.Gen
{
    [Generator]
    public class SixGenerator : ISourceGenerator
    {
        private void HandleAdditional(GeneratorExecutionContext context, AdditionalText additional)
        {
            if (!additional.Path.EndsWith(".sixg", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }

            var filename = $"{Path.GetFileName(additional.Path)}";
            var name = $"{Path.GetFileNameWithoutExtension(additional.Path)}";
            var file = $"{name}.gen.cs";

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
                            writer.WriteLine($"System.Console.WriteLine(\"Additional text was: {filename}\");");
                        }
                        writer.WriteLine("}");
                    }
                    writer.WriteLine("}");
                }
                writer.WriteLine("}");

                context.AddSource(file, writer.ToString());
            }

            //new Output(additional.Path, additional.GetText()!.ToString());
        }

        public void Execute(GeneratorExecutionContext context)
        {
            foreach (var file in context.AdditionalFiles)
            {
                HandleAdditional(context, file);
            }
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            // No initialization required for this one
        }
    }
}
#endif