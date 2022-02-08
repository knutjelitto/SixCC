// <generated from="D:\\Six\\Six.Sax\\Sax.six" at="08.02.2022 06:48:15" />

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
                : base(new Mx.Matcher[284])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new Mx.StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new Mx.WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new Mx.IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new Mx.PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _codeUnit = new Mx.PlainRule(this, 4, "code-unit") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _moduleDescriptor = new Mx.PlainRule(this, 5, "module-descriptor") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _moduleBody = new Mx.PlainRule(this, 6, "module-body") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _moduleBodyElement = new Mx.PlainRule(this, 7, "module-body-element") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _moduleImport = new Mx.PlainRule(this, 8, "module-import") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _usings = new Mx.PlainRule(this, 9, "usings") { Builder = nodes => nodes[0] };
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
                /*  20 PlainRuleOp      */ __Matchers[20] = _reference = new Mx.PlainRule(this, 20, "reference") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _genericArguments = new Mx.PlainRule(this, 21, "generic-arguments") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _genericArgumentList = new Mx.PlainRule(this, 22, "generic-argument-list") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _genericArgument = new Mx.PlainRule(this, 23, "generic-argument") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _genericParameters = new Mx.PlainRule(this, 24, "generic-parameters") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _genericParameterList = new Mx.PlainRule(this, 25, "generic-parameter-list") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _genericParameter = new Mx.PlainRule(this, 26, "generic-parameter") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _variance = new Mx.PlainRule(this, 27, "variance") { Creator = node => new CVariance(node) };
                /*  28 PlainRuleOp      */ __Matchers[28] = _declarations = new Mx.PlainRule(this, 28, "declarations") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _declaration = new Mx.PlainRule(this, 29, "declaration") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _functionDeclaration = new Mx.PlainRule(this, 30, "function-declaration") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _attributeDeclaration = new Mx.PlainRule(this, 31, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _classDeclaration = new Mx.PlainRule(this, 32, "class-declaration") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _interfaceDeclaration = new Mx.PlainRule(this, 33, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _objectDeclaration = new Mx.PlainRule(this, 34, "object-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _aliasDeclaration = new Mx.PlainRule(this, 35, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _constructorDeclaration = new Mx.PlainRule(this, 36, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _functionBody = new Mx.PlainRule(this, 37, "function-body") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _attributeBody = new Mx.PlainRule(this, 38, "attribute-body") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _blockBody = new Mx.PlainRule(this, 39, "block-body") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _statelarations = new Mx.PlainRule(this, 40, "statelarations") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _statelaration = new Mx.PlainRule(this, 41, "statelaration") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _expressionBody = new Mx.PlainRule(this, 42, "expression-body") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _nullBody = new Mx.PlainRule(this, 43, "null-body") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _functionSpecifier = new Mx.PlainRule(this, 44, "function-specifier") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _extends = new Mx.PlainRule(this, 45, "extends") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _satisfies = new Mx.PlainRule(this, 46, "satisfies") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _constraints = new Mx.PlainRule(this, 47, "constraints") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _constraint = new Mx.PlainRule(this, 48, "constraint") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _unionTypeList = new Mx.PlainRule(this, 49, "union-type-list") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _caseTypes = new Mx.PlainRule(this, 50, "case-types") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _caseTypeList = new Mx.PlainRule(this, 51, "case-type-list") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _prelude = new Mx.PlainRule(this, 52, "prelude") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _attribute = new Mx.PlainRule(this, 53, "attribute") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _attributeArguments = new Mx.PlainRule(this, 54, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _attributeArgumentList = new Mx.PlainRule(this, 55, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _attributeArgument = new Mx.PlainRule(this, 56, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _metaReference = new Mx.PlainRule(this, 57, "meta-reference") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _classReference = new Mx.PlainRule(this, 58, "class-reference") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _objectReference = new Mx.PlainRule(this, 59, "object-reference") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _valueReference = new Mx.PlainRule(this, 60, "value-reference") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _interfaceReference = new Mx.PlainRule(this, 61, "interface-reference") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _functionReference = new Mx.PlainRule(this, 62, "function-reference") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _type = new Mx.PlainRule(this, 63, "type") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _unionlevelType = new Mx.PlainRule(this, 64, "unionlevel-type") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _unionType = new Mx.PlainRule(this, 65, "union-type") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _intersectionlevelType = new Mx.PlainRule(this, 66, "intersectionlevel-type") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _intersectionType = new Mx.PlainRule(this, 67, "intersection-type") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _primaryType = new Mx.PlainRule(this, 68, "primary-type") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _arrayType = new Mx.PlainRule(this, 69, "array-type") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _typeSelector = new Mx.PlainRule(this, 70, "type-selector") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _constructor = new Mx.PlainRule(this, 71, "constructor") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _parameters = new Mx.PlainRule(this, 72, "parameters") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _parameterList = new Mx.PlainRule(this, 73, "parameter-list") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _parameter = new Mx.PlainRule(this, 74, "parameter") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _arguments = new Mx.PlainRule(this, 75, "arguments") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _argumentList = new Mx.PlainRule(this, 76, "argument-list") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _argument = new Mx.PlainRule(this, 77, "argument") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _statement = new Mx.PlainRule(this, 78, "statement") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _returnStatement = new Mx.PlainRule(this, 79, "return-statement") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _assertStatement = new Mx.PlainRule(this, 80, "assert-statement") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _expression = new Mx.PlainRule(this, 81, "expression") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _notlevelExpression = new Mx.PlainRule(this, 82, "notlevel-expression") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _notExpression = new Mx.PlainRule(this, 83, "not-expression") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _equallevelExpression = new Mx.PlainRule(this, 84, "equallevel-expression") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _equalExpression = new Mx.PlainRule(this, 85, "equal-expression") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _notEqualExpression = new Mx.PlainRule(this, 86, "not-equal-expression") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _identicalExpression = new Mx.PlainRule(this, 87, "identical-expression") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _notIdenticalExpression = new Mx.PlainRule(this, 88, "not-identical-expression") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _addlevelExpression = new Mx.PlainRule(this, 89, "addlevel-expression") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _addExpression = new Mx.PlainRule(this, 90, "add-expression") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _subExpression = new Mx.PlainRule(this, 91, "sub-expression") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _mullevelExpression = new Mx.PlainRule(this, 92, "mullevel-expression") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _mulExpression = new Mx.PlainRule(this, 93, "mul-expression") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _divExpression = new Mx.PlainRule(this, 94, "div-expression") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _remExpression = new Mx.PlainRule(this, 95, "rem-expression") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _primaryExpression = new Mx.PlainRule(this, 96, "primary-expression") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _callExpression = new Mx.PlainRule(this, 97, "call-expression") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _selectExpression = new Mx.PlainRule(this, 98, "select-expression") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _literal = new Mx.PlainRule(this, 99, "literal") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _stringLiteral = new Mx.PlainRule(this, 100, "string-literal") { Builder = nodes => nodes[0] };
                /* 101 DfaRuleOp        */ __Matchers[101] = _naturalLiteral = new Mx.DfaRule(this, 101, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 102 DfaRuleOp        */ __Matchers[102] = _plainStringLiteral = new Mx.DfaRule(this, 102, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 103 DfaRuleOp        */ __Matchers[103] = _verbatimStringLiteral = new Mx.DfaRule(this, 103, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 104 DfaRuleOp        */ __Matchers[104] = _identifier = new Mx.DfaRule(this, 104, "identifier") { Creator = node => new CIdentifier(node) };
                /* 105 EofOp            */ __Matchers[105] = new Mx.Eof(this, 105, "<eof>") { Creator = node => new REof(node) };
                /* 106 SeqOp            */ __Matchers[106] = new Mx.Seq(this, 106, "_106:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 107 AltOp            */ __Matchers[107] = new Mx.Alt(this, 107, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 108 StringOp         */ __Matchers[108] = new Mx.String(this, 108, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 109 OptionalOp       */ __Matchers[109] = new Mx.Optional(this, 109, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 110 StringOp         */ __Matchers[110] = new Mx.Keyword(this, 110, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 111 StringOp         */ __Matchers[111] = new Mx.String(this, 111, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 112 SeqOp            */ __Matchers[112] = new Mx.Seq(this, 112, "_112:(?('@skip'),>prelude,'namespace',>names,';',>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 113 StringOp         */ __Matchers[113] = new Mx.Keyword(this, 113, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 114 SeqOp            */ __Matchers[114] = new Mx.Seq(this, 114, "_114:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 115 StringOp         */ __Matchers[115] = new Mx.String(this, 115, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 116 StarOp           */ __Matchers[116] = new Mx.Star(this, 116, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 117 StringOp         */ __Matchers[117] = new Mx.String(this, 117, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 118 SeqOp            */ __Matchers[118] = new Mx.Seq(this, 118, "_118:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 119 StringOp         */ __Matchers[119] = new Mx.Keyword(this, 119, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 120 SeqOp            */ __Matchers[120] = new Mx.Seq(this, 120, "_120:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 121 StarOp           */ __Matchers[121] = new Mx.Star(this, 121, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 122 StringOp         */ __Matchers[122] = new Mx.Keyword(this, 122, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 123 SeqOp            */ __Matchers[123] = new Mx.Seq(this, 123, "_123:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 124 OptionalOp       */ __Matchers[124] = new Mx.Optional(this, 124, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 125 SeqOp            */ __Matchers[125] = new Mx.Seq(this, 125, "_125:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 126 StringOp         */ __Matchers[126] = new Mx.String(this, 126, "','", ",") { Creator = node => new RLiteral(node) };
                /* 127 SeqOp            */ __Matchers[127] = new Mx.Seq(this, 127, "_127:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 128 StarOp           */ __Matchers[128] = new Mx.Star(this, 128, "*(_127:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 129 SeqOp            */ __Matchers[129] = new Mx.Seq(this, 129, "_129:(>using-element,*(_127:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 130 AltOp            */ __Matchers[130] = new Mx.Alt(this, 130, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 131 OptionalOp       */ __Matchers[131] = new Mx.Optional(this, 131, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 132 OptionalOp       */ __Matchers[132] = new Mx.Optional(this, 132, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 133 SeqOp            */ __Matchers[133] = new Mx.Seq(this, 133, "_133:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 134 StringOp         */ __Matchers[134] = new Mx.String(this, 134, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 135 SeqOp            */ __Matchers[135] = new Mx.Seq(this, 135, "_135:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 136 StringOp         */ __Matchers[136] = new Mx.String(this, 136, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 137 StringOp         */ __Matchers[137] = new Mx.String(this, 137, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 138 SeqOp            */ __Matchers[138] = new Mx.Seq(this, 138, "_138:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 139 StarOp           */ __Matchers[139] = new Mx.Star(this, 139, "*(_138:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 140 SeqOp            */ __Matchers[140] = new Mx.Seq(this, 140, "_140:(>name,*(_138:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 141 OptionalOp       */ __Matchers[141] = new Mx.Optional(this, 141, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 142 SeqOp            */ __Matchers[142] = new Mx.Seq(this, 142, "_142:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 143 StringOp         */ __Matchers[143] = new Mx.String(this, 143, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 144 OptionalOp       */ __Matchers[144] = new Mx.Optional(this, 144, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 145 StringOp         */ __Matchers[145] = new Mx.String(this, 145, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 146 SeqOp            */ __Matchers[146] = new Mx.Seq(this, 146, "_146:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 147 SeqOp            */ __Matchers[147] = new Mx.Seq(this, 147, "_147:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 148 StarOp           */ __Matchers[148] = new Mx.Star(this, 148, "*(_147:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 149 SeqOp            */ __Matchers[149] = new Mx.Seq(this, 149, "_149:(>generic-argument,*(_147:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 150 OptionalOp       */ __Matchers[150] = new Mx.Optional(this, 150, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 151 SeqOp            */ __Matchers[151] = new Mx.Seq(this, 151, "_151:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 152 SeqOp            */ __Matchers[152] = new Mx.Seq(this, 152, "_152:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 153 StarOp           */ __Matchers[153] = new Mx.Star(this, 153, "*(_152:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 154 SeqOp            */ __Matchers[154] = new Mx.Seq(this, 154, "_154:(>generic-parameter,*(_152:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 155 OptionalOp       */ __Matchers[155] = new Mx.Optional(this, 155, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 156 SeqOp            */ __Matchers[156] = new Mx.Seq(this, 156, "_156:(?(>variance),>name)") { Builder = nodes => new CGenericParameter(nodes) };
                /* 157 StringOp         */ __Matchers[157] = new Mx.Keyword(this, 157, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 158 StringOp         */ __Matchers[158] = new Mx.Keyword(this, 158, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 159 AltOp            */ __Matchers[159] = new Mx.Alt(this, 159, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 160 StarOp           */ __Matchers[160] = new Mx.Star(this, 160, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 161 AltOp            */ __Matchers[161] = new Mx.Alt(this, 161, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 162 StringOp         */ __Matchers[162] = new Mx.Keyword(this, 162, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 163 OptionalOp       */ __Matchers[163] = new Mx.Optional(this, 163, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 164 OptionalOp       */ __Matchers[164] = new Mx.Optional(this, 164, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 165 SeqOp            */ __Matchers[165] = new Mx.Seq(this, 165, "_165:(>prelude,'function',>type,>name,?(>generic-parameters),>parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 166 StringOp         */ __Matchers[166] = new Mx.Keyword(this, 166, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 167 OptionalOp       */ __Matchers[167] = new Mx.Optional(this, 167, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 168 SeqOp            */ __Matchers[168] = new Mx.Seq(this, 168, "_168:(>prelude,'value',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 169 StringOp         */ __Matchers[169] = new Mx.Keyword(this, 169, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 170 OptionalOp       */ __Matchers[170] = new Mx.Optional(this, 170, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 171 OptionalOp       */ __Matchers[171] = new Mx.Optional(this, 171, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 172 OptionalOp       */ __Matchers[172] = new Mx.Optional(this, 172, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 173 OptionalOp       */ __Matchers[173] = new Mx.Optional(this, 173, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 174 SeqOp            */ __Matchers[174] = new Mx.Seq(this, 174, "_174:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 175 StringOp         */ __Matchers[175] = new Mx.Keyword(this, 175, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 176 SeqOp            */ __Matchers[176] = new Mx.Seq(this, 176, "_176:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 177 StringOp         */ __Matchers[177] = new Mx.Keyword(this, 177, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 178 SeqOp            */ __Matchers[178] = new Mx.Seq(this, 178, "_178:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 179 StringOp         */ __Matchers[179] = new Mx.Keyword(this, 179, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 180 StringOp         */ __Matchers[180] = new Mx.String(this, 180, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 182 StringOp         */ __Matchers[182] = new Mx.Keyword(this, 182, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 183 OptionalOp       */ __Matchers[183] = new Mx.Optional(this, 183, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 184 SeqOp            */ __Matchers[184] = new Mx.Seq(this, 184, "_184:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 185 AltOp            */ __Matchers[185] = new Mx.Alt(this, 185, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 186 SeqOp            */ __Matchers[186] = new Mx.Seq(this, 186, "_186:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 187 StarOp           */ __Matchers[187] = new Mx.Star(this, 187, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 188 AltOp            */ __Matchers[188] = new Mx.Alt(this, 188, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 189 SeqOp            */ __Matchers[189] = new Mx.Seq(this, 189, "_189:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 191 SeqOp            */ __Matchers[191] = new Mx.Seq(this, 191, "_191:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 192 StringOp         */ __Matchers[192] = new Mx.String(this, 192, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 193 SeqOp            */ __Matchers[193] = new Mx.Seq(this, 193, "_193:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 194 StringOp         */ __Matchers[194] = new Mx.Keyword(this, 194, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 195 SeqOp            */ __Matchers[195] = new Mx.Seq(this, 195, "_195:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 196 PlusOp           */ __Matchers[196] = new Mx.Plus(this, 196, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 197 StringOp         */ __Matchers[197] = new Mx.Keyword(this, 197, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 199 SeqOp            */ __Matchers[199] = new Mx.Seq(this, 199, "_199:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 200 StarOp           */ __Matchers[200] = new Mx.Star(this, 200, "*(_199:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:(>type,*(_199:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 202 StringOp         */ __Matchers[202] = new Mx.Keyword(this, 202, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 203 SeqOp            */ __Matchers[203] = new Mx.Seq(this, 203, "_203:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 204 StringOp         */ __Matchers[204] = new Mx.String(this, 204, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 206 StarOp           */ __Matchers[206] = new Mx.Star(this, 206, "*(_205:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:(>type,*(_205:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 208 OptionalOp       */ __Matchers[208] = new Mx.Optional(this, 208, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 209 StarOp           */ __Matchers[209] = new Mx.Star(this, 209, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 210 SeqOp            */ __Matchers[210] = new Mx.Seq(this, 210, "_210:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 211 OptionalOp       */ __Matchers[211] = new Mx.Optional(this, 211, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 213 StringOp         */ __Matchers[213] = new Mx.String(this, 213, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 214 OptionalOp       */ __Matchers[214] = new Mx.Optional(this, 214, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 215 StringOp         */ __Matchers[215] = new Mx.String(this, 215, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 216 SeqOp            */ __Matchers[216] = new Mx.Seq(this, 216, "_216:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 217 SeqOp            */ __Matchers[217] = new Mx.Seq(this, 217, "_217:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 218 StarOp           */ __Matchers[218] = new Mx.Star(this, 218, "*(_217:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:(>attribute-argument,*(_217:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 220 AltOp            */ __Matchers[220] = new Mx.Alt(this, 220, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 221 AltOp            */ __Matchers[221] = new Mx.Alt(this, 221, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 222 SeqOp            */ __Matchers[222] = new Mx.Seq(this, 222, "_222:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 223 SeqOp            */ __Matchers[223] = new Mx.Seq(this, 223, "_223:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 225 SeqOp            */ __Matchers[225] = new Mx.Seq(this, 225, "_225:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 227 AltOp            */ __Matchers[227] = new Mx.Alt(this, 227, "alt(>union-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 228 SeqOp            */ __Matchers[228] = new Mx.Seq(this, 228, "_228:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 229 AltOp            */ __Matchers[229] = new Mx.Alt(this, 229, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 230 StringOp         */ __Matchers[230] = new Mx.String(this, 230, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 232 AltOp            */ __Matchers[232] = new Mx.Alt(this, 232, "alt(>reference|>type-selector|>constructor|>array-type)") { Builder = nodes => nodes[0] };
                /* 233 StringOp         */ __Matchers[233] = new Mx.String(this, 233, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 234 StringOp         */ __Matchers[234] = new Mx.String(this, 234, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 236 SeqOp            */ __Matchers[236] = new Mx.Seq(this, 236, "_236:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 237 SeqOp            */ __Matchers[237] = new Mx.Seq(this, 237, "_237:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 238 OptionalOp       */ __Matchers[238] = new Mx.Optional(this, 238, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 239 SeqOp            */ __Matchers[239] = new Mx.Seq(this, 239, "_239:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 241 StarOp           */ __Matchers[241] = new Mx.Star(this, 241, "*(_240:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 242 SeqOp            */ __Matchers[242] = new Mx.Seq(this, 242, "_242:(>parameter,*(_240:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 243 SeqOp            */ __Matchers[243] = new Mx.Seq(this, 243, "_243:(>prelude,>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 244 OptionalOp       */ __Matchers[244] = new Mx.Optional(this, 244, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 246 SeqOp            */ __Matchers[246] = new Mx.Seq(this, 246, "_246:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 247 StarOp           */ __Matchers[247] = new Mx.Star(this, 247, "*(_246:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>argument,*(_246:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 249 AltOp            */ __Matchers[249] = new Mx.Alt(this, 249, "alt(>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 250 StringOp         */ __Matchers[250] = new Mx.Keyword(this, 250, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 251 OptionalOp       */ __Matchers[251] = new Mx.Optional(this, 251, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 252 SeqOp            */ __Matchers[252] = new Mx.Seq(this, 252, "_252:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 253 StringOp         */ __Matchers[253] = new Mx.Keyword(this, 253, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 254 SeqOp            */ __Matchers[254] = new Mx.Seq(this, 254, "_254:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 255 AltOp            */ __Matchers[255] = new Mx.Alt(this, 255, "alt(>not-expression|>equallevel-expression)") { Builder = nodes => nodes[0] };
                /* 256 StringOp         */ __Matchers[256] = new Mx.String(this, 256, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 257 SeqOp            */ __Matchers[257] = new Mx.Seq(this, 257, "_257:('!',>notlevel-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 258 AltOp            */ __Matchers[258] = new Mx.Alt(this, 258, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>addlevel-expression)") { Builder = nodes => nodes[0] };
                /* 259 StringOp         */ __Matchers[259] = new Mx.String(this, 259, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 260 SeqOp            */ __Matchers[260] = new Mx.Seq(this, 260, "_260:(>addlevel-expression,'==',>addlevel-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 261 StringOp         */ __Matchers[261] = new Mx.String(this, 261, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 262 SeqOp            */ __Matchers[262] = new Mx.Seq(this, 262, "_262:(>addlevel-expression,'!=',>addlevel-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 263 StringOp         */ __Matchers[263] = new Mx.String(this, 263, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 264 SeqOp            */ __Matchers[264] = new Mx.Seq(this, 264, "_264:(>addlevel-expression,'===',>addlevel-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 265 StringOp         */ __Matchers[265] = new Mx.String(this, 265, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 266 SeqOp            */ __Matchers[266] = new Mx.Seq(this, 266, "_266:(>addlevel-expression,'!==',>addlevel-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 267 AltOp            */ __Matchers[267] = new Mx.Alt(this, 267, "alt(>add-expression|>sub-expression|>mullevel-expression)") { Builder = nodes => nodes[0] };
                /* 268 StringOp         */ __Matchers[268] = new Mx.String(this, 268, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 269 SeqOp            */ __Matchers[269] = new Mx.Seq(this, 269, "_269:(>addlevel-expression,'+',>mullevel-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 270 StringOp         */ __Matchers[270] = new Mx.String(this, 270, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 271 SeqOp            */ __Matchers[271] = new Mx.Seq(this, 271, "_271:(>addlevel-expression,'-',>mullevel-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 272 AltOp            */ __Matchers[272] = new Mx.Alt(this, 272, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 273 StringOp         */ __Matchers[273] = new Mx.String(this, 273, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:(>mullevel-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 275 StringOp         */ __Matchers[275] = new Mx.String(this, 275, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(>mullevel-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 277 StringOp         */ __Matchers[277] = new Mx.String(this, 277, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 278 SeqOp            */ __Matchers[278] = new Mx.Seq(this, 278, "_278:(>mullevel-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 279 AltOp            */ __Matchers[279] = new Mx.Alt(this, 279, "alt(>reference|>literal|>call-expression|>select-expression)") { Builder = nodes => nodes[0] };
                /* 280 SeqOp            */ __Matchers[280] = new Mx.Seq(this, 280, "_280:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 281 SeqOp            */ __Matchers[281] = new Mx.Seq(this, 281, "_281:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 282 AltOp            */ __Matchers[282] = new Mx.Alt(this, 282, "alt(>string-literal|>natural-literal)") { Builder = nodes => nodes[0] };
                /* 283 AltOp            */ __Matchers[283] = new Mx.Alt(this, 283, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[106]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[107]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[112]);
                /*   5 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[114]);
                /*   6 PlainRuleOp      */ _moduleBody.Set(__Matchers[118]);
                /*   7 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   8 PlainRuleOp      */ _moduleImport.Set(__Matchers[120]);
                /*   9 PlainRuleOp      */ _usings.Set(__Matchers[121]);
                /*  10 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[123]);
                /*  11 PlainRuleOp      */ _usingElements.Set(__Matchers[125]);
                /*  12 PlainRuleOp      */ _usingElementList.Set(__Matchers[129]);
                /*  13 PlainRuleOp      */ _usingElement.Set(__Matchers[130]);
                /*  14 PlainRuleOp      */ _usingNamed.Set(__Matchers[133]);
                /*  15 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  16 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[135]);
                /*  17 PlainRuleOp      */ _usingWildcard.Set(__Matchers[136]);
                /*  18 PlainRuleOp      */ _name.Set(_identifier);
                /*  19 PlainRuleOp      */ _names.Set(__Matchers[140]);
                /*  20 PlainRuleOp      */ _reference.Set(__Matchers[142]);
                /*  21 PlainRuleOp      */ _genericArguments.Set(__Matchers[146]);
                /*  22 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[149]);
                /*  23 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  24 PlainRuleOp      */ _genericParameters.Set(__Matchers[151]);
                /*  25 PlainRuleOp      */ _genericParameterList.Set(__Matchers[154]);
                /*  26 PlainRuleOp      */ _genericParameter.Set(__Matchers[156]);
                /*  27 PlainRuleOp      */ _variance.Set(__Matchers[159]);
                /*  28 PlainRuleOp      */ _declarations.Set(__Matchers[160]);
                /*  29 PlainRuleOp      */ _declaration.Set(__Matchers[161]);
                /*  30 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[165]);
                /*  31 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[168]);
                /*  32 PlainRuleOp      */ _classDeclaration.Set(__Matchers[174]);
                /*  33 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[176]);
                /*  34 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[178]);
                /*  35 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[181]);
                /*  36 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[184]);
                /*  37 PlainRuleOp      */ _functionBody.Set(__Matchers[185]);
                /*  38 PlainRuleOp      */ _attributeBody.Set(__Matchers[185]);
                /*  39 PlainRuleOp      */ _blockBody.Set(__Matchers[186]);
                /*  40 PlainRuleOp      */ _statelarations.Set(__Matchers[187]);
                /*  41 PlainRuleOp      */ _statelaration.Set(__Matchers[188]);
                /*  42 PlainRuleOp      */ _expressionBody.Set(__Matchers[189]);
                /*  43 PlainRuleOp      */ _nullBody.Set(__Matchers[190]);
                /*  44 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[191]);
                /*  45 PlainRuleOp      */ _extends.Set(__Matchers[193]);
                /*  46 PlainRuleOp      */ _satisfies.Set(__Matchers[195]);
                /*  47 PlainRuleOp      */ _constraints.Set(__Matchers[196]);
                /*  48 PlainRuleOp      */ _constraint.Set(__Matchers[198]);
                /*  49 PlainRuleOp      */ _unionTypeList.Set(__Matchers[201]);
                /*  50 PlainRuleOp      */ _caseTypes.Set(__Matchers[203]);
                /*  51 PlainRuleOp      */ _caseTypeList.Set(__Matchers[207]);
                /*  52 PlainRuleOp      */ _prelude.Set(__Matchers[210]);
                /*  53 PlainRuleOp      */ _attribute.Set(__Matchers[212]);
                /*  54 PlainRuleOp      */ _attributeArguments.Set(__Matchers[216]);
                /*  55 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[219]);
                /*  56 PlainRuleOp      */ _attributeArgument.Set(__Matchers[220]);
                /*  57 PlainRuleOp      */ _metaReference.Set(__Matchers[221]);
                /*  58 PlainRuleOp      */ _classReference.Set(__Matchers[222]);
                /*  59 PlainRuleOp      */ _objectReference.Set(__Matchers[223]);
                /*  60 PlainRuleOp      */ _valueReference.Set(__Matchers[224]);
                /*  61 PlainRuleOp      */ _interfaceReference.Set(__Matchers[225]);
                /*  62 PlainRuleOp      */ _functionReference.Set(__Matchers[226]);
                /*  63 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  64 PlainRuleOp      */ _unionlevelType.Set(__Matchers[227]);
                /*  65 PlainRuleOp      */ _unionType.Set(__Matchers[228]);
                /*  66 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[229]);
                /*  67 PlainRuleOp      */ _intersectionType.Set(__Matchers[231]);
                /*  68 PlainRuleOp      */ _primaryType.Set(__Matchers[232]);
                /*  69 PlainRuleOp      */ _arrayType.Set(__Matchers[235]);
                /*  70 PlainRuleOp      */ _typeSelector.Set(__Matchers[236]);
                /*  71 PlainRuleOp      */ _constructor.Set(__Matchers[237]);
                /*  72 PlainRuleOp      */ _parameters.Set(__Matchers[239]);
                /*  73 PlainRuleOp      */ _parameterList.Set(__Matchers[242]);
                /*  74 PlainRuleOp      */ _parameter.Set(__Matchers[243]);
                /*  75 PlainRuleOp      */ _arguments.Set(__Matchers[245]);
                /*  76 PlainRuleOp      */ _argumentList.Set(__Matchers[248]);
                /*  77 PlainRuleOp      */ _argument.Set(_expression);
                /*  78 PlainRuleOp      */ _statement.Set(__Matchers[249]);
                /*  79 PlainRuleOp      */ _returnStatement.Set(__Matchers[252]);
                /*  80 PlainRuleOp      */ _assertStatement.Set(__Matchers[254]);
                /*  81 PlainRuleOp      */ _expression.Set(_notlevelExpression);
                /*  82 PlainRuleOp      */ _notlevelExpression.Set(__Matchers[255]);
                /*  83 PlainRuleOp      */ _notExpression.Set(__Matchers[257]);
                /*  84 PlainRuleOp      */ _equallevelExpression.Set(__Matchers[258]);
                /*  85 PlainRuleOp      */ _equalExpression.Set(__Matchers[260]);
                /*  86 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[262]);
                /*  87 PlainRuleOp      */ _identicalExpression.Set(__Matchers[264]);
                /*  88 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[266]);
                /*  89 PlainRuleOp      */ _addlevelExpression.Set(__Matchers[267]);
                /*  90 PlainRuleOp      */ _addExpression.Set(__Matchers[269]);
                /*  91 PlainRuleOp      */ _subExpression.Set(__Matchers[271]);
                /*  92 PlainRuleOp      */ _mullevelExpression.Set(__Matchers[272]);
                /*  93 PlainRuleOp      */ _mulExpression.Set(__Matchers[274]);
                /*  94 PlainRuleOp      */ _divExpression.Set(__Matchers[276]);
                /*  95 PlainRuleOp      */ _remExpression.Set(__Matchers[278]);
                /*  96 PlainRuleOp      */ _primaryExpression.Set(__Matchers[279]);
                /*  97 PlainRuleOp      */ _callExpression.Set(__Matchers[280]);
                /*  98 PlainRuleOp      */ _selectExpression.Set(__Matchers[281]);
                /*  99 PlainRuleOp      */ _literal.Set(__Matchers[282]);
                /* 100 PlainRuleOp      */ _stringLiteral.Set(__Matchers[283]);
                /* 101 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 102 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 103 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 104 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 106 SeqOp            */ __Matchers[106].Set(_compilationUnit, __Matchers[105]);
                /* 107 AltOp            */ __Matchers[107].Set(_moduleDescriptor, _codeUnit);
                /* 109 OptionalOp       */ __Matchers[109].Set(__Matchers[108]);
                /* 112 SeqOp            */ __Matchers[112].Set(__Matchers[109], _prelude, __Matchers[110], _names, __Matchers[111], _usings, _declarations);
                /* 114 SeqOp            */ __Matchers[114].Set(__Matchers[113], _names, _moduleBody);
                /* 116 StarOp           */ __Matchers[116].Set(_moduleBodyElement);
                /* 118 SeqOp            */ __Matchers[118].Set(__Matchers[115], __Matchers[116], __Matchers[117]);
                /* 120 SeqOp            */ __Matchers[120].Set(__Matchers[119], _names, __Matchers[111]);
                /* 121 StarOp           */ __Matchers[121].Set(_usingDeclaration);
                /* 123 SeqOp            */ __Matchers[123].Set(__Matchers[122], _names, _usingElements);
                /* 124 OptionalOp       */ __Matchers[124].Set(_usingElementList);
                /* 125 SeqOp            */ __Matchers[125].Set(__Matchers[115], __Matchers[124], __Matchers[117]);
                /* 127 SeqOp            */ __Matchers[127].Set(__Matchers[126], _usingElement);
                /* 128 StarOp           */ __Matchers[128].Set(__Matchers[127]);
                /* 129 SeqOp            */ __Matchers[129].Set(_usingElement, __Matchers[128]);
                /* 130 AltOp            */ __Matchers[130].Set(_usingNamed, _usingWildcard);
                /* 131 OptionalOp       */ __Matchers[131].Set(_usingNameSpecifier);
                /* 132 OptionalOp       */ __Matchers[132].Set(_usingElements);
                /* 133 SeqOp            */ __Matchers[133].Set(_usingName, __Matchers[131], __Matchers[132]);
                /* 135 SeqOp            */ __Matchers[135].Set(__Matchers[134], _identifier);
                /* 138 SeqOp            */ __Matchers[138].Set(__Matchers[137], _name);
                /* 139 StarOp           */ __Matchers[139].Set(__Matchers[138]);
                /* 140 SeqOp            */ __Matchers[140].Set(_name, __Matchers[139]);
                /* 141 OptionalOp       */ __Matchers[141].Set(_genericArguments);
                /* 142 SeqOp            */ __Matchers[142].Set(_name, __Matchers[141]);
                /* 144 OptionalOp       */ __Matchers[144].Set(_genericArgumentList);
                /* 146 SeqOp            */ __Matchers[146].Set(__Matchers[143], __Matchers[144], __Matchers[145]);
                /* 147 SeqOp            */ __Matchers[147].Set(__Matchers[126], _genericArgument);
                /* 148 StarOp           */ __Matchers[148].Set(__Matchers[147]);
                /* 149 SeqOp            */ __Matchers[149].Set(_genericArgument, __Matchers[148]);
                /* 150 OptionalOp       */ __Matchers[150].Set(_genericParameterList);
                /* 151 SeqOp            */ __Matchers[151].Set(__Matchers[143], __Matchers[150], __Matchers[145]);
                /* 152 SeqOp            */ __Matchers[152].Set(__Matchers[126], _genericParameter);
                /* 153 StarOp           */ __Matchers[153].Set(__Matchers[152]);
                /* 154 SeqOp            */ __Matchers[154].Set(_genericParameter, __Matchers[153]);
                /* 155 OptionalOp       */ __Matchers[155].Set(_variance);
                /* 156 SeqOp            */ __Matchers[156].Set(__Matchers[155], _name);
                /* 159 AltOp            */ __Matchers[159].Set(__Matchers[157], __Matchers[158]);
                /* 160 StarOp           */ __Matchers[160].Set(_declaration);
                /* 161 AltOp            */ __Matchers[161].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 163 OptionalOp       */ __Matchers[163].Set(_genericParameters);
                /* 164 OptionalOp       */ __Matchers[164].Set(_constraints);
                /* 165 SeqOp            */ __Matchers[165].Set(_prelude, __Matchers[162], _type, _name, __Matchers[163], _parameters, __Matchers[164], _functionBody);
                /* 167 OptionalOp       */ __Matchers[167].Set(_type);
                /* 168 SeqOp            */ __Matchers[168].Set(_prelude, __Matchers[166], __Matchers[167], _name, _attributeBody);
                /* 170 OptionalOp       */ __Matchers[170].Set(_parameters);
                /* 171 OptionalOp       */ __Matchers[171].Set(_extends);
                /* 172 OptionalOp       */ __Matchers[172].Set(_satisfies);
                /* 173 OptionalOp       */ __Matchers[173].Set(_caseTypes);
                /* 174 SeqOp            */ __Matchers[174].Set(_prelude, __Matchers[169], _name, __Matchers[163], __Matchers[170], __Matchers[171], __Matchers[172], __Matchers[173], __Matchers[164], _blockBody);
                /* 176 SeqOp            */ __Matchers[176].Set(_prelude, __Matchers[175], _name, __Matchers[163], __Matchers[170], __Matchers[172], __Matchers[173], __Matchers[164], _blockBody);
                /* 178 SeqOp            */ __Matchers[178].Set(_prelude, __Matchers[177], _name, __Matchers[171], __Matchers[172], _blockBody);
                /* 181 SeqOp            */ __Matchers[181].Set(_prelude, __Matchers[179], _name, __Matchers[163], __Matchers[164], __Matchers[180], _type, __Matchers[111]);
                /* 183 OptionalOp       */ __Matchers[183].Set(_name);
                /* 184 SeqOp            */ __Matchers[184].Set(_prelude, __Matchers[182], __Matchers[183], __Matchers[171], _functionBody);
                /* 185 AltOp            */ __Matchers[185].Set(_expressionBody, _blockBody, _nullBody);
                /* 186 SeqOp            */ __Matchers[186].Set(__Matchers[115], _usings, _statelarations, __Matchers[117]);
                /* 187 StarOp           */ __Matchers[187].Set(_statelaration);
                /* 188 AltOp            */ __Matchers[188].Set(_statement, _declaration);
                /* 189 SeqOp            */ __Matchers[189].Set(_functionSpecifier, __Matchers[111]);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[111]);
                /* 191 SeqOp            */ __Matchers[191].Set(__Matchers[180], _expression);
                /* 193 SeqOp            */ __Matchers[193].Set(__Matchers[192], _type);
                /* 195 SeqOp            */ __Matchers[195].Set(__Matchers[194], _unionTypeList);
                /* 196 PlusOp           */ __Matchers[196].Set(_constraint);
                /* 198 SeqOp            */ __Matchers[198].Set(__Matchers[197], _name, __Matchers[163], __Matchers[173], __Matchers[172]);
                /* 199 SeqOp            */ __Matchers[199].Set(__Matchers[126], _type);
                /* 200 StarOp           */ __Matchers[200].Set(__Matchers[199]);
                /* 201 SeqOp            */ __Matchers[201].Set(_type, __Matchers[200]);
                /* 203 SeqOp            */ __Matchers[203].Set(__Matchers[202], _caseTypeList);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[204], _type);
                /* 206 StarOp           */ __Matchers[206].Set(__Matchers[205]);
                /* 207 SeqOp            */ __Matchers[207].Set(_type, __Matchers[206]);
                /* 208 OptionalOp       */ __Matchers[208].Set(_stringLiteral);
                /* 209 StarOp           */ __Matchers[209].Set(_attribute);
                /* 210 SeqOp            */ __Matchers[210].Set(__Matchers[208], __Matchers[209]);
                /* 211 OptionalOp       */ __Matchers[211].Set(_attributeArguments);
                /* 212 SeqOp            */ __Matchers[212].Set(_name, __Matchers[211]);
                /* 214 OptionalOp       */ __Matchers[214].Set(_attributeArgumentList);
                /* 216 SeqOp            */ __Matchers[216].Set(__Matchers[213], __Matchers[214], __Matchers[215]);
                /* 217 SeqOp            */ __Matchers[217].Set(__Matchers[126], _attributeArgument);
                /* 218 StarOp           */ __Matchers[218].Set(__Matchers[217]);
                /* 219 SeqOp            */ __Matchers[219].Set(_attributeArgument, __Matchers[218]);
                /* 220 AltOp            */ __Matchers[220].Set(_stringLiteral, _metaReference);
                /* 221 AltOp            */ __Matchers[221].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 222 SeqOp            */ __Matchers[222].Set(__Matchers[169], _names);
                /* 223 SeqOp            */ __Matchers[223].Set(__Matchers[177], _names);
                /* 224 SeqOp            */ __Matchers[224].Set(__Matchers[166], _names);
                /* 225 SeqOp            */ __Matchers[225].Set(__Matchers[175], _names);
                /* 226 SeqOp            */ __Matchers[226].Set(__Matchers[162], _names);
                /* 227 AltOp            */ __Matchers[227].Set(_unionType, _intersectionlevelType);
                /* 228 SeqOp            */ __Matchers[228].Set(_unionlevelType, __Matchers[204], _intersectionlevelType);
                /* 229 AltOp            */ __Matchers[229].Set(_intersectionType, _primaryType);
                /* 231 SeqOp            */ __Matchers[231].Set(_intersectionlevelType, __Matchers[230], _primaryType);
                /* 232 AltOp            */ __Matchers[232].Set(_reference, _typeSelector, _constructor, _arrayType);
                /* 235 SeqOp            */ __Matchers[235].Set(_primaryType, __Matchers[233], __Matchers[234]);
                /* 236 SeqOp            */ __Matchers[236].Set(_primaryType, __Matchers[137], _reference);
                /* 237 SeqOp            */ __Matchers[237].Set(_primaryType, _arguments);
                /* 238 OptionalOp       */ __Matchers[238].Set(_parameterList);
                /* 239 SeqOp            */ __Matchers[239].Set(__Matchers[213], __Matchers[238], __Matchers[215]);
                /* 240 SeqOp            */ __Matchers[240].Set(__Matchers[126], _parameter);
                /* 241 StarOp           */ __Matchers[241].Set(__Matchers[240]);
                /* 242 SeqOp            */ __Matchers[242].Set(_parameter, __Matchers[241]);
                /* 243 SeqOp            */ __Matchers[243].Set(_prelude, _type, _name);
                /* 244 OptionalOp       */ __Matchers[244].Set(_argumentList);
                /* 245 SeqOp            */ __Matchers[245].Set(__Matchers[213], __Matchers[244], __Matchers[215]);
                /* 246 SeqOp            */ __Matchers[246].Set(__Matchers[126], _argument);
                /* 247 StarOp           */ __Matchers[247].Set(__Matchers[246]);
                /* 248 SeqOp            */ __Matchers[248].Set(_argument, __Matchers[247]);
                /* 249 AltOp            */ __Matchers[249].Set(_returnStatement, _assertStatement);
                /* 251 OptionalOp       */ __Matchers[251].Set(_expression);
                /* 252 SeqOp            */ __Matchers[252].Set(__Matchers[250], __Matchers[251], __Matchers[111]);
                /* 254 SeqOp            */ __Matchers[254].Set(__Matchers[208], __Matchers[253], _arguments, __Matchers[111]);
                /* 255 AltOp            */ __Matchers[255].Set(_notExpression, _equallevelExpression);
                /* 257 SeqOp            */ __Matchers[257].Set(__Matchers[256], _notlevelExpression);
                /* 258 AltOp            */ __Matchers[258].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _addlevelExpression);
                /* 260 SeqOp            */ __Matchers[260].Set(_addlevelExpression, __Matchers[259], _addlevelExpression);
                /* 262 SeqOp            */ __Matchers[262].Set(_addlevelExpression, __Matchers[261], _addlevelExpression);
                /* 264 SeqOp            */ __Matchers[264].Set(_addlevelExpression, __Matchers[263], _addlevelExpression);
                /* 266 SeqOp            */ __Matchers[266].Set(_addlevelExpression, __Matchers[265], _addlevelExpression);
                /* 267 AltOp            */ __Matchers[267].Set(_addExpression, _subExpression, _mullevelExpression);
                /* 269 SeqOp            */ __Matchers[269].Set(_addlevelExpression, __Matchers[268], _mullevelExpression);
                /* 271 SeqOp            */ __Matchers[271].Set(_addlevelExpression, __Matchers[270], _mullevelExpression);
                /* 272 AltOp            */ __Matchers[272].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 274 SeqOp            */ __Matchers[274].Set(_mullevelExpression, __Matchers[273], _primaryExpression);
                /* 276 SeqOp            */ __Matchers[276].Set(_mullevelExpression, __Matchers[275], _primaryExpression);
                /* 278 SeqOp            */ __Matchers[278].Set(_mullevelExpression, __Matchers[277], _primaryExpression);
                /* 279 AltOp            */ __Matchers[279].Set(_reference, _literal, _callExpression, _selectExpression);
                /* 280 SeqOp            */ __Matchers[280].Set(_primaryExpression, _arguments);
                /* 281 SeqOp            */ __Matchers[281].Set(_primaryExpression, __Matchers[137], _reference);
                /* 282 AltOp            */ __Matchers[282].Set(_stringLiteral, _naturalLiteral);
                /* 283 AltOp            */ __Matchers[283].Set(_plainStringLiteral, _verbatimStringLiteral);

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
                _naturalLiteral_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, false),
                    new DfaState(5, true)
                );
                _naturalLiteral_DFA.States[0].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[1], new DfaInterval(48, 57)),
                    new DfaTrans(_naturalLiteral_DFA.States[2], new DfaInterval(35, 35)),
                    new DfaTrans(_naturalLiteral_DFA.States[4], new DfaInterval(36, 36))
                );
                _naturalLiteral_DFA.States[1].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(95, 95))
                );
                _naturalLiteral_DFA.States[2].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _naturalLiteral_DFA.States[3].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(95, 95), new DfaInterval(97, 102))
                );
                _naturalLiteral_DFA.States[4].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[5], new DfaInterval(48, 49))
                );
                _naturalLiteral_DFA.States[5].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[5], new DfaInterval(48, 49), new DfaInterval(95, 95))
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
                    new DfaState(12, true),
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
                    new DfaState(24, false),
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
                    new DfaState(51, true),
                    new DfaState(52, true),
                    new DfaState(53, true),
                    new DfaState(54, true),
                    new DfaState(55, true),
                    new DfaState(56, true),
                    new DfaState(57, true),
                    new DfaState(58, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 101), new DfaInterval(103, 104), new DfaInterval(106, 108), new DfaInterval(112, 113), new DfaInterval(115, 116), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[11], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[14], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[56], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.States[2].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[3], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[7], new DfaInterval(115, 115))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[8].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[9].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[10].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[11].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[12].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[13], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[13].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[14].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[15].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[16].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[17].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(111, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(103, 103))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[54].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[55], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[55].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[56].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[57], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[57].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(114, 114))
                );
            }

            private readonly Mx.PlainRule _compilationUnit;
            private readonly Mx.PlainRule _codeUnit;
            private readonly Mx.PlainRule _moduleDescriptor;
            private readonly Mx.PlainRule _moduleBody;
            private readonly Mx.PlainRule _moduleBodyElement;
            private readonly Mx.PlainRule _moduleImport;
            private readonly Mx.PlainRule _usings;
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
            private readonly Mx.PlainRule _reference;
            private readonly Mx.PlainRule _genericArguments;
            private readonly Mx.PlainRule _genericArgumentList;
            private readonly Mx.PlainRule _genericArgument;
            private readonly Mx.PlainRule _genericParameters;
            private readonly Mx.PlainRule _genericParameterList;
            private readonly Mx.PlainRule _genericParameter;
            private readonly Mx.PlainRule _variance;
            private readonly Mx.PlainRule _declarations;
            private readonly Mx.PlainRule _declaration;
            private readonly Mx.PlainRule _functionDeclaration;
            private readonly Mx.PlainRule _attributeDeclaration;
            private readonly Mx.PlainRule _classDeclaration;
            private readonly Mx.PlainRule _interfaceDeclaration;
            private readonly Mx.PlainRule _objectDeclaration;
            private readonly Mx.PlainRule _aliasDeclaration;
            private readonly Mx.PlainRule _constructorDeclaration;
            private readonly Mx.PlainRule _functionBody;
            private readonly Mx.PlainRule _attributeBody;
            private readonly Mx.PlainRule _blockBody;
            private readonly Mx.PlainRule _statelarations;
            private readonly Mx.PlainRule _statelaration;
            private readonly Mx.PlainRule _expressionBody;
            private readonly Mx.PlainRule _nullBody;
            private readonly Mx.PlainRule _functionSpecifier;
            private readonly Mx.PlainRule _extends;
            private readonly Mx.PlainRule _satisfies;
            private readonly Mx.PlainRule _constraints;
            private readonly Mx.PlainRule _constraint;
            private readonly Mx.PlainRule _unionTypeList;
            private readonly Mx.PlainRule _caseTypes;
            private readonly Mx.PlainRule _caseTypeList;
            private readonly Mx.PlainRule _prelude;
            private readonly Mx.PlainRule _attribute;
            private readonly Mx.PlainRule _attributeArguments;
            private readonly Mx.PlainRule _attributeArgumentList;
            private readonly Mx.PlainRule _attributeArgument;
            private readonly Mx.PlainRule _metaReference;
            private readonly Mx.PlainRule _classReference;
            private readonly Mx.PlainRule _objectReference;
            private readonly Mx.PlainRule _valueReference;
            private readonly Mx.PlainRule _interfaceReference;
            private readonly Mx.PlainRule _functionReference;
            private readonly Mx.PlainRule _type;
            private readonly Mx.PlainRule _unionlevelType;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionlevelType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _arrayType;
            private readonly Mx.PlainRule _typeSelector;
            private readonly Mx.PlainRule _constructor;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _argumentList;
            private readonly Mx.PlainRule _argument;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _returnStatement;
            private readonly Mx.PlainRule _assertStatement;
            private readonly Mx.PlainRule _expression;
            private readonly Mx.PlainRule _notlevelExpression;
            private readonly Mx.PlainRule _notExpression;
            private readonly Mx.PlainRule _equallevelExpression;
            private readonly Mx.PlainRule _equalExpression;
            private readonly Mx.PlainRule _notEqualExpression;
            private readonly Mx.PlainRule _identicalExpression;
            private readonly Mx.PlainRule _notIdenticalExpression;
            private readonly Mx.PlainRule _addlevelExpression;
            private readonly Mx.PlainRule _addExpression;
            private readonly Mx.PlainRule _subExpression;
            private readonly Mx.PlainRule _mullevelExpression;
            private readonly Mx.PlainRule _mulExpression;
            private readonly Mx.PlainRule _divExpression;
            private readonly Mx.PlainRule _remExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.PlainRule _callExpression;
            private readonly Mx.PlainRule _selectExpression;
            private readonly Mx.PlainRule _literal;
            private readonly Mx.PlainRule _stringLiteral;
            private readonly Mx.DfaRule _naturalLiteral;
            private readonly Mx.DfaRule _plainStringLiteral;
            private readonly Mx.DfaRule _verbatimStringLiteral;
            private readonly Mx.DfaRule _identifier;

            private readonly Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private readonly Dfa __Keywords_DFA = new Dfa("%keywords");
            private readonly Dfa _naturalLiteral_DFA = new Dfa("natural-literal");
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
        public interface ICModuleDescriptor : ICCompilationUnit {}
        public interface ICModuleBody : IRNode {}
        public interface ICModuleBodyElement : IRNode {}
        public interface ICModuleImport : ICModuleBodyElement {}
        public interface ICUsings : IRNode {}
        public interface ICUsingDeclaration : IRNode {}
        public interface ICUsingElements : IRNode {}
        public interface ICUsingElementList : IRNode {}
        public interface ICUsingElement : IRNode {}
        public interface ICUsingNamed : ICUsingElement {}
        public interface ICUsingName : IRNode {}
        public interface ICUsingNameSpecifier : IRNode {}
        public interface ICUsingWildcard : ICUsingElement {}
        public interface ICName : IRNode {}
        public interface ICNames : IRNode {}
        public interface ICReference : ICPrimaryExpression, ICPrimaryType {}
        public interface ICGenericArguments : IRNode {}
        public interface ICGenericArgumentList : IRNode {}
        public interface ICGenericArgument : IRNode {}
        public interface ICGenericParameters : IRNode {}
        public interface ICGenericParameterList : IRNode {}
        public interface ICGenericParameter : IRNode {}
        public interface ICVariance : IRNode {}
        public interface ICDeclarations : IRNode {}
        public interface ICDeclaration : ICStatelaration {}
        public interface ICFunctionDeclaration : ICDeclaration {}
        public interface ICAttributeDeclaration : ICDeclaration {}
        public interface ICClassDeclaration : ICDeclaration {}
        public interface ICInterfaceDeclaration : ICDeclaration {}
        public interface ICObjectDeclaration : ICDeclaration {}
        public interface ICAliasDeclaration : ICDeclaration {}
        public interface ICConstructorDeclaration : ICDeclaration {}
        public interface ICFunctionBody : IRNode {}
        public interface ICAttributeBody : IRNode {}
        public interface ICBlockBody : ICAttributeBody, ICFunctionBody {}
        public interface ICStatelarations : IRNode {}
        public interface ICStatelaration : IRNode {}
        public interface ICExpressionBody : ICAttributeBody, ICFunctionBody {}
        public interface ICNullBody : ICAttributeBody, ICFunctionBody {}
        public interface ICFunctionSpecifier : IRNode {}
        public interface ICExtends : IRNode {}
        public interface ICSatisfies : IRNode {}
        public interface ICConstraints : IRNode {}
        public interface ICConstraint : IRNode {}
        public interface ICUnionTypeList : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICPrelude : IRNode {}
        public interface ICAttribute : IRNode {}
        public interface ICAttributeArguments : IRNode {}
        public interface ICAttributeArgumentList : IRNode {}
        public interface ICAttributeArgument : IRNode {}
        public interface ICMetaReference : ICAttributeArgument {}
        public interface ICClassReference : ICMetaReference {}
        public interface ICObjectReference : ICMetaReference {}
        public interface ICValueReference : ICMetaReference {}
        public interface ICInterfaceReference : ICMetaReference {}
        public interface ICFunctionReference : ICMetaReference {}
        public interface ICType : ICGenericArgument {}
        public interface ICUnionlevelType : ICType {}
        public interface ICUnionType : ICUnionlevelType {}
        public interface ICIntersectionlevelType : ICUnionlevelType {}
        public interface ICIntersectionType : ICIntersectionlevelType {}
        public interface ICPrimaryType : ICIntersectionlevelType {}
        public interface ICArrayType : ICPrimaryType {}
        public interface ICTypeSelector : ICPrimaryType {}
        public interface ICConstructor : ICPrimaryType {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICArgumentList : IRNode {}
        public interface ICArgument : IRNode {}
        public interface ICStatement : ICStatelaration {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICAssertStatement : ICStatement {}
        public interface ICExpression : ICArgument {}
        public interface ICNotlevelExpression : ICExpression {}
        public interface ICNotExpression : ICNotlevelExpression {}
        public interface ICEquallevelExpression : ICNotlevelExpression {}
        public interface ICEqualExpression : ICEquallevelExpression {}
        public interface ICNotEqualExpression : ICEquallevelExpression {}
        public interface ICIdenticalExpression : ICEquallevelExpression {}
        public interface ICNotIdenticalExpression : ICEquallevelExpression {}
        public interface ICAddlevelExpression : ICEquallevelExpression {}
        public interface ICAddExpression : ICAddlevelExpression {}
        public interface ICSubExpression : ICAddlevelExpression {}
        public interface ICMullevelExpression : ICAddlevelExpression {}
        public interface ICMulExpression : ICMullevelExpression {}
        public interface ICDivExpression : ICMullevelExpression {}
        public interface ICRemExpression : ICMullevelExpression {}
        public interface ICPrimaryExpression : ICMullevelExpression {}
        public interface ICCallExpression : ICPrimaryExpression {}
        public interface ICSelectExpression : ICPrimaryExpression {}
        public interface ICLiteral : ICPrimaryExpression {}
        public interface ICStringLiteral : ICAttributeArgument, ICLiteral {}
        public interface ICNaturalLiteral : ICLiteral {}
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

        public partial class CCodeUnit : RSequence, ICCodeUnit
        {
            // sequence
            public CCodeUnit(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public CPrelude Prelude => Get<CPrelude>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // 'namespace'
            public CNames Names => Get<CNames>(3);
            public RLiteral Literal3 => Get<RLiteral>(4); // ';'
            public CUsings Usings => Get<CUsings>(5);
            public CDeclarations Declarations => Get<CDeclarations>(6);
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

        public partial class CUsings : RStar<CUsingDeclaration>, ICUsings
        {
            // *star*
            public CUsings(params RNode[] children) : base(children) {}
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

        public partial class CGenericParameters : RSequence, ICGenericParameters
        {
            // sequence
            public CGenericParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public ROptional<CGenericParameterList> GenericParameterList => Get<ROptional<CGenericParameterList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '>'
        }

        public partial class CGenericParameterList : RLoop<CGenericParameter>, ICGenericParameterList
        {
            // sequence
            public CGenericParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CGenericParameter : RSequence, ICGenericParameter
        {
            // sequence
            public CGenericParameter(params RNode[] children) : base(children) {}

            public ROptional<ICVariance> Variance => Get<ROptional<ICVariance>>(0);
            public ICName Name => Get<ICName>(1);
        }

        public partial class CVariance : RLiteral, ICVariance
        {
            // alternatives
            public CVariance(params Node[] children) : base(children) {}
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
            public RLiteral Literal => Get<RLiteral>(1); // 'function'
            public ICType Type => Get<ICType>(2);
            public ICName Name => Get<ICName>(3);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(4);
            public CParameters Parameters => Get<CParameters>(5);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(6);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(7);
        }

        public partial class CAttributeDeclaration : RSequence, ICAttributeDeclaration
        {
            // sequence
            public CAttributeDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'value'
            public ROptional<ICType> Type => Get<ROptional<ICType>>(2);
            public ICName Name => Get<ICName>(3);
            public ICAttributeBody AttributeBody => Get<ICAttributeBody>(4);
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'class'
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(4);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(5);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(6);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(7);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(8);
            public CBlockBody BlockBody => Get<CBlockBody>(9);
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'interface'
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(4);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(5);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(6);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(7);
            public CBlockBody BlockBody => Get<CBlockBody>(8);
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'object'
            public ICName Name => Get<ICName>(2);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(3);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(4);
            public CBlockBody BlockBody => Get<CBlockBody>(5);
        }

        public partial class CAliasDeclaration : RSequence, ICAliasDeclaration
        {
            // sequence
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'alias'
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(4);
            public RLiteral Literal2 => Get<RLiteral>(5); // '=>'
            public ICType Type => Get<ICType>(6);
            public RLiteral Literal3 => Get<RLiteral>(7); // ';'
        }

        public partial class CConstructorDeclaration : RSequence, ICConstructorDeclaration
        {
            // sequence
            public CConstructorDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'new'
            public ROptional<ICName> Name => Get<ROptional<ICName>>(2);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(3);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(4);
        }

        public partial class CBlockBody : RSequence, ICBlockBody
        {
            // sequence
            public CBlockBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUsings Usings => Get<CUsings>(1);
            public CStatelarations Statelarations => Get<CStatelarations>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CStatelarations : RStar<ICStatelaration>, ICStatelarations
        {
            // *star*
            public CStatelarations(params RNode[] children) : base(children) {}
        }

        public partial class CExpressionBody : RSequence, ICExpressionBody
        {
            // sequence
            public CExpressionBody(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CNullBody : RSequence, ICNullBody
        {
            // sequence
            public CNullBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ';'
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            // sequence
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CExtends : RSequence, ICExtends
        {
            // sequence
            public CExtends(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ':'
            public ICType Type => Get<ICType>(1);
        }

        public partial class CSatisfies : RSequence, ICSatisfies
        {
            // sequence
            public CSatisfies(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'is'
            public CUnionTypeList UnionTypeList => Get<CUnionTypeList>(1);
        }

        public partial class CConstraints : RPlus<CConstraint>, ICConstraints
        {
            // +plus+
            public CConstraints(params RNode[] children) : base(children) {}
        }

        public partial class CConstraint : RSequence, ICConstraint
        {
            // sequence
            public CConstraint(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'where'
            public ICName Name => Get<ICName>(1);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(2);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(3);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(4);
        }

        public partial class CUnionTypeList : RLoop<ICType>, ICUnionTypeList
        {
            // sequence
            public CUnionTypeList(params RNode[] children) : base(children) {}
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

        public partial class CObjectReference : RSequence, ICObjectReference
        {
            // sequence
            public CObjectReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public CNames Names => Get<CNames>(1);
        }

        public partial class CValueReference : RSequence, ICValueReference
        {
            // sequence
            public CValueReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'value'
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

        public partial class CArrayType : RSequence, ICArrayType
        {
            // sequence
            public CArrayType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '['
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CTypeSelector : RSequence, ICTypeSelector
        {
            // sequence
            public CTypeSelector(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '.'
            public CReference Reference => Get<CReference>(2);
        }

        public partial class CConstructor : RSequence, ICConstructor
        {
            // sequence
            public CConstructor(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
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

        public partial class CReturnStatement : RSequence, ICReturnStatement
        {
            // sequence
            public CReturnStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'return'
            public ROptional<ICExpression> Expression => Get<ROptional<ICExpression>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CAssertStatement : RSequence, ICAssertStatement
        {
            // sequence
            public CAssertStatement(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteral => Get<ROptional<ICStringLiteral>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'assert'
            public CArguments Arguments => Get<CArguments>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
        }

        public partial class CNotExpression : RSequence, ICNotExpression
        {
            // sequence
            public CNotExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '!'
            public ICNotlevelExpression NotlevelExpression => Get<ICNotlevelExpression>(1);
        }

        public partial class CEqualExpression : RSequence, ICEqualExpression
        {
            // sequence
            public CEqualExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '=='
            public ICAddlevelExpression AddlevelExpression2 => Get<ICAddlevelExpression>(2);
        }

        public partial class CNotEqualExpression : RSequence, ICNotEqualExpression
        {
            // sequence
            public CNotEqualExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!='
            public ICAddlevelExpression AddlevelExpression2 => Get<ICAddlevelExpression>(2);
        }

        public partial class CIdenticalExpression : RSequence, ICIdenticalExpression
        {
            // sequence
            public CIdenticalExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '==='
            public ICAddlevelExpression AddlevelExpression2 => Get<ICAddlevelExpression>(2);
        }

        public partial class CNotIdenticalExpression : RSequence, ICNotIdenticalExpression
        {
            // sequence
            public CNotIdenticalExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!=='
            public ICAddlevelExpression AddlevelExpression2 => Get<ICAddlevelExpression>(2);
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

        public partial class CCallExpression : RSequence, ICCallExpression
        {
            // sequence
            public CCallExpression(params RNode[] children) : base(children) {}

            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(0);
            public CArguments Arguments => Get<CArguments>(1);
        }

        public partial class CSelectExpression : RSequence, ICSelectExpression
        {
            // sequence
            public CSelectExpression(params RNode[] children) : base(children) {}

            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '.'
            public CReference Reference => Get<CReference>(2);
        }

        public partial class CNaturalLiteral : RToken, ICNaturalLiteral
        {
            // token
            public CNaturalLiteral(params Node[] children) : base(children) {}
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

            protected virtual void Visit(CCodeUnit element)
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

            protected virtual void Visit(CUsings element)
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

            protected virtual void Visit(CGenericParameters element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGenericParameterList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGenericParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariance element)
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

            protected virtual void Visit(CClassDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceDeclaration element)
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

            protected virtual void Visit(CConstructorDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBlockBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStatelarations element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExpressionBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNullBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExtends element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSatisfies element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConstraints element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConstraint element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnionTypeList element)
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

            protected virtual void Visit(CObjectReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueReference element)
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

            protected virtual void Visit(CArrayType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeSelector element)
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

            protected virtual void Visit(CReturnStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssertStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNotExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEqualExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNotEqualExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIdenticalExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNotIdenticalExpression element)
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

            protected virtual void Visit(CCallExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSelectExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNaturalLiteral element)
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
