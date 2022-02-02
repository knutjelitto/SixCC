// <generated from="D:\\Six\\Six.Ceylon\\Ceylon.six" at="02.02.2022 21:20:14" />

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
                : base(new Matcher[850])
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
                /*   9 PlainRuleOp      */ __Matchers[9] = _version = new PlainRule(this, 9, "version") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _moduleName = new PlainRule(this, 10, "module-name") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _moduleBody = new PlainRule(this, 11, "module-body") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _moduleBodyElement = new PlainRule(this, 12, "module-body-element") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _moduleImport = new PlainRule(this, 13, "module-import") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _importDeclaration = new PlainRule(this, 14, "import-declaration") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _importElements = new PlainRule(this, 15, "import-elements") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _importElementList = new PlainRule(this, 16, "import-element-list") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _importElement = new PlainRule(this, 17, "import-element") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _importNamed = new PlainRule(this, 18, "import-named") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _importName = new PlainRule(this, 19, "import-name") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _importNameSpecifier = new PlainRule(this, 20, "import-name-specifier") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _importWildcard = new PlainRule(this, 21, "import-wildcard") { Creator = node => new CImportWildcard(node) };
                /*  22 PlainRuleOp      */ __Matchers[22] = _packageName = new PlainRule(this, 22, "package-name") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _packagePath = new PlainRule(this, 23, "package-path") { Builder = nodes => nodes[0] };
                /*  24 PlainRuleOp      */ __Matchers[24] = _memberName = new PlainRule(this, 24, "member-name") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _typeName = new PlainRule(this, 25, "type-name") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _pattern = new PlainRule(this, 26, "pattern") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _entryPattern = new PlainRule(this, 27, "entry-pattern") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _variableOrTuplePattern = new PlainRule(this, 28, "variable-or-tuple-pattern") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _tuplePattern = new PlainRule(this, 29, "tuple-pattern") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _variadicPatternList = new PlainRule(this, 30, "variadic-pattern-list") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _variadicPattern = new PlainRule(this, 31, "variadic-pattern") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _variablePattern = new PlainRule(this, 32, "variable-pattern") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _variadicVariable = new PlainRule(this, 33, "variadic-variable") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _variadicOperator = new PlainRule(this, 34, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /*  35 PlainRuleOp      */ __Matchers[35] = _letStatement = new PlainRule(this, 35, "let-statement") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _letVariableList = new PlainRule(this, 36, "let-variable-list") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _letVariable = new PlainRule(this, 37, "let-variable") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _delegatedConstructor = new PlainRule(this, 38, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _assertionStatement = new PlainRule(this, 39, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _assertionMessage = new PlainRule(this, 40, "assertion-message") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _block = new PlainRule(this, 41, "block") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _extendedType = new PlainRule(this, 42, "extended-type") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _classSpecifier = new PlainRule(this, 43, "class-specifier") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _classInstantiation = new PlainRule(this, 44, "class-instantiation") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _qualifiedClass = new PlainRule(this, 45, "qualified-class") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _packageQualifiedClass = new PlainRule(this, 46, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _superQualifiedClass = new PlainRule(this, 47, "super-qualified-class") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _unQualifiedClass = new PlainRule(this, 48, "un-qualified-class") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _memberPath = new PlainRule(this, 49, "member-path") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _typePath = new PlainRule(this, 50, "type-path") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _satisfiedTypes = new PlainRule(this, 51, "satisfied-types") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _unionTypeList = new PlainRule(this, 52, "union-type-list") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _caseTypes = new PlainRule(this, 53, "case-types") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _caseTypeList = new PlainRule(this, 54, "case-type-list") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _caseType = new PlainRule(this, 55, "case-type") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _qualifiedCaseType = new PlainRule(this, 56, "qualified-case-type") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _parameters = new PlainRule(this, 57, "parameters") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _parameterList = new PlainRule(this, 58, "parameter-list") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _parameterDeclarationOrRefPattern = new PlainRule(this, 59, "parameter-declaration-or-ref-pattern") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _parameter = new PlainRule(this, 60, "parameter") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _parameterReference = new PlainRule(this, 61, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _parameterDeclaration = new PlainRule(this, 62, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _functionParameterDeclaration = new PlainRule(this, 63, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _voidFunctionParameter = new PlainRule(this, 64, "void-function-parameter") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _inferredFunctionParameter = new PlainRule(this, 65, "inferred-function-parameter") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _typedFunctionParameter = new PlainRule(this, 66, "typed-function-parameter") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _valueParameterDeclaration = new PlainRule(this, 67, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _inferredValueParameter = new PlainRule(this, 68, "inferred-value-parameter") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _typedValueParameter = new PlainRule(this, 69, "typed-value-parameter") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _typeParameters = new PlainRule(this, 70, "type-parameters") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _typeParameterList = new PlainRule(this, 71, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _typeParameter = new PlainRule(this, 72, "type-parameter") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _variance = new PlainRule(this, 73, "variance") { Creator = node => new CVariance(node) };
                /*  74 PlainRuleOp      */ __Matchers[74] = _typeDefault = new PlainRule(this, 74, "type-default") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _typeConstraint = new PlainRule(this, 75, "type-constraint") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _typeConstraints = new PlainRule(this, 76, "type-constraints") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _topDeclarations = new PlainRule(this, 77, "top-declarations") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _topDeclaration = new PlainRule(this, 78, "top-declaration") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _declaration = new PlainRule(this, 79, "declaration") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _constructorDeclaration = new PlainRule(this, 80, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _aliasDeclaration = new PlainRule(this, 81, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _enumeratedObjectDeclaration = new PlainRule(this, 82, "enumerated-object-declaration") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _objectDeclaration = new PlainRule(this, 83, "object-declaration") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _setterDeclaration = new PlainRule(this, 84, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _setterDefinition = new PlainRule(this, 85, "setter-definition") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _voidMethodDeclaration = new PlainRule(this, 86, "void-method-declaration") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _inferredMethodDeclaration = new PlainRule(this, 87, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _typedMethodDeclaration = new PlainRule(this, 88, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _methodDefinition = new PlainRule(this, 89, "method-definition") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _typedAttributeDeclaration = new PlainRule(this, 90, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _inferredAttributeDeclaration = new PlainRule(this, 91, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _attributeDefinition = new PlainRule(this, 92, "attribute-definition") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _classDeclaration = new PlainRule(this, 93, "class-declaration") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _classDefinition = new PlainRule(this, 94, "class-definition") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _optionalClassSpecifier = new PlainRule(this, 95, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _interfaceDeclaration = new PlainRule(this, 96, "interface-declaration") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _interfaceDefinition = new PlainRule(this, 97, "interface-definition") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _statements = new PlainRule(this, 98, "statements") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _statement = new PlainRule(this, 99, "statement") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _declarationStatement = new PlainRule(this, 100, "declaration-statement") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _unclosedStatement = new PlainRule(this, 101, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _openStatement = new PlainRule(this, 102, "open-statement") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _expressionStatement = new PlainRule(this, 103, "expression-statement") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _specificationStatement = new PlainRule(this, 104, "specification-statement") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _returnStatement = new PlainRule(this, 105, "return-statement") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _throwStatement = new PlainRule(this, 106, "throw-statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _breakStatement = new PlainRule(this, 107, "break-statement") { Creator = node => new CBreakStatement(node) };
                /* 108 PlainRuleOp      */ __Matchers[108] = _continueStatement = new PlainRule(this, 108, "continue-statement") { Creator = node => new CContinueStatement(node) };
                /* 109 PlainRuleOp      */ __Matchers[109] = _valueSpecifier = new PlainRule(this, 109, "value-specifier") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _functionSpecifier = new PlainRule(this, 110, "function-specifier") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _optionalFunctionSpecifier = new PlainRule(this, 111, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _requiredFunctionSpecifier = new PlainRule(this, 112, "required-function-specifier") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _typeSpecifier = new PlainRule(this, 113, "type-specifier") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _optionalTypeSpecifier = new PlainRule(this, 114, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _anySpecifier = new PlainRule(this, 115, "any-specifier") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _optionalAnySpecifier = new PlainRule(this, 116, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _baseReferenceOrParameterized = new PlainRule(this, 117, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _baseReference = new PlainRule(this, 118, "base-reference") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _parametrizedMember = new PlainRule(this, 119, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _selfParametrizedMember = new PlainRule(this, 120, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _memberReference = new PlainRule(this, 121, "member-reference") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _typeReference = new PlainRule(this, 122, "type-reference") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _selfReferenceSelector = new PlainRule(this, 123, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _selfReference = new PlainRule(this, 124, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 125 PlainRuleOp      */ __Matchers[125] = _enumerationExpr = new PlainRule(this, 125, "enumeration-expr") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _tupleExpr = new PlainRule(this, 126, "tuple-expr") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _arguments = new PlainRule(this, 127, "arguments") { Builder = nodes => nodes[0] };
                /* 128 PlainRuleOp      */ __Matchers[128] = _patternedArguments = new PlainRule(this, 128, "patterned-arguments") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _positionalArguments = new PlainRule(this, 129, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _structuredArgument = new PlainRule(this, 130, "structured-argument") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _anonymousArgument = new PlainRule(this, 131, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _namedArgument = new PlainRule(this, 132, "named-argument") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _namedSpecifiedArgument = new PlainRule(this, 133, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _sequencedArgumentList = new PlainRule(this, 134, "sequenced-argument-list") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _sequencedArgument = new PlainRule(this, 135, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _namedArgumentDeclaration = new PlainRule(this, 136, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _objectArgument = new PlainRule(this, 137, "object-argument") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _typedMethodArgument = new PlainRule(this, 138, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _inferredMethodArgument = new PlainRule(this, 139, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _untypedMethodArgument = new PlainRule(this, 140, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _typedGetterArgument = new PlainRule(this, 141, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _inferredGetterArgument = new PlainRule(this, 142, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _untypedGetterArgument = new PlainRule(this, 143, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _positionalArgument = new PlainRule(this, 144, "positional-argument") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _expressionArgument = new PlainRule(this, 145, "expression-argument") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _spreadArgument = new PlainRule(this, 146, "spread-argument") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _letExpr = new PlainRule(this, 147, "let-expr") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _switchExpr = new PlainRule(this, 148, "switch-expr") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _switchHeader = new PlainRule(this, 149, "switch-header") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _switched = new PlainRule(this, 150, "switched") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _caseExpression = new PlainRule(this, 151, "case-expression") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _ifExpr = new PlainRule(this, 152, "if-expr") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _elseExpression = new PlainRule(this, 153, "else-expression") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _thenExpression = new PlainRule(this, 154, "then-expression") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _conditionalExpression = new PlainRule(this, 155, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _functionExpression = new PlainRule(this, 156, "function-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _voidFunctionExpr = new PlainRule(this, 157, "void-function-expr") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _inferredFunctionExpr = new PlainRule(this, 158, "inferred-function-expr") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _functionDefinition = new PlainRule(this, 159, "function-definition") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _comprehensionArgument = new PlainRule(this, 160, "comprehension-argument") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _comprehensionClause = new PlainRule(this, 161, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _expressionComprehensionClause = new PlainRule(this, 162, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _forComprehensionClause = new PlainRule(this, 163, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _ifComprehensionClause = new PlainRule(this, 164, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _expression = new PlainRule(this, 165, "expression") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _operatorExpression = new PlainRule(this, 166, "operator-expression") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _assignmentExpression = new PlainRule(this, 167, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _assignmentExpr = new PlainRule(this, 168, "assignment-expr") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _assignmentOperator = new PlainRule(this, 169, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 170 PlainRuleOp      */ __Matchers[170] = _thenElseExpression = new PlainRule(this, 170, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _thenElseExpr = new PlainRule(this, 171, "then-else-expr") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _thenElseOperator = new PlainRule(this, 172, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 173 PlainRuleOp      */ __Matchers[173] = _disjunctionExpression = new PlainRule(this, 173, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _disjunctionExpr = new PlainRule(this, 174, "disjunction-expr") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _disjunctionOperator = new PlainRule(this, 175, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 176 PlainRuleOp      */ __Matchers[176] = _conjunctionExpression = new PlainRule(this, 176, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _conjunctionExpr = new PlainRule(this, 177, "conjunction-expr") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _conjunctionOperator = new PlainRule(this, 178, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 179 PlainRuleOp      */ __Matchers[179] = _logicalNegationExpression = new PlainRule(this, 179, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 180 PlainRuleOp      */ __Matchers[180] = _logicalNegationExpr = new PlainRule(this, 180, "logical-negation-expr") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _notOperator = new PlainRule(this, 181, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 182 PlainRuleOp      */ __Matchers[182] = _expressionOrMeta = new PlainRule(this, 182, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 183 PlainRuleOp      */ __Matchers[183] = _equalityExpression = new PlainRule(this, 183, "equality-expression") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _equalityExpr = new PlainRule(this, 184, "equality-expr") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _equalityOperator = new PlainRule(this, 185, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 186 PlainRuleOp      */ __Matchers[186] = _comparisonExpression = new PlainRule(this, 186, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _comparisonExpr = new PlainRule(this, 187, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _largerExpr = new PlainRule(this, 188, "larger-expr") { Builder = nodes => nodes[0] };
                /* 189 PlainRuleOp      */ __Matchers[189] = _smallerExpr = new PlainRule(this, 189, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _largerBoundsExpr = new PlainRule(this, 190, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _smallerBoundsExpr = new PlainRule(this, 191, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _typecheckExpr = new PlainRule(this, 192, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _comparisonOperator = new PlainRule(this, 193, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 194 PlainRuleOp      */ __Matchers[194] = _smallerOperator = new PlainRule(this, 194, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 195 PlainRuleOp      */ __Matchers[195] = _largerOperator = new PlainRule(this, 195, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 196 PlainRuleOp      */ __Matchers[196] = _typeOperator = new PlainRule(this, 196, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 197 PlainRuleOp      */ __Matchers[197] = _existsNonemptyExpression = new PlainRule(this, 197, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _existsExpr = new PlainRule(this, 198, "exists-expr") { Builder = nodes => nodes[0] };
                /* 199 PlainRuleOp      */ __Matchers[199] = _nonemptyExpr = new PlainRule(this, 199, "nonempty-expr") { Builder = nodes => nodes[0] };
                /* 200 PlainRuleOp      */ __Matchers[200] = _entryRangeExpression = new PlainRule(this, 200, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 201 PlainRuleOp      */ __Matchers[201] = _rangeExpr = new PlainRule(this, 201, "range-expr") { Builder = nodes => nodes[0] };
                /* 202 PlainRuleOp      */ __Matchers[202] = _entryExpr = new PlainRule(this, 202, "entry-expr") { Builder = nodes => nodes[0] };
                /* 203 PlainRuleOp      */ __Matchers[203] = _rangeOperator = new PlainRule(this, 203, "range-operator") { Creator = node => new CRangeOperator(node) };
                /* 204 PlainRuleOp      */ __Matchers[204] = _entryOperator = new PlainRule(this, 204, "entry-operator") { Creator = node => new CEntryOperator(node) };
                /* 205 PlainRuleOp      */ __Matchers[205] = _additiveExpression = new PlainRule(this, 205, "additive-expression") { Builder = nodes => nodes[0] };
                /* 206 PlainRuleOp      */ __Matchers[206] = _additiveExpr = new PlainRule(this, 206, "additive-expr") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _additiveOperator = new PlainRule(this, 207, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 208 PlainRuleOp      */ __Matchers[208] = _scaleExpression = new PlainRule(this, 208, "scale-expression") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _scaleExpr = new PlainRule(this, 209, "scale-expr") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _scaleOperator = new PlainRule(this, 210, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 211 PlainRuleOp      */ __Matchers[211] = _multiplicativeExpression = new PlainRule(this, 211, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _multiplicativeExpr = new PlainRule(this, 212, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 213 PlainRuleOp      */ __Matchers[213] = _multiplicativeOperator = new PlainRule(this, 213, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 214 PlainRuleOp      */ __Matchers[214] = _unionExpression = new PlainRule(this, 214, "union-expression") { Builder = nodes => nodes[0] };
                /* 215 PlainRuleOp      */ __Matchers[215] = _unionExpr = new PlainRule(this, 215, "union-expr") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _unionOperator = new PlainRule(this, 216, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 217 PlainRuleOp      */ __Matchers[217] = _exclusiveExpression = new PlainRule(this, 217, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 218 PlainRuleOp      */ __Matchers[218] = _exclusiveExpr = new PlainRule(this, 218, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _exclusiveOperator = new PlainRule(this, 219, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 220 PlainRuleOp      */ __Matchers[220] = _intersectionExpression = new PlainRule(this, 220, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 221 PlainRuleOp      */ __Matchers[221] = _intersectionExpr = new PlainRule(this, 221, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _intersectionOperator = new PlainRule(this, 222, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 223 PlainRuleOp      */ __Matchers[223] = _negationOrComplementExpression = new PlainRule(this, 223, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 224 PlainRuleOp      */ __Matchers[224] = _negationOrComplementExpr = new PlainRule(this, 224, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _unaryMinusOrComplementOperator = new PlainRule(this, 225, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _negateOperator = new PlainRule(this, 226, "negate-operator") { Builder = nodes => nodes[0] };
                /* 227 PlainRuleOp      */ __Matchers[227] = _neutralOperator = new PlainRule(this, 227, "neutral-operator") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _complementOperator = new PlainRule(this, 228, "complement-operator") { Creator = node => new CComplementOperator(node) };
                /* 229 PlainRuleOp      */ __Matchers[229] = _prefixExpression = new PlainRule(this, 229, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _prefixExpr = new PlainRule(this, 230, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _postfixExpression = new PlainRule(this, 231, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _postfixExpr = new PlainRule(this, 232, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _incrementOperator = new PlainRule(this, 233, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 234 PlainRuleOp      */ __Matchers[234] = _primary = new PlainRule(this, 234, "primary") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _selectionExpr = new PlainRule(this, 235, "selection-expr") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _memberSelectionOperator = new PlainRule(this, 236, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 237 PlainRuleOp      */ __Matchers[237] = _indexedExpr = new PlainRule(this, 237, "indexed-expr") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _index = new PlainRule(this, 238, "index") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _upperSpanned = new PlainRule(this, 239, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _lowerSpanned = new PlainRule(this, 240, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _spanned = new PlainRule(this, 241, "spanned") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _measured = new PlainRule(this, 242, "measured") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _indexExpression = new PlainRule(this, 243, "index-expression") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _callExpr = new PlainRule(this, 244, "call-expr") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _baseExpression = new PlainRule(this, 245, "base-expression") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _nonstringLiteral = new PlainRule(this, 246, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _stringExpression = new PlainRule(this, 247, "string-expression") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _stringInterpolation = new PlainRule(this, 248, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _interpolationPart = new PlainRule(this, 249, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _stringLiteral = new PlainRule(this, 250, "string-literal") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _objectExpr = new PlainRule(this, 251, "object-expr") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _groupedExpr = new PlainRule(this, 252, "grouped-expr") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _typeArguments = new PlainRule(this, 253, "type-arguments") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _typeArgumentList = new PlainRule(this, 254, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _variancedType = new PlainRule(this, 255, "varianced-type") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _defaultedTypeList = new PlainRule(this, 256, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _defaultedType = new PlainRule(this, 257, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _defaultedTypeCore = new PlainRule(this, 258, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _variadicType = new PlainRule(this, 259, "variadic-type") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _variadicTypeCore = new PlainRule(this, 260, "variadic-type-core") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _spreadType = new PlainRule(this, 261, "spread-type") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _type = new PlainRule(this, 262, "type") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _entryType = new PlainRule(this, 263, "entry-type") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _unionType = new PlainRule(this, 264, "union-type") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _unionTypeCore = new PlainRule(this, 265, "union-type-core") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _intersectionType = new PlainRule(this, 266, "intersection-type") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _intersectionTypeCore = new PlainRule(this, 267, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _primaryType = new PlainRule(this, 268, "primary-type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _nullableType = new PlainRule(this, 269, "nullable-type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _arrayType = new PlainRule(this, 270, "array-type") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _functionType = new PlainRule(this, 271, "function-type") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _typeTypeArguments = new PlainRule(this, 272, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _tupleType = new PlainRule(this, 273, "tuple-type") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _iterableType = new PlainRule(this, 274, "iterable-type") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _groupedType = new PlainRule(this, 275, "grouped-type") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _packageQualifiedType = new PlainRule(this, 276, "package-qualified-type") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _annotations = new PlainRule(this, 277, "annotations") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _annotation = new PlainRule(this, 278, "annotation") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _conditions = new PlainRule(this, 279, "conditions") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _conditionList = new PlainRule(this, 280, "condition-list") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _condition = new PlainRule(this, 281, "condition") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _existsCondition = new PlainRule(this, 282, "exists-condition") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _nonemptyCondition = new PlainRule(this, 283, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _letOrExpression = new PlainRule(this, 284, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _isCondition = new PlainRule(this, 285, "is-condition") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _isConditionVariable = new PlainRule(this, 286, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _satisfiesCondition = new PlainRule(this, 287, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _booleanCondition = new PlainRule(this, 288, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _controlStatement = new PlainRule(this, 289, "control-statement") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _ifElseStatement = new PlainRule(this, 290, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _elseIf = new PlainRule(this, 291, "else-if") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _elseBlock = new PlainRule(this, 292, "else-block") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _switchStatement = new PlainRule(this, 293, "switch-statement") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _caseBlock = new PlainRule(this, 294, "case-block") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _caseItem = new PlainRule(this, 295, "case-item") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _isCaseCondition = new PlainRule(this, 296, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _satisfiesCaseCondition = new PlainRule(this, 297, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _valueCaseList = new PlainRule(this, 298, "value-case-list") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _valueCaseSeparator = new PlainRule(this, 299, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 300 PlainRuleOp      */ __Matchers[300] = _valueCase = new PlainRule(this, 300, "value-case") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _forElseStatement = new PlainRule(this, 301, "for-else-statement") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _forIterator = new PlainRule(this, 302, "for-iterator") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _forVariable = new PlainRule(this, 303, "for-variable") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _containment = new PlainRule(this, 304, "containment") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _containmentOperator = new PlainRule(this, 305, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 306 PlainRuleOp      */ __Matchers[306] = _whileStatement = new PlainRule(this, 306, "while-statement") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _tryStatement = new PlainRule(this, 307, "try-statement") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _catchBlock = new PlainRule(this, 308, "catch-block") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _finallyBlock = new PlainRule(this, 309, "finally-block") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _resources = new PlainRule(this, 310, "resources") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _resourceList = new PlainRule(this, 311, "resource-list") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _resource = new PlainRule(this, 312, "resource") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _specifiedOrExpression = new PlainRule(this, 313, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 314 PlainRuleOp      */ __Matchers[314] = _specifiedVariable = new PlainRule(this, 314, "specified-variable") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _variable = new PlainRule(this, 315, "variable") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _variableType = new PlainRule(this, 316, "variable-type") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _modelReference = new PlainRule(this, 317, "model-reference") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _metaLiteral = new PlainRule(this, 318, "meta-literal") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _metaExpression = new PlainRule(this, 319, "meta-expression") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _modelExpression = new PlainRule(this, 320, "model-expression") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _memberModelExpression = new PlainRule(this, 321, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _packageQualifiedMemberReference = new PlainRule(this, 322, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _typeQualifiedMemberReference = new PlainRule(this, 323, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _typeModelExpression = new PlainRule(this, 324, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _declarationReference = new PlainRule(this, 325, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _moduleLiteral = new PlainRule(this, 326, "module-literal") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _packageLiteral = new PlainRule(this, 327, "package-literal") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _classLiteral = new PlainRule(this, 328, "class-literal") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _interfaceLiteral = new PlainRule(this, 329, "interface-literal") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _aliasLiteral = new PlainRule(this, 330, "alias-literal") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _typeParameterLiteral = new PlainRule(this, 331, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _newLiteral = new PlainRule(this, 332, "new-literal") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _valueLiteral = new PlainRule(this, 333, "value-literal") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _objectLiteral = new PlainRule(this, 334, "object-literal") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _functionLiteral = new PlainRule(this, 335, "function-literal") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _packageQualifier = new PlainRule(this, 336, "package-qualifier") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _referencePath = new PlainRule(this, 337, "reference-path") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _referencePathElementList = new PlainRule(this, 338, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _referencePathElement = new PlainRule(this, 339, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _kwVoid = new PlainRule(this, 340, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 341 PlainRuleOp      */ __Matchers[341] = _kwFunction = new PlainRule(this, 341, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 342 PlainRuleOp      */ __Matchers[342] = _kwValue = new PlainRule(this, 342, "kw-value") { Creator = node => new CKwValue(node) };
                /* 343 DfaRuleOp        */ __Matchers[343] = _literalFloat = new DfaRule(this, 343, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 344 DfaRuleOp        */ __Matchers[344] = _literalNatural = new DfaRule(this, 344, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 345 DfaRuleOp        */ __Matchers[345] = _literalChar = new DfaRule(this, 345, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 346 DfaRuleOp        */ __Matchers[346] = _stringStart = new DfaRule(this, 346, "string-start") { Creator = node => new CStringStart(node) };
                /* 347 DfaRuleOp        */ __Matchers[347] = _stringMid = new DfaRule(this, 347, "string-mid") { Creator = node => new CStringMid(node) };
                /* 348 DfaRuleOp        */ __Matchers[348] = _stringEnd = new DfaRule(this, 348, "string-end") { Creator = node => new CStringEnd(node) };
                /* 349 DfaRuleOp        */ __Matchers[349] = _literalString = new DfaRule(this, 349, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 350 DfaRuleOp        */ __Matchers[350] = _verbatimString = new DfaRule(this, 350, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 351 DfaRuleOp        */ __Matchers[351] = _lowerIdentifier = new DfaRule(this, 351, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 352 DfaRuleOp        */ __Matchers[352] = _upperIdentifier = new DfaRule(this, 352, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 353 DfaRuleOp        */ __Matchers[353] = _identifier = new DfaRule(this, 353, "identifier") { Creator = node => new CIdentifier(node) };
                /* 354 EofOp            */ __Matchers[354] = new Eof(this, 354, "<eof>") { Creator = node => new REof(node) };
                /* 355 SeqOp            */ __Matchers[355] = new Seq(this, 355, "_355:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 356 AltOp            */ __Matchers[356] = new Alt(this, 356, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /* 357 SeqOp            */ __Matchers[357] = new Seq(this, 357, "_357:(>namespace,>imports,>top-declarations)") { Builder = nodes => new CCodeUnit(nodes) };
                /* 358 StringOp         */ __Matchers[358] = new Keyword(this, 358, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /* 359 StringOp         */ __Matchers[359] = new String(this, 359, "';'", ";") { Creator = node => new RLiteral(node) };
                /* 360 SeqOp            */ __Matchers[360] = new Seq(this, 360, "_360:(>annotations,'namespace',>namespace-path,';')") { Builder = nodes => new CNamespace(nodes) };
                /* 361 StringOp         */ __Matchers[361] = new String(this, 361, "'.'", ".") { Creator = node => new RLiteral(node) };
                /* 362 SeqOp            */ __Matchers[362] = new Seq(this, 362, "_362:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /* 363 StarOp           */ __Matchers[363] = new Star(this, 363, "*(_362:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 364 SeqOp            */ __Matchers[364] = new Seq(this, 364, "_364:(>identifier,*(_362:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /* 365 StarOp           */ __Matchers[365] = new Star(this, 365, "*(>import-declaration)") { Builder = nodes => new CImports(nodes) };
                /* 366 StringOp         */ __Matchers[366] = new Keyword(this, 366, "'module'", "module") { Creator = node => new RLiteral(node) };
                /* 367 OptionalOp       */ __Matchers[367] = new Optional(this, 367, "?(>version)") { Builder = nodes => new ROptional<ICVersion>(nodes) };
                /* 368 SeqOp            */ __Matchers[368] = new Seq(this, 368, "_368:(>annotations,'module',>module-name,?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 369 StringOp         */ __Matchers[369] = new String(this, 369, "'{'", "{") { Creator = node => new RLiteral(node) };
                /* 370 StarOp           */ __Matchers[370] = new Star(this, 370, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /* 371 StringOp         */ __Matchers[371] = new String(this, 371, "'}'", "}") { Creator = node => new RLiteral(node) };
                /* 372 SeqOp            */ __Matchers[372] = new Seq(this, 372, "_372:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 373 AltOp            */ __Matchers[373] = new Alt(this, 373, "alt(>inferred-attribute-declaration|>module-import)") { Builder = nodes => nodes[0] };
                /* 374 StringOp         */ __Matchers[374] = new Keyword(this, 374, "'import'", "import") { Creator = node => new RLiteral(node) };
                /* 375 SeqOp            */ __Matchers[375] = new Seq(this, 375, "_375:(>annotations,'import',>module-name,?(>version),';')") { Builder = nodes => new CModuleImport(nodes) };
                /* 376 StringOp         */ __Matchers[376] = new Keyword(this, 376, "'package'", "package") { Creator = node => new RLiteral(node) };
                /* 377 StringOp         */ __Matchers[377] = new String(this, 377, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 378 SeqOp            */ __Matchers[378] = new Seq(this, 378, "_378:('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 379 OptionalOp       */ __Matchers[379] = new Optional(this, 379, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 380 SeqOp            */ __Matchers[380] = new Seq(this, 380, "_380:('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 381 StringOp         */ __Matchers[381] = new String(this, 381, "','", ",") { Creator = node => new RLiteral(node) };
                /* 382 SeqOp            */ __Matchers[382] = new Seq(this, 382, "_382:(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 383 StarOp           */ __Matchers[383] = new Star(this, 383, "*(_382:(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 384 SeqOp            */ __Matchers[384] = new Seq(this, 384, "_384:(>import-element,*(_382:(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 385 AltOp            */ __Matchers[385] = new Alt(this, 385, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 386 OptionalOp       */ __Matchers[386] = new Optional(this, 386, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 387 OptionalOp       */ __Matchers[387] = new Optional(this, 387, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 388 SeqOp            */ __Matchers[388] = new Seq(this, 388, "_388:(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 389 StringOp         */ __Matchers[389] = new String(this, 389, "'='", "=") { Creator = node => new RLiteral(node) };
                /* 390 SeqOp            */ __Matchers[390] = new Seq(this, 390, "_390:('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 391 StringOp         */ __Matchers[391] = new String(this, 391, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 392 SeqOp            */ __Matchers[392] = new Seq(this, 392, "_392:('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 393 StarOp           */ __Matchers[393] = new Star(this, 393, "*(_392:('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 394 SeqOp            */ __Matchers[394] = new Seq(this, 394, "_394:(>package-name,*(_392:('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 395 AltOp            */ __Matchers[395] = new Alt(this, 395, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 396 StringOp         */ __Matchers[396] = new String(this, 396, "'->'", "->") { Creator = node => new CEntryOperator(node) };
                /* 397 SeqOp            */ __Matchers[397] = new Seq(this, 397, "_397:(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 398 AltOp            */ __Matchers[398] = new Alt(this, 398, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 399 StringOp         */ __Matchers[399] = new String(this, 399, "'['", "[") { Creator = node => new RLiteral(node) };
                /* 400 OptionalOp       */ __Matchers[400] = new Optional(this, 400, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 401 StringOp         */ __Matchers[401] = new String(this, 401, "']'", "]") { Creator = node => new RLiteral(node) };
                /* 402 SeqOp            */ __Matchers[402] = new Seq(this, 402, "_402:('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 403 SeqOp            */ __Matchers[403] = new Seq(this, 403, "_403:(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 404 StarOp           */ __Matchers[404] = new Star(this, 404, "*(_403:(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 405 SeqOp            */ __Matchers[405] = new Seq(this, 405, "_405:(>variadic-pattern,*(_403:(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 406 AltOp            */ __Matchers[406] = new Alt(this, 406, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 407 OptionalOp       */ __Matchers[407] = new Optional(this, 407, "?(>union-type)") { Builder = nodes => new ROptional<ICUnionType>(nodes) };
                /* 408 SeqOp            */ __Matchers[408] = new Seq(this, 408, "_408:(?(>union-type),>variadic-operator,>member-name)") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 409 StringOp         */ __Matchers[409] = new String(this, 409, "'*'", "*") { Creator = node => new RLiteral(node) };
                /* 410 StringOp         */ __Matchers[410] = new String(this, 410, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 411 AltOp            */ __Matchers[411] = new Alt(this, 411, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 412 StringOp         */ __Matchers[412] = new Keyword(this, 412, "'let'", "let") { Creator = node => new RLiteral(node) };
                /* 413 StringOp         */ __Matchers[413] = new String(this, 413, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 414 StringOp         */ __Matchers[414] = new String(this, 414, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 415 SeqOp            */ __Matchers[415] = new Seq(this, 415, "_415:('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 416 SeqOp            */ __Matchers[416] = new Seq(this, 416, "_416:(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 417 StarOp           */ __Matchers[417] = new Star(this, 417, "*(_416:(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 418 SeqOp            */ __Matchers[418] = new Seq(this, 418, "_418:(>let-variable,*(_416:(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 419 SeqOp            */ __Matchers[419] = new Seq(this, 419, "_419:(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 420 StringOp         */ __Matchers[420] = new Keyword(this, 420, "'extends'", "extends") { Creator = node => new RLiteral(node) };
                /* 421 SeqOp            */ __Matchers[421] = new Seq(this, 421, "_421:('extends',>class-instantiation)") { Builder = nodes => new CDelegatedConstructor(nodes) };
                /* 422 OptionalOp       */ __Matchers[422] = new Optional(this, 422, "?(>assertion-message)") { Builder = nodes => new ROptional<ICAssertionMessage>(nodes) };
                /* 423 StringOp         */ __Matchers[423] = new Keyword(this, 423, "'assert'", "assert") { Creator = node => new RLiteral(node) };
                /* 424 SeqOp            */ __Matchers[424] = new Seq(this, 424, "_424:(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Seq(this, 425, "_425:('{',>imports,>statements,'}')") { Builder = nodes => new CBlock(nodes) };
                /* 426 SeqOp            */ __Matchers[426] = new Seq(this, 426, "_426:('extends',>class-instantiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 427 StringOp         */ __Matchers[427] = new String(this, 427, "'=>'", "=>") { Creator = node => new RLiteral(node) };
                /* 428 SeqOp            */ __Matchers[428] = new Seq(this, 428, "_428:('=>',>class-instantiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 429 OptionalOp       */ __Matchers[429] = new Optional(this, 429, "?(>arguments)") { Builder = nodes => new ROptional<ICArguments>(nodes) };
                /* 430 SeqOp            */ __Matchers[430] = new Seq(this, 430, "_430:(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstantiation(nodes) };
                /* 431 AltOp            */ __Matchers[431] = new Alt(this, 431, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 432 SeqOp            */ __Matchers[432] = new Seq(this, 432, "_432:('package','.',>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 433 StringOp         */ __Matchers[433] = new Keyword(this, 433, "'super'", "super") { Creator = node => new RLiteral(node) };
                /* 434 SeqOp            */ __Matchers[434] = new Seq(this, 434, "_434:('super','.',>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 435 AltOp            */ __Matchers[435] = new Alt(this, 435, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 436 SeqOp            */ __Matchers[436] = new Seq(this, 436, "_436:(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 437 SeqOp            */ __Matchers[437] = new Seq(this, 437, "_437:('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 438 StarOp           */ __Matchers[438] = new Star(this, 438, "*(_437:('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 439 SeqOp            */ __Matchers[439] = new Seq(this, 439, "_439:(>type-reference,*(_437:('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 440 StringOp         */ __Matchers[440] = new Keyword(this, 440, "'satisfies'", "satisfies") { Creator = node => new RLiteral(node) };
                /* 441 SeqOp            */ __Matchers[441] = new Seq(this, 441, "_441:('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 442 SeqOp            */ __Matchers[442] = new Seq(this, 442, "_442:(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 443 StarOp           */ __Matchers[443] = new Star(this, 443, "*(_442:(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 444 SeqOp            */ __Matchers[444] = new Seq(this, 444, "_444:(>union-type,*(_442:(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 445 StringOp         */ __Matchers[445] = new Keyword(this, 445, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 446 SeqOp            */ __Matchers[446] = new Seq(this, 446, "_446:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 447 StringOp         */ __Matchers[447] = new String(this, 447, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 448 SeqOp            */ __Matchers[448] = new Seq(this, 448, "_448:('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 449 StarOp           */ __Matchers[449] = new Star(this, 449, "*(_448:('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_450:(>case-type,*(_448:('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 451 AltOp            */ __Matchers[451] = new Alt(this, 451, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 452 OptionalOp       */ __Matchers[452] = new Optional(this, 452, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_453:(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 454 OptionalOp       */ __Matchers[454] = new Optional(this, 454, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 455 SeqOp            */ __Matchers[455] = new Seq(this, 455, "_455:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_456:(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 457 StarOp           */ __Matchers[457] = new Star(this, 457, "*(_456:(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_458:(>parameter-declaration-or-ref-pattern,*(_456:(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 459 AltOp            */ __Matchers[459] = new Alt(this, 459, "alt(>entry-pattern|>tuple-pattern|>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 460 SeqOp            */ __Matchers[460] = new Seq(this, 460, "_460:(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 461 OptionalOp       */ __Matchers[461] = new Optional(this, 461, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 462 SeqOp            */ __Matchers[462] = new Seq(this, 462, "_462:(>member-name,?(>value-specifier))") { Builder = nodes => new CParameterReference(nodes) };
                /* 463 AltOp            */ __Matchers[463] = new Alt(this, 463, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 464 AltOp            */ __Matchers[464] = new Alt(this, 464, "alt(>void-function-parameter|>inferred-function-parameter|>typed-function-parameter)") { Builder = nodes => nodes[0] };
                /* 465 StringOp         */ __Matchers[465] = new Keyword(this, 465, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 466 OptionalOp       */ __Matchers[466] = new Optional(this, 466, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 467 PlusOp           */ __Matchers[467] = new Plus(this, 467, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 468 OptionalOp       */ __Matchers[468] = new Optional(this, 468, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 469 SeqOp            */ __Matchers[469] = new Seq(this, 469, "_469:('void',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CVoidFunctionParameter(nodes) };
                /* 470 StringOp         */ __Matchers[470] = new Keyword(this, 470, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 471 SeqOp            */ __Matchers[471] = new Seq(this, 471, "_471:('function',>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CInferredFunctionParameter(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_472:(>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CTypedFunctionParameter(nodes) };
                /* 473 AltOp            */ __Matchers[473] = new Alt(this, 473, "alt(>inferred-value-parameter|>typed-value-parameter)") { Builder = nodes => nodes[0] };
                /* 474 StringOp         */ __Matchers[474] = new Keyword(this, 474, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_475:('value',>member-name,?(>value-specifier))") { Builder = nodes => new CInferredValueParameter(nodes) };
                /* 476 SeqOp            */ __Matchers[476] = new Seq(this, 476, "_476:(>variadic-type,>member-name,?(>value-specifier))") { Builder = nodes => new CTypedValueParameter(nodes) };
                /* 477 StringOp         */ __Matchers[477] = new String(this, 477, "'<'", "<") { Creator = node => new RLiteral(node) };
                /* 478 StringOp         */ __Matchers[478] = new String(this, 478, "'>'", ">") { Creator = node => new RLiteral(node) };
                /* 479 SeqOp            */ __Matchers[479] = new Seq(this, 479, "_479:('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_480:(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 481 StarOp           */ __Matchers[481] = new Star(this, 481, "*(_480:(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 482 SeqOp            */ __Matchers[482] = new Seq(this, 482, "_482:(>type-parameter,*(_480:(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 483 OptionalOp       */ __Matchers[483] = new Optional(this, 483, "?(>variance)") { Builder = nodes => new ROptional<ICVariance>(nodes) };
                /* 484 OptionalOp       */ __Matchers[484] = new Optional(this, 484, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 485 SeqOp            */ __Matchers[485] = new Seq(this, 485, "_485:(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 486 StringOp         */ __Matchers[486] = new Keyword(this, 486, "'in'", "in") { Creator = node => new RLiteral(node) };
                /* 487 StringOp         */ __Matchers[487] = new Keyword(this, 487, "'out'", "out") { Creator = node => new RLiteral(node) };
                /* 488 AltOp            */ __Matchers[488] = new Alt(this, 488, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 489 SeqOp            */ __Matchers[489] = new Seq(this, 489, "_489:('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 490 StringOp         */ __Matchers[490] = new Keyword(this, 490, "'given'", "given") { Creator = node => new RLiteral(node) };
                /* 491 OptionalOp       */ __Matchers[491] = new Optional(this, 491, "?(>type-name)") { Builder = nodes => new ROptional<ICTypeName>(nodes) };
                /* 492 OptionalOp       */ __Matchers[492] = new Optional(this, 492, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 493 OptionalOp       */ __Matchers[493] = new Optional(this, 493, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 494 SeqOp            */ __Matchers[494] = new Seq(this, 494, "_494:('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 495 PlusOp           */ __Matchers[495] = new Plus(this, 495, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 496 StarOp           */ __Matchers[496] = new Star(this, 496, "*(>top-declaration)") { Builder = nodes => new CTopDeclarations(nodes) };
                /* 497 AltOp            */ __Matchers[497] = new Alt(this, 497, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 498 AltOp            */ __Matchers[498] = new Alt(this, 498, "alt(>class-declaration|>interface-declaration|>alias-declaration|>object-declaration|>constructor-declaration|>enumerated-object-declaration|>setter-declaration|>typed-method-declaration|>void-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 499 StringOp         */ __Matchers[499] = new Keyword(this, 499, "'new'", "new") { Creator = node => new RLiteral(node) };
                /* 500 OptionalOp       */ __Matchers[500] = new Optional(this, 500, "?(>member-name)") { Builder = nodes => new ROptional<ICMemberName>(nodes) };
                /* 501 OptionalOp       */ __Matchers[501] = new Optional(this, 501, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 502 SeqOp            */ __Matchers[502] = new Seq(this, 502, "_502:(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 503 StringOp         */ __Matchers[503] = new Keyword(this, 503, "'alias'", "alias") { Creator = node => new RLiteral(node) };
                /* 504 OptionalOp       */ __Matchers[504] = new Optional(this, 504, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 505 SeqOp            */ __Matchers[505] = new Seq(this, 505, "_505:(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 506 SeqOp            */ __Matchers[506] = new Seq(this, 506, "_506:(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObjectDeclaration(nodes) };
                /* 507 StringOp         */ __Matchers[507] = new Keyword(this, 507, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 508 OptionalOp       */ __Matchers[508] = new Optional(this, 508, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 509 SeqOp            */ __Matchers[509] = new Seq(this, 509, "_509:(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 510 StringOp         */ __Matchers[510] = new Keyword(this, 510, "'assign'", "assign") { Creator = node => new RLiteral(node) };
                /* 511 SeqOp            */ __Matchers[511] = new Seq(this, 511, "_511:(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 512 AltOp            */ __Matchers[512] = new Alt(this, 512, "alt(>block|>required-function-specifier)") { Builder = nodes => nodes[0] };
                /* 513 SeqOp            */ __Matchers[513] = new Seq(this, 513, "_513:(>annotations,'void',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CVoidMethodDeclaration(nodes) };
                /* 514 SeqOp            */ __Matchers[514] = new Seq(this, 514, "_514:(>annotations,'function',>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 515 SeqOp            */ __Matchers[515] = new Seq(this, 515, "_515:(>annotations,>variadic-type,>member-name,?(>type-parameters),+(>parameters),?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 516 AltOp            */ __Matchers[516] = new Alt(this, 516, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 517 SeqOp            */ __Matchers[517] = new Seq(this, 517, "_517:(>annotations,>variadic-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 518 SeqOp            */ __Matchers[518] = new Seq(this, 518, "_518:(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 519 AltOp            */ __Matchers[519] = new Alt(this, 519, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 520 StringOp         */ __Matchers[520] = new Keyword(this, 520, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 521 OptionalOp       */ __Matchers[521] = new Optional(this, 521, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 522 SeqOp            */ __Matchers[522] = new Seq(this, 522, "_522:(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 523 AltOp            */ __Matchers[523] = new Alt(this, 523, "alt(>block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 524 OptionalOp       */ __Matchers[524] = new Optional(this, 524, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 525 SeqOp            */ __Matchers[525] = new Seq(this, 525, "_525:(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 526 StringOp         */ __Matchers[526] = new Keyword(this, 526, "'interface'", "interface") { Creator = node => new RLiteral(node) };
                /* 527 SeqOp            */ __Matchers[527] = new Seq(this, 527, "_527:(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 528 AltOp            */ __Matchers[528] = new Alt(this, 528, "alt(>block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 529 StarOp           */ __Matchers[529] = new Star(this, 529, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 530 AltOp            */ __Matchers[530] = new Alt(this, 530, "alt(>declaration-statement|>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 531 SeqOp            */ __Matchers[531] = new Seq(this, 531, "_531:(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 532 AltOp            */ __Matchers[532] = new Alt(this, 532, "alt(>return-statement|>throw-statement|>break-statement|>continue-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 533 SeqOp            */ __Matchers[533] = new Seq(this, 533, "_533:(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 534 StringOp         */ __Matchers[534] = new Keyword(this, 534, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 535 OptionalOp       */ __Matchers[535] = new Optional(this, 535, "?(>expression)") { Builder = nodes => new ROptional<ICExpression>(nodes) };
                /* 536 SeqOp            */ __Matchers[536] = new Seq(this, 536, "_536:('return',?(>expression))") { Builder = nodes => new CReturnStatement(nodes) };
                /* 537 StringOp         */ __Matchers[537] = new Keyword(this, 537, "'throw'", "throw") { Creator = node => new RLiteral(node) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_538:('throw',?(>expression))") { Builder = nodes => new CThrowStatement(nodes) };
                /* 539 StringOp         */ __Matchers[539] = new Keyword(this, 539, "'break'", "break") { Creator = node => new CBreakStatement(node) };
                /* 540 StringOp         */ __Matchers[540] = new Keyword(this, 540, "'continue'", "continue") { Creator = node => new CContinueStatement(node) };
                /* 541 SeqOp            */ __Matchers[541] = new Seq(this, 541, "_541:('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 542 SeqOp            */ __Matchers[542] = new Seq(this, 542, "_542:('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 543 SeqOp            */ __Matchers[543] = new Seq(this, 543, "_543:(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 544 SeqOp            */ __Matchers[544] = new Seq(this, 544, "_544:(>function-specifier,';')") { Builder = nodes => new CRequiredFunctionSpecifier(nodes) };
                /* 545 SeqOp            */ __Matchers[545] = new Seq(this, 545, "_545:('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 546 OptionalOp       */ __Matchers[546] = new Optional(this, 546, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 547 SeqOp            */ __Matchers[547] = new Seq(this, 547, "_547:(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 548 AltOp            */ __Matchers[548] = new Alt(this, 548, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 549 OptionalOp       */ __Matchers[549] = new Optional(this, 549, "?(>any-specifier)") { Builder = nodes => new ROptional<ICAnySpecifier>(nodes) };
                /* 550 SeqOp            */ __Matchers[550] = new Seq(this, 550, "_550:(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 551 AltOp            */ __Matchers[551] = new Alt(this, 551, "alt(>base-reference|>self-reference|>parametrized-member|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 552 AltOp            */ __Matchers[552] = new Alt(this, 552, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 553 SeqOp            */ __Matchers[553] = new Seq(this, 553, "_553:(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 554 SeqOp            */ __Matchers[554] = new Seq(this, 554, "_554:(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 555 OptionalOp       */ __Matchers[555] = new Optional(this, 555, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 556 SeqOp            */ __Matchers[556] = new Seq(this, 556, "_556:(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 557 SeqOp            */ __Matchers[557] = new Seq(this, 557, "_557:(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 558 SeqOp            */ __Matchers[558] = new Seq(this, 558, "_558:(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 559 StringOp         */ __Matchers[559] = new Keyword(this, 559, "'this'", "this") { Creator = node => new RLiteral(node) };
                /* 560 StringOp         */ __Matchers[560] = new Keyword(this, 560, "'outer'", "outer") { Creator = node => new RLiteral(node) };
                /* 561 AltOp            */ __Matchers[561] = new Alt(this, 561, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 562 OptionalOp       */ __Matchers[562] = new Optional(this, 562, "?(>sequenced-argument-list)") { Builder = nodes => new ROptional<CSequencedArgumentList>(nodes) };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_563:('{',>statements,?(>sequenced-argument-list),'}')") { Builder = nodes => new CEnumerationExpr(nodes) };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_564:('[',?(>sequenced-argument-list),']')") { Builder = nodes => new CTupleExpr(nodes) };
                /* 565 AltOp            */ __Matchers[565] = new Alt(this, 565, "alt(>patterned-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 566 StarOp           */ __Matchers[566] = new Star(this, 566, "*(>structured-argument)") { Builder = nodes => new RStar<ICStructuredArgument>(nodes) };
                /* 567 SeqOp            */ __Matchers[567] = new Seq(this, 567, "_567:('{',*(>structured-argument),?(>sequenced-argument-list),'}')") { Builder = nodes => new CPatternedArguments(nodes) };
                /* 568 SeqOp            */ __Matchers[568] = new Seq(this, 568, "_568:('(',?(>sequenced-argument-list),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 569 AltOp            */ __Matchers[569] = new Alt(this, 569, "alt(>anonymous-argument|>named-argument)") { Builder = nodes => nodes[0] };
                /* 570 SeqOp            */ __Matchers[570] = new Seq(this, 570, "_570:(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 571 AltOp            */ __Matchers[571] = new Alt(this, 571, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 572 SeqOp            */ __Matchers[572] = new Seq(this, 572, "_572:(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 573 SeqOp            */ __Matchers[573] = new Seq(this, 573, "_573:(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 574 StarOp           */ __Matchers[574] = new Star(this, 574, "*(_573:(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 575 SeqOp            */ __Matchers[575] = new Seq(this, 575, "_575:(>sequenced-argument,*(_573:(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArgumentList(nodes) };
                /* 576 AltOp            */ __Matchers[576] = new Alt(this, 576, "alt(>comprehension-argument|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 577 AltOp            */ __Matchers[577] = new Alt(this, 577, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 578 SeqOp            */ __Matchers[578] = new Seq(this, 578, "_578:('object',?(>member-name),?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_579:(>type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_580:('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 581 SeqOp            */ __Matchers[581] = new Seq(this, 581, "_581:(>member-name,+(>parameters),>required-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 582 SeqOp            */ __Matchers[582] = new Seq(this, 582, "_582:(>type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 583 SeqOp            */ __Matchers[583] = new Seq(this, 583, "_583:('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_584:(>member-name,>required-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 585 AltOp            */ __Matchers[585] = new Alt(this, 585, "alt(>expression-argument|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 586 SeqOp            */ __Matchers[586] = new Seq(this, 586, "_586:('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 587 OptionalOp       */ __Matchers[587] = new Optional(this, 587, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 588 SeqOp            */ __Matchers[588] = new Seq(this, 588, "_588:('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpr(nodes) };
                /* 589 PlusOp           */ __Matchers[589] = new Plus(this, 589, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 590 OptionalOp       */ __Matchers[590] = new Optional(this, 590, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 591 SeqOp            */ __Matchers[591] = new Seq(this, 591, "_591:(>switch-header,+(>case-expression),?(>else-expression))") { Builder = nodes => new CSwitchExpr(nodes) };
                /* 592 StringOp         */ __Matchers[592] = new Keyword(this, 592, "'switch'", "switch") { Creator = node => new RLiteral(node) };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_593:('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 594 StringOp         */ __Matchers[594] = new Keyword(this, 594, "'else'", "else") { Creator = node => new RLiteral(node) };
                /* 595 OptionalOp       */ __Matchers[595] = new Optional(this, 595, "?('else')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 596 StringOp         */ __Matchers[596] = new Keyword(this, 596, "'case'", "case") { Creator = node => new RLiteral(node) };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_597:(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 598 StringOp         */ __Matchers[598] = new Keyword(this, 598, "'if'", "if") { Creator = node => new RLiteral(node) };
                /* 599 SeqOp            */ __Matchers[599] = new Seq(this, 599, "_599:('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpr(nodes) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_600:('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 601 StringOp         */ __Matchers[601] = new Keyword(this, 601, "'then'", "then") { Creator = node => new RLiteral(node) };
                /* 602 SeqOp            */ __Matchers[602] = new Seq(this, 602, "_602:('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 603 AltOp            */ __Matchers[603] = new Alt(this, 603, "alt(>if-expr|>let-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 604 AltOp            */ __Matchers[604] = new Alt(this, 604, "alt(>void-function-expr|>inferred-function-expr)") { Builder = nodes => nodes[0] };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_605:('void',?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CVoidFunctionExpr(nodes) };
                /* 606 OptionalOp       */ __Matchers[606] = new Optional(this, 606, "?('function')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_607:(?('function'),?(>type-parameters),+(>parameters),?(>type-constraints),>function-definition)") { Builder = nodes => new CInferredFunctionExpr(nodes) };
                /* 608 AltOp            */ __Matchers[608] = new Alt(this, 608, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 609 AltOp            */ __Matchers[609] = new Alt(this, 609, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 610 AltOp            */ __Matchers[610] = new Alt(this, 610, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 611 StringOp         */ __Matchers[611] = new Keyword(this, 611, "'for'", "for") { Creator = node => new RLiteral(node) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 613 SeqOp            */ __Matchers[613] = new Seq(this, 613, "_613:('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_614:('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 615 AltOp            */ __Matchers[615] = new Alt(this, 615, "alt(>let-expr|>if-expr|>switch-expr|>function-expression|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 616 AltOp            */ __Matchers[616] = new Alt(this, 616, "alt(>assignment-expr|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_617:(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignmentExpr(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new String(this, 618, "'+='", "+=") { Creator = node => new RLiteral(node) };
                /* 619 StringOp         */ __Matchers[619] = new String(this, 619, "'-='", "-=") { Creator = node => new RLiteral(node) };
                /* 620 StringOp         */ __Matchers[620] = new String(this, 620, "'*='", "*=") { Creator = node => new RLiteral(node) };
                /* 621 StringOp         */ __Matchers[621] = new String(this, 621, "'/='", "/=") { Creator = node => new RLiteral(node) };
                /* 622 StringOp         */ __Matchers[622] = new String(this, 622, "'%='", "%=") { Creator = node => new RLiteral(node) };
                /* 623 StringOp         */ __Matchers[623] = new String(this, 623, "'&='", "&=") { Creator = node => new RLiteral(node) };
                /* 624 StringOp         */ __Matchers[624] = new String(this, 624, "'|='", "|=") { Creator = node => new RLiteral(node) };
                /* 625 StringOp         */ __Matchers[625] = new String(this, 625, "'^='", "^=") { Creator = node => new RLiteral(node) };
                /* 626 StringOp         */ __Matchers[626] = new String(this, 626, "'~='", "~=") { Creator = node => new RLiteral(node) };
                /* 627 StringOp         */ __Matchers[627] = new String(this, 627, "'&&='", "&&=") { Creator = node => new RLiteral(node) };
                /* 628 StringOp         */ __Matchers[628] = new String(this, 628, "'||='", "||=") { Creator = node => new RLiteral(node) };
                /* 629 AltOp            */ __Matchers[629] = new Alt(this, 629, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 630 AltOp            */ __Matchers[630] = new Alt(this, 630, "alt(>then-else-expr|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 631 SeqOp            */ __Matchers[631] = new Seq(this, 631, "_631:(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElseExpr(nodes) };
                /* 632 AltOp            */ __Matchers[632] = new Alt(this, 632, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 633 AltOp            */ __Matchers[633] = new Alt(this, 633, "alt(>disjunction-expr|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 634 SeqOp            */ __Matchers[634] = new Seq(this, 634, "_634:(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunctionExpr(nodes) };
                /* 635 StringOp         */ __Matchers[635] = new String(this, 635, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 636 AltOp            */ __Matchers[636] = new Alt(this, 636, "alt(>conjunction-expr|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 637 SeqOp            */ __Matchers[637] = new Seq(this, 637, "_637:(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunctionExpr(nodes) };
                /* 638 StringOp         */ __Matchers[638] = new String(this, 638, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 639 AltOp            */ __Matchers[639] = new Alt(this, 639, "alt(>logical-negation-expr|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 640 SeqOp            */ __Matchers[640] = new Seq(this, 640, "_640:(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegationExpr(nodes) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 642 AltOp            */ __Matchers[642] = new Alt(this, 642, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 643 AltOp            */ __Matchers[643] = new Alt(this, 643, "alt(>equality-expr|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 644 SeqOp            */ __Matchers[644] = new Seq(this, 644, "_644:(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEqualityExpr(nodes) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'=='", "==") { Creator = node => new RLiteral(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'!='", "!=") { Creator = node => new RLiteral(node) };
                /* 647 StringOp         */ __Matchers[647] = new String(this, 647, "'==='", "===") { Creator = node => new RLiteral(node) };
                /* 648 AltOp            */ __Matchers[648] = new Alt(this, 648, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 649 AltOp            */ __Matchers[649] = new Alt(this, 649, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 650 SeqOp            */ __Matchers[650] = new Seq(this, 650, "_650:(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 651 SeqOp            */ __Matchers[651] = new Seq(this, 651, "_651:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 652 SeqOp            */ __Matchers[652] = new Seq(this, 652, "_652:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 653 SeqOp            */ __Matchers[653] = new Seq(this, 653, "_653:(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 654 SeqOp            */ __Matchers[654] = new Seq(this, 654, "_654:(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 655 SeqOp            */ __Matchers[655] = new Seq(this, 655, "_655:(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 656 StringOp         */ __Matchers[656] = new String(this, 656, "'<=>'", "<=>") { Creator = node => new RLiteral(node) };
                /* 657 AltOp            */ __Matchers[657] = new Alt(this, 657, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 658 StringOp         */ __Matchers[658] = new String(this, 658, "'<='", "<=") { Creator = node => new RLiteral(node) };
                /* 659 AltOp            */ __Matchers[659] = new Alt(this, 659, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 660 StringOp         */ __Matchers[660] = new String(this, 660, "'>='", ">=") { Creator = node => new RLiteral(node) };
                /* 661 AltOp            */ __Matchers[661] = new Alt(this, 661, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 662 StringOp         */ __Matchers[662] = new Keyword(this, 662, "'is'", "is") { Creator = node => new RLiteral(node) };
                /* 663 AltOp            */ __Matchers[663] = new Alt(this, 663, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 664 AltOp            */ __Matchers[664] = new Alt(this, 664, "alt(>exists-expr|>nonempty-expr|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 665 StringOp         */ __Matchers[665] = new Keyword(this, 665, "'exists'", "exists") { Creator = node => new RLiteral(node) };
                /* 666 SeqOp            */ __Matchers[666] = new Seq(this, 666, "_666:(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpr(nodes) };
                /* 667 StringOp         */ __Matchers[667] = new Keyword(this, 667, "'nonempty'", "nonempty") { Creator = node => new RLiteral(node) };
                /* 668 SeqOp            */ __Matchers[668] = new Seq(this, 668, "_668:(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpr(nodes) };
                /* 669 AltOp            */ __Matchers[669] = new Alt(this, 669, "alt(>range-expr|>entry-expr|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 670 SeqOp            */ __Matchers[670] = new Seq(this, 670, "_670:(>additive-expression,>range-operator,>additive-expression)") { Builder = nodes => new CRangeExpr(nodes) };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_671:(>additive-expression,>entry-operator,>additive-expression)") { Builder = nodes => new CEntryExpr(nodes) };
                /* 672 StringOp         */ __Matchers[672] = new String(this, 672, "'..'", "..") { Creator = node => new RLiteral(node) };
                /* 673 AltOp            */ __Matchers[673] = new Alt(this, 673, "alt('..'|':')") { Builder = nodes => nodes[0] };
                /* 674 AltOp            */ __Matchers[674] = new Alt(this, 674, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 675 SeqOp            */ __Matchers[675] = new Seq(this, 675, "_675:(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 676 StringOp         */ __Matchers[676] = new String(this, 676, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 677 AltOp            */ __Matchers[677] = new Alt(this, 677, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 678 AltOp            */ __Matchers[678] = new Alt(this, 678, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 679 SeqOp            */ __Matchers[679] = new Seq(this, 679, "_679:(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 680 StringOp         */ __Matchers[680] = new String(this, 680, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 681 AltOp            */ __Matchers[681] = new Alt(this, 681, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 682 SeqOp            */ __Matchers[682] = new Seq(this, 682, "_682:(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 683 StringOp         */ __Matchers[683] = new String(this, 683, "'/'", "/") { Creator = node => new RLiteral(node) };
                /* 684 StringOp         */ __Matchers[684] = new String(this, 684, "'%'", "%") { Creator = node => new RLiteral(node) };
                /* 685 AltOp            */ __Matchers[685] = new Alt(this, 685, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 686 AltOp            */ __Matchers[686] = new Alt(this, 686, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 687 SeqOp            */ __Matchers[687] = new Seq(this, 687, "_687:(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 688 StringOp         */ __Matchers[688] = new String(this, 688, "'~'", "~") { Creator = node => new CComplementOperator(node) };
                /* 689 AltOp            */ __Matchers[689] = new Alt(this, 689, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 690 AltOp            */ __Matchers[690] = new Alt(this, 690, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 691 SeqOp            */ __Matchers[691] = new Seq(this, 691, "_691:(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 692 StringOp         */ __Matchers[692] = new String(this, 692, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 693 AltOp            */ __Matchers[693] = new Alt(this, 693, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 694 SeqOp            */ __Matchers[694] = new Seq(this, 694, "_694:(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 695 StringOp         */ __Matchers[695] = new String(this, 695, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 696 AltOp            */ __Matchers[696] = new Alt(this, 696, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 697 SeqOp            */ __Matchers[697] = new Seq(this, 697, "_697:(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 698 AltOp            */ __Matchers[698] = new Alt(this, 698, "alt(>negate-operator|>neutral-operator|>complement-operator)") { Builder = nodes => nodes[0] };
                /* 699 NotOp            */ __Matchers[699] = new Not(this, 699, "!('-')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 700 SeqOp            */ __Matchers[700] = new Seq(this, 700, "_700:('-',!('-'))") { Builder = nodes => new CNegateOperator(nodes) };
                /* 701 NotOp            */ __Matchers[701] = new Not(this, 701, "!('+')") { Builder = nodes => new RNot<RLiteral>(nodes) };
                /* 702 SeqOp            */ __Matchers[702] = new Seq(this, 702, "_702:('+',!('+'))") { Builder = nodes => new CNeutralOperator(nodes) };
                /* 703 AltOp            */ __Matchers[703] = new Alt(this, 703, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 704 SeqOp            */ __Matchers[704] = new Seq(this, 704, "_704:(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 705 AltOp            */ __Matchers[705] = new Alt(this, 705, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 706 SeqOp            */ __Matchers[706] = new Seq(this, 706, "_706:(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 707 StringOp         */ __Matchers[707] = new String(this, 707, "'++'", "++") { Creator = node => new RLiteral(node) };
                /* 708 StringOp         */ __Matchers[708] = new String(this, 708, "'--'", "--") { Creator = node => new RLiteral(node) };
                /* 709 AltOp            */ __Matchers[709] = new Alt(this, 709, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 710 AltOp            */ __Matchers[710] = new Alt(this, 710, "alt(>selection-expr|>indexed-expr|>call-expr|>base-expression)") { Builder = nodes => nodes[0] };
                /* 711 SeqOp            */ __Matchers[711] = new Seq(this, 711, "_711:(>primary,>member-selection-operator,>base-reference)") { Builder = nodes => new CSelectionExpr(nodes) };
                /* 712 StringOp         */ __Matchers[712] = new String(this, 712, "'?.'", "?.") { Creator = node => new RLiteral(node) };
                /* 713 StringOp         */ __Matchers[713] = new String(this, 713, "'*.'", "*.") { Creator = node => new RLiteral(node) };
                /* 714 AltOp            */ __Matchers[714] = new Alt(this, 714, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 715 SeqOp            */ __Matchers[715] = new Seq(this, 715, "_715:(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpr(nodes) };
                /* 716 AltOp            */ __Matchers[716] = new Alt(this, 716, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 717 SeqOp            */ __Matchers[717] = new Seq(this, 717, "_717:(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 718 SeqOp            */ __Matchers[718] = new Seq(this, 718, "_718:('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 719 SeqOp            */ __Matchers[719] = new Seq(this, 719, "_719:(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 720 SeqOp            */ __Matchers[720] = new Seq(this, 720, "_720:(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_721:(>primary,>arguments)") { Builder = nodes => new CCallExpr(nodes) };
                /* 722 AltOp            */ __Matchers[722] = new Alt(this, 722, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration-expr|>tuple-expr|>object-expr|>grouped-expr|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 723 AltOp            */ __Matchers[723] = new Alt(this, 723, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 724 AltOp            */ __Matchers[724] = new Alt(this, 724, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 725 StarOp           */ __Matchers[725] = new Star(this, 725, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 726 SeqOp            */ __Matchers[726] = new Seq(this, 726, "_726:(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 727 SeqOp            */ __Matchers[727] = new Seq(this, 727, "_727:(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 728 AltOp            */ __Matchers[728] = new Alt(this, 728, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 729 SeqOp            */ __Matchers[729] = new Seq(this, 729, "_729:('object',?(>extended-type),?(>satisfied-types),>block)") { Builder = nodes => new CObjectExpr(nodes) };
                /* 730 SeqOp            */ __Matchers[730] = new Seq(this, 730, "_730:('(',>expression,')')") { Builder = nodes => new CGroupedExpr(nodes) };
                /* 731 OptionalOp       */ __Matchers[731] = new Optional(this, 731, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 732 SeqOp            */ __Matchers[732] = new Seq(this, 732, "_732:('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 733 SeqOp            */ __Matchers[733] = new Seq(this, 733, "_733:(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 734 StarOp           */ __Matchers[734] = new Star(this, 734, "*(_733:(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 735 SeqOp            */ __Matchers[735] = new Seq(this, 735, "_735:(>varianced-type,*(_733:(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 736 SeqOp            */ __Matchers[736] = new Seq(this, 736, "_736:(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_737:(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 738 StarOp           */ __Matchers[738] = new Star(this, 738, "*(_737:(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_739:(>defaulted-type,*(_737:(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 740 AltOp            */ __Matchers[740] = new Alt(this, 740, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_741:(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 742 AltOp            */ __Matchers[742] = new Alt(this, 742, "alt(>variadic-type-core|>type)") { Builder = nodes => nodes[0] };
                /* 743 SeqOp            */ __Matchers[743] = new Seq(this, 743, "_743:(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicTypeCore(nodes) };
                /* 744 SeqOp            */ __Matchers[744] = new Seq(this, 744, "_744:('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 745 AltOp            */ __Matchers[745] = new Alt(this, 745, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 746 SeqOp            */ __Matchers[746] = new Seq(this, 746, "_746:(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 747 AltOp            */ __Matchers[747] = new Alt(this, 747, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_748:(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 749 AltOp            */ __Matchers[749] = new Alt(this, 749, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_750:(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 751 AltOp            */ __Matchers[751] = new Alt(this, 751, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>package-qualified-type|>type-path)") { Builder = nodes => nodes[0] };
                /* 752 StringOp         */ __Matchers[752] = new String(this, 752, "'?'", "?") { Creator = node => new RLiteral(node) };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_753:(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 754 OptionalOp       */ __Matchers[754] = new Optional(this, 754, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_755:(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 756 OptionalOp       */ __Matchers[756] = new Optional(this, 756, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ICTypeTypeArguments>(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_757:(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 758 AltOp            */ __Matchers[758] = new Alt(this, 758, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_759:('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 760 OptionalOp       */ __Matchers[760] = new Optional(this, 760, "?(>variadic-type)") { Builder = nodes => new ROptional<ICVariadicType>(nodes) };
                /* 761 SeqOp            */ __Matchers[761] = new Seq(this, 761, "_761:('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 762 SeqOp            */ __Matchers[762] = new Seq(this, 762, "_762:('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 763 SeqOp            */ __Matchers[763] = new Seq(this, 763, "_763:('package','.',>type-path)") { Builder = nodes => new CPackageQualifiedType(nodes) };
                /* 764 OptionalOp       */ __Matchers[764] = new Optional(this, 764, "?(>string-literal)") { Builder = nodes => new ROptional<ICStringLiteral>(nodes) };
                /* 765 StarOp           */ __Matchers[765] = new Star(this, 765, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 766 SeqOp            */ __Matchers[766] = new Seq(this, 766, "_766:(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_767:(>member-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 768 OptionalOp       */ __Matchers[768] = new Optional(this, 768, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_769:('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 770 SeqOp            */ __Matchers[770] = new Seq(this, 770, "_770:(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 771 StarOp           */ __Matchers[771] = new Star(this, 771, "*(_770:(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 772 SeqOp            */ __Matchers[772] = new Seq(this, 772, "_772:(>condition,*(_770:(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 773 AltOp            */ __Matchers[773] = new Alt(this, 773, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 774 OptionalOp       */ __Matchers[774] = new Optional(this, 774, "?('!')") { Builder = nodes => new ROptional<RLiteral>(nodes) };
                /* 775 SeqOp            */ __Matchers[775] = new Seq(this, 775, "_775:(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 776 SeqOp            */ __Matchers[776] = new Seq(this, 776, "_776:(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 777 AltOp            */ __Matchers[777] = new Alt(this, 777, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_778:(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 779 SeqOp            */ __Matchers[779] = new Seq(this, 779, "_779:(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 780 SeqOp            */ __Matchers[780] = new Seq(this, 780, "_780:('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 781 AltOp            */ __Matchers[781] = new Alt(this, 781, "alt(>if-else-statement|>for-else-statement|>switch-statement|>while-statement|>try-statement)") { Builder = nodes => nodes[0] };
                /* 782 StarOp           */ __Matchers[782] = new Star(this, 782, "*(>else-if)") { Builder = nodes => new RStar<CElseIf>(nodes) };
                /* 783 OptionalOp       */ __Matchers[783] = new Optional(this, 783, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 784 SeqOp            */ __Matchers[784] = new Seq(this, 784, "_784:('if',>conditions,>block,*(>else-if),?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 785 SeqOp            */ __Matchers[785] = new Seq(this, 785, "_785:('else','if',>conditions,>block)") { Builder = nodes => new CElseIf(nodes) };
                /* 786 SeqOp            */ __Matchers[786] = new Seq(this, 786, "_786:('else',>block)") { Builder = nodes => new CElseBlock(nodes) };
                /* 787 PlusOp           */ __Matchers[787] = new Plus(this, 787, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 788 SeqOp            */ __Matchers[788] = new Seq(this, 788, "_788:(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchStatement(nodes) };
                /* 789 SeqOp            */ __Matchers[789] = new Seq(this, 789, "_789:(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 790 AltOp            */ __Matchers[790] = new Alt(this, 790, "alt(>is-case-condition|>satisfies-case-condition|>value-case-list|>pattern)") { Builder = nodes => nodes[0] };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_791:('is',>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 792 SeqOp            */ __Matchers[792] = new Seq(this, 792, "_792:('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 793 SeqOp            */ __Matchers[793] = new Seq(this, 793, "_793:(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 794 StarOp           */ __Matchers[794] = new Star(this, 794, "*(_793:(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 795 SeqOp            */ __Matchers[795] = new Seq(this, 795, "_795:(>value-case,*(_793:(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 796 AltOp            */ __Matchers[796] = new Alt(this, 796, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 797 AltOp            */ __Matchers[797] = new Alt(this, 797, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 798 SeqOp            */ __Matchers[798] = new Seq(this, 798, "_798:('for','(',?(>for-iterator),')',>block,?(>else-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_799:(>for-variable,>containment)") { Builder = nodes => new CForIterator(nodes) };
                /* 800 SeqOp            */ __Matchers[800] = new Seq(this, 800, "_800:(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 801 AltOp            */ __Matchers[801] = new Alt(this, 801, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 802 StringOp         */ __Matchers[802] = new Keyword(this, 802, "'while'", "while") { Creator = node => new RLiteral(node) };
                /* 803 SeqOp            */ __Matchers[803] = new Seq(this, 803, "_803:('while',>conditions,>block)") { Builder = nodes => new CWhileStatement(nodes) };
                /* 804 StringOp         */ __Matchers[804] = new Keyword(this, 804, "'try'", "try") { Creator = node => new RLiteral(node) };
                /* 805 OptionalOp       */ __Matchers[805] = new Optional(this, 805, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 806 StarOp           */ __Matchers[806] = new Star(this, 806, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 807 OptionalOp       */ __Matchers[807] = new Optional(this, 807, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_808:('try',?(>resources),>block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryStatement(nodes) };
                /* 809 StringOp         */ __Matchers[809] = new Keyword(this, 809, "'catch'", "catch") { Creator = node => new RLiteral(node) };
                /* 810 OptionalOp       */ __Matchers[810] = new Optional(this, 810, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 811 SeqOp            */ __Matchers[811] = new Seq(this, 811, "_811:('catch','(',?(>variable),')',>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 812 StringOp         */ __Matchers[812] = new Keyword(this, 812, "'finally'", "finally") { Creator = node => new RLiteral(node) };
                /* 813 SeqOp            */ __Matchers[813] = new Seq(this, 813, "_813:('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 814 OptionalOp       */ __Matchers[814] = new Optional(this, 814, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_815:('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 816 SeqOp            */ __Matchers[816] = new Seq(this, 816, "_816:(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 817 StarOp           */ __Matchers[817] = new Star(this, 817, "*(_816:(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 818 SeqOp            */ __Matchers[818] = new Seq(this, 818, "_818:(>resource,*(_816:(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 819 AltOp            */ __Matchers[819] = new Alt(this, 819, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 820 SeqOp            */ __Matchers[820] = new Seq(this, 820, "_820:(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 821 OptionalOp       */ __Matchers[821] = new Optional(this, 821, "?(>variable-type)") { Builder = nodes => new ROptional<ICVariableType>(nodes) };
                /* 822 StarOp           */ __Matchers[822] = new Star(this, 822, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 823 SeqOp            */ __Matchers[823] = new Seq(this, 823, "_823:(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 824 AltOp            */ __Matchers[824] = new Alt(this, 824, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 825 SeqOp            */ __Matchers[825] = new Seq(this, 825, "_825:('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 826 StringOp         */ __Matchers[826] = new String(this, 826, "'`'", "`") { Creator = node => new RLiteral(node) };
                /* 827 SeqOp            */ __Matchers[827] = new Seq(this, 827, "_827:('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 828 AltOp            */ __Matchers[828] = new Alt(this, 828, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 829 AltOp            */ __Matchers[829] = new Alt(this, 829, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 830 AltOp            */ __Matchers[830] = new Alt(this, 830, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 831 SeqOp            */ __Matchers[831] = new Seq(this, 831, "_831:('package','.',>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 832 SeqOp            */ __Matchers[832] = new Seq(this, 832, "_832:(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 833 AltOp            */ __Matchers[833] = new Alt(this, 833, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>object-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 834 OptionalOp       */ __Matchers[834] = new Optional(this, 834, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 835 SeqOp            */ __Matchers[835] = new Seq(this, 835, "_835:('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 836 SeqOp            */ __Matchers[836] = new Seq(this, 836, "_836:('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 837 SeqOp            */ __Matchers[837] = new Seq(this, 837, "_837:('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 838 SeqOp            */ __Matchers[838] = new Seq(this, 838, "_838:('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 839 SeqOp            */ __Matchers[839] = new Seq(this, 839, "_839:('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 840 SeqOp            */ __Matchers[840] = new Seq(this, 840, "_840:('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_841:('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 842 SeqOp            */ __Matchers[842] = new Seq(this, 842, "_842:('value',>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 843 SeqOp            */ __Matchers[843] = new Seq(this, 843, "_843:('object',>reference-path)") { Builder = nodes => new CObjectLiteral(nodes) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_844:('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 845 SeqOp            */ __Matchers[845] = new Seq(this, 845, "_845:('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_846:(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 847 SeqOp            */ __Matchers[847] = new Seq(this, 847, "_847:('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 848 StarOp           */ __Matchers[848] = new Star(this, 848, "*(_847:('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 849 SeqOp            */ __Matchers[849] = new Seq(this, 849, "_849:(>reference-path-element,*(_847:('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[355]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[356]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[357]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[360]);
                /*   6 PlainRuleOp      */ _namespacePath.Set(__Matchers[364]);
                /*   7 PlainRuleOp      */ _imports.Set(__Matchers[365]);
                /*   8 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[368]);
                /*   9 PlainRuleOp      */ _version.Set(_literalString);
                /*  10 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  11 PlainRuleOp      */ _moduleBody.Set(__Matchers[372]);
                /*  12 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[373]);
                /*  13 PlainRuleOp      */ _moduleImport.Set(__Matchers[375]);
                /*  14 PlainRuleOp      */ _importDeclaration.Set(__Matchers[378]);
                /*  15 PlainRuleOp      */ _importElements.Set(__Matchers[380]);
                /*  16 PlainRuleOp      */ _importElementList.Set(__Matchers[384]);
                /*  17 PlainRuleOp      */ _importElement.Set(__Matchers[385]);
                /*  18 PlainRuleOp      */ _importNamed.Set(__Matchers[388]);
                /*  19 PlainRuleOp      */ _importName.Set(_identifier);
                /*  20 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[390]);
                /*  21 PlainRuleOp      */ _importWildcard.Set(__Matchers[391]);
                /*  22 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  23 PlainRuleOp      */ _packagePath.Set(__Matchers[394]);
                /*  24 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  25 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  26 PlainRuleOp      */ _pattern.Set(__Matchers[395]);
                /*  27 PlainRuleOp      */ _entryPattern.Set(__Matchers[397]);
                /*  28 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[398]);
                /*  29 PlainRuleOp      */ _tuplePattern.Set(__Matchers[402]);
                /*  30 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[405]);
                /*  31 PlainRuleOp      */ _variadicPattern.Set(__Matchers[406]);
                /*  32 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  33 PlainRuleOp      */ _variadicVariable.Set(__Matchers[408]);
                /*  34 PlainRuleOp      */ _variadicOperator.Set(__Matchers[411]);
                /*  35 PlainRuleOp      */ _letStatement.Set(__Matchers[415]);
                /*  36 PlainRuleOp      */ _letVariableList.Set(__Matchers[418]);
                /*  37 PlainRuleOp      */ _letVariable.Set(__Matchers[419]);
                /*  38 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[421]);
                /*  39 PlainRuleOp      */ _assertionStatement.Set(__Matchers[424]);
                /*  40 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  41 PlainRuleOp      */ _block.Set(__Matchers[425]);
                /*  42 PlainRuleOp      */ _extendedType.Set(__Matchers[426]);
                /*  43 PlainRuleOp      */ _classSpecifier.Set(__Matchers[428]);
                /*  44 PlainRuleOp      */ _classInstantiation.Set(__Matchers[430]);
                /*  45 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[431]);
                /*  46 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[432]);
                /*  47 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[434]);
                /*  48 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[435]);
                /*  49 PlainRuleOp      */ _memberPath.Set(__Matchers[436]);
                /*  50 PlainRuleOp      */ _typePath.Set(__Matchers[439]);
                /*  51 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[441]);
                /*  52 PlainRuleOp      */ _unionTypeList.Set(__Matchers[444]);
                /*  53 PlainRuleOp      */ _caseTypes.Set(__Matchers[446]);
                /*  54 PlainRuleOp      */ _caseTypeList.Set(__Matchers[450]);
                /*  55 PlainRuleOp      */ _caseType.Set(__Matchers[451]);
                /*  56 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[453]);
                /*  57 PlainRuleOp      */ _parameters.Set(__Matchers[455]);
                /*  58 PlainRuleOp      */ _parameterList.Set(__Matchers[458]);
                /*  59 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[459]);
                /*  60 PlainRuleOp      */ _parameter.Set(__Matchers[460]);
                /*  61 PlainRuleOp      */ _parameterReference.Set(__Matchers[462]);
                /*  62 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[463]);
                /*  63 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[464]);
                /*  64 PlainRuleOp      */ _voidFunctionParameter.Set(__Matchers[469]);
                /*  65 PlainRuleOp      */ _inferredFunctionParameter.Set(__Matchers[471]);
                /*  66 PlainRuleOp      */ _typedFunctionParameter.Set(__Matchers[472]);
                /*  67 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[473]);
                /*  68 PlainRuleOp      */ _inferredValueParameter.Set(__Matchers[475]);
                /*  69 PlainRuleOp      */ _typedValueParameter.Set(__Matchers[476]);
                /*  70 PlainRuleOp      */ _typeParameters.Set(__Matchers[479]);
                /*  71 PlainRuleOp      */ _typeParameterList.Set(__Matchers[482]);
                /*  72 PlainRuleOp      */ _typeParameter.Set(__Matchers[485]);
                /*  73 PlainRuleOp      */ _variance.Set(__Matchers[488]);
                /*  74 PlainRuleOp      */ _typeDefault.Set(__Matchers[489]);
                /*  75 PlainRuleOp      */ _typeConstraint.Set(__Matchers[494]);
                /*  76 PlainRuleOp      */ _typeConstraints.Set(__Matchers[495]);
                /*  77 PlainRuleOp      */ _topDeclarations.Set(__Matchers[496]);
                /*  78 PlainRuleOp      */ _topDeclaration.Set(__Matchers[497]);
                /*  79 PlainRuleOp      */ _declaration.Set(__Matchers[498]);
                /*  80 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[502]);
                /*  81 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[505]);
                /*  82 PlainRuleOp      */ _enumeratedObjectDeclaration.Set(__Matchers[506]);
                /*  83 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[509]);
                /*  84 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[511]);
                /*  85 PlainRuleOp      */ _setterDefinition.Set(__Matchers[512]);
                /*  86 PlainRuleOp      */ _voidMethodDeclaration.Set(__Matchers[513]);
                /*  87 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[514]);
                /*  88 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[515]);
                /*  89 PlainRuleOp      */ _methodDefinition.Set(__Matchers[516]);
                /*  90 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[517]);
                /*  91 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[518]);
                /*  92 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[519]);
                /*  93 PlainRuleOp      */ _classDeclaration.Set(__Matchers[522]);
                /*  94 PlainRuleOp      */ _classDefinition.Set(__Matchers[523]);
                /*  95 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[525]);
                /*  96 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[527]);
                /*  97 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[528]);
                /*  98 PlainRuleOp      */ _statements.Set(__Matchers[529]);
                /*  99 PlainRuleOp      */ _statement.Set(__Matchers[530]);
                /* 100 PlainRuleOp      */ _declarationStatement.Set(_declaration);
                /* 101 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[531]);
                /* 102 PlainRuleOp      */ _openStatement.Set(__Matchers[532]);
                /* 103 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 104 PlainRuleOp      */ _specificationStatement.Set(__Matchers[533]);
                /* 105 PlainRuleOp      */ _returnStatement.Set(__Matchers[536]);
                /* 106 PlainRuleOp      */ _throwStatement.Set(__Matchers[538]);
                /* 107 PlainRuleOp      */ _breakStatement.Set(__Matchers[539]);
                /* 108 PlainRuleOp      */ _continueStatement.Set(__Matchers[540]);
                /* 109 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[541]);
                /* 110 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[542]);
                /* 111 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[543]);
                /* 112 PlainRuleOp      */ _requiredFunctionSpecifier.Set(__Matchers[544]);
                /* 113 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[545]);
                /* 114 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[547]);
                /* 115 PlainRuleOp      */ _anySpecifier.Set(__Matchers[548]);
                /* 116 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[550]);
                /* 117 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[551]);
                /* 118 PlainRuleOp      */ _baseReference.Set(__Matchers[552]);
                /* 119 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[553]);
                /* 120 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[554]);
                /* 121 PlainRuleOp      */ _memberReference.Set(__Matchers[556]);
                /* 122 PlainRuleOp      */ _typeReference.Set(__Matchers[557]);
                /* 123 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[558]);
                /* 124 PlainRuleOp      */ _selfReference.Set(__Matchers[561]);
                /* 125 PlainRuleOp      */ _enumerationExpr.Set(__Matchers[563]);
                /* 126 PlainRuleOp      */ _tupleExpr.Set(__Matchers[564]);
                /* 127 PlainRuleOp      */ _arguments.Set(__Matchers[565]);
                /* 128 PlainRuleOp      */ _patternedArguments.Set(__Matchers[567]);
                /* 129 PlainRuleOp      */ _positionalArguments.Set(__Matchers[568]);
                /* 130 PlainRuleOp      */ _structuredArgument.Set(__Matchers[569]);
                /* 131 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[570]);
                /* 132 PlainRuleOp      */ _namedArgument.Set(__Matchers[571]);
                /* 133 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[572]);
                /* 134 PlainRuleOp      */ _sequencedArgumentList.Set(__Matchers[575]);
                /* 135 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[576]);
                /* 136 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[577]);
                /* 137 PlainRuleOp      */ _objectArgument.Set(__Matchers[578]);
                /* 138 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[579]);
                /* 139 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[580]);
                /* 140 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[581]);
                /* 141 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[582]);
                /* 142 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[583]);
                /* 143 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[584]);
                /* 144 PlainRuleOp      */ _positionalArgument.Set(__Matchers[585]);
                /* 145 PlainRuleOp      */ _expressionArgument.Set(_expression);
                /* 146 PlainRuleOp      */ _spreadArgument.Set(__Matchers[586]);
                /* 147 PlainRuleOp      */ _letExpr.Set(__Matchers[588]);
                /* 148 PlainRuleOp      */ _switchExpr.Set(__Matchers[591]);
                /* 149 PlainRuleOp      */ _switchHeader.Set(__Matchers[593]);
                /* 150 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 151 PlainRuleOp      */ _caseExpression.Set(__Matchers[597]);
                /* 152 PlainRuleOp      */ _ifExpr.Set(__Matchers[599]);
                /* 153 PlainRuleOp      */ _elseExpression.Set(__Matchers[600]);
                /* 154 PlainRuleOp      */ _thenExpression.Set(__Matchers[602]);
                /* 155 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[603]);
                /* 156 PlainRuleOp      */ _functionExpression.Set(__Matchers[604]);
                /* 157 PlainRuleOp      */ _voidFunctionExpr.Set(__Matchers[605]);
                /* 158 PlainRuleOp      */ _inferredFunctionExpr.Set(__Matchers[607]);
                /* 159 PlainRuleOp      */ _functionDefinition.Set(__Matchers[608]);
                /* 160 PlainRuleOp      */ _comprehensionArgument.Set(__Matchers[609]);
                /* 161 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[610]);
                /* 162 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 163 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[613]);
                /* 164 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[614]);
                /* 165 PlainRuleOp      */ _expression.Set(__Matchers[615]);
                /* 166 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 167 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[616]);
                /* 168 PlainRuleOp      */ _assignmentExpr.Set(__Matchers[617]);
                /* 169 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[629]);
                /* 170 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[630]);
                /* 171 PlainRuleOp      */ _thenElseExpr.Set(__Matchers[631]);
                /* 172 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[632]);
                /* 173 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[633]);
                /* 174 PlainRuleOp      */ _disjunctionExpr.Set(__Matchers[634]);
                /* 175 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[635]);
                /* 176 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[636]);
                /* 177 PlainRuleOp      */ _conjunctionExpr.Set(__Matchers[637]);
                /* 178 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[638]);
                /* 179 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[639]);
                /* 180 PlainRuleOp      */ _logicalNegationExpr.Set(__Matchers[640]);
                /* 181 PlainRuleOp      */ _notOperator.Set(__Matchers[641]);
                /* 182 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[642]);
                /* 183 PlainRuleOp      */ _equalityExpression.Set(__Matchers[643]);
                /* 184 PlainRuleOp      */ _equalityExpr.Set(__Matchers[644]);
                /* 185 PlainRuleOp      */ _equalityOperator.Set(__Matchers[648]);
                /* 186 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[649]);
                /* 187 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[650]);
                /* 188 PlainRuleOp      */ _largerExpr.Set(__Matchers[651]);
                /* 189 PlainRuleOp      */ _smallerExpr.Set(__Matchers[652]);
                /* 190 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[653]);
                /* 191 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[654]);
                /* 192 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[655]);
                /* 193 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[657]);
                /* 194 PlainRuleOp      */ _smallerOperator.Set(__Matchers[659]);
                /* 195 PlainRuleOp      */ _largerOperator.Set(__Matchers[661]);
                /* 196 PlainRuleOp      */ _typeOperator.Set(__Matchers[663]);
                /* 197 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[664]);
                /* 198 PlainRuleOp      */ _existsExpr.Set(__Matchers[666]);
                /* 199 PlainRuleOp      */ _nonemptyExpr.Set(__Matchers[668]);
                /* 200 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[669]);
                /* 201 PlainRuleOp      */ _rangeExpr.Set(__Matchers[670]);
                /* 202 PlainRuleOp      */ _entryExpr.Set(__Matchers[671]);
                /* 203 PlainRuleOp      */ _rangeOperator.Set(__Matchers[673]);
                /* 204 PlainRuleOp      */ _entryOperator.Set(__Matchers[396]);
                /* 205 PlainRuleOp      */ _additiveExpression.Set(__Matchers[674]);
                /* 206 PlainRuleOp      */ _additiveExpr.Set(__Matchers[675]);
                /* 207 PlainRuleOp      */ _additiveOperator.Set(__Matchers[677]);
                /* 208 PlainRuleOp      */ _scaleExpression.Set(__Matchers[678]);
                /* 209 PlainRuleOp      */ _scaleExpr.Set(__Matchers[679]);
                /* 210 PlainRuleOp      */ _scaleOperator.Set(__Matchers[680]);
                /* 211 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[681]);
                /* 212 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[682]);
                /* 213 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[685]);
                /* 214 PlainRuleOp      */ _unionExpression.Set(__Matchers[686]);
                /* 215 PlainRuleOp      */ _unionExpr.Set(__Matchers[687]);
                /* 216 PlainRuleOp      */ _unionOperator.Set(__Matchers[689]);
                /* 217 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[690]);
                /* 218 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[691]);
                /* 219 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[692]);
                /* 220 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[693]);
                /* 221 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[694]);
                /* 222 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[695]);
                /* 223 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[696]);
                /* 224 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[697]);
                /* 225 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[698]);
                /* 226 PlainRuleOp      */ _negateOperator.Set(__Matchers[700]);
                /* 227 PlainRuleOp      */ _neutralOperator.Set(__Matchers[702]);
                /* 228 PlainRuleOp      */ _complementOperator.Set(__Matchers[688]);
                /* 229 PlainRuleOp      */ _prefixExpression.Set(__Matchers[703]);
                /* 230 PlainRuleOp      */ _prefixExpr.Set(__Matchers[704]);
                /* 231 PlainRuleOp      */ _postfixExpression.Set(__Matchers[705]);
                /* 232 PlainRuleOp      */ _postfixExpr.Set(__Matchers[706]);
                /* 233 PlainRuleOp      */ _incrementOperator.Set(__Matchers[709]);
                /* 234 PlainRuleOp      */ _primary.Set(__Matchers[710]);
                /* 235 PlainRuleOp      */ _selectionExpr.Set(__Matchers[711]);
                /* 236 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[714]);
                /* 237 PlainRuleOp      */ _indexedExpr.Set(__Matchers[715]);
                /* 238 PlainRuleOp      */ _index.Set(__Matchers[716]);
                /* 239 PlainRuleOp      */ _upperSpanned.Set(__Matchers[717]);
                /* 240 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[718]);
                /* 241 PlainRuleOp      */ _spanned.Set(__Matchers[719]);
                /* 242 PlainRuleOp      */ _measured.Set(__Matchers[720]);
                /* 243 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 244 PlainRuleOp      */ _callExpr.Set(__Matchers[721]);
                /* 245 PlainRuleOp      */ _baseExpression.Set(__Matchers[722]);
                /* 246 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[723]);
                /* 247 PlainRuleOp      */ _stringExpression.Set(__Matchers[724]);
                /* 248 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[726]);
                /* 249 PlainRuleOp      */ _interpolationPart.Set(__Matchers[727]);
                /* 250 PlainRuleOp      */ _stringLiteral.Set(__Matchers[728]);
                /* 251 PlainRuleOp      */ _objectExpr.Set(__Matchers[729]);
                /* 252 PlainRuleOp      */ _groupedExpr.Set(__Matchers[730]);
                /* 253 PlainRuleOp      */ _typeArguments.Set(__Matchers[732]);
                /* 254 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[735]);
                /* 255 PlainRuleOp      */ _variancedType.Set(__Matchers[736]);
                /* 256 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[739]);
                /* 257 PlainRuleOp      */ _defaultedType.Set(__Matchers[740]);
                /* 258 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[741]);
                /* 259 PlainRuleOp      */ _variadicType.Set(__Matchers[742]);
                /* 260 PlainRuleOp      */ _variadicTypeCore.Set(__Matchers[743]);
                /* 261 PlainRuleOp      */ _spreadType.Set(__Matchers[744]);
                /* 262 PlainRuleOp      */ _type.Set(__Matchers[745]);
                /* 263 PlainRuleOp      */ _entryType.Set(__Matchers[746]);
                /* 264 PlainRuleOp      */ _unionType.Set(__Matchers[747]);
                /* 265 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[748]);
                /* 266 PlainRuleOp      */ _intersectionType.Set(__Matchers[749]);
                /* 267 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[750]);
                /* 268 PlainRuleOp      */ _primaryType.Set(__Matchers[751]);
                /* 269 PlainRuleOp      */ _nullableType.Set(__Matchers[753]);
                /* 270 PlainRuleOp      */ _arrayType.Set(__Matchers[755]);
                /* 271 PlainRuleOp      */ _functionType.Set(__Matchers[757]);
                /* 272 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[758]);
                /* 273 PlainRuleOp      */ _tupleType.Set(__Matchers[759]);
                /* 274 PlainRuleOp      */ _iterableType.Set(__Matchers[761]);
                /* 275 PlainRuleOp      */ _groupedType.Set(__Matchers[762]);
                /* 276 PlainRuleOp      */ _packageQualifiedType.Set(__Matchers[763]);
                /* 277 PlainRuleOp      */ _annotations.Set(__Matchers[766]);
                /* 278 PlainRuleOp      */ _annotation.Set(__Matchers[767]);
                /* 279 PlainRuleOp      */ _conditions.Set(__Matchers[769]);
                /* 280 PlainRuleOp      */ _conditionList.Set(__Matchers[772]);
                /* 281 PlainRuleOp      */ _condition.Set(__Matchers[773]);
                /* 282 PlainRuleOp      */ _existsCondition.Set(__Matchers[775]);
                /* 283 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[776]);
                /* 284 PlainRuleOp      */ _letOrExpression.Set(__Matchers[777]);
                /* 285 PlainRuleOp      */ _isCondition.Set(__Matchers[778]);
                /* 286 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[779]);
                /* 287 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[780]);
                /* 288 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 289 PlainRuleOp      */ _controlStatement.Set(__Matchers[781]);
                /* 290 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[784]);
                /* 291 PlainRuleOp      */ _elseIf.Set(__Matchers[785]);
                /* 292 PlainRuleOp      */ _elseBlock.Set(__Matchers[786]);
                /* 293 PlainRuleOp      */ _switchStatement.Set(__Matchers[788]);
                /* 294 PlainRuleOp      */ _caseBlock.Set(__Matchers[789]);
                /* 295 PlainRuleOp      */ _caseItem.Set(__Matchers[790]);
                /* 296 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[791]);
                /* 297 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[792]);
                /* 298 PlainRuleOp      */ _valueCaseList.Set(__Matchers[795]);
                /* 299 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[796]);
                /* 300 PlainRuleOp      */ _valueCase.Set(__Matchers[797]);
                /* 301 PlainRuleOp      */ _forElseStatement.Set(__Matchers[798]);
                /* 302 PlainRuleOp      */ _forIterator.Set(__Matchers[799]);
                /* 303 PlainRuleOp      */ _forVariable.Set(_pattern);
                /* 304 PlainRuleOp      */ _containment.Set(__Matchers[800]);
                /* 305 PlainRuleOp      */ _containmentOperator.Set(__Matchers[801]);
                /* 306 PlainRuleOp      */ _whileStatement.Set(__Matchers[803]);
                /* 307 PlainRuleOp      */ _tryStatement.Set(__Matchers[808]);
                /* 308 PlainRuleOp      */ _catchBlock.Set(__Matchers[811]);
                /* 309 PlainRuleOp      */ _finallyBlock.Set(__Matchers[813]);
                /* 310 PlainRuleOp      */ _resources.Set(__Matchers[815]);
                /* 311 PlainRuleOp      */ _resourceList.Set(__Matchers[818]);
                /* 312 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 313 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[819]);
                /* 314 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[820]);
                /* 315 PlainRuleOp      */ _variable.Set(__Matchers[823]);
                /* 316 PlainRuleOp      */ _variableType.Set(__Matchers[824]);
                /* 317 PlainRuleOp      */ _modelReference.Set(__Matchers[825]);
                /* 318 PlainRuleOp      */ _metaLiteral.Set(__Matchers[827]);
                /* 319 PlainRuleOp      */ _metaExpression.Set(__Matchers[828]);
                /* 320 PlainRuleOp      */ _modelExpression.Set(__Matchers[829]);
                /* 321 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[830]);
                /* 322 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[831]);
                /* 323 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[832]);
                /* 324 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 325 PlainRuleOp      */ _declarationReference.Set(__Matchers[833]);
                /* 326 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[835]);
                /* 327 PlainRuleOp      */ _packageLiteral.Set(__Matchers[836]);
                /* 328 PlainRuleOp      */ _classLiteral.Set(__Matchers[837]);
                /* 329 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[838]);
                /* 330 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[839]);
                /* 331 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[840]);
                /* 332 PlainRuleOp      */ _newLiteral.Set(__Matchers[841]);
                /* 333 PlainRuleOp      */ _valueLiteral.Set(__Matchers[842]);
                /* 334 PlainRuleOp      */ _objectLiteral.Set(__Matchers[843]);
                /* 335 PlainRuleOp      */ _functionLiteral.Set(__Matchers[844]);
                /* 336 PlainRuleOp      */ _packageQualifier.Set(__Matchers[845]);
                /* 337 PlainRuleOp      */ _referencePath.Set(__Matchers[846]);
                /* 338 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[849]);
                /* 339 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 340 PlainRuleOp      */ _kwVoid.Set(__Matchers[465]);
                /* 341 PlainRuleOp      */ _kwFunction.Set(__Matchers[470]);
                /* 342 PlainRuleOp      */ _kwValue.Set(__Matchers[474]);
                /* 343 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 344 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 345 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 346 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 347 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 348 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 349 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 350 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 351 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 352 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 353 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /* 355 SeqOp            */ __Matchers[355].Set(_compilationUnit, __Matchers[354]);
                /* 356 AltOp            */ __Matchers[356].Set(_moduleDescriptor, _codeUnit);
                /* 357 SeqOp            */ __Matchers[357].Set(_namespace, _imports, _topDeclarations);
                /* 360 SeqOp            */ __Matchers[360].Set(_annotations, __Matchers[358], _namespacePath, __Matchers[359]);
                /* 362 SeqOp            */ __Matchers[362].Set(__Matchers[361], _identifier);
                /* 363 StarOp           */ __Matchers[363].Set(__Matchers[362]);
                /* 364 SeqOp            */ __Matchers[364].Set(_identifier, __Matchers[363]);
                /* 365 StarOp           */ __Matchers[365].Set(_importDeclaration);
                /* 367 OptionalOp       */ __Matchers[367].Set(_version);
                /* 368 SeqOp            */ __Matchers[368].Set(_annotations, __Matchers[366], _moduleName, __Matchers[367], _moduleBody);
                /* 370 StarOp           */ __Matchers[370].Set(_moduleBodyElement);
                /* 372 SeqOp            */ __Matchers[372].Set(__Matchers[369], __Matchers[370], __Matchers[371]);
                /* 373 AltOp            */ __Matchers[373].Set(_inferredAttributeDeclaration, _moduleImport);
                /* 375 SeqOp            */ __Matchers[375].Set(_annotations, __Matchers[374], _moduleName, __Matchers[367], __Matchers[359]);
                /* 378 SeqOp            */ __Matchers[378].Set(__Matchers[374], _packagePath, _importElements);
                /* 379 OptionalOp       */ __Matchers[379].Set(_importElementList);
                /* 380 SeqOp            */ __Matchers[380].Set(__Matchers[369], __Matchers[379], __Matchers[371]);
                /* 382 SeqOp            */ __Matchers[382].Set(__Matchers[381], _importElement);
                /* 383 StarOp           */ __Matchers[383].Set(__Matchers[382]);
                /* 384 SeqOp            */ __Matchers[384].Set(_importElement, __Matchers[383]);
                /* 385 AltOp            */ __Matchers[385].Set(_importNamed, _importWildcard);
                /* 386 OptionalOp       */ __Matchers[386].Set(_importNameSpecifier);
                /* 387 OptionalOp       */ __Matchers[387].Set(_importElements);
                /* 388 SeqOp            */ __Matchers[388].Set(_importName, __Matchers[386], __Matchers[387]);
                /* 390 SeqOp            */ __Matchers[390].Set(__Matchers[389], _identifier);
                /* 392 SeqOp            */ __Matchers[392].Set(__Matchers[361], _packageName);
                /* 393 StarOp           */ __Matchers[393].Set(__Matchers[392]);
                /* 394 SeqOp            */ __Matchers[394].Set(_packageName, __Matchers[393]);
                /* 395 AltOp            */ __Matchers[395].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 397 SeqOp            */ __Matchers[397].Set(_variableOrTuplePattern, __Matchers[396], _variableOrTuplePattern);
                /* 398 AltOp            */ __Matchers[398].Set(_tuplePattern, _variablePattern);
                /* 400 OptionalOp       */ __Matchers[400].Set(_variadicPatternList);
                /* 402 SeqOp            */ __Matchers[402].Set(__Matchers[399], __Matchers[400], __Matchers[401]);
                /* 403 SeqOp            */ __Matchers[403].Set(__Matchers[381], _variadicPattern);
                /* 404 StarOp           */ __Matchers[404].Set(__Matchers[403]);
                /* 405 SeqOp            */ __Matchers[405].Set(_variadicPattern, __Matchers[404]);
                /* 406 AltOp            */ __Matchers[406].Set(_variadicVariable, _pattern);
                /* 407 OptionalOp       */ __Matchers[407].Set(_unionType);
                /* 408 SeqOp            */ __Matchers[408].Set(__Matchers[407], _variadicOperator, _memberName);
                /* 411 AltOp            */ __Matchers[411].Set(__Matchers[409], __Matchers[410]);
                /* 415 SeqOp            */ __Matchers[415].Set(__Matchers[412], __Matchers[413], _letVariableList, __Matchers[414]);
                /* 416 SeqOp            */ __Matchers[416].Set(__Matchers[381], _letVariable);
                /* 417 StarOp           */ __Matchers[417].Set(__Matchers[416]);
                /* 418 SeqOp            */ __Matchers[418].Set(_letVariable, __Matchers[417]);
                /* 419 SeqOp            */ __Matchers[419].Set(_pattern, _valueSpecifier);
                /* 421 SeqOp            */ __Matchers[421].Set(__Matchers[420], _classInstantiation);
                /* 422 OptionalOp       */ __Matchers[422].Set(_assertionMessage);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[422], __Matchers[423], _conditions);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[369], _imports, _statements, __Matchers[371]);
                /* 426 SeqOp            */ __Matchers[426].Set(__Matchers[420], _classInstantiation);
                /* 428 SeqOp            */ __Matchers[428].Set(__Matchers[427], _classInstantiation);
                /* 429 OptionalOp       */ __Matchers[429].Set(_arguments);
                /* 430 SeqOp            */ __Matchers[430].Set(_qualifiedClass, __Matchers[429]);
                /* 431 AltOp            */ __Matchers[431].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 432 SeqOp            */ __Matchers[432].Set(__Matchers[376], __Matchers[361], _unQualifiedClass);
                /* 434 SeqOp            */ __Matchers[434].Set(__Matchers[433], __Matchers[361], _baseReference);
                /* 435 AltOp            */ __Matchers[435].Set(_memberPath, _typePath, _memberReference);
                /* 436 SeqOp            */ __Matchers[436].Set(_typePath, __Matchers[361], _memberReference);
                /* 437 SeqOp            */ __Matchers[437].Set(__Matchers[361], _typeReference);
                /* 438 StarOp           */ __Matchers[438].Set(__Matchers[437]);
                /* 439 SeqOp            */ __Matchers[439].Set(_typeReference, __Matchers[438]);
                /* 441 SeqOp            */ __Matchers[441].Set(__Matchers[440], _unionTypeList);
                /* 442 SeqOp            */ __Matchers[442].Set(__Matchers[381], _unionType);
                /* 443 StarOp           */ __Matchers[443].Set(__Matchers[442]);
                /* 444 SeqOp            */ __Matchers[444].Set(_unionType, __Matchers[443]);
                /* 446 SeqOp            */ __Matchers[446].Set(__Matchers[445], _caseTypeList);
                /* 448 SeqOp            */ __Matchers[448].Set(__Matchers[447], _caseType);
                /* 449 StarOp           */ __Matchers[449].Set(__Matchers[448]);
                /* 450 SeqOp            */ __Matchers[450].Set(_caseType, __Matchers[449]);
                /* 451 AltOp            */ __Matchers[451].Set(_primaryType, _qualifiedCaseType);
                /* 452 OptionalOp       */ __Matchers[452].Set(_packageQualifier);
                /* 453 SeqOp            */ __Matchers[453].Set(__Matchers[452], _memberName);
                /* 454 OptionalOp       */ __Matchers[454].Set(_parameterList);
                /* 455 SeqOp            */ __Matchers[455].Set(__Matchers[413], __Matchers[454], __Matchers[414]);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[381], _parameterDeclarationOrRefPattern);
                /* 457 StarOp           */ __Matchers[457].Set(__Matchers[456]);
                /* 458 SeqOp            */ __Matchers[458].Set(_parameterDeclarationOrRefPattern, __Matchers[457]);
                /* 459 AltOp            */ __Matchers[459].Set(_entryPattern, _tuplePattern, _parameter, _parameterReference);
                /* 460 SeqOp            */ __Matchers[460].Set(_annotations, _parameterDeclaration);
                /* 461 OptionalOp       */ __Matchers[461].Set(_valueSpecifier);
                /* 462 SeqOp            */ __Matchers[462].Set(_memberName, __Matchers[461]);
                /* 463 AltOp            */ __Matchers[463].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 464 AltOp            */ __Matchers[464].Set(_voidFunctionParameter, _inferredFunctionParameter, _typedFunctionParameter);
                /* 466 OptionalOp       */ __Matchers[466].Set(_typeParameters);
                /* 467 PlusOp           */ __Matchers[467].Set(_parameters);
                /* 468 OptionalOp       */ __Matchers[468].Set(_functionSpecifier);
                /* 469 SeqOp            */ __Matchers[469].Set(__Matchers[465], _memberName, __Matchers[466], __Matchers[467], __Matchers[468]);
                /* 471 SeqOp            */ __Matchers[471].Set(__Matchers[470], _memberName, __Matchers[466], __Matchers[467], __Matchers[468]);
                /* 472 SeqOp            */ __Matchers[472].Set(_variadicType, _memberName, __Matchers[466], __Matchers[467], __Matchers[468]);
                /* 473 AltOp            */ __Matchers[473].Set(_inferredValueParameter, _typedValueParameter);
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[474], _memberName, __Matchers[461]);
                /* 476 SeqOp            */ __Matchers[476].Set(_variadicType, _memberName, __Matchers[461]);
                /* 479 SeqOp            */ __Matchers[479].Set(__Matchers[477], _typeParameterList, __Matchers[478]);
                /* 480 SeqOp            */ __Matchers[480].Set(__Matchers[381], _typeParameter);
                /* 481 StarOp           */ __Matchers[481].Set(__Matchers[480]);
                /* 482 SeqOp            */ __Matchers[482].Set(_typeParameter, __Matchers[481]);
                /* 483 OptionalOp       */ __Matchers[483].Set(_variance);
                /* 484 OptionalOp       */ __Matchers[484].Set(_typeDefault);
                /* 485 SeqOp            */ __Matchers[485].Set(__Matchers[483], _typeName, __Matchers[484]);
                /* 488 AltOp            */ __Matchers[488].Set(__Matchers[486], __Matchers[487]);
                /* 489 SeqOp            */ __Matchers[489].Set(__Matchers[389], _type);
                /* 491 OptionalOp       */ __Matchers[491].Set(_typeName);
                /* 492 OptionalOp       */ __Matchers[492].Set(_caseTypes);
                /* 493 OptionalOp       */ __Matchers[493].Set(_satisfiedTypes);
                /* 494 SeqOp            */ __Matchers[494].Set(__Matchers[490], __Matchers[491], __Matchers[466], __Matchers[492], __Matchers[493]);
                /* 495 PlusOp           */ __Matchers[495].Set(_typeConstraint);
                /* 496 StarOp           */ __Matchers[496].Set(_topDeclaration);
                /* 497 AltOp            */ __Matchers[497].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 498 AltOp            */ __Matchers[498].Set(_classDeclaration, _interfaceDeclaration, _aliasDeclaration, _objectDeclaration, _constructorDeclaration, _enumeratedObjectDeclaration, _setterDeclaration, _typedMethodDeclaration, _voidMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 500 OptionalOp       */ __Matchers[500].Set(_memberName);
                /* 501 OptionalOp       */ __Matchers[501].Set(_delegatedConstructor);
                /* 502 SeqOp            */ __Matchers[502].Set(_annotations, __Matchers[499], __Matchers[500], _parameters, __Matchers[501], _block);
                /* 504 OptionalOp       */ __Matchers[504].Set(_typeConstraints);
                /* 505 SeqOp            */ __Matchers[505].Set(_annotations, __Matchers[503], _typeName, __Matchers[466], __Matchers[504], _optionalTypeSpecifier);
                /* 506 SeqOp            */ __Matchers[506].Set(_annotations, __Matchers[499], _memberName, __Matchers[501], _block);
                /* 508 OptionalOp       */ __Matchers[508].Set(_extendedType);
                /* 509 SeqOp            */ __Matchers[509].Set(_annotations, __Matchers[507], _memberName, __Matchers[508], __Matchers[493], _block);
                /* 511 SeqOp            */ __Matchers[511].Set(_annotations, __Matchers[510], _memberName, _setterDefinition);
                /* 512 AltOp            */ __Matchers[512].Set(_block, _requiredFunctionSpecifier);
                /* 513 SeqOp            */ __Matchers[513].Set(_annotations, __Matchers[465], _memberName, __Matchers[466], __Matchers[467], __Matchers[504], _methodDefinition);
                /* 514 SeqOp            */ __Matchers[514].Set(_annotations, __Matchers[470], _memberName, __Matchers[466], __Matchers[467], __Matchers[504], _methodDefinition);
                /* 515 SeqOp            */ __Matchers[515].Set(_annotations, _variadicType, _memberName, __Matchers[466], __Matchers[467], __Matchers[504], _methodDefinition);
                /* 516 AltOp            */ __Matchers[516].Set(_block, _optionalFunctionSpecifier);
                /* 517 SeqOp            */ __Matchers[517].Set(_annotations, _variadicType, _memberName, _attributeDefinition);
                /* 518 SeqOp            */ __Matchers[518].Set(_annotations, __Matchers[474], _memberName, _attributeDefinition);
                /* 519 AltOp            */ __Matchers[519].Set(_block, _optionalAnySpecifier);
                /* 521 OptionalOp       */ __Matchers[521].Set(_parameters);
                /* 522 SeqOp            */ __Matchers[522].Set(_annotations, __Matchers[520], _typeName, __Matchers[466], __Matchers[521], __Matchers[492], __Matchers[508], __Matchers[493], __Matchers[504], _classDefinition);
                /* 523 AltOp            */ __Matchers[523].Set(_block, _optionalClassSpecifier);
                /* 524 OptionalOp       */ __Matchers[524].Set(_classSpecifier);
                /* 525 SeqOp            */ __Matchers[525].Set(__Matchers[524], __Matchers[359]);
                /* 527 SeqOp            */ __Matchers[527].Set(_annotations, __Matchers[526], _typeName, __Matchers[466], __Matchers[492], __Matchers[493], __Matchers[504], _interfaceDefinition);
                /* 528 AltOp            */ __Matchers[528].Set(_block, _optionalTypeSpecifier);
                /* 529 StarOp           */ __Matchers[529].Set(_statement);
                /* 530 AltOp            */ __Matchers[530].Set(_declarationStatement, _unclosedStatement, _controlStatement);
                /* 531 SeqOp            */ __Matchers[531].Set(_openStatement, __Matchers[359]);
                /* 532 AltOp            */ __Matchers[532].Set(_returnStatement, _throwStatement, _breakStatement, _continueStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 533 SeqOp            */ __Matchers[533].Set(_primary, _functionSpecifier);
                /* 535 OptionalOp       */ __Matchers[535].Set(_expression);
                /* 536 SeqOp            */ __Matchers[536].Set(__Matchers[534], __Matchers[535]);
                /* 538 SeqOp            */ __Matchers[538].Set(__Matchers[537], __Matchers[535]);
                /* 541 SeqOp            */ __Matchers[541].Set(__Matchers[389], _expression);
                /* 542 SeqOp            */ __Matchers[542].Set(__Matchers[427], _expression);
                /* 543 SeqOp            */ __Matchers[543].Set(__Matchers[468], __Matchers[359]);
                /* 544 SeqOp            */ __Matchers[544].Set(_functionSpecifier, __Matchers[359]);
                /* 545 SeqOp            */ __Matchers[545].Set(__Matchers[427], _type);
                /* 546 OptionalOp       */ __Matchers[546].Set(_typeSpecifier);
                /* 547 SeqOp            */ __Matchers[547].Set(__Matchers[546], __Matchers[359]);
                /* 548 AltOp            */ __Matchers[548].Set(_valueSpecifier, _functionSpecifier);
                /* 549 OptionalOp       */ __Matchers[549].Set(_anySpecifier);
                /* 550 SeqOp            */ __Matchers[550].Set(__Matchers[549], __Matchers[359]);
                /* 551 AltOp            */ __Matchers[551].Set(_baseReference, _selfReference, _parametrizedMember, _selfParametrizedMember);
                /* 552 AltOp            */ __Matchers[552].Set(_memberReference, _typeReference);
                /* 553 SeqOp            */ __Matchers[553].Set(_memberName, __Matchers[466], __Matchers[467]);
                /* 554 SeqOp            */ __Matchers[554].Set(_selfReferenceSelector, _parametrizedMember);
                /* 555 OptionalOp       */ __Matchers[555].Set(_typeArguments);
                /* 556 SeqOp            */ __Matchers[556].Set(_memberName, __Matchers[555]);
                /* 557 SeqOp            */ __Matchers[557].Set(_typeName, __Matchers[555]);
                /* 558 SeqOp            */ __Matchers[558].Set(_selfReference, _memberSelectionOperator);
                /* 561 AltOp            */ __Matchers[561].Set(__Matchers[559], __Matchers[433], __Matchers[560], __Matchers[376]);
                /* 562 OptionalOp       */ __Matchers[562].Set(_sequencedArgumentList);
                /* 563 SeqOp            */ __Matchers[563].Set(__Matchers[369], _statements, __Matchers[562], __Matchers[371]);
                /* 564 SeqOp            */ __Matchers[564].Set(__Matchers[399], __Matchers[562], __Matchers[401]);
                /* 565 AltOp            */ __Matchers[565].Set(_patternedArguments, _positionalArguments);
                /* 566 StarOp           */ __Matchers[566].Set(_structuredArgument);
                /* 567 SeqOp            */ __Matchers[567].Set(__Matchers[369], __Matchers[566], __Matchers[562], __Matchers[371]);
                /* 568 SeqOp            */ __Matchers[568].Set(__Matchers[413], __Matchers[562], __Matchers[414]);
                /* 569 AltOp            */ __Matchers[569].Set(_anonymousArgument, _namedArgument);
                /* 570 SeqOp            */ __Matchers[570].Set(_expression, __Matchers[359]);
                /* 571 AltOp            */ __Matchers[571].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 572 SeqOp            */ __Matchers[572].Set(_memberName, _valueSpecifier, __Matchers[359]);
                /* 573 SeqOp            */ __Matchers[573].Set(__Matchers[381], _sequencedArgument);
                /* 574 StarOp           */ __Matchers[574].Set(__Matchers[573]);
                /* 575 SeqOp            */ __Matchers[575].Set(_sequencedArgument, __Matchers[574]);
                /* 576 AltOp            */ __Matchers[576].Set(_comprehensionArgument, _positionalArgument, _spreadArgument);
                /* 577 AltOp            */ __Matchers[577].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 578 SeqOp            */ __Matchers[578].Set(__Matchers[507], __Matchers[500], __Matchers[508], __Matchers[493], _block);
                /* 579 SeqOp            */ __Matchers[579].Set(_type, _parametrizedMember, _methodDefinition);
                /* 580 SeqOp            */ __Matchers[580].Set(__Matchers[470], __Matchers[500], __Matchers[466], _parameters, _methodDefinition);
                /* 581 SeqOp            */ __Matchers[581].Set(_memberName, __Matchers[467], _requiredFunctionSpecifier);
                /* 582 SeqOp            */ __Matchers[582].Set(_type, _memberName, _methodDefinition);
                /* 583 SeqOp            */ __Matchers[583].Set(__Matchers[474], _memberName, _methodDefinition);
                /* 584 SeqOp            */ __Matchers[584].Set(_memberName, _requiredFunctionSpecifier);
                /* 585 AltOp            */ __Matchers[585].Set(_expressionArgument, _declarationReference);
                /* 586 SeqOp            */ __Matchers[586].Set(__Matchers[409], _unionExpression);
                /* 587 OptionalOp       */ __Matchers[587].Set(_letVariableList);
                /* 588 SeqOp            */ __Matchers[588].Set(__Matchers[412], __Matchers[413], __Matchers[587], __Matchers[414], _conditionalExpression);
                /* 589 PlusOp           */ __Matchers[589].Set(_caseExpression);
                /* 590 OptionalOp       */ __Matchers[590].Set(_elseExpression);
                /* 591 SeqOp            */ __Matchers[591].Set(_switchHeader, __Matchers[589], __Matchers[590]);
                /* 593 SeqOp            */ __Matchers[593].Set(__Matchers[592], __Matchers[413], _switched, __Matchers[414]);
                /* 595 OptionalOp       */ __Matchers[595].Set(__Matchers[594]);
                /* 597 SeqOp            */ __Matchers[597].Set(__Matchers[595], __Matchers[596], __Matchers[413], _caseItem, __Matchers[414], _conditionalExpression);
                /* 599 SeqOp            */ __Matchers[599].Set(__Matchers[598], _conditions, _thenExpression, _elseExpression);
                /* 600 SeqOp            */ __Matchers[600].Set(__Matchers[594], _conditionalExpression);
                /* 602 SeqOp            */ __Matchers[602].Set(__Matchers[601], _conditionalExpression);
                /* 603 AltOp            */ __Matchers[603].Set(_ifExpr, _letExpr, _disjunctionExpression);
                /* 604 AltOp            */ __Matchers[604].Set(_voidFunctionExpr, _inferredFunctionExpr);
                /* 605 SeqOp            */ __Matchers[605].Set(__Matchers[465], __Matchers[466], __Matchers[467], __Matchers[504], _functionDefinition);
                /* 606 OptionalOp       */ __Matchers[606].Set(__Matchers[470]);
                /* 607 SeqOp            */ __Matchers[607].Set(__Matchers[606], __Matchers[466], __Matchers[467], __Matchers[504], _functionDefinition);
                /* 608 AltOp            */ __Matchers[608].Set(_block, _functionSpecifier);
                /* 609 AltOp            */ __Matchers[609].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 610 AltOp            */ __Matchers[610].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 612 OptionalOp       */ __Matchers[612].Set(_forIterator);
                /* 613 SeqOp            */ __Matchers[613].Set(__Matchers[611], __Matchers[413], __Matchers[612], __Matchers[414], _comprehensionClause);
                /* 614 SeqOp            */ __Matchers[614].Set(__Matchers[598], _conditions, _comprehensionClause);
                /* 615 AltOp            */ __Matchers[615].Set(_letExpr, _ifExpr, _switchExpr, _functionExpression, _operatorExpression);
                /* 616 AltOp            */ __Matchers[616].Set(_assignmentExpr, _thenElseExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 629 AltOp            */ __Matchers[629].Set(__Matchers[389], __Matchers[618], __Matchers[619], __Matchers[620], __Matchers[621], __Matchers[622], __Matchers[623], __Matchers[624], __Matchers[625], __Matchers[626], __Matchers[627], __Matchers[628]);
                /* 630 AltOp            */ __Matchers[630].Set(_thenElseExpr, _disjunctionExpression);
                /* 631 SeqOp            */ __Matchers[631].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 632 AltOp            */ __Matchers[632].Set(__Matchers[594], __Matchers[601]);
                /* 633 AltOp            */ __Matchers[633].Set(_disjunctionExpr, _conjunctionExpression);
                /* 634 SeqOp            */ __Matchers[634].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 636 AltOp            */ __Matchers[636].Set(_conjunctionExpr, _logicalNegationExpression);
                /* 637 SeqOp            */ __Matchers[637].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 639 AltOp            */ __Matchers[639].Set(_logicalNegationExpr, _expressionOrMeta);
                /* 640 SeqOp            */ __Matchers[640].Set(_notOperator, _logicalNegationExpression);
                /* 642 AltOp            */ __Matchers[642].Set(_equalityExpression, _modelReference);
                /* 643 AltOp            */ __Matchers[643].Set(_equalityExpr, _comparisonExpression);
                /* 644 SeqOp            */ __Matchers[644].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 648 AltOp            */ __Matchers[648].Set(__Matchers[645], __Matchers[646], __Matchers[647]);
                /* 649 AltOp            */ __Matchers[649].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 650 SeqOp            */ __Matchers[650].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 651 SeqOp            */ __Matchers[651].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 652 SeqOp            */ __Matchers[652].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 653 SeqOp            */ __Matchers[653].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 654 SeqOp            */ __Matchers[654].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 655 SeqOp            */ __Matchers[655].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 657 AltOp            */ __Matchers[657].Set(__Matchers[656], __Matchers[486]);
                /* 659 AltOp            */ __Matchers[659].Set(__Matchers[658], __Matchers[477]);
                /* 661 AltOp            */ __Matchers[661].Set(__Matchers[660], __Matchers[478]);
                /* 663 AltOp            */ __Matchers[663].Set(__Matchers[662], __Matchers[420], __Matchers[440], __Matchers[445]);
                /* 664 AltOp            */ __Matchers[664].Set(_existsExpr, _nonemptyExpr, _entryRangeExpression);
                /* 666 SeqOp            */ __Matchers[666].Set(_entryRangeExpression, __Matchers[665]);
                /* 668 SeqOp            */ __Matchers[668].Set(_entryRangeExpression, __Matchers[667]);
                /* 669 AltOp            */ __Matchers[669].Set(_rangeExpr, _entryExpr, _additiveExpression);
                /* 670 SeqOp            */ __Matchers[670].Set(_additiveExpression, _rangeOperator, _additiveExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_additiveExpression, _entryOperator, _additiveExpression);
                /* 673 AltOp            */ __Matchers[673].Set(__Matchers[672], __Matchers[377]);
                /* 674 AltOp            */ __Matchers[674].Set(_additiveExpr, _scaleExpression);
                /* 675 SeqOp            */ __Matchers[675].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 677 AltOp            */ __Matchers[677].Set(__Matchers[410], __Matchers[676]);
                /* 678 AltOp            */ __Matchers[678].Set(_scaleExpr, _multiplicativeExpression);
                /* 679 SeqOp            */ __Matchers[679].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 681 AltOp            */ __Matchers[681].Set(_multiplicativeExpr, _unionExpression);
                /* 682 SeqOp            */ __Matchers[682].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 685 AltOp            */ __Matchers[685].Set(__Matchers[409], __Matchers[683], __Matchers[684]);
                /* 686 AltOp            */ __Matchers[686].Set(_unionExpr, _exclusiveExpression);
                /* 687 SeqOp            */ __Matchers[687].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 689 AltOp            */ __Matchers[689].Set(__Matchers[447], __Matchers[688]);
                /* 690 AltOp            */ __Matchers[690].Set(_exclusiveExpr, _intersectionExpression);
                /* 691 SeqOp            */ __Matchers[691].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 693 AltOp            */ __Matchers[693].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 694 SeqOp            */ __Matchers[694].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 696 AltOp            */ __Matchers[696].Set(_negationOrComplementExpr, _prefixExpression);
                /* 697 SeqOp            */ __Matchers[697].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 698 AltOp            */ __Matchers[698].Set(_negateOperator, _neutralOperator, _complementOperator);
                /* 699 NotOp            */ __Matchers[699].Set(__Matchers_699_DFA);
                /* 700 SeqOp            */ __Matchers[700].Set(__Matchers[676], __Matchers[699]);
                /* 701 NotOp            */ __Matchers[701].Set(__Matchers_701_DFA);
                /* 702 SeqOp            */ __Matchers[702].Set(__Matchers[410], __Matchers[701]);
                /* 703 AltOp            */ __Matchers[703].Set(_prefixExpr, _postfixExpression);
                /* 704 SeqOp            */ __Matchers[704].Set(_incrementOperator, _prefixExpression);
                /* 705 AltOp            */ __Matchers[705].Set(_postfixExpr, _primary);
                /* 706 SeqOp            */ __Matchers[706].Set(_postfixExpression, _incrementOperator);
                /* 709 AltOp            */ __Matchers[709].Set(__Matchers[707], __Matchers[708]);
                /* 710 AltOp            */ __Matchers[710].Set(_selectionExpr, _indexedExpr, _callExpr, _baseExpression);
                /* 711 SeqOp            */ __Matchers[711].Set(_primary, _memberSelectionOperator, _baseReference);
                /* 714 AltOp            */ __Matchers[714].Set(__Matchers[361], __Matchers[712], __Matchers[713]);
                /* 715 SeqOp            */ __Matchers[715].Set(_primary, __Matchers[399], _index, __Matchers[401]);
                /* 716 AltOp            */ __Matchers[716].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 717 SeqOp            */ __Matchers[717].Set(_indexExpression, __Matchers[391]);
                /* 718 SeqOp            */ __Matchers[718].Set(__Matchers[391], _indexExpression);
                /* 719 SeqOp            */ __Matchers[719].Set(_indexExpression, __Matchers[672], _indexExpression);
                /* 720 SeqOp            */ __Matchers[720].Set(_indexExpression, __Matchers[377], _indexExpression);
                /* 721 SeqOp            */ __Matchers[721].Set(_primary, _arguments);
                /* 722 AltOp            */ __Matchers[722].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumerationExpr, _tupleExpr, _objectExpr, _groupedExpr, _baseReferenceOrParameterized);
                /* 723 AltOp            */ __Matchers[723].Set(_literalNatural, _literalFloat, _literalChar);
                /* 724 AltOp            */ __Matchers[724].Set(_stringLiteral, _stringInterpolation);
                /* 725 StarOp           */ __Matchers[725].Set(_interpolationPart);
                /* 726 SeqOp            */ __Matchers[726].Set(_stringStart, _expression, __Matchers[725], _stringEnd);
                /* 727 SeqOp            */ __Matchers[727].Set(_stringMid, _expression);
                /* 728 AltOp            */ __Matchers[728].Set(_literalString, _verbatimString);
                /* 729 SeqOp            */ __Matchers[729].Set(__Matchers[507], __Matchers[508], __Matchers[493], _block);
                /* 730 SeqOp            */ __Matchers[730].Set(__Matchers[413], _expression, __Matchers[414]);
                /* 731 OptionalOp       */ __Matchers[731].Set(_typeArgumentList);
                /* 732 SeqOp            */ __Matchers[732].Set(__Matchers[477], __Matchers[731], __Matchers[478]);
                /* 733 SeqOp            */ __Matchers[733].Set(__Matchers[381], _variancedType);
                /* 734 StarOp           */ __Matchers[734].Set(__Matchers[733]);
                /* 735 SeqOp            */ __Matchers[735].Set(_variancedType, __Matchers[734]);
                /* 736 SeqOp            */ __Matchers[736].Set(__Matchers[483], _type);
                /* 737 SeqOp            */ __Matchers[737].Set(__Matchers[381], _defaultedType);
                /* 738 StarOp           */ __Matchers[738].Set(__Matchers[737]);
                /* 739 SeqOp            */ __Matchers[739].Set(_defaultedType, __Matchers[738]);
                /* 740 AltOp            */ __Matchers[740].Set(_defaultedTypeCore, _variadicType);
                /* 741 SeqOp            */ __Matchers[741].Set(_type, __Matchers[389]);
                /* 742 AltOp            */ __Matchers[742].Set(_variadicTypeCore, _type);
                /* 743 SeqOp            */ __Matchers[743].Set(_unionType, _variadicOperator);
                /* 744 SeqOp            */ __Matchers[744].Set(__Matchers[409], _unionType);
                /* 745 AltOp            */ __Matchers[745].Set(_entryType, _unionType);
                /* 746 SeqOp            */ __Matchers[746].Set(_unionType, __Matchers[396], _unionType);
                /* 747 AltOp            */ __Matchers[747].Set(_unionTypeCore, _intersectionType);
                /* 748 SeqOp            */ __Matchers[748].Set(_unionType, __Matchers[447], _intersectionType);
                /* 749 AltOp            */ __Matchers[749].Set(_intersectionTypeCore, _primaryType);
                /* 750 SeqOp            */ __Matchers[750].Set(_intersectionType, __Matchers[695], _primaryType);
                /* 751 AltOp            */ __Matchers[751].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _packageQualifiedType, _typePath);
                /* 753 SeqOp            */ __Matchers[753].Set(_primaryType, __Matchers[752]);
                /* 754 OptionalOp       */ __Matchers[754].Set(_literalNatural);
                /* 755 SeqOp            */ __Matchers[755].Set(_primaryType, __Matchers[399], __Matchers[754], __Matchers[401]);
                /* 756 OptionalOp       */ __Matchers[756].Set(_typeTypeArguments);
                /* 757 SeqOp            */ __Matchers[757].Set(_primaryType, __Matchers[413], __Matchers[756], __Matchers[414]);
                /* 758 AltOp            */ __Matchers[758].Set(_spreadType, _defaultedTypeList);
                /* 759 SeqOp            */ __Matchers[759].Set(__Matchers[399], __Matchers[756], __Matchers[401]);
                /* 760 OptionalOp       */ __Matchers[760].Set(_variadicType);
                /* 761 SeqOp            */ __Matchers[761].Set(__Matchers[369], __Matchers[760], __Matchers[371]);
                /* 762 SeqOp            */ __Matchers[762].Set(__Matchers[477], _type, __Matchers[478]);
                /* 763 SeqOp            */ __Matchers[763].Set(__Matchers[376], __Matchers[361], _typePath);
                /* 764 OptionalOp       */ __Matchers[764].Set(_stringLiteral);
                /* 765 StarOp           */ __Matchers[765].Set(_annotation);
                /* 766 SeqOp            */ __Matchers[766].Set(__Matchers[764], __Matchers[765]);
                /* 767 SeqOp            */ __Matchers[767].Set(_memberName, __Matchers[429]);
                /* 768 OptionalOp       */ __Matchers[768].Set(_conditionList);
                /* 769 SeqOp            */ __Matchers[769].Set(__Matchers[413], __Matchers[768], __Matchers[414]);
                /* 770 SeqOp            */ __Matchers[770].Set(__Matchers[381], _condition);
                /* 771 StarOp           */ __Matchers[771].Set(__Matchers[770]);
                /* 772 SeqOp            */ __Matchers[772].Set(_condition, __Matchers[771]);
                /* 773 AltOp            */ __Matchers[773].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 774 OptionalOp       */ __Matchers[774].Set(__Matchers[641]);
                /* 775 SeqOp            */ __Matchers[775].Set(__Matchers[774], __Matchers[665], _letOrExpression);
                /* 776 SeqOp            */ __Matchers[776].Set(__Matchers[774], __Matchers[667], _letOrExpression);
                /* 777 AltOp            */ __Matchers[777].Set(_letVariable, _operatorExpression);
                /* 778 SeqOp            */ __Matchers[778].Set(__Matchers[774], __Matchers[662], _type, _isConditionVariable);
                /* 779 SeqOp            */ __Matchers[779].Set(_memberName, __Matchers[461]);
                /* 780 SeqOp            */ __Matchers[780].Set(__Matchers[440], _type, _typeName);
                /* 781 AltOp            */ __Matchers[781].Set(_ifElseStatement, _forElseStatement, _switchStatement, _whileStatement, _tryStatement);
                /* 782 StarOp           */ __Matchers[782].Set(_elseIf);
                /* 783 OptionalOp       */ __Matchers[783].Set(_elseBlock);
                /* 784 SeqOp            */ __Matchers[784].Set(__Matchers[598], _conditions, _block, __Matchers[782], __Matchers[783]);
                /* 785 SeqOp            */ __Matchers[785].Set(__Matchers[594], __Matchers[598], _conditions, _block);
                /* 786 SeqOp            */ __Matchers[786].Set(__Matchers[594], _block);
                /* 787 PlusOp           */ __Matchers[787].Set(_caseBlock);
                /* 788 SeqOp            */ __Matchers[788].Set(_switchHeader, __Matchers[787], __Matchers[783]);
                /* 789 SeqOp            */ __Matchers[789].Set(__Matchers[595], __Matchers[596], __Matchers[413], _caseItem, __Matchers[414], _block);
                /* 790 AltOp            */ __Matchers[790].Set(_isCaseCondition, _satisfiesCaseCondition, _valueCaseList, _pattern);
                /* 791 SeqOp            */ __Matchers[791].Set(__Matchers[662], _type);
                /* 792 SeqOp            */ __Matchers[792].Set(__Matchers[440], _type);
                /* 793 SeqOp            */ __Matchers[793].Set(_valueCaseSeparator, _valueCase);
                /* 794 StarOp           */ __Matchers[794].Set(__Matchers[793]);
                /* 795 SeqOp            */ __Matchers[795].Set(_valueCase, __Matchers[794]);
                /* 796 AltOp            */ __Matchers[796].Set(__Matchers[381], __Matchers[447]);
                /* 797 AltOp            */ __Matchers[797].Set(_intersectionType, _intersectionExpression);
                /* 798 SeqOp            */ __Matchers[798].Set(__Matchers[611], __Matchers[413], __Matchers[612], __Matchers[414], _block, __Matchers[783]);
                /* 799 SeqOp            */ __Matchers[799].Set(_forVariable, _containment);
                /* 800 SeqOp            */ __Matchers[800].Set(_containmentOperator, _operatorExpression);
                /* 801 AltOp            */ __Matchers[801].Set(__Matchers[486], __Matchers[377]);
                /* 803 SeqOp            */ __Matchers[803].Set(__Matchers[802], _conditions, _block);
                /* 805 OptionalOp       */ __Matchers[805].Set(_resources);
                /* 806 StarOp           */ __Matchers[806].Set(_catchBlock);
                /* 807 OptionalOp       */ __Matchers[807].Set(_finallyBlock);
                /* 808 SeqOp            */ __Matchers[808].Set(__Matchers[804], __Matchers[805], _block, __Matchers[806], __Matchers[807]);
                /* 810 OptionalOp       */ __Matchers[810].Set(_variable);
                /* 811 SeqOp            */ __Matchers[811].Set(__Matchers[809], __Matchers[413], __Matchers[810], __Matchers[414], _block);
                /* 813 SeqOp            */ __Matchers[813].Set(__Matchers[812], _block);
                /* 814 OptionalOp       */ __Matchers[814].Set(_resourceList);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[413], __Matchers[814], __Matchers[414]);
                /* 816 SeqOp            */ __Matchers[816].Set(__Matchers[381], _resource);
                /* 817 StarOp           */ __Matchers[817].Set(__Matchers[816]);
                /* 818 SeqOp            */ __Matchers[818].Set(_resource, __Matchers[817]);
                /* 819 AltOp            */ __Matchers[819].Set(_specifiedVariable, _operatorExpression);
                /* 820 SeqOp            */ __Matchers[820].Set(_variable, _valueSpecifier);
                /* 821 OptionalOp       */ __Matchers[821].Set(_variableType);
                /* 822 StarOp           */ __Matchers[822].Set(_parameters);
                /* 823 SeqOp            */ __Matchers[823].Set(__Matchers[821], _memberName, __Matchers[822]);
                /* 824 AltOp            */ __Matchers[824].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 825 SeqOp            */ __Matchers[825].Set(__Matchers[692], _modelExpression);
                /* 827 SeqOp            */ __Matchers[827].Set(__Matchers[826], _metaExpression, __Matchers[826]);
                /* 828 AltOp            */ __Matchers[828].Set(_declarationReference, _modelExpression);
                /* 829 AltOp            */ __Matchers[829].Set(_memberModelExpression, _typeModelExpression);
                /* 830 AltOp            */ __Matchers[830].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 831 SeqOp            */ __Matchers[831].Set(__Matchers[376], __Matchers[361], _memberReference);
                /* 832 SeqOp            */ __Matchers[832].Set(_primaryType, __Matchers[361], _memberReference);
                /* 833 AltOp            */ __Matchers[833].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _objectLiteral, _functionLiteral);
                /* 834 OptionalOp       */ __Matchers[834].Set(_packagePath);
                /* 835 SeqOp            */ __Matchers[835].Set(__Matchers[366], __Matchers[834]);
                /* 836 SeqOp            */ __Matchers[836].Set(__Matchers[376], __Matchers[834]);
                /* 837 SeqOp            */ __Matchers[837].Set(__Matchers[520], _referencePath);
                /* 838 SeqOp            */ __Matchers[838].Set(__Matchers[526], _referencePath);
                /* 839 SeqOp            */ __Matchers[839].Set(__Matchers[503], _referencePath);
                /* 840 SeqOp            */ __Matchers[840].Set(__Matchers[490], _referencePath);
                /* 841 SeqOp            */ __Matchers[841].Set(__Matchers[499], _referencePath);
                /* 842 SeqOp            */ __Matchers[842].Set(__Matchers[474], _referencePath);
                /* 843 SeqOp            */ __Matchers[843].Set(__Matchers[507], _referencePath);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[470], _referencePath);
                /* 845 SeqOp            */ __Matchers[845].Set(__Matchers[376], __Matchers[361]);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[452], _referencePathElementList);
                /* 847 SeqOp            */ __Matchers[847].Set(__Matchers[361], _referencePathElement);
                /* 848 StarOp           */ __Matchers[848].Set(__Matchers[847]);
                /* 849 SeqOp            */ __Matchers[849].Set(_referencePathElement, __Matchers[848]);

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
                __Matchers_699_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_699_DFA.States[0].Set(
                    new DfaTrans(__Matchers_699_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_699_DFA.States[1].Set(
                );
                __Matchers_701_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_701_DFA.States[0].Set(
                    new DfaTrans(__Matchers_701_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_701_DFA.States[1].Set(
                );
            }

            private PlainRule _compilationUnit;
            private PlainRule _codeUnit;
            private PlainRule _namespace;
            private PlainRule _namespacePath;
            private PlainRule _imports;
            private PlainRule _moduleDescriptor;
            private PlainRule _version;
            private PlainRule _moduleName;
            private PlainRule _moduleBody;
            private PlainRule _moduleBodyElement;
            private PlainRule _moduleImport;
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
            private PlainRule _entryPattern;
            private PlainRule _variableOrTuplePattern;
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
            private PlainRule _topDeclarations;
            private PlainRule _topDeclaration;
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
            private PlainRule _methodDefinition;
            private PlainRule _typedAttributeDeclaration;
            private PlainRule _inferredAttributeDeclaration;
            private PlainRule _attributeDefinition;
            private PlainRule _classDeclaration;
            private PlainRule _classDefinition;
            private PlainRule _optionalClassSpecifier;
            private PlainRule _interfaceDeclaration;
            private PlainRule _interfaceDefinition;
            private PlainRule _statements;
            private PlainRule _statement;
            private PlainRule _declarationStatement;
            private PlainRule _unclosedStatement;
            private PlainRule _openStatement;
            private PlainRule _expressionStatement;
            private PlainRule _specificationStatement;
            private PlainRule _returnStatement;
            private PlainRule _throwStatement;
            private PlainRule _breakStatement;
            private PlainRule _continueStatement;
            private PlainRule _valueSpecifier;
            private PlainRule _functionSpecifier;
            private PlainRule _optionalFunctionSpecifier;
            private PlainRule _requiredFunctionSpecifier;
            private PlainRule _typeSpecifier;
            private PlainRule _optionalTypeSpecifier;
            private PlainRule _anySpecifier;
            private PlainRule _optionalAnySpecifier;
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
            private PlainRule _inferredMethodArgument;
            private PlainRule _untypedMethodArgument;
            private PlainRule _typedGetterArgument;
            private PlainRule _inferredGetterArgument;
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
            private Dfa __Matchers_699_DFA = new Dfa("__Matchers_699_DFA");
            private Dfa __Matchers_701_DFA = new Dfa("__Matchers_701_DFA");
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
        public interface ICVersion : IRNode {}
        public interface ICModuleName : IRNode {}
        public interface ICModuleBody : IRNode {}
        public interface ICModuleBodyElement : IRNode {}
        public interface ICModuleImport : ICModuleBodyElement {}
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
        public interface ICPattern : ICCaseItem, ICForVariable, ICVariadicPattern {}
        public interface ICEntryPattern : ICParameterDeclarationOrRefPattern, ICPattern {}
        public interface ICVariableOrTuplePattern : IRNode {}
        public interface ICTuplePattern : ICParameterDeclarationOrRefPattern, ICPattern, ICVariableOrTuplePattern {}
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
        public interface ICTopDeclarations : IRNode {}
        public interface ICTopDeclaration : IRNode {}
        public interface ICDeclaration : ICDeclarationStatement {}
        public interface ICConstructorDeclaration : ICDeclaration {}
        public interface ICAliasDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICEnumeratedObjectDeclaration : ICDeclaration {}
        public interface ICObjectDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICSetterDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICSetterDefinition : IRNode {}
        public interface ICVoidMethodDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICInferredMethodDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICTypedMethodDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICMethodDefinition : IRNode {}
        public interface ICTypedAttributeDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICInferredAttributeDeclaration : ICDeclaration, ICModuleBodyElement, ICTopDeclaration {}
        public interface ICAttributeDefinition : IRNode {}
        public interface ICClassDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICClassDefinition : IRNode {}
        public interface ICOptionalClassSpecifier : ICClassDefinition {}
        public interface ICInterfaceDeclaration : ICDeclaration, ICTopDeclaration {}
        public interface ICInterfaceDefinition : IRNode {}
        public interface ICStatements : IRNode {}
        public interface ICStatement : IRNode {}
        public interface ICDeclarationStatement : ICStatement {}
        public interface ICUnclosedStatement : ICStatement {}
        public interface ICOpenStatement : IRNode {}
        public interface ICExpressionStatement : ICOpenStatement {}
        public interface ICSpecificationStatement : ICOpenStatement {}
        public interface ICReturnStatement : ICOpenStatement {}
        public interface ICThrowStatement : ICOpenStatement {}
        public interface ICBreakStatement : ICOpenStatement {}
        public interface ICContinueStatement : ICOpenStatement {}
        public interface ICValueSpecifier : ICAnySpecifier {}
        public interface ICFunctionSpecifier : ICAnySpecifier, ICFunctionDefinition {}
        public interface ICOptionalFunctionSpecifier : ICMethodDefinition {}
        public interface ICRequiredFunctionSpecifier : ICSetterDefinition {}
        public interface ICTypeSpecifier : IRNode {}
        public interface ICOptionalTypeSpecifier : ICInterfaceDefinition {}
        public interface ICAnySpecifier : IRNode {}
        public interface ICOptionalAnySpecifier : ICAttributeDefinition {}
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
        public interface ICInferredMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICUntypedMethodArgument : ICNamedArgumentDeclaration {}
        public interface ICTypedGetterArgument : ICNamedArgumentDeclaration {}
        public interface ICInferredGetterArgument : ICNamedArgumentDeclaration {}
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
        public interface ICType : ICTypeModelExpression, ICVariableType, ICVariadicType {}
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
        public interface ICVariable : ICVariablePattern {}
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
        public interface ICKwVoid : ICVariableType {}
        public interface ICKwFunction : ICVariableType {}
        public interface ICKwValue : ICVariableType {}
        public interface ICLiteralFloat : ICNonstringLiteral {}
        public interface ICLiteralNatural : ICNonstringLiteral {}
        public interface ICLiteralChar : ICNonstringLiteral {}
        public interface ICStringStart : IRNode {}
        public interface ICStringMid : IRNode {}
        public interface ICStringEnd : IRNode {}
        public interface ICLiteralString : ICStringLiteral, ICVersion {}
        public interface ICVerbatimString : ICStringLiteral {}
        public interface ICLowerIdentifier : ICMemberName {}
        public interface ICUpperIdentifier : ICTypeName {}
        public interface ICIdentifier : ICImportName, ICPackageName, ICReferencePathElement {}

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

            public CNamespace Namespace => Get<CNamespace>(0);
            public CImports Imports => Get<CImports>(1);
            public CTopDeclarations TopDeclarations => Get<CTopDeclarations>(2);
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
            public ROptional<ICVersion> Version => Get<ROptional<ICVersion>>(3);
            public CModuleBody ModuleBody => Get<CModuleBody>(4);
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
            public ICModuleName ModuleName => Get<ICModuleName>(2);
            public ROptional<ICVersion> Version => Get<ROptional<ICVersion>>(3);
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

        public partial class CTopDeclarations : RStar<ICTopDeclaration>, ICTopDeclarations
        {
            // *star*
            public CTopDeclarations(params RNode[] children) : base(children) {}
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

        public partial class CTypeSpecifier : RSequence, ICTypeSpecifier
        {
            // sequence
            public CTypeSpecifier(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '=>'
            public ICType Type => Get<ICType>(1);
        }

        public partial class COptionalTypeSpecifier : RSequence, ICOptionalTypeSpecifier
        {
            // sequence
            public COptionalTypeSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CTypeSpecifier> TypeSpecifier => Get<ROptional<CTypeSpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
        }

        public partial class COptionalAnySpecifier : RSequence, ICOptionalAnySpecifier
        {
            // sequence
            public COptionalAnySpecifier(params RNode[] children) : base(children) {}

            public ROptional<ICAnySpecifier> AnySpecifier => Get<ROptional<ICAnySpecifier>>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
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

            public ICType Type => Get<ICType>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
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

        public partial class CUntypedMethodArgument : RSequence, ICUntypedMethodArgument
        {
            // sequence
            public CUntypedMethodArgument(params RNode[] children) : base(children) {}

            public ICMemberName MemberName => Get<ICMemberName>(0);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(1);
            public CRequiredFunctionSpecifier RequiredFunctionSpecifier => Get<CRequiredFunctionSpecifier>(2);
        }

        public partial class CTypedGetterArgument : RSequence, ICTypedGetterArgument
        {
            // sequence
            public CTypedGetterArgument(params RNode[] children) : base(children) {}

            public ICType Type => Get<ICType>(0);
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
        }

        public partial class CInferredGetterArgument : RSequence, ICInferredGetterArgument
        {
            // sequence
            public CInferredGetterArgument(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'value'
            public ICMemberName MemberName => Get<ICMemberName>(1);
            public ICMethodDefinition MethodDefinition => Get<ICMethodDefinition>(2);
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
            public CContainment Containment => Get<CContainment>(1);
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

            protected virtual void Visit(CModuleBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CModuleImport element)
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

            protected virtual void Visit(CTopDeclarations element)
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

            protected virtual void Visit(CValueSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
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

            protected virtual void Visit(CTypeSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalTypeSpecifier element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COptionalAnySpecifier element)
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

            protected virtual void Visit(CInferredMethodArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CUntypedMethodArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTypedGetterArgument element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CInferredGetterArgument element)
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
