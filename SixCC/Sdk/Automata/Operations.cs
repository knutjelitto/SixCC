using SixCC.Runtime.Commons;
using SixCC.Sdk.Commons;

namespace SixCC.Sdk.Automata
{
    public static class Operations
    {
        public static DFA Complement(DFA dfa)
        {
            return Difference(dfa.Factory.Universe().ToDfa(), dfa);
        }

        public static DFA Complete(DFA dfa)
        {
            EnsureDfa(dfa);

            State? sink = null;

            foreach (var state in dfa.States)
            {
                var rest = dfa.Factory.AnySet;

                foreach (var transition in state.Transitions)
                {
                    rest = rest.ExceptWith(transition.Set);
                }

                if (!rest.IsEmpty)
                {
                    if (sink == null)
                    {
                        sink = new State(dfa.Factory);
                        sink.AddTerminalTransition(dfa.Factory.AnySet, sink);
                    }

                    state.AddTerminalTransition(IntegerSet.From(rest), sink);
                }
            }

            if (sink != null)
            {
                sink.ID = dfa.States.Count;
                dfa.States.Add(sink);
            }

            EnsureComplete(dfa);

            return dfa;
        }

        public static DFA Union(DFA dfa1, DFA dfa2)
        {
            return CrossBuilder.Build(dfa1, dfa2, (s1, s2) => s1.IsFinal || s2.IsFinal);
        }

        public static DFA Intersection(DFA dfa1, DFA dfa2)
        {
            return CrossBuilder.Build(dfa1, dfa2, (s1, s2) => s1.IsFinal && s2.IsFinal);
        }

        public static DFA Difference(DFA dfa1, DFA dfa2)
        {
            return CrossBuilder.Build(dfa1, dfa2, (s1, s2) => s1.IsFinal && !s2.IsFinal);
        }

        private static class CrossBuilder
        {
            public static DFA Build(DFA dfa1, DFA dfa2, Func<State, State, bool> isFinal)
            {
                Debug.Assert(dfa1.Factory == dfa2.Factory);

                var factory = dfa1.Factory;

                EnsureDfa(dfa1);
                EnsureDfa(dfa2);

                dfa1 = Complete(dfa1);
                dfa2 = Complete(dfa2);

                EnsureComplete(dfa1);
                EnsureComplete(dfa2);

                var cross = new State[dfa1.States.Count, dfa2.States.Count];

                var t1 = dfa1.States.Select(s => GetTransitions(factory, s)).ToList();
                var t2 = dfa2.States.Select(s => GetTransitions(factory, s)).ToList();

                for (var n1 = 0; n1 < dfa1.States.Count; n1 += 1)
                {
                    var state1 = dfa1.States[n1];

                    for (var n2 = 0; n2 < dfa2.States.Count; n2 += 1)
                    {
                        var state2 = dfa2.States[n2];

                        var newState = new State(factory, isFinal(state1, state2));
                        if (state1.IsPayload && !state2.IsPayload)
                        {
                            newState.AddPayload(state1);
                        }
                        else if (!state1.IsPayload && state2.IsPayload)
                        {
                            newState.AddPayload(state2);
                        }
                        else if (state1.IsPayload && state2.IsPayload)
                        {
                            Debug.Assert(true);

                            if (state1.Transitions.Count == 1 && state1.Transitions[0].Set == dfa1.Factory.AnySet)
                            {
                                newState.AddPayload(state1);
                            }
                            else if (state2.Transitions.Count == 1 && state2.Transitions[0].Set == dfa1.Factory.AnySet)
                            {
                                newState.AddPayload(state2);
                            }
                            else
                            {
                                if (state1.Payload > state2.Payload)
                                {
                                    newState.AddPayload(state1);
                                }
                                else
                                {
                                    newState.AddPayload(state2);
                                }
                                //throw new InternalException("missing tie break");
                            }
                        }

                        cross[n1, n2] = newState;
                    }
                }

                for (var n1 = 0; n1 < dfa1.States.Count; n1 += 1)
                {
                    for (var n2 = 0; n2 < dfa2.States.Count; n2 += 1)
                    {
                        var state = cross[n1, n2];
                        var ctranses = GetMerge(factory, t1[n1], t2[n2]);
                        foreach (var ctrans in ctranses)
                        {
                            state.AddTerminalTransition(IntegerSet.From(ctrans.Range.Min, ctrans.Range.Max), cross[ctrans.Target1, ctrans.Target2]);
                        }
                    }
                }

                var dfa = DFA.From(dfa1.Factory, cross[0, 0]);

                EnsureComplete(dfa);

                return dfa;
            }

