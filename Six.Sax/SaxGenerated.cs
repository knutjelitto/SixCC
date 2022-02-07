// <generated from="D:\\Six\\Six.Sax\\Sax.six" at="07.02.2022 06:14:05" />

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
                : base(new Mx.Matcher[280])
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
                /*  40 PlainRuleOp      */ __Matchers[40] = _expressionBody = new Mx.PlainRule(this, 40, "expression-body") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _nullBody = new Mx.PlainRule(this, 41, "null-body") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _functionSpecifier = new Mx.PlainRule(this, 42, "function-specifier") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _extends = new Mx.PlainRule(this, 43, "extends") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _satisfies = new Mx.PlainRule(this, 44, "satisfies") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _constraints = new Mx.PlainRule(this, 45, "constraints") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _constraint = new Mx.PlainRule(this, 46, "constraint") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _unionTypeList = new Mx.PlainRule(this, 47, "union-type-list") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _caseTypes = new Mx.PlainRule(this, 48, "case-types") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _caseTypeList = new Mx.PlainRule(this, 49, "case-type-list") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _prelude = new Mx.PlainRule(this, 50, "prelude") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _attribute = new Mx.PlainRule(this, 51, "attribute") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _attributeArguments = new Mx.PlainRule(this, 52, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _attributeArgumentList = new Mx.PlainRule(this, 53, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _attributeArgument = new Mx.PlainRule(this, 54, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _metaReference = new Mx.PlainRule(this, 55, "meta-reference") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _classReference = new Mx.PlainRule(this, 56, "class-reference") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _objectReference = new Mx.PlainRule(this, 57, "object-reference") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _valueReference = new Mx.PlainRule(this, 58, "value-reference") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _interfaceReference = new Mx.PlainRule(this, 59, "interface-reference") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _functionReference = new Mx.PlainRule(this, 60, "function-reference") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _type = new Mx.PlainRule(this, 61, "type") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _unionlevelType = new Mx.PlainRule(this, 62, "unionlevel-type") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _unionType = new Mx.PlainRule(this, 63, "union-type") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _intersectionlevelType = new Mx.PlainRule(this, 64, "intersectionlevel-type") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _intersectionType = new Mx.PlainRule(this, 65, "intersection-type") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _primaryType = new Mx.PlainRule(this, 66, "primary-type") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _arrayType = new Mx.PlainRule(this, 67, "array-type") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _typeSelector = new Mx.PlainRule(this, 68, "type-selector") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _constructor = new Mx.PlainRule(this, 69, "constructor") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _parameters = new Mx.PlainRule(this, 70, "parameters") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _parameterList = new Mx.PlainRule(this, 71, "parameter-list") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _parameter = new Mx.PlainRule(this, 72, "parameter") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _arguments = new Mx.PlainRule(this, 73, "arguments") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _argumentList = new Mx.PlainRule(this, 74, "argument-list") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _argument = new Mx.PlainRule(this, 75, "argument") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _statements = new Mx.PlainRule(this, 76, "statements") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _statement = new Mx.PlainRule(this, 77, "statement") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _returnStatement = new Mx.PlainRule(this, 78, "return-statement") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _assertStatement = new Mx.PlainRule(this, 79, "assert-statement") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _expression = new Mx.PlainRule(this, 80, "expression") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _notlevelExpression = new Mx.PlainRule(this, 81, "notlevel-expression") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _notExpression = new Mx.PlainRule(this, 82, "not-expression") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _equallevelExpression = new Mx.PlainRule(this, 83, "equallevel-expression") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _equalExpression = new Mx.PlainRule(this, 84, "equal-expression") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _notEqualExpression = new Mx.PlainRule(this, 85, "not-equal-expression") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _identicalExpression = new Mx.PlainRule(this, 86, "identical-expression") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _notIdenticalExpression = new Mx.PlainRule(this, 87, "not-identical-expression") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _addlevelExpression = new Mx.PlainRule(this, 88, "addlevel-expression") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _addExpression = new Mx.PlainRule(this, 89, "add-expression") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _subExpression = new Mx.PlainRule(this, 90, "sub-expression") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _mullevelExpression = new Mx.PlainRule(this, 91, "mullevel-expression") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _mulExpression = new Mx.PlainRule(this, 92, "mul-expression") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _divExpression = new Mx.PlainRule(this, 93, "div-expression") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _remExpression = new Mx.PlainRule(this, 94, "rem-expression") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _primaryExpression = new Mx.PlainRule(this, 95, "primary-expression") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _callExpression = new Mx.PlainRule(this, 96, "call-expression") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _selectExpression = new Mx.PlainRule(this, 97, "select-expression") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _literal = new Mx.PlainRule(this, 98, "literal") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _stringLiteral = new Mx.PlainRule(this, 99, "string-literal") { Builder = nodes => nodes[0] };
                /* 100 DfaRuleOp        */ __Matchers[100] = _naturalLiteral = new Mx.DfaRule(this, 100, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 101 DfaRuleOp        */ __Matchers[101] = _plainStringLiteral = new Mx.DfaRule(this, 101, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 102 DfaRuleOp        */ __Matchers[102] = _verbatimStringLiteral = new Mx.DfaRule(this, 102, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 103 DfaRuleOp        */ __Matchers[103] = _identifier = new Mx.DfaRule(this, 103, "identifier") { Creator = node => new CIdentifier(node) };
                /* 104 EofOp            */ __Matchers[104] = new Mx.Eof(this, 104, "<eof>") { Creator = node => new REof(node) };
                /* 105 SeqOp            */ __Matchers[105] = new Mx.Seq(this, 105, "_105:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 106 AltOp            */ __Matchers[106] = new Mx.Alt(this, 106, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 107 StringOp         */ __Matchers[107] = new Mx.Keyword(this, 107, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 108 StringOp         */ __Matchers[108] = new Mx.String(this, 108, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 109 SeqOp            */ __Matchers[109] = new Mx.Seq(this, 109, "_109:(>prelude,'namespace',>names,';',>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 110 StringOp         */ __Matchers[110] = new Mx.Keyword(this, 110, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 111 SeqOp            */ __Matchers[111] = new Mx.Seq(this, 111, "_111:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 112 StringOp         */ __Matchers[112] = new Mx.String(this, 112, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 113 StarOp           */ __Matchers[113] = new Mx.Star(this, 113, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 114 StringOp         */ __Matchers[114] = new Mx.String(this, 114, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 115 SeqOp            */ __Matchers[115] = new Mx.Seq(this, 115, "_115:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 116 StringOp         */ __Matchers[116] = new Mx.Keyword(this, 116, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 117 SeqOp            */ __Matchers[117] = new Mx.Seq(this, 117, "_117:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 118 StarOp           */ __Matchers[118] = new Mx.Star(this, 118, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 119 StringOp         */ __Matchers[119] = new Mx.Keyword(this, 119, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 120 SeqOp            */ __Matchers[120] = new Mx.Seq(this, 120, "_120:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 121 OptionalOp       */ __Matchers[121] = new Mx.Optional(this, 121, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 122 SeqOp            */ __Matchers[122] = new Mx.Seq(this, 122, "_122:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 123 StringOp         */ __Matchers[123] = new Mx.String(this, 123, "','", ",") { Creator = node => new RLiteral(node) };
                /* 124 SeqOp            */ __Matchers[124] = new Mx.Seq(this, 124, "_124:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 125 StarOp           */ __Matchers[125] = new Mx.Star(this, 125, "*(_124:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 126 SeqOp            */ __Matchers[126] = new Mx.Seq(this, 126, "_126:(>using-element,*(_124:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 127 AltOp            */ __Matchers[127] = new Mx.Alt(this, 127, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 128 OptionalOp       */ __Matchers[128] = new Mx.Optional(this, 128, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 129 OptionalOp       */ __Matchers[129] = new Mx.Optional(this, 129, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 130 SeqOp            */ __Matchers[130] = new Mx.Seq(this, 130, "_130:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 131 StringOp         */ __Matchers[131] = new Mx.String(this, 131, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 132 SeqOp            */ __Matchers[132] = new Mx.Seq(this, 132, "_132:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 133 StringOp         */ __Matchers[133] = new Mx.String(this, 133, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 134 StringOp         */ __Matchers[134] = new Mx.String(this, 134, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 135 SeqOp            */ __Matchers[135] = new Mx.Seq(this, 135, "_135:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 136 StarOp           */ __Matchers[136] = new Mx.Star(this, 136, "*(_135:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 137 SeqOp            */ __Matchers[137] = new Mx.Seq(this, 137, "_137:(>name,*(_135:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 138 OptionalOp       */ __Matchers[138] = new Mx.Optional(this, 138, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 139 SeqOp            */ __Matchers[139] = new Mx.Seq(this, 139, "_139:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 140 StringOp         */ __Matchers[140] = new Mx.String(this, 140, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 141 OptionalOp       */ __Matchers[141] = new Mx.Optional(this, 141, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 142 StringOp         */ __Matchers[142] = new Mx.String(this, 142, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 143 SeqOp            */ __Matchers[143] = new Mx.Seq(this, 143, "_143:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 144 SeqOp            */ __Matchers[144] = new Mx.Seq(this, 144, "_144:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 145 StarOp           */ __Matchers[145] = new Mx.Star(this, 145, "*(_144:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 146 SeqOp            */ __Matchers[146] = new Mx.Seq(this, 146, "_146:(>generic-argument,*(_144:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 147 OptionalOp       */ __Matchers[147] = new Mx.Optional(this, 147, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 148 SeqOp            */ __Matchers[148] = new Mx.Seq(this, 148, "_148:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 149 SeqOp            */ __Matchers[149] = new Mx.Seq(this, 149, "_149:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 150 StarOp           */ __Matchers[150] = new Mx.Star(this, 150, "*(_149:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 151 SeqOp            */ __Matchers[151] = new Mx.Seq(this, 151, "_151:(>generic-parameter,*(_149:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 152 OptionalOp       */ __Matchers[152] = new Mx.Optional(this, 152, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 153 SeqOp            */ __Matchers[153] = new Mx.Seq(this, 153, "_153:(?(>variance),>name)") { Builder = nodes => new CGenericParameter(nodes) };
                /* 154 StringOp         */ __Matchers[154] = new Mx.Keyword(this, 154, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 155 StringOp         */ __Matchers[155] = new Mx.Keyword(this, 155, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 156 AltOp            */ __Matchers[156] = new Mx.Alt(this, 156, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 157 StarOp           */ __Matchers[157] = new Mx.Star(this, 157, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 158 AltOp            */ __Matchers[158] = new Mx.Alt(this, 158, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 159 StringOp         */ __Matchers[159] = new Mx.Keyword(this, 159, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 160 OptionalOp       */ __Matchers[160] = new Mx.Optional(this, 160, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 161 OptionalOp       */ __Matchers[161] = new Mx.Optional(this, 161, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 162 SeqOp            */ __Matchers[162] = new Mx.Seq(this, 162, "_162:(>prelude,'function',>type,>name,?(>generic-parameters),>parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 163 StringOp         */ __Matchers[163] = new Mx.Keyword(this, 163, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 164 OptionalOp       */ __Matchers[164] = new Mx.Optional(this, 164, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 165 SeqOp            */ __Matchers[165] = new Mx.Seq(this, 165, "_165:(>prelude,'value',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 166 StringOp         */ __Matchers[166] = new Mx.Keyword(this, 166, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 167 OptionalOp       */ __Matchers[167] = new Mx.Optional(this, 167, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 168 OptionalOp       */ __Matchers[168] = new Mx.Optional(this, 168, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 169 OptionalOp       */ __Matchers[169] = new Mx.Optional(this, 169, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 170 OptionalOp       */ __Matchers[170] = new Mx.Optional(this, 170, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 171 SeqOp            */ __Matchers[171] = new Mx.Seq(this, 171, "_171:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 172 StringOp         */ __Matchers[172] = new Mx.Keyword(this, 172, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 173 SeqOp            */ __Matchers[173] = new Mx.Seq(this, 173, "_173:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 174 StringOp         */ __Matchers[174] = new Mx.Keyword(this, 174, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 175 SeqOp            */ __Matchers[175] = new Mx.Seq(this, 175, "_175:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 176 StringOp         */ __Matchers[176] = new Mx.Keyword(this, 176, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 177 StringOp         */ __Matchers[177] = new Mx.String(this, 177, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 178 SeqOp            */ __Matchers[178] = new Mx.Seq(this, 178, "_178:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 179 StringOp         */ __Matchers[179] = new Mx.Keyword(this, 179, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 180 OptionalOp       */ __Matchers[180] = new Mx.Optional(this, 180, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 182 AltOp            */ __Matchers[182] = new Mx.Alt(this, 182, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:('{',>usings,>declarations,>statements,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 184 SeqOp            */ __Matchers[184] = new Mx.Seq(this, 184, "_184:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 185 SeqOp            */ __Matchers[185] = new Mx.Seq(this, 185, "_185:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 186 SeqOp            */ __Matchers[186] = new Mx.Seq(this, 186, "_186:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 187 StringOp         */ __Matchers[187] = new Mx.String(this, 187, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 188 SeqOp            */ __Matchers[188] = new Mx.Seq(this, 188, "_188:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.Keyword(this, 189, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 191 PlusOp           */ __Matchers[191] = new Mx.Plus(this, 191, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 192 StringOp         */ __Matchers[192] = new Mx.Keyword(this, 192, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 193 SeqOp            */ __Matchers[193] = new Mx.Seq(this, 193, "_193:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 194 SeqOp            */ __Matchers[194] = new Mx.Seq(this, 194, "_194:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 195 StarOp           */ __Matchers[195] = new Mx.Star(this, 195, "*(_194:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:(>type,*(_194:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 197 StringOp         */ __Matchers[197] = new Mx.Keyword(this, 197, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 199 StringOp         */ __Matchers[199] = new Mx.String(this, 199, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 201 StarOp           */ __Matchers[201] = new Mx.Star(this, 201, "*(_200:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 202 SeqOp            */ __Matchers[202] = new Mx.Seq(this, 202, "_202:(>type,*(_200:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 203 OptionalOp       */ __Matchers[203] = new Mx.Optional(this, 203, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 204 StarOp           */ __Matchers[204] = new Mx.Star(this, 204, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 206 OptionalOp       */ __Matchers[206] = new Mx.Optional(this, 206, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 208 StringOp         */ __Matchers[208] = new Mx.String(this, 208, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 209 OptionalOp       */ __Matchers[209] = new Mx.Optional(this, 209, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 210 StringOp         */ __Matchers[210] = new Mx.String(this, 210, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 211 SeqOp            */ __Matchers[211] = new Mx.Seq(this, 211, "_211:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 213 StarOp           */ __Matchers[213] = new Mx.Star(this, 213, "*(_212:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 214 SeqOp            */ __Matchers[214] = new Mx.Seq(this, 214, "_214:(>attribute-argument,*(_212:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 215 AltOp            */ __Matchers[215] = new Mx.Alt(this, 215, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 216 AltOp            */ __Matchers[216] = new Mx.Alt(this, 216, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 217 SeqOp            */ __Matchers[217] = new Mx.Seq(this, 217, "_217:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 218 SeqOp            */ __Matchers[218] = new Mx.Seq(this, 218, "_218:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 220 SeqOp            */ __Matchers[220] = new Mx.Seq(this, 220, "_220:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 222 AltOp            */ __Matchers[222] = new Mx.Alt(this, 222, "alt(>union-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 223 SeqOp            */ __Matchers[223] = new Mx.Seq(this, 223, "_223:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 224 AltOp            */ __Matchers[224] = new Mx.Alt(this, 224, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 225 StringOp         */ __Matchers[225] = new Mx.String(this, 225, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 227 AltOp            */ __Matchers[227] = new Mx.Alt(this, 227, "alt(>reference|>type-selector|>constructor|>array-type)") { Builder = nodes => nodes[0] };
                /* 228 StringOp         */ __Matchers[228] = new Mx.String(this, 228, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 229 StringOp         */ __Matchers[229] = new Mx.String(this, 229, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 230 SeqOp            */ __Matchers[230] = new Mx.Seq(this, 230, "_230:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 232 SeqOp            */ __Matchers[232] = new Mx.Seq(this, 232, "_232:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 233 OptionalOp       */ __Matchers[233] = new Mx.Optional(this, 233, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 234 SeqOp            */ __Matchers[234] = new Mx.Seq(this, 234, "_234:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 236 StarOp           */ __Matchers[236] = new Mx.Star(this, 236, "*(_235:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 237 SeqOp            */ __Matchers[237] = new Mx.Seq(this, 237, "_237:(>parameter,*(_235:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 238 SeqOp            */ __Matchers[238] = new Mx.Seq(this, 238, "_238:(>prelude,>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 239 OptionalOp       */ __Matchers[239] = new Mx.Optional(this, 239, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 241 SeqOp            */ __Matchers[241] = new Mx.Seq(this, 241, "_241:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 242 StarOp           */ __Matchers[242] = new Mx.Star(this, 242, "*(_241:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 243 SeqOp            */ __Matchers[243] = new Mx.Seq(this, 243, "_243:(>argument,*(_241:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 244 StarOp           */ __Matchers[244] = new Mx.Star(this, 244, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 245 AltOp            */ __Matchers[245] = new Mx.Alt(this, 245, "alt(>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 246 StringOp         */ __Matchers[246] = new Mx.Keyword(this, 246, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 247 OptionalOp       */ __Matchers[247] = new Mx.Optional(this, 247, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.Keyword(this, 249, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 251 AltOp            */ __Matchers[251] = new Mx.Alt(this, 251, "alt(>not-expression|>equallevel-expression)") { Builder = nodes => nodes[0] };
                /* 252 StringOp         */ __Matchers[252] = new Mx.String(this, 252, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 253 SeqOp            */ __Matchers[253] = new Mx.Seq(this, 253, "_253:('!',>notlevel-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 254 AltOp            */ __Matchers[254] = new Mx.Alt(this, 254, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>addlevel-expression)") { Builder = nodes => nodes[0] };
                /* 255 StringOp         */ __Matchers[255] = new Mx.String(this, 255, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 256 SeqOp            */ __Matchers[256] = new Mx.Seq(this, 256, "_256:(>addlevel-expression,'==',>addlevel-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 257 StringOp         */ __Matchers[257] = new Mx.String(this, 257, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 258 SeqOp            */ __Matchers[258] = new Mx.Seq(this, 258, "_258:(>addlevel-expression,'!=',>addlevel-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 259 StringOp         */ __Matchers[259] = new Mx.String(this, 259, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 260 SeqOp            */ __Matchers[260] = new Mx.Seq(this, 260, "_260:(>addlevel-expression,'===',>addlevel-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 261 StringOp         */ __Matchers[261] = new Mx.String(this, 261, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 262 SeqOp            */ __Matchers[262] = new Mx.Seq(this, 262, "_262:(>addlevel-expression,'!==',>addlevel-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 263 AltOp            */ __Matchers[263] = new Mx.Alt(this, 263, "alt(>add-expression|>sub-expression|>mullevel-expression)") { Builder = nodes => nodes[0] };
                /* 264 StringOp         */ __Matchers[264] = new Mx.String(this, 264, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 265 SeqOp            */ __Matchers[265] = new Mx.Seq(this, 265, "_265:(>addlevel-expression,'+',>mullevel-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 266 StringOp         */ __Matchers[266] = new Mx.String(this, 266, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 267 SeqOp            */ __Matchers[267] = new Mx.Seq(this, 267, "_267:(>addlevel-expression,'-',>mullevel-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 268 AltOp            */ __Matchers[268] = new Mx.Alt(this, 268, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 269 StringOp         */ __Matchers[269] = new Mx.String(this, 269, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 270 SeqOp            */ __Matchers[270] = new Mx.Seq(this, 270, "_270:(>mullevel-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 271 StringOp         */ __Matchers[271] = new Mx.String(this, 271, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 272 SeqOp            */ __Matchers[272] = new Mx.Seq(this, 272, "_272:(>mullevel-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 273 StringOp         */ __Matchers[273] = new Mx.String(this, 273, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:(>mullevel-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 275 AltOp            */ __Matchers[275] = new Mx.Alt(this, 275, "alt(>reference|>literal|>call-expression|>select-expression)") { Builder = nodes => nodes[0] };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 278 AltOp            */ __Matchers[278] = new Mx.Alt(this, 278, "alt(>string-literal|>natural-literal)") { Builder = nodes => nodes[0] };
                /* 279 AltOp            */ __Matchers[279] = new Mx.Alt(this, 279, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[105]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[106]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[109]);
                /*   5 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[111]);
                /*   6 PlainRuleOp      */ _moduleBody.Set(__Matchers[115]);
                /*   7 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   8 PlainRuleOp      */ _moduleImport.Set(__Matchers[117]);
                /*   9 PlainRuleOp      */ _usings.Set(__Matchers[118]);
                /*  10 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[120]);
                /*  11 PlainRuleOp      */ _usingElements.Set(__Matchers[122]);
                /*  12 PlainRuleOp      */ _usingElementList.Set(__Matchers[126]);
                /*  13 PlainRuleOp      */ _usingElement.Set(__Matchers[127]);
                /*  14 PlainRuleOp      */ _usingNamed.Set(__Matchers[130]);
                /*  15 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  16 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[132]);
                /*  17 PlainRuleOp      */ _usingWildcard.Set(__Matchers[133]);
                /*  18 PlainRuleOp      */ _name.Set(_identifier);
                /*  19 PlainRuleOp      */ _names.Set(__Matchers[137]);
                /*  20 PlainRuleOp      */ _reference.Set(__Matchers[139]);
                /*  21 PlainRuleOp      */ _genericArguments.Set(__Matchers[143]);
                /*  22 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[146]);
                /*  23 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  24 PlainRuleOp      */ _genericParameters.Set(__Matchers[148]);
                /*  25 PlainRuleOp      */ _genericParameterList.Set(__Matchers[151]);
                /*  26 PlainRuleOp      */ _genericParameter.Set(__Matchers[153]);
                /*  27 PlainRuleOp      */ _variance.Set(__Matchers[156]);
                /*  28 PlainRuleOp      */ _declarations.Set(__Matchers[157]);
                /*  29 PlainRuleOp      */ _declaration.Set(__Matchers[158]);
                /*  30 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[162]);
                /*  31 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[165]);
                /*  32 PlainRuleOp      */ _classDeclaration.Set(__Matchers[171]);
                /*  33 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[173]);
                /*  34 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[175]);
                /*  35 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[178]);
                /*  36 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[181]);
                /*  37 PlainRuleOp      */ _functionBody.Set(__Matchers[182]);
                /*  38 PlainRuleOp      */ _attributeBody.Set(__Matchers[182]);
                /*  39 PlainRuleOp      */ _blockBody.Set(__Matchers[183]);
                /*  40 PlainRuleOp      */ _expressionBody.Set(__Matchers[184]);
                /*  41 PlainRuleOp      */ _nullBody.Set(__Matchers[185]);
                /*  42 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[186]);
                /*  43 PlainRuleOp      */ _extends.Set(__Matchers[188]);
                /*  44 PlainRuleOp      */ _satisfies.Set(__Matchers[190]);
                /*  45 PlainRuleOp      */ _constraints.Set(__Matchers[191]);
                /*  46 PlainRuleOp      */ _constraint.Set(__Matchers[193]);
                /*  47 PlainRuleOp      */ _unionTypeList.Set(__Matchers[196]);
                /*  48 PlainRuleOp      */ _caseTypes.Set(__Matchers[198]);
                /*  49 PlainRuleOp      */ _caseTypeList.Set(__Matchers[202]);
                /*  50 PlainRuleOp      */ _prelude.Set(__Matchers[205]);
                /*  51 PlainRuleOp      */ _attribute.Set(__Matchers[207]);
                /*  52 PlainRuleOp      */ _attributeArguments.Set(__Matchers[211]);
                /*  53 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[214]);
                /*  54 PlainRuleOp      */ _attributeArgument.Set(__Matchers[215]);
                /*  55 PlainRuleOp      */ _metaReference.Set(__Matchers[216]);
                /*  56 PlainRuleOp      */ _classReference.Set(__Matchers[217]);
                /*  57 PlainRuleOp      */ _objectReference.Set(__Matchers[218]);
                /*  58 PlainRuleOp      */ _valueReference.Set(__Matchers[219]);
                /*  59 PlainRuleOp      */ _interfaceReference.Set(__Matchers[220]);
                /*  60 PlainRuleOp      */ _functionReference.Set(__Matchers[221]);
                /*  61 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  62 PlainRuleOp      */ _unionlevelType.Set(__Matchers[222]);
                /*  63 PlainRuleOp      */ _unionType.Set(__Matchers[223]);
                /*  64 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[224]);
                /*  65 PlainRuleOp      */ _intersectionType.Set(__Matchers[226]);
                /*  66 PlainRuleOp      */ _primaryType.Set(__Matchers[227]);
                /*  67 PlainRuleOp      */ _arrayType.Set(__Matchers[230]);
                /*  68 PlainRuleOp      */ _typeSelector.Set(__Matchers[231]);
                /*  69 PlainRuleOp      */ _constructor.Set(__Matchers[232]);
                /*  70 PlainRuleOp      */ _parameters.Set(__Matchers[234]);
                /*  71 PlainRuleOp      */ _parameterList.Set(__Matchers[237]);
                /*  72 PlainRuleOp      */ _parameter.Set(__Matchers[238]);
                /*  73 PlainRuleOp      */ _arguments.Set(__Matchers[240]);
                /*  74 PlainRuleOp      */ _argumentList.Set(__Matchers[243]);
                /*  75 PlainRuleOp      */ _argument.Set(_expression);
                /*  76 PlainRuleOp      */ _statements.Set(__Matchers[244]);
                /*  77 PlainRuleOp      */ _statement.Set(__Matchers[245]);
                /*  78 PlainRuleOp      */ _returnStatement.Set(__Matchers[248]);
                /*  79 PlainRuleOp      */ _assertStatement.Set(__Matchers[250]);
                /*  80 PlainRuleOp      */ _expression.Set(_notlevelExpression);
                /*  81 PlainRuleOp      */ _notlevelExpression.Set(__Matchers[251]);
                /*  82 PlainRuleOp      */ _notExpression.Set(__Matchers[253]);
                /*  83 PlainRuleOp      */ _equallevelExpression.Set(__Matchers[254]);
                /*  84 PlainRuleOp      */ _equalExpression.Set(__Matchers[256]);
                /*  85 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[258]);
                /*  86 PlainRuleOp      */ _identicalExpression.Set(__Matchers[260]);
                /*  87 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[262]);
                /*  88 PlainRuleOp      */ _addlevelExpression.Set(__Matchers[263]);
                /*  89 PlainRuleOp      */ _addExpression.Set(__Matchers[265]);
                /*  90 PlainRuleOp      */ _subExpression.Set(__Matchers[267]);
                /*  91 PlainRuleOp      */ _mullevelExpression.Set(__Matchers[268]);
                /*  92 PlainRuleOp      */ _mulExpression.Set(__Matchers[270]);
                /*  93 PlainRuleOp      */ _divExpression.Set(__Matchers[272]);
                /*  94 PlainRuleOp      */ _remExpression.Set(__Matchers[274]);
                /*  95 PlainRuleOp      */ _primaryExpression.Set(__Matchers[275]);
                /*  96 PlainRuleOp      */ _callExpression.Set(__Matchers[276]);
                /*  97 PlainRuleOp      */ _selectExpression.Set(__Matchers[277]);
                /*  98 PlainRuleOp      */ _literal.Set(__Matchers[278]);
                /*  99 PlainRuleOp      */ _stringLiteral.Set(__Matchers[279]);
                /* 100 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 101 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 102 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 103 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 105 SeqOp            */ __Matchers[105].Set(_compilationUnit, __Matchers[104]);
                /* 106 AltOp            */ __Matchers[106].Set(_moduleDescriptor, _codeUnit);
                /* 109 SeqOp            */ __Matchers[109].Set(_prelude, __Matchers[107], _names, __Matchers[108], _usings, _declarations);
                /* 111 SeqOp            */ __Matchers[111].Set(__Matchers[110], _names, _moduleBody);
                /* 113 StarOp           */ __Matchers[113].Set(_moduleBodyElement);
                /* 115 SeqOp            */ __Matchers[115].Set(__Matchers[112], __Matchers[113], __Matchers[114]);
                /* 117 SeqOp            */ __Matchers[117].Set(__Matchers[116], _names, __Matchers[108]);
                /* 118 StarOp           */ __Matchers[118].Set(_usingDeclaration);
                /* 120 SeqOp            */ __Matchers[120].Set(__Matchers[119], _names, _usingElements);
                /* 121 OptionalOp       */ __Matchers[121].Set(_usingElementList);
                /* 122 SeqOp            */ __Matchers[122].Set(__Matchers[112], __Matchers[121], __Matchers[114]);
                /* 124 SeqOp            */ __Matchers[124].Set(__Matchers[123], _usingElement);
                /* 125 StarOp           */ __Matchers[125].Set(__Matchers[124]);
                /* 126 SeqOp            */ __Matchers[126].Set(_usingElement, __Matchers[125]);
                /* 127 AltOp            */ __Matchers[127].Set(_usingNamed, _usingWildcard);
                /* 128 OptionalOp       */ __Matchers[128].Set(_usingNameSpecifier);
                /* 129 OptionalOp       */ __Matchers[129].Set(_usingElements);
                /* 130 SeqOp            */ __Matchers[130].Set(_usingName, __Matchers[128], __Matchers[129]);
                /* 132 SeqOp            */ __Matchers[132].Set(__Matchers[131], _identifier);
                /* 135 SeqOp            */ __Matchers[135].Set(__Matchers[134], _name);
                /* 136 StarOp           */ __Matchers[136].Set(__Matchers[135]);
                /* 137 SeqOp            */ __Matchers[137].Set(_name, __Matchers[136]);
                /* 138 OptionalOp       */ __Matchers[138].Set(_genericArguments);
                /* 139 SeqOp            */ __Matchers[139].Set(_name, __Matchers[138]);
                /* 141 OptionalOp       */ __Matchers[141].Set(_genericArgumentList);
                /* 143 SeqOp            */ __Matchers[143].Set(__Matchers[140], __Matchers[141], __Matchers[142]);
                /* 144 SeqOp            */ __Matchers[144].Set(__Matchers[123], _genericArgument);
                /* 145 StarOp           */ __Matchers[145].Set(__Matchers[144]);
                /* 146 SeqOp            */ __Matchers[146].Set(_genericArgument, __Matchers[145]);
                /* 147 OptionalOp       */ __Matchers[147].Set(_genericParameterList);
                /* 148 SeqOp            */ __Matchers[148].Set(__Matchers[140], __Matchers[147], __Matchers[142]);
                /* 149 SeqOp            */ __Matchers[149].Set(__Matchers[123], _genericParameter);
                /* 150 StarOp           */ __Matchers[150].Set(__Matchers[149]);
                /* 151 SeqOp            */ __Matchers[151].Set(_genericParameter, __Matchers[150]);
                /* 152 OptionalOp       */ __Matchers[152].Set(_variance);
                /* 153 SeqOp            */ __Matchers[153].Set(__Matchers[152], _name);
                /* 156 AltOp            */ __Matchers[156].Set(__Matchers[154], __Matchers[155]);
                /* 157 StarOp           */ __Matchers[157].Set(_declaration);
                /* 158 AltOp            */ __Matchers[158].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 160 OptionalOp       */ __Matchers[160].Set(_genericParameters);
                /* 161 OptionalOp       */ __Matchers[161].Set(_constraints);
                /* 162 SeqOp            */ __Matchers[162].Set(_prelude, __Matchers[159], _type, _name, __Matchers[160], _parameters, __Matchers[161], _functionBody);
                /* 164 OptionalOp       */ __Matchers[164].Set(_type);
                /* 165 SeqOp            */ __Matchers[165].Set(_prelude, __Matchers[163], __Matchers[164], _name, _attributeBody);
                /* 167 OptionalOp       */ __Matchers[167].Set(_parameters);
                /* 168 OptionalOp       */ __Matchers[168].Set(_extends);
                /* 169 OptionalOp       */ __Matchers[169].Set(_satisfies);
                /* 170 OptionalOp       */ __Matchers[170].Set(_caseTypes);
                /* 171 SeqOp            */ __Matchers[171].Set(_prelude, __Matchers[166], _name, __Matchers[160], __Matchers[167], __Matchers[168], __Matchers[169], __Matchers[170], __Matchers[161], _blockBody);
                /* 173 SeqOp            */ __Matchers[173].Set(_prelude, __Matchers[172], _name, __Matchers[160], __Matchers[167], __Matchers[169], __Matchers[170], __Matchers[161], _blockBody);
                /* 175 SeqOp            */ __Matchers[175].Set(_prelude, __Matchers[174], _name, __Matchers[168], __Matchers[169], _blockBody);
                /* 178 SeqOp            */ __Matchers[178].Set(_prelude, __Matchers[176], _name, __Matchers[160], __Matchers[161], __Matchers[177], _type, __Matchers[108]);
                /* 180 OptionalOp       */ __Matchers[180].Set(_name);
                /* 181 SeqOp            */ __Matchers[181].Set(_prelude, __Matchers[179], __Matchers[180], __Matchers[168], _functionBody);
                /* 182 AltOp            */ __Matchers[182].Set(_expressionBody, _blockBody, _nullBody);
                /* 183 SeqOp            */ __Matchers[183].Set(__Matchers[112], _usings, _declarations, _statements, __Matchers[114]);
                /* 184 SeqOp            */ __Matchers[184].Set(_functionSpecifier, __Matchers[108]);
                /* 185 SeqOp            */ __Matchers[185].Set(__Matchers[108]);
                /* 186 SeqOp            */ __Matchers[186].Set(__Matchers[177], _expression);
                /* 188 SeqOp            */ __Matchers[188].Set(__Matchers[187], _type);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[189], _unionTypeList);
                /* 191 PlusOp           */ __Matchers[191].Set(_constraint);
                /* 193 SeqOp            */ __Matchers[193].Set(__Matchers[192], _name, __Matchers[160], __Matchers[170], __Matchers[169]);
                /* 194 SeqOp            */ __Matchers[194].Set(__Matchers[123], _type);
                /* 195 StarOp           */ __Matchers[195].Set(__Matchers[194]);
                /* 196 SeqOp            */ __Matchers[196].Set(_type, __Matchers[195]);
                /* 198 SeqOp            */ __Matchers[198].Set(__Matchers[197], _caseTypeList);
                /* 200 SeqOp            */ __Matchers[200].Set(__Matchers[199], _type);
                /* 201 StarOp           */ __Matchers[201].Set(__Matchers[200]);
                /* 202 SeqOp            */ __Matchers[202].Set(_type, __Matchers[201]);
                /* 203 OptionalOp       */ __Matchers[203].Set(_stringLiteral);
                /* 204 StarOp           */ __Matchers[204].Set(_attribute);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[203], __Matchers[204]);
                /* 206 OptionalOp       */ __Matchers[206].Set(_attributeArguments);
                /* 207 SeqOp            */ __Matchers[207].Set(_name, __Matchers[206]);
                /* 209 OptionalOp       */ __Matchers[209].Set(_attributeArgumentList);
                /* 211 SeqOp            */ __Matchers[211].Set(__Matchers[208], __Matchers[209], __Matchers[210]);
                /* 212 SeqOp            */ __Matchers[212].Set(__Matchers[123], _attributeArgument);
                /* 213 StarOp           */ __Matchers[213].Set(__Matchers[212]);
                /* 214 SeqOp            */ __Matchers[214].Set(_attributeArgument, __Matchers[213]);
                /* 215 AltOp            */ __Matchers[215].Set(_stringLiteral, _metaReference);
                /* 216 AltOp            */ __Matchers[216].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 217 SeqOp            */ __Matchers[217].Set(__Matchers[166], _names);
                /* 218 SeqOp            */ __Matchers[218].Set(__Matchers[174], _names);
                /* 219 SeqOp            */ __Matchers[219].Set(__Matchers[163], _names);
                /* 220 SeqOp            */ __Matchers[220].Set(__Matchers[172], _names);
                /* 221 SeqOp            */ __Matchers[221].Set(__Matchers[159], _names);
                /* 222 AltOp            */ __Matchers[222].Set(_unionType, _intersectionlevelType);
                /* 223 SeqOp            */ __Matchers[223].Set(_unionlevelType, __Matchers[199], _intersectionlevelType);
                /* 224 AltOp            */ __Matchers[224].Set(_intersectionType, _primaryType);
                /* 226 SeqOp            */ __Matchers[226].Set(_intersectionlevelType, __Matchers[225], _primaryType);
                /* 227 AltOp            */ __Matchers[227].Set(_reference, _typeSelector, _constructor, _arrayType);
                /* 230 SeqOp            */ __Matchers[230].Set(_primaryType, __Matchers[228], __Matchers[229]);
                /* 231 SeqOp            */ __Matchers[231].Set(_primaryType, __Matchers[134], _reference);
                /* 232 SeqOp            */ __Matchers[232].Set(_primaryType, _arguments);
                /* 233 OptionalOp       */ __Matchers[233].Set(_parameterList);
                /* 234 SeqOp            */ __Matchers[234].Set(__Matchers[208], __Matchers[233], __Matchers[210]);
                /* 235 SeqOp            */ __Matchers[235].Set(__Matchers[123], _parameter);
                /* 236 StarOp           */ __Matchers[236].Set(__Matchers[235]);
                /* 237 SeqOp            */ __Matchers[237].Set(_parameter, __Matchers[236]);
                /* 238 SeqOp            */ __Matchers[238].Set(_prelude, _type, _name);
                /* 239 OptionalOp       */ __Matchers[239].Set(_argumentList);
                /* 240 SeqOp            */ __Matchers[240].Set(__Matchers[208], __Matchers[239], __Matchers[210]);
                /* 241 SeqOp            */ __Matchers[241].Set(__Matchers[123], _argument);
                /* 242 StarOp           */ __Matchers[242].Set(__Matchers[241]);
                /* 243 SeqOp            */ __Matchers[243].Set(_argument, __Matchers[242]);
                /* 244 StarOp           */ __Matchers[244].Set(_statement);
                /* 245 AltOp            */ __Matchers[245].Set(_returnStatement, _assertStatement);
                /* 247 OptionalOp       */ __Matchers[247].Set(_expression);
                /* 248 SeqOp            */ __Matchers[248].Set(__Matchers[246], __Matchers[247], __Matchers[108]);
                /* 250 SeqOp            */ __Matchers[250].Set(__Matchers[203], __Matchers[249], _arguments, __Matchers[108]);
                /* 251 AltOp            */ __Matchers[251].Set(_notExpression, _equallevelExpression);
                /* 253 SeqOp            */ __Matchers[253].Set(__Matchers[252], _notlevelExpression);
                /* 254 AltOp            */ __Matchers[254].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _addlevelExpression);
                /* 256 SeqOp            */ __Matchers[256].Set(_addlevelExpression, __Matchers[255], _addlevelExpression);
                /* 258 SeqOp            */ __Matchers[258].Set(_addlevelExpression, __Matchers[257], _addlevelExpression);
                /* 260 SeqOp            */ __Matchers[260].Set(_addlevelExpression, __Matchers[259], _addlevelExpression);
                /* 262 SeqOp            */ __Matchers[262].Set(_addlevelExpression, __Matchers[261], _addlevelExpression);
                /* 263 AltOp            */ __Matchers[263].Set(_addExpression, _subExpression, _mullevelExpression);
                /* 265 SeqOp            */ __Matchers[265].Set(_addlevelExpression, __Matchers[264], _mullevelExpression);
                /* 267 SeqOp            */ __Matchers[267].Set(_addlevelExpression, __Matchers[266], _mullevelExpression);
                /* 268 AltOp            */ __Matchers[268].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 270 SeqOp            */ __Matchers[270].Set(_mullevelExpression, __Matchers[269], _primaryExpression);
                /* 272 SeqOp            */ __Matchers[272].Set(_mullevelExpression, __Matchers[271], _primaryExpression);
                /* 274 SeqOp            */ __Matchers[274].Set(_mullevelExpression, __Matchers[273], _primaryExpression);
                /* 275 AltOp            */ __Matchers[275].Set(_reference, _literal, _callExpression, _selectExpression);
                /* 276 SeqOp            */ __Matchers[276].Set(_primaryExpression, _arguments);
                /* 277 SeqOp            */ __Matchers[277].Set(_primaryExpression, __Matchers[134], _reference);
                /* 278 AltOp            */ __Matchers[278].Set(_stringLiteral, _naturalLiteral);
                /* 279 AltOp            */ __Matchers[279].Set(_plainStringLiteral, _verbatimStringLiteral);

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
            private readonly Mx.PlainRule _statements;
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
        public interface ICDeclaration : IRNode {}
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
        public interface ICStatements : IRNode {}
        public interface ICStatement : IRNode {}
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

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'namespace'
            public CNames Names => Get<CNames>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
            public CUsings Usings => Get<CUsings>(4);
            public CDeclarations Declarations => Get<CDeclarations>(5);
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
            public CDeclarations Declarations => Get<CDeclarations>(2);
            public CStatements Statements => Get<CStatements>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '}'
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

            protected virtual void Visit(CStatements element)
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
