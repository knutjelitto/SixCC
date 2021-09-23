using System;
using System.IO;
using System.Linq;
using SixCc.Hime;
using Hime.Redist;
using System.Reflection;
using System.Diagnostics;
using SixCC.Hime;
using SixCC.Sdk.Build;
using SixCC.Sdk.Commons;
using SixCC.Sdk.Dumping;
using SixCC.Sdk.CSharpWrite;

namespace Lingu.Hime
{
    internal class Program
    {
        static void Main()
        {
            new Program().Compile("Expressions");

            Console.Write("any key ... ");
            Console.ReadKey(true);
        }

        private static string LoadGrammar(string grammarName)
        {
            var resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(n => n.EndsWith(grammarName + ".gsix")).Single();
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)!;
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        private void Compile(string grammarName)
        {
            var grammarText = LoadGrammar(grammarName);

            var lexer = new LinguLexer(grammarText);
            var parser = new LinguParser(lexer);

            var result = parser.Parse();

            if (result.IsSuccess)
            {
                var dumpRoot = FileRef.From(@"/SixTmp/Expressions");

                DumpTree(dumpRoot.Add(".Tree"), result);

                var visitor = new LinguVisitor();
                var rawGrammar = visitor.Visit(result);
                var builder = new GrammarBuilder(rawGrammar);
                var grammar = builder.Build();
                var dumper = new Dumper(grammar);
                dumper.Dump(dumpRoot);

                var writer = new CSharpWriter(grammar, FileRef.From(grammarName + ".gsix"), DirRef.From(dumpRoot));
                writer.Write();
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"{error} ({error.Type})");
                }
            }
        }

        private void DumpTree(FileRef file, ParseResult result)
        {
            using var writer = new StreamWriter(file);
            
            Print(result.Root, false, Array.Empty<bool>());

            void Print(ASTNode node, bool more, bool[] crossings)
            {
                for (int i = 0; i < crossings.Length - 1; i++)
                {
                    writer.Write(crossings[i] ? "| " : "  ");
                }
                if (crossings.Length > 0)
                {
                    if (more)
                    {
                        writer.Write("├─› ");
                    }
                    else
                    {
                        writer.Write("└─› ");
                    }
                }
                writer.WriteLine(node.ToString());
                for (int i = 0; i != node.Children.Count; i++)
                {
                    bool[] childCrossings = new bool[crossings.Length + 1];
                    Array.Copy(crossings, childCrossings, crossings.Length);
                    childCrossings[^1] = i < node.Children.Count - 1;
                    Print(node.Children[i], i < node.Children.Count - 1, childCrossings);
                }
            }
        }
    }
}
