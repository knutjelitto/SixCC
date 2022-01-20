// <generated from="C:\\Dev\\Knut\\SixCC\\Six.Ceylon\\Ceylon.six" at="20.01.2022 15:51:27" />

using System.Collections.Generic;
using Six.Runtime;
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
                : base(new Matcher[879])
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
                /*  69 PlainRuleOp      */ __Matchers[69] = _parameterDeclarationOrRef = new PlainRule(this, 69, "parameter-declaration-or-ref") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _parameter = new PlainRule(this, 70, "parameter") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _parameterReference = new PlainRule(this, 71, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _parameterDeclaration = new PlainRule(this, 72, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _functionParameterDeclaration = new PlainRule(this, 73, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _functionParameterType = new PlainRule(this, 74, "function-parameter-type") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _valueParameterDeclaration = new PlainRule(this, 75, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _valueParameterType = new PlainRule(this, 76, "value-parameter-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _typeParameters = new PlainRule(this, 77, "type-parameters") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _typeParameterList = new PlainRule(this, 78, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _typeParameter = new PlainRule(this, 79, "type-parameter") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _variance = new PlainRule(this, 80, "variance") { Creator = node => new CVariance(node) };
                /*  81 PlainRuleOp      */ __Matchers[81] = _typeDefault = new PlainRule(this, 81, "type-default") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _typeConstraint = new PlainRule(this, 82, "type-constraint") { Builder = nodes => nodes[0] };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeConstraints = new PlainRule(this, 83, "type-constraints") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _declarationOrStatement = new PlainRule(this, 84, "declaration-or-statement") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _declaration = new PlainRule(this, 85, "declaration") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _constructorDeclaration = new PlainRule(this, 86, "constructor-declaration") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _aliasDeclaration = new PlainRule(this, 87, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _enumeratedObject = new PlainRule(this, 88, "enumerated-object") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _objectDeclaration = new PlainRule(this, 89, "object-declaration") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _setterDeclaration = new PlainRule(this, 90, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _setterDefinition = new PlainRule(this, 91, "setter-definition") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _typedMethodDeclaration = new PlainRule(this, 92, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _methodType = new PlainRule(this, 93, "method-type") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _inferredMethodDeclaration = new PlainRule(this, 94, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _typedAttributeDeclaration = new PlainRule(this, 95, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _attributeType = new PlainRule(this, 96, "attribute-type") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _inferredAttributeDeclaration = new PlainRule(this, 97, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _attributeDefinition = new PlainRule(this, 98, "attribute-definition") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _optionalAnySpecifier = new PlainRule(this, 99, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _classDeclaration = new PlainRule(this, 100, "class-declaration") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _classDefinition = new PlainRule(this, 101, "class-definition") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _optionalClassSpecifier = new PlainRule(this, 102, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _interfaceDeclaration = new PlainRule(this, 103, "interface-declaration") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _interfaceDefinition = new PlainRule(this, 104, "interface-definition") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _optionalTypeSpecifier = new PlainRule(this, 105, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _statement = new PlainRule(this, 106, "statement") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _unclosedStatement = new PlainRule(this, 107, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _openStatement = new PlainRule(this, 108, "open-statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _specificationStatement = new PlainRule(this, 109, "specification-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _expressionStatement = new PlainRule(this, 110, "expression-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _directiveStatement = new PlainRule(this, 111, "directive-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _returnDirective = new PlainRule(this, 112, "return-directive") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _throwDirective = new PlainRule(this, 113, "throw-directive") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _breakDirective = new PlainRule(this, 114, "break-directive") { Creator = node => new CBreakDirective(node) };
                /* 115 PlainRuleOp      */ __Matchers[115] = _continueDirective = new PlainRule(this, 115, "continue-directive") { Creator = node => new CContinueDirective(node) };
                /* 116 PlainRuleOp      */ __Matchers[116] = _typeSpecifier = new PlainRule(this, 116, "type-specifier") { Builder = nodes => nodes[0] };
                /* 117 PlainRuleOp      */ __Matchers[117] = _valueSpecifier = new PlainRule(this, 117, "value-specifier") { Builder = nodes => nodes[0] };
                /* 118 PlainRuleOp      */ __Matchers[118] = _functionSpecifier = new PlainRule(this, 118, "function-specifier") { Builder = nodes => nodes[0] };
                /* 119 PlainRuleOp      */ __Matchers[119] = _anySpecifier = new PlainRule(this, 119, "any-specifier") { Builder = nodes => nodes[0] };
                /* 120 PlainRuleOp      */ __Matchers[120] = _baseReferenceOrParameterized = new PlainRule(this, 120, "base-reference-or-parameterized") { Builder = nodes => nodes[0] };
                /* 121 PlainRuleOp      */ __Matchers[121] = _baseReference = new PlainRule(this, 121, "base-reference") { Builder = nodes => nodes[0] };
                /* 122 PlainRuleOp      */ __Matchers[122] = _parametrizedMember = new PlainRule(this, 122, "parametrized-member") { Builder = nodes => nodes[0] };
                /* 123 PlainRuleOp      */ __Matchers[123] = _selfParametrizedMember = new PlainRule(this, 123, "self-parametrized-member") { Builder = nodes => nodes[0] };
                /* 124 PlainRuleOp      */ __Matchers[124] = _memberReference = new PlainRule(this, 124, "member-reference") { Builder = nodes => nodes[0] };
                /* 125 PlainRuleOp      */ __Matchers[125] = _typeReference = new PlainRule(this, 125, "type-reference") { Builder = nodes => nodes[0] };
                /* 126 PlainRuleOp      */ __Matchers[126] = _selfReferenceSelector = new PlainRule(this, 126, "self-reference-selector") { Builder = nodes => nodes[0] };
                /* 127 PlainRuleOp      */ __Matchers[127] = _selfReference = new PlainRule(this, 127, "self-reference") { Creator = node => new CSelfReference(node) };
                /* 128 PlainRuleOp      */ __Matchers[128] = _enumeration = new PlainRule(this, 128, "enumeration") { Builder = nodes => nodes[0] };
                /* 129 PlainRuleOp      */ __Matchers[129] = _tuple = new PlainRule(this, 129, "tuple") { Builder = nodes => nodes[0] };
                /* 130 PlainRuleOp      */ __Matchers[130] = _arguments = new PlainRule(this, 130, "arguments") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _structuralArguments = new PlainRule(this, 131, "structural-arguments") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _namedOrAnonymous = new PlainRule(this, 132, "named-or-anonymous") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _namedArgument = new PlainRule(this, 133, "named-argument") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _namedSpecifiedArgument = new PlainRule(this, 134, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _sequencedArguments = new PlainRule(this, 135, "sequenced-arguments") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _sequencedArgument = new PlainRule(this, 136, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _anonymousArgument = new PlainRule(this, 137, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _namedArgumentDeclaration = new PlainRule(this, 138, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _objectArgument = new PlainRule(this, 139, "object-argument") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _typedMethodArgument = new PlainRule(this, 140, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _methodDefinition = new PlainRule(this, 141, "method-definition") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _optionalFunctionSpecifier = new PlainRule(this, 142, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _neededFunctionSpecifier = new PlainRule(this, 143, "needed-function-specifier") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _methodArgumentType = new PlainRule(this, 144, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _typedGetterArgument = new PlainRule(this, 145, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _getterArgumentType = new PlainRule(this, 146, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _inferredMethodArgument = new PlainRule(this, 147, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _inferredGetterArgument = new PlainRule(this, 148, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _untypedMethodArgument = new PlainRule(this, 149, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _untypedGetterArgument = new PlainRule(this, 150, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _positionalArguments = new PlainRule(this, 151, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _positionalArgument = new PlainRule(this, 152, "positional-argument") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _spreadArgument = new PlainRule(this, 153, "spread-argument") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _letExpression = new PlainRule(this, 154, "let-expression") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _letVariableList = new PlainRule(this, 155, "let-variable-list") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _letVariable = new PlainRule(this, 156, "let-variable") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _switchExpression = new PlainRule(this, 157, "switch-expression") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _caseExpressions = new PlainRule(this, 158, "case-expressions") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _caseExpression = new PlainRule(this, 159, "case-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _ifExpression = new PlainRule(this, 160, "if-expression") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _elseExpression = new PlainRule(this, 161, "else-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _thenExpression = new PlainRule(this, 162, "then-expression") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _conditionalExpression = new PlainRule(this, 163, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _functionExpression = new PlainRule(this, 164, "function-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _functionExpressionType = new PlainRule(this, 165, "function-expression-type") { Creator = node => new CFunctionExpressionType(node) };
                /* 166 PlainRuleOp      */ __Matchers[166] = _functionParameters = new PlainRule(this, 166, "function-parameters") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _functionDefinition = new PlainRule(this, 167, "function-definition") { Builder = nodes => nodes[0] };
                /* 168 PlainRuleOp      */ __Matchers[168] = _comprehension = new PlainRule(this, 168, "comprehension") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _comprehensionClause = new PlainRule(this, 169, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _expressionComprehensionClause = new PlainRule(this, 170, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _forComprehensionClause = new PlainRule(this, 171, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _ifComprehensionClause = new PlainRule(this, 172, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _expression = new PlainRule(this, 173, "expression") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _operatorExpression = new PlainRule(this, 174, "operator-expression") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _assignmentExpression = new PlainRule(this, 175, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _assignment = new PlainRule(this, 176, "assignment") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _assignmentOperator = new PlainRule(this, 177, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 178 PlainRuleOp      */ __Matchers[178] = _thenElseExpression = new PlainRule(this, 178, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 179 PlainRuleOp      */ __Matchers[179] = _thenElse = new PlainRule(this, 179, "then-else") { Builder = nodes => nodes[0] };
                /* 180 PlainRuleOp      */ __Matchers[180] = _thenElseOperator = new PlainRule(this, 180, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 181 PlainRuleOp      */ __Matchers[181] = _disjunctionExpression = new PlainRule(this, 181, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _disjunction = new PlainRule(this, 182, "disjunction") { Builder = nodes => nodes[0] };
                /* 183 PlainRuleOp      */ __Matchers[183] = _disjunctionOperator = new PlainRule(this, 183, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 184 PlainRuleOp      */ __Matchers[184] = _conjunctionExpression = new PlainRule(this, 184, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _conjunction = new PlainRule(this, 185, "conjunction") { Builder = nodes => nodes[0] };
                /* 186 PlainRuleOp      */ __Matchers[186] = _conjunctionOperator = new PlainRule(this, 186, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 187 PlainRuleOp      */ __Matchers[187] = _logicalNegationExpression = new PlainRule(this, 187, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _logicalNegation = new PlainRule(this, 188, "logical-negation") { Builder = nodes => nodes[0] };
                /* 189 PlainRuleOp      */ __Matchers[189] = _notOperator = new PlainRule(this, 189, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 190 PlainRuleOp      */ __Matchers[190] = _expressionOrMeta = new PlainRule(this, 190, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _equalityExpression = new PlainRule(this, 191, "equality-expression") { Builder = nodes => nodes[0] };
                /* 192 PlainRuleOp      */ __Matchers[192] = _equality = new PlainRule(this, 192, "equality") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _equalityOperator = new PlainRule(this, 193, "equality-operator") { Creator = node => new CEqualityOperator(node) };
                /* 194 PlainRuleOp      */ __Matchers[194] = _comparisonExpression = new PlainRule(this, 194, "comparison-expression") { Builder = nodes => nodes[0] };
                /* 195 PlainRuleOp      */ __Matchers[195] = _comparisonExpr = new PlainRule(this, 195, "comparison-expr") { Builder = nodes => nodes[0] };
                /* 196 PlainRuleOp      */ __Matchers[196] = _largerExpr = new PlainRule(this, 196, "larger-expr") { Builder = nodes => nodes[0] };
                /* 197 PlainRuleOp      */ __Matchers[197] = _smallerExpr = new PlainRule(this, 197, "smaller-expr") { Builder = nodes => nodes[0] };
                /* 198 PlainRuleOp      */ __Matchers[198] = _largerBoundsExpr = new PlainRule(this, 198, "larger-bounds-expr") { Builder = nodes => nodes[0] };
                /* 199 PlainRuleOp      */ __Matchers[199] = _smallerBoundsExpr = new PlainRule(this, 199, "smaller-bounds-expr") { Builder = nodes => nodes[0] };
                /* 200 PlainRuleOp      */ __Matchers[200] = _typecheckExpr = new PlainRule(this, 200, "typecheck-expr") { Builder = nodes => nodes[0] };
                /* 201 PlainRuleOp      */ __Matchers[201] = _comparisonOperator = new PlainRule(this, 201, "comparison-operator") { Creator = node => new CComparisonOperator(node) };
                /* 202 PlainRuleOp      */ __Matchers[202] = _smallerOperator = new PlainRule(this, 202, "smaller-operator") { Creator = node => new CSmallerOperator(node) };
                /* 203 PlainRuleOp      */ __Matchers[203] = _largerOperator = new PlainRule(this, 203, "larger-operator") { Creator = node => new CLargerOperator(node) };
                /* 204 PlainRuleOp      */ __Matchers[204] = _typeOperator = new PlainRule(this, 204, "type-operator") { Creator = node => new CTypeOperator(node) };
                /* 205 PlainRuleOp      */ __Matchers[205] = _existsNonemptyExpression = new PlainRule(this, 205, "exists-nonempty-expression") { Builder = nodes => nodes[0] };
                /* 206 PlainRuleOp      */ __Matchers[206] = _existsExpression = new PlainRule(this, 206, "exists-expression") { Builder = nodes => nodes[0] };
                /* 207 PlainRuleOp      */ __Matchers[207] = _nonemptyExpression = new PlainRule(this, 207, "nonempty-expression") { Builder = nodes => nodes[0] };
                /* 208 PlainRuleOp      */ __Matchers[208] = _entryRangeExpression = new PlainRule(this, 208, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _entryOrRange = new PlainRule(this, 209, "entry-or-range") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _rangeOrEntryOperator = new PlainRule(this, 210, "range-or-entry-operator") { Creator = node => new CRangeOrEntryOperator(node) };
                /* 211 PlainRuleOp      */ __Matchers[211] = _additiveExpression = new PlainRule(this, 211, "additive-expression") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _additiveExpr = new PlainRule(this, 212, "additive-expr") { Builder = nodes => nodes[0] };
                /* 213 PlainRuleOp      */ __Matchers[213] = _additiveOperator = new PlainRule(this, 213, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 214 PlainRuleOp      */ __Matchers[214] = _scaleExpression = new PlainRule(this, 214, "scale-expression") { Builder = nodes => nodes[0] };
                /* 215 PlainRuleOp      */ __Matchers[215] = _scaleExpr = new PlainRule(this, 215, "scale-expr") { Builder = nodes => nodes[0] };
                /* 216 PlainRuleOp      */ __Matchers[216] = _scaleOperator = new PlainRule(this, 216, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 217 PlainRuleOp      */ __Matchers[217] = _multiplicativeExpression = new PlainRule(this, 217, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 218 PlainRuleOp      */ __Matchers[218] = _multiplicativeExpr = new PlainRule(this, 218, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 219 PlainRuleOp      */ __Matchers[219] = _multiplicativeOperator = new PlainRule(this, 219, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 220 PlainRuleOp      */ __Matchers[220] = _unionExpression = new PlainRule(this, 220, "union-expression") { Builder = nodes => nodes[0] };
                /* 221 PlainRuleOp      */ __Matchers[221] = _unionExpr = new PlainRule(this, 221, "union-expr") { Builder = nodes => nodes[0] };
                /* 222 PlainRuleOp      */ __Matchers[222] = _unionOperator = new PlainRule(this, 222, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 223 PlainRuleOp      */ __Matchers[223] = _exclusiveExpression = new PlainRule(this, 223, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 224 PlainRuleOp      */ __Matchers[224] = _exclusiveExpr = new PlainRule(this, 224, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 225 PlainRuleOp      */ __Matchers[225] = _exclusiveOperator = new PlainRule(this, 225, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 226 PlainRuleOp      */ __Matchers[226] = _intersectionExpression = new PlainRule(this, 226, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 227 PlainRuleOp      */ __Matchers[227] = _intersectionExpr = new PlainRule(this, 227, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 228 PlainRuleOp      */ __Matchers[228] = _intersectionOperator = new PlainRule(this, 228, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 229 PlainRuleOp      */ __Matchers[229] = _negationOrComplementExpression = new PlainRule(this, 229, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _negationOrComplementExpr = new PlainRule(this, 230, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 231 PlainRuleOp      */ __Matchers[231] = _unaryMinusOrComplementOperator = new PlainRule(this, 231, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _opNegate = new PlainRule(this, 232, "op-negate") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _opNeutral = new PlainRule(this, 233, "op-neutral") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _opComplement = new PlainRule(this, 234, "op-complement") { Creator = node => new COpComplement(node) };
                /* 235 PlainRuleOp      */ __Matchers[235] = _prefixExpression = new PlainRule(this, 235, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _prefixExpr = new PlainRule(this, 236, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 237 PlainRuleOp      */ __Matchers[237] = _postfixExpression = new PlainRule(this, 237, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _postfixExpr = new PlainRule(this, 238, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _incrementOperator = new PlainRule(this, 239, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 240 PlainRuleOp      */ __Matchers[240] = _primary = new PlainRule(this, 240, "primary") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _selectionExpression = new PlainRule(this, 241, "selection-expression") { Builder = nodes => nodes[0] };
                /* 242 PlainRuleOp      */ __Matchers[242] = _qualifiedReference = new PlainRule(this, 242, "qualified-reference") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _memberSelectionOperator = new PlainRule(this, 243, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 244 PlainRuleOp      */ __Matchers[244] = _indexedExpression = new PlainRule(this, 244, "indexed-expression") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _index = new PlainRule(this, 245, "index") { Builder = nodes => nodes[0] };
                /* 246 PlainRuleOp      */ __Matchers[246] = _upperSpanned = new PlainRule(this, 246, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _lowerSpanned = new PlainRule(this, 247, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _spanned = new PlainRule(this, 248, "spanned") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _measured = new PlainRule(this, 249, "measured") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _indexExpression = new PlainRule(this, 250, "index-expression") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _callExpression = new PlainRule(this, 251, "call-expression") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _baseExpression = new PlainRule(this, 252, "base-expression") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _nonstringLiteral = new PlainRule(this, 253, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _stringExpression = new PlainRule(this, 254, "string-expression") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _stringInterpolation = new PlainRule(this, 255, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _interpolationPart = new PlainRule(this, 256, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _stringLiteral = new PlainRule(this, 257, "string-literal") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _objectExpression = new PlainRule(this, 258, "object-expression") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _groupedExpression = new PlainRule(this, 259, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _typeArguments = new PlainRule(this, 260, "type-arguments") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _typeArgumentList = new PlainRule(this, 261, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _variancedType = new PlainRule(this, 262, "varianced-type") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _defaultedTypeList = new PlainRule(this, 263, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _defaultedType = new PlainRule(this, 264, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _defaultedTypeCore = new PlainRule(this, 265, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _variadicType = new PlainRule(this, 266, "variadic-type") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _variadicUnionType = new PlainRule(this, 267, "variadic-union-type") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _variadicOperator = new PlainRule(this, 268, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
                /* 269 PlainRuleOp      */ __Matchers[269] = _spreadType = new PlainRule(this, 269, "spread-type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _type = new PlainRule(this, 270, "type") { Builder = nodes => nodes[0] };
                /* 271 PlainRuleOp      */ __Matchers[271] = _entryType = new PlainRule(this, 271, "entry-type") { Builder = nodes => nodes[0] };
                /* 272 PlainRuleOp      */ __Matchers[272] = _unionType = new PlainRule(this, 272, "union-type") { Builder = nodes => nodes[0] };
                /* 273 PlainRuleOp      */ __Matchers[273] = _unionTypeCore = new PlainRule(this, 273, "union-type-core") { Builder = nodes => nodes[0] };
                /* 274 PlainRuleOp      */ __Matchers[274] = _intersectionType = new PlainRule(this, 274, "intersection-type") { Builder = nodes => nodes[0] };
                /* 275 PlainRuleOp      */ __Matchers[275] = _intersectionTypeCore = new PlainRule(this, 275, "intersection-type-core") { Builder = nodes => nodes[0] };
                /* 276 PlainRuleOp      */ __Matchers[276] = _primaryType = new PlainRule(this, 276, "primary-type") { Builder = nodes => nodes[0] };
                /* 277 PlainRuleOp      */ __Matchers[277] = _nullableType = new PlainRule(this, 277, "nullable-type") { Builder = nodes => nodes[0] };
                /* 278 PlainRuleOp      */ __Matchers[278] = _arrayType = new PlainRule(this, 278, "array-type") { Builder = nodes => nodes[0] };
                /* 279 PlainRuleOp      */ __Matchers[279] = _functionType = new PlainRule(this, 279, "function-type") { Builder = nodes => nodes[0] };
                /* 280 PlainRuleOp      */ __Matchers[280] = _typeTypeArguments = new PlainRule(this, 280, "type-type-arguments") { Builder = nodes => nodes[0] };
                /* 281 PlainRuleOp      */ __Matchers[281] = _tupleType = new PlainRule(this, 281, "tuple-type") { Builder = nodes => nodes[0] };
                /* 282 PlainRuleOp      */ __Matchers[282] = _iterableType = new PlainRule(this, 282, "iterable-type") { Builder = nodes => nodes[0] };
                /* 283 PlainRuleOp      */ __Matchers[283] = _groupedType = new PlainRule(this, 283, "grouped-type") { Builder = nodes => nodes[0] };
                /* 284 PlainRuleOp      */ __Matchers[284] = _qualifiedType = new PlainRule(this, 284, "qualified-type") { Builder = nodes => nodes[0] };
                /* 285 PlainRuleOp      */ __Matchers[285] = _annotations = new PlainRule(this, 285, "annotations") { Builder = nodes => nodes[0] };
                /* 286 PlainRuleOp      */ __Matchers[286] = _annotation = new PlainRule(this, 286, "annotation") { Builder = nodes => nodes[0] };
                /* 287 PlainRuleOp      */ __Matchers[287] = _conditions = new PlainRule(this, 287, "conditions") { Builder = nodes => nodes[0] };
                /* 288 PlainRuleOp      */ __Matchers[288] = _conditionList = new PlainRule(this, 288, "condition-list") { Builder = nodes => nodes[0] };
                /* 289 PlainRuleOp      */ __Matchers[289] = _condition = new PlainRule(this, 289, "condition") { Builder = nodes => nodes[0] };
                /* 290 PlainRuleOp      */ __Matchers[290] = _existsCondition = new PlainRule(this, 290, "exists-condition") { Builder = nodes => nodes[0] };
                /* 291 PlainRuleOp      */ __Matchers[291] = _nonemptyCondition = new PlainRule(this, 291, "nonempty-condition") { Builder = nodes => nodes[0] };
                /* 292 PlainRuleOp      */ __Matchers[292] = _letOrExpression = new PlainRule(this, 292, "let-or-expression") { Builder = nodes => nodes[0] };
                /* 293 PlainRuleOp      */ __Matchers[293] = _isCondition = new PlainRule(this, 293, "is-condition") { Builder = nodes => nodes[0] };
                /* 294 PlainRuleOp      */ __Matchers[294] = _isConditionVariable = new PlainRule(this, 294, "is-condition-variable") { Builder = nodes => nodes[0] };
                /* 295 PlainRuleOp      */ __Matchers[295] = _satisfiesCondition = new PlainRule(this, 295, "satisfies-condition") { Builder = nodes => nodes[0] };
                /* 296 PlainRuleOp      */ __Matchers[296] = _booleanCondition = new PlainRule(this, 296, "boolean-condition") { Builder = nodes => nodes[0] };
                /* 297 PlainRuleOp      */ __Matchers[297] = _controlStatement = new PlainRule(this, 297, "control-statement") { Builder = nodes => nodes[0] };
                /* 298 PlainRuleOp      */ __Matchers[298] = _ifElseStatement = new PlainRule(this, 298, "if-else-statement") { Builder = nodes => nodes[0] };
                /* 299 PlainRuleOp      */ __Matchers[299] = _ifBlock = new PlainRule(this, 299, "if-block") { Builder = nodes => nodes[0] };
                /* 300 PlainRuleOp      */ __Matchers[300] = _elseBlock = new PlainRule(this, 300, "else-block") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _elseBlockNext = new PlainRule(this, 301, "else-block-next") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _switchCaseElse = new PlainRule(this, 302, "switch-case-else") { Builder = nodes => nodes[0] };
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
                /* 314 PlainRuleOp      */ __Matchers[314] = _forBlock = new PlainRule(this, 314, "for-block") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _failBlock = new PlainRule(this, 315, "fail-block") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _forIterator = new PlainRule(this, 316, "for-iterator") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _forVariable = new PlainRule(this, 317, "for-variable") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _containment = new PlainRule(this, 318, "containment") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _containmentOperator = new PlainRule(this, 319, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 320 PlainRuleOp      */ __Matchers[320] = _whileLoop = new PlainRule(this, 320, "while-loop") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _whileBlock = new PlainRule(this, 321, "while-block") { Builder = nodes => nodes[0] };
                /* 322 PlainRuleOp      */ __Matchers[322] = _tryCatchFinally = new PlainRule(this, 322, "try-catch-finally") { Builder = nodes => nodes[0] };
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
                /* 371 SeqOp            */ __Matchers[371] = new Seq(this, 371, "_(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 372 AltOp            */ __Matchers[372] = new Alt(this, 372, "alt(>module-descriptor|>package-descriptor|>unit-elements)") { Builder = nodes => nodes[0] };
                /* 373 StarOp           */ __Matchers[373] = new Star(this, 373, "*(>declaration)") { Builder = nodes => new RStar<IDeclaration>(nodes) };
                /* 374 SeqOp            */ __Matchers[374] = new Seq(this, 374, "_(>import-declarations,*(>declaration))") { Builder = nodes => new CUnitElements(nodes) };
                /* 375 StarOp           */ __Matchers[375] = new Star(this, 375, "*(>import-declaration)") { Builder = nodes => new CImportDeclarations(nodes) };
                /* 376 StringOp         */ __Matchers[376] = new Keyword(this, 376, "'module'", "module") { Creator = node => new RString(node) };
                /* 377 OptionalOp       */ __Matchers[377] = new Optional(this, 377, "?(>module-specifier)") { Builder = nodes => new ROptional<CModuleSpecifier>(nodes) };
                /* 378 OptionalOp       */ __Matchers[378] = new Optional(this, 378, "?(>version)") { Builder = nodes => new ROptional<IVersion>(nodes) };
                /* 379 SeqOp            */ __Matchers[379] = new Seq(this, 379, "_(>annotations,'module',>module-name,?(>module-specifier),?(>version),>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /* 380 StringOp         */ __Matchers[380] = new String(this, 380, "':'", ":") { Creator = node => new RString(node) };
                /* 381 OptionalOp       */ __Matchers[381] = new Optional(this, 381, "?(>artifact-and-classifier)") { Builder = nodes => new ROptional<CArtifactAndClassifier>(nodes) };
                /* 382 SeqOp            */ __Matchers[382] = new Seq(this, 382, "_(>repository,':',>module,?(>artifact-and-classifier))") { Builder = nodes => new CModuleSpecifier(nodes) };
                /* 383 AltOp            */ __Matchers[383] = new Alt(this, 383, "alt(>literal-string|>module-name)") { Builder = nodes => nodes[0] };
                /* 384 OptionalOp       */ __Matchers[384] = new Optional(this, 384, "?(>classifier)") { Builder = nodes => new ROptional<CClassifier>(nodes) };
                /* 385 SeqOp            */ __Matchers[385] = new Seq(this, 385, "_(>artifact,?(>classifier))") { Builder = nodes => new CArtifactAndClassifier(nodes) };
                /* 386 SeqOp            */ __Matchers[386] = new Seq(this, 386, "_(':',>literal-string)") { Builder = nodes => new CClassifier(nodes) };
                /* 387 StringOp         */ __Matchers[387] = new String(this, 387, "'{'", "{") { Creator = node => new RString(node) };
                /* 388 StarOp           */ __Matchers[388] = new Star(this, 388, "*(>module-body-element)") { Builder = nodes => new RStar<IModuleBodyElement>(nodes) };
                /* 389 StringOp         */ __Matchers[389] = new String(this, 389, "'}'", "}") { Creator = node => new RString(node) };
                /* 390 SeqOp            */ __Matchers[390] = new Seq(this, 390, "_('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /* 391 AltOp            */ __Matchers[391] = new Alt(this, 391, "alt(>inferred-attribute-declaration|>import-module)") { Builder = nodes => nodes[0] };
                /* 392 StringOp         */ __Matchers[392] = new Keyword(this, 392, "'package'", "package") { Creator = node => new RString(node) };
                /* 393 StringOp         */ __Matchers[393] = new String(this, 393, "';'", ";") { Creator = node => new RString(node) };
                /* 394 SeqOp            */ __Matchers[394] = new Seq(this, 394, "_(>annotations,'package',>package-path,';')") { Builder = nodes => new CPackageDescriptor(nodes) };
                /* 395 StringOp         */ __Matchers[395] = new Keyword(this, 395, "'import'", "import") { Creator = node => new RString(node) };
                /* 396 SeqOp            */ __Matchers[396] = new Seq(this, 396, "_(>annotations,'import',>module,?(>version),';')") { Builder = nodes => new CImportModule(nodes) };
                /* 397 SeqOp            */ __Matchers[397] = new Seq(this, 397, "_('import',>package-path,>import-elements)") { Builder = nodes => new CImportDeclaration(nodes) };
                /* 398 OptionalOp       */ __Matchers[398] = new Optional(this, 398, "?(>import-element-list)") { Builder = nodes => new ROptional<CImportElementList>(nodes) };
                /* 399 SeqOp            */ __Matchers[399] = new Seq(this, 399, "_('{',?(>import-element-list),'}')") { Builder = nodes => new CImportElements(nodes) };
                /* 400 StringOp         */ __Matchers[400] = new String(this, 400, "','", ",") { Creator = node => new RString(node) };
                /* 401 SeqOp            */ __Matchers[401] = new Seq(this, 401, "_(',',>import-element)") { Builder = nodes => new RSequence(nodes) };
                /* 402 StarOp           */ __Matchers[402] = new Star(this, 402, "*(_(',',>import-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 403 SeqOp            */ __Matchers[403] = new Seq(this, 403, "_(>import-element,*(_(',',>import-element)))") { Builder = nodes => new CImportElementList(nodes) };
                /* 404 AltOp            */ __Matchers[404] = new Alt(this, 404, "alt(>import-named|>import-wildcard)") { Builder = nodes => nodes[0] };
                /* 405 OptionalOp       */ __Matchers[405] = new Optional(this, 405, "?(>import-name-specifier)") { Builder = nodes => new ROptional<CImportNameSpecifier>(nodes) };
                /* 406 OptionalOp       */ __Matchers[406] = new Optional(this, 406, "?(>import-elements)") { Builder = nodes => new ROptional<CImportElements>(nodes) };
                /* 407 SeqOp            */ __Matchers[407] = new Seq(this, 407, "_(>import-name,?(>import-name-specifier),?(>import-elements))") { Builder = nodes => new CImportNamed(nodes) };
                /* 408 StringOp         */ __Matchers[408] = new String(this, 408, "'='", "=") { Creator = node => new RString(node) };
                /* 409 SeqOp            */ __Matchers[409] = new Seq(this, 409, "_('=',>identifier)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 410 StringOp         */ __Matchers[410] = new String(this, 410, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 411 StringOp         */ __Matchers[411] = new String(this, 411, "'.'", ".") { Creator = node => new RString(node) };
                /* 412 SeqOp            */ __Matchers[412] = new Seq(this, 412, "_('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 413 StarOp           */ __Matchers[413] = new Star(this, 413, "*(_('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 414 SeqOp            */ __Matchers[414] = new Seq(this, 414, "_(>package-name,*(_('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 415 AltOp            */ __Matchers[415] = new Alt(this, 415, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 416 AltOp            */ __Matchers[416] = new Alt(this, 416, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 417 AltOp            */ __Matchers[417] = new Alt(this, 417, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 418 StringOp         */ __Matchers[418] = new String(this, 418, "'->'", "->") { Creator = node => new RString(node) };
                /* 419 SeqOp            */ __Matchers[419] = new Seq(this, 419, "_(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 420 StringOp         */ __Matchers[420] = new String(this, 420, "'['", "[") { Creator = node => new RString(node) };
                /* 421 OptionalOp       */ __Matchers[421] = new Optional(this, 421, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 422 StringOp         */ __Matchers[422] = new String(this, 422, "']'", "]") { Creator = node => new RString(node) };
                /* 423 SeqOp            */ __Matchers[423] = new Seq(this, 423, "_('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 424 SeqOp            */ __Matchers[424] = new Seq(this, 424, "_(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 425 StarOp           */ __Matchers[425] = new Star(this, 425, "*(_(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 426 SeqOp            */ __Matchers[426] = new Seq(this, 426, "_(>variadic-pattern,*(_(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 427 AltOp            */ __Matchers[427] = new Alt(this, 427, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 428 OptionalOp       */ __Matchers[428] = new Optional(this, 428, "?(>union-type)") { Builder = nodes => new ROptional<IUnionType>(nodes) };
                /* 429 OptionalOp       */ __Matchers[429] = new Optional(this, 429, "?(>member-name)") { Builder = nodes => new ROptional<IMemberName>(nodes) };
                /* 430 SeqOp            */ __Matchers[430] = new Seq(this, 430, "_(?(>union-type),>variadic-operator,?(>member-name))") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 431 StringOp         */ __Matchers[431] = new Keyword(this, 431, "'let'", "let") { Creator = node => new RString(node) };
                /* 432 StringOp         */ __Matchers[432] = new String(this, 432, "'('", "(") { Creator = node => new RString(node) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "')'", ")") { Creator = node => new RString(node) };
                /* 434 SeqOp            */ __Matchers[434] = new Seq(this, 434, "_('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 435 StringOp         */ __Matchers[435] = new Keyword(this, 435, "'extends'", "extends") { Creator = node => new RString(node) };
                /* 436 SeqOp            */ __Matchers[436] = new Seq(this, 436, "_('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 437 OptionalOp       */ __Matchers[437] = new Optional(this, 437, "?(>assertion-message)") { Builder = nodes => new ROptional<IAssertionMessage>(nodes) };
                /* 438 StringOp         */ __Matchers[438] = new Keyword(this, 438, "'assert'", "assert") { Creator = node => new RString(node) };
                /* 439 SeqOp            */ __Matchers[439] = new Seq(this, 439, "_(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 440 StarOp           */ __Matchers[440] = new Star(this, 440, "*(>declaration-or-statement)") { Builder = nodes => new RStar<IDeclarationOrStatement>(nodes) };
                /* 441 SeqOp            */ __Matchers[441] = new Seq(this, 441, "_('{',>import-declarations,*(>declaration-or-statement),'}')") { Builder = nodes => new CBlockElements(nodes) };
                /* 442 StringOp         */ __Matchers[442] = new String(this, 442, "'=>'", "=>") { Creator = node => new RString(node) };
                /* 443 SeqOp            */ __Matchers[443] = new Seq(this, 443, "_('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 444 OptionalOp       */ __Matchers[444] = new Optional(this, 444, "?(>arguments)") { Builder = nodes => new ROptional<IArguments>(nodes) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 446 AltOp            */ __Matchers[446] = new Alt(this, 446, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_(>super-qualifier,>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 448 StringOp         */ __Matchers[448] = new Keyword(this, 448, "'super'", "super") { Creator = node => new RString(node) };
                /* 449 SeqOp            */ __Matchers[449] = new Seq(this, 449, "_('super','.')") { Builder = nodes => new CSuperQualifier(nodes) };
                /* 450 SeqOp            */ __Matchers[450] = new Seq(this, 450, "_(>package-qualifier,>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 451 SeqOp            */ __Matchers[451] = new Seq(this, 451, "_('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 452 AltOp            */ __Matchers[452] = new Alt(this, 452, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 454 SeqOp            */ __Matchers[454] = new Seq(this, 454, "_('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 455 StarOp           */ __Matchers[455] = new Star(this, 455, "*(_('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_(>type-reference,*(_('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 457 StringOp         */ __Matchers[457] = new Keyword(this, 457, "'satisfies'", "satisfies") { Creator = node => new RString(node) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 459 SeqOp            */ __Matchers[459] = new Seq(this, 459, "_(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 460 StarOp           */ __Matchers[460] = new Star(this, 460, "*(_(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_(>union-type,*(_(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 462 StringOp         */ __Matchers[462] = new Keyword(this, 462, "'of'", "of") { Creator = node => new RString(node) };
                /* 463 SeqOp            */ __Matchers[463] = new Seq(this, 463, "_('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 464 StringOp         */ __Matchers[464] = new String(this, 464, "'|'", "|") { Creator = node => new RString(node) };
                /* 465 SeqOp            */ __Matchers[465] = new Seq(this, 465, "_('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 466 StarOp           */ __Matchers[466] = new Star(this, 466, "*(_('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 467 SeqOp            */ __Matchers[467] = new Seq(this, 467, "_(>case-type,*(_('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 468 AltOp            */ __Matchers[468] = new Alt(this, 468, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 469 OptionalOp       */ __Matchers[469] = new Optional(this, 469, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 470 SeqOp            */ __Matchers[470] = new Seq(this, 470, "_(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 471 OptionalOp       */ __Matchers[471] = new Optional(this, 471, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 473 SeqOp            */ __Matchers[473] = new Seq(this, 473, "_(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 474 StarOp           */ __Matchers[474] = new Star(this, 474, "*(_(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_(>parameter-declaration-or-ref-pattern,*(_(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 476 AltOp            */ __Matchers[476] = new Alt(this, 476, "alt(>tuple-or-entry-pattern|>parameter-declaration-or-ref)") { Builder = nodes => nodes[0] };
                /* 477 AltOp            */ __Matchers[477] = new Alt(this, 477, "alt(>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 478 SeqOp            */ __Matchers[478] = new Seq(this, 478, "_(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 479 OptionalOp       */ __Matchers[479] = new Optional(this, 479, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 481 AltOp            */ __Matchers[481] = new Alt(this, 481, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 482 OptionalOp       */ __Matchers[482] = new Optional(this, 482, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 483 PlusOp           */ __Matchers[483] = new Plus(this, 483, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 484 OptionalOp       */ __Matchers[484] = new Optional(this, 484, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 485 SeqOp            */ __Matchers[485] = new Seq(this, 485, "_(>function-parameter-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CFunctionParameterDeclaration(nodes) };
                /* 486 AltOp            */ __Matchers[486] = new Alt(this, 486, "alt(>variadic-type|>kw-void|>kw-function)") { Builder = nodes => nodes[0] };
                /* 487 SeqOp            */ __Matchers[487] = new Seq(this, 487, "_(>value-parameter-type,>member-name,?(>value-specifier))") { Builder = nodes => new CValueParameterDeclaration(nodes) };
                /* 488 AltOp            */ __Matchers[488] = new Alt(this, 488, "alt(>variadic-type|>kw-value)") { Builder = nodes => nodes[0] };
                /* 489 StringOp         */ __Matchers[489] = new String(this, 489, "'<'", "<") { Creator = node => new RString(node) };
                /* 490 StringOp         */ __Matchers[490] = new String(this, 490, "'>'", ">") { Creator = node => new RString(node) };
                /* 491 SeqOp            */ __Matchers[491] = new Seq(this, 491, "_('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 492 SeqOp            */ __Matchers[492] = new Seq(this, 492, "_(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 493 StarOp           */ __Matchers[493] = new Star(this, 493, "*(_(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 494 SeqOp            */ __Matchers[494] = new Seq(this, 494, "_(>type-parameter,*(_(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 495 OptionalOp       */ __Matchers[495] = new Optional(this, 495, "?(>variance)") { Builder = nodes => new ROptional<IVariance>(nodes) };
                /* 496 OptionalOp       */ __Matchers[496] = new Optional(this, 496, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 497 SeqOp            */ __Matchers[497] = new Seq(this, 497, "_(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 498 StringOp         */ __Matchers[498] = new Keyword(this, 498, "'in'", "in") { Creator = node => new RString(node) };
                /* 499 StringOp         */ __Matchers[499] = new Keyword(this, 499, "'out'", "out") { Creator = node => new RString(node) };
                /* 500 AltOp            */ __Matchers[500] = new Alt(this, 500, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 501 SeqOp            */ __Matchers[501] = new Seq(this, 501, "_('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 502 StringOp         */ __Matchers[502] = new Keyword(this, 502, "'given'", "given") { Creator = node => new RString(node) };
                /* 503 OptionalOp       */ __Matchers[503] = new Optional(this, 503, "?(>type-name)") { Builder = nodes => new ROptional<ITypeName>(nodes) };
                /* 504 OptionalOp       */ __Matchers[504] = new Optional(this, 504, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 505 OptionalOp       */ __Matchers[505] = new Optional(this, 505, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 506 SeqOp            */ __Matchers[506] = new Seq(this, 506, "_('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 507 PlusOp           */ __Matchers[507] = new Plus(this, 507, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 508 AltOp            */ __Matchers[508] = new Alt(this, 508, "alt(>declaration|>statement)") { Builder = nodes => nodes[0] };
                /* 509 AltOp            */ __Matchers[509] = new Alt(this, 509, "alt(>constructor-declaration|>alias-declaration|>class-declaration|>interface-declaration|>object-declaration|>enumerated-object|>setter-declaration|>typed-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration)") { Builder = nodes => nodes[0] };
                /* 510 StringOp         */ __Matchers[510] = new Keyword(this, 510, "'new'", "new") { Creator = node => new RString(node) };
                /* 511 OptionalOp       */ __Matchers[511] = new Optional(this, 511, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 512 SeqOp            */ __Matchers[512] = new Seq(this, 512, "_(>annotations,'new',?(>member-name),>parameters,?(>delegated-constructor),>block)") { Builder = nodes => new CConstructorDeclaration(nodes) };
                /* 513 StringOp         */ __Matchers[513] = new Keyword(this, 513, "'alias'", "alias") { Creator = node => new RString(node) };
                /* 514 OptionalOp       */ __Matchers[514] = new Optional(this, 514, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 515 SeqOp            */ __Matchers[515] = new Seq(this, 515, "_(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 516 SeqOp            */ __Matchers[516] = new Seq(this, 516, "_(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObject(nodes) };
                /* 517 StringOp         */ __Matchers[517] = new Keyword(this, 517, "'object'", "object") { Creator = node => new RString(node) };
                /* 518 OptionalOp       */ __Matchers[518] = new Optional(this, 518, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 519 SeqOp            */ __Matchers[519] = new Seq(this, 519, "_(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 520 StringOp         */ __Matchers[520] = new Keyword(this, 520, "'assign'", "assign") { Creator = node => new RString(node) };
                /* 521 SeqOp            */ __Matchers[521] = new Seq(this, 521, "_(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 522 AltOp            */ __Matchers[522] = new Alt(this, 522, "alt(>block|>needed-function-specifier)") { Builder = nodes => nodes[0] };
                /* 523 SeqOp            */ __Matchers[523] = new Seq(this, 523, "_(>annotations,>method-type,>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 524 AltOp            */ __Matchers[524] = new Alt(this, 524, "alt(>variadic-type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 525 StringOp         */ __Matchers[525] = new Keyword(this, 525, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 526 SeqOp            */ __Matchers[526] = new Seq(this, 526, "_(>annotations,'function',>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 527 SeqOp            */ __Matchers[527] = new Seq(this, 527, "_(>annotations,>attribute-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 528 StringOp         */ __Matchers[528] = new Keyword(this, 528, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 529 SeqOp            */ __Matchers[529] = new Seq(this, 529, "_(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 530 AltOp            */ __Matchers[530] = new Alt(this, 530, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 531 OptionalOp       */ __Matchers[531] = new Optional(this, 531, "?(>any-specifier)") { Builder = nodes => new ROptional<IAnySpecifier>(nodes) };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 533 StringOp         */ __Matchers[533] = new Keyword(this, 533, "'class'", "class") { Creator = node => new RString(node) };
                /* 534 OptionalOp       */ __Matchers[534] = new Optional(this, 534, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 535 SeqOp            */ __Matchers[535] = new Seq(this, 535, "_(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 536 AltOp            */ __Matchers[536] = new Alt(this, 536, "alt(>class-block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 537 OptionalOp       */ __Matchers[537] = new Optional(this, 537, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 538 SeqOp            */ __Matchers[538] = new Seq(this, 538, "_(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 539 StringOp         */ __Matchers[539] = new Keyword(this, 539, "'interface'", "interface") { Creator = node => new RString(node) };
                /* 540 SeqOp            */ __Matchers[540] = new Seq(this, 540, "_(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 541 AltOp            */ __Matchers[541] = new Alt(this, 541, "alt(>interface-block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 542 OptionalOp       */ __Matchers[542] = new Optional(this, 542, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 543 SeqOp            */ __Matchers[543] = new Seq(this, 543, "_(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 544 AltOp            */ __Matchers[544] = new Alt(this, 544, "alt(>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 545 SeqOp            */ __Matchers[545] = new Seq(this, 545, "_(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 546 AltOp            */ __Matchers[546] = new Alt(this, 546, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 547 SeqOp            */ __Matchers[547] = new Seq(this, 547, "_(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 548 AltOp            */ __Matchers[548] = new Alt(this, 548, "alt(>return-directive|>throw-directive|>break-directive|>continue-directive)") { Builder = nodes => nodes[0] };
                /* 549 StringOp         */ __Matchers[549] = new Keyword(this, 549, "'return'", "return") { Creator = node => new RString(node) };
                /* 550 OptionalOp       */ __Matchers[550] = new Optional(this, 550, "?(>expression)") { Builder = nodes => new ROptional<IExpression>(nodes) };
                /* 551 SeqOp            */ __Matchers[551] = new Seq(this, 551, "_('return',?(>expression))") { Builder = nodes => new CReturnDirective(nodes) };
                /* 552 StringOp         */ __Matchers[552] = new Keyword(this, 552, "'throw'", "throw") { Creator = node => new RString(node) };
                /* 553 SeqOp            */ __Matchers[553] = new Seq(this, 553, "_('throw',?(>expression))") { Builder = nodes => new CThrowDirective(nodes) };
                /* 554 StringOp         */ __Matchers[554] = new Keyword(this, 554, "'break'", "break") { Creator = node => new CBreakDirective(node) };
                /* 555 StringOp         */ __Matchers[555] = new Keyword(this, 555, "'continue'", "continue") { Creator = node => new CContinueDirective(node) };
                /* 556 SeqOp            */ __Matchers[556] = new Seq(this, 556, "_('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 557 SeqOp            */ __Matchers[557] = new Seq(this, 557, "_('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 558 SeqOp            */ __Matchers[558] = new Seq(this, 558, "_('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 559 AltOp            */ __Matchers[559] = new Alt(this, 559, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 560 AltOp            */ __Matchers[560] = new Alt(this, 560, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 561 AltOp            */ __Matchers[561] = new Alt(this, 561, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 562 SeqOp            */ __Matchers[562] = new Seq(this, 562, "_(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 563 SeqOp            */ __Matchers[563] = new Seq(this, 563, "_(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 564 OptionalOp       */ __Matchers[564] = new Optional(this, 564, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 566 SeqOp            */ __Matchers[566] = new Seq(this, 566, "_(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 567 SeqOp            */ __Matchers[567] = new Seq(this, 567, "_(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 568 StringOp         */ __Matchers[568] = new Keyword(this, 568, "'this'", "this") { Creator = node => new RString(node) };
                /* 569 StringOp         */ __Matchers[569] = new Keyword(this, 569, "'outer'", "outer") { Creator = node => new RString(node) };
                /* 570 AltOp            */ __Matchers[570] = new Alt(this, 570, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 571 OptionalOp       */ __Matchers[571] = new Optional(this, 571, "?(>sequenced-arguments)") { Builder = nodes => new ROptional<CSequencedArguments>(nodes) };
                /* 572 SeqOp            */ __Matchers[572] = new Seq(this, 572, "_('{',*(>declaration-or-statement),?(>sequenced-arguments),'}')") { Builder = nodes => new CEnumeration(nodes) };
                /* 573 SeqOp            */ __Matchers[573] = new Seq(this, 573, "_('[',?(>sequenced-arguments),']')") { Builder = nodes => new CTuple(nodes) };
                /* 574 AltOp            */ __Matchers[574] = new Alt(this, 574, "alt(>structural-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 575 StarOp           */ __Matchers[575] = new Star(this, 575, "*(>named-or-anonymous)") { Builder = nodes => new RStar<INamedOrAnonymous>(nodes) };
                /* 576 SeqOp            */ __Matchers[576] = new Seq(this, 576, "_('{',*(>named-or-anonymous),?(>sequenced-arguments),'}')") { Builder = nodes => new CStructuralArguments(nodes) };
                /* 577 AltOp            */ __Matchers[577] = new Alt(this, 577, "alt(>named-argument|>anonymous-argument)") { Builder = nodes => nodes[0] };
                /* 578 AltOp            */ __Matchers[578] = new Alt(this, 578, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 580 SeqOp            */ __Matchers[580] = new Seq(this, 580, "_(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 581 StarOp           */ __Matchers[581] = new Star(this, 581, "*(_(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 582 SeqOp            */ __Matchers[582] = new Seq(this, 582, "_(>sequenced-argument,*(_(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArguments(nodes) };
                /* 583 AltOp            */ __Matchers[583] = new Alt(this, 583, "alt(>comprehension|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 584 SeqOp            */ __Matchers[584] = new Seq(this, 584, "_(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 585 AltOp            */ __Matchers[585] = new Alt(this, 585, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 586 SeqOp            */ __Matchers[586] = new Seq(this, 586, "_('object',?(>member-name),?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 587 SeqOp            */ __Matchers[587] = new Seq(this, 587, "_(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 588 AltOp            */ __Matchers[588] = new Alt(this, 588, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 589 SeqOp            */ __Matchers[589] = new Seq(this, 589, "_(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 590 SeqOp            */ __Matchers[590] = new Seq(this, 590, "_(>function-specifier,';')") { Builder = nodes => new CNeededFunctionSpecifier(nodes) };
                /* 591 AltOp            */ __Matchers[591] = new Alt(this, 591, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 592 SeqOp            */ __Matchers[592] = new Seq(this, 592, "_(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 594 SeqOp            */ __Matchers[594] = new Seq(this, 594, "_('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_(>member-name,+(>parameters),>needed-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 596 SeqOp            */ __Matchers[596] = new Seq(this, 596, "_(>member-name,>needed-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_('(',?(>sequenced-arguments),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 598 AltOp            */ __Matchers[598] = new Alt(this, 598, "alt(>expression|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 599 StringOp         */ __Matchers[599] = new String(this, 599, "'*'", "*") { Creator = node => new RString(node) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 601 OptionalOp       */ __Matchers[601] = new Optional(this, 601, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 602 SeqOp            */ __Matchers[602] = new Seq(this, 602, "_('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpression(nodes) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 604 StarOp           */ __Matchers[604] = new Star(this, 604, "*(_(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_(>let-variable,*(_(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 606 SeqOp            */ __Matchers[606] = new Seq(this, 606, "_(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 607 SeqOp            */ __Matchers[607] = new Seq(this, 607, "_(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpression(nodes) };
                /* 608 PlusOp           */ __Matchers[608] = new Plus(this, 608, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 609 OptionalOp       */ __Matchers[609] = new Optional(this, 609, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 610 SeqOp            */ __Matchers[610] = new Seq(this, 610, "_(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 611 StringOp         */ __Matchers[611] = new Keyword(this, 611, "'else'", "else") { Creator = node => new RString(node) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?('else')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 613 StringOp         */ __Matchers[613] = new Keyword(this, 613, "'case'", "case") { Creator = node => new RString(node) };
                /* 614 SeqOp            */ __Matchers[614] = new Seq(this, 614, "_(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 615 StringOp         */ __Matchers[615] = new Keyword(this, 615, "'if'", "if") { Creator = node => new RString(node) };
                /* 616 SeqOp            */ __Matchers[616] = new Seq(this, 616, "_('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpression(nodes) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new Keyword(this, 618, "'then'", "then") { Creator = node => new RString(node) };
                /* 619 SeqOp            */ __Matchers[619] = new Seq(this, 619, "_('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 620 AltOp            */ __Matchers[620] = new Alt(this, 620, "alt(>if-expression|>let-expression|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 621 OptionalOp       */ __Matchers[621] = new Optional(this, 621, "?(>function-expression-type)") { Builder = nodes => new ROptional<IFunctionExpressionType>(nodes) };
                /* 622 OptionalOp       */ __Matchers[622] = new Optional(this, 622, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 623 SeqOp            */ __Matchers[623] = new Seq(this, 623, "_(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpression(nodes) };
                /* 624 StringOp         */ __Matchers[624] = new Keyword(this, 624, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 625 AltOp            */ __Matchers[625] = new Alt(this, 625, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 626 SeqOp            */ __Matchers[626] = new Seq(this, 626, "_(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 627 AltOp            */ __Matchers[627] = new Alt(this, 627, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 628 AltOp            */ __Matchers[628] = new Alt(this, 628, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 629 AltOp            */ __Matchers[629] = new Alt(this, 629, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 630 StringOp         */ __Matchers[630] = new Keyword(this, 630, "'for'", "for") { Creator = node => new RString(node) };
                /* 631 OptionalOp       */ __Matchers[631] = new Optional(this, 631, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 632 SeqOp            */ __Matchers[632] = new Seq(this, 632, "_('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 633 SeqOp            */ __Matchers[633] = new Seq(this, 633, "_('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 634 AltOp            */ __Matchers[634] = new Alt(this, 634, "alt(>let-expression|>if-expression|>switch-expression|>function-expression|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 635 AltOp            */ __Matchers[635] = new Alt(this, 635, "alt(>assignment|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 636 SeqOp            */ __Matchers[636] = new Seq(this, 636, "_(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignment(nodes) };
                /* 637 StringOp         */ __Matchers[637] = new String(this, 637, "'+='", "+=") { Creator = node => new RString(node) };
                /* 638 StringOp         */ __Matchers[638] = new String(this, 638, "'-='", "-=") { Creator = node => new RString(node) };
                /* 639 StringOp         */ __Matchers[639] = new String(this, 639, "'*='", "*=") { Creator = node => new RString(node) };
                /* 640 StringOp         */ __Matchers[640] = new String(this, 640, "'/='", "/=") { Creator = node => new RString(node) };
                /* 641 StringOp         */ __Matchers[641] = new String(this, 641, "'%='", "%=") { Creator = node => new RString(node) };
                /* 642 StringOp         */ __Matchers[642] = new String(this, 642, "'&='", "&=") { Creator = node => new RString(node) };
                /* 643 StringOp         */ __Matchers[643] = new String(this, 643, "'|='", "|=") { Creator = node => new RString(node) };
                /* 644 StringOp         */ __Matchers[644] = new String(this, 644, "'^='", "^=") { Creator = node => new RString(node) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'~='", "~=") { Creator = node => new RString(node) };
                /* 646 StringOp         */ __Matchers[646] = new String(this, 646, "'&&='", "&&=") { Creator = node => new RString(node) };
                /* 647 StringOp         */ __Matchers[647] = new String(this, 647, "'||='", "||=") { Creator = node => new RString(node) };
                /* 648 AltOp            */ __Matchers[648] = new Alt(this, 648, "alt('='|'+='|'-='|'*='|'/='|'%='|'&='|'|='|'^='|'~='|'&&='|'||=')") { Builder = nodes => nodes[0] };
                /* 649 AltOp            */ __Matchers[649] = new Alt(this, 649, "alt(>then-else|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 650 SeqOp            */ __Matchers[650] = new Seq(this, 650, "_(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElse(nodes) };
                /* 651 AltOp            */ __Matchers[651] = new Alt(this, 651, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 652 AltOp            */ __Matchers[652] = new Alt(this, 652, "alt(>disjunction|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 653 SeqOp            */ __Matchers[653] = new Seq(this, 653, "_(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunction(nodes) };
                /* 654 StringOp         */ __Matchers[654] = new String(this, 654, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 655 AltOp            */ __Matchers[655] = new Alt(this, 655, "alt(>conjunction|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 656 SeqOp            */ __Matchers[656] = new Seq(this, 656, "_(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunction(nodes) };
                /* 657 StringOp         */ __Matchers[657] = new String(this, 657, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 658 AltOp            */ __Matchers[658] = new Alt(this, 658, "alt(>logical-negation|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 659 SeqOp            */ __Matchers[659] = new Seq(this, 659, "_(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegation(nodes) };
                /* 660 StringOp         */ __Matchers[660] = new String(this, 660, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 661 AltOp            */ __Matchers[661] = new Alt(this, 661, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 662 AltOp            */ __Matchers[662] = new Alt(this, 662, "alt(>equality|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 663 SeqOp            */ __Matchers[663] = new Seq(this, 663, "_(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEquality(nodes) };
                /* 664 StringOp         */ __Matchers[664] = new String(this, 664, "'=='", "==") { Creator = node => new RString(node) };
                /* 665 StringOp         */ __Matchers[665] = new String(this, 665, "'!='", "!=") { Creator = node => new RString(node) };
                /* 666 StringOp         */ __Matchers[666] = new String(this, 666, "'==='", "===") { Creator = node => new RString(node) };
                /* 667 AltOp            */ __Matchers[667] = new Alt(this, 667, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 668 AltOp            */ __Matchers[668] = new Alt(this, 668, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 669 SeqOp            */ __Matchers[669] = new Seq(this, 669, "_(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 670 SeqOp            */ __Matchers[670] = new Seq(this, 670, "_(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 671 SeqOp            */ __Matchers[671] = new Seq(this, 671, "_(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 672 SeqOp            */ __Matchers[672] = new Seq(this, 672, "_(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 673 SeqOp            */ __Matchers[673] = new Seq(this, 673, "_(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 674 SeqOp            */ __Matchers[674] = new Seq(this, 674, "_(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 675 StringOp         */ __Matchers[675] = new String(this, 675, "'<=>'", "<=>") { Creator = node => new RString(node) };
                /* 676 AltOp            */ __Matchers[676] = new Alt(this, 676, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 677 StringOp         */ __Matchers[677] = new String(this, 677, "'<='", "<=") { Creator = node => new RString(node) };
                /* 678 AltOp            */ __Matchers[678] = new Alt(this, 678, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 679 StringOp         */ __Matchers[679] = new String(this, 679, "'>='", ">=") { Creator = node => new RString(node) };
                /* 680 AltOp            */ __Matchers[680] = new Alt(this, 680, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 681 StringOp         */ __Matchers[681] = new Keyword(this, 681, "'is'", "is") { Creator = node => new RString(node) };
                /* 682 AltOp            */ __Matchers[682] = new Alt(this, 682, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 683 AltOp            */ __Matchers[683] = new Alt(this, 683, "alt(>exists-expression|>nonempty-expression|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 684 StringOp         */ __Matchers[684] = new Keyword(this, 684, "'exists'", "exists") { Creator = node => new RString(node) };
                /* 685 SeqOp            */ __Matchers[685] = new Seq(this, 685, "_(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpression(nodes) };
                /* 686 StringOp         */ __Matchers[686] = new Keyword(this, 686, "'nonempty'", "nonempty") { Creator = node => new RString(node) };
                /* 687 SeqOp            */ __Matchers[687] = new Seq(this, 687, "_(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpression(nodes) };
                /* 688 AltOp            */ __Matchers[688] = new Alt(this, 688, "alt(>entry-or-range|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 689 SeqOp            */ __Matchers[689] = new Seq(this, 689, "_(>additive-expression,>range-or-entry-operator,>additive-expression)") { Builder = nodes => new CEntryOrRange(nodes) };
                /* 690 StringOp         */ __Matchers[690] = new String(this, 690, "'..'", "..") { Creator = node => new RString(node) };
                /* 691 AltOp            */ __Matchers[691] = new Alt(this, 691, "alt('..'|':'|'->')") { Builder = nodes => nodes[0] };
                /* 692 AltOp            */ __Matchers[692] = new Alt(this, 692, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 693 SeqOp            */ __Matchers[693] = new Seq(this, 693, "_(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 694 StringOp         */ __Matchers[694] = new String(this, 694, "'+'", "+") { Creator = node => new RString(node) };
                /* 695 StringOp         */ __Matchers[695] = new String(this, 695, "'-'", "-") { Creator = node => new RString(node) };
                /* 696 AltOp            */ __Matchers[696] = new Alt(this, 696, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 697 AltOp            */ __Matchers[697] = new Alt(this, 697, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 698 SeqOp            */ __Matchers[698] = new Seq(this, 698, "_(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 699 StringOp         */ __Matchers[699] = new String(this, 699, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 700 AltOp            */ __Matchers[700] = new Alt(this, 700, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 701 SeqOp            */ __Matchers[701] = new Seq(this, 701, "_(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 702 StringOp         */ __Matchers[702] = new String(this, 702, "'/'", "/") { Creator = node => new RString(node) };
                /* 703 StringOp         */ __Matchers[703] = new String(this, 703, "'%'", "%") { Creator = node => new RString(node) };
                /* 704 AltOp            */ __Matchers[704] = new Alt(this, 704, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 705 AltOp            */ __Matchers[705] = new Alt(this, 705, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 706 SeqOp            */ __Matchers[706] = new Seq(this, 706, "_(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 707 StringOp         */ __Matchers[707] = new String(this, 707, "'~'", "~") { Creator = node => new COpComplement(node) };
                /* 708 AltOp            */ __Matchers[708] = new Alt(this, 708, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 709 AltOp            */ __Matchers[709] = new Alt(this, 709, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 710 SeqOp            */ __Matchers[710] = new Seq(this, 710, "_(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 711 StringOp         */ __Matchers[711] = new String(this, 711, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 712 AltOp            */ __Matchers[712] = new Alt(this, 712, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 713 SeqOp            */ __Matchers[713] = new Seq(this, 713, "_(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 714 StringOp         */ __Matchers[714] = new String(this, 714, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 715 AltOp            */ __Matchers[715] = new Alt(this, 715, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 716 SeqOp            */ __Matchers[716] = new Seq(this, 716, "_(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 717 AltOp            */ __Matchers[717] = new Alt(this, 717, "alt(>op-negate|>op-neutral|>op-complement)") { Builder = nodes => nodes[0] };
                /* 718 NotOp            */ __Matchers[718] = new Not(this, 718, "!('-')") { Builder = nodes => new RNot<RString>(nodes) };
                /* 719 SeqOp            */ __Matchers[719] = new Seq(this, 719, "_('-',!('-'))") { Builder = nodes => new COpNegate(nodes) };
                /* 720 NotOp            */ __Matchers[720] = new Not(this, 720, "!('+')") { Builder = nodes => new RNot<RString>(nodes) };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_('+',!('+'))") { Builder = nodes => new COpNeutral(nodes) };
                /* 722 AltOp            */ __Matchers[722] = new Alt(this, 722, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 723 SeqOp            */ __Matchers[723] = new Seq(this, 723, "_(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 724 AltOp            */ __Matchers[724] = new Alt(this, 724, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 725 SeqOp            */ __Matchers[725] = new Seq(this, 725, "_(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 726 StringOp         */ __Matchers[726] = new String(this, 726, "'++'", "++") { Creator = node => new RString(node) };
                /* 727 StringOp         */ __Matchers[727] = new String(this, 727, "'--'", "--") { Creator = node => new RString(node) };
                /* 728 AltOp            */ __Matchers[728] = new Alt(this, 728, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 729 AltOp            */ __Matchers[729] = new Alt(this, 729, "alt(>selection-expression|>indexed-expression|>call-expression|>base-expression)") { Builder = nodes => nodes[0] };
                /* 730 SeqOp            */ __Matchers[730] = new Seq(this, 730, "_(>primary,>qualified-reference)") { Builder = nodes => new CSelectionExpression(nodes) };
                /* 731 SeqOp            */ __Matchers[731] = new Seq(this, 731, "_(>member-selection-operator,>base-reference)") { Builder = nodes => new CQualifiedReference(nodes) };
                /* 732 StringOp         */ __Matchers[732] = new String(this, 732, "'?.'", "?.") { Creator = node => new RString(node) };
                /* 733 StringOp         */ __Matchers[733] = new String(this, 733, "'*.'", "*.") { Creator = node => new RString(node) };
                /* 734 AltOp            */ __Matchers[734] = new Alt(this, 734, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 735 SeqOp            */ __Matchers[735] = new Seq(this, 735, "_(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpression(nodes) };
                /* 736 AltOp            */ __Matchers[736] = new Alt(this, 736, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 739 SeqOp            */ __Matchers[739] = new Seq(this, 739, "_(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_(>primary,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 742 AltOp            */ __Matchers[742] = new Alt(this, 742, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration|>tuple|>object-expression|>grouped-expression|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 743 AltOp            */ __Matchers[743] = new Alt(this, 743, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 744 AltOp            */ __Matchers[744] = new Alt(this, 744, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 745 StarOp           */ __Matchers[745] = new Star(this, 745, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 746 SeqOp            */ __Matchers[746] = new Seq(this, 746, "_(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 747 SeqOp            */ __Matchers[747] = new Seq(this, 747, "_(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 748 AltOp            */ __Matchers[748] = new Alt(this, 748, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 749 SeqOp            */ __Matchers[749] = new Seq(this, 749, "_('object',?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectExpression(nodes) };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 751 OptionalOp       */ __Matchers[751] = new Optional(this, 751, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 752 SeqOp            */ __Matchers[752] = new Seq(this, 752, "_('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 753 SeqOp            */ __Matchers[753] = new Seq(this, 753, "_(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 754 StarOp           */ __Matchers[754] = new Star(this, 754, "*(_(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 755 SeqOp            */ __Matchers[755] = new Seq(this, 755, "_(>varianced-type,*(_(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 757 SeqOp            */ __Matchers[757] = new Seq(this, 757, "_(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 758 StarOp           */ __Matchers[758] = new Star(this, 758, "*(_(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 759 SeqOp            */ __Matchers[759] = new Seq(this, 759, "_(>defaulted-type,*(_(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 760 AltOp            */ __Matchers[760] = new Alt(this, 760, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 761 SeqOp            */ __Matchers[761] = new Seq(this, 761, "_(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 762 AltOp            */ __Matchers[762] = new Alt(this, 762, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 763 SeqOp            */ __Matchers[763] = new Seq(this, 763, "_(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 764 AltOp            */ __Matchers[764] = new Alt(this, 764, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 766 AltOp            */ __Matchers[766] = new Alt(this, 766, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 768 AltOp            */ __Matchers[768] = new Alt(this, 768, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 770 AltOp            */ __Matchers[770] = new Alt(this, 770, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 771 SeqOp            */ __Matchers[771] = new Seq(this, 771, "_(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 772 AltOp            */ __Matchers[772] = new Alt(this, 772, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>qualified-type)") { Builder = nodes => nodes[0] };
                /* 773 StringOp         */ __Matchers[773] = new String(this, 773, "'?'", "?") { Creator = node => new RString(node) };
                /* 774 SeqOp            */ __Matchers[774] = new Seq(this, 774, "_(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 775 OptionalOp       */ __Matchers[775] = new Optional(this, 775, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 776 SeqOp            */ __Matchers[776] = new Seq(this, 776, "_(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 777 OptionalOp       */ __Matchers[777] = new Optional(this, 777, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ITypeTypeArguments>(nodes) };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 779 AltOp            */ __Matchers[779] = new Alt(this, 779, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 780 SeqOp            */ __Matchers[780] = new Seq(this, 780, "_('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 781 OptionalOp       */ __Matchers[781] = new Optional(this, 781, "?(>variadic-type)") { Builder = nodes => new ROptional<IVariadicType>(nodes) };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 783 SeqOp            */ __Matchers[783] = new Seq(this, 783, "_('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 784 SeqOp            */ __Matchers[784] = new Seq(this, 784, "_(?(>package-qualifier),>type-path)") { Builder = nodes => new CQualifiedType(nodes) };
                /* 785 OptionalOp       */ __Matchers[785] = new Optional(this, 785, "?(>string-literal)") { Builder = nodes => new ROptional<IStringLiteral>(nodes) };
                /* 786 StarOp           */ __Matchers[786] = new Star(this, 786, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 787 SeqOp            */ __Matchers[787] = new Seq(this, 787, "_(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 788 SeqOp            */ __Matchers[788] = new Seq(this, 788, "_(>annotation-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 789 OptionalOp       */ __Matchers[789] = new Optional(this, 789, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 792 StarOp           */ __Matchers[792] = new Star(this, 792, "*(_(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 793 SeqOp            */ __Matchers[793] = new Seq(this, 793, "_(>condition,*(_(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 794 AltOp            */ __Matchers[794] = new Alt(this, 794, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 795 OptionalOp       */ __Matchers[795] = new Optional(this, 795, "?('!')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 796 SeqOp            */ __Matchers[796] = new Seq(this, 796, "_(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 797 SeqOp            */ __Matchers[797] = new Seq(this, 797, "_(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 798 AltOp            */ __Matchers[798] = new Alt(this, 798, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 800 SeqOp            */ __Matchers[800] = new Seq(this, 800, "_('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 801 AltOp            */ __Matchers[801] = new Alt(this, 801, "alt(>if-else-statement|>for-else-statement|>switch-case-else|>while-loop|>try-catch-finally)") { Builder = nodes => nodes[0] };
                /* 802 OptionalOp       */ __Matchers[802] = new Optional(this, 802, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 803 SeqOp            */ __Matchers[803] = new Seq(this, 803, "_(>if-block,?(>else-block))") { Builder = nodes => new CIfElseStatement(nodes) };
                /* 804 SeqOp            */ __Matchers[804] = new Seq(this, 804, "_('if',>conditions,>block)") { Builder = nodes => new CIfBlock(nodes) };
                /* 805 SeqOp            */ __Matchers[805] = new Seq(this, 805, "_('else',>else-block-next)") { Builder = nodes => new CElseBlock(nodes) };
                /* 806 AltOp            */ __Matchers[806] = new Alt(this, 806, "alt(>if-else-statement|>block)") { Builder = nodes => nodes[0] };
                /* 807 PlusOp           */ __Matchers[807] = new Plus(this, 807, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 808 SeqOp            */ __Matchers[808] = new Seq(this, 808, "_(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchCaseElse(nodes) };
                /* 809 StringOp         */ __Matchers[809] = new Keyword(this, 809, "'switch'", "switch") { Creator = node => new RString(node) };
                /* 810 SeqOp            */ __Matchers[810] = new Seq(this, 810, "_('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 811 SeqOp            */ __Matchers[811] = new Seq(this, 811, "_(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 812 AltOp            */ __Matchers[812] = new Alt(this, 812, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 813 OptionalOp       */ __Matchers[813] = new Optional(this, 813, "?('is')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 816 SeqOp            */ __Matchers[816] = new Seq(this, 816, "_(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 817 StarOp           */ __Matchers[817] = new Star(this, 817, "*(_(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 818 SeqOp            */ __Matchers[818] = new Seq(this, 818, "_(>value-case,*(_(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 819 AltOp            */ __Matchers[819] = new Alt(this, 819, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 820 AltOp            */ __Matchers[820] = new Alt(this, 820, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 821 OptionalOp       */ __Matchers[821] = new Optional(this, 821, "?(>fail-block)") { Builder = nodes => new ROptional<CFailBlock>(nodes) };
                /* 822 SeqOp            */ __Matchers[822] = new Seq(this, 822, "_(>for-block,?(>fail-block))") { Builder = nodes => new CForElseStatement(nodes) };
                /* 823 SeqOp            */ __Matchers[823] = new Seq(this, 823, "_('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 824 SeqOp            */ __Matchers[824] = new Seq(this, 824, "_('else',>block)") { Builder = nodes => new CFailBlock(nodes) };
                /* 825 OptionalOp       */ __Matchers[825] = new Optional(this, 825, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 826 SeqOp            */ __Matchers[826] = new Seq(this, 826, "_(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 827 AltOp            */ __Matchers[827] = new Alt(this, 827, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 828 SeqOp            */ __Matchers[828] = new Seq(this, 828, "_(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 829 AltOp            */ __Matchers[829] = new Alt(this, 829, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 830 StringOp         */ __Matchers[830] = new Keyword(this, 830, "'while'", "while") { Creator = node => new RString(node) };
                /* 831 SeqOp            */ __Matchers[831] = new Seq(this, 831, "_('while',>conditions,>block)") { Builder = nodes => new CWhileBlock(nodes) };
                /* 832 StarOp           */ __Matchers[832] = new Star(this, 832, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 833 OptionalOp       */ __Matchers[833] = new Optional(this, 833, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 834 SeqOp            */ __Matchers[834] = new Seq(this, 834, "_(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryCatchFinally(nodes) };
                /* 835 StringOp         */ __Matchers[835] = new Keyword(this, 835, "'try'", "try") { Creator = node => new RString(node) };
                /* 836 OptionalOp       */ __Matchers[836] = new Optional(this, 836, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 837 SeqOp            */ __Matchers[837] = new Seq(this, 837, "_('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 838 StringOp         */ __Matchers[838] = new Keyword(this, 838, "'catch'", "catch") { Creator = node => new RString(node) };
                /* 839 SeqOp            */ __Matchers[839] = new Seq(this, 839, "_('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 840 OptionalOp       */ __Matchers[840] = new Optional(this, 840, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 842 StringOp         */ __Matchers[842] = new Keyword(this, 842, "'finally'", "finally") { Creator = node => new RString(node) };
                /* 843 SeqOp            */ __Matchers[843] = new Seq(this, 843, "_('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 844 OptionalOp       */ __Matchers[844] = new Optional(this, 844, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 845 SeqOp            */ __Matchers[845] = new Seq(this, 845, "_('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 847 StarOp           */ __Matchers[847] = new Star(this, 847, "*(_(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 848 SeqOp            */ __Matchers[848] = new Seq(this, 848, "_(>resource,*(_(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 849 AltOp            */ __Matchers[849] = new Alt(this, 849, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 850 SeqOp            */ __Matchers[850] = new Seq(this, 850, "_(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 851 OptionalOp       */ __Matchers[851] = new Optional(this, 851, "?(>variable-type)") { Builder = nodes => new ROptional<IVariableType>(nodes) };
                /* 852 StarOp           */ __Matchers[852] = new Star(this, 852, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 853 SeqOp            */ __Matchers[853] = new Seq(this, 853, "_(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 854 AltOp            */ __Matchers[854] = new Alt(this, 854, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 855 SeqOp            */ __Matchers[855] = new Seq(this, 855, "_('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 856 StringOp         */ __Matchers[856] = new String(this, 856, "'`'", "`") { Creator = node => new RString(node) };
                /* 857 SeqOp            */ __Matchers[857] = new Seq(this, 857, "_('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 858 AltOp            */ __Matchers[858] = new Alt(this, 858, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 859 AltOp            */ __Matchers[859] = new Alt(this, 859, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 860 AltOp            */ __Matchers[860] = new Alt(this, 860, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 861 SeqOp            */ __Matchers[861] = new Seq(this, 861, "_(>package-qualifier,>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 862 SeqOp            */ __Matchers[862] = new Seq(this, 862, "_(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 863 AltOp            */ __Matchers[863] = new Alt(this, 863, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 864 OptionalOp       */ __Matchers[864] = new Optional(this, 864, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 868 SeqOp            */ __Matchers[868] = new Seq(this, 868, "_('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 870 SeqOp            */ __Matchers[870] = new Seq(this, 870, "_('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 871 SeqOp            */ __Matchers[871] = new Seq(this, 871, "_('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 872 SeqOp            */ __Matchers[872] = new Seq(this, 872, "_(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 873 AltOp            */ __Matchers[873] = new Alt(this, 873, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 874 SeqOp            */ __Matchers[874] = new Seq(this, 874, "_('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 875 SeqOp            */ __Matchers[875] = new Seq(this, 875, "_(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 876 SeqOp            */ __Matchers[876] = new Seq(this, 876, "_('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 877 StarOp           */ __Matchers[877] = new Star(this, 877, "*(_('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 878 SeqOp            */ __Matchers[878] = new Seq(this, 878, "_(>reference-path-element,*(_('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

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
                /*  12 PlainRuleOp      */ _classifier.Set(__Matchers[386]);
                /*  13 PlainRuleOp      */ _version.Set(_literalString);
                /*  14 PlainRuleOp      */ _moduleName.Set(_packagePath);
                /*  15 PlainRuleOp      */ _moduleBody.Set(__Matchers[390]);
                /*  16 PlainRuleOp      */ _moduleBodyElement.Set(__Matchers[391]);
                /*  17 PlainRuleOp      */ _packageDescriptor.Set(__Matchers[394]);
                /*  18 PlainRuleOp      */ _importModule.Set(__Matchers[396]);
                /*  19 PlainRuleOp      */ _importDeclaration.Set(__Matchers[397]);
                /*  20 PlainRuleOp      */ _importElements.Set(__Matchers[399]);
                /*  21 PlainRuleOp      */ _importElementList.Set(__Matchers[403]);
                /*  22 PlainRuleOp      */ _importElement.Set(__Matchers[404]);
                /*  23 PlainRuleOp      */ _importNamed.Set(__Matchers[407]);
                /*  24 PlainRuleOp      */ _importName.Set(_identifier);
                /*  25 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[409]);
                /*  26 PlainRuleOp      */ _importWildcard.Set(__Matchers[410]);
                /*  27 PlainRuleOp      */ _packageName.Set(_identifier);
                /*  28 PlainRuleOp      */ _packagePath.Set(__Matchers[414]);
                /*  29 PlainRuleOp      */ _annotationName.Set(_lowerIdentifier);
                /*  30 PlainRuleOp      */ _memberName.Set(_lowerIdentifier);
                /*  31 PlainRuleOp      */ _typeName.Set(_upperIdentifier);
                /*  32 PlainRuleOp      */ _pattern.Set(__Matchers[415]);
                /*  33 PlainRuleOp      */ _variableOrTuplePattern.Set(__Matchers[416]);
                /*  34 PlainRuleOp      */ _tupleOrEntryPattern.Set(__Matchers[417]);
                /*  35 PlainRuleOp      */ _entryPattern.Set(__Matchers[419]);
                /*  36 PlainRuleOp      */ _tuplePattern.Set(__Matchers[423]);
                /*  37 PlainRuleOp      */ _variadicPatternList.Set(__Matchers[426]);
                /*  38 PlainRuleOp      */ _variadicPattern.Set(__Matchers[427]);
                /*  39 PlainRuleOp      */ _variablePattern.Set(_variable);
                /*  40 PlainRuleOp      */ _variadicVariable.Set(__Matchers[430]);
                /*  41 PlainRuleOp      */ _letStatement.Set(__Matchers[434]);
                /*  42 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[436]);
                /*  43 PlainRuleOp      */ _assertionStatement.Set(__Matchers[439]);
                /*  44 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  45 PlainRuleOp      */ _block.Set(_blockElements);
                /*  46 PlainRuleOp      */ _interfaceBlock.Set(_blockElements);
                /*  47 PlainRuleOp      */ _classBlock.Set(_blockElements);
                /*  48 PlainRuleOp      */ _blockElements.Set(__Matchers[441]);
                /*  49 PlainRuleOp      */ _extendedType.Set(__Matchers[436]);
                /*  50 PlainRuleOp      */ _classSpecifier.Set(__Matchers[443]);
                /*  51 PlainRuleOp      */ _classInstatiation.Set(__Matchers[445]);
                /*  52 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[446]);
                /*  53 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[447]);
                /*  54 PlainRuleOp      */ _superQualifier.Set(__Matchers[449]);
                /*  55 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[450]);
                /*  56 PlainRuleOp      */ _packageQualifier.Set(__Matchers[451]);
                /*  57 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[452]);
                /*  58 PlainRuleOp      */ _memberPath.Set(__Matchers[453]);
                /*  59 PlainRuleOp      */ _typePath.Set(__Matchers[456]);
                /*  60 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[458]);
                /*  61 PlainRuleOp      */ _unionTypeList.Set(__Matchers[461]);
                /*  62 PlainRuleOp      */ _caseTypes.Set(__Matchers[463]);
                /*  63 PlainRuleOp      */ _caseTypeList.Set(__Matchers[467]);
                /*  64 PlainRuleOp      */ _caseType.Set(__Matchers[468]);
                /*  65 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[470]);
                /*  66 PlainRuleOp      */ _parameters.Set(__Matchers[472]);
                /*  67 PlainRuleOp      */ _parameterList.Set(__Matchers[475]);
                /*  68 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[476]);
                /*  69 PlainRuleOp      */ _parameterDeclarationOrRef.Set(__Matchers[477]);
                /*  70 PlainRuleOp      */ _parameter.Set(__Matchers[478]);
                /*  71 PlainRuleOp      */ _parameterReference.Set(__Matchers[480]);
                /*  72 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[481]);
                /*  73 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[485]);
                /*  74 PlainRuleOp      */ _functionParameterType.Set(__Matchers[486]);
                /*  75 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[487]);
                /*  76 PlainRuleOp      */ _valueParameterType.Set(__Matchers[488]);
                /*  77 PlainRuleOp      */ _typeParameters.Set(__Matchers[491]);
                /*  78 PlainRuleOp      */ _typeParameterList.Set(__Matchers[494]);
                /*  79 PlainRuleOp      */ _typeParameter.Set(__Matchers[497]);
                /*  80 PlainRuleOp      */ _variance.Set(__Matchers[500]);
                /*  81 PlainRuleOp      */ _typeDefault.Set(__Matchers[501]);
                /*  82 PlainRuleOp      */ _typeConstraint.Set(__Matchers[506]);
                /*  83 PlainRuleOp      */ _typeConstraints.Set(__Matchers[507]);
                /*  84 PlainRuleOp      */ _declarationOrStatement.Set(__Matchers[508]);
                /*  85 PlainRuleOp      */ _declaration.Set(__Matchers[509]);
                /*  86 PlainRuleOp      */ _constructorDeclaration.Set(__Matchers[512]);
                /*  87 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[515]);
                /*  88 PlainRuleOp      */ _enumeratedObject.Set(__Matchers[516]);
                /*  89 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[519]);
                /*  90 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[521]);
                /*  91 PlainRuleOp      */ _setterDefinition.Set(__Matchers[522]);
                /*  92 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[523]);
                /*  93 PlainRuleOp      */ _methodType.Set(__Matchers[524]);
                /*  94 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[526]);
                /*  95 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[527]);
                /*  96 PlainRuleOp      */ _attributeType.Set(_variadicType);
                /*  97 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[529]);
                /*  98 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[530]);
                /*  99 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[532]);
                /* 100 PlainRuleOp      */ _classDeclaration.Set(__Matchers[535]);
                /* 101 PlainRuleOp      */ _classDefinition.Set(__Matchers[536]);
                /* 102 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[538]);
                /* 103 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[540]);
                /* 104 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[541]);
                /* 105 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[543]);
                /* 106 PlainRuleOp      */ _statement.Set(__Matchers[544]);
                /* 107 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[545]);
                /* 108 PlainRuleOp      */ _openStatement.Set(__Matchers[546]);
                /* 109 PlainRuleOp      */ _specificationStatement.Set(__Matchers[547]);
                /* 110 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 111 PlainRuleOp      */ _directiveStatement.Set(__Matchers[548]);
                /* 112 PlainRuleOp      */ _returnDirective.Set(__Matchers[551]);
                /* 113 PlainRuleOp      */ _throwDirective.Set(__Matchers[553]);
                /* 114 PlainRuleOp      */ _breakDirective.Set(__Matchers[554]);
                /* 115 PlainRuleOp      */ _continueDirective.Set(__Matchers[555]);
                /* 116 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[556]);
                /* 117 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[557]);
                /* 118 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[558]);
                /* 119 PlainRuleOp      */ _anySpecifier.Set(__Matchers[559]);
                /* 120 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[560]);
                /* 121 PlainRuleOp      */ _baseReference.Set(__Matchers[561]);
                /* 122 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[562]);
                /* 123 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[563]);
                /* 124 PlainRuleOp      */ _memberReference.Set(__Matchers[565]);
                /* 125 PlainRuleOp      */ _typeReference.Set(__Matchers[566]);
                /* 126 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[567]);
                /* 127 PlainRuleOp      */ _selfReference.Set(__Matchers[570]);
                /* 128 PlainRuleOp      */ _enumeration.Set(__Matchers[572]);
                /* 129 PlainRuleOp      */ _tuple.Set(__Matchers[573]);
                /* 130 PlainRuleOp      */ _arguments.Set(__Matchers[574]);
                /* 131 PlainRuleOp      */ _structuralArguments.Set(__Matchers[576]);
                /* 132 PlainRuleOp      */ _namedOrAnonymous.Set(__Matchers[577]);
                /* 133 PlainRuleOp      */ _namedArgument.Set(__Matchers[578]);
                /* 134 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[579]);
                /* 135 PlainRuleOp      */ _sequencedArguments.Set(__Matchers[582]);
                /* 136 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[583]);
                /* 137 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[584]);
                /* 138 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[585]);
                /* 139 PlainRuleOp      */ _objectArgument.Set(__Matchers[586]);
                /* 140 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[587]);
                /* 141 PlainRuleOp      */ _methodDefinition.Set(__Matchers[588]);
                /* 142 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[589]);
                /* 143 PlainRuleOp      */ _neededFunctionSpecifier.Set(__Matchers[590]);
                /* 144 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[591]);
                /* 145 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[592]);
                /* 146 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 147 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[593]);
                /* 148 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[594]);
                /* 149 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[595]);
                /* 150 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[596]);
                /* 151 PlainRuleOp      */ _positionalArguments.Set(__Matchers[597]);
                /* 152 PlainRuleOp      */ _positionalArgument.Set(__Matchers[598]);
                /* 153 PlainRuleOp      */ _spreadArgument.Set(__Matchers[600]);
                /* 154 PlainRuleOp      */ _letExpression.Set(__Matchers[602]);
                /* 155 PlainRuleOp      */ _letVariableList.Set(__Matchers[605]);
                /* 156 PlainRuleOp      */ _letVariable.Set(__Matchers[606]);
                /* 157 PlainRuleOp      */ _switchExpression.Set(__Matchers[607]);
                /* 158 PlainRuleOp      */ _caseExpressions.Set(__Matchers[610]);
                /* 159 PlainRuleOp      */ _caseExpression.Set(__Matchers[614]);
                /* 160 PlainRuleOp      */ _ifExpression.Set(__Matchers[616]);
                /* 161 PlainRuleOp      */ _elseExpression.Set(__Matchers[617]);
                /* 162 PlainRuleOp      */ _thenExpression.Set(__Matchers[619]);
                /* 163 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[620]);
                /* 164 PlainRuleOp      */ _functionExpression.Set(__Matchers[623]);
                /* 165 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[625]);
                /* 166 PlainRuleOp      */ _functionParameters.Set(__Matchers[626]);
                /* 167 PlainRuleOp      */ _functionDefinition.Set(__Matchers[627]);
                /* 168 PlainRuleOp      */ _comprehension.Set(__Matchers[628]);
                /* 169 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[629]);
                /* 170 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 171 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[632]);
                /* 172 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[633]);
                /* 173 PlainRuleOp      */ _expression.Set(__Matchers[634]);
                /* 174 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 175 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[635]);
                /* 176 PlainRuleOp      */ _assignment.Set(__Matchers[636]);
                /* 177 PlainRuleOp      */ _assignmentOperator.Set(__Matchers[648]);
                /* 178 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[649]);
                /* 179 PlainRuleOp      */ _thenElse.Set(__Matchers[650]);
                /* 180 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[651]);
                /* 181 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[652]);
                /* 182 PlainRuleOp      */ _disjunction.Set(__Matchers[653]);
                /* 183 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[654]);
                /* 184 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[655]);
                /* 185 PlainRuleOp      */ _conjunction.Set(__Matchers[656]);
                /* 186 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[657]);
                /* 187 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[658]);
                /* 188 PlainRuleOp      */ _logicalNegation.Set(__Matchers[659]);
                /* 189 PlainRuleOp      */ _notOperator.Set(__Matchers[660]);
                /* 190 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[661]);
                /* 191 PlainRuleOp      */ _equalityExpression.Set(__Matchers[662]);
                /* 192 PlainRuleOp      */ _equality.Set(__Matchers[663]);
                /* 193 PlainRuleOp      */ _equalityOperator.Set(__Matchers[667]);
                /* 194 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[668]);
                /* 195 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[669]);
                /* 196 PlainRuleOp      */ _largerExpr.Set(__Matchers[670]);
                /* 197 PlainRuleOp      */ _smallerExpr.Set(__Matchers[671]);
                /* 198 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[672]);
                /* 199 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[673]);
                /* 200 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[674]);
                /* 201 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[676]);
                /* 202 PlainRuleOp      */ _smallerOperator.Set(__Matchers[678]);
                /* 203 PlainRuleOp      */ _largerOperator.Set(__Matchers[680]);
                /* 204 PlainRuleOp      */ _typeOperator.Set(__Matchers[682]);
                /* 205 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[683]);
                /* 206 PlainRuleOp      */ _existsExpression.Set(__Matchers[685]);
                /* 207 PlainRuleOp      */ _nonemptyExpression.Set(__Matchers[687]);
                /* 208 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[688]);
                /* 209 PlainRuleOp      */ _entryOrRange.Set(__Matchers[689]);
                /* 210 PlainRuleOp      */ _rangeOrEntryOperator.Set(__Matchers[691]);
                /* 211 PlainRuleOp      */ _additiveExpression.Set(__Matchers[692]);
                /* 212 PlainRuleOp      */ _additiveExpr.Set(__Matchers[693]);
                /* 213 PlainRuleOp      */ _additiveOperator.Set(__Matchers[696]);
                /* 214 PlainRuleOp      */ _scaleExpression.Set(__Matchers[697]);
                /* 215 PlainRuleOp      */ _scaleExpr.Set(__Matchers[698]);
                /* 216 PlainRuleOp      */ _scaleOperator.Set(__Matchers[699]);
                /* 217 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[700]);
                /* 218 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[701]);
                /* 219 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[704]);
                /* 220 PlainRuleOp      */ _unionExpression.Set(__Matchers[705]);
                /* 221 PlainRuleOp      */ _unionExpr.Set(__Matchers[706]);
                /* 222 PlainRuleOp      */ _unionOperator.Set(__Matchers[708]);
                /* 223 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[709]);
                /* 224 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[710]);
                /* 225 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[711]);
                /* 226 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[712]);
                /* 227 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[713]);
                /* 228 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[714]);
                /* 229 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[715]);
                /* 230 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[716]);
                /* 231 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[717]);
                /* 232 PlainRuleOp      */ _opNegate.Set(__Matchers[719]);
                /* 233 PlainRuleOp      */ _opNeutral.Set(__Matchers[721]);
                /* 234 PlainRuleOp      */ _opComplement.Set(__Matchers[707]);
                /* 235 PlainRuleOp      */ _prefixExpression.Set(__Matchers[722]);
                /* 236 PlainRuleOp      */ _prefixExpr.Set(__Matchers[723]);
                /* 237 PlainRuleOp      */ _postfixExpression.Set(__Matchers[724]);
                /* 238 PlainRuleOp      */ _postfixExpr.Set(__Matchers[725]);
                /* 239 PlainRuleOp      */ _incrementOperator.Set(__Matchers[728]);
                /* 240 PlainRuleOp      */ _primary.Set(__Matchers[729]);
                /* 241 PlainRuleOp      */ _selectionExpression.Set(__Matchers[730]);
                /* 242 PlainRuleOp      */ _qualifiedReference.Set(__Matchers[731]);
                /* 243 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[734]);
                /* 244 PlainRuleOp      */ _indexedExpression.Set(__Matchers[735]);
                /* 245 PlainRuleOp      */ _index.Set(__Matchers[736]);
                /* 246 PlainRuleOp      */ _upperSpanned.Set(__Matchers[737]);
                /* 247 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[738]);
                /* 248 PlainRuleOp      */ _spanned.Set(__Matchers[739]);
                /* 249 PlainRuleOp      */ _measured.Set(__Matchers[740]);
                /* 250 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 251 PlainRuleOp      */ _callExpression.Set(__Matchers[741]);
                /* 252 PlainRuleOp      */ _baseExpression.Set(__Matchers[742]);
                /* 253 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[743]);
                /* 254 PlainRuleOp      */ _stringExpression.Set(__Matchers[744]);
                /* 255 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[746]);
                /* 256 PlainRuleOp      */ _interpolationPart.Set(__Matchers[747]);
                /* 257 PlainRuleOp      */ _stringLiteral.Set(__Matchers[748]);
                /* 258 PlainRuleOp      */ _objectExpression.Set(__Matchers[749]);
                /* 259 PlainRuleOp      */ _groupedExpression.Set(__Matchers[750]);
                /* 260 PlainRuleOp      */ _typeArguments.Set(__Matchers[752]);
                /* 261 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[755]);
                /* 262 PlainRuleOp      */ _variancedType.Set(__Matchers[756]);
                /* 263 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[759]);
                /* 264 PlainRuleOp      */ _defaultedType.Set(__Matchers[760]);
                /* 265 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[761]);
                /* 266 PlainRuleOp      */ _variadicType.Set(__Matchers[762]);
                /* 267 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[763]);
                /* 268 PlainRuleOp      */ _variadicOperator.Set(__Matchers[764]);
                /* 269 PlainRuleOp      */ _spreadType.Set(__Matchers[765]);
                /* 270 PlainRuleOp      */ _type.Set(__Matchers[766]);
                /* 271 PlainRuleOp      */ _entryType.Set(__Matchers[767]);
                /* 272 PlainRuleOp      */ _unionType.Set(__Matchers[768]);
                /* 273 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[769]);
                /* 274 PlainRuleOp      */ _intersectionType.Set(__Matchers[770]);
                /* 275 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[771]);
                /* 276 PlainRuleOp      */ _primaryType.Set(__Matchers[772]);
                /* 277 PlainRuleOp      */ _nullableType.Set(__Matchers[774]);
                /* 278 PlainRuleOp      */ _arrayType.Set(__Matchers[776]);
                /* 279 PlainRuleOp      */ _functionType.Set(__Matchers[778]);
                /* 280 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[779]);
                /* 281 PlainRuleOp      */ _tupleType.Set(__Matchers[780]);
                /* 282 PlainRuleOp      */ _iterableType.Set(__Matchers[782]);
                /* 283 PlainRuleOp      */ _groupedType.Set(__Matchers[783]);
                /* 284 PlainRuleOp      */ _qualifiedType.Set(__Matchers[784]);
                /* 285 PlainRuleOp      */ _annotations.Set(__Matchers[787]);
                /* 286 PlainRuleOp      */ _annotation.Set(__Matchers[788]);
                /* 287 PlainRuleOp      */ _conditions.Set(__Matchers[790]);
                /* 288 PlainRuleOp      */ _conditionList.Set(__Matchers[793]);
                /* 289 PlainRuleOp      */ _condition.Set(__Matchers[794]);
                /* 290 PlainRuleOp      */ _existsCondition.Set(__Matchers[796]);
                /* 291 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[797]);
                /* 292 PlainRuleOp      */ _letOrExpression.Set(__Matchers[798]);
                /* 293 PlainRuleOp      */ _isCondition.Set(__Matchers[799]);
                /* 294 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[480]);
                /* 295 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[800]);
                /* 296 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 297 PlainRuleOp      */ _controlStatement.Set(__Matchers[801]);
                /* 298 PlainRuleOp      */ _ifElseStatement.Set(__Matchers[803]);
                /* 299 PlainRuleOp      */ _ifBlock.Set(__Matchers[804]);
                /* 300 PlainRuleOp      */ _elseBlock.Set(__Matchers[805]);
                /* 301 PlainRuleOp      */ _elseBlockNext.Set(__Matchers[806]);
                /* 302 PlainRuleOp      */ _switchCaseElse.Set(__Matchers[808]);
                /* 303 PlainRuleOp      */ _switchHeader.Set(__Matchers[810]);
                /* 304 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 305 PlainRuleOp      */ _caseBlock.Set(__Matchers[811]);
                /* 306 PlainRuleOp      */ _caseItem.Set(__Matchers[812]);
                /* 307 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[814]);
                /* 308 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[815]);
                /* 309 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 310 PlainRuleOp      */ _valueCaseList.Set(__Matchers[818]);
                /* 311 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[819]);
                /* 312 PlainRuleOp      */ _valueCase.Set(__Matchers[820]);
                /* 313 PlainRuleOp      */ _forElseStatement.Set(__Matchers[822]);
                /* 314 PlainRuleOp      */ _forBlock.Set(__Matchers[823]);
                /* 315 PlainRuleOp      */ _failBlock.Set(__Matchers[824]);
                /* 316 PlainRuleOp      */ _forIterator.Set(__Matchers[826]);
                /* 317 PlainRuleOp      */ _forVariable.Set(__Matchers[827]);
                /* 318 PlainRuleOp      */ _containment.Set(__Matchers[828]);
                /* 319 PlainRuleOp      */ _containmentOperator.Set(__Matchers[829]);
                /* 320 PlainRuleOp      */ _whileLoop.Set(_whileBlock);
                /* 321 PlainRuleOp      */ _whileBlock.Set(__Matchers[831]);
                /* 322 PlainRuleOp      */ _tryCatchFinally.Set(__Matchers[834]);
                /* 323 PlainRuleOp      */ _tryBlock.Set(__Matchers[837]);
                /* 324 PlainRuleOp      */ _catchBlock.Set(__Matchers[839]);
                /* 325 PlainRuleOp      */ _catchVariable.Set(__Matchers[841]);
                /* 326 PlainRuleOp      */ _finallyBlock.Set(__Matchers[843]);
                /* 327 PlainRuleOp      */ _resources.Set(__Matchers[845]);
                /* 328 PlainRuleOp      */ _resourceList.Set(__Matchers[848]);
                /* 329 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 330 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[849]);
                /* 331 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[850]);
                /* 332 PlainRuleOp      */ _variable.Set(__Matchers[853]);
                /* 333 PlainRuleOp      */ _variableType.Set(__Matchers[854]);
                /* 334 PlainRuleOp      */ _modelReference.Set(__Matchers[855]);
                /* 335 PlainRuleOp      */ _metaLiteral.Set(__Matchers[857]);
                /* 336 PlainRuleOp      */ _metaExpression.Set(__Matchers[858]);
                /* 337 PlainRuleOp      */ _modelExpression.Set(__Matchers[859]);
                /* 338 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[860]);
                /* 339 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[861]);
                /* 340 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[862]);
                /* 341 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 342 PlainRuleOp      */ _declarationReference.Set(__Matchers[863]);
                /* 343 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[865]);
                /* 344 PlainRuleOp      */ _packageLiteral.Set(__Matchers[866]);
                /* 345 PlainRuleOp      */ _classLiteral.Set(__Matchers[867]);
                /* 346 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[868]);
                /* 347 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[869]);
                /* 348 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[870]);
                /* 349 PlainRuleOp      */ _newLiteral.Set(__Matchers[871]);
                /* 350 PlainRuleOp      */ _valueLiteral.Set(__Matchers[872]);
                /* 351 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[873]);
                /* 352 PlainRuleOp      */ _functionLiteral.Set(__Matchers[874]);
                /* 353 PlainRuleOp      */ _referencePath.Set(__Matchers[875]);
                /* 354 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[878]);
                /* 355 PlainRuleOp      */ _referencePathElement.Set(_identifier);
                /* 356 PlainRuleOp      */ _kwVoid.Set(__Matchers[624]);
                /* 357 PlainRuleOp      */ _kwFunction.Set(__Matchers[525]);
                /* 358 PlainRuleOp      */ _kwValue.Set(__Matchers[528]);
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
                /* 388 StarOp           */ __Matchers[388].Set(_moduleBodyElement);
                /* 390 SeqOp            */ __Matchers[390].Set(__Matchers[387], __Matchers[388], __Matchers[389]);
                /* 391 AltOp            */ __Matchers[391].Set(_inferredAttributeDeclaration, _importModule);
                /* 394 SeqOp            */ __Matchers[394].Set(_annotations, __Matchers[392], _packagePath, __Matchers[393]);
                /* 396 SeqOp            */ __Matchers[396].Set(_annotations, __Matchers[395], _module, __Matchers[378], __Matchers[393]);
                /* 397 SeqOp            */ __Matchers[397].Set(__Matchers[395], _packagePath, _importElements);
                /* 398 OptionalOp       */ __Matchers[398].Set(_importElementList);
                /* 399 SeqOp            */ __Matchers[399].Set(__Matchers[387], __Matchers[398], __Matchers[389]);
                /* 401 SeqOp            */ __Matchers[401].Set(__Matchers[400], _importElement);
                /* 402 StarOp           */ __Matchers[402].Set(__Matchers[401]);
                /* 403 SeqOp            */ __Matchers[403].Set(_importElement, __Matchers[402]);
                /* 404 AltOp            */ __Matchers[404].Set(_importNamed, _importWildcard);
                /* 405 OptionalOp       */ __Matchers[405].Set(_importNameSpecifier);
                /* 406 OptionalOp       */ __Matchers[406].Set(_importElements);
                /* 407 SeqOp            */ __Matchers[407].Set(_importName, __Matchers[405], __Matchers[406]);
                /* 409 SeqOp            */ __Matchers[409].Set(__Matchers[408], _identifier);
                /* 412 SeqOp            */ __Matchers[412].Set(__Matchers[411], _packageName);
                /* 413 StarOp           */ __Matchers[413].Set(__Matchers[412]);
                /* 414 SeqOp            */ __Matchers[414].Set(_packageName, __Matchers[413]);
                /* 415 AltOp            */ __Matchers[415].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 416 AltOp            */ __Matchers[416].Set(_tuplePattern, _variablePattern);
                /* 417 AltOp            */ __Matchers[417].Set(_entryPattern, _tuplePattern);
                /* 419 SeqOp            */ __Matchers[419].Set(_variableOrTuplePattern, __Matchers[418], _variableOrTuplePattern);
                /* 421 OptionalOp       */ __Matchers[421].Set(_variadicPatternList);
                /* 423 SeqOp            */ __Matchers[423].Set(__Matchers[420], __Matchers[421], __Matchers[422]);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[400], _variadicPattern);
                /* 425 StarOp           */ __Matchers[425].Set(__Matchers[424]);
                /* 426 SeqOp            */ __Matchers[426].Set(_variadicPattern, __Matchers[425]);
                /* 427 AltOp            */ __Matchers[427].Set(_variadicVariable, _pattern);
                /* 428 OptionalOp       */ __Matchers[428].Set(_unionType);
                /* 429 OptionalOp       */ __Matchers[429].Set(_memberName);
                /* 430 SeqOp            */ __Matchers[430].Set(__Matchers[428], _variadicOperator, __Matchers[429]);
                /* 434 SeqOp            */ __Matchers[434].Set(__Matchers[431], __Matchers[432], _letVariableList, __Matchers[433]);
                /* 436 SeqOp            */ __Matchers[436].Set(__Matchers[435], _classInstatiation);
                /* 437 OptionalOp       */ __Matchers[437].Set(_assertionMessage);
                /* 439 SeqOp            */ __Matchers[439].Set(__Matchers[437], __Matchers[438], _conditions);
                /* 440 StarOp           */ __Matchers[440].Set(_declarationOrStatement);
                /* 441 SeqOp            */ __Matchers[441].Set(__Matchers[387], _importDeclarations, __Matchers[440], __Matchers[389]);
                /* 443 SeqOp            */ __Matchers[443].Set(__Matchers[442], _classInstatiation);
                /* 444 OptionalOp       */ __Matchers[444].Set(_arguments);
                /* 445 SeqOp            */ __Matchers[445].Set(_qualifiedClass, __Matchers[444]);
                /* 446 AltOp            */ __Matchers[446].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 447 SeqOp            */ __Matchers[447].Set(_superQualifier, _baseReference);
                /* 449 SeqOp            */ __Matchers[449].Set(__Matchers[448], __Matchers[411]);
                /* 450 SeqOp            */ __Matchers[450].Set(_packageQualifier, _unQualifiedClass);
                /* 451 SeqOp            */ __Matchers[451].Set(__Matchers[392], __Matchers[411]);
                /* 452 AltOp            */ __Matchers[452].Set(_memberPath, _typePath, _memberReference);
                /* 453 SeqOp            */ __Matchers[453].Set(_typePath, __Matchers[411], _memberReference);
                /* 454 SeqOp            */ __Matchers[454].Set(__Matchers[411], _typeReference);
                /* 455 StarOp           */ __Matchers[455].Set(__Matchers[454]);
                /* 456 SeqOp            */ __Matchers[456].Set(_typeReference, __Matchers[455]);
                /* 458 SeqOp            */ __Matchers[458].Set(__Matchers[457], _unionTypeList);
                /* 459 SeqOp            */ __Matchers[459].Set(__Matchers[400], _unionType);
                /* 460 StarOp           */ __Matchers[460].Set(__Matchers[459]);
                /* 461 SeqOp            */ __Matchers[461].Set(_unionType, __Matchers[460]);
                /* 463 SeqOp            */ __Matchers[463].Set(__Matchers[462], _caseTypeList);
                /* 465 SeqOp            */ __Matchers[465].Set(__Matchers[464], _caseType);
                /* 466 StarOp           */ __Matchers[466].Set(__Matchers[465]);
                /* 467 SeqOp            */ __Matchers[467].Set(_caseType, __Matchers[466]);
                /* 468 AltOp            */ __Matchers[468].Set(_primaryType, _qualifiedCaseType);
                /* 469 OptionalOp       */ __Matchers[469].Set(_packageQualifier);
                /* 470 SeqOp            */ __Matchers[470].Set(__Matchers[469], _memberName);
                /* 471 OptionalOp       */ __Matchers[471].Set(_parameterList);
                /* 472 SeqOp            */ __Matchers[472].Set(__Matchers[432], __Matchers[471], __Matchers[433]);
                /* 473 SeqOp            */ __Matchers[473].Set(__Matchers[400], _parameterDeclarationOrRefPattern);
                /* 474 StarOp           */ __Matchers[474].Set(__Matchers[473]);
                /* 475 SeqOp            */ __Matchers[475].Set(_parameterDeclarationOrRefPattern, __Matchers[474]);
                /* 476 AltOp            */ __Matchers[476].Set(_tupleOrEntryPattern, _parameterDeclarationOrRef);
                /* 477 AltOp            */ __Matchers[477].Set(_parameter, _parameterReference);
                /* 478 SeqOp            */ __Matchers[478].Set(_annotations, _parameterDeclaration);
                /* 479 OptionalOp       */ __Matchers[479].Set(_valueSpecifier);
                /* 480 SeqOp            */ __Matchers[480].Set(_memberName, __Matchers[479]);
                /* 481 AltOp            */ __Matchers[481].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 482 OptionalOp       */ __Matchers[482].Set(_typeParameters);
                /* 483 PlusOp           */ __Matchers[483].Set(_parameters);
                /* 484 OptionalOp       */ __Matchers[484].Set(_functionSpecifier);
                /* 485 SeqOp            */ __Matchers[485].Set(_functionParameterType, _memberName, __Matchers[482], __Matchers[483], __Matchers[484]);
                /* 486 AltOp            */ __Matchers[486].Set(_variadicType, _kwVoid, _kwFunction);
                /* 487 SeqOp            */ __Matchers[487].Set(_valueParameterType, _memberName, __Matchers[479]);
                /* 488 AltOp            */ __Matchers[488].Set(_variadicType, _kwValue);
                /* 491 SeqOp            */ __Matchers[491].Set(__Matchers[489], _typeParameterList, __Matchers[490]);
                /* 492 SeqOp            */ __Matchers[492].Set(__Matchers[400], _typeParameter);
                /* 493 StarOp           */ __Matchers[493].Set(__Matchers[492]);
                /* 494 SeqOp            */ __Matchers[494].Set(_typeParameter, __Matchers[493]);
                /* 495 OptionalOp       */ __Matchers[495].Set(_variance);
                /* 496 OptionalOp       */ __Matchers[496].Set(_typeDefault);
                /* 497 SeqOp            */ __Matchers[497].Set(__Matchers[495], _typeName, __Matchers[496]);
                /* 500 AltOp            */ __Matchers[500].Set(__Matchers[498], __Matchers[499]);
                /* 501 SeqOp            */ __Matchers[501].Set(__Matchers[408], _type);
                /* 503 OptionalOp       */ __Matchers[503].Set(_typeName);
                /* 504 OptionalOp       */ __Matchers[504].Set(_caseTypes);
                /* 505 OptionalOp       */ __Matchers[505].Set(_satisfiedTypes);
                /* 506 SeqOp            */ __Matchers[506].Set(__Matchers[502], __Matchers[503], __Matchers[482], __Matchers[504], __Matchers[505]);
                /* 507 PlusOp           */ __Matchers[507].Set(_typeConstraint);
                /* 508 AltOp            */ __Matchers[508].Set(_declaration, _statement);
                /* 509 AltOp            */ __Matchers[509].Set(_constructorDeclaration, _aliasDeclaration, _classDeclaration, _interfaceDeclaration, _objectDeclaration, _enumeratedObject, _setterDeclaration, _typedMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration);
                /* 511 OptionalOp       */ __Matchers[511].Set(_delegatedConstructor);
                /* 512 SeqOp            */ __Matchers[512].Set(_annotations, __Matchers[510], __Matchers[429], _parameters, __Matchers[511], _block);
                /* 514 OptionalOp       */ __Matchers[514].Set(_typeConstraints);
                /* 515 SeqOp            */ __Matchers[515].Set(_annotations, __Matchers[513], _typeName, __Matchers[482], __Matchers[514], _optionalTypeSpecifier);
                /* 516 SeqOp            */ __Matchers[516].Set(_annotations, __Matchers[510], _memberName, __Matchers[511], _block);
                /* 518 OptionalOp       */ __Matchers[518].Set(_extendedType);
                /* 519 SeqOp            */ __Matchers[519].Set(_annotations, __Matchers[517], _memberName, __Matchers[518], __Matchers[505], _classBlock);
                /* 521 SeqOp            */ __Matchers[521].Set(_annotations, __Matchers[520], _memberName, _setterDefinition);
                /* 522 AltOp            */ __Matchers[522].Set(_block, _neededFunctionSpecifier);
                /* 523 SeqOp            */ __Matchers[523].Set(_annotations, _methodType, _parametrizedMember, __Matchers[514], _methodDefinition);
                /* 524 AltOp            */ __Matchers[524].Set(_variadicType, _kwVoid);
                /* 526 SeqOp            */ __Matchers[526].Set(_annotations, __Matchers[525], _parametrizedMember, __Matchers[514], _methodDefinition);
                /* 527 SeqOp            */ __Matchers[527].Set(_annotations, _attributeType, _memberName, _attributeDefinition);
                /* 529 SeqOp            */ __Matchers[529].Set(_annotations, __Matchers[528], _memberName, _attributeDefinition);
                /* 530 AltOp            */ __Matchers[530].Set(_block, _optionalAnySpecifier);
                /* 531 OptionalOp       */ __Matchers[531].Set(_anySpecifier);
                /* 532 SeqOp            */ __Matchers[532].Set(__Matchers[531], __Matchers[393]);
                /* 534 OptionalOp       */ __Matchers[534].Set(_parameters);
                /* 535 SeqOp            */ __Matchers[535].Set(_annotations, __Matchers[533], _typeName, __Matchers[482], __Matchers[534], __Matchers[504], __Matchers[518], __Matchers[505], __Matchers[514], _classDefinition);
                /* 536 AltOp            */ __Matchers[536].Set(_classBlock, _optionalClassSpecifier);
                /* 537 OptionalOp       */ __Matchers[537].Set(_classSpecifier);
                /* 538 SeqOp            */ __Matchers[538].Set(__Matchers[537], __Matchers[393]);
                /* 540 SeqOp            */ __Matchers[540].Set(_annotations, __Matchers[539], _typeName, __Matchers[482], __Matchers[504], __Matchers[505], __Matchers[514], _interfaceDefinition);
                /* 541 AltOp            */ __Matchers[541].Set(_interfaceBlock, _optionalTypeSpecifier);
                /* 542 OptionalOp       */ __Matchers[542].Set(_typeSpecifier);
                /* 543 SeqOp            */ __Matchers[543].Set(__Matchers[542], __Matchers[393]);
                /* 544 AltOp            */ __Matchers[544].Set(_unclosedStatement, _controlStatement);
                /* 545 SeqOp            */ __Matchers[545].Set(_openStatement, __Matchers[393]);
                /* 546 AltOp            */ __Matchers[546].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 547 SeqOp            */ __Matchers[547].Set(_primary, _functionSpecifier);
                /* 548 AltOp            */ __Matchers[548].Set(_returnDirective, _throwDirective, _breakDirective, _continueDirective);
                /* 550 OptionalOp       */ __Matchers[550].Set(_expression);
                /* 551 SeqOp            */ __Matchers[551].Set(__Matchers[549], __Matchers[550]);
                /* 553 SeqOp            */ __Matchers[553].Set(__Matchers[552], __Matchers[550]);
                /* 556 SeqOp            */ __Matchers[556].Set(__Matchers[442], _type);
                /* 557 SeqOp            */ __Matchers[557].Set(__Matchers[408], _expression);
                /* 558 SeqOp            */ __Matchers[558].Set(__Matchers[442], _expression);
                /* 559 AltOp            */ __Matchers[559].Set(_valueSpecifier, _functionSpecifier);
                /* 560 AltOp            */ __Matchers[560].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 561 AltOp            */ __Matchers[561].Set(_memberReference, _typeReference);
                /* 562 SeqOp            */ __Matchers[562].Set(_memberName, __Matchers[482], __Matchers[483]);
                /* 563 SeqOp            */ __Matchers[563].Set(_selfReferenceSelector, _parametrizedMember);
                /* 564 OptionalOp       */ __Matchers[564].Set(_typeArguments);
                /* 565 SeqOp            */ __Matchers[565].Set(_memberName, __Matchers[564]);
                /* 566 SeqOp            */ __Matchers[566].Set(_typeName, __Matchers[564]);
                /* 567 SeqOp            */ __Matchers[567].Set(_selfReference, _memberSelectionOperator);
                /* 570 AltOp            */ __Matchers[570].Set(__Matchers[568], __Matchers[448], __Matchers[569], __Matchers[392]);
                /* 571 OptionalOp       */ __Matchers[571].Set(_sequencedArguments);
                /* 572 SeqOp            */ __Matchers[572].Set(__Matchers[387], __Matchers[440], __Matchers[571], __Matchers[389]);
                /* 573 SeqOp            */ __Matchers[573].Set(__Matchers[420], __Matchers[571], __Matchers[422]);
                /* 574 AltOp            */ __Matchers[574].Set(_structuralArguments, _positionalArguments);
                /* 575 StarOp           */ __Matchers[575].Set(_namedOrAnonymous);
                /* 576 SeqOp            */ __Matchers[576].Set(__Matchers[387], __Matchers[575], __Matchers[571], __Matchers[389]);
                /* 577 AltOp            */ __Matchers[577].Set(_namedArgument, _anonymousArgument);
                /* 578 AltOp            */ __Matchers[578].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 579 SeqOp            */ __Matchers[579].Set(_memberName, _valueSpecifier, __Matchers[393]);
                /* 580 SeqOp            */ __Matchers[580].Set(__Matchers[400], _sequencedArgument);
                /* 581 StarOp           */ __Matchers[581].Set(__Matchers[580]);
                /* 582 SeqOp            */ __Matchers[582].Set(_sequencedArgument, __Matchers[581]);
                /* 583 AltOp            */ __Matchers[583].Set(_comprehension, _positionalArgument, _spreadArgument);
                /* 584 SeqOp            */ __Matchers[584].Set(_expression, __Matchers[393]);
                /* 585 AltOp            */ __Matchers[585].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 586 SeqOp            */ __Matchers[586].Set(__Matchers[517], __Matchers[429], __Matchers[518], __Matchers[505], _classBlock);
                /* 587 SeqOp            */ __Matchers[587].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 588 AltOp            */ __Matchers[588].Set(_block, _optionalFunctionSpecifier);
                /* 589 SeqOp            */ __Matchers[589].Set(__Matchers[484], __Matchers[393]);
                /* 590 SeqOp            */ __Matchers[590].Set(_functionSpecifier, __Matchers[393]);
                /* 591 AltOp            */ __Matchers[591].Set(_type, _kwVoid);
                /* 592 SeqOp            */ __Matchers[592].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 593 SeqOp            */ __Matchers[593].Set(__Matchers[525], __Matchers[429], __Matchers[482], _parameters, _methodDefinition);
                /* 594 SeqOp            */ __Matchers[594].Set(__Matchers[528], _memberName, _methodDefinition);
                /* 595 SeqOp            */ __Matchers[595].Set(_memberName, __Matchers[483], _neededFunctionSpecifier);
                /* 596 SeqOp            */ __Matchers[596].Set(_memberName, _neededFunctionSpecifier);
                /* 597 SeqOp            */ __Matchers[597].Set(__Matchers[432], __Matchers[571], __Matchers[433]);
                /* 598 AltOp            */ __Matchers[598].Set(_expression, _declarationReference);
                /* 600 SeqOp            */ __Matchers[600].Set(__Matchers[599], _unionExpression);
                /* 601 OptionalOp       */ __Matchers[601].Set(_letVariableList);
                /* 602 SeqOp            */ __Matchers[602].Set(__Matchers[431], __Matchers[432], __Matchers[601], __Matchers[433], _conditionalExpression);
                /* 603 SeqOp            */ __Matchers[603].Set(__Matchers[400], _letVariable);
                /* 604 StarOp           */ __Matchers[604].Set(__Matchers[603]);
                /* 605 SeqOp            */ __Matchers[605].Set(_letVariable, __Matchers[604]);
                /* 606 SeqOp            */ __Matchers[606].Set(_pattern, _valueSpecifier);
                /* 607 SeqOp            */ __Matchers[607].Set(_switchHeader, _caseExpressions);
                /* 608 PlusOp           */ __Matchers[608].Set(_caseExpression);
                /* 609 OptionalOp       */ __Matchers[609].Set(_elseExpression);
                /* 610 SeqOp            */ __Matchers[610].Set(__Matchers[608], __Matchers[609]);
                /* 612 OptionalOp       */ __Matchers[612].Set(__Matchers[611]);
                /* 614 SeqOp            */ __Matchers[614].Set(__Matchers[612], __Matchers[613], __Matchers[432], _caseItem, __Matchers[433], _conditionalExpression);
                /* 616 SeqOp            */ __Matchers[616].Set(__Matchers[615], _conditions, _thenExpression, _elseExpression);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[611], _conditionalExpression);
                /* 619 SeqOp            */ __Matchers[619].Set(__Matchers[618], _conditionalExpression);
                /* 620 AltOp            */ __Matchers[620].Set(_ifExpression, _letExpression, _disjunctionExpression);
                /* 621 OptionalOp       */ __Matchers[621].Set(_functionExpressionType);
                /* 622 OptionalOp       */ __Matchers[622].Set(_functionParameters);
                /* 623 SeqOp            */ __Matchers[623].Set(__Matchers[621], __Matchers[482], __Matchers[622], _functionDefinition);
                /* 625 AltOp            */ __Matchers[625].Set(__Matchers[624], __Matchers[525]);
                /* 626 SeqOp            */ __Matchers[626].Set(__Matchers[483], __Matchers[514]);
                /* 627 AltOp            */ __Matchers[627].Set(_block, _functionSpecifier);
                /* 628 AltOp            */ __Matchers[628].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 629 AltOp            */ __Matchers[629].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 631 OptionalOp       */ __Matchers[631].Set(_forIterator);
                /* 632 SeqOp            */ __Matchers[632].Set(__Matchers[630], __Matchers[432], __Matchers[631], __Matchers[433], _comprehensionClause);
                /* 633 SeqOp            */ __Matchers[633].Set(__Matchers[615], _conditions, _comprehensionClause);
                /* 634 AltOp            */ __Matchers[634].Set(_letExpression, _ifExpression, _switchExpression, _functionExpression, _operatorExpression);
                /* 635 AltOp            */ __Matchers[635].Set(_assignment, _thenElseExpression);
                /* 636 SeqOp            */ __Matchers[636].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 648 AltOp            */ __Matchers[648].Set(__Matchers[408], __Matchers[637], __Matchers[638], __Matchers[639], __Matchers[640], __Matchers[641], __Matchers[642], __Matchers[643], __Matchers[644], __Matchers[645], __Matchers[646], __Matchers[647]);
                /* 649 AltOp            */ __Matchers[649].Set(_thenElse, _disjunctionExpression);
                /* 650 SeqOp            */ __Matchers[650].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 651 AltOp            */ __Matchers[651].Set(__Matchers[611], __Matchers[618]);
                /* 652 AltOp            */ __Matchers[652].Set(_disjunction, _conjunctionExpression);
                /* 653 SeqOp            */ __Matchers[653].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 655 AltOp            */ __Matchers[655].Set(_conjunction, _logicalNegationExpression);
                /* 656 SeqOp            */ __Matchers[656].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 658 AltOp            */ __Matchers[658].Set(_logicalNegation, _expressionOrMeta);
                /* 659 SeqOp            */ __Matchers[659].Set(_notOperator, _logicalNegationExpression);
                /* 661 AltOp            */ __Matchers[661].Set(_equalityExpression, _modelReference);
                /* 662 AltOp            */ __Matchers[662].Set(_equality, _comparisonExpression);
                /* 663 SeqOp            */ __Matchers[663].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 667 AltOp            */ __Matchers[667].Set(__Matchers[664], __Matchers[665], __Matchers[666]);
                /* 668 AltOp            */ __Matchers[668].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 669 SeqOp            */ __Matchers[669].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 670 SeqOp            */ __Matchers[670].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 671 SeqOp            */ __Matchers[671].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 672 SeqOp            */ __Matchers[672].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 673 SeqOp            */ __Matchers[673].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 674 SeqOp            */ __Matchers[674].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 676 AltOp            */ __Matchers[676].Set(__Matchers[675], __Matchers[498]);
                /* 678 AltOp            */ __Matchers[678].Set(__Matchers[677], __Matchers[489]);
                /* 680 AltOp            */ __Matchers[680].Set(__Matchers[679], __Matchers[490]);
                /* 682 AltOp            */ __Matchers[682].Set(__Matchers[681], __Matchers[435], __Matchers[457], __Matchers[462]);
                /* 683 AltOp            */ __Matchers[683].Set(_existsExpression, _nonemptyExpression, _entryRangeExpression);
                /* 685 SeqOp            */ __Matchers[685].Set(_entryRangeExpression, __Matchers[684]);
                /* 687 SeqOp            */ __Matchers[687].Set(_entryRangeExpression, __Matchers[686]);
                /* 688 AltOp            */ __Matchers[688].Set(_entryOrRange, _additiveExpression);
                /* 689 SeqOp            */ __Matchers[689].Set(_additiveExpression, _rangeOrEntryOperator, _additiveExpression);
                /* 691 AltOp            */ __Matchers[691].Set(__Matchers[690], __Matchers[380], __Matchers[418]);
                /* 692 AltOp            */ __Matchers[692].Set(_additiveExpr, _scaleExpression);
                /* 693 SeqOp            */ __Matchers[693].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 696 AltOp            */ __Matchers[696].Set(__Matchers[694], __Matchers[695]);
                /* 697 AltOp            */ __Matchers[697].Set(_scaleExpr, _multiplicativeExpression);
                /* 698 SeqOp            */ __Matchers[698].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 700 AltOp            */ __Matchers[700].Set(_multiplicativeExpr, _unionExpression);
                /* 701 SeqOp            */ __Matchers[701].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 704 AltOp            */ __Matchers[704].Set(__Matchers[599], __Matchers[702], __Matchers[703]);
                /* 705 AltOp            */ __Matchers[705].Set(_unionExpr, _exclusiveExpression);
                /* 706 SeqOp            */ __Matchers[706].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 708 AltOp            */ __Matchers[708].Set(__Matchers[464], __Matchers[707]);
                /* 709 AltOp            */ __Matchers[709].Set(_exclusiveExpr, _intersectionExpression);
                /* 710 SeqOp            */ __Matchers[710].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 712 AltOp            */ __Matchers[712].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 713 SeqOp            */ __Matchers[713].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 715 AltOp            */ __Matchers[715].Set(_negationOrComplementExpr, _prefixExpression);
                /* 716 SeqOp            */ __Matchers[716].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 717 AltOp            */ __Matchers[717].Set(_opNegate, _opNeutral, _opComplement);
                /* 718 NotOp            */ __Matchers[718].Set(__Matchers_718_DFA);
                /* 719 SeqOp            */ __Matchers[719].Set(__Matchers[695], __Matchers[718]);
                /* 720 NotOp            */ __Matchers[720].Set(__Matchers_720_DFA);
                /* 721 SeqOp            */ __Matchers[721].Set(__Matchers[694], __Matchers[720]);
                /* 722 AltOp            */ __Matchers[722].Set(_prefixExpr, _postfixExpression);
                /* 723 SeqOp            */ __Matchers[723].Set(_incrementOperator, _prefixExpression);
                /* 724 AltOp            */ __Matchers[724].Set(_postfixExpr, _primary);
                /* 725 SeqOp            */ __Matchers[725].Set(_postfixExpression, _incrementOperator);
                /* 728 AltOp            */ __Matchers[728].Set(__Matchers[726], __Matchers[727]);
                /* 729 AltOp            */ __Matchers[729].Set(_selectionExpression, _indexedExpression, _callExpression, _baseExpression);
                /* 730 SeqOp            */ __Matchers[730].Set(_primary, _qualifiedReference);
                /* 731 SeqOp            */ __Matchers[731].Set(_memberSelectionOperator, _baseReference);
                /* 734 AltOp            */ __Matchers[734].Set(__Matchers[411], __Matchers[732], __Matchers[733]);
                /* 735 SeqOp            */ __Matchers[735].Set(_primary, __Matchers[420], _index, __Matchers[422]);
                /* 736 AltOp            */ __Matchers[736].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 737 SeqOp            */ __Matchers[737].Set(_indexExpression, __Matchers[410]);
                /* 738 SeqOp            */ __Matchers[738].Set(__Matchers[410], _indexExpression);
                /* 739 SeqOp            */ __Matchers[739].Set(_indexExpression, __Matchers[690], _indexExpression);
                /* 740 SeqOp            */ __Matchers[740].Set(_indexExpression, __Matchers[380], _indexExpression);
                /* 741 SeqOp            */ __Matchers[741].Set(_primary, _arguments);
                /* 742 AltOp            */ __Matchers[742].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumeration, _tuple, _objectExpression, _groupedExpression, _baseReferenceOrParameterized);
                /* 743 AltOp            */ __Matchers[743].Set(_literalNatural, _literalFloat, _literalChar);
                /* 744 AltOp            */ __Matchers[744].Set(_stringLiteral, _stringInterpolation);
                /* 745 StarOp           */ __Matchers[745].Set(_interpolationPart);
                /* 746 SeqOp            */ __Matchers[746].Set(_stringStart, _expression, __Matchers[745], _stringEnd);
                /* 747 SeqOp            */ __Matchers[747].Set(_stringMid, _expression);
                /* 748 AltOp            */ __Matchers[748].Set(_literalString, _verbatimString);
                /* 749 SeqOp            */ __Matchers[749].Set(__Matchers[517], __Matchers[518], __Matchers[505], _classBlock);
                /* 750 SeqOp            */ __Matchers[750].Set(__Matchers[432], _expression, __Matchers[433]);
                /* 751 OptionalOp       */ __Matchers[751].Set(_typeArgumentList);
                /* 752 SeqOp            */ __Matchers[752].Set(__Matchers[489], __Matchers[751], __Matchers[490]);
                /* 753 SeqOp            */ __Matchers[753].Set(__Matchers[400], _variancedType);
                /* 754 StarOp           */ __Matchers[754].Set(__Matchers[753]);
                /* 755 SeqOp            */ __Matchers[755].Set(_variancedType, __Matchers[754]);
                /* 756 SeqOp            */ __Matchers[756].Set(__Matchers[495], _type);
                /* 757 SeqOp            */ __Matchers[757].Set(__Matchers[400], _defaultedType);
                /* 758 StarOp           */ __Matchers[758].Set(__Matchers[757]);
                /* 759 SeqOp            */ __Matchers[759].Set(_defaultedType, __Matchers[758]);
                /* 760 AltOp            */ __Matchers[760].Set(_defaultedTypeCore, _variadicType);
                /* 761 SeqOp            */ __Matchers[761].Set(_type, __Matchers[408]);
                /* 762 AltOp            */ __Matchers[762].Set(_variadicUnionType, _type);
                /* 763 SeqOp            */ __Matchers[763].Set(_unionType, _variadicOperator);
                /* 764 AltOp            */ __Matchers[764].Set(__Matchers[599], __Matchers[694]);
                /* 765 SeqOp            */ __Matchers[765].Set(__Matchers[599], _unionType);
                /* 766 AltOp            */ __Matchers[766].Set(_entryType, _unionType);
                /* 767 SeqOp            */ __Matchers[767].Set(_unionType, __Matchers[418], _unionType);
                /* 768 AltOp            */ __Matchers[768].Set(_unionTypeCore, _intersectionType);
                /* 769 SeqOp            */ __Matchers[769].Set(_unionType, __Matchers[464], _intersectionType);
                /* 770 AltOp            */ __Matchers[770].Set(_intersectionTypeCore, _primaryType);
                /* 771 SeqOp            */ __Matchers[771].Set(_intersectionType, __Matchers[714], _primaryType);
                /* 772 AltOp            */ __Matchers[772].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _qualifiedType);
                /* 774 SeqOp            */ __Matchers[774].Set(_primaryType, __Matchers[773]);
                /* 775 OptionalOp       */ __Matchers[775].Set(_literalNatural);
                /* 776 SeqOp            */ __Matchers[776].Set(_primaryType, __Matchers[420], __Matchers[775], __Matchers[422]);
                /* 777 OptionalOp       */ __Matchers[777].Set(_typeTypeArguments);
                /* 778 SeqOp            */ __Matchers[778].Set(_primaryType, __Matchers[432], __Matchers[777], __Matchers[433]);
                /* 779 AltOp            */ __Matchers[779].Set(_spreadType, _defaultedTypeList);
                /* 780 SeqOp            */ __Matchers[780].Set(__Matchers[420], __Matchers[777], __Matchers[422]);
                /* 781 OptionalOp       */ __Matchers[781].Set(_variadicType);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[387], __Matchers[781], __Matchers[389]);
                /* 783 SeqOp            */ __Matchers[783].Set(__Matchers[489], _type, __Matchers[490]);
                /* 784 SeqOp            */ __Matchers[784].Set(__Matchers[469], _typePath);
                /* 785 OptionalOp       */ __Matchers[785].Set(_stringLiteral);
                /* 786 StarOp           */ __Matchers[786].Set(_annotation);
                /* 787 SeqOp            */ __Matchers[787].Set(__Matchers[785], __Matchers[786]);
                /* 788 SeqOp            */ __Matchers[788].Set(_annotationName, __Matchers[444]);
                /* 789 OptionalOp       */ __Matchers[789].Set(_conditionList);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[432], __Matchers[789], __Matchers[433]);
                /* 791 SeqOp            */ __Matchers[791].Set(__Matchers[400], _condition);
                /* 792 StarOp           */ __Matchers[792].Set(__Matchers[791]);
                /* 793 SeqOp            */ __Matchers[793].Set(_condition, __Matchers[792]);
                /* 794 AltOp            */ __Matchers[794].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 795 OptionalOp       */ __Matchers[795].Set(__Matchers[660]);
                /* 796 SeqOp            */ __Matchers[796].Set(__Matchers[795], __Matchers[684], _letOrExpression);
                /* 797 SeqOp            */ __Matchers[797].Set(__Matchers[795], __Matchers[686], _letOrExpression);
                /* 798 AltOp            */ __Matchers[798].Set(_letVariable, _operatorExpression);
                /* 799 SeqOp            */ __Matchers[799].Set(__Matchers[795], __Matchers[681], _type, _isConditionVariable);
                /* 800 SeqOp            */ __Matchers[800].Set(__Matchers[457], _type, _typeName);
                /* 801 AltOp            */ __Matchers[801].Set(_ifElseStatement, _forElseStatement, _switchCaseElse, _whileLoop, _tryCatchFinally);
                /* 802 OptionalOp       */ __Matchers[802].Set(_elseBlock);
                /* 803 SeqOp            */ __Matchers[803].Set(_ifBlock, __Matchers[802]);
                /* 804 SeqOp            */ __Matchers[804].Set(__Matchers[615], _conditions, _block);
                /* 805 SeqOp            */ __Matchers[805].Set(__Matchers[611], _elseBlockNext);
                /* 806 AltOp            */ __Matchers[806].Set(_ifElseStatement, _block);
                /* 807 PlusOp           */ __Matchers[807].Set(_caseBlock);
                /* 808 SeqOp            */ __Matchers[808].Set(_switchHeader, __Matchers[807], __Matchers[802]);
                /* 810 SeqOp            */ __Matchers[810].Set(__Matchers[809], __Matchers[432], _switched, __Matchers[433]);
                /* 811 SeqOp            */ __Matchers[811].Set(__Matchers[612], __Matchers[613], __Matchers[432], _caseItem, __Matchers[433], _block);
                /* 812 AltOp            */ __Matchers[812].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 813 OptionalOp       */ __Matchers[813].Set(__Matchers[681]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[813], _type);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[457], _type);
                /* 816 SeqOp            */ __Matchers[816].Set(_valueCaseSeparator, _valueCase);
                /* 817 StarOp           */ __Matchers[817].Set(__Matchers[816]);
                /* 818 SeqOp            */ __Matchers[818].Set(_valueCase, __Matchers[817]);
                /* 819 AltOp            */ __Matchers[819].Set(__Matchers[400], __Matchers[464]);
                /* 820 AltOp            */ __Matchers[820].Set(_intersectionType, _intersectionExpression);
                /* 821 OptionalOp       */ __Matchers[821].Set(_failBlock);
                /* 822 SeqOp            */ __Matchers[822].Set(_forBlock, __Matchers[821]);
                /* 823 SeqOp            */ __Matchers[823].Set(__Matchers[630], __Matchers[432], __Matchers[631], __Matchers[433], _block);
                /* 824 SeqOp            */ __Matchers[824].Set(__Matchers[611], _block);
                /* 825 OptionalOp       */ __Matchers[825].Set(_containment);
                /* 826 SeqOp            */ __Matchers[826].Set(_forVariable, __Matchers[825]);
                /* 827 AltOp            */ __Matchers[827].Set(_tupleOrEntryPattern, _variable);
                /* 828 SeqOp            */ __Matchers[828].Set(_containmentOperator, _operatorExpression);
                /* 829 AltOp            */ __Matchers[829].Set(__Matchers[498], __Matchers[380]);
                /* 831 SeqOp            */ __Matchers[831].Set(__Matchers[830], _conditions, _block);
                /* 832 StarOp           */ __Matchers[832].Set(_catchBlock);
                /* 833 OptionalOp       */ __Matchers[833].Set(_finallyBlock);
                /* 834 SeqOp            */ __Matchers[834].Set(_tryBlock, __Matchers[832], __Matchers[833]);
                /* 836 OptionalOp       */ __Matchers[836].Set(_resources);
                /* 837 SeqOp            */ __Matchers[837].Set(__Matchers[835], __Matchers[836], _block);
                /* 839 SeqOp            */ __Matchers[839].Set(__Matchers[838], _catchVariable, _block);
                /* 840 OptionalOp       */ __Matchers[840].Set(_variable);
                /* 841 SeqOp            */ __Matchers[841].Set(__Matchers[432], __Matchers[840], __Matchers[433]);
                /* 843 SeqOp            */ __Matchers[843].Set(__Matchers[842], _block);
                /* 844 OptionalOp       */ __Matchers[844].Set(_resourceList);
                /* 845 SeqOp            */ __Matchers[845].Set(__Matchers[432], __Matchers[844], __Matchers[433]);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[400], _resource);
                /* 847 StarOp           */ __Matchers[847].Set(__Matchers[846]);
                /* 848 SeqOp            */ __Matchers[848].Set(_resource, __Matchers[847]);
                /* 849 AltOp            */ __Matchers[849].Set(_specifiedVariable, _operatorExpression);
                /* 850 SeqOp            */ __Matchers[850].Set(_variable, _valueSpecifier);
                /* 851 OptionalOp       */ __Matchers[851].Set(_variableType);
                /* 852 StarOp           */ __Matchers[852].Set(_parameters);
                /* 853 SeqOp            */ __Matchers[853].Set(__Matchers[851], _memberName, __Matchers[852]);
                /* 854 AltOp            */ __Matchers[854].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 855 SeqOp            */ __Matchers[855].Set(__Matchers[711], _modelExpression);
                /* 857 SeqOp            */ __Matchers[857].Set(__Matchers[856], _metaExpression, __Matchers[856]);
                /* 858 AltOp            */ __Matchers[858].Set(_declarationReference, _modelExpression);
                /* 859 AltOp            */ __Matchers[859].Set(_memberModelExpression, _typeModelExpression);
                /* 860 AltOp            */ __Matchers[860].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 861 SeqOp            */ __Matchers[861].Set(_packageQualifier, _memberReference);
                /* 862 SeqOp            */ __Matchers[862].Set(_primaryType, __Matchers[411], _memberReference);
                /* 863 AltOp            */ __Matchers[863].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 864 OptionalOp       */ __Matchers[864].Set(_packagePath);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[376], __Matchers[864]);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[392], __Matchers[864]);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[533], _referencePath);
                /* 868 SeqOp            */ __Matchers[868].Set(__Matchers[539], _referencePath);
                /* 869 SeqOp            */ __Matchers[869].Set(__Matchers[513], _referencePath);
                /* 870 SeqOp            */ __Matchers[870].Set(__Matchers[502], _referencePath);
                /* 871 SeqOp            */ __Matchers[871].Set(__Matchers[510], _referencePath);
                /* 872 SeqOp            */ __Matchers[872].Set(_valueLiteralIntro, _referencePath);
                /* 873 AltOp            */ __Matchers[873].Set(__Matchers[528], __Matchers[517]);
                /* 874 SeqOp            */ __Matchers[874].Set(__Matchers[525], _referencePath);
                /* 875 SeqOp            */ __Matchers[875].Set(__Matchers[469], _referencePathElementList);
                /* 876 SeqOp            */ __Matchers[876].Set(__Matchers[411], _referencePathElement);
                /* 877 StarOp           */ __Matchers[877].Set(__Matchers[876]);
                /* 878 SeqOp            */ __Matchers[878].Set(_referencePathElement, __Matchers[877]);

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
            private PlainRule _parameterDeclarationOrRef;
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
            private PlainRule _returnDirective;
            private PlainRule _throwDirective;
            private PlainRule _breakDirective;
            private PlainRule _continueDirective;
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
            private PlainRule _enumeration;
            private PlainRule _tuple;
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
            private PlainRule _letExpression;
            private PlainRule _letVariableList;
            private PlainRule _letVariable;
            private PlainRule _switchExpression;
            private PlainRule _caseExpressions;
            private PlainRule _caseExpression;
            private PlainRule _ifExpression;
            private PlainRule _elseExpression;
            private PlainRule _thenExpression;
            private PlainRule _conditionalExpression;
            private PlainRule _functionExpression;
            private PlainRule _functionExpressionType;
            private PlainRule _functionParameters;
            private PlainRule _functionDefinition;
            private PlainRule _comprehension;
            private PlainRule _comprehensionClause;
            private PlainRule _expressionComprehensionClause;
            private PlainRule _forComprehensionClause;
            private PlainRule _ifComprehensionClause;
            private PlainRule _expression;
            private PlainRule _operatorExpression;
            private PlainRule _assignmentExpression;
            private PlainRule _assignment;
            private PlainRule _assignmentOperator;
            private PlainRule _thenElseExpression;
            private PlainRule _thenElse;
            private PlainRule _thenElseOperator;
            private PlainRule _disjunctionExpression;
            private PlainRule _disjunction;
            private PlainRule _disjunctionOperator;
            private PlainRule _conjunctionExpression;
            private PlainRule _conjunction;
            private PlainRule _conjunctionOperator;
            private PlainRule _logicalNegationExpression;
            private PlainRule _logicalNegation;
            private PlainRule _notOperator;
            private PlainRule _expressionOrMeta;
            private PlainRule _equalityExpression;
            private PlainRule _equality;
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
            private PlainRule _existsExpression;
            private PlainRule _nonemptyExpression;
            private PlainRule _entryRangeExpression;
            private PlainRule _entryOrRange;
            private PlainRule _rangeOrEntryOperator;
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
            private PlainRule _opNegate;
            private PlainRule _opNeutral;
            private PlainRule _opComplement;
            private PlainRule _prefixExpression;
            private PlainRule _prefixExpr;
            private PlainRule _postfixExpression;
            private PlainRule _postfixExpr;
            private PlainRule _incrementOperator;
            private PlainRule _primary;
            private PlainRule _selectionExpression;
            private PlainRule _qualifiedReference;
            private PlainRule _memberSelectionOperator;
            private PlainRule _indexedExpression;
            private PlainRule _index;
            private PlainRule _upperSpanned;
            private PlainRule _lowerSpanned;
            private PlainRule _spanned;
            private PlainRule _measured;
            private PlainRule _indexExpression;
            private PlainRule _callExpression;
            private PlainRule _baseExpression;
            private PlainRule _nonstringLiteral;
            private PlainRule _stringExpression;
            private PlainRule _stringInterpolation;
            private PlainRule _interpolationPart;
            private PlainRule _stringLiteral;
            private PlainRule _objectExpression;
            private PlainRule _groupedExpression;
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
            private PlainRule _switchCaseElse;
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
            private PlainRule _whileLoop;
            private PlainRule _whileBlock;
            private PlainRule _tryCatchFinally;
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
            private Dfa __Matchers_718_DFA = new Dfa("__Matchers_718_DFA");
            private Dfa __Matchers_720_DFA = new Dfa("__Matchers_720_DFA");
        }
    }

    public partial class CeylonTree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface ICompilationUnit {}
        public interface IUnitElements : ICompilationUnit {}
        public interface IImportDeclarations {}
        public interface IModuleDescriptor : ICompilationUnit {}
        public interface IModuleSpecifier {}
        public interface IRepository {}
        public interface IModule {}
        public interface IArtifactAndClassifier {}
        public interface IArtifact {}
        public interface IClassifier {}
        public interface IVersion {}
        public interface IModuleName : IModule {}
        public interface IModuleBody {}
        public interface IModuleBodyElement {}
        public interface IPackageDescriptor : ICompilationUnit {}
        public interface IImportModule : IModuleBodyElement {}
        public interface IImportDeclaration {}
        public interface IImportElements {}
        public interface IImportElementList {}
        public interface IImportElement {}
        public interface IImportNamed : IImportElement {}
        public interface IImportName {}
        public interface IImportNameSpecifier {}
        public interface IImportWildcard : IImportElement {}
        public interface IPackageName {}
        public interface IPackagePath : IModuleName {}
        public interface IAnnotationName {}
        public interface IMemberName {}
        public interface ITypeName {}
        public interface IPattern : ICaseItem, IVariadicPattern {}
        public interface IVariableOrTuplePattern {}
        public interface ITupleOrEntryPattern : IForVariable, IParameterDeclarationOrRefPattern {}
        public interface IEntryPattern : IPattern, ITupleOrEntryPattern {}
        public interface ITuplePattern : IPattern, ITupleOrEntryPattern, IVariableOrTuplePattern {}
        public interface IVariadicPatternList {}
        public interface IVariadicPattern {}
        public interface IVariablePattern : IPattern, IVariableOrTuplePattern {}
        public interface IVariadicVariable : IVariadicPattern {}
        public interface ILetStatement : IOpenStatement {}
        public interface IDelegatedConstructor {}
        public interface IAssertionStatement : IOpenStatement {}
        public interface IAssertionMessage {}
        public interface IBlock : IAttributeDefinition, IElseBlockNext, IFunctionDefinition, IMethodDefinition, ISetterDefinition {}
        public interface IInterfaceBlock : IInterfaceDefinition {}
        public interface IClassBlock : IClassDefinition {}
        public interface IBlockElements : IBlock, IClassBlock, IInterfaceBlock {}
        public interface IExtendedType {}
        public interface IClassSpecifier {}
        public interface IClassInstatiation {}
        public interface IQualifiedClass {}
        public interface ISuperQualifiedClass : IQualifiedClass {}
        public interface ISuperQualifier {}
        public interface IPackageQualifiedClass : IQualifiedClass {}
        public interface IPackageQualifier {}
        public interface IUnQualifiedClass : IQualifiedClass {}
        public interface IMemberPath : IUnQualifiedClass {}
        public interface ITypePath : IUnQualifiedClass {}
        public interface ISatisfiedTypes {}
        public interface IUnionTypeList {}
        public interface ICaseTypes {}
        public interface ICaseTypeList {}
        public interface ICaseType {}
        public interface IQualifiedCaseType : ICaseType {}
        public interface IParameters {}
        public interface IParameterList {}
        public interface IParameterDeclarationOrRefPattern {}
        public interface IParameterDeclarationOrRef : IParameterDeclarationOrRefPattern {}
        public interface IParameter : IParameterDeclarationOrRef {}
        public interface IParameterReference : IParameterDeclarationOrRef {}
        public interface IParameterDeclaration {}
        public interface IFunctionParameterDeclaration : IParameterDeclaration {}
        public interface IFunctionParameterType {}
        public interface IValueParameterDeclaration : IParameterDeclaration {}
        public interface IValueParameterType {}
        public interface ITypeParameters {}
        public interface ITypeParameterList {}
        public interface ITypeParameter {}
        public interface IVariance {}
        public interface ITypeDefault {}
        public interface ITypeConstraint {}
        public interface ITypeConstraints {}
        public interface IDeclarationOrStatement {}
        public interface IDeclaration : IDeclarationOrStatement {}
        public interface IConstructorDeclaration : IDeclaration {}
        public interface IAliasDeclaration : IDeclaration {}
        public interface IEnumeratedObject : IDeclaration {}
        public interface IObjectDeclaration : IDeclaration {}
        public interface ISetterDeclaration : IDeclaration {}
        public interface ISetterDefinition {}
        public interface ITypedMethodDeclaration : IDeclaration {}
        public interface IMethodType {}
        public interface IInferredMethodDeclaration : IDeclaration {}
        public interface ITypedAttributeDeclaration : IDeclaration {}
        public interface IAttributeType {}
        public interface IInferredAttributeDeclaration : IDeclaration, IModuleBodyElement {}
        public interface IAttributeDefinition {}
        public interface IOptionalAnySpecifier : IAttributeDefinition {}
        public interface IClassDeclaration : IDeclaration {}
        public interface IClassDefinition {}
        public interface IOptionalClassSpecifier : IClassDefinition {}
        public interface IInterfaceDeclaration : IDeclaration {}
        public interface IInterfaceDefinition {}
        public interface IOptionalTypeSpecifier : IInterfaceDefinition {}
        public interface IStatement : IDeclarationOrStatement {}
        public interface IUnclosedStatement : IStatement {}
        public interface IOpenStatement {}
        public interface ISpecificationStatement : IOpenStatement {}
        public interface IExpressionStatement : IOpenStatement {}
        public interface IDirectiveStatement : IOpenStatement {}
        public interface IReturnDirective : IDirectiveStatement {}
        public interface IThrowDirective : IDirectiveStatement {}
        public interface IBreakDirective : IDirectiveStatement {}
        public interface IContinueDirective : IDirectiveStatement {}
        public interface ITypeSpecifier {}
        public interface IValueSpecifier : IAnySpecifier {}
        public interface IFunctionSpecifier : IAnySpecifier, IFunctionDefinition {}
        public interface IAnySpecifier {}
        public interface IBaseReferenceOrParameterized : IBaseExpression {}
        public interface IBaseReference : IBaseReferenceOrParameterized {}
        public interface IParametrizedMember : IBaseReferenceOrParameterized {}
        public interface ISelfParametrizedMember : IBaseReferenceOrParameterized {}
        public interface IMemberReference : IBaseReference, IMemberModelExpression, IUnQualifiedClass {}
        public interface ITypeReference : IBaseReference {}
        public interface ISelfReferenceSelector {}
        public interface ISelfReference : IBaseReferenceOrParameterized {}
        public interface IEnumeration : IBaseExpression {}
        public interface ITuple : IBaseExpression {}
        public interface IArguments {}
        public interface IStructuralArguments : IArguments {}
        public interface INamedOrAnonymous {}
        public interface INamedArgument : INamedOrAnonymous {}
        public interface INamedSpecifiedArgument : INamedArgument {}
        public interface ISequencedArguments {}
        public interface ISequencedArgument {}
        public interface IAnonymousArgument : INamedOrAnonymous {}
        public interface INamedArgumentDeclaration : INamedArgument {}
        public interface IObjectArgument : INamedArgumentDeclaration {}
        public interface ITypedMethodArgument : INamedArgumentDeclaration {}
        public interface IMethodDefinition {}
        public interface IOptionalFunctionSpecifier : IMethodDefinition {}
        public interface INeededFunctionSpecifier : ISetterDefinition {}
        public interface IMethodArgumentType {}
        public interface ITypedGetterArgument : INamedArgumentDeclaration {}
        public interface IGetterArgumentType {}
        public interface IInferredMethodArgument : INamedArgumentDeclaration {}
        public interface IInferredGetterArgument : INamedArgumentDeclaration {}
        public interface IUntypedMethodArgument : INamedArgumentDeclaration {}
        public interface IUntypedGetterArgument : INamedArgumentDeclaration {}
        public interface IPositionalArguments : IArguments {}
        public interface IPositionalArgument : ISequencedArgument {}
        public interface ISpreadArgument : ISequencedArgument {}
        public interface ILetExpression : IConditionalExpression, IExpression {}
        public interface ILetVariableList {}
        public interface ILetVariable : ILetOrExpression {}
        public interface ISwitchExpression : IExpression {}
        public interface ICaseExpressions {}
        public interface ICaseExpression {}
        public interface IIfExpression : IConditionalExpression, IExpression {}
        public interface IElseExpression {}
        public interface IThenExpression {}
        public interface IConditionalExpression {}
        public interface IFunctionExpression : IExpression {}
        public interface IFunctionExpressionType {}
        public interface IFunctionParameters {}
        public interface IFunctionDefinition {}
        public interface IComprehension : ISequencedArgument {}
        public interface IComprehensionClause {}
        public interface IExpressionComprehensionClause : IComprehensionClause {}
        public interface IForComprehensionClause : IComprehension, IComprehensionClause {}
        public interface IIfComprehensionClause : IComprehension, IComprehensionClause {}
        public interface IExpression : IBooleanCondition, IExpressionComprehensionClause, IIndex, IPositionalArgument {}
        public interface IOperatorExpression : IExpression, IExpressionStatement, ILetOrExpression, ISpecifiedOrExpression {}
        public interface IAssignmentExpression : IOperatorExpression {}
        public interface IAssignment : IAssignmentExpression {}
        public interface IAssignmentOperator {}
        public interface IThenElseExpression : IAssignmentExpression {}
        public interface IThenElse : IThenElseExpression {}
        public interface IThenElseOperator {}
        public interface IDisjunctionExpression : IConditionalExpression, IThenElseExpression {}
        public interface IDisjunction : IDisjunctionExpression {}
        public interface IDisjunctionOperator {}
        public interface IConjunctionExpression : IDisjunctionExpression {}
        public interface IConjunction : IConjunctionExpression {}
        public interface IConjunctionOperator {}
        public interface ILogicalNegationExpression : IConjunctionExpression {}
        public interface ILogicalNegation : ILogicalNegationExpression {}
        public interface INotOperator {}
        public interface IExpressionOrMeta : ILogicalNegationExpression {}
        public interface IEqualityExpression : IExpressionOrMeta {}
        public interface IEquality : IEqualityExpression {}
        public interface IEqualityOperator {}
        public interface IComparisonExpression : IEqualityExpression {}
        public interface IComparisonExpr : IComparisonExpression {}
        public interface ILargerExpr : IComparisonExpression {}
        public interface ISmallerExpr : IComparisonExpression {}
        public interface ILargerBoundsExpr : IComparisonExpression {}
        public interface ISmallerBoundsExpr : IComparisonExpression {}
        public interface ITypecheckExpr : IComparisonExpression {}
        public interface IComparisonOperator {}
        public interface ISmallerOperator {}
        public interface ILargerOperator {}
        public interface ITypeOperator {}
        public interface IExistsNonemptyExpression : IComparisonExpression {}
        public interface IExistsExpression : IExistsNonemptyExpression {}
        public interface INonemptyExpression : IExistsNonemptyExpression {}
        public interface IEntryRangeExpression : IExistsNonemptyExpression {}
        public interface IEntryOrRange : IEntryRangeExpression {}
        public interface IRangeOrEntryOperator {}
        public interface IAdditiveExpression : IEntryRangeExpression, IIndexExpression {}
        public interface IAdditiveExpr : IAdditiveExpression {}
        public interface IAdditiveOperator {}
        public interface IScaleExpression : IAdditiveExpression {}
        public interface IScaleExpr : IScaleExpression {}
        public interface IScaleOperator {}
        public interface IMultiplicativeExpression : IScaleExpression {}
        public interface IMultiplicativeExpr : IMultiplicativeExpression {}
        public interface IMultiplicativeOperator {}
        public interface IUnionExpression : IMultiplicativeExpression {}
        public interface IUnionExpr : IUnionExpression {}
        public interface IUnionOperator {}
        public interface IExclusiveExpression : IUnionExpression {}
        public interface IExclusiveExpr : IExclusiveExpression {}
        public interface IExclusiveOperator {}
        public interface IIntersectionExpression : IExclusiveExpression, IValueCase {}
        public interface IIntersectionExpr : IIntersectionExpression {}
        public interface IIntersectionOperator {}
        public interface INegationOrComplementExpression : IIntersectionExpression {}
        public interface INegationOrComplementExpr : INegationOrComplementExpression {}
        public interface IUnaryMinusOrComplementOperator {}
        public interface IOpNegate : IUnaryMinusOrComplementOperator {}
        public interface IOpNeutral : IUnaryMinusOrComplementOperator {}
        public interface IOpComplement : IUnaryMinusOrComplementOperator {}
        public interface IPrefixExpression : INegationOrComplementExpression {}
        public interface IPrefixExpr : IPrefixExpression {}
        public interface IPostfixExpression : IPrefixExpression {}
        public interface IPostfixExpr : IPostfixExpression {}
        public interface IIncrementOperator {}
        public interface IPrimary : IPostfixExpression {}
        public interface ISelectionExpression : IPrimary {}
        public interface IQualifiedReference {}
        public interface IMemberSelectionOperator {}
        public interface IIndexedExpression : IPrimary {}
        public interface IIndex {}
        public interface IUpperSpanned : IIndex {}
        public interface ILowerSpanned : IIndex {}
        public interface ISpanned : IIndex {}
        public interface IMeasured : IIndex {}
        public interface IIndexExpression {}
        public interface ICallExpression : IPrimary {}
        public interface IBaseExpression : IPrimary {}
        public interface INonstringLiteral : IBaseExpression {}
        public interface IStringExpression : IAssertionMessage, IBaseExpression {}
        public interface IStringInterpolation : IStringExpression {}
        public interface IInterpolationPart {}
        public interface IStringLiteral : IStringExpression {}
        public interface IObjectExpression : IBaseExpression {}
        public interface IGroupedExpression : IBaseExpression {}
        public interface ITypeArguments {}
        public interface ITypeArgumentList {}
        public interface IVariancedType {}
        public interface IDefaultedTypeList : ITypeTypeArguments {}
        public interface IDefaultedType {}
        public interface IDefaultedTypeCore : IDefaultedType {}
        public interface IVariadicType : IAttributeType, IDefaultedType, IFunctionParameterType, IMethodType, IValueParameterType {}
        public interface IVariadicUnionType : IVariadicType {}
        public interface IVariadicOperator {}
        public interface ISpreadType : ITypeTypeArguments {}
        public interface IType : IGetterArgumentType, IMethodArgumentType, ITypeModelExpression, IVariableType, IVariadicType {}
        public interface IEntryType : IType {}
        public interface IUnionType : IType {}
        public interface IUnionTypeCore : IUnionType {}
        public interface IIntersectionType : IUnionType, IValueCase {}
        public interface IIntersectionTypeCore : IIntersectionType {}
        public interface IPrimaryType : ICaseType, IIntersectionType {}
        public interface INullableType : IPrimaryType {}
        public interface IArrayType : IPrimaryType {}
        public interface IFunctionType : IPrimaryType {}
        public interface ITypeTypeArguments {}
        public interface ITupleType : IPrimaryType {}
        public interface IIterableType : IPrimaryType {}
        public interface IGroupedType : IPrimaryType {}
        public interface IQualifiedType : IPrimaryType {}
        public interface IAnnotations {}
        public interface IAnnotation {}
        public interface IConditions {}
        public interface IConditionList {}
        public interface ICondition {}
        public interface IExistsCondition : ICondition {}
        public interface INonemptyCondition : ICondition {}
        public interface ILetOrExpression {}
        public interface IIsCondition : ICondition {}
        public interface IIsConditionVariable {}
        public interface ISatisfiesCondition : ICondition {}
        public interface IBooleanCondition : ICondition {}
        public interface IControlStatement : IStatement {}
        public interface IIfElseStatement : IControlStatement, IElseBlockNext {}
        public interface IIfBlock {}
        public interface IElseBlock {}
        public interface IElseBlockNext {}
        public interface ISwitchCaseElse : IControlStatement {}
        public interface ISwitchHeader {}
        public interface ISwitched {}
        public interface ICaseBlock {}
        public interface ICaseItem {}
        public interface IIsCaseCondition : ICaseItem {}
        public interface ISatisfiesCaseCondition : ICaseItem {}
        public interface IMatchCaseCondition : ICaseItem {}
        public interface IValueCaseList : IMatchCaseCondition {}
        public interface IValueCaseSeparator {}
        public interface IValueCase {}
        public interface IForElseStatement : IControlStatement {}
        public interface IForBlock {}
        public interface IFailBlock {}
        public interface IForIterator {}
        public interface IForVariable {}
        public interface IContainment {}
        public interface IContainmentOperator {}
        public interface IWhileLoop : IControlStatement {}
        public interface IWhileBlock : IWhileLoop {}
        public interface ITryCatchFinally : IControlStatement {}
        public interface ITryBlock {}
        public interface ICatchBlock {}
        public interface ICatchVariable {}
        public interface IFinallyBlock {}
        public interface IResources {}
        public interface IResourceList {}
        public interface IResource {}
        public interface ISpecifiedOrExpression : IResource, ISwitched {}
        public interface ISpecifiedVariable : ISpecifiedOrExpression {}
        public interface IVariable : IForVariable, IVariablePattern {}
        public interface IVariableType {}
        public interface IModelReference : IExpressionOrMeta {}
        public interface IMetaLiteral : IBaseExpression {}
        public interface IMetaExpression {}
        public interface IModelExpression : IMetaExpression {}
        public interface IMemberModelExpression : IModelExpression {}
        public interface IPackageQualifiedMemberReference : IMemberModelExpression {}
        public interface ITypeQualifiedMemberReference : IMemberModelExpression {}
        public interface ITypeModelExpression : IModelExpression {}
        public interface IDeclarationReference : IMetaExpression, IPositionalArgument {}
        public interface IModuleLiteral : IDeclarationReference {}
        public interface IPackageLiteral : IDeclarationReference {}
        public interface IClassLiteral : IDeclarationReference {}
        public interface IInterfaceLiteral : IDeclarationReference {}
        public interface IAliasLiteral : IDeclarationReference {}
        public interface ITypeParameterLiteral : IDeclarationReference {}
        public interface INewLiteral : IDeclarationReference {}
        public interface IValueLiteral : IDeclarationReference {}
        public interface IValueLiteralIntro {}
        public interface IFunctionLiteral : IDeclarationReference {}
        public interface IReferencePath {}
        public interface IReferencePathElementList {}
        public interface IReferencePathElement {}
        public interface IKwVoid : IFunctionParameterType, IMethodArgumentType, IMethodType, IVariableType {}
        public interface IKwFunction : IFunctionParameterType, IVariableType {}
        public interface IKwValue : IValueParameterType, IVariableType {}
        public interface ILiteralFloat : INonstringLiteral {}
        public interface ILiteralNatural : INonstringLiteral {}
        public interface ILiteralChar : INonstringLiteral {}
        public interface IStringStart {}
        public interface IStringMid {}
        public interface IStringEnd {}
        public interface ILiteralString : IModule, IStringLiteral, IVersion {}
        public interface IVerbatimString : IStringLiteral {}
        public interface ILowerIdentifier : IAnnotationName, IMemberName {}
        public interface IUpperIdentifier : ITypeName {}
        public interface IIdentifier : IImportName, IPackageName, IReferencePathElement, IRepository {}

        public partial class CXStart : RSequence, IXStart
        {
            public CXStart(params RNode[] children) : base(children) {}

            public ICompilationUnit CompilationUnit => Get<ICompilationUnit>(0);
            public REof Eof => Get<REof>(1);
        }

        public partial class CXWhitespace : RString, IXWhitespace
        {
            public CXWhitespace(params Node[] children) : base(children) {}
        }

        public partial class CXKeywords : RString, IXKeywords
        {
            public CXKeywords(params Node[] children) : base(children) {}
        }

        public partial class CUnitElements : RSequence, IUnitElements
        {
            public CUnitElements(params RNode[] children) : base(children) {}

            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(0);
            public RStar<IDeclaration> Declaration => Get<RStar<IDeclaration>>(1);
        }

        public partial class CImportDeclarations : RStar<CImportDeclaration>, IImportDeclarations
        {
            public CImportDeclarations(params RNode[] children) : base(children) {}
        }

        public partial class CModuleDescriptor : RSequence, IModuleDescriptor
        {
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IModuleName ModuleName => Get<IModuleName>(2);
            public ROptional<CModuleSpecifier> ModuleSpecifier => Get<ROptional<CModuleSpecifier>>(3);
            public ROptional<IVersion> Version => Get<ROptional<IVersion>>(4);
            public CModuleBody ModuleBody => Get<CModuleBody>(5);
        }

        public partial class CModuleSpecifier : RSequence, IModuleSpecifier
        {
            public CModuleSpecifier(params RNode[] children) : base(children) {}

            public IRepository Repository => Get<IRepository>(0);
            public RString String => Get<RString>(1);
            public IModule Module => Get<IModule>(2);
            public ROptional<CArtifactAndClassifier> ArtifactAndClassifier => Get<ROptional<CArtifactAndClassifier>>(3);
        }

        public partial class CArtifactAndClassifier : RSequence, IArtifactAndClassifier
        {
            public CArtifactAndClassifier(params RNode[] children) : base(children) {}

            public CArtifact Artifact => Get<CArtifact>(0);
            public ROptional<CClassifier> Classifier => Get<ROptional<CClassifier>>(1);
        }

        public partial class CArtifact : RSequence, IArtifact
        {
            public CArtifact(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CClassifier : RSequence, IClassifier
        {
            public CClassifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CLiteralString LiteralString => Get<CLiteralString>(1);
        }

        public partial class CModuleBody : RSequence, IModuleBody
        {
            public CModuleBody(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RStar<IModuleBodyElement> ModuleBodyElement => Get<RStar<IModuleBodyElement>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CPackageDescriptor : RSequence, IPackageDescriptor
        {
            public CPackageDescriptor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public CPackagePath PackagePath => Get<CPackagePath>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CImportModule : RSequence, IImportModule
        {
            public CImportModule(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IModule Module => Get<IModule>(2);
            public ROptional<IVersion> Version => Get<ROptional<IVersion>>(3);
            public RString String2 => Get<RString>(4);
        }

        public partial class CImportDeclaration : RSequence, IImportDeclaration
        {
            public CImportDeclaration(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CPackagePath PackagePath => Get<CPackagePath>(1);
            public CImportElements ImportElements => Get<CImportElements>(2);
        }

        public partial class CImportElements : RSequence, IImportElements
        {
            public CImportElements(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CImportElementList> ImportElementList => Get<ROptional<CImportElementList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CImportElementList : RLoop<IImportElement>, IImportElementList
        {
            public CImportElementList(params RNode[] children) : base(children) {}
        }

        public partial class CImportNamed : RSequence, IImportNamed
        {
            public CImportNamed(params RNode[] children) : base(children) {}

            public IImportName ImportName => Get<IImportName>(0);
            public ROptional<CImportNameSpecifier> ImportNameSpecifier => Get<ROptional<CImportNameSpecifier>>(1);
            public ROptional<CImportElements> ImportElements => Get<ROptional<CImportElements>>(2);
        }

        public partial class CImportNameSpecifier : RSequence, IImportNameSpecifier
        {
            public CImportNameSpecifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CIdentifier Identifier => Get<CIdentifier>(1);
        }

        public partial class CImportWildcard : RString, IImportWildcard
        {
            public CImportWildcard(params Node[] children) : base(children) {}
        }

        public partial class CPackagePath : RLoop<IPackageName>, IPackagePath
        {
            public CPackagePath(params RNode[] children) : base(children) {}
        }

        public partial class CEntryPattern : RSequence, IEntryPattern
        {
            public CEntryPattern(params RNode[] children) : base(children) {}

            public IVariableOrTuplePattern VariableOrTuplePattern => Get<IVariableOrTuplePattern>(0);
            public RString String => Get<RString>(1);
            public IVariableOrTuplePattern VariableOrTuplePattern2 => Get<IVariableOrTuplePattern>(2);
        }

        public partial class CTuplePattern : RSequence, ITuplePattern
        {
            public CTuplePattern(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CVariadicPatternList> VariadicPatternList => Get<ROptional<CVariadicPatternList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CVariadicPatternList : RLoop<IVariadicPattern>, IVariadicPatternList
        {
            public CVariadicPatternList(params RNode[] children) : base(children) {}
        }

        public partial class CVariadicVariable : RSequence, IVariadicVariable
        {
            public CVariadicVariable(params RNode[] children) : base(children) {}

            public ROptional<IUnionType> UnionType => Get<ROptional<IUnionType>>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
            public ROptional<IMemberName> MemberName => Get<ROptional<IMemberName>>(2);
        }

        public partial class CLetStatement : RSequence, ILetStatement
        {
            public CLetStatement(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public CLetVariableList LetVariableList => Get<CLetVariableList>(2);
            public RString String3 => Get<RString>(3);
        }

        public partial class CDelegatedConstructor : RSequence, IDelegatedConstructor
        {
            public CDelegatedConstructor(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CAssertionStatement : RSequence, IAssertionStatement
        {
            public CAssertionStatement(params RNode[] children) : base(children) {}

            public ROptional<IAssertionMessage> AssertionMessage => Get<ROptional<IAssertionMessage>>(0);
            public RString String => Get<RString>(1);
            public CConditions Conditions => Get<CConditions>(2);
        }

        public partial class CBlockElements : RSequence, IBlockElements
        {
            public CBlockElements(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CImportDeclarations ImportDeclarations => Get<CImportDeclarations>(1);
            public RStar<IDeclarationOrStatement> DeclarationOrStatement => Get<RStar<IDeclarationOrStatement>>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CExtendedType : RSequence, IExtendedType
        {
            public CExtendedType(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassSpecifier : RSequence, IClassSpecifier
        {
            public CClassSpecifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CClassInstatiation ClassInstatiation => Get<CClassInstatiation>(1);
        }

        public partial class CClassInstatiation : RSequence, IClassInstatiation
        {
            public CClassInstatiation(params RNode[] children) : base(children) {}

            public IQualifiedClass QualifiedClass => Get<IQualifiedClass>(0);
            public ROptional<IArguments> Arguments => Get<ROptional<IArguments>>(1);
        }

        public partial class CSuperQualifiedClass : RSequence, ISuperQualifiedClass
        {
            public CSuperQualifiedClass(params RNode[] children) : base(children) {}

            public CSuperQualifier SuperQualifier => Get<CSuperQualifier>(0);
            public IBaseReference BaseReference => Get<IBaseReference>(1);
        }

        public partial class CSuperQualifier : RSequence, ISuperQualifier
        {
            public CSuperQualifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
        }

        public partial class CPackageQualifiedClass : RSequence, IPackageQualifiedClass
        {
            public CPackageQualifiedClass(params RNode[] children) : base(children) {}

            public CPackageQualifier PackageQualifier => Get<CPackageQualifier>(0);
            public IUnQualifiedClass UnQualifiedClass => Get<IUnQualifiedClass>(1);
        }

        public partial class CPackageQualifier : RSequence, IPackageQualifier
        {
            public CPackageQualifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
        }

        public partial class CMemberPath : RSequence, IMemberPath
        {
            public CMemberPath(params RNode[] children) : base(children) {}

            public CTypePath TypePath => Get<CTypePath>(0);
            public RString String => Get<RString>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CTypePath : RLoop<CTypeReference>, ITypePath
        {
            public CTypePath(params RNode[] children) : base(children) {}
        }

        public partial class CSatisfiedTypes : RSequence, ISatisfiedTypes
        {
            public CSatisfiedTypes(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CUnionTypeList UnionTypeList => Get<CUnionTypeList>(1);
        }

        public partial class CUnionTypeList : RLoop<IUnionType>, IUnionTypeList
        {
            public CUnionTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CCaseTypes : RSequence, ICaseTypes
        {
            public CCaseTypes(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CCaseTypeList CaseTypeList => Get<CCaseTypeList>(1);
        }

        public partial class CCaseTypeList : RLoop<ICaseType>, ICaseTypeList
        {
            public CCaseTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CQualifiedCaseType : RSequence, IQualifiedCaseType
        {
            public CQualifiedCaseType(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifier => Get<ROptional<CPackageQualifier>>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
        }

        public partial class CParameters : RSequence, IParameters
        {
            public CParameters(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CParameterList> ParameterList => Get<ROptional<CParameterList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CParameterList : RLoop<IParameterDeclarationOrRefPattern>, IParameterList
        {
            public CParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CParameter : RSequence, IParameter
        {
            public CParameter(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public IParameterDeclaration ParameterDeclaration => Get<IParameterDeclaration>(1);
        }

        public partial class CParameterReference : RSequence, IParameterReference
        {
            public CParameterReference(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CFunctionParameterDeclaration : RSequence, IFunctionParameterDeclaration
        {
            public CFunctionParameterDeclaration(params RNode[] children) : base(children) {}

            public IFunctionParameterType FunctionParameterType => Get<IFunctionParameterType>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(3);
            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(4);
        }

        public partial class CValueParameterDeclaration : RSequence, IValueParameterDeclaration
        {
            public CValueParameterDeclaration(params RNode[] children) : base(children) {}

            public IValueParameterType ValueParameterType => Get<IValueParameterType>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(2);
        }

        public partial class CTypeParameters : RSequence, ITypeParameters
        {
            public CTypeParameters(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CTypeParameterList TypeParameterList => Get<CTypeParameterList>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CTypeParameterList : RLoop<CTypeParameter>, ITypeParameterList
        {
            public CTypeParameterList(params RNode[] children) : base(children) {}
        }

        public partial class CTypeParameter : RSequence, ITypeParameter
        {
            public CTypeParameter(params RNode[] children) : base(children) {}

            public ROptional<IVariance> Variance => Get<ROptional<IVariance>>(0);
            public ITypeName TypeName => Get<ITypeName>(1);
            public ROptional<CTypeDefault> TypeDefault => Get<ROptional<CTypeDefault>>(2);
        }

        public partial class CVariance : RString, IVariance
        {
            public CVariance(params Node[] children) : base(children) {}
        }

        public partial class CTypeDefault : RSequence, ITypeDefault
        {
            public CTypeDefault(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IType Type => Get<IType>(1);
        }

        public partial class CTypeConstraint : RSequence, ITypeConstraint
        {
            public CTypeConstraint(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<ITypeName> TypeName => Get<ROptional<ITypeName>>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(4);
        }

        public partial class CTypeConstraints : RPlus<CTypeConstraint>, ITypeConstraints
        {
            public CTypeConstraints(params RNode[] children) : base(children) {}
        }

        public partial class CConstructorDeclaration : RSequence, IConstructorDeclaration
        {
            public CConstructorDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public ROptional<IMemberName> MemberName => Get<ROptional<IMemberName>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public ROptional<CDelegatedConstructor> DelegatedConstructor => Get<ROptional<CDelegatedConstructor>>(4);
            public IBlock Block => Get<IBlock>(5);
        }

        public partial class CAliasDeclaration : RSequence, IAliasDeclaration
        {
            public CAliasDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public ITypeName TypeName => Get<ITypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(4);
            public COptionalTypeSpecifier OptionalTypeSpecifier => Get<COptionalTypeSpecifier>(5);
        }

        public partial class CEnumeratedObject : RSequence, IEnumeratedObject
        {
            public CEnumeratedObject(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IMemberName MemberName => Get<IMemberName>(2);
            public ROptional<CDelegatedConstructor> DelegatedConstructor => Get<ROptional<CDelegatedConstructor>>(3);
            public IBlock Block => Get<IBlock>(4);
        }

        public partial class CObjectDeclaration : RSequence, IObjectDeclaration
        {
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IMemberName MemberName => Get<IMemberName>(2);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(3);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(4);
            public IClassBlock ClassBlock => Get<IClassBlock>(5);
        }

        public partial class CSetterDeclaration : RSequence, ISetterDeclaration
        {
            public CSetterDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IMemberName MemberName => Get<IMemberName>(2);
            public ISetterDefinition SetterDefinition => Get<ISetterDefinition>(3);
        }

        public partial class CTypedMethodDeclaration : RSequence, ITypedMethodDeclaration
        {
            public CTypedMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public IMethodType MethodType => Get<IMethodType>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(3);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(4);
        }

        public partial class CInferredMethodDeclaration : RSequence, IInferredMethodDeclaration
        {
            public CInferredMethodDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(2);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(3);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(4);
        }

        public partial class CTypedAttributeDeclaration : RSequence, ITypedAttributeDeclaration
        {
            public CTypedAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public IAttributeType AttributeType => Get<IAttributeType>(1);
            public IMemberName MemberName => Get<IMemberName>(2);
            public IAttributeDefinition AttributeDefinition => Get<IAttributeDefinition>(3);
        }

        public partial class CInferredAttributeDeclaration : RSequence, IInferredAttributeDeclaration
        {
            public CInferredAttributeDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public IMemberName MemberName => Get<IMemberName>(2);
            public IAttributeDefinition AttributeDefinition => Get<IAttributeDefinition>(3);
        }

        public partial class COptionalAnySpecifier : RSequence, IOptionalAnySpecifier
        {
            public COptionalAnySpecifier(params RNode[] children) : base(children) {}

            public ROptional<IAnySpecifier> AnySpecifier => Get<ROptional<IAnySpecifier>>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CClassDeclaration : RSequence, IClassDeclaration
        {
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public ITypeName TypeName => Get<ITypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(6);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(7);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(8);
            public IClassDefinition ClassDefinition => Get<IClassDefinition>(9);
        }

        public partial class COptionalClassSpecifier : RSequence, IOptionalClassSpecifier
        {
            public COptionalClassSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CClassSpecifier> ClassSpecifier => Get<ROptional<CClassSpecifier>>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CInterfaceDeclaration : RSequence, IInterfaceDeclaration
        {
            public CInterfaceDeclaration(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public ITypeName TypeName => Get<ITypeName>(2);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(3);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(4);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(5);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(6);
            public IInterfaceDefinition InterfaceDefinition => Get<IInterfaceDefinition>(7);
        }

        public partial class COptionalTypeSpecifier : RSequence, IOptionalTypeSpecifier
        {
            public COptionalTypeSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CTypeSpecifier> TypeSpecifier => Get<ROptional<CTypeSpecifier>>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CUnclosedStatement : RSequence, IUnclosedStatement
        {
            public CUnclosedStatement(params RNode[] children) : base(children) {}

            public IOpenStatement OpenStatement => Get<IOpenStatement>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CSpecificationStatement : RSequence, ISpecificationStatement
        {
            public CSpecificationStatement(params RNode[] children) : base(children) {}

            public IPrimary Primary => Get<IPrimary>(0);
            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(1);
        }

        public partial class CReturnDirective : RSequence, IReturnDirective
        {
            public CReturnDirective(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<IExpression> Expression => Get<ROptional<IExpression>>(1);
        }

        public partial class CThrowDirective : RSequence, IThrowDirective
        {
            public CThrowDirective(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<IExpression> Expression => Get<ROptional<IExpression>>(1);
        }

        public partial class CBreakDirective : RString, IBreakDirective
        {
            public CBreakDirective(params Node[] children) : base(children) {}
        }

        public partial class CContinueDirective : RString, IContinueDirective
        {
            public CContinueDirective(params Node[] children) : base(children) {}
        }

        public partial class CTypeSpecifier : RSequence, ITypeSpecifier
        {
            public CTypeSpecifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IType Type => Get<IType>(1);
        }

        public partial class CValueSpecifier : RSequence, IValueSpecifier
        {
            public CValueSpecifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IExpression Expression => Get<IExpression>(1);
        }

        public partial class CFunctionSpecifier : RSequence, IFunctionSpecifier
        {
            public CFunctionSpecifier(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IExpression Expression => Get<IExpression>(1);
        }

        public partial class CParametrizedMember : RSequence, IParametrizedMember
        {
            public CParametrizedMember(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(2);
        }

        public partial class CSelfParametrizedMember : RSequence, ISelfParametrizedMember
        {
            public CSelfParametrizedMember(params RNode[] children) : base(children) {}

            public CSelfReferenceSelector SelfReferenceSelector => Get<CSelfReferenceSelector>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
        }

        public partial class CMemberReference : RSequence, IMemberReference
        {
            public CMemberReference(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public ROptional<CTypeArguments> TypeArguments => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CTypeReference : RSequence, ITypeReference
        {
            public CTypeReference(params RNode[] children) : base(children) {}

            public ITypeName TypeName => Get<ITypeName>(0);
            public ROptional<CTypeArguments> TypeArguments => Get<ROptional<CTypeArguments>>(1);
        }

        public partial class CSelfReferenceSelector : RSequence, ISelfReferenceSelector
        {
            public CSelfReferenceSelector(params RNode[] children) : base(children) {}

            public CSelfReference SelfReference => Get<CSelfReference>(0);
            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(1);
        }

        public partial class CSelfReference : RString, ISelfReference
        {
            public CSelfReference(params Node[] children) : base(children) {}
        }

        public partial class CEnumeration : RSequence, IEnumeration
        {
            public CEnumeration(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RStar<IDeclarationOrStatement> DeclarationOrStatement => Get<RStar<IDeclarationOrStatement>>(1);
            public ROptional<CSequencedArguments> SequencedArguments => Get<ROptional<CSequencedArguments>>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CTuple : RSequence, ITuple
        {
            public CTuple(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CSequencedArguments> SequencedArguments => Get<ROptional<CSequencedArguments>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CStructuralArguments : RSequence, IStructuralArguments
        {
            public CStructuralArguments(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RStar<INamedOrAnonymous> NamedOrAnonymous => Get<RStar<INamedOrAnonymous>>(1);
            public ROptional<CSequencedArguments> SequencedArguments => Get<ROptional<CSequencedArguments>>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CNamedSpecifiedArgument : RSequence, INamedSpecifiedArgument
        {
            public CNamedSpecifiedArgument(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
            public RString String => Get<RString>(2);
        }

        public partial class CSequencedArguments : RLoop<ISequencedArgument>, ISequencedArguments
        {
            public CSequencedArguments(params RNode[] children) : base(children) {}
        }

        public partial class CAnonymousArgument : RSequence, IAnonymousArgument
        {
            public CAnonymousArgument(params RNode[] children) : base(children) {}

            public IExpression Expression => Get<IExpression>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CObjectArgument : RSequence, IObjectArgument
        {
            public CObjectArgument(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<IMemberName> MemberName => Get<ROptional<IMemberName>>(1);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(2);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(3);
            public IClassBlock ClassBlock => Get<IClassBlock>(4);
        }

        public partial class CTypedMethodArgument : RSequence, ITypedMethodArgument
        {
            public CTypedMethodArgument(params RNode[] children) : base(children) {}

            public IMethodArgumentType MethodArgumentType => Get<IMethodArgumentType>(0);
            public CParametrizedMember ParametrizedMember => Get<CParametrizedMember>(1);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(2);
        }

        public partial class COptionalFunctionSpecifier : RSequence, IOptionalFunctionSpecifier
        {
            public COptionalFunctionSpecifier(params RNode[] children) : base(children) {}

            public ROptional<CFunctionSpecifier> FunctionSpecifier => Get<ROptional<CFunctionSpecifier>>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CNeededFunctionSpecifier : RSequence, INeededFunctionSpecifier
        {
            public CNeededFunctionSpecifier(params RNode[] children) : base(children) {}

            public CFunctionSpecifier FunctionSpecifier => Get<CFunctionSpecifier>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CTypedGetterArgument : RSequence, ITypedGetterArgument
        {
            public CTypedGetterArgument(params RNode[] children) : base(children) {}

            public IGetterArgumentType GetterArgumentType => Get<IGetterArgumentType>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(2);
        }

        public partial class CInferredMethodArgument : RSequence, IInferredMethodArgument
        {
            public CInferredMethodArgument(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<IMemberName> MemberName => Get<ROptional<IMemberName>>(1);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(2);
            public CParameters Parameters => Get<CParameters>(3);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(4);
        }

        public partial class CInferredGetterArgument : RSequence, IInferredGetterArgument
        {
            public CInferredGetterArgument(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
            public IMethodDefinition MethodDefinition => Get<IMethodDefinition>(2);
        }

        public partial class CUntypedMethodArgument : RSequence, IUntypedMethodArgument
        {
            public CUntypedMethodArgument(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(1);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(2);
        }

        public partial class CUntypedGetterArgument : RSequence, IUntypedGetterArgument
        {
            public CUntypedGetterArgument(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public CNeededFunctionSpecifier NeededFunctionSpecifier => Get<CNeededFunctionSpecifier>(1);
        }

        public partial class CPositionalArguments : RSequence, IPositionalArguments
        {
            public CPositionalArguments(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CSequencedArguments> SequencedArguments => Get<ROptional<CSequencedArguments>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CSpreadArgument : RSequence, ISpreadArgument
        {
            public CSpreadArgument(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IUnionExpression UnionExpression => Get<IUnionExpression>(1);
        }

        public partial class CLetExpression : RSequence, ILetExpression
        {
            public CLetExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public ROptional<CLetVariableList> LetVariableList => Get<ROptional<CLetVariableList>>(2);
            public RString String3 => Get<RString>(3);
            public IConditionalExpression ConditionalExpression => Get<IConditionalExpression>(4);
        }

        public partial class CLetVariableList : RLoop<CLetVariable>, ILetVariableList
        {
            public CLetVariableList(params RNode[] children) : base(children) {}
        }

        public partial class CLetVariable : RSequence, ILetVariable
        {
            public CLetVariable(params RNode[] children) : base(children) {}

            public IPattern Pattern => Get<IPattern>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CSwitchExpression : RSequence, ISwitchExpression
        {
            public CSwitchExpression(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public CCaseExpressions CaseExpressions => Get<CCaseExpressions>(1);
        }

        public partial class CCaseExpressions : RSequence, ICaseExpressions
        {
            public CCaseExpressions(params RNode[] children) : base(children) {}

            public RPlus<CCaseExpression> CaseExpression => Get<RPlus<CCaseExpression>>(0);
            public ROptional<CElseExpression> ElseExpression => Get<ROptional<CElseExpression>>(1);
        }

        public partial class CCaseExpression : RSequence, ICaseExpression
        {
            public CCaseExpression(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public RString String2 => Get<RString>(1);
            public RString String3 => Get<RString>(2);
            public ICaseItem CaseItem => Get<ICaseItem>(3);
            public RString String4 => Get<RString>(4);
            public IConditionalExpression ConditionalExpression => Get<IConditionalExpression>(5);
        }

        public partial class CIfExpression : RSequence, IIfExpression
        {
            public CIfExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public CThenExpression ThenExpression => Get<CThenExpression>(2);
            public CElseExpression ElseExpression => Get<CElseExpression>(3);
        }

        public partial class CElseExpression : RSequence, IElseExpression
        {
            public CElseExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IConditionalExpression ConditionalExpression => Get<IConditionalExpression>(1);
        }

        public partial class CThenExpression : RSequence, IThenExpression
        {
            public CThenExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IConditionalExpression ConditionalExpression => Get<IConditionalExpression>(1);
        }

        public partial class CFunctionExpression : RSequence, IFunctionExpression
        {
            public CFunctionExpression(params RNode[] children) : base(children) {}

            public ROptional<IFunctionExpressionType> FunctionExpressionType => Get<ROptional<IFunctionExpressionType>>(0);
            public ROptional<CTypeParameters> TypeParameters => Get<ROptional<CTypeParameters>>(1);
            public ROptional<CFunctionParameters> FunctionParameters => Get<ROptional<CFunctionParameters>>(2);
            public IFunctionDefinition FunctionDefinition => Get<IFunctionDefinition>(3);
        }

        public partial class CFunctionExpressionType : RString, IFunctionExpressionType
        {
            public CFunctionExpressionType(params Node[] children) : base(children) {}
        }

        public partial class CFunctionParameters : RSequence, IFunctionParameters
        {
            public CFunctionParameters(params RNode[] children) : base(children) {}

            public RPlus<CParameters> Parameters => Get<RPlus<CParameters>>(0);
            public ROptional<CTypeConstraints> TypeConstraints => Get<ROptional<CTypeConstraints>>(1);
        }

        public partial class CForComprehensionClause : RSequence, IForComprehensionClause
        {
            public CForComprehensionClause(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public ROptional<CForIterator> ForIterator => Get<ROptional<CForIterator>>(2);
            public RString String3 => Get<RString>(3);
            public IComprehensionClause ComprehensionClause => Get<IComprehensionClause>(4);
        }

        public partial class CIfComprehensionClause : RSequence, IIfComprehensionClause
        {
            public CIfComprehensionClause(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public IComprehensionClause ComprehensionClause => Get<IComprehensionClause>(2);
        }

        public partial class CAssignment : RSequence, IAssignment
        {
            public CAssignment(params RNode[] children) : base(children) {}

            public IThenElseExpression ThenElseExpression => Get<IThenElseExpression>(0);
            public CAssignmentOperator AssignmentOperator => Get<CAssignmentOperator>(1);
            public IExpression Expression => Get<IExpression>(2);
        }

        public partial class CAssignmentOperator : RString, IAssignmentOperator
        {
            public CAssignmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CThenElse : RSequence, IThenElse
        {
            public CThenElse(params RNode[] children) : base(children) {}

            public IThenElseExpression ThenElseExpression => Get<IThenElseExpression>(0);
            public CThenElseOperator ThenElseOperator => Get<CThenElseOperator>(1);
            public IDisjunctionExpression DisjunctionExpression => Get<IDisjunctionExpression>(2);
        }

        public partial class CThenElseOperator : RString, IThenElseOperator
        {
            public CThenElseOperator(params Node[] children) : base(children) {}
        }

        public partial class CDisjunction : RSequence, IDisjunction
        {
            public CDisjunction(params RNode[] children) : base(children) {}

            public IDisjunctionExpression DisjunctionExpression => Get<IDisjunctionExpression>(0);
            public CDisjunctionOperator DisjunctionOperator => Get<CDisjunctionOperator>(1);
            public IConjunctionExpression ConjunctionExpression => Get<IConjunctionExpression>(2);
        }

        public partial class CDisjunctionOperator : RString, IDisjunctionOperator
        {
            public CDisjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CConjunction : RSequence, IConjunction
        {
            public CConjunction(params RNode[] children) : base(children) {}

            public IConjunctionExpression ConjunctionExpression => Get<IConjunctionExpression>(0);
            public CConjunctionOperator ConjunctionOperator => Get<CConjunctionOperator>(1);
            public ILogicalNegationExpression LogicalNegationExpression => Get<ILogicalNegationExpression>(2);
        }

        public partial class CConjunctionOperator : RString, IConjunctionOperator
        {
            public CConjunctionOperator(params Node[] children) : base(children) {}
        }

        public partial class CLogicalNegation : RSequence, ILogicalNegation
        {
            public CLogicalNegation(params RNode[] children) : base(children) {}

            public CNotOperator NotOperator => Get<CNotOperator>(0);
            public ILogicalNegationExpression LogicalNegationExpression => Get<ILogicalNegationExpression>(1);
        }

        public partial class CNotOperator : RString, INotOperator
        {
            public CNotOperator(params Node[] children) : base(children) {}
        }

        public partial class CEquality : RSequence, IEquality
        {
            public CEquality(params RNode[] children) : base(children) {}

            public IComparisonExpression ComparisonExpression => Get<IComparisonExpression>(0);
            public CEqualityOperator EqualityOperator => Get<CEqualityOperator>(1);
            public IComparisonExpression ComparisonExpression2 => Get<IComparisonExpression>(2);
        }

        public partial class CEqualityOperator : RString, IEqualityOperator
        {
            public CEqualityOperator(params Node[] children) : base(children) {}
        }

        public partial class CComparisonExpr : RSequence, IComparisonExpr
        {
            public CComparisonExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CComparisonOperator ComparisonOperator => Get<CComparisonOperator>(1);
            public IExistsNonemptyExpression ExistsNonemptyExpression2 => Get<IExistsNonemptyExpression>(2);
        }

        public partial class CLargerExpr : RSequence, ILargerExpr
        {
            public CLargerExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public IExistsNonemptyExpression ExistsNonemptyExpression2 => Get<IExistsNonemptyExpression>(2);
        }

        public partial class CSmallerExpr : RSequence, ISmallerExpr
        {
            public CSmallerExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public IExistsNonemptyExpression ExistsNonemptyExpression2 => Get<IExistsNonemptyExpression>(2);
        }

        public partial class CLargerBoundsExpr : RSequence, ILargerBoundsExpr
        {
            public CLargerBoundsExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CLargerOperator LargerOperator => Get<CLargerOperator>(1);
            public IExistsNonemptyExpression ExistsNonemptyExpression2 => Get<IExistsNonemptyExpression>(2);
            public CLargerOperator LargerOperator2 => Get<CLargerOperator>(3);
            public IExistsNonemptyExpression ExistsNonemptyExpression3 => Get<IExistsNonemptyExpression>(4);
        }

        public partial class CSmallerBoundsExpr : RSequence, ISmallerBoundsExpr
        {
            public CSmallerBoundsExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CSmallerOperator SmallerOperator => Get<CSmallerOperator>(1);
            public IExistsNonemptyExpression ExistsNonemptyExpression2 => Get<IExistsNonemptyExpression>(2);
            public CSmallerOperator SmallerOperator2 => Get<CSmallerOperator>(3);
            public IExistsNonemptyExpression ExistsNonemptyExpression3 => Get<IExistsNonemptyExpression>(4);
        }

        public partial class CTypecheckExpr : RSequence, ITypecheckExpr
        {
            public CTypecheckExpr(params RNode[] children) : base(children) {}

            public IExistsNonemptyExpression ExistsNonemptyExpression => Get<IExistsNonemptyExpression>(0);
            public CTypeOperator TypeOperator => Get<CTypeOperator>(1);
            public IType Type => Get<IType>(2);
        }

        public partial class CComparisonOperator : RString, IComparisonOperator
        {
            public CComparisonOperator(params Node[] children) : base(children) {}
        }

        public partial class CSmallerOperator : RString, ISmallerOperator
        {
            public CSmallerOperator(params Node[] children) : base(children) {}
        }

        public partial class CLargerOperator : RString, ILargerOperator
        {
            public CLargerOperator(params Node[] children) : base(children) {}
        }

        public partial class CTypeOperator : RString, ITypeOperator
        {
            public CTypeOperator(params Node[] children) : base(children) {}
        }

        public partial class CExistsExpression : RSequence, IExistsExpression
        {
            public CExistsExpression(params RNode[] children) : base(children) {}

            public IEntryRangeExpression EntryRangeExpression => Get<IEntryRangeExpression>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CNonemptyExpression : RSequence, INonemptyExpression
        {
            public CNonemptyExpression(params RNode[] children) : base(children) {}

            public IEntryRangeExpression EntryRangeExpression => Get<IEntryRangeExpression>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CEntryOrRange : RSequence, IEntryOrRange
        {
            public CEntryOrRange(params RNode[] children) : base(children) {}

            public IAdditiveExpression AdditiveExpression => Get<IAdditiveExpression>(0);
            public CRangeOrEntryOperator RangeOrEntryOperator => Get<CRangeOrEntryOperator>(1);
            public IAdditiveExpression AdditiveExpression2 => Get<IAdditiveExpression>(2);
        }

        public partial class CRangeOrEntryOperator : RString, IRangeOrEntryOperator
        {
            public CRangeOrEntryOperator(params Node[] children) : base(children) {}
        }

        public partial class CAdditiveExpr : RSequence, IAdditiveExpr
        {
            public CAdditiveExpr(params RNode[] children) : base(children) {}

            public IAdditiveExpression AdditiveExpression => Get<IAdditiveExpression>(0);
            public CAdditiveOperator AdditiveOperator => Get<CAdditiveOperator>(1);
            public IScaleExpression ScaleExpression => Get<IScaleExpression>(2);
        }

        public partial class CAdditiveOperator : RString, IAdditiveOperator
        {
            public CAdditiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CScaleExpr : RSequence, IScaleExpr
        {
            public CScaleExpr(params RNode[] children) : base(children) {}

            public IMultiplicativeExpression MultiplicativeExpression => Get<IMultiplicativeExpression>(0);
            public CScaleOperator ScaleOperator => Get<CScaleOperator>(1);
            public IScaleExpression ScaleExpression => Get<IScaleExpression>(2);
        }

        public partial class CScaleOperator : RString, IScaleOperator
        {
            public CScaleOperator(params Node[] children) : base(children) {}
        }

        public partial class CMultiplicativeExpr : RSequence, IMultiplicativeExpr
        {
            public CMultiplicativeExpr(params RNode[] children) : base(children) {}

            public IMultiplicativeExpression MultiplicativeExpression => Get<IMultiplicativeExpression>(0);
            public CMultiplicativeOperator MultiplicativeOperator => Get<CMultiplicativeOperator>(1);
            public IUnionExpression UnionExpression => Get<IUnionExpression>(2);
        }

        public partial class CMultiplicativeOperator : RString, IMultiplicativeOperator
        {
            public CMultiplicativeOperator(params Node[] children) : base(children) {}
        }

        public partial class CUnionExpr : RSequence, IUnionExpr
        {
            public CUnionExpr(params RNode[] children) : base(children) {}

            public IUnionExpression UnionExpression => Get<IUnionExpression>(0);
            public CUnionOperator UnionOperator => Get<CUnionOperator>(1);
            public IExclusiveExpression ExclusiveExpression => Get<IExclusiveExpression>(2);
        }

        public partial class CUnionOperator : RString, IUnionOperator
        {
            public CUnionOperator(params Node[] children) : base(children) {}
        }

        public partial class CExclusiveExpr : RSequence, IExclusiveExpr
        {
            public CExclusiveExpr(params RNode[] children) : base(children) {}

            public IExclusiveExpression ExclusiveExpression => Get<IExclusiveExpression>(0);
            public CExclusiveOperator ExclusiveOperator => Get<CExclusiveOperator>(1);
            public IIntersectionExpression IntersectionExpression => Get<IIntersectionExpression>(2);
        }

        public partial class CExclusiveOperator : RString, IExclusiveOperator
        {
            public CExclusiveOperator(params Node[] children) : base(children) {}
        }

        public partial class CIntersectionExpr : RSequence, IIntersectionExpr
        {
            public CIntersectionExpr(params RNode[] children) : base(children) {}

            public IIntersectionExpression IntersectionExpression => Get<IIntersectionExpression>(0);
            public CIntersectionOperator IntersectionOperator => Get<CIntersectionOperator>(1);
            public INegationOrComplementExpression NegationOrComplementExpression => Get<INegationOrComplementExpression>(2);
        }

        public partial class CIntersectionOperator : RString, IIntersectionOperator
        {
            public CIntersectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CNegationOrComplementExpr : RSequence, INegationOrComplementExpr
        {
            public CNegationOrComplementExpr(params RNode[] children) : base(children) {}

            public IUnaryMinusOrComplementOperator UnaryMinusOrComplementOperator => Get<IUnaryMinusOrComplementOperator>(0);
            public INegationOrComplementExpression NegationOrComplementExpression => Get<INegationOrComplementExpression>(1);
        }

        public partial class COpNegate : RSequence, IOpNegate
        {
            public COpNegate(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RNot<RString> String2 => Get<RNot<RString>>(1);
        }

        public partial class COpNeutral : RSequence, IOpNeutral
        {
            public COpNeutral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RNot<RString> String2 => Get<RNot<RString>>(1);
        }

        public partial class COpComplement : RString, IOpComplement
        {
            public COpComplement(params Node[] children) : base(children) {}
        }

        public partial class CPrefixExpr : RSequence, IPrefixExpr
        {
            public CPrefixExpr(params RNode[] children) : base(children) {}

            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(0);
            public IPrefixExpression PrefixExpression => Get<IPrefixExpression>(1);
        }

        public partial class CPostfixExpr : RSequence, IPostfixExpr
        {
            public CPostfixExpr(params RNode[] children) : base(children) {}

            public IPostfixExpression PostfixExpression => Get<IPostfixExpression>(0);
            public CIncrementOperator IncrementOperator => Get<CIncrementOperator>(1);
        }

        public partial class CIncrementOperator : RString, IIncrementOperator
        {
            public CIncrementOperator(params Node[] children) : base(children) {}
        }

        public partial class CSelectionExpression : RSequence, ISelectionExpression
        {
            public CSelectionExpression(params RNode[] children) : base(children) {}

            public IPrimary Primary => Get<IPrimary>(0);
            public CQualifiedReference QualifiedReference => Get<CQualifiedReference>(1);
        }

        public partial class CQualifiedReference : RSequence, IQualifiedReference
        {
            public CQualifiedReference(params RNode[] children) : base(children) {}

            public CMemberSelectionOperator MemberSelectionOperator => Get<CMemberSelectionOperator>(0);
            public IBaseReference BaseReference => Get<IBaseReference>(1);
        }

        public partial class CMemberSelectionOperator : RString, IMemberSelectionOperator
        {
            public CMemberSelectionOperator(params Node[] children) : base(children) {}
        }

        public partial class CIndexedExpression : RSequence, IIndexedExpression
        {
            public CIndexedExpression(params RNode[] children) : base(children) {}

            public IPrimary Primary => Get<IPrimary>(0);
            public RString String => Get<RString>(1);
            public IIndex Index => Get<IIndex>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CUpperSpanned : RSequence, IUpperSpanned
        {
            public CUpperSpanned(params RNode[] children) : base(children) {}

            public IIndexExpression IndexExpression => Get<IIndexExpression>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CLowerSpanned : RSequence, ILowerSpanned
        {
            public CLowerSpanned(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IIndexExpression IndexExpression => Get<IIndexExpression>(1);
        }

        public partial class CSpanned : RSequence, ISpanned
        {
            public CSpanned(params RNode[] children) : base(children) {}

            public IIndexExpression IndexExpression => Get<IIndexExpression>(0);
            public RString String => Get<RString>(1);
            public IIndexExpression IndexExpression2 => Get<IIndexExpression>(2);
        }

        public partial class CMeasured : RSequence, IMeasured
        {
            public CMeasured(params RNode[] children) : base(children) {}

            public IIndexExpression IndexExpression => Get<IIndexExpression>(0);
            public RString String => Get<RString>(1);
            public IIndexExpression IndexExpression2 => Get<IIndexExpression>(2);
        }

        public partial class CCallExpression : RSequence, ICallExpression
        {
            public CCallExpression(params RNode[] children) : base(children) {}

            public IPrimary Primary => Get<IPrimary>(0);
            public IArguments Arguments => Get<IArguments>(1);
        }

        public partial class CStringInterpolation : RSequence, IStringInterpolation
        {
            public CStringInterpolation(params RNode[] children) : base(children) {}

            public CStringStart StringStart => Get<CStringStart>(0);
            public IExpression Expression => Get<IExpression>(1);
            public RStar<CInterpolationPart> InterpolationPart => Get<RStar<CInterpolationPart>>(2);
            public CStringEnd StringEnd => Get<CStringEnd>(3);
        }

        public partial class CInterpolationPart : RSequence, IInterpolationPart
        {
            public CInterpolationPart(params RNode[] children) : base(children) {}

            public CStringMid StringMid => Get<CStringMid>(0);
            public IExpression Expression => Get<IExpression>(1);
        }

        public partial class CObjectExpression : RSequence, IObjectExpression
        {
            public CObjectExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CExtendedType> ExtendedType => Get<ROptional<CExtendedType>>(1);
            public ROptional<CSatisfiedTypes> SatisfiedTypes => Get<ROptional<CSatisfiedTypes>>(2);
            public IClassBlock ClassBlock => Get<IClassBlock>(3);
        }

        public partial class CGroupedExpression : RSequence, IGroupedExpression
        {
            public CGroupedExpression(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IExpression Expression => Get<IExpression>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CTypeArguments : RSequence, ITypeArguments
        {
            public CTypeArguments(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CTypeArgumentList> TypeArgumentList => Get<ROptional<CTypeArgumentList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CTypeArgumentList : RLoop<CVariancedType>, ITypeArgumentList
        {
            public CTypeArgumentList(params RNode[] children) : base(children) {}
        }

        public partial class CVariancedType : RSequence, IVariancedType
        {
            public CVariancedType(params RNode[] children) : base(children) {}

            public ROptional<IVariance> Variance => Get<ROptional<IVariance>>(0);
            public IType Type => Get<IType>(1);
        }

        public partial class CDefaultedTypeList : RLoop<IDefaultedType>, IDefaultedTypeList
        {
            public CDefaultedTypeList(params RNode[] children) : base(children) {}
        }

        public partial class CDefaultedTypeCore : RSequence, IDefaultedTypeCore
        {
            public CDefaultedTypeCore(params RNode[] children) : base(children) {}

            public IType Type => Get<IType>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CVariadicUnionType : RSequence, IVariadicUnionType
        {
            public CVariadicUnionType(params RNode[] children) : base(children) {}

            public IUnionType UnionType => Get<IUnionType>(0);
            public CVariadicOperator VariadicOperator => Get<CVariadicOperator>(1);
        }

        public partial class CVariadicOperator : RString, IVariadicOperator
        {
            public CVariadicOperator(params Node[] children) : base(children) {}
        }

        public partial class CSpreadType : RSequence, ISpreadType
        {
            public CSpreadType(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IUnionType UnionType => Get<IUnionType>(1);
        }

        public partial class CEntryType : RSequence, IEntryType
        {
            public CEntryType(params RNode[] children) : base(children) {}

            public IUnionType UnionType => Get<IUnionType>(0);
            public RString String => Get<RString>(1);
            public IUnionType UnionType2 => Get<IUnionType>(2);
        }

        public partial class CUnionTypeCore : RSequence, IUnionTypeCore
        {
            public CUnionTypeCore(params RNode[] children) : base(children) {}

            public IUnionType UnionType => Get<IUnionType>(0);
            public RString String => Get<RString>(1);
            public IIntersectionType IntersectionType => Get<IIntersectionType>(2);
        }

        public partial class CIntersectionTypeCore : RSequence, IIntersectionTypeCore
        {
            public CIntersectionTypeCore(params RNode[] children) : base(children) {}

            public IIntersectionType IntersectionType => Get<IIntersectionType>(0);
            public RString String => Get<RString>(1);
            public IPrimaryType PrimaryType => Get<IPrimaryType>(2);
        }

        public partial class CNullableType : RSequence, INullableType
        {
            public CNullableType(params RNode[] children) : base(children) {}

            public IPrimaryType PrimaryType => Get<IPrimaryType>(0);
            public RString String => Get<RString>(1);
        }

        public partial class CArrayType : RSequence, IArrayType
        {
            public CArrayType(params RNode[] children) : base(children) {}

            public IPrimaryType PrimaryType => Get<IPrimaryType>(0);
            public RString String => Get<RString>(1);
            public ROptional<CLiteralNatural> LiteralNatural => Get<ROptional<CLiteralNatural>>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CFunctionType : RSequence, IFunctionType
        {
            public CFunctionType(params RNode[] children) : base(children) {}

            public IPrimaryType PrimaryType => Get<IPrimaryType>(0);
            public RString String => Get<RString>(1);
            public ROptional<ITypeTypeArguments> TypeTypeArguments => Get<ROptional<ITypeTypeArguments>>(2);
            public RString String2 => Get<RString>(3);
        }

        public partial class CTupleType : RSequence, ITupleType
        {
            public CTupleType(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<ITypeTypeArguments> TypeTypeArguments => Get<ROptional<ITypeTypeArguments>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CIterableType : RSequence, IIterableType
        {
            public CIterableType(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<IVariadicType> VariadicType => Get<ROptional<IVariadicType>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CGroupedType : RSequence, IGroupedType
        {
            public CGroupedType(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IType Type => Get<IType>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CQualifiedType : RSequence, IQualifiedType
        {
            public CQualifiedType(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifier => Get<ROptional<CPackageQualifier>>(0);
            public CTypePath TypePath => Get<CTypePath>(1);
        }

        public partial class CAnnotations : RSequence, IAnnotations
        {
            public CAnnotations(params RNode[] children) : base(children) {}

            public ROptional<IStringLiteral> StringLiteral => Get<ROptional<IStringLiteral>>(0);
            public RStar<CAnnotation> Annotation => Get<RStar<CAnnotation>>(1);
        }

        public partial class CAnnotation : RSequence, IAnnotation
        {
            public CAnnotation(params RNode[] children) : base(children) {}

            public IAnnotationName AnnotationName => Get<IAnnotationName>(0);
            public ROptional<IArguments> Arguments => Get<ROptional<IArguments>>(1);
        }

        public partial class CConditions : RSequence, IConditions
        {
            public CConditions(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CConditionList> ConditionList => Get<ROptional<CConditionList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CConditionList : RLoop<ICondition>, IConditionList
        {
            public CConditionList(params RNode[] children) : base(children) {}
        }

        public partial class CExistsCondition : RSequence, IExistsCondition
        {
            public CExistsCondition(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public RString String2 => Get<RString>(1);
            public ILetOrExpression LetOrExpression => Get<ILetOrExpression>(2);
        }

        public partial class CNonemptyCondition : RSequence, INonemptyCondition
        {
            public CNonemptyCondition(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public RString String2 => Get<RString>(1);
            public ILetOrExpression LetOrExpression => Get<ILetOrExpression>(2);
        }

        public partial class CIsCondition : RSequence, IIsCondition
        {
            public CIsCondition(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public RString String2 => Get<RString>(1);
            public IType Type => Get<IType>(2);
            public CIsConditionVariable IsConditionVariable => Get<CIsConditionVariable>(3);
        }

        public partial class CIsConditionVariable : RSequence, IIsConditionVariable
        {
            public CIsConditionVariable(params RNode[] children) : base(children) {}

            public IMemberName MemberName => Get<IMemberName>(0);
            public ROptional<CValueSpecifier> ValueSpecifier => Get<ROptional<CValueSpecifier>>(1);
        }

        public partial class CSatisfiesCondition : RSequence, ISatisfiesCondition
        {
            public CSatisfiesCondition(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IType Type => Get<IType>(1);
            public ITypeName TypeName => Get<ITypeName>(2);
        }

        public partial class CIfElseStatement : RSequence, IIfElseStatement
        {
            public CIfElseStatement(params RNode[] children) : base(children) {}

            public CIfBlock IfBlock => Get<CIfBlock>(0);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(1);
        }

        public partial class CIfBlock : RSequence, IIfBlock
        {
            public CIfBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public IBlock Block => Get<IBlock>(2);
        }

        public partial class CElseBlock : RSequence, IElseBlock
        {
            public CElseBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IElseBlockNext ElseBlockNext => Get<IElseBlockNext>(1);
        }

        public partial class CSwitchCaseElse : RSequence, ISwitchCaseElse
        {
            public CSwitchCaseElse(params RNode[] children) : base(children) {}

            public CSwitchHeader SwitchHeader => Get<CSwitchHeader>(0);
            public RPlus<CCaseBlock> CaseBlock => Get<RPlus<CCaseBlock>>(1);
            public ROptional<CElseBlock> ElseBlock => Get<ROptional<CElseBlock>>(2);
        }

        public partial class CSwitchHeader : RSequence, ISwitchHeader
        {
            public CSwitchHeader(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public ISwitched Switched => Get<ISwitched>(2);
            public RString String3 => Get<RString>(3);
        }

        public partial class CCaseBlock : RSequence, ICaseBlock
        {
            public CCaseBlock(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public RString String2 => Get<RString>(1);
            public RString String3 => Get<RString>(2);
            public ICaseItem CaseItem => Get<ICaseItem>(3);
            public RString String4 => Get<RString>(4);
            public IBlock Block => Get<IBlock>(5);
        }

        public partial class CIsCaseCondition : RSequence, IIsCaseCondition
        {
            public CIsCaseCondition(params RNode[] children) : base(children) {}

            public ROptional<RString> String => Get<ROptional<RString>>(0);
            public IType Type => Get<IType>(1);
        }

        public partial class CSatisfiesCaseCondition : RSequence, ISatisfiesCaseCondition
        {
            public CSatisfiesCaseCondition(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IType Type => Get<IType>(1);
        }

        public partial class CValueCaseList : RLoop<IValueCase>, IValueCaseList
        {
            public CValueCaseList(params RNode[] children) : base(children) {}
        }

        public partial class CValueCaseSeparator : RString, IValueCaseSeparator
        {
            public CValueCaseSeparator(params Node[] children) : base(children) {}
        }

        public partial class CForElseStatement : RSequence, IForElseStatement
        {
            public CForElseStatement(params RNode[] children) : base(children) {}

            public CForBlock ForBlock => Get<CForBlock>(0);
            public ROptional<CFailBlock> FailBlock => Get<ROptional<CFailBlock>>(1);
        }

        public partial class CForBlock : RSequence, IForBlock
        {
            public CForBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public RString String2 => Get<RString>(1);
            public ROptional<CForIterator> ForIterator => Get<ROptional<CForIterator>>(2);
            public RString String3 => Get<RString>(3);
            public IBlock Block => Get<IBlock>(4);
        }

        public partial class CFailBlock : RSequence, IFailBlock
        {
            public CFailBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IBlock Block => Get<IBlock>(1);
        }

        public partial class CForIterator : RSequence, IForIterator
        {
            public CForIterator(params RNode[] children) : base(children) {}

            public IForVariable ForVariable => Get<IForVariable>(0);
            public ROptional<CContainment> Containment => Get<ROptional<CContainment>>(1);
        }

        public partial class CContainment : RSequence, IContainment
        {
            public CContainment(params RNode[] children) : base(children) {}

            public CContainmentOperator ContainmentOperator => Get<CContainmentOperator>(0);
            public IOperatorExpression OperatorExpression => Get<IOperatorExpression>(1);
        }

        public partial class CContainmentOperator : RString, IContainmentOperator
        {
            public CContainmentOperator(params Node[] children) : base(children) {}
        }

        public partial class CWhileBlock : RSequence, IWhileBlock
        {
            public CWhileBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CConditions Conditions => Get<CConditions>(1);
            public IBlock Block => Get<IBlock>(2);
        }

        public partial class CTryCatchFinally : RSequence, ITryCatchFinally
        {
            public CTryCatchFinally(params RNode[] children) : base(children) {}

            public CTryBlock TryBlock => Get<CTryBlock>(0);
            public RStar<CCatchBlock> CatchBlock => Get<RStar<CCatchBlock>>(1);
            public ROptional<CFinallyBlock> FinallyBlock => Get<ROptional<CFinallyBlock>>(2);
        }

        public partial class CTryBlock : RSequence, ITryBlock
        {
            public CTryBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CResources> Resources => Get<ROptional<CResources>>(1);
            public IBlock Block => Get<IBlock>(2);
        }

        public partial class CCatchBlock : RSequence, ICatchBlock
        {
            public CCatchBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CCatchVariable CatchVariable => Get<CCatchVariable>(1);
            public IBlock Block => Get<IBlock>(2);
        }

        public partial class CCatchVariable : RSequence, ICatchVariable
        {
            public CCatchVariable(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CVariable> Variable => Get<ROptional<CVariable>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CFinallyBlock : RSequence, IFinallyBlock
        {
            public CFinallyBlock(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IBlock Block => Get<IBlock>(1);
        }

        public partial class CResources : RSequence, IResources
        {
            public CResources(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CResourceList> ResourceList => Get<ROptional<CResourceList>>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CResourceList : RLoop<IResource>, IResourceList
        {
            public CResourceList(params RNode[] children) : base(children) {}
        }

        public partial class CSpecifiedVariable : RSequence, ISpecifiedVariable
        {
            public CSpecifiedVariable(params RNode[] children) : base(children) {}

            public CVariable Variable => Get<CVariable>(0);
            public CValueSpecifier ValueSpecifier => Get<CValueSpecifier>(1);
        }

        public partial class CVariable : RSequence, IVariable
        {
            public CVariable(params RNode[] children) : base(children) {}

            public ROptional<IVariableType> VariableType => Get<ROptional<IVariableType>>(0);
            public IMemberName MemberName => Get<IMemberName>(1);
            public RStar<CParameters> Parameters => Get<RStar<CParameters>>(2);
        }

        public partial class CModelReference : RSequence, IModelReference
        {
            public CModelReference(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IModelExpression ModelExpression => Get<IModelExpression>(1);
        }

        public partial class CMetaLiteral : RSequence, IMetaLiteral
        {
            public CMetaLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public IMetaExpression MetaExpression => Get<IMetaExpression>(1);
            public RString String2 => Get<RString>(2);
        }

        public partial class CPackageQualifiedMemberReference : RSequence, IPackageQualifiedMemberReference
        {
            public CPackageQualifiedMemberReference(params RNode[] children) : base(children) {}

            public CPackageQualifier PackageQualifier => Get<CPackageQualifier>(0);
            public CMemberReference MemberReference => Get<CMemberReference>(1);
        }

        public partial class CTypeQualifiedMemberReference : RSequence, ITypeQualifiedMemberReference
        {
            public CTypeQualifiedMemberReference(params RNode[] children) : base(children) {}

            public IPrimaryType PrimaryType => Get<IPrimaryType>(0);
            public RString String => Get<RString>(1);
            public CMemberReference MemberReference => Get<CMemberReference>(2);
        }

        public partial class CModuleLiteral : RSequence, IModuleLiteral
        {
            public CModuleLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CPackagePath> PackagePath => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CPackageLiteral : RSequence, IPackageLiteral
        {
            public CPackageLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public ROptional<CPackagePath> PackagePath => Get<ROptional<CPackagePath>>(1);
        }

        public partial class CClassLiteral : RSequence, IClassLiteral
        {
            public CClassLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CInterfaceLiteral : RSequence, IInterfaceLiteral
        {
            public CInterfaceLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CAliasLiteral : RSequence, IAliasLiteral
        {
            public CAliasLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CTypeParameterLiteral : RSequence, ITypeParameterLiteral
        {
            public CTypeParameterLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CNewLiteral : RSequence, INewLiteral
        {
            public CNewLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteral : RSequence, IValueLiteral
        {
            public CValueLiteral(params RNode[] children) : base(children) {}

            public CValueLiteralIntro ValueLiteralIntro => Get<CValueLiteralIntro>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CValueLiteralIntro : RString, IValueLiteralIntro
        {
            public CValueLiteralIntro(params Node[] children) : base(children) {}
        }

        public partial class CFunctionLiteral : RSequence, IFunctionLiteral
        {
            public CFunctionLiteral(params RNode[] children) : base(children) {}

            public RString String => Get<RString>(0);
            public CReferencePath ReferencePath => Get<CReferencePath>(1);
        }

        public partial class CReferencePath : RSequence, IReferencePath
        {
            public CReferencePath(params RNode[] children) : base(children) {}

            public ROptional<CPackageQualifier> PackageQualifier => Get<ROptional<CPackageQualifier>>(0);
            public CReferencePathElementList ReferencePathElementList => Get<CReferencePathElementList>(1);
        }

        public partial class CReferencePathElementList : RLoop<IReferencePathElement>, IReferencePathElementList
        {
            public CReferencePathElementList(params RNode[] children) : base(children) {}
        }

        public partial class CKwVoid : RString, IKwVoid
        {
            public CKwVoid(params Node[] children) : base(children) {}
        }

        public partial class CKwFunction : RString, IKwFunction
        {
            public CKwFunction(params Node[] children) : base(children) {}
        }

        public partial class CKwValue : RString, IKwValue
        {
            public CKwValue(params Node[] children) : base(children) {}
        }

        public partial class CLiteralFloat : RString, ILiteralFloat
        {
            public CLiteralFloat(params Node[] children) : base(children) {}
        }

        public partial class CLiteralNatural : RString, ILiteralNatural
        {
            public CLiteralNatural(params Node[] children) : base(children) {}
        }

        public partial class CLiteralChar : RString, ILiteralChar
        {
            public CLiteralChar(params Node[] children) : base(children) {}
        }

        public partial class CStringStart : RString, IStringStart
        {
            public CStringStart(params Node[] children) : base(children) {}
        }

        public partial class CStringMid : RString, IStringMid
        {
            public CStringMid(params Node[] children) : base(children) {}
        }

        public partial class CStringEnd : RString, IStringEnd
        {
            public CStringEnd(params Node[] children) : base(children) {}
        }

        public partial class CLiteralString : RString, ILiteralString
        {
            public CLiteralString(params Node[] children) : base(children) {}
        }

        public partial class CVerbatimString : RString, IVerbatimString
        {
            public CVerbatimString(params Node[] children) : base(children) {}
        }

        public partial class CLowerIdentifier : RString, ILowerIdentifier
        {
            public CLowerIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CUpperIdentifier : RString, IUpperIdentifier
        {
            public CUpperIdentifier(params Node[] children) : base(children) {}
        }

        public partial class CIdentifier : RString, IIdentifier
        {
            public CIdentifier(params Node[] children) : base(children) {}
        }

        public partial class DynamicCeylonVisitor : DynamicVisitor
        {
            public override void Walk(RNode node)
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

            protected virtual void Visit(CReturnDirective element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThrowDirective element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBreakDirective element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CContinueDirective element)
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

            protected virtual void Visit(CEnumeration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTuple element)
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

            protected virtual void Visit(CLetExpression element)
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

            protected virtual void Visit(CSwitchExpression element)
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

            protected virtual void Visit(CIfExpression element)
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

            protected virtual void Visit(CFunctionExpression element)
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

            protected virtual void Visit(CAssignment element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CAssignmentOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThenElse element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CThenElseOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDisjunction element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CDisjunctionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConjunction element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CConjunctionOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CLogicalNegation element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNotOperator element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEquality element)
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

            protected virtual void Visit(CExistsExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNonemptyExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CEntryOrRange element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CRangeOrEntryOperator element)
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

            protected virtual void Visit(COpNegate element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COpNeutral element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(COpComplement element)
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

            protected virtual void Visit(CSelectionExpression element)
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

            protected virtual void Visit(CIndexedExpression element)
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

            protected virtual void Visit(CCallExpression element)
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

            protected virtual void Visit(CObjectExpression element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CGroupedExpression element)
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

            protected virtual void Visit(CSwitchCaseElse element)
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

            protected virtual void Visit(CWhileBlock element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CTryCatchFinally element)
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
