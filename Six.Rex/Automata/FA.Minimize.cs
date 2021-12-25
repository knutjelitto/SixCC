namespace Six.Rex
{
    public partial class FA
    {
        private static partial class Operations
        {
            public static FA Minimize(FA dfa)
            {
                return new Minimizer().Minimize(dfa);
            }

            private class Minimizer
            {
                public FA Minimize(FA dfa)
                {
                    EnsureDfa(dfa);
                    dfa = Complete(dfa);
                    EnsureComplete(dfa);

                    var s = dfa.States;
                    var n = s.Count;

                    var table = new bool[n, n];

                    for (var i = 0; i < n; ++i)
                    {
                        for (var j = 0; j < n; ++j)
                        {
                            if (i >= j) continue;

                            table[i, j] = s[i].IsFinal && !s[j].IsFinal ||
                                          !s[i].IsFinal && s[j].IsFinal ||
                                          s[i].IsFinal && s[j].IsFinal && s[i].Payload != s[j].Payload;
                        }
                    }

                    var more = true;
                    while (more)
                    {
                        more = false;
                        for (var i = 0; i < n; ++i)
                        {
                            for (var j = 0; j < n; ++j)
                            {
                                if (i >= j) continue;

                                if (!table[i, j])
                                {
                                    foreach (var ti in s[i].Transitions)
                                    {
                                        foreach (var tj in s[j].Transitions)
                                        {
                                            if (ti.Set.Overlaps(tj.Set))
                                            {
                                                var si = ti.Target.Id;
                                                var sj = tj.Target.Id;
                                                if (si == sj)
                                                {
                                                    continue;
                                                }
                                                if (si > sj)
                                                {
                                                    var tmp = si;
                                                    si = sj;
                                                    sj = tmp;

                                                    Debug.Assert(si < sj);
                                                }

                                                var before = more;
                                                if (table[si,sj])
                                                {
                                                    var isij = table[i, j];
                                                    more = more || !table[i, j];
                                                    if (!before && more)
                                                    {
                                                        Debug.Assert(true);
                                                    }
                                                    table[i, j] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    var combines = new List<StateSet>();

                    for (var i = 0; i < n; ++i)
                    {
                        for (var j = 0; j < n; ++j)
                        {
                            if (i >= j) continue;

                            if (!table[i,j])
                            {
                                combines.Add(new StateSet { s[i], s[j] });
                            }
                        }
                    }

                    var current = 0;
                    while (current < combines.Count)
                    {
                        for (var i = current + 1; i < combines.Count;)
                        {
                            if (combines[current].Overlaps(combines[i]))
                            {
                                combines[current].Add(combines[i]);
                                combines.RemoveAt(i);
                            }
                            else
                            {
                                i += 1;
                            }
                        }
                        current += 1;
                    }


                    foreach (var set in combines)
                    {
                        var premium = set.First();

                        var remove = set.Skip(1).ToList();

                        foreach (var state in s)
                        {
                            foreach (var transition in state.Transitions)
                            {
                                if (remove.Contains(transition.Target))
                                {
                                    transition.Retarget(premium);
                                }
                            }
                        }

                        EnsureDistinctTransitions(premium);
                    }

                    var mini = From(dfa.Start);

                    mini = MergeTransitions(mini);

                    return mini;
                }

                private FA MergeTransitions(FA dfa)
                {
                    foreach (var state in dfa.States)
                    {
                        //EnsureDfaTransition(state);

                        var i = 0;

                        while (i < state.Transitions.Count)
                        {
                            var j = i + 1;
                            while (j < state.Transitions.Count)
                            {
                                if (state.Transitions[i].Target.Equals(state.Transitions[j].Target))
                                {
                                    state.Transitions[i].Set.Add(state.Transitions[j].Set);
                                    state.Transitions.RemoveAt(j);
                                    continue;
                                }
                                j += 1;
                            }
                            i += 1;
                        }
                    }

                    return dfa;
                }
            }
        }
    }
}
