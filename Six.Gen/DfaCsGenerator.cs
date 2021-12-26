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
            foreach (var rule in Grammar.Rules.Where(r => r.DFA != null))
            {
                Create(rule.DfaId(), rule.DFA!);
            }
        }

        public void Init()
        {
            foreach (var rule in Grammar.Rules.Where(r => r.DFA != null))
            {
                wl($"{rule.RuleId()}.Set({rule.DfaId()});");
            }
        }

        public void Declare()
        {
            foreach (var rule in Grammar.Rules.Where(r => r.DFA != null))
            {
                wl($"private {DfaClass} {rule.DfaId()} = new {DfaClass}({rule.Name.CsString()});");
            }
        }

        private void Create(string name, FA dfa)
        {
            wl($"{name}.Set(");
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

#if true
                indent(
                    $"{name}.States[{i}].Set(",
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
                            w($"new {DfaTransClass}({name}.States[{transition.TargetId}], {DfaIntervals(transition.Set)})");
                        }
                        if (transitions.Length > 0)
                        {
                            wl();
                        }
                    });
                wl(");");
#else
                initializer($"{name}.States[{i}].Transitions = new {DfaTransClass}[]",
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
                            w($"new {DfaTransClass}({name}.States[{transition.TargetId}], {DfaIntervals(transition.Set)})");
                        }
                        if (transitions.Length > 0)
                        {
                            wl();
                        }
                    });
#endif
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
