// <generated from="D:\\Six\\SixBot\\Grammars\\T1.six" at="20.01.2022 17:29:53" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T1Tree;

namespace GeneratedParser
{
    public partial class T1Parser : Parser
    {
        public T1Parser()
            : base("T1", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[17])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _S = new PlainRule(this, 3, "S") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _Abac = new PlainRule(this, 4, "Abac") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _Bbaa = new PlainRule(this, 5, "Bbaa") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _CbAc = new PlainRule(this, 6, "CbAc") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _A = new PlainRule(this, 7, "A") { Creator = node => new CA(node) };
                /*   8 EofOp            */ __Matchers[8] = new Eof(this, 8, "<eof>") { Creator = node => new REof(node) };
                /*   9 SeqOp            */ __Matchers[9] = new Seq(this, 9, "_(>S,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  10 AltOp            */ __Matchers[10] = new Alt(this, 10, "alt(>Abac|>Bbaa|>CbAc)") { Builder = nodes => nodes[0] };
                /*  11 StringOp         */ __Matchers[11] = new String(this, 11, "'b'", "b") { Creator = node => new RString(node) };
                /*  12 StringOp         */ __Matchers[12] = new String(this, 12, "'a'", "a") { Creator = node => new CA(node) };
                /*  13 StringOp         */ __Matchers[13] = new String(this, 13, "'c'", "c") { Creator = node => new RString(node) };
                /*  14 SeqOp            */ __Matchers[14] = new Seq(this, 14, "_('b','a','c')") { Builder = nodes => new CAbac(nodes) };
                /*  15 SeqOp            */ __Matchers[15] = new Seq(this, 15, "_('b','a','a')") { Builder = nodes => new CBbaa(nodes) };
                /*  16 SeqOp            */ __Matchers[16] = new Seq(this, 16, "_('b',>A,'c')") { Builder = nodes => new CCbac(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[9]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _S.Set(__Matchers[10]);
                /*   4 PlainRuleOp      */ _Abac.Set(__Matchers[14]);
                /*   5 PlainRuleOp      */ _Bbaa.Set(__Matchers[15]);
                /*   6 PlainRuleOp      */ _CbAc.Set(__Matchers[16]);
                /*   7 PlainRuleOp      */ _A.Set(__Matchers[12]);
                /*   9 SeqOp            */ __Matchers[9].Set(_S, __Matchers[8]);
                /*  10 AltOp            */ __Matchers[10].Set(_Abac, _Bbaa, _CbAc);
                /*  14 SeqOp            */ __Matchers[14].Set(__Matchers[11], __Matchers[12], __Matchers[13]);
                /*  15 SeqOp            */ __Matchers[15].Set(__Matchers[11], __Matchers[12], __Matchers[12]);
                /*  16 SeqOp            */ __Matchers[16].Set(__Matchers[11], _A, __Matchers[13]);

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
            private PlainRule _Abac;
            private PlainRule _Bbaa;
            private PlainRule _CbAc;
            private PlainRule _A;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
        }
    }

    public partial class T1Tree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface IS {}
        public interface IAbac : IS {}
        public interface IBbaa : IS {}
        public interface ICbac : IS {}
        public interface IA {}

        public partial class CXStart : RSequence, IXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public IS S => Get<IS>(0);
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

        public partial class CAbac : RSequence, IAbac
        {
            public CAbac(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public RString String3 => Get<RString>(2);
        }

        public partial class CBbaa : RSequence, IBbaa
        {
            public CBbaa(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public RString String3 => Get<RString>(2);
        }

        public partial class CCbac : RSequence, ICbac
        {
            public CCbac(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CA A => Get<CA>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CA : RString, IA
        {
            public CA(params Node[] children) : base(children) {}
        }

        public partial class DynamicT1Visitor : DynamicVisitor
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

            protected virtual void Visit(CAbac element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CBbaa element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCbac element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CA element)
            {
                VisitChildren(element);
            }
        }
    }
}
