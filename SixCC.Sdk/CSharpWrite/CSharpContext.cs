using SixCC.Sdk.Commons;
using SixCC.Sdk.Grammars;
using SixCC.Sdk.Output;
using SixCC.Runtime.Structures;

namespace SixCC.Sdk.CSharpWrite
{
    public class CSharpContext
    {
        public CSharpContext(Grammar grammar, FileRef sourceFile, string @namespace, DirRef output, CsWriter? writer = null)
        {
            Grammar = grammar;
            SourceFile = sourceFile;
            Namespace = @namespace;
            Output = output;
            Writer = writer ?? new CsWriter();
        }

        public Grammar Grammar { get; }
        public FileRef SourceFile { get; }
        public string Namespace { get; }
        public DirRef Output { get; }
        public CsWriter Writer { get; }

        public string ContextClass => $"{Grammar.Name}Context";
        public FileRef ContextClassFile => Output.File(ContextClass).Add(".cs");
        public string VisitorClass => $"{Grammar.Name}Visitor";
        public FileRef VisitorClassFile => Output.File(VisitorClass).Add(".cs");
        public string IdClass => $"{Grammar.Name}Id";
        public static string DataSubClass => "Data";
        public FileRef DataSubClassFile => Output.File($"{ContextClass}.{DataSubClass}").Add(".cs");

        public string ParseTableType => nameof(IParseTable);
        public string DfaSetType => nameof(IDfaSet);

        public CSharpContext With(CsWriter writer)
        {
            return new CSharpContext(Grammar, SourceFile, Namespace, Output, writer);
        }

        public CSharpContext WithWriter()
        {
            return With(new CsWriter());
        }

        public void Space()
        {
            Writer?.WriteLine();
        }
    }
}
