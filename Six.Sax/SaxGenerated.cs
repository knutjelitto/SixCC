// <generated from="D:\\Six\\Six.Sax\\Sax.six" at="05.02.2022 03:14:41" />

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
                : base(new Mx.Matcher[144])
            {
                /*   0 StartRuleOp      */ __Matchers[0] = __Start = new Mx.StartRule(this, 0, "%start") { Builder = nodes => nodes[0] };
                /*   1 WhiteRuleOp      */ __Matchers[1] = __Whitespace = new Mx.WhiteRule(this, 1, "%whitespace") { Creator = node => new CXWhitespace(node) };
                /*   2 IdentifierRuleOp */ __Matchers[2] = __Keywords = new Mx.IdentifierRule(this, 2, "%keywords") { Creator = node => new CXKeywords(node) };
                /*   3 PlainRuleOp      */ __Matchers[3] = _compilationUnit = new Mx.PlainRule(this, 3, "compilation-unit") { Builder = nodes => nodes[0] };
                /*   4 PlainRuleOp      */ __Matchers[4] = _codeUnit = new Mx.PlainRule(this, 4, "code-unit") { Builder = nodes => nodes[0] };
                /*   5 PlainRuleOp      */ __Matchers[5] = _namespace = new Mx.PlainRule(this, 5, "namespace") { Builder = nodes => nodes[0] };
                /*   6 PlainRuleOp      */ __Matchers[6] = _fileNamespace = new Mx.PlainRule(this, 6, "file-namespace") { Builder = nodes => nodes[0] };
                /*   7 PlainRuleOp      */ __Matchers[7] = _blockNamespace = new Mx.PlainRule(this, 7, "block-namespace") { Builder = nodes => nodes[0] };
                /*   8 PlainRuleOp      */ __Matchers[8] = _namespaceIntro = new Mx.PlainRule(this, 8, "namespace-intro") { Builder = nodes => nodes[0] };
                /*   9 PlainRuleOp      */ __Matchers[9] = _namespacePath = new Mx.PlainRule(this, 9, "namespace-path") { Builder = nodes => nodes[0] };
                /*  10 PlainRuleOp      */ __Matchers[10] = _moduleDescriptor = new Mx.PlainRule(this, 10, "module-descriptor") { Builder = nodes => nodes[0] };
                /*  11 PlainRuleOp      */ __Matchers[11] = _moduleName = new Mx.PlainRule(this, 11, "module-name") { Builder = nodes => nodes[0] };
                /*  12 PlainRuleOp      */ __Matchers[12] = _moduleBody = new Mx.PlainRule(this, 12, "module-body") { Builder = nodes => nodes[0] };
                /*  13 PlainRuleOp      */ __Matchers[13] = _moduleBodyElement = new Mx.PlainRule(this, 13, "module-body-element") { Builder = nodes => nodes[0] };
                /*  14 PlainRuleOp      */ __Matchers[14] = _moduleImport = new Mx.PlainRule(this, 14, "module-import") { Builder = nodes => nodes[0] };
                /*  15 PlainRuleOp      */ __Matchers[15] = _usings = new Mx.PlainRule(this, 15, "usings") { Builder = nodes => nodes[0] };
                /*  16 PlainRuleOp      */ __Matchers[16] = _usingDeclaration = new Mx.PlainRule(this, 16, "using-declaration") { Builder = nodes => nodes[0] };
                /*  17 PlainRuleOp      */ __Matchers[17] = _usingElements = new Mx.PlainRule(this, 17, "using-elements") { Builder = nodes => nodes[0] };
                /*  18 PlainRuleOp      */ __Matchers[18] = _usingElementList = new Mx.PlainRule(this, 18, "using-element-list") { Builder = nodes => nodes[0] };
                /*  19 PlainRuleOp      */ __Matchers[19] = _usingElement = new Mx.PlainRule(this, 19, "using-element") { Builder = nodes => nodes[0] };
                /*  20 PlainRuleOp      */ __Matchers[20] = _usingNamed = new Mx.PlainRule(this, 20, "using-named") { Builder = nodes => nodes[0] };
                /*  21 PlainRuleOp      */ __Matchers[21] = _usingName = new Mx.PlainRule(this, 21, "using-name") { Builder = nodes => nodes[0] };
                /*  22 PlainRuleOp      */ __Matchers[22] = _usingNameSpecifier = new Mx.PlainRule(this, 22, "using-name-specifier") { Builder = nodes => nodes[0] };
                /*  23 PlainRuleOp      */ __Matchers[23] = _usingWildcard = new Mx.PlainRule(this, 23, "using-wildcard") { Creator = node => new CUsingWildcard(node) };
                /*  24 PlainRuleOp      */ __Matchers[24] = _anyPath = new Mx.PlainRule(this, 24, "any-path") { Builder = nodes => nodes[0] };
                /*  25 PlainRuleOp      */ __Matchers[25] = _name = new Mx.PlainRule(this, 25, "name") { Builder = nodes => nodes[0] };
                /*  26 PlainRuleOp      */ __Matchers[26] = _declarations = new Mx.PlainRule(this, 26, "declarations") { Builder = nodes => nodes[0] };
                /*  27 PlainRuleOp      */ __Matchers[27] = _declaration = new Mx.PlainRule(this, 27, "declaration") { Builder = nodes => nodes[0] };
                /*  28 PlainRuleOp      */ __Matchers[28] = _functionDeclaration = new Mx.PlainRule(this, 28, "function-declaration") { Builder = nodes => nodes[0] };
                /*  29 PlainRuleOp      */ __Matchers[29] = _functionBody = new Mx.PlainRule(this, 29, "function-body") { Builder = nodes => nodes[0] };
                /*  30 PlainRuleOp      */ __Matchers[30] = _classDeclaration = new Mx.PlainRule(this, 30, "class-declaration") { Builder = nodes => nodes[0] };
                /*  31 PlainRuleOp      */ __Matchers[31] = _extends = new Mx.PlainRule(this, 31, "extends") { Builder = nodes => nodes[0] };
                /*  32 PlainRuleOp      */ __Matchers[32] = _caseTypes = new Mx.PlainRule(this, 32, "case-types") { Builder = nodes => nodes[0] };
                /*  33 PlainRuleOp      */ __Matchers[33] = _caseTypeList = new Mx.PlainRule(this, 33, "case-type-list") { Builder = nodes => nodes[0] };
                /*  34 PlainRuleOp      */ __Matchers[34] = _classBody = new Mx.PlainRule(this, 34, "class-body") { Builder = nodes => nodes[0] };
                /*  35 PlainRuleOp      */ __Matchers[35] = _objectDeclaration = new Mx.PlainRule(this, 35, "object-declaration") { Builder = nodes => nodes[0] };
                /*  36 PlainRuleOp      */ __Matchers[36] = _prelude = new Mx.PlainRule(this, 36, "prelude") { Builder = nodes => nodes[0] };
                /*  37 PlainRuleOp      */ __Matchers[37] = _attribute = new Mx.PlainRule(this, 37, "attribute") { Builder = nodes => nodes[0] };
                /*  38 PlainRuleOp      */ __Matchers[38] = _attributeArguments = new Mx.PlainRule(this, 38, "attribute-arguments") { Builder = nodes => nodes[0] };
                /*  39 PlainRuleOp      */ __Matchers[39] = _type = new Mx.PlainRule(this, 39, "type") { Builder = nodes => nodes[0] };
                /*  40 PlainRuleOp      */ __Matchers[40] = _unionlevelType = new Mx.PlainRule(this, 40, "unionlevel-type") { Builder = nodes => nodes[0] };
                /*  41 PlainRuleOp      */ __Matchers[41] = _unionType = new Mx.PlainRule(this, 41, "union-type") { Builder = nodes => nodes[0] };
                /*  42 PlainRuleOp      */ __Matchers[42] = _intersectionlevelType = new Mx.PlainRule(this, 42, "intersectionlevel-type") { Builder = nodes => nodes[0] };
                /*  43 PlainRuleOp      */ __Matchers[43] = _intersectionType = new Mx.PlainRule(this, 43, "intersection-type") { Builder = nodes => nodes[0] };
                /*  44 PlainRuleOp      */ __Matchers[44] = _primaryType = new Mx.PlainRule(this, 44, "primary-type") { Builder = nodes => nodes[0] };
                /*  45 PlainRuleOp      */ __Matchers[45] = _parameters = new Mx.PlainRule(this, 45, "parameters") { Builder = nodes => nodes[0] };
                /*  46 PlainRuleOp      */ __Matchers[46] = _parameterList = new Mx.PlainRule(this, 46, "parameter-list") { Builder = nodes => nodes[0] };
                /*  47 PlainRuleOp      */ __Matchers[47] = _parameter = new Mx.PlainRule(this, 47, "parameter") { Builder = nodes => nodes[0] };
                /*  48 PlainRuleOp      */ __Matchers[48] = _statements = new Mx.PlainRule(this, 48, "statements") { Builder = nodes => nodes[0] };
                /*  49 PlainRuleOp      */ __Matchers[49] = _statement = new Mx.PlainRule(this, 49, "statement") { Builder = nodes => nodes[0] };
                /*  50 PlainRuleOp      */ __Matchers[50] = _returnStatement = new Mx.PlainRule(this, 50, "return-statement") { Builder = nodes => nodes[0] };
                /*  51 PlainRuleOp      */ __Matchers[51] = _expression = new Mx.PlainRule(this, 51, "expression") { Builder = nodes => nodes[0] };
                /*  52 PlainRuleOp      */ __Matchers[52] = _addlevelExpression = new Mx.PlainRule(this, 52, "addlevel-expression") { Builder = nodes => nodes[0] };
                /*  53 PlainRuleOp      */ __Matchers[53] = _addExpression = new Mx.PlainRule(this, 53, "add-expression") { Builder = nodes => nodes[0] };
                /*  54 PlainRuleOp      */ __Matchers[54] = _subExpression = new Mx.PlainRule(this, 54, "sub-expression") { Builder = nodes => nodes[0] };
                /*  55 PlainRuleOp      */ __Matchers[55] = _primaryExpression = new Mx.PlainRule(this, 55, "primary-expression") { Builder = nodes => nodes[0] };
                /*  56 DfaRuleOp        */ __Matchers[56] = _identifier = new Mx.DfaRule(this, 56, "identifier") { Creator = node => new CIdentifier(node) };
                /*  57 EofOp            */ __Matchers[57] = new Mx.Eof(this, 57, "<eof>") { Creator = node => new REof(node) };
                /*  58 SeqOp            */ __Matchers[58] = new Mx.Seq(this, 58, "_58:(>compilation-unit,<eof>)") { Builder = nodes => new CXStart(nodes) };
                /*  59 AltOp            */ __Matchers[59] = new Mx.Alt(this, 59, "alt(>module-descriptor|>code-unit)") { Builder = nodes => nodes[0] };
                /*  60 SeqOp            */ __Matchers[60] = new Mx.Seq(this, 60, "_60:(>usings,>namespace)") { Builder = nodes => new CCodeUnit(nodes) };
                /*  61 AltOp            */ __Matchers[61] = new Mx.Alt(this, 61, "alt(>file-namespace|>block-namespace)") { Builder = nodes => nodes[0] };
                /*  62 StringOp         */ __Matchers[62] = new Mx.String(this, 62, "';'", ";") { Creator = node => new RLiteral(node) };
                /*  63 SeqOp            */ __Matchers[63] = new Mx.Seq(this, 63, "_63:(>namespace-intro,';',>usings,>declarations)") { Builder = nodes => new CFileNamespace(nodes) };
                /*  64 StringOp         */ __Matchers[64] = new Mx.String(this, 64, "'{'", "{") { Creator = node => new RLiteral(node) };
                /*  65 StringOp         */ __Matchers[65] = new Mx.String(this, 65, "'}'", "}") { Creator = node => new RLiteral(node) };
                /*  66 SeqOp            */ __Matchers[66] = new Mx.Seq(this, 66, "_66:(>namespace-intro,'{',>usings,>declarations,'}')") { Builder = nodes => new CBlockNamespace(nodes) };
                /*  67 StringOp         */ __Matchers[67] = new Mx.Keyword(this, 67, "'namespace'", "namespace") { Creator = node => new RLiteral(node) };
                /*  68 SeqOp            */ __Matchers[68] = new Mx.Seq(this, 68, "_68:('namespace',>namespace-path)") { Builder = nodes => new CNamespaceIntro(nodes) };
                /*  69 StringOp         */ __Matchers[69] = new Mx.String(this, 69, "'.'", ".") { Creator = node => new RLiteral(node) };
                /*  70 SeqOp            */ __Matchers[70] = new Mx.Seq(this, 70, "_70:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /*  71 StarOp           */ __Matchers[71] = new Mx.Star(this, 71, "*(_70:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  72 SeqOp            */ __Matchers[72] = new Mx.Seq(this, 72, "_72:(>identifier,*(_70:('.',>identifier)))") { Builder = nodes => new CNamespacePath(nodes) };
                /*  73 StringOp         */ __Matchers[73] = new Mx.Keyword(this, 73, "'module'", "module") { Creator = node => new RLiteral(node) };
                /*  74 SeqOp            */ __Matchers[74] = new Mx.Seq(this, 74, "_74:('module',>module-name,>module-body)") { Builder = nodes => new CModuleDescriptor(nodes) };
                /*  75 StarOp           */ __Matchers[75] = new Mx.Star(this, 75, "*(>module-body-element)") { Builder = nodes => new RStar<ICModuleBodyElement>(nodes) };
                /*  76 SeqOp            */ __Matchers[76] = new Mx.Seq(this, 76, "_76:('{',*(>module-body-element),'}')") { Builder = nodes => new CModuleBody(nodes) };
                /*  77 StringOp         */ __Matchers[77] = new Mx.Keyword(this, 77, "'import'", "import") { Creator = node => new RLiteral(node) };
                /*  78 SeqOp            */ __Matchers[78] = new Mx.Seq(this, 78, "_78:('import',>module-name,';')") { Builder = nodes => new CModuleImport(nodes) };
                /*  79 StarOp           */ __Matchers[79] = new Mx.Star(this, 79, "*(>using-declaration)") { Builder = nodes => new CUsings(nodes) };
                /*  80 StringOp         */ __Matchers[80] = new Mx.Keyword(this, 80, "'using'", "using") { Creator = node => new RLiteral(node) };
                /*  81 SeqOp            */ __Matchers[81] = new Mx.Seq(this, 81, "_81:('using',>any-path,>using-elements)") { Builder = nodes => new CUsingDeclaration(nodes) };
                /*  82 OptionalOp       */ __Matchers[82] = new Mx.Optional(this, 82, "?(>using-element-list)") { Builder = nodes => new ROptional<CUsingElementList>(nodes) };
                /*  83 SeqOp            */ __Matchers[83] = new Mx.Seq(this, 83, "_83:('{',?(>using-element-list),'}')") { Builder = nodes => new CUsingElements(nodes) };
                /*  84 StringOp         */ __Matchers[84] = new Mx.String(this, 84, "','", ",") { Creator = node => new RLiteral(node) };
                /*  85 SeqOp            */ __Matchers[85] = new Mx.Seq(this, 85, "_85:(',',>using-element)") { Builder = nodes => new RSequence(nodes) };
                /*  86 StarOp           */ __Matchers[86] = new Mx.Star(this, 86, "*(_85:(',',>using-element))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  87 SeqOp            */ __Matchers[87] = new Mx.Seq(this, 87, "_87:(>using-element,*(_85:(',',>using-element)))") { Builder = nodes => new CUsingElementList(nodes) };
                /*  88 AltOp            */ __Matchers[88] = new Mx.Alt(this, 88, "alt(>using-named|>using-wildcard)") { Builder = nodes => nodes[0] };
                /*  89 OptionalOp       */ __Matchers[89] = new Mx.Optional(this, 89, "?(>using-name-specifier)") { Builder = nodes => new ROptional<CUsingNameSpecifier>(nodes) };
                /*  90 OptionalOp       */ __Matchers[90] = new Mx.Optional(this, 90, "?(>using-elements)") { Builder = nodes => new ROptional<CUsingElements>(nodes) };
                /*  91 SeqOp            */ __Matchers[91] = new Mx.Seq(this, 91, "_91:(>using-name,?(>using-name-specifier),?(>using-elements))") { Builder = nodes => new CUsingNamed(nodes) };
                /*  92 StringOp         */ __Matchers[92] = new Mx.String(this, 92, "'='", "=") { Creator = node => new RLiteral(node) };
                /*  93 SeqOp            */ __Matchers[93] = new Mx.Seq(this, 93, "_93:('=',>identifier)") { Builder = nodes => new CUsingNameSpecifier(nodes) };
                /*  94 StringOp         */ __Matchers[94] = new Mx.String(this, 94, "'...'", "...") { Creator = node => new CUsingWildcard(node) };
                /*  95 SeqOp            */ __Matchers[95] = new Mx.Seq(this, 95, "_95:('.',>identifier)") { Builder = nodes => new RSequence(nodes) };
                /*  96 StarOp           */ __Matchers[96] = new Mx.Star(this, 96, "*(_95:('.',>identifier))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /*  97 SeqOp            */ __Matchers[97] = new Mx.Seq(this, 97, "_97:(>identifier,*(_95:('.',>identifier)))") { Builder = nodes => new CAnyPath(nodes) };
                /*  98 StarOp           */ __Matchers[98] = new Mx.Star(this, 98, "*(>declaration)") { Builder = nodes => new CDeclarations(nodes) };
                /*  99 AltOp            */ __Matchers[99] = new Mx.Alt(this, 99, "alt(>function-declaration|>class-declaration|>object-declaration)") { Builder = nodes => nodes[0] };
                /* 100 StringOp         */ __Matchers[100] = new Mx.Keyword(this, 100, "'function'", "function") { Creator = node => new RLiteral(node) };
                /* 101 SeqOp            */ __Matchers[101] = new Mx.Seq(this, 101, "_101:(>prelude,>type,'function',>name,>parameters,>function-body)") { Builder = nodes => new CFunctionDeclaration(nodes) };
                /* 102 SeqOp            */ __Matchers[102] = new Mx.Seq(this, 102, "_102:('{',>usings,>declarations,>statements,'}')") { Builder = nodes => new CFunctionBody(nodes) };
                /* 103 StringOp         */ __Matchers[103] = new Mx.Keyword(this, 103, "'class'", "class") { Creator = node => new RLiteral(node) };
                /* 104 OptionalOp       */ __Matchers[104] = new Mx.Optional(this, 104, "?(>parameters)") { Builder = nodes => new ROptional<CParameters>(nodes) };
                /* 105 OptionalOp       */ __Matchers[105] = new Mx.Optional(this, 105, "?(>extends)") { Builder = nodes => new ROptional<CExtends>(nodes) };
                /* 106 OptionalOp       */ __Matchers[106] = new Mx.Optional(this, 106, "?(>case-types)") { Builder = nodes => new ROptional<CCaseTypes>(nodes) };
                /* 107 SeqOp            */ __Matchers[107] = new Mx.Seq(this, 107, "_107:(>prelude,'class',>name,?(>parameters),?(>extends),?(>case-types),>class-body)") { Builder = nodes => new CClassDeclaration(nodes) };
                /* 108 StringOp         */ __Matchers[108] = new Mx.String(this, 108, "':'", ":") { Creator = node => new RLiteral(node) };
                /* 109 SeqOp            */ __Matchers[109] = new Mx.Seq(this, 109, "_109:(':',>type)") { Builder = nodes => new CExtends(nodes) };
                /* 110 StringOp         */ __Matchers[110] = new Mx.Keyword(this, 110, "'of'", "of") { Creator = node => new RLiteral(node) };
                /* 111 SeqOp            */ __Matchers[111] = new Mx.Seq(this, 111, "_111:('of',>case-type-list)") { Builder = nodes => new CCaseTypes(nodes) };
                /* 112 StringOp         */ __Matchers[112] = new Mx.String(this, 112, "'|'", "|") { Creator = node => new RLiteral(node) };
                /* 113 SeqOp            */ __Matchers[113] = new Mx.Seq(this, 113, "_113:('|',>type)") { Builder = nodes => new RSequence(nodes) };
                /* 114 StarOp           */ __Matchers[114] = new Mx.Star(this, 114, "*(_113:('|',>type))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 115 SeqOp            */ __Matchers[115] = new Mx.Seq(this, 115, "_115:(>type,*(_113:('|',>type)))") { Builder = nodes => new CCaseTypeList(nodes) };
                /* 116 SeqOp            */ __Matchers[116] = new Mx.Seq(this, 116, "_116:('{',>usings,>declarations,'}')") { Builder = nodes => new CClassBody(nodes) };
                /* 117 StringOp         */ __Matchers[117] = new Mx.Keyword(this, 117, "'object'", "object") { Creator = node => new RLiteral(node) };
                /* 118 SeqOp            */ __Matchers[118] = new Mx.Seq(this, 118, "_118:(>prelude,'object',>name,?(>extends),>class-body)") { Builder = nodes => new CObjectDeclaration(nodes) };
                /* 119 StarOp           */ __Matchers[119] = new Mx.Star(this, 119, "*(>attribute)") { Builder = nodes => new CPrelude(nodes) };
                /* 120 OptionalOp       */ __Matchers[120] = new Mx.Optional(this, 120, "?(>attribute-arguments)") { Builder = nodes => new ROptional<CAttributeArguments>(nodes) };
                /* 121 SeqOp            */ __Matchers[121] = new Mx.Seq(this, 121, "_121:(>name,?(>attribute-arguments))") { Builder = nodes => new CAttribute(nodes) };
                /* 122 StringOp         */ __Matchers[122] = new Mx.String(this, 122, "'('", "(") { Creator = node => new RLiteral(node) };
                /* 123 StringOp         */ __Matchers[123] = new Mx.String(this, 123, "')'", ")") { Creator = node => new RLiteral(node) };
                /* 124 SeqOp            */ __Matchers[124] = new Mx.Seq(this, 124, "_124:('(',')')") { Builder = nodes => new CAttributeArguments(nodes) };
                /* 125 AltOp            */ __Matchers[125] = new Mx.Alt(this, 125, "alt(>union-type|>intersectionlevel-type)") { Builder = nodes => nodes[0] };
                /* 126 SeqOp            */ __Matchers[126] = new Mx.Seq(this, 126, "_126:(>unionlevel-type,'|',>intersectionlevel-type)") { Builder = nodes => new CUnionType(nodes) };
                /* 127 AltOp            */ __Matchers[127] = new Mx.Alt(this, 127, "alt(>intersection-type|>primary-type)") { Builder = nodes => nodes[0] };
                /* 128 StringOp         */ __Matchers[128] = new Mx.String(this, 128, "'&'", "&") { Creator = node => new RLiteral(node) };
                /* 129 SeqOp            */ __Matchers[129] = new Mx.Seq(this, 129, "_129:(>intersectionlevel-type,'&',>primary-type)") { Builder = nodes => new CIntersectionType(nodes) };
                /* 130 OptionalOp       */ __Matchers[130] = new Mx.Optional(this, 130, "?(>parameter-list)") { Builder = nodes => new ROptional<CParameterList>(nodes) };
                /* 131 SeqOp            */ __Matchers[131] = new Mx.Seq(this, 131, "_131:('(',?(>parameter-list),')')") { Builder = nodes => new CParameters(nodes) };
                /* 132 SeqOp            */ __Matchers[132] = new Mx.Seq(this, 132, "_132:(',',>parameter)") { Builder = nodes => new RSequence(nodes) };
                /* 133 StarOp           */ __Matchers[133] = new Mx.Star(this, 133, "*(_132:(',',>parameter))") { Builder = nodes => new RStar<RSequence>(nodes) };
                /* 134 SeqOp            */ __Matchers[134] = new Mx.Seq(this, 134, "_134:(>parameter,*(_132:(',',>parameter)))") { Builder = nodes => new CParameterList(nodes) };
                /* 135 SeqOp            */ __Matchers[135] = new Mx.Seq(this, 135, "_135:(>type,>name)") { Builder = nodes => new CParameter(nodes) };
                /* 136 StarOp           */ __Matchers[136] = new Mx.Star(this, 136, "*(>statement)") { Builder = nodes => new CStatements(nodes) };
                /* 137 StringOp         */ __Matchers[137] = new Mx.Keyword(this, 137, "'return'", "return") { Creator = node => new RLiteral(node) };
                /* 138 SeqOp            */ __Matchers[138] = new Mx.Seq(this, 138, "_138:('return',>expression,';')") { Builder = nodes => new CReturnStatement(nodes) };
                /* 139 AltOp            */ __Matchers[139] = new Mx.Alt(this, 139, "alt(>add-expression|>sub-expression|>primary-expression)") { Builder = nodes => nodes[0] };
                /* 140 StringOp         */ __Matchers[140] = new Mx.String(this, 140, "'+'", "+") { Creator = node => new RLiteral(node) };
                /* 141 SeqOp            */ __Matchers[141] = new Mx.Seq(this, 141, "_141:(>addlevel-expression,'+',>primary-expression)") { Builder = nodes => new CAddExpression(nodes) };
                /* 142 StringOp         */ __Matchers[142] = new Mx.String(this, 142, "'-'", "-") { Creator = node => new RLiteral(node) };
                /* 143 SeqOp            */ __Matchers[143] = new Mx.Seq(this, 143, "_143:(>addlevel-expression,'-',>primary-expression)") { Builder = nodes => new CSubExpression(nodes) };

                /*   0 StartRuleOp      */ __Start.Set(__Matchers[58]);
                /*   1 WhiteRuleOp      */ __Whitespace.Set(__Whitespace_DFA);
                /*   2 IdentifierRuleOp */ __Keywords.Set(__Keywords_DFA);
                /*   3 PlainRuleOp      */ _compilationUnit.Set(__Matchers[59]);
                /*   4 PlainRuleOp      */ _codeUnit.Set(__Matchers[60]);
                /*   5 PlainRuleOp      */ _namespace.Set(__Matchers[61]);
                /*   6 PlainRuleOp      */ _fileNamespace.Set(__Matchers[63]);
                /*   7 PlainRuleOp      */ _blockNamespace.Set(__Matchers[66]);
                /*   8 PlainRuleOp      */ _namespaceIntro.Set(__Matchers[68]);
                /*   9 PlainRuleOp      */ _namespacePath.Set(__Matchers[72]);
                /*  10 PlainRuleOp      */ _moduleDescriptor.Set(__Matchers[74]);
                /*  11 PlainRuleOp      */ _moduleName.Set(_anyPath);
                /*  12 PlainRuleOp      */ _moduleBody.Set(__Matchers[76]);
                /*  13 PlainRuleOp      */ _moduleBodyElement.Set(_moduleImport);
                /*  14 PlainRuleOp      */ _moduleImport.Set(__Matchers[78]);
                /*  15 PlainRuleOp      */ _usings.Set(__Matchers[79]);
                /*  16 PlainRuleOp      */ _usingDeclaration.Set(__Matchers[81]);
                /*  17 PlainRuleOp      */ _usingElements.Set(__Matchers[83]);
                /*  18 PlainRuleOp      */ _usingElementList.Set(__Matchers[87]);
                /*  19 PlainRuleOp      */ _usingElement.Set(__Matchers[88]);
                /*  20 PlainRuleOp      */ _usingNamed.Set(__Matchers[91]);
                /*  21 PlainRuleOp      */ _usingName.Set(_identifier);
                /*  22 PlainRuleOp      */ _usingNameSpecifier.Set(__Matchers[93]);
                /*  23 PlainRuleOp      */ _usingWildcard.Set(__Matchers[94]);
                /*  24 PlainRuleOp      */ _anyPath.Set(__Matchers[97]);
                /*  25 PlainRuleOp      */ _name.Set(_identifier);
                /*  26 PlainRuleOp      */ _declarations.Set(__Matchers[98]);
                /*  27 PlainRuleOp      */ _declaration.Set(__Matchers[99]);
                /*  28 PlainRuleOp      */ _functionDeclaration.Set(__Matchers[101]);
                /*  29 PlainRuleOp      */ _functionBody.Set(__Matchers[102]);
                /*  30 PlainRuleOp      */ _classDeclaration.Set(__Matchers[107]);
                /*  31 PlainRuleOp      */ _extends.Set(__Matchers[109]);
                /*  32 PlainRuleOp      */ _caseTypes.Set(__Matchers[111]);
                /*  33 PlainRuleOp      */ _caseTypeList.Set(__Matchers[115]);
                /*  34 PlainRuleOp      */ _classBody.Set(__Matchers[116]);
                /*  35 PlainRuleOp      */ _objectDeclaration.Set(__Matchers[118]);
                /*  36 PlainRuleOp      */ _prelude.Set(__Matchers[119]);
                /*  37 PlainRuleOp      */ _attribute.Set(__Matchers[121]);
                /*  38 PlainRuleOp      */ _attributeArguments.Set(__Matchers[124]);
                /*  39 PlainRuleOp      */ _type.Set(_unionlevelType);
                /*  40 PlainRuleOp      */ _unionlevelType.Set(__Matchers[125]);
                /*  41 PlainRuleOp      */ _unionType.Set(__Matchers[126]);
                /*  42 PlainRuleOp      */ _intersectionlevelType.Set(__Matchers[127]);
                /*  43 PlainRuleOp      */ _intersectionType.Set(__Matchers[129]);
                /*  44 PlainRuleOp      */ _primaryType.Set(_name);
                /*  45 PlainRuleOp      */ _parameters.Set(__Matchers[131]);
                /*  46 PlainRuleOp      */ _parameterList.Set(__Matchers[134]);
                /*  47 PlainRuleOp      */ _parameter.Set(__Matchers[135]);
                /*  48 PlainRuleOp      */ _statements.Set(__Matchers[136]);
                /*  49 PlainRuleOp      */ _statement.Set(_returnStatement);
                /*  50 PlainRuleOp      */ _returnStatement.Set(__Matchers[138]);
                /*  51 PlainRuleOp      */ _expression.Set(_addlevelExpression);
                /*  52 PlainRuleOp      */ _addlevelExpression.Set(__Matchers[139]);
                /*  53 PlainRuleOp      */ _addExpression.Set(__Matchers[141]);
                /*  54 PlainRuleOp      */ _subExpression.Set(__Matchers[143]);
                /*  55 PlainRuleOp      */ _primaryExpression.Set(_name);
                /*  56 DfaRuleOp        */ _identifier.Set(_identifier_DFA);
                /*  58 SeqOp            */ __Matchers[58].Set(_compilationUnit, __Matchers[57]);
                /*  59 AltOp            */ __Matchers[59].Set(_moduleDescriptor, _codeUnit);
                /*  60 SeqOp            */ __Matchers[60].Set(_usings, _namespace);
                /*  61 AltOp            */ __Matchers[61].Set(_fileNamespace, _blockNamespace);
                /*  63 SeqOp            */ __Matchers[63].Set(_namespaceIntro, __Matchers[62], _usings, _declarations);
                /*  66 SeqOp            */ __Matchers[66].Set(_namespaceIntro, __Matchers[64], _usings, _declarations, __Matchers[65]);
                /*  68 SeqOp            */ __Matchers[68].Set(__Matchers[67], _namespacePath);
                /*  70 SeqOp            */ __Matchers[70].Set(__Matchers[69], _identifier);
                /*  71 StarOp           */ __Matchers[71].Set(__Matchers[70]);
                /*  72 SeqOp            */ __Matchers[72].Set(_identifier, __Matchers[71]);
                /*  74 SeqOp            */ __Matchers[74].Set(__Matchers[73], _moduleName, _moduleBody);
                /*  75 StarOp           */ __Matchers[75].Set(_moduleBodyElement);
                /*  76 SeqOp            */ __Matchers[76].Set(__Matchers[64], __Matchers[75], __Matchers[65]);
                /*  78 SeqOp            */ __Matchers[78].Set(__Matchers[77], _moduleName, __Matchers[62]);
                /*  79 StarOp           */ __Matchers[79].Set(_usingDeclaration);
                /*  81 SeqOp            */ __Matchers[81].Set(__Matchers[80], _anyPath, _usingElements);
                /*  82 OptionalOp       */ __Matchers[82].Set(_usingElementList);
                /*  83 SeqOp            */ __Matchers[83].Set(__Matchers[64], __Matchers[82], __Matchers[65]);
                /*  85 SeqOp            */ __Matchers[85].Set(__Matchers[84], _usingElement);
                /*  86 StarOp           */ __Matchers[86].Set(__Matchers[85]);
                /*  87 SeqOp            */ __Matchers[87].Set(_usingElement, __Matchers[86]);
                /*  88 AltOp            */ __Matchers[88].Set(_usingNamed, _usingWildcard);
                /*  89 OptionalOp       */ __Matchers[89].Set(_usingNameSpecifier);
                /*  90 OptionalOp       */ __Matchers[90].Set(_usingElements);
                /*  91 SeqOp            */ __Matchers[91].Set(_usingName, __Matchers[89], __Matchers[90]);
                /*  93 SeqOp            */ __Matchers[93].Set(__Matchers[92], _identifier);
                /*  95 SeqOp            */ __Matchers[95].Set(__Matchers[69], _identifier);
                /*  96 StarOp           */ __Matchers[96].Set(__Matchers[95]);
                /*  97 SeqOp            */ __Matchers[97].Set(_identifier, __Matchers[96]);
                /*  98 StarOp           */ __Matchers[98].Set(_declaration);
                /*  99 AltOp            */ __Matchers[99].Set(_functionDeclaration, _classDeclaration, _objectDeclaration);
                /* 101 SeqOp            */ __Matchers[101].Set(_prelude, _type, __Matchers[100], _name, _parameters, _functionBody);
                /* 102 SeqOp            */ __Matchers[102].Set(__Matchers[64], _usings, _declarations, _statements, __Matchers[65]);
                /* 104 OptionalOp       */ __Matchers[104].Set(_parameters);
                /* 105 OptionalOp       */ __Matchers[105].Set(_extends);
                /* 106 OptionalOp       */ __Matchers[106].Set(_caseTypes);
                /* 107 SeqOp            */ __Matchers[107].Set(_prelude, __Matchers[103], _name, __Matchers[104], __Matchers[105], __Matchers[106], _classBody);
                /* 109 SeqOp            */ __Matchers[109].Set(__Matchers[108], _type);
                /* 111 SeqOp            */ __Matchers[111].Set(__Matchers[110], _caseTypeList);
                /* 113 SeqOp            */ __Matchers[113].Set(__Matchers[112], _type);
                /* 114 StarOp           */ __Matchers[114].Set(__Matchers[113]);
                /* 115 SeqOp            */ __Matchers[115].Set(_type, __Matchers[114]);
                /* 116 SeqOp            */ __Matchers[116].Set(__Matchers[64], _usings, _declarations, __Matchers[65]);
                /* 118 SeqOp            */ __Matchers[118].Set(_prelude, __Matchers[117], _name, __Matchers[105], _classBody);
                /* 119 StarOp           */ __Matchers[119].Set(_attribute);
                /* 120 OptionalOp       */ __Matchers[120].Set(_attributeArguments);
                /* 121 SeqOp            */ __Matchers[121].Set(_name, __Matchers[120]);
                /* 124 SeqOp            */ __Matchers[124].Set(__Matchers[122], __Matchers[123]);
                /* 125 AltOp            */ __Matchers[125].Set(_unionType, _intersectionlevelType);
                /* 126 SeqOp            */ __Matchers[126].Set(_unionlevelType, __Matchers[112], _intersectionlevelType);
                /* 127 AltOp            */ __Matchers[127].Set(_intersectionType, _primaryType);
                /* 129 SeqOp            */ __Matchers[129].Set(_intersectionlevelType, __Matchers[128], _primaryType);
                /* 130 OptionalOp       */ __Matchers[130].Set(_parameterList);
                /* 131 SeqOp            */ __Matchers[131].Set(__Matchers[122], __Matchers[130], __Matchers[123]);
                /* 132 SeqOp            */ __Matchers[132].Set(__Matchers[84], _parameter);
                /* 133 StarOp           */ __Matchers[133].Set(__Matchers[132]);
                /* 134 SeqOp            */ __Matchers[134].Set(_parameter, __Matchers[133]);
                /* 135 SeqOp            */ __Matchers[135].Set(_type, _name);
                /* 136 StarOp           */ __Matchers[136].Set(_statement);
                /* 138 SeqOp            */ __Matchers[138].Set(__Matchers[137], _expression, __Matchers[62]);
                /* 139 AltOp            */ __Matchers[139].Set(_addExpression, _subExpression, _primaryExpression);
                /* 141 SeqOp            */ __Matchers[141].Set(_addlevelExpression, __Matchers[140], _primaryExpression);
                /* 143 SeqOp            */ __Matchers[143].Set(_addlevelExpression, __Matchers[142], _primaryExpression);

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
                    new DfaState(42, true)
                );
                _identifier_DFA.States[0].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 101), new DfaInterval(103, 104), new DfaInterval(106, 108), new DfaInterval(112, 113), new DfaInterval(115, 116), new DfaInterval(118, 122)),
                    new DfaTrans(_identifier_DFA.States[2], new DfaInterval(99, 99)),
                    new DfaTrans(_identifier_DFA.States[7], new DfaInterval(102, 102)),
                    new DfaTrans(_identifier_DFA.States[14], new DfaInterval(105, 105)),
                    new DfaTrans(_identifier_DFA.States[19], new DfaInterval(109, 109)),
                    new DfaTrans(_identifier_DFA.States[24], new DfaInterval(110, 110)),
                    new DfaTrans(_identifier_DFA.States[31], new DfaInterval(111, 111)),
                    new DfaTrans(_identifier_DFA.States[35], new DfaInterval(114, 114)),
                    new DfaTrans(_identifier_DFA.States[39], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[1].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.States[2].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[3], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[3].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[4], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[4].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[5], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[5].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[6].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 122), new DfaInterval(128, 65535))
                );
                _identifier_DFA.States[7].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[8], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[8].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[9], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[9].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[10], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[10].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[11], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[11].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[12], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[12].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[13], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[13].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[14].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[15], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[15].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[16], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[16].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[17], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[17].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[18].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[19].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 110), new DfaInterval(112, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[20], new DfaInterval(111, 111))
                );
                _identifier_DFA.States[20].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 99), new DfaInterval(101, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[21], new DfaInterval(100, 100))
                );
                _identifier_DFA.States[21].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[22], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[22].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 107), new DfaInterval(109, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(108, 108))
                );
                _identifier_DFA.States[23].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[24].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[25], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[25].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 108), new DfaInterval(110, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[26], new DfaInterval(109, 109))
                );
                _identifier_DFA.States[26].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[27], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[27].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[28], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[28].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 111), new DfaInterval(113, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[29], new DfaInterval(112, 112))
                );
                _identifier_DFA.States[29].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(98, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[30], new DfaInterval(97, 97))
                );
                _identifier_DFA.States[30].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[23], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[31].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 97), new DfaInterval(99, 101), new DfaInterval(103, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[32], new DfaInterval(98, 98)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(102, 102))
                );
                _identifier_DFA.States[32].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 105), new DfaInterval(107, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[33], new DfaInterval(106, 106))
                );
                _identifier_DFA.States[33].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[34], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[34].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 98), new DfaInterval(100, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[18], new DfaInterval(99, 99))
                );
                _identifier_DFA.States[35].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 100), new DfaInterval(102, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[36], new DfaInterval(101, 101))
                );
                _identifier_DFA.States[36].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 115), new DfaInterval(117, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[37], new DfaInterval(116, 116))
                );
                _identifier_DFA.States[37].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 116), new DfaInterval(118, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[38], new DfaInterval(117, 117))
                );
                _identifier_DFA.States[38].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 113), new DfaInterval(115, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[13], new DfaInterval(114, 114))
                );
                _identifier_DFA.States[39].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 114), new DfaInterval(116, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[40], new DfaInterval(115, 115))
                );
                _identifier_DFA.States[40].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 104), new DfaInterval(106, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[41], new DfaInterval(105, 105))
                );
                _identifier_DFA.States[41].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 109), new DfaInterval(111, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[42], new DfaInterval(110, 110))
                );
                _identifier_DFA.States[42].Set(
                    new DfaTrans(_identifier_DFA.States[1], new DfaInterval(48, 57), new DfaInterval(65, 90), new DfaInterval(95, 95), new DfaInterval(97, 102), new DfaInterval(104, 122), new DfaInterval(128, 65535)),
                    new DfaTrans(_identifier_DFA.States[6], new DfaInterval(103, 103))
                );
            }

            private readonly Mx.PlainRule _compilationUnit;
            private readonly Mx.PlainRule _codeUnit;
            private readonly Mx.PlainRule _namespace;
            private readonly Mx.PlainRule _fileNamespace;
            private readonly Mx.PlainRule _blockNamespace;
            private readonly Mx.PlainRule _namespaceIntro;
            private readonly Mx.PlainRule _namespacePath;
            private readonly Mx.PlainRule _moduleDescriptor;
            private readonly Mx.PlainRule _moduleName;
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
            private readonly Mx.PlainRule _anyPath;
            private readonly Mx.PlainRule _name;
            private readonly Mx.PlainRule _declarations;
            private readonly Mx.PlainRule _declaration;
            private readonly Mx.PlainRule _functionDeclaration;
            private readonly Mx.PlainRule _functionBody;
            private readonly Mx.PlainRule _classDeclaration;
            private readonly Mx.PlainRule _extends;
            private readonly Mx.PlainRule _caseTypes;
            private readonly Mx.PlainRule _caseTypeList;
            private readonly Mx.PlainRule _classBody;
            private readonly Mx.PlainRule _objectDeclaration;
            private readonly Mx.PlainRule _prelude;
            private readonly Mx.PlainRule _attribute;
            private readonly Mx.PlainRule _attributeArguments;
            private readonly Mx.PlainRule _type;
            private readonly Mx.PlainRule _unionlevelType;
            private readonly Mx.PlainRule _unionType;
            private readonly Mx.PlainRule _intersectionlevelType;
            private readonly Mx.PlainRule _intersectionType;
            private readonly Mx.PlainRule _primaryType;
            private readonly Mx.PlainRule _parameters;
            private readonly Mx.PlainRule _parameterList;
            private readonly Mx.PlainRule _parameter;
            private readonly Mx.PlainRule _statements;
            private readonly Mx.PlainRule _statement;
            private readonly Mx.PlainRule _returnStatement;
            private readonly Mx.PlainRule _expression;
            private readonly Mx.PlainRule _addlevelExpression;
            private readonly Mx.PlainRule _addExpression;
            private readonly Mx.PlainRule _subExpression;
            private readonly Mx.PlainRule _primaryExpression;
            private readonly Mx.DfaRule _identifier;

            private readonly Dfa __Whitespace_DFA = new Dfa("%whitespace");
            private readonly Dfa __Keywords_DFA = new Dfa("%keywords");
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
        public interface ICFileNamespace : ICNamespace {}
        public interface ICBlockNamespace : ICNamespace {}
        public interface ICNamespaceIntro : IRNode {}
        public interface ICNamespacePath : IRNode {}
        public interface ICModuleDescriptor : ICCompilationUnit {}
        public interface ICModuleName : IRNode {}
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
        public interface ICAnyPath : ICModuleName {}
        public interface ICName : ICPrimaryExpression, ICPrimaryType {}
        public interface ICDeclarations : IRNode {}
        public interface ICDeclaration : IRNode {}
        public interface ICFunctionDeclaration : ICDeclaration {}
        public interface ICFunctionBody : IRNode {}
        public interface ICClassDeclaration : ICDeclaration {}
        public interface ICExtends : IRNode {}
        public interface ICCaseTypes : IRNode {}
        public interface ICCaseTypeList : IRNode {}
        public interface ICClassBody : IRNode {}
        public interface ICObjectDeclaration : ICDeclaration {}
        public interface ICPrelude : IRNode {}
        public interface ICAttribute : IRNode {}
        public interface ICAttributeArguments : IRNode {}
        public interface ICType : IRNode {}
        public interface ICUnionlevelType : ICType {}
        public interface ICUnionType : ICUnionlevelType {}
        public interface ICIntersectionlevelType : ICUnionlevelType {}
        public interface ICIntersectionType : ICIntersectionlevelType {}
        public interface ICPrimaryType : ICIntersectionlevelType {}
        public interface ICParameters : IRNode {}
        public interface ICParameterList : IRNode {}
        public interface ICParameter : IRNode {}
        public interface ICStatements : IRNode {}
        public interface ICStatement : IRNode {}
        public interface ICReturnStatement : ICStatement {}
        public interface ICExpression : IRNode {}
        public interface ICAddlevelExpression : ICExpression {}
        public interface ICAddExpression : ICAddlevelExpression {}
        public interface ICSubExpression : ICAddlevelExpression {}
        public interface ICPrimaryExpression : ICAddlevelExpression {}
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

            public CUsings Usings => Get<CUsings>(0);
            public ICNamespace Namespace => Get<ICNamespace>(1);
        }

        public partial class CFileNamespace : RSequence, ICFileNamespace
        {
            // sequence
            public CFileNamespace(params RNode[] children) : base(children) {}

            public CNamespaceIntro NamespaceIntro => Get<CNamespaceIntro>(0);
            public RLiteral Literal => Get<RLiteral>(1); // ';'
            public CUsings Usings => Get<CUsings>(2);
            public CDeclarations Declarations => Get<CDeclarations>(3);
        }

        public partial class CBlockNamespace : RSequence, ICBlockNamespace
        {
            // sequence
            public CBlockNamespace(params RNode[] children) : base(children) {}

            public CNamespaceIntro NamespaceIntro => Get<CNamespaceIntro>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '{'
            public CUsings Usings => Get<CUsings>(2);
            public CDeclarations Declarations => Get<CDeclarations>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '}'
        }

        public partial class CNamespaceIntro : RSequence, ICNamespaceIntro
        {
            // sequence
            public CNamespaceIntro(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'namespace'
            public CNamespacePath NamespacePath => Get<CNamespacePath>(1);
        }

        public partial class CNamespacePath : RLoop<CIdentifier>, ICNamespacePath
        {
            // sequence
            public CNamespacePath(params RNode[] children) : base(children) {}
        }

        public partial class CModuleDescriptor : RSequence, ICModuleDescriptor
        {
            // sequence
            public CModuleDescriptor(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'module'
            public ICModuleName ModuleName => Get<ICModuleName>(1);
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
            public ICModuleName ModuleName => Get<ICModuleName>(1);
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
            public CAnyPath AnyPath => Get<CAnyPath>(1);
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

        public partial class CAnyPath : RLoop<CIdentifier>, ICAnyPath
        {
            // sequence
            public CAnyPath(params RNode[] children) : base(children) {}
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
            public ICType Type => Get<ICType>(1);
            public RLiteral Literal => Get<RLiteral>(2); // 'function'
            public ICName Name => Get<ICName>(3);
            public CParameters Parameters => Get<CParameters>(4);
            public CFunctionBody FunctionBody => Get<CFunctionBody>(5);
        }

        public partial class CFunctionBody : RSequence, ICFunctionBody
        {
            // sequence
            public CFunctionBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUsings Usings => Get<CUsings>(1);
            public CDeclarations Declarations => Get<CDeclarations>(2);
            public CStatements Statements => Get<CStatements>(3);
            public RLiteral Literal2 => Get<RLiteral>(4); // '}'
        }

        public partial class CClassDeclaration : RSequence, ICClassDeclaration
        {
            // sequence
            public CClassDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'class'
            public ICName Name => Get<ICName>(2);
            public ROptional<CParameters> Parameters => Get<ROptional<CParameters>>(3);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(4);
            public ROptional<CCaseTypes> CaseTypes => Get<ROptional<CCaseTypes>>(5);
            public CClassBody ClassBody => Get<CClassBody>(6);
        }

        public partial class CExtends : RSequence, ICExtends
        {
            // sequence
            public CExtends(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // ':'
            public ICType Type => Get<ICType>(1);
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

        public partial class CClassBody : RSequence, ICClassBody
        {
            // sequence
            public CClassBody(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // '{'
            public CUsings Usings => Get<CUsings>(1);
            public CDeclarations Declarations => Get<CDeclarations>(2);
            public RLiteral Literal2 => Get<RLiteral>(3); // '}'
        }

        public partial class CObjectDeclaration : RSequence, ICObjectDeclaration
        {
            // sequence
            public CObjectDeclaration(params RNode[] children) : base(children) {}

            public CPrelude Prelude => Get<CPrelude>(0);
            public RLiteral Literal => Get<RLiteral>(1); // 'object'
            public ICName Name => Get<ICName>(2);
            public ROptional<CExtends> Extends => Get<ROptional<CExtends>>(3);
            public CClassBody ClassBody => Get<CClassBody>(4);
        }

        public partial class CPrelude : RStar<CAttribute>, ICPrelude
        {
            // *star*
            public CPrelude(params RNode[] children) : base(children) {}
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
            public RLiteral Literal2 => Get<RLiteral>(1); // ')'
        }

        public partial class CUnionType : RSequence, ICUnionType
        {
            // sequence
            public CUnionType(params RNode[] children) : base(children) {}

            public ICUnionlevelType UnionlevelType => Get<ICUnionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '|'
            public ICIntersectionlevelType IntersectionlevelType => Get<ICIntersectionlevelType>(2);
        }

        public partial class CIntersectionType : RSequence, ICIntersectionType
        {
            // sequence
            public CIntersectionType(params RNode[] children) : base(children) {}

            public ICIntersectionlevelType IntersectionlevelType => Get<ICIntersectionlevelType>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '&'
            public ICPrimaryType PrimaryType => Get<ICPrimaryType>(2);
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

            public ICType Type => Get<ICType>(0);
            public ICName Name => Get<ICName>(1);
        }

        public partial class CStatements : RStar<ICStatement>, ICStatements
        {
            // *star*
            public CStatements(params RNode[] children) : base(children) {}
        }

        public partial class CReturnStatement : RSequence, ICReturnStatement
        {
            // sequence
            public CReturnStatement(params RNode[] children) : base(children) {}

            public RLiteral Literal => Get<RLiteral>(0); // 'return'
            public ICExpression Expression => Get<ICExpression>(1);
            public RLiteral Literal2 => Get<RLiteral>(2); // ';'
        }

        public partial class CAddExpression : RSequence, ICAddExpression
        {
            // sequence
            public CAddExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '+'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
        }

        public partial class CSubExpression : RSequence, ICSubExpression
        {
            // sequence
            public CSubExpression(params RNode[] children) : base(children) {}

            public ICAddlevelExpression AddlevelExpression => Get<ICAddlevelExpression>(0);
            public RLiteral Literal => Get<RLiteral>(1); // '-'
            public ICPrimaryExpression PrimaryExpression => Get<ICPrimaryExpression>(2);
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

            protected virtual void Visit(CFileNamespace element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CBlockNamespace element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNamespaceIntro element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CNamespacePath element)
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

            protected virtual void Visit(CAnyPath element)
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

            protected virtual void Visit(CFunctionBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CClassDeclaration element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CExtends element)
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

            protected virtual void Visit(CClassBody element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CObjectDeclaration element)
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

            protected virtual void Visit(CUnionType element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CIntersectionType element)
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

            protected virtual void Visit(CStatements element)
            {
                DefaultImplementation(element);
            }

            protected virtual void Visit(CReturnStatement element)
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

            protected virtual void Visit(CIdentifier element)
            {
                DefaultImplementation(element);
            }
        }
    }
}
