using Six.Gen.Ebnf;
using Six.Input;

namespace Six.Gen
{
    internal class EbnfCsGenerator : CsGenerator
    {
        const string Matchers = "__Matchers";

        const string ImplementationCoreClass = "ImplementationCore";
        const string RuleClass = "Rule";
        const string MatcherClass = "Matcher";
        const string ParserCore = "ParserCore";

        private readonly OpNamer namer = new();

        public override void Generate(string name, string content)
        {
            var ast = Builder.Build(name, content)!;
            var transformer = new EbnfCreator(ast);
            var grammar = transformer.Create();

            if (grammar == null)
            {
                return;
            }

            var dfaGenerator = new DfaCsGenerator(writer, grammar);
            var parserClass = $"{name}Parser";
            var implementationClass = $"__{parserClass}Implementation";

            wl("using System.Collections.Generic;");
            wl("using Six.Runtime;");
            wl("using Six.Runtime.Matchers;");
            wl("using Six.Runtime.Dfa;");
            wl("using Range = Six.Runtime.Matchers.Range;");
            wl("using String = Six.Runtime.Matchers.String;");
            wl();

            block("namespace SixBot", () =>
            {
                block($"public partial class {parserClass} : {ParserCore}", () =>
                {
                    wl($"public {parserClass}()");
                    indent(() => wl($": base({name.CsString()}, new {implementationClass}())"));
                    block(() =>
                    {
                    });
                    wl();

                    var matchersCount = grammar.Inner.Count;

                    block($"private class {implementationClass} : {ImplementationCoreClass}", () =>
                    {
                        wl($"public {implementationClass}()");
                        indent(() => wl($": base(new {MatcherClass}[{matchersCount}])"));
                        block(() =>
                        {
                            string ClassName(Operator op)
                            {
                                var name = op.GetType().Name;
                                return name.Substring(0, name.Length - 2);
                            }

                            void NonRule(Operator op, string? className = null, string? extra = null)
                            {
                                var arguments = extra == null ? ");" : $", {extra});";
                                className = className ?? ClassName(op);
                                wl($"new {className}(this, {op.Id}, {namer.NameOf(op).CsString()}{arguments}");
                            }

                            foreach (var rule in grammar.Rules)
                            {
                                w($"/* {rule.Id,3} {rule.GetType().Name,-12} */ {Matchers}[{rule.Id}] = ");
                                wl($"{rule.RuleId()} = new {ClassName(rule)}(this, {rule.Id}, {rule.Name.CsString()});");
                            }
                            foreach (var inner in grammar.Others)
                            {
                                w($"/* {inner.Id,3} {inner.GetType().Name,-12} */ {Matchers}[{inner.Id}] = ");
                                switch (inner)
                                {
                                    case RuleOp rule:
                                        wl($"{rule.RuleId()} = new {RuleClass}(this, {rule.Id}, {rule.Name.CsString()});");
                                        break;
                                    case RefOp op:
                                        wl($"{op.RuleId()};");
                                        break;
                                    case DiffOp op when op.CodepointSet != null:
                                        NonRule(op, className: "Set", extra: dfaGenerator.DfaSet(op.CodepointSet));
                                        break;
                                    case CharacterOp op:
                                        NonRule(op, extra: $"{(int)op.Codepoint}");
                                        break;
                                    case RangeOp op:
                                        NonRule(op, extra: $"{(int)op.Codepoint1}, {(int)op.Codepoint2}");
                                        break;
                                    case StringOp op:
                                        NonRule(op, extra: $"{op.Text.CsString()}");
                                        break;
                                    default:
                                        NonRule(inner);
                                        break;
                                }
                            }
                            wl();

                            foreach (var op in grammar.Inner.Where(i => !i.Closed))
                            {
                                w($"/* {op.Id,3} {op.GetType().Name,-12} */ ");
                                w($"{Matchers}[{op.Id}].Set(");
                                var more = false;
                                foreach (var argument in op)
                                {
                                    if (more)
                                    {
                                        w(", ");
                                    }
                                    more = true;
                                    w($"{Matchers}[{argument.Id}]");
                                }
                                wl($");");
                            }
                            wl();

                            dfaGenerator.Create();
                            wl();
                            dfaGenerator.Init();
                        });
                        wl();

                        foreach (var op in grammar.Rules)
                        {
                            if (!op.Name.StartsWith("%"))
                            {
                                wl($"private {RuleClass} {op.RuleId()};");
                            }
                        }
                        wl();

                        dfaGenerator.Declare();
                    });
                    wl();
                });
            });

            wl();
            wl("#if false");
            wl();
            //grammar.DumpAst(writer);
            wl();
            wl("#endif");
        }
    }
}
