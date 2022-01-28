// <generated from="D:\\Six\\Six.Ceylon\\Ceylon.six" at="28.01.2022 07:48:39" />

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
                /*   4 PlainRuleOp      */ __Matchers[4] = _codeUnit = new PlainRule(this, 4, "code-unit") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _namespace = new PlainRule(this, 5, "namespace") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _namespacePath = new PlainRule(this, 6, "namespace-path") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _imports = new PlainRule(this, 7, "imports") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _moduleDescriptor = new PlainRule(this, 8, "module-descriptor") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _moduleSpecifier = new PlainRule(this, 9, "module-specifier") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _repository = new PlainRule(this, 10, "repository") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _module = new PlainRule(this, 11, "module") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _artifactAndClassifier = new PlainRule(this, 12, "artifact-and-classifier") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _artifact = new PlainRule(this, 13, "artifact") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _classifier = new PlainRule(this, 14, "classifier") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _version = new PlainRule(this, 15, "version") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _moduleName = new PlainRule(this, 16, "module-name") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _moduleBody = new PlainRule(this, 17, "module-body") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _moduleBodyElement = new PlainRule(this, 18, "module-body-element") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _moduleImport = new PlainRule(this, 19, "module-import") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _packageDescriptor = new PlainRule(this, 20, "package-descriptor") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _importDeclaration = new PlainRule(this, 21, "import-declaration") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _importElements = new PlainRule(this, 22, "import-elements") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _importElementList = new PlainRule(this, 23, "import-element-list") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _importElement = new PlainRule(this, 24, "import-element") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _importNamed = new PlainRule(this, 25, "import-named") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _importName = new PlainRule(this, 26, "import-name") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _importNameSpecifier = new PlainRule(this, 27, "import-name-specifier") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _importWildcard = new PlainRule(this, 28, "import-wildcard") { Creator = node => new CImportWildcard(node) };
                /*  29 PlainRuleOp      */ __Matchers[29] = _packageName = new PlainRule(this, 29, "package-name") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _packagePath = new PlainRule(this, 30, "package-path") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _memberName = new PlainRule(this, 31, "member-name") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _typeName = new PlainRule(this, 32, "type-name") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _pattern = new PlainRule(this, 33, "pattern") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _variableOrTuplePattern = new PlainRule(this, 34, "variable-or-tuple-pattern") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _tupleOrEntryPattern = new PlainRule(this, 35, "tuple-or-entry-pattern") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _entryPattern = new PlainRule(this, 36, "entry-pattern") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _tuplePattern = new PlainRule(this, 37, "tuple-pattern") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _variadicPatternList = new PlainRule(this, 38, "variadic-pattern-list") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _variadicPattern = new PlainRule(this, 39, "variadic-pattern") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _variablePattern = new PlainRule(this, 40, "variable-pattern") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _variadicVariable = new PlainRule(this, 41, "variadic-variable") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _letStatement = new PlainRule(this, 42, "let-statement") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _letVariableList = new PlainRule(this, 43, "let-variable-list") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _letVariable = new PlainRule(this, 44, "let-variable") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _delegatedConstructor = new PlainRule(this, 45, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _assertionStatement = new PlainRule(this, 46, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _assertionMessage = new PlainRule(this, 47, "assertion-message") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _block = new PlainRule(this, 48, "block") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _extendedType = new PlainRule(this, 49, "extended-type") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _classSpecifier = new PlainRule(this, 50, "class-specifier") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _classInstatiation = new PlainRule(this, 51, "class-instatiation") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _qualifiedClass = new PlainRule(this, 52, "qualified-class") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _packageQualifiedClass = new PlainRule(this, 53, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _superQualifiedClass = new PlainRule(this, 54, "super-qualified-class") { Builder = nodes => nodes[0] };
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
                /*  81 PlainRuleOp      */ __Matchers[81] = _declarations = new PlainRule(this, 81, "declarations") { Builder = nodes => nodes[0] };
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
                /* 102 PlainRuleOp      */ __Matchers[102] = _statements = new PlainRule(this, 102, "statements") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _statement = new PlainRule(this, 103, "statement") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _declarationStatement = new PlainRule(this, 104, "declaration-statement") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _unclosedStatement = new PlainRule(this, 105, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _openStatement = new PlainRule(this, 106, "open-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _specificationStatement = new PlainRule(this, 107, "specification-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _expressionStatement = new PlainRule(this, 108, "expression-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _directiveStatement = new PlainRule(this, 109, "directive-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _returnStatement = new PlainRule(this, 110, "return-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _throwStatement = new PlainRule(this, 111, "throw-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _breakStatement = new PlainRule(this, 112, "break-statement") { Creator = node => new CBreakStatement(node) };
                /* 113 PlainRuleOp      */ __Matchers[113] = _continueStatement = new PlainRule(this, 113, "continue-statement") { Creator = node => new CContinueStatement(node) };
                /* 114 PlainRuleOp      */ __Matchers[114] = _typeSpecifier = new PlainRule(this, 114, "type-specifier") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _valueSpecifier = new PlainRule(this, 115, "value-specifier") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _functionSpecifier = new PlainRule(this, 116, "function-specifier") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _anySpecifier = new PlainRule(this, 117, "any-specifier") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _baseReferenceOrParameterized = new PlainRule(this, 118, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _baseReference = new PlainRule(this, 119, "base-reference") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _parametrizedMember = new PlainRule(this, 120, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _selfParametrizedMember = new PlainRule(this, 121, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _memberReference = new PlainRule(this, 122, "member-reference") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _typeReference = new PlainRule(this, 123, "type-reference") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _selfReferenceSelector = new PlainRule(this, 124, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _selfReference = new PlainRule(this, 125, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 126 PlainRuleOp      */ __Matchers[126] = _enumerationExpr = new PlainRule(this, 126, "enumeration-expr") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _tupleExpr = new PlainRule(this, 127, "tuple-expr") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _arguments = new PlainRule(this, 128, "arguments") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _patternedArguments = new PlainRule(this, 129, "patterned-arguments") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _positionalArguments = new PlainRule(this, 130, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _structuredArgument = new PlainRule(this, 131, "structured-argument") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _anonymousArgument = new PlainRule(this, 132, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _namedArgument = new PlainRule(this, 133, "named-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _namedSpecifiedArgument = new PlainRule(this, 134, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _sequencedArgumentList = new PlainRule(this, 135, "sequenced-argument-list") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _sequencedArgument = new PlainRule(this, 136, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _namedArgumentDeclaration = new PlainRule(this, 137, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _objectArgument = new PlainRule(this, 138, "object-argument") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _typedMethodArgument = new PlainRule(this, 139, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _methodDefinition = new PlainRule(this, 140, "method-definition") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _optionalFunctionSpecifier = new PlainRule(this, 141, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _requiredFunctionSpecifier = new PlainRule(this, 142, "required-function-specifier") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _methodArgumentType = new PlainRule(this, 143, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _typedGetterArgument = new PlainRule(this, 144, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _getterArgumentType = new PlainRule(this, 145, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _inferredMethodArgument = new PlainRule(this, 146, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _inferredGetterArgument = new PlainRule(this, 147, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _untypedMethodArgument = new PlainRule(this, 148, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _untypedGetterArgument = new PlainRule(this, 149, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _positionalArgument = new PlainRule(this, 150, "positional-argument") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _expressionArgument = new PlainRule(this, 151, "expression-argument") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _spreadArgument = new PlainRule(this, 152, "spread-argument") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _letExpr = new PlainRule(this, 153, "let-expr") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _switchExpr = new PlainRule(this, 154, "switch-expr") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _caseExpressions = new PlainRule(this, 155, "case-expressions") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _caseExpression = new PlainRule(this, 156, "case-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _ifExpr = new PlainRule(this, 157, "if-expr") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _elseExpression = new PlainRule(this, 158, "else-expression") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _thenExpression = new PlainRule(this, 159, "then-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _conditionalExpression = new PlainRule(this, 160, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _functionExpr = new PlainRule(this, 161, "function-expr") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _functionExpressionType = new PlainRule(this, 162, "function-expression-type") { Creator = node => new CFunctionExpressionType(node) };
                /* 163 PlainRuleOp      */ __Matchers[163] = _functionParameters = new PlainRule(this, 163, "function-parameters") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _functionDefinition = new PlainRule(this, 164, "function-definition") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _comprehensionArgument = new PlainRule(this, 165, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _comprehensionClause = new PlainRule(this, 166, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _expressionComprehensionClause = new PlainRule(this, 167, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _forComprehensionClause = new PlainRule(this, 168, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _ifComprehensionClause = new PlainRule(this, 169, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _expression = new PlainRule(this, 170, "expression") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _operatorExpression = new PlainRule(this, 171, "operator-expression") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _assignmentExpression = new PlainRule(this, 172, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _assignmentExpr = new PlainRule(this, 173, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _assignmentOperator = new PlainRule(this, 174, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 175 PlainRuleOp      */ __Matchers[175] = _thenElseExpression = new PlainRule(this, 175, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _thenElseExpr = new PlainRule(this, 176, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _thenElseOperator = new PlainRule(this, 177, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 178 PlainRuleOp      */ __Matchers[178] = _disjunctionExpression = new PlainRule(this, 178, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 179 PlainRuleOp      */ __Matchers[179] = _disjunctionExpr = new PlainRule(this, 179, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 180 PlainRuleOp      */ __Matchers[180] = _disjunctionOperator = new PlainRule(this, 180, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 181 PlainRuleOp      */ __Matchers[181] = _conjunctionExpression = new PlainRule(this, 181, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _conjunctionExpr = new PlainRule(this, 182, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 183 PlainRuleOp      */ __Matchers[183] = _conjunctionOperator = new PlainRule(this, 183, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 184 PlainRuleOp      */ __Matchers[184] = _logicalNegationExpression = new PlainRule(this, 184, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _logicalNegationExpr = new PlainRule(this, 185, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 186 PlainRuleOp      */ __Matchers[186] = _notOperator = new PlainRule(this, 186, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 187 PlainRuleOp      */ __Matchers[187] = _expressionOrMeta = new PlainRule(this, 187, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _equalityExpression = new PlainRule(this, 188, "equality-expression") { Builder = nodes => nodes[0] };
                /* 189 PlainRuleOp      */ __Matchers[189] = _equalityExpr = new PlainRule(this, 189, "equality-expr") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _equalityOperator = new PlainRule(this, 190, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 191 PlainRuleOp      */ __Matchers[191] = _comparisonExpression = new PlainRule(this, 191, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _comparisonExpr = new PlainRule(this, 192, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _largerExpr = new PlainRule(this, 193, "larger-expr") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _smallerExpr = new PlainRule(this, 194, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 195 PlainRuleOp      */ __Matchers[195] = _largerBoundsExpr = new PlainRule(this, 195, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 196 PlainRuleOp      */ __Matchers[196] = _smallerBoundsExpr = new PlainRule(this, 196, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _typecheckExpr = new PlainRule(this, 197, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _comparisonOperator = new PlainRule(this, 198, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 199 PlainRuleOp      */ __Matchers[199] = _smallerOperator = new PlainRule(this, 199, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 200 PlainRuleOp      */ __Matchers[200] = _largerOperator = new PlainRule(this, 200, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 201 PlainRuleOp      */ __Matchers[201] = _typeOperator = new PlainRule(this, 201, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 202 PlainRuleOp      */ __Matchers[202] = _existsNonemptyExpression = new PlainRule(this, 202, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 203 PlainRuleOp      */ __Matchers[203] = _existsExpr = new PlainRule(this, 203, "exists-expr") { Builder = nodes => nodes[0] };
                /* 204 PlainRuleOp      */ __Matchers[204] = _nonemptyExpr = new PlainRule(this, 204, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 205 PlainRuleOp      */ __Matchers[205] = _entryRangeExpression = new PlainRule(this, 205, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 206 PlainRuleOp      */ __Matchers[206] = _rangeExpr = new PlainRule(this, 206, "range-expr") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _entryExpr = new PlainRule(this, 207, "entry-expr") { Builder = nodes => nodes[0] };
                /* 208 PlainRuleOp      */ __Matchers[208] = _rangeOperator = new PlainRule(this, 208, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 209 PlainRuleOp      */ __Matchers[209] = _entryOperator = new PlainRule(this, 209, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 210 PlainRuleOp      */ __Matchers[210] = _additiveExpression = new PlainRule(this, 210, "additive-expression") { Builder = nodes => nodes[0] };
                /* 211 PlainRuleOp      */ __Matchers[211] = _additiveExpr = new PlainRule(this, 211, "additive-expr") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _additiveOperator = new PlainRule(this, 212, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 213 PlainRuleOp      */ __Matchers[213] = _scaleExpression = new PlainRule(this, 213, "scale-expression") { Builder = nodes => nodes[0] };
                /* 214 PlainRuleOp      */ __Matchers[214] = _scaleExpr = new PlainRule(this, 214, "scale-expr") { Builder = nodes => nodes[0] };
                /* 215 PlainRuleOp      */ __Matchers[215] = _scaleOperator = new PlainRule(this, 215, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 216 PlainRuleOp      */ __Matchers[216] = _multiplicativeExpression = new PlainRule(this, 216, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 217 PlainRuleOp      */ __Matchers[217] = _multiplicativeExpr = new PlainRule(this, 217, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 218 PlainRuleOp      */ __Matchers[218] = _multiplicativeOperator = new PlainRule(this, 218, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 219 PlainRuleOp      */ __Matchers[219] = _unionExpression = new PlainRule(this, 219, "union-expression") { Builder = nodes => nodes[0] };
                /* 220 PlainRuleOp      */ __Matchers[220] = _unionExpr = new PlainRule(this, 220, "union-expr") { Builder = nodes => nodes[0] };
                /* 221 PlainRuleOp      */ __Matchers[221] = _unionOperator = new PlainRule(this, 221, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 222 PlainRuleOp      */ __Matchers[222] = _exclusiveExpression = new PlainRule(this, 222, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 223 PlainRuleOp      */ __Matchers[223] = _exclusiveExpr = new PlainRule(this, 223, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 224 PlainRuleOp      */ __Matchers[224] = _exclusiveOperator = new PlainRule(this, 224, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 225 PlainRuleOp      */ __Matchers[225] = _intersectionExpression = new PlainRule(this, 225, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _intersectionExpr = new PlainRule(this, 226, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 227 PlainRuleOp      */ __Matchers[227] = _intersectionOperator = new PlainRule(this, 227, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 228 PlainRuleOp      */ __Matchers[228] = _negationOrComplementExpression = new PlainRule(this, 228, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 229 PlainRuleOp      */ __Matchers[229] = _negationOrComplementExpr = new PlainRule(this, 229, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _unaryMinusOrComplementOperator = new PlainRule(this, 230, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _negateOperator = new PlainRule(this, 231, "negate-operator") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _neutralOperator = new PlainRule(this, 232, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _complementOperator = new PlainRule(this, 233, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 234 PlainRuleOp      */ __Matchers[234] = _prefixExpression = new PlainRule(this, 234, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _prefixExpr = new PlainRule(this, 235, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _postfixExpression = new PlainRule(this, 236, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _postfixExpr = new PlainRule(this, 237, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _incrementOperator = new PlainRule(this, 238, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 239 PlainRuleOp      */ __Matchers[239] = _primary = new PlainRule(this, 239, "primary") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _selectionExpr = new PlainRule(this, 240, "selection-expr") { Builder = nodes => nodes[0] };
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
                /* 297 PlainRuleOp      */ __Matchers[297] = _elseIf = new PlainRule(this, 297, "else-if") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _elseBlock = new PlainRule(this, 298, "else-block") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _switchStatement = new PlainRule(this, 299, "switch-statement") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _switchHeader = new PlainRule(this, 300, "switch-header") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _switched = new PlainRule(this, 301, "switched") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _caseBlock = new PlainRule(this, 302, "case-block") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _caseItem = new PlainRule(this, 303, "case-item") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _isCaseCondition = new PlainRule(this, 304, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _satisfiesCaseCondition = new PlainRule(this, 305, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _matchCaseCondition = new PlainRule(this, 306, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _valueCaseList = new PlainRule(this, 307, "value-case-list") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _valueCaseSeparator = new PlainRule(this, 308, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 309 PlainRuleOp      */ __Matchers[309] = _valueCase = new PlainRule(this, 309, "value-case") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _forElseStatement = new PlainRule(this, 310, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _forBlock = new PlainRule(this, 311, "for-block") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _forIterator = new PlainRule(this, 312, "for-iterator") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _forVariable = new PlainRule(this, 313, "for-variable") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _containment = new PlainRule(this, 314, "containment") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _containmentOperator = new PlainRule(this, 315, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 316 PlainRuleOp      */ __Matchers[316] = _whileStatement = new PlainRule(this, 316, "while-statement") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _tryStatement = new PlainRule(this, 317, "try-statement") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _tryBlock = new PlainRule(this, 318, "try-block") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _catchBlock = new PlainRule(this, 319, "catch-block") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _catchVariable = new PlainRule(this, 320, "catch-variable") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _finallyBlock = new PlainRule(this, 321, "finally-block") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _resources = new PlainRule(this, 322, "resources") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _resourceList = new PlainRule(this, 323, "resource-list") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _resource = new PlainRule(this, 324, "resource") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _specifiedOrExpression = new PlainRule(this, 325, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _specifiedVariable = new PlainRule(this, 326, "specified-variable") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _variable = new PlainRule(this, 327, "variable") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _variableType = new PlainRule(this, 328, "variable-type") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _modelReference = new PlainRule(this, 329, "model-reference") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _metaLiteral = new PlainRule(this, 330, "meta-literal") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _metaExpression = new PlainRule(this, 331, "meta-expression") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _modelExpression = new PlainRule(this, 332, "model-expression") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _memberModelExpression = new PlainRule(this, 333, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _packageQualifiedMemberReference = new PlainRule(this, 334, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _typeQualifiedMemberReference = new PlainRule(this, 335, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _typeModelExpression = new PlainRule(this, 336, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _declarationReference = new PlainRule(this, 337, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _moduleLiteral = new PlainRule(this, 338, "module-literal") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _packageLiteral = new PlainRule(this, 339, "package-literal") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _classLiteral = new PlainRule(this, 340, "class-literal") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _interfaceLiteral = new PlainRule(this, 341, "interface-literal") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _aliasLiteral = new PlainRule(this, 342, "alias-literal") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _typeParameterLiteral = new PlainRule(this, 343, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _newLiteral = new PlainRule(this, 344, "new-literal") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _valueLiteral = new PlainRule(this, 345, "value-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _valueLiteralIntro = new PlainRule(this, 346, "value-literal-intro") { Creator = node => new CValueLiteralIntro(node) };
                /* 347 PlainRuleOp      */ __Matchers[347] = _functionLiteral = new PlainRule(this, 347, "function-literal") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _packageQualifier = new PlainRule(this, 348, "package-qualifier") { Builder = nodes => nodes[0] };
                /* 349 PlainRuleOp      */ __Matchers[349] = _referencePath = new PlainRule(this, 349, "reference-path") { Builder = nodes => nodes[0] };
                /* 350 PlainRuleOp      */ __Matchers[350] = _referencePathElementList = new PlainRule(this, 350, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _referencePathElement = new PlainRule(this, 351, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 352 PlainRuleOp      */ __Matchers[352] = _kwVoid = new PlainRule(this, 352, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 353 PlainRuleOp      */ __Matchers[353] = _kwFunction = new PlainRule(this, 353, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 354 PlainRuleOp      */ __Matchers[354] = _kwValue = new PlainRule(this, 354, "kw-value") { Creator = node => new CKwValue(node) };
                /* 355 DfaRuleOp        */ __Matchers[355] = _literalFloat = new DfaRule(this, 355, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 356 DfaRuleOp        */ __Matchers[356] = _literalNatural = new DfaRule(this, 356, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 357 DfaRuleOp        */ __Matchers[357] = _literalChar = new DfaRule(this, 357, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 358 DfaRuleOp        */ __Matchers[358] = _stringStart = new DfaRule(this, 358, "string-start") { Creator = node => new CStringStart(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _stringMid = new DfaRule(this, 359, "string-mid") { Creator = node => new CStringMid(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _stringEnd = new DfaRule(this, 360, "string-end") { Creator = node => new CStringEnd(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _literalString = new DfaRule(this, 361, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _verbatimString = new DfaRule(this, 362, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _lowerIdentifier = new DfaRule(this, 363, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _upperIdentifier = new DfaRule(this, 364, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _identifier = new DfaRule(this, 365, "identifier") { Creator = node => new CIdentifier(node) };
                /* 366 EofOp            */ __Matchers[366] = new Eof(this, 366, "<eof>") { Creator = node => new REof(node) };
                /* 367 SeqOp            */ __Matchers[367] = new Seq(this, 367, "_367:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 368 AltOp            */ __Matchers[368] = new Alt(this, 368, "alt(>module-descriptor|>package-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 369 SeqOp            */ __Matchers[369] = new Seq(this, 369, "_369:(>imports,>namespace,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 370 StringOp         */ __Matchers[370] = new Keyword(this, 370, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 371 StringOp         */ __Matchers[371] = new String(this, 371, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 372 SeqOp            */ __Matchers[372] = new Seq(this, 372, "_372:(>annotations,'namespace',>namespace-path,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 373 StringOp         */ __Matchers[373] = new String(this, 373, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 374 SeqOp            */ __Matchers[374] = new Seq(this, 374, "_374:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /* 375 StarOp           */ __Matchers[375] = new Star(this, 375, "*(_374:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 376 SeqOp            */ __Matchers[376] = new Seq(this, 376, "_376:(>identifier,*(_374:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /* 377 StarOp           */ __Matchers[377] = new Star(this, 377, "*(>import-declaration)") { Builder = nodes => new CImports(nodes) };
                /* 378 StringOp         */ __Matchers[378] = new Keyword(this, 378, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 379 OptionalOp       */ __Matchers[379] = new Optional(this, 379, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 380 OptionalOp       */ __Matchers[380] = new Optional(this, 380, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 381 SeqOp            */ __Matchers[381] = new Seq(this, 381, "_381:(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 382 StringOp         */ __Matchers[382] = new String(this, 382, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 383 OptionalOp       */ __Matchers[383] = new Optional(this, 383, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 384 SeqOp            */ __Matchers[384] = new Seq(this, 384, "_384:(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 385 AltOp            */ __Matchers[385] = new Alt(this, 385, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 386 OptionalOp       */ __Matchers[386] = new Optional(this, 386, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 387 SeqOp            */ __Matchers[387] = new Seq(this, 387, "_387:(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 388 SeqOp            */ __Matchers[388] = new Seq(this, 388, "_388:(':',>literal-string)") { Builder = nodes => new CArtifact(nodes) };
                /* 389 SeqOp            */ __Matchers[389] = new Seq(this, 389, "_389:(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 390 StringOp         */ __Matchers[390] = new String(this, 390, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 391 StarOp           */ __Matchers[391] = new Star(this, 391, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 392 StringOp         */ __Matchers[392] = new String(this, 392, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 393 SeqOp            */ __Matchers[393] = new Seq(this, 393, "_393:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 394 AltOp            */ __Matchers[394] = new Alt(this, 394, "alt(>inferred-attribute-declaration|>module-import)") { Builder = nodes => nodes[0] };
                /* 395 StringOp         */ __Matchers[395] = new Keyword(this, 395, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 396 SeqOp            */ __Matchers[396] = new Seq(this, 396, "_396:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 397 StringOp         */ __Matchers[397] = new Keyword(this, 397, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 398 SeqOp            */ __Matchers[398] = new Seq(this, 398, "_398:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 399 SeqOp            */ __Matchers[399] = new Seq(this, 399, "_399:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 400 OptionalOp       */ __Matchers[400] = new Optional(this, 400, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_401:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 402 StringOp         */ __Matchers[402] = new String(this, 402, "','", ",") { Creator = node => new RLiteral(node) };
                /* 403 SeqOp            */ __Matchers[403] = new Seq(this, 403, "_403:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 404 StarOp           */ __Matchers[404] = new Star(this, 404, "*(_403:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 405 SeqOp            */ __Matchers[405] = new Seq(this, 405, "_405:(>import-element,*(_403:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 406 AltOp            */ __Matchers[406] = new Alt(this, 406, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 407 OptionalOp       */ __Matchers[407] = new Optional(this, 407, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 408 OptionalOp       */ __Matchers[408] = new Optional(this, 408, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 409 SeqOp            */ __Matchers[409] = new Seq(this, 409, "_409:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 410 StringOp         */ __Matchers[410] = new String(this, 410, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 411 SeqOp            */ __Matchers[411] = new Seq(this, 411, "_411:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 412 StringOp         */ __Matchers[412] = new String(this, 412, "'...'", "...") { Creator = node => new CImportWildcard(node) };
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
                /* 430 SeqOp            */ __Matchers[430] = new Seq(this, 430, "_430:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 431 StringOp         */ __Matchers[431] = new Keyword(this, 431, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 432 StringOp         */ __Matchers[432] = new String(this, 432, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 434 SeqOp            */ __Matchers[434] = new Seq(this, 434, "_434:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 435 SeqOp            */ __Matchers[435] = new Seq(this, 435, "_435:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 436 StarOp           */ __Matchers[436] = new Star(this, 436, "*(_435:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 437 SeqOp            */ __Matchers[437] = new Seq(this, 437, "_437:(>let-variable,*(_435:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 438 SeqOp            */ __Matchers[438] = new Seq(this, 438, "_438:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 439 StringOp         */ __Matchers[439] = new Keyword(this, 439, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 440 SeqOp            */ __Matchers[440] = new Seq(this, 440, "_440:('extends',>class-instatiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 441 OptionalOp       */ __Matchers[441] = new Optional(this, 441, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 442 StringOp         */ __Matchers[442] = new Keyword(this, 442, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_443:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 444 SeqOp            */ __Matchers[444] = new Seq(this, 444, "_444:('{',>imports,>statements,'}')") { Builder = nodes => new CBlock(nodes) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_445:('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 446 StringOp         */ __Matchers[446] = new String(this, 446, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_447:('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 448 OptionalOp       */ __Matchers[448] = new Optional(this, 448, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 449 SeqOp            */ __Matchers[449] = new Seq(this, 449, "_449:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 450 AltOp            */ __Matchers[450] = new Alt(this, 450, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 451 SeqOp            */ __Matchers[451] = new Seq(this, 451, "_451:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 452 StringOp         */ __Matchers[452] = new Keyword(this, 452, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_453:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
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
                /* 509 StarOp           */ __Matchers[509] = new Star(this, 509, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 510 AltOp            */ __Matchers[510] = new Alt(this, 510, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 511 StringOp         */ __Matchers[511] = new Keyword(this, 511, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 512 OptionalOp       */ __Matchers[512] = new Optional(this, 512, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 513 OptionalOp       */ __Matchers[513] = new Optional(this, 513, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 514 SeqOp            */ __Matchers[514] = new Seq(this, 514, "_514:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 515 StringOp         */ __Matchers[515] = new Keyword(this, 515, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 516 OptionalOp       */ __Matchers[516] = new Optional(this, 516, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 517 SeqOp            */ __Matchers[517] = new Seq(this, 517, "_517:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 518 SeqOp            */ __Matchers[518] = new Seq(this, 518, "_518:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 519 StringOp         */ __Matchers[519] = new Keyword(this, 519, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 520 OptionalOp       */ __Matchers[520] = new Optional(this, 520, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 521 SeqOp            */ __Matchers[521] = new Seq(this, 521, "_521:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 522 StringOp         */ __Matchers[522] = new Keyword(this, 522, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 523 SeqOp            */ __Matchers[523] = new Seq(this, 523, "_523:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 524 AltOp            */ __Matchers[524] = new Alt(this, 524, "alt(>block|>required-function-specifier)") { Builder = nodes => nodes[0] };
                /* 525 SeqOp            */ __Matchers[525] = new Seq(this, 525, "_525:(>annotations,>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 527 SeqOp            */ __Matchers[527] = new Seq(this, 527, "_527:(>annotations,'void',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 528 StringOp         */ __Matchers[528] = new Keyword(this, 528, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 529 SeqOp            */ __Matchers[529] = new Seq(this, 529, "_529:(>annotations,'function',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_530:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 531 StringOp         */ __Matchers[531] = new Keyword(this, 531, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_532:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 533 AltOp            */ __Matchers[533] = new Alt(this, 533, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 534 OptionalOp       */ __Matchers[534] = new Optional(this, 534, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 535 SeqOp            */ __Matchers[535] = new Seq(this, 535, "_535:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 536 StringOp         */ __Matchers[536] = new Keyword(this, 536, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 537 OptionalOp       */ __Matchers[537] = new Optional(this, 537, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_538:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 539 AltOp            */ __Matchers[539] = new Alt(this, 539, "alt(>block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 540 OptionalOp       */ __Matchers[540] = new Optional(this, 540, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 541 SeqOp            */ __Matchers[541] = new Seq(this, 541, "_541:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 542 StringOp         */ __Matchers[542] = new Keyword(this, 542, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 543 SeqOp            */ __Matchers[543] = new Seq(this, 543, "_543:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 544 AltOp            */ __Matchers[544] = new Alt(this, 544, "alt(>block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 545 OptionalOp       */ __Matchers[545] = new Optional(this, 545, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 546 SeqOp            */ __Matchers[546] = new Seq(this, 546, "_546:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 547 StarOp           */ __Matchers[547] = new Star(this, 547, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 548 AltOp            */ __Matchers[548] = new Alt(this, 548, "alt(>declaration-statement|>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 549 SeqOp            */ __Matchers[549] = new Seq(this, 549, "_549:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 550 AltOp            */ __Matchers[550] = new Alt(this, 550, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 551 SeqOp            */ __Matchers[551] = new Seq(this, 551, "_551:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 552 AltOp            */ __Matchers[552] = new Alt(this, 552, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 553 StringOp         */ __Matchers[553] = new Keyword(this, 553, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 554 OptionalOp       */ __Matchers[554] = new Optional(this, 554, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 555 SeqOp            */ __Matchers[555] = new Seq(this, 555, "_555:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 556 StringOp         */ __Matchers[556] = new Keyword(this, 556, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 557 SeqOp            */ __Matchers[557] = new Seq(this, 557, "_557:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 558 StringOp         */ __Matchers[558] = new Keyword(this, 558, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 559 StringOp         */ __Matchers[559] = new Keyword(this, 559, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 560 SeqOp            */ __Matchers[560] = new Seq(this, 560, "_560:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 561 SeqOp            */ __Matchers[561] = new Seq(this, 561, "_561:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 562 SeqOp            */ __Matchers[562] = new Seq(this, 562, "_562:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 563 AltOp            */ __Matchers[563] = new Alt(this, 563, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 564 AltOp            */ __Matchers[564] = new Alt(this, 564, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 565 AltOp            */ __Matchers[565] = new Alt(this, 565, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 566 SeqOp            */ __Matchers[566] = new Seq(this, 566, "_566:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 567 SeqOp            */ __Matchers[567] = new Seq(this, 567, "_567:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 568 OptionalOp       */ __Matchers[568] = new Optional(this, 568, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 569 SeqOp            */ __Matchers[569] = new Seq(this, 569, "_569:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 571 SeqOp            */ __Matchers[571] = new Seq(this, 571, "_571:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 572 StringOp         */ __Matchers[572] = new Keyword(this, 572, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 573 StringOp         */ __Matchers[573] = new Keyword(this, 573, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 574 AltOp            */ __Matchers[574] = new Alt(this, 574, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 575 OptionalOp       */ __Matchers[575] = new Optional(this, 575, "?(>sequenced-argument-list)") { Builder = nodes => new ROptional<CSequencedArgumentList>(nodes) };
                /* 576 SeqOp            */ __Matchers[576] = new Seq(this, 576, "_576:('{',>statements,?(>sequenced-argument-list),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 577 SeqOp            */ __Matchers[577] = new Seq(this, 577, "_577:('[',?(>sequenced-argument-list),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 578 AltOp            */ __Matchers[578] = new Alt(this, 578, "alt(>patterned-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 579 StarOp           */ __Matchers[579] = new Star(this, 579, "*(>structured-argument)") { Builder = nodes => new RStar<ICStructuredArgument>(nodes) };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_580:('{',*(>structured-argument),?(>sequenced-argument-list),'}')") { Builder = nodes => new CPatternedArguments(nodes) };
                /* 581 SeqOp            */ __Matchers[581] = new Seq(this, 581, "_581:('(',?(>sequenced-argument-list),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 582 AltOp            */ __Matchers[582] = new Alt(this, 582, "alt(>anonymous-argument|>named-argument)") { Builder = nodes => nodes[0] };
                /* 583 SeqOp            */ __Matchers[583] = new Seq(this, 583, "_583:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 584 AltOp            */ __Matchers[584] = new Alt(this, 584, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_585:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 586 SeqOp            */ __Matchers[586] = new Seq(this, 586, "_586:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 587 StarOp           */ __Matchers[587] = new Star(this, 587, "*(_586:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:(>sequenced-argument,*(_586:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArgumentList(nodes) };
                /* 589 AltOp            */ __Matchers[589] = new Alt(this, 589, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 590 AltOp            */ __Matchers[590] = new Alt(this, 590, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 592 SeqOp            */ __Matchers[592] = new Seq(this, 592, "_592:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 593 AltOp            */ __Matchers[593] = new Alt(this, 593, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_594:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_595:(>function-specifier,';')") { Builder = nodes => new CRequiredFunctionSpecifier(nodes) };
                /* 596 AltOp            */ __Matchers[596] = new Alt(this, 596, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_597:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_598:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 599 SeqOp            */ __Matchers[599] = new Seq(this, 599, "_599:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_600:(>member-name,+(>parameters),>required-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 601 SeqOp            */ __Matchers[601] = new Seq(this, 601, "_601:(>member-name,>required-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 602 AltOp            */ __Matchers[602] = new Alt(this, 602, "alt(>expression-argument|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 603 StringOp         */ __Matchers[603] = new String(this, 603, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 604 SeqOp            */ __Matchers[604] = new Seq(this, 604, "_604:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 605 OptionalOp       */ __Matchers[605] = new Optional(this, 605, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 606 SeqOp            */ __Matchers[606] = new Seq(this, 606, "_606:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 608 PlusOp           */ __Matchers[608] = new Plus(this, 608, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 609 OptionalOp       */ __Matchers[609] = new Optional(this, 609, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 610 SeqOp            */ __Matchers[610] = new Seq(this, 610, "_610:(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 611 StringOp         */ __Matchers[611] = new Keyword(this, 611, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 613 StringOp         */ __Matchers[613] = new Keyword(this, 613, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_614:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 615 StringOp         */ __Matchers[615] = new Keyword(this, 615, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 616 SeqOp            */ __Matchers[616] = new Seq(this, 616, "_616:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new Keyword(this, 618, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 619 SeqOp            */ __Matchers[619] = new Seq(this, 619, "_619:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 620 AltOp            */ __Matchers[620] = new Alt(this, 620, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 621 OptionalOp       */ __Matchers[621] = new Optional(this, 621, "?(>function-expression-type)") { Builder = nodes => new ROptional<ICFunctionExpressionType>(nodes) };
                /* 622 OptionalOp       */ __Matchers[622] = new Optional(this, 622, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 623 SeqOp            */ __Matchers[623] = new Seq(this, 623, "_623:(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpr(nodes) };
                /* 624 AltOp            */ __Matchers[624] = new Alt(this, 624, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 625 SeqOp            */ __Matchers[625] = new Seq(this, 625, "_625:(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 626 AltOp            */ __Matchers[626] = new Alt(this, 626, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 627 AltOp            */ __Matchers[627] = new Alt(this, 627, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 628 AltOp            */ __Matchers[628] = new Alt(this, 628, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 629 StringOp         */ __Matchers[629] = new Keyword(this, 629, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 630 OptionalOp       */ __Matchers[630] = new Optional(this, 630, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 631 SeqOp            */ __Matchers[631] = new Seq(this, 631, "_631:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 632 SeqOp            */ __Matchers[632] = new Seq(this, 632, "_632:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 633 AltOp            */ __Matchers[633] = new Alt(this, 633, "alt(>let-expr|>if-expr|>switch-expr|>function-expr|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 634 AltOp            */ __Matchers[634] = new Alt(this, 634, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 635 SeqOp            */ __Matchers[635] = new Seq(this, 635, "_635:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 636 StringOp         */ __Matchers[636] = new String(this, 636, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 637 StringOp         */ __Matchers[637] = new String(this, 637, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 638 StringOp         */ __Matchers[638] = new String(this, 638, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 639 StringOp         */ __Matchers[639] = new String(this, 639, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 640 StringOp         */ __Matchers[640] = new String(this, 640, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 647 AltOp            */ __Matchers[647] = new Alt(this, 647, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 648 AltOp            */ __Matchers[648] = new Alt(this, 648, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 649 SeqOp            */ __Matchers[649] = new Seq(this, 649, "_649:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 650 AltOp            */ __Matchers[650] = new Alt(this, 650, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 651 AltOp            */ __Matchers[651] = new Alt(this, 651, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 652 SeqOp            */ __Matchers[652] = new Seq(this, 652, "_652:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 653 StringOp         */ __Matchers[653] = new String(this, 653, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 654 AltOp            */ __Matchers[654] = new Alt(this, 654, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 655 SeqOp            */ __Matchers[655] = new Seq(this, 655, "_655:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 656 StringOp         */ __Matchers[656] = new String(this, 656, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 657 AltOp            */ __Matchers[657] = new Alt(this, 657, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 658 SeqOp            */ __Matchers[658] = new Seq(this, 658, "_658:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 659 StringOp         */ __Matchers[659] = new String(this, 659, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 660 AltOp            */ __Matchers[660] = new Alt(this, 660, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 661 AltOp            */ __Matchers[661] = new Alt(this, 661, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 662 SeqOp            */ __Matchers[662] = new Seq(this, 662, "_662:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 663 StringOp         */ __Matchers[663] = new String(this, 663, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 664 StringOp         */ __Matchers[664] = new String(this, 664, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 665 StringOp         */ __Matchers[665] = new String(this, 665, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 666 AltOp            */ __Matchers[666] = new Alt(this, 666, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 667 AltOp            */ __Matchers[667] = new Alt(this, 667, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 668 SeqOp            */ __Matchers[668] = new Seq(this, 668, "_668:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 669 SeqOp            */ __Matchers[669] = new Seq(this, 669, "_669:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 670 SeqOp            */ __Matchers[670] = new Seq(this, 670, "_670:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_671:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 672 SeqOp            */ __Matchers[672] = new Seq(this, 672, "_672:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 673 SeqOp            */ __Matchers[673] = new Seq(this, 673, "_673:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 674 StringOp         */ __Matchers[674] = new String(this, 674, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 675 AltOp            */ __Matchers[675] = new Alt(this, 675, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 676 StringOp         */ __Matchers[676] = new String(this, 676, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 677 AltOp            */ __Matchers[677] = new Alt(this, 677, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 678 StringOp         */ __Matchers[678] = new String(this, 678, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 679 AltOp            */ __Matchers[679] = new Alt(this, 679, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 680 StringOp         */ __Matchers[680] = new Keyword(this, 680, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 681 AltOp            */ __Matchers[681] = new Alt(this, 681, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 682 AltOp            */ __Matchers[682] = new Alt(this, 682, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 683 StringOp         */ __Matchers[683] = new Keyword(this, 683, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 684 SeqOp            */ __Matchers[684] = new Seq(this, 684, "_684:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 685 StringOp         */ __Matchers[685] = new Keyword(this, 685, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 686 SeqOp            */ __Matchers[686] = new Seq(this, 686, "_686:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 687 AltOp            */ __Matchers[687] = new Alt(this, 687, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 688 SeqOp            */ __Matchers[688] = new Seq(this, 688, "_688:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 689 SeqOp            */ __Matchers[689] = new Seq(this, 689, "_689:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 690 StringOp         */ __Matchers[690] = new String(this, 690, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 691 AltOp            */ __Matchers[691] = new Alt(this, 691, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 692 AltOp            */ __Matchers[692] = new Alt(this, 692, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 693 SeqOp            */ __Matchers[693] = new Seq(this, 693, "_693:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 694 StringOp         */ __Matchers[694] = new String(this, 694, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 695 StringOp         */ __Matchers[695] = new String(this, 695, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 696 AltOp            */ __Matchers[696] = new Alt(this, 696, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 697 AltOp            */ __Matchers[697] = new Alt(this, 697, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 698 SeqOp            */ __Matchers[698] = new Seq(this, 698, "_698:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 699 StringOp         */ __Matchers[699] = new String(this, 699, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 700 AltOp            */ __Matchers[700] = new Alt(this, 700, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 701 SeqOp            */ __Matchers[701] = new Seq(this, 701, "_701:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 702 StringOp         */ __Matchers[702] = new String(this, 702, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 703 StringOp         */ __Matchers[703] = new String(this, 703, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 704 AltOp            */ __Matchers[704] = new Alt(this, 704, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 705 AltOp            */ __Matchers[705] = new Alt(this, 705, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 706 SeqOp            */ __Matchers[706] = new Seq(this, 706, "_706:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 707 StringOp         */ __Matchers[707] = new String(this, 707, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 708 AltOp            */ __Matchers[708] = new Alt(this, 708, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 709 AltOp            */ __Matchers[709] = new Alt(this, 709, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 710 SeqOp            */ __Matchers[710] = new Seq(this, 710, "_710:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 711 StringOp         */ __Matchers[711] = new String(this, 711, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 712 AltOp            */ __Matchers[712] = new Alt(this, 712, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 713 SeqOp            */ __Matchers[713] = new Seq(this, 713, "_713:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 714 StringOp         */ __Matchers[714] = new String(this, 714, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 715 AltOp            */ __Matchers[715] = new Alt(this, 715, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 716 SeqOp            */ __Matchers[716] = new Seq(this, 716, "_716:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 717 AltOp            */ __Matchers[717] = new Alt(this, 717, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 718 NotOp            */ __Matchers[718] = new Not(this, 718, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 719 SeqOp            */ __Matchers[719] = new Seq(this, 719, "_719:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 720 NotOp            */ __Matchers[720] = new Not(this, 720, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_721:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 722 AltOp            */ __Matchers[722] = new Alt(this, 722, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 723 SeqOp            */ __Matchers[723] = new Seq(this, 723, "_723:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 724 AltOp            */ __Matchers[724] = new Alt(this, 724, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 725 SeqOp            */ __Matchers[725] = new Seq(this, 725, "_725:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 726 StringOp         */ __Matchers[726] = new String(this, 726, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 727 StringOp         */ __Matchers[727] = new String(this, 727, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 728 AltOp            */ __Matchers[728] = new Alt(this, 728, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 729 AltOp            */ __Matchers[729] = new Alt(this, 729, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 730 SeqOp            */ __Matchers[730] = new Seq(this, 730, "_730:(>primary,>member-selection-operator,>base-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 731 StringOp         */ __Matchers[731] = new String(this, 731, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 732 StringOp         */ __Matchers[732] = new String(this, 732, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 733 AltOp            */ __Matchers[733] = new Alt(this, 733, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 734 SeqOp            */ __Matchers[734] = new Seq(this, 734, "_734:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 735 AltOp            */ __Matchers[735] = new Alt(this, 735, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 736 SeqOp            */ __Matchers[736] = new Seq(this, 736, "_736:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_737:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_738:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_740:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 741 AltOp            */ __Matchers[741] = new Alt(this, 741, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 742 AltOp            */ __Matchers[742] = new Alt(this, 742, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 743 AltOp            */ __Matchers[743] = new Alt(this, 743, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 744 StarOp           */ __Matchers[744] = new Star(this, 744, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 745 SeqOp            */ __Matchers[745] = new Seq(this, 745, "_745:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 746 SeqOp            */ __Matchers[746] = new Seq(this, 746, "_746:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 747 AltOp            */ __Matchers[747] = new Alt(this, 747, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_748:('object',?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 749 SeqOp            */ __Matchers[749] = new Seq(this, 749, "_749:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 750 OptionalOp       */ __Matchers[750] = new Optional(this, 750, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 751 SeqOp            */ __Matchers[751] = new Seq(this, 751, "_751:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 752 SeqOp            */ __Matchers[752] = new Seq(this, 752, "_752:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 753 StarOp           */ __Matchers[753] = new Star(this, 753, "*(_752:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_754:(>varianced-type,*(_752:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_755:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_756:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 757 StarOp           */ __Matchers[757] = new Star(this, 757, "*(_756:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 758 SeqOp            */ __Matchers[758] = new Seq(this, 758, "_758:(>defaulted-type,*(_756:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 759 AltOp            */ __Matchers[759] = new Alt(this, 759, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 760 SeqOp            */ __Matchers[760] = new Seq(this, 760, "_760:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 761 AltOp            */ __Matchers[761] = new Alt(this, 761, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 762 SeqOp            */ __Matchers[762] = new Seq(this, 762, "_762:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 763 AltOp            */ __Matchers[763] = new Alt(this, 763, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 764 SeqOp            */ __Matchers[764] = new Seq(this, 764, "_764:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 765 AltOp            */ __Matchers[765] = new Alt(this, 765, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 766 SeqOp            */ __Matchers[766] = new Seq(this, 766, "_766:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 767 AltOp            */ __Matchers[767] = new Alt(this, 767, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 768 SeqOp            */ __Matchers[768] = new Seq(this, 768, "_768:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 769 AltOp            */ __Matchers[769] = new Alt(this, 769, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 770 SeqOp            */ __Matchers[770] = new Seq(this, 770, "_770:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 771 AltOp            */ __Matchers[771] = new Alt(this, 771, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>package-qualified-type|>type-path)") { Builder = nodes => nodes[0] };
                /* 772 StringOp         */ __Matchers[772] = new String(this, 772, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 773 SeqOp            */ __Matchers[773] = new Seq(this, 773, "_773:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 774 OptionalOp       */ __Matchers[774] = new Optional(this, 774, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 775 SeqOp            */ __Matchers[775] = new Seq(this, 775, "_775:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 776 OptionalOp       */ __Matchers[776] = new Optional(this, 776, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 777 SeqOp            */ __Matchers[777] = new Seq(this, 777, "_777:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 778 AltOp            */ __Matchers[778] = new Alt(this, 778, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 779 SeqOp            */ __Matchers[779] = new Seq(this, 779, "_779:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 780 OptionalOp       */ __Matchers[780] = new Optional(this, 780, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 781 SeqOp            */ __Matchers[781] = new Seq(this, 781, "_781:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_782:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 783 SeqOp            */ __Matchers[783] = new Seq(this, 783, "_783:('package','.',>type-path)") { Builder = nodes => new CPackageQualifiedType(nodes) };
                /* 784 OptionalOp       */ __Matchers[784] = new Optional(this, 784, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 785 StarOp           */ __Matchers[785] = new Star(this, 785, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 786 SeqOp            */ __Matchers[786] = new Seq(this, 786, "_786:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 787 SeqOp            */ __Matchers[787] = new Seq(this, 787, "_787:(>member-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 788 OptionalOp       */ __Matchers[788] = new Optional(this, 788, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 789 SeqOp            */ __Matchers[789] = new Seq(this, 789, "_789:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_790:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 791 StarOp           */ __Matchers[791] = new Star(this, 791, "*(_790:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 792 SeqOp            */ __Matchers[792] = new Seq(this, 792, "_792:(>condition,*(_790:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 793 AltOp            */ __Matchers[793] = new Alt(this, 793, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 794 OptionalOp       */ __Matchers[794] = new Optional(this, 794, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 795 SeqOp            */ __Matchers[795] = new Seq(this, 795, "_795:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 796 SeqOp            */ __Matchers[796] = new Seq(this, 796, "_796:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 797 AltOp            */ __Matchers[797] = new Alt(this, 797, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 798 SeqOp            */ __Matchers[798] = new Seq(this, 798, "_798:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 800 SeqOp            */ __Matchers[800] = new Seq(this, 800, "_800:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 801 AltOp            */ __Matchers[801] = new Alt(this, 801, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 802 StarOp           */ __Matchers[802] = new Star(this, 802, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 803 OptionalOp       */ __Matchers[803] = new Optional(this, 803, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 804 SeqOp            */ __Matchers[804] = new Seq(this, 804, "_804:('if',>conditions,>block,*(>else-if),?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 805 SeqOp            */ __Matchers[805] = new Seq(this, 805, "_805:('else','if',>conditions,>block)") { Builder = nodes => new CElseIf(nodes) };
                /* 806 SeqOp            */ __Matchers[806] = new Seq(this, 806, "_806:('else',>block)") { Builder = nodes => new CElseBlock(nodes) };
                /* 807 PlusOp           */ __Matchers[807] = new Plus(this, 807, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_808:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 809 StringOp         */ __Matchers[809] = new Keyword(this, 809, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 810 SeqOp            */ __Matchers[810] = new Seq(this, 810, "_810:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 811 SeqOp            */ __Matchers[811] = new Seq(this, 811, "_811:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 812 AltOp            */ __Matchers[812] = new Alt(this, 812, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 813 OptionalOp       */ __Matchers[813] = new Optional(this, 813, "?('is')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_814:(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_815:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 816 SeqOp            */ __Matchers[816] = new Seq(this, 816, "_816:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 817 StarOp           */ __Matchers[817] = new Star(this, 817, "*(_816:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 818 SeqOp            */ __Matchers[818] = new Seq(this, 818, "_818:(>value-case,*(_816:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 819 AltOp            */ __Matchers[819] = new Alt(this, 819, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 820 AltOp            */ __Matchers[820] = new Alt(this, 820, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 821 SeqOp            */ __Matchers[821] = new Seq(this, 821, "_821:(>for-block,?(>else-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 822 SeqOp            */ __Matchers[822] = new Seq(this, 822, "_822:('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 823 OptionalOp       */ __Matchers[823] = new Optional(this, 823, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 824 SeqOp            */ __Matchers[824] = new Seq(this, 824, "_824:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 825 AltOp            */ __Matchers[825] = new Alt(this, 825, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 826 SeqOp            */ __Matchers[826] = new Seq(this, 826, "_826:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 827 AltOp            */ __Matchers[827] = new Alt(this, 827, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 828 StringOp         */ __Matchers[828] = new Keyword(this, 828, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 829 SeqOp            */ __Matchers[829] = new Seq(this, 829, "_829:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 830 StarOp           */ __Matchers[830] = new Star(this, 830, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 831 OptionalOp       */ __Matchers[831] = new Optional(this, 831, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 832 SeqOp            */ __Matchers[832] = new Seq(this, 832, "_832:(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 833 StringOp         */ __Matchers[833] = new Keyword(this, 833, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 834 OptionalOp       */ __Matchers[834] = new Optional(this, 834, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 835 SeqOp            */ __Matchers[835] = new Seq(this, 835, "_835:('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 836 StringOp         */ __Matchers[836] = new Keyword(this, 836, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 837 SeqOp            */ __Matchers[837] = new Seq(this, 837, "_837:('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 838 OptionalOp       */ __Matchers[838] = new Optional(this, 838, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 839 SeqOp            */ __Matchers[839] = new Seq(this, 839, "_839:('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 840 StringOp         */ __Matchers[840] = new Keyword(this, 840, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_841:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 842 OptionalOp       */ __Matchers[842] = new Optional(this, 842, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 843 SeqOp            */ __Matchers[843] = new Seq(this, 843, "_843:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_844:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 845 StarOp           */ __Matchers[845] = new Star(this, 845, "*(_844:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_846:(>resource,*(_844:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 847 AltOp            */ __Matchers[847] = new Alt(this, 847, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 848 SeqOp            */ __Matchers[848] = new Seq(this, 848, "_848:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 849 OptionalOp       */ __Matchers[849] = new Optional(this, 849, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 850 StarOp           */ __Matchers[850] = new Star(this, 850, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 851 SeqOp            */ __Matchers[851] = new Seq(this, 851, "_851:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 852 AltOp            */ __Matchers[852] = new Alt(this, 852, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 853 SeqOp            */ __Matchers[853] = new Seq(this, 853, "_853:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 854 StringOp         */ __Matchers[854] = new String(this, 854, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 855 SeqOp            */ __Matchers[855] = new Seq(this, 855, "_855:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 856 AltOp            */ __Matchers[856] = new Alt(this, 856, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 857 AltOp            */ __Matchers[857] = new Alt(this, 857, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 858 AltOp            */ __Matchers[858] = new Alt(this, 858, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 859 SeqOp            */ __Matchers[859] = new Seq(this, 859, "_859:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 860 SeqOp            */ __Matchers[860] = new Seq(this, 860, "_860:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 861 AltOp            */ __Matchers[861] = new Alt(this, 861, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 862 OptionalOp       */ __Matchers[862] = new Optional(this, 862, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 863 SeqOp            */ __Matchers[863] = new Seq(this, 863, "_863:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 864 SeqOp            */ __Matchers[864] = new Seq(this, 864, "_864:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_865:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_866:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_867:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_868:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 871 AltOp            */ __Matchers[871] = new Alt(this, 871, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_872:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 873 SeqOp            */ __Matchers[873] = new Seq(this, 873, "_873:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 874 SeqOp            */ __Matchers[874] = new Seq(this, 874, "_874:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_875:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 876 StarOp           */ __Matchers[876] = new Star(this, 876, "*(_875:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 877 SeqOp            */ __Matchers[877] = new Seq(this, 877, "_877:(>reference-path-element,*(_875:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[367]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[368]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[369]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[372]);
                /*   6 PlainRuleOp      */ _namespacePath.Set(__Matchers[376]);
                /*   7 PlainRuleOp      */ _imports.Set(__Matchers[377]);
                /*   8 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[381]);
                /*   9 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[384]);
                /*  10 PlainRuleOp      */ _repository.Set(_identifier);
                /*  11 PlainRuleOp      */ _module.Set(__Matchers[385]);
                /*  12 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[387]);
                /*  13 PlainRuleOp      */ _artifact.Set(__Matchers[388]);
                /*  14 PlainRuleOp      */ _classifier.Set(__Matchers[389]);
                /*  15 PlainRuleOp      */ _version.Set(_literalString);
                /*  16 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  17 PlainRuleOp      */ _moduleBody.Set(__Matchers[393]);
                /*  18 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[394]);
                /*  19 PlainRuleOp      */ _moduleImport.Set(__Matchers[396]);
                /*  20 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[398]);
                /*  21 PlainRuleOp      */ _importDeclaration.Set(__Matchers[399]);
                /*  22 PlainRuleOp      */ _importElements.Set(__Matchers[401]);
                /*  23 PlainRuleOp      */ _importElementList.Set(__Matchers[405]);
                /*  24 PlainRuleOp      */ _importElement.Set(__Matchers[406]);
                /*  25 PlainRuleOp      */ _importNamed.Set(__Matchers[409]);
                /*  26 PlainRuleOp      */ _importName.Set(_identifier);
                /*  27 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[411]);
                /*  28 PlainRuleOp      */ _importWildcard.Set(__Matchers[412]);
                /*  29 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  30 PlainRuleOp      */ _packagePath.Set(__Matchers[415]);
                /*  31 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  32 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  33 PlainRuleOp      */ _pattern.Set(__Matchers[416]);
                /*  34 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[417]);
                /*  35 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[418]);
                /*  36 PlainRuleOp      */ _entryPattern.Set(__Matchers[420]);
                /*  37 PlainRuleOp      */ _tuplePattern.Set(__Matchers[424]);
                /*  38 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[427]);
                /*  39 PlainRuleOp      */ _variadicPattern.Set(__Matchers[428]);
                /*  40 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  41 PlainRuleOp      */ _variadicVariable.Set(__Matchers[430]);
                /*  42 PlainRuleOp      */ _letStatement.Set(__Matchers[434]);
                /*  43 PlainRuleOp      */ _letVariableList.Set(__Matchers[437]);
                /*  44 PlainRuleOp      */ _letVariable.Set(__Matchers[438]);
                /*  45 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[440]);
                /*  46 PlainRuleOp      */ _assertionStatement.Set(__Matchers[443]);
                /*  47 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  48 PlainRuleOp      */ _block.Set(__Matchers[444]);
                /*  49 PlainRuleOp      */ _extendedType.Set(__Matchers[445]);
                /*  50 PlainRuleOp      */ _classSpecifier.Set(__Matchers[447]);
                /*  51 PlainRuleOp      */ _classInstatiation.Set(__Matchers[449]);
                /*  52 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[450]);
                /*  53 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[451]);
                /*  54 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[453]);
                /*  55 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[454]);
                /*  56 PlainRuleOp      */ _memberPath.Set(__Matchers[455]);
                /*  57 PlainRuleOp      */ _typePath.Set(__Matchers[458]);
                /*  58 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[460]);
                /*  59 PlainRuleOp      */ _unionTypeList.Set(__Matchers[463]);
                /*  60 PlainRuleOp      */ _caseTypes.Set(__Matchers[465]);
                /*  61 PlainRuleOp      */ _caseTypeList.Set(__Matchers[469]);
                /*  62 PlainRuleOp      */ _caseType.Set(__Matchers[470]);
                /*  63 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[472]);
                /*  64 PlainRuleOp      */ _parameters.Set(__Matchers[474]);
                /*  65 PlainRuleOp      */ _parameterList.Set(__Matchers[477]);
                /*  66 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[478]);
                /*  67 PlainRuleOp      */ _parameter.Set(__Matchers[479]);
                /*  68 PlainRuleOp      */ _parameterReference.Set(__Matchers[481]);
                /*  69 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[482]);
                /*  70 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[486]);
                /*  71 PlainRuleOp      */ _functionParameterType.Set(__Matchers[487]);
                /*  72 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[488]);
                /*  73 PlainRuleOp      */ _valueParameterType.Set(__Matchers[489]);
                /*  74 PlainRuleOp      */ _typeParameters.Set(__Matchers[492]);
                /*  75 PlainRuleOp      */ _typeParameterList.Set(__Matchers[495]);
                /*  76 PlainRuleOp      */ _typeParameter.Set(__Matchers[498]);
                /*  77 PlainRuleOp      */ _variance.Set(__Matchers[501]);
                /*  78 PlainRuleOp      */ _typeDefault.Set(__Matchers[502]);
                /*  79 PlainRuleOp      */ _typeConstraint.Set(__Matchers[507]);
                /*  80 PlainRuleOp      */ _typeConstraints.Set(__Matchers[508]);
                /*  81 PlainRuleOp      */ _declarations.Set(__Matchers[509]);
                /*  82 PlainRuleOp      */ _declaration.Set(__Matchers[510]);
                /*  83 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[514]);
                /*  84 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[517]);
                /*  85 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[518]);
                /*  86 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[521]);
                /*  87 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[523]);
                /*  88 PlainRuleOp      */ _setterDefinition.Set(__Matchers[524]);
                /*  89 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[525]);
                /*  90 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[527]);
                /*  91 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[529]);
                /*  92 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[530]);
                /*  93 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[532]);
                /*  94 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[533]);
                /*  95 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[535]);
                /*  96 PlainRuleOp      */ _classDeclaration.Set(__Matchers[538]);
                /*  97 PlainRuleOp      */ _classDefinition.Set(__Matchers[539]);
                /*  98 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[541]);
                /*  99 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[543]);
                /* 100 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[544]);
                /* 101 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[546]);
                /* 102 PlainRuleOp      */ _statements.Set(__Matchers[547]);
                /* 103 PlainRuleOp      */ _statement.Set(__Matchers[548]);
                /* 104 PlainRuleOp      */ _declarationStatement.Set(_declaration);
                /* 105 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[549]);
                /* 106 PlainRuleOp      */ _openStatement.Set(__Matchers[550]);
                /* 107 PlainRuleOp      */ _specificationStatement.Set(__Matchers[551]);
                /* 108 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 109 PlainRuleOp      */ _directiveStatement.Set(__Matchers[552]);
                /* 110 PlainRuleOp      */ _returnStatement.Set(__Matchers[555]);
                /* 111 PlainRuleOp      */ _throwStatement.Set(__Matchers[557]);
                /* 112 PlainRuleOp      */ _breakStatement.Set(__Matchers[558]);
                /* 113 PlainRuleOp      */ _continueStatement.Set(__Matchers[559]);
                /* 114 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[560]);
                /* 115 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[561]);
                /* 116 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[562]);
                /* 117 PlainRuleOp      */ _anySpecifier.Set(__Matchers[563]);
                /* 118 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[564]);
                /* 119 PlainRuleOp      */ _baseReference.Set(__Matchers[565]);
                /* 120 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[566]);
                /* 121 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[567]);
                /* 122 PlainRuleOp      */ _memberReference.Set(__Matchers[569]);
                /* 123 PlainRuleOp      */ _typeReference.Set(__Matchers[570]);
                /* 124 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[571]);
                /* 125 PlainRuleOp      */ _selfReference.Set(__Matchers[574]);
                /* 126 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[576]);
                /* 127 PlainRuleOp      */ _tupleExpr.Set(__Matchers[577]);
                /* 128 PlainRuleOp      */ _arguments.Set(__Matchers[578]);
                /* 129 PlainRuleOp      */ _patternedArguments.Set(__Matchers[580]);
                /* 130 PlainRuleOp      */ _positionalArguments.Set(__Matchers[581]);
                /* 131 PlainRuleOp      */ _structuredArgument.Set(__Matchers[582]);
                /* 132 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[583]);
                /* 133 PlainRuleOp      */ _namedArgument.Set(__Matchers[584]);
                /* 134 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[585]);
                /* 135 PlainRuleOp      */ _sequencedArgumentList.Set(__Matchers[588]);
                /* 136 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[589]);
                /* 137 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[590]);
                /* 138 PlainRuleOp      */ _objectArgument.Set(__Matchers[591]);
                /* 139 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[592]);
                /* 140 PlainRuleOp      */ _methodDefinition.Set(__Matchers[593]);
                /* 141 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[594]);
                /* 142 PlainRuleOp      */ _requiredFunctionSpecifier.Set(__Matchers[595]);
                /* 143 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[596]);
                /* 144 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[597]);
                /* 145 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 146 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[598]);
                /* 147 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[599]);
                /* 148 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[600]);
                /* 149 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[601]);
                /* 150 PlainRuleOp      */ _positionalArgument.Set(__Matchers[602]);
                /* 151 PlainRuleOp      */ _expressionArgument.Set(_expression);
                /* 152 PlainRuleOp      */ _spreadArgument.Set(__Matchers[604]);
                /* 153 PlainRuleOp      */ _letExpr.Set(__Matchers[606]);
                /* 154 PlainRuleOp      */ _switchExpr.Set(__Matchers[607]);
                /* 155 PlainRuleOp      */ _caseExpressions.Set(__Matchers[610]);
                /* 156 PlainRuleOp      */ _caseExpression.Set(__Matchers[614]);
                /* 157 PlainRuleOp      */ _ifExpr.Set(__Matchers[616]);
                /* 158 PlainRuleOp      */ _elseExpression.Set(__Matchers[617]);
                /* 159 PlainRuleOp      */ _thenExpression.Set(__Matchers[619]);
                /* 160 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[620]);
                /* 161 PlainRuleOp      */ _functionExpr.Set(__Matchers[623]);
                /* 162 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[624]);
                /* 163 PlainRuleOp      */ _functionParameters.Set(__Matchers[625]);
                /* 164 PlainRuleOp      */ _functionDefinition.Set(__Matchers[626]);
                /* 165 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[627]);
                /* 166 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[628]);
                /* 167 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 168 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[631]);
                /* 169 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[632]);
                /* 170 PlainRuleOp      */ _expression.Set(__Matchers[633]);
                /* 171 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 172 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[634]);
                /* 173 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[635]);
                /* 174 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[647]);
                /* 175 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[648]);
                /* 176 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[649]);
                /* 177 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[650]);
                /* 178 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[651]);
                /* 179 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[652]);
                /* 180 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[653]);
                /* 181 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[654]);
                /* 182 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[655]);
                /* 183 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[656]);
                /* 184 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[657]);
                /* 185 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[658]);
                /* 186 PlainRuleOp      */ _notOperator.Set(__Matchers[659]);
                /* 187 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[660]);
                /* 188 PlainRuleOp      */ _equalityExpression.Set(__Matchers[661]);
                /* 189 PlainRuleOp      */ _equalityExpr.Set(__Matchers[662]);
                /* 190 PlainRuleOp      */ _equalityOperator.Set(__Matchers[666]);
                /* 191 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[667]);
                /* 192 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[668]);
                /* 193 PlainRuleOp      */ _largerExpr.Set(__Matchers[669]);
                /* 194 PlainRuleOp      */ _smallerExpr.Set(__Matchers[670]);
                /* 195 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[671]);
                /* 196 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[672]);
                /* 197 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[673]);
                /* 198 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[675]);
                /* 199 PlainRuleOp      */ _smallerOperator.Set(__Matchers[677]);
                /* 200 PlainRuleOp      */ _largerOperator.Set(__Matchers[679]);
                /* 201 PlainRuleOp      */ _typeOperator.Set(__Matchers[681]);
                /* 202 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[682]);
                /* 203 PlainRuleOp      */ _existsExpr.Set(__Matchers[684]);
                /* 204 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[686]);
                /* 205 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[687]);
                /* 206 PlainRuleOp      */ _rangeExpr.Set(__Matchers[688]);
                /* 207 PlainRuleOp      */ _entryExpr.Set(__Matchers[689]);
                /* 208 PlainRuleOp      */ _rangeOperator.Set(__Matchers[691]);
                /* 209 PlainRuleOp      */ _entryOperator.Set(__Matchers[419]);
                /* 210 PlainRuleOp      */ _additiveExpression.Set(__Matchers[692]);
                /* 211 PlainRuleOp      */ _additiveExpr.Set(__Matchers[693]);
                /* 212 PlainRuleOp      */ _additiveOperator.Set(__Matchers[696]);
                /* 213 PlainRuleOp      */ _scaleExpression.Set(__Matchers[697]);
                /* 214 PlainRuleOp      */ _scaleExpr.Set(__Matchers[698]);
                /* 215 PlainRuleOp      */ _scaleOperator.Set(__Matchers[699]);
                /* 216 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[700]);
                /* 217 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[701]);
                /* 218 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[704]);
                /* 219 PlainRuleOp      */ _unionExpression.Set(__Matchers[705]);
                /* 220 PlainRuleOp      */ _unionExpr.Set(__Matchers[706]);
                /* 221 PlainRuleOp      */ _unionOperator.Set(__Matchers[708]);
                /* 222 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[709]);
                /* 223 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[710]);
                /* 224 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[711]);
                /* 225 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[712]);
                /* 226 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[713]);
                /* 227 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[714]);
                /* 228 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[715]);
                /* 229 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[716]);
                /* 230 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[717]);
                /* 231 PlainRuleOp      */ _negateOperator.Set(__Matchers[719]);
                /* 232 PlainRuleOp      */ _neutralOperator.Set(__Matchers[721]);
                /* 233 PlainRuleOp      */ _complementOperator.Set(__Matchers[707]);
                /* 234 PlainRuleOp      */ _prefixExpression.Set(__Matchers[722]);
                /* 235 PlainRuleOp      */ _prefixExpr.Set(__Matchers[723]);
                /* 236 PlainRuleOp      */ _postfixExpression.Set(__Matchers[724]);
                /* 237 PlainRuleOp      */ _postfixExpr.Set(__Matchers[725]);
                /* 238 PlainRuleOp      */ _incrementOperator.Set(__Matchers[728]);
                /* 239 PlainRuleOp      */ _primary.Set(__Matchers[729]);
                /* 240 PlainRuleOp      */ _selectionExpr.Set(__Matchers[730]);
                /* 241 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[733]);
                /* 242 PlainRuleOp      */ _indexedExpr.Set(__Matchers[734]);
                /* 243 PlainRuleOp      */ _index.Set(__Matchers[735]);
                /* 244 PlainRuleOp      */ _upperSpanned.Set(__Matchers[736]);
                /* 245 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[737]);
                /* 246 PlainRuleOp      */ _spanned.Set(__Matchers[738]);
                /* 247 PlainRuleOp      */ _measured.Set(__Matchers[739]);
                /* 248 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 249 PlainRuleOp      */ _callExpr.Set(__Matchers[740]);
                /* 250 PlainRuleOp      */ _baseExpression.Set(__Matchers[741]);
                /* 251 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[742]);
                /* 252 PlainRuleOp      */ _stringExpression.Set(__Matchers[743]);
                /* 253 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[745]);
                /* 254 PlainRuleOp      */ _interpolationPart.Set(__Matchers[746]);
                /* 255 PlainRuleOp      */ _stringLiteral.Set(__Matchers[747]);
                /* 256 PlainRuleOp      */ _objectExpr.Set(__Matchers[748]);
                /* 257 PlainRuleOp      */ _groupedExpr.Set(__Matchers[749]);
                /* 258 PlainRuleOp      */ _typeArguments.Set(__Matchers[751]);
                /* 259 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[754]);
                /* 260 PlainRuleOp      */ _variancedType.Set(__Matchers[755]);
                /* 261 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[758]);
                /* 262 PlainRuleOp      */ _defaultedType.Set(__Matchers[759]);
                /* 263 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[760]);
                /* 264 PlainRuleOp      */ _variadicType.Set(__Matchers[761]);
                /* 265 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[762]);
                /* 266 PlainRuleOp      */ _variadicOperator.Set(__Matchers[763]);
                /* 267 PlainRuleOp      */ _spreadType.Set(__Matchers[764]);
                /* 268 PlainRuleOp      */ _type.Set(__Matchers[765]);
                /* 269 PlainRuleOp      */ _entryType.Set(__Matchers[766]);
                /* 270 PlainRuleOp      */ _unionType.Set(__Matchers[767]);
                /* 271 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[768]);
                /* 272 PlainRuleOp      */ _intersectionType.Set(__Matchers[769]);
                /* 273 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[770]);
                /* 274 PlainRuleOp      */ _primaryType.Set(__Matchers[771]);
                /* 275 PlainRuleOp      */ _nullableType.Set(__Matchers[773]);
                /* 276 PlainRuleOp      */ _arrayType.Set(__Matchers[775]);
                /* 277 PlainRuleOp      */ _functionType.Set(__Matchers[777]);
                /* 278 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[778]);
                /* 279 PlainRuleOp      */ _tupleType.Set(__Matchers[779]);
                /* 280 PlainRuleOp      */ _iterableType.Set(__Matchers[781]);
                /* 281 PlainRuleOp      */ _groupedType.Set(__Matchers[782]);
                /* 282 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[783]);
                /* 283 PlainRuleOp      */ _annotations.Set(__Matchers[786]);
                /* 284 PlainRuleOp      */ _annotation.Set(__Matchers[787]);
                /* 285 PlainRuleOp      */ _conditions.Set(__Matchers[789]);
                /* 286 PlainRuleOp      */ _conditionList.Set(__Matchers[792]);
                /* 287 PlainRuleOp      */ _condition.Set(__Matchers[793]);
                /* 288 PlainRuleOp      */ _existsCondition.Set(__Matchers[795]);
                /* 289 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[796]);
                /* 290 PlainRuleOp      */ _letOrExpression.Set(__Matchers[797]);
                /* 291 PlainRuleOp      */ _isCondition.Set(__Matchers[798]);
                /* 292 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[799]);
                /* 293 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[800]);
                /* 294 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 295 PlainRuleOp      */ _controlStatement.Set(__Matchers[801]);
                /* 296 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[804]);
                /* 297 PlainRuleOp      */ _elseIf.Set(__Matchers[805]);
                /* 298 PlainRuleOp      */ _elseBlock.Set(__Matchers[806]);
                /* 299 PlainRuleOp      */ _switchStatement.Set(__Matchers[808]);
                /* 300 PlainRuleOp      */ _switchHeader.Set(__Matchers[810]);
                /* 301 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 302 PlainRuleOp      */ _caseBlock.Set(__Matchers[811]);
                /* 303 PlainRuleOp      */ _caseItem.Set(__Matchers[812]);
                /* 304 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[814]);
                /* 305 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[815]);
                /* 306 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 307 PlainRuleOp      */ _valueCaseList.Set(__Matchers[818]);
                /* 308 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[819]);
                /* 309 PlainRuleOp      */ _valueCase.Set(__Matchers[820]);
                /* 310 PlainRuleOp      */ _forElseStatement.Set(__Matchers[821]);
                /* 311 PlainRuleOp      */ _forBlock.Set(__Matchers[822]);
                /* 312 PlainRuleOp      */ _forIterator.Set(__Matchers[824]);
                /* 313 PlainRuleOp      */ _forVariable.Set(__Matchers[825]);
                /* 314 PlainRuleOp      */ _containment.Set(__Matchers[826]);
                /* 315 PlainRuleOp      */ _containmentOperator.Set(__Matchers[827]);
                /* 316 PlainRuleOp      */ _whileStatement.Set(__Matchers[829]);
                /* 317 PlainRuleOp      */ _tryStatement.Set(__Matchers[832]);
                /* 318 PlainRuleOp      */ _tryBlock.Set(__Matchers[835]);
                /* 319 PlainRuleOp      */ _catchBlock.Set(__Matchers[837]);
                /* 320 PlainRuleOp      */ _catchVariable.Set(__Matchers[839]);
                /* 321 PlainRuleOp      */ _finallyBlock.Set(__Matchers[841]);
                /* 322 PlainRuleOp      */ _resources.Set(__Matchers[843]);
                /* 323 PlainRuleOp      */ _resourceList.Set(__Matchers[846]);
                /* 324 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 325 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[847]);
                /* 326 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[848]);
                /* 327 PlainRuleOp      */ _variable.Set(__Matchers[851]);
                /* 328 PlainRuleOp      */ _variableType.Set(__Matchers[852]);
                /* 329 PlainRuleOp      */ _modelReference.Set(__Matchers[853]);
                /* 330 PlainRuleOp      */ _metaLiteral.Set(__Matchers[855]);
                /* 331 PlainRuleOp      */ _metaExpression.Set(__Matchers[856]);
                /* 332 PlainRuleOp      */ _modelExpression.Set(__Matchers[857]);
                /* 333 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[858]);
                /* 334 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[859]);
                /* 335 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[860]);
                /* 336 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 337 PlainRuleOp      */ _declarationReference.Set(__Matchers[861]);
                /* 338 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[863]);
                /* 339 PlainRuleOp      */ _packageLiteral.Set(__Matchers[864]);
                /* 340 PlainRuleOp      */ _classLiteral.Set(__Matchers[865]);
                /* 341 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[866]);
                /* 342 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[867]);
                /* 343 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[868]);
                /* 344 PlainRuleOp      */ _newLiteral.Set(__Matchers[869]);
                /* 345 PlainRuleOp      */ _valueLiteral.Set(__Matchers[870]);
                /* 346 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[871]);
                /* 347 PlainRuleOp      */ _functionLiteral.Set(__Matchers[872]);
                /* 348 PlainRuleOp      */ _packageQualifier.Set(__Matchers[873]);
                /* 349 PlainRuleOp      */ _referencePath.Set(__Matchers[874]);
                /* 350 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[877]);
                /* 351 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 352 PlainRuleOp      */ _kwVoid.Set(__Matchers[526]);
                /* 353 PlainRuleOp      */ _kwFunction.Set(__Matchers[528]);
                /* 354 PlainRuleOp      */ _kwValue.Set(__Matchers[531]);
                /* 355 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 356 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 357 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 358 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 359 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 360 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 361 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 362 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 363 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 364 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 365 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 367 SeqOp            */ __Matchers[367].Set(_compilationUnit, __Matchers[366]);
                /* 368 AltOp            */ __Matchers[368].Set(_moduleDescriptor, _packageDescriptor, _codeUnit);
                /* 369 SeqOp            */ __Matchers[369].Set(_imports, _namespace, _declarations);
                /* 372 SeqOp            */ __Matchers[372].Set(_annotations, __Matchers[370], _namespacePath, __Matchers[371]);
                /* 374 SeqOp            */ __Matchers[374].Set(__Matchers[373], _identifier);
                /* 375 StarOp           */ __Matchers[375].Set(__Matchers[374]);
                /* 376 SeqOp            */ __Matchers[376].Set(_identifier, __Matchers[375]);
                /* 377 StarOp           */ __Matchers[377].Set(_importDeclaration);
                /* 379 OptionalOp       */ __Matchers[379].Set(_moduleSpecifier);
                /* 380 OptionalOp       */ __Matchers[380].Set(_version);
                /* 381 SeqOp            */ __Matchers[381].Set(_annotations, __Matchers[378], _moduleName, __Matchers[379], __Matchers[380], _moduleBody);
                /* 383 OptionalOp       */ __Matchers[383].Set(_artifactAndClassifier);
                /* 384 SeqOp            */ __Matchers[384].Set(_repository, __Matchers[382], _module, __Matchers[383]);
                /* 385 AltOp            */ __Matchers[385].Set(_literalString, _moduleName);
                /* 386 OptionalOp       */ __Matchers[386].Set(_classifier);
                /* 387 SeqOp            */ __Matchers[387].Set(_artifact, __Matchers[386]);
                /* 388 SeqOp            */ __Matchers[388].Set(__Matchers[382], _literalString);
                /* 389 SeqOp            */ __Matchers[389].Set(__Matchers[382], _literalString);
                /* 391 StarOp           */ __Matchers[391].Set(_moduleBodyElement);
                /* 393 SeqOp            */ __Matchers[393].Set(__Matchers[390], __Matchers[391], __Matchers[392]);
                /* 394 AltOp            */ __Matchers[394].Set(_inferredAttributeDeclaration, _moduleImport);
                /* 396 SeqOp            */ __Matchers[396].Set(_annotations, __Matchers[395], _module, __Matchers[380], __Matchers[371]);
                /* 398 SeqOp            */ __Matchers[398].Set(_annotations, __Matchers[397], _packagePath, __Matchers[371]);
                /* 399 SeqOp            */ __Matchers[399].Set(__Matchers[395], _packagePath, _importElements);
                /* 400 OptionalOp       */ __Matchers[400].Set(_importElementList);
                /* 401 SeqOp            */ __Matchers[401].Set(__Matchers[390], __Matchers[400], __Matchers[392]);
                /* 403 SeqOp            */ __Matchers[403].Set(__Matchers[402], _importElement);
                /* 404 StarOp           */ __Matchers[404].Set(__Matchers[403]);
                /* 405 SeqOp            */ __Matchers[405].Set(_importElement, __Matchers[404]);
                /* 406 AltOp            */ __Matchers[406].Set(_importNamed, _importWildcard);
                /* 407 OptionalOp       */ __Matchers[407].Set(_importNameSpecifier);
                /* 408 OptionalOp       */ __Matchers[408].Set(_importElements);
                /* 409 SeqOp            */ __Matchers[409].Set(_importName, __Matchers[407], __Matchers[408]);
                /* 411 SeqOp            */ __Matchers[411].Set(__Matchers[410], _identifier);
                /* 413 SeqOp            */ __Matchers[413].Set(__Matchers[373], _packageName);
                /* 414 StarOp           */ __Matchers[414].Set(__Matchers[413]);
                /* 415 SeqOp            */ __Matchers[415].Set(_packageName, __Matchers[414]);
                /* 416 AltOp            */ __Matchers[416].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 417 AltOp            */ __Matchers[417].Set(_tuplePattern, _variablePattern);
                /* 418 AltOp            */ __Matchers[418].Set(_entryPattern, _tuplePattern);
                /* 420 SeqOp            */ __Matchers[420].Set(_variableOrTuplePattern, __Matchers[419], _variableOrTuplePattern);
                /* 422 OptionalOp       */ __Matchers[422].Set(_variadicPatternList);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[421], __Matchers[422], __Matchers[423]);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[402], _variadicPattern);
                /* 426 StarOp           */ __Matchers[426].Set(__Matchers[425]);
                /* 427 SeqOp            */ __Matchers[427].Set(_variadicPattern, __Matchers[426]);
                /* 428 AltOp            */ __Matchers[428].Set(_variadicVariable, _pattern);
                /* 429 OptionalOp       */ __Matchers[429].Set(_unionType);
                /* 430 SeqOp            */ __Matchers[430].Set(__Matchers[429], _variadicOperator, _memberName);
                /* 434 SeqOp            */ __Matchers[434].Set(__Matchers[431], __Matchers[432], _letVariableList, __Matchers[433]);
                /* 435 SeqOp            */ __Matchers[435].Set(__Matchers[402], _letVariable);
                /* 436 StarOp           */ __Matchers[436].Set(__Matchers[435]);
                /* 437 SeqOp            */ __Matchers[437].Set(_letVariable, __Matchers[436]);
                /* 438 SeqOp            */ __Matchers[438].Set(_pattern, _valueSpecifier);
                /* 440 SeqOp            */ __Matchers[440].Set(__Matchers[439], _classInstatiation);
                /* 441 OptionalOp       */ __Matchers[441].Set(_assertionMessage);
                /* 443 SeqOp            */ __Matchers[443].Set(__Matchers[441], __Matchers[442], _conditions);
                /* 444 SeqOp            */ __Matchers[444].Set(__Matchers[390], _imports, _statements, __Matchers[392]);
                /* 445 SeqOp            */ __Matchers[445].Set(__Matchers[439], _classInstatiation);
                /* 447 SeqOp            */ __Matchers[447].Set(__Matchers[446], _classInstatiation);
                /* 448 OptionalOp       */ __Matchers[448].Set(_arguments);
                /* 449 SeqOp            */ __Matchers[449].Set(_qualifiedClass, __Matchers[448]);
                /* 450 AltOp            */ __Matchers[450].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 451 SeqOp            */ __Matchers[451].Set(__Matchers[397], __Matchers[373], _unQualifiedClass);
                /* 453 SeqOp            */ __Matchers[453].Set(__Matchers[452], __Matchers[373], _baseReference);
                /* 454 AltOp            */ __Matchers[454].Set(_memberPath, _typePath, _memberReference);
                /* 455 SeqOp            */ __Matchers[455].Set(_typePath, __Matchers[373], _memberReference);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[373], _typeReference);
                /* 457 StarOp           */ __Matchers[457].Set(__Matchers[456]);
                /* 458 SeqOp            */ __Matchers[458].Set(_typeReference, __Matchers[457]);
                /* 460 SeqOp            */ __Matchers[460].Set(__Matchers[459], _unionTypeList);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[402], _unionType);
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
                /* 474 SeqOp            */ __Matchers[474].Set(__Matchers[432], __Matchers[473], __Matchers[433]);
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[402], _parameterDeclarationOrRefPattern);
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
                /* 493 SeqOp            */ __Matchers[493].Set(__Matchers[402], _typeParameter);
                /* 494 StarOp           */ __Matchers[494].Set(__Matchers[493]);
                /* 495 SeqOp            */ __Matchers[495].Set(_typeParameter, __Matchers[494]);
                /* 496 OptionalOp       */ __Matchers[496].Set(_variance);
                /* 497 OptionalOp       */ __Matchers[497].Set(_typeDefault);
                /* 498 SeqOp            */ __Matchers[498].Set(__Matchers[496], _typeName, __Matchers[497]);
                /* 501 AltOp            */ __Matchers[501].Set(__Matchers[499], __Matchers[500]);
                /* 502 SeqOp            */ __Matchers[502].Set(__Matchers[410], _type);
                /* 504 OptionalOp       */ __Matchers[504].Set(_typeName);
                /* 505 OptionalOp       */ __Matchers[505].Set(_caseTypes);
                /* 506 OptionalOp       */ __Matchers[506].Set(_satisfiedTypes);
                /* 507 SeqOp            */ __Matchers[507].Set(__Matchers[503], __Matchers[504], __Matchers[483], __Matchers[505], __Matchers[506]);
                /* 508 PlusOp           */ __Matchers[508].Set(_typeConstraint);
                /* 509 StarOp           */ __Matchers[509].Set(_declaration);
                /* 510 AltOp            */ __Matchers[510].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 512 OptionalOp       */ __Matchers[512].Set(_memberName);
                /* 513 OptionalOp       */ __Matchers[513].Set(_delegatedConstructor);
                /* 514 SeqOp            */ __Matchers[514].Set(_annotations, __Matchers[511], __Matchers[512], _parameters, __Matchers[513], _block);
                /* 516 OptionalOp       */ __Matchers[516].Set(_typeConstraints);
                /* 517 SeqOp            */ __Matchers[517].Set(_annotations, __Matchers[515], _typeName, __Matchers[483], __Matchers[516], _optionalTypeSpecifier);
                /* 518 SeqOp            */ __Matchers[518].Set(_annotations, __Matchers[511], _memberName, __Matchers[513], _block);
                /* 520 OptionalOp       */ __Matchers[520].Set(_extendedType);
                /* 521 SeqOp            */ __Matchers[521].Set(_annotations, __Matchers[519], _memberName, __Matchers[520], __Matchers[506], _block);
                /* 523 SeqOp            */ __Matchers[523].Set(_annotations, __Matchers[522], _memberName, _setterDefinition);
                /* 524 AltOp            */ __Matchers[524].Set(_block, _requiredFunctionSpecifier);
                /* 525 SeqOp            */ __Matchers[525].Set(_annotations, _variadicType, _memberName, __Matchers[483], __Matchers[484], __Matchers[516], _methodDefinition);
                /* 527 SeqOp            */ __Matchers[527].Set(_annotations, __Matchers[526], _memberName, __Matchers[483], __Matchers[484], __Matchers[516], _methodDefinition);
                /* 529 SeqOp            */ __Matchers[529].Set(_annotations, __Matchers[528], _memberName, __Matchers[483], __Matchers[484], __Matchers[516], _methodDefinition);
                /* 530 SeqOp            */ __Matchers[530].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 532 SeqOp            */ __Matchers[532].Set(_annotations, __Matchers[531], _memberName, _attributeDefinition);
                /* 533 AltOp            */ __Matchers[533].Set(_block, _optionalAnySpecifier);
                /* 534 OptionalOp       */ __Matchers[534].Set(_anySpecifier);
                /* 535 SeqOp            */ __Matchers[535].Set(__Matchers[534], __Matchers[371]);
                /* 537 OptionalOp       */ __Matchers[537].Set(_parameters);
                /* 538 SeqOp            */ __Matchers[538].Set(_annotations, __Matchers[536], _typeName, __Matchers[483], __Matchers[537], __Matchers[505], __Matchers[520], __Matchers[506], __Matchers[516], _classDefinition);
                /* 539 AltOp            */ __Matchers[539].Set(_block, _optionalClassSpecifier);
                /* 540 OptionalOp       */ __Matchers[540].Set(_classSpecifier);
                /* 541 SeqOp            */ __Matchers[541].Set(__Matchers[540], __Matchers[371]);
                /* 543 SeqOp            */ __Matchers[543].Set(_annotations, __Matchers[542], _typeName, __Matchers[483], __Matchers[505], __Matchers[506], __Matchers[516], _interfaceDefinition);
                /* 544 AltOp            */ __Matchers[544].Set(_block, _optionalTypeSpecifier);
                /* 545 OptionalOp       */ __Matchers[545].Set(_typeSpecifier);
                /* 546 SeqOp            */ __Matchers[546].Set(__Matchers[545], __Matchers[371]);
                /* 547 StarOp           */ __Matchers[547].Set(_statement);
                /* 548 AltOp            */ __Matchers[548].Set(_declarationStatement, _unclosedStatement, _controlStatement);
                /* 549 SeqOp            */ __Matchers[549].Set(_openStatement, __Matchers[371]);
                /* 550 AltOp            */ __Matchers[550].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 551 SeqOp            */ __Matchers[551].Set(_primary, _functionSpecifier);
                /* 552 AltOp            */ __Matchers[552].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 554 OptionalOp       */ __Matchers[554].Set(_expression);
                /* 555 SeqOp            */ __Matchers[555].Set(__Matchers[553], __Matchers[554]);
                /* 557 SeqOp            */ __Matchers[557].Set(__Matchers[556], __Matchers[554]);
                /* 560 SeqOp            */ __Matchers[560].Set(__Matchers[446], _type);
                /* 561 SeqOp            */ __Matchers[561].Set(__Matchers[410], _expression);
                /* 562 SeqOp            */ __Matchers[562].Set(__Matchers[446], _expression);
                /* 563 AltOp            */ __Matchers[563].Set(_valueSpecifier, _functionSpecifier);
                /* 564 AltOp            */ __Matchers[564].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 565 AltOp            */ __Matchers[565].Set(_memberReference, _typeReference);
                /* 566 SeqOp            */ __Matchers[566].Set(_memberName, __Matchers[483], __Matchers[484]);
                /* 567 SeqOp            */ __Matchers[567].Set(_selfReferenceSelector, _parametrizedMember);
                /* 568 OptionalOp       */ __Matchers[568].Set(_typeArguments);
                /* 569 SeqOp            */ __Matchers[569].Set(_memberName, __Matchers[568]);
                /* 570 SeqOp            */ __Matchers[570].Set(_typeName, __Matchers[568]);
                /* 571 SeqOp            */ __Matchers[571].Set(_selfReference, _memberSelectionOperator);
                /* 574 AltOp            */ __Matchers[574].Set(__Matchers[572], __Matchers[452], __Matchers[573], __Matchers[397]);
                /* 575 OptionalOp       */ __Matchers[575].Set(_sequencedArgumentList);
                /* 576 SeqOp            */ __Matchers[576].Set(__Matchers[390], _statements, __Matchers[575], __Matchers[392]);
                /* 577 SeqOp            */ __Matchers[577].Set(__Matchers[421], __Matchers[575], __Matchers[423]);
                /* 578 AltOp            */ __Matchers[578].Set(_patternedArguments, _positionalArguments);
                /* 579 StarOp           */ __Matchers[579].Set(_structuredArgument);
                /* 580 SeqOp            */ __Matchers[580].Set(__Matchers[390], __Matchers[579], __Matchers[575], __Matchers[392]);
                /* 581 SeqOp            */ __Matchers[581].Set(__Matchers[432], __Matchers[575], __Matchers[433]);
                /* 582 AltOp            */ __Matchers[582].Set(_anonymousArgument, _namedArgument);
                /* 583 SeqOp            */ __Matchers[583].Set(_expression, __Matchers[371]);
                /* 584 AltOp            */ __Matchers[584].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 585 SeqOp            */ __Matchers[585].Set(_memberName, _valueSpecifier, __Matchers[371]);
                /* 586 SeqOp            */ __Matchers[586].Set(__Matchers[402], _sequencedArgument);
                /* 587 StarOp           */ __Matchers[587].Set(__Matchers[586]);
                /* 588 SeqOp            */ __Matchers[588].Set(_sequencedArgument, __Matchers[587]);
                /* 589 AltOp            */ __Matchers[589].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 590 AltOp            */ __Matchers[590].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 591 SeqOp            */ __Matchers[591].Set(__Matchers[519], __Matchers[512], __Matchers[520], __Matchers[506], _block);
                /* 592 SeqOp            */ __Matchers[592].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 593 AltOp            */ __Matchers[593].Set(_block, _optionalFunctionSpecifier);
                /* 594 SeqOp            */ __Matchers[594].Set(__Matchers[485], __Matchers[371]);
                /* 595 SeqOp            */ __Matchers[595].Set(_functionSpecifier, __Matchers[371]);
                /* 596 AltOp            */ __Matchers[596].Set(_type, _kwVoid);
                /* 597 SeqOp            */ __Matchers[597].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 598 SeqOp            */ __Matchers[598].Set(__Matchers[528], __Matchers[512], __Matchers[483], _parameters, _methodDefinition);
                /* 599 SeqOp            */ __Matchers[599].Set(__Matchers[531], _memberName, _methodDefinition);
                /* 600 SeqOp            */ __Matchers[600].Set(_memberName, __Matchers[484], _requiredFunctionSpecifier);
                /* 601 SeqOp            */ __Matchers[601].Set(_memberName, _requiredFunctionSpecifier);
                /* 602 AltOp            */ __Matchers[602].Set(_expressionArgument, _declarationReference);
                /* 604 SeqOp            */ __Matchers[604].Set(__Matchers[603], _unionExpression);
                /* 605 OptionalOp       */ __Matchers[605].Set(_letVariableList);
                /* 606 SeqOp            */ __Matchers[606].Set(__Matchers[431], __Matchers[432], __Matchers[605], __Matchers[433], _conditionalExpression);
                /* 607 SeqOp            */ __Matchers[607].Set(_switchHeader, _caseExpressions);
                /* 608 PlusOp           */ __Matchers[608].Set(_caseExpression);
                /* 609 OptionalOp       */ __Matchers[609].Set(_elseExpression);
                /* 610 SeqOp            */ __Matchers[610].Set(__Matchers[608], __Matchers[609]);
                /* 612 OptionalOp       */ __Matchers[612].Set(__Matchers[611]);
                /* 614 SeqOp            */ __Matchers[614].Set(__Matchers[612], __Matchers[613], __Matchers[432], _caseItem, __Matchers[433], _conditionalExpression);
                /* 616 SeqOp            */ __Matchers[616].Set(__Matchers[615], _conditions, _thenExpression, _elseExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[611], _conditionalExpression);
                /* 619 SeqOp            */ __Matchers[619].Set(__Matchers[618], _conditionalExpression);
                /* 620 AltOp            */ __Matchers[620].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 621 OptionalOp       */ __Matchers[621].Set(_functionExpressionType);
                /* 622 OptionalOp       */ __Matchers[622].Set(_functionParameters);
                /* 623 SeqOp            */ __Matchers[623].Set(__Matchers[621], __Matchers[483], __Matchers[622], _functionDefinition);
                /* 624 AltOp            */ __Matchers[624].Set(__Matchers[526], __Matchers[528]);
                /* 625 SeqOp            */ __Matchers[625].Set(__Matchers[484], __Matchers[516]);
                /* 626 AltOp            */ __Matchers[626].Set(_block, _functionSpecifier);
                /* 627 AltOp            */ __Matchers[627].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 628 AltOp            */ __Matchers[628].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 630 OptionalOp       */ __Matchers[630].Set(_forIterator);
                /* 631 SeqOp            */ __Matchers[631].Set(__Matchers[629], __Matchers[432], __Matchers[630], __Matchers[433], _comprehensionClause);
                /* 632 SeqOp            */ __Matchers[632].Set(__Matchers[615], _conditions, _comprehensionClause);
                /* 633 AltOp            */ __Matchers[633].Set(_letExpr, _ifExpr, _switchExpr, _functionExpr, _operatorExpression);
                /* 634 AltOp            */ __Matchers[634].Set(_assignmentExpr, _thenElseExpression);
                /* 635 SeqOp            */ __Matchers[635].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 647 AltOp            */ __Matchers[647].Set(__Matchers[410], __Matchers[636], __Matchers[637], __Matchers[638], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646]);
                /* 648 AltOp            */ __Matchers[648].Set(_thenElseExpr, _disjunctionExpression);
                /* 649 SeqOp            */ __Matchers[649].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 650 AltOp            */ __Matchers[650].Set(__Matchers[611], __Matchers[618]);
                /* 651 AltOp            */ __Matchers[651].Set(_disjunctionExpr, _conjunctionExpression);
                /* 652 SeqOp            */ __Matchers[652].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 654 AltOp            */ __Matchers[654].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 655 SeqOp            */ __Matchers[655].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 657 AltOp            */ __Matchers[657].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 658 SeqOp            */ __Matchers[658].Set(_notOperator, _logicalNegationExpression);
                /* 660 AltOp            */ __Matchers[660].Set(_equalityExpression, _modelReference);
                /* 661 AltOp            */ __Matchers[661].Set(_equalityExpr, _comparisonExpression);
                /* 662 SeqOp            */ __Matchers[662].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 666 AltOp            */ __Matchers[666].Set(__Matchers[663], __Matchers[664], __Matchers[665]);
                /* 667 AltOp            */ __Matchers[667].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 668 SeqOp            */ __Matchers[668].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 669 SeqOp            */ __Matchers[669].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 670 SeqOp            */ __Matchers[670].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 672 SeqOp            */ __Matchers[672].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 673 SeqOp            */ __Matchers[673].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 675 AltOp            */ __Matchers[675].Set(__Matchers[674], __Matchers[499]);
                /* 677 AltOp            */ __Matchers[677].Set(__Matchers[676], __Matchers[490]);
                /* 679 AltOp            */ __Matchers[679].Set(__Matchers[678], __Matchers[491]);
                /* 681 AltOp            */ __Matchers[681].Set(__Matchers[680], __Matchers[439], __Matchers[459], __Matchers[464]);
                /* 682 AltOp            */ __Matchers[682].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 684 SeqOp            */ __Matchers[684].Set(_entryRangeExpression, __Matchers[683]);
                /* 686 SeqOp            */ __Matchers[686].Set(_entryRangeExpression, __Matchers[685]);
                /* 687 AltOp            */ __Matchers[687].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 688 SeqOp            */ __Matchers[688].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 689 SeqOp            */ __Matchers[689].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 691 AltOp            */ __Matchers[691].Set(__Matchers[690], __Matchers[382]);
                /* 692 AltOp            */ __Matchers[692].Set(_additiveExpr, _scaleExpression);
                /* 693 SeqOp            */ __Matchers[693].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 696 AltOp            */ __Matchers[696].Set(__Matchers[694], __Matchers[695]);
                /* 697 AltOp            */ __Matchers[697].Set(_scaleExpr, _multiplicativeExpression);
                /* 698 SeqOp            */ __Matchers[698].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 700 AltOp            */ __Matchers[700].Set(_multiplicativeExpr, _unionExpression);
                /* 701 SeqOp            */ __Matchers[701].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 704 AltOp            */ __Matchers[704].Set(__Matchers[603], __Matchers[702], __Matchers[703]);
                /* 705 AltOp            */ __Matchers[705].Set(_unionExpr, _exclusiveExpression);
                /* 706 SeqOp            */ __Matchers[706].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 708 AltOp            */ __Matchers[708].Set(__Matchers[466], __Matchers[707]);
                /* 709 AltOp            */ __Matchers[709].Set(_exclusiveExpr, _intersectionExpression);
                /* 710 SeqOp            */ __Matchers[710].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 712 AltOp            */ __Matchers[712].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 713 SeqOp            */ __Matchers[713].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 715 AltOp            */ __Matchers[715].Set(_negationOrComplementExpr, _prefixExpression);
                /* 716 SeqOp            */ __Matchers[716].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 717 AltOp            */ __Matchers[717].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 718 NotOp            */ __Matchers[718].Set(__Matchers_718_DFA);
                /* 719 SeqOp            */ __Matchers[719].Set(__Matchers[695], __Matchers[718]);
                /* 720 NotOp            */ __Matchers[720].Set(__Matchers_720_DFA);
                /* 721 SeqOp            */ __Matchers[721].Set(__Matchers[694], __Matchers[720]);
                /* 722 AltOp            */ __Matchers[722].Set(_prefixExpr, _postfixExpression);
                /* 723 SeqOp            */ __Matchers[723].Set(_incrementOperator, _prefixExpression);
                /* 724 AltOp            */ __Matchers[724].Set(_postfixExpr, _primary);
                /* 725 SeqOp            */ __Matchers[725].Set(_postfixExpression, _incrementOperator);
                /* 728 AltOp            */ __Matchers[728].Set(__Matchers[726], __Matchers[727]);
                /* 729 AltOp            */ __Matchers[729].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 730 SeqOp            */ __Matchers[730].Set(_primary, _memberSelectionOperator, _baseReference);
                /* 733 AltOp            */ __Matchers[733].Set(__Matchers[373], __Matchers[731], __Matchers[732]);
                /* 734 SeqOp            */ __Matchers[734].Set(_primary, __Matchers[421], _index, __Matchers[423]);
                /* 735 AltOp            */ __Matchers[735].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 736 SeqOp            */ __Matchers[736].Set(_indexExpression, __Matchers[412]);
                /* 737 SeqOp            */ __Matchers[737].Set(__Matchers[412], _indexExpression);
                /* 738 SeqOp            */ __Matchers[738].Set(_indexExpression, __Matchers[690], _indexExpression);
                /* 739 SeqOp            */ __Matchers[739].Set(_indexExpression, __Matchers[382], _indexExpression);
                /* 740 SeqOp            */ __Matchers[740].Set(_primary, _arguments);
                /* 741 AltOp            */ __Matchers[741].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 742 AltOp            */ __Matchers[742].Set(_literalNatural, _literalFloat, _literalChar);
                /* 743 AltOp            */ __Matchers[743].Set(_stringLiteral, _stringInterpolation);
                /* 744 StarOp           */ __Matchers[744].Set(_interpolationPart);
                /* 745 SeqOp            */ __Matchers[745].Set(_stringStart, _expression, __Matchers[744], _stringEnd);
                /* 746 SeqOp            */ __Matchers[746].Set(_stringMid, _expression);
                /* 747 AltOp            */ __Matchers[747].Set(_literalString, _verbatimString);
                /* 748 SeqOp            */ __Matchers[748].Set(__Matchers[519], __Matchers[520], __Matchers[506], _block);
                /* 749 SeqOp            */ __Matchers[749].Set(__Matchers[432], _expression, __Matchers[433]);
                /* 750 OptionalOp       */ __Matchers[750].Set(_typeArgumentList);
                /* 751 SeqOp            */ __Matchers[751].Set(__Matchers[490], __Matchers[750], __Matchers[491]);
                /* 752 SeqOp            */ __Matchers[752].Set(__Matchers[402], _variancedType);
                /* 753 StarOp           */ __Matchers[753].Set(__Matchers[752]);
                /* 754 SeqOp            */ __Matchers[754].Set(_variancedType, __Matchers[753]);
                /* 755 SeqOp            */ __Matchers[755].Set(__Matchers[496], _type);
                /* 756 SeqOp            */ __Matchers[756].Set(__Matchers[402], _defaultedType);
                /* 757 StarOp           */ __Matchers[757].Set(__Matchers[756]);
                /* 758 SeqOp            */ __Matchers[758].Set(_defaultedType, __Matchers[757]);
                /* 759 AltOp            */ __Matchers[759].Set(_defaultedTypeCore, _variadicType);
                /* 760 SeqOp            */ __Matchers[760].Set(_type, __Matchers[410]);
                /* 761 AltOp            */ __Matchers[761].Set(_variadicUnionType, _type);
                /* 762 SeqOp            */ __Matchers[762].Set(_unionType, _variadicOperator);
                /* 763 AltOp            */ __Matchers[763].Set(__Matchers[603], __Matchers[694]);
                /* 764 SeqOp            */ __Matchers[764].Set(__Matchers[603], _unionType);
                /* 765 AltOp            */ __Matchers[765].Set(_entryType, _unionType);
                /* 766 SeqOp            */ __Matchers[766].Set(_unionType, __Matchers[419], _unionType);
                /* 767 AltOp            */ __Matchers[767].Set(_unionTypeCore, _intersectionType);
                /* 768 SeqOp            */ __Matchers[768].Set(_unionType, __Matchers[466], _intersectionType);
                /* 769 AltOp            */ __Matchers[769].Set(_intersectionTypeCore, _primaryType);
                /* 770 SeqOp            */ __Matchers[770].Set(_intersectionType, __Matchers[714], _primaryType);
                /* 771 AltOp            */ __Matchers[771].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 773 SeqOp            */ __Matchers[773].Set(_primaryType, __Matchers[772]);
                /* 774 OptionalOp       */ __Matchers[774].Set(_literalNatural);
                /* 775 SeqOp            */ __Matchers[775].Set(_primaryType, __Matchers[421], __Matchers[774], __Matchers[423]);
                /* 776 OptionalOp       */ __Matchers[776].Set(_typeTypeArguments);
                /* 777 SeqOp            */ __Matchers[777].Set(_primaryType, __Matchers[432], __Matchers[776], __Matchers[433]);
                /* 778 AltOp            */ __Matchers[778].Set(_spreadType, _defaultedTypeList);
                /* 779 SeqOp            */ __Matchers[779].Set(__Matchers[421], __Matchers[776], __Matchers[423]);
                /* 780 OptionalOp       */ __Matchers[780].Set(_variadicType);
                /* 781 SeqOp            */ __Matchers[781].Set(__Matchers[390], __Matchers[780], __Matchers[392]);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[490], _type, __Matchers[491]);
                /* 783 SeqOp            */ __Matchers[783].Set(__Matchers[397], __Matchers[373], _typePath);
                /* 784 OptionalOp       */ __Matchers[784].Set(_stringLiteral);
                /* 785 StarOp           */ __Matchers[785].Set(_annotation);
                /* 786 SeqOp            */ __Matchers[786].Set(__Matchers[784], __Matchers[785]);
                /* 787 SeqOp            */ __Matchers[787].Set(_memberName, __Matchers[448]);
                /* 788 OptionalOp       */ __Matchers[788].Set(_conditionList);
                /* 789 SeqOp            */ __Matchers[789].Set(__Matchers[432], __Matchers[788], __Matchers[433]);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[402], _condition);
                /* 791 StarOp           */ __Matchers[791].Set(__Matchers[790]);
                /* 792 SeqOp            */ __Matchers[792].Set(_condition, __Matchers[791]);
                /* 793 AltOp            */ __Matchers[793].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 794 OptionalOp       */ __Matchers[794].Set(__Matchers[659]);
                /* 795 SeqOp            */ __Matchers[795].Set(__Matchers[794], __Matchers[683], _letOrExpression);
                /* 796 SeqOp            */ __Matchers[796].Set(__Matchers[794], __Matchers[685], _letOrExpression);
                /* 797 AltOp            */ __Matchers[797].Set(_letVariable, _operatorExpression);
                /* 798 SeqOp            */ __Matchers[798].Set(__Matchers[794], __Matchers[680], _type, _isConditionVariable);
                /* 799 SeqOp            */ __Matchers[799].Set(_memberName, __Matchers[480]);
                /* 800 SeqOp            */ __Matchers[800].Set(__Matchers[459], _type, _typeName);
                /* 801 AltOp            */ __Matchers[801].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 802 StarOp           */ __Matchers[802].Set(_elseIf);
                /* 803 OptionalOp       */ __Matchers[803].Set(_elseBlock);
                /* 804 SeqOp            */ __Matchers[804].Set(__Matchers[615], _conditions, _block, __Matchers[802], __Matchers[803]);
                /* 805 SeqOp            */ __Matchers[805].Set(__Matchers[611], __Matchers[615], _conditions, _block);
                /* 806 SeqOp            */ __Matchers[806].Set(__Matchers[611], _block);
                /* 807 PlusOp           */ __Matchers[807].Set(_caseBlock);
                /* 808 SeqOp            */ __Matchers[808].Set(_switchHeader, __Matchers[807], __Matchers[803]);
                /* 810 SeqOp            */ __Matchers[810].Set(__Matchers[809], __Matchers[432], _switched, __Matchers[433]);
                /* 811 SeqOp            */ __Matchers[811].Set(__Matchers[612], __Matchers[613], __Matchers[432], _caseItem, __Matchers[433], _block);
                /* 812 AltOp            */ __Matchers[812].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 813 OptionalOp       */ __Matchers[813].Set(__Matchers[680]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[813], _type);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[459], _type);
                /* 816 SeqOp            */ __Matchers[816].Set(_valueCaseSeparator, _valueCase);
                /* 817 StarOp           */ __Matchers[817].Set(__Matchers[816]);
                /* 818 SeqOp            */ __Matchers[818].Set(_valueCase, __Matchers[817]);
                /* 819 AltOp            */ __Matchers[819].Set(__Matchers[402], __Matchers[466]);
                /* 820 AltOp            */ __Matchers[820].Set(_intersectionType, _intersectionExpression);
                /* 821 SeqOp            */ __Matchers[821].Set(_forBlock, __Matchers[803]);
                /* 822 SeqOp            */ __Matchers[822].Set(__Matchers[629], __Matchers[432], __Matchers[630], __Matchers[433], _block);
                /* 823 OptionalOp       */ __Matchers[823].Set(_containment);
                /* 824 SeqOp            */ __Matchers[824].Set(_forVariable, __Matchers[823]);
                /* 825 AltOp            */ __Matchers[825].Set(_tupleOrEntryPattern, _variable);
                /* 826 SeqOp            */ __Matchers[826].Set(_containmentOperator, _operatorExpression);
                /* 827 AltOp            */ __Matchers[827].Set(__Matchers[499], __Matchers[382]);
                /* 829 SeqOp            */ __Matchers[829].Set(__Matchers[828], _conditions, _block);
                /* 830 StarOp           */ __Matchers[830].Set(_catchBlock);
                /* 831 OptionalOp       */ __Matchers[831].Set(_finallyBlock);
                /* 832 SeqOp            */ __Matchers[832].Set(_tryBlock, __Matchers[830], __Matchers[831]);
                /* 834 OptionalOp       */ __Matchers[834].Set(_resources);
                /* 835 SeqOp            */ __Matchers[835].Set(__Matchers[833], __Matchers[834], _block);
                /* 837 SeqOp            */ __Matchers[837].Set(__Matchers[836], _catchVariable, _block);
                /* 838 OptionalOp       */ __Matchers[838].Set(_variable);
                /* 839 SeqOp            */ __Matchers[839].Set(__Matchers[432], __Matchers[838], __Matchers[433]);
                /* 841 SeqOp            */ __Matchers[841].Set(__Matchers[840], _block);
                /* 842 OptionalOp       */ __Matchers[842].Set(_resourceList);
                /* 843 SeqOp            */ __Matchers[843].Set(__Matchers[432], __Matchers[842], __Matchers[433]);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[402], _resource);
                /* 845 StarOp           */ __Matchers[845].Set(__Matchers[844]);
                /* 846 SeqOp            */ __Matchers[846].Set(_resource, __Matchers[845]);
                /* 847 AltOp            */ __Matchers[847].Set(_specifiedVariable, _operatorExpression);
                /* 848 SeqOp            */ __Matchers[848].Set(_variable, _valueSpecifier);
                /* 849 OptionalOp       */ __Matchers[849].Set(_variableType);
                /* 850 StarOp           */ __Matchers[850].Set(_parameters);
                /* 851 SeqOp            */ __Matchers[851].Set(__Matchers[849], _memberName, __Matchers[850]);
                /* 852 AltOp            */ __Matchers[852].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 853 SeqOp            */ __Matchers[853].Set(__Matchers[711], _modelExpression);
                /* 855 SeqOp            */ __Matchers[855].Set(__Matchers[854], _metaExpression, __Matchers[854]);
                /* 856 AltOp            */ __Matchers[856].Set(_declarationReference, _modelExpression);
                /* 857 AltOp            */ __Matchers[857].Set(_memberModelExpression, _typeModelExpression);
                /* 858 AltOp            */ __Matchers[858].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 859 SeqOp            */ __Matchers[859].Set(__Matchers[397], __Matchers[373], _memberReference);
                /* 860 SeqOp            */ __Matchers[860].Set(_primaryType, __Matchers[373], _memberReference);
                /* 861 AltOp            */ __Matchers[861].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 862 OptionalOp       */ __Matchers[862].Set(_packagePath);
                /* 863 SeqOp            */ __Matchers[863].Set(__Matchers[378], __Matchers[862]);
                /* 864 SeqOp            */ __Matchers[864].Set(__Matchers[397], __Matchers[862]);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[536], _referencePath);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[542], _referencePath);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[515], _referencePath);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[503], _referencePath);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[511], _referencePath);
                /* 870 SeqOp            */ __Matchers[870].Set(_valueLiteralIntro, _referencePath);
                /* 871 AltOp            */ __Matchers[871].Set(__Matchers[531], __Matchers[519]);
                /* 872 SeqOp            */ __Matchers[872].Set(__Matchers[528], _referencePath);
                /* 873 SeqOp            */ __Matchers[873].Set(__Matchers[397], __Matchers[373]);
                /* 874 SeqOp            */ __Matchers[874].Set(__Matchers[471], _referencePathElementList);
                /* 875 SeqOp            */ __Matchers[875].Set(__Matchers[373], _referencePathElement);
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
                    new DfaState(79, true),
                    new DfaState(80, true),
                    new DfaState(81, true),
                    new DfaState(82, true),
                    new DfaState(83, false),
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
                    new DfaState(108, true),
                    new DfaState(109, true),
                    new DfaState(110, true),
                    new DfaState(111, true),
                    new DfaState(112, true)
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
                    new DfaTrans(_lowerIdentifier_DFA.States[78], new DfaInterval(111, 111)),
                    new DfaTrans(_lowerIdentifier_DFA.States[84], new DfaInterval(112, 112)),
                    new DfaTrans(_lowerIdentifier_DFA.States[89], new DfaInterval(114, 114)),
                    new DfaTrans(_lowerIdentifier_DFA.States[93], new DfaInterval(115, 115)),
                    new DfaTrans(_lowerIdentifier_DFA.States[104], new DfaInterval(116, 116)),
                    new DfaTrans(_lowerIdentifier_DFA.States[107], new DfaInterval(118, 118)),
                    new DfaTrans(_lowerIdentifier_DFA.States[111], new DfaInterval(119, 119))
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
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 100), new DfaInterval(102, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[68], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[72], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[73], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[68].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[69], new DfaInterval(109, 109))
                );
                _lowerIdentifier_DFA.States[69].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[70], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[70].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[71], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[71].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[60], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[72].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(119, 119))
                );
                _lowerIdentifier_DFA.States[73].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[74], new DfaInterval(110, 110))
                );
                _lowerIdentifier_DFA.States[74].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[75], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[75].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[76], new DfaInterval(109, 109))
                );
                _lowerIdentifier_DFA.States[76].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[77], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[77].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[43], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[78].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[79], new DfaInterval(98, 98)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(102, 102)),
                    new DfaTrans(_lowerIdentifier_DFA.States[82], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[79].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[80], new DfaInterval(106, 106))
                );
                _lowerIdentifier_DFA.States[80].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[81], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[81].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[11], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[82].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[83], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[83].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[84].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[85], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[85].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[86], new DfaInterval(99, 99))
                );
                _lowerIdentifier_DFA.States[86].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 106), new DfaInterval(108, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[87], new DfaInterval(107, 107))
                );
                _lowerIdentifier_DFA.States[87].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[88], new DfaInterval(97, 97))
                );
                _lowerIdentifier_DFA.States[88].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[20], new DfaInterval(103, 103))
                );
                _lowerIdentifier_DFA.States[89].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[90], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[90].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[91], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[91].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[92], new DfaInterval(117, 117))
                );
                _lowerIdentifier_DFA.States[92].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[93].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 116), new DfaInterval(118, 118), new DfaInterval(120, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[94], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[100], new DfaInterval(117, 117)),
                    new DfaTrans(_lowerIdentifier_DFA.States[102], new DfaInterval(119, 119))
                );
                _lowerIdentifier_DFA.States[94].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[95], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[95].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[96], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[96].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[97], new DfaInterval(115, 115))
                );
                _lowerIdentifier_DFA.States[97].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[98], new DfaInterval(102, 102))
                );
                _lowerIdentifier_DFA.States[98].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[99], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[99].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[100].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[101], new DfaInterval(112, 112))
                );
                _lowerIdentifier_DFA.States[101].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[44], new DfaInterval(101, 101))
                );
                _lowerIdentifier_DFA.States[102].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[103], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[103].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[21], new DfaInterval(116, 116))
                );
                _lowerIdentifier_DFA.States[104].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[105], new DfaInterval(104, 104)),
                    new DfaTrans(_lowerIdentifier_DFA.States[43], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[105].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 104), new DfaInterval(106, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[13], new DfaInterval(101, 101)),
                    new DfaTrans(_lowerIdentifier_DFA.States[7], new DfaInterval(105, 105)),
                    new DfaTrans(_lowerIdentifier_DFA.States[106], new DfaInterval(114, 114))
                );
                _lowerIdentifier_DFA.States[106].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[72], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[107].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[108], new DfaInterval(97, 97)),
                    new DfaTrans(_lowerIdentifier_DFA.States[109], new DfaInterval(111, 111))
                );
                _lowerIdentifier_DFA.States[108].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[29], new DfaInterval(108, 108))
                );
                _lowerIdentifier_DFA.States[109].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[110], new DfaInterval(105, 105))
                );
                _lowerIdentifier_DFA.States[110].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[2], new DfaInterval(100, 100))
                );
                _lowerIdentifier_DFA.States[111].Set(
                    new DfaTrans(_lowerIdentifier_DFA.States[3], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 103), new DfaInterval(105, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_lowerIdentifier_DFA.States[112], new DfaInterval(104, 104))
                );
                _lowerIdentifier_DFA.States[112].Set(
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
                __Matchers_718_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_718_DFA.States[0].Set(
                    new DfaTrans(__Matchers_718_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_718_DFA.States[1].Set(
                );
                __Matchers_720_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_720_DFA.States[0].Set(
                    new DfaTrans(__Matchers_720_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_720_DFA.States[1].Set(
                );
            }

            private PlainRule _compilationUnit;
            private PlainRule _codeUnit;
            private PlainRule _namespace;
            private PlainRule _namespacePath;
            private PlainRule _imports;
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
            private PlainRule _moduleImport;
            private PlainRule _packageDescriptor;
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
            private PlainRule _letVariableList;
            private PlainRule _letVariable;
            private PlainRule _delegatedConstructor;
            private PlainRule _assertionStatement;
            private PlainRule _assertionMessage;
            private PlainRule _block;
            private PlainRule _extendedType;
            private PlainRule _classSpecifier;
            private PlainRule _classInstatiation;
            private PlainRule _qualifiedClass;
            private PlainRule _packageQualifiedClass;
            private PlainRule _superQualifiedClass;
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
            private PlainRule _declarations;
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
            private PlainRule _statements;
            private PlainRule _statement;
            private PlainRule _declarationStatement;
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
            private PlainRule _patternedArguments;
            private PlainRule _positionalArguments;
            private PlainRule _structuredArgument;
            private PlainRule _anonymousArgument;
            private PlainRule _namedArgument;
            private PlainRule _namedSpecifiedArgument;
            private PlainRule _sequencedArgumentList;
            private PlainRule _sequencedArgument;
            private PlainRule _namedArgumentDeclaration;
            private PlainRule _objectArgument;
            private PlainRule _typedMethodArgument;
            private PlainRule _methodDefinition;
            private PlainRule _optionalFunctionSpecifier;
            private PlainRule _requiredFunctionSpecifier;
            private PlainRule _methodArgumentType;
            private PlainRule _typedGetterArgument;
            private PlainRule _getterArgumentType;
            private PlainRule _inferredMethodArgument;
            private PlainRule _inferredGetterArgument;
            private PlainRule _untypedMethodArgument;
            private PlainRule _untypedGetterArgument;
            private PlainRule _positionalArgument;
            private PlainRule _expressionArgument;
            private PlainRule _spreadArgument;
            private PlainRule _letExpr;
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
            private PlainRule _elseIf;
            private PlainRule _elseBlock;
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
            private PlainRule _packageQualifier;
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
            private Dfa __Matchers_718_DFA = new Dfa("__Matchers_718_DFA");
            private Dfa __Matchers_720_DFA = new Dfa("__Matchers_720_DFA");
        }
    }

    public partial class CeylonTree
    {
        public interface ICXStart : IRNode {}
        public interface ICXWhitespace : IRNode {}
        public interface ICXKeywords : IRNode {}
        public interface ICCompilationUnit : IRNode {}
        public interface ICCodeUnit : ICCompilationUnit {}
        public interface ICNamespace : IRNode {}
        public interface ICNamespacePath : IRNode {}
        public interface ICImports : IRNode {}
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
        public interface ICModuleImport : ICModuleBodyElement {}
        public interface ICPackageDescriptor : ICCompilationUnit {}
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
        public interface ICLetVariableList : IRNode {}
        public interface ICLetVariable : ICLetOrExpression {}
        public interface ICDelegatedConstructor : IRNode {}
        public interface ICAssertionStatement : ICOpenStatement {}
        public interface ICAssertionMessage : IRNode {}
        public interface ICBlock : ICAttributeDefinition, ICClassDefinition, ICFunctionDefinition, ICInterfaceDefinition, ICMethodDefinition, ICSetterDefinition {}
        public interface ICExtendedType : IRNode {}
        public interface ICClassSpecifier : IRNode {}
        public interface ICClassInstatiation : IRNode {}
        public interface ICQualifiedClass : IRNode {}
        public interface ICPackageQualifiedClass : ICQualifiedClass {}
        public interface ICSuperQualifiedClass : ICQualifiedClass {}
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
        public interface ICDeclarations : IRNode {}
        public interface ICDeclaration : ICDeclarationStatement {}
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
        public interface ICStatements : IRNode {}
        public interface ICStatement : IRNode {}
        public interface ICDeclarationStatement : ICStatement {}
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
        public interface ICPatternedArguments : ICArguments {}
        public interface ICPositionalArguments : ICArguments {}
        public interface ICStructuredArgument : IRNode {}
        public interface ICAnonymousArgument : ICStructuredArgument {}
        public interface ICNamedArgument : ICStructuredArgument {}
        public interface ICNamedSpecifiedArgument : ICNamedArgument {}
        public interface ICSequencedArgumentList : IRNode {}
        public interface ICSequencedArgument : IRNode {}
        public interface ICNamedArgumentDeclaration : ICNamedArgument {}
        public interface ICObjectArgument : ICNamedArgumentDeclaration {}
        public interface ICTypedMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICMethodDefinition : IRNode {}
        public interface ICOptionalFunctionSpecifier : ICMethodDefinition {}
        public interface ICRequiredFunctionSpecifier : ICSetterDefinition {}
        public interface ICMethodArgumentType : IRNode {}
        public interface ICTypedGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICGetterArgumentType : IRNode {}
        public interface ICInferredMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICInferredGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICUntypedMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICUntypedGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICPositionalArgument : ICSequencedArgument {}
        public interface ICExpressionArgument : ICPositionalArgument {}
        public interface ICSpreadArgument : ICSequencedArgument {}
        public interface ICLetExpr : ICConditionalExpression, ICExpression {}
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
        public interface ICExpression : ICBooleanCondition, ICExpressionArgument, ICExpressionComprehensionClause, ICIndex {}
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
        public interface ICIfElseStatement : ICControlStatement {}
        public interface ICElseIf : IRNode {}
        public interface ICElseBlock : IRNode {}
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
        public interface ICPackageQualifier : IRNode {}
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

        public partial class CCodeUnit : RSequence, ICCodeUnit
        {
            // sequence
            public CCodeUnit(params RNode[] children) : base(children) {}

            public CImports Imports => Get<CImports>(0);
            public CNamespace Namespace => Get<CNamespace>(1);
            public CDeclarations Declarations => Get<CDeclarations>(2);
        }

        public partial class CNamespace : RSequence, ICNamespace
        {
            // sequence
            public CNamespace(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'namespace'
            public CNamespacePath NamespacePath => Get<CNamespacePath>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
        }

        public partial class CNamespacePath : RLoop<CIdentifier>, ICNamespacePath
        {
            // sequence
            public CNamespacePath(params RNode[] children) : base(children) {}
        }

        public partial class CImports : RStar<CImportDeclaration>, ICImports
        {
            // *star*
            public CImports(params RNode[] children) : base(children) {}
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
            // sequence
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'module'
            public ICModuleName ModuleName => Get<ICModuleName>(2);
            public ROptional<CModuleSpecifier> ModuleSpecifier => Get<ROptional<CModuleSpecifier>>(3);
            public ROptional<ICVersion> Version => Get<ROptional<ICVersion>>(4);
            public CModuleBody ModuleBody => Get<CModuleBody>(5);
        }

        public partial class CModuleSpecifier : RSequence, ICModuleSpecifier
        {
            // sequence
            public CModuleSpecifier(params RNode[] children) : base(children) {}

            public ICRepository Repository => Get<ICRepository>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ':'
            public ICModule Module => Get<ICModule>(2);
            public ROptional<CArtifactAndClassifier> ArtifactAndClassifier => Get<ROptional<CArtifactAndClassifier>>(3);
        }

        public partial class CArtifactAndClassifier : RSequence, ICArtifactAndClassifier
        {
            // sequence
            public CArtifactAndClassifier(params RNode[] children) : base(children) {}

            public CArtifact Artifact => Get<CArtifact>(0);
            public ROptional<CClassifier> Classifier => Get<ROptional<CClassifier>>(1);
        }

        public partial class CArtifact : RSequence, ICArtifact
        {
            // sequence
            public CArtifact(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ':'
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CClassifier : RSequence, ICClassifier
        {
            // sequence
            public CClassifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ':'
            public CLiteralString LiteralString => Get<CLiteralString>(1);
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

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'import'
            public ICModule Module => Get<ICModule>(2);
            public ROptional<ICVersion> Version => Get<ROptional<ICVersion>>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // ';'
        }

        public partial class CPackageDescriptor : RSequence, ICPackageDescriptor
        {
            // sequence
            public CPackageDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'package'
            public CPackagePath PackagePath => Get<CPackagePath>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ';'
        }

        public partial class CImportDeclaration : RSequence, ICImportDeclaration
        {
            // sequence
            public CImportDeclaration(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'import'
            public CPackagePath PackagePath => Get<CPackagePath>(1);
            public CImportElements ImportElements => Get<CImportElements>(2);
        }

        public partial class CImportElements : RSequence, ICImportElements
        {
            // sequence
            public CImportElements(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public ROptional<CImportElementList> ImportElementList => Get<ROptional<CImportElementList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
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
            public ROptional<CImportNameSpecifier> ImportNameSpecifier => Get<ROptional<CImportNameSpecifier>>(1);
            public ROptional<CImportElements> ImportElements => Get<ROptional<CImportElements>>(2);
        }

        public partial class CImportNameSpecifier : RSequence, ICImportNameSpecifier
        {
            // sequence
            public CImportNameSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
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
            public RLiteral Literal => Get<RLiteral>(1); // '->'
            public ICVariableOrTuplePattern VariableOrTuplePattern2 => Get<ICVariableOrTuplePattern>(2);
        }

        public partial class CTuplePattern : RSequence, ICTuplePattern
        {
            // sequence
            public CTuplePattern(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public ROptional<CVariadicPatternList> VariadicPatternList => Get<ROptional<CVariadicPatternList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
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

            public ROptional<ICUnionType> UnionType => Get<ROptional<ICUnionType>>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
        }

        public partial class CLetStatement : RSequence, ICLetStatement
        {
            // sequence
            public CLetStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'let'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public CLetVariableList LetVariableList => Get<CLetVariableList>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
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

        public partial class CDelegatedConstructor : RSequence, ICDelegatedConstructor
        {
            // sequence
            public CDelegatedConstructor(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'extends'
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CAssertionStatement : RSequence, ICAssertionStatement
        {
            // sequence
            public CAssertionStatement(params RNode[] children) : base(children) {}

            public ROptional<ICAssertionMessage> AssertionMessage => Get<ROptional<ICAssertionMessage>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'assert'
            public CConditions Conditions => Get<CConditions>(2);
        }

        public partial class CBlock : RSequence, ICBlock
        {
            // sequence
            public CBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CImports Imports => Get<CImports>(1);
            public CStatements Statements => Get<CStatements>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CExtendedType : RSequence, ICExtendedType
        {
            // sequence
            public CExtendedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'extends'
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassSpecifier : RSequence, ICClassSpecifier
        {
            // sequence
            public CClassSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassInstatiation : RSequence, ICClassInstatiation
        {
            // sequence
            public CClassInstatiation(params RNode[] children) : base(children) {}

            public ICQualifiedClass QualifiedClass => Get<ICQualifiedClass>(0);
            public ROptional<ICArguments> Arguments => Get<ROptional<ICArguments>>(1);
        }

        public partial class CPackageQualifiedClass : RSequence, ICPackageQualifiedClass
        {
            // sequence
            public CPackageQualifiedClass(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public RLiteral Literal2 => Get<RLiteral>(1); // '.'
            public ICUnQualifiedClass UnQualifiedClass => Get<ICUnQualifiedClass>(2);
        }

        public partial class CSuperQualifiedClass : RSequence, ICSuperQualifiedClass
        {
            // sequence
            public CSuperQualifiedClass(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'super'
            public RLiteral Literal2 => Get<RLiteral>(1); // '.'
            public ICBaseReference BaseReference => Get<ICBaseReference>(2);
        }

        public partial class CMemberPath : RSequence, ICMemberPath
        {
            // sequence
            public CMemberPath(params RNode[] children) : base(children) {}

            public CTypePath TypePath => Get<CTypePath>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '.'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'satisfies'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'of'
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

            public ROptional<CPackageQualifier> PackageQualifier => Get<ROptional<CPackageQualifier>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
        }

        public partial class CParameters : RSequence, ICParameters
        {
            // sequence
            public CParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CParameterList> ParameterList => Get<ROptional<CParameterList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
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
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CFunctionParameterDeclaration : RSequence, ICFunctionParameterDeclaration
        {
            // sequence
            public CFunctionParameterDeclaration(params RNode[] children) : base(children) {}

            public ICFunctionParameterType FunctionParameterType => Get<ICFunctionParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CValueParameterDeclaration : RSequence, ICValueParameterDeclaration
        {
            // sequence
            public CValueParameterDeclaration(params RNode[] children) : base(children) {}

            public ICValueParameterType ValueParameterType => Get<ICValueParameterType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(2);
        }

        public partial class CTypeParameters : RSequence, ICTypeParameters
        {
            // sequence
            public CTypeParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public CTypeParameterList TypeParameterList => Get<CTypeParameterList>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '>'
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

            public ROptional<ICVariance> Variance => Get<ROptional<ICVariance>>(0);
            public ICTypeName TypeName => Get<ICTypeName>(1);
            public ROptional<CTypeDefault> TypeDefault => Get<ROptional<CTypeDefault>>(2);
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

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICType Type => Get<ICType>(1);
        }

        public partial class CTypeConstraint : RSequence, ICTypeConstraint
        {
            // sequence
            public CTypeConstraint(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'given'
            public ROptional<ICTypeName> TypeName => Get<ROptional<ICTypeName>>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(4);
        }

        public partial class CTypeConstraints : RPlus<CTypeConstraint>, ICTypeConstraints
        {
            // +plus+
            public CTypeConstraints(params RNode[] children) : base(children) {}
        }

        public partial class CDeclarations : RStar<ICDeclaration>, ICDeclarations
        {
            // *star*
            public CDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CConstructorDeclaration : RSequence, ICConstructorDeclaration
        {
            // sequence
            public CConstructorDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'new'
            public ROptional<ICMemberName> MemberName => Get<ROptional<ICMemberName>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ROptional<CDelegatedConstructor> DelegatedConstructor => Get<ROptional<CDelegatedConstructor>>(4);
            public CBlock Block => Get<CBlock>(5);
        }

        public partial class CAliasDeclaration : RSequence, ICAliasDeclaration
        {
            // sequence
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'alias'
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(4);
            public COptionalTypeSpecifier OptionalTypeSpecifier => Get<COptionalTypeSpecifier>(5);
        }

        public partial class CEnumeratedObjectDeclaration : RSequence, ICEnumeratedObjectDeclaration
        {
            // sequence
            public CEnumeratedObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'new'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CDelegatedConstructor> DelegatedConstructor => Get<ROptional<CDelegatedConstructor>>(3);
            public CBlock Block => Get<CBlock>(4);
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'object'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(4);
            public CBlock Block => Get<CBlock>(5);
        }

        public partial class CSetterDeclaration : RSequence, ICSetterDeclaration
        {
            // sequence
            public CSetterDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'assign'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICSetterDefinition SetterDefinition => Get<ICSetterDefinition>(3);
        }

        public partial class CTypedMethodDeclaration : RSequence, ICTypedMethodDeclaration
        {
            // sequence
            public CTypedMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public ICVariadicType VariadicType => Get<ICVariadicType>(1);
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(5);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(6);
        }

        public partial class CVoidMethodDeclaration : RSequence, ICVoidMethodDeclaration
        {
            // sequence
            public CVoidMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'void'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(5);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(6);
        }

        public partial class CInferredMethodDeclaration : RSequence, ICInferredMethodDeclaration
        {
            // sequence
            public CInferredMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'function'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(5);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(6);
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
            public RLiteral Literal => Get<RLiteral>(1); // 'value'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ICAttributeDefinition AttributeDefinition => Get<ICAttributeDefinition>(3);
        }

        public partial class COptionalAnySpecifier : RSequence, ICOptionalAnySpecifier
        {
            // sequence
            public COptionalAnySpecifier(params RNode[] children) : base(children) {}

            public ROptional<ICAnySpecifier> AnySpecifier => Get<ROptional<ICAnySpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'class'
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(6);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(7);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(8);
            public ICClassDefinition ClassDefinition => Get<ICClassDefinition>(9);
        }

        public partial class COptionalClassSpecifier : RSequence, ICOptionalClassSpecifier
        {
            // sequence
            public COptionalClassSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CClassSpecifier> ClassSpecifier => Get<ROptional<CClassSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'interface'
            public ICTypeName TypeName => Get<ICTypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(4);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(5);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(6);
            public ICInterfaceDefinition InterfaceDefinition => Get<ICInterfaceDefinition>(7);
        }

        public partial class COptionalTypeSpecifier : RSequence, ICOptionalTypeSpecifier
        {
            // sequence
            public COptionalTypeSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CTypeSpecifier> TypeSpecifier => Get<ROptional<CTypeSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CStatements : RStar<ICStatement>, ICStatements
        {
            // *star*
            public CStatements(params RNode[] children) : base(children) {}
        }

        public partial class CUnclosedStatement : RSequence, ICUnclosedStatement
        {
            // sequence
            public CUnclosedStatement(params RNode[] children) : base(children) {}

            public ICOpenStatement OpenStatement => Get<ICOpenStatement>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'return'
            public ROptional<ICExpression> Expression => Get<ROptional<ICExpression>>(1);
        }

        public partial class CThrowStatement : RSequence, ICThrowStatement
        {
            // sequence
            public CThrowStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'throw'
            public ROptional<ICExpression> Expression => Get<ROptional<ICExpression>>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICType Type => Get<ICType>(1);
        }

        public partial class CValueSpecifier : RSequence, ICValueSpecifier
        {
            // sequence
            public CValueSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CFunctionSpecifier : RSequence, ICFunctionSpecifier
        {
            // sequence
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICExpression Expression => Get<ICExpression>(1);
        }

        public partial class CParametrizedMember : RSequence, ICParametrizedMember
        {
            // sequence
            public CParametrizedMember(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(2);
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
            public ROptional<CTypeArguments> TypeArguments => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CTypeReference : RSequence, ICTypeReference
        {
            // sequence
            public CTypeReference(params RNode[] children) : base(children) {}

            public ICTypeName TypeName => Get<ICTypeName>(0);
            public ROptional<CTypeArguments> TypeArguments => Get<ROptional<CTypeArguments>>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CStatements Statements => Get<CStatements>(1);
            public ROptional<CSequencedArgumentList> SequencedArgumentList => Get<ROptional<CSequencedArgumentList>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CTupleExpr : RSequence, ICTupleExpr
        {
            // sequence
            public CTupleExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public ROptional<CSequencedArgumentList> SequencedArgumentList => Get<ROptional<CSequencedArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CPatternedArguments : RSequence, ICPatternedArguments
        {
            // sequence
            public CPatternedArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public RStar<ICStructuredArgument> StructuredArgument => Get<RStar<ICStructuredArgument>>(1);
            public ROptional<CSequencedArgumentList> SequencedArgumentList => Get<ROptional<CSequencedArgumentList>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CPositionalArguments : RSequence, ICPositionalArguments
        {
            // sequence
            public CPositionalArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CSequencedArgumentList> SequencedArgumentList => Get<ROptional<CSequencedArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CAnonymousArgument : RSequence, ICAnonymousArgument
        {
            // sequence
            public CAnonymousArgument(params RNode[] children) : base(children) {}

            public ICExpression Expression => Get<ICExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CNamedSpecifiedArgument : RSequence, ICNamedSpecifiedArgument
        {
            // sequence
            public CNamedSpecifiedArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
            public RLiteral Literal => Get<RLiteral>(2); // ';'
        }

        public partial class CSequencedArgumentList : RLoop<ICSequencedArgument>, ICSequencedArgumentList
        {
            // sequence
            public CSequencedArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CObjectArgument : RSequence, ICObjectArgument
        {
            // sequence
            public CObjectArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public ROptional<ICMemberName> MemberName => Get<ROptional<ICMemberName>>(1);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(2);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(3);
            public CBlock Block => Get<CBlock>(4);
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

            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CRequiredFunctionSpecifier : RSequence, ICRequiredFunctionSpecifier
        {
            // sequence
            public CRequiredFunctionSpecifier(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'function'
            public ROptional<ICMemberName> MemberName => Get<ROptional<ICMemberName>>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(4);
        }

        public partial class CInferredGetterArgument : RSequence, ICInferredGetterArgument
        {
            // sequence
            public CInferredGetterArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'value'
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CUntypedMethodArgument : RSequence, ICUntypedMethodArgument
        {
            // sequence
            public CUntypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(1);
            public CRequiredFunctionSpecifier RequiredFunctionSpecifier => Get<CRequiredFunctionSpecifier>(2);
        }

        public partial class CUntypedGetterArgument : RSequence, ICUntypedGetterArgument
        {
            // sequence
            public CUntypedGetterArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public CRequiredFunctionSpecifier RequiredFunctionSpecifier => Get<CRequiredFunctionSpecifier>(1);
        }

        public partial class CSpreadArgument : RSequence, ICSpreadArgument
        {
            // sequence
            public CSpreadArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '*'
            public ICUnionExpression UnionExpression => Get<ICUnionExpression>(1);
        }

        public partial class CLetExpr : RSequence, ICLetExpr
        {
            // sequence
            public CLetExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'let'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CLetVariableList> LetVariableList => Get<ROptional<CLetVariableList>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(4);
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

            public RPlus<CCaseExpression> CaseExpression => Get<RPlus<CCaseExpression>>(0);
            public ROptional<CElseExpression> ElseExpression => Get<ROptional<CElseExpression>>(1);
        }

        public partial class CCaseExpression : RSequence, ICCaseExpression
        {
            // sequence
            public CCaseExpression(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'case'
            public RLiteral Literal3 => Get<RLiteral>(2); // '('
            public ICCaseItem CaseItem => Get<ICCaseItem>(3);
            public RLiteral Literal4 => Get<RLiteral>(4); // ')'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(5);
        }

        public partial class CIfExpr : RSequence, ICIfExpr
        {
            // sequence
            public CIfExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
            public CConditions Conditions => Get<CConditions>(1);
            public CThenExpression ThenExpression => Get<CThenExpression>(2);
            public CElseExpression ElseExpression => Get<CElseExpression>(3);
        }

        public partial class CElseExpression : RSequence, ICElseExpression
        {
            // sequence
            public CElseExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CThenExpression : RSequence, ICThenExpression
        {
            // sequence
            public CThenExpression(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'then'
            public ICConditionalExpression ConditionalExpression => Get<ICConditionalExpression>(1);
        }

        public partial class CFunctionExpr : RSequence, ICFunctionExpr
        {
            // sequence
            public CFunctionExpr(params RNode[] children) : base(children) {}

            public ROptional<ICFunctionExpressionType> FunctionExpressionType => Get<ROptional<ICFunctionExpressionType>>(0);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public ROptional<CFunctionParameters> FunctionParameters => Get<ROptional<CFunctionParameters>>(2);
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

            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(0);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(1);
        }

        public partial class CForComprehensionClause : RSequence, ICForComprehensionClause
        {
            // sequence
            public CForComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CForIterator> ForIterator => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public ICComprehensionClause ComprehensionClause => Get<ICComprehensionClause>(4);
        }

        public partial class CIfComprehensionClause : RSequence, ICIfComprehensionClause
        {
            // sequence
            public CIfComprehensionClause(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
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
            public RLiteral Literal => Get<RLiteral>(1); // 'exists'
        }

        public partial class CNonemptyExpr : RSequence, ICNonemptyExpr
        {
            // sequence
            public CNonemptyExpr(params RNode[] children) : base(children) {}

            public ICEntryRangeExpression EntryRangeExpression => Get<ICEntryRangeExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'nonempty'
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

            public RLiteral Literal => Get<RLiteral>(0); // '-'
            public RNot<RLiteral> Literal2 => Get<RNot<RLiteral>>(1);
        }

        public partial class CNeutralOperator : RSequence, ICNeutralOperator
        {
            // sequence
            public CNeutralOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '+'
            public RNot<RLiteral> Literal2 => Get<RNot<RLiteral>>(1);
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
            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(1);
            public ICBaseReference BaseReference => Get<ICBaseReference>(2);
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
            public RLiteral Literal => Get<RLiteral>(1); // '['
            public ICIndex Index => Get<ICIndex>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ']'
        }

        public partial class CUpperSpanned : RSequence, ICUpperSpanned
        {
            // sequence
            public CUpperSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '...'
        }

        public partial class CLowerSpanned : RSequence, ICLowerSpanned
        {
            // sequence
            public CLowerSpanned(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '...'
            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(1);
        }

        public partial class CSpanned : RSequence, ICSpanned
        {
            // sequence
            public CSpanned(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '..'
            public ICIndexExpression IndexExpression2 => Get<ICIndexExpression>(2);
        }

        public partial class CMeasured : RSequence, ICMeasured
        {
            // sequence
            public CMeasured(params RNode[] children) : base(children) {}

            public ICIndexExpression IndexExpression => Get<ICIndexExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ':'
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

        public partial class CObjectExpr : RSequence, ICObjectExpr
        {
            // sequence
            public CObjectExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(1);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(2);
            public CBlock Block => Get<CBlock>(3);
        }

        public partial class CGroupedExpr : RSequence, ICGroupedExpr
        {
            // sequence
            public CGroupedExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ICExpression Expression => Get<ICExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CTypeArguments : RSequence, ICTypeArguments
        {
            // sequence
            public CTypeArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public ROptional<CTypeArgumentList> TypeArgumentList => Get<ROptional<CTypeArgumentList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '>'
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

            public ROptional<ICVariance> Variance => Get<ROptional<ICVariance>>(0);
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
            public RLiteral Literal => Get<RLiteral>(1); // '='
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

            public RLiteral Literal => Get<RLiteral>(0); // '*'
            public ICUnionType UnionType => Get<ICUnionType>(1);
        }

        public partial class CEntryType : RSequence, ICEntryType
        {
            // sequence
            public CEntryType(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '->'
            public ICUnionType UnionType2 => Get<ICUnionType>(2);
        }

        public partial class CUnionTypeCore : RSequence, ICUnionTypeCore
        {
            // sequence
            public CUnionTypeCore(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '|'
            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(2);
        }

        public partial class CIntersectionTypeCore : RSequence, ICIntersectionTypeCore
        {
            // sequence
            public CIntersectionTypeCore(params RNode[] children) : base(children) {}

            public ICIntersectionType IntersectionType => Get<ICIntersectionType>(0);
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
            public ROptional<CLiteralNatural> LiteralNatural => Get<ROptional<CLiteralNatural>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ']'
        }

        public partial class CFunctionType : RSequence, ICFunctionType
        {
            // sequence
            public CFunctionType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '('
            public ROptional<ICTypeTypeArguments> TypeTypeArguments => Get<ROptional<ICTypeTypeArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ')'
        }

        public partial class CTupleType : RSequence, ICTupleType
        {
            // sequence
            public CTupleType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public ROptional<ICTypeTypeArguments> TypeTypeArguments => Get<ROptional<ICTypeTypeArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CIterableType : RSequence, ICIterableType
        {
            // sequence
            public CIterableType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public ROptional<ICVariadicType> VariadicType => Get<ROptional<ICVariadicType>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
        }

        public partial class CGroupedType : RSequence, ICGroupedType
        {
            // sequence
            public CGroupedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '<'
            public ICType Type => Get<ICType>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '>'
        }

        public partial class CPackageQualifiedType : RSequence, ICPackageQualifiedType
        {
            // sequence
            public CPackageQualifiedType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public RLiteral Literal2 => Get<RLiteral>(1); // '.'
            public CTypePath TypePath => Get<CTypePath>(2);
        }

        public partial class CAnnotations : RSequence, ICAnnotations
        {
            // sequence
            public CAnnotations(params RNode[] children) : base(children) {}

            public ROptional<ICStringLiteral> StringLiteral => Get<ROptional<ICStringLiteral>>(0);
            public RStar<CAnnotation> Annotation => Get<RStar<CAnnotation>>(1);
        }

        public partial class CAnnotation : RSequence, ICAnnotation
        {
            // sequence
            public CAnnotation(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<ICArguments> Arguments => Get<ROptional<ICArguments>>(1);
        }

        public partial class CConditions : RSequence, ICConditions
        {
            // sequence
            public CConditions(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CConditionList> ConditionList => Get<ROptional<CConditionList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
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

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'exists'
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CNonemptyCondition : RSequence, ICNonemptyCondition
        {
            // sequence
            public CNonemptyCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'nonempty'
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CIsCondition : RSequence, ICIsCondition
        {
            // sequence
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'is'
            public ICType Type => Get<ICType>(2);
            public CIsConditionVariable IsConditionVariable => Get<CIsConditionVariable>(3);
        }

        public partial class CIsConditionVariable : RSequence, ICIsConditionVariable
        {
            // sequence
            public CIsConditionVariable(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CSatisfiesCondition : RSequence, ICSatisfiesCondition
        {
            // sequence
            public CSatisfiesCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'satisfies'
            public ICType Type => Get<ICType>(1);
            public ICTypeName TypeName => Get<ICTypeName>(2);
        }

        public partial class CIfElseStatement : RSequence, ICIfElseStatement
        {
            // sequence
            public CIfElseStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlock Block => Get<CBlock>(2);
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
            public CBlock Block => Get<CBlock>(3);
        }

        public partial class CElseBlock : RSequence, ICElseBlock
        {
            // sequence
            public CElseBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public CBlock Block => Get<CBlock>(1);
        }

        public partial class CSwitchStatement : RSequence, ICSwitchStatement
        {
            // sequence
            public CSwitchStatement(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public RPlus<CCaseBlock> CaseBlock => Get<RPlus<CCaseBlock>>(1);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(2);
        }

        public partial class CSwitchHeader : RSequence, ICSwitchHeader
        {
            // sequence
            public CSwitchHeader(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'switch'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ICSwitched Switched => Get<ICSwitched>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
        }

        public partial class CCaseBlock : RSequence, ICCaseBlock
        {
            // sequence
            public CCaseBlock(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'case'
            public RLiteral Literal3 => Get<RLiteral>(2); // '('
            public ICCaseItem CaseItem => Get<ICCaseItem>(3);
            public RLiteral Literal4 => Get<RLiteral>(4); // ')'
            public CBlock Block => Get<CBlock>(5);
        }

        public partial class CIsCaseCondition : RSequence, ICIsCaseCondition
        {
            // sequence
            public CIsCaseCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public ICType Type => Get<ICType>(1);
        }

        public partial class CSatisfiesCaseCondition : RSequence, ICSatisfiesCaseCondition
        {
            // sequence
            public CSatisfiesCaseCondition(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'satisfies'
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
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(1);
        }

        public partial class CForBlock : RSequence, ICForBlock
        {
            // sequence
            public CForBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CForIterator> ForIterator => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public CBlock Block => Get<CBlock>(4);
        }

        public partial class CForIterator : RSequence, ICForIterator
        {
            // sequence
            public CForIterator(params RNode[] children) : base(children) {}

            public ICForVariable ForVariable => Get<ICForVariable>(0);
            public ROptional<CContainment> Containment => Get<ROptional<CContainment>>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'while'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlock Block => Get<CBlock>(2);
        }

        public partial class CTryStatement : RSequence, ICTryStatement
        {
            // sequence
            public CTryStatement(params RNode[] children) : base(children) {}

            public CTryBlock TryBlock => Get<CTryBlock>(0);
            public RStar<CCatchBlock> CatchBlock => Get<RStar<CCatchBlock>>(1);
            public ROptional<CFinallyBlock> FinallyBlock => Get<ROptional<CFinallyBlock>>(2);
        }

        public partial class CTryBlock : RSequence, ICTryBlock
        {
            // sequence
            public CTryBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'try'
            public ROptional<CResources> Resources => Get<ROptional<CResources>>(1);
            public CBlock Block => Get<CBlock>(2);
        }

        public partial class CCatchBlock : RSequence, ICCatchBlock
        {
            // sequence
            public CCatchBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'catch'
            public CCatchVariable CatchVariable => Get<CCatchVariable>(1);
            public CBlock Block => Get<CBlock>(2);
        }

        public partial class CCatchVariable : RSequence, ICCatchVariable
        {
            // sequence
            public CCatchVariable(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CVariable> Variable => Get<ROptional<CVariable>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
        }

        public partial class CFinallyBlock : RSequence, ICFinallyBlock
        {
            // sequence
            public CFinallyBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'finally'
            public CBlock Block => Get<CBlock>(1);
        }

        public partial class CResources : RSequence, ICResources
        {
            // sequence
            public CResources(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CResourceList> ResourceList => Get<ROptional<CResourceList>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ')'
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

            public ROptional<ICVariableType> VariableType => Get<ROptional<ICVariableType>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public RStar<CParameters> Parameters => Get<RStar<CParameters>>(2);
        }

        public partial class CModelReference : RSequence, ICModelReference
        {
            // sequence
            public CModelReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '^'
            public ICModelExpression ModelExpression => Get<ICModelExpression>(1);
        }

        public partial class CMetaLiteral : RSequence, ICMetaLiteral
        {
            // sequence
            public CMetaLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '`'
            public ICMetaExpression MetaExpression => Get<ICMetaExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '`'
        }

        public partial class CPackageQualifiedMemberReference : RSequence, ICPackageQualifiedMemberReference
        {
            // sequence
            public CPackageQualifiedMemberReference(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public RLiteral Literal2 => Get<RLiteral>(1); // '.'
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CTypeQualifiedMemberReference : RSequence, ICTypeQualifiedMemberReference
        {
            // sequence
            public CTypeQualifiedMemberReference(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '.'
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CModuleLiteral : RSequence, ICModuleLiteral
        {
            // sequence
            public CModuleLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'module'
            public ROptional<CPackagePath> PackagePath => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CPackageLiteral : RSequence, ICPackageLiteral
        {
            // sequence
            public CPackageLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public ROptional<CPackagePath> PackagePath => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CClassLiteral : RSequence, ICClassLiteral
        {
            // sequence
            public CClassLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'class'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CInterfaceLiteral : RSequence, ICInterfaceLiteral
        {
            // sequence
            public CInterfaceLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'interface'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CAliasLiteral : RSequence, ICAliasLiteral
        {
            // sequence
            public CAliasLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'alias'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CTypeParameterLiteral : RSequence, ICTypeParameterLiteral
        {
            // sequence
            public CTypeParameterLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'given'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CNewLiteral : RSequence, ICNewLiteral
        {
            // sequence
            public CNewLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'new'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'function'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CPackageQualifier : RSequence, ICPackageQualifier
        {
            // sequence
            public CPackageQualifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public RLiteral Literal2 => Get<RLiteral>(1); // '.'
        }

        public partial class CReferencePath : RSequence, ICReferencePath
        {
            // sequence
            public CReferencePath(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifier => Get<ROptional<CPackageQualifier>>(0);
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

            protected virtual void Visit(CCodeUnit element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNamespace element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNamespacePath element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CImports element)
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

            protected virtual void Visit(CModuleImport element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPackageDescriptor element)
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

            protected virtual void Visit(CLetVariableList element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetVariable element)
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

            protected virtual void Visit(CBlock element)
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

            protected virtual void Visit(CPackageQualifiedClass element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CSuperQualifiedClass element)
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

            protected virtual void Visit(CDeclarations element)
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

            protected virtual void Visit(CStatements element)
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

            protected virtual void Visit(CPatternedArguments element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CPositionalArguments element)
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

            protected virtual void Visit(CSequencedArgumentList element)
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

            protected virtual void Visit(CRequiredFunctionSpecifier element)
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

            protected virtual void Visit(CSpreadArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLetExpr element)
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

            protected virtual void Visit(CElseIf element)
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

            protected virtual void Visit(CPackageQualifier element)
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
