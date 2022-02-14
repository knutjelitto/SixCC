// <generated from="D:\\Six\\Six.Sax\\Sax.six" at="14.02.2022 04:46:21" />

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
                : base(new Mx.Matcher[431])
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
                /*  29 PlainRuleOp      */ __Matchers[29] = _valueDefault = new Mx.PlainRule(this, 29, "value-default") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _variance = new Mx.PlainRule(this, 30, "variance") { Creator = node => new CVariance(node) };
                /*  31 PlainRuleOp      */ __Matchers[31] = _declarations = new Mx.PlainRule(this, 31, "declarations") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _declaration = new Mx.PlainRule(this, 32, "declaration") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _functionDeclaration = new Mx.PlainRule(this, 33, "function-declaration") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _attributeDeclaration = new Mx.PlainRule(this, 34, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _classDeclaration = new Mx.PlainRule(this, 35, "class-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _interfaceDeclaration = new Mx.PlainRule(this, 36, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _objectDeclaration = new Mx.PlainRule(this, 37, "object-declaration") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _aliasDeclaration = new Mx.PlainRule(this, 38, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _constructorDeclaration = new Mx.PlainRule(this, 39, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _functionBody = new Mx.PlainRule(this, 40, "function-body") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _attributeBody = new Mx.PlainRule(this, 41, "attribute-body") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _blockBody = new Mx.PlainRule(this, 42, "block-body") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _statelarations = new Mx.PlainRule(this, 43, "statelarations") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _statelaration = new Mx.PlainRule(this, 44, "statelaration") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _expressionBody = new Mx.PlainRule(this, 45, "expression-body") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _nullBody = new Mx.PlainRule(this, 46, "null-body") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _functionSpecifier = new Mx.PlainRule(this, 47, "function-specifier") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _extends = new Mx.PlainRule(this, 48, "extends") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _extendType = new Mx.PlainRule(this, 49, "extend-type") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _constructor = new Mx.PlainRule(this, 50, "constructor") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _satisfies = new Mx.PlainRule(this, 51, "satisfies") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _constraints = new Mx.PlainRule(this, 52, "constraints") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _constraint = new Mx.PlainRule(this, 53, "constraint") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _unionTypeList = new Mx.PlainRule(this, 54, "union-type-list") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _caseTypes = new Mx.PlainRule(this, 55, "case-types") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _caseTypeList = new Mx.PlainRule(this, 56, "case-type-list") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _pattern = new Mx.PlainRule(this, 57, "pattern") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _namePattern = new Mx.PlainRule(this, 58, "name-pattern") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _prelude = new Mx.PlainRule(this, 59, "prelude") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _attribute = new Mx.PlainRule(this, 60, "attribute") { Builder = nodes => nodes[0] };
                /*  61 DfaRuleOp        */ __Matchers[61] = _attributeName = new Mx.DfaRule(this, 61, "attribute-name") { Creator = node => new CAttributeName(node) };
                /*  62 PlainRuleOp      */ __Matchers[62] = _attributeArguments = new Mx.PlainRule(this, 62, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _attributeArgumentList = new Mx.PlainRule(this, 63, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _attributeArgument = new Mx.PlainRule(this, 64, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _literalArgument = new Mx.PlainRule(this, 65, "literal-argument") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _metaArgument = new Mx.PlainRule(this, 66, "meta-argument") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _metaReference = new Mx.PlainRule(this, 67, "meta-reference") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _classReference = new Mx.PlainRule(this, 68, "class-reference") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _objectReference = new Mx.PlainRule(this, 69, "object-reference") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _valueReference = new Mx.PlainRule(this, 70, "value-reference") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _interfaceReference = new Mx.PlainRule(this, 71, "interface-reference") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _functionReference = new Mx.PlainRule(this, 72, "function-reference") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _type = new Mx.PlainRule(this, 73, "type") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _entryType = new Mx.PlainRule(this, 74, "entry-type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _variadicType = new Mx.PlainRule(this, 75, "variadic-type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _variadicTypeZero = new Mx.PlainRule(this, 76, "variadic-type-zero") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _variadicTypeOne = new Mx.PlainRule(this, 77, "variadic-type-one") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _unionType = new Mx.PlainRule(this, 78, "union-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _intersectionType = new Mx.PlainRule(this, 79, "intersection-type") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _primaryType = new Mx.PlainRule(this, 80, "primary-type") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _nullableType = new Mx.PlainRule(this, 81, "nullable-type") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _sequenceType = new Mx.PlainRule(this, 82, "sequence-type") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeSelector = new Mx.PlainRule(this, 83, "type-selector") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _callableType = new Mx.PlainRule(this, 84, "callable-type") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _callableArguments = new Mx.PlainRule(this, 85, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _typeList = new Mx.PlainRule(this, 86, "type-list") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _typeListType = new Mx.PlainRule(this, 87, "type-list-type") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _defaultedType = new Mx.PlainRule(this, 88, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _spreadType = new Mx.PlainRule(this, 89, "spread-type") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _emptyType = new Mx.PlainRule(this, 90, "empty-type") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _tupleType = new Mx.PlainRule(this, 91, "tuple-type") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _iterableType = new Mx.PlainRule(this, 92, "iterable-type") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _iterableTypeZero = new Mx.PlainRule(this, 93, "iterable-type-zero") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _iterableTypeOne = new Mx.PlainRule(this, 94, "iterable-type-one") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _nothingType = new Mx.PlainRule(this, 95, "nothing-type") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _multiParameters = new Mx.PlainRule(this, 96, "multi-parameters") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _parameters = new Mx.PlainRule(this, 97, "parameters") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _parameterList = new Mx.PlainRule(this, 98, "parameter-list") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _parameter = new Mx.PlainRule(this, 99, "parameter") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _valueParameter = new Mx.PlainRule(this, 100, "value-parameter") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _parameterType = new Mx.PlainRule(this, 101, "parameter-type") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _arguments = new Mx.PlainRule(this, 102, "arguments") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _argumentList = new Mx.PlainRule(this, 103, "argument-list") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _argument = new Mx.PlainRule(this, 104, "argument") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _expressionArgument = new Mx.PlainRule(this, 105, "expression-argument") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _spreadArgument = new Mx.PlainRule(this, 106, "spread-argument") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _statement = new Mx.PlainRule(this, 107, "statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _ifStatement = new Mx.PlainRule(this, 108, "if-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _elseIf = new Mx.PlainRule(this, 109, "else-if") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _elseBlock = new Mx.PlainRule(this, 110, "else-block") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _forStatement = new Mx.PlainRule(this, 111, "for-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _returnStatement = new Mx.PlainRule(this, 112, "return-statement") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _assertStatement = new Mx.PlainRule(this, 113, "assert-statement") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _expression = new Mx.PlainRule(this, 114, "expression") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _levelCoalesceExpression = new Mx.PlainRule(this, 115, "level-coalesce-expression") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _thenExpression = new Mx.PlainRule(this, 116, "then-expression") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _elseExpression = new Mx.PlainRule(this, 117, "else-expression") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _levelDisjunctionExpression = new Mx.PlainRule(this, 118, "level-disjunction-expression") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _disjunctionExpression = new Mx.PlainRule(this, 119, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _levelConjunctionExpression = new Mx.PlainRule(this, 120, "level-conjunction-expression") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _conjunctionExpression = new Mx.PlainRule(this, 121, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _levelNotExpression = new Mx.PlainRule(this, 122, "level-not-expression") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _notExpression = new Mx.PlainRule(this, 123, "not-expression") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _levelEqualityExpression = new Mx.PlainRule(this, 124, "level-equality-expression") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _equalExpression = new Mx.PlainRule(this, 125, "equal-expression") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _notEqualExpression = new Mx.PlainRule(this, 126, "not-equal-expression") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _identicalExpression = new Mx.PlainRule(this, 127, "identical-expression") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _notIdenticalExpression = new Mx.PlainRule(this, 128, "not-identical-expression") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _levelCompareExpression = new Mx.PlainRule(this, 129, "level-compare-expression") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _lessExpression = new Mx.PlainRule(this, 130, "less-expression") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _lessEqualExpression = new Mx.PlainRule(this, 131, "less-equal-expression") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _greaterExpression = new Mx.PlainRule(this, 132, "greater-expression") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _greaterEqualExpression = new Mx.PlainRule(this, 133, "greater-equal-expression") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _levelAddExpression = new Mx.PlainRule(this, 134, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _addExpression = new Mx.PlainRule(this, 135, "add-expression") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _subExpression = new Mx.PlainRule(this, 136, "sub-expression") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _levelMulExpression = new Mx.PlainRule(this, 137, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _mulExpression = new Mx.PlainRule(this, 138, "mul-expression") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _divExpression = new Mx.PlainRule(this, 139, "div-expression") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _remExpression = new Mx.PlainRule(this, 140, "rem-expression") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _levelUnionExpression = new Mx.PlainRule(this, 141, "level-union-expression") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _unionExpression = new Mx.PlainRule(this, 142, "union-expression") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _complementExpression = new Mx.PlainRule(this, 143, "complement-expression") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _primaryExpression = new Mx.PlainRule(this, 144, "primary-expression") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _callExpression = new Mx.PlainRule(this, 145, "call-expression") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _selectExpression = new Mx.PlainRule(this, 146, "select-expression") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _nullsafeSelectExpression = new Mx.PlainRule(this, 147, "nullsafe-select-expression") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _literal = new Mx.PlainRule(this, 148, "literal") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _stringExpression = new Mx.PlainRule(this, 149, "string-expression") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _stringLiteral = new Mx.PlainRule(this, 150, "string-literal") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _stringInterpolation = new Mx.PlainRule(this, 151, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _interpolationPart = new Mx.PlainRule(this, 152, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _ifExpression = new Mx.PlainRule(this, 153, "if-expression") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _ifThen = new Mx.PlainRule(this, 154, "if-then") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _ifElse = new Mx.PlainRule(this, 155, "if-else") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _conditionalExpression = new Mx.PlainRule(this, 156, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _conditions = new Mx.PlainRule(this, 157, "conditions") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _conditionList = new Mx.PlainRule(this, 158, "condition-list") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _condition = new Mx.PlainRule(this, 159, "condition") { Builder = nodes => nodes[0] };
                /* 160 DfaRuleOp        */ __Matchers[160] = _naturalLiteral = new Mx.DfaRule(this, 160, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 161 DfaRuleOp        */ __Matchers[161] = _stringStart = new Mx.DfaRule(this, 161, "string-start") { Creator = node => new CStringStart(node) };
                /* 162 DfaRuleOp        */ __Matchers[162] = _stringMid = new Mx.DfaRule(this, 162, "string-mid") { Creator = node => new CStringMid(node) };
                /* 163 DfaRuleOp        */ __Matchers[163] = _stringEnd = new Mx.DfaRule(this, 163, "string-end") { Creator = node => new CStringEnd(node) };
                /* 164 DfaRuleOp        */ __Matchers[164] = _plainStringLiteral = new Mx.DfaRule(this, 164, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 165 DfaRuleOp        */ __Matchers[165] = _verbatimStringLiteral = new Mx.DfaRule(this, 165, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 166 DfaRuleOp        */ __Matchers[166] = _identifier = new Mx.DfaRule(this, 166, "identifier") { Creator = node => new CIdentifier(node) };
                /* 167 EofOp            */ __Matchers[167] = new Mx.Eof(this, 167, "<eof>") { Creator = node => new REof(node) };
                /* 168 SeqOp            */ __Matchers[168] = new Mx.Seq(this, 168, "_168:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 169 AltOp            */ __Matchers[169] = new Mx.Alt(this, 169, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 170 StringOp         */ __Matchers[170] = new Mx.String(this, 170, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 171 OptionalOp       */ __Matchers[171] = new Mx.Optional(this, 171, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 172 SeqOp            */ __Matchers[172] = new Mx.Seq(this, 172, "_172:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 173 StringOp         */ __Matchers[173] = new Mx.Keyword(this, 173, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 174 StringOp         */ __Matchers[174] = new Mx.String(this, 174, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 175 SeqOp            */ __Matchers[175] = new Mx.Seq(this, 175, "_175:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 176 StringOp         */ __Matchers[176] = new Mx.Keyword(this, 176, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 177 SeqOp            */ __Matchers[177] = new Mx.Seq(this, 177, "_177:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 178 StringOp         */ __Matchers[178] = new Mx.String(this, 178, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 179 StarOp           */ __Matchers[179] = new Mx.Star(this, 179, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 180 StringOp         */ __Matchers[180] = new Mx.String(this, 180, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 182 StringOp         */ __Matchers[182] = new Mx.Keyword(this, 182, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 184 StarOp           */ __Matchers[184] = new Mx.Star(this, 184, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 185 StringOp         */ __Matchers[185] = new Mx.Keyword(this, 185, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 186 SeqOp            */ __Matchers[186] = new Mx.Seq(this, 186, "_186:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 187 OptionalOp       */ __Matchers[187] = new Mx.Optional(this, 187, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 188 SeqOp            */ __Matchers[188] = new Mx.Seq(this, 188, "_188:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.String(this, 189, "','", ",") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 191 StarOp           */ __Matchers[191] = new Mx.Star(this, 191, "*(_190:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:(>using-element,*(_190:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 193 AltOp            */ __Matchers[193] = new Mx.Alt(this, 193, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 194 OptionalOp       */ __Matchers[194] = new Mx.Optional(this, 194, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 195 OptionalOp       */ __Matchers[195] = new Mx.Optional(this, 195, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 197 StringOp         */ __Matchers[197] = new Mx.String(this, 197, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 199 StringOp         */ __Matchers[199] = new Mx.String(this, 199, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 200 StringOp         */ __Matchers[200] = new Mx.String(this, 200, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 202 StarOp           */ __Matchers[202] = new Mx.Star(this, 202, "*(_201:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 203 SeqOp            */ __Matchers[203] = new Mx.Seq(this, 203, "_203:(>name,*(_201:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 204 OptionalOp       */ __Matchers[204] = new Mx.Optional(this, 204, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 206 StringOp         */ __Matchers[206] = new Mx.String(this, 206, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 207 OptionalOp       */ __Matchers[207] = new Mx.Optional(this, 207, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 208 StringOp         */ __Matchers[208] = new Mx.String(this, 208, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 209 SeqOp            */ __Matchers[209] = new Mx.Seq(this, 209, "_209:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 210 SeqOp            */ __Matchers[210] = new Mx.Seq(this, 210, "_210:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 211 StarOp           */ __Matchers[211] = new Mx.Star(this, 211, "*(_210:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:(>generic-argument,*(_210:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 213 OptionalOp       */ __Matchers[213] = new Mx.Optional(this, 213, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 214 SeqOp            */ __Matchers[214] = new Mx.Seq(this, 214, "_214:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 215 SeqOp            */ __Matchers[215] = new Mx.Seq(this, 215, "_215:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 216 StarOp           */ __Matchers[216] = new Mx.Star(this, 216, "*(_215:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 217 SeqOp            */ __Matchers[217] = new Mx.Seq(this, 217, "_217:(>generic-parameter,*(_215:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 218 OptionalOp       */ __Matchers[218] = new Mx.Optional(this, 218, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 219 OptionalOp       */ __Matchers[219] = new Mx.Optional(this, 219, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 220 SeqOp            */ __Matchers[220] = new Mx.Seq(this, 220, "_220:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 222 SeqOp            */ __Matchers[222] = new Mx.Seq(this, 222, "_222:('=',>expression)") { Builder = nodes => new CValueDefault(nodes) };
                /* 223 StringOp         */ __Matchers[223] = new Mx.Keyword(this, 223, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 224 StringOp         */ __Matchers[224] = new Mx.Keyword(this, 224, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 225 AltOp            */ __Matchers[225] = new Mx.Alt(this, 225, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 226 StarOp           */ __Matchers[226] = new Mx.Star(this, 226, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 227 AltOp            */ __Matchers[227] = new Mx.Alt(this, 227, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 228 OptionalOp       */ __Matchers[228] = new Mx.Optional(this, 228, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 229 OptionalOp       */ __Matchers[229] = new Mx.Optional(this, 229, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 230 OptionalOp       */ __Matchers[230] = new Mx.Optional(this, 230, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:(>prelude,?(>type),>name,?(>generic-parameters),>multi-parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 232 SeqOp            */ __Matchers[232] = new Mx.Seq(this, 232, "_232:(>prelude,?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 233 StringOp         */ __Matchers[233] = new Mx.Keyword(this, 233, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 234 OptionalOp       */ __Matchers[234] = new Mx.Optional(this, 234, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 235 OptionalOp       */ __Matchers[235] = new Mx.Optional(this, 235, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 236 OptionalOp       */ __Matchers[236] = new Mx.Optional(this, 236, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 237 OptionalOp       */ __Matchers[237] = new Mx.Optional(this, 237, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 238 SeqOp            */ __Matchers[238] = new Mx.Seq(this, 238, "_238:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 239 StringOp         */ __Matchers[239] = new Mx.Keyword(this, 239, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 241 StringOp         */ __Matchers[241] = new Mx.Keyword(this, 241, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 242 SeqOp            */ __Matchers[242] = new Mx.Seq(this, 242, "_242:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 243 StringOp         */ __Matchers[243] = new Mx.Keyword(this, 243, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 244 StringOp         */ __Matchers[244] = new Mx.String(this, 244, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 246 StringOp         */ __Matchers[246] = new Mx.Keyword(this, 246, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 247 OptionalOp       */ __Matchers[247] = new Mx.Optional(this, 247, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 249 AltOp            */ __Matchers[249] = new Mx.Alt(this, 249, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 251 StarOp           */ __Matchers[251] = new Mx.Star(this, 251, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 252 AltOp            */ __Matchers[252] = new Mx.Alt(this, 252, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 253 SeqOp            */ __Matchers[253] = new Mx.Seq(this, 253, "_253:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 254 SeqOp            */ __Matchers[254] = new Mx.Seq(this, 254, "_254:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 255 SeqOp            */ __Matchers[255] = new Mx.Seq(this, 255, "_255:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 256 StringOp         */ __Matchers[256] = new Mx.String(this, 256, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 257 SeqOp            */ __Matchers[257] = new Mx.Seq(this, 257, "_257:(':',>extend-type)") { Builder = nodes => new CExtends(nodes) };
                /* 258 AltOp            */ __Matchers[258] = new Mx.Alt(this, 258, "alt(>type|>constructor)") { Builder = nodes => nodes[0] };
                /* 259 SeqOp            */ __Matchers[259] = new Mx.Seq(this, 259, "_259:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 260 StringOp         */ __Matchers[260] = new Mx.Keyword(this, 260, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 261 SeqOp            */ __Matchers[261] = new Mx.Seq(this, 261, "_261:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 262 PlusOp           */ __Matchers[262] = new Mx.Plus(this, 262, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 263 StringOp         */ __Matchers[263] = new Mx.Keyword(this, 263, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 264 SeqOp            */ __Matchers[264] = new Mx.Seq(this, 264, "_264:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 265 SeqOp            */ __Matchers[265] = new Mx.Seq(this, 265, "_265:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 266 StarOp           */ __Matchers[266] = new Mx.Star(this, 266, "*(_265:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 267 SeqOp            */ __Matchers[267] = new Mx.Seq(this, 267, "_267:(>type,*(_265:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 268 StringOp         */ __Matchers[268] = new Mx.Keyword(this, 268, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 269 SeqOp            */ __Matchers[269] = new Mx.Seq(this, 269, "_269:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 270 StringOp         */ __Matchers[270] = new Mx.String(this, 270, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 271 SeqOp            */ __Matchers[271] = new Mx.Seq(this, 271, "_271:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 272 StarOp           */ __Matchers[272] = new Mx.Star(this, 272, "*(_271:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 273 SeqOp            */ __Matchers[273] = new Mx.Seq(this, 273, "_273:(>type,*(_271:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 275 OptionalOp       */ __Matchers[275] = new Mx.Optional(this, 275, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 276 StarOp           */ __Matchers[276] = new Mx.Star(this, 276, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 278 OptionalOp       */ __Matchers[278] = new Mx.Optional(this, 278, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 279 SeqOp            */ __Matchers[279] = new Mx.Seq(this, 279, "_279:(>attribute-name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 280 StringOp         */ __Matchers[280] = new Mx.String(this, 280, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 281 OptionalOp       */ __Matchers[281] = new Mx.Optional(this, 281, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 282 StringOp         */ __Matchers[282] = new Mx.String(this, 282, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 283 SeqOp            */ __Matchers[283] = new Mx.Seq(this, 283, "_283:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 284 SeqOp            */ __Matchers[284] = new Mx.Seq(this, 284, "_284:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 285 StarOp           */ __Matchers[285] = new Mx.Star(this, 285, "*(_284:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 286 SeqOp            */ __Matchers[286] = new Mx.Seq(this, 286, "_286:(>attribute-argument,*(_284:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 287 AltOp            */ __Matchers[287] = new Mx.Alt(this, 287, "alt(>literal-argument|>meta-argument)") { Builder = nodes => nodes[0] };
                /* 288 SeqOp            */ __Matchers[288] = new Mx.Seq(this, 288, "_288:(>string-literal)") { Builder = nodes => new CLiteralArgument(nodes) };
                /* 289 SeqOp            */ __Matchers[289] = new Mx.Seq(this, 289, "_289:(>meta-reference)") { Builder = nodes => new CMetaArgument(nodes) };
                /* 290 AltOp            */ __Matchers[290] = new Mx.Alt(this, 290, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 291 SeqOp            */ __Matchers[291] = new Mx.Seq(this, 291, "_291:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 293 StringOp         */ __Matchers[293] = new Mx.Keyword(this, 293, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 294 SeqOp            */ __Matchers[294] = new Mx.Seq(this, 294, "_294:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 296 StringOp         */ __Matchers[296] = new Mx.Keyword(this, 296, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 297 SeqOp            */ __Matchers[297] = new Mx.Seq(this, 297, "_297:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 298 AltOp            */ __Matchers[298] = new Mx.Alt(this, 298, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 299 StringOp         */ __Matchers[299] = new Mx.String(this, 299, "'->'", "->") { Creator = node => new RLiteral(node) };
                /* 300 SeqOp            */ __Matchers[300] = new Mx.Seq(this, 300, "_300:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 301 AltOp            */ __Matchers[301] = new Mx.Alt(this, 301, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 302 StringOp         */ __Matchers[302] = new Mx.String(this, 302, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 303 SeqOp            */ __Matchers[303] = new Mx.Seq(this, 303, "_303:(>union-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 304 StringOp         */ __Matchers[304] = new Mx.String(this, 304, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 305 SeqOp            */ __Matchers[305] = new Mx.Seq(this, 305, "_305:(>union-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 306 SeqOp            */ __Matchers[306] = new Mx.Seq(this, 306, "_306:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 307 StarOp           */ __Matchers[307] = new Mx.Star(this, 307, "*(_306:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 308 SeqOp            */ __Matchers[308] = new Mx.Seq(this, 308, "_308:(>intersection-type,*(_306:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 309 StringOp         */ __Matchers[309] = new Mx.String(this, 309, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 310 SeqOp            */ __Matchers[310] = new Mx.Seq(this, 310, "_310:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 311 StarOp           */ __Matchers[311] = new Mx.Star(this, 311, "*(_310:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 312 SeqOp            */ __Matchers[312] = new Mx.Seq(this, 312, "_312:(>primary-type,*(_310:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 313 AltOp            */ __Matchers[313] = new Mx.Alt(this, 313, "alt(>nullable-type|>sequence-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>iterable-type|>nothing-type)") { Builder = nodes => nodes[0] };
                /* 314 StringOp         */ __Matchers[314] = new Mx.String(this, 314, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 315 SeqOp            */ __Matchers[315] = new Mx.Seq(this, 315, "_315:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 316 StringOp         */ __Matchers[316] = new Mx.String(this, 316, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 317 StringOp         */ __Matchers[317] = new Mx.String(this, 317, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 318 SeqOp            */ __Matchers[318] = new Mx.Seq(this, 318, "_318:(>primary-type,'[',']')") { Builder = nodes => new CSequenceType(nodes) };
                /* 319 SeqOp            */ __Matchers[319] = new Mx.Seq(this, 319, "_319:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 320 OptionalOp       */ __Matchers[320] = new Mx.Optional(this, 320, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 321 SeqOp            */ __Matchers[321] = new Mx.Seq(this, 321, "_321:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 322 AltOp            */ __Matchers[322] = new Mx.Alt(this, 322, "alt(>type-list|>spread-type)") { Builder = nodes => nodes[0] };
                /* 323 SeqOp            */ __Matchers[323] = new Mx.Seq(this, 323, "_323:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 324 StarOp           */ __Matchers[324] = new Mx.Star(this, 324, "*(_323:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 325 SeqOp            */ __Matchers[325] = new Mx.Seq(this, 325, "_325:(>type-list-type,*(_323:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 326 AltOp            */ __Matchers[326] = new Mx.Alt(this, 326, "alt(>type|>defaulted-type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 327 SeqOp            */ __Matchers[327] = new Mx.Seq(this, 327, "_327:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 328 SeqOp            */ __Matchers[328] = new Mx.Seq(this, 328, "_328:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 329 SeqOp            */ __Matchers[329] = new Mx.Seq(this, 329, "_329:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 330 SeqOp            */ __Matchers[330] = new Mx.Seq(this, 330, "_330:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 331 AltOp            */ __Matchers[331] = new Mx.Alt(this, 331, "alt(>iterable-type-zero|>iterable-type-one)") { Builder = nodes => nodes[0] };
                /* 332 SeqOp            */ __Matchers[332] = new Mx.Seq(this, 332, "_332:('{',>union-type,'*','}')") { Builder = nodes => new CIterableTypeZero(nodes) };
                /* 333 SeqOp            */ __Matchers[333] = new Mx.Seq(this, 333, "_333:('{',>union-type,'+','}')") { Builder = nodes => new CIterableTypeOne(nodes) };
                /* 334 StringOp         */ __Matchers[334] = new Mx.Keyword(this, 334, "'Nothing'", "Nothing") { Creator = node => new RLiteral(node) };
                /* 335 SeqOp            */ __Matchers[335] = new Mx.Seq(this, 335, "_335:('Nothing')") { Builder = nodes => new CNothingType(nodes) };
                /* 336 PlusOp           */ __Matchers[336] = new Mx.Plus(this, 336, "+(>parameters)") { Builder = nodes => new CMultiParameters(nodes) };
                /* 337 OptionalOp       */ __Matchers[337] = new Mx.Optional(this, 337, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 338 SeqOp            */ __Matchers[338] = new Mx.Seq(this, 338, "_338:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 339 SeqOp            */ __Matchers[339] = new Mx.Seq(this, 339, "_339:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 340 StarOp           */ __Matchers[340] = new Mx.Star(this, 340, "*(_339:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 341 SeqOp            */ __Matchers[341] = new Mx.Seq(this, 341, "_341:(>parameter,*(_339:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 342 OptionalOp       */ __Matchers[342] = new Mx.Optional(this, 342, "?(>parameter-type)") { Builder = nodes => new ROptional<ICParameterType>(nodes) };
                /* 343 OptionalOp       */ __Matchers[343] = new Mx.Optional(this, 343, "?(>value-default)") { Builder = nodes => new ROptional<CValueDefault>(nodes) };
                /* 344 SeqOp            */ __Matchers[344] = new Mx.Seq(this, 344, "_344:(>prelude,?(>parameter-type),>name,?(>value-default))") { Builder = nodes => new CValueParameter(nodes) };
                /* 345 AltOp            */ __Matchers[345] = new Mx.Alt(this, 345, "alt(>type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 346 OptionalOp       */ __Matchers[346] = new Mx.Optional(this, 346, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 347 SeqOp            */ __Matchers[347] = new Mx.Seq(this, 347, "_347:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 348 SeqOp            */ __Matchers[348] = new Mx.Seq(this, 348, "_348:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 349 StarOp           */ __Matchers[349] = new Mx.Star(this, 349, "*(_348:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 350 SeqOp            */ __Matchers[350] = new Mx.Seq(this, 350, "_350:(>argument,*(_348:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 351 AltOp            */ __Matchers[351] = new Mx.Alt(this, 351, "alt(>expression-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 352 SeqOp            */ __Matchers[352] = new Mx.Seq(this, 352, "_352:(>expression)") { Builder = nodes => new CExpressionArgument(nodes) };
                /* 353 SeqOp            */ __Matchers[353] = new Mx.Seq(this, 353, "_353:('*',>level-union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 354 AltOp            */ __Matchers[354] = new Mx.Alt(this, 354, "alt(>if-statement|>for-statement|>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 355 StringOp         */ __Matchers[355] = new Mx.Keyword(this, 355, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 356 StarOp           */ __Matchers[356] = new Mx.Star(this, 356, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 357 OptionalOp       */ __Matchers[357] = new Mx.Optional(this, 357, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 358 SeqOp            */ __Matchers[358] = new Mx.Seq(this, 358, "_358:('if',>conditions,>block-body,*(>else-if),?(>else-block))") { Builder = nodes => new CIfStatement(nodes) };
                /* 359 StringOp         */ __Matchers[359] = new Mx.Keyword(this, 359, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 360 SeqOp            */ __Matchers[360] = new Mx.Seq(this, 360, "_360:('else','if',>conditions,>block-body)") { Builder = nodes => new CElseIf(nodes) };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 362 StringOp         */ __Matchers[362] = new Mx.Keyword(this, 362, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 363 SeqOp            */ __Matchers[363] = new Mx.Seq(this, 363, "_363:('for','(',>pattern,'in',>expression,')',>block-body,?(>else-block))") { Builder = nodes => new CForStatement(nodes) };
                /* 364 StringOp         */ __Matchers[364] = new Mx.Keyword(this, 364, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 365 OptionalOp       */ __Matchers[365] = new Mx.Optional(this, 365, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 366 SeqOp            */ __Matchers[366] = new Mx.Seq(this, 366, "_366:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 367 StringOp         */ __Matchers[367] = new Mx.Keyword(this, 367, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 368 SeqOp            */ __Matchers[368] = new Mx.Seq(this, 368, "_368:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 369 AltOp            */ __Matchers[369] = new Mx.Alt(this, 369, "alt(>level-coalesce-expression|>if-expression)") { Builder = nodes => nodes[0] };
                /* 370 AltOp            */ __Matchers[370] = new Mx.Alt(this, 370, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 371 StringOp         */ __Matchers[371] = new Mx.Keyword(this, 371, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 372 SeqOp            */ __Matchers[372] = new Mx.Seq(this, 372, "_372:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 373 SeqOp            */ __Matchers[373] = new Mx.Seq(this, 373, "_373:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 374 AltOp            */ __Matchers[374] = new Mx.Alt(this, 374, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 375 StringOp         */ __Matchers[375] = new Mx.String(this, 375, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 376 SeqOp            */ __Matchers[376] = new Mx.Seq(this, 376, "_376:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 377 AltOp            */ __Matchers[377] = new Mx.Alt(this, 377, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 378 StringOp         */ __Matchers[378] = new Mx.String(this, 378, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 380 AltOp            */ __Matchers[380] = new Mx.Alt(this, 380, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 381 StringOp         */ __Matchers[381] = new Mx.String(this, 381, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 382 SeqOp            */ __Matchers[382] = new Mx.Seq(this, 382, "_382:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 383 AltOp            */ __Matchers[383] = new Mx.Alt(this, 383, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 384 StringOp         */ __Matchers[384] = new Mx.String(this, 384, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 385 SeqOp            */ __Matchers[385] = new Mx.Seq(this, 385, "_385:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 386 StringOp         */ __Matchers[386] = new Mx.String(this, 386, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 387 SeqOp            */ __Matchers[387] = new Mx.Seq(this, 387, "_387:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 388 StringOp         */ __Matchers[388] = new Mx.String(this, 388, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 389 SeqOp            */ __Matchers[389] = new Mx.Seq(this, 389, "_389:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 390 StringOp         */ __Matchers[390] = new Mx.String(this, 390, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 391 SeqOp            */ __Matchers[391] = new Mx.Seq(this, 391, "_391:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 392 AltOp            */ __Matchers[392] = new Mx.Alt(this, 392, "alt(>less-expression|>less-equal-expression|>greater-expression|>greater-equal-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 393 SeqOp            */ __Matchers[393] = new Mx.Seq(this, 393, "_393:(>level-add-expression,'<',>level-add-expression)") { Builder = nodes => new CLessExpression(nodes) };
                /* 394 StringOp         */ __Matchers[394] = new Mx.String(this, 394, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 395 SeqOp            */ __Matchers[395] = new Mx.Seq(this, 395, "_395:(>level-add-expression,'<=',>level-add-expression)") { Builder = nodes => new CLessEqualExpression(nodes) };
                /* 396 SeqOp            */ __Matchers[396] = new Mx.Seq(this, 396, "_396:(>level-add-expression,'>',>level-add-expression)") { Builder = nodes => new CGreaterExpression(nodes) };
                /* 397 StringOp         */ __Matchers[397] = new Mx.String(this, 397, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 398 SeqOp            */ __Matchers[398] = new Mx.Seq(this, 398, "_398:(>level-add-expression,'>=',>level-add-expression)") { Builder = nodes => new CGreaterEqualExpression(nodes) };
                /* 399 AltOp            */ __Matchers[399] = new Mx.Alt(this, 399, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 400 SeqOp            */ __Matchers[400] = new Mx.Seq(this, 400, "_400:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 401 StringOp         */ __Matchers[401] = new Mx.String(this, 401, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 402 SeqOp            */ __Matchers[402] = new Mx.Seq(this, 402, "_402:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 403 AltOp            */ __Matchers[403] = new Mx.Alt(this, 403, "alt(>mul-expression|>div-expression|>rem-expression|>level-union-expression)") { Builder = nodes => nodes[0] };
                /* 404 SeqOp            */ __Matchers[404] = new Mx.Seq(this, 404, "_404:(>level-mul-expression,'*',>level-union-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 405 StringOp         */ __Matchers[405] = new Mx.String(this, 405, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 406 SeqOp            */ __Matchers[406] = new Mx.Seq(this, 406, "_406:(>level-mul-expression,'/',>level-union-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 407 StringOp         */ __Matchers[407] = new Mx.String(this, 407, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 408 SeqOp            */ __Matchers[408] = new Mx.Seq(this, 408, "_408:(>level-mul-expression,'%',>level-union-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 409 AltOp            */ __Matchers[409] = new Mx.Alt(this, 409, "alt(>union-expression|>complement-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 410 SeqOp            */ __Matchers[410] = new Mx.Seq(this, 410, "_410:(>level-union-expression,'|',>primary-expression)") { Builder = nodes => new CUnionExpression(nodes) };
                /* 411 StringOp         */ __Matchers[411] = new Mx.String(this, 411, "'~'", "~") { Creator = node => new RLiteral(node) };
                /* 412 SeqOp            */ __Matchers[412] = new Mx.Seq(this, 412, "_412:(>level-union-expression,'~',>primary-expression)") { Builder = nodes => new CComplementExpression(nodes) };
                /* 413 AltOp            */ __Matchers[413] = new Mx.Alt(this, 413, "alt(>reference|>literal|>string-expression|>call-expression|>select-expression|>nullsafe-select-expression)") { Builder = nodes => nodes[0] };
                /* 414 SeqOp            */ __Matchers[414] = new Mx.Seq(this, 414, "_414:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 415 SeqOp            */ __Matchers[415] = new Mx.Seq(this, 415, "_415:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 416 StringOp         */ __Matchers[416] = new Mx.String(this, 416, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 417 SeqOp            */ __Matchers[417] = new Mx.Seq(this, 417, "_417:(>primary-expression,'?.',>reference)") { Builder = nodes => new CNullsafeSelectExpression(nodes) };
                /* 418 AltOp            */ __Matchers[418] = new Mx.Alt(this, 418, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 419 AltOp            */ __Matchers[419] = new Mx.Alt(this, 419, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 420 StarOp           */ __Matchers[420] = new Mx.Star(this, 420, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 421 SeqOp            */ __Matchers[421] = new Mx.Seq(this, 421, "_421:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 422 SeqOp            */ __Matchers[422] = new Mx.Seq(this, 422, "_422:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 423 SeqOp            */ __Matchers[423] = new Mx.Seq(this, 423, "_423:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 424 SeqOp            */ __Matchers[424] = new Mx.Seq(this, 424, "_424:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Mx.Seq(this, 425, "_425:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 426 AltOp            */ __Matchers[426] = new Mx.Alt(this, 426, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 427 SeqOp            */ __Matchers[427] = new Mx.Seq(this, 427, "_427:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 428 SeqOp            */ __Matchers[428] = new Mx.Seq(this, 428, "_428:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 429 StarOp           */ __Matchers[429] = new Mx.Star(this, 429, "*(_428:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 430 SeqOp            */ __Matchers[430] = new Mx.Seq(this, 430, "_430:(>condition,*(_428:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[168]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[169]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[172]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[175]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[177]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[181]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[183]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[184]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[186]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[188]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[192]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[193]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[196]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[198]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[199]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[203]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[205]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[209]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[212]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[214]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[217]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[220]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[221]);
                /*  29 PlainRuleOp      */ _valueDefault.Set(__Matchers[222]);
                /*  30 PlainRuleOp      */ _variance.Set(__Matchers[225]);
                /*  31 PlainRuleOp      */ _declarations.Set(__Matchers[226]);
                /*  32 PlainRuleOp      */ _declaration.Set(__Matchers[227]);
                /*  33 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[231]);
                /*  34 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[232]);
                /*  35 PlainRuleOp      */ _classDeclaration.Set(__Matchers[238]);
                /*  36 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[240]);
                /*  37 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[242]);
                /*  38 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[245]);
                /*  39 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[248]);
                /*  40 PlainRuleOp      */ _functionBody.Set(__Matchers[249]);
                /*  41 PlainRuleOp      */ _attributeBody.Set(__Matchers[249]);
                /*  42 PlainRuleOp      */ _blockBody.Set(__Matchers[250]);
                /*  43 PlainRuleOp      */ _statelarations.Set(__Matchers[251]);
                /*  44 PlainRuleOp      */ _statelaration.Set(__Matchers[252]);
                /*  45 PlainRuleOp      */ _expressionBody.Set(__Matchers[253]);
                /*  46 PlainRuleOp      */ _nullBody.Set(__Matchers[254]);
                /*  47 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[255]);
                /*  48 PlainRuleOp      */ _extends.Set(__Matchers[257]);
                /*  49 PlainRuleOp      */ _extendType.Set(__Matchers[258]);
                /*  50 PlainRuleOp      */ _constructor.Set(__Matchers[259]);
                /*  51 PlainRuleOp      */ _satisfies.Set(__Matchers[261]);
                /*  52 PlainRuleOp      */ _constraints.Set(__Matchers[262]);
                /*  53 PlainRuleOp      */ _constraint.Set(__Matchers[264]);
                /*  54 PlainRuleOp      */ _unionTypeList.Set(__Matchers[267]);
                /*  55 PlainRuleOp      */ _caseTypes.Set(__Matchers[269]);
                /*  56 PlainRuleOp      */ _caseTypeList.Set(__Matchers[273]);
                /*  57 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  58 PlainRuleOp      */ _namePattern.Set(__Matchers[274]);
                /*  59 PlainRuleOp      */ _prelude.Set(__Matchers[277]);
                /*  60 PlainRuleOp      */ _attribute.Set(__Matchers[279]);
                /*  61 DfaRuleOp        */ _attributeName.Set(_attributeName_DFA);
                /*  62 PlainRuleOp      */ _attributeArguments.Set(__Matchers[283]);
                /*  63 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[286]);
                /*  64 PlainRuleOp      */ _attributeArgument.Set(__Matchers[287]);
                /*  65 PlainRuleOp      */ _literalArgument.Set(__Matchers[288]);
                /*  66 PlainRuleOp      */ _metaArgument.Set(__Matchers[289]);
                /*  67 PlainRuleOp      */ _metaReference.Set(__Matchers[290]);
                /*  68 PlainRuleOp      */ _classReference.Set(__Matchers[291]);
                /*  69 PlainRuleOp      */ _objectReference.Set(__Matchers[292]);
                /*  70 PlainRuleOp      */ _valueReference.Set(__Matchers[294]);
                /*  71 PlainRuleOp      */ _interfaceReference.Set(__Matchers[295]);
                /*  72 PlainRuleOp      */ _functionReference.Set(__Matchers[297]);
                /*  73 PlainRuleOp      */ _type.Set(__Matchers[298]);
                /*  74 PlainRuleOp      */ _entryType.Set(__Matchers[300]);
                /*  75 PlainRuleOp      */ _variadicType.Set(__Matchers[301]);
                /*  76 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[303]);
                /*  77 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[305]);
                /*  78 PlainRuleOp      */ _unionType.Set(__Matchers[308]);
                /*  79 PlainRuleOp      */ _intersectionType.Set(__Matchers[312]);
                /*  80 PlainRuleOp      */ _primaryType.Set(__Matchers[313]);
                /*  81 PlainRuleOp      */ _nullableType.Set(__Matchers[315]);
                /*  82 PlainRuleOp      */ _sequenceType.Set(__Matchers[318]);
                /*  83 PlainRuleOp      */ _typeSelector.Set(__Matchers[319]);
                /*  84 PlainRuleOp      */ _callableType.Set(__Matchers[321]);
                /*  85 PlainRuleOp      */ _callableArguments.Set(__Matchers[322]);
                /*  86 PlainRuleOp      */ _typeList.Set(__Matchers[325]);
                /*  87 PlainRuleOp      */ _typeListType.Set(__Matchers[326]);
                /*  88 PlainRuleOp      */ _defaultedType.Set(__Matchers[327]);
                /*  89 PlainRuleOp      */ _spreadType.Set(__Matchers[328]);
                /*  90 PlainRuleOp      */ _emptyType.Set(__Matchers[329]);
                /*  91 PlainRuleOp      */ _tupleType.Set(__Matchers[330]);
                /*  92 PlainRuleOp      */ _iterableType.Set(__Matchers[331]);
                /*  93 PlainRuleOp      */ _iterableTypeZero.Set(__Matchers[332]);
                /*  94 PlainRuleOp      */ _iterableTypeOne.Set(__Matchers[333]);
                /*  95 PlainRuleOp      */ _nothingType.Set(__Matchers[335]);
                /*  96 PlainRuleOp      */ _multiParameters.Set(__Matchers[336]);
                /*  97 PlainRuleOp      */ _parameters.Set(__Matchers[338]);
                /*  98 PlainRuleOp      */ _parameterList.Set(__Matchers[341]);
                /*  99 PlainRuleOp      */ _parameter.Set(_valueParameter);
                /* 100 PlainRuleOp      */ _valueParameter.Set(__Matchers[344]);
                /* 101 PlainRuleOp      */ _parameterType.Set(__Matchers[345]);
                /* 102 PlainRuleOp      */ _arguments.Set(__Matchers[347]);
                /* 103 PlainRuleOp      */ _argumentList.Set(__Matchers[350]);
                /* 104 PlainRuleOp      */ _argument.Set(__Matchers[351]);
                /* 105 PlainRuleOp      */ _expressionArgument.Set(__Matchers[352]);
                /* 106 PlainRuleOp      */ _spreadArgument.Set(__Matchers[353]);
                /* 107 PlainRuleOp      */ _statement.Set(__Matchers[354]);
                /* 108 PlainRuleOp      */ _ifStatement.Set(__Matchers[358]);
                /* 109 PlainRuleOp      */ _elseIf.Set(__Matchers[360]);
                /* 110 PlainRuleOp      */ _elseBlock.Set(__Matchers[361]);
                /* 111 PlainRuleOp      */ _forStatement.Set(__Matchers[363]);
                /* 112 PlainRuleOp      */ _returnStatement.Set(__Matchers[366]);
                /* 113 PlainRuleOp      */ _assertStatement.Set(__Matchers[368]);
                /* 114 PlainRuleOp      */ _expression.Set(__Matchers[369]);
                /* 115 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[370]);
                /* 116 PlainRuleOp      */ _thenExpression.Set(__Matchers[372]);
                /* 117 PlainRuleOp      */ _elseExpression.Set(__Matchers[373]);
                /* 118 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[374]);
                /* 119 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[376]);
                /* 120 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[377]);
                /* 121 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[379]);
                /* 122 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[380]);
                /* 123 PlainRuleOp      */ _notExpression.Set(__Matchers[382]);
                /* 124 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[383]);
                /* 125 PlainRuleOp      */ _equalExpression.Set(__Matchers[385]);
                /* 126 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[387]);
                /* 127 PlainRuleOp      */ _identicalExpression.Set(__Matchers[389]);
                /* 128 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[391]);
                /* 129 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[392]);
                /* 130 PlainRuleOp      */ _lessExpression.Set(__Matchers[393]);
                /* 131 PlainRuleOp      */ _lessEqualExpression.Set(__Matchers[395]);
                /* 132 PlainRuleOp      */ _greaterExpression.Set(__Matchers[396]);
                /* 133 PlainRuleOp      */ _greaterEqualExpression.Set(__Matchers[398]);
                /* 134 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[399]);
                /* 135 PlainRuleOp      */ _addExpression.Set(__Matchers[400]);
                /* 136 PlainRuleOp      */ _subExpression.Set(__Matchers[402]);
                /* 137 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[403]);
                /* 138 PlainRuleOp      */ _mulExpression.Set(__Matchers[404]);
                /* 139 PlainRuleOp      */ _divExpression.Set(__Matchers[406]);
                /* 140 PlainRuleOp      */ _remExpression.Set(__Matchers[408]);
                /* 141 PlainRuleOp      */ _levelUnionExpression.Set(__Matchers[409]);
                /* 142 PlainRuleOp      */ _unionExpression.Set(__Matchers[410]);
                /* 143 PlainRuleOp      */ _complementExpression.Set(__Matchers[412]);
                /* 144 PlainRuleOp      */ _primaryExpression.Set(__Matchers[413]);
                /* 145 PlainRuleOp      */ _callExpression.Set(__Matchers[414]);
                /* 146 PlainRuleOp      */ _selectExpression.Set(__Matchers[415]);
                /* 147 PlainRuleOp      */ _nullsafeSelectExpression.Set(__Matchers[417]);
                /* 148 PlainRuleOp      */ _literal.Set(_naturalLiteral);
                /* 149 PlainRuleOp      */ _stringExpression.Set(__Matchers[418]);
                /* 150 PlainRuleOp      */ _stringLiteral.Set(__Matchers[419]);
                /* 151 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[421]);
                /* 152 PlainRuleOp      */ _interpolationPart.Set(__Matchers[422]);
                /* 153 PlainRuleOp      */ _ifExpression.Set(__Matchers[423]);
                /* 154 PlainRuleOp      */ _ifThen.Set(__Matchers[424]);
                /* 155 PlainRuleOp      */ _ifElse.Set(__Matchers[425]);
                /* 156 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[426]);
                /* 157 PlainRuleOp      */ _conditions.Set(__Matchers[427]);
                /* 158 PlainRuleOp      */ _conditionList.Set(__Matchers[430]);
                /* 159 PlainRuleOp      */ _condition.Set(_expression);
                /* 160 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 161 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 162 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 163 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 164 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 165 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 166 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 168 SeqOp            */ __Matchers[168].Set(_compilationUnit, __Matchers[167]);
                /* 169 AltOp            */ __Matchers[169].Set(_moduleDescriptor, _codeUnit);
                /* 171 OptionalOp       */ __Matchers[171].Set(__Matchers[170]);
                /* 172 SeqOp            */ __Matchers[172].Set(__Matchers[171], _namespace, _usings, _declarations);
                /* 175 SeqOp            */ __Matchers[175].Set(_prelude, __Matchers[173], _names, __Matchers[174]);
                /* 177 SeqOp            */ __Matchers[177].Set(__Matchers[176], _names, _moduleBody);
                /* 179 StarOp           */ __Matchers[179].Set(_moduleBodyElement);
                /* 181 SeqOp            */ __Matchers[181].Set(__Matchers[178], __Matchers[179], __Matchers[180]);
                /* 183 SeqOp            */ __Matchers[183].Set(__Matchers[182], _names, __Matchers[174]);
                /* 184 StarOp           */ __Matchers[184].Set(_usingDeclaration);
                /* 186 SeqOp            */ __Matchers[186].Set(__Matchers[185], _names, _usingElements);
                /* 187 OptionalOp       */ __Matchers[187].Set(_usingElementList);
                /* 188 SeqOp            */ __Matchers[188].Set(__Matchers[178], __Matchers[187], __Matchers[180]);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[189], _usingElement);
                /* 191 StarOp           */ __Matchers[191].Set(__Matchers[190]);
                /* 192 SeqOp            */ __Matchers[192].Set(_usingElement, __Matchers[191]);
                /* 193 AltOp            */ __Matchers[193].Set(_usingNamed, _usingWildcard);
                /* 194 OptionalOp       */ __Matchers[194].Set(_usingNameSpecifier);
                /* 195 OptionalOp       */ __Matchers[195].Set(_usingElements);
                /* 196 SeqOp            */ __Matchers[196].Set(_usingName, __Matchers[194], __Matchers[195]);
                /* 198 SeqOp            */ __Matchers[198].Set(__Matchers[197], _identifier);
                /* 201 SeqOp            */ __Matchers[201].Set(__Matchers[200], _name);
                /* 202 StarOp           */ __Matchers[202].Set(__Matchers[201]);
                /* 203 SeqOp            */ __Matchers[203].Set(_name, __Matchers[202]);
                /* 204 OptionalOp       */ __Matchers[204].Set(_genericArguments);
                /* 205 SeqOp            */ __Matchers[205].Set(_name, __Matchers[204]);
                /* 207 OptionalOp       */ __Matchers[207].Set(_genericArgumentList);
                /* 209 SeqOp            */ __Matchers[209].Set(__Matchers[206], __Matchers[207], __Matchers[208]);
                /* 210 SeqOp            */ __Matchers[210].Set(__Matchers[189], _genericArgument);
                /* 211 StarOp           */ __Matchers[211].Set(__Matchers[210]);
                /* 212 SeqOp            */ __Matchers[212].Set(_genericArgument, __Matchers[211]);
                /* 213 OptionalOp       */ __Matchers[213].Set(_genericParameterList);
                /* 214 SeqOp            */ __Matchers[214].Set(__Matchers[206], __Matchers[213], __Matchers[208]);
                /* 215 SeqOp            */ __Matchers[215].Set(__Matchers[189], _genericParameter);
                /* 216 StarOp           */ __Matchers[216].Set(__Matchers[215]);
                /* 217 SeqOp            */ __Matchers[217].Set(_genericParameter, __Matchers[216]);
                /* 218 OptionalOp       */ __Matchers[218].Set(_variance);
                /* 219 OptionalOp       */ __Matchers[219].Set(_typeDefault);
                /* 220 SeqOp            */ __Matchers[220].Set(__Matchers[218], _name, __Matchers[219]);
                /* 221 SeqOp            */ __Matchers[221].Set(__Matchers[197], _type);
                /* 222 SeqOp            */ __Matchers[222].Set(__Matchers[197], _expression);
                /* 225 AltOp            */ __Matchers[225].Set(__Matchers[223], __Matchers[224]);
                /* 226 StarOp           */ __Matchers[226].Set(_declaration);
                /* 227 AltOp            */ __Matchers[227].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 228 OptionalOp       */ __Matchers[228].Set(_type);
                /* 229 OptionalOp       */ __Matchers[229].Set(_genericParameters);
                /* 230 OptionalOp       */ __Matchers[230].Set(_constraints);
                /* 231 SeqOp            */ __Matchers[231].Set(_prelude, __Matchers[228], _name, __Matchers[229], _multiParameters, __Matchers[230], _functionBody);
                /* 232 SeqOp            */ __Matchers[232].Set(_prelude, __Matchers[228], _name, _attributeBody);
                /* 234 OptionalOp       */ __Matchers[234].Set(_parameters);
                /* 235 OptionalOp       */ __Matchers[235].Set(_extends);
                /* 236 OptionalOp       */ __Matchers[236].Set(_satisfies);
                /* 237 OptionalOp       */ __Matchers[237].Set(_caseTypes);
                /* 238 SeqOp            */ __Matchers[238].Set(_prelude, __Matchers[233], _name, __Matchers[229], __Matchers[234], __Matchers[235], __Matchers[236], __Matchers[237], __Matchers[230], _blockBody);
                /* 240 SeqOp            */ __Matchers[240].Set(_prelude, __Matchers[239], _name, __Matchers[229], __Matchers[234], __Matchers[236], __Matchers[237], __Matchers[230], _blockBody);
                /* 242 SeqOp            */ __Matchers[242].Set(_prelude, __Matchers[241], _name, __Matchers[235], __Matchers[236], _blockBody);
                /* 245 SeqOp            */ __Matchers[245].Set(_prelude, __Matchers[243], _name, __Matchers[229], __Matchers[230], __Matchers[244], _type, __Matchers[174]);
                /* 247 OptionalOp       */ __Matchers[247].Set(_name);
                /* 248 SeqOp            */ __Matchers[248].Set(_prelude, __Matchers[246], __Matchers[247], __Matchers[235], _functionBody);
                /* 249 AltOp            */ __Matchers[249].Set(_expressionBody, _blockBody, _nullBody);
                /* 250 SeqOp            */ __Matchers[250].Set(__Matchers[178], _usings, _statelarations, __Matchers[180]);
                /* 251 StarOp           */ __Matchers[251].Set(_statelaration);
                /* 252 AltOp            */ __Matchers[252].Set(_statement, _declaration);
                /* 253 SeqOp            */ __Matchers[253].Set(_functionSpecifier, __Matchers[174]);
                /* 254 SeqOp            */ __Matchers[254].Set(__Matchers[174]);
                /* 255 SeqOp            */ __Matchers[255].Set(__Matchers[244], _expression);
                /* 257 SeqOp            */ __Matchers[257].Set(__Matchers[256], _extendType);
                /* 258 AltOp            */ __Matchers[258].Set(_type, _constructor);
                /* 259 SeqOp            */ __Matchers[259].Set(_primaryType, _arguments);
                /* 261 SeqOp            */ __Matchers[261].Set(__Matchers[260], _unionTypeList);
                /* 262 PlusOp           */ __Matchers[262].Set(_constraint);
                /* 264 SeqOp            */ __Matchers[264].Set(__Matchers[263], _name, __Matchers[229], __Matchers[237], __Matchers[236]);
                /* 265 SeqOp            */ __Matchers[265].Set(__Matchers[189], _type);
                /* 266 StarOp           */ __Matchers[266].Set(__Matchers[265]);
                /* 267 SeqOp            */ __Matchers[267].Set(_type, __Matchers[266]);
                /* 269 SeqOp            */ __Matchers[269].Set(__Matchers[268], _caseTypeList);
                /* 271 SeqOp            */ __Matchers[271].Set(__Matchers[270], _type);
                /* 272 StarOp           */ __Matchers[272].Set(__Matchers[271]);
                /* 273 SeqOp            */ __Matchers[273].Set(_type, __Matchers[272]);
                /* 274 SeqOp            */ __Matchers[274].Set(_name);
                /* 275 OptionalOp       */ __Matchers[275].Set(_stringLiteral);
                /* 276 StarOp           */ __Matchers[276].Set(_attribute);
                /* 277 SeqOp            */ __Matchers[277].Set(__Matchers[275], __Matchers[276]);
                /* 278 OptionalOp       */ __Matchers[278].Set(_attributeArguments);
                /* 279 SeqOp            */ __Matchers[279].Set(_attributeName, __Matchers[278]);
                /* 281 OptionalOp       */ __Matchers[281].Set(_attributeArgumentList);
                /* 283 SeqOp            */ __Matchers[283].Set(__Matchers[280], __Matchers[281], __Matchers[282]);
                /* 284 SeqOp            */ __Matchers[284].Set(__Matchers[189], _attributeArgument);
                /* 285 StarOp           */ __Matchers[285].Set(__Matchers[284]);
                /* 286 SeqOp            */ __Matchers[286].Set(_attributeArgument, __Matchers[285]);
                /* 287 AltOp            */ __Matchers[287].Set(_literalArgument, _metaArgument);
                /* 288 SeqOp            */ __Matchers[288].Set(_stringLiteral);
                /* 289 SeqOp            */ __Matchers[289].Set(_metaReference);
                /* 290 AltOp            */ __Matchers[290].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 291 SeqOp            */ __Matchers[291].Set(__Matchers[233], _names);
                /* 292 SeqOp            */ __Matchers[292].Set(__Matchers[241], _names);
                /* 294 SeqOp            */ __Matchers[294].Set(__Matchers[293], _names);
                /* 295 SeqOp            */ __Matchers[295].Set(__Matchers[239], _names);
                /* 297 SeqOp            */ __Matchers[297].Set(__Matchers[296], _names);
                /* 298 AltOp            */ __Matchers[298].Set(_entryType, _unionType);
                /* 300 SeqOp            */ __Matchers[300].Set(_unionType, __Matchers[299], _unionType);
                /* 301 AltOp            */ __Matchers[301].Set(_variadicTypeZero, _variadicTypeOne);
                /* 303 SeqOp            */ __Matchers[303].Set(_unionType, __Matchers[302]);
                /* 305 SeqOp            */ __Matchers[305].Set(_unionType, __Matchers[304]);
                /* 306 SeqOp            */ __Matchers[306].Set(__Matchers[270], _intersectionType);
                /* 307 StarOp           */ __Matchers[307].Set(__Matchers[306]);
                /* 308 SeqOp            */ __Matchers[308].Set(_intersectionType, __Matchers[307]);
                /* 310 SeqOp            */ __Matchers[310].Set(__Matchers[309], _primaryType);
                /* 311 StarOp           */ __Matchers[311].Set(__Matchers[310]);
                /* 312 SeqOp            */ __Matchers[312].Set(_primaryType, __Matchers[311]);
                /* 313 AltOp            */ __Matchers[313].Set(_nullableType, _sequenceType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _iterableType, _nothingType);
                /* 315 SeqOp            */ __Matchers[315].Set(_primaryType, __Matchers[314]);
                /* 318 SeqOp            */ __Matchers[318].Set(_primaryType, __Matchers[316], __Matchers[317]);
                /* 319 SeqOp            */ __Matchers[319].Set(_primaryType, __Matchers[200], _reference);
                /* 320 OptionalOp       */ __Matchers[320].Set(_callableArguments);
                /* 321 SeqOp            */ __Matchers[321].Set(_primaryType, __Matchers[280], __Matchers[320], __Matchers[282]);
                /* 322 AltOp            */ __Matchers[322].Set(_typeList, _spreadType);
                /* 323 SeqOp            */ __Matchers[323].Set(__Matchers[189], _typeListType);
                /* 324 StarOp           */ __Matchers[324].Set(__Matchers[323]);
                /* 325 SeqOp            */ __Matchers[325].Set(_typeListType, __Matchers[324]);
                /* 326 AltOp            */ __Matchers[326].Set(_type, _defaultedType, _variadicType);
                /* 327 SeqOp            */ __Matchers[327].Set(_type, __Matchers[197]);
                /* 328 SeqOp            */ __Matchers[328].Set(__Matchers[302], _unionType);
                /* 329 SeqOp            */ __Matchers[329].Set(__Matchers[316], __Matchers[317]);
                /* 330 SeqOp            */ __Matchers[330].Set(__Matchers[316], _typeList, __Matchers[317]);
                /* 331 AltOp            */ __Matchers[331].Set(_iterableTypeZero, _iterableTypeOne);
                /* 332 SeqOp            */ __Matchers[332].Set(__Matchers[178], _unionType, __Matchers[302], __Matchers[180]);
                /* 333 SeqOp            */ __Matchers[333].Set(__Matchers[178], _unionType, __Matchers[304], __Matchers[180]);
                /* 335 SeqOp            */ __Matchers[335].Set(__Matchers[334]);
                /* 336 PlusOp           */ __Matchers[336].Set(_parameters);
                /* 337 OptionalOp       */ __Matchers[337].Set(_parameterList);
                /* 338 SeqOp            */ __Matchers[338].Set(__Matchers[280], __Matchers[337], __Matchers[282]);
                /* 339 SeqOp            */ __Matchers[339].Set(__Matchers[189], _parameter);
                /* 340 StarOp           */ __Matchers[340].Set(__Matchers[339]);
                /* 341 SeqOp            */ __Matchers[341].Set(_parameter, __Matchers[340]);
                /* 342 OptionalOp       */ __Matchers[342].Set(_parameterType);
                /* 343 OptionalOp       */ __Matchers[343].Set(_valueDefault);
                /* 344 SeqOp            */ __Matchers[344].Set(_prelude, __Matchers[342], _name, __Matchers[343]);
                /* 345 AltOp            */ __Matchers[345].Set(_type, _variadicType);
                /* 346 OptionalOp       */ __Matchers[346].Set(_argumentList);
                /* 347 SeqOp            */ __Matchers[347].Set(__Matchers[280], __Matchers[346], __Matchers[282]);
                /* 348 SeqOp            */ __Matchers[348].Set(__Matchers[189], _argument);
                /* 349 StarOp           */ __Matchers[349].Set(__Matchers[348]);
                /* 350 SeqOp            */ __Matchers[350].Set(_argument, __Matchers[349]);
                /* 351 AltOp            */ __Matchers[351].Set(_expressionArgument, _spreadArgument);
                /* 352 SeqOp            */ __Matchers[352].Set(_expression);
                /* 353 SeqOp            */ __Matchers[353].Set(__Matchers[302], _levelUnionExpression);
                /* 354 AltOp            */ __Matchers[354].Set(_ifStatement, _forStatement, _returnStatement, _assertStatement);
                /* 356 StarOp           */ __Matchers[356].Set(_elseIf);
                /* 357 OptionalOp       */ __Matchers[357].Set(_elseBlock);
                /* 358 SeqOp            */ __Matchers[358].Set(__Matchers[355], _conditions, _blockBody, __Matchers[356], __Matchers[357]);
                /* 360 SeqOp            */ __Matchers[360].Set(__Matchers[359], __Matchers[355], _conditions, _blockBody);
                /* 361 SeqOp            */ __Matchers[361].Set(__Matchers[359], _blockBody);
                /* 363 SeqOp            */ __Matchers[363].Set(__Matchers[362], __Matchers[280], _pattern, __Matchers[223], _expression, __Matchers[282], _blockBody, __Matchers[357]);
                /* 365 OptionalOp       */ __Matchers[365].Set(_expression);
                /* 366 SeqOp            */ __Matchers[366].Set(__Matchers[364], __Matchers[365], __Matchers[174]);
                /* 368 SeqOp            */ __Matchers[368].Set(__Matchers[275], __Matchers[367], _arguments, __Matchers[174]);
                /* 369 AltOp            */ __Matchers[369].Set(_levelCoalesceExpression, _ifExpression);
                /* 370 AltOp            */ __Matchers[370].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 372 SeqOp            */ __Matchers[372].Set(_levelCoalesceExpression, __Matchers[371], _levelDisjunctionExpression);
                /* 373 SeqOp            */ __Matchers[373].Set(_levelCoalesceExpression, __Matchers[359], _levelDisjunctionExpression);
                /* 374 AltOp            */ __Matchers[374].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 376 SeqOp            */ __Matchers[376].Set(_levelDisjunctionExpression, __Matchers[375], _levelConjunctionExpression);
                /* 377 AltOp            */ __Matchers[377].Set(_conjunctionExpression, _levelNotExpression);
                /* 379 SeqOp            */ __Matchers[379].Set(_levelConjunctionExpression, __Matchers[378], _levelNotExpression);
                /* 380 AltOp            */ __Matchers[380].Set(_notExpression, _levelEqualityExpression);
                /* 382 SeqOp            */ __Matchers[382].Set(__Matchers[381], _levelNotExpression);
                /* 383 AltOp            */ __Matchers[383].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 385 SeqOp            */ __Matchers[385].Set(_levelCompareExpression, __Matchers[384], _levelCompareExpression);
                /* 387 SeqOp            */ __Matchers[387].Set(_levelCompareExpression, __Matchers[386], _levelCompareExpression);
                /* 389 SeqOp            */ __Matchers[389].Set(_levelCompareExpression, __Matchers[388], _levelCompareExpression);
                /* 391 SeqOp            */ __Matchers[391].Set(_levelCompareExpression, __Matchers[390], _levelCompareExpression);
                /* 392 AltOp            */ __Matchers[392].Set(_lessExpression, _lessEqualExpression, _greaterExpression, _greaterEqualExpression, _levelAddExpression);
                /* 393 SeqOp            */ __Matchers[393].Set(_levelAddExpression, __Matchers[206], _levelAddExpression);
                /* 395 SeqOp            */ __Matchers[395].Set(_levelAddExpression, __Matchers[394], _levelAddExpression);
                /* 396 SeqOp            */ __Matchers[396].Set(_levelAddExpression, __Matchers[208], _levelAddExpression);
                /* 398 SeqOp            */ __Matchers[398].Set(_levelAddExpression, __Matchers[397], _levelAddExpression);
                /* 399 AltOp            */ __Matchers[399].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 400 SeqOp            */ __Matchers[400].Set(_levelAddExpression, __Matchers[304], _levelMulExpression);
                /* 402 SeqOp            */ __Matchers[402].Set(_levelAddExpression, __Matchers[401], _levelMulExpression);
                /* 403 AltOp            */ __Matchers[403].Set(_mulExpression, _divExpression, _remExpression, _levelUnionExpression);
                /* 404 SeqOp            */ __Matchers[404].Set(_levelMulExpression, __Matchers[302], _levelUnionExpression);
                /* 406 SeqOp            */ __Matchers[406].Set(_levelMulExpression, __Matchers[405], _levelUnionExpression);
                /* 408 SeqOp            */ __Matchers[408].Set(_levelMulExpression, __Matchers[407], _levelUnionExpression);
                /* 409 AltOp            */ __Matchers[409].Set(_unionExpression, _complementExpression, _primaryExpression);
                /* 410 SeqOp            */ __Matchers[410].Set(_levelUnionExpression, __Matchers[270], _primaryExpression);
                /* 412 SeqOp            */ __Matchers[412].Set(_levelUnionExpression, __Matchers[411], _primaryExpression);
                /* 413 AltOp            */ __Matchers[413].Set(_reference, _literal, _stringExpression, _callExpression, _selectExpression, _nullsafeSelectExpression);
                /* 414 SeqOp            */ __Matchers[414].Set(_primaryExpression, _arguments);
                /* 415 SeqOp            */ __Matchers[415].Set(_primaryExpression, __Matchers[200], _reference);
                /* 417 SeqOp            */ __Matchers[417].Set(_primaryExpression, __Matchers[416], _reference);
                /* 418 AltOp            */ __Matchers[418].Set(_stringLiteral, _stringInterpolation);
                /* 419 AltOp            */ __Matchers[419].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 420 StarOp           */ __Matchers[420].Set(_interpolationPart);
                /* 421 SeqOp            */ __Matchers[421].Set(_stringStart, _expression, __Matchers[420], _stringEnd);
                /* 422 SeqOp            */ __Matchers[422].Set(_stringMid, _expression);
                /* 423 SeqOp            */ __Matchers[423].Set(__Matchers[355], _conditions, _ifThen, _ifElse);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[371], _conditionalExpression);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[359], _conditionalExpression);
                /* 426 AltOp            */ __Matchers[426].Set(_ifExpression, _levelDisjunctionExpression);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[280], _conditionList, __Matchers[282]);
                /* 428 SeqOp            */ __Matchers[428].Set(__Matchers[189], _condition);
                /* 429 StarOp           */ __Matchers[429].Set(__Matchers[428]);
                /* 430 SeqOp            */ __Matchers[430].Set(_condition, __Matchers[429]);

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
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(160, 65535))
                );
                _attributeName_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true),
                    new DfaState(7, false),
                    new DfaState(8, false),
                    new DfaState(9, false),
                    new DfaState(10, false),
                    new DfaState(11, false),
                    new DfaState(12, false),
                    new DfaState(13, false),
                    new DfaState(14, false),
                    new DfaState(15, false),
                    new DfaState(16, false),
                    new DfaState(17, false),
                    new DfaState(18, false),
                    new DfaState(19, false),
                    new DfaState(20, false),
                    new DfaState(21, false),
                    new DfaState(22, false),
                    new DfaState(23, false),
                    new DfaState(24, false),
                    new DfaState(25, false),
                    new DfaState(26, false),
                    new DfaState(27, false),
                    new DfaState(28, false),
                    new DfaState(29, false),
                    new DfaState(30, false),
                    new DfaState(31, false),
                    new DfaState(32, false),
                    new DfaState(33, false),
                    new DfaState(34, false),
                    new DfaState(35, false),
                    new DfaState(36, false),
                    new DfaState(37, false),
                    new DfaState(38, false),
                    new DfaState(39, false),
                    new DfaState(40, false),
                    new DfaState(41, false),
                    new DfaState(42, false),
                    new DfaState(43, false),
                    new DfaState(44, false),
                    new DfaState(45, false),
                    new DfaState(46, false),
                    new DfaState(47, false),
                    new DfaState(48, false),
                    new DfaState(49, false),
                    new DfaState(50, false),
                    new DfaState(51, false),
                    new DfaState(52, false)
                );
                _attributeName_DFA.States[0].Set(
                    new DfaTrans(_attributeName_DFA.States[1], new DfaInterval(116, 116)),
                    new DfaTrans(_attributeName_DFA.States[11], new DfaInterval(115, 115)),
                    new DfaTrans(_attributeName_DFA.States[29], new DfaInterval(110, 110)),
                    new DfaTrans(_attributeName_DFA.States[33], new DfaInterval(97, 97)),
                    new DfaTrans(_attributeName_DFA.States[44], new DfaInterval(102, 102)),
                    new DfaTrans(_attributeName_DFA.States[48], new DfaInterval(100, 100))
                );
                _attributeName_DFA.States[1].Set(
                    new DfaTrans(_attributeName_DFA.States[2], new DfaInterval(97, 97)),
                    new DfaTrans(_attributeName_DFA.States[7], new DfaInterval(104, 104))
                );
                _attributeName_DFA.States[2].Set(
                    new DfaTrans(_attributeName_DFA.States[3], new DfaInterval(103, 103))
                );
                _attributeName_DFA.States[3].Set(
                    new DfaTrans(_attributeName_DFA.States[4], new DfaInterval(103, 103))
                );
                _attributeName_DFA.States[4].Set(
                    new DfaTrans(_attributeName_DFA.States[5], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[5].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(100, 100))
                );
                _attributeName_DFA.States[6].Set(
                );
                _attributeName_DFA.States[7].Set(
                    new DfaTrans(_attributeName_DFA.States[8], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[8].Set(
                    new DfaTrans(_attributeName_DFA.States[9], new DfaInterval(111, 111))
                );
                _attributeName_DFA.States[9].Set(
                    new DfaTrans(_attributeName_DFA.States[10], new DfaInterval(119, 119))
                );
                _attributeName_DFA.States[10].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(115, 115))
                );
                _attributeName_DFA.States[11].Set(
                    new DfaTrans(_attributeName_DFA.States[12], new DfaInterval(101, 101)),
                    new DfaTrans(_attributeName_DFA.States[23], new DfaInterval(104, 104)),
                    new DfaTrans(_attributeName_DFA.States[25], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[12].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(101, 101)),
                    new DfaTrans(_attributeName_DFA.States[13], new DfaInterval(97, 97)),
                    new DfaTrans(_attributeName_DFA.States[14], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[13].Set(
                    new DfaTrans(_attributeName_DFA.States[4], new DfaInterval(108, 108))
                );
                _attributeName_DFA.States[14].Set(
                    new DfaTrans(_attributeName_DFA.States[15], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[15].Set(
                    new DfaTrans(_attributeName_DFA.States[16], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[16].Set(
                    new DfaTrans(_attributeName_DFA.States[17], new DfaInterval(108, 108))
                );
                _attributeName_DFA.States[17].Set(
                    new DfaTrans(_attributeName_DFA.States[18], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[18].Set(
                    new DfaTrans(_attributeName_DFA.States[19], new DfaInterval(122, 122))
                );
                _attributeName_DFA.States[19].Set(
                    new DfaTrans(_attributeName_DFA.States[20], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[20].Set(
                    new DfaTrans(_attributeName_DFA.States[21], new DfaInterval(98, 98))
                );
                _attributeName_DFA.States[21].Set(
                    new DfaTrans(_attributeName_DFA.States[22], new DfaInterval(108, 108))
                );
                _attributeName_DFA.States[22].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[23].Set(
                    new DfaTrans(_attributeName_DFA.States[24], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[24].Set(
                    new DfaTrans(_attributeName_DFA.States[4], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[25].Set(
                    new DfaTrans(_attributeName_DFA.States[26], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[26].Set(
                    new DfaTrans(_attributeName_DFA.States[27], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[27].Set(
                    new DfaTrans(_attributeName_DFA.States[28], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[28].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(99, 99))
                );
                _attributeName_DFA.States[29].Set(
                    new DfaTrans(_attributeName_DFA.States[30], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[30].Set(
                    new DfaTrans(_attributeName_DFA.States[31], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[31].Set(
                    new DfaTrans(_attributeName_DFA.States[32], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[32].Set(
                    new DfaTrans(_attributeName_DFA.States[22], new DfaInterval(118, 118))
                );
                _attributeName_DFA.States[33].Set(
                    new DfaTrans(_attributeName_DFA.States[34], new DfaInterval(98, 98)),
                    new DfaTrans(_attributeName_DFA.States[40], new DfaInterval(99, 99))
                );
                _attributeName_DFA.States[34].Set(
                    new DfaTrans(_attributeName_DFA.States[35], new DfaInterval(115, 115))
                );
                _attributeName_DFA.States[35].Set(
                    new DfaTrans(_attributeName_DFA.States[36], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[36].Set(
                    new DfaTrans(_attributeName_DFA.States[37], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[37].Set(
                    new DfaTrans(_attributeName_DFA.States[38], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[38].Set(
                    new DfaTrans(_attributeName_DFA.States[39], new DfaInterval(99, 99))
                );
                _attributeName_DFA.States[39].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[40].Set(
                    new DfaTrans(_attributeName_DFA.States[41], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[41].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(117, 117))
                );
                _attributeName_DFA.States[42].Set(
                    new DfaTrans(_attributeName_DFA.States[43], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[43].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(108, 108))
                );
                _attributeName_DFA.States[44].Set(
                    new DfaTrans(_attributeName_DFA.States[45], new DfaInterval(111, 111)),
                    new DfaTrans(_attributeName_DFA.States[47], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[45].Set(
                    new DfaTrans(_attributeName_DFA.States[46], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[46].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(109, 109))
                );
                _attributeName_DFA.States[47].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(110, 110))
                );
                _attributeName_DFA.States[48].Set(
                    new DfaTrans(_attributeName_DFA.States[49], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[49].Set(
                    new DfaTrans(_attributeName_DFA.States[50], new DfaInterval(102, 102))
                );
                _attributeName_DFA.States[50].Set(
                    new DfaTrans(_attributeName_DFA.States[51], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[51].Set(
                    new DfaTrans(_attributeName_DFA.States[52], new DfaInterval(117, 117))
                );
                _attributeName_DFA.States[52].Set(
                    new DfaTrans(_attributeName_DFA.States[39], new DfaInterval(108, 108))
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
                _stringStart_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true),
                    new DfaState(7, true),
                    new DfaState(8, false),
                    new DfaState(9, false)
                );
                _stringStart_DFA.States[0].Set(
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(34, 34))
                );
                _stringStart_DFA.States[1].Set(
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[2], new DfaInterval(96, 96)),
                    new DfaTrans(_stringStart_DFA.States[8], new DfaInterval(92, 92))
                );
                _stringStart_DFA.States[2].Set(
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[3], new DfaInterval(92, 92)),
                    new DfaTrans(_stringStart_DFA.States[7], new DfaInterval(96, 96))
                );
                _stringStart_DFA.States[3].Set(
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[4], new DfaInterval(123, 123))
                );
                _stringStart_DFA.States[4].Set(
                    new DfaTrans(_stringStart_DFA.States[4], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_stringStart_DFA.States[5], new DfaInterval(96, 96))
                );
                _stringStart_DFA.States[5].Set(
                    new DfaTrans(_stringStart_DFA.States[4], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_stringStart_DFA.States[6], new DfaInterval(96, 96))
                );
                _stringStart_DFA.States[6].Set(
                    new DfaTrans(_stringStart_DFA.States[4], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_stringStart_DFA.States[6], new DfaInterval(96, 96))
                );
                _stringStart_DFA.States[7].Set(
                );
                _stringStart_DFA.States[8].Set(
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[9], new DfaInterval(123, 123))
                );
                _stringStart_DFA.States[9].Set(
                    new DfaTrans(_stringStart_DFA.States[9], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringStart_DFA.States[1], new DfaInterval(125, 125))
                );
                _stringMid_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, false),
                    new DfaState(7, true),
                    new DfaState(8, true),
                    new DfaState(9, false),
                    new DfaState(10, false)
                );
                _stringMid_DFA.States[0].Set(
                    new DfaTrans(_stringMid_DFA.States[1], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[1].Set(
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[2].Set(
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[3], new DfaInterval(96, 96)),
                    new DfaTrans(_stringMid_DFA.States[9], new DfaInterval(92, 92))
                );
                _stringMid_DFA.States[3].Set(
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[4], new DfaInterval(92, 92)),
                    new DfaTrans(_stringMid_DFA.States[8], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[4].Set(
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[5], new DfaInterval(123, 123))
                );
                _stringMid_DFA.States[5].Set(
                    new DfaTrans(_stringMid_DFA.States[5], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(125, 125)),
                    new DfaTrans(_stringMid_DFA.States[6], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[6].Set(
                    new DfaTrans(_stringMid_DFA.States[5], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(125, 125)),
                    new DfaTrans(_stringMid_DFA.States[7], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[7].Set(
                    new DfaTrans(_stringMid_DFA.States[5], new DfaInterval(0, 95), new DfaInterval(97, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(125, 125)),
                    new DfaTrans(_stringMid_DFA.States[7], new DfaInterval(96, 96))
                );
                _stringMid_DFA.States[8].Set(
                );
                _stringMid_DFA.States[9].Set(
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[10], new DfaInterval(123, 123))
                );
                _stringMid_DFA.States[10].Set(
                    new DfaTrans(_stringMid_DFA.States[10], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringMid_DFA.States[2], new DfaInterval(125, 125))
                );
                _stringEnd_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true),
                    new DfaState(7, false),
                    new DfaState(8, true),
                    new DfaState(9, false),
                    new DfaState(10, false)
                );
                _stringEnd_DFA.States[0].Set(
                    new DfaTrans(_stringEnd_DFA.States[1], new DfaInterval(96, 96))
                );
                _stringEnd_DFA.States[1].Set(
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(96, 96))
                );
                _stringEnd_DFA.States[2].Set(
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[3], new DfaInterval(96, 96)),
                    new DfaTrans(_stringEnd_DFA.States[9], new DfaInterval(92, 92)),
                    new DfaTrans(_stringEnd_DFA.States[8], new DfaInterval(34, 34))
                );
                _stringEnd_DFA.States[3].Set(
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[4], new DfaInterval(92, 92)),
                    new DfaTrans(_stringEnd_DFA.States[7], new DfaInterval(96, 96)),
                    new DfaTrans(_stringEnd_DFA.States[8], new DfaInterval(34, 34))
                );
                _stringEnd_DFA.States[4].Set(
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[5], new DfaInterval(123, 123))
                );
                _stringEnd_DFA.States[5].Set(
                    new DfaTrans(_stringEnd_DFA.States[5], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(125, 125)),
                    new DfaTrans(_stringEnd_DFA.States[6], new DfaInterval(34, 34))
                );
                _stringEnd_DFA.States[6].Set(
                    new DfaTrans(_stringEnd_DFA.States[5], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(125, 125)),
                    new DfaTrans(_stringEnd_DFA.States[6], new DfaInterval(34, 34))
                );
                _stringEnd_DFA.States[7].Set(
                    new DfaTrans(_stringEnd_DFA.States[7], new DfaInterval(96, 96)),
                    new DfaTrans(_stringEnd_DFA.States[8], new DfaInterval(34, 34))
                );
                _stringEnd_DFA.States[8].Set(
                );
                _stringEnd_DFA.States[9].Set(
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[10], new DfaInterval(123, 123))
                );
                _stringEnd_DFA.States[10].Set(
                    new DfaTrans(_stringEnd_DFA.States[10], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_stringEnd_DFA.States[2], new DfaInterval(125, 125))
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
                    new DfaState(6, true),
                    new DfaState(7, true),
                    new DfaState(8, false),
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
                    new DfaState(34, false),
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
                    new DfaState(58, true),
                    new DfaState(59, true),
                    new DfaState(60, true),
                    new DfaState(61, true),
                    new DfaState(62, true),
                    new DfaState(63, true),
                    new DfaState(64, true),
                    new DfaState(65, true),
                    new DfaState(66, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 77), new DfaInterval(79, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 100), new DfaInterval(103, 104), new DfaInterval(106, 108), new DfaInterval(112, 113), new DfaInterval(115, 115), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(78, 78)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(116, 116)),
                    new DfaTrans(_identifier_DFA.States[60], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[64], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(160, 65535))
                );
                _identifier_DFA.States[2].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[3], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[3].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[4], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[4].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[5].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[6].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[7], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[7].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(103, 103))
                );
                _identifier_DFA.States[8].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(160, 65535))
                );
                _identifier_DFA.States[9].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[13], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[10].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[11], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[11].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[12].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[13].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[14], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[14].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[15].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[16].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[17].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 108), new DfaInterval(111, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102), new DfaInterval(115, 115)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[54].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[55], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[55].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[56], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[56].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[57], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[57].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[59], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[59].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[60].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[64].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[65], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[65].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[66], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[66].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(114, 114))
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
            private readonly Mx.PlainRule _valueDefault;
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
            private readonly Mx.PlainRule _extendType;
            private readonly Mx.PlainRule _constructor;
            private readonly Mx.PlainRule _satisfies;
            private readonly Mx.PlainRule _constraints;
            private readonly Mx.PlainRule _constraint;
            private readonly Mx.PlainRule _unionTypeList;
            private readonly Mx.PlainRule _caseTypes;
            private readonly Mx.PlainRule _caseTypeList;
            private readonly Mx.PlainRule _pattern;
            private readonly Mx.PlainRule _namePattern;
            private readonly Mx.PlainRule _prelude;
            private readonly Mx.PlainRule _attribute;
            private readonly Mx.DfaRule _attributeName;
            private readonly Mx.PlainRule _attributeArguments;
            private readonly Mx.PlainRule _attributeArgumentList;
            private readonly Mx.PlainRule _attributeArgument;
            private readonly Mx.PlainRule _literalArgument;
            private readonly Mx.PlainRule _metaArgument;
            private readonly Mx.PlainRule _metaReference;
            private readonly Mx.PlainRule _classReference;
            private readonly Mx.PlainRule _objectReference;
            private readonly Mx.PlainRule _valueReference;
            private readonly Mx.PlainRule _interfaceReference;
            private readonly Mx.PlainRule _functionReference;
            private readonly Mx.PlainRule _type;
            private readonly Mx.PlainRule _entryType;
            private readonly Mx.PlainRule _variadicType;
            private readonly Mx.PlainRule _variadicTypeZero;
            private readonly Mx.PlainRule _variadicTypeOne;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _nullableType;
            private readonly Mx.PlainRule _sequenceType;
            private readonly Mx.PlainRule _typeSelector;
            private readonly Mx.PlainRule _callableType;
            private readonly Mx.PlainRule _callableArguments;
            private readonly Mx.PlainRule _typeList;
            private readonly Mx.PlainRule _typeListType;
            private readonly Mx.PlainRule _defaultedType;
            private readonly Mx.PlainRule _spreadType;
            private readonly Mx.PlainRule _emptyType;
            private readonly Mx.PlainRule _tupleType;
            private readonly Mx.PlainRule _iterableType;
            private readonly Mx.PlainRule _iterableTypeZero;
            private readonly Mx.PlainRule _iterableTypeOne;
            private readonly Mx.PlainRule _nothingType;
            private readonly Mx.PlainRule _multiParameters;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _valueParameter;
            private readonly Mx.PlainRule _parameterType;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _argumentList;
            private readonly Mx.PlainRule _argument;
            private readonly Mx.PlainRule _expressionArgument;
            private readonly Mx.PlainRule _spreadArgument;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _ifStatement;
            private readonly Mx.PlainRule _elseIf;
            private readonly Mx.PlainRule _elseBlock;
            private readonly Mx.PlainRule _forStatement;
            private readonly Mx.PlainRule _returnStatement;
            private readonly Mx.PlainRule _assertStatement;
            private readonly Mx.PlainRule _expression;
            private readonly Mx.PlainRule _levelCoalesceExpression;
            private readonly Mx.PlainRule _thenExpression;
            private readonly Mx.PlainRule _elseExpression;
            private readonly Mx.PlainRule _levelDisjunctionExpression;
            private readonly Mx.PlainRule _disjunctionExpression;
            private readonly Mx.PlainRule _levelConjunctionExpression;
            private readonly Mx.PlainRule _conjunctionExpression;
            private readonly Mx.PlainRule _levelNotExpression;
            private readonly Mx.PlainRule _notExpression;
            private readonly Mx.PlainRule _levelEqualityExpression;
            private readonly Mx.PlainRule _equalExpression;
            private readonly Mx.PlainRule _notEqualExpression;
            private readonly Mx.PlainRule _identicalExpression;
            private readonly Mx.PlainRule _notIdenticalExpression;
            private readonly Mx.PlainRule _levelCompareExpression;
            private readonly Mx.PlainRule _lessExpression;
            private readonly Mx.PlainRule _lessEqualExpression;
            private readonly Mx.PlainRule _greaterExpression;
            private readonly Mx.PlainRule _greaterEqualExpression;
            private readonly Mx.PlainRule _levelAddExpression;
            private readonly Mx.PlainRule _addExpression;
            private readonly Mx.PlainRule _subExpression;
            private readonly Mx.PlainRule _levelMulExpression;
            private readonly Mx.PlainRule _mulExpression;
            private readonly Mx.PlainRule _divExpression;
            private readonly Mx.PlainRule _remExpression;
            private readonly Mx.PlainRule _levelUnionExpression;
            private readonly Mx.PlainRule _unionExpression;
            private readonly Mx.PlainRule _complementExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.PlainRule _callExpression;
            private readonly Mx.PlainRule _selectExpression;
            private readonly Mx.PlainRule _nullsafeSelectExpression;
            private readonly Mx.PlainRule _literal;
            private readonly Mx.PlainRule _stringExpression;
            private readonly Mx.PlainRule _stringLiteral;
            private readonly Mx.PlainRule _stringInterpolation;
            private readonly Mx.PlainRule _interpolationPart;
            private readonly Mx.PlainRule _ifExpression;
            private readonly Mx.PlainRule _ifThen;
            private readonly Mx.PlainRule _ifElse;
            private readonly Mx.PlainRule _conditionalExpression;
            private readonly Mx.PlainRule _conditions;
            private readonly Mx.PlainRule _conditionList;
            private readonly Mx.PlainRule _condition;
            private readonly Mx.DfaRule _naturalLiteral;
            private readonly Mx.DfaRule _stringStart;
            private readonly Mx.DfaRule _stringMid;
            private readonly Mx.DfaRule _stringEnd;
            private readonly Mx.DfaRule _plainStringLiteral;
            private readonly Mx.DfaRule _verbatimStringLiteral;
            private readonly Mx.DfaRule _identifier;

            private readonly Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private readonly Dfa __Keywords_DFA = new Dfa("%keywords");
            private readonly Dfa _attributeName_DFA = new Dfa("attribute-name");
            private readonly Dfa _naturalLiteral_DFA = new Dfa("natural-literal");
            private readonly Dfa _stringStart_DFA = new Dfa("string-start");
            private readonly Dfa _stringMid_DFA = new Dfa("string-mid");
            private readonly Dfa _stringEnd_DFA = new Dfa("string-end");
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
        public interface ICValueDefault : IRNode {}
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
        public interface ICExtendType : IRNode {}
        public interface ICConstructor : ICExtendType {}
        public interface ICSatisfies : IRNode {}
        public interface ICConstraints : IRNode {}
        public interface ICConstraint : IRNode {}
        public interface ICUnionTypeList : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICPattern : IRNode {}
        public interface ICNamePattern : ICPattern {}
        public interface ICPrelude : IRNode {}
        public interface ICAttribute : IRNode {}
        public interface ICAttributeName : IRNode {}
        public interface ICAttributeArguments : IRNode {}
        public interface ICAttributeArgumentList : IRNode {}
        public interface ICAttributeArgument : IRNode {}
        public interface ICLiteralArgument : ICAttributeArgument {}
        public interface ICMetaArgument : ICAttributeArgument {}
        public interface ICMetaReference : IRNode {}
        public interface ICClassReference : ICMetaReference {}
        public interface ICObjectReference : ICMetaReference {}
        public interface ICValueReference : ICMetaReference {}
        public interface ICInterfaceReference : ICMetaReference {}
        public interface ICFunctionReference : ICMetaReference {}
        public interface ICType : ICExtendType, ICGenericArgument, ICParameterType, ICTypeListType {}
        public interface ICEntryType : ICType {}
        public interface ICVariadicType : ICParameterType, ICTypeListType {}
        public interface ICVariadicTypeZero : ICVariadicType {}
        public interface ICVariadicTypeOne : ICVariadicType {}
        public interface ICUnionType : ICType {}
        public interface ICIntersectionType : IRNode {}
        public interface ICPrimaryType : IRNode {}
        public interface ICNullableType : ICPrimaryType {}
        public interface ICSequenceType : ICPrimaryType {}
        public interface ICTypeSelector : ICPrimaryType {}
        public interface ICCallableType : ICPrimaryType {}
        public interface ICCallableArguments : IRNode {}
        public interface ICTypeList : ICCallableArguments {}
        public interface ICTypeListType : IRNode {}
        public interface ICDefaultedType : ICTypeListType {}
        public interface ICSpreadType : ICCallableArguments {}
        public interface ICEmptyType : ICPrimaryType {}
        public interface ICTupleType : ICPrimaryType {}
        public interface ICIterableType : ICPrimaryType {}
        public interface ICIterableTypeZero : ICIterableType {}
        public interface ICIterableTypeOne : ICIterableType {}
        public interface ICNothingType : ICPrimaryType {}
        public interface ICMultiParameters : IRNode {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICValueParameter : ICParameter {}
        public interface ICParameterType : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICArgumentList : IRNode {}
        public interface ICArgument : IRNode {}
        public interface ICExpressionArgument : ICArgument {}
        public interface ICSpreadArgument : ICArgument {}
        public interface ICStatement : ICStatelaration {}
        public interface ICIfStatement : ICStatement {}
        public interface ICElseIf : IRNode {}
        public interface ICElseBlock : IRNode {}
        public interface ICForStatement : ICStatement {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICAssertStatement : ICStatement {}
        public interface ICExpression : ICCondition {}
        public interface ICLevelCoalesceExpression : ICExpression {}
        public interface ICThenExpression : ICLevelCoalesceExpression {}
        public interface ICElseExpression : ICLevelCoalesceExpression {}
        public interface ICLevelDisjunctionExpression : ICConditionalExpression, ICLevelCoalesceExpression {}
        public interface ICDisjunctionExpression : ICLevelDisjunctionExpression {}
        public interface ICLevelConjunctionExpression : ICLevelDisjunctionExpression {}
        public interface ICConjunctionExpression : ICLevelConjunctionExpression {}
        public interface ICLevelNotExpression : ICLevelConjunctionExpression {}
        public interface ICNotExpression : ICLevelNotExpression {}
        public interface ICLevelEqualityExpression : ICLevelNotExpression {}
        public interface ICEqualExpression : ICLevelEqualityExpression {}
        public interface ICNotEqualExpression : ICLevelEqualityExpression {}
        public interface ICIdenticalExpression : ICLevelEqualityExpression {}
        public interface ICNotIdenticalExpression : ICLevelEqualityExpression {}
        public interface ICLevelCompareExpression : ICLevelEqualityExpression {}
        public interface ICLessExpression : ICLevelCompareExpression {}
        public interface ICLessEqualExpression : ICLevelCompareExpression {}
        public interface ICGreaterExpression : ICLevelCompareExpression {}
        public interface ICGreaterEqualExpression : ICLevelCompareExpression {}
        public interface ICLevelAddExpression : ICLevelCompareExpression {}
        public interface ICAddExpression : ICLevelAddExpression {}
        public interface ICSubExpression : ICLevelAddExpression {}
        public interface ICLevelMulExpression : ICLevelAddExpression {}
        public interface ICMulExpression : ICLevelMulExpression {}
        public interface ICDivExpression : ICLevelMulExpression {}
        public interface ICRemExpression : ICLevelMulExpression {}
        public interface ICLevelUnionExpression : ICLevelMulExpression {}
        public interface ICUnionExpression : ICLevelUnionExpression {}
        public interface ICComplementExpression : ICLevelUnionExpression {}
        public interface ICPrimaryExpression : ICLevelUnionExpression {}
        public interface ICCallExpression : ICPrimaryExpression {}
        public interface ICSelectExpression : ICPrimaryExpression {}
        public interface ICNullsafeSelectExpression : ICPrimaryExpression {}
        public interface ICLiteral : ICPrimaryExpression {}
        public interface ICStringExpression : ICPrimaryExpression {}
        public interface ICStringLiteral : ICStringExpression {}
        public interface ICStringInterpolation : ICStringExpression {}
        public interface ICInterpolationPart : IRNode {}
        public interface ICIfExpression : ICConditionalExpression, ICExpression {}
        public interface ICIfThen : IRNode {}
        public interface ICIfElse : IRNode {}
        public interface ICConditionalExpression : IRNode {}
        public interface ICConditions : IRNode {}
        public interface ICConditionList : IRNode {}
        public interface ICCondition : IRNode {}
        public interface ICNaturalLiteral : ICLiteral {}
        public interface ICStringStart : IRNode {}
        public interface ICStringMid : IRNode {}
        public interface ICStringEnd : IRNode {}
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

        public partial class CValueDefault : RSequence, ICValueDefault
        {
            // sequence
            public CValueDefault(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICExpression Expression => Get<ICExpression>(1);
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
            public ROptional<ICType> Type => Get<ROptional<ICType>>(1);
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public CMultiParameters MultiParameters => Get<CMultiParameters>(4);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(5);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(6);
        }

        public partial class CAttributeDeclaration : RSequence, ICAttributeDeclaration
        {
            // sequence
            public CAttributeDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ROptional<ICType> Type => Get<ROptional<ICType>>(1);
            public ICName Name => Get<ICName>(2);
            public ICAttributeBody AttributeBody => Get<ICAttributeBody>(3);
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
            public ICExtendType ExtendType => Get<ICExtendType>(1);
        }

        public partial class CConstructor : RSequence, ICConstructor
        {
            // sequence
            public CConstructor(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public CArguments Arguments => Get<CArguments>(1);
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

        public partial class CNamePattern : RSequence, ICNamePattern
        {
            // sequence
            public CNamePattern(params RNode[] children) : base(children) {}

            public ICName Name => Get<ICName>(0);
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

            public CAttributeName AttributeName => Get<CAttributeName>(0);
            public ROptional<CAttributeArguments> AttributeArguments => Get<ROptional<CAttributeArguments>>(1);
        }

        public partial class CAttributeName : RToken, ICAttributeName
        {
            // token
            public CAttributeName(params Node[] children) : base(children) {}
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

        public partial class CLiteralArgument : RSequence, ICLiteralArgument
        {
            // sequence
            public CLiteralArgument(params RNode[] children) : base(children) {}

            public ICStringLiteral StringLiteral => Get<ICStringLiteral>(0);
        }

        public partial class CMetaArgument : RSequence, ICMetaArgument
        {
            // sequence
            public CMetaArgument(params RNode[] children) : base(children) {}

            public ICMetaReference MetaReference => Get<ICMetaReference>(0);
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

        public partial class CEntryType : RSequence, ICEntryType
        {
            // sequence
            public CEntryType(params RNode[] children) : base(children) {}

            public CUnionType UnionType => Get<CUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '->'
            public CUnionType UnionType2 => Get<CUnionType>(2);
        }

        public partial class CVariadicTypeZero : RSequence, ICVariadicTypeZero
        {
            // sequence
            public CVariadicTypeZero(params RNode[] children) : base(children) {}

            public CUnionType UnionType => Get<CUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '*'
        }

        public partial class CVariadicTypeOne : RSequence, ICVariadicTypeOne
        {
            // sequence
            public CVariadicTypeOne(params RNode[] children) : base(children) {}

            public CUnionType UnionType => Get<CUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
        }

        public partial class CUnionType : RLoop<CIntersectionType>, ICUnionType
        {
            // sequence
            public CUnionType(params RNode[] children) : base(children) {}
        }

        public partial class CIntersectionType : RLoop<ICPrimaryType>, ICIntersectionType
        {
            // sequence
            public CIntersectionType(params RNode[] children) : base(children) {}
        }

        public partial class CNullableType : RSequence, ICNullableType
        {
            // sequence
            public CNullableType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '?'
        }

        public partial class CSequenceType : RSequence, ICSequenceType
        {
            // sequence
            public CSequenceType(params RNode[] children) : base(children) {}

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

        public partial class CCallableType : RSequence, ICCallableType
        {
            // sequence
            public CCallableType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '('
            public ROptional<ICCallableArguments> CallableArguments => Get<ROptional<ICCallableArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ')'
        }

        public partial class CTypeList : RLoop<ICTypeListType>, ICTypeList
        {
            // sequence
            public CTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CDefaultedType : RSequence, ICDefaultedType
        {
            // sequence
            public CDefaultedType(params RNode[] children) : base(children) {}

            public ICType Type => Get<ICType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '='
        }

        public partial class CSpreadType : RSequence, ICSpreadType
        {
            // sequence
            public CSpreadType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '*'
            public CUnionType UnionType => Get<CUnionType>(1);
        }

        public partial class CEmptyType : RSequence, ICEmptyType
        {
            // sequence
            public CEmptyType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public RLiteral Literal2 => Get<RLiteral>(1); // ']'
        }

        public partial class CTupleType : RSequence, ICTupleType
        {
            // sequence
            public CTupleType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public CTypeList TypeList => Get<CTypeList>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CIterableTypeZero : RSequence, ICIterableTypeZero
        {
            // sequence
            public CIterableTypeZero(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUnionType UnionType => Get<CUnionType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '*'
            public RLiteral Literal3 => Get<RLiteral>(3); // '}'
        }

        public partial class CIterableTypeOne : RSequence, ICIterableTypeOne
        {
            // sequence
            public CIterableTypeOne(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUnionType UnionType => Get<CUnionType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '+'
            public RLiteral Literal3 => Get<RLiteral>(3); // '}'
        }

        public partial class CNothingType : RSequence, ICNothingType
        {
            // sequence
            public CNothingType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'Nothing'
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

        public partial class CParameterList : RLoop<ICParameter>, ICParameterList
        {
            // sequence
            public CParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CValueParameter : RSequence, ICValueParameter
        {
            // sequence
            public CValueParameter(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ROptional<ICParameterType> ParameterType => Get<ROptional<ICParameterType>>(1);
            public ICName Name => Get<ICName>(2);
            public ROptional<CValueDefault> ValueDefault => Get<ROptional<CValueDefault>>(3);
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

        public partial class CExpressionArgument : RSequence, ICExpressionArgument
        {
            // sequence
            public CExpressionArgument(params RNode[] children) : base(children) {}

            public ICExpression Expression => Get<ICExpression>(0);
        }

        public partial class CSpreadArgument : RSequence, ICSpreadArgument
        {
            // sequence
            public CSpreadArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '*'
            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(1);
        }

        public partial class CIfStatement : RSequence, ICIfStatement
        {
            // sequence
            public CIfStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlockBody BlockBody => Get<CBlockBody>(2);
            public RStar<CElseIf> ElseIf => Get<RStar<CElseIf>>(3);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(4);
        }

        public partial class CElseIf : RSequence, ICElseIf
        {
            // sequence
            public CElseIf(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public RLiteral Literal2 => Get<RLiteral>(1); // 'if'
            public CConditions Conditions => Get<CConditions>(2);
            public CBlockBody BlockBody => Get<CBlockBody>(3);
        }

        public partial class CElseBlock : RSequence, ICElseBlock
        {
            // sequence
            public CElseBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public CBlockBody BlockBody => Get<CBlockBody>(1);
        }

        public partial class CForStatement : RSequence, ICForStatement
        {
            // sequence
            public CForStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ICPattern Pattern => Get<ICPattern>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // 'in'
            public ICExpression Expression => Get<ICExpression>(4);
            public RLiteral Literal4 => Get<RLiteral>(5); // ')'
            public CBlockBody BlockBody => Get<CBlockBody>(6);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(7);
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

        public partial class CThenExpression : RSequence, ICThenExpression
        {
            // sequence
            public CThenExpression(params RNode[] children) : base(children) {}

            public ICLevelCoalesceExpression LevelCoalesceExpression => Get<ICLevelCoalesceExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'then'
            public ICLevelDisjunctionExpression LevelDisjunctionExpression => Get<ICLevelDisjunctionExpression>(2);
        }

        public partial class CElseExpression : RSequence, ICElseExpression
        {
            // sequence
            public CElseExpression(params RNode[] children) : base(children) {}

            public ICLevelCoalesceExpression LevelCoalesceExpression => Get<ICLevelCoalesceExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'else'
            public ICLevelDisjunctionExpression LevelDisjunctionExpression => Get<ICLevelDisjunctionExpression>(2);
        }

        public partial class CDisjunctionExpression : RSequence, ICDisjunctionExpression
        {
            // sequence
            public CDisjunctionExpression(params RNode[] children) : base(children) {}

            public ICLevelDisjunctionExpression LevelDisjunctionExpression => Get<ICLevelDisjunctionExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '||'
            public ICLevelConjunctionExpression LevelConjunctionExpression => Get<ICLevelConjunctionExpression>(2);
        }

        public partial class CConjunctionExpression : RSequence, ICConjunctionExpression
        {
            // sequence
            public CConjunctionExpression(params RNode[] children) : base(children) {}

            public ICLevelConjunctionExpression LevelConjunctionExpression => Get<ICLevelConjunctionExpression>(0);
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

            public ICLevelCompareExpression LevelCompareExpression => Get<ICLevelCompareExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '=='
            public ICLevelCompareExpression LevelCompareExpression2 => Get<ICLevelCompareExpression>(2);
        }

        public partial class CNotEqualExpression : RSequence, ICNotEqualExpression
        {
            // sequence
            public CNotEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelCompareExpression LevelCompareExpression => Get<ICLevelCompareExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!='
            public ICLevelCompareExpression LevelCompareExpression2 => Get<ICLevelCompareExpression>(2);
        }

        public partial class CIdenticalExpression : RSequence, ICIdenticalExpression
        {
            // sequence
            public CIdenticalExpression(params RNode[] children) : base(children) {}

            public ICLevelCompareExpression LevelCompareExpression => Get<ICLevelCompareExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '==='
            public ICLevelCompareExpression LevelCompareExpression2 => Get<ICLevelCompareExpression>(2);
        }

        public partial class CNotIdenticalExpression : RSequence, ICNotIdenticalExpression
        {
            // sequence
            public CNotIdenticalExpression(params RNode[] children) : base(children) {}

            public ICLevelCompareExpression LevelCompareExpression => Get<ICLevelCompareExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '!=='
            public ICLevelCompareExpression LevelCompareExpression2 => Get<ICLevelCompareExpression>(2);
        }

        public partial class CLessExpression : RSequence, ICLessExpression
        {
            // sequence
            public CLessExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<'
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CLessEqualExpression : RSequence, ICLessEqualExpression
        {
            // sequence
            public CLessEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CGreaterExpression : RSequence, ICGreaterExpression
        {
            // sequence
            public CGreaterExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>'
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CGreaterEqualExpression : RSequence, ICGreaterEqualExpression
        {
            // sequence
            public CGreaterEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CAddExpression : RSequence, ICAddExpression
        {
            // sequence
            public CAddExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(2);
        }

        public partial class CSubExpression : RSequence, ICSubExpression
        {
            // sequence
            public CSubExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '-'
            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(2);
        }

        public partial class CMulExpression : RSequence, ICMulExpression
        {
            // sequence
            public CMulExpression(params RNode[] children) : base(children) {}

            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '*'
            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(2);
        }

        public partial class CDivExpression : RSequence, ICDivExpression
        {
            // sequence
            public CDivExpression(params RNode[] children) : base(children) {}

            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '/'
            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(2);
        }

        public partial class CRemExpression : RSequence, ICRemExpression
        {
            // sequence
            public CRemExpression(params RNode[] children) : base(children) {}

            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '%'
            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(2);
        }

        public partial class CUnionExpression : RSequence, ICUnionExpression
        {
            // sequence
            public CUnionExpression(params RNode[] children) : base(children) {}

            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '|'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CComplementExpression : RSequence, ICComplementExpression
        {
            // sequence
            public CComplementExpression(params RNode[] children) : base(children) {}

            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '~'
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

        public partial class CNullsafeSelectExpression : RSequence, ICNullsafeSelectExpression
        {
            // sequence
            public CNullsafeSelectExpression(params RNode[] children) : base(children) {}

            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '?.'
            public CReference Reference => Get<CReference>(2);
        }

        public partial class CStringInterpolation : RSequence, ICStringInterpolation
        {
            // sequence
            public CStringInterpolation(params RNode[] children) : base(children) {}

            public CStringStart StringStart => Get<CStringStart>(0);
            public ICExpression Expression => Get<ICExpression>(1);
            public RStar<CInterpolationPart> InterpolationPart => Get<RStar<CInterpolationPart>>(2);
            public CStringEnd StringEnd => Get<CStringEnd>(3);
        }

        public partial class CInterpolationPart : RSequence, ICInterpolationPart
        {
            // sequence
            public CInterpolationPart(params RNode[] children) : base(children) {}

            public CStringMid StringMid => Get<CStringMid>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CIfExpression : RSequence, ICIfExpression
        {
            // sequence
            public CIfExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
            public CConditions Conditions => Get<CConditions>(1);
            public CIfThen IfThen => Get<CIfThen>(2);
            public CIfElse IfElse => Get<CIfElse>(3);
        }

        public partial class CIfThen : RSequence, ICIfThen
        {
            // sequence
            public CIfThen(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'then'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CIfElse : RSequence, ICIfElse
        {
            // sequence
            public CIfElse(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CConditions : RSequence, ICConditions
        {
            // sequence
            public CConditions(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public CConditionList ConditionList => Get<CConditionList>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CConditionList : RLoop<ICCondition>, ICConditionList
        {
            // sequence
            public CConditionList(params RNode[] children) : base(children) {}
        }

        public partial class CNaturalLiteral : RToken, ICNaturalLiteral
        {
            // token
            public CNaturalLiteral(params Node[] children) : base(children) {}
        }

        public partial class CStringStart : RToken, ICStringStart
        {
            // token
            public CStringStart(params Node[] children) : base(children) {}
        }

        public partial class CStringMid : RToken, ICStringMid
        {
            // token
            public CStringMid(params Node[] children) : base(children) {}
        }

        public partial class CStringEnd : RToken, ICStringEnd
        {
            // token
            public CStringEnd(params Node[] children) : base(children) {}
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

            protected virtual void Visit(CValueDefault element)
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

            protected virtual void Visit(CConstructor element)
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

            protected virtual void Visit(CNamePattern element)
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

            protected virtual void Visit(CAttributeName element)
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

            protected virtual void Visit(CLiteralArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMetaArgument element)
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

            protected virtual void Visit(CEntryType element)
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

            protected virtual void Visit(CSequenceType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeSelector element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCallableType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDefaultedType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpreadType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEmptyType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTupleType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIterableTypeZero element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIterableTypeOne element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNothingType element)
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

            protected virtual void Visit(CValueParameter element)
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

            protected virtual void Visit(CExpressionArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpreadArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElseIf element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElseBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CForStatement element)
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

            protected virtual void Visit(CThenExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElseExpression element)
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

            protected virtual void Visit(CLessExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLessEqualExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGreaterExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGreaterEqualExpression element)
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

            protected virtual void Visit(CUnionExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CComplementExpression element)
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

            protected virtual void Visit(CNullsafeSelectExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStringInterpolation element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterpolationPart element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfThen element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfElse element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConditions element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConditionList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNaturalLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStringStart element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStringMid element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStringEnd element)
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
