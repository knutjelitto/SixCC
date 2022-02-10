// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Sax\\Sax.six" at="10.02.2022 09:21:15" />

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
                : base(new Mx.Matcher[298])
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
                /*  10 PlainRuleOp      */ __Matchers[10] = _usings = new Mx.PlainRule(this, 10, "usings") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _usingDeclaration = new Mx.PlainRule(this, 11, "using-declaration") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _usingElements = new Mx.PlainRule(this, 12, "using-elements") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _usingElementList = new Mx.PlainRule(this, 13, "using-element-list") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _usingElement = new Mx.PlainRule(this, 14, "using-element") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _usingNamed = new Mx.PlainRule(this, 15, "using-named") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _usingName = new Mx.PlainRule(this, 16, "using-name") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _usingNameSpecifier = new Mx.PlainRule(this, 17, "using-name-specifier") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _usingWildcard = new Mx.PlainRule(this, 18, "using-wildcard") { Creator = node => new CUsingWildcard(node) };
                /*  19 PlainRuleOp      */ __Matchers[19] = _name = new Mx.PlainRule(this, 19, "name") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _names = new Mx.PlainRule(this, 20, "names") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _reference = new Mx.PlainRule(this, 21, "reference") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _genericArguments = new Mx.PlainRule(this, 22, "generic-arguments") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _genericArgumentList = new Mx.PlainRule(this, 23, "generic-argument-list") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _genericArgument = new Mx.PlainRule(this, 24, "generic-argument") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _genericParameters = new Mx.PlainRule(this, 25, "generic-parameters") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _genericParameterList = new Mx.PlainRule(this, 26, "generic-parameter-list") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _genericParameter = new Mx.PlainRule(this, 27, "generic-parameter") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _typeDefault = new Mx.PlainRule(this, 28, "type-default") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _variance = new Mx.PlainRule(this, 29, "variance") { Creator = node => new CVariance(node) };
                /*  30 PlainRuleOp      */ __Matchers[30] = _declarations = new Mx.PlainRule(this, 30, "declarations") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _declaration = new Mx.PlainRule(this, 31, "declaration") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _functionDeclaration = new Mx.PlainRule(this, 32, "function-declaration") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _attributeDeclaration = new Mx.PlainRule(this, 33, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _classDeclaration = new Mx.PlainRule(this, 34, "class-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _interfaceDeclaration = new Mx.PlainRule(this, 35, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _objectDeclaration = new Mx.PlainRule(this, 36, "object-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _aliasDeclaration = new Mx.PlainRule(this, 37, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _constructorDeclaration = new Mx.PlainRule(this, 38, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _functionBody = new Mx.PlainRule(this, 39, "function-body") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _attributeBody = new Mx.PlainRule(this, 40, "attribute-body") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _blockBody = new Mx.PlainRule(this, 41, "block-body") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _statelarations = new Mx.PlainRule(this, 42, "statelarations") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _statelaration = new Mx.PlainRule(this, 43, "statelaration") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _expressionBody = new Mx.PlainRule(this, 44, "expression-body") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _nullBody = new Mx.PlainRule(this, 45, "null-body") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _functionSpecifier = new Mx.PlainRule(this, 46, "function-specifier") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _extends = new Mx.PlainRule(this, 47, "extends") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _satisfies = new Mx.PlainRule(this, 48, "satisfies") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _constraints = new Mx.PlainRule(this, 49, "constraints") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _constraint = new Mx.PlainRule(this, 50, "constraint") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _unionTypeList = new Mx.PlainRule(this, 51, "union-type-list") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _caseTypes = new Mx.PlainRule(this, 52, "case-types") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _caseTypeList = new Mx.PlainRule(this, 53, "case-type-list") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _prelude = new Mx.PlainRule(this, 54, "prelude") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _attribute = new Mx.PlainRule(this, 55, "attribute") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _attributeArguments = new Mx.PlainRule(this, 56, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _attributeArgumentList = new Mx.PlainRule(this, 57, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _attributeArgument = new Mx.PlainRule(this, 58, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _metaReference = new Mx.PlainRule(this, 59, "meta-reference") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _classReference = new Mx.PlainRule(this, 60, "class-reference") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _objectReference = new Mx.PlainRule(this, 61, "object-reference") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _valueReference = new Mx.PlainRule(this, 62, "value-reference") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _interfaceReference = new Mx.PlainRule(this, 63, "interface-reference") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _functionReference = new Mx.PlainRule(this, 64, "function-reference") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _type = new Mx.PlainRule(this, 65, "type") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _unionlevelType = new Mx.PlainRule(this, 66, "unionlevel-type") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _variadicType = new Mx.PlainRule(this, 67, "variadic-type") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _variadicTypeZero = new Mx.PlainRule(this, 68, "variadic-type-zero") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _variadicTypeOne = new Mx.PlainRule(this, 69, "variadic-type-one") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _unionType = new Mx.PlainRule(this, 70, "union-type") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _intersectionlevelType = new Mx.PlainRule(this, 71, "intersectionlevel-type") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _intersectionType = new Mx.PlainRule(this, 72, "intersection-type") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _primaryType = new Mx.PlainRule(this, 73, "primary-type") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _nullableType = new Mx.PlainRule(this, 74, "nullable-type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _arrayType = new Mx.PlainRule(this, 75, "array-type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _typeSelector = new Mx.PlainRule(this, 76, "type-selector") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _constructor = new Mx.PlainRule(this, 77, "constructor") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _parameters = new Mx.PlainRule(this, 78, "parameters") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _parameterList = new Mx.PlainRule(this, 79, "parameter-list") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _parameter = new Mx.PlainRule(this, 80, "parameter") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _arguments = new Mx.PlainRule(this, 81, "arguments") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _argumentList = new Mx.PlainRule(this, 82, "argument-list") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _argument = new Mx.PlainRule(this, 83, "argument") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _statement = new Mx.PlainRule(this, 84, "statement") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _returnStatement = new Mx.PlainRule(this, 85, "return-statement") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _assertStatement = new Mx.PlainRule(this, 86, "assert-statement") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _expression = new Mx.PlainRule(this, 87, "expression") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _notlevelExpression = new Mx.PlainRule(this, 88, "notlevel-expression") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _notExpression = new Mx.PlainRule(this, 89, "not-expression") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _equallevelExpression = new Mx.PlainRule(this, 90, "equallevel-expression") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _equalExpression = new Mx.PlainRule(this, 91, "equal-expression") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _notEqualExpression = new Mx.PlainRule(this, 92, "not-equal-expression") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _identicalExpression = new Mx.PlainRule(this, 93, "identical-expression") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _notIdenticalExpression = new Mx.PlainRule(this, 94, "not-identical-expression") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _addlevelExpression = new Mx.PlainRule(this, 95, "addlevel-expression") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _addExpression = new Mx.PlainRule(this, 96, "add-expression") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _subExpression = new Mx.PlainRule(this, 97, "sub-expression") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _mullevelExpression = new Mx.PlainRule(this, 98, "mullevel-expression") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _mulExpression = new Mx.PlainRule(this, 99, "mul-expression") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _divExpression = new Mx.PlainRule(this, 100, "div-expression") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _remExpression = new Mx.PlainRule(this, 101, "rem-expression") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _primaryExpression = new Mx.PlainRule(this, 102, "primary-expression") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _callExpression = new Mx.PlainRule(this, 103, "call-expression") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _selectExpression = new Mx.PlainRule(this, 104, "select-expression") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _literal = new Mx.PlainRule(this, 105, "literal") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _stringLiteral = new Mx.PlainRule(this, 106, "string-literal") { Builder = nodes => nodes[0] };
                /* 107 DfaRuleOp        */ __Matchers[107] = _naturalLiteral = new Mx.DfaRule(this, 107, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 108 DfaRuleOp        */ __Matchers[108] = _plainStringLiteral = new Mx.DfaRule(this, 108, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 109 DfaRuleOp        */ __Matchers[109] = _verbatimStringLiteral = new Mx.DfaRule(this, 109, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 110 DfaRuleOp        */ __Matchers[110] = _identifier = new Mx.DfaRule(this, 110, "identifier") { Creator = node => new CIdentifier(node) };
                /* 111 EofOp            */ __Matchers[111] = new Mx.Eof(this, 111, "<eof>") { Creator = node => new REof(node) };
                /* 112 SeqOp            */ __Matchers[112] = new Mx.Seq(this, 112, "_112:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 113 AltOp            */ __Matchers[113] = new Mx.Alt(this, 113, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 114 StringOp         */ __Matchers[114] = new Mx.String(this, 114, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 115 OptionalOp       */ __Matchers[115] = new Mx.Optional(this, 115, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 116 SeqOp            */ __Matchers[116] = new Mx.Seq(this, 116, "_116:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 117 StringOp         */ __Matchers[117] = new Mx.Keyword(this, 117, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 118 StringOp         */ __Matchers[118] = new Mx.String(this, 118, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 119 SeqOp            */ __Matchers[119] = new Mx.Seq(this, 119, "_119:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 120 StringOp         */ __Matchers[120] = new Mx.Keyword(this, 120, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 121 SeqOp            */ __Matchers[121] = new Mx.Seq(this, 121, "_121:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 122 StringOp         */ __Matchers[122] = new Mx.String(this, 122, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 123 StarOp           */ __Matchers[123] = new Mx.Star(this, 123, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 124 StringOp         */ __Matchers[124] = new Mx.String(this, 124, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 125 SeqOp            */ __Matchers[125] = new Mx.Seq(this, 125, "_125:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 126 StringOp         */ __Matchers[126] = new Mx.Keyword(this, 126, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 127 SeqOp            */ __Matchers[127] = new Mx.Seq(this, 127, "_127:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 128 StarOp           */ __Matchers[128] = new Mx.Star(this, 128, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 129 StringOp         */ __Matchers[129] = new Mx.Keyword(this, 129, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 130 SeqOp            */ __Matchers[130] = new Mx.Seq(this, 130, "_130:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 131 OptionalOp       */ __Matchers[131] = new Mx.Optional(this, 131, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 132 SeqOp            */ __Matchers[132] = new Mx.Seq(this, 132, "_132:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 133 StringOp         */ __Matchers[133] = new Mx.String(this, 133, "','", ",") { Creator = node => new RLiteral(node) };
                /* 134 SeqOp            */ __Matchers[134] = new Mx.Seq(this, 134, "_134:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 135 StarOp           */ __Matchers[135] = new Mx.Star(this, 135, "*(_134:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 136 SeqOp            */ __Matchers[136] = new Mx.Seq(this, 136, "_136:(>using-element,*(_134:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 137 AltOp            */ __Matchers[137] = new Mx.Alt(this, 137, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 138 OptionalOp       */ __Matchers[138] = new Mx.Optional(this, 138, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 139 OptionalOp       */ __Matchers[139] = new Mx.Optional(this, 139, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 140 SeqOp            */ __Matchers[140] = new Mx.Seq(this, 140, "_140:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 141 StringOp         */ __Matchers[141] = new Mx.String(this, 141, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 142 SeqOp            */ __Matchers[142] = new Mx.Seq(this, 142, "_142:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 143 StringOp         */ __Matchers[143] = new Mx.String(this, 143, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 144 StringOp         */ __Matchers[144] = new Mx.String(this, 144, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 145 SeqOp            */ __Matchers[145] = new Mx.Seq(this, 145, "_145:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 146 StarOp           */ __Matchers[146] = new Mx.Star(this, 146, "*(_145:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 147 SeqOp            */ __Matchers[147] = new Mx.Seq(this, 147, "_147:(>name,*(_145:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 148 OptionalOp       */ __Matchers[148] = new Mx.Optional(this, 148, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 149 SeqOp            */ __Matchers[149] = new Mx.Seq(this, 149, "_149:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 150 StringOp         */ __Matchers[150] = new Mx.String(this, 150, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 151 OptionalOp       */ __Matchers[151] = new Mx.Optional(this, 151, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 152 StringOp         */ __Matchers[152] = new Mx.String(this, 152, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 153 SeqOp            */ __Matchers[153] = new Mx.Seq(this, 153, "_153:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 154 SeqOp            */ __Matchers[154] = new Mx.Seq(this, 154, "_154:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 155 StarOp           */ __Matchers[155] = new Mx.Star(this, 155, "*(_154:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 156 SeqOp            */ __Matchers[156] = new Mx.Seq(this, 156, "_156:(>generic-argument,*(_154:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 157 OptionalOp       */ __Matchers[157] = new Mx.Optional(this, 157, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 158 SeqOp            */ __Matchers[158] = new Mx.Seq(this, 158, "_158:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 159 SeqOp            */ __Matchers[159] = new Mx.Seq(this, 159, "_159:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 160 StarOp           */ __Matchers[160] = new Mx.Star(this, 160, "*(_159:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 161 SeqOp            */ __Matchers[161] = new Mx.Seq(this, 161, "_161:(>generic-parameter,*(_159:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 162 OptionalOp       */ __Matchers[162] = new Mx.Optional(this, 162, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 163 OptionalOp       */ __Matchers[163] = new Mx.Optional(this, 163, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 164 SeqOp            */ __Matchers[164] = new Mx.Seq(this, 164, "_164:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 165 SeqOp            */ __Matchers[165] = new Mx.Seq(this, 165, "_165:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 166 StringOp         */ __Matchers[166] = new Mx.Keyword(this, 166, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 167 StringOp         */ __Matchers[167] = new Mx.Keyword(this, 167, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 168 AltOp            */ __Matchers[168] = new Mx.Alt(this, 168, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 169 StarOp           */ __Matchers[169] = new Mx.Star(this, 169, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 170 AltOp            */ __Matchers[170] = new Mx.Alt(this, 170, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 171 StringOp         */ __Matchers[171] = new Mx.Keyword(this, 171, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 172 OptionalOp       */ __Matchers[172] = new Mx.Optional(this, 172, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 173 OptionalOp       */ __Matchers[173] = new Mx.Optional(this, 173, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 174 SeqOp            */ __Matchers[174] = new Mx.Seq(this, 174, "_174:(>prelude,'function',>type,>name,?(>generic-parameters),>parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 175 StringOp         */ __Matchers[175] = new Mx.Keyword(this, 175, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 176 OptionalOp       */ __Matchers[176] = new Mx.Optional(this, 176, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 177 SeqOp            */ __Matchers[177] = new Mx.Seq(this, 177, "_177:(>prelude,'value',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 178 StringOp         */ __Matchers[178] = new Mx.Keyword(this, 178, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 179 OptionalOp       */ __Matchers[179] = new Mx.Optional(this, 179, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 180 OptionalOp       */ __Matchers[180] = new Mx.Optional(this, 180, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 181 OptionalOp       */ __Matchers[181] = new Mx.Optional(this, 181, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 182 OptionalOp       */ __Matchers[182] = new Mx.Optional(this, 182, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 184 StringOp         */ __Matchers[184] = new Mx.Keyword(this, 184, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 185 SeqOp            */ __Matchers[185] = new Mx.Seq(this, 185, "_185:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 186 StringOp         */ __Matchers[186] = new Mx.Keyword(this, 186, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 187 SeqOp            */ __Matchers[187] = new Mx.Seq(this, 187, "_187:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 188 StringOp         */ __Matchers[188] = new Mx.Keyword(this, 188, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.String(this, 189, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 191 StringOp         */ __Matchers[191] = new Mx.Keyword(this, 191, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 192 OptionalOp       */ __Matchers[192] = new Mx.Optional(this, 192, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 193 SeqOp            */ __Matchers[193] = new Mx.Seq(this, 193, "_193:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 194 AltOp            */ __Matchers[194] = new Mx.Alt(this, 194, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 195 SeqOp            */ __Matchers[195] = new Mx.Seq(this, 195, "_195:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 196 StarOp           */ __Matchers[196] = new Mx.Star(this, 196, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 197 AltOp            */ __Matchers[197] = new Mx.Alt(this, 197, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 199 SeqOp            */ __Matchers[199] = new Mx.Seq(this, 199, "_199:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 201 StringOp         */ __Matchers[201] = new Mx.String(this, 201, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 202 SeqOp            */ __Matchers[202] = new Mx.Seq(this, 202, "_202:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 203 StringOp         */ __Matchers[203] = new Mx.Keyword(this, 203, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 204 SeqOp            */ __Matchers[204] = new Mx.Seq(this, 204, "_204:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 205 PlusOp           */ __Matchers[205] = new Mx.Plus(this, 205, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 206 StringOp         */ __Matchers[206] = new Mx.Keyword(this, 206, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 208 SeqOp            */ __Matchers[208] = new Mx.Seq(this, 208, "_208:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 209 StarOp           */ __Matchers[209] = new Mx.Star(this, 209, "*(_208:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 210 SeqOp            */ __Matchers[210] = new Mx.Seq(this, 210, "_210:(>type,*(_208:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 211 StringOp         */ __Matchers[211] = new Mx.Keyword(this, 211, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 213 StringOp         */ __Matchers[213] = new Mx.String(this, 213, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 214 SeqOp            */ __Matchers[214] = new Mx.Seq(this, 214, "_214:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 215 StarOp           */ __Matchers[215] = new Mx.Star(this, 215, "*(_214:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 216 SeqOp            */ __Matchers[216] = new Mx.Seq(this, 216, "_216:(>type,*(_214:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 217 OptionalOp       */ __Matchers[217] = new Mx.Optional(this, 217, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 218 StarOp           */ __Matchers[218] = new Mx.Star(this, 218, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 220 OptionalOp       */ __Matchers[220] = new Mx.Optional(this, 220, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 222 StringOp         */ __Matchers[222] = new Mx.String(this, 222, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 223 OptionalOp       */ __Matchers[223] = new Mx.Optional(this, 223, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 224 StringOp         */ __Matchers[224] = new Mx.String(this, 224, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 225 SeqOp            */ __Matchers[225] = new Mx.Seq(this, 225, "_225:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 227 StarOp           */ __Matchers[227] = new Mx.Star(this, 227, "*(_226:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 228 SeqOp            */ __Matchers[228] = new Mx.Seq(this, 228, "_228:(>attribute-argument,*(_226:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 229 AltOp            */ __Matchers[229] = new Mx.Alt(this, 229, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 230 AltOp            */ __Matchers[230] = new Mx.Alt(this, 230, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 232 SeqOp            */ __Matchers[232] = new Mx.Seq(this, 232, "_232:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 233 SeqOp            */ __Matchers[233] = new Mx.Seq(this, 233, "_233:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 234 SeqOp            */ __Matchers[234] = new Mx.Seq(this, 234, "_234:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 236 AltOp            */ __Matchers[236] = new Mx.Alt(this, 236, "alt(>union-type|>variadic-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 237 AltOp            */ __Matchers[237] = new Mx.Alt(this, 237, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 238 StringOp         */ __Matchers[238] = new Mx.String(this, 238, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 239 SeqOp            */ __Matchers[239] = new Mx.Seq(this, 239, "_239:(>unionlevel-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 240 StringOp         */ __Matchers[240] = new Mx.String(this, 240, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 241 SeqOp            */ __Matchers[241] = new Mx.Seq(this, 241, "_241:(>unionlevel-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 242 SeqOp            */ __Matchers[242] = new Mx.Seq(this, 242, "_242:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 243 AltOp            */ __Matchers[243] = new Mx.Alt(this, 243, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 244 StringOp         */ __Matchers[244] = new Mx.String(this, 244, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 246 AltOp            */ __Matchers[246] = new Mx.Alt(this, 246, "alt(>nullable-type|>array-type|>reference|>type-selector|>constructor)") { Builder = nodes => nodes[0] };
                /* 247 StringOp         */ __Matchers[247] = new Mx.String(this, 247, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.String(this, 249, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 250 StringOp         */ __Matchers[250] = new Mx.String(this, 250, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 251 SeqOp            */ __Matchers[251] = new Mx.Seq(this, 251, "_251:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 252 SeqOp            */ __Matchers[252] = new Mx.Seq(this, 252, "_252:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 253 SeqOp            */ __Matchers[253] = new Mx.Seq(this, 253, "_253:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 254 OptionalOp       */ __Matchers[254] = new Mx.Optional(this, 254, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 255 SeqOp            */ __Matchers[255] = new Mx.Seq(this, 255, "_255:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 256 SeqOp            */ __Matchers[256] = new Mx.Seq(this, 256, "_256:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 257 StarOp           */ __Matchers[257] = new Mx.Star(this, 257, "*(_256:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 258 SeqOp            */ __Matchers[258] = new Mx.Seq(this, 258, "_258:(>parameter,*(_256:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 259 SeqOp            */ __Matchers[259] = new Mx.Seq(this, 259, "_259:(>prelude,>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 260 OptionalOp       */ __Matchers[260] = new Mx.Optional(this, 260, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 261 SeqOp            */ __Matchers[261] = new Mx.Seq(this, 261, "_261:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 262 SeqOp            */ __Matchers[262] = new Mx.Seq(this, 262, "_262:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 263 StarOp           */ __Matchers[263] = new Mx.Star(this, 263, "*(_262:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 264 SeqOp            */ __Matchers[264] = new Mx.Seq(this, 264, "_264:(>argument,*(_262:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 265 AltOp            */ __Matchers[265] = new Mx.Alt(this, 265, "alt(>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 266 StringOp         */ __Matchers[266] = new Mx.Keyword(this, 266, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 267 OptionalOp       */ __Matchers[267] = new Mx.Optional(this, 267, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 268 SeqOp            */ __Matchers[268] = new Mx.Seq(this, 268, "_268:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 269 StringOp         */ __Matchers[269] = new Mx.Keyword(this, 269, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 270 SeqOp            */ __Matchers[270] = new Mx.Seq(this, 270, "_270:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 271 AltOp            */ __Matchers[271] = new Mx.Alt(this, 271, "alt(>not-expression|>equallevel-expression)") { Builder = nodes => nodes[0] };
                /* 272 StringOp         */ __Matchers[272] = new Mx.String(this, 272, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 273 SeqOp            */ __Matchers[273] = new Mx.Seq(this, 273, "_273:('!',>notlevel-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 274 AltOp            */ __Matchers[274] = new Mx.Alt(this, 274, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>addlevel-expression)") { Builder = nodes => nodes[0] };
                /* 275 StringOp         */ __Matchers[275] = new Mx.String(this, 275, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(>addlevel-expression,'==',>addlevel-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 277 StringOp         */ __Matchers[277] = new Mx.String(this, 277, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 278 SeqOp            */ __Matchers[278] = new Mx.Seq(this, 278, "_278:(>addlevel-expression,'!=',>addlevel-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 279 StringOp         */ __Matchers[279] = new Mx.String(this, 279, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 280 SeqOp            */ __Matchers[280] = new Mx.Seq(this, 280, "_280:(>addlevel-expression,'===',>addlevel-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 281 StringOp         */ __Matchers[281] = new Mx.String(this, 281, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:(>addlevel-expression,'!==',>addlevel-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 283 AltOp            */ __Matchers[283] = new Mx.Alt(this, 283, "alt(>add-expression|>sub-expression|>mullevel-expression)") { Builder = nodes => nodes[0] };
                /* 284 SeqOp            */ __Matchers[284] = new Mx.Seq(this, 284, "_284:(>addlevel-expression,'+',>mullevel-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 285 StringOp         */ __Matchers[285] = new Mx.String(this, 285, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 286 SeqOp            */ __Matchers[286] = new Mx.Seq(this, 286, "_286:(>addlevel-expression,'-',>mullevel-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 287 AltOp            */ __Matchers[287] = new Mx.Alt(this, 287, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 288 SeqOp            */ __Matchers[288] = new Mx.Seq(this, 288, "_288:(>mullevel-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 289 StringOp         */ __Matchers[289] = new Mx.String(this, 289, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 290 SeqOp            */ __Matchers[290] = new Mx.Seq(this, 290, "_290:(>mullevel-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 291 StringOp         */ __Matchers[291] = new Mx.String(this, 291, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:(>mullevel-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 293 AltOp            */ __Matchers[293] = new Mx.Alt(this, 293, "alt(>reference|>literal|>call-expression|>select-expression)") { Builder = nodes => nodes[0] };
                /* 294 SeqOp            */ __Matchers[294] = new Mx.Seq(this, 294, "_294:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 296 AltOp            */ __Matchers[296] = new Mx.Alt(this, 296, "alt(>string-literal|>natural-literal)") { Builder = nodes => nodes[0] };
                /* 297 AltOp            */ __Matchers[297] = new Mx.Alt(this, 297, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[112]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[113]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[116]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[119]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[121]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[125]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[127]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[128]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[130]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[132]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[136]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[137]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[140]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[142]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[143]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[147]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[149]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[153]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[156]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[158]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[161]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[164]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[165]);
                /*  29 PlainRuleOp      */ _variance.Set(__Matchers[168]);
                /*  30 PlainRuleOp      */ _declarations.Set(__Matchers[169]);
                /*  31 PlainRuleOp      */ _declaration.Set(__Matchers[170]);
                /*  32 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[174]);
                /*  33 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[177]);
                /*  34 PlainRuleOp      */ _classDeclaration.Set(__Matchers[183]);
                /*  35 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[185]);
                /*  36 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[187]);
                /*  37 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[190]);
                /*  38 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[193]);
                /*  39 PlainRuleOp      */ _functionBody.Set(__Matchers[194]);
                /*  40 PlainRuleOp      */ _attributeBody.Set(__Matchers[194]);
                /*  41 PlainRuleOp      */ _blockBody.Set(__Matchers[195]);
                /*  42 PlainRuleOp      */ _statelarations.Set(__Matchers[196]);
                /*  43 PlainRuleOp      */ _statelaration.Set(__Matchers[197]);
                /*  44 PlainRuleOp      */ _expressionBody.Set(__Matchers[198]);
                /*  45 PlainRuleOp      */ _nullBody.Set(__Matchers[199]);
                /*  46 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[200]);
                /*  47 PlainRuleOp      */ _extends.Set(__Matchers[202]);
                /*  48 PlainRuleOp      */ _satisfies.Set(__Matchers[204]);
                /*  49 PlainRuleOp      */ _constraints.Set(__Matchers[205]);
                /*  50 PlainRuleOp      */ _constraint.Set(__Matchers[207]);
                /*  51 PlainRuleOp      */ _unionTypeList.Set(__Matchers[210]);
                /*  52 PlainRuleOp      */ _caseTypes.Set(__Matchers[212]);
                /*  53 PlainRuleOp      */ _caseTypeList.Set(__Matchers[216]);
                /*  54 PlainRuleOp      */ _prelude.Set(__Matchers[219]);
                /*  55 PlainRuleOp      */ _attribute.Set(__Matchers[221]);
                /*  56 PlainRuleOp      */ _attributeArguments.Set(__Matchers[225]);
                /*  57 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[228]);
                /*  58 PlainRuleOp      */ _attributeArgument.Set(__Matchers[229]);
                /*  59 PlainRuleOp      */ _metaReference.Set(__Matchers[230]);
                /*  60 PlainRuleOp      */ _classReference.Set(__Matchers[231]);
                /*  61 PlainRuleOp      */ _objectReference.Set(__Matchers[232]);
                /*  62 PlainRuleOp      */ _valueReference.Set(__Matchers[233]);
                /*  63 PlainRuleOp      */ _interfaceReference.Set(__Matchers[234]);
                /*  64 PlainRuleOp      */ _functionReference.Set(__Matchers[235]);
                /*  65 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  66 PlainRuleOp      */ _unionlevelType.Set(__Matchers[236]);
                /*  67 PlainRuleOp      */ _variadicType.Set(__Matchers[237]);
                /*  68 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[239]);
                /*  69 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[241]);
                /*  70 PlainRuleOp      */ _unionType.Set(__Matchers[242]);
                /*  71 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[243]);
                /*  72 PlainRuleOp      */ _intersectionType.Set(__Matchers[245]);
                /*  73 PlainRuleOp      */ _primaryType.Set(__Matchers[246]);
                /*  74 PlainRuleOp      */ _nullableType.Set(__Matchers[248]);
                /*  75 PlainRuleOp      */ _arrayType.Set(__Matchers[251]);
                /*  76 PlainRuleOp      */ _typeSelector.Set(__Matchers[252]);
                /*  77 PlainRuleOp      */ _constructor.Set(__Matchers[253]);
                /*  78 PlainRuleOp      */ _parameters.Set(__Matchers[255]);
                /*  79 PlainRuleOp      */ _parameterList.Set(__Matchers[258]);
                /*  80 PlainRuleOp      */ _parameter.Set(__Matchers[259]);
                /*  81 PlainRuleOp      */ _arguments.Set(__Matchers[261]);
                /*  82 PlainRuleOp      */ _argumentList.Set(__Matchers[264]);
                /*  83 PlainRuleOp      */ _argument.Set(_expression);
                /*  84 PlainRuleOp      */ _statement.Set(__Matchers[265]);
                /*  85 PlainRuleOp      */ _returnStatement.Set(__Matchers[268]);
                /*  86 PlainRuleOp      */ _assertStatement.Set(__Matchers[270]);
                /*  87 PlainRuleOp      */ _expression.Set(_notlevelExpression);
                /*  88 PlainRuleOp      */ _notlevelExpression.Set(__Matchers[271]);
                /*  89 PlainRuleOp      */ _notExpression.Set(__Matchers[273]);
                /*  90 PlainRuleOp      */ _equallevelExpression.Set(__Matchers[274]);
                /*  91 PlainRuleOp      */ _equalExpression.Set(__Matchers[276]);
                /*  92 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[278]);
                /*  93 PlainRuleOp      */ _identicalExpression.Set(__Matchers[280]);
                /*  94 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[282]);
                /*  95 PlainRuleOp      */ _addlevelExpression.Set(__Matchers[283]);
                /*  96 PlainRuleOp      */ _addExpression.Set(__Matchers[284]);
                /*  97 PlainRuleOp      */ _subExpression.Set(__Matchers[286]);
                /*  98 PlainRuleOp      */ _mullevelExpression.Set(__Matchers[287]);
                /*  99 PlainRuleOp      */ _mulExpression.Set(__Matchers[288]);
                /* 100 PlainRuleOp      */ _divExpression.Set(__Matchers[290]);
                /* 101 PlainRuleOp      */ _remExpression.Set(__Matchers[292]);
                /* 102 PlainRuleOp      */ _primaryExpression.Set(__Matchers[293]);
                /* 103 PlainRuleOp      */ _callExpression.Set(__Matchers[294]);
                /* 104 PlainRuleOp      */ _selectExpression.Set(__Matchers[295]);
                /* 105 PlainRuleOp      */ _literal.Set(__Matchers[296]);
                /* 106 PlainRuleOp      */ _stringLiteral.Set(__Matchers[297]);
                /* 107 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 108 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 109 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 110 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 112 SeqOp            */ __Matchers[112].Set(_compilationUnit, __Matchers[111]);
                /* 113 AltOp            */ __Matchers[113].Set(_moduleDescriptor, _codeUnit);
                /* 115 OptionalOp       */ __Matchers[115].Set(__Matchers[114]);
                /* 116 SeqOp            */ __Matchers[116].Set(__Matchers[115], _namespace, _usings, _declarations);
                /* 119 SeqOp            */ __Matchers[119].Set(_prelude, __Matchers[117], _names, __Matchers[118]);
                /* 121 SeqOp            */ __Matchers[121].Set(__Matchers[120], _names, _moduleBody);
                /* 123 StarOp           */ __Matchers[123].Set(_moduleBodyElement);
                /* 125 SeqOp            */ __Matchers[125].Set(__Matchers[122], __Matchers[123], __Matchers[124]);
                /* 127 SeqOp            */ __Matchers[127].Set(__Matchers[126], _names, __Matchers[118]);
                /* 128 StarOp           */ __Matchers[128].Set(_usingDeclaration);
                /* 130 SeqOp            */ __Matchers[130].Set(__Matchers[129], _names, _usingElements);
                /* 131 OptionalOp       */ __Matchers[131].Set(_usingElementList);
                /* 132 SeqOp            */ __Matchers[132].Set(__Matchers[122], __Matchers[131], __Matchers[124]);
                /* 134 SeqOp            */ __Matchers[134].Set(__Matchers[133], _usingElement);
                /* 135 StarOp           */ __Matchers[135].Set(__Matchers[134]);
                /* 136 SeqOp            */ __Matchers[136].Set(_usingElement, __Matchers[135]);
                /* 137 AltOp            */ __Matchers[137].Set(_usingNamed, _usingWildcard);
                /* 138 OptionalOp       */ __Matchers[138].Set(_usingNameSpecifier);
                /* 139 OptionalOp       */ __Matchers[139].Set(_usingElements);
                /* 140 SeqOp            */ __Matchers[140].Set(_usingName, __Matchers[138], __Matchers[139]);
                /* 142 SeqOp            */ __Matchers[142].Set(__Matchers[141], _identifier);
                /* 145 SeqOp            */ __Matchers[145].Set(__Matchers[144], _name);
                /* 146 StarOp           */ __Matchers[146].Set(__Matchers[145]);
                /* 147 SeqOp            */ __Matchers[147].Set(_name, __Matchers[146]);
                /* 148 OptionalOp       */ __Matchers[148].Set(_genericArguments);
                /* 149 SeqOp            */ __Matchers[149].Set(_name, __Matchers[148]);
                /* 151 OptionalOp       */ __Matchers[151].Set(_genericArgumentList);
                /* 153 SeqOp            */ __Matchers[153].Set(__Matchers[150], __Matchers[151], __Matchers[152]);
                /* 154 SeqOp            */ __Matchers[154].Set(__Matchers[133], _genericArgument);
                /* 155 StarOp           */ __Matchers[155].Set(__Matchers[154]);
                /* 156 SeqOp            */ __Matchers[156].Set(_genericArgument, __Matchers[155]);
                /* 157 OptionalOp       */ __Matchers[157].Set(_genericParameterList);
                /* 158 SeqOp            */ __Matchers[158].Set(__Matchers[150], __Matchers[157], __Matchers[152]);
                /* 159 SeqOp            */ __Matchers[159].Set(__Matchers[133], _genericParameter);
                /* 160 StarOp           */ __Matchers[160].Set(__Matchers[159]);
                /* 161 SeqOp            */ __Matchers[161].Set(_genericParameter, __Matchers[160]);
                /* 162 OptionalOp       */ __Matchers[162].Set(_variance);
                /* 163 OptionalOp       */ __Matchers[163].Set(_typeDefault);
                /* 164 SeqOp            */ __Matchers[164].Set(__Matchers[162], _name, __Matchers[163]);
                /* 165 SeqOp            */ __Matchers[165].Set(__Matchers[141], _type);
                /* 168 AltOp            */ __Matchers[168].Set(__Matchers[166], __Matchers[167]);
                /* 169 StarOp           */ __Matchers[169].Set(_declaration);
                /* 170 AltOp            */ __Matchers[170].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 172 OptionalOp       */ __Matchers[172].Set(_genericParameters);
                /* 173 OptionalOp       */ __Matchers[173].Set(_constraints);
                /* 174 SeqOp            */ __Matchers[174].Set(_prelude, __Matchers[171], _type, _name, __Matchers[172], _parameters, __Matchers[173], _functionBody);
                /* 176 OptionalOp       */ __Matchers[176].Set(_type);
                /* 177 SeqOp            */ __Matchers[177].Set(_prelude, __Matchers[175], __Matchers[176], _name, _attributeBody);
                /* 179 OptionalOp       */ __Matchers[179].Set(_parameters);
                /* 180 OptionalOp       */ __Matchers[180].Set(_extends);
                /* 181 OptionalOp       */ __Matchers[181].Set(_satisfies);
                /* 182 OptionalOp       */ __Matchers[182].Set(_caseTypes);
                /* 183 SeqOp            */ __Matchers[183].Set(_prelude, __Matchers[178], _name, __Matchers[172], __Matchers[179], __Matchers[180], __Matchers[181], __Matchers[182], __Matchers[173], _blockBody);
                /* 185 SeqOp            */ __Matchers[185].Set(_prelude, __Matchers[184], _name, __Matchers[172], __Matchers[179], __Matchers[181], __Matchers[182], __Matchers[173], _blockBody);
                /* 187 SeqOp            */ __Matchers[187].Set(_prelude, __Matchers[186], _name, __Matchers[180], __Matchers[181], _blockBody);
                /* 190 SeqOp            */ __Matchers[190].Set(_prelude, __Matchers[188], _name, __Matchers[172], __Matchers[173], __Matchers[189], _type, __Matchers[118]);
                /* 192 OptionalOp       */ __Matchers[192].Set(_name);
                /* 193 SeqOp            */ __Matchers[193].Set(_prelude, __Matchers[191], __Matchers[192], __Matchers[180], _functionBody);
                /* 194 AltOp            */ __Matchers[194].Set(_expressionBody, _blockBody, _nullBody);
                /* 195 SeqOp            */ __Matchers[195].Set(__Matchers[122], _usings, _statelarations, __Matchers[124]);
                /* 196 StarOp           */ __Matchers[196].Set(_statelaration);
                /* 197 AltOp            */ __Matchers[197].Set(_statement, _declaration);
                /* 198 SeqOp            */ __Matchers[198].Set(_functionSpecifier, __Matchers[118]);
                /* 199 SeqOp            */ __Matchers[199].Set(__Matchers[118]);
                /* 200 SeqOp            */ __Matchers[200].Set(__Matchers[189], _expression);
                /* 202 SeqOp            */ __Matchers[202].Set(__Matchers[201], _type);
                /* 204 SeqOp            */ __Matchers[204].Set(__Matchers[203], _unionTypeList);
                /* 205 PlusOp           */ __Matchers[205].Set(_constraint);
                /* 207 SeqOp            */ __Matchers[207].Set(__Matchers[206], _name, __Matchers[172], __Matchers[182], __Matchers[181]);
                /* 208 SeqOp            */ __Matchers[208].Set(__Matchers[133], _type);
                /* 209 StarOp           */ __Matchers[209].Set(__Matchers[208]);
                /* 210 SeqOp            */ __Matchers[210].Set(_type, __Matchers[209]);
                /* 212 SeqOp            */ __Matchers[212].Set(__Matchers[211], _caseTypeList);
                /* 214 SeqOp            */ __Matchers[214].Set(__Matchers[213], _type);
                /* 215 StarOp           */ __Matchers[215].Set(__Matchers[214]);
                /* 216 SeqOp            */ __Matchers[216].Set(_type, __Matchers[215]);
                /* 217 OptionalOp       */ __Matchers[217].Set(_stringLiteral);
                /* 218 StarOp           */ __Matchers[218].Set(_attribute);
                /* 219 SeqOp            */ __Matchers[219].Set(__Matchers[217], __Matchers[218]);
                /* 220 OptionalOp       */ __Matchers[220].Set(_attributeArguments);
                /* 221 SeqOp            */ __Matchers[221].Set(_name, __Matchers[220]);
                /* 223 OptionalOp       */ __Matchers[223].Set(_attributeArgumentList);
                /* 225 SeqOp            */ __Matchers[225].Set(__Matchers[222], __Matchers[223], __Matchers[224]);
                /* 226 SeqOp            */ __Matchers[226].Set(__Matchers[133], _attributeArgument);
                /* 227 StarOp           */ __Matchers[227].Set(__Matchers[226]);
                /* 228 SeqOp            */ __Matchers[228].Set(_attributeArgument, __Matchers[227]);
                /* 229 AltOp            */ __Matchers[229].Set(_stringLiteral, _metaReference);
                /* 230 AltOp            */ __Matchers[230].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 231 SeqOp            */ __Matchers[231].Set(__Matchers[178], _names);
                /* 232 SeqOp            */ __Matchers[232].Set(__Matchers[186], _names);
                /* 233 SeqOp            */ __Matchers[233].Set(__Matchers[175], _names);
                /* 234 SeqOp            */ __Matchers[234].Set(__Matchers[184], _names);
                /* 235 SeqOp            */ __Matchers[235].Set(__Matchers[171], _names);
                /* 236 AltOp            */ __Matchers[236].Set(_unionType, _variadicType, _intersectionlevelType);
                /* 237 AltOp            */ __Matchers[237].Set(_variadicTypeZero, _variadicTypeOne);
                /* 239 SeqOp            */ __Matchers[239].Set(_unionlevelType, __Matchers[238]);
                /* 241 SeqOp            */ __Matchers[241].Set(_unionlevelType, __Matchers[240]);
                /* 242 SeqOp            */ __Matchers[242].Set(_unionlevelType, __Matchers[213], _intersectionlevelType);
                /* 243 AltOp            */ __Matchers[243].Set(_intersectionType, _primaryType);
                /* 245 SeqOp            */ __Matchers[245].Set(_intersectionlevelType, __Matchers[244], _primaryType);
                /* 246 AltOp            */ __Matchers[246].Set(_nullableType, _arrayType, _reference, _typeSelector, _constructor);
                /* 248 SeqOp            */ __Matchers[248].Set(_primaryType, __Matchers[247]);
                /* 251 SeqOp            */ __Matchers[251].Set(_primaryType, __Matchers[249], __Matchers[250]);
                /* 252 SeqOp            */ __Matchers[252].Set(_primaryType, __Matchers[144], _reference);
                /* 253 SeqOp            */ __Matchers[253].Set(_primaryType, _arguments);
                /* 254 OptionalOp       */ __Matchers[254].Set(_parameterList);
                /* 255 SeqOp            */ __Matchers[255].Set(__Matchers[222], __Matchers[254], __Matchers[224]);
                /* 256 SeqOp            */ __Matchers[256].Set(__Matchers[133], _parameter);
                /* 257 StarOp           */ __Matchers[257].Set(__Matchers[256]);
                /* 258 SeqOp            */ __Matchers[258].Set(_parameter, __Matchers[257]);
                /* 259 SeqOp            */ __Matchers[259].Set(_prelude, _type, _name);
                /* 260 OptionalOp       */ __Matchers[260].Set(_argumentList);
                /* 261 SeqOp            */ __Matchers[261].Set(__Matchers[222], __Matchers[260], __Matchers[224]);
                /* 262 SeqOp            */ __Matchers[262].Set(__Matchers[133], _argument);
                /* 263 StarOp           */ __Matchers[263].Set(__Matchers[262]);
                /* 264 SeqOp            */ __Matchers[264].Set(_argument, __Matchers[263]);
                /* 265 AltOp            */ __Matchers[265].Set(_returnStatement, _assertStatement);
                /* 267 OptionalOp       */ __Matchers[267].Set(_expression);
                /* 268 SeqOp            */ __Matchers[268].Set(__Matchers[266], __Matchers[267], __Matchers[118]);
                /* 270 SeqOp            */ __Matchers[270].Set(__Matchers[217], __Matchers[269], _arguments, __Matchers[118]);
                /* 271 AltOp            */ __Matchers[271].Set(_notExpression, _equallevelExpression);
                /* 273 SeqOp            */ __Matchers[273].Set(__Matchers[272], _notlevelExpression);
                /* 274 AltOp            */ __Matchers[274].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _addlevelExpression);
                /* 276 SeqOp            */ __Matchers[276].Set(_addlevelExpression, __Matchers[275], _addlevelExpression);
                /* 278 SeqOp            */ __Matchers[278].Set(_addlevelExpression, __Matchers[277], _addlevelExpression);
                /* 280 SeqOp            */ __Matchers[280].Set(_addlevelExpression, __Matchers[279], _addlevelExpression);
                /* 282 SeqOp            */ __Matchers[282].Set(_addlevelExpression, __Matchers[281], _addlevelExpression);
                /* 283 AltOp            */ __Matchers[283].Set(_addExpression, _subExpression, _mullevelExpression);
                /* 284 SeqOp            */ __Matchers[284].Set(_addlevelExpression, __Matchers[240], _mullevelExpression);
                /* 286 SeqOp            */ __Matchers[286].Set(_addlevelExpression, __Matchers[285], _mullevelExpression);
                /* 287 AltOp            */ __Matchers[287].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 288 SeqOp            */ __Matchers[288].Set(_mullevelExpression, __Matchers[238], _primaryExpression);
                /* 290 SeqOp            */ __Matchers[290].Set(_mullevelExpression, __Matchers[289], _primaryExpression);
                /* 292 SeqOp            */ __Matchers[292].Set(_mullevelExpression, __Matchers[291], _primaryExpression);
                /* 293 AltOp            */ __Matchers[293].Set(_reference, _literal, _callExpression, _selectExpression);
                /* 294 SeqOp            */ __Matchers[294].Set(_primaryExpression, _arguments);
                /* 295 SeqOp            */ __Matchers[295].Set(_primaryExpression, __Matchers[144], _reference);
                /* 296 AltOp            */ __Matchers[296].Set(_stringLiteral, _naturalLiteral);
                /* 297 AltOp            */ __Matchers[297].Set(_plainStringLiteral, _verbatimStringLiteral);

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
            private readonly Mx.PlainRule _namespace;
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
            private readonly Mx.PlainRule _typeDefault;
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
            private readonly Mx.PlainRule _variadicType;
            private readonly Mx.PlainRule _variadicTypeZero;
            private readonly Mx.PlainRule _variadicTypeOne;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionlevelType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _nullableType;
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
        public interface ICNamespace : IRNode {}
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
        public interface ICTypeDefault : IRNode {}
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
        public interface ICVariadicType : ICUnionlevelType {}
        public interface ICVariadicTypeZero : ICVariadicType {}
        public interface ICVariadicTypeOne : ICVariadicType {}
        public interface ICUnionType : ICUnionlevelType {}
        public interface ICIntersectionlevelType : ICUnionlevelType {}
        public interface ICIntersectionType : ICIntersectionlevelType {}
        public interface ICPrimaryType : ICIntersectionlevelType {}
        public interface ICNullableType : ICPrimaryType {}
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
            public CNamespace Namespace => Get<CNamespace>(1);
            public CUsings Usings => Get<CUsings>(2);
            public CDeclarations Declarations => Get<CDeclarations>(3);
        }

        public partial class CNamespace : RSequence, ICNamespace
        {
            // sequence
            public CNamespace(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'namespace'
            public CNames Names => Get<CNames>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
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
            public ROptional<CTypeDefault> TypeDefault => Get<ROptional<CTypeDefault>>(2);
        }

        public partial class CTypeDefault : RSequence, ICTypeDefault
        {
            // sequence
            public CTypeDefault(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICType Type => Get<ICType>(1);
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

        public partial class CVariadicTypeZero : RSequence, ICVariadicTypeZero
        {
            // sequence
            public CVariadicTypeZero(params RNode[] children) : base(children) {}

            public ICUnionlevelType UnionlevelType => Get<ICUnionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '*'
        }

        public partial class CVariadicTypeOne : RSequence, ICVariadicTypeOne
        {
            // sequence
            public CVariadicTypeOne(params RNode[] children) : base(children) {}

            public ICUnionlevelType UnionlevelType => Get<ICUnionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
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

        public partial class CNullableType : RSequence, ICNullableType
        {
            // sequence
            public CNullableType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '?'
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

            protected virtual void Visit(CTypeDefault element)
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

            protected virtual void Visit(CVariadicTypeZero element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariadicTypeOne element)
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

            protected virtual void Visit(CNullableType element)
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
