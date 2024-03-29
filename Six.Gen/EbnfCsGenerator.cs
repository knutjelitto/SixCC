﻿using Six.Gen.Ebnf;
using Six.Input;

#pragma warning disable IDE0057 // Use range operator

namespace Six.Gen
{
    public class EbnfCsGenerator : CsGenerator
    {
        const string Matchers = "__Matchers";

        const string ImplementationCoreClass = "ImplementationCore";
        const string MatcherClass = "Matcher";
        const string ParserCoreClass = "Parser";

        private readonly NameWalker namer = new();

        public EbnfCsGenerator(string originalPath)
        {
            OriginalPath = originalPath;
        }

        public EbnfGrammar? Grammar { get; private set; }
        public string OriginalPath { get; }

        public override void Generate(string name, string content)
        {
            var ast = Builder.Build(name, content)!;
            var transformer = new EbnfCreator(ast);
            Grammar = transformer.Create();

            if (Grammar == null)
            {
                return;
            }

            var dfaGenerator = new DfaCsGenerator(writer, Grammar);
            var typeGenerator = new TypeCsGenerator(writer, Grammar);
            var parserClass = $"{name}Parser";
            var implementationClass = $"Implementation";
            var astClass = $"{name}Tree";

            wl($"// <generated from={OriginalPath.CsString()} at={DateTime.Now.ToString().CsString()} />");
            wl();

            wl("using Six.Runtime;");
            wl("using Six.Runtime.Dfa;");
            wl("using Six.Runtime.Sppf;");
            wl("using Six.Runtime.Types;");
            wl("using Mx = Six.Runtime.Matchers;");
            wl($"using static {Grammar.Namespace}.{astClass};");
            wl();

            block($"namespace {Grammar.Namespace}", () =>
            {
                block($"public partial class {parserClass} : {ParserCoreClass}", () =>
                {
                    wl($"public {parserClass}()");
                    indent(() => wl($": base({name.CsString()}, new {implementationClass}())"));
                    block(() =>
                    {
                    });
                    wl();

                    var matchersCount = Grammar.Operators.Count(o => o is not RefOp);

                    string ClassName(CoreOp op)
                    {
                        var name = op.GetType().Name;
                        return name.Substring(0, name.Length - 2);
                    }

                    void CreateMatcher(CoreOp op, string? className = null, string? extra = null)
                    { 
                        var arguments = extra == null ? "" : $", {extra}";
                        className ??= ClassName(op);
                        w($"new Mx.{className}(this, {op.Id}, {namer.NameOf(op).CsString()}{arguments}");
                        var attributes = new StringBuilder();
                        if (op.Class != null)
                        {
                            if (op.IsBottomType)
                            {
                                if (op.Outer != null)
                                {
                                    Assert(true);
                                    attributes.Append($"Creator = node => new {op.Outer.TypeName}(node)");
                                }
                                else
                                {
                                    attributes.Append($"Creator = node => new {op.Class.TypeName}(node)");
                                }
                            }
                            else
                            {
                                if (op.Outer != null)
                                {
                                    attributes.Append($"Builder = nodes => new {op.Outer.TypeName}(nodes)");
                                }
                                else
                                {
                                    if (op.WithInner)
                                    {
                                        attributes.Append($"Builder = nodes => nodes[0]");
                                    }
                                    else
                                    {
                                        attributes.Append($"Builder = nodes => new {op.Class.TypeName}(nodes)");
                                    }
                                }
                            }
                        }
                        else if (op.Interface != null)
                        {
                            attributes.Append($"Builder = nodes => nodes[0]");
                        }
                        if (attributes.Length > 0)
                        {
                            wl($") {{ {attributes} }};");
                        }
                        else
                        {
                            wl($");");
                        }
                    }

                    block($"private class {implementationClass} : {ImplementationCoreClass}", () =>
                    {
                        wl($"public {implementationClass}()");
                        indent(() => wl($": base(new Mx.{MatcherClass}[{matchersCount}])"));
                        block(() =>
                        {
                            foreach (var inner in Grammar.Operators.Where(o => o is not RefOp))
                            {
                                w($"/* {inner.Id,3} {inner.GetType().Name,-16} */ ");
                                w($"{Matchers}[{inner.Id}] = ");
                                switch (inner)
                                {
                                    case RuleOp rule:
                                        w($"{rule.RuleId()} = ");
                                        CreateMatcher(rule);
                                        break;
                                    case SetOp op when op.CodepointSet != null:
                                        CreateMatcher(op, extra: dfaGenerator.DfaSet(op.CodepointSet));
                                        break;
                                    case RangeOp op:
                                        CreateMatcher(op, extra: $"{(int)op.Codepoint1}, {(int)op.Codepoint2}");
                                        break;
                                    case StringOp op when op.IsKeyword:
                                        CreateMatcher(op, className: "Keyword", extra: $"{op.Text.CsString()}");
                                        break;
                                    case StringOp op:
                                        CreateMatcher(op, extra: $"{op.Text.CsString()}");
                                        break;
                                    default:
                                        CreateMatcher(inner);
                                        break;
                                }
                            }
                            wl();

                            foreach (var op in Grammar.Operators.Where(i => i.HasArguments))
                            {
                                w($"/* {op.Id,3} {op.GetType().Name,-16} */ ");
                                if (op is DfaRuleOp dfaRule)
                                {
                                    wl($"{dfaRule.RuleId()}.Set({dfaRule.DfaId()});");
                                }
                                else if (op is NotOp notOp)
                                {
                                    wl($"{notOp.RuleId()}.Set({notOp.DfaId()});");
                                }
                                else
                                {
                                    if (op is RuleOp ruleOp)
                                    {
                                        w($"{ruleOp.RuleId()}.Set(");
                                    }
                                    else
                                    {
                                        w($"{Matchers}[{op.Id}].Set(");
                                    }
                                    var more = false;
                                    foreach (var argument in op.Arguments)
                                    {
                                        if (more)
                                        {
                                            w(", ");
                                        }
                                        more = true;
                                        if (argument is RefOp reference)
                                        {
                                            var rule = reference.Rule;
                                            w($"{rule.RuleId()}");
                                        }
                                        else
                                        {
                                            w($"{Matchers}[{argument.Id}]");
                                        }
                                    }
                                    wl($");");
                                }
                            }
                            wl();

                            dfaGenerator.Create();
                        });
                        wl();

                        foreach (var op in Grammar.Rules)
                        {
                            if (!op.IsSpecial)
                            {
                                wl($"private readonly Mx.{ClassName(op)} {op.RuleId()};"); 
                            }
                        }
                        wl();

                        dfaGenerator.Declare();
                    });
                });

                wl();
                block($"public partial class {astClass}", () =>
                {
                    typeGenerator.Generate();
                });
            });
        }
    }
}
