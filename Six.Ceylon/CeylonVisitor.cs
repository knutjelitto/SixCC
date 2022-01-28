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

        protected override void Visit(CClassInstatiation element)
        {
            //TODO
            Walk(element.QualifiedClass);
            var arguments = Walk<ArgumentList>(element.Arguments);
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
            WalkChildrenTodo(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Parameters
         *--------------------------------------------------------------------*/
        protected override void Visit(CFunctionParameters element)
        {
            WalkChildrenTodo(element);
        }

        /**********************************************************************
         *  Patterns / Variables
         **********************************************************************/
        protected override void Visit(CVariable element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CVariadicVariable element)
        {
            WalkChildrenTodo(element);
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
            WalkChildrenTodo(element);
        }

        protected override void Visit(CVariadicPatternList element)
        {
            WalkChildrenTodo(element);
        }

        /**********************************************************************
         *  Expression
         **********************************************************************/
        protected override void Visit(CParametrizedMember element)
        {
            WalkChildrenTodo(element);
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
            WalkChildrenTodo(element);
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
            WalkChildrenTodo(element);
        }

        protected override void Visit(CInterfaceLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CFunctionLiteral element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CValueLiteral element)
        {
            WalkChildrenTodo(element);
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
            WalkChildrenTodo(element);
        }

        protected override void Visit(CReferencePathElementList element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CMemberReference element)
        {
            //TODO
            var name = Walk<Identifier>(element.MemberName);
            if (element.TypeArguments.Children.Length > 0)
            {
                Assert(true);
            }
            var arguments = Walk<TypeArguments>(element.TypeArguments);

            element.Value = new MemberReference(name, arguments);
        }

        protected override void Visit(CTypeReference element)
        {
            WalkChildrenTodo(element);

            element.Value = new Expression();
        }

        protected override void Visit(CTypeArguments element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CTypeArgumentList element)
        {
            WalkChildrenTodo(element);
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
            WalkChildrenTodo(element);
        }

        protected override void Visit(CAdditiveOperator element)
        {
            WalkChildrenTodo(element);
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
