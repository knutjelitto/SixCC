// <generated from="D:\\Six\\SixBot\\Grammars\\T4.six" at="20.01.2022 17:31:06" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T4Tree;

namespace GeneratedParser
{
    public partial class T4Parser : Parser
    {
        public T4Parser()
            : base("T4", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[30])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _S = new PlainRule(this, 3, "S") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _qq = new PlainRule(this, 4, "qq") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _qs = new PlainRule(this, 5, "qs") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _qp = new PlainRule(this, 6, "qp") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _sq = new PlainRule(this, 7, "sq") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _ss = new PlainRule(this, 8, "ss") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _sp = new PlainRule(this, 9, "sp") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _pq = new PlainRule(this, 10, "pq") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _ps = new PlainRule(this, 11, "ps") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _pp = new PlainRule(this, 12, "pp") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _d = new PlainRule(this, 13, "d") { Creator = node => new CD(node) };
                /*  14 EofOp            */ __Matchers[14] = new Eof(this, 14, "<eof>") { Creator = node => new REof(node) };
                /*  15 SeqOp            */ __Matchers[15] = new Seq(this, 15, "_(>S,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  16 AltOp            */ __Matchers[16] = new Alt(this, 16, "alt(>qq|>qs|>qp|>sq|>ss|>sp|>pq|>ps|>pp)") { Builder = nodes => nodes[0] };
                /*  17 OptionalOp       */ __Matchers[17] = new Optional(this, 17, "?(>d)") { Builder = nodes => new ROptional<CD>(nodes) };
                /*  18 SeqOp            */ __Matchers[18] = new Seq(this, 18, "_(?(>d),?(>d))") { Builder = nodes => new CQq(nodes) };
                /*  19 StarOp           */ __Matchers[19] = new Star(this, 19, "*(>d)") { Builder = nodes => new RStar<CD>(nodes) };
                /*  20 SeqOp            */ __Matchers[20] = new Seq(this, 20, "_(?(>d),*(>d))") { Builder = nodes => new CQs(nodes) };
                /*  21 PlusOp           */ __Matchers[21] = new Plus(this, 21, "+(>d)") { Builder = nodes => new RPlus<CD>(nodes) };
                /*  22 SeqOp            */ __Matchers[22] = new Seq(this, 22, "_(?(>d),+(>d))") { Builder = nodes => new CQp(nodes) };
                /*  23 SeqOp            */ __Matchers[23] = new Seq(this, 23, "_(*(>d),?(>d))") { Builder = nodes => new CSq(nodes) };
                /*  24 SeqOp            */ __Matchers[24] = new Seq(this, 24, "_(*(>d),*(>d))") { Builder = nodes => new CSs(nodes) };
                /*  25 SeqOp            */ __Matchers[25] = new Seq(this, 25, "_(*(>d),+(>d))") { Builder = nodes => new CSp(nodes) };
                /*  26 SeqOp            */ __Matchers[26] = new Seq(this, 26, "_(+(>d),?(>d))") { Builder = nodes => new CPq(nodes) };
                /*  27 SeqOp            */ __Matchers[27] = new Seq(this, 27, "_(+(>d),*(>d))") { Builder = nodes => new CPs(nodes) };
                /*  28 SeqOp            */ __Matchers[28] = new Seq(this, 28, "_(+(>d),+(>d))") { Builder = nodes => new CPp(nodes) };
                /*  29 StringOp         */ __Matchers[29] = new String(this, 29, "'d'", "d") { Creator = node => new CD(node) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[15]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _S.Set(__Matchers[16]);
                /*   4 PlainRuleOp      */ _qq.Set(__Matchers[18]);
                /*   5 PlainRuleOp      */ _qs.Set(__Matchers[20]);
                /*   6 PlainRuleOp      */ _qp.Set(__Matchers[22]);
                /*   7 PlainRuleOp      */ _sq.Set(__Matchers[23]);
                /*   8 PlainRuleOp      */ _ss.Set(__Matchers[24]);
                /*   9 PlainRuleOp      */ _sp.Set(__Matchers[25]);
                /*  10 PlainRuleOp      */ _pq.Set(__Matchers[26]);
                /*  11 PlainRuleOp      */ _ps.Set(__Matchers[27]);
                /*  12 PlainRuleOp      */ _pp.Set(__Matchers[28]);
                /*  13 PlainRuleOp      */ _d.Set(__Matchers[29]);
                /*  15 SeqOp            */ __Matchers[15].Set(_S, __Matchers[14]);
                /*  16 AltOp            */ __Matchers[16].Set(_qq, _qs, _qp, _sq, _ss, _sp, _pq, _ps, _pp);
                /*  17 OptionalOp       */ __Matchers[17].Set(_d);
                /*  18 SeqOp            */ __Matchers[18].Set(__Matchers[17], __Matchers[17]);
                /*  19 StarOp           */ __Matchers[19].Set(_d);
                /*  20 SeqOp            */ __Matchers[20].Set(__Matchers[17], __Matchers[19]);
                /*  21 PlusOp           */ __Matchers[21].Set(_d);
                /*  22 SeqOp            */ __Matchers[22].Set(__Matchers[17], __Matchers[21]);
                /*  23 SeqOp            */ __Matchers[23].Set(__Matchers[19], __Matchers[17]);
                /*  24 SeqOp            */ __Matchers[24].Set(__Matchers[19], __Matchers[19]);
                /*  25 SeqOp            */ __Matchers[25].Set(__Matchers[19], __Matchers[21]);
                /*  26 SeqOp            */ __Matchers[26].Set(__Matchers[21], __Matchers[17]);
                /*  27 SeqOp            */ __Matchers[27].Set(__Matchers[21], __Matchers[19]);
                /*  28 SeqOp            */ __Matchers[28].Set(__Matchers[21], __Matchers[21]);

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
            private PlainRule _qq;
            private PlainRule _qs;
            private PlainRule _qp;
            private PlainRule _sq;
            private PlainRule _ss;
            private PlainRule _sp;
            private PlainRule _pq;
            private PlainRule _ps;
            private PlainRule _pp;
            private PlainRule _d;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
        }
    }

