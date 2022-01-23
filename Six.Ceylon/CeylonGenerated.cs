// <generated from="d:\\Six\\Six.Ceylon\\Ceylon.six" at="23.01.2022 06:12:25" />

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
                : base(new Matcher[882])
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
                /*  29 PlainRuleOp      */ __Matchers[29] = _annotationName = new PlainRule(this, 29, "annotation-name") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _memberName = new PlainRule(this, 30, "member-name") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _typeName = new PlainRule(this, 31, "type-name") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _pattern = new PlainRule(this, 32, "pattern") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _variableOrTuplePattern = new PlainRule(this, 33, "variable-or-tuple-pattern") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _tupleOrEntryPattern = new PlainRule(this, 34, "tuple-or-entry-pattern") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _entryPattern = new PlainRule(this, 35, "entry-pattern") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _tuplePattern = new PlainRule(this, 36, "tuple-pattern") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _variadicPatternList = new PlainRule(this, 37, "variadic-pattern-list") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _variadicPattern = new PlainRule(this, 38, "variadic-pattern") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _variablePattern = new PlainRule(this, 39, "variable-pattern") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _variadicVariable = new PlainRule(this, 40, "variadic-variable") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _letStatement = new PlainRule(this, 41, "let-statement") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _delegatedConstructor = new PlainRule(this, 42, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _assertionStatement = new PlainRule(this, 43, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _assertionMessage = new PlainRule(this, 44, "assertion-message") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _block = new PlainRule(this, 45, "block") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _interfaceBlock = new PlainRule(this, 46, "interface-block") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _classBlock = new PlainRule(this, 47, "class-block") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _blockElements = new PlainRule(this, 48, "block-elements") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _extendedType = new PlainRule(this, 49, "extended-type") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _classSpecifier = new PlainRule(this, 50, "class-specifier") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _classInstatiation = new PlainRule(this, 51, "class-instatiation") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _qualifiedClass = new PlainRule(this, 52, "qualified-class") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _superQualifiedClass = new PlainRule(this, 53, "super-qualified-class") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _superQualifier = new PlainRule(this, 54, "super-qualifier") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _packageQualifiedClass = new PlainRule(this, 55, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _packageQualifier = new PlainRule(this, 56, "package-qualifier") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _unQualifiedClass = new PlainRule(this, 57, "un-qualified-class") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _memberPath = new PlainRule(this, 58, "member-path") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _typePath = new PlainRule(this, 59, "type-path") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _satisfiedTypes = new PlainRule(this, 60, "satisfied-types") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _unionTypeList = new PlainRule(this, 61, "union-type-list") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _caseTypes = new PlainRule(this, 62, "case-types") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _caseTypeList = new PlainRule(this, 63, "case-type-list") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _caseType = new PlainRule(this, 64, "case-type") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _qualifiedCaseType = new PlainRule(this, 65, "qualified-case-type") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _parameters = new PlainRule(this, 66, "parameters") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _parameterList = new PlainRule(this, 67, "parameter-list") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _parameterDeclarationOrRefPattern = new PlainRule(this, 68, "parameter-declaration-or-ref-pattern") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _parameter = new PlainRule(this, 69, "parameter") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _parameterReference = new PlainRule(this, 70, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _parameterDeclaration = new PlainRule(this, 71, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _functionParameterDeclaration = new PlainRule(this, 72, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _functionParameterType = new PlainRule(this, 73, "function-parameter-type") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _valueParameterDeclaration = new PlainRule(this, 74, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _valueParameterType = new PlainRule(this, 75, "value-parameter-type") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _typeParameters = new PlainRule(this, 76, "type-parameters") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _typeParameterList = new PlainRule(this, 77, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _typeParameter = new PlainRule(this, 78, "type-parameter") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _variance = new PlainRule(this, 79, "variance") { Creator = node => new CVariance(node) };
                /*  80 PlainRuleOp      */ __Matchers[80] = _typeDefault = new PlainRule(this, 80, "type-default") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _typeConstraint = new PlainRule(this, 81, "type-constraint") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _typeConstraints = new PlainRule(this, 82, "type-constraints") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _declarationOrStatement = new PlainRule(this, 83, "declaration-or-statement") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _declaration = new PlainRule(this, 84, "declaration") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _constructorDeclaration = new PlainRule(this, 85, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _aliasDeclaration = new PlainRule(this, 86, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _enumeratedObject = new PlainRule(this, 87, "enumerated-object") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _objectDeclaration = new PlainRule(this, 88, "object-declaration") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _setterDeclaration = new PlainRule(this, 89, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _setterDefinition = new PlainRule(this, 90, "setter-definition") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _typedMethodDeclaration = new PlainRule(this, 91, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _methodType = new PlainRule(this, 92, "method-type") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _inferredMethodDeclaration = new PlainRule(this, 93, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _typedAttributeDeclaration = new PlainRule(this, 94, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _attributeType = new PlainRule(this, 95, "attribute-type") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _inferredAttributeDeclaration = new PlainRule(this, 96, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _attributeDefinition = new PlainRule(this, 97, "attribute-definition") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _optionalAnySpecifier = new PlainRule(this, 98, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _classDeclaration = new PlainRule(this, 99, "class-declaration") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _classDefinition = new PlainRule(this, 100, "class-definition") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _optionalClassSpecifier = new PlainRule(this, 101, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _interfaceDeclaration = new PlainRule(this, 102, "interface-declaration") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _interfaceDefinition = new PlainRule(this, 103, "interface-definition") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _optionalTypeSpecifier = new PlainRule(this, 104, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _statement = new PlainRule(this, 105, "statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _unclosedStatement = new PlainRule(this, 106, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _openStatement = new PlainRule(this, 107, "open-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _specificationStatement = new PlainRule(this, 108, "specification-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _expressionStatement = new PlainRule(this, 109, "expression-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _directiveStatement = new PlainRule(this, 110, "directive-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _returnStatement = new PlainRule(this, 111, "return-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _throwStatement = new PlainRule(this, 112, "throw-statement") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _breakStatement = new PlainRule(this, 113, "break-statement") { Creator = node => new CBreakStatement(node) };
                /* 114 PlainRuleOp      */ __Matchers[114] = _continueStatement = new PlainRule(this, 114, "continue-statement") { Creator = node => new CContinueStatement(node) };
                /* 115 PlainRuleOp      */ __Matchers[115] = _typeSpecifier = new PlainRule(this, 115, "type-specifier") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _valueSpecifier = new PlainRule(this, 116, "value-specifier") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _functionSpecifier = new PlainRule(this, 117, "function-specifier") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _anySpecifier = new PlainRule(this, 118, "any-specifier") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _baseReferenceOrParameterized = new PlainRule(this, 119, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _baseReference = new PlainRule(this, 120, "base-reference") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _parametrizedMember = new PlainRule(this, 121, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _selfParametrizedMember = new PlainRule(this, 122, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _memberReference = new PlainRule(this, 123, "member-reference") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _typeReference = new PlainRule(this, 124, "type-reference") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _selfReferenceSelector = new PlainRule(this, 125, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _selfReference = new PlainRule(this, 126, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 127 PlainRuleOp      */ __Matchers[127] = _enumerationExpr = new PlainRule(this, 127, "enumeration-expr") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _tupleExpr = new PlainRule(this, 128, "tuple-expr") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _arguments = new PlainRule(this, 129, "arguments") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _structuralArguments = new PlainRule(this, 130, "structural-arguments") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _namedOrAnonymous = new PlainRule(this, 131, "named-or-anonymous") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _namedArgument = new PlainRule(this, 132, "named-argument") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _namedSpecifiedArgument = new PlainRule(this, 133, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _sequencedArguments = new PlainRule(this, 134, "sequenced-arguments") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _sequencedArgument = new PlainRule(this, 135, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _anonymousArgument = new PlainRule(this, 136, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _namedArgumentDeclaration = new PlainRule(this, 137, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _objectArgument = new PlainRule(this, 138, "object-argument") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _typedMethodArgument = new PlainRule(this, 139, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _methodDefinition = new PlainRule(this, 140, "method-definition") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _optionalFunctionSpecifier = new PlainRule(this, 141, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _neededFunctionSpecifier = new PlainRule(this, 142, "needed-function-specifier") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _methodArgumentType = new PlainRule(this, 143, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _typedGetterArgument = new PlainRule(this, 144, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _getterArgumentType = new PlainRule(this, 145, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _inferredMethodArgument = new PlainRule(this, 146, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _inferredGetterArgument = new PlainRule(this, 147, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _untypedMethodArgument = new PlainRule(this, 148, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _untypedGetterArgument = new PlainRule(this, 149, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _positionalArguments = new PlainRule(this, 150, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _positionalArgument = new PlainRule(this, 151, "positional-argument") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _spreadArgument = new PlainRule(this, 152, "spread-argument") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _letExpr = new PlainRule(this, 153, "let-expr") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _letVariableList = new PlainRule(this, 154, "let-variable-list") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _letVariable = new PlainRule(this, 155, "let-variable") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _switchExpr = new PlainRule(this, 156, "switch-expr") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _caseExpressions = new PlainRule(this, 157, "case-expressions") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _caseExpression = new PlainRule(this, 158, "case-expression") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _ifExpr = new PlainRule(this, 159, "if-expr") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _elseExpression = new PlainRule(this, 160, "else-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _thenExpression = new PlainRule(this, 161, "then-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _conditionalExpression = new PlainRule(this, 162, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _functionExpr = new PlainRule(this, 163, "function-expr") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _functionExpressionType = new PlainRule(this, 164, "function-expression-type") { Creator = node => new CFunctionExpressionType(node) };
                /* 165 PlainRuleOp      */ __Matchers[165] = _functionParameters = new PlainRule(this, 165, "function-parameters") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _functionDefinition = new PlainRule(this, 166, "function-definition") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _comprehensionArgument = new PlainRule(this, 167, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _comprehensionClause = new PlainRule(this, 168, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _expressionComprehensionClause = new PlainRule(this, 169, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _forComprehensionClause = new PlainRule(this, 170, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _ifComprehensionClause = new PlainRule(this, 171, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _expression = new PlainRule(this, 172, "expression") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _operatorExpression = new PlainRule(this, 173, "operator-expression") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _assignmentExpression = new PlainRule(this, 174, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _assignmentExpr = new PlainRule(this, 175, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _assignmentOperator = new PlainRule(this, 176, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 177 PlainRuleOp      */ __Matchers[177] = _thenElseExpression = new PlainRule(this, 177, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _thenElseExpr = new PlainRule(this, 178, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 179 PlainRuleOp      */ __Matchers[179] = _thenElseOperator = new PlainRule(this, 179, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 180 PlainRuleOp      */ __Matchers[180] = _disjunctionExpression = new PlainRule(this, 180, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _disjunctionExpr = new PlainRule(this, 181, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _disjunctionOperator = new PlainRule(this, 182, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 183 PlainRuleOp      */ __Matchers[183] = _conjunctionExpression = new PlainRule(this, 183, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _conjunctionExpr = new PlainRule(this, 184, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _conjunctionOperator = new PlainRule(this, 185, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 186 PlainRuleOp      */ __Matchers[186] = _logicalNegationExpression = new PlainRule(this, 186, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _logicalNegationExpr = new PlainRule(this, 187, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _notOperator = new PlainRule(this, 188, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 189 PlainRuleOp      */ __Matchers[189] = _expressionOrMeta = new PlainRule(this, 189, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _equalityExpression = new PlainRule(this, 190, "equality-expression") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _equalityExpr = new PlainRule(this, 191, "equality-expr") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _equalityOperator = new PlainRule(this, 192, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 193 PlainRuleOp      */ __Matchers[193] = _comparisonExpression = new PlainRule(this, 193, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _comparisonExpr = new PlainRule(this, 194, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 195 PlainRuleOp      */ __Matchers[195] = _largerExpr = new PlainRule(this, 195, "larger-expr") { Builder = nodes => nodes[0] };
                /* 196 PlainRuleOp      */ __Matchers[196] = _smallerExpr = new PlainRule(this, 196, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _largerBoundsExpr = new PlainRule(this, 197, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _smallerBoundsExpr = new PlainRule(this, 198, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 199 PlainRuleOp      */ __Matchers[199] = _typecheckExpr = new PlainRule(this, 199, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 200 PlainRuleOp      */ __Matchers[200] = _comparisonOperator = new PlainRule(this, 200, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 201 PlainRuleOp      */ __Matchers[201] = _smallerOperator = new PlainRule(this, 201, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 202 PlainRuleOp      */ __Matchers[202] = _largerOperator = new PlainRule(this, 202, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 203 PlainRuleOp      */ __Matchers[203] = _typeOperator = new PlainRule(this, 203, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 204 PlainRuleOp      */ __Matchers[204] = _existsNonemptyExpression = new PlainRule(this, 204, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 205 PlainRuleOp      */ __Matchers[205] = _existsExpr = new PlainRule(this, 205, "exists-expr") { Builder = nodes => nodes[0] };
                /* 206 PlainRuleOp      */ __Matchers[206] = _nonemptyExpr = new PlainRule(this, 206, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _entryRangeExpression = new PlainRule(this, 207, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 208 PlainRuleOp      */ __Matchers[208] = _rangeExpr = new PlainRule(this, 208, "range-expr") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _entryExpr = new PlainRule(this, 209, "entry-expr") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _rangeOperator = new PlainRule(this, 210, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 211 PlainRuleOp      */ __Matchers[211] = _entryOperator = new PlainRule(this, 211, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 212 PlainRuleOp      */ __Matchers[212] = _additiveExpression = new PlainRule(this, 212, "additive-expression") { Builder = nodes => nodes[0] };
                /* 213 PlainRuleOp      */ __Matchers[213] = _additiveExpr = new PlainRule(this, 213, "additive-expr") { Builder = nodes => nodes[0] };
                /* 214 PlainRuleOp      */ __Matchers[214] = _additiveOperator = new PlainRule(this, 214, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 215 PlainRuleOp      */ __Matchers[215] = _scaleExpression = new PlainRule(this, 215, "scale-expression") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _scaleExpr = new PlainRule(this, 216, "scale-expr") { Builder = nodes => nodes[0] };
                /* 217 PlainRuleOp      */ __Matchers[217] = _scaleOperator = new PlainRule(this, 217, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 218 PlainRuleOp      */ __Matchers[218] = _multiplicativeExpression = new PlainRule(this, 218, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _multiplicativeExpr = new PlainRule(this, 219, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 220 PlainRuleOp      */ __Matchers[220] = _multiplicativeOperator = new PlainRule(this, 220, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 221 PlainRuleOp      */ __Matchers[221] = _unionExpression = new PlainRule(this, 221, "union-expression") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _unionExpr = new PlainRule(this, 222, "union-expr") { Builder = nodes => nodes[0] };
                /* 223 PlainRuleOp      */ __Matchers[223] = _unionOperator = new PlainRule(this, 223, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 224 PlainRuleOp      */ __Matchers[224] = _exclusiveExpression = new PlainRule(this, 224, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _exclusiveExpr = new PlainRule(this, 225, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _exclusiveOperator = new PlainRule(this, 226, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 227 PlainRuleOp      */ __Matchers[227] = _intersectionExpression = new PlainRule(this, 227, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _intersectionExpr = new PlainRule(this, 228, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 229 PlainRuleOp      */ __Matchers[229] = _intersectionOperator = new PlainRule(this, 229, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 230 PlainRuleOp      */ __Matchers[230] = _negationOrComplementExpression = new PlainRule(this, 230, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _negationOrComplementExpr = new PlainRule(this, 231, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _unaryMinusOrComplementOperator = new PlainRule(this, 232, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _negateOperator = new PlainRule(this, 233, "negate-operator") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _neutralOperator = new PlainRule(this, 234, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _complementOperator = new PlainRule(this, 235, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 236 PlainRuleOp      */ __Matchers[236] = _prefixExpression = new PlainRule(this, 236, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _prefixExpr = new PlainRule(this, 237, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _postfixExpression = new PlainRule(this, 238, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _postfixExpr = new PlainRule(this, 239, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _incrementOperator = new PlainRule(this, 240, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 241 PlainRuleOp      */ __Matchers[241] = _primary = new PlainRule(this, 241, "primary") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _selectionExpr = new PlainRule(this, 242, "selection-expr") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _qualifiedReference = new PlainRule(this, 243, "qualified-reference") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _memberSelectionOperator = new PlainRule(this, 244, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 245 PlainRuleOp      */ __Matchers[245] = _indexedExpr = new PlainRule(this, 245, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _index = new PlainRule(this, 246, "index") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _upperSpanned = new PlainRule(this, 247, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _lowerSpanned = new PlainRule(this, 248, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _spanned = new PlainRule(this, 249, "spanned") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _measured = new PlainRule(this, 250, "measured") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _indexExpression = new PlainRule(this, 251, "index-expression") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _callExpr = new PlainRule(this, 252, "call-expr") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _baseExpression = new PlainRule(this, 253, "base-expression") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _nonstringLiteral = new PlainRule(this, 254, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _stringExpression = new PlainRule(this, 255, "string-expression") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _stringInterpolation = new PlainRule(this, 256, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _interpolationPart = new PlainRule(this, 257, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _stringLiteral = new PlainRule(this, 258, "string-literal") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _objectExpr = new PlainRule(this, 259, "object-expr") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _groupedExpr = new PlainRule(this, 260, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _typeArguments = new PlainRule(this, 261, "type-arguments") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _typeArgumentList = new PlainRule(this, 262, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _variancedType = new PlainRule(this, 263, "varianced-type") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _defaultedTypeList = new PlainRule(this, 264, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _defaultedType = new PlainRule(this, 265, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _defaultedTypeCore = new PlainRule(this, 266, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _variadicType = new PlainRule(this, 267, "variadic-type") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _variadicUnionType = new PlainRule(this, 268, "variadic-union-type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _variadicOperator = new PlainRule(this, 269, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /* 270 PlainRuleOp      */ __Matchers[270] = _spreadType = new PlainRule(this, 270, "spread-type") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _type = new PlainRule(this, 271, "type") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _entryType = new PlainRule(this, 272, "entry-type") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _unionType = new PlainRule(this, 273, "union-type") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _unionTypeCore = new PlainRule(this, 274, "union-type-core") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _intersectionType = new PlainRule(this, 275, "intersection-type") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _intersectionTypeCore = new PlainRule(this, 276, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _primaryType = new PlainRule(this, 277, "primary-type") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _nullableType = new PlainRule(this, 278, "nullable-type") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _arrayType = new PlainRule(this, 279, "array-type") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _functionType = new PlainRule(this, 280, "function-type") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _typeTypeArguments = new PlainRule(this, 281, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _tupleType = new PlainRule(this, 282, "tuple-type") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _iterableType = new PlainRule(this, 283, "iterable-type") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _groupedType = new PlainRule(this, 284, "grouped-type") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _qualifiedType = new PlainRule(this, 285, "qualified-type") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _annotations = new PlainRule(this, 286, "annotations") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _annotation = new PlainRule(this, 287, "annotation") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _conditions = new PlainRule(this, 288, "conditions") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _conditionList = new PlainRule(this, 289, "condition-list") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _condition = new PlainRule(this, 290, "condition") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _existsCondition = new PlainRule(this, 291, "exists-condition") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _nonemptyCondition = new PlainRule(this, 292, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _letOrExpression = new PlainRule(this, 293, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _isCondition = new PlainRule(this, 294, "is-condition") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _isConditionVariable = new PlainRule(this, 295, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _satisfiesCondition = new PlainRule(this, 296, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _booleanCondition = new PlainRule(this, 297, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _controlStatement = new PlainRule(this, 298, "control-statement") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _ifElseStatement = new PlainRule(this, 299, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _ifBlock = new PlainRule(this, 300, "if-block") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _elseBlock = new PlainRule(this, 301, "else-block") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _elseBlockNext = new PlainRule(this, 302, "else-block-next") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _switchStatement = new PlainRule(this, 303, "switch-statement") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _switchHeader = new PlainRule(this, 304, "switch-header") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _switched = new PlainRule(this, 305, "switched") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _caseBlock = new PlainRule(this, 306, "case-block") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _caseItem = new PlainRule(this, 307, "case-item") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _isCaseCondition = new PlainRule(this, 308, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _satisfiesCaseCondition = new PlainRule(this, 309, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _matchCaseCondition = new PlainRule(this, 310, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _valueCaseList = new PlainRule(this, 311, "value-case-list") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _valueCaseSeparator = new PlainRule(this, 312, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 313 PlainRuleOp      */ __Matchers[313] = _valueCase = new PlainRule(this, 313, "value-case") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _forElseStatement = new PlainRule(this, 314, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _forBlock = new PlainRule(this, 315, "for-block") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _failBlock = new PlainRule(this, 316, "fail-block") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _forIterator = new PlainRule(this, 317, "for-iterator") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _forVariable = new PlainRule(this, 318, "for-variable") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _containment = new PlainRule(this, 319, "containment") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _containmentOperator = new PlainRule(this, 320, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 321 PlainRuleOp      */ __Matchers[321] = _whileStatement = new PlainRule(this, 321, "while-statement") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _tryStatement = new PlainRule(this, 322, "try-statement") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _tryBlock = new PlainRule(this, 323, "try-block") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _catchBlock = new PlainRule(this, 324, "catch-block") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _catchVariable = new PlainRule(this, 325, "catch-variable") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _finallyBlock = new PlainRule(this, 326, "finally-block") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _resources = new PlainRule(this, 327, "resources") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _resourceList = new PlainRule(this, 328, "resource-list") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _resource = new PlainRule(this, 329, "resource") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _specifiedOrExpression = new PlainRule(this, 330, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _specifiedVariable = new PlainRule(this, 331, "specified-variable") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _variable = new PlainRule(this, 332, "variable") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _variableType = new PlainRule(this, 333, "variable-type") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _modelReference = new PlainRule(this, 334, "model-reference") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _metaLiteral = new PlainRule(this, 335, "meta-literal") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _metaExpression = new PlainRule(this, 336, "meta-expression") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _modelExpression = new PlainRule(this, 337, "model-expression") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _memberModelExpression = new PlainRule(this, 338, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _packageQualifiedMemberReference = new PlainRule(this, 339, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _typeQualifiedMemberReference = new PlainRule(this, 340, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _typeModelExpression = new PlainRule(this, 341, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _declarationReference = new PlainRule(this, 342, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _moduleLiteral = new PlainRule(this, 343, "module-literal") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _packageLiteral = new PlainRule(this, 344, "package-literal") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _classLiteral = new PlainRule(this, 345, "class-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _interfaceLiteral = new PlainRule(this, 346, "interface-literal") { Builder = nodes => nodes[0] };
                /* 347 PlainRuleOp      */ __Matchers[347] = _aliasLiteral = new PlainRule(this, 347, "alias-literal") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _typeParameterLiteral = new PlainRule(this, 348, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 349 PlainRuleOp      */ __Matchers[349] = _newLiteral = new PlainRule(this, 349, "new-literal") { Builder = nodes => nodes[0] };
                /* 350 PlainRuleOp      */ __Matchers[350] = _valueLiteral = new PlainRule(this, 350, "value-literal") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _valueLiteralIntro = new PlainRule(this, 351, "value-literal-intro") { Creator = node => new CValueLiteralIntro(node) };
                /* 352 PlainRuleOp      */ __Matchers[352] = _functionLiteral = new PlainRule(this, 352, "function-literal") { Builder = nodes => nodes[0] };
                /* 353 PlainRuleOp      */ __Matchers[353] = _referencePath = new PlainRule(this, 353, "reference-path") { Builder = nodes => nodes[0] };
                /* 354 PlainRuleOp      */ __Matchers[354] = _referencePathElementList = new PlainRule(this, 354, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 355 PlainRuleOp      */ __Matchers[355] = _referencePathElement = new PlainRule(this, 355, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 356 PlainRuleOp      */ __Matchers[356] = _kwVoid = new PlainRule(this, 356, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 357 PlainRuleOp      */ __Matchers[357] = _kwFunction = new PlainRule(this, 357, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 358 PlainRuleOp      */ __Matchers[358] = _kwValue = new PlainRule(this, 358, "kw-value") { Creator = node => new CKwValue(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _literalFloat = new DfaRule(this, 359, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _literalNatural = new DfaRule(this, 360, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _literalChar = new DfaRule(this, 361, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _stringStart = new DfaRule(this, 362, "string-start") { Creator = node => new CStringStart(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _stringMid = new DfaRule(this, 363, "string-mid") { Creator = node => new CStringMid(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _stringEnd = new DfaRule(this, 364, "string-end") { Creator = node => new CStringEnd(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _literalString = new DfaRule(this, 365, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 366 DfaRuleOp        */ __Matchers[366] = _verbatimString = new DfaRule(this, 366, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 367 DfaRuleOp        */ __Matchers[367] = _lowerIdentifier = new DfaRule(this, 367, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 368 DfaRuleOp        */ __Matchers[368] = _upperIdentifier = new DfaRule(this, 368, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 369 DfaRuleOp        */ __Matchers[369] = _identifier = new DfaRule(this, 369, "identifier") { Creator = node => new CIdentifier(node) };
                /* 370 EofOp            */ __Matchers[370] = new Eof(this, 370, "<eof>") { Creator = node => new REof(node) };
                /* 371 SeqOp            */ __Matchers[371] = new Seq(this, 371, "_371:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 372 AltOp            */ __Matchers[372] = new Alt(this, 372, "alt(>module-descriptor|>package-descriptor|>unit-elements)") { Builder = nodes => nodes[0] };
                /* 373 StarOp           */ __Matchers[373] = new Star(this, 373, "*(>declaration)") { Builder = nodes => new RStar<ICDeclaration>(nodes) };
                /* 374 SeqOp            */ __Matchers[374] = new Seq(this, 374, "_374:(>import-declarations,*(>declaration))") { Builder = nodes => new CUnitElements(nodes) };
                /* 375 StarOp           */ __Matchers[375] = new Star(this, 375, "*(>import-declaration)") { Builder = nodes => new CImportDeclarations(nodes) };
                /* 376 StringOp         */ __Matchers[376] = new Keyword(this, 376, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 377 OptionalOp       */ __Matchers[377] = new Optional(this, 377, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 378 OptionalOp       */ __Matchers[378] = new Optional(this, 378, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Seq(this, 379, "_379:(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new String(this, 380, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 381 OptionalOp       */ __Matchers[381] = new Optional(this, 381, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 382 SeqOp            */ __Matchers[382] = new Seq(this, 382, "_382:(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 383 AltOp            */ __Matchers[383] = new Alt(this, 383, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 384 OptionalOp       */ __Matchers[384] = new Optional(this, 384, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 385 SeqOp            */ __Matchers[385] = new Seq(this, 385, "_385:(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 386 SeqOp            */ __Matchers[386] = new Seq(this, 386, "_386:(':',>literal-string)") { Builder = nodes => new CArtifact(nodes) };
                /* 387 SeqOp            */ __Matchers[387] = new Seq(this, 387, "_387:(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 388 StringOp         */ __Matchers[388] = new String(this, 388, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 389 StarOp           */ __Matchers[389] = new Star(this, 389, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 390 StringOp         */ __Matchers[390] = new String(this, 390, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 391 SeqOp            */ __Matchers[391] = new Seq(this, 391, "_391:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 392 AltOp            */ __Matchers[392] = new Alt(this, 392, "alt(>inferred-attribute-declaration|>import-module)") { Builder = nodes => nodes[0] };
                /* 393 StringOp         */ __Matchers[393] = new Keyword(this, 393, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 394 StringOp         */ __Matchers[394] = new String(this, 394, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 395 SeqOp            */ __Matchers[395] = new Seq(this, 395, "_395:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 396 StringOp         */ __Matchers[396] = new Keyword(this, 396, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 397 SeqOp            */ __Matchers[397] = new Seq(this, 397, "_397:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CImportModule(nodes) };
                /* 398 SeqOp            */ __Matchers[398] = new Seq(this, 398, "_398:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 399 OptionalOp       */ __Matchers[399] = new Optional(this, 399, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 400 SeqOp            */ __Matchers[400] = new Seq(this, 400, "_400:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 401 StringOp         */ __Matchers[401] = new String(this, 401, "','", ",") { Creator = node => new RLiteral(node) };
                /* 402 SeqOp            */ __Matchers[402] = new Seq(this, 402, "_402:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 403 StarOp           */ __Matchers[403] = new Star(this, 403, "*(_402:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 404 SeqOp            */ __Matchers[404] = new Seq(this, 404, "_404:(>import-element,*(_402:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 405 AltOp            */ __Matchers[405] = new Alt(this, 405, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 406 OptionalOp       */ __Matchers[406] = new Optional(this, 406, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 407 OptionalOp       */ __Matchers[407] = new Optional(this, 407, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 408 SeqOp            */ __Matchers[408] = new Seq(this, 408, "_408:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 409 StringOp         */ __Matchers[409] = new String(this, 409, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 410 SeqOp            */ __Matchers[410] = new Seq(this, 410, "_410:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 411 StringOp         */ __Matchers[411] = new String(this, 411, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 412 StringOp         */ __Matchers[412] = new String(this, 412, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 413 SeqOp            */ __Matchers[413] = new Seq(this, 413, "_413:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 414 StarOp           */ __Matchers[414] = new Star(this, 414, "*(_413:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 415 SeqOp            */ __Matchers[415] = new Seq(this, 415, "_415:(>package-name,*(_413:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 416 AltOp            */ __Matchers[416] = new Alt(this, 416, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 417 AltOp            */ __Matchers[417] = new Alt(this, 417, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 418 AltOp            */ __Matchers[418] = new Alt(this, 418, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 419 StringOp         */ __Matchers[419] = new String(this, 419, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 420 SeqOp            */ __Matchers[420] = new Seq(this, 420, "_420:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 421 StringOp         */ __Matchers[421] = new String(this, 421, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 422 OptionalOp       */ __Matchers[422] = new Optional(this, 422, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 423 StringOp         */ __Matchers[423] = new String(this, 423, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 424 SeqOp            */ __Matchers[424] = new Seq(this, 424, "_424:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Seq(this, 425, "_425:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 426 StarOp           */ __Matchers[426] = new Star(this, 426, "*(_425:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Seq(this, 427, "_427:(>variadic-pattern,*(_425:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 428 AltOp            */ __Matchers[428] = new Alt(this, 428, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 429 OptionalOp       */ __Matchers[429] = new Optional(this, 429, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 430 OptionalOp       */ __Matchers[430] = new Optional(this, 430, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 431 SeqOp            */ __Matchers[431] = new Seq(this, 431, "_431:(?(>union-type),>variadic-operator,?(>member-name))") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 432 StringOp         */ __Matchers[432] = new Keyword(this, 432, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 434 StringOp         */ __Matchers[434] = new String(this, 434, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 435 SeqOp            */ __Matchers[435] = new Seq(this, 435, "_435:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 436 StringOp         */ __Matchers[436] = new Keyword(this, 436, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 437 SeqOp            */ __Matchers[437] = new Seq(this, 437, "_437:('extends',>class-instatiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 438 OptionalOp       */ __Matchers[438] = new Optional(this, 438, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 439 StringOp         */ __Matchers[439] = new Keyword(this, 439, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 440 SeqOp            */ __Matchers[440] = new Seq(this, 440, "_440:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 441 StarOp           */ __Matchers[441] = new Star(this, 441, "*(>declaration-or-statement)") { Builder = nodes => new RStar<ICDeclarationOrStatement>(nodes) };
                /* 442 SeqOp            */ __Matchers[442] = new Seq(this, 442, "_442:('{',>import-declarations,*(>declaration-or-statement),'}')") { Builder = nodes => new CBlockElements(nodes) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_443:('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 444 StringOp         */ __Matchers[444] = new String(this, 444, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_445:('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 446 OptionalOp       */ __Matchers[446] = new Optional(this, 446, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_447:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 448 AltOp            */ __Matchers[448] = new Alt(this, 448, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 449 SeqOp            */ __Matchers[449] = new Seq(this, 449, "_449:(>super-qualifier,>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 450 StringOp         */ __Matchers[450] = new Keyword(this, 450, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 451 SeqOp            */ __Matchers[451] = new Seq(this, 451, "_451:('super','.')") { Builder = nodes => new CSuperQualifier(nodes) };
                /* 452 SeqOp            */ __Matchers[452] = new Seq(this, 452, "_452:(>package-qualifier,>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_453:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 454 AltOp            */ __Matchers[454] = new Alt(this, 454, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 455 SeqOp            */ __Matchers[455] = new Seq(this, 455, "_455:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 457 StarOp           */ __Matchers[457] = new Star(this, 457, "*(_456:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_458:(>type-reference,*(_456:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 459 StringOp         */ __Matchers[459] = new Keyword(this, 459, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 460 SeqOp            */ __Matchers[460] = new Seq(this, 460, "_460:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_461:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 462 StarOp           */ __Matchers[462] = new Star(this, 462, "*(_461:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 463 SeqOp            */ __Matchers[463] = new Seq(this, 463, "_463:(>union-type,*(_461:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 464 StringOp         */ __Matchers[464] = new Keyword(this, 464, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 465 SeqOp            */ __Matchers[465] = new Seq(this, 465, "_465:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 466 StringOp         */ __Matchers[466] = new String(this, 466, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 467 SeqOp            */ __Matchers[467] = new Seq(this, 467, "_467:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 468 StarOp           */ __Matchers[468] = new Star(this, 468, "*(_467:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 469 SeqOp            */ __Matchers[469] = new Seq(this, 469, "_469:(>case-type,*(_467:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 470 AltOp            */ __Matchers[470] = new Alt(this, 470, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 471 OptionalOp       */ __Matchers[471] = new Optional(this, 471, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_472:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 473 OptionalOp       */ __Matchers[473] = new Optional(this, 473, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 474 SeqOp            */ __Matchers[474] = new Seq(this, 474, "_474:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_475:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 476 StarOp           */ __Matchers[476] = new Star(this, 476, "*(_475:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 477 SeqOp            */ __Matchers[477] = new Seq(this, 477, "_477:(>parameter-declaration-or-ref-pattern,*(_475:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 478 AltOp            */ __Matchers[478] = new Alt(this, 478, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 479 SeqOp            */ __Matchers[479] = new Seq(this, 479, "_479:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 480 OptionalOp       */ __Matchers[480] = new Optional(this, 480, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 481 SeqOp            */ __Matchers[481] = new Seq(this, 481, "_481:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 482 AltOp            */ __Matchers[482] = new Alt(this, 482, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 483 OptionalOp       */ __Matchers[483] = new Optional(this, 483, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 484 PlusOp           */ __Matchers[484] = new Plus(this, 484, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 485 OptionalOp       */ __Matchers[485] = new Optional(this, 485, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 486 SeqOp            */ __Matchers[486] = new Seq(this, 486, "_486:(>function-parameter-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CFunctionParameterDeclaration(nodes) };
                /* 487 AltOp            */ __Matchers[487] = new Alt(this, 487, "alt(>variadic-type|>kw-void|>kw-function)") { Builder = nodes => nodes[0] };
                /* 488 SeqOp            */ __Matchers[488] = new Seq(this, 488, "_488:(>value-parameter-type,>member-name,?(>value-specifier))") { Builder = nodes => new CValueParameterDeclaration(nodes) };
                /* 489 AltOp            */ __Matchers[489] = new Alt(this, 489, "alt(>variadic-type|>kw-value)") { Builder = nodes => nodes[0] };
                /* 490 StringOp         */ __Matchers[490] = new String(this, 490, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 491 StringOp         */ __Matchers[491] = new String(this, 491, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 492 SeqOp            */ __Matchers[492] = new Seq(this, 492, "_492:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 493 SeqOp            */ __Matchers[493] = new Seq(this, 493, "_493:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 494 StarOp           */ __Matchers[494] = new Star(this, 494, "*(_493:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 495 SeqOp            */ __Matchers[495] = new Seq(this, 495, "_495:(>type-parameter,*(_493:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 496 OptionalOp       */ __Matchers[496] = new Optional(this, 496, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 497 OptionalOp       */ __Matchers[497] = new Optional(this, 497, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 498 SeqOp            */ __Matchers[498] = new Seq(this, 498, "_498:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 499 StringOp         */ __Matchers[499] = new Keyword(this, 499, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 500 StringOp         */ __Matchers[500] = new Keyword(this, 500, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 501 AltOp            */ __Matchers[501] = new Alt(this, 501, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 502 SeqOp            */ __Matchers[502] = new Seq(this, 502, "_502:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 503 StringOp         */ __Matchers[503] = new Keyword(this, 503, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 504 OptionalOp       */ __Matchers[504] = new Optional(this, 504, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 505 OptionalOp       */ __Matchers[505] = new Optional(this, 505, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 506 OptionalOp       */ __Matchers[506] = new Optional(this, 506, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 507 SeqOp            */ __Matchers[507] = new Seq(this, 507, "_507:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 508 PlusOp           */ __Matchers[508] = new Plus(this, 508, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 509 AltOp            */ __Matchers[509] = new Alt(this, 509, "alt(>declaration|>statement)") { Builder = nodes => nodes[0] };
                /* 510 AltOp            */ __Matchers[510] = new Alt(this, 510, "alt(>constructor-declaration|>alias-declaration|>class-declaration|>interface-declaration|>object-declaration|>enumerated-object|>setter-declaration|>typed-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 511 StringOp         */ __Matchers[511] = new Keyword(this, 511, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 512 OptionalOp       */ __Matchers[512] = new Optional(this, 512, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 513 SeqOp            */ __Matchers[513] = new Seq(this, 513, "_513:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 514 StringOp         */ __Matchers[514] = new Keyword(this, 514, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 515 OptionalOp       */ __Matchers[515] = new Optional(this, 515, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 516 SeqOp            */ __Matchers[516] = new Seq(this, 516, "_516:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 517 SeqOp            */ __Matchers[517] = new Seq(this, 517, "_517:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObject(nodes) };
                /* 518 StringOp         */ __Matchers[518] = new Keyword(this, 518, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 519 OptionalOp       */ __Matchers[519] = new Optional(this, 519, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 520 SeqOp            */ __Matchers[520] = new Seq(this, 520, "_520:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 521 StringOp         */ __Matchers[521] = new Keyword(this, 521, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 522 SeqOp            */ __Matchers[522] = new Seq(this, 522, "_522:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 523 AltOp            */ __Matchers[523] = new Alt(this, 523, "alt(>block|>needed-function-specifier)") { Builder = nodes => nodes[0] };
                /* 524 SeqOp            */ __Matchers[524] = new Seq(this, 524, "_524:(>annotations,>method-type,>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 525 AltOp            */ __Matchers[525] = new Alt(this, 525, "alt(>variadic-type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 527 SeqOp            */ __Matchers[527] = new Seq(this, 527, "_527:(>annotations,'function',>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 528 SeqOp            */ __Matchers[528] = new Seq(this, 528, "_528:(>annotations,>attribute-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 529 StringOp         */ __Matchers[529] = new Keyword(this, 529, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_530:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 531 AltOp            */ __Matchers[531] = new Alt(this, 531, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 532 OptionalOp       */ __Matchers[532] = new Optional(this, 532, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 533 SeqOp            */ __Matchers[533] = new Seq(this, 533, "_533:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 534 StringOp         */ __Matchers[534] = new Keyword(this, 534, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 535 OptionalOp       */ __Matchers[535] = new Optional(this, 535, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 536 SeqOp            */ __Matchers[536] = new Seq(this, 536, "_536:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 537 AltOp            */ __Matchers[537] = new Alt(this, 537, "alt(>class-block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 538 OptionalOp       */ __Matchers[538] = new Optional(this, 538, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 539 SeqOp            */ __Matchers[539] = new Seq(this, 539, "_539:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 540 StringOp         */ __Matchers[540] = new Keyword(this, 540, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 541 SeqOp            */ __Matchers[541] = new Seq(this, 541, "_541:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 542 AltOp            */ __Matchers[542] = new Alt(this, 542, "alt(>interface-block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 543 OptionalOp       */ __Matchers[543] = new Optional(this, 543, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 544 SeqOp            */ __Matchers[544] = new Seq(this, 544, "_544:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 545 AltOp            */ __Matchers[545] = new Alt(this, 545, "alt(>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 546 SeqOp            */ __Matchers[546] = new Seq(this, 546, "_546:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 547 AltOp            */ __Matchers[547] = new Alt(this, 547, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 548 SeqOp            */ __Matchers[548] = new Seq(this, 548, "_548:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 549 AltOp            */ __Matchers[549] = new Alt(this, 549, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 550 StringOp         */ __Matchers[550] = new Keyword(this, 550, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 551 OptionalOp       */ __Matchers[551] = new Optional(this, 551, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 552 SeqOp            */ __Matchers[552] = new Seq(this, 552, "_552:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 553 StringOp         */ __Matchers[553] = new Keyword(this, 553, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 554 SeqOp            */ __Matchers[554] = new Seq(this, 554, "_554:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 555 StringOp         */ __Matchers[555] = new Keyword(this, 555, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 556 StringOp         */ __Matchers[556] = new Keyword(this, 556, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 557 SeqOp            */ __Matchers[557] = new Seq(this, 557, "_557:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 558 SeqOp            */ __Matchers[558] = new Seq(this, 558, "_558:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 559 SeqOp            */ __Matchers[559] = new Seq(this, 559, "_559:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 560 AltOp            */ __Matchers[560] = new Alt(this, 560, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 561 AltOp            */ __Matchers[561] = new Alt(this, 561, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 562 AltOp            */ __Matchers[562] = new Alt(this, 562, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_563:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_564:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 565 OptionalOp       */ __Matchers[565] = new Optional(this, 565, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 566 SeqOp            */ __Matchers[566] = new Seq(this, 566, "_566:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 567 SeqOp            */ __Matchers[567] = new Seq(this, 567, "_567:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 568 SeqOp            */ __Matchers[568] = new Seq(this, 568, "_568:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 569 StringOp         */ __Matchers[569] = new Keyword(this, 569, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 570 StringOp         */ __Matchers[570] = new Keyword(this, 570, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 571 AltOp            */ __Matchers[571] = new Alt(this, 571, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 572 OptionalOp       */ __Matchers[572] = new Optional(this, 572, "?(>sequenced-arguments)") { Builder = nodes => new ROptional<CSequencedArguments>(nodes) };
                /* 573 SeqOp            */ __Matchers[573] = new Seq(this, 573, "_573:('{',*(>declaration-or-statement),?(>sequenced-arguments),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 574 SeqOp            */ __Matchers[574] = new Seq(this, 574, "_574:('[',?(>sequenced-arguments),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 575 AltOp            */ __Matchers[575] = new Alt(this, 575, "alt(>structural-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 576 StarOp           */ __Matchers[576] = new Star(this, 576, "*(>named-or-anonymous)") { Builder = nodes => new RStar<ICNamedOrAnonymous>(nodes) };
                /* 577 SeqOp            */ __Matchers[577] = new Seq(this, 577, "_577:('{',*(>named-or-anonymous),?(>sequenced-arguments),'}')") { Builder = nodes => new CStructuralArguments(nodes) };
                /* 578 AltOp            */ __Matchers[578] = new Alt(this, 578, "alt(>named-argument|>anonymous-argument)") { Builder = nodes => nodes[0] };
                /* 579 AltOp            */ __Matchers[579] = new Alt(this, 579, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_580:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 581 SeqOp            */ __Matchers[581] = new Seq(this, 581, "_581:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 582 StarOp           */ __Matchers[582] = new Star(this, 582, "*(_581:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 583 SeqOp            */ __Matchers[583] = new Seq(this, 583, "_583:(>sequenced-argument,*(_581:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArguments(nodes) };
                /* 584 AltOp            */ __Matchers[584] = new Alt(this, 584, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_585:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 586 AltOp            */ __Matchers[586] = new Alt(this, 586, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 587 SeqOp            */ __Matchers[587] = new Seq(this, 587, "_587:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 589 AltOp            */ __Matchers[589] = new Alt(this, 589, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 590 SeqOp            */ __Matchers[590] = new Seq(this, 590, "_590:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:(>function-specifier,';')") { Builder = nodes => new CNeededFunctionSpecifier(nodes) };
                /* 592 AltOp            */ __Matchers[592] = new Alt(this, 592, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_593:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_594:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_595:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 596 SeqOp            */ __Matchers[596] = new Seq(this, 596, "_596:(>member-name,+(>parameters),>needed-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_597:(>member-name,>needed-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_598:('(',?(>sequenced-arguments),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 599 AltOp            */ __Matchers[599] = new Alt(this, 599, "alt(>expression|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 600 StringOp         */ __Matchers[600] = new String(this, 600, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 601 SeqOp            */ __Matchers[601] = new Seq(this, 601, "_601:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 602 OptionalOp       */ __Matchers[602] = new Optional(this, 602, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_603:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 604 SeqOp            */ __Matchers[604] = new Seq(this, 604, "_604:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 605 StarOp           */ __Matchers[605] = new Star(this, 605, "*(_604:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 606 SeqOp            */ __Matchers[606] = new Seq(this, 606, "_606:(>let-variable,*(_604:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 608 SeqOp            */ __Matchers[608] = new Seq(this, 608, "_608:(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 609 PlusOp           */ __Matchers[609] = new Plus(this, 609, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 610 OptionalOp       */ __Matchers[610] = new Optional(this, 610, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 611 SeqOp            */ __Matchers[611] = new Seq(this, 611, "_611:(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 612 StringOp         */ __Matchers[612] = new Keyword(this, 612, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 613 OptionalOp       */ __Matchers[613] = new Optional(this, 613, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 614 StringOp         */ __Matchers[614] = new Keyword(this, 614, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 615 SeqOp            */ __Matchers[615] = new Seq(this, 615, "_615:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 616 StringOp         */ __Matchers[616] = new Keyword(this, 616, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 618 SeqOp            */ __Matchers[618] = new Seq(this, 618, "_618:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 619 StringOp         */ __Matchers[619] = new Keyword(this, 619, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 620 SeqOp            */ __Matchers[620] = new Seq(this, 620, "_620:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 621 AltOp            */ __Matchers[621] = new Alt(this, 621, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 622 OptionalOp       */ __Matchers[622] = new Optional(this, 622, "?(>function-expression-type)") { Builder = nodes => new ROptional<ICFunctionExpressionType>(nodes) };
                /* 623 OptionalOp       */ __Matchers[623] = new Optional(this, 623, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 624 SeqOp            */ __Matchers[624] = new Seq(this, 624, "_624:(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpr(nodes) };
                /* 625 StringOp         */ __Matchers[625] = new Keyword(this, 625, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 626 AltOp            */ __Matchers[626] = new Alt(this, 626, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 627 SeqOp            */ __Matchers[627] = new Seq(this, 627, "_627:(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 628 AltOp            */ __Matchers[628] = new Alt(this, 628, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 629 AltOp            */ __Matchers[629] = new Alt(this, 629, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 630 AltOp            */ __Matchers[630] = new Alt(this, 630, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 631 StringOp         */ __Matchers[631] = new Keyword(this, 631, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 632 OptionalOp       */ __Matchers[632] = new Optional(this, 632, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 633 SeqOp            */ __Matchers[633] = new Seq(this, 633, "_633:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 634 SeqOp            */ __Matchers[634] = new Seq(this, 634, "_634:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 635 AltOp            */ __Matchers[635] = new Alt(this, 635, "alt(>let-expr|>if-expr|>switch-expr|>function-expr|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 636 AltOp            */ __Matchers[636] = new Alt(this, 636, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 637 SeqOp            */ __Matchers[637] = new Seq(this, 637, "_637:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 638 StringOp         */ __Matchers[638] = new String(this, 638, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 639 StringOp         */ __Matchers[639] = new String(this, 639, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 640 StringOp         */ __Matchers[640] = new String(this, 640, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 647 StringOp         */ __Matchers[647] = new String(this, 647, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 648 StringOp         */ __Matchers[648] = new String(this, 648, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 649 AltOp            */ __Matchers[649] = new Alt(this, 649, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 650 AltOp            */ __Matchers[650] = new Alt(this, 650, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 651 SeqOp            */ __Matchers[651] = new Seq(this, 651, "_651:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 652 AltOp            */ __Matchers[652] = new Alt(this, 652, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 653 AltOp            */ __Matchers[653] = new Alt(this, 653, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 654 SeqOp            */ __Matchers[654] = new Seq(this, 654, "_654:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 655 StringOp         */ __Matchers[655] = new String(this, 655, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 656 AltOp            */ __Matchers[656] = new Alt(this, 656, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 657 SeqOp            */ __Matchers[657] = new Seq(this, 657, "_657:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 658 StringOp         */ __Matchers[658] = new String(this, 658, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 659 AltOp            */ __Matchers[659] = new Alt(this, 659, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 660 SeqOp            */ __Matchers[660] = new Seq(this, 660, "_660:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 661 StringOp         */ __Matchers[661] = new String(this, 661, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 662 AltOp            */ __Matchers[662] = new Alt(this, 662, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 663 AltOp            */ __Matchers[663] = new Alt(this, 663, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 664 SeqOp            */ __Matchers[664] = new Seq(this, 664, "_664:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 665 StringOp         */ __Matchers[665] = new String(this, 665, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 666 StringOp         */ __Matchers[666] = new String(this, 666, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 667 StringOp         */ __Matchers[667] = new String(this, 667, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 668 AltOp            */ __Matchers[668] = new Alt(this, 668, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 669 AltOp            */ __Matchers[669] = new Alt(this, 669, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 670 SeqOp            */ __Matchers[670] = new Seq(this, 670, "_670:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_671:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 672 SeqOp            */ __Matchers[672] = new Seq(this, 672, "_672:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 673 SeqOp            */ __Matchers[673] = new Seq(this, 673, "_673:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 674 SeqOp            */ __Matchers[674] = new Seq(this, 674, "_674:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 675 SeqOp            */ __Matchers[675] = new Seq(this, 675, "_675:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 676 StringOp         */ __Matchers[676] = new String(this, 676, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 677 AltOp            */ __Matchers[677] = new Alt(this, 677, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 678 StringOp         */ __Matchers[678] = new String(this, 678, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 679 AltOp            */ __Matchers[679] = new Alt(this, 679, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 680 StringOp         */ __Matchers[680] = new String(this, 680, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 681 AltOp            */ __Matchers[681] = new Alt(this, 681, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 682 StringOp         */ __Matchers[682] = new Keyword(this, 682, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 683 AltOp            */ __Matchers[683] = new Alt(this, 683, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 684 AltOp            */ __Matchers[684] = new Alt(this, 684, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 685 StringOp         */ __Matchers[685] = new Keyword(this, 685, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 686 SeqOp            */ __Matchers[686] = new Seq(this, 686, "_686:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 687 StringOp         */ __Matchers[687] = new Keyword(this, 687, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 688 SeqOp            */ __Matchers[688] = new Seq(this, 688, "_688:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 689 AltOp            */ __Matchers[689] = new Alt(this, 689, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 690 SeqOp            */ __Matchers[690] = new Seq(this, 690, "_690:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 691 SeqOp            */ __Matchers[691] = new Seq(this, 691, "_691:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 692 StringOp         */ __Matchers[692] = new String(this, 692, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 693 AltOp            */ __Matchers[693] = new Alt(this, 693, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 694 AltOp            */ __Matchers[694] = new Alt(this, 694, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 695 SeqOp            */ __Matchers[695] = new Seq(this, 695, "_695:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 696 StringOp         */ __Matchers[696] = new String(this, 696, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 697 StringOp         */ __Matchers[697] = new String(this, 697, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 698 AltOp            */ __Matchers[698] = new Alt(this, 698, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 699 AltOp            */ __Matchers[699] = new Alt(this, 699, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 700 SeqOp            */ __Matchers[700] = new Seq(this, 700, "_700:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 701 StringOp         */ __Matchers[701] = new String(this, 701, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 702 AltOp            */ __Matchers[702] = new Alt(this, 702, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 703 SeqOp            */ __Matchers[703] = new Seq(this, 703, "_703:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 704 StringOp         */ __Matchers[704] = new String(this, 704, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 705 StringOp         */ __Matchers[705] = new String(this, 705, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 706 AltOp            */ __Matchers[706] = new Alt(this, 706, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 707 AltOp            */ __Matchers[707] = new Alt(this, 707, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 708 SeqOp            */ __Matchers[708] = new Seq(this, 708, "_708:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 709 StringOp         */ __Matchers[709] = new String(this, 709, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 710 AltOp            */ __Matchers[710] = new Alt(this, 710, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 711 AltOp            */ __Matchers[711] = new Alt(this, 711, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 712 SeqOp            */ __Matchers[712] = new Seq(this, 712, "_712:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 713 StringOp         */ __Matchers[713] = new String(this, 713, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 714 AltOp            */ __Matchers[714] = new Alt(this, 714, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 715 SeqOp            */ __Matchers[715] = new Seq(this, 715, "_715:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 716 StringOp         */ __Matchers[716] = new String(this, 716, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 717 AltOp            */ __Matchers[717] = new Alt(this, 717, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 718 SeqOp            */ __Matchers[718] = new Seq(this, 718, "_718:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 719 AltOp            */ __Matchers[719] = new Alt(this, 719, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 720 NotOp            */ __Matchers[720] = new Not(this, 720, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_721:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 722 NotOp            */ __Matchers[722] = new Not(this, 722, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 723 SeqOp            */ __Matchers[723] = new Seq(this, 723, "_723:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 724 AltOp            */ __Matchers[724] = new Alt(this, 724, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 725 SeqOp            */ __Matchers[725] = new Seq(this, 725, "_725:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 726 AltOp            */ __Matchers[726] = new Alt(this, 726, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 727 SeqOp            */ __Matchers[727] = new Seq(this, 727, "_727:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 728 StringOp         */ __Matchers[728] = new String(this, 728, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 729 StringOp         */ __Matchers[729] = new String(this, 729, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 730 AltOp            */ __Matchers[730] = new Alt(this, 730, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 731 AltOp            */ __Matchers[731] = new Alt(this, 731, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 732 SeqOp            */ __Matchers[732] = new Seq(this, 732, "_732:(>primary,>qualified-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 733 SeqOp            */ __Matchers[733] = new Seq(this, 733, "_733:(>member-selection-operator,>base-reference)") { Builder = nodes => new CQualifiedReference(nodes) };
                /* 734 StringOp         */ __Matchers[734] = new String(this, 734, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 735 StringOp         */ __Matchers[735] = new String(this, 735, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 736 AltOp            */ __Matchers[736] = new Alt(this, 736, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_737:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 738 AltOp            */ __Matchers[738] = new Alt(this, 738, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_740:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_741:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 742 SeqOp            */ __Matchers[742] = new Seq(this, 742, "_742:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 743 SeqOp            */ __Matchers[743] = new Seq(this, 743, "_743:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 744 AltOp            */ __Matchers[744] = new Alt(this, 744, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 745 AltOp            */ __Matchers[745] = new Alt(this, 745, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 746 AltOp            */ __Matchers[746] = new Alt(this, 746, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 747 StarOp           */ __Matchers[747] = new Star(this, 747, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_748:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 749 SeqOp            */ __Matchers[749] = new Seq(this, 749, "_749:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 750 AltOp            */ __Matchers[750] = new Alt(this, 750, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 751 SeqOp            */ __Matchers[751] = new Seq(this, 751, "_751:('object',?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 752 SeqOp            */ __Matchers[752] = new Seq(this, 752, "_752:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 753 OptionalOp       */ __Matchers[753] = new Optional(this, 753, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_754:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_755:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 756 StarOp           */ __Matchers[756] = new Star(this, 756, "*(_755:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_757:(>varianced-type,*(_755:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 758 SeqOp            */ __Matchers[758] = new Seq(this, 758, "_758:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_759:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 760 StarOp           */ __Matchers[760] = new Star(this, 760, "*(_759:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 761 SeqOp            */ __Matchers[761] = new Seq(this, 761, "_761:(>defaulted-type,*(_759:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 762 AltOp            */ __Matchers[762] = new Alt(this, 762, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 763 SeqOp            */ __Matchers[763] = new Seq(this, 763, "_763:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 764 AltOp            */ __Matchers[764] = new Alt(this, 764, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_765:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 766 AltOp            */ __Matchers[766] = new Alt(this, 766, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_767:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 768 AltOp            */ __Matchers[768] = new Alt(this, 768, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_769:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 770 AltOp            */ __Matchers[770] = new Alt(this, 770, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 771 SeqOp            */ __Matchers[771] = new Seq(this, 771, "_771:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 772 AltOp            */ __Matchers[772] = new Alt(this, 772, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 773 SeqOp            */ __Matchers[773] = new Seq(this, 773, "_773:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 774 AltOp            */ __Matchers[774] = new Alt(this, 774, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>qualified-type)") { Builder = nodes => nodes[0] };
                /* 775 StringOp         */ __Matchers[775] = new String(this, 775, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 776 SeqOp            */ __Matchers[776] = new Seq(this, 776, "_776:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 777 OptionalOp       */ __Matchers[777] = new Optional(this, 777, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_778:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 779 OptionalOp       */ __Matchers[779] = new Optional(this, 779, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 780 SeqOp            */ __Matchers[780] = new Seq(this, 780, "_780:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 781 AltOp            */ __Matchers[781] = new Alt(this, 781, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_782:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 783 OptionalOp       */ __Matchers[783] = new Optional(this, 783, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 784 SeqOp            */ __Matchers[784] = new Seq(this, 784, "_784:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 785 SeqOp            */ __Matchers[785] = new Seq(this, 785, "_785:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 786 SeqOp            */ __Matchers[786] = new Seq(this, 786, "_786:(?(>package-qualifier),>type-path)") { Builder = nodes => new CQualifiedType(nodes) };
                /* 787 OptionalOp       */ __Matchers[787] = new Optional(this, 787, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 788 StarOp           */ __Matchers[788] = new Star(this, 788, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 789 SeqOp            */ __Matchers[789] = new Seq(this, 789, "_789:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_790:(>annotation-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 791 OptionalOp       */ __Matchers[791] = new Optional(this, 791, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 792 SeqOp            */ __Matchers[792] = new Seq(this, 792, "_792:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 793 SeqOp            */ __Matchers[793] = new Seq(this, 793, "_793:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 794 StarOp           */ __Matchers[794] = new Star(this, 794, "*(_793:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 795 SeqOp            */ __Matchers[795] = new Seq(this, 795, "_795:(>condition,*(_793:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 796 AltOp            */ __Matchers[796] = new Alt(this, 796, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 797 OptionalOp       */ __Matchers[797] = new Optional(this, 797, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 798 SeqOp            */ __Matchers[798] = new Seq(this, 798, "_798:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 800 AltOp            */ __Matchers[800] = new Alt(this, 800, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 801 SeqOp            */ __Matchers[801] = new Seq(this, 801, "_801:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 802 SeqOp            */ __Matchers[802] = new Seq(this, 802, "_802:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 803 SeqOp            */ __Matchers[803] = new Seq(this, 803, "_803:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 804 AltOp            */ __Matchers[804] = new Alt(this, 804, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 805 OptionalOp       */ __Matchers[805] = new Optional(this, 805, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 806 SeqOp            */ __Matchers[806] = new Seq(this, 806, "_806:(>if-block,?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 807 SeqOp            */ __Matchers[807] = new Seq(this, 807, "_807:('if',>conditions,>block)") { Builder = nodes => new CIfBlock(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_808:('else',>else-block-next)") { Builder = nodes => new CElseBlock(nodes) };
                /* 809 AltOp            */ __Matchers[809] = new Alt(this, 809, "alt(>if-else-statement|>block)") { Builder = nodes => nodes[0] };
                /* 810 PlusOp           */ __Matchers[810] = new Plus(this, 810, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 811 SeqOp            */ __Matchers[811] = new Seq(this, 811, "_811:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 812 StringOp         */ __Matchers[812] = new Keyword(this, 812, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 813 SeqOp            */ __Matchers[813] = new Seq(this, 813, "_813:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_814:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 815 AltOp            */ __Matchers[815] = new Alt(this, 815, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 816 OptionalOp       */ __Matchers[816] = new Optional(this, 816, "?('is')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 817 SeqOp            */ __Matchers[817] = new Seq(this, 817, "_817:(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 818 SeqOp            */ __Matchers[818] = new Seq(this, 818, "_818:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 819 SeqOp            */ __Matchers[819] = new Seq(this, 819, "_819:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 820 StarOp           */ __Matchers[820] = new Star(this, 820, "*(_819:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 821 SeqOp            */ __Matchers[821] = new Seq(this, 821, "_821:(>value-case,*(_819:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 822 AltOp            */ __Matchers[822] = new Alt(this, 822, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 823 AltOp            */ __Matchers[823] = new Alt(this, 823, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 824 OptionalOp       */ __Matchers[824] = new Optional(this, 824, "?(>fail-block)") { Builder = nodes => new ROptional<CFailBlock>(nodes) };
                /* 825 SeqOp            */ __Matchers[825] = new Seq(this, 825, "_825:(>for-block,?(>fail-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 826 SeqOp            */ __Matchers[826] = new Seq(this, 826, "_826:('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 827 SeqOp            */ __Matchers[827] = new Seq(this, 827, "_827:('else',>block)") { Builder = nodes => new CFailBlock(nodes) };
                /* 828 OptionalOp       */ __Matchers[828] = new Optional(this, 828, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 829 SeqOp            */ __Matchers[829] = new Seq(this, 829, "_829:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 830 AltOp            */ __Matchers[830] = new Alt(this, 830, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 831 SeqOp            */ __Matchers[831] = new Seq(this, 831, "_831:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 832 AltOp            */ __Matchers[832] = new Alt(this, 832, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 833 StringOp         */ __Matchers[833] = new Keyword(this, 833, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 834 SeqOp            */ __Matchers[834] = new Seq(this, 834, "_834:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 835 StarOp           */ __Matchers[835] = new Star(this, 835, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 836 OptionalOp       */ __Matchers[836] = new Optional(this, 836, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 837 SeqOp            */ __Matchers[837] = new Seq(this, 837, "_837:(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 838 StringOp         */ __Matchers[838] = new Keyword(this, 838, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 839 OptionalOp       */ __Matchers[839] = new Optional(this, 839, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 840 SeqOp            */ __Matchers[840] = new Seq(this, 840, "_840:('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 841 StringOp         */ __Matchers[841] = new Keyword(this, 841, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 842 SeqOp            */ __Matchers[842] = new Seq(this, 842, "_842:('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 843 OptionalOp       */ __Matchers[843] = new Optional(this, 843, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_844:('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 845 StringOp         */ __Matchers[845] = new Keyword(this, 845, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_846:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 847 OptionalOp       */ __Matchers[847] = new Optional(this, 847, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 848 SeqOp            */ __Matchers[848] = new Seq(this, 848, "_848:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 849 SeqOp            */ __Matchers[849] = new Seq(this, 849, "_849:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 850 StarOp           */ __Matchers[850] = new Star(this, 850, "*(_849:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 851 SeqOp            */ __Matchers[851] = new Seq(this, 851, "_851:(>resource,*(_849:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 852 AltOp            */ __Matchers[852] = new Alt(this, 852, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 853 SeqOp            */ __Matchers[853] = new Seq(this, 853, "_853:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 854 OptionalOp       */ __Matchers[854] = new Optional(this, 854, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 855 StarOp           */ __Matchers[855] = new Star(this, 855, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 856 SeqOp            */ __Matchers[856] = new Seq(this, 856, "_856:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 857 AltOp            */ __Matchers[857] = new Alt(this, 857, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 858 SeqOp            */ __Matchers[858] = new Seq(this, 858, "_858:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 859 StringOp         */ __Matchers[859] = new String(this, 859, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 860 SeqOp            */ __Matchers[860] = new Seq(this, 860, "_860:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 861 AltOp            */ __Matchers[861] = new Alt(this, 861, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 862 AltOp            */ __Matchers[862] = new Alt(this, 862, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 863 AltOp            */ __Matchers[863] = new Alt(this, 863, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 864 SeqOp            */ __Matchers[864] = new Seq(this, 864, "_864:(>package-qualifier,>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_865:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 866 AltOp            */ __Matchers[866] = new Alt(this, 866, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 867 OptionalOp       */ __Matchers[867] = new Optional(this, 867, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_868:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 871 SeqOp            */ __Matchers[871] = new Seq(this, 871, "_871:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_872:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 873 SeqOp            */ __Matchers[873] = new Seq(this, 873, "_873:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 874 SeqOp            */ __Matchers[874] = new Seq(this, 874, "_874:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_875:(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 876 AltOp            */ __Matchers[876] = new Alt(this, 876, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 877 SeqOp            */ __Matchers[877] = new Seq(this, 877, "_877:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 878 SeqOp            */ __Matchers[878] = new Seq(this, 878, "_878:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 879 SeqOp            */ __Matchers[879] = new Seq(this, 879, "_879:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 880 StarOp           */ __Matchers[880] = new Star(this, 880, "*(_879:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 881 SeqOp            */ __Matchers[881] = new Seq(this, 881, "_881:(>reference-path-element,*(_879:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[371]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[372]);
                /*   4 PlainRuleOp      */ _unitElements.Set(__Matchers[374]);
                /*   5 PlainRuleOp      */ _importDeclarations.Set(__Matchers[375]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[379]);
                /*   7 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[382]);
                /*   8 PlainRuleOp      */ _repository.Set(_identifier);
                /*   9 PlainRuleOp      */ _module.Set(__Matchers[383]);
                /*  10 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[385]);
                /*  11 PlainRuleOp      */ _artifact.Set(__Matchers[386]);
                /*  12 PlainRuleOp      */ _classifier.Set(__Matchers[387]);
                /*  13 PlainRuleOp      */ _version.Set(_literalString);
                /*  14 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  15 PlainRuleOp      */ _moduleBody.Set(__Matchers[391]);
                /*  16 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[392]);
                /*  17 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[395]);
                /*  18 PlainRuleOp      */ _importModule.Set(__Matchers[397]);
                /*  19 PlainRuleOp      */ _importDeclaration.Set(__Matchers[398]);
                /*  20 PlainRuleOp      */ _importElements.Set(__Matchers[400]);
                /*  21 PlainRuleOp      */ _importElementList.Set(__Matchers[404]);
                /*  22 PlainRuleOp      */ _importElement.Set(__Matchers[405]);
                /*  23 PlainRuleOp      */ _importNamed.Set(__Matchers[408]);
                /*  24 PlainRuleOp      */ _importName.Set(_identifier);
                /*  25 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[410]);
                /*  26 PlainRuleOp      */ _importWildcard.Set(__Matchers[411]);
                /*  27 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  28 PlainRuleOp      */ _packagePath.Set(__Matchers[415]);
                /*  29 PlainRuleOp      */ _annotationName.Set(_lowerIdentifier);
                /*  30 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  31 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  32 PlainRuleOp      */ _pattern.Set(__Matchers[416]);
                /*  33 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[417]);
                /*  34 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[418]);
                /*  35 PlainRuleOp      */ _entryPattern.Set(__Matchers[420]);
                /*  36 PlainRuleOp      */ _tuplePattern.Set(__Matchers[424]);
                /*  37 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[427]);
                /*  38 PlainRuleOp      */ _variadicPattern.Set(__Matchers[428]);
                /*  39 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  40 PlainRuleOp      */ _variadicVariable.Set(__Matchers[431]);
                /*  41 PlainRuleOp      */ _letStatement.Set(__Matchers[435]);
                /*  42 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[437]);
                /*  43 PlainRuleOp      */ _assertionStatement.Set(__Matchers[440]);
                /*  44 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  45 PlainRuleOp      */ _block.Set(_blockElements);
                /*  46 PlainRuleOp      */ _interfaceBlock.Set(_blockElements);
                /*  47 PlainRuleOp      */ _classBlock.Set(_blockElements);
                /*  48 PlainRuleOp      */ _blockElements.Set(__Matchers[442]);
                /*  49 PlainRuleOp      */ _extendedType.Set(__Matchers[443]);
                /*  50 PlainRuleOp      */ _classSpecifier.Set(__Matchers[445]);
                /*  51 PlainRuleOp      */ _classInstatiation.Set(__Matchers[447]);
                /*  52 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[448]);
                /*  53 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[449]);
                /*  54 PlainRuleOp      */ _superQualifier.Set(__Matchers[451]);
                /*  55 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[452]);
                /*  56 PlainRuleOp      */ _packageQualifier.Set(__Matchers[453]);
                /*  57 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[454]);
                /*  58 PlainRuleOp      */ _memberPath.Set(__Matchers[455]);
                /*  59 PlainRuleOp      */ _typePath.Set(__Matchers[458]);
                /*  60 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[460]);
                /*  61 PlainRuleOp      */ _unionTypeList.Set(__Matchers[463]);
                /*  62 PlainRuleOp      */ _caseTypes.Set(__Matchers[465]);
                /*  63 PlainRuleOp      */ _caseTypeList.Set(__Matchers[469]);
                /*  64 PlainRuleOp      */ _caseType.Set(__Matchers[470]);
                /*  65 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[472]);
                /*  66 PlainRuleOp      */ _parameters.Set(__Matchers[474]);
                /*  67 PlainRuleOp      */ _parameterList.Set(__Matchers[477]);
                /*  68 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[478]);
                /*  69 PlainRuleOp      */ _parameter.Set(__Matchers[479]);
                /*  70 PlainRuleOp      */ _parameterReference.Set(__Matchers[481]);
                /*  71 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[482]);
                /*  72 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[486]);
                /*  73 PlainRuleOp      */ _functionParameterType.Set(__Matchers[487]);
                /*  74 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[488]);
                /*  75 PlainRuleOp      */ _valueParameterType.Set(__Matchers[489]);
                /*  76 PlainRuleOp      */ _typeParameters.Set(__Matchers[492]);
                /*  77 PlainRuleOp      */ _typeParameterList.Set(__Matchers[495]);
                /*  78 PlainRuleOp      */ _typeParameter.Set(__Matchers[498]);
                /*  79 PlainRuleOp      */ _variance.Set(__Matchers[501]);
                /*  80 PlainRuleOp      */ _typeDefault.Set(__Matchers[502]);
                /*  81 PlainRuleOp      */ _typeConstraint.Set(__Matchers[507]);
                /*  82 PlainRuleOp      */ _typeConstraints.Set(__Matchers[508]);
                /*  83 PlainRuleOp      */ _declarationOrStatement.Set(__Matchers[509]);
                /*  84 PlainRuleOp      */ _declaration.Set(__Matchers[510]);
                /*  85 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[513]);
                /*  86 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[516]);
                /*  87 PlainRuleOp      */ _enumeratedObject.Set(__Matchers[517]);
                /*  88 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[520]);
                /*  89 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[522]);
                /*  90 PlainRuleOp      */ _setterDefinition.Set(__Matchers[523]);
                /*  91 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[524]);
                /*  92 PlainRuleOp      */ _methodType.Set(__Matchers[525]);
                /*  93 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[527]);
                /*  94 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[528]);
                /*  95 PlainRuleOp      */ _attributeType.Set(_variadicType);
                /*  96 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[530]);
                /*  97 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[531]);
                /*  98 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[533]);
                /*  99 PlainRuleOp      */ _classDeclaration.Set(__Matchers[536]);
                /* 100 PlainRuleOp      */ _classDefinition.Set(__Matchers[537]);
                /* 101 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[539]);
                /* 102 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[541]);
                /* 103 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[542]);
                /* 104 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[544]);
                /* 105 PlainRuleOp      */ _statement.Set(__Matchers[545]);
                /* 106 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[546]);
                /* 107 PlainRuleOp      */ _openStatement.Set(__Matchers[547]);
                /* 108 PlainRuleOp      */ _specificationStatement.Set(__Matchers[548]);
                /* 109 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 110 PlainRuleOp      */ _directiveStatement.Set(__Matchers[549]);
                /* 111 PlainRuleOp      */ _returnStatement.Set(__Matchers[552]);
                /* 112 PlainRuleOp      */ _throwStatement.Set(__Matchers[554]);
                /* 113 PlainRuleOp      */ _breakStatement.Set(__Matchers[555]);
                /* 114 PlainRuleOp      */ _continueStatement.Set(__Matchers[556]);
                /* 115 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[557]);
                /* 116 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[558]);
                /* 117 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[559]);
                /* 118 PlainRuleOp      */ _anySpecifier.Set(__Matchers[560]);
                /* 119 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[561]);
                /* 120 PlainRuleOp      */ _baseReference.Set(__Matchers[562]);
                /* 121 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[563]);
                /* 122 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[564]);
                /* 123 PlainRuleOp      */ _memberReference.Set(__Matchers[566]);
                /* 124 PlainRuleOp      */ _typeReference.Set(__Matchers[567]);
                /* 125 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[568]);
                /* 126 PlainRuleOp      */ _selfReference.Set(__Matchers[571]);
                /* 127 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[573]);
                /* 128 PlainRuleOp      */ _tupleExpr.Set(__Matchers[574]);
                /* 129 PlainRuleOp      */ _arguments.Set(__Matchers[575]);
                /* 130 PlainRuleOp      */ _structuralArguments.Set(__Matchers[577]);
                /* 131 PlainRuleOp      */ _namedOrAnonymous.Set(__Matchers[578]);
                /* 132 PlainRuleOp      */ _namedArgument.Set(__Matchers[579]);
                /* 133 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[580]);
                /* 134 PlainRuleOp      */ _sequencedArguments.Set(__Matchers[583]);
                /* 135 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[584]);
                /* 136 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[585]);
                /* 137 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[586]);
                /* 138 PlainRuleOp      */ _objectArgument.Set(__Matchers[587]);
                /* 139 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[588]);
                /* 140 PlainRuleOp      */ _methodDefinition.Set(__Matchers[589]);
                /* 141 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[590]);
                /* 142 PlainRuleOp      */ _neededFunctionSpecifier.Set(__Matchers[591]);
                /* 143 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[592]);
                /* 144 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[593]);
                /* 145 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 146 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[594]);
                /* 147 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[595]);
                /* 148 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[596]);
                /* 149 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[597]);
                /* 150 PlainRuleOp      */ _positionalArguments.Set(__Matchers[598]);
                /* 151 PlainRuleOp      */ _positionalArgument.Set(__Matchers[599]);
                /* 152 PlainRuleOp      */ _spreadArgument.Set(__Matchers[601]);
                /* 153 PlainRuleOp      */ _letExpr.Set(__Matchers[603]);
                /* 154 PlainRuleOp      */ _letVariableList.Set(__Matchers[606]);
                /* 155 PlainRuleOp      */ _letVariable.Set(__Matchers[607]);
                /* 156 PlainRuleOp      */ _switchExpr.Set(__Matchers[608]);
                /* 157 PlainRuleOp      */ _caseExpressions.Set(__Matchers[611]);
                /* 158 PlainRuleOp      */ _caseExpression.Set(__Matchers[615]);
                /* 159 PlainRuleOp      */ _ifExpr.Set(__Matchers[617]);
                /* 160 PlainRuleOp      */ _elseExpression.Set(__Matchers[618]);
                /* 161 PlainRuleOp      */ _thenExpression.Set(__Matchers[620]);
                /* 162 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[621]);
                /* 163 PlainRuleOp      */ _functionExpr.Set(__Matchers[624]);
                /* 164 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[626]);
                /* 165 PlainRuleOp      */ _functionParameters.Set(__Matchers[627]);
                /* 166 PlainRuleOp      */ _functionDefinition.Set(__Matchers[628]);
                /* 167 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[629]);
                /* 168 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[630]);
                /* 169 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 170 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[633]);
                /* 171 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[634]);
                /* 172 PlainRuleOp      */ _expression.Set(__Matchers[635]);
                /* 173 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 174 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[636]);
                /* 175 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[637]);
                /* 176 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[649]);
                /* 177 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[650]);
                /* 178 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[651]);
                /* 179 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[652]);
                /* 180 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[653]);
                /* 181 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[654]);
                /* 182 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[655]);
                /* 183 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[656]);
                /* 184 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[657]);
                /* 185 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[658]);
                /* 186 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[659]);
                /* 187 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[660]);
                /* 188 PlainRuleOp      */ _notOperator.Set(__Matchers[661]);
                /* 189 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[662]);
                /* 190 PlainRuleOp      */ _equalityExpression.Set(__Matchers[663]);
                /* 191 PlainRuleOp      */ _equalityExpr.Set(__Matchers[664]);
                /* 192 PlainRuleOp      */ _equalityOperator.Set(__Matchers[668]);
                /* 193 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[669]);
                /* 194 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[670]);
                /* 195 PlainRuleOp      */ _largerExpr.Set(__Matchers[671]);
                /* 196 PlainRuleOp      */ _smallerExpr.Set(__Matchers[672]);
                /* 197 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[673]);
                /* 198 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[674]);
                /* 199 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[675]);
                /* 200 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[677]);
                /* 201 PlainRuleOp      */ _smallerOperator.Set(__Matchers[679]);
                /* 202 PlainRuleOp      */ _largerOperator.Set(__Matchers[681]);
                /* 203 PlainRuleOp      */ _typeOperator.Set(__Matchers[683]);
                /* 204 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[684]);
                /* 205 PlainRuleOp      */ _existsExpr.Set(__Matchers[686]);
                /* 206 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[688]);
                /* 207 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[689]);
                /* 208 PlainRuleOp      */ _rangeExpr.Set(__Matchers[690]);
                /* 209 PlainRuleOp      */ _entryExpr.Set(__Matchers[691]);
                /* 210 PlainRuleOp      */ _rangeOperator.Set(__Matchers[693]);
                /* 211 PlainRuleOp      */ _entryOperator.Set(__Matchers[419]);
                /* 212 PlainRuleOp      */ _additiveExpression.Set(__Matchers[694]);
                /* 213 PlainRuleOp      */ _additiveExpr.Set(__Matchers[695]);
                /* 214 PlainRuleOp      */ _additiveOperator.Set(__Matchers[698]);
                /* 215 PlainRuleOp      */ _scaleExpression.Set(__Matchers[699]);
                /* 216 PlainRuleOp      */ _scaleExpr.Set(__Matchers[700]);
                /* 217 PlainRuleOp      */ _scaleOperator.Set(__Matchers[701]);
                /* 218 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[702]);
                /* 219 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[703]);
                /* 220 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[706]);
                /* 221 PlainRuleOp      */ _unionExpression.Set(__Matchers[707]);
                /* 222 PlainRuleOp      */ _unionExpr.Set(__Matchers[708]);
                /* 223 PlainRuleOp      */ _unionOperator.Set(__Matchers[710]);
                /* 224 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[711]);
                /* 225 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[712]);
                /* 226 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[713]);
                /* 227 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[714]);
                /* 228 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[715]);
                /* 229 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[716]);
                /* 230 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[717]);
                /* 231 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[718]);
                /* 232 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[719]);
                /* 233 PlainRuleOp      */ _negateOperator.Set(__Matchers[721]);
                /* 234 PlainRuleOp      */ _neutralOperator.Set(__Matchers[723]);
                /* 235 PlainRuleOp      */ _complementOperator.Set(__Matchers[709]);
                /* 236 PlainRuleOp      */ _prefixExpression.Set(__Matchers[724]);
                /* 237 PlainRuleOp      */ _prefixExpr.Set(__Matchers[725]);
                /* 238 PlainRuleOp      */ _postfixExpression.Set(__Matchers[726]);
                /* 239 PlainRuleOp      */ _postfixExpr.Set(__Matchers[727]);
                /* 240 PlainRuleOp      */ _incrementOperator.Set(__Matchers[730]);
                /* 241 PlainRuleOp      */ _primary.Set(__Matchers[731]);
                /* 242 PlainRuleOp      */ _selectionExpr.Set(__Matchers[732]);
                /* 243 PlainRuleOp      */ _qualifiedReference.Set(__Matchers[733]);
                /* 244 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[736]);
                /* 245 PlainRuleOp      */ _indexedExpr.Set(__Matchers[737]);
                /* 246 PlainRuleOp      */ _index.Set(__Matchers[738]);
                /* 247 PlainRuleOp      */ _upperSpanned.Set(__Matchers[739]);
                /* 248 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[740]);
                /* 249 PlainRuleOp      */ _spanned.Set(__Matchers[741]);
                /* 250 PlainRuleOp      */ _measured.Set(__Matchers[742]);
                /* 251 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 252 PlainRuleOp      */ _callExpr.Set(__Matchers[743]);
                /* 253 PlainRuleOp      */ _baseExpression.Set(__Matchers[744]);
                /* 254 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[745]);
                /* 255 PlainRuleOp      */ _stringExpression.Set(__Matchers[746]);
                /* 256 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[748]);
                /* 257 PlainRuleOp      */ _interpolationPart.Set(__Matchers[749]);
                /* 258 PlainRuleOp      */ _stringLiteral.Set(__Matchers[750]);
                /* 259 PlainRuleOp      */ _objectExpr.Set(__Matchers[751]);
                /* 260 PlainRuleOp      */ _groupedExpr.Set(__Matchers[752]);
                /* 261 PlainRuleOp      */ _typeArguments.Set(__Matchers[754]);
                /* 262 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[757]);
                /* 263 PlainRuleOp      */ _variancedType.Set(__Matchers[758]);
                /* 264 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[761]);
                /* 265 PlainRuleOp      */ _defaultedType.Set(__Matchers[762]);
                /* 266 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[763]);
                /* 267 PlainRuleOp      */ _variadicType.Set(__Matchers[764]);
                /* 268 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[765]);
                /* 269 PlainRuleOp      */ _variadicOperator.Set(__Matchers[766]);
                /* 270 PlainRuleOp      */ _spreadType.Set(__Matchers[767]);
                /* 271 PlainRuleOp      */ _type.Set(__Matchers[768]);
                /* 272 PlainRuleOp      */ _entryType.Set(__Matchers[769]);
                /* 273 PlainRuleOp      */ _unionType.Set(__Matchers[770]);
                /* 274 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[771]);
                /* 275 PlainRuleOp      */ _intersectionType.Set(__Matchers[772]);
                /* 276 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[773]);
                /* 277 PlainRuleOp      */ _primaryType.Set(__Matchers[774]);
                /* 278 PlainRuleOp      */ _nullableType.Set(__Matchers[776]);
                /* 279 PlainRuleOp      */ _arrayType.Set(__Matchers[778]);
                /* 280 PlainRuleOp      */ _functionType.Set(__Matchers[780]);
                /* 281 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[781]);
                /* 282 PlainRuleOp      */ _tupleType.Set(__Matchers[782]);
                /* 283 PlainRuleOp      */ _iterableType.Set(__Matchers[784]);
                /* 284 PlainRuleOp      */ _groupedType.Set(__Matchers[785]);
                /* 285 PlainRuleOp      */ _qualifiedType.Set(__Matchers[786]);
                /* 286 PlainRuleOp      */ _annotations.Set(__Matchers[789]);
                /* 287 PlainRuleOp      */ _annotation.Set(__Matchers[790]);
                /* 288 PlainRuleOp      */ _conditions.Set(__Matchers[792]);
                /* 289 PlainRuleOp      */ _conditionList.Set(__Matchers[795]);
                /* 290 PlainRuleOp      */ _condition.Set(__Matchers[796]);
                /* 291 PlainRuleOp      */ _existsCondition.Set(__Matchers[798]);
                /* 292 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[799]);
                /* 293 PlainRuleOp      */ _letOrExpression.Set(__Matchers[800]);
                /* 294 PlainRuleOp      */ _isCondition.Set(__Matchers[801]);
                /* 295 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[802]);
                /* 296 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[803]);
                /* 297 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 298 PlainRuleOp      */ _controlStatement.Set(__Matchers[804]);
                /* 299 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[806]);
                /* 300 PlainRuleOp      */ _ifBlock.Set(__Matchers[807]);
                /* 301 PlainRuleOp      */ _elseBlock.Set(__Matchers[808]);
                /* 302 PlainRuleOp      */ _elseBlockNext.Set(__Matchers[809]);
                /* 303 PlainRuleOp      */ _switchStatement.Set(__Matchers[811]);
                /* 304 PlainRuleOp      */ _switchHeader.Set(__Matchers[813]);
                /* 305 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 306 PlainRuleOp      */ _caseBlock.Set(__Matchers[814]);
                /* 307 PlainRuleOp      */ _caseItem.Set(__Matchers[815]);
                /* 308 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[817]);
                /* 309 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[818]);
                /* 310 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 311 PlainRuleOp      */ _valueCaseList.Set(__Matchers[821]);
                /* 312 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[822]);
                /* 313 PlainRuleOp      */ _valueCase.Set(__Matchers[823]);
                /* 314 PlainRuleOp      */ _forElseStatement.Set(__Matchers[825]);
                /* 315 PlainRuleOp      */ _forBlock.Set(__Matchers[826]);
                /* 316 PlainRuleOp      */ _failBlock.Set(__Matchers[827]);
                /* 317 PlainRuleOp      */ _forIterator.Set(__Matchers[829]);
                /* 318 PlainRuleOp      */ _forVariable.Set(__Matchers[830]);
                /* 319 PlainRuleOp      */ _containment.Set(__Matchers[831]);
                /* 320 PlainRuleOp      */ _containmentOperator.Set(__Matchers[832]);
                /* 321 PlainRuleOp      */ _whileStatement.Set(__Matchers[834]);
                /* 322 PlainRuleOp      */ _tryStatement.Set(__Matchers[837]);
                /* 323 PlainRuleOp      */ _tryBlock.Set(__Matchers[840]);
                /* 324 PlainRuleOp      */ _catchBlock.Set(__Matchers[842]);
                /* 325 PlainRuleOp      */ _catchVariable.Set(__Matchers[844]);
                /* 326 PlainRuleOp      */ _finallyBlock.Set(__Matchers[846]);
                /* 327 PlainRuleOp      */ _resources.Set(__Matchers[848]);
                /* 328 PlainRuleOp      */ _resourceList.Set(__Matchers[851]);
                /* 329 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 330 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[852]);
                /* 331 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[853]);
                /* 332 PlainRuleOp      */ _variable.Set(__Matchers[856]);
                /* 333 PlainRuleOp      */ _variableType.Set(__Matchers[857]);
                /* 334 PlainRuleOp      */ _modelReference.Set(__Matchers[858]);
                /* 335 PlainRuleOp      */ _metaLiteral.Set(__Matchers[860]);
                /* 336 PlainRuleOp      */ _metaExpression.Set(__Matchers[861]);
                /* 337 PlainRuleOp      */ _modelExpression.Set(__Matchers[862]);
                /* 338 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[863]);
                /* 339 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[864]);
                /* 340 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[865]);
                /* 341 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 342 PlainRuleOp      */ _declarationReference.Set(__Matchers[866]);
                /* 343 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[868]);
                /* 344 PlainRuleOp      */ _packageLiteral.Set(__Matchers[869]);
                /* 345 PlainRuleOp      */ _classLiteral.Set(__Matchers[870]);
                /* 346 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[871]);
                /* 347 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[872]);
                /* 348 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[873]);
                /* 349 PlainRuleOp      */ _newLiteral.Set(__Matchers[874]);
                /* 350 PlainRuleOp      */ _valueLiteral.Set(__Matchers[875]);
                /* 351 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[876]);
                /* 352 PlainRuleOp      */ _functionLiteral.Set(__Matchers[877]);
                /* 353 PlainRuleOp      */ _referencePath.Set(__Matchers[878]);
                /* 354 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[881]);
                /* 355 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 356 PlainRuleOp      */ _kwVoid.Set(__Matchers[625]);
                /* 357 PlainRuleOp      */ _kwFunction.Set(__Matchers[526]);
                /* 358 PlainRuleOp      */ _kwValue.Set(__Matchers[529]);
                /* 359 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 360 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 361 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 362 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 363 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 364 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 365 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 366 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 367 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 368 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 369 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 371 SeqOp            */ __Matchers[371].Set(_compilationUnit, __Matchers[370]);
                /* 372 AltOp            */ __Matchers[372].Set(_moduleDescriptor, _packageDescriptor, _unitElements);
                /* 373 StarOp           */ __Matchers[373].Set(_declaration);
                /* 374 SeqOp            */ __Matchers[374].Set(_importDeclarations, __Matchers[373]);
                /* 375 StarOp           */ __Matchers[375].Set(_importDeclaration);
                /* 377 OptionalOp       */ __Matchers[377].Set(_moduleSpecifier);
                /* 378 OptionalOp       */ __Matchers[378].Set(_version);
                /* 379 SeqOp            */ __Matchers[379].Set(_annotations, __Matchers[376], _moduleName, __Matchers[377], __Matchers[378], _moduleBody);
                /* 381 OptionalOp       */ __Matchers[381].Set(_artifactAndClassifier);
                /* 382 SeqOp            */ __Matchers[382].Set(_repository, __Matchers[380], _module, __Matchers[381]);
                /* 383 AltOp            */ __Matchers[383].Set(_literalString, _moduleName);
                /* 384 OptionalOp       */ __Matchers[384].Set(_classifier);
                /* 385 SeqOp            */ __Matchers[385].Set(_artifact, __Matchers[384]);
                /* 386 SeqOp            */ __Matchers[386].Set(__Matchers[380], _literalString);
                /* 387 SeqOp            */ __Matchers[387].Set(__Matchers[380], _literalString);
                /* 389 StarOp           */ __Matchers[389].Set(_moduleBodyElement);
                /* 391 SeqOp            */ __Matchers[391].Set(__Matchers[388], __Matchers[389], __Matchers[390]);
                /* 392 AltOp            */ __Matchers[392].Set(_inferredAttributeDeclaration, _importModule);
                /* 395 SeqOp            */ __Matchers[395].Set(_annotations, __Matchers[393], _packagePath, __Matchers[394]);
                /* 397 SeqOp            */ __Matchers[397].Set(_annotations, __Matchers[396], _module, __Matchers[378], __Matchers[394]);
                /* 398 SeqOp            */ __Matchers[398].Set(__Matchers[396], _packagePath, _importElements);
                /* 399 OptionalOp       */ __Matchers[399].Set(_importElementList);
                /* 400 SeqOp            */ __Matchers[400].Set(__Matchers[388], __Matchers[399], __Matchers[390]);
                /* 402 SeqOp            */ __Matchers[402].Set(__Matchers[401], _importElement);
                /* 403 StarOp           */ __Matchers[403].Set(__Matchers[402]);
                /* 404 SeqOp            */ __Matchers[404].Set(_importElement, __Matchers[403]);
                /* 405 AltOp            */ __Matchers[405].Set(_importNamed, _importWildcard);
                /* 406 OptionalOp       */ __Matchers[406].Set(_importNameSpecifier);
                /* 407 OptionalOp       */ __Matchers[407].Set(_importElements);
                /* 408 SeqOp            */ __Matchers[408].Set(_importName, __Matchers[406], __Matchers[407]);
                /* 410 SeqOp            */ __Matchers[410].Set(__Matchers[409], _identifier);
                /* 413 SeqOp            */ __Matchers[413].Set(__Matchers[412], _packageName);
                /* 414 StarOp           */ __Matchers[414].Set(__Matchers[413]);
                /* 415 SeqOp            */ __Matchers[415].Set(_packageName, __Matchers[414]);
                /* 416 AltOp            */ __Matchers[416].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 417 AltOp            */ __Matchers[417].Set(_tuplePattern, _variablePattern);
                /* 418 AltOp            */ __Matchers[418].Set(_entryPattern, _tuplePattern);
                /* 420 SeqOp            */ __Matchers[420].Set(_variableOrTuplePattern, __Matchers[419], _variableOrTuplePattern);
                /* 422 OptionalOp       */ __Matchers[422].Set(_variadicPatternList);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[421], __Matchers[422], __Matchers[423]);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[401], _variadicPattern);
                /* 426 StarOp           */ __Matchers[426].Set(__Matchers[425]);
                /* 427 SeqOp            */ __Matchers[427].Set(_variadicPattern, __Matchers[426]);
                /* 428 AltOp            */ __Matchers[428].Set(_variadicVariable, _pattern);
                /* 429 OptionalOp       */ __Matchers[429].Set(_unionType);
                /* 430 OptionalOp       */ __Matchers[430].Set(_memberName);
                /* 431 SeqOp            */ __Matchers[431].Set(__Matchers[429], _variadicOperator, __Matchers[430]);
                /* 435 SeqOp            */ __Matchers[435].Set(__Matchers[432], __Matchers[433], _letVariableList, __Matchers[434]);
                /* 437 SeqOp            */ __Matchers[437].Set(__Matchers[436], _classInstatiation);
                /* 438 OptionalOp       */ __Matchers[438].Set(_assertionMessage);
                /* 440 SeqOp            */ __Matchers[440].Set(__Matchers[438], __Matchers[439], _conditions);
                /* 441 StarOp           */ __Matchers[441].Set(_declarationOrStatement);
                /* 442 SeqOp            */ __Matchers[442].Set(__Matchers[388], _importDeclarations, __Matchers[441], __Matchers[390]);
                /* 443 SeqOp            */ __Matchers[443].Set(__Matchers[436], _classInstatiation);
                /* 445 SeqOp            */ __Matchers[445].Set(__Matchers[444], _classInstatiation);
                /* 446 OptionalOp       */ __Matchers[446].Set(_arguments);
                /* 447 SeqOp            */ __Matchers[447].Set(_qualifiedClass, __Matchers[446]);
                /* 448 AltOp            */ __Matchers[448].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 449 SeqOp            */ __Matchers[449].Set(_superQualifier, _baseReference);
                /* 451 SeqOp            */ __Matchers[451].Set(__Matchers[450], __Matchers[412]);
                /* 452 SeqOp            */ __Matchers[452].Set(_packageQualifier, _unQualifiedClass);
                /* 453 SeqOp            */ __Matchers[453].Set(__Matchers[393], __Matchers[412]);
                /* 454 AltOp            */ __Matchers[454].Set(_memberPath, _typePath, _memberReference);
                /* 455 SeqOp            */ __Matchers[455].Set(_typePath, __Matchers[412], _memberReference);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[412], _typeReference);
                /* 457 StarOp           */ __Matchers[457].Set(__Matchers[456]);
                /* 458 SeqOp            */ __Matchers[458].Set(_typeReference, __Matchers[457]);
                /* 460 SeqOp            */ __Matchers[460].Set(__Matchers[459], _unionTypeList);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[401], _unionType);
                /* 462 StarOp           */ __Matchers[462].Set(__Matchers[461]);
                /* 463 SeqOp            */ __Matchers[463].Set(_unionType, __Matchers[462]);
                /* 465 SeqOp            */ __Matchers[465].Set(__Matchers[464], _caseTypeList);
                /* 467 SeqOp            */ __Matchers[467].Set(__Matchers[466], _caseType);
                /* 468 StarOp           */ __Matchers[468].Set(__Matchers[467]);
                /* 469 SeqOp            */ __Matchers[469].Set(_caseType, __Matchers[468]);
                /* 470 AltOp            */ __Matchers[470].Set(_primaryType, _qualifiedCaseType);
                /* 471 OptionalOp       */ __Matchers[471].Set(_packageQualifier);
                /* 472 SeqOp            */ __Matchers[472].Set(__Matchers[471], _memberName);
                /* 473 OptionalOp       */ __Matchers[473].Set(_parameterList);
                /* 474 SeqOp            */ __Matchers[474].Set(__Matchers[433], __Matchers[473], __Matchers[434]);
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[401], _parameterDeclarationOrRefPattern);
                /* 476 StarOp           */ __Matchers[476].Set(__Matchers[475]);
                /* 477 SeqOp            */ __Matchers[477].Set(_parameterDeclarationOrRefPattern, __Matchers[476]);
                /* 478 AltOp            */ __Matchers[478].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 479 SeqOp            */ __Matchers[479].Set(_annotations, _parameterDeclaration);
                /* 480 OptionalOp       */ __Matchers[480].Set(_valueSpecifier);
                /* 481 SeqOp            */ __Matchers[481].Set(_memberName, __Matchers[480]);
                /* 482 AltOp            */ __Matchers[482].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 483 OptionalOp       */ __Matchers[483].Set(_typeParameters);
                /* 484 PlusOp           */ __Matchers[484].Set(_parameters);
                /* 485 OptionalOp       */ __Matchers[485].Set(_functionSpecifier);
                /* 486 SeqOp            */ __Matchers[486].Set(_functionParameterType, _memberName, __Matchers[483], __Matchers[484], __Matchers[485]);
                /* 487 AltOp            */ __Matchers[487].Set(_variadicType, _kwVoid, _kwFunction);
                /* 488 SeqOp            */ __Matchers[488].Set(_valueParameterType, _memberName, __Matchers[480]);
                /* 489 AltOp            */ __Matchers[489].Set(_variadicType, _kwValue);
                /* 492 SeqOp            */ __Matchers[492].Set(__Matchers[490], _typeParameterList, __Matchers[491]);
                /* 493 SeqOp            */ __Matchers[493].Set(__Matchers[401], _typeParameter);
                /* 494 StarOp           */ __Matchers[494].Set(__Matchers[493]);
                /* 495 SeqOp            */ __Matchers[495].Set(_typeParameter, __Matchers[494]);
                /* 496 OptionalOp       */ __Matchers[496].Set(_variance);
                /* 497 OptionalOp       */ __Matchers[497].Set(_typeDefault);
                /* 498 SeqOp            */ __Matchers[498].Set(__Matchers[496], _typeName, __Matchers[497]);
                /* 501 AltOp            */ __Matchers[501].Set(__Matchers[499], __Matchers[500]);
                /* 502 SeqOp            */ __Matchers[502].Set(__Matchers[409], _type);
                /* 504 OptionalOp       */ __Matchers[504].Set(_typeName);
                /* 505 OptionalOp       */ __Matchers[505].Set(_caseTypes);
                /* 506 OptionalOp       */ __Matchers[506].Set(_satisfiedTypes);
                /* 507 SeqOp            */ __Matchers[507].Set(__Matchers[503], __Matchers[504], __Matchers[483], __Matchers[505], __Matchers[506]);
                /* 508 PlusOp           */ __Matchers[508].Set(_typeConstraint);
                /* 509 AltOp            */ __Matchers[509].Set(_declaration, _statement);
                /* 510 AltOp            */ __Matchers[510].Set(_constructorDeclaration, _aliasDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _enumeratedObject, _setterDeclaration, _typedMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 512 OptionalOp       */ __Matchers[512].Set(_delegatedConstructor);
                /* 513 SeqOp            */ __Matchers[513].Set(_annotations, __Matchers[511], __Matchers[430], _parameters, __Matchers[512], _block);
                /* 515 OptionalOp       */ __Matchers[515].Set(_typeConstraints);
                /* 516 SeqOp            */ __Matchers[516].Set(_annotations, __Matchers[514], _typeName, __Matchers[483], __Matchers[515], _optionalTypeSpecifier);
                /* 517 SeqOp            */ __Matchers[517].Set(_annotations, __Matchers[511], _memberName, __Matchers[512], _block);
                /* 519 OptionalOp       */ __Matchers[519].Set(_extendedType);
                /* 520 SeqOp            */ __Matchers[520].Set(_annotations, __Matchers[518], _memberName, __Matchers[519], __Matchers[506], _classBlock);
                /* 522 SeqOp            */ __Matchers[522].Set(_annotations, __Matchers[521], _memberName, _setterDefinition);
                /* 523 AltOp            */ __Matchers[523].Set(_block, _neededFunctionSpecifier);
                /* 524 SeqOp            */ __Matchers[524].Set(_annotations, _methodType, _parametrizedMember, __Matchers[515], _methodDefinition);
                /* 525 AltOp            */ __Matchers[525].Set(_variadicType, _kwVoid);
                /* 527 SeqOp            */ __Matchers[527].Set(_annotations, __Matchers[526], _parametrizedMember, __Matchers[515], _methodDefinition);
                /* 528 SeqOp            */ __Matchers[528].Set(_annotations, _attributeType, _memberName, _attributeDefinition);
                /* 530 SeqOp            */ __Matchers[530].Set(_annotations, __Matchers[529], _memberName, _attributeDefinition);
                /* 531 AltOp            */ __Matchers[531].Set(_block, _optionalAnySpecifier);
                /* 532 OptionalOp       */ __Matchers[532].Set(_anySpecifier);
                /* 533 SeqOp            */ __Matchers[533].Set(__Matchers[532], __Matchers[394]);
                /* 535 OptionalOp       */ __Matchers[535].Set(_parameters);
                /* 536 SeqOp            */ __Matchers[536].Set(_annotations, __Matchers[534], _typeName, __Matchers[483], __Matchers[535], __Matchers[505], __Matchers[519], __Matchers[506], __Matchers[515], _classDefinition);
                /* 537 AltOp            */ __Matchers[537].Set(_classBlock, _optionalClassSpecifier);
                /* 538 OptionalOp       */ __Matchers[538].Set(_classSpecifier);
                /* 539 SeqOp            */ __Matchers[539].Set(__Matchers[538], __Matchers[394]);
                /* 541 SeqOp            */ __Matchers[541].Set(_annotations, __Matchers[540], _typeName, __Matchers[483], __Matchers[505], __Matchers[506], __Matchers[515], _interfaceDefinition);
                /* 542 AltOp            */ __Matchers[542].Set(_interfaceBlock, _optionalTypeSpecifier);
                /* 543 OptionalOp       */ __Matchers[543].Set(_typeSpecifier);
                /* 544 SeqOp            */ __Matchers[544].Set(__Matchers[543], __Matchers[394]);
                /* 545 AltOp            */ __Matchers[545].Set(_unclosedStatement, _controlStatement);
                /* 546 SeqOp            */ __Matchers[546].Set(_openStatement, __Matchers[394]);
                /* 547 AltOp            */ __Matchers[547].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 548 SeqOp            */ __Matchers[548].Set(_primary, _functionSpecifier);
                /* 549 AltOp            */ __Matchers[549].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 551 OptionalOp       */ __Matchers[551].Set(_expression);
                /* 552 SeqOp            */ __Matchers[552].Set(__Matchers[550], __Matchers[551]);
                /* 554 SeqOp            */ __Matchers[554].Set(__Matchers[553], __Matchers[551]);
                /* 557 SeqOp            */ __Matchers[557].Set(__Matchers[444], _type);
                /* 558 SeqOp            */ __Matchers[558].Set(__Matchers[409], _expression);
                /* 559 SeqOp            */ __Matchers[559].Set(__Matchers[444], _expression);
                /* 560 AltOp            */ __Matchers[560].Set(_valueSpecifier, _functionSpecifier);
                /* 561 AltOp            */ __Matchers[561].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 562 AltOp            */ __Matchers[562].Set(_memberReference, _typeReference);
                /* 563 SeqOp            */ __Matchers[563].Set(_memberName, __Matchers[483], __Matchers[484]);
                /* 564 SeqOp            */ __Matchers[564].Set(_selfReferenceSelector, _parametrizedMember);
                /* 565 OptionalOp       */ __Matchers[565].Set(_typeArguments);
                /* 566 SeqOp            */ __Matchers[566].Set(_memberName, __Matchers[565]);
                /* 567 SeqOp            */ __Matchers[567].Set(_typeName, __Matchers[565]);
                /* 568 SeqOp            */ __Matchers[568].Set(_selfReference, _memberSelectionOperator);
                /* 571 AltOp            */ __Matchers[571].Set(__Matchers[569], __Matchers[450], __Matchers[570], __Matchers[393]);
                /* 572 OptionalOp       */ __Matchers[572].Set(_sequencedArguments);
                /* 573 SeqOp            */ __Matchers[573].Set(__Matchers[388], __Matchers[441], __Matchers[572], __Matchers[390]);
                /* 574 SeqOp            */ __Matchers[574].Set(__Matchers[421], __Matchers[572], __Matchers[423]);
                /* 575 AltOp            */ __Matchers[575].Set(_structuralArguments, _positionalArguments);
                /* 576 StarOp           */ __Matchers[576].Set(_namedOrAnonymous);
                /* 577 SeqOp            */ __Matchers[577].Set(__Matchers[388], __Matchers[576], __Matchers[572], __Matchers[390]);
                /* 578 AltOp            */ __Matchers[578].Set(_namedArgument, _anonymousArgument);
                /* 579 AltOp            */ __Matchers[579].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 580 SeqOp            */ __Matchers[580].Set(_memberName, _valueSpecifier, __Matchers[394]);
                /* 581 SeqOp            */ __Matchers[581].Set(__Matchers[401], _sequencedArgument);
                /* 582 StarOp           */ __Matchers[582].Set(__Matchers[581]);
                /* 583 SeqOp            */ __Matchers[583].Set(_sequencedArgument, __Matchers[582]);
                /* 584 AltOp            */ __Matchers[584].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 585 SeqOp            */ __Matchers[585].Set(_expression, __Matchers[394]);
                /* 586 AltOp            */ __Matchers[586].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 587 SeqOp            */ __Matchers[587].Set(__Matchers[518], __Matchers[430], __Matchers[519], __Matchers[506], _classBlock);
                /* 588 SeqOp            */ __Matchers[588].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 589 AltOp            */ __Matchers[589].Set(_block, _optionalFunctionSpecifier);
                /* 590 SeqOp            */ __Matchers[590].Set(__Matchers[485], __Matchers[394]);
                /* 591 SeqOp            */ __Matchers[591].Set(_functionSpecifier, __Matchers[394]);
                /* 592 AltOp            */ __Matchers[592].Set(_type, _kwVoid);
                /* 593 SeqOp            */ __Matchers[593].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 594 SeqOp            */ __Matchers[594].Set(__Matchers[526], __Matchers[430], __Matchers[483], _parameters, _methodDefinition);
                /* 595 SeqOp            */ __Matchers[595].Set(__Matchers[529], _memberName, _methodDefinition);
                /* 596 SeqOp            */ __Matchers[596].Set(_memberName, __Matchers[484], _neededFunctionSpecifier);
                /* 597 SeqOp            */ __Matchers[597].Set(_memberName, _neededFunctionSpecifier);
                /* 598 SeqOp            */ __Matchers[598].Set(__Matchers[433], __Matchers[572], __Matchers[434]);
                /* 599 AltOp            */ __Matchers[599].Set(_expression, _declarationReference);
                /* 601 SeqOp            */ __Matchers[601].Set(__Matchers[600], _unionExpression);
                /* 602 OptionalOp       */ __Matchers[602].Set(_letVariableList);
                /* 603 SeqOp            */ __Matchers[603].Set(__Matchers[432], __Matchers[433], __Matchers[602], __Matchers[434], _conditionalExpression);
                /* 604 SeqOp            */ __Matchers[604].Set(__Matchers[401], _letVariable);
                /* 605 StarOp           */ __Matchers[605].Set(__Matchers[604]);
                /* 606 SeqOp            */ __Matchers[606].Set(_letVariable, __Matchers[605]);
                /* 607 SeqOp            */ __Matchers[607].Set(_pattern, _valueSpecifier);
                /* 608 SeqOp            */ __Matchers[608].Set(_switchHeader, _caseExpressions);
                /* 609 PlusOp           */ __Matchers[609].Set(_caseExpression);
                /* 610 OptionalOp       */ __Matchers[610].Set(_elseExpression);
                /* 611 SeqOp            */ __Matchers[611].Set(__Matchers[609], __Matchers[610]);
                /* 613 OptionalOp       */ __Matchers[613].Set(__Matchers[612]);
                /* 615 SeqOp            */ __Matchers[615].Set(__Matchers[613], __Matchers[614], __Matchers[433], _caseItem, __Matchers[434], _conditionalExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[616], _conditions, _thenExpression, _elseExpression);
                /* 618 SeqOp            */ __Matchers[618].Set(__Matchers[612], _conditionalExpression);
                /* 620 SeqOp            */ __Matchers[620].Set(__Matchers[619], _conditionalExpression);
                /* 621 AltOp            */ __Matchers[621].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 622 OptionalOp       */ __Matchers[622].Set(_functionExpressionType);
                /* 623 OptionalOp       */ __Matchers[623].Set(_functionParameters);
                /* 624 SeqOp            */ __Matchers[624].Set(__Matchers[622], __Matchers[483], __Matchers[623], _functionDefinition);
                /* 626 AltOp            */ __Matchers[626].Set(__Matchers[625], __Matchers[526]);
                /* 627 SeqOp            */ __Matchers[627].Set(__Matchers[484], __Matchers[515]);
                /* 628 AltOp            */ __Matchers[628].Set(_block, _functionSpecifier);
                /* 629 AltOp            */ __Matchers[629].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 630 AltOp            */ __Matchers[630].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 632 OptionalOp       */ __Matchers[632].Set(_forIterator);
                /* 633 SeqOp            */ __Matchers[633].Set(__Matchers[631], __Matchers[433], __Matchers[632], __Matchers[434], _comprehensionClause);
                /* 634 SeqOp            */ __Matchers[634].Set(__Matchers[616], _conditions, _comprehensionClause);
                /* 635 AltOp            */ __Matchers[635].Set(_letExpr, _ifExpr, _switchExpr, _functionExpr, _operatorExpression);
                /* 636 AltOp            */ __Matchers[636].Set(_assignmentExpr, _thenElseExpression);
                /* 637 SeqOp            */ __Matchers[637].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 649 AltOp            */ __Matchers[649].Set(__Matchers[409], __Matchers[638], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646], __Matchers[647], __Matchers[648]);
                /* 650 AltOp            */ __Matchers[650].Set(_thenElseExpr, _disjunctionExpression);
                /* 651 SeqOp            */ __Matchers[651].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 652 AltOp            */ __Matchers[652].Set(__Matchers[612], __Matchers[619]);
                /* 653 AltOp            */ __Matchers[653].Set(_disjunctionExpr, _conjunctionExpression);
                /* 654 SeqOp            */ __Matchers[654].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 656 AltOp            */ __Matchers[656].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 657 SeqOp            */ __Matchers[657].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 659 AltOp            */ __Matchers[659].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 660 SeqOp            */ __Matchers[660].Set(_notOperator, _logicalNegationExpression);
                /* 662 AltOp            */ __Matchers[662].Set(_equalityExpression, _modelReference);
                /* 663 AltOp            */ __Matchers[663].Set(_equalityExpr, _comparisonExpression);
                /* 664 SeqOp            */ __Matchers[664].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 668 AltOp            */ __Matchers[668].Set(__Matchers[665], __Matchers[666], __Matchers[667]);
                /* 669 AltOp            */ __Matchers[669].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 670 SeqOp            */ __Matchers[670].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 672 SeqOp            */ __Matchers[672].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 673 SeqOp            */ __Matchers[673].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 674 SeqOp            */ __Matchers[674].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 675 SeqOp            */ __Matchers[675].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 677 AltOp            */ __Matchers[677].Set(__Matchers[676], __Matchers[499]);
                /* 679 AltOp            */ __Matchers[679].Set(__Matchers[678], __Matchers[490]);
                /* 681 AltOp            */ __Matchers[681].Set(__Matchers[680], __Matchers[491]);
                /* 683 AltOp            */ __Matchers[683].Set(__Matchers[682], __Matchers[436], __Matchers[459], __Matchers[464]);
                /* 684 AltOp            */ __Matchers[684].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 686 SeqOp            */ __Matchers[686].Set(_entryRangeExpression, __Matchers[685]);
                /* 688 SeqOp            */ __Matchers[688].Set(_entryRangeExpression, __Matchers[687]);
                /* 689 AltOp            */ __Matchers[689].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 690 SeqOp            */ __Matchers[690].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 691 SeqOp            */ __Matchers[691].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 693 AltOp            */ __Matchers[693].Set(__Matchers[692], __Matchers[380]);
                /* 694 AltOp            */ __Matchers[694].Set(_additiveExpr, _scaleExpression);
                /* 695 SeqOp            */ __Matchers[695].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 698 AltOp            */ __Matchers[698].Set(__Matchers[696], __Matchers[697]);
                /* 699 AltOp            */ __Matchers[699].Set(_scaleExpr, _multiplicativeExpression);
                /* 700 SeqOp            */ __Matchers[700].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 702 AltOp            */ __Matchers[702].Set(_multiplicativeExpr, _unionExpression);
                /* 703 SeqOp            */ __Matchers[703].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 706 AltOp            */ __Matchers[706].Set(__Matchers[600], __Matchers[704], __Matchers[705]);
                /* 707 AltOp            */ __Matchers[707].Set(_unionExpr, _exclusiveExpression);
                /* 708 SeqOp            */ __Matchers[708].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 710 AltOp            */ __Matchers[710].Set(__Matchers[466], __Matchers[709]);
                /* 711 AltOp            */ __Matchers[711].Set(_exclusiveExpr, _intersectionExpression);
                /* 712 SeqOp            */ __Matchers[712].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 714 AltOp            */ __Matchers[714].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 715 SeqOp            */ __Matchers[715].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 717 AltOp            */ __Matchers[717].Set(_negationOrComplementExpr, _prefixExpression);
                /* 718 SeqOp            */ __Matchers[718].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 719 AltOp            */ __Matchers[719].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 720 NotOp            */ __Matchers[720].Set(__Matchers_720_DFA);
                /* 721 SeqOp            */ __Matchers[721].Set(__Matchers[697], __Matchers[720]);
                /* 722 NotOp            */ __Matchers[722].Set(__Matchers_722_DFA);
                /* 723 SeqOp            */ __Matchers[723].Set(__Matchers[696], __Matchers[722]);
                /* 724 AltOp            */ __Matchers[724].Set(_prefixExpr, _postfixExpression);
                /* 725 SeqOp            */ __Matchers[725].Set(_incrementOperator, _prefixExpression);
                /* 726 AltOp            */ __Matchers[726].Set(_postfixExpr, _primary);
                /* 727 SeqOp            */ __Matchers[727].Set(_postfixExpression, _incrementOperator);
                /* 730 AltOp            */ __Matchers[730].Set(__Matchers[728], __Matchers[729]);
                /* 731 AltOp            */ __Matchers[731].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 732 SeqOp            */ __Matchers[732].Set(_primary, _qualifiedReference);
                /* 733 SeqOp            */ __Matchers[733].Set(_memberSelectionOperator, _baseReference);
                /* 736 AltOp            */ __Matchers[736].Set(__Matchers[412], __Matchers[734], __Matchers[735]);
                /* 737 SeqOp            */ __Matchers[737].Set(_primary, __Matchers[421], _index, __Matchers[423]);
                /* 738 AltOp            */ __Matchers[738].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 739 SeqOp            */ __Matchers[739].Set(_indexExpression, __Matchers[411]);
                /* 740 SeqOp            */ __Matchers[740].Set(__Matchers[411], _indexExpression);
                /* 741 SeqOp            */ __Matchers[741].Set(_indexExpression, __Matchers[692], _indexExpression);
                /* 742 SeqOp            */ __Matchers[742].Set(_indexExpression, __Matchers[380], _indexExpression);
                /* 743 SeqOp            */ __Matchers[743].Set(_primary, _arguments);
                /* 744 AltOp            */ __Matchers[744].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 745 AltOp            */ __Matchers[745].Set(_literalNatural, _literalFloat, _literalChar);
                /* 746 AltOp            */ __Matchers[746].Set(_stringLiteral, _stringInterpolation);
                /* 747 StarOp           */ __Matchers[747].Set(_interpolationPart);
                /* 748 SeqOp            */ __Matchers[748].Set(_stringStart, _expression, __Matchers[747], _stringEnd);
                /* 749 SeqOp            */ __Matchers[749].Set(_stringMid, _expression);
                /* 750 AltOp            */ __Matchers[750].Set(_literalString, _verbatimString);
                /* 751 SeqOp            */ __Matchers[751].Set(__Matchers[518], __Matchers[519], __Matchers[506], _classBlock);
                /* 752 SeqOp            */ __Matchers[752].Set(__Matchers[433], _expression, __Matchers[434]);
                /* 753 OptionalOp       */ __Matchers[753].Set(_typeArgumentList);
                /* 754 SeqOp            */ __Matchers[754].Set(__Matchers[490], __Matchers[753], __Matchers[491]);
                /* 755 SeqOp            */ __Matchers[755].Set(__Matchers[401], _variancedType);
                /* 756 StarOp           */ __Matchers[756].Set(__Matchers[755]);
                /* 757 SeqOp            */ __Matchers[757].Set(_variancedType, __Matchers[756]);
                /* 758 SeqOp            */ __Matchers[758].Set(__Matchers[496], _type);
                /* 759 SeqOp            */ __Matchers[759].Set(__Matchers[401], _defaultedType);
                /* 760 StarOp           */ __Matchers[760].Set(__Matchers[759]);
                /* 761 SeqOp            */ __Matchers[761].Set(_defaultedType, __Matchers[760]);
                /* 762 AltOp            */ __Matchers[762].Set(_defaultedTypeCore, _variadicType);
                /* 763 SeqOp            */ __Matchers[763].Set(_type, __Matchers[409]);
                /* 764 AltOp            */ __Matchers[764].Set(_variadicUnionType, _type);
                /* 765 SeqOp            */ __Matchers[765].Set(_unionType, _variadicOperator);
                /* 766 AltOp            */ __Matchers[766].Set(__Matchers[600], __Matchers[696]);
                /* 767 SeqOp            */ __Matchers[767].Set(__Matchers[600], _unionType);
                /* 768 AltOp            */ __Matchers[768].Set(_entryType, _unionType);
                /* 769 SeqOp            */ __Matchers[769].Set(_unionType, __Matchers[419], _unionType);
                /* 770 AltOp            */ __Matchers[770].Set(_unionTypeCore, _intersectionType);
                /* 771 SeqOp            */ __Matchers[771].Set(_unionType, __Matchers[466], _intersectionType);
                /* 772 AltOp            */ __Matchers[772].Set(_intersectionTypeCore, _primaryType);
                /* 773 SeqOp            */ __Matchers[773].Set(_intersectionType, __Matchers[716], _primaryType);
                /* 774 AltOp            */ __Matchers[774].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _qualifiedType);
                /* 776 SeqOp            */ __Matchers[776].Set(_primaryType, __Matchers[775]);
                /* 777 OptionalOp       */ __Matchers[777].Set(_literalNatural);
                /* 778 SeqOp            */ __Matchers[778].Set(_primaryType, __Matchers[421], __Matchers[777], __Matchers[423]);
                /* 779 OptionalOp       */ __Matchers[779].Set(_typeTypeArguments);
                /* 780 SeqOp            */ __Matchers[780].Set(_primaryType, __Matchers[433], __Matchers[779], __Matchers[434]);
                /* 781 AltOp            */ __Matchers[781].Set(_spreadType, _defaultedTypeList);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[421], __Matchers[779], __Matchers[423]);
                /* 783 OptionalOp       */ __Matchers[783].Set(_variadicType);
                /* 784 SeqOp            */ __Matchers[784].Set(__Matchers[388], __Matchers[783], __Matchers[390]);
                /* 785 SeqOp            */ __Matchers[785].Set(__Matchers[490], _type, __Matchers[491]);
                /* 786 SeqOp            */ __Matchers[786].Set(__Matchers[471], _typePath);
                /* 787 OptionalOp       */ __Matchers[787].Set(_stringLiteral);
                /* 788 StarOp           */ __Matchers[788].Set(_annotation);
                /* 789 SeqOp            */ __Matchers[789].Set(__Matchers[787], __Matchers[788]);
                /* 790 SeqOp            */ __Matchers[790].Set(_annotationName, __Matchers[446]);
                /* 791 OptionalOp       */ __Matchers[791].Set(_conditionList);
                /* 792 SeqOp            */ __Matchers[792].Set(__Matchers[433], __Matchers[791], __Matchers[434]);
                /* 793 SeqOp            */ __Matchers[793].Set(__Matchers[401], _condition);
                /* 794 StarOp           */ __Matchers[794].Set(__Matchers[793]);
                /* 795 SeqOp            */ __Matchers[795].Set(_condition, __Matchers[794]);
                /* 796 AltOp            */ __Matchers[796].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 797 OptionalOp       */ __Matchers[797].Set(__Matchers[661]);
                /* 798 SeqOp            */ __Matchers[798].Set(__Matchers[797], __Matchers[685], _letOrExpression);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[797], __Matchers[687], _letOrExpression);
                /* 800 AltOp            */ __Matchers[800].Set(_letVariable, _operatorExpression);
                /* 801 SeqOp            */ __Matchers[801].Set(__Matchers[797], __Matchers[682], _type, _isConditionVariable);
                /* 802 SeqOp            */ __Matchers[802].Set(_memberName, __Matchers[480]);
                /* 803 SeqOp            */ __Matchers[803].Set(__Matchers[459], _type, _typeName);
                /* 804 AltOp            */ __Matchers[804].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 805 OptionalOp       */ __Matchers[805].Set(_elseBlock);
                /* 806 SeqOp            */ __Matchers[806].Set(_ifBlock, __Matchers[805]);
                /* 807 SeqOp            */ __Matchers[807].Set(__Matchers[616], _conditions, _block);
                /* 808 SeqOp            */ __Matchers[808].Set(__Matchers[612], _elseBlockNext);
                /* 809 AltOp            */ __Matchers[809].Set(_ifElseStatement, _block);
                /* 810 PlusOp           */ __Matchers[810].Set(_caseBlock);
                /* 811 SeqOp            */ __Matchers[811].Set(_switchHeader, __Matchers[810], __Matchers[805]);
                /* 813 SeqOp            */ __Matchers[813].Set(__Matchers[812], __Matchers[433], _switched, __Matchers[434]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[613], __Matchers[614], __Matchers[433], _caseItem, __Matchers[434], _block);
                /* 815 AltOp            */ __Matchers[815].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 816 OptionalOp       */ __Matchers[816].Set(__Matchers[682]);
                /* 817 SeqOp            */ __Matchers[817].Set(__Matchers[816], _type);
                /* 818 SeqOp            */ __Matchers[818].Set(__Matchers[459], _type);
                /* 819 SeqOp            */ __Matchers[819].Set(_valueCaseSeparator, _valueCase);
                /* 820 StarOp           */ __Matchers[820].Set(__Matchers[819]);
                /* 821 SeqOp            */ __Matchers[821].Set(_valueCase, __Matchers[820]);
                /* 822 AltOp            */ __Matchers[822].Set(__Matchers[401], __Matchers[466]);
                /* 823 AltOp            */ __Matchers[823].Set(_intersectionType, _intersectionExpression);
                /* 824 OptionalOp       */ __Matchers[824].Set(_failBlock);
                /* 825 SeqOp            */ __Matchers[825].Set(_forBlock, __Matchers[824]);
                /* 826 SeqOp            */ __Matchers[826].Set(__Matchers[631], __Matchers[433], __Matchers[632], __Matchers[434], _block);
                /* 827 SeqOp            */ __Matchers[827].Set(__Matchers[612], _block);
                /* 828 OptionalOp       */ __Matchers[828].Set(_containment);
                /* 829 SeqOp            */ __Matchers[829].Set(_forVariable, __Matchers[828]);
                /* 830 AltOp            */ __Matchers[830].Set(_tupleOrEntryPattern, _variable);
                /* 831 SeqOp            */ __Matchers[831].Set(_containmentOperator, _operatorExpression);
                /* 832 AltOp            */ __Matchers[832].Set(__Matchers[499], __Matchers[380]);
                /* 834 SeqOp            */ __Matchers[834].Set(__Matchers[833], _conditions, _block);
                /* 835 StarOp           */ __Matchers[835].Set(_catchBlock);
                /* 836 OptionalOp       */ __Matchers[836].Set(_finallyBlock);
                /* 837 SeqOp            */ __Matchers[837].Set(_tryBlock, __Matchers[835], __Matchers[836]);
                /* 839 OptionalOp       */ __Matchers[839].Set(_resources);
                /* 840 SeqOp            */ __Matchers[840].Set(__Matchers[838], __Matchers[839], _block);
                /* 842 SeqOp            */ __Matchers[842].Set(__Matchers[841], _catchVariable, _block);
                /* 843 OptionalOp       */ __Matchers[843].Set(_variable);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[433], __Matchers[843], __Matchers[434]);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[845], _block);
                /* 847 OptionalOp       */ __Matchers[847].Set(_resourceList);
                /* 848 SeqOp            */ __Matchers[848].Set(__Matchers[433], __Matchers[847], __Matchers[434]);
                /* 849 SeqOp            */ __Matchers[849].Set(__Matchers[401], _resource);
                /* 850 StarOp           */ __Matchers[850].Set(__Matchers[849]);
                /* 851 SeqOp            */ __Matchers[851].Set(_resource, __Matchers[850]);
                /* 852 AltOp            */ __Matchers[852].Set(_specifiedVariable, _operatorExpression);
                /* 853 SeqOp            */ __Matchers[853].Set(_variable, _valueSpecifier);
                /* 854 OptionalOp       */ __Matchers[854].Set(_variableType);
                /* 855 StarOp           */ __Matchers[855].Set(_parameters);
                /* 856 SeqOp            */ __Matchers[856].Set(__Matchers[854], _memberName, __Matchers[855]);
                /* 857 AltOp            */ __Matchers[857].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 858 SeqOp            */ __Matchers[858].Set(__Matchers[713], _modelExpression);
                /* 860 SeqOp            */ __Matchers[860].Set(__Matchers[859], _metaExpression, __Matchers[859]);
                /* 861 AltOp            */ __Matchers[861].Set(_declarationReference, _modelExpression);
                /* 862 AltOp            */ __Matchers[862].Set(_memberModelExpression, _typeModelExpression);
                /* 863 AltOp            */ __Matchers[863].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 864 SeqOp            */ __Matchers[864].Set(_packageQualifier, _memberReference);
                /* 865 SeqOp            */ __Matchers[865].Set(_primaryType, __Matchers[412], _memberReference);
                /* 866 AltOp            */ __Matchers[866].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 867 OptionalOp       */ __Matchers[867].Set(_packagePath);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[376], __Matchers[867]);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[393], __Matchers[867]);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[534], _referencePath);
                /* 871 SeqOp            */ __Matchers[871].Set(__Matchers[540], _referencePath);
                /* 872 SeqOp            */ __Matchers[872].Set(__Matchers[514], _referencePath);
                /* 873 SeqOp            */ __Matchers[873].Set(__Matchers[503], _referencePath);
                /* 874 SeqOp            */ __Matchers[874].Set(__Matchers[511], _referencePath);
                /* 875 SeqOp            */ __Matchers[875].Set(_valueLiteralIntro, _referencePath);
                /* 876 AltOp            */ __Matchers[876].Set(__Matchers[529], __Matchers[518]);
                /* 877 SeqOp            */ __Matchers[877].Set(__Matchers[526], _referencePath);
                /* 878 SeqOp            */ __Matchers[878].Set(__Matchers[471], _referencePathElementList);
                /* 879 SeqOp            */ __Matchers[879].Set(__Matchers[412], _referencePathElement);
                /* 880 StarOp           */ __Matchers[880].Set(__Matchers[879]);
                /* 881 SeqOp            */ __Matchers[881].Set(_referencePathElement, __Matchers[880]);

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
                __Matchers_720_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_720_DFA.States[0].Set(
                    new DfaTrans(__Matchers_720_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_720_DFA.States[1].Set(
                );
                __Matchers_722_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_722_DFA.States[0].Set(
                    new DfaTrans(__Matchers_722_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_722_DFA.States[1].Set(
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
            private PlainRule _annotationName;
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
            private PlainRule _superQualifier;
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
            private PlainRule _enumeratedObject;
            private PlainRule _objectDeclaration;
            private PlainRule _setterDeclaration;
            private PlainRule _setterDefinition;
            private PlainRule _typedMethodDeclaration;
            private PlainRule _methodType;
            private PlainRule _inferredMethodDeclaration;
            private PlainRule _typedAttributeDeclaration;
            private PlainRule _attributeType;
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
            private PlainRule _namedSpecifiedArgument;
            private PlainRule _sequencedArguments;
            private PlainRule _sequencedArgument;
            private PlainRule _anonymousArgument;
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
            private PlainRule _qualifiedType;
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
            private Dfa __Matchers_720_DFA = new Dfa("__Matchers_720_DFA");
            private Dfa __Matchers_722_DFA = new Dfa("__Matchers_722_DFA");
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
        public interface ICAnnotationName : IRNode {}
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
        public interface ICSuperQualifier : IRNode {}
        public interface ICPackageQualifiedClass : ICQualifiedClass {}
        public interface ICPackageQualifier : IRNode {}
        public interface ICUnQualifiedClass : ICQualifiedClass {}
        public interface ICMemberPath : ICUnQualifiedClass {}
        public interface ICTypePath : ICUnQualifiedClass {}
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
        public interface ICEnumeratedObject : ICDeclaration {}
        public interface ICObjectDeclaration : ICDeclaration {}
        public interface ICSetterDeclaration : ICDeclaration {}
        public interface ICSetterDefinition : IRNode {}
        public interface ICTypedMethodDeclaration : ICDeclaration {}
        public interface ICMethodType : IRNode {}
        public interface ICInferredMethodDeclaration : ICDeclaration {}
        public interface ICTypedAttributeDeclaration : ICDeclaration {}
        public interface ICAttributeType : IRNode {}
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
        public interface ICNamedSpecifiedArgument : ICNamedArgument {}
        public interface ICSequencedArguments : IRNode {}
        public interface ICSequencedArgument : IRNode {}
        public interface ICAnonymousArgument : ICNamedOrAnonymous {}
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
        public interface ICVariadicType : ICAttributeType, ICDefaultedType, ICFunctionParameterType, ICMethodType, ICValueParameterType {}
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
        public interface ICQualifiedType : ICPrimaryType {}
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
        public interface ICKwVoid : ICFunctionParameterType, ICMethodArgumentType, ICMethodType, ICVariableType {}
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
        public interface ICLowerIdentifier : ICAnnotationName, ICMemberName {}
        public interface ICUpperIdentifier : ICTypeName {}
        public interface ICIdentifier : ICImportName, ICPackageName, ICReferencePathElement, ICRepository {}

        public partial class CXStart : RSequence, ICXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public ICCompilationUnit CompilationUnit => Get<ICCompilationUnit>(0);
            public REof Eof => Get<REof>(1);
        }

        public partial class CXWhitespace : RToken, ICXWhitespace
        {
            public CXWhitespace(params Node[] children) : base(children) {}
        }

        public partial class CXKeywords : RToken, ICXKeywords
        {
            public CXKeywords(params Node[] children) : base(children) {}
        }

        public partial class CUnitElements : RSequence, ICUnitElements
        {
            public CUnitElements(params RNode[] children) : base(children) {}

            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(0);
            public RStar<ICDeclaration> DeclarationStar => Get<RStar<ICDeclaration>>(1);
        }

        public partial class CImportDeclarations : RStar<CImportDeclaration>, ICImportDeclarations
        {
            public CImportDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
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
            public CModuleSpecifier(params RNode[] children) : base(children) {}

            public ICRepository Repository => Get<ICRepository>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICModule Module => Get<ICModule>(2);
            public ROptional<CArtifactAndClassifier> ArtifactAndClassifierOptional => Get<ROptional<CArtifactAndClassifier>>(3);
        }

        public partial class CArtifactAndClassifier : RSequence, ICArtifactAndClassifier
        {
            public CArtifactAndClassifier(params RNode[] children) : base(children) {}

            public CArtifact Artifact => Get<CArtifact>(0);
            public ROptional<CClassifier> ClassifierOptional => Get<ROptional<CClassifier>>(1);
        }

        public partial class CArtifact : RSequence, ICArtifact
        {
            public CArtifact(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CClassifier : RSequence, ICClassifier
        {
            public CClassifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CModuleBody : RSequence, ICModuleBody
        {
            public CModuleBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICModuleBodyElement> ModuleBodyElementStar => Get<RStar<ICModuleBodyElement>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CPackageDescriptor : RSequence, ICPackageDescriptor
        {
            public CPackageDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CPackagePath PackagePath => Get<CPackagePath>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CImportModule : RSequence, ICImportModule
        {
            public CImportModule(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICModule Module => Get<ICModule>(2);
            public ROptional<ICVersion> VersionOptional => Get<ROptional<ICVersion>>(3);
            public RLiteral Literal2 => Get<RLiteral>(4);
        }

        public partial class CImportDeclaration : RSequence, ICImportDeclaration
        {
            public CImportDeclaration(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CPackagePath PackagePath => Get<CPackagePath>(1);
            public CImportElements ImportElements => Get<CImportElements>(2);
        }

        public partial class CImportElements : RSequence, ICImportElements
        {
            public CImportElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CImportElementList> ImportElementListOptional => Get<ROptional<CImportElementList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CImportElementList : RLoop<ICImportElement>, ICImportElementList
        {
            public CImportElementList(params RNode[] children) : base(children) {}
        }

        public partial class CImportNamed : RSequence, ICImportNamed
        {
            public CImportNamed(params RNode[] children) : base(children) {}

            public ICImportName ImportName => Get<ICImportName>(0);
            public ROptional<CImportNameSpecifier> ImportNameSpecifierOptional => Get<ROptional<CImportNameSpecifier>>(1);
            public ROptional<CImportElements> ImportElementsOptional => Get<ROptional<CImportElements>>(2);
        }

        public partial class CImportNameSpecifier : RSequence, ICImportNameSpecifier
        {
            public CImportNameSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CIdentifier Identifier => Get<CIdentifier>(1);
        }

        public partial class CImportWildcard : RLiteral, ICImportWildcard
        {
            public CImportWildcard(params Node[] children) : base(children) {}
        }

        public partial class CPackagePath : RLoop<ICPackageName>, ICPackagePath
        {
            public CPackagePath(params RNode[] children) : base(children) {}
        }

        public partial class CEntryPattern : RSequence, ICEntryPattern
        {
            public CEntryPattern(params RNode[] children) : base(children) {}

            public ICVariableOrTuplePattern VariableOrTuplePattern => Get<ICVariableOrTuplePattern>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICVariableOrTuplePattern VariableOrTuplePattern2 => Get<ICVariableOrTuplePattern>(2);
        }

        public partial class CTuplePattern : RSequence, ICTuplePattern
        {
            public CTuplePattern(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CVariadicPatternList> VariadicPatternListOptional => Get<ROptional<CVariadicPatternList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CVariadicPatternList : RLoop<ICVariadicPattern>, ICVariadicPatternList
        {
            public CVariadicPatternList(params RNode[] children) : base(children) {}
        }

        public partial class CVariadicVariable : RSequence, ICVariadicVariable
        {
            public CVariadicVariable(params RNode[] children) : base(children) {}

            public ROptional<ICUnionType> UnionTypeOptional => Get<ROptional<ICUnionType>>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(2);
        }

        public partial class CLetStatement : RSequence, ICLetStatement
        {
            public CLetStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public CLetVariableList LetVariableList => Get<CLetVariableList>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
        }

        public partial class CDelegatedConstructor : RSequence, ICDelegatedConstructor
        {
            public CDelegatedConstructor(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CAssertionStatement : RSequence, ICAssertionStatement
        {
            public CAssertionStatement(params RNode[] children) : base(children) {}

            public ROptional<ICAssertionMessage> AssertionMessageOptional => Get<ROptional<ICAssertionMessage>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CConditions Conditions => Get<CConditions>(2);
        }

        public partial class CBlockElements : RSequence, ICBlockElements
        {
            public CBlockElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(1);
            public RStar<ICDeclarationOrStatement> DeclarationOrStatementStar => Get<RStar<ICDeclarationOrStatement>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CExtendedType : RSequence, ICExtendedType
        {
            public CExtendedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassSpecifier : RSequence, ICClassSpecifier
        {
            public CClassSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassInstatiation : RSequence, ICClassInstatiation
        {
            public CClassInstatiation(params RNode[] children) : base(children) {}

            public ICQualifiedClass QualifiedClass => Get<ICQualifiedClass>(0);
            public ROptional<ICArguments> ArgumentsOptional => Get<ROptional<ICArguments>>(1);
        }

        public partial class CSuperQualifiedClass : RSequence, ICSuperQualifiedClass
        {
            public CSuperQualifiedClass(params RNode[] children) : base(children) {}

            public CSuperQualifier SuperQualifier => Get<CSuperQualifier>(0);
            public ICBaseReference BaseReference => Get<ICBaseReference>(1);
        }

        public partial class CSuperQualifier : RSequence, ICSuperQualifier
        {
            public CSuperQualifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
        }

        public partial class CPackageQualifiedClass : RSequence, ICPackageQualifiedClass
        {
            public CPackageQualifiedClass(params RNode[] children) : base(children) {}

            public CPackageQualifier PackageQualifier => Get<CPackageQualifier>(0);
            public ICUnQualifiedClass UnQualifiedClass => Get<ICUnQualifiedClass>(1);
        }

        public partial class CPackageQualifier : RSequence, ICPackageQualifier
        {
            public CPackageQualifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
        }

        public partial class CMemberPath : RSequence, ICMemberPath
        {
            public CMemberPath(params RNode[] children) : base(children) {}

            public CTypePath TypePath => Get<CTypePath>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CTypePath : RLoop<CTypeReference>, ICTypePath
        {
            public CTypePath(params RNode[] children) : base(children) {}
        }

        public partial class CSatisfiedTypes : RSequence, ICSatisfiedTypes
        {
            public CSatisfiedTypes(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CUnionTypeList UnionTypeList => Get<CUnionTypeList>(1);
        }

        public partial class CUnionTypeList : RLoop<ICUnionType>, ICUnionTypeList
        {
            public CUnionTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CCaseTypes : RSequence, ICCaseTypes
        {
            public CCaseTypes(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CCaseTypeList CaseTypeList => Get<CCaseTypeList>(1);
        }

        public partial class CCaseTypeList : RLoop<ICCaseType>, ICCaseTypeList
        {
            public CCaseTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CQualifiedCaseType : RSequence, ICQualifiedCaseType
        {
            public CQualifiedCaseType(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
        }

        public partial class CParameters : RSequence, ICParameters
        {
            public CParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CParameterList> ParameterListOptional => Get<ROptional<CParameterList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CParameterList : RLoop<ICParameterDeclarationOrRefPattern>, ICParameterList
        {
            public CParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CParameter : RSequence, ICParameter
        {
            public CParameter(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICParameterDeclaration ParameterDeclaration => Get<ICParameterDeclaration>(1);
        }

        public partial class CParameterReference : RSequence, ICParameterReference
        {
            public CParameterReference(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CFunctionParameterDeclaration : RSequence, ICFunctionParameterDeclaration
        {
            public CFunctionParameterDeclaration(params RNode[] children) : base(children) {}

            public ICFunctionParameterType FunctionParameterType => Get<ICFunctionParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifierOptional => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CValueParameterDeclaration : RSequence, ICValueParameterDeclaration
        {
            public CValueParameterDeclaration(params RNode[] children) : base(children) {}

            public ICValueParameterType ValueParameterType => Get<ICValueParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(2);
        }

        public partial class CTypeParameters : RSequence, ICTypeParameters
        {
            public CTypeParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CTypeParameterList TypeParameterList => Get<CTypeParameterList>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeParameterList : RLoop<CTypeParameter>, ICTypeParameterList
        {
            public CTypeParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CTypeParameter : RSequence, ICTypeParameter
        {
            public CTypeParameter(params RNode[] children) : base(children) {}

            public ROptional<ICVariance> VarianceOptional => Get<ROptional<ICVariance>>(0);
            public ICTypeName TypeName => Get<ICTypeName>(1);
            public ROptional<CTypeDefault> TypeDefaultOptional => Get<ROptional<CTypeDefault>>(2);
        }

        public partial class CVariance : RLiteral, ICVariance
        {
            public CVariance(params Node[] children) : base(children) {}
        }

        public partial class CTypeDefault : RSequence, ICTypeDefault
        {
            public CTypeDefault(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CTypeConstraint : RSequence, ICTypeConstraint
        {
            public CTypeConstraint(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICTypeName> TypeNameOptional => Get<ROptional<ICTypeName>>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public ROptional<CCaseTypes> CaseTypesOptional => Get<ROptional<CCaseTypes>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(4);
        }

        public partial class CTypeConstraints : RPlus<CTypeConstraint>, ICTypeConstraints
        {
            public CTypeConstraints(params RNode[] children) : base(children) {}
        }

        public partial class CConstructorDeclaration : RSequence, ICConstructorDeclaration
        {
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
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(4);
            public COptionalTypeSpecifier OptionalTypeSpecifier => Get<COptionalTypeSpecifier>(5);
        }

        public partial class CEnumeratedObject : RSequence, ICEnumeratedObject
        {
            public CEnumeratedObject(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CDelegatedConstructor> DelegatedConstructorOptional => Get<ROptional<CDelegatedConstructor>>(3);
            public ICBlock Block => Get<ICBlock>(4);
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
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
            public CSetterDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICSetterDefinition SetterDefinition => Get<ICSetterDefinition>(3);
        }

        public partial class CTypedMethodDeclaration : RSequence, ICTypedMethodDeclaration
        {
            public CTypedMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICMethodType MethodType => Get<ICMethodType>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CInferredMethodDeclaration : RSequence, ICInferredMethodDeclaration
        {
            public CInferredMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CTypedAttributeDeclaration : RSequence, ICTypedAttributeDeclaration
        {
            public CTypedAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICAttributeType AttributeType => Get<ICAttributeType>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICAttributeDefinition AttributeDefinition => Get<ICAttributeDefinition>(3);
        }

        public partial class CInferredAttributeDeclaration : RSequence, ICInferredAttributeDeclaration
        {
            public CInferredAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICAttributeDefinition AttributeDefinition => Get<ICAttributeDefinition>(3);
        }

        public partial class COptionalAnySpecifier : RSequence, ICOptionalAnySpecifier
        {
            public COptionalAnySpecifier(params RNode[] children) : base(children) {}

            public ROptional<ICAnySpecifier> AnySpecifierOptional => Get<ROptional<ICAnySpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
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
            public COptionalClassSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CClassSpecifier> ClassSpecifierOptional => Get<ROptional<CClassSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
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
            public COptionalTypeSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CTypeSpecifier> TypeSpecifierOptional => Get<ROptional<CTypeSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CUnclosedStatement : RSequence, ICUnclosedStatement
        {
            public CUnclosedStatement(params RNode[] children) : base(children) {}

            public ICOpenStatement OpenStatement => Get<ICOpenStatement>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CSpecificationStatement : RSequence, ICSpecificationStatement
        {
            public CSpecificationStatement(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(1);
        }

        public partial class CReturnStatement : RSequence, ICReturnStatement
        {
            public CReturnStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICExpression> ExpressionOptional => Get<ROptional<ICExpression>>(1);
        }

        public partial class CThrowStatement : RSequence, ICThrowStatement
        {
            public CThrowStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICExpression> ExpressionOptional => Get<ROptional<ICExpression>>(1);
        }

        public partial class CBreakStatement : RLiteral, ICBreakStatement
        {
            public CBreakStatement(params Node[] children) : base(children) {}
        }

        public partial class CContinueStatement : RLiteral, ICContinueStatement
        {
            public CContinueStatement(params Node[] children) : base(children) {}
        }

        public partial class CTypeSpecifier : RSequence, ICTypeSpecifier
        {
            public CTypeSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CValueSpecifier : RSequence, ICValueSpecifier
        {
            public CValueSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CParametrizedMember : RSequence, ICParametrizedMember
        {
            public CParametrizedMember(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(2);
        }

        public partial class CSelfParametrizedMember : RSequence, ICSelfParametrizedMember
        {
            public CSelfParametrizedMember(params RNode[] children) : base(children) {}

            public CSelfReferenceSelector SelfReferenceSelector => Get<CSelfReferenceSelector>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
        }

        public partial class CMemberReference : RSequence, ICMemberReference
        {
            public CMemberReference(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CTypeArguments> TypeArgumentsOptional => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CTypeReference : RSequence, ICTypeReference
        {
            public CTypeReference(params RNode[] children) : base(children) {}

            public ICTypeName TypeName => Get<ICTypeName>(0);
            public ROptional<CTypeArguments> TypeArgumentsOptional => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CSelfReferenceSelector : RSequence, ICSelfReferenceSelector
        {
            public CSelfReferenceSelector(params RNode[] children) : base(children) {}

            public CSelfReference SelfReference => Get<CSelfReference>(0);
            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(1);
        }

        public partial class CSelfReference : RLiteral, ICSelfReference
        {
            public CSelfReference(params Node[] children) : base(children) {}
        }

        public partial class CEnumerationExpr : RSequence, ICEnumerationExpr
        {
            public CEnumerationExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICDeclarationOrStatement> DeclarationOrStatementStar => Get<RStar<ICDeclarationOrStatement>>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CTupleExpr : RSequence, ICTupleExpr
        {
            public CTupleExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CStructuralArguments : RSequence, ICStructuralArguments
        {
            public CStructuralArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RStar<ICNamedOrAnonymous> NamedOrAnonymousStar => Get<RStar<ICNamedOrAnonymous>>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CNamedSpecifiedArgument : RSequence, ICNamedSpecifiedArgument
        {
            public CNamedSpecifiedArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
            public RLiteral Literal => Get<RLiteral>(2);
        }

        public partial class CSequencedArguments : RLoop<ICSequencedArgument>, ICSequencedArguments
        {
            public CSequencedArguments(params RNode[] children) : base(children) {}
        }

        public partial class CAnonymousArgument : RSequence, ICAnonymousArgument
        {
            public CAnonymousArgument(params RNode[] children) : base(children) {}

            public ICExpression Expression => Get<ICExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CObjectArgument : RSequence, ICObjectArgument
        {
            public CObjectArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(2);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(3);
            public ICClassBlock ClassBlock => Get<ICClassBlock>(4);
        }

        public partial class CTypedMethodArgument : RSequence, ICTypedMethodArgument
        {
            public CTypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMethodArgumentType MethodArgumentType => Get<ICMethodArgumentType>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class COptionalFunctionSpecifier : RSequence, ICOptionalFunctionSpecifier
        {
            public COptionalFunctionSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CFunctionSpecifier> FunctionSpecifierOptional => Get<ROptional<CFunctionSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CNeededFunctionSpecifier : RSequence, ICNeededFunctionSpecifier
        {
            public CNeededFunctionSpecifier(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CTypedGetterArgument : RSequence, ICTypedGetterArgument
        {
            public CTypedGetterArgument(params RNode[] children) : base(children) {}

            public ICGetterArgumentType GetterArgumentType => Get<ICGetterArgumentType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CInferredMethodArgument : RSequence, ICInferredMethodArgument
        {
            public CInferredMethodArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CInferredGetterArgument : RSequence, ICInferredGetterArgument
        {
            public CInferredGetterArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CUntypedMethodArgument : RSequence, ICUntypedMethodArgument
        {
            public CUntypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(1);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(2);
        }

        public partial class CUntypedGetterArgument : RSequence, ICUntypedGetterArgument
        {
            public CUntypedGetterArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(1);
        }

        public partial class CPositionalArguments : RSequence, ICPositionalArguments
        {
            public CPositionalArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CSpreadArgument : RSequence, ICSpreadArgument
        {
            public CSpreadArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(1);
        }

        public partial class CLetExpr : RSequence, ICLetExpr
        {
            public CLetExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CLetVariableList> LetVariableListOptional => Get<ROptional<CLetVariableList>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(4);
        }

        public partial class CLetVariableList : RLoop<CLetVariable>, ICLetVariableList
        {
            public CLetVariableList(params RNode[] children) : base(children) {}
        }

        public partial class CLetVariable : RSequence, ICLetVariable
        {
            public CLetVariable(params RNode[] children) : base(children) {}

            public ICPattern Pattern => Get<ICPattern>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CSwitchExpr : RSequence, ICSwitchExpr
        {
            public CSwitchExpr(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public CCaseExpressions CaseExpressions => Get<CCaseExpressions>(1);
        }

        public partial class CCaseExpressions : RSequence, ICCaseExpressions
        {
            public CCaseExpressions(params RNode[] children) : base(children) {}

            public RPlus<CCaseExpression> CaseExpressionPlus => Get<RPlus<CCaseExpression>>(0);
            public ROptional<CElseExpression> ElseExpressionOptional => Get<ROptional<CElseExpression>>(1);
        }

        public partial class CCaseExpression : RSequence, ICCaseExpression
        {
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
            public CIfExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public CThenExpression ThenExpression => Get<CThenExpression>(2);
            public CElseExpression ElseExpression => Get<CElseExpression>(3);
        }

        public partial class CElseExpression : RSequence, ICElseExpression
        {
            public CElseExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CThenExpression : RSequence, ICThenExpression
        {
            public CThenExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CFunctionExpr : RSequence, ICFunctionExpr
        {
            public CFunctionExpr(params RNode[] children) : base(children) {}

            public ROptional<ICFunctionExpressionType> FunctionExpressionTypeOptional => Get<ROptional<ICFunctionExpressionType>>(0);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(1);
            public ROptional<CFunctionParameters> FunctionParametersOptional => Get<ROptional<CFunctionParameters>>(2);
            public ICFunctionDefinition FunctionDefinition => Get<ICFunctionDefinition>(3);
        }

        public partial class CFunctionExpressionType : RLiteral, ICFunctionExpressionType
        {
            public CFunctionExpressionType(params Node[] children) : base(children) {}
        }

        public partial class CFunctionParameters : RSequence, ICFunctionParameters
        {
            public CFunctionParameters(params RNode[] children) : base(children) {}

            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(0);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(1);
        }

        public partial class CForComprehensionClause : RSequence, ICForComprehensionClause
        {
            public CForComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICComprehensionClause ComprehensionClause => Get<ICComprehensionClause>(4);
        }

        public partial class CIfComprehensionClause : RSequence, ICIfComprehensionClause
        {
            public CIfComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICComprehensionClause ComprehensionClause => Get<ICComprehensionClause>(2);
        }

        public partial class CAssignmentExpr : RSequence, ICAssignmentExpr
        {
            public CAssignmentExpr(params RNode[] children) : base(children) {}

            public ICThenElseExpression ThenElseExpression => Get<ICThenElseExpression>(0);
            public CAssignmentOperator AssignmentOperator => Get<CAssignmentOperator>(1);
            public ICExpression Expression => Get<ICExpression>(2);
        }

        public partial class CAssignmentOperator : RLiteral, ICAssignmentOperator
        {
            public CAssignmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CThenElseExpr : RSequence, ICThenElseExpr
        {
            public CThenElseExpr(params RNode[] children) : base(children) {}

            public ICThenElseExpression ThenElseExpression => Get<ICThenElseExpression>(0);
            public CThenElseOperator ThenElseOperator => Get<CThenElseOperator>(1);
            public ICDisjunctionExpression DisjunctionExpression => Get<ICDisjunctionExpression>(2);
        }

        public partial class CThenElseOperator : RLiteral, ICThenElseOperator
        {
            public CThenElseOperator(params Node[] children) : base(children) {}
        }

        public partial class CDisjunctionExpr : RSequence, ICDisjunctionExpr
        {
            public CDisjunctionExpr(params RNode[] children) : base(children) {}

            public ICDisjunctionExpression DisjunctionExpression => Get<ICDisjunctionExpression>(0);
            public CDisjunctionOperator DisjunctionOperator => Get<CDisjunctionOperator>(1);
            public ICConjunctionExpression ConjunctionExpression => Get<ICConjunctionExpression>(2);
        }

        public partial class CDisjunctionOperator : RLiteral, ICDisjunctionOperator
        {
            public CDisjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CConjunctionExpr : RSequence, ICConjunctionExpr
        {
            public CConjunctionExpr(params RNode[] children) : base(children) {}

            public ICConjunctionExpression ConjunctionExpression => Get<ICConjunctionExpression>(0);
            public CConjunctionOperator ConjunctionOperator => Get<CConjunctionOperator>(1);
            public ICLogicalNegationExpression LogicalNegationExpression => Get<ICLogicalNegationExpression>(2);
        }

        public partial class CConjunctionOperator : RLiteral, ICConjunctionOperator
        {
            public CConjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CLogicalNegationExpr : RSequence, ICLogicalNegationExpr
        {
            public CLogicalNegationExpr(params RNode[] children) : base(children) {}

            public CNotOperator NotOperator => Get<CNotOperator>(0);
            public ICLogicalNegationExpression LogicalNegationExpression => Get<ICLogicalNegationExpression>(1);
        }

        public partial class CNotOperator : RLiteral, ICNotOperator
        {
            public CNotOperator(params Node[] children) : base(children) {}
        }

        public partial class CEqualityExpr : RSequence, ICEqualityExpr
        {
            public CEqualityExpr(params RNode[] children) : base(children) {}

            public ICComparisonExpression ComparisonExpression => Get<ICComparisonExpression>(0);
            public CEqualityOperator EqualityOperator => Get<CEqualityOperator>(1);
            public ICComparisonExpression ComparisonExpression2 => Get<ICComparisonExpression>(2);
        }

        public partial class CEqualityOperator : RLiteral, ICEqualityOperator
        {
            public CEqualityOperator(params Node[] children) : base(children) {}
        }

        public partial class CComparisonExpr : RSequence, ICComparisonExpr
        {
            public CComparisonExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CComparisonOperator ComparisonOperator => Get<CComparisonOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CLargerExpr : RSequence, ICLargerExpr
        {
            public CLargerExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CSmallerExpr : RSequence, ICSmallerExpr
        {
            public CSmallerExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
        }

        public partial class CLargerBoundsExpr : RSequence, ICLargerBoundsExpr
        {
            public CLargerBoundsExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
            public CLargerOperator LargerOperator2 => Get<CLargerOperator>(3);
            public ICExistsNonemptyExpression ExistsNonemptyExpression3 => Get<ICExistsNonemptyExpression>(4);
        }

        public partial class CSmallerBoundsExpr : RSequence, ICSmallerBoundsExpr
        {
            public CSmallerBoundsExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public ICExistsNonemptyExpression ExistsNonemptyExpression2 => Get<ICExistsNonemptyExpression>(2);
            public CSmallerOperator SmallerOperator2 => Get<CSmallerOperator>(3);
            public ICExistsNonemptyExpression ExistsNonemptyExpression3 => Get<ICExistsNonemptyExpression>(4);
        }

        public partial class CTypecheckExpr : RSequence, ICTypecheckExpr
        {
            public CTypecheckExpr(params RNode[] children) : base(children) {}

            public ICExistsNonemptyExpression ExistsNonemptyExpression => Get<ICExistsNonemptyExpression>(0);
            public CTypeOperator TypeOperator => Get<CTypeOperator>(1);
            public ICType Type => Get<ICType>(2);
        }

        public partial class CComparisonOperator : RLiteral, ICComparisonOperator
        {
            public CComparisonOperator(params Node[] children) : base(children) {}
        }

        public partial class CSmallerOperator : RLiteral, ICSmallerOperator
        {
            public CSmallerOperator(params Node[] children) : base(children) {}
        }

        public partial class CLargerOperator : RLiteral, ICLargerOperator
        {
            public CLargerOperator(params Node[] children) : base(children) {}
        }

        public partial class CTypeOperator : RLiteral, ICTypeOperator
        {
            public CTypeOperator(params Node[] children) : base(children) {}
        }

        public partial class CExistsExpr : RSequence, ICExistsExpr
        {
            public CExistsExpr(params RNode[] children) : base(children) {}

            public ICEntryRangeExpression EntryRangeExpression => Get<ICEntryRangeExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CNonemptyExpr : RSequence, ICNonemptyExpr
        {
            public CNonemptyExpr(params RNode[] children) : base(children) {}

            public ICEntryRangeExpression EntryRangeExpression => Get<ICEntryRangeExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CRangeExpr : RSequence, ICRangeExpr
        {
            public CRangeExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CRangeOperator RangeOperator => Get<CRangeOperator>(1);
            public ICAdditiveExpression AdditiveExpression2 => Get<ICAdditiveExpression>(2);
        }

        public partial class CEntryExpr : RSequence, ICEntryExpr
        {
            public CEntryExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CEntryOperator EntryOperator => Get<CEntryOperator>(1);
            public ICAdditiveExpression AdditiveExpression2 => Get<ICAdditiveExpression>(2);
        }

        public partial class CRangeOperator : RLiteral, ICRangeOperator
        {
            public CRangeOperator(params Node[] children) : base(children) {}
        }

        public partial class CEntryOperator : RLiteral, ICEntryOperator
        {
            public CEntryOperator(params Node[] children) : base(children) {}
        }

        public partial class CAdditiveExpr : RSequence, ICAdditiveExpr
        {
            public CAdditiveExpr(params RNode[] children) : base(children) {}

            public ICAdditiveExpression AdditiveExpression => Get<ICAdditiveExpression>(0);
            public CAdditiveOperator AdditiveOperator => Get<CAdditiveOperator>(1);
            public ICScaleExpression ScaleExpression => Get<ICScaleExpression>(2);
        }

        public partial class CAdditiveOperator : RLiteral, ICAdditiveOperator
        {
            public CAdditiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CScaleExpr : RSequence, ICScaleExpr
        {
            public CScaleExpr(params RNode[] children) : base(children) {}

            public ICMultiplicativeExpression MultiplicativeExpression => Get<ICMultiplicativeExpression>(0);
            public CScaleOperator ScaleOperator => Get<CScaleOperator>(1);
            public ICScaleExpression ScaleExpression => Get<ICScaleExpression>(2);
        }

        public partial class CScaleOperator : RLiteral, ICScaleOperator
        {
            public CScaleOperator(params Node[] children) : base(children) {}
        }

        public partial class CMultiplicativeExpr : RSequence, ICMultiplicativeExpr
        {
            public CMultiplicativeExpr(params RNode[] children) : base(children) {}

            public ICMultiplicativeExpression MultiplicativeExpression => Get<ICMultiplicativeExpression>(0);
            public CMultiplicativeOperator MultiplicativeOperator => Get<CMultiplicativeOperator>(1);
            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(2);
        }

        public partial class CMultiplicativeOperator : RLiteral, ICMultiplicativeOperator
        {
            public CMultiplicativeOperator(params Node[] children) : base(children) {}
        }

        public partial class CUnionExpr : RSequence, ICUnionExpr
        {
            public CUnionExpr(params RNode[] children) : base(children) {}

            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(0);
            public CUnionOperator UnionOperator => Get<CUnionOperator>(1);
            public ICExclusiveExpression ExclusiveExpression => Get<ICExclusiveExpression>(2);
        }

        public partial class CUnionOperator : RLiteral, ICUnionOperator
        {
            public CUnionOperator(params Node[] children) : base(children) {}
        }

        public partial class CExclusiveExpr : RSequence, ICExclusiveExpr
        {
            public CExclusiveExpr(params RNode[] children) : base(children) {}

            public ICExclusiveExpression ExclusiveExpression => Get<ICExclusiveExpression>(0);
            public CExclusiveOperator ExclusiveOperator => Get<CExclusiveOperator>(1);
            public ICIntersectionExpression IntersectionExpression => Get<ICIntersectionExpression>(2);
        }

        public partial class CExclusiveOperator : RLiteral, ICExclusiveOperator
        {
            public CExclusiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CIntersectionExpr : RSequence, ICIntersectionExpr
        {
            public CIntersectionExpr(params RNode[] children) : base(children) {}

            public ICIntersectionExpression IntersectionExpression => Get<ICIntersectionExpression>(0);
            public CIntersectionOperator IntersectionOperator => Get<CIntersectionOperator>(1);
            public ICNegationOrComplementExpression NegationOrComplementExpression => Get<ICNegationOrComplementExpression>(2);
        }

        public partial class CIntersectionOperator : RLiteral, ICIntersectionOperator
        {
            public CIntersectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CNegationOrComplementExpr : RSequence, ICNegationOrComplementExpr
        {
            public CNegationOrComplementExpr(params RNode[] children) : base(children) {}

            public ICUnaryMinusOrComplementOperator UnaryMinusOrComplementOperator => Get<ICUnaryMinusOrComplementOperator>(0);
            public ICNegationOrComplementExpression NegationOrComplementExpression => Get<ICNegationOrComplementExpression>(1);
        }

        public partial class CNegateOperator : RSequence, ICNegateOperator
        {
            public CNegateOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RNot<RLiteral> Literal2Not => Get<RNot<RLiteral>>(1);
        }

        public partial class CNeutralOperator : RSequence, ICNeutralOperator
        {
            public CNeutralOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RNot<RLiteral> Literal2Not => Get<RNot<RLiteral>>(1);
        }

        public partial class CComplementOperator : RLiteral, ICComplementOperator
        {
            public CComplementOperator(params Node[] children) : base(children) {}
        }

        public partial class CPrefixExpr : RSequence, ICPrefixExpr
        {
            public CPrefixExpr(params RNode[] children) : base(children) {}

            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(0);
            public ICPrefixExpression PrefixExpression => Get<ICPrefixExpression>(1);
        }

        public partial class CPostfixExpr : RSequence, ICPostfixExpr
        {
            public CPostfixExpr(params RNode[] children) : base(children) {}

            public ICPostfixExpression PostfixExpression => Get<ICPostfixExpression>(0);
            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(1);
        }

        public partial class CIncrementOperator : RLiteral, ICIncrementOperator
        {
            public CIncrementOperator(params Node[] children) : base(children) {}
        }

        public partial class CSelectionExpr : RSequence, ICSelectionExpr
        {
            public CSelectionExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public CQualifiedReference QualifiedReference => Get<CQualifiedReference>(1);
        }

        public partial class CQualifiedReference : RSequence, ICQualifiedReference
        {
            public CQualifiedReference(params RNode[] children) : base(children) {}

            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(0);
            public ICBaseReference BaseReference => Get<ICBaseReference>(1);
        }

        public partial class CMemberSelectionOperator : RLiteral, ICMemberSelectionOperator
        {
            public CMemberSelectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CIndexedExpr : RSequence, ICIndexedExpr
        {
            public CIndexedExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndex Index => Get<ICIndex>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CUpperSpanned : RSequence, ICUpperSpanned
        {
            public CUpperSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CLowerSpanned : RSequence, ICLowerSpanned
        {
            public CLowerSpanned(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(1);
        }

        public partial class CSpanned : RSequence, ICSpanned
        {
            public CSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndexExpression IndexExpression2 => Get<ICIndexExpression>(2);
        }

        public partial class CMeasured : RSequence, ICMeasured
        {
            public CMeasured(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIndexExpression IndexExpression2 => Get<ICIndexExpression>(2);
        }

        public partial class CCallExpr : RSequence, ICCallExpr
        {
            public CCallExpr(params RNode[] children) : base(children) {}

            public ICPrimary Primary => Get<ICPrimary>(0);
            public ICArguments Arguments => Get<ICArguments>(1);
        }

        public partial class CStringInterpolation : RSequence, ICStringInterpolation
        {
            public CStringInterpolation(params RNode[] children) : base(children) {}

            public CStringStart StringStart => Get<CStringStart>(0);
            public ICExpression Expression => Get<ICExpression>(1);
            public RStar<CInterpolationPart> InterpolationPartStar => Get<RStar<CInterpolationPart>>(2);
            public CStringEnd StringEnd => Get<CStringEnd>(3);
        }

        public partial class CInterpolationPart : RSequence, ICInterpolationPart
        {
            public CInterpolationPart(params RNode[] children) : base(children) {}

            public CStringMid StringMid => Get<CStringMid>(0);
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CObjectExpr : RSequence, ICObjectExpr
        {
            public CObjectExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(1);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(2);
            public ICClassBlock ClassBlock => Get<ICClassBlock>(3);
        }

        public partial class CGroupedExpr : RSequence, ICGroupedExpr
        {
            public CGroupedExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICExpression Expression => Get<ICExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeArguments : RSequence, ICTypeArguments
        {
            public CTypeArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CTypeArgumentList> TypeArgumentListOptional => Get<ROptional<CTypeArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CTypeArgumentList : RLoop<CVariancedType>, ICTypeArgumentList
        {
            public CTypeArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CVariancedType : RSequence, ICVariancedType
        {
            public CVariancedType(params RNode[] children) : base(children) {}

            public ROptional<ICVariance> VarianceOptional => Get<ROptional<ICVariance>>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CDefaultedTypeList : RLoop<ICDefaultedType>, ICDefaultedTypeList
        {
            public CDefaultedTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CDefaultedTypeCore : RSequence, ICDefaultedTypeCore
        {
            public CDefaultedTypeCore(params RNode[] children) : base(children) {}

            public ICType Type => Get<ICType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CVariadicUnionType : RSequence, ICVariadicUnionType
        {
            public CVariadicUnionType(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
        }

        public partial class CVariadicOperator : RLiteral, ICVariadicOperator
        {
            public CVariadicOperator(params Node[] children) : base(children) {}
        }

        public partial class CSpreadType : RSequence, ICSpreadType
        {
            public CSpreadType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICUnionType UnionType => Get<ICUnionType>(1);
        }

        public partial class CEntryType : RSequence, ICEntryType
        {
            public CEntryType(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICUnionType UnionType2 => Get<ICUnionType>(2);
        }

        public partial class CUnionTypeCore : RSequence, ICUnionTypeCore
        {
            public CUnionTypeCore(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(2);
        }

        public partial class CIntersectionTypeCore : RSequence, ICIntersectionTypeCore
        {
            public CIntersectionTypeCore(params RNode[] children) : base(children) {}

            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(2);
        }

        public partial class CNullableType : RSequence, ICNullableType
        {
            public CNullableType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
        }

        public partial class CArrayType : RSequence, ICArrayType
        {
            public CArrayType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ROptional<CLiteralNatural> LiteralNaturalOptional => Get<ROptional<CLiteralNatural>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CFunctionType : RSequence, ICFunctionType
        {
            public CFunctionType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3);
        }

        public partial class CTupleType : RSequence, ICTupleType
        {
            public CTupleType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CIterableType : RSequence, ICIterableType
        {
            public CIterableType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<ICVariadicType> VariadicTypeOptional => Get<ROptional<ICVariadicType>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CGroupedType : RSequence, ICGroupedType
        {
            public CGroupedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CQualifiedType : RSequence, ICQualifiedType
        {
            public CQualifiedType(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public CTypePath TypePath => Get<CTypePath>(1);
        }

        public partial class CAnnotations : RSequence, ICAnnotations
        {
            public CAnnotations(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteralOptional => Get<ROptional<ICStringLiteral>>(0);
            public RStar<CAnnotation> AnnotationStar => Get<RStar<CAnnotation>>(1);
        }

        public partial class CAnnotation : RSequence, ICAnnotation
        {
            public CAnnotation(params RNode[] children) : base(children) {}

            public ICAnnotationName AnnotationName => Get<ICAnnotationName>(0);
            public ROptional<ICArguments> ArgumentsOptional => Get<ROptional<ICArguments>>(1);
        }

        public partial class CConditions : RSequence, ICConditions
        {
            public CConditions(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CConditionList> ConditionListOptional => Get<ROptional<CConditionList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CConditionList : RLoop<ICCondition>, ICConditionList
        {
            public CConditionList(params RNode[] children) : base(children) {}
        }

        public partial class CExistsCondition : RSequence, ICExistsCondition
        {
            public CExistsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CNonemptyCondition : RSequence, ICNonemptyCondition
        {
            public CNonemptyCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CIsCondition : RSequence, ICIsCondition
        {
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICType Type => Get<ICType>(2);
            public CIsConditionVariable IsConditionVariable => Get<CIsConditionVariable>(3);
        }

        public partial class CIsConditionVariable : RSequence, ICIsConditionVariable
        {
            public CIsConditionVariable(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifierOptional => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CSatisfiesCondition : RSequence, ICSatisfiesCondition
        {
            public CSatisfiesCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
        }

        public partial class CIfElseStatement : RSequence, ICIfElseStatement
        {
            public CIfElseStatement(params RNode[] children) : base(children) {}

            public CIfBlock IfBlock => Get<CIfBlock>(0);
            public ROptional<CElseBlock> ElseBlockOptional => Get<ROptional<CElseBlock>>(1);
        }

        public partial class CIfBlock : RSequence, ICIfBlock
        {
            public CIfBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CElseBlock : RSequence, ICElseBlock
        {
            public CElseBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICElseBlockNext ElseBlockNext => Get<ICElseBlockNext>(1);
        }

        public partial class CSwitchStatement : RSequence, ICSwitchStatement
        {
            public CSwitchStatement(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public RPlus<CCaseBlock> CaseBlockPlus => Get<RPlus<CCaseBlock>>(1);
            public ROptional<CElseBlock> ElseBlockOptional => Get<ROptional<CElseBlock>>(2);
        }

        public partial class CSwitchHeader : RSequence, ICSwitchHeader
        {
            public CSwitchHeader(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ICSwitched Switched => Get<ICSwitched>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
        }

        public partial class CCaseBlock : RSequence, ICCaseBlock
        {
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
            public CIsCaseCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CSatisfiesCaseCondition : RSequence, ICSatisfiesCaseCondition
        {
            public CSatisfiesCaseCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CValueCaseList : RLoop<ICValueCase>, ICValueCaseList
        {
            public CValueCaseList(params RNode[] children) : base(children) {}
        }

        public partial class CValueCaseSeparator : RLiteral, ICValueCaseSeparator
        {
            public CValueCaseSeparator(params Node[] children) : base(children) {}
        }

        public partial class CForElseStatement : RSequence, ICForElseStatement
        {
            public CForElseStatement(params RNode[] children) : base(children) {}

            public CForBlock ForBlock => Get<CForBlock>(0);
            public ROptional<CFailBlock> FailBlockOptional => Get<ROptional<CFailBlock>>(1);
        }

        public partial class CForBlock : RSequence, ICForBlock
        {
            public CForBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public RLiteral Literal2 => Get<RLiteral>(1);
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3);
            public ICBlock Block => Get<ICBlock>(4);
        }

        public partial class CFailBlock : RSequence, ICFailBlock
        {
            public CFailBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICBlock Block => Get<ICBlock>(1);
        }

        public partial class CForIterator : RSequence, ICForIterator
        {
            public CForIterator(params RNode[] children) : base(children) {}

            public ICForVariable ForVariable => Get<ICForVariable>(0);
            public ROptional<CContainment> ContainmentOptional => Get<ROptional<CContainment>>(1);
        }

        public partial class CContainment : RSequence, ICContainment
        {
            public CContainment(params RNode[] children) : base(children) {}

            public CContainmentOperator ContainmentOperator => Get<CContainmentOperator>(0);
            public ICOperatorExpression OperatorExpression => Get<ICOperatorExpression>(1);
        }

        public partial class CContainmentOperator : RLiteral, ICContainmentOperator
        {
            public CContainmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CWhileStatement : RSequence, ICWhileStatement
        {
            public CWhileStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CTryStatement : RSequence, ICTryStatement
        {
            public CTryStatement(params RNode[] children) : base(children) {}

            public CTryBlock TryBlock => Get<CTryBlock>(0);
            public RStar<CCatchBlock> CatchBlockStar => Get<RStar<CCatchBlock>>(1);
            public ROptional<CFinallyBlock> FinallyBlockOptional => Get<ROptional<CFinallyBlock>>(2);
        }

        public partial class CTryBlock : RSequence, ICTryBlock
        {
            public CTryBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CResources> ResourcesOptional => Get<ROptional<CResources>>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CCatchBlock : RSequence, ICCatchBlock
        {
            public CCatchBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CCatchVariable CatchVariable => Get<CCatchVariable>(1);
            public ICBlock Block => Get<ICBlock>(2);
        }

        public partial class CCatchVariable : RSequence, ICCatchVariable
        {
            public CCatchVariable(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CVariable> VariableOptional => Get<ROptional<CVariable>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CFinallyBlock : RSequence, ICFinallyBlock
        {
            public CFinallyBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICBlock Block => Get<ICBlock>(1);
        }

        public partial class CResources : RSequence, ICResources
        {
            public CResources(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CResourceList> ResourceListOptional => Get<ROptional<CResourceList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CResourceList : RLoop<ICResource>, ICResourceList
        {
            public CResourceList(params RNode[] children) : base(children) {}
        }

        public partial class CSpecifiedVariable : RSequence, ICSpecifiedVariable
        {
            public CSpecifiedVariable(params RNode[] children) : base(children) {}

            public CVariable Variable => Get<CVariable>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CVariable : RSequence, ICVariable
        {
            public CVariable(params RNode[] children) : base(children) {}

            public ROptional<ICVariableType> VariableTypeOptional => Get<ROptional<ICVariableType>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public RStar<CParameters> ParametersStar => Get<RStar<CParameters>>(2);
        }

        public partial class CModelReference : RSequence, ICModelReference
        {
            public CModelReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICModelExpression ModelExpression => Get<ICModelExpression>(1);
        }

        public partial class CMetaLiteral : RSequence, ICMetaLiteral
        {
            public CMetaLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ICMetaExpression MetaExpression => Get<ICMetaExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2);
        }

        public partial class CPackageQualifiedMemberReference : RSequence, ICPackageQualifiedMemberReference
        {
            public CPackageQualifiedMemberReference(params RNode[] children) : base(children) {}

            public CPackageQualifier PackageQualifier => Get<CPackageQualifier>(0);
            public CMemberReference MemberReference => Get<CMemberReference>(1);
        }

        public partial class CTypeQualifiedMemberReference : RSequence, ICTypeQualifiedMemberReference
        {
            public CTypeQualifiedMemberReference(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CModuleLiteral : RSequence, ICModuleLiteral
        {
            public CModuleLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CPackageLiteral : RSequence, ICPackageLiteral
        {
            public CPackageLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CClassLiteral : RSequence, ICClassLiteral
        {
            public CClassLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CInterfaceLiteral : RSequence, ICInterfaceLiteral
        {
            public CInterfaceLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CAliasLiteral : RSequence, ICAliasLiteral
        {
            public CAliasLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CTypeParameterLiteral : RSequence, ICTypeParameterLiteral
        {
            public CTypeParameterLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CNewLiteral : RSequence, ICNewLiteral
        {
            public CNewLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteral : RSequence, ICValueLiteral
        {
            public CValueLiteral(params RNode[] children) : base(children) {}

            public CValueLiteralIntro ValueLiteralIntro => Get<CValueLiteralIntro>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteralIntro : RLiteral, ICValueLiteralIntro
        {
            public CValueLiteralIntro(params Node[] children) : base(children) {}
        }

        public partial class CFunctionLiteral : RSequence, ICFunctionLiteral
        {
            public CFunctionLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CReferencePath : RSequence, ICReferencePath
        {
            public CReferencePath(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public CReferencePathElementList ReferencePathElementList => Get<CReferencePathElementList>(1);
        }

        public partial class CReferencePathElementList : RLoop<ICReferencePathElement>, ICReferencePathElementList
        {
            public CReferencePathElementList(params RNode[] children) : base(children) {}
        }

        public partial class CKwVoid : RLiteral, ICKwVoid
        {
            public CKwVoid(params Node[] children) : base(children) {}
        }

        public partial class CKwFunction : RLiteral, ICKwFunction
        {
            public CKwFunction(params Node[] children) : base(children) {}
        }

        public partial class CKwValue : RLiteral, ICKwValue
        {
            public CKwValue(params Node[] children) : base(children) {}
        }

        public partial class CLiteralFloat : RToken, ICLiteralFloat
        {
            public CLiteralFloat(params Node[] children) : base(children) {}
        }

        public partial class CLiteralNatural : RToken, ICLiteralNatural
        {
            public CLiteralNatural(params Node[] children) : base(children) {}
        }

        public partial class CLiteralChar : RToken, ICLiteralChar
        {
            public CLiteralChar(params Node[] children) : base(children) {}
        }

        public partial class CStringStart : RToken, ICStringStart
        {
            public CStringStart(params Node[] children) : base(children) {}
        }

        public partial class CStringMid : RToken, ICStringMid
        {
            public CStringMid(params Node[] children) : base(children) {}
        }

        public partial class CStringEnd : RToken, ICStringEnd
        {
            public CStringEnd(params Node[] children) : base(children) {}
        }

        public partial class CLiteralString : RToken, ICLiteralString
        {
            public CLiteralString(params Node[] children) : base(children) {}
        }

        public partial class CVerbatimString : RToken, ICVerbatimString
        {
            public CVerbatimString(params Node[] children) : base(children) {}
        }

        public partial class CLowerIdentifier : RToken, ICLowerIdentifier
        {
            public CLowerIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CUpperIdentifier : RToken, ICUpperIdentifier
        {
            public CUpperIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CIdentifier : RToken, ICIdentifier
        {
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

            protected virtual void Visit(CSuperQualifier element)
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

            protected virtual void Visit(CEnumeratedObject element)
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

            protected virtual void Visit(CNamedSpecifiedArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSequencedArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAnonymousArgument element)
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

            protected virtual void Visit(CQualifiedType element)
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
