// <generated from="D:\\Six\\SixBot\\Grammars\\Six.six" at="20.01.2022 17:31:06" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.SixTree;

namespace GeneratedParser
{
    public partial class SixParser : Parser
    {
        public SixParser()
            : base("Six", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[64])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _grammar = new PlainRule(this, 3, "grammar") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _options = new PlainRule(this, 4, "options") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _option = new PlainRule(this, 5, "option") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _rules = new PlainRule(this, 6, "rules") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _rule = new PlainRule(this, 7, "rule") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _define = new PlainRule(this, 8, "define") { Creator = node => new CDefine(node) };
                /*   9 PlainRuleOp      */ __Matchers[9] = _expression = new PlainRule(this, 9, "expression") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _sequence = new PlainRule(this, 10, "sequence") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _element = new PlainRule(this, 11, "element") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _range = new PlainRule(this, 12, "range") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _diff = new PlainRule(this, 13, "diff") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _star = new PlainRule(this, 14, "star") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _plus = new PlainRule(this, 15, "plus") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _optional = new PlainRule(this, 16, "optional") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _complement = new PlainRule(this, 17, "complement") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _not = new PlainRule(this, 18, "not") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _atom = new PlainRule(this, 19, "atom") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _groupedExpression = new PlainRule(this, 20, "grouped-expression") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _tokenExpression = new PlainRule(this, 21, "token-expression") { Builder = nodes => nodes[0] };
                /*  22 DfaRuleOp        */ __Matchers[22] = _specialIdentifier = new DfaRule(this, 22, "special-identifier") { Creator = node => new CSpecialIdentifier(node) };
                /*  23 DfaRuleOp        */ __Matchers[23] = _identifier = new DfaRule(this, 23, "identifier") { Creator = node => new CIdentifier(node) };
                /*  24 DfaRuleOp        */ __Matchers[24] = _string = new DfaRule(this, 24, "string") { Creator = node => new CString(node) };
                /*  25 EofOp            */ __Matchers[25] = new Eof(this, 25, "<eof>") { Creator = node => new REof(node) };
                /*  26 SeqOp            */ __Matchers[26] = new Seq(this, 26, "_(>grammar,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  27 StringOp         */ __Matchers[27] = new String(this, 27, "'grammar'", "grammar") { Creator = node => new RString(node) };
                /*  28 StringOp         */ __Matchers[28] = new String(this, 28, "';'", ";") { Creator = node => new RString(node) };
                /*  29 SeqOp            */ __Matchers[29] = new Seq(this, 29, "_('grammar',>identifier,';',>options,>rules)") { Builder = nodes => new CGrammar(nodes) };
                /*  30 StarOp           */ __Matchers[30] = new Star(this, 30, "*(>option)") { Builder = nodes => new COptions(nodes) };
                /*  31 StringOp         */ __Matchers[31] = new String(this, 31, "'='", "=") { Creator = node => new RString(node) };
                /*  32 SeqOp            */ __Matchers[32] = new Seq(this, 32, "_(>special-identifier,'=',>expression,';')") { Builder = nodes => new COption(nodes) };
                /*  33 StarOp           */ __Matchers[33] = new Star(this, 33, "*(>rule)") { Builder = nodes => new CRules(nodes) };
                /*  34 SeqOp            */ __Matchers[34] = new Seq(this, 34, "_(>identifier,>define,>expression,';')") { Builder = nodes => new CRule(nodes) };
                /*  35 StringOp         */ __Matchers[35] = new String(this, 35, "'|'", "|") { Creator = node => new RString(node) };
                /*  36 StringOp         */ __Matchers[36] = new String(this, 36, "':'", ":") { Creator = node => new RString(node) };
                /*  37 AltOp            */ __Matchers[37] = new Alt(this, 37, "alt('|'|':')") { Builder = nodes => nodes[0] };
                /*  38 SeqOp            */ __Matchers[38] = new Seq(this, 38, "_('|',>sequence)") { Builder = nodes => new RSequence(nodes) };
                /*  39 StarOp           */ __Matchers[39] = new Star(this, 39, "*(_('|',>sequence))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  40 SeqOp            */ __Matchers[40] = new Seq(this, 40, "_(>sequence,*(_('|',>sequence)))") { Builder = nodes => new CExpression(nodes) };
                /*  41 StarOp           */ __Matchers[41] = new Star(this, 41, "*(>element)") { Builder = nodes => new CSequence(nodes) };
                /*  42 AltOp            */ __Matchers[42] = new Alt(this, 42, "alt(>atom|>range|>diff|>star|>plus|>optional|>complement|>not)") { Builder = nodes => nodes[0] };
                /*  43 StringOp         */ __Matchers[43] = new String(this, 43, "'..'", "..") { Creator = node => new RString(node) };
                /*  44 SeqOp            */ __Matchers[44] = new Seq(this, 44, "_(>atom,'..',>atom)") { Builder = nodes => new CRange(nodes) };
                /*  45 StringOp         */ __Matchers[45] = new String(this, 45, "'-'", "-") { Creator = node => new RString(node) };
                /*  46 SeqOp            */ __Matchers[46] = new Seq(this, 46, "_(>atom,'-',>atom)") { Builder = nodes => new CDiff(nodes) };
                /*  47 StringOp         */ __Matchers[47] = new String(this, 47, "'*'", "*") { Creator = node => new RString(node) };
                /*  48 SeqOp            */ __Matchers[48] = new Seq(this, 48, "_(>atom,'*')") { Builder = nodes => new CStar(nodes) };
                /*  49 StringOp         */ __Matchers[49] = new String(this, 49, "'+'", "+") { Creator = node => new RString(node) };
                /*  50 SeqOp            */ __Matchers[50] = new Seq(this, 50, "_(>atom,'+')") { Builder = nodes => new CPlus(nodes) };
                /*  51 StringOp         */ __Matchers[51] = new String(this, 51, "'?'", "?") { Creator = node => new RString(node) };
                /*  52 SeqOp            */ __Matchers[52] = new Seq(this, 52, "_(>atom,'?')") { Builder = nodes => new COptional(nodes) };
                /*  53 StringOp         */ __Matchers[53] = new String(this, 53, "'~'", "~") { Creator = node => new RString(node) };
                /*  54 SeqOp            */ __Matchers[54] = new Seq(this, 54, "_('~',>atom)") { Builder = nodes => new CComplement(nodes) };
                /*  55 StringOp         */ __Matchers[55] = new String(this, 55, "'!'", "!") { Creator = node => new RString(node) };
                /*  56 SeqOp            */ __Matchers[56] = new Seq(this, 56, "_('!',>atom)") { Builder = nodes => new CNot(nodes) };
                /*  57 AltOp            */ __Matchers[57] = new Alt(this, 57, "alt(>identifier|>string|>grouped-expression|>token-expression)") { Builder = nodes => nodes[0] };
                /*  58 StringOp         */ __Matchers[58] = new String(this, 58, "'('", "(") { Creator = node => new RString(node) };
                /*  59 StringOp         */ __Matchers[59] = new String(this, 59, "')'", ")") { Creator = node => new RString(node) };
                /*  60 SeqOp            */ __Matchers[60] = new Seq(this, 60, "_('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /*  61 StringOp         */ __Matchers[61] = new String(this, 61, "'<'", "<") { Creator = node => new RString(node) };
                /*  62 StringOp         */ __Matchers[62] = new String(this, 62, "'>'", ">") { Creator = node => new RString(node) };
                /*  63 SeqOp            */ __Matchers[63] = new Seq(this, 63, "_('<',>expression,'>')") { Builder = nodes => new CTokenExpression(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[26]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _grammar.Set(__Matchers[29]);
                /*   4 PlainRuleOp      */ _options.Set(__Matchers[30]);
                /*   5 PlainRuleOp      */ _option.Set(__Matchers[32]);
                /*   6 PlainRuleOp      */ _rules.Set(__Matchers[33]);
                /*   7 PlainRuleOp      */ _rule.Set(__Matchers[34]);
                /*   8 PlainRuleOp      */ _define.Set(__Matchers[37]);
                /*   9 PlainRuleOp      */ _expression.Set(__Matchers[40]);
                /*  10 PlainRuleOp      */ _sequence.Set(__Matchers[41]);
                /*  11 PlainRuleOp      */ _element.Set(__Matchers[42]);
                /*  12 PlainRuleOp      */ _range.Set(__Matchers[44]);
                /*  13 PlainRuleOp      */ _diff.Set(__Matchers[46]);
                /*  14 PlainRuleOp      */ _star.Set(__Matchers[48]);
                /*  15 PlainRuleOp      */ _plus.Set(__Matchers[50]);
                /*  16 PlainRuleOp      */ _optional.Set(__Matchers[52]);
                /*  17 PlainRuleOp      */ _complement.Set(__Matchers[54]);
                /*  18 PlainRuleOp      */ _not.Set(__Matchers[56]);
                /*  19 PlainRuleOp      */ _atom.Set(__Matchers[57]);
                /*  20 PlainRuleOp      */ _groupedExpression.Set(__Matchers[60]);
                /*  21 PlainRuleOp      */ _tokenExpression.Set(__Matchers[63]);
                /*  22 DfaRuleOp        */ _specialIdentifier.Set(_specialIdentifier_DFA);
                /*  23 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /*  24 DfaRuleOp        */ _string.Set(_string_DFA);
                /*  26 SeqOp            */ __Matchers[26].Set(_grammar, __Matchers[25]);
                /*  29 SeqOp            */ __Matchers[29].Set(__Matchers[27], _identifier, __Matchers[28], _options, _rules);
                /*  30 StarOp           */ __Matchers[30].Set(_option);
                /*  32 SeqOp            */ __Matchers[32].Set(_specialIdentifier, __Matchers[31], _expression, __Matchers[28]);
                /*  33 StarOp           */ __Matchers[33].Set(_rule);
                /*  34 SeqOp            */ __Matchers[34].Set(_identifier, _define, _expression, __Matchers[28]);
                /*  37 AltOp            */ __Matchers[37].Set(__Matchers[35], __Matchers[36]);
                /*  38 SeqOp            */ __Matchers[38].Set(__Matchers[35], _sequence);
                /*  39 StarOp           */ __Matchers[39].Set(__Matchers[38]);
                /*  40 SeqOp            */ __Matchers[40].Set(_sequence, __Matchers[39]);
                /*  41 StarOp           */ __Matchers[41].Set(_element);
                /*  42 AltOp            */ __Matchers[42].Set(_atom, _range, _diff, _star, _plus, _optional, _complement, _not);
                /*  44 SeqOp            */ __Matchers[44].Set(_atom, __Matchers[43], _atom);
                /*  46 SeqOp            */ __Matchers[46].Set(_atom, __Matchers[45], _atom);
                /*  48 SeqOp            */ __Matchers[48].Set(_atom, __Matchers[47]);
                /*  50 SeqOp            */ __Matchers[50].Set(_atom, __Matchers[49]);
                /*  52 SeqOp            */ __Matchers[52].Set(_atom, __Matchers[51]);
                /*  54 SeqOp            */ __Matchers[54].Set(__Matchers[53], _atom);
                /*  56 SeqOp            */ __Matchers[56].Set(__Matchers[55], _atom);
                /*  57 AltOp            */ __Matchers[57].Set(_identifier, _string, _groupedExpression, _tokenExpression);
                /*  60 SeqOp            */ __Matchers[60].Set(__Matchers[58], _expression, __Matchers[59]);
                /*  63 SeqOp            */ __Matchers[63].Set(__Matchers[61], _expression, __Matchers[62]);

                __Whitespace_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, true),
                    new DfaState(3, false),
                    new DfaState(4, true),
                    new DfaState(5, false),
                    new DfaState(6, false)
                );
                __Whitespace_DFA.States[0].Set(
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(9, 10), new DfaInterval(32, 32)),
                    new DfaTrans(__Whitespace_DFA.States[2], new DfaInterval(13, 13)),
                    new DfaTrans(__Whitespace_DFA.States[3], new DfaInterval(47, 47))
                );
                __Whitespace_DFA.States[1].Set(
                );
                __Whitespace_DFA.States[2].Set(
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(10, 10))
                );
                __Whitespace_DFA.States[3].Set(
                    new DfaTrans(__Whitespace_DFA.States[4], new DfaInterval(47, 47)),
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(42, 42))
                );
                __Whitespace_DFA.States[4].Set(
                    new DfaTrans(__Whitespace_DFA.States[4], new DfaInterval(0, 9), new DfaInterval(11, 12), new DfaInterval(14, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[2], new DfaInterval(13, 13)),
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(10, 10))
                );
                __Whitespace_DFA.States[5].Set(
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(0, 41), new DfaInterval(43, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[6], new DfaInterval(42, 42))
                );
                __Whitespace_DFA.States[6].Set(
                    new DfaTrans(__Whitespace_DFA.States[6], new DfaInterval(42, 42)),
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(0, 41), new DfaInterval(43, 46), new DfaInterval(48, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(47, 47))
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
                _specialIdentifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, true),
                    new DfaState(3, false)
                );
                _specialIdentifier_DFA.States[0].Set(
                    new DfaTrans(_specialIdentifier_DFA.States[1], new DfaInterval(37, 37))
                );
                _specialIdentifier_DFA.States[1].Set(
                    new DfaTrans(_specialIdentifier_DFA.States[2], new DfaInterval(65, 90), new DfaInterval(97, 122))
                );
                _specialIdentifier_DFA.States[2].Set(
                    new DfaTrans(_specialIdentifier_DFA.States[2], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(97, 122)),
                    new DfaTrans(_specialIdentifier_DFA.States[3], new DfaInterval(45, 45), new DfaInterval(95, 95))
                );
                _specialIdentifier_DFA.States[3].Set(
                    new DfaTrans(_specialIdentifier_DFA.States[2], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(97, 122))
                );
                _identifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(97, 122))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(97, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(45, 45), new DfaInterval(95, 95))
                );
                _identifier_DFA.States[2].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(97, 122))
                );
                _string_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, false),
                    new DfaState(7, false),
                    new DfaState(8, false),
                    new DfaState(9, false),
                    new DfaState(10, false),
                    new DfaState(11, false),
                    new DfaState(12, false),
                    new DfaState(13, true)
                );
                _string_DFA.States[0].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(39, 39))
                );
                _string_DFA.States[1].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(0, 38), new DfaInterval(40, 91), new DfaInterval(93, 1114111)),
                    new DfaTrans(_string_DFA.States[2], new DfaInterval(92, 92)),
                    new DfaTrans(_string_DFA.States[13], new DfaInterval(39, 39))
                );
                _string_DFA.States[2].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(39, 39), new DfaInterval(92, 92), new DfaInterval(97, 98), new DfaInterval(102, 102), new DfaInterval(110, 110), new DfaInterval(114, 114), new DfaInterval(116, 116), new DfaInterval(118, 118)),
                    new DfaTrans(_string_DFA.States[3], new DfaInterval(120, 120)),
                    new DfaTrans(_string_DFA.States[5], new DfaInterval(117, 117))
                );
                _string_DFA.States[3].Set(
                    new DfaTrans(_string_DFA.States[4], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[4].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[5].Set(
                    new DfaTrans(_string_DFA.States[6], new DfaInterval(123, 123))
                );
                _string_DFA.States[6].Set(
                    new DfaTrans(_string_DFA.States[7], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _string_DFA.States[7].Set(
                    new DfaTrans(_string_DFA.States[8], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102)),
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[8].Set(
                    new DfaTrans(_string_DFA.States[9], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102)),
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[9].Set(
                    new DfaTrans(_string_DFA.States[10], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102)),
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[10].Set(
                    new DfaTrans(_string_DFA.States[11], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102)),
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[11].Set(
                    new DfaTrans(_string_DFA.States[12], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102)),
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[12].Set(
                    new DfaTrans(_string_DFA.States[1], new DfaInterval(125, 125))
                );
                _string_DFA.States[13].Set(
                );
            }

            private PlainRule _grammar;
            private PlainRule _options;
            private PlainRule _option;
            private PlainRule _rules;
            private PlainRule _rule;
            private PlainRule _define;
            private PlainRule _expression;
            private PlainRule _sequence;
            private PlainRule _element;
            private PlainRule _range;
            private PlainRule _diff;
            private PlainRule _star;
            private PlainRule _plus;
            private PlainRule _optional;
            private PlainRule _complement;
            private PlainRule _not;
            private PlainRule _atom;
            private PlainRule _groupedExpression;
            private PlainRule _tokenExpression;
            private DfaRule _specialIdentifier;
            private DfaRule _identifier;
            private DfaRule _string;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
            private Dfa _specialIdentifier_DFA = new Dfa("special-identifier");
            private Dfa _identifier_DFA = new Dfa("identifier");
            private Dfa _string_DFA = new Dfa("string");
        }
    }

    public partial class SixTree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface IGrammar {}
        public interface IOptions {}
        public interface IOption {}
        public interface IRules {}
        public interface IRule {}
        public interface IDefine {}
        public interface IExpression {}
        public interface ISequence {}
        public interface IElement {}
        public interface IRange : IElement {}
        public interface IDiff : IElement {}
        public interface IStar : IElement {}
        public interface IPlus : IElement {}
        public interface IOptional : IElement {}
        public interface IComplement : IElement {}
        public interface INot : IElement {}
        public interface IAtom : IElement {}
        public interface IGroupedExpression : IAtom {}
        public interface ITokenExpression : IAtom {}
        public interface ISpecialIdentifier {}
        public interface IIdentifier : IAtom {}
        public interface IString : IAtom {}

        public partial class CXStart : RSequence, IXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public CGrammar Grammar => Get<CGrammar>(0);
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

        public partial class CGrammar : RSequence, IGrammar
        {
            public CGrammar(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CIdentifier Identifier => Get<CIdentifier>(1);
            public RString String2 => Get<RString>(2);
            public COptions Options => Get<COptions>(3);
            public CRules Rules => Get<CRules>(4);
        }

        public partial class COptions : RStar<COption>, IOptions
        {
            public COptions(params RNode[] children) : base(children) {}
        }

        public partial class COption : RSequence, IOption
        {
            public COption(params RNode[] children) : base(children) {}

            public CSpecialIdentifier SpecialIdentifier => Get<CSpecialIdentifier>(0);
            public RString String => Get<RString>(1);
            public CExpression Expression => Get<CExpression>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CRules : RStar<CRule>, IRules
        {
            public CRules(params RNode[] children) : base(children) {}
        }

        public partial class CRule : RSequence, IRule
        {
            public CRule(params RNode[] children) : base(children) {}

            public CIdentifier Identifier => Get<CIdentifier>(0);
            public CDefine Define => Get<CDefine>(1);
            public CExpression Expression => Get<CExpression>(2);
            public RString String => Get<RString>(3);
        }

        public partial class CDefine : RString, IDefine
        {
            public CDefine(params Node[] children) : base(children) {}
        }

        public partial class CExpression : RLoop<CSequence>, IExpression
        {
            public CExpression(params RNode[] children) : base(children) {}
        }

        public partial class CSequence : RStar<IElement>, ISequence
        {
            public CSequence(params RNode[] children) : base(children) {}
        }

        public partial class CRange : RSequence, IRange
        {
            public CRange(params RNode[] children) : base(children) {}

            public IAtom Atom => Get<IAtom>(0);
            public RString String => Get<RString>(1);
            public IAtom Atom2 => Get<IAtom>(2);
        }

        public partial class CDiff : RSequence, IDiff
        {
            public CDiff(params RNode[] children) : base(children) {}

            public IAtom Atom => Get<IAtom>(0);
            public RString String => Get<RString>(1);
            public IAtom Atom2 => Get<IAtom>(2);
        }

        public partial class CStar : RSequence, IStar
        {
            public CStar(params RNode[] children) : base(children) {}

            public IAtom Atom => Get<IAtom>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CPlus : RSequence, IPlus
        {
            public CPlus(params RNode[] children) : base(children) {}

            public IAtom Atom => Get<IAtom>(0);
            public RString String => Get<RString>(1);
        }

        public partial class COptional : RSequence, IOptional
        {
            public COptional(params RNode[] children) : base(children) {}

            public IAtom Atom => Get<IAtom>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CComplement : RSequence, IComplement
        {
            public CComplement(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IAtom Atom => Get<IAtom>(1);
        }

        public partial class CNot : RSequence, INot
        {
            public CNot(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IAtom Atom => Get<IAtom>(1);
        }

        public partial class CGroupedExpression : RSequence, IGroupedExpression
        {
            public CGroupedExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CExpression Expression => Get<CExpression>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CTokenExpression : RSequence, ITokenExpression
        {
            public CTokenExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CExpression Expression => Get<CExpression>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CSpecialIdentifier : RString, ISpecialIdentifier
        {
            public CSpecialIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CIdentifier : RString, IIdentifier
        {
            public CIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CString : RString, IString
        {
            public CString(params Node[] children) : base(children) {}
        }

        public partial class DynamicSixVisitor : DynamicVisitor
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

            protected virtual void Visit(CGrammar element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptions element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COption element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CRules element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CRule element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDefine element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSequence element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CRange element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDiff element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStar element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPlus element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptional element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CComplement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNot element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CGroupedExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTokenExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpecialIdentifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIdentifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CString element)
            {
                VisitChildren(element);
            }
        }
    }
}
