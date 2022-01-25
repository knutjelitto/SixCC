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
            WalkChilden(element);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPackageDescriptor element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCodeUnit element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNamespace element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNamespacePath element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDeclarations element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalAnySpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CRequiredFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalClassSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CClassSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CClassInstatiation element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CBlockElements element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalTypeSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeSpecifier element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CModuleSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CModuleBody element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportModule element)
        {
            WalkChilden(element);
        }
        protected override void Visit(CSuperQualifiedClass element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDelegatedConstructor element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Parameters
         *--------------------------------------------------------------------*/
        protected override void Visit(CFunctionParameters element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Annotations
         *--------------------------------------------------------------------*/
        protected override void Visit(CAnnotations element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAnnotation element)
        {
            WalkChilden(element);
        }

        /**********************************************************************
         *  Patterns / Variables
         **********************************************************************/
        protected override void Visit(CVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariadicVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryPattern element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTuplePattern element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariadicPatternList element)
        {
            WalkChilden(element);
        }

        /**********************************************************************
         *  Expression
         **********************************************************************/
        protected override void Visit(CSmallerBoundsExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParametrizedMember element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Expression - Inners
         *--------------------------------------------------------------------*/
        protected override void Visit(CStringInterpolation element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThenExpression element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CElseExpression element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CQualifiedReference element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSwitchHeader element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseExpressions element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseExpression element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIsCaseCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetVariableList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpanned element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMeasured element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLowerSpanned element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUpperSpanned element)
        {
            WalkChilden(element);
        }


        /*---------------------------------------------------------------------
         *  Expression - Arguments
         *--------------------------------------------------------------------*/
        protected override void Visit(CPositionalArguments element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSequencedArguments element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CStructuralArguments element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpreadArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNamedSpecifiedArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAnonymousArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUntypedMethodArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInferredMethodArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypedMethodArgument element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForComprehensionClause element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIfComprehensionClause element)
        {
            WalkChilden(element);
        }


        /*---------------------------------------------------------------------
         *  Expression - Helpers
         *--------------------------------------------------------------------*/
        protected override void Visit(CSpecifiedVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConditions element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConditionList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExistsCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNonemptyCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIsCondition element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIsConditionVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueCaseList element)
        {
            WalkChilden(element);
        }


        /*---------------------------------------------------------------------
         *  Names / References / Literals
         *--------------------------------------------------------------------*/
        protected override void Visit(CMetaLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CModuleLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CClassLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInterfaceLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAliasLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNewLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPackageLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameterLiteral element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueLiteralIntro element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPackagePath element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CReferencePath element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CReferencePathElementList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMemberReference element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeReference element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeArguments element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeArgumentList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSelfReference element)
        {
            WalkChilden(element);
        }
        protected override void Visit(CInterpolationPart element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariance element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPackageQualifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CKwVoid element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CKwValue element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CKwFunction element)
        {
            WalkChilden(element);
        }

        /**********************************************************************
         *  Operators
         **********************************************************************/

        protected override void Visit(CNotOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariadicOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLargerOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSmallerOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIncrementOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConjunctionOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAdditiveOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMultiplicativeOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMemberSelectionOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEqualityOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CContainmentOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CRangeOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAssignmentOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CComparisonOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDisjunctionOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThenElseOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIntersectionOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNegateOperator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExclusiveOperator element)
        {
            WalkChilden(element);
        }
    }
}
