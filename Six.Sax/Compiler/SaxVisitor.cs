﻿using Six.Runtime;
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
            var doc = WalkOptional<Expression.String>(element.StringLiteral);
            var attributes = new Attributes(element, WalkMany<Attribute>(element.Attribute));

            element.Value = new Prelude(element, doc, attributes);
        }

        protected override void Visit(CAttribute element)
        {
            //var name = Walk<Name>(element.Name);
            var arguments = WalkOptional<Arguments>(element.AttributeArguments);

            element.Value = new Attribute(element, element.AttributeName, arguments);
        }

        protected override void Visit(CAttributeArguments element)
        {
            element.Value = WalkOptional<Arguments>(element.AttributeArgumentList);
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
            var type = WalkOptional<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<Generic.TypeParameters>(element.GenericParameters);
            var parameters = Walk<MultiParameters>(element.MultiParameters);
            var constraints = WalkOptional<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Declaration.Function(element, prelude, name, generics, constraints, type, parameters, body);
        }

        protected override void Visit(CAttributeDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = WalkOptional<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var body = Walk<Body>(element.AttributeBody);

            element.Value = new Declaration.Attribute(element, prelude, name, type, body);
        }

        protected override void Visit(CClassDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<Generic.TypeParameters>(element.GenericParameters);
            var parameters = WalkOptional<Parameters>(element.Parameters);
            var extends = WalkOptional<Type>(element.Extends);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var constraints = WalkOptional<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Class(element, prelude, name, generics, constraints, parameters, extends, satifies, cases, body);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<Generic.TypeParameters>(element.GenericParameters);
            var parameters = WalkOptional<Parameters>(element.Parameters);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var constraints = WalkOptional<Generic.Constraints>(element.Constraints);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Interface(element, prelude, name, generics, constraints, parameters, satifies, cases, body);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var extends = WalkOptional<Type>(element.Extends);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Object(element, prelude, name, extends, satifies, body);
        }

        protected override void Visit(CAliasDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var generics = WalkOptional<Generic.TypeParameters>(element.GenericParameters);
            var constraints = WalkOptional<Generic.Constraints>(element.Constraints);
            var type = Walk<Type>(element.Type);

            element.Value = new Declaration.Alias(element, prelude, name, generics, constraints, type);
        }

        protected override void Visit(CReference element)
        {
            var name = Walk<Name>(element.Name);
            var arguments = WalkOptional<Generic.TypeArguments>(element.GenericArguments);

            element.Value = new Reference(element, name, arguments);
        }


        protected override void Visit(CParameters element)
        {
            element.Value = WalkOptional<Parameters>(element.ParameterList) ?? new Parameters(element);
        }

        protected override void Visit(CMultiParameters element)
        {
            element.Value = new MultiParameters(element, WalkMany<Parameters>(element));
        }

        protected override void Visit(CParameterList element)
        {
            element.Value = new Parameters(element, WalkMany<Parameter>(element));
        }

        protected override void Visit(CValueParameter element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = WalkOptional<Type>(element.ParameterType);
            var name = Walk<Name>(element.Name);
            var @default = WalkOptional<Expression>(element.ValueDefault);

            element.Value = new ValueParameter(element, prelude, name, type, @default);
        }

        protected override void Visit(CNullBody element)
        {
            element.Value = new Body.Deferred(element);
        }

        protected override void Visit(CBlockBody element)
        {
            var statelarations = Walk<Statelarations>(element.Statelarations);

            element.Value = new Body.Block(element, statelarations);
        }

        protected override void Visit(CExpressionBody element)
        {
            var expression = Walk<Expression>(element.FunctionSpecifier)!;
            var @return = new Statement.Return(element, expression);
            var statements = new Statelarations(element, @return);

            element.Value = new Body.Block(element, statements);
        }

        protected override void Visit(CReturnStatement element)
        {
            element.Value = new Statement.Return(element, WalkOptional<Expression>(element.Expression));
        }

        protected override void Visit(CIfStatement element)
        {
            var conditions = Walk<Expression.Conditions>(element.Conditions);
            var block = Walk<Body.Block>(element.BlockBody);

            var items = new List<Statement.Guarded>();
            items.Add(new Statement.Guarded(element, conditions, block));
            items.AddRange(WalkMany<Statement.Guarded>(element.ElseIf));
            var guardeds = new Statement.Guardeds(element.ElseIf, items);

            var elseBlock = WalkOptional<Body.Block>(element.ElseBlock);

            element.Value = new Statement.If(element, guardeds, elseBlock);
        }

        protected override void Visit(CForStatement element)
        {
            var pattern = Walk<Pattern>(element.Pattern);
            var expression = Walk<Expression>(element.Expression);
            var block = Walk<Body.Block>(element.BlockBody);
            var elseBlock = WalkOptional<Body.Block>(element.ElseBlock);

            element.Value = new Statement.For(element, pattern, expression, block, elseBlock);
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
            element.Value = WalkOptional<Arguments>(element.ArgumentList);
        }

        protected override void Visit(CArgumentList element)
        {
            element.Value = new Arguments(element, WalkMany<Argument>(element));
        }

        protected override void Visit(CExtends element)
        {
            element.Value = Walk<Type>(element.ExtendType);
        }

        protected override void Visit(CNaturalLiteral element)
        {
            element.Value = new Expression.Number(element);
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
            var arguments = Walk<Arguments>(element.Arguments);

            element.Value = new Statement.Assert(element, message, arguments);
        }

        protected override void Visit(CGenericParameters element)
        {
            element.Value = WalkOptional<Generic.TypeParameters>(element.GenericParameterList);
        }

        protected override void Visit(CGenericParameterList element)
        {
            element.Value = new Generic.TypeParameters(element, WalkMany<Generic.TypeParameter>(element));
        }

        protected override void Visit(CGenericParameter element)
        {
            var variance = WalkOptional<string>(element.Variance);
            var name = Walk<Name>(element.Name);
            var @default = WalkOptional<Type>(element.TypeDefault);

            element.Value = new Generic.TypeParameter(element, variance, name, @default);
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
            var parameters = WalkOptional<Generic.TypeParameters>(element.GenericParameters);
            var cases = WalkOptional<Type.Types>(element.CaseTypes);
            var satifies = WalkOptional<Type.Types>(element.Satisfies);

            element.Value = new Generic.Constraint(element, name, parameters, cases, satifies);
        }

        protected override void Visit(CSequenceType element)
        {
            var type = Walk<Type>(element.PrimaryType);

            element.Value = new Type.Sequence(element, type);
        }

        protected override void Visit(CGenericArguments element)
        {
            element.Value = WalkOptional<Generic.TypeArguments>(element.GenericArgumentList);
        }

        protected override void Visit(CGenericArgumentList element)
        {
            element.Value = new Generic.TypeArguments(element, WalkMany<Type>(element));
        }

        protected override void Visit(CAddExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelMulExpression);

            element.Value = new Expression.Add(element, left, right);
        }

        protected override void Visit(CSubExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelMulExpression);

            element.Value = new Expression.Sub(element, left, right);
        }

        protected override void Visit(CMulExpression element)
        {
            var left = Walk<Expression>(element.LevelMulExpression);
            var right = Walk<Expression>(element.LevelUnionExpression);

            element.Value = new Expression.Mul(element, left, right);
        }

        protected override void Visit(CIdenticalExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Identical(element, left, right);
        }

        protected override void Visit(CNotIdenticalExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.NotIdentical(element, left, right);
        }

        protected override void Visit(CEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.Equal(element, left, right);
        }

        protected override void Visit(CNotEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelCompareExpression);
            var right = Walk<Expression>(element.LevelCompareExpression2);

            element.Value = new Expression.NotEqual(element, left, right);
        }

        protected override void Visit(CGreaterExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Greater(element, left, right);
        }

        protected override void Visit(CGreaterEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.GreaterEqual(element, left, right);
        }

        protected override void Visit(CLessExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.Less(element, left, right);
        }

        protected override void Visit(CLessEqualExpression element)
        {
            var left = Walk<Expression>(element.LevelAddExpression);
            var right = Walk<Expression>(element.LevelAddExpression2);

            element.Value = new Expression.LessEqual(element, left, right);
        }

        protected override void Visit(CNotExpression element)
        {
            var expression = Walk<Expression>(element.LevelNotExpression);

            element.Value = new Expression.Not(element, expression);
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

        protected override void Visit(CConjunctionExpression element)
        {
            var left = Walk<Expression>(element.LevelConjunctionExpression);
            var right = Walk<Expression>(element.LevelNotExpression);

            element.Value = new Expression.Conjuntion(element, left, right);
        }

        protected override void Visit(CDisjunctionExpression element)
        {
            var left = Walk<Expression>(element.LevelDisjunctionExpression);
            var right = Walk<Expression>(element.LevelConjunctionExpression);

            element.Value = new Expression.Disjunction(element, left, right);
        }

        protected override void Visit(CVariadicTypeZero element)
        {
            var type = Walk<Type>(element.UnionType);

            element.Value = new Type.ZeroOrMore(element, type);
        }

        protected override void Visit(CVariadicTypeOne element)
        {
            var type = Walk<Type>(element.UnionType);

            element.Value = new Type.OneOrMore(element, type);
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

        protected override void Visit(CIterableTypeZero element)
        {
            var variadic = Walk<Type>(element.UnionType);

            element.Value = new Type.IterableZeroOrMore(element, variadic);
        }

        protected override void Visit(CIterableTypeOne element)
        {
            var variadic = Walk<Type>(element.UnionType);

            element.Value = new Type.IterableOneOrMore(element, variadic);
        }

        protected override void Visit(CNamePattern element)
        {
            element.Value = new Pattern.Ident(element, Walk<Name>(element.Name));
        }

        protected override void Visit(CExpressionArgument element)
        {
            element.Value = new Argument.Expression(element, Walk<Expression>(element.Expression));
        }

        protected override void Visit(CSpreadArgument element)
        {
            element.Value = new Argument.Expression(element, Walk<Expression>(element.LevelUnionExpression));
        }

        protected override void Visit(CMetaArgument element)
        {
            element.Value = new Argument.Expression(element, Walk<Expression>(element.MetaReference));
        }

        protected override void Visit(CLiteralArgument element)
        {
            element.Value = new Argument.Expression(element, Walk<Expression>(element.StringLiteral));
        }

        protected override void Visit(CSpreadType element)
        {
            element.Value = new Type.Spread(element, Walk<Type>(element.UnionType));
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

        protected override void Visit(CTypeDefault element)
        {
            element.Value = Walk<Type>(element.Type);
        }

        protected override void Visit(CValueDefault element)
        {
            element.Value = Walk<Expression>(element.Expression);
        }

        protected override void Visit(CElseExpression element)
        {
            var left = Walk<Expression>(element.LevelCoalesceExpression);
            var right = Walk<Expression>(element.LevelDisjunctionExpression);

            element.Value = new Expression.Else(element, left, right);
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
