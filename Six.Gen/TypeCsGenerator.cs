using Six.Gen.Ebnf;
using Six.Gen.Typing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Six.Gen
{
    public class TypeCsGenerator : CsGenerator
    {
        public TypeCsGenerator(Writer writer, EbnfGrammar grammar) : base(writer)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }

        public void Generate()
        {
            foreach (var rule in Grammar.CoreRules)
            {
                if (rule.Interface == null)
                {
                    continue;
                }
                var ifaces = string.Empty;
                if (rule.Interface.Interfaces.Count > 0)
                {
                    ifaces = $" : {rule.Interface.InterfaceNames}";
                }
                wl($"public interface {rule.Interface.TypeName}{ifaces} {{}}");
            }
            wl();
            foreach (var rule in Grammar.CoreRules)
            {
                if (rule.Class == null)
                {
                    continue;
                }
                var ifaces = string.Empty;
                if (rule.Class.Base != null || rule.Interface != null)
                {
                    ifaces = " : ";
                    if (rule.Class.Base != null)
                    {
                        ifaces = $"{ifaces}{rule.Class.BaseName}";
                        if (rule.Interface != null)
                        {
                            ifaces = $"{ifaces}, ";
                        }
                    }
                    if (rule.Interface != null)
                    {
                        ifaces = $"{ifaces}{rule.Interface.TypeName}";
                    }
                }
                block($"public partial class {rule.Class.TypeName}{ifaces}",
                    () =>
                    {
                        Body(rule, rule.Argument);
                    });
            }
        }

        private void Body(RuleOp rule, CoreOp op)
        {
            switch (op)
            {
                case SeqOp seq when seq.IsLoop:
                    LoopBody(rule, seq);
                    break;
                case SeqOp seq:
                    SequenceBody(rule, seq);
                    break;
                case StarOp star:
                    StarBody(rule, star);
                    break;
                case PlusOp plus:
                    PlusBody(rule, plus);
                    break;
                case StringOp inner:
                    StringBody(rule, inner);
                    break;
                case TokenOp inner:
                    TokenBody(rule, inner);
                    break;
                default:
                    wl($"// TODO");
                    break;
            }
        }

        private void Constructor(RuleOp rule)
        {
            if (rule.Class != null)
            {
                wl($"public {rule.Class.TypeName}(params RNode[] children) {{}}");
            }
        }

        private void SequenceBody(RuleOp rule, SeqOp inner)
        {
            Constructor(rule);
            wl();

            var namer = new Namer();

            for (var index = 0; index < inner.Arguments.Count; index++)
            {
                var element = inner.Arguments[index];

                wl($"// public {TypeOf(element)} {NameOf(namer, element)} => ({TypeOf(element)})(object)Children[{index}]");
            }
        }

        private void LoopBody(RuleOp rule, SeqOp op)
        {
            Constructor(rule);
        }

        private void StarBody(RuleOp rule, StarOp op)
        {
            Constructor(rule);
        }

        private void PlusBody(RuleOp rule, PlusOp op)
        {
            Constructor(rule);
        }

        private void StringBody(RuleOp rule, StringOp op)
        {
            Constructor(rule);
        }

        private void TokenBody(RuleOp rule, TokenOp op)
        {
            Constructor(rule);
        }

        private string? TypeOf(CoreOp op)
        {
            return op.Class?.TypeName ?? op.Interface?.TypeName;
        }

        private string? NameOf(Namer namer, CoreOp op)
        {
            if (op.Class != null)
            {
                if (op.Class.Generic != null)
                {
                    return namer.NameOf(op.Class.Generic.Name.CsId());
                }
                return namer.NameOf(op.Class.Name.CsId());
            }
            else if (op.Interface != null)
            {
                return namer.NameOf(op.Interface.Name.CsId());
            }

            return null;
        }

        private class Namer
        {
            private readonly Dictionary<string, int> names = new();

            public string NameOf(string name)
            {
                if (names.TryGetValue(name, out var number))
                {
                    names[name] = ++number;

                    return $"{name}{number}";
                }

                names.Add(name, 1);

                return name;
            }
        }
    }
}
