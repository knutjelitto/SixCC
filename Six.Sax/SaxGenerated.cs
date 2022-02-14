// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Sax\\Sax.six" at="14.02.2022 16:12:12" />

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
                : base(new Mx.Matcher[475])
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
                /*  35 PlainRuleOp      */ __Matchers[35] = _varDeclaration = new Mx.PlainRule(this, 35, "var-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _letDeclaration = new Mx.PlainRule(this, 36, "let-declaration") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _classDeclaration = new Mx.PlainRule(this, 37, "class-declaration") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _interfaceDeclaration = new Mx.PlainRule(this, 38, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _objectDeclaration = new Mx.PlainRule(this, 39, "object-declaration") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _aliasDeclaration = new Mx.PlainRule(this, 40, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _constructorDeclaration = new Mx.PlainRule(this, 41, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _functionBody = new Mx.PlainRule(this, 42, "function-body") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _attributeBody = new Mx.PlainRule(this, 43, "attribute-body") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _blockBody = new Mx.PlainRule(this, 44, "block-body") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _statelarations = new Mx.PlainRule(this, 45, "statelarations") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _statelaration = new Mx.PlainRule(this, 46, "statelaration") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _expressionBody = new Mx.PlainRule(this, 47, "expression-body") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _nullBody = new Mx.PlainRule(this, 48, "null-body") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _functionSpecifier = new Mx.PlainRule(this, 49, "function-specifier") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _extends = new Mx.PlainRule(this, 50, "extends") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _extendType = new Mx.PlainRule(this, 51, "extend-type") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _constructor = new Mx.PlainRule(this, 52, "constructor") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _satisfies = new Mx.PlainRule(this, 53, "satisfies") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _constraints = new Mx.PlainRule(this, 54, "constraints") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _constraint = new Mx.PlainRule(this, 55, "constraint") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _unionTypeList = new Mx.PlainRule(this, 56, "union-type-list") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _caseTypes = new Mx.PlainRule(this, 57, "case-types") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _caseTypeList = new Mx.PlainRule(this, 58, "case-type-list") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _pattern = new Mx.PlainRule(this, 59, "pattern") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _namePattern = new Mx.PlainRule(this, 60, "name-pattern") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _prelude = new Mx.PlainRule(this, 61, "prelude") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _attribute = new Mx.PlainRule(this, 62, "attribute") { Builder = nodes => nodes[0] };
                /*  63 DfaRuleOp        */ __Matchers[63] = _attributeName = new Mx.DfaRule(this, 63, "attribute-name") { Creator = node => new CAttributeName(node) };
                /*  64 PlainRuleOp      */ __Matchers[64] = _attributeArguments = new Mx.PlainRule(this, 64, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _attributeArgumentList = new Mx.PlainRule(this, 65, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _attributeArgument = new Mx.PlainRule(this, 66, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _literalArgument = new Mx.PlainRule(this, 67, "literal-argument") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _metaArgument = new Mx.PlainRule(this, 68, "meta-argument") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _metaReference = new Mx.PlainRule(this, 69, "meta-reference") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _classReference = new Mx.PlainRule(this, 70, "class-reference") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _objectReference = new Mx.PlainRule(this, 71, "object-reference") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _valueReference = new Mx.PlainRule(this, 72, "value-reference") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _interfaceReference = new Mx.PlainRule(this, 73, "interface-reference") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _functionReference = new Mx.PlainRule(this, 74, "function-reference") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _type = new Mx.PlainRule(this, 75, "type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _entryType = new Mx.PlainRule(this, 76, "entry-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _variadicType = new Mx.PlainRule(this, 77, "variadic-type") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _variadicTypeZero = new Mx.PlainRule(this, 78, "variadic-type-zero") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _variadicTypeOne = new Mx.PlainRule(this, 79, "variadic-type-one") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _unionType = new Mx.PlainRule(this, 80, "union-type") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _intersectionType = new Mx.PlainRule(this, 81, "intersection-type") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _primaryType = new Mx.PlainRule(this, 82, "primary-type") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _nullableType = new Mx.PlainRule(this, 83, "nullable-type") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _sequenceType = new Mx.PlainRule(this, 84, "sequence-type") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _typeSelector = new Mx.PlainRule(this, 85, "type-selector") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _callableType = new Mx.PlainRule(this, 86, "callable-type") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _callableArguments = new Mx.PlainRule(this, 87, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _typeList = new Mx.PlainRule(this, 88, "type-list") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _typeListType = new Mx.PlainRule(this, 89, "type-list-type") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _defaultedType = new Mx.PlainRule(this, 90, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _spreadType = new Mx.PlainRule(this, 91, "spread-type") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _emptyType = new Mx.PlainRule(this, 92, "empty-type") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _tupleType = new Mx.PlainRule(this, 93, "tuple-type") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _iterableType = new Mx.PlainRule(this, 94, "iterable-type") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _iterableTypeZero = new Mx.PlainRule(this, 95, "iterable-type-zero") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _iterableTypeOne = new Mx.PlainRule(this, 96, "iterable-type-one") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _nothingType = new Mx.PlainRule(this, 97, "nothing-type") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _multiParameters = new Mx.PlainRule(this, 98, "multi-parameters") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _parameters = new Mx.PlainRule(this, 99, "parameters") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _parameterList = new Mx.PlainRule(this, 100, "parameter-list") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _parameter = new Mx.PlainRule(this, 101, "parameter") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _valueParameter = new Mx.PlainRule(this, 102, "value-parameter") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _parameterType = new Mx.PlainRule(this, 103, "parameter-type") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _arguments = new Mx.PlainRule(this, 104, "arguments") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _argumentList = new Mx.PlainRule(this, 105, "argument-list") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _argument = new Mx.PlainRule(this, 106, "argument") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _expressionArgument = new Mx.PlainRule(this, 107, "expression-argument") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _spreadArgument = new Mx.PlainRule(this, 108, "spread-argument") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _statement = new Mx.PlainRule(this, 109, "statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _assignStatement = new Mx.PlainRule(this, 110, "assign-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _expressionStatement = new Mx.PlainRule(this, 111, "expression-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _ifStatement = new Mx.PlainRule(this, 112, "if-statement") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _elseIf = new Mx.PlainRule(this, 113, "else-if") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _elseBlock = new Mx.PlainRule(this, 114, "else-block") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _forStatement = new Mx.PlainRule(this, 115, "for-statement") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _returnStatement = new Mx.PlainRule(this, 116, "return-statement") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _assertStatement = new Mx.PlainRule(this, 117, "assert-statement") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _expression = new Mx.PlainRule(this, 118, "expression") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _levelCoalesceExpression = new Mx.PlainRule(this, 119, "level-coalesce-expression") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _thenExpression = new Mx.PlainRule(this, 120, "then-expression") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _elseExpression = new Mx.PlainRule(this, 121, "else-expression") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _levelDisjunctionExpression = new Mx.PlainRule(this, 122, "level-disjunction-expression") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _disjunctionExpression = new Mx.PlainRule(this, 123, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _levelConjunctionExpression = new Mx.PlainRule(this, 124, "level-conjunction-expression") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _conjunctionExpression = new Mx.PlainRule(this, 125, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _levelNotExpression = new Mx.PlainRule(this, 126, "level-not-expression") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _notExpression = new Mx.PlainRule(this, 127, "not-expression") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _levelEqualityExpression = new Mx.PlainRule(this, 128, "level-equality-expression") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _equalExpression = new Mx.PlainRule(this, 129, "equal-expression") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _notEqualExpression = new Mx.PlainRule(this, 130, "not-equal-expression") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _identicalExpression = new Mx.PlainRule(this, 131, "identical-expression") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _notIdenticalExpression = new Mx.PlainRule(this, 132, "not-identical-expression") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _levelCompareExpression = new Mx.PlainRule(this, 133, "level-compare-expression") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _lessExpression = new Mx.PlainRule(this, 134, "less-expression") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _lessEqualExpression = new Mx.PlainRule(this, 135, "less-equal-expression") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _greaterExpression = new Mx.PlainRule(this, 136, "greater-expression") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _greaterEqualExpression = new Mx.PlainRule(this, 137, "greater-equal-expression") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _boundsExpression = new Mx.PlainRule(this, 138, "bounds-expression") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _lowerBound = new Mx.PlainRule(this, 139, "lower-bound") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _lowerLessBound = new Mx.PlainRule(this, 140, "lower-less-bound") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _lowerLessEqualBound = new Mx.PlainRule(this, 141, "lower-less-equal-bound") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _upperBound = new Mx.PlainRule(this, 142, "upper-bound") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _upperLessBound = new Mx.PlainRule(this, 143, "upper-less-bound") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _upperLessEqualBound = new Mx.PlainRule(this, 144, "upper-less-equal-bound") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _levelAddExpression = new Mx.PlainRule(this, 145, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _addExpression = new Mx.PlainRule(this, 146, "add-expression") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _subExpression = new Mx.PlainRule(this, 147, "sub-expression") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _levelMulExpression = new Mx.PlainRule(this, 148, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _mulExpression = new Mx.PlainRule(this, 149, "mul-expression") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _divExpression = new Mx.PlainRule(this, 150, "div-expression") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _remExpression = new Mx.PlainRule(this, 151, "rem-expression") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _levelUnionExpression = new Mx.PlainRule(this, 152, "level-union-expression") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _unionExpression = new Mx.PlainRule(this, 153, "union-expression") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _complementExpression = new Mx.PlainRule(this, 154, "complement-expression") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _levelExclusiveExpression = new Mx.PlainRule(this, 155, "level-exclusive-expression") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _exclusiveExpression = new Mx.PlainRule(this, 156, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _levelIntersectionExpression = new Mx.PlainRule(this, 157, "level-intersection-expression") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _intersectionExpression = new Mx.PlainRule(this, 158, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _levelNegateExpression = new Mx.PlainRule(this, 159, "level-negate-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _negateExpression = new Mx.PlainRule(this, 160, "negate-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _primaryExpression = new Mx.PlainRule(this, 161, "primary-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _groupedExpression = new Mx.PlainRule(this, 162, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _callExpression = new Mx.PlainRule(this, 163, "call-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _selectExpression = new Mx.PlainRule(this, 164, "select-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _nullsafeSelectExpression = new Mx.PlainRule(this, 165, "nullsafe-select-expression") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _literal = new Mx.PlainRule(this, 166, "literal") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _stringExpression = new Mx.PlainRule(this, 167, "string-expression") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _stringLiteral = new Mx.PlainRule(this, 168, "string-literal") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _stringInterpolation = new Mx.PlainRule(this, 169, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _interpolationPart = new Mx.PlainRule(this, 170, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _ifExpression = new Mx.PlainRule(this, 171, "if-expression") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _ifThen = new Mx.PlainRule(this, 172, "if-then") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _ifElse = new Mx.PlainRule(this, 173, "if-else") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _conditionalExpression = new Mx.PlainRule(this, 174, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _conditions = new Mx.PlainRule(this, 175, "conditions") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _conditionList = new Mx.PlainRule(this, 176, "condition-list") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _condition = new Mx.PlainRule(this, 177, "condition") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _isCondition = new Mx.PlainRule(this, 178, "is-condition") { Builder = nodes => nodes[0] };
                /* 179 DfaRuleOp        */ __Matchers[179] = _naturalLiteral = new Mx.DfaRule(this, 179, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 180 DfaRuleOp        */ __Matchers[180] = _stringStart = new Mx.DfaRule(this, 180, "string-start") { Creator = node => new CStringStart(node) };
                /* 181 DfaRuleOp        */ __Matchers[181] = _stringMid = new Mx.DfaRule(this, 181, "string-mid") { Creator = node => new CStringMid(node) };
                /* 182 DfaRuleOp        */ __Matchers[182] = _stringEnd = new Mx.DfaRule(this, 182, "string-end") { Creator = node => new CStringEnd(node) };
                /* 183 DfaRuleOp        */ __Matchers[183] = _plainStringLiteral = new Mx.DfaRule(this, 183, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 184 DfaRuleOp        */ __Matchers[184] = _verbatimStringLiteral = new Mx.DfaRule(this, 184, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 185 DfaRuleOp        */ __Matchers[185] = _identifier = new Mx.DfaRule(this, 185, "identifier") { Creator = node => new CIdentifier(node) };
                /* 186 EofOp            */ __Matchers[186] = new Mx.Eof(this, 186, "<eof>") { Creator = node => new REof(node) };
                /* 187 SeqOp            */ __Matchers[187] = new Mx.Seq(this, 187, "_187:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 188 AltOp            */ __Matchers[188] = new Mx.Alt(this, 188, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 189 StringOp         */ __Matchers[189] = new Mx.String(this, 189, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 190 OptionalOp       */ __Matchers[190] = new Mx.Optional(this, 190, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 191 SeqOp            */ __Matchers[191] = new Mx.Seq(this, 191, "_191:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 192 StringOp         */ __Matchers[192] = new Mx.Keyword(this, 192, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 193 StringOp         */ __Matchers[193] = new Mx.String(this, 193, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 194 SeqOp            */ __Matchers[194] = new Mx.Seq(this, 194, "_194:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 195 StringOp         */ __Matchers[195] = new Mx.Keyword(this, 195, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 196 SeqOp            */ __Matchers[196] = new Mx.Seq(this, 196, "_196:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 197 StringOp         */ __Matchers[197] = new Mx.String(this, 197, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 198 StarOp           */ __Matchers[198] = new Mx.Star(this, 198, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 199 StringOp         */ __Matchers[199] = new Mx.String(this, 199, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 201 StringOp         */ __Matchers[201] = new Mx.Keyword(this, 201, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 202 SeqOp            */ __Matchers[202] = new Mx.Seq(this, 202, "_202:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 203 StarOp           */ __Matchers[203] = new Mx.Star(this, 203, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 204 StringOp         */ __Matchers[204] = new Mx.Keyword(this, 204, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 205 SeqOp            */ __Matchers[205] = new Mx.Seq(this, 205, "_205:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 206 OptionalOp       */ __Matchers[206] = new Mx.Optional(this, 206, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 207 SeqOp            */ __Matchers[207] = new Mx.Seq(this, 207, "_207:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 208 StringOp         */ __Matchers[208] = new Mx.String(this, 208, "','", ",") { Creator = node => new RLiteral(node) };
                /* 209 SeqOp            */ __Matchers[209] = new Mx.Seq(this, 209, "_209:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 210 StarOp           */ __Matchers[210] = new Mx.Star(this, 210, "*(_209:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 211 SeqOp            */ __Matchers[211] = new Mx.Seq(this, 211, "_211:(>using-element,*(_209:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 212 AltOp            */ __Matchers[212] = new Mx.Alt(this, 212, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 213 OptionalOp       */ __Matchers[213] = new Mx.Optional(this, 213, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 214 OptionalOp       */ __Matchers[214] = new Mx.Optional(this, 214, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 215 SeqOp            */ __Matchers[215] = new Mx.Seq(this, 215, "_215:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 216 StringOp         */ __Matchers[216] = new Mx.String(this, 216, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 217 SeqOp            */ __Matchers[217] = new Mx.Seq(this, 217, "_217:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 218 StringOp         */ __Matchers[218] = new Mx.String(this, 218, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 219 StringOp         */ __Matchers[219] = new Mx.String(this, 219, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 220 SeqOp            */ __Matchers[220] = new Mx.Seq(this, 220, "_220:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 221 StarOp           */ __Matchers[221] = new Mx.Star(this, 221, "*(_220:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 222 SeqOp            */ __Matchers[222] = new Mx.Seq(this, 222, "_222:(>name,*(_220:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 223 OptionalOp       */ __Matchers[223] = new Mx.Optional(this, 223, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 224 SeqOp            */ __Matchers[224] = new Mx.Seq(this, 224, "_224:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 225 StringOp         */ __Matchers[225] = new Mx.String(this, 225, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 226 OptionalOp       */ __Matchers[226] = new Mx.Optional(this, 226, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 227 StringOp         */ __Matchers[227] = new Mx.String(this, 227, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 228 SeqOp            */ __Matchers[228] = new Mx.Seq(this, 228, "_228:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 229 SeqOp            */ __Matchers[229] = new Mx.Seq(this, 229, "_229:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 230 StarOp           */ __Matchers[230] = new Mx.Star(this, 230, "*(_229:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:(>generic-argument,*(_229:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 232 OptionalOp       */ __Matchers[232] = new Mx.Optional(this, 232, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 233 SeqOp            */ __Matchers[233] = new Mx.Seq(this, 233, "_233:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 234 SeqOp            */ __Matchers[234] = new Mx.Seq(this, 234, "_234:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 235 StarOp           */ __Matchers[235] = new Mx.Star(this, 235, "*(_234:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 236 SeqOp            */ __Matchers[236] = new Mx.Seq(this, 236, "_236:(>generic-parameter,*(_234:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 237 OptionalOp       */ __Matchers[237] = new Mx.Optional(this, 237, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 238 OptionalOp       */ __Matchers[238] = new Mx.Optional(this, 238, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 239 SeqOp            */ __Matchers[239] = new Mx.Seq(this, 239, "_239:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 241 SeqOp            */ __Matchers[241] = new Mx.Seq(this, 241, "_241:('=',>expression)") { Builder = nodes => new CValueDefault(nodes) };
                /* 242 StringOp         */ __Matchers[242] = new Mx.Keyword(this, 242, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 243 StringOp         */ __Matchers[243] = new Mx.Keyword(this, 243, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 244 AltOp            */ __Matchers[244] = new Mx.Alt(this, 244, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 245 StarOp           */ __Matchers[245] = new Mx.Star(this, 245, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 246 AltOp            */ __Matchers[246] = new Mx.Alt(this, 246, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration|>let-declaration|>var-declaration)") { Builder = nodes => nodes[0] };
                /* 247 OptionalOp       */ __Matchers[247] = new Mx.Optional(this, 247, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 248 OptionalOp       */ __Matchers[248] = new Mx.Optional(this, 248, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 249 OptionalOp       */ __Matchers[249] = new Mx.Optional(this, 249, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:(>prelude,?(>type),>name,?(>generic-parameters),>multi-parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 251 SeqOp            */ __Matchers[251] = new Mx.Seq(this, 251, "_251:(>prelude,?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 252 StringOp         */ __Matchers[252] = new Mx.Keyword(this, 252, "'var'", "var") { Creator = node => new RLiteral(node) };
                /* 253 SeqOp            */ __Matchers[253] = new Mx.Seq(this, 253, "_253:(>prelude,'var',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CVarDeclaration(nodes) };
                /* 254 StringOp         */ __Matchers[254] = new Mx.Keyword(this, 254, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 255 SeqOp            */ __Matchers[255] = new Mx.Seq(this, 255, "_255:(>prelude,'let',?(>type),>name,'=',>expression,';')") { Builder = nodes => new CLetDeclaration(nodes) };
                /* 256 StringOp         */ __Matchers[256] = new Mx.Keyword(this, 256, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 257 OptionalOp       */ __Matchers[257] = new Mx.Optional(this, 257, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 258 OptionalOp       */ __Matchers[258] = new Mx.Optional(this, 258, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 259 OptionalOp       */ __Matchers[259] = new Mx.Optional(this, 259, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 260 OptionalOp       */ __Matchers[260] = new Mx.Optional(this, 260, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 261 SeqOp            */ __Matchers[261] = new Mx.Seq(this, 261, "_261:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 262 StringOp         */ __Matchers[262] = new Mx.Keyword(this, 262, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 263 SeqOp            */ __Matchers[263] = new Mx.Seq(this, 263, "_263:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 264 StringOp         */ __Matchers[264] = new Mx.Keyword(this, 264, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 265 SeqOp            */ __Matchers[265] = new Mx.Seq(this, 265, "_265:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 266 StringOp         */ __Matchers[266] = new Mx.Keyword(this, 266, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 267 StringOp         */ __Matchers[267] = new Mx.String(this, 267, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 268 SeqOp            */ __Matchers[268] = new Mx.Seq(this, 268, "_268:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 269 StringOp         */ __Matchers[269] = new Mx.Keyword(this, 269, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 270 OptionalOp       */ __Matchers[270] = new Mx.Optional(this, 270, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 271 SeqOp            */ __Matchers[271] = new Mx.Seq(this, 271, "_271:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 272 AltOp            */ __Matchers[272] = new Mx.Alt(this, 272, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 273 SeqOp            */ __Matchers[273] = new Mx.Seq(this, 273, "_273:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 274 StarOp           */ __Matchers[274] = new Mx.Star(this, 274, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 275 AltOp            */ __Matchers[275] = new Mx.Alt(this, 275, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 276 SeqOp            */ __Matchers[276] = new Mx.Seq(this, 276, "_276:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 278 SeqOp            */ __Matchers[278] = new Mx.Seq(this, 278, "_278:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 279 StringOp         */ __Matchers[279] = new Mx.String(this, 279, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 280 SeqOp            */ __Matchers[280] = new Mx.Seq(this, 280, "_280:(':',>extend-type)") { Builder = nodes => new CExtends(nodes) };
                /* 281 AltOp            */ __Matchers[281] = new Mx.Alt(this, 281, "alt(>type|>constructor)") { Builder = nodes => nodes[0] };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 283 StringOp         */ __Matchers[283] = new Mx.Keyword(this, 283, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 284 SeqOp            */ __Matchers[284] = new Mx.Seq(this, 284, "_284:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 285 PlusOp           */ __Matchers[285] = new Mx.Plus(this, 285, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 286 StringOp         */ __Matchers[286] = new Mx.Keyword(this, 286, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 287 SeqOp            */ __Matchers[287] = new Mx.Seq(this, 287, "_287:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 288 SeqOp            */ __Matchers[288] = new Mx.Seq(this, 288, "_288:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 289 StarOp           */ __Matchers[289] = new Mx.Star(this, 289, "*(_288:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 290 SeqOp            */ __Matchers[290] = new Mx.Seq(this, 290, "_290:(>type,*(_288:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 291 StringOp         */ __Matchers[291] = new Mx.Keyword(this, 291, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 293 StringOp         */ __Matchers[293] = new Mx.String(this, 293, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 294 SeqOp            */ __Matchers[294] = new Mx.Seq(this, 294, "_294:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 295 StarOp           */ __Matchers[295] = new Mx.Star(this, 295, "*(_294:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 296 SeqOp            */ __Matchers[296] = new Mx.Seq(this, 296, "_296:(>type,*(_294:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 297 SeqOp            */ __Matchers[297] = new Mx.Seq(this, 297, "_297:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 298 OptionalOp       */ __Matchers[298] = new Mx.Optional(this, 298, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 299 StarOp           */ __Matchers[299] = new Mx.Star(this, 299, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 300 SeqOp            */ __Matchers[300] = new Mx.Seq(this, 300, "_300:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 301 OptionalOp       */ __Matchers[301] = new Mx.Optional(this, 301, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:(>attribute-name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 303 StringOp         */ __Matchers[303] = new Mx.String(this, 303, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 304 OptionalOp       */ __Matchers[304] = new Mx.Optional(this, 304, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 305 StringOp         */ __Matchers[305] = new Mx.String(this, 305, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 306 SeqOp            */ __Matchers[306] = new Mx.Seq(this, 306, "_306:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 308 StarOp           */ __Matchers[308] = new Mx.Star(this, 308, "*(_307:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 309 SeqOp            */ __Matchers[309] = new Mx.Seq(this, 309, "_309:(>attribute-argument,*(_307:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 310 AltOp            */ __Matchers[310] = new Mx.Alt(this, 310, "alt(>literal-argument|>meta-argument)") { Builder = nodes => nodes[0] };
                /* 311 SeqOp            */ __Matchers[311] = new Mx.Seq(this, 311, "_311:(>string-literal)") { Builder = nodes => new CLiteralArgument(nodes) };
                /* 312 SeqOp            */ __Matchers[312] = new Mx.Seq(this, 312, "_312:(>meta-reference)") { Builder = nodes => new CMetaArgument(nodes) };
                /* 313 AltOp            */ __Matchers[313] = new Mx.Alt(this, 313, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 314 SeqOp            */ __Matchers[314] = new Mx.Seq(this, 314, "_314:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 315 SeqOp            */ __Matchers[315] = new Mx.Seq(this, 315, "_315:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 316 StringOp         */ __Matchers[316] = new Mx.Keyword(this, 316, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 317 SeqOp            */ __Matchers[317] = new Mx.Seq(this, 317, "_317:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 318 SeqOp            */ __Matchers[318] = new Mx.Seq(this, 318, "_318:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 319 StringOp         */ __Matchers[319] = new Mx.Keyword(this, 319, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 320 SeqOp            */ __Matchers[320] = new Mx.Seq(this, 320, "_320:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 321 AltOp            */ __Matchers[321] = new Mx.Alt(this, 321, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 322 StringOp         */ __Matchers[322] = new Mx.String(this, 322, "'->'", "->") { Creator = node => new RLiteral(node) };
                /* 323 SeqOp            */ __Matchers[323] = new Mx.Seq(this, 323, "_323:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 324 AltOp            */ __Matchers[324] = new Mx.Alt(this, 324, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 325 StringOp         */ __Matchers[325] = new Mx.String(this, 325, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 326 SeqOp            */ __Matchers[326] = new Mx.Seq(this, 326, "_326:(>union-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 327 StringOp         */ __Matchers[327] = new Mx.String(this, 327, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 328 SeqOp            */ __Matchers[328] = new Mx.Seq(this, 328, "_328:(>union-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 329 SeqOp            */ __Matchers[329] = new Mx.Seq(this, 329, "_329:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 330 StarOp           */ __Matchers[330] = new Mx.Star(this, 330, "*(_329:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 331 SeqOp            */ __Matchers[331] = new Mx.Seq(this, 331, "_331:(>intersection-type,*(_329:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 332 StringOp         */ __Matchers[332] = new Mx.String(this, 332, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 333 SeqOp            */ __Matchers[333] = new Mx.Seq(this, 333, "_333:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 334 StarOp           */ __Matchers[334] = new Mx.Star(this, 334, "*(_333:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 335 SeqOp            */ __Matchers[335] = new Mx.Seq(this, 335, "_335:(>primary-type,*(_333:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 336 AltOp            */ __Matchers[336] = new Mx.Alt(this, 336, "alt(>nullable-type|>sequence-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>iterable-type|>nothing-type)") { Builder = nodes => nodes[0] };
                /* 337 StringOp         */ __Matchers[337] = new Mx.String(this, 337, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 338 SeqOp            */ __Matchers[338] = new Mx.Seq(this, 338, "_338:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 339 StringOp         */ __Matchers[339] = new Mx.String(this, 339, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 340 StringOp         */ __Matchers[340] = new Mx.String(this, 340, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 341 SeqOp            */ __Matchers[341] = new Mx.Seq(this, 341, "_341:(>primary-type,'[',']')") { Builder = nodes => new CSequenceType(nodes) };
                /* 342 SeqOp            */ __Matchers[342] = new Mx.Seq(this, 342, "_342:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 343 OptionalOp       */ __Matchers[343] = new Mx.Optional(this, 343, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 344 SeqOp            */ __Matchers[344] = new Mx.Seq(this, 344, "_344:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 345 AltOp            */ __Matchers[345] = new Mx.Alt(this, 345, "alt(>type-list|>spread-type)") { Builder = nodes => nodes[0] };
                /* 346 SeqOp            */ __Matchers[346] = new Mx.Seq(this, 346, "_346:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 347 StarOp           */ __Matchers[347] = new Mx.Star(this, 347, "*(_346:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 348 SeqOp            */ __Matchers[348] = new Mx.Seq(this, 348, "_348:(>type-list-type,*(_346:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 349 AltOp            */ __Matchers[349] = new Mx.Alt(this, 349, "alt(>type|>defaulted-type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 350 SeqOp            */ __Matchers[350] = new Mx.Seq(this, 350, "_350:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 351 SeqOp            */ __Matchers[351] = new Mx.Seq(this, 351, "_351:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 352 SeqOp            */ __Matchers[352] = new Mx.Seq(this, 352, "_352:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 353 SeqOp            */ __Matchers[353] = new Mx.Seq(this, 353, "_353:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 354 AltOp            */ __Matchers[354] = new Mx.Alt(this, 354, "alt(>iterable-type-zero|>iterable-type-one)") { Builder = nodes => nodes[0] };
                /* 355 SeqOp            */ __Matchers[355] = new Mx.Seq(this, 355, "_355:('{',>union-type,'*','}')") { Builder = nodes => new CIterableTypeZero(nodes) };
                /* 356 SeqOp            */ __Matchers[356] = new Mx.Seq(this, 356, "_356:('{',>union-type,'+','}')") { Builder = nodes => new CIterableTypeOne(nodes) };
                /* 357 StringOp         */ __Matchers[357] = new Mx.Keyword(this, 357, "'Nothing'", "Nothing") { Creator = node => new RLiteral(node) };
                /* 358 SeqOp            */ __Matchers[358] = new Mx.Seq(this, 358, "_358:('Nothing')") { Builder = nodes => new CNothingType(nodes) };
                /* 359 PlusOp           */ __Matchers[359] = new Mx.Plus(this, 359, "+(>parameters)") { Builder = nodes => new CMultiParameters(nodes) };
                /* 360 OptionalOp       */ __Matchers[360] = new Mx.Optional(this, 360, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 362 SeqOp            */ __Matchers[362] = new Mx.Seq(this, 362, "_362:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 363 StarOp           */ __Matchers[363] = new Mx.Star(this, 363, "*(_362:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 364 SeqOp            */ __Matchers[364] = new Mx.Seq(this, 364, "_364:(>parameter,*(_362:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 365 OptionalOp       */ __Matchers[365] = new Mx.Optional(this, 365, "?(>parameter-type)") { Builder = nodes => new ROptional<ICParameterType>(nodes) };
                /* 366 OptionalOp       */ __Matchers[366] = new Mx.Optional(this, 366, "?(>value-default)") { Builder = nodes => new ROptional<CValueDefault>(nodes) };
                /* 367 SeqOp            */ __Matchers[367] = new Mx.Seq(this, 367, "_367:(>prelude,?(>parameter-type),>name,?(>value-default))") { Builder = nodes => new CValueParameter(nodes) };
                /* 368 AltOp            */ __Matchers[368] = new Mx.Alt(this, 368, "alt(>type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 369 OptionalOp       */ __Matchers[369] = new Mx.Optional(this, 369, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 370 SeqOp            */ __Matchers[370] = new Mx.Seq(this, 370, "_370:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 371 SeqOp            */ __Matchers[371] = new Mx.Seq(this, 371, "_371:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 372 StarOp           */ __Matchers[372] = new Mx.Star(this, 372, "*(_371:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 373 SeqOp            */ __Matchers[373] = new Mx.Seq(this, 373, "_373:(>argument,*(_371:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 374 AltOp            */ __Matchers[374] = new Mx.Alt(this, 374, "alt(>expression-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 375 SeqOp            */ __Matchers[375] = new Mx.Seq(this, 375, "_375:(>expression)") { Builder = nodes => new CExpressionArgument(nodes) };
                /* 376 SeqOp            */ __Matchers[376] = new Mx.Seq(this, 376, "_376:('*',>level-union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 377 AltOp            */ __Matchers[377] = new Mx.Alt(this, 377, "alt(>assign-statement|>expression-statement|>if-statement|>for-statement|>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 378 SeqOp            */ __Matchers[378] = new Mx.Seq(this, 378, "_378:(>name,'=',>expression,';')") { Builder = nodes => new CAssignStatement(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:(>expression,';')") { Builder = nodes => new CExpressionStatement(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new Mx.Keyword(this, 380, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 381 StarOp           */ __Matchers[381] = new Mx.Star(this, 381, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 382 OptionalOp       */ __Matchers[382] = new Mx.Optional(this, 382, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 383 SeqOp            */ __Matchers[383] = new Mx.Seq(this, 383, "_383:('if',>conditions,>block-body,*(>else-if),?(>else-block))") { Builder = nodes => new CIfStatement(nodes) };
                /* 384 StringOp         */ __Matchers[384] = new Mx.Keyword(this, 384, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 385 SeqOp            */ __Matchers[385] = new Mx.Seq(this, 385, "_385:('else','if',>conditions,>block-body)") { Builder = nodes => new CElseIf(nodes) };
                /* 386 SeqOp            */ __Matchers[386] = new Mx.Seq(this, 386, "_386:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 387 StringOp         */ __Matchers[387] = new Mx.Keyword(this, 387, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 388 SeqOp            */ __Matchers[388] = new Mx.Seq(this, 388, "_388:('for','(',>pattern,'in',>expression,')',>block-body,?(>else-block))") { Builder = nodes => new CForStatement(nodes) };
                /* 389 StringOp         */ __Matchers[389] = new Mx.Keyword(this, 389, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 390 OptionalOp       */ __Matchers[390] = new Mx.Optional(this, 390, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 391 SeqOp            */ __Matchers[391] = new Mx.Seq(this, 391, "_391:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 392 StringOp         */ __Matchers[392] = new Mx.Keyword(this, 392, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 393 SeqOp            */ __Matchers[393] = new Mx.Seq(this, 393, "_393:(?(>string-literal),'assert',>conditions,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 394 AltOp            */ __Matchers[394] = new Mx.Alt(this, 394, "alt(>if-expression|>level-coalesce-expression)") { Builder = nodes => nodes[0] };
                /* 395 AltOp            */ __Matchers[395] = new Mx.Alt(this, 395, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 396 StringOp         */ __Matchers[396] = new Mx.Keyword(this, 396, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 397 SeqOp            */ __Matchers[397] = new Mx.Seq(this, 397, "_397:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 398 SeqOp            */ __Matchers[398] = new Mx.Seq(this, 398, "_398:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 399 AltOp            */ __Matchers[399] = new Mx.Alt(this, 399, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 400 StringOp         */ __Matchers[400] = new Mx.String(this, 400, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 401 SeqOp            */ __Matchers[401] = new Mx.Seq(this, 401, "_401:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 402 AltOp            */ __Matchers[402] = new Mx.Alt(this, 402, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 403 StringOp         */ __Matchers[403] = new Mx.String(this, 403, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 404 SeqOp            */ __Matchers[404] = new Mx.Seq(this, 404, "_404:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 405 AltOp            */ __Matchers[405] = new Mx.Alt(this, 405, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 406 StringOp         */ __Matchers[406] = new Mx.String(this, 406, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 407 SeqOp            */ __Matchers[407] = new Mx.Seq(this, 407, "_407:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 408 AltOp            */ __Matchers[408] = new Mx.Alt(this, 408, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 409 StringOp         */ __Matchers[409] = new Mx.String(this, 409, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 410 SeqOp            */ __Matchers[410] = new Mx.Seq(this, 410, "_410:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 411 StringOp         */ __Matchers[411] = new Mx.String(this, 411, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 412 SeqOp            */ __Matchers[412] = new Mx.Seq(this, 412, "_412:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 413 StringOp         */ __Matchers[413] = new Mx.String(this, 413, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 414 SeqOp            */ __Matchers[414] = new Mx.Seq(this, 414, "_414:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 415 StringOp         */ __Matchers[415] = new Mx.String(this, 415, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 416 SeqOp            */ __Matchers[416] = new Mx.Seq(this, 416, "_416:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 417 AltOp            */ __Matchers[417] = new Mx.Alt(this, 417, "alt(>less-expression|>less-equal-expression|>greater-expression|>greater-equal-expression|>bounds-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 418 SeqOp            */ __Matchers[418] = new Mx.Seq(this, 418, "_418:(>level-add-expression,'<',>level-add-expression)") { Builder = nodes => new CLessExpression(nodes) };
                /* 419 StringOp         */ __Matchers[419] = new Mx.String(this, 419, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 420 SeqOp            */ __Matchers[420] = new Mx.Seq(this, 420, "_420:(>level-add-expression,'<=',>level-add-expression)") { Builder = nodes => new CLessEqualExpression(nodes) };
                /* 421 SeqOp            */ __Matchers[421] = new Mx.Seq(this, 421, "_421:(>level-add-expression,'>',>level-add-expression)") { Builder = nodes => new CGreaterExpression(nodes) };
                /* 422 StringOp         */ __Matchers[422] = new Mx.String(this, 422, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 423 SeqOp            */ __Matchers[423] = new Mx.Seq(this, 423, "_423:(>level-add-expression,'>=',>level-add-expression)") { Builder = nodes => new CGreaterEqualExpression(nodes) };
                /* 424 SeqOp            */ __Matchers[424] = new Mx.Seq(this, 424, "_424:(>lower-bound,>level-add-expression,>upper-bound)") { Builder = nodes => new CBoundsExpression(nodes) };
                /* 425 AltOp            */ __Matchers[425] = new Mx.Alt(this, 425, "alt(>lower-less-bound|>lower-less-equal-bound)") { Builder = nodes => nodes[0] };
                /* 426 SeqOp            */ __Matchers[426] = new Mx.Seq(this, 426, "_426:(>level-add-expression,'<')") { Builder = nodes => new CLowerLessBound(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Mx.Seq(this, 427, "_427:(>level-add-expression,'<=')") { Builder = nodes => new CLowerLessEqualBound(nodes) };
                /* 428 AltOp            */ __Matchers[428] = new Mx.Alt(this, 428, "alt(>upper-less-bound|>upper-less-equal-bound)") { Builder = nodes => nodes[0] };
                /* 429 SeqOp            */ __Matchers[429] = new Mx.Seq(this, 429, "_429:('<',>level-add-expression)") { Builder = nodes => new CUpperLessBound(nodes) };
                /* 430 SeqOp            */ __Matchers[430] = new Mx.Seq(this, 430, "_430:('<=',>level-add-expression)") { Builder = nodes => new CUpperLessEqualBound(nodes) };
                /* 431 AltOp            */ __Matchers[431] = new Mx.Alt(this, 431, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 432 SeqOp            */ __Matchers[432] = new Mx.Seq(this, 432, "_432:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 433 StringOp         */ __Matchers[433] = new Mx.String(this, 433, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 434 SeqOp            */ __Matchers[434] = new Mx.Seq(this, 434, "_434:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 435 AltOp            */ __Matchers[435] = new Mx.Alt(this, 435, "alt(>mul-expression|>div-expression|>rem-expression|>level-union-expression)") { Builder = nodes => nodes[0] };
                /* 436 SeqOp            */ __Matchers[436] = new Mx.Seq(this, 436, "_436:(>level-mul-expression,'*',>level-union-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 437 StringOp         */ __Matchers[437] = new Mx.String(this, 437, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 438 SeqOp            */ __Matchers[438] = new Mx.Seq(this, 438, "_438:(>level-mul-expression,'/',>level-union-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 439 StringOp         */ __Matchers[439] = new Mx.String(this, 439, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 440 SeqOp            */ __Matchers[440] = new Mx.Seq(this, 440, "_440:(>level-mul-expression,'%',>level-union-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 441 AltOp            */ __Matchers[441] = new Mx.Alt(this, 441, "alt(>union-expression|>complement-expression|>level-exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 442 SeqOp            */ __Matchers[442] = new Mx.Seq(this, 442, "_442:(>level-union-expression,'|',>level-exclusive-expression)") { Builder = nodes => new CUnionExpression(nodes) };
                /* 443 StringOp         */ __Matchers[443] = new Mx.String(this, 443, "'~'", "~") { Creator = node => new RLiteral(node) };
                /* 444 SeqOp            */ __Matchers[444] = new Mx.Seq(this, 444, "_444:(>level-union-expression,'~',>level-exclusive-expression)") { Builder = nodes => new CComplementExpression(nodes) };
                /* 445 AltOp            */ __Matchers[445] = new Mx.Alt(this, 445, "alt(>exclusive-expression|>level-intersection-expression)") { Builder = nodes => nodes[0] };
                /* 446 StringOp         */ __Matchers[446] = new Mx.String(this, 446, "'^'", "^") { Creator = node => new RLiteral(node) };
                /* 447 SeqOp            */ __Matchers[447] = new Mx.Seq(this, 447, "_447:(>level-exclusive-expression,'^',>level-intersection-expression)") { Builder = nodes => new CExclusiveExpression(nodes) };
                /* 448 AltOp            */ __Matchers[448] = new Mx.Alt(this, 448, "alt(>intersection-expression|>level-negate-expression)") { Builder = nodes => nodes[0] };
                /* 449 SeqOp            */ __Matchers[449] = new Mx.Seq(this, 449, "_449:(>level-intersection-expression,'&',>level-negate-expression)") { Builder = nodes => new CIntersectionExpression(nodes) };
                /* 450 AltOp            */ __Matchers[450] = new Mx.Alt(this, 450, "alt(>negate-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 451 NotOp            */ __Matchers[451] = new Mx.Not(this, 451, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 452 SeqOp            */ __Matchers[452] = new Mx.Seq(this, 452, "_452:('-',!('-'),>level-negate-expression)") { Builder = nodes => new CNegateExpression(nodes) };
                /* 453 AltOp            */ __Matchers[453] = new Mx.Alt(this, 453, "alt(>reference|>literal|>string-expression|>call-expression|>select-expression|>nullsafe-select-expression|>grouped-expression)") { Builder = nodes => nodes[0] };
                /* 454 SeqOp            */ __Matchers[454] = new Mx.Seq(this, 454, "_454:('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 455 SeqOp            */ __Matchers[455] = new Mx.Seq(this, 455, "_455:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Mx.Seq(this, 456, "_456:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 457 StringOp         */ __Matchers[457] = new Mx.String(this, 457, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 458 SeqOp            */ __Matchers[458] = new Mx.Seq(this, 458, "_458:(>primary-expression,'?.',>reference)") { Builder = nodes => new CNullsafeSelectExpression(nodes) };
                /* 459 AltOp            */ __Matchers[459] = new Mx.Alt(this, 459, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 460 AltOp            */ __Matchers[460] = new Mx.Alt(this, 460, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 461 StarOp           */ __Matchers[461] = new Mx.Star(this, 461, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 462 SeqOp            */ __Matchers[462] = new Mx.Seq(this, 462, "_462:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 463 SeqOp            */ __Matchers[463] = new Mx.Seq(this, 463, "_463:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 464 SeqOp            */ __Matchers[464] = new Mx.Seq(this, 464, "_464:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 465 SeqOp            */ __Matchers[465] = new Mx.Seq(this, 465, "_465:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 466 SeqOp            */ __Matchers[466] = new Mx.Seq(this, 466, "_466:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 467 AltOp            */ __Matchers[467] = new Mx.Alt(this, 467, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 468 SeqOp            */ __Matchers[468] = new Mx.Seq(this, 468, "_468:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 469 SeqOp            */ __Matchers[469] = new Mx.Seq(this, 469, "_469:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 470 StarOp           */ __Matchers[470] = new Mx.Star(this, 470, "*(_469:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 471 SeqOp            */ __Matchers[471] = new Mx.Seq(this, 471, "_471:(>condition,*(_469:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 472 AltOp            */ __Matchers[472] = new Mx.Alt(this, 472, "alt(>is-condition|>expression)") { Builder = nodes => nodes[0] };
                /* 473 OptionalOp       */ __Matchers[473] = new Mx.Optional(this, 473, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 474 SeqOp            */ __Matchers[474] = new Mx.Seq(this, 474, "_474:(?('!'),'is',>type,>name)") { Builder = nodes => new CIsCondition(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[187]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[188]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[191]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[194]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[196]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[200]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[202]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[203]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[205]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[207]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[211]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[212]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[215]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[217]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[218]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[222]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[224]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[228]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[231]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[233]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[236]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[239]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[240]);
                /*  29 PlainRuleOp      */ _valueDefault.Set(__Matchers[241]);
                /*  30 PlainRuleOp      */ _variance.Set(__Matchers[244]);
                /*  31 PlainRuleOp      */ _declarations.Set(__Matchers[245]);
                /*  32 PlainRuleOp      */ _declaration.Set(__Matchers[246]);
                /*  33 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[250]);
                /*  34 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[251]);
                /*  35 PlainRuleOp      */ _varDeclaration.Set(__Matchers[253]);
                /*  36 PlainRuleOp      */ _letDeclaration.Set(__Matchers[255]);
                /*  37 PlainRuleOp      */ _classDeclaration.Set(__Matchers[261]);
                /*  38 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[263]);
                /*  39 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[265]);
                /*  40 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[268]);
                /*  41 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[271]);
                /*  42 PlainRuleOp      */ _functionBody.Set(__Matchers[272]);
                /*  43 PlainRuleOp      */ _attributeBody.Set(__Matchers[272]);
                /*  44 PlainRuleOp      */ _blockBody.Set(__Matchers[273]);
                /*  45 PlainRuleOp      */ _statelarations.Set(__Matchers[274]);
                /*  46 PlainRuleOp      */ _statelaration.Set(__Matchers[275]);
                /*  47 PlainRuleOp      */ _expressionBody.Set(__Matchers[276]);
                /*  48 PlainRuleOp      */ _nullBody.Set(__Matchers[277]);
                /*  49 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[278]);
                /*  50 PlainRuleOp      */ _extends.Set(__Matchers[280]);
                /*  51 PlainRuleOp      */ _extendType.Set(__Matchers[281]);
                /*  52 PlainRuleOp      */ _constructor.Set(__Matchers[282]);
                /*  53 PlainRuleOp      */ _satisfies.Set(__Matchers[284]);
                /*  54 PlainRuleOp      */ _constraints.Set(__Matchers[285]);
                /*  55 PlainRuleOp      */ _constraint.Set(__Matchers[287]);
                /*  56 PlainRuleOp      */ _unionTypeList.Set(__Matchers[290]);
                /*  57 PlainRuleOp      */ _caseTypes.Set(__Matchers[292]);
                /*  58 PlainRuleOp      */ _caseTypeList.Set(__Matchers[296]);
                /*  59 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  60 PlainRuleOp      */ _namePattern.Set(__Matchers[297]);
                /*  61 PlainRuleOp      */ _prelude.Set(__Matchers[300]);
                /*  62 PlainRuleOp      */ _attribute.Set(__Matchers[302]);
                /*  63 DfaRuleOp        */ _attributeName.Set(_attributeName_DFA);
                /*  64 PlainRuleOp      */ _attributeArguments.Set(__Matchers[306]);
                /*  65 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[309]);
                /*  66 PlainRuleOp      */ _attributeArgument.Set(__Matchers[310]);
                /*  67 PlainRuleOp      */ _literalArgument.Set(__Matchers[311]);
                /*  68 PlainRuleOp      */ _metaArgument.Set(__Matchers[312]);
                /*  69 PlainRuleOp      */ _metaReference.Set(__Matchers[313]);
                /*  70 PlainRuleOp      */ _classReference.Set(__Matchers[314]);
                /*  71 PlainRuleOp      */ _objectReference.Set(__Matchers[315]);
                /*  72 PlainRuleOp      */ _valueReference.Set(__Matchers[317]);
                /*  73 PlainRuleOp      */ _interfaceReference.Set(__Matchers[318]);
                /*  74 PlainRuleOp      */ _functionReference.Set(__Matchers[320]);
                /*  75 PlainRuleOp      */ _type.Set(__Matchers[321]);
                /*  76 PlainRuleOp      */ _entryType.Set(__Matchers[323]);
                /*  77 PlainRuleOp      */ _variadicType.Set(__Matchers[324]);
                /*  78 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[326]);
                /*  79 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[328]);
                /*  80 PlainRuleOp      */ _unionType.Set(__Matchers[331]);
                /*  81 PlainRuleOp      */ _intersectionType.Set(__Matchers[335]);
                /*  82 PlainRuleOp      */ _primaryType.Set(__Matchers[336]);
                /*  83 PlainRuleOp      */ _nullableType.Set(__Matchers[338]);
                /*  84 PlainRuleOp      */ _sequenceType.Set(__Matchers[341]);
                /*  85 PlainRuleOp      */ _typeSelector.Set(__Matchers[342]);
                /*  86 PlainRuleOp      */ _callableType.Set(__Matchers[344]);
                /*  87 PlainRuleOp      */ _callableArguments.Set(__Matchers[345]);
                /*  88 PlainRuleOp      */ _typeList.Set(__Matchers[348]);
                /*  89 PlainRuleOp      */ _typeListType.Set(__Matchers[349]);
                /*  90 PlainRuleOp      */ _defaultedType.Set(__Matchers[350]);
                /*  91 PlainRuleOp      */ _spreadType.Set(__Matchers[351]);
                /*  92 PlainRuleOp      */ _emptyType.Set(__Matchers[352]);
                /*  93 PlainRuleOp      */ _tupleType.Set(__Matchers[353]);
                /*  94 PlainRuleOp      */ _iterableType.Set(__Matchers[354]);
                /*  95 PlainRuleOp      */ _iterableTypeZero.Set(__Matchers[355]);
                /*  96 PlainRuleOp      */ _iterableTypeOne.Set(__Matchers[356]);
                /*  97 PlainRuleOp      */ _nothingType.Set(__Matchers[358]);
                /*  98 PlainRuleOp      */ _multiParameters.Set(__Matchers[359]);
                /*  99 PlainRuleOp      */ _parameters.Set(__Matchers[361]);
                /* 100 PlainRuleOp      */ _parameterList.Set(__Matchers[364]);
                /* 101 PlainRuleOp      */ _parameter.Set(_valueParameter);
                /* 102 PlainRuleOp      */ _valueParameter.Set(__Matchers[367]);
                /* 103 PlainRuleOp      */ _parameterType.Set(__Matchers[368]);
                /* 104 PlainRuleOp      */ _arguments.Set(__Matchers[370]);
                /* 105 PlainRuleOp      */ _argumentList.Set(__Matchers[373]);
                /* 106 PlainRuleOp      */ _argument.Set(__Matchers[374]);
                /* 107 PlainRuleOp      */ _expressionArgument.Set(__Matchers[375]);
                /* 108 PlainRuleOp      */ _spreadArgument.Set(__Matchers[376]);
                /* 109 PlainRuleOp      */ _statement.Set(__Matchers[377]);
                /* 110 PlainRuleOp      */ _assignStatement.Set(__Matchers[378]);
                /* 111 PlainRuleOp      */ _expressionStatement.Set(__Matchers[379]);
                /* 112 PlainRuleOp      */ _ifStatement.Set(__Matchers[383]);
                /* 113 PlainRuleOp      */ _elseIf.Set(__Matchers[385]);
                /* 114 PlainRuleOp      */ _elseBlock.Set(__Matchers[386]);
                /* 115 PlainRuleOp      */ _forStatement.Set(__Matchers[388]);
                /* 116 PlainRuleOp      */ _returnStatement.Set(__Matchers[391]);
                /* 117 PlainRuleOp      */ _assertStatement.Set(__Matchers[393]);
                /* 118 PlainRuleOp      */ _expression.Set(__Matchers[394]);
                /* 119 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[395]);
                /* 120 PlainRuleOp      */ _thenExpression.Set(__Matchers[397]);
                /* 121 PlainRuleOp      */ _elseExpression.Set(__Matchers[398]);
                /* 122 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[399]);
                /* 123 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[401]);
                /* 124 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[402]);
                /* 125 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[404]);
                /* 126 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[405]);
                /* 127 PlainRuleOp      */ _notExpression.Set(__Matchers[407]);
                /* 128 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[408]);
                /* 129 PlainRuleOp      */ _equalExpression.Set(__Matchers[410]);
                /* 130 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[412]);
                /* 131 PlainRuleOp      */ _identicalExpression.Set(__Matchers[414]);
                /* 132 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[416]);
                /* 133 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[417]);
                /* 134 PlainRuleOp      */ _lessExpression.Set(__Matchers[418]);
                /* 135 PlainRuleOp      */ _lessEqualExpression.Set(__Matchers[420]);
                /* 136 PlainRuleOp      */ _greaterExpression.Set(__Matchers[421]);
                /* 137 PlainRuleOp      */ _greaterEqualExpression.Set(__Matchers[423]);
                /* 138 PlainRuleOp      */ _boundsExpression.Set(__Matchers[424]);
                /* 139 PlainRuleOp      */ _lowerBound.Set(__Matchers[425]);
                /* 140 PlainRuleOp      */ _lowerLessBound.Set(__Matchers[426]);
                /* 141 PlainRuleOp      */ _lowerLessEqualBound.Set(__Matchers[427]);
                /* 142 PlainRuleOp      */ _upperBound.Set(__Matchers[428]);
                /* 143 PlainRuleOp      */ _upperLessBound.Set(__Matchers[429]);
                /* 144 PlainRuleOp      */ _upperLessEqualBound.Set(__Matchers[430]);
                /* 145 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[431]);
                /* 146 PlainRuleOp      */ _addExpression.Set(__Matchers[432]);
                /* 147 PlainRuleOp      */ _subExpression.Set(__Matchers[434]);
                /* 148 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[435]);
                /* 149 PlainRuleOp      */ _mulExpression.Set(__Matchers[436]);
                /* 150 PlainRuleOp      */ _divExpression.Set(__Matchers[438]);
                /* 151 PlainRuleOp      */ _remExpression.Set(__Matchers[440]);
                /* 152 PlainRuleOp      */ _levelUnionExpression.Set(__Matchers[441]);
                /* 153 PlainRuleOp      */ _unionExpression.Set(__Matchers[442]);
                /* 154 PlainRuleOp      */ _complementExpression.Set(__Matchers[444]);
                /* 155 PlainRuleOp      */ _levelExclusiveExpression.Set(__Matchers[445]);
                /* 156 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[447]);
                /* 157 PlainRuleOp      */ _levelIntersectionExpression.Set(__Matchers[448]);
                /* 158 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[449]);
                /* 159 PlainRuleOp      */ _levelNegateExpression.Set(__Matchers[450]);
                /* 160 PlainRuleOp      */ _negateExpression.Set(__Matchers[452]);
                /* 161 PlainRuleOp      */ _primaryExpression.Set(__Matchers[453]);
                /* 162 PlainRuleOp      */ _groupedExpression.Set(__Matchers[454]);
                /* 163 PlainRuleOp      */ _callExpression.Set(__Matchers[455]);
                /* 164 PlainRuleOp      */ _selectExpression.Set(__Matchers[456]);
                /* 165 PlainRuleOp      */ _nullsafeSelectExpression.Set(__Matchers[458]);
                /* 166 PlainRuleOp      */ _literal.Set(_naturalLiteral);
                /* 167 PlainRuleOp      */ _stringExpression.Set(__Matchers[459]);
                /* 168 PlainRuleOp      */ _stringLiteral.Set(__Matchers[460]);
                /* 169 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[462]);
                /* 170 PlainRuleOp      */ _interpolationPart.Set(__Matchers[463]);
                /* 171 PlainRuleOp      */ _ifExpression.Set(__Matchers[464]);
                /* 172 PlainRuleOp      */ _ifThen.Set(__Matchers[465]);
                /* 173 PlainRuleOp      */ _ifElse.Set(__Matchers[466]);
                /* 174 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[467]);
                /* 175 PlainRuleOp      */ _conditions.Set(__Matchers[468]);
                /* 176 PlainRuleOp      */ _conditionList.Set(__Matchers[471]);
                /* 177 PlainRuleOp      */ _condition.Set(__Matchers[472]);
                /* 178 PlainRuleOp      */ _isCondition.Set(__Matchers[474]);
                /* 179 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 180 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 181 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 182 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 183 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 184 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 185 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 187 SeqOp            */ __Matchers[187].Set(_compilationUnit, __Matchers[186]);
                /* 188 AltOp            */ __Matchers[188].Set(_moduleDescriptor, _codeUnit);
                /* 190 OptionalOp       */ __Matchers[190].Set(__Matchers[189]);
                /* 191 SeqOp            */ __Matchers[191].Set(__Matchers[190], _namespace, _usings, _declarations);
                /* 194 SeqOp            */ __Matchers[194].Set(_prelude, __Matchers[192], _names, __Matchers[193]);
                /* 196 SeqOp            */ __Matchers[196].Set(__Matchers[195], _names, _moduleBody);
                /* 198 StarOp           */ __Matchers[198].Set(_moduleBodyElement);
                /* 200 SeqOp            */ __Matchers[200].Set(__Matchers[197], __Matchers[198], __Matchers[199]);
                /* 202 SeqOp            */ __Matchers[202].Set(__Matchers[201], _names, __Matchers[193]);
                /* 203 StarOp           */ __Matchers[203].Set(_usingDeclaration);
                /* 205 SeqOp            */ __Matchers[205].Set(__Matchers[204], _names, _usingElements);
                /* 206 OptionalOp       */ __Matchers[206].Set(_usingElementList);
                /* 207 SeqOp            */ __Matchers[207].Set(__Matchers[197], __Matchers[206], __Matchers[199]);
                /* 209 SeqOp            */ __Matchers[209].Set(__Matchers[208], _usingElement);
                /* 210 StarOp           */ __Matchers[210].Set(__Matchers[209]);
                /* 211 SeqOp            */ __Matchers[211].Set(_usingElement, __Matchers[210]);
                /* 212 AltOp            */ __Matchers[212].Set(_usingNamed, _usingWildcard);
                /* 213 OptionalOp       */ __Matchers[213].Set(_usingNameSpecifier);
                /* 214 OptionalOp       */ __Matchers[214].Set(_usingElements);
                /* 215 SeqOp            */ __Matchers[215].Set(_usingName, __Matchers[213], __Matchers[214]);
                /* 217 SeqOp            */ __Matchers[217].Set(__Matchers[216], _identifier);
                /* 220 SeqOp            */ __Matchers[220].Set(__Matchers[219], _name);
                /* 221 StarOp           */ __Matchers[221].Set(__Matchers[220]);
                /* 222 SeqOp            */ __Matchers[222].Set(_name, __Matchers[221]);
                /* 223 OptionalOp       */ __Matchers[223].Set(_genericArguments);
                /* 224 SeqOp            */ __Matchers[224].Set(_name, __Matchers[223]);
                /* 226 OptionalOp       */ __Matchers[226].Set(_genericArgumentList);
                /* 228 SeqOp            */ __Matchers[228].Set(__Matchers[225], __Matchers[226], __Matchers[227]);
                /* 229 SeqOp            */ __Matchers[229].Set(__Matchers[208], _genericArgument);
                /* 230 StarOp           */ __Matchers[230].Set(__Matchers[229]);
                /* 231 SeqOp            */ __Matchers[231].Set(_genericArgument, __Matchers[230]);
                /* 232 OptionalOp       */ __Matchers[232].Set(_genericParameterList);
                /* 233 SeqOp            */ __Matchers[233].Set(__Matchers[225], __Matchers[232], __Matchers[227]);
                /* 234 SeqOp            */ __Matchers[234].Set(__Matchers[208], _genericParameter);
                /* 235 StarOp           */ __Matchers[235].Set(__Matchers[234]);
                /* 236 SeqOp            */ __Matchers[236].Set(_genericParameter, __Matchers[235]);
                /* 237 OptionalOp       */ __Matchers[237].Set(_variance);
                /* 238 OptionalOp       */ __Matchers[238].Set(_typeDefault);
                /* 239 SeqOp            */ __Matchers[239].Set(__Matchers[237], _name, __Matchers[238]);
                /* 240 SeqOp            */ __Matchers[240].Set(__Matchers[216], _type);
                /* 241 SeqOp            */ __Matchers[241].Set(__Matchers[216], _expression);
                /* 244 AltOp            */ __Matchers[244].Set(__Matchers[242], __Matchers[243]);
                /* 245 StarOp           */ __Matchers[245].Set(_declaration);
                /* 246 AltOp            */ __Matchers[246].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration, _letDeclaration, _varDeclaration);
                /* 247 OptionalOp       */ __Matchers[247].Set(_type);
                /* 248 OptionalOp       */ __Matchers[248].Set(_genericParameters);
                /* 249 OptionalOp       */ __Matchers[249].Set(_constraints);
                /* 250 SeqOp            */ __Matchers[250].Set(_prelude, __Matchers[247], _name, __Matchers[248], _multiParameters, __Matchers[249], _functionBody);
                /* 251 SeqOp            */ __Matchers[251].Set(_prelude, __Matchers[247], _name, _attributeBody);
                /* 253 SeqOp            */ __Matchers[253].Set(_prelude, __Matchers[252], __Matchers[247], _name, __Matchers[216], _expression, __Matchers[193]);
                /* 255 SeqOp            */ __Matchers[255].Set(_prelude, __Matchers[254], __Matchers[247], _name, __Matchers[216], _expression, __Matchers[193]);
                /* 257 OptionalOp       */ __Matchers[257].Set(_parameters);
                /* 258 OptionalOp       */ __Matchers[258].Set(_extends);
                /* 259 OptionalOp       */ __Matchers[259].Set(_satisfies);
                /* 260 OptionalOp       */ __Matchers[260].Set(_caseTypes);
                /* 261 SeqOp            */ __Matchers[261].Set(_prelude, __Matchers[256], _name, __Matchers[248], __Matchers[257], __Matchers[258], __Matchers[259], __Matchers[260], __Matchers[249], _blockBody);
                /* 263 SeqOp            */ __Matchers[263].Set(_prelude, __Matchers[262], _name, __Matchers[248], __Matchers[257], __Matchers[259], __Matchers[260], __Matchers[249], _blockBody);
                /* 265 SeqOp            */ __Matchers[265].Set(_prelude, __Matchers[264], _name, __Matchers[258], __Matchers[259], _blockBody);
                /* 268 SeqOp            */ __Matchers[268].Set(_prelude, __Matchers[266], _name, __Matchers[248], __Matchers[249], __Matchers[267], _type, __Matchers[193]);
                /* 270 OptionalOp       */ __Matchers[270].Set(_name);
                /* 271 SeqOp            */ __Matchers[271].Set(_prelude, __Matchers[269], __Matchers[270], __Matchers[258], _functionBody);
                /* 272 AltOp            */ __Matchers[272].Set(_expressionBody, _blockBody, _nullBody);
                /* 273 SeqOp            */ __Matchers[273].Set(__Matchers[197], _usings, _statelarations, __Matchers[199]);
                /* 274 StarOp           */ __Matchers[274].Set(_statelaration);
                /* 275 AltOp            */ __Matchers[275].Set(_statement, _declaration);
                /* 276 SeqOp            */ __Matchers[276].Set(_functionSpecifier, __Matchers[193]);
                /* 277 SeqOp            */ __Matchers[277].Set(__Matchers[193]);
                /* 278 SeqOp            */ __Matchers[278].Set(__Matchers[267], _expression);
                /* 280 SeqOp            */ __Matchers[280].Set(__Matchers[279], _extendType);
                /* 281 AltOp            */ __Matchers[281].Set(_type, _constructor);
                /* 282 SeqOp            */ __Matchers[282].Set(_primaryType, _arguments);
                /* 284 SeqOp            */ __Matchers[284].Set(__Matchers[283], _unionTypeList);
                /* 285 PlusOp           */ __Matchers[285].Set(_constraint);
                /* 287 SeqOp            */ __Matchers[287].Set(__Matchers[286], _name, __Matchers[248], __Matchers[260], __Matchers[259]);
                /* 288 SeqOp            */ __Matchers[288].Set(__Matchers[208], _type);
                /* 289 StarOp           */ __Matchers[289].Set(__Matchers[288]);
                /* 290 SeqOp            */ __Matchers[290].Set(_type, __Matchers[289]);
                /* 292 SeqOp            */ __Matchers[292].Set(__Matchers[291], _caseTypeList);
                /* 294 SeqOp            */ __Matchers[294].Set(__Matchers[293], _type);
                /* 295 StarOp           */ __Matchers[295].Set(__Matchers[294]);
                /* 296 SeqOp            */ __Matchers[296].Set(_type, __Matchers[295]);
                /* 297 SeqOp            */ __Matchers[297].Set(_name);
                /* 298 OptionalOp       */ __Matchers[298].Set(_stringLiteral);
                /* 299 StarOp           */ __Matchers[299].Set(_attribute);
                /* 300 SeqOp            */ __Matchers[300].Set(__Matchers[298], __Matchers[299]);
                /* 301 OptionalOp       */ __Matchers[301].Set(_attributeArguments);
                /* 302 SeqOp            */ __Matchers[302].Set(_attributeName, __Matchers[301]);
                /* 304 OptionalOp       */ __Matchers[304].Set(_attributeArgumentList);
                /* 306 SeqOp            */ __Matchers[306].Set(__Matchers[303], __Matchers[304], __Matchers[305]);
                /* 307 SeqOp            */ __Matchers[307].Set(__Matchers[208], _attributeArgument);
                /* 308 StarOp           */ __Matchers[308].Set(__Matchers[307]);
                /* 309 SeqOp            */ __Matchers[309].Set(_attributeArgument, __Matchers[308]);
                /* 310 AltOp            */ __Matchers[310].Set(_literalArgument, _metaArgument);
                /* 311 SeqOp            */ __Matchers[311].Set(_stringLiteral);
                /* 312 SeqOp            */ __Matchers[312].Set(_metaReference);
                /* 313 AltOp            */ __Matchers[313].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 314 SeqOp            */ __Matchers[314].Set(__Matchers[256], _names);
                /* 315 SeqOp            */ __Matchers[315].Set(__Matchers[264], _names);
                /* 317 SeqOp            */ __Matchers[317].Set(__Matchers[316], _names);
                /* 318 SeqOp            */ __Matchers[318].Set(__Matchers[262], _names);
                /* 320 SeqOp            */ __Matchers[320].Set(__Matchers[319], _names);
                /* 321 AltOp            */ __Matchers[321].Set(_entryType, _unionType);
                /* 323 SeqOp            */ __Matchers[323].Set(_unionType, __Matchers[322], _unionType);
                /* 324 AltOp            */ __Matchers[324].Set(_variadicTypeZero, _variadicTypeOne);
                /* 326 SeqOp            */ __Matchers[326].Set(_unionType, __Matchers[325]);
                /* 328 SeqOp            */ __Matchers[328].Set(_unionType, __Matchers[327]);
                /* 329 SeqOp            */ __Matchers[329].Set(__Matchers[293], _intersectionType);
                /* 330 StarOp           */ __Matchers[330].Set(__Matchers[329]);
                /* 331 SeqOp            */ __Matchers[331].Set(_intersectionType, __Matchers[330]);
                /* 333 SeqOp            */ __Matchers[333].Set(__Matchers[332], _primaryType);
                /* 334 StarOp           */ __Matchers[334].Set(__Matchers[333]);
                /* 335 SeqOp            */ __Matchers[335].Set(_primaryType, __Matchers[334]);
                /* 336 AltOp            */ __Matchers[336].Set(_nullableType, _sequenceType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _iterableType, _nothingType);
                /* 338 SeqOp            */ __Matchers[338].Set(_primaryType, __Matchers[337]);
                /* 341 SeqOp            */ __Matchers[341].Set(_primaryType, __Matchers[339], __Matchers[340]);
                /* 342 SeqOp            */ __Matchers[342].Set(_primaryType, __Matchers[219], _reference);
                /* 343 OptionalOp       */ __Matchers[343].Set(_callableArguments);
                /* 344 SeqOp            */ __Matchers[344].Set(_primaryType, __Matchers[303], __Matchers[343], __Matchers[305]);
                /* 345 AltOp            */ __Matchers[345].Set(_typeList, _spreadType);
                /* 346 SeqOp            */ __Matchers[346].Set(__Matchers[208], _typeListType);
                /* 347 StarOp           */ __Matchers[347].Set(__Matchers[346]);
                /* 348 SeqOp            */ __Matchers[348].Set(_typeListType, __Matchers[347]);
                /* 349 AltOp            */ __Matchers[349].Set(_type, _defaultedType, _variadicType);
                /* 350 SeqOp            */ __Matchers[350].Set(_type, __Matchers[216]);
                /* 351 SeqOp            */ __Matchers[351].Set(__Matchers[325], _unionType);
                /* 352 SeqOp            */ __Matchers[352].Set(__Matchers[339], __Matchers[340]);
                /* 353 SeqOp            */ __Matchers[353].Set(__Matchers[339], _typeList, __Matchers[340]);
                /* 354 AltOp            */ __Matchers[354].Set(_iterableTypeZero, _iterableTypeOne);
                /* 355 SeqOp            */ __Matchers[355].Set(__Matchers[197], _unionType, __Matchers[325], __Matchers[199]);
                /* 356 SeqOp            */ __Matchers[356].Set(__Matchers[197], _unionType, __Matchers[327], __Matchers[199]);
                /* 358 SeqOp            */ __Matchers[358].Set(__Matchers[357]);
                /* 359 PlusOp           */ __Matchers[359].Set(_parameters);
                /* 360 OptionalOp       */ __Matchers[360].Set(_parameterList);
                /* 361 SeqOp            */ __Matchers[361].Set(__Matchers[303], __Matchers[360], __Matchers[305]);
                /* 362 SeqOp            */ __Matchers[362].Set(__Matchers[208], _parameter);
                /* 363 StarOp           */ __Matchers[363].Set(__Matchers[362]);
                /* 364 SeqOp            */ __Matchers[364].Set(_parameter, __Matchers[363]);
                /* 365 OptionalOp       */ __Matchers[365].Set(_parameterType);
                /* 366 OptionalOp       */ __Matchers[366].Set(_valueDefault);
                /* 367 SeqOp            */ __Matchers[367].Set(_prelude, __Matchers[365], _name, __Matchers[366]);
                /* 368 AltOp            */ __Matchers[368].Set(_type, _variadicType);
                /* 369 OptionalOp       */ __Matchers[369].Set(_argumentList);
                /* 370 SeqOp            */ __Matchers[370].Set(__Matchers[303], __Matchers[369], __Matchers[305]);
                /* 371 SeqOp            */ __Matchers[371].Set(__Matchers[208], _argument);
                /* 372 StarOp           */ __Matchers[372].Set(__Matchers[371]);
                /* 373 SeqOp            */ __Matchers[373].Set(_argument, __Matchers[372]);
                /* 374 AltOp            */ __Matchers[374].Set(_expressionArgument, _spreadArgument);
                /* 375 SeqOp            */ __Matchers[375].Set(_expression);
                /* 376 SeqOp            */ __Matchers[376].Set(__Matchers[325], _levelUnionExpression);
                /* 377 AltOp            */ __Matchers[377].Set(_assignStatement, _expressionStatement, _ifStatement, _forStatement, _returnStatement, _assertStatement);
                /* 378 SeqOp            */ __Matchers[378].Set(_name, __Matchers[216], _expression, __Matchers[193]);
                /* 379 SeqOp            */ __Matchers[379].Set(_expression, __Matchers[193]);
                /* 381 StarOp           */ __Matchers[381].Set(_elseIf);
                /* 382 OptionalOp       */ __Matchers[382].Set(_elseBlock);
                /* 383 SeqOp            */ __Matchers[383].Set(__Matchers[380], _conditions, _blockBody, __Matchers[381], __Matchers[382]);
                /* 385 SeqOp            */ __Matchers[385].Set(__Matchers[384], __Matchers[380], _conditions, _blockBody);
                /* 386 SeqOp            */ __Matchers[386].Set(__Matchers[384], _blockBody);
                /* 388 SeqOp            */ __Matchers[388].Set(__Matchers[387], __Matchers[303], _pattern, __Matchers[242], _expression, __Matchers[305], _blockBody, __Matchers[382]);
                /* 390 OptionalOp       */ __Matchers[390].Set(_expression);
                /* 391 SeqOp            */ __Matchers[391].Set(__Matchers[389], __Matchers[390], __Matchers[193]);
                /* 393 SeqOp            */ __Matchers[393].Set(__Matchers[298], __Matchers[392], _conditions, __Matchers[193]);
                /* 394 AltOp            */ __Matchers[394].Set(_ifExpression, _levelCoalesceExpression);
                /* 395 AltOp            */ __Matchers[395].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 397 SeqOp            */ __Matchers[397].Set(_levelCoalesceExpression, __Matchers[396], _levelDisjunctionExpression);
                /* 398 SeqOp            */ __Matchers[398].Set(_levelCoalesceExpression, __Matchers[384], _levelDisjunctionExpression);
                /* 399 AltOp            */ __Matchers[399].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 401 SeqOp            */ __Matchers[401].Set(_levelDisjunctionExpression, __Matchers[400], _levelConjunctionExpression);
                /* 402 AltOp            */ __Matchers[402].Set(_conjunctionExpression, _levelNotExpression);
                /* 404 SeqOp            */ __Matchers[404].Set(_levelConjunctionExpression, __Matchers[403], _levelNotExpression);
                /* 405 AltOp            */ __Matchers[405].Set(_notExpression, _levelEqualityExpression);
                /* 407 SeqOp            */ __Matchers[407].Set(__Matchers[406], _levelNotExpression);
                /* 408 AltOp            */ __Matchers[408].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 410 SeqOp            */ __Matchers[410].Set(_levelCompareExpression, __Matchers[409], _levelCompareExpression);
                /* 412 SeqOp            */ __Matchers[412].Set(_levelCompareExpression, __Matchers[411], _levelCompareExpression);
                /* 414 SeqOp            */ __Matchers[414].Set(_levelCompareExpression, __Matchers[413], _levelCompareExpression);
                /* 416 SeqOp            */ __Matchers[416].Set(_levelCompareExpression, __Matchers[415], _levelCompareExpression);
                /* 417 AltOp            */ __Matchers[417].Set(_lessExpression, _lessEqualExpression, _greaterExpression, _greaterEqualExpression, _boundsExpression, _levelAddExpression);
                /* 418 SeqOp            */ __Matchers[418].Set(_levelAddExpression, __Matchers[225], _levelAddExpression);
                /* 420 SeqOp            */ __Matchers[420].Set(_levelAddExpression, __Matchers[419], _levelAddExpression);
                /* 421 SeqOp            */ __Matchers[421].Set(_levelAddExpression, __Matchers[227], _levelAddExpression);
                /* 423 SeqOp            */ __Matchers[423].Set(_levelAddExpression, __Matchers[422], _levelAddExpression);
                /* 424 SeqOp            */ __Matchers[424].Set(_lowerBound, _levelAddExpression, _upperBound);
                /* 425 AltOp            */ __Matchers[425].Set(_lowerLessBound, _lowerLessEqualBound);
                /* 426 SeqOp            */ __Matchers[426].Set(_levelAddExpression, __Matchers[225]);
                /* 427 SeqOp            */ __Matchers[427].Set(_levelAddExpression, __Matchers[419]);
                /* 428 AltOp            */ __Matchers[428].Set(_upperLessBound, _upperLessEqualBound);
                /* 429 SeqOp            */ __Matchers[429].Set(__Matchers[225], _levelAddExpression);
                /* 430 SeqOp            */ __Matchers[430].Set(__Matchers[419], _levelAddExpression);
                /* 431 AltOp            */ __Matchers[431].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 432 SeqOp            */ __Matchers[432].Set(_levelAddExpression, __Matchers[327], _levelMulExpression);
                /* 434 SeqOp            */ __Matchers[434].Set(_levelAddExpression, __Matchers[433], _levelMulExpression);
                /* 435 AltOp            */ __Matchers[435].Set(_mulExpression, _divExpression, _remExpression, _levelUnionExpression);
                /* 436 SeqOp            */ __Matchers[436].Set(_levelMulExpression, __Matchers[325], _levelUnionExpression);
                /* 438 SeqOp            */ __Matchers[438].Set(_levelMulExpression, __Matchers[437], _levelUnionExpression);
                /* 440 SeqOp            */ __Matchers[440].Set(_levelMulExpression, __Matchers[439], _levelUnionExpression);
                /* 441 AltOp            */ __Matchers[441].Set(_unionExpression, _complementExpression, _levelExclusiveExpression);
                /* 442 SeqOp            */ __Matchers[442].Set(_levelUnionExpression, __Matchers[293], _levelExclusiveExpression);
                /* 444 SeqOp            */ __Matchers[444].Set(_levelUnionExpression, __Matchers[443], _levelExclusiveExpression);
                /* 445 AltOp            */ __Matchers[445].Set(_exclusiveExpression, _levelIntersectionExpression);
                /* 447 SeqOp            */ __Matchers[447].Set(_levelExclusiveExpression, __Matchers[446], _levelIntersectionExpression);
                /* 448 AltOp            */ __Matchers[448].Set(_intersectionExpression, _levelNegateExpression);
                /* 449 SeqOp            */ __Matchers[449].Set(_levelIntersectionExpression, __Matchers[332], _levelNegateExpression);
                /* 450 AltOp            */ __Matchers[450].Set(_negateExpression, _primaryExpression);
                /* 451 NotOp            */ __Matchers[451].Set(__Matchers_451_DFA);
                /* 452 SeqOp            */ __Matchers[452].Set(__Matchers[433], __Matchers[451], _levelNegateExpression);
                /* 453 AltOp            */ __Matchers[453].Set(_reference, _literal, _stringExpression, _callExpression, _selectExpression, _nullsafeSelectExpression, _groupedExpression);
                /* 454 SeqOp            */ __Matchers[454].Set(__Matchers[303], _expression, __Matchers[305]);
                /* 455 SeqOp            */ __Matchers[455].Set(_primaryExpression, _arguments);
                /* 456 SeqOp            */ __Matchers[456].Set(_primaryExpression, __Matchers[219], _reference);
                /* 458 SeqOp            */ __Matchers[458].Set(_primaryExpression, __Matchers[457], _reference);
                /* 459 AltOp            */ __Matchers[459].Set(_stringLiteral, _stringInterpolation);
                /* 460 AltOp            */ __Matchers[460].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 461 StarOp           */ __Matchers[461].Set(_interpolationPart);
                /* 462 SeqOp            */ __Matchers[462].Set(_stringStart, _expression, __Matchers[461], _stringEnd);
                /* 463 SeqOp            */ __Matchers[463].Set(_stringMid, _expression);
                /* 464 SeqOp            */ __Matchers[464].Set(__Matchers[380], _conditions, _ifThen, _ifElse);
                /* 465 SeqOp            */ __Matchers[465].Set(__Matchers[396], _conditionalExpression);
                /* 466 SeqOp            */ __Matchers[466].Set(__Matchers[384], _conditionalExpression);
                /* 467 AltOp            */ __Matchers[467].Set(_ifExpression, _levelDisjunctionExpression);
                /* 468 SeqOp            */ __Matchers[468].Set(__Matchers[303], _conditionList, __Matchers[305]);
                /* 469 SeqOp            */ __Matchers[469].Set(__Matchers[208], _condition);
                /* 470 StarOp           */ __Matchers[470].Set(__Matchers[469]);
                /* 471 SeqOp            */ __Matchers[471].Set(_condition, __Matchers[470]);
                /* 472 AltOp            */ __Matchers[472].Set(_isCondition, _expression);
                /* 473 OptionalOp       */ __Matchers[473].Set(__Matchers[406]);
                /* 474 SeqOp            */ __Matchers[474].Set(__Matchers[473], __Matchers[283], _type, _name);

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
                    new DfaState(55, false)
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
                    new DfaTrans(_attributeName_DFA.States[53], new DfaInterval(102, 102))
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
                    new DfaState(67, true)
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
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[65], new DfaInterval(119, 119))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[64], new DfaInterval(108, 108)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[64].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[65].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[66], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[66].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[67], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[67].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(160, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(114, 114))
                );
                __Matchers_451_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_451_DFA.States[0].Set(
                    new DfaTrans(__Matchers_451_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_451_DFA.States[1].Set(
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
            private readonly Mx.PlainRule _assignStatement;
            private readonly Mx.PlainRule _expressionStatement;
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
            private readonly Dfa __Matchers_451_DFA = new Dfa("__Matchers_451_DFA");
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
        public interface ICAssignStatement : ICStatement {}
        public interface ICExpressionStatement : ICStatement {}
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
            public RNot<RLiteral> Literal2 => Get<RNot<RLiteral>>(1);
            public ICLevelNegateExpression LevelNegateExpression => Get<ICLevelNegateExpression>(2);
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