            private static List<CrossTrans> GetMerge(Factory factory, List<Trans> l1, List<Trans> l2)
            {
                Debug.Assert(l1.Count > 0 && l2.Count > 0);

                var i1 = 0;
                var i2 = 0;

                var t1 = l1[i1++];
                var r1 = t1.Range;
                var t2 = l2[i2++];
                var r2 = t2.Range;

                var result = new List<CrossTrans>();

                void Add(Range range)
                {
                    result.Add(new CrossTrans { Range = range, Target1 = t1.Target, Target2 = t2.Target });
                }

                for (; ; )
                {
                    Debug.Assert(r1.Min == r2.Min);

                    if (r1.Max == r2.Max)
                    {
                        Add(r1);

                        if (i1 == l1.Count && i2 == l2.Count)
                        {
                            break;
                        }
                        Debug.Assert(i1 < l1.Count && i2 < l2.Count);
                        t1 = l1[i1++];
                        r1 = t1.Range;
                        t2 = l2[i2++];
                        r2 = t2.Range;
                    }
                    else if (r1.Max < r2.Max)
                    {
                        Add(r1);

                        Debug.Assert(i1 < l1.Count);
                        r2 = new Range(r1.Max + 1, r2.Max);
                        t1 = l1[i1++];
                        r1 = t1.Range;
                    }
                    else if (r2.Max < r1.Max)
                    {
                        Add(r2);

                        Debug.Assert(i2 < l2.Count);
                        r1 = new Range(r2.Max + 1, r1.Max);
                        t2 = l2[i2++];
                        r2 = t2.Range;
                    }
                }

                Debug.Assert(result[0].Range.Min == factory.Min);
                Debug.Assert(result[^1].Range.Max == factory.Max);
                for (int i = 1; i < result.Count; ++i)
                {
                    Debug.Assert(result[i - 1].Range.Max + 1 == result[i].Range.Min);
                }

                return result;
            }

            private static List<Trans> GetTransitions(Factory factory, State state)
            {
                var result = new List<Trans>();
                foreach (var transition in state.Transitions)
                {
                    foreach (var (min, max) in transition.Set.GetIntervals())
                    {
                        result.Add(new Trans { Range = new Range(min, max), Target = transition.Target.ID });
                    }
                }

                result = result.OrderBy(t => t.Range.Min).ToList();

                Debug.Assert(result[0].Range.Min == factory.Min);
                Debug.Assert(result[^1].Range.Max == factory.Max);
                for (int i = 1; i < result.Count; ++i)
                {
                    Debug.Assert(result[i - 1].Range.Max + 1 == result[i].Range.Min);
                }

                return result;
            }

            [DebuggerDisplay("{DD()}")]
            private struct Range
            {
                public Range(int min, int max)
                {
                    Min = min;
                    Max = max;
                }
                public readonly int Min;
                public readonly int Max;

                public string DD()
                {
                    return $"[{CharRep.InRange(Min)}-{CharRep.InRange(Max)}]";
                }
            }

            [DebuggerDisplay("{DD()}")]
            private class Trans
            {
                public Range Range;
                public int Target;

                public string DD()
                {
                    return $"{Range.DD()}->{Target}";
                }
            }

            [DebuggerDisplay("{DD()}")]
            private class CrossTrans
            {
                public Range Range;
                public int Target1;
                public int Target2;

                public string DD()
                {
                    return $"{Range.DD()}->({Target1},{Target2})";
                }
            }
        }

        public static DFA Minimize(DFA dfa)
        {
            return Minimizer.Minimize(dfa);
        }

        private class Minimizer
        {
            public static DFA Minimize(DFA dfa)
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

                bool more = true;
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
                                            var si = ti.Target.ID;
                                            var sj = tj.Target.ID;
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
                                            if (table[si, sj])
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

                var combines = new List<StatePair>();

