using Six.Runtime;
using Six.Runtime.Types;
using Six.Sax.Ast;
using static Six.Sax.SaxTree;

namespace Six.Sax.Compiler
{
    public partial class SaxVisitor : DynamicSaxVisitor
    {
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

        private T? Walk<T>(ROptional node)
            where T : class
        {
            Walk(node);

            var value = node.GetValue<T>();

            Assert(value == null || typeof(T).IsAssignableFrom(value.GetType()));

            return value;
        }

        private bool Exists(ROptional node)
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
            var skip = Exists(element.Literal);

            var nspace = Walk<Namespace>(element.Namespace);

            var usings = Walk<Using.Usings>(element.Usings);
            var declarations = Walk<Declarations>(element.Declarations);

            element.Value = new Unit.Code(element, skip, nspace, usings, declarations);
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
            var doc = Walk<Expression.String>(element.StringLiteral);
            var attributes = new Attributes(element, WalkMany<Attribute>(element.Attribute));

            element.Value = new Prelude(element, doc, attributes);
        }

        protected override void Visit(CAttribute element)
        {
            var name = Walk<Name>(element.Name);
            var arguments = Walk<Arguments>(element.AttributeArguments);

            element.Value = new Attribute(element, name, arguments);
        }

        protected override void Visit(CAttributeArguments element)
        {
            element.Value = Walk<Arguments>(element.AttributeArgumentList);
        }

        protected override void Visit(CAttributeArgumentList element)
        {
            element.Value = new Arguments(element, WalkMany<Argument>(element));
        }

        protected override void Visit(CPlainStringLiteral element)
        {
            element.Value = new Expression.String.Plain(element);
        }

        protected override void Visit(CVerbatimStringLiteral element)
        {
            element.Value = new Expression.String.Verbatim(element);
        }

        protected override void Visit(CDeclarations element)
        {
            element.Value = new Declarations(element, WalkMany<Declaration>(element));
        }

        protected override void Visit(CStatelarations element)
        {
            element.Value = new Statelarations(element, WalkMany<Statelaration>(element));
        }

        protected override void Visit(CFunctionDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var genrics = Walk<Generic.Parameters>(element.GenericParameters);
            var parameters = Walk<Parameters>(element.Parameters);
            var constraints = Walk<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Declaration.Entity.Function(element, prelude, name, genrics, type, parameters, constraints, body);
        }

        protected override void Visit(CAttributeDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var body = Walk<Body>(element.AttributeBody);

            element.Value = new Declaration.Entity.Attribute(element, prelude, name, type, body);
        }

        protected override void Visit(CClassDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var genrics = Walk<Generic.Parameters>(element.GenericParameters);
            var parameters = Walk<Parameters>(element.Parameters);
            var extends = Walk<Type>(element.Extends);
            var satifies = Walk<Types>(element.Satisfies);
            var cases = Walk<Types>(element.CaseTypes);
            var constraints = Walk<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Entity.Class(element, prelude, name, genrics, parameters, extends, satifies, cases, constraints, body);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var genrics = Walk<Generic.Parameters>(element.GenericParameters);
            var parameters = Walk<Parameters>(element.Parameters);
            var satifies = Walk<Types>(element.Satisfies);
            var cases = Walk<Types>(element.CaseTypes);
            var constraints = Walk<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Entity.Interface(element, prelude, name, genrics, parameters, satifies, cases, constraints, body);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var extends = Walk<Type>(element.Extends);
            var satifies = Walk<Types>(element.Satisfies);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Entity.Object(element, prelude, name, extends, satifies, body);
        }

        protected override void Visit(CAliasDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = Walk<Generic.Parameters>(element.GenericParameters);
            var constraints = Walk<Generic.Constraints>(element.Constraints);
            var type = Walk<Type>(element.Type);

            element.Value = new Declaration.Entity.Alias(element, prelude, name, generics, constraints, type);
        }

        protected override void Visit(CReference element)
        {
            var name = Walk<Name>(element.Name);
            var arguments = Walk<Generic.Arguments>(element.GenericArguments);

            element.Value = new Reference(element, name, arguments);
        }


        protected override void Visit(CParameters element)
        {
            element.Value = Walk<Parameters>(element.ParameterList) ?? new Parameters(element);
        }

        protected override void Visit(CParameterList element)
        {
            element.Value = new Parameters(element, WalkMany<Parameter>(element));
        }

        protected override void Visit(CParameter element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var type = Walk<Type>(element.Type);

            element.Value = new Parameter(element, prelude, name, type);
        }

        protected override void Visit(CNullBody element)
        {
            element.Value = new Body.Null(element);
        }

        protected override void Visit(CBlockBody element)
        {
            var statelarations = Walk<Statelarations>(element.Statelarations);

            element.Value = new Body.Block(element, statelarations);
        }

        protected override void Visit(CExpressionBody element)
        {
            var expression = Walk<Expression>(element.FunctionSpecifier)!;
            element.Value = new Body.Function(element, expression);
        }

        protected override void Visit(CReturnStatement element)
        {
            element.Value = new Statement.Return(element, Walk<Expression>(element.Expression));
        }

        protected override void Visit(CCaseTypes element)
        {
            element.Value = Walk<Types>(element.CaseTypeList);
        }

