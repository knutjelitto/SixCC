// <generated from="D:\\Six\\SixBot\\Grammars\\T7.six" at="19.01.2022 18:48:09" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.T7ParserAst;

namespace GeneratedParser
{
    public partial class T7Parser : Parser
    {
        public T7Parser()
            : base("T7", new __T7ParserImplementation())
        {
        }

        private class __T7ParserImplementation : ImplementationCore
        {
            public __T7ParserImplementation()
                : base(new Matcher[9])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _S = new PlainRule(this, 3, "S") { Builder = nodes => nodes[0] };
                /*   4 EofOp            */ __Matchers[4] = new Eof(this, 4, "<eof>") { Creator = node => new REof(node) };
                /*   5 SeqOp            */ __Matchers[5] = new Seq(this, 5, "_(>S,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*   6 StringOp         */ __Matchers[6] = new String(this, 6, "'d'", "d") { Creator = node => new RString(node) };
                /*   7 StarOp           */ __Matchers[7] = new Star(this, 7, "*('d')") { Builder = nodes => new RStar<RString>(nodes) };
                /*   8 SeqOp            */ __Matchers[8] = new Seq(this, 8, "_(*('d'),*('d'))") { Builder = nodes => new CS(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[5]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _S.Set(__Matchers[8]);
                /*   5 SeqOp            */ __Matchers[5].Set(_S, __Matchers[4]);
                /*   7 StarOp           */ __Matchers[7].Set(__Matchers[6]);
                /*   8 SeqOp            */ __Matchers[8].Set(__Matchers[7], __Matchers[7]);

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

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
        }
    }

    public partial class T7ParserAst
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface IS {}

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

        public partial class CS : RSequence, IS
        {
            public CS(params RNode[] children) : base(children) {}

            public RStar<RString> String => Get<RStar<RString>>(0);
            public RStar<RString> String2 => Get<RStar<RString>>(1);
        }

        public partial class DynamicT7Visitor : DynamicVisitor
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
        }
    }
}
