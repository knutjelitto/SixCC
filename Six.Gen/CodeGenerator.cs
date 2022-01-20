using Microsoft.CodeAnalysis;
using Six.Core.Errors;

namespace Six.Gen
{
    internal static class CodeGenerator
    {
        public static void Generate(SourceProductionContext context, AdditionalText additional)
        {
            var name = $"{Path.GetFileNameWithoutExtension(additional.Path)}";
            var fileHint = $"{name}Parser.gen.cs";
            var content = additional.GetText()?.ToString() ?? string.Empty;
            var generated = string.Empty;

            try
            {
                using (var generator = new EbnfCsGenerator(additional.Path))
                {
                    generator.Generate(name, content);
                    generated = generator.ToString();
                }
            }
            catch (DiagnosticException exception)
            {
                Error(exception, context, additional);
            }

            var generatedFile = Sibling(additional.Path, "Generated.cs");

            File.WriteAllText(generatedFile, generated);

#if true
            //context.AddSource(fileHint, null);
#else
            context.AddSource(fileHint, generated);
#endif
        }

        private static string Sibling(string path, string append)
        {
            var directory = Path.GetDirectoryName(path);
            var filename = Path.GetFileNameWithoutExtension(path) + append;
            var filepath = Path.Combine(directory, filename);

            return filepath;
        }

        private static readonly DiagnosticDescriptor CommonError = new(
            id: "SIXGEN001",
            title: "General Error",
            messageFormat: "general error",
            category: "SixGen",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor SyntaxError = new(
            id: "SIXGEN002",
            title: "Syntax Error",
            messageFormat: "syntax error - {0}",
            category: "SixGen",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor SemanticError = new(
            id: "SIXGEN003",
            title: "Semantic Error",
            messageFormat: "semantic error - {0}",
            category: "SixGen",
            DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        private static void Error(DiagnosticException exception, SourceProductionContext context, AdditionalText additional)
        {
            foreach (var diagnostic in exception.Diagnostics)
            {
                if (diagnostic is SyntaxError syntax)
                {
                    var location = MakeLocation(additional.Path, syntax);

                    context.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic.Create(SyntaxError, location, syntax.Message));
                }
                else if (diagnostic is SemanticError semantic)
                {
                    var location = MakeLocation(additional.Path, semantic);

                    context.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic.Create(SemanticError, location, semantic.Message));
                }
                else
                {
                    context.ReportDiagnostic(Microsoft.CodeAnalysis.Diagnostic.Create(CommonError, null));
                }
            }
        }

        private static Location MakeLocation(string file, LocatedMessageError error)
        {
            var (startLineNo, startColumnNo) = error.Location.Source.GetLineAndColumn(error.Location.Offset);
            var (endLineNo, endColumnNo) = error.Location.Source.GetLineAndColumn(error.Location.Offset + error.Location.Length);

            var span = new Microsoft.CodeAnalysis.Text.TextSpan(error.Location.Offset, error.Location.Offset);
            var start = new Microsoft.CodeAnalysis.Text.LinePosition(startLineNo - 1, startColumnNo - 1);
            var end = new Microsoft.CodeAnalysis.Text.LinePosition(endLineNo - 1, endColumnNo - 1);
            var lineSpan = new Microsoft.CodeAnalysis.Text.LinePositionSpan(start, end);
            return Location.Create(file, span, lineSpan);
        }
    }
}
