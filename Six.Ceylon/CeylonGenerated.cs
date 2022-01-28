// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Ceylon\\Ceylon.six" at="28.01.2022 15:23:57" />

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
                : base(new Matcher[881])
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
                /* 159 PlainRuleOp      */ __Matchers[159] = _caseExpressions = new PlainRule(this, 159, "case-expressions") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _caseExpression = new PlainRule(this, 160, "case-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _ifExpr = new PlainRule(this, 161, "if-expr") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _elseExpression = new PlainRule(this, 162, "else-expression") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _thenExpression = new PlainRule(this, 163, "then-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _conditionalExpression = new PlainRule(this, 164, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _functionExpression = new PlainRule(this, 165, "function-expression") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _voidFunctionExpr = new PlainRule(this, 166, "void-function-expr") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _inferredFunctionExpr = new PlainRule(this, 167, "inferred-function-expr") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _functionDefinition = new PlainRule(this, 168, "function-definition") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _comprehensionArgument = new PlainRule(this, 169, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _comprehensionClause = new PlainRule(this, 170, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _expressionComprehensionClause = new PlainRule(this, 171, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _forComprehensionClause = new PlainRule(this, 172, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _ifComprehensionClause = new PlainRule(this, 173, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _expression = new PlainRule(this, 174, "expression") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _operatorExpression = new PlainRule(this, 175, "operator-expression") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _assignmentExpression = new PlainRule(this, 176, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _assignmentExpr = new PlainRule(this, 177, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _assignmentOperator = new PlainRule(this, 178, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 179 PlainRuleOp      */ __Matchers[179] = _thenElseExpression = new PlainRule(this, 179, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 180 PlainRuleOp      */ __Matchers[180] = _thenElseExpr = new PlainRule(this, 180, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _thenElseOperator = new PlainRule(this, 181, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 182 PlainRuleOp      */ __Matchers[182] = _disjunctionExpression = new PlainRule(this, 182, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 183 PlainRuleOp      */ __Matchers[183] = _disjunctionExpr = new PlainRule(this, 183, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _disjunctionOperator = new PlainRule(this, 184, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 185 PlainRuleOp      */ __Matchers[185] = _conjunctionExpression = new PlainRule(this, 185, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 186 PlainRuleOp      */ __Matchers[186] = _conjunctionExpr = new PlainRule(this, 186, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _conjunctionOperator = new PlainRule(this, 187, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 188 PlainRuleOp      */ __Matchers[188] = _logicalNegationExpression = new PlainRule(this, 188, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 189 PlainRuleOp      */ __Matchers[189] = _logicalNegationExpr = new PlainRule(this, 189, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _notOperator = new PlainRule(this, 190, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 191 PlainRuleOp      */ __Matchers[191] = _expressionOrMeta = new PlainRule(this, 191, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _equalityExpression = new PlainRule(this, 192, "equality-expression") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _equalityExpr = new PlainRule(this, 193, "equality-expr") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _equalityOperator = new PlainRule(this, 194, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 195 PlainRuleOp      */ __Matchers[195] = _comparisonExpression = new PlainRule(this, 195, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 196 PlainRuleOp      */ __Matchers[196] = _comparisonExpr = new PlainRule(this, 196, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _largerExpr = new PlainRule(this, 197, "larger-expr") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _smallerExpr = new PlainRule(this, 198, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 199 PlainRuleOp      */ __Matchers[199] = _largerBoundsExpr = new PlainRule(this, 199, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 200 PlainRuleOp      */ __Matchers[200] = _smallerBoundsExpr = new PlainRule(this, 200, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 201 PlainRuleOp      */ __Matchers[201] = _typecheckExpr = new PlainRule(this, 201, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 202 PlainRuleOp      */ __Matchers[202] = _comparisonOperator = new PlainRule(this, 202, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 203 PlainRuleOp      */ __Matchers[203] = _smallerOperator = new PlainRule(this, 203, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 204 PlainRuleOp      */ __Matchers[204] = _largerOperator = new PlainRule(this, 204, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 205 PlainRuleOp      */ __Matchers[205] = _typeOperator = new PlainRule(this, 205, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 206 PlainRuleOp      */ __Matchers[206] = _existsNonemptyExpression = new PlainRule(this, 206, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _existsExpr = new PlainRule(this, 207, "exists-expr") { Builder = nodes => nodes[0] };
                /* 208 PlainRuleOp      */ __Matchers[208] = _nonemptyExpr = new PlainRule(this, 208, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _entryRangeExpression = new PlainRule(this, 209, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _rangeExpr = new PlainRule(this, 210, "range-expr") { Builder = nodes => nodes[0] };
                /* 211 PlainRuleOp      */ __Matchers[211] = _entryExpr = new PlainRule(this, 211, "entry-expr") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _rangeOperator = new PlainRule(this, 212, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 213 PlainRuleOp      */ __Matchers[213] = _entryOperator = new PlainRule(this, 213, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 214 PlainRuleOp      */ __Matchers[214] = _additiveExpression = new PlainRule(this, 214, "additive-expression") { Builder = nodes => nodes[0] };
                /* 215 PlainRuleOp      */ __Matchers[215] = _additiveExpr = new PlainRule(this, 215, "additive-expr") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _additiveOperator = new PlainRule(this, 216, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 217 PlainRuleOp      */ __Matchers[217] = _scaleExpression = new PlainRule(this, 217, "scale-expression") { Builder = nodes => nodes[0] };
                /* 218 PlainRuleOp      */ __Matchers[218] = _scaleExpr = new PlainRule(this, 218, "scale-expr") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _scaleOperator = new PlainRule(this, 219, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 220 PlainRuleOp      */ __Matchers[220] = _multiplicativeExpression = new PlainRule(this, 220, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 221 PlainRuleOp      */ __Matchers[221] = _multiplicativeExpr = new PlainRule(this, 221, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _multiplicativeOperator = new PlainRule(this, 222, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 223 PlainRuleOp      */ __Matchers[223] = _unionExpression = new PlainRule(this, 223, "union-expression") { Builder = nodes => nodes[0] };
                /* 224 PlainRuleOp      */ __Matchers[224] = _unionExpr = new PlainRule(this, 224, "union-expr") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _unionOperator = new PlainRule(this, 225, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 226 PlainRuleOp      */ __Matchers[226] = _exclusiveExpression = new PlainRule(this, 226, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 227 PlainRuleOp      */ __Matchers[227] = _exclusiveExpr = new PlainRule(this, 227, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _exclusiveOperator = new PlainRule(this, 228, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 229 PlainRuleOp      */ __Matchers[229] = _intersectionExpression = new PlainRule(this, 229, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _intersectionExpr = new PlainRule(this, 230, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _intersectionOperator = new PlainRule(this, 231, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 232 PlainRuleOp      */ __Matchers[232] = _negationOrComplementExpression = new PlainRule(this, 232, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _negationOrComplementExpr = new PlainRule(this, 233, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _unaryMinusOrComplementOperator = new PlainRule(this, 234, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _negateOperator = new PlainRule(this, 235, "negate-operator") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _neutralOperator = new PlainRule(this, 236, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _complementOperator = new PlainRule(this, 237, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 238 PlainRuleOp      */ __Matchers[238] = _prefixExpression = new PlainRule(this, 238, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _prefixExpr = new PlainRule(this, 239, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _postfixExpression = new PlainRule(this, 240, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _postfixExpr = new PlainRule(this, 241, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _incrementOperator = new PlainRule(this, 242, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 243 PlainRuleOp      */ __Matchers[243] = _primary = new PlainRule(this, 243, "primary") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _selectionExpr = new PlainRule(this, 244, "selection-expr") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _memberSelectionOperator = new PlainRule(this, 245, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 246 PlainRuleOp      */ __Matchers[246] = _indexedExpr = new PlainRule(this, 246, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _index = new PlainRule(this, 247, "index") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _upperSpanned = new PlainRule(this, 248, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _lowerSpanned = new PlainRule(this, 249, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _spanned = new PlainRule(this, 250, "spanned") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _measured = new PlainRule(this, 251, "measured") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _indexExpression = new PlainRule(this, 252, "index-expression") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _callExpr = new PlainRule(this, 253, "call-expr") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _baseExpression = new PlainRule(this, 254, "base-expression") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _nonstringLiteral = new PlainRule(this, 255, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _stringExpression = new PlainRule(this, 256, "string-expression") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _stringInterpolation = new PlainRule(this, 257, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _interpolationPart = new PlainRule(this, 258, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _stringLiteral = new PlainRule(this, 259, "string-literal") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _objectExpr = new PlainRule(this, 260, "object-expr") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _groupedExpr = new PlainRule(this, 261, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _typeArguments = new PlainRule(this, 262, "type-arguments") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _typeArgumentList = new PlainRule(this, 263, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _variancedType = new PlainRule(this, 264, "varianced-type") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _defaultedTypeList = new PlainRule(this, 265, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _defaultedType = new PlainRule(this, 266, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _defaultedTypeCore = new PlainRule(this, 267, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _variadicType = new PlainRule(this, 268, "variadic-type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _variadicUnionType = new PlainRule(this, 269, "variadic-union-type") { Builder = nodes => nodes[0] };
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
                /* 285 PlainRuleOp      */ __Matchers[285] = _packageQualifiedType = new PlainRule(this, 285, "package-qualified-type") { Builder = nodes => nodes[0] };
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
                /* 300 PlainRuleOp      */ __Matchers[300] = _elseIf = new PlainRule(this, 300, "else-if") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _elseBlock = new PlainRule(this, 301, "else-block") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _switchStatement = new PlainRule(this, 302, "switch-statement") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _switchHeader = new PlainRule(this, 303, "switch-header") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _switched = new PlainRule(this, 304, "switched") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _caseBlock = new PlainRule(this, 305, "case-block") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _caseItem = new PlainRule(this, 306, "case-item") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _isCaseCondition = new PlainRule(this, 307, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _satisfiesCaseCondition = new PlainRule(this, 308, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _matchCaseCondition = new PlainRule(this, 309, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _valueCaseList = new PlainRule(this, 310, "value-case-list") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _valueCaseSeparator = new PlainRule(this, 311, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 312 PlainRuleOp      */ __Matchers[312] = _valueCase = new PlainRule(this, 312, "value-case") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _forElseStatement = new PlainRule(this, 313, "for-else-statement") { Builder = nodes => nodes[0] };
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
                /* 350 PlainRuleOp      */ __Matchers[350] = _packageQualifier = new PlainRule(this, 350, "package-qualifier") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _referencePath = new PlainRule(this, 351, "reference-path") { Builder = nodes => nodes[0] };
                /* 352 PlainRuleOp      */ __Matchers[352] = _referencePathElementList = new PlainRule(this, 352, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 353 PlainRuleOp      */ __Matchers[353] = _referencePathElement = new PlainRule(this, 353, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 354 PlainRuleOp      */ __Matchers[354] = _kwVoid = new PlainRule(this, 354, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 355 PlainRuleOp      */ __Matchers[355] = _kwFunction = new PlainRule(this, 355, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 356 PlainRuleOp      */ __Matchers[356] = _kwValue = new PlainRule(this, 356, "kw-value") { Creator = node => new CKwValue(node) };
                /* 357 DfaRuleOp        */ __Matchers[357] = _literalFloat = new DfaRule(this, 357, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 358 DfaRuleOp        */ __Matchers[358] = _literalNatural = new DfaRule(this, 358, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _literalChar = new DfaRule(this, 359, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _stringStart = new DfaRule(this, 360, "string-start") { Creator = node => new CStringStart(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _stringMid = new DfaRule(this, 361, "string-mid") { Creator = node => new CStringMid(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _stringEnd = new DfaRule(this, 362, "string-end") { Creator = node => new CStringEnd(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _literalString = new DfaRule(this, 363, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _verbatimString = new DfaRule(this, 364, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _lowerIdentifier = new DfaRule(this, 365, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 366 DfaRuleOp        */ __Matchers[366] = _upperIdentifier = new DfaRule(this, 366, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 367 DfaRuleOp        */ __Matchers[367] = _identifier = new DfaRule(this, 367, "identifier") { Creator = node => new CIdentifier(node) };
                /* 368 EofOp            */ __Matchers[368] = new Eof(this, 368, "<eof>") { Creator = node => new REof(node) };
                /* 369 SeqOp            */ __Matchers[369] = new Seq(this, 369, "_369:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 370 AltOp            */ __Matchers[370] = new Alt(this, 370, "alt(>module-descriptor|>package-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 371 SeqOp            */ __Matchers[371] = new Seq(this, 371, "_371:(>imports,>namespace,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 372 StringOp         */ __Matchers[372] = new Keyword(this, 372, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 373 StringOp         */ __Matchers[373] = new String(this, 373, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 374 SeqOp            */ __Matchers[374] = new Seq(this, 374, "_374:(>annotations,'namespace',>namespace-path,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 375 StringOp         */ __Matchers[375] = new String(this, 375, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 376 SeqOp            */ __Matchers[376] = new Seq(this, 376, "_376:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /* 377 StarOp           */ __Matchers[377] = new Star(this, 377, "*(_376:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 378 SeqOp            */ __Matchers[378] = new Seq(this, 378, "_378:(>identifier,*(_376:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /* 379 StarOp           */ __Matchers[379] = new Star(this, 379, "*(>import-declaration)") { Builder = nodes => new CImports(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new Keyword(this, 380, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 381 OptionalOp       */ __Matchers[381] = new Optional(this, 381, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 382 OptionalOp       */ __Matchers[382] = new Optional(this, 382, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 383 SeqOp            */ __Matchers[383] = new Seq(this, 383, "_383:(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 384 StringOp         */ __Matchers[384] = new String(this, 384, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 385 OptionalOp       */ __Matchers[385] = new Optional(this, 385, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 386 SeqOp            */ __Matchers[386] = new Seq(this, 386, "_386:(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 387 AltOp            */ __Matchers[387] = new Alt(this, 387, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 388 OptionalOp       */ __Matchers[388] = new Optional(this, 388, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 389 SeqOp            */ __Matchers[389] = new Seq(this, 389, "_389:(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 390 SeqOp            */ __Matchers[390] = new Seq(this, 390, "_390:(':',>literal-string)") { Builder = nodes => new CArtifact(nodes) };
                /* 391 SeqOp            */ __Matchers[391] = new Seq(this, 391, "_391:(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 392 StringOp         */ __Matchers[392] = new String(this, 392, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 393 StarOp           */ __Matchers[393] = new Star(this, 393, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 394 StringOp         */ __Matchers[394] = new String(this, 394, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 395 SeqOp            */ __Matchers[395] = new Seq(this, 395, "_395:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 396 AltOp            */ __Matchers[396] = new Alt(this, 396, "alt(>inferred-attribute-declaration|>module-import)") { Builder = nodes => nodes[0] };
                /* 397 StringOp         */ __Matchers[397] = new Keyword(this, 397, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 398 SeqOp            */ __Matchers[398] = new Seq(this, 398, "_398:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 399 StringOp         */ __Matchers[399] = new Keyword(this, 399, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 400 SeqOp            */ __Matchers[400] = new Seq(this, 400, "_400:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_401:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 402 OptionalOp       */ __Matchers[402] = new Optional(this, 402, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 403 SeqOp            */ __Matchers[403] = new Seq(this, 403, "_403:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 404 StringOp         */ __Matchers[404] = new String(this, 404, "','", ",") { Creator = node => new RLiteral(node) };
                /* 405 SeqOp            */ __Matchers[405] = new Seq(this, 405, "_405:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 406 StarOp           */ __Matchers[406] = new Star(this, 406, "*(_405:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 407 SeqOp            */ __Matchers[407] = new Seq(this, 407, "_407:(>import-element,*(_405:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 408 AltOp            */ __Matchers[408] = new Alt(this, 408, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 409 OptionalOp       */ __Matchers[409] = new Optional(this, 409, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 410 OptionalOp       */ __Matchers[410] = new Optional(this, 410, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 411 SeqOp            */ __Matchers[411] = new Seq(this, 411, "_411:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 412 StringOp         */ __Matchers[412] = new String(this, 412, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 413 SeqOp            */ __Matchers[413] = new Seq(this, 413, "_413:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 414 StringOp         */ __Matchers[414] = new String(this, 414, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 415 SeqOp            */ __Matchers[415] = new Seq(this, 415, "_415:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 416 StarOp           */ __Matchers[416] = new Star(this, 416, "*(_415:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 417 SeqOp            */ __Matchers[417] = new Seq(this, 417, "_417:(>package-name,*(_415:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 418 AltOp            */ __Matchers[418] = new Alt(this, 418, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 419 AltOp            */ __Matchers[419] = new Alt(this, 419, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 420 AltOp            */ __Matchers[420] = new Alt(this, 420, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 421 StringOp         */ __Matchers[421] = new String(this, 421, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 422 SeqOp            */ __Matchers[422] = new Seq(this, 422, "_422:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 423 StringOp         */ __Matchers[423] = new String(this, 423, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 424 OptionalOp       */ __Matchers[424] = new Optional(this, 424, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 425 StringOp         */ __Matchers[425] = new String(this, 425, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 426 SeqOp            */ __Matchers[426] = new Seq(this, 426, "_426:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Seq(this, 427, "_427:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 428 StarOp           */ __Matchers[428] = new Star(this, 428, "*(_427:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 429 SeqOp            */ __Matchers[429] = new Seq(this, 429, "_429:(>variadic-pattern,*(_427:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 430 AltOp            */ __Matchers[430] = new Alt(this, 430, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 431 OptionalOp       */ __Matchers[431] = new Optional(this, 431, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 432 SeqOp            */ __Matchers[432] = new Seq(this, 432, "_432:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 434 StringOp         */ __Matchers[434] = new String(this, 434, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 435 AltOp            */ __Matchers[435] = new Alt(this, 435, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 436 StringOp         */ __Matchers[436] = new Keyword(this, 436, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 437 StringOp         */ __Matchers[437] = new String(this, 437, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 438 StringOp         */ __Matchers[438] = new String(this, 438, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 439 SeqOp            */ __Matchers[439] = new Seq(this, 439, "_439:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 440 SeqOp            */ __Matchers[440] = new Seq(this, 440, "_440:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 441 StarOp           */ __Matchers[441] = new Star(this, 441, "*(_440:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 442 SeqOp            */ __Matchers[442] = new Seq(this, 442, "_442:(>let-variable,*(_440:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_443:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 444 StringOp         */ __Matchers[444] = new Keyword(this, 444, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_445:('extends',>class-instantiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 446 OptionalOp       */ __Matchers[446] = new Optional(this, 446, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 447 StringOp         */ __Matchers[447] = new Keyword(this, 447, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 448 SeqOp            */ __Matchers[448] = new Seq(this, 448, "_448:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 449 SeqOp            */ __Matchers[449] = new Seq(this, 449, "_449:('{',>imports,>statements,'}')") { Builder = nodes => new CBlock(nodes) };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_450:('extends',>class-instantiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 451 StringOp         */ __Matchers[451] = new String(this, 451, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 452 SeqOp            */ __Matchers[452] = new Seq(this, 452, "_452:('=>',>class-instantiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 453 OptionalOp       */ __Matchers[453] = new Optional(this, 453, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 454 SeqOp            */ __Matchers[454] = new Seq(this, 454, "_454:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstantiation(nodes) };
                /* 455 AltOp            */ __Matchers[455] = new Alt(this, 455, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 457 StringOp         */ __Matchers[457] = new Keyword(this, 457, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_458:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 459 AltOp            */ __Matchers[459] = new Alt(this, 459, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 460 SeqOp            */ __Matchers[460] = new Seq(this, 460, "_460:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_461:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 462 StarOp           */ __Matchers[462] = new Star(this, 462, "*(_461:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 463 SeqOp            */ __Matchers[463] = new Seq(this, 463, "_463:(>type-reference,*(_461:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 464 StringOp         */ __Matchers[464] = new Keyword(this, 464, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 465 SeqOp            */ __Matchers[465] = new Seq(this, 465, "_465:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 466 SeqOp            */ __Matchers[466] = new Seq(this, 466, "_466:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 467 StarOp           */ __Matchers[467] = new Star(this, 467, "*(_466:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 468 SeqOp            */ __Matchers[468] = new Seq(this, 468, "_468:(>union-type,*(_466:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 469 StringOp         */ __Matchers[469] = new Keyword(this, 469, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 470 SeqOp            */ __Matchers[470] = new Seq(this, 470, "_470:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 471 StringOp         */ __Matchers[471] = new String(this, 471, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_472:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 473 StarOp           */ __Matchers[473] = new Star(this, 473, "*(_472:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 474 SeqOp            */ __Matchers[474] = new Seq(this, 474, "_474:(>case-type,*(_472:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 475 AltOp            */ __Matchers[475] = new Alt(this, 475, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 476 OptionalOp       */ __Matchers[476] = new Optional(this, 476, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 477 SeqOp            */ __Matchers[477] = new Seq(this, 477, "_477:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 478 OptionalOp       */ __Matchers[478] = new Optional(this, 478, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 479 SeqOp            */ __Matchers[479] = new Seq(this, 479, "_479:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_480:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 481 StarOp           */ __Matchers[481] = new Star(this, 481, "*(_480:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 482 SeqOp            */ __Matchers[482] = new Seq(this, 482, "_482:(>parameter-declaration-or-ref-pattern,*(_480:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 483 AltOp            */ __Matchers[483] = new Alt(this, 483, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 484 SeqOp            */ __Matchers[484] = new Seq(this, 484, "_484:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 485 OptionalOp       */ __Matchers[485] = new Optional(this, 485, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 486 SeqOp            */ __Matchers[486] = new Seq(this, 486, "_486:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 487 AltOp            */ __Matchers[487] = new Alt(this, 487, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 488 AltOp            */ __Matchers[488] = new Alt(this, 488, "alt(>void-function-parameter|>inferred-function-parameter|>typed-function-parameter)") { Builder = nodes => nodes[0] };
                /* 489 StringOp         */ __Matchers[489] = new Keyword(this, 489, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 490 OptionalOp       */ __Matchers[490] = new Optional(this, 490, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 491 PlusOp           */ __Matchers[491] = new Plus(this, 491, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 492 OptionalOp       */ __Matchers[492] = new Optional(this, 492, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 493 SeqOp            */ __Matchers[493] = new Seq(this, 493, "_493:('void',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CVoidFunctionParameter(nodes) };
                /* 494 StringOp         */ __Matchers[494] = new Keyword(this, 494, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 495 SeqOp            */ __Matchers[495] = new Seq(this, 495, "_495:('function',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CInferredFunctionParameter(nodes) };
                /* 496 SeqOp            */ __Matchers[496] = new Seq(this, 496, "_496:(>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CTypedFunctionParameter(nodes) };
                /* 497 AltOp            */ __Matchers[497] = new Alt(this, 497, "alt(>inferred-value-parameter|>typed-value-parameter)") { Builder = nodes => nodes[0] };
                /* 498 StringOp         */ __Matchers[498] = new Keyword(this, 498, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 499 SeqOp            */ __Matchers[499] = new Seq(this, 499, "_499:('value',>member-name,?(>value-specifier))") { Builder = nodes => new CInferredValueParameter(nodes) };
                /* 500 SeqOp            */ __Matchers[500] = new Seq(this, 500, "_500:(>variadic-type,>member-name,?(>value-specifier))") { Builder = nodes => new CTypedValueParameter(nodes) };
                /* 501 StringOp         */ __Matchers[501] = new String(this, 501, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 502 StringOp         */ __Matchers[502] = new String(this, 502, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 503 SeqOp            */ __Matchers[503] = new Seq(this, 503, "_503:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 504 SeqOp            */ __Matchers[504] = new Seq(this, 504, "_504:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 505 StarOp           */ __Matchers[505] = new Star(this, 505, "*(_504:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 506 SeqOp            */ __Matchers[506] = new Seq(this, 506, "_506:(>type-parameter,*(_504:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 507 OptionalOp       */ __Matchers[507] = new Optional(this, 507, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 508 OptionalOp       */ __Matchers[508] = new Optional(this, 508, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 509 SeqOp            */ __Matchers[509] = new Seq(this, 509, "_509:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 510 StringOp         */ __Matchers[510] = new Keyword(this, 510, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 511 StringOp         */ __Matchers[511] = new Keyword(this, 511, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 512 AltOp            */ __Matchers[512] = new Alt(this, 512, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 513 SeqOp            */ __Matchers[513] = new Seq(this, 513, "_513:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 514 StringOp         */ __Matchers[514] = new Keyword(this, 514, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 515 OptionalOp       */ __Matchers[515] = new Optional(this, 515, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 516 OptionalOp       */ __Matchers[516] = new Optional(this, 516, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 517 OptionalOp       */ __Matchers[517] = new Optional(this, 517, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 518 SeqOp            */ __Matchers[518] = new Seq(this, 518, "_518:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 519 PlusOp           */ __Matchers[519] = new Plus(this, 519, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 520 StarOp           */ __Matchers[520] = new Star(this, 520, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 521 AltOp            */ __Matchers[521] = new Alt(this, 521, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 522 StringOp         */ __Matchers[522] = new Keyword(this, 522, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 523 OptionalOp       */ __Matchers[523] = new Optional(this, 523, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 524 OptionalOp       */ __Matchers[524] = new Optional(this, 524, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 525 SeqOp            */ __Matchers[525] = new Seq(this, 525, "_525:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 527 OptionalOp       */ __Matchers[527] = new Optional(this, 527, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 528 SeqOp            */ __Matchers[528] = new Seq(this, 528, "_528:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 529 SeqOp            */ __Matchers[529] = new Seq(this, 529, "_529:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 530 StringOp         */ __Matchers[530] = new Keyword(this, 530, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 531 OptionalOp       */ __Matchers[531] = new Optional(this, 531, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_532:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 533 StringOp         */ __Matchers[533] = new Keyword(this, 533, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 534 SeqOp            */ __Matchers[534] = new Seq(this, 534, "_534:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 535 AltOp            */ __Matchers[535] = new Alt(this, 535, "alt(>block|>required-function-specifier)") { Builder = nodes => nodes[0] };
                /* 536 SeqOp            */ __Matchers[536] = new Seq(this, 536, "_536:(>annotations,'void',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 537 SeqOp            */ __Matchers[537] = new Seq(this, 537, "_537:(>annotations,'function',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_538:(>annotations,>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 539 SeqOp            */ __Matchers[539] = new Seq(this, 539, "_539:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 540 SeqOp            */ __Matchers[540] = new Seq(this, 540, "_540:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 541 AltOp            */ __Matchers[541] = new Alt(this, 541, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 542 OptionalOp       */ __Matchers[542] = new Optional(this, 542, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 543 SeqOp            */ __Matchers[543] = new Seq(this, 543, "_543:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 544 StringOp         */ __Matchers[544] = new Keyword(this, 544, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 545 OptionalOp       */ __Matchers[545] = new Optional(this, 545, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 546 SeqOp            */ __Matchers[546] = new Seq(this, 546, "_546:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 547 AltOp            */ __Matchers[547] = new Alt(this, 547, "alt(>block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 548 OptionalOp       */ __Matchers[548] = new Optional(this, 548, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 549 SeqOp            */ __Matchers[549] = new Seq(this, 549, "_549:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 550 StringOp         */ __Matchers[550] = new Keyword(this, 550, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 551 SeqOp            */ __Matchers[551] = new Seq(this, 551, "_551:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 552 AltOp            */ __Matchers[552] = new Alt(this, 552, "alt(>block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 553 OptionalOp       */ __Matchers[553] = new Optional(this, 553, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 554 SeqOp            */ __Matchers[554] = new Seq(this, 554, "_554:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 555 StarOp           */ __Matchers[555] = new Star(this, 555, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 556 AltOp            */ __Matchers[556] = new Alt(this, 556, "alt(>declaration-statement|>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 557 SeqOp            */ __Matchers[557] = new Seq(this, 557, "_557:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 558 AltOp            */ __Matchers[558] = new Alt(this, 558, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 559 SeqOp            */ __Matchers[559] = new Seq(this, 559, "_559:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 560 AltOp            */ __Matchers[560] = new Alt(this, 560, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 561 StringOp         */ __Matchers[561] = new Keyword(this, 561, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 562 OptionalOp       */ __Matchers[562] = new Optional(this, 562, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_563:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 564 StringOp         */ __Matchers[564] = new Keyword(this, 564, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_565:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 566 StringOp         */ __Matchers[566] = new Keyword(this, 566, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 567 StringOp         */ __Matchers[567] = new Keyword(this, 567, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 568 SeqOp            */ __Matchers[568] = new Seq(this, 568, "_568:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 569 SeqOp            */ __Matchers[569] = new Seq(this, 569, "_569:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 571 AltOp            */ __Matchers[571] = new Alt(this, 571, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 572 AltOp            */ __Matchers[572] = new Alt(this, 572, "alt(>base-reference|>self-reference|>parametrized-member|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 573 AltOp            */ __Matchers[573] = new Alt(this, 573, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 574 SeqOp            */ __Matchers[574] = new Seq(this, 574, "_574:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 575 SeqOp            */ __Matchers[575] = new Seq(this, 575, "_575:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 576 OptionalOp       */ __Matchers[576] = new Optional(this, 576, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 577 SeqOp            */ __Matchers[577] = new Seq(this, 577, "_577:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 578 SeqOp            */ __Matchers[578] = new Seq(this, 578, "_578:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_579:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 580 StringOp         */ __Matchers[580] = new Keyword(this, 580, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 581 StringOp         */ __Matchers[581] = new Keyword(this, 581, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 582 AltOp            */ __Matchers[582] = new Alt(this, 582, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 583 OptionalOp       */ __Matchers[583] = new Optional(this, 583, "?(>sequenced-argument-list)") { Builder = nodes => new ROptional<CSequencedArgumentList>(nodes) };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_584:('{',>statements,?(>sequenced-argument-list),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_585:('[',?(>sequenced-argument-list),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 586 AltOp            */ __Matchers[586] = new Alt(this, 586, "alt(>patterned-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 587 StarOp           */ __Matchers[587] = new Star(this, 587, "*(>structured-argument)") { Builder = nodes => new RStar<ICStructuredArgument>(nodes) };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:('{',*(>structured-argument),?(>sequenced-argument-list),'}')") { Builder = nodes => new CPatternedArguments(nodes) };
                /* 589 SeqOp            */ __Matchers[589] = new Seq(this, 589, "_589:('(',?(>sequenced-argument-list),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 590 AltOp            */ __Matchers[590] = new Alt(this, 590, "alt(>anonymous-argument|>named-argument)") { Builder = nodes => nodes[0] };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 592 AltOp            */ __Matchers[592] = new Alt(this, 592, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_593:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_594:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 595 StarOp           */ __Matchers[595] = new Star(this, 595, "*(_594:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 596 SeqOp            */ __Matchers[596] = new Seq(this, 596, "_596:(>sequenced-argument,*(_594:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArgumentList(nodes) };
                /* 597 AltOp            */ __Matchers[597] = new Alt(this, 597, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 598 AltOp            */ __Matchers[598] = new Alt(this, 598, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 599 SeqOp            */ __Matchers[599] = new Seq(this, 599, "_599:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_600:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 601 AltOp            */ __Matchers[601] = new Alt(this, 601, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 602 SeqOp            */ __Matchers[602] = new Seq(this, 602, "_602:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_603:(>function-specifier,';')") { Builder = nodes => new CRequiredFunctionSpecifier(nodes) };
                /* 604 AltOp            */ __Matchers[604] = new Alt(this, 604, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_605:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 606 SeqOp            */ __Matchers[606] = new Seq(this, 606, "_606:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 608 SeqOp            */ __Matchers[608] = new Seq(this, 608, "_608:(>member-name,+(>parameters),>required-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 609 SeqOp            */ __Matchers[609] = new Seq(this, 609, "_609:(>member-name,>required-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 610 AltOp            */ __Matchers[610] = new Alt(this, 610, "alt(>expression-argument|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 611 SeqOp            */ __Matchers[611] = new Seq(this, 611, "_611:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 613 SeqOp            */ __Matchers[613] = new Seq(this, 613, "_613:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_614:(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 615 PlusOp           */ __Matchers[615] = new Plus(this, 615, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 616 OptionalOp       */ __Matchers[616] = new Optional(this, 616, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new Keyword(this, 618, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 619 OptionalOp       */ __Matchers[619] = new Optional(this, 619, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 620 StringOp         */ __Matchers[620] = new Keyword(this, 620, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 621 SeqOp            */ __Matchers[621] = new Seq(this, 621, "_621:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 622 StringOp         */ __Matchers[622] = new Keyword(this, 622, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 623 SeqOp            */ __Matchers[623] = new Seq(this, 623, "_623:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 624 SeqOp            */ __Matchers[624] = new Seq(this, 624, "_624:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 625 StringOp         */ __Matchers[625] = new Keyword(this, 625, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 626 SeqOp            */ __Matchers[626] = new Seq(this, 626, "_626:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 627 AltOp            */ __Matchers[627] = new Alt(this, 627, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 628 AltOp            */ __Matchers[628] = new Alt(this, 628, "alt(>void-function-expr|>inferred-function-expr)") { Builder = nodes => nodes[0] };
                /* 629 SeqOp            */ __Matchers[629] = new Seq(this, 629, "_629:('void',?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CVoidFunctionExpr(nodes) };
                /* 630 OptionalOp       */ __Matchers[630] = new Optional(this, 630, "?('function')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 631 SeqOp            */ __Matchers[631] = new Seq(this, 631, "_631:(?('function'),?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CInferredFunctionExpr(nodes) };
                /* 632 AltOp            */ __Matchers[632] = new Alt(this, 632, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 633 AltOp            */ __Matchers[633] = new Alt(this, 633, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 634 AltOp            */ __Matchers[634] = new Alt(this, 634, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 635 StringOp         */ __Matchers[635] = new Keyword(this, 635, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 636 OptionalOp       */ __Matchers[636] = new Optional(this, 636, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 637 SeqOp            */ __Matchers[637] = new Seq(this, 637, "_637:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 638 SeqOp            */ __Matchers[638] = new Seq(this, 638, "_638:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 639 AltOp            */ __Matchers[639] = new Alt(this, 639, "alt(>let-expr|>if-expr|>switch-expr|>function-expression|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 640 AltOp            */ __Matchers[640] = new Alt(this, 640, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 641 SeqOp            */ __Matchers[641] = new Seq(this, 641, "_641:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 647 StringOp         */ __Matchers[647] = new String(this, 647, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 648 StringOp         */ __Matchers[648] = new String(this, 648, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 649 StringOp         */ __Matchers[649] = new String(this, 649, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 650 StringOp         */ __Matchers[650] = new String(this, 650, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 651 StringOp         */ __Matchers[651] = new String(this, 651, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 652 StringOp         */ __Matchers[652] = new String(this, 652, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 653 AltOp            */ __Matchers[653] = new Alt(this, 653, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 654 AltOp            */ __Matchers[654] = new Alt(this, 654, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 655 SeqOp            */ __Matchers[655] = new Seq(this, 655, "_655:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 656 AltOp            */ __Matchers[656] = new Alt(this, 656, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 657 AltOp            */ __Matchers[657] = new Alt(this, 657, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 658 SeqOp            */ __Matchers[658] = new Seq(this, 658, "_658:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 659 StringOp         */ __Matchers[659] = new String(this, 659, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 660 AltOp            */ __Matchers[660] = new Alt(this, 660, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 661 SeqOp            */ __Matchers[661] = new Seq(this, 661, "_661:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 662 StringOp         */ __Matchers[662] = new String(this, 662, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 663 AltOp            */ __Matchers[663] = new Alt(this, 663, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 664 SeqOp            */ __Matchers[664] = new Seq(this, 664, "_664:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 665 StringOp         */ __Matchers[665] = new String(this, 665, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 666 AltOp            */ __Matchers[666] = new Alt(this, 666, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 667 AltOp            */ __Matchers[667] = new Alt(this, 667, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 668 SeqOp            */ __Matchers[668] = new Seq(this, 668, "_668:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 669 StringOp         */ __Matchers[669] = new String(this, 669, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 670 StringOp         */ __Matchers[670] = new String(this, 670, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 671 StringOp         */ __Matchers[671] = new String(this, 671, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 672 AltOp            */ __Matchers[672] = new Alt(this, 672, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 673 AltOp            */ __Matchers[673] = new Alt(this, 673, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 674 SeqOp            */ __Matchers[674] = new Seq(this, 674, "_674:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 675 SeqOp            */ __Matchers[675] = new Seq(this, 675, "_675:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 676 SeqOp            */ __Matchers[676] = new Seq(this, 676, "_676:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 677 SeqOp            */ __Matchers[677] = new Seq(this, 677, "_677:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 678 SeqOp            */ __Matchers[678] = new Seq(this, 678, "_678:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 679 SeqOp            */ __Matchers[679] = new Seq(this, 679, "_679:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 680 StringOp         */ __Matchers[680] = new String(this, 680, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 681 AltOp            */ __Matchers[681] = new Alt(this, 681, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 682 StringOp         */ __Matchers[682] = new String(this, 682, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 683 AltOp            */ __Matchers[683] = new Alt(this, 683, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 684 StringOp         */ __Matchers[684] = new String(this, 684, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 685 AltOp            */ __Matchers[685] = new Alt(this, 685, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 686 StringOp         */ __Matchers[686] = new Keyword(this, 686, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 687 AltOp            */ __Matchers[687] = new Alt(this, 687, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 688 AltOp            */ __Matchers[688] = new Alt(this, 688, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 689 StringOp         */ __Matchers[689] = new Keyword(this, 689, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 690 SeqOp            */ __Matchers[690] = new Seq(this, 690, "_690:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 691 StringOp         */ __Matchers[691] = new Keyword(this, 691, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 692 SeqOp            */ __Matchers[692] = new Seq(this, 692, "_692:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 693 AltOp            */ __Matchers[693] = new Alt(this, 693, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 694 SeqOp            */ __Matchers[694] = new Seq(this, 694, "_694:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 695 SeqOp            */ __Matchers[695] = new Seq(this, 695, "_695:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 696 StringOp         */ __Matchers[696] = new String(this, 696, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 697 AltOp            */ __Matchers[697] = new Alt(this, 697, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 698 AltOp            */ __Matchers[698] = new Alt(this, 698, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 699 SeqOp            */ __Matchers[699] = new Seq(this, 699, "_699:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 700 StringOp         */ __Matchers[700] = new String(this, 700, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 701 AltOp            */ __Matchers[701] = new Alt(this, 701, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 702 AltOp            */ __Matchers[702] = new Alt(this, 702, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 703 SeqOp            */ __Matchers[703] = new Seq(this, 703, "_703:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 704 StringOp         */ __Matchers[704] = new String(this, 704, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 705 AltOp            */ __Matchers[705] = new Alt(this, 705, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 706 SeqOp            */ __Matchers[706] = new Seq(this, 706, "_706:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 707 StringOp         */ __Matchers[707] = new String(this, 707, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 708 StringOp         */ __Matchers[708] = new String(this, 708, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 709 AltOp            */ __Matchers[709] = new Alt(this, 709, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 710 AltOp            */ __Matchers[710] = new Alt(this, 710, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 711 SeqOp            */ __Matchers[711] = new Seq(this, 711, "_711:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 712 StringOp         */ __Matchers[712] = new String(this, 712, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 713 AltOp            */ __Matchers[713] = new Alt(this, 713, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 714 AltOp            */ __Matchers[714] = new Alt(this, 714, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 715 SeqOp            */ __Matchers[715] = new Seq(this, 715, "_715:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 716 StringOp         */ __Matchers[716] = new String(this, 716, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 717 AltOp            */ __Matchers[717] = new Alt(this, 717, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 718 SeqOp            */ __Matchers[718] = new Seq(this, 718, "_718:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 719 StringOp         */ __Matchers[719] = new String(this, 719, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 720 AltOp            */ __Matchers[720] = new Alt(this, 720, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_721:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 722 AltOp            */ __Matchers[722] = new Alt(this, 722, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 723 NotOp            */ __Matchers[723] = new Not(this, 723, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 724 SeqOp            */ __Matchers[724] = new Seq(this, 724, "_724:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 725 NotOp            */ __Matchers[725] = new Not(this, 725, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 726 SeqOp            */ __Matchers[726] = new Seq(this, 726, "_726:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 727 AltOp            */ __Matchers[727] = new Alt(this, 727, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 728 SeqOp            */ __Matchers[728] = new Seq(this, 728, "_728:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 729 AltOp            */ __Matchers[729] = new Alt(this, 729, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 730 SeqOp            */ __Matchers[730] = new Seq(this, 730, "_730:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 731 StringOp         */ __Matchers[731] = new String(this, 731, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 732 StringOp         */ __Matchers[732] = new String(this, 732, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 733 AltOp            */ __Matchers[733] = new Alt(this, 733, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 734 AltOp            */ __Matchers[734] = new Alt(this, 734, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 735 SeqOp            */ __Matchers[735] = new Seq(this, 735, "_735:(>primary,>member-selection-operator,>base-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 736 StringOp         */ __Matchers[736] = new String(this, 736, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 737 StringOp         */ __Matchers[737] = new String(this, 737, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 738 AltOp            */ __Matchers[738] = new Alt(this, 738, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 740 AltOp            */ __Matchers[740] = new Alt(this, 740, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_741:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 742 SeqOp            */ __Matchers[742] = new Seq(this, 742, "_742:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 743 SeqOp            */ __Matchers[743] = new Seq(this, 743, "_743:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 744 SeqOp            */ __Matchers[744] = new Seq(this, 744, "_744:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 745 SeqOp            */ __Matchers[745] = new Seq(this, 745, "_745:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 746 AltOp            */ __Matchers[746] = new Alt(this, 746, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 747 AltOp            */ __Matchers[747] = new Alt(this, 747, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 748 AltOp            */ __Matchers[748] = new Alt(this, 748, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 749 StarOp           */ __Matchers[749] = new Star(this, 749, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_750:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 751 SeqOp            */ __Matchers[751] = new Seq(this, 751, "_751:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 752 AltOp            */ __Matchers[752] = new Alt(this, 752, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_753:('object',?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_754:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 755 OptionalOp       */ __Matchers[755] = new Optional(this, 755, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_756:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_757:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 758 StarOp           */ __Matchers[758] = new Star(this, 758, "*(_757:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_759:(>varianced-type,*(_757:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 760 SeqOp            */ __Matchers[760] = new Seq(this, 760, "_760:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 761 SeqOp            */ __Matchers[761] = new Seq(this, 761, "_761:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 762 StarOp           */ __Matchers[762] = new Star(this, 762, "*(_761:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 763 SeqOp            */ __Matchers[763] = new Seq(this, 763, "_763:(>defaulted-type,*(_761:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 764 AltOp            */ __Matchers[764] = new Alt(this, 764, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_765:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 766 AltOp            */ __Matchers[766] = new Alt(this, 766, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_767:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 768 SeqOp            */ __Matchers[768] = new Seq(this, 768, "_768:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 769 AltOp            */ __Matchers[769] = new Alt(this, 769, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 770 SeqOp            */ __Matchers[770] = new Seq(this, 770, "_770:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 771 AltOp            */ __Matchers[771] = new Alt(this, 771, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 772 SeqOp            */ __Matchers[772] = new Seq(this, 772, "_772:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 773 AltOp            */ __Matchers[773] = new Alt(this, 773, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 774 SeqOp            */ __Matchers[774] = new Seq(this, 774, "_774:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 775 AltOp            */ __Matchers[775] = new Alt(this, 775, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>package-qualified-type|>type-path)") { Builder = nodes => nodes[0] };
                /* 776 StringOp         */ __Matchers[776] = new String(this, 776, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 777 SeqOp            */ __Matchers[777] = new Seq(this, 777, "_777:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 778 OptionalOp       */ __Matchers[778] = new Optional(this, 778, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 779 SeqOp            */ __Matchers[779] = new Seq(this, 779, "_779:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 780 OptionalOp       */ __Matchers[780] = new Optional(this, 780, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 781 SeqOp            */ __Matchers[781] = new Seq(this, 781, "_781:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 782 AltOp            */ __Matchers[782] = new Alt(this, 782, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 783 SeqOp            */ __Matchers[783] = new Seq(this, 783, "_783:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 784 OptionalOp       */ __Matchers[784] = new Optional(this, 784, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 785 SeqOp            */ __Matchers[785] = new Seq(this, 785, "_785:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 786 SeqOp            */ __Matchers[786] = new Seq(this, 786, "_786:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 787 SeqOp            */ __Matchers[787] = new Seq(this, 787, "_787:('package','.',>type-path)") { Builder = nodes => new CPackageQualifiedType(nodes) };
                /* 788 OptionalOp       */ __Matchers[788] = new Optional(this, 788, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 789 StarOp           */ __Matchers[789] = new Star(this, 789, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_790:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_791:(>member-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 792 OptionalOp       */ __Matchers[792] = new Optional(this, 792, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 793 SeqOp            */ __Matchers[793] = new Seq(this, 793, "_793:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 794 SeqOp            */ __Matchers[794] = new Seq(this, 794, "_794:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 795 StarOp           */ __Matchers[795] = new Star(this, 795, "*(_794:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 796 SeqOp            */ __Matchers[796] = new Seq(this, 796, "_796:(>condition,*(_794:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 797 AltOp            */ __Matchers[797] = new Alt(this, 797, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 798 OptionalOp       */ __Matchers[798] = new Optional(this, 798, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 800 SeqOp            */ __Matchers[800] = new Seq(this, 800, "_800:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 801 AltOp            */ __Matchers[801] = new Alt(this, 801, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 802 SeqOp            */ __Matchers[802] = new Seq(this, 802, "_802:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 803 SeqOp            */ __Matchers[803] = new Seq(this, 803, "_803:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 804 SeqOp            */ __Matchers[804] = new Seq(this, 804, "_804:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 805 AltOp            */ __Matchers[805] = new Alt(this, 805, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 806 StarOp           */ __Matchers[806] = new Star(this, 806, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 807 OptionalOp       */ __Matchers[807] = new Optional(this, 807, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_808:('if',>conditions,>block,*(>else-if),?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 809 SeqOp            */ __Matchers[809] = new Seq(this, 809, "_809:('else','if',>conditions,>block)") { Builder = nodes => new CElseIf(nodes) };
                /* 810 SeqOp            */ __Matchers[810] = new Seq(this, 810, "_810:('else',>block)") { Builder = nodes => new CElseBlock(nodes) };
                /* 811 PlusOp           */ __Matchers[811] = new Plus(this, 811, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 812 SeqOp            */ __Matchers[812] = new Seq(this, 812, "_812:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 813 StringOp         */ __Matchers[813] = new Keyword(this, 813, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_814:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_815:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 816 AltOp            */ __Matchers[816] = new Alt(this, 816, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 817 OptionalOp       */ __Matchers[817] = new Optional(this, 817, "?('is')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 818 SeqOp            */ __Matchers[818] = new Seq(this, 818, "_818:(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 819 SeqOp            */ __Matchers[819] = new Seq(this, 819, "_819:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 820 SeqOp            */ __Matchers[820] = new Seq(this, 820, "_820:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 821 StarOp           */ __Matchers[821] = new Star(this, 821, "*(_820:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 822 SeqOp            */ __Matchers[822] = new Seq(this, 822, "_822:(>value-case,*(_820:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 823 AltOp            */ __Matchers[823] = new Alt(this, 823, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 824 AltOp            */ __Matchers[824] = new Alt(this, 824, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 825 SeqOp            */ __Matchers[825] = new Seq(this, 825, "_825:('for','(',?(>for-iterator),')',>block,?(>else-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 826 OptionalOp       */ __Matchers[826] = new Optional(this, 826, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 827 SeqOp            */ __Matchers[827] = new Seq(this, 827, "_827:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 828 AltOp            */ __Matchers[828] = new Alt(this, 828, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 829 SeqOp            */ __Matchers[829] = new Seq(this, 829, "_829:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 830 AltOp            */ __Matchers[830] = new Alt(this, 830, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 831 StringOp         */ __Matchers[831] = new Keyword(this, 831, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 832 SeqOp            */ __Matchers[832] = new Seq(this, 832, "_832:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 833 StarOp           */ __Matchers[833] = new Star(this, 833, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 834 OptionalOp       */ __Matchers[834] = new Optional(this, 834, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 835 SeqOp            */ __Matchers[835] = new Seq(this, 835, "_835:(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 836 StringOp         */ __Matchers[836] = new Keyword(this, 836, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 837 OptionalOp       */ __Matchers[837] = new Optional(this, 837, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 838 SeqOp            */ __Matchers[838] = new Seq(this, 838, "_838:('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 839 StringOp         */ __Matchers[839] = new Keyword(this, 839, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 840 SeqOp            */ __Matchers[840] = new Seq(this, 840, "_840:('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 841 OptionalOp       */ __Matchers[841] = new Optional(this, 841, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 842 SeqOp            */ __Matchers[842] = new Seq(this, 842, "_842:('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 843 StringOp         */ __Matchers[843] = new Keyword(this, 843, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_844:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 845 OptionalOp       */ __Matchers[845] = new Optional(this, 845, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_846:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 847 SeqOp            */ __Matchers[847] = new Seq(this, 847, "_847:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 848 StarOp           */ __Matchers[848] = new Star(this, 848, "*(_847:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 849 SeqOp            */ __Matchers[849] = new Seq(this, 849, "_849:(>resource,*(_847:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 850 AltOp            */ __Matchers[850] = new Alt(this, 850, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 851 SeqOp            */ __Matchers[851] = new Seq(this, 851, "_851:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 852 OptionalOp       */ __Matchers[852] = new Optional(this, 852, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 853 StarOp           */ __Matchers[853] = new Star(this, 853, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 854 SeqOp            */ __Matchers[854] = new Seq(this, 854, "_854:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 855 AltOp            */ __Matchers[855] = new Alt(this, 855, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 856 SeqOp            */ __Matchers[856] = new Seq(this, 856, "_856:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 857 StringOp         */ __Matchers[857] = new String(this, 857, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 858 SeqOp            */ __Matchers[858] = new Seq(this, 858, "_858:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 859 AltOp            */ __Matchers[859] = new Alt(this, 859, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 860 AltOp            */ __Matchers[860] = new Alt(this, 860, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 861 AltOp            */ __Matchers[861] = new Alt(this, 861, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 862 SeqOp            */ __Matchers[862] = new Seq(this, 862, "_862:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 863 SeqOp            */ __Matchers[863] = new Seq(this, 863, "_863:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 864 AltOp            */ __Matchers[864] = new Alt(this, 864, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 865 OptionalOp       */ __Matchers[865] = new Optional(this, 865, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_866:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_867:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_868:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 871 SeqOp            */ __Matchers[871] = new Seq(this, 871, "_871:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_872:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 873 SeqOp            */ __Matchers[873] = new Seq(this, 873, "_873:(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 874 AltOp            */ __Matchers[874] = new Alt(this, 874, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_875:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 876 SeqOp            */ __Matchers[876] = new Seq(this, 876, "_876:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 877 SeqOp            */ __Matchers[877] = new Seq(this, 877, "_877:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 878 SeqOp            */ __Matchers[878] = new Seq(this, 878, "_878:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 879 StarOp           */ __Matchers[879] = new Star(this, 879, "*(_878:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 880 SeqOp            */ __Matchers[880] = new Seq(this, 880, "_880:(>reference-path-element,*(_878:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[369]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[370]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[371]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[374]);
                /*   6 PlainRuleOp      */ _namespacePath.Set(__Matchers[378]);
                /*   7 PlainRuleOp      */ _imports.Set(__Matchers[379]);
                /*   8 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[383]);
                /*   9 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[386]);
                /*  10 PlainRuleOp      */ _repository.Set(_identifier);
                /*  11 PlainRuleOp      */ _module.Set(__Matchers[387]);
                /*  12 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[389]);
                /*  13 PlainRuleOp      */ _artifact.Set(__Matchers[390]);
                /*  14 PlainRuleOp      */ _classifier.Set(__Matchers[391]);
                /*  15 PlainRuleOp      */ _version.Set(_literalString);
                /*  16 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  17 PlainRuleOp      */ _moduleBody.Set(__Matchers[395]);
                /*  18 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[396]);
                /*  19 PlainRuleOp      */ _moduleImport.Set(__Matchers[398]);
                /*  20 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[400]);
                /*  21 PlainRuleOp      */ _importDeclaration.Set(__Matchers[401]);
                /*  22 PlainRuleOp      */ _importElements.Set(__Matchers[403]);
                /*  23 PlainRuleOp      */ _importElementList.Set(__Matchers[407]);
                /*  24 PlainRuleOp      */ _importElement.Set(__Matchers[408]);
                /*  25 PlainRuleOp      */ _importNamed.Set(__Matchers[411]);
                /*  26 PlainRuleOp      */ _importName.Set(_identifier);
                /*  27 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[413]);
                /*  28 PlainRuleOp      */ _importWildcard.Set(__Matchers[414]);
                /*  29 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  30 PlainRuleOp      */ _packagePath.Set(__Matchers[417]);
                /*  31 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  32 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  33 PlainRuleOp      */ _pattern.Set(__Matchers[418]);
                /*  34 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[419]);
                /*  35 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[420]);
                /*  36 PlainRuleOp      */ _entryPattern.Set(__Matchers[422]);
                /*  37 PlainRuleOp      */ _tuplePattern.Set(__Matchers[426]);
                /*  38 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[429]);
                /*  39 PlainRuleOp      */ _variadicPattern.Set(__Matchers[430]);
                /*  40 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  41 PlainRuleOp      */ _variadicVariable.Set(__Matchers[432]);
                /*  42 PlainRuleOp      */ _variadicOperator.Set(__Matchers[435]);
                /*  43 PlainRuleOp      */ _letStatement.Set(__Matchers[439]);
                /*  44 PlainRuleOp      */ _letVariableList.Set(__Matchers[442]);
                /*  45 PlainRuleOp      */ _letVariable.Set(__Matchers[443]);
                /*  46 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[445]);
                /*  47 PlainRuleOp      */ _assertionStatement.Set(__Matchers[448]);
                /*  48 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  49 PlainRuleOp      */ _block.Set(__Matchers[449]);
                /*  50 PlainRuleOp      */ _extendedType.Set(__Matchers[450]);
                /*  51 PlainRuleOp      */ _classSpecifier.Set(__Matchers[452]);
                /*  52 PlainRuleOp      */ _classInstantiation.Set(__Matchers[454]);
                /*  53 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[455]);
                /*  54 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[456]);
                /*  55 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[458]);
                /*  56 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[459]);
                /*  57 PlainRuleOp      */ _memberPath.Set(__Matchers[460]);
                /*  58 PlainRuleOp      */ _typePath.Set(__Matchers[463]);
                /*  59 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[465]);
                /*  60 PlainRuleOp      */ _unionTypeList.Set(__Matchers[468]);
                /*  61 PlainRuleOp      */ _caseTypes.Set(__Matchers[470]);
                /*  62 PlainRuleOp      */ _caseTypeList.Set(__Matchers[474]);
                /*  63 PlainRuleOp      */ _caseType.Set(__Matchers[475]);
                /*  64 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[477]);
                /*  65 PlainRuleOp      */ _parameters.Set(__Matchers[479]);
                /*  66 PlainRuleOp      */ _parameterList.Set(__Matchers[482]);
                /*  67 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[483]);
                /*  68 PlainRuleOp      */ _parameter.Set(__Matchers[484]);
                /*  69 PlainRuleOp      */ _parameterReference.Set(__Matchers[486]);
                /*  70 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[487]);
                /*  71 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[488]);
                /*  72 PlainRuleOp      */ _voidFunctionParameter.Set(__Matchers[493]);
                /*  73 PlainRuleOp      */ _inferredFunctionParameter.Set(__Matchers[495]);
                /*  74 PlainRuleOp      */ _typedFunctionParameter.Set(__Matchers[496]);
                /*  75 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[497]);
                /*  76 PlainRuleOp      */ _inferredValueParameter.Set(__Matchers[499]);
                /*  77 PlainRuleOp      */ _typedValueParameter.Set(__Matchers[500]);
                /*  78 PlainRuleOp      */ _typeParameters.Set(__Matchers[503]);
                /*  79 PlainRuleOp      */ _typeParameterList.Set(__Matchers[506]);
                /*  80 PlainRuleOp      */ _typeParameter.Set(__Matchers[509]);
                /*  81 PlainRuleOp      */ _variance.Set(__Matchers[512]);
                /*  82 PlainRuleOp      */ _typeDefault.Set(__Matchers[513]);
                /*  83 PlainRuleOp      */ _typeConstraint.Set(__Matchers[518]);
                /*  84 PlainRuleOp      */ _typeConstraints.Set(__Matchers[519]);
                /*  85 PlainRuleOp      */ _declarations.Set(__Matchers[520]);
                /*  86 PlainRuleOp      */ _declaration.Set(__Matchers[521]);
                /*  87 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[525]);
                /*  88 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[528]);
                /*  89 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[529]);
                /*  90 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[532]);
                /*  91 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[534]);
                /*  92 PlainRuleOp      */ _setterDefinition.Set(__Matchers[535]);
                /*  93 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[536]);
                /*  94 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[537]);
                /*  95 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[538]);
                /*  96 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[539]);
                /*  97 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[540]);
                /*  98 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[541]);
                /*  99 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[543]);
                /* 100 PlainRuleOp      */ _classDeclaration.Set(__Matchers[546]);
                /* 101 PlainRuleOp      */ _classDefinition.Set(__Matchers[547]);
                /* 102 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[549]);
                /* 103 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[551]);
                /* 104 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[552]);
                /* 105 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[554]);
                /* 106 PlainRuleOp      */ _statements.Set(__Matchers[555]);
                /* 107 PlainRuleOp      */ _statement.Set(__Matchers[556]);
                /* 108 PlainRuleOp      */ _declarationStatement.Set(_declaration);
                /* 109 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[557]);
                /* 110 PlainRuleOp      */ _openStatement.Set(__Matchers[558]);
                /* 111 PlainRuleOp      */ _specificationStatement.Set(__Matchers[559]);
                /* 112 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 113 PlainRuleOp      */ _directiveStatement.Set(__Matchers[560]);
                /* 114 PlainRuleOp      */ _returnStatement.Set(__Matchers[563]);
                /* 115 PlainRuleOp      */ _throwStatement.Set(__Matchers[565]);
                /* 116 PlainRuleOp      */ _breakStatement.Set(__Matchers[566]);
                /* 117 PlainRuleOp      */ _continueStatement.Set(__Matchers[567]);
                /* 118 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[568]);
                /* 119 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[569]);
                /* 120 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[570]);
                /* 121 PlainRuleOp      */ _anySpecifier.Set(__Matchers[571]);
                /* 122 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[572]);
                /* 123 PlainRuleOp      */ _baseReference.Set(__Matchers[573]);
                /* 124 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[574]);
                /* 125 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[575]);
                /* 126 PlainRuleOp      */ _memberReference.Set(__Matchers[577]);
                /* 127 PlainRuleOp      */ _typeReference.Set(__Matchers[578]);
                /* 128 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[579]);
                /* 129 PlainRuleOp      */ _selfReference.Set(__Matchers[582]);
                /* 130 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[584]);
                /* 131 PlainRuleOp      */ _tupleExpr.Set(__Matchers[585]);
                /* 132 PlainRuleOp      */ _arguments.Set(__Matchers[586]);
                /* 133 PlainRuleOp      */ _patternedArguments.Set(__Matchers[588]);
                /* 134 PlainRuleOp      */ _positionalArguments.Set(__Matchers[589]);
                /* 135 PlainRuleOp      */ _structuredArgument.Set(__Matchers[590]);
                /* 136 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[591]);
                /* 137 PlainRuleOp      */ _namedArgument.Set(__Matchers[592]);
                /* 138 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[593]);
                /* 139 PlainRuleOp      */ _sequencedArgumentList.Set(__Matchers[596]);
                /* 140 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[597]);
                /* 141 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[598]);
                /* 142 PlainRuleOp      */ _objectArgument.Set(__Matchers[599]);
                /* 143 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[600]);
                /* 144 PlainRuleOp      */ _methodDefinition.Set(__Matchers[601]);
                /* 145 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[602]);
                /* 146 PlainRuleOp      */ _requiredFunctionSpecifier.Set(__Matchers[603]);
                /* 147 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[604]);
                /* 148 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[605]);
                /* 149 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 150 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[606]);
                /* 151 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[607]);
                /* 152 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[608]);
                /* 153 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[609]);
                /* 154 PlainRuleOp      */ _positionalArgument.Set(__Matchers[610]);
                /* 155 PlainRuleOp      */ _expressionArgument.Set(_expression);
                /* 156 PlainRuleOp      */ _spreadArgument.Set(__Matchers[611]);
                /* 157 PlainRuleOp      */ _letExpr.Set(__Matchers[613]);
                /* 158 PlainRuleOp      */ _switchExpr.Set(__Matchers[614]);
                /* 159 PlainRuleOp      */ _caseExpressions.Set(__Matchers[617]);
                /* 160 PlainRuleOp      */ _caseExpression.Set(__Matchers[621]);
                /* 161 PlainRuleOp      */ _ifExpr.Set(__Matchers[623]);
                /* 162 PlainRuleOp      */ _elseExpression.Set(__Matchers[624]);
                /* 163 PlainRuleOp      */ _thenExpression.Set(__Matchers[626]);
                /* 164 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[627]);
                /* 165 PlainRuleOp      */ _functionExpression.Set(__Matchers[628]);
                /* 166 PlainRuleOp      */ _voidFunctionExpr.Set(__Matchers[629]);
                /* 167 PlainRuleOp      */ _inferredFunctionExpr.Set(__Matchers[631]);
                /* 168 PlainRuleOp      */ _functionDefinition.Set(__Matchers[632]);
                /* 169 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[633]);
                /* 170 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[634]);
                /* 171 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 172 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[637]);
                /* 173 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[638]);
                /* 174 PlainRuleOp      */ _expression.Set(__Matchers[639]);
                /* 175 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 176 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[640]);
                /* 177 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[641]);
                /* 178 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[653]);
                /* 179 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[654]);
                /* 180 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[655]);
                /* 181 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[656]);
                /* 182 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[657]);
                /* 183 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[658]);
                /* 184 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[659]);
                /* 185 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[660]);
                /* 186 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[661]);
                /* 187 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[662]);
                /* 188 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[663]);
                /* 189 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[664]);
                /* 190 PlainRuleOp      */ _notOperator.Set(__Matchers[665]);
                /* 191 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[666]);
                /* 192 PlainRuleOp      */ _equalityExpression.Set(__Matchers[667]);
                /* 193 PlainRuleOp      */ _equalityExpr.Set(__Matchers[668]);
                /* 194 PlainRuleOp      */ _equalityOperator.Set(__Matchers[672]);
                /* 195 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[673]);
                /* 196 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[674]);
                /* 197 PlainRuleOp      */ _largerExpr.Set(__Matchers[675]);
                /* 198 PlainRuleOp      */ _smallerExpr.Set(__Matchers[676]);
                /* 199 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[677]);
                /* 200 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[678]);
                /* 201 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[679]);
                /* 202 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[681]);
                /* 203 PlainRuleOp      */ _smallerOperator.Set(__Matchers[683]);
                /* 204 PlainRuleOp      */ _largerOperator.Set(__Matchers[685]);
                /* 205 PlainRuleOp      */ _typeOperator.Set(__Matchers[687]);
                /* 206 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[688]);
                /* 207 PlainRuleOp      */ _existsExpr.Set(__Matchers[690]);
                /* 208 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[692]);
                /* 209 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[693]);
                /* 210 PlainRuleOp      */ _rangeExpr.Set(__Matchers[694]);
                /* 211 PlainRuleOp      */ _entryExpr.Set(__Matchers[695]);
                /* 212 PlainRuleOp      */ _rangeOperator.Set(__Matchers[697]);
                /* 213 PlainRuleOp      */ _entryOperator.Set(__Matchers[421]);
                /* 214 PlainRuleOp      */ _additiveExpression.Set(__Matchers[698]);
                /* 215 PlainRuleOp      */ _additiveExpr.Set(__Matchers[699]);
                /* 216 PlainRuleOp      */ _additiveOperator.Set(__Matchers[701]);
                /* 217 PlainRuleOp      */ _scaleExpression.Set(__Matchers[702]);
                /* 218 PlainRuleOp      */ _scaleExpr.Set(__Matchers[703]);
                /* 219 PlainRuleOp      */ _scaleOperator.Set(__Matchers[704]);
                /* 220 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[705]);
                /* 221 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[706]);
                /* 222 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[709]);
                /* 223 PlainRuleOp      */ _unionExpression.Set(__Matchers[710]);
                /* 224 PlainRuleOp      */ _unionExpr.Set(__Matchers[711]);
                /* 225 PlainRuleOp      */ _unionOperator.Set(__Matchers[713]);
                /* 226 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[714]);
                /* 227 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[715]);
                /* 228 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[716]);
                /* 229 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[717]);
                /* 230 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[718]);
                /* 231 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[719]);
                /* 232 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[720]);
                /* 233 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[721]);
                /* 234 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[722]);
                /* 235 PlainRuleOp      */ _negateOperator.Set(__Matchers[724]);
                /* 236 PlainRuleOp      */ _neutralOperator.Set(__Matchers[726]);
                /* 237 PlainRuleOp      */ _complementOperator.Set(__Matchers[712]);
                /* 238 PlainRuleOp      */ _prefixExpression.Set(__Matchers[727]);
                /* 239 PlainRuleOp      */ _prefixExpr.Set(__Matchers[728]);
                /* 240 PlainRuleOp      */ _postfixExpression.Set(__Matchers[729]);
                /* 241 PlainRuleOp      */ _postfixExpr.Set(__Matchers[730]);
                /* 242 PlainRuleOp      */ _incrementOperator.Set(__Matchers[733]);
                /* 243 PlainRuleOp      */ _primary.Set(__Matchers[734]);
                /* 244 PlainRuleOp      */ _selectionExpr.Set(__Matchers[735]);
                /* 245 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[738]);
                /* 246 PlainRuleOp      */ _indexedExpr.Set(__Matchers[739]);
                /* 247 PlainRuleOp      */ _index.Set(__Matchers[740]);
                /* 248 PlainRuleOp      */ _upperSpanned.Set(__Matchers[741]);
                /* 249 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[742]);
                /* 250 PlainRuleOp      */ _spanned.Set(__Matchers[743]);
                /* 251 PlainRuleOp      */ _measured.Set(__Matchers[744]);
                /* 252 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 253 PlainRuleOp      */ _callExpr.Set(__Matchers[745]);
                /* 254 PlainRuleOp      */ _baseExpression.Set(__Matchers[746]);
                /* 255 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[747]);
                /* 256 PlainRuleOp      */ _stringExpression.Set(__Matchers[748]);
                /* 257 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[750]);
                /* 258 PlainRuleOp      */ _interpolationPart.Set(__Matchers[751]);
                /* 259 PlainRuleOp      */ _stringLiteral.Set(__Matchers[752]);
                /* 260 PlainRuleOp      */ _objectExpr.Set(__Matchers[753]);
                /* 261 PlainRuleOp      */ _groupedExpr.Set(__Matchers[754]);
                /* 262 PlainRuleOp      */ _typeArguments.Set(__Matchers[756]);
                /* 263 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[759]);
                /* 264 PlainRuleOp      */ _variancedType.Set(__Matchers[760]);
                /* 265 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[763]);
                /* 266 PlainRuleOp      */ _defaultedType.Set(__Matchers[764]);
                /* 267 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[765]);
                /* 268 PlainRuleOp      */ _variadicType.Set(__Matchers[766]);
                /* 269 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[767]);
                /* 270 PlainRuleOp      */ _spreadType.Set(__Matchers[768]);
                /* 271 PlainRuleOp      */ _type.Set(__Matchers[769]);
                /* 272 PlainRuleOp      */ _entryType.Set(__Matchers[770]);
                /* 273 PlainRuleOp      */ _unionType.Set(__Matchers[771]);
                /* 274 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[772]);
                /* 275 PlainRuleOp      */ _intersectionType.Set(__Matchers[773]);
                /* 276 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[774]);
                /* 277 PlainRuleOp      */ _primaryType.Set(__Matchers[775]);
                /* 278 PlainRuleOp      */ _nullableType.Set(__Matchers[777]);
                /* 279 PlainRuleOp      */ _arrayType.Set(__Matchers[779]);
                /* 280 PlainRuleOp      */ _functionType.Set(__Matchers[781]);
                /* 281 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[782]);
                /* 282 PlainRuleOp      */ _tupleType.Set(__Matchers[783]);
                /* 283 PlainRuleOp      */ _iterableType.Set(__Matchers[785]);
                /* 284 PlainRuleOp      */ _groupedType.Set(__Matchers[786]);
                /* 285 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[787]);
                /* 286 PlainRuleOp      */ _annotations.Set(__Matchers[790]);
                /* 287 PlainRuleOp      */ _annotation.Set(__Matchers[791]);
                /* 288 PlainRuleOp      */ _conditions.Set(__Matchers[793]);
                /* 289 PlainRuleOp      */ _conditionList.Set(__Matchers[796]);
                /* 290 PlainRuleOp      */ _condition.Set(__Matchers[797]);
                /* 291 PlainRuleOp      */ _existsCondition.Set(__Matchers[799]);
                /* 292 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[800]);
                /* 293 PlainRuleOp      */ _letOrExpression.Set(__Matchers[801]);
                /* 294 PlainRuleOp      */ _isCondition.Set(__Matchers[802]);
                /* 295 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[803]);
                /* 296 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[804]);
                /* 297 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 298 PlainRuleOp      */ _controlStatement.Set(__Matchers[805]);
                /* 299 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[808]);
                /* 300 PlainRuleOp      */ _elseIf.Set(__Matchers[809]);
                /* 301 PlainRuleOp      */ _elseBlock.Set(__Matchers[810]);
                /* 302 PlainRuleOp      */ _switchStatement.Set(__Matchers[812]);
                /* 303 PlainRuleOp      */ _switchHeader.Set(__Matchers[814]);
                /* 304 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 305 PlainRuleOp      */ _caseBlock.Set(__Matchers[815]);
                /* 306 PlainRuleOp      */ _caseItem.Set(__Matchers[816]);
                /* 307 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[818]);
                /* 308 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[819]);
                /* 309 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 310 PlainRuleOp      */ _valueCaseList.Set(__Matchers[822]);
                /* 311 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[823]);
                /* 312 PlainRuleOp      */ _valueCase.Set(__Matchers[824]);
                /* 313 PlainRuleOp      */ _forElseStatement.Set(__Matchers[825]);
                /* 314 PlainRuleOp      */ _forIterator.Set(__Matchers[827]);
                /* 315 PlainRuleOp      */ _forVariable.Set(__Matchers[828]);
                /* 316 PlainRuleOp      */ _containment.Set(__Matchers[829]);
                /* 317 PlainRuleOp      */ _containmentOperator.Set(__Matchers[830]);
                /* 318 PlainRuleOp      */ _whileStatement.Set(__Matchers[832]);
                /* 319 PlainRuleOp      */ _tryStatement.Set(__Matchers[835]);
                /* 320 PlainRuleOp      */ _tryBlock.Set(__Matchers[838]);
                /* 321 PlainRuleOp      */ _catchBlock.Set(__Matchers[840]);
                /* 322 PlainRuleOp      */ _catchVariable.Set(__Matchers[842]);
                /* 323 PlainRuleOp      */ _finallyBlock.Set(__Matchers[844]);
                /* 324 PlainRuleOp      */ _resources.Set(__Matchers[846]);
                /* 325 PlainRuleOp      */ _resourceList.Set(__Matchers[849]);
                /* 326 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 327 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[850]);
                /* 328 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[851]);
                /* 329 PlainRuleOp      */ _variable.Set(__Matchers[854]);
                /* 330 PlainRuleOp      */ _variableType.Set(__Matchers[855]);
                /* 331 PlainRuleOp      */ _modelReference.Set(__Matchers[856]);
                /* 332 PlainRuleOp      */ _metaLiteral.Set(__Matchers[858]);
                /* 333 PlainRuleOp      */ _metaExpression.Set(__Matchers[859]);
                /* 334 PlainRuleOp      */ _modelExpression.Set(__Matchers[860]);
                /* 335 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[861]);
                /* 336 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[862]);
                /* 337 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[863]);
                /* 338 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 339 PlainRuleOp      */ _declarationReference.Set(__Matchers[864]);
                /* 340 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[866]);
                /* 341 PlainRuleOp      */ _packageLiteral.Set(__Matchers[867]);
                /* 342 PlainRuleOp      */ _classLiteral.Set(__Matchers[868]);
                /* 343 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[869]);
                /* 344 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[870]);
                /* 345 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[871]);
                /* 346 PlainRuleOp      */ _newLiteral.Set(__Matchers[872]);
                /* 347 PlainRuleOp      */ _valueLiteral.Set(__Matchers[873]);
                /* 348 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[874]);
                /* 349 PlainRuleOp      */ _functionLiteral.Set(__Matchers[875]);
                /* 350 PlainRuleOp      */ _packageQualifier.Set(__Matchers[876]);
                /* 351 PlainRuleOp      */ _referencePath.Set(__Matchers[877]);
                /* 352 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[880]);
                /* 353 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 354 PlainRuleOp      */ _kwVoid.Set(__Matchers[489]);
                /* 355 PlainRuleOp      */ _kwFunction.Set(__Matchers[494]);
                /* 356 PlainRuleOp      */ _kwValue.Set(__Matchers[498]);
                /* 357 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 358 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 359 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 360 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 361 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 362 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 363 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 364 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 365 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 366 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 367 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 369 SeqOp            */ __Matchers[369].Set(_compilationUnit, __Matchers[368]);
                /* 370 AltOp            */ __Matchers[370].Set(_moduleDescriptor, _packageDescriptor, _codeUnit);
                /* 371 SeqOp            */ __Matchers[371].Set(_imports, _namespace, _declarations);
                /* 374 SeqOp            */ __Matchers[374].Set(_annotations, __Matchers[372], _namespacePath, __Matchers[373]);
                /* 376 SeqOp            */ __Matchers[376].Set(__Matchers[375], _identifier);
                /* 377 StarOp           */ __Matchers[377].Set(__Matchers[376]);
                /* 378 SeqOp            */ __Matchers[378].Set(_identifier, __Matchers[377]);
                /* 379 StarOp           */ __Matchers[379].Set(_importDeclaration);
                /* 381 OptionalOp       */ __Matchers[381].Set(_moduleSpecifier);
                /* 382 OptionalOp       */ __Matchers[382].Set(_version);
                /* 383 SeqOp            */ __Matchers[383].Set(_annotations, __Matchers[380], _moduleName, __Matchers[381], __Matchers[382], _moduleBody);
                /* 385 OptionalOp       */ __Matchers[385].Set(_artifactAndClassifier);
                /* 386 SeqOp            */ __Matchers[386].Set(_repository, __Matchers[384], _module, __Matchers[385]);
                /* 387 AltOp            */ __Matchers[387].Set(_literalString, _moduleName);
                /* 388 OptionalOp       */ __Matchers[388].Set(_classifier);
                /* 389 SeqOp            */ __Matchers[389].Set(_artifact, __Matchers[388]);
                /* 390 SeqOp            */ __Matchers[390].Set(__Matchers[384], _literalString);
                /* 391 SeqOp            */ __Matchers[391].Set(__Matchers[384], _literalString);
                /* 393 StarOp           */ __Matchers[393].Set(_moduleBodyElement);
                /* 395 SeqOp            */ __Matchers[395].Set(__Matchers[392], __Matchers[393], __Matchers[394]);
                /* 396 AltOp            */ __Matchers[396].Set(_inferredAttributeDeclaration, _moduleImport);
                /* 398 SeqOp            */ __Matchers[398].Set(_annotations, __Matchers[397], _module, __Matchers[382], __Matchers[373]);
                /* 400 SeqOp            */ __Matchers[400].Set(_annotations, __Matchers[399], _packagePath, __Matchers[373]);
                /* 401 SeqOp            */ __Matchers[401].Set(__Matchers[397], _packagePath, _importElements);
                /* 402 OptionalOp       */ __Matchers[402].Set(_importElementList);
                /* 403 SeqOp            */ __Matchers[403].Set(__Matchers[392], __Matchers[402], __Matchers[394]);
                /* 405 SeqOp            */ __Matchers[405].Set(__Matchers[404], _importElement);
                /* 406 StarOp           */ __Matchers[406].Set(__Matchers[405]);
                /* 407 SeqOp            */ __Matchers[407].Set(_importElement, __Matchers[406]);
                /* 408 AltOp            */ __Matchers[408].Set(_importNamed, _importWildcard);
                /* 409 OptionalOp       */ __Matchers[409].Set(_importNameSpecifier);
                /* 410 OptionalOp       */ __Matchers[410].Set(_importElements);
                /* 411 SeqOp            */ __Matchers[411].Set(_importName, __Matchers[409], __Matchers[410]);
                /* 413 SeqOp            */ __Matchers[413].Set(__Matchers[412], _identifier);
                /* 415 SeqOp            */ __Matchers[415].Set(__Matchers[375], _packageName);
                /* 416 StarOp           */ __Matchers[416].Set(__Matchers[415]);
                /* 417 SeqOp            */ __Matchers[417].Set(_packageName, __Matchers[416]);
                /* 418 AltOp            */ __Matchers[418].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 419 AltOp            */ __Matchers[419].Set(_tuplePattern, _variablePattern);
                /* 420 AltOp            */ __Matchers[420].Set(_entryPattern, _tuplePattern);
                /* 422 SeqOp            */ __Matchers[422].Set(_variableOrTuplePattern, __Matchers[421], _variableOrTuplePattern);
                /* 424 OptionalOp       */ __Matchers[424].Set(_variadicPatternList);
                /* 426 SeqOp            */ __Matchers[426].Set(__Matchers[423], __Matchers[424], __Matchers[425]);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[404], _variadicPattern);
                /* 428 StarOp           */ __Matchers[428].Set(__Matchers[427]);
                /* 429 SeqOp            */ __Matchers[429].Set(_variadicPattern, __Matchers[428]);
                /* 430 AltOp            */ __Matchers[430].Set(_variadicVariable, _pattern);
                /* 431 OptionalOp       */ __Matchers[431].Set(_unionType);
                /* 432 SeqOp            */ __Matchers[432].Set(__Matchers[431], _variadicOperator, _memberName);
                /* 435 AltOp            */ __Matchers[435].Set(__Matchers[433], __Matchers[434]);
                /* 439 SeqOp            */ __Matchers[439].Set(__Matchers[436], __Matchers[437], _letVariableList, __Matchers[438]);
                /* 440 SeqOp            */ __Matchers[440].Set(__Matchers[404], _letVariable);
                /* 441 StarOp           */ __Matchers[441].Set(__Matchers[440]);
                /* 442 SeqOp            */ __Matchers[442].Set(_letVariable, __Matchers[441]);
                /* 443 SeqOp            */ __Matchers[443].Set(_pattern, _valueSpecifier);
                /* 445 SeqOp            */ __Matchers[445].Set(__Matchers[444], _classInstantiation);
                /* 446 OptionalOp       */ __Matchers[446].Set(_assertionMessage);
                /* 448 SeqOp            */ __Matchers[448].Set(__Matchers[446], __Matchers[447], _conditions);
                /* 449 SeqOp            */ __Matchers[449].Set(__Matchers[392], _imports, _statements, __Matchers[394]);
                /* 450 SeqOp            */ __Matchers[450].Set(__Matchers[444], _classInstantiation);
                /* 452 SeqOp            */ __Matchers[452].Set(__Matchers[451], _classInstantiation);
                /* 453 OptionalOp       */ __Matchers[453].Set(_arguments);
                /* 454 SeqOp            */ __Matchers[454].Set(_qualifiedClass, __Matchers[453]);
                /* 455 AltOp            */ __Matchers[455].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[399], __Matchers[375], _unQualifiedClass);
                /* 458 SeqOp            */ __Matchers[458].Set(__Matchers[457], __Matchers[375], _baseReference);
                /* 459 AltOp            */ __Matchers[459].Set(_memberPath, _typePath, _memberReference);
                /* 460 SeqOp            */ __Matchers[460].Set(_typePath, __Matchers[375], _memberReference);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[375], _typeReference);
                /* 462 StarOp           */ __Matchers[462].Set(__Matchers[461]);
                /* 463 SeqOp            */ __Matchers[463].Set(_typeReference, __Matchers[462]);
                /* 465 SeqOp            */ __Matchers[465].Set(__Matchers[464], _unionTypeList);
                /* 466 SeqOp            */ __Matchers[466].Set(__Matchers[404], _unionType);
                /* 467 StarOp           */ __Matchers[467].Set(__Matchers[466]);
                /* 468 SeqOp            */ __Matchers[468].Set(_unionType, __Matchers[467]);
                /* 470 SeqOp            */ __Matchers[470].Set(__Matchers[469], _caseTypeList);
                /* 472 SeqOp            */ __Matchers[472].Set(__Matchers[471], _caseType);
                /* 473 StarOp           */ __Matchers[473].Set(__Matchers[472]);
                /* 474 SeqOp            */ __Matchers[474].Set(_caseType, __Matchers[473]);
                /* 475 AltOp            */ __Matchers[475].Set(_primaryType, _qualifiedCaseType);
                /* 476 OptionalOp       */ __Matchers[476].Set(_packageQualifier);
                /* 477 SeqOp            */ __Matchers[477].Set(__Matchers[476], _memberName);
                /* 478 OptionalOp       */ __Matchers[478].Set(_parameterList);
                /* 479 SeqOp            */ __Matchers[479].Set(__Matchers[437], __Matchers[478], __Matchers[438]);
                /* 480 SeqOp            */ __Matchers[480].Set(__Matchers[404], _parameterDeclarationOrRefPattern);
                /* 481 StarOp           */ __Matchers[481].Set(__Matchers[480]);
                /* 482 SeqOp            */ __Matchers[482].Set(_parameterDeclarationOrRefPattern, __Matchers[481]);
                /* 483 AltOp            */ __Matchers[483].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 484 SeqOp            */ __Matchers[484].Set(_annotations, _parameterDeclaration);
                /* 485 OptionalOp       */ __Matchers[485].Set(_valueSpecifier);
                /* 486 SeqOp            */ __Matchers[486].Set(_memberName, __Matchers[485]);
                /* 487 AltOp            */ __Matchers[487].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 488 AltOp            */ __Matchers[488].Set(_voidFunctionParameter, _inferredFunctionParameter, _typedFunctionParameter);
                /* 490 OptionalOp       */ __Matchers[490].Set(_typeParameters);
                /* 491 PlusOp           */ __Matchers[491].Set(_parameters);
                /* 492 OptionalOp       */ __Matchers[492].Set(_functionSpecifier);
                /* 493 SeqOp            */ __Matchers[493].Set(__Matchers[489], _memberName, __Matchers[490], __Matchers[491], __Matchers[492]);
                /* 495 SeqOp            */ __Matchers[495].Set(__Matchers[494], _memberName, __Matchers[490], __Matchers[491], __Matchers[492]);
                /* 496 SeqOp            */ __Matchers[496].Set(_variadicType, _memberName, __Matchers[490], __Matchers[491], __Matchers[492]);
                /* 497 AltOp            */ __Matchers[497].Set(_inferredValueParameter, _typedValueParameter);
                /* 499 SeqOp            */ __Matchers[499].Set(__Matchers[498], _memberName, __Matchers[485]);
                /* 500 SeqOp            */ __Matchers[500].Set(_variadicType, _memberName, __Matchers[485]);
                /* 503 SeqOp            */ __Matchers[503].Set(__Matchers[501], _typeParameterList, __Matchers[502]);
                /* 504 SeqOp            */ __Matchers[504].Set(__Matchers[404], _typeParameter);
                /* 505 StarOp           */ __Matchers[505].Set(__Matchers[504]);
                /* 506 SeqOp            */ __Matchers[506].Set(_typeParameter, __Matchers[505]);
                /* 507 OptionalOp       */ __Matchers[507].Set(_variance);
                /* 508 OptionalOp       */ __Matchers[508].Set(_typeDefault);
                /* 509 SeqOp            */ __Matchers[509].Set(__Matchers[507], _typeName, __Matchers[508]);
                /* 512 AltOp            */ __Matchers[512].Set(__Matchers[510], __Matchers[511]);
                /* 513 SeqOp            */ __Matchers[513].Set(__Matchers[412], _type);
                /* 515 OptionalOp       */ __Matchers[515].Set(_typeName);
                /* 516 OptionalOp       */ __Matchers[516].Set(_caseTypes);
                /* 517 OptionalOp       */ __Matchers[517].Set(_satisfiedTypes);
                /* 518 SeqOp            */ __Matchers[518].Set(__Matchers[514], __Matchers[515], __Matchers[490], __Matchers[516], __Matchers[517]);
                /* 519 PlusOp           */ __Matchers[519].Set(_typeConstraint);
                /* 520 StarOp           */ __Matchers[520].Set(_declaration);
                /* 521 AltOp            */ __Matchers[521].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 523 OptionalOp       */ __Matchers[523].Set(_memberName);
                /* 524 OptionalOp       */ __Matchers[524].Set(_delegatedConstructor);
                /* 525 SeqOp            */ __Matchers[525].Set(_annotations, __Matchers[522], __Matchers[523], _parameters, __Matchers[524], _block);
                /* 527 OptionalOp       */ __Matchers[527].Set(_typeConstraints);
                /* 528 SeqOp            */ __Matchers[528].Set(_annotations, __Matchers[526], _typeName, __Matchers[490], __Matchers[527], _optionalTypeSpecifier);
                /* 529 SeqOp            */ __Matchers[529].Set(_annotations, __Matchers[522], _memberName, __Matchers[524], _block);
                /* 531 OptionalOp       */ __Matchers[531].Set(_extendedType);
                /* 532 SeqOp            */ __Matchers[532].Set(_annotations, __Matchers[530], _memberName, __Matchers[531], __Matchers[517], _block);
                /* 534 SeqOp            */ __Matchers[534].Set(_annotations, __Matchers[533], _memberName, _setterDefinition);
                /* 535 AltOp            */ __Matchers[535].Set(_block, _requiredFunctionSpecifier);
                /* 536 SeqOp            */ __Matchers[536].Set(_annotations, __Matchers[489], _memberName, __Matchers[490], __Matchers[491], __Matchers[527], _methodDefinition);
                /* 537 SeqOp            */ __Matchers[537].Set(_annotations, __Matchers[494], _memberName, __Matchers[490], __Matchers[491], __Matchers[527], _methodDefinition);
                /* 538 SeqOp            */ __Matchers[538].Set(_annotations, _variadicType, _memberName, __Matchers[490], __Matchers[491], __Matchers[527], _methodDefinition);
                /* 539 SeqOp            */ __Matchers[539].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 540 SeqOp            */ __Matchers[540].Set(_annotations, __Matchers[498], _memberName, _attributeDefinition);
                /* 541 AltOp            */ __Matchers[541].Set(_block, _optionalAnySpecifier);
                /* 542 OptionalOp       */ __Matchers[542].Set(_anySpecifier);
                /* 543 SeqOp            */ __Matchers[543].Set(__Matchers[542], __Matchers[373]);
                /* 545 OptionalOp       */ __Matchers[545].Set(_parameters);
                /* 546 SeqOp            */ __Matchers[546].Set(_annotations, __Matchers[544], _typeName, __Matchers[490], __Matchers[545], __Matchers[516], __Matchers[531], __Matchers[517], __Matchers[527], _classDefinition);
                /* 547 AltOp            */ __Matchers[547].Set(_block, _optionalClassSpecifier);
                /* 548 OptionalOp       */ __Matchers[548].Set(_classSpecifier);
                /* 549 SeqOp            */ __Matchers[549].Set(__Matchers[548], __Matchers[373]);
                /* 551 SeqOp            */ __Matchers[551].Set(_annotations, __Matchers[550], _typeName, __Matchers[490], __Matchers[516], __Matchers[517], __Matchers[527], _interfaceDefinition);
                /* 552 AltOp            */ __Matchers[552].Set(_block, _optionalTypeSpecifier);
                /* 553 OptionalOp       */ __Matchers[553].Set(_typeSpecifier);
                /* 554 SeqOp            */ __Matchers[554].Set(__Matchers[553], __Matchers[373]);
                /* 555 StarOp           */ __Matchers[555].Set(_statement);
                /* 556 AltOp            */ __Matchers[556].Set(_declarationStatement, _unclosedStatement, _controlStatement);
                /* 557 SeqOp            */ __Matchers[557].Set(_openStatement, __Matchers[373]);
                /* 558 AltOp            */ __Matchers[558].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 559 SeqOp            */ __Matchers[559].Set(_primary, _functionSpecifier);
                /* 560 AltOp            */ __Matchers[560].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 562 OptionalOp       */ __Matchers[562].Set(_expression);
                /* 563 SeqOp            */ __Matchers[563].Set(__Matchers[561], __Matchers[562]);
                /* 565 SeqOp            */ __Matchers[565].Set(__Matchers[564], __Matchers[562]);
                /* 568 SeqOp            */ __Matchers[568].Set(__Matchers[451], _type);
                /* 569 SeqOp            */ __Matchers[569].Set(__Matchers[412], _expression);
                /* 570 SeqOp            */ __Matchers[570].Set(__Matchers[451], _expression);
                /* 571 AltOp            */ __Matchers[571].Set(_valueSpecifier, _functionSpecifier);
                /* 572 AltOp            */ __Matchers[572].Set(_baseReference, _selfReference, _parametrizedMember, _selfParametrizedMember);
                /* 573 AltOp            */ __Matchers[573].Set(_memberReference, _typeReference);
                /* 574 SeqOp            */ __Matchers[574].Set(_memberName, __Matchers[490], __Matchers[491]);
                /* 575 SeqOp            */ __Matchers[575].Set(_selfReferenceSelector, _parametrizedMember);
                /* 576 OptionalOp       */ __Matchers[576].Set(_typeArguments);
                /* 577 SeqOp            */ __Matchers[577].Set(_memberName, __Matchers[576]);
                /* 578 SeqOp            */ __Matchers[578].Set(_typeName, __Matchers[576]);
                /* 579 SeqOp            */ __Matchers[579].Set(_selfReference, _memberSelectionOperator);
                /* 582 AltOp            */ __Matchers[582].Set(__Matchers[580], __Matchers[457], __Matchers[581], __Matchers[399]);
                /* 583 OptionalOp       */ __Matchers[583].Set(_sequencedArgumentList);
                /* 584 SeqOp            */ __Matchers[584].Set(__Matchers[392], _statements, __Matchers[583], __Matchers[394]);
                /* 585 SeqOp            */ __Matchers[585].Set(__Matchers[423], __Matchers[583], __Matchers[425]);
                /* 586 AltOp            */ __Matchers[586].Set(_patternedArguments, _positionalArguments);
                /* 587 StarOp           */ __Matchers[587].Set(_structuredArgument);
                /* 588 SeqOp            */ __Matchers[588].Set(__Matchers[392], __Matchers[587], __Matchers[583], __Matchers[394]);
                /* 589 SeqOp            */ __Matchers[589].Set(__Matchers[437], __Matchers[583], __Matchers[438]);
                /* 590 AltOp            */ __Matchers[590].Set(_anonymousArgument, _namedArgument);
                /* 591 SeqOp            */ __Matchers[591].Set(_expression, __Matchers[373]);
                /* 592 AltOp            */ __Matchers[592].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 593 SeqOp            */ __Matchers[593].Set(_memberName, _valueSpecifier, __Matchers[373]);
                /* 594 SeqOp            */ __Matchers[594].Set(__Matchers[404], _sequencedArgument);
                /* 595 StarOp           */ __Matchers[595].Set(__Matchers[594]);
                /* 596 SeqOp            */ __Matchers[596].Set(_sequencedArgument, __Matchers[595]);
                /* 597 AltOp            */ __Matchers[597].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 598 AltOp            */ __Matchers[598].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 599 SeqOp            */ __Matchers[599].Set(__Matchers[530], __Matchers[523], __Matchers[531], __Matchers[517], _block);
                /* 600 SeqOp            */ __Matchers[600].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 601 AltOp            */ __Matchers[601].Set(_block, _optionalFunctionSpecifier);
                /* 602 SeqOp            */ __Matchers[602].Set(__Matchers[492], __Matchers[373]);
                /* 603 SeqOp            */ __Matchers[603].Set(_functionSpecifier, __Matchers[373]);
                /* 604 AltOp            */ __Matchers[604].Set(_type, _kwVoid);
                /* 605 SeqOp            */ __Matchers[605].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 606 SeqOp            */ __Matchers[606].Set(__Matchers[494], __Matchers[523], __Matchers[490], _parameters, _methodDefinition);
                /* 607 SeqOp            */ __Matchers[607].Set(__Matchers[498], _memberName, _methodDefinition);
                /* 608 SeqOp            */ __Matchers[608].Set(_memberName, __Matchers[491], _requiredFunctionSpecifier);
                /* 609 SeqOp            */ __Matchers[609].Set(_memberName, _requiredFunctionSpecifier);
                /* 610 AltOp            */ __Matchers[610].Set(_expressionArgument, _declarationReference);
                /* 611 SeqOp            */ __Matchers[611].Set(__Matchers[433], _unionExpression);
                /* 612 OptionalOp       */ __Matchers[612].Set(_letVariableList);
                /* 613 SeqOp            */ __Matchers[613].Set(__Matchers[436], __Matchers[437], __Matchers[612], __Matchers[438], _conditionalExpression);
                /* 614 SeqOp            */ __Matchers[614].Set(_switchHeader, _caseExpressions);
                /* 615 PlusOp           */ __Matchers[615].Set(_caseExpression);
                /* 616 OptionalOp       */ __Matchers[616].Set(_elseExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[615], __Matchers[616]);
                /* 619 OptionalOp       */ __Matchers[619].Set(__Matchers[618]);
                /* 621 SeqOp            */ __Matchers[621].Set(__Matchers[619], __Matchers[620], __Matchers[437], _caseItem, __Matchers[438], _conditionalExpression);
                /* 623 SeqOp            */ __Matchers[623].Set(__Matchers[622], _conditions, _thenExpression, _elseExpression);
                /* 624 SeqOp            */ __Matchers[624].Set(__Matchers[618], _conditionalExpression);
                /* 626 SeqOp            */ __Matchers[626].Set(__Matchers[625], _conditionalExpression);
                /* 627 AltOp            */ __Matchers[627].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 628 AltOp            */ __Matchers[628].Set(_voidFunctionExpr, _inferredFunctionExpr);
                /* 629 SeqOp            */ __Matchers[629].Set(__Matchers[489], __Matchers[490], __Matchers[491], __Matchers[527], _functionDefinition);
                /* 630 OptionalOp       */ __Matchers[630].Set(__Matchers[494]);
                /* 631 SeqOp            */ __Matchers[631].Set(__Matchers[630], __Matchers[490], __Matchers[491], __Matchers[527], _functionDefinition);
                /* 632 AltOp            */ __Matchers[632].Set(_block, _functionSpecifier);
                /* 633 AltOp            */ __Matchers[633].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 634 AltOp            */ __Matchers[634].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 636 OptionalOp       */ __Matchers[636].Set(_forIterator);
                /* 637 SeqOp            */ __Matchers[637].Set(__Matchers[635], __Matchers[437], __Matchers[636], __Matchers[438], _comprehensionClause);
                /* 638 SeqOp            */ __Matchers[638].Set(__Matchers[622], _conditions, _comprehensionClause);
                /* 639 AltOp            */ __Matchers[639].Set(_letExpr, _ifExpr, _switchExpr, _functionExpression, _operatorExpression);
                /* 640 AltOp            */ __Matchers[640].Set(_assignmentExpr, _thenElseExpression);
                /* 641 SeqOp            */ __Matchers[641].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 653 AltOp            */ __Matchers[653].Set(__Matchers[412], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646], __Matchers[647], __Matchers[648], __Matchers[649], __Matchers[650], __Matchers[651], __Matchers[652]);
                /* 654 AltOp            */ __Matchers[654].Set(_thenElseExpr, _disjunctionExpression);
                /* 655 SeqOp            */ __Matchers[655].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 656 AltOp            */ __Matchers[656].Set(__Matchers[618], __Matchers[625]);
                /* 657 AltOp            */ __Matchers[657].Set(_disjunctionExpr, _conjunctionExpression);
                /* 658 SeqOp            */ __Matchers[658].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 660 AltOp            */ __Matchers[660].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 661 SeqOp            */ __Matchers[661].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 663 AltOp            */ __Matchers[663].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 664 SeqOp            */ __Matchers[664].Set(_notOperator, _logicalNegationExpression);
                /* 666 AltOp            */ __Matchers[666].Set(_equalityExpression, _modelReference);
                /* 667 AltOp            */ __Matchers[667].Set(_equalityExpr, _comparisonExpression);
                /* 668 SeqOp            */ __Matchers[668].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 672 AltOp            */ __Matchers[672].Set(__Matchers[669], __Matchers[670], __Matchers[671]);
                /* 673 AltOp            */ __Matchers[673].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 674 SeqOp            */ __Matchers[674].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 675 SeqOp            */ __Matchers[675].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 676 SeqOp            */ __Matchers[676].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 677 SeqOp            */ __Matchers[677].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 678 SeqOp            */ __Matchers[678].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 679 SeqOp            */ __Matchers[679].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 681 AltOp            */ __Matchers[681].Set(__Matchers[680], __Matchers[510]);
                /* 683 AltOp            */ __Matchers[683].Set(__Matchers[682], __Matchers[501]);
                /* 685 AltOp            */ __Matchers[685].Set(__Matchers[684], __Matchers[502]);
                /* 687 AltOp            */ __Matchers[687].Set(__Matchers[686], __Matchers[444], __Matchers[464], __Matchers[469]);
                /* 688 AltOp            */ __Matchers[688].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 690 SeqOp            */ __Matchers[690].Set(_entryRangeExpression, __Matchers[689]);
                /* 692 SeqOp            */ __Matchers[692].Set(_entryRangeExpression, __Matchers[691]);
                /* 693 AltOp            */ __Matchers[693].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 694 SeqOp            */ __Matchers[694].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 695 SeqOp            */ __Matchers[695].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 697 AltOp            */ __Matchers[697].Set(__Matchers[696], __Matchers[384]);
                /* 698 AltOp            */ __Matchers[698].Set(_additiveExpr, _scaleExpression);
                /* 699 SeqOp            */ __Matchers[699].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 701 AltOp            */ __Matchers[701].Set(__Matchers[434], __Matchers[700]);
                /* 702 AltOp            */ __Matchers[702].Set(_scaleExpr, _multiplicativeExpression);
                /* 703 SeqOp            */ __Matchers[703].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 705 AltOp            */ __Matchers[705].Set(_multiplicativeExpr, _unionExpression);
                /* 706 SeqOp            */ __Matchers[706].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 709 AltOp            */ __Matchers[709].Set(__Matchers[433], __Matchers[707], __Matchers[708]);
                /* 710 AltOp            */ __Matchers[710].Set(_unionExpr, _exclusiveExpression);
                /* 711 SeqOp            */ __Matchers[711].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 713 AltOp            */ __Matchers[713].Set(__Matchers[471], __Matchers[712]);
                /* 714 AltOp            */ __Matchers[714].Set(_exclusiveExpr, _intersectionExpression);
                /* 715 SeqOp            */ __Matchers[715].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 717 AltOp            */ __Matchers[717].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 718 SeqOp            */ __Matchers[718].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 720 AltOp            */ __Matchers[720].Set(_negationOrComplementExpr, _prefixExpression);
                /* 721 SeqOp            */ __Matchers[721].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 722 AltOp            */ __Matchers[722].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 723 NotOp            */ __Matchers[723].Set(__Matchers_723_DFA);
                /* 724 SeqOp            */ __Matchers[724].Set(__Matchers[700], __Matchers[723]);
                /* 725 NotOp            */ __Matchers[725].Set(__Matchers_725_DFA);
                /* 726 SeqOp            */ __Matchers[726].Set(__Matchers[434], __Matchers[725]);
                /* 727 AltOp            */ __Matchers[727].Set(_prefixExpr, _postfixExpression);
                /* 728 SeqOp            */ __Matchers[728].Set(_incrementOperator, _prefixExpression);
                /* 729 AltOp            */ __Matchers[729].Set(_postfixExpr, _primary);
                /* 730 SeqOp            */ __Matchers[730].Set(_postfixExpression, _incrementOperator);
                /* 733 AltOp            */ __Matchers[733].Set(__Matchers[731], __Matchers[732]);
                /* 734 AltOp            */ __Matchers[734].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 735 SeqOp            */ __Matchers[735].Set(_primary, _memberSelectionOperator, _baseReference);
                /* 738 AltOp            */ __Matchers[738].Set(__Matchers[375], __Matchers[736], __Matchers[737]);
                /* 739 SeqOp            */ __Matchers[739].Set(_primary, __Matchers[423], _index, __Matchers[425]);
                /* 740 AltOp            */ __Matchers[740].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 741 SeqOp            */ __Matchers[741].Set(_indexExpression, __Matchers[414]);
                /* 742 SeqOp            */ __Matchers[742].Set(__Matchers[414], _indexExpression);
                /* 743 SeqOp            */ __Matchers[743].Set(_indexExpression, __Matchers[696], _indexExpression);
                /* 744 SeqOp            */ __Matchers[744].Set(_indexExpression, __Matchers[384], _indexExpression);
                /* 745 SeqOp            */ __Matchers[745].Set(_primary, _arguments);
                /* 746 AltOp            */ __Matchers[746].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 747 AltOp            */ __Matchers[747].Set(_literalNatural, _literalFloat, _literalChar);
                /* 748 AltOp            */ __Matchers[748].Set(_stringLiteral, _stringInterpolation);
                /* 749 StarOp           */ __Matchers[749].Set(_interpolationPart);
                /* 750 SeqOp            */ __Matchers[750].Set(_stringStart, _expression, __Matchers[749], _stringEnd);
                /* 751 SeqOp            */ __Matchers[751].Set(_stringMid, _expression);
                /* 752 AltOp            */ __Matchers[752].Set(_literalString, _verbatimString);
                /* 753 SeqOp            */ __Matchers[753].Set(__Matchers[530], __Matchers[531], __Matchers[517], _block);
                /* 754 SeqOp            */ __Matchers[754].Set(__Matchers[437], _expression, __Matchers[438]);
                /* 755 OptionalOp       */ __Matchers[755].Set(_typeArgumentList);
                /* 756 SeqOp            */ __Matchers[756].Set(__Matchers[501], __Matchers[755], __Matchers[502]);
                /* 757 SeqOp            */ __Matchers[757].Set(__Matchers[404], _variancedType);
                /* 758 StarOp           */ __Matchers[758].Set(__Matchers[757]);
                /* 759 SeqOp            */ __Matchers[759].Set(_variancedType, __Matchers[758]);
                /* 760 SeqOp            */ __Matchers[760].Set(__Matchers[507], _type);
                /* 761 SeqOp            */ __Matchers[761].Set(__Matchers[404], _defaultedType);
                /* 762 StarOp           */ __Matchers[762].Set(__Matchers[761]);
                /* 763 SeqOp            */ __Matchers[763].Set(_defaultedType, __Matchers[762]);
                /* 764 AltOp            */ __Matchers[764].Set(_defaultedTypeCore, _variadicType);
                /* 765 SeqOp            */ __Matchers[765].Set(_type, __Matchers[412]);
                /* 766 AltOp            */ __Matchers[766].Set(_variadicUnionType, _type);
                /* 767 SeqOp            */ __Matchers[767].Set(_unionType, _variadicOperator);
                /* 768 SeqOp            */ __Matchers[768].Set(__Matchers[433], _unionType);
                /* 769 AltOp            */ __Matchers[769].Set(_entryType, _unionType);
                /* 770 SeqOp            */ __Matchers[770].Set(_unionType, __Matchers[421], _unionType);
                /* 771 AltOp            */ __Matchers[771].Set(_unionTypeCore, _intersectionType);
                /* 772 SeqOp            */ __Matchers[772].Set(_unionType, __Matchers[471], _intersectionType);
                /* 773 AltOp            */ __Matchers[773].Set(_intersectionTypeCore, _primaryType);
                /* 774 SeqOp            */ __Matchers[774].Set(_intersectionType, __Matchers[719], _primaryType);
                /* 775 AltOp            */ __Matchers[775].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 777 SeqOp            */ __Matchers[777].Set(_primaryType, __Matchers[776]);
                /* 778 OptionalOp       */ __Matchers[778].Set(_literalNatural);
                /* 779 SeqOp            */ __Matchers[779].Set(_primaryType, __Matchers[423], __Matchers[778], __Matchers[425]);
                /* 780 OptionalOp       */ __Matchers[780].Set(_typeTypeArguments);
                /* 781 SeqOp            */ __Matchers[781].Set(_primaryType, __Matchers[437], __Matchers[780], __Matchers[438]);
                /* 782 AltOp            */ __Matchers[782].Set(_spreadType, _defaultedTypeList);
                /* 783 SeqOp            */ __Matchers[783].Set(__Matchers[423], __Matchers[780], __Matchers[425]);
                /* 784 OptionalOp       */ __Matchers[784].Set(_variadicType);
                /* 785 SeqOp            */ __Matchers[785].Set(__Matchers[392], __Matchers[784], __Matchers[394]);
                /* 786 SeqOp            */ __Matchers[786].Set(__Matchers[501], _type, __Matchers[502]);
                /* 787 SeqOp            */ __Matchers[787].Set(__Matchers[399], __Matchers[375], _typePath);
                /* 788 OptionalOp       */ __Matchers[788].Set(_stringLiteral);
                /* 789 StarOp           */ __Matchers[789].Set(_annotation);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[788], __Matchers[789]);
                /* 791 SeqOp            */ __Matchers[791].Set(_memberName, __Matchers[453]);
                /* 792 OptionalOp       */ __Matchers[792].Set(_conditionList);
                /* 793 SeqOp            */ __Matchers[793].Set(__Matchers[437], __Matchers[792], __Matchers[438]);
                /* 794 SeqOp            */ __Matchers[794].Set(__Matchers[404], _condition);
                /* 795 StarOp           */ __Matchers[795].Set(__Matchers[794]);
                /* 796 SeqOp            */ __Matchers[796].Set(_condition, __Matchers[795]);
                /* 797 AltOp            */ __Matchers[797].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 798 OptionalOp       */ __Matchers[798].Set(__Matchers[665]);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[798], __Matchers[689], _letOrExpression);
                /* 800 SeqOp            */ __Matchers[800].Set(__Matchers[798], __Matchers[691], _letOrExpression);
                /* 801 AltOp            */ __Matchers[801].Set(_letVariable, _operatorExpression);
                /* 802 SeqOp            */ __Matchers[802].Set(__Matchers[798], __Matchers[686], _type, _isConditionVariable);
                /* 803 SeqOp            */ __Matchers[803].Set(_memberName, __Matchers[485]);
                /* 804 SeqOp            */ __Matchers[804].Set(__Matchers[464], _type, _typeName);
                /* 805 AltOp            */ __Matchers[805].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 806 StarOp           */ __Matchers[806].Set(_elseIf);
                /* 807 OptionalOp       */ __Matchers[807].Set(_elseBlock);
                /* 808 SeqOp            */ __Matchers[808].Set(__Matchers[622], _conditions, _block, __Matchers[806], __Matchers[807]);
                /* 809 SeqOp            */ __Matchers[809].Set(__Matchers[618], __Matchers[622], _conditions, _block);
                /* 810 SeqOp            */ __Matchers[810].Set(__Matchers[618], _block);
                /* 811 PlusOp           */ __Matchers[811].Set(_caseBlock);
                /* 812 SeqOp            */ __Matchers[812].Set(_switchHeader, __Matchers[811], __Matchers[807]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[813], __Matchers[437], _switched, __Matchers[438]);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[619], __Matchers[620], __Matchers[437], _caseItem, __Matchers[438], _block);
                /* 816 AltOp            */ __Matchers[816].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 817 OptionalOp       */ __Matchers[817].Set(__Matchers[686]);
                /* 818 SeqOp            */ __Matchers[818].Set(__Matchers[817], _type);
                /* 819 SeqOp            */ __Matchers[819].Set(__Matchers[464], _type);
                /* 820 SeqOp            */ __Matchers[820].Set(_valueCaseSeparator, _valueCase);
                /* 821 StarOp           */ __Matchers[821].Set(__Matchers[820]);
                /* 822 SeqOp            */ __Matchers[822].Set(_valueCase, __Matchers[821]);
                /* 823 AltOp            */ __Matchers[823].Set(__Matchers[404], __Matchers[471]);
                /* 824 AltOp            */ __Matchers[824].Set(_intersectionType, _intersectionExpression);
                /* 825 SeqOp            */ __Matchers[825].Set(__Matchers[635], __Matchers[437], __Matchers[636], __Matchers[438], _block, __Matchers[807]);
                /* 826 OptionalOp       */ __Matchers[826].Set(_containment);
                /* 827 SeqOp            */ __Matchers[827].Set(_forVariable, __Matchers[826]);
                /* 828 AltOp            */ __Matchers[828].Set(_tupleOrEntryPattern, _variable);
                /* 829 SeqOp            */ __Matchers[829].Set(_containmentOperator, _operatorExpression);
                /* 830 AltOp            */ __Matchers[830].Set(__Matchers[510], __Matchers[384]);
                /* 832 SeqOp            */ __Matchers[832].Set(__Matchers[831], _conditions, _block);
                /* 833 StarOp           */ __Matchers[833].Set(_catchBlock);
                /* 834 OptionalOp       */ __Matchers[834].Set(_finallyBlock);
                /* 835 SeqOp            */ __Matchers[835].Set(_tryBlock, __Matchers[833], __Matchers[834]);
                /* 837 OptionalOp       */ __Matchers[837].Set(_resources);
                /* 838 SeqOp            */ __Matchers[838].Set(__Matchers[836], __Matchers[837], _block);
                /* 840 SeqOp            */ __Matchers[840].Set(__Matchers[839], _catchVariable, _block);
                /* 841 OptionalOp       */ __Matchers[841].Set(_variable);
                /* 842 SeqOp            */ __Matchers[842].Set(__Matchers[437], __Matchers[841], __Matchers[438]);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[843], _block);
                /* 845 OptionalOp       */ __Matchers[845].Set(_resourceList);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[437], __Matchers[845], __Matchers[438]);
                /* 847 SeqOp            */ __Matchers[847].Set(__Matchers[404], _resource);
                /* 848 StarOp           */ __Matchers[848].Set(__Matchers[847]);
                /* 849 SeqOp            */ __Matchers[849].Set(_resource, __Matchers[848]);
                /* 850 AltOp            */ __Matchers[850].Set(_specifiedVariable, _operatorExpression);
                /* 851 SeqOp            */ __Matchers[851].Set(_variable, _valueSpecifier);
                /* 852 OptionalOp       */ __Matchers[852].Set(_variableType);
                /* 853 StarOp           */ __Matchers[853].Set(_parameters);
                /* 854 SeqOp            */ __Matchers[854].Set(__Matchers[852], _memberName, __Matchers[853]);
                /* 855 AltOp            */ __Matchers[855].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 856 SeqOp            */ __Matchers[856].Set(__Matchers[716], _modelExpression);
                /* 858 SeqOp            */ __Matchers[858].Set(__Matchers[857], _metaExpression, __Matchers[857]);
                /* 859 AltOp            */ __Matchers[859].Set(_declarationReference, _modelExpression);
                /* 860 AltOp            */ __Matchers[860].Set(_memberModelExpression, _typeModelExpression);
                /* 861 AltOp            */ __Matchers[861].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 862 SeqOp            */ __Matchers[862].Set(__Matchers[399], __Matchers[375], _memberReference);
                /* 863 SeqOp            */ __Matchers[863].Set(_primaryType, __Matchers[375], _memberReference);
                /* 864 AltOp            */ __Matchers[864].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 865 OptionalOp       */ __Matchers[865].Set(_packagePath);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[380], __Matchers[865]);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[399], __Matchers[865]);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[544], _referencePath);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[550], _referencePath);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[526], _referencePath);
                /* 871 SeqOp            */ __Matchers[871].Set(__Matchers[514], _referencePath);
                /* 872 SeqOp            */ __Matchers[872].Set(__Matchers[522], _referencePath);
                /* 873 SeqOp            */ __Matchers[873].Set(_valueLiteralIntro, _referencePath);
                /* 874 AltOp            */ __Matchers[874].Set(__Matchers[498], __Matchers[530]);
                /* 875 SeqOp            */ __Matchers[875].Set(__Matchers[494], _referencePath);
                /* 876 SeqOp            */ __Matchers[876].Set(__Matchers[399], __Matchers[375]);
                /* 877 SeqOp            */ __Matchers[877].Set(__Matchers[476], _referencePathElementList);
                /* 878 SeqOp            */ __Matchers[878].Set(__Matchers[375], _referencePathElement);
                /* 879 StarOp           */ __Matchers[879].Set(__Matchers[878]);
                /* 880 SeqOp            */ __Matchers[880].Set(_referencePathElement, __Matchers[879]);

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
                __Matchers_723_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_723_DFA.States[0].Set(
                    new DfaTrans(__Matchers_723_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_723_DFA.States[1].Set(
                );
                __Matchers_725_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_725_DFA.States[0].Set(
                    new DfaTrans(__Matchers_725_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_725_DFA.States[1].Set(
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
            private PlainRule _caseExpressions;
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
            private PlainRule _variadicUnionType;
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
            private Dfa __Matchers_723_DFA = new Dfa("__Matchers_723_DFA");
            private Dfa __Matchers_725_DFA = new Dfa("__Matchers_725_DFA");
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
        public interface ICCaseExpressions : IRNode {}
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
        public interface ICVariadicUnionType : ICVariadicType {}
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

        public partial class CVariadicUnionType : RSequence, ICVariadicUnionType
        {
            // sequence
            public CVariadicUnionType(params RNode[] children) : base(children) {}

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

            protected virtual void Visit(CVariadicUnionType element)
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
