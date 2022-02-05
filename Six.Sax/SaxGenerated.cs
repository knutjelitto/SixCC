// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Sax\\Sax.six" at="04.02.2022 15:43:22" />

using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Mx = Six.Runtime.Matchers;
using static Six.Sax.SaxTree;

namespace Six.Sax
{
    public partial class SaxParser : Parser
    {
        public SaxParser()
            : base("Sax", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Mx.Matcher[211])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new Mx.StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new Mx.WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new Mx.IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new Mx.PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _codeUnit = new Mx.PlainRule(this, 4, "code-unit") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _namespace = new Mx.PlainRule(this, 5, "namespace") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _moduleDescriptor = new Mx.PlainRule(this, 6, "module-descriptor") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _moduleBody = new Mx.PlainRule(this, 7, "module-body") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _moduleBodyElement = new Mx.PlainRule(this, 8, "module-body-element") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _moduleImport = new Mx.PlainRule(this, 9, "module-import") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _usingDeclaration = new Mx.PlainRule(this, 10, "using-declaration") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _usingElements = new Mx.PlainRule(this, 11, "using-elements") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _usingElementList = new Mx.PlainRule(this, 12, "using-element-list") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _usingElement = new Mx.PlainRule(this, 13, "using-element") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _usingNamed = new Mx.PlainRule(this, 14, "using-named") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _usingName = new Mx.PlainRule(this, 15, "using-name") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _usingNameSpecifier = new Mx.PlainRule(this, 16, "using-name-specifier") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _usingWildcard = new Mx.PlainRule(this, 17, "using-wildcard") { Creator = node => new CUsingWildcard(node) };
                /*  18 PlainRuleOp      */ __Matchers[18] = _name = new Mx.PlainRule(this, 18, "name") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _names = new Mx.PlainRule(this, 19, "names") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _path = new Mx.PlainRule(this, 20, "path") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _reference = new Mx.PlainRule(this, 21, "reference") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _genericArguments = new Mx.PlainRule(this, 22, "generic-arguments") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _genericArgumentList = new Mx.PlainRule(this, 23, "generic-argument-list") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _genericArgument = new Mx.PlainRule(this, 24, "generic-argument") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _declarations = new Mx.PlainRule(this, 25, "declarations") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _declaration = new Mx.PlainRule(this, 26, "declaration") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _functionDeclaration = new Mx.PlainRule(this, 27, "function-declaration") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _attributeDeclaration = new Mx.PlainRule(this, 28, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _functionBody = new Mx.PlainRule(this, 29, "function-body") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _attributeBody = new Mx.PlainRule(this, 30, "attribute-body") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _expressionBody = new Mx.PlainRule(this, 31, "expression-body") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _functionSpecifier = new Mx.PlainRule(this, 32, "function-specifier") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _blockBody = new Mx.PlainRule(this, 33, "block-body") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _classDeclaration = new Mx.PlainRule(this, 34, "class-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _interfaceDeclaration = new Mx.PlainRule(this, 35, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _extends = new Mx.PlainRule(this, 36, "extends") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _caseTypes = new Mx.PlainRule(this, 37, "case-types") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _caseTypeList = new Mx.PlainRule(this, 38, "case-type-list") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _objectDeclaration = new Mx.PlainRule(this, 39, "object-declaration") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _aliasDeclaration = new Mx.PlainRule(this, 40, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _prelude = new Mx.PlainRule(this, 41, "prelude") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _attribute = new Mx.PlainRule(this, 42, "attribute") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _attributeArguments = new Mx.PlainRule(this, 43, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _attributeArgumentList = new Mx.PlainRule(this, 44, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _attributeArgument = new Mx.PlainRule(this, 45, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _metaReference = new Mx.PlainRule(this, 46, "meta-reference") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _classReference = new Mx.PlainRule(this, 47, "class-reference") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _interfaceReference = new Mx.PlainRule(this, 48, "interface-reference") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _functionReference = new Mx.PlainRule(this, 49, "function-reference") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _type = new Mx.PlainRule(this, 50, "type") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _unionlevelType = new Mx.PlainRule(this, 51, "unionlevel-type") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _unionType = new Mx.PlainRule(this, 52, "union-type") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _intersectionlevelType = new Mx.PlainRule(this, 53, "intersectionlevel-type") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _intersectionType = new Mx.PlainRule(this, 54, "intersection-type") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _primaryType = new Mx.PlainRule(this, 55, "primary-type") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _constructor = new Mx.PlainRule(this, 56, "constructor") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _parameters = new Mx.PlainRule(this, 57, "parameters") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _parameterList = new Mx.PlainRule(this, 58, "parameter-list") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _parameter = new Mx.PlainRule(this, 59, "parameter") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _arguments = new Mx.PlainRule(this, 60, "arguments") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _argumentList = new Mx.PlainRule(this, 61, "argument-list") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _argument = new Mx.PlainRule(this, 62, "argument") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _statements = new Mx.PlainRule(this, 63, "statements") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _statement = new Mx.PlainRule(this, 64, "statement") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _returnStatement = new Mx.PlainRule(this, 65, "return-statement") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _expression = new Mx.PlainRule(this, 66, "expression") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _addlevelExpression = new Mx.PlainRule(this, 67, "addlevel-expression") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _addExpression = new Mx.PlainRule(this, 68, "add-expression") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _subExpression = new Mx.PlainRule(this, 69, "sub-expression") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _mullevelExpression = new Mx.PlainRule(this, 70, "mullevel-expression") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _mulExpression = new Mx.PlainRule(this, 71, "mul-expression") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _divExpression = new Mx.PlainRule(this, 72, "div-expression") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _remExpression = new Mx.PlainRule(this, 73, "rem-expression") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _primaryExpression = new Mx.PlainRule(this, 74, "primary-expression") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _literal = new Mx.PlainRule(this, 75, "literal") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _stringLiteral = new Mx.PlainRule(this, 76, "string-literal") { Builder = nodes => nodes[0] };
                /*  77 DfaRuleOp        */ __Matchers[77] = _plainStringLiteral = new Mx.DfaRule(this, 77, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /*  78 DfaRuleOp        */ __Matchers[78] = _verbatimStringLiteral = new Mx.DfaRule(this, 78, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /*  79 DfaRuleOp        */ __Matchers[79] = _identifier = new Mx.DfaRule(this, 79, "identifier") { Creator = node => new CIdentifier(node) };
                /*  80 EofOp            */ __Matchers[80] = new Mx.Eof(this, 80, "<eof>") { Creator = node => new REof(node) };
                /*  81 SeqOp            */ __Matchers[81] = new Mx.Seq(this, 81, "_81:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  82 AltOp            */ __Matchers[82] = new Mx.Alt(this, 82, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /*  83 StringOp         */ __Matchers[83] = new Mx.Keyword(this, 83, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /*  84 StringOp         */ __Matchers[84] = new Mx.String(this, 84, "';'", ";") { Creator = node => new RLiteral(node) };
                /*  85 SeqOp            */ __Matchers[85] = new Mx.Seq(this, 85, "_85:(>prelude,'namespace',>names,';',>declarations)") { Builder = nodes => new CNamespace(nodes) };
                /*  86 StringOp         */ __Matchers[86] = new Mx.Keyword(this, 86, "'module'", "module") { Creator = node => new RLiteral(node) };
                /*  87 SeqOp            */ __Matchers[87] = new Mx.Seq(this, 87, "_87:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /*  88 StringOp         */ __Matchers[88] = new Mx.String(this, 88, "'{'", "{") { Creator = node => new RLiteral(node) };
                /*  89 StarOp           */ __Matchers[89] = new Mx.Star(this, 89, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /*  90 StringOp         */ __Matchers[90] = new Mx.String(this, 90, "'}'", "}") { Creator = node => new RLiteral(node) };
                /*  91 SeqOp            */ __Matchers[91] = new Mx.Seq(this, 91, "_91:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /*  92 StringOp         */ __Matchers[92] = new Mx.Keyword(this, 92, "'import'", "import") { Creator = node => new RLiteral(node) };
                /*  93 SeqOp            */ __Matchers[93] = new Mx.Seq(this, 93, "_93:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /*  94 StringOp         */ __Matchers[94] = new Mx.Keyword(this, 94, "'using'", "using") { Creator = node => new RLiteral(node) };
                /*  95 SeqOp            */ __Matchers[95] = new Mx.Seq(this, 95, "_95:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /*  96 OptionalOp       */ __Matchers[96] = new Mx.Optional(this, 96, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /*  97 SeqOp            */ __Matchers[97] = new Mx.Seq(this, 97, "_97:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /*  98 StringOp         */ __Matchers[98] = new Mx.String(this, 98, "','", ",") { Creator = node => new RLiteral(node) };
                /*  99 SeqOp            */ __Matchers[99] = new Mx.Seq(this, 99, "_99:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 100 StarOp           */ __Matchers[100] = new Mx.Star(this, 100, "*(_99:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 101 SeqOp            */ __Matchers[101] = new Mx.Seq(this, 101, "_101:(>using-element,*(_99:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 102 AltOp            */ __Matchers[102] = new Mx.Alt(this, 102, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 103 OptionalOp       */ __Matchers[103] = new Mx.Optional(this, 103, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 104 OptionalOp       */ __Matchers[104] = new Mx.Optional(this, 104, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 105 SeqOp            */ __Matchers[105] = new Mx.Seq(this, 105, "_105:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 106 StringOp         */ __Matchers[106] = new Mx.String(this, 106, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 107 SeqOp            */ __Matchers[107] = new Mx.Seq(this, 107, "_107:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 108 StringOp         */ __Matchers[108] = new Mx.String(this, 108, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 109 StringOp         */ __Matchers[109] = new Mx.String(this, 109, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 110 SeqOp            */ __Matchers[110] = new Mx.Seq(this, 110, "_110:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 111 StarOp           */ __Matchers[111] = new Mx.Star(this, 111, "*(_110:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 112 SeqOp            */ __Matchers[112] = new Mx.Seq(this, 112, "_112:(>name,*(_110:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 113 SeqOp            */ __Matchers[113] = new Mx.Seq(this, 113, "_113:('.',>reference)") { Builder = nodes => new RSequence(nodes) };
                /* 114 StarOp           */ __Matchers[114] = new Mx.Star(this, 114, "*(_113:('.',>reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 115 SeqOp            */ __Matchers[115] = new Mx.Seq(this, 115, "_115:(>reference,*(_113:('.',>reference)))") { Builder = nodes => new CPath(nodes) };
                /* 116 OptionalOp       */ __Matchers[116] = new Mx.Optional(this, 116, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 117 SeqOp            */ __Matchers[117] = new Mx.Seq(this, 117, "_117:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 118 StringOp         */ __Matchers[118] = new Mx.String(this, 118, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 119 OptionalOp       */ __Matchers[119] = new Mx.Optional(this, 119, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 120 StringOp         */ __Matchers[120] = new Mx.String(this, 120, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 121 SeqOp            */ __Matchers[121] = new Mx.Seq(this, 121, "_121:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 122 SeqOp            */ __Matchers[122] = new Mx.Seq(this, 122, "_122:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 123 StarOp           */ __Matchers[123] = new Mx.Star(this, 123, "*(_122:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 124 SeqOp            */ __Matchers[124] = new Mx.Seq(this, 124, "_124:(>generic-argument,*(_122:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 125 StarOp           */ __Matchers[125] = new Mx.Star(this, 125, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 126 AltOp            */ __Matchers[126] = new Mx.Alt(this, 126, "alt(>using-declaration|>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration)") { Builder = nodes => nodes[0] };
                /* 127 StringOp         */ __Matchers[127] = new Mx.Keyword(this, 127, "'fun'", "fun") { Creator = node => new RLiteral(node) };
                /* 128 SeqOp            */ __Matchers[128] = new Mx.Seq(this, 128, "_128:(>prelude,'fun',>type,>name,>parameters,>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 129 StringOp         */ __Matchers[129] = new Mx.Keyword(this, 129, "'val'", "val") { Creator = node => new RLiteral(node) };
                /* 130 OptionalOp       */ __Matchers[130] = new Mx.Optional(this, 130, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 131 SeqOp            */ __Matchers[131] = new Mx.Seq(this, 131, "_131:(>prelude,'val',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 132 AltOp            */ __Matchers[132] = new Mx.Alt(this, 132, "alt(>expression-body|>block-body)") { Builder = nodes => nodes[0] };
                /* 133 OptionalOp       */ __Matchers[133] = new Mx.Optional(this, 133, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 134 SeqOp            */ __Matchers[134] = new Mx.Seq(this, 134, "_134:(?(>function-specifier),';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 135 StringOp         */ __Matchers[135] = new Mx.String(this, 135, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 136 SeqOp            */ __Matchers[136] = new Mx.Seq(this, 136, "_136:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 137 SeqOp            */ __Matchers[137] = new Mx.Seq(this, 137, "_137:('{',>declarations,>statements,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 138 StringOp         */ __Matchers[138] = new Mx.Keyword(this, 138, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 139 OptionalOp       */ __Matchers[139] = new Mx.Optional(this, 139, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 140 OptionalOp       */ __Matchers[140] = new Mx.Optional(this, 140, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 141 OptionalOp       */ __Matchers[141] = new Mx.Optional(this, 141, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 142 SeqOp            */ __Matchers[142] = new Mx.Seq(this, 142, "_142:(>prelude,'class',>name,?(>parameters),?(>extends),?(>case-types),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 143 StringOp         */ __Matchers[143] = new Mx.Keyword(this, 143, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 144 SeqOp            */ __Matchers[144] = new Mx.Seq(this, 144, "_144:(>prelude,'interface',>name,?(>parameters),?(>extends),?(>case-types),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 145 StringOp         */ __Matchers[145] = new Mx.String(this, 145, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 146 SeqOp            */ __Matchers[146] = new Mx.Seq(this, 146, "_146:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 147 StringOp         */ __Matchers[147] = new Mx.Keyword(this, 147, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 148 SeqOp            */ __Matchers[148] = new Mx.Seq(this, 148, "_148:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 149 StringOp         */ __Matchers[149] = new Mx.String(this, 149, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 150 SeqOp            */ __Matchers[150] = new Mx.Seq(this, 150, "_150:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 151 StarOp           */ __Matchers[151] = new Mx.Star(this, 151, "*(_150:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 152 SeqOp            */ __Matchers[152] = new Mx.Seq(this, 152, "_152:(>type,*(_150:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 153 StringOp         */ __Matchers[153] = new Mx.Keyword(this, 153, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 154 SeqOp            */ __Matchers[154] = new Mx.Seq(this, 154, "_154:(>prelude,'object',>name,?(>extends),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 155 StringOp         */ __Matchers[155] = new Mx.Keyword(this, 155, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 156 SeqOp            */ __Matchers[156] = new Mx.Seq(this, 156, "_156:(>prelude,'alias',>name,'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 157 OptionalOp       */ __Matchers[157] = new Mx.Optional(this, 157, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 158 StarOp           */ __Matchers[158] = new Mx.Star(this, 158, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 159 SeqOp            */ __Matchers[159] = new Mx.Seq(this, 159, "_159:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 160 OptionalOp       */ __Matchers[160] = new Mx.Optional(this, 160, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 161 SeqOp            */ __Matchers[161] = new Mx.Seq(this, 161, "_161:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 162 StringOp         */ __Matchers[162] = new Mx.String(this, 162, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 163 OptionalOp       */ __Matchers[163] = new Mx.Optional(this, 163, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 164 StringOp         */ __Matchers[164] = new Mx.String(this, 164, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 165 SeqOp            */ __Matchers[165] = new Mx.Seq(this, 165, "_165:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 166 SeqOp            */ __Matchers[166] = new Mx.Seq(this, 166, "_166:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 167 StarOp           */ __Matchers[167] = new Mx.Star(this, 167, "*(_166:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 168 SeqOp            */ __Matchers[168] = new Mx.Seq(this, 168, "_168:(>attribute-argument,*(_166:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 169 AltOp            */ __Matchers[169] = new Mx.Alt(this, 169, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 170 AltOp            */ __Matchers[170] = new Mx.Alt(this, 170, "alt(>class-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 171 SeqOp            */ __Matchers[171] = new Mx.Seq(this, 171, "_171:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 172 SeqOp            */ __Matchers[172] = new Mx.Seq(this, 172, "_172:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 173 StringOp         */ __Matchers[173] = new Mx.Keyword(this, 173, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 174 SeqOp            */ __Matchers[174] = new Mx.Seq(this, 174, "_174:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 175 AltOp            */ __Matchers[175] = new Mx.Alt(this, 175, "alt(>union-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 176 SeqOp            */ __Matchers[176] = new Mx.Seq(this, 176, "_176:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 177 AltOp            */ __Matchers[177] = new Mx.Alt(this, 177, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 178 StringOp         */ __Matchers[178] = new Mx.String(this, 178, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 179 SeqOp            */ __Matchers[179] = new Mx.Seq(this, 179, "_179:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 180 AltOp            */ __Matchers[180] = new Mx.Alt(this, 180, "alt(>path|>constructor)") { Builder = nodes => nodes[0] };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:(>path,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 182 OptionalOp       */ __Matchers[182] = new Mx.Optional(this, 182, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 184 SeqOp            */ __Matchers[184] = new Mx.Seq(this, 184, "_184:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 185 StarOp           */ __Matchers[185] = new Mx.Star(this, 185, "*(_184:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 186 SeqOp            */ __Matchers[186] = new Mx.Seq(this, 186, "_186:(>parameter,*(_184:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 187 SeqOp            */ __Matchers[187] = new Mx.Seq(this, 187, "_187:(>prelude,>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 188 OptionalOp       */ __Matchers[188] = new Mx.Optional(this, 188, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 189 SeqOp            */ __Matchers[189] = new Mx.Seq(this, 189, "_189:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 191 StarOp           */ __Matchers[191] = new Mx.Star(this, 191, "*(_190:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:(>argument,*(_190:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 193 StarOp           */ __Matchers[193] = new Mx.Star(this, 193, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 194 StringOp         */ __Matchers[194] = new Mx.Keyword(this, 194, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 195 OptionalOp       */ __Matchers[195] = new Mx.Optional(this, 195, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 197 AltOp            */ __Matchers[197] = new Mx.Alt(this, 197, "alt(>add-expression|>sub-expression|>mullevel-expression)") { Builder = nodes => nodes[0] };
                /* 198 StringOp         */ __Matchers[198] = new Mx.String(this, 198, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 199 SeqOp            */ __Matchers[199] = new Mx.Seq(this, 199, "_199:(>addlevel-expression,'+',>mullevel-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 200 StringOp         */ __Matchers[200] = new Mx.String(this, 200, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:(>addlevel-expression,'-',>mullevel-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 202 AltOp            */ __Matchers[202] = new Mx.Alt(this, 202, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 203 StringOp         */ __Matchers[203] = new Mx.String(this, 203, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 204 SeqOp            */ __Matchers[204] = new Mx.Seq(this, 204, "_204:(>mullevel-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 205 StringOp         */ __Matchers[205] = new Mx.String(this, 205, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 206 SeqOp            */ __Matchers[206] = new Mx.Seq(this, 206, "_206:(>mullevel-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 207 StringOp         */ __Matchers[207] = new Mx.String(this, 207, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 208 SeqOp            */ __Matchers[208] = new Mx.Seq(this, 208, "_208:(>mullevel-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 209 AltOp            */ __Matchers[209] = new Mx.Alt(this, 209, "alt(>name|>literal)") { Builder = nodes => nodes[0] };
                /* 210 AltOp            */ __Matchers[210] = new Mx.Alt(this, 210, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[81]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[82]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(_namespace);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[85]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[87]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[91]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[93]);
                /*  10 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[95]);
                /*  11 PlainRuleOp      */ _usingElements.Set(__Matchers[97]);
                /*  12 PlainRuleOp      */ _usingElementList.Set(__Matchers[101]);
                /*  13 PlainRuleOp      */ _usingElement.Set(__Matchers[102]);
                /*  14 PlainRuleOp      */ _usingNamed.Set(__Matchers[105]);
                /*  15 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  16 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[107]);
                /*  17 PlainRuleOp      */ _usingWildcard.Set(__Matchers[108]);
                /*  18 PlainRuleOp      */ _name.Set(_identifier);
                /*  19 PlainRuleOp      */ _names.Set(__Matchers[112]);
                /*  20 PlainRuleOp      */ _path.Set(__Matchers[115]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[117]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[121]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[124]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _declarations.Set(__Matchers[125]);
                /*  26 PlainRuleOp      */ _declaration.Set(__Matchers[126]);
                /*  27 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[128]);
                /*  28 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[131]);
                /*  29 PlainRuleOp      */ _functionBody.Set(__Matchers[132]);
                /*  30 PlainRuleOp      */ _attributeBody.Set(__Matchers[132]);
                /*  31 PlainRuleOp      */ _expressionBody.Set(__Matchers[134]);
                /*  32 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[136]);
                /*  33 PlainRuleOp      */ _blockBody.Set(__Matchers[137]);
                /*  34 PlainRuleOp      */ _classDeclaration.Set(__Matchers[142]);
                /*  35 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[144]);
                /*  36 PlainRuleOp      */ _extends.Set(__Matchers[146]);
                /*  37 PlainRuleOp      */ _caseTypes.Set(__Matchers[148]);
                /*  38 PlainRuleOp      */ _caseTypeList.Set(__Matchers[152]);
                /*  39 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[154]);
                /*  40 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[156]);
                /*  41 PlainRuleOp      */ _prelude.Set(__Matchers[159]);
                /*  42 PlainRuleOp      */ _attribute.Set(__Matchers[161]);
                /*  43 PlainRuleOp      */ _attributeArguments.Set(__Matchers[165]);
                /*  44 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[168]);
                /*  45 PlainRuleOp      */ _attributeArgument.Set(__Matchers[169]);
                /*  46 PlainRuleOp      */ _metaReference.Set(__Matchers[170]);
                /*  47 PlainRuleOp      */ _classReference.Set(__Matchers[171]);
                /*  48 PlainRuleOp      */ _interfaceReference.Set(__Matchers[172]);
                /*  49 PlainRuleOp      */ _functionReference.Set(__Matchers[174]);
                /*  50 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  51 PlainRuleOp      */ _unionlevelType.Set(__Matchers[175]);
                /*  52 PlainRuleOp      */ _unionType.Set(__Matchers[176]);
                /*  53 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[177]);
                /*  54 PlainRuleOp      */ _intersectionType.Set(__Matchers[179]);
                /*  55 PlainRuleOp      */ _primaryType.Set(__Matchers[180]);
                /*  56 PlainRuleOp      */ _constructor.Set(__Matchers[181]);
                /*  57 PlainRuleOp      */ _parameters.Set(__Matchers[183]);
                /*  58 PlainRuleOp      */ _parameterList.Set(__Matchers[186]);
                /*  59 PlainRuleOp      */ _parameter.Set(__Matchers[187]);
                /*  60 PlainRuleOp      */ _arguments.Set(__Matchers[189]);
                /*  61 PlainRuleOp      */ _argumentList.Set(__Matchers[192]);
                /*  62 PlainRuleOp      */ _argument.Set(_expression);
                /*  63 PlainRuleOp      */ _statements.Set(__Matchers[193]);
                /*  64 PlainRuleOp      */ _statement.Set(_returnStatement);
                /*  65 PlainRuleOp      */ _returnStatement.Set(__Matchers[196]);
                /*  66 PlainRuleOp      */ _expression.Set(_addlevelExpression);
                /*  67 PlainRuleOp      */ _addlevelExpression.Set(__Matchers[197]);
                /*  68 PlainRuleOp      */ _addExpression.Set(__Matchers[199]);
                /*  69 PlainRuleOp      */ _subExpression.Set(__Matchers[201]);
                /*  70 PlainRuleOp      */ _mullevelExpression.Set(__Matchers[202]);
                /*  71 PlainRuleOp      */ _mulExpression.Set(__Matchers[204]);
                /*  72 PlainRuleOp      */ _divExpression.Set(__Matchers[206]);
                /*  73 PlainRuleOp      */ _remExpression.Set(__Matchers[208]);
                /*  74 PlainRuleOp      */ _primaryExpression.Set(__Matchers[209]);
                /*  75 PlainRuleOp      */ _literal.Set(_stringLiteral);
                /*  76 PlainRuleOp      */ _stringLiteral.Set(__Matchers[210]);
                /*  77 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /*  78 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /*  79 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /*  81 SeqOp            */ __Matchers[81].Set(_compilationUnit, __Matchers[80]);
                /*  82 AltOp            */ __Matchers[82].Set(_moduleDescriptor, _codeUnit);
                /*  85 SeqOp            */ __Matchers[85].Set(_prelude, __Matchers[83], _names, __Matchers[84], _declarations);
                /*  87 SeqOp            */ __Matchers[87].Set(__Matchers[86], _names, _moduleBody);
                /*  89 StarOp           */ __Matchers[89].Set(_moduleBodyElement);
                /*  91 SeqOp            */ __Matchers[91].Set(__Matchers[88], __Matchers[89], __Matchers[90]);
                /*  93 SeqOp            */ __Matchers[93].Set(__Matchers[92], _names, __Matchers[84]);
                /*  95 SeqOp            */ __Matchers[95].Set(__Matchers[94], _names, _usingElements);
                /*  96 OptionalOp       */ __Matchers[96].Set(_usingElementList);
                /*  97 SeqOp            */ __Matchers[97].Set(__Matchers[88], __Matchers[96], __Matchers[90]);
                /*  99 SeqOp            */ __Matchers[99].Set(__Matchers[98], _usingElement);
                /* 100 StarOp           */ __Matchers[100].Set(__Matchers[99]);
                /* 101 SeqOp            */ __Matchers[101].Set(_usingElement, __Matchers[100]);
                /* 102 AltOp            */ __Matchers[102].Set(_usingNamed, _usingWildcard);
                /* 103 OptionalOp       */ __Matchers[103].Set(_usingNameSpecifier);
                /* 104 OptionalOp       */ __Matchers[104].Set(_usingElements);
                /* 105 SeqOp            */ __Matchers[105].Set(_usingName, __Matchers[103], __Matchers[104]);
                /* 107 SeqOp            */ __Matchers[107].Set(__Matchers[106], _identifier);
                /* 110 SeqOp            */ __Matchers[110].Set(__Matchers[109], _name);
                /* 111 StarOp           */ __Matchers[111].Set(__Matchers[110]);
                /* 112 SeqOp            */ __Matchers[112].Set(_name, __Matchers[111]);
                /* 113 SeqOp            */ __Matchers[113].Set(__Matchers[109], _reference);
                /* 114 StarOp           */ __Matchers[114].Set(__Matchers[113]);
                /* 115 SeqOp            */ __Matchers[115].Set(_reference, __Matchers[114]);
                /* 116 OptionalOp       */ __Matchers[116].Set(_genericArguments);
                /* 117 SeqOp            */ __Matchers[117].Set(_name, __Matchers[116]);
                /* 119 OptionalOp       */ __Matchers[119].Set(_genericArgumentList);
                /* 121 SeqOp            */ __Matchers[121].Set(__Matchers[118], __Matchers[119], __Matchers[120]);
                /* 122 SeqOp            */ __Matchers[122].Set(__Matchers[98], _genericArgument);
                /* 123 StarOp           */ __Matchers[123].Set(__Matchers[122]);
                /* 124 SeqOp            */ __Matchers[124].Set(_genericArgument, __Matchers[123]);
                /* 125 StarOp           */ __Matchers[125].Set(_declaration);
                /* 126 AltOp            */ __Matchers[126].Set(_usingDeclaration, _functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration);
                /* 128 SeqOp            */ __Matchers[128].Set(_prelude, __Matchers[127], _type, _name, _parameters, _functionBody);
                /* 130 OptionalOp       */ __Matchers[130].Set(_type);
                /* 131 SeqOp            */ __Matchers[131].Set(_prelude, __Matchers[129], __Matchers[130], _name, _attributeBody);
                /* 132 AltOp            */ __Matchers[132].Set(_expressionBody, _blockBody);
                /* 133 OptionalOp       */ __Matchers[133].Set(_functionSpecifier);
                /* 134 SeqOp            */ __Matchers[134].Set(__Matchers[133], __Matchers[84]);
                /* 136 SeqOp            */ __Matchers[136].Set(__Matchers[135], _expression);
                /* 137 SeqOp            */ __Matchers[137].Set(__Matchers[88], _declarations, _statements, __Matchers[90]);
                /* 139 OptionalOp       */ __Matchers[139].Set(_parameters);
                /* 140 OptionalOp       */ __Matchers[140].Set(_extends);
                /* 141 OptionalOp       */ __Matchers[141].Set(_caseTypes);
                /* 142 SeqOp            */ __Matchers[142].Set(_prelude, __Matchers[138], _name, __Matchers[139], __Matchers[140], __Matchers[141], _blockBody);
                /* 144 SeqOp            */ __Matchers[144].Set(_prelude, __Matchers[143], _name, __Matchers[139], __Matchers[140], __Matchers[141], _blockBody);
                /* 146 SeqOp            */ __Matchers[146].Set(__Matchers[145], _type);
                /* 148 SeqOp            */ __Matchers[148].Set(__Matchers[147], _caseTypeList);
                /* 150 SeqOp            */ __Matchers[150].Set(__Matchers[149], _type);
                /* 151 StarOp           */ __Matchers[151].Set(__Matchers[150]);
                /* 152 SeqOp            */ __Matchers[152].Set(_type, __Matchers[151]);
                /* 154 SeqOp            */ __Matchers[154].Set(_prelude, __Matchers[153], _name, __Matchers[140], _blockBody);
                /* 156 SeqOp            */ __Matchers[156].Set(_prelude, __Matchers[155], _name, __Matchers[135], _type, __Matchers[84]);
                /* 157 OptionalOp       */ __Matchers[157].Set(_stringLiteral);
                /* 158 StarOp           */ __Matchers[158].Set(_attribute);
                /* 159 SeqOp            */ __Matchers[159].Set(__Matchers[157], __Matchers[158]);
                /* 160 OptionalOp       */ __Matchers[160].Set(_attributeArguments);
                /* 161 SeqOp            */ __Matchers[161].Set(_name, __Matchers[160]);
                /* 163 OptionalOp       */ __Matchers[163].Set(_attributeArgumentList);
                /* 165 SeqOp            */ __Matchers[165].Set(__Matchers[162], __Matchers[163], __Matchers[164]);
                /* 166 SeqOp            */ __Matchers[166].Set(__Matchers[98], _attributeArgument);
                /* 167 StarOp           */ __Matchers[167].Set(__Matchers[166]);
                /* 168 SeqOp            */ __Matchers[168].Set(_attributeArgument, __Matchers[167]);
                /* 169 AltOp            */ __Matchers[169].Set(_stringLiteral, _metaReference);
                /* 170 AltOp            */ __Matchers[170].Set(_classReference, _interfaceReference, _functionReference);
                /* 171 SeqOp            */ __Matchers[171].Set(__Matchers[138], _names);
                /* 172 SeqOp            */ __Matchers[172].Set(__Matchers[143], _names);
                /* 174 SeqOp            */ __Matchers[174].Set(__Matchers[173], _names);
                /* 175 AltOp            */ __Matchers[175].Set(_unionType, _intersectionlevelType);
                /* 176 SeqOp            */ __Matchers[176].Set(_unionlevelType, __Matchers[149], _intersectionlevelType);
                /* 177 AltOp            */ __Matchers[177].Set(_intersectionType, _primaryType);
                /* 179 SeqOp            */ __Matchers[179].Set(_intersectionlevelType, __Matchers[178], _primaryType);
                /* 180 AltOp            */ __Matchers[180].Set(_path, _constructor);
                /* 181 SeqOp            */ __Matchers[181].Set(_path, _arguments);
                /* 182 OptionalOp       */ __Matchers[182].Set(_parameterList);
                /* 183 SeqOp            */ __Matchers[183].Set(__Matchers[162], __Matchers[182], __Matchers[164]);
                /* 184 SeqOp            */ __Matchers[184].Set(__Matchers[98], _parameter);
                /* 185 StarOp           */ __Matchers[185].Set(__Matchers[184]);
                /* 186 SeqOp            */ __Matchers[186].Set(_parameter, __Matchers[185]);
                /* 187 SeqOp            */ __Matchers[187].Set(_prelude, _type, _name);
                /* 188 OptionalOp       */ __Matchers[188].Set(_argumentList);
                /* 189 SeqOp            */ __Matchers[189].Set(__Matchers[162], __Matchers[188], __Matchers[164]);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[98], _argument);
                /* 191 StarOp           */ __Matchers[191].Set(__Matchers[190]);
                /* 192 SeqOp            */ __Matchers[192].Set(_argument, __Matchers[191]);
                /* 193 StarOp           */ __Matchers[193].Set(_statement);
                /* 195 OptionalOp       */ __Matchers[195].Set(_expression);
                /* 196 SeqOp            */ __Matchers[196].Set(__Matchers[194], __Matchers[195], __Matchers[84]);
                /* 197 AltOp            */ __Matchers[197].Set(_addExpression, _subExpression, _mullevelExpression);
                /* 199 SeqOp            */ __Matchers[199].Set(_addlevelExpression, __Matchers[198], _mullevelExpression);
                /* 201 SeqOp            */ __Matchers[201].Set(_addlevelExpression, __Matchers[200], _mullevelExpression);
                /* 202 AltOp            */ __Matchers[202].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 204 SeqOp            */ __Matchers[204].Set(_mullevelExpression, __Matchers[203], _primaryExpression);
                /* 206 SeqOp            */ __Matchers[206].Set(_mullevelExpression, __Matchers[205], _primaryExpression);
                /* 208 SeqOp            */ __Matchers[208].Set(_mullevelExpression, __Matchers[207], _primaryExpression);
                /* 209 AltOp            */ __Matchers[209].Set(_name, _literal);
                /* 210 AltOp            */ __Matchers[210].Set(_plainStringLiteral, _verbatimStringLiteral);

                __Whitespace_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, true),
                    new DfaState(5, true),
                    new DfaState(6, false),
                    new DfaState(7, false)
                );
                __Whitespace_DFA.States[0].Set(
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(9, 10), new DfaInterval(12, 13), new DfaInterval(32, 32)),
                    new DfaTrans(__Whitespace_DFA.States[2], new DfaInterval(47, 47))
                );
                __Whitespace_DFA.States[1].Set(
                    new DfaTrans(__Whitespace_DFA.States[1], new DfaInterval(9, 10), new DfaInterval(12, 13), new DfaInterval(32, 32))
                );
                __Whitespace_DFA.States[2].Set(
                    new DfaTrans(__Whitespace_DFA.States[3], new DfaInterval(47, 47)),
                    new DfaTrans(__Whitespace_DFA.States[6], new DfaInterval(42, 42))
                );
                __Whitespace_DFA.States[3].Set(
                    new DfaTrans(__Whitespace_DFA.States[3], new DfaInterval(0, 9), new DfaInterval(11, 12), new DfaInterval(14, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[4], new DfaInterval(13, 13)),
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(10, 10))
                );
                __Whitespace_DFA.States[4].Set(
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(10, 10))
                );
                __Whitespace_DFA.States[5].Set(
                );
                __Whitespace_DFA.States[6].Set(
                    new DfaTrans(__Whitespace_DFA.States[6], new DfaInterval(0, 41), new DfaInterval(43, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[7], new DfaInterval(42, 42))
                );
                __Whitespace_DFA.States[7].Set(
                    new DfaTrans(__Whitespace_DFA.States[7], new DfaInterval(42, 42)),
                    new DfaTrans(__Whitespace_DFA.States[6], new DfaInterval(0, 41), new DfaInterval(43, 46), new DfaInterval(48, 1114111)),
                    new DfaTrans(__Whitespace_DFA.States[5], new DfaInterval(47, 47))
                );
                __Keywords_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Keywords_DFA.States[0].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122))
                );
                __Keywords_DFA.States[1].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _plainStringLiteral_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, true),
                    new DfaState(6, false),
                    new DfaState(7, true),
                    new DfaState(8, false),
                    new DfaState(9, false)
                );
                _plainStringLiteral_DFA.States[0].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[1].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[2], new DfaInterval(96, 96)),
                    new DfaTrans(_plainStringLiteral_DFA.States[8], new DfaInterval(92, 92)),
                    new DfaTrans(_plainStringLiteral_DFA.States[7], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[2].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[3], new DfaInterval(92, 92)),
                    new DfaTrans(_plainStringLiteral_DFA.States[6], new DfaInterval(96, 96)),
                    new DfaTrans(_plainStringLiteral_DFA.States[7], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[3].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[4], new DfaInterval(123, 123))
                );
                _plainStringLiteral_DFA.States[4].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[4], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_plainStringLiteral_DFA.States[5], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[5].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[4], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_plainStringLiteral_DFA.States[5], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[6].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[6], new DfaInterval(96, 96)),
                    new DfaTrans(_plainStringLiteral_DFA.States[7], new DfaInterval(34, 34))
                );
                _plainStringLiteral_DFA.States[7].Set(
                );
                _plainStringLiteral_DFA.States[8].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[9], new DfaInterval(123, 123))
                );
                _plainStringLiteral_DFA.States[9].Set(
                    new DfaTrans(_plainStringLiteral_DFA.States[9], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_plainStringLiteral_DFA.States[1], new DfaInterval(125, 125))
                );
                _verbatimStringLiteral_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true)
                );
                _verbatimStringLiteral_DFA.States[0].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[1], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[1].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[2], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[2].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[3], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[3].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimStringLiteral_DFA.States[4], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[4].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimStringLiteral_DFA.States[5], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[5].Set(
                    new DfaTrans(_verbatimStringLiteral_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimStringLiteral_DFA.States[6], new DfaInterval(34, 34))
                );
                _verbatimStringLiteral_DFA.States[6].Set(
                );
                _identifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, true),
                    new DfaState(3, true),
                    new DfaState(4, true),
                    new DfaState(5, true),
                    new DfaState(6, false),
                    new DfaState(7, true),
                    new DfaState(8, true),
                    new DfaState(9, true),
                    new DfaState(10, true),
                    new DfaState(11, true),
                    new DfaState(12, false),
                    new DfaState(13, true),
                    new DfaState(14, true),
                    new DfaState(15, true),
                    new DfaState(16, true),
                    new DfaState(17, true),
                    new DfaState(18, true),
                    new DfaState(19, true),
                    new DfaState(20, true),
                    new DfaState(21, true),
                    new DfaState(22, true),
                    new DfaState(23, true),
                    new DfaState(24, true),
                    new DfaState(25, true),
                    new DfaState(26, true),
                    new DfaState(27, true),
                    new DfaState(28, true),
                    new DfaState(29, true),
                    new DfaState(30, true),
                    new DfaState(31, true),
                    new DfaState(32, true),
                    new DfaState(33, true),
                    new DfaState(34, true),
                    new DfaState(35, true),
                    new DfaState(36, true),
                    new DfaState(37, true),
                    new DfaState(38, true),
                    new DfaState(39, true),
                    new DfaState(40, true),
                    new DfaState(41, true),
                    new DfaState(42, true),
                    new DfaState(43, true),
                    new DfaState(44, true),
                    new DfaState(45, true),
                    new DfaState(46, true),
                    new DfaState(47, true),
                    new DfaState(48, true),
                    new DfaState(49, true),
                    new DfaState(50, true),
                    new DfaState(51, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 101), new DfaInterval(103, 104), new DfaInterval(106, 108), new DfaInterval(112, 113), new DfaInterval(115, 116), new DfaInterval(119, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[7], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(118, 118))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.States[2].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[3], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[3].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[4], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[4].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[5].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[6].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.States[7].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[8].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[9].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[10].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[11], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[11].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[12].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[13], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[13].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[14], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[14].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[15].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[16].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[17].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(103, 103))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(108, 108))
                );
            }

            private readonly Mx.PlainRule _compilationUnit;
            private readonly Mx.PlainRule _codeUnit;
            private readonly Mx.PlainRule _namespace;
            private readonly Mx.PlainRule _moduleDescriptor;
            private readonly Mx.PlainRule _moduleBody;
            private readonly Mx.PlainRule _moduleBodyElement;
            private readonly Mx.PlainRule _moduleImport;
            private readonly Mx.PlainRule _usingDeclaration;
            private readonly Mx.PlainRule _usingElements;
            private readonly Mx.PlainRule _usingElementList;
            private readonly Mx.PlainRule _usingElement;
            private readonly Mx.PlainRule _usingNamed;
            private readonly Mx.PlainRule _usingName;
            private readonly Mx.PlainRule _usingNameSpecifier;
            private readonly Mx.PlainRule _usingWildcard;
            private readonly Mx.PlainRule _name;
            private readonly Mx.PlainRule _names;
            private readonly Mx.PlainRule _path;
            private readonly Mx.PlainRule _reference;
            private readonly Mx.PlainRule _genericArguments;
            private readonly Mx.PlainRule _genericArgumentList;
            private readonly Mx.PlainRule _genericArgument;
            private readonly Mx.PlainRule _declarations;
            private readonly Mx.PlainRule _declaration;
            private readonly Mx.PlainRule _functionDeclaration;
            private readonly Mx.PlainRule _attributeDeclaration;
            private readonly Mx.PlainRule _functionBody;
            private readonly Mx.PlainRule _attributeBody;
            private readonly Mx.PlainRule _expressionBody;
            private readonly Mx.PlainRule _functionSpecifier;
            private readonly Mx.PlainRule _blockBody;
            private readonly Mx.PlainRule _classDeclaration;
            private readonly Mx.PlainRule _interfaceDeclaration;
            private readonly Mx.PlainRule _extends;
            private readonly Mx.PlainRule _caseTypes;
            private readonly Mx.PlainRule _caseTypeList;
            private readonly Mx.PlainRule _objectDeclaration;
            private readonly Mx.PlainRule _aliasDeclaration;
            private readonly Mx.PlainRule _prelude;
            private readonly Mx.PlainRule _attribute;
            private readonly Mx.PlainRule _attributeArguments;
            private readonly Mx.PlainRule _attributeArgumentList;
            private readonly Mx.PlainRule _attributeArgument;
            private readonly Mx.PlainRule _metaReference;
            private readonly Mx.PlainRule _classReference;
            private readonly Mx.PlainRule _interfaceReference;
            private readonly Mx.PlainRule _functionReference;
            private readonly Mx.PlainRule _type;
            private readonly Mx.PlainRule _unionlevelType;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionlevelType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _constructor;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _argumentList;
            private readonly Mx.PlainRule _argument;
            private readonly Mx.PlainRule _statements;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _returnStatement;
            private readonly Mx.PlainRule _expression;
            private readonly Mx.PlainRule _addlevelExpression;
            private readonly Mx.PlainRule _addExpression;
            private readonly Mx.PlainRule _subExpression;
            private readonly Mx.PlainRule _mullevelExpression;
            private readonly Mx.PlainRule _mulExpression;
            private readonly Mx.PlainRule _divExpression;
            private readonly Mx.PlainRule _remExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.PlainRule _literal;
            private readonly Mx.PlainRule _stringLiteral;
            private readonly Mx.DfaRule _plainStringLiteral;
            private readonly Mx.DfaRule _verbatimStringLiteral;
            private readonly Mx.DfaRule _identifier;

            private readonly Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private readonly Dfa __Keywords_DFA = new Dfa("%keywords");
            private readonly Dfa _plainStringLiteral_DFA = new Dfa("plain-string-literal");
            private readonly Dfa _verbatimStringLiteral_DFA = new Dfa("verbatim-string-literal");
            private readonly Dfa _identifier_DFA = new Dfa("identifier");
        }
    }

    public partial class SaxTree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICCompilationUnit : IRNode {}
        public interface ICCodeUnit : ICCompilationUnit {}
        public interface ICNamespace : ICCodeUnit {}
        public interface ICModuleDescriptor : ICCompilationUnit {}
        public interface ICModuleBody : IRNode {}
        public interface ICModuleBodyElement : IRNode {}
        public interface ICModuleImport : ICModuleBodyElement {}
        public interface ICUsingDeclaration : ICDeclaration {}
        public interface ICUsingElements : IRNode {}
        public interface ICUsingElementList : IRNode {}
        public interface ICUsingElement : IRNode {}
        public interface ICUsingNamed : ICUsingElement {}
        public interface ICUsingName : IRNode {}
        public interface ICUsingNameSpecifier : IRNode {}
        public interface ICUsingWildcard : ICUsingElement {}
        public interface ICName : ICPrimaryExpression {}
        public interface ICNames : IRNode {}
        public interface ICPath : ICPrimaryType {}
        public interface ICReference : IRNode {}
        public interface ICGenericArguments : IRNode {}
        public interface ICGenericArgumentList : IRNode {}
        public interface ICGenericArgument : IRNode {}
        public interface ICDeclarations : IRNode {}
        public interface ICDeclaration : IRNode {}
        public interface ICFunctionDeclaration : ICDeclaration {}
        public interface ICAttributeDeclaration : ICDeclaration {}
        public interface ICFunctionBody : IRNode {}
        public interface ICAttributeBody : IRNode {}
        public interface ICExpressionBody : ICAttributeBody, ICFunctionBody {}
        public interface ICFunctionSpecifier : IRNode {}
        public interface ICBlockBody : ICAttributeBody, ICFunctionBody {}
        public interface ICClassDeclaration : ICDeclaration {}
        public interface ICInterfaceDeclaration : ICDeclaration {}
        public interface ICExtends : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICObjectDeclaration : ICDeclaration {}
        public interface ICAliasDeclaration : ICDeclaration {}
        public interface ICPrelude : IRNode {}
        public interface ICAttribute : IRNode {}
        public interface ICAttributeArguments : IRNode {}
        public interface ICAttributeArgumentList : IRNode {}
        public interface ICAttributeArgument : IRNode {}
        public interface ICMetaReference : ICAttributeArgument {}
        public interface ICClassReference : ICMetaReference {}
        public interface ICInterfaceReference : ICMetaReference {}
        public interface ICFunctionReference : ICMetaReference {}
        public interface ICType : ICGenericArgument {}
        public interface ICUnionlevelType : ICType {}
        public interface ICUnionType : ICUnionlevelType {}
        public interface ICIntersectionlevelType : ICUnionlevelType {}
        public interface ICIntersectionType : ICIntersectionlevelType {}
        public interface ICPrimaryType : ICIntersectionlevelType {}
        public interface ICConstructor : ICPrimaryType {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICArgumentList : IRNode {}
        public interface ICArgument : IRNode {}
        public interface ICStatements : IRNode {}
        public interface ICStatement : IRNode {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICExpression : ICArgument {}
        public interface ICAddlevelExpression : ICExpression {}
        public interface ICAddExpression : ICAddlevelExpression {}
        public interface ICSubExpression : ICAddlevelExpression {}
        public interface ICMullevelExpression : ICAddlevelExpression {}
        public interface ICMulExpression : ICMullevelExpression {}
        public interface ICDivExpression : ICMullevelExpression {}
        public interface ICRemExpression : ICMullevelExpression {}
        public interface ICPrimaryExpression : ICMullevelExpression {}
        public interface ICLiteral : ICPrimaryExpression {}
        public interface ICStringLiteral : ICAttributeArgument, ICLiteral {}
        public interface ICPlainStringLiteral : ICStringLiteral {}
        public interface ICVerbatimStringLiteral : ICStringLiteral {}
        public interface ICIdentifier : ICName, ICUsingName {}

        public partial class CXStart : RSequence, ICXStart
        {
            // sequence
            public CXStart(params RNode[] children) : base(children) {}

            public ICCompilationUnit CompilationUnit => Get<ICCompilationUnit>(0);
            public REof Eof => Get<REof>(1);
        }

        public partial class CXWhitespace : RToken, ICXWhitespace
        {
            // token
            public CXWhitespace(params Node[] children) : base(children) {}
        }

        public partial class CXKeywords : RToken, ICXKeywords
        {
            // token
            public CXKeywords(params Node[] children) : base(children) {}
        }

        public partial class CNamespace : RSequence, ICNamespace
        {
            // sequence
            public CNamespace(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'namespace'
            public CNames Names => Get<CNames>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
            public CDeclarations Declarations => Get<CDeclarations>(4);
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
            // sequence
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'module'
            public CNames Names => Get<CNames>(1);
            public CModuleBody ModuleBody => Get<CModuleBody>(2);
        }

        public partial class CModuleBody : RSequence, ICModuleBody
        {
            // sequence
            public CModuleBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public RStar<ICModuleBodyElement> ModuleBodyElement => Get<RStar<ICModuleBodyElement>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
        }

        public partial class CModuleImport : RSequence, ICModuleImport
        {
            // sequence
            public CModuleImport(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'import'
            public CNames Names => Get<CNames>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CUsingDeclaration : RSequence, ICUsingDeclaration
        {
            // sequence
            public CUsingDeclaration(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'using'
            public CNames Names => Get<CNames>(1);
            public CUsingElements UsingElements => Get<CUsingElements>(2);
        }

        public partial class CUsingElements : RSequence, ICUsingElements
        {
            // sequence
            public CUsingElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public ROptional<CUsingElementList> UsingElementList => Get<ROptional<CUsingElementList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
        }

        public partial class CUsingElementList : RLoop<ICUsingElement>, ICUsingElementList
        {
            // sequence
            public CUsingElementList(params RNode[] children) : base(children) {}
        }

        public partial class CUsingNamed : RSequence, ICUsingNamed
        {
            // sequence
            public CUsingNamed(params RNode[] children) : base(children) {}

            public ICUsingName UsingName => Get<ICUsingName>(0);
            public ROptional<CUsingNameSpecifier> UsingNameSpecifier => Get<ROptional<CUsingNameSpecifier>>(1);
            public ROptional<CUsingElements> UsingElements => Get<ROptional<CUsingElements>>(2);
        }

        public partial class CUsingNameSpecifier : RSequence, ICUsingNameSpecifier
        {
            // sequence
            public CUsingNameSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public CIdentifier Identifier => Get<CIdentifier>(1);
        }

        public partial class CUsingWildcard : RLiteral, ICUsingWildcard
        {
            // string('...')
            public CUsingWildcard(params Node[] children) : base(children) {}
        }

        public partial class CNames : RLoop<ICName>, ICNames
        {
            // sequence
            public CNames(params RNode[] children) : base(children) {}
        }

        public partial class CPath : RLoop<CReference>, ICPath
        {
            // sequence
            public CPath(params RNode[] children) : base(children) {}
        }

        public partial class CReference : RSequence, ICReference
        {
            // sequence
            public CReference(params RNode[] children) : base(children) {}

            public ICName Name => Get<ICName>(0);
            public ROptional<CGenericArguments> GenericArguments => Get<ROptional<CGenericArguments>>(1);
        }

        public partial class CGenericArguments : RSequence, ICGenericArguments
        {
            // sequence
            public CGenericArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public ROptional<CGenericArgumentList> GenericArgumentList => Get<ROptional<CGenericArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '>'
        }

        public partial class CGenericArgumentList : RLoop<ICGenericArgument>, ICGenericArgumentList
        {
            // sequence
            public CGenericArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CDeclarations : RStar<ICDeclaration>, ICDeclarations
        {
            // *star*
            public CDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CFunctionDeclaration : RSequence, ICFunctionDeclaration
        {
            // sequence
            public CFunctionDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'fun'
            public ICType Type => Get<ICType>(2);
            public ICName Name => Get<ICName>(3);
            public CParameters Parameters => Get<CParameters>(4);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(5);
        }

        public partial class CAttributeDeclaration : RSequence, ICAttributeDeclaration
        {
            // sequence
            public CAttributeDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'val'
            public ROptional<ICType> Type => Get<ROptional<ICType>>(2);
            public ICName Name => Get<ICName>(3);
            public ICAttributeBody AttributeBody => Get<ICAttributeBody>(4);
        }

        public partial class CExpressionBody : RSequence, ICExpressionBody
        {
            // sequence
            public CExpressionBody(params RNode[] children) : base(children) {}

            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            // sequence
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CBlockBody : RSequence, ICBlockBody
        {
            // sequence
            public CBlockBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CDeclarations Declarations => Get<CDeclarations>(1);
            public CStatements Statements => Get<CStatements>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'class'
            public ICName Name => Get<ICName>(2);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(3);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public CBlockBody BlockBody => Get<CBlockBody>(6);
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'interface'
            public ICName Name => Get<ICName>(2);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(3);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public CBlockBody BlockBody => Get<CBlockBody>(6);
        }

        public partial class CExtends : RSequence, ICExtends
        {
            // sequence
            public CExtends(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ':'
            public ICType Type => Get<ICType>(1);
        }

        public partial class CCaseTypes : RSequence, ICCaseTypes
        {
            // sequence
            public CCaseTypes(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'of'
            public CCaseTypeList CaseTypeList => Get<CCaseTypeList>(1);
        }

        public partial class CCaseTypeList : RLoop<ICType>, ICCaseTypeList
        {
            // sequence
            public CCaseTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'object'
            public ICName Name => Get<ICName>(2);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(3);
            public CBlockBody BlockBody => Get<CBlockBody>(4);
        }

        public partial class CAliasDeclaration : RSequence, ICAliasDeclaration
        {
            // sequence
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'alias'
            public ICName Name => Get<ICName>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '=>'
            public ICType Type => Get<ICType>(4);
            public RLiteral Literal3 => Get<RLiteral>(5); // ';'
        }

        public partial class CPrelude : RSequence, ICPrelude
        {
            // sequence
            public CPrelude(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteral => Get<ROptional<ICStringLiteral>>(0);
            public RStar<CAttribute> Attribute => Get<RStar<CAttribute>>(1);
        }

        public partial class CAttribute : RSequence, ICAttribute
        {
            // sequence
            public CAttribute(params RNode[] children) : base(children) {}

            public ICName Name => Get<ICName>(0);
            public ROptional<CAttributeArguments> AttributeArguments => Get<ROptional<CAttributeArguments>>(1);
        }

        public partial class CAttributeArguments : RSequence, ICAttributeArguments
        {
            // sequence
            public CAttributeArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CAttributeArgumentList> AttributeArgumentList => Get<ROptional<CAttributeArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CAttributeArgumentList : RLoop<ICAttributeArgument>, ICAttributeArgumentList
        {
            // sequence
            public CAttributeArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CClassReference : RSequence, ICClassReference
        {
            // sequence
            public CClassReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'class'
            public CNames Names => Get<CNames>(1);
        }

        public partial class CInterfaceReference : RSequence, ICInterfaceReference
        {
            // sequence
            public CInterfaceReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'interface'
            public CNames Names => Get<CNames>(1);
        }

        public partial class CFunctionReference : RSequence, ICFunctionReference
        {
            // sequence
            public CFunctionReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'function'
            public CNames Names => Get<CNames>(1);
        }

        public partial class CUnionType : RSequence, ICUnionType
        {
            // sequence
            public CUnionType(params RNode[] children) : base(children) {}

            public ICUnionlevelType UnionlevelType => Get<ICUnionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '|'
            public ICIntersectionlevelType IntersectionlevelType => Get<ICIntersectionlevelType>(2);
        }

        public partial class CIntersectionType : RSequence, ICIntersectionType
        {
            // sequence
            public CIntersectionType(params RNode[] children) : base(children) {}

            public ICIntersectionlevelType IntersectionlevelType => Get<ICIntersectionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '&'
            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(2);
        }

        public partial class CConstructor : RSequence, ICConstructor
        {
            // sequence
            public CConstructor(params RNode[] children) : base(children) {}

            public CPath Path => Get<CPath>(0);
            public CArguments Arguments => Get<CArguments>(1);
        }

        public partial class CParameters : RSequence, ICParameters
        {
            // sequence
            public CParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CParameterList> ParameterList => Get<ROptional<CParameterList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CParameterList : RLoop<CParameter>, ICParameterList
        {
            // sequence
            public CParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CParameter : RSequence, ICParameter
        {
            // sequence
            public CParameter(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ICType Type => Get<ICType>(1);
            public ICName Name => Get<ICName>(2);
        }

        public partial class CArguments : RSequence, ICArguments
        {
            // sequence
            public CArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CArgumentList> ArgumentList => Get<ROptional<CArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CArgumentList : RLoop<ICArgument>, ICArgumentList
        {
            // sequence
            public CArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CStatements : RStar<ICStatement>, ICStatements
        {
            // *star*
            public CStatements(params RNode[] children) : base(children) {}
        }

        public partial class CReturnStatement : RSequence, ICReturnStatement
        {
            // sequence
            public CReturnStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'return'
            public ROptional<ICExpression> Expression => Get<ROptional<ICExpression>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CAddExpression : RSequence, ICAddExpression
        {
            // sequence
            public CAddExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(2);
        }

        public partial class CSubExpression : RSequence, ICSubExpression
        {
            // sequence
            public CSubExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '-'
            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(2);
        }

        public partial class CMulExpression : RSequence, ICMulExpression
        {
            // sequence
            public CMulExpression(params RNode[] children) : base(children) {}

            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '*'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CDivExpression : RSequence, ICDivExpression
        {
            // sequence
            public CDivExpression(params RNode[] children) : base(children) {}

            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '/'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CRemExpression : RSequence, ICRemExpression
        {
            // sequence
            public CRemExpression(params RNode[] children) : base(children) {}

            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '%'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CPlainStringLiteral : RToken, ICPlainStringLiteral
        {
            // token
            public CPlainStringLiteral(params Node[] children) : base(children) {}
        }

        public partial class CVerbatimStringLiteral : RToken, ICVerbatimStringLiteral
        {
            // token
            public CVerbatimStringLiteral(params Node[] children) : base(children) {}
        }

        public partial class CIdentifier : RToken, ICIdentifier
        {
            // token
            public CIdentifier(params Node[] children) : base(children) {}
        }

        public partial class DynamicSaxVisitor : DynamicVisitor
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

            protected virtual void Visit(CNamespace element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleDescriptor element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleImport element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingElements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingElementList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingNamed element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingNameSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUsingWildcard element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNames element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGenericArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGenericArgumentList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDeclarations element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAttributeDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExpressionBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBlockBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExtends element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCaseTypes element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCaseTypeList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CObjectDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAliasDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPrelude element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAttribute element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAttributeArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAttributeArgumentList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnionType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConstructor element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CParameters element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CParameterList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArgumentList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStatements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CReturnStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAddExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSubExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMulExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDivExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CRemExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPlainStringLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVerbatimStringLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIdentifier element)
            {
                DefaultImplementation(element);
            }
        }
    }
}
