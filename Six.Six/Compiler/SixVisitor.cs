using Six.Runtime;
using Six.Runtime.Types;
using Six.Six.Ast;
using static Six.Six.SixTree;
using S = Six.Six.Sema;

namespace Six.Six.Compiler
{
    public partial class SixVisitor : DynamicSixVisitor
    {
        public S.Resolver Resolver { get; }

        public SixVisitor(S.Resolver resolver)
        {
            Resolver = resolver;
        }

        public void Walk(SourceFile source)
        {
            if (source.Tree != null)
            {
                Walk(source.Tree);
            }
        }

        private IEnumerable<T> WalkMany<T>(RNode element)
            where T : class, TreeNode
        {
            return element.Children.Select(child => Walk<T>(child));
        }

        private T Walk<T>(IRNode element)
            where T : class
        {
            Walk(element);

            Assert(element.Value != null);

            var value = element.GetValue<T>();

            Assert(value != null && typeof(T).IsAssignableFrom(value.GetType()));

            return value;
        }

        private T? WalkOptional<T>(ROptional node)
            where T : class
        {
            Walk(node);

            var value = node.GetValue<T>();

            Assert(value == null || typeof(T).IsAssignableFrom(value.GetType()));

            return value;
        }

        private static bool Exists(ROptional node)
        {
            return node.Children.Length > 0;
        }

        protected override void DefaultImplementation(RNode element)
        {
            Assert(false);
            base.DefaultImplementation(element);
        }

        protected override void Visit(CXStart element)
        {
            element.Value = Walk<Unit>(element.CompilationUnit);
        }

        protected override void Visit(CCodeUnit element)
        {
            var @namespace = Walk<NamespaceIntro>(element.NamespaceIntro);

            var usings = Walk<Usings>(element.Usings);
            var declarations = Walk<Declarations>(element.TopDeclarations);

            element.Value = new Unit.Code(element, @namespace, usings, declarations);
        }

        protected override void Visit(CTopDeclarations element)
        {
            element.Value = new Declarations(element, WalkMany<Decl>(element));
        }

        protected override void Visit(CModuleDescriptor element)
        {
            var names = Walk<Names>(element.Names);
            element.Value = new Unit.Module(element, names);
        }

        protected override void Visit(CNamespace element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var names = Walk<Names>(element.Names);

            element.Value = new Namespace(element, prelude, names);
        }

        protected override void Visit(CNamespaceIntro element)
        {
            var names = Walk<Names>(element.Names);

            element.Value = new NamespaceIntro(element, names);
        }

        protected override void Visit(CNames element)
        {
            element.Value = new Names(element, WalkMany<Name>(element));
        }

        protected override void Visit(CIdentifier element)
        {
            element.Value = new Name.Id(element);
        }

        protected override void Visit(CPrelude element)
        {
            var doc = WalkOptional<Expression.String>(element.StringLiteral);
            var attributes = new Attributes(element, WalkMany<Attribute>(element.Attribute));

            element.Value = new Prelude(element, doc, attributes);
        }

        protected override void Visit(CAttribute element)
        {
            //var name = Walk<Name>(element.Name);
            var arguments = WalkOptional<Arguments>(element.Arguments);

            element.Value = new Attribute(element, element.AttributeName, arguments);
        }


        protected override void Visit(CPlainStringLiteral element)
        {
            element.Value = new Expression.String.Plain(element);
        }

        protected override void Visit(CVerbatimStringLiteral element)
        {
            element.Value = new Expression.String.Verbatim(element);
        }

        protected override void Visit(CStringStart element)
        {
            element.Value = new Expression.String.Start(element);
        }

        protected override void Visit(CStringMid element)
        {
            element.Value = new Expression.String.Mid(element);
        }

        protected override void Visit(CStringEnd element)
        {
            element.Value = new Expression.String.End(element);
        }

        protected override void Visit(CStatelarations element)
        {
            element.Value = new Statelarations(element, WalkMany<StmtOrDecl>(element));
        }

        protected override void Visit(CPrimitiveDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Decl.Primitive(element, prelude, name, cases, body);
        }

        protected override void Visit(CInfixDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.InfixOperator);
            var parameters = new Decl.Parameters(element.DefinitiveParameter, Walk<Decl.DefinitiveParameter>(element.DefinitiveParameter));
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Decl.Infix(element, prelude, name, type, parameters, body);
        }


