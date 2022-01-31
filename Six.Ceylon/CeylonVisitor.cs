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


        private void WalkChildrenNotYet(RNode element)
        {
            foreach (var child in element.Children)
            {
                Walk(child);
            }
        }

        private void WalkChildrenNever(RNode element)
        {
            throw new System.InvalidOperationException();
        }

        protected override void DefaultImplementation(RNode element)
        {
            System.Console.WriteLine($"Type ``{element.GetType().Name}´´ not implemented");

            throw new System.NotImplementedException();
        }

        protected override void Visit(CXStart element)
        {
            if (element.CompilationUnit is CModuleDescriptor)
            {
                WalkChildrenNotYet(element);
            }
            else if (element.CompilationUnit is CPackageDescriptor)
            {
                WalkChildrenNotYet(element);
            }
            else
            {
                var unit = Walk<Unit>(element.CompilationUnit);

                element.Value = unit;
            }
        }

        protected override void Visit(CCodeUnit element)
        {
            var imports = Walk<ImportList>(element.Imports);
            var ns = Walk<Ast.Namespace>(element.Namespace);
            var imports2 = Walk<ImportList>(element.Imports2);
            var declarations = Walk<Declarations>(element.Declarations);

            element.Value = new Unit(imports, ns, imports2, declarations);
        }

        protected override void Visit(CNamespace element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var path = Walk<IdentifierList>(element.NamespacePath);

            element.Value = new Ast.Namespace(annotations, path);
        }

        protected override void Visit(CNamespacePath element)
        {
            element.Value = new IdentifierList(element.Children.Select(child => Walk<Identifier>(child)));
        }

        protected override void Visit(COptionalAnySpecifier element)
        {
            element.Value = Walk<Expr.Specifier>(element.AnySpecifier) ?? new Expr.Specifier.Null();
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            // '=>'
            var op = element.Literal.GetText();
            var expr = Walk<Expr>(element.Expression);

            element.Value = new Expr.Specifier.Function(op, expr);
        }

        protected override void Visit(COptionalFunctionSpecifier element)
        {
            element.Value = Walk<Expr.Specifier>(element.FunctionSpecifier) ?? new Expr.Specifier.Null();
            // ';'
        }

        protected override void Visit(CRequiredFunctionSpecifier element)
        {
            element.Value = Walk<Expr.Specifier.Function>(element.FunctionSpecifier);
            // ';'
        }

        protected override void Visit(CValueSpecifier element)
        {
            // '='
            var op = element.Literal.GetText();
            var expr = Walk<Expr>(element.Expression);

            element.Value = new Expr.Specifier.Value(op, expr);
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
            element.Value = Walk<Type.Specifier>(element.TypeSpecifier);
        }

        protected override void Visit(CTypeSpecifier element)
        {
            // '=>' type
            var type = Walk<Type>(element.Type);

            element.Value = new Type.Specifier(type);
        }

        /*---------------------------------------------------------------------
         *  Declaration - Interns
         *--------------------------------------------------------------------*/
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
            var type = Walk<Type>(element.VariableType);
            var name = Walk<Identifier>(element.MemberName);
            var items = element.Parameters.Children.Select(child => Walk<Parameters>(child));
            var parameters = new ParametersList(items);

            element.Value = new Pattern.Variable(type, name, parameters);
        }

        protected override void Visit(CVariadicVariable element)
        {
            var type = Walk<Type>(element.UnionType);
            var op = element.VariadicOperator.GetText();
            var name = Walk<Identifier>(element.MemberName);

            element.Value = new Pattern.Variadic(type, op, name);
        }

        protected override void Visit(CLetVariable element)
        {
            var pattern = Walk<Pattern>(element.Pattern);
            var specifier = Walk<Expr.Specifier.Value>(element.ValueSpecifier);

            element.Value = new Pattern.LetVariable(pattern, specifier);
        }

        protected override void Visit(CEntryPattern element)
        {
            var left = Walk<Pattern>(element.VariableOrTuplePattern);
            var right = Walk<Pattern>(element.VariableOrTuplePattern2);

            element.Value = new Pattern.Entry(left, right);
        }

        protected override void Visit(CTuplePattern element)
        {
            var patterns = Walk<Patterns>(element.VariadicPatternList) ?? new Patterns(Enumerable.Empty<Pattern>());

            element.Value = new Pattern.Tuple(patterns);
        }

        protected override void Visit(CVariadicPatternList element)
        {
            var items = element.Elements.Select(child => Walk<Pattern>(child)).ToList();

            element.Value = new Patterns(items);
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
            var expr = Walk<Expr>(element.UnionExpression);

            element.Value = new Argument.Spread(expr);
        }

        protected override void Visit(CNamedSpecifiedArgument element)
        {
            WalkChildrenTodo(element);
        }

        protected override void Visit(CAnonymousArgument element)
        {
            var expr = Walk<Expr>(element.Expression);

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
            var iterator = Walk<Misc.ForIterator>(element.ForIterator);
            var comprehension = Walk<Comprehension>(element.ComprehensionClause);

            element.Value = new Comprehension.For(iterator, comprehension);
        }

        protected override void Visit(CIfComprehensionClause element)
        {
            var conditions = Walk<Conditions>(element.Conditions);
            var comprehension = Walk<Comprehension>(element.ComprehensionClause);

            element.Value = new Comprehension.If(conditions, comprehension);
        }


        /*---------------------------------------------------------------------
         *  Expression - Helpers
         *--------------------------------------------------------------------*/
        protected override void Visit(CSpecifiedVariable element)
        {
            var variable = Walk<Pattern.Variable>(element.Variable);
            var specifier = Walk<Expr.Specifier.Value>(element.ValueSpecifier);

            element.Value = new Expr.SpecifiedVariable(variable, specifier);
        }
     
        protected override void Visit(CValueCaseList element)
        {
            var items = element.Elements.Select(child => Walk<CaseItem>(child));
            var list = new CaseItemList(items);

            element.Value = list;
        }

        /*---------------------------------------------------------------------
         *  Names / References / Literals
         *--------------------------------------------------------------------*/
        protected override void Visit(CPackagePath element)
        {
            var names = element.Elements.Select(child => Walk<Identifier>(child));

            element.Value = new IdentifierList(names);
        }

        protected override void Visit(CReferencePath element)
        {
            var package = element.PackageQualifier.Children.Length > 0;
            var names = Walk<IdentifierList>(element.ReferencePathElementList);

            element.Value = new ReferencePath(package, names);
        }

        protected override void Visit(CReferencePathElementList element)
        {
            var items = WalkMany<Identifier>(element);

            element.Value = new IdentifierList(items);
        }

        protected override void Visit(CMemberReference element)
        {
            var name = Walk<Identifier>(element.MemberName);
            var arguments = Walk<TypeArgumentList>(element.TypeArguments);

            element.Value = new Expr.MemberReference(name, arguments);
        }

        protected override void Visit(CTypeReference element)
        {
            var name = Walk<Identifier>(element.TypeName);
            var arguments = Walk<TypeArgumentList>(element.TypeArguments);

            element.Value = new Expr.TypeReference(name, arguments);
        }

        protected override void Visit(CTypeArguments element)
        {
            element.Value = Walk<TypeArgumentList>(element.TypeArgumentList);
        }

        protected override void Visit(CTypeArgumentList element)
        {
            var arguments = WalkMany<Type.Varianced>(element);

            element.Value = new TypeArgumentList(arguments);
        }

        protected override void Visit(CVariance element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CPackageQualifier element)
        {
            WalkChildrenNever(element);
        }

        protected override void Visit(CKwVoid element)
        {
            WalkChildrenNever(element);
        }

        protected override void Visit(CKwValue element)
        {
            WalkChildrenNever(element);
        }

        protected override void Visit(CKwFunction element)
        {
            WalkChildrenNever(element);
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
            element.Value = new Expr.SelfReference(element.GetText());
        }
    }
}
