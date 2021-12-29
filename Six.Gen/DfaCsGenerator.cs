using Six.Gen.Ebnf;
using Six.Rex;

namespace Six.Gen
{
    internal class DfaCsGenerator : CsGenerator
    {
        const string DfaClass = "Dfa";
        const string DfaStateClass = "DfaState";
        const string DfaTransClass = "DfaTrans";
        const string DfaSetClass = "DfaSet";
        const string DfaIntervalClass = "DfaInterval";

        public DfaCsGenerator(Writer writer, EbnfGrammar grammar) : base(writer)
        {
            Grammar = grammar;
        }

        public EbnfGrammar Grammar { get; }


        public void Create()
        {
            foreach (var op in Grammar.Operators.Where(r => r.DFA != null))
            {
                Create(op.DfaId(), op.DFA!);
            }
        }

        public void Init()
        {
#if true
            foreach (var op in Grammar.Operators.Where(r => r.DFA != null))
            {
                wl($"{op.RuleId()}.Set({op.DfaId()});");
            }
#else
            foreach (var rule in Grammar.Rules.Where(r => r.DFA != null))
            {
                wl($"{rule.RuleId()}.Set({rule.DfaId()});");
            }
            foreach (var op in Grammar.Others.Where(r => r.DFA != null))
            {
                wl($"{op.RuleId()}.Set({op.DfaId()});");
            }
#endif
        }

        public void Declare()
        {
            foreach (var rule in Grammar.Rules.Where(r => r.DFA != null))
            {
                wl($"private {DfaClass} {rule.DfaId()} = new {DfaClass}({rule.Name.CsString()});");
            }
            foreach (var op in Grammar.Others.Where(r => r.DFA != null))
            {
                wl($"private {DfaClass} {op.DfaId()} = new {DfaClass}({op.DfaId().CsString()});");
            }
        }

        private void Create(string reference, FA dfa)
        {
            wl($"{reference}.Set(");
            indent(() =>
            {
                var more = false;
                foreach (var state in dfa.States)
                {
                    if (more)
                    {
                        wl($",");
                    }
                    more = true;

                    var final = state.IsFinal ? "true" : "false";
                    w($"new {DfaStateClass}({state.Id}, {final})");
                }
                wl();
            });
            wl($");");
            for (var i = 0; i < dfa.States.Count; i++)
            {
                var state = dfa.States[i];
                var transitions = state.TerminalTransitions.ToArray();

                indent(
                    $"{reference}.States[{i}].Set(",
                    () =>
                    {
                        var more = false;
                        for (var j = 0; j < transitions.Length; j++)
                        {
                            var transition = transitions[j];
                            if (more)
                            {
                                wl($",");
                            }
                            more = true;
                            w($"new {DfaTransClass}({reference}.States[{transition.TargetId}], {DfaIntervals(transition.Set)})");
                        }
                        if (transitions.Length > 0)
                        {
                            wl();
                        }
                    });
                wl(");");
            }
        }

        public string DfaSet(Integers set)
        {
            return $"new {DfaSetClass}({DfaIntervals(set)})";
        }

        private string DfaIntervals(Integers set)
        {
            return string.Join(", ", set.GetIntervals().Select(i => $"new {DfaIntervalClass}({i.Min}, {i.Max})"));
        }
    }
}