        protected override void Visit(CPrefixDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.PrefixOperator);
            var parameters = new Decl.Parameters(element.FunctionBody);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Decl.Prefix(element, prelude, name, type, parameters, body);
        }

        protected override void Visit(CInfixOperator element)
        {
            element.Value = new Name.Id(element);
        }

        protected override void Visit(CPrefixOperator element)
        {
            element.Value = new Name.Id(element);
        }

        protected override void Visit(CFunctionDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<TypeParameters>(element.GenericParameters);
            var parameters = Walk<Decl.Parameters>(element.Parameters);
            var constraints = WalkOptional<TypeConstraints>(element.Constraints);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Decl.Function(element, prelude, name, generics, constraints, type, parameters, body);
        }

        protected override void Visit(CAttributeDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var body = Walk<Body>(element.AttributeBody);

            element.Value = new Decl.Attribute(element, prelude, name, type, body);
        }

        protected override void Visit(CClassDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<TypeParameters>(element.GenericParameters);
            var parameters = WalkOptional<Decl.Parameters>(element.Parameters);
            var extends = WalkOptional<Type>(element.Extends);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var constraints = WalkOptional<TypeConstraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Decl.Class(element, prelude, name, generics, constraints, parameters, extends, satifies, cases, body);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<TypeParameters>(element.GenericParameters);
            var parameters = WalkOptional<Decl.Parameters>(element.Parameters);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var constraints = WalkOptional<TypeConstraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Decl.Interface(element, prelude, name, generics, constraints, parameters, satifies, cases, body);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var extends = WalkOptional<Type>(element.Extends);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Decl.Object(element, prelude, name, extends, satifies, body);
        }

        protected override void Visit(CAliasDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<TypeParameters>(element.GenericParameters);
            var constraints = WalkOptional<TypeConstraints>(element.Constraints);
            var type = Walk<Type>(element.Type);

            element.Value = new Decl.Alias(element, prelude, name, generics, constraints, type);
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = WalkOptional<Name>(element.Name) ?? new Name.ArtificalId(S.Module.DefaultCtor);
            var parameters = Walk<Decl.Parameters>(element.Parameters);
            var extends = WalkOptional<Type>(element.Extends);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Decl.Constructor(element, prelude, name, parameters, extends, body);
        }

        protected override void Visit(CLetDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = WalkOptional<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var value = Walk<Expression>(element.Expression);

            element.Value = new Decl.Let(element, prelude, name, type, value);
        }

        protected override void Visit(CVarDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = WalkOptional<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var value = Walk<Expression>(element.Expression);

            element.Value = new Decl.Var(element, prelude, name, type, value);
        }

        protected override void Visit(CValueBody element)
        {
            var expr = Walk<Expression>(element.ValueSpecifier);

            element.Value = new Body.Value(element, expr);
        }

        protected override void Visit(CValueSpecifier element)
        {
            var expr = Walk<Expression>(element.Expression);

            element.Value = expr;
        }

        protected override void Visit(CReference element)
        {
            var name = Walk<Name>(element.Name);
            var arguments = WalkOptional<TypeArguments>(element.GenericArguments);

            element.Value = new Reference(element, name, arguments);
        }


        protected override void Visit(CParameters element)
        {
            element.Value = WalkOptional<Decl.Parameters>(element.ParameterList) ?? new Decl.Parameters(element);
        }

        protected override void Visit(CParameterList element)
        {
            element.Value = new Decl.Parameters(element, WalkMany<Decl.Parameter>(element));
        }

        protected override void Visit(CValueParameter element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.ParameterType);
            var name = Walk<Name>(element.Name);
            var @default = WalkOptional<Expression>(element.ValueDefault);

            element.Value = new Decl.ValueParameter(element, prelude, name, type, @default);
        }

        protected override void Visit(CDefinitiveParameter element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.ParameterType);
            var name = Walk<Name>(element.Name);

            element.Value = new Decl.DefinitiveParameter(element, prelude, name, type);
        }

        protected override void Visit(CNullBody element)
        {
            element.Value = new Body.Deferred(element);
        }

        protected override void Visit(CBuiltinBody element)
        {
            element.Value = new Body.Builtin(element);
        }

        protected override void Visit(CBlockBody element)
        {
            var usings = Walk<Usings>(element.Usings);
            var statelarations = Walk<Statelarations>(element.Statelarations);

            element.Value = new Body.Block(element, usings, statelarations);
        }

        protected override void Visit(CCalcBody element)
        {
            var expression = Walk<Expression>(element.FunctionSpecifier);

            element.Value = new Body.Calc(element, expression);
        }

        protected override void Visit(CReturnStatement element)
        {
            element.Value = new Stmt.Return(element, WalkOptional<Expression>(element.Expression));
        }

        protected override void Visit(CThrowStatement element)
        {
            element.Value = new Stmt.Throw(element, WalkOptional<Expression>(element.Expression));
        }

        protected override void Visit(CExpressionStatement element)
        {
            element.Value = new Stmt.Expr(element, Walk<Expression>(element.Expression));
        }

        protected override void Visit(CIfStatement element)
        {
            var conditions = Walk<Expression.Conditions>(element.Conditions);
            var block = Walk<Body.Block>(element.BlockBody);

            var items = new List<Stmt.Guarded>();
            items.Add(new Stmt.Guarded(element, conditions, block));
            items.AddRange(WalkMany<Stmt.Guarded>(element.ElseIf));
            var guardeds = new Stmt.Guardeds(element.ElseIf, items);

            var elseBlock = WalkOptional<Body.Block>(element.ElseBlock);

            element.Value = new Stmt.If(element, guardeds, elseBlock);
        }

        protected override void Visit(CElseIf element)
        {
            var conditions = Walk<Expression.Conditions>(element.Conditions);
            var block = Walk<Body.Block>(element.BlockBody);

            element.Value = new Stmt.Guarded(element, conditions, block);
        }


        protected override void Visit(CForStatement element)
        {
            var pattern = Walk<Pattern>(element.Pattern);
            var expression = Walk<Expression>(element.Expression);
            var block = Walk<Body.Block>(element.BlockBody);
            var elseBlock = WalkOptional<Body.Block>(element.ElseBlock);

            element.Value = new Stmt.For(element, pattern, expression, block, elseBlock);
        }

        protected override void Visit(CElseBlock element)
        {
            element.Value = Walk<Body.Block>(element.BlockBody);
        }

        protected override void Visit(CCaseTypes element)
        {
            element.Value = Walk<Type.Types>(element.CaseTypeList);
        }

        protected override void Visit(CCaseTypeList element)
        {
            element.Value = new Type.Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CUnionType element)
        {
            var items = WalkMany<Type>(element).ToList();
            if (items.Count == 1)
            {
                element.Value = items[0];
            }
            else
            {
                element.Value = new Type.Union(element, items);
            }
        }

        protected override void Visit(CIntersectionType element)
        {
            var items = WalkMany<Type>(element).ToList();
            if (items.Count == 1)
            {
                element.Value = items[0];
            }
            else
            {
                element.Value = new Type.Intersection(element, items);
            }
        }

        protected override void Visit(CFunctionSpecifier element)
        {
            element.Value = Walk<Expression>(element.Expression);
        }

        protected override void Visit(CCallExpression element)
        {
            var expression = Walk<Expression>(element.PrimaryExpression);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Expression.Call(element, expression, arguments);
        }

        protected override void Visit(CArguments element)
        {
            element.Value = WalkOptional<Arguments>(element.ArgumentList) ?? new Arguments(element);
        }

        protected override void Visit(CArgumentList element)
        {
            element.Value = new Arguments(element, WalkMany<Expression>(element));
        }

        protected override void Visit(CExtends element)
        {
            element.Value = Walk<Type>(element.ExtendType);
        }

        protected override void Visit(CNaturalLiteral element)
        {
            element.Value = new Expression.NaturalNumber(element);
        }

        protected override void Visit(CCallableType element)
        {
            var type = Walk<Type>(element.PrimaryType);
            var arguments = WalkOptional<Type>(element.CallableArguments) ?? new Type.Types(element.CallableArguments);

            element.Value = new Type.Callable(element, type, arguments);
        }

        protected override void Visit(CSatisfies element)
        {
            element.Value = Walk<Type.Types>(element.UnionTypeList);
        }

        protected override void Visit(CUnionTypeList element)
        {
            element.Value = new Type.Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CUsings element)
        {
            element.Value = new Usings(element, WalkMany<Using>(element));
        }

        protected override void Visit(CUsingDeclaration element)
        {
            var names = Walk<Names>(element.Names);
            var elements = Walk<Using.ElementList>(element.UsingElements);

            element.Value = new Using(element, names, elements);
        }

        protected override void Visit(CUsingElements element)
        {
            element.Value = WalkOptional<Using.ElementList>(element.UsingElementList);
        }

        protected override void Visit(CUsingElementList element)
        {
            element.Value = new Using.ElementList(element, WalkMany<Using.Element>(element));
        }

        protected override void Visit(CUsingNamed element)
        {
            var name1 = Walk<Name>(element.UsingName);
            var name2 = WalkOptional<Name>(element.UsingNameSpecifier);
            var elements = WalkOptional<Using.ElementList>(element.UsingElements);

            if (name2 == null)
            {
                element.Value = new Using.Element.Named(element, name1, null, elements);
            }
            else
            {
                element.Value = new Using.Element.Named(element, name2, name1, elements);
            }
        }

        protected override void Visit(CUsingNameSpecifier element)
        {
            element.Value = Walk<Name>(element.Identifier);
        }

        protected override void Visit(CUsingWildcard element)
        {
            element.Value = new Using.Element.Wildcard(element);
        }

        protected override void Visit(CSelectExpression element)
        {
            var primary = Walk<Expression>(element.PrimaryExpression);
            var reference = Walk<Reference>(element.Reference);

            element.Value = new Expression.Select(element, primary, reference);
        }

        protected override void Visit(CNullsafeSelectExpression element)
        {
            var primary = Walk<Expression>(element.PrimaryExpression);
            var reference = Walk<Reference>(element.Reference);

            element.Value = new Expression.NullsafeSelect(element, primary, reference);
        }

        protected override void Visit(CAssertStatement element)
        {
            var message = WalkOptional<Expression.String>(element.StringLiteral);
            var conditions = Walk<Expression.Conditions>(element.Conditions);

            element.Value = new Stmt.Assert(element, message, conditions);
        }

        protected override void Visit(CGenericParameters element)
        {
            element.Value = WalkOptional<TypeParameters>(element.GenericParameterList);
        }

        protected override void Visit(CGenericParameterList element)
        {
            element.Value = new TypeParameters(element, WalkMany<TypeParameter>(element));
        }

        protected override void Visit(CGenericParameter element)
        {
            var variance = WalkOptional<string>(element.Variance);
            var name = Walk<Name>(element.Name);
            var @default = WalkOptional<Type>(element.TypeDefault);

            element.Value = new TypeParameter(element, variance, name, @default);
        }

        protected override void Visit(CVariance element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CConstraints element)
        {
            element.Value = new TypeConstraints(element, WalkMany<TypeConstraint>(element));
        }

        protected override void Visit(CConstraint element)
        {
            var name = Walk<Name>(element.Name);
            var parameters = WalkOptional<TypeParameters>(element.GenericParameters);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);

            element.Value = new TypeConstraint(element, name, parameters, cases, satifies);
        }

        protected override void Visit(CGenericArguments element)
        {
            element.Value = WalkOptional<TypeArguments>(element.GenericArgumentList);
        }

        protected override void Visit(CGenericArgumentList element)
        {
            element.Value = new TypeArguments(element, WalkMany<Type>(element));
        }

        protected override void Visit(CAddExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelMulExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CSubExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelMulExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CMulExpression element)
        {
            var left = Walk<Expression>(element.LevelMulExpression);
            var right = Walk<Expression>(element.LevelUnionExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CDivExpression element)
        {
            var left = Walk<Expression>(element.LevelMulExpression);
            var right = Walk<Expression>(element.LevelUnionExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CRemExpression element)
        {
            var left = Walk<Expression>(element.LevelMulExpression);
            var right = Walk<Expression>(element.LevelUnionExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CIdenticalExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CNotIdenticalExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CNotEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CGreaterExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CGreaterEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CLessExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CLessEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CNotExpression element)
        {
            var expression = Walk<Expression>(element.LevelNotExpression);

            element.Value = new Expression.Prefix(element, new Reference(element.Literal), expression);
        }

        protected override void Visit(CGroupedExpression element)
        {
            element.Value = Walk<Expression>(element.Expression);
        }

        protected override void Visit(CIfExpression element)
        {
            var conditions = Walk<Expression.Conditions>(element.Conditions);
            var ifThen = Walk<Expression>(element.IfThen);
            var ifElse = Walk<Expression>(element.IfElse);

            element.Value = new Expression.If(element, conditions, ifThen, ifElse);
        }

        protected override void Visit(CIfThen element)
        {
            element.Value = Walk<Expression>(element.ConditionalExpression);
        }

        protected override void Visit(CIfElse element)
        {
            element.Value = Walk<Expression>(element.ConditionalExpression);
        }

        protected override void Visit(CConditions element)
        {
            element.Value = Walk<Expression.Conditions>(element.ConditionList);
        }

        protected override void Visit(CConditionList element)
        {
            element.Value = new Expression.Conditions(element, WalkMany<Expression>(element));
        }

        protected override void Visit(CIsCondition element)
        {
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);

            element.Value = new Expression.IsType(element, type, name);
        }


        protected override void Visit(CConjunctionExpression element)
        {
            var left = Walk<Expression>(element.LevelConjunctionExpression);
            var right = Walk<Expression>(element.LevelNotExpression);

            element.Value = new Expression.AndThen(element, left, right);
        }

        protected override void Visit(CDisjunctionExpression element)
        {
            var left = Walk<Expression>(element.LevelDisjunctionExpression);
            var right = Walk<Expression>(element.LevelConjunctionExpression);

            element.Value = new Expression.OrElse(element, left, right);
        }

        protected override void Visit(CNullableType element)
        {
            var type = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Nullable(element, type);
        }

        protected override void Visit(CTupleType element)
        {
            var type = Walk<Type.Types>(element.TypeList);

            element.Value = new Type.Tuple(element, type);
        }

        protected override void Visit(CEmptyType element)
        {
            element.Value = new Type.Empty(element);
        }

        protected override void Visit(CConstructor element)
        {
            var type = Walk<Type>(element.PrimaryType);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Type.Constructor(element, type, arguments);
        }

        protected override void Visit(CTypeList element)
        {
            element.Value = new Type.Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CNamePattern element)
        {
            element.Value = new Pattern.Ident(element, Walk<Name>(element.Name));
        }

        protected override void Visit(CNothingType element)
        {
            element.Value = new Type.Nothing(element);
        }

        protected override void Visit(CTypeSelector element)
        {
            var type = Walk<Type>(element.PrimaryType);
            var reference = Walk<Reference>(element.Reference);

            element.Value = new Type.Selector(element, type, reference);
        }

        protected override void Visit(CDefaultedType element)
        {
            element.Value = new Type.Defaulted(element, Walk<Type>(element.Type));
        }

        protected override void Visit(CTypeDefault element)
        {
            element.Value = Walk<Type>(element.Type);
        }

        protected override void Visit(CValueDefault element)
        {
            element.Value = Walk<Expression>(element.Expression);
        }

        protected override void Visit(CThenExpression element)
        {
            var left = Walk<Expression>(element.LevelCoalesceExpression);
            var right = Walk<Expression>(element.LevelDisjunctionExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CElseExpression element)
        {
            var left = Walk<Expression>(element.LevelCoalesceExpression);
            var right = Walk<Expression>(element.LevelDisjunctionExpression);

            element.Value = new Expression.Infix(element, new Reference(element.Literal), left, right);
        }

        protected override void Visit(CNegateExpression element)
        {
            var expr = Walk<Expression>(element.LevelNegateExpression);

            element.Value = new Expression.Prefix(element, new Reference(element.Literal), expr);
        }

        protected override void Visit(CAssignStatement element)
        {
            var left = Walk<Expression>(element.PrimaryExpression);
            var right = Walk<Expression>(element.Expression);

            element.Value = new Stmt.Assign(element, left, right);
        }

        protected override void Visit(CStringInterpolation element)
        {
            var str = Walk<Expression.String>(element.StringStart);
            var expr = Walk<Expression>(element.Expression);
            var interpolations = new List<Expression.InterpolationPart>();
            interpolations.Add(new Expression.InterpolationPart(element, str, expr));
            foreach (var part in element.InterpolationPart)
            {
                str = Walk<Expression.String>(part.StringMid);
                expr = Walk<Expression>(part.Expression);
                interpolations.Add(new Expression.InterpolationPart(element, str, expr));
            }
            str = Walk<Expression.String>(element.StringEnd);

            element.Value = new Expression.StringInterpolation(element, new Expression.InterpolationParts(element, interpolations), str);
        }
    }
}
