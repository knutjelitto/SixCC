// <generated from="D:\\Six\\Six.Six\\Six.six" at="15.04.2022 06:01:37" />

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
                : base(new Mx.Matcher[448])
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
                /*  35 PlainRuleOp      */ __Matchers[35] = _operatorDeclaration = new Mx.PlainRule(this, 35, "operator-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _prefixDeclaration = new Mx.PlainRule(this, 36, "prefix-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _prefixOperator = new Mx.PlainRule(this, 37, "prefix-operator") { Creator = node => new CPrefixOperator(node) };
                /*  38 PlainRuleOp      */ __Matchers[38] = _infixDeclaration = new Mx.PlainRule(this, 38, "infix-declaration") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _infixOperator = new Mx.PlainRule(this, 39, "infix-operator") { Creator = node => new CInfixOperator(node) };
                /*  40 PlainRuleOp      */ __Matchers[40] = _functionDeclaration = new Mx.PlainRule(this, 40, "function-declaration") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _attributeDeclaration = new Mx.PlainRule(this, 41, "attribute-declaration") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _varDeclaration = new Mx.PlainRule(this, 42, "var-declaration") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _letDeclaration = new Mx.PlainRule(this, 43, "let-declaration") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _classDeclaration = new Mx.PlainRule(this, 44, "class-declaration") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _interfaceDeclaration = new Mx.PlainRule(this, 45, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _objectDeclaration = new Mx.PlainRule(this, 46, "object-declaration") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _aliasDeclaration = new Mx.PlainRule(this, 47, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _constructorDeclaration = new Mx.PlainRule(this, 48, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _classBody = new Mx.PlainRule(this, 49, "class-body") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _interfaceBody = new Mx.PlainRule(this, 50, "interface-body") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _classMember = new Mx.PlainRule(this, 51, "class-member") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _interfaceMember = new Mx.PlainRule(this, 52, "interface-member") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _functionBody = new Mx.PlainRule(this, 53, "function-body") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _attributeBody = new Mx.PlainRule(this, 54, "attribute-body") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _blockBody = new Mx.PlainRule(this, 55, "block-body") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _statelarations = new Mx.PlainRule(this, 56, "statelarations") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _statelaration = new Mx.PlainRule(this, 57, "statelaration") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _calcBody = new Mx.PlainRule(this, 58, "calc-body") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _nullBody = new Mx.PlainRule(this, 59, "null-body") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _functionSpecifier = new Mx.PlainRule(this, 60, "function-specifier") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _extends = new Mx.PlainRule(this, 61, "extends") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _extendedType = new Mx.PlainRule(this, 62, "extended-type") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _satisfies = new Mx.PlainRule(this, 63, "satisfies") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _unionTypeList = new Mx.PlainRule(this, 64, "union-type-list") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _constraints = new Mx.PlainRule(this, 65, "constraints") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _constraint = new Mx.PlainRule(this, 66, "constraint") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _caseTypes = new Mx.PlainRule(this, 67, "case-types") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _caseTypeList = new Mx.PlainRule(this, 68, "case-type-list") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _pattern = new Mx.PlainRule(this, 69, "pattern") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _namePattern = new Mx.PlainRule(this, 70, "name-pattern") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _prelude = new Mx.PlainRule(this, 71, "prelude") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _attribute = new Mx.PlainRule(this, 72, "attribute") { Builder = nodes => nodes[0] };
                /*  73 DfaRuleOp        */ __Matchers[73] = _attributeName = new Mx.DfaRule(this, 73, "attribute-name") { Creator = node => new CAttributeName(node) };
                /*  74 PlainRuleOp      */ __Matchers[74] = _type = new Mx.PlainRule(this, 74, "type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _unionType = new Mx.PlainRule(this, 75, "union-type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _intersectionType = new Mx.PlainRule(this, 76, "intersection-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _primaryType = new Mx.PlainRule(this, 77, "primary-type") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _nullableType = new Mx.PlainRule(this, 78, "nullable-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _arrayType = new Mx.PlainRule(this, 79, "array-type") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _typeSelector = new Mx.PlainRule(this, 80, "type-selector") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _callableType = new Mx.PlainRule(this, 81, "callable-type") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _callableArguments = new Mx.PlainRule(this, 82, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeList = new Mx.PlainRule(this, 83, "type-list") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _typeListType = new Mx.PlainRule(this, 84, "type-list-type") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _defaultedType = new Mx.PlainRule(this, 85, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _emptyType = new Mx.PlainRule(this, 86, "empty-type") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _tupleType = new Mx.PlainRule(this, 87, "tuple-type") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _nothingType = new Mx.PlainRule(this, 88, "nothing-type") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _parameters = new Mx.PlainRule(this, 89, "parameters") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _parameterList = new Mx.PlainRule(this, 90, "parameter-list") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _parameter = new Mx.PlainRule(this, 91, "parameter") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _valueParameter = new Mx.PlainRule(this, 92, "value-parameter") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _definitiveParameter = new Mx.PlainRule(this, 93, "definitive-parameter") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _valueDefault = new Mx.PlainRule(this, 94, "value-default") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _parameterType = new Mx.PlainRule(this, 95, "parameter-type") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _arguments = new Mx.PlainRule(this, 96, "arguments") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _argumentList = new Mx.PlainRule(this, 97, "argument-list") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _statement = new Mx.PlainRule(this, 98, "statement") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _assignStatement = new Mx.PlainRule(this, 99, "assign-statement") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _expressionStatement = new Mx.PlainRule(this, 100, "expression-statement") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _ifStatement = new Mx.PlainRule(this, 101, "if-statement") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _elsePart = new Mx.PlainRule(this, 102, "else-part") { Builder = nodes => nodes[0] };
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
                /* 130 PlainRuleOp      */ __Matchers[130] = _levelShiftExpression = new Mx.PlainRule(this, 130, "level-shift-expression") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _shiftLeftExpression = new Mx.PlainRule(this, 131, "shift-left-expression") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _shiftRightExpression = new Mx.PlainRule(this, 132, "shift-right-expression") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _levelAddExpression = new Mx.PlainRule(this, 133, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _addExpression = new Mx.PlainRule(this, 134, "add-expression") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _subExpression = new Mx.PlainRule(this, 135, "sub-expression") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _levelMulExpression = new Mx.PlainRule(this, 136, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _mulExpression = new Mx.PlainRule(this, 137, "mul-expression") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _divExpression = new Mx.PlainRule(this, 138, "div-expression") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _remExpression = new Mx.PlainRule(this, 139, "rem-expression") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _levelUnionExpression = new Mx.PlainRule(this, 140, "level-union-expression") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _unionExpression = new Mx.PlainRule(this, 141, "union-expression") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _complementExpression = new Mx.PlainRule(this, 142, "complement-expression") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _levelExclusiveExpression = new Mx.PlainRule(this, 143, "level-exclusive-expression") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _exclusiveExpression = new Mx.PlainRule(this, 144, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _levelIntersectionExpression = new Mx.PlainRule(this, 145, "level-intersection-expression") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _intersectionExpression = new Mx.PlainRule(this, 146, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _levelNegateExpression = new Mx.PlainRule(this, 147, "level-negate-expression") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _negateExpression = new Mx.PlainRule(this, 148, "negate-expression") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _positiveExpression = new Mx.PlainRule(this, 149, "positive-expression") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _complExpression = new Mx.PlainRule(this, 150, "compl-expression") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _primaryExpression = new Mx.PlainRule(this, 151, "primary-expression") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _groupedExpression = new Mx.PlainRule(this, 152, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _callExpression = new Mx.PlainRule(this, 153, "call-expression") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _selectExpression = new Mx.PlainRule(this, 154, "select-expression") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _nullsafeSelectExpression = new Mx.PlainRule(this, 155, "nullsafe-select-expression") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _literal = new Mx.PlainRule(this, 156, "literal") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _stringExpression = new Mx.PlainRule(this, 157, "string-expression") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _stringLiteral = new Mx.PlainRule(this, 158, "string-literal") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _stringInterpolation = new Mx.PlainRule(this, 159, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _interpolationPart = new Mx.PlainRule(this, 160, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _ifExpression = new Mx.PlainRule(this, 161, "if-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _ifThen = new Mx.PlainRule(this, 162, "if-then") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _ifElse = new Mx.PlainRule(this, 163, "if-else") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _conditionalExpression = new Mx.PlainRule(this, 164, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _conditions = new Mx.PlainRule(this, 165, "conditions") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _conditionList = new Mx.PlainRule(this, 166, "condition-list") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _condition = new Mx.PlainRule(this, 167, "condition") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _isCondition = new Mx.PlainRule(this, 168, "is-condition") { Builder = nodes => nodes[0] };
                /* 169 DfaRuleOp        */ __Matchers[169] = _naturalLiteral = new Mx.DfaRule(this, 169, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 170 DfaRuleOp        */ __Matchers[170] = _stringStart = new Mx.DfaRule(this, 170, "string-start") { Creator = node => new CStringStart(node) };
                /* 171 DfaRuleOp        */ __Matchers[171] = _stringMid = new Mx.DfaRule(this, 171, "string-mid") { Creator = node => new CStringMid(node) };
                /* 172 DfaRuleOp        */ __Matchers[172] = _stringEnd = new Mx.DfaRule(this, 172, "string-end") { Creator = node => new CStringEnd(node) };
                /* 173 DfaRuleOp        */ __Matchers[173] = _plainStringLiteral = new Mx.DfaRule(this, 173, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 174 DfaRuleOp        */ __Matchers[174] = _verbatimStringLiteral = new Mx.DfaRule(this, 174, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 175 DfaRuleOp        */ __Matchers[175] = _identifier = new Mx.DfaRule(this, 175, "identifier") { Creator = node => new CIdentifier(node) };
                /* 176 EofOp            */ __Matchers[176] = new Mx.Eof(this, 176, "<eof>") { Creator = node => new REof(node) };
                /* 177 SeqOp            */ __Matchers[177] = new Mx.Seq(this, 177, "_177:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 178 AltOp            */ __Matchers[178] = new Mx.Alt(this, 178, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 179 SeqOp            */ __Matchers[179] = new Mx.Seq(this, 179, "_179:(>namespace-intro,>usings,>top-declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 180 StringOp         */ __Matchers[180] = new Mx.Keyword(this, 180, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 181 StringOp         */ __Matchers[181] = new Mx.String(this, 181, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 182 SeqOp            */ __Matchers[182] = new Mx.Seq(this, 182, "_182:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:('namespace',>names,';')") { Builder = nodes => new CNamespaceIntro(nodes) };
                /* 184 StringOp         */ __Matchers[184] = new Mx.Keyword(this, 184, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 185 StarOp           */ __Matchers[185] = new Mx.Star(this, 185, "*(>namespace)") { Builder = nodes => new RStar<CNamespace>(nodes) };
                /* 186 SeqOp            */ __Matchers[186] = new Mx.Seq(this, 186, "_186:(>prelude,'module',>names,>module-body,*(>namespace))") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 187 StringOp         */ __Matchers[187] = new Mx.String(this, 187, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 188 StarOp           */ __Matchers[188] = new Mx.Star(this, 188, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 189 StringOp         */ __Matchers[189] = new Mx.String(this, 189, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 191 StringOp         */ __Matchers[191] = new Mx.Keyword(this, 191, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 193 StarOp           */ __Matchers[193] = new Mx.Star(this, 193, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 194 StringOp         */ __Matchers[194] = new Mx.Keyword(this, 194, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 195 SeqOp            */ __Matchers[195] = new Mx.Seq(this, 195, "_195:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 196 OptionalOp       */ __Matchers[196] = new Mx.Optional(this, 196, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 197 SeqOp            */ __Matchers[197] = new Mx.Seq(this, 197, "_197:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 198 StringOp         */ __Matchers[198] = new Mx.String(this, 198, "','", ",") { Creator = node => new RLiteral(node) };
                /* 199 SeqOp            */ __Matchers[199] = new Mx.Seq(this, 199, "_199:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 200 StarOp           */ __Matchers[200] = new Mx.Star(this, 200, "*(_199:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:(>using-element,*(_199:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 202 AltOp            */ __Matchers[202] = new Mx.Alt(this, 202, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 203 OptionalOp       */ __Matchers[203] = new Mx.Optional(this, 203, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 204 OptionalOp       */ __Matchers[204] = new Mx.Optional(this, 204, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 206 StringOp         */ __Matchers[206] = new Mx.String(this, 206, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 208 StringOp         */ __Matchers[208] = new Mx.String(this, 208, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 209 StringOp         */ __Matchers[209] = new Mx.String(this, 209, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 210 SeqOp            */ __Matchers[210] = new Mx.Seq(this, 210, "_210:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 211 StarOp           */ __Matchers[211] = new Mx.Star(this, 211, "*(_210:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 212 SeqOp            */ __Matchers[212] = new Mx.Seq(this, 212, "_212:(>name,*(_210:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 213 OptionalOp       */ __Matchers[213] = new Mx.Optional(this, 213, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 214 SeqOp            */ __Matchers[214] = new Mx.Seq(this, 214, "_214:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 215 StringOp         */ __Matchers[215] = new Mx.String(this, 215, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 216 OptionalOp       */ __Matchers[216] = new Mx.Optional(this, 216, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 217 StringOp         */ __Matchers[217] = new Mx.String(this, 217, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 218 SeqOp            */ __Matchers[218] = new Mx.Seq(this, 218, "_218:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 220 StarOp           */ __Matchers[220] = new Mx.Star(this, 220, "*(_219:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:(>generic-argument,*(_219:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 222 OptionalOp       */ __Matchers[222] = new Mx.Optional(this, 222, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 223 SeqOp            */ __Matchers[223] = new Mx.Seq(this, 223, "_223:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 225 StarOp           */ __Matchers[225] = new Mx.Star(this, 225, "*(_224:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:(>generic-parameter,*(_224:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 227 OptionalOp       */ __Matchers[227] = new Mx.Optional(this, 227, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 228 OptionalOp       */ __Matchers[228] = new Mx.Optional(this, 228, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 229 SeqOp            */ __Matchers[229] = new Mx.Seq(this, 229, "_229:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 230 SeqOp            */ __Matchers[230] = new Mx.Seq(this, 230, "_230:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 231 StringOp         */ __Matchers[231] = new Mx.Keyword(this, 231, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 232 StringOp         */ __Matchers[232] = new Mx.Keyword(this, 232, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 233 AltOp            */ __Matchers[233] = new Mx.Alt(this, 233, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 234 StarOp           */ __Matchers[234] = new Mx.Star(this, 234, "*(>top-declaration)") { Builder = nodes => new CTopDeclarations(nodes) };
                /* 235 AltOp            */ __Matchers[235] = new Mx.Alt(this, 235, "alt(>function-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>let-declaration|>var-declaration)") { Builder = nodes => nodes[0] };
                /* 236 AltOp            */ __Matchers[236] = new Mx.Alt(this, 236, "alt(>universal-declaration|>constructor-declaration|>operator-declaration|>attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 237 AltOp            */ __Matchers[237] = new Mx.Alt(this, 237, "alt(>prefix-declaration|>infix-declaration)") { Builder = nodes => nodes[0] };
                /* 238 StringOp         */ __Matchers[238] = new Mx.Keyword(this, 238, "'prefix'", "prefix") { Creator = node => new RLiteral(node) };
                /* 239 StringOp         */ __Matchers[239] = new Mx.String(this, 239, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 240 StringOp         */ __Matchers[240] = new Mx.String(this, 240, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 241 SeqOp            */ __Matchers[241] = new Mx.Seq(this, 241, "_241:(>prelude,'prefix',>type,>prefix-operator,'(',')',>function-body)") { Builder = nodes => new CPrefixDeclaration(nodes) };
                /* 242 StringOp         */ __Matchers[242] = new Mx.String(this, 242, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 243 StringOp         */ __Matchers[243] = new Mx.String(this, 243, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 244 StringOp         */ __Matchers[244] = new Mx.String(this, 244, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 245 StringOp         */ __Matchers[245] = new Mx.String(this, 245, "'~'", "~") { Creator = node => new RLiteral(node) };
                /* 246 AltOp            */ __Matchers[246] = new Mx.Alt(this, 246, "alt('+'|'-'|'!'|'~')") { Builder = nodes => nodes[0] };
                /* 247 StringOp         */ __Matchers[247] = new Mx.Keyword(this, 247, "'infix'", "infix") { Creator = node => new RLiteral(node) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>prelude,'infix',>type,>infix-operator,'(',>definitive-parameter,')',>function-body)") { Builder = nodes => new CInfixDeclaration(nodes) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.String(this, 249, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 250 StringOp         */ __Matchers[250] = new Mx.String(this, 250, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 251 StringOp         */ __Matchers[251] = new Mx.String(this, 251, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 252 StringOp         */ __Matchers[252] = new Mx.String(this, 252, "'<<'", "<<") { Creator = node => new RLiteral(node) };
                /* 253 StringOp         */ __Matchers[253] = new Mx.String(this, 253, "'>>'", ">>") { Creator = node => new RLiteral(node) };
                /* 254 StringOp         */ __Matchers[254] = new Mx.String(this, 254, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 255 StringOp         */ __Matchers[255] = new Mx.String(this, 255, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 256 StringOp         */ __Matchers[256] = new Mx.String(this, 256, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 257 StringOp         */ __Matchers[257] = new Mx.String(this, 257, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 258 StringOp         */ __Matchers[258] = new Mx.String(this, 258, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 259 StringOp         */ __Matchers[259] = new Mx.String(this, 259, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 260 StringOp         */ __Matchers[260] = new Mx.String(this, 260, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 261 StringOp         */ __Matchers[261] = new Mx.String(this, 261, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 262 StringOp         */ __Matchers[262] = new Mx.String(this, 262, "'^'", "^") { Creator = node => new RLiteral(node) };
                /* 263 AltOp            */ __Matchers[263] = new Mx.Alt(this, 263, "alt('+'|'-'|'*'|'/'|'%'|'<<'|'>>'|'=='|'!='|'<'|'<='|'>'|'>='|'==='|'!=='|'&'|'|'|'^')") { Builder = nodes => nodes[0] };
                /* 264 OptionalOp       */ __Matchers[264] = new Mx.Optional(this, 264, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 265 OptionalOp       */ __Matchers[265] = new Mx.Optional(this, 265, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 266 SeqOp            */ __Matchers[266] = new Mx.Seq(this, 266, "_266:(>prelude,>type,>name,?(>generic-parameters),>parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 267 SeqOp            */ __Matchers[267] = new Mx.Seq(this, 267, "_267:(>prelude,>type,>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 268 StringOp         */ __Matchers[268] = new Mx.Keyword(this, 268, "'var'", "var") { Creator = node => new RLiteral(node) };
                /* 269 OptionalOp       */ __Matchers[269] = new Mx.Optional(this, 269, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 270 SeqOp            */ __Matchers[270] = new Mx.Seq(this, 270, "_270:(>prelude,'var',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CVarDeclaration(nodes) };
                /* 271 StringOp         */ __Matchers[271] = new Mx.Keyword(this, 271, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 272 SeqOp            */ __Matchers[272] = new Mx.Seq(this, 272, "_272:(>prelude,'let',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CLetDeclaration(nodes) };
                /* 273 StringOp         */ __Matchers[273] = new Mx.Keyword(this, 273, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 274 OptionalOp       */ __Matchers[274] = new Mx.Optional(this, 274, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 275 OptionalOp       */ __Matchers[275] = new Mx.Optional(this, 275, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 276 OptionalOp       */ __Matchers[276] = new Mx.Optional(this, 276, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(>prelude,'class',>name,?(>generic-parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>class-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 278 StringOp         */ __Matchers[278] = new Mx.Keyword(this, 278, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 279 SeqOp            */ __Matchers[279] = new Mx.Seq(this, 279, "_279:(>prelude,'interface',>name,?(>generic-parameters),?(>satisfies),?(>case-types),?(>constraints),>interface-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 280 StringOp         */ __Matchers[280] = new Mx.Keyword(this, 280, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 281 SeqOp            */ __Matchers[281] = new Mx.Seq(this, 281, "_281:(>prelude,'object',>name,?(>extends),?(>satisfies),>class-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 282 StringOp         */ __Matchers[282] = new Mx.Keyword(this, 282, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 283 StringOp         */ __Matchers[283] = new Mx.String(this, 283, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 284 SeqOp            */ __Matchers[284] = new Mx.Seq(this, 284, "_284:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 285 StringOp         */ __Matchers[285] = new Mx.Keyword(this, 285, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 286 OptionalOp       */ __Matchers[286] = new Mx.Optional(this, 286, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 287 SeqOp            */ __Matchers[287] = new Mx.Seq(this, 287, "_287:(>prelude,'new',?(>name),>parameters,?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 288 StarOp           */ __Matchers[288] = new Mx.Star(this, 288, "*(>class-member)") { Builder = nodes => new RStar<ICClassMember>(nodes) };
                /* 289 SeqOp            */ __Matchers[289] = new Mx.Seq(this, 289, "_289:('{',>usings,*(>class-member),'}')") { Builder = nodes => new CClassBody(nodes) };
                /* 290 StarOp           */ __Matchers[290] = new Mx.Star(this, 290, "*(>interface-member)") { Builder = nodes => new RStar<ICInterfaceMember>(nodes) };
                /* 291 SeqOp            */ __Matchers[291] = new Mx.Seq(this, 291, "_291:('{',>usings,*(>interface-member),'}')") { Builder = nodes => new CInterfaceBody(nodes) };
                /* 292 AltOp            */ __Matchers[292] = new Mx.Alt(this, 292, "alt(>universal-declaration|>constructor-declaration|>operator-declaration|>attribute-declaration|>let-declaration|>var-declaration)") { Builder = nodes => nodes[0] };
                /* 293 AltOp            */ __Matchers[293] = new Mx.Alt(this, 293, "alt(>universal-declaration|>constructor-declaration|>attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 294 AltOp            */ __Matchers[294] = new Mx.Alt(this, 294, "alt(>calc-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 296 StarOp           */ __Matchers[296] = new Mx.Star(this, 296, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 297 AltOp            */ __Matchers[297] = new Mx.Alt(this, 297, "alt(>statement|>nested-declaration)") { Builder = nodes => nodes[0] };
                /* 298 SeqOp            */ __Matchers[298] = new Mx.Seq(this, 298, "_298:(>function-specifier,';')") { Builder = nodes => new CCalcBody(nodes) };
                /* 299 SeqOp            */ __Matchers[299] = new Mx.Seq(this, 299, "_299:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 300 SeqOp            */ __Matchers[300] = new Mx.Seq(this, 300, "_300:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 301 StringOp         */ __Matchers[301] = new Mx.String(this, 301, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:(':',>extended-type)") { Builder = nodes => new CExtends(nodes) };
                /* 303 StringOp         */ __Matchers[303] = new Mx.Keyword(this, 303, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 304 SeqOp            */ __Matchers[304] = new Mx.Seq(this, 304, "_304:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 305 SeqOp            */ __Matchers[305] = new Mx.Seq(this, 305, "_305:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 306 StarOp           */ __Matchers[306] = new Mx.Star(this, 306, "*(_305:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:(>primary-type,*(_305:('&',>primary-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 308 PlusOp           */ __Matchers[308] = new Mx.Plus(this, 308, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 309 StringOp         */ __Matchers[309] = new Mx.Keyword(this, 309, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 310 SeqOp            */ __Matchers[310] = new Mx.Seq(this, 310, "_310:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 311 StringOp         */ __Matchers[311] = new Mx.Keyword(this, 311, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 312 SeqOp            */ __Matchers[312] = new Mx.Seq(this, 312, "_312:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 313 SeqOp            */ __Matchers[313] = new Mx.Seq(this, 313, "_313:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 314 StarOp           */ __Matchers[314] = new Mx.Star(this, 314, "*(_313:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 315 SeqOp            */ __Matchers[315] = new Mx.Seq(this, 315, "_315:(>type,*(_313:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 316 SeqOp            */ __Matchers[316] = new Mx.Seq(this, 316, "_316:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 317 OptionalOp       */ __Matchers[317] = new Mx.Optional(this, 317, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 318 StarOp           */ __Matchers[318] = new Mx.Star(this, 318, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 319 SeqOp            */ __Matchers[319] = new Mx.Seq(this, 319, "_319:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 320 OptionalOp       */ __Matchers[320] = new Mx.Optional(this, 320, "?(>arguments)") { Builder = nodes => new ROptional<CArguments>(nodes) };
                /* 321 SeqOp            */ __Matchers[321] = new Mx.Seq(this, 321, "_321:(>attribute-name,?(>arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 322 SeqOp            */ __Matchers[322] = new Mx.Seq(this, 322, "_322:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 323 StarOp           */ __Matchers[323] = new Mx.Star(this, 323, "*(_322:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 324 SeqOp            */ __Matchers[324] = new Mx.Seq(this, 324, "_324:(>intersection-type,*(_322:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 325 SeqOp            */ __Matchers[325] = new Mx.Seq(this, 325, "_325:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 326 StarOp           */ __Matchers[326] = new Mx.Star(this, 326, "*(_325:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 327 SeqOp            */ __Matchers[327] = new Mx.Seq(this, 327, "_327:(>primary-type,*(_325:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 328 AltOp            */ __Matchers[328] = new Mx.Alt(this, 328, "alt(>nullable-type|>array-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>nothing-type)") { Builder = nodes => nodes[0] };
                /* 329 StringOp         */ __Matchers[329] = new Mx.String(this, 329, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 330 SeqOp            */ __Matchers[330] = new Mx.Seq(this, 330, "_330:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 331 StringOp         */ __Matchers[331] = new Mx.String(this, 331, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 332 StringOp         */ __Matchers[332] = new Mx.String(this, 332, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 333 SeqOp            */ __Matchers[333] = new Mx.Seq(this, 333, "_333:(>primary-type,'[',']')") { Builder = nodes => new CArrayType(nodes) };
                /* 334 SeqOp            */ __Matchers[334] = new Mx.Seq(this, 334, "_334:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 335 OptionalOp       */ __Matchers[335] = new Mx.Optional(this, 335, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 336 SeqOp            */ __Matchers[336] = new Mx.Seq(this, 336, "_336:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 337 SeqOp            */ __Matchers[337] = new Mx.Seq(this, 337, "_337:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 338 StarOp           */ __Matchers[338] = new Mx.Star(this, 338, "*(_337:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 339 SeqOp            */ __Matchers[339] = new Mx.Seq(this, 339, "_339:(>type-list-type,*(_337:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 340 AltOp            */ __Matchers[340] = new Mx.Alt(this, 340, "alt(>type|>defaulted-type)") { Builder = nodes => nodes[0] };
                /* 341 SeqOp            */ __Matchers[341] = new Mx.Seq(this, 341, "_341:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 342 SeqOp            */ __Matchers[342] = new Mx.Seq(this, 342, "_342:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 343 SeqOp            */ __Matchers[343] = new Mx.Seq(this, 343, "_343:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 344 StringOp         */ __Matchers[344] = new Mx.Keyword(this, 344, "'Nothing'", "Nothing") { Creator = node => new RLiteral(node) };
                /* 345 SeqOp            */ __Matchers[345] = new Mx.Seq(this, 345, "_345:('Nothing')") { Builder = nodes => new CNothingType(nodes) };
                /* 346 OptionalOp       */ __Matchers[346] = new Mx.Optional(this, 346, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 347 SeqOp            */ __Matchers[347] = new Mx.Seq(this, 347, "_347:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 348 SeqOp            */ __Matchers[348] = new Mx.Seq(this, 348, "_348:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 349 StarOp           */ __Matchers[349] = new Mx.Star(this, 349, "*(_348:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 350 SeqOp            */ __Matchers[350] = new Mx.Seq(this, 350, "_350:(>parameter,*(_348:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 351 OptionalOp       */ __Matchers[351] = new Mx.Optional(this, 351, "?(>value-default)") { Builder = nodes => new ROptional<CValueDefault>(nodes) };
                /* 352 SeqOp            */ __Matchers[352] = new Mx.Seq(this, 352, "_352:(>prelude,>parameter-type,>name,?(>value-default))") { Builder = nodes => new CValueParameter(nodes) };
                /* 353 SeqOp            */ __Matchers[353] = new Mx.Seq(this, 353, "_353:(>prelude,>parameter-type,>name)") { Builder = nodes => new CDefinitiveParameter(nodes) };
                /* 354 SeqOp            */ __Matchers[354] = new Mx.Seq(this, 354, "_354:('=',>expression)") { Builder = nodes => new CValueDefault(nodes) };
                /* 355 OptionalOp       */ __Matchers[355] = new Mx.Optional(this, 355, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 356 SeqOp            */ __Matchers[356] = new Mx.Seq(this, 356, "_356:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 357 SeqOp            */ __Matchers[357] = new Mx.Seq(this, 357, "_357:(',',>expression)") { Builder = nodes => new RSequence(nodes) };
                /* 358 StarOp           */ __Matchers[358] = new Mx.Star(this, 358, "*(_357:(',',>expression))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 359 SeqOp            */ __Matchers[359] = new Mx.Seq(this, 359, "_359:(>expression,*(_357:(',',>expression)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 360 AltOp            */ __Matchers[360] = new Mx.Alt(this, 360, "alt(>assign-statement|>expression-statement|>if-statement|>for-statement|>while-statement|>assert-statement|>return-statement|>throw-statement)") { Builder = nodes => nodes[0] };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:(>primary-expression,'=',>expression,';')") { Builder = nodes => new CAssignStatement(nodes) };
                /* 362 SeqOp            */ __Matchers[362] = new Mx.Seq(this, 362, "_362:(>expression,';')") { Builder = nodes => new CExpressionStatement(nodes) };
                /* 363 StringOp         */ __Matchers[363] = new Mx.Keyword(this, 363, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 364 OptionalOp       */ __Matchers[364] = new Mx.Optional(this, 364, "?(>else-part)") { Builder = nodes => new ROptional<ICElsePart>(nodes) };
                /* 365 SeqOp            */ __Matchers[365] = new Mx.Seq(this, 365, "_365:('if',>conditions,>block-body,?(>else-part))") { Builder = nodes => new CIfStatement(nodes) };
                /* 366 AltOp            */ __Matchers[366] = new Mx.Alt(this, 366, "alt(>else-block|>else-if)") { Builder = nodes => nodes[0] };
                /* 367 StringOp         */ __Matchers[367] = new Mx.Keyword(this, 367, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 368 SeqOp            */ __Matchers[368] = new Mx.Seq(this, 368, "_368:('else',>if-statement)") { Builder = nodes => new CElseIf(nodes) };
                /* 369 SeqOp            */ __Matchers[369] = new Mx.Seq(this, 369, "_369:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 370 StringOp         */ __Matchers[370] = new Mx.Keyword(this, 370, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 371 OptionalOp       */ __Matchers[371] = new Mx.Optional(this, 371, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 372 SeqOp            */ __Matchers[372] = new Mx.Seq(this, 372, "_372:('for','(',>pattern,'in',>expression,')',>block-body,?(>else-block))") { Builder = nodes => new CForStatement(nodes) };
                /* 373 StringOp         */ __Matchers[373] = new Mx.Keyword(this, 373, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 374 SeqOp            */ __Matchers[374] = new Mx.Seq(this, 374, "_374:('while',>conditions,>block-body)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 375 StringOp         */ __Matchers[375] = new Mx.Keyword(this, 375, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 376 OptionalOp       */ __Matchers[376] = new Mx.Optional(this, 376, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 377 SeqOp            */ __Matchers[377] = new Mx.Seq(this, 377, "_377:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 378 StringOp         */ __Matchers[378] = new Mx.Keyword(this, 378, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:('throw',?(>expression),';')") { Builder = nodes => new CThrowStatement(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new Mx.Keyword(this, 380, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 381 SeqOp            */ __Matchers[381] = new Mx.Seq(this, 381, "_381:(?(>string-literal),'assert',>conditions,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 382 AltOp            */ __Matchers[382] = new Mx.Alt(this, 382, "alt(>if-expression|>level-coalesce-expression)") { Builder = nodes => nodes[0] };
                /* 383 AltOp            */ __Matchers[383] = new Mx.Alt(this, 383, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 384 StringOp         */ __Matchers[384] = new Mx.Keyword(this, 384, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 385 SeqOp            */ __Matchers[385] = new Mx.Seq(this, 385, "_385:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 386 SeqOp            */ __Matchers[386] = new Mx.Seq(this, 386, "_386:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 387 AltOp            */ __Matchers[387] = new Mx.Alt(this, 387, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 388 StringOp         */ __Matchers[388] = new Mx.String(this, 388, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 389 SeqOp            */ __Matchers[389] = new Mx.Seq(this, 389, "_389:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 390 AltOp            */ __Matchers[390] = new Mx.Alt(this, 390, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 391 StringOp         */ __Matchers[391] = new Mx.String(this, 391, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 392 SeqOp            */ __Matchers[392] = new Mx.Seq(this, 392, "_392:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 393 AltOp            */ __Matchers[393] = new Mx.Alt(this, 393, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 394 SeqOp            */ __Matchers[394] = new Mx.Seq(this, 394, "_394:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 395 AltOp            */ __Matchers[395] = new Mx.Alt(this, 395, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 396 SeqOp            */ __Matchers[396] = new Mx.Seq(this, 396, "_396:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 397 SeqOp            */ __Matchers[397] = new Mx.Seq(this, 397, "_397:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 398 SeqOp            */ __Matchers[398] = new Mx.Seq(this, 398, "_398:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 399 SeqOp            */ __Matchers[399] = new Mx.Seq(this, 399, "_399:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 400 AltOp            */ __Matchers[400] = new Mx.Alt(this, 400, "alt(>less-expression|>less-equal-expression|>greater-expression|>greater-equal-expression|>level-shift-expression)") { Builder = nodes => nodes[0] };
                /* 401 SeqOp            */ __Matchers[401] = new Mx.Seq(this, 401, "_401:(>level-shift-expression,'<',>level-shift-expression)") { Builder = nodes => new CLessExpression(nodes) };
                /* 402 SeqOp            */ __Matchers[402] = new Mx.Seq(this, 402, "_402:(>level-shift-expression,'<=',>level-shift-expression)") { Builder = nodes => new CLessEqualExpression(nodes) };
                /* 403 SeqOp            */ __Matchers[403] = new Mx.Seq(this, 403, "_403:(>level-shift-expression,'>',>level-shift-expression)") { Builder = nodes => new CGreaterExpression(nodes) };
                /* 404 SeqOp            */ __Matchers[404] = new Mx.Seq(this, 404, "_404:(>level-shift-expression,'>=',>level-shift-expression)") { Builder = nodes => new CGreaterEqualExpression(nodes) };
                /* 405 AltOp            */ __Matchers[405] = new Mx.Alt(this, 405, "alt(>shift-left-expression|>shift-right-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 406 SeqOp            */ __Matchers[406] = new Mx.Seq(this, 406, "_406:(>level-add-expression,'<<',>level-add-expression)") { Builder = nodes => new CShiftLeftExpression(nodes) };
                /* 407 SeqOp            */ __Matchers[407] = new Mx.Seq(this, 407, "_407:(>level-add-expression,'>>',>level-add-expression)") { Builder = nodes => new CShiftRightExpression(nodes) };
                /* 408 AltOp            */ __Matchers[408] = new Mx.Alt(this, 408, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 409 SeqOp            */ __Matchers[409] = new Mx.Seq(this, 409, "_409:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 410 SeqOp            */ __Matchers[410] = new Mx.Seq(this, 410, "_410:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 411 AltOp            */ __Matchers[411] = new Mx.Alt(this, 411, "alt(>mul-expression|>div-expression|>rem-expression|>level-union-expression)") { Builder = nodes => nodes[0] };
                /* 412 SeqOp            */ __Matchers[412] = new Mx.Seq(this, 412, "_412:(>level-mul-expression,'*',>level-union-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 413 SeqOp            */ __Matchers[413] = new Mx.Seq(this, 413, "_413:(>level-mul-expression,'/',>level-union-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 414 SeqOp            */ __Matchers[414] = new Mx.Seq(this, 414, "_414:(>level-mul-expression,'%',>level-union-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 415 AltOp            */ __Matchers[415] = new Mx.Alt(this, 415, "alt(>union-expression|>complement-expression|>level-exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 416 SeqOp            */ __Matchers[416] = new Mx.Seq(this, 416, "_416:(>level-union-expression,'|',>level-exclusive-expression)") { Builder = nodes => new CUnionExpression(nodes) };
                /* 417 SeqOp            */ __Matchers[417] = new Mx.Seq(this, 417, "_417:(>level-union-expression,'~',>level-exclusive-expression)") { Builder = nodes => new CComplementExpression(nodes) };
                /* 418 AltOp            */ __Matchers[418] = new Mx.Alt(this, 418, "alt(>exclusive-expression|>level-intersection-expression)") { Builder = nodes => nodes[0] };
                /* 419 SeqOp            */ __Matchers[419] = new Mx.Seq(this, 419, "_419:(>level-exclusive-expression,'^',>level-intersection-expression)") { Builder = nodes => new CExclusiveExpression(nodes) };
                /* 420 AltOp            */ __Matchers[420] = new Mx.Alt(this, 420, "alt(>intersection-expression|>level-negate-expression)") { Builder = nodes => nodes[0] };
                /* 421 SeqOp            */ __Matchers[421] = new Mx.Seq(this, 421, "_421:(>level-intersection-expression,'&',>level-negate-expression)") { Builder = nodes => new CIntersectionExpression(nodes) };
                /* 422 AltOp            */ __Matchers[422] = new Mx.Alt(this, 422, "alt(>negate-expression|>positive-expression|>compl-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 423 SeqOp            */ __Matchers[423] = new Mx.Seq(this, 423, "_423:('-',>level-negate-expression)") { Builder = nodes => new CNegateExpression(nodes) };
                /* 424 SeqOp            */ __Matchers[424] = new Mx.Seq(this, 424, "_424:('+',>level-negate-expression)") { Builder = nodes => new CPositiveExpression(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Mx.Seq(this, 425, "_425:('~',>level-negate-expression)") { Builder = nodes => new CComplExpression(nodes) };
                /* 426 AltOp            */ __Matchers[426] = new Mx.Alt(this, 426, "alt(>reference|>literal|>string-expression|>call-expression|>select-expression|>nullsafe-select-expression|>grouped-expression)") { Builder = nodes => nodes[0] };
                /* 427 SeqOp            */ __Matchers[427] = new Mx.Seq(this, 427, "_427:('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 428 SeqOp            */ __Matchers[428] = new Mx.Seq(this, 428, "_428:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 429 SeqOp            */ __Matchers[429] = new Mx.Seq(this, 429, "_429:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 430 StringOp         */ __Matchers[430] = new Mx.String(this, 430, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 431 SeqOp            */ __Matchers[431] = new Mx.Seq(this, 431, "_431:(>primary-expression,'?.',>reference)") { Builder = nodes => new CNullsafeSelectExpression(nodes) };
                /* 432 AltOp            */ __Matchers[432] = new Mx.Alt(this, 432, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 433 AltOp            */ __Matchers[433] = new Mx.Alt(this, 433, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 434 StarOp           */ __Matchers[434] = new Mx.Star(this, 434, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 435 SeqOp            */ __Matchers[435] = new Mx.Seq(this, 435, "_435:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 436 SeqOp            */ __Matchers[436] = new Mx.Seq(this, 436, "_436:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 437 SeqOp            */ __Matchers[437] = new Mx.Seq(this, 437, "_437:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 438 SeqOp            */ __Matchers[438] = new Mx.Seq(this, 438, "_438:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 439 SeqOp            */ __Matchers[439] = new Mx.Seq(this, 439, "_439:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 440 AltOp            */ __Matchers[440] = new Mx.Alt(this, 440, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 441 SeqOp            */ __Matchers[441] = new Mx.Seq(this, 441, "_441:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 442 SeqOp            */ __Matchers[442] = new Mx.Seq(this, 442, "_442:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 443 StarOp           */ __Matchers[443] = new Mx.Star(this, 443, "*(_442:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 444 SeqOp            */ __Matchers[444] = new Mx.Seq(this, 444, "_444:(>condition,*(_442:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 445 AltOp            */ __Matchers[445] = new Mx.Alt(this, 445, "alt(>is-condition|>expression)") { Builder = nodes => nodes[0] };
                /* 446 OptionalOp       */ __Matchers[446] = new Mx.Optional(this, 446, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Mx.Seq(this, 447, "_447:(?('!'),'is',>type,>name)") { Builder = nodes => new CIsCondition(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[177]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[178]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[179]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[182]);
                /*   6 PlainRuleOp      */ _namespaceIntro.Set(__Matchers[183]);
                /*   7 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[186]);
                /*   8 PlainRuleOp      */ _moduleBody.Set(__Matchers[190]);
                /*   9 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*  10 PlainRuleOp      */ _moduleImport.Set(__Matchers[192]);
                /*  11 PlainRuleOp      */ _usings.Set(__Matchers[193]);
                /*  12 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[195]);
                /*  13 PlainRuleOp      */ _usingElements.Set(__Matchers[197]);
                /*  14 PlainRuleOp      */ _usingElementList.Set(__Matchers[201]);
                /*  15 PlainRuleOp      */ _usingElement.Set(__Matchers[202]);
                /*  16 PlainRuleOp      */ _usingNamed.Set(__Matchers[205]);
                /*  17 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  18 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[207]);
                /*  19 PlainRuleOp      */ _usingWildcard.Set(__Matchers[208]);
                /*  20 PlainRuleOp      */ _name.Set(_identifier);
                /*  21 PlainRuleOp      */ _names.Set(__Matchers[212]);
                /*  22 PlainRuleOp      */ _reference.Set(__Matchers[214]);
                /*  23 PlainRuleOp      */ _genericArguments.Set(__Matchers[218]);
                /*  24 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[221]);
                /*  25 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  26 PlainRuleOp      */ _genericParameters.Set(__Matchers[223]);
                /*  27 PlainRuleOp      */ _genericParameterList.Set(__Matchers[226]);
                /*  28 PlainRuleOp      */ _genericParameter.Set(__Matchers[229]);
                /*  29 PlainRuleOp      */ _typeDefault.Set(__Matchers[230]);
                /*  30 PlainRuleOp      */ _variance.Set(__Matchers[233]);
                /*  31 PlainRuleOp      */ _topDeclarations.Set(__Matchers[234]);
                /*  32 PlainRuleOp      */ _topDeclaration.Set(_universalDeclaration);
                /*  33 PlainRuleOp      */ _universalDeclaration.Set(__Matchers[235]);
                /*  34 PlainRuleOp      */ _nestedDeclaration.Set(__Matchers[236]);
                /*  35 PlainRuleOp      */ _operatorDeclaration.Set(__Matchers[237]);
                /*  36 PlainRuleOp      */ _prefixDeclaration.Set(__Matchers[241]);
                /*  37 PlainRuleOp      */ _prefixOperator.Set(__Matchers[246]);
                /*  38 PlainRuleOp      */ _infixDeclaration.Set(__Matchers[248]);
                /*  39 PlainRuleOp      */ _infixOperator.Set(__Matchers[263]);
                /*  40 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[266]);
                /*  41 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[267]);
                /*  42 PlainRuleOp      */ _varDeclaration.Set(__Matchers[270]);
                /*  43 PlainRuleOp      */ _letDeclaration.Set(__Matchers[272]);
                /*  44 PlainRuleOp      */ _classDeclaration.Set(__Matchers[277]);
                /*  45 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[279]);
                /*  46 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[281]);
                /*  47 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[284]);
                /*  48 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[287]);
                /*  49 PlainRuleOp      */ _classBody.Set(__Matchers[289]);
                /*  50 PlainRuleOp      */ _interfaceBody.Set(__Matchers[291]);
                /*  51 PlainRuleOp      */ _classMember.Set(__Matchers[292]);
                /*  52 PlainRuleOp      */ _interfaceMember.Set(__Matchers[293]);
                /*  53 PlainRuleOp      */ _functionBody.Set(__Matchers[294]);
                /*  54 PlainRuleOp      */ _attributeBody.Set(__Matchers[294]);
                /*  55 PlainRuleOp      */ _blockBody.Set(__Matchers[295]);
                /*  56 PlainRuleOp      */ _statelarations.Set(__Matchers[296]);
                /*  57 PlainRuleOp      */ _statelaration.Set(__Matchers[297]);
                /*  58 PlainRuleOp      */ _calcBody.Set(__Matchers[298]);
                /*  59 PlainRuleOp      */ _nullBody.Set(__Matchers[299]);
                /*  60 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[300]);
                /*  61 PlainRuleOp      */ _extends.Set(__Matchers[302]);
                /*  62 PlainRuleOp      */ _extendedType.Set(_type);
                /*  63 PlainRuleOp      */ _satisfies.Set(__Matchers[304]);
                /*  64 PlainRuleOp      */ _unionTypeList.Set(__Matchers[307]);
                /*  65 PlainRuleOp      */ _constraints.Set(__Matchers[308]);
                /*  66 PlainRuleOp      */ _constraint.Set(__Matchers[310]);
                /*  67 PlainRuleOp      */ _caseTypes.Set(__Matchers[312]);
                /*  68 PlainRuleOp      */ _caseTypeList.Set(__Matchers[315]);
                /*  69 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  70 PlainRuleOp      */ _namePattern.Set(__Matchers[316]);
                /*  71 PlainRuleOp      */ _prelude.Set(__Matchers[319]);
                /*  72 PlainRuleOp      */ _attribute.Set(__Matchers[321]);
                /*  73 DfaRuleOp        */ _attributeName.Set(_attributeName_DFA);
                /*  74 PlainRuleOp      */ _type.Set(_unionType);
                /*  75 PlainRuleOp      */ _unionType.Set(__Matchers[324]);
                /*  76 PlainRuleOp      */ _intersectionType.Set(__Matchers[327]);
                /*  77 PlainRuleOp      */ _primaryType.Set(__Matchers[328]);
                /*  78 PlainRuleOp      */ _nullableType.Set(__Matchers[330]);
                /*  79 PlainRuleOp      */ _arrayType.Set(__Matchers[333]);
                /*  80 PlainRuleOp      */ _typeSelector.Set(__Matchers[334]);
                /*  81 PlainRuleOp      */ _callableType.Set(__Matchers[336]);
                /*  82 PlainRuleOp      */ _callableArguments.Set(_typeList);
                /*  83 PlainRuleOp      */ _typeList.Set(__Matchers[339]);
                /*  84 PlainRuleOp      */ _typeListType.Set(__Matchers[340]);
                /*  85 PlainRuleOp      */ _defaultedType.Set(__Matchers[341]);
                /*  86 PlainRuleOp      */ _emptyType.Set(__Matchers[342]);
                /*  87 PlainRuleOp      */ _tupleType.Set(__Matchers[343]);
                /*  88 PlainRuleOp      */ _nothingType.Set(__Matchers[345]);
                /*  89 PlainRuleOp      */ _parameters.Set(__Matchers[347]);
                /*  90 PlainRuleOp      */ _parameterList.Set(__Matchers[350]);
                /*  91 PlainRuleOp      */ _parameter.Set(_valueParameter);
                /*  92 PlainRuleOp      */ _valueParameter.Set(__Matchers[352]);
                /*  93 PlainRuleOp      */ _definitiveParameter.Set(__Matchers[353]);
                /*  94 PlainRuleOp      */ _valueDefault.Set(__Matchers[354]);
                /*  95 PlainRuleOp      */ _parameterType.Set(_type);
                /*  96 PlainRuleOp      */ _arguments.Set(__Matchers[356]);
                /*  97 PlainRuleOp      */ _argumentList.Set(__Matchers[359]);
                /*  98 PlainRuleOp      */ _statement.Set(__Matchers[360]);
                /*  99 PlainRuleOp      */ _assignStatement.Set(__Matchers[361]);
                /* 100 PlainRuleOp      */ _expressionStatement.Set(__Matchers[362]);
                /* 101 PlainRuleOp      */ _ifStatement.Set(__Matchers[365]);
                /* 102 PlainRuleOp      */ _elsePart.Set(__Matchers[366]);
                /* 103 PlainRuleOp      */ _elseIf.Set(__Matchers[368]);
                /* 104 PlainRuleOp      */ _elseBlock.Set(__Matchers[369]);
                /* 105 PlainRuleOp      */ _forStatement.Set(__Matchers[372]);
                /* 106 PlainRuleOp      */ _whileStatement.Set(__Matchers[374]);
                /* 107 PlainRuleOp      */ _returnStatement.Set(__Matchers[377]);
                /* 108 PlainRuleOp      */ _throwStatement.Set(__Matchers[379]);
                /* 109 PlainRuleOp      */ _assertStatement.Set(__Matchers[381]);
                /* 110 PlainRuleOp      */ _expression.Set(__Matchers[382]);
                /* 111 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[383]);
                /* 112 PlainRuleOp      */ _thenExpression.Set(__Matchers[385]);
                /* 113 PlainRuleOp      */ _elseExpression.Set(__Matchers[386]);
                /* 114 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[387]);
                /* 115 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[389]);
                /* 116 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[390]);
                /* 117 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[392]);
                /* 118 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[393]);
                /* 119 PlainRuleOp      */ _notExpression.Set(__Matchers[394]);
                /* 120 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[395]);
                /* 121 PlainRuleOp      */ _equalExpression.Set(__Matchers[396]);
                /* 122 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[397]);
                /* 123 PlainRuleOp      */ _identicalExpression.Set(__Matchers[398]);
                /* 124 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[399]);
                /* 125 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[400]);
                /* 126 PlainRuleOp      */ _lessExpression.Set(__Matchers[401]);
                /* 127 PlainRuleOp      */ _lessEqualExpression.Set(__Matchers[402]);
                /* 128 PlainRuleOp      */ _greaterExpression.Set(__Matchers[403]);
                /* 129 PlainRuleOp      */ _greaterEqualExpression.Set(__Matchers[404]);
                /* 130 PlainRuleOp      */ _levelShiftExpression.Set(__Matchers[405]);
                /* 131 PlainRuleOp      */ _shiftLeftExpression.Set(__Matchers[406]);
                /* 132 PlainRuleOp      */ _shiftRightExpression.Set(__Matchers[407]);
                /* 133 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[408]);
                /* 134 PlainRuleOp      */ _addExpression.Set(__Matchers[409]);
                /* 135 PlainRuleOp      */ _subExpression.Set(__Matchers[410]);
                /* 136 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[411]);
                /* 137 PlainRuleOp      */ _mulExpression.Set(__Matchers[412]);
                /* 138 PlainRuleOp      */ _divExpression.Set(__Matchers[413]);
                /* 139 PlainRuleOp      */ _remExpression.Set(__Matchers[414]);
                /* 140 PlainRuleOp      */ _levelUnionExpression.Set(__Matchers[415]);
                /* 141 PlainRuleOp      */ _unionExpression.Set(__Matchers[416]);
                /* 142 PlainRuleOp      */ _complementExpression.Set(__Matchers[417]);
                /* 143 PlainRuleOp      */ _levelExclusiveExpression.Set(__Matchers[418]);
                /* 144 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[419]);
                /* 145 PlainRuleOp      */ _levelIntersectionExpression.Set(__Matchers[420]);
                /* 146 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[421]);
                /* 147 PlainRuleOp      */ _levelNegateExpression.Set(__Matchers[422]);
                /* 148 PlainRuleOp      */ _negateExpression.Set(__Matchers[423]);
                /* 149 PlainRuleOp      */ _positiveExpression.Set(__Matchers[424]);
                /* 150 PlainRuleOp      */ _complExpression.Set(__Matchers[425]);
                /* 151 PlainRuleOp      */ _primaryExpression.Set(__Matchers[426]);
                /* 152 PlainRuleOp      */ _groupedExpression.Set(__Matchers[427]);
                /* 153 PlainRuleOp      */ _callExpression.Set(__Matchers[428]);
                /* 154 PlainRuleOp      */ _selectExpression.Set(__Matchers[429]);
                /* 155 PlainRuleOp      */ _nullsafeSelectExpression.Set(__Matchers[431]);
                /* 156 PlainRuleOp      */ _literal.Set(_naturalLiteral);
                /* 157 PlainRuleOp      */ _stringExpression.Set(__Matchers[432]);
                /* 158 PlainRuleOp      */ _stringLiteral.Set(__Matchers[433]);
                /* 159 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[435]);
                /* 160 PlainRuleOp      */ _interpolationPart.Set(__Matchers[436]);
                /* 161 PlainRuleOp      */ _ifExpression.Set(__Matchers[437]);
                /* 162 PlainRuleOp      */ _ifThen.Set(__Matchers[438]);
                /* 163 PlainRuleOp      */ _ifElse.Set(__Matchers[439]);
                /* 164 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[440]);
                /* 165 PlainRuleOp      */ _conditions.Set(__Matchers[441]);
                /* 166 PlainRuleOp      */ _conditionList.Set(__Matchers[444]);
                /* 167 PlainRuleOp      */ _condition.Set(__Matchers[445]);
                /* 168 PlainRuleOp      */ _isCondition.Set(__Matchers[447]);
                /* 169 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 170 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 171 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 172 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 173 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 174 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 175 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 177 SeqOp            */ __Matchers[177].Set(_compilationUnit, __Matchers[176]);
                /* 178 AltOp            */ __Matchers[178].Set(_moduleDescriptor, _codeUnit);
                /* 179 SeqOp            */ __Matchers[179].Set(_namespaceIntro, _usings, _topDeclarations);
                /* 182 SeqOp            */ __Matchers[182].Set(_prelude, __Matchers[180], _names, __Matchers[181]);
                /* 183 SeqOp            */ __Matchers[183].Set(__Matchers[180], _names, __Matchers[181]);
                /* 185 StarOp           */ __Matchers[185].Set(_namespace);
                /* 186 SeqOp            */ __Matchers[186].Set(_prelude, __Matchers[184], _names, _moduleBody, __Matchers[185]);
                /* 188 StarOp           */ __Matchers[188].Set(_moduleBodyElement);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[187], __Matchers[188], __Matchers[189]);
                /* 192 SeqOp            */ __Matchers[192].Set(__Matchers[191], _names, __Matchers[181]);
                /* 193 StarOp           */ __Matchers[193].Set(_usingDeclaration);
                /* 195 SeqOp            */ __Matchers[195].Set(__Matchers[194], _names, _usingElements);
                /* 196 OptionalOp       */ __Matchers[196].Set(_usingElementList);
                /* 197 SeqOp            */ __Matchers[197].Set(__Matchers[187], __Matchers[196], __Matchers[189]);
                /* 199 SeqOp            */ __Matchers[199].Set(__Matchers[198], _usingElement);
                /* 200 StarOp           */ __Matchers[200].Set(__Matchers[199]);
                /* 201 SeqOp            */ __Matchers[201].Set(_usingElement, __Matchers[200]);
                /* 202 AltOp            */ __Matchers[202].Set(_usingNamed, _usingWildcard);
                /* 203 OptionalOp       */ __Matchers[203].Set(_usingNameSpecifier);
                /* 204 OptionalOp       */ __Matchers[204].Set(_usingElements);
                /* 205 SeqOp            */ __Matchers[205].Set(_usingName, __Matchers[203], __Matchers[204]);
                /* 207 SeqOp            */ __Matchers[207].Set(__Matchers[206], _identifier);
                /* 210 SeqOp            */ __Matchers[210].Set(__Matchers[209], _name);
                /* 211 StarOp           */ __Matchers[211].Set(__Matchers[210]);
                /* 212 SeqOp            */ __Matchers[212].Set(_name, __Matchers[211]);
                /* 213 OptionalOp       */ __Matchers[213].Set(_genericArguments);
                /* 214 SeqOp            */ __Matchers[214].Set(_name, __Matchers[213]);
                /* 216 OptionalOp       */ __Matchers[216].Set(_genericArgumentList);
                /* 218 SeqOp            */ __Matchers[218].Set(__Matchers[215], __Matchers[216], __Matchers[217]);
                /* 219 SeqOp            */ __Matchers[219].Set(__Matchers[198], _genericArgument);
                /* 220 StarOp           */ __Matchers[220].Set(__Matchers[219]);
                /* 221 SeqOp            */ __Matchers[221].Set(_genericArgument, __Matchers[220]);
                /* 222 OptionalOp       */ __Matchers[222].Set(_genericParameterList);
                /* 223 SeqOp            */ __Matchers[223].Set(__Matchers[215], __Matchers[222], __Matchers[217]);
                /* 224 SeqOp            */ __Matchers[224].Set(__Matchers[198], _genericParameter);
                /* 225 StarOp           */ __Matchers[225].Set(__Matchers[224]);
                /* 226 SeqOp            */ __Matchers[226].Set(_genericParameter, __Matchers[225]);
                /* 227 OptionalOp       */ __Matchers[227].Set(_variance);
                /* 228 OptionalOp       */ __Matchers[228].Set(_typeDefault);
                /* 229 SeqOp            */ __Matchers[229].Set(__Matchers[227], _name, __Matchers[228]);
                /* 230 SeqOp            */ __Matchers[230].Set(__Matchers[206], _type);
                /* 233 AltOp            */ __Matchers[233].Set(__Matchers[231], __Matchers[232]);
                /* 234 StarOp           */ __Matchers[234].Set(_topDeclaration);
                /* 235 AltOp            */ __Matchers[235].Set(_functionDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _letDeclaration, _varDeclaration);
                /* 236 AltOp            */ __Matchers[236].Set(_universalDeclaration, _constructorDeclaration, _operatorDeclaration, _attributeDeclaration);
                /* 237 AltOp            */ __Matchers[237].Set(_prefixDeclaration, _infixDeclaration);
                /* 241 SeqOp            */ __Matchers[241].Set(_prelude, __Matchers[238], _type, _prefixOperator, __Matchers[239], __Matchers[240], _functionBody);
                /* 246 AltOp            */ __Matchers[246].Set(__Matchers[242], __Matchers[243], __Matchers[244], __Matchers[245]);
                /* 248 SeqOp            */ __Matchers[248].Set(_prelude, __Matchers[247], _type, _infixOperator, __Matchers[239], _definitiveParameter, __Matchers[240], _functionBody);
                /* 263 AltOp            */ __Matchers[263].Set(__Matchers[242], __Matchers[243], __Matchers[249], __Matchers[250], __Matchers[251], __Matchers[252], __Matchers[253], __Matchers[254], __Matchers[255], __Matchers[215], __Matchers[256], __Matchers[217], __Matchers[257], __Matchers[258], __Matchers[259], __Matchers[260], __Matchers[261], __Matchers[262]);
                /* 264 OptionalOp       */ __Matchers[264].Set(_genericParameters);
                /* 265 OptionalOp       */ __Matchers[265].Set(_constraints);
                /* 266 SeqOp            */ __Matchers[266].Set(_prelude, _type, _name, __Matchers[264], _parameters, __Matchers[265], _functionBody);
                /* 267 SeqOp            */ __Matchers[267].Set(_prelude, _type, _name, _attributeBody);
                /* 269 OptionalOp       */ __Matchers[269].Set(_type);
                /* 270 SeqOp            */ __Matchers[270].Set(_prelude, __Matchers[268], __Matchers[269], _name, __Matchers[206], _expression, __Matchers[181]);
                /* 272 SeqOp            */ __Matchers[272].Set(_prelude, __Matchers[271], __Matchers[269], _name, __Matchers[206], _expression, __Matchers[181]);
                /* 274 OptionalOp       */ __Matchers[274].Set(_extends);
                /* 275 OptionalOp       */ __Matchers[275].Set(_satisfies);
                /* 276 OptionalOp       */ __Matchers[276].Set(_caseTypes);
                /* 277 SeqOp            */ __Matchers[277].Set(_prelude, __Matchers[273], _name, __Matchers[264], __Matchers[274], __Matchers[275], __Matchers[276], __Matchers[265], _classBody);
                /* 279 SeqOp            */ __Matchers[279].Set(_prelude, __Matchers[278], _name, __Matchers[264], __Matchers[275], __Matchers[276], __Matchers[265], _interfaceBody);
                /* 281 SeqOp            */ __Matchers[281].Set(_prelude, __Matchers[280], _name, __Matchers[274], __Matchers[275], _classBody);
                /* 284 SeqOp            */ __Matchers[284].Set(_prelude, __Matchers[282], _name, __Matchers[264], __Matchers[265], __Matchers[283], _type, __Matchers[181]);
                /* 286 OptionalOp       */ __Matchers[286].Set(_name);
                /* 287 SeqOp            */ __Matchers[287].Set(_prelude, __Matchers[285], __Matchers[286], _parameters, __Matchers[274], _functionBody);
                /* 288 StarOp           */ __Matchers[288].Set(_classMember);
                /* 289 SeqOp            */ __Matchers[289].Set(__Matchers[187], _usings, __Matchers[288], __Matchers[189]);
                /* 290 StarOp           */ __Matchers[290].Set(_interfaceMember);
                /* 291 SeqOp            */ __Matchers[291].Set(__Matchers[187], _usings, __Matchers[290], __Matchers[189]);
                /* 292 AltOp            */ __Matchers[292].Set(_universalDeclaration, _constructorDeclaration, _operatorDeclaration, _attributeDeclaration, _letDeclaration, _varDeclaration);
                /* 293 AltOp            */ __Matchers[293].Set(_universalDeclaration, _constructorDeclaration, _attributeDeclaration);
                /* 294 AltOp            */ __Matchers[294].Set(_calcBody, _blockBody, _nullBody);
                /* 295 SeqOp            */ __Matchers[295].Set(__Matchers[187], _usings, _statelarations, __Matchers[189]);
                /* 296 StarOp           */ __Matchers[296].Set(_statelaration);
                /* 297 AltOp            */ __Matchers[297].Set(_statement, _nestedDeclaration);
                /* 298 SeqOp            */ __Matchers[298].Set(_functionSpecifier, __Matchers[181]);
                /* 299 SeqOp            */ __Matchers[299].Set(__Matchers[181]);
                /* 300 SeqOp            */ __Matchers[300].Set(__Matchers[283], _expression);
                /* 302 SeqOp            */ __Matchers[302].Set(__Matchers[301], _extendedType);
                /* 304 SeqOp            */ __Matchers[304].Set(__Matchers[303], _unionTypeList);
                /* 305 SeqOp            */ __Matchers[305].Set(__Matchers[260], _primaryType);
                /* 306 StarOp           */ __Matchers[306].Set(__Matchers[305]);
                /* 307 SeqOp            */ __Matchers[307].Set(_primaryType, __Matchers[306]);
                /* 308 PlusOp           */ __Matchers[308].Set(_constraint);
                /* 310 SeqOp            */ __Matchers[310].Set(__Matchers[309], _name, __Matchers[264], __Matchers[276], __Matchers[275]);
                /* 312 SeqOp            */ __Matchers[312].Set(__Matchers[311], _caseTypeList);
                /* 313 SeqOp            */ __Matchers[313].Set(__Matchers[261], _type);
                /* 314 StarOp           */ __Matchers[314].Set(__Matchers[313]);
                /* 315 SeqOp            */ __Matchers[315].Set(_type, __Matchers[314]);
                /* 316 SeqOp            */ __Matchers[316].Set(_name);
                /* 317 OptionalOp       */ __Matchers[317].Set(_stringLiteral);
                /* 318 StarOp           */ __Matchers[318].Set(_attribute);
                /* 319 SeqOp            */ __Matchers[319].Set(__Matchers[317], __Matchers[318]);
                /* 320 OptionalOp       */ __Matchers[320].Set(_arguments);
                /* 321 SeqOp            */ __Matchers[321].Set(_attributeName, __Matchers[320]);
                /* 322 SeqOp            */ __Matchers[322].Set(__Matchers[261], _intersectionType);
                /* 323 StarOp           */ __Matchers[323].Set(__Matchers[322]);
                /* 324 SeqOp            */ __Matchers[324].Set(_intersectionType, __Matchers[323]);
                /* 325 SeqOp            */ __Matchers[325].Set(__Matchers[260], _primaryType);
                /* 326 StarOp           */ __Matchers[326].Set(__Matchers[325]);
                /* 327 SeqOp            */ __Matchers[327].Set(_primaryType, __Matchers[326]);
                /* 328 AltOp            */ __Matchers[328].Set(_nullableType, _arrayType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _nothingType);
                /* 330 SeqOp            */ __Matchers[330].Set(_primaryType, __Matchers[329]);
                /* 333 SeqOp            */ __Matchers[333].Set(_primaryType, __Matchers[331], __Matchers[332]);
                /* 334 SeqOp            */ __Matchers[334].Set(_primaryType, __Matchers[209], _reference);
                /* 335 OptionalOp       */ __Matchers[335].Set(_callableArguments);
                /* 336 SeqOp            */ __Matchers[336].Set(_primaryType, __Matchers[239], __Matchers[335], __Matchers[240]);
                /* 337 SeqOp            */ __Matchers[337].Set(__Matchers[198], _typeListType);
                /* 338 StarOp           */ __Matchers[338].Set(__Matchers[337]);
                /* 339 SeqOp            */ __Matchers[339].Set(_typeListType, __Matchers[338]);
                /* 340 AltOp            */ __Matchers[340].Set(_type, _defaultedType);
                /* 341 SeqOp            */ __Matchers[341].Set(_type, __Matchers[206]);
                /* 342 SeqOp            */ __Matchers[342].Set(__Matchers[331], __Matchers[332]);
                /* 343 SeqOp            */ __Matchers[343].Set(__Matchers[331], _typeList, __Matchers[332]);
                /* 345 SeqOp            */ __Matchers[345].Set(__Matchers[344]);
                /* 346 OptionalOp       */ __Matchers[346].Set(_parameterList);
                /* 347 SeqOp            */ __Matchers[347].Set(__Matchers[239], __Matchers[346], __Matchers[240]);
                /* 348 SeqOp            */ __Matchers[348].Set(__Matchers[198], _parameter);
                /* 349 StarOp           */ __Matchers[349].Set(__Matchers[348]);
                /* 350 SeqOp            */ __Matchers[350].Set(_parameter, __Matchers[349]);
                /* 351 OptionalOp       */ __Matchers[351].Set(_valueDefault);
                /* 352 SeqOp            */ __Matchers[352].Set(_prelude, _parameterType, _name, __Matchers[351]);
                /* 353 SeqOp            */ __Matchers[353].Set(_prelude, _parameterType, _name);
                /* 354 SeqOp            */ __Matchers[354].Set(__Matchers[206], _expression);
                /* 355 OptionalOp       */ __Matchers[355].Set(_argumentList);
                /* 356 SeqOp            */ __Matchers[356].Set(__Matchers[239], __Matchers[355], __Matchers[240]);
                /* 357 SeqOp            */ __Matchers[357].Set(__Matchers[198], _expression);
                /* 358 StarOp           */ __Matchers[358].Set(__Matchers[357]);
                /* 359 SeqOp            */ __Matchers[359].Set(_expression, __Matchers[358]);
                /* 360 AltOp            */ __Matchers[360].Set(_assignStatement, _expressionStatement, _ifStatement, _forStatement, _whileStatement, _assertStatement, _returnStatement, _throwStatement);
                /* 361 SeqOp            */ __Matchers[361].Set(_primaryExpression, __Matchers[206], _expression, __Matchers[181]);
                /* 362 SeqOp            */ __Matchers[362].Set(_expression, __Matchers[181]);
                /* 364 OptionalOp       */ __Matchers[364].Set(_elsePart);
                /* 365 SeqOp            */ __Matchers[365].Set(__Matchers[363], _conditions, _blockBody, __Matchers[364]);
                /* 366 AltOp            */ __Matchers[366].Set(_elseBlock, _elseIf);
                /* 368 SeqOp            */ __Matchers[368].Set(__Matchers[367], _ifStatement);
                /* 369 SeqOp            */ __Matchers[369].Set(__Matchers[367], _blockBody);
                /* 371 OptionalOp       */ __Matchers[371].Set(_elseBlock);
                /* 372 SeqOp            */ __Matchers[372].Set(__Matchers[370], __Matchers[239], _pattern, __Matchers[231], _expression, __Matchers[240], _blockBody, __Matchers[371]);
                /* 374 SeqOp            */ __Matchers[374].Set(__Matchers[373], _conditions, _blockBody);
                /* 376 OptionalOp       */ __Matchers[376].Set(_expression);
                /* 377 SeqOp            */ __Matchers[377].Set(__Matchers[375], __Matchers[376], __Matchers[181]);
                /* 379 SeqOp            */ __Matchers[379].Set(__Matchers[378], __Matchers[376], __Matchers[181]);
                /* 381 SeqOp            */ __Matchers[381].Set(__Matchers[317], __Matchers[380], _conditions, __Matchers[181]);
                /* 382 AltOp            */ __Matchers[382].Set(_ifExpression, _levelCoalesceExpression);
                /* 383 AltOp            */ __Matchers[383].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 385 SeqOp            */ __Matchers[385].Set(_levelCoalesceExpression, __Matchers[384], _levelDisjunctionExpression);
                /* 386 SeqOp            */ __Matchers[386].Set(_levelCoalesceExpression, __Matchers[367], _levelDisjunctionExpression);
                /* 387 AltOp            */ __Matchers[387].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 389 SeqOp            */ __Matchers[389].Set(_levelDisjunctionExpression, __Matchers[388], _levelConjunctionExpression);
                /* 390 AltOp            */ __Matchers[390].Set(_conjunctionExpression, _levelNotExpression);
                /* 392 SeqOp            */ __Matchers[392].Set(_levelConjunctionExpression, __Matchers[391], _levelNotExpression);
                /* 393 AltOp            */ __Matchers[393].Set(_notExpression, _levelEqualityExpression);
                /* 394 SeqOp            */ __Matchers[394].Set(__Matchers[244], _levelNotExpression);
                /* 395 AltOp            */ __Matchers[395].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 396 SeqOp            */ __Matchers[396].Set(_levelCompareExpression, __Matchers[254], _levelCompareExpression);
                /* 397 SeqOp            */ __Matchers[397].Set(_levelCompareExpression, __Matchers[255], _levelCompareExpression);
                /* 398 SeqOp            */ __Matchers[398].Set(_levelCompareExpression, __Matchers[258], _levelCompareExpression);
                /* 399 SeqOp            */ __Matchers[399].Set(_levelCompareExpression, __Matchers[259], _levelCompareExpression);
                /* 400 AltOp            */ __Matchers[400].Set(_lessExpression, _lessEqualExpression, _greaterExpression, _greaterEqualExpression, _levelShiftExpression);
                /* 401 SeqOp            */ __Matchers[401].Set(_levelShiftExpression, __Matchers[215], _levelShiftExpression);
                /* 402 SeqOp            */ __Matchers[402].Set(_levelShiftExpression, __Matchers[256], _levelShiftExpression);
                /* 403 SeqOp            */ __Matchers[403].Set(_levelShiftExpression, __Matchers[217], _levelShiftExpression);
                /* 404 SeqOp            */ __Matchers[404].Set(_levelShiftExpression, __Matchers[257], _levelShiftExpression);
                /* 405 AltOp            */ __Matchers[405].Set(_shiftLeftExpression, _shiftRightExpression, _levelAddExpression);
                /* 406 SeqOp            */ __Matchers[406].Set(_levelAddExpression, __Matchers[252], _levelAddExpression);
                /* 407 SeqOp            */ __Matchers[407].Set(_levelAddExpression, __Matchers[253], _levelAddExpression);
                /* 408 AltOp            */ __Matchers[408].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 409 SeqOp            */ __Matchers[409].Set(_levelAddExpression, __Matchers[242], _levelMulExpression);
                /* 410 SeqOp            */ __Matchers[410].Set(_levelAddExpression, __Matchers[243], _levelMulExpression);
                /* 411 AltOp            */ __Matchers[411].Set(_mulExpression, _divExpression, _remExpression, _levelUnionExpression);
                /* 412 SeqOp            */ __Matchers[412].Set(_levelMulExpression, __Matchers[249], _levelUnionExpression);
                /* 413 SeqOp            */ __Matchers[413].Set(_levelMulExpression, __Matchers[250], _levelUnionExpression);
                /* 414 SeqOp            */ __Matchers[414].Set(_levelMulExpression, __Matchers[251], _levelUnionExpression);
                /* 415 AltOp            */ __Matchers[415].Set(_unionExpression, _complementExpression, _levelExclusiveExpression);
                /* 416 SeqOp            */ __Matchers[416].Set(_levelUnionExpression, __Matchers[261], _levelExclusiveExpression);
                /* 417 SeqOp            */ __Matchers[417].Set(_levelUnionExpression, __Matchers[245], _levelExclusiveExpression);
                /* 418 AltOp            */ __Matchers[418].Set(_exclusiveExpression, _levelIntersectionExpression);
                /* 419 SeqOp            */ __Matchers[419].Set(_levelExclusiveExpression, __Matchers[262], _levelIntersectionExpression);
                /* 420 AltOp            */ __Matchers[420].Set(_intersectionExpression, _levelNegateExpression);
                /* 421 SeqOp            */ __Matchers[421].Set(_levelIntersectionExpression, __Matchers[260], _levelNegateExpression);
                /* 422 AltOp            */ __Matchers[422].Set(_negateExpression, _positiveExpression, _complExpression, _primaryExpression);
                /* 423 SeqOp            */ __Matchers[423].Set(__Matchers[243], _levelNegateExpression);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[242], _levelNegateExpression);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[245], _levelNegateExpression);
                /* 426 AltOp            */ __Matchers[426].Set(_reference, _literal, _stringExpression, _callExpression, _selectExpression, _nullsafeSelectExpression, _groupedExpression);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[239], _expression, __Matchers[240]);
                /* 428 SeqOp            */ __Matchers[428].Set(_primaryExpression, _arguments);
                /* 429 SeqOp            */ __Matchers[429].Set(_primaryExpression, __Matchers[209], _reference);
                /* 431 SeqOp            */ __Matchers[431].Set(_primaryExpression, __Matchers[430], _reference);
                /* 432 AltOp            */ __Matchers[432].Set(_stringLiteral, _stringInterpolation);
                /* 433 AltOp            */ __Matchers[433].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 434 StarOp           */ __Matchers[434].Set(_interpolationPart);
                /* 435 SeqOp            */ __Matchers[435].Set(_stringStart, _expression, __Matchers[434], _stringEnd);
                /* 436 SeqOp            */ __Matchers[436].Set(_stringMid, _expression);
                /* 437 SeqOp            */ __Matchers[437].Set(__Matchers[363], _conditions, _ifThen, _ifElse);
                /* 438 SeqOp            */ __Matchers[438].Set(__Matchers[384], _conditionalExpression);
                /* 439 SeqOp            */ __Matchers[439].Set(__Matchers[367], _conditionalExpression);
                /* 440 AltOp            */ __Matchers[440].Set(_ifExpression, _levelDisjunctionExpression);
                /* 441 SeqOp            */ __Matchers[441].Set(__Matchers[239], _conditionList, __Matchers[240]);
                /* 442 SeqOp            */ __Matchers[442].Set(__Matchers[198], _condition);
                /* 443 StarOp           */ __Matchers[443].Set(__Matchers[442]);
                /* 444 SeqOp            */ __Matchers[444].Set(_condition, __Matchers[443]);
                /* 445 AltOp            */ __Matchers[445].Set(_isCondition, _expression);
                /* 446 OptionalOp       */ __Matchers[446].Set(__Matchers[244]);
                /* 447 SeqOp            */ __Matchers[447].Set(__Matchers[446], __Matchers[303], _type, _name);

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
                    new DfaTrans(_attributeName_DFA.States[29], new DfaInterval(100, 100)),
                    new DfaTrans(_attributeName_DFA.States[30], new DfaInterval(110, 110)),
                    new DfaTrans(_attributeName_DFA.States[34], new DfaInterval(97, 97)),
                    new DfaTrans(_attributeName_DFA.States[41], new DfaInterval(111, 111)),
                    new DfaTrans(_attributeName_DFA.States[47], new DfaInterval(118, 118))
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
                    new DfaTrans(_attributeName_DFA.States[28], new DfaInterval(111, 111))
                );
                _attributeName_DFA.States[30].Set(
                    new DfaTrans(_attributeName_DFA.States[31], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[31].Set(
                    new DfaTrans(_attributeName_DFA.States[32], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[32].Set(
                    new DfaTrans(_attributeName_DFA.States[33], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[33].Set(
                    new DfaTrans(_attributeName_DFA.States[22], new DfaInterval(118, 118))
                );
                _attributeName_DFA.States[34].Set(
                    new DfaTrans(_attributeName_DFA.States[35], new DfaInterval(98, 98))
                );
                _attributeName_DFA.States[35].Set(
                    new DfaTrans(_attributeName_DFA.States[36], new DfaInterval(115, 115))
                );
                _attributeName_DFA.States[36].Set(
                    new DfaTrans(_attributeName_DFA.States[37], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[37].Set(
                    new DfaTrans(_attributeName_DFA.States[38], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[38].Set(
                    new DfaTrans(_attributeName_DFA.States[39], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[39].Set(
                    new DfaTrans(_attributeName_DFA.States[40], new DfaInterval(99, 99))
                );
                _attributeName_DFA.States[40].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[41].Set(
                    new DfaTrans(_attributeName_DFA.States[42], new DfaInterval(118, 118))
                );
                _attributeName_DFA.States[42].Set(
                    new DfaTrans(_attributeName_DFA.States[43], new DfaInterval(101, 101))
                );
                _attributeName_DFA.States[43].Set(
                    new DfaTrans(_attributeName_DFA.States[44], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[44].Set(
                    new DfaTrans(_attributeName_DFA.States[45], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[45].Set(
                    new DfaTrans(_attributeName_DFA.States[46], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[46].Set(
                    new DfaTrans(_attributeName_DFA.States[22], new DfaInterval(100, 100))
                );
                _attributeName_DFA.States[47].Set(
                    new DfaTrans(_attributeName_DFA.States[48], new DfaInterval(105, 105))
                );
                _attributeName_DFA.States[48].Set(
                    new DfaTrans(_attributeName_DFA.States[49], new DfaInterval(114, 114))
                );
                _attributeName_DFA.States[49].Set(
                    new DfaTrans(_attributeName_DFA.States[50], new DfaInterval(116, 116))
                );
                _attributeName_DFA.States[50].Set(
                    new DfaTrans(_attributeName_DFA.States[51], new DfaInterval(117, 117))
                );
                _attributeName_DFA.States[51].Set(
                    new DfaTrans(_attributeName_DFA.States[52], new DfaInterval(97, 97))
                );
                _attributeName_DFA.States[52].Set(
                    new DfaTrans(_attributeName_DFA.States[6], new DfaInterval(108, 108))
                );
                _naturalLiteral_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, false),
                    new DfaState(7, false),
                    new DfaState(8, true),
                    new DfaState(9, false),
                    new DfaState(10, true)
                );
                _naturalLiteral_DFA.States[0].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[1], new DfaInterval(48, 57)),
                    new DfaTrans(_naturalLiteral_DFA.States[7], new DfaInterval(35, 35)),
                    new DfaTrans(_naturalLiteral_DFA.States[9], new DfaInterval(36, 36))
                );
                _naturalLiteral_DFA.States[1].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(95, 95)),
                    new DfaTrans(_naturalLiteral_DFA.States[2], new DfaInterval(115, 115), new DfaInterval(117, 117))
                );
                _naturalLiteral_DFA.States[2].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(56, 56)),
                    new DfaTrans(_naturalLiteral_DFA.States[4], new DfaInterval(49, 49)),
                    new DfaTrans(_naturalLiteral_DFA.States[5], new DfaInterval(51, 51)),
                    new DfaTrans(_naturalLiteral_DFA.States[6], new DfaInterval(54, 54))
                );
                _naturalLiteral_DFA.States[3].Set(
                );
                _naturalLiteral_DFA.States[4].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(54, 54))
                );
                _naturalLiteral_DFA.States[5].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(50, 50))
                );
                _naturalLiteral_DFA.States[6].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[3], new DfaInterval(52, 52))
                );
                _naturalLiteral_DFA.States[7].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[8], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _naturalLiteral_DFA.States[8].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[8], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(95, 95), new DfaInterval(97, 102)),
                    new DfaTrans(_naturalLiteral_DFA.States[2], new DfaInterval(115, 115), new DfaInterval(117, 117))
                );
                _naturalLiteral_DFA.States[9].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[10], new DfaInterval(48, 49))
                );
                _naturalLiteral_DFA.States[10].Set(
                    new DfaTrans(_naturalLiteral_DFA.States[10], new DfaInterval(48, 49), new DfaInterval(95, 95)),
                    new DfaTrans(_naturalLiteral_DFA.States[2], new DfaInterval(115, 115), new DfaInterval(117, 117))
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
                    new DfaState(28, false),
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 77), new DfaInterval(79, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 100), new DfaInterval(103, 104), new DfaInterval(106, 107), new DfaInterval(113, 113), new DfaInterval(115, 115), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(78, 78)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(112, 112)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[59], new DfaInterval(116, 116)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(118, 118)),
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 108), new DfaInterval(111, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102), new DfaInterval(115, 115)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 115), new DfaInterval(117, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 119), new DfaInterval(121, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(120, 120))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(102, 102))
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
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[59].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[60], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[60].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[64].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[65], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[65].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 104), new DfaInterval(106, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[66], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[66].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(114, 114))
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
            private readonly Mx.PlainRule _classBody;
            private readonly Mx.PlainRule _interfaceBody;
            private readonly Mx.PlainRule _classMember;
            private readonly Mx.PlainRule _interfaceMember;
            private readonly Mx.PlainRule _functionBody;
            private readonly Mx.PlainRule _attributeBody;
            private readonly Mx.PlainRule _blockBody;
            private readonly Mx.PlainRule _statelarations;
            private readonly Mx.PlainRule _statelaration;
            private readonly Mx.PlainRule _calcBody;
            private readonly Mx.PlainRule _nullBody;
            private readonly Mx.PlainRule _functionSpecifier;
            private readonly Mx.PlainRule _extends;
            private readonly Mx.PlainRule _extendedType;
            private readonly Mx.PlainRule _satisfies;
            private readonly Mx.PlainRule _unionTypeList;
            private readonly Mx.PlainRule _constraints;
            private readonly Mx.PlainRule _constraint;
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
            private readonly Mx.PlainRule _elsePart;
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
            private readonly Mx.PlainRule _levelShiftExpression;
            private readonly Mx.PlainRule _shiftLeftExpression;
            private readonly Mx.PlainRule _shiftRightExpression;
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
            private readonly Mx.PlainRule _positiveExpression;
            private readonly Mx.PlainRule _complExpression;
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
        public interface ICUniversalDeclaration : ICClassMember, ICInterfaceMember, ICNestedDeclaration, ICTopDeclaration {}
        public interface ICNestedDeclaration : ICStatelaration {}
        public interface ICOperatorDeclaration : ICClassMember, ICNestedDeclaration {}
        public interface ICPrefixDeclaration : ICOperatorDeclaration {}
        public interface ICPrefixOperator : IRNode {}
        public interface ICInfixDeclaration : ICOperatorDeclaration {}
        public interface ICInfixOperator : IRNode {}
        public interface ICFunctionDeclaration : ICUniversalDeclaration {}
        public interface ICAttributeDeclaration : ICClassMember, ICInterfaceMember, ICNestedDeclaration {}
        public interface ICVarDeclaration : ICClassMember, ICUniversalDeclaration {}
        public interface ICLetDeclaration : ICClassMember, ICUniversalDeclaration {}
        public interface ICClassDeclaration : ICUniversalDeclaration {}
        public interface ICInterfaceDeclaration : ICUniversalDeclaration {}
        public interface ICObjectDeclaration : ICUniversalDeclaration {}
        public interface ICAliasDeclaration : ICUniversalDeclaration {}
        public interface ICConstructorDeclaration : ICClassMember, ICInterfaceMember, ICNestedDeclaration {}
        public interface ICClassBody : IRNode {}
        public interface ICInterfaceBody : IRNode {}
        public interface ICClassMember : IRNode {}
        public interface ICInterfaceMember : IRNode {}
        public interface ICFunctionBody : IRNode {}
        public interface ICAttributeBody : IRNode {}
        public interface ICBlockBody : ICAttributeBody, ICFunctionBody {}
        public interface ICStatelarations : IRNode {}
        public interface ICStatelaration : IRNode {}
        public interface ICCalcBody : ICAttributeBody, ICFunctionBody {}
        public interface ICNullBody : ICAttributeBody, ICFunctionBody {}
        public interface ICFunctionSpecifier : IRNode {}
        public interface ICExtends : IRNode {}
        public interface ICExtendedType : IRNode {}
        public interface ICSatisfies : IRNode {}
        public interface ICUnionTypeList : IRNode {}
        public interface ICConstraints : IRNode {}
        public interface ICConstraint : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICPattern : IRNode {}
        public interface ICNamePattern : ICPattern {}
        public interface ICPrelude : IRNode {}
        public interface ICAttribute : IRNode {}
        public interface ICAttributeName : IRNode {}
        public interface ICType : ICExtendedType, ICGenericArgument, ICParameterType, ICTypeListType {}
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
        public interface ICElsePart : IRNode {}
        public interface ICElseIf : ICElsePart {}
        public interface ICElseBlock : ICElsePart {}
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
        public interface ICLevelShiftExpression : ICLevelCompareExpression {}
        public interface ICShiftLeftExpression : ICLevelShiftExpression {}
        public interface ICShiftRightExpression : ICLevelShiftExpression {}
        public interface ICLevelAddExpression : ICLevelShiftExpression {}
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
        public interface ICPositiveExpression : ICLevelNegateExpression {}
        public interface ICComplExpression : ICLevelNegateExpression {}
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
            public CClassBody ClassBody => Get<CClassBody>(8);
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
            public CInterfaceBody InterfaceBody => Get<CInterfaceBody>(7);
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
            public CClassBody ClassBody => Get<CClassBody>(5);
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

        public partial class CClassBody : RSequence, ICClassBody
        {
            // sequence
            public CClassBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUsings Usings => Get<CUsings>(1);
            public RStar<ICClassMember> ClassMember => Get<RStar<ICClassMember>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CInterfaceBody : RSequence, ICInterfaceBody
        {
            // sequence
            public CInterfaceBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUsings Usings => Get<CUsings>(1);
            public RStar<ICInterfaceMember> InterfaceMember => Get<RStar<ICInterfaceMember>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
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
            public ICExtendedType ExtendedType => Get<ICExtendedType>(1);
        }

        public partial class CSatisfies : RSequence, ICSatisfies
        {
            // sequence
            public CSatisfies(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'is'
            public CUnionTypeList UnionTypeList => Get<CUnionTypeList>(1);
        }

        public partial class CUnionTypeList : RLoop<ICPrimaryType>, ICUnionTypeList
        {
            // sequence
            public CUnionTypeList(params RNode[] children) : base(children) {}
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
            public ROptional<ICElsePart> ElsePart => Get<ROptional<ICElsePart>>(3);
        }

        public partial class CElseIf : RSequence, ICElseIf
        {
            // sequence
            public CElseIf(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public CIfStatement IfStatement => Get<CIfStatement>(1);
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

            public ICLevelShiftExpression LevelShiftExpression => Get<ICLevelShiftExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<'
            public ICLevelShiftExpression LevelShiftExpression2 => Get<ICLevelShiftExpression>(2);
        }

        public partial class CLessEqualExpression : RSequence, ICLessEqualExpression
        {
            // sequence
            public CLessEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelShiftExpression LevelShiftExpression => Get<ICLevelShiftExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<='
            public ICLevelShiftExpression LevelShiftExpression2 => Get<ICLevelShiftExpression>(2);
        }

        public partial class CGreaterExpression : RSequence, ICGreaterExpression
        {
            // sequence
            public CGreaterExpression(params RNode[] children) : base(children) {}

            public ICLevelShiftExpression LevelShiftExpression => Get<ICLevelShiftExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>'
            public ICLevelShiftExpression LevelShiftExpression2 => Get<ICLevelShiftExpression>(2);
        }

        public partial class CGreaterEqualExpression : RSequence, ICGreaterEqualExpression
        {
            // sequence
            public CGreaterEqualExpression(params RNode[] children) : base(children) {}

            public ICLevelShiftExpression LevelShiftExpression => Get<ICLevelShiftExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>='
            public ICLevelShiftExpression LevelShiftExpression2 => Get<ICLevelShiftExpression>(2);
        }

        public partial class CShiftLeftExpression : RSequence, ICShiftLeftExpression
        {
            // sequence
            public CShiftLeftExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<<'
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CShiftRightExpression : RSequence, ICShiftRightExpression
        {
            // sequence
            public CShiftRightExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>>'
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

        public partial class CPositiveExpression : RSequence, ICPositiveExpression
        {
            // sequence
            public CPositiveExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '+'
            public ICLevelNegateExpression LevelNegateExpression => Get<ICLevelNegateExpression>(1);
        }

        public partial class CComplExpression : RSequence, ICComplExpression
        {
            // sequence
            public CComplExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '~'
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

            protected virtual void Visit(CClassBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceBody element)
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

            protected virtual void Visit(CUnionTypeList element)
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

            protected virtual void Visit(CShiftLeftExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CShiftRightExpression element)
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

            protected virtual void Visit(CPositiveExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CComplExpression element)
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