                for (var i = 0; i < n; ++i)
                {
                    for (var j = 0; j < n; ++j)
                    {
                        if (i >= j) continue;

                        if (!table[i, j])
                        {
                            combines.Add(new StatePair { s[i], s[j] });
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

                var mini = DFA.From(dfa.Factory, dfa.Start);

                mini = MergeTransitions(mini);

                return mini;
            }

            private static DFA MergeTransitions(DFA dfa)
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

        public static DFA RemoveDead(DFA dfa)
        {
            EnsureDfa(dfa);

            var closures = new Dictionary<State, HashSet<State>>();

            void Initial(State state)
            {
                var set = new HashSet<State>() { state };

                foreach (var transition in state.Transitions)
                {
                    set.Add(transition.Target);
                }

                closures.Add(state, set);
            }

            bool Close(State state)
            {
                var set = closures[state];

                var before = set.Count;

                foreach (var buddy in set.Where(s => s != state).ToList())
                {
                    var buddySet = closures[buddy];

                    set.UnionWith(buddySet);
                }

                var after = set.Count;

                return after > before;
            }

            foreach (var state in dfa.States)
            {
                Initial(state);
            }

            var added = true;
            while (added)
            {
                added = false;

                foreach (var state in dfa.States)
                {
                    added = added || Close(state);
                }
            }

            var dead = new HashSet<State>();

            foreach (var state in dfa.States)
            {
                var set = closures[state];

                if (set.All(s => !s.IsFinal))
                {
                    dead.UnionWith(set);
                }
            }

            return RemoveDead(dfa, dead);
        }

        private static DFA RemoveDead(DFA dfa, HashSet<State> dead)
        {
            if (dead.Count == 0)
            {
                return dfa;
            }

            var map = new Dictionary<State, State>();

            return DFA.From(dfa.Factory, Map(dfa.Start));

            State Map(State state)
            {
                if (!map.TryGetValue(state, out var mapped))
                {
                    mapped = new State(dfa.Factory, state.IsFinal);
                    mapped.AddPayload(state);
                    map.Add(state, mapped);

                    foreach (var transition in state.Transitions)
                    {
                        if (!dead.Contains(transition.Target))
                        {
                            mapped.AddTerminalTransition(transition.Set, Map(transition.Target));
                        }
                    }
                }

                return mapped;
            }
        }

        public static DFA ToDfa(NFA nfa)
        {
            var once = new UniqueQueue<Closure>();
            var start = new Closure(nfa.Factory, nfa.Start, nfa.Final);
            once.Enqueue(start);

            while (once.Count > 0)
            {
                var closure = once.Dequeue();
                var transitions = closure.UnambiguateTransitions();

                foreach (var transition in transitions)
                {
                    var terminal = transition.Key;
                    var targets = transition.Value;
                    var targetClosure = new Closure(nfa.Factory, targets, nfa.Final);
                    once.Enqueue(targetClosure, out targetClosure);
                    var target = targetClosure.DfaState;

                    closure.DfaState.AddTerminalTransition(IntegerSet.From(terminal), target);
                }
            }

            var dfa = DFA.From(nfa.Factory, start.DfaState);

            EnsureDfa(dfa);

            return dfa;
        }

        private class Closure
        {
            public Closure(Factory factory, State state, State end)
                : this(factory, Enumerable.Repeat(state, 1), end)
            {
            }

            public Closure(Factory factory, IEnumerable<State> states, State end)
            {
                Factory = factory;

                var set = new HashSet<State>();
                var isFinal = false;

                foreach (var state in states)
                {
                    foreach (var closureState in state.EpsilonClosure())
                    {
                        if (closureState.ID == end.ID)
                        {
                            Debug.Assert(true);
                        }
                        if (closureState.Equals(end))
                        {
                            isFinal = true;
                        }

                        set.Add(closureState);
                    }
                }

                Set = set;
                DfaState = new State(Factory, isFinal);
                hashCode = Set.Hash();
            }

            public Dictionary<IntegerSet, HashSet<State>> UnambiguateTransitions()
            {
                var transitions = new Dictionary<IntegerSet, HashSet<State>>();

                void Handle(IntegerSet terminal, State target)
                {
                    HandleMore(terminal, Enumerable.Repeat(target, 1));
                }

                void HandleMore(IntegerSet added, IEnumerable<State> targets)
                {
                    var already = transitions.Keys.FirstOrDefault(t => t.Overlaps(added));

                    if (already == null)
                    {
                        transitions.Add(added, new HashSet<State>(targets));
                        return;
                    }

                    if (already.Equals(added))
                    {
                        transitions[already].AddRange(targets);
                        return;
                    }

                    var alreadyTransitions = transitions[already];

                    var newAlready = already / added;
                    var newAdded = added / already;
                    var intersection = (already + added) / (newAlready + newAdded);

                    if (!newAlready.IsEmpty)
                    {
                        transitions.Remove(already);
                        HandleMore(newAlready, alreadyTransitions);
                    }
                    if (!intersection.IsEmpty)
                    {
                        HandleMore(intersection, alreadyTransitions.Concat(targets));
                    }
                    if (!newAdded.IsEmpty)
                    {
                        HandleMore(newAdded, targets);
                    }
                }

                foreach (var state in Set)
                {
                    foreach (var transition in state.TerminalTransitions)
                    {
                        Handle(transition.Set, transition.Target);
                    }
                }

                EnsureDistinct(transitions);

                return transitions;
            }

            public HashSet<State> Set { get; }

            public State DfaState { get; }
            public Factory Factory { get; }

            public override bool Equals(object? obj)
            {
                return obj is Closure other && Set.SetEquals(other.Set);
            }

            public override int GetHashCode() => hashCode;


            [Conditional("DEBUG")]
            private static void EnsureDistinct(Dictionary<IntegerSet, HashSet<State>> transitions)
            {
                var terminals = transitions.Keys.ToList();
                var i = 0;
                while (i < terminals.Count)
                {
                    var j = i + 1;
                    while (j < terminals.Count)
                    {
                        if (terminals[i].Overlaps(terminals[j]))
                        {
                            throw new Exception($"terminal set {terminals[i]} and {terminals[j]} overlap");
                        }
                        j += 1;
                    }
                    i += 1;
                }
            }

            private readonly int hashCode;
        }
        public static NFA ToNfa(DFA dfa)
        {
            EnsureDfa(dfa);

            var nfaFinal = new State(dfa.Factory);

            foreach (var final in dfa.Finals)
            {
                final.AddEpsilonTransition(nfaFinal);
                final.AddPayload(nfaFinal);
            }

            nfaFinal.ID = dfa.States.Count;
            foreach (var state in dfa.States)
            {
                state.IsFinal = false;
            }

            return NFA.From(dfa.Factory, dfa.Start, nfaFinal);
        }

        [Conditional("DEBUG")]
        private static void EnsureComplete(DFA dfa)
        {
            EnsureDfa(dfa);

            foreach (var state in dfa.States)
            {
                var all = new IntegerSet();
                var sum = 0;
                foreach (var transition in state.Transitions)
                {
                    sum += transition.Set.Cardinality;
                    all.Add(transition.Set);
                }
                if (all.Cardinality != dfa.Factory.AnySet.Cardinality)
                {
                    throw new Exception("DFA: incomplete transition set (wannabe DFA is not `complete´)");
                }
                if (sum != all.Cardinality)
                {
                    throw new Exception("DFA: overlapping transitions (wannabe DFA is not `deterministic´)");
                }
            }
        }

        [Conditional("DEBUG")]
        private static void EnsureDistinctTransitions(State state)
        {
            foreach (var (Left, Right) in state.Transitions.GlidePairWise())
            {
                if (Left.Set.Overlaps(Right.Set))
                {
                    throw new Exception("DFA: some transitions overlap");
                }
            }

            var i = 0;
            while (i < state.Transitions.Count)
            {
                var trans1 = state.Transitions[i];

                if (trans1.Set.IsEmpty)
                {
                    throw new Exception("DFA: epsilon transition");
                }
                var j = i + 1;
                while (j < state.Transitions.Count)
                {
                    var trans2 = state.Transitions[j];
                    if (trans1.Set.Overlaps(trans2.Set))
                    {
                        throw new Exception("DFA: some transitions overlap");
                    }
                    j += 1;
                }
                i += 1;
            }
        }

        [Conditional("DEBUG")]
        private static void EnsureDefiniteTransitions(State state)
        {
            foreach (var transition in state.Transitions)
            {
                if (transition.Set.IsEmpty)
                {
                    throw new Exception("DFA: epsilon transition");
                }
            }
        }

        [Conditional("DEBUG")]
        private static void EnsureDfaTransitions(DFA dfa)
        {
            foreach (var state in dfa.States)
            {
                EnsureDfaTransition(state);
            }
        }

        [Conditional("DEBUG")]
        private static void EnsureDfaTransition(State state)
        {
            EnsureDistinctTransitions(state);
            EnsureDefiniteTransitions(state);
        }

        [Conditional("DEBUG")]
        private static void EnsureDfa(DFA dfa)
        {
            if (!dfa.Finals.Any())
            {
                throw new Exception("DFA: no final state");
            }
            if (dfa.States.Count < 1)
            {
                throw new Exception("DFA: at least on state");
            }
            for (var i = 0; i < dfa.States.Count; ++i)
            {
                if (dfa.States[i].ID != i)
                {
                    throw new Exception("DFA: not properly numbered");
                }
            }
            EnsureDfaTransitions(dfa);
        }
    }
}
