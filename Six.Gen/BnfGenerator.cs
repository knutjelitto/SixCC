using Six.Ast;
using Six.Input;

namespace Six.Gen
{
    internal class BnfGenerator : CodeGeneratorCore
    {
        const string Implementation = "RunImplementation";
        const string IImplementation = "IRunImplementation";
        const string StartSymbol = "Start";
        const string Production = "Production";
        const string Productions = "Productions";
        const string Slot = "Slot";
        const string Slots = "Slots";
        const string IntermediateSlot = "IntermediateSlot";
        const string FinalSlot = "FinalSlot";
        const string Symbol = "Symbol";
        const string Symbols = "Symbols";
        const string Nonterminal = "Nonterminal";
        const string UndefinedTerminal = "UndefinedTerminal";
        const string StringTerminal = "StringTerminal";
        const string Fragment = "Fragment";
        const string Continuation = "Continuation";

        public override void Generate(string name, string content)
        {
            var checker = new Checker();
            var grammar = checker.Run(false, name, content);

            if (grammar == null)
            {
                return;
            }

            wl("using System.Collections.Generic;");
            wl("using Six.Runtime;");
            wl();

            block("namespace SixBot", () =>
            {
                block($"public partial class {name}Parser : Parser", () =>
                {
                    block($"public override void Match(string text)", () =>
                    {
                        wl($"var source = new Source(text);");
                        wl($"var cursor = new Cursor(source, 0);");
                        wl($"var implementation = new {Implementation}();");
                        wl($"implementation.Start.Match(cursor, new {Continuation}(next =>");
                        wl("{");
                        indent(() =>
                        {
                            wl($"System.Console.WriteLine($\"match-length: {{next.Offset}}\");");
                        });
                        wl("}));");
                    });

                    wl();

                    block($"private class {Implementation} : {IImplementation}", () =>
                    {
                        var nonterminals = grammar.Nonterminals().Cast<Nonterminal>().ToList();
                        var terminals = grammar.Terminals().Cast<Terminal>().ToList();
                        var fragments = grammar.Fragments().Cast<Fragment>().ToList();


                        wl($"public {Slot}[] {Slots} {{ get; }}");
                        wl();
                        wl($"public {Production}[] {Productions} {{ get; }}");
                        wl();
                        wl($"public {Symbol}[] {Symbols} {{ get; }}");
                        wl();
                        wl($"public {Symbol} {StartSymbol} => {Symbols}[0];");
                        wl();


                        block($"public {Implementation}()", () =>
                        {
                            initializer($"{Slots} = new {Slot}[]", () =>
                            {
                                var slotId = 0;

                                foreach (var nonterminal in nonterminals)
                                {
                                    foreach (var production in nonterminal.Sequences)
                                    {
                                        foreach (var slot in production.Expressions)
                                        {
                                            switch (slot)
                                            {
                                                case Reference reference:
                                                    wl($"new {IntermediateSlot}(this, {slotId++}, {reference.Symbol.Id}, {slotId}),");
                                                    break;
                                                default:
                                                    wl($"//new {IntermediateSlot}(this, ...),");
                                                    break;
                                            }
                                        }
                                        wl($"new {FinalSlot}(this, {slotId++}),");
                                    }
                                }
                            });
                            wl();

                            initializer($"{Productions} = new {Production}[]", () =>
                            {
                                var slotId = 0;
                                var productionId = 0;

                                foreach (var nonterminal in nonterminals)
                                {
                                    foreach (var production in nonterminal.Sequences)
                                    {
                                        wl($"new {Production}(this, {productionId++}, {slotId}),");
                                        slotId += production.Expressions.Count + 1;
                                    }
                                }

                            });
                            wl();

                            initializer($"{Symbols} = new {Symbol}[]", () =>
                            {
                                var productionId = 0;

                                foreach (var nonterminal in nonterminals)
                                {
                                    w($"new {Nonterminal}(this, {nonterminal.Id}, {nonterminal.Name.CsString()}");
                                    using (indent())
                                    {
                                        foreach (var production in nonterminal.Sequences)
                                        {
                                            w($", {productionId++}");
                                        }
                                        wl("),");
                                    }
                                }

                                wl();

                                foreach (var terminal in terminals)
                                {
                                    switch (terminal.Expression)
                                    {
                                        case Literal literal:
                                            wl($"new {StringTerminal}(this, {terminal.Id}, {terminal.Name.CsString()}, {literal.Text.ToString().CsString()}),");
                                            break;
                                        default:
                                            wl($"new {UndefinedTerminal}(this, {terminal.Id}, {terminal.Name.CsString()}),");
                                            break;
                                    }
                                }

                                wl();

                                foreach (var fragment in fragments)
                                {
                                    wl($"new {Fragment}(this, {fragment.Id}, {fragment.Name.CsString()}),");
                                }
                            });
                        });
                    });
                });

            });

            wl();
            wl("#if false");
            wl();
            grammar.DumpAst(writer);
            wl();
            wl("#endif");
        }
    }
}