        protected override void Visit(CCaseTypeList element)
        {
            element.Value = new Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CObjectReference element)
        {
            element.Value = new Meta.ObjectReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CValueReference element)
        {
            element.Value = new Meta.ValueReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CClassReference element)
        {
            element.Value = new Meta.ClassReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CInterfaceReference element)
        {
            element.Value = new Meta.InterfaceReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CFunctionReference element)
        {
            element.Value = new Meta.FunctionReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CUnionType element)
        {
            var left = Walk<Type>(element.UnionlevelType);
            var right = Walk<Type>(element.IntersectionlevelType);

            element.Value = new Type.Union(element, left, right);
        }

        protected override void Visit(CIntersectionType element)
        {
            var left = Walk<Type>(element.IntersectionlevelType);
            var right = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Intersection(element, left, right);
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
            element.Value = Walk<Arguments>(element.ArgumentList);
        }

        protected override void Visit(CArgumentList element)
        {
            element.Value = new Arguments(element, WalkMany<Argument>(element));
        }

        protected override void Visit(CExtends element)
        {
            element.Value = Walk<Type>(element.Type);
        }

        protected override void Visit(CNaturalLiteral element)
        {
            element.Value = new Expression.Number(element);
        }

        protected override void Visit(CConstructor element)
        {
            var type = Walk<Type>(element.PrimaryType);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Type.Constructor(element, type, arguments);
        }

        protected override void Visit(CSatisfies element)
        {
            element.Value = Walk<Types>(element.UnionTypeList);
        }

        protected override void Visit(CUnionTypeList element)
        {
            element.Value = new Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CUsings element)
        {
            element.Value = new Using.Usings(element, WalkMany<Using>(element));
        }

        protected override void Visit(CUsingDeclaration element)
        {
            var names = Walk<Names>(element.Names);
            var elements = Walk<Using.ElementList>(element.UsingElements);

            element.Value = new Using(element, names, elements);
        }

        protected override void Visit(CUsingElements element)
        {
            element.Value = Walk<Using.ElementList>(element.UsingElementList);
        }

        protected override void Visit(CUsingElementList element)
        {
            element.Value = new Using.ElementList(element, WalkMany<Using.Element>(element));
        }

        protected override void Visit(CUsingNamed element)
        {
            var name1 = Walk<Name>(element.UsingName);
            var name2 = Walk<Name>(element.UsingNameSpecifier);
            var elements = Walk<Using.ElementList>(element.UsingElements);

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

        protected override void Visit(CAssertStatement element)
        {
            var message = Walk<Expression.String>(element.StringLiteral);
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Statement.Assert(element, message, arguments);
        }

        protected override void Visit(CGenericParameters element)
        {
            element.Value = Walk<Generic.Parameters>(element.GenericParameterList);
        }

        protected override void Visit(CGenericParameterList element)
        {
            element.Value = new Generic.Parameters(element, WalkMany<Generic.Parameter>(element));
        }

        protected override void Visit(CGenericParameter element)
        {
            var name = Walk<Name>(element.Name);
            var variance = Walk<string>(element.Variance);

            element.Value = new Generic.Parameter(element, variance, name);
        }

        protected override void Visit(CVariance element)
        {
            element.Value = element.GetText();
        }

        protected override void Visit(CConstraints element)
        {
            element.Value = new Generic.Constraints(element, WalkMany<Generic.Constraint>(element));
        }

        protected override void Visit(CConstraint element)
        {
            var name = Walk<Name>(element.Name);
            var parameters = Walk<Generic.Parameters>(element.GenericParameters);
            var cases = Walk<Types>(element.CaseTypes);
            var satifies = Walk<Types>(element.Satisfies);

            element.Value = new Generic.Constraint(element, name, parameters, cases, satifies);
        }

        protected override void Visit(CArrayType element)
        {
            var type = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Array(element, type);
        }

        protected override void Visit(CGenericArguments element)
        {
            element.Value = Walk<Generic.Arguments>(element.GenericArgumentList);
        }

        protected override void Visit(CGenericArgumentList element)
        {
            element.Value = new Generic.Arguments(element, WalkMany<Generic.Argument>(element));
        }

        protected override void Visit(CAddExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.MullevelExpression);

            element.Value = new Expression.Add(element, left, right);
        }

        protected override void Visit(CSubExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.MullevelExpression);

            element.Value = new Expression.Sub(element, left, right);
        }

        protected override void Visit(CMulExpression element)
        {
            var left = Walk<Expression>(element.MullevelExpression);
            var right = Walk<Expression>(element.PrimaryExpression);

            element.Value = new Expression.Mul(element, left, right);
        }

        protected override void Visit(CIdenticalExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.AddlevelExpression2);

            element.Value = new Expression.Identical(element, left, right);
        }

        protected override void Visit(CNotIdenticalExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.AddlevelExpression2);

            element.Value = new Expression.NotIdentical(element, left, right);
        }

        protected override void Visit(CEqualExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.AddlevelExpression2);

            element.Value = new Expression.Equal(element, left, right);
        }

        protected override void Visit(CNotEqualExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.AddlevelExpression2);

            element.Value = new Expression.NotEqual(element, left, right);
        }

        protected override void Visit(CNotExpression element)
        {
            var expression = Walk<Expression>(element.NotlevelExpression);

            element.Value = new Expression.Not(element, expression);
        }

        protected override void Visit(CVariadicTypeZero element)
        {
            var type = Walk<Type>(element.UnionlevelType);

            element.Value = new Type.ZeroOrMore(element, type);
        }

        protected override void Visit(CVariadicTypeOne element)
        {
            var type = Walk<Type>(element.UnionlevelType);

            element.Value = new Type.OneOrMore(element, type);
        }

        protected override void Visit(CNullableType element)
        {
            var type = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Nullable(element, type);
        }
    }
}
