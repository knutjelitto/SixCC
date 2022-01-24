// <generated from="D:\\Six\\SixBot\\Grammars\\T6.six" at="23.01.2022 06:31:45" />

using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T6Tree;

namespace GeneratedParser
{
    public partial class T6Parser : Parser
    {
        public T6Parser()
            : base("T6", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[12])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _T = new PlainRule(this, 3, "T") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _E = new PlainRule(this, 4, "E") { Builder = nodes => nodes[0] };
                /*   5 EofOp            */ __Matchers[5] = new Eof(this, 5, "<eof>") { Creator = node => new REof(node) };
                /*   6 SeqOp            */ __Matchers[6] = new Seq(this, 6, "_(>T,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*   7 PlusOp           */ __Matchers[7] = new Plus(this, 7, "+(>E)") { Builder = nodes => new CT(nodes) };
                /*   8 StringOp         */ __Matchers[8] = new String(this, 8, "'id'", "id") { Creator = node => new RLiteral(node) };
                /*   9 StringOp         */ __Matchers[9] = new String(this, 9, "'x'", "x") { Creator = node => new RLiteral(node) };
                /*  10 OptionalOp       */ __Matchers[10] = new Optional(this, 10, "?('x')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /*  11 SeqOp            */ __Matchers[11] = new Seq(this, 11, "_('id',?('x'))") { Builder = nodes => new CE(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[6]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _T.Set(__Matchers[7]);
                /*   4 PlainRuleOp      */ _E.Set(__Matchers[11]);
                /*   6 SeqOp            */ __Matchers[6].Set(_T, __Matchers[5]);
                /*   7 PlusOp           */ __Matchers[7].Set(_E);
                /*  10 OptionalOp       */ __Matchers[10].Set(__Matchers[9]);
                /*  11 SeqOp            */ __Matchers[11].Set(__Matchers[8], __Matchers[10]);

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
            }

            private PlainRule _T;
            private PlainRule _E;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
        }
    }

    public partial class T6Tree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICT : IRNode {}
        public interface ICE : IRNode {}

        public partial class CXStart : RSequence, ICXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public CT T => Get<CT>(0);
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

        public partial class CT : RPlus<CE>, ICT
        {
            public CT(params RNode[] children) : base(children) {}
        }

        public partial class CE : RSequence, ICE
        {
            public CE(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<RLiteral> Literal2Optional => Get<ROptional<RLiteral>>(1);
        }

        public partial class DynamicT6Visitor : DynamicVisitor
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

            protected virtual void Visit(CT element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CE element)
            {
                DefaultImplementation(element);
            }
        }
    }
}
