using SixCC.Sdk.Automata;
using SixCC.Writing;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable CA2252 // This API requires opting into preview features

namespace SixCC.Sdk.Earley
{
    public class CoreNode
    {
        public static int IdCounter;

        public CoreNode(NodeKey key, Extend extend)
        {
            Key = key;
            Extend = extend;
            Id = ++IdCounter;
        }

        public NodeKey Key { get; }
        public Extend Extend { get; }
        public int Start => Extend.Start;
        public int Next => Extend.Next;
        public int Id { get; }

        public List<CoreNode?> Children = new();
    }

    public class SymbolNode : CoreNode
    {
        public SymbolNode(NodeKey key, Extend extend, DFA rule)
            : base(key, extend)
        {
            Rule = rule;
        }

        public DFA Rule { get; }
        public string Symbol => Rule.Symbol;

        public override string ToString()
        {
            return $"[{Id}]{Symbol}<{Start},{Next}>";
        }
    }

    public class TerminalNode : SymbolNode
    {
        public TerminalNode(NodeKey key, Extend extend, DFA rule)
            : base(key, extend, rule)
        {
        }

        public override string ToString()
        {
            return $"terminal: {base.ToString()}";
        }
    }

    public class NonterminalNode : SymbolNode
    {
        public NonterminalNode(NodeKey key, Extend extend, DFA rule)
            : base(key, extend, rule)
        {
        }

        public override string ToString()
        {
            return $"nonterminal: {base.ToString()}";
        }
    }

    public class IntermediateNode : SymbolNode
    {
        public IntermediateNode(NodeKey key, Extend extend, DFA rule)
            : base(key, extend, rule)
        {
        }

        public override string ToString()
        {
            return $"intermediate: {base.ToString()}";
        }
    }

    public class RootNode : CoreNode
    {
        public RootNode(Extend extend)
            : base(new NodeKey(), extend)
        {
        }
    }

    public class PackedNode : CoreNode
    {
        public PackedNode(Extend extend, CoreNode? left, CoreNode right)
            : base(new NodeKey(), extend)
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
            return $"({State},{Start},{Next})";
        }

        public static bool operator ==(NodeKey left, NodeKey right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(NodeKey left, NodeKey right)
        {
            return !(left == right);
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
            var root = new RootNode(new Extend(Chart.First.ID, Chart.Last.ID));
            
            foreach (var item in Chart.Results())
            {
                Debug.Assert(item.IsFinal);
                Debug.Assert(item.Dfa == Automaton.Start);

                root.Children.Add(Build(item)!);
            }

            return root;
        }

        private CoreNode Add(NodeKey key, CoreNode node)
        {
            items.Add(key, node);
            return node;
        }

        private PackedNode BuildPacked(FromTransition back)
        {
            var origin = back.Origin;
            var finished = back.Finished;

            if (finished.IsTerminal)
            {

            }
            throw new NotImplementedException();
        }

        private CoreNode? Build(EarleyItem item)
        {
            var key = new NodeKey(item);

            if (!items.TryGetValue(key, out var node))
            {
                if (item.Dfa.IsTerminal)
                {
                    node = Add(key, new TerminalNode(key, item.Extend, item.Dfa));
                }
                else
                {
                    if (item.IsFinal)
                    {
                        Debug.Assert(item.From.Count >= 0);
                        node = Add(key, new NonterminalNode(key, item.Extend, item.Dfa));

                        if (item.From.Count == 0)
                        {
                            return node;
                        }
                    }
                    else
                    {
                        Debug.Assert(item.From.Count > 0);
                        node = Add(key, new IntermediateNode(key, item.Extend, item.Dfa));
                    }

                    foreach (var from in item.From)
                    {
                        var finished = from.Finished;
                        var origin = from.Origin;

                        var right = Build(finished)!;
                        Debug.Assert(right != null);
                        CoreNode? left = null;
                        if (finished != origin)
                        {
                            left = Build(origin);
                        }

                        var packed = new PackedNode(from.Extend, left, right);
                        node.Children.Add(packed);
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