    public partial class T4Tree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface IS {}
        public interface IQq : IS {}
        public interface IQs : IS {}
        public interface IQp : IS {}
        public interface ISq : IS {}
        public interface ISs : IS {}
        public interface ISp : IS {}
        public interface IPq : IS {}
        public interface IPs : IS {}
        public interface IPp : IS {}
        public interface ID {}

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

        public partial class CQq : RSequence, IQq
        {
            public CQq(params RNode[] children) : base(children) {}

            public ROptional<CD> D => Get<ROptional<CD>>(0);
            public ROptional<CD> D2 => Get<ROptional<CD>>(1);
        }

        public partial class CQs : RSequence, IQs
        {
            public CQs(params RNode[] children) : base(children) {}

            public ROptional<CD> D => Get<ROptional<CD>>(0);
            public RStar<CD> D2 => Get<RStar<CD>>(1);
        }

        public partial class CQp : RSequence, IQp
        {
            public CQp(params RNode[] children) : base(children) {}

            public ROptional<CD> D => Get<ROptional<CD>>(0);
            public RPlus<CD> D2 => Get<RPlus<CD>>(1);
        }

        public partial class CSq : RSequence, ISq
        {
            public CSq(params RNode[] children) : base(children) {}

            public RStar<CD> D => Get<RStar<CD>>(0);
            public ROptional<CD> D2 => Get<ROptional<CD>>(1);
        }

        public partial class CSs : RSequence, ISs
        {
            public CSs(params RNode[] children) : base(children) {}

            public RStar<CD> D => Get<RStar<CD>>(0);
            public RStar<CD> D2 => Get<RStar<CD>>(1);
        }

        public partial class CSp : RSequence, ISp
        {
            public CSp(params RNode[] children) : base(children) {}

            public RStar<CD> D => Get<RStar<CD>>(0);
            public RPlus<CD> D2 => Get<RPlus<CD>>(1);
        }

        public partial class CPq : RSequence, IPq
        {
            public CPq(params RNode[] children) : base(children) {}

            public RPlus<CD> D => Get<RPlus<CD>>(0);
            public ROptional<CD> D2 => Get<ROptional<CD>>(1);
        }

        public partial class CPs : RSequence, IPs
        {
            public CPs(params RNode[] children) : base(children) {}

            public RPlus<CD> D => Get<RPlus<CD>>(0);
            public RStar<CD> D2 => Get<RStar<CD>>(1);
        }

        public partial class CPp : RSequence, IPp
        {
            public CPp(params RNode[] children) : base(children) {}

            public RPlus<CD> D => Get<RPlus<CD>>(0);
            public RPlus<CD> D2 => Get<RPlus<CD>>(1);
        }

        public partial class CD : RString, ID
        {
            public CD(params Node[] children) : base(children) {}
        }

        public partial class DynamicT4Visitor : DynamicVisitor
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

            protected virtual void Visit(CQq element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CQs element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CQp element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSq element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSs element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSp element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPq element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPs element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPp element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CD element)
            {
                VisitChildren(element);
            }
        }
    }
}
