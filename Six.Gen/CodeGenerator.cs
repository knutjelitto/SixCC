using Microsoft.CodeAnalysis;

namespace Six.Gen
{
    internal class CodeGenerator
    {
        public static void Generate(SourceProductionContext context, AdditionalText additional)
        {
#if XDEBUG
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }
#endif
            var name = $"{Path.GetFileNameWithoutExtension(additional.Path)}";
            var fileHint = $"{name}Parser.gen.cs";
            var content = additional.GetText()?.ToString() ?? string.Empty;
            var generated = string.Empty;

            using (var generator = new EbnfCsGenerator())
            {
                generator.Generate(name, content);
                generated = generator.ToString();
            }

            context.AddSource(fileHint, generated);
        }

#if false
        private static readonly DiagnosticDescriptor InvalidSixError = new(
            id: "SIXGEN001",
            title: "Couldn't parse SIX grammar file",
            messageFormat: "Couldn't parse SIX grammar file",
            category: "SixGenerator",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

#pragma warning disable IDE0051 // Remove unused private members
        private void Error()
#pragma warning restore IDE0051 // Remove unused private members
        {
            var ts = new Microsoft.CodeAnalysis.Text.TextSpan(0, 6);
            var l1 = new Microsoft.CodeAnalysis.Text.LinePosition(0, 0);
            var l2 = new Microsoft.CodeAnalysis.Text.LinePosition(0, 6);
            var ls = new Microsoft.CodeAnalysis.Text.LinePositionSpan(l1, l2);
            var lc = Microsoft.CodeAnalysis.Location.Create(additional.Path, ts, ls);

            context.ReportDiagnostic(Diagnostic.Create(InvalidSixError, lc));

        }
#endif
    }
}
