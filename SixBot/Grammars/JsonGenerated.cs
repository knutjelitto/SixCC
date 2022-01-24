// <generated from="D:\\Six\\SixBot\\Grammars\\Json.six" at="23.01.2022 06:31:45" />

using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.JsonTree;

namespace GeneratedParser
{
    public partial class JsonParser : Parser
    {
        public JsonParser()
            : base("Json", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[39])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _json = new PlainRule(this, 3, "json") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _value = new PlainRule(this, 4, "value") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _true = new PlainRule(this, 5, "true") { Creator = node => new CTrue(node) };
                /*   6 PlainRuleOp      */ __Matchers[6] = _false = new PlainRule(this, 6, "false") { Creator = node => new CFalse(node) };
                /*   7 PlainRuleOp      */ __Matchers[7] = _null = new PlainRule(this, 7, "null") { Creator = node => new CNull(node) };
                /*   8 PlainRuleOp      */ __Matchers[8] = _object = new PlainRule(this, 8, "object") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _members = new PlainRule(this, 9, "members") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _member = new PlainRule(this, 10, "member") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _array = new PlainRule(this, 11, "array") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _elements = new PlainRule(this, 12, "elements") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _element = new PlainRule(this, 13, "element") { Builder = nodes => nodes[0] };
                /*  14 DfaRuleOp        */ __Matchers[14] = _string = new DfaRule(this, 14, "string") { Creator = node => new CString(node) };
                /*  15 DfaRuleOp        */ __Matchers[15] = _number = new DfaRule(this, 15, "number") { Creator = node => new CNumber(node) };
                /*  16 EofOp            */ __Matchers[16] = new Eof(this, 16, "<eof>") { Creator = node => new REof(node) };
                /*  17 SeqOp            */ __Matchers[17] = new Seq(this, 17, "_(>json,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  18 AltOp            */ __Matchers[18] = new Alt(this, 18, "alt(>object|>array|>string|>number|>true|>false|>null)") { Builder = nodes => nodes[0] };
                /*  19 StringOp         */ __Matchers[19] = new String(this, 19, "'true'", "true") { Creator = node => new CTrue(node) };
                /*  20 StringOp         */ __Matchers[20] = new String(this, 20, "'false'", "false") { Creator = node => new CFalse(node) };
                /*  21 StringOp         */ __Matchers[21] = new String(this, 21, "'null'", "null") { Creator = node => new CNull(node) };
                /*  22 StringOp         */ __Matchers[22] = new String(this, 22, "'{'", "{") { Creator = node => new RLiteral(node) };
                /*  23 OptionalOp       */ __Matchers[23] = new Optional(this, 23, "?(>members)") { Builder = nodes => new ROptional<CMembers>(nodes) };
                /*  24 StringOp         */ __Matchers[24] = new String(this, 24, "'}'", "}") { Creator = node => new RLiteral(node) };
                /*  25 SeqOp            */ __Matchers[25] = new Seq(this, 25, "_('{',?(>members),'}')") { Builder = nodes => new CObject(nodes) };
                /*  26 StringOp         */ __Matchers[26] = new String(this, 26, "','", ",") { Creator = node => new RLiteral(node) };
                /*  27 SeqOp            */ __Matchers[27] = new Seq(this, 27, "_(',',>member)") { Builder = nodes => new RSequence(nodes) };
                /*  28 StarOp           */ __Matchers[28] = new Star(this, 28, "*(_(',',>member))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  29 SeqOp            */ __Matchers[29] = new Seq(this, 29, "_(>member,*(_(',',>member)))") { Builder = nodes => new CMembers(nodes) };
                /*  30 StringOp         */ __Matchers[30] = new String(this, 30, "':'", ":") { Creator = node => new RLiteral(node) };
                /*  31 SeqOp            */ __Matchers[31] = new Seq(this, 31, "_(>string,':',>element)") { Builder = nodes => new CMember(nodes) };
                /*  32 StringOp         */ __Matchers[32] = new String(this, 32, "'['", "[") { Creator = node => new RLiteral(node) };
                /*  33 OptionalOp       */ __Matchers[33] = new Optional(this, 33, "?(>elements)") { Builder = nodes => new ROptional<CElements>(nodes) };
                /*  34 StringOp         */ __Matchers[34] = new String(this, 34, "']'", "]") { Creator = node => new RLiteral(node) };
                /*  35 SeqOp            */ __Matchers[35] = new Seq(this, 35, "_('[',?(>elements),']')") { Builder = nodes => new CArray(nodes) };
                /*  36 SeqOp            */ __Matchers[36] = new Seq(this, 36, "_(',',>element)") { Builder = nodes => new RSequence(nodes) };
                /*  37 StarOp           */ __Matchers[37] = new Star(this, 37, "*(_(',',>element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  38 SeqOp            */ __Matchers[38] = new Seq(this, 38, "_(>element,*(_(',',>element)))") { Builder = nodes => new CElements(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[17]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _json.Set(_element);
                /*   4 PlainRuleOp      */ _value.Set(__Matchers[18]);
                /*   5 PlainRuleOp      */ _true.Set(__Matchers[19]);
                /*   6 PlainRuleOp      */ _false.Set(__Matchers[20]);
                /*   7 PlainRuleOp      */ _null.Set(__Matchers[21]);
                /*   8 PlainRuleOp      */ _object.Set(__Matchers[25]);
                /*   9 PlainRuleOp      */ _members.Set(__Matchers[29]);
                /*  10 PlainRuleOp      */ _member.Set(__Matchers[31]);
                /*  11 PlainRuleOp      */ _array.Set(__Matchers[35]);
                /*  12 PlainRuleOp      */ _elements.Set(__Matchers[38]);
                /*  13 PlainRuleOp      */ _element.Set(_value);
                /*  14 DfaRuleOp        */ _string.Set(_string_DFA);
                /*  15 DfaRuleOp        */ _number.Set(_number_DFA);
                /*  17 SeqOp            */ __Matchers[17].Set(_json, __Matchers[16]);
                /*  18 AltOp            */ __Matchers[18].Set(_object, _array, _string, _number, _true, _false, _null);
                /*  23 OptionalOp       */ __Matchers[23].Set(_members);
                /*  25 SeqOp            */ __Matchers[25].Set(__Matchers[22], __Matchers[23], __Matchers[24]);
                /*  27 SeqOp            */ __Matchers[27].Set(__Matchers[26], _member);
                /*  28 StarOp           */ __Matchers[28].Set(__Matchers[27]);
                /*  29 SeqOp            */ __Matchers[29].Set(_member, __Matchers[28]);
                /*  31 SeqOp            */ __Matchers[31].Set(_string, __Matchers[30], _element);
                /*  33 OptionalOp       */ __Matchers[33].Set(_elements);
                /*  35 SeqOp            */ __Matchers[35].Set(__Matchers[32], __Matchers[33], __Matchers[34]);
                /*  36 SeqOp            */ __Matchers[36].Set(__Matchers[26], _element);
                /*  37 StarOp           */ __Matchers[37].Set(__Matchers[36]);
                /*  38 SeqOp            */ __Matchers[38].Set(_element, __Matchers[37]);

                __Whitespace_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Whitespace_DFA.States[0].Set(
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(9, 10), new DfaInterval(13, 13), new DfaInterval(32, 32))
                );
                __Whitespace_DFA.States[1].Set(
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
                _string_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, false),
                    new DfaState(7, true)
                );
                _string_DFA.States[0].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(34, 34))
                );
                _string_DFA.States[1].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(32, 33), new DfaInterval(35, 91), new DfaInterval(93, 1114111)),
                    new DfaTrans(_string_DFA.States[2], new DfaInterval(92, 92)),
                    new DfaTrans(_string_DFA.States[7], new DfaInterval(34, 34))
                );
                _string_DFA.States[2].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(34, 34), new DfaInterval(47, 47), new DfaInterval(92, 92), new DfaInterval(98, 98), new DfaInterval(102, 102), new DfaInterval(110, 110), new DfaInterval(114, 114), new DfaInterval(116, 116), new DfaInterval(118, 118)),
                    new DfaTrans(_string_DFA.States[3], new DfaInterval(117, 117))
                );
                _string_DFA.States[3].Set(
                    new DfaTrans(_string_DFA.States[4], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[4].Set(
                    new DfaTrans(_string_DFA.States[5], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[5].Set(
                    new DfaTrans(_string_DFA.States[6], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[6].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[7].Set(
                );
                _number_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true),
                    new DfaState(7, true),
                    new DfaState(8, false)
                );
                _number_DFA.States[0].Set(
                    new DfaTrans(_number_DFA.States[1], new DfaInterval(48, 48)),
                    new DfaTrans(_number_DFA.States[7], new DfaInterval(49, 57)),
                    new DfaTrans(_number_DFA.States[8], new DfaInterval(45, 45))
                );
                _number_DFA.States[1].Set(
                    new DfaTrans(_number_DFA.States[2], new DfaInterval(46, 46)),
                    new DfaTrans(_number_DFA.States[4], new DfaInterval(69, 69), new DfaInterval(101, 101))
                );
                _number_DFA.States[2].Set(
                    new DfaTrans(_number_DFA.States[3], new DfaInterval(48, 57))
                );
                _number_DFA.States[3].Set(
                    new DfaTrans(_number_DFA.States[3], new DfaInterval(48, 57)),
                    new DfaTrans(_number_DFA.States[4], new DfaInterval(69, 69), new DfaInterval(101, 101))
                );
                _number_DFA.States[4].Set(
                    new DfaTrans(_number_DFA.States[5], new DfaInterval(43, 43), new DfaInterval(45, 45)),
                    new DfaTrans(_number_DFA.States[6], new DfaInterval(48, 57))
                );
                _number_DFA.States[5].Set(
                    new DfaTrans(_number_DFA.States[6], new DfaInterval(48, 57))
                );
                _number_DFA.States[6].Set(
                    new DfaTrans(_number_DFA.States[6], new DfaInterval(48, 57))
                );
                _number_DFA.States[7].Set(
                    new DfaTrans(_number_DFA.States[7], new DfaInterval(48, 57)),
                    new DfaTrans(_number_DFA.States[2], new DfaInterval(46, 46)),
                    new DfaTrans(_number_DFA.States[4], new DfaInterval(69, 69), new DfaInterval(101, 101))
                );
                _number_DFA.States[8].Set(
                    new DfaTrans(_number_DFA.States[1], new DfaInterval(48, 48)),
                    new DfaTrans(_number_DFA.States[7], new DfaInterval(49, 57))
                );
            }

            private PlainRule _json;
            private PlainRule _value;
            private PlainRule _true;
            private PlainRule _false;
            private PlainRule _null;
            private PlainRule _object;
            private PlainRule _members;
            private PlainRule _member;
            private PlainRule _array;
            private PlainRule _elements;
            private PlainRule _element;
            private DfaRule _string;
            private DfaRule _number;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
            private Dfa _string_DFA = new Dfa("string");
            private Dfa _number_DFA = new Dfa("number");
        }
    }

    public partial class JsonTree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICJson : IRNode {}
        public interface ICValue : ICElement {}
        public interface ICTrue : ICValue {}
        public interface ICFalse : ICValue {}
        public interface ICNull : ICValue {}
        public interface ICObject : ICValue {}
        public interface ICMembers : IRNode {}
        public interface ICMember : IRNode {}
        public interface ICArray : ICValue {}
        public interface ICElements : IRNode {}
        public interface ICElement : ICJson {}
        public interface ICString : ICValue {}
        public interface ICNumber : ICValue {}

        public partial class CXStart : RSequence, ICXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public ICJson Json => Get<ICJson>(0);
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

        public partial class CTrue : RLiteral, ICTrue
        {
            public CTrue(params Node[] children) : base(children) {}
        }

        public partial class CFalse : RLiteral, ICFalse
        {
            public CFalse(params Node[] children) : base(children) {}
        }

        public partial class CNull : RLiteral, ICNull
        {
            public CNull(params Node[] children) : base(children) {}
        }

        public partial class CObject : RSequence, ICObject
        {
            public CObject(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CMembers> MembersOptional => Get<ROptional<CMembers>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CMembers : RLoop<CMember>, ICMembers
        {
            public CMembers(params RNode[] children) : base(children) {}
        }

        public partial class CMember : RSequence, ICMember
        {
            public CMember(params RNode[] children) : base(children) {}

            public CString String => Get<CString>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICElement Element => Get<ICElement>(2);
        }

        public partial class CArray : RSequence, ICArray
        {
            public CArray(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CElements> ElementsOptional => Get<ROptional<CElements>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CElements : RLoop<ICElement>, ICElements
        {
            public CElements(params RNode[] children) : base(children) {}
        }

        public partial class CString : RToken, ICString
        {
            public CString(params Node[] children) : base(children) {}
        }

        public partial class CNumber : RToken, ICNumber
        {
            public CNumber(params Node[] children) : base(children) {}
        }

        public partial class DynamicJsonVisitor : DynamicVisitor
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

            protected virtual void Visit(CTrue element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFalse element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNull element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CObject element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMembers element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMember element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArray element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CString element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNumber element)
            {
                DefaultImplementation(element);
            }
        }
    }
}
