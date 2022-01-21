using Six.Runtime.Types;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public class CeylonVisitor : DynamicCeylonVisitor
    {
        protected override void DefaultImplementation(RNode element)
        {
            Console.WriteLine($"Type ``{element.GetType().Name}´´ not implemented");

            throw new NotImplementedException();
        }

        protected void WalkI(object iface)
        {
            Walk((RNode)iface);
        }

        protected override void Visit(CXStart element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            // main module description

            WalkChilden(element);
        }

        protected override void Visit(CPackageDescriptor element)
        {
            // main package description

            WalkChilden(element);
        }

        protected override void Visit(CUnitElements element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportDeclarations element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CClassDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAliasDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSetterDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEnumeratedObject element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalAnySpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNeededFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(COptionalClassSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CClassSpecifier element)
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

        protected override void Visit(CImportElements element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportElementList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportNamed element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportNameSpecifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CImportWildcard element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSuperQualifiedClass element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSuperQualifier element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Parameters
         *--------------------------------------------------------------------*/
        protected override void Visit(CParameters element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParameterList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CParameter element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CValueParameterDeclaration element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionParameterDeclaration element)
        {
            WalkChilden(element);
        }

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
         *  Statements
         **********************************************************************/
        protected override void Visit(CUnclosedStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpecificationStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAssertionStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIfElseStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForElseStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CReturnStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CBreakStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CContinueStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSwitchStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CWhileStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTryStatement element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThrowStatement element)
        {
            WalkChilden(element);
        }

        /*---------------------------------------------------------------------
         *  Statements - Interns
         *--------------------------------------------------------------------*/
        protected override void Visit(CIfBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CElseBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFailBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTryBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCatchBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCatchVariable element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CResources element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CResourceList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFinallyBlock element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CForIterator element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CContainment element)
        {
            WalkChilden(element);
        }


        /**********************************************************************
         *  Patterns / Variables
         **********************************************************************/
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

        /**********************************************************************
         *  Expression
         **********************************************************************/
        protected override void Visit(CAssignmentExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCallExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLargerExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSmallerExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CAdditiveExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIfExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSelectionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTupleExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIndexedExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPostfixExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CPrefixExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CMultiplicativeExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CObjectExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CGroupedExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CRangeExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEnumerationExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypecheckExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CThenElseExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExistsExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNonemptyExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLogicalNegationExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSwitchExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLetExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEqualityExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CConjunctionExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNegationOrComplementExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CComparisonExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExclusiveExpr element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDisjunctionExpr element)
        {
            WalkChilden(element);
        }

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

        protected override void Visit(CIdentifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLowerIdentifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUpperIdentifier element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLiteralNatural element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLiteralFloat element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLiteralString element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CLiteralChar element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVerbatimString element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CInterpolationPart element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CStringStart element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CStringEnd element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CStringMid element)
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
         *  Types
         **********************************************************************/
        protected override void Visit(CTypeDefault element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypePath element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSatisfiedTypes element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CExtendedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeConstraints element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeConstraint element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUnionTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CQualifiedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CEntryType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIntersectionTypeCore element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CUnionTypeCore element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CIterableType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CGroupedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTupleType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CArrayType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CNullableType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariancedType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CVariadicUnionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CSpreadType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CFunctionExpressionType element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CDefaultedTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameters element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameterList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CTypeParameter element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseTypes element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CCaseTypeList element)
        {
            WalkChilden(element);
        }

        protected override void Visit(CQualifiedCaseType element)
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
