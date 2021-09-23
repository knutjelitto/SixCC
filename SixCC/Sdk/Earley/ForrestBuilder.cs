using SixCC.Sdk.Automata;
using SixCC.Writing;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CA2252 // This API requires opting into preview features

namespace SixCC.Sdk.Earley
{
    public class CoreNode
    {
        public static int IdCounter;

        public CoreNode(NodeKey key, int start, int next)
        {
            Key = key;
            Start = start;
            Next = next;
            Id = ++IdCounter;
        }

        public NodeKey Key { get; }
        public int Start { get; }
        public int Next { get; }
        public int Id { get; }

        public List<CoreNode?> Children = new();
    }

    public class SymbolNode : CoreNode
    {
        public SymbolNode(NodeKey key, int start, int next, DFA rule)
            : base(key, start, next)
        {
            Rule = rule;
        }

        public Automata.DFA Rule { get; }
        public string Symbol => Rule.Symbol;

        public override string ToString()
        {
            return $"[{Id}]{Symbol}<{Start},{Next}>";
        }
    }

    public class TerminalNode : SymbolNode
    {
        public TerminalNode(NodeKey key, int start, int next, DFA rule)
            : base(key, start, next, rule)
        {
        }

        public override string ToString()
        {
            return $"terminal: {base.ToString()}";
        }
    }

    public class NonterminalNode : SymbolNode
    {
        public NonterminalNode(NodeKey key, int start, int next, DFA rule)
            : base(key, start, next, rule)
        {
        }

        public override string ToString()
        {
            return $"nonterminal: {base.ToString()}";
        }
    }

    public class IntermediateNode : SymbolNode
    {
        public IntermediateNode(NodeKey key, int start, int next, DFA rule)
            : base(key, start, next, rule)
        {
        }

        public override string ToString()
        {
            return $"intermediate: {base.ToString()}";
        }
    }

    public class RootNode : CoreNode
    {
        public RootNode(int start, int next)
            : base(new NodeKey(), start, next)
        {
        }
    }

    public class PackedNode : CoreNode
    {
        public PackedNode(int start, int next, CoreNode? left, CoreNode right)
            : base(new NodeKey(), start, next)
        {
            Debug.Assert(right != null);
            Children.Add(left);
            Children.Add(right);
        }
        public CoreNode? Left => Children[0];
        public CoreNode Right => Children[1]!;
    }

    public struct NodeKey
    {
        public NodeKey(EarleyItem item)
            : this(item.Dfa.ID, item.State.ID, item.OriginSet.ID, item.Set.ID)
        {
        }

        public NodeKey(int dfa, int state, int start, int next)
        {
            Dfa = dfa;
            State = state;
            Start = start;
            Next = next;
        }

        public int Dfa { get; }
        public int State { get; }
        public int Start { get; }
        public int Next { get; }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is NodeKey other && Dfa == other.Dfa && State == other.State && Start == other.Start && Next == other.Next;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Dfa, State, Start, Next);
        }

        public override string ToString()
        {
            return $"({Dfa},{State},{Start},{Next})";
        }
    }

    public class ForrestBuilder
    {
        private readonly Dictionary<NodeKey, CoreNode?> items = new();

        public ForrestBuilder(Writer writer, EarleyChart chart)
        {
            Writer = writer;
            Chart = chart;
        }

        public Writer Writer { get; }
        public EarleyChart Chart { get; }
        public Automaton Automaton => Chart.Automaton;

        public CoreNode Build()
        {
            var root = new RootNode(Chart.First.ID, Chart.Last.ID);
            
            foreach (var item in Chart.Results())
            {
                Debug.Assert(item.IsFinal);
                Debug.Assert(item.Dfa == Automaton.Start);

                root.Children.Add(Build(item)!);
            }

            return root;
        }

        private CoreNode? Build(EarleyItem item)
        {
            var key = new NodeKey(item);

            if (key.ToString() == "(0,1,0,0)")
            {
                Debug.Assert(true);
            }

            if (!items.TryGetValue(key, out var node))
            {
                if (item.Dfa.IsTerminal)
                {
                    node = new TerminalNode(key, item.OriginSet.ID, item.Set.ID, item.Dfa);
                    items.Add(key, node);
                }
                else
                {
                    if (item.From.Count == 0)
                    {
                        if (item.IsFinal)
                        {
                            node = new NonterminalNode(key, item.OriginSet.ID, item.Set.ID, item.Dfa);
                            items.Add(key, node);
                        }
                        else
                        {
                            Debug.Assert(item.State.ID == 0);

                            node = null;
                        }
                    }
                    else
                    {
                        node = new IntermediateNode(key, item.OriginSet.ID, item.Set.ID, item.Dfa);
                        items.Add(key, node);

                        foreach (var from in item.From)
                        {
                            var start = from.Origin.Set.ID;
                            var next = from.Finished.Set.ID;
                            var left = Build(from.Finished);
                            if (left == null)
                            {
                                Debug.Assert(true);
                            }
                            var right = Build(from.Origin)!;
                            Debug.Assert(right != null);
                            if (left == right)
                            {
                                left = null;
                            }

                            var packed = new PackedNode(start, next, left, right);
                            node.Children.Add(packed);
                        }
                    }
                }
            }

            return node;
        }

        private bool IsLinear(EarleyItem item)
        {
            if (item.From != null && item.From.Count == 1)
            {
                var from = item.From.First();
                if (Build(from.Finished) == null)
                {
                    return true;
                }
            }
            return false;            
        }
    }
}
