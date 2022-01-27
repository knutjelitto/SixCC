// <generated from="D:\\Six\\Six.Ceylon\\Ceylon.six" at="27.01.2022 07:11:22" />

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
                : base(new Matcher[884])
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
                /*  19 PlainRuleOp      */ __Matchers[19] = _packageDescriptor = new PlainRule(this, 19, "package-descriptor") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _importModule = new PlainRule(this, 20, "import-module") { Builder = nodes => nodes[0] };
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
                /* 129 PlainRuleOp      */ __Matchers[129] = _structuralArguments = new PlainRule(this, 129, "structural-arguments") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _positionalArguments = new PlainRule(this, 130, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _namedOrAnonymous = new PlainRule(this, 131, "named-or-anonymous") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _anonymousArgument = new PlainRule(this, 132, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _namedArgument = new PlainRule(this, 133, "named-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _namedSpecifiedArgument = new PlainRule(this, 134, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _sequencedArguments = new PlainRule(this, 135, "sequenced-arguments") { Builder = nodes => nodes[0] };
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
                /* 241 PlainRuleOp      */ __Matchers[241] = _qualifiedReference = new PlainRule(this, 241, "qualified-reference") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _memberSelectionOperator = new PlainRule(this, 242, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 243 PlainRuleOp      */ __Matchers[243] = _indexedExpr = new PlainRule(this, 243, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _index = new PlainRule(this, 244, "index") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _upperSpanned = new PlainRule(this, 245, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _lowerSpanned = new PlainRule(this, 246, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _spanned = new PlainRule(this, 247, "spanned") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _measured = new PlainRule(this, 248, "measured") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _indexExpression = new PlainRule(this, 249, "index-expression") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _callExpr = new PlainRule(this, 250, "call-expr") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _baseExpression = new PlainRule(this, 251, "base-expression") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _nonstringLiteral = new PlainRule(this, 252, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _stringExpression = new PlainRule(this, 253, "string-expression") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _stringInterpolation = new PlainRule(this, 254, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _interpolationPart = new PlainRule(this, 255, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _stringLiteral = new PlainRule(this, 256, "string-literal") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _objectExpr = new PlainRule(this, 257, "object-expr") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _groupedExpr = new PlainRule(this, 258, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _typeArguments = new PlainRule(this, 259, "type-arguments") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _typeArgumentList = new PlainRule(this, 260, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _variancedType = new PlainRule(this, 261, "varianced-type") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _defaultedTypeList = new PlainRule(this, 262, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _defaultedType = new PlainRule(this, 263, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _defaultedTypeCore = new PlainRule(this, 264, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _variadicType = new PlainRule(this, 265, "variadic-type") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _variadicUnionType = new PlainRule(this, 266, "variadic-union-type") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _variadicOperator = new PlainRule(this, 267, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /* 268 PlainRuleOp      */ __Matchers[268] = _spreadType = new PlainRule(this, 268, "spread-type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _type = new PlainRule(this, 269, "type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _entryType = new PlainRule(this, 270, "entry-type") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _unionType = new PlainRule(this, 271, "union-type") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _unionTypeCore = new PlainRule(this, 272, "union-type-core") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _intersectionType = new PlainRule(this, 273, "intersection-type") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _intersectionTypeCore = new PlainRule(this, 274, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _primaryType = new PlainRule(this, 275, "primary-type") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _nullableType = new PlainRule(this, 276, "nullable-type") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _arrayType = new PlainRule(this, 277, "array-type") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _functionType = new PlainRule(this, 278, "function-type") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _typeTypeArguments = new PlainRule(this, 279, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _tupleType = new PlainRule(this, 280, "tuple-type") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _iterableType = new PlainRule(this, 281, "iterable-type") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _groupedType = new PlainRule(this, 282, "grouped-type") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _packageQualifiedType = new PlainRule(this, 283, "package-qualified-type") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _annotations = new PlainRule(this, 284, "annotations") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _annotation = new PlainRule(this, 285, "annotation") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _conditions = new PlainRule(this, 286, "conditions") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _conditionList = new PlainRule(this, 287, "condition-list") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _condition = new PlainRule(this, 288, "condition") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _existsCondition = new PlainRule(this, 289, "exists-condition") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _nonemptyCondition = new PlainRule(this, 290, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _letOrExpression = new PlainRule(this, 291, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _isCondition = new PlainRule(this, 292, "is-condition") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _isConditionVariable = new PlainRule(this, 293, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _satisfiesCondition = new PlainRule(this, 294, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _booleanCondition = new PlainRule(this, 295, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _controlStatement = new PlainRule(this, 296, "control-statement") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _ifElseStatement = new PlainRule(this, 297, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _ifBlock = new PlainRule(this, 298, "if-block") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _elseBlock = new PlainRule(this, 299, "else-block") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _elseBlockNext = new PlainRule(this, 300, "else-block-next") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _switchStatement = new PlainRule(this, 301, "switch-statement") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _switchHeader = new PlainRule(this, 302, "switch-header") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _switched = new PlainRule(this, 303, "switched") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _caseBlock = new PlainRule(this, 304, "case-block") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _caseItem = new PlainRule(this, 305, "case-item") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _isCaseCondition = new PlainRule(this, 306, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _satisfiesCaseCondition = new PlainRule(this, 307, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _matchCaseCondition = new PlainRule(this, 308, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _valueCaseList = new PlainRule(this, 309, "value-case-list") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _valueCaseSeparator = new PlainRule(this, 310, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 311 PlainRuleOp      */ __Matchers[311] = _valueCase = new PlainRule(this, 311, "value-case") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _forElseStatement = new PlainRule(this, 312, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _forBlock = new PlainRule(this, 313, "for-block") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _failBlock = new PlainRule(this, 314, "fail-block") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _forIterator = new PlainRule(this, 315, "for-iterator") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _forVariable = new PlainRule(this, 316, "for-variable") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _containment = new PlainRule(this, 317, "containment") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _containmentOperator = new PlainRule(this, 318, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 319 PlainRuleOp      */ __Matchers[319] = _whileStatement = new PlainRule(this, 319, "while-statement") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _tryStatement = new PlainRule(this, 320, "try-statement") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _tryBlock = new PlainRule(this, 321, "try-block") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _catchBlock = new PlainRule(this, 322, "catch-block") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _catchVariable = new PlainRule(this, 323, "catch-variable") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _finallyBlock = new PlainRule(this, 324, "finally-block") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _resources = new PlainRule(this, 325, "resources") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _resourceList = new PlainRule(this, 326, "resource-list") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _resource = new PlainRule(this, 327, "resource") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _specifiedOrExpression = new PlainRule(this, 328, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _specifiedVariable = new PlainRule(this, 329, "specified-variable") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _variable = new PlainRule(this, 330, "variable") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _variableType = new PlainRule(this, 331, "variable-type") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _modelReference = new PlainRule(this, 332, "model-reference") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _metaLiteral = new PlainRule(this, 333, "meta-literal") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _metaExpression = new PlainRule(this, 334, "meta-expression") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _modelExpression = new PlainRule(this, 335, "model-expression") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _memberModelExpression = new PlainRule(this, 336, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _packageQualifiedMemberReference = new PlainRule(this, 337, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _typeQualifiedMemberReference = new PlainRule(this, 338, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _typeModelExpression = new PlainRule(this, 339, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _declarationReference = new PlainRule(this, 340, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _moduleLiteral = new PlainRule(this, 341, "module-literal") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _packageLiteral = new PlainRule(this, 342, "package-literal") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _classLiteral = new PlainRule(this, 343, "class-literal") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _interfaceLiteral = new PlainRule(this, 344, "interface-literal") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _aliasLiteral = new PlainRule(this, 345, "alias-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _typeParameterLiteral = new PlainRule(this, 346, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 347 PlainRuleOp      */ __Matchers[347] = _newLiteral = new PlainRule(this, 347, "new-literal") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _valueLiteral = new PlainRule(this, 348, "value-literal") { Builder = nodes => nodes[0] };
                /* 349 PlainRuleOp      */ __Matchers[349] = _valueLiteralIntro = new PlainRule(this, 349, "value-literal-intro") { Creator = node => new CValueLiteralIntro(node) };
                /* 350 PlainRuleOp      */ __Matchers[350] = _functionLiteral = new PlainRule(this, 350, "function-literal") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _packageQualifier = new PlainRule(this, 351, "package-qualifier") { Builder = nodes => nodes[0] };
                /* 352 PlainRuleOp      */ __Matchers[352] = _referencePath = new PlainRule(this, 352, "reference-path") { Builder = nodes => nodes[0] };
                /* 353 PlainRuleOp      */ __Matchers[353] = _referencePathElementList = new PlainRule(this, 353, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 354 PlainRuleOp      */ __Matchers[354] = _referencePathElement = new PlainRule(this, 354, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 355 PlainRuleOp      */ __Matchers[355] = _kwVoid = new PlainRule(this, 355, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 356 PlainRuleOp      */ __Matchers[356] = _kwFunction = new PlainRule(this, 356, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 357 PlainRuleOp      */ __Matchers[357] = _kwValue = new PlainRule(this, 357, "kw-value") { Creator = node => new CKwValue(node) };
                /* 358 DfaRuleOp        */ __Matchers[358] = _literalFloat = new DfaRule(this, 358, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 359 DfaRuleOp        */ __Matchers[359] = _literalNatural = new DfaRule(this, 359, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 360 DfaRuleOp        */ __Matchers[360] = _literalChar = new DfaRule(this, 360, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _stringStart = new DfaRule(this, 361, "string-start") { Creator = node => new CStringStart(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _stringMid = new DfaRule(this, 362, "string-mid") { Creator = node => new CStringMid(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _stringEnd = new DfaRule(this, 363, "string-end") { Creator = node => new CStringEnd(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _literalString = new DfaRule(this, 364, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _verbatimString = new DfaRule(this, 365, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 366 DfaRuleOp        */ __Matchers[366] = _lowerIdentifier = new DfaRule(this, 366, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 367 DfaRuleOp        */ __Matchers[367] = _upperIdentifier = new DfaRule(this, 367, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 368 DfaRuleOp        */ __Matchers[368] = _identifier = new DfaRule(this, 368, "identifier") { Creator = node => new CIdentifier(node) };
                /* 369 EofOp            */ __Matchers[369] = new Eof(this, 369, "<eof>") { Creator = node => new REof(node) };
                /* 370 SeqOp            */ __Matchers[370] = new Seq(this, 370, "_370:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 371 AltOp            */ __Matchers[371] = new Alt(this, 371, "alt(>module-descriptor|>package-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 372 SeqOp            */ __Matchers[372] = new Seq(this, 372, "_372:(>imports,>namespace,>declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 373 StringOp         */ __Matchers[373] = new Keyword(this, 373, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 374 StringOp         */ __Matchers[374] = new String(this, 374, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 375 SeqOp            */ __Matchers[375] = new Seq(this, 375, "_375:(>annotations,'namespace',>namespace-path,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 376 StringOp         */ __Matchers[376] = new String(this, 376, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 377 SeqOp            */ __Matchers[377] = new Seq(this, 377, "_377:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /* 378 StarOp           */ __Matchers[378] = new Star(this, 378, "*(_377:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Seq(this, 379, "_379:(>identifier,*(_377:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /* 380 StarOp           */ __Matchers[380] = new Star(this, 380, "*(>import-declaration)") { Builder = nodes => new CImports(nodes) };
                /* 381 StringOp         */ __Matchers[381] = new Keyword(this, 381, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 382 OptionalOp       */ __Matchers[382] = new Optional(this, 382, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 383 OptionalOp       */ __Matchers[383] = new Optional(this, 383, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 384 SeqOp            */ __Matchers[384] = new Seq(this, 384, "_384:(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 385 StringOp         */ __Matchers[385] = new String(this, 385, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 386 OptionalOp       */ __Matchers[386] = new Optional(this, 386, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 387 SeqOp            */ __Matchers[387] = new Seq(this, 387, "_387:(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 388 AltOp            */ __Matchers[388] = new Alt(this, 388, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 389 OptionalOp       */ __Matchers[389] = new Optional(this, 389, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 390 SeqOp            */ __Matchers[390] = new Seq(this, 390, "_390:(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 391 SeqOp            */ __Matchers[391] = new Seq(this, 391, "_391:(':',>literal-string)") { Builder = nodes => new CArtifact(nodes) };
                /* 392 SeqOp            */ __Matchers[392] = new Seq(this, 392, "_392:(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 393 StringOp         */ __Matchers[393] = new String(this, 393, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 394 StarOp           */ __Matchers[394] = new Star(this, 394, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 395 StringOp         */ __Matchers[395] = new String(this, 395, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 396 SeqOp            */ __Matchers[396] = new Seq(this, 396, "_396:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 397 AltOp            */ __Matchers[397] = new Alt(this, 397, "alt(>inferred-attribute-declaration|>import-module)") { Builder = nodes => nodes[0] };
                /* 398 StringOp         */ __Matchers[398] = new Keyword(this, 398, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 399 SeqOp            */ __Matchers[399] = new Seq(this, 399, "_399:(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 400 StringOp         */ __Matchers[400] = new Keyword(this, 400, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_401:(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CImportModule(nodes) };
                /* 402 SeqOp            */ __Matchers[402] = new Seq(this, 402, "_402:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 403 OptionalOp       */ __Matchers[403] = new Optional(this, 403, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 404 SeqOp            */ __Matchers[404] = new Seq(this, 404, "_404:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 405 StringOp         */ __Matchers[405] = new String(this, 405, "','", ",") { Creator = node => new RLiteral(node) };
                /* 406 SeqOp            */ __Matchers[406] = new Seq(this, 406, "_406:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 407 StarOp           */ __Matchers[407] = new Star(this, 407, "*(_406:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 408 SeqOp            */ __Matchers[408] = new Seq(this, 408, "_408:(>import-element,*(_406:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 409 AltOp            */ __Matchers[409] = new Alt(this, 409, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 410 OptionalOp       */ __Matchers[410] = new Optional(this, 410, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 411 OptionalOp       */ __Matchers[411] = new Optional(this, 411, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 412 SeqOp            */ __Matchers[412] = new Seq(this, 412, "_412:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 413 StringOp         */ __Matchers[413] = new String(this, 413, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 414 SeqOp            */ __Matchers[414] = new Seq(this, 414, "_414:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 415 StringOp         */ __Matchers[415] = new String(this, 415, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 416 SeqOp            */ __Matchers[416] = new Seq(this, 416, "_416:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 417 StarOp           */ __Matchers[417] = new Star(this, 417, "*(_416:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 418 SeqOp            */ __Matchers[418] = new Seq(this, 418, "_418:(>package-name,*(_416:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 419 AltOp            */ __Matchers[419] = new Alt(this, 419, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 420 AltOp            */ __Matchers[420] = new Alt(this, 420, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 421 AltOp            */ __Matchers[421] = new Alt(this, 421, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 422 StringOp         */ __Matchers[422] = new String(this, 422, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 423 SeqOp            */ __Matchers[423] = new Seq(this, 423, "_423:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 424 StringOp         */ __Matchers[424] = new String(this, 424, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 425 OptionalOp       */ __Matchers[425] = new Optional(this, 425, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 426 StringOp         */ __Matchers[426] = new String(this, 426, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 427 SeqOp            */ __Matchers[427] = new Seq(this, 427, "_427:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 428 SeqOp            */ __Matchers[428] = new Seq(this, 428, "_428:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 429 StarOp           */ __Matchers[429] = new Star(this, 429, "*(_428:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 430 SeqOp            */ __Matchers[430] = new Seq(this, 430, "_430:(>variadic-pattern,*(_428:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 431 AltOp            */ __Matchers[431] = new Alt(this, 431, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 432 OptionalOp       */ __Matchers[432] = new Optional(this, 432, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 433 SeqOp            */ __Matchers[433] = new Seq(this, 433, "_433:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 434 StringOp         */ __Matchers[434] = new Keyword(this, 434, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 435 StringOp         */ __Matchers[435] = new String(this, 435, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 436 StringOp         */ __Matchers[436] = new String(this, 436, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 437 SeqOp            */ __Matchers[437] = new Seq(this, 437, "_437:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 438 SeqOp            */ __Matchers[438] = new Seq(this, 438, "_438:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 439 StarOp           */ __Matchers[439] = new Star(this, 439, "*(_438:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 440 SeqOp            */ __Matchers[440] = new Seq(this, 440, "_440:(>let-variable,*(_438:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 441 SeqOp            */ __Matchers[441] = new Seq(this, 441, "_441:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 442 StringOp         */ __Matchers[442] = new Keyword(this, 442, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_443:('extends',>class-instatiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 444 OptionalOp       */ __Matchers[444] = new Optional(this, 444, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 445 StringOp         */ __Matchers[445] = new Keyword(this, 445, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 446 SeqOp            */ __Matchers[446] = new Seq(this, 446, "_446:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_447:('{',>imports,>statements,'}')") { Builder = nodes => new CBlock(nodes) };
                /* 448 SeqOp            */ __Matchers[448] = new Seq(this, 448, "_448:('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 449 StringOp         */ __Matchers[449] = new String(this, 449, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_450:('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 451 OptionalOp       */ __Matchers[451] = new Optional(this, 451, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 452 SeqOp            */ __Matchers[452] = new Seq(this, 452, "_452:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 453 AltOp            */ __Matchers[453] = new Alt(this, 453, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 454 SeqOp            */ __Matchers[454] = new Seq(this, 454, "_454:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 455 StringOp         */ __Matchers[455] = new Keyword(this, 455, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 457 AltOp            */ __Matchers[457] = new Alt(this, 457, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_458:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 459 SeqOp            */ __Matchers[459] = new Seq(this, 459, "_459:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 460 StarOp           */ __Matchers[460] = new Star(this, 460, "*(_459:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_461:(>type-reference,*(_459:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 462 StringOp         */ __Matchers[462] = new Keyword(this, 462, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 463 SeqOp            */ __Matchers[463] = new Seq(this, 463, "_463:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 464 SeqOp            */ __Matchers[464] = new Seq(this, 464, "_464:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 465 StarOp           */ __Matchers[465] = new Star(this, 465, "*(_464:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 466 SeqOp            */ __Matchers[466] = new Seq(this, 466, "_466:(>union-type,*(_464:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 467 StringOp         */ __Matchers[467] = new Keyword(this, 467, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 468 SeqOp            */ __Matchers[468] = new Seq(this, 468, "_468:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 469 StringOp         */ __Matchers[469] = new String(this, 469, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 470 SeqOp            */ __Matchers[470] = new Seq(this, 470, "_470:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 471 StarOp           */ __Matchers[471] = new Star(this, 471, "*(_470:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_472:(>case-type,*(_470:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 473 AltOp            */ __Matchers[473] = new Alt(this, 473, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 474 OptionalOp       */ __Matchers[474] = new Optional(this, 474, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_475:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 476 OptionalOp       */ __Matchers[476] = new Optional(this, 476, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 477 SeqOp            */ __Matchers[477] = new Seq(this, 477, "_477:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 478 SeqOp            */ __Matchers[478] = new Seq(this, 478, "_478:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 479 StarOp           */ __Matchers[479] = new Star(this, 479, "*(_478:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_480:(>parameter-declaration-or-ref-pattern,*(_478:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 481 AltOp            */ __Matchers[481] = new Alt(this, 481, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 482 SeqOp            */ __Matchers[482] = new Seq(this, 482, "_482:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 483 OptionalOp       */ __Matchers[483] = new Optional(this, 483, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 484 SeqOp            */ __Matchers[484] = new Seq(this, 484, "_484:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 485 AltOp            */ __Matchers[485] = new Alt(this, 485, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 486 OptionalOp       */ __Matchers[486] = new Optional(this, 486, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 487 PlusOp           */ __Matchers[487] = new Plus(this, 487, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 488 OptionalOp       */ __Matchers[488] = new Optional(this, 488, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 489 SeqOp            */ __Matchers[489] = new Seq(this, 489, "_489:(>function-parameter-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CFunctionParameterDeclaration(nodes) };
                /* 490 AltOp            */ __Matchers[490] = new Alt(this, 490, "alt(>variadic-type|>kw-void|>kw-function)") { Builder = nodes => nodes[0] };
                /* 491 SeqOp            */ __Matchers[491] = new Seq(this, 491, "_491:(>value-parameter-type,>member-name,?(>value-specifier))") { Builder = nodes => new CValueParameterDeclaration(nodes) };
                /* 492 AltOp            */ __Matchers[492] = new Alt(this, 492, "alt(>variadic-type|>kw-value)") { Builder = nodes => nodes[0] };
                /* 493 StringOp         */ __Matchers[493] = new String(this, 493, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 494 StringOp         */ __Matchers[494] = new String(this, 494, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 495 SeqOp            */ __Matchers[495] = new Seq(this, 495, "_495:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 496 SeqOp            */ __Matchers[496] = new Seq(this, 496, "_496:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 497 StarOp           */ __Matchers[497] = new Star(this, 497, "*(_496:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 498 SeqOp            */ __Matchers[498] = new Seq(this, 498, "_498:(>type-parameter,*(_496:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 499 OptionalOp       */ __Matchers[499] = new Optional(this, 499, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 500 OptionalOp       */ __Matchers[500] = new Optional(this, 500, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 501 SeqOp            */ __Matchers[501] = new Seq(this, 501, "_501:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 502 StringOp         */ __Matchers[502] = new Keyword(this, 502, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 503 StringOp         */ __Matchers[503] = new Keyword(this, 503, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 504 AltOp            */ __Matchers[504] = new Alt(this, 504, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 505 SeqOp            */ __Matchers[505] = new Seq(this, 505, "_505:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 506 StringOp         */ __Matchers[506] = new Keyword(this, 506, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 507 OptionalOp       */ __Matchers[507] = new Optional(this, 507, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 508 OptionalOp       */ __Matchers[508] = new Optional(this, 508, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 509 OptionalOp       */ __Matchers[509] = new Optional(this, 509, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 510 SeqOp            */ __Matchers[510] = new Seq(this, 510, "_510:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 511 PlusOp           */ __Matchers[511] = new Plus(this, 511, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 512 StarOp           */ __Matchers[512] = new Star(this, 512, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /* 513 AltOp            */ __Matchers[513] = new Alt(this, 513, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 514 StringOp         */ __Matchers[514] = new Keyword(this, 514, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 515 OptionalOp       */ __Matchers[515] = new Optional(this, 515, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 516 OptionalOp       */ __Matchers[516] = new Optional(this, 516, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 517 SeqOp            */ __Matchers[517] = new Seq(this, 517, "_517:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 518 StringOp         */ __Matchers[518] = new Keyword(this, 518, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 519 OptionalOp       */ __Matchers[519] = new Optional(this, 519, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 520 SeqOp            */ __Matchers[520] = new Seq(this, 520, "_520:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 521 SeqOp            */ __Matchers[521] = new Seq(this, 521, "_521:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 522 StringOp         */ __Matchers[522] = new Keyword(this, 522, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 523 OptionalOp       */ __Matchers[523] = new Optional(this, 523, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 524 SeqOp            */ __Matchers[524] = new Seq(this, 524, "_524:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 525 StringOp         */ __Matchers[525] = new Keyword(this, 525, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 526 SeqOp            */ __Matchers[526] = new Seq(this, 526, "_526:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 527 AltOp            */ __Matchers[527] = new Alt(this, 527, "alt(>block|>required-function-specifier)") { Builder = nodes => nodes[0] };
                /* 528 SeqOp            */ __Matchers[528] = new Seq(this, 528, "_528:(>annotations,>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 529 StringOp         */ __Matchers[529] = new Keyword(this, 529, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_530:(>annotations,'void',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 531 StringOp         */ __Matchers[531] = new Keyword(this, 531, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_532:(>annotations,'function',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 533 SeqOp            */ __Matchers[533] = new Seq(this, 533, "_533:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 534 StringOp         */ __Matchers[534] = new Keyword(this, 534, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 535 SeqOp            */ __Matchers[535] = new Seq(this, 535, "_535:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 536 AltOp            */ __Matchers[536] = new Alt(this, 536, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 537 OptionalOp       */ __Matchers[537] = new Optional(this, 537, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_538:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 539 StringOp         */ __Matchers[539] = new Keyword(this, 539, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 540 OptionalOp       */ __Matchers[540] = new Optional(this, 540, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 541 SeqOp            */ __Matchers[541] = new Seq(this, 541, "_541:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 542 AltOp            */ __Matchers[542] = new Alt(this, 542, "alt(>block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 543 OptionalOp       */ __Matchers[543] = new Optional(this, 543, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 544 SeqOp            */ __Matchers[544] = new Seq(this, 544, "_544:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 545 StringOp         */ __Matchers[545] = new Keyword(this, 545, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 546 SeqOp            */ __Matchers[546] = new Seq(this, 546, "_546:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 547 AltOp            */ __Matchers[547] = new Alt(this, 547, "alt(>block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 548 OptionalOp       */ __Matchers[548] = new Optional(this, 548, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 549 SeqOp            */ __Matchers[549] = new Seq(this, 549, "_549:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 550 StarOp           */ __Matchers[550] = new Star(this, 550, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 551 AltOp            */ __Matchers[551] = new Alt(this, 551, "alt(>declaration-statement|>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 552 SeqOp            */ __Matchers[552] = new Seq(this, 552, "_552:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 553 AltOp            */ __Matchers[553] = new Alt(this, 553, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 554 SeqOp            */ __Matchers[554] = new Seq(this, 554, "_554:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 555 AltOp            */ __Matchers[555] = new Alt(this, 555, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement)") { Builder = nodes => nodes[0] };
                /* 556 StringOp         */ __Matchers[556] = new Keyword(this, 556, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 557 OptionalOp       */ __Matchers[557] = new Optional(this, 557, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 558 SeqOp            */ __Matchers[558] = new Seq(this, 558, "_558:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 559 StringOp         */ __Matchers[559] = new Keyword(this, 559, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 560 SeqOp            */ __Matchers[560] = new Seq(this, 560, "_560:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 561 StringOp         */ __Matchers[561] = new Keyword(this, 561, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 562 StringOp         */ __Matchers[562] = new Keyword(this, 562, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_563:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_564:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_565:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 566 AltOp            */ __Matchers[566] = new Alt(this, 566, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 567 AltOp            */ __Matchers[567] = new Alt(this, 567, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 568 AltOp            */ __Matchers[568] = new Alt(this, 568, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 569 SeqOp            */ __Matchers[569] = new Seq(this, 569, "_569:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 571 OptionalOp       */ __Matchers[571] = new Optional(this, 571, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 572 SeqOp            */ __Matchers[572] = new Seq(this, 572, "_572:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 573 SeqOp            */ __Matchers[573] = new Seq(this, 573, "_573:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 574 SeqOp            */ __Matchers[574] = new Seq(this, 574, "_574:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 575 StringOp         */ __Matchers[575] = new Keyword(this, 575, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 576 StringOp         */ __Matchers[576] = new Keyword(this, 576, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 577 AltOp            */ __Matchers[577] = new Alt(this, 577, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 578 OptionalOp       */ __Matchers[578] = new Optional(this, 578, "?(>sequenced-arguments)") { Builder = nodes => new ROptional<CSequencedArguments>(nodes) };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_579:('{',>statements,?(>sequenced-arguments),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_580:('[',?(>sequenced-arguments),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 581 AltOp            */ __Matchers[581] = new Alt(this, 581, "alt(>structural-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 582 StarOp           */ __Matchers[582] = new Star(this, 582, "*(>named-or-anonymous)") { Builder = nodes => new RStar<ICNamedOrAnonymous>(nodes) };
                /* 583 SeqOp            */ __Matchers[583] = new Seq(this, 583, "_583:('{',*(>named-or-anonymous),?(>sequenced-arguments),'}')") { Builder = nodes => new CStructuralArguments(nodes) };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_584:('(',?(>sequenced-arguments),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 585 AltOp            */ __Matchers[585] = new Alt(this, 585, "alt(>anonymous-argument|>named-argument)") { Builder = nodes => nodes[0] };
                /* 586 SeqOp            */ __Matchers[586] = new Seq(this, 586, "_586:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 587 AltOp            */ __Matchers[587] = new Alt(this, 587, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 589 SeqOp            */ __Matchers[589] = new Seq(this, 589, "_589:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 590 StarOp           */ __Matchers[590] = new Star(this, 590, "*(_589:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:(>sequenced-argument,*(_589:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArguments(nodes) };
                /* 592 AltOp            */ __Matchers[592] = new Alt(this, 592, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 593 AltOp            */ __Matchers[593] = new Alt(this, 593, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_594:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_595:(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 596 AltOp            */ __Matchers[596] = new Alt(this, 596, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_597:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_598:(>function-specifier,';')") { Builder = nodes => new CRequiredFunctionSpecifier(nodes) };
                /* 599 AltOp            */ __Matchers[599] = new Alt(this, 599, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_600:(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 601 SeqOp            */ __Matchers[601] = new Seq(this, 601, "_601:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 602 SeqOp            */ __Matchers[602] = new Seq(this, 602, "_602:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_603:(>member-name,+(>parameters),>required-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 604 SeqOp            */ __Matchers[604] = new Seq(this, 604, "_604:(>member-name,>required-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 605 AltOp            */ __Matchers[605] = new Alt(this, 605, "alt(>expression-argument|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 606 StringOp         */ __Matchers[606] = new String(this, 606, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 608 OptionalOp       */ __Matchers[608] = new Optional(this, 608, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 609 SeqOp            */ __Matchers[609] = new Seq(this, 609, "_609:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 610 SeqOp            */ __Matchers[610] = new Seq(this, 610, "_610:(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 611 PlusOp           */ __Matchers[611] = new Plus(this, 611, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 613 SeqOp            */ __Matchers[613] = new Seq(this, 613, "_613:(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 614 StringOp         */ __Matchers[614] = new Keyword(this, 614, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 615 OptionalOp       */ __Matchers[615] = new Optional(this, 615, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 616 StringOp         */ __Matchers[616] = new Keyword(this, 616, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new Keyword(this, 618, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 619 SeqOp            */ __Matchers[619] = new Seq(this, 619, "_619:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 620 SeqOp            */ __Matchers[620] = new Seq(this, 620, "_620:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 621 StringOp         */ __Matchers[621] = new Keyword(this, 621, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 622 SeqOp            */ __Matchers[622] = new Seq(this, 622, "_622:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 623 AltOp            */ __Matchers[623] = new Alt(this, 623, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 624 OptionalOp       */ __Matchers[624] = new Optional(this, 624, "?(>function-expression-type)") { Builder = nodes => new ROptional<ICFunctionExpressionType>(nodes) };
                /* 625 OptionalOp       */ __Matchers[625] = new Optional(this, 625, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 626 SeqOp            */ __Matchers[626] = new Seq(this, 626, "_626:(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpr(nodes) };
                /* 627 AltOp            */ __Matchers[627] = new Alt(this, 627, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 628 SeqOp            */ __Matchers[628] = new Seq(this, 628, "_628:(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 629 AltOp            */ __Matchers[629] = new Alt(this, 629, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 630 AltOp            */ __Matchers[630] = new Alt(this, 630, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 631 AltOp            */ __Matchers[631] = new Alt(this, 631, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 632 StringOp         */ __Matchers[632] = new Keyword(this, 632, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 633 OptionalOp       */ __Matchers[633] = new Optional(this, 633, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 634 SeqOp            */ __Matchers[634] = new Seq(this, 634, "_634:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 635 SeqOp            */ __Matchers[635] = new Seq(this, 635, "_635:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 636 AltOp            */ __Matchers[636] = new Alt(this, 636, "alt(>let-expr|>if-expr|>switch-expr|>function-expr|>operator-expression)") { Builder = nodes => nodes[0] };
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
                /* 697 StringOp         */ __Matchers[697] = new String(this, 697, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 698 StringOp         */ __Matchers[698] = new String(this, 698, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 699 AltOp            */ __Matchers[699] = new Alt(this, 699, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 700 AltOp            */ __Matchers[700] = new Alt(this, 700, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 701 SeqOp            */ __Matchers[701] = new Seq(this, 701, "_701:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 702 StringOp         */ __Matchers[702] = new String(this, 702, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 703 AltOp            */ __Matchers[703] = new Alt(this, 703, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 704 SeqOp            */ __Matchers[704] = new Seq(this, 704, "_704:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 705 StringOp         */ __Matchers[705] = new String(this, 705, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 706 StringOp         */ __Matchers[706] = new String(this, 706, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 707 AltOp            */ __Matchers[707] = new Alt(this, 707, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 708 AltOp            */ __Matchers[708] = new Alt(this, 708, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 709 SeqOp            */ __Matchers[709] = new Seq(this, 709, "_709:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 710 StringOp         */ __Matchers[710] = new String(this, 710, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 711 AltOp            */ __Matchers[711] = new Alt(this, 711, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 712 AltOp            */ __Matchers[712] = new Alt(this, 712, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 713 SeqOp            */ __Matchers[713] = new Seq(this, 713, "_713:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 714 StringOp         */ __Matchers[714] = new String(this, 714, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 715 AltOp            */ __Matchers[715] = new Alt(this, 715, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 716 SeqOp            */ __Matchers[716] = new Seq(this, 716, "_716:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 717 StringOp         */ __Matchers[717] = new String(this, 717, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 718 AltOp            */ __Matchers[718] = new Alt(this, 718, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 719 SeqOp            */ __Matchers[719] = new Seq(this, 719, "_719:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 720 AltOp            */ __Matchers[720] = new Alt(this, 720, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 721 NotOp            */ __Matchers[721] = new Not(this, 721, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 722 SeqOp            */ __Matchers[722] = new Seq(this, 722, "_722:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 723 NotOp            */ __Matchers[723] = new Not(this, 723, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 724 SeqOp            */ __Matchers[724] = new Seq(this, 724, "_724:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 725 AltOp            */ __Matchers[725] = new Alt(this, 725, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 726 SeqOp            */ __Matchers[726] = new Seq(this, 726, "_726:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 727 AltOp            */ __Matchers[727] = new Alt(this, 727, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 728 SeqOp            */ __Matchers[728] = new Seq(this, 728, "_728:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 729 StringOp         */ __Matchers[729] = new String(this, 729, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 730 StringOp         */ __Matchers[730] = new String(this, 730, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 731 AltOp            */ __Matchers[731] = new Alt(this, 731, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 732 AltOp            */ __Matchers[732] = new Alt(this, 732, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 733 SeqOp            */ __Matchers[733] = new Seq(this, 733, "_733:(>primary,>qualified-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 734 SeqOp            */ __Matchers[734] = new Seq(this, 734, "_734:(>member-selection-operator,>base-reference)") { Builder = nodes => new CQualifiedReference(nodes) };
                /* 735 StringOp         */ __Matchers[735] = new String(this, 735, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 736 StringOp         */ __Matchers[736] = new String(this, 736, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 737 AltOp            */ __Matchers[737] = new Alt(this, 737, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_738:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 739 AltOp            */ __Matchers[739] = new Alt(this, 739, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_740:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_741:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 742 SeqOp            */ __Matchers[742] = new Seq(this, 742, "_742:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 743 SeqOp            */ __Matchers[743] = new Seq(this, 743, "_743:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 744 SeqOp            */ __Matchers[744] = new Seq(this, 744, "_744:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 745 AltOp            */ __Matchers[745] = new Alt(this, 745, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 746 AltOp            */ __Matchers[746] = new Alt(this, 746, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 747 AltOp            */ __Matchers[747] = new Alt(this, 747, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 748 StarOp           */ __Matchers[748] = new Star(this, 748, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 749 SeqOp            */ __Matchers[749] = new Seq(this, 749, "_749:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_750:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 751 AltOp            */ __Matchers[751] = new Alt(this, 751, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 752 SeqOp            */ __Matchers[752] = new Seq(this, 752, "_752:('object',?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_753:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 754 OptionalOp       */ __Matchers[754] = new Optional(this, 754, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_755:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_756:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 757 StarOp           */ __Matchers[757] = new Star(this, 757, "*(_756:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 758 SeqOp            */ __Matchers[758] = new Seq(this, 758, "_758:(>varianced-type,*(_756:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_759:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 760 SeqOp            */ __Matchers[760] = new Seq(this, 760, "_760:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 761 StarOp           */ __Matchers[761] = new Star(this, 761, "*(_760:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 762 SeqOp            */ __Matchers[762] = new Seq(this, 762, "_762:(>defaulted-type,*(_760:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 763 AltOp            */ __Matchers[763] = new Alt(this, 763, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 764 SeqOp            */ __Matchers[764] = new Seq(this, 764, "_764:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 765 AltOp            */ __Matchers[765] = new Alt(this, 765, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 766 SeqOp            */ __Matchers[766] = new Seq(this, 766, "_766:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 767 AltOp            */ __Matchers[767] = new Alt(this, 767, "alt('*'|'+')") { Builder = nodes => nodes[0] };
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
                /* 806 OptionalOp       */ __Matchers[806] = new Optional(this, 806, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 807 SeqOp            */ __Matchers[807] = new Seq(this, 807, "_807:(>if-block,?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_808:('if',>conditions,>block)") { Builder = nodes => new CIfBlock(nodes) };
                /* 809 SeqOp            */ __Matchers[809] = new Seq(this, 809, "_809:('else',>else-block-next)") { Builder = nodes => new CElseBlock(nodes) };
                /* 810 AltOp            */ __Matchers[810] = new Alt(this, 810, "alt(>if-else-statement|>block)") { Builder = nodes => nodes[0] };
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
                /* 825 OptionalOp       */ __Matchers[825] = new Optional(this, 825, "?(>fail-block)") { Builder = nodes => new ROptional<CFailBlock>(nodes) };
                /* 826 SeqOp            */ __Matchers[826] = new Seq(this, 826, "_826:(>for-block,?(>fail-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 827 SeqOp            */ __Matchers[827] = new Seq(this, 827, "_827:('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 828 SeqOp            */ __Matchers[828] = new Seq(this, 828, "_828:('else',>block)") { Builder = nodes => new CFailBlock(nodes) };
                /* 829 OptionalOp       */ __Matchers[829] = new Optional(this, 829, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 830 SeqOp            */ __Matchers[830] = new Seq(this, 830, "_830:(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 831 AltOp            */ __Matchers[831] = new Alt(this, 831, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 832 SeqOp            */ __Matchers[832] = new Seq(this, 832, "_832:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 833 AltOp            */ __Matchers[833] = new Alt(this, 833, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 834 StringOp         */ __Matchers[834] = new Keyword(this, 834, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 835 SeqOp            */ __Matchers[835] = new Seq(this, 835, "_835:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 836 StarOp           */ __Matchers[836] = new Star(this, 836, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 837 OptionalOp       */ __Matchers[837] = new Optional(this, 837, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 838 SeqOp            */ __Matchers[838] = new Seq(this, 838, "_838:(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 839 StringOp         */ __Matchers[839] = new Keyword(this, 839, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 840 OptionalOp       */ __Matchers[840] = new Optional(this, 840, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_841:('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 842 StringOp         */ __Matchers[842] = new Keyword(this, 842, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 843 SeqOp            */ __Matchers[843] = new Seq(this, 843, "_843:('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 844 OptionalOp       */ __Matchers[844] = new Optional(this, 844, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 845 SeqOp            */ __Matchers[845] = new Seq(this, 845, "_845:('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 846 StringOp         */ __Matchers[846] = new Keyword(this, 846, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 847 SeqOp            */ __Matchers[847] = new Seq(this, 847, "_847:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 848 OptionalOp       */ __Matchers[848] = new Optional(this, 848, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 849 SeqOp            */ __Matchers[849] = new Seq(this, 849, "_849:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 850 SeqOp            */ __Matchers[850] = new Seq(this, 850, "_850:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 851 StarOp           */ __Matchers[851] = new Star(this, 851, "*(_850:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 852 SeqOp            */ __Matchers[852] = new Seq(this, 852, "_852:(>resource,*(_850:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 853 AltOp            */ __Matchers[853] = new Alt(this, 853, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 854 SeqOp            */ __Matchers[854] = new Seq(this, 854, "_854:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 855 OptionalOp       */ __Matchers[855] = new Optional(this, 855, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 856 StarOp           */ __Matchers[856] = new Star(this, 856, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 857 SeqOp            */ __Matchers[857] = new Seq(this, 857, "_857:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 858 AltOp            */ __Matchers[858] = new Alt(this, 858, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 859 SeqOp            */ __Matchers[859] = new Seq(this, 859, "_859:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 860 StringOp         */ __Matchers[860] = new String(this, 860, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 861 SeqOp            */ __Matchers[861] = new Seq(this, 861, "_861:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 862 AltOp            */ __Matchers[862] = new Alt(this, 862, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 863 AltOp            */ __Matchers[863] = new Alt(this, 863, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 864 AltOp            */ __Matchers[864] = new Alt(this, 864, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_865:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_866:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 867 AltOp            */ __Matchers[867] = new Alt(this, 867, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 868 OptionalOp       */ __Matchers[868] = new Optional(this, 868, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_869:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_870:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 871 SeqOp            */ __Matchers[871] = new Seq(this, 871, "_871:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_872:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 873 SeqOp            */ __Matchers[873] = new Seq(this, 873, "_873:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 874 SeqOp            */ __Matchers[874] = new Seq(this, 874, "_874:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_875:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 876 SeqOp            */ __Matchers[876] = new Seq(this, 876, "_876:(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 877 AltOp            */ __Matchers[877] = new Alt(this, 877, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 878 SeqOp            */ __Matchers[878] = new Seq(this, 878, "_878:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 879 SeqOp            */ __Matchers[879] = new Seq(this, 879, "_879:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 880 SeqOp            */ __Matchers[880] = new Seq(this, 880, "_880:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 881 SeqOp            */ __Matchers[881] = new Seq(this, 881, "_881:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 882 StarOp           */ __Matchers[882] = new Star(this, 882, "*(_881:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 883 SeqOp            */ __Matchers[883] = new Seq(this, 883, "_883:(>reference-path-element,*(_881:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[370]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[371]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[372]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[375]);
                /*   6 PlainRuleOp      */ _namespacePath.Set(__Matchers[379]);
                /*   7 PlainRuleOp      */ _imports.Set(__Matchers[380]);
                /*   8 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[384]);
                /*   9 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[387]);
                /*  10 PlainRuleOp      */ _repository.Set(_identifier);
                /*  11 PlainRuleOp      */ _module.Set(__Matchers[388]);
                /*  12 PlainRuleOp      */ _artifactAndClassifier.Set(__Matchers[390]);
                /*  13 PlainRuleOp      */ _artifact.Set(__Matchers[391]);
                /*  14 PlainRuleOp      */ _classifier.Set(__Matchers[392]);
                /*  15 PlainRuleOp      */ _version.Set(_literalString);
                /*  16 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  17 PlainRuleOp      */ _moduleBody.Set(__Matchers[396]);
                /*  18 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[397]);
                /*  19 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[399]);
                /*  20 PlainRuleOp      */ _importModule.Set(__Matchers[401]);
                /*  21 PlainRuleOp      */ _importDeclaration.Set(__Matchers[402]);
                /*  22 PlainRuleOp      */ _importElements.Set(__Matchers[404]);
                /*  23 PlainRuleOp      */ _importElementList.Set(__Matchers[408]);
                /*  24 PlainRuleOp      */ _importElement.Set(__Matchers[409]);
                /*  25 PlainRuleOp      */ _importNamed.Set(__Matchers[412]);
                /*  26 PlainRuleOp      */ _importName.Set(_identifier);
                /*  27 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[414]);
                /*  28 PlainRuleOp      */ _importWildcard.Set(__Matchers[415]);
                /*  29 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  30 PlainRuleOp      */ _packagePath.Set(__Matchers[418]);
                /*  31 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  32 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  33 PlainRuleOp      */ _pattern.Set(__Matchers[419]);
                /*  34 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[420]);
                /*  35 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[421]);
                /*  36 PlainRuleOp      */ _entryPattern.Set(__Matchers[423]);
                /*  37 PlainRuleOp      */ _tuplePattern.Set(__Matchers[427]);
                /*  38 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[430]);
                /*  39 PlainRuleOp      */ _variadicPattern.Set(__Matchers[431]);
                /*  40 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  41 PlainRuleOp      */ _variadicVariable.Set(__Matchers[433]);
                /*  42 PlainRuleOp      */ _letStatement.Set(__Matchers[437]);
                /*  43 PlainRuleOp      */ _letVariableList.Set(__Matchers[440]);
                /*  44 PlainRuleOp      */ _letVariable.Set(__Matchers[441]);
                /*  45 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[443]);
                /*  46 PlainRuleOp      */ _assertionStatement.Set(__Matchers[446]);
                /*  47 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  48 PlainRuleOp      */ _block.Set(__Matchers[447]);
                /*  49 PlainRuleOp      */ _extendedType.Set(__Matchers[448]);
                /*  50 PlainRuleOp      */ _classSpecifier.Set(__Matchers[450]);
                /*  51 PlainRuleOp      */ _classInstatiation.Set(__Matchers[452]);
                /*  52 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[453]);
                /*  53 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[454]);
                /*  54 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[456]);
                /*  55 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[457]);
                /*  56 PlainRuleOp      */ _memberPath.Set(__Matchers[458]);
                /*  57 PlainRuleOp      */ _typePath.Set(__Matchers[461]);
                /*  58 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[463]);
                /*  59 PlainRuleOp      */ _unionTypeList.Set(__Matchers[466]);
                /*  60 PlainRuleOp      */ _caseTypes.Set(__Matchers[468]);
                /*  61 PlainRuleOp      */ _caseTypeList.Set(__Matchers[472]);
                /*  62 PlainRuleOp      */ _caseType.Set(__Matchers[473]);
                /*  63 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[475]);
                /*  64 PlainRuleOp      */ _parameters.Set(__Matchers[477]);
                /*  65 PlainRuleOp      */ _parameterList.Set(__Matchers[480]);
                /*  66 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[481]);
                /*  67 PlainRuleOp      */ _parameter.Set(__Matchers[482]);
                /*  68 PlainRuleOp      */ _parameterReference.Set(__Matchers[484]);
                /*  69 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[485]);
                /*  70 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[489]);
                /*  71 PlainRuleOp      */ _functionParameterType.Set(__Matchers[490]);
                /*  72 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[491]);
                /*  73 PlainRuleOp      */ _valueParameterType.Set(__Matchers[492]);
                /*  74 PlainRuleOp      */ _typeParameters.Set(__Matchers[495]);
                /*  75 PlainRuleOp      */ _typeParameterList.Set(__Matchers[498]);
                /*  76 PlainRuleOp      */ _typeParameter.Set(__Matchers[501]);
                /*  77 PlainRuleOp      */ _variance.Set(__Matchers[504]);
                /*  78 PlainRuleOp      */ _typeDefault.Set(__Matchers[505]);
                /*  79 PlainRuleOp      */ _typeConstraint.Set(__Matchers[510]);
                /*  80 PlainRuleOp      */ _typeConstraints.Set(__Matchers[511]);
                /*  81 PlainRuleOp      */ _declarations.Set(__Matchers[512]);
                /*  82 PlainRuleOp      */ _declaration.Set(__Matchers[513]);
                /*  83 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[517]);
                /*  84 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[520]);
                /*  85 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[521]);
                /*  86 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[524]);
                /*  87 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[526]);
                /*  88 PlainRuleOp      */ _setterDefinition.Set(__Matchers[527]);
                /*  89 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[528]);
                /*  90 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[530]);
                /*  91 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[532]);
                /*  92 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[533]);
                /*  93 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[535]);
                /*  94 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[536]);
                /*  95 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[538]);
                /*  96 PlainRuleOp      */ _classDeclaration.Set(__Matchers[541]);
                /*  97 PlainRuleOp      */ _classDefinition.Set(__Matchers[542]);
                /*  98 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[544]);
                /*  99 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[546]);
                /* 100 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[547]);
                /* 101 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[549]);
                /* 102 PlainRuleOp      */ _statements.Set(__Matchers[550]);
                /* 103 PlainRuleOp      */ _statement.Set(__Matchers[551]);
                /* 104 PlainRuleOp      */ _declarationStatement.Set(_declaration);
                /* 105 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[552]);
                /* 106 PlainRuleOp      */ _openStatement.Set(__Matchers[553]);
                /* 107 PlainRuleOp      */ _specificationStatement.Set(__Matchers[554]);
                /* 108 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 109 PlainRuleOp      */ _directiveStatement.Set(__Matchers[555]);
                /* 110 PlainRuleOp      */ _returnStatement.Set(__Matchers[558]);
                /* 111 PlainRuleOp      */ _throwStatement.Set(__Matchers[560]);
                /* 112 PlainRuleOp      */ _breakStatement.Set(__Matchers[561]);
                /* 113 PlainRuleOp      */ _continueStatement.Set(__Matchers[562]);
                /* 114 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[563]);
                /* 115 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[564]);
                /* 116 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[565]);
                /* 117 PlainRuleOp      */ _anySpecifier.Set(__Matchers[566]);
                /* 118 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[567]);
                /* 119 PlainRuleOp      */ _baseReference.Set(__Matchers[568]);
                /* 120 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[569]);
                /* 121 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[570]);
                /* 122 PlainRuleOp      */ _memberReference.Set(__Matchers[572]);
                /* 123 PlainRuleOp      */ _typeReference.Set(__Matchers[573]);
                /* 124 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[574]);
                /* 125 PlainRuleOp      */ _selfReference.Set(__Matchers[577]);
                /* 126 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[579]);
                /* 127 PlainRuleOp      */ _tupleExpr.Set(__Matchers[580]);
                /* 128 PlainRuleOp      */ _arguments.Set(__Matchers[581]);
                /* 129 PlainRuleOp      */ _structuralArguments.Set(__Matchers[583]);
                /* 130 PlainRuleOp      */ _positionalArguments.Set(__Matchers[584]);
                /* 131 PlainRuleOp      */ _namedOrAnonymous.Set(__Matchers[585]);
                /* 132 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[586]);
                /* 133 PlainRuleOp      */ _namedArgument.Set(__Matchers[587]);
                /* 134 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[588]);
                /* 135 PlainRuleOp      */ _sequencedArguments.Set(__Matchers[591]);
                /* 136 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[592]);
                /* 137 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[593]);
                /* 138 PlainRuleOp      */ _objectArgument.Set(__Matchers[594]);
                /* 139 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[595]);
                /* 140 PlainRuleOp      */ _methodDefinition.Set(__Matchers[596]);
                /* 141 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[597]);
                /* 142 PlainRuleOp      */ _requiredFunctionSpecifier.Set(__Matchers[598]);
                /* 143 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[599]);
                /* 144 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[600]);
                /* 145 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 146 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[601]);
                /* 147 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[602]);
                /* 148 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[603]);
                /* 149 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[604]);
                /* 150 PlainRuleOp      */ _positionalArgument.Set(__Matchers[605]);
                /* 151 PlainRuleOp      */ _expressionArgument.Set(_expression);
                /* 152 PlainRuleOp      */ _spreadArgument.Set(__Matchers[607]);
                /* 153 PlainRuleOp      */ _letExpr.Set(__Matchers[609]);
                /* 154 PlainRuleOp      */ _switchExpr.Set(__Matchers[610]);
                /* 155 PlainRuleOp      */ _caseExpressions.Set(__Matchers[613]);
                /* 156 PlainRuleOp      */ _caseExpression.Set(__Matchers[617]);
                /* 157 PlainRuleOp      */ _ifExpr.Set(__Matchers[619]);
                /* 158 PlainRuleOp      */ _elseExpression.Set(__Matchers[620]);
                /* 159 PlainRuleOp      */ _thenExpression.Set(__Matchers[622]);
                /* 160 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[623]);
                /* 161 PlainRuleOp      */ _functionExpr.Set(__Matchers[626]);
                /* 162 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[627]);
                /* 163 PlainRuleOp      */ _functionParameters.Set(__Matchers[628]);
                /* 164 PlainRuleOp      */ _functionDefinition.Set(__Matchers[629]);
                /* 165 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[630]);
                /* 166 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[631]);
                /* 167 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 168 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[634]);
                /* 169 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[635]);
                /* 170 PlainRuleOp      */ _expression.Set(__Matchers[636]);
                /* 171 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 172 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[637]);
                /* 173 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[638]);
                /* 174 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[650]);
                /* 175 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[651]);
                /* 176 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[652]);
                /* 177 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[653]);
                /* 178 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[654]);
                /* 179 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[655]);
                /* 180 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[656]);
                /* 181 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[657]);
                /* 182 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[658]);
                /* 183 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[659]);
                /* 184 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[660]);
                /* 185 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[661]);
                /* 186 PlainRuleOp      */ _notOperator.Set(__Matchers[662]);
                /* 187 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[663]);
                /* 188 PlainRuleOp      */ _equalityExpression.Set(__Matchers[664]);
                /* 189 PlainRuleOp      */ _equalityExpr.Set(__Matchers[665]);
                /* 190 PlainRuleOp      */ _equalityOperator.Set(__Matchers[669]);
                /* 191 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[670]);
                /* 192 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[671]);
                /* 193 PlainRuleOp      */ _largerExpr.Set(__Matchers[672]);
                /* 194 PlainRuleOp      */ _smallerExpr.Set(__Matchers[673]);
                /* 195 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[674]);
                /* 196 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[675]);
                /* 197 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[676]);
                /* 198 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[678]);
                /* 199 PlainRuleOp      */ _smallerOperator.Set(__Matchers[680]);
                /* 200 PlainRuleOp      */ _largerOperator.Set(__Matchers[682]);
                /* 201 PlainRuleOp      */ _typeOperator.Set(__Matchers[684]);
                /* 202 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[685]);
                /* 203 PlainRuleOp      */ _existsExpr.Set(__Matchers[687]);
                /* 204 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[689]);
                /* 205 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[690]);
                /* 206 PlainRuleOp      */ _rangeExpr.Set(__Matchers[691]);
                /* 207 PlainRuleOp      */ _entryExpr.Set(__Matchers[692]);
                /* 208 PlainRuleOp      */ _rangeOperator.Set(__Matchers[694]);
                /* 209 PlainRuleOp      */ _entryOperator.Set(__Matchers[422]);
                /* 210 PlainRuleOp      */ _additiveExpression.Set(__Matchers[695]);
                /* 211 PlainRuleOp      */ _additiveExpr.Set(__Matchers[696]);
                /* 212 PlainRuleOp      */ _additiveOperator.Set(__Matchers[699]);
                /* 213 PlainRuleOp      */ _scaleExpression.Set(__Matchers[700]);
                /* 214 PlainRuleOp      */ _scaleExpr.Set(__Matchers[701]);
                /* 215 PlainRuleOp      */ _scaleOperator.Set(__Matchers[702]);
                /* 216 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[703]);
                /* 217 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[704]);
                /* 218 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[707]);
                /* 219 PlainRuleOp      */ _unionExpression.Set(__Matchers[708]);
                /* 220 PlainRuleOp      */ _unionExpr.Set(__Matchers[709]);
                /* 221 PlainRuleOp      */ _unionOperator.Set(__Matchers[711]);
                /* 222 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[712]);
                /* 223 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[713]);
                /* 224 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[714]);
                /* 225 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[715]);
                /* 226 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[716]);
                /* 227 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[717]);
                /* 228 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[718]);
                /* 229 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[719]);
                /* 230 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[720]);
                /* 231 PlainRuleOp      */ _negateOperator.Set(__Matchers[722]);
                /* 232 PlainRuleOp      */ _neutralOperator.Set(__Matchers[724]);
                /* 233 PlainRuleOp      */ _complementOperator.Set(__Matchers[710]);
                /* 234 PlainRuleOp      */ _prefixExpression.Set(__Matchers[725]);
                /* 235 PlainRuleOp      */ _prefixExpr.Set(__Matchers[726]);
                /* 236 PlainRuleOp      */ _postfixExpression.Set(__Matchers[727]);
                /* 237 PlainRuleOp      */ _postfixExpr.Set(__Matchers[728]);
                /* 238 PlainRuleOp      */ _incrementOperator.Set(__Matchers[731]);
                /* 239 PlainRuleOp      */ _primary.Set(__Matchers[732]);
                /* 240 PlainRuleOp      */ _selectionExpr.Set(__Matchers[733]);
                /* 241 PlainRuleOp      */ _qualifiedReference.Set(__Matchers[734]);
                /* 242 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[737]);
                /* 243 PlainRuleOp      */ _indexedExpr.Set(__Matchers[738]);
                /* 244 PlainRuleOp      */ _index.Set(__Matchers[739]);
                /* 245 PlainRuleOp      */ _upperSpanned.Set(__Matchers[740]);
                /* 246 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[741]);
                /* 247 PlainRuleOp      */ _spanned.Set(__Matchers[742]);
                /* 248 PlainRuleOp      */ _measured.Set(__Matchers[743]);
                /* 249 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 250 PlainRuleOp      */ _callExpr.Set(__Matchers[744]);
                /* 251 PlainRuleOp      */ _baseExpression.Set(__Matchers[745]);
                /* 252 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[746]);
                /* 253 PlainRuleOp      */ _stringExpression.Set(__Matchers[747]);
                /* 254 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[749]);
                /* 255 PlainRuleOp      */ _interpolationPart.Set(__Matchers[750]);
                /* 256 PlainRuleOp      */ _stringLiteral.Set(__Matchers[751]);
                /* 257 PlainRuleOp      */ _objectExpr.Set(__Matchers[752]);
                /* 258 PlainRuleOp      */ _groupedExpr.Set(__Matchers[753]);
                /* 259 PlainRuleOp      */ _typeArguments.Set(__Matchers[755]);
                /* 260 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[758]);
                /* 261 PlainRuleOp      */ _variancedType.Set(__Matchers[759]);
                /* 262 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[762]);
                /* 263 PlainRuleOp      */ _defaultedType.Set(__Matchers[763]);
                /* 264 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[764]);
                /* 265 PlainRuleOp      */ _variadicType.Set(__Matchers[765]);
                /* 266 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[766]);
                /* 267 PlainRuleOp      */ _variadicOperator.Set(__Matchers[767]);
                /* 268 PlainRuleOp      */ _spreadType.Set(__Matchers[768]);
                /* 269 PlainRuleOp      */ _type.Set(__Matchers[769]);
                /* 270 PlainRuleOp      */ _entryType.Set(__Matchers[770]);
                /* 271 PlainRuleOp      */ _unionType.Set(__Matchers[771]);
                /* 272 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[772]);
                /* 273 PlainRuleOp      */ _intersectionType.Set(__Matchers[773]);
                /* 274 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[774]);
                /* 275 PlainRuleOp      */ _primaryType.Set(__Matchers[775]);
                /* 276 PlainRuleOp      */ _nullableType.Set(__Matchers[777]);
                /* 277 PlainRuleOp      */ _arrayType.Set(__Matchers[779]);
                /* 278 PlainRuleOp      */ _functionType.Set(__Matchers[781]);
                /* 279 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[782]);
                /* 280 PlainRuleOp      */ _tupleType.Set(__Matchers[783]);
                /* 281 PlainRuleOp      */ _iterableType.Set(__Matchers[785]);
                /* 282 PlainRuleOp      */ _groupedType.Set(__Matchers[786]);
                /* 283 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[787]);
                /* 284 PlainRuleOp      */ _annotations.Set(__Matchers[790]);
                /* 285 PlainRuleOp      */ _annotation.Set(__Matchers[791]);
                /* 286 PlainRuleOp      */ _conditions.Set(__Matchers[793]);
                /* 287 PlainRuleOp      */ _conditionList.Set(__Matchers[796]);
                /* 288 PlainRuleOp      */ _condition.Set(__Matchers[797]);
                /* 289 PlainRuleOp      */ _existsCondition.Set(__Matchers[799]);
                /* 290 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[800]);
                /* 291 PlainRuleOp      */ _letOrExpression.Set(__Matchers[801]);
                /* 292 PlainRuleOp      */ _isCondition.Set(__Matchers[802]);
                /* 293 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[803]);
                /* 294 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[804]);
                /* 295 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 296 PlainRuleOp      */ _controlStatement.Set(__Matchers[805]);
                /* 297 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[807]);
                /* 298 PlainRuleOp      */ _ifBlock.Set(__Matchers[808]);
                /* 299 PlainRuleOp      */ _elseBlock.Set(__Matchers[809]);
                /* 300 PlainRuleOp      */ _elseBlockNext.Set(__Matchers[810]);
                /* 301 PlainRuleOp      */ _switchStatement.Set(__Matchers[812]);
                /* 302 PlainRuleOp      */ _switchHeader.Set(__Matchers[814]);
                /* 303 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 304 PlainRuleOp      */ _caseBlock.Set(__Matchers[815]);
                /* 305 PlainRuleOp      */ _caseItem.Set(__Matchers[816]);
                /* 306 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[818]);
                /* 307 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[819]);
                /* 308 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 309 PlainRuleOp      */ _valueCaseList.Set(__Matchers[822]);
                /* 310 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[823]);
                /* 311 PlainRuleOp      */ _valueCase.Set(__Matchers[824]);
                /* 312 PlainRuleOp      */ _forElseStatement.Set(__Matchers[826]);
                /* 313 PlainRuleOp      */ _forBlock.Set(__Matchers[827]);
                /* 314 PlainRuleOp      */ _failBlock.Set(__Matchers[828]);
                /* 315 PlainRuleOp      */ _forIterator.Set(__Matchers[830]);
                /* 316 PlainRuleOp      */ _forVariable.Set(__Matchers[831]);
                /* 317 PlainRuleOp      */ _containment.Set(__Matchers[832]);
                /* 318 PlainRuleOp      */ _containmentOperator.Set(__Matchers[833]);
                /* 319 PlainRuleOp      */ _whileStatement.Set(__Matchers[835]);
                /* 320 PlainRuleOp      */ _tryStatement.Set(__Matchers[838]);
                /* 321 PlainRuleOp      */ _tryBlock.Set(__Matchers[841]);
                /* 322 PlainRuleOp      */ _catchBlock.Set(__Matchers[843]);
                /* 323 PlainRuleOp      */ _catchVariable.Set(__Matchers[845]);
                /* 324 PlainRuleOp      */ _finallyBlock.Set(__Matchers[847]);
                /* 325 PlainRuleOp      */ _resources.Set(__Matchers[849]);
                /* 326 PlainRuleOp      */ _resourceList.Set(__Matchers[852]);
                /* 327 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 328 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[853]);
                /* 329 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[854]);
                /* 330 PlainRuleOp      */ _variable.Set(__Matchers[857]);
                /* 331 PlainRuleOp      */ _variableType.Set(__Matchers[858]);
                /* 332 PlainRuleOp      */ _modelReference.Set(__Matchers[859]);
                /* 333 PlainRuleOp      */ _metaLiteral.Set(__Matchers[861]);
                /* 334 PlainRuleOp      */ _metaExpression.Set(__Matchers[862]);
                /* 335 PlainRuleOp      */ _modelExpression.Set(__Matchers[863]);
                /* 336 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[864]);
                /* 337 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[865]);
                /* 338 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[866]);
                /* 339 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 340 PlainRuleOp      */ _declarationReference.Set(__Matchers[867]);
                /* 341 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[869]);
                /* 342 PlainRuleOp      */ _packageLiteral.Set(__Matchers[870]);
                /* 343 PlainRuleOp      */ _classLiteral.Set(__Matchers[871]);
                /* 344 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[872]);
                /* 345 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[873]);
                /* 346 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[874]);
                /* 347 PlainRuleOp      */ _newLiteral.Set(__Matchers[875]);
                /* 348 PlainRuleOp      */ _valueLiteral.Set(__Matchers[876]);
                /* 349 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[877]);
                /* 350 PlainRuleOp      */ _functionLiteral.Set(__Matchers[878]);
                /* 351 PlainRuleOp      */ _packageQualifier.Set(__Matchers[879]);
                /* 352 PlainRuleOp      */ _referencePath.Set(__Matchers[880]);
                /* 353 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[883]);
                /* 354 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 355 PlainRuleOp      */ _kwVoid.Set(__Matchers[529]);
                /* 356 PlainRuleOp      */ _kwFunction.Set(__Matchers[531]);
                /* 357 PlainRuleOp      */ _kwValue.Set(__Matchers[534]);
                /* 358 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 359 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 360 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 361 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 362 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 363 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 364 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 365 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 366 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 367 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 368 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 370 SeqOp            */ __Matchers[370].Set(_compilationUnit, __Matchers[369]);
                /* 371 AltOp            */ __Matchers[371].Set(_moduleDescriptor, _packageDescriptor, _codeUnit);
                /* 372 SeqOp            */ __Matchers[372].Set(_imports, _namespace, _declarations);
                /* 375 SeqOp            */ __Matchers[375].Set(_annotations, __Matchers[373], _namespacePath, __Matchers[374]);
                /* 377 SeqOp            */ __Matchers[377].Set(__Matchers[376], _identifier);
                /* 378 StarOp           */ __Matchers[378].Set(__Matchers[377]);
                /* 379 SeqOp            */ __Matchers[379].Set(_identifier, __Matchers[378]);
                /* 380 StarOp           */ __Matchers[380].Set(_importDeclaration);
                /* 382 OptionalOp       */ __Matchers[382].Set(_moduleSpecifier);
                /* 383 OptionalOp       */ __Matchers[383].Set(_version);
                /* 384 SeqOp            */ __Matchers[384].Set(_annotations, __Matchers[381], _moduleName, __Matchers[382], __Matchers[383], _moduleBody);
                /* 386 OptionalOp       */ __Matchers[386].Set(_artifactAndClassifier);
                /* 387 SeqOp            */ __Matchers[387].Set(_repository, __Matchers[385], _module, __Matchers[386]);
                /* 388 AltOp            */ __Matchers[388].Set(_literalString, _moduleName);
                /* 389 OptionalOp       */ __Matchers[389].Set(_classifier);
                /* 390 SeqOp            */ __Matchers[390].Set(_artifact, __Matchers[389]);
                /* 391 SeqOp            */ __Matchers[391].Set(__Matchers[385], _literalString);
                /* 392 SeqOp            */ __Matchers[392].Set(__Matchers[385], _literalString);
                /* 394 StarOp           */ __Matchers[394].Set(_moduleBodyElement);
                /* 396 SeqOp            */ __Matchers[396].Set(__Matchers[393], __Matchers[394], __Matchers[395]);
                /* 397 AltOp            */ __Matchers[397].Set(_inferredAttributeDeclaration, _importModule);
                /* 399 SeqOp            */ __Matchers[399].Set(_annotations, __Matchers[398], _packagePath, __Matchers[374]);
                /* 401 SeqOp            */ __Matchers[401].Set(_annotations, __Matchers[400], _module, __Matchers[383], __Matchers[374]);
                /* 402 SeqOp            */ __Matchers[402].Set(__Matchers[400], _packagePath, _importElements);
                /* 403 OptionalOp       */ __Matchers[403].Set(_importElementList);
                /* 404 SeqOp            */ __Matchers[404].Set(__Matchers[393], __Matchers[403], __Matchers[395]);
                /* 406 SeqOp            */ __Matchers[406].Set(__Matchers[405], _importElement);
                /* 407 StarOp           */ __Matchers[407].Set(__Matchers[406]);
                /* 408 SeqOp            */ __Matchers[408].Set(_importElement, __Matchers[407]);
                /* 409 AltOp            */ __Matchers[409].Set(_importNamed, _importWildcard);
                /* 410 OptionalOp       */ __Matchers[410].Set(_importNameSpecifier);
                /* 411 OptionalOp       */ __Matchers[411].Set(_importElements);
                /* 412 SeqOp            */ __Matchers[412].Set(_importName, __Matchers[410], __Matchers[411]);
                /* 414 SeqOp            */ __Matchers[414].Set(__Matchers[413], _identifier);
                /* 416 SeqOp            */ __Matchers[416].Set(__Matchers[376], _packageName);
                /* 417 StarOp           */ __Matchers[417].Set(__Matchers[416]);
                /* 418 SeqOp            */ __Matchers[418].Set(_packageName, __Matchers[417]);
                /* 419 AltOp            */ __Matchers[419].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 420 AltOp            */ __Matchers[420].Set(_tuplePattern, _variablePattern);
                /* 421 AltOp            */ __Matchers[421].Set(_entryPattern, _tuplePattern);
                /* 423 SeqOp            */ __Matchers[423].Set(_variableOrTuplePattern, __Matchers[422], _variableOrTuplePattern);
                /* 425 OptionalOp       */ __Matchers[425].Set(_variadicPatternList);
                /* 427 SeqOp            */ __Matchers[427].Set(__Matchers[424], __Matchers[425], __Matchers[426]);
                /* 428 SeqOp            */ __Matchers[428].Set(__Matchers[405], _variadicPattern);
                /* 429 StarOp           */ __Matchers[429].Set(__Matchers[428]);
                /* 430 SeqOp            */ __Matchers[430].Set(_variadicPattern, __Matchers[429]);
                /* 431 AltOp            */ __Matchers[431].Set(_variadicVariable, _pattern);
                /* 432 OptionalOp       */ __Matchers[432].Set(_unionType);
                /* 433 SeqOp            */ __Matchers[433].Set(__Matchers[432], _variadicOperator, _memberName);
                /* 437 SeqOp            */ __Matchers[437].Set(__Matchers[434], __Matchers[435], _letVariableList, __Matchers[436]);
                /* 438 SeqOp            */ __Matchers[438].Set(__Matchers[405], _letVariable);
                /* 439 StarOp           */ __Matchers[439].Set(__Matchers[438]);
                /* 440 SeqOp            */ __Matchers[440].Set(_letVariable, __Matchers[439]);
                /* 441 SeqOp            */ __Matchers[441].Set(_pattern, _valueSpecifier);
                /* 443 SeqOp            */ __Matchers[443].Set(__Matchers[442], _classInstatiation);
                /* 444 OptionalOp       */ __Matchers[444].Set(_assertionMessage);
                /* 446 SeqOp            */ __Matchers[446].Set(__Matchers[444], __Matchers[445], _conditions);
                /* 447 SeqOp            */ __Matchers[447].Set(__Matchers[393], _imports, _statements, __Matchers[395]);
                /* 448 SeqOp            */ __Matchers[448].Set(__Matchers[442], _classInstatiation);
                /* 450 SeqOp            */ __Matchers[450].Set(__Matchers[449], _classInstatiation);
                /* 451 OptionalOp       */ __Matchers[451].Set(_arguments);
                /* 452 SeqOp            */ __Matchers[452].Set(_qualifiedClass, __Matchers[451]);
                /* 453 AltOp            */ __Matchers[453].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 454 SeqOp            */ __Matchers[454].Set(__Matchers[398], __Matchers[376], _unQualifiedClass);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[455], __Matchers[376], _baseReference);
                /* 457 AltOp            */ __Matchers[457].Set(_memberPath, _typePath, _memberReference);
                /* 458 SeqOp            */ __Matchers[458].Set(_typePath, __Matchers[376], _memberReference);
                /* 459 SeqOp            */ __Matchers[459].Set(__Matchers[376], _typeReference);
                /* 460 StarOp           */ __Matchers[460].Set(__Matchers[459]);
                /* 461 SeqOp            */ __Matchers[461].Set(_typeReference, __Matchers[460]);
                /* 463 SeqOp            */ __Matchers[463].Set(__Matchers[462], _unionTypeList);
                /* 464 SeqOp            */ __Matchers[464].Set(__Matchers[405], _unionType);
                /* 465 StarOp           */ __Matchers[465].Set(__Matchers[464]);
                /* 466 SeqOp            */ __Matchers[466].Set(_unionType, __Matchers[465]);
                /* 468 SeqOp            */ __Matchers[468].Set(__Matchers[467], _caseTypeList);
                /* 470 SeqOp            */ __Matchers[470].Set(__Matchers[469], _caseType);
                /* 471 StarOp           */ __Matchers[471].Set(__Matchers[470]);
                /* 472 SeqOp            */ __Matchers[472].Set(_caseType, __Matchers[471]);
                /* 473 AltOp            */ __Matchers[473].Set(_primaryType, _qualifiedCaseType);
                /* 474 OptionalOp       */ __Matchers[474].Set(_packageQualifier);
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[474], _memberName);
                /* 476 OptionalOp       */ __Matchers[476].Set(_parameterList);
                /* 477 SeqOp            */ __Matchers[477].Set(__Matchers[435], __Matchers[476], __Matchers[436]);
                /* 478 SeqOp            */ __Matchers[478].Set(__Matchers[405], _parameterDeclarationOrRefPattern);
                /* 479 StarOp           */ __Matchers[479].Set(__Matchers[478]);
                /* 480 SeqOp            */ __Matchers[480].Set(_parameterDeclarationOrRefPattern, __Matchers[479]);
                /* 481 AltOp            */ __Matchers[481].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 482 SeqOp            */ __Matchers[482].Set(_annotations, _parameterDeclaration);
                /* 483 OptionalOp       */ __Matchers[483].Set(_valueSpecifier);
                /* 484 SeqOp            */ __Matchers[484].Set(_memberName, __Matchers[483]);
                /* 485 AltOp            */ __Matchers[485].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 486 OptionalOp       */ __Matchers[486].Set(_typeParameters);
                /* 487 PlusOp           */ __Matchers[487].Set(_parameters);
                /* 488 OptionalOp       */ __Matchers[488].Set(_functionSpecifier);
                /* 489 SeqOp            */ __Matchers[489].Set(_functionParameterType, _memberName, __Matchers[486], __Matchers[487], __Matchers[488]);
                /* 490 AltOp            */ __Matchers[490].Set(_variadicType, _kwVoid, _kwFunction);
                /* 491 SeqOp            */ __Matchers[491].Set(_valueParameterType, _memberName, __Matchers[483]);
                /* 492 AltOp            */ __Matchers[492].Set(_variadicType, _kwValue);
                /* 495 SeqOp            */ __Matchers[495].Set(__Matchers[493], _typeParameterList, __Matchers[494]);
                /* 496 SeqOp            */ __Matchers[496].Set(__Matchers[405], _typeParameter);
                /* 497 StarOp           */ __Matchers[497].Set(__Matchers[496]);
                /* 498 SeqOp            */ __Matchers[498].Set(_typeParameter, __Matchers[497]);
                /* 499 OptionalOp       */ __Matchers[499].Set(_variance);
                /* 500 OptionalOp       */ __Matchers[500].Set(_typeDefault);
                /* 501 SeqOp            */ __Matchers[501].Set(__Matchers[499], _typeName, __Matchers[500]);
                /* 504 AltOp            */ __Matchers[504].Set(__Matchers[502], __Matchers[503]);
                /* 505 SeqOp            */ __Matchers[505].Set(__Matchers[413], _type);
                /* 507 OptionalOp       */ __Matchers[507].Set(_typeName);
                /* 508 OptionalOp       */ __Matchers[508].Set(_caseTypes);
                /* 509 OptionalOp       */ __Matchers[509].Set(_satisfiedTypes);
                /* 510 SeqOp            */ __Matchers[510].Set(__Matchers[506], __Matchers[507], __Matchers[486], __Matchers[508], __Matchers[509]);
                /* 511 PlusOp           */ __Matchers[511].Set(_typeConstraint);
                /* 512 StarOp           */ __Matchers[512].Set(_declaration);
                /* 513 AltOp            */ __Matchers[513].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 515 OptionalOp       */ __Matchers[515].Set(_memberName);
                /* 516 OptionalOp       */ __Matchers[516].Set(_delegatedConstructor);
                /* 517 SeqOp            */ __Matchers[517].Set(_annotations, __Matchers[514], __Matchers[515], _parameters, __Matchers[516], _block);
                /* 519 OptionalOp       */ __Matchers[519].Set(_typeConstraints);
                /* 520 SeqOp            */ __Matchers[520].Set(_annotations, __Matchers[518], _typeName, __Matchers[486], __Matchers[519], _optionalTypeSpecifier);
                /* 521 SeqOp            */ __Matchers[521].Set(_annotations, __Matchers[514], _memberName, __Matchers[516], _block);
                /* 523 OptionalOp       */ __Matchers[523].Set(_extendedType);
                /* 524 SeqOp            */ __Matchers[524].Set(_annotations, __Matchers[522], _memberName, __Matchers[523], __Matchers[509], _block);
                /* 526 SeqOp            */ __Matchers[526].Set(_annotations, __Matchers[525], _memberName, _setterDefinition);
                /* 527 AltOp            */ __Matchers[527].Set(_block, _requiredFunctionSpecifier);
                /* 528 SeqOp            */ __Matchers[528].Set(_annotations, _variadicType, _memberName, __Matchers[486], __Matchers[487], __Matchers[519], _methodDefinition);
                /* 530 SeqOp            */ __Matchers[530].Set(_annotations, __Matchers[529], _memberName, __Matchers[486], __Matchers[487], __Matchers[519], _methodDefinition);
                /* 532 SeqOp            */ __Matchers[532].Set(_annotations, __Matchers[531], _memberName, __Matchers[486], __Matchers[487], __Matchers[519], _methodDefinition);
                /* 533 SeqOp            */ __Matchers[533].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 535 SeqOp            */ __Matchers[535].Set(_annotations, __Matchers[534], _memberName, _attributeDefinition);
                /* 536 AltOp            */ __Matchers[536].Set(_block, _optionalAnySpecifier);
                /* 537 OptionalOp       */ __Matchers[537].Set(_anySpecifier);
                /* 538 SeqOp            */ __Matchers[538].Set(__Matchers[537], __Matchers[374]);
                /* 540 OptionalOp       */ __Matchers[540].Set(_parameters);
                /* 541 SeqOp            */ __Matchers[541].Set(_annotations, __Matchers[539], _typeName, __Matchers[486], __Matchers[540], __Matchers[508], __Matchers[523], __Matchers[509], __Matchers[519], _classDefinition);
                /* 542 AltOp            */ __Matchers[542].Set(_block, _optionalClassSpecifier);
                /* 543 OptionalOp       */ __Matchers[543].Set(_classSpecifier);
                /* 544 SeqOp            */ __Matchers[544].Set(__Matchers[543], __Matchers[374]);
                /* 546 SeqOp            */ __Matchers[546].Set(_annotations, __Matchers[545], _typeName, __Matchers[486], __Matchers[508], __Matchers[509], __Matchers[519], _interfaceDefinition);
                /* 547 AltOp            */ __Matchers[547].Set(_block, _optionalTypeSpecifier);
                /* 548 OptionalOp       */ __Matchers[548].Set(_typeSpecifier);
                /* 549 SeqOp            */ __Matchers[549].Set(__Matchers[548], __Matchers[374]);
                /* 550 StarOp           */ __Matchers[550].Set(_statement);
                /* 551 AltOp            */ __Matchers[551].Set(_declarationStatement, _unclosedStatement, _controlStatement);
                /* 552 SeqOp            */ __Matchers[552].Set(_openStatement, __Matchers[374]);
                /* 553 AltOp            */ __Matchers[553].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 554 SeqOp            */ __Matchers[554].Set(_primary, _functionSpecifier);
                /* 555 AltOp            */ __Matchers[555].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement);
                /* 557 OptionalOp       */ __Matchers[557].Set(_expression);
                /* 558 SeqOp            */ __Matchers[558].Set(__Matchers[556], __Matchers[557]);
                /* 560 SeqOp            */ __Matchers[560].Set(__Matchers[559], __Matchers[557]);
                /* 563 SeqOp            */ __Matchers[563].Set(__Matchers[449], _type);
                /* 564 SeqOp            */ __Matchers[564].Set(__Matchers[413], _expression);
                /* 565 SeqOp            */ __Matchers[565].Set(__Matchers[449], _expression);
                /* 566 AltOp            */ __Matchers[566].Set(_valueSpecifier, _functionSpecifier);
                /* 567 AltOp            */ __Matchers[567].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 568 AltOp            */ __Matchers[568].Set(_memberReference, _typeReference);
                /* 569 SeqOp            */ __Matchers[569].Set(_memberName, __Matchers[486], __Matchers[487]);
                /* 570 SeqOp            */ __Matchers[570].Set(_selfReferenceSelector, _parametrizedMember);
                /* 571 OptionalOp       */ __Matchers[571].Set(_typeArguments);
                /* 572 SeqOp            */ __Matchers[572].Set(_memberName, __Matchers[571]);
                /* 573 SeqOp            */ __Matchers[573].Set(_typeName, __Matchers[571]);
                /* 574 SeqOp            */ __Matchers[574].Set(_selfReference, _memberSelectionOperator);
                /* 577 AltOp            */ __Matchers[577].Set(__Matchers[575], __Matchers[455], __Matchers[576], __Matchers[398]);
                /* 578 OptionalOp       */ __Matchers[578].Set(_sequencedArguments);
                /* 579 SeqOp            */ __Matchers[579].Set(__Matchers[393], _statements, __Matchers[578], __Matchers[395]);
                /* 580 SeqOp            */ __Matchers[580].Set(__Matchers[424], __Matchers[578], __Matchers[426]);
                /* 581 AltOp            */ __Matchers[581].Set(_structuralArguments, _positionalArguments);
                /* 582 StarOp           */ __Matchers[582].Set(_namedOrAnonymous);
                /* 583 SeqOp            */ __Matchers[583].Set(__Matchers[393], __Matchers[582], __Matchers[578], __Matchers[395]);
                /* 584 SeqOp            */ __Matchers[584].Set(__Matchers[435], __Matchers[578], __Matchers[436]);
                /* 585 AltOp            */ __Matchers[585].Set(_anonymousArgument, _namedArgument);
                /* 586 SeqOp            */ __Matchers[586].Set(_expression, __Matchers[374]);
                /* 587 AltOp            */ __Matchers[587].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 588 SeqOp            */ __Matchers[588].Set(_memberName, _valueSpecifier, __Matchers[374]);
                /* 589 SeqOp            */ __Matchers[589].Set(__Matchers[405], _sequencedArgument);
                /* 590 StarOp           */ __Matchers[590].Set(__Matchers[589]);
                /* 591 SeqOp            */ __Matchers[591].Set(_sequencedArgument, __Matchers[590]);
                /* 592 AltOp            */ __Matchers[592].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 593 AltOp            */ __Matchers[593].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 594 SeqOp            */ __Matchers[594].Set(__Matchers[522], __Matchers[515], __Matchers[523], __Matchers[509], _block);
                /* 595 SeqOp            */ __Matchers[595].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 596 AltOp            */ __Matchers[596].Set(_block, _optionalFunctionSpecifier);
                /* 597 SeqOp            */ __Matchers[597].Set(__Matchers[488], __Matchers[374]);
                /* 598 SeqOp            */ __Matchers[598].Set(_functionSpecifier, __Matchers[374]);
                /* 599 AltOp            */ __Matchers[599].Set(_type, _kwVoid);
                /* 600 SeqOp            */ __Matchers[600].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 601 SeqOp            */ __Matchers[601].Set(__Matchers[531], __Matchers[515], __Matchers[486], _parameters, _methodDefinition);
                /* 602 SeqOp            */ __Matchers[602].Set(__Matchers[534], _memberName, _methodDefinition);
                /* 603 SeqOp            */ __Matchers[603].Set(_memberName, __Matchers[487], _requiredFunctionSpecifier);
                /* 604 SeqOp            */ __Matchers[604].Set(_memberName, _requiredFunctionSpecifier);
                /* 605 AltOp            */ __Matchers[605].Set(_expressionArgument, _declarationReference);
                /* 607 SeqOp            */ __Matchers[607].Set(__Matchers[606], _unionExpression);
                /* 608 OptionalOp       */ __Matchers[608].Set(_letVariableList);
                /* 609 SeqOp            */ __Matchers[609].Set(__Matchers[434], __Matchers[435], __Matchers[608], __Matchers[436], _conditionalExpression);
                /* 610 SeqOp            */ __Matchers[610].Set(_switchHeader, _caseExpressions);
                /* 611 PlusOp           */ __Matchers[611].Set(_caseExpression);
                /* 612 OptionalOp       */ __Matchers[612].Set(_elseExpression);
                /* 613 SeqOp            */ __Matchers[613].Set(__Matchers[611], __Matchers[612]);
                /* 615 OptionalOp       */ __Matchers[615].Set(__Matchers[614]);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[615], __Matchers[616], __Matchers[435], _caseItem, __Matchers[436], _conditionalExpression);
                /* 619 SeqOp            */ __Matchers[619].Set(__Matchers[618], _conditions, _thenExpression, _elseExpression);
                /* 620 SeqOp            */ __Matchers[620].Set(__Matchers[614], _conditionalExpression);
                /* 622 SeqOp            */ __Matchers[622].Set(__Matchers[621], _conditionalExpression);
                /* 623 AltOp            */ __Matchers[623].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 624 OptionalOp       */ __Matchers[624].Set(_functionExpressionType);
                /* 625 OptionalOp       */ __Matchers[625].Set(_functionParameters);
                /* 626 SeqOp            */ __Matchers[626].Set(__Matchers[624], __Matchers[486], __Matchers[625], _functionDefinition);
                /* 627 AltOp            */ __Matchers[627].Set(__Matchers[529], __Matchers[531]);
                /* 628 SeqOp            */ __Matchers[628].Set(__Matchers[487], __Matchers[519]);
                /* 629 AltOp            */ __Matchers[629].Set(_block, _functionSpecifier);
                /* 630 AltOp            */ __Matchers[630].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 631 AltOp            */ __Matchers[631].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 633 OptionalOp       */ __Matchers[633].Set(_forIterator);
                /* 634 SeqOp            */ __Matchers[634].Set(__Matchers[632], __Matchers[435], __Matchers[633], __Matchers[436], _comprehensionClause);
                /* 635 SeqOp            */ __Matchers[635].Set(__Matchers[618], _conditions, _comprehensionClause);
                /* 636 AltOp            */ __Matchers[636].Set(_letExpr, _ifExpr, _switchExpr, _functionExpr, _operatorExpression);
                /* 637 AltOp            */ __Matchers[637].Set(_assignmentExpr, _thenElseExpression);
                /* 638 SeqOp            */ __Matchers[638].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 650 AltOp            */ __Matchers[650].Set(__Matchers[413], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646], __Matchers[647], __Matchers[648], __Matchers[649]);
                /* 651 AltOp            */ __Matchers[651].Set(_thenElseExpr, _disjunctionExpression);
                /* 652 SeqOp            */ __Matchers[652].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 653 AltOp            */ __Matchers[653].Set(__Matchers[614], __Matchers[621]);
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
                /* 678 AltOp            */ __Matchers[678].Set(__Matchers[677], __Matchers[502]);
                /* 680 AltOp            */ __Matchers[680].Set(__Matchers[679], __Matchers[493]);
                /* 682 AltOp            */ __Matchers[682].Set(__Matchers[681], __Matchers[494]);
                /* 684 AltOp            */ __Matchers[684].Set(__Matchers[683], __Matchers[442], __Matchers[462], __Matchers[467]);
                /* 685 AltOp            */ __Matchers[685].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 687 SeqOp            */ __Matchers[687].Set(_entryRangeExpression, __Matchers[686]);
                /* 689 SeqOp            */ __Matchers[689].Set(_entryRangeExpression, __Matchers[688]);
                /* 690 AltOp            */ __Matchers[690].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 691 SeqOp            */ __Matchers[691].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 692 SeqOp            */ __Matchers[692].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 694 AltOp            */ __Matchers[694].Set(__Matchers[693], __Matchers[385]);
                /* 695 AltOp            */ __Matchers[695].Set(_additiveExpr, _scaleExpression);
                /* 696 SeqOp            */ __Matchers[696].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 699 AltOp            */ __Matchers[699].Set(__Matchers[697], __Matchers[698]);
                /* 700 AltOp            */ __Matchers[700].Set(_scaleExpr, _multiplicativeExpression);
                /* 701 SeqOp            */ __Matchers[701].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 703 AltOp            */ __Matchers[703].Set(_multiplicativeExpr, _unionExpression);
                /* 704 SeqOp            */ __Matchers[704].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 707 AltOp            */ __Matchers[707].Set(__Matchers[606], __Matchers[705], __Matchers[706]);
                /* 708 AltOp            */ __Matchers[708].Set(_unionExpr, _exclusiveExpression);
                /* 709 SeqOp            */ __Matchers[709].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 711 AltOp            */ __Matchers[711].Set(__Matchers[469], __Matchers[710]);
                /* 712 AltOp            */ __Matchers[712].Set(_exclusiveExpr, _intersectionExpression);
                /* 713 SeqOp            */ __Matchers[713].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 715 AltOp            */ __Matchers[715].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 716 SeqOp            */ __Matchers[716].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 718 AltOp            */ __Matchers[718].Set(_negationOrComplementExpr, _prefixExpression);
                /* 719 SeqOp            */ __Matchers[719].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 720 AltOp            */ __Matchers[720].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 721 NotOp            */ __Matchers[721].Set(__Matchers_721_DFA);
                /* 722 SeqOp            */ __Matchers[722].Set(__Matchers[698], __Matchers[721]);
                /* 723 NotOp            */ __Matchers[723].Set(__Matchers_723_DFA);
                /* 724 SeqOp            */ __Matchers[724].Set(__Matchers[697], __Matchers[723]);
                /* 725 AltOp            */ __Matchers[725].Set(_prefixExpr, _postfixExpression);
                /* 726 SeqOp            */ __Matchers[726].Set(_incrementOperator, _prefixExpression);
                /* 727 AltOp            */ __Matchers[727].Set(_postfixExpr, _primary);
                /* 728 SeqOp            */ __Matchers[728].Set(_postfixExpression, _incrementOperator);
                /* 731 AltOp            */ __Matchers[731].Set(__Matchers[729], __Matchers[730]);
                /* 732 AltOp            */ __Matchers[732].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 733 SeqOp            */ __Matchers[733].Set(_primary, _qualifiedReference);
                /* 734 SeqOp            */ __Matchers[734].Set(_memberSelectionOperator, _baseReference);
                /* 737 AltOp            */ __Matchers[737].Set(__Matchers[376], __Matchers[735], __Matchers[736]);
                /* 738 SeqOp            */ __Matchers[738].Set(_primary, __Matchers[424], _index, __Matchers[426]);
                /* 739 AltOp            */ __Matchers[739].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 740 SeqOp            */ __Matchers[740].Set(_indexExpression, __Matchers[415]);
                /* 741 SeqOp            */ __Matchers[741].Set(__Matchers[415], _indexExpression);
                /* 742 SeqOp            */ __Matchers[742].Set(_indexExpression, __Matchers[693], _indexExpression);
                /* 743 SeqOp            */ __Matchers[743].Set(_indexExpression, __Matchers[385], _indexExpression);
                /* 744 SeqOp            */ __Matchers[744].Set(_primary, _arguments);
                /* 745 AltOp            */ __Matchers[745].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 746 AltOp            */ __Matchers[746].Set(_literalNatural, _literalFloat, _literalChar);
                /* 747 AltOp            */ __Matchers[747].Set(_stringLiteral, _stringInterpolation);
                /* 748 StarOp           */ __Matchers[748].Set(_interpolationPart);
                /* 749 SeqOp            */ __Matchers[749].Set(_stringStart, _expression, __Matchers[748], _stringEnd);
                /* 750 SeqOp            */ __Matchers[750].Set(_stringMid, _expression);
                /* 751 AltOp            */ __Matchers[751].Set(_literalString, _verbatimString);
                /* 752 SeqOp            */ __Matchers[752].Set(__Matchers[522], __Matchers[523], __Matchers[509], _block);
                /* 753 SeqOp            */ __Matchers[753].Set(__Matchers[435], _expression, __Matchers[436]);
                /* 754 OptionalOp       */ __Matchers[754].Set(_typeArgumentList);
                /* 755 SeqOp            */ __Matchers[755].Set(__Matchers[493], __Matchers[754], __Matchers[494]);
                /* 756 SeqOp            */ __Matchers[756].Set(__Matchers[405], _variancedType);
                /* 757 StarOp           */ __Matchers[757].Set(__Matchers[756]);
                /* 758 SeqOp            */ __Matchers[758].Set(_variancedType, __Matchers[757]);
                /* 759 SeqOp            */ __Matchers[759].Set(__Matchers[499], _type);
                /* 760 SeqOp            */ __Matchers[760].Set(__Matchers[405], _defaultedType);
                /* 761 StarOp           */ __Matchers[761].Set(__Matchers[760]);
                /* 762 SeqOp            */ __Matchers[762].Set(_defaultedType, __Matchers[761]);
                /* 763 AltOp            */ __Matchers[763].Set(_defaultedTypeCore, _variadicType);
                /* 764 SeqOp            */ __Matchers[764].Set(_type, __Matchers[413]);
                /* 765 AltOp            */ __Matchers[765].Set(_variadicUnionType, _type);
                /* 766 SeqOp            */ __Matchers[766].Set(_unionType, _variadicOperator);
                /* 767 AltOp            */ __Matchers[767].Set(__Matchers[606], __Matchers[697]);
                /* 768 SeqOp            */ __Matchers[768].Set(__Matchers[606], _unionType);
                /* 769 AltOp            */ __Matchers[769].Set(_entryType, _unionType);
                /* 770 SeqOp            */ __Matchers[770].Set(_unionType, __Matchers[422], _unionType);
                /* 771 AltOp            */ __Matchers[771].Set(_unionTypeCore, _intersectionType);
                /* 772 SeqOp            */ __Matchers[772].Set(_unionType, __Matchers[469], _intersectionType);
                /* 773 AltOp            */ __Matchers[773].Set(_intersectionTypeCore, _primaryType);
                /* 774 SeqOp            */ __Matchers[774].Set(_intersectionType, __Matchers[717], _primaryType);
                /* 775 AltOp            */ __Matchers[775].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 777 SeqOp            */ __Matchers[777].Set(_primaryType, __Matchers[776]);
                /* 778 OptionalOp       */ __Matchers[778].Set(_literalNatural);
                /* 779 SeqOp            */ __Matchers[779].Set(_primaryType, __Matchers[424], __Matchers[778], __Matchers[426]);
                /* 780 OptionalOp       */ __Matchers[780].Set(_typeTypeArguments);
                /* 781 SeqOp            */ __Matchers[781].Set(_primaryType, __Matchers[435], __Matchers[780], __Matchers[436]);
                /* 782 AltOp            */ __Matchers[782].Set(_spreadType, _defaultedTypeList);
                /* 783 SeqOp            */ __Matchers[783].Set(__Matchers[424], __Matchers[780], __Matchers[426]);
                /* 784 OptionalOp       */ __Matchers[784].Set(_variadicType);
                /* 785 SeqOp            */ __Matchers[785].Set(__Matchers[393], __Matchers[784], __Matchers[395]);
                /* 786 SeqOp            */ __Matchers[786].Set(__Matchers[493], _type, __Matchers[494]);
                /* 787 SeqOp            */ __Matchers[787].Set(__Matchers[398], __Matchers[376], _typePath);
                /* 788 OptionalOp       */ __Matchers[788].Set(_stringLiteral);
                /* 789 StarOp           */ __Matchers[789].Set(_annotation);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[788], __Matchers[789]);
                /* 791 SeqOp            */ __Matchers[791].Set(_memberName, __Matchers[451]);
                /* 792 OptionalOp       */ __Matchers[792].Set(_conditionList);
                /* 793 SeqOp            */ __Matchers[793].Set(__Matchers[435], __Matchers[792], __Matchers[436]);
                /* 794 SeqOp            */ __Matchers[794].Set(__Matchers[405], _condition);
                /* 795 StarOp           */ __Matchers[795].Set(__Matchers[794]);
                /* 796 SeqOp            */ __Matchers[796].Set(_condition, __Matchers[795]);
                /* 797 AltOp            */ __Matchers[797].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 798 OptionalOp       */ __Matchers[798].Set(__Matchers[662]);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[798], __Matchers[686], _letOrExpression);
                /* 800 SeqOp            */ __Matchers[800].Set(__Matchers[798], __Matchers[688], _letOrExpression);
                /* 801 AltOp            */ __Matchers[801].Set(_letVariable, _operatorExpression);
                /* 802 SeqOp            */ __Matchers[802].Set(__Matchers[798], __Matchers[683], _type, _isConditionVariable);
                /* 803 SeqOp            */ __Matchers[803].Set(_memberName, __Matchers[483]);
                /* 804 SeqOp            */ __Matchers[804].Set(__Matchers[462], _type, _typeName);
                /* 805 AltOp            */ __Matchers[805].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 806 OptionalOp       */ __Matchers[806].Set(_elseBlock);
                /* 807 SeqOp            */ __Matchers[807].Set(_ifBlock, __Matchers[806]);
                /* 808 SeqOp            */ __Matchers[808].Set(__Matchers[618], _conditions, _block);
                /* 809 SeqOp            */ __Matchers[809].Set(__Matchers[614], _elseBlockNext);
                /* 810 AltOp            */ __Matchers[810].Set(_ifElseStatement, _block);
                /* 811 PlusOp           */ __Matchers[811].Set(_caseBlock);
                /* 812 SeqOp            */ __Matchers[812].Set(_switchHeader, __Matchers[811], __Matchers[806]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[813], __Matchers[435], _switched, __Matchers[436]);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[615], __Matchers[616], __Matchers[435], _caseItem, __Matchers[436], _block);
                /* 816 AltOp            */ __Matchers[816].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 817 OptionalOp       */ __Matchers[817].Set(__Matchers[683]);
                /* 818 SeqOp            */ __Matchers[818].Set(__Matchers[817], _type);
                /* 819 SeqOp            */ __Matchers[819].Set(__Matchers[462], _type);
                /* 820 SeqOp            */ __Matchers[820].Set(_valueCaseSeparator, _valueCase);
                /* 821 StarOp           */ __Matchers[821].Set(__Matchers[820]);
                /* 822 SeqOp            */ __Matchers[822].Set(_valueCase, __Matchers[821]);
                /* 823 AltOp            */ __Matchers[823].Set(__Matchers[405], __Matchers[469]);
                /* 824 AltOp            */ __Matchers[824].Set(_intersectionType, _intersectionExpression);
                /* 825 OptionalOp       */ __Matchers[825].Set(_failBlock);
                /* 826 SeqOp            */ __Matchers[826].Set(_forBlock, __Matchers[825]);
                /* 827 SeqOp            */ __Matchers[827].Set(__Matchers[632], __Matchers[435], __Matchers[633], __Matchers[436], _block);
                /* 828 SeqOp            */ __Matchers[828].Set(__Matchers[614], _block);
                /* 829 OptionalOp       */ __Matchers[829].Set(_containment);
                /* 830 SeqOp            */ __Matchers[830].Set(_forVariable, __Matchers[829]);
                /* 831 AltOp            */ __Matchers[831].Set(_tupleOrEntryPattern, _variable);
                /* 832 SeqOp            */ __Matchers[832].Set(_containmentOperator, _operatorExpression);
                /* 833 AltOp            */ __Matchers[833].Set(__Matchers[502], __Matchers[385]);
                /* 835 SeqOp            */ __Matchers[835].Set(__Matchers[834], _conditions, _block);
                /* 836 StarOp           */ __Matchers[836].Set(_catchBlock);
                /* 837 OptionalOp       */ __Matchers[837].Set(_finallyBlock);
                /* 838 SeqOp            */ __Matchers[838].Set(_tryBlock, __Matchers[836], __Matchers[837]);
                /* 840 OptionalOp       */ __Matchers[840].Set(_resources);
                /* 841 SeqOp            */ __Matchers[841].Set(__Matchers[839], __Matchers[840], _block);
                /* 843 SeqOp            */ __Matchers[843].Set(__Matchers[842], _catchVariable, _block);
                /* 844 OptionalOp       */ __Matchers[844].Set(_variable);
                /* 845 SeqOp            */ __Matchers[845].Set(__Matchers[435], __Matchers[844], __Matchers[436]);
                /* 847 SeqOp            */ __Matchers[847].Set(__Matchers[846], _block);
                /* 848 OptionalOp       */ __Matchers[848].Set(_resourceList);
                /* 849 SeqOp            */ __Matchers[849].Set(__Matchers[435], __Matchers[848], __Matchers[436]);
                /* 850 SeqOp            */ __Matchers[850].Set(__Matchers[405], _resource);
                /* 851 StarOp           */ __Matchers[851].Set(__Matchers[850]);
                /* 852 SeqOp            */ __Matchers[852].Set(_resource, __Matchers[851]);
                /* 853 AltOp            */ __Matchers[853].Set(_specifiedVariable, _operatorExpression);
                /* 854 SeqOp            */ __Matchers[854].Set(_variable, _valueSpecifier);
                /* 855 OptionalOp       */ __Matchers[855].Set(_variableType);
                /* 856 StarOp           */ __Matchers[856].Set(_parameters);
                /* 857 SeqOp            */ __Matchers[857].Set(__Matchers[855], _memberName, __Matchers[856]);
                /* 858 AltOp            */ __Matchers[858].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 859 SeqOp            */ __Matchers[859].Set(__Matchers[714], _modelExpression);
                /* 861 SeqOp            */ __Matchers[861].Set(__Matchers[860], _metaExpression, __Matchers[860]);
                /* 862 AltOp            */ __Matchers[862].Set(_declarationReference, _modelExpression);
                /* 863 AltOp            */ __Matchers[863].Set(_memberModelExpression, _typeModelExpression);
                /* 864 AltOp            */ __Matchers[864].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[398], __Matchers[376], _memberReference);
                /* 866 SeqOp            */ __Matchers[866].Set(_primaryType, __Matchers[376], _memberReference);
                /* 867 AltOp            */ __Matchers[867].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 868 OptionalOp       */ __Matchers[868].Set(_packagePath);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[381], __Matchers[868]);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[398], __Matchers[868]);
                /* 871 SeqOp            */ __Matchers[871].Set(__Matchers[539], _referencePath);
                /* 872 SeqOp            */ __Matchers[872].Set(__Matchers[545], _referencePath);
                /* 873 SeqOp            */ __Matchers[873].Set(__Matchers[518], _referencePath);
                /* 874 SeqOp            */ __Matchers[874].Set(__Matchers[506], _referencePath);
                /* 875 SeqOp            */ __Matchers[875].Set(__Matchers[514], _referencePath);
                /* 876 SeqOp            */ __Matchers[876].Set(_valueLiteralIntro, _referencePath);
                /* 877 AltOp            */ __Matchers[877].Set(__Matchers[534], __Matchers[522]);
                /* 878 SeqOp            */ __Matchers[878].Set(__Matchers[531], _referencePath);
                /* 879 SeqOp            */ __Matchers[879].Set(__Matchers[398], __Matchers[376]);
                /* 880 SeqOp            */ __Matchers[880].Set(__Matchers[474], _referencePathElementList);
                /* 881 SeqOp            */ __Matchers[881].Set(__Matchers[376], _referencePathElement);
                /* 882 StarOp           */ __Matchers[882].Set(__Matchers[881]);
                /* 883 SeqOp            */ __Matchers[883].Set(_referencePathElement, __Matchers[882]);

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
                __Matchers_721_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_721_DFA.States[0].Set(
                    new DfaTrans(__Matchers_721_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_721_DFA.States[1].Set(
                );
                __Matchers_723_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_723_DFA.States[0].Set(
                    new DfaTrans(__Matchers_723_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_723_DFA.States[1].Set(
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
            private PlainRule _structuralArguments;
            private PlainRule _positionalArguments;
            private PlainRule _namedOrAnonymous;
            private PlainRule _anonymousArgument;
            private PlainRule _namedArgument;
            private PlainRule _namedSpecifiedArgument;
            private PlainRule _sequencedArguments;
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
            private Dfa __Matchers_721_DFA = new Dfa("__Matchers_721_DFA");
            private Dfa __Matchers_723_DFA = new Dfa("__Matchers_723_DFA");
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
        public interface ICLetVariableList : IRNode {}
        public interface ICLetVariable : ICLetOrExpression {}
        public interface ICDelegatedConstructor : IRNode {}
        public interface ICAssertionStatement : ICOpenStatement {}
        public interface ICAssertionMessage : IRNode {}
        public interface ICBlock : ICAttributeDefinition, ICClassDefinition, ICElseBlockNext, ICFunctionDefinition, ICInterfaceDefinition, ICMethodDefinition, ICSetterDefinition {}
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
        public interface ICStructuralArguments : ICArguments {}
        public interface ICPositionalArguments : ICArguments {}
        public interface ICNamedOrAnonymous : IRNode {}
        public interface ICAnonymousArgument : ICNamedOrAnonymous {}
        public interface ICNamedArgument : ICNamedOrAnonymous {}
        public interface ICNamedSpecifiedArgument : ICNamedArgument {}
        public interface ICSequencedArguments : IRNode {}
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
            public ROptional<CModuleSpecifier> ModuleSpecifierOptional => Get<ROptional<CModuleSpecifier>>(3);
            public ROptional<ICVersion> VersionOptional => Get<ROptional<ICVersion>>(4);
            public CModuleBody ModuleBody => Get<CModuleBody>(5);
        }

        public partial class CModuleSpecifier : RSequence, ICModuleSpecifier
        {
            // sequence
            public CModuleSpecifier(params RNode[] children) : base(children) {}

            public ICRepository Repository => Get<ICRepository>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ':'
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
            public RStar<ICModuleBodyElement> ModuleBodyElementStar => Get<RStar<ICModuleBodyElement>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // '}'
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

        public partial class CImportModule : RSequence, ICImportModule
        {
            // sequence
            public CImportModule(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'import'
            public ICModule Module => Get<ICModule>(2);
            public ROptional<ICVersion> VersionOptional => Get<ROptional<ICVersion>>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // ';'
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
            public ROptional<CImportElementList> ImportElementListOptional => Get<ROptional<CImportElementList>>(1);
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
            public ROptional<CImportNameSpecifier> ImportNameSpecifierOptional => Get<ROptional<CImportNameSpecifier>>(1);
            public ROptional<CImportElements> ImportElementsOptional => Get<ROptional<CImportElements>>(2);
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
            public ROptional<CVariadicPatternList> VariadicPatternListOptional => Get<ROptional<CVariadicPatternList>>(1);
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

            public ROptional<ICUnionType> UnionTypeOptional => Get<ROptional<ICUnionType>>(0);
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

            public ROptional<ICAssertionMessage> AssertionMessageOptional => Get<ROptional<ICAssertionMessage>>(0);
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
            public ROptional<ICArguments> ArgumentsOptional => Get<ROptional<ICArguments>>(1);
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

            public ROptional<CPackageQualifier> PackageQualifierOptional => Get<ROptional<CPackageQualifier>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
        }

        public partial class CParameters : RSequence, ICParameters
        {
            // sequence
            public CParameters(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CParameterList> ParameterListOptional => Get<ROptional<CParameterList>>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // '='
            public ICType Type => Get<ICType>(1);
        }

        public partial class CTypeConstraint : RSequence, ICTypeConstraint
        {
            // sequence
            public CTypeConstraint(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'given'
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
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ROptional<CDelegatedConstructor> DelegatedConstructorOptional => Get<ROptional<CDelegatedConstructor>>(4);
            public CBlock Block => Get<CBlock>(5);
        }

        public partial class CAliasDeclaration : RSequence, ICAliasDeclaration
        {
            // sequence
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'alias'
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
            public RLiteral Literal => Get<RLiteral>(1); // 'new'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CDelegatedConstructor> DelegatedConstructorOptional => Get<ROptional<CDelegatedConstructor>>(3);
            public CBlock Block => Get<CBlock>(4);
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'object'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(4);
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
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(5);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(6);
        }

        public partial class CVoidMethodDeclaration : RSequence, ICVoidMethodDeclaration
        {
            // sequence
            public CVoidMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'void'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(5);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(6);
        }

        public partial class CInferredMethodDeclaration : RSequence, ICInferredMethodDeclaration
        {
            // sequence
            public CInferredMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'function'
            public ICMemberName MemberName => Get<ICMemberName>(2);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(3);
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(4);
            public ROptional<CTypeConstraints> TypeConstraintsOptional => Get<ROptional<CTypeConstraints>>(5);
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

            public ROptional<ICAnySpecifier> AnySpecifierOptional => Get<ROptional<ICAnySpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'class'
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
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class CInterfaceDeclaration : RSequence, ICInterfaceDeclaration
        {
            // sequence
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'interface'
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
            public ROptional<ICExpression> ExpressionOptional => Get<ROptional<ICExpression>>(1);
        }

        public partial class CThrowStatement : RSequence, ICThrowStatement
        {
            // sequence
            public CThrowStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'throw'
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

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CStatements Statements => Get<CStatements>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CTupleExpr : RSequence, ICTupleExpr
        {
            // sequence
            public CTupleExpr(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CStructuralArguments : RSequence, ICStructuralArguments
        {
            // sequence
            public CStructuralArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public RStar<ICNamedOrAnonymous> NamedOrAnonymousStar => Get<RStar<ICNamedOrAnonymous>>(1);
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CPositionalArguments : RSequence, ICPositionalArguments
        {
            // sequence
            public CPositionalArguments(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CSequencedArguments> SequencedArgumentsOptional => Get<ROptional<CSequencedArguments>>(1);
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

        public partial class CSequencedArguments : RLoop<ICSequencedArgument>, ICSequencedArguments
        {
            // sequence
            public CSequencedArguments(params RNode[] children) : base(children) {}
        }

        public partial class CObjectArgument : RSequence, ICObjectArgument
        {
            // sequence
            public CObjectArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(2);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(3);
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

            public ROptional<CFunctionSpecifier> FunctionSpecifierOptional => Get<ROptional<CFunctionSpecifier>>(0);
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
            public ROptional<ICMemberName> MemberNameOptional => Get<ROptional<ICMemberName>>(1);
            public ROptional<CTypeParameters> TypeParametersOptional => Get<ROptional<CTypeParameters>>(2);
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
            public RPlus<CParameters> ParametersPlus => Get<RPlus<CParameters>>(1);
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
            public ROptional<CLetVariableList> LetVariableListOptional => Get<ROptional<CLetVariableList>>(2);
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

            public RPlus<CCaseExpression> CaseExpressionPlus => Get<RPlus<CCaseExpression>>(0);
            public ROptional<CElseExpression> ElseExpressionOptional => Get<ROptional<CElseExpression>>(1);
        }

        public partial class CCaseExpression : RSequence, ICCaseExpression
        {
            // sequence
            public CCaseExpression(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
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
            public RNot<RLiteral> Literal2Not => Get<RNot<RLiteral>>(1);
        }

        public partial class CNeutralOperator : RSequence, ICNeutralOperator
        {
            // sequence
            public CNeutralOperator(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '+'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'object'
            public ROptional<CExtendedType> ExtendedTypeOptional => Get<ROptional<CExtendedType>>(1);
            public ROptional<CSatisfiedTypes> SatisfiedTypesOptional => Get<ROptional<CSatisfiedTypes>>(2);
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
            public ROptional<CTypeArgumentList> TypeArgumentListOptional => Get<ROptional<CTypeArgumentList>>(1);
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
            public ROptional<CLiteralNatural> LiteralNaturalOptional => Get<ROptional<CLiteralNatural>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ']'
        }

        public partial class CFunctionType : RSequence, ICFunctionType
        {
            // sequence
            public CFunctionType(params RNode[] children) : base(children) {}

            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '('
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // ')'
        }

        public partial class CTupleType : RSequence, ICTupleType
        {
            // sequence
            public CTupleType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '['
            public ROptional<ICTypeTypeArguments> TypeTypeArgumentsOptional => Get<ROptional<ICTypeTypeArguments>>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ']'
        }

        public partial class CIterableType : RSequence, ICIterableType
        {
            // sequence
            public CIterableType(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public ROptional<ICVariadicType> VariadicTypeOptional => Get<ROptional<ICVariadicType>>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // '('
            public ROptional<CConditionList> ConditionListOptional => Get<ROptional<CConditionList>>(1);
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

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'exists'
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CNonemptyCondition : RSequence, ICNonemptyCondition
        {
            // sequence
            public CNonemptyCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'nonempty'
            public ICLetOrExpression LetOrExpression => Get<ICLetOrExpression>(2);
        }

        public partial class CIsCondition : RSequence, ICIsCondition
        {
            // sequence
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
            public RLiteral Literal2 => Get<RLiteral>(1); // 'is'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'satisfies'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'if'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlock Block => Get<CBlock>(2);
        }

        public partial class CElseBlock : RSequence, ICElseBlock
        {
            // sequence
            public CElseBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
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

            public RLiteral Literal => Get<RLiteral>(0); // 'switch'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ICSwitched Switched => Get<ICSwitched>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
        }

        public partial class CCaseBlock : RSequence, ICCaseBlock
        {
            // sequence
            public CCaseBlock(params RNode[] children) : base(children) {}

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
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

            public ROptional<RLiteral> LiteralOptional => Get<ROptional<RLiteral>>(0);
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
            public ROptional<CFailBlock> FailBlockOptional => Get<ROptional<CFailBlock>>(1);
        }

        public partial class CForBlock : RSequence, ICForBlock
        {
            // sequence
            public CForBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'for'
            public RLiteral Literal2 => Get<RLiteral>(1); // '('
            public ROptional<CForIterator> ForIteratorOptional => Get<ROptional<CForIterator>>(2);
            public RLiteral Literal3 => Get<RLiteral>(3); // ')'
            public CBlock Block => Get<CBlock>(4);
        }

        public partial class CFailBlock : RSequence, ICFailBlock
        {
            // sequence
            public CFailBlock(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'else'
            public CBlock Block => Get<CBlock>(1);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'while'
            public CConditions Conditions => Get<CConditions>(1);
            public CBlock Block => Get<CBlock>(2);
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

            public RLiteral Literal => Get<RLiteral>(0); // 'try'
            public ROptional<CResources> ResourcesOptional => Get<ROptional<CResources>>(1);
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
            public ROptional<CVariable> VariableOptional => Get<ROptional<CVariable>>(1);
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
            public ROptional<CResourceList> ResourceListOptional => Get<ROptional<CResourceList>>(1);
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

            public ROptional<ICVariableType> VariableTypeOptional => Get<ROptional<ICVariableType>>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public RStar<CParameters> ParametersStar => Get<RStar<CParameters>>(2);
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
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CPackageLiteral : RSequence, ICPackageLiteral
        {
            // sequence
            public CPackageLiteral(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'package'
            public ROptional<CPackagePath> PackagePathOptional => Get<ROptional<CPackagePath>>(1);
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

            protected virtual void Visit(CStructuralArguments element)
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
