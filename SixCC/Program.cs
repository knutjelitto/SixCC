using SixCC.CC;
using SixCC.CC.Analyzers;
using SixCC.CC.Dumping;
using SixCC.CC.Errors;
using SixCC.Runtime.Sources;
using SixCC.Sdk.Commons;
using SixCC.Sdk.Earley;
using SixCC.Sdk.Ebnf;
using SixCC.Writing;

namespace SixCC
{
    class Program
    {
        private static void Main(string[] args)
        {
            var quick = false;
            try
            {
                Compile();

                Console.WriteLine("OK");
            }
            catch (DiagnosticException error)
            {
                error.Diagnostic.Report(new ConsoleWriter());
                quick = false;
            }

            if (!quick)
            {
                Console.Write("any key ... ");
                Console.ReadKey(true);

            }
        }

        static void Compile()
        {
            var dumpRoot = DirectoryRef.From(@"/SixTmp/SixCC").Ensure();

            //var content = Grammars.Gamma21(); var test = "abcd";
            //var content = Grammars.Bug(); var test = "a";
            //var content = Grammars.Expr(); var test = "1+2+3";
            //var content = Grammars.Expression(); var test = "f(x,y)";
            //var content = Grammars.List(); var test = "f(x)";
            //var content = Grammars.Ambiguous(); var test = "xxyy";
            var content = Grammars.SixCC(); var test = "1+2+3";
            var source = new Source(content.Name, content.Text);
            var lexer = new Lexer(source);
            var tokens = new Tokens(lexer);
            var parser = new CC.Parser(tokens);
            var tree = parser.Grammar();

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.tree")))
            {
                TreeDumper.Dump(writer, tree);
            }

            var grammar = new GrammarBuilder().Build(tree);

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.structure")))
            {
                GrammarDumper.Dump(writer, grammar);
            }

            var automaton = new AutomatonBuilder().Build(grammar);

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.automaton")))
            {
                AutomatonDumper.Dump(writer, automaton);
            }

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.automaton.dot")))
            {
                new AutomatonDot(writer, automaton).Dot();
            }

            Console.WriteLine($"{test}");

            foreach (var rule in grammar.Rules.Where(r => r is Nonterminal))
            {
                Console.WriteLine($"{rule.Name}");
                var dots = dumpRoot.AppendDirectory("svg");
                dots.Ensure();
                var name = dots.AppendFile($"{rule.Name}.svg");

                using (var writer = new FileWriter(name))
                {
                    new RuleSvg(writer).Write(rule);
                }
            }

#if false
            var earley = new Sdk.Earley.Parser(new Source("test", test), automaton);
            var items = earley.Recognize().ToList();

            using (var writer = new FileWriter(dumpRoot.AppendFile($"Grammar.chart")))
            {
                EarleyDumper.Dump(writer, earley.Chart);
            }

            CoreNode node;

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.forrest-build")))
            {
                var forrestBuilder = new ForrestBuilder(writer, earley.Chart);

                node = forrestBuilder.Build();
            }

            using (var writer = new FileWriter(dumpRoot.AppendFile($"{content.Name}.dot")))
            {
                new ForrestDot(writer, node).Dot();
            }

            var oks = items.Count == 0 ? "FAIL" : "OK";
            Console.WriteLine(oks);
#endif
        }
    }
}
