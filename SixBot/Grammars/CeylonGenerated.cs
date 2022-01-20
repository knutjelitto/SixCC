// <generated from="D:\\Six\\SixBot\\Grammars\\Ceylon.six" at="20.01.2022 17:29:18" />

using System.Collections.Generic;
using Six.Runtime;
using Six.Runtime.Dfa;
using Six.Runtime.Matchers;
using Six.Runtime.Sppf;
using Six.Runtime.Types;
using Range = Six.Runtime.Matchers.Range;
using String = Six.Runtime.Matchers.String;
using static GeneratedParser.CeylonTree;

namespace GeneratedParser
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
                : base(new Matcher[870])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _unitElements = new PlainRule(this, 4, "unit-elements") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _unitElement = new PlainRule(this, 5, "unit-element") { Builder = nodes => nodes[0] };
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
                /*  24 PlainRuleOp      */ __Matchers[24] = _importNameSpecifier = new PlainRule(this, 24, "import-name-specifier") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _importWildcard = new PlainRule(this, 25, "import-wildcard") { Creator = node => new CImportWildcard(node) };
                /*  26 PlainRuleOp      */ __Matchers[26] = _importName = new PlainRule(this, 26, "import-name") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _packagePath = new PlainRule(this, 27, "package-path") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _anyName = new PlainRule(this, 28, "any-name") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _packageName = new PlainRule(this, 29, "package-name") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _annotationName = new PlainRule(this, 30, "annotation-name") { Builder = nodes => nodes[0] };
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
                /*  43 PlainRuleOp      */ __Matchers[43] = _delegatedConstructor = new PlainRule(this, 43, "delegated-constructor") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _assertionStatement = new PlainRule(this, 44, "assertion-statement") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _assertionMessage = new PlainRule(this, 45, "assertion-message") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _block = new PlainRule(this, 46, "block") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _interfaceBlock = new PlainRule(this, 47, "interface-block") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _classBlock = new PlainRule(this, 48, "class-block") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _blockElements = new PlainRule(this, 49, "block-elements") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _blockElement = new PlainRule(this, 50, "block-element") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _extendedType = new PlainRule(this, 51, "extended-type") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _classSpecifier = new PlainRule(this, 52, "class-specifier") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _classInstatiation = new PlainRule(this, 53, "class-instatiation") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _qualifiedClass = new PlainRule(this, 54, "qualified-class") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _superQualifiedClass = new PlainRule(this, 55, "super-qualified-class") { Builder = nodes => nodes[0] };
                /*  56 PlainRuleOp      */ __Matchers[56] = _superQualifier = new PlainRule(this, 56, "super-qualifier") { Builder = nodes => nodes[0] };
                /*  57 PlainRuleOp      */ __Matchers[57] = _packageQualifiedClass = new PlainRule(this, 57, "package-qualified-class") { Builder = nodes => nodes[0] };
                /*  58 PlainRuleOp      */ __Matchers[58] = _packageQualifier = new PlainRule(this, 58, "package-qualifier") { Builder = nodes => nodes[0] };
                /*  59 PlainRuleOp      */ __Matchers[59] = _unQualifiedClass = new PlainRule(this, 59, "un-qualified-class") { Builder = nodes => nodes[0] };
                /*  60 PlainRuleOp      */ __Matchers[60] = _memberPath = new PlainRule(this, 60, "member-path") { Builder = nodes => nodes[0] };
                /*  61 PlainRuleOp      */ __Matchers[61] = _typePath = new PlainRule(this, 61, "type-path") { Builder = nodes => nodes[0] };
                /*  62 PlainRuleOp      */ __Matchers[62] = _satisfiedTypes = new PlainRule(this, 62, "satisfied-types") { Builder = nodes => nodes[0] };
                /*  63 PlainRuleOp      */ __Matchers[63] = _unionTypeList = new PlainRule(this, 63, "union-type-list") { Builder = nodes => nodes[0] };
                /*  64 PlainRuleOp      */ __Matchers[64] = _caseTypes = new PlainRule(this, 64, "case-types") { Builder = nodes => nodes[0] };
                /*  65 PlainRuleOp      */ __Matchers[65] = _caseTypeList = new PlainRule(this, 65, "case-type-list") { Builder = nodes => nodes[0] };
                /*  66 PlainRuleOp      */ __Matchers[66] = _caseType = new PlainRule(this, 66, "case-type") { Builder = nodes => nodes[0] };
                /*  67 PlainRuleOp      */ __Matchers[67] = _qualifiedCaseType = new PlainRule(this, 67, "qualified-case-type") { Builder = nodes => nodes[0] };
                /*  68 PlainRuleOp      */ __Matchers[68] = _parameters = new PlainRule(this, 68, "parameters") { Builder = nodes => nodes[0] };
                /*  69 PlainRuleOp      */ __Matchers[69] = _parameterList = new PlainRule(this, 69, "parameter-list") { Builder = nodes => nodes[0] };
                /*  70 PlainRuleOp      */ __Matchers[70] = _parameterDeclarationOrRefPattern = new PlainRule(this, 70, "parameter-declaration-or-ref-pattern") { Builder = nodes => nodes[0] };
                /*  71 PlainRuleOp      */ __Matchers[71] = _parameterDeclarationOrRef = new PlainRule(this, 71, "parameter-declaration-or-ref") { Builder = nodes => nodes[0] };
                /*  72 PlainRuleOp      */ __Matchers[72] = _parameter = new PlainRule(this, 72, "parameter") { Builder = nodes => nodes[0] };
                /*  73 PlainRuleOp      */ __Matchers[73] = _parameterReference = new PlainRule(this, 73, "parameter-reference") { Builder = nodes => nodes[0] };
                /*  74 PlainRuleOp      */ __Matchers[74] = _parameterDeclaration = new PlainRule(this, 74, "parameter-declaration") { Builder = nodes => nodes[0] };
                /*  75 PlainRuleOp      */ __Matchers[75] = _functionParameterDeclaration = new PlainRule(this, 75, "function-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  76 PlainRuleOp      */ __Matchers[76] = _functionParameterType = new PlainRule(this, 76, "function-parameter-type") { Builder = nodes => nodes[0] };
                /*  77 PlainRuleOp      */ __Matchers[77] = _valueParameterDeclaration = new PlainRule(this, 77, "value-parameter-declaration") { Builder = nodes => nodes[0] };
                /*  78 PlainRuleOp      */ __Matchers[78] = _valueParameterType = new PlainRule(this, 78, "value-parameter-type") { Builder = nodes => nodes[0] };
                /*  79 PlainRuleOp      */ __Matchers[79] = _typeParameters = new PlainRule(this, 79, "type-parameters") { Builder = nodes => nodes[0] };
                /*  80 PlainRuleOp      */ __Matchers[80] = _typeParameterList = new PlainRule(this, 80, "type-parameter-list") { Builder = nodes => nodes[0] };
                /*  81 PlainRuleOp      */ __Matchers[81] = _typeParameter = new PlainRule(this, 81, "type-parameter") { Builder = nodes => nodes[0] };
                /*  82 PlainRuleOp      */ __Matchers[82] = _variance = new PlainRule(this, 82, "variance") { Creator = node => new CVariance(node) };
                /*  83 PlainRuleOp      */ __Matchers[83] = _typeDefault = new PlainRule(this, 83, "type-default") { Builder = nodes => nodes[0] };
                /*  84 PlainRuleOp      */ __Matchers[84] = _typeConstraint = new PlainRule(this, 84, "type-constraint") { Builder = nodes => nodes[0] };
                /*  85 PlainRuleOp      */ __Matchers[85] = _typeConstraints = new PlainRule(this, 85, "type-constraints") { Builder = nodes => nodes[0] };
                /*  86 PlainRuleOp      */ __Matchers[86] = _declarationOrStatement = new PlainRule(this, 86, "declaration-or-statement") { Builder = nodes => nodes[0] };
                /*  87 PlainRuleOp      */ __Matchers[87] = _declaration = new PlainRule(this, 87, "declaration") { Builder = nodes => nodes[0] };
                /*  88 PlainRuleOp      */ __Matchers[88] = _constructor = new PlainRule(this, 88, "constructor") { Builder = nodes => nodes[0] };
                /*  89 PlainRuleOp      */ __Matchers[89] = _enumeratedObject = new PlainRule(this, 89, "enumerated-object") { Builder = nodes => nodes[0] };
                /*  90 PlainRuleOp      */ __Matchers[90] = _aliasDeclaration = new PlainRule(this, 90, "alias-declaration") { Builder = nodes => nodes[0] };
                /*  91 PlainRuleOp      */ __Matchers[91] = _objectDeclaration = new PlainRule(this, 91, "object-declaration") { Builder = nodes => nodes[0] };
                /*  92 PlainRuleOp      */ __Matchers[92] = _setterDeclaration = new PlainRule(this, 92, "setter-declaration") { Builder = nodes => nodes[0] };
                /*  93 PlainRuleOp      */ __Matchers[93] = _setterDefinition = new PlainRule(this, 93, "setter-definition") { Builder = nodes => nodes[0] };
                /*  94 PlainRuleOp      */ __Matchers[94] = _typedMethodDeclaration = new PlainRule(this, 94, "typed-method-declaration") { Builder = nodes => nodes[0] };
                /*  95 PlainRuleOp      */ __Matchers[95] = _methodType = new PlainRule(this, 95, "method-type") { Builder = nodes => nodes[0] };
                /*  96 PlainRuleOp      */ __Matchers[96] = _inferredMethodDeclaration = new PlainRule(this, 96, "inferred-method-declaration") { Builder = nodes => nodes[0] };
                /*  97 PlainRuleOp      */ __Matchers[97] = _typedAttributeDeclaration = new PlainRule(this, 97, "typed-attribute-declaration") { Builder = nodes => nodes[0] };
                /*  98 PlainRuleOp      */ __Matchers[98] = _attributeType = new PlainRule(this, 98, "attribute-type") { Builder = nodes => nodes[0] };
                /*  99 PlainRuleOp      */ __Matchers[99] = _inferredAttributeDeclaration = new PlainRule(this, 99, "inferred-attribute-declaration") { Builder = nodes => nodes[0] };
                /* 100 PlainRuleOp      */ __Matchers[100] = _attributeDefinition = new PlainRule(this, 100, "attribute-definition") { Builder = nodes => nodes[0] };
                /* 101 PlainRuleOp      */ __Matchers[101] = _optionalAnySpecifier = new PlainRule(this, 101, "optional-any-specifier") { Builder = nodes => nodes[0] };
                /* 102 PlainRuleOp      */ __Matchers[102] = _classDeclaration = new PlainRule(this, 102, "class-declaration") { Builder = nodes => nodes[0] };
                /* 103 PlainRuleOp      */ __Matchers[103] = _classDefinition = new PlainRule(this, 103, "class-definition") { Builder = nodes => nodes[0] };
                /* 104 PlainRuleOp      */ __Matchers[104] = _optionalClassSpecifier = new PlainRule(this, 104, "optional-class-specifier") { Builder = nodes => nodes[0] };
                /* 105 PlainRuleOp      */ __Matchers[105] = _interfaceDeclaration = new PlainRule(this, 105, "interface-declaration") { Builder = nodes => nodes[0] };
                /* 106 PlainRuleOp      */ __Matchers[106] = _interfaceDefinition = new PlainRule(this, 106, "interface-definition") { Builder = nodes => nodes[0] };
                /* 107 PlainRuleOp      */ __Matchers[107] = _optionalTypeSpecifier = new PlainRule(this, 107, "optional-type-specifier") { Builder = nodes => nodes[0] };
                /* 108 PlainRuleOp      */ __Matchers[108] = _statement = new PlainRule(this, 108, "statement") { Builder = nodes => nodes[0] };
                /* 109 PlainRuleOp      */ __Matchers[109] = _unclosedStatement = new PlainRule(this, 109, "unclosed-statement") { Builder = nodes => nodes[0] };
                /* 110 PlainRuleOp      */ __Matchers[110] = _openStatement = new PlainRule(this, 110, "open-statement") { Builder = nodes => nodes[0] };
                /* 111 PlainRuleOp      */ __Matchers[111] = _specificationStatement = new PlainRule(this, 111, "specification-statement") { Builder = nodes => nodes[0] };
                /* 112 PlainRuleOp      */ __Matchers[112] = _expressionStatement = new PlainRule(this, 112, "expression-statement") { Builder = nodes => nodes[0] };
                /* 113 PlainRuleOp      */ __Matchers[113] = _directiveStatement = new PlainRule(this, 113, "directive-statement") { Builder = nodes => nodes[0] };
                /* 114 PlainRuleOp      */ __Matchers[114] = _returnDirective = new PlainRule(this, 114, "return-directive") { Builder = nodes => nodes[0] };
                /* 115 PlainRuleOp      */ __Matchers[115] = _throwDirective = new PlainRule(this, 115, "throw-directive") { Builder = nodes => nodes[0] };
                /* 116 PlainRuleOp      */ __Matchers[116] = _breakDirective = new PlainRule(this, 116, "break-directive") { Creator = node => new CBreakDirective(node) };
                /* 117 PlainRuleOp      */ __Matchers[117] = _continueDirective = new PlainRule(this, 117, "continue-directive") { Creator = node => new CContinueDirective(node) };
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
                /* 130 PlainRuleOp      */ __Matchers[130] = _enumeration = new PlainRule(this, 130, "enumeration") { Builder = nodes => nodes[0] };
                /* 131 PlainRuleOp      */ __Matchers[131] = _tuple = new PlainRule(this, 131, "tuple") { Builder = nodes => nodes[0] };
                /* 132 PlainRuleOp      */ __Matchers[132] = _arguments = new PlainRule(this, 132, "arguments") { Builder = nodes => nodes[0] };
                /* 133 PlainRuleOp      */ __Matchers[133] = _structuralArguments = new PlainRule(this, 133, "structural-arguments") { Builder = nodes => nodes[0] };
                /* 134 PlainRuleOp      */ __Matchers[134] = _namedOrAnonymous = new PlainRule(this, 134, "named-or-anonymous") { Builder = nodes => nodes[0] };
                /* 135 PlainRuleOp      */ __Matchers[135] = _namedArgument = new PlainRule(this, 135, "named-argument") { Builder = nodes => nodes[0] };
                /* 136 PlainRuleOp      */ __Matchers[136] = _namedSpecifiedArgument = new PlainRule(this, 136, "named-specified-argument") { Builder = nodes => nodes[0] };
                /* 137 PlainRuleOp      */ __Matchers[137] = _sequencedArguments = new PlainRule(this, 137, "sequenced-arguments") { Builder = nodes => nodes[0] };
                /* 138 PlainRuleOp      */ __Matchers[138] = _sequencedArgument = new PlainRule(this, 138, "sequenced-argument") { Builder = nodes => nodes[0] };
                /* 139 PlainRuleOp      */ __Matchers[139] = _anonymousArgument = new PlainRule(this, 139, "anonymous-argument") { Builder = nodes => nodes[0] };
                /* 140 PlainRuleOp      */ __Matchers[140] = _namedArgumentDeclaration = new PlainRule(this, 140, "named-argument-declaration") { Builder = nodes => nodes[0] };
                /* 141 PlainRuleOp      */ __Matchers[141] = _objectArgument = new PlainRule(this, 141, "object-argument") { Builder = nodes => nodes[0] };
                /* 142 PlainRuleOp      */ __Matchers[142] = _typedMethodArgument = new PlainRule(this, 142, "typed-method-argument") { Builder = nodes => nodes[0] };
                /* 143 PlainRuleOp      */ __Matchers[143] = _methodDefinition = new PlainRule(this, 143, "method-definition") { Builder = nodes => nodes[0] };
                /* 144 PlainRuleOp      */ __Matchers[144] = _optionalFunctionSpecifier = new PlainRule(this, 144, "optional-function-specifier") { Builder = nodes => nodes[0] };
                /* 145 PlainRuleOp      */ __Matchers[145] = _neededFunctionSpecifier = new PlainRule(this, 145, "needed-function-specifier") { Builder = nodes => nodes[0] };
                /* 146 PlainRuleOp      */ __Matchers[146] = _methodArgumentType = new PlainRule(this, 146, "method-argument-type") { Builder = nodes => nodes[0] };
                /* 147 PlainRuleOp      */ __Matchers[147] = _typedGetterArgument = new PlainRule(this, 147, "typed-getter-argument") { Builder = nodes => nodes[0] };
                /* 148 PlainRuleOp      */ __Matchers[148] = _getterArgumentType = new PlainRule(this, 148, "getter-argument-type") { Builder = nodes => nodes[0] };
                /* 149 PlainRuleOp      */ __Matchers[149] = _inferredMethodArgument = new PlainRule(this, 149, "inferred-method-argument") { Builder = nodes => nodes[0] };
                /* 150 PlainRuleOp      */ __Matchers[150] = _inferredGetterArgument = new PlainRule(this, 150, "inferred-getter-argument") { Builder = nodes => nodes[0] };
                /* 151 PlainRuleOp      */ __Matchers[151] = _untypedMethodArgument = new PlainRule(this, 151, "untyped-method-argument") { Builder = nodes => nodes[0] };
                /* 152 PlainRuleOp      */ __Matchers[152] = _untypedGetterArgument = new PlainRule(this, 152, "untyped-getter-argument") { Builder = nodes => nodes[0] };
                /* 153 PlainRuleOp      */ __Matchers[153] = _positionalArguments = new PlainRule(this, 153, "positional-arguments") { Builder = nodes => nodes[0] };
                /* 154 PlainRuleOp      */ __Matchers[154] = _positionalArgument = new PlainRule(this, 154, "positional-argument") { Builder = nodes => nodes[0] };
                /* 155 PlainRuleOp      */ __Matchers[155] = _spreadArgument = new PlainRule(this, 155, "spread-argument") { Builder = nodes => nodes[0] };
                /* 156 PlainRuleOp      */ __Matchers[156] = _letExpression = new PlainRule(this, 156, "let-expression") { Builder = nodes => nodes[0] };
                /* 157 PlainRuleOp      */ __Matchers[157] = _letVariableList = new PlainRule(this, 157, "let-variable-list") { Builder = nodes => nodes[0] };
                /* 158 PlainRuleOp      */ __Matchers[158] = _letVariable = new PlainRule(this, 158, "let-variable") { Builder = nodes => nodes[0] };
                /* 159 PlainRuleOp      */ __Matchers[159] = _switchExpression = new PlainRule(this, 159, "switch-expression") { Builder = nodes => nodes[0] };
                /* 160 PlainRuleOp      */ __Matchers[160] = _caseExpressions = new PlainRule(this, 160, "case-expressions") { Builder = nodes => nodes[0] };
                /* 161 PlainRuleOp      */ __Matchers[161] = _caseExpression = new PlainRule(this, 161, "case-expression") { Builder = nodes => nodes[0] };
                /* 162 PlainRuleOp      */ __Matchers[162] = _ifExpression = new PlainRule(this, 162, "if-expression") { Builder = nodes => nodes[0] };
                /* 163 PlainRuleOp      */ __Matchers[163] = _elseExpression = new PlainRule(this, 163, "else-expression") { Builder = nodes => nodes[0] };
                /* 164 PlainRuleOp      */ __Matchers[164] = _thenExpression = new PlainRule(this, 164, "then-expression") { Builder = nodes => nodes[0] };
                /* 165 PlainRuleOp      */ __Matchers[165] = _conditionalExpression = new PlainRule(this, 165, "conditional-expression") { Builder = nodes => nodes[0] };
                /* 166 PlainRuleOp      */ __Matchers[166] = _functionExpression = new PlainRule(this, 166, "function-expression") { Builder = nodes => nodes[0] };
                /* 167 PlainRuleOp      */ __Matchers[167] = _functionExpressionType = new PlainRule(this, 167, "function-expression-type") { Creator = node => new CFunctionExpressionType(node) };
                /* 168 PlainRuleOp      */ __Matchers[168] = _functionParameters = new PlainRule(this, 168, "function-parameters") { Builder = nodes => nodes[0] };
                /* 169 PlainRuleOp      */ __Matchers[169] = _functionDefinition = new PlainRule(this, 169, "function-definition") { Builder = nodes => nodes[0] };
                /* 170 PlainRuleOp      */ __Matchers[170] = _comprehension = new PlainRule(this, 170, "comprehension") { Builder = nodes => nodes[0] };
                /* 171 PlainRuleOp      */ __Matchers[171] = _comprehensionClause = new PlainRule(this, 171, "comprehension-clause") { Builder = nodes => nodes[0] };
                /* 172 PlainRuleOp      */ __Matchers[172] = _expressionComprehensionClause = new PlainRule(this, 172, "expression-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 173 PlainRuleOp      */ __Matchers[173] = _forComprehensionClause = new PlainRule(this, 173, "for-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 174 PlainRuleOp      */ __Matchers[174] = _ifComprehensionClause = new PlainRule(this, 174, "if-comprehension-clause") { Builder = nodes => nodes[0] };
                /* 175 PlainRuleOp      */ __Matchers[175] = _expression = new PlainRule(this, 175, "expression") { Builder = nodes => nodes[0] };
                /* 176 PlainRuleOp      */ __Matchers[176] = _operatorExpression = new PlainRule(this, 176, "operator-expression") { Builder = nodes => nodes[0] };
                /* 177 PlainRuleOp      */ __Matchers[177] = _assignmentExpression = new PlainRule(this, 177, "assignment-expression") { Builder = nodes => nodes[0] };
                /* 178 PlainRuleOp      */ __Matchers[178] = _assignment = new PlainRule(this, 178, "assignment") { Builder = nodes => nodes[0] };
                /* 179 DfaRuleOp        */ __Matchers[179] = _assignmentOperator = new DfaRule(this, 179, "assignment-operator") { Creator = node => new CAssignmentOperator(node) };
                /* 180 PlainRuleOp      */ __Matchers[180] = _thenElseExpression = new PlainRule(this, 180, "then-else-expression") { Builder = nodes => nodes[0] };
                /* 181 PlainRuleOp      */ __Matchers[181] = _thenElse = new PlainRule(this, 181, "then-else") { Builder = nodes => nodes[0] };
                /* 182 PlainRuleOp      */ __Matchers[182] = _thenElseOperator = new PlainRule(this, 182, "then-else-operator") { Creator = node => new CThenElseOperator(node) };
                /* 183 PlainRuleOp      */ __Matchers[183] = _disjunctionExpression = new PlainRule(this, 183, "disjunction-expression") { Builder = nodes => nodes[0] };
                /* 184 PlainRuleOp      */ __Matchers[184] = _disjunction = new PlainRule(this, 184, "disjunction") { Builder = nodes => nodes[0] };
                /* 185 PlainRuleOp      */ __Matchers[185] = _disjunctionOperator = new PlainRule(this, 185, "disjunction-operator") { Creator = node => new CDisjunctionOperator(node) };
                /* 186 PlainRuleOp      */ __Matchers[186] = _conjunctionExpression = new PlainRule(this, 186, "conjunction-expression") { Builder = nodes => nodes[0] };
                /* 187 PlainRuleOp      */ __Matchers[187] = _conjunction = new PlainRule(this, 187, "conjunction") { Builder = nodes => nodes[0] };
                /* 188 PlainRuleOp      */ __Matchers[188] = _conjunctionOperator = new PlainRule(this, 188, "conjunction-operator") { Creator = node => new CConjunctionOperator(node) };
                /* 189 PlainRuleOp      */ __Matchers[189] = _logicalNegationExpression = new PlainRule(this, 189, "logical-negation-expression") { Builder = nodes => nodes[0] };
                /* 190 PlainRuleOp      */ __Matchers[190] = _logicalNegation = new PlainRule(this, 190, "logical-negation") { Builder = nodes => nodes[0] };
                /* 191 PlainRuleOp      */ __Matchers[191] = _notOperator = new PlainRule(this, 191, "not-operator") { Creator = node => new CNotOperator(node) };
                /* 192 PlainRuleOp      */ __Matchers[192] = _expressionOrMeta = new PlainRule(this, 192, "expression-or-meta") { Builder = nodes => nodes[0] };
                /* 193 PlainRuleOp      */ __Matchers[193] = _equalityExpression = new PlainRule(this, 193, "equality-expression") { Builder = nodes => nodes[0] };
                /* 194 PlainRuleOp      */ __Matchers[194] = _equality = new PlainRule(this, 194, "equality") { Builder = nodes => nodes[0] };
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
                /* 208 PlainRuleOp      */ __Matchers[208] = _existsExpression = new PlainRule(this, 208, "exists-expression") { Builder = nodes => nodes[0] };
                /* 209 PlainRuleOp      */ __Matchers[209] = _nonemptyExpression = new PlainRule(this, 209, "nonempty-expression") { Builder = nodes => nodes[0] };
                /* 210 PlainRuleOp      */ __Matchers[210] = _entryRangeExpression = new PlainRule(this, 210, "entry-range-expression") { Builder = nodes => nodes[0] };
                /* 211 PlainRuleOp      */ __Matchers[211] = _entryOrRange = new PlainRule(this, 211, "entry-or-range") { Builder = nodes => nodes[0] };
                /* 212 PlainRuleOp      */ __Matchers[212] = _rangeOrEntryOperator = new PlainRule(this, 212, "range-or-entry-operator") { Creator = node => new CRangeOrEntryOperator(node) };
                /* 213 PlainRuleOp      */ __Matchers[213] = _additiveExpression = new PlainRule(this, 213, "additive-expression") { Builder = nodes => nodes[0] };
                /* 214 PlainRuleOp      */ __Matchers[214] = _additiveExpr = new PlainRule(this, 214, "additive-expr") { Builder = nodes => nodes[0] };
                /* 215 PlainRuleOp      */ __Matchers[215] = _additiveOperator = new PlainRule(this, 215, "additive-operator") { Creator = node => new CAdditiveOperator(node) };
                /* 216 PlainRuleOp      */ __Matchers[216] = _scaleExpression = new PlainRule(this, 216, "scale-expression") { Builder = nodes => nodes[0] };
                /* 217 PlainRuleOp      */ __Matchers[217] = _scaleExpr = new PlainRule(this, 217, "scale-expr") { Builder = nodes => nodes[0] };
                /* 218 PlainRuleOp      */ __Matchers[218] = _scaleOperator = new PlainRule(this, 218, "scale-operator") { Creator = node => new CScaleOperator(node) };
                /* 219 PlainRuleOp      */ __Matchers[219] = _multiplicativeExpression = new PlainRule(this, 219, "multiplicative-expression") { Builder = nodes => nodes[0] };
                /* 220 PlainRuleOp      */ __Matchers[220] = _multiplicativeExpr = new PlainRule(this, 220, "multiplicative-expr") { Builder = nodes => nodes[0] };
                /* 221 PlainRuleOp      */ __Matchers[221] = _multiplicativeOperator = new PlainRule(this, 221, "multiplicative-operator") { Creator = node => new CMultiplicativeOperator(node) };
                /* 222 PlainRuleOp      */ __Matchers[222] = _unionExpression = new PlainRule(this, 222, "union-expression") { Builder = nodes => nodes[0] };
                /* 223 PlainRuleOp      */ __Matchers[223] = _unionExpr = new PlainRule(this, 223, "union-expr") { Builder = nodes => nodes[0] };
                /* 224 PlainRuleOp      */ __Matchers[224] = _unionOperator = new PlainRule(this, 224, "union-operator") { Creator = node => new CUnionOperator(node) };
                /* 225 PlainRuleOp      */ __Matchers[225] = _exclusiveExpression = new PlainRule(this, 225, "exclusive-expression") { Builder = nodes => nodes[0] };
                /* 226 PlainRuleOp      */ __Matchers[226] = _exclusiveExpr = new PlainRule(this, 226, "exclusive-expr") { Builder = nodes => nodes[0] };
                /* 227 PlainRuleOp      */ __Matchers[227] = _exclusiveOperator = new PlainRule(this, 227, "exclusive-operator") { Creator = node => new CExclusiveOperator(node) };
                /* 228 PlainRuleOp      */ __Matchers[228] = _intersectionExpression = new PlainRule(this, 228, "intersection-expression") { Builder = nodes => nodes[0] };
                /* 229 PlainRuleOp      */ __Matchers[229] = _intersectionExpr = new PlainRule(this, 229, "intersection-expr") { Builder = nodes => nodes[0] };
                /* 230 PlainRuleOp      */ __Matchers[230] = _intersectionOperator = new PlainRule(this, 230, "intersection-operator") { Creator = node => new CIntersectionOperator(node) };
                /* 231 PlainRuleOp      */ __Matchers[231] = _negationOrComplementExpression = new PlainRule(this, 231, "negation-or-complement-expression") { Builder = nodes => nodes[0] };
                /* 232 PlainRuleOp      */ __Matchers[232] = _negationOrComplementExpr = new PlainRule(this, 232, "negation-or-complement-expr") { Builder = nodes => nodes[0] };
                /* 233 PlainRuleOp      */ __Matchers[233] = _unaryMinusOrComplementOperator = new PlainRule(this, 233, "unary-minus-or-complement-operator") { Builder = nodes => nodes[0] };
                /* 234 PlainRuleOp      */ __Matchers[234] = _opNegate = new PlainRule(this, 234, "op-negate") { Builder = nodes => nodes[0] };
                /* 235 PlainRuleOp      */ __Matchers[235] = _opNeutral = new PlainRule(this, 235, "op-neutral") { Builder = nodes => nodes[0] };
                /* 236 PlainRuleOp      */ __Matchers[236] = _opComplement = new PlainRule(this, 236, "op-complement") { Creator = node => new COpComplement(node) };
                /* 237 PlainRuleOp      */ __Matchers[237] = _prefixExpression = new PlainRule(this, 237, "prefix-expression") { Builder = nodes => nodes[0] };
                /* 238 PlainRuleOp      */ __Matchers[238] = _prefixExpr = new PlainRule(this, 238, "prefix-expr") { Builder = nodes => nodes[0] };
                /* 239 PlainRuleOp      */ __Matchers[239] = _postfixExpression = new PlainRule(this, 239, "postfix-expression") { Builder = nodes => nodes[0] };
                /* 240 PlainRuleOp      */ __Matchers[240] = _postfixExpr = new PlainRule(this, 240, "postfix-expr") { Builder = nodes => nodes[0] };
                /* 241 PlainRuleOp      */ __Matchers[241] = _incrementOperator = new PlainRule(this, 241, "increment-operator") { Creator = node => new CIncrementOperator(node) };
                /* 242 PlainRuleOp      */ __Matchers[242] = _primary = new PlainRule(this, 242, "primary") { Builder = nodes => nodes[0] };
                /* 243 PlainRuleOp      */ __Matchers[243] = _selectionExpression = new PlainRule(this, 243, "selection-expression") { Builder = nodes => nodes[0] };
                /* 244 PlainRuleOp      */ __Matchers[244] = _qualifiedReference = new PlainRule(this, 244, "qualified-reference") { Builder = nodes => nodes[0] };
                /* 245 PlainRuleOp      */ __Matchers[245] = _memberSelectionOperator = new PlainRule(this, 245, "member-selection-operator") { Creator = node => new CMemberSelectionOperator(node) };
                /* 246 PlainRuleOp      */ __Matchers[246] = _indexedExpression = new PlainRule(this, 246, "indexed-expression") { Builder = nodes => nodes[0] };
                /* 247 PlainRuleOp      */ __Matchers[247] = _index = new PlainRule(this, 247, "index") { Builder = nodes => nodes[0] };
                /* 248 PlainRuleOp      */ __Matchers[248] = _upperSpanned = new PlainRule(this, 248, "upper-spanned") { Builder = nodes => nodes[0] };
                /* 249 PlainRuleOp      */ __Matchers[249] = _lowerSpanned = new PlainRule(this, 249, "lower-spanned") { Builder = nodes => nodes[0] };
                /* 250 PlainRuleOp      */ __Matchers[250] = _spanned = new PlainRule(this, 250, "spanned") { Builder = nodes => nodes[0] };
                /* 251 PlainRuleOp      */ __Matchers[251] = _measured = new PlainRule(this, 251, "measured") { Builder = nodes => nodes[0] };
                /* 252 PlainRuleOp      */ __Matchers[252] = _indexExpression = new PlainRule(this, 252, "index-expression") { Builder = nodes => nodes[0] };
                /* 253 PlainRuleOp      */ __Matchers[253] = _callExpression = new PlainRule(this, 253, "call-expression") { Builder = nodes => nodes[0] };
                /* 254 PlainRuleOp      */ __Matchers[254] = _baseExpression = new PlainRule(this, 254, "base-expression") { Builder = nodes => nodes[0] };
                /* 255 PlainRuleOp      */ __Matchers[255] = _nonstringLiteral = new PlainRule(this, 255, "nonstring-literal") { Builder = nodes => nodes[0] };
                /* 256 PlainRuleOp      */ __Matchers[256] = _stringExpression = new PlainRule(this, 256, "string-expression") { Builder = nodes => nodes[0] };
                /* 257 PlainRuleOp      */ __Matchers[257] = _stringInterpolation = new PlainRule(this, 257, "string-interpolation") { Builder = nodes => nodes[0] };
                /* 258 PlainRuleOp      */ __Matchers[258] = _interpolationPart = new PlainRule(this, 258, "interpolation-part") { Builder = nodes => nodes[0] };
                /* 259 PlainRuleOp      */ __Matchers[259] = _stringLiteral = new PlainRule(this, 259, "string-literal") { Builder = nodes => nodes[0] };
                /* 260 PlainRuleOp      */ __Matchers[260] = _objectExpression = new PlainRule(this, 260, "object-expression") { Builder = nodes => nodes[0] };
                /* 261 PlainRuleOp      */ __Matchers[261] = _groupedExpression = new PlainRule(this, 261, "grouped-expression") { Builder = nodes => nodes[0] };
                /* 262 PlainRuleOp      */ __Matchers[262] = _typeArguments = new PlainRule(this, 262, "type-arguments") { Builder = nodes => nodes[0] };
                /* 263 PlainRuleOp      */ __Matchers[263] = _typeArgumentList = new PlainRule(this, 263, "type-argument-list") { Builder = nodes => nodes[0] };
                /* 264 PlainRuleOp      */ __Matchers[264] = _variancedType = new PlainRule(this, 264, "varianced-type") { Builder = nodes => nodes[0] };
                /* 265 PlainRuleOp      */ __Matchers[265] = _defaultedTypeList = new PlainRule(this, 265, "defaulted-type-list") { Builder = nodes => nodes[0] };
                /* 266 PlainRuleOp      */ __Matchers[266] = _defaultedType = new PlainRule(this, 266, "defaulted-type") { Builder = nodes => nodes[0] };
                /* 267 PlainRuleOp      */ __Matchers[267] = _defaultedTypeCore = new PlainRule(this, 267, "defaulted-type-core") { Builder = nodes => nodes[0] };
                /* 268 PlainRuleOp      */ __Matchers[268] = _variadicType = new PlainRule(this, 268, "variadic-type") { Builder = nodes => nodes[0] };
                /* 269 PlainRuleOp      */ __Matchers[269] = _variadicUnionType = new PlainRule(this, 269, "variadic-union-type") { Builder = nodes => nodes[0] };
                /* 270 PlainRuleOp      */ __Matchers[270] = _variadicOperator = new PlainRule(this, 270, "variadic-operator") { Creator = node => new CVariadicOperator(node) };
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
                /* 286 PlainRuleOp      */ __Matchers[286] = _qualifiedType = new PlainRule(this, 286, "qualified-type") { Builder = nodes => nodes[0] };
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
                /* 300 PlainRuleOp      */ __Matchers[300] = _ifElse = new PlainRule(this, 300, "if-else") { Builder = nodes => nodes[0] };
                /* 301 PlainRuleOp      */ __Matchers[301] = _ifBlock = new PlainRule(this, 301, "if-block") { Builder = nodes => nodes[0] };
                /* 302 PlainRuleOp      */ __Matchers[302] = _elseBlock = new PlainRule(this, 302, "else-block") { Builder = nodes => nodes[0] };
                /* 303 PlainRuleOp      */ __Matchers[303] = _elseBlockNext = new PlainRule(this, 303, "else-block-next") { Builder = nodes => nodes[0] };
                /* 304 PlainRuleOp      */ __Matchers[304] = _switchCaseElse = new PlainRule(this, 304, "switch-case-else") { Builder = nodes => nodes[0] };
                /* 305 PlainRuleOp      */ __Matchers[305] = _switchHeader = new PlainRule(this, 305, "switch-header") { Builder = nodes => nodes[0] };
                /* 306 PlainRuleOp      */ __Matchers[306] = _switched = new PlainRule(this, 306, "switched") { Builder = nodes => nodes[0] };
                /* 307 PlainRuleOp      */ __Matchers[307] = _caseBlock = new PlainRule(this, 307, "case-block") { Builder = nodes => nodes[0] };
                /* 308 PlainRuleOp      */ __Matchers[308] = _caseItem = new PlainRule(this, 308, "case-item") { Builder = nodes => nodes[0] };
                /* 309 PlainRuleOp      */ __Matchers[309] = _isCaseCondition = new PlainRule(this, 309, "is-case-condition") { Builder = nodes => nodes[0] };
                /* 310 PlainRuleOp      */ __Matchers[310] = _satisfiesCaseCondition = new PlainRule(this, 310, "satisfies-case-condition") { Builder = nodes => nodes[0] };
                /* 311 PlainRuleOp      */ __Matchers[311] = _matchCaseCondition = new PlainRule(this, 311, "match-case-condition") { Builder = nodes => nodes[0] };
                /* 312 PlainRuleOp      */ __Matchers[312] = _valueCaseList = new PlainRule(this, 312, "value-case-list") { Builder = nodes => nodes[0] };
                /* 313 PlainRuleOp      */ __Matchers[313] = _valueCaseSeparator = new PlainRule(this, 313, "value-case-separator") { Creator = node => new CValueCaseSeparator(node) };
                /* 314 PlainRuleOp      */ __Matchers[314] = _valueCase = new PlainRule(this, 314, "value-case") { Builder = nodes => nodes[0] };
                /* 315 PlainRuleOp      */ __Matchers[315] = _forElse = new PlainRule(this, 315, "for-else") { Builder = nodes => nodes[0] };
                /* 316 PlainRuleOp      */ __Matchers[316] = _forBlock = new PlainRule(this, 316, "for-block") { Builder = nodes => nodes[0] };
                /* 317 PlainRuleOp      */ __Matchers[317] = _failBlock = new PlainRule(this, 317, "fail-block") { Builder = nodes => nodes[0] };
                /* 318 PlainRuleOp      */ __Matchers[318] = _forIterator = new PlainRule(this, 318, "for-iterator") { Builder = nodes => nodes[0] };
                /* 319 PlainRuleOp      */ __Matchers[319] = _forVariable = new PlainRule(this, 319, "for-variable") { Builder = nodes => nodes[0] };
                /* 320 PlainRuleOp      */ __Matchers[320] = _containment = new PlainRule(this, 320, "containment") { Builder = nodes => nodes[0] };
                /* 321 PlainRuleOp      */ __Matchers[321] = _containmentOperator = new PlainRule(this, 321, "containment-operator") { Creator = node => new CContainmentOperator(node) };
                /* 322 PlainRuleOp      */ __Matchers[322] = _whileLoop = new PlainRule(this, 322, "while-loop") { Builder = nodes => nodes[0] };
                /* 323 PlainRuleOp      */ __Matchers[323] = _whileBlock = new PlainRule(this, 323, "while-block") { Builder = nodes => nodes[0] };
                /* 324 PlainRuleOp      */ __Matchers[324] = _tryCatchFinally = new PlainRule(this, 324, "try-catch-finally") { Builder = nodes => nodes[0] };
                /* 325 PlainRuleOp      */ __Matchers[325] = _tryBlock = new PlainRule(this, 325, "try-block") { Builder = nodes => nodes[0] };
                /* 326 PlainRuleOp      */ __Matchers[326] = _catchBlock = new PlainRule(this, 326, "catch-block") { Builder = nodes => nodes[0] };
                /* 327 PlainRuleOp      */ __Matchers[327] = _catchVariable = new PlainRule(this, 327, "catch-variable") { Builder = nodes => nodes[0] };
                /* 328 PlainRuleOp      */ __Matchers[328] = _finallyBlock = new PlainRule(this, 328, "finally-block") { Builder = nodes => nodes[0] };
                /* 329 PlainRuleOp      */ __Matchers[329] = _resources = new PlainRule(this, 329, "resources") { Builder = nodes => nodes[0] };
                /* 330 PlainRuleOp      */ __Matchers[330] = _resourceList = new PlainRule(this, 330, "resource-list") { Builder = nodes => nodes[0] };
                /* 331 PlainRuleOp      */ __Matchers[331] = _resource = new PlainRule(this, 331, "resource") { Builder = nodes => nodes[0] };
                /* 332 PlainRuleOp      */ __Matchers[332] = _specifiedOrExpression = new PlainRule(this, 332, "specified-or-expression") { Builder = nodes => nodes[0] };
                /* 333 PlainRuleOp      */ __Matchers[333] = _specifiedVariable = new PlainRule(this, 333, "specified-variable") { Builder = nodes => nodes[0] };
                /* 334 PlainRuleOp      */ __Matchers[334] = _variable = new PlainRule(this, 334, "variable") { Builder = nodes => nodes[0] };
                /* 335 PlainRuleOp      */ __Matchers[335] = _variableType = new PlainRule(this, 335, "variable-type") { Builder = nodes => nodes[0] };
                /* 336 PlainRuleOp      */ __Matchers[336] = _modelReference = new PlainRule(this, 336, "model-reference") { Builder = nodes => nodes[0] };
                /* 337 PlainRuleOp      */ __Matchers[337] = _metaLiteral = new PlainRule(this, 337, "meta-literal") { Builder = nodes => nodes[0] };
                /* 338 PlainRuleOp      */ __Matchers[338] = _metaExpression = new PlainRule(this, 338, "meta-expression") { Builder = nodes => nodes[0] };
                /* 339 PlainRuleOp      */ __Matchers[339] = _modelExpression = new PlainRule(this, 339, "model-expression") { Builder = nodes => nodes[0] };
                /* 340 PlainRuleOp      */ __Matchers[340] = _memberModelExpression = new PlainRule(this, 340, "member-model-expression") { Builder = nodes => nodes[0] };
                /* 341 PlainRuleOp      */ __Matchers[341] = _packageQualifiedMemberReference = new PlainRule(this, 341, "package-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 342 PlainRuleOp      */ __Matchers[342] = _typeQualifiedMemberReference = new PlainRule(this, 342, "type-qualified-member-reference") { Builder = nodes => nodes[0] };
                /* 343 PlainRuleOp      */ __Matchers[343] = _typeModelExpression = new PlainRule(this, 343, "type-model-expression") { Builder = nodes => nodes[0] };
                /* 344 PlainRuleOp      */ __Matchers[344] = _declarationReference = new PlainRule(this, 344, "declaration-reference") { Builder = nodes => nodes[0] };
                /* 345 PlainRuleOp      */ __Matchers[345] = _moduleLiteral = new PlainRule(this, 345, "module-literal") { Builder = nodes => nodes[0] };
                /* 346 PlainRuleOp      */ __Matchers[346] = _packageLiteral = new PlainRule(this, 346, "package-literal") { Builder = nodes => nodes[0] };
                /* 347 PlainRuleOp      */ __Matchers[347] = _classLiteral = new PlainRule(this, 347, "class-literal") { Builder = nodes => nodes[0] };
                /* 348 PlainRuleOp      */ __Matchers[348] = _interfaceLiteral = new PlainRule(this, 348, "interface-literal") { Builder = nodes => nodes[0] };
                /* 349 PlainRuleOp      */ __Matchers[349] = _aliasLiteral = new PlainRule(this, 349, "alias-literal") { Builder = nodes => nodes[0] };
                /* 350 PlainRuleOp      */ __Matchers[350] = _typeParameterLiteral = new PlainRule(this, 350, "type-parameter-literal") { Builder = nodes => nodes[0] };
                /* 351 PlainRuleOp      */ __Matchers[351] = _newLiteral = new PlainRule(this, 351, "new-literal") { Builder = nodes => nodes[0] };
                /* 352 PlainRuleOp      */ __Matchers[352] = _valueLiteral = new PlainRule(this, 352, "value-literal") { Builder = nodes => nodes[0] };
                /* 353 PlainRuleOp      */ __Matchers[353] = _valueLiteralIntro = new PlainRule(this, 353, "value-literal-intro") { Creator = node => new CValueLiteralIntro(node) };
                /* 354 PlainRuleOp      */ __Matchers[354] = _functionLiteral = new PlainRule(this, 354, "function-literal") { Builder = nodes => nodes[0] };
                /* 355 PlainRuleOp      */ __Matchers[355] = _referencePath = new PlainRule(this, 355, "reference-path") { Builder = nodes => nodes[0] };
                /* 356 PlainRuleOp      */ __Matchers[356] = _referencePathElementList = new PlainRule(this, 356, "reference-path-element-list") { Builder = nodes => nodes[0] };
                /* 357 PlainRuleOp      */ __Matchers[357] = _referencePathElement = new PlainRule(this, 357, "reference-path-element") { Builder = nodes => nodes[0] };
                /* 358 PlainRuleOp      */ __Matchers[358] = _kwVoid = new PlainRule(this, 358, "kw-void") { Creator = node => new CKwVoid(node) };
                /* 359 PlainRuleOp      */ __Matchers[359] = _kwFunction = new PlainRule(this, 359, "kw-function") { Creator = node => new CKwFunction(node) };
                /* 360 PlainRuleOp      */ __Matchers[360] = _kwValue = new PlainRule(this, 360, "kw-value") { Creator = node => new CKwValue(node) };
                /* 361 DfaRuleOp        */ __Matchers[361] = _literalFloat = new DfaRule(this, 361, "literal-float") { Creator = node => new CLiteralFloat(node) };
                /* 362 DfaRuleOp        */ __Matchers[362] = _literalNatural = new DfaRule(this, 362, "literal-natural") { Creator = node => new CLiteralNatural(node) };
                /* 363 DfaRuleOp        */ __Matchers[363] = _literalChar = new DfaRule(this, 363, "literal-char") { Creator = node => new CLiteralChar(node) };
                /* 364 DfaRuleOp        */ __Matchers[364] = _stringStart = new DfaRule(this, 364, "string-start") { Creator = node => new CStringStart(node) };
                /* 365 DfaRuleOp        */ __Matchers[365] = _stringMid = new DfaRule(this, 365, "string-mid") { Creator = node => new CStringMid(node) };
                /* 366 DfaRuleOp        */ __Matchers[366] = _stringEnd = new DfaRule(this, 366, "string-end") { Creator = node => new CStringEnd(node) };
                /* 367 DfaRuleOp        */ __Matchers[367] = _literalString = new DfaRule(this, 367, "literal-string") { Creator = node => new CLiteralString(node) };
                /* 368 DfaRuleOp        */ __Matchers[368] = _verbatimString = new DfaRule(this, 368, "verbatim-string") { Creator = node => new CVerbatimString(node) };
                /* 369 DfaRuleOp        */ __Matchers[369] = _lowerIdentifier = new DfaRule(this, 369, "lower-identifier") { Creator = node => new CLowerIdentifier(node) };
                /* 370 DfaRuleOp        */ __Matchers[370] = _upperIdentifier = new DfaRule(this, 370, "upper-identifier") { Creator = node => new CUpperIdentifier(node) };
                /* 371 EofOp            */ __Matchers[371] = new Eof(this, 371, "<eof>") { Creator = node => new REof(node) };
                /* 372 SeqOp            */ __Matchers[372] = new Seq(this, 372, "_(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /* 373 AltOp            */ __Matchers[373] = new Alt(this, 373, "alt(>module-descriptor|>package-descriptor|>unit-elements)") { Builder = nodes => nodes[0] };
                /* 374 StarOp           */ __Matchers[374] = new Star(this, 374, "*(>unit-element)") { Builder = nodes => new CUnitElements(nodes) };
                /* 375 AltOp            */ __Matchers[375] = new Alt(this, 375, "alt(>import-declaration|>declaration)") { Builder = nodes => nodes[0] };
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
                /* 409 SeqOp            */ __Matchers[409] = new Seq(this, 409, "_('=',>import-name)") { Builder = nodes => new CImportNameSpecifier(nodes) };
                /* 410 StringOp         */ __Matchers[410] = new String(this, 410, "'...'", "...") { Creator = node => new CImportWildcard(node) };
                /* 411 StringOp         */ __Matchers[411] = new String(this, 411, "'.'", ".") { Creator = node => new RString(node) };
                /* 412 SeqOp            */ __Matchers[412] = new Seq(this, 412, "_('.',>package-name)") { Builder = nodes => new RSequence(nodes) };
                /* 413 StarOp           */ __Matchers[413] = new Star(this, 413, "*(_('.',>package-name))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 414 SeqOp            */ __Matchers[414] = new Seq(this, 414, "_(>package-name,*(_('.',>package-name)))") { Builder = nodes => new CPackagePath(nodes) };
                /* 415 AltOp            */ __Matchers[415] = new Alt(this, 415, "alt(>lower-identifier|>upper-identifier)") { Builder = nodes => nodes[0] };
                /* 416 AltOp            */ __Matchers[416] = new Alt(this, 416, "alt(>entry-pattern|>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 417 AltOp            */ __Matchers[417] = new Alt(this, 417, "alt(>tuple-pattern|>variable-pattern)") { Builder = nodes => nodes[0] };
                /* 418 AltOp            */ __Matchers[418] = new Alt(this, 418, "alt(>entry-pattern|>tuple-pattern)") { Builder = nodes => nodes[0] };
                /* 419 StringOp         */ __Matchers[419] = new String(this, 419, "'->'", "->") { Creator = node => new RString(node) };
                /* 420 SeqOp            */ __Matchers[420] = new Seq(this, 420, "_(>variable-or-tuple-pattern,'->',>variable-or-tuple-pattern)") { Builder = nodes => new CEntryPattern(nodes) };
                /* 421 StringOp         */ __Matchers[421] = new String(this, 421, "'['", "[") { Creator = node => new RString(node) };
                /* 422 OptionalOp       */ __Matchers[422] = new Optional(this, 422, "?(>variadic-pattern-list)") { Builder = nodes => new ROptional<CVariadicPatternList>(nodes) };
                /* 423 StringOp         */ __Matchers[423] = new String(this, 423, "']'", "]") { Creator = node => new RString(node) };
                /* 424 SeqOp            */ __Matchers[424] = new Seq(this, 424, "_('[',?(>variadic-pattern-list),']')") { Builder = nodes => new CTuplePattern(nodes) };
                /* 425 SeqOp            */ __Matchers[425] = new Seq(this, 425, "_(',',>variadic-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 426 StarOp           */ __Matchers[426] = new Star(this, 426, "*(_(',',>variadic-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 427 SeqOp            */ __Matchers[427] = new Seq(this, 427, "_(>variadic-pattern,*(_(',',>variadic-pattern)))") { Builder = nodes => new CVariadicPatternList(nodes) };
                /* 428 AltOp            */ __Matchers[428] = new Alt(this, 428, "alt(>variadic-variable|>pattern)") { Builder = nodes => nodes[0] };
                /* 429 OptionalOp       */ __Matchers[429] = new Optional(this, 429, "?(>union-type)") { Builder = nodes => new ROptional<IUnionType>(nodes) };
                /* 430 OptionalOp       */ __Matchers[430] = new Optional(this, 430, "?(>member-name)") { Builder = nodes => new ROptional<IMemberName>(nodes) };
                /* 431 SeqOp            */ __Matchers[431] = new Seq(this, 431, "_(?(>union-type),>variadic-operator,?(>member-name))") { Builder = nodes => new CVariadicVariable(nodes) };
                /* 432 StringOp         */ __Matchers[432] = new Keyword(this, 432, "'let'", "let") { Creator = node => new RString(node) };
                /* 433 StringOp         */ __Matchers[433] = new String(this, 433, "'('", "(") { Creator = node => new RString(node) };
                /* 434 StringOp         */ __Matchers[434] = new String(this, 434, "')'", ")") { Creator = node => new RString(node) };
                /* 435 SeqOp            */ __Matchers[435] = new Seq(this, 435, "_('let','(',>let-variable-list,')')") { Builder = nodes => new CLetStatement(nodes) };
                /* 436 StringOp         */ __Matchers[436] = new Keyword(this, 436, "'extends'", "extends") { Creator = node => new RString(node) };
                /* 437 SeqOp            */ __Matchers[437] = new Seq(this, 437, "_('extends',>class-instatiation)") { Builder = nodes => new CExtendedType(nodes) };
                /* 438 OptionalOp       */ __Matchers[438] = new Optional(this, 438, "?(>assertion-message)") { Builder = nodes => new ROptional<IAssertionMessage>(nodes) };
                /* 439 StringOp         */ __Matchers[439] = new Keyword(this, 439, "'assert'", "assert") { Creator = node => new RString(node) };
                /* 440 SeqOp            */ __Matchers[440] = new Seq(this, 440, "_(?(>assertion-message),'assert',>conditions)") { Builder = nodes => new CAssertionStatement(nodes) };
                /* 441 StarOp           */ __Matchers[441] = new Star(this, 441, "*(>block-element)") { Builder = nodes => new RStar<IBlockElement>(nodes) };
                /* 442 SeqOp            */ __Matchers[442] = new Seq(this, 442, "_('{',*(>block-element),'}')") { Builder = nodes => new CBlockElements(nodes) };
                /* 443 AltOp            */ __Matchers[443] = new Alt(this, 443, "alt(>import-declaration|>declaration-or-statement)") { Builder = nodes => nodes[0] };
                /* 444 StringOp         */ __Matchers[444] = new String(this, 444, "'=>'", "=>") { Creator = node => new RString(node) };
                /* 445 SeqOp            */ __Matchers[445] = new Seq(this, 445, "_('=>',>class-instatiation)") { Builder = nodes => new CClassSpecifier(nodes) };
                /* 446 OptionalOp       */ __Matchers[446] = new Optional(this, 446, "?(>arguments)") { Builder = nodes => new ROptional<IArguments>(nodes) };
                /* 447 SeqOp            */ __Matchers[447] = new Seq(this, 447, "_(>qualified-class,?(>arguments))") { Builder = nodes => new CClassInstatiation(nodes) };
                /* 448 AltOp            */ __Matchers[448] = new Alt(this, 448, "alt(>package-qualified-class|>super-qualified-class|>un-qualified-class)") { Builder = nodes => nodes[0] };
                /* 449 SeqOp            */ __Matchers[449] = new Seq(this, 449, "_(>super-qualifier,>base-reference)") { Builder = nodes => new CSuperQualifiedClass(nodes) };
                /* 450 StringOp         */ __Matchers[450] = new Keyword(this, 450, "'super'", "super") { Creator = node => new RString(node) };
                /* 451 SeqOp            */ __Matchers[451] = new Seq(this, 451, "_('super','.')") { Builder = nodes => new CSuperQualifier(nodes) };
                /* 452 SeqOp            */ __Matchers[452] = new Seq(this, 452, "_(>package-qualifier,>un-qualified-class)") { Builder = nodes => new CPackageQualifiedClass(nodes) };
                /* 453 SeqOp            */ __Matchers[453] = new Seq(this, 453, "_('package','.')") { Builder = nodes => new CPackageQualifier(nodes) };
                /* 454 AltOp            */ __Matchers[454] = new Alt(this, 454, "alt(>member-path|>type-path|>member-reference)") { Builder = nodes => nodes[0] };
                /* 455 SeqOp            */ __Matchers[455] = new Seq(this, 455, "_(>type-path,'.',>member-reference)") { Builder = nodes => new CMemberPath(nodes) };
                /* 456 SeqOp            */ __Matchers[456] = new Seq(this, 456, "_('.',>type-reference)") { Builder = nodes => new RSequence(nodes) };
                /* 457 StarOp           */ __Matchers[457] = new Star(this, 457, "*(_('.',>type-reference))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 458 SeqOp            */ __Matchers[458] = new Seq(this, 458, "_(>type-reference,*(_('.',>type-reference)))") { Builder = nodes => new CTypePath(nodes) };
                /* 459 StringOp         */ __Matchers[459] = new Keyword(this, 459, "'satisfies'", "satisfies") { Creator = node => new RString(node) };
                /* 460 SeqOp            */ __Matchers[460] = new Seq(this, 460, "_('satisfies',>union-type-list)") { Builder = nodes => new CSatisfiedTypes(nodes) };
                /* 461 SeqOp            */ __Matchers[461] = new Seq(this, 461, "_(',',>union-type)") { Builder = nodes => new RSequence(nodes) };
                /* 462 StarOp           */ __Matchers[462] = new Star(this, 462, "*(_(',',>union-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 463 SeqOp            */ __Matchers[463] = new Seq(this, 463, "_(>union-type,*(_(',',>union-type)))") { Builder = nodes => new CUnionTypeList(nodes) };
                /* 464 StringOp         */ __Matchers[464] = new Keyword(this, 464, "'of'", "of") { Creator = node => new RString(node) };
                /* 465 SeqOp            */ __Matchers[465] = new Seq(this, 465, "_('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 466 StringOp         */ __Matchers[466] = new String(this, 466, "'|'", "|") { Creator = node => new RString(node) };
                /* 467 SeqOp            */ __Matchers[467] = new Seq(this, 467, "_('|',>case-type)") { Builder = nodes => new RSequence(nodes) };
                /* 468 StarOp           */ __Matchers[468] = new Star(this, 468, "*(_('|',>case-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 469 SeqOp            */ __Matchers[469] = new Seq(this, 469, "_(>case-type,*(_('|',>case-type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 470 AltOp            */ __Matchers[470] = new Alt(this, 470, "alt(>primary-type|>qualified-case-type)") { Builder = nodes => nodes[0] };
                /* 471 OptionalOp       */ __Matchers[471] = new Optional(this, 471, "?(>package-qualifier)") { Builder = nodes => new ROptional<CPackageQualifier>(nodes) };
                /* 472 SeqOp            */ __Matchers[472] = new Seq(this, 472, "_(?(>package-qualifier),>member-name)") { Builder = nodes => new CQualifiedCaseType(nodes) };
                /* 473 OptionalOp       */ __Matchers[473] = new Optional(this, 473, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 474 SeqOp            */ __Matchers[474] = new Seq(this, 474, "_('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 475 SeqOp            */ __Matchers[475] = new Seq(this, 475, "_(',',>parameter-declaration-or-ref-pattern)") { Builder = nodes => new RSequence(nodes) };
                /* 476 StarOp           */ __Matchers[476] = new Star(this, 476, "*(_(',',>parameter-declaration-or-ref-pattern))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 477 SeqOp            */ __Matchers[477] = new Seq(this, 477, "_(>parameter-declaration-or-ref-pattern,*(_(',',>parameter-declaration-or-ref-pattern)))") { Builder = nodes => new CParameterList(nodes) };
                /* 478 AltOp            */ __Matchers[478] = new Alt(this, 478, "alt(>tuple-or-entry-pattern|>parameter-declaration-or-ref)") { Builder = nodes => nodes[0] };
                /* 479 AltOp            */ __Matchers[479] = new Alt(this, 479, "alt(>parameter|>parameter-reference)") { Builder = nodes => nodes[0] };
                /* 480 SeqOp            */ __Matchers[480] = new Seq(this, 480, "_(>annotations,>parameter-declaration)") { Builder = nodes => new CParameter(nodes) };
                /* 481 OptionalOp       */ __Matchers[481] = new Optional(this, 481, "?(>value-specifier)") { Builder = nodes => new ROptional<CValueSpecifier>(nodes) };
                /* 482 SeqOp            */ __Matchers[482] = new Seq(this, 482, "_(>member-name,?(>value-specifier))") { Builder = nodes => new CIsConditionVariable(nodes) };
                /* 483 AltOp            */ __Matchers[483] = new Alt(this, 483, "alt(>function-parameter-declaration|>value-parameter-declaration)") { Builder = nodes => nodes[0] };
                /* 484 OptionalOp       */ __Matchers[484] = new Optional(this, 484, "?(>type-parameters)") { Builder = nodes => new ROptional<CTypeParameters>(nodes) };
                /* 485 PlusOp           */ __Matchers[485] = new Plus(this, 485, "+(>parameters)") { Builder = nodes => new RPlus<CParameters>(nodes) };
                /* 486 OptionalOp       */ __Matchers[486] = new Optional(this, 486, "?(>function-specifier)") { Builder = nodes => new ROptional<CFunctionSpecifier>(nodes) };
                /* 487 SeqOp            */ __Matchers[487] = new Seq(this, 487, "_(>function-parameter-type,>member-name,?(>type-parameters),+(>parameters),?(>function-specifier))") { Builder = nodes => new CFunctionParameterDeclaration(nodes) };
                /* 488 AltOp            */ __Matchers[488] = new Alt(this, 488, "alt(>variadic-type|>kw-void|>kw-function)") { Builder = nodes => nodes[0] };
                /* 489 SeqOp            */ __Matchers[489] = new Seq(this, 489, "_(>value-parameter-type,>member-name,?(>value-specifier))") { Builder = nodes => new CValueParameterDeclaration(nodes) };
                /* 490 AltOp            */ __Matchers[490] = new Alt(this, 490, "alt(>variadic-type|>kw-value)") { Builder = nodes => nodes[0] };
                /* 491 StringOp         */ __Matchers[491] = new String(this, 491, "'<'", "<") { Creator = node => new RString(node) };
                /* 492 StringOp         */ __Matchers[492] = new String(this, 492, "'>'", ">") { Creator = node => new RString(node) };
                /* 493 SeqOp            */ __Matchers[493] = new Seq(this, 493, "_('<',>type-parameter-list,'>')") { Builder = nodes => new CTypeParameters(nodes) };
                /* 494 SeqOp            */ __Matchers[494] = new Seq(this, 494, "_(',',>type-parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 495 StarOp           */ __Matchers[495] = new Star(this, 495, "*(_(',',>type-parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 496 SeqOp            */ __Matchers[496] = new Seq(this, 496, "_(>type-parameter,*(_(',',>type-parameter)))") { Builder = nodes => new CTypeParameterList(nodes) };
                /* 497 OptionalOp       */ __Matchers[497] = new Optional(this, 497, "?(>variance)") { Builder = nodes => new ROptional<IVariance>(nodes) };
                /* 498 OptionalOp       */ __Matchers[498] = new Optional(this, 498, "?(>type-default)") { Builder = nodes => new ROptional<CTypeDefault>(nodes) };
                /* 499 SeqOp            */ __Matchers[499] = new Seq(this, 499, "_(?(>variance),>type-name,?(>type-default))") { Builder = nodes => new CTypeParameter(nodes) };
                /* 500 StringOp         */ __Matchers[500] = new Keyword(this, 500, "'in'", "in") { Creator = node => new RString(node) };
                /* 501 StringOp         */ __Matchers[501] = new Keyword(this, 501, "'out'", "out") { Creator = node => new RString(node) };
                /* 502 AltOp            */ __Matchers[502] = new Alt(this, 502, "alt('in'|'out')") { Builder = nodes => nodes[0] };
                /* 503 SeqOp            */ __Matchers[503] = new Seq(this, 503, "_('=',>type)") { Builder = nodes => new CTypeDefault(nodes) };
                /* 504 StringOp         */ __Matchers[504] = new Keyword(this, 504, "'given'", "given") { Creator = node => new RString(node) };
                /* 505 OptionalOp       */ __Matchers[505] = new Optional(this, 505, "?(>type-name)") { Builder = nodes => new ROptional<ITypeName>(nodes) };
                /* 506 OptionalOp       */ __Matchers[506] = new Optional(this, 506, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 507 OptionalOp       */ __Matchers[507] = new Optional(this, 507, "?(>satisfied-types)") { Builder = nodes => new ROptional<CSatisfiedTypes>(nodes) };
                /* 508 SeqOp            */ __Matchers[508] = new Seq(this, 508, "_('given',?(>type-name),?(>type-parameters),?(>case-types),?(>satisfied-types))") { Builder = nodes => new CTypeConstraint(nodes) };
                /* 509 PlusOp           */ __Matchers[509] = new Plus(this, 509, "+(>type-constraint)") { Builder = nodes => new CTypeConstraints(nodes) };
                /* 510 AltOp            */ __Matchers[510] = new Alt(this, 510, "alt(>declaration|>statement)") { Builder = nodes => nodes[0] };
                /* 511 AltOp            */ __Matchers[511] = new Alt(this, 511, "alt(>constructor|>enumerated-object|>alias-declaration|>object-declaration|>setter-declaration|>typed-method-declaration|>inferred-method-declaration|>typed-attribute-declaration|>inferred-attribute-declaration|>class-declaration|>interface-declaration)") { Builder = nodes => nodes[0] };
                /* 512 StringOp         */ __Matchers[512] = new Keyword(this, 512, "'new'", "new") { Creator = node => new RString(node) };
                /* 513 OptionalOp       */ __Matchers[513] = new Optional(this, 513, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 514 OptionalOp       */ __Matchers[514] = new Optional(this, 514, "?(>delegated-constructor)") { Builder = nodes => new ROptional<CDelegatedConstructor>(nodes) };
                /* 515 SeqOp            */ __Matchers[515] = new Seq(this, 515, "_(>annotations,'new',?(>member-name),?(>parameters),?(>delegated-constructor),>block)") { Builder = nodes => new CConstructor(nodes) };
                /* 516 SeqOp            */ __Matchers[516] = new Seq(this, 516, "_(>annotations,'new',>member-name,?(>delegated-constructor),>block)") { Builder = nodes => new CEnumeratedObject(nodes) };
                /* 517 StringOp         */ __Matchers[517] = new Keyword(this, 517, "'alias'", "alias") { Creator = node => new RString(node) };
                /* 518 OptionalOp       */ __Matchers[518] = new Optional(this, 518, "?(>type-constraints)") { Builder = nodes => new ROptional<CTypeConstraints>(nodes) };
                /* 519 SeqOp            */ __Matchers[519] = new Seq(this, 519, "_(>annotations,'alias',>type-name,?(>type-parameters),?(>type-constraints),>optional-type-specifier)") { Builder = nodes => new CAliasDeclaration(nodes) };
                /* 520 StringOp         */ __Matchers[520] = new Keyword(this, 520, "'object'", "object") { Creator = node => new RString(node) };
                /* 521 OptionalOp       */ __Matchers[521] = new Optional(this, 521, "?(>extended-type)") { Builder = nodes => new ROptional<CExtendedType>(nodes) };
                /* 522 SeqOp            */ __Matchers[522] = new Seq(this, 522, "_(>annotations,'object',>member-name,?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 523 StringOp         */ __Matchers[523] = new Keyword(this, 523, "'assign'", "assign") { Creator = node => new RString(node) };
                /* 524 SeqOp            */ __Matchers[524] = new Seq(this, 524, "_(>annotations,'assign',>member-name,>setter-definition)") { Builder = nodes => new CSetterDeclaration(nodes) };
                /* 525 AltOp            */ __Matchers[525] = new Alt(this, 525, "alt(>block|>needed-function-specifier)") { Builder = nodes => nodes[0] };
                /* 526 SeqOp            */ __Matchers[526] = new Seq(this, 526, "_(>annotations,>method-type,>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CTypedMethodDeclaration(nodes) };
                /* 527 AltOp            */ __Matchers[527] = new Alt(this, 527, "alt(>variadic-type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 528 StringOp         */ __Matchers[528] = new Keyword(this, 528, "'function'", "function") { Creator = node => new CKwFunction(node) };
                /* 529 SeqOp            */ __Matchers[529] = new Seq(this, 529, "_(>annotations,'function',>parametrized-member,?(>type-constraints),>method-definition)") { Builder = nodes => new CInferredMethodDeclaration(nodes) };
                /* 530 SeqOp            */ __Matchers[530] = new Seq(this, 530, "_(>annotations,>attribute-type,>member-name,>attribute-definition)") { Builder = nodes => new CTypedAttributeDeclaration(nodes) };
                /* 531 StringOp         */ __Matchers[531] = new Keyword(this, 531, "'value'", "value") { Creator = node => new CKwValue(node) };
                /* 532 SeqOp            */ __Matchers[532] = new Seq(this, 532, "_(>annotations,'value',>member-name,>attribute-definition)") { Builder = nodes => new CInferredAttributeDeclaration(nodes) };
                /* 533 AltOp            */ __Matchers[533] = new Alt(this, 533, "alt(>block|>optional-any-specifier)") { Builder = nodes => nodes[0] };
                /* 534 OptionalOp       */ __Matchers[534] = new Optional(this, 534, "?(>any-specifier)") { Builder = nodes => new ROptional<IAnySpecifier>(nodes) };
                /* 535 SeqOp            */ __Matchers[535] = new Seq(this, 535, "_(?(>any-specifier),';')") { Builder = nodes => new COptionalAnySpecifier(nodes) };
                /* 536 StringOp         */ __Matchers[536] = new Keyword(this, 536, "'class'", "class") { Creator = node => new RString(node) };
                /* 537 SeqOp            */ __Matchers[537] = new Seq(this, 537, "_(>annotations,'class',>type-name,?(>type-parameters),?(>parameters),?(>case-types),?(>extended-type),?(>satisfied-types),?(>type-constraints),>class-definition)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 538 AltOp            */ __Matchers[538] = new Alt(this, 538, "alt(>class-block|>optional-class-specifier)") { Builder = nodes => nodes[0] };
                /* 539 OptionalOp       */ __Matchers[539] = new Optional(this, 539, "?(>class-specifier)") { Builder = nodes => new ROptional<CClassSpecifier>(nodes) };
                /* 540 SeqOp            */ __Matchers[540] = new Seq(this, 540, "_(?(>class-specifier),';')") { Builder = nodes => new COptionalClassSpecifier(nodes) };
                /* 541 StringOp         */ __Matchers[541] = new Keyword(this, 541, "'interface'", "interface") { Creator = node => new RString(node) };
                /* 542 SeqOp            */ __Matchers[542] = new Seq(this, 542, "_(>annotations,'interface',>type-name,?(>type-parameters),?(>case-types),?(>satisfied-types),?(>type-constraints),>interface-definition)") { Builder = nodes => new CInterfaceDeclaration(nodes) };
                /* 543 AltOp            */ __Matchers[543] = new Alt(this, 543, "alt(>interface-block|>optional-type-specifier)") { Builder = nodes => nodes[0] };
                /* 544 OptionalOp       */ __Matchers[544] = new Optional(this, 544, "?(>type-specifier)") { Builder = nodes => new ROptional<CTypeSpecifier>(nodes) };
                /* 545 SeqOp            */ __Matchers[545] = new Seq(this, 545, "_(?(>type-specifier),';')") { Builder = nodes => new COptionalTypeSpecifier(nodes) };
                /* 546 AltOp            */ __Matchers[546] = new Alt(this, 546, "alt(>unclosed-statement|>control-statement)") { Builder = nodes => nodes[0] };
                /* 547 SeqOp            */ __Matchers[547] = new Seq(this, 547, "_(>open-statement,';')") { Builder = nodes => new CUnclosedStatement(nodes) };
                /* 548 AltOp            */ __Matchers[548] = new Alt(this, 548, "alt(>directive-statement|>expression-statement|>specification-statement|>assertion-statement|>let-statement)") { Builder = nodes => nodes[0] };
                /* 549 SeqOp            */ __Matchers[549] = new Seq(this, 549, "_(>primary,>function-specifier)") { Builder = nodes => new CSpecificationStatement(nodes) };
                /* 550 AltOp            */ __Matchers[550] = new Alt(this, 550, "alt(>return-directive|>throw-directive|>break-directive|>continue-directive)") { Builder = nodes => nodes[0] };
                /* 551 StringOp         */ __Matchers[551] = new Keyword(this, 551, "'return'", "return") { Creator = node => new RString(node) };
                /* 552 OptionalOp       */ __Matchers[552] = new Optional(this, 552, "?(>expression)") { Builder = nodes => new ROptional<IExpression>(nodes) };
                /* 553 SeqOp            */ __Matchers[553] = new Seq(this, 553, "_('return',?(>expression))") { Builder = nodes => new CReturnDirective(nodes) };
                /* 554 StringOp         */ __Matchers[554] = new Keyword(this, 554, "'throw'", "throw") { Creator = node => new RString(node) };
                /* 555 SeqOp            */ __Matchers[555] = new Seq(this, 555, "_('throw',?(>expression))") { Builder = nodes => new CThrowDirective(nodes) };
                /* 556 StringOp         */ __Matchers[556] = new Keyword(this, 556, "'break'", "break") { Creator = node => new CBreakDirective(node) };
                /* 557 StringOp         */ __Matchers[557] = new Keyword(this, 557, "'continue'", "continue") { Creator = node => new CContinueDirective(node) };
                /* 558 SeqOp            */ __Matchers[558] = new Seq(this, 558, "_('=>',>type)") { Builder = nodes => new CTypeSpecifier(nodes) };
                /* 559 SeqOp            */ __Matchers[559] = new Seq(this, 559, "_('=',>expression)") { Builder = nodes => new CValueSpecifier(nodes) };
                /* 560 SeqOp            */ __Matchers[560] = new Seq(this, 560, "_('=>',>expression)") { Builder = nodes => new CFunctionSpecifier(nodes) };
                /* 561 AltOp            */ __Matchers[561] = new Alt(this, 561, "alt(>value-specifier|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 562 AltOp            */ __Matchers[562] = new Alt(this, 562, "alt(>base-reference|>parametrized-member|>self-reference|>self-parametrized-member)") { Builder = nodes => nodes[0] };
                /* 563 AltOp            */ __Matchers[563] = new Alt(this, 563, "alt(>member-reference|>type-reference)") { Builder = nodes => nodes[0] };
                /* 564 SeqOp            */ __Matchers[564] = new Seq(this, 564, "_(>member-name,?(>type-parameters),+(>parameters))") { Builder = nodes => new CParametrizedMember(nodes) };
                /* 565 SeqOp            */ __Matchers[565] = new Seq(this, 565, "_(>self-reference-selector,>parametrized-member)") { Builder = nodes => new CSelfParametrizedMember(nodes) };
                /* 566 OptionalOp       */ __Matchers[566] = new Optional(this, 566, "?(>type-arguments)") { Builder = nodes => new ROptional<CTypeArguments>(nodes) };
                /* 567 SeqOp            */ __Matchers[567] = new Seq(this, 567, "_(>member-name,?(>type-arguments))") { Builder = nodes => new CMemberReference(nodes) };
                /* 568 SeqOp            */ __Matchers[568] = new Seq(this, 568, "_(>type-name,?(>type-arguments))") { Builder = nodes => new CTypeReference(nodes) };
                /* 569 SeqOp            */ __Matchers[569] = new Seq(this, 569, "_(>self-reference,>member-selection-operator)") { Builder = nodes => new CSelfReferenceSelector(nodes) };
                /* 570 StringOp         */ __Matchers[570] = new Keyword(this, 570, "'this'", "this") { Creator = node => new RString(node) };
                /* 571 StringOp         */ __Matchers[571] = new Keyword(this, 571, "'outer'", "outer") { Creator = node => new RString(node) };
                /* 572 AltOp            */ __Matchers[572] = new Alt(this, 572, "alt('this'|'super'|'outer'|'package')") { Builder = nodes => nodes[0] };
                /* 573 StarOp           */ __Matchers[573] = new Star(this, 573, "*(>declaration-or-statement)") { Builder = nodes => new RStar<IDeclarationOrStatement>(nodes) };
                /* 574 OptionalOp       */ __Matchers[574] = new Optional(this, 574, "?(>sequenced-arguments)") { Builder = nodes => new ROptional<CSequencedArguments>(nodes) };
                /* 575 SeqOp            */ __Matchers[575] = new Seq(this, 575, "_('{',*(>declaration-or-statement),?(>sequenced-arguments),'}')") { Builder = nodes => new CEnumeration(nodes) };
                /* 576 SeqOp            */ __Matchers[576] = new Seq(this, 576, "_('[',?(>sequenced-arguments),']')") { Builder = nodes => new CTuple(nodes) };
                /* 577 AltOp            */ __Matchers[577] = new Alt(this, 577, "alt(>structural-arguments|>positional-arguments)") { Builder = nodes => nodes[0] };
                /* 578 StarOp           */ __Matchers[578] = new Star(this, 578, "*(>named-or-anonymous)") { Builder = nodes => new RStar<INamedOrAnonymous>(nodes) };
                /* 579 SeqOp            */ __Matchers[579] = new Seq(this, 579, "_('{',*(>named-or-anonymous),?(>sequenced-arguments),'}')") { Builder = nodes => new CStructuralArguments(nodes) };
                /* 580 AltOp            */ __Matchers[580] = new Alt(this, 580, "alt(>named-argument|>anonymous-argument)") { Builder = nodes => nodes[0] };
                /* 581 AltOp            */ __Matchers[581] = new Alt(this, 581, "alt(>named-specified-argument|>named-argument-declaration)") { Builder = nodes => nodes[0] };
                /* 582 SeqOp            */ __Matchers[582] = new Seq(this, 582, "_(>member-name,>value-specifier,';')") { Builder = nodes => new CNamedSpecifiedArgument(nodes) };
                /* 583 SeqOp            */ __Matchers[583] = new Seq(this, 583, "_(',',>sequenced-argument)") { Builder = nodes => new RSequence(nodes) };
                /* 584 StarOp           */ __Matchers[584] = new Star(this, 584, "*(_(',',>sequenced-argument))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 585 SeqOp            */ __Matchers[585] = new Seq(this, 585, "_(>sequenced-argument,*(_(',',>sequenced-argument)))") { Builder = nodes => new CSequencedArguments(nodes) };
                /* 586 AltOp            */ __Matchers[586] = new Alt(this, 586, "alt(>comprehension|>positional-argument|>spread-argument)") { Builder = nodes => nodes[0] };
                /* 587 SeqOp            */ __Matchers[587] = new Seq(this, 587, "_(>expression,';')") { Builder = nodes => new CAnonymousArgument(nodes) };
                /* 588 AltOp            */ __Matchers[588] = new Alt(this, 588, "alt(>object-argument|>typed-method-argument|>inferred-method-argument|>untyped-method-argument|>typed-getter-argument|>inferred-getter-argument|>untyped-getter-argument)") { Builder = nodes => nodes[0] };
                /* 589 SeqOp            */ __Matchers[589] = new Seq(this, 589, "_('object',?(>member-name),?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectArgument(nodes) };
                /* 590 SeqOp            */ __Matchers[590] = new Seq(this, 590, "_(>method-argument-type,>parametrized-member,>method-definition)") { Builder = nodes => new CTypedMethodArgument(nodes) };
                /* 591 AltOp            */ __Matchers[591] = new Alt(this, 591, "alt(>block|>optional-function-specifier)") { Builder = nodes => nodes[0] };
                /* 592 SeqOp            */ __Matchers[592] = new Seq(this, 592, "_(?(>function-specifier),';')") { Builder = nodes => new COptionalFunctionSpecifier(nodes) };
                /* 593 SeqOp            */ __Matchers[593] = new Seq(this, 593, "_(>function-specifier,';')") { Builder = nodes => new CNeededFunctionSpecifier(nodes) };
                /* 594 AltOp            */ __Matchers[594] = new Alt(this, 594, "alt(>type|>kw-void)") { Builder = nodes => nodes[0] };
                /* 595 SeqOp            */ __Matchers[595] = new Seq(this, 595, "_(>getter-argument-type,>member-name,>method-definition)") { Builder = nodes => new CTypedGetterArgument(nodes) };
                /* 596 SeqOp            */ __Matchers[596] = new Seq(this, 596, "_('function',?(>member-name),?(>type-parameters),>parameters,>method-definition)") { Builder = nodes => new CInferredMethodArgument(nodes) };
                /* 597 SeqOp            */ __Matchers[597] = new Seq(this, 597, "_('value',>member-name,>method-definition)") { Builder = nodes => new CInferredGetterArgument(nodes) };
                /* 598 SeqOp            */ __Matchers[598] = new Seq(this, 598, "_(>member-name,+(>parameters),>needed-function-specifier)") { Builder = nodes => new CUntypedMethodArgument(nodes) };
                /* 599 SeqOp            */ __Matchers[599] = new Seq(this, 599, "_(>member-name,>needed-function-specifier)") { Builder = nodes => new CUntypedGetterArgument(nodes) };
                /* 600 SeqOp            */ __Matchers[600] = new Seq(this, 600, "_('(',?(>sequenced-arguments),')')") { Builder = nodes => new CPositionalArguments(nodes) };
                /* 601 AltOp            */ __Matchers[601] = new Alt(this, 601, "alt(>expression|>declaration-reference)") { Builder = nodes => nodes[0] };
                /* 602 StringOp         */ __Matchers[602] = new String(this, 602, "'*'", "*") { Creator = node => new RString(node) };
                /* 603 SeqOp            */ __Matchers[603] = new Seq(this, 603, "_('*',>union-expression)") { Builder = nodes => new CSpreadArgument(nodes) };
                /* 604 OptionalOp       */ __Matchers[604] = new Optional(this, 604, "?(>let-variable-list)") { Builder = nodes => new ROptional<CLetVariableList>(nodes) };
                /* 605 SeqOp            */ __Matchers[605] = new Seq(this, 605, "_('let','(',?(>let-variable-list),')',>conditional-expression)") { Builder = nodes => new CLetExpression(nodes) };
                /* 606 SeqOp            */ __Matchers[606] = new Seq(this, 606, "_(',',>let-variable)") { Builder = nodes => new RSequence(nodes) };
                /* 607 StarOp           */ __Matchers[607] = new Star(this, 607, "*(_(',',>let-variable))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 608 SeqOp            */ __Matchers[608] = new Seq(this, 608, "_(>let-variable,*(_(',',>let-variable)))") { Builder = nodes => new CLetVariableList(nodes) };
                /* 609 SeqOp            */ __Matchers[609] = new Seq(this, 609, "_(>pattern,>value-specifier)") { Builder = nodes => new CLetVariable(nodes) };
                /* 610 SeqOp            */ __Matchers[610] = new Seq(this, 610, "_(>switch-header,>case-expressions)") { Builder = nodes => new CSwitchExpression(nodes) };
                /* 611 PlusOp           */ __Matchers[611] = new Plus(this, 611, "+(>case-expression)") { Builder = nodes => new RPlus<CCaseExpression>(nodes) };
                /* 612 OptionalOp       */ __Matchers[612] = new Optional(this, 612, "?(>else-expression)") { Builder = nodes => new ROptional<CElseExpression>(nodes) };
                /* 613 SeqOp            */ __Matchers[613] = new Seq(this, 613, "_(+(>case-expression),?(>else-expression))") { Builder = nodes => new CCaseExpressions(nodes) };
                /* 614 StringOp         */ __Matchers[614] = new Keyword(this, 614, "'else'", "else") { Creator = node => new RString(node) };
                /* 615 OptionalOp       */ __Matchers[615] = new Optional(this, 615, "?('else')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 616 StringOp         */ __Matchers[616] = new Keyword(this, 616, "'case'", "case") { Creator = node => new RString(node) };
                /* 617 SeqOp            */ __Matchers[617] = new Seq(this, 617, "_(?('else'),'case','(',>case-item,')',>conditional-expression)") { Builder = nodes => new CCaseExpression(nodes) };
                /* 618 StringOp         */ __Matchers[618] = new Keyword(this, 618, "'if'", "if") { Creator = node => new RString(node) };
                /* 619 SeqOp            */ __Matchers[619] = new Seq(this, 619, "_('if',>conditions,>then-expression,>else-expression)") { Builder = nodes => new CIfExpression(nodes) };
                /* 620 SeqOp            */ __Matchers[620] = new Seq(this, 620, "_('else',>conditional-expression)") { Builder = nodes => new CElseExpression(nodes) };
                /* 621 StringOp         */ __Matchers[621] = new Keyword(this, 621, "'then'", "then") { Creator = node => new RString(node) };
                /* 622 SeqOp            */ __Matchers[622] = new Seq(this, 622, "_('then',>conditional-expression)") { Builder = nodes => new CThenExpression(nodes) };
                /* 623 AltOp            */ __Matchers[623] = new Alt(this, 623, "alt(>if-expression|>let-expression|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 624 OptionalOp       */ __Matchers[624] = new Optional(this, 624, "?(>function-expression-type)") { Builder = nodes => new ROptional<IFunctionExpressionType>(nodes) };
                /* 625 OptionalOp       */ __Matchers[625] = new Optional(this, 625, "?(>function-parameters)") { Builder = nodes => new ROptional<CFunctionParameters>(nodes) };
                /* 626 SeqOp            */ __Matchers[626] = new Seq(this, 626, "_(?(>function-expression-type),?(>type-parameters),?(>function-parameters),>function-definition)") { Builder = nodes => new CFunctionExpression(nodes) };
                /* 627 StringOp         */ __Matchers[627] = new Keyword(this, 627, "'void'", "void") { Creator = node => new CKwVoid(node) };
                /* 628 AltOp            */ __Matchers[628] = new Alt(this, 628, "alt('void'|'function')") { Builder = nodes => nodes[0] };
                /* 629 SeqOp            */ __Matchers[629] = new Seq(this, 629, "_(+(>parameters),?(>type-constraints))") { Builder = nodes => new CFunctionParameters(nodes) };
                /* 630 AltOp            */ __Matchers[630] = new Alt(this, 630, "alt(>block|>function-specifier)") { Builder = nodes => nodes[0] };
                /* 631 AltOp            */ __Matchers[631] = new Alt(this, 631, "alt(>for-comprehension-clause|>if-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 632 AltOp            */ __Matchers[632] = new Alt(this, 632, "alt(>for-comprehension-clause|>if-comprehension-clause|>expression-comprehension-clause)") { Builder = nodes => nodes[0] };
                /* 633 StringOp         */ __Matchers[633] = new Keyword(this, 633, "'for'", "for") { Creator = node => new RString(node) };
                /* 634 OptionalOp       */ __Matchers[634] = new Optional(this, 634, "?(>for-iterator)") { Builder = nodes => new ROptional<CForIterator>(nodes) };
                /* 635 SeqOp            */ __Matchers[635] = new Seq(this, 635, "_('for','(',?(>for-iterator),')',>comprehension-clause)") { Builder = nodes => new CForComprehensionClause(nodes) };
                /* 636 SeqOp            */ __Matchers[636] = new Seq(this, 636, "_('if',>conditions,>comprehension-clause)") { Builder = nodes => new CIfComprehensionClause(nodes) };
                /* 637 AltOp            */ __Matchers[637] = new Alt(this, 637, "alt(>let-expression|>if-expression|>switch-expression|>function-expression|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 638 AltOp            */ __Matchers[638] = new Alt(this, 638, "alt(>assignment|>then-else-expression)") { Builder = nodes => nodes[0] };
                /* 639 SeqOp            */ __Matchers[639] = new Seq(this, 639, "_(>then-else-expression,>assignment-operator,>expression)") { Builder = nodes => new CAssignment(nodes) };
                /* 640 AltOp            */ __Matchers[640] = new Alt(this, 640, "alt(>then-else|>disjunction-expression)") { Builder = nodes => nodes[0] };
                /* 641 SeqOp            */ __Matchers[641] = new Seq(this, 641, "_(>then-else-expression,>then-else-operator,>disjunction-expression)") { Builder = nodes => new CThenElse(nodes) };
                /* 642 AltOp            */ __Matchers[642] = new Alt(this, 642, "alt('else'|'then')") { Builder = nodes => nodes[0] };
                /* 643 AltOp            */ __Matchers[643] = new Alt(this, 643, "alt(>disjunction|>conjunction-expression)") { Builder = nodes => nodes[0] };
                /* 644 SeqOp            */ __Matchers[644] = new Seq(this, 644, "_(>disjunction-expression,>disjunction-operator,>conjunction-expression)") { Builder = nodes => new CDisjunction(nodes) };
                /* 645 StringOp         */ __Matchers[645] = new String(this, 645, "'||'", "||") { Creator = node => new CDisjunctionOperator(node) };
                /* 646 AltOp            */ __Matchers[646] = new Alt(this, 646, "alt(>conjunction|>logical-negation-expression)") { Builder = nodes => nodes[0] };
                /* 647 SeqOp            */ __Matchers[647] = new Seq(this, 647, "_(>conjunction-expression,>conjunction-operator,>logical-negation-expression)") { Builder = nodes => new CConjunction(nodes) };
                /* 648 StringOp         */ __Matchers[648] = new String(this, 648, "'&&'", "&&") { Creator = node => new CConjunctionOperator(node) };
                /* 649 AltOp            */ __Matchers[649] = new Alt(this, 649, "alt(>logical-negation|>expression-or-meta)") { Builder = nodes => nodes[0] };
                /* 650 SeqOp            */ __Matchers[650] = new Seq(this, 650, "_(>not-operator,>logical-negation-expression)") { Builder = nodes => new CLogicalNegation(nodes) };
                /* 651 StringOp         */ __Matchers[651] = new String(this, 651, "'!'", "!") { Creator = node => new CNotOperator(node) };
                /* 652 AltOp            */ __Matchers[652] = new Alt(this, 652, "alt(>equality-expression|>model-reference)") { Builder = nodes => nodes[0] };
                /* 653 AltOp            */ __Matchers[653] = new Alt(this, 653, "alt(>equality|>comparison-expression)") { Builder = nodes => nodes[0] };
                /* 654 SeqOp            */ __Matchers[654] = new Seq(this, 654, "_(>comparison-expression,>equality-operator,>comparison-expression)") { Builder = nodes => new CEquality(nodes) };
                /* 655 StringOp         */ __Matchers[655] = new String(this, 655, "'=='", "==") { Creator = node => new RString(node) };
                /* 656 StringOp         */ __Matchers[656] = new String(this, 656, "'!='", "!=") { Creator = node => new RString(node) };
                /* 657 StringOp         */ __Matchers[657] = new String(this, 657, "'==='", "===") { Creator = node => new RString(node) };
                /* 658 AltOp            */ __Matchers[658] = new Alt(this, 658, "alt('=='|'!='|'===')") { Builder = nodes => nodes[0] };
                /* 659 AltOp            */ __Matchers[659] = new Alt(this, 659, "alt(>comparison-expr|>larger-expr|>smaller-expr|>larger-bounds-expr|>smaller-bounds-expr|>typecheck-expr|>exists-nonempty-expression)") { Builder = nodes => nodes[0] };
                /* 660 SeqOp            */ __Matchers[660] = new Seq(this, 660, "_(>exists-nonempty-expression,>comparison-operator,>exists-nonempty-expression)") { Builder = nodes => new CComparisonExpr(nodes) };
                /* 661 SeqOp            */ __Matchers[661] = new Seq(this, 661, "_(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerExpr(nodes) };
                /* 662 SeqOp            */ __Matchers[662] = new Seq(this, 662, "_(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerExpr(nodes) };
                /* 663 SeqOp            */ __Matchers[663] = new Seq(this, 663, "_(>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression,>larger-operator,>exists-nonempty-expression)") { Builder = nodes => new CLargerBoundsExpr(nodes) };
                /* 664 SeqOp            */ __Matchers[664] = new Seq(this, 664, "_(>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression,>smaller-operator,>exists-nonempty-expression)") { Builder = nodes => new CSmallerBoundsExpr(nodes) };
                /* 665 SeqOp            */ __Matchers[665] = new Seq(this, 665, "_(>exists-nonempty-expression,>type-operator,>type)") { Builder = nodes => new CTypecheckExpr(nodes) };
                /* 666 StringOp         */ __Matchers[666] = new String(this, 666, "'<=>'", "<=>") { Creator = node => new RString(node) };
                /* 667 AltOp            */ __Matchers[667] = new Alt(this, 667, "alt('<=>'|'in')") { Builder = nodes => nodes[0] };
                /* 668 StringOp         */ __Matchers[668] = new String(this, 668, "'<='", "<=") { Creator = node => new RString(node) };
                /* 669 AltOp            */ __Matchers[669] = new Alt(this, 669, "alt('<='|'<')") { Builder = nodes => nodes[0] };
                /* 670 StringOp         */ __Matchers[670] = new String(this, 670, "'>='", ">=") { Creator = node => new RString(node) };
                /* 671 AltOp            */ __Matchers[671] = new Alt(this, 671, "alt('>='|'>')") { Builder = nodes => nodes[0] };
                /* 672 StringOp         */ __Matchers[672] = new Keyword(this, 672, "'is'", "is") { Creator = node => new RString(node) };
                /* 673 AltOp            */ __Matchers[673] = new Alt(this, 673, "alt('is'|'extends'|'satisfies'|'of')") { Builder = nodes => nodes[0] };
                /* 674 AltOp            */ __Matchers[674] = new Alt(this, 674, "alt(>exists-expression|>nonempty-expression|>entry-range-expression)") { Builder = nodes => nodes[0] };
                /* 675 StringOp         */ __Matchers[675] = new Keyword(this, 675, "'exists'", "exists") { Creator = node => new RString(node) };
                /* 676 SeqOp            */ __Matchers[676] = new Seq(this, 676, "_(>entry-range-expression,'exists')") { Builder = nodes => new CExistsExpression(nodes) };
                /* 677 StringOp         */ __Matchers[677] = new Keyword(this, 677, "'nonempty'", "nonempty") { Creator = node => new RString(node) };
                /* 678 SeqOp            */ __Matchers[678] = new Seq(this, 678, "_(>entry-range-expression,'nonempty')") { Builder = nodes => new CNonemptyExpression(nodes) };
                /* 679 AltOp            */ __Matchers[679] = new Alt(this, 679, "alt(>entry-or-range|>additive-expression)") { Builder = nodes => nodes[0] };
                /* 680 SeqOp            */ __Matchers[680] = new Seq(this, 680, "_(>additive-expression,>range-or-entry-operator,>additive-expression)") { Builder = nodes => new CEntryOrRange(nodes) };
                /* 681 StringOp         */ __Matchers[681] = new String(this, 681, "'..'", "..") { Creator = node => new RString(node) };
                /* 682 AltOp            */ __Matchers[682] = new Alt(this, 682, "alt('..'|':'|'->')") { Builder = nodes => nodes[0] };
                /* 683 AltOp            */ __Matchers[683] = new Alt(this, 683, "alt(>additive-expr|>scale-expression)") { Builder = nodes => nodes[0] };
                /* 684 SeqOp            */ __Matchers[684] = new Seq(this, 684, "_(>additive-expression,>additive-operator,>scale-expression)") { Builder = nodes => new CAdditiveExpr(nodes) };
                /* 685 StringOp         */ __Matchers[685] = new String(this, 685, "'+'", "+") { Creator = node => new RString(node) };
                /* 686 StringOp         */ __Matchers[686] = new String(this, 686, "'-'", "-") { Creator = node => new RString(node) };
                /* 687 AltOp            */ __Matchers[687] = new Alt(this, 687, "alt('+'|'-')") { Builder = nodes => nodes[0] };
                /* 688 AltOp            */ __Matchers[688] = new Alt(this, 688, "alt(>scale-expr|>multiplicative-expression)") { Builder = nodes => nodes[0] };
                /* 689 SeqOp            */ __Matchers[689] = new Seq(this, 689, "_(>multiplicative-expression,>scale-operator,>scale-expression)") { Builder = nodes => new CScaleExpr(nodes) };
                /* 690 StringOp         */ __Matchers[690] = new String(this, 690, "'**'", "**") { Creator = node => new CScaleOperator(node) };
                /* 691 AltOp            */ __Matchers[691] = new Alt(this, 691, "alt(>multiplicative-expr|>union-expression)") { Builder = nodes => nodes[0] };
                /* 692 SeqOp            */ __Matchers[692] = new Seq(this, 692, "_(>multiplicative-expression,>multiplicative-operator,>union-expression)") { Builder = nodes => new CMultiplicativeExpr(nodes) };
                /* 693 StringOp         */ __Matchers[693] = new String(this, 693, "'/'", "/") { Creator = node => new RString(node) };
                /* 694 StringOp         */ __Matchers[694] = new String(this, 694, "'%'", "%") { Creator = node => new RString(node) };
                /* 695 AltOp            */ __Matchers[695] = new Alt(this, 695, "alt('*'|'/'|'%')") { Builder = nodes => nodes[0] };
                /* 696 AltOp            */ __Matchers[696] = new Alt(this, 696, "alt(>union-expr|>exclusive-expression)") { Builder = nodes => nodes[0] };
                /* 697 SeqOp            */ __Matchers[697] = new Seq(this, 697, "_(>union-expression,>union-operator,>exclusive-expression)") { Builder = nodes => new CUnionExpr(nodes) };
                /* 698 StringOp         */ __Matchers[698] = new String(this, 698, "'~'", "~") { Creator = node => new COpComplement(node) };
                /* 699 AltOp            */ __Matchers[699] = new Alt(this, 699, "alt('|'|'~')") { Builder = nodes => nodes[0] };
                /* 700 AltOp            */ __Matchers[700] = new Alt(this, 700, "alt(>exclusive-expr|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 701 SeqOp            */ __Matchers[701] = new Seq(this, 701, "_(>exclusive-expression,>exclusive-operator,>intersection-expression)") { Builder = nodes => new CExclusiveExpr(nodes) };
                /* 702 StringOp         */ __Matchers[702] = new String(this, 702, "'^'", "^") { Creator = node => new CExclusiveOperator(node) };
                /* 703 AltOp            */ __Matchers[703] = new Alt(this, 703, "alt(>intersection-expr|>negation-or-complement-expression)") { Builder = nodes => nodes[0] };
                /* 704 SeqOp            */ __Matchers[704] = new Seq(this, 704, "_(>intersection-expression,>intersection-operator,>negation-or-complement-expression)") { Builder = nodes => new CIntersectionExpr(nodes) };
                /* 705 StringOp         */ __Matchers[705] = new String(this, 705, "'&'", "&") { Creator = node => new CIntersectionOperator(node) };
                /* 706 AltOp            */ __Matchers[706] = new Alt(this, 706, "alt(>negation-or-complement-expr|>prefix-expression)") { Builder = nodes => nodes[0] };
                /* 707 SeqOp            */ __Matchers[707] = new Seq(this, 707, "_(>unary-minus-or-complement-operator,>negation-or-complement-expression)") { Builder = nodes => new CNegationOrComplementExpr(nodes) };
                /* 708 AltOp            */ __Matchers[708] = new Alt(this, 708, "alt(>op-negate|>op-neutral|>op-complement)") { Builder = nodes => nodes[0] };
                /* 709 NotOp            */ __Matchers[709] = new Not(this, 709, "!('-')") { Builder = nodes => new RNot<RString>(nodes) };
                /* 710 SeqOp            */ __Matchers[710] = new Seq(this, 710, "_('-',!('-'))") { Builder = nodes => new COpNegate(nodes) };
                /* 711 NotOp            */ __Matchers[711] = new Not(this, 711, "!('+')") { Builder = nodes => new RNot<RString>(nodes) };
                /* 712 SeqOp            */ __Matchers[712] = new Seq(this, 712, "_('+',!('+'))") { Builder = nodes => new COpNeutral(nodes) };
                /* 713 AltOp            */ __Matchers[713] = new Alt(this, 713, "alt(>prefix-expr|>postfix-expression)") { Builder = nodes => nodes[0] };
                /* 714 SeqOp            */ __Matchers[714] = new Seq(this, 714, "_(>increment-operator,>prefix-expression)") { Builder = nodes => new CPrefixExpr(nodes) };
                /* 715 AltOp            */ __Matchers[715] = new Alt(this, 715, "alt(>postfix-expr|>primary)") { Builder = nodes => nodes[0] };
                /* 716 SeqOp            */ __Matchers[716] = new Seq(this, 716, "_(>postfix-expression,>increment-operator)") { Builder = nodes => new CPostfixExpr(nodes) };
                /* 717 StringOp         */ __Matchers[717] = new String(this, 717, "'++'", "++") { Creator = node => new RString(node) };
                /* 718 StringOp         */ __Matchers[718] = new String(this, 718, "'--'", "--") { Creator = node => new RString(node) };
                /* 719 AltOp            */ __Matchers[719] = new Alt(this, 719, "alt('++'|'--')") { Builder = nodes => nodes[0] };
                /* 720 AltOp            */ __Matchers[720] = new Alt(this, 720, "alt(>selection-expression|>indexed-expression|>call-expression|>base-expression)") { Builder = nodes => nodes[0] };
                /* 721 SeqOp            */ __Matchers[721] = new Seq(this, 721, "_(>primary,>qualified-reference)") { Builder = nodes => new CSelectionExpression(nodes) };
                /* 722 SeqOp            */ __Matchers[722] = new Seq(this, 722, "_(>member-selection-operator,>base-reference)") { Builder = nodes => new CQualifiedReference(nodes) };
                /* 723 StringOp         */ __Matchers[723] = new String(this, 723, "'?.'", "?.") { Creator = node => new RString(node) };
                /* 724 StringOp         */ __Matchers[724] = new String(this, 724, "'*.'", "*.") { Creator = node => new RString(node) };
                /* 725 AltOp            */ __Matchers[725] = new Alt(this, 725, "alt('.'|'?.'|'*.')") { Builder = nodes => nodes[0] };
                /* 726 SeqOp            */ __Matchers[726] = new Seq(this, 726, "_(>primary,'[',>index,']')") { Builder = nodes => new CIndexedExpression(nodes) };
                /* 727 AltOp            */ __Matchers[727] = new Alt(this, 727, "alt(>lower-spanned|>upper-spanned|>spanned|>measured|>expression)") { Builder = nodes => nodes[0] };
                /* 728 SeqOp            */ __Matchers[728] = new Seq(this, 728, "_(>index-expression,'...')") { Builder = nodes => new CUpperSpanned(nodes) };
                /* 729 SeqOp            */ __Matchers[729] = new Seq(this, 729, "_('...',>index-expression)") { Builder = nodes => new CLowerSpanned(nodes) };
                /* 730 SeqOp            */ __Matchers[730] = new Seq(this, 730, "_(>index-expression,'..',>index-expression)") { Builder = nodes => new CSpanned(nodes) };
                /* 731 SeqOp            */ __Matchers[731] = new Seq(this, 731, "_(>index-expression,':',>index-expression)") { Builder = nodes => new CMeasured(nodes) };
                /* 732 SeqOp            */ __Matchers[732] = new Seq(this, 732, "_(>primary,>arguments)") { Builder = nodes => new CCallExpression(nodes) };
                /* 733 AltOp            */ __Matchers[733] = new Alt(this, 733, "alt(>nonstring-literal|>string-expression|>meta-literal|>enumeration|>tuple|>object-expression|>grouped-expression|>base-reference-or-parameterized)") { Builder = nodes => nodes[0] };
                /* 734 AltOp            */ __Matchers[734] = new Alt(this, 734, "alt(>literal-natural|>literal-float|>literal-char)") { Builder = nodes => nodes[0] };
                /* 735 AltOp            */ __Matchers[735] = new Alt(this, 735, "alt(>string-literal|>string-interpolation)") { Builder = nodes => nodes[0] };
                /* 736 StarOp           */ __Matchers[736] = new Star(this, 736, "*(>interpolation-part)") { Builder = nodes => new RStar<CInterpolationPart>(nodes) };
                /* 737 SeqOp            */ __Matchers[737] = new Seq(this, 737, "_(>string-start,>expression,*(>interpolation-part),>string-end)") { Builder = nodes => new CStringInterpolation(nodes) };
                /* 738 SeqOp            */ __Matchers[738] = new Seq(this, 738, "_(>string-mid,>expression)") { Builder = nodes => new CInterpolationPart(nodes) };
                /* 739 AltOp            */ __Matchers[739] = new Alt(this, 739, "alt(>literal-string|>verbatim-string)") { Builder = nodes => nodes[0] };
                /* 740 SeqOp            */ __Matchers[740] = new Seq(this, 740, "_('object',?(>extended-type),?(>satisfied-types),>class-block)") { Builder = nodes => new CObjectExpression(nodes) };
                /* 741 SeqOp            */ __Matchers[741] = new Seq(this, 741, "_('(',>expression,')')") { Builder = nodes => new CGroupedExpression(nodes) };
                /* 742 OptionalOp       */ __Matchers[742] = new Optional(this, 742, "?(>type-argument-list)") { Builder = nodes => new ROptional<CTypeArgumentList>(nodes) };
                /* 743 SeqOp            */ __Matchers[743] = new Seq(this, 743, "_('<',?(>type-argument-list),'>')") { Builder = nodes => new CTypeArguments(nodes) };
                /* 744 SeqOp            */ __Matchers[744] = new Seq(this, 744, "_(',',>varianced-type)") { Builder = nodes => new RSequence(nodes) };
                /* 745 StarOp           */ __Matchers[745] = new Star(this, 745, "*(_(',',>varianced-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 746 SeqOp            */ __Matchers[746] = new Seq(this, 746, "_(>varianced-type,*(_(',',>varianced-type)))") { Builder = nodes => new CTypeArgumentList(nodes) };
                /* 747 SeqOp            */ __Matchers[747] = new Seq(this, 747, "_(?(>variance),>type)") { Builder = nodes => new CVariancedType(nodes) };
                /* 748 SeqOp            */ __Matchers[748] = new Seq(this, 748, "_(',',>defaulted-type)") { Builder = nodes => new RSequence(nodes) };
                /* 749 StarOp           */ __Matchers[749] = new Star(this, 749, "*(_(',',>defaulted-type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 750 SeqOp            */ __Matchers[750] = new Seq(this, 750, "_(>defaulted-type,*(_(',',>defaulted-type)))") { Builder = nodes => new CDefaultedTypeList(nodes) };
                /* 751 AltOp            */ __Matchers[751] = new Alt(this, 751, "alt(>defaulted-type-core|>variadic-type)") { Builder = nodes => nodes[0] };
                /* 752 SeqOp            */ __Matchers[752] = new Seq(this, 752, "_(>type,'=')") { Builder = nodes => new CDefaultedTypeCore(nodes) };
                /* 753 AltOp            */ __Matchers[753] = new Alt(this, 753, "alt(>variadic-union-type|>type)") { Builder = nodes => nodes[0] };
                /* 754 SeqOp            */ __Matchers[754] = new Seq(this, 754, "_(>union-type,>variadic-operator)") { Builder = nodes => new CVariadicUnionType(nodes) };
                /* 755 AltOp            */ __Matchers[755] = new Alt(this, 755, "alt('*'|'+')") { Builder = nodes => nodes[0] };
                /* 756 SeqOp            */ __Matchers[756] = new Seq(this, 756, "_('*',>union-type)") { Builder = nodes => new CSpreadType(nodes) };
                /* 757 AltOp            */ __Matchers[757] = new Alt(this, 757, "alt(>entry-type|>union-type)") { Builder = nodes => nodes[0] };
                /* 758 SeqOp            */ __Matchers[758] = new Seq(this, 758, "_(>union-type,'->',>union-type)") { Builder = nodes => new CEntryType(nodes) };
                /* 759 AltOp            */ __Matchers[759] = new Alt(this, 759, "alt(>union-type-core|>intersection-type)") { Builder = nodes => nodes[0] };
                /* 760 SeqOp            */ __Matchers[760] = new Seq(this, 760, "_(>union-type,'|',>intersection-type)") { Builder = nodes => new CUnionTypeCore(nodes) };
                /* 761 AltOp            */ __Matchers[761] = new Alt(this, 761, "alt(>intersection-type-core|>primary-type)") { Builder = nodes => nodes[0] };
                /* 762 SeqOp            */ __Matchers[762] = new Seq(this, 762, "_(>intersection-type,'&',>primary-type)") { Builder = nodes => new CIntersectionTypeCore(nodes) };
                /* 763 AltOp            */ __Matchers[763] = new Alt(this, 763, "alt(>nullable-type|>array-type|>function-type|>tuple-type|>iterable-type|>grouped-type|>qualified-type)") { Builder = nodes => nodes[0] };
                /* 764 StringOp         */ __Matchers[764] = new String(this, 764, "'?'", "?") { Creator = node => new RString(node) };
                /* 765 SeqOp            */ __Matchers[765] = new Seq(this, 765, "_(>primary-type,'?')") { Builder = nodes => new CNullableType(nodes) };
                /* 766 OptionalOp       */ __Matchers[766] = new Optional(this, 766, "?(>literal-natural)") { Builder = nodes => new ROptional<CLiteralNatural>(nodes) };
                /* 767 SeqOp            */ __Matchers[767] = new Seq(this, 767, "_(>primary-type,'[',?(>literal-natural),']')") { Builder = nodes => new CArrayType(nodes) };
                /* 768 OptionalOp       */ __Matchers[768] = new Optional(this, 768, "?(>type-type-arguments)") { Builder = nodes => new ROptional<ITypeTypeArguments>(nodes) };
                /* 769 SeqOp            */ __Matchers[769] = new Seq(this, 769, "_(>primary-type,'(',?(>type-type-arguments),')')") { Builder = nodes => new CFunctionType(nodes) };
                /* 770 AltOp            */ __Matchers[770] = new Alt(this, 770, "alt(>spread-type|>defaulted-type-list)") { Builder = nodes => nodes[0] };
                /* 771 SeqOp            */ __Matchers[771] = new Seq(this, 771, "_('[',?(>type-type-arguments),']')") { Builder = nodes => new CTupleType(nodes) };
                /* 772 OptionalOp       */ __Matchers[772] = new Optional(this, 772, "?(>variadic-type)") { Builder = nodes => new ROptional<IVariadicType>(nodes) };
                /* 773 SeqOp            */ __Matchers[773] = new Seq(this, 773, "_('{',?(>variadic-type),'}')") { Builder = nodes => new CIterableType(nodes) };
                /* 774 SeqOp            */ __Matchers[774] = new Seq(this, 774, "_('<',>type,'>')") { Builder = nodes => new CGroupedType(nodes) };
                /* 775 SeqOp            */ __Matchers[775] = new Seq(this, 775, "_(?(>package-qualifier),>type-path)") { Builder = nodes => new CQualifiedType(nodes) };
                /* 776 OptionalOp       */ __Matchers[776] = new Optional(this, 776, "?(>string-literal)") { Builder = nodes => new ROptional<IStringLiteral>(nodes) };
                /* 777 StarOp           */ __Matchers[777] = new Star(this, 777, "*(>annotation)") { Builder = nodes => new RStar<CAnnotation>(nodes) };
                /* 778 SeqOp            */ __Matchers[778] = new Seq(this, 778, "_(?(>string-literal),*(>annotation))") { Builder = nodes => new CAnnotations(nodes) };
                /* 779 SeqOp            */ __Matchers[779] = new Seq(this, 779, "_(>annotation-name,?(>arguments))") { Builder = nodes => new CAnnotation(nodes) };
                /* 780 OptionalOp       */ __Matchers[780] = new Optional(this, 780, "?(>condition-list)") { Builder = nodes => new ROptional<CConditionList>(nodes) };
                /* 781 SeqOp            */ __Matchers[781] = new Seq(this, 781, "_('(',?(>condition-list),')')") { Builder = nodes => new CConditions(nodes) };
                /* 782 SeqOp            */ __Matchers[782] = new Seq(this, 782, "_(',',>condition)") { Builder = nodes => new RSequence(nodes) };
                /* 783 StarOp           */ __Matchers[783] = new Star(this, 783, "*(_(',',>condition))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 784 SeqOp            */ __Matchers[784] = new Seq(this, 784, "_(>condition,*(_(',',>condition)))") { Builder = nodes => new CConditionList(nodes) };
                /* 785 AltOp            */ __Matchers[785] = new Alt(this, 785, "alt(>exists-condition|>nonempty-condition|>is-condition|>satisfies-condition|>boolean-condition)") { Builder = nodes => nodes[0] };
                /* 786 OptionalOp       */ __Matchers[786] = new Optional(this, 786, "?('!')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 787 SeqOp            */ __Matchers[787] = new Seq(this, 787, "_(?('!'),'exists',>let-or-expression)") { Builder = nodes => new CExistsCondition(nodes) };
                /* 788 SeqOp            */ __Matchers[788] = new Seq(this, 788, "_(?('!'),'nonempty',>let-or-expression)") { Builder = nodes => new CNonemptyCondition(nodes) };
                /* 789 AltOp            */ __Matchers[789] = new Alt(this, 789, "alt(>let-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 790 SeqOp            */ __Matchers[790] = new Seq(this, 790, "_(?('!'),'is',>type,>is-condition-variable)") { Builder = nodes => new CIsCondition(nodes) };
                /* 791 SeqOp            */ __Matchers[791] = new Seq(this, 791, "_('satisfies',>type,>type-name)") { Builder = nodes => new CSatisfiesCondition(nodes) };
                /* 792 AltOp            */ __Matchers[792] = new Alt(this, 792, "alt(>if-else|>switch-case-else|>while-loop|>for-else|>try-catch-finally)") { Builder = nodes => nodes[0] };
                /* 793 OptionalOp       */ __Matchers[793] = new Optional(this, 793, "?(>else-block)") { Builder = nodes => new ROptional<CElseBlock>(nodes) };
                /* 794 SeqOp            */ __Matchers[794] = new Seq(this, 794, "_(>if-block,?(>else-block))") { Builder = nodes => new CIfElse(nodes) };
                /* 795 SeqOp            */ __Matchers[795] = new Seq(this, 795, "_('if',>conditions,>block)") { Builder = nodes => new CIfBlock(nodes) };
                /* 796 SeqOp            */ __Matchers[796] = new Seq(this, 796, "_('else',>else-block-next)") { Builder = nodes => new CElseBlock(nodes) };
                /* 797 AltOp            */ __Matchers[797] = new Alt(this, 797, "alt(>if-else|>block)") { Builder = nodes => nodes[0] };
                /* 798 PlusOp           */ __Matchers[798] = new Plus(this, 798, "+(>case-block)") { Builder = nodes => new RPlus<CCaseBlock>(nodes) };
                /* 799 SeqOp            */ __Matchers[799] = new Seq(this, 799, "_(>switch-header,+(>case-block),?(>else-block))") { Builder = nodes => new CSwitchCaseElse(nodes) };
                /* 800 StringOp         */ __Matchers[800] = new Keyword(this, 800, "'switch'", "switch") { Creator = node => new RString(node) };
                /* 801 SeqOp            */ __Matchers[801] = new Seq(this, 801, "_('switch','(',>switched,')')") { Builder = nodes => new CSwitchHeader(nodes) };
                /* 802 SeqOp            */ __Matchers[802] = new Seq(this, 802, "_(?('else'),'case','(',>case-item,')',>block)") { Builder = nodes => new CCaseBlock(nodes) };
                /* 803 AltOp            */ __Matchers[803] = new Alt(this, 803, "alt(>is-case-condition|>satisfies-case-condition|>match-case-condition|>pattern)") { Builder = nodes => nodes[0] };
                /* 804 OptionalOp       */ __Matchers[804] = new Optional(this, 804, "?('is')") { Builder = nodes => new ROptional<RString>(nodes) };
                /* 805 SeqOp            */ __Matchers[805] = new Seq(this, 805, "_(?('is'),>type)") { Builder = nodes => new CIsCaseCondition(nodes) };
                /* 806 SeqOp            */ __Matchers[806] = new Seq(this, 806, "_('satisfies',>type)") { Builder = nodes => new CSatisfiesCaseCondition(nodes) };
                /* 807 SeqOp            */ __Matchers[807] = new Seq(this, 807, "_(>value-case-separator,>value-case)") { Builder = nodes => new RSequence(nodes) };
                /* 808 StarOp           */ __Matchers[808] = new Star(this, 808, "*(_(>value-case-separator,>value-case))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 809 SeqOp            */ __Matchers[809] = new Seq(this, 809, "_(>value-case,*(_(>value-case-separator,>value-case)))") { Builder = nodes => new CValueCaseList(nodes) };
                /* 810 AltOp            */ __Matchers[810] = new Alt(this, 810, "alt(','|'|')") { Builder = nodes => nodes[0] };
                /* 811 AltOp            */ __Matchers[811] = new Alt(this, 811, "alt(>intersection-type|>intersection-expression)") { Builder = nodes => nodes[0] };
                /* 812 OptionalOp       */ __Matchers[812] = new Optional(this, 812, "?(>fail-block)") { Builder = nodes => new ROptional<CFailBlock>(nodes) };
                /* 813 SeqOp            */ __Matchers[813] = new Seq(this, 813, "_(>for-block,?(>fail-block))") { Builder = nodes => new CForElse(nodes) };
                /* 814 SeqOp            */ __Matchers[814] = new Seq(this, 814, "_('for','(',?(>for-iterator),')',>block)") { Builder = nodes => new CForBlock(nodes) };
                /* 815 SeqOp            */ __Matchers[815] = new Seq(this, 815, "_('else',>block)") { Builder = nodes => new CFailBlock(nodes) };
                /* 816 OptionalOp       */ __Matchers[816] = new Optional(this, 816, "?(>containment)") { Builder = nodes => new ROptional<CContainment>(nodes) };
                /* 817 SeqOp            */ __Matchers[817] = new Seq(this, 817, "_(>for-variable,?(>containment))") { Builder = nodes => new CForIterator(nodes) };
                /* 818 AltOp            */ __Matchers[818] = new Alt(this, 818, "alt(>tuple-or-entry-pattern|>variable)") { Builder = nodes => nodes[0] };
                /* 819 SeqOp            */ __Matchers[819] = new Seq(this, 819, "_(>containment-operator,>operator-expression)") { Builder = nodes => new CContainment(nodes) };
                /* 820 AltOp            */ __Matchers[820] = new Alt(this, 820, "alt('in'|':')") { Builder = nodes => nodes[0] };
                /* 821 StringOp         */ __Matchers[821] = new Keyword(this, 821, "'while'", "while") { Creator = node => new RString(node) };
                /* 822 SeqOp            */ __Matchers[822] = new Seq(this, 822, "_('while',>conditions,>block)") { Builder = nodes => new CWhileBlock(nodes) };
                /* 823 StarOp           */ __Matchers[823] = new Star(this, 823, "*(>catch-block)") { Builder = nodes => new RStar<CCatchBlock>(nodes) };
                /* 824 OptionalOp       */ __Matchers[824] = new Optional(this, 824, "?(>finally-block)") { Builder = nodes => new ROptional<CFinallyBlock>(nodes) };
                /* 825 SeqOp            */ __Matchers[825] = new Seq(this, 825, "_(>try-block,*(>catch-block),?(>finally-block))") { Builder = nodes => new CTryCatchFinally(nodes) };
                /* 826 StringOp         */ __Matchers[826] = new Keyword(this, 826, "'try'", "try") { Creator = node => new RString(node) };
                /* 827 OptionalOp       */ __Matchers[827] = new Optional(this, 827, "?(>resources)") { Builder = nodes => new ROptional<CResources>(nodes) };
                /* 828 SeqOp            */ __Matchers[828] = new Seq(this, 828, "_('try',?(>resources),>block)") { Builder = nodes => new CTryBlock(nodes) };
                /* 829 StringOp         */ __Matchers[829] = new Keyword(this, 829, "'catch'", "catch") { Creator = node => new RString(node) };
                /* 830 SeqOp            */ __Matchers[830] = new Seq(this, 830, "_('catch',>catch-variable,>block)") { Builder = nodes => new CCatchBlock(nodes) };
                /* 831 OptionalOp       */ __Matchers[831] = new Optional(this, 831, "?(>variable)") { Builder = nodes => new ROptional<CVariable>(nodes) };
                /* 832 SeqOp            */ __Matchers[832] = new Seq(this, 832, "_('(',?(>variable),')')") { Builder = nodes => new CCatchVariable(nodes) };
                /* 833 StringOp         */ __Matchers[833] = new Keyword(this, 833, "'finally'", "finally") { Creator = node => new RString(node) };
                /* 834 SeqOp            */ __Matchers[834] = new Seq(this, 834, "_('finally',>block)") { Builder = nodes => new CFinallyBlock(nodes) };
                /* 835 OptionalOp       */ __Matchers[835] = new Optional(this, 835, "?(>resource-list)") { Builder = nodes => new ROptional<CResourceList>(nodes) };
                /* 836 SeqOp            */ __Matchers[836] = new Seq(this, 836, "_('(',?(>resource-list),')')") { Builder = nodes => new CResources(nodes) };
                /* 837 SeqOp            */ __Matchers[837] = new Seq(this, 837, "_(',',>resource)") { Builder = nodes => new RSequence(nodes) };
                /* 838 StarOp           */ __Matchers[838] = new Star(this, 838, "*(_(',',>resource))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 839 SeqOp            */ __Matchers[839] = new Seq(this, 839, "_(>resource,*(_(',',>resource)))") { Builder = nodes => new CResourceList(nodes) };
                /* 840 AltOp            */ __Matchers[840] = new Alt(this, 840, "alt(>specified-variable|>operator-expression)") { Builder = nodes => nodes[0] };
                /* 841 SeqOp            */ __Matchers[841] = new Seq(this, 841, "_(>variable,>value-specifier)") { Builder = nodes => new CSpecifiedVariable(nodes) };
                /* 842 OptionalOp       */ __Matchers[842] = new Optional(this, 842, "?(>variable-type)") { Builder = nodes => new ROptional<IVariableType>(nodes) };
                /* 843 StarOp           */ __Matchers[843] = new Star(this, 843, "*(>parameters)") { Builder = nodes => new RStar<CParameters>(nodes) };
                /* 844 SeqOp            */ __Matchers[844] = new Seq(this, 844, "_(?(>variable-type),>member-name,*(>parameters))") { Builder = nodes => new CVariable(nodes) };
                /* 845 AltOp            */ __Matchers[845] = new Alt(this, 845, "alt(>type|>kw-void|>kw-function|>kw-value)") { Builder = nodes => nodes[0] };
                /* 846 SeqOp            */ __Matchers[846] = new Seq(this, 846, "_('^',>model-expression)") { Builder = nodes => new CModelReference(nodes) };
                /* 847 StringOp         */ __Matchers[847] = new String(this, 847, "'`'", "`") { Creator = node => new RString(node) };
                /* 848 SeqOp            */ __Matchers[848] = new Seq(this, 848, "_('`',>meta-expression,'`')") { Builder = nodes => new CMetaLiteral(nodes) };
                /* 849 AltOp            */ __Matchers[849] = new Alt(this, 849, "alt(>declaration-reference|>model-expression)") { Builder = nodes => nodes[0] };
                /* 850 AltOp            */ __Matchers[850] = new Alt(this, 850, "alt(>member-model-expression|>type-model-expression)") { Builder = nodes => nodes[0] };
                /* 851 AltOp            */ __Matchers[851] = new Alt(this, 851, "alt(>member-reference|>package-qualified-member-reference|>type-qualified-member-reference)") { Builder = nodes => nodes[0] };
                /* 852 SeqOp            */ __Matchers[852] = new Seq(this, 852, "_(>package-qualifier,>member-reference)") { Builder = nodes => new CPackageQualifiedMemberReference(nodes) };
                /* 853 SeqOp            */ __Matchers[853] = new Seq(this, 853, "_(>primary-type,'.',>member-reference)") { Builder = nodes => new CTypeQualifiedMemberReference(nodes) };
                /* 854 AltOp            */ __Matchers[854] = new Alt(this, 854, "alt(>module-literal|>package-literal|>class-literal|>new-literal|>interface-literal|>alias-literal|>type-parameter-literal|>value-literal|>function-literal)") { Builder = nodes => nodes[0] };
                /* 855 OptionalOp       */ __Matchers[855] = new Optional(this, 855, "?(>package-path)") { Builder = nodes => new ROptional<CPackagePath>(nodes) };
                /* 856 SeqOp            */ __Matchers[856] = new Seq(this, 856, "_('module',?(>package-path))") { Builder = nodes => new CModuleLiteral(nodes) };
                /* 857 SeqOp            */ __Matchers[857] = new Seq(this, 857, "_('package',?(>package-path))") { Builder = nodes => new CPackageLiteral(nodes) };
                /* 858 SeqOp            */ __Matchers[858] = new Seq(this, 858, "_('class',>reference-path)") { Builder = nodes => new CClassLiteral(nodes) };
                /* 859 SeqOp            */ __Matchers[859] = new Seq(this, 859, "_('interface',>reference-path)") { Builder = nodes => new CInterfaceLiteral(nodes) };
                /* 860 SeqOp            */ __Matchers[860] = new Seq(this, 860, "_('alias',>reference-path)") { Builder = nodes => new CAliasLiteral(nodes) };
                /* 861 SeqOp            */ __Matchers[861] = new Seq(this, 861, "_('given',>reference-path)") { Builder = nodes => new CTypeParameterLiteral(nodes) };
                /* 862 SeqOp            */ __Matchers[862] = new Seq(this, 862, "_('new',>reference-path)") { Builder = nodes => new CNewLiteral(nodes) };
                /* 863 SeqOp            */ __Matchers[863] = new Seq(this, 863, "_(>value-literal-intro,>reference-path)") { Builder = nodes => new CValueLiteral(nodes) };
                /* 864 AltOp            */ __Matchers[864] = new Alt(this, 864, "alt('value'|'object')") { Builder = nodes => nodes[0] };
                /* 865 SeqOp            */ __Matchers[865] = new Seq(this, 865, "_('function',>reference-path)") { Builder = nodes => new CFunctionLiteral(nodes) };
                /* 866 SeqOp            */ __Matchers[866] = new Seq(this, 866, "_(?(>package-qualifier),>reference-path-element-list)") { Builder = nodes => new CReferencePath(nodes) };
                /* 867 SeqOp            */ __Matchers[867] = new Seq(this, 867, "_('.',>reference-path-element)") { Builder = nodes => new RSequence(nodes) };
                /* 868 StarOp           */ __Matchers[868] = new Star(this, 868, "*(_('.',>reference-path-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 869 SeqOp            */ __Matchers[869] = new Seq(this, 869, "_(>reference-path-element,*(_('.',>reference-path-element)))") { Builder = nodes => new CReferencePathElementList(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[372]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[373]);
                /*   4 PlainRuleOp      */ _unitElements.Set(__Matchers[374]);
                /*   5 PlainRuleOp      */ _unitElement.Set(__Matchers[375]);
                /*   6 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[379]);
                /*   7 PlainRuleOp      */ _moduleSpecifier.Set(__Matchers[382]);
                /*   8 PlainRuleOp      */ _repository.Set(_anyName);
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
                /*  24 PlainRuleOp      */ _importNameSpecifier.Set(__Matchers[409]);
                /*  25 PlainRuleOp      */ _importWildcard.Set(__Matchers[410]);
                /*  26 PlainRuleOp      */ _importName.Set(_anyName);
                /*  27 PlainRuleOp      */ _packagePath.Set(__Matchers[414]);
                /*  28 PlainRuleOp      */ _anyName.Set(__Matchers[415]);
                /*  29 PlainRuleOp      */ _packageName.Set(_anyName);
                /*  30 PlainRuleOp      */ _annotationName.Set(_lowerIdentifier);
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
                /*  41 PlainRuleOp      */ _variadicVariable.Set(__Matchers[431]);
                /*  42 PlainRuleOp      */ _letStatement.Set(__Matchers[435]);
                /*  43 PlainRuleOp      */ _delegatedConstructor.Set(__Matchers[437]);
                /*  44 PlainRuleOp      */ _assertionStatement.Set(__Matchers[440]);
                /*  45 PlainRuleOp      */ _assertionMessage.Set(_stringExpression);
                /*  46 PlainRuleOp      */ _block.Set(_blockElements);
                /*  47 PlainRuleOp      */ _interfaceBlock.Set(_blockElements);
                /*  48 PlainRuleOp      */ _classBlock.Set(_blockElements);
                /*  49 PlainRuleOp      */ _blockElements.Set(__Matchers[442]);
                /*  50 PlainRuleOp      */ _blockElement.Set(__Matchers[443]);
                /*  51 PlainRuleOp      */ _extendedType.Set(__Matchers[437]);
                /*  52 PlainRuleOp      */ _classSpecifier.Set(__Matchers[445]);
                /*  53 PlainRuleOp      */ _classInstatiation.Set(__Matchers[447]);
                /*  54 PlainRuleOp      */ _qualifiedClass.Set(__Matchers[448]);
                /*  55 PlainRuleOp      */ _superQualifiedClass.Set(__Matchers[449]);
                /*  56 PlainRuleOp      */ _superQualifier.Set(__Matchers[451]);
                /*  57 PlainRuleOp      */ _packageQualifiedClass.Set(__Matchers[452]);
                /*  58 PlainRuleOp      */ _packageQualifier.Set(__Matchers[453]);
                /*  59 PlainRuleOp      */ _unQualifiedClass.Set(__Matchers[454]);
                /*  60 PlainRuleOp      */ _memberPath.Set(__Matchers[455]);
                /*  61 PlainRuleOp      */ _typePath.Set(__Matchers[458]);
                /*  62 PlainRuleOp      */ _satisfiedTypes.Set(__Matchers[460]);
                /*  63 PlainRuleOp      */ _unionTypeList.Set(__Matchers[463]);
                /*  64 PlainRuleOp      */ _caseTypes.Set(__Matchers[465]);
                /*  65 PlainRuleOp      */ _caseTypeList.Set(__Matchers[469]);
                /*  66 PlainRuleOp      */ _caseType.Set(__Matchers[470]);
                /*  67 PlainRuleOp      */ _qualifiedCaseType.Set(__Matchers[472]);
                /*  68 PlainRuleOp      */ _parameters.Set(__Matchers[474]);
                /*  69 PlainRuleOp      */ _parameterList.Set(__Matchers[477]);
                /*  70 PlainRuleOp      */ _parameterDeclarationOrRefPattern.Set(__Matchers[478]);
                /*  71 PlainRuleOp      */ _parameterDeclarationOrRef.Set(__Matchers[479]);
                /*  72 PlainRuleOp      */ _parameter.Set(__Matchers[480]);
                /*  73 PlainRuleOp      */ _parameterReference.Set(__Matchers[482]);
                /*  74 PlainRuleOp      */ _parameterDeclaration.Set(__Matchers[483]);
                /*  75 PlainRuleOp      */ _functionParameterDeclaration.Set(__Matchers[487]);
                /*  76 PlainRuleOp      */ _functionParameterType.Set(__Matchers[488]);
                /*  77 PlainRuleOp      */ _valueParameterDeclaration.Set(__Matchers[489]);
                /*  78 PlainRuleOp      */ _valueParameterType.Set(__Matchers[490]);
                /*  79 PlainRuleOp      */ _typeParameters.Set(__Matchers[493]);
                /*  80 PlainRuleOp      */ _typeParameterList.Set(__Matchers[496]);
                /*  81 PlainRuleOp      */ _typeParameter.Set(__Matchers[499]);
                /*  82 PlainRuleOp      */ _variance.Set(__Matchers[502]);
                /*  83 PlainRuleOp      */ _typeDefault.Set(__Matchers[503]);
                /*  84 PlainRuleOp      */ _typeConstraint.Set(__Matchers[508]);
                /*  85 PlainRuleOp      */ _typeConstraints.Set(__Matchers[509]);
                /*  86 PlainRuleOp      */ _declarationOrStatement.Set(__Matchers[510]);
                /*  87 PlainRuleOp      */ _declaration.Set(__Matchers[511]);
                /*  88 PlainRuleOp      */ _constructor.Set(__Matchers[515]);
                /*  89 PlainRuleOp      */ _enumeratedObject.Set(__Matchers[516]);
                /*  90 PlainRuleOp      */ _aliasDeclaration.Set(__Matchers[519]);
                /*  91 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[522]);
                /*  92 PlainRuleOp      */ _setterDeclaration.Set(__Matchers[524]);
                /*  93 PlainRuleOp      */ _setterDefinition.Set(__Matchers[525]);
                /*  94 PlainRuleOp      */ _typedMethodDeclaration.Set(__Matchers[526]);
                /*  95 PlainRuleOp      */ _methodType.Set(__Matchers[527]);
                /*  96 PlainRuleOp      */ _inferredMethodDeclaration.Set(__Matchers[529]);
                /*  97 PlainRuleOp      */ _typedAttributeDeclaration.Set(__Matchers[530]);
                /*  98 PlainRuleOp      */ _attributeType.Set(_variadicType);
                /*  99 PlainRuleOp      */ _inferredAttributeDeclaration.Set(__Matchers[532]);
                /* 100 PlainRuleOp      */ _attributeDefinition.Set(__Matchers[533]);
                /* 101 PlainRuleOp      */ _optionalAnySpecifier.Set(__Matchers[535]);
                /* 102 PlainRuleOp      */ _classDeclaration.Set(__Matchers[537]);
                /* 103 PlainRuleOp      */ _classDefinition.Set(__Matchers[538]);
                /* 104 PlainRuleOp      */ _optionalClassSpecifier.Set(__Matchers[540]);
                /* 105 PlainRuleOp      */ _interfaceDeclaration.Set(__Matchers[542]);
                /* 106 PlainRuleOp      */ _interfaceDefinition.Set(__Matchers[543]);
                /* 107 PlainRuleOp      */ _optionalTypeSpecifier.Set(__Matchers[545]);
                /* 108 PlainRuleOp      */ _statement.Set(__Matchers[546]);
                /* 109 PlainRuleOp      */ _unclosedStatement.Set(__Matchers[547]);
                /* 110 PlainRuleOp      */ _openStatement.Set(__Matchers[548]);
                /* 111 PlainRuleOp      */ _specificationStatement.Set(__Matchers[549]);
                /* 112 PlainRuleOp      */ _expressionStatement.Set(_operatorExpression);
                /* 113 PlainRuleOp      */ _directiveStatement.Set(__Matchers[550]);
                /* 114 PlainRuleOp      */ _returnDirective.Set(__Matchers[553]);
                /* 115 PlainRuleOp      */ _throwDirective.Set(__Matchers[555]);
                /* 116 PlainRuleOp      */ _breakDirective.Set(__Matchers[556]);
                /* 117 PlainRuleOp      */ _continueDirective.Set(__Matchers[557]);
                /* 118 PlainRuleOp      */ _typeSpecifier.Set(__Matchers[558]);
                /* 119 PlainRuleOp      */ _valueSpecifier.Set(__Matchers[559]);
                /* 120 PlainRuleOp      */ _functionSpecifier.Set(__Matchers[560]);
                /* 121 PlainRuleOp      */ _anySpecifier.Set(__Matchers[561]);
                /* 122 PlainRuleOp      */ _baseReferenceOrParameterized.Set(__Matchers[562]);
                /* 123 PlainRuleOp      */ _baseReference.Set(__Matchers[563]);
                /* 124 PlainRuleOp      */ _parametrizedMember.Set(__Matchers[564]);
                /* 125 PlainRuleOp      */ _selfParametrizedMember.Set(__Matchers[565]);
                /* 126 PlainRuleOp      */ _memberReference.Set(__Matchers[567]);
                /* 127 PlainRuleOp      */ _typeReference.Set(__Matchers[568]);
                /* 128 PlainRuleOp      */ _selfReferenceSelector.Set(__Matchers[569]);
                /* 129 PlainRuleOp      */ _selfReference.Set(__Matchers[572]);
                /* 130 PlainRuleOp      */ _enumeration.Set(__Matchers[575]);
                /* 131 PlainRuleOp      */ _tuple.Set(__Matchers[576]);
                /* 132 PlainRuleOp      */ _arguments.Set(__Matchers[577]);
                /* 133 PlainRuleOp      */ _structuralArguments.Set(__Matchers[579]);
                /* 134 PlainRuleOp      */ _namedOrAnonymous.Set(__Matchers[580]);
                /* 135 PlainRuleOp      */ _namedArgument.Set(__Matchers[581]);
                /* 136 PlainRuleOp      */ _namedSpecifiedArgument.Set(__Matchers[582]);
                /* 137 PlainRuleOp      */ _sequencedArguments.Set(__Matchers[585]);
                /* 138 PlainRuleOp      */ _sequencedArgument.Set(__Matchers[586]);
                /* 139 PlainRuleOp      */ _anonymousArgument.Set(__Matchers[587]);
                /* 140 PlainRuleOp      */ _namedArgumentDeclaration.Set(__Matchers[588]);
                /* 141 PlainRuleOp      */ _objectArgument.Set(__Matchers[589]);
                /* 142 PlainRuleOp      */ _typedMethodArgument.Set(__Matchers[590]);
                /* 143 PlainRuleOp      */ _methodDefinition.Set(__Matchers[591]);
                /* 144 PlainRuleOp      */ _optionalFunctionSpecifier.Set(__Matchers[592]);
                /* 145 PlainRuleOp      */ _neededFunctionSpecifier.Set(__Matchers[593]);
                /* 146 PlainRuleOp      */ _methodArgumentType.Set(__Matchers[594]);
                /* 147 PlainRuleOp      */ _typedGetterArgument.Set(__Matchers[595]);
                /* 148 PlainRuleOp      */ _getterArgumentType.Set(_type);
                /* 149 PlainRuleOp      */ _inferredMethodArgument.Set(__Matchers[596]);
                /* 150 PlainRuleOp      */ _inferredGetterArgument.Set(__Matchers[597]);
                /* 151 PlainRuleOp      */ _untypedMethodArgument.Set(__Matchers[598]);
                /* 152 PlainRuleOp      */ _untypedGetterArgument.Set(__Matchers[599]);
                /* 153 PlainRuleOp      */ _positionalArguments.Set(__Matchers[600]);
                /* 154 PlainRuleOp      */ _positionalArgument.Set(__Matchers[601]);
                /* 155 PlainRuleOp      */ _spreadArgument.Set(__Matchers[603]);
                /* 156 PlainRuleOp      */ _letExpression.Set(__Matchers[605]);
                /* 157 PlainRuleOp      */ _letVariableList.Set(__Matchers[608]);
                /* 158 PlainRuleOp      */ _letVariable.Set(__Matchers[609]);
                /* 159 PlainRuleOp      */ _switchExpression.Set(__Matchers[610]);
                /* 160 PlainRuleOp      */ _caseExpressions.Set(__Matchers[613]);
                /* 161 PlainRuleOp      */ _caseExpression.Set(__Matchers[617]);
                /* 162 PlainRuleOp      */ _ifExpression.Set(__Matchers[619]);
                /* 163 PlainRuleOp      */ _elseExpression.Set(__Matchers[620]);
                /* 164 PlainRuleOp      */ _thenExpression.Set(__Matchers[622]);
                /* 165 PlainRuleOp      */ _conditionalExpression.Set(__Matchers[623]);
                /* 166 PlainRuleOp      */ _functionExpression.Set(__Matchers[626]);
                /* 167 PlainRuleOp      */ _functionExpressionType.Set(__Matchers[628]);
                /* 168 PlainRuleOp      */ _functionParameters.Set(__Matchers[629]);
                /* 169 PlainRuleOp      */ _functionDefinition.Set(__Matchers[630]);
                /* 170 PlainRuleOp      */ _comprehension.Set(__Matchers[631]);
                /* 171 PlainRuleOp      */ _comprehensionClause.Set(__Matchers[632]);
                /* 172 PlainRuleOp      */ _expressionComprehensionClause.Set(_expression);
                /* 173 PlainRuleOp      */ _forComprehensionClause.Set(__Matchers[635]);
                /* 174 PlainRuleOp      */ _ifComprehensionClause.Set(__Matchers[636]);
                /* 175 PlainRuleOp      */ _expression.Set(__Matchers[637]);
                /* 176 PlainRuleOp      */ _operatorExpression.Set(_assignmentExpression);
                /* 177 PlainRuleOp      */ _assignmentExpression.Set(__Matchers[638]);
                /* 178 PlainRuleOp      */ _assignment.Set(__Matchers[639]);
                /* 179 DfaRuleOp        */ _assignmentOperator.Set(_assignmentOperator_DFA);
                /* 180 PlainRuleOp      */ _thenElseExpression.Set(__Matchers[640]);
                /* 181 PlainRuleOp      */ _thenElse.Set(__Matchers[641]);
                /* 182 PlainRuleOp      */ _thenElseOperator.Set(__Matchers[642]);
                /* 183 PlainRuleOp      */ _disjunctionExpression.Set(__Matchers[643]);
                /* 184 PlainRuleOp      */ _disjunction.Set(__Matchers[644]);
                /* 185 PlainRuleOp      */ _disjunctionOperator.Set(__Matchers[645]);
                /* 186 PlainRuleOp      */ _conjunctionExpression.Set(__Matchers[646]);
                /* 187 PlainRuleOp      */ _conjunction.Set(__Matchers[647]);
                /* 188 PlainRuleOp      */ _conjunctionOperator.Set(__Matchers[648]);
                /* 189 PlainRuleOp      */ _logicalNegationExpression.Set(__Matchers[649]);
                /* 190 PlainRuleOp      */ _logicalNegation.Set(__Matchers[650]);
                /* 191 PlainRuleOp      */ _notOperator.Set(__Matchers[651]);
                /* 192 PlainRuleOp      */ _expressionOrMeta.Set(__Matchers[652]);
                /* 193 PlainRuleOp      */ _equalityExpression.Set(__Matchers[653]);
                /* 194 PlainRuleOp      */ _equality.Set(__Matchers[654]);
                /* 195 PlainRuleOp      */ _equalityOperator.Set(__Matchers[658]);
                /* 196 PlainRuleOp      */ _comparisonExpression.Set(__Matchers[659]);
                /* 197 PlainRuleOp      */ _comparisonExpr.Set(__Matchers[660]);
                /* 198 PlainRuleOp      */ _largerExpr.Set(__Matchers[661]);
                /* 199 PlainRuleOp      */ _smallerExpr.Set(__Matchers[662]);
                /* 200 PlainRuleOp      */ _largerBoundsExpr.Set(__Matchers[663]);
                /* 201 PlainRuleOp      */ _smallerBoundsExpr.Set(__Matchers[664]);
                /* 202 PlainRuleOp      */ _typecheckExpr.Set(__Matchers[665]);
                /* 203 PlainRuleOp      */ _comparisonOperator.Set(__Matchers[667]);
                /* 204 PlainRuleOp      */ _smallerOperator.Set(__Matchers[669]);
                /* 205 PlainRuleOp      */ _largerOperator.Set(__Matchers[671]);
                /* 206 PlainRuleOp      */ _typeOperator.Set(__Matchers[673]);
                /* 207 PlainRuleOp      */ _existsNonemptyExpression.Set(__Matchers[674]);
                /* 208 PlainRuleOp      */ _existsExpression.Set(__Matchers[676]);
                /* 209 PlainRuleOp      */ _nonemptyExpression.Set(__Matchers[678]);
                /* 210 PlainRuleOp      */ _entryRangeExpression.Set(__Matchers[679]);
                /* 211 PlainRuleOp      */ _entryOrRange.Set(__Matchers[680]);
                /* 212 PlainRuleOp      */ _rangeOrEntryOperator.Set(__Matchers[682]);
                /* 213 PlainRuleOp      */ _additiveExpression.Set(__Matchers[683]);
                /* 214 PlainRuleOp      */ _additiveExpr.Set(__Matchers[684]);
                /* 215 PlainRuleOp      */ _additiveOperator.Set(__Matchers[687]);
                /* 216 PlainRuleOp      */ _scaleExpression.Set(__Matchers[688]);
                /* 217 PlainRuleOp      */ _scaleExpr.Set(__Matchers[689]);
                /* 218 PlainRuleOp      */ _scaleOperator.Set(__Matchers[690]);
                /* 219 PlainRuleOp      */ _multiplicativeExpression.Set(__Matchers[691]);
                /* 220 PlainRuleOp      */ _multiplicativeExpr.Set(__Matchers[692]);
                /* 221 PlainRuleOp      */ _multiplicativeOperator.Set(__Matchers[695]);
                /* 222 PlainRuleOp      */ _unionExpression.Set(__Matchers[696]);
                /* 223 PlainRuleOp      */ _unionExpr.Set(__Matchers[697]);
                /* 224 PlainRuleOp      */ _unionOperator.Set(__Matchers[699]);
                /* 225 PlainRuleOp      */ _exclusiveExpression.Set(__Matchers[700]);
                /* 226 PlainRuleOp      */ _exclusiveExpr.Set(__Matchers[701]);
                /* 227 PlainRuleOp      */ _exclusiveOperator.Set(__Matchers[702]);
                /* 228 PlainRuleOp      */ _intersectionExpression.Set(__Matchers[703]);
                /* 229 PlainRuleOp      */ _intersectionExpr.Set(__Matchers[704]);
                /* 230 PlainRuleOp      */ _intersectionOperator.Set(__Matchers[705]);
                /* 231 PlainRuleOp      */ _negationOrComplementExpression.Set(__Matchers[706]);
                /* 232 PlainRuleOp      */ _negationOrComplementExpr.Set(__Matchers[707]);
                /* 233 PlainRuleOp      */ _unaryMinusOrComplementOperator.Set(__Matchers[708]);
                /* 234 PlainRuleOp      */ _opNegate.Set(__Matchers[710]);
                /* 235 PlainRuleOp      */ _opNeutral.Set(__Matchers[712]);
                /* 236 PlainRuleOp      */ _opComplement.Set(__Matchers[698]);
                /* 237 PlainRuleOp      */ _prefixExpression.Set(__Matchers[713]);
                /* 238 PlainRuleOp      */ _prefixExpr.Set(__Matchers[714]);
                /* 239 PlainRuleOp      */ _postfixExpression.Set(__Matchers[715]);
                /* 240 PlainRuleOp      */ _postfixExpr.Set(__Matchers[716]);
                /* 241 PlainRuleOp      */ _incrementOperator.Set(__Matchers[719]);
                /* 242 PlainRuleOp      */ _primary.Set(__Matchers[720]);
                /* 243 PlainRuleOp      */ _selectionExpression.Set(__Matchers[721]);
                /* 244 PlainRuleOp      */ _qualifiedReference.Set(__Matchers[722]);
                /* 245 PlainRuleOp      */ _memberSelectionOperator.Set(__Matchers[725]);
                /* 246 PlainRuleOp      */ _indexedExpression.Set(__Matchers[726]);
                /* 247 PlainRuleOp      */ _index.Set(__Matchers[727]);
                /* 248 PlainRuleOp      */ _upperSpanned.Set(__Matchers[728]);
                /* 249 PlainRuleOp      */ _lowerSpanned.Set(__Matchers[729]);
                /* 250 PlainRuleOp      */ _spanned.Set(__Matchers[730]);
                /* 251 PlainRuleOp      */ _measured.Set(__Matchers[731]);
                /* 252 PlainRuleOp      */ _indexExpression.Set(_additiveExpression);
                /* 253 PlainRuleOp      */ _callExpression.Set(__Matchers[732]);
                /* 254 PlainRuleOp      */ _baseExpression.Set(__Matchers[733]);
                /* 255 PlainRuleOp      */ _nonstringLiteral.Set(__Matchers[734]);
                /* 256 PlainRuleOp      */ _stringExpression.Set(__Matchers[735]);
                /* 257 PlainRuleOp      */ _stringInterpolation.Set(__Matchers[737]);
                /* 258 PlainRuleOp      */ _interpolationPart.Set(__Matchers[738]);
                /* 259 PlainRuleOp      */ _stringLiteral.Set(__Matchers[739]);
                /* 260 PlainRuleOp      */ _objectExpression.Set(__Matchers[740]);
                /* 261 PlainRuleOp      */ _groupedExpression.Set(__Matchers[741]);
                /* 262 PlainRuleOp      */ _typeArguments.Set(__Matchers[743]);
                /* 263 PlainRuleOp      */ _typeArgumentList.Set(__Matchers[746]);
                /* 264 PlainRuleOp      */ _variancedType.Set(__Matchers[747]);
                /* 265 PlainRuleOp      */ _defaultedTypeList.Set(__Matchers[750]);
                /* 266 PlainRuleOp      */ _defaultedType.Set(__Matchers[751]);
                /* 267 PlainRuleOp      */ _defaultedTypeCore.Set(__Matchers[752]);
                /* 268 PlainRuleOp      */ _variadicType.Set(__Matchers[753]);
                /* 269 PlainRuleOp      */ _variadicUnionType.Set(__Matchers[754]);
                /* 270 PlainRuleOp      */ _variadicOperator.Set(__Matchers[755]);
                /* 271 PlainRuleOp      */ _spreadType.Set(__Matchers[756]);
                /* 272 PlainRuleOp      */ _type.Set(__Matchers[757]);
                /* 273 PlainRuleOp      */ _entryType.Set(__Matchers[758]);
                /* 274 PlainRuleOp      */ _unionType.Set(__Matchers[759]);
                /* 275 PlainRuleOp      */ _unionTypeCore.Set(__Matchers[760]);
                /* 276 PlainRuleOp      */ _intersectionType.Set(__Matchers[761]);
                /* 277 PlainRuleOp      */ _intersectionTypeCore.Set(__Matchers[762]);
                /* 278 PlainRuleOp      */ _primaryType.Set(__Matchers[763]);
                /* 279 PlainRuleOp      */ _nullableType.Set(__Matchers[765]);
                /* 280 PlainRuleOp      */ _arrayType.Set(__Matchers[767]);
                /* 281 PlainRuleOp      */ _functionType.Set(__Matchers[769]);
                /* 282 PlainRuleOp      */ _typeTypeArguments.Set(__Matchers[770]);
                /* 283 PlainRuleOp      */ _tupleType.Set(__Matchers[771]);
                /* 284 PlainRuleOp      */ _iterableType.Set(__Matchers[773]);
                /* 285 PlainRuleOp      */ _groupedType.Set(__Matchers[774]);
                /* 286 PlainRuleOp      */ _qualifiedType.Set(__Matchers[775]);
                /* 287 PlainRuleOp      */ _annotations.Set(__Matchers[778]);
                /* 288 PlainRuleOp      */ _annotation.Set(__Matchers[779]);
                /* 289 PlainRuleOp      */ _conditions.Set(__Matchers[781]);
                /* 290 PlainRuleOp      */ _conditionList.Set(__Matchers[784]);
                /* 291 PlainRuleOp      */ _condition.Set(__Matchers[785]);
                /* 292 PlainRuleOp      */ _existsCondition.Set(__Matchers[787]);
                /* 293 PlainRuleOp      */ _nonemptyCondition.Set(__Matchers[788]);
                /* 294 PlainRuleOp      */ _letOrExpression.Set(__Matchers[789]);
                /* 295 PlainRuleOp      */ _isCondition.Set(__Matchers[790]);
                /* 296 PlainRuleOp      */ _isConditionVariable.Set(__Matchers[482]);
                /* 297 PlainRuleOp      */ _satisfiesCondition.Set(__Matchers[791]);
                /* 298 PlainRuleOp      */ _booleanCondition.Set(_expression);
                /* 299 PlainRuleOp      */ _controlStatement.Set(__Matchers[792]);
                /* 300 PlainRuleOp      */ _ifElse.Set(__Matchers[794]);
                /* 301 PlainRuleOp      */ _ifBlock.Set(__Matchers[795]);
                /* 302 PlainRuleOp      */ _elseBlock.Set(__Matchers[796]);
                /* 303 PlainRuleOp      */ _elseBlockNext.Set(__Matchers[797]);
                /* 304 PlainRuleOp      */ _switchCaseElse.Set(__Matchers[799]);
                /* 305 PlainRuleOp      */ _switchHeader.Set(__Matchers[801]);
                /* 306 PlainRuleOp      */ _switched.Set(_specifiedOrExpression);
                /* 307 PlainRuleOp      */ _caseBlock.Set(__Matchers[802]);
                /* 308 PlainRuleOp      */ _caseItem.Set(__Matchers[803]);
                /* 309 PlainRuleOp      */ _isCaseCondition.Set(__Matchers[805]);
                /* 310 PlainRuleOp      */ _satisfiesCaseCondition.Set(__Matchers[806]);
                /* 311 PlainRuleOp      */ _matchCaseCondition.Set(_valueCaseList);
                /* 312 PlainRuleOp      */ _valueCaseList.Set(__Matchers[809]);
                /* 313 PlainRuleOp      */ _valueCaseSeparator.Set(__Matchers[810]);
                /* 314 PlainRuleOp      */ _valueCase.Set(__Matchers[811]);
                /* 315 PlainRuleOp      */ _forElse.Set(__Matchers[813]);
                /* 316 PlainRuleOp      */ _forBlock.Set(__Matchers[814]);
                /* 317 PlainRuleOp      */ _failBlock.Set(__Matchers[815]);
                /* 318 PlainRuleOp      */ _forIterator.Set(__Matchers[817]);
                /* 319 PlainRuleOp      */ _forVariable.Set(__Matchers[818]);
                /* 320 PlainRuleOp      */ _containment.Set(__Matchers[819]);
                /* 321 PlainRuleOp      */ _containmentOperator.Set(__Matchers[820]);
                /* 322 PlainRuleOp      */ _whileLoop.Set(_whileBlock);
                /* 323 PlainRuleOp      */ _whileBlock.Set(__Matchers[822]);
                /* 324 PlainRuleOp      */ _tryCatchFinally.Set(__Matchers[825]);
                /* 325 PlainRuleOp      */ _tryBlock.Set(__Matchers[828]);
                /* 326 PlainRuleOp      */ _catchBlock.Set(__Matchers[830]);
                /* 327 PlainRuleOp      */ _catchVariable.Set(__Matchers[832]);
                /* 328 PlainRuleOp      */ _finallyBlock.Set(__Matchers[834]);
                /* 329 PlainRuleOp      */ _resources.Set(__Matchers[836]);
                /* 330 PlainRuleOp      */ _resourceList.Set(__Matchers[839]);
                /* 331 PlainRuleOp      */ _resource.Set(_specifiedOrExpression);
                /* 332 PlainRuleOp      */ _specifiedOrExpression.Set(__Matchers[840]);
                /* 333 PlainRuleOp      */ _specifiedVariable.Set(__Matchers[841]);
                /* 334 PlainRuleOp      */ _variable.Set(__Matchers[844]);
                /* 335 PlainRuleOp      */ _variableType.Set(__Matchers[845]);
                /* 336 PlainRuleOp      */ _modelReference.Set(__Matchers[846]);
                /* 337 PlainRuleOp      */ _metaLiteral.Set(__Matchers[848]);
                /* 338 PlainRuleOp      */ _metaExpression.Set(__Matchers[849]);
                /* 339 PlainRuleOp      */ _modelExpression.Set(__Matchers[850]);
                /* 340 PlainRuleOp      */ _memberModelExpression.Set(__Matchers[851]);
                /* 341 PlainRuleOp      */ _packageQualifiedMemberReference.Set(__Matchers[852]);
                /* 342 PlainRuleOp      */ _typeQualifiedMemberReference.Set(__Matchers[853]);
                /* 343 PlainRuleOp      */ _typeModelExpression.Set(_type);
                /* 344 PlainRuleOp      */ _declarationReference.Set(__Matchers[854]);
                /* 345 PlainRuleOp      */ _moduleLiteral.Set(__Matchers[856]);
                /* 346 PlainRuleOp      */ _packageLiteral.Set(__Matchers[857]);
                /* 347 PlainRuleOp      */ _classLiteral.Set(__Matchers[858]);
                /* 348 PlainRuleOp      */ _interfaceLiteral.Set(__Matchers[859]);
                /* 349 PlainRuleOp      */ _aliasLiteral.Set(__Matchers[860]);
                /* 350 PlainRuleOp      */ _typeParameterLiteral.Set(__Matchers[861]);
                /* 351 PlainRuleOp      */ _newLiteral.Set(__Matchers[862]);
                /* 352 PlainRuleOp      */ _valueLiteral.Set(__Matchers[863]);
                /* 353 PlainRuleOp      */ _valueLiteralIntro.Set(__Matchers[864]);
                /* 354 PlainRuleOp      */ _functionLiteral.Set(__Matchers[865]);
                /* 355 PlainRuleOp      */ _referencePath.Set(__Matchers[866]);
                /* 356 PlainRuleOp      */ _referencePathElementList.Set(__Matchers[869]);
                /* 357 PlainRuleOp      */ _referencePathElement.Set(_anyName);
                /* 358 PlainRuleOp      */ _kwVoid.Set(__Matchers[627]);
                /* 359 PlainRuleOp      */ _kwFunction.Set(__Matchers[528]);
                /* 360 PlainRuleOp      */ _kwValue.Set(__Matchers[531]);
                /* 361 DfaRuleOp        */ _literalFloat.Set(_literalFloat_DFA);
                /* 362 DfaRuleOp        */ _literalNatural.Set(_literalNatural_DFA);
                /* 363 DfaRuleOp        */ _literalChar.Set(_literalChar_DFA);
                /* 364 DfaRuleOp        */ _stringStart.Set(_stringStart_DFA);
                /* 365 DfaRuleOp        */ _stringMid.Set(_stringMid_DFA);
                /* 366 DfaRuleOp        */ _stringEnd.Set(_stringEnd_DFA);
                /* 367 DfaRuleOp        */ _literalString.Set(_literalString_DFA);
                /* 368 DfaRuleOp        */ _verbatimString.Set(_verbatimString_DFA);
                /* 369 DfaRuleOp        */ _lowerIdentifier.Set(_lowerIdentifier_DFA);
                /* 370 DfaRuleOp        */ _upperIdentifier.Set(_upperIdentifier_DFA);
                /* 372 SeqOp            */ __Matchers[372].Set(_compilationUnit, __Matchers[371]);
                /* 373 AltOp            */ __Matchers[373].Set(_moduleDescriptor, _packageDescriptor, _unitElements);
                /* 374 StarOp           */ __Matchers[374].Set(_unitElement);
                /* 375 AltOp            */ __Matchers[375].Set(_importDeclaration, _declaration);
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
                /* 409 SeqOp            */ __Matchers[409].Set(__Matchers[408], _importName);
                /* 412 SeqOp            */ __Matchers[412].Set(__Matchers[411], _packageName);
                /* 413 StarOp           */ __Matchers[413].Set(__Matchers[412]);
                /* 414 SeqOp            */ __Matchers[414].Set(_packageName, __Matchers[413]);
                /* 415 AltOp            */ __Matchers[415].Set(_lowerIdentifier, _upperIdentifier);
                /* 416 AltOp            */ __Matchers[416].Set(_entryPattern, _tuplePattern, _variablePattern);
                /* 417 AltOp            */ __Matchers[417].Set(_tuplePattern, _variablePattern);
                /* 418 AltOp            */ __Matchers[418].Set(_entryPattern, _tuplePattern);
                /* 420 SeqOp            */ __Matchers[420].Set(_variableOrTuplePattern, __Matchers[419], _variableOrTuplePattern);
                /* 422 OptionalOp       */ __Matchers[422].Set(_variadicPatternList);
                /* 424 SeqOp            */ __Matchers[424].Set(__Matchers[421], __Matchers[422], __Matchers[423]);
                /* 425 SeqOp            */ __Matchers[425].Set(__Matchers[400], _variadicPattern);
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
                /* 441 StarOp           */ __Matchers[441].Set(_blockElement);
                /* 442 SeqOp            */ __Matchers[442].Set(__Matchers[387], __Matchers[441], __Matchers[389]);
                /* 443 AltOp            */ __Matchers[443].Set(_importDeclaration, _declarationOrStatement);
                /* 445 SeqOp            */ __Matchers[445].Set(__Matchers[444], _classInstatiation);
                /* 446 OptionalOp       */ __Matchers[446].Set(_arguments);
                /* 447 SeqOp            */ __Matchers[447].Set(_qualifiedClass, __Matchers[446]);
                /* 448 AltOp            */ __Matchers[448].Set(_packageQualifiedClass, _superQualifiedClass, _unQualifiedClass);
                /* 449 SeqOp            */ __Matchers[449].Set(_superQualifier, _baseReference);
                /* 451 SeqOp            */ __Matchers[451].Set(__Matchers[450], __Matchers[411]);
                /* 452 SeqOp            */ __Matchers[452].Set(_packageQualifier, _unQualifiedClass);
                /* 453 SeqOp            */ __Matchers[453].Set(__Matchers[392], __Matchers[411]);
                /* 454 AltOp            */ __Matchers[454].Set(_memberPath, _typePath, _memberReference);
                /* 455 SeqOp            */ __Matchers[455].Set(_typePath, __Matchers[411], _memberReference);
                /* 456 SeqOp            */ __Matchers[456].Set(__Matchers[411], _typeReference);
                /* 457 StarOp           */ __Matchers[457].Set(__Matchers[456]);
                /* 458 SeqOp            */ __Matchers[458].Set(_typeReference, __Matchers[457]);
                /* 460 SeqOp            */ __Matchers[460].Set(__Matchers[459], _unionTypeList);
                /* 461 SeqOp            */ __Matchers[461].Set(__Matchers[400], _unionType);
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
                /* 475 SeqOp            */ __Matchers[475].Set(__Matchers[400], _parameterDeclarationOrRefPattern);
                /* 476 StarOp           */ __Matchers[476].Set(__Matchers[475]);
                /* 477 SeqOp            */ __Matchers[477].Set(_parameterDeclarationOrRefPattern, __Matchers[476]);
                /* 478 AltOp            */ __Matchers[478].Set(_tupleOrEntryPattern, _parameterDeclarationOrRef);
                /* 479 AltOp            */ __Matchers[479].Set(_parameter, _parameterReference);
                /* 480 SeqOp            */ __Matchers[480].Set(_annotations, _parameterDeclaration);
                /* 481 OptionalOp       */ __Matchers[481].Set(_valueSpecifier);
                /* 482 SeqOp            */ __Matchers[482].Set(_memberName, __Matchers[481]);
                /* 483 AltOp            */ __Matchers[483].Set(_functionParameterDeclaration, _valueParameterDeclaration);
                /* 484 OptionalOp       */ __Matchers[484].Set(_typeParameters);
                /* 485 PlusOp           */ __Matchers[485].Set(_parameters);
                /* 486 OptionalOp       */ __Matchers[486].Set(_functionSpecifier);
                /* 487 SeqOp            */ __Matchers[487].Set(_functionParameterType, _memberName, __Matchers[484], __Matchers[485], __Matchers[486]);
                /* 488 AltOp            */ __Matchers[488].Set(_variadicType, _kwVoid, _kwFunction);
                /* 489 SeqOp            */ __Matchers[489].Set(_valueParameterType, _memberName, __Matchers[481]);
                /* 490 AltOp            */ __Matchers[490].Set(_variadicType, _kwValue);
                /* 493 SeqOp            */ __Matchers[493].Set(__Matchers[491], _typeParameterList, __Matchers[492]);
                /* 494 SeqOp            */ __Matchers[494].Set(__Matchers[400], _typeParameter);
                /* 495 StarOp           */ __Matchers[495].Set(__Matchers[494]);
                /* 496 SeqOp            */ __Matchers[496].Set(_typeParameter, __Matchers[495]);
                /* 497 OptionalOp       */ __Matchers[497].Set(_variance);
                /* 498 OptionalOp       */ __Matchers[498].Set(_typeDefault);
                /* 499 SeqOp            */ __Matchers[499].Set(__Matchers[497], _typeName, __Matchers[498]);
                /* 502 AltOp            */ __Matchers[502].Set(__Matchers[500], __Matchers[501]);
                /* 503 SeqOp            */ __Matchers[503].Set(__Matchers[408], _type);
                /* 505 OptionalOp       */ __Matchers[505].Set(_typeName);
                /* 506 OptionalOp       */ __Matchers[506].Set(_caseTypes);
                /* 507 OptionalOp       */ __Matchers[507].Set(_satisfiedTypes);
                /* 508 SeqOp            */ __Matchers[508].Set(__Matchers[504], __Matchers[505], __Matchers[484], __Matchers[506], __Matchers[507]);
                /* 509 PlusOp           */ __Matchers[509].Set(_typeConstraint);
                /* 510 AltOp            */ __Matchers[510].Set(_declaration, _statement);
                /* 511 AltOp            */ __Matchers[511].Set(_constructor, _enumeratedObject, _aliasDeclaration, _objectDeclaration, _setterDeclaration, _typedMethodDeclaration, _inferredMethodDeclaration, _typedAttributeDeclaration, _inferredAttributeDeclaration, _classDeclaration, _interfaceDeclaration);
                /* 513 OptionalOp       */ __Matchers[513].Set(_parameters);
                /* 514 OptionalOp       */ __Matchers[514].Set(_delegatedConstructor);
                /* 515 SeqOp            */ __Matchers[515].Set(_annotations, __Matchers[512], __Matchers[430], __Matchers[513], __Matchers[514], _block);
                /* 516 SeqOp            */ __Matchers[516].Set(_annotations, __Matchers[512], _memberName, __Matchers[514], _block);
                /* 518 OptionalOp       */ __Matchers[518].Set(_typeConstraints);
                /* 519 SeqOp            */ __Matchers[519].Set(_annotations, __Matchers[517], _typeName, __Matchers[484], __Matchers[518], _optionalTypeSpecifier);
                /* 521 OptionalOp       */ __Matchers[521].Set(_extendedType);
                /* 522 SeqOp            */ __Matchers[522].Set(_annotations, __Matchers[520], _memberName, __Matchers[521], __Matchers[507], _classBlock);
                /* 524 SeqOp            */ __Matchers[524].Set(_annotations, __Matchers[523], _memberName, _setterDefinition);
                /* 525 AltOp            */ __Matchers[525].Set(_block, _neededFunctionSpecifier);
                /* 526 SeqOp            */ __Matchers[526].Set(_annotations, _methodType, _parametrizedMember, __Matchers[518], _methodDefinition);
                /* 527 AltOp            */ __Matchers[527].Set(_variadicType, _kwVoid);
                /* 529 SeqOp            */ __Matchers[529].Set(_annotations, __Matchers[528], _parametrizedMember, __Matchers[518], _methodDefinition);
                /* 530 SeqOp            */ __Matchers[530].Set(_annotations, _attributeType, _memberName, _attributeDefinition);
                /* 532 SeqOp            */ __Matchers[532].Set(_annotations, __Matchers[531], _memberName, _attributeDefinition);
                /* 533 AltOp            */ __Matchers[533].Set(_block, _optionalAnySpecifier);
                /* 534 OptionalOp       */ __Matchers[534].Set(_anySpecifier);
                /* 535 SeqOp            */ __Matchers[535].Set(__Matchers[534], __Matchers[393]);
                /* 537 SeqOp            */ __Matchers[537].Set(_annotations, __Matchers[536], _typeName, __Matchers[484], __Matchers[513], __Matchers[506], __Matchers[521], __Matchers[507], __Matchers[518], _classDefinition);
                /* 538 AltOp            */ __Matchers[538].Set(_classBlock, _optionalClassSpecifier);
                /* 539 OptionalOp       */ __Matchers[539].Set(_classSpecifier);
                /* 540 SeqOp            */ __Matchers[540].Set(__Matchers[539], __Matchers[393]);
                /* 542 SeqOp            */ __Matchers[542].Set(_annotations, __Matchers[541], _typeName, __Matchers[484], __Matchers[506], __Matchers[507], __Matchers[518], _interfaceDefinition);
                /* 543 AltOp            */ __Matchers[543].Set(_interfaceBlock, _optionalTypeSpecifier);
                /* 544 OptionalOp       */ __Matchers[544].Set(_typeSpecifier);
                /* 545 SeqOp            */ __Matchers[545].Set(__Matchers[544], __Matchers[393]);
                /* 546 AltOp            */ __Matchers[546].Set(_unclosedStatement, _controlStatement);
                /* 547 SeqOp            */ __Matchers[547].Set(_openStatement, __Matchers[393]);
                /* 548 AltOp            */ __Matchers[548].Set(_directiveStatement, _expressionStatement, _specificationStatement, _assertionStatement, _letStatement);
                /* 549 SeqOp            */ __Matchers[549].Set(_primary, _functionSpecifier);
                /* 550 AltOp            */ __Matchers[550].Set(_returnDirective, _throwDirective, _breakDirective, _continueDirective);
                /* 552 OptionalOp       */ __Matchers[552].Set(_expression);
                /* 553 SeqOp            */ __Matchers[553].Set(__Matchers[551], __Matchers[552]);
                /* 555 SeqOp            */ __Matchers[555].Set(__Matchers[554], __Matchers[552]);
                /* 558 SeqOp            */ __Matchers[558].Set(__Matchers[444], _type);
                /* 559 SeqOp            */ __Matchers[559].Set(__Matchers[408], _expression);
                /* 560 SeqOp            */ __Matchers[560].Set(__Matchers[444], _expression);
                /* 561 AltOp            */ __Matchers[561].Set(_valueSpecifier, _functionSpecifier);
                /* 562 AltOp            */ __Matchers[562].Set(_baseReference, _parametrizedMember, _selfReference, _selfParametrizedMember);
                /* 563 AltOp            */ __Matchers[563].Set(_memberReference, _typeReference);
                /* 564 SeqOp            */ __Matchers[564].Set(_memberName, __Matchers[484], __Matchers[485]);
                /* 565 SeqOp            */ __Matchers[565].Set(_selfReferenceSelector, _parametrizedMember);
                /* 566 OptionalOp       */ __Matchers[566].Set(_typeArguments);
                /* 567 SeqOp            */ __Matchers[567].Set(_memberName, __Matchers[566]);
                /* 568 SeqOp            */ __Matchers[568].Set(_typeName, __Matchers[566]);
                /* 569 SeqOp            */ __Matchers[569].Set(_selfReference, _memberSelectionOperator);
                /* 572 AltOp            */ __Matchers[572].Set(__Matchers[570], __Matchers[450], __Matchers[571], __Matchers[392]);
                /* 573 StarOp           */ __Matchers[573].Set(_declarationOrStatement);
                /* 574 OptionalOp       */ __Matchers[574].Set(_sequencedArguments);
                /* 575 SeqOp            */ __Matchers[575].Set(__Matchers[387], __Matchers[573], __Matchers[574], __Matchers[389]);
                /* 576 SeqOp            */ __Matchers[576].Set(__Matchers[421], __Matchers[574], __Matchers[423]);
                /* 577 AltOp            */ __Matchers[577].Set(_structuralArguments, _positionalArguments);
                /* 578 StarOp           */ __Matchers[578].Set(_namedOrAnonymous);
                /* 579 SeqOp            */ __Matchers[579].Set(__Matchers[387], __Matchers[578], __Matchers[574], __Matchers[389]);
                /* 580 AltOp            */ __Matchers[580].Set(_namedArgument, _anonymousArgument);
                /* 581 AltOp            */ __Matchers[581].Set(_namedSpecifiedArgument, _namedArgumentDeclaration);
                /* 582 SeqOp            */ __Matchers[582].Set(_memberName, _valueSpecifier, __Matchers[393]);
                /* 583 SeqOp            */ __Matchers[583].Set(__Matchers[400], _sequencedArgument);
                /* 584 StarOp           */ __Matchers[584].Set(__Matchers[583]);
                /* 585 SeqOp            */ __Matchers[585].Set(_sequencedArgument, __Matchers[584]);
                /* 586 AltOp            */ __Matchers[586].Set(_comprehension, _positionalArgument, _spreadArgument);
                /* 587 SeqOp            */ __Matchers[587].Set(_expression, __Matchers[393]);
                /* 588 AltOp            */ __Matchers[588].Set(_objectArgument, _typedMethodArgument, _inferredMethodArgument, _untypedMethodArgument, _typedGetterArgument, _inferredGetterArgument, _untypedGetterArgument);
                /* 589 SeqOp            */ __Matchers[589].Set(__Matchers[520], __Matchers[430], __Matchers[521], __Matchers[507], _classBlock);
                /* 590 SeqOp            */ __Matchers[590].Set(_methodArgumentType, _parametrizedMember, _methodDefinition);
                /* 591 AltOp            */ __Matchers[591].Set(_block, _optionalFunctionSpecifier);
                /* 592 SeqOp            */ __Matchers[592].Set(__Matchers[486], __Matchers[393]);
                /* 593 SeqOp            */ __Matchers[593].Set(_functionSpecifier, __Matchers[393]);
                /* 594 AltOp            */ __Matchers[594].Set(_type, _kwVoid);
                /* 595 SeqOp            */ __Matchers[595].Set(_getterArgumentType, _memberName, _methodDefinition);
                /* 596 SeqOp            */ __Matchers[596].Set(__Matchers[528], __Matchers[430], __Matchers[484], _parameters, _methodDefinition);
                /* 597 SeqOp            */ __Matchers[597].Set(__Matchers[531], _memberName, _methodDefinition);
                /* 598 SeqOp            */ __Matchers[598].Set(_memberName, __Matchers[485], _neededFunctionSpecifier);
                /* 599 SeqOp            */ __Matchers[599].Set(_memberName, _neededFunctionSpecifier);
                /* 600 SeqOp            */ __Matchers[600].Set(__Matchers[433], __Matchers[574], __Matchers[434]);
                /* 601 AltOp            */ __Matchers[601].Set(_expression, _declarationReference);
                /* 603 SeqOp            */ __Matchers[603].Set(__Matchers[602], _unionExpression);
                /* 604 OptionalOp       */ __Matchers[604].Set(_letVariableList);
                /* 605 SeqOp            */ __Matchers[605].Set(__Matchers[432], __Matchers[433], __Matchers[604], __Matchers[434], _conditionalExpression);
                /* 606 SeqOp            */ __Matchers[606].Set(__Matchers[400], _letVariable);
                /* 607 StarOp           */ __Matchers[607].Set(__Matchers[606]);
                /* 608 SeqOp            */ __Matchers[608].Set(_letVariable, __Matchers[607]);
                /* 609 SeqOp            */ __Matchers[609].Set(_pattern, _valueSpecifier);
                /* 610 SeqOp            */ __Matchers[610].Set(_switchHeader, _caseExpressions);
                /* 611 PlusOp           */ __Matchers[611].Set(_caseExpression);
                /* 612 OptionalOp       */ __Matchers[612].Set(_elseExpression);
                /* 613 SeqOp            */ __Matchers[613].Set(__Matchers[611], __Matchers[612]);
                /* 615 OptionalOp       */ __Matchers[615].Set(__Matchers[614]);
                /* 617 SeqOp            */ __Matchers[617].Set(__Matchers[615], __Matchers[616], __Matchers[433], _caseItem, __Matchers[434], _conditionalExpression);
                /* 619 SeqOp            */ __Matchers[619].Set(__Matchers[618], _conditions, _thenExpression, _elseExpression);
                /* 620 SeqOp            */ __Matchers[620].Set(__Matchers[614], _conditionalExpression);
                /* 622 SeqOp            */ __Matchers[622].Set(__Matchers[621], _conditionalExpression);
                /* 623 AltOp            */ __Matchers[623].Set(_ifExpression, _letExpression, _disjunctionExpression);
                /* 624 OptionalOp       */ __Matchers[624].Set(_functionExpressionType);
                /* 625 OptionalOp       */ __Matchers[625].Set(_functionParameters);
                /* 626 SeqOp            */ __Matchers[626].Set(__Matchers[624], __Matchers[484], __Matchers[625], _functionDefinition);
                /* 628 AltOp            */ __Matchers[628].Set(__Matchers[627], __Matchers[528]);
                /* 629 SeqOp            */ __Matchers[629].Set(__Matchers[485], __Matchers[518]);
                /* 630 AltOp            */ __Matchers[630].Set(_block, _functionSpecifier);
                /* 631 AltOp            */ __Matchers[631].Set(_forComprehensionClause, _ifComprehensionClause);
                /* 632 AltOp            */ __Matchers[632].Set(_forComprehensionClause, _ifComprehensionClause, _expressionComprehensionClause);
                /* 634 OptionalOp       */ __Matchers[634].Set(_forIterator);
                /* 635 SeqOp            */ __Matchers[635].Set(__Matchers[633], __Matchers[433], __Matchers[634], __Matchers[434], _comprehensionClause);
                /* 636 SeqOp            */ __Matchers[636].Set(__Matchers[618], _conditions, _comprehensionClause);
                /* 637 AltOp            */ __Matchers[637].Set(_letExpression, _ifExpression, _switchExpression, _functionExpression, _operatorExpression);
                /* 638 AltOp            */ __Matchers[638].Set(_assignment, _thenElseExpression);
                /* 639 SeqOp            */ __Matchers[639].Set(_thenElseExpression, _assignmentOperator, _expression);
                /* 640 AltOp            */ __Matchers[640].Set(_thenElse, _disjunctionExpression);
                /* 641 SeqOp            */ __Matchers[641].Set(_thenElseExpression, _thenElseOperator, _disjunctionExpression);
                /* 642 AltOp            */ __Matchers[642].Set(__Matchers[614], __Matchers[621]);
                /* 643 AltOp            */ __Matchers[643].Set(_disjunction, _conjunctionExpression);
                /* 644 SeqOp            */ __Matchers[644].Set(_disjunctionExpression, _disjunctionOperator, _conjunctionExpression);
                /* 646 AltOp            */ __Matchers[646].Set(_conjunction, _logicalNegationExpression);
                /* 647 SeqOp            */ __Matchers[647].Set(_conjunctionExpression, _conjunctionOperator, _logicalNegationExpression);
                /* 649 AltOp            */ __Matchers[649].Set(_logicalNegation, _expressionOrMeta);
                /* 650 SeqOp            */ __Matchers[650].Set(_notOperator, _logicalNegationExpression);
                /* 652 AltOp            */ __Matchers[652].Set(_equalityExpression, _modelReference);
                /* 653 AltOp            */ __Matchers[653].Set(_equality, _comparisonExpression);
                /* 654 SeqOp            */ __Matchers[654].Set(_comparisonExpression, _equalityOperator, _comparisonExpression);
                /* 658 AltOp            */ __Matchers[658].Set(__Matchers[655], __Matchers[656], __Matchers[657]);
                /* 659 AltOp            */ __Matchers[659].Set(_comparisonExpr, _largerExpr, _smallerExpr, _largerBoundsExpr, _smallerBoundsExpr, _typecheckExpr, _existsNonemptyExpression);
                /* 660 SeqOp            */ __Matchers[660].Set(_existsNonemptyExpression, _comparisonOperator, _existsNonemptyExpression);
                /* 661 SeqOp            */ __Matchers[661].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 662 SeqOp            */ __Matchers[662].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 663 SeqOp            */ __Matchers[663].Set(_existsNonemptyExpression, _largerOperator, _existsNonemptyExpression, _largerOperator, _existsNonemptyExpression);
                /* 664 SeqOp            */ __Matchers[664].Set(_existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression, _smallerOperator, _existsNonemptyExpression);
                /* 665 SeqOp            */ __Matchers[665].Set(_existsNonemptyExpression, _typeOperator, _type);
                /* 667 AltOp            */ __Matchers[667].Set(__Matchers[666], __Matchers[500]);
                /* 669 AltOp            */ __Matchers[669].Set(__Matchers[668], __Matchers[491]);
                /* 671 AltOp            */ __Matchers[671].Set(__Matchers[670], __Matchers[492]);
                /* 673 AltOp            */ __Matchers[673].Set(__Matchers[672], __Matchers[436], __Matchers[459], __Matchers[464]);
                /* 674 AltOp            */ __Matchers[674].Set(_existsExpression, _nonemptyExpression, _entryRangeExpression);
                /* 676 SeqOp            */ __Matchers[676].Set(_entryRangeExpression, __Matchers[675]);
                /* 678 SeqOp            */ __Matchers[678].Set(_entryRangeExpression, __Matchers[677]);
                /* 679 AltOp            */ __Matchers[679].Set(_entryOrRange, _additiveExpression);
                /* 680 SeqOp            */ __Matchers[680].Set(_additiveExpression, _rangeOrEntryOperator, _additiveExpression);
                /* 682 AltOp            */ __Matchers[682].Set(__Matchers[681], __Matchers[380], __Matchers[419]);
                /* 683 AltOp            */ __Matchers[683].Set(_additiveExpr, _scaleExpression);
                /* 684 SeqOp            */ __Matchers[684].Set(_additiveExpression, _additiveOperator, _scaleExpression);
                /* 687 AltOp            */ __Matchers[687].Set(__Matchers[685], __Matchers[686]);
                /* 688 AltOp            */ __Matchers[688].Set(_scaleExpr, _multiplicativeExpression);
                /* 689 SeqOp            */ __Matchers[689].Set(_multiplicativeExpression, _scaleOperator, _scaleExpression);
                /* 691 AltOp            */ __Matchers[691].Set(_multiplicativeExpr, _unionExpression);
                /* 692 SeqOp            */ __Matchers[692].Set(_multiplicativeExpression, _multiplicativeOperator, _unionExpression);
                /* 695 AltOp            */ __Matchers[695].Set(__Matchers[602], __Matchers[693], __Matchers[694]);
                /* 696 AltOp            */ __Matchers[696].Set(_unionExpr, _exclusiveExpression);
                /* 697 SeqOp            */ __Matchers[697].Set(_unionExpression, _unionOperator, _exclusiveExpression);
                /* 699 AltOp            */ __Matchers[699].Set(__Matchers[466], __Matchers[698]);
                /* 700 AltOp            */ __Matchers[700].Set(_exclusiveExpr, _intersectionExpression);
                /* 701 SeqOp            */ __Matchers[701].Set(_exclusiveExpression, _exclusiveOperator, _intersectionExpression);
                /* 703 AltOp            */ __Matchers[703].Set(_intersectionExpr, _negationOrComplementExpression);
                /* 704 SeqOp            */ __Matchers[704].Set(_intersectionExpression, _intersectionOperator, _negationOrComplementExpression);
                /* 706 AltOp            */ __Matchers[706].Set(_negationOrComplementExpr, _prefixExpression);
                /* 707 SeqOp            */ __Matchers[707].Set(_unaryMinusOrComplementOperator, _negationOrComplementExpression);
                /* 708 AltOp            */ __Matchers[708].Set(_opNegate, _opNeutral, _opComplement);
                /* 709 NotOp            */ __Matchers[709].Set(__Matchers_709_DFA);
                /* 710 SeqOp            */ __Matchers[710].Set(__Matchers[686], __Matchers[709]);
                /* 711 NotOp            */ __Matchers[711].Set(__Matchers_711_DFA);
                /* 712 SeqOp            */ __Matchers[712].Set(__Matchers[685], __Matchers[711]);
                /* 713 AltOp            */ __Matchers[713].Set(_prefixExpr, _postfixExpression);
                /* 714 SeqOp            */ __Matchers[714].Set(_incrementOperator, _prefixExpression);
                /* 715 AltOp            */ __Matchers[715].Set(_postfixExpr, _primary);
                /* 716 SeqOp            */ __Matchers[716].Set(_postfixExpression, _incrementOperator);
                /* 719 AltOp            */ __Matchers[719].Set(__Matchers[717], __Matchers[718]);
                /* 720 AltOp            */ __Matchers[720].Set(_selectionExpression, _indexedExpression, _callExpression, _baseExpression);
                /* 721 SeqOp            */ __Matchers[721].Set(_primary, _qualifiedReference);
                /* 722 SeqOp            */ __Matchers[722].Set(_memberSelectionOperator, _baseReference);
                /* 725 AltOp            */ __Matchers[725].Set(__Matchers[411], __Matchers[723], __Matchers[724]);
                /* 726 SeqOp            */ __Matchers[726].Set(_primary, __Matchers[421], _index, __Matchers[423]);
                /* 727 AltOp            */ __Matchers[727].Set(_lowerSpanned, _upperSpanned, _spanned, _measured, _expression);
                /* 728 SeqOp            */ __Matchers[728].Set(_indexExpression, __Matchers[410]);
                /* 729 SeqOp            */ __Matchers[729].Set(__Matchers[410], _indexExpression);
                /* 730 SeqOp            */ __Matchers[730].Set(_indexExpression, __Matchers[681], _indexExpression);
                /* 731 SeqOp            */ __Matchers[731].Set(_indexExpression, __Matchers[380], _indexExpression);
                /* 732 SeqOp            */ __Matchers[732].Set(_primary, _arguments);
                /* 733 AltOp            */ __Matchers[733].Set(_nonstringLiteral, _stringExpression, _metaLiteral, _enumeration, _tuple, _objectExpression, _groupedExpression, _baseReferenceOrParameterized);
                /* 734 AltOp            */ __Matchers[734].Set(_literalNatural, _literalFloat, _literalChar);
                /* 735 AltOp            */ __Matchers[735].Set(_stringLiteral, _stringInterpolation);
                /* 736 StarOp           */ __Matchers[736].Set(_interpolationPart);
                /* 737 SeqOp            */ __Matchers[737].Set(_stringStart, _expression, __Matchers[736], _stringEnd);
                /* 738 SeqOp            */ __Matchers[738].Set(_stringMid, _expression);
                /* 739 AltOp            */ __Matchers[739].Set(_literalString, _verbatimString);
                /* 740 SeqOp            */ __Matchers[740].Set(__Matchers[520], __Matchers[521], __Matchers[507], _classBlock);
                /* 741 SeqOp            */ __Matchers[741].Set(__Matchers[433], _expression, __Matchers[434]);
                /* 742 OptionalOp       */ __Matchers[742].Set(_typeArgumentList);
                /* 743 SeqOp            */ __Matchers[743].Set(__Matchers[491], __Matchers[742], __Matchers[492]);
                /* 744 SeqOp            */ __Matchers[744].Set(__Matchers[400], _variancedType);
                /* 745 StarOp           */ __Matchers[745].Set(__Matchers[744]);
                /* 746 SeqOp            */ __Matchers[746].Set(_variancedType, __Matchers[745]);
                /* 747 SeqOp            */ __Matchers[747].Set(__Matchers[497], _type);
                /* 748 SeqOp            */ __Matchers[748].Set(__Matchers[400], _defaultedType);
                /* 749 StarOp           */ __Matchers[749].Set(__Matchers[748]);
                /* 750 SeqOp            */ __Matchers[750].Set(_defaultedType, __Matchers[749]);
                /* 751 AltOp            */ __Matchers[751].Set(_defaultedTypeCore, _variadicType);
                /* 752 SeqOp            */ __Matchers[752].Set(_type, __Matchers[408]);
                /* 753 AltOp            */ __Matchers[753].Set(_variadicUnionType, _type);
                /* 754 SeqOp            */ __Matchers[754].Set(_unionType, _variadicOperator);
                /* 755 AltOp            */ __Matchers[755].Set(__Matchers[602], __Matchers[685]);
                /* 756 SeqOp            */ __Matchers[756].Set(__Matchers[602], _unionType);
                /* 757 AltOp            */ __Matchers[757].Set(_entryType, _unionType);
                /* 758 SeqOp            */ __Matchers[758].Set(_unionType, __Matchers[419], _unionType);
                /* 759 AltOp            */ __Matchers[759].Set(_unionTypeCore, _intersectionType);
                /* 760 SeqOp            */ __Matchers[760].Set(_unionType, __Matchers[466], _intersectionType);
                /* 761 AltOp            */ __Matchers[761].Set(_intersectionTypeCore, _primaryType);
                /* 762 SeqOp            */ __Matchers[762].Set(_intersectionType, __Matchers[705], _primaryType);
                /* 763 AltOp            */ __Matchers[763].Set(_nullableType, _arrayType, _functionType, _tupleType, _iterableType, _groupedType, _qualifiedType);
                /* 765 SeqOp            */ __Matchers[765].Set(_primaryType, __Matchers[764]);
                /* 766 OptionalOp       */ __Matchers[766].Set(_literalNatural);
                /* 767 SeqOp            */ __Matchers[767].Set(_primaryType, __Matchers[421], __Matchers[766], __Matchers[423]);
                /* 768 OptionalOp       */ __Matchers[768].Set(_typeTypeArguments);
                /* 769 SeqOp            */ __Matchers[769].Set(_primaryType, __Matchers[433], __Matchers[768], __Matchers[434]);
                /* 770 AltOp            */ __Matchers[770].Set(_spreadType, _defaultedTypeList);
                /* 771 SeqOp            */ __Matchers[771].Set(__Matchers[421], __Matchers[768], __Matchers[423]);
                /* 772 OptionalOp       */ __Matchers[772].Set(_variadicType);
                /* 773 SeqOp            */ __Matchers[773].Set(__Matchers[387], __Matchers[772], __Matchers[389]);
                /* 774 SeqOp            */ __Matchers[774].Set(__Matchers[491], _type, __Matchers[492]);
                /* 775 SeqOp            */ __Matchers[775].Set(__Matchers[471], _typePath);
                /* 776 OptionalOp       */ __Matchers[776].Set(_stringLiteral);
                /* 777 StarOp           */ __Matchers[777].Set(_annotation);
                /* 778 SeqOp            */ __Matchers[778].Set(__Matchers[776], __Matchers[777]);
                /* 779 SeqOp            */ __Matchers[779].Set(_annotationName, __Matchers[446]);
                /* 780 OptionalOp       */ __Matchers[780].Set(_conditionList);
                /* 781 SeqOp            */ __Matchers[781].Set(__Matchers[433], __Matchers[780], __Matchers[434]);
                /* 782 SeqOp            */ __Matchers[782].Set(__Matchers[400], _condition);
                /* 783 StarOp           */ __Matchers[783].Set(__Matchers[782]);
                /* 784 SeqOp            */ __Matchers[784].Set(_condition, __Matchers[783]);
                /* 785 AltOp            */ __Matchers[785].Set(_existsCondition, _nonemptyCondition, _isCondition, _satisfiesCondition, _booleanCondition);
                /* 786 OptionalOp       */ __Matchers[786].Set(__Matchers[651]);
                /* 787 SeqOp            */ __Matchers[787].Set(__Matchers[786], __Matchers[675], _letOrExpression);
                /* 788 SeqOp            */ __Matchers[788].Set(__Matchers[786], __Matchers[677], _letOrExpression);
                /* 789 AltOp            */ __Matchers[789].Set(_letVariable, _operatorExpression);
                /* 790 SeqOp            */ __Matchers[790].Set(__Matchers[786], __Matchers[672], _type, _isConditionVariable);
                /* 791 SeqOp            */ __Matchers[791].Set(__Matchers[459], _type, _typeName);
                /* 792 AltOp            */ __Matchers[792].Set(_ifElse, _switchCaseElse, _whileLoop, _forElse, _tryCatchFinally);
                /* 793 OptionalOp       */ __Matchers[793].Set(_elseBlock);
                /* 794 SeqOp            */ __Matchers[794].Set(_ifBlock, __Matchers[793]);
                /* 795 SeqOp            */ __Matchers[795].Set(__Matchers[618], _conditions, _block);
                /* 796 SeqOp            */ __Matchers[796].Set(__Matchers[614], _elseBlockNext);
                /* 797 AltOp            */ __Matchers[797].Set(_ifElse, _block);
                /* 798 PlusOp           */ __Matchers[798].Set(_caseBlock);
                /* 799 SeqOp            */ __Matchers[799].Set(_switchHeader, __Matchers[798], __Matchers[793]);
                /* 801 SeqOp            */ __Matchers[801].Set(__Matchers[800], __Matchers[433], _switched, __Matchers[434]);
                /* 802 SeqOp            */ __Matchers[802].Set(__Matchers[615], __Matchers[616], __Matchers[433], _caseItem, __Matchers[434], _block);
                /* 803 AltOp            */ __Matchers[803].Set(_isCaseCondition, _satisfiesCaseCondition, _matchCaseCondition, _pattern);
                /* 804 OptionalOp       */ __Matchers[804].Set(__Matchers[672]);
                /* 805 SeqOp            */ __Matchers[805].Set(__Matchers[804], _type);
                /* 806 SeqOp            */ __Matchers[806].Set(__Matchers[459], _type);
                /* 807 SeqOp            */ __Matchers[807].Set(_valueCaseSeparator, _valueCase);
                /* 808 StarOp           */ __Matchers[808].Set(__Matchers[807]);
                /* 809 SeqOp            */ __Matchers[809].Set(_valueCase, __Matchers[808]);
                /* 810 AltOp            */ __Matchers[810].Set(__Matchers[400], __Matchers[466]);
                /* 811 AltOp            */ __Matchers[811].Set(_intersectionType, _intersectionExpression);
                /* 812 OptionalOp       */ __Matchers[812].Set(_failBlock);
                /* 813 SeqOp            */ __Matchers[813].Set(_forBlock, __Matchers[812]);
                /* 814 SeqOp            */ __Matchers[814].Set(__Matchers[633], __Matchers[433], __Matchers[634], __Matchers[434], _block);
                /* 815 SeqOp            */ __Matchers[815].Set(__Matchers[614], _block);
                /* 816 OptionalOp       */ __Matchers[816].Set(_containment);
                /* 817 SeqOp            */ __Matchers[817].Set(_forVariable, __Matchers[816]);
                /* 818 AltOp            */ __Matchers[818].Set(_tupleOrEntryPattern, _variable);
                /* 819 SeqOp            */ __Matchers[819].Set(_containmentOperator, _operatorExpression);
                /* 820 AltOp            */ __Matchers[820].Set(__Matchers[500], __Matchers[380]);
                /* 822 SeqOp            */ __Matchers[822].Set(__Matchers[821], _conditions, _block);
                /* 823 StarOp           */ __Matchers[823].Set(_catchBlock);
                /* 824 OptionalOp       */ __Matchers[824].Set(_finallyBlock);
                /* 825 SeqOp            */ __Matchers[825].Set(_tryBlock, __Matchers[823], __Matchers[824]);
                /* 827 OptionalOp       */ __Matchers[827].Set(_resources);
                /* 828 SeqOp            */ __Matchers[828].Set(__Matchers[826], __Matchers[827], _block);
                /* 830 SeqOp            */ __Matchers[830].Set(__Matchers[829], _catchVariable, _block);
                /* 831 OptionalOp       */ __Matchers[831].Set(_variable);
                /* 832 SeqOp            */ __Matchers[832].Set(__Matchers[433], __Matchers[831], __Matchers[434]);
                /* 834 SeqOp            */ __Matchers[834].Set(__Matchers[833], _block);
                /* 835 OptionalOp       */ __Matchers[835].Set(_resourceList);
                /* 836 SeqOp            */ __Matchers[836].Set(__Matchers[433], __Matchers[835], __Matchers[434]);
                /* 837 SeqOp            */ __Matchers[837].Set(__Matchers[400], _resource);
                /* 838 StarOp           */ __Matchers[838].Set(__Matchers[837]);
                /* 839 SeqOp            */ __Matchers[839].Set(_resource, __Matchers[838]);
                /* 840 AltOp            */ __Matchers[840].Set(_specifiedVariable, _operatorExpression);
                /* 841 SeqOp            */ __Matchers[841].Set(_variable, _valueSpecifier);
                /* 842 OptionalOp       */ __Matchers[842].Set(_variableType);
                /* 843 StarOp           */ __Matchers[843].Set(_parameters);
                /* 844 SeqOp            */ __Matchers[844].Set(__Matchers[842], _memberName, __Matchers[843]);
                /* 845 AltOp            */ __Matchers[845].Set(_type, _kwVoid, _kwFunction, _kwValue);
                /* 846 SeqOp            */ __Matchers[846].Set(__Matchers[702], _modelExpression);
                /* 848 SeqOp            */ __Matchers[848].Set(__Matchers[847], _metaExpression, __Matchers[847]);
                /* 849 AltOp            */ __Matchers[849].Set(_declarationReference, _modelExpression);
                /* 850 AltOp            */ __Matchers[850].Set(_memberModelExpression, _typeModelExpression);
                /* 851 AltOp            */ __Matchers[851].Set(_memberReference, _packageQualifiedMemberReference, _typeQualifiedMemberReference);
                /* 852 SeqOp            */ __Matchers[852].Set(_packageQualifier, _memberReference);
                /* 853 SeqOp            */ __Matchers[853].Set(_primaryType, __Matchers[411], _memberReference);
                /* 854 AltOp            */ __Matchers[854].Set(_moduleLiteral, _packageLiteral, _classLiteral, _newLiteral, _interfaceLiteral, _aliasLiteral, _typeParameterLiteral, _valueLiteral, _functionLiteral);
                /* 855 OptionalOp       */ __Matchers[855].Set(_packagePath);
                /* 856 SeqOp            */ __Matchers[856].Set(__Matchers[376], __Matchers[855]);
                /* 857 SeqOp            */ __Matchers[857].Set(__Matchers[392], __Matchers[855]);
                /* 858 SeqOp            */ __Matchers[858].Set(__Matchers[536], _referencePath);
                /* 859 SeqOp            */ __Matchers[859].Set(__Matchers[541], _referencePath);
                /* 860 SeqOp            */ __Matchers[860].Set(__Matchers[517], _referencePath);
                /* 861 SeqOp            */ __Matchers[861].Set(__Matchers[504], _referencePath);
                /* 862 SeqOp            */ __Matchers[862].Set(__Matchers[512], _referencePath);
                /* 863 SeqOp            */ __Matchers[863].Set(_valueLiteralIntro, _referencePath);
                /* 864 AltOp            */ __Matchers[864].Set(__Matchers[531], __Matchers[520]);
                /* 865 SeqOp            */ __Matchers[865].Set(__Matchers[528], _referencePath);
                /* 866 SeqOp            */ __Matchers[866].Set(__Matchers[471], _referencePathElementList);
                /* 867 SeqOp            */ __Matchers[867].Set(__Matchers[411], _referencePathElement);
                /* 868 StarOp           */ __Matchers[868].Set(__Matchers[867]);
                /* 869 SeqOp            */ __Matchers[869].Set(_referencePathElement, __Matchers[868]);

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
                _assignmentOperator_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true),
                    new DfaState(2, false),
                    new DfaState(3, false),
                    new DfaState(4, false)
                );
                _assignmentOperator_DFA.States[0].Set(
                    new DfaTrans(_assignmentOperator_DFA.States[1], new DfaInterval(61, 61)),
                    new DfaTrans(_assignmentOperator_DFA.States[2], new DfaInterval(37, 37), new DfaInterval(42, 43), new DfaInterval(45, 45), new DfaInterval(47, 47), new DfaInterval(126, 126)),
                    new DfaTrans(_assignmentOperator_DFA.States[3], new DfaInterval(38, 38)),
                    new DfaTrans(_assignmentOperator_DFA.States[4], new DfaInterval(124, 124))
                );
                _assignmentOperator_DFA.States[1].Set(
                );
                _assignmentOperator_DFA.States[2].Set(
                    new DfaTrans(_assignmentOperator_DFA.States[1], new DfaInterval(61, 61))
                );
                _assignmentOperator_DFA.States[3].Set(
                    new DfaTrans(_assignmentOperator_DFA.States[1], new DfaInterval(61, 61)),
                    new DfaTrans(_assignmentOperator_DFA.States[2], new DfaInterval(38, 38))
                );
                _assignmentOperator_DFA.States[4].Set(
                    new DfaTrans(_assignmentOperator_DFA.States[1], new DfaInterval(61, 61)),
                    new DfaTrans(_assignmentOperator_DFA.States[2], new DfaInterval(124, 124))
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
                __Matchers_709_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_709_DFA.States[0].Set(
                    new DfaTrans(__Matchers_709_DFA.States[1], new DfaInterval(45, 45))
                );
                __Matchers_709_DFA.States[1].Set(
                );
                __Matchers_711_DFA.Set(
                    new DfaState(0, false),
                    new DfaState(1, true)
                );
                __Matchers_711_DFA.States[0].Set(
                    new DfaTrans(__Matchers_711_DFA.States[1], new DfaInterval(43, 43))
                );
                __Matchers_711_DFA.States[1].Set(
                );
            }

            private PlainRule _compilationUnit;
            private PlainRule _unitElements;
            private PlainRule _unitElement;
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
            private PlainRule _importNameSpecifier;
            private PlainRule _importWildcard;
            private PlainRule _importName;
            private PlainRule _packagePath;
            private PlainRule _anyName;
            private PlainRule _packageName;
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
            private PlainRule _blockElement;
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
            private PlainRule _constructor;
            private PlainRule _enumeratedObject;
            private PlainRule _aliasDeclaration;
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
            private DfaRule _assignmentOperator;
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
            private PlainRule _ifElse;
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
            private PlainRule _forElse;
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

            private Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private Dfa __Keywords_DFA = new Dfa("%keywords");
            private Dfa _assignmentOperator_DFA = new Dfa("assignment-operator");
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
            private Dfa __Matchers_709_DFA = new Dfa("__Matchers_709_DFA");
            private Dfa __Matchers_711_DFA = new Dfa("__Matchers_711_DFA");
        }
    }

    public partial class CeylonTree
    {
        public interface IXStart {}
        public interface IXWhitespace {}
        public interface IXKeywords {}
        public interface ICompilationUnit {}
        public interface IUnitElements : ICompilationUnit {}
        public interface IUnitElement {}
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
        public interface IImportDeclaration : IBlockElement, IUnitElement {}
        public interface IImportElements {}
        public interface IImportElementList {}
        public interface IImportElement {}
        public interface IImportNamed : IImportElement {}
        public interface IImportNameSpecifier {}
        public interface IImportWildcard : IImportElement {}
        public interface IImportName {}
        public interface IPackagePath : IModuleName {}
        public interface IAnyName : IImportName, IPackageName, IReferencePathElement, IRepository {}
        public interface IPackageName {}
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
        public interface IBlockElement {}
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
        public interface IDeclarationOrStatement : IBlockElement {}
        public interface IDeclaration : IDeclarationOrStatement, IUnitElement {}
        public interface IConstructor : IDeclaration {}
        public interface IEnumeratedObject : IDeclaration {}
        public interface IAliasDeclaration : IDeclaration {}
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
        public interface IIfElse : IControlStatement, IElseBlockNext {}
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
        public interface IForElse : IControlStatement {}
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
        public interface ILowerIdentifier : IAnnotationName, IAnyName, IMemberName {}
        public interface IUpperIdentifier : IAnyName, ITypeName {}

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

        public partial class CUnitElements : RStar<IUnitElement>, IUnitElements
        {
            public CUnitElements(params RNode[] children) : base(children) {}
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
            public IImportName ImportName => Get<IImportName>(1);
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
            public RStar<IBlockElement> BlockElement => Get<RStar<IBlockElement>>(1);
            public RString String2 => Get<RString>(2);
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

        public partial class CConstructor : RSequence, IConstructor
        {
            public CConstructor(params RNode[] children) : base(children) {}

            public CAnnotations Annotations => Get<CAnnotations>(0);
            public RString String => Get<RString>(1);
            public ROptional<IMemberName> MemberName => Get<ROptional<IMemberName>>(2);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(3);
            public ROptional<CDelegatedConstructor> DelegatedConstructor => Get<ROptional<CDelegatedConstructor>>(4);
            public IBlock Block => Get<IBlock>(5);
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

        public partial class CIfElse : RSequence, IIfElse
        {
            public CIfElse(params RNode[] children) : base(children) {}

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

        public partial class CForElse : RSequence, IForElse
        {
            public CForElse(params RNode[] children) : base(children) {}

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

        public partial class DynamicCeylonVisitor : DynamicVisitor
        {
            public override void Walk(RNode node)
            {
                Visit((dynamic)node);
            }

            protected virtual void Visit(CXStart element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CXWhitespace element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CXKeywords element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnitElements element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CModuleDescriptor element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CModuleSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CArtifactAndClassifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CArtifact element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CClassifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CModuleBody element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackageDescriptor element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportModule element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportElements element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportElementList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportNamed element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportNameSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CImportWildcard element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackagePath element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEntryPattern element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTuplePattern element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariadicPatternList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariadicVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLetStatement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDelegatedConstructor element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAssertionStatement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CBlockElements element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExtendedType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CClassSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CClassInstatiation element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSuperQualifiedClass element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSuperQualifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackageQualifiedClass element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackageQualifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMemberPath element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypePath element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSatisfiedTypes element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnionTypeList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCaseTypes element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCaseTypeList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CQualifiedCaseType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CParameters element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CParameterList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CParameter element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CParameterReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionParameterDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueParameterDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeParameters element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeParameterList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeParameter element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariance element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeDefault element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeConstraint element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeConstraints element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CConstructor element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEnumeratedObject element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAliasDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CObjectDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSetterDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypedMethodDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInferredMethodDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypedAttributeDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInferredAttributeDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptionalAnySpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CClassDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptionalClassSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInterfaceDeclaration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptionalTypeSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnclosedStatement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpecificationStatement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CReturnDirective element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CThrowDirective element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CBreakDirective element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CContinueDirective element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CParametrizedMember element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSelfParametrizedMember element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMemberReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSelfReferenceSelector element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSelfReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEnumeration element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTuple element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStructuralArguments element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNamedSpecifiedArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSequencedArguments element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAnonymousArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CObjectArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypedMethodArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COptionalFunctionSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNeededFunctionSpecifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypedGetterArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInferredMethodArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInferredGetterArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUntypedMethodArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUntypedGetterArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPositionalArguments element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpreadArgument element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLetExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLetVariableList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLetVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSwitchExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCaseExpressions element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCaseExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIfExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CElseExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CThenExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionExpressionType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionParameters element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CForComprehensionClause element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIfComprehensionClause element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAssignment element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAssignmentOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CThenElse element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CThenElseOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDisjunction element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDisjunctionOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CConjunction element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CConjunctionOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLogicalNegation element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNotOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEquality element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEqualityOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CComparisonExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLargerExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSmallerExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLargerBoundsExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSmallerBoundsExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypecheckExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CComparisonOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSmallerOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLargerOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExistsExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNonemptyExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEntryOrRange element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CRangeOrEntryOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAdditiveExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAdditiveOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CScaleExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CScaleOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMultiplicativeExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMultiplicativeOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnionExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnionOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExclusiveExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExclusiveOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIntersectionExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIntersectionOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNegationOrComplementExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COpNegate element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COpNeutral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(COpComplement element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPrefixExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPostfixExpr element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIncrementOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSelectionExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CQualifiedReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMemberSelectionOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIndexedExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUpperSpanned element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLowerSpanned element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpanned element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMeasured element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCallExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStringInterpolation element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInterpolationPart element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CObjectExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CGroupedExpression element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeArguments element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeArgumentList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariancedType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDefaultedTypeList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CDefaultedTypeCore element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariadicUnionType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariadicOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpreadType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CEntryType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUnionTypeCore element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIntersectionTypeCore element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNullableType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CArrayType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTupleType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIterableType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CGroupedType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CQualifiedType element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAnnotations element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAnnotation element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CConditions element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CConditionList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CExistsCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNonemptyCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIsCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIsConditionVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSatisfiesCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIfElse element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIfBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CElseBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSwitchCaseElse element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSwitchHeader element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCaseBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CIsCaseCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSatisfiesCaseCondition element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueCaseList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueCaseSeparator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CForElse element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CForBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFailBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CForIterator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CContainment element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CContainmentOperator element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CWhileBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTryCatchFinally element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTryBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCatchBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CCatchVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFinallyBlock element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CResources element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CResourceList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CSpecifiedVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVariable element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CModelReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CMetaLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackageQualifiedMemberReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeQualifiedMemberReference element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CModuleLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CPackageLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CClassLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CInterfaceLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CAliasLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CTypeParameterLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CNewLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CValueLiteralIntro element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CFunctionLiteral element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CReferencePath element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CReferencePathElementList element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CKwVoid element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CKwFunction element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CKwValue element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLiteralFloat element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLiteralNatural element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLiteralChar element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStringStart element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStringMid element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CStringEnd element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLiteralString element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CVerbatimString element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CLowerIdentifier element)
            {
                VisitChildren(element);
            }

            protected virtual void Visit(CUpperIdentifier element)
            {
                VisitChildren(element);
            }
        }
    }
}
