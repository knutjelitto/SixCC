// <generated from="D:\\Six\\Six.Ceylon\\Ceylon.six" at="24.01.2022 07:48:45" />

using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonParser : Parser
    {
        public CeylonParser()
            : base("Ceylon", new Implementation())
        {
        }

        private class Implementation : ImplementationCore
        {
            public Implementation()
                : base(new Matcher[878])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _unitElements = new PlainRule(this, 4, "unit-elements") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _importDeclarations = new PlainRule(this, 5, "import-declarations") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _moduleDescriptor = new PlainRule(this, 6, "module-descriptor") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _moduleSpecifier = new PlainRule(this, 7, "module-specifier") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _repository = new PlainRule(this, 8, "repository") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _module = new PlainRule(this, 9, "module") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _artifactAndClassifier = new PlainRule(this, 10, "artifact-and-classifier") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _artifact = new PlainRule(this, 11, "artifact") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _classifier = new PlainRule(this, 12, "classifier") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _version = new PlainRule(this, 13, "version") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _moduleName = new PlainRule(this, 14, "module-name") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _moduleBody = new PlainRule(this, 15, "module-body") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _moduleBodyElement = new PlainRule(this, 16, "module-body-element") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _packageDescriptor = new PlainRule(this, 17, "package-descriptor") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _importModule = new PlainRule(this, 18, "import-module") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _importDeclaration = new PlainRule(this, 19, "import-declaration") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _importElements = new PlainRule(this, 20, "import-elements") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _importElementList = new PlainRule(this, 21, "import-element-list") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _importElement = new PlainRule(this, 22, "import-element") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _importNamed = new PlainRule(this, 23, "import-named") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _importName = new PlainRule(this, 24, "import-name") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _importNameSpecifier = new PlainRule(this, 25, "import-name-specifier") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _importWildcard = new PlainRule(this, 26, "import-wildcard") { Creator = node => new CImportWildcard(node) };
                /*  27 PlainRuleOp      */ __Matchers[27] = _packageName = new PlainRule(this, 27, "package-name") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _packagePath = new PlainRule(this, 28, "package-path") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _memberName = new PlainRule(this, 29, "member-name") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _typeName = new PlainRule(this, 30, "type-name") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _pattern = new PlainRule(this, 31, "pattern") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _variableOrTuplePattern = new PlainRule(this, 32, "variable-or-tuple-pattern") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _tupleOrEntryPattern = new PlainRule(this, 33, "tuple-or-entry-pattern") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _entryPattern = new PlainRule(this, 34, "entry-pattern") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _tuplePattern = new PlainRule(this, 35, "tuple-pattern") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _variadicPatternList = new PlainRule(this, 36, "variadic-pattern-list") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _variadicPattern = new PlainRule(this, 37, "variadic-pattern") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _variablePattern = new PlainRule(this, 38, "variable-pattern") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _variadicVariable = new PlainRule(this, 39, "variadic-variable") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _letStatement = new PlainRule(this, 40, "let-statement") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _delegatedConstructor = new PlainRule(this, 41, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _assertionStatement = new PlainRule(this, 42, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _assertionMessage = new PlainRule(this, 43, "assertion-message") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _block = new PlainRule(this, 44, "block") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _interfaceBlock = new PlainRule(this, 45, "interface-block") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _classBlock = new PlainRule(this, 46, "class-block") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _blockElements = new PlainRule(this, 47, "block-elements") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _extendedType = new PlainRule(this, 48, "extended-type") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _classSpecifier = new PlainRule(this, 49, "class-specifier") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _classInstatiation = new PlainRule(this, 50, "class-instatiation") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _qualifiedClass = new PlainRule(this, 51, "qualified-class") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _superQualifiedClass = new PlainRule(this, 52, "super-qualified-class") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _packageQualifiedClass = new PlainRule(this, 53, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _packageQualifier = new PlainRule(this, 54, "package-qualifier") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _unQualifiedClass = new PlainRule(this, 55, "un-qualified-class") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _memberPath = new PlainRule(this, 56, "member-path") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _typePath = new PlainRule(this, 57, "type-path") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _satisfiedTypes = new PlainRule(this, 58, "satisfied-types") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _unionTypeList = new PlainRule(this, 59, "union-type-list") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _caseTypes = new PlainRule(this, 60, "case-types") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _caseTypeList = new PlainRule(this, 61, "case-type-list") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _caseType = new PlainRule(this, 62, "case-type") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _qualifiedCaseType = new PlainRule(this, 63, "qualified-case-type") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _parameters = new PlainRule(this, 64, "parameters") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _parameterList = new PlainRule(this, 65, "parameter-list") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _parameterDeclarationOrRefPattern = new PlainRule(this, 66, "parameter-declaration-or-ref-pattern") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _parameter = new PlainRule(this, 67, "parameter") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _parameterReference = new PlainRule(this, 68, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _parameterDeclaration = new PlainRule(this, 69, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _functionParameterDeclaration = new PlainRule(this, 70, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _functionParameterType = new PlainRule(this, 71, "function-parameter-type") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _valueParameterDeclaration = new PlainRule(this, 72, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _valueParameterType = new PlainRule(this, 73, "value-parameter-type") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _typeParameters = new PlainRule(this, 74, "type-parameters") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _typeParameterList = new PlainRule(this, 75, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _typeParameter = new PlainRule(this, 76, "type-parameter") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _variance = new PlainRule(this, 77, "variance") { Creator = node => new CVariance(node) };
                /*  78 PlainRuleOp      */ __Matchers[78] = _typeDefault = new PlainRule(this, 78, "type-default") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _typeConstraint = new PlainRule(this, 79, "type-constraint") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _typeConstraints = new PlainRule(this, 80, "type-constraints") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _declarationOrStatement = new PlainRule(this, 81, "declaration-or-statement") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _declaration = new PlainRule(this, 82, "declaration") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _constructorDeclaration = new PlainRule(this, 83, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _aliasDeclaration = new PlainRule(this, 84, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _enumeratedObjectDeclaration = new PlainRule(this, 85, "enumerated-object-declaration") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _objectDeclaration = new PlainRule(this, 86, "object-declaration") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _setterDeclaration = new PlainRule(this, 87, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _setterDefinition = new PlainRule(this, 88, "setter-definition") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _typedMethodDeclaration = new PlainRule(this, 89, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _voidMethodDeclaration = new PlainRule(this, 90, "void-method-declaration") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _inferredMethodDeclaration = new PlainRule(this, 91, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _typedAttributeDeclaration = new PlainRule(this, 92, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _inferredAttributeDeclaration = new PlainRule(this, 93, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _attributeDefinition = new PlainRule(this, 94, "attribute-definition") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _optionalAnySpecifier = new PlainRule(this, 95, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _classDeclaration = new PlainRule(this, 96, "class-declaration") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _classDefinition = new PlainRule(this, 97, "class-definition") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _optionalClassSpecifier = new PlainRule(this, 98, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _interfaceDeclaration = new PlainRule(this, 99, "interface-declaration") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _interfaceDefinition = new PlainRule(this, 100, "interface-definition") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _optionalTypeSpecifier = new PlainRule(this, 101, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _statement = new PlainRule(this, 102, "statement") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _unclosedStatement = new PlainRule(this, 103, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _openStatement = new PlainRule(this, 104, "open-statement") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _specificationStatement = new PlainRule(this, 105, "specification-statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _expressionStatement = new PlainRule(this, 106, "expression-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _directiveStatement = new PlainRule(this, 107, "directive-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _returnStatement = new PlainRule(this, 108, "return-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _throwStatement = new PlainRule(this, 109, "throw-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _breakStatement = new PlainRule(this, 110, "break-statement") { Creator = node => new CBreakStatement(node) };
                /* 111 PlainRuleOp      */ __Matchers[111] = _continueStatement = new PlainRule(this, 111, "continue-statement") { Creator = node => new CContinueStatement(node) };
                /* 112 PlainRuleOp      */ __Matchers[112] = _typeSpecifier = new PlainRule(this, 112, "type-specifier") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _valueSpecifier = new PlainRule(this, 113, "value-specifier") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _functionSpecifier = new PlainRule(this, 114, "function-specifier") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _anySpecifier = new PlainRule(this, 115, "any-specifier") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _baseReferenceOrParameterized = new PlainRule(this, 116, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _baseReference = new PlainRule(this, 117, "base-reference") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _parametrizedMember = new PlainRule(this, 118, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _selfParametrizedMember = new PlainRule(this, 119, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _memberReference = new PlainRule(this, 120, "member-reference") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _typeReference = new PlainRule(this, 121, "type-reference") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _selfReferenceSelector = new PlainRule(this, 122, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _selfReference = new PlainRule(this, 123, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 124 PlainRuleOp      */ __Matchers[124] = _enumerationExpr = new PlainRule(this, 124, "enumeration-expr") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _tupleExpr = new PlainRule(this, 125, "tuple-expr") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _arguments = new PlainRule(this, 126, "arguments") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _structuralArguments = new PlainRule(this, 127, "structural-arguments") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _namedOrAnonymous = new PlainRule(this, 128, "named-or-anonymous") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _namedArgument = new PlainRule(this, 129, "named-argument") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _anonymousArgument = new PlainRule(this, 130, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _namedSpecifiedArgument = new PlainRule(this, 131, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _sequencedArguments = new PlainRule(this, 132, "sequenced-arguments") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _sequencedArgument = new PlainRule(this, 133, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _namedArgumentDeclaration = new PlainRule(this, 134, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _objectArgument = new PlainRule(this, 135, "object-argument") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _typedMethodArgument = new PlainRule(this, 136, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _methodDefinition = new PlainRule(this, 137, "method-definition") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _optionalFunctionSpecifier = new PlainRule(this, 138, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _neededFunctionSpecifier = new PlainRule(this, 139, "needed-function-specifier") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _methodArgumentType = new PlainRule(this, 140, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _typedGetterArgument = new PlainRule(this, 141, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _getterArgumentType = new PlainRule(this, 142, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _inferredMethodArgument = new PlainRule(this, 143, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _inferredGetterArgument = new PlainRule(this, 144, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _untypedMethodArgument = new PlainRule(this, 145, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _untypedGetterArgument = new PlainRule(this, 146, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _positionalArguments = new PlainRule(this, 147, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _positionalArgument = new PlainRule(this, 148, "positional-argument") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _spreadArgument = new PlainRule(this, 149, "spread-argument") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _letExpr = new PlainRule(this, 150, "let-expr") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _letVariableList = new PlainRule(this, 151, "let-variable-list") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _letVariable = new PlainRule(this, 152, "let-variable") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _switchExpr = new PlainRule(this, 153, "switch-expr") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _caseExpressions = new PlainRule(this, 154, "case-expressions") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _caseExpression = new PlainRule(this, 155, "case-expression") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _ifExpr = new PlainRule(this, 156, "if-expr") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _elseExpression = new PlainRule(this, 157, "else-expression") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _thenExpression = new PlainRule(this, 158, "then-expression") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _conditionalExpression = new PlainRule(this, 159, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _functionExpr = new PlainRule(this, 160, "function-expr") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _functionExpressionType = new PlainRule(this, 161, "function-expression-type") { Creator = node => new CFunctionExpressionType(node) };
                /* 162 PlainRuleOp      */ __Matchers[162] = _functionParameters = new PlainRule(this, 162, "function-parameters") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _functionDefinition = new PlainRule(this, 163, "function-definition") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _comprehensionArgument = new PlainRule(this, 164, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _comprehensionClause = new PlainRule(this, 165, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _expressionComprehensionClause = new PlainRule(this, 166, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _forComprehensionClause = new PlainRule(this, 167, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _ifComprehensionClause = new PlainRule(this, 168, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _expression = new PlainRule(this, 169, "expression") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _operatorExpression = new PlainRule(this, 170, "operator-expression") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _assignmentExpression = new PlainRule(this, 171, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _assignmentExpr = new PlainRule(this, 172, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _assignmentOperator = new PlainRule(this, 173, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 174 PlainRuleOp      */ __Matchers[174] = _thenElseExpression = new PlainRule(this, 174, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _thenElseExpr = new PlainRule(this, 175, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _thenElseOperator = new PlainRule(this, 176, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 177 PlainRuleOp      */ __Matchers[177] = _disjunctionExpression = new PlainRule(this, 177, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _disjunctionExpr = new PlainRule(this, 178, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 179 PlainRuleOp      */ __Matchers[179] = _disjunctionOperator = new PlainRule(this, 179, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 180 PlainRuleOp      */ __Matchers[180] = _conjunctionExpression = new PlainRule(this, 180, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _conjunctionExpr = new PlainRule(this, 181, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _conjunctionOperator = new PlainRule(this, 182, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 183 PlainRuleOp      */ __Matchers[183] = _logicalNegationExpression = new PlainRule(this, 183, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _logicalNegationExpr = new PlainRule(this, 184, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _notOperator = new PlainRule(this, 185, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 186 PlainRuleOp      */ __Matchers[186] = _expressionOrMeta = new PlainRule(this, 186, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _equalityExpression = new PlainRule(this, 187, "equality-expression") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _equalityExpr = new PlainRule(this, 188, "equality-expr") { Builder = nodes => nodes[0] };
                /* 189 PlainRuleOp      */ __Matchers[189] = _equalityOperator = new PlainRule(this, 189, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 190 PlainRuleOp      */ __Matchers[190] = _comparisonExpression = new PlainRule(this, 190, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _comparisonExpr = new PlainRule(this, 191, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _largerExpr = new PlainRule(this, 192, "larger-expr") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _smallerExpr = new PlainRule(this, 193, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _largerBoundsExpr = new PlainRule(this, 194, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 195 PlainRuleOp      */ __Matchers[195] = _smallerBoundsExpr = new PlainRule(this, 195, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 196 PlainRuleOp      */ __Matchers[196] = _typecheckExpr = new PlainRule(this, 196, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _comparisonOperator = new PlainRule(this, 197, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 198 PlainRuleOp      */ __Matchers[198] = _smallerOperator = new PlainRule(this, 198, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 199 PlainRuleOp      */ __Matchers[199] = _largerOperator = new PlainRule(this, 199, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 200 PlainRuleOp      */ __Matchers[200] = _typeOperator = new PlainRule(this, 200, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 201 PlainRuleOp      */ __Matchers[201] = _existsNonemptyExpression = new PlainRule(this, 201, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 202 PlainRuleOp      */ __Matchers[202] = _existsExpr = new PlainRule(this, 202, "exists-expr") { Builder = nodes => nodes[0] };
                /* 203 PlainRuleOp      */ __Matchers[203] = _nonemptyExpr = new PlainRule(this, 203, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 204 PlainRuleOp      */ __Matchers[204] = _entryRangeExpression = new PlainRule(this, 204, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 205 PlainRuleOp      */ __Matchers[205] = _rangeExpr = new PlainRule(this, 205, "range-expr") { Builder = nodes => nodes[0] };
                /* 206 PlainRuleOp      */ __Matchers[206] = _entryExpr = new PlainRule(this, 206, "entry-expr") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _rangeOperator = new PlainRule(this, 207, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 208 PlainRuleOp      */ __Matchers[208] = _entryOperator = new PlainRule(this, 208, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 209 PlainRuleOp      */ __Matchers[209] = _additiveExpression = new PlainRule(this, 209, "additive-expression") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _additiveExpr = new PlainRule(this, 210, "additive-expr") { Builder = nodes => nodes[0] };
                /* 211 PlainRuleOp      */ __Matchers[211] = _additiveOperator = new PlainRule(this, 211, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 212 PlainRuleOp      */ __Matchers[212] = _scaleExpression = new PlainRule(this, 212, "scale-expression") { Builder = nodes => nodes[0] };
                /* 213 PlainRuleOp      */ __Matchers[213] = _scaleExpr = new PlainRule(this, 213, "scale-expr") { Builder = nodes => nodes[0] };
                /* 214 PlainRuleOp      */ __Matchers[214] = _scaleOperator = new PlainRule(this, 214, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 215 PlainRuleOp      */ __Matchers[215] = _multiplicativeExpression = new PlainRule(this, 215, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _multiplicativeExpr = new PlainRule(this, 216, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 217 PlainRuleOp      */ __Matchers[217] = _multiplicativeOperator = new PlainRule(this, 217, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 218 PlainRuleOp      */ __Matchers[218] = _unionExpression = new PlainRule(this, 218, "union-expression") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _unionExpr = new PlainRule(this, 219, "union-expr") { Builder = nodes => nodes[0] };
                /* 220 PlainRuleOp      */ __Matchers[220] = _unionOperator = new PlainRule(this, 220, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 221 PlainRuleOp      */ __Matchers[221] = _exclusiveExpression = new PlainRule(this, 221, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _exclusiveExpr = new PlainRule(this, 222, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 223 PlainRuleOp      */ __Matchers[223] = _exclusiveOperator = new PlainRule(this, 223, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 224 PlainRuleOp      */ __Matchers[224] = _intersectionExpression = new PlainRule(this, 224, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _intersectionExpr = new PlainRule(this, 225, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _intersectionOperator = new PlainRule(this, 226, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 227 PlainRuleOp      */ __Matchers[227] = _negationOrComplementExpression = new PlainRule(this, 227, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _negationOrComplementExpr = new PlainRule(this, 228, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 229 PlainRuleOp      */ __Matchers[229] = _unaryMinusOrComplementOperator = new PlainRule(this, 229, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _negateOperator = new PlainRule(this, 230, "negate-operator") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _neutralOperator = new PlainRule(this, 231, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _complementOperator = new PlainRule(this, 232, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 233 PlainRuleOp      */ __Matchers[233] = _prefixExpression = new PlainRule(this, 233, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _prefixExpr = new PlainRule(this, 234, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _postfixExpression = new PlainRule(this, 235, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _postfixExpr = new PlainRule(this, 236, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _incrementOperator = new PlainRule(this, 237, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 238 PlainRuleOp      */ __Matchers[238] = _primary = new PlainRule(this, 238, "primary") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _selectionExpr = new PlainRule(this, 239, "selection-expr") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _qualifiedReference = new PlainRule(this, 240, "qualified-reference") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _memberSelectionOperator = new PlainRule(this, 241, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 242 PlainRuleOp      */ __Matchers[242] = _indexedExpr = new PlainRule(this, 242, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _index = new PlainRule(this, 243, "index") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _upperSpanned = new PlainRule(this, 244, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _lowerSpanned = new PlainRule(this, 245, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _spanned = new PlainRule(this, 246, "spanned") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _measured = new PlainRule(this, 247, "measured") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _indexExpression = new PlainRule(this, 248, "index-expression") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _callExpr = new PlainRule(this, 249, "call-expr") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _baseExpression = new PlainRule(this, 250, "base-expression") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _nonstringLiteral = new PlainRule(this, 251, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _stringExpression = new PlainRule(this, 252, "string-expression") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _stringInterpolation = new PlainRule(this, 253, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _interpolationPart = new PlainRule(this, 254, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _stringLiteral = new PlainRule(this, 255, "string-literal") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _objectExpr = new PlainRule(this, 256, "object-expr") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _groupedExpr = new PlainRule(this, 257, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _typeArguments = new PlainRule(this, 258, "type-arguments") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _typeArgumentList = new PlainRule(this, 259, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _variancedType = new PlainRule(this, 260, "varianced-type") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _defaultedTypeList = new PlainRule(this, 261, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _defaultedType = new PlainRule(this, 262, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _defaultedTypeCore = new PlainRule(this, 263, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _variadicType = new PlainRule(this, 264, "variadic-type") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _variadicUnionType = new PlainRule(this, 265, "variadic-union-type") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _variadicOperator = new PlainRule(this, 266, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /* 267 PlainRuleOp      */ __Matchers[267] = _spreadType = new PlainRule(this, 267, "spread-type") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _type = new PlainRule(this, 268, "type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _entryType = new PlainRule(this, 269, "entry-type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _unionType = new PlainRule(this, 270, "union-type") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _unionTypeCore = new PlainRule(this, 271, "union-type-core") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _intersectionType = new PlainRule(this, 272, "intersection-type") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _intersectionTypeCore = new PlainRule(this, 273, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _primaryType = new PlainRule(this, 274, "primary-type") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _nullableType = new PlainRule(this, 275, "nullable-type") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _arrayType = new PlainRule(this, 276, "array-type") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _functionType = new PlainRule(this, 277, "function-type") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _typeTypeArguments = new PlainRule(this, 278, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _tupleType = new PlainRule(this, 279, "tuple-type") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _iterableType = new PlainRule(this, 280, "iterable-type") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _groupedType = new PlainRule(this, 281, "grouped-type") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _packageQualifiedType = new PlainRule(this, 282, "package-qualified-type") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _annotations = new PlainRule(this, 283, "annotations") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _annotation = new PlainRule(this, 284, "annotation") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _conditions = new PlainRule(this, 285, "conditions") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _conditionList = new PlainRule(this, 286, "condition-list") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _condition = new PlainRule(this, 287, "condition") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _existsCondition = new PlainRule(this, 288, "exists-condition") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _nonemptyCondition = new PlainRule(this, 289, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _letOrExpression = new PlainRule(this, 290, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _isCondition = new PlainRule(this, 291, "is-condition") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _isConditionVariable = new PlainRule(this, 292, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _satisfiesCondition = new PlainRule(this, 293, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _booleanCondition = new PlainRule(this, 294, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _controlStatement = new PlainRule(this, 295, "control-statement") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _ifElseStatement = new PlainRule(this, 296, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _ifBlock = new PlainRule(this, 297, "if-block") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _elseBlock = new PlainRule(this, 298, "else-block") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _elseBlockNext = new PlainRule(this, 299, "else-block-next") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _switchStatement = new PlainRule(this, 300, "switch-statement") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _switchHeader = new PlainRule(this, 301, "switch-header") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _switched = new PlainRule(this, 302, "switched") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _caseBlock = new PlainRule(this, 303, "case-block") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _caseItem = new PlainRule(this, 304, "case-item") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _isCaseCondition = new PlainRule(this, 305, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _satisfiesCaseCondition = new PlainRule(this, 306, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _matchCaseCondition = new PlainRule(this, 307, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _valueCaseList = new PlainRule(this, 308, "value-case-list") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _valueCaseSeparator = new PlainRule(this, 309, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 310 PlainRuleOp      */ __Matchers[310] = _valueCase = new PlainRule(this, 310, "value-case") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _forElseStatement = new PlainRule(this, 311, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _forBlock = new PlainRule(this, 312, "for-block") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _failBlock = new PlainRule(this, 313, "fail-block") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _forIterator = new PlainRule(this, 314, "for-iterator") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _forVariable = new PlainRule(this, 315, "for-variable") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _containment = new PlainRule(this, 316, "containment") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _containmentOperator = new PlainRule(this, 317, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 318 PlainRuleOp      */ __Matchers[318] = _whileStatement = new PlainRule(this, 318, "while-statement") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _tryStatement = new PlainRule(this, 319, "try-statement") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _tryBlock = new PlainRule(this, 320, "try-block") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _catchBlock = new PlainRule(this, 321, "catch-block") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _catchVariable = new PlainRule(this, 322, "catch-variable") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _finallyBlock = new PlainRule(this, 323, "finally-block") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _resources = new PlainRule(this, 324, "resources") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _resourceList = new PlainRule(this, 325, "resource-list") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _resource = new PlainRule(this, 326, "resource") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _specifiedOrExpression = new PlainRule(this, 327, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _specifiedVariable = new PlainRule(this, 328, "specified-variable") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _variable = new PlainRule(this, 329, "variable") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _variableType = new PlainRule(this, 330, "variable-type") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _modelReference = new PlainRule(this, 331, "model-reference") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _metaLiteral = new PlainRule(this, 332, "meta-literal") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _metaExpression = new PlainRule(this, 333, "meta-expression") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _modelExpression = new PlainRule(this, 334, "model-expression") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _memberModelExpression = new PlainRule(this, 335, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _packageQualifiedMemberReference = new PlainRule(this, 336, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _typeQualifiedMemberReference = new PlainRule(this, 337, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _typeModelExpression = new PlainRule(this, 338, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _declarationReference = new PlainRule(this, 339, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _moduleLiteral = new PlainRule(this, 340, "module-literal") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _packageLiteral = new PlainRule(this, 341, "package-literal") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _classLiteral = new PlainRule(this, 342, "class-literal") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _interfaceLiteral = new PlainRule(this, 343, "interface-literal") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _aliasLiteral = new PlainRule(this, 344, "alias-literal") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _typeParameterLiteral = new PlainRule(this, 345, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _newLiteral = new PlainRule(this, 346, "new-literal") { Builder = nodes => nodes[0] };
                /* 347 PlainRuleOp      */ __Matchers[347] = _valueLiteral = new PlainRule(this, 347, "value-literal") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _valueLiteralIntro = new PlainRule(this, 348, "value-literal-intro") { Creator = node => new CValueLiteralIntro(node) };
                /* 349 PlainRuleOp      */ __Matchers[349] = _functionLiteral = new PlainRule(this, 349, "function-literal") { Builder = nodes => nodes[0] };
                /* 350 PlainRuleOp      */ __Matchers[350] = _referencePath = new PlainRule(this, 350, "reference-path") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _referencePathElementList = new PlainRule(this, 351, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 352 PlainRuleOp      */ __Matchers[352] = _referencePathElement = new PlainRule(this, 352, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 353 PlainRuleOp      */ __Matchers[353] = _kwVoid = new PlainRule(this, 353, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 354 PlainRuleOp      */ __Matchers[354] = _kwFunction = new PlainRule(this, 354, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 355 PlainRuleOp      */ __Matchers[355] = _kwValue = new PlainRule(this, 355, "kw-value") { Creator = node => new CKwValue(node) };
                /* 356 DfaRuleOp        */ __Matchers[356] = _literalFloat = new DfaRule(this, 356, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 357 DfaRuleOp        */ __Matchers[357] = _literalNatural = new DfaRule(this, 357, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 358 DfaRuleOp        */ __Matchers[358] = _literalChar = new DfaRule(this, 358, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _stringStart = new DfaRule(this, 359, "string-start") { Creator = node => new CStringStart(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _stringMid = new DfaRule(this, 360, "string-mid") { Creator = node => new CStringMid(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _stringEnd = new DfaRule(this, 361, "string-end") { Creator = node => new CStringEnd(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _literalString = new DfaRule(this, 362, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _verbatimString = new DfaRule(this, 363, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _lowerIdentifier = new DfaRule(this, 364, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _upperIdentifier = new DfaRule(this, 365, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 366 DfaRuleOp        */ __Matchers[366] = _identifier = new DfaRule(this, 366, "identifier") { Creator = node => new CIdentifier(node) };
                /* 367 EofOp            */ __Matchers[367] = new Eof(this, 367, "<eof>") { Creator = node => new REof(node) };
                /* 368 SeqOp            */ __Matchers[368] = new Seq(this, 368, "_368:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 369 AltOp            */ __Matchers[369] = new Alt(this, 369, "alt(>module-descriptor|>package-descriptor|>unit-elements)") { Builder = nodes => nodes[0] };
                /* 370 StarOp           */ __Matchers[370] = new Star(this, 370, "*(>declaration)") { Builder = nodes => new RStar<ICDeclaration>(nodes) };
                /* 371 SeqOp            */ __Matchers[371] = new Seq(this, 371, "_371:(>import-declarations,*(>declaration))") { Builder = nodes => new CUnitElements(nodes) };
                /* 372 StarOp           */ __Matchers[372] = new Star(this, 372, "*(>import-declaration)") { Builder = nodes => new CImportDeclarations(nodes) };
                /* 373 StringOp         */ __Matchers[373] = new Keyword(this, 373, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 374 OptionalOp       */ __Matchers[374] = new Optional(this, 374, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 375 OptionalOp       */ __Matchers[375] = new Optional(this, 375, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 376 SeqOp            */ __Matchers[376] = new Seq(this, 376, "_376:(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 377 StringOp         */ __Matchers[377] = new String(this, 377, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 378 OptionalOp       */ __Matchers[378] = new Optional(this, 378, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Seq(this, 379, "_379:(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 380 AltOp            */ __Matchers[380] = new Alt(this, 380, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 381 OptionalOp       */ __Matchers[381] = new Optional(this, 381, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 382 SeqOp            */ __Matchers[382] = new Seq(this, 382, "_382:(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 383 SeqOp            */ __Matchers[383] = new Seq(this, 383, "_383:(':',>literal-string)") { Builder = nodes => new CArtifact(nodes) };
                /* 384 SeqOp            */ __Matchers[384] = new Seq(this, 384, "_384:(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 385 StringOp         */ __Matchers[385] = new String(this, 385, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 386 StarOp           */ __Matchers[386] = new Star(this, 386, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 387 StringOp         */ __Matchers[387] = new String(this, 387, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 388 SeqOp            */ __Matchers[388] = new Seq(this, 388, "_388:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 389 AltOp            */ __Matchers[389] = new Alt(this, 389, "alt(>inferred-attribute-declaration|>import-module)") { Builder = nodes => nodes[0] };
                /* 390 StringOp         */ __Matchers[390] = new Keyword(this, 390, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 391 StringOp         */ __Matchers[391] = new String(this, 391, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 392 SeqOp            */ __Matchers[392] = new Seq(this, 392, "_392:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 393 StringOp         */ __Matchers[393] = new Keyword(this, 393, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 394 SeqOp            */ __Matchers[394] = new Seq(this, 394, "_394:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CImportModule(nodes) };
                /* 395 SeqOp            */ __Matchers[395] = new Seq(this, 395, "_395:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 396 OptionalOp       */ __Matchers[396] = new Optional(this, 396, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 397 SeqOp            */ __Matchers[397] = new Seq(this, 397, "_397:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 398 StringOp         */ __Matchers[398] = new String(this, 398, "','", ",") { Creator = node => new RLiteral(node) };
                /* 399 SeqOp            */ __Matchers[399] = new Seq(this, 399, "_399:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 400 StarOp           */ __Matchers[400] = new Star(this, 400, "*(_399:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_401:(>import-element,*(_399:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 402 AltOp            */ __Matchers[402] = new Alt(this, 402, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 403 OptionalOp       */ __Matchers[403] = new Optional(this, 403, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 404 OptionalOp       */ __Matchers[404] = new Optional(this, 404, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 405 SeqOp            */ __Matchers[405] = new Seq(this, 405, "_405:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 406 StringOp         */ __Matchers[406] = new String(this, 406, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 407 SeqOp            */ __Matchers[407] = new Seq(this, 407, "_407:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 408 StringOp         */ __Matchers[408] = new String(this, 408, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 409 StringOp         */ __Matchers[409] = new String(this, 409, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 410 SeqOp            */ __Matchers[410] = new Seq(this, 410, "_410:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 411 StarOp           */ __Matchers[411] = new Star(this, 411, "*(_410:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 412 SeqOp            */ __Matchers[412] = new Seq(this, 412, "_412:(>package-name,*(_410:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 413 AltOp            */ __Matchers[413] = new Alt(this, 413, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 414 AltOp            */ __Matchers[414] = new Alt(this, 414, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 415 AltOp            */ __Matchers[415] = new Alt(this, 415, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 416 StringOp         */ __Matchers[416] = new String(this, 416, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 417 SeqOp            */ __Matchers[417] = new Seq(this, 417, "_417:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 418 StringOp         */ __Matchers[418] = new String(this, 418, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 419 OptionalOp       */ __Matchers[419] = new Optional(this, 419, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 420 StringOp         */ __Matchers[420] = new String(this, 420, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 421 SeqOp            */ __Matchers[421] = new Seq(this, 421, "_421:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 422 SeqOp            */ __Matchers[422] = new Seq(this, 422, "_422:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 423 StarOp           */ __Matchers[423] = new Star(this, 423, "*(_422:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 424 SeqOp            */ __Matchers[424] = new Seq(this, 424, "_424:(>variadic-pattern,*(_422:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 425 AltOp            */ __Matchers[425] = new Alt(this, 425, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 426 OptionalOp       */ __Matchers[426] = new Optional(this, 426, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Seq(this, 427, "_427:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 428 StringOp         */ __Matchers[428] = new Keyword(this, 428, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 429 StringOp         */ __Matchers[429] = new String(this, 429, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 430 StringOp         */ __Matchers[430] = new String(this, 430, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 431 SeqOp            */ __Matchers[431] = new Seq(this, 431, "_431:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 432 StringOp         */ __Matchers[432] = new Keyword(this, 432, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 433 SeqOp            */ __Matchers[433] = new Seq(this, 433, "_433:('extends',>class-instatiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 434 OptionalOp       */ __Matchers[434] = new Optional(this, 434, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 435 StringOp         */ __Matchers[435] = new Keyword(this, 435, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 436 SeqOp            */ __Matchers[436] = new Seq(this, 436, "_436:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 437 StarOp           */ __Matchers[437] = new Star(this, 437, "*(>declaration-or-statement)") { Builder = nodes => new RStar<ICDeclarationOrStatement>(nodes) };
                /* 438 SeqOp            */ __Matchers[438] = new Seq(this, 438, "_438:('{',>import-declarations,*(>declaration-or-statement),'}')") { Builder = nodes => new CBlockElements(nodes) };
                /* 439 SeqOp            */ __Matchers[439] = new Seq(this, 439, "_439:('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 440 StringOp         */ __Matchers[440] = new String(this, 440, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 441 SeqOp            */ __Matchers[441] = new Seq(this, 441, "_441:('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 442 OptionalOp       */ __Matchers[442] = new Optional(this, 442, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_443:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 444 AltOp            */ __Matchers[444] = new Alt(this, 444, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 445 StringOp         */ __Matchers[445] = new Keyword(this, 445, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 446 SeqOp            */ __Matchers[446] = new Seq(this, 446, "_446:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_447:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 448 SeqOp            */ __Matchers[448] = new Seq(this, 448, "_448:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 449 AltOp            */ __Matchers[449] = new Alt(this, 449, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_450:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 451 SeqOp            */ __Matchers[451] = new Seq(this, 451, "_451:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 452 StarOp           */ __Matchers[452] = new Star(this, 452, "*(_451:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_453:(>type-reference,*(_451:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 454 StringOp         */ __Matchers[454] = new Keyword(this, 454, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 455 SeqOp            */ __Matchers[455] = new Seq(this, 455, "_455:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 457 StarOp           */ __Matchers[457] = new Star(this, 457, "*(_456:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_458:(>union-type,*(_456:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 459 StringOp         */ __Matchers[459] = new Keyword(this, 459, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 460 SeqOp            */ __Matchers[460] = new Seq(this, 460, "_460:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 461 StringOp         */ __Matchers[461] = new String(this, 461, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 462 SeqOp            */ __Matchers[462] = new Seq(this, 462, "_462:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 463 StarOp           */ __Matchers[463] = new Star(this, 463, "*(_462:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 464 SeqOp            */ __Matchers[464] = new Seq(this, 464, "_464:(>case-type,*(_462:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 465 AltOp            */ __Matchers[465] = new Alt(this, 465, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 466 OptionalOp       */ __Matchers[466] = new Optional(this, 466, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 467 SeqOp            */ __Matchers[467] = new Seq(this, 467, "_467:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 468 OptionalOp       */ __Matchers[468] = new Optional(this, 468, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 469 SeqOp            */ __Matchers[469] = new Seq(this, 469, "_469:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 470 SeqOp            */ __Matchers[470] = new Seq(this, 470, "_470:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 471 StarOp           */ __Matchers[471] = new Star(this, 471, "*(_470:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_472:(>parameter-declaration-or-ref-pattern,*(_470:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 473 AltOp            */ __Matchers[473] = new Alt(this, 473, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 474 SeqOp            */ __Matchers[474] = new Seq(this, 474, "_474:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 475 OptionalOp       */ __Matchers[475] = new Optional(this, 475, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 476 SeqOp            */ __Matchers[476] = new Seq(this, 476, "_476:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 477 AltOp            */ __Matchers[477] = new Alt(this, 477, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 478 OptionalOp       */ __Matchers[478] = new Optional(this, 478, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 479 PlusOp           */ __Matchers[479] = new Plus(this, 479, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 480 OptionalOp       */ __Matchers[480] = new Optional(this, 480, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 481 SeqOp            */ __Matchers[481] = new Seq(this, 481, "_481:(>function-parameter-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CFunctionParameterDeclaration(nodes) };
                /* 482 AltOp            */ __Matchers[482] = new Alt(this, 482, "alt(>variadic-type|>kw-void|>kw-function)") { Builder = nodes => nodes[0] };
                /* 483 SeqOp            */ __Matchers[483] = new Seq(this, 483, "_483:(>value-parameter-type,>member-name,?(>value-specifier))") { Builder = nodes => new CValueParameterDeclaration(nodes) };
                /* 484 AltOp            */ __Matchers[484] = new Alt(this, 484, "alt(>variadic-type|>kw-value)") { Builder = nodes => nodes[0] };
                /* 485 StringOp         */ __Matchers[485] = new String(this, 485, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 486 StringOp         */ __Matchers[486] = new String(this, 486, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 487 SeqOp            */ __Matchers[487] = new Seq(this, 487, "_487:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 488 SeqOp            */ __Matchers[488] = new Seq(this, 488, "_488:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 489 StarOp           */ __Matchers[489] = new Star(this, 489, "*(_488:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 490 SeqOp            */ __Matchers[490] = new Seq(this, 490, "_490:(>type-parameter,*(_488:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 491 OptionalOp       */ __Matchers[491] = new Optional(this, 491, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 492 OptionalOp       */ __Matchers[492] = new Optional(this, 492, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 493 SeqOp            */ __Matchers[493] = new Seq(this, 493, "_493:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 494 StringOp         */ __Matchers[494] = new Keyword(this, 494, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 495 StringOp         */ __Matchers[495] = new Keyword(this, 495, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 496 AltOp            */ __Matchers[496] = new Alt(this, 496, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 497 SeqOp            */ __Matchers[497] = new Seq(this, 497, "_497:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 498 StringOp         */ __Matchers[498] = new Keyword(this, 498, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 499 OptionalOp       */ __Matchers[499] = new Optional(this, 499, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 500 OptionalOp       */ __Matchers[500] = new Optional(this, 500, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 501 OptionalOp       */ __Matchers[501] = new Optional(this, 501, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 502 SeqOp            */ __Matchers[502] = new Seq(this, 502, "_502:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 503 PlusOp           */ __Matchers[503] = new Plus(this, 503, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 504 AltOp            */ __Matchers[504] = new Alt(this, 504, "alt(>declaration|>statement)") { Builder = nodes => nodes[0] };
                /* 505 AltOp            */ __Matchers[505] = new Alt(this, 505, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 506 StringOp         */ __Matchers[506] = new Keyword(this, 506, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 507 OptionalOp       */ __Matchers[507] = new Optional(this, 507, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 508 OptionalOp       */ __Matchers[508] = new Optional(this, 508, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 509 SeqOp            */ __Matchers[509] = new Seq(this, 509, "_509:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 510 StringOp         */ __Matchers[510] = new Keyword(this, 510, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 511 OptionalOp       */ __Matchers[511] = new Optional(this, 511, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 512 SeqOp            */ __Matchers[512] = new Seq(this, 512, "_512:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 513 SeqOp            */ __Matchers[513] = new Seq(this, 513, "_513:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 514 StringOp         */ __Matchers[514] = new Keyword(this, 514, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 515 OptionalOp       */ __Matchers[515] = new Optional(this, 515, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 516 SeqOp            */ __Matchers[516] = new Seq(this, 516, "_516:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 517 StringOp         */ __Matchers[517] = new Keyword(this, 517, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 518 SeqOp            */ __Matchers[518] = new Seq(this, 518, "_518:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 519 AltOp            */ __Matchers[519] = new Alt(this, 519, "alt(>block|>needed-function-specifier)") { Builder = nodes => nodes[0] };
                /* 520 SeqOp            */ __Matchers[520] = new Seq(this, 520, "_520:(>annotations,>variadic-type,>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 521 StringOp         */ __Matchers[521] = new Keyword(this, 521, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 522 SeqOp            */ __Matchers[522] = new Seq(this, 522, "_522:(>annotations,'void',>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 523 StringOp         */ __Matchers[523] = new Keyword(this, 523, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 524 SeqOp            */ __Matchers[524] = new Seq(this, 524, "_524:(>annotations,'function',>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 525 SeqOp            */ __Matchers[525] = new Seq(this, 525, "_525:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 527 SeqOp            */ __Matchers[527] = new Seq(this, 527, "_527:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 528 AltOp            */ __Matchers[528] = new Alt(this, 528, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 529 OptionalOp       */ __Matchers[529] = new Optional(this, 529, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_530:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 531 StringOp         */ __Matchers[531] = new Keyword(this, 531, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 532 OptionalOp       */ __Matchers[532] = new Optional(this, 532, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 533 SeqOp            */ __Matchers[533] = new Seq(this, 533, "_533:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 534 AltOp            */ __Matchers[534] = new Alt(this, 534, "alt(>class-block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 535 OptionalOp       */ __Matchers[535] = new Optional(this, 535, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 536 SeqOp            */ __Matchers[536] = new Seq(this, 536, "_536:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 537 StringOp         */ __Matchers[537] = new Keyword(this, 537, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_538:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 539 AltOp            */ __Matchers[539] = new Alt(this, 539, "alt(>interface-block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 540 OptionalOp       */ __Matchers[540] = new Optional(this, 540, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 541 SeqOp            */ __Matchers[541] = new Seq(this, 541, "_541:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 542 AltOp            */ __Matchers[542] = new Alt(this, 542, "alt(>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 543 SeqOp            */ __Matchers[543] = new Seq(this, 543, "_543:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 544 AltOp            */ __Matchers[544] = new Alt(this, 544, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 545 SeqOp            */ __Matchers[545] = new Seq(this, 545, "_545:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 546 AltOp            */ __Matchers[546] = new Alt(this, 546, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 547 StringOp         */ __Matchers[547] = new Keyword(this, 547, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 548 OptionalOp       */ __Matchers[548] = new Optional(this, 548, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 549 SeqOp            */ __Matchers[549] = new Seq(this, 549, "_549:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 550 StringOp         */ __Matchers[550] = new Keyword(this, 550, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 551 SeqOp            */ __Matchers[551] = new Seq(this, 551, "_551:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 552 StringOp         */ __Matchers[552] = new Keyword(this, 552, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 553 StringOp         */ __Matchers[553] = new Keyword(this, 553, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 554 SeqOp            */ __Matchers[554] = new Seq(this, 554, "_554:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 555 SeqOp            */ __Matchers[555] = new Seq(this, 555, "_555:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 556 SeqOp            */ __Matchers[556] = new Seq(this, 556, "_556:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 557 AltOp            */ __Matchers[557] = new Alt(this, 557, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 558 AltOp            */ __Matchers[558] = new Alt(this, 558, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 559 AltOp            */ __Matchers[559] = new Alt(this, 559, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 560 SeqOp            */ __Matchers[560] = new Seq(this, 560, "_560:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 561 SeqOp            */ __Matchers[561] = new Seq(this, 561, "_561:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 562 OptionalOp       */ __Matchers[562] = new Optional(this, 562, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_563:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_564:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_565:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 566 StringOp         */ __Matchers[566] = new Keyword(this, 566, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 567 StringOp         */ __Matchers[567] = new Keyword(this, 567, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 568 AltOp            */ __Matchers[568] = new Alt(this, 568, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 569 OptionalOp       */ __Matchers[569] = new Optional(this, 569, "?(>sequenced-arguments)") { Builder = nodes => new ROptional<CSequencedArguments>(nodes) };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:('{',*(>declaration-or-statement),?(>sequenced-arguments),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 571 SeqOp            */ __Matchers[571] = new Seq(this, 571, "_571:('[',?(>sequenced-arguments),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 572 AltOp            */ __Matchers[572] = new Alt(this, 572, "alt(>structural-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 573 StarOp           */ __Matchers[573] = new Star(this, 573, "*(>named-or-anonymous)") { Builder = nodes => new RStar<ICNamedOrAnonymous>(nodes) };
                /* 574 SeqOp            */ __Matchers[574] = new Seq(this, 574, "_574:('{',*(>named-or-anonymous),?(>sequenced-arguments),'}')") { Builder = nodes => new CStructuralArguments(nodes) };
                /* 575 AltOp            */ __Matchers[575] = new Alt(this, 575, "alt(>named-argument|>anonymous-argument)") { Builder = nodes => nodes[0] };
                /* 576 AltOp            */ __Matchers[576] = new Alt(this, 576, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 577 SeqOp            */ __Matchers[577] = new Seq(this, 577, "_577:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 578 SeqOp            */ __Matchers[578] = new Seq(this, 578, "_578:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_579:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 580 StarOp           */ __Matchers[580] = new Star(this, 580, "*(_579:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 581 SeqOp            */ __Matchers[581] = new Seq(this, 581, "_581:(>sequenced-argument,*(_579:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArguments(nodes) };
                /* 582 AltOp            */ __Matchers[582] = new Alt(this, 582, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 583 AltOp            */ __Matchers[583] = new Alt(this, 583, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_584:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_585:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 586 AltOp            */ __Matchers[586] = new Alt(this, 586, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 587 SeqOp            */ __Matchers[587] = new Seq(this, 587, "_587:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:(>function-specifier,';')") { Builder = nodes => new CNeededFunctionSpecifier(nodes) };
                /* 589 AltOp            */ __Matchers[589] = new Alt(this, 589, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 590 SeqOp            */ __Matchers[590] = new Seq(this, 590, "_590:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 592 SeqOp            */ __Matchers[592] = new Seq(this, 592, "_592:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_593:(>member-name,+(>parameters),>needed-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_594:(>member-name,>needed-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_595:('(',?(>sequenced-arguments),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 596 AltOp            */ __Matchers[596] = new Alt(this, 596, "alt(>expression|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 597 StringOp         */ __Matchers[597] = new String(this, 597, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_598:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 599 OptionalOp       */ __Matchers[599] = new Optional(this, 599, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_600:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 601 SeqOp            */ __Matchers[601] = new Seq(this, 601, "_601:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 602 StarOp           */ __Matchers[602] = new Star(this, 602, "*(_601:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_603:(>let-variable,*(_601:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 604 SeqOp            */ __Matchers[604] = new Seq(this, 604, "_604:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_605:(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 606 PlusOp           */ __Matchers[606] = new Plus(this, 606, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 607 OptionalOp       */ __Matchers[607] = new Optional(this, 607, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 608 SeqOp            */ __Matchers[608] = new Seq(this, 608, "_608:(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 609 StringOp         */ __Matchers[609] = new Keyword(this, 609, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 610 OptionalOp       */ __Matchers[610] = new Optional(this, 610, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 611 StringOp         */ __Matchers[611] = new Keyword(this, 611, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 612 SeqOp            */ __Matchers[612] = new Seq(this, 612, "_612:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 613 StringOp         */ __Matchers[613] = new Keyword(this, 613, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_614:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 615 SeqOp            */ __Matchers[615] = new Seq(this, 615, "_615:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 616 StringOp         */ __Matchers[616] = new Keyword(this, 616, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 618 AltOp            */ __Matchers[618] = new Alt(this, 618, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 619 OptionalOp       */ __Matchers[619] = new Optional(this, 619, "?(>function-expression-type)") { Builder = nodes => new ROptional<ICFunctionExpressionType>(nodes) };
                /* 620 OptionalOp       */ __Matchers[620] = new Optional(this, 620, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 621 SeqOp            */ __Matchers[621] = new Seq(this, 621, "_621:(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpr(nodes) };
                /* 622 AltOp            */ __Matchers[622] = new Alt(this, 622, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 623 SeqOp            */ __Matchers[623] = new Seq(this, 623, "_623:(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 624 AltOp            */ __Matchers[624] = new Alt(this, 624, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 625 AltOp            */ __Matchers[625] = new Alt(this, 625, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 626 AltOp            */ __Matchers[626] = new Alt(this, 626, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 627 StringOp         */ __Matchers[627] = new Keyword(this, 627, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 628 OptionalOp       */ __Matchers[628] = new Optional(this, 628, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 629 SeqOp            */ __Matchers[629] = new Seq(this, 629, "_629:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 630 SeqOp            */ __Matchers[630] = new Seq(this, 630, "_630:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 631 AltOp            */ __Matchers[631] = new Alt(this, 631, "alt(>let-expr|>if-expr|>switch-expr|>function-expr|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 632 AltOp            */ __Matchers[632] = new Alt(this, 632, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 633 SeqOp            */ __Matchers[633] = new Seq(this, 633, "_633:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 634 StringOp         */ __Matchers[634] = new String(this, 634, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 635 StringOp         */ __Matchers[635] = new String(this, 635, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 636 StringOp         */ __Matchers[636] = new String(this, 636, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 637 StringOp         */ __Matchers[637] = new String(this, 637, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 638 StringOp         */ __Matchers[638] = new String(this, 638, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 639 StringOp         */ __Matchers[639] = new String(this, 639, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 640 StringOp         */ __Matchers[640] = new String(this, 640, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 645 AltOp            */ __Matchers[645] = new Alt(this, 645, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 646 AltOp            */ __Matchers[646] = new Alt(this, 646, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 647 SeqOp            */ __Matchers[647] = new Seq(this, 647, "_647:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 648 AltOp            */ __Matchers[648] = new Alt(this, 648, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 649 AltOp            */ __Matchers[649] = new Alt(this, 649, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 650 SeqOp            */ __Matchers[650] = new Seq(this, 650, "_650:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 651 StringOp         */ __Matchers[651] = new String(this, 651, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 652 AltOp            */ __Matchers[652] = new Alt(this, 652, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 653 SeqOp            */ __Matchers[653] = new Seq(this, 653, "_653:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 654 StringOp         */ __Matchers[654] = new String(this, 654, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 655 AltOp            */ __Matchers[655] = new Alt(this, 655, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 656 SeqOp            */ __Matchers[656] = new Seq(this, 656, "_656:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 657 StringOp         */ __Matchers[657] = new String(this, 657, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 658 AltOp            */ __Matchers[658] = new Alt(this, 658, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 659 AltOp            */ __Matchers[659] = new Alt(this, 659, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 660 SeqOp            */ __Matchers[660] = new Seq(this, 660, "_660:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 661 StringOp         */ __Matchers[661] = new String(this, 661, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 662 StringOp         */ __Matchers[662] = new String(this, 662, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 663 StringOp         */ __Matchers[663] = new String(this, 663, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 664 AltOp            */ __Matchers[664] = new Alt(this, 664, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 665 AltOp            */ __Matchers[665] = new Alt(this, 665, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 666 SeqOp            */ __Matchers[666] = new Seq(this, 666, "_666:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 667 SeqOp            */ __Matchers[667] = new Seq(this, 667, "_667:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 668 SeqOp            */ __Matchers[668] = new Seq(this, 668, "_668:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 669 SeqOp            */ __Matchers[669] = new Seq(this, 669, "_669:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 670 SeqOp            */ __Matchers[670] = new Seq(this, 670, "_670:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_671:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 672 StringOp         */ __Matchers[672] = new String(this, 672, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 673 AltOp            */ __Matchers[673] = new Alt(this, 673, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 674 StringOp         */ __Matchers[674] = new String(this, 674, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 675 AltOp            */ __Matchers[675] = new Alt(this, 675, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 676 StringOp         */ __Matchers[676] = new String(this, 676, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 677 AltOp            */ __Matchers[677] = new Alt(this, 677, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 678 StringOp         */ __Matchers[678] = new Keyword(this, 678, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 679 AltOp            */ __Matchers[679] = new Alt(this, 679, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 680 AltOp            */ __Matchers[680] = new Alt(this, 680, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 681 StringOp         */ __Matchers[681] = new Keyword(this, 681, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 682 SeqOp            */ __Matchers[682] = new Seq(this, 682, "_682:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 683 StringOp         */ __Matchers[683] = new Keyword(this, 683, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 684 SeqOp            */ __Matchers[684] = new Seq(this, 684, "_684:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 685 AltOp            */ __Matchers[685] = new Alt(this, 685, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 686 SeqOp            */ __Matchers[686] = new Seq(this, 686, "_686:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 687 SeqOp            */ __Matchers[687] = new Seq(this, 687, "_687:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 688 StringOp         */ __Matchers[688] = new String(this, 688, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 689 AltOp            */ __Matchers[689] = new Alt(this, 689, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 690 AltOp            */ __Matchers[690] = new Alt(this, 690, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 691 SeqOp            */ __Matchers[691] = new Seq(this, 691, "_691:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 692 StringOp         */ __Matchers[692] = new String(this, 692, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 693 StringOp         */ __Matchers[693] = new String(this, 693, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 694 AltOp            */ __Matchers[694] = new Alt(this, 694, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 695 AltOp            */ __Matchers[695] = new Alt(this, 695, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 696 SeqOp            */ __Matchers[696] = new Seq(this, 696, "_696:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 697 StringOp         */ __Matchers[697] = new String(this, 697, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 698 AltOp            */ __Matchers[698] = new Alt(this, 698, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 699 SeqOp            */ __Matchers[699] = new Seq(this, 699, "_699:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 700 StringOp         */ __Matchers[700] = new String(this, 700, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 701 StringOp         */ __Matchers[701] = new String(this, 701, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 702 AltOp            */ __Matchers[702] = new Alt(this, 702, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 703 AltOp            */ __Matchers[703] = new Alt(this, 703, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 704 SeqOp            */ __Matchers[704] = new Seq(this, 704, "_704:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 705 StringOp         */ __Matchers[705] = new String(this, 705, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 706 AltOp            */ __Matchers[706] = new Alt(this, 706, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 707 AltOp            */ __Matchers[707] = new Alt(this, 707, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 708 SeqOp            */ __Matchers[708] = new Seq(this, 708, "_708:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 709 StringOp         */ __Matchers[709] = new String(this, 709, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 710 AltOp            */ __Matchers[710] = new Alt(this, 710, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 711 SeqOp            */ __Matchers[711] = new Seq(this, 711, "_711:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 712 StringOp         */ __Matchers[712] = new String(this, 712, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 713 AltOp            */ __Matchers[713] = new Alt(this, 713, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 714 SeqOp            */ __Matchers[714] = new Seq(this, 714, "_714:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 715 AltOp            */ __Matchers[715] = new Alt(this, 715, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 716 NotOp            */ __Matchers[716] = new Not(this, 716, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 717 SeqOp            */ __Matchers[717] = new Seq(this, 717, "_717:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 718 NotOp            */ __Matchers[718] = new Not(this, 718, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 719 SeqOp            */ __Matchers[719] = new Seq(this, 719, "_719:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 720 AltOp            */ __Matchers[720] = new Alt(this, 720, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_721:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 722 AltOp            */ __Matchers[722] = new Alt(this, 722, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 723 SeqOp            */ __Matchers[723] = new Seq(this, 723, "_723:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 724 StringOp         */ __Matchers[724] = new String(this, 724, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 725 StringOp         */ __Matchers[725] = new String(this, 725, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 726 AltOp            */ __Matchers[726] = new Alt(this, 726, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 727 AltOp            */ __Matchers[727] = new Alt(this, 727, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 728 SeqOp            */ __Matchers[728] = new Seq(this, 728, "_728:(>primary,>qualified-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 729 SeqOp            */ __Matchers[729] = new Seq(this, 729, "_729:(>member-selection-operator,>base-reference)") { Builder = nodes => new CQualifiedReference(nodes) };
                /* 730 StringOp         */ __Matchers[730] = new String(this, 730, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 731 StringOp         */ __Matchers[731] = new String(this, 731, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 732 AltOp            */ __Matchers[732] = new Alt(this, 732, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 733 SeqOp            */ __Matchers[733] = new Seq(this, 733, "_733:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 734 AltOp            */ __Matchers[734] = new Alt(this, 734, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 735 SeqOp            */ __Matchers[735] = new Seq(this, 735, "_735:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 736 SeqOp            */ __Matchers[736] = new Seq(this, 736, "_736:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_737:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_738:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 740 AltOp            */ __Matchers[740] = new Alt(this, 740, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 741 AltOp            */ __Matchers[741] = new Alt(this, 741, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 742 AltOp            */ __Matchers[742] = new Alt(this, 742, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 743 StarOp           */ __Matchers[743] = new Star(this, 743, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 744 SeqOp            */ __Matchers[744] = new Seq(this, 744, "_744:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 745 SeqOp            */ __Matchers[745] = new Seq(this, 745, "_745:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 746 AltOp            */ __Matchers[746] = new Alt(this, 746, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 747 SeqOp            */ __Matchers[747] = new Seq(this, 747, "_747:('object',?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_748:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 749 OptionalOp       */ __Matchers[749] = new Optional(this, 749, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_750:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 751 SeqOp            */ __Matchers[751] = new Seq(this, 751, "_751:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 752 StarOp           */ __Matchers[752] = new Star(this, 752, "*(_751:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_753:(>varianced-type,*(_751:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_754:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_755:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 756 StarOp           */ __Matchers[756] = new Star(this, 756, "*(_755:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_757:(>defaulted-type,*(_755:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 758 AltOp            */ __Matchers[758] = new Alt(this, 758, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_759:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 760 AltOp            */ __Matchers[760] = new Alt(this, 760, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 761 SeqOp            */ __Matchers[761] = new Seq(this, 761, "_761:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 762 AltOp            */ __Matchers[762] = new Alt(this, 762, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 763 SeqOp            */ __Matchers[763] = new Seq(this, 763, "_763:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 764 AltOp            */ __Matchers[764] = new Alt(this, 764, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_765:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 766 AltOp            */ __Matchers[766] = new Alt(this, 766, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_767:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 768 AltOp            */ __Matchers[768] = new Alt(this, 768, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_769:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 770 AltOp            */ __Matchers[770] = new Alt(this, 770, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>package-qualified-type|>type-path)") { Builder = nodes => nodes[0] };
                /* 771 StringOp         */ __Matchers[771] = new String(this, 771, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 772 SeqOp            */ __Matchers[772] = new Seq(this, 772, "_772:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 773 OptionalOp       */ __Matchers[773] = new Optional(this, 773, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 774 SeqOp            */ __Matchers[774] = new Seq(this, 774, "_774:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 775 OptionalOp       */ __Matchers[775] = new Optional(this, 775, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 776 SeqOp            */ __Matchers[776] = new Seq(this, 776, "_776:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 777 AltOp            */ __Matchers[777] = new Alt(this, 777, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_778:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 779 OptionalOp       */ __Matchers[779] = new Optional(this, 779, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 780 SeqOp            */ __Matchers[780] = new Seq(this, 780, "_780:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 781 SeqOp            */ __Matchers[781] = new Seq(this, 781, "_781:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_782:('package','.',>type-path)") { Builder = nodes => new CPackageQualifiedType(nodes) };
                /* 783 OptionalOp       */ __Matchers[783] = new Optional(this, 783, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 784 StarOp           */ __Matchers[784] = new Star(this, 784, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 785 SeqOp            */ __Matchers[785] = new Seq(this, 785, "_785:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 786 SeqOp            */ __Matchers[786] = new Seq(this, 786, "_786:(>member-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 787 OptionalOp       */ __Matchers[787] = new Optional(this, 787, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 788 SeqOp            */ __Matchers[788] = new Seq(this, 788, "_788:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 789 SeqOp            */ __Matchers[789] = new Seq(this, 789, "_789:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 790 StarOp           */ __Matchers[790] = new Star(this, 790, "*(_789:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_791:(>condition,*(_789:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 792 AltOp            */ __Matchers[792] = new Alt(this, 792, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 793 OptionalOp       */ __Matchers[793] = new Optional(this, 793, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 794 SeqOp            */ __Matchers[794] = new Seq(this, 794, "_794:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 795 SeqOp            */ __Matchers[795] = new Seq(this, 795, "_795:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 796 AltOp            */ __Matchers[796] = new Alt(this, 796, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 797 SeqOp            */ __Matchers[797] = new Seq(this, 797, "_797:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 798 SeqOp            */ __Matchers[798] = new Seq(this, 798, "_798:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 800 AltOp            */ __Matchers[800] = new Alt(this, 800, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 801 OptionalOp       */ __Matchers[801] = new Optional(this, 801, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 802 SeqOp            */ __Matchers[802] = new Seq(this, 802, "_802:(>if-block,?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 803 SeqOp            */ __Matchers[803] = new Seq(this, 803, "_803:('if',>conditions,>block)") { Builder = nodes => new CIfBlock(nodes) };
                /* 804 SeqOp            */ __Matchers[804] = new Seq(this, 804, "_804:('else',>else-block-next)") { Builder = nodes => new CElseBlock(nodes) };
                /* 805 AltOp            */ __Matchers[805] = new Alt(this, 805, "alt(>if-else-statement|>block)") { Builder = nodes => nodes[0] };
                /* 806 PlusOp           */ __Matchers[806] = new Plus(this, 806, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 807 SeqOp            */ __Matchers[807] = new Seq(this, 807, "_807:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 808 StringOp         */ __Matchers[808] = new Keyword(this, 808, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 809 SeqOp            */ __Matchers[809] = new Seq(this, 809, "_809:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 810 SeqOp            */ __Matchers[810] = new Seq(this, 810, "_810:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 811 AltOp            */ __Matchers[811] = new Alt(this, 811, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 812 OptionalOp       */ __Matchers[812] = new Optional(this, 812, "?('is')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 813 SeqOp            */ __Matchers[813] = new Seq(this, 813, "_813:(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_814:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_815:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 816 StarOp           */ __Matchers[816] = new Star(this, 816, "*(_815:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 817 SeqOp            */ __Matchers[817] = new Seq(this, 817, "_817:(>value-case,*(_815:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 818 AltOp            */ __Matchers[818] = new Alt(this, 818, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 819 AltOp            */ __Matchers[819] = new Alt(this, 819, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 820 OptionalOp       */ __Matchers[820] = new Optional(this, 820, "?(>fail-block)") { Builder = nodes => new ROptional<CFailBlock>(nodes) };
                /* 821 SeqOp            */ __Matchers[821] = new Seq(this, 821, "_821:(>for-block,?(>fail-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 822 SeqOp            */ __Matchers[822] = new Seq(this, 822, "_822:('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 823 SeqOp            */ __Matchers[823] = new Seq(this, 823, "_823:('else',>block)") { Builder = nodes => new CFailBlock(nodes) };
                /* 824 OptionalOp       */ __Matchers[824] = new Optional(this, 824, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 825 SeqOp            */ __Matchers[825] = new Seq(this, 825, "_825:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 826 AltOp            */ __Matchers[826] = new Alt(this, 826, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 827 SeqOp            */ __Matchers[827] = new Seq(this, 827, "_827:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 828 AltOp            */ __Matchers[828] = new Alt(this, 828, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 829 StringOp         */ __Matchers[829] = new Keyword(this, 829, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 830 SeqOp            */ __Matchers[830] = new Seq(this, 830, "_830:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 831 StarOp           */ __Matchers[831] = new Star(this, 831, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 832 OptionalOp       */ __Matchers[832] = new Optional(this, 832, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 833 SeqOp            */ __Matchers[833] = new Seq(this, 833, "_833:(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 834 StringOp         */ __Matchers[834] = new Keyword(this, 834, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 835 OptionalOp       */ __Matchers[835] = new Optional(this, 835, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 836 SeqOp            */ __Matchers[836] = new Seq(this, 836, "_836:('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 837 StringOp         */ __Matchers[837] = new Keyword(this, 837, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 838 SeqOp            */ __Matchers[838] = new Seq(this, 838, "_838:('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 839 OptionalOp       */ __Matchers[839] = new Optional(this, 839, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 840 SeqOp            */ __Matchers[840] = new Seq(this, 840, "_840:('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 841 StringOp         */ __Matchers[841] = new Keyword(this, 841, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 842 SeqOp            */ __Matchers[842] = new Seq(this, 842, "_842:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 843 OptionalOp       */ __Matchers[843] = new Optional(this, 843, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_844:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 845 SeqOp            */ __Matchers[845] = new Seq(this, 845, "_845:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 846 StarOp           */ __Matchers[846] = new Star(this, 846, "*(_845:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 847 SeqOp            */ __Matchers[847] = new Seq(this, 847, "_847:(>resource,*(_845:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 848 AltOp            */ __Matchers[848] = new Alt(this, 848, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 849 SeqOp            */ __Matchers[849] = new Seq(this, 849, "_849:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 850 OptionalOp       */ __Matchers[850] = new Optional(this, 850, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 851 StarOp           */ __Matchers[851] = new Star(this, 851, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 852 SeqOp            */ __Matchers[852] = new Seq(this, 852, "_852:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 853 AltOp            */ __Matchers[853] = new Alt(this, 853, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 854 SeqOp            */ __Matchers[854] = new Seq(this, 854, "_854:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 855 StringOp         */ __Matchers[855] = new String(this, 855, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 856 SeqOp            */ __Matchers[856] = new Seq(this, 856, "_856:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 857 AltOp            */ __Matchers[857] = new Alt(this, 857, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 858 AltOp            */ __Matchers[858] = new Alt(this, 858, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 859 AltOp            */ __Matchers[859] = new Alt(this, 859, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 860 SeqOp            */ __Matchers[860] = new Seq(this, 860, "_860:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 861 SeqOp            */ __Matchers[861] = new Seq(this, 861, "_861:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 862 AltOp            */ __Matchers[862] = new Alt(this, 862, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 863 OptionalOp       */ __Matchers[863] = new Optional(this, 863, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 864 SeqOp            */ __Matchers[864] = new Seq(this, 864, "_864:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_865:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_866:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_867:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_868:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 871 SeqOp            */ __Matchers[871] = new Seq(this, 871, "_871:(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 872 AltOp            */ __Matchers[872] = new Alt(this, 872, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 873 SeqOp            */ __Matchers[873] = new Seq(this, 873, "_873:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 874 SeqOp            */ __Matchers[874] = new Seq(this, 874, "_874:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_875:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 876 StarOp           */ __Matchers[876] = new Star(this, 876, "*(_875:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 877 SeqOp            */ __Matchers[877] = new Seq(this, 877, "_877:(>reference-path-element,*(_875:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[368]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[369]);
                /*   4 PlainRuleOp      */ _unitElements.Set(__Matchers[371]);
                /*   5 PlainRuleOp      */ _importDeclarations.Set(__Matchers[372]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[376]);
                /*   7 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[379]);
                /*   8 PlainRuleOp      */ _repository.Set(_identifier);
                /*   9 PlainRuleOp      */ _module.Set(__Matchers[380]);
                /*  10 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[382]);
                /*  11 PlainRuleOp      */ _artifact.Set(__Matchers[383]);
                /*  12 PlainRuleOp      */ _classifier.Set(__Matchers[384]);
                /*  13 PlainRuleOp      */ _version.Set(_literalString);
                /*  14 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  15 PlainRuleOp      */ _moduleBody.Set(__Matchers[388]);
                /*  16 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[389]);
                /*  17 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[392]);
                /*  18 PlainRuleOp      */ _importModule.Set(__Matchers[394]);
                /*  19 PlainRuleOp      */ _importDeclaration.Set(__Matchers[395]);
                /*  20 PlainRuleOp      */ _importElements.Set(__Matchers[397]);
                /*  21 PlainRuleOp      */ _importElementList.Set(__Matchers[401]);
                /*  22 PlainRuleOp      */ _importElement.Set(__Matchers[402]);
                /*  23 PlainRuleOp      */ _importNamed.Set(__Matchers[405]);
                /*  24 PlainRuleOp      */ _importName.Set(_identifier);
                /*  25 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[407]);
                /*  26 PlainRuleOp      */ _importWildcard.Set(__Matchers[408]);
                /*  27 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  28 PlainRuleOp      */ _packagePath.Set(__Matchers[412]);
                /*  29 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  30 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  31 PlainRuleOp      */ _pattern.Set(__Matchers[413]);
                /*  32 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[414]);
                /*  33 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[415]);
                /*  34 PlainRuleOp      */ _entryPattern.Set(__Matchers[417]);
                /*  35 PlainRuleOp      */ _tuplePattern.Set(__Matchers[421]);
                /*  36 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[424]);
                /*  37 PlainRuleOp      */ _variadicPattern.Set(__Matchers[425]);
                /*  38 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  39 PlainRuleOp      */ _variadicVariable.Set(__Matchers[427]);
                /*  40 PlainRuleOp      */ _letStatement.Set(__Matchers[431]);
                /*  41 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[433]);
                /*  42 PlainRuleOp      */ _assertionStatement.Set(__Matchers[436]);
                /*  43 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  44 PlainRuleOp      */ _block.Set(_blockElements);
                /*  45 PlainRuleOp      */ _interfaceBlock.Set(_blockElements);
                /*  46 PlainRuleOp      */ _classBlock.Set(_blockElements);
                /*  47 PlainRuleOp      */ _blockElements.Set(__Matchers[438]);
                /*  48 PlainRuleOp      */ _extendedType.Set(__Matchers[439]);
                /*  49 PlainRuleOp      */ _classSpecifier.Set(__Matchers[441]);
                /*  50 PlainRuleOp      */ _classInstatiation.Set(__Matchers[443]);
                /*  51 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[444]);
                /*  52 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[446]);
                /*  53 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[447]);
                /*  54 PlainRuleOp      */ _packageQualifier.Set(__Matchers[448]);
                /*  55 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[449]);
                /*  56 PlainRuleOp      */ _memberPath.Set(__Matchers[450]);
                /*  57 PlainRuleOp      */ _typePath.Set(__Matchers[453]);
                /*  58 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[455]);
                /*  59 PlainRuleOp      */ _unionTypeList.Set(__Matchers[458]);
                /*  60 PlainRuleOp      */ _caseTypes.Set(__Matchers[460]);
                /*  61 PlainRuleOp      */ _caseTypeList.Set(__Matchers[464]);
                /*  62 PlainRuleOp      */ _caseType.Set(__Matchers[465]);
                /*  63 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[467]);
                /*  64 PlainRuleOp      */ _parameters.Set(__Matchers[469]);
                /*  65 PlainRuleOp      */ _parameterList.Set(__Matchers[472]);
                /*  66 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[473]);
                /*  67 PlainRuleOp      */ _parameter.Set(__Matchers[474]);
                /*  68 PlainRuleOp      */ _parameterReference.Set(__Matchers[476]);
                /*  69 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[477]);
                /*  70 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[481]);
                /*  71 PlainRuleOp      */ _functionParameterType.Set(__Matchers[482]);
                /*  72 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[483]);
                /*  73 PlainRuleOp      */ _valueParameterType.Set(__Matchers[484]);
                /*  74 PlainRuleOp      */ _typeParameters.Set(__Matchers[487]);
                /*  75 PlainRuleOp      */ _typeParameterList.Set(__Matchers[490]);
                /*  76 PlainRuleOp      */ _typeParameter.Set(__Matchers[493]);
                /*  77 PlainRuleOp      */ _variance.Set(__Matchers[496]);
                /*  78 PlainRuleOp      */ _typeDefault.Set(__Matchers[497]);
                /*  79 PlainRuleOp      */ _typeConstraint.Set(__Matchers[502]);
                /*  80 PlainRuleOp      */ _typeConstraints.Set(__Matchers[503]);
                /*  81 PlainRuleOp      */ _declarationOrStatement.Set(__Matchers[504]);
                /*  82 PlainRuleOp      */ _declaration.Set(__Matchers[505]);
                /*  83 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[509]);
                /*  84 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[512]);
                /*  85 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[513]);
                /*  86 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[516]);
                /*  87 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[518]);
                /*  88 PlainRuleOp      */ _setterDefinition.Set(__Matchers[519]);
                /*  89 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[520]);
                /*  90 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[522]);
                /*  91 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[524]);
                /*  92 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[525]);
                /*  93 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[527]);
                /*  94 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[528]);
                /*  95 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[530]);
                /*  96 PlainRuleOp      */ _classDeclaration.Set(__Matchers[533]);
                /*  97 PlainRuleOp      */ _classDefinition.Set(__Matchers[534]);
                /*  98 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[536]);
                /*  99 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[538]);
                /* 100 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[539]);
                /* 101 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[541]);
                /* 102 PlainRuleOp      */ _statement.Set(__Matchers[542]);
                /* 103 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[543]);
                /* 104 PlainRuleOp      */ _openStatement.Set(__Matchers[544]);
                /* 105 PlainRuleOp      */ _specificationStatement.Set(__Matchers[545]);
                /* 106 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 107 PlainRuleOp      */ _directiveStatement.Set(__Matchers[546]);
                /* 108 PlainRuleOp      */ _returnStatement.Set(__Matchers[549]);
                /* 109 PlainRuleOp      */ _throwStatement.Set(__Matchers[551]);
                /* 110 PlainRuleOp      */ _breakStatement.Set(__Matchers[552]);
                /* 111 PlainRuleOp      */ _continueStatement.Set(__Matchers[553]);
                /* 112 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[554]);
                /* 113 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[555]);
                /* 114 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[556]);
                /* 115 PlainRuleOp      */ _anySpecifier.Set(__Matchers[557]);
                /* 116 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[558]);
                /* 117 PlainRuleOp      */ _baseReference.Set(__Matchers[559]);
                /* 118 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[560]);
                /* 119 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[561]);
                /* 120 PlainRuleOp      */ _memberReference.Set(__Matchers[563]);
                /* 121 PlainRuleOp      */ _typeReference.Set(__Matchers[564]);
                /* 122 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[565]);
                /* 123 PlainRuleOp      */ _selfReference.Set(__Matchers[568]);
                /* 124 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[570]);
                /* 125 PlainRuleOp      */ _tupleExpr.Set(__Matchers[571]);
                /* 126 PlainRuleOp      */ _arguments.Set(__Matchers[572]);
                /* 127 PlainRuleOp      */ _structuralArguments.Set(__Matchers[574]);
                /* 128 PlainRuleOp      */ _namedOrAnonymous.Set(__Matchers[575]);
                /* 129 PlainRuleOp      */ _namedArgument.Set(__Matchers[576]);
                /* 130 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[577]);
                /* 131 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[578]);
                /* 132 PlainRuleOp      */ _sequencedArguments.Set(__Matchers[581]);
                /* 133 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[582]);
                /* 134 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[583]);
                /* 135 PlainRuleOp      */ _objectArgument.Set(__Matchers[584]);
                /* 136 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[585]);
                /* 137 PlainRuleOp      */ _methodDefinition.Set(__Matchers[586]);
                /* 138 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[587]);
                /* 139 PlainRuleOp      */ _neededFunctionSpecifier.Set(__Matchers[588]);
                /* 140 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[589]);
                /* 141 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[590]);
                /* 142 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 143 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[591]);
                /* 144 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[592]);
                /* 145 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[593]);
                /* 146 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[594]);
                /* 147 PlainRuleOp      */ _positionalArguments.Set(__Matchers[595]);
                /* 148 PlainRuleOp      */ _positionalArgument.Set(__Matchers[596]);
                /* 149 PlainRuleOp      */ _spreadArgument.Set(__Matchers[598]);
                /* 150 PlainRuleOp      */ _letExpr.Set(__Matchers[600]);
                /* 151 PlainRuleOp      */ _letVariableList.Set(__Matchers[603]);
                /* 152 PlainRuleOp      */ _letVariable.Set(__Matchers[604]);
                /* 153 PlainRuleOp      */ _switchExpr.Set(__Matchers[605]);
                /* 154 PlainRuleOp      */ _caseExpressions.Set(__Matchers[608]);
                /* 155 PlainRuleOp      */ _caseExpression.Set(__Matchers[612]);
                /* 156 PlainRuleOp      */ _ifExpr.Set(__Matchers[614]);
                /* 157 PlainRuleOp      */ _elseExpression.Set(__Matchers[615]);
                /* 158 PlainRuleOp      */ _thenExpression.Set(__Matchers[617]);
                /* 159 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[618]);
                /* 160 PlainRuleOp      */ _functionExpr.Set(__Matchers[621]);
                /* 161 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[622]);
                /* 162 PlainRuleOp      */ _functionParameters.Set(__Matchers[623]);
                /* 163 PlainRuleOp      */ _functionDefinition.Set(__Matchers[624]);
                /* 164 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[625]);
                /* 165 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[626]);
                /* 166 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 167 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[629]);
                /* 168 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[630]);
                /* 169 PlainRuleOp      */ _expression.Set(__Matchers[631]);
                /* 170 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 171 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[632]);
                /* 172 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[633]);
                /* 173 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[645]);
                /* 174 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[646]);
                /* 175 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[647]);
                /* 176 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[648]);
                /* 177 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[649]);
                /* 178 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[650]);
                /* 179 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[651]);
                /* 180 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[652]);
                /* 181 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[653]);
                /* 182 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[654]);
                /* 183 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[655]);
                /* 184 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[656]);
                /* 185 PlainRuleOp      */ _notOperator.Set(__Matchers[657]);
                /* 186 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[658]);
                /* 187 PlainRuleOp      */ _equalityExpression.Set(__Matchers[659]);
                /* 188 PlainRuleOp      */ _equalityExpr.Set(__Matchers[660]);
                /* 189 PlainRuleOp      */ _equalityOperator.Set(__Matchers[664]);
                /* 190 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[665]);
                /* 191 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[666]);
                /* 192 PlainRuleOp      */ _largerExpr.Set(__Matchers[667]);
                /* 193 PlainRuleOp      */ _smallerExpr.Set(__Matchers[668]);
                /* 194 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[669]);
                /* 195 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[670]);
                /* 196 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[671]);
                /* 197 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[673]);
                /* 198 PlainRuleOp      */ _smallerOperator.Set(__Matchers[675]);
                /* 199 PlainRuleOp      */ _largerOperator.Set(__Matchers[677]);
                /* 200 PlainRuleOp      */ _typeOperator.Set(__Matchers[679]);
                /* 201 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[680]);
                /* 202 PlainRuleOp      */ _existsExpr.Set(__Matchers[682]);
                /* 203 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[684]);
                /* 204 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[685]);
                /* 205 PlainRuleOp      */ _rangeExpr.Set(__Matchers[686]);
                /* 206 PlainRuleOp      */ _entryExpr.Set(__Matchers[687]);
                /* 207 PlainRuleOp      */ _rangeOperator.Set(__Matchers[689]);
                /* 208 PlainRuleOp      */ _entryOperator.Set(__Matchers[416]);
                /* 209 PlainRuleOp      */ _additiveExpression.Set(__Matchers[690]);
                /* 210 PlainRuleOp      */ _additiveExpr.Set(__Matchers[691]);
                /* 211 PlainRuleOp      */ _additiveOperator.Set(__Matchers[694]);
                /* 212 PlainRuleOp      */ _scaleExpression.Set(__Matchers[695]);
                /* 213 PlainRuleOp      */ _scaleExpr.Set(__Matchers[696]);
                /* 214 PlainRuleOp      */ _scaleOperator.Set(__Matchers[697]);
                /* 215 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[698]);
                /* 216 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[699]);
                /* 217 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[702]);
                /* 218 PlainRuleOp      */ _unionExpression.Set(__Matchers[703]);
                /* 219 PlainRuleOp      */ _unionExpr.Set(__Matchers[704]);
                /* 220 PlainRuleOp      */ _unionOperator.Set(__Matchers[706]);
                /* 221 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[707]);
                /* 222 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[708]);
                /* 223 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[709]);
                /* 224 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[710]);
                /* 225 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[711]);
                /* 226 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[712]);
                /* 227 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[713]);
                /* 228 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[714]);
                /* 229 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[715]);
                /* 230 PlainRuleOp      */ _negateOperator.Set(__Matchers[717]);
                /* 231 PlainRuleOp      */ _neutralOperator.Set(__Matchers[719]);
                /* 232 PlainRuleOp      */ _complementOperator.Set(__Matchers[705]);
                /* 233 PlainRuleOp      */ _prefixExpression.Set(__Matchers[720]);
                /* 234 PlainRuleOp      */ _prefixExpr.Set(__Matchers[721]);
                /* 235 PlainRuleOp      */ _postfixExpression.Set(__Matchers[722]);
                /* 236 PlainRuleOp      */ _postfixExpr.Set(__Matchers[723]);
                /* 237 PlainRuleOp      */ _incrementOperator.Set(__Matchers[726]);
                /* 238 PlainRuleOp      */ _primary.Set(__Matchers[727]);
                /* 239 PlainRuleOp      */ _selectionExpr.Set(__Matchers[728]);
                /* 240 PlainRuleOp      */ _qualifiedReference.Set(__Matchers[729]);
                /* 241 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[732]);
                /* 242 PlainRuleOp      */ _indexedExpr.Set(__Matchers[733]);
                /* 243 PlainRuleOp      */ _index.Set(__Matchers[734]);
                /* 244 PlainRuleOp      */ _upperSpanned.Set(__Matchers[735]);
                /* 245 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[736]);
                /* 246 PlainRuleOp      */ _spanned.Set(__Matchers[737]);
                /* 247 PlainRuleOp      */ _measured.Set(__Matchers[738]);
                /* 248 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 249 PlainRuleOp      */ _callExpr.Set(__Matchers[739]);
                /* 250 PlainRuleOp      */ _baseExpression.Set(__Matchers[740]);
                /* 251 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[741]);
                /* 252 PlainRuleOp      */ _stringExpression.Set(__Matchers[742]);
                /* 253 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[744]);
                /* 254 PlainRuleOp      */ _interpolationPart.Set(__Matchers[745]);
                /* 255 PlainRuleOp      */ _stringLiteral.Set(__Matchers[746]);
                /* 256 PlainRuleOp      */ _objectExpr.Set(__Matchers[747]);
                /* 257 PlainRuleOp      */ _groupedExpr.Set(__Matchers[748]);
                /* 258 PlainRuleOp      */ _typeArguments.Set(__Matchers[750]);
                /* 259 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[753]);
                /* 260 PlainRuleOp      */ _variancedType.Set(__Matchers[754]);
                /* 261 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[757]);
                /* 262 PlainRuleOp      */ _defaultedType.Set(__Matchers[758]);
                /* 263 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[759]);
                /* 264 PlainRuleOp      */ _variadicType.Set(__Matchers[760]);
                /* 265 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[761]);
                /* 266 PlainRuleOp      */ _variadicOperator.Set(__Matchers[762]);
                /* 267 PlainRuleOp      */ _spreadType.Set(__Matchers[763]);
                /* 268 PlainRuleOp      */ _type.Set(__Matchers[764]);
                /* 269 PlainRuleOp      */ _entryType.Set(__Matchers[765]);
                /* 270 PlainRuleOp      */ _unionType.Set(__Matchers[766]);
                /* 271 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[767]);
                /* 272 PlainRuleOp      */ _intersectionType.Set(__Matchers[768]);
                /* 273 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[769]);
                /* 274 PlainRuleOp      */ _primaryType.Set(__Matchers[770]);
                /* 275 PlainRuleOp      */ _nullableType.Set(__Matchers[772]);
                /* 276 PlainRuleOp      */ _arrayType.Set(__Matchers[774]);
                /* 277 PlainRuleOp      */ _functionType.Set(__Matchers[776]);
                /* 278 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[777]);
                /* 279 PlainRuleOp      */ _tupleType.Set(__Matchers[778]);
                /* 280 PlainRuleOp      */ _iterableType.Set(__Matchers[780]);
                /* 281 PlainRuleOp      */ _groupedType.Set(__Matchers[781]);
                /* 282 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[782]);
                /* 283 PlainRuleOp      */ _annotations.Set(__Matchers[785]);
                /* 284 PlainRuleOp      */ _annotation.Set(__Matchers[786]);
                /* 285 PlainRuleOp      */ _conditions.Set(__Matchers[788]);
                /* 286 PlainRuleOp      */ _conditionList.Set(__Matchers[791]);
                /* 287 PlainRuleOp      */ _condition.Set(__Matchers[792]);
                /* 288 PlainRuleOp      */ _existsCondition.Set(__Matchers[794]);
                /* 289 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[795]);
                /* 290 PlainRuleOp      */ _letOrExpression.Set(__Matchers[796]);
                /* 291 PlainRuleOp      */ _isCondition.Set(__Matchers[797]);
                /* 292 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[798]);
                /* 293 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[799]);
                /* 294 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 295 PlainRuleOp      */ _controlStatement.Set(__Matchers[800]);
                /* 296 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[802]);
                /* 297 PlainRuleOp      */ _ifBlock.Set(__Matchers[803]);
                /* 298 PlainRuleOp      */ _elseBlock.Set(__Matchers[804]);
                /* 299 PlainRuleOp      */ _elseBlockNext.Set(__Matchers[805]);
                /* 300 PlainRuleOp      */ _switchStatement.Set(__Matchers[807]);
                /* 301 PlainRuleOp      */ _switchHeader.Set(__Matchers[809]);
                /* 302 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 303 PlainRuleOp      */ _caseBlock.Set(__Matchers[810]);
                /* 304 PlainRuleOp      */ _caseItem.Set(__Matchers[811]);
                /* 305 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[813]);
                /* 306 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[814]);
                /* 307 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 308 PlainRuleOp      */ _valueCaseList.Set(__Matchers[817]);
                /* 309 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[818]);
                /* 310 PlainRuleOp      */ _valueCase.Set(__Matchers[819]);
                /* 311 PlainRuleOp      */ _forElseStatement.Set(__Matchers[821]);
                /* 312 PlainRuleOp      */ _forBlock.Set(__Matchers[822]);
                /* 313 PlainRuleOp      */ _failBlock.Set(__Matchers[823]);
                /* 314 PlainRuleOp      */ _forIterator.Set(__Matchers[825]);
                /* 315 PlainRuleOp      */ _forVariable.Set(__Matchers[826]);
                /* 316 PlainRuleOp      */ _containment.Set(__Matchers[827]);
                /* 317 PlainRuleOp      */ _containmentOperator.Set(__Matchers[828]);
                /* 318 PlainRuleOp      */ _whileStatement.Set(__Matchers[830]);
                /* 319 PlainRuleOp      */ _tryStatement.Set(__Matchers[833]);
                /* 320 PlainRuleOp      */ _tryBlock.Set(__Matchers[836]);
                /* 321 PlainRuleOp      */ _catchBlock.Set(__Matchers[838]);
                /* 322 PlainRuleOp      */ _catchVariable.Set(__Matchers[840]);
                /* 323 PlainRuleOp      */ _finallyBlock.Set(__Matchers[842]);
                /* 324 PlainRuleOp      */ _resources.Set(__Matchers[844]);
                /* 325 PlainRuleOp      */ _resourceList.Set(__Matchers[847]);
                /* 326 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 327 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[848]);
                /* 328 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[849]);
                /* 329 PlainRuleOp      */ _variable.Set(__Matchers[852]);
                /* 330 PlainRuleOp      */ _variableType.Set(__Matchers[853]);
                /* 331 PlainRuleOp      */ _modelReference.Set(__Matchers[854]);
                /* 332 PlainRuleOp      */ _metaLiteral.Set(__Matchers[856]);
                /* 333 PlainRuleOp      */ _metaExpression.Set(__Matchers[857]);
                /* 334 PlainRuleOp      */ _modelExpression.Set(__Matchers[858]);
                /* 335 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[859]);
                /* 336 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[860]);
                /* 337 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[861]);
                /* 338 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 339 PlainRuleOp      */ _declarationReference.Set(__Matchers[862]);
                /* 340 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[864]);
                /* 341 PlainRuleOp      */ _packageLiteral.Set(__Matchers[865]);
                /* 342 PlainRuleOp      */ _classLiteral.Set(__Matchers[866]);
                /* 343 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[867]);
                /* 344 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[868]);
                /* 345 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[869]);
                /* 346 PlainRuleOp      */ _newLiteral.Set(__Matchers[870]);
                /* 347 PlainRuleOp      */ _valueLiteral.Set(__Matchers[871]);
                /* 348 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[872]);
                /* 349 PlainRuleOp      */ _functionLiteral.Set(__Matchers[873]);
                /* 350 PlainRuleOp      */ _referencePath.Set(__Matchers[874]);
                /* 351 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[877]);
                /* 352 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 353 PlainRuleOp      */ _kwVoid.Set(__Matchers[521]);
                /* 354 PlainRuleOp      */ _kwFunction.Set(__Matchers[523]);
                /* 355 PlainRuleOp      */ _kwValue.Set(__Matchers[526]);
                /* 356 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 357 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 358 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 359 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 360 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 361 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 362 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 363 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 364 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 365 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 366 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 368 SeqOp            */ __Matchers[368].Set(_compilationUnit, __Matchers[367]);
                /* 369 AltOp            */ __Matchers[369].Set(_moduleDescriptor, _packageDescriptor, _unitElements);
                /* 370 StarOp           */ __Matchers[370].Set(_declaration);
                /* 371 SeqOp            */ __Matchers[371].Set(_importDeclarations, __Matchers[370]);
                /* 372 StarOp           */ __Matchers[372].Set(_importDeclaration);
                /* 374 OptionalOp       */ __Matchers[374].Set(_moduleSpecifier);
                /* 375 OptionalOp       */ __Matchers[375].Set(_version);
                /* 376 SeqOp            */ __Matchers[376].Set(_annotations, __Matchers[373], _moduleName, __Matchers[374], __Matchers[375], _moduleBody);
                /* 378 OptionalOp       */ __Matchers[378].Set(_artifactAndClassifier);
                /* 379 SeqOp            */ __Matchers[379].Set(_repository, __Matchers[377], _module, __Matchers[378]);
                /* 380 AltOp            */ __Matchers[380].Set(_literalString, _moduleName);
                /* 381 OptionalOp       */ __Matchers[381].Set(_classifier);
                /* 382 SeqOp            */ __Matchers[382].Set(_artifact, __Matchers[381]);
                /* 383 SeqOp            */ __Matchers[383].Set(__Matchers[377], _literalString);
                /* 384 SeqOp            */ __Matchers[384].Set(__Matchers[377], _literalString);
                /* 386 StarOp           */ __Matchers[386].Set(_moduleBodyElement);
                /* 388 SeqOp            */ __Matchers[388].Set(__Matchers[385], __Matchers[386], __Matchers[387]);
                /* 389 AltOp            */ __Matchers[389].Set(_inferredAttributeDeclaration, _importModule);
                /* 392 SeqOp            */ __Matchers[392].Set(_annotations, __Matchers[390], _packagePath, __Matchers[391]);
                /* 394 SeqOp            */ __Matchers[394].Set(_annotations, __Matchers[393], _module, __Matchers[375], __Matchers[391]);
                /* 395 SeqOp            */ __Matchers[395].Set(__Matchers[393], _packagePath, _importElements);
                /* 396 OptionalOp       */ __Matchers[396].Set(_importElementList);
                /* 397 SeqOp            */ __Matchers[397].Set(__Matchers[385], __Matchers[396], __Matchers[387]);
                /* 399 SeqOp            */ __Matchers[399].Set(__Matchers[398], _importElement);
                /* 400 StarOp           */ __Matchers[400].Set(__Matchers[399]);
                /* 401 SeqOp            */ __Matchers[401].Set(_importElement, __Matchers[400]);
                /* 402 AltOp            */ __Matchers[402].Set(_importNamed, _importWildcard);
                /* 403 OptionalOp       */ __Matchers[403].Set(_importNameSpecifier);
                /* 404 OptionalOp       */ __Matchers[404].Set(_importElements);
                /* 405 SeqOp            */ __Matchers[405].Set(_importName, __Matchers[403], __Matchers[404]);
                /* 407 SeqOp            */ __Matchers[407].Set(__Matchers[406], _identifier);
                /* 410 SeqOp            */ __Matchers[410].Set(__Matchers[409], _packageName);
                /* 411 StarOp           */ __Matchers[411].Set(__Matchers[410]);
                /* 412 SeqOp            */ __Matchers[412].Set(_packageName, __Matchers[411]);
                /* 413 AltOp            */ __Matchers[413].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 414 AltOp            */ __Matchers[414].Set(_tuplePattern, _variablePattern);
                /* 415 AltOp            */ __Matchers[415].Set(_entryPattern, _tuplePattern);
                /* 417 SeqOp            */ __Matchers[417].Set(_variableOrTuplePattern, __Matchers[416], _variableOrTuplePattern);
                /* 419 OptionalOp       */ __Matchers[419].Set(_variadicPatternList);
                /* 421 SeqOp            */ __Matchers[421].Set(__Matchers[418], __Matchers[419], __Matchers[420]);
                /* 422 SeqOp            */ __Matchers[422].Set(__Matchers[398], _variadicPattern);
                /* 423 StarOp           */ __Matchers[423].Set(__Matchers[422]);
                /* 424 SeqOp            */ __Matchers[424].Set(_variadicPattern, __Matchers[423]);
                /* 425 AltOp            */ __Matchers[425].Set(_variadicVariable, _pattern);
                /* 426 OptionalOp       */ __Matchers[426].Set(_unionType);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[426], _variadicOperator, _memberName);
                /* 431 SeqOp            */ __Matchers[431].Set(__Matchers[428], __Matchers[429], _letVariableList, __Matchers[430]);
                /* 433 SeqOp            */ __Matchers[433].Set(__Matchers[432], _classInstatiation);
                /* 434 OptionalOp       */ __Matchers[434].Set(_assertionMessage);
                /* 436 SeqOp            */ __Matchers[436].Set(__Matchers[434], __Matchers[435], _conditions);
                /* 437 StarOp           */ __Matchers[437].Set(_declarationOrStatement);
                /* 438 SeqOp            */ __Matchers[438].Set(__Matchers[385], _importDeclarations, __Matchers[437], __Matchers[387]);
                /* 439 SeqOp            */ __Matchers[439].Set(__Matchers[432], _classInstatiation);
                /* 441 SeqOp            */ __Matchers[441].Set(__Matchers[440], _classInstatiation);
                /* 442 OptionalOp       */ __Matchers[442].Set(_arguments);
                /* 443 SeqOp            */ __Matchers[443].Set(_qualifiedClass, __Matchers[442]);
                /* 444 AltOp            */ __Matchers[444].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 446 SeqOp            */ __Matchers[446].Set(__Matchers[445], __Matchers[409], _baseReference);
                /* 447 SeqOp            */ __Matchers[447].Set(__Matchers[390], __Matchers[409], _unQualifiedClass);
                /* 448 SeqOp            */ __Matchers[448].Set(__Matchers[390], __Matchers[409]);
                /* 449 AltOp            */ __Matchers[449].Set(_memberPath, _typePath, _memberReference);
                /* 450 SeqOp            */ __Matchers[450].Set(_typePath, __Matchers[409], _memberReference);
                /* 451 SeqOp            */ __Matchers[451].Set(__Matchers[409], _typeReference);
                /* 452 StarOp           */ __Matchers[452].Set(__Matchers[451]);
                /* 453 SeqOp            */ __Matchers[453].Set(_typeReference, __Matchers[452]);
                /* 455 SeqOp            */ __Matchers[455].Set(__Matchers[454], _unionTypeList);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[398], _unionType);
                /* 457 StarOp           */ __Matchers[457].Set(__Matchers[456]);
                /* 458 SeqOp            */ __Matchers[458].Set(_unionType, __Matchers[457]);
                /* 460 SeqOp            */ __Matchers[460].Set(__Matchers[459], _caseTypeList);
                /* 462 SeqOp            */ __Matchers[462].Set(__Matchers[461], _caseType);
                /* 463 StarOp           */ __Matchers[463].Set(__Matchers[462]);
                /* 464 SeqOp            */ __Matchers[464].Set(_caseType, __Matchers[463]);
                /* 465 AltOp            */ __Matchers[465].Set(_primaryType, _qualifiedCaseType);
                /* 466 OptionalOp       */ __Matchers[466].Set(_packageQualifier);
                /* 467 SeqOp            */ __Matchers[467].Set(__Matchers[466], _memberName);
                /* 468 OptionalOp       */ __Matchers[468].Set(_parameterList);
                /* 469 SeqOp            */ __Matchers[469].Set(__Matchers[429], __Matchers[468], __Matchers[430]);
                /* 470 SeqOp            */ __Matchers[470].Set(__Matchers[398], _parameterDeclarationOrRefPattern);
                /* 471 StarOp           */ __Matchers[471].Set(__Matchers[470]);
                /* 472 SeqOp            */ __Matchers[472].Set(_parameterDeclarationOrRefPattern, __Matchers[471]);
                /* 473 AltOp            */ __Matchers[473].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 474 SeqOp            */ __Matchers[474].Set(_annotations, _parameterDeclaration);
                /* 475 OptionalOp       */ __Matchers[475].Set(_valueSpecifier);
                /* 476 SeqOp            */ __Matchers[476].Set(_memberName, __Matchers[475]);
                /* 477 AltOp            */ __Matchers[477].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 478 OptionalOp       */ __Matchers[478].Set(_typeParameters);
                /* 479 PlusOp           */ __Matchers[479].Set(_parameters);
                /* 480 OptionalOp       */ __Matchers[480].Set(_functionSpecifier);
                /* 481 SeqOp            */ __Matchers[481].Set(_functionParameterType, _memberName, __Matchers[478], __Matchers[479], __Matchers[480]);
                /* 482 AltOp            */ __Matchers[482].Set(_variadicType, _kwVoid, _kwFunction);
                /* 483 SeqOp            */ __Matchers[483].Set(_valueParameterType, _memberName, __Matchers[475]);
                /* 484 AltOp            */ __Matchers[484].Set(_variadicType, _kwValue);
                /* 487 SeqOp            */ __Matchers[487].Set(__Matchers[485], _typeParameterList, __Matchers[486]);
                /* 488 SeqOp            */ __Matchers[488].Set(__Matchers[398], _typeParameter);
                /* 489 StarOp           */ __Matchers[489].Set(__Matchers[488]);
                /* 490 SeqOp            */ __Matchers[490].Set(_typeParameter, __Matchers[489]);
                /* 491 OptionalOp       */ __Matchers[491].Set(_variance);
                /* 492 OptionalOp       */ __Matchers[492].Set(_typeDefault);
                /* 493 SeqOp            */ __Matchers[493].Set(__Matchers[491], _typeName, __Matchers[492]);
                /* 496 AltOp            */ __Matchers[496].Set(__Matchers[494], __Matchers[495]);
                /* 497 SeqOp            */ __Matchers[497].Set(__Matchers[406], _type);
                /* 499 OptionalOp       */ __Matchers[499].Set(_typeName);
                /* 500 OptionalOp       */ __Matchers[500].Set(_caseTypes);
                /* 501 OptionalOp       */ __Matchers[501].Set(_satisfiedTypes);
                /* 502 SeqOp            */ __Matchers[502].Set(__Matchers[498], __Matchers[499], __Matchers[478], __Matchers[500], __Matchers[501]);
                /* 503 PlusOp           */ __Matchers[503].Set(_typeConstraint);
                /* 504 AltOp            */ __Matchers[504].Set(_declaration, _statement);
                /* 505 AltOp            */ __Matchers[505].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 507 OptionalOp       */ __Matchers[507].Set(_memberName);
                /* 508 OptionalOp       */ __Matchers[508].Set(_delegatedConstructor);
                /* 509 SeqOp            */ __Matchers[509].Set(_annotations, __Matchers[506], __Matchers[507], _parameters, __Matchers[508], _block);
                /* 511 OptionalOp       */ __Matchers[511].Set(_typeConstraints);
                /* 512 SeqOp            */ __Matchers[512].Set(_annotations, __Matchers[510], _typeName, __Matchers[478], __Matchers[511], _optionalTypeSpecifier);
                /* 513 SeqOp            */ __Matchers[513].Set(_annotations, __Matchers[506], _memberName, __Matchers[508], _block);
                /* 515 OptionalOp       */ __Matchers[515].Set(_extendedType);
                /* 516 SeqOp            */ __Matchers[516].Set(_annotations, __Matchers[514], _memberName, __Matchers[515], __Matchers[501], _classBlock);
                /* 518 SeqOp            */ __Matchers[518].Set(_annotations, __Matchers[517], _memberName, _setterDefinition);
                /* 519 AltOp            */ __Matchers[519].Set(_block, _neededFunctionSpecifier);
                /* 520 SeqOp            */ __Matchers[520].Set(_annotations, _variadicType, _parametrizedMember, __Matchers[511], _methodDefinition);
                /* 522 SeqOp            */ __Matchers[522].Set(_annotations, __Matchers[521], _parametrizedMember, __Matchers[511], _methodDefinition);
                /* 524 SeqOp            */ __Matchers[524].Set(_annotations, __Matchers[523], _parametrizedMember, __Matchers[511], _methodDefinition);
                /* 525 SeqOp            */ __Matchers[525].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 527 SeqOp            */ __Matchers[527].Set(_annotations, __Matchers[526], _memberName, _attributeDefinition);
                /* 528 AltOp            */ __Matchers[528].Set(_block, _optionalAnySpecifier);
                /* 529 OptionalOp       */ __Matchers[529].Set(_anySpecifier);
                /* 530 SeqOp            */ __Matchers[530].Set(__Matchers[529], __Matchers[391]);
                /* 532 OptionalOp       */ __Matchers[532].Set(_parameters);
                /* 533 SeqOp            */ __Matchers[533].Set(_annotations, __Matchers[531], _typeName, __Matchers[478], __Matchers[532], __Matchers[500], __Matchers[515], __Matchers[501], __Matchers[511], _classDefinition);
                /* 534 AltOp            */ __Matchers[534].Set(_classBlock, _optionalClassSpecifier);
                /* 535 OptionalOp       */ __Matchers[535].Set(_classSpecifier);
                /* 536 SeqOp            */ __Matchers[536].Set(__Matchers[535], __Matchers[391]);
                /* 538 SeqOp            */ __Matchers[538].Set(_annotations, __Matchers[537], _typeName, __Matchers[478], __Matchers[500], __Matchers[501], __Matchers[511], _interfaceDefinition);
                /* 539 AltOp            */ __Matchers[539].Set(_interfaceBlock, _optionalTypeSpecifier);
                /* 540 OptionalOp       */ __Matchers[540].Set(_typeSpecifier);
                /* 541 SeqOp            */ __Matchers[541].Set(__Matchers[540], __Matchers[391]);
                /* 542 AltOp            */ __Matchers[542].Set(_unclosedStatement, _controlStatement);
                /* 543 SeqOp            */ __Matchers[543].Set(_openStatement, __Matchers[391]);
                /* 544 AltOp            */ __Matchers[544].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 545 SeqOp            */ __Matchers[545].Set(_primary, _functionSpecifier);
                /* 546 AltOp            */ __Matchers[546].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 548 OptionalOp       */ __Matchers[548].Set(_expression);
                /* 549 SeqOp            */ __Matchers[549].Set(__Matchers[547], __Matchers[548]);
                /* 551 SeqOp            */ __Matchers[551].Set(__Matchers[550], __Matchers[548]);
                /* 554 SeqOp            */ __Matchers[554].Set(__Matchers[440], _type);
                /* 555 SeqOp            */ __Matchers[555].Set(__Matchers[406], _expression);
                /* 556 SeqOp            */ __Matchers[556].Set(__Matchers[440], _expression);
                /* 557 AltOp            */ __Matchers[557].Set(_valueSpecifier, _functionSpecifier);
                /* 558 AltOp            */ __Matchers[558].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 559 AltOp            */ __Matchers[559].Set(_memberReference, _typeReference);
                /* 560 SeqOp            */ __Matchers[560].Set(_memberName, __Matchers[478], __Matchers[479]);
                /* 561 SeqOp            */ __Matchers[561].Set(_selfReferenceSelector, _parametrizedMember);
                /* 562 OptionalOp       */ __Matchers[562].Set(_typeArguments);
                /* 563 SeqOp            */ __Matchers[563].Set(_memberName, __Matchers[562]);
                /* 564 SeqOp            */ __Matchers[564].Set(_typeName, __Matchers[562]);
                /* 565 SeqOp            */ __Matchers[565].Set(_selfReference, _memberSelectionOperator);
                /* 568 AltOp            */ __Matchers[568].Set(__Matchers[566], __Matchers[445], __Matchers[567], __Matchers[390]);
                /* 569 OptionalOp       */ __Matchers[569].Set(_sequencedArguments);
                /* 570 SeqOp            */ __Matchers[570].Set(__Matchers[385], __Matchers[437], __Matchers[569], __Matchers[387]);
                /* 571 SeqOp            */ __Matchers[571].Set(__Matchers[418], __Matchers[569], __Matchers[420]);
                /* 572 AltOp            */ __Matchers[572].Set(_structuralArguments, _positionalArguments);
                /* 573 StarOp           */ __Matchers[573].Set(_namedOrAnonymous);
                /* 574 SeqOp            */ __Matchers[574].Set(__Matchers[385], __Matchers[573], __Matchers[569], __Matchers[387]);
                /* 575 AltOp            */ __Matchers[575].Set(_namedArgument, _anonymousArgument);
                /* 576 AltOp            */ __Matchers[576].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 577 SeqOp            */ __Matchers[577].Set(_expression, __Matchers[391]);
                /* 578 SeqOp            */ __Matchers[578].Set(_memberName, _valueSpecifier, __Matchers[391]);
                /* 579 SeqOp            */ __Matchers[579].Set(__Matchers[398], _sequencedArgument);
                /* 580 StarOp           */ __Matchers[580].Set(__Matchers[579]);
                /* 581 SeqOp            */ __Matchers[581].Set(_sequencedArgument, __Matchers[580]);
                /* 582 AltOp            */ __Matchers[582].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 583 AltOp            */ __Matchers[583].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 584 SeqOp            */ __Matchers[584].Set(__Matchers[514], __Matchers[507], __Matchers[515], __Matchers[501], _classBlock);
                /* 585 SeqOp            */ __Matchers[585].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 586 AltOp            */ __Matchers[586].Set(_block, _optionalFunctionSpecifier);
                /* 587 SeqOp            */ __Matchers[587].Set(__Matchers[480], __Matchers[391]);
                /* 588 SeqOp            */ __Matchers[588].Set(_functionSpecifier, __Matchers[391]);
                /* 589 AltOp            */ __Matchers[589].Set(_type, _kwVoid);
                /* 590 SeqOp            */ __Matchers[590].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 591 SeqOp            */ __Matchers[591].Set(__Matchers[523], __Matchers[507], __Matchers[478], _parameters, _methodDefinition);
                /* 592 SeqOp            */ __Matchers[592].Set(__Matchers[526], _memberName, _methodDefinition);
                /* 593 SeqOp            */ __Matchers[593].Set(_memberName, __Matchers[479], _neededFunctionSpecifier);
                /* 594 SeqOp            */ __Matchers[594].Set(_memberName, _neededFunctionSpecifier);
                /* 595 SeqOp            */ __Matchers[595].Set(__Matchers[429], __Matchers[569], __Matchers[430]);
                /* 596 AltOp            */ __Matchers[596].Set(_expression, _declarationReference);
                /* 598 SeqOp            */ __Matchers[598].Set(__Matchers[597], _unionExpression);
                /* 599 OptionalOp       */ __Matchers[599].Set(_letVariableList);
                /* 600 SeqOp            */ __Matchers[600].Set(__Matchers[428], __Matchers[429], __Matchers[599], __Matchers[430], _conditionalExpression);
                /* 601 SeqOp            */ __Matchers[601].Set(__Matchers[398], _letVariable);
                /* 602 StarOp           */ __Matchers[602].Set(__Matchers[601]);
                /* 603 SeqOp            */ __Matchers[603].Set(_letVariable, __Matchers[602]);
                /* 604 SeqOp            */ __Matchers[604].Set(_pattern, _valueSpecifier);
                /* 605 SeqOp            */ __Matchers[605].Set(_switchHeader, _caseExpressions);
                /* 606 PlusOp           */ __Matchers[606].Set(_caseExpression);
                /* 607 OptionalOp       */ __Matchers[607].Set(_elseExpression);
                /* 608 SeqOp            */ __Matchers[608].Set(__Matchers[606], __Matchers[607]);
                /* 610 OptionalOp       */ __Matchers[610].Set(__Matchers[609]);
                /* 612 SeqOp            */ __Matchers[612].Set(__Matchers[610], __Matchers[611], __Matchers[429], _caseItem, __Matchers[430], _conditionalExpression);
                /* 614 SeqOp            */ __Matchers[614].Set(__Matchers[613], _conditions, _thenExpression, _elseExpression);
                /* 615 SeqOp            */ __Matchers[615].Set(__Matchers[609], _conditionalExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[616], _conditionalExpression);
                /* 618 AltOp            */ __Matchers[618].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 619 OptionalOp       */ __Matchers[619].Set(_functionExpressionType);
                /* 620 OptionalOp       */ __Matchers[620].Set(_functionParameters);
                /* 621 SeqOp            */ __Matchers[621].Set(__Matchers[619], __Matchers[478], __Matchers[620], _functionDefinition);
                /* 622 AltOp            */ __Matchers[622].Set(__Matchers[521], __Matchers[523]);
                /* 623 SeqOp            */ __Matchers[623].Set(__Matchers[479], __Matchers[511]);
                /* 624 AltOp            */ __Matchers[624].Set(_block, _functionSpecifier);
                /* 625 AltOp            */ __Matchers[625].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 626 AltOp            */ __Matchers[626].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 628 OptionalOp       */ __Matchers[628].Set(_forIterator);
                /* 629 SeqOp            */ __Matchers[629].Set(__Matchers[627], __Matchers[429], __Matchers[628], __Matchers[430], _comprehensionClause);
                /* 630 SeqOp            */ __Matchers[630].Set(__Matchers[613], _conditions, _comprehensionClause);
                /* 631 AltOp            */ __Matchers[631].Set(_letExpr, _ifExpr, _switchExpr, _functionExpr, _operatorExpression);
                /* 632 AltOp            */ __Matchers[632].Set(_assignmentExpr, _thenElseExpression);
                /* 633 SeqOp            */ __Matchers[633].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 645 AltOp            */ __Matchers[645].Set(__Matchers[406], __Matchers[634], __Matchers[635], __Matchers[636], __Matchers[637], __Matchers[638], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644]);
                /* 646 AltOp            */ __Matchers[646].Set(_thenElseExpr, _disjunctionExpression);
                /* 647 SeqOp            */ __Matchers[647].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 648 AltOp            */ __Matchers[648].Set(__Matchers[609], __Matchers[616]);
                /* 649 AltOp            */ __Matchers[649].Set(_disjunctionExpr, _conjunctionExpression);
                /* 650 SeqOp            */ __Matchers[650].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 652 AltOp            */ __Matchers[652].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 653 SeqOp            */ __Matchers[653].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 655 AltOp            */ __Matchers[655].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 656 SeqOp            */ __Matchers[656].Set(_notOperator, _logicalNegationExpression);
                /* 658 AltOp            */ __Matchers[658].Set(_equalityExpression, _modelReference);
                /* 659 AltOp            */ __Matchers[659].Set(_equalityExpr, _comparisonExpression);
                /* 660 SeqOp            */ __Matchers[660].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 664 AltOp            */ __Matchers[664].Set(__Matchers[661], __Matchers[662], __Matchers[663]);
                /* 665 AltOp            */ __Matchers[665].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 666 SeqOp            */ __Matchers[666].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 667 SeqOp            */ __Matchers[667].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 668 SeqOp            */ __Matchers[668].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 669 SeqOp            */ __Matchers[669].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 670 SeqOp            */ __Matchers[670].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 673 AltOp            */ __Matchers[673].Set(__Matchers[672], __Matchers[494]);
                /* 675 AltOp            */ __Matchers[675].Set(__Matchers[674], __Matchers[485]);
                /* 677 AltOp            */ __Matchers[677].Set(__Matchers[676], __Matchers[486]);
                /* 679 AltOp            */ __Matchers[679].Set(__Matchers[678], __Matchers[432], __Matchers[454], __Matchers[459]);
                /* 680 AltOp            */ __Matchers[680].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 682 SeqOp            */ __Matchers[682].Set(_entryRangeExpression, __Matchers[681]);
                /* 684 SeqOp            */ __Matchers[684].Set(_entryRangeExpression, __Matchers[683]);
                /* 685 AltOp            */ __Matchers[685].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 686 SeqOp            */ __Matchers[686].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 687 SeqOp            */ __Matchers[687].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 689 AltOp            */ __Matchers[689].Set(__Matchers[688], __Matchers[377]);
                /* 690 AltOp            */ __Matchers[690].Set(_additiveExpr, _scaleExpression);
                /* 691 SeqOp            */ __Matchers[691].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 694 AltOp            */ __Matchers[694].Set(__Matchers[692], __Matchers[693]);
                /* 695 AltOp            */ __Matchers[695].Set(_scaleExpr, _multiplicativeExpression);
                /* 696 SeqOp            */ __Matchers[696].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 698 AltOp            */ __Matchers[698].Set(_multiplicativeExpr, _unionExpression);
                /* 699 SeqOp            */ __Matchers[699].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 702 AltOp            */ __Matchers[702].Set(__Matchers[597], __Matchers[700], __Matchers[701]);
                /* 703 AltOp            */ __Matchers[703].Set(_unionExpr, _exclusiveExpression);
                /* 704 SeqOp            */ __Matchers[704].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 706 AltOp            */ __Matchers[706].Set(__Matchers[461], __Matchers[705]);
                /* 707 AltOp            */ __Matchers[707].Set(_exclusiveExpr, _intersectionExpression);
                /* 708 SeqOp            */ __Matchers[708].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 710 AltOp            */ __Matchers[710].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 711 SeqOp            */ __Matchers[711].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 713 AltOp            */ __Matchers[713].Set(_negationOrComplementExpr, _prefixExpression);
                /* 714 SeqOp            */ __Matchers[714].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 715 AltOp            */ __Matchers[715].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 716 NotOp            */ __Matchers[716].Set(__Matchers_716_DFA);
                /* 717 SeqOp            */ __Matchers[717].Set(__Matchers[693], __Matchers[716]);
                /* 718 NotOp            */ __Matchers[718].Set(__Matchers_718_DFA);
                /* 719 SeqOp            */ __Matchers[719].Set(__Matchers[692], __Matchers[718]);
                /* 720 AltOp            */ __Matchers[720].Set(_prefixExpr, _postfixExpression);
                /* 721 SeqOp            */ __Matchers[721].Set(_incrementOperator, _prefixExpression);
                /* 722 AltOp            */ __Matchers[722].Set(_postfixExpr, _primary);
                /* 723 SeqOp            */ __Matchers[723].Set(_postfixExpression, _incrementOperator);
                /* 726 AltOp            */ __Matchers[726].Set(__Matchers[724], __Matchers[725]);
                /* 727 AltOp            */ __Matchers[727].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 728 SeqOp            */ __Matchers[728].Set(_primary, _qualifiedReference);
                /* 729 SeqOp            */ __Matchers[729].Set(_memberSelectionOperator, _baseReference);
                /* 732 AltOp            */ __Matchers[732].Set(__Matchers[409], __Matchers[730], __Matchers[731]);
                /* 733 SeqOp            */ __Matchers[733].Set(_primary, __Matchers[418], _index, __Matchers[420]);
                /* 734 AltOp            */ __Matchers[734].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 735 SeqOp            */ __Matchers[735].Set(_indexExpression, __Matchers[408]);
                /* 736 SeqOp            */ __Matchers[736].Set(__Matchers[408], _indexExpression);
                /* 737 SeqOp            */ __Matchers[737].Set(_indexExpression, __Matchers[688], _indexExpression);
                /* 738 SeqOp            */ __Matchers[738].Set(_indexExpression, __Matchers[377], _indexExpression);
                /* 739 SeqOp            */ __Matchers[739].Set(_primary, _arguments);
                /* 740 AltOp            */ __Matchers[740].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 741 AltOp            */ __Matchers[741].Set(_literalNatural, _literalFloat, _literalChar);
                /* 742 AltOp            */ __Matchers[742].Set(_stringLiteral, _stringInterpolation);
                /* 743 StarOp           */ __Matchers[743].Set(_interpolationPart);
                /* 744 SeqOp            */ __Matchers[744].Set(_stringStart, _expression, __Matchers[743], _stringEnd);
                /* 745 SeqOp            */ __Matchers[745].Set(_stringMid, _expression);
                /* 746 AltOp            */ __Matchers[746].Set(_literalString, _verbatimString);
                /* 747 SeqOp            */ __Matchers[747].Set(__Matchers[514], __Matchers[515], __Matchers[501], _classBlock);
                /* 748 SeqOp            */ __Matchers[748].Set(__Matchers[429], _expression, __Matchers[430]);
                /* 749 OptionalOp       */ __Matchers[749].Set(_typeArgumentList);
                /* 750 SeqOp            */ __Matchers[750].Set(__Matchers[485], __Matchers[749], __Matchers[486]);
                /* 751 SeqOp            */ __Matchers[751].Set(__Matchers[398], _variancedType);
                /* 752 StarOp           */ __Matchers[752].Set(__Matchers[751]);
                /* 753 SeqOp            */ __Matchers[753].Set(_variancedType, __Matchers[752]);
                /* 754 SeqOp            */ __Matchers[754].Set(__Matchers[491], _type);
                /* 755 SeqOp            */ __Matchers[755].Set(__Matchers[398], _defaultedType);
                /* 756 StarOp           */ __Matchers[756].Set(__Matchers[755]);
                /* 757 SeqOp            */ __Matchers[757].Set(_defaultedType, __Matchers[756]);
                /* 758 AltOp            */ __Matchers[758].Set(_defaultedTypeCore, _variadicType);
                /* 759 SeqOp            */ __Matchers[759].Set(_type, __Matchers[406]);
                /* 760 AltOp            */ __Matchers[760].Set(_variadicUnionType, _type);
                /* 761 SeqOp            */ __Matchers[761].Set(_unionType, _variadicOperator);
                /* 762 AltOp            */ __Matchers[762].Set(__Matchers[597], __Matchers[692]);
                /* 763 SeqOp            */ __Matchers[763].Set(__Matchers[597], _unionType);
                /* 764 AltOp            */ __Matchers[764].Set(_entryType, _unionType);
                /* 765 SeqOp            */ __Matchers[765].Set(_unionType, __Matchers[416], _unionType);
                /* 766 AltOp            */ __Matchers[766].Set(_unionTypeCore, _intersectionType);
                /* 767 SeqOp            */ __Matchers[767].Set(_unionType, __Matchers[461], _intersectionType);
                /* 768 AltOp            */ __Matchers[768].Set(_intersectionTypeCore, _primaryType);
                /* 769 SeqOp            */ __Matchers[769].Set(_intersectionType, __Matchers[712], _primaryType);
                /* 770 AltOp            */ __Matchers[770].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 772 SeqOp            */ __Matchers[772].Set(_primaryType, __Matchers[771]);
                /* 773 OptionalOp       */ __Matchers[773].Set(_literalNatural);
                /* 774 SeqOp            */ __Matchers[774].Set(_primaryType, __Matchers[418], __Matchers[773], __Matchers[420]);
                /* 775 OptionalOp       */ __Matchers[775].Set(_typeTypeArguments);
                /* 776 SeqOp            */ __Matchers[776].Set(_primaryType, __Matchers[429], __Matchers[775], __Matchers[430]);
                /* 777 AltOp            */ __Matchers[777].Set(_spreadType, _defaultedTypeList);
                /* 778 SeqOp            */ __Matchers[778].Set(__Matchers[418], __Matchers[775], __Matchers[420]);
                /* 779 OptionalOp       */ __Matchers[779].Set(_variadicType);
                /* 780 SeqOp            */ __Matchers[780].Set(__Matchers[385], __Matchers[779], __Matchers[387]);
                /* 781 SeqOp            */ __Matchers[781].Set(__Matchers[485], _type, __Matchers[486]);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[390], __Matchers[409], _typePath);
                /* 783 OptionalOp       */ __Matchers[783].Set(_stringLiteral);
                /* 784 StarOp           */ __Matchers[784].Set(_annotation);
                /* 785 SeqOp            */ __Matchers[785].Set(__Matchers[783], __Matchers[784]);
                /* 786 SeqOp            */ __Matchers[786].Set(_memberName, __Matchers[442]);
                /* 787 OptionalOp       */ __Matchers[787].Set(_conditionList);
                /* 788 SeqOp            */ __Matchers[788].Set(__Matchers[429], __Matchers[787], __Matchers[430]);
                /* 789 SeqOp            */ __Matchers[789].Set(__Matchers[398], _condition);
                /* 790 StarOp           */ __Matchers[790].Set(__Matchers[789]);
                /* 791 SeqOp            */ __Matchers[791].Set(_condition, __Matchers[790]);
                /* 792 AltOp            */ __Matchers[792].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 793 OptionalOp       */ __Matchers[793].Set(__Matchers[657]);
                /* 794 SeqOp            */ __Matchers[794].Set(__Matchers[793], __Matchers[681], _letOrExpression);
                /* 795 SeqOp            */ __Matchers[795].Set(__Matchers[793], __Matchers[683], _letOrExpression);
                /* 796 AltOp            */ __Matchers[796].Set(_letVariable, _operatorExpression);
                /* 797 SeqOp            */ __Matchers[797].Set(__Matchers[793], __Matchers[678], _type, _isConditionVariable);
                /* 798 SeqOp            */ __Matchers[798].Set(_memberName, __Matchers[475]);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[454], _type, _typeName);
                /* 800 AltOp            */ __Matchers[800].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 801 OptionalOp       */ __Matchers[801].Set(_elseBlock);
                /* 802 SeqOp            */ __Matchers[802].Set(_ifBlock, __Matchers[801]);
                /* 803 SeqOp            */ __Matchers[803].Set(__Matchers[613], _conditions, _block);
                /* 804 SeqOp            */ __Matchers[804].Set(__Matchers[609], _elseBlockNext);
                /* 805 AltOp            */ __Matchers[805].Set(_ifElseStatement, _block);
                /* 806 PlusOp           */ __Matchers[806].Set(_caseBlock);
                /* 807 SeqOp            */ __Matchers[807].Set(_switchHeader, __Matchers[806], __Matchers[801]);
                /* 809 SeqOp            */ __Matchers[809].Set(__Matchers[808], __Matchers[429], _switched, __Matchers[430]);
                /* 810 SeqOp            */ __Matchers[810].Set(__Matchers[610], __Matchers[611], __Matchers[429], _caseItem, __Matchers[430], _block);
                /* 811 AltOp            */ __Matchers[811].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 812 OptionalOp       */ __Matchers[812].Set(__Matchers[678]);
                /* 813 SeqOp            */ __Matchers[813].Set(__Matchers[812], _type);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[454], _type);
                /* 815 SeqOp            */ __Matchers[815].Set(_valueCaseSeparator, _valueCase);
                /* 816 StarOp           */ __Matchers[816].Set(__Matchers[815]);
                /* 817 SeqOp            */ __Matchers[817].Set(_valueCase, __Matchers[816]);
                /* 818 AltOp            */ __Matchers[818].Set(__Matchers[398], __Matchers[461]);
                /* 819 AltOp            */ __Matchers[819].Set(_intersectionType, _intersectionExpression);
                /* 820 OptionalOp       */ __Matchers[820].Set(_failBlock);
                /* 821 SeqOp            */ __Matchers[821].Set(_forBlock, __Matchers[820]);
                /* 822 SeqOp            */ __Matchers[822].Set(__Matchers[627], __Matchers[429], __Matchers[628], __Matchers[430], _block);
                /* 823 SeqOp            */ __Matchers[823].Set(__Matchers[609], _block);
                /* 824 OptionalOp       */ __Matchers[824].Set(_containment);
                /* 825 SeqOp            */ __Matchers[825].Set(_forVariable, __Matchers[824]);
                /* 826 AltOp            */ __Matchers[826].Set(_tupleOrEntryPattern, _variable);
                /* 827 SeqOp            */ __Matchers[827].Set(_containmentOperator, _operatorExpression);
                /* 828 AltOp            */ __Matchers[828].Set(__Matchers[494], __Matchers[377]);
                /* 830 SeqOp            */ __Matchers[830].Set(__Matchers[829], _conditions, _block);
                /* 831 StarOp           */ __Matchers[831].Set(_catchBlock);
                /* 832 OptionalOp       */ __Matchers[832].Set(_finallyBlock);
                /* 833 SeqOp            */ __Matchers[833].Set(_tryBlock, __Matchers[831], __Matchers[832]);
                /* 835 OptionalOp       */ __Matchers[835].Set(_resources);
                /* 836 SeqOp            */ __Matchers[836].Set(__Matchers[834], __Matchers[835], _block);
                /* 838 SeqOp            */ __Matchers[838].Set(__Matchers[837], _catchVariable, _block);
                /* 839 OptionalOp       */ __Matchers[839].Set(_variable);
                /* 840 SeqOp            */ __Matchers[840].Set(__Matchers[429], __Matchers[839], __Matchers[430]);
                /* 842 SeqOp            */ __Matchers[842].Set(__Matchers[841], _block);
                /* 843 OptionalOp       */ __Matchers[843].Set(_resourceList);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[429], __Matchers[843], __Matchers[430]);
                /* 845 SeqOp            */ __Matchers[845].Set(__Matchers[398], _resource);
                /* 846 StarOp           */ __Matchers[846].Set(__Matchers[845]);
                /* 847 SeqOp            */ __Matchers[847].Set(_resource, __Matchers[846]);
                /* 848 AltOp            */ __Matchers[848].Set(_specifiedVariable, _operatorExpression);
                /* 849 SeqOp            */ __Matchers[849].Set(_variable, _valueSpecifier);
                /* 850 OptionalOp       */ __Matchers[850].Set(_variableType);
                /* 851 StarOp           */ __Matchers[851].Set(_parameters);
                /* 852 SeqOp            */ __Matchers[852].Set(__Matchers[850], _memberName, __Matchers[851]);
                /* 853 AltOp            */ __Matchers[853].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 854 SeqOp            */ __Matchers[854].Set(__Matchers[709], _modelExpression);
                /* 856 SeqOp            */ __Matchers[856].Set(__Matchers[855], _metaExpression, __Matchers[855]);
                /* 857 AltOp            */ __Matchers[857].Set(_declarationReference, _modelExpression);
                /* 858 AltOp            */ __Matchers[858].Set(_memberModelExpression, _typeModelExpression);
                /* 859 AltOp            */ __Matchers[859].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 860 SeqOp            */ __Matchers[860].Set(__Matchers[390], __Matchers[409], _memberReference);
                /* 861 SeqOp            */ __Matchers[861].Set(_primaryType, __Matchers[409], _memberReference);
                /* 862 AltOp            */ __Matchers[862].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 863 OptionalOp       */ __Matchers[863].Set(_packagePath);
                /* 864 SeqOp            */ __Matchers[864].Set(__Matchers[373], __Matchers[863]);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[390], __Matchers[863]);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[531], _referencePath);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[537], _referencePath);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[510], _referencePath);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[498], _referencePath);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[506], _referencePath);
                /* 871 SeqOp            */ __Matchers[871].Set(_valueLiteralIntro, _referencePath);
                /* 872 AltOp            */ __Matchers[872].Set(__Matchers[526], __Matchers[514]);
                /* 873 SeqOp            */ __Matchers[873].Set(__Matchers[523], _referencePath);
                /* 874 SeqOp            */ __Matchers[874].Set(__Matchers[466], _referencePathElementList);
                /* 875 SeqOp            */ __Matchers[875].Set(__Matchers[409], _referencePathElement);
                /* 876 StarOp           */ __Matchers[876].Set(__Matchers[875]);
                /* 877 SeqOp            */ __Matchers[877].Set(_referencePathElement, __Matchers[876]);

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
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, false)
                );
                __Keywords_DFA.States[0].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(95, 95), new DfaInterval(97, 122)),
                    new DfaTrans(__Keywords_DFA.States[2], new DfaInterval(92, 92))
                );
                __Keywords_DFA.States[1].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                __Keywords_DFA.States[2].Set(
                    new DfaTrans(__Keywords_DFA.States[3], new DfaInterval(105, 105))
                );
                __Keywords_DFA.States[3].Set(
                    new DfaTrans(__Keywords_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _literalFloat_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, true),
                    new DfaState(5, true),
                    new DfaState(6, true)
                );
                _literalFloat_DFA.States[0].Set(
                    new DfaTrans(_literalFloat_DFA.States[1], new DfaInterval(48, 57))
                );
                _literalFloat_DFA.States[1].Set(
                    new DfaTrans(_literalFloat_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(95, 95)),
                    new DfaTrans(_literalFloat_DFA.States[2], new DfaInterval(46, 46)),
                    new DfaTrans(_literalFloat_DFA.States[6], new DfaInterval(102, 102), new DfaInterval(109, 110), new DfaInterval(112, 112), new DfaInterval(117, 117))
                );
                _literalFloat_DFA.States[2].Set(
                    new DfaTrans(_literalFloat_DFA.States[3], new DfaInterval(48, 57))
                );
                _literalFloat_DFA.States[3].Set(
                    new DfaTrans(_literalFloat_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(95, 95)),
                    new DfaTrans(_literalFloat_DFA.States[4], new DfaInterval(69, 69), new DfaInterval(101, 101)),
                    new DfaTrans(_literalFloat_DFA.States[6], new DfaInterval(71, 71), new DfaInterval(77, 77), new DfaInterval(80, 80), new DfaInterval(84, 84), new DfaInterval(102, 102), new DfaInterval(107, 107), new DfaInterval(109, 110), new DfaInterval(112, 112), new DfaInterval(117, 117))
                );
                _literalFloat_DFA.States[4].Set(
                    new DfaTrans(_literalFloat_DFA.States[5], new DfaInterval(43, 43), new DfaInterval(45, 45), new DfaInterval(48, 57))
                );
                _literalFloat_DFA.States[5].Set(
                    new DfaTrans(_literalFloat_DFA.States[5], new DfaInterval(48, 57))
                );
                _literalFloat_DFA.States[6].Set(
                );
                _literalNatural_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, true),
                    new DfaState(3, false),
                    new DfaState(4, true),
                    new DfaState(5, false),
                    new DfaState(6, true)
                );
                _literalNatural_DFA.States[0].Set(
                    new DfaTrans(_literalNatural_DFA.States[1], new DfaInterval(48, 57)),
                    new DfaTrans(_literalNatural_DFA.States[3], new DfaInterval(35, 35)),
                    new DfaTrans(_literalNatural_DFA.States[5], new DfaInterval(36, 36))
                );
                _literalNatural_DFA.States[1].Set(
                    new DfaTrans(_literalNatural_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(95, 95)),
                    new DfaTrans(_literalNatural_DFA.States[2], new DfaInterval(71, 71), new DfaInterval(77, 77), new DfaInterval(80, 80), new DfaInterval(84, 84), new DfaInterval(107, 107))
                );
                _literalNatural_DFA.States[2].Set(
                );
                _literalNatural_DFA.States[3].Set(
                    new DfaTrans(_literalNatural_DFA.States[4], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(97, 102))
                );
                _literalNatural_DFA.States[4].Set(
                    new DfaTrans(_literalNatural_DFA.States[4], new DfaInterval(48, 57), new DfaInterval(65, 70), new DfaInterval(95, 95), new DfaInterval(97, 102))
                );
                _literalNatural_DFA.States[5].Set(
                    new DfaTrans(_literalNatural_DFA.States[6], new DfaInterval(48, 49))
                );
                _literalNatural_DFA.States[6].Set(
                    new DfaTrans(_literalNatural_DFA.States[6], new DfaInterval(48, 49), new DfaInterval(95, 95))
                );
                _literalChar_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, true)
                );
                _literalChar_DFA.States[0].Set(
                    new DfaTrans(_literalChar_DFA.States[1], new DfaInterval(39, 39))
                );
                _literalChar_DFA.States[1].Set(
                    new DfaTrans(_literalChar_DFA.States[1], new DfaInterval(0, 38), new DfaInterval(40, 91), new DfaInterval(93, 1114111)),
                    new DfaTrans(_literalChar_DFA.States[2], new DfaInterval(92, 92)),
                    new DfaTrans(_literalChar_DFA.States[4], new DfaInterval(39, 39))
                );
                _literalChar_DFA.States[2].Set(
                    new DfaTrans(_literalChar_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_literalChar_DFA.States[3], new DfaInterval(123, 123))
                );
                _literalChar_DFA.States[3].Set(
                    new DfaTrans(_literalChar_DFA.States[3], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_literalChar_DFA.States[1], new DfaInterval(125, 125))
                );
                _literalChar_DFA.States[4].Set(
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
                _literalString_DFA.Set(
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
                _literalString_DFA.States[0].Set(
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[1].Set(
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_literalString_DFA.States[2], new DfaInterval(96, 96)),
                    new DfaTrans(_literalString_DFA.States[8], new DfaInterval(92, 92)),
                    new DfaTrans(_literalString_DFA.States[7], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[2].Set(
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(0, 33), new DfaInterval(35, 91), new DfaInterval(93, 95), new DfaInterval(97, 1114111)),
                    new DfaTrans(_literalString_DFA.States[3], new DfaInterval(92, 92)),
                    new DfaTrans(_literalString_DFA.States[6], new DfaInterval(96, 96)),
                    new DfaTrans(_literalString_DFA.States[7], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[3].Set(
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_literalString_DFA.States[4], new DfaInterval(123, 123))
                );
                _literalString_DFA.States[4].Set(
                    new DfaTrans(_literalString_DFA.States[4], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_literalString_DFA.States[5], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[5].Set(
                    new DfaTrans(_literalString_DFA.States[4], new DfaInterval(0, 33), new DfaInterval(35, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(125, 125)),
                    new DfaTrans(_literalString_DFA.States[5], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[6].Set(
                    new DfaTrans(_literalString_DFA.States[6], new DfaInterval(96, 96)),
                    new DfaTrans(_literalString_DFA.States[7], new DfaInterval(34, 34))
                );
                _literalString_DFA.States[7].Set(
                );
                _literalString_DFA.States[8].Set(
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(0, 122), new DfaInterval(124, 1114111)),
                    new DfaTrans(_literalString_DFA.States[9], new DfaInterval(123, 123))
                );
                _literalString_DFA.States[9].Set(
                    new DfaTrans(_literalString_DFA.States[9], new DfaInterval(0, 124), new DfaInterval(126, 1114111)),
                    new DfaTrans(_literalString_DFA.States[1], new DfaInterval(125, 125))
                );
                _verbatimString_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false),
                    new DfaState(5, false),
                    new DfaState(6, true)
                );
                _verbatimString_DFA.States[0].Set(
                    new DfaTrans(_verbatimString_DFA.States[1], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[1].Set(
                    new DfaTrans(_verbatimString_DFA.States[2], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[2].Set(
                    new DfaTrans(_verbatimString_DFA.States[3], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[3].Set(
                    new DfaTrans(_verbatimString_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimString_DFA.States[4], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[4].Set(
                    new DfaTrans(_verbatimString_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimString_DFA.States[5], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[5].Set(
                    new DfaTrans(_verbatimString_DFA.States[3], new DfaInterval(0, 33), new DfaInterval(35, 1114111)),
                    new DfaTrans(_verbatimString_DFA.States[6], new DfaInterval(34, 34))
                );
                _verbatimString_DFA.States[6].Set(
                );
                _lowerIdentifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, false),
                    new DfaState(2, false),
                    new DfaState(3, true),
                    new DfaState(4, true),
                    new DfaState(5, true),
                    new DfaState(6, true),
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
                    new DfaState(56, false),
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
                    new DfaState(71, true),
                    new DfaState(72, true),
                    new DfaState(73, true),
                    new DfaState(74, true),
                    new DfaState(75, true),
                    new DfaState(76, true),
                    new DfaState(77, true),
                    new DfaState(78, true),
                    new DfaState(79, false),
                    new DfaState(80, true),
                    new DfaState(81, true),
                    new DfaState(82, true),
                    new DfaState(83, true),
                    new DfaState(84, true),
                    new DfaState(85, true),
                    new DfaState(86, true),
                    new DfaState(87, true),
                    new DfaState(88, true),
                    new DfaState(89, true),
                    new DfaState(90, true),
                    new DfaState(91, true),
                    new DfaState(92, true),
                    new DfaState(93, true),
                    new DfaState(94, true),
                    new DfaState(95, true),
                    new DfaState(96, true),
                    new DfaState(97, true),
                    new DfaState(98, true),
                    new DfaState(99, true),
                    new DfaState(100, true),
                    new DfaState(101, true),
                    new DfaState(102, true),
                    new DfaState(103, true),
                    new DfaState(104, true),
                    new DfaState(105, true),
                    new DfaState(106, true),
                    new DfaState(107, true),
                    new DfaState(108, true)
                );
                _lowerIdentifier_DFA.States[0].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[1], new DfaInterval(92, 92)),
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(95, 95), new DfaInterval(100, 100), new DfaInterval(104, 104), new DfaInterval(106, 107), new DfaInterval(113, 113), new DfaInterval(117, 117), new DfaInterval(120, 122)),
                    new DfaTrans(_lowerIdentifier_DFA.States[4], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[14], new DfaInterval(98, 98)),
                    new DfaTrans(_lowerIdentifier_DFA.States[18], new DfaInterval(99, 99)),
                    new DfaTrans(_lowerIdentifier_DFA.States[30], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[38], new DfaInterval(102, 102)),
                    new DfaTrans(_lowerIdentifier_DFA.States[50], new DfaInterval(103, 103)),
                    new DfaTrans(_lowerIdentifier_DFA.States[53], new DfaInterval(105, 105)),
                    new DfaTrans(_lowerIdentifier_DFA.States[62], new DfaInterval(108, 108)),
                    new DfaTrans(_lowerIdentifier_DFA.States[63], new DfaInterval(109, 109)),
                    new DfaTrans(_lowerIdentifier_DFA.States[67], new DfaInterval(110, 110)),
                    new DfaTrans(_lowerIdentifier_DFA.States[74], new DfaInterval(111, 111)),
                    new DfaTrans(_lowerIdentifier_DFA.States[80], new DfaInterval(112, 112)),
                    new DfaTrans(_lowerIdentifier_DFA.States[85], new DfaInterval(114, 114)),
                    new DfaTrans(_lowerIdentifier_DFA.States[89], new DfaInterval(115, 115)),
                    new DfaTrans(_lowerIdentifier_DFA.States[100], new DfaInterval(116, 116)),
                    new DfaTrans(_lowerIdentifier_DFA.States[103], new DfaInterval(118, 118)),
                    new DfaTrans(_lowerIdentifier_DFA.States[107], new DfaInterval(119, 119))
                );
                _lowerIdentifier_DFA.States[1].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[2].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _lowerIdentifier_DFA.States[3].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _lowerIdentifier_DFA.States[4].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[5], new DfaInterval(108, 108)),
                    new DfaTrans(_lowerIdentifier_DFA.States[8], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[5].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[6], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[6].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[7].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[8].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[9], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[9].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[10], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[12], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[10].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[11], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[11].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[12].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(103, 103))
                );
                _lowerIdentifier_DFA.States[13].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[14].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[15], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[15].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[16], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[16].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[17], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[17].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 106), new DfaInterval(108, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(107, 107))
                );
                _lowerIdentifier_DFA.States[18].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 107), new DfaInterval(109, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[19], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[23], new DfaInterval(108, 108)),
                    new DfaTrans(_lowerIdentifier_DFA.States[25], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[19].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(115, 115)),
                    new DfaTrans(_lowerIdentifier_DFA.States[21], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[20].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[21].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[22], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[22].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(104, 104))
                );
                _lowerIdentifier_DFA.States[23].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[24], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[24].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[25].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[26], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[26].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[27], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[27].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[28], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[28].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[29], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[29].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[30].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 119), new DfaInterval(121, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[31], new DfaInterval(108, 108)),
                    new DfaTrans(_lowerIdentifier_DFA.States[32], new DfaInterval(120, 120))
                );
                _lowerIdentifier_DFA.States[31].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[32].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[33], new DfaInterval(105, 105)),
                    new DfaTrans(_lowerIdentifier_DFA.States[35], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[33].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[34], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[34].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[35].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[36], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[36].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[37], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[37].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(100, 100))
                );
                _lowerIdentifier_DFA.States[38].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 110), new DfaInterval(112, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[39], new DfaInterval(105, 105)),
                    new DfaTrans(_lowerIdentifier_DFA.States[44], new DfaInterval(111, 111)),
                    new DfaTrans(_lowerIdentifier_DFA.States[45], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[39].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[40], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[40].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[41], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[41].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[42], new DfaInterval(108, 108))
                );
                _lowerIdentifier_DFA.States[42].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[43], new DfaInterval(108, 108))
                );
                _lowerIdentifier_DFA.States[43].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 120), new DfaInterval(122, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(121, 121))
                );
                _lowerIdentifier_DFA.States[44].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[45].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[46], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[46].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[47], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[47].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[48], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[48].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[49], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[49].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[50].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[51], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[51].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 117), new DfaInterval(119, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[52], new DfaInterval(118, 118))
                );
                _lowerIdentifier_DFA.States[52].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[53].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 108), new DfaInterval(111, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(102, 102), new DfaInterval(115, 115)),
                    new DfaTrans(_lowerIdentifier_DFA.States[54], new DfaInterval(109, 109)),
                    new DfaTrans(_lowerIdentifier_DFA.States[56], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[54].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[55], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[55].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[10], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[56].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[57], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[57].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[58], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[58].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[59], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[59].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[60], new DfaInterval(102, 102))
                );
                _lowerIdentifier_DFA.States[60].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[61], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[61].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[62].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[11], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[63].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[64], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[64].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[65], new DfaInterval(100, 100))
                );
                _lowerIdentifier_DFA.States[65].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[66], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[66].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(108, 108))
                );
                _lowerIdentifier_DFA.States[67].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[68], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[69], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[68].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(119, 119))
                );
                _lowerIdentifier_DFA.States[69].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[70], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[70].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[71], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[71].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[72], new DfaInterval(109, 109))
                );
                _lowerIdentifier_DFA.States[72].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[73], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[73].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[43], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[74].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[75], new DfaInterval(98, 98)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(102, 102)),
                    new DfaTrans(_lowerIdentifier_DFA.States[78], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[75].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[76], new DfaInterval(106, 106))
                );
                _lowerIdentifier_DFA.States[76].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[77], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[77].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[11], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[78].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[79], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[79].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[80].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[81], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[81].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[82], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[82].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 106), new DfaInterval(108, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[83], new DfaInterval(107, 107))
                );
                _lowerIdentifier_DFA.States[83].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[84], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[84].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(103, 103))
                );
                _lowerIdentifier_DFA.States[85].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[86], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[86].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[87], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[87].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[88], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[88].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[89].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 116), new DfaInterval(118, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[90], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[96], new DfaInterval(117, 117)),
                    new DfaTrans(_lowerIdentifier_DFA.States[98], new DfaInterval(119, 119))
                );
                _lowerIdentifier_DFA.States[90].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[91], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[91].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[92], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[92].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[93], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[93].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[94], new DfaInterval(102, 102))
                );
                _lowerIdentifier_DFA.States[94].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[95], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[95].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[96].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[97], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[97].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[98].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[99], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[99].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[21], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[100].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[101], new DfaInterval(104, 104)),
                    new DfaTrans(_lowerIdentifier_DFA.States[43], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[101].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 104), new DfaInterval(106, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(105, 105)),
                    new DfaTrans(_lowerIdentifier_DFA.States[102], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[102].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[68], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[103].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[104], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[105], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[104].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[29], new DfaInterval(108, 108))
                );
                _lowerIdentifier_DFA.States[105].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[106], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[106].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(100, 100))
                );
                _lowerIdentifier_DFA.States[107].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[108], new DfaInterval(104, 104))
                );
                _lowerIdentifier_DFA.States[108].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[66], new DfaInterval(105, 105))
                );
                _upperIdentifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, false)
                );
                _upperIdentifier_DFA.States[0].Set(
                    new DfaTrans(_upperIdentifier_DFA.States[1], new DfaInterval(65, 90)),
                    new DfaTrans(_upperIdentifier_DFA.States[2], new DfaInterval(92, 92))
                );
                _upperIdentifier_DFA.States[1].Set(
                    new DfaTrans(_upperIdentifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _upperIdentifier_DFA.States[2].Set(
                    new DfaTrans(_upperIdentifier_DFA.States[3], new DfaInterval(73, 73))
                );
                _upperIdentifier_DFA.States[3].Set(
                    new DfaTrans(_upperIdentifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                __Matchers_716_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_716_DFA.States[0].Set(
                    new DfaTrans(__Matchers_716_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_716_DFA.States[1].Set(
                );
                __Matchers_718_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_718_DFA.States[0].Set(
                    new DfaTrans(__Matchers_718_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_718_DFA.States[1].Set(
                );
            }

            private PlainRule _compilationUnit;
            private PlainRule _unitElements;
            private PlainRule _importDeclarations;
            private PlainRule _moduleDescriptor;
            private PlainRule _moduleSpecifier;
            private PlainRule _repository;
            private PlainRule _module;
            private PlainRule _artifactAndClassifier;
            private PlainRule _artifact;
            private PlainRule _classifier;
            private PlainRule _version;
            private PlainRule _moduleName;
            private PlainRule _moduleBody;
            private PlainRule _moduleBodyElement;
            private PlainRule _packageDescriptor;
            private PlainRule _importModule;
            private PlainRule _importDeclaration;
            private PlainRule _importElements;
            private PlainRule _importElementList;
            private PlainRule _importElement;
            private PlainRule _importNamed;
            private PlainRule _importName;
            private PlainRule _importNameSpecifier;
            private PlainRule _importWildcard;
            private PlainRule _packageName;
            private PlainRule _packagePath;
            private PlainRule _memberName;
            private PlainRule _typeName;
            private PlainRule _pattern;
            private PlainRule _variableOrTuplePattern;
            private PlainRule _tupleOrEntryPattern;
            private PlainRule _entryPattern;
            private PlainRule _tuplePattern;
            private PlainRule _variadicPatternList;
            private PlainRule _variadicPattern;
            private PlainRule _variablePattern;
            private PlainRule _variadicVariable;
            private PlainRule _letStatement;
            private PlainRule _delegatedConstructor;
            private PlainRule _assertionStatement;
            private PlainRule _assertionMessage;
            private PlainRule _block;
            private PlainRule _interfaceBlock;
            private PlainRule _classBlock;
            private PlainRule _blockElements;
            private PlainRule _extendedType;
            private PlainRule _classSpecifier;
            private PlainRule _classInstatiation;
            private PlainRule _qualifiedClass;
            private PlainRule _superQualifiedClass;
            private PlainRule _packageQualifiedClass;
            private PlainRule _packageQualifier;
            private PlainRule _unQualifiedClass;
            private PlainRule _memberPath;
            private PlainRule _typePath;
            private PlainRule _satisfiedTypes;
            private PlainRule _unionTypeList;
            private PlainRule _caseTypes;
            private PlainRule _caseTypeList;
            private PlainRule _caseType;
            private PlainRule _qualifiedCaseType;
            private PlainRule _parameters;
            private PlainRule _parameterList;
            private PlainRule _parameterDeclarationOrRefPattern;
            private PlainRule _parameter;
            private PlainRule _parameterReference;
            private PlainRule _parameterDeclaration;
            private PlainRule _functionParameterDeclaration;
            private PlainRule _functionParameterType;
            private PlainRule _valueParameterDeclaration;
            private PlainRule _valueParameterType;
            private PlainRule _typeParameters;
            private PlainRule _typeParameterList;
            private PlainRule _typeParameter;
            private PlainRule _variance;
            private PlainRule _typeDefault;
            private PlainRule _typeConstraint;
            private PlainRule _typeConstraints;
            private PlainRule _declarationOrStatement;
            private PlainRule _declaration;
            private PlainRule _constructorDeclaration;
            private PlainRule _aliasDeclaration;
            private PlainRule _enumeratedObjectDeclaration;
            private PlainRule _objectDeclaration;
            private PlainRule _setterDeclaration;
            private PlainRule _setterDefinition;
            private PlainRule _typedMethodDeclaration;
            private PlainRule _voidMethodDeclaration;
            private PlainRule _inferredMethodDeclaration;
            private PlainRule _typedAttributeDeclaration;
            private PlainRule _inferredAttributeDeclaration;
            private PlainRule _attributeDefinition;
            private PlainRule _optionalAnySpecifier;
            private PlainRule _classDeclaration;
            private PlainRule _classDefinition;
            private PlainRule _optionalClassSpecifier;
            private PlainRule _interfaceDeclaration;
            private PlainRule _interfaceDefinition;
            private PlainRule _optionalTypeSpecifier;
            private PlainRule _statement;
            private PlainRule _unclosedStatement;
            private PlainRule _openStatement;
            private PlainRule _specificationStatement;
            private PlainRule _expressionStatement;
            private PlainRule _directiveStatement;
            private PlainRule _returnStatement;
            private PlainRule _throwStatement;
            private PlainRule _breakStatement;
            private PlainRule _continueStatement;
            private PlainRule _typeSpecifier;
            private PlainRule _valueSpecifier;
            private PlainRule _functionSpecifier;
            private PlainRule _anySpecifier;
            private PlainRule _baseReferenceOrParameterized;
            private PlainRule _baseReference;
            private PlainRule _parametrizedMember;
            private PlainRule _selfParametrizedMember;
            private PlainRule _memberReference;
            private PlainRule _typeReference;
            private PlainRule _selfReferenceSelector;
            private PlainRule _selfReference;
            private PlainRule _enumerationExpr;
            private PlainRule _tupleExpr;
            private PlainRule _arguments;
            private PlainRule _structuralArguments;
            private PlainRule _namedOrAnonymous;
            private PlainRule _namedArgument;
            private PlainRule _anonymousArgument;
            private PlainRule _namedSpecifiedArgument;
            private PlainRule _sequencedArguments;
            private PlainRule _sequencedArgument;
            private PlainRule _namedArgumentDeclaration;
            private PlainRule _objectArgument;
            private PlainRule _typedMethodArgument;
            private PlainRule _methodDefinition;
            private PlainRule _optionalFunctionSpecifier;
            private PlainRule _neededFunctionSpecifier;
            private PlainRule _methodArgumentType;
            private PlainRule _typedGetterArgument;
            private PlainRule _getterArgumentType;
            private PlainRule _inferredMethodArgument;
            private PlainRule _inferredGetterArgument;
            private PlainRule _untypedMethodArgument;
            private PlainRule _untypedGetterArgument;
            private PlainRule _positionalArguments;
            private PlainRule _positionalArgument;
            private PlainRule _spreadArgument;
            private PlainRule _letExpr;
            private PlainRule _letVariableList;
            private PlainRule _letVariable;
            private PlainRule _switchExpr;
            private PlainRule _caseExpressions;
            private PlainRule _caseExpression;
            private PlainRule _ifExpr;
            private PlainRule _elseExpression;
            private PlainRule _thenExpression;
            private PlainRule _conditionalExpression;
            private PlainRule _functionExpr;
            private PlainRule _functionExpressionType;
            private PlainRule _functionParameters;
            private PlainRule _functionDefinition;
            private PlainRule _comprehensionArgument;
            private PlainRule _comprehensionClause;
            private PlainRule _expressionComprehensionClause;
            private PlainRule _forComprehensionClause;
            private PlainRule _ifComprehensionClause;
            private PlainRule _expression;
            private PlainRule _operatorExpression;
            private PlainRule _assignmentExpression;
            private PlainRule _assignmentExpr;
            private PlainRule _assignmentOperator;
            private PlainRule _thenElseExpression;
            private PlainRule _thenElseExpr;
            private PlainRule _thenElseOperator;
            private PlainRule _disjunctionExpression;
            private PlainRule _disjunctionExpr;
            private PlainRule _disjunctionOperator;
            private PlainRule _conjunctionExpression;
            private PlainRule _conjunctionExpr;
            private PlainRule _conjunctionOperator;
            private PlainRule _logicalNegationExpression;
            private PlainRule _logicalNegationExpr;
            private PlainRule _notOperator;
            private PlainRule _expressionOrMeta;
            private PlainRule _equalityExpression;
            private PlainRule _equalityExpr;
            private PlainRule _equalityOperator;
            private PlainRule _comparisonExpression;
            private PlainRule _comparisonExpr;
            private PlainRule _largerExpr;
            private PlainRule _smallerExpr;
            private PlainRule _largerBoundsExpr;
            private PlainRule _smallerBoundsExpr;
            private PlainRule _typecheckExpr;
            private PlainRule _comparisonOperator;
            private PlainRule _smallerOperator;
            private PlainRule _largerOperator;
            private PlainRule _typeOperator;
            private PlainRule _existsNonemptyExpression;
            private PlainRule _existsExpr;
            private PlainRule _nonemptyExpr;
            private PlainRule _entryRangeExpression;
            private PlainRule _rangeExpr;
            private PlainRule _entryExpr;
            private PlainRule _rangeOperator;
            private PlainRule _entryOperator;
            private PlainRule _additiveExpression;
            private PlainRule _additiveExpr;
            private PlainRule _additiveOperator;
            private PlainRule _scaleExpression;
            private PlainRule _scaleExpr;
            private PlainRule _scaleOperator;
            private PlainRule _multiplicativeExpression;
            private PlainRule _multiplicativeExpr;
            private PlainRule _multiplicativeOperator;
            private PlainRule _unionExpression;
            private PlainRule _unionExpr;
            private PlainRule _unionOperator;
            private PlainRule _exclusiveExpression;
            private PlainRule _exclusiveExpr;
            private PlainRule _exclusiveOperator;
            private PlainRule _intersectionExpression;
            private PlainRule _intersectionExpr;
            private PlainRule _intersectionOperator;
            private PlainRule _negationOrComplementExpression;
            private PlainRule _negationOrComplementExpr;
            private PlainRule _unaryMinusOrComplementOperator;
            private PlainRule _negateOperator;
            private PlainRule _neutralOperator;
            private PlainRule _complementOperator;
            private PlainRule _prefixExpression;
            private PlainRule _prefixExpr;
            private PlainRule _postfixExpression;
            private PlainRule _postfixExpr;
            private PlainRule _incrementOperator;
            private PlainRule _primary;
            private PlainRule _selectionExpr;
            private PlainRule _qualifiedReference;
            private PlainRule _memberSelectionOperator;
            private PlainRule _indexedExpr;
            private PlainRule _index;
            private PlainRule _upperSpanned;
            private PlainRule _lowerSpanned;
            private PlainRule _spanned;
            private PlainRule _measured;
            private PlainRule _indexExpression;
            private PlainRule _callExpr;
            private PlainRule _baseExpression;
            private PlainRule _nonstringLiteral;
            private PlainRule _stringExpression;
            private PlainRule _stringInterpolation;
            private PlainRule _interpolationPart;
            private PlainRule _stringLiteral;
            private PlainRule _objectExpr;
            private PlainRule _groupedExpr;
            private PlainRule _typeArguments;
            private PlainRule _typeArgumentList;
            private PlainRule _variancedType;
            private PlainRule _defaultedTypeList;
            private PlainRule _defaultedType;
            private PlainRule _defaultedTypeCore;
            private PlainRule _variadicType;
            private PlainRule _variadicUnionType;
            private PlainRule _variadicOperator;
            private PlainRule _spreadType;
            private PlainRule _type;
            private PlainRule _entryType;
            private PlainRule _unionType;
            private PlainRule _unionTypeCore;
            private PlainRule _intersectionType;
            private PlainRule _intersectionTypeCore;
            private PlainRule _primaryType;
            private PlainRule _nullableType;
            private PlainRule _arrayType;
            private PlainRule _functionType;
            private PlainRule _typeTypeArguments;
            private PlainRule _tupleType;
            private PlainRule _iterableType;
            private PlainRule _groupedType;
            private PlainRule _packageQualifiedType;
            private PlainRule _annotations;
            private PlainRule _annotation;
            private PlainRule _conditions;
            private PlainRule _conditionList;
            private PlainRule _condition;
            private PlainRule _existsCondition;
            private PlainRule _nonemptyCondition;
            private PlainRule _letOrExpression;
            private PlainRule _isCondition;
            private PlainRule _isConditionVariable;
            private PlainRule _satisfiesCondition;
            private PlainRule _booleanCondition;
            private PlainRule _controlStatement;
            private PlainRule _ifElseStatement;
            private PlainRule _ifBlock;
            private PlainRule _elseBlock;
            private PlainRule _elseBlockNext;
            private PlainRule _switchStatement;
            private PlainRule _switchHeader;
            private PlainRule _switched;
            private PlainRule _caseBlock;
            private PlainRule _caseItem;
            private PlainRule _isCaseCondition;
            private PlainRule _satisfiesCaseCondition;
            private PlainRule _matchCaseCondition;
            private PlainRule _valueCaseList;
            private PlainRule _valueCaseSeparator;
            private PlainRule _valueCase;
            private PlainRule _forElseStatement;
            private PlainRule _forBlock;
            private PlainRule _failBlock;
            private PlainRule _forIterator;
            private PlainRule _forVariable;
            private PlainRule _containment;
            private PlainRule _containmentOperator;
            private PlainRule _whileStatement;
            private PlainRule _tryStatement;
            private PlainRule _tryBlock;
            private PlainRule _catchBlock;
            private PlainRule _catchVariable;
            private PlainRule _finallyBlock;
            private PlainRule _resources;
            private PlainRule _resourceList;
            private PlainRule _resource;
            private PlainRule _specifiedOrExpression;
            private PlainRule _specifiedVariable;
            private PlainRule _variable;
            private PlainRule _variableType;
            private PlainRule _modelReference;
            private PlainRule _metaLiteral;
            private PlainRule _metaExpression;
            private PlainRule _modelExpression;
            private PlainRule _memberModelExpression;
            private PlainRule _packageQualifiedMemberReference;
            private PlainRule _typeQualifiedMemberReference;
            private PlainRule _typeModelExpression;
            private PlainRule _declarationReference;
            private PlainRule _moduleLiteral;
            private PlainRule _packageLiteral;
            private PlainRule _classLiteral;
            private PlainRule _interfaceLiteral;
            private PlainRule _aliasLiteral;
            private PlainRule _typeParameterLiteral;
            private PlainRule _newLiteral;
            private PlainRule _valueLiteral;
            private PlainRule _valueLiteralIntro;
            private PlainRule _functionLiteral;
            private PlainRule _referencePath;
            private PlainRule _referencePathElementList;
            private PlainRule _referencePathElement;
            private PlainRule _kwVoid;
            private PlainRule _kwFunction;
            private PlainRule _kwValue;
            private DfaRule _literalFloat;
            private DfaRule _literalNatural;
            private DfaRule _literalChar;
            private DfaRule _stringStart;
            private DfaRule _stringMid;
            private DfaRule _stringEnd;
            private DfaRule _literalString;
            private DfaRule _verbatimString;
            private DfaRule _lowerIdentifier;
            private DfaRule _upperIdentifier;
            private DfaRule _identifier;

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
            private Dfa _literalFloat_DFA = new Dfa("literal-float");
            private Dfa _literalNatural_DFA = new Dfa("literal-natural");
            private Dfa _literalChar_DFA = new Dfa("literal-char");
            private Dfa _stringStart_DFA = new Dfa("string-start");
            private Dfa _stringMid_DFA = new Dfa("string-mid");
            private Dfa _stringEnd_DFA = new Dfa("string-end");
            private Dfa _literalString_DFA = new Dfa("literal-string");
            private Dfa _verbatimString_DFA = new Dfa("verbatim-string");
            private Dfa _lowerIdentifier_DFA = new Dfa("lower-identifier");
            private Dfa _upperIdentifier_DFA = new Dfa("upper-identifier");
            private Dfa _identifier_DFA = new Dfa("identifier");
            private Dfa __Matchers_716_DFA = new Dfa("__Matchers_716_DFA");
            private Dfa __Matchers_718_DFA = new Dfa("__Matchers_718_DFA");
        }
    }

    public partial class CeylonTree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICCompilationUnit : IRNode {}
        public interface ICUnitElements : ICCompilationUnit {}
        public interface ICImportDeclarations : IRNode {}
        public interface ICModuleDescriptor : ICCompilationUnit {}
        public interface ICModuleSpecifier : IRNode {}
        public interface ICRepository : IRNode {}
        public interface ICModule : IRNode {}
        public interface ICArtifactAndClassifier : IRNode {}
        public interface ICArtifact : IRNode {}
        public interface ICClassifier : IRNode {}
        public interface ICVersion : IRNode {}
        public interface ICModuleName : ICModule {}
        public interface ICModuleBody : IRNode {}
        public interface ICModuleBodyElement : IRNode {}
        public interface ICPackageDescriptor : ICCompilationUnit {}
        public interface ICImportModule : ICModuleBodyElement {}
        public interface ICImportDeclaration : IRNode {}
        public interface ICImportElements : IRNode {}
        public interface ICImportElementList : IRNode {}
        public interface ICImportElement : IRNode {}
        public interface ICImportNamed : ICImportElement {}
        public interface ICImportName : IRNode {}
        public interface ICImportNameSpecifier : IRNode {}
        public interface ICImportWildcard : ICImportElement {}
        public interface ICPackageName : IRNode {}
        public interface ICPackagePath : ICModuleName {}
        public interface ICMemberName : IRNode {}
        public interface ICTypeName : IRNode {}
        public interface ICPattern : ICCaseItem, ICVariadicPattern {}
        public interface ICVariableOrTuplePattern : IRNode {}
        public interface ICTupleOrEntryPattern : ICForVariable {}
        public interface ICEntryPattern : ICParameterDeclarationOrRefPattern, ICPattern, ICTupleOrEntryPattern {}
        public interface ICTuplePattern : ICParameterDeclarationOrRefPattern, ICPattern, ICTupleOrEntryPattern, ICVariableOrTuplePattern {}
        public interface ICVariadicPatternList : IRNode {}
        public interface ICVariadicPattern : IRNode {}
        public interface ICVariablePattern : ICPattern, ICVariableOrTuplePattern {}
        public interface ICVariadicVariable : ICVariadicPattern {}
        public interface ICLetStatement : ICOpenStatement {}
        public interface ICDelegatedConstructor : IRNode {}
        public interface ICAssertionStatement : ICOpenStatement {}
        public interface ICAssertionMessage : IRNode {}
        public interface ICBlock : ICAttributeDefinition, ICElseBlockNext, ICFunctionDefinition, ICMethodDefinition, ICSetterDefinition {}
        public interface ICInterfaceBlock : ICInterfaceDefinition {}
        public interface ICClassBlock : ICClassDefinition {}
        public interface ICBlockElements : ICBlock, ICClassBlock, ICInterfaceBlock {}
        public interface ICExtendedType : IRNode {}
        public interface ICClassSpecifier : IRNode {}
        public interface ICClassInstatiation : IRNode {}
        public interface ICQualifiedClass : IRNode {}
        public interface ICSuperQualifiedClass : ICQualifiedClass {}
        public interface ICPackageQualifiedClass : ICQualifiedClass {}
        public interface ICPackageQualifier : IRNode {}
        public interface ICUnQualifiedClass : ICQualifiedClass {}
        public interface ICMemberPath : ICUnQualifiedClass {}
        public interface ICTypePath : ICPrimaryType, ICUnQualifiedClass {}
        public interface ICSatisfiedTypes : IRNode {}
        public interface ICUnionTypeList : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICCaseType : IRNode {}
        public interface ICQualifiedCaseType : ICCaseType {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameterDeclarationOrRefPattern : IRNode {}
        public interface ICParameter : ICParameterDeclarationOrRefPattern {}
        public interface ICParameterReference : ICParameterDeclarationOrRefPattern {}
        public interface ICParameterDeclaration : IRNode {}
        public interface ICFunctionParameterDeclaration : ICParameterDeclaration {}
        public interface ICFunctionParameterType : IRNode {}
        public interface ICValueParameterDeclaration : ICParameterDeclaration {}
        public interface ICValueParameterType : IRNode {}
        public interface ICTypeParameters : IRNode {}
        public interface ICTypeParameterList : IRNode {}
        public interface ICTypeParameter : IRNode {}
        public interface ICVariance : IRNode {}
        public interface ICTypeDefault : IRNode {}
        public interface ICTypeConstraint : IRNode {}
        public interface ICTypeConstraints : IRNode {}
        public interface ICDeclarationOrStatement : IRNode {}
        public interface ICDeclaration : ICDeclarationOrStatement {}
        public interface ICConstructorDeclaration : ICDeclaration {}
        public interface ICAliasDeclaration : ICDeclaration {}
        public interface ICEnumeratedObjectDeclaration : ICDeclaration {}
        public interface ICObjectDeclaration : ICDeclaration {}
        public interface ICSetterDeclaration : ICDeclaration {}
        public interface ICSetterDefinition : IRNode {}
        public interface ICTypedMethodDeclaration : ICDeclaration {}
        public interface ICVoidMethodDeclaration : ICDeclaration {}
        public interface ICInferredMethodDeclaration : ICDeclaration {}
        public interface ICTypedAttributeDeclaration : ICDeclaration {}
        public interface ICInferredAttributeDeclaration : ICDeclaration, ICModuleBodyElement {}
        public interface ICAttributeDefinition : IRNode {}
        public interface ICOptionalAnySpecifier : ICAttributeDefinition {}
        public interface ICClassDeclaration : ICDeclaration {}
        public interface ICClassDefinition : IRNode {}
        public interface ICOptionalClassSpecifier : ICClassDefinition {}
        public interface ICInterfaceDeclaration : ICDeclaration {}
        public interface ICInterfaceDefinition : IRNode {}
        public interface ICOptionalTypeSpecifier : ICInterfaceDefinition {}
        public interface ICStatement : ICDeclarationOrStatement {}
        public interface ICUnclosedStatement : ICStatement {}
        public interface ICOpenStatement : IRNode {}
        public interface ICSpecificationStatement : ICOpenStatement {}
        public interface ICExpressionStatement : ICOpenStatement {}
        public interface ICDirectiveStatement : ICOpenStatement {}
        public interface ICReturnStatement : ICDirectiveStatement {}
        public interface ICThrowStatement : ICDirectiveStatement {}
        public interface ICBreakStatement : ICDirectiveStatement {}
        public interface ICContinueStatement : ICDirectiveStatement {}
        public interface ICTypeSpecifier : IRNode {}
        public interface ICValueSpecifier : ICAnySpecifier {}
        public interface ICFunctionSpecifier : ICAnySpecifier, ICFunctionDefinition {}
        public interface ICAnySpecifier : IRNode {}
        public interface ICBaseReferenceOrParameterized : ICBaseExpression {}
        public interface ICBaseReference : ICBaseReferenceOrParameterized {}
        public interface ICParametrizedMember : ICBaseReferenceOrParameterized {}
        public interface ICSelfParametrizedMember : ICBaseReferenceOrParameterized {}
        public interface ICMemberReference : ICBaseReference, ICMemberModelExpression, ICUnQualifiedClass {}
        public interface ICTypeReference : ICBaseReference {}
        public interface ICSelfReferenceSelector : IRNode {}
        public interface ICSelfReference : ICBaseReferenceOrParameterized {}
        public interface ICEnumerationExpr : ICBaseExpression {}
        public interface ICTupleExpr : ICBaseExpression {}
        public interface ICArguments : IRNode {}
        public interface ICStructuralArguments : ICArguments {}
        public interface ICNamedOrAnonymous : IRNode {}
        public interface ICNamedArgument : ICNamedOrAnonymous {}
        public interface ICAnonymousArgument : ICNamedOrAnonymous {}
        public interface ICNamedSpecifiedArgument : ICNamedArgument {}
        public interface ICSequencedArguments : IRNode {}
        public interface ICSequencedArgument : IRNode {}
        public interface ICNamedArgumentDeclaration : ICNamedArgument {}
        public interface ICObjectArgument : ICNamedArgumentDeclaration {}
        public interface ICTypedMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICMethodDefinition : IRNode {}
        public interface ICOptionalFunctionSpecifier : ICMethodDefinition {}
        public interface ICNeededFunctionSpecifier : ICSetterDefinition {}
        public interface ICMethodArgumentType : IRNode {}
        public interface ICTypedGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICGetterArgumentType : IRNode {}
        public interface ICInferredMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICInferredGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICUntypedMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICUntypedGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICPositionalArguments : ICArguments {}
        public interface ICPositionalArgument : ICSequencedArgument {}
        public interface ICSpreadArgument : ICSequencedArgument {}
        public interface ICLetExpr : ICConditionalExpression, ICExpression {}
        public interface ICLetVariableList : IRNode {}
        public interface ICLetVariable : ICLetOrExpression {}
        public interface ICSwitchExpr : ICExpression {}
        public interface ICCaseExpressions : IRNode {}
        public interface ICCaseExpression : IRNode {}
        public interface ICIfExpr : ICConditionalExpression, ICExpression {}
        public interface ICElseExpression : IRNode {}
        public interface ICThenExpression : IRNode {}
        public interface ICConditionalExpression : IRNode {}
        public interface ICFunctionExpr : ICExpression {}
        public interface ICFunctionExpressionType : IRNode {}
        public interface ICFunctionParameters : IRNode {}
        public interface ICFunctionDefinition : IRNode {}
        public interface ICComprehensionArgument : ICSequencedArgument {}
        public interface ICComprehensionClause : IRNode {}
        public interface ICExpressionComprehensionClause : ICComprehensionClause {}
        public interface ICForComprehensionClause : ICComprehensionArgument, ICComprehensionClause {}
        public interface ICIfComprehensionClause : ICComprehensionArgument, ICComprehensionClause {}
        public interface ICExpression : ICBooleanCondition, ICExpressionComprehensionClause, ICIndex, ICPositionalArgument {}
        public interface ICOperatorExpression : ICExpression, ICExpressionStatement, ICLetOrExpression, ICSpecifiedOrExpression {}
        public interface ICAssignmentExpression : ICOperatorExpression {}
        public interface ICAssignmentExpr : ICAssignmentExpression {}
        public interface ICAssignmentOperator : IRNode {}
        public interface ICThenElseExpression : ICAssignmentExpression {}
        public interface ICThenElseExpr : ICThenElseExpression {}
        public interface ICThenElseOperator : IRNode {}
        public interface ICDisjunctionExpression : ICConditionalExpression, ICThenElseExpression {}
        public interface ICDisjunctionExpr : ICDisjunctionExpression {}
        public interface ICDisjunctionOperator : IRNode {}
        public interface ICConjunctionExpression : ICDisjunctionExpression {}
        public interface ICConjunctionExpr : ICConjunctionExpression {}
        public interface ICConjunctionOperator : IRNode {}
        public interface ICLogicalNegationExpression : ICConjunctionExpression {}
        public interface ICLogicalNegationExpr : ICLogicalNegationExpression {}
        public interface ICNotOperator : IRNode {}
        public interface ICExpressionOrMeta : ICLogicalNegationExpression {}
        public interface ICEqualityExpression : ICExpressionOrMeta {}
        public interface ICEqualityExpr : ICEqualityExpression {}
        public interface ICEqualityOperator : IRNode {}
        public interface ICComparisonExpression : ICEqualityExpression {}
        public interface ICComparisonExpr : ICComparisonExpression {}
        public interface ICLargerExpr : ICComparisonExpression {}
        public interface ICSmallerExpr : ICComparisonExpression {}
        public interface ICLargerBoundsExpr : ICComparisonExpression {}
        public interface ICSmallerBoundsExpr : ICComparisonExpression {}
        public interface ICTypecheckExpr : ICComparisonExpression {}
        public interface ICComparisonOperator : IRNode {}
        public interface ICSmallerOperator : IRNode {}
        public interface ICLargerOperator : IRNode {}
        public interface ICTypeOperator : IRNode {}
        public interface ICExistsNonemptyExpression : ICComparisonExpression {}
        public interface ICExistsExpr : ICExistsNonemptyExpression {}
        public interface ICNonemptyExpr : ICExistsNonemptyExpression {}
        public interface ICEntryRangeExpression : ICExistsNonemptyExpression {}
        public interface ICRangeExpr : ICEntryRangeExpression {}
        public interface ICEntryExpr : ICEntryRangeExpression {}
        public interface ICRangeOperator : IRNode {}
        public interface ICEntryOperator : IRNode {}
        public interface ICAdditiveExpression : ICEntryRangeExpression, ICIndexExpression {}
        public interface ICAdditiveExpr : ICAdditiveExpression {}
        public interface ICAdditiveOperator : IRNode {}
        public interface ICScaleExpression : ICAdditiveExpression {}
        public interface ICScaleExpr : ICScaleExpression {}
        public interface ICScaleOperator : IRNode {}
        public interface ICMultiplicativeExpression : ICScaleExpression {}
        public interface ICMultiplicativeExpr : ICMultiplicativeExpression {}
        public interface ICMultiplicativeOperator : IRNode {}
        public interface ICUnionExpression : ICMultiplicativeExpression {}
        public interface ICUnionExpr : ICUnionExpression {}
        public interface ICUnionOperator : IRNode {}
        public interface ICExclusiveExpression : ICUnionExpression {}
        public interface ICExclusiveExpr : ICExclusiveExpression {}
        public interface ICExclusiveOperator : IRNode {}
        public interface ICIntersectionExpression : ICExclusiveExpression, ICValueCase {}
        public interface ICIntersectionExpr : ICIntersectionExpression {}
        public interface ICIntersectionOperator : IRNode {}
        public interface ICNegationOrComplementExpression : ICIntersectionExpression {}
        public interface ICNegationOrComplementExpr : ICNegationOrComplementExpression {}
        public interface ICUnaryMinusOrComplementOperator : IRNode {}
        public interface ICNegateOperator : ICUnaryMinusOrComplementOperator {}
        public interface ICNeutralOperator : ICUnaryMinusOrComplementOperator {}
        public interface ICComplementOperator : ICUnaryMinusOrComplementOperator {}
        public interface ICPrefixExpression : ICNegationOrComplementExpression {}
        public interface ICPrefixExpr : ICPrefixExpression {}
        public interface ICPostfixExpression : ICPrefixExpression {}
        public interface ICPostfixExpr : ICPostfixExpression {}
        public interface ICIncrementOperator : IRNode {}
        public interface ICPrimary : ICPostfixExpression {}
        public interface ICSelectionExpr : ICPrimary {}
        public interface ICQualifiedReference : IRNode {}
        public interface ICMemberSelectionOperator : IRNode {}
        public interface ICIndexedExpr : ICPrimary {}
        public interface ICIndex : IRNode {}
        public interface ICUpperSpanned : ICIndex {}
        public interface ICLowerSpanned : ICIndex {}
        public interface ICSpanned : ICIndex {}
        public interface ICMeasured : ICIndex {}
        public interface ICIndexExpression : IRNode {}
        public interface ICCallExpr : ICPrimary {}
        public interface ICBaseExpression : ICPrimary {}
        public interface ICNonstringLiteral : ICBaseExpression {}
        public interface ICStringExpression : ICAssertionMessage, ICBaseExpression {}
        public interface ICStringInterpolation : ICStringExpression {}
        public interface ICInterpolationPart : IRNode {}
        public interface ICStringLiteral : ICStringExpression {}
        public interface ICObjectExpr : ICBaseExpression {}
        public interface ICGroupedExpr : ICBaseExpression {}
        public interface ICTypeArguments : IRNode {}
        public interface ICTypeArgumentList : IRNode {}
        public interface ICVariancedType : IRNode {}
        public interface ICDefaultedTypeList : ICTypeTypeArguments {}
        public interface ICDefaultedType : IRNode {}
        public interface ICDefaultedTypeCore : ICDefaultedType {}
        public interface ICVariadicType : ICDefaultedType, ICFunctionParameterType, ICValueParameterType {}
        public interface ICVariadicUnionType : ICVariadicType {}
        public interface ICVariadicOperator : IRNode {}
        public interface ICSpreadType : ICTypeTypeArguments {}
        public interface ICType : ICGetterArgumentType, ICMethodArgumentType, ICTypeModelExpression, ICVariableType, ICVariadicType {}
        public interface ICEntryType : ICType {}
        public interface ICUnionType : ICType {}
        public interface ICUnionTypeCore : ICUnionType {}
        public interface ICIntersectionType : ICUnionType, ICValueCase {}
        public interface ICIntersectionTypeCore : ICIntersectionType {}
        public interface ICPrimaryType : ICCaseType, ICIntersectionType {}
        public interface ICNullableType : ICPrimaryType {}
        public interface ICArrayType : ICPrimaryType {}
        public interface ICFunctionType : ICPrimaryType {}
        public interface ICTypeTypeArguments : IRNode {}
        public interface ICTupleType : ICPrimaryType {}
        public interface ICIterableType : ICPrimaryType {}
        public interface ICGroupedType : ICPrimaryType {}
        public interface ICPackageQualifiedType : ICPrimaryType {}
        public interface ICAnnotations : IRNode {}
        public interface ICAnnotation : IRNode {}
        public interface ICConditions : IRNode {}
        public interface ICConditionList : IRNode {}
        public interface ICCondition : IRNode {}
        public interface ICExistsCondition : ICCondition {}
        public interface ICNonemptyCondition : ICCondition {}
        public interface ICLetOrExpression : IRNode {}
        public interface ICIsCondition : ICCondition {}
        public interface ICIsConditionVariable : IRNode {}
        public interface ICSatisfiesCondition : ICCondition {}
        public interface ICBooleanCondition : ICCondition {}
        public interface ICControlStatement : ICStatement {}
        public interface ICIfElseStatement : ICControlStatement, ICElseBlockNext {}
        public interface ICIfBlock : IRNode {}
        public interface ICElseBlock : IRNode {}
        public interface ICElseBlockNext : IRNode {}
        public interface ICSwitchStatement : ICControlStatement {}
        public interface ICSwitchHeader : IRNode {}
        public interface ICSwitched : IRNode {}
        public interface ICCaseBlock : IRNode {}
        public interface ICCaseItem : IRNode {}
        public interface ICIsCaseCondition : ICCaseItem {}
        public interface ICSatisfiesCaseCondition : ICCaseItem {}
        public interface ICMatchCaseCondition : ICCaseItem {}
        public interface ICValueCaseList : ICMatchCaseCondition {}
        public interface ICValueCaseSeparator : IRNode {}
        public interface ICValueCase : IRNode {}
        public interface ICForElseStatement : ICControlStatement {}
        public interface ICForBlock : IRNode {}
        public interface ICFailBlock : IRNode {}
        public interface ICForIterator : IRNode {}
        public interface ICForVariable : IRNode {}
        public interface ICContainment : IRNode {}
        public interface ICContainmentOperator : IRNode {}
        public interface ICWhileStatement : ICControlStatement {}
        public interface ICTryStatement : ICControlStatement {}
        public interface ICTryBlock : IRNode {}
        public interface ICCatchBlock : IRNode {}
        public interface ICCatchVariable : IRNode {}
        public interface ICFinallyBlock : IRNode {}
        public interface ICResources : IRNode {}
        public interface ICResourceList : IRNode {}
        public interface ICResource : IRNode {}
        public interface ICSpecifiedOrExpression : ICResource, ICSwitched {}
        public interface ICSpecifiedVariable : ICSpecifiedOrExpression {}
        public interface ICVariable : ICForVariable, ICVariablePattern {}
        public interface ICVariableType : IRNode {}
        public interface ICModelReference : ICExpressionOrMeta {}
        public interface ICMetaLiteral : ICBaseExpression {}
        public interface ICMetaExpression : IRNode {}
        public interface ICModelExpression : ICMetaExpression {}
        public interface ICMemberModelExpression : ICModelExpression {}
        public interface ICPackageQualifiedMemberReference : ICMemberModelExpression {}
        public interface ICTypeQualifiedMemberReference : ICMemberModelExpression {}
        public interface ICTypeModelExpression : ICModelExpression {}
        public interface ICDeclarationReference : ICMetaExpression, ICPositionalArgument {}
        public interface ICModuleLiteral : ICDeclarationReference {}
        public interface ICPackageLiteral : ICDeclarationReference {}
        public interface ICClassLiteral : ICDeclarationReference {}
        public interface ICInterfaceLiteral : ICDeclarationReference {}
        public interface ICAliasLiteral : ICDeclarationReference {}
        public interface ICTypeParameterLiteral : ICDeclarationReference {}
        public interface ICNewLiteral : ICDeclarationReference {}
        public interface ICValueLiteral : ICDeclarationReference {}
        public interface ICValueLiteralIntro : IRNode {}
        public interface ICFunctionLiteral : ICDeclarationReference {}
        public interface ICReferencePath : IRNode {}
        public interface ICReferencePathElementList : IRNode {}
        public interface ICReferencePathElement : IRNode {}
        public interface ICKwVoid : ICFunctionParameterType, ICMethodArgumentType, ICVariableType {}
        public interface ICKwFunction : ICFunctionParameterType, ICVariableType {}
        public interface ICKwValue : ICValueParameterType, ICVariableType {}
        public interface ICLiteralFloat : ICNonstringLiteral {}
        public interface ICLiteralNatural : ICNonstringLiteral {}
        public interface ICLiteralChar : ICNonstringLiteral {}
        public interface ICStringStart : IRNode {}
        public interface ICStringMid : IRNode {}
        public interface ICStringEnd : IRNode {}
        public interface ICLiteralString : ICModule, ICStringLiteral, ICVersion {}
        public interface ICVerbatimString : ICStringLiteral {}
        public interface ICLowerIdentifier : ICMemberName {}
        public interface ICUpperIdentifier : ICTypeName {}
        public interface ICIdentifier : ICImportName, ICPackageName, ICReferencePathElement, ICRepository {}

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

        public partial class CUnitElements : RSequence, ICUnitElements
        {
            // sequence
            public CUnitElements(params RNode[] children) : base(children) {}

            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(0);
            public RStar<ICDeclaration> DeclarationStar => Get<RStar<ICDeclaration>>(1);
        }

        public partial class CImportDeclarations : RStar<CImportDeclaration>, ICImportDeclarations
        {
            // *star*
            public CImportDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
            // sequence
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICModuleName ModuleName => Get<ICModuleName>(2);
            public ROptional<CModuleSpecifier> ModuleSpecifierOptional => Get<ROptional<CModuleSpecifier>>(3);
            public ROptional<ICVersion> VersionOptional => Get<ROptional<ICVersion>>(4);
            public CModuleBody ModuleBody => Get<CModuleBody>(5);
        }

        public partial class CModuleSpecifier : RSequence, ICModuleSpecifier
        {
            // sequence
            public CModuleSpecifier(params RNode[] children) : base(children) {}

            public ICRepository Repository => Get<ICRepository>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICModule Module => Get<ICModule>(2);
            public ROptional<CArtifactAndClassifier> ArtifactAndClassifierOptional => Get<ROptional<CArtifactAndClassifier>>(3);
        }

        public partial class CArtifactAndClassifier : RSequence, ICArtifactAndClassifier
        {
            // sequence
            public CArtifactAndClassifier(params RNode[] children) : base(children) {}

            public CArtifact Artifact => Get<CArtifact>(0);
            public ROptional<CClassifier> ClassifierOptional => Get<ROptional<CClassifier>>(1);
        }

        public partial class CArtifact : RSequence, ICArtifact
        {
            // sequence
            public CArtifact(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CClassifier : RSequence, ICClassifier
        {
            // sequence
            public CClassifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CModuleBody : RSequence, ICModuleBody
        {
            // sequence
            public CModuleBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICModuleBodyElement> ModuleBodyElementStar => Get<RStar<ICModuleBodyElement>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CPackageDescriptor : RSequence, ICPackageDescriptor
        {
            // sequence
            public CPackageDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CPackagePath PackagePath => Get<CPackagePath>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CImportModule : RSequence, ICImportModule
        {
            // sequence
            public CImportModule(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICModule Module => Get<ICModule>(2);
            public ROptional<ICVersion> VersionOptional => Get<ROptional<ICVersion>>(3);
            public RLiteral Literal2 => Get<RLiteral>(4);
        }

        public partial class CImportDeclaration : RSequence, ICImportDeclaration
        {
            // sequence
            public CImportDeclaration(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CPackagePath PackagePath => Get<CPackagePath>(1);
            public CImportElements ImportElements => Get<CImportElements>(2);
        }

        public partial class CImportElements : RSequence, ICImportElements
        {
            // sequence
            public CImportElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CImportElementList> ImportElementListOptional => Get<ROptional<CImportElementList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CImportElementList : RLoop<ICImportElement>, ICImportElementList
        {
            // sequence
            public CImportElementList(params RNode[] children) : base(children) {}
        }

        public partial class CImportNamed : RSequence, ICImportNamed
        {
            // sequence
            public CImportNamed(params RNode[] children) : base(children) {}

            public ICImportName ImportName => Get<ICImportName>(0);
            public ROptional<CImportNameSpecifier> ImportNameSpecifierOptional => Get<ROptional<CImportNameSpecifier>>(1);
            public ROptional<CImportElements> ImportElementsOptional => Get<ROptional<CImportElements>>(2);
        }

        public partial class CImportNameSpecifier : RSequence, ICImportNameSpecifier
        {
            // sequence
            public CImportNameSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CIdentifier Identifier => Get<CIdentifier>(1);
        }

        public partial class CImportWildcard : RLiteral, ICImportWildcard
        {
            // string('...')
            public CImportWildcard(params Node[] children) : base(children) {}
        }

        public partial class CPackagePath : RLoop<ICPackageName>, ICPackagePath
        {
            // sequence
            public CPackagePath(params RNode[] children) : base(children) {}
        }

        public partial class CEntryPattern : RSequence, ICEntryPattern
        {
            // sequence
            public CEntryPattern(params RNode[] children) : base(children) {}

            public ICVariableOrTuplePattern VariableOrTuplePattern => Get<ICVariableOrTuplePattern>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICVariableOrTuplePattern VariableOrTuplePattern2 => Get<ICVariableOrTuplePattern>(2);
        }

        public partial class CTuplePattern : RSequence, ICTuplePattern
        {
            // sequence
            public CTuplePattern(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CVariadicPatternList> VariadicPatternListOptional => Get<ROptional<CVariadicPatternList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CVariadicPatternList : RLoop<ICVariadicPattern>, ICVariadicPatternList
        {
            // sequence
            public CVariadicPatternList(params RNode[] children) : base(children) {}
        }

        public partial class CVariadicVariable : RSequence, ICVariadicVariable
        {
            // sequence
            public CVariadicVariable(params RNode[] children) : base(children) {}

            public ROptional<ICUnionType> UnionTypeOptional => Get<ROptional<ICUnionType>>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
        }

        public partial class CLetStatement : RSequence, ICLetStatement
        {
            // sequence
            public CLetStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public CLetVariableList LetVariableList => Get<CLetVariableList>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
        }

        public partial class CDelegatedConstructor : RSequence, ICDelegatedConstructor
        {
            // sequence
            public CDelegatedConstructor(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CAssertionStatement : RSequence, ICAssertionStatement
        {
            // sequence
            public CAssertionStatement(params RNode[] children) : base(children) {}

            public ROptional<ICAssertionMessage> AssertionMessageOptional => Get<ROptional<ICAssertionMessage>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CConditions Conditions => Get<CConditions>(2);
        }

        public partial class CBlockElements : RSequence, ICBlockElements
        {
            // sequence
            public CBlockElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(1);
            public RStar<ICDeclarationOrStatement> DeclarationOrStatementStar => Get<RStar<ICDeclarationOrStatement>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CExtendedType : RSequence, ICExtendedType
        {
            // sequence
            public CExtendedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassSpecifier : RSequence, ICClassSpecifier
        {
            // sequence
            public CClassSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassInstatiation : RSequence, ICClassInstatiation
        {
            // sequence
            public CClassInstatiation(params RNode[] children) : base(children) {}

            public ICQualifiedClass QualifiedClass => Get<ICQualifiedClass>(0);
            public ROptional<ICArguments> ArgumentsOptional => Get<ROptional<ICArguments>>(1);
        }

        public partial class CSuperQualifiedClass : RSequence, ICSuperQualifiedClass
        {
            // sequence
            public CSuperQualifiedClass(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICBaseReference BaseReference => Get<ICBaseReference>(2);
        }

        public partial class CPackageQualifiedClass : RSequence, ICPackageQualifiedClass
        {
            // sequence
            public CPackageQualifiedClass(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICUnQualifiedClass UnQualifiedClass => Get<ICUnQualifiedClass>(2);
        }

        public partial class CPackageQualifier : RSequence, ICPackageQualifier
        {
            // sequence
            public CPackageQualifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
        }

        public partial class CMemberPath : RSequence, ICMemberPath
        {
            // sequence
            public CMemberPath(params RNode[] children) : base(children) {}

            public CTypePath TypePath => Get<CTypePath>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CTypePath : RLoop<CTypeReference>, ICTypePath
        {
            // sequence
            public CTypePath(params RNode[] children) : base(children) {}
        }

        public partial class CSatisfiedTypes : RSequence, ICSatisfiedTypes
        {
            // sequence
            public CSatisfiedTypes(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CUnionTypeList UnionTypeList => Get<CUnionTypeList>(1);
        }

        public partial class CUnionTypeList : RLoop<ICUnionType>, ICUnionTypeList
        {
            // sequence
            public CUnionTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CCaseTypes : RSequence, ICCaseTypes
        {
            // sequence
            public CCaseTypes(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CCaseTypeList CaseTypeList => Get<CCaseTypeList>(1);
        }

        public partial class CCaseTypeList : RLoop<ICCaseType>, ICCaseTypeList
        {
            // sequence
            public CCaseTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CQualifiedCaseType : RSequence, ICQualifiedCaseType
        {
            // sequence
            public CQualifiedCaseType(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
        }

        public partial class CParameters : RSequence, ICParameters
        {
            // sequence
            public CParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CParameterList> ParameterListOptional => Get<ROptional<CParameterList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CParameterList : RLoop<ICParameterDeclarationOrRefPattern>, ICParameterList
        {
            // sequence
            public CParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CParameter : RSequence, ICParameter
        {
            // sequence
            public CParameter(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICParameterDeclaration ParameterDeclaration => Get<ICParameterDeclaration>(1);
        }

        public partial class CParameterReference : RSequence, ICParameterReference
        {
            // sequence
            public CParameterReference(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CFunctionParameterDeclaration : RSequence, ICFunctionParameterDeclaration
        {
            // sequence
            public CFunctionParameterDeclaration(params RNode[] children) : base(children) {}

            public ICFunctionParameterType FunctionParameterType => Get<ICFunctionParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifierOptional => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CValueParameterDeclaration : RSequence, ICValueParameterDeclaration
        {
            // sequence
            public CValueParameterDeclaration(params RNode[] children) : base(children) {}

            public ICValueParameterType ValueParameterType => Get<ICValueParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(2);
        }

        public partial class CTypeParameters : RSequence, ICTypeParameters
        {
            // sequence
            public CTypeParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CTypeParameterList TypeParameterList => Get<CTypeParameterList>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeParameterList : RLoop<CTypeParameter>, ICTypeParameterList
        {
            // sequence
            public CTypeParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CTypeParameter : RSequence, ICTypeParameter
        {
            // sequence
            public CTypeParameter(params RNode[] children) : base(children) {}

            public ROptional<ICVariance> VarianceOptional => Get<ROptional<ICVariance>>(0);
            public ICTypeName TypeName => Get<ICTypeName>(1);
            public ROptional<CTypeDefault> TypeDefaultOptional => Get<ROptional<CTypeDefault>>(2);
        }

        public partial class CVariance : RLiteral, ICVariance
        {
            // alternatives
            public CVariance(params Node[] children) : base(children) {}
        }

        public partial class CTypeDefault : RSequence, ICTypeDefault
        {
            // sequence
            public CTypeDefault(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CTypeConstraint : RSequence, ICTypeConstraint
        {
            // sequence
            public CTypeConstraint(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICTypeName> TypeNameOptional => Get<ROptional<ICTypeName>>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public ROptional<CCaseTypes> CaseTypesOptional => Get<ROptional<CCaseTypes>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(4);
        }

        public partial class CTypeConstraints : RPlus<CTypeConstraint>, ICTypeConstraints
        {
            // +plus+
            public CTypeConstraints(params RNode[] children) : base(children) {}
        }

        public partial class CConstructorDeclaration : RSequence, ICConstructorDeclaration
        {
            // sequence
            public CConstructorDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ROptional<CDelegatedConstructor> DelegatedConstructorOptional => Get<ROptional<CDelegatedConstructor>>(4);
            public ICBlock Block => Get<ICBlock>(5);
        }

        public partial class CAliasDeclaration : RSequence, ICAliasDeclaration
        {
            // sequence
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(4);
            public COptionalTypeSpecifier OptionalTypeSpecifier => Get<COptionalTypeSpecifier>(5);
        }

        public partial class CEnumeratedObjectDeclaration : RSequence, ICEnumeratedObjectDeclaration
        {
            // sequence
            public CEnumeratedObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CDelegatedConstructor> DelegatedConstructorOptional => Get<ROptional<CDelegatedConstructor>>(3);
            public ICBlock Block => Get<ICBlock>(4);
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(4);
            public ICClassBlock ClassBlock => Get<ICClassBlock>(5);
        }

        public partial class CSetterDeclaration : RSequence, ICSetterDeclaration
        {
            // sequence
            public CSetterDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICSetterDefinition SetterDefinition => Get<ICSetterDefinition>(3);
        }

        public partial class CTypedMethodDeclaration : RSequence, ICTypedMethodDeclaration
        {
            // sequence
            public CTypedMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICVariadicType VariadicType => Get<ICVariadicType>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CVoidMethodDeclaration : RSequence, ICVoidMethodDeclaration
        {
            // sequence
            public CVoidMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CInferredMethodDeclaration : RSequence, ICInferredMethodDeclaration
        {
            // sequence
            public CInferredMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CTypedAttributeDeclaration : RSequence, ICTypedAttributeDeclaration
        {
            // sequence
            public CTypedAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICVariadicType VariadicType => Get<ICVariadicType>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICAttributeDefinition AttributeDefinition => Get<ICAttributeDefinition>(3);
        }

        public partial class CInferredAttributeDeclaration : RSequence, ICInferredAttributeDeclaration
        {
            // sequence
            public CInferredAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICAttributeDefinition AttributeDefinition => Get<ICAttributeDefinition>(3);
        }

        public partial class COptionalAnySpecifier : RSequence, ICOptionalAnySpecifier
        {
            // sequence
            public COptionalAnySpecifier(params RNode[] children) : base(children) {}

            public ROptional<ICAnySpecifier> AnySpecifierOptional => Get<ROptional<ICAnySpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CParameters> ParametersOptional => Get<ROptional<CParameters>>(4);
            public ROptional<CCaseTypes> CaseTypesOptional => Get<ROptional<CCaseTypes>>(5);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(6);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(7);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(8);
            public ICClassDefinition ClassDefinition => Get<ICClassDefinition>(9);
        }

        public partial class COptionalClassSpecifier : RSequence, ICOptionalClassSpecifier
        {
            // sequence
            public COptionalClassSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CClassSpecifier> ClassSpecifierOptional => Get<ROptional<CClassSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CCaseTypes> CaseTypesOptional => Get<ROptional<CCaseTypes>>(4);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(5);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(6);
            public ICInterfaceDefinition InterfaceDefinition => Get<ICInterfaceDefinition>(7);
        }

        public partial class COptionalTypeSpecifier : RSequence, ICOptionalTypeSpecifier
        {
            // sequence
            public COptionalTypeSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CTypeSpecifier> TypeSpecifierOptional => Get<ROptional<CTypeSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CUnclosedStatement : RSequence, ICUnclosedStatement
        {
            // sequence
            public CUnclosedStatement(params RNode[] children) : base(children) {}

            public ICOpenStatement OpenStatement => Get<ICOpenStatement>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CSpecificationStatement : RSequence, ICSpecificationStatement
        {
            // sequence
            public CSpecificationStatement(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(1);
        }

        public partial class CReturnStatement : RSequence, ICReturnStatement
        {
            // sequence
            public CReturnStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICExpression> ExpressionOptional => Get<ROptional<ICExpression>>(1);
        }

        public partial class CThrowStatement : RSequence, ICThrowStatement
        {
            // sequence
            public CThrowStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICExpression> ExpressionOptional => Get<ROptional<ICExpression>>(1);
        }

        public partial class CBreakStatement : RLiteral, ICBreakStatement
        {
            // string('break')
            public CBreakStatement(params Node[] children) : base(children) {}
        }

        public partial class CContinueStatement : RLiteral, ICContinueStatement
        {
            // string('continue')
            public CContinueStatement(params Node[] children) : base(children) {}
        }

        public partial class CTypeSpecifier : RSequence, ICTypeSpecifier
        {
            // sequence
            public CTypeSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CValueSpecifier : RSequence, ICValueSpecifier
        {
            // sequence
            public CValueSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            // sequence
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CParametrizedMember : RSequence, ICParametrizedMember
        {
            // sequence
            public CParametrizedMember(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(2);
        }

        public partial class CSelfParametrizedMember : RSequence, ICSelfParametrizedMember
        {
            // sequence
            public CSelfParametrizedMember(params RNode[] children) : base(children) {}

            public CSelfReferenceSelector SelfReferenceSelector => Get<CSelfReferenceSelector>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
        }

        public partial class CMemberReference : RSequence, ICMemberReference
        {
            // sequence
            public CMemberReference(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CTypeArguments> TypeArgumentsOptional => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CTypeReference : RSequence, ICTypeReference
        {
            // sequence
            public CTypeReference(params RNode[] children) : base(children) {}

            public ICTypeName TypeName => Get<ICTypeName>(0);
            public ROptional<CTypeArguments> TypeArgumentsOptional => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CSelfReferenceSelector : RSequence, ICSelfReferenceSelector
        {
            // sequence
            public CSelfReferenceSelector(params RNode[] children) : base(children) {}

            public CSelfReference SelfReference => Get<CSelfReference>(0);
            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(1);
        }

        public partial class CSelfReference : RLiteral, ICSelfReference
        {
            // alternatives
            public CSelfReference(params Node[] children) : base(children) {}
        }

        public partial class CEnumerationExpr : RSequence, ICEnumerationExpr
        {
            // sequence
            public CEnumerationExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICDeclarationOrStatement> DeclarationOrStatementStar => Get<RStar<ICDeclarationOrStatement>>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CTupleExpr : RSequence, ICTupleExpr
        {
            // sequence
            public CTupleExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CStructuralArguments : RSequence, ICStructuralArguments
        {
            // sequence
            public CStructuralArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICNamedOrAnonymous> NamedOrAnonymousStar => Get<RStar<ICNamedOrAnonymous>>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CAnonymousArgument : RSequence, ICAnonymousArgument
        {
            // sequence
            public CAnonymousArgument(params RNode[] children) : base(children) {}

            public ICExpression Expression => Get<ICExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CNamedSpecifiedArgument : RSequence, ICNamedSpecifiedArgument
        {
            // sequence
            public CNamedSpecifiedArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
            public RLiteral Literal => Get<RLiteral>(2);
        }

        public partial class CSequencedArguments : RLoop<ICSequencedArgument>, ICSequencedArguments
        {
            // sequence
            public CSequencedArguments(params RNode[] children) : base(children) {}
        }

        public partial class CObjectArgument : RSequence, ICObjectArgument
        {
            // sequence
            public CObjectArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(2);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(3);
            public ICClassBlock ClassBlock => Get<ICClassBlock>(4);
        }

        public partial class CTypedMethodArgument : RSequence, ICTypedMethodArgument
        {
            // sequence
            public CTypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMethodArgumentType MethodArgumentType => Get<ICMethodArgumentType>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class COptionalFunctionSpecifier : RSequence, ICOptionalFunctionSpecifier
        {
            // sequence
            public COptionalFunctionSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CFunctionSpecifier> FunctionSpecifierOptional => Get<ROptional<CFunctionSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CNeededFunctionSpecifier : RSequence, ICNeededFunctionSpecifier
        {
            // sequence
            public CNeededFunctionSpecifier(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CTypedGetterArgument : RSequence, ICTypedGetterArgument
        {
            // sequence
            public CTypedGetterArgument(params RNode[] children) : base(children) {}

            public ICGetterArgumentType GetterArgumentType => Get<ICGetterArgumentType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CInferredMethodArgument : RSequence, ICInferredMethodArgument
        {
            // sequence
            public CInferredMethodArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CInferredGetterArgument : RSequence, ICInferredGetterArgument
        {
            // sequence
            public CInferredGetterArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CUntypedMethodArgument : RSequence, ICUntypedMethodArgument
        {
            // sequence
            public CUntypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(1);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(2);
        }

        public partial class CUntypedGetterArgument : RSequence, ICUntypedGetterArgument
        {
            // sequence
            public CUntypedGetterArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(1);
        }

        public partial class CPositionalArguments : RSequence, ICPositionalArguments
        {
            // sequence
            public CPositionalArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CSpreadArgument : RSequence, ICSpreadArgument
        {
            // sequence
            public CSpreadArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(1);
        }

        public partial class CLetExpr : RSequence, ICLetExpr
        {
            // sequence
            public CLetExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CLetVariableList> LetVariableListOptional => Get<ROptional<CLetVariableList>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(4);
        }

        public partial class CLetVariableList : RLoop<CLetVariable>, ICLetVariableList
        {
            // sequence
            public CLetVariableList(params RNode[] children) : base(children) {}
        }

        public partial class CLetVariable : RSequence, ICLetVariable
        {
            // sequence
            public CLetVariable(params RNode[] children) : base(children) {}

            public ICPattern Pattern => Get<ICPattern>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CSwitchExpr : RSequence, ICSwitchExpr
        {
            // sequence
            public CSwitchExpr(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public CCaseExpressions CaseExpressions => Get<CCaseExpressions>(1);
        }

        public partial class CCaseExpressions : RSequence, ICCaseExpressions
        {
            // sequence
            public CCaseExpressions(params RNode[] children) : base(children) {}

            public RPlus<CCaseExpression> CaseExpressionPlus => Get<RPlus<CCaseExpression>>(0);
            public ROptional<CElseExpression> ElseExpressionOptional => Get<ROptional<CElseExpression>>(1);
        }

        public partial class CCaseExpression : RSequence, ICCaseExpression
        {
            // sequence
            public CCaseExpression(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public RLiteral Literal3 => Get<RLiteral>(2);
            public ICCaseItem CaseItem => Get<ICCaseItem>(3);
            public RLiteral Literal4 => Get<RLiteral>(4);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(5);
        }

        public partial class CIfExpr : RSequence, ICIfExpr
        {
            // sequence
            public CIfExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public CThenExpression ThenExpression => Get<CThenExpression>(2);
            public CElseExpression ElseExpression => Get<CElseExpression>(3);
        }

        public partial class CElseExpression : RSequence, ICElseExpression
        {
            // sequence
            public CElseExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CThenExpression : RSequence, ICThenExpression
        {
            // sequence
            public CThenExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CFunctionExpr : RSequence, ICFunctionExpr
        {
            // sequence
            public CFunctionExpr(params RNode[] children) : base(children) {}

            public ROptional<ICFunctionExpressionType> FunctionExpressionTypeOptional => Get<ROptional<ICFunctionExpressionType>>(0);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(1);
            public ROptional<CFunctionParameters> FunctionParametersOptional => Get<ROptional<CFunctionParameters>>(2);
            public ICFunctionDefinition FunctionDefinition => Get<ICFunctionDefinition>(3);
        }

        public partial class CFunctionExpressionType : RLiteral, ICFunctionExpressionType
        {
            // alternatives
            public CFunctionExpressionType(params Node[] children) : base(children) {}
        }

        public partial class CFunctionParameters : RSequence, ICFunctionParameters
        {
            // sequence
            public CFunctionParameters(params RNode[] children) : base(children) {}

            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(0);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(1);
        }

        public partial class CForComprehensionClause : RSequence, ICForComprehensionClause
        {
            // sequence
            public CForComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICComprehensionClause ComprehensionClause => Get<ICComprehensionClause>(4);
        }

        public partial class CIfComprehensionClause : RSequence, ICIfComprehensionClause
        {
            // sequence
            public CIfComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICComprehensionClause ComprehensionClause => Get<ICComprehensionClause>(2);
        }

        public partial class CAssignmentExpr : RSequence, ICAssignmentExpr
        {
            // sequence
            public CAssignmentExpr(params RNode[] children) : base(children) {}

            public ICThenElseExpression ThenElseExpression => Get<ICThenElseExpression>(0);
            public CAssignmentOperator AssignmentOperator => Get<CAssignmentOperator>(1);
            public ICExpression Expression => Get<ICExpression>(2);
        }

        public partial class CAssignmentOperator : RLiteral, ICAssignmentOperator
        {
            // alternatives
            public CAssignmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CThenElseExpr : RSequence, ICThenElseExpr
        {
            // sequence
            public CThenElseExpr(params RNode[] children) : base(children) {}

            public ICThenElseExpression ThenElseExpression => Get<ICThenElseExpression>(0);
            public CThenElseOperator ThenElseOperator => Get<CThenElseOperator>(1);
            public ICDisjunctionExpression DisjunctionExpression => Get<ICDisjunctionExpression>(2);
        }

        public partial class CThenElseOperator : RLiteral, ICThenElseOperator
        {
            // alternatives
            public CThenElseOperator(params Node[] children) : base(children) {}
        }

        public partial class CDisjunctionExpr : RSequence, ICDisjunctionExpr
        {
            // sequence
            public CDisjunctionExpr(params RNode[] children) : base(children) {}

            public ICDisjunctionExpression DisjunctionExpression => Get<ICDisjunctionExpression>(0);
            public CDisjunctionOperator DisjunctionOperator => Get<CDisjunctionOperator>(1);
            public ICConjunctionExpression ConjunctionExpression => Get<ICConjunctionExpression>(2);
        }

        public partial class CDisjunctionOperator : RLiteral, ICDisjunctionOperator
        {
            // string('||')
            public CDisjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CConjunctionExpr : RSequence, ICConjunctionExpr
        {
            // sequence
            public CConjunctionExpr(params RNode[] children) : base(children) {}

            public ICConjunctionExpression ConjunctionExpression => Get<ICConjunctionExpression>(0);
            public CConjunctionOperator ConjunctionOperator => Get<CConjunctionOperator>(1);
            public ICLogicalNegationExpression LogicalNegationExpression => Get<ICLogicalNegationExpression>(2);
        }

        public partial class CConjunctionOperator : RLiteral, ICConjunctionOperator
        {
            // string('&&')
            public CConjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CLogicalNegationExpr : RSequence, ICLogicalNegationExpr
        {
            // sequence
            public CLogicalNegationExpr(params RNode[] children) : base(children) {}

            public CNotOperator NotOperator => Get<CNotOperator>(0);
            public ICLogicalNegationExpression LogicalNegationExpression => Get<ICLogicalNegationExpression>(1);
        }

        public partial class CNotOperator : RLiteral, ICNotOperator
        {
            // string('!')
            public CNotOperator(params Node[] children) : base(children) {}
        }

        public partial class CEqualityExpr : RSequence, ICEqualityExpr
        {
            // sequence
            public CEqualityExpr(params RNode[] children) : base(children) {}

            public ICComparisonExpression ComparisonExpression => Get<ICComparisonExpression>(0);
            public CEqualityOperator EqualityOperator => Get<CEqualityOperator>(1);
            public ICComparisonExpression ComparisonExpression2 => Get<ICComparisonExpression>(2);
        }

        public partial class CEqualityOperator : RLiteral, ICEqualityOperator
        {
            // alternatives
            public CEqualityOperator(params Node[] children) : base(children) {}
        }

        public partial class CComparisonExpr : RSequence, ICComparisonExpr
        {
            // sequence
            public CComparisonExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CComparisonOperator ComparisonOperator => Get<CComparisonOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CLargerExpr : RSequence, ICLargerExpr
        {
            // sequence
            public CLargerExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CSmallerExpr : RSequence, ICSmallerExpr
        {
            // sequence
            public CSmallerExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CLargerBoundsExpr : RSequence, ICLargerBoundsExpr
        {
            // sequence
            public CLargerBoundsExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
            public CLargerOperator LargerOperator2 => Get<CLargerOperator>(3);
            public ICExistsNonemptyExpression ExistsNonemptyExpression3 => Get<ICExistsNonemptyExpression>(4);
        }

        public partial class CSmallerBoundsExpr : RSequence, ICSmallerBoundsExpr
        {
            // sequence
            public CSmallerBoundsExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
            public CSmallerOperator SmallerOperator2 => Get<CSmallerOperator>(3);
            public ICExistsNonemptyExpression ExistsNonemptyExpression3 => Get<ICExistsNonemptyExpression>(4);
        }

        public partial class CTypecheckExpr : RSequence, ICTypecheckExpr
        {
            // sequence
            public CTypecheckExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CTypeOperator TypeOperator => Get<CTypeOperator>(1);
            public ICType Type => Get<ICType>(2);
        }

        public partial class CComparisonOperator : RLiteral, ICComparisonOperator
        {
            // alternatives
            public CComparisonOperator(params Node[] children) : base(children) {}
        }

        public partial class CSmallerOperator : RLiteral, ICSmallerOperator
        {
            // alternatives
            public CSmallerOperator(params Node[] children) : base(children) {}
        }

        public partial class CLargerOperator : RLiteral, ICLargerOperator
        {
            // alternatives
            public CLargerOperator(params Node[] children) : base(children) {}
        }

        public partial class CTypeOperator : RLiteral, ICTypeOperator
        {
            // alternatives
            public CTypeOperator(params Node[] children) : base(children) {}
        }

        public partial class CExistsExpr : RSequence, ICExistsExpr
        {
            // sequence
            public CExistsExpr(params RNode[] children) : base(children) {}

            public ICEntryRangeExpression EntryRangeExpression => Get<ICEntryRangeExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CNonemptyExpr : RSequence, ICNonemptyExpr
        {
            // sequence
            public CNonemptyExpr(params RNode[] children) : base(children) {}

            public ICEntryRangeExpression EntryRangeExpression => Get<ICEntryRangeExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CRangeExpr : RSequence, ICRangeExpr
        {
            // sequence
            public CRangeExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CRangeOperator RangeOperator => Get<CRangeOperator>(1);
            public ICAdditiveExpression AdditiveExpression2 => Get<ICAdditiveExpression>(2);
        }

        public partial class CEntryExpr : RSequence, ICEntryExpr
        {
            // sequence
            public CEntryExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CEntryOperator EntryOperator => Get<CEntryOperator>(1);
            public ICAdditiveExpression AdditiveExpression2 => Get<ICAdditiveExpression>(2);
        }

        public partial class CRangeOperator : RLiteral, ICRangeOperator
        {
            // alternatives
            public CRangeOperator(params Node[] children) : base(children) {}
        }

        public partial class CEntryOperator : RLiteral, ICEntryOperator
        {
            // string('->')
            public CEntryOperator(params Node[] children) : base(children) {}
        }

        public partial class CAdditiveExpr : RSequence, ICAdditiveExpr
        {
            // sequence
            public CAdditiveExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CAdditiveOperator AdditiveOperator => Get<CAdditiveOperator>(1);
            public ICScaleExpression ScaleExpression => Get<ICScaleExpression>(2);
        }

        public partial class CAdditiveOperator : RLiteral, ICAdditiveOperator
        {
            // alternatives
            public CAdditiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CScaleExpr : RSequence, ICScaleExpr
        {
            // sequence
            public CScaleExpr(params RNode[] children) : base(children) {}

            public ICMultiplicativeExpression MultiplicativeExpression => Get<ICMultiplicativeExpression>(0);
            public CScaleOperator ScaleOperator => Get<CScaleOperator>(1);
            public ICScaleExpression ScaleExpression => Get<ICScaleExpression>(2);
        }

        public partial class CScaleOperator : RLiteral, ICScaleOperator
        {
            // string('**')
            public CScaleOperator(params Node[] children) : base(children) {}
        }

        public partial class CMultiplicativeExpr : RSequence, ICMultiplicativeExpr
        {
            // sequence
            public CMultiplicativeExpr(params RNode[] children) : base(children) {}

            public ICMultiplicativeExpression MultiplicativeExpression => Get<ICMultiplicativeExpression>(0);
            public CMultiplicativeOperator MultiplicativeOperator => Get<CMultiplicativeOperator>(1);
            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(2);
        }

        public partial class CMultiplicativeOperator : RLiteral, ICMultiplicativeOperator
        {
            // alternatives
            public CMultiplicativeOperator(params Node[] children) : base(children) {}
        }

        public partial class CUnionExpr : RSequence, ICUnionExpr
        {
            // sequence
            public CUnionExpr(params RNode[] children) : base(children) {}

            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(0);
            public CUnionOperator UnionOperator => Get<CUnionOperator>(1);
            public ICExclusiveExpression ExclusiveExpression => Get<ICExclusiveExpression>(2);
        }

        public partial class CUnionOperator : RLiteral, ICUnionOperator
        {
            // alternatives
            public CUnionOperator(params Node[] children) : base(children) {}
        }

        public partial class CExclusiveExpr : RSequence, ICExclusiveExpr
        {
            // sequence
            public CExclusiveExpr(params RNode[] children) : base(children) {}

            public ICExclusiveExpression ExclusiveExpression => Get<ICExclusiveExpression>(0);
            public CExclusiveOperator ExclusiveOperator => Get<CExclusiveOperator>(1);
            public ICIntersectionExpression IntersectionExpression => Get<ICIntersectionExpression>(2);
        }

        public partial class CExclusiveOperator : RLiteral, ICExclusiveOperator
        {
            // string('^')
            public CExclusiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CIntersectionExpr : RSequence, ICIntersectionExpr
        {
            // sequence
            public CIntersectionExpr(params RNode[] children) : base(children) {}

            public ICIntersectionExpression IntersectionExpression => Get<ICIntersectionExpression>(0);
            public CIntersectionOperator IntersectionOperator => Get<CIntersectionOperator>(1);
            public ICNegationOrComplementExpression NegationOrComplementExpression => Get<ICNegationOrComplementExpression>(2);
        }

        public partial class CIntersectionOperator : RLiteral, ICIntersectionOperator
        {
            // string('&')
            public CIntersectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CNegationOrComplementExpr : RSequence, ICNegationOrComplementExpr
        {
            // sequence
            public CNegationOrComplementExpr(params RNode[] children) : base(children) {}

            public ICUnaryMinusOrComplementOperator UnaryMinusOrComplementOperator => Get<ICUnaryMinusOrComplementOperator>(0);
            public ICNegationOrComplementExpression NegationOrComplementExpression => Get<ICNegationOrComplementExpression>(1);
        }

        public partial class CNegateOperator : RSequence, ICNegateOperator
        {
            // sequence
            public CNegateOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RNot<RLiteral> Literal2Not => Get<RNot<RLiteral>>(1);
        }

        public partial class CNeutralOperator : RSequence, ICNeutralOperator
        {
            // sequence
            public CNeutralOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RNot<RLiteral> Literal2Not => Get<RNot<RLiteral>>(1);
        }

        public partial class CComplementOperator : RLiteral, ICComplementOperator
        {
            // string('~')
            public CComplementOperator(params Node[] children) : base(children) {}
        }

        public partial class CPrefixExpr : RSequence, ICPrefixExpr
        {
            // sequence
            public CPrefixExpr(params RNode[] children) : base(children) {}

            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(0);
            public ICPrefixExpression PrefixExpression => Get<ICPrefixExpression>(1);
        }

        public partial class CPostfixExpr : RSequence, ICPostfixExpr
        {
            // sequence
            public CPostfixExpr(params RNode[] children) : base(children) {}

            public ICPostfixExpression PostfixExpression => Get<ICPostfixExpression>(0);
            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(1);
        }

        public partial class CIncrementOperator : RLiteral, ICIncrementOperator
        {
            // alternatives
            public CIncrementOperator(params Node[] children) : base(children) {}
        }

        public partial class CSelectionExpr : RSequence, ICSelectionExpr
        {
            // sequence
            public CSelectionExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public CQualifiedReference QualifiedReference => Get<CQualifiedReference>(1);
        }

        public partial class CQualifiedReference : RSequence, ICQualifiedReference
        {
            // sequence
            public CQualifiedReference(params RNode[] children) : base(children) {}

            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(0);
            public ICBaseReference BaseReference => Get<ICBaseReference>(1);
        }

        public partial class CMemberSelectionOperator : RLiteral, ICMemberSelectionOperator
        {
            // alternatives
            public CMemberSelectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CIndexedExpr : RSequence, ICIndexedExpr
        {
            // sequence
            public CIndexedExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndex Index => Get<ICIndex>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CUpperSpanned : RSequence, ICUpperSpanned
        {
            // sequence
            public CUpperSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CLowerSpanned : RSequence, ICLowerSpanned
        {
            // sequence
            public CLowerSpanned(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(1);
        }

        public partial class CSpanned : RSequence, ICSpanned
        {
            // sequence
            public CSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndexExpression IndexExpression2 => Get<ICIndexExpression>(2);
        }

        public partial class CMeasured : RSequence, ICMeasured
        {
            // sequence
            public CMeasured(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndexExpression IndexExpression2 => Get<ICIndexExpression>(2);
        }

        public partial class CCallExpr : RSequence, ICCallExpr
        {
            // sequence
            public CCallExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public ICArguments Arguments => Get<ICArguments>(1);
        }

        public partial class CStringInterpolation : RSequence, ICStringInterpolation
        {
            // sequence
            public CStringInterpolation(params RNode[] children) : base(children) {}

            public CStringStart StringStart => Get<CStringStart>(0);
            public ICExpression Expression => Get<ICExpression>(1);
            public RStar<CInterpolationPart> InterpolationPartStar => Get<RStar<CInterpolationPart>>(2);
            public CStringEnd StringEnd => Get<CStringEnd>(3);
        }

        public partial class CInterpolationPart : RSequence, ICInterpolationPart
        {
            // sequence
            public CInterpolationPart(params RNode[] children) : base(children) {}

            public CStringMid StringMid => Get<CStringMid>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CObjectExpr : RSequence, ICObjectExpr
        {
            // sequence
            public CObjectExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(1);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(2);
            public ICClassBlock ClassBlock => Get<ICClassBlock>(3);
        }

        public partial class CGroupedExpr : RSequence, ICGroupedExpr
        {
            // sequence
            public CGroupedExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeArguments : RSequence, ICTypeArguments
        {
            // sequence
            public CTypeArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CTypeArgumentList> TypeArgumentListOptional => Get<ROptional<CTypeArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeArgumentList : RLoop<CVariancedType>, ICTypeArgumentList
        {
            // sequence
            public CTypeArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CVariancedType : RSequence, ICVariancedType
        {
            // sequence
            public CVariancedType(params RNode[] children) : base(children) {}

            public ROptional<ICVariance> VarianceOptional => Get<ROptional<ICVariance>>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CDefaultedTypeList : RLoop<ICDefaultedType>, ICDefaultedTypeList
        {
            // sequence
            public CDefaultedTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CDefaultedTypeCore : RSequence, ICDefaultedTypeCore
        {
            // sequence
            public CDefaultedTypeCore(params RNode[] children) : base(children) {}

            public ICType Type => Get<ICType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CVariadicUnionType : RSequence, ICVariadicUnionType
        {
            // sequence
            public CVariadicUnionType(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
        }

        public partial class CVariadicOperator : RLiteral, ICVariadicOperator
        {
            // alternatives
            public CVariadicOperator(params Node[] children) : base(children) {}
        }

        public partial class CSpreadType : RSequence, ICSpreadType
        {
            // sequence
            public CSpreadType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICUnionType UnionType => Get<ICUnionType>(1);
        }

        public partial class CEntryType : RSequence, ICEntryType
        {
            // sequence
            public CEntryType(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICUnionType UnionType2 => Get<ICUnionType>(2);
        }

        public partial class CUnionTypeCore : RSequence, ICUnionTypeCore
        {
            // sequence
            public CUnionTypeCore(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(2);
        }

        public partial class CIntersectionTypeCore : RSequence, ICIntersectionTypeCore
        {
            // sequence
            public CIntersectionTypeCore(params RNode[] children) : base(children) {}

            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(2);
        }

        public partial class CNullableType : RSequence, ICNullableType
        {
            // sequence
            public CNullableType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CArrayType : RSequence, ICArrayType
        {
            // sequence
            public CArrayType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ROptional<CLiteralNatural> LiteralNaturalOptional => Get<ROptional<CLiteralNatural>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CFunctionType : RSequence, ICFunctionType
        {
            // sequence
            public CFunctionType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CTupleType : RSequence, ICTupleType
        {
            // sequence
            public CTupleType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CIterableType : RSequence, ICIterableType
        {
            // sequence
            public CIterableType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICVariadicType> VariadicTypeOptional => Get<ROptional<ICVariadicType>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CGroupedType : RSequence, ICGroupedType
        {
            // sequence
            public CGroupedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CPackageQualifiedType : RSequence, ICPackageQualifiedType
        {
            // sequence
            public CPackageQualifiedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public CTypePath TypePath => Get<CTypePath>(2);
        }

        public partial class CAnnotations : RSequence, ICAnnotations
        {
            // sequence
            public CAnnotations(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteralOptional => Get<ROptional<ICStringLiteral>>(0);
            public RStar<CAnnotation> AnnotationStar => Get<RStar<CAnnotation>>(1);
        }

        public partial class CAnnotation : RSequence, ICAnnotation
        {
            // sequence
            public CAnnotation(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<ICArguments> ArgumentsOptional => Get<ROptional<ICArguments>>(1);
        }

        public partial class CConditions : RSequence, ICConditions
        {
            // sequence
            public CConditions(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CConditionList> ConditionListOptional => Get<ROptional<CConditionList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CConditionList : RLoop<ICCondition>, ICConditionList
        {
            // sequence
            public CConditionList(params RNode[] children) : base(children) {}
        }

        public partial class CExistsCondition : RSequence, ICExistsCondition
        {
            // sequence
            public CExistsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CNonemptyCondition : RSequence, ICNonemptyCondition
        {
            // sequence
            public CNonemptyCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CIsCondition : RSequence, ICIsCondition
        {
            // sequence
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICType Type => Get<ICType>(2);
            public CIsConditionVariable IsConditionVariable => Get<CIsConditionVariable>(3);
        }

        public partial class CIsConditionVariable : RSequence, ICIsConditionVariable
        {
            // sequence
            public CIsConditionVariable(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CSatisfiesCondition : RSequence, ICSatisfiesCondition
        {
            // sequence
            public CSatisfiesCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
        }

        public partial class CIfElseStatement : RSequence, ICIfElseStatement
        {
            // sequence
            public CIfElseStatement(params RNode[] children) : base(children) {}

            public CIfBlock IfBlock => Get<CIfBlock>(0);
            public ROptional<CElseBlock> ElseBlockOptional => Get<ROptional<CElseBlock>>(1);
        }

        public partial class CIfBlock : RSequence, ICIfBlock
        {
            // sequence
            public CIfBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CElseBlock : RSequence, ICElseBlock
        {
            // sequence
            public CElseBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICElseBlockNext ElseBlockNext => Get<ICElseBlockNext>(1);
        }

        public partial class CSwitchStatement : RSequence, ICSwitchStatement
        {
            // sequence
            public CSwitchStatement(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public RPlus<CCaseBlock> CaseBlockPlus => Get<RPlus<CCaseBlock>>(1);
            public ROptional<CElseBlock> ElseBlockOptional => Get<ROptional<CElseBlock>>(2);
        }

        public partial class CSwitchHeader : RSequence, ICSwitchHeader
        {
            // sequence
            public CSwitchHeader(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICSwitched Switched => Get<ICSwitched>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
        }

        public partial class CCaseBlock : RSequence, ICCaseBlock
        {
            // sequence
            public CCaseBlock(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public RLiteral Literal3 => Get<RLiteral>(2);
            public ICCaseItem CaseItem => Get<ICCaseItem>(3);
            public RLiteral Literal4 => Get<RLiteral>(4);
            public ICBlock Block => Get<ICBlock>(5);
        }

        public partial class CIsCaseCondition : RSequence, ICIsCaseCondition
        {
            // sequence
            public CIsCaseCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CSatisfiesCaseCondition : RSequence, ICSatisfiesCaseCondition
        {
            // sequence
            public CSatisfiesCaseCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CValueCaseList : RLoop<ICValueCase>, ICValueCaseList
        {
            // sequence
            public CValueCaseList(params RNode[] children) : base(children) {}
        }

        public partial class CValueCaseSeparator : RLiteral, ICValueCaseSeparator
        {
            // alternatives
            public CValueCaseSeparator(params Node[] children) : base(children) {}
        }

        public partial class CForElseStatement : RSequence, ICForElseStatement
        {
            // sequence
            public CForElseStatement(params RNode[] children) : base(children) {}

            public CForBlock ForBlock => Get<CForBlock>(0);
            public ROptional<CFailBlock> FailBlockOptional => Get<ROptional<CFailBlock>>(1);
        }

        public partial class CForBlock : RSequence, ICForBlock
        {
            // sequence
            public CForBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICBlock Block => Get<ICBlock>(4);
        }

        public partial class CFailBlock : RSequence, ICFailBlock
        {
            // sequence
            public CFailBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICBlock Block => Get<ICBlock>(1);
        }

        public partial class CForIterator : RSequence, ICForIterator
        {
            // sequence
            public CForIterator(params RNode[] children) : base(children) {}

            public ICForVariable ForVariable => Get<ICForVariable>(0);
            public ROptional<CContainment> ContainmentOptional => Get<ROptional<CContainment>>(1);
        }

        public partial class CContainment : RSequence, ICContainment
        {
            // sequence
            public CContainment(params RNode[] children) : base(children) {}

            public CContainmentOperator ContainmentOperator => Get<CContainmentOperator>(0);
            public ICOperatorExpression OperatorExpression => Get<ICOperatorExpression>(1);
        }

        public partial class CContainmentOperator : RLiteral, ICContainmentOperator
        {
            // alternatives
            public CContainmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CWhileStatement : RSequence, ICWhileStatement
        {
            // sequence
            public CWhileStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CTryStatement : RSequence, ICTryStatement
        {
            // sequence
            public CTryStatement(params RNode[] children) : base(children) {}

            public CTryBlock TryBlock => Get<CTryBlock>(0);
            public RStar<CCatchBlock> CatchBlockStar => Get<RStar<CCatchBlock>>(1);
            public ROptional<CFinallyBlock> FinallyBlockOptional => Get<ROptional<CFinallyBlock>>(2);
        }

        public partial class CTryBlock : RSequence, ICTryBlock
        {
            // sequence
            public CTryBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CResources> ResourcesOptional => Get<ROptional<CResources>>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CCatchBlock : RSequence, ICCatchBlock
        {
            // sequence
            public CCatchBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CCatchVariable CatchVariable => Get<CCatchVariable>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CCatchVariable : RSequence, ICCatchVariable
        {
            // sequence
            public CCatchVariable(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CVariable> VariableOptional => Get<ROptional<CVariable>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CFinallyBlock : RSequence, ICFinallyBlock
        {
            // sequence
            public CFinallyBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICBlock Block => Get<ICBlock>(1);
        }

        public partial class CResources : RSequence, ICResources
        {
            // sequence
            public CResources(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CResourceList> ResourceListOptional => Get<ROptional<CResourceList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CResourceList : RLoop<ICResource>, ICResourceList
        {
            // sequence
            public CResourceList(params RNode[] children) : base(children) {}
        }

        public partial class CSpecifiedVariable : RSequence, ICSpecifiedVariable
        {
            // sequence
            public CSpecifiedVariable(params RNode[] children) : base(children) {}

            public CVariable Variable => Get<CVariable>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CVariable : RSequence, ICVariable
        {
            // sequence
            public CVariable(params RNode[] children) : base(children) {}

            public ROptional<ICVariableType> VariableTypeOptional => Get<ROptional<ICVariableType>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public RStar<CParameters> ParametersStar => Get<RStar<CParameters>>(2);
        }

        public partial class CModelReference : RSequence, ICModelReference
        {
            // sequence
            public CModelReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICModelExpression ModelExpression => Get<ICModelExpression>(1);
        }

        public partial class CMetaLiteral : RSequence, ICMetaLiteral
        {
            // sequence
            public CMetaLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICMetaExpression MetaExpression => Get<ICMetaExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CPackageQualifiedMemberReference : RSequence, ICPackageQualifiedMemberReference
        {
            // sequence
            public CPackageQualifiedMemberReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CTypeQualifiedMemberReference : RSequence, ICTypeQualifiedMemberReference
        {
            // sequence
            public CTypeQualifiedMemberReference(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CModuleLiteral : RSequence, ICModuleLiteral
        {
            // sequence
            public CModuleLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CPackageLiteral : RSequence, ICPackageLiteral
        {
            // sequence
            public CPackageLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CClassLiteral : RSequence, ICClassLiteral
        {
            // sequence
            public CClassLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CInterfaceLiteral : RSequence, ICInterfaceLiteral
        {
            // sequence
            public CInterfaceLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CAliasLiteral : RSequence, ICAliasLiteral
        {
            // sequence
            public CAliasLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CTypeParameterLiteral : RSequence, ICTypeParameterLiteral
        {
            // sequence
            public CTypeParameterLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CNewLiteral : RSequence, ICNewLiteral
        {
            // sequence
            public CNewLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteral : RSequence, ICValueLiteral
        {
            // sequence
            public CValueLiteral(params RNode[] children) : base(children) {}

            public CValueLiteralIntro ValueLiteralIntro => Get<CValueLiteralIntro>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteralIntro : RLiteral, ICValueLiteralIntro
        {
            // alternatives
            public CValueLiteralIntro(params Node[] children) : base(children) {}
        }

        public partial class CFunctionLiteral : RSequence, ICFunctionLiteral
        {
            // sequence
            public CFunctionLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CReferencePath : RSequence, ICReferencePath
        {
            // sequence
            public CReferencePath(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public CReferencePathElementList ReferencePathElementList => Get<CReferencePathElementList>(1);
        }

        public partial class CReferencePathElementList : RLoop<ICReferencePathElement>, ICReferencePathElementList
        {
            // sequence
            public CReferencePathElementList(params RNode[] children) : base(children) {}
        }

        public partial class CKwVoid : RLiteral, ICKwVoid
        {
            // string('void')
            public CKwVoid(params Node[] children) : base(children) {}
        }

        public partial class CKwFunction : RLiteral, ICKwFunction
        {
            // string('function')
            public CKwFunction(params Node[] children) : base(children) {}
        }

        public partial class CKwValue : RLiteral, ICKwValue
        {
            // string('value')
            public CKwValue(params Node[] children) : base(children) {}
        }

        public partial class CLiteralFloat : RToken, ICLiteralFloat
        {
            // token
            public CLiteralFloat(params Node[] children) : base(children) {}
        }

        public partial class CLiteralNatural : RToken, ICLiteralNatural
        {
            // token
            public CLiteralNatural(params Node[] children) : base(children) {}
        }

        public partial class CLiteralChar : RToken, ICLiteralChar
        {
            // token
            public CLiteralChar(params Node[] children) : base(children) {}
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

        public partial class CLiteralString : RToken, ICLiteralString
        {
            // token
            public CLiteralString(params Node[] children) : base(children) {}
        }

        public partial class CVerbatimString : RToken, ICVerbatimString
        {
            // token
            public CVerbatimString(params Node[] children) : base(children) {}
        }

        public partial class CLowerIdentifier : RToken, ICLowerIdentifier
        {
            // token
            public CLowerIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CUpperIdentifier : RToken, ICUpperIdentifier
        {
            // token
            public CUpperIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CIdentifier : RToken, ICIdentifier
        {
            // token
            public CIdentifier(params Node[] children) : base(children) {}
        }

        public partial class DynamicCeylonVisitor : DynamicVisitor
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

            protected virtual void Visit(CUnitElements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportDeclarations element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleDescriptor element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArtifactAndClassifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CArtifact element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageDescriptor element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportModule element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportElements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportElementList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportNamed element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportNameSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImportWildcard element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackagePath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEntryPattern element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTuplePattern element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariadicPatternList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariadicVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDelegatedConstructor element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssertionStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBlockElements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExtendedType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassInstatiation element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSuperQualifiedClass element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageQualifiedClass element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageQualifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMemberPath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypePath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSatisfiedTypes element)
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

            protected virtual void Visit(CQualifiedCaseType element)
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

            protected virtual void Visit(CParameterReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionParameterDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueParameterDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeParameters element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeParameterList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariance element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeDefault element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeConstraint element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeConstraints element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConstructorDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAliasDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEnumeratedObjectDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CObjectDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSetterDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedMethodDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVoidMethodDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredMethodDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedAttributeDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredAttributeDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalAnySpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalClassSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalTypeSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnclosedStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpecificationStatement element)
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

            protected virtual void Visit(CBreakStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CContinueStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CParametrizedMember element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSelfParametrizedMember element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMemberReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSelfReferenceSelector element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSelfReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEnumerationExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTupleExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CStructuralArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAnonymousArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNamedSpecifiedArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSequencedArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CObjectArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedMethodArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNeededFunctionSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedGetterArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredMethodArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredGetterArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUntypedMethodArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUntypedGetterArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPositionalArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpreadArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetVariableList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSwitchExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCaseExpressions element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCaseExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElseExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThenExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionExpressionType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionParameters element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CForComprehensionClause element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfComprehensionClause element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssignmentExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssignmentOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThenElseExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThenElseOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDisjunctionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDisjunctionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConjunctionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConjunctionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLogicalNegationExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNotOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEqualityExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEqualityOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CComparisonExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLargerExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSmallerExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLargerBoundsExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSmallerBoundsExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypecheckExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CComparisonOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSmallerOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLargerOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExistsExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNonemptyExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CRangeExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEntryExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CRangeOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEntryOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAdditiveExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAdditiveOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CScaleExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CScaleOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMultiplicativeExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMultiplicativeOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExclusiveExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExclusiveOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNegationOrComplementExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNegateOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNeutralOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CComplementOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPrefixExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPostfixExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIncrementOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSelectionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CQualifiedReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMemberSelectionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIndexedExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUpperSpanned element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLowerSpanned element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpanned element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMeasured element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCallExpr element)
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

            protected virtual void Visit(CObjectExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGroupedExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeArgumentList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariancedType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDefaultedTypeList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDefaultedTypeCore element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariadicUnionType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariadicOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpreadType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEntryType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUnionTypeCore element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionTypeCore element)
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

            protected virtual void Visit(CFunctionType element)
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

            protected virtual void Visit(CGroupedType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageQualifiedType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAnnotations element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAnnotation element)
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

            protected virtual void Visit(CExistsCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNonemptyCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIsCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIsConditionVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSatisfiesCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfElseStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIfBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CElseBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSwitchStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSwitchHeader element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCaseBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIsCaseCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSatisfiesCaseCondition element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueCaseList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueCaseSeparator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CForElseStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CForBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFailBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CForIterator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CContainment element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CContainmentOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CWhileStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTryStatement element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTryBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCatchBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CCatchVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFinallyBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CResources element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CResourceList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSpecifiedVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVariable element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModelReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CMetaLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageQualifiedMemberReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeQualifiedMemberReference element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInterfaceLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAliasLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypeParameterLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNewLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CValueLiteralIntro element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionLiteral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CReferencePath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CReferencePathElementList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CKwVoid element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CKwFunction element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CKwValue element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLiteralFloat element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLiteralNatural element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLiteralChar element)
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

            protected virtual void Visit(CLiteralString element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CVerbatimString element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLowerIdentifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUpperIdentifier element)
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
