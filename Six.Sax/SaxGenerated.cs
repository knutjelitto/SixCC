// <generated from="D:\\Six\\Six.Sax\\Sax.six" at="09.02.2022 20:49:59" />

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
                : base(new Mx.Matcher[310])
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
                /*  78 PlainRuleOp      */ __Matchers[78] = _multiParameters = new Mx.PlainRule(this, 78, "multi-parameters") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _parameters = new Mx.PlainRule(this, 79, "parameters") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _parameterList = new Mx.PlainRule(this, 80, "parameter-list") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _parameter = new Mx.PlainRule(this, 81, "parameter") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _arguments = new Mx.PlainRule(this, 82, "arguments") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _argumentList = new Mx.PlainRule(this, 83, "argument-list") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _argument = new Mx.PlainRule(this, 84, "argument") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _statement = new Mx.PlainRule(this, 85, "statement") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _returnStatement = new Mx.PlainRule(this, 86, "return-statement") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _assertStatement = new Mx.PlainRule(this, 87, "assert-statement") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _expression = new Mx.PlainRule(this, 88, "expression") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _levelDisExpression = new Mx.PlainRule(this, 89, "level-dis-expression") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _disjunctionExpression = new Mx.PlainRule(this, 90, "disjunction-expression") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _levelConExpression = new Mx.PlainRule(this, 91, "level-con-expression") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _conjunctionExpression = new Mx.PlainRule(this, 92, "conjunction-expression") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _levelNotExpression = new Mx.PlainRule(this, 93, "level-not-expression") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _notExpression = new Mx.PlainRule(this, 94, "not-expression") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _levelEqExpression = new Mx.PlainRule(this, 95, "level-eq-expression") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _equalExpression = new Mx.PlainRule(this, 96, "equal-expression") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _notEqualExpression = new Mx.PlainRule(this, 97, "not-equal-expression") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _identicalExpression = new Mx.PlainRule(this, 98, "identical-expression") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _notIdenticalExpression = new Mx.PlainRule(this, 99, "not-identical-expression") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _levelAddExpression = new Mx.PlainRule(this, 100, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _addExpression = new Mx.PlainRule(this, 101, "add-expression") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _subExpression = new Mx.PlainRule(this, 102, "sub-expression") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _mullevelExpression = new Mx.PlainRule(this, 103, "mullevel-expression") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _mulExpression = new Mx.PlainRule(this, 104, "mul-expression") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _divExpression = new Mx.PlainRule(this, 105, "div-expression") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _remExpression = new Mx.PlainRule(this, 106, "rem-expression") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _primaryExpression = new Mx.PlainRule(this, 107, "primary-expression") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _callExpression = new Mx.PlainRule(this, 108, "call-expression") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _selectExpression = new Mx.PlainRule(this, 109, "select-expression") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _literal = new Mx.PlainRule(this, 110, "literal") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _stringLiteral = new Mx.PlainRule(this, 111, "string-literal") { Builder = nodes => nodes[0] };
                /* 112 DfaRuleOp        */ __Matchers[112] = _naturalLiteral = new Mx.DfaRule(this, 112, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 113 DfaRuleOp        */ __Matchers[113] = _plainStringLiteral = new Mx.DfaRule(this, 113, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 114 DfaRuleOp        */ __Matchers[114] = _verbatimStringLiteral = new Mx.DfaRule(this, 114, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 115 DfaRuleOp        */ __Matchers[115] = _identifier = new Mx.DfaRule(this, 115, "identifier") { Creator = node => new CIdentifier(node) };
                /* 116 EofOp            */ __Matchers[116] = new Mx.Eof(this, 116, "<eof>") { Creator = node => new REof(node) };
                /* 117 SeqOp            */ __Matchers[117] = new Mx.Seq(this, 117, "_117:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 118 AltOp            */ __Matchers[118] = new Mx.Alt(this, 118, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 119 StringOp         */ __Matchers[119] = new Mx.String(this, 119, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 120 OptionalOp       */ __Matchers[120] = new Mx.Optional(this, 120, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 121 SeqOp            */ __Matchers[121] = new Mx.Seq(this, 121, "_121:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 122 StringOp         */ __Matchers[122] = new Mx.Keyword(this, 122, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 123 StringOp         */ __Matchers[123] = new Mx.String(this, 123, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 124 SeqOp            */ __Matchers[124] = new Mx.Seq(this, 124, "_124:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 125 StringOp         */ __Matchers[125] = new Mx.Keyword(this, 125, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 126 SeqOp            */ __Matchers[126] = new Mx.Seq(this, 126, "_126:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 127 StringOp         */ __Matchers[127] = new Mx.String(this, 127, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 128 StarOp           */ __Matchers[128] = new Mx.Star(this, 128, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 129 StringOp         */ __Matchers[129] = new Mx.String(this, 129, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 130 SeqOp            */ __Matchers[130] = new Mx.Seq(this, 130, "_130:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 131 StringOp         */ __Matchers[131] = new Mx.Keyword(this, 131, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 132 SeqOp            */ __Matchers[132] = new Mx.Seq(this, 132, "_132:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 133 StarOp           */ __Matchers[133] = new Mx.Star(this, 133, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 134 StringOp         */ __Matchers[134] = new Mx.Keyword(this, 134, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 135 SeqOp            */ __Matchers[135] = new Mx.Seq(this, 135, "_135:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 136 OptionalOp       */ __Matchers[136] = new Mx.Optional(this, 136, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 137 SeqOp            */ __Matchers[137] = new Mx.Seq(this, 137, "_137:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 138 StringOp         */ __Matchers[138] = new Mx.String(this, 138, "','", ",") { Creator = node => new RLiteral(node) };
                /* 139 SeqOp            */ __Matchers[139] = new Mx.Seq(this, 139, "_139:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 140 StarOp           */ __Matchers[140] = new Mx.Star(this, 140, "*(_139:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 141 SeqOp            */ __Matchers[141] = new Mx.Seq(this, 141, "_141:(>using-element,*(_139:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 142 AltOp            */ __Matchers[142] = new Mx.Alt(this, 142, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 143 OptionalOp       */ __Matchers[143] = new Mx.Optional(this, 143, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 144 OptionalOp       */ __Matchers[144] = new Mx.Optional(this, 144, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 145 SeqOp            */ __Matchers[145] = new Mx.Seq(this, 145, "_145:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 146 StringOp         */ __Matchers[146] = new Mx.String(this, 146, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 147 SeqOp            */ __Matchers[147] = new Mx.Seq(this, 147, "_147:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 148 StringOp         */ __Matchers[148] = new Mx.String(this, 148, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 149 StringOp         */ __Matchers[149] = new Mx.String(this, 149, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 150 SeqOp            */ __Matchers[150] = new Mx.Seq(this, 150, "_150:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 151 StarOp           */ __Matchers[151] = new Mx.Star(this, 151, "*(_150:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 152 SeqOp            */ __Matchers[152] = new Mx.Seq(this, 152, "_152:(>name,*(_150:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 153 OptionalOp       */ __Matchers[153] = new Mx.Optional(this, 153, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 154 SeqOp            */ __Matchers[154] = new Mx.Seq(this, 154, "_154:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 155 StringOp         */ __Matchers[155] = new Mx.String(this, 155, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 156 OptionalOp       */ __Matchers[156] = new Mx.Optional(this, 156, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 157 StringOp         */ __Matchers[157] = new Mx.String(this, 157, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 158 SeqOp            */ __Matchers[158] = new Mx.Seq(this, 158, "_158:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 159 SeqOp            */ __Matchers[159] = new Mx.Seq(this, 159, "_159:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 160 StarOp           */ __Matchers[160] = new Mx.Star(this, 160, "*(_159:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 161 SeqOp            */ __Matchers[161] = new Mx.Seq(this, 161, "_161:(>generic-argument,*(_159:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 162 OptionalOp       */ __Matchers[162] = new Mx.Optional(this, 162, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 163 SeqOp            */ __Matchers[163] = new Mx.Seq(this, 163, "_163:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 164 SeqOp            */ __Matchers[164] = new Mx.Seq(this, 164, "_164:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 165 StarOp           */ __Matchers[165] = new Mx.Star(this, 165, "*(_164:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 166 SeqOp            */ __Matchers[166] = new Mx.Seq(this, 166, "_166:(>generic-parameter,*(_164:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 167 OptionalOp       */ __Matchers[167] = new Mx.Optional(this, 167, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 168 OptionalOp       */ __Matchers[168] = new Mx.Optional(this, 168, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 169 SeqOp            */ __Matchers[169] = new Mx.Seq(this, 169, "_169:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 170 SeqOp            */ __Matchers[170] = new Mx.Seq(this, 170, "_170:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 171 StringOp         */ __Matchers[171] = new Mx.Keyword(this, 171, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 172 StringOp         */ __Matchers[172] = new Mx.Keyword(this, 172, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 173 AltOp            */ __Matchers[173] = new Mx.Alt(this, 173, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 174 StarOp           */ __Matchers[174] = new Mx.Star(this, 174, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 175 AltOp            */ __Matchers[175] = new Mx.Alt(this, 175, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 176 StringOp         */ __Matchers[176] = new Mx.Keyword(this, 176, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 177 OptionalOp       */ __Matchers[177] = new Mx.Optional(this, 177, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 178 OptionalOp       */ __Matchers[178] = new Mx.Optional(this, 178, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 179 SeqOp            */ __Matchers[179] = new Mx.Seq(this, 179, "_179:(>prelude,'function',>type,>name,?(>generic-parameters),>multi-parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 180 StringOp         */ __Matchers[180] = new Mx.Keyword(this, 180, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 181 OptionalOp       */ __Matchers[181] = new Mx.Optional(this, 181, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 182 SeqOp            */ __Matchers[182] = new Mx.Seq(this, 182, "_182:(>prelude,'value',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 183 StringOp         */ __Matchers[183] = new Mx.Keyword(this, 183, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 184 OptionalOp       */ __Matchers[184] = new Mx.Optional(this, 184, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 185 OptionalOp       */ __Matchers[185] = new Mx.Optional(this, 185, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 186 OptionalOp       */ __Matchers[186] = new Mx.Optional(this, 186, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 187 OptionalOp       */ __Matchers[187] = new Mx.Optional(this, 187, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 188 SeqOp            */ __Matchers[188] = new Mx.Seq(this, 188, "_188:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.Keyword(this, 189, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 191 StringOp         */ __Matchers[191] = new Mx.Keyword(this, 191, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 193 StringOp         */ __Matchers[193] = new Mx.Keyword(this, 193, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 194 StringOp         */ __Matchers[194] = new Mx.String(this, 194, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 195 SeqOp            */ __Matchers[195] = new Mx.Seq(this, 195, "_195:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 196 StringOp         */ __Matchers[196] = new Mx.Keyword(this, 196, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 197 OptionalOp       */ __Matchers[197] = new Mx.Optional(this, 197, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 199 AltOp            */ __Matchers[199] = new Mx.Alt(this, 199, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 201 StarOp           */ __Matchers[201] = new Mx.Star(this, 201, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 202 AltOp            */ __Matchers[202] = new Mx.Alt(this, 202, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 203 SeqOp            */ __Matchers[203] = new Mx.Seq(this, 203, "_203:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 204 SeqOp            */ __Matchers[204] = new Mx.Seq(this, 204, "_204:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 206 StringOp         */ __Matchers[206] = new Mx.String(this, 206, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 208 StringOp         */ __Matchers[208] = new Mx.Keyword(this, 208, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 209 SeqOp            */ __Matchers[209] = new Mx.Seq(this, 209, "_209:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 210 PlusOp           */ __Matchers[210] = new Mx.Plus(this, 210, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 211 StringOp         */ __Matchers[211] = new Mx.Keyword(this, 211, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 213 SeqOp            */ __Matchers[213] = new Mx.Seq(this, 213, "_213:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 214 StarOp           */ __Matchers[214] = new Mx.Star(this, 214, "*(_213:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 215 SeqOp            */ __Matchers[215] = new Mx.Seq(this, 215, "_215:(>type,*(_213:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 216 StringOp         */ __Matchers[216] = new Mx.Keyword(this, 216, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 217 SeqOp            */ __Matchers[217] = new Mx.Seq(this, 217, "_217:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 218 StringOp         */ __Matchers[218] = new Mx.String(this, 218, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 220 StarOp           */ __Matchers[220] = new Mx.Star(this, 220, "*(_219:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:(>type,*(_219:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 222 OptionalOp       */ __Matchers[222] = new Mx.Optional(this, 222, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 223 StarOp           */ __Matchers[223] = new Mx.Star(this, 223, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 225 OptionalOp       */ __Matchers[225] = new Mx.Optional(this, 225, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 227 StringOp         */ __Matchers[227] = new Mx.String(this, 227, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 228 OptionalOp       */ __Matchers[228] = new Mx.Optional(this, 228, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 229 StringOp         */ __Matchers[229] = new Mx.String(this, 229, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 230 SeqOp            */ __Matchers[230] = new Mx.Seq(this, 230, "_230:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 232 StarOp           */ __Matchers[232] = new Mx.Star(this, 232, "*(_231:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 233 SeqOp            */ __Matchers[233] = new Mx.Seq(this, 233, "_233:(>attribute-argument,*(_231:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 234 AltOp            */ __Matchers[234] = new Mx.Alt(this, 234, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 235 AltOp            */ __Matchers[235] = new Mx.Alt(this, 235, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 236 SeqOp            */ __Matchers[236] = new Mx.Seq(this, 236, "_236:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 237 SeqOp            */ __Matchers[237] = new Mx.Seq(this, 237, "_237:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 238 SeqOp            */ __Matchers[238] = new Mx.Seq(this, 238, "_238:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 239 SeqOp            */ __Matchers[239] = new Mx.Seq(this, 239, "_239:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 241 AltOp            */ __Matchers[241] = new Mx.Alt(this, 241, "alt(>union-type|>variadic-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 242 AltOp            */ __Matchers[242] = new Mx.Alt(this, 242, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 243 StringOp         */ __Matchers[243] = new Mx.String(this, 243, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 244 SeqOp            */ __Matchers[244] = new Mx.Seq(this, 244, "_244:(>unionlevel-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 245 StringOp         */ __Matchers[245] = new Mx.String(this, 245, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 246 SeqOp            */ __Matchers[246] = new Mx.Seq(this, 246, "_246:(>unionlevel-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 247 SeqOp            */ __Matchers[247] = new Mx.Seq(this, 247, "_247:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 248 AltOp            */ __Matchers[248] = new Mx.Alt(this, 248, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 249 StringOp         */ __Matchers[249] = new Mx.String(this, 249, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 251 AltOp            */ __Matchers[251] = new Mx.Alt(this, 251, "alt(>nullable-type|>array-type|>reference|>type-selector|>constructor)") { Builder = nodes => nodes[0] };
                /* 252 StringOp         */ __Matchers[252] = new Mx.String(this, 252, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 253 SeqOp            */ __Matchers[253] = new Mx.Seq(this, 253, "_253:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 254 StringOp         */ __Matchers[254] = new Mx.String(this, 254, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 255 StringOp         */ __Matchers[255] = new Mx.String(this, 255, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 256 SeqOp            */ __Matchers[256] = new Mx.Seq(this, 256, "_256:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 257 SeqOp            */ __Matchers[257] = new Mx.Seq(this, 257, "_257:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 258 SeqOp            */ __Matchers[258] = new Mx.Seq(this, 258, "_258:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 259 PlusOp           */ __Matchers[259] = new Mx.Plus(this, 259, "+(>parameters)") { Builder = nodes => new CMultiParameters(nodes) };
                /* 260 OptionalOp       */ __Matchers[260] = new Mx.Optional(this, 260, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 261 SeqOp            */ __Matchers[261] = new Mx.Seq(this, 261, "_261:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 262 SeqOp            */ __Matchers[262] = new Mx.Seq(this, 262, "_262:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 263 StarOp           */ __Matchers[263] = new Mx.Star(this, 263, "*(_262:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 264 SeqOp            */ __Matchers[264] = new Mx.Seq(this, 264, "_264:(>parameter,*(_262:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 265 SeqOp            */ __Matchers[265] = new Mx.Seq(this, 265, "_265:(>prelude,>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 266 OptionalOp       */ __Matchers[266] = new Mx.Optional(this, 266, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 267 SeqOp            */ __Matchers[267] = new Mx.Seq(this, 267, "_267:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 268 SeqOp            */ __Matchers[268] = new Mx.Seq(this, 268, "_268:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 269 StarOp           */ __Matchers[269] = new Mx.Star(this, 269, "*(_268:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 270 SeqOp            */ __Matchers[270] = new Mx.Seq(this, 270, "_270:(>argument,*(_268:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 271 AltOp            */ __Matchers[271] = new Mx.Alt(this, 271, "alt(>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 272 StringOp         */ __Matchers[272] = new Mx.Keyword(this, 272, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 273 OptionalOp       */ __Matchers[273] = new Mx.Optional(this, 273, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 275 StringOp         */ __Matchers[275] = new Mx.Keyword(this, 275, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 277 AltOp            */ __Matchers[277] = new Mx.Alt(this, 277, "alt(>disjunction-expression|>level-con-expression)") { Builder = nodes => nodes[0] };
                /* 278 StringOp         */ __Matchers[278] = new Mx.String(this, 278, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 279 SeqOp            */ __Matchers[279] = new Mx.Seq(this, 279, "_279:(>level-dis-expression,'||',>level-con-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 280 AltOp            */ __Matchers[280] = new Mx.Alt(this, 280, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 281 StringOp         */ __Matchers[281] = new Mx.String(this, 281, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:(>level-con-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 283 AltOp            */ __Matchers[283] = new Mx.Alt(this, 283, "alt(>not-expression|>level-eq-expression)") { Builder = nodes => nodes[0] };
                /* 284 StringOp         */ __Matchers[284] = new Mx.String(this, 284, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 285 SeqOp            */ __Matchers[285] = new Mx.Seq(this, 285, "_285:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 286 AltOp            */ __Matchers[286] = new Mx.Alt(this, 286, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 287 StringOp         */ __Matchers[287] = new Mx.String(this, 287, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 288 SeqOp            */ __Matchers[288] = new Mx.Seq(this, 288, "_288:(>level-add-expression,'==',>level-add-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 289 StringOp         */ __Matchers[289] = new Mx.String(this, 289, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 290 SeqOp            */ __Matchers[290] = new Mx.Seq(this, 290, "_290:(>level-add-expression,'!=',>level-add-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 291 StringOp         */ __Matchers[291] = new Mx.String(this, 291, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:(>level-add-expression,'===',>level-add-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 293 StringOp         */ __Matchers[293] = new Mx.String(this, 293, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 294 SeqOp            */ __Matchers[294] = new Mx.Seq(this, 294, "_294:(>level-add-expression,'!==',>level-add-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 295 AltOp            */ __Matchers[295] = new Mx.Alt(this, 295, "alt(>add-expression|>sub-expression|>mullevel-expression)") { Builder = nodes => nodes[0] };
                /* 296 SeqOp            */ __Matchers[296] = new Mx.Seq(this, 296, "_296:(>level-add-expression,'+',>mullevel-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 297 StringOp         */ __Matchers[297] = new Mx.String(this, 297, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 298 SeqOp            */ __Matchers[298] = new Mx.Seq(this, 298, "_298:(>level-add-expression,'-',>mullevel-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 299 AltOp            */ __Matchers[299] = new Mx.Alt(this, 299, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 300 SeqOp            */ __Matchers[300] = new Mx.Seq(this, 300, "_300:(>mullevel-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 301 StringOp         */ __Matchers[301] = new Mx.String(this, 301, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:(>mullevel-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 303 StringOp         */ __Matchers[303] = new Mx.String(this, 303, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 304 SeqOp            */ __Matchers[304] = new Mx.Seq(this, 304, "_304:(>mullevel-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 305 AltOp            */ __Matchers[305] = new Mx.Alt(this, 305, "alt(>reference|>literal|>call-expression|>select-expression)") { Builder = nodes => nodes[0] };
                /* 306 SeqOp            */ __Matchers[306] = new Mx.Seq(this, 306, "_306:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 308 AltOp            */ __Matchers[308] = new Mx.Alt(this, 308, "alt(>string-literal|>natural-literal)") { Builder = nodes => nodes[0] };
                /* 309 AltOp            */ __Matchers[309] = new Mx.Alt(this, 309, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[117]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[118]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[121]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[124]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[126]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[130]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[132]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[133]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[135]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[137]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[141]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[142]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[145]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[147]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[148]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[152]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[154]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[158]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[161]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[163]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[166]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[169]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[170]);
                /*  29 PlainRuleOp      */ _variance.Set(__Matchers[173]);
                /*  30 PlainRuleOp      */ _declarations.Set(__Matchers[174]);
                /*  31 PlainRuleOp      */ _declaration.Set(__Matchers[175]);
                /*  32 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[179]);
                /*  33 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[182]);
                /*  34 PlainRuleOp      */ _classDeclaration.Set(__Matchers[188]);
                /*  35 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[190]);
                /*  36 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[192]);
                /*  37 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[195]);
                /*  38 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[198]);
                /*  39 PlainRuleOp      */ _functionBody.Set(__Matchers[199]);
                /*  40 PlainRuleOp      */ _attributeBody.Set(__Matchers[199]);
                /*  41 PlainRuleOp      */ _blockBody.Set(__Matchers[200]);
                /*  42 PlainRuleOp      */ _statelarations.Set(__Matchers[201]);
                /*  43 PlainRuleOp      */ _statelaration.Set(__Matchers[202]);
                /*  44 PlainRuleOp      */ _expressionBody.Set(__Matchers[203]);
                /*  45 PlainRuleOp      */ _nullBody.Set(__Matchers[204]);
                /*  46 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[205]);
                /*  47 PlainRuleOp      */ _extends.Set(__Matchers[207]);
                /*  48 PlainRuleOp      */ _satisfies.Set(__Matchers[209]);
                /*  49 PlainRuleOp      */ _constraints.Set(__Matchers[210]);
                /*  50 PlainRuleOp      */ _constraint.Set(__Matchers[212]);
                /*  51 PlainRuleOp      */ _unionTypeList.Set(__Matchers[215]);
                /*  52 PlainRuleOp      */ _caseTypes.Set(__Matchers[217]);
                /*  53 PlainRuleOp      */ _caseTypeList.Set(__Matchers[221]);
                /*  54 PlainRuleOp      */ _prelude.Set(__Matchers[224]);
                /*  55 PlainRuleOp      */ _attribute.Set(__Matchers[226]);
                /*  56 PlainRuleOp      */ _attributeArguments.Set(__Matchers[230]);
                /*  57 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[233]);
                /*  58 PlainRuleOp      */ _attributeArgument.Set(__Matchers[234]);
                /*  59 PlainRuleOp      */ _metaReference.Set(__Matchers[235]);
                /*  60 PlainRuleOp      */ _classReference.Set(__Matchers[236]);
                /*  61 PlainRuleOp      */ _objectReference.Set(__Matchers[237]);
                /*  62 PlainRuleOp      */ _valueReference.Set(__Matchers[238]);
                /*  63 PlainRuleOp      */ _interfaceReference.Set(__Matchers[239]);
                /*  64 PlainRuleOp      */ _functionReference.Set(__Matchers[240]);
                /*  65 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  66 PlainRuleOp      */ _unionlevelType.Set(__Matchers[241]);
                /*  67 PlainRuleOp      */ _variadicType.Set(__Matchers[242]);
                /*  68 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[244]);
                /*  69 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[246]);
                /*  70 PlainRuleOp      */ _unionType.Set(__Matchers[247]);
                /*  71 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[248]);
                /*  72 PlainRuleOp      */ _intersectionType.Set(__Matchers[250]);
                /*  73 PlainRuleOp      */ _primaryType.Set(__Matchers[251]);
                /*  74 PlainRuleOp      */ _nullableType.Set(__Matchers[253]);
                /*  75 PlainRuleOp      */ _arrayType.Set(__Matchers[256]);
                /*  76 PlainRuleOp      */ _typeSelector.Set(__Matchers[257]);
                /*  77 PlainRuleOp      */ _constructor.Set(__Matchers[258]);
                /*  78 PlainRuleOp      */ _multiParameters.Set(__Matchers[259]);
                /*  79 PlainRuleOp      */ _parameters.Set(__Matchers[261]);
                /*  80 PlainRuleOp      */ _parameterList.Set(__Matchers[264]);
                /*  81 PlainRuleOp      */ _parameter.Set(__Matchers[265]);
                /*  82 PlainRuleOp      */ _arguments.Set(__Matchers[267]);
                /*  83 PlainRuleOp      */ _argumentList.Set(__Matchers[270]);
                /*  84 PlainRuleOp      */ _argument.Set(_expression);
                /*  85 PlainRuleOp      */ _statement.Set(__Matchers[271]);
                /*  86 PlainRuleOp      */ _returnStatement.Set(__Matchers[274]);
                /*  87 PlainRuleOp      */ _assertStatement.Set(__Matchers[276]);
                /*  88 PlainRuleOp      */ _expression.Set(_levelDisExpression);
                /*  89 PlainRuleOp      */ _levelDisExpression.Set(__Matchers[277]);
                /*  90 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[279]);
                /*  91 PlainRuleOp      */ _levelConExpression.Set(__Matchers[280]);
                /*  92 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[282]);
                /*  93 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[283]);
                /*  94 PlainRuleOp      */ _notExpression.Set(__Matchers[285]);
                /*  95 PlainRuleOp      */ _levelEqExpression.Set(__Matchers[286]);
                /*  96 PlainRuleOp      */ _equalExpression.Set(__Matchers[288]);
                /*  97 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[290]);
                /*  98 PlainRuleOp      */ _identicalExpression.Set(__Matchers[292]);
                /*  99 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[294]);
                /* 100 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[295]);
                /* 101 PlainRuleOp      */ _addExpression.Set(__Matchers[296]);
                /* 102 PlainRuleOp      */ _subExpression.Set(__Matchers[298]);
                /* 103 PlainRuleOp      */ _mullevelExpression.Set(__Matchers[299]);
                /* 104 PlainRuleOp      */ _mulExpression.Set(__Matchers[300]);
                /* 105 PlainRuleOp      */ _divExpression.Set(__Matchers[302]);
                /* 106 PlainRuleOp      */ _remExpression.Set(__Matchers[304]);
                /* 107 PlainRuleOp      */ _primaryExpression.Set(__Matchers[305]);
                /* 108 PlainRuleOp      */ _callExpression.Set(__Matchers[306]);
                /* 109 PlainRuleOp      */ _selectExpression.Set(__Matchers[307]);
                /* 110 PlainRuleOp      */ _literal.Set(__Matchers[308]);
                /* 111 PlainRuleOp      */ _stringLiteral.Set(__Matchers[309]);
                /* 112 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 113 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 114 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 115 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 117 SeqOp            */ __Matchers[117].Set(_compilationUnit, __Matchers[116]);
                /* 118 AltOp            */ __Matchers[118].Set(_moduleDescriptor, _codeUnit);
                /* 120 OptionalOp       */ __Matchers[120].Set(__Matchers[119]);
                /* 121 SeqOp            */ __Matchers[121].Set(__Matchers[120], _namespace, _usings, _declarations);
                /* 124 SeqOp            */ __Matchers[124].Set(_prelude, __Matchers[122], _names, __Matchers[123]);
                /* 126 SeqOp            */ __Matchers[126].Set(__Matchers[125], _names, _moduleBody);
                /* 128 StarOp           */ __Matchers[128].Set(_moduleBodyElement);
                /* 130 SeqOp            */ __Matchers[130].Set(__Matchers[127], __Matchers[128], __Matchers[129]);
                /* 132 SeqOp            */ __Matchers[132].Set(__Matchers[131], _names, __Matchers[123]);
                /* 133 StarOp           */ __Matchers[133].Set(_usingDeclaration);
                /* 135 SeqOp            */ __Matchers[135].Set(__Matchers[134], _names, _usingElements);
                /* 136 OptionalOp       */ __Matchers[136].Set(_usingElementList);
                /* 137 SeqOp            */ __Matchers[137].Set(__Matchers[127], __Matchers[136], __Matchers[129]);
                /* 139 SeqOp            */ __Matchers[139].Set(__Matchers[138], _usingElement);
                /* 140 StarOp           */ __Matchers[140].Set(__Matchers[139]);
                /* 141 SeqOp            */ __Matchers[141].Set(_usingElement, __Matchers[140]);
                /* 142 AltOp            */ __Matchers[142].Set(_usingNamed, _usingWildcard);
                /* 143 OptionalOp       */ __Matchers[143].Set(_usingNameSpecifier);
                /* 144 OptionalOp       */ __Matchers[144].Set(_usingElements);
                /* 145 SeqOp            */ __Matchers[145].Set(_usingName, __Matchers[143], __Matchers[144]);
                /* 147 SeqOp            */ __Matchers[147].Set(__Matchers[146], _identifier);
                /* 150 SeqOp            */ __Matchers[150].Set(__Matchers[149], _name);
                /* 151 StarOp           */ __Matchers[151].Set(__Matchers[150]);
                /* 152 SeqOp            */ __Matchers[152].Set(_name, __Matchers[151]);
                /* 153 OptionalOp       */ __Matchers[153].Set(_genericArguments);
                /* 154 SeqOp            */ __Matchers[154].Set(_name, __Matchers[153]);
                /* 156 OptionalOp       */ __Matchers[156].Set(_genericArgumentList);
                /* 158 SeqOp            */ __Matchers[158].Set(__Matchers[155], __Matchers[156], __Matchers[157]);
                /* 159 SeqOp            */ __Matchers[159].Set(__Matchers[138], _genericArgument);
                /* 160 StarOp           */ __Matchers[160].Set(__Matchers[159]);
                /* 161 SeqOp            */ __Matchers[161].Set(_genericArgument, __Matchers[160]);
                /* 162 OptionalOp       */ __Matchers[162].Set(_genericParameterList);
                /* 163 SeqOp            */ __Matchers[163].Set(__Matchers[155], __Matchers[162], __Matchers[157]);
                /* 164 SeqOp            */ __Matchers[164].Set(__Matchers[138], _genericParameter);
                /* 165 StarOp           */ __Matchers[165].Set(__Matchers[164]);
                /* 166 SeqOp            */ __Matchers[166].Set(_genericParameter, __Matchers[165]);
                /* 167 OptionalOp       */ __Matchers[167].Set(_variance);
                /* 168 OptionalOp       */ __Matchers[168].Set(_typeDefault);
                /* 169 SeqOp            */ __Matchers[169].Set(__Matchers[167], _name, __Matchers[168]);
                /* 170 SeqOp            */ __Matchers[170].Set(__Matchers[146], _type);
                /* 173 AltOp            */ __Matchers[173].Set(__Matchers[171], __Matchers[172]);
                /* 174 StarOp           */ __Matchers[174].Set(_declaration);
                /* 175 AltOp            */ __Matchers[175].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 177 OptionalOp       */ __Matchers[177].Set(_genericParameters);
                /* 178 OptionalOp       */ __Matchers[178].Set(_constraints);
                /* 179 SeqOp            */ __Matchers[179].Set(_prelude, __Matchers[176], _type, _name, __Matchers[177], _multiParameters, __Matchers[178], _functionBody);
                /* 181 OptionalOp       */ __Matchers[181].Set(_type);
                /* 182 SeqOp            */ __Matchers[182].Set(_prelude, __Matchers[180], __Matchers[181], _name, _attributeBody);
                /* 184 OptionalOp       */ __Matchers[184].Set(_parameters);
                /* 185 OptionalOp       */ __Matchers[185].Set(_extends);
                /* 186 OptionalOp       */ __Matchers[186].Set(_satisfies);
                /* 187 OptionalOp       */ __Matchers[187].Set(_caseTypes);
                /* 188 SeqOp            */ __Matchers[188].Set(_prelude, __Matchers[183], _name, __Matchers[177], __Matchers[184], __Matchers[185], __Matchers[186], __Matchers[187], __Matchers[178], _blockBody);
                /* 190 SeqOp            */ __Matchers[190].Set(_prelude, __Matchers[189], _name, __Matchers[177], __Matchers[184], __Matchers[186], __Matchers[187], __Matchers[178], _blockBody);
                /* 192 SeqOp            */ __Matchers[192].Set(_prelude, __Matchers[191], _name, __Matchers[185], __Matchers[186], _blockBody);
                /* 195 SeqOp            */ __Matchers[195].Set(_prelude, __Matchers[193], _name, __Matchers[177], __Matchers[178], __Matchers[194], _type, __Matchers[123]);
                /* 197 OptionalOp       */ __Matchers[197].Set(_name);
                /* 198 SeqOp            */ __Matchers[198].Set(_prelude, __Matchers[196], __Matchers[197], __Matchers[185], _functionBody);
                /* 199 AltOp            */ __Matchers[199].Set(_expressionBody, _blockBody, _nullBody);
                /* 200 SeqOp            */ __Matchers[200].Set(__Matchers[127], _usings, _statelarations, __Matchers[129]);
                /* 201 StarOp           */ __Matchers[201].Set(_statelaration);
                /* 202 AltOp            */ __Matchers[202].Set(_statement, _declaration);
                /* 203 SeqOp            */ __Matchers[203].Set(_functionSpecifier, __Matchers[123]);
                /* 204 SeqOp            */ __Matchers[204].Set(__Matchers[123]);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[194], _expression);
                /* 207 SeqOp            */ __Matchers[207].Set(__Matchers[206], _type);
                /* 209 SeqOp            */ __Matchers[209].Set(__Matchers[208], _unionTypeList);
                /* 210 PlusOp           */ __Matchers[210].Set(_constraint);
                /* 212 SeqOp            */ __Matchers[212].Set(__Matchers[211], _name, __Matchers[177], __Matchers[187], __Matchers[186]);
                /* 213 SeqOp            */ __Matchers[213].Set(__Matchers[138], _type);
                /* 214 StarOp           */ __Matchers[214].Set(__Matchers[213]);
                /* 215 SeqOp            */ __Matchers[215].Set(_type, __Matchers[214]);
                /* 217 SeqOp            */ __Matchers[217].Set(__Matchers[216], _caseTypeList);
                /* 219 SeqOp            */ __Matchers[219].Set(__Matchers[218], _type);
                /* 220 StarOp           */ __Matchers[220].Set(__Matchers[219]);
                /* 221 SeqOp            */ __Matchers[221].Set(_type, __Matchers[220]);
                /* 222 OptionalOp       */ __Matchers[222].Set(_stringLiteral);
                /* 223 StarOp           */ __Matchers[223].Set(_attribute);
                /* 224 SeqOp            */ __Matchers[224].Set(__Matchers[222], __Matchers[223]);
                /* 225 OptionalOp       */ __Matchers[225].Set(_attributeArguments);
                /* 226 SeqOp            */ __Matchers[226].Set(_name, __Matchers[225]);
                /* 228 OptionalOp       */ __Matchers[228].Set(_attributeArgumentList);
                /* 230 SeqOp            */ __Matchers[230].Set(__Matchers[227], __Matchers[228], __Matchers[229]);
                /* 231 SeqOp            */ __Matchers[231].Set(__Matchers[138], _attributeArgument);
                /* 232 StarOp           */ __Matchers[232].Set(__Matchers[231]);
                /* 233 SeqOp            */ __Matchers[233].Set(_attributeArgument, __Matchers[232]);
                /* 234 AltOp            */ __Matchers[234].Set(_stringLiteral, _metaReference);
                /* 235 AltOp            */ __Matchers[235].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 236 SeqOp            */ __Matchers[236].Set(__Matchers[183], _names);
                /* 237 SeqOp            */ __Matchers[237].Set(__Matchers[191], _names);
                /* 238 SeqOp            */ __Matchers[238].Set(__Matchers[180], _names);
                /* 239 SeqOp            */ __Matchers[239].Set(__Matchers[189], _names);
                /* 240 SeqOp            */ __Matchers[240].Set(__Matchers[176], _names);
                /* 241 AltOp            */ __Matchers[241].Set(_unionType, _variadicType, _intersectionlevelType);
                /* 242 AltOp            */ __Matchers[242].Set(_variadicTypeZero, _variadicTypeOne);
                /* 244 SeqOp            */ __Matchers[244].Set(_unionlevelType, __Matchers[243]);
                /* 246 SeqOp            */ __Matchers[246].Set(_unionlevelType, __Matchers[245]);
                /* 247 SeqOp            */ __Matchers[247].Set(_unionlevelType, __Matchers[218], _intersectionlevelType);
                /* 248 AltOp            */ __Matchers[248].Set(_intersectionType, _primaryType);
                /* 250 SeqOp            */ __Matchers[250].Set(_intersectionlevelType, __Matchers[249], _primaryType);
                /* 251 AltOp            */ __Matchers[251].Set(_nullableType, _arrayType, _reference, _typeSelector, _constructor);
                /* 253 SeqOp            */ __Matchers[253].Set(_primaryType, __Matchers[252]);
                /* 256 SeqOp            */ __Matchers[256].Set(_primaryType, __Matchers[254], __Matchers[255]);
                /* 257 SeqOp            */ __Matchers[257].Set(_primaryType, __Matchers[149], _reference);
                /* 258 SeqOp            */ __Matchers[258].Set(_primaryType, _arguments);
                /* 259 PlusOp           */ __Matchers[259].Set(_parameters);
                /* 260 OptionalOp       */ __Matchers[260].Set(_parameterList);
                /* 261 SeqOp            */ __Matchers[261].Set(__Matchers[227], __Matchers[260], __Matchers[229]);
                /* 262 SeqOp            */ __Matchers[262].Set(__Matchers[138], _parameter);
                /* 263 StarOp           */ __Matchers[263].Set(__Matchers[262]);
                /* 264 SeqOp            */ __Matchers[264].Set(_parameter, __Matchers[263]);
                /* 265 SeqOp            */ __Matchers[265].Set(_prelude, _type, _name);
                /* 266 OptionalOp       */ __Matchers[266].Set(_argumentList);
                /* 267 SeqOp            */ __Matchers[267].Set(__Matchers[227], __Matchers[266], __Matchers[229]);
                /* 268 SeqOp            */ __Matchers[268].Set(__Matchers[138], _argument);
                /* 269 StarOp           */ __Matchers[269].Set(__Matchers[268]);
                /* 270 SeqOp            */ __Matchers[270].Set(_argument, __Matchers[269]);
                /* 271 AltOp            */ __Matchers[271].Set(_returnStatement, _assertStatement);
                /* 273 OptionalOp       */ __Matchers[273].Set(_expression);
                /* 274 SeqOp            */ __Matchers[274].Set(__Matchers[272], __Matchers[273], __Matchers[123]);
                /* 276 SeqOp            */ __Matchers[276].Set(__Matchers[222], __Matchers[275], _arguments, __Matchers[123]);
                /* 277 AltOp            */ __Matchers[277].Set(_disjunctionExpression, _levelConExpression);
                /* 279 SeqOp            */ __Matchers[279].Set(_levelDisExpression, __Matchers[278], _levelConExpression);
                /* 280 AltOp            */ __Matchers[280].Set(_conjunctionExpression, _levelNotExpression);
                /* 282 SeqOp            */ __Matchers[282].Set(_levelConExpression, __Matchers[281], _levelNotExpression);
                /* 283 AltOp            */ __Matchers[283].Set(_notExpression, _levelEqExpression);
                /* 285 SeqOp            */ __Matchers[285].Set(__Matchers[284], _levelNotExpression);
                /* 286 AltOp            */ __Matchers[286].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelAddExpression);
                /* 288 SeqOp            */ __Matchers[288].Set(_levelAddExpression, __Matchers[287], _levelAddExpression);
                /* 290 SeqOp            */ __Matchers[290].Set(_levelAddExpression, __Matchers[289], _levelAddExpression);
                /* 292 SeqOp            */ __Matchers[292].Set(_levelAddExpression, __Matchers[291], _levelAddExpression);
                /* 294 SeqOp            */ __Matchers[294].Set(_levelAddExpression, __Matchers[293], _levelAddExpression);
                /* 295 AltOp            */ __Matchers[295].Set(_addExpression, _subExpression, _mullevelExpression);
                /* 296 SeqOp            */ __Matchers[296].Set(_levelAddExpression, __Matchers[245], _mullevelExpression);
                /* 298 SeqOp            */ __Matchers[298].Set(_levelAddExpression, __Matchers[297], _mullevelExpression);
                /* 299 AltOp            */ __Matchers[299].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 300 SeqOp            */ __Matchers[300].Set(_mullevelExpression, __Matchers[243], _primaryExpression);
                /* 302 SeqOp            */ __Matchers[302].Set(_mullevelExpression, __Matchers[301], _primaryExpression);
                /* 304 SeqOp            */ __Matchers[304].Set(_mullevelExpression, __Matchers[303], _primaryExpression);
                /* 305 AltOp            */ __Matchers[305].Set(_reference, _literal, _callExpression, _selectExpression);
                /* 306 SeqOp            */ __Matchers[306].Set(_primaryExpression, _arguments);
                /* 307 SeqOp            */ __Matchers[307].Set(_primaryExpression, __Matchers[149], _reference);
                /* 308 AltOp            */ __Matchers[308].Set(_stringLiteral, _naturalLiteral);
                /* 309 AltOp            */ __Matchers[309].Set(_plainStringLiteral, _verbatimStringLiteral);

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
            private readonly Mx.PlainRule _multiParameters;
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
            private readonly Mx.PlainRule _levelDisExpression;
            private readonly Mx.PlainRule _disjunctionExpression;
            private readonly Mx.PlainRule _levelConExpression;
            private readonly Mx.PlainRule _conjunctionExpression;
            private readonly Mx.PlainRule _levelNotExpression;
            private readonly Mx.PlainRule _notExpression;
            private readonly Mx.PlainRule _levelEqExpression;
            private readonly Mx.PlainRule _equalExpression;
            private readonly Mx.PlainRule _notEqualExpression;
            private readonly Mx.PlainRule _identicalExpression;
            private readonly Mx.PlainRule _notIdenticalExpression;
            private readonly Mx.PlainRule _levelAddExpression;
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
        public interface ICMultiParameters : IRNode {}
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
        public interface ICLevelDisExpression : ICExpression {}
        public interface ICDisjunctionExpression : ICLevelDisExpression {}
        public interface ICLevelConExpression : ICLevelDisExpression {}
        public interface ICConjunctionExpression : ICLevelConExpression {}
        public interface ICLevelNotExpression : ICLevelConExpression {}
        public interface ICNotExpression : ICLevelNotExpression {}
        public interface ICLevelEqExpression : ICLevelNotExpression {}
        public interface ICEqualExpression : ICLevelEqExpression {}
        public interface ICNotEqualExpression : ICLevelEqExpression {}
        public interface ICIdenticalExpression : ICLevelEqExpression {}
        public interface ICNotIdenticalExpression : ICLevelEqExpression {}
        public interface ICLevelAddExpression : ICLevelEqExpression {}
        public interface ICAddExpression : ICLevelAddExpression {}
        public interface ICSubExpression : ICLevelAddExpression {}
        public interface ICMullevelExpression : ICLevelAddExpression {}
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
            public CMultiParameters MultiParameters => Get<CMultiParameters>(5);
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

        public partial class CMultiParameters : RPlus<CParameters>, ICMultiParameters
        {
            // +plus+
            public CMultiParameters(params RNode[] children) : base(children) {}
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

        public partial class CDisjunctionExpression : RSequence, ICDisjunctionExpression
        {
            // sequence
            public CDisjunctionExpression(params RNode[] children) : base(children) {}

            public ICLevelDisExpression LevelDisExpression => Get<ICLevelDisExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '||'
            public ICLevelConExpression LevelConExpression => Get<ICLevelConExpression>(2);
        }

        public partial class CConjunctionExpression : RSequence, ICConjunctionExpression
        {
            // sequence
            public CConjunctionExpression(params RNode[] children) : base(children) {}

            public ICLevelConExpression LevelConExpression => Get<ICLevelConExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '&&'
            public ICLevelNotExpression LevelNotExpression => Get<ICLevelNotExpression>(2);
        }

        public partial class CNotExpression : RSequence, ICNotExpression
        {
            // sequence
            public CNotExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '!'
            public ICLevelNotExpression LevelNotExpression => Get<ICLevelNotExpression>(1);
        }

        public partial class CEqualExpression : RSequence, ICEqualExpression
        {
            // sequence
            public CEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '=='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CNotEqualExpression : RSequence, ICNotEqualExpression
        {
            // sequence
            public CNotEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CIdenticalExpression : RSequence, ICIdenticalExpression
        {
            // sequence
            public CIdenticalExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '==='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CNotIdenticalExpression : RSequence, ICNotIdenticalExpression
        {
            // sequence
            public CNotIdenticalExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!=='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CAddExpression : RSequence, ICAddExpression
        {
            // sequence
            public CAddExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
            public ICMullevelExpression MullevelExpression => Get<ICMullevelExpression>(2);
        }

        public partial class CSubExpression : RSequence, ICSubExpression
        {
            // sequence
            public CSubExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
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

            protected virtual void Visit(CMultiParameters element)
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

            protected virtual void Visit(CDisjunctionExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConjunctionExpression element)
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
