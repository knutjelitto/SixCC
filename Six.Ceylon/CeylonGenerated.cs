// <generated from="D:\\Six\\Six.Ceylon\\Ceylon.six" at="30.01.2022 14:32:27" />

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
                : base(new Matcher[873])
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
                /*  42 PlainRuleOp      */ __Matchers[42] = _variadicOperator = new PlainRule(this, 42, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /*  43 PlainRuleOp      */ __Matchers[43] = _letStatement = new PlainRule(this, 43, "let-statement") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _letVariableList = new PlainRule(this, 44, "let-variable-list") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _letVariable = new PlainRule(this, 45, "let-variable") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _delegatedConstructor = new PlainRule(this, 46, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _assertionStatement = new PlainRule(this, 47, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _assertionMessage = new PlainRule(this, 48, "assertion-message") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _block = new PlainRule(this, 49, "block") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _extendedType = new PlainRule(this, 50, "extended-type") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _classSpecifier = new PlainRule(this, 51, "class-specifier") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _classInstantiation = new PlainRule(this, 52, "class-instantiation") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _qualifiedClass = new PlainRule(this, 53, "qualified-class") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _packageQualifiedClass = new PlainRule(this, 54, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _superQualifiedClass = new PlainRule(this, 55, "super-qualified-class") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _unQualifiedClass = new PlainRule(this, 56, "un-qualified-class") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _memberPath = new PlainRule(this, 57, "member-path") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _typePath = new PlainRule(this, 58, "type-path") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _satisfiedTypes = new PlainRule(this, 59, "satisfied-types") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _unionTypeList = new PlainRule(this, 60, "union-type-list") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _caseTypes = new PlainRule(this, 61, "case-types") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _caseTypeList = new PlainRule(this, 62, "case-type-list") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _caseType = new PlainRule(this, 63, "case-type") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _qualifiedCaseType = new PlainRule(this, 64, "qualified-case-type") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _parameters = new PlainRule(this, 65, "parameters") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _parameterList = new PlainRule(this, 66, "parameter-list") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _parameterDeclarationOrRefPattern = new PlainRule(this, 67, "parameter-declaration-or-ref-pattern") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _parameter = new PlainRule(this, 68, "parameter") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _parameterReference = new PlainRule(this, 69, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _parameterDeclaration = new PlainRule(this, 70, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _functionParameterDeclaration = new PlainRule(this, 71, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _voidFunctionParameter = new PlainRule(this, 72, "void-function-parameter") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _inferredFunctionParameter = new PlainRule(this, 73, "inferred-function-parameter") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _typedFunctionParameter = new PlainRule(this, 74, "typed-function-parameter") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _valueParameterDeclaration = new PlainRule(this, 75, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _inferredValueParameter = new PlainRule(this, 76, "inferred-value-parameter") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _typedValueParameter = new PlainRule(this, 77, "typed-value-parameter") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _typeParameters = new PlainRule(this, 78, "type-parameters") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _typeParameterList = new PlainRule(this, 79, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _typeParameter = new PlainRule(this, 80, "type-parameter") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _variance = new PlainRule(this, 81, "variance") { Creator = node => new CVariance(node) };
                /*  82 PlainRuleOp      */ __Matchers[82] = _typeDefault = new PlainRule(this, 82, "type-default") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeConstraint = new PlainRule(this, 83, "type-constraint") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _typeConstraints = new PlainRule(this, 84, "type-constraints") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _declarations = new PlainRule(this, 85, "declarations") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _declaration = new PlainRule(this, 86, "declaration") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _constructorDeclaration = new PlainRule(this, 87, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _aliasDeclaration = new PlainRule(this, 88, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _enumeratedObjectDeclaration = new PlainRule(this, 89, "enumerated-object-declaration") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _objectDeclaration = new PlainRule(this, 90, "object-declaration") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _setterDeclaration = new PlainRule(this, 91, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _setterDefinition = new PlainRule(this, 92, "setter-definition") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _voidMethodDeclaration = new PlainRule(this, 93, "void-method-declaration") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _inferredMethodDeclaration = new PlainRule(this, 94, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _typedMethodDeclaration = new PlainRule(this, 95, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _typedAttributeDeclaration = new PlainRule(this, 96, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _inferredAttributeDeclaration = new PlainRule(this, 97, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _attributeDefinition = new PlainRule(this, 98, "attribute-definition") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _optionalAnySpecifier = new PlainRule(this, 99, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _classDeclaration = new PlainRule(this, 100, "class-declaration") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _classDefinition = new PlainRule(this, 101, "class-definition") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _optionalClassSpecifier = new PlainRule(this, 102, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _interfaceDeclaration = new PlainRule(this, 103, "interface-declaration") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _interfaceDefinition = new PlainRule(this, 104, "interface-definition") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _optionalTypeSpecifier = new PlainRule(this, 105, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _statements = new PlainRule(this, 106, "statements") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _statement = new PlainRule(this, 107, "statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _declarationStatement = new PlainRule(this, 108, "declaration-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _unclosedStatement = new PlainRule(this, 109, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _openStatement = new PlainRule(this, 110, "open-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _specificationStatement = new PlainRule(this, 111, "specification-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _expressionStatement = new PlainRule(this, 112, "expression-statement") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _directiveStatement = new PlainRule(this, 113, "directive-statement") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _returnStatement = new PlainRule(this, 114, "return-statement") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _throwStatement = new PlainRule(this, 115, "throw-statement") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _breakStatement = new PlainRule(this, 116, "break-statement") { Creator = node => new CBreakStatement(node) };
                /* 117 PlainRuleOp      */ __Matchers[117] = _continueStatement = new PlainRule(this, 117, "continue-statement") { Creator = node => new CContinueStatement(node) };
                /* 118 PlainRuleOp      */ __Matchers[118] = _typeSpecifier = new PlainRule(this, 118, "type-specifier") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _valueSpecifier = new PlainRule(this, 119, "value-specifier") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _functionSpecifier = new PlainRule(this, 120, "function-specifier") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _anySpecifier = new PlainRule(this, 121, "any-specifier") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _baseReferenceOrParameterized = new PlainRule(this, 122, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _baseReference = new PlainRule(this, 123, "base-reference") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _parametrizedMember = new PlainRule(this, 124, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _selfParametrizedMember = new PlainRule(this, 125, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _memberReference = new PlainRule(this, 126, "member-reference") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _typeReference = new PlainRule(this, 127, "type-reference") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _selfReferenceSelector = new PlainRule(this, 128, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _selfReference = new PlainRule(this, 129, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 130 PlainRuleOp      */ __Matchers[130] = _enumerationExpr = new PlainRule(this, 130, "enumeration-expr") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _tupleExpr = new PlainRule(this, 131, "tuple-expr") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _arguments = new PlainRule(this, 132, "arguments") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _patternedArguments = new PlainRule(this, 133, "patterned-arguments") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _positionalArguments = new PlainRule(this, 134, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _structuredArgument = new PlainRule(this, 135, "structured-argument") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _anonymousArgument = new PlainRule(this, 136, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _namedArgument = new PlainRule(this, 137, "named-argument") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _namedSpecifiedArgument = new PlainRule(this, 138, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _sequencedArgumentList = new PlainRule(this, 139, "sequenced-argument-list") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _sequencedArgument = new PlainRule(this, 140, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _namedArgumentDeclaration = new PlainRule(this, 141, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _objectArgument = new PlainRule(this, 142, "object-argument") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _typedMethodArgument = new PlainRule(this, 143, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _methodDefinition = new PlainRule(this, 144, "method-definition") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _optionalFunctionSpecifier = new PlainRule(this, 145, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _requiredFunctionSpecifier = new PlainRule(this, 146, "required-function-specifier") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _methodArgumentType = new PlainRule(this, 147, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _typedGetterArgument = new PlainRule(this, 148, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _getterArgumentType = new PlainRule(this, 149, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _inferredMethodArgument = new PlainRule(this, 150, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _inferredGetterArgument = new PlainRule(this, 151, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _untypedMethodArgument = new PlainRule(this, 152, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _untypedGetterArgument = new PlainRule(this, 153, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _positionalArgument = new PlainRule(this, 154, "positional-argument") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _expressionArgument = new PlainRule(this, 155, "expression-argument") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _spreadArgument = new PlainRule(this, 156, "spread-argument") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _letExpr = new PlainRule(this, 157, "let-expr") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _switchExpr = new PlainRule(this, 158, "switch-expr") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _switchHeader = new PlainRule(this, 159, "switch-header") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _switched = new PlainRule(this, 160, "switched") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _caseExpression = new PlainRule(this, 161, "case-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _ifExpr = new PlainRule(this, 162, "if-expr") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _elseExpression = new PlainRule(this, 163, "else-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _thenExpression = new PlainRule(this, 164, "then-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _conditionalExpression = new PlainRule(this, 165, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _functionExpression = new PlainRule(this, 166, "function-expression") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _voidFunctionExpr = new PlainRule(this, 167, "void-function-expr") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _inferredFunctionExpr = new PlainRule(this, 168, "inferred-function-expr") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _functionDefinition = new PlainRule(this, 169, "function-definition") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _comprehensionArgument = new PlainRule(this, 170, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _comprehensionClause = new PlainRule(this, 171, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _expressionComprehensionClause = new PlainRule(this, 172, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _forComprehensionClause = new PlainRule(this, 173, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _ifComprehensionClause = new PlainRule(this, 174, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _expression = new PlainRule(this, 175, "expression") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _operatorExpression = new PlainRule(this, 176, "operator-expression") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _assignmentExpression = new PlainRule(this, 177, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _assignmentExpr = new PlainRule(this, 178, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 179 PlainRuleOp      */ __Matchers[179] = _assignmentOperator = new PlainRule(this, 179, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 180 PlainRuleOp      */ __Matchers[180] = _thenElseExpression = new PlainRule(this, 180, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _thenElseExpr = new PlainRule(this, 181, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _thenElseOperator = new PlainRule(this, 182, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 183 PlainRuleOp      */ __Matchers[183] = _disjunctionExpression = new PlainRule(this, 183, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _disjunctionExpr = new PlainRule(this, 184, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _disjunctionOperator = new PlainRule(this, 185, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 186 PlainRuleOp      */ __Matchers[186] = _conjunctionExpression = new PlainRule(this, 186, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _conjunctionExpr = new PlainRule(this, 187, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _conjunctionOperator = new PlainRule(this, 188, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 189 PlainRuleOp      */ __Matchers[189] = _logicalNegationExpression = new PlainRule(this, 189, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _logicalNegationExpr = new PlainRule(this, 190, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _notOperator = new PlainRule(this, 191, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 192 PlainRuleOp      */ __Matchers[192] = _expressionOrMeta = new PlainRule(this, 192, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _equalityExpression = new PlainRule(this, 193, "equality-expression") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _equalityExpr = new PlainRule(this, 194, "equality-expr") { Builder = nodes => nodes[0] };
                /* 195 PlainRuleOp      */ __Matchers[195] = _equalityOperator = new PlainRule(this, 195, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 196 PlainRuleOp      */ __Matchers[196] = _comparisonExpression = new PlainRule(this, 196, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _comparisonExpr = new PlainRule(this, 197, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _largerExpr = new PlainRule(this, 198, "larger-expr") { Builder = nodes => nodes[0] };
                /* 199 PlainRuleOp      */ __Matchers[199] = _smallerExpr = new PlainRule(this, 199, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 200 PlainRuleOp      */ __Matchers[200] = _largerBoundsExpr = new PlainRule(this, 200, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 201 PlainRuleOp      */ __Matchers[201] = _smallerBoundsExpr = new PlainRule(this, 201, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 202 PlainRuleOp      */ __Matchers[202] = _typecheckExpr = new PlainRule(this, 202, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 203 PlainRuleOp      */ __Matchers[203] = _comparisonOperator = new PlainRule(this, 203, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 204 PlainRuleOp      */ __Matchers[204] = _smallerOperator = new PlainRule(this, 204, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 205 PlainRuleOp      */ __Matchers[205] = _largerOperator = new PlainRule(this, 205, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 206 PlainRuleOp      */ __Matchers[206] = _typeOperator = new PlainRule(this, 206, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 207 PlainRuleOp      */ __Matchers[207] = _existsNonemptyExpression = new PlainRule(this, 207, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 208 PlainRuleOp      */ __Matchers[208] = _existsExpr = new PlainRule(this, 208, "exists-expr") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _nonemptyExpr = new PlainRule(this, 209, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _entryRangeExpression = new PlainRule(this, 210, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 211 PlainRuleOp      */ __Matchers[211] = _rangeExpr = new PlainRule(this, 211, "range-expr") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _entryExpr = new PlainRule(this, 212, "entry-expr") { Builder = nodes => nodes[0] };
                /* 213 PlainRuleOp      */ __Matchers[213] = _rangeOperator = new PlainRule(this, 213, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 214 PlainRuleOp      */ __Matchers[214] = _entryOperator = new PlainRule(this, 214, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 215 PlainRuleOp      */ __Matchers[215] = _additiveExpression = new PlainRule(this, 215, "additive-expression") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _additiveExpr = new PlainRule(this, 216, "additive-expr") { Builder = nodes => nodes[0] };
                /* 217 PlainRuleOp      */ __Matchers[217] = _additiveOperator = new PlainRule(this, 217, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 218 PlainRuleOp      */ __Matchers[218] = _scaleExpression = new PlainRule(this, 218, "scale-expression") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _scaleExpr = new PlainRule(this, 219, "scale-expr") { Builder = nodes => nodes[0] };
                /* 220 PlainRuleOp      */ __Matchers[220] = _scaleOperator = new PlainRule(this, 220, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 221 PlainRuleOp      */ __Matchers[221] = _multiplicativeExpression = new PlainRule(this, 221, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _multiplicativeExpr = new PlainRule(this, 222, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 223 PlainRuleOp      */ __Matchers[223] = _multiplicativeOperator = new PlainRule(this, 223, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 224 PlainRuleOp      */ __Matchers[224] = _unionExpression = new PlainRule(this, 224, "union-expression") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _unionExpr = new PlainRule(this, 225, "union-expr") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _unionOperator = new PlainRule(this, 226, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 227 PlainRuleOp      */ __Matchers[227] = _exclusiveExpression = new PlainRule(this, 227, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _exclusiveExpr = new PlainRule(this, 228, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 229 PlainRuleOp      */ __Matchers[229] = _exclusiveOperator = new PlainRule(this, 229, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 230 PlainRuleOp      */ __Matchers[230] = _intersectionExpression = new PlainRule(this, 230, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _intersectionExpr = new PlainRule(this, 231, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _intersectionOperator = new PlainRule(this, 232, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 233 PlainRuleOp      */ __Matchers[233] = _negationOrComplementExpression = new PlainRule(this, 233, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _negationOrComplementExpr = new PlainRule(this, 234, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _unaryMinusOrComplementOperator = new PlainRule(this, 235, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _negateOperator = new PlainRule(this, 236, "negate-operator") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _neutralOperator = new PlainRule(this, 237, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _complementOperator = new PlainRule(this, 238, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 239 PlainRuleOp      */ __Matchers[239] = _prefixExpression = new PlainRule(this, 239, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _prefixExpr = new PlainRule(this, 240, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _postfixExpression = new PlainRule(this, 241, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _postfixExpr = new PlainRule(this, 242, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _incrementOperator = new PlainRule(this, 243, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 244 PlainRuleOp      */ __Matchers[244] = _primary = new PlainRule(this, 244, "primary") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _selectionExpr = new PlainRule(this, 245, "selection-expr") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _memberSelectionOperator = new PlainRule(this, 246, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 247 PlainRuleOp      */ __Matchers[247] = _indexedExpr = new PlainRule(this, 247, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _index = new PlainRule(this, 248, "index") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _upperSpanned = new PlainRule(this, 249, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _lowerSpanned = new PlainRule(this, 250, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _spanned = new PlainRule(this, 251, "spanned") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _measured = new PlainRule(this, 252, "measured") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _indexExpression = new PlainRule(this, 253, "index-expression") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _callExpr = new PlainRule(this, 254, "call-expr") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _baseExpression = new PlainRule(this, 255, "base-expression") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _nonstringLiteral = new PlainRule(this, 256, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _stringExpression = new PlainRule(this, 257, "string-expression") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _stringInterpolation = new PlainRule(this, 258, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _interpolationPart = new PlainRule(this, 259, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _stringLiteral = new PlainRule(this, 260, "string-literal") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _objectExpr = new PlainRule(this, 261, "object-expr") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _groupedExpr = new PlainRule(this, 262, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _typeArguments = new PlainRule(this, 263, "type-arguments") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _typeArgumentList = new PlainRule(this, 264, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _variancedType = new PlainRule(this, 265, "varianced-type") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _defaultedTypeList = new PlainRule(this, 266, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _defaultedType = new PlainRule(this, 267, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _defaultedTypeCore = new PlainRule(this, 268, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _variadicType = new PlainRule(this, 269, "variadic-type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _variadicTypeCore = new PlainRule(this, 270, "variadic-type-core") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _spreadType = new PlainRule(this, 271, "spread-type") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _type = new PlainRule(this, 272, "type") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _entryType = new PlainRule(this, 273, "entry-type") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _unionType = new PlainRule(this, 274, "union-type") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _unionTypeCore = new PlainRule(this, 275, "union-type-core") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _intersectionType = new PlainRule(this, 276, "intersection-type") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _intersectionTypeCore = new PlainRule(this, 277, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _primaryType = new PlainRule(this, 278, "primary-type") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _nullableType = new PlainRule(this, 279, "nullable-type") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _arrayType = new PlainRule(this, 280, "array-type") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _functionType = new PlainRule(this, 281, "function-type") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _typeTypeArguments = new PlainRule(this, 282, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _tupleType = new PlainRule(this, 283, "tuple-type") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _iterableType = new PlainRule(this, 284, "iterable-type") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _groupedType = new PlainRule(this, 285, "grouped-type") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _packageQualifiedType = new PlainRule(this, 286, "package-qualified-type") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _annotations = new PlainRule(this, 287, "annotations") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _annotation = new PlainRule(this, 288, "annotation") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _conditions = new PlainRule(this, 289, "conditions") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _conditionList = new PlainRule(this, 290, "condition-list") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _condition = new PlainRule(this, 291, "condition") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _existsCondition = new PlainRule(this, 292, "exists-condition") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _nonemptyCondition = new PlainRule(this, 293, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _letOrExpression = new PlainRule(this, 294, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _isCondition = new PlainRule(this, 295, "is-condition") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _isConditionVariable = new PlainRule(this, 296, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _satisfiesCondition = new PlainRule(this, 297, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _booleanCondition = new PlainRule(this, 298, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _controlStatement = new PlainRule(this, 299, "control-statement") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _ifElseStatement = new PlainRule(this, 300, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _elseIf = new PlainRule(this, 301, "else-if") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _elseBlock = new PlainRule(this, 302, "else-block") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _switchStatement = new PlainRule(this, 303, "switch-statement") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _caseBlock = new PlainRule(this, 304, "case-block") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _caseItem = new PlainRule(this, 305, "case-item") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _isCaseCondition = new PlainRule(this, 306, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _satisfiesCaseCondition = new PlainRule(this, 307, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _valueCaseList = new PlainRule(this, 308, "value-case-list") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _valueCaseSeparator = new PlainRule(this, 309, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 310 PlainRuleOp      */ __Matchers[310] = _valueCase = new PlainRule(this, 310, "value-case") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _forElseStatement = new PlainRule(this, 311, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _forIterator = new PlainRule(this, 312, "for-iterator") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _forVariable = new PlainRule(this, 313, "for-variable") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _containment = new PlainRule(this, 314, "containment") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _containmentOperator = new PlainRule(this, 315, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 316 PlainRuleOp      */ __Matchers[316] = _whileStatement = new PlainRule(this, 316, "while-statement") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _tryStatement = new PlainRule(this, 317, "try-statement") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _catchBlock = new PlainRule(this, 318, "catch-block") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _finallyBlock = new PlainRule(this, 319, "finally-block") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _resources = new PlainRule(this, 320, "resources") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _resourceList = new PlainRule(this, 321, "resource-list") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _resource = new PlainRule(this, 322, "resource") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _specifiedOrExpression = new PlainRule(this, 323, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _specifiedVariable = new PlainRule(this, 324, "specified-variable") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _variable = new PlainRule(this, 325, "variable") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _variableType = new PlainRule(this, 326, "variable-type") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _modelReference = new PlainRule(this, 327, "model-reference") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _metaLiteral = new PlainRule(this, 328, "meta-literal") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _metaExpression = new PlainRule(this, 329, "meta-expression") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _modelExpression = new PlainRule(this, 330, "model-expression") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _memberModelExpression = new PlainRule(this, 331, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _packageQualifiedMemberReference = new PlainRule(this, 332, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _typeQualifiedMemberReference = new PlainRule(this, 333, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _typeModelExpression = new PlainRule(this, 334, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _declarationReference = new PlainRule(this, 335, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _moduleLiteral = new PlainRule(this, 336, "module-literal") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _packageLiteral = new PlainRule(this, 337, "package-literal") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _classLiteral = new PlainRule(this, 338, "class-literal") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _interfaceLiteral = new PlainRule(this, 339, "interface-literal") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _aliasLiteral = new PlainRule(this, 340, "alias-literal") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _typeParameterLiteral = new PlainRule(this, 341, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _newLiteral = new PlainRule(this, 342, "new-literal") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _valueLiteral = new PlainRule(this, 343, "value-literal") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _objectLiteral = new PlainRule(this, 344, "object-literal") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _functionLiteral = new PlainRule(this, 345, "function-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _packageQualifier = new PlainRule(this, 346, "package-qualifier") { Builder = nodes => nodes[0] };
                /* 347 PlainRuleOp      */ __Matchers[347] = _referencePath = new PlainRule(this, 347, "reference-path") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _referencePathElementList = new PlainRule(this, 348, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 349 PlainRuleOp      */ __Matchers[349] = _referencePathElement = new PlainRule(this, 349, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 350 PlainRuleOp      */ __Matchers[350] = _kwVoid = new PlainRule(this, 350, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 351 PlainRuleOp      */ __Matchers[351] = _kwFunction = new PlainRule(this, 351, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 352 PlainRuleOp      */ __Matchers[352] = _kwValue = new PlainRule(this, 352, "kw-value") { Creator = node => new CKwValue(node) };
                /* 353 DfaRuleOp        */ __Matchers[353] = _literalFloat = new DfaRule(this, 353, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 354 DfaRuleOp        */ __Matchers[354] = _literalNatural = new DfaRule(this, 354, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 355 DfaRuleOp        */ __Matchers[355] = _literalChar = new DfaRule(this, 355, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 356 DfaRuleOp        */ __Matchers[356] = _stringStart = new DfaRule(this, 356, "string-start") { Creator = node => new CStringStart(node) };
                /* 357 DfaRuleOp        */ __Matchers[357] = _stringMid = new DfaRule(this, 357, "string-mid") { Creator = node => new CStringMid(node) };
                /* 358 DfaRuleOp        */ __Matchers[358] = _stringEnd = new DfaRule(this, 358, "string-end") { Creator = node => new CStringEnd(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _literalString = new DfaRule(this, 359, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _verbatimString = new DfaRule(this, 360, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _lowerIdentifier = new DfaRule(this, 361, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _upperIdentifier = new DfaRule(this, 362, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _identifier = new DfaRule(this, 363, "identifier") { Creator = node => new CIdentifier(node) };
                /* 364 EofOp            */ __Matchers[364] = new Eof(this, 364, "<eof>") { Creator = node => new REof(node) };
                /* 365 SeqOp            */ __Matchers[365] = new Seq(this, 365, "_365:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 366 AltOp            */ __Matchers[366] = new Alt(this, 366, "alt(>module-descriptor|>package-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 367 SeqOp            */ __Matchers[367] = new Seq(this, 367, "_367:(>imports,>namespace,>imports,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 368 StringOp         */ __Matchers[368] = new Keyword(this, 368, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 369 StringOp         */ __Matchers[369] = new String(this, 369, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 370 SeqOp            */ __Matchers[370] = new Seq(this, 370, "_370:(>annotations,'namespace',>namespace-path,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 371 StringOp         */ __Matchers[371] = new String(this, 371, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 372 SeqOp            */ __Matchers[372] = new Seq(this, 372, "_372:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /* 373 StarOp           */ __Matchers[373] = new Star(this, 373, "*(_372:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 374 SeqOp            */ __Matchers[374] = new Seq(this, 374, "_374:(>identifier,*(_372:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /* 375 StarOp           */ __Matchers[375] = new Star(this, 375, "*(>import-declaration)") { Builder = nodes => new CImports(nodes) };
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
                /* 392 AltOp            */ __Matchers[392] = new Alt(this, 392, "alt(>inferred-attribute-declaration|>module-import)") { Builder = nodes => nodes[0] };
                /* 393 StringOp         */ __Matchers[393] = new Keyword(this, 393, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 394 SeqOp            */ __Matchers[394] = new Seq(this, 394, "_394:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 395 StringOp         */ __Matchers[395] = new Keyword(this, 395, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 396 SeqOp            */ __Matchers[396] = new Seq(this, 396, "_396:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 397 SeqOp            */ __Matchers[397] = new Seq(this, 397, "_397:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 398 OptionalOp       */ __Matchers[398] = new Optional(this, 398, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 399 SeqOp            */ __Matchers[399] = new Seq(this, 399, "_399:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 400 StringOp         */ __Matchers[400] = new String(this, 400, "','", ",") { Creator = node => new RLiteral(node) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_401:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 402 StarOp           */ __Matchers[402] = new Star(this, 402, "*(_401:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 403 SeqOp            */ __Matchers[403] = new Seq(this, 403, "_403:(>import-element,*(_401:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 404 AltOp            */ __Matchers[404] = new Alt(this, 404, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 405 OptionalOp       */ __Matchers[405] = new Optional(this, 405, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 406 OptionalOp       */ __Matchers[406] = new Optional(this, 406, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 407 SeqOp            */ __Matchers[407] = new Seq(this, 407, "_407:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 408 StringOp         */ __Matchers[408] = new String(this, 408, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 409 SeqOp            */ __Matchers[409] = new Seq(this, 409, "_409:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 410 StringOp         */ __Matchers[410] = new String(this, 410, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 411 SeqOp            */ __Matchers[411] = new Seq(this, 411, "_411:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 412 StarOp           */ __Matchers[412] = new Star(this, 412, "*(_411:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 413 SeqOp            */ __Matchers[413] = new Seq(this, 413, "_413:(>package-name,*(_411:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 414 AltOp            */ __Matchers[414] = new Alt(this, 414, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 415 AltOp            */ __Matchers[415] = new Alt(this, 415, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 416 AltOp            */ __Matchers[416] = new Alt(this, 416, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 417 StringOp         */ __Matchers[417] = new String(this, 417, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 418 SeqOp            */ __Matchers[418] = new Seq(this, 418, "_418:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 419 StringOp         */ __Matchers[419] = new String(this, 419, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 420 OptionalOp       */ __Matchers[420] = new Optional(this, 420, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 421 StringOp         */ __Matchers[421] = new String(this, 421, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 422 SeqOp            */ __Matchers[422] = new Seq(this, 422, "_422:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 423 SeqOp            */ __Matchers[423] = new Seq(this, 423, "_423:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 424 StarOp           */ __Matchers[424] = new Star(this, 424, "*(_423:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Seq(this, 425, "_425:(>variadic-pattern,*(_423:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 426 AltOp            */ __Matchers[426] = new Alt(this, 426, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 427 OptionalOp       */ __Matchers[427] = new Optional(this, 427, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 428 SeqOp            */ __Matchers[428] = new Seq(this, 428, "_428:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 429 StringOp         */ __Matchers[429] = new String(this, 429, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 430 StringOp         */ __Matchers[430] = new String(this, 430, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 431 AltOp            */ __Matchers[431] = new Alt(this, 431, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 432 StringOp         */ __Matchers[432] = new Keyword(this, 432, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 434 StringOp         */ __Matchers[434] = new String(this, 434, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 435 SeqOp            */ __Matchers[435] = new Seq(this, 435, "_435:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 436 SeqOp            */ __Matchers[436] = new Seq(this, 436, "_436:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 437 StarOp           */ __Matchers[437] = new Star(this, 437, "*(_436:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 438 SeqOp            */ __Matchers[438] = new Seq(this, 438, "_438:(>let-variable,*(_436:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 439 SeqOp            */ __Matchers[439] = new Seq(this, 439, "_439:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 440 StringOp         */ __Matchers[440] = new Keyword(this, 440, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 441 SeqOp            */ __Matchers[441] = new Seq(this, 441, "_441:('extends',>class-instantiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 442 OptionalOp       */ __Matchers[442] = new Optional(this, 442, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 443 StringOp         */ __Matchers[443] = new Keyword(this, 443, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 444 SeqOp            */ __Matchers[444] = new Seq(this, 444, "_444:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_445:('{',>imports,>statements,'}')") { Builder = nodes => new CBlock(nodes) };
                /* 446 SeqOp            */ __Matchers[446] = new Seq(this, 446, "_446:('extends',>class-instantiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 447 StringOp         */ __Matchers[447] = new String(this, 447, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 448 SeqOp            */ __Matchers[448] = new Seq(this, 448, "_448:('=>',>class-instantiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 449 OptionalOp       */ __Matchers[449] = new Optional(this, 449, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_450:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstantiation(nodes) };
                /* 451 AltOp            */ __Matchers[451] = new Alt(this, 451, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 452 SeqOp            */ __Matchers[452] = new Seq(this, 452, "_452:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 453 StringOp         */ __Matchers[453] = new Keyword(this, 453, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 454 SeqOp            */ __Matchers[454] = new Seq(this, 454, "_454:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 455 AltOp            */ __Matchers[455] = new Alt(this, 455, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 457 SeqOp            */ __Matchers[457] = new Seq(this, 457, "_457:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 458 StarOp           */ __Matchers[458] = new Star(this, 458, "*(_457:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 459 SeqOp            */ __Matchers[459] = new Seq(this, 459, "_459:(>type-reference,*(_457:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 460 StringOp         */ __Matchers[460] = new Keyword(this, 460, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_461:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 462 SeqOp            */ __Matchers[462] = new Seq(this, 462, "_462:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 463 StarOp           */ __Matchers[463] = new Star(this, 463, "*(_462:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 464 SeqOp            */ __Matchers[464] = new Seq(this, 464, "_464:(>union-type,*(_462:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 465 StringOp         */ __Matchers[465] = new Keyword(this, 465, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 466 SeqOp            */ __Matchers[466] = new Seq(this, 466, "_466:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 467 StringOp         */ __Matchers[467] = new String(this, 467, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 468 SeqOp            */ __Matchers[468] = new Seq(this, 468, "_468:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 469 StarOp           */ __Matchers[469] = new Star(this, 469, "*(_468:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 470 SeqOp            */ __Matchers[470] = new Seq(this, 470, "_470:(>case-type,*(_468:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 471 AltOp            */ __Matchers[471] = new Alt(this, 471, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 472 OptionalOp       */ __Matchers[472] = new Optional(this, 472, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 473 SeqOp            */ __Matchers[473] = new Seq(this, 473, "_473:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 474 OptionalOp       */ __Matchers[474] = new Optional(this, 474, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_475:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 476 SeqOp            */ __Matchers[476] = new Seq(this, 476, "_476:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 477 StarOp           */ __Matchers[477] = new Star(this, 477, "*(_476:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 478 SeqOp            */ __Matchers[478] = new Seq(this, 478, "_478:(>parameter-declaration-or-ref-pattern,*(_476:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 479 AltOp            */ __Matchers[479] = new Alt(this, 479, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_480:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 481 OptionalOp       */ __Matchers[481] = new Optional(this, 481, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 482 SeqOp            */ __Matchers[482] = new Seq(this, 482, "_482:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 483 AltOp            */ __Matchers[483] = new Alt(this, 483, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 484 AltOp            */ __Matchers[484] = new Alt(this, 484, "alt(>void-function-parameter|>inferred-function-parameter|>typed-function-parameter)") { Builder = nodes => nodes[0] };
                /* 485 StringOp         */ __Matchers[485] = new Keyword(this, 485, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 486 OptionalOp       */ __Matchers[486] = new Optional(this, 486, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 487 PlusOp           */ __Matchers[487] = new Plus(this, 487, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 488 OptionalOp       */ __Matchers[488] = new Optional(this, 488, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 489 SeqOp            */ __Matchers[489] = new Seq(this, 489, "_489:('void',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CVoidFunctionParameter(nodes) };
                /* 490 StringOp         */ __Matchers[490] = new Keyword(this, 490, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 491 SeqOp            */ __Matchers[491] = new Seq(this, 491, "_491:('function',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CInferredFunctionParameter(nodes) };
                /* 492 SeqOp            */ __Matchers[492] = new Seq(this, 492, "_492:(>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CTypedFunctionParameter(nodes) };
                /* 493 AltOp            */ __Matchers[493] = new Alt(this, 493, "alt(>inferred-value-parameter|>typed-value-parameter)") { Builder = nodes => nodes[0] };
                /* 494 StringOp         */ __Matchers[494] = new Keyword(this, 494, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 495 SeqOp            */ __Matchers[495] = new Seq(this, 495, "_495:('value',>member-name,?(>value-specifier))") { Builder = nodes => new CInferredValueParameter(nodes) };
                /* 496 SeqOp            */ __Matchers[496] = new Seq(this, 496, "_496:(>variadic-type,>member-name,?(>value-specifier))") { Builder = nodes => new CTypedValueParameter(nodes) };
                /* 497 StringOp         */ __Matchers[497] = new String(this, 497, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 498 StringOp         */ __Matchers[498] = new String(this, 498, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 499 SeqOp            */ __Matchers[499] = new Seq(this, 499, "_499:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 500 SeqOp            */ __Matchers[500] = new Seq(this, 500, "_500:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 501 StarOp           */ __Matchers[501] = new Star(this, 501, "*(_500:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 502 SeqOp            */ __Matchers[502] = new Seq(this, 502, "_502:(>type-parameter,*(_500:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 503 OptionalOp       */ __Matchers[503] = new Optional(this, 503, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 504 OptionalOp       */ __Matchers[504] = new Optional(this, 504, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 505 SeqOp            */ __Matchers[505] = new Seq(this, 505, "_505:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 506 StringOp         */ __Matchers[506] = new Keyword(this, 506, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 507 StringOp         */ __Matchers[507] = new Keyword(this, 507, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 508 AltOp            */ __Matchers[508] = new Alt(this, 508, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 509 SeqOp            */ __Matchers[509] = new Seq(this, 509, "_509:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 510 StringOp         */ __Matchers[510] = new Keyword(this, 510, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 511 OptionalOp       */ __Matchers[511] = new Optional(this, 511, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 512 OptionalOp       */ __Matchers[512] = new Optional(this, 512, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 513 OptionalOp       */ __Matchers[513] = new Optional(this, 513, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 514 SeqOp            */ __Matchers[514] = new Seq(this, 514, "_514:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 515 PlusOp           */ __Matchers[515] = new Plus(this, 515, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 516 StarOp           */ __Matchers[516] = new Star(this, 516, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 517 AltOp            */ __Matchers[517] = new Alt(this, 517, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 518 StringOp         */ __Matchers[518] = new Keyword(this, 518, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 519 OptionalOp       */ __Matchers[519] = new Optional(this, 519, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 520 OptionalOp       */ __Matchers[520] = new Optional(this, 520, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 521 SeqOp            */ __Matchers[521] = new Seq(this, 521, "_521:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 522 StringOp         */ __Matchers[522] = new Keyword(this, 522, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 523 OptionalOp       */ __Matchers[523] = new Optional(this, 523, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 524 SeqOp            */ __Matchers[524] = new Seq(this, 524, "_524:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 525 SeqOp            */ __Matchers[525] = new Seq(this, 525, "_525:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 527 OptionalOp       */ __Matchers[527] = new Optional(this, 527, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 528 SeqOp            */ __Matchers[528] = new Seq(this, 528, "_528:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 529 StringOp         */ __Matchers[529] = new Keyword(this, 529, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_530:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 531 AltOp            */ __Matchers[531] = new Alt(this, 531, "alt(>block|>required-function-specifier)") { Builder = nodes => nodes[0] };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_532:(>annotations,'void',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 533 SeqOp            */ __Matchers[533] = new Seq(this, 533, "_533:(>annotations,'function',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 534 SeqOp            */ __Matchers[534] = new Seq(this, 534, "_534:(>annotations,>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 535 SeqOp            */ __Matchers[535] = new Seq(this, 535, "_535:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 536 SeqOp            */ __Matchers[536] = new Seq(this, 536, "_536:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 537 AltOp            */ __Matchers[537] = new Alt(this, 537, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 538 OptionalOp       */ __Matchers[538] = new Optional(this, 538, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 539 SeqOp            */ __Matchers[539] = new Seq(this, 539, "_539:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 540 StringOp         */ __Matchers[540] = new Keyword(this, 540, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 541 OptionalOp       */ __Matchers[541] = new Optional(this, 541, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 542 SeqOp            */ __Matchers[542] = new Seq(this, 542, "_542:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 543 AltOp            */ __Matchers[543] = new Alt(this, 543, "alt(>block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 544 OptionalOp       */ __Matchers[544] = new Optional(this, 544, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 545 SeqOp            */ __Matchers[545] = new Seq(this, 545, "_545:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 546 StringOp         */ __Matchers[546] = new Keyword(this, 546, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 547 SeqOp            */ __Matchers[547] = new Seq(this, 547, "_547:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 548 AltOp            */ __Matchers[548] = new Alt(this, 548, "alt(>block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 549 OptionalOp       */ __Matchers[549] = new Optional(this, 549, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 550 SeqOp            */ __Matchers[550] = new Seq(this, 550, "_550:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 551 StarOp           */ __Matchers[551] = new Star(this, 551, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 552 AltOp            */ __Matchers[552] = new Alt(this, 552, "alt(>declaration-statement|>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 553 SeqOp            */ __Matchers[553] = new Seq(this, 553, "_553:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 554 AltOp            */ __Matchers[554] = new Alt(this, 554, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 555 SeqOp            */ __Matchers[555] = new Seq(this, 555, "_555:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 556 AltOp            */ __Matchers[556] = new Alt(this, 556, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 557 StringOp         */ __Matchers[557] = new Keyword(this, 557, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 558 OptionalOp       */ __Matchers[558] = new Optional(this, 558, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 559 SeqOp            */ __Matchers[559] = new Seq(this, 559, "_559:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 560 StringOp         */ __Matchers[560] = new Keyword(this, 560, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 561 SeqOp            */ __Matchers[561] = new Seq(this, 561, "_561:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 562 StringOp         */ __Matchers[562] = new Keyword(this, 562, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 563 StringOp         */ __Matchers[563] = new Keyword(this, 563, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_564:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_565:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 566 SeqOp            */ __Matchers[566] = new Seq(this, 566, "_566:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 567 AltOp            */ __Matchers[567] = new Alt(this, 567, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 568 AltOp            */ __Matchers[568] = new Alt(this, 568, "alt(>base-reference|>self-reference|>parametrized-member|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 569 AltOp            */ __Matchers[569] = new Alt(this, 569, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 571 SeqOp            */ __Matchers[571] = new Seq(this, 571, "_571:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 572 OptionalOp       */ __Matchers[572] = new Optional(this, 572, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 573 SeqOp            */ __Matchers[573] = new Seq(this, 573, "_573:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 574 SeqOp            */ __Matchers[574] = new Seq(this, 574, "_574:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 575 SeqOp            */ __Matchers[575] = new Seq(this, 575, "_575:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 576 StringOp         */ __Matchers[576] = new Keyword(this, 576, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 577 StringOp         */ __Matchers[577] = new Keyword(this, 577, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 578 AltOp            */ __Matchers[578] = new Alt(this, 578, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 579 OptionalOp       */ __Matchers[579] = new Optional(this, 579, "?(>sequenced-argument-list)") { Builder = nodes => new ROptional<CSequencedArgumentList>(nodes) };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_580:('{',>statements,?(>sequenced-argument-list),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 581 SeqOp            */ __Matchers[581] = new Seq(this, 581, "_581:('[',?(>sequenced-argument-list),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 582 AltOp            */ __Matchers[582] = new Alt(this, 582, "alt(>patterned-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 583 StarOp           */ __Matchers[583] = new Star(this, 583, "*(>structured-argument)") { Builder = nodes => new RStar<ICStructuredArgument>(nodes) };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_584:('{',*(>structured-argument),?(>sequenced-argument-list),'}')") { Builder = nodes => new CPatternedArguments(nodes) };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_585:('(',?(>sequenced-argument-list),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 586 AltOp            */ __Matchers[586] = new Alt(this, 586, "alt(>anonymous-argument|>named-argument)") { Builder = nodes => nodes[0] };
                /* 587 SeqOp            */ __Matchers[587] = new Seq(this, 587, "_587:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 588 AltOp            */ __Matchers[588] = new Alt(this, 588, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 589 SeqOp            */ __Matchers[589] = new Seq(this, 589, "_589:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 590 SeqOp            */ __Matchers[590] = new Seq(this, 590, "_590:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 591 StarOp           */ __Matchers[591] = new Star(this, 591, "*(_590:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 592 SeqOp            */ __Matchers[592] = new Seq(this, 592, "_592:(>sequenced-argument,*(_590:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArgumentList(nodes) };
                /* 593 AltOp            */ __Matchers[593] = new Alt(this, 593, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 594 AltOp            */ __Matchers[594] = new Alt(this, 594, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_595:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 596 SeqOp            */ __Matchers[596] = new Seq(this, 596, "_596:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 597 AltOp            */ __Matchers[597] = new Alt(this, 597, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_598:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 599 SeqOp            */ __Matchers[599] = new Seq(this, 599, "_599:(>function-specifier,';')") { Builder = nodes => new CRequiredFunctionSpecifier(nodes) };
                /* 600 AltOp            */ __Matchers[600] = new Alt(this, 600, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 601 SeqOp            */ __Matchers[601] = new Seq(this, 601, "_601:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 602 SeqOp            */ __Matchers[602] = new Seq(this, 602, "_602:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_603:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 604 SeqOp            */ __Matchers[604] = new Seq(this, 604, "_604:(>member-name,+(>parameters),>required-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_605:(>member-name,>required-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 606 AltOp            */ __Matchers[606] = new Alt(this, 606, "alt(>expression-argument|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 608 OptionalOp       */ __Matchers[608] = new Optional(this, 608, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 609 SeqOp            */ __Matchers[609] = new Seq(this, 609, "_609:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 610 PlusOp           */ __Matchers[610] = new Plus(this, 610, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 611 OptionalOp       */ __Matchers[611] = new Optional(this, 611, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 612 SeqOp            */ __Matchers[612] = new Seq(this, 612, "_612:(>switch-header,+(>case-expression),?(>else-expression))") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 613 StringOp         */ __Matchers[613] = new Keyword(this, 613, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_614:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 615 StringOp         */ __Matchers[615] = new Keyword(this, 615, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 616 OptionalOp       */ __Matchers[616] = new Optional(this, 616, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 617 StringOp         */ __Matchers[617] = new Keyword(this, 617, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 618 SeqOp            */ __Matchers[618] = new Seq(this, 618, "_618:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 619 StringOp         */ __Matchers[619] = new Keyword(this, 619, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 620 SeqOp            */ __Matchers[620] = new Seq(this, 620, "_620:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 621 SeqOp            */ __Matchers[621] = new Seq(this, 621, "_621:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 622 StringOp         */ __Matchers[622] = new Keyword(this, 622, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 623 SeqOp            */ __Matchers[623] = new Seq(this, 623, "_623:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 624 AltOp            */ __Matchers[624] = new Alt(this, 624, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 625 AltOp            */ __Matchers[625] = new Alt(this, 625, "alt(>void-function-expr|>inferred-function-expr)") { Builder = nodes => nodes[0] };
                /* 626 SeqOp            */ __Matchers[626] = new Seq(this, 626, "_626:('void',?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CVoidFunctionExpr(nodes) };
                /* 627 OptionalOp       */ __Matchers[627] = new Optional(this, 627, "?('function')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 628 SeqOp            */ __Matchers[628] = new Seq(this, 628, "_628:(?('function'),?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CInferredFunctionExpr(nodes) };
                /* 629 AltOp            */ __Matchers[629] = new Alt(this, 629, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 630 AltOp            */ __Matchers[630] = new Alt(this, 630, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 631 AltOp            */ __Matchers[631] = new Alt(this, 631, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 632 StringOp         */ __Matchers[632] = new Keyword(this, 632, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 633 OptionalOp       */ __Matchers[633] = new Optional(this, 633, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 634 SeqOp            */ __Matchers[634] = new Seq(this, 634, "_634:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 635 SeqOp            */ __Matchers[635] = new Seq(this, 635, "_635:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 636 AltOp            */ __Matchers[636] = new Alt(this, 636, "alt(>let-expr|>if-expr|>switch-expr|>function-expression|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 637 AltOp            */ __Matchers[637] = new Alt(this, 637, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 638 SeqOp            */ __Matchers[638] = new Seq(this, 638, "_638:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 639 StringOp         */ __Matchers[639] = new String(this, 639, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 640 StringOp         */ __Matchers[640] = new String(this, 640, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 647 StringOp         */ __Matchers[647] = new String(this, 647, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 648 StringOp         */ __Matchers[648] = new String(this, 648, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 649 StringOp         */ __Matchers[649] = new String(this, 649, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 650 AltOp            */ __Matchers[650] = new Alt(this, 650, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 651 AltOp            */ __Matchers[651] = new Alt(this, 651, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 652 SeqOp            */ __Matchers[652] = new Seq(this, 652, "_652:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 653 AltOp            */ __Matchers[653] = new Alt(this, 653, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 654 AltOp            */ __Matchers[654] = new Alt(this, 654, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 655 SeqOp            */ __Matchers[655] = new Seq(this, 655, "_655:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 656 StringOp         */ __Matchers[656] = new String(this, 656, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 657 AltOp            */ __Matchers[657] = new Alt(this, 657, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 658 SeqOp            */ __Matchers[658] = new Seq(this, 658, "_658:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 659 StringOp         */ __Matchers[659] = new String(this, 659, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 660 AltOp            */ __Matchers[660] = new Alt(this, 660, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 661 SeqOp            */ __Matchers[661] = new Seq(this, 661, "_661:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 662 StringOp         */ __Matchers[662] = new String(this, 662, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 663 AltOp            */ __Matchers[663] = new Alt(this, 663, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 664 AltOp            */ __Matchers[664] = new Alt(this, 664, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 665 SeqOp            */ __Matchers[665] = new Seq(this, 665, "_665:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 666 StringOp         */ __Matchers[666] = new String(this, 666, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 667 StringOp         */ __Matchers[667] = new String(this, 667, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 668 StringOp         */ __Matchers[668] = new String(this, 668, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 669 AltOp            */ __Matchers[669] = new Alt(this, 669, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 670 AltOp            */ __Matchers[670] = new Alt(this, 670, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_671:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 672 SeqOp            */ __Matchers[672] = new Seq(this, 672, "_672:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 673 SeqOp            */ __Matchers[673] = new Seq(this, 673, "_673:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 674 SeqOp            */ __Matchers[674] = new Seq(this, 674, "_674:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 675 SeqOp            */ __Matchers[675] = new Seq(this, 675, "_675:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 676 SeqOp            */ __Matchers[676] = new Seq(this, 676, "_676:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 677 StringOp         */ __Matchers[677] = new String(this, 677, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 678 AltOp            */ __Matchers[678] = new Alt(this, 678, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 679 StringOp         */ __Matchers[679] = new String(this, 679, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 680 AltOp            */ __Matchers[680] = new Alt(this, 680, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 681 StringOp         */ __Matchers[681] = new String(this, 681, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 682 AltOp            */ __Matchers[682] = new Alt(this, 682, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 683 StringOp         */ __Matchers[683] = new Keyword(this, 683, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 684 AltOp            */ __Matchers[684] = new Alt(this, 684, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 685 AltOp            */ __Matchers[685] = new Alt(this, 685, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 686 StringOp         */ __Matchers[686] = new Keyword(this, 686, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 687 SeqOp            */ __Matchers[687] = new Seq(this, 687, "_687:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 688 StringOp         */ __Matchers[688] = new Keyword(this, 688, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 689 SeqOp            */ __Matchers[689] = new Seq(this, 689, "_689:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 690 AltOp            */ __Matchers[690] = new Alt(this, 690, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 691 SeqOp            */ __Matchers[691] = new Seq(this, 691, "_691:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 692 SeqOp            */ __Matchers[692] = new Seq(this, 692, "_692:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 693 StringOp         */ __Matchers[693] = new String(this, 693, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 694 AltOp            */ __Matchers[694] = new Alt(this, 694, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 695 AltOp            */ __Matchers[695] = new Alt(this, 695, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 696 SeqOp            */ __Matchers[696] = new Seq(this, 696, "_696:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
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
                /* 732 SeqOp            */ __Matchers[732] = new Seq(this, 732, "_732:(>primary,>member-selection-operator,>base-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 733 StringOp         */ __Matchers[733] = new String(this, 733, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 734 StringOp         */ __Matchers[734] = new String(this, 734, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 735 AltOp            */ __Matchers[735] = new Alt(this, 735, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 736 SeqOp            */ __Matchers[736] = new Seq(this, 736, "_736:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 737 AltOp            */ __Matchers[737] = new Alt(this, 737, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_738:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_740:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_741:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 742 SeqOp            */ __Matchers[742] = new Seq(this, 742, "_742:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 743 AltOp            */ __Matchers[743] = new Alt(this, 743, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 744 AltOp            */ __Matchers[744] = new Alt(this, 744, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 745 AltOp            */ __Matchers[745] = new Alt(this, 745, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 746 StarOp           */ __Matchers[746] = new Star(this, 746, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 747 SeqOp            */ __Matchers[747] = new Seq(this, 747, "_747:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_748:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 749 AltOp            */ __Matchers[749] = new Alt(this, 749, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_750:('object',?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 751 SeqOp            */ __Matchers[751] = new Seq(this, 751, "_751:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 752 OptionalOp       */ __Matchers[752] = new Optional(this, 752, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_753:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_754:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 755 StarOp           */ __Matchers[755] = new Star(this, 755, "*(_754:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_756:(>varianced-type,*(_754:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_757:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 758 SeqOp            */ __Matchers[758] = new Seq(this, 758, "_758:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 759 StarOp           */ __Matchers[759] = new Star(this, 759, "*(_758:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 760 SeqOp            */ __Matchers[760] = new Seq(this, 760, "_760:(>defaulted-type,*(_758:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 761 AltOp            */ __Matchers[761] = new Alt(this, 761, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 762 SeqOp            */ __Matchers[762] = new Seq(this, 762, "_762:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 763 AltOp            */ __Matchers[763] = new Alt(this, 763, "alt(>variadic-type-core|>type)") { Builder = nodes => nodes[0] };
                /* 764 SeqOp            */ __Matchers[764] = new Seq(this, 764, "_764:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicTypeCore(nodes) };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_765:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 766 AltOp            */ __Matchers[766] = new Alt(this, 766, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_767:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 768 AltOp            */ __Matchers[768] = new Alt(this, 768, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_769:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 770 AltOp            */ __Matchers[770] = new Alt(this, 770, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 771 SeqOp            */ __Matchers[771] = new Seq(this, 771, "_771:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 772 AltOp            */ __Matchers[772] = new Alt(this, 772, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>package-qualified-type|>type-path)") { Builder = nodes => nodes[0] };
                /* 773 StringOp         */ __Matchers[773] = new String(this, 773, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 774 SeqOp            */ __Matchers[774] = new Seq(this, 774, "_774:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 775 OptionalOp       */ __Matchers[775] = new Optional(this, 775, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 776 SeqOp            */ __Matchers[776] = new Seq(this, 776, "_776:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 777 OptionalOp       */ __Matchers[777] = new Optional(this, 777, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_778:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 779 AltOp            */ __Matchers[779] = new Alt(this, 779, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 780 SeqOp            */ __Matchers[780] = new Seq(this, 780, "_780:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 781 OptionalOp       */ __Matchers[781] = new Optional(this, 781, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_782:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 783 SeqOp            */ __Matchers[783] = new Seq(this, 783, "_783:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 784 SeqOp            */ __Matchers[784] = new Seq(this, 784, "_784:('package','.',>type-path)") { Builder = nodes => new CPackageQualifiedType(nodes) };
                /* 785 OptionalOp       */ __Matchers[785] = new Optional(this, 785, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 786 StarOp           */ __Matchers[786] = new Star(this, 786, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 787 SeqOp            */ __Matchers[787] = new Seq(this, 787, "_787:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 788 SeqOp            */ __Matchers[788] = new Seq(this, 788, "_788:(>member-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 789 OptionalOp       */ __Matchers[789] = new Optional(this, 789, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_790:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_791:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 792 StarOp           */ __Matchers[792] = new Star(this, 792, "*(_791:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 793 SeqOp            */ __Matchers[793] = new Seq(this, 793, "_793:(>condition,*(_791:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 794 AltOp            */ __Matchers[794] = new Alt(this, 794, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 795 OptionalOp       */ __Matchers[795] = new Optional(this, 795, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 796 SeqOp            */ __Matchers[796] = new Seq(this, 796, "_796:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 797 SeqOp            */ __Matchers[797] = new Seq(this, 797, "_797:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 798 AltOp            */ __Matchers[798] = new Alt(this, 798, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 800 SeqOp            */ __Matchers[800] = new Seq(this, 800, "_800:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 801 SeqOp            */ __Matchers[801] = new Seq(this, 801, "_801:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 802 AltOp            */ __Matchers[802] = new Alt(this, 802, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 803 StarOp           */ __Matchers[803] = new Star(this, 803, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 804 OptionalOp       */ __Matchers[804] = new Optional(this, 804, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 805 SeqOp            */ __Matchers[805] = new Seq(this, 805, "_805:('if',>conditions,>block,*(>else-if),?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 806 SeqOp            */ __Matchers[806] = new Seq(this, 806, "_806:('else','if',>conditions,>block)") { Builder = nodes => new CElseIf(nodes) };
                /* 807 SeqOp            */ __Matchers[807] = new Seq(this, 807, "_807:('else',>block)") { Builder = nodes => new CElseBlock(nodes) };
                /* 808 PlusOp           */ __Matchers[808] = new Plus(this, 808, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 809 SeqOp            */ __Matchers[809] = new Seq(this, 809, "_809:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 810 SeqOp            */ __Matchers[810] = new Seq(this, 810, "_810:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 811 AltOp            */ __Matchers[811] = new Alt(this, 811, "alt(>is-case-condition|>satisfies-case-condition|>value-case-list|>pattern)") { Builder = nodes => nodes[0] };
                /* 812 SeqOp            */ __Matchers[812] = new Seq(this, 812, "_812:('is',>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 813 SeqOp            */ __Matchers[813] = new Seq(this, 813, "_813:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_814:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 815 StarOp           */ __Matchers[815] = new Star(this, 815, "*(_814:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 816 SeqOp            */ __Matchers[816] = new Seq(this, 816, "_816:(>value-case,*(_814:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 817 AltOp            */ __Matchers[817] = new Alt(this, 817, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 818 AltOp            */ __Matchers[818] = new Alt(this, 818, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 819 SeqOp            */ __Matchers[819] = new Seq(this, 819, "_819:('for','(',?(>for-iterator),')',>block,?(>else-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 820 OptionalOp       */ __Matchers[820] = new Optional(this, 820, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 821 SeqOp            */ __Matchers[821] = new Seq(this, 821, "_821:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 822 AltOp            */ __Matchers[822] = new Alt(this, 822, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 823 SeqOp            */ __Matchers[823] = new Seq(this, 823, "_823:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 824 AltOp            */ __Matchers[824] = new Alt(this, 824, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 825 StringOp         */ __Matchers[825] = new Keyword(this, 825, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 826 SeqOp            */ __Matchers[826] = new Seq(this, 826, "_826:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 827 StringOp         */ __Matchers[827] = new Keyword(this, 827, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 828 OptionalOp       */ __Matchers[828] = new Optional(this, 828, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 829 StarOp           */ __Matchers[829] = new Star(this, 829, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 830 OptionalOp       */ __Matchers[830] = new Optional(this, 830, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 831 SeqOp            */ __Matchers[831] = new Seq(this, 831, "_831:('try',?(>resources),>block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 832 StringOp         */ __Matchers[832] = new Keyword(this, 832, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 833 OptionalOp       */ __Matchers[833] = new Optional(this, 833, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 834 SeqOp            */ __Matchers[834] = new Seq(this, 834, "_834:('catch','(',?(>variable),')',>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 835 StringOp         */ __Matchers[835] = new Keyword(this, 835, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 836 SeqOp            */ __Matchers[836] = new Seq(this, 836, "_836:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 837 OptionalOp       */ __Matchers[837] = new Optional(this, 837, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 838 SeqOp            */ __Matchers[838] = new Seq(this, 838, "_838:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 839 SeqOp            */ __Matchers[839] = new Seq(this, 839, "_839:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 840 StarOp           */ __Matchers[840] = new Star(this, 840, "*(_839:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_841:(>resource,*(_839:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 842 AltOp            */ __Matchers[842] = new Alt(this, 842, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 843 SeqOp            */ __Matchers[843] = new Seq(this, 843, "_843:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 844 OptionalOp       */ __Matchers[844] = new Optional(this, 844, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 845 StarOp           */ __Matchers[845] = new Star(this, 845, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_846:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 847 AltOp            */ __Matchers[847] = new Alt(this, 847, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 848 SeqOp            */ __Matchers[848] = new Seq(this, 848, "_848:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 849 StringOp         */ __Matchers[849] = new String(this, 849, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 850 SeqOp            */ __Matchers[850] = new Seq(this, 850, "_850:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 851 AltOp            */ __Matchers[851] = new Alt(this, 851, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 852 AltOp            */ __Matchers[852] = new Alt(this, 852, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 853 AltOp            */ __Matchers[853] = new Alt(this, 853, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 854 SeqOp            */ __Matchers[854] = new Seq(this, 854, "_854:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 855 SeqOp            */ __Matchers[855] = new Seq(this, 855, "_855:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 856 AltOp            */ __Matchers[856] = new Alt(this, 856, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>object-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 857 OptionalOp       */ __Matchers[857] = new Optional(this, 857, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 858 SeqOp            */ __Matchers[858] = new Seq(this, 858, "_858:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 859 SeqOp            */ __Matchers[859] = new Seq(this, 859, "_859:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 860 SeqOp            */ __Matchers[860] = new Seq(this, 860, "_860:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 861 SeqOp            */ __Matchers[861] = new Seq(this, 861, "_861:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 862 SeqOp            */ __Matchers[862] = new Seq(this, 862, "_862:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 863 SeqOp            */ __Matchers[863] = new Seq(this, 863, "_863:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 864 SeqOp            */ __Matchers[864] = new Seq(this, 864, "_864:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_865:('value',>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_866:('object',>reference-path)") { Builder = nodes => new CObjectLiteral(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_867:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_868:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 871 StarOp           */ __Matchers[871] = new Star(this, 871, "*(_870:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_872:(>reference-path-element,*(_870:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[365]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[366]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[367]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[370]);
                /*   6 PlainRuleOp      */ _namespacePath.Set(__Matchers[374]);
                /*   7 PlainRuleOp      */ _imports.Set(__Matchers[375]);
                /*   8 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[379]);
                /*   9 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[382]);
                /*  10 PlainRuleOp      */ _repository.Set(_identifier);
                /*  11 PlainRuleOp      */ _module.Set(__Matchers[383]);
                /*  12 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[385]);
                /*  13 PlainRuleOp      */ _artifact.Set(__Matchers[386]);
                /*  14 PlainRuleOp      */ _classifier.Set(__Matchers[387]);
                /*  15 PlainRuleOp      */ _version.Set(_literalString);
                /*  16 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  17 PlainRuleOp      */ _moduleBody.Set(__Matchers[391]);
                /*  18 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[392]);
                /*  19 PlainRuleOp      */ _moduleImport.Set(__Matchers[394]);
                /*  20 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[396]);
                /*  21 PlainRuleOp      */ _importDeclaration.Set(__Matchers[397]);
                /*  22 PlainRuleOp      */ _importElements.Set(__Matchers[399]);
                /*  23 PlainRuleOp      */ _importElementList.Set(__Matchers[403]);
                /*  24 PlainRuleOp      */ _importElement.Set(__Matchers[404]);
                /*  25 PlainRuleOp      */ _importNamed.Set(__Matchers[407]);
                /*  26 PlainRuleOp      */ _importName.Set(_identifier);
                /*  27 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[409]);
                /*  28 PlainRuleOp      */ _importWildcard.Set(__Matchers[410]);
                /*  29 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  30 PlainRuleOp      */ _packagePath.Set(__Matchers[413]);
                /*  31 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  32 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  33 PlainRuleOp      */ _pattern.Set(__Matchers[414]);
                /*  34 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[415]);
                /*  35 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[416]);
                /*  36 PlainRuleOp      */ _entryPattern.Set(__Matchers[418]);
                /*  37 PlainRuleOp      */ _tuplePattern.Set(__Matchers[422]);
                /*  38 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[425]);
                /*  39 PlainRuleOp      */ _variadicPattern.Set(__Matchers[426]);
                /*  40 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  41 PlainRuleOp      */ _variadicVariable.Set(__Matchers[428]);
                /*  42 PlainRuleOp      */ _variadicOperator.Set(__Matchers[431]);
                /*  43 PlainRuleOp      */ _letStatement.Set(__Matchers[435]);
                /*  44 PlainRuleOp      */ _letVariableList.Set(__Matchers[438]);
                /*  45 PlainRuleOp      */ _letVariable.Set(__Matchers[439]);
                /*  46 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[441]);
                /*  47 PlainRuleOp      */ _assertionStatement.Set(__Matchers[444]);
                /*  48 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  49 PlainRuleOp      */ _block.Set(__Matchers[445]);
                /*  50 PlainRuleOp      */ _extendedType.Set(__Matchers[446]);
                /*  51 PlainRuleOp      */ _classSpecifier.Set(__Matchers[448]);
                /*  52 PlainRuleOp      */ _classInstantiation.Set(__Matchers[450]);
                /*  53 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[451]);
                /*  54 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[452]);
                /*  55 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[454]);
                /*  56 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[455]);
                /*  57 PlainRuleOp      */ _memberPath.Set(__Matchers[456]);
                /*  58 PlainRuleOp      */ _typePath.Set(__Matchers[459]);
                /*  59 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[461]);
                /*  60 PlainRuleOp      */ _unionTypeList.Set(__Matchers[464]);
                /*  61 PlainRuleOp      */ _caseTypes.Set(__Matchers[466]);
                /*  62 PlainRuleOp      */ _caseTypeList.Set(__Matchers[470]);
                /*  63 PlainRuleOp      */ _caseType.Set(__Matchers[471]);
                /*  64 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[473]);
                /*  65 PlainRuleOp      */ _parameters.Set(__Matchers[475]);
                /*  66 PlainRuleOp      */ _parameterList.Set(__Matchers[478]);
                /*  67 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[479]);
                /*  68 PlainRuleOp      */ _parameter.Set(__Matchers[480]);
                /*  69 PlainRuleOp      */ _parameterReference.Set(__Matchers[482]);
                /*  70 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[483]);
                /*  71 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[484]);
                /*  72 PlainRuleOp      */ _voidFunctionParameter.Set(__Matchers[489]);
                /*  73 PlainRuleOp      */ _inferredFunctionParameter.Set(__Matchers[491]);
                /*  74 PlainRuleOp      */ _typedFunctionParameter.Set(__Matchers[492]);
                /*  75 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[493]);
                /*  76 PlainRuleOp      */ _inferredValueParameter.Set(__Matchers[495]);
                /*  77 PlainRuleOp      */ _typedValueParameter.Set(__Matchers[496]);
                /*  78 PlainRuleOp      */ _typeParameters.Set(__Matchers[499]);
                /*  79 PlainRuleOp      */ _typeParameterList.Set(__Matchers[502]);
                /*  80 PlainRuleOp      */ _typeParameter.Set(__Matchers[505]);
                /*  81 PlainRuleOp      */ _variance.Set(__Matchers[508]);
                /*  82 PlainRuleOp      */ _typeDefault.Set(__Matchers[509]);
                /*  83 PlainRuleOp      */ _typeConstraint.Set(__Matchers[514]);
                /*  84 PlainRuleOp      */ _typeConstraints.Set(__Matchers[515]);
                /*  85 PlainRuleOp      */ _declarations.Set(__Matchers[516]);
                /*  86 PlainRuleOp      */ _declaration.Set(__Matchers[517]);
                /*  87 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[521]);
                /*  88 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[524]);
                /*  89 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[525]);
                /*  90 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[528]);
                /*  91 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[530]);
                /*  92 PlainRuleOp      */ _setterDefinition.Set(__Matchers[531]);
                /*  93 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[532]);
                /*  94 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[533]);
                /*  95 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[534]);
                /*  96 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[535]);
                /*  97 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[536]);
                /*  98 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[537]);
                /*  99 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[539]);
                /* 100 PlainRuleOp      */ _classDeclaration.Set(__Matchers[542]);
                /* 101 PlainRuleOp      */ _classDefinition.Set(__Matchers[543]);
                /* 102 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[545]);
                /* 103 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[547]);
                /* 104 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[548]);
                /* 105 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[550]);
                /* 106 PlainRuleOp      */ _statements.Set(__Matchers[551]);
                /* 107 PlainRuleOp      */ _statement.Set(__Matchers[552]);
                /* 108 PlainRuleOp      */ _declarationStatement.Set(_declaration);
                /* 109 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[553]);
                /* 110 PlainRuleOp      */ _openStatement.Set(__Matchers[554]);
                /* 111 PlainRuleOp      */ _specificationStatement.Set(__Matchers[555]);
                /* 112 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 113 PlainRuleOp      */ _directiveStatement.Set(__Matchers[556]);
                /* 114 PlainRuleOp      */ _returnStatement.Set(__Matchers[559]);
                /* 115 PlainRuleOp      */ _throwStatement.Set(__Matchers[561]);
                /* 116 PlainRuleOp      */ _breakStatement.Set(__Matchers[562]);
                /* 117 PlainRuleOp      */ _continueStatement.Set(__Matchers[563]);
                /* 118 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[564]);
                /* 119 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[565]);
                /* 120 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[566]);
                /* 121 PlainRuleOp      */ _anySpecifier.Set(__Matchers[567]);
                /* 122 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[568]);
                /* 123 PlainRuleOp      */ _baseReference.Set(__Matchers[569]);
                /* 124 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[570]);
                /* 125 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[571]);
                /* 126 PlainRuleOp      */ _memberReference.Set(__Matchers[573]);
                /* 127 PlainRuleOp      */ _typeReference.Set(__Matchers[574]);
                /* 128 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[575]);
                /* 129 PlainRuleOp      */ _selfReference.Set(__Matchers[578]);
                /* 130 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[580]);
                /* 131 PlainRuleOp      */ _tupleExpr.Set(__Matchers[581]);
                /* 132 PlainRuleOp      */ _arguments.Set(__Matchers[582]);
                /* 133 PlainRuleOp      */ _patternedArguments.Set(__Matchers[584]);
                /* 134 PlainRuleOp      */ _positionalArguments.Set(__Matchers[585]);
                /* 135 PlainRuleOp      */ _structuredArgument.Set(__Matchers[586]);
                /* 136 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[587]);
                /* 137 PlainRuleOp      */ _namedArgument.Set(__Matchers[588]);
                /* 138 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[589]);
                /* 139 PlainRuleOp      */ _sequencedArgumentList.Set(__Matchers[592]);
                /* 140 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[593]);
                /* 141 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[594]);
                /* 142 PlainRuleOp      */ _objectArgument.Set(__Matchers[595]);
                /* 143 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[596]);
                /* 144 PlainRuleOp      */ _methodDefinition.Set(__Matchers[597]);
                /* 145 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[598]);
                /* 146 PlainRuleOp      */ _requiredFunctionSpecifier.Set(__Matchers[599]);
                /* 147 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[600]);
                /* 148 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[601]);
                /* 149 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 150 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[602]);
                /* 151 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[603]);
                /* 152 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[604]);
                /* 153 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[605]);
                /* 154 PlainRuleOp      */ _positionalArgument.Set(__Matchers[606]);
                /* 155 PlainRuleOp      */ _expressionArgument.Set(_expression);
                /* 156 PlainRuleOp      */ _spreadArgument.Set(__Matchers[607]);
                /* 157 PlainRuleOp      */ _letExpr.Set(__Matchers[609]);
                /* 158 PlainRuleOp      */ _switchExpr.Set(__Matchers[612]);
                /* 159 PlainRuleOp      */ _switchHeader.Set(__Matchers[614]);
                /* 160 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 161 PlainRuleOp      */ _caseExpression.Set(__Matchers[618]);
                /* 162 PlainRuleOp      */ _ifExpr.Set(__Matchers[620]);
                /* 163 PlainRuleOp      */ _elseExpression.Set(__Matchers[621]);
                /* 164 PlainRuleOp      */ _thenExpression.Set(__Matchers[623]);
                /* 165 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[624]);
                /* 166 PlainRuleOp      */ _functionExpression.Set(__Matchers[625]);
                /* 167 PlainRuleOp      */ _voidFunctionExpr.Set(__Matchers[626]);
                /* 168 PlainRuleOp      */ _inferredFunctionExpr.Set(__Matchers[628]);
                /* 169 PlainRuleOp      */ _functionDefinition.Set(__Matchers[629]);
                /* 170 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[630]);
                /* 171 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[631]);
                /* 172 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 173 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[634]);
                /* 174 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[635]);
                /* 175 PlainRuleOp      */ _expression.Set(__Matchers[636]);
                /* 176 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 177 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[637]);
                /* 178 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[638]);
                /* 179 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[650]);
                /* 180 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[651]);
                /* 181 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[652]);
                /* 182 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[653]);
                /* 183 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[654]);
                /* 184 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[655]);
                /* 185 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[656]);
                /* 186 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[657]);
                /* 187 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[658]);
                /* 188 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[659]);
                /* 189 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[660]);
                /* 190 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[661]);
                /* 191 PlainRuleOp      */ _notOperator.Set(__Matchers[662]);
                /* 192 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[663]);
                /* 193 PlainRuleOp      */ _equalityExpression.Set(__Matchers[664]);
                /* 194 PlainRuleOp      */ _equalityExpr.Set(__Matchers[665]);
                /* 195 PlainRuleOp      */ _equalityOperator.Set(__Matchers[669]);
                /* 196 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[670]);
                /* 197 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[671]);
                /* 198 PlainRuleOp      */ _largerExpr.Set(__Matchers[672]);
                /* 199 PlainRuleOp      */ _smallerExpr.Set(__Matchers[673]);
                /* 200 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[674]);
                /* 201 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[675]);
                /* 202 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[676]);
                /* 203 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[678]);
                /* 204 PlainRuleOp      */ _smallerOperator.Set(__Matchers[680]);
                /* 205 PlainRuleOp      */ _largerOperator.Set(__Matchers[682]);
                /* 206 PlainRuleOp      */ _typeOperator.Set(__Matchers[684]);
                /* 207 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[685]);
                /* 208 PlainRuleOp      */ _existsExpr.Set(__Matchers[687]);
                /* 209 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[689]);
                /* 210 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[690]);
                /* 211 PlainRuleOp      */ _rangeExpr.Set(__Matchers[691]);
                /* 212 PlainRuleOp      */ _entryExpr.Set(__Matchers[692]);
                /* 213 PlainRuleOp      */ _rangeOperator.Set(__Matchers[694]);
                /* 214 PlainRuleOp      */ _entryOperator.Set(__Matchers[417]);
                /* 215 PlainRuleOp      */ _additiveExpression.Set(__Matchers[695]);
                /* 216 PlainRuleOp      */ _additiveExpr.Set(__Matchers[696]);
                /* 217 PlainRuleOp      */ _additiveOperator.Set(__Matchers[698]);
                /* 218 PlainRuleOp      */ _scaleExpression.Set(__Matchers[699]);
                /* 219 PlainRuleOp      */ _scaleExpr.Set(__Matchers[700]);
                /* 220 PlainRuleOp      */ _scaleOperator.Set(__Matchers[701]);
                /* 221 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[702]);
                /* 222 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[703]);
                /* 223 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[706]);
                /* 224 PlainRuleOp      */ _unionExpression.Set(__Matchers[707]);
                /* 225 PlainRuleOp      */ _unionExpr.Set(__Matchers[708]);
                /* 226 PlainRuleOp      */ _unionOperator.Set(__Matchers[710]);
                /* 227 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[711]);
                /* 228 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[712]);
                /* 229 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[713]);
                /* 230 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[714]);
                /* 231 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[715]);
                /* 232 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[716]);
                /* 233 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[717]);
                /* 234 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[718]);
                /* 235 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[719]);
                /* 236 PlainRuleOp      */ _negateOperator.Set(__Matchers[721]);
                /* 237 PlainRuleOp      */ _neutralOperator.Set(__Matchers[723]);
                /* 238 PlainRuleOp      */ _complementOperator.Set(__Matchers[709]);
                /* 239 PlainRuleOp      */ _prefixExpression.Set(__Matchers[724]);
                /* 240 PlainRuleOp      */ _prefixExpr.Set(__Matchers[725]);
                /* 241 PlainRuleOp      */ _postfixExpression.Set(__Matchers[726]);
                /* 242 PlainRuleOp      */ _postfixExpr.Set(__Matchers[727]);
                /* 243 PlainRuleOp      */ _incrementOperator.Set(__Matchers[730]);
                /* 244 PlainRuleOp      */ _primary.Set(__Matchers[731]);
                /* 245 PlainRuleOp      */ _selectionExpr.Set(__Matchers[732]);
                /* 246 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[735]);
                /* 247 PlainRuleOp      */ _indexedExpr.Set(__Matchers[736]);
                /* 248 PlainRuleOp      */ _index.Set(__Matchers[737]);
                /* 249 PlainRuleOp      */ _upperSpanned.Set(__Matchers[738]);
                /* 250 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[739]);
                /* 251 PlainRuleOp      */ _spanned.Set(__Matchers[740]);
                /* 252 PlainRuleOp      */ _measured.Set(__Matchers[741]);
                /* 253 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 254 PlainRuleOp      */ _callExpr.Set(__Matchers[742]);
                /* 255 PlainRuleOp      */ _baseExpression.Set(__Matchers[743]);
                /* 256 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[744]);
                /* 257 PlainRuleOp      */ _stringExpression.Set(__Matchers[745]);
                /* 258 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[747]);
                /* 259 PlainRuleOp      */ _interpolationPart.Set(__Matchers[748]);
                /* 260 PlainRuleOp      */ _stringLiteral.Set(__Matchers[749]);
                /* 261 PlainRuleOp      */ _objectExpr.Set(__Matchers[750]);
                /* 262 PlainRuleOp      */ _groupedExpr.Set(__Matchers[751]);
                /* 263 PlainRuleOp      */ _typeArguments.Set(__Matchers[753]);
                /* 264 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[756]);
                /* 265 PlainRuleOp      */ _variancedType.Set(__Matchers[757]);
                /* 266 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[760]);
                /* 267 PlainRuleOp      */ _defaultedType.Set(__Matchers[761]);
                /* 268 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[762]);
                /* 269 PlainRuleOp      */ _variadicType.Set(__Matchers[763]);
                /* 270 PlainRuleOp      */ _variadicTypeCore.Set(__Matchers[764]);
                /* 271 PlainRuleOp      */ _spreadType.Set(__Matchers[765]);
                /* 272 PlainRuleOp      */ _type.Set(__Matchers[766]);
                /* 273 PlainRuleOp      */ _entryType.Set(__Matchers[767]);
                /* 274 PlainRuleOp      */ _unionType.Set(__Matchers[768]);
                /* 275 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[769]);
                /* 276 PlainRuleOp      */ _intersectionType.Set(__Matchers[770]);
                /* 277 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[771]);
                /* 278 PlainRuleOp      */ _primaryType.Set(__Matchers[772]);
                /* 279 PlainRuleOp      */ _nullableType.Set(__Matchers[774]);
                /* 280 PlainRuleOp      */ _arrayType.Set(__Matchers[776]);
                /* 281 PlainRuleOp      */ _functionType.Set(__Matchers[778]);
                /* 282 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[779]);
                /* 283 PlainRuleOp      */ _tupleType.Set(__Matchers[780]);
                /* 284 PlainRuleOp      */ _iterableType.Set(__Matchers[782]);
                /* 285 PlainRuleOp      */ _groupedType.Set(__Matchers[783]);
                /* 286 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[784]);
                /* 287 PlainRuleOp      */ _annotations.Set(__Matchers[787]);
                /* 288 PlainRuleOp      */ _annotation.Set(__Matchers[788]);
                /* 289 PlainRuleOp      */ _conditions.Set(__Matchers[790]);
                /* 290 PlainRuleOp      */ _conditionList.Set(__Matchers[793]);
                /* 291 PlainRuleOp      */ _condition.Set(__Matchers[794]);
                /* 292 PlainRuleOp      */ _existsCondition.Set(__Matchers[796]);
                /* 293 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[797]);
                /* 294 PlainRuleOp      */ _letOrExpression.Set(__Matchers[798]);
                /* 295 PlainRuleOp      */ _isCondition.Set(__Matchers[799]);
                /* 296 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[800]);
                /* 297 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[801]);
                /* 298 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 299 PlainRuleOp      */ _controlStatement.Set(__Matchers[802]);
                /* 300 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[805]);
                /* 301 PlainRuleOp      */ _elseIf.Set(__Matchers[806]);
                /* 302 PlainRuleOp      */ _elseBlock.Set(__Matchers[807]);
                /* 303 PlainRuleOp      */ _switchStatement.Set(__Matchers[809]);
                /* 304 PlainRuleOp      */ _caseBlock.Set(__Matchers[810]);
                /* 305 PlainRuleOp      */ _caseItem.Set(__Matchers[811]);
                /* 306 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[812]);
                /* 307 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[813]);
                /* 308 PlainRuleOp      */ _valueCaseList.Set(__Matchers[816]);
                /* 309 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[817]);
                /* 310 PlainRuleOp      */ _valueCase.Set(__Matchers[818]);
                /* 311 PlainRuleOp      */ _forElseStatement.Set(__Matchers[819]);
                /* 312 PlainRuleOp      */ _forIterator.Set(__Matchers[821]);
                /* 313 PlainRuleOp      */ _forVariable.Set(__Matchers[822]);
                /* 314 PlainRuleOp      */ _containment.Set(__Matchers[823]);
                /* 315 PlainRuleOp      */ _containmentOperator.Set(__Matchers[824]);
                /* 316 PlainRuleOp      */ _whileStatement.Set(__Matchers[826]);
                /* 317 PlainRuleOp      */ _tryStatement.Set(__Matchers[831]);
                /* 318 PlainRuleOp      */ _catchBlock.Set(__Matchers[834]);
                /* 319 PlainRuleOp      */ _finallyBlock.Set(__Matchers[836]);
                /* 320 PlainRuleOp      */ _resources.Set(__Matchers[838]);
                /* 321 PlainRuleOp      */ _resourceList.Set(__Matchers[841]);
                /* 322 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 323 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[842]);
                /* 324 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[843]);
                /* 325 PlainRuleOp      */ _variable.Set(__Matchers[846]);
                /* 326 PlainRuleOp      */ _variableType.Set(__Matchers[847]);
                /* 327 PlainRuleOp      */ _modelReference.Set(__Matchers[848]);
                /* 328 PlainRuleOp      */ _metaLiteral.Set(__Matchers[850]);
                /* 329 PlainRuleOp      */ _metaExpression.Set(__Matchers[851]);
                /* 330 PlainRuleOp      */ _modelExpression.Set(__Matchers[852]);
                /* 331 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[853]);
                /* 332 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[854]);
                /* 333 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[855]);
                /* 334 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 335 PlainRuleOp      */ _declarationReference.Set(__Matchers[856]);
                /* 336 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[858]);
                /* 337 PlainRuleOp      */ _packageLiteral.Set(__Matchers[859]);
                /* 338 PlainRuleOp      */ _classLiteral.Set(__Matchers[860]);
                /* 339 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[861]);
                /* 340 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[862]);
                /* 341 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[863]);
                /* 342 PlainRuleOp      */ _newLiteral.Set(__Matchers[864]);
                /* 343 PlainRuleOp      */ _valueLiteral.Set(__Matchers[865]);
                /* 344 PlainRuleOp      */ _objectLiteral.Set(__Matchers[866]);
                /* 345 PlainRuleOp      */ _functionLiteral.Set(__Matchers[867]);
                /* 346 PlainRuleOp      */ _packageQualifier.Set(__Matchers[868]);
                /* 347 PlainRuleOp      */ _referencePath.Set(__Matchers[869]);
                /* 348 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[872]);
                /* 349 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 350 PlainRuleOp      */ _kwVoid.Set(__Matchers[485]);
                /* 351 PlainRuleOp      */ _kwFunction.Set(__Matchers[490]);
                /* 352 PlainRuleOp      */ _kwValue.Set(__Matchers[494]);
                /* 353 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 354 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 355 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 356 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 357 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 358 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 359 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 360 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 361 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 362 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 363 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 365 SeqOp            */ __Matchers[365].Set(_compilationUnit, __Matchers[364]);
                /* 366 AltOp            */ __Matchers[366].Set(_moduleDescriptor, _packageDescriptor, _codeUnit);
                /* 367 SeqOp            */ __Matchers[367].Set(_imports, _namespace, _imports, _declarations);
                /* 370 SeqOp            */ __Matchers[370].Set(_annotations, __Matchers[368], _namespacePath, __Matchers[369]);
                /* 372 SeqOp            */ __Matchers[372].Set(__Matchers[371], _identifier);
                /* 373 StarOp           */ __Matchers[373].Set(__Matchers[372]);
                /* 374 SeqOp            */ __Matchers[374].Set(_identifier, __Matchers[373]);
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
                /* 392 AltOp            */ __Matchers[392].Set(_inferredAttributeDeclaration, _moduleImport);
                /* 394 SeqOp            */ __Matchers[394].Set(_annotations, __Matchers[393], _module, __Matchers[378], __Matchers[369]);
                /* 396 SeqOp            */ __Matchers[396].Set(_annotations, __Matchers[395], _packagePath, __Matchers[369]);
                /* 397 SeqOp            */ __Matchers[397].Set(__Matchers[393], _packagePath, _importElements);
                /* 398 OptionalOp       */ __Matchers[398].Set(_importElementList);
                /* 399 SeqOp            */ __Matchers[399].Set(__Matchers[388], __Matchers[398], __Matchers[390]);
                /* 401 SeqOp            */ __Matchers[401].Set(__Matchers[400], _importElement);
                /* 402 StarOp           */ __Matchers[402].Set(__Matchers[401]);
                /* 403 SeqOp            */ __Matchers[403].Set(_importElement, __Matchers[402]);
                /* 404 AltOp            */ __Matchers[404].Set(_importNamed, _importWildcard);
                /* 405 OptionalOp       */ __Matchers[405].Set(_importNameSpecifier);
                /* 406 OptionalOp       */ __Matchers[406].Set(_importElements);
                /* 407 SeqOp            */ __Matchers[407].Set(_importName, __Matchers[405], __Matchers[406]);
                /* 409 SeqOp            */ __Matchers[409].Set(__Matchers[408], _identifier);
                /* 411 SeqOp            */ __Matchers[411].Set(__Matchers[371], _packageName);
                /* 412 StarOp           */ __Matchers[412].Set(__Matchers[411]);
                /* 413 SeqOp            */ __Matchers[413].Set(_packageName, __Matchers[412]);
                /* 414 AltOp            */ __Matchers[414].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 415 AltOp            */ __Matchers[415].Set(_tuplePattern, _variablePattern);
                /* 416 AltOp            */ __Matchers[416].Set(_entryPattern, _tuplePattern);
                /* 418 SeqOp            */ __Matchers[418].Set(_variableOrTuplePattern, __Matchers[417], _variableOrTuplePattern);
                /* 420 OptionalOp       */ __Matchers[420].Set(_variadicPatternList);
                /* 422 SeqOp            */ __Matchers[422].Set(__Matchers[419], __Matchers[420], __Matchers[421]);
                /* 423 SeqOp            */ __Matchers[423].Set(__Matchers[400], _variadicPattern);
                /* 424 StarOp           */ __Matchers[424].Set(__Matchers[423]);
                /* 425 SeqOp            */ __Matchers[425].Set(_variadicPattern, __Matchers[424]);
                /* 426 AltOp            */ __Matchers[426].Set(_variadicVariable, _pattern);
                /* 427 OptionalOp       */ __Matchers[427].Set(_unionType);
                /* 428 SeqOp            */ __Matchers[428].Set(__Matchers[427], _variadicOperator, _memberName);
                /* 431 AltOp            */ __Matchers[431].Set(__Matchers[429], __Matchers[430]);
                /* 435 SeqOp            */ __Matchers[435].Set(__Matchers[432], __Matchers[433], _letVariableList, __Matchers[434]);
                /* 436 SeqOp            */ __Matchers[436].Set(__Matchers[400], _letVariable);
                /* 437 StarOp           */ __Matchers[437].Set(__Matchers[436]);
                /* 438 SeqOp            */ __Matchers[438].Set(_letVariable, __Matchers[437]);
                /* 439 SeqOp            */ __Matchers[439].Set(_pattern, _valueSpecifier);
                /* 441 SeqOp            */ __Matchers[441].Set(__Matchers[440], _classInstantiation);
                /* 442 OptionalOp       */ __Matchers[442].Set(_assertionMessage);
                /* 444 SeqOp            */ __Matchers[444].Set(__Matchers[442], __Matchers[443], _conditions);
                /* 445 SeqOp            */ __Matchers[445].Set(__Matchers[388], _imports, _statements, __Matchers[390]);
                /* 446 SeqOp            */ __Matchers[446].Set(__Matchers[440], _classInstantiation);
                /* 448 SeqOp            */ __Matchers[448].Set(__Matchers[447], _classInstantiation);
                /* 449 OptionalOp       */ __Matchers[449].Set(_arguments);
                /* 450 SeqOp            */ __Matchers[450].Set(_qualifiedClass, __Matchers[449]);
                /* 451 AltOp            */ __Matchers[451].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 452 SeqOp            */ __Matchers[452].Set(__Matchers[395], __Matchers[371], _unQualifiedClass);
                /* 454 SeqOp            */ __Matchers[454].Set(__Matchers[453], __Matchers[371], _baseReference);
                /* 455 AltOp            */ __Matchers[455].Set(_memberPath, _typePath, _memberReference);
                /* 456 SeqOp            */ __Matchers[456].Set(_typePath, __Matchers[371], _memberReference);
                /* 457 SeqOp            */ __Matchers[457].Set(__Matchers[371], _typeReference);
                /* 458 StarOp           */ __Matchers[458].Set(__Matchers[457]);
                /* 459 SeqOp            */ __Matchers[459].Set(_typeReference, __Matchers[458]);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[460], _unionTypeList);
                /* 462 SeqOp            */ __Matchers[462].Set(__Matchers[400], _unionType);
                /* 463 StarOp           */ __Matchers[463].Set(__Matchers[462]);
                /* 464 SeqOp            */ __Matchers[464].Set(_unionType, __Matchers[463]);
                /* 466 SeqOp            */ __Matchers[466].Set(__Matchers[465], _caseTypeList);
                /* 468 SeqOp            */ __Matchers[468].Set(__Matchers[467], _caseType);
                /* 469 StarOp           */ __Matchers[469].Set(__Matchers[468]);
                /* 470 SeqOp            */ __Matchers[470].Set(_caseType, __Matchers[469]);
                /* 471 AltOp            */ __Matchers[471].Set(_primaryType, _qualifiedCaseType);
                /* 472 OptionalOp       */ __Matchers[472].Set(_packageQualifier);
                /* 473 SeqOp            */ __Matchers[473].Set(__Matchers[472], _memberName);
                /* 474 OptionalOp       */ __Matchers[474].Set(_parameterList);
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[433], __Matchers[474], __Matchers[434]);
                /* 476 SeqOp            */ __Matchers[476].Set(__Matchers[400], _parameterDeclarationOrRefPattern);
                /* 477 StarOp           */ __Matchers[477].Set(__Matchers[476]);
                /* 478 SeqOp            */ __Matchers[478].Set(_parameterDeclarationOrRefPattern, __Matchers[477]);
                /* 479 AltOp            */ __Matchers[479].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 480 SeqOp            */ __Matchers[480].Set(_annotations, _parameterDeclaration);
                /* 481 OptionalOp       */ __Matchers[481].Set(_valueSpecifier);
                /* 482 SeqOp            */ __Matchers[482].Set(_memberName, __Matchers[481]);
                /* 483 AltOp            */ __Matchers[483].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 484 AltOp            */ __Matchers[484].Set(_voidFunctionParameter, _inferredFunctionParameter, _typedFunctionParameter);
                /* 486 OptionalOp       */ __Matchers[486].Set(_typeParameters);
                /* 487 PlusOp           */ __Matchers[487].Set(_parameters);
                /* 488 OptionalOp       */ __Matchers[488].Set(_functionSpecifier);
                /* 489 SeqOp            */ __Matchers[489].Set(__Matchers[485], _memberName, __Matchers[486], __Matchers[487], __Matchers[488]);
                /* 491 SeqOp            */ __Matchers[491].Set(__Matchers[490], _memberName, __Matchers[486], __Matchers[487], __Matchers[488]);
                /* 492 SeqOp            */ __Matchers[492].Set(_variadicType, _memberName, __Matchers[486], __Matchers[487], __Matchers[488]);
                /* 493 AltOp            */ __Matchers[493].Set(_inferredValueParameter, _typedValueParameter);
                /* 495 SeqOp            */ __Matchers[495].Set(__Matchers[494], _memberName, __Matchers[481]);
                /* 496 SeqOp            */ __Matchers[496].Set(_variadicType, _memberName, __Matchers[481]);
                /* 499 SeqOp            */ __Matchers[499].Set(__Matchers[497], _typeParameterList, __Matchers[498]);
                /* 500 SeqOp            */ __Matchers[500].Set(__Matchers[400], _typeParameter);
                /* 501 StarOp           */ __Matchers[501].Set(__Matchers[500]);
                /* 502 SeqOp            */ __Matchers[502].Set(_typeParameter, __Matchers[501]);
                /* 503 OptionalOp       */ __Matchers[503].Set(_variance);
                /* 504 OptionalOp       */ __Matchers[504].Set(_typeDefault);
                /* 505 SeqOp            */ __Matchers[505].Set(__Matchers[503], _typeName, __Matchers[504]);
                /* 508 AltOp            */ __Matchers[508].Set(__Matchers[506], __Matchers[507]);
                /* 509 SeqOp            */ __Matchers[509].Set(__Matchers[408], _type);
                /* 511 OptionalOp       */ __Matchers[511].Set(_typeName);
                /* 512 OptionalOp       */ __Matchers[512].Set(_caseTypes);
                /* 513 OptionalOp       */ __Matchers[513].Set(_satisfiedTypes);
                /* 514 SeqOp            */ __Matchers[514].Set(__Matchers[510], __Matchers[511], __Matchers[486], __Matchers[512], __Matchers[513]);
                /* 515 PlusOp           */ __Matchers[515].Set(_typeConstraint);
                /* 516 StarOp           */ __Matchers[516].Set(_declaration);
                /* 517 AltOp            */ __Matchers[517].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 519 OptionalOp       */ __Matchers[519].Set(_memberName);
                /* 520 OptionalOp       */ __Matchers[520].Set(_delegatedConstructor);
                /* 521 SeqOp            */ __Matchers[521].Set(_annotations, __Matchers[518], __Matchers[519], _parameters, __Matchers[520], _block);
                /* 523 OptionalOp       */ __Matchers[523].Set(_typeConstraints);
                /* 524 SeqOp            */ __Matchers[524].Set(_annotations, __Matchers[522], _typeName, __Matchers[486], __Matchers[523], _optionalTypeSpecifier);
                /* 525 SeqOp            */ __Matchers[525].Set(_annotations, __Matchers[518], _memberName, __Matchers[520], _block);
                /* 527 OptionalOp       */ __Matchers[527].Set(_extendedType);
                /* 528 SeqOp            */ __Matchers[528].Set(_annotations, __Matchers[526], _memberName, __Matchers[527], __Matchers[513], _block);
                /* 530 SeqOp            */ __Matchers[530].Set(_annotations, __Matchers[529], _memberName, _setterDefinition);
                /* 531 AltOp            */ __Matchers[531].Set(_block, _requiredFunctionSpecifier);
                /* 532 SeqOp            */ __Matchers[532].Set(_annotations, __Matchers[485], _memberName, __Matchers[486], __Matchers[487], __Matchers[523], _methodDefinition);
                /* 533 SeqOp            */ __Matchers[533].Set(_annotations, __Matchers[490], _memberName, __Matchers[486], __Matchers[487], __Matchers[523], _methodDefinition);
                /* 534 SeqOp            */ __Matchers[534].Set(_annotations, _variadicType, _memberName, __Matchers[486], __Matchers[487], __Matchers[523], _methodDefinition);
                /* 535 SeqOp            */ __Matchers[535].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 536 SeqOp            */ __Matchers[536].Set(_annotations, __Matchers[494], _memberName, _attributeDefinition);
                /* 537 AltOp            */ __Matchers[537].Set(_block, _optionalAnySpecifier);
                /* 538 OptionalOp       */ __Matchers[538].Set(_anySpecifier);
                /* 539 SeqOp            */ __Matchers[539].Set(__Matchers[538], __Matchers[369]);
                /* 541 OptionalOp       */ __Matchers[541].Set(_parameters);
                /* 542 SeqOp            */ __Matchers[542].Set(_annotations, __Matchers[540], _typeName, __Matchers[486], __Matchers[541], __Matchers[512], __Matchers[527], __Matchers[513], __Matchers[523], _classDefinition);
                /* 543 AltOp            */ __Matchers[543].Set(_block, _optionalClassSpecifier);
                /* 544 OptionalOp       */ __Matchers[544].Set(_classSpecifier);
                /* 545 SeqOp            */ __Matchers[545].Set(__Matchers[544], __Matchers[369]);
                /* 547 SeqOp            */ __Matchers[547].Set(_annotations, __Matchers[546], _typeName, __Matchers[486], __Matchers[512], __Matchers[513], __Matchers[523], _interfaceDefinition);
                /* 548 AltOp            */ __Matchers[548].Set(_block, _optionalTypeSpecifier);
                /* 549 OptionalOp       */ __Matchers[549].Set(_typeSpecifier);
                /* 550 SeqOp            */ __Matchers[550].Set(__Matchers[549], __Matchers[369]);
                /* 551 StarOp           */ __Matchers[551].Set(_statement);
                /* 552 AltOp            */ __Matchers[552].Set(_declarationStatement, _unclosedStatement, _controlStatement);
                /* 553 SeqOp            */ __Matchers[553].Set(_openStatement, __Matchers[369]);
                /* 554 AltOp            */ __Matchers[554].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 555 SeqOp            */ __Matchers[555].Set(_primary, _functionSpecifier);
                /* 556 AltOp            */ __Matchers[556].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 558 OptionalOp       */ __Matchers[558].Set(_expression);
                /* 559 SeqOp            */ __Matchers[559].Set(__Matchers[557], __Matchers[558]);
                /* 561 SeqOp            */ __Matchers[561].Set(__Matchers[560], __Matchers[558]);
                /* 564 SeqOp            */ __Matchers[564].Set(__Matchers[447], _type);
                /* 565 SeqOp            */ __Matchers[565].Set(__Matchers[408], _expression);
                /* 566 SeqOp            */ __Matchers[566].Set(__Matchers[447], _expression);
                /* 567 AltOp            */ __Matchers[567].Set(_valueSpecifier, _functionSpecifier);
                /* 568 AltOp            */ __Matchers[568].Set(_baseReference, _selfReference, _parametrizedMember, _selfParametrizedMember);
                /* 569 AltOp            */ __Matchers[569].Set(_memberReference, _typeReference);
                /* 570 SeqOp            */ __Matchers[570].Set(_memberName, __Matchers[486], __Matchers[487]);
                /* 571 SeqOp            */ __Matchers[571].Set(_selfReferenceSelector, _parametrizedMember);
                /* 572 OptionalOp       */ __Matchers[572].Set(_typeArguments);
                /* 573 SeqOp            */ __Matchers[573].Set(_memberName, __Matchers[572]);
                /* 574 SeqOp            */ __Matchers[574].Set(_typeName, __Matchers[572]);
                /* 575 SeqOp            */ __Matchers[575].Set(_selfReference, _memberSelectionOperator);
                /* 578 AltOp            */ __Matchers[578].Set(__Matchers[576], __Matchers[453], __Matchers[577], __Matchers[395]);
                /* 579 OptionalOp       */ __Matchers[579].Set(_sequencedArgumentList);
                /* 580 SeqOp            */ __Matchers[580].Set(__Matchers[388], _statements, __Matchers[579], __Matchers[390]);
                /* 581 SeqOp            */ __Matchers[581].Set(__Matchers[419], __Matchers[579], __Matchers[421]);
                /* 582 AltOp            */ __Matchers[582].Set(_patternedArguments, _positionalArguments);
                /* 583 StarOp           */ __Matchers[583].Set(_structuredArgument);
                /* 584 SeqOp            */ __Matchers[584].Set(__Matchers[388], __Matchers[583], __Matchers[579], __Matchers[390]);
                /* 585 SeqOp            */ __Matchers[585].Set(__Matchers[433], __Matchers[579], __Matchers[434]);
                /* 586 AltOp            */ __Matchers[586].Set(_anonymousArgument, _namedArgument);
                /* 587 SeqOp            */ __Matchers[587].Set(_expression, __Matchers[369]);
                /* 588 AltOp            */ __Matchers[588].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 589 SeqOp            */ __Matchers[589].Set(_memberName, _valueSpecifier, __Matchers[369]);
                /* 590 SeqOp            */ __Matchers[590].Set(__Matchers[400], _sequencedArgument);
                /* 591 StarOp           */ __Matchers[591].Set(__Matchers[590]);
                /* 592 SeqOp            */ __Matchers[592].Set(_sequencedArgument, __Matchers[591]);
                /* 593 AltOp            */ __Matchers[593].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 594 AltOp            */ __Matchers[594].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 595 SeqOp            */ __Matchers[595].Set(__Matchers[526], __Matchers[519], __Matchers[527], __Matchers[513], _block);
                /* 596 SeqOp            */ __Matchers[596].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 597 AltOp            */ __Matchers[597].Set(_block, _optionalFunctionSpecifier);
                /* 598 SeqOp            */ __Matchers[598].Set(__Matchers[488], __Matchers[369]);
                /* 599 SeqOp            */ __Matchers[599].Set(_functionSpecifier, __Matchers[369]);
                /* 600 AltOp            */ __Matchers[600].Set(_type, _kwVoid);
                /* 601 SeqOp            */ __Matchers[601].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 602 SeqOp            */ __Matchers[602].Set(__Matchers[490], __Matchers[519], __Matchers[486], _parameters, _methodDefinition);
                /* 603 SeqOp            */ __Matchers[603].Set(__Matchers[494], _memberName, _methodDefinition);
                /* 604 SeqOp            */ __Matchers[604].Set(_memberName, __Matchers[487], _requiredFunctionSpecifier);
                /* 605 SeqOp            */ __Matchers[605].Set(_memberName, _requiredFunctionSpecifier);
                /* 606 AltOp            */ __Matchers[606].Set(_expressionArgument, _declarationReference);
                /* 607 SeqOp            */ __Matchers[607].Set(__Matchers[429], _unionExpression);
                /* 608 OptionalOp       */ __Matchers[608].Set(_letVariableList);
                /* 609 SeqOp            */ __Matchers[609].Set(__Matchers[432], __Matchers[433], __Matchers[608], __Matchers[434], _conditionalExpression);
                /* 610 PlusOp           */ __Matchers[610].Set(_caseExpression);
                /* 611 OptionalOp       */ __Matchers[611].Set(_elseExpression);
                /* 612 SeqOp            */ __Matchers[612].Set(_switchHeader, __Matchers[610], __Matchers[611]);
                /* 614 SeqOp            */ __Matchers[614].Set(__Matchers[613], __Matchers[433], _switched, __Matchers[434]);
                /* 616 OptionalOp       */ __Matchers[616].Set(__Matchers[615]);
                /* 618 SeqOp            */ __Matchers[618].Set(__Matchers[616], __Matchers[617], __Matchers[433], _caseItem, __Matchers[434], _conditionalExpression);
                /* 620 SeqOp            */ __Matchers[620].Set(__Matchers[619], _conditions, _thenExpression, _elseExpression);
                /* 621 SeqOp            */ __Matchers[621].Set(__Matchers[615], _conditionalExpression);
                /* 623 SeqOp            */ __Matchers[623].Set(__Matchers[622], _conditionalExpression);
                /* 624 AltOp            */ __Matchers[624].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 625 AltOp            */ __Matchers[625].Set(_voidFunctionExpr, _inferredFunctionExpr);
                /* 626 SeqOp            */ __Matchers[626].Set(__Matchers[485], __Matchers[486], __Matchers[487], __Matchers[523], _functionDefinition);
                /* 627 OptionalOp       */ __Matchers[627].Set(__Matchers[490]);
                /* 628 SeqOp            */ __Matchers[628].Set(__Matchers[627], __Matchers[486], __Matchers[487], __Matchers[523], _functionDefinition);
                /* 629 AltOp            */ __Matchers[629].Set(_block, _functionSpecifier);
                /* 630 AltOp            */ __Matchers[630].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 631 AltOp            */ __Matchers[631].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 633 OptionalOp       */ __Matchers[633].Set(_forIterator);
                /* 634 SeqOp            */ __Matchers[634].Set(__Matchers[632], __Matchers[433], __Matchers[633], __Matchers[434], _comprehensionClause);
                /* 635 SeqOp            */ __Matchers[635].Set(__Matchers[619], _conditions, _comprehensionClause);
                /* 636 AltOp            */ __Matchers[636].Set(_letExpr, _ifExpr, _switchExpr, _functionExpression, _operatorExpression);
                /* 637 AltOp            */ __Matchers[637].Set(_assignmentExpr, _thenElseExpression);
                /* 638 SeqOp            */ __Matchers[638].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 650 AltOp            */ __Matchers[650].Set(__Matchers[408], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646], __Matchers[647], __Matchers[648], __Matchers[649]);
                /* 651 AltOp            */ __Matchers[651].Set(_thenElseExpr, _disjunctionExpression);
                /* 652 SeqOp            */ __Matchers[652].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 653 AltOp            */ __Matchers[653].Set(__Matchers[615], __Matchers[622]);
                /* 654 AltOp            */ __Matchers[654].Set(_disjunctionExpr, _conjunctionExpression);
                /* 655 SeqOp            */ __Matchers[655].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 657 AltOp            */ __Matchers[657].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 658 SeqOp            */ __Matchers[658].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 660 AltOp            */ __Matchers[660].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 661 SeqOp            */ __Matchers[661].Set(_notOperator, _logicalNegationExpression);
                /* 663 AltOp            */ __Matchers[663].Set(_equalityExpression, _modelReference);
                /* 664 AltOp            */ __Matchers[664].Set(_equalityExpr, _comparisonExpression);
                /* 665 SeqOp            */ __Matchers[665].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 669 AltOp            */ __Matchers[669].Set(__Matchers[666], __Matchers[667], __Matchers[668]);
                /* 670 AltOp            */ __Matchers[670].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 672 SeqOp            */ __Matchers[672].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 673 SeqOp            */ __Matchers[673].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 674 SeqOp            */ __Matchers[674].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 675 SeqOp            */ __Matchers[675].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 676 SeqOp            */ __Matchers[676].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 678 AltOp            */ __Matchers[678].Set(__Matchers[677], __Matchers[506]);
                /* 680 AltOp            */ __Matchers[680].Set(__Matchers[679], __Matchers[497]);
                /* 682 AltOp            */ __Matchers[682].Set(__Matchers[681], __Matchers[498]);
                /* 684 AltOp            */ __Matchers[684].Set(__Matchers[683], __Matchers[440], __Matchers[460], __Matchers[465]);
                /* 685 AltOp            */ __Matchers[685].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 687 SeqOp            */ __Matchers[687].Set(_entryRangeExpression, __Matchers[686]);
                /* 689 SeqOp            */ __Matchers[689].Set(_entryRangeExpression, __Matchers[688]);
                /* 690 AltOp            */ __Matchers[690].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 691 SeqOp            */ __Matchers[691].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 692 SeqOp            */ __Matchers[692].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 694 AltOp            */ __Matchers[694].Set(__Matchers[693], __Matchers[380]);
                /* 695 AltOp            */ __Matchers[695].Set(_additiveExpr, _scaleExpression);
                /* 696 SeqOp            */ __Matchers[696].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 698 AltOp            */ __Matchers[698].Set(__Matchers[430], __Matchers[697]);
                /* 699 AltOp            */ __Matchers[699].Set(_scaleExpr, _multiplicativeExpression);
                /* 700 SeqOp            */ __Matchers[700].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 702 AltOp            */ __Matchers[702].Set(_multiplicativeExpr, _unionExpression);
                /* 703 SeqOp            */ __Matchers[703].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 706 AltOp            */ __Matchers[706].Set(__Matchers[429], __Matchers[704], __Matchers[705]);
                /* 707 AltOp            */ __Matchers[707].Set(_unionExpr, _exclusiveExpression);
                /* 708 SeqOp            */ __Matchers[708].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 710 AltOp            */ __Matchers[710].Set(__Matchers[467], __Matchers[709]);
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
                /* 723 SeqOp            */ __Matchers[723].Set(__Matchers[430], __Matchers[722]);
                /* 724 AltOp            */ __Matchers[724].Set(_prefixExpr, _postfixExpression);
                /* 725 SeqOp            */ __Matchers[725].Set(_incrementOperator, _prefixExpression);
                /* 726 AltOp            */ __Matchers[726].Set(_postfixExpr, _primary);
                /* 727 SeqOp            */ __Matchers[727].Set(_postfixExpression, _incrementOperator);
                /* 730 AltOp            */ __Matchers[730].Set(__Matchers[728], __Matchers[729]);
                /* 731 AltOp            */ __Matchers[731].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 732 SeqOp            */ __Matchers[732].Set(_primary, _memberSelectionOperator, _baseReference);
                /* 735 AltOp            */ __Matchers[735].Set(__Matchers[371], __Matchers[733], __Matchers[734]);
                /* 736 SeqOp            */ __Matchers[736].Set(_primary, __Matchers[419], _index, __Matchers[421]);
                /* 737 AltOp            */ __Matchers[737].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 738 SeqOp            */ __Matchers[738].Set(_indexExpression, __Matchers[410]);
                /* 739 SeqOp            */ __Matchers[739].Set(__Matchers[410], _indexExpression);
                /* 740 SeqOp            */ __Matchers[740].Set(_indexExpression, __Matchers[693], _indexExpression);
                /* 741 SeqOp            */ __Matchers[741].Set(_indexExpression, __Matchers[380], _indexExpression);
                /* 742 SeqOp            */ __Matchers[742].Set(_primary, _arguments);
                /* 743 AltOp            */ __Matchers[743].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 744 AltOp            */ __Matchers[744].Set(_literalNatural, _literalFloat, _literalChar);
                /* 745 AltOp            */ __Matchers[745].Set(_stringLiteral, _stringInterpolation);
                /* 746 StarOp           */ __Matchers[746].Set(_interpolationPart);
                /* 747 SeqOp            */ __Matchers[747].Set(_stringStart, _expression, __Matchers[746], _stringEnd);
                /* 748 SeqOp            */ __Matchers[748].Set(_stringMid, _expression);
                /* 749 AltOp            */ __Matchers[749].Set(_literalString, _verbatimString);
                /* 750 SeqOp            */ __Matchers[750].Set(__Matchers[526], __Matchers[527], __Matchers[513], _block);
                /* 751 SeqOp            */ __Matchers[751].Set(__Matchers[433], _expression, __Matchers[434]);
                /* 752 OptionalOp       */ __Matchers[752].Set(_typeArgumentList);
                /* 753 SeqOp            */ __Matchers[753].Set(__Matchers[497], __Matchers[752], __Matchers[498]);
                /* 754 SeqOp            */ __Matchers[754].Set(__Matchers[400], _variancedType);
                /* 755 StarOp           */ __Matchers[755].Set(__Matchers[754]);
                /* 756 SeqOp            */ __Matchers[756].Set(_variancedType, __Matchers[755]);
                /* 757 SeqOp            */ __Matchers[757].Set(__Matchers[503], _type);
                /* 758 SeqOp            */ __Matchers[758].Set(__Matchers[400], _defaultedType);
                /* 759 StarOp           */ __Matchers[759].Set(__Matchers[758]);
                /* 760 SeqOp            */ __Matchers[760].Set(_defaultedType, __Matchers[759]);
                /* 761 AltOp            */ __Matchers[761].Set(_defaultedTypeCore, _variadicType);
                /* 762 SeqOp            */ __Matchers[762].Set(_type, __Matchers[408]);
                /* 763 AltOp            */ __Matchers[763].Set(_variadicTypeCore, _type);
                /* 764 SeqOp            */ __Matchers[764].Set(_unionType, _variadicOperator);
                /* 765 SeqOp            */ __Matchers[765].Set(__Matchers[429], _unionType);
                /* 766 AltOp            */ __Matchers[766].Set(_entryType, _unionType);
                /* 767 SeqOp            */ __Matchers[767].Set(_unionType, __Matchers[417], _unionType);
                /* 768 AltOp            */ __Matchers[768].Set(_unionTypeCore, _intersectionType);
                /* 769 SeqOp            */ __Matchers[769].Set(_unionType, __Matchers[467], _intersectionType);
                /* 770 AltOp            */ __Matchers[770].Set(_intersectionTypeCore, _primaryType);
                /* 771 SeqOp            */ __Matchers[771].Set(_intersectionType, __Matchers[716], _primaryType);
                /* 772 AltOp            */ __Matchers[772].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 774 SeqOp            */ __Matchers[774].Set(_primaryType, __Matchers[773]);
                /* 775 OptionalOp       */ __Matchers[775].Set(_literalNatural);
                /* 776 SeqOp            */ __Matchers[776].Set(_primaryType, __Matchers[419], __Matchers[775], __Matchers[421]);
                /* 777 OptionalOp       */ __Matchers[777].Set(_typeTypeArguments);
                /* 778 SeqOp            */ __Matchers[778].Set(_primaryType, __Matchers[433], __Matchers[777], __Matchers[434]);
                /* 779 AltOp            */ __Matchers[779].Set(_spreadType, _defaultedTypeList);
                /* 780 SeqOp            */ __Matchers[780].Set(__Matchers[419], __Matchers[777], __Matchers[421]);
                /* 781 OptionalOp       */ __Matchers[781].Set(_variadicType);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[388], __Matchers[781], __Matchers[390]);
                /* 783 SeqOp            */ __Matchers[783].Set(__Matchers[497], _type, __Matchers[498]);
                /* 784 SeqOp            */ __Matchers[784].Set(__Matchers[395], __Matchers[371], _typePath);
                /* 785 OptionalOp       */ __Matchers[785].Set(_stringLiteral);
                /* 786 StarOp           */ __Matchers[786].Set(_annotation);
                /* 787 SeqOp            */ __Matchers[787].Set(__Matchers[785], __Matchers[786]);
                /* 788 SeqOp            */ __Matchers[788].Set(_memberName, __Matchers[449]);
                /* 789 OptionalOp       */ __Matchers[789].Set(_conditionList);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[433], __Matchers[789], __Matchers[434]);
                /* 791 SeqOp            */ __Matchers[791].Set(__Matchers[400], _condition);
                /* 792 StarOp           */ __Matchers[792].Set(__Matchers[791]);
                /* 793 SeqOp            */ __Matchers[793].Set(_condition, __Matchers[792]);
                /* 794 AltOp            */ __Matchers[794].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 795 OptionalOp       */ __Matchers[795].Set(__Matchers[662]);
                /* 796 SeqOp            */ __Matchers[796].Set(__Matchers[795], __Matchers[686], _letOrExpression);
                /* 797 SeqOp            */ __Matchers[797].Set(__Matchers[795], __Matchers[688], _letOrExpression);
                /* 798 AltOp            */ __Matchers[798].Set(_letVariable, _operatorExpression);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[795], __Matchers[683], _type, _isConditionVariable);
                /* 800 SeqOp            */ __Matchers[800].Set(_memberName, __Matchers[481]);
                /* 801 SeqOp            */ __Matchers[801].Set(__Matchers[460], _type, _typeName);
                /* 802 AltOp            */ __Matchers[802].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 803 StarOp           */ __Matchers[803].Set(_elseIf);
                /* 804 OptionalOp       */ __Matchers[804].Set(_elseBlock);
                /* 805 SeqOp            */ __Matchers[805].Set(__Matchers[619], _conditions, _block, __Matchers[803], __Matchers[804]);
                /* 806 SeqOp            */ __Matchers[806].Set(__Matchers[615], __Matchers[619], _conditions, _block);
                /* 807 SeqOp            */ __Matchers[807].Set(__Matchers[615], _block);
                /* 808 PlusOp           */ __Matchers[808].Set(_caseBlock);
                /* 809 SeqOp            */ __Matchers[809].Set(_switchHeader, __Matchers[808], __Matchers[804]);
                /* 810 SeqOp            */ __Matchers[810].Set(__Matchers[616], __Matchers[617], __Matchers[433], _caseItem, __Matchers[434], _block);
                /* 811 AltOp            */ __Matchers[811].Set(_isCaseCondition, _satisfiesCaseCondition, _valueCaseList, _pattern);
                /* 812 SeqOp            */ __Matchers[812].Set(__Matchers[683], _type);
                /* 813 SeqOp            */ __Matchers[813].Set(__Matchers[460], _type);
                /* 814 SeqOp            */ __Matchers[814].Set(_valueCaseSeparator, _valueCase);
                /* 815 StarOp           */ __Matchers[815].Set(__Matchers[814]);
                /* 816 SeqOp            */ __Matchers[816].Set(_valueCase, __Matchers[815]);
                /* 817 AltOp            */ __Matchers[817].Set(__Matchers[400], __Matchers[467]);
                /* 818 AltOp            */ __Matchers[818].Set(_intersectionType, _intersectionExpression);
                /* 819 SeqOp            */ __Matchers[819].Set(__Matchers[632], __Matchers[433], __Matchers[633], __Matchers[434], _block, __Matchers[804]);
                /* 820 OptionalOp       */ __Matchers[820].Set(_containment);
                /* 821 SeqOp            */ __Matchers[821].Set(_forVariable, __Matchers[820]);
                /* 822 AltOp            */ __Matchers[822].Set(_tupleOrEntryPattern, _variable);
                /* 823 SeqOp            */ __Matchers[823].Set(_containmentOperator, _operatorExpression);
                /* 824 AltOp            */ __Matchers[824].Set(__Matchers[506], __Matchers[380]);
                /* 826 SeqOp            */ __Matchers[826].Set(__Matchers[825], _conditions, _block);
                /* 828 OptionalOp       */ __Matchers[828].Set(_resources);
                /* 829 StarOp           */ __Matchers[829].Set(_catchBlock);
                /* 830 OptionalOp       */ __Matchers[830].Set(_finallyBlock);
                /* 831 SeqOp            */ __Matchers[831].Set(__Matchers[827], __Matchers[828], _block, __Matchers[829], __Matchers[830]);
                /* 833 OptionalOp       */ __Matchers[833].Set(_variable);
                /* 834 SeqOp            */ __Matchers[834].Set(__Matchers[832], __Matchers[433], __Matchers[833], __Matchers[434], _block);
                /* 836 SeqOp            */ __Matchers[836].Set(__Matchers[835], _block);
                /* 837 OptionalOp       */ __Matchers[837].Set(_resourceList);
                /* 838 SeqOp            */ __Matchers[838].Set(__Matchers[433], __Matchers[837], __Matchers[434]);
                /* 839 SeqOp            */ __Matchers[839].Set(__Matchers[400], _resource);
                /* 840 StarOp           */ __Matchers[840].Set(__Matchers[839]);
                /* 841 SeqOp            */ __Matchers[841].Set(_resource, __Matchers[840]);
                /* 842 AltOp            */ __Matchers[842].Set(_specifiedVariable, _operatorExpression);
                /* 843 SeqOp            */ __Matchers[843].Set(_variable, _valueSpecifier);
                /* 844 OptionalOp       */ __Matchers[844].Set(_variableType);
                /* 845 StarOp           */ __Matchers[845].Set(_parameters);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[844], _memberName, __Matchers[845]);
                /* 847 AltOp            */ __Matchers[847].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 848 SeqOp            */ __Matchers[848].Set(__Matchers[713], _modelExpression);
                /* 850 SeqOp            */ __Matchers[850].Set(__Matchers[849], _metaExpression, __Matchers[849]);
                /* 851 AltOp            */ __Matchers[851].Set(_declarationReference, _modelExpression);
                /* 852 AltOp            */ __Matchers[852].Set(_memberModelExpression, _typeModelExpression);
                /* 853 AltOp            */ __Matchers[853].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 854 SeqOp            */ __Matchers[854].Set(__Matchers[395], __Matchers[371], _memberReference);
                /* 855 SeqOp            */ __Matchers[855].Set(_primaryType, __Matchers[371], _memberReference);
                /* 856 AltOp            */ __Matchers[856].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _objectLiteral, _functionLiteral);
                /* 857 OptionalOp       */ __Matchers[857].Set(_packagePath);
                /* 858 SeqOp            */ __Matchers[858].Set(__Matchers[376], __Matchers[857]);
                /* 859 SeqOp            */ __Matchers[859].Set(__Matchers[395], __Matchers[857]);
                /* 860 SeqOp            */ __Matchers[860].Set(__Matchers[540], _referencePath);
                /* 861 SeqOp            */ __Matchers[861].Set(__Matchers[546], _referencePath);
                /* 862 SeqOp            */ __Matchers[862].Set(__Matchers[522], _referencePath);
                /* 863 SeqOp            */ __Matchers[863].Set(__Matchers[510], _referencePath);
                /* 864 SeqOp            */ __Matchers[864].Set(__Matchers[518], _referencePath);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[494], _referencePath);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[526], _referencePath);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[490], _referencePath);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[395], __Matchers[371]);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[472], _referencePathElementList);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[371], _referencePathElement);
                /* 871 StarOp           */ __Matchers[871].Set(__Matchers[870]);
                /* 872 SeqOp            */ __Matchers[872].Set(_referencePathElement, __Matchers[871]);

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
            private PlainRule _variadicOperator;
            private PlainRule _letStatement;
            private PlainRule _letVariableList;
            private PlainRule _letVariable;
            private PlainRule _delegatedConstructor;
            private PlainRule _assertionStatement;
            private PlainRule _assertionMessage;
            private PlainRule _block;
            private PlainRule _extendedType;
            private PlainRule _classSpecifier;
            private PlainRule _classInstantiation;
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
            private PlainRule _voidFunctionParameter;
            private PlainRule _inferredFunctionParameter;
            private PlainRule _typedFunctionParameter;
            private PlainRule _valueParameterDeclaration;
            private PlainRule _inferredValueParameter;
            private PlainRule _typedValueParameter;
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
            private PlainRule _voidMethodDeclaration;
            private PlainRule _inferredMethodDeclaration;
            private PlainRule _typedMethodDeclaration;
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
            private PlainRule _switchHeader;
            private PlainRule _switched;
            private PlainRule _caseExpression;
            private PlainRule _ifExpr;
            private PlainRule _elseExpression;
            private PlainRule _thenExpression;
            private PlainRule _conditionalExpression;
            private PlainRule _functionExpression;
            private PlainRule _voidFunctionExpr;
            private PlainRule _inferredFunctionExpr;
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
            private PlainRule _variadicTypeCore;
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
            private PlainRule _caseBlock;
            private PlainRule _caseItem;
            private PlainRule _isCaseCondition;
            private PlainRule _satisfiesCaseCondition;
            private PlainRule _valueCaseList;
            private PlainRule _valueCaseSeparator;
            private PlainRule _valueCase;
            private PlainRule _forElseStatement;
            private PlainRule _forIterator;
            private PlainRule _forVariable;
            private PlainRule _containment;
            private PlainRule _containmentOperator;
            private PlainRule _whileStatement;
            private PlainRule _tryStatement;
            private PlainRule _catchBlock;
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
            private PlainRule _objectLiteral;
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
        public interface ICVariadicOperator : IRNode {}
        public interface ICLetStatement : ICOpenStatement {}
        public interface ICLetVariableList : IRNode {}
        public interface ICLetVariable : ICLetOrExpression {}
        public interface ICDelegatedConstructor : IRNode {}
        public interface ICAssertionStatement : ICOpenStatement {}
        public interface ICAssertionMessage : IRNode {}
        public interface ICBlock : ICAttributeDefinition, ICClassDefinition, ICFunctionDefinition, ICInterfaceDefinition, ICMethodDefinition, ICSetterDefinition {}
        public interface ICExtendedType : IRNode {}
        public interface ICClassSpecifier : IRNode {}
        public interface ICClassInstantiation : IRNode {}
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
        public interface ICVoidFunctionParameter : ICFunctionParameterDeclaration {}
        public interface ICInferredFunctionParameter : ICFunctionParameterDeclaration {}
        public interface ICTypedFunctionParameter : ICFunctionParameterDeclaration {}
        public interface ICValueParameterDeclaration : ICParameterDeclaration {}
        public interface ICInferredValueParameter : ICValueParameterDeclaration {}
        public interface ICTypedValueParameter : ICValueParameterDeclaration {}
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
        public interface ICVoidMethodDeclaration : ICDeclaration {}
        public interface ICInferredMethodDeclaration : ICDeclaration {}
        public interface ICTypedMethodDeclaration : ICDeclaration {}
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
        public interface ICSwitchHeader : IRNode {}
        public interface ICSwitched : IRNode {}
        public interface ICCaseExpression : IRNode {}
        public interface ICIfExpr : ICConditionalExpression, ICExpression {}
        public interface ICElseExpression : IRNode {}
        public interface ICThenExpression : IRNode {}
        public interface ICConditionalExpression : IRNode {}
        public interface ICFunctionExpression : ICExpression {}
        public interface ICVoidFunctionExpr : ICFunctionExpression {}
        public interface ICInferredFunctionExpr : ICFunctionExpression {}
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
        public interface ICVariadicType : ICDefaultedType {}
        public interface ICVariadicTypeCore : ICVariadicType {}
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
        public interface ICCaseBlock : IRNode {}
        public interface ICCaseItem : IRNode {}
        public interface ICIsCaseCondition : ICCaseItem {}
        public interface ICSatisfiesCaseCondition : ICCaseItem {}
        public interface ICValueCaseList : ICCaseItem {}
        public interface ICValueCaseSeparator : IRNode {}
        public interface ICValueCase : IRNode {}
        public interface ICForElseStatement : ICControlStatement {}
        public interface ICForIterator : IRNode {}
        public interface ICForVariable : IRNode {}
        public interface ICContainment : IRNode {}
        public interface ICContainmentOperator : IRNode {}
        public interface ICWhileStatement : ICControlStatement {}
        public interface ICTryStatement : ICControlStatement {}
        public interface ICCatchBlock : IRNode {}
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
        public interface ICObjectLiteral : ICDeclarationReference {}
        public interface ICFunctionLiteral : ICDeclarationReference {}
        public interface ICPackageQualifier : IRNode {}
        public interface ICReferencePath : IRNode {}
        public interface ICReferencePathElementList : IRNode {}
        public interface ICReferencePathElement : IRNode {}
        public interface ICKwVoid : ICMethodArgumentType, ICVariableType {}
        public interface ICKwFunction : ICVariableType {}
        public interface ICKwValue : ICVariableType {}
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
            public CImports Imports2 => Get<CImports>(2);
            public CDeclarations Declarations => Get<CDeclarations>(3);
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

        public partial class CVariadicOperator : RLiteral, ICVariadicOperator
        {
            // alternatives
            public CVariadicOperator(params Node[] children) : base(children) {}
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
            public CClassInstantiation ClassInstantiation => Get<CClassInstantiation>(1);
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
            public CClassInstantiation ClassInstantiation => Get<CClassInstantiation>(1);
        }

        public partial class CClassSpecifier : RSequence, ICClassSpecifier
        {
            // sequence
            public CClassSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public CClassInstantiation ClassInstantiation => Get<CClassInstantiation>(1);
        }

        public partial class CClassInstantiation : RSequence, ICClassInstantiation
        {
            // sequence
            public CClassInstantiation(params RNode[] children) : base(children) {}

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

        public partial class CVoidFunctionParameter : RSequence, ICVoidFunctionParameter
        {
            // sequence
            public CVoidFunctionParameter(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'void'
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CInferredFunctionParameter : RSequence, ICInferredFunctionParameter
        {
            // sequence
            public CInferredFunctionParameter(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'function'
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CTypedFunctionParameter : RSequence, ICTypedFunctionParameter
        {
            // sequence
            public CTypedFunctionParameter(params RNode[] children) : base(children) {}

            public ICVariadicType VariadicType => Get<ICVariadicType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CInferredValueParameter : RSequence, ICInferredValueParameter
        {
            // sequence
            public CInferredValueParameter(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'value'
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(2);
        }

        public partial class CTypedValueParameter : RSequence, ICTypedValueParameter
        {
            // sequence
            public CTypedValueParameter(params RNode[] children) : base(children) {}

            public ICVariadicType VariadicType => Get<ICVariadicType>(0);
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
            public RPlus<CCaseExpression> CaseExpression => Get<RPlus<CCaseExpression>>(1);
            public ROptional<CElseExpression> ElseExpression => Get<ROptional<CElseExpression>>(2);
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

        public partial class CVoidFunctionExpr : RSequence, ICVoidFunctionExpr
        {
            // sequence
            public CVoidFunctionExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'void'
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(2);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(3);
            public ICFunctionDefinition FunctionDefinition => Get<ICFunctionDefinition>(4);
        }

        public partial class CInferredFunctionExpr : RSequence, ICInferredFunctionExpr
        {
            // sequence
            public CInferredFunctionExpr(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> Literal => Get<ROptional<RLiteral>>(0);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(2);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(3);
            public ICFunctionDefinition FunctionDefinition => Get<ICFunctionDefinition>(4);
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

        public partial class CVariadicTypeCore : RSequence, ICVariadicTypeCore
        {
            // sequence
            public CVariadicTypeCore(params RNode[] children) : base(children) {}

            public ICUnionType UnionType => Get<ICUnionType>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'is'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CForIterator> ForIterator => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public CBlock Block => Get<CBlock>(4);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(5);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'try'
            public ROptional<CResources> Resources => Get<ROptional<CResources>>(1);
            public CBlock Block => Get<CBlock>(2);
            public RStar<CCatchBlock> CatchBlock => Get<RStar<CCatchBlock>>(3);
            public ROptional<CFinallyBlock> FinallyBlock => Get<ROptional<CFinallyBlock>>(4);
        }

        public partial class CCatchBlock : RSequence, ICCatchBlock
        {
            // sequence
            public CCatchBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'catch'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CVariable> Variable => Get<ROptional<CVariable>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public CBlock Block => Get<CBlock>(4);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'value'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CObjectLiteral : RSequence, ICObjectLiteral
        {
            // sequence
            public CObjectLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
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

            protected virtual void Visit(CVariadicOperator element)
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

            protected virtual void Visit(CClassInstantiation element)
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

            protected virtual void Visit(CVoidFunctionParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredFunctionParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedFunctionParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredValueParameter element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedValueParameter element)
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

            protected virtual void Visit(CVoidMethodDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredMethodDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedMethodDeclaration element)
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

            protected virtual void Visit(CSwitchHeader element)
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

            protected virtual void Visit(CVoidFunctionExpr element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredFunctionExpr element)
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

            protected virtual void Visit(CVariadicTypeCore element)
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

            protected virtual void Visit(CCatchBlock element)
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

            protected virtual void Visit(CObjectLiteral element)
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
