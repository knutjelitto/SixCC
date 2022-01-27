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

        protected override void DefaultImplementation(RNode element)
        {
            Console.WriteLine($"Type ``{element.GetType().Name}´´ not implemented");

            throw new NotImplementedException();
        }

        protected override void Visit(CXStart element)
        {
            Walk(element.CompilationUnit);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            //TODO: Visitor
        }

        protected override void Visit(CPackageDescriptor element)
        {
            //TODO: Visitor
        }

        protected override void Visit(CCodeUnit element)
        {
#if true
            var imports = Walk<ImportList>(element.Imports);
            Walk(element.Namespace);

            var path = element.Namespace.NamespacePath.GetValue<Identifiers>()!;

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
            element.Value = new Identifiers(element.Children.Select(child => Walk<Identifier>(child)));
        }

        protected override void Visit(CDeclarations element)
        {
            WalkChildren(element);
        }

        protected override void Visit(COptionalAnySpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            // '=>'
            element.Value = Walk<IExpression>(element.Expression);
        }

        protected override void Visit(COptionalFunctionSpecifier element)
        {
            element.Value = Walk<IExpression>(element.FunctionSpecifierOptional);
            // ';'
        }

        protected override void Visit(CRequiredFunctionSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(COptionalClassSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CClassSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CValueSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CClassInstatiation element)
        {
            //TODO
            Walk(element.QualifiedClass);
            var arguments = Walk<Arguments>(element.ArgumentsOptional);
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
            WalkChildren(element);
        }

        protected override void Visit(CTypeSpecifier element)
        {
            WalkChildren(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CModuleSpecifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CModuleBody element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CImportModule element)
        {
            WalkChildren(element);
        }
        protected override void Visit(CSuperQualifiedClass element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CDelegatedConstructor element)
        {
            WalkChildren(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Parameters
         *--------------------------------------------------------------------*/
        protected override void Visit(CFunctionParameters element)
        {
            WalkChildren(element);
        }

        /*---------------------------------------------------------------------
         *  Annotations
         *--------------------------------------------------------------------*/
        /**********************************************************************
         *  Patterns / Variables
         **********************************************************************/
        protected override void Visit(CVariable element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariadicVariable element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CLetVariable element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Expression();
        }

        protected override void Visit(CEntryPattern element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTuplePattern element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariadicPatternList element)
        {
            WalkChildren(element);
        }

        /**********************************************************************
         *  Expression
         **********************************************************************/
        protected override void Visit(CParametrizedMember element)
        {
            WalkChildren(element);
        }

        /*---------------------------------------------------------------------
         *  Expression - Inners
         *--------------------------------------------------------------------*/
        protected override void Visit(CThenExpression element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CElseExpression element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CQualifiedReference element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSwitchHeader element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCaseExpressions element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CCaseExpression element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CIsCaseCondition element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CLetVariableList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSpanned element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CMeasured element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CLowerSpanned element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CUpperSpanned element)
        {
            WalkChildren(element);
        }


        /*---------------------------------------------------------------------
         *  Expression - Arguments
         *--------------------------------------------------------------------*/
        protected override void Visit(CPositionalArguments element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSequencedArguments element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CStructuralArguments element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSpreadArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CNamedSpecifiedArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CAnonymousArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CUntypedMethodArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CInferredMethodArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypedMethodArgument element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CForComprehensionClause element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CIfComprehensionClause element)
        {
            WalkChildren(element);
        }


        /*---------------------------------------------------------------------
         *  Expression - Helpers
         *--------------------------------------------------------------------*/
        protected override void Visit(CSpecifiedVariable element)
        {
            WalkChildren(element);
        }
        protected override void Visit(CValueCaseList element)
        {
            WalkChildren(element);
        }


        /*---------------------------------------------------------------------
         *  Names / References / Literals
         *--------------------------------------------------------------------*/
        protected override void Visit(CMetaLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CModuleLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CClassLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CInterfaceLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CFunctionLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CValueLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CAliasLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CNewLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CPackageLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeParameterLiteral element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CValueLiteralIntro element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CPackagePath element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CReferencePath element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CReferencePathElementList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CMemberReference element)
        {
            //TODO
            var name = Walk<Identifier>(element.MemberName);
            if (element.TypeArgumentsOptional.Children.Length > 0)
            {
                Assert(true);
            }
            var arguments = Walk<TypeArguments>(element.TypeArgumentsOptional);

            element.Value = new MemberReference(name, arguments);
        }

        protected override void Visit(CTypeReference element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeArguments element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeArgumentList element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSelfReference element)
        {
            WalkChildren(element);

            //TODO
            element.Value = new Expression();
        }
        protected override void Visit(CInterpolationPart element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariance element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CPackageQualifier element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CKwVoid element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CKwValue element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CKwFunction element)
        {
            WalkChildren(element);
        }

        /**********************************************************************
         *  Operators
         **********************************************************************/

        protected override void Visit(CNotOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CVariadicOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CEntryOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CLargerOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CSmallerOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CIncrementOperator element)
        {   
            WalkChildren(element);
        }

        protected override void Visit(CConjunctionOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CAdditiveOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CMultiplicativeOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CMemberSelectionOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CEqualityOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CContainmentOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CRangeOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CAssignmentOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CComparisonOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CDisjunctionOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CTypeOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CThenElseOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CIntersectionOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CNegateOperator element)
        {
            WalkChildren(element);
        }

        protected override void Visit(CExclusiveOperator element)
        {
            WalkChildren(element);
        }
    }
}
