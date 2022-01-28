using Six.Ceylon.Ast;
using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor : DynamicCeylonVisitor
    {
        public CeylonVisitor(World world)
        {
            World = world;
        }

        public World World { get; }

        public void Walk(SourceFile source)
        {
            if (source.Tree != null)
            {
                Walk(source.Tree);
            }
        }

        private void WalkChildrenTodo(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }

        protected override void WalkChildren(RNode element)
        {
            WalkChildrenTodo(element);
        }

        protected override void DefaultImplementation(RNode element)
        {
            Console.WriteLine($"Type ``{element.GetType().Name}´´ not implemented");

            throw new NotImplementedException();
        }

        protected override void Visit(CXStart element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CPackageDescriptor element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CCodeUnit element)
        {
#if true
            var imports = Walk<ImportList>(element.Imports);
            Walk(element.Namespace);

            var path = element.Namespace.NamespacePath.GetValue<IdentifierList>()!;

            using (World.CreateNamespace(path))
            {
                Walk(element.Declarations);
            }
#endif
        }

        protected override void Visit(CNamespace element)
        {
            //TODO: Visitor - Annotations
            //Walk(element.Annotations);
            Walk(element.NamespacePath);
        }

        protected override void Visit(CNamespacePath element)
        {
            element.Value = new IdentifierList(element.Children.Select(child => Walk<Identifier>(child)));
        }

        protected override void Visit(CDeclarations element)
        {
            element.Value = new DeclarationList(element.Children.Select(child => Walk<Declaration>(child)));
        }

        protected override void Visit(COptionalAnySpecifier element)
        {
            element.Value = Walk<Expression.Specifier>(element.AnySpecifier);
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            // '=>'
            element.Value = new Expression.FunctionSpecifier(
                element.Literal.GetText(),
                Walk<IExpression>(element.Expression));
        }

        protected override void Visit(COptionalFunctionSpecifier element)
        {
            element.Value = Walk<Expression.FunctionSpecifier>(element.FunctionSpecifier);
            // ';'
        }

        protected override void Visit(CRequiredFunctionSpecifier element)
        {
            element.Value = Walk<Expression.FunctionSpecifier>(element.FunctionSpecifier);
            // ';'
        }

        protected override void Visit(CValueSpecifier element)
        {
            // '='
            element.Value = new Expression.ValueSpecifier(
                element.Literal.GetText(),
                Walk<IExpression>(element.Expression));
        }

        protected override void Visit(COptionalClassSpecifier element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CClassSpecifier element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CBlock element)
        {
            // '{'
            var imports = Walk<ImportList>(element.Imports);
            var statements = Walk<StatementList>(element.Statements);
            // '}'

            element.Value = new Block(imports, statements);
        }

        protected override void Visit(COptionalTypeSpecifier element)
        {
            element.Value = Walk<Typo.Specifier>(element.TypeSpecifier);
        }

        protected override void Visit(CTypeSpecifier element)
        {
            // '=>' type
            var type = Walk<Typo>(element.Type);

            element.Value = new Typo.Specifier(type);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CModuleSpecifier element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CModuleBody element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CModuleImport element)
        {
            WalkChildrenTodo(element);
        }
        protected override void Visit(CSuperQualifiedClass element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CDelegatedConstructor element)
        {
            element.Value = Walk<Instantiation>(element.ClassInstantiation);
        }

        /**********************************************************************
         *  Patterns / Variables
         **********************************************************************/
        protected override void Visit(CVariable element)
        {
            var type = Walk<Typo>(element.VariableType);
            var name = Walk<Identifier>(element.MemberName);
            var items = element.Parameters.Children.Select(child => Walk<ParameterList>(child));
            var parameters = new ParameterListList(items);

            element.Value = new Variable(type, name, parameters);
        }

        protected override void Visit(CVariadicVariable element)
        {
            var type = Walk<Typo>(element.UnionType);
            var op = element.VariadicOperator.GetText();
            var name = Walk<Identifier>(element.MemberName);

            element.Value = new Variadic(type, op, name);
        }

        protected override void Visit(CLetVariable element)
        {
            WalkChildrenTodo(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CEntryPattern element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTuplePattern element)
        {
            var patterns = Walk<PatternList>(element.VariadicPatternList) ?? new PatternList(Enumerable.Empty<Pattern>());

            element.Value = new Pattern.Tuple(patterns);
        }

        protected override void Visit(CVariadicPatternList element)
        {
            var items = element.Elements.Select(child => Walk<Pattern>(child)).ToList();

            element.Value = new PatternList(items);
        }



        /*---------------------------------------------------------------------
         *  Expression - Arguments
         *--------------------------------------------------------------------*/
        protected override void Visit(CPositionalArguments element)
        {
            // '('
            var sequenced = Walk<ArgumentList>(element.SequencedArgumentList) ?? new ArgumentList(Enumerable.Empty<Argument>());
            // ')
            element.Value = new Arguments.Positional(sequenced);
        }

        protected override void Visit(CPatternedArguments element)
        {
            // '{'
            var structured = new ArgumentList(element.StructuredArgument.Select(child => Walk<Argument>(child)));
            var sequenced = Walk<ArgumentList>(element.SequencedArgumentList) ?? new ArgumentList(Enumerable.Empty<Argument>());
            // '}'
            element.Value = new Arguments.Patterned(structured, sequenced);
        }

        protected override void Visit(CSequencedArgumentList element)
        {
            var items = element.Elements.Select(child => Walk<Argument>(child));

            element.Value = new ArgumentList(items);
        }

        protected override void Visit(CSpreadArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CNamedSpecifiedArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CAnonymousArgument element)
        {
            var expr = Walk<IExpression>(element.Expression);

            element.Value = new Argument.Expression(expr);
        }

        protected override void Visit(CUntypedMethodArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CInferredMethodArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypedMethodArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CForComprehensionClause element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CIfComprehensionClause element)
        {
            WalkChildrenTodo(element);
        }


        /*---------------------------------------------------------------------
         *  Expression - Helpers
         *--------------------------------------------------------------------*/
        protected override void Visit(CSpecifiedVariable element)
        {
            WalkChildrenTodo(element);
        }
        protected override void Visit(CValueCaseList element)
        {
            WalkChildrenTodo(element);
        }


        /*---------------------------------------------------------------------
         *  Names / References / Literals
         *--------------------------------------------------------------------*/
        protected override void Visit(CMetaLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CModuleLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CClassLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Meta.Class(path);
        }

        protected override void Visit(CInterfaceLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CFunctionLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Meta.Function(path);
        }

        protected override void Visit(CValueLiteral element)
        {
            var path = Walk<ReferencePath>(element.ReferencePath);

            element.Value = new Meta.Value(path);
        }

        protected override void Visit(CAliasLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CNewLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CPackageLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeParameterLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CValueLiteralIntro element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CPackagePath element)
        {
            var names = element.Elements.Select(child => Walk<Identifier>(child));

            element.Value = new IdentifierList(names);
        }

        protected override void Visit(CReferencePath element)
        {
            var package = element.PackageQualifier.Children.Length > 0;
            var items = element.ReferencePathElementList.Elements.Select(child => Walk<Identifier>(child));
            var names = new IdentifierList(items);

            element.Value = new ReferencePath(package, names);
        }

        protected override void Visit(CReferencePathElementList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CMemberReference element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var arguments = Walk<TypeArgumentList>(element.TypeArguments) ?? new TypeArgumentList(Enumerable.Empty<Typo>());

            element.Value = new MemberReference(name, arguments);
        }

        protected override void Visit(CTypeReference element)
        {
            var name = Walk<Identifier>(element.TypeName);
            var arguments = Walk<TypeArgumentList>(element.TypeArguments) ?? new TypeArgumentList(Enumerable.Empty<Typo>());

            element.Value = new TypeReference(name, arguments);
        }

        protected override void Visit(CTypeArguments element)
        {
            element.Value = Walk<TypeArgumentList>(element.TypeArgumentList);
        }

        protected override void Visit(CTypeArgumentList element)
        {
            var items = element.Elements.Select(child => Walk<Typo.Varianced>(child));

            element.Value = new TypeArgumentList(items);
        }

        protected override void Visit(CVariance element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CPackageQualifier element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CKwVoid element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CKwValue element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CKwFunction element)
        {
            WalkChildrenTodo(element);
        }

        /**********************************************************************
         *  Operators
         **********************************************************************/

        protected override void Visit(CNotOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CVariadicOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CEntryOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CLargerOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CSmallerOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CIncrementOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CConjunctionOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CAdditiveOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CMultiplicativeOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CMemberSelectionOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CEqualityOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CContainmentOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CRangeOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CAssignmentOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CComparisonOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CDisjunctionOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CTypeOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CThenElseOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CIntersectionOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CNegateOperator element)
        {
            element.Value = element.Literal.GetText();
        }

        protected override void Visit(CExclusiveOperator element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CSelfReference element)
        {
            element.Value = new Expression.SelfReference(element.GetText());
        }
    }
}
