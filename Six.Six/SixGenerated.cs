// <generated from="C:\\Dev\\Knut\\Six\\Six.Six\\Six.six" at="15.02.2022 16:10:41" />

using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Mx = Six.Runtime.Matchers;
using static Six.Six.SixTree;

namespace Six.Six
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
                : base(new Mx.Matcher[467])
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
                /*  34 PlainRuleOp      */ __Matchers[34] = _varDeclaration = new Mx.PlainRule(this, 34, "var-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _letDeclaration = new Mx.PlainRule(this, 35, "let-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _classDeclaration = new Mx.PlainRule(this, 36, "class-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _interfaceDeclaration = new Mx.PlainRule(this, 37, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _objectDeclaration = new Mx.PlainRule(this, 38, "object-declaration") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _aliasDeclaration = new Mx.PlainRule(this, 39, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _constructorDeclaration = new Mx.PlainRule(this, 40, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _functionBody = new Mx.PlainRule(this, 41, "function-body") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _attributeBody = new Mx.PlainRule(this, 42, "attribute-body") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _blockBody = new Mx.PlainRule(this, 43, "block-body") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _statelarations = new Mx.PlainRule(this, 44, "statelarations") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _statelaration = new Mx.PlainRule(this, 45, "statelaration") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _expressionBody = new Mx.PlainRule(this, 46, "expression-body") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _nullBody = new Mx.PlainRule(this, 47, "null-body") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _functionSpecifier = new Mx.PlainRule(this, 48, "function-specifier") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _extends = new Mx.PlainRule(this, 49, "extends") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _extendType = new Mx.PlainRule(this, 50, "extend-type") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _constructor = new Mx.PlainRule(this, 51, "constructor") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _satisfies = new Mx.PlainRule(this, 52, "satisfies") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _constraints = new Mx.PlainRule(this, 53, "constraints") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _constraint = new Mx.PlainRule(this, 54, "constraint") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _unionTypeList = new Mx.PlainRule(this, 55, "union-type-list") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _caseTypes = new Mx.PlainRule(this, 56, "case-types") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _caseTypeList = new Mx.PlainRule(this, 57, "case-type-list") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _pattern = new Mx.PlainRule(this, 58, "pattern") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _namePattern = new Mx.PlainRule(this, 59, "name-pattern") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _prelude = new Mx.PlainRule(this, 60, "prelude") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _attribute = new Mx.PlainRule(this, 61, "attribute") { Builder = nodes => nodes[0] };
                /*  62 DfaRuleOp        */ __Matchers[62] = _attributeName = new Mx.DfaRule(this, 62, "attribute-name") { Creator = node => new CAttributeName(node) };
                /*  63 PlainRuleOp      */ __Matchers[63] = _attributeArguments = new Mx.PlainRule(this, 63, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _attributeArgumentList = new Mx.PlainRule(this, 64, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _attributeArgument = new Mx.PlainRule(this, 65, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _metaReference = new Mx.PlainRule(this, 66, "meta-reference") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _classReference = new Mx.PlainRule(this, 67, "class-reference") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _objectReference = new Mx.PlainRule(this, 68, "object-reference") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _valueReference = new Mx.PlainRule(this, 69, "value-reference") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _interfaceReference = new Mx.PlainRule(this, 70, "interface-reference") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _functionReference = new Mx.PlainRule(this, 71, "function-reference") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _type = new Mx.PlainRule(this, 72, "type") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _entryType = new Mx.PlainRule(this, 73, "entry-type") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _variadicType = new Mx.PlainRule(this, 74, "variadic-type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _variadicTypeZero = new Mx.PlainRule(this, 75, "variadic-type-zero") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _variadicTypeOne = new Mx.PlainRule(this, 76, "variadic-type-one") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _unionType = new Mx.PlainRule(this, 77, "union-type") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _intersectionType = new Mx.PlainRule(this, 78, "intersection-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _primaryType = new Mx.PlainRule(this, 79, "primary-type") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _nullableType = new Mx.PlainRule(this, 80, "nullable-type") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _sequenceType = new Mx.PlainRule(this, 81, "sequence-type") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _typeSelector = new Mx.PlainRule(this, 82, "type-selector") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _callableType = new Mx.PlainRule(this, 83, "callable-type") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _callableArguments = new Mx.PlainRule(this, 84, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _typeList = new Mx.PlainRule(this, 85, "type-list") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _typeListType = new Mx.PlainRule(this, 86, "type-list-type") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _defaultedType = new Mx.PlainRule(this, 87, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _spreadType = new Mx.PlainRule(this, 88, "spread-type") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _emptyType = new Mx.PlainRule(this, 89, "empty-type") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _tupleType = new Mx.PlainRule(this, 90, "tuple-type") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _iterableType = new Mx.PlainRule(this, 91, "iterable-type") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _iterableTypeZero = new Mx.PlainRule(this, 92, "iterable-type-zero") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _iterableTypeOne = new Mx.PlainRule(this, 93, "iterable-type-one") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _nothingType = new Mx.PlainRule(this, 94, "nothing-type") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _multiParameters = new Mx.PlainRule(this, 95, "multi-parameters") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _parameters = new Mx.PlainRule(this, 96, "parameters") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _parameterList = new Mx.PlainRule(this, 97, "parameter-list") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _parameter = new Mx.PlainRule(this, 98, "parameter") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _valueParameter = new Mx.PlainRule(this, 99, "value-parameter") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _valueDefault = new Mx.PlainRule(this, 100, "value-default") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _parameterType = new Mx.PlainRule(this, 101, "parameter-type") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _arguments = new Mx.PlainRule(this, 102, "arguments") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _expressionList = new Mx.PlainRule(this, 103, "expression-list") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _statement = new Mx.PlainRule(this, 104, "statement") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _assignStatement = new Mx.PlainRule(this, 105, "assign-statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _expressionStatement = new Mx.PlainRule(this, 106, "expression-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _ifStatement = new Mx.PlainRule(this, 107, "if-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _elseIf = new Mx.PlainRule(this, 108, "else-if") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _elseBlock = new Mx.PlainRule(this, 109, "else-block") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _forStatement = new Mx.PlainRule(this, 110, "for-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _returnStatement = new Mx.PlainRule(this, 111, "return-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _throwStatement = new Mx.PlainRule(this, 112, "throw-statement") { Builder = nodes => nodes[0] };
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
                /* 134 PlainRuleOp      */ __Matchers[134] = _boundsExpression = new Mx.PlainRule(this, 134, "bounds-expression") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _lowerBound = new Mx.PlainRule(this, 135, "lower-bound") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _lowerLessBound = new Mx.PlainRule(this, 136, "lower-less-bound") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _lowerLessEqualBound = new Mx.PlainRule(this, 137, "lower-less-equal-bound") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _upperBound = new Mx.PlainRule(this, 138, "upper-bound") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _upperLessBound = new Mx.PlainRule(this, 139, "upper-less-bound") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _upperLessEqualBound = new Mx.PlainRule(this, 140, "upper-less-equal-bound") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _levelAddExpression = new Mx.PlainRule(this, 141, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _addExpression = new Mx.PlainRule(this, 142, "add-expression") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _subExpression = new Mx.PlainRule(this, 143, "sub-expression") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _levelMulExpression = new Mx.PlainRule(this, 144, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _mulExpression = new Mx.PlainRule(this, 145, "mul-expression") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _divExpression = new Mx.PlainRule(this, 146, "div-expression") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _remExpression = new Mx.PlainRule(this, 147, "rem-expression") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _levelUnionExpression = new Mx.PlainRule(this, 148, "level-union-expression") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _unionExpression = new Mx.PlainRule(this, 149, "union-expression") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _complementExpression = new Mx.PlainRule(this, 150, "complement-expression") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _levelExclusiveExpression = new Mx.PlainRule(this, 151, "level-exclusive-expression") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _exclusiveExpression = new Mx.PlainRule(this, 152, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _levelIntersectionExpression = new Mx.PlainRule(this, 153, "level-intersection-expression") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _intersectionExpression = new Mx.PlainRule(this, 154, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _levelNegateExpression = new Mx.PlainRule(this, 155, "level-negate-expression") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _negateExpression = new Mx.PlainRule(this, 156, "negate-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _primaryExpression = new Mx.PlainRule(this, 157, "primary-expression") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _groupedExpression = new Mx.PlainRule(this, 158, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _callExpression = new Mx.PlainRule(this, 159, "call-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _selectExpression = new Mx.PlainRule(this, 160, "select-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _nullsafeSelectExpression = new Mx.PlainRule(this, 161, "nullsafe-select-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _literal = new Mx.PlainRule(this, 162, "literal") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _stringExpression = new Mx.PlainRule(this, 163, "string-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _stringLiteral = new Mx.PlainRule(this, 164, "string-literal") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _stringInterpolation = new Mx.PlainRule(this, 165, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _interpolationPart = new Mx.PlainRule(this, 166, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _ifExpression = new Mx.PlainRule(this, 167, "if-expression") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _ifThen = new Mx.PlainRule(this, 168, "if-then") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _ifElse = new Mx.PlainRule(this, 169, "if-else") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _conditionalExpression = new Mx.PlainRule(this, 170, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _conditions = new Mx.PlainRule(this, 171, "conditions") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _conditionList = new Mx.PlainRule(this, 172, "condition-list") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _condition = new Mx.PlainRule(this, 173, "condition") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _isCondition = new Mx.PlainRule(this, 174, "is-condition") { Builder = nodes => nodes[0] };
                /* 175 DfaRuleOp        */ __Matchers[175] = _naturalLiteral = new Mx.DfaRule(this, 175, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 176 DfaRuleOp        */ __Matchers[176] = _stringStart = new Mx.DfaRule(this, 176, "string-start") { Creator = node => new CStringStart(node) };
                /* 177 DfaRuleOp        */ __Matchers[177] = _stringMid = new Mx.DfaRule(this, 177, "string-mid") { Creator = node => new CStringMid(node) };
                /* 178 DfaRuleOp        */ __Matchers[178] = _stringEnd = new Mx.DfaRule(this, 178, "string-end") { Creator = node => new CStringEnd(node) };
                /* 179 DfaRuleOp        */ __Matchers[179] = _plainStringLiteral = new Mx.DfaRule(this, 179, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 180 DfaRuleOp        */ __Matchers[180] = _verbatimStringLiteral = new Mx.DfaRule(this, 180, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 181 DfaRuleOp        */ __Matchers[181] = _identifier = new Mx.DfaRule(this, 181, "identifier") { Creator = node => new CIdentifier(node) };
                /* 182 EofOp            */ __Matchers[182] = new Mx.Eof(this, 182, "<eof>") { Creator = node => new REof(node) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 184 AltOp            */ __Matchers[184] = new Mx.Alt(this, 184, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 185 StringOp         */ __Matchers[185] = new Mx.String(this, 185, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 186 OptionalOp       */ __Matchers[186] = new Mx.Optional(this, 186, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 187 SeqOp            */ __Matchers[187] = new Mx.Seq(this, 187, "_187:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 188 StringOp         */ __Matchers[188] = new Mx.Keyword(this, 188, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.String(this, 189, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 191 StringOp         */ __Matchers[191] = new Mx.Keyword(this, 191, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 193 StringOp         */ __Matchers[193] = new Mx.String(this, 193, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 194 StarOp           */ __Matchers[194] = new Mx.Star(this, 194, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 195 StringOp         */ __Matchers[195] = new Mx.String(this, 195, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 197 StringOp         */ __Matchers[197] = new Mx.Keyword(this, 197, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 198 SeqOp            */ __Matchers[198] = new Mx.Seq(this, 198, "_198:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 199 StarOp           */ __Matchers[199] = new Mx.Star(this, 199, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 200 StringOp         */ __Matchers[200] = new Mx.Keyword(this, 200, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 202 OptionalOp       */ __Matchers[202] = new Mx.Optional(this, 202, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 203 SeqOp            */ __Matchers[203] = new Mx.Seq(this, 203, "_203:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 204 StringOp         */ __Matchers[204] = new Mx.String(this, 204, "','", ",") { Creator = node => new RLiteral(node) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 206 StarOp           */ __Matchers[206] = new Mx.Star(this, 206, "*(_205:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:(>using-element,*(_205:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 208 AltOp            */ __Matchers[208] = new Mx.Alt(this, 208, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 209 OptionalOp       */ __Matchers[209] = new Mx.Optional(this, 209, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 210 OptionalOp       */ __Matchers[210] = new Mx.Optional(this, 210, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 211 SeqOp            */ __Matchers[211] = new Mx.Seq(this, 211, "_211:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 212 StringOp         */ __Matchers[212] = new Mx.String(this, 212, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 213 SeqOp            */ __Matchers[213] = new Mx.Seq(this, 213, "_213:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 214 StringOp         */ __Matchers[214] = new Mx.String(this, 214, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 215 StringOp         */ __Matchers[215] = new Mx.String(this, 215, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 216 SeqOp            */ __Matchers[216] = new Mx.Seq(this, 216, "_216:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 217 StarOp           */ __Matchers[217] = new Mx.Star(this, 217, "*(_216:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 218 SeqOp            */ __Matchers[218] = new Mx.Seq(this, 218, "_218:(>name,*(_216:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 219 OptionalOp       */ __Matchers[219] = new Mx.Optional(this, 219, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 220 SeqOp            */ __Matchers[220] = new Mx.Seq(this, 220, "_220:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 221 StringOp         */ __Matchers[221] = new Mx.String(this, 221, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 222 OptionalOp       */ __Matchers[222] = new Mx.Optional(this, 222, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 223 StringOp         */ __Matchers[223] = new Mx.String(this, 223, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 225 SeqOp            */ __Matchers[225] = new Mx.Seq(this, 225, "_225:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 226 StarOp           */ __Matchers[226] = new Mx.Star(this, 226, "*(_225:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 227 SeqOp            */ __Matchers[227] = new Mx.Seq(this, 227, "_227:(>generic-argument,*(_225:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 228 OptionalOp       */ __Matchers[228] = new Mx.Optional(this, 228, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 229 SeqOp            */ __Matchers[229] = new Mx.Seq(this, 229, "_229:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 230 SeqOp            */ __Matchers[230] = new Mx.Seq(this, 230, "_230:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 231 StarOp           */ __Matchers[231] = new Mx.Star(this, 231, "*(_230:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 232 SeqOp            */ __Matchers[232] = new Mx.Seq(this, 232, "_232:(>generic-parameter,*(_230:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 233 OptionalOp       */ __Matchers[233] = new Mx.Optional(this, 233, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 234 OptionalOp       */ __Matchers[234] = new Mx.Optional(this, 234, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 236 SeqOp            */ __Matchers[236] = new Mx.Seq(this, 236, "_236:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 237 StringOp         */ __Matchers[237] = new Mx.Keyword(this, 237, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 238 StringOp         */ __Matchers[238] = new Mx.Keyword(this, 238, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 239 AltOp            */ __Matchers[239] = new Mx.Alt(this, 239, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 240 StarOp           */ __Matchers[240] = new Mx.Star(this, 240, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 241 AltOp            */ __Matchers[241] = new Mx.Alt(this, 241, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration|>let-declaration|>var-declaration)") { Builder = nodes => nodes[0] };
                /* 242 OptionalOp       */ __Matchers[242] = new Mx.Optional(this, 242, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 243 OptionalOp       */ __Matchers[243] = new Mx.Optional(this, 243, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 244 OptionalOp       */ __Matchers[244] = new Mx.Optional(this, 244, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:(>prelude,?(>type),>name,?(>generic-parameters),>multi-parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 246 SeqOp            */ __Matchers[246] = new Mx.Seq(this, 246, "_246:(>prelude,?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 247 StringOp         */ __Matchers[247] = new Mx.Keyword(this, 247, "'var'", "var") { Creator = node => new RLiteral(node) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>prelude,'var',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CVarDeclaration(nodes) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.Keyword(this, 249, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:(>prelude,'let',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CLetDeclaration(nodes) };
                /* 251 StringOp         */ __Matchers[251] = new Mx.Keyword(this, 251, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 252 OptionalOp       */ __Matchers[252] = new Mx.Optional(this, 252, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 253 OptionalOp       */ __Matchers[253] = new Mx.Optional(this, 253, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 254 OptionalOp       */ __Matchers[254] = new Mx.Optional(this, 254, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 255 OptionalOp       */ __Matchers[255] = new Mx.Optional(this, 255, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 256 SeqOp            */ __Matchers[256] = new Mx.Seq(this, 256, "_256:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 257 StringOp         */ __Matchers[257] = new Mx.Keyword(this, 257, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 258 SeqOp            */ __Matchers[258] = new Mx.Seq(this, 258, "_258:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 259 StringOp         */ __Matchers[259] = new Mx.Keyword(this, 259, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 260 SeqOp            */ __Matchers[260] = new Mx.Seq(this, 260, "_260:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 261 StringOp         */ __Matchers[261] = new Mx.Keyword(this, 261, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 262 StringOp         */ __Matchers[262] = new Mx.String(this, 262, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 263 SeqOp            */ __Matchers[263] = new Mx.Seq(this, 263, "_263:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 264 StringOp         */ __Matchers[264] = new Mx.Keyword(this, 264, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 265 OptionalOp       */ __Matchers[265] = new Mx.Optional(this, 265, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 266 SeqOp            */ __Matchers[266] = new Mx.Seq(this, 266, "_266:(>prelude,'new',?(>name),>parameters,?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 267 AltOp            */ __Matchers[267] = new Mx.Alt(this, 267, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 268 SeqOp            */ __Matchers[268] = new Mx.Seq(this, 268, "_268:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 269 StarOp           */ __Matchers[269] = new Mx.Star(this, 269, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 270 AltOp            */ __Matchers[270] = new Mx.Alt(this, 270, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 271 SeqOp            */ __Matchers[271] = new Mx.Seq(this, 271, "_271:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 272 SeqOp            */ __Matchers[272] = new Mx.Seq(this, 272, "_272:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 273 SeqOp            */ __Matchers[273] = new Mx.Seq(this, 273, "_273:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 274 StringOp         */ __Matchers[274] = new Mx.String(this, 274, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 275 SeqOp            */ __Matchers[275] = new Mx.Seq(this, 275, "_275:(':',>extend-type)") { Builder = nodes => new CExtends(nodes) };
                /* 276 AltOp            */ __Matchers[276] = new Mx.Alt(this, 276, "alt(>type|>constructor)") { Builder = nodes => nodes[0] };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 278 StringOp         */ __Matchers[278] = new Mx.Keyword(this, 278, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 279 SeqOp            */ __Matchers[279] = new Mx.Seq(this, 279, "_279:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 280 PlusOp           */ __Matchers[280] = new Mx.Plus(this, 280, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 281 StringOp         */ __Matchers[281] = new Mx.Keyword(this, 281, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 283 SeqOp            */ __Matchers[283] = new Mx.Seq(this, 283, "_283:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 284 StarOp           */ __Matchers[284] = new Mx.Star(this, 284, "*(_283:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 285 SeqOp            */ __Matchers[285] = new Mx.Seq(this, 285, "_285:(>type,*(_283:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 286 StringOp         */ __Matchers[286] = new Mx.Keyword(this, 286, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 287 SeqOp            */ __Matchers[287] = new Mx.Seq(this, 287, "_287:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 288 StringOp         */ __Matchers[288] = new Mx.String(this, 288, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 289 SeqOp            */ __Matchers[289] = new Mx.Seq(this, 289, "_289:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 290 StarOp           */ __Matchers[290] = new Mx.Star(this, 290, "*(_289:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 291 SeqOp            */ __Matchers[291] = new Mx.Seq(this, 291, "_291:(>type,*(_289:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 293 OptionalOp       */ __Matchers[293] = new Mx.Optional(this, 293, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 294 StarOp           */ __Matchers[294] = new Mx.Star(this, 294, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 296 OptionalOp       */ __Matchers[296] = new Mx.Optional(this, 296, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 297 SeqOp            */ __Matchers[297] = new Mx.Seq(this, 297, "_297:(>attribute-name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 298 StringOp         */ __Matchers[298] = new Mx.String(this, 298, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 299 OptionalOp       */ __Matchers[299] = new Mx.Optional(this, 299, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 300 StringOp         */ __Matchers[300] = new Mx.String(this, 300, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 301 SeqOp            */ __Matchers[301] = new Mx.Seq(this, 301, "_301:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 303 StarOp           */ __Matchers[303] = new Mx.Star(this, 303, "*(_302:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 304 SeqOp            */ __Matchers[304] = new Mx.Seq(this, 304, "_304:(>attribute-argument,*(_302:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 305 AltOp            */ __Matchers[305] = new Mx.Alt(this, 305, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 306 AltOp            */ __Matchers[306] = new Mx.Alt(this, 306, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 308 SeqOp            */ __Matchers[308] = new Mx.Seq(this, 308, "_308:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 309 StringOp         */ __Matchers[309] = new Mx.Keyword(this, 309, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 310 SeqOp            */ __Matchers[310] = new Mx.Seq(this, 310, "_310:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 311 SeqOp            */ __Matchers[311] = new Mx.Seq(this, 311, "_311:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 312 StringOp         */ __Matchers[312] = new Mx.Keyword(this, 312, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 313 SeqOp            */ __Matchers[313] = new Mx.Seq(this, 313, "_313:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 314 AltOp            */ __Matchers[314] = new Mx.Alt(this, 314, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 315 StringOp         */ __Matchers[315] = new Mx.String(this, 315, "'->'", "->") { Creator = node => new RLiteral(node) };
                /* 316 SeqOp            */ __Matchers[316] = new Mx.Seq(this, 316, "_316:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 317 AltOp            */ __Matchers[317] = new Mx.Alt(this, 317, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 318 StringOp         */ __Matchers[318] = new Mx.String(this, 318, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 319 SeqOp            */ __Matchers[319] = new Mx.Seq(this, 319, "_319:(>union-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 320 StringOp         */ __Matchers[320] = new Mx.String(this, 320, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 321 SeqOp            */ __Matchers[321] = new Mx.Seq(this, 321, "_321:(>union-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 322 SeqOp            */ __Matchers[322] = new Mx.Seq(this, 322, "_322:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 323 StarOp           */ __Matchers[323] = new Mx.Star(this, 323, "*(_322:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 324 SeqOp            */ __Matchers[324] = new Mx.Seq(this, 324, "_324:(>intersection-type,*(_322:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 325 StringOp         */ __Matchers[325] = new Mx.String(this, 325, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 326 SeqOp            */ __Matchers[326] = new Mx.Seq(this, 326, "_326:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 327 StarOp           */ __Matchers[327] = new Mx.Star(this, 327, "*(_326:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 328 SeqOp            */ __Matchers[328] = new Mx.Seq(this, 328, "_328:(>primary-type,*(_326:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 329 AltOp            */ __Matchers[329] = new Mx.Alt(this, 329, "alt(>nullable-type|>sequence-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>iterable-type|>nothing-type)") { Builder = nodes => nodes[0] };
                /* 330 StringOp         */ __Matchers[330] = new Mx.String(this, 330, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 331 SeqOp            */ __Matchers[331] = new Mx.Seq(this, 331, "_331:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 332 StringOp         */ __Matchers[332] = new Mx.String(this, 332, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 333 StringOp         */ __Matchers[333] = new Mx.String(this, 333, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 334 SeqOp            */ __Matchers[334] = new Mx.Seq(this, 334, "_334:(>primary-type,'[',']')") { Builder = nodes => new CSequenceType(nodes) };
                /* 335 SeqOp            */ __Matchers[335] = new Mx.Seq(this, 335, "_335:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 336 OptionalOp       */ __Matchers[336] = new Mx.Optional(this, 336, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 337 SeqOp            */ __Matchers[337] = new Mx.Seq(this, 337, "_337:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 338 AltOp            */ __Matchers[338] = new Mx.Alt(this, 338, "alt(>type-list|>spread-type)") { Builder = nodes => nodes[0] };
                /* 339 SeqOp            */ __Matchers[339] = new Mx.Seq(this, 339, "_339:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 340 StarOp           */ __Matchers[340] = new Mx.Star(this, 340, "*(_339:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 341 SeqOp            */ __Matchers[341] = new Mx.Seq(this, 341, "_341:(>type-list-type,*(_339:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 342 AltOp            */ __Matchers[342] = new Mx.Alt(this, 342, "alt(>type|>defaulted-type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 343 SeqOp            */ __Matchers[343] = new Mx.Seq(this, 343, "_343:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 344 SeqOp            */ __Matchers[344] = new Mx.Seq(this, 344, "_344:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 345 SeqOp            */ __Matchers[345] = new Mx.Seq(this, 345, "_345:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 346 SeqOp            */ __Matchers[346] = new Mx.Seq(this, 346, "_346:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 347 AltOp            */ __Matchers[347] = new Mx.Alt(this, 347, "alt(>iterable-type-zero|>iterable-type-one)") { Builder = nodes => nodes[0] };
                /* 348 SeqOp            */ __Matchers[348] = new Mx.Seq(this, 348, "_348:('{',>union-type,'*','}')") { Builder = nodes => new CIterableTypeZero(nodes) };
                /* 349 SeqOp            */ __Matchers[349] = new Mx.Seq(this, 349, "_349:('{',>union-type,'+','}')") { Builder = nodes => new CIterableTypeOne(nodes) };
                /* 350 StringOp         */ __Matchers[350] = new Mx.Keyword(this, 350, "'Nothing'", "Nothing") { Creator = node => new RLiteral(node) };
                /* 351 SeqOp            */ __Matchers[351] = new Mx.Seq(this, 351, "_351:('Nothing')") { Builder = nodes => new CNothingType(nodes) };
                /* 352 PlusOp           */ __Matchers[352] = new Mx.Plus(this, 352, "+(>parameters)") { Builder = nodes => new CMultiParameters(nodes) };
                /* 353 OptionalOp       */ __Matchers[353] = new Mx.Optional(this, 353, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 354 SeqOp            */ __Matchers[354] = new Mx.Seq(this, 354, "_354:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 355 SeqOp            */ __Matchers[355] = new Mx.Seq(this, 355, "_355:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 356 StarOp           */ __Matchers[356] = new Mx.Star(this, 356, "*(_355:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 357 SeqOp            */ __Matchers[357] = new Mx.Seq(this, 357, "_357:(>parameter,*(_355:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 358 OptionalOp       */ __Matchers[358] = new Mx.Optional(this, 358, "?(>parameter-type)") { Builder = nodes => new ROptional<ICParameterType>(nodes) };
                /* 359 OptionalOp       */ __Matchers[359] = new Mx.Optional(this, 359, "?(>value-default)") { Builder = nodes => new ROptional<CValueDefault>(nodes) };
                /* 360 SeqOp            */ __Matchers[360] = new Mx.Seq(this, 360, "_360:(>prelude,?(>parameter-type),>name,?(>value-default))") { Builder = nodes => new CValueParameter(nodes) };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:('=',>expression)") { Builder = nodes => new CValueDefault(nodes) };
                /* 362 AltOp            */ __Matchers[362] = new Mx.Alt(this, 362, "alt(>type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 363 OptionalOp       */ __Matchers[363] = new Mx.Optional(this, 363, "?(>expression-list)") { Builder = nodes => new ROptional<CExpressionList>(nodes) };
                /* 364 SeqOp            */ __Matchers[364] = new Mx.Seq(this, 364, "_364:('(',?(>expression-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 365 SeqOp            */ __Matchers[365] = new Mx.Seq(this, 365, "_365:(',',>expression)") { Builder = nodes => new RSequence(nodes) };
                /* 366 StarOp           */ __Matchers[366] = new Mx.Star(this, 366, "*(_365:(',',>expression))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 367 SeqOp            */ __Matchers[367] = new Mx.Seq(this, 367, "_367:(>expression,*(_365:(',',>expression)))") { Builder = nodes => new CExpressionList(nodes) };
                /* 368 AltOp            */ __Matchers[368] = new Mx.Alt(this, 368, "alt(>assign-statement|>expression-statement|>if-statement|>for-statement|>assert-statement|>return-statement|>throw-statement)") { Builder = nodes => nodes[0] };
                /* 369 SeqOp            */ __Matchers[369] = new Mx.Seq(this, 369, "_369:(>name,'=',>expression,';')") { Builder = nodes => new CAssignStatement(nodes) };
                /* 370 SeqOp            */ __Matchers[370] = new Mx.Seq(this, 370, "_370:(>expression,';')") { Builder = nodes => new CExpressionStatement(nodes) };
                /* 371 StringOp         */ __Matchers[371] = new Mx.Keyword(this, 371, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 372 StarOp           */ __Matchers[372] = new Mx.Star(this, 372, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 373 OptionalOp       */ __Matchers[373] = new Mx.Optional(this, 373, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 374 SeqOp            */ __Matchers[374] = new Mx.Seq(this, 374, "_374:('if',>conditions,>block-body,*(>else-if),?(>else-block))") { Builder = nodes => new CIfStatement(nodes) };
                /* 375 StringOp         */ __Matchers[375] = new Mx.Keyword(this, 375, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 376 SeqOp            */ __Matchers[376] = new Mx.Seq(this, 376, "_376:('else','if',>conditions,>block-body)") { Builder = nodes => new CElseIf(nodes) };
                /* 377 SeqOp            */ __Matchers[377] = new Mx.Seq(this, 377, "_377:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 378 StringOp         */ __Matchers[378] = new Mx.Keyword(this, 378, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:('for','(',>pattern,'in',>expression,')',>block-body,?(>else-block))") { Builder = nodes => new CForStatement(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new Mx.Keyword(this, 380, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 381 OptionalOp       */ __Matchers[381] = new Mx.Optional(this, 381, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 382 SeqOp            */ __Matchers[382] = new Mx.Seq(this, 382, "_382:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 383 StringOp         */ __Matchers[383] = new Mx.Keyword(this, 383, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 384 SeqOp            */ __Matchers[384] = new Mx.Seq(this, 384, "_384:('throw',?(>expression),';')") { Builder = nodes => new CThrowStatement(nodes) };
                /* 385 StringOp         */ __Matchers[385] = new Mx.Keyword(this, 385, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 386 SeqOp            */ __Matchers[386] = new Mx.Seq(this, 386, "_386:(?(>string-literal),'assert',>conditions,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 387 AltOp            */ __Matchers[387] = new Mx.Alt(this, 387, "alt(>if-expression|>level-coalesce-expression)") { Builder = nodes => nodes[0] };
                /* 388 AltOp            */ __Matchers[388] = new Mx.Alt(this, 388, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 389 StringOp         */ __Matchers[389] = new Mx.Keyword(this, 389, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 390 SeqOp            */ __Matchers[390] = new Mx.Seq(this, 390, "_390:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 391 SeqOp            */ __Matchers[391] = new Mx.Seq(this, 391, "_391:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 392 AltOp            */ __Matchers[392] = new Mx.Alt(this, 392, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 393 StringOp         */ __Matchers[393] = new Mx.String(this, 393, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 394 SeqOp            */ __Matchers[394] = new Mx.Seq(this, 394, "_394:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 395 AltOp            */ __Matchers[395] = new Mx.Alt(this, 395, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 396 StringOp         */ __Matchers[396] = new Mx.String(this, 396, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 397 SeqOp            */ __Matchers[397] = new Mx.Seq(this, 397, "_397:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 398 AltOp            */ __Matchers[398] = new Mx.Alt(this, 398, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 399 StringOp         */ __Matchers[399] = new Mx.String(this, 399, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 400 SeqOp            */ __Matchers[400] = new Mx.Seq(this, 400, "_400:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 401 AltOp            */ __Matchers[401] = new Mx.Alt(this, 401, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 402 StringOp         */ __Matchers[402] = new Mx.String(this, 402, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 403 SeqOp            */ __Matchers[403] = new Mx.Seq(this, 403, "_403:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 404 StringOp         */ __Matchers[404] = new Mx.String(this, 404, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 405 SeqOp            */ __Matchers[405] = new Mx.Seq(this, 405, "_405:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 406 StringOp         */ __Matchers[406] = new Mx.String(this, 406, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 407 SeqOp            */ __Matchers[407] = new Mx.Seq(this, 407, "_407:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 408 StringOp         */ __Matchers[408] = new Mx.String(this, 408, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 409 SeqOp            */ __Matchers[409] = new Mx.Seq(this, 409, "_409:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 410 AltOp            */ __Matchers[410] = new Mx.Alt(this, 410, "alt(>less-expression|>less-equal-expression|>greater-expression|>greater-equal-expression|>bounds-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 411 SeqOp            */ __Matchers[411] = new Mx.Seq(this, 411, "_411:(>level-add-expression,'<',>level-add-expression)") { Builder = nodes => new CLessExpression(nodes) };
                /* 412 StringOp         */ __Matchers[412] = new Mx.String(this, 412, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 413 SeqOp            */ __Matchers[413] = new Mx.Seq(this, 413, "_413:(>level-add-expression,'<=',>level-add-expression)") { Builder = nodes => new CLessEqualExpression(nodes) };
                /* 414 SeqOp            */ __Matchers[414] = new Mx.Seq(this, 414, "_414:(>level-add-expression,'>',>level-add-expression)") { Builder = nodes => new CGreaterExpression(nodes) };
                /* 415 StringOp         */ __Matchers[415] = new Mx.String(this, 415, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 416 SeqOp            */ __Matchers[416] = new Mx.Seq(this, 416, "_416:(>level-add-expression,'>=',>level-add-expression)") { Builder = nodes => new CGreaterEqualExpression(nodes) };
                /* 417 SeqOp            */ __Matchers[417] = new Mx.Seq(this, 417, "_417:(>lower-bound,>level-add-expression,>upper-bound)") { Builder = nodes => new CBoundsExpression(nodes) };
                /* 418 AltOp            */ __Matchers[418] = new Mx.Alt(this, 418, "alt(>lower-less-bound|>lower-less-equal-bound)") { Builder = nodes => nodes[0] };
                /* 419 SeqOp            */ __Matchers[419] = new Mx.Seq(this, 419, "_419:(>level-add-expression,'<')") { Builder = nodes => new CLowerLessBound(nodes) };
                /* 420 SeqOp            */ __Matchers[420] = new Mx.Seq(this, 420, "_420:(>level-add-expression,'<=')") { Builder = nodes => new CLowerLessEqualBound(nodes) };
                /* 421 AltOp            */ __Matchers[421] = new Mx.Alt(this, 421, "alt(>upper-less-bound|>upper-less-equal-bound)") { Builder = nodes => nodes[0] };
                /* 422 SeqOp            */ __Matchers[422] = new Mx.Seq(this, 422, "_422:('<',>level-add-expression)") { Builder = nodes => new CUpperLessBound(nodes) };
                /* 423 SeqOp            */ __Matchers[423] = new Mx.Seq(this, 423, "_423:('<=',>level-add-expression)") { Builder = nodes => new CUpperLessEqualBound(nodes) };
                /* 424 AltOp            */ __Matchers[424] = new Mx.Alt(this, 424, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 425 SeqOp            */ __Matchers[425] = new Mx.Seq(this, 425, "_425:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 426 StringOp         */ __Matchers[426] = new Mx.String(this, 426, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 427 SeqOp            */ __Matchers[427] = new Mx.Seq(this, 427, "_427:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 428 AltOp            */ __Matchers[428] = new Mx.Alt(this, 428, "alt(>mul-expression|>div-expression|>rem-expression|>level-union-expression)") { Builder = nodes => nodes[0] };
                /* 429 SeqOp            */ __Matchers[429] = new Mx.Seq(this, 429, "_429:(>level-mul-expression,'*',>level-union-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 430 StringOp         */ __Matchers[430] = new Mx.String(this, 430, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 431 SeqOp            */ __Matchers[431] = new Mx.Seq(this, 431, "_431:(>level-mul-expression,'/',>level-union-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 432 StringOp         */ __Matchers[432] = new Mx.String(this, 432, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 433 SeqOp            */ __Matchers[433] = new Mx.Seq(this, 433, "_433:(>level-mul-expression,'%',>level-union-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 434 AltOp            */ __Matchers[434] = new Mx.Alt(this, 434, "alt(>union-expression|>complement-expression|>level-exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 435 SeqOp            */ __Matchers[435] = new Mx.Seq(this, 435, "_435:(>level-union-expression,'|',>level-exclusive-expression)") { Builder = nodes => new CUnionExpression(nodes) };
                /* 436 StringOp         */ __Matchers[436] = new Mx.String(this, 436, "'~'", "~") { Creator = node => new RLiteral(node) };
                /* 437 SeqOp            */ __Matchers[437] = new Mx.Seq(this, 437, "_437:(>level-union-expression,'~',>level-exclusive-expression)") { Builder = nodes => new CComplementExpression(nodes) };
                /* 438 AltOp            */ __Matchers[438] = new Mx.Alt(this, 438, "alt(>exclusive-expression|>level-intersection-expression)") { Builder = nodes => nodes[0] };
                /* 439 StringOp         */ __Matchers[439] = new Mx.String(this, 439, "'^'", "^") { Creator = node => new RLiteral(node) };
                /* 440 SeqOp            */ __Matchers[440] = new Mx.Seq(this, 440, "_440:(>level-exclusive-expression,'^',>level-intersection-expression)") { Builder = nodes => new CExclusiveExpression(nodes) };
                /* 441 AltOp            */ __Matchers[441] = new Mx.Alt(this, 441, "alt(>intersection-expression|>level-negate-expression)") { Builder = nodes => nodes[0] };
                /* 442 SeqOp            */ __Matchers[442] = new Mx.Seq(this, 442, "_442:(>level-intersection-expression,'&',>level-negate-expression)") { Builder = nodes => new CIntersectionExpression(nodes) };
                /* 443 AltOp            */ __Matchers[443] = new Mx.Alt(this, 443, "alt(>negate-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 444 SeqOp            */ __Matchers[444] = new Mx.Seq(this, 444, "_444:('-',>level-negate-expression)") { Builder = nodes => new CNegateExpression(nodes) };
                /* 445 AltOp            */ __Matchers[445] = new Mx.Alt(this, 445, "alt(>reference|>literal|>string-expression|>call-expression|>select-expression|>nullsafe-select-expression|>grouped-expression)") { Builder = nodes => nodes[0] };
                /* 446 SeqOp            */ __Matchers[446] = new Mx.Seq(this, 446, "_446:('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Mx.Seq(this, 447, "_447:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 448 SeqOp            */ __Matchers[448] = new Mx.Seq(this, 448, "_448:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 449 StringOp         */ __Matchers[449] = new Mx.String(this, 449, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 450 SeqOp            */ __Matchers[450] = new Mx.Seq(this, 450, "_450:(>primary-expression,'?.',>reference)") { Builder = nodes => new CNullsafeSelectExpression(nodes) };
                /* 451 AltOp            */ __Matchers[451] = new Mx.Alt(this, 451, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 452 AltOp            */ __Matchers[452] = new Mx.Alt(this, 452, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 453 StarOp           */ __Matchers[453] = new Mx.Star(this, 453, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 454 SeqOp            */ __Matchers[454] = new Mx.Seq(this, 454, "_454:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 455 SeqOp            */ __Matchers[455] = new Mx.Seq(this, 455, "_455:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Mx.Seq(this, 456, "_456:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 457 SeqOp            */ __Matchers[457] = new Mx.Seq(this, 457, "_457:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 458 SeqOp            */ __Matchers[458] = new Mx.Seq(this, 458, "_458:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 459 AltOp            */ __Matchers[459] = new Mx.Alt(this, 459, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 460 SeqOp            */ __Matchers[460] = new Mx.Seq(this, 460, "_460:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Mx.Seq(this, 461, "_461:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 462 StarOp           */ __Matchers[462] = new Mx.Star(this, 462, "*(_461:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 463 SeqOp            */ __Matchers[463] = new Mx.Seq(this, 463, "_463:(>condition,*(_461:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 464 AltOp            */ __Matchers[464] = new Mx.Alt(this, 464, "alt(>is-condition|>expression)") { Builder = nodes => nodes[0] };
                /* 465 OptionalOp       */ __Matchers[465] = new Mx.Optional(this, 465, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 466 SeqOp            */ __Matchers[466] = new Mx.Seq(this, 466, "_466:(?('!'),'is',>type,>name)") { Builder = nodes => new CIsCondition(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[183]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[184]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[187]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[190]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[192]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[196]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[198]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[199]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[201]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[203]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[207]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[208]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[211]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[213]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[214]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[218]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[220]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[224]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[227]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[229]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[232]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[235]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[236]);
                /*  29 PlainRuleOp      */ _variance.Set(__Matchers[239]);
                /*  30 PlainRuleOp      */ _declarations.Set(__Matchers[240]);
                /*  31 PlainRuleOp      */ _declaration.Set(__Matchers[241]);
                /*  32 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[245]);
                /*  33 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[246]);
                /*  34 PlainRuleOp      */ _varDeclaration.Set(__Matchers[248]);
                /*  35 PlainRuleOp      */ _letDeclaration.Set(__Matchers[250]);
                /*  36 PlainRuleOp      */ _classDeclaration.Set(__Matchers[256]);
                /*  37 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[258]);
                /*  38 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[260]);
                /*  39 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[263]);
                /*  40 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[266]);
                /*  41 PlainRuleOp      */ _functionBody.Set(__Matchers[267]);
                /*  42 PlainRuleOp      */ _attributeBody.Set(__Matchers[267]);
                /*  43 PlainRuleOp      */ _blockBody.Set(__Matchers[268]);
                /*  44 PlainRuleOp      */ _statelarations.Set(__Matchers[269]);
                /*  45 PlainRuleOp      */ _statelaration.Set(__Matchers[270]);
                /*  46 PlainRuleOp      */ _expressionBody.Set(__Matchers[271]);
                /*  47 PlainRuleOp      */ _nullBody.Set(__Matchers[272]);
                /*  48 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[273]);
                /*  49 PlainRuleOp      */ _extends.Set(__Matchers[275]);
                /*  50 PlainRuleOp      */ _extendType.Set(__Matchers[276]);
                /*  51 PlainRuleOp      */ _constructor.Set(__Matchers[277]);
                /*  52 PlainRuleOp      */ _satisfies.Set(__Matchers[279]);
                /*  53 PlainRuleOp      */ _constraints.Set(__Matchers[280]);
                /*  54 PlainRuleOp      */ _constraint.Set(__Matchers[282]);
                /*  55 PlainRuleOp      */ _unionTypeList.Set(__Matchers[285]);
                /*  56 PlainRuleOp      */ _caseTypes.Set(__Matchers[287]);
                /*  57 PlainRuleOp      */ _caseTypeList.Set(__Matchers[291]);
                /*  58 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  59 PlainRuleOp      */ _namePattern.Set(__Matchers[292]);
                /*  60 PlainRuleOp      */ _prelude.Set(__Matchers[295]);
                /*  61 PlainRuleOp      */ _attribute.Set(__Matchers[297]);
                /*  62 DfaRuleOp        */ _attributeName.Set(_attributeName_DFA);
                /*  63 PlainRuleOp      */ _attributeArguments.Set(__Matchers[301]);
                /*  64 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[304]);
                /*  65 PlainRuleOp      */ _attributeArgument.Set(__Matchers[305]);
                /*  66 PlainRuleOp      */ _metaReference.Set(__Matchers[306]);
                /*  67 PlainRuleOp      */ _classReference.Set(__Matchers[307]);
                /*  68 PlainRuleOp      */ _objectReference.Set(__Matchers[308]);
                /*  69 PlainRuleOp      */ _valueReference.Set(__Matchers[310]);
                /*  70 PlainRuleOp      */ _interfaceReference.Set(__Matchers[311]);
                /*  71 PlainRuleOp      */ _functionReference.Set(__Matchers[313]);
                /*  72 PlainRuleOp      */ _type.Set(__Matchers[314]);
                /*  73 PlainRuleOp      */ _entryType.Set(__Matchers[316]);
                /*  74 PlainRuleOp      */ _variadicType.Set(__Matchers[317]);
                /*  75 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[319]);
                /*  76 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[321]);
                /*  77 PlainRuleOp      */ _unionType.Set(__Matchers[324]);
                /*  78 PlainRuleOp      */ _intersectionType.Set(__Matchers[328]);
                /*  79 PlainRuleOp      */ _primaryType.Set(__Matchers[329]);
                /*  80 PlainRuleOp      */ _nullableType.Set(__Matchers[331]);
                /*  81 PlainRuleOp      */ _sequenceType.Set(__Matchers[334]);
                /*  82 PlainRuleOp      */ _typeSelector.Set(__Matchers[335]);
                /*  83 PlainRuleOp      */ _callableType.Set(__Matchers[337]);
                /*  84 PlainRuleOp      */ _callableArguments.Set(__Matchers[338]);
                /*  85 PlainRuleOp      */ _typeList.Set(__Matchers[341]);
                /*  86 PlainRuleOp      */ _typeListType.Set(__Matchers[342]);
                /*  87 PlainRuleOp      */ _defaultedType.Set(__Matchers[343]);
                /*  88 PlainRuleOp      */ _spreadType.Set(__Matchers[344]);
                /*  89 PlainRuleOp      */ _emptyType.Set(__Matchers[345]);
                /*  90 PlainRuleOp      */ _tupleType.Set(__Matchers[346]);
                /*  91 PlainRuleOp      */ _iterableType.Set(__Matchers[347]);
                /*  92 PlainRuleOp      */ _iterableTypeZero.Set(__Matchers[348]);
                /*  93 PlainRuleOp      */ _iterableTypeOne.Set(__Matchers[349]);
                /*  94 PlainRuleOp      */ _nothingType.Set(__Matchers[351]);
                /*  95 PlainRuleOp      */ _multiParameters.Set(__Matchers[352]);
                /*  96 PlainRuleOp      */ _parameters.Set(__Matchers[354]);
                /*  97 PlainRuleOp      */ _parameterList.Set(__Matchers[357]);
                /*  98 PlainRuleOp      */ _parameter.Set(_valueParameter);
                /*  99 PlainRuleOp      */ _valueParameter.Set(__Matchers[360]);
                /* 100 PlainRuleOp      */ _valueDefault.Set(__Matchers[361]);
                /* 101 PlainRuleOp      */ _parameterType.Set(__Matchers[362]);
                /* 102 PlainRuleOp      */ _arguments.Set(__Matchers[364]);
                /* 103 PlainRuleOp      */ _expressionList.Set(__Matchers[367]);
                /* 104 PlainRuleOp      */ _statement.Set(__Matchers[368]);
                /* 105 PlainRuleOp      */ _assignStatement.Set(__Matchers[369]);
                /* 106 PlainRuleOp      */ _expressionStatement.Set(__Matchers[370]);
                /* 107 PlainRuleOp      */ _ifStatement.Set(__Matchers[374]);
                /* 108 PlainRuleOp      */ _elseIf.Set(__Matchers[376]);
                /* 109 PlainRuleOp      */ _elseBlock.Set(__Matchers[377]);
                /* 110 PlainRuleOp      */ _forStatement.Set(__Matchers[379]);
                /* 111 PlainRuleOp      */ _returnStatement.Set(__Matchers[382]);
                /* 112 PlainRuleOp      */ _throwStatement.Set(__Matchers[384]);
                /* 113 PlainRuleOp      */ _assertStatement.Set(__Matchers[386]);
                /* 114 PlainRuleOp      */ _expression.Set(__Matchers[387]);
                /* 115 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[388]);
                /* 116 PlainRuleOp      */ _thenExpression.Set(__Matchers[390]);
                /* 117 PlainRuleOp      */ _elseExpression.Set(__Matchers[391]);
                /* 118 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[392]);
                /* 119 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[394]);
                /* 120 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[395]);
                /* 121 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[397]);
                /* 122 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[398]);
                /* 123 PlainRuleOp      */ _notExpression.Set(__Matchers[400]);
                /* 124 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[401]);
                /* 125 PlainRuleOp      */ _equalExpression.Set(__Matchers[403]);
                /* 126 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[405]);
                /* 127 PlainRuleOp      */ _identicalExpression.Set(__Matchers[407]);
                /* 128 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[409]);
                /* 129 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[410]);
                /* 130 PlainRuleOp      */ _lessExpression.Set(__Matchers[411]);
                /* 131 PlainRuleOp      */ _lessEqualExpression.Set(__Matchers[413]);
                /* 132 PlainRuleOp      */ _greaterExpression.Set(__Matchers[414]);
                /* 133 PlainRuleOp      */ _greaterEqualExpression.Set(__Matchers[416]);
                /* 134 PlainRuleOp      */ _boundsExpression.Set(__Matchers[417]);
                /* 135 PlainRuleOp      */ _lowerBound.Set(__Matchers[418]);
                /* 136 PlainRuleOp      */ _lowerLessBound.Set(__Matchers[419]);
                /* 137 PlainRuleOp      */ _lowerLessEqualBound.Set(__Matchers[420]);
                /* 138 PlainRuleOp      */ _upperBound.Set(__Matchers[421]);
                /* 139 PlainRuleOp      */ _upperLessBound.Set(__Matchers[422]);
                /* 140 PlainRuleOp      */ _upperLessEqualBound.Set(__Matchers[423]);
                /* 141 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[424]);
                /* 142 PlainRuleOp      */ _addExpression.Set(__Matchers[425]);
                /* 143 PlainRuleOp      */ _subExpression.Set(__Matchers[427]);
                /* 144 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[428]);
                /* 145 PlainRuleOp      */ _mulExpression.Set(__Matchers[429]);
                /* 146 PlainRuleOp      */ _divExpression.Set(__Matchers[431]);
                /* 147 PlainRuleOp      */ _remExpression.Set(__Matchers[433]);
                /* 148 PlainRuleOp      */ _levelUnionExpression.Set(__Matchers[434]);
                /* 149 PlainRuleOp      */ _unionExpression.Set(__Matchers[435]);
                /* 150 PlainRuleOp      */ _complementExpression.Set(__Matchers[437]);
                /* 151 PlainRuleOp      */ _levelExclusiveExpression.Set(__Matchers[438]);
                /* 152 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[440]);
                /* 153 PlainRuleOp      */ _levelIntersectionExpression.Set(__Matchers[441]);
                /* 154 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[442]);
                /* 155 PlainRuleOp      */ _levelNegateExpression.Set(__Matchers[443]);
                /* 156 PlainRuleOp      */ _negateExpression.Set(__Matchers[444]);
                /* 157 PlainRuleOp      */ _primaryExpression.Set(__Matchers[445]);
                /* 158 PlainRuleOp      */ _groupedExpression.Set(__Matchers[446]);
                /* 159 PlainRuleOp      */ _callExpression.Set(__Matchers[447]);
                /* 160 PlainRuleOp      */ _selectExpression.Set(__Matchers[448]);
                /* 161 PlainRuleOp      */ _nullsafeSelectExpression.Set(__Matchers[450]);
                /* 162 PlainRuleOp      */ _literal.Set(_naturalLiteral);
                /* 163 PlainRuleOp      */ _stringExpression.Set(__Matchers[451]);
                /* 164 PlainRuleOp      */ _stringLiteral.Set(__Matchers[452]);
                /* 165 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[454]);
                /* 166 PlainRuleOp      */ _interpolationPart.Set(__Matchers[455]);
                /* 167 PlainRuleOp      */ _ifExpression.Set(__Matchers[456]);
                /* 168 PlainRuleOp      */ _ifThen.Set(__Matchers[457]);
                /* 169 PlainRuleOp      */ _ifElse.Set(__Matchers[458]);
                /* 170 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[459]);
                /* 171 PlainRuleOp      */ _conditions.Set(__Matchers[460]);
                /* 172 PlainRuleOp      */ _conditionList.Set(__Matchers[463]);
                /* 173 PlainRuleOp      */ _condition.Set(__Matchers[464]);
                /* 174 PlainRuleOp      */ _isCondition.Set(__Matchers[466]);
                /* 175 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 176 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 177 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 178 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 179 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 180 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 181 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 183 SeqOp            */ __Matchers[183].Set(_compilationUnit, __Matchers[182]);
                /* 184 AltOp            */ __Matchers[184].Set(_moduleDescriptor, _codeUnit);
                /* 186 OptionalOp       */ __Matchers[186].Set(__Matchers[185]);
                /* 187 SeqOp            */ __Matchers[187].Set(__Matchers[186], _namespace, _usings, _declarations);
                /* 190 SeqOp            */ __Matchers[190].Set(_prelude, __Matchers[188], _names, __Matchers[189]);
                /* 192 SeqOp            */ __Matchers[192].Set(__Matchers[191], _names, _moduleBody);
                /* 194 StarOp           */ __Matchers[194].Set(_moduleBodyElement);
                /* 196 SeqOp            */ __Matchers[196].Set(__Matchers[193], __Matchers[194], __Matchers[195]);
                /* 198 SeqOp            */ __Matchers[198].Set(__Matchers[197], _names, __Matchers[189]);
                /* 199 StarOp           */ __Matchers[199].Set(_usingDeclaration);
                /* 201 SeqOp            */ __Matchers[201].Set(__Matchers[200], _names, _usingElements);
                /* 202 OptionalOp       */ __Matchers[202].Set(_usingElementList);
                /* 203 SeqOp            */ __Matchers[203].Set(__Matchers[193], __Matchers[202], __Matchers[195]);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[204], _usingElement);
                /* 206 StarOp           */ __Matchers[206].Set(__Matchers[205]);
                /* 207 SeqOp            */ __Matchers[207].Set(_usingElement, __Matchers[206]);
                /* 208 AltOp            */ __Matchers[208].Set(_usingNamed, _usingWildcard);
                /* 209 OptionalOp       */ __Matchers[209].Set(_usingNameSpecifier);
                /* 210 OptionalOp       */ __Matchers[210].Set(_usingElements);
                /* 211 SeqOp            */ __Matchers[211].Set(_usingName, __Matchers[209], __Matchers[210]);
                /* 213 SeqOp            */ __Matchers[213].Set(__Matchers[212], _identifier);
                /* 216 SeqOp            */ __Matchers[216].Set(__Matchers[215], _name);
                /* 217 StarOp           */ __Matchers[217].Set(__Matchers[216]);
                /* 218 SeqOp            */ __Matchers[218].Set(_name, __Matchers[217]);
                /* 219 OptionalOp       */ __Matchers[219].Set(_genericArguments);
                /* 220 SeqOp            */ __Matchers[220].Set(_name, __Matchers[219]);
                /* 222 OptionalOp       */ __Matchers[222].Set(_genericArgumentList);
                /* 224 SeqOp            */ __Matchers[224].Set(__Matchers[221], __Matchers[222], __Matchers[223]);
                /* 225 SeqOp            */ __Matchers[225].Set(__Matchers[204], _genericArgument);
                /* 226 StarOp           */ __Matchers[226].Set(__Matchers[225]);
                /* 227 SeqOp            */ __Matchers[227].Set(_genericArgument, __Matchers[226]);
                /* 228 OptionalOp       */ __Matchers[228].Set(_genericParameterList);
                /* 229 SeqOp            */ __Matchers[229].Set(__Matchers[221], __Matchers[228], __Matchers[223]);
                /* 230 SeqOp            */ __Matchers[230].Set(__Matchers[204], _genericParameter);
                /* 231 StarOp           */ __Matchers[231].Set(__Matchers[230]);
                /* 232 SeqOp            */ __Matchers[232].Set(_genericParameter, __Matchers[231]);
                /* 233 OptionalOp       */ __Matchers[233].Set(_variance);
                /* 234 OptionalOp       */ __Matchers[234].Set(_typeDefault);
                /* 235 SeqOp            */ __Matchers[235].Set(__Matchers[233], _name, __Matchers[234]);
                /* 236 SeqOp            */ __Matchers[236].Set(__Matchers[212], _type);
                /* 239 AltOp            */ __Matchers[239].Set(__Matchers[237], __Matchers[238]);
                /* 240 StarOp           */ __Matchers[240].Set(_declaration);
                /* 241 AltOp            */ __Matchers[241].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration, _letDeclaration, _varDeclaration);
                /* 242 OptionalOp       */ __Matchers[242].Set(_type);
                /* 243 OptionalOp       */ __Matchers[243].Set(_genericParameters);
                /* 244 OptionalOp       */ __Matchers[244].Set(_constraints);
                /* 245 SeqOp            */ __Matchers[245].Set(_prelude, __Matchers[242], _name, __Matchers[243], _multiParameters, __Matchers[244], _functionBody);
                /* 246 SeqOp            */ __Matchers[246].Set(_prelude, __Matchers[242], _name, _attributeBody);
                /* 248 SeqOp            */ __Matchers[248].Set(_prelude, __Matchers[247], __Matchers[242], _name, __Matchers[212], _expression, __Matchers[189]);
                /* 250 SeqOp            */ __Matchers[250].Set(_prelude, __Matchers[249], __Matchers[242], _name, __Matchers[212], _expression, __Matchers[189]);
                /* 252 OptionalOp       */ __Matchers[252].Set(_parameters);
                /* 253 OptionalOp       */ __Matchers[253].Set(_extends);
                /* 254 OptionalOp       */ __Matchers[254].Set(_satisfies);
                /* 255 OptionalOp       */ __Matchers[255].Set(_caseTypes);
                /* 256 SeqOp            */ __Matchers[256].Set(_prelude, __Matchers[251], _name, __Matchers[243], __Matchers[252], __Matchers[253], __Matchers[254], __Matchers[255], __Matchers[244], _blockBody);
                /* 258 SeqOp            */ __Matchers[258].Set(_prelude, __Matchers[257], _name, __Matchers[243], __Matchers[252], __Matchers[254], __Matchers[255], __Matchers[244], _blockBody);
                /* 260 SeqOp            */ __Matchers[260].Set(_prelude, __Matchers[259], _name, __Matchers[253], __Matchers[254], _blockBody);
                /* 263 SeqOp            */ __Matchers[263].Set(_prelude, __Matchers[261], _name, __Matchers[243], __Matchers[244], __Matchers[262], _type, __Matchers[189]);
                /* 265 OptionalOp       */ __Matchers[265].Set(_name);
                /* 266 SeqOp            */ __Matchers[266].Set(_prelude, __Matchers[264], __Matchers[265], _parameters, __Matchers[253], _functionBody);
                /* 267 AltOp            */ __Matchers[267].Set(_expressionBody, _blockBody, _nullBody);
                /* 268 SeqOp            */ __Matchers[268].Set(__Matchers[193], _usings, _statelarations, __Matchers[195]);
                /* 269 StarOp           */ __Matchers[269].Set(_statelaration);
                /* 270 AltOp            */ __Matchers[270].Set(_statement, _declaration);
                /* 271 SeqOp            */ __Matchers[271].Set(_functionSpecifier, __Matchers[189]);
                /* 272 SeqOp            */ __Matchers[272].Set(__Matchers[189]);
                /* 273 SeqOp            */ __Matchers[273].Set(__Matchers[262], _expression);
                /* 275 SeqOp            */ __Matchers[275].Set(__Matchers[274], _extendType);
                /* 276 AltOp            */ __Matchers[276].Set(_type, _constructor);
                /* 277 SeqOp            */ __Matchers[277].Set(_primaryType, _arguments);
                /* 279 SeqOp            */ __Matchers[279].Set(__Matchers[278], _unionTypeList);
                /* 280 PlusOp           */ __Matchers[280].Set(_constraint);
                /* 282 SeqOp            */ __Matchers[282].Set(__Matchers[281], _name, __Matchers[243], __Matchers[255], __Matchers[254]);
                /* 283 SeqOp            */ __Matchers[283].Set(__Matchers[204], _type);
                /* 284 StarOp           */ __Matchers[284].Set(__Matchers[283]);
                /* 285 SeqOp            */ __Matchers[285].Set(_type, __Matchers[284]);
                /* 287 SeqOp            */ __Matchers[287].Set(__Matchers[286], _caseTypeList);
                /* 289 SeqOp            */ __Matchers[289].Set(__Matchers[288], _type);
                /* 290 StarOp           */ __Matchers[290].Set(__Matchers[289]);
                /* 291 SeqOp            */ __Matchers[291].Set(_type, __Matchers[290]);
                /* 292 SeqOp            */ __Matchers[292].Set(_name);
                /* 293 OptionalOp       */ __Matchers[293].Set(_stringLiteral);
                /* 294 StarOp           */ __Matchers[294].Set(_attribute);
                /* 295 SeqOp            */ __Matchers[295].Set(__Matchers[293], __Matchers[294]);
                /* 296 OptionalOp       */ __Matchers[296].Set(_attributeArguments);
                /* 297 SeqOp            */ __Matchers[297].Set(_attributeName, __Matchers[296]);
                /* 299 OptionalOp       */ __Matchers[299].Set(_attributeArgumentList);
                /* 301 SeqOp            */ __Matchers[301].Set(__Matchers[298], __Matchers[299], __Matchers[300]);
                /* 302 SeqOp            */ __Matchers[302].Set(__Matchers[204], _attributeArgument);
                /* 303 StarOp           */ __Matchers[303].Set(__Matchers[302]);
                /* 304 SeqOp            */ __Matchers[304].Set(_attributeArgument, __Matchers[303]);
                /* 305 AltOp            */ __Matchers[305].Set(_stringLiteral, _metaReference);
                /* 306 AltOp            */ __Matchers[306].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 307 SeqOp            */ __Matchers[307].Set(__Matchers[251], _names);
                /* 308 SeqOp            */ __Matchers[308].Set(__Matchers[259], _names);
                /* 310 SeqOp            */ __Matchers[310].Set(__Matchers[309], _names);
                /* 311 SeqOp            */ __Matchers[311].Set(__Matchers[257], _names);
                /* 313 SeqOp            */ __Matchers[313].Set(__Matchers[312], _names);
                /* 314 AltOp            */ __Matchers[314].Set(_entryType, _unionType);
                /* 316 SeqOp            */ __Matchers[316].Set(_unionType, __Matchers[315], _unionType);
                /* 317 AltOp            */ __Matchers[317].Set(_variadicTypeZero, _variadicTypeOne);
                /* 319 SeqOp            */ __Matchers[319].Set(_unionType, __Matchers[318]);
                /* 321 SeqOp            */ __Matchers[321].Set(_unionType, __Matchers[320]);
                /* 322 SeqOp            */ __Matchers[322].Set(__Matchers[288], _intersectionType);
                /* 323 StarOp           */ __Matchers[323].Set(__Matchers[322]);
                /* 324 SeqOp            */ __Matchers[324].Set(_intersectionType, __Matchers[323]);
                /* 326 SeqOp            */ __Matchers[326].Set(__Matchers[325], _primaryType);
                /* 327 StarOp           */ __Matchers[327].Set(__Matchers[326]);
                /* 328 SeqOp            */ __Matchers[328].Set(_primaryType, __Matchers[327]);
                /* 329 AltOp            */ __Matchers[329].Set(_nullableType, _sequenceType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _iterableType, _nothingType);
                /* 331 SeqOp            */ __Matchers[331].Set(_primaryType, __Matchers[330]);
                /* 334 SeqOp            */ __Matchers[334].Set(_primaryType, __Matchers[332], __Matchers[333]);
                /* 335 SeqOp            */ __Matchers[335].Set(_primaryType, __Matchers[215], _reference);
                /* 336 OptionalOp       */ __Matchers[336].Set(_callableArguments);
                /* 337 SeqOp            */ __Matchers[337].Set(_primaryType, __Matchers[298], __Matchers[336], __Matchers[300]);
                /* 338 AltOp            */ __Matchers[338].Set(_typeList, _spreadType);
                /* 339 SeqOp            */ __Matchers[339].Set(__Matchers[204], _typeListType);
                /* 340 StarOp           */ __Matchers[340].Set(__Matchers[339]);
                /* 341 SeqOp            */ __Matchers[341].Set(_typeListType, __Matchers[340]);
                /* 342 AltOp            */ __Matchers[342].Set(_type, _defaultedType, _variadicType);
                /* 343 SeqOp            */ __Matchers[343].Set(_type, __Matchers[212]);
                /* 344 SeqOp            */ __Matchers[344].Set(__Matchers[318], _unionType);
                /* 345 SeqOp            */ __Matchers[345].Set(__Matchers[332], __Matchers[333]);
                /* 346 SeqOp            */ __Matchers[346].Set(__Matchers[332], _typeList, __Matchers[333]);
                /* 347 AltOp            */ __Matchers[347].Set(_iterableTypeZero, _iterableTypeOne);
                /* 348 SeqOp            */ __Matchers[348].Set(__Matchers[193], _unionType, __Matchers[318], __Matchers[195]);
                /* 349 SeqOp            */ __Matchers[349].Set(__Matchers[193], _unionType, __Matchers[320], __Matchers[195]);
                /* 351 SeqOp            */ __Matchers[351].Set(__Matchers[350]);
                /* 352 PlusOp           */ __Matchers[352].Set(_parameters);
                /* 353 OptionalOp       */ __Matchers[353].Set(_parameterList);
                /* 354 SeqOp            */ __Matchers[354].Set(__Matchers[298], __Matchers[353], __Matchers[300]);
                /* 355 SeqOp            */ __Matchers[355].Set(__Matchers[204], _parameter);
                /* 356 StarOp           */ __Matchers[356].Set(__Matchers[355]);
                /* 357 SeqOp            */ __Matchers[357].Set(_parameter, __Matchers[356]);
                /* 358 OptionalOp       */ __Matchers[358].Set(_parameterType);
                /* 359 OptionalOp       */ __Matchers[359].Set(_valueDefault);
                /* 360 SeqOp            */ __Matchers[360].Set(_prelude, __Matchers[358], _name, __Matchers[359]);
                /* 361 SeqOp            */ __Matchers[361].Set(__Matchers[212], _expression);
                /* 362 AltOp            */ __Matchers[362].Set(_type, _variadicType);
                /* 363 OptionalOp       */ __Matchers[363].Set(_expressionList);
                /* 364 SeqOp            */ __Matchers[364].Set(__Matchers[298], __Matchers[363], __Matchers[300]);
                /* 365 SeqOp            */ __Matchers[365].Set(__Matchers[204], _expression);
                /* 366 StarOp           */ __Matchers[366].Set(__Matchers[365]);
                /* 367 SeqOp            */ __Matchers[367].Set(_expression, __Matchers[366]);
                /* 368 AltOp            */ __Matchers[368].Set(_assignStatement, _expressionStatement, _ifStatement, _forStatement, _assertStatement, _returnStatement, _throwStatement);
                /* 369 SeqOp            */ __Matchers[369].Set(_name, __Matchers[212], _expression, __Matchers[189]);
                /* 370 SeqOp            */ __Matchers[370].Set(_expression, __Matchers[189]);
                /* 372 StarOp           */ __Matchers[372].Set(_elseIf);
                /* 373 OptionalOp       */ __Matchers[373].Set(_elseBlock);
                /* 374 SeqOp            */ __Matchers[374].Set(__Matchers[371], _conditions, _blockBody, __Matchers[372], __Matchers[373]);
                /* 376 SeqOp            */ __Matchers[376].Set(__Matchers[375], __Matchers[371], _conditions, _blockBody);
                /* 377 SeqOp            */ __Matchers[377].Set(__Matchers[375], _blockBody);
                /* 379 SeqOp            */ __Matchers[379].Set(__Matchers[378], __Matchers[298], _pattern, __Matchers[237], _expression, __Matchers[300], _blockBody, __Matchers[373]);
                /* 381 OptionalOp       */ __Matchers[381].Set(_expression);
                /* 382 SeqOp            */ __Matchers[382].Set(__Matchers[380], __Matchers[381], __Matchers[189]);
                /* 384 SeqOp            */ __Matchers[384].Set(__Matchers[383], __Matchers[381], __Matchers[189]);
                /* 386 SeqOp            */ __Matchers[386].Set(__Matchers[293], __Matchers[385], _conditions, __Matchers[189]);
                /* 387 AltOp            */ __Matchers[387].Set(_ifExpression, _levelCoalesceExpression);
                /* 388 AltOp            */ __Matchers[388].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 390 SeqOp            */ __Matchers[390].Set(_levelCoalesceExpression, __Matchers[389], _levelDisjunctionExpression);
                /* 391 SeqOp            */ __Matchers[391].Set(_levelCoalesceExpression, __Matchers[375], _levelDisjunctionExpression);
                /* 392 AltOp            */ __Matchers[392].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 394 SeqOp            */ __Matchers[394].Set(_levelDisjunctionExpression, __Matchers[393], _levelConjunctionExpression);
                /* 395 AltOp            */ __Matchers[395].Set(_conjunctionExpression, _levelNotExpression);
                /* 397 SeqOp            */ __Matchers[397].Set(_levelConjunctionExpression, __Matchers[396], _levelNotExpression);
                /* 398 AltOp            */ __Matchers[398].Set(_notExpression, _levelEqualityExpression);
                /* 400 SeqOp            */ __Matchers[400].Set(__Matchers[399], _levelNotExpression);
                /* 401 AltOp            */ __Matchers[401].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 403 SeqOp            */ __Matchers[403].Set(_levelCompareExpression, __Matchers[402], _levelCompareExpression);
                /* 405 SeqOp            */ __Matchers[405].Set(_levelCompareExpression, __Matchers[404], _levelCompareExpression);
                /* 407 SeqOp            */ __Matchers[407].Set(_levelCompareExpression, __Matchers[406], _levelCompareExpression);
                /* 409 SeqOp            */ __Matchers[409].Set(_levelCompareExpression, __Matchers[408], _levelCompareExpression);
                /* 410 AltOp            */ __Matchers[410].Set(_lessExpression, _lessEqualExpression, _greaterExpression, _greaterEqualExpression, _boundsExpression, _levelAddExpression);
                /* 411 SeqOp            */ __Matchers[411].Set(_levelAddExpression, __Matchers[221], _levelAddExpression);
                /* 413 SeqOp            */ __Matchers[413].Set(_levelAddExpression, __Matchers[412], _levelAddExpression);
                /* 414 SeqOp            */ __Matchers[414].Set(_levelAddExpression, __Matchers[223], _levelAddExpression);
                /* 416 SeqOp            */ __Matchers[416].Set(_levelAddExpression, __Matchers[415], _levelAddExpression);
                /* 417 SeqOp            */ __Matchers[417].Set(_lowerBound, _levelAddExpression, _upperBound);
                /* 418 AltOp            */ __Matchers[418].Set(_lowerLessBound, _lowerLessEqualBound);
                /* 419 SeqOp            */ __Matchers[419].Set(_levelAddExpression, __Matchers[221]);
                /* 420 SeqOp            */ __Matchers[420].Set(_levelAddExpression, __Matchers[412]);
                /* 421 AltOp            */ __Matchers[421].Set(_upperLessBound, _upperLessEqualBound);
                /* 422 SeqOp            */ __Matchers[422].Set(__Matchers[221], _levelAddExpression);
                /* 423 SeqOp            */ __Matchers[423].Set(__Matchers[412], _levelAddExpression);
                /* 424 AltOp            */ __Matchers[424].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 425 SeqOp            */ __Matchers[425].Set(_levelAddExpression, __Matchers[320], _levelMulExpression);
                /* 427 SeqOp            */ __Matchers[427].Set(_levelAddExpression, __Matchers[426], _levelMulExpression);
                /* 428 AltOp            */ __Matchers[428].Set(_mulExpression, _divExpression, _remExpression, _levelUnionExpression);
                /* 429 SeqOp            */ __Matchers[429].Set(_levelMulExpression, __Matchers[318], _levelUnionExpression);
                /* 431 SeqOp            */ __Matchers[431].Set(_levelMulExpression, __Matchers[430], _levelUnionExpression);
                /* 433 SeqOp            */ __Matchers[433].Set(_levelMulExpression, __Matchers[432], _levelUnionExpression);
                /* 434 AltOp            */ __Matchers[434].Set(_unionExpression, _complementExpression, _levelExclusiveExpression);
                /* 435 SeqOp            */ __Matchers[435].Set(_levelUnionExpression, __Matchers[288], _levelExclusiveExpression);
                /* 437 SeqOp            */ __Matchers[437].Set(_levelUnionExpression, __Matchers[436], _levelExclusiveExpression);
                /* 438 AltOp            */ __Matchers[438].Set(_exclusiveExpression, _levelIntersectionExpression);
                /* 440 SeqOp            */ __Matchers[440].Set(_levelExclusiveExpression, __Matchers[439], _levelIntersectionExpression);
                /* 441 AltOp            */ __Matchers[441].Set(_intersectionExpression, _levelNegateExpression);
                /* 442 SeqOp            */ __Matchers[442].Set(_levelIntersectionExpression, __Matchers[325], _levelNegateExpression);
                /* 443 AltOp            */ __Matchers[443].Set(_negateExpression, _primaryExpression);
                /* 444 SeqOp            */ __Matchers[444].Set(__Matchers[426], _levelNegateExpression);
                /* 445 AltOp            */ __Matchers[445].Set(_reference, _literal, _stringExpression, _callExpression, _selectExpression, _nullsafeSelectExpression, _groupedExpression);
                /* 446 SeqOp            */ __Matchers[446].Set(__Matchers[298], _expression, __Matchers[300]);
                /* 447 SeqOp            */ __Matchers[447].Set(_primaryExpression, _arguments);
                /* 448 SeqOp            */ __Matchers[448].Set(_primaryExpression, __Matchers[215], _reference);
                /* 450 SeqOp            */ __Matchers[450].Set(_primaryExpression, __Matchers[449], _reference);
                /* 451 AltOp            */ __Matchers[451].Set(_stringLiteral, _stringInterpolation);
                /* 452 AltOp            */ __Matchers[452].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 453 StarOp           */ __Matchers[453].Set(_interpolationPart);
                /* 454 SeqOp            */ __Matchers[454].Set(_stringStart, _expression, __Matchers[453], _stringEnd);
                /* 455 SeqOp            */ __Matchers[455].Set(_stringMid, _expression);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[371], _conditions, _ifThen, _ifElse);
                /* 457 SeqOp            */ __Matchers[457].Set(__Matchers[389], _conditionalExpression);
                /* 458 SeqOp            */ __Matchers[458].Set(__Matchers[375], _conditionalExpression);
                /* 459 AltOp            */ __Matchers[459].Set(_ifExpression, _levelDisjunctionExpression);
                /* 460 SeqOp            */ __Matchers[460].Set(__Matchers[298], _conditionList, __Matchers[300]);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[204], _condition);
                /* 462 StarOp           */ __Matchers[462].Set(__Matchers[461]);
                /* 463 SeqOp            */ __Matchers[463].Set(_condition, __Matchers[462]);
                /* 464 AltOp            */ __Matchers[464].Set(_isCondition, _expression);
                /* 465 OptionalOp       */ __Matchers[465].Set(__Matchers[399]);
                /* 466 SeqOp            */ __Matchers[466].Set(__Matchers[465], __Matchers[278], _type, _name);

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
                    new DfaState(52, false),
                    new DfaState(53, false),
                    new DfaState(54, false),
                    new DfaState(55, false),
                    new DfaState(56, false),
                    new DfaState(57, false),
                    new DfaState(58, false),
                    new DfaState(59, false),
                    new DfaState(60, false)
                );
                _attributeName_DFA.States[0].Set(
                    new DfaTrans(_attributeName_DFA.States[1], new DfaInterval(116, 116)),
                    new DfaTrans(_attributeName_DFA.States[11], new DfaInterval(115, 115)),
                    new DfaTrans(_attributeName_DFA.States[29], new DfaInterval(110, 110)),
                    new DfaTrans(_attributeName_DFA.States[33], new DfaInterval(97, 97)),
                    new DfaTrans(_attributeName_DFA.States[47], new DfaInterval(102, 102)),
                    new DfaTrans(_attributeName_DFA.States[51], new DfaInterval(100, 100))
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
                    new DfaTrans(_attributeName_DFA.States[40], new DfaInterval(99, 99)),
                    new DfaTrans(_attributeName_DFA.States[44], new DfaInterval(108, 108))
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
                    new DfaTrans(_attributeName_DFA.States[45], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[45].Set(
                    new DfaTrans(_attributeName_DFA.States[46], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[46].Set(
                    new DfaTrans(_attributeName_DFA.States[4], new DfaInterval(115, 115))
                );
                _attributeName_DFA.States[47].Set(
                    new DfaTrans(_attributeName_DFA.States[48], new DfaInterval(111, 111)),
                    new DfaTrans(_attributeName_DFA.States[50], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[48].Set(
                    new DfaTrans(_attributeName_DFA.States[49], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[49].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(109, 109))
                );
                _attributeName_DFA.States[50].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(110, 110))
                );
                _attributeName_DFA.States[51].Set(
                    new DfaTrans(_attributeName_DFA.States[52], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[52].Set(
                    new DfaTrans(_attributeName_DFA.States[53], new DfaInterval(102, 102)),
                    new DfaTrans(_attributeName_DFA.States[56], new DfaInterval(112, 112))
                );
                _attributeName_DFA.States[53].Set(
                    new DfaTrans(_attributeName_DFA.States[54], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[54].Set(
                    new DfaTrans(_attributeName_DFA.States[55], new DfaInterval(117, 117))
                );
                _attributeName_DFA.States[55].Set(
                    new DfaTrans(_attributeName_DFA.States[39], new DfaInterval(108, 108))
                );
                _attributeName_DFA.States[56].Set(
                    new DfaTrans(_attributeName_DFA.States[57], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[57].Set(
                    new DfaTrans(_attributeName_DFA.States[58], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[58].Set(
                    new DfaTrans(_attributeName_DFA.States[59], new DfaInterval(99, 99))
                );
                _attributeName_DFA.States[59].Set(
                    new DfaTrans(_attributeName_DFA.States[60], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[60].Set(
                    new DfaTrans(_attributeName_DFA.States[4], new DfaInterval(116, 116))
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
                    new DfaState(66, true),
                    new DfaState(67, true),
                    new DfaState(68, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 77), new DfaInterval(79, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 100), new DfaInterval(103, 104), new DfaInterval(106, 107), new DfaInterval(112, 113), new DfaInterval(115, 115), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(78, 78)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[55], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[59], new DfaInterval(116, 116)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[66], new DfaInterval(119, 119))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[54].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[55].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[56], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[56].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[57], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[57].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[59].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[60], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[60].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[64], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[64].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[65], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[65].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[66].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[67], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[67].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[68], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[68].Set(
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
            private readonly Mx.PlainRule _variance;
            private readonly Mx.PlainRule _declarations;
            private readonly Mx.PlainRule _declaration;
            private readonly Mx.PlainRule _functionDeclaration;
            private readonly Mx.PlainRule _attributeDeclaration;
            private readonly Mx.PlainRule _varDeclaration;
            private readonly Mx.PlainRule _letDeclaration;
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
            private readonly Mx.PlainRule _valueDefault;
            private readonly Mx.PlainRule _parameterType;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _expressionList;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _assignStatement;
            private readonly Mx.PlainRule _expressionStatement;
            private readonly Mx.PlainRule _ifStatement;
            private readonly Mx.PlainRule _elseIf;
            private readonly Mx.PlainRule _elseBlock;
            private readonly Mx.PlainRule _forStatement;
            private readonly Mx.PlainRule _returnStatement;
            private readonly Mx.PlainRule _throwStatement;
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
            private readonly Mx.PlainRule _boundsExpression;
            private readonly Mx.PlainRule _lowerBound;
            private readonly Mx.PlainRule _lowerLessBound;
            private readonly Mx.PlainRule _lowerLessEqualBound;
            private readonly Mx.PlainRule _upperBound;
            private readonly Mx.PlainRule _upperLessBound;
            private readonly Mx.PlainRule _upperLessEqualBound;
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
            private readonly Mx.PlainRule _levelExclusiveExpression;
            private readonly Mx.PlainRule _exclusiveExpression;
            private readonly Mx.PlainRule _levelIntersectionExpression;
            private readonly Mx.PlainRule _intersectionExpression;
            private readonly Mx.PlainRule _levelNegateExpression;
            private readonly Mx.PlainRule _negateExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.PlainRule _groupedExpression;
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
            private readonly Mx.PlainRule _isCondition;
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

    public partial class SixTree
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
        public interface ICVarDeclaration : ICDeclaration {}
        public interface ICLetDeclaration : ICDeclaration {}
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
        public interface ICMetaReference : ICAttributeArgument {}
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
        public interface ICValueDefault : IRNode {}
        public interface ICParameterType : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICExpressionList : IRNode {}
        public interface ICStatement : ICStatelaration {}
        public interface ICAssignStatement : ICStatement {}
        public interface ICExpressionStatement : ICStatement {}
        public interface ICIfStatement : ICStatement {}
        public interface ICElseIf : IRNode {}
        public interface ICElseBlock : IRNode {}
        public interface ICForStatement : ICStatement {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICThrowStatement : ICStatement {}
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
        public interface ICBoundsExpression : ICLevelCompareExpression {}
        public interface ICLowerBound : IRNode {}
        public interface ICLowerLessBound : ICLowerBound {}
        public interface ICLowerLessEqualBound : ICLowerBound {}
        public interface ICUpperBound : IRNode {}
        public interface ICUpperLessBound : ICUpperBound {}
        public interface ICUpperLessEqualBound : ICUpperBound {}
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
        public interface ICLevelExclusiveExpression : ICLevelUnionExpression {}
        public interface ICExclusiveExpression : ICLevelExclusiveExpression {}
        public interface ICLevelIntersectionExpression : ICLevelExclusiveExpression {}
        public interface ICIntersectionExpression : ICLevelIntersectionExpression {}
        public interface ICLevelNegateExpression : ICLevelIntersectionExpression {}
        public interface ICNegateExpression : ICLevelNegateExpression {}
        public interface ICPrimaryExpression : ICLevelNegateExpression {}
        public interface ICGroupedExpression : ICPrimaryExpression {}
        public interface ICCallExpression : ICPrimaryExpression {}
        public interface ICSelectExpression : ICPrimaryExpression {}
        public interface ICNullsafeSelectExpression : ICPrimaryExpression {}
        public interface ICLiteral : ICPrimaryExpression {}
        public interface ICStringExpression : ICPrimaryExpression {}
        public interface ICStringLiteral : ICAttributeArgument, ICStringExpression {}
        public interface ICStringInterpolation : ICStringExpression {}
        public interface ICInterpolationPart : IRNode {}
        public interface ICIfExpression : ICConditionalExpression, ICExpression {}
        public interface ICIfThen : IRNode {}
        public interface ICIfElse : IRNode {}
        public interface ICConditionalExpression : IRNode {}
        public interface ICConditions : IRNode {}
        public interface ICConditionList : IRNode {}
        public interface ICCondition : IRNode {}
        public interface ICIsCondition : ICCondition {}
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

        public partial class CVarDeclaration : RSequence, ICVarDeclaration
        {
            // sequence
            public CVarDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'var'
            public ROptional<ICType> Type => Get<ROptional<ICType>>(2);
            public ICName Name => Get<ICName>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '='
            public ICExpression Expression => Get<ICExpression>(5);
            public RLiteral Literal3 => Get<RLiteral>(6); // ';'
        }

        public partial class CLetDeclaration : RSequence, ICLetDeclaration
        {
            // sequence
            public CLetDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'let'
            public ROptional<ICType> Type => Get<ROptional<ICType>>(2);
            public ICName Name => Get<ICName>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '='
            public ICExpression Expression => Get<ICExpression>(5);
            public RLiteral Literal3 => Get<RLiteral>(6); // ';'
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
            public CParameters Parameters => Get<CParameters>(3);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(4);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(5);
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

        public partial class CValueDefault : RSequence, ICValueDefault
        {
            // sequence
            public CValueDefault(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CArguments : RSequence, ICArguments
        {
            // sequence
            public CArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CExpressionList> ExpressionList => Get<ROptional<CExpressionList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CExpressionList : RLoop<ICExpression>, ICExpressionList
        {
            // sequence
            public CExpressionList(params RNode[] children) : base(children) {}
        }

        public partial class CAssignStatement : RSequence, ICAssignStatement
        {
            // sequence
            public CAssignStatement(params RNode[] children) : base(children) {}

            public ICName Name => Get<ICName>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '='
            public ICExpression Expression => Get<ICExpression>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
        }

        public partial class CExpressionStatement : RSequence, ICExpressionStatement
        {
            // sequence
            public CExpressionStatement(params RNode[] children) : base(children) {}

            public ICExpression Expression => Get<ICExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
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

        public partial class CThrowStatement : RSequence, ICThrowStatement
        {
            // sequence
            public CThrowStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'throw'
            public ROptional<ICExpression> Expression => Get<ROptional<ICExpression>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CAssertStatement : RSequence, ICAssertStatement
        {
            // sequence
            public CAssertStatement(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteral => Get<ROptional<ICStringLiteral>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'assert'
            public CConditions Conditions => Get<CConditions>(2);
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

        public partial class CBoundsExpression : RSequence, ICBoundsExpression
        {
            // sequence
            public CBoundsExpression(params RNode[] children) : base(children) {}

            public ICLowerBound LowerBound => Get<ICLowerBound>(0);
            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(1);
            public ICUpperBound UpperBound => Get<ICUpperBound>(2);
        }

        public partial class CLowerLessBound : RSequence, ICLowerLessBound
        {
            // sequence
            public CLowerLessBound(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<'
        }

        public partial class CLowerLessEqualBound : RSequence, ICLowerLessEqualBound
        {
            // sequence
            public CLowerLessEqualBound(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<='
        }

        public partial class CUpperLessBound : RSequence, ICUpperLessBound
        {
            // sequence
            public CUpperLessBound(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(1);
        }

        public partial class CUpperLessEqualBound : RSequence, ICUpperLessEqualBound
        {
            // sequence
            public CUpperLessEqualBound(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<='
            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(1);
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
            public ICLevelExclusiveExpression LevelExclusiveExpression => Get<ICLevelExclusiveExpression>(2);
        }

        public partial class CComplementExpression : RSequence, ICComplementExpression
        {
            // sequence
            public CComplementExpression(params RNode[] children) : base(children) {}

            public ICLevelUnionExpression LevelUnionExpression => Get<ICLevelUnionExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '~'
            public ICLevelExclusiveExpression LevelExclusiveExpression => Get<ICLevelExclusiveExpression>(2);
        }

        public partial class CExclusiveExpression : RSequence, ICExclusiveExpression
        {
            // sequence
            public CExclusiveExpression(params RNode[] children) : base(children) {}

            public ICLevelExclusiveExpression LevelExclusiveExpression => Get<ICLevelExclusiveExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '^'
            public ICLevelIntersectionExpression LevelIntersectionExpression => Get<ICLevelIntersectionExpression>(2);
        }

        public partial class CIntersectionExpression : RSequence, ICIntersectionExpression
        {
            // sequence
            public CIntersectionExpression(params RNode[] children) : base(children) {}

            public ICLevelIntersectionExpression LevelIntersectionExpression => Get<ICLevelIntersectionExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '&'
            public ICLevelNegateExpression LevelNegateExpression => Get<ICLevelNegateExpression>(2);
        }

        public partial class CNegateExpression : RSequence, ICNegateExpression
        {
            // sequence
            public CNegateExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '-'
            public ICLevelNegateExpression LevelNegateExpression => Get<ICLevelNegateExpression>(1);
        }

        public partial class CGroupedExpression : RSequence, ICGroupedExpression
        {
            // sequence
            public CGroupedExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ICExpression Expression => Get<ICExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
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

        public partial class CIsCondition : RSequence, ICIsCondition
        {
            // sequence
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'is'
            public ICType Type => Get<ICType>(2);
            public ICName Name => Get<ICName>(3);
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

        public partial class DynamicSixVisitor : DynamicVisitor
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

            protected virtual void Visit(CVarDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetDeclaration element)
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

            protected virtual void Visit(CValueDefault element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExpressionList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssignStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExpressionStatement element)
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

            protected virtual void Visit(CThrowStatement element)
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

            protected virtual void Visit(CBoundsExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLowerLessBound element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLowerLessEqualBound element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUpperLessBound element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUpperLessEqualBound element)
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

            protected virtual void Visit(CExclusiveExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNegateExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGroupedExpression element)
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

            protected virtual void Visit(CIsCondition element)
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
