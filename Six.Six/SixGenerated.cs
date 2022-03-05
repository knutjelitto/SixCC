// <generated from="D:\\Six\\Six.Six\\Six.six" at="05.03.2022 04:56:27" />

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
                : base(new Mx.Matcher[438])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new Mx.StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new Mx.WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new Mx.IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new Mx.PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _codeUnit = new Mx.PlainRule(this, 4, "code-unit") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _namespace = new Mx.PlainRule(this, 5, "namespace") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _namespaceIntro = new Mx.PlainRule(this, 6, "namespace-intro") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _moduleDescriptor = new Mx.PlainRule(this, 7, "module-descriptor") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _moduleBody = new Mx.PlainRule(this, 8, "module-body") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _moduleBodyElement = new Mx.PlainRule(this, 9, "module-body-element") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _moduleImport = new Mx.PlainRule(this, 10, "module-import") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _usings = new Mx.PlainRule(this, 11, "usings") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _usingDeclaration = new Mx.PlainRule(this, 12, "using-declaration") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _usingElements = new Mx.PlainRule(this, 13, "using-elements") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _usingElementList = new Mx.PlainRule(this, 14, "using-element-list") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _usingElement = new Mx.PlainRule(this, 15, "using-element") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _usingNamed = new Mx.PlainRule(this, 16, "using-named") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _usingName = new Mx.PlainRule(this, 17, "using-name") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _usingNameSpecifier = new Mx.PlainRule(this, 18, "using-name-specifier") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _usingWildcard = new Mx.PlainRule(this, 19, "using-wildcard") { Creator = node => new CUsingWildcard(node) };
                /*  20 PlainRuleOp      */ __Matchers[20] = _name = new Mx.PlainRule(this, 20, "name") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _names = new Mx.PlainRule(this, 21, "names") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _reference = new Mx.PlainRule(this, 22, "reference") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _genericArguments = new Mx.PlainRule(this, 23, "generic-arguments") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _genericArgumentList = new Mx.PlainRule(this, 24, "generic-argument-list") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _genericArgument = new Mx.PlainRule(this, 25, "generic-argument") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _genericParameters = new Mx.PlainRule(this, 26, "generic-parameters") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _genericParameterList = new Mx.PlainRule(this, 27, "generic-parameter-list") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _genericParameter = new Mx.PlainRule(this, 28, "generic-parameter") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _typeDefault = new Mx.PlainRule(this, 29, "type-default") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _variance = new Mx.PlainRule(this, 30, "variance") { Creator = node => new CVariance(node) };
                /*  31 PlainRuleOp      */ __Matchers[31] = _topDeclarations = new Mx.PlainRule(this, 31, "top-declarations") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _topDeclaration = new Mx.PlainRule(this, 32, "top-declaration") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _universalDeclaration = new Mx.PlainRule(this, 33, "universal-declaration") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _nestedDeclaration = new Mx.PlainRule(this, 34, "nested-declaration") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _primitiveDeclaration = new Mx.PlainRule(this, 35, "primitive-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _operatorDeclaration = new Mx.PlainRule(this, 36, "operator-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _prefixDeclaration = new Mx.PlainRule(this, 37, "prefix-declaration") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _prefixOperator = new Mx.PlainRule(this, 38, "prefix-operator") { Creator = node => new CPrefixOperator(node) };
                /*  39 PlainRuleOp      */ __Matchers[39] = _infixDeclaration = new Mx.PlainRule(this, 39, "infix-declaration") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _infixOperator = new Mx.PlainRule(this, 40, "infix-operator") { Creator = node => new CInfixOperator(node) };
                /*  41 PlainRuleOp      */ __Matchers[41] = _functionDeclaration = new Mx.PlainRule(this, 41, "function-declaration") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _attributeDeclaration = new Mx.PlainRule(this, 42, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _varDeclaration = new Mx.PlainRule(this, 43, "var-declaration") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _letDeclaration = new Mx.PlainRule(this, 44, "let-declaration") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _classDeclaration = new Mx.PlainRule(this, 45, "class-declaration") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _interfaceDeclaration = new Mx.PlainRule(this, 46, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _objectDeclaration = new Mx.PlainRule(this, 47, "object-declaration") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _aliasDeclaration = new Mx.PlainRule(this, 48, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _constructorDeclaration = new Mx.PlainRule(this, 49, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _functionBody = new Mx.PlainRule(this, 50, "function-body") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _attributeBody = new Mx.PlainRule(this, 51, "attribute-body") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _blockBody = new Mx.PlainRule(this, 52, "block-body") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _statelarations = new Mx.PlainRule(this, 53, "statelarations") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _statelaration = new Mx.PlainRule(this, 54, "statelaration") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _calcBody = new Mx.PlainRule(this, 55, "calc-body") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _valueBody = new Mx.PlainRule(this, 56, "value-body") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _nullBody = new Mx.PlainRule(this, 57, "null-body") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _builtinBody = new Mx.PlainRule(this, 58, "builtin-body") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _functionSpecifier = new Mx.PlainRule(this, 59, "function-specifier") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _valueSpecifier = new Mx.PlainRule(this, 60, "value-specifier") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _extends = new Mx.PlainRule(this, 61, "extends") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _extendType = new Mx.PlainRule(this, 62, "extend-type") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _constructor = new Mx.PlainRule(this, 63, "constructor") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _satisfies = new Mx.PlainRule(this, 64, "satisfies") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _constraints = new Mx.PlainRule(this, 65, "constraints") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _constraint = new Mx.PlainRule(this, 66, "constraint") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _unionTypeList = new Mx.PlainRule(this, 67, "union-type-list") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _caseTypes = new Mx.PlainRule(this, 68, "case-types") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _caseTypeList = new Mx.PlainRule(this, 69, "case-type-list") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _pattern = new Mx.PlainRule(this, 70, "pattern") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _namePattern = new Mx.PlainRule(this, 71, "name-pattern") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _prelude = new Mx.PlainRule(this, 72, "prelude") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _attribute = new Mx.PlainRule(this, 73, "attribute") { Builder = nodes => nodes[0] };
                /*  74 DfaRuleOp        */ __Matchers[74] = _attributeName = new Mx.DfaRule(this, 74, "attribute-name") { Creator = node => new CAttributeName(node) };
                /*  75 PlainRuleOp      */ __Matchers[75] = _type = new Mx.PlainRule(this, 75, "type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _unionType = new Mx.PlainRule(this, 76, "union-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _intersectionType = new Mx.PlainRule(this, 77, "intersection-type") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _primaryType = new Mx.PlainRule(this, 78, "primary-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _nullableType = new Mx.PlainRule(this, 79, "nullable-type") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _arrayType = new Mx.PlainRule(this, 80, "array-type") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _typeSelector = new Mx.PlainRule(this, 81, "type-selector") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _callableType = new Mx.PlainRule(this, 82, "callable-type") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _callableArguments = new Mx.PlainRule(this, 83, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _typeList = new Mx.PlainRule(this, 84, "type-list") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _typeListType = new Mx.PlainRule(this, 85, "type-list-type") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _defaultedType = new Mx.PlainRule(this, 86, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _emptyType = new Mx.PlainRule(this, 87, "empty-type") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _tupleType = new Mx.PlainRule(this, 88, "tuple-type") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _nothingType = new Mx.PlainRule(this, 89, "nothing-type") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _parameters = new Mx.PlainRule(this, 90, "parameters") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _parameterList = new Mx.PlainRule(this, 91, "parameter-list") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _parameter = new Mx.PlainRule(this, 92, "parameter") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _valueParameter = new Mx.PlainRule(this, 93, "value-parameter") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _definitiveParameter = new Mx.PlainRule(this, 94, "definitive-parameter") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _valueDefault = new Mx.PlainRule(this, 95, "value-default") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _parameterType = new Mx.PlainRule(this, 96, "parameter-type") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _arguments = new Mx.PlainRule(this, 97, "arguments") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _argumentList = new Mx.PlainRule(this, 98, "argument-list") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _statement = new Mx.PlainRule(this, 99, "statement") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _assignStatement = new Mx.PlainRule(this, 100, "assign-statement") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _expressionStatement = new Mx.PlainRule(this, 101, "expression-statement") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _ifStatement = new Mx.PlainRule(this, 102, "if-statement") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _elseIf = new Mx.PlainRule(this, 103, "else-if") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _elseBlock = new Mx.PlainRule(this, 104, "else-block") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _forStatement = new Mx.PlainRule(this, 105, "for-statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _whileStatement = new Mx.PlainRule(this, 106, "while-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _returnStatement = new Mx.PlainRule(this, 107, "return-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _throwStatement = new Mx.PlainRule(this, 108, "throw-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _assertStatement = new Mx.PlainRule(this, 109, "assert-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _expression = new Mx.PlainRule(this, 110, "expression") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _levelCoalesceExpression = new Mx.PlainRule(this, 111, "level-coalesce-expression") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _thenExpression = new Mx.PlainRule(this, 112, "then-expression") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _elseExpression = new Mx.PlainRule(this, 113, "else-expression") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _levelDisjunctionExpression = new Mx.PlainRule(this, 114, "level-disjunction-expression") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _disjunctionExpression = new Mx.PlainRule(this, 115, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _levelConjunctionExpression = new Mx.PlainRule(this, 116, "level-conjunction-expression") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _conjunctionExpression = new Mx.PlainRule(this, 117, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _levelNotExpression = new Mx.PlainRule(this, 118, "level-not-expression") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _notExpression = new Mx.PlainRule(this, 119, "not-expression") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _levelEqualityExpression = new Mx.PlainRule(this, 120, "level-equality-expression") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _equalExpression = new Mx.PlainRule(this, 121, "equal-expression") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _notEqualExpression = new Mx.PlainRule(this, 122, "not-equal-expression") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _identicalExpression = new Mx.PlainRule(this, 123, "identical-expression") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _notIdenticalExpression = new Mx.PlainRule(this, 124, "not-identical-expression") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _levelCompareExpression = new Mx.PlainRule(this, 125, "level-compare-expression") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _lessExpression = new Mx.PlainRule(this, 126, "less-expression") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _lessEqualExpression = new Mx.PlainRule(this, 127, "less-equal-expression") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _greaterExpression = new Mx.PlainRule(this, 128, "greater-expression") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _greaterEqualExpression = new Mx.PlainRule(this, 129, "greater-equal-expression") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _levelAddExpression = new Mx.PlainRule(this, 130, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _addExpression = new Mx.PlainRule(this, 131, "add-expression") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _subExpression = new Mx.PlainRule(this, 132, "sub-expression") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _levelMulExpression = new Mx.PlainRule(this, 133, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _mulExpression = new Mx.PlainRule(this, 134, "mul-expression") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _divExpression = new Mx.PlainRule(this, 135, "div-expression") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _remExpression = new Mx.PlainRule(this, 136, "rem-expression") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _levelUnionExpression = new Mx.PlainRule(this, 137, "level-union-expression") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _unionExpression = new Mx.PlainRule(this, 138, "union-expression") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _complementExpression = new Mx.PlainRule(this, 139, "complement-expression") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _levelExclusiveExpression = new Mx.PlainRule(this, 140, "level-exclusive-expression") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _exclusiveExpression = new Mx.PlainRule(this, 141, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _levelIntersectionExpression = new Mx.PlainRule(this, 142, "level-intersection-expression") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _intersectionExpression = new Mx.PlainRule(this, 143, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _levelNegateExpression = new Mx.PlainRule(this, 144, "level-negate-expression") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _negateExpression = new Mx.PlainRule(this, 145, "negate-expression") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _primaryExpression = new Mx.PlainRule(this, 146, "primary-expression") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _groupedExpression = new Mx.PlainRule(this, 147, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _callExpression = new Mx.PlainRule(this, 148, "call-expression") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _selectExpression = new Mx.PlainRule(this, 149, "select-expression") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _nullsafeSelectExpression = new Mx.PlainRule(this, 150, "nullsafe-select-expression") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _literal = new Mx.PlainRule(this, 151, "literal") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _stringExpression = new Mx.PlainRule(this, 152, "string-expression") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _stringLiteral = new Mx.PlainRule(this, 153, "string-literal") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _stringInterpolation = new Mx.PlainRule(this, 154, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _interpolationPart = new Mx.PlainRule(this, 155, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _ifExpression = new Mx.PlainRule(this, 156, "if-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _ifThen = new Mx.PlainRule(this, 157, "if-then") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _ifElse = new Mx.PlainRule(this, 158, "if-else") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _conditionalExpression = new Mx.PlainRule(this, 159, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _conditions = new Mx.PlainRule(this, 160, "conditions") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _conditionList = new Mx.PlainRule(this, 161, "condition-list") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _condition = new Mx.PlainRule(this, 162, "condition") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _isCondition = new Mx.PlainRule(this, 163, "is-condition") { Builder = nodes => nodes[0] };
                /* 164 DfaRuleOp        */ __Matchers[164] = _naturalLiteral = new Mx.DfaRule(this, 164, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 165 DfaRuleOp        */ __Matchers[165] = _stringStart = new Mx.DfaRule(this, 165, "string-start") { Creator = node => new CStringStart(node) };
                /* 166 DfaRuleOp        */ __Matchers[166] = _stringMid = new Mx.DfaRule(this, 166, "string-mid") { Creator = node => new CStringMid(node) };
                /* 167 DfaRuleOp        */ __Matchers[167] = _stringEnd = new Mx.DfaRule(this, 167, "string-end") { Creator = node => new CStringEnd(node) };
                /* 168 DfaRuleOp        */ __Matchers[168] = _plainStringLiteral = new Mx.DfaRule(this, 168, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 169 DfaRuleOp        */ __Matchers[169] = _verbatimStringLiteral = new Mx.DfaRule(this, 169, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 170 DfaRuleOp        */ __Matchers[170] = _identifier = new Mx.DfaRule(this, 170, "identifier") { Creator = node => new CIdentifier(node) };
                /* 171 EofOp            */ __Matchers[171] = new Mx.Eof(this, 171, "<eof>") { Creator = node => new REof(node) };
                /* 172 SeqOp            */ __Matchers[172] = new Mx.Seq(this, 172, "_172:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 173 AltOp            */ __Matchers[173] = new Mx.Alt(this, 173, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 174 SeqOp            */ __Matchers[174] = new Mx.Seq(this, 174, "_174:(>namespace-intro,>usings,>top-declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 175 StringOp         */ __Matchers[175] = new Mx.Keyword(this, 175, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 176 StringOp         */ __Matchers[176] = new Mx.String(this, 176, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 177 SeqOp            */ __Matchers[177] = new Mx.Seq(this, 177, "_177:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 178 SeqOp            */ __Matchers[178] = new Mx.Seq(this, 178, "_178:('namespace',>names,';')") { Builder = nodes => new CNamespaceIntro(nodes) };
                /* 179 StringOp         */ __Matchers[179] = new Mx.Keyword(this, 179, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 180 StarOp           */ __Matchers[180] = new Mx.Star(this, 180, "*(>namespace)") { Builder = nodes => new RStar<CNamespace>(nodes) };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:(>prelude,'module',>names,>module-body,*(>namespace))") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 182 StringOp         */ __Matchers[182] = new Mx.String(this, 182, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 183 StarOp           */ __Matchers[183] = new Mx.Star(this, 183, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 184 StringOp         */ __Matchers[184] = new Mx.String(this, 184, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 185 SeqOp            */ __Matchers[185] = new Mx.Seq(this, 185, "_185:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 186 StringOp         */ __Matchers[186] = new Mx.Keyword(this, 186, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 187 SeqOp            */ __Matchers[187] = new Mx.Seq(this, 187, "_187:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 188 StarOp           */ __Matchers[188] = new Mx.Star(this, 188, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.Keyword(this, 189, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 191 OptionalOp       */ __Matchers[191] = new Mx.Optional(this, 191, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 193 StringOp         */ __Matchers[193] = new Mx.String(this, 193, "','", ",") { Creator = node => new RLiteral(node) };
                /* 194 SeqOp            */ __Matchers[194] = new Mx.Seq(this, 194, "_194:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 195 StarOp           */ __Matchers[195] = new Mx.Star(this, 195, "*(_194:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:(>using-element,*(_194:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 197 AltOp            */ __Matchers[197] = new Mx.Alt(this, 197, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 198 OptionalOp       */ __Matchers[198] = new Mx.Optional(this, 198, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 199 OptionalOp       */ __Matchers[199] = new Mx.Optional(this, 199, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 201 StringOp         */ __Matchers[201] = new Mx.String(this, 201, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 202 SeqOp            */ __Matchers[202] = new Mx.Seq(this, 202, "_202:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 203 StringOp         */ __Matchers[203] = new Mx.String(this, 203, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 204 StringOp         */ __Matchers[204] = new Mx.String(this, 204, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 206 StarOp           */ __Matchers[206] = new Mx.Star(this, 206, "*(_205:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:(>name,*(_205:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 208 OptionalOp       */ __Matchers[208] = new Mx.Optional(this, 208, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 209 SeqOp            */ __Matchers[209] = new Mx.Seq(this, 209, "_209:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 210 StringOp         */ __Matchers[210] = new Mx.String(this, 210, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 211 OptionalOp       */ __Matchers[211] = new Mx.Optional(this, 211, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 212 StringOp         */ __Matchers[212] = new Mx.String(this, 212, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 213 SeqOp            */ __Matchers[213] = new Mx.Seq(this, 213, "_213:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 214 SeqOp            */ __Matchers[214] = new Mx.Seq(this, 214, "_214:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 215 StarOp           */ __Matchers[215] = new Mx.Star(this, 215, "*(_214:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 216 SeqOp            */ __Matchers[216] = new Mx.Seq(this, 216, "_216:(>generic-argument,*(_214:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 217 OptionalOp       */ __Matchers[217] = new Mx.Optional(this, 217, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 218 SeqOp            */ __Matchers[218] = new Mx.Seq(this, 218, "_218:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 220 StarOp           */ __Matchers[220] = new Mx.Star(this, 220, "*(_219:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:(>generic-parameter,*(_219:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 222 OptionalOp       */ __Matchers[222] = new Mx.Optional(this, 222, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 223 OptionalOp       */ __Matchers[223] = new Mx.Optional(this, 223, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 225 SeqOp            */ __Matchers[225] = new Mx.Seq(this, 225, "_225:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 226 StringOp         */ __Matchers[226] = new Mx.Keyword(this, 226, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 227 StringOp         */ __Matchers[227] = new Mx.Keyword(this, 227, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 228 AltOp            */ __Matchers[228] = new Mx.Alt(this, 228, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 229 StarOp           */ __Matchers[229] = new Mx.Star(this, 229, "*(>top-declaration)") { Builder = nodes => new CTopDeclarations(nodes) };
                /* 230 AltOp            */ __Matchers[230] = new Mx.Alt(this, 230, "alt(>primitive-declaration|>universal-declaration)") { Builder = nodes => nodes[0] };
                /* 231 AltOp            */ __Matchers[231] = new Mx.Alt(this, 231, "alt(>function-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 232 AltOp            */ __Matchers[232] = new Mx.Alt(this, 232, "alt(>universal-declaration|>constructor-declaration|>let-declaration|>var-declaration|>operator-declaration)") { Builder = nodes => nodes[0] };
                /* 233 StringOp         */ __Matchers[233] = new Mx.Keyword(this, 233, "'builtin'", "builtin") { Creator = node => new RLiteral(node) };
                /* 234 OptionalOp       */ __Matchers[234] = new Mx.Optional(this, 234, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:(>prelude,'builtin',>name,?(>case-types),>block-body)") { Builder = nodes => new CPrimitiveDeclaration(nodes) };
                /* 236 AltOp            */ __Matchers[236] = new Mx.Alt(this, 236, "alt(>prefix-declaration|>infix-declaration)") { Builder = nodes => nodes[0] };
                /* 237 StringOp         */ __Matchers[237] = new Mx.Keyword(this, 237, "'prefix'", "prefix") { Creator = node => new RLiteral(node) };
                /* 238 StringOp         */ __Matchers[238] = new Mx.String(this, 238, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 239 StringOp         */ __Matchers[239] = new Mx.String(this, 239, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:(>prelude,'prefix',>type,>prefix-operator,'(',')',>function-body)") { Builder = nodes => new CPrefixDeclaration(nodes) };
                /* 241 StringOp         */ __Matchers[241] = new Mx.String(this, 241, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 242 StringOp         */ __Matchers[242] = new Mx.String(this, 242, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 243 AltOp            */ __Matchers[243] = new Mx.Alt(this, 243, "alt('-'|'!')") { Builder = nodes => nodes[0] };
                /* 244 StringOp         */ __Matchers[244] = new Mx.Keyword(this, 244, "'infix'", "infix") { Creator = node => new RLiteral(node) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:(>prelude,'infix',>type,>infix-operator,'(',>definitive-parameter,')',>function-body)") { Builder = nodes => new CInfixDeclaration(nodes) };
                /* 246 StringOp         */ __Matchers[246] = new Mx.String(this, 246, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 247 StringOp         */ __Matchers[247] = new Mx.String(this, 247, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 248 StringOp         */ __Matchers[248] = new Mx.String(this, 248, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.String(this, 249, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 250 StringOp         */ __Matchers[250] = new Mx.String(this, 250, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 251 StringOp         */ __Matchers[251] = new Mx.String(this, 251, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 252 StringOp         */ __Matchers[252] = new Mx.String(this, 252, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 253 StringOp         */ __Matchers[253] = new Mx.String(this, 253, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 254 StringOp         */ __Matchers[254] = new Mx.String(this, 254, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 255 StringOp         */ __Matchers[255] = new Mx.String(this, 255, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 256 StringOp         */ __Matchers[256] = new Mx.String(this, 256, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 257 StringOp         */ __Matchers[257] = new Mx.String(this, 257, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 258 StringOp         */ __Matchers[258] = new Mx.String(this, 258, "'^'", "^") { Creator = node => new RLiteral(node) };
                /* 259 AltOp            */ __Matchers[259] = new Mx.Alt(this, 259, "alt('+'|'-'|'*'|'/'|'%'|'<'|'<='|'>'|'>='|'=='|'!='|'==='|'!=='|'|'|'&'|'^')") { Builder = nodes => nodes[0] };
                /* 260 OptionalOp       */ __Matchers[260] = new Mx.Optional(this, 260, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 261 OptionalOp       */ __Matchers[261] = new Mx.Optional(this, 261, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 262 SeqOp            */ __Matchers[262] = new Mx.Seq(this, 262, "_262:(>prelude,>type,>name,?(>generic-parameters),>parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 263 SeqOp            */ __Matchers[263] = new Mx.Seq(this, 263, "_263:(>prelude,>type,>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 264 StringOp         */ __Matchers[264] = new Mx.Keyword(this, 264, "'var'", "var") { Creator = node => new RLiteral(node) };
                /* 265 OptionalOp       */ __Matchers[265] = new Mx.Optional(this, 265, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 266 SeqOp            */ __Matchers[266] = new Mx.Seq(this, 266, "_266:(>prelude,'var',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CVarDeclaration(nodes) };
                /* 267 StringOp         */ __Matchers[267] = new Mx.Keyword(this, 267, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 268 SeqOp            */ __Matchers[268] = new Mx.Seq(this, 268, "_268:(>prelude,'let',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CLetDeclaration(nodes) };
                /* 269 StringOp         */ __Matchers[269] = new Mx.Keyword(this, 269, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 270 OptionalOp       */ __Matchers[270] = new Mx.Optional(this, 270, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 271 OptionalOp       */ __Matchers[271] = new Mx.Optional(this, 271, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 272 SeqOp            */ __Matchers[272] = new Mx.Seq(this, 272, "_272:(>prelude,'class',>name,?(>generic-parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 273 StringOp         */ __Matchers[273] = new Mx.Keyword(this, 273, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:(>prelude,'interface',>name,?(>generic-parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 275 StringOp         */ __Matchers[275] = new Mx.Keyword(this, 275, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 277 StringOp         */ __Matchers[277] = new Mx.Keyword(this, 277, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 278 StringOp         */ __Matchers[278] = new Mx.String(this, 278, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 279 SeqOp            */ __Matchers[279] = new Mx.Seq(this, 279, "_279:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 280 StringOp         */ __Matchers[280] = new Mx.Keyword(this, 280, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 281 OptionalOp       */ __Matchers[281] = new Mx.Optional(this, 281, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:(>prelude,'new',?(>name),>parameters,?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 283 AltOp            */ __Matchers[283] = new Mx.Alt(this, 283, "alt(>calc-body|>block-body|>null-body|>builtin-body)") { Builder = nodes => nodes[0] };
                /* 284 AltOp            */ __Matchers[284] = new Mx.Alt(this, 284, "alt(>calc-body|>value-body|>block-body|>null-body|>builtin-body)") { Builder = nodes => nodes[0] };
                /* 285 SeqOp            */ __Matchers[285] = new Mx.Seq(this, 285, "_285:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 286 StarOp           */ __Matchers[286] = new Mx.Star(this, 286, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 287 AltOp            */ __Matchers[287] = new Mx.Alt(this, 287, "alt(>statement|>nested-declaration)") { Builder = nodes => nodes[0] };
                /* 288 SeqOp            */ __Matchers[288] = new Mx.Seq(this, 288, "_288:(>function-specifier,';')") { Builder = nodes => new CCalcBody(nodes) };
                /* 289 SeqOp            */ __Matchers[289] = new Mx.Seq(this, 289, "_289:(>value-specifier,';')") { Builder = nodes => new CValueBody(nodes) };
                /* 290 SeqOp            */ __Matchers[290] = new Mx.Seq(this, 290, "_290:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 291 SeqOp            */ __Matchers[291] = new Mx.Seq(this, 291, "_291:('=>','builtin',';')") { Builder = nodes => new CBuiltinBody(nodes) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 293 SeqOp            */ __Matchers[293] = new Mx.Seq(this, 293, "_293:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 294 StringOp         */ __Matchers[294] = new Mx.String(this, 294, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:(':',>extend-type)") { Builder = nodes => new CExtends(nodes) };
                /* 296 AltOp            */ __Matchers[296] = new Mx.Alt(this, 296, "alt(>type|>constructor)") { Builder = nodes => nodes[0] };
                /* 297 SeqOp            */ __Matchers[297] = new Mx.Seq(this, 297, "_297:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 298 StringOp         */ __Matchers[298] = new Mx.Keyword(this, 298, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 299 SeqOp            */ __Matchers[299] = new Mx.Seq(this, 299, "_299:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 300 PlusOp           */ __Matchers[300] = new Mx.Plus(this, 300, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 301 StringOp         */ __Matchers[301] = new Mx.Keyword(this, 301, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 303 SeqOp            */ __Matchers[303] = new Mx.Seq(this, 303, "_303:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 304 StarOp           */ __Matchers[304] = new Mx.Star(this, 304, "*(_303:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 305 SeqOp            */ __Matchers[305] = new Mx.Seq(this, 305, "_305:(>type,*(_303:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 306 StringOp         */ __Matchers[306] = new Mx.Keyword(this, 306, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 308 SeqOp            */ __Matchers[308] = new Mx.Seq(this, 308, "_308:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 309 StarOp           */ __Matchers[309] = new Mx.Star(this, 309, "*(_308:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 310 SeqOp            */ __Matchers[310] = new Mx.Seq(this, 310, "_310:(>type,*(_308:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 311 SeqOp            */ __Matchers[311] = new Mx.Seq(this, 311, "_311:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 312 OptionalOp       */ __Matchers[312] = new Mx.Optional(this, 312, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 313 StarOp           */ __Matchers[313] = new Mx.Star(this, 313, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 314 SeqOp            */ __Matchers[314] = new Mx.Seq(this, 314, "_314:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 315 OptionalOp       */ __Matchers[315] = new Mx.Optional(this, 315, "?(>arguments)") { Builder = nodes => new ROptional<CArguments>(nodes) };
                /* 316 SeqOp            */ __Matchers[316] = new Mx.Seq(this, 316, "_316:(>attribute-name,?(>arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 317 SeqOp            */ __Matchers[317] = new Mx.Seq(this, 317, "_317:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 318 StarOp           */ __Matchers[318] = new Mx.Star(this, 318, "*(_317:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 319 SeqOp            */ __Matchers[319] = new Mx.Seq(this, 319, "_319:(>intersection-type,*(_317:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 320 SeqOp            */ __Matchers[320] = new Mx.Seq(this, 320, "_320:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 321 StarOp           */ __Matchers[321] = new Mx.Star(this, 321, "*(_320:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 322 SeqOp            */ __Matchers[322] = new Mx.Seq(this, 322, "_322:(>primary-type,*(_320:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 323 AltOp            */ __Matchers[323] = new Mx.Alt(this, 323, "alt(>nullable-type|>array-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>nothing-type)") { Builder = nodes => nodes[0] };
                /* 324 StringOp         */ __Matchers[324] = new Mx.String(this, 324, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 325 SeqOp            */ __Matchers[325] = new Mx.Seq(this, 325, "_325:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 326 StringOp         */ __Matchers[326] = new Mx.String(this, 326, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 327 StringOp         */ __Matchers[327] = new Mx.String(this, 327, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 328 SeqOp            */ __Matchers[328] = new Mx.Seq(this, 328, "_328:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 329 SeqOp            */ __Matchers[329] = new Mx.Seq(this, 329, "_329:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 330 OptionalOp       */ __Matchers[330] = new Mx.Optional(this, 330, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 331 SeqOp            */ __Matchers[331] = new Mx.Seq(this, 331, "_331:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 332 SeqOp            */ __Matchers[332] = new Mx.Seq(this, 332, "_332:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 333 StarOp           */ __Matchers[333] = new Mx.Star(this, 333, "*(_332:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 334 SeqOp            */ __Matchers[334] = new Mx.Seq(this, 334, "_334:(>type-list-type,*(_332:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 335 AltOp            */ __Matchers[335] = new Mx.Alt(this, 335, "alt(>type|>defaulted-type)") { Builder = nodes => nodes[0] };
                /* 336 SeqOp            */ __Matchers[336] = new Mx.Seq(this, 336, "_336:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 337 SeqOp            */ __Matchers[337] = new Mx.Seq(this, 337, "_337:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 338 SeqOp            */ __Matchers[338] = new Mx.Seq(this, 338, "_338:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 339 StringOp         */ __Matchers[339] = new Mx.Keyword(this, 339, "'Nothing'", "Nothing") { Creator = node => new RLiteral(node) };
                /* 340 SeqOp            */ __Matchers[340] = new Mx.Seq(this, 340, "_340:('Nothing')") { Builder = nodes => new CNothingType(nodes) };
                /* 341 OptionalOp       */ __Matchers[341] = new Mx.Optional(this, 341, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 342 SeqOp            */ __Matchers[342] = new Mx.Seq(this, 342, "_342:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 343 SeqOp            */ __Matchers[343] = new Mx.Seq(this, 343, "_343:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 344 StarOp           */ __Matchers[344] = new Mx.Star(this, 344, "*(_343:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 345 SeqOp            */ __Matchers[345] = new Mx.Seq(this, 345, "_345:(>parameter,*(_343:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 346 OptionalOp       */ __Matchers[346] = new Mx.Optional(this, 346, "?(>value-default)") { Builder = nodes => new ROptional<CValueDefault>(nodes) };
                /* 347 SeqOp            */ __Matchers[347] = new Mx.Seq(this, 347, "_347:(>prelude,>parameter-type,>name,?(>value-default))") { Builder = nodes => new CValueParameter(nodes) };
                /* 348 SeqOp            */ __Matchers[348] = new Mx.Seq(this, 348, "_348:(>prelude,>parameter-type,>name)") { Builder = nodes => new CDefinitiveParameter(nodes) };
                /* 349 SeqOp            */ __Matchers[349] = new Mx.Seq(this, 349, "_349:('=',>expression)") { Builder = nodes => new CValueDefault(nodes) };
                /* 350 OptionalOp       */ __Matchers[350] = new Mx.Optional(this, 350, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 351 SeqOp            */ __Matchers[351] = new Mx.Seq(this, 351, "_351:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 352 SeqOp            */ __Matchers[352] = new Mx.Seq(this, 352, "_352:(',',>expression)") { Builder = nodes => new RSequence(nodes) };
                /* 353 StarOp           */ __Matchers[353] = new Mx.Star(this, 353, "*(_352:(',',>expression))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 354 SeqOp            */ __Matchers[354] = new Mx.Seq(this, 354, "_354:(>expression,*(_352:(',',>expression)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 355 AltOp            */ __Matchers[355] = new Mx.Alt(this, 355, "alt(>assign-statement|>expression-statement|>if-statement|>for-statement|>while-statement|>assert-statement|>return-statement|>throw-statement)") { Builder = nodes => nodes[0] };
                /* 356 SeqOp            */ __Matchers[356] = new Mx.Seq(this, 356, "_356:(>primary-expression,'=',>expression,';')") { Builder = nodes => new CAssignStatement(nodes) };
                /* 357 SeqOp            */ __Matchers[357] = new Mx.Seq(this, 357, "_357:(>expression,';')") { Builder = nodes => new CExpressionStatement(nodes) };
                /* 358 StringOp         */ __Matchers[358] = new Mx.Keyword(this, 358, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 359 StarOp           */ __Matchers[359] = new Mx.Star(this, 359, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 360 OptionalOp       */ __Matchers[360] = new Mx.Optional(this, 360, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:('if',>conditions,>block-body,*(>else-if),?(>else-block))") { Builder = nodes => new CIfStatement(nodes) };
                /* 362 StringOp         */ __Matchers[362] = new Mx.Keyword(this, 362, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 363 SeqOp            */ __Matchers[363] = new Mx.Seq(this, 363, "_363:('else','if',>conditions,>block-body)") { Builder = nodes => new CElseIf(nodes) };
                /* 364 SeqOp            */ __Matchers[364] = new Mx.Seq(this, 364, "_364:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 365 StringOp         */ __Matchers[365] = new Mx.Keyword(this, 365, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 366 SeqOp            */ __Matchers[366] = new Mx.Seq(this, 366, "_366:('for','(',>pattern,'in',>expression,')',>block-body,?(>else-block))") { Builder = nodes => new CForStatement(nodes) };
                /* 367 StringOp         */ __Matchers[367] = new Mx.Keyword(this, 367, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 368 SeqOp            */ __Matchers[368] = new Mx.Seq(this, 368, "_368:('while',>conditions,>block-body)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 369 StringOp         */ __Matchers[369] = new Mx.Keyword(this, 369, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 370 OptionalOp       */ __Matchers[370] = new Mx.Optional(this, 370, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 371 SeqOp            */ __Matchers[371] = new Mx.Seq(this, 371, "_371:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 372 StringOp         */ __Matchers[372] = new Mx.Keyword(this, 372, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 373 SeqOp            */ __Matchers[373] = new Mx.Seq(this, 373, "_373:('throw',?(>expression),';')") { Builder = nodes => new CThrowStatement(nodes) };
                /* 374 StringOp         */ __Matchers[374] = new Mx.Keyword(this, 374, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 375 SeqOp            */ __Matchers[375] = new Mx.Seq(this, 375, "_375:(?(>string-literal),'assert',>conditions,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 376 AltOp            */ __Matchers[376] = new Mx.Alt(this, 376, "alt(>if-expression|>level-coalesce-expression)") { Builder = nodes => nodes[0] };
                /* 377 AltOp            */ __Matchers[377] = new Mx.Alt(this, 377, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 378 StringOp         */ __Matchers[378] = new Mx.Keyword(this, 378, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 380 SeqOp            */ __Matchers[380] = new Mx.Seq(this, 380, "_380:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 381 AltOp            */ __Matchers[381] = new Mx.Alt(this, 381, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 382 StringOp         */ __Matchers[382] = new Mx.String(this, 382, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 383 SeqOp            */ __Matchers[383] = new Mx.Seq(this, 383, "_383:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 384 AltOp            */ __Matchers[384] = new Mx.Alt(this, 384, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 385 StringOp         */ __Matchers[385] = new Mx.String(this, 385, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 386 SeqOp            */ __Matchers[386] = new Mx.Seq(this, 386, "_386:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 387 AltOp            */ __Matchers[387] = new Mx.Alt(this, 387, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 388 SeqOp            */ __Matchers[388] = new Mx.Seq(this, 388, "_388:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 389 AltOp            */ __Matchers[389] = new Mx.Alt(this, 389, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 390 SeqOp            */ __Matchers[390] = new Mx.Seq(this, 390, "_390:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 391 SeqOp            */ __Matchers[391] = new Mx.Seq(this, 391, "_391:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 392 SeqOp            */ __Matchers[392] = new Mx.Seq(this, 392, "_392:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 393 SeqOp            */ __Matchers[393] = new Mx.Seq(this, 393, "_393:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 394 AltOp            */ __Matchers[394] = new Mx.Alt(this, 394, "alt(>less-expression|>less-equal-expression|>greater-expression|>greater-equal-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 395 SeqOp            */ __Matchers[395] = new Mx.Seq(this, 395, "_395:(>level-add-expression,'<',>level-add-expression)") { Builder = nodes => new CLessExpression(nodes) };
                /* 396 SeqOp            */ __Matchers[396] = new Mx.Seq(this, 396, "_396:(>level-add-expression,'<=',>level-add-expression)") { Builder = nodes => new CLessEqualExpression(nodes) };
                /* 397 SeqOp            */ __Matchers[397] = new Mx.Seq(this, 397, "_397:(>level-add-expression,'>',>level-add-expression)") { Builder = nodes => new CGreaterExpression(nodes) };
                /* 398 SeqOp            */ __Matchers[398] = new Mx.Seq(this, 398, "_398:(>level-add-expression,'>=',>level-add-expression)") { Builder = nodes => new CGreaterEqualExpression(nodes) };
                /* 399 AltOp            */ __Matchers[399] = new Mx.Alt(this, 399, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 400 SeqOp            */ __Matchers[400] = new Mx.Seq(this, 400, "_400:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 401 SeqOp            */ __Matchers[401] = new Mx.Seq(this, 401, "_401:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 402 AltOp            */ __Matchers[402] = new Mx.Alt(this, 402, "alt(>mul-expression|>div-expression|>rem-expression|>level-union-expression)") { Builder = nodes => nodes[0] };
                /* 403 SeqOp            */ __Matchers[403] = new Mx.Seq(this, 403, "_403:(>level-mul-expression,'*',>level-union-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 404 SeqOp            */ __Matchers[404] = new Mx.Seq(this, 404, "_404:(>level-mul-expression,'/',>level-union-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 405 SeqOp            */ __Matchers[405] = new Mx.Seq(this, 405, "_405:(>level-mul-expression,'%',>level-union-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 406 AltOp            */ __Matchers[406] = new Mx.Alt(this, 406, "alt(>union-expression|>complement-expression|>level-exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 407 SeqOp            */ __Matchers[407] = new Mx.Seq(this, 407, "_407:(>level-union-expression,'|',>level-exclusive-expression)") { Builder = nodes => new CUnionExpression(nodes) };
                /* 408 StringOp         */ __Matchers[408] = new Mx.String(this, 408, "'~'", "~") { Creator = node => new RLiteral(node) };
                /* 409 SeqOp            */ __Matchers[409] = new Mx.Seq(this, 409, "_409:(>level-union-expression,'~',>level-exclusive-expression)") { Builder = nodes => new CComplementExpression(nodes) };
                /* 410 AltOp            */ __Matchers[410] = new Mx.Alt(this, 410, "alt(>exclusive-expression|>level-intersection-expression)") { Builder = nodes => nodes[0] };
                /* 411 SeqOp            */ __Matchers[411] = new Mx.Seq(this, 411, "_411:(>level-exclusive-expression,'^',>level-intersection-expression)") { Builder = nodes => new CExclusiveExpression(nodes) };
                /* 412 AltOp            */ __Matchers[412] = new Mx.Alt(this, 412, "alt(>intersection-expression|>level-negate-expression)") { Builder = nodes => nodes[0] };
                /* 413 SeqOp            */ __Matchers[413] = new Mx.Seq(this, 413, "_413:(>level-intersection-expression,'&',>level-negate-expression)") { Builder = nodes => new CIntersectionExpression(nodes) };
                /* 414 AltOp            */ __Matchers[414] = new Mx.Alt(this, 414, "alt(>negate-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 415 SeqOp            */ __Matchers[415] = new Mx.Seq(this, 415, "_415:('-',>level-negate-expression)") { Builder = nodes => new CNegateExpression(nodes) };
                /* 416 AltOp            */ __Matchers[416] = new Mx.Alt(this, 416, "alt(>reference|>literal|>string-expression|>call-expression|>select-expression|>nullsafe-select-expression|>grouped-expression)") { Builder = nodes => nodes[0] };
                /* 417 SeqOp            */ __Matchers[417] = new Mx.Seq(this, 417, "_417:('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 418 SeqOp            */ __Matchers[418] = new Mx.Seq(this, 418, "_418:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 419 SeqOp            */ __Matchers[419] = new Mx.Seq(this, 419, "_419:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 420 StringOp         */ __Matchers[420] = new Mx.String(this, 420, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 421 SeqOp            */ __Matchers[421] = new Mx.Seq(this, 421, "_421:(>primary-expression,'?.',>reference)") { Builder = nodes => new CNullsafeSelectExpression(nodes) };
                /* 422 AltOp            */ __Matchers[422] = new Mx.Alt(this, 422, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 423 AltOp            */ __Matchers[423] = new Mx.Alt(this, 423, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 424 StarOp           */ __Matchers[424] = new Mx.Star(this, 424, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Mx.Seq(this, 425, "_425:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 426 SeqOp            */ __Matchers[426] = new Mx.Seq(this, 426, "_426:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Mx.Seq(this, 427, "_427:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 428 SeqOp            */ __Matchers[428] = new Mx.Seq(this, 428, "_428:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 429 SeqOp            */ __Matchers[429] = new Mx.Seq(this, 429, "_429:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 430 AltOp            */ __Matchers[430] = new Mx.Alt(this, 430, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 431 SeqOp            */ __Matchers[431] = new Mx.Seq(this, 431, "_431:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 432 SeqOp            */ __Matchers[432] = new Mx.Seq(this, 432, "_432:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 433 StarOp           */ __Matchers[433] = new Mx.Star(this, 433, "*(_432:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 434 SeqOp            */ __Matchers[434] = new Mx.Seq(this, 434, "_434:(>condition,*(_432:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 435 AltOp            */ __Matchers[435] = new Mx.Alt(this, 435, "alt(>is-condition|>expression)") { Builder = nodes => nodes[0] };
                /* 436 OptionalOp       */ __Matchers[436] = new Mx.Optional(this, 436, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 437 SeqOp            */ __Matchers[437] = new Mx.Seq(this, 437, "_437:(?('!'),'is',>type,>name)") { Builder = nodes => new CIsCondition(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[172]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[173]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[174]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[177]);
                /*   6 PlainRuleOp      */ _namespaceIntro.Set(__Matchers[178]);
                /*   7 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[181]);
                /*   8 PlainRuleOp      */ _moduleBody.Set(__Matchers[185]);
                /*   9 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*  10 PlainRuleOp      */ _moduleImport.Set(__Matchers[187]);
                /*  11 PlainRuleOp      */ _usings.Set(__Matchers[188]);
                /*  12 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[190]);
                /*  13 PlainRuleOp      */ _usingElements.Set(__Matchers[192]);
                /*  14 PlainRuleOp      */ _usingElementList.Set(__Matchers[196]);
                /*  15 PlainRuleOp      */ _usingElement.Set(__Matchers[197]);
                /*  16 PlainRuleOp      */ _usingNamed.Set(__Matchers[200]);
                /*  17 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  18 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[202]);
                /*  19 PlainRuleOp      */ _usingWildcard.Set(__Matchers[203]);
                /*  20 PlainRuleOp      */ _name.Set(_identifier);
                /*  21 PlainRuleOp      */ _names.Set(__Matchers[207]);
                /*  22 PlainRuleOp      */ _reference.Set(__Matchers[209]);
                /*  23 PlainRuleOp      */ _genericArguments.Set(__Matchers[213]);
                /*  24 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[216]);
                /*  25 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  26 PlainRuleOp      */ _genericParameters.Set(__Matchers[218]);
                /*  27 PlainRuleOp      */ _genericParameterList.Set(__Matchers[221]);
                /*  28 PlainRuleOp      */ _genericParameter.Set(__Matchers[224]);
                /*  29 PlainRuleOp      */ _typeDefault.Set(__Matchers[225]);
                /*  30 PlainRuleOp      */ _variance.Set(__Matchers[228]);
                /*  31 PlainRuleOp      */ _topDeclarations.Set(__Matchers[229]);
                /*  32 PlainRuleOp      */ _topDeclaration.Set(__Matchers[230]);
                /*  33 PlainRuleOp      */ _universalDeclaration.Set(__Matchers[231]);
                /*  34 PlainRuleOp      */ _nestedDeclaration.Set(__Matchers[232]);
                /*  35 PlainRuleOp      */ _primitiveDeclaration.Set(__Matchers[235]);
                /*  36 PlainRuleOp      */ _operatorDeclaration.Set(__Matchers[236]);
                /*  37 PlainRuleOp      */ _prefixDeclaration.Set(__Matchers[240]);
                /*  38 PlainRuleOp      */ _prefixOperator.Set(__Matchers[243]);
                /*  39 PlainRuleOp      */ _infixDeclaration.Set(__Matchers[245]);
                /*  40 PlainRuleOp      */ _infixOperator.Set(__Matchers[259]);
                /*  41 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[262]);
                /*  42 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[263]);
                /*  43 PlainRuleOp      */ _varDeclaration.Set(__Matchers[266]);
                /*  44 PlainRuleOp      */ _letDeclaration.Set(__Matchers[268]);
                /*  45 PlainRuleOp      */ _classDeclaration.Set(__Matchers[272]);
                /*  46 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[274]);
                /*  47 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[276]);
                /*  48 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[279]);
                /*  49 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[282]);
                /*  50 PlainRuleOp      */ _functionBody.Set(__Matchers[283]);
                /*  51 PlainRuleOp      */ _attributeBody.Set(__Matchers[284]);
                /*  52 PlainRuleOp      */ _blockBody.Set(__Matchers[285]);
                /*  53 PlainRuleOp      */ _statelarations.Set(__Matchers[286]);
                /*  54 PlainRuleOp      */ _statelaration.Set(__Matchers[287]);
                /*  55 PlainRuleOp      */ _calcBody.Set(__Matchers[288]);
                /*  56 PlainRuleOp      */ _valueBody.Set(__Matchers[289]);
                /*  57 PlainRuleOp      */ _nullBody.Set(__Matchers[290]);
                /*  58 PlainRuleOp      */ _builtinBody.Set(__Matchers[291]);
                /*  59 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[292]);
                /*  60 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[293]);
                /*  61 PlainRuleOp      */ _extends.Set(__Matchers[295]);
                /*  62 PlainRuleOp      */ _extendType.Set(__Matchers[296]);
                /*  63 PlainRuleOp      */ _constructor.Set(__Matchers[297]);
                /*  64 PlainRuleOp      */ _satisfies.Set(__Matchers[299]);
                /*  65 PlainRuleOp      */ _constraints.Set(__Matchers[300]);
                /*  66 PlainRuleOp      */ _constraint.Set(__Matchers[302]);
                /*  67 PlainRuleOp      */ _unionTypeList.Set(__Matchers[305]);
                /*  68 PlainRuleOp      */ _caseTypes.Set(__Matchers[307]);
                /*  69 PlainRuleOp      */ _caseTypeList.Set(__Matchers[310]);
                /*  70 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  71 PlainRuleOp      */ _namePattern.Set(__Matchers[311]);
                /*  72 PlainRuleOp      */ _prelude.Set(__Matchers[314]);
                /*  73 PlainRuleOp      */ _attribute.Set(__Matchers[316]);
                /*  74 DfaRuleOp        */ _attributeName.Set(_attributeName_DFA);
                /*  75 PlainRuleOp      */ _type.Set(_unionType);
                /*  76 PlainRuleOp      */ _unionType.Set(__Matchers[319]);
                /*  77 PlainRuleOp      */ _intersectionType.Set(__Matchers[322]);
                /*  78 PlainRuleOp      */ _primaryType.Set(__Matchers[323]);
                /*  79 PlainRuleOp      */ _nullableType.Set(__Matchers[325]);
                /*  80 PlainRuleOp      */ _arrayType.Set(__Matchers[328]);
                /*  81 PlainRuleOp      */ _typeSelector.Set(__Matchers[329]);
                /*  82 PlainRuleOp      */ _callableType.Set(__Matchers[331]);
                /*  83 PlainRuleOp      */ _callableArguments.Set(_typeList);
                /*  84 PlainRuleOp      */ _typeList.Set(__Matchers[334]);
                /*  85 PlainRuleOp      */ _typeListType.Set(__Matchers[335]);
                /*  86 PlainRuleOp      */ _defaultedType.Set(__Matchers[336]);
                /*  87 PlainRuleOp      */ _emptyType.Set(__Matchers[337]);
                /*  88 PlainRuleOp      */ _tupleType.Set(__Matchers[338]);
                /*  89 PlainRuleOp      */ _nothingType.Set(__Matchers[340]);
                /*  90 PlainRuleOp      */ _parameters.Set(__Matchers[342]);
                /*  91 PlainRuleOp      */ _parameterList.Set(__Matchers[345]);
                /*  92 PlainRuleOp      */ _parameter.Set(_valueParameter);
                /*  93 PlainRuleOp      */ _valueParameter.Set(__Matchers[347]);
                /*  94 PlainRuleOp      */ _definitiveParameter.Set(__Matchers[348]);
                /*  95 PlainRuleOp      */ _valueDefault.Set(__Matchers[349]);
                /*  96 PlainRuleOp      */ _parameterType.Set(_type);
                /*  97 PlainRuleOp      */ _arguments.Set(__Matchers[351]);
                /*  98 PlainRuleOp      */ _argumentList.Set(__Matchers[354]);
                /*  99 PlainRuleOp      */ _statement.Set(__Matchers[355]);
                /* 100 PlainRuleOp      */ _assignStatement.Set(__Matchers[356]);
                /* 101 PlainRuleOp      */ _expressionStatement.Set(__Matchers[357]);
                /* 102 PlainRuleOp      */ _ifStatement.Set(__Matchers[361]);
                /* 103 PlainRuleOp      */ _elseIf.Set(__Matchers[363]);
                /* 104 PlainRuleOp      */ _elseBlock.Set(__Matchers[364]);
                /* 105 PlainRuleOp      */ _forStatement.Set(__Matchers[366]);
                /* 106 PlainRuleOp      */ _whileStatement.Set(__Matchers[368]);
                /* 107 PlainRuleOp      */ _returnStatement.Set(__Matchers[371]);
                /* 108 PlainRuleOp      */ _throwStatement.Set(__Matchers[373]);
                /* 109 PlainRuleOp      */ _assertStatement.Set(__Matchers[375]);
                /* 110 PlainRuleOp      */ _expression.Set(__Matchers[376]);
                /* 111 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[377]);
                /* 112 PlainRuleOp      */ _thenExpression.Set(__Matchers[379]);
                /* 113 PlainRuleOp      */ _elseExpression.Set(__Matchers[380]);
                /* 114 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[381]);
                /* 115 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[383]);
                /* 116 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[384]);
                /* 117 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[386]);
                /* 118 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[387]);
                /* 119 PlainRuleOp      */ _notExpression.Set(__Matchers[388]);
                /* 120 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[389]);
                /* 121 PlainRuleOp      */ _equalExpression.Set(__Matchers[390]);
                /* 122 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[391]);
                /* 123 PlainRuleOp      */ _identicalExpression.Set(__Matchers[392]);
                /* 124 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[393]);
                /* 125 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[394]);
                /* 126 PlainRuleOp      */ _lessExpression.Set(__Matchers[395]);
                /* 127 PlainRuleOp      */ _lessEqualExpression.Set(__Matchers[396]);
                /* 128 PlainRuleOp      */ _greaterExpression.Set(__Matchers[397]);
                /* 129 PlainRuleOp      */ _greaterEqualExpression.Set(__Matchers[398]);
                /* 130 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[399]);
                /* 131 PlainRuleOp      */ _addExpression.Set(__Matchers[400]);
                /* 132 PlainRuleOp      */ _subExpression.Set(__Matchers[401]);
                /* 133 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[402]);
                /* 134 PlainRuleOp      */ _mulExpression.Set(__Matchers[403]);
                /* 135 PlainRuleOp      */ _divExpression.Set(__Matchers[404]);
                /* 136 PlainRuleOp      */ _remExpression.Set(__Matchers[405]);
                /* 137 PlainRuleOp      */ _levelUnionExpression.Set(__Matchers[406]);
                /* 138 PlainRuleOp      */ _unionExpression.Set(__Matchers[407]);
                /* 139 PlainRuleOp      */ _complementExpression.Set(__Matchers[409]);
                /* 140 PlainRuleOp      */ _levelExclusiveExpression.Set(__Matchers[410]);
                /* 141 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[411]);
                /* 142 PlainRuleOp      */ _levelIntersectionExpression.Set(__Matchers[412]);
                /* 143 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[413]);
                /* 144 PlainRuleOp      */ _levelNegateExpression.Set(__Matchers[414]);
                /* 145 PlainRuleOp      */ _negateExpression.Set(__Matchers[415]);
                /* 146 PlainRuleOp      */ _primaryExpression.Set(__Matchers[416]);
                /* 147 PlainRuleOp      */ _groupedExpression.Set(__Matchers[417]);
                /* 148 PlainRuleOp      */ _callExpression.Set(__Matchers[418]);
                /* 149 PlainRuleOp      */ _selectExpression.Set(__Matchers[419]);
                /* 150 PlainRuleOp      */ _nullsafeSelectExpression.Set(__Matchers[421]);
                /* 151 PlainRuleOp      */ _literal.Set(_naturalLiteral);
                /* 152 PlainRuleOp      */ _stringExpression.Set(__Matchers[422]);
                /* 153 PlainRuleOp      */ _stringLiteral.Set(__Matchers[423]);
                /* 154 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[425]);
                /* 155 PlainRuleOp      */ _interpolationPart.Set(__Matchers[426]);
                /* 156 PlainRuleOp      */ _ifExpression.Set(__Matchers[427]);
                /* 157 PlainRuleOp      */ _ifThen.Set(__Matchers[428]);
                /* 158 PlainRuleOp      */ _ifElse.Set(__Matchers[429]);
                /* 159 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[430]);
                /* 160 PlainRuleOp      */ _conditions.Set(__Matchers[431]);
                /* 161 PlainRuleOp      */ _conditionList.Set(__Matchers[434]);
                /* 162 PlainRuleOp      */ _condition.Set(__Matchers[435]);
                /* 163 PlainRuleOp      */ _isCondition.Set(__Matchers[437]);
                /* 164 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 165 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 166 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 167 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 168 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 169 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 170 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 172 SeqOp            */ __Matchers[172].Set(_compilationUnit, __Matchers[171]);
                /* 173 AltOp            */ __Matchers[173].Set(_moduleDescriptor, _codeUnit);
                /* 174 SeqOp            */ __Matchers[174].Set(_namespaceIntro, _usings, _topDeclarations);
                /* 177 SeqOp            */ __Matchers[177].Set(_prelude, __Matchers[175], _names, __Matchers[176]);
                /* 178 SeqOp            */ __Matchers[178].Set(__Matchers[175], _names, __Matchers[176]);
                /* 180 StarOp           */ __Matchers[180].Set(_namespace);
                /* 181 SeqOp            */ __Matchers[181].Set(_prelude, __Matchers[179], _names, _moduleBody, __Matchers[180]);
                /* 183 StarOp           */ __Matchers[183].Set(_moduleBodyElement);
                /* 185 SeqOp            */ __Matchers[185].Set(__Matchers[182], __Matchers[183], __Matchers[184]);
                /* 187 SeqOp            */ __Matchers[187].Set(__Matchers[186], _names, __Matchers[176]);
                /* 188 StarOp           */ __Matchers[188].Set(_usingDeclaration);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[189], _names, _usingElements);
                /* 191 OptionalOp       */ __Matchers[191].Set(_usingElementList);
                /* 192 SeqOp            */ __Matchers[192].Set(__Matchers[182], __Matchers[191], __Matchers[184]);
                /* 194 SeqOp            */ __Matchers[194].Set(__Matchers[193], _usingElement);
                /* 195 StarOp           */ __Matchers[195].Set(__Matchers[194]);
                /* 196 SeqOp            */ __Matchers[196].Set(_usingElement, __Matchers[195]);
                /* 197 AltOp            */ __Matchers[197].Set(_usingNamed, _usingWildcard);
                /* 198 OptionalOp       */ __Matchers[198].Set(_usingNameSpecifier);
                /* 199 OptionalOp       */ __Matchers[199].Set(_usingElements);
                /* 200 SeqOp            */ __Matchers[200].Set(_usingName, __Matchers[198], __Matchers[199]);
                /* 202 SeqOp            */ __Matchers[202].Set(__Matchers[201], _identifier);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[204], _name);
                /* 206 StarOp           */ __Matchers[206].Set(__Matchers[205]);
                /* 207 SeqOp            */ __Matchers[207].Set(_name, __Matchers[206]);
                /* 208 OptionalOp       */ __Matchers[208].Set(_genericArguments);
                /* 209 SeqOp            */ __Matchers[209].Set(_name, __Matchers[208]);
                /* 211 OptionalOp       */ __Matchers[211].Set(_genericArgumentList);
                /* 213 SeqOp            */ __Matchers[213].Set(__Matchers[210], __Matchers[211], __Matchers[212]);
                /* 214 SeqOp            */ __Matchers[214].Set(__Matchers[193], _genericArgument);
                /* 215 StarOp           */ __Matchers[215].Set(__Matchers[214]);
                /* 216 SeqOp            */ __Matchers[216].Set(_genericArgument, __Matchers[215]);
                /* 217 OptionalOp       */ __Matchers[217].Set(_genericParameterList);
                /* 218 SeqOp            */ __Matchers[218].Set(__Matchers[210], __Matchers[217], __Matchers[212]);
                /* 219 SeqOp            */ __Matchers[219].Set(__Matchers[193], _genericParameter);
                /* 220 StarOp           */ __Matchers[220].Set(__Matchers[219]);
                /* 221 SeqOp            */ __Matchers[221].Set(_genericParameter, __Matchers[220]);
                /* 222 OptionalOp       */ __Matchers[222].Set(_variance);
                /* 223 OptionalOp       */ __Matchers[223].Set(_typeDefault);
                /* 224 SeqOp            */ __Matchers[224].Set(__Matchers[222], _name, __Matchers[223]);
                /* 225 SeqOp            */ __Matchers[225].Set(__Matchers[201], _type);
                /* 228 AltOp            */ __Matchers[228].Set(__Matchers[226], __Matchers[227]);
                /* 229 StarOp           */ __Matchers[229].Set(_topDeclaration);
                /* 230 AltOp            */ __Matchers[230].Set(_primitiveDeclaration, _universalDeclaration);
                /* 231 AltOp            */ __Matchers[231].Set(_functionDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _attributeDeclaration);
                /* 232 AltOp            */ __Matchers[232].Set(_universalDeclaration, _constructorDeclaration, _letDeclaration, _varDeclaration, _operatorDeclaration);
                /* 234 OptionalOp       */ __Matchers[234].Set(_caseTypes);
                /* 235 SeqOp            */ __Matchers[235].Set(_prelude, __Matchers[233], _name, __Matchers[234], _blockBody);
                /* 236 AltOp            */ __Matchers[236].Set(_prefixDeclaration, _infixDeclaration);
                /* 240 SeqOp            */ __Matchers[240].Set(_prelude, __Matchers[237], _type, _prefixOperator, __Matchers[238], __Matchers[239], _functionBody);
                /* 243 AltOp            */ __Matchers[243].Set(__Matchers[241], __Matchers[242]);
                /* 245 SeqOp            */ __Matchers[245].Set(_prelude, __Matchers[244], _type, _infixOperator, __Matchers[238], _definitiveParameter, __Matchers[239], _functionBody);
                /* 259 AltOp            */ __Matchers[259].Set(__Matchers[246], __Matchers[241], __Matchers[247], __Matchers[248], __Matchers[249], __Matchers[210], __Matchers[250], __Matchers[212], __Matchers[251], __Matchers[252], __Matchers[253], __Matchers[254], __Matchers[255], __Matchers[256], __Matchers[257], __Matchers[258]);
                /* 260 OptionalOp       */ __Matchers[260].Set(_genericParameters);
                /* 261 OptionalOp       */ __Matchers[261].Set(_constraints);
                /* 262 SeqOp            */ __Matchers[262].Set(_prelude, _type, _name, __Matchers[260], _parameters, __Matchers[261], _functionBody);
                /* 263 SeqOp            */ __Matchers[263].Set(_prelude, _type, _name, _attributeBody);
                /* 265 OptionalOp       */ __Matchers[265].Set(_type);
                /* 266 SeqOp            */ __Matchers[266].Set(_prelude, __Matchers[264], __Matchers[265], _name, __Matchers[201], _expression, __Matchers[176]);
                /* 268 SeqOp            */ __Matchers[268].Set(_prelude, __Matchers[267], __Matchers[265], _name, __Matchers[201], _expression, __Matchers[176]);
                /* 270 OptionalOp       */ __Matchers[270].Set(_extends);
                /* 271 OptionalOp       */ __Matchers[271].Set(_satisfies);
                /* 272 SeqOp            */ __Matchers[272].Set(_prelude, __Matchers[269], _name, __Matchers[260], __Matchers[270], __Matchers[271], __Matchers[234], __Matchers[261], _blockBody);
                /* 274 SeqOp            */ __Matchers[274].Set(_prelude, __Matchers[273], _name, __Matchers[260], __Matchers[271], __Matchers[234], __Matchers[261], _blockBody);
                /* 276 SeqOp            */ __Matchers[276].Set(_prelude, __Matchers[275], _name, __Matchers[270], __Matchers[271], _blockBody);
                /* 279 SeqOp            */ __Matchers[279].Set(_prelude, __Matchers[277], _name, __Matchers[260], __Matchers[261], __Matchers[278], _type, __Matchers[176]);
                /* 281 OptionalOp       */ __Matchers[281].Set(_name);
                /* 282 SeqOp            */ __Matchers[282].Set(_prelude, __Matchers[280], __Matchers[281], _parameters, __Matchers[270], _functionBody);
                /* 283 AltOp            */ __Matchers[283].Set(_calcBody, _blockBody, _nullBody, _builtinBody);
                /* 284 AltOp            */ __Matchers[284].Set(_calcBody, _valueBody, _blockBody, _nullBody, _builtinBody);
                /* 285 SeqOp            */ __Matchers[285].Set(__Matchers[182], _usings, _statelarations, __Matchers[184]);
                /* 286 StarOp           */ __Matchers[286].Set(_statelaration);
                /* 287 AltOp            */ __Matchers[287].Set(_statement, _nestedDeclaration);
                /* 288 SeqOp            */ __Matchers[288].Set(_functionSpecifier, __Matchers[176]);
                /* 289 SeqOp            */ __Matchers[289].Set(_valueSpecifier, __Matchers[176]);
                /* 290 SeqOp            */ __Matchers[290].Set(__Matchers[176]);
                /* 291 SeqOp            */ __Matchers[291].Set(__Matchers[278], __Matchers[233], __Matchers[176]);
                /* 292 SeqOp            */ __Matchers[292].Set(__Matchers[278], _expression);
                /* 293 SeqOp            */ __Matchers[293].Set(__Matchers[201], _expression);
                /* 295 SeqOp            */ __Matchers[295].Set(__Matchers[294], _extendType);
                /* 296 AltOp            */ __Matchers[296].Set(_type, _constructor);
                /* 297 SeqOp            */ __Matchers[297].Set(_primaryType, _arguments);
                /* 299 SeqOp            */ __Matchers[299].Set(__Matchers[298], _unionTypeList);
                /* 300 PlusOp           */ __Matchers[300].Set(_constraint);
                /* 302 SeqOp            */ __Matchers[302].Set(__Matchers[301], _name, __Matchers[260], __Matchers[234], __Matchers[271]);
                /* 303 SeqOp            */ __Matchers[303].Set(__Matchers[193], _type);
                /* 304 StarOp           */ __Matchers[304].Set(__Matchers[303]);
                /* 305 SeqOp            */ __Matchers[305].Set(_type, __Matchers[304]);
                /* 307 SeqOp            */ __Matchers[307].Set(__Matchers[306], _caseTypeList);
                /* 308 SeqOp            */ __Matchers[308].Set(__Matchers[256], _type);
                /* 309 StarOp           */ __Matchers[309].Set(__Matchers[308]);
                /* 310 SeqOp            */ __Matchers[310].Set(_type, __Matchers[309]);
                /* 311 SeqOp            */ __Matchers[311].Set(_name);
                /* 312 OptionalOp       */ __Matchers[312].Set(_stringLiteral);
                /* 313 StarOp           */ __Matchers[313].Set(_attribute);
                /* 314 SeqOp            */ __Matchers[314].Set(__Matchers[312], __Matchers[313]);
                /* 315 OptionalOp       */ __Matchers[315].Set(_arguments);
                /* 316 SeqOp            */ __Matchers[316].Set(_attributeName, __Matchers[315]);
                /* 317 SeqOp            */ __Matchers[317].Set(__Matchers[256], _intersectionType);
                /* 318 StarOp           */ __Matchers[318].Set(__Matchers[317]);
                /* 319 SeqOp            */ __Matchers[319].Set(_intersectionType, __Matchers[318]);
                /* 320 SeqOp            */ __Matchers[320].Set(__Matchers[257], _primaryType);
                /* 321 StarOp           */ __Matchers[321].Set(__Matchers[320]);
                /* 322 SeqOp            */ __Matchers[322].Set(_primaryType, __Matchers[321]);
                /* 323 AltOp            */ __Matchers[323].Set(_nullableType, _arrayType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _nothingType);
                /* 325 SeqOp            */ __Matchers[325].Set(_primaryType, __Matchers[324]);
                /* 328 SeqOp            */ __Matchers[328].Set(_primaryType, __Matchers[326], __Matchers[327]);
                /* 329 SeqOp            */ __Matchers[329].Set(_primaryType, __Matchers[204], _reference);
                /* 330 OptionalOp       */ __Matchers[330].Set(_callableArguments);
                /* 331 SeqOp            */ __Matchers[331].Set(_primaryType, __Matchers[238], __Matchers[330], __Matchers[239]);
                /* 332 SeqOp            */ __Matchers[332].Set(__Matchers[193], _typeListType);
                /* 333 StarOp           */ __Matchers[333].Set(__Matchers[332]);
                /* 334 SeqOp            */ __Matchers[334].Set(_typeListType, __Matchers[333]);
                /* 335 AltOp            */ __Matchers[335].Set(_type, _defaultedType);
                /* 336 SeqOp            */ __Matchers[336].Set(_type, __Matchers[201]);
                /* 337 SeqOp            */ __Matchers[337].Set(__Matchers[326], __Matchers[327]);
                /* 338 SeqOp            */ __Matchers[338].Set(__Matchers[326], _typeList, __Matchers[327]);
                /* 340 SeqOp            */ __Matchers[340].Set(__Matchers[339]);
                /* 341 OptionalOp       */ __Matchers[341].Set(_parameterList);
                /* 342 SeqOp            */ __Matchers[342].Set(__Matchers[238], __Matchers[341], __Matchers[239]);
                /* 343 SeqOp            */ __Matchers[343].Set(__Matchers[193], _parameter);
                /* 344 StarOp           */ __Matchers[344].Set(__Matchers[343]);
                /* 345 SeqOp            */ __Matchers[345].Set(_parameter, __Matchers[344]);
                /* 346 OptionalOp       */ __Matchers[346].Set(_valueDefault);
                /* 347 SeqOp            */ __Matchers[347].Set(_prelude, _parameterType, _name, __Matchers[346]);
                /* 348 SeqOp            */ __Matchers[348].Set(_prelude, _parameterType, _name);
                /* 349 SeqOp            */ __Matchers[349].Set(__Matchers[201], _expression);
                /* 350 OptionalOp       */ __Matchers[350].Set(_argumentList);
                /* 351 SeqOp            */ __Matchers[351].Set(__Matchers[238], __Matchers[350], __Matchers[239]);
                /* 352 SeqOp            */ __Matchers[352].Set(__Matchers[193], _expression);
                /* 353 StarOp           */ __Matchers[353].Set(__Matchers[352]);
                /* 354 SeqOp            */ __Matchers[354].Set(_expression, __Matchers[353]);
                /* 355 AltOp            */ __Matchers[355].Set(_assignStatement, _expressionStatement, _ifStatement, _forStatement, _whileStatement, _assertStatement, _returnStatement, _throwStatement);
                /* 356 SeqOp            */ __Matchers[356].Set(_primaryExpression, __Matchers[201], _expression, __Matchers[176]);
                /* 357 SeqOp            */ __Matchers[357].Set(_expression, __Matchers[176]);
                /* 359 StarOp           */ __Matchers[359].Set(_elseIf);
                /* 360 OptionalOp       */ __Matchers[360].Set(_elseBlock);
                /* 361 SeqOp            */ __Matchers[361].Set(__Matchers[358], _conditions, _blockBody, __Matchers[359], __Matchers[360]);
                /* 363 SeqOp            */ __Matchers[363].Set(__Matchers[362], __Matchers[358], _conditions, _blockBody);
                /* 364 SeqOp            */ __Matchers[364].Set(__Matchers[362], _blockBody);
                /* 366 SeqOp            */ __Matchers[366].Set(__Matchers[365], __Matchers[238], _pattern, __Matchers[226], _expression, __Matchers[239], _blockBody, __Matchers[360]);
                /* 368 SeqOp            */ __Matchers[368].Set(__Matchers[367], _conditions, _blockBody);
                /* 370 OptionalOp       */ __Matchers[370].Set(_expression);
                /* 371 SeqOp            */ __Matchers[371].Set(__Matchers[369], __Matchers[370], __Matchers[176]);
                /* 373 SeqOp            */ __Matchers[373].Set(__Matchers[372], __Matchers[370], __Matchers[176]);
                /* 375 SeqOp            */ __Matchers[375].Set(__Matchers[312], __Matchers[374], _conditions, __Matchers[176]);
                /* 376 AltOp            */ __Matchers[376].Set(_ifExpression, _levelCoalesceExpression);
                /* 377 AltOp            */ __Matchers[377].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 379 SeqOp            */ __Matchers[379].Set(_levelCoalesceExpression, __Matchers[378], _levelDisjunctionExpression);
                /* 380 SeqOp            */ __Matchers[380].Set(_levelCoalesceExpression, __Matchers[362], _levelDisjunctionExpression);
                /* 381 AltOp            */ __Matchers[381].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 383 SeqOp            */ __Matchers[383].Set(_levelDisjunctionExpression, __Matchers[382], _levelConjunctionExpression);
                /* 384 AltOp            */ __Matchers[384].Set(_conjunctionExpression, _levelNotExpression);
                /* 386 SeqOp            */ __Matchers[386].Set(_levelConjunctionExpression, __Matchers[385], _levelNotExpression);
                /* 387 AltOp            */ __Matchers[387].Set(_notExpression, _levelEqualityExpression);
                /* 388 SeqOp            */ __Matchers[388].Set(__Matchers[242], _levelNotExpression);
                /* 389 AltOp            */ __Matchers[389].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 390 SeqOp            */ __Matchers[390].Set(_levelCompareExpression, __Matchers[252], _levelCompareExpression);
                /* 391 SeqOp            */ __Matchers[391].Set(_levelCompareExpression, __Matchers[253], _levelCompareExpression);
                /* 392 SeqOp            */ __Matchers[392].Set(_levelCompareExpression, __Matchers[254], _levelCompareExpression);
                /* 393 SeqOp            */ __Matchers[393].Set(_levelCompareExpression, __Matchers[255], _levelCompareExpression);
                /* 394 AltOp            */ __Matchers[394].Set(_lessExpression, _lessEqualExpression, _greaterExpression, _greaterEqualExpression, _levelAddExpression);
                /* 395 SeqOp            */ __Matchers[395].Set(_levelAddExpression, __Matchers[210], _levelAddExpression);
                /* 396 SeqOp            */ __Matchers[396].Set(_levelAddExpression, __Matchers[250], _levelAddExpression);
                /* 397 SeqOp            */ __Matchers[397].Set(_levelAddExpression, __Matchers[212], _levelAddExpression);
                /* 398 SeqOp            */ __Matchers[398].Set(_levelAddExpression, __Matchers[251], _levelAddExpression);
                /* 399 AltOp            */ __Matchers[399].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 400 SeqOp            */ __Matchers[400].Set(_levelAddExpression, __Matchers[246], _levelMulExpression);
                /* 401 SeqOp            */ __Matchers[401].Set(_levelAddExpression, __Matchers[241], _levelMulExpression);
                /* 402 AltOp            */ __Matchers[402].Set(_mulExpression, _divExpression, _remExpression, _levelUnionExpression);
                /* 403 SeqOp            */ __Matchers[403].Set(_levelMulExpression, __Matchers[247], _levelUnionExpression);
                /* 404 SeqOp            */ __Matchers[404].Set(_levelMulExpression, __Matchers[248], _levelUnionExpression);
                /* 405 SeqOp            */ __Matchers[405].Set(_levelMulExpression, __Matchers[249], _levelUnionExpression);
                /* 406 AltOp            */ __Matchers[406].Set(_unionExpression, _complementExpression, _levelExclusiveExpression);
                /* 407 SeqOp            */ __Matchers[407].Set(_levelUnionExpression, __Matchers[256], _levelExclusiveExpression);
                /* 409 SeqOp            */ __Matchers[409].Set(_levelUnionExpression, __Matchers[408], _levelExclusiveExpression);
                /* 410 AltOp            */ __Matchers[410].Set(_exclusiveExpression, _levelIntersectionExpression);
                /* 411 SeqOp            */ __Matchers[411].Set(_levelExclusiveExpression, __Matchers[258], _levelIntersectionExpression);
                /* 412 AltOp            */ __Matchers[412].Set(_intersectionExpression, _levelNegateExpression);
                /* 413 SeqOp            */ __Matchers[413].Set(_levelIntersectionExpression, __Matchers[257], _levelNegateExpression);
                /* 414 AltOp            */ __Matchers[414].Set(_negateExpression, _primaryExpression);
                /* 415 SeqOp            */ __Matchers[415].Set(__Matchers[241], _levelNegateExpression);
                /* 416 AltOp            */ __Matchers[416].Set(_reference, _literal, _stringExpression, _callExpression, _selectExpression, _nullsafeSelectExpression, _groupedExpression);
                /* 417 SeqOp            */ __Matchers[417].Set(__Matchers[238], _expression, __Matchers[239]);
                /* 418 SeqOp            */ __Matchers[418].Set(_primaryExpression, _arguments);
                /* 419 SeqOp            */ __Matchers[419].Set(_primaryExpression, __Matchers[204], _reference);
                /* 421 SeqOp            */ __Matchers[421].Set(_primaryExpression, __Matchers[420], _reference);
                /* 422 AltOp            */ __Matchers[422].Set(_stringLiteral, _stringInterpolation);
                /* 423 AltOp            */ __Matchers[423].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 424 StarOp           */ __Matchers[424].Set(_interpolationPart);
                /* 425 SeqOp            */ __Matchers[425].Set(_stringStart, _expression, __Matchers[424], _stringEnd);
                /* 426 SeqOp            */ __Matchers[426].Set(_stringMid, _expression);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[358], _conditions, _ifThen, _ifElse);
                /* 428 SeqOp            */ __Matchers[428].Set(__Matchers[378], _conditionalExpression);
                /* 429 SeqOp            */ __Matchers[429].Set(__Matchers[362], _conditionalExpression);
                /* 430 AltOp            */ __Matchers[430].Set(_ifExpression, _levelDisjunctionExpression);
                /* 431 SeqOp            */ __Matchers[431].Set(__Matchers[238], _conditionList, __Matchers[239]);
                /* 432 SeqOp            */ __Matchers[432].Set(__Matchers[193], _condition);
                /* 433 StarOp           */ __Matchers[433].Set(__Matchers[432]);
                /* 434 SeqOp            */ __Matchers[434].Set(_condition, __Matchers[433]);
                /* 435 AltOp            */ __Matchers[435].Set(_isCondition, _expression);
                /* 436 OptionalOp       */ __Matchers[436].Set(__Matchers[242]);
                /* 437 SeqOp            */ __Matchers[437].Set(__Matchers[436], __Matchers[298], _type, _name);

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
                    new DfaState(66, true),
                    new DfaState(67, true),
                    new DfaState(68, true),
                    new DfaState(69, true),
                    new DfaState(70, true),
                    new DfaState(71, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 77), new DfaInterval(79, 90), new DfaInterval(95, 95), new DfaInterval(100, 100), new DfaInterval(103, 104), new DfaInterval(106, 107), new DfaInterval(113, 113), new DfaInterval(115, 115), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(78, 78)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[57], new DfaInterval(112, 112)),
                    new DfaTrans(_identifier_DFA.States[60], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[64], new DfaInterval(116, 116)),
                    new DfaTrans(_identifier_DFA.States[67], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[68], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[69], new DfaInterval(119, 119))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(114, 114))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 119), new DfaInterval(121, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(120, 120))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[54].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[55], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[55].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[56], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[56].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[57].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[59], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[59].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[60].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[64].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[65], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[65].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[66], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[66].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[67].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[68].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[69].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[70], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[70].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[71], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[71].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(114, 114))
                );
            }

            private readonly Mx.PlainRule _compilationUnit;
            private readonly Mx.PlainRule _codeUnit;
            private readonly Mx.PlainRule _namespace;
            private readonly Mx.PlainRule _namespaceIntro;
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
            private readonly Mx.PlainRule _topDeclarations;
            private readonly Mx.PlainRule _topDeclaration;
            private readonly Mx.PlainRule _universalDeclaration;
            private readonly Mx.PlainRule _nestedDeclaration;
            private readonly Mx.PlainRule _primitiveDeclaration;
            private readonly Mx.PlainRule _operatorDeclaration;
            private readonly Mx.PlainRule _prefixDeclaration;
            private readonly Mx.PlainRule _prefixOperator;
            private readonly Mx.PlainRule _infixDeclaration;
            private readonly Mx.PlainRule _infixOperator;
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
            private readonly Mx.PlainRule _calcBody;
            private readonly Mx.PlainRule _valueBody;
            private readonly Mx.PlainRule _nullBody;
            private readonly Mx.PlainRule _builtinBody;
            private readonly Mx.PlainRule _functionSpecifier;
            private readonly Mx.PlainRule _valueSpecifier;
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
            private readonly Mx.PlainRule _type;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _nullableType;
            private readonly Mx.PlainRule _arrayType;
            private readonly Mx.PlainRule _typeSelector;
            private readonly Mx.PlainRule _callableType;
            private readonly Mx.PlainRule _callableArguments;
            private readonly Mx.PlainRule _typeList;
            private readonly Mx.PlainRule _typeListType;
            private readonly Mx.PlainRule _defaultedType;
            private readonly Mx.PlainRule _emptyType;
            private readonly Mx.PlainRule _tupleType;
            private readonly Mx.PlainRule _nothingType;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _valueParameter;
            private readonly Mx.PlainRule _definitiveParameter;
            private readonly Mx.PlainRule _valueDefault;
            private readonly Mx.PlainRule _parameterType;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _argumentList;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _assignStatement;
            private readonly Mx.PlainRule _expressionStatement;
            private readonly Mx.PlainRule _ifStatement;
            private readonly Mx.PlainRule _elseIf;
            private readonly Mx.PlainRule _elseBlock;
            private readonly Mx.PlainRule _forStatement;
            private readonly Mx.PlainRule _whileStatement;
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
        public interface ICNamespaceIntro : IRNode {}
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
        public interface ICTopDeclarations : IRNode {}
        public interface ICTopDeclaration : IRNode {}
        public interface ICUniversalDeclaration : ICNestedDeclaration, ICTopDeclaration {}
        public interface ICNestedDeclaration : ICStatelaration {}
        public interface ICPrimitiveDeclaration : ICTopDeclaration {}
        public interface ICOperatorDeclaration : ICNestedDeclaration {}
        public interface ICPrefixDeclaration : ICOperatorDeclaration {}
        public interface ICPrefixOperator : IRNode {}
        public interface ICInfixDeclaration : ICOperatorDeclaration {}
        public interface ICInfixOperator : IRNode {}
        public interface ICFunctionDeclaration : ICUniversalDeclaration {}
        public interface ICAttributeDeclaration : ICUniversalDeclaration {}
        public interface ICVarDeclaration : ICNestedDeclaration {}
        public interface ICLetDeclaration : ICNestedDeclaration {}
        public interface ICClassDeclaration : ICUniversalDeclaration {}
        public interface ICInterfaceDeclaration : ICUniversalDeclaration {}
        public interface ICObjectDeclaration : ICUniversalDeclaration {}
        public interface ICAliasDeclaration : ICUniversalDeclaration {}
        public interface ICConstructorDeclaration : ICNestedDeclaration {}
        public interface ICFunctionBody : IRNode {}
        public interface ICAttributeBody : IRNode {}
        public interface ICBlockBody : ICAttributeBody, ICFunctionBody {}
        public interface ICStatelarations : IRNode {}
        public interface ICStatelaration : IRNode {}
        public interface ICCalcBody : ICAttributeBody, ICFunctionBody {}
        public interface ICValueBody : ICAttributeBody {}
        public interface ICNullBody : ICAttributeBody, ICFunctionBody {}
        public interface ICBuiltinBody : ICAttributeBody, ICFunctionBody {}
        public interface ICFunctionSpecifier : IRNode {}
        public interface ICValueSpecifier : IRNode {}
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
        public interface ICType : ICExtendType, ICGenericArgument, ICParameterType, ICTypeListType {}
        public interface ICUnionType : ICType {}
        public interface ICIntersectionType : IRNode {}
        public interface ICPrimaryType : IRNode {}
        public interface ICNullableType : ICPrimaryType {}
        public interface ICArrayType : ICPrimaryType {}
        public interface ICTypeSelector : ICPrimaryType {}
        public interface ICCallableType : ICPrimaryType {}
        public interface ICCallableArguments : IRNode {}
        public interface ICTypeList : ICCallableArguments {}
        public interface ICTypeListType : IRNode {}
        public interface ICDefaultedType : ICTypeListType {}
        public interface ICEmptyType : ICPrimaryType {}
        public interface ICTupleType : ICPrimaryType {}
        public interface ICNothingType : ICPrimaryType {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICValueParameter : ICParameter {}
        public interface ICDefinitiveParameter : IRNode {}
        public interface ICValueDefault : IRNode {}
        public interface ICParameterType : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICArgumentList : IRNode {}
        public interface ICStatement : ICStatelaration {}
        public interface ICAssignStatement : ICStatement {}
        public interface ICExpressionStatement : ICStatement {}
        public interface ICIfStatement : ICStatement {}
        public interface ICElseIf : IRNode {}
        public interface ICElseBlock : IRNode {}
        public interface ICForStatement : ICStatement {}
        public interface ICWhileStatement : ICStatement {}
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

            public CNamespaceIntro NamespaceIntro => Get<CNamespaceIntro>(0);
            public CUsings Usings => Get<CUsings>(1);
            public CTopDeclarations TopDeclarations => Get<CTopDeclarations>(2);
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

        public partial class CNamespaceIntro : RSequence, ICNamespaceIntro
        {
            // sequence
            public CNamespaceIntro(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'namespace'
            public CNames Names => Get<CNames>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
            // sequence
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'module'
            public CNames Names => Get<CNames>(2);
            public CModuleBody ModuleBody => Get<CModuleBody>(3);
            public RStar<CNamespace> Namespace => Get<RStar<CNamespace>>(4);
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

        public partial class CTopDeclarations : RStar<ICTopDeclaration>, ICTopDeclarations
        {
            // *star*
            public CTopDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CPrimitiveDeclaration : RSequence, ICPrimitiveDeclaration
        {
            // sequence
            public CPrimitiveDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'builtin'
            public ICName Name => Get<ICName>(2);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(3);
            public CBlockBody BlockBody => Get<CBlockBody>(4);
        }

        public partial class CPrefixDeclaration : RSequence, ICPrefixDeclaration
        {
            // sequence
            public CPrefixDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'prefix'
            public ICType Type => Get<ICType>(2);
            public CPrefixOperator PrefixOperator => Get<CPrefixOperator>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '('
            public RLiteral Literal3 => Get<RLiteral>(5); // ')'
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(6);
        }

        public partial class CPrefixOperator : RLiteral, ICPrefixOperator
        {
            // alternatives
            public CPrefixOperator(params Node[] children) : base(children) {}
        }

        public partial class CInfixDeclaration : RSequence, ICInfixDeclaration
        {
            // sequence
            public CInfixDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'infix'
            public ICType Type => Get<ICType>(2);
            public CInfixOperator InfixOperator => Get<CInfixOperator>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '('
            public CDefinitiveParameter DefinitiveParameter => Get<CDefinitiveParameter>(5);
            public RLiteral Literal3 => Get<RLiteral>(6); // ')'
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(7);
        }

        public partial class CInfixOperator : RLiteral, ICInfixOperator
        {
            // alternatives
            public CInfixOperator(params Node[] children) : base(children) {}
        }

        public partial class CFunctionDeclaration : RSequence, ICFunctionDeclaration
        {
            // sequence
            public CFunctionDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ICType Type => Get<ICType>(1);
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public CParameters Parameters => Get<CParameters>(4);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(5);
            public ICFunctionBody FunctionBody => Get<ICFunctionBody>(6);
        }

        public partial class CAttributeDeclaration : RSequence, ICAttributeDeclaration
        {
            // sequence
            public CAttributeDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ICType Type => Get<ICType>(1);
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
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(4);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(5);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(6);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(7);
            public CBlockBody BlockBody => Get<CBlockBody>(8);
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'interface'
            public ICName Name => Get<ICName>(2);
            public ROptional<CGenericParameters> GenericParameters => Get<ROptional<CGenericParameters>>(3);
            public ROptional<CSatisfies> Satisfies => Get<ROptional<CSatisfies>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public ROptional<CConstraints> Constraints => Get<ROptional<CConstraints>>(6);
            public CBlockBody BlockBody => Get<CBlockBody>(7);
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

        public partial class CCalcBody : RSequence, ICCalcBody
        {
            // sequence
            public CCalcBody(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CValueBody : RSequence, ICValueBody
        {
            // sequence
            public CValueBody(params RNode[] children) : base(children) {}

            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CNullBody : RSequence, ICNullBody
        {
            // sequence
            public CNullBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ';'
        }

        public partial class CBuiltinBody : RSequence, ICBuiltinBody
        {
            // sequence
            public CBuiltinBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public RLiteral Literal2 => Get<RLiteral>(1); // 'builtin'
            public RLiteral Literal3 => Get<RLiteral>(2); // ';'
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            // sequence
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CValueSpecifier : RSequence, ICValueSpecifier
        {
            // sequence
            public CValueSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
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
            public ROptional<CArguments> Arguments => Get<ROptional<CArguments>>(1);
        }

        public partial class CAttributeName : RToken, ICAttributeName
        {
            // token
            public CAttributeName(params Node[] children) : base(children) {}
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

        public partial class CNothingType : RSequence, ICNothingType
        {
            // sequence
            public CNothingType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'Nothing'
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
            public ICParameterType ParameterType => Get<ICParameterType>(1);
            public ICName Name => Get<ICName>(2);
            public ROptional<CValueDefault> ValueDefault => Get<ROptional<CValueDefault>>(3);
        }

        public partial class CDefinitiveParameter : RSequence, ICDefinitiveParameter
        {
            // sequence
            public CDefinitiveParameter(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public ICParameterType ParameterType => Get<ICParameterType>(1);
            public ICName Name => Get<ICName>(2);
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
            public ROptional<CArgumentList> ArgumentList => Get<ROptional<CArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CArgumentList : RLoop<ICExpression>, ICArgumentList
        {
            // sequence
            public CArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CAssignStatement : RSequence, ICAssignStatement
        {
            // sequence
            public CAssignStatement(params RNode[] children) : base(children) {}

            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(0);
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

        public partial class CWhileStatement : RSequence, ICWhileStatement
        {
            // sequence
            public CWhileStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'while'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlockBody BlockBody => Get<CBlockBody>(2);
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

            protected virtual void Visit(CNamespaceIntro element)
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

            protected virtual void Visit(CTopDeclarations element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPrimitiveDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPrefixDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPrefixOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInfixDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInfixOperator element)
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

            protected virtual void Visit(CCalcBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNullBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBuiltinBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueSpecifier element)
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

            protected virtual void Visit(CEmptyType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTupleType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNothingType element)
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

            protected virtual void Visit(CDefinitiveParameter element)
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

            protected virtual void Visit(CArgumentList element)
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

            protected virtual void Visit(CWhileStatement element)
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
