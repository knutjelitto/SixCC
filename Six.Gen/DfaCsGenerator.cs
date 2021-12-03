using Six.Gen.Ebnf;
using Six.Rex;

namespace Six.Gen
{
    internal class DfaCsGenerator : CsGenerator
    {
        const string DfaClass = "Dfa";

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
                wl($"private {DfaClass} {rule.DfaId()};");
            }
        }

        private void Create(string name, FA dfa)
        {
            wl($"{name} = new Dfa(");
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

                    var final = state.Final ? "true" : "false";
                    w($"new DfaState({state.Id}, {final}, {state.Payload})");
                }
                wl();
            });
            wl($");");
            for (var i = 0; i < dfa.States.Count; i++)
            {
                var state = dfa.States[i];
                var transitions = state.TerminalTransitions.ToArray();

                initializer($"{name}.States[{i}].Transitions = new DfaTrans[]",
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
                            w($"new DfaTrans({name}.States[{transition.TargetId}], new DfaSet({Intervals(transition)}))");
                        }
                        wl();
                    });
            }
        }

        private string Intervals(Transition transition)
        {
            return string.Join(", ", transition.Set.GetIntervals().Select(i => $"new Interval({i.Min}, {i.Max})"));
        }
    }
}
