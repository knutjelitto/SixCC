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
            CodeGenerator.Generate(context, additional);
        }
    }
}
