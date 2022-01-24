// <generated from="D:\\Six\\SixBot\\Grammars\\T3.six" at="23.01.2022 06:31:44" />

using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T3Tree;

namespace GeneratedParser
{
    public partial class T3Parser : Parser
    {
        public T3Parser()
            : base("T3", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[11])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _C = new PlainRule(this, 3, "C") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _add = new PlainRule(this, 4, "add") { Builder = nodes => nodes[0] };
                /*   5 DfaRuleOp        */ __Matchers[5] = _id = new DfaRule(this, 5, "id") { Creator = node => new CId(node) };
                /*   6 EofOp            */ __Matchers[6] = new Eof(this, 6, "<eof>") { Creator = node => new REof(node) };
                /*   7 SeqOp            */ __Matchers[7] = new Seq(this, 7, "_(>C,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*   8 AltOp            */ __Matchers[8] = new Alt(this, 8, "alt(>add|>id)") { Builder = nodes => nodes[0] };
                /*   9 StringOp         */ __Matchers[9] = new String(this, 9, "'+'", "+") { Creator = node => new RLiteral(node) };
                /*  10 SeqOp            */ __Matchers[10] = new Seq(this, 10, "_(>C,'+',>C)") { Builder = nodes => new CAdd(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[7]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _C.Set(__Matchers[8]);
                /*   4 PlainRuleOp      */ _add.Set(__Matchers[10]);
                /*   5 DfaRuleOp        */ _id.Set(_id_DFA);
                /*   7 SeqOp            */ __Matchers[7].Set(_C, __Matchers[6]);
                /*   8 AltOp            */ __Matchers[8].Set(_add, _id);
                /*  10 SeqOp            */ __Matchers[10].Set(_C, __Matchers[9], _C);

                __Whitespace_DFA.Set(
                    new DfaState(0, true)
                );
                __Whitespace_DFA.States[0].Set(
                );
                __Keywords_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Keywords_DFA.States[0].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(97, 122))
                );
                __Keywords_DFA.States[1].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(97, 122))
                );
                _id_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                _id_DFA.States[0].Set(
                    new DfaTrans(_id_DFA.States[1], new DfaInterval(97, 122))
                );
                _id_DFA.States[1].Set(
                );
            }

            private PlainRule _C;
            private PlainRule _add;
            private DfaRule _id;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
            private Dfa _id_DFA = new Dfa("id");
        }
    }

    public partial class T3Tree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICC : IRNode {}
        public interface ICAdd : ICC {}
        public interface ICId : ICC {}

        public partial class CXStart : RSequence, ICXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public ICC C => Get<ICC>(0);
            public REof Eof => Get<REof>(1);
        }

        public partial class CXWhitespace : RToken, ICXWhitespace
        {
            public CXWhitespace(params Node[] children) : base(children) {}
        }

        public partial class CXKeywords : RToken, ICXKeywords
        {
            public CXKeywords(params Node[] children) : base(children) {}
        }

        public partial class CAdd : RSequence, ICAdd
        {
            public CAdd(params RNode[] children) : base(children) {}

            public ICC C => Get<ICC>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICC C2 => Get<ICC>(2);
        }

        public partial class CId : RToken, ICId
        {
            public CId(params Node[] children) : base(children) {}
        }

        public partial class DynamicT3Visitor : DynamicVisitor
        {
            public override void Walk(IRNode node)
            {
                Visit((dynamic)node);
            }

            protected virtual void Visit(CXStart element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CXWhitespace element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CXKeywords element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAdd element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CId element)
            {
                DefaultImplementation(element);
            }
        }
    }
}
