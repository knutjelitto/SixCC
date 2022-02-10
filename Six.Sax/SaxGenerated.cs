// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Sax\\Sax.six" at="10.02.2022 14:31:57" />

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
                : base(new Mx.Matcher[390])
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
                /*  48 PlainRuleOp      */ __Matchers[48] = _extendType = new Mx.PlainRule(this, 48, "extend-type") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _constructor = new Mx.PlainRule(this, 49, "constructor") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _satisfies = new Mx.PlainRule(this, 50, "satisfies") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _constraints = new Mx.PlainRule(this, 51, "constraints") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _constraint = new Mx.PlainRule(this, 52, "constraint") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _unionTypeList = new Mx.PlainRule(this, 53, "union-type-list") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _caseTypes = new Mx.PlainRule(this, 54, "case-types") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _caseTypeList = new Mx.PlainRule(this, 55, "case-type-list") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _pattern = new Mx.PlainRule(this, 56, "pattern") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _namePattern = new Mx.PlainRule(this, 57, "name-pattern") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _prelude = new Mx.PlainRule(this, 58, "prelude") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _attribute = new Mx.PlainRule(this, 59, "attribute") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _attributeArguments = new Mx.PlainRule(this, 60, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _attributeArgumentList = new Mx.PlainRule(this, 61, "attribute-argument-list") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _attributeArgument = new Mx.PlainRule(this, 62, "attribute-argument") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _metaReference = new Mx.PlainRule(this, 63, "meta-reference") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _classReference = new Mx.PlainRule(this, 64, "class-reference") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _objectReference = new Mx.PlainRule(this, 65, "object-reference") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _valueReference = new Mx.PlainRule(this, 66, "value-reference") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _interfaceReference = new Mx.PlainRule(this, 67, "interface-reference") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _functionReference = new Mx.PlainRule(this, 68, "function-reference") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _type = new Mx.PlainRule(this, 69, "type") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _entryType = new Mx.PlainRule(this, 70, "entry-type") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _variadicType = new Mx.PlainRule(this, 71, "variadic-type") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _variadicTypeZero = new Mx.PlainRule(this, 72, "variadic-type-zero") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _variadicTypeOne = new Mx.PlainRule(this, 73, "variadic-type-one") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _unionType = new Mx.PlainRule(this, 74, "union-type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _intersectionType = new Mx.PlainRule(this, 75, "intersection-type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _primaryType = new Mx.PlainRule(this, 76, "primary-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _nullableType = new Mx.PlainRule(this, 77, "nullable-type") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _sequenceType = new Mx.PlainRule(this, 78, "sequence-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _typeSelector = new Mx.PlainRule(this, 79, "type-selector") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _callableType = new Mx.PlainRule(this, 80, "callable-type") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _callableArguments = new Mx.PlainRule(this, 81, "callable-arguments") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _typeList = new Mx.PlainRule(this, 82, "type-list") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeListType = new Mx.PlainRule(this, 83, "type-list-type") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _defaultedType = new Mx.PlainRule(this, 84, "defaulted-type") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _spreadType = new Mx.PlainRule(this, 85, "spread-type") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _emptyType = new Mx.PlainRule(this, 86, "empty-type") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _tupleType = new Mx.PlainRule(this, 87, "tuple-type") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _iterableType = new Mx.PlainRule(this, 88, "iterable-type") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _multiParameters = new Mx.PlainRule(this, 89, "multi-parameters") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _parameters = new Mx.PlainRule(this, 90, "parameters") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _parameterList = new Mx.PlainRule(this, 91, "parameter-list") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _parameter = new Mx.PlainRule(this, 92, "parameter") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _parameterType = new Mx.PlainRule(this, 93, "parameter-type") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _arguments = new Mx.PlainRule(this, 94, "arguments") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _argumentList = new Mx.PlainRule(this, 95, "argument-list") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _argument = new Mx.PlainRule(this, 96, "argument") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _statement = new Mx.PlainRule(this, 97, "statement") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _ifStatement = new Mx.PlainRule(this, 98, "if-statement") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _elseIf = new Mx.PlainRule(this, 99, "else-if") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _elseBlock = new Mx.PlainRule(this, 100, "else-block") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _forStatement = new Mx.PlainRule(this, 101, "for-statement") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _returnStatement = new Mx.PlainRule(this, 102, "return-statement") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _assertStatement = new Mx.PlainRule(this, 103, "assert-statement") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _expression = new Mx.PlainRule(this, 104, "expression") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _levelCoalesceExpression = new Mx.PlainRule(this, 105, "level-coalesce-expression") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _thenExpression = new Mx.PlainRule(this, 106, "then-expression") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _elseExpression = new Mx.PlainRule(this, 107, "else-expression") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _levelDisjunctionExpression = new Mx.PlainRule(this, 108, "level-disjunction-expression") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _disjunctionExpression = new Mx.PlainRule(this, 109, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _levelConjunctionExpression = new Mx.PlainRule(this, 110, "level-conjunction-expression") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _conjunctionExpression = new Mx.PlainRule(this, 111, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _levelNotExpression = new Mx.PlainRule(this, 112, "level-not-expression") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _notExpression = new Mx.PlainRule(this, 113, "not-expression") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _levelEqualityExpression = new Mx.PlainRule(this, 114, "level-equality-expression") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _equalExpression = new Mx.PlainRule(this, 115, "equal-expression") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _notEqualExpression = new Mx.PlainRule(this, 116, "not-equal-expression") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _identicalExpression = new Mx.PlainRule(this, 117, "identical-expression") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _notIdenticalExpression = new Mx.PlainRule(this, 118, "not-identical-expression") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _levelCompareExpression = new Mx.PlainRule(this, 119, "level-compare-expression") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _ltExpression = new Mx.PlainRule(this, 120, "lt-expression") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _leExpression = new Mx.PlainRule(this, 121, "le-expression") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _gtExpression = new Mx.PlainRule(this, 122, "gt-expression") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _geExpression = new Mx.PlainRule(this, 123, "ge-expression") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _levelAddExpression = new Mx.PlainRule(this, 124, "level-add-expression") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _addExpression = new Mx.PlainRule(this, 125, "add-expression") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _subExpression = new Mx.PlainRule(this, 126, "sub-expression") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _levelMulExpression = new Mx.PlainRule(this, 127, "level-mul-expression") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _mulExpression = new Mx.PlainRule(this, 128, "mul-expression") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _divExpression = new Mx.PlainRule(this, 129, "div-expression") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _remExpression = new Mx.PlainRule(this, 130, "rem-expression") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _primaryExpression = new Mx.PlainRule(this, 131, "primary-expression") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _callExpression = new Mx.PlainRule(this, 132, "call-expression") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _selectExpression = new Mx.PlainRule(this, 133, "select-expression") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _literal = new Mx.PlainRule(this, 134, "literal") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _stringLiteral = new Mx.PlainRule(this, 135, "string-literal") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _ifExpression = new Mx.PlainRule(this, 136, "if-expression") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _ifThen = new Mx.PlainRule(this, 137, "if-then") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _ifElse = new Mx.PlainRule(this, 138, "if-else") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _conditionalExpression = new Mx.PlainRule(this, 139, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _conditions = new Mx.PlainRule(this, 140, "conditions") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _conditionList = new Mx.PlainRule(this, 141, "condition-list") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _condition = new Mx.PlainRule(this, 142, "condition") { Builder = nodes => nodes[0] };
                /* 143 DfaRuleOp        */ __Matchers[143] = _naturalLiteral = new Mx.DfaRule(this, 143, "natural-literal") { Creator = node => new CNaturalLiteral(node) };
                /* 144 DfaRuleOp        */ __Matchers[144] = _plainStringLiteral = new Mx.DfaRule(this, 144, "plain-string-literal") { Creator = node => new CPlainStringLiteral(node) };
                /* 145 DfaRuleOp        */ __Matchers[145] = _verbatimStringLiteral = new Mx.DfaRule(this, 145, "verbatim-string-literal") { Creator = node => new CVerbatimStringLiteral(node) };
                /* 146 DfaRuleOp        */ __Matchers[146] = _identifier = new Mx.DfaRule(this, 146, "identifier") { Creator = node => new CIdentifier(node) };
                /* 147 EofOp            */ __Matchers[147] = new Mx.Eof(this, 147, "<eof>") { Creator = node => new REof(node) };
                /* 148 SeqOp            */ __Matchers[148] = new Mx.Seq(this, 148, "_148:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 149 AltOp            */ __Matchers[149] = new Mx.Alt(this, 149, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 150 StringOp         */ __Matchers[150] = new Mx.String(this, 150, "'@skip'", "@skip") { Creator = node => new RLiteral(node) };
                /* 151 OptionalOp       */ __Matchers[151] = new Mx.Optional(this, 151, "?('@skip')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 152 SeqOp            */ __Matchers[152] = new Mx.Seq(this, 152, "_152:(?('@skip'),>namespace,>usings,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 153 StringOp         */ __Matchers[153] = new Mx.Keyword(this, 153, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 154 StringOp         */ __Matchers[154] = new Mx.String(this, 154, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 155 SeqOp            */ __Matchers[155] = new Mx.Seq(this, 155, "_155:(>prelude,'namespace',>names,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 156 StringOp         */ __Matchers[156] = new Mx.Keyword(this, 156, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 157 SeqOp            */ __Matchers[157] = new Mx.Seq(this, 157, "_157:('module',>names,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 158 StringOp         */ __Matchers[158] = new Mx.String(this, 158, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 159 StarOp           */ __Matchers[159] = new Mx.Star(this, 159, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 160 StringOp         */ __Matchers[160] = new Mx.String(this, 160, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 161 SeqOp            */ __Matchers[161] = new Mx.Seq(this, 161, "_161:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 162 StringOp         */ __Matchers[162] = new Mx.Keyword(this, 162, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 163 SeqOp            */ __Matchers[163] = new Mx.Seq(this, 163, "_163:('import',>names,';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 164 StarOp           */ __Matchers[164] = new Mx.Star(this, 164, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /* 165 StringOp         */ __Matchers[165] = new Mx.Keyword(this, 165, "'using'", "using") { Creator = node => new RLiteral(node) };
                /* 166 SeqOp            */ __Matchers[166] = new Mx.Seq(this, 166, "_166:('using',>names,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /* 167 OptionalOp       */ __Matchers[167] = new Mx.Optional(this, 167, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /* 168 SeqOp            */ __Matchers[168] = new Mx.Seq(this, 168, "_168:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /* 169 StringOp         */ __Matchers[169] = new Mx.String(this, 169, "','", ",") { Creator = node => new RLiteral(node) };
                /* 170 SeqOp            */ __Matchers[170] = new Mx.Seq(this, 170, "_170:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /* 171 StarOp           */ __Matchers[171] = new Mx.Star(this, 171, "*(_170:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 172 SeqOp            */ __Matchers[172] = new Mx.Seq(this, 172, "_172:(>using-element,*(_170:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /* 173 AltOp            */ __Matchers[173] = new Mx.Alt(this, 173, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /* 174 OptionalOp       */ __Matchers[174] = new Mx.Optional(this, 174, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /* 175 OptionalOp       */ __Matchers[175] = new Mx.Optional(this, 175, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /* 176 SeqOp            */ __Matchers[176] = new Mx.Seq(this, 176, "_176:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /* 177 StringOp         */ __Matchers[177] = new Mx.String(this, 177, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 178 SeqOp            */ __Matchers[178] = new Mx.Seq(this, 178, "_178:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /* 179 StringOp         */ __Matchers[179] = new Mx.String(this, 179, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /* 180 StringOp         */ __Matchers[180] = new Mx.String(this, 180, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 181 SeqOp            */ __Matchers[181] = new Mx.Seq(this, 181, "_181:('.',>name)") { Builder = nodes => new RSequence(nodes) };
                /* 182 StarOp           */ __Matchers[182] = new Mx.Star(this, 182, "*(_181:('.',>name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 183 SeqOp            */ __Matchers[183] = new Mx.Seq(this, 183, "_183:(>name,*(_181:('.',>name)))") { Builder = nodes => new CNames(nodes) };
                /* 184 OptionalOp       */ __Matchers[184] = new Mx.Optional(this, 184, "?(>generic-arguments)") { Builder = nodes => new ROptional<CGenericArguments>(nodes) };
                /* 185 SeqOp            */ __Matchers[185] = new Mx.Seq(this, 185, "_185:(>name,?(>generic-arguments))") { Builder = nodes => new CReference(nodes) };
                /* 186 StringOp         */ __Matchers[186] = new Mx.String(this, 186, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 187 OptionalOp       */ __Matchers[187] = new Mx.Optional(this, 187, "?(>generic-argument-list)") { Builder = nodes => new ROptional<CGenericArgumentList>(nodes) };
                /* 188 StringOp         */ __Matchers[188] = new Mx.String(this, 188, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 189 SeqOp            */ __Matchers[189] = new Mx.Seq(this, 189, "_189:('<',?(>generic-argument-list),'>')") { Builder = nodes => new CGenericArguments(nodes) };
                /* 190 SeqOp            */ __Matchers[190] = new Mx.Seq(this, 190, "_190:(',',>generic-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 191 StarOp           */ __Matchers[191] = new Mx.Star(this, 191, "*(_190:(',',>generic-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 192 SeqOp            */ __Matchers[192] = new Mx.Seq(this, 192, "_192:(>generic-argument,*(_190:(',',>generic-argument)))") { Builder = nodes => new CGenericArgumentList(nodes) };
                /* 193 OptionalOp       */ __Matchers[193] = new Mx.Optional(this, 193, "?(>generic-parameter-list)") { Builder = nodes => new ROptional<CGenericParameterList>(nodes) };
                /* 194 SeqOp            */ __Matchers[194] = new Mx.Seq(this, 194, "_194:('<',?(>generic-parameter-list),'>')") { Builder = nodes => new CGenericParameters(nodes) };
                /* 195 SeqOp            */ __Matchers[195] = new Mx.Seq(this, 195, "_195:(',',>generic-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 196 StarOp           */ __Matchers[196] = new Mx.Star(this, 196, "*(_195:(',',>generic-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 197 SeqOp            */ __Matchers[197] = new Mx.Seq(this, 197, "_197:(>generic-parameter,*(_195:(',',>generic-parameter)))") { Builder = nodes => new CGenericParameterList(nodes) };
                /* 198 OptionalOp       */ __Matchers[198] = new Mx.Optional(this, 198, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 199 OptionalOp       */ __Matchers[199] = new Mx.Optional(this, 199, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 200 SeqOp            */ __Matchers[200] = new Mx.Seq(this, 200, "_200:(?(>variance),>name,?(>type-default))") { Builder = nodes => new CGenericParameter(nodes) };
                /* 201 SeqOp            */ __Matchers[201] = new Mx.Seq(this, 201, "_201:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 202 StringOp         */ __Matchers[202] = new Mx.Keyword(this, 202, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 203 StringOp         */ __Matchers[203] = new Mx.Keyword(this, 203, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 204 AltOp            */ __Matchers[204] = new Mx.Alt(this, 204, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 205 StarOp           */ __Matchers[205] = new Mx.Star(this, 205, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 206 AltOp            */ __Matchers[206] = new Mx.Alt(this, 206, "alt(>function-declaration|>attribute-declaration|>class-declaration|>interface-declaration|>object-declaration|>alias-declaration|>constructor-declaration)") { Builder = nodes => nodes[0] };
                /* 207 StringOp         */ __Matchers[207] = new Mx.Keyword(this, 207, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 208 OptionalOp       */ __Matchers[208] = new Mx.Optional(this, 208, "?(>generic-parameters)") { Builder = nodes => new ROptional<CGenericParameters>(nodes) };
                /* 209 OptionalOp       */ __Matchers[209] = new Mx.Optional(this, 209, "?(>constraints)") { Builder = nodes => new ROptional<CConstraints>(nodes) };
                /* 210 SeqOp            */ __Matchers[210] = new Mx.Seq(this, 210, "_210:(>prelude,'function',>type,>name,?(>generic-parameters),>multi-parameters,?(>constraints),>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 211 StringOp         */ __Matchers[211] = new Mx.Keyword(this, 211, "'value'", "value") { Creator = node => new RLiteral(node) };
                /* 212 OptionalOp       */ __Matchers[212] = new Mx.Optional(this, 212, "?(>type)") { Builder = nodes => new ROptional<ICType>(nodes) };
                /* 213 SeqOp            */ __Matchers[213] = new Mx.Seq(this, 213, "_213:(>prelude,'value',?(>type),>name,>attribute-body)") { Builder = nodes => new CAttributeDeclaration(nodes) };
                /* 214 StringOp         */ __Matchers[214] = new Mx.Keyword(this, 214, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 215 OptionalOp       */ __Matchers[215] = new Mx.Optional(this, 215, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 216 OptionalOp       */ __Matchers[216] = new Mx.Optional(this, 216, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 217 OptionalOp       */ __Matchers[217] = new Mx.Optional(this, 217, "?(>satisfies)") { Builder = nodes => new ROptional<CSatisfies>(nodes) };
                /* 218 OptionalOp       */ __Matchers[218] = new Mx.Optional(this, 218, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 219 SeqOp            */ __Matchers[219] = new Mx.Seq(this, 219, "_219:(>prelude,'class',>name,?(>generic-parameters),?(>parameters),?(>extends),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 220 StringOp         */ __Matchers[220] = new Mx.Keyword(this, 220, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 221 SeqOp            */ __Matchers[221] = new Mx.Seq(this, 221, "_221:(>prelude,'interface',>name,?(>generic-parameters),?(>parameters),?(>satisfies),?(>case-types),?(>constraints),>block-body)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 222 StringOp         */ __Matchers[222] = new Mx.Keyword(this, 222, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 223 SeqOp            */ __Matchers[223] = new Mx.Seq(this, 223, "_223:(>prelude,'object',>name,?(>extends),?(>satisfies),>block-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 224 StringOp         */ __Matchers[224] = new Mx.Keyword(this, 224, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 225 StringOp         */ __Matchers[225] = new Mx.String(this, 225, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 226 SeqOp            */ __Matchers[226] = new Mx.Seq(this, 226, "_226:(>prelude,'alias',>name,?(>generic-parameters),?(>constraints),'=>',>type,';')") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 227 StringOp         */ __Matchers[227] = new Mx.Keyword(this, 227, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 228 OptionalOp       */ __Matchers[228] = new Mx.Optional(this, 228, "?(>name)") { Builder = nodes => new ROptional<ICName>(nodes) };
                /* 229 SeqOp            */ __Matchers[229] = new Mx.Seq(this, 229, "_229:(>prelude,'new',?(>name),?(>extends),>function-body)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 230 AltOp            */ __Matchers[230] = new Mx.Alt(this, 230, "alt(>expression-body|>block-body|>null-body)") { Builder = nodes => nodes[0] };
                /* 231 SeqOp            */ __Matchers[231] = new Mx.Seq(this, 231, "_231:('{',>usings,>statelarations,'}')") { Builder = nodes => new CBlockBody(nodes) };
                /* 232 StarOp           */ __Matchers[232] = new Mx.Star(this, 232, "*(>statelaration)") { Builder = nodes => new CStatelarations(nodes) };
                /* 233 AltOp            */ __Matchers[233] = new Mx.Alt(this, 233, "alt(>statement|>declaration)") { Builder = nodes => nodes[0] };
                /* 234 SeqOp            */ __Matchers[234] = new Mx.Seq(this, 234, "_234:(>function-specifier,';')") { Builder = nodes => new CExpressionBody(nodes) };
                /* 235 SeqOp            */ __Matchers[235] = new Mx.Seq(this, 235, "_235:(';')") { Builder = nodes => new CNullBody(nodes) };
                /* 236 SeqOp            */ __Matchers[236] = new Mx.Seq(this, 236, "_236:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 237 StringOp         */ __Matchers[237] = new Mx.String(this, 237, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 238 SeqOp            */ __Matchers[238] = new Mx.Seq(this, 238, "_238:(':',>extend-type)") { Builder = nodes => new CExtends(nodes) };
                /* 239 AltOp            */ __Matchers[239] = new Mx.Alt(this, 239, "alt(>type|>constructor)") { Builder = nodes => nodes[0] };
                /* 240 SeqOp            */ __Matchers[240] = new Mx.Seq(this, 240, "_240:(>primary-type,>arguments)") { Builder = nodes => new CConstructor(nodes) };
                /* 241 StringOp         */ __Matchers[241] = new Mx.Keyword(this, 241, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 242 SeqOp            */ __Matchers[242] = new Mx.Seq(this, 242, "_242:('is',>union-type-list)") { Builder = nodes => new CSatisfies(nodes) };
                /* 243 PlusOp           */ __Matchers[243] = new Mx.Plus(this, 243, "+(>constraint)") { Builder = nodes => new CConstraints(nodes) };
                /* 244 StringOp         */ __Matchers[244] = new Mx.Keyword(this, 244, "'where'", "where") { Creator = node => new RLiteral(node) };
                /* 245 SeqOp            */ __Matchers[245] = new Mx.Seq(this, 245, "_245:('where',>name,?(>generic-parameters),?(>case-types),?(>satisfies))") { Builder = nodes => new CConstraint(nodes) };
                /* 246 SeqOp            */ __Matchers[246] = new Mx.Seq(this, 246, "_246:(',',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 247 StarOp           */ __Matchers[247] = new Mx.Star(this, 247, "*(_246:(',',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 248 SeqOp            */ __Matchers[248] = new Mx.Seq(this, 248, "_248:(>type,*(_246:(',',>type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 249 StringOp         */ __Matchers[249] = new Mx.Keyword(this, 249, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 250 SeqOp            */ __Matchers[250] = new Mx.Seq(this, 250, "_250:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 251 StringOp         */ __Matchers[251] = new Mx.String(this, 251, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 252 SeqOp            */ __Matchers[252] = new Mx.Seq(this, 252, "_252:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 253 StarOp           */ __Matchers[253] = new Mx.Star(this, 253, "*(_252:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 254 SeqOp            */ __Matchers[254] = new Mx.Seq(this, 254, "_254:(>type,*(_252:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 255 SeqOp            */ __Matchers[255] = new Mx.Seq(this, 255, "_255:(>name)") { Builder = nodes => new CNamePattern(nodes) };
                /* 256 OptionalOp       */ __Matchers[256] = new Mx.Optional(this, 256, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 257 StarOp           */ __Matchers[257] = new Mx.Star(this, 257, "*(>attribute)") { Builder = nodes => new RStar<CAttribute>(nodes) };
                /* 258 SeqOp            */ __Matchers[258] = new Mx.Seq(this, 258, "_258:(?(>string-literal),*(>attribute))") { Builder = nodes => new CPrelude(nodes) };
                /* 259 OptionalOp       */ __Matchers[259] = new Mx.Optional(this, 259, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 260 SeqOp            */ __Matchers[260] = new Mx.Seq(this, 260, "_260:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 261 StringOp         */ __Matchers[261] = new Mx.String(this, 261, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 262 OptionalOp       */ __Matchers[262] = new Mx.Optional(this, 262, "?(>attribute-argument-list)") { Builder = nodes => new ROptional<CAttributeArgumentList>(nodes) };
                /* 263 StringOp         */ __Matchers[263] = new Mx.String(this, 263, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 264 SeqOp            */ __Matchers[264] = new Mx.Seq(this, 264, "_264:('(',?(>attribute-argument-list),')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 265 SeqOp            */ __Matchers[265] = new Mx.Seq(this, 265, "_265:(',',>attribute-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 266 StarOp           */ __Matchers[266] = new Mx.Star(this, 266, "*(_265:(',',>attribute-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 267 SeqOp            */ __Matchers[267] = new Mx.Seq(this, 267, "_267:(>attribute-argument,*(_265:(',',>attribute-argument)))") { Builder = nodes => new CAttributeArgumentList(nodes) };
                /* 268 AltOp            */ __Matchers[268] = new Mx.Alt(this, 268, "alt(>string-literal|>meta-reference)") { Builder = nodes => nodes[0] };
                /* 269 AltOp            */ __Matchers[269] = new Mx.Alt(this, 269, "alt(>class-reference|>object-reference|>value-reference|>interface-reference|>function-reference)") { Builder = nodes => nodes[0] };
                /* 270 SeqOp            */ __Matchers[270] = new Mx.Seq(this, 270, "_270:('class',>names)") { Builder = nodes => new CClassReference(nodes) };
                /* 271 SeqOp            */ __Matchers[271] = new Mx.Seq(this, 271, "_271:('object',>names)") { Builder = nodes => new CObjectReference(nodes) };
                /* 272 SeqOp            */ __Matchers[272] = new Mx.Seq(this, 272, "_272:('value',>names)") { Builder = nodes => new CValueReference(nodes) };
                /* 273 SeqOp            */ __Matchers[273] = new Mx.Seq(this, 273, "_273:('interface',>names)") { Builder = nodes => new CInterfaceReference(nodes) };
                /* 274 SeqOp            */ __Matchers[274] = new Mx.Seq(this, 274, "_274:('function',>names)") { Builder = nodes => new CFunctionReference(nodes) };
                /* 275 AltOp            */ __Matchers[275] = new Mx.Alt(this, 275, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 276 StringOp         */ __Matchers[276] = new Mx.String(this, 276, "'->'", "->") { Creator = node => new RLiteral(node) };
                /* 277 SeqOp            */ __Matchers[277] = new Mx.Seq(this, 277, "_277:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 278 AltOp            */ __Matchers[278] = new Mx.Alt(this, 278, "alt(>variadic-type-zero|>variadic-type-one)") { Builder = nodes => nodes[0] };
                /* 279 StringOp         */ __Matchers[279] = new Mx.String(this, 279, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 280 SeqOp            */ __Matchers[280] = new Mx.Seq(this, 280, "_280:(>union-type,'*')") { Builder = nodes => new CVariadicTypeZero(nodes) };
                /* 281 StringOp         */ __Matchers[281] = new Mx.String(this, 281, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 282 SeqOp            */ __Matchers[282] = new Mx.Seq(this, 282, "_282:(>union-type,'+')") { Builder = nodes => new CVariadicTypeOne(nodes) };
                /* 283 SeqOp            */ __Matchers[283] = new Mx.Seq(this, 283, "_283:('|',>intersection-type)") { Builder = nodes => new RSequence(nodes) };
                /* 284 StarOp           */ __Matchers[284] = new Mx.Star(this, 284, "*(_283:('|',>intersection-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 285 SeqOp            */ __Matchers[285] = new Mx.Seq(this, 285, "_285:(>intersection-type,*(_283:('|',>intersection-type)))") { Builder = nodes => new CUnionType(nodes) };
                /* 286 StringOp         */ __Matchers[286] = new Mx.String(this, 286, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 287 SeqOp            */ __Matchers[287] = new Mx.Seq(this, 287, "_287:('&',>primary-type)") { Builder = nodes => new RSequence(nodes) };
                /* 288 StarOp           */ __Matchers[288] = new Mx.Star(this, 288, "*(_287:('&',>primary-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 289 SeqOp            */ __Matchers[289] = new Mx.Seq(this, 289, "_289:(>primary-type,*(_287:('&',>primary-type)))") { Builder = nodes => new CIntersectionType(nodes) };
                /* 290 AltOp            */ __Matchers[290] = new Mx.Alt(this, 290, "alt(>nullable-type|>sequence-type|>reference|>type-selector|>callable-type|>empty-type|>tuple-type|>iterable-type)") { Builder = nodes => nodes[0] };
                /* 291 StringOp         */ __Matchers[291] = new Mx.String(this, 291, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 292 SeqOp            */ __Matchers[292] = new Mx.Seq(this, 292, "_292:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 293 StringOp         */ __Matchers[293] = new Mx.String(this, 293, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 294 StringOp         */ __Matchers[294] = new Mx.String(this, 294, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 295 SeqOp            */ __Matchers[295] = new Mx.Seq(this, 295, "_295:(>primary-type,'[',']')") { Builder = nodes => new CSequenceType(nodes) };
                /* 296 SeqOp            */ __Matchers[296] = new Mx.Seq(this, 296, "_296:(>primary-type,'.',>reference)") { Builder = nodes => new CTypeSelector(nodes) };
                /* 297 OptionalOp       */ __Matchers[297] = new Mx.Optional(this, 297, "?(>callable-arguments)") { Builder = nodes => new ROptional<ICCallableArguments>(nodes) };
                /* 298 SeqOp            */ __Matchers[298] = new Mx.Seq(this, 298, "_298:(>primary-type,'(',?(>callable-arguments),')')") { Builder = nodes => new CCallableType(nodes) };
                /* 299 AltOp            */ __Matchers[299] = new Mx.Alt(this, 299, "alt(>type-list|>spread-type)") { Builder = nodes => nodes[0] };
                /* 300 SeqOp            */ __Matchers[300] = new Mx.Seq(this, 300, "_300:(',',>type-list-type)") { Builder = nodes => new RSequence(nodes) };
                /* 301 StarOp           */ __Matchers[301] = new Mx.Star(this, 301, "*(_300:(',',>type-list-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 302 SeqOp            */ __Matchers[302] = new Mx.Seq(this, 302, "_302:(>type-list-type,*(_300:(',',>type-list-type)))") { Builder = nodes => new CTypeList(nodes) };
                /* 303 AltOp            */ __Matchers[303] = new Mx.Alt(this, 303, "alt(>type|>defaulted-type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 304 SeqOp            */ __Matchers[304] = new Mx.Seq(this, 304, "_304:(>type,'=')") { Builder = nodes => new CDefaultedType(nodes) };
                /* 305 SeqOp            */ __Matchers[305] = new Mx.Seq(this, 305, "_305:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 306 SeqOp            */ __Matchers[306] = new Mx.Seq(this, 306, "_306:('[',']')") { Builder = nodes => new CEmptyType(nodes) };
                /* 307 SeqOp            */ __Matchers[307] = new Mx.Seq(this, 307, "_307:('[',>type-list,']')") { Builder = nodes => new CTupleType(nodes) };
                /* 308 SeqOp            */ __Matchers[308] = new Mx.Seq(this, 308, "_308:('{',>variadic-type,'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 309 PlusOp           */ __Matchers[309] = new Mx.Plus(this, 309, "+(>parameters)") { Builder = nodes => new CMultiParameters(nodes) };
                /* 310 OptionalOp       */ __Matchers[310] = new Mx.Optional(this, 310, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 311 SeqOp            */ __Matchers[311] = new Mx.Seq(this, 311, "_311:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 312 SeqOp            */ __Matchers[312] = new Mx.Seq(this, 312, "_312:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 313 StarOp           */ __Matchers[313] = new Mx.Star(this, 313, "*(_312:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 314 SeqOp            */ __Matchers[314] = new Mx.Seq(this, 314, "_314:(>parameter,*(_312:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 315 SeqOp            */ __Matchers[315] = new Mx.Seq(this, 315, "_315:(>prelude,>parameter-type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 316 AltOp            */ __Matchers[316] = new Mx.Alt(this, 316, "alt(>type|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 317 OptionalOp       */ __Matchers[317] = new Mx.Optional(this, 317, "?(>argument-list)") { Builder = nodes => new ROptional<CArgumentList>(nodes) };
                /* 318 SeqOp            */ __Matchers[318] = new Mx.Seq(this, 318, "_318:('(',?(>argument-list),')')") { Builder = nodes => new CArguments(nodes) };
                /* 319 SeqOp            */ __Matchers[319] = new Mx.Seq(this, 319, "_319:(',',>argument)") { Builder = nodes => new RSequence(nodes) };
                /* 320 StarOp           */ __Matchers[320] = new Mx.Star(this, 320, "*(_319:(',',>argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 321 SeqOp            */ __Matchers[321] = new Mx.Seq(this, 321, "_321:(>argument,*(_319:(',',>argument)))") { Builder = nodes => new CArgumentList(nodes) };
                /* 322 AltOp            */ __Matchers[322] = new Mx.Alt(this, 322, "alt(>if-statement|>for-statement|>return-statement|>assert-statement)") { Builder = nodes => nodes[0] };
                /* 323 StringOp         */ __Matchers[323] = new Mx.Keyword(this, 323, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 324 StarOp           */ __Matchers[324] = new Mx.Star(this, 324, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 325 OptionalOp       */ __Matchers[325] = new Mx.Optional(this, 325, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 326 SeqOp            */ __Matchers[326] = new Mx.Seq(this, 326, "_326:('if',>conditions,>block-body,*(>else-if),?(>else-block))") { Builder = nodes => new CIfStatement(nodes) };
                /* 327 StringOp         */ __Matchers[327] = new Mx.Keyword(this, 327, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 328 SeqOp            */ __Matchers[328] = new Mx.Seq(this, 328, "_328:('else','if',>conditions,>block-body)") { Builder = nodes => new CElseIf(nodes) };
                /* 329 SeqOp            */ __Matchers[329] = new Mx.Seq(this, 329, "_329:('else',>block-body)") { Builder = nodes => new CElseBlock(nodes) };
                /* 330 StringOp         */ __Matchers[330] = new Mx.Keyword(this, 330, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 331 SeqOp            */ __Matchers[331] = new Mx.Seq(this, 331, "_331:('for','(',>pattern,'in',>expression,')',>block-body)") { Builder = nodes => new CForStatement(nodes) };
                /* 332 StringOp         */ __Matchers[332] = new Mx.Keyword(this, 332, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 333 OptionalOp       */ __Matchers[333] = new Mx.Optional(this, 333, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 334 SeqOp            */ __Matchers[334] = new Mx.Seq(this, 334, "_334:('return',?(>expression),';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 335 StringOp         */ __Matchers[335] = new Mx.Keyword(this, 335, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 336 SeqOp            */ __Matchers[336] = new Mx.Seq(this, 336, "_336:(?(>string-literal),'assert',>arguments,';')") { Builder = nodes => new CAssertStatement(nodes) };
                /* 337 AltOp            */ __Matchers[337] = new Mx.Alt(this, 337, "alt(>level-coalesce-expression|>if-expression)") { Builder = nodes => nodes[0] };
                /* 338 AltOp            */ __Matchers[338] = new Mx.Alt(this, 338, "alt(>then-expression|>else-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 339 StringOp         */ __Matchers[339] = new Mx.Keyword(this, 339, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 340 SeqOp            */ __Matchers[340] = new Mx.Seq(this, 340, "_340:(>level-coalesce-expression,'then',>level-disjunction-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 341 SeqOp            */ __Matchers[341] = new Mx.Seq(this, 341, "_341:(>level-coalesce-expression,'else',>level-disjunction-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 342 AltOp            */ __Matchers[342] = new Mx.Alt(this, 342, "alt(>disjunction-expression|>level-conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 343 StringOp         */ __Matchers[343] = new Mx.String(this, 343, "'||'", "||") { Creator = node => new RLiteral(node) };
                /* 344 SeqOp            */ __Matchers[344] = new Mx.Seq(this, 344, "_344:(>level-disjunction-expression,'||',>level-conjunction-expression)") { Builder = nodes => new CDisjunctionExpression(nodes) };
                /* 345 AltOp            */ __Matchers[345] = new Mx.Alt(this, 345, "alt(>conjunction-expression|>level-not-expression)") { Builder = nodes => nodes[0] };
                /* 346 StringOp         */ __Matchers[346] = new Mx.String(this, 346, "'&&'", "&&") { Creator = node => new RLiteral(node) };
                /* 347 SeqOp            */ __Matchers[347] = new Mx.Seq(this, 347, "_347:(>level-conjunction-expression,'&&',>level-not-expression)") { Builder = nodes => new CConjunctionExpression(nodes) };
                /* 348 AltOp            */ __Matchers[348] = new Mx.Alt(this, 348, "alt(>not-expression|>level-equality-expression)") { Builder = nodes => nodes[0] };
                /* 349 StringOp         */ __Matchers[349] = new Mx.String(this, 349, "'!'", "!") { Creator = node => new RLiteral(node) };
                /* 350 SeqOp            */ __Matchers[350] = new Mx.Seq(this, 350, "_350:('!',>level-not-expression)") { Builder = nodes => new CNotExpression(nodes) };
                /* 351 AltOp            */ __Matchers[351] = new Mx.Alt(this, 351, "alt(>equal-expression|>not-equal-expression|>identical-expression|>not-identical-expression|>level-compare-expression)") { Builder = nodes => nodes[0] };
                /* 352 StringOp         */ __Matchers[352] = new Mx.String(this, 352, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 353 SeqOp            */ __Matchers[353] = new Mx.Seq(this, 353, "_353:(>level-compare-expression,'==',>level-compare-expression)") { Builder = nodes => new CEqualExpression(nodes) };
                /* 354 StringOp         */ __Matchers[354] = new Mx.String(this, 354, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 355 SeqOp            */ __Matchers[355] = new Mx.Seq(this, 355, "_355:(>level-compare-expression,'!=',>level-compare-expression)") { Builder = nodes => new CNotEqualExpression(nodes) };
                /* 356 StringOp         */ __Matchers[356] = new Mx.String(this, 356, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 357 SeqOp            */ __Matchers[357] = new Mx.Seq(this, 357, "_357:(>level-compare-expression,'===',>level-compare-expression)") { Builder = nodes => new CIdenticalExpression(nodes) };
                /* 358 StringOp         */ __Matchers[358] = new Mx.String(this, 358, "'!=='", "!==") { Creator = node => new RLiteral(node) };
                /* 359 SeqOp            */ __Matchers[359] = new Mx.Seq(this, 359, "_359:(>level-compare-expression,'!==',>level-compare-expression)") { Builder = nodes => new CNotIdenticalExpression(nodes) };
                /* 360 AltOp            */ __Matchers[360] = new Mx.Alt(this, 360, "alt(>lt-expression|>le-expression|>gt-expression|>ge-expression|>level-add-expression)") { Builder = nodes => nodes[0] };
                /* 361 SeqOp            */ __Matchers[361] = new Mx.Seq(this, 361, "_361:(>level-add-expression,'<',>level-add-expression)") { Builder = nodes => new CLtExpression(nodes) };
                /* 362 StringOp         */ __Matchers[362] = new Mx.String(this, 362, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 363 SeqOp            */ __Matchers[363] = new Mx.Seq(this, 363, "_363:(>level-add-expression,'<=',>level-add-expression)") { Builder = nodes => new CLeExpression(nodes) };
                /* 364 SeqOp            */ __Matchers[364] = new Mx.Seq(this, 364, "_364:(>level-add-expression,'>',>level-add-expression)") { Builder = nodes => new CGtExpression(nodes) };
                /* 365 StringOp         */ __Matchers[365] = new Mx.String(this, 365, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 366 SeqOp            */ __Matchers[366] = new Mx.Seq(this, 366, "_366:(>level-add-expression,'>=',>level-add-expression)") { Builder = nodes => new CGeExpression(nodes) };
                /* 367 AltOp            */ __Matchers[367] = new Mx.Alt(this, 367, "alt(>add-expression|>sub-expression|>level-mul-expression)") { Builder = nodes => nodes[0] };
                /* 368 SeqOp            */ __Matchers[368] = new Mx.Seq(this, 368, "_368:(>level-add-expression,'+',>level-mul-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 369 StringOp         */ __Matchers[369] = new Mx.String(this, 369, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 370 SeqOp            */ __Matchers[370] = new Mx.Seq(this, 370, "_370:(>level-add-expression,'-',>level-mul-expression)") { Builder = nodes => new CSubExpression(nodes) };
                /* 371 AltOp            */ __Matchers[371] = new Mx.Alt(this, 371, "alt(>mul-expression|>div-expression|>rem-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 372 SeqOp            */ __Matchers[372] = new Mx.Seq(this, 372, "_372:(>level-mul-expression,'*',>primary-expression)") { Builder = nodes => new CMulExpression(nodes) };
                /* 373 StringOp         */ __Matchers[373] = new Mx.String(this, 373, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 374 SeqOp            */ __Matchers[374] = new Mx.Seq(this, 374, "_374:(>level-mul-expression,'/',>primary-expression)") { Builder = nodes => new CDivExpression(nodes) };
                /* 375 StringOp         */ __Matchers[375] = new Mx.String(this, 375, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 376 SeqOp            */ __Matchers[376] = new Mx.Seq(this, 376, "_376:(>level-mul-expression,'%',>primary-expression)") { Builder = nodes => new CRemExpression(nodes) };
                /* 377 AltOp            */ __Matchers[377] = new Mx.Alt(this, 377, "alt(>reference|>literal|>call-expression|>select-expression)") { Builder = nodes => nodes[0] };
                /* 378 SeqOp            */ __Matchers[378] = new Mx.Seq(this, 378, "_378:(>primary-expression,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Mx.Seq(this, 379, "_379:(>primary-expression,'.',>reference)") { Builder = nodes => new CSelectExpression(nodes) };
                /* 380 AltOp            */ __Matchers[380] = new Mx.Alt(this, 380, "alt(>string-literal|>natural-literal)") { Builder = nodes => nodes[0] };
                /* 381 AltOp            */ __Matchers[381] = new Mx.Alt(this, 381, "alt(>plain-string-literal|>verbatim-string-literal)") { Builder = nodes => nodes[0] };
                /* 382 SeqOp            */ __Matchers[382] = new Mx.Seq(this, 382, "_382:('if',>conditions,>if-then,>if-else)") { Builder = nodes => new CIfExpression(nodes) };
                /* 383 SeqOp            */ __Matchers[383] = new Mx.Seq(this, 383, "_383:('then',>conditional-expression)") { Builder = nodes => new CIfThen(nodes) };
                /* 384 SeqOp            */ __Matchers[384] = new Mx.Seq(this, 384, "_384:('else',>conditional-expression)") { Builder = nodes => new CIfElse(nodes) };
                /* 385 AltOp            */ __Matchers[385] = new Mx.Alt(this, 385, "alt(>if-expression|>level-disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 386 SeqOp            */ __Matchers[386] = new Mx.Seq(this, 386, "_386:('(',>condition-list,')')") { Builder = nodes => new CConditions(nodes) };
                /* 387 SeqOp            */ __Matchers[387] = new Mx.Seq(this, 387, "_387:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 388 StarOp           */ __Matchers[388] = new Mx.Star(this, 388, "*(_387:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 389 SeqOp            */ __Matchers[389] = new Mx.Seq(this, 389, "_389:(>condition,*(_387:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[148]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[149]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[152]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[155]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[157]);
                /*   7 PlainRuleOp      */ _moduleBody.Set(__Matchers[161]);
                /*   8 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*   9 PlainRuleOp      */ _moduleImport.Set(__Matchers[163]);
                /*  10 PlainRuleOp      */ _usings.Set(__Matchers[164]);
                /*  11 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[166]);
                /*  12 PlainRuleOp      */ _usingElements.Set(__Matchers[168]);
                /*  13 PlainRuleOp      */ _usingElementList.Set(__Matchers[172]);
                /*  14 PlainRuleOp      */ _usingElement.Set(__Matchers[173]);
                /*  15 PlainRuleOp      */ _usingNamed.Set(__Matchers[176]);
                /*  16 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  17 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[178]);
                /*  18 PlainRuleOp      */ _usingWildcard.Set(__Matchers[179]);
                /*  19 PlainRuleOp      */ _name.Set(_identifier);
                /*  20 PlainRuleOp      */ _names.Set(__Matchers[183]);
                /*  21 PlainRuleOp      */ _reference.Set(__Matchers[185]);
                /*  22 PlainRuleOp      */ _genericArguments.Set(__Matchers[189]);
                /*  23 PlainRuleOp      */ _genericArgumentList.Set(__Matchers[192]);
                /*  24 PlainRuleOp      */ _genericArgument.Set(_type);
                /*  25 PlainRuleOp      */ _genericParameters.Set(__Matchers[194]);
                /*  26 PlainRuleOp      */ _genericParameterList.Set(__Matchers[197]);
                /*  27 PlainRuleOp      */ _genericParameter.Set(__Matchers[200]);
                /*  28 PlainRuleOp      */ _typeDefault.Set(__Matchers[201]);
                /*  29 PlainRuleOp      */ _variance.Set(__Matchers[204]);
                /*  30 PlainRuleOp      */ _declarations.Set(__Matchers[205]);
                /*  31 PlainRuleOp      */ _declaration.Set(__Matchers[206]);
                /*  32 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[210]);
                /*  33 PlainRuleOp      */ _attributeDeclaration.Set(__Matchers[213]);
                /*  34 PlainRuleOp      */ _classDeclaration.Set(__Matchers[219]);
                /*  35 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[221]);
                /*  36 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[223]);
                /*  37 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[226]);
                /*  38 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[229]);
                /*  39 PlainRuleOp      */ _functionBody.Set(__Matchers[230]);
                /*  40 PlainRuleOp      */ _attributeBody.Set(__Matchers[230]);
                /*  41 PlainRuleOp      */ _blockBody.Set(__Matchers[231]);
                /*  42 PlainRuleOp      */ _statelarations.Set(__Matchers[232]);
                /*  43 PlainRuleOp      */ _statelaration.Set(__Matchers[233]);
                /*  44 PlainRuleOp      */ _expressionBody.Set(__Matchers[234]);
                /*  45 PlainRuleOp      */ _nullBody.Set(__Matchers[235]);
                /*  46 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[236]);
                /*  47 PlainRuleOp      */ _extends.Set(__Matchers[238]);
                /*  48 PlainRuleOp      */ _extendType.Set(__Matchers[239]);
                /*  49 PlainRuleOp      */ _constructor.Set(__Matchers[240]);
                /*  50 PlainRuleOp      */ _satisfies.Set(__Matchers[242]);
                /*  51 PlainRuleOp      */ _constraints.Set(__Matchers[243]);
                /*  52 PlainRuleOp      */ _constraint.Set(__Matchers[245]);
                /*  53 PlainRuleOp      */ _unionTypeList.Set(__Matchers[248]);
                /*  54 PlainRuleOp      */ _caseTypes.Set(__Matchers[250]);
                /*  55 PlainRuleOp      */ _caseTypeList.Set(__Matchers[254]);
                /*  56 PlainRuleOp      */ _pattern.Set(_namePattern);
                /*  57 PlainRuleOp      */ _namePattern.Set(__Matchers[255]);
                /*  58 PlainRuleOp      */ _prelude.Set(__Matchers[258]);
                /*  59 PlainRuleOp      */ _attribute.Set(__Matchers[260]);
                /*  60 PlainRuleOp      */ _attributeArguments.Set(__Matchers[264]);
                /*  61 PlainRuleOp      */ _attributeArgumentList.Set(__Matchers[267]);
                /*  62 PlainRuleOp      */ _attributeArgument.Set(__Matchers[268]);
                /*  63 PlainRuleOp      */ _metaReference.Set(__Matchers[269]);
                /*  64 PlainRuleOp      */ _classReference.Set(__Matchers[270]);
                /*  65 PlainRuleOp      */ _objectReference.Set(__Matchers[271]);
                /*  66 PlainRuleOp      */ _valueReference.Set(__Matchers[272]);
                /*  67 PlainRuleOp      */ _interfaceReference.Set(__Matchers[273]);
                /*  68 PlainRuleOp      */ _functionReference.Set(__Matchers[274]);
                /*  69 PlainRuleOp      */ _type.Set(__Matchers[275]);
                /*  70 PlainRuleOp      */ _entryType.Set(__Matchers[277]);
                /*  71 PlainRuleOp      */ _variadicType.Set(__Matchers[278]);
                /*  72 PlainRuleOp      */ _variadicTypeZero.Set(__Matchers[280]);
                /*  73 PlainRuleOp      */ _variadicTypeOne.Set(__Matchers[282]);
                /*  74 PlainRuleOp      */ _unionType.Set(__Matchers[285]);
                /*  75 PlainRuleOp      */ _intersectionType.Set(__Matchers[289]);
                /*  76 PlainRuleOp      */ _primaryType.Set(__Matchers[290]);
                /*  77 PlainRuleOp      */ _nullableType.Set(__Matchers[292]);
                /*  78 PlainRuleOp      */ _sequenceType.Set(__Matchers[295]);
                /*  79 PlainRuleOp      */ _typeSelector.Set(__Matchers[296]);
                /*  80 PlainRuleOp      */ _callableType.Set(__Matchers[298]);
                /*  81 PlainRuleOp      */ _callableArguments.Set(__Matchers[299]);
                /*  82 PlainRuleOp      */ _typeList.Set(__Matchers[302]);
                /*  83 PlainRuleOp      */ _typeListType.Set(__Matchers[303]);
                /*  84 PlainRuleOp      */ _defaultedType.Set(__Matchers[304]);
                /*  85 PlainRuleOp      */ _spreadType.Set(__Matchers[305]);
                /*  86 PlainRuleOp      */ _emptyType.Set(__Matchers[306]);
                /*  87 PlainRuleOp      */ _tupleType.Set(__Matchers[307]);
                /*  88 PlainRuleOp      */ _iterableType.Set(__Matchers[308]);
                /*  89 PlainRuleOp      */ _multiParameters.Set(__Matchers[309]);
                /*  90 PlainRuleOp      */ _parameters.Set(__Matchers[311]);
                /*  91 PlainRuleOp      */ _parameterList.Set(__Matchers[314]);
                /*  92 PlainRuleOp      */ _parameter.Set(__Matchers[315]);
                /*  93 PlainRuleOp      */ _parameterType.Set(__Matchers[316]);
                /*  94 PlainRuleOp      */ _arguments.Set(__Matchers[318]);
                /*  95 PlainRuleOp      */ _argumentList.Set(__Matchers[321]);
                /*  96 PlainRuleOp      */ _argument.Set(_expression);
                /*  97 PlainRuleOp      */ _statement.Set(__Matchers[322]);
                /*  98 PlainRuleOp      */ _ifStatement.Set(__Matchers[326]);
                /*  99 PlainRuleOp      */ _elseIf.Set(__Matchers[328]);
                /* 100 PlainRuleOp      */ _elseBlock.Set(__Matchers[329]);
                /* 101 PlainRuleOp      */ _forStatement.Set(__Matchers[331]);
                /* 102 PlainRuleOp      */ _returnStatement.Set(__Matchers[334]);
                /* 103 PlainRuleOp      */ _assertStatement.Set(__Matchers[336]);
                /* 104 PlainRuleOp      */ _expression.Set(__Matchers[337]);
                /* 105 PlainRuleOp      */ _levelCoalesceExpression.Set(__Matchers[338]);
                /* 106 PlainRuleOp      */ _thenExpression.Set(__Matchers[340]);
                /* 107 PlainRuleOp      */ _elseExpression.Set(__Matchers[341]);
                /* 108 PlainRuleOp      */ _levelDisjunctionExpression.Set(__Matchers[342]);
                /* 109 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[344]);
                /* 110 PlainRuleOp      */ _levelConjunctionExpression.Set(__Matchers[345]);
                /* 111 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[347]);
                /* 112 PlainRuleOp      */ _levelNotExpression.Set(__Matchers[348]);
                /* 113 PlainRuleOp      */ _notExpression.Set(__Matchers[350]);
                /* 114 PlainRuleOp      */ _levelEqualityExpression.Set(__Matchers[351]);
                /* 115 PlainRuleOp      */ _equalExpression.Set(__Matchers[353]);
                /* 116 PlainRuleOp      */ _notEqualExpression.Set(__Matchers[355]);
                /* 117 PlainRuleOp      */ _identicalExpression.Set(__Matchers[357]);
                /* 118 PlainRuleOp      */ _notIdenticalExpression.Set(__Matchers[359]);
                /* 119 PlainRuleOp      */ _levelCompareExpression.Set(__Matchers[360]);
                /* 120 PlainRuleOp      */ _ltExpression.Set(__Matchers[361]);
                /* 121 PlainRuleOp      */ _leExpression.Set(__Matchers[363]);
                /* 122 PlainRuleOp      */ _gtExpression.Set(__Matchers[364]);
                /* 123 PlainRuleOp      */ _geExpression.Set(__Matchers[366]);
                /* 124 PlainRuleOp      */ _levelAddExpression.Set(__Matchers[367]);
                /* 125 PlainRuleOp      */ _addExpression.Set(__Matchers[368]);
                /* 126 PlainRuleOp      */ _subExpression.Set(__Matchers[370]);
                /* 127 PlainRuleOp      */ _levelMulExpression.Set(__Matchers[371]);
                /* 128 PlainRuleOp      */ _mulExpression.Set(__Matchers[372]);
                /* 129 PlainRuleOp      */ _divExpression.Set(__Matchers[374]);
                /* 130 PlainRuleOp      */ _remExpression.Set(__Matchers[376]);
                /* 131 PlainRuleOp      */ _primaryExpression.Set(__Matchers[377]);
                /* 132 PlainRuleOp      */ _callExpression.Set(__Matchers[378]);
                /* 133 PlainRuleOp      */ _selectExpression.Set(__Matchers[379]);
                /* 134 PlainRuleOp      */ _literal.Set(__Matchers[380]);
                /* 135 PlainRuleOp      */ _stringLiteral.Set(__Matchers[381]);
                /* 136 PlainRuleOp      */ _ifExpression.Set(__Matchers[382]);
                /* 137 PlainRuleOp      */ _ifThen.Set(__Matchers[383]);
                /* 138 PlainRuleOp      */ _ifElse.Set(__Matchers[384]);
                /* 139 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[385]);
                /* 140 PlainRuleOp      */ _conditions.Set(__Matchers[386]);
                /* 141 PlainRuleOp      */ _conditionList.Set(__Matchers[389]);
                /* 142 PlainRuleOp      */ _condition.Set(_expression);
                /* 143 DfaRuleOp        */ _naturalLiteral.Set(_naturalLiteral_DFA);
                /* 144 DfaRuleOp        */ _plainStringLiteral.Set(_plainStringLiteral_DFA);
                /* 145 DfaRuleOp        */ _verbatimStringLiteral.Set(_verbatimStringLiteral_DFA);
                /* 146 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 148 SeqOp            */ __Matchers[148].Set(_compilationUnit, __Matchers[147]);
                /* 149 AltOp            */ __Matchers[149].Set(_moduleDescriptor, _codeUnit);
                /* 151 OptionalOp       */ __Matchers[151].Set(__Matchers[150]);
                /* 152 SeqOp            */ __Matchers[152].Set(__Matchers[151], _namespace, _usings, _declarations);
                /* 155 SeqOp            */ __Matchers[155].Set(_prelude, __Matchers[153], _names, __Matchers[154]);
                /* 157 SeqOp            */ __Matchers[157].Set(__Matchers[156], _names, _moduleBody);
                /* 159 StarOp           */ __Matchers[159].Set(_moduleBodyElement);
                /* 161 SeqOp            */ __Matchers[161].Set(__Matchers[158], __Matchers[159], __Matchers[160]);
                /* 163 SeqOp            */ __Matchers[163].Set(__Matchers[162], _names, __Matchers[154]);
                /* 164 StarOp           */ __Matchers[164].Set(_usingDeclaration);
                /* 166 SeqOp            */ __Matchers[166].Set(__Matchers[165], _names, _usingElements);
                /* 167 OptionalOp       */ __Matchers[167].Set(_usingElementList);
                /* 168 SeqOp            */ __Matchers[168].Set(__Matchers[158], __Matchers[167], __Matchers[160]);
                /* 170 SeqOp            */ __Matchers[170].Set(__Matchers[169], _usingElement);
                /* 171 StarOp           */ __Matchers[171].Set(__Matchers[170]);
                /* 172 SeqOp            */ __Matchers[172].Set(_usingElement, __Matchers[171]);
                /* 173 AltOp            */ __Matchers[173].Set(_usingNamed, _usingWildcard);
                /* 174 OptionalOp       */ __Matchers[174].Set(_usingNameSpecifier);
                /* 175 OptionalOp       */ __Matchers[175].Set(_usingElements);
                /* 176 SeqOp            */ __Matchers[176].Set(_usingName, __Matchers[174], __Matchers[175]);
                /* 178 SeqOp            */ __Matchers[178].Set(__Matchers[177], _identifier);
                /* 181 SeqOp            */ __Matchers[181].Set(__Matchers[180], _name);
                /* 182 StarOp           */ __Matchers[182].Set(__Matchers[181]);
                /* 183 SeqOp            */ __Matchers[183].Set(_name, __Matchers[182]);
                /* 184 OptionalOp       */ __Matchers[184].Set(_genericArguments);
                /* 185 SeqOp            */ __Matchers[185].Set(_name, __Matchers[184]);
                /* 187 OptionalOp       */ __Matchers[187].Set(_genericArgumentList);
                /* 189 SeqOp            */ __Matchers[189].Set(__Matchers[186], __Matchers[187], __Matchers[188]);
                /* 190 SeqOp            */ __Matchers[190].Set(__Matchers[169], _genericArgument);
                /* 191 StarOp           */ __Matchers[191].Set(__Matchers[190]);
                /* 192 SeqOp            */ __Matchers[192].Set(_genericArgument, __Matchers[191]);
                /* 193 OptionalOp       */ __Matchers[193].Set(_genericParameterList);
                /* 194 SeqOp            */ __Matchers[194].Set(__Matchers[186], __Matchers[193], __Matchers[188]);
                /* 195 SeqOp            */ __Matchers[195].Set(__Matchers[169], _genericParameter);
                /* 196 StarOp           */ __Matchers[196].Set(__Matchers[195]);
                /* 197 SeqOp            */ __Matchers[197].Set(_genericParameter, __Matchers[196]);
                /* 198 OptionalOp       */ __Matchers[198].Set(_variance);
                /* 199 OptionalOp       */ __Matchers[199].Set(_typeDefault);
                /* 200 SeqOp            */ __Matchers[200].Set(__Matchers[198], _name, __Matchers[199]);
                /* 201 SeqOp            */ __Matchers[201].Set(__Matchers[177], _type);
                /* 204 AltOp            */ __Matchers[204].Set(__Matchers[202], __Matchers[203]);
                /* 205 StarOp           */ __Matchers[205].Set(_declaration);
                /* 206 AltOp            */ __Matchers[206].Set(_functionDeclaration, _attributeDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _aliasDeclaration, _constructorDeclaration);
                /* 208 OptionalOp       */ __Matchers[208].Set(_genericParameters);
                /* 209 OptionalOp       */ __Matchers[209].Set(_constraints);
                /* 210 SeqOp            */ __Matchers[210].Set(_prelude, __Matchers[207], _type, _name, __Matchers[208], _multiParameters, __Matchers[209], _functionBody);
                /* 212 OptionalOp       */ __Matchers[212].Set(_type);
                /* 213 SeqOp            */ __Matchers[213].Set(_prelude, __Matchers[211], __Matchers[212], _name, _attributeBody);
                /* 215 OptionalOp       */ __Matchers[215].Set(_parameters);
                /* 216 OptionalOp       */ __Matchers[216].Set(_extends);
                /* 217 OptionalOp       */ __Matchers[217].Set(_satisfies);
                /* 218 OptionalOp       */ __Matchers[218].Set(_caseTypes);
                /* 219 SeqOp            */ __Matchers[219].Set(_prelude, __Matchers[214], _name, __Matchers[208], __Matchers[215], __Matchers[216], __Matchers[217], __Matchers[218], __Matchers[209], _blockBody);
                /* 221 SeqOp            */ __Matchers[221].Set(_prelude, __Matchers[220], _name, __Matchers[208], __Matchers[215], __Matchers[217], __Matchers[218], __Matchers[209], _blockBody);
                /* 223 SeqOp            */ __Matchers[223].Set(_prelude, __Matchers[222], _name, __Matchers[216], __Matchers[217], _blockBody);
                /* 226 SeqOp            */ __Matchers[226].Set(_prelude, __Matchers[224], _name, __Matchers[208], __Matchers[209], __Matchers[225], _type, __Matchers[154]);
                /* 228 OptionalOp       */ __Matchers[228].Set(_name);
                /* 229 SeqOp            */ __Matchers[229].Set(_prelude, __Matchers[227], __Matchers[228], __Matchers[216], _functionBody);
                /* 230 AltOp            */ __Matchers[230].Set(_expressionBody, _blockBody, _nullBody);
                /* 231 SeqOp            */ __Matchers[231].Set(__Matchers[158], _usings, _statelarations, __Matchers[160]);
                /* 232 StarOp           */ __Matchers[232].Set(_statelaration);
                /* 233 AltOp            */ __Matchers[233].Set(_statement, _declaration);
                /* 234 SeqOp            */ __Matchers[234].Set(_functionSpecifier, __Matchers[154]);
                /* 235 SeqOp            */ __Matchers[235].Set(__Matchers[154]);
                /* 236 SeqOp            */ __Matchers[236].Set(__Matchers[225], _expression);
                /* 238 SeqOp            */ __Matchers[238].Set(__Matchers[237], _extendType);
                /* 239 AltOp            */ __Matchers[239].Set(_type, _constructor);
                /* 240 SeqOp            */ __Matchers[240].Set(_primaryType, _arguments);
                /* 242 SeqOp            */ __Matchers[242].Set(__Matchers[241], _unionTypeList);
                /* 243 PlusOp           */ __Matchers[243].Set(_constraint);
                /* 245 SeqOp            */ __Matchers[245].Set(__Matchers[244], _name, __Matchers[208], __Matchers[218], __Matchers[217]);
                /* 246 SeqOp            */ __Matchers[246].Set(__Matchers[169], _type);
                /* 247 StarOp           */ __Matchers[247].Set(__Matchers[246]);
                /* 248 SeqOp            */ __Matchers[248].Set(_type, __Matchers[247]);
                /* 250 SeqOp            */ __Matchers[250].Set(__Matchers[249], _caseTypeList);
                /* 252 SeqOp            */ __Matchers[252].Set(__Matchers[251], _type);
                /* 253 StarOp           */ __Matchers[253].Set(__Matchers[252]);
                /* 254 SeqOp            */ __Matchers[254].Set(_type, __Matchers[253]);
                /* 255 SeqOp            */ __Matchers[255].Set(_name);
                /* 256 OptionalOp       */ __Matchers[256].Set(_stringLiteral);
                /* 257 StarOp           */ __Matchers[257].Set(_attribute);
                /* 258 SeqOp            */ __Matchers[258].Set(__Matchers[256], __Matchers[257]);
                /* 259 OptionalOp       */ __Matchers[259].Set(_attributeArguments);
                /* 260 SeqOp            */ __Matchers[260].Set(_name, __Matchers[259]);
                /* 262 OptionalOp       */ __Matchers[262].Set(_attributeArgumentList);
                /* 264 SeqOp            */ __Matchers[264].Set(__Matchers[261], __Matchers[262], __Matchers[263]);
                /* 265 SeqOp            */ __Matchers[265].Set(__Matchers[169], _attributeArgument);
                /* 266 StarOp           */ __Matchers[266].Set(__Matchers[265]);
                /* 267 SeqOp            */ __Matchers[267].Set(_attributeArgument, __Matchers[266]);
                /* 268 AltOp            */ __Matchers[268].Set(_stringLiteral, _metaReference);
                /* 269 AltOp            */ __Matchers[269].Set(_classReference, _objectReference, _valueReference, _interfaceReference, _functionReference);
                /* 270 SeqOp            */ __Matchers[270].Set(__Matchers[214], _names);
                /* 271 SeqOp            */ __Matchers[271].Set(__Matchers[222], _names);
                /* 272 SeqOp            */ __Matchers[272].Set(__Matchers[211], _names);
                /* 273 SeqOp            */ __Matchers[273].Set(__Matchers[220], _names);
                /* 274 SeqOp            */ __Matchers[274].Set(__Matchers[207], _names);
                /* 275 AltOp            */ __Matchers[275].Set(_entryType, _unionType);
                /* 277 SeqOp            */ __Matchers[277].Set(_unionType, __Matchers[276], _unionType);
                /* 278 AltOp            */ __Matchers[278].Set(_variadicTypeZero, _variadicTypeOne);
                /* 280 SeqOp            */ __Matchers[280].Set(_unionType, __Matchers[279]);
                /* 282 SeqOp            */ __Matchers[282].Set(_unionType, __Matchers[281]);
                /* 283 SeqOp            */ __Matchers[283].Set(__Matchers[251], _intersectionType);
                /* 284 StarOp           */ __Matchers[284].Set(__Matchers[283]);
                /* 285 SeqOp            */ __Matchers[285].Set(_intersectionType, __Matchers[284]);
                /* 287 SeqOp            */ __Matchers[287].Set(__Matchers[286], _primaryType);
                /* 288 StarOp           */ __Matchers[288].Set(__Matchers[287]);
                /* 289 SeqOp            */ __Matchers[289].Set(_primaryType, __Matchers[288]);
                /* 290 AltOp            */ __Matchers[290].Set(_nullableType, _sequenceType, _reference, _typeSelector, _callableType, _emptyType, _tupleType, _iterableType);
                /* 292 SeqOp            */ __Matchers[292].Set(_primaryType, __Matchers[291]);
                /* 295 SeqOp            */ __Matchers[295].Set(_primaryType, __Matchers[293], __Matchers[294]);
                /* 296 SeqOp            */ __Matchers[296].Set(_primaryType, __Matchers[180], _reference);
                /* 297 OptionalOp       */ __Matchers[297].Set(_callableArguments);
                /* 298 SeqOp            */ __Matchers[298].Set(_primaryType, __Matchers[261], __Matchers[297], __Matchers[263]);
                /* 299 AltOp            */ __Matchers[299].Set(_typeList, _spreadType);
                /* 300 SeqOp            */ __Matchers[300].Set(__Matchers[169], _typeListType);
                /* 301 StarOp           */ __Matchers[301].Set(__Matchers[300]);
                /* 302 SeqOp            */ __Matchers[302].Set(_typeListType, __Matchers[301]);
                /* 303 AltOp            */ __Matchers[303].Set(_type, _defaultedType, _variadicType);
                /* 304 SeqOp            */ __Matchers[304].Set(_type, __Matchers[177]);
                /* 305 SeqOp            */ __Matchers[305].Set(__Matchers[279], _unionType);
                /* 306 SeqOp            */ __Matchers[306].Set(__Matchers[293], __Matchers[294]);
                /* 307 SeqOp            */ __Matchers[307].Set(__Matchers[293], _typeList, __Matchers[294]);
                /* 308 SeqOp            */ __Matchers[308].Set(__Matchers[158], _variadicType, __Matchers[160]);
                /* 309 PlusOp           */ __Matchers[309].Set(_parameters);
                /* 310 OptionalOp       */ __Matchers[310].Set(_parameterList);
                /* 311 SeqOp            */ __Matchers[311].Set(__Matchers[261], __Matchers[310], __Matchers[263]);
                /* 312 SeqOp            */ __Matchers[312].Set(__Matchers[169], _parameter);
                /* 313 StarOp           */ __Matchers[313].Set(__Matchers[312]);
                /* 314 SeqOp            */ __Matchers[314].Set(_parameter, __Matchers[313]);
                /* 315 SeqOp            */ __Matchers[315].Set(_prelude, _parameterType, _name);
                /* 316 AltOp            */ __Matchers[316].Set(_type, _variadicType);
                /* 317 OptionalOp       */ __Matchers[317].Set(_argumentList);
                /* 318 SeqOp            */ __Matchers[318].Set(__Matchers[261], __Matchers[317], __Matchers[263]);
                /* 319 SeqOp            */ __Matchers[319].Set(__Matchers[169], _argument);
                /* 320 StarOp           */ __Matchers[320].Set(__Matchers[319]);
                /* 321 SeqOp            */ __Matchers[321].Set(_argument, __Matchers[320]);
                /* 322 AltOp            */ __Matchers[322].Set(_ifStatement, _forStatement, _returnStatement, _assertStatement);
                /* 324 StarOp           */ __Matchers[324].Set(_elseIf);
                /* 325 OptionalOp       */ __Matchers[325].Set(_elseBlock);
                /* 326 SeqOp            */ __Matchers[326].Set(__Matchers[323], _conditions, _blockBody, __Matchers[324], __Matchers[325]);
                /* 328 SeqOp            */ __Matchers[328].Set(__Matchers[327], __Matchers[323], _conditions, _blockBody);
                /* 329 SeqOp            */ __Matchers[329].Set(__Matchers[327], _blockBody);
                /* 331 SeqOp            */ __Matchers[331].Set(__Matchers[330], __Matchers[261], _pattern, __Matchers[202], _expression, __Matchers[263], _blockBody);
                /* 333 OptionalOp       */ __Matchers[333].Set(_expression);
                /* 334 SeqOp            */ __Matchers[334].Set(__Matchers[332], __Matchers[333], __Matchers[154]);
                /* 336 SeqOp            */ __Matchers[336].Set(__Matchers[256], __Matchers[335], _arguments, __Matchers[154]);
                /* 337 AltOp            */ __Matchers[337].Set(_levelCoalesceExpression, _ifExpression);
                /* 338 AltOp            */ __Matchers[338].Set(_thenExpression, _elseExpression, _levelDisjunctionExpression);
                /* 340 SeqOp            */ __Matchers[340].Set(_levelCoalesceExpression, __Matchers[339], _levelDisjunctionExpression);
                /* 341 SeqOp            */ __Matchers[341].Set(_levelCoalesceExpression, __Matchers[327], _levelDisjunctionExpression);
                /* 342 AltOp            */ __Matchers[342].Set(_disjunctionExpression, _levelConjunctionExpression);
                /* 344 SeqOp            */ __Matchers[344].Set(_levelDisjunctionExpression, __Matchers[343], _levelConjunctionExpression);
                /* 345 AltOp            */ __Matchers[345].Set(_conjunctionExpression, _levelNotExpression);
                /* 347 SeqOp            */ __Matchers[347].Set(_levelConjunctionExpression, __Matchers[346], _levelNotExpression);
                /* 348 AltOp            */ __Matchers[348].Set(_notExpression, _levelEqualityExpression);
                /* 350 SeqOp            */ __Matchers[350].Set(__Matchers[349], _levelNotExpression);
                /* 351 AltOp            */ __Matchers[351].Set(_equalExpression, _notEqualExpression, _identicalExpression, _notIdenticalExpression, _levelCompareExpression);
                /* 353 SeqOp            */ __Matchers[353].Set(_levelCompareExpression, __Matchers[352], _levelCompareExpression);
                /* 355 SeqOp            */ __Matchers[355].Set(_levelCompareExpression, __Matchers[354], _levelCompareExpression);
                /* 357 SeqOp            */ __Matchers[357].Set(_levelCompareExpression, __Matchers[356], _levelCompareExpression);
                /* 359 SeqOp            */ __Matchers[359].Set(_levelCompareExpression, __Matchers[358], _levelCompareExpression);
                /* 360 AltOp            */ __Matchers[360].Set(_ltExpression, _leExpression, _gtExpression, _geExpression, _levelAddExpression);
                /* 361 SeqOp            */ __Matchers[361].Set(_levelAddExpression, __Matchers[186], _levelAddExpression);
                /* 363 SeqOp            */ __Matchers[363].Set(_levelAddExpression, __Matchers[362], _levelAddExpression);
                /* 364 SeqOp            */ __Matchers[364].Set(_levelAddExpression, __Matchers[188], _levelAddExpression);
                /* 366 SeqOp            */ __Matchers[366].Set(_levelAddExpression, __Matchers[365], _levelAddExpression);
                /* 367 AltOp            */ __Matchers[367].Set(_addExpression, _subExpression, _levelMulExpression);
                /* 368 SeqOp            */ __Matchers[368].Set(_levelAddExpression, __Matchers[281], _levelMulExpression);
                /* 370 SeqOp            */ __Matchers[370].Set(_levelAddExpression, __Matchers[369], _levelMulExpression);
                /* 371 AltOp            */ __Matchers[371].Set(_mulExpression, _divExpression, _remExpression, _primaryExpression);
                /* 372 SeqOp            */ __Matchers[372].Set(_levelMulExpression, __Matchers[279], _primaryExpression);
                /* 374 SeqOp            */ __Matchers[374].Set(_levelMulExpression, __Matchers[373], _primaryExpression);
                /* 376 SeqOp            */ __Matchers[376].Set(_levelMulExpression, __Matchers[375], _primaryExpression);
                /* 377 AltOp            */ __Matchers[377].Set(_reference, _literal, _callExpression, _selectExpression);
                /* 378 SeqOp            */ __Matchers[378].Set(_primaryExpression, _arguments);
                /* 379 SeqOp            */ __Matchers[379].Set(_primaryExpression, __Matchers[180], _reference);
                /* 380 AltOp            */ __Matchers[380].Set(_stringLiteral, _naturalLiteral);
                /* 381 AltOp            */ __Matchers[381].Set(_plainStringLiteral, _verbatimStringLiteral);
                /* 382 SeqOp            */ __Matchers[382].Set(__Matchers[323], _conditions, _ifThen, _ifElse);
                /* 383 SeqOp            */ __Matchers[383].Set(__Matchers[339], _conditionalExpression);
                /* 384 SeqOp            */ __Matchers[384].Set(__Matchers[327], _conditionalExpression);
                /* 385 AltOp            */ __Matchers[385].Set(_ifExpression, _levelDisjunctionExpression);
                /* 386 SeqOp            */ __Matchers[386].Set(__Matchers[261], _conditionList, __Matchers[263]);
                /* 387 SeqOp            */ __Matchers[387].Set(__Matchers[169], _condition);
                /* 388 StarOp           */ __Matchers[388].Set(__Matchers[387]);
                /* 389 SeqOp            */ __Matchers[389].Set(_condition, __Matchers[388]);

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
                    new DfaState(63, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 98), new DfaInterval(100, 100), new DfaInterval(103, 104), new DfaInterval(106, 108), new DfaInterval(112, 113), new DfaInterval(115, 115), new DfaInterval(120, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[11], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[14], new DfaInterval(101, 101)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[44], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[48], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[52], new DfaInterval(116, 116)),
                    new DfaTrans(_identifier_DFA.States[54], new DfaInterval(117, 117)),
                    new DfaTrans(_identifier_DFA.States[58], new DfaInterval(118, 118)),
                    new DfaTrans(_identifier_DFA.States[61], new DfaInterval(119, 119))
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
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[15].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[16].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[17].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 108), new DfaInterval(111, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(102, 102), new DfaInterval(115, 115)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(97, 97)),
                    new DfaTrans(_identifier_DFA.States[43], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[43].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(119, 119))
                );
                _identifier_DFA.States[44].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[45], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[45].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[46], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[46].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[47], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[47].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[48].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[49], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[49].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[50], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[50].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[51], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[51].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[52].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[53], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[53].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[54].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[55], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[55].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[56], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[56].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[57], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[57].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(103, 103))
                );
                _identifier_DFA.States[58].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[59], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[59].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[60], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[60].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[61].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[62], new DfaInterval(104, 104))
                );
                _identifier_DFA.States[62].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[63], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[63].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(114, 114))
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
            private readonly Mx.PlainRule _multiParameters;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _parameterType;
            private readonly Mx.PlainRule _arguments;
            private readonly Mx.PlainRule _argumentList;
            private readonly Mx.PlainRule _argument;
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
            private readonly Mx.PlainRule _ltExpression;
            private readonly Mx.PlainRule _leExpression;
            private readonly Mx.PlainRule _gtExpression;
            private readonly Mx.PlainRule _geExpression;
            private readonly Mx.PlainRule _levelAddExpression;
            private readonly Mx.PlainRule _addExpression;
            private readonly Mx.PlainRule _subExpression;
            private readonly Mx.PlainRule _levelMulExpression;
            private readonly Mx.PlainRule _mulExpression;
            private readonly Mx.PlainRule _divExpression;
            private readonly Mx.PlainRule _remExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.PlainRule _callExpression;
            private readonly Mx.PlainRule _selectExpression;
            private readonly Mx.PlainRule _literal;
            private readonly Mx.PlainRule _stringLiteral;
            private readonly Mx.PlainRule _ifExpression;
            private readonly Mx.PlainRule _ifThen;
            private readonly Mx.PlainRule _ifElse;
            private readonly Mx.PlainRule _conditionalExpression;
            private readonly Mx.PlainRule _conditions;
            private readonly Mx.PlainRule _conditionList;
            private readonly Mx.PlainRule _condition;
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
        public interface ICMultiParameters : IRNode {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICParameterType : IRNode {}
        public interface ICArguments : IRNode {}
        public interface ICArgumentList : IRNode {}
        public interface ICArgument : IRNode {}
        public interface ICStatement : ICStatelaration {}
        public interface ICIfStatement : ICStatement {}
        public interface ICElseIf : IRNode {}
        public interface ICElseBlock : IRNode {}
        public interface ICForStatement : ICStatement {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICAssertStatement : ICStatement {}
        public interface ICExpression : ICArgument, ICCondition {}
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
        public interface ICLtExpression : ICLevelCompareExpression {}
        public interface ICLeExpression : ICLevelCompareExpression {}
        public interface ICGtExpression : ICLevelCompareExpression {}
        public interface ICGeExpression : ICLevelCompareExpression {}
        public interface ICLevelAddExpression : ICLevelCompareExpression {}
        public interface ICAddExpression : ICLevelAddExpression {}
        public interface ICSubExpression : ICLevelAddExpression {}
        public interface ICLevelMulExpression : ICLevelAddExpression {}
        public interface ICMulExpression : ICLevelMulExpression {}
        public interface ICDivExpression : ICLevelMulExpression {}
        public interface ICRemExpression : ICLevelMulExpression {}
        public interface ICPrimaryExpression : ICLevelMulExpression {}
        public interface ICCallExpression : ICPrimaryExpression {}
        public interface ICSelectExpression : ICPrimaryExpression {}
        public interface ICLiteral : ICPrimaryExpression {}
        public interface ICStringLiteral : ICAttributeArgument, ICLiteral {}
        public interface ICIfExpression : ICConditionalExpression, ICExpression {}
        public interface ICIfThen : IRNode {}
        public interface ICIfElse : IRNode {}
        public interface ICConditionalExpression : IRNode {}
        public interface ICConditions : IRNode {}
        public interface ICConditionList : IRNode {}
        public interface ICCondition : IRNode {}
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

        public partial class CIterableType : RSequence, ICIterableType
        {
            // sequence
            public CIterableType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public ICVariadicType VariadicType => Get<ICVariadicType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
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
            public ICParameterType ParameterType => Get<ICParameterType>(1);
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

        public partial class CLtExpression : RSequence, ICLtExpression
        {
            // sequence
            public CLtExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<'
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CLeExpression : RSequence, ICLeExpression
        {
            // sequence
            public CLeExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '<='
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CGtExpression : RSequence, ICGtExpression
        {
            // sequence
            public CGtExpression(params RNode[] children) : base(children) {}

            public ICLevelAddExpression LevelAddExpression => Get<ICLevelAddExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '>'
            public ICLevelAddExpression LevelAddExpression2 => Get<ICLevelAddExpression>(2);
        }

        public partial class CGeExpression : RSequence, ICGeExpression
        {
            // sequence
            public CGeExpression(params RNode[] children) : base(children) {}

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
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CDivExpression : RSequence, ICDivExpression
        {
            // sequence
            public CDivExpression(params RNode[] children) : base(children) {}

            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '/'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CRemExpression : RSequence, ICRemExpression
        {
            // sequence
            public CRemExpression(params RNode[] children) : base(children) {}

            public ICLevelMulExpression LevelMulExpression => Get<ICLevelMulExpression>(0);
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

            protected virtual void Visit(CIterableType element)
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

            protected virtual void Visit(CLtExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLeExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGtExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGeExpression element)
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
