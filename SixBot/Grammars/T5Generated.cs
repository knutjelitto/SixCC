// <generated from="D:\\Six\\SixBot\\Grammars\\T5.six" at="20.01.2022 17:29:53" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T5Tree;

namespace GeneratedParser
{
    public partial class T5Parser : Parser
    {
        public T5Parser()
            : base("T5", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[16])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _S = new PlainRule(this, 3, "S") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _E = new PlainRule(this, 4, "E") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _R = new PlainRule(this, 5, "R") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _P = new PlainRule(this, 6, "P") { Creator = node => new CP(node) };
                /*   7 EofOp            */ __Matchers[7] = new Eof(this, 7, "<eof>") { Creator = node => new REof(node) };
                /*   8 SeqOp            */ __Matchers[8] = new Seq(this, 8, "_(>S,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*   9 StarOp           */ __Matchers[9] = new Star(this, 9, "*(>E)") { Builder = nodes => new CS(nodes) };
                /*  10 AltOp            */ __Matchers[10] = new Alt(this, 10, "alt(>R|>P)") { Builder = nodes => nodes[0] };
                /*  11 StringOp         */ __Matchers[11] = new String(this, 11, "'..'", "..") { Creator = node => new RString(node) };
                /*  12 SeqOp            */ __Matchers[12] = new Seq(this, 12, "_(>P,'..',>P)") { Builder = nodes => new CR(nodes) };
                /*  13 StringOp         */ __Matchers[13] = new String(this, 13, "'e'", "e") { Creator = node => new RString(node) };
                /*  14 StringOp         */ __Matchers[14] = new String(this, 14, "'.'", ".") { Creator = node => new RString(node) };
                /*  15 AltOp            */ __Matchers[15] = new Alt(this, 15, "alt('e'|'.')") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[8]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _S.Set(__Matchers[9]);
                /*   4 PlainRuleOp      */ _E.Set(__Matchers[10]);
                /*   5 PlainRuleOp      */ _R.Set(__Matchers[12]);
                /*   6 PlainRuleOp      */ _P.Set(__Matchers[15]);
                /*   8 SeqOp            */ __Matchers[8].Set(_S, __Matchers[7]);
                /*   9 StarOp           */ __Matchers[9].Set(_E);
                /*  10 AltOp            */ __Matchers[10].Set(_R, _P);
                /*  12 SeqOp            */ __Matchers[12].Set(_P, __Matchers[11], _P);
                /*  15 AltOp            */ __Matchers[15].Set(__Matchers[13], __Matchers[14]);

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

            private PlainRule _S;
            private PlainRule _E;
            private PlainRule _R;
            private PlainRule _P;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
        }
    }

    public partial class T5Tree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface IS {}
        public interface IE {}
        public interface IR : IE {}
        public interface IP : IE {}

        public partial class CXStart : RSequence, IXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public CS S => Get<CS>(0);
            public REof Eof => Get<REof>(1);
        }

        public partial class CXWhitespace : RString, IXWhitespace
        {
            public CXWhitespace(params Node[] children) : base(children) {}
        }

        public partial class CXKeywords : RString, IXKeywords
        {
            public CXKeywords(params Node[] children) : base(children) {}
        }

        public partial class CS : RStar<IE>, IS
        {
            public CS(params RNode[] children) : base(children) {}
        }

        public partial class CR : RSequence, IR
        {
            public CR(params RNode[] children) : base(children) {}

            public CP P => Get<CP>(0);
            public RString String => Get<RString>(1);
            public CP P2 => Get<CP>(2);
        }

        public partial class CP : RString, IP
        {
            public CP(params Node[] children) : base(children) {}
        }

        public partial class DynamicT5Visitor : DynamicVisitor
        {
            public override void Walk(RNode node)
            {
                Visit((dynamic)node);
            }

            protected virtual void Visit(CXStart element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CXWhitespace element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CXKeywords element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CS element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CR element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CP element)
            {
                VisitChildren(element);
            }
        }
    }
}
