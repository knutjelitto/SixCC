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
            where T : class, Node
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
            base.DefaultImplementation(element);
        }

        protected override void Visit(CXStart element)
        {
            Walk(element.CompilationUnit);
        }

        protected override void Visit(CModuleDescriptor element)
        {
            element.Value = Walk<Names>(element.Names);

        }

        protected override void Visit(CNames element)
        {
            element.Value = new Names(element, WalkMany<Name>(element));
        }

        protected override void Visit(CIdentifier element)
        {
            element.Value = new Name(element);
        }

        protected override void Visit(CNamespace element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var names = Walk<Names>(element.Names);
            var declarations = Walk<Declarations>(element.Declarations);

            element.Value = new Namespace(element, prelude, names, declarations);
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
            element.Value = new Expression.String(element);
        }

        protected override void Visit(CVerbatimStringLiteral element)
        {
            element.Value = new Expression.String(element);
        }

        protected override void Visit(CDeclarations element)
        {
            element.Value = new Declarations(element, WalkMany<Declaration>(element));
        }

        protected override void Visit(CFunctionDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var parameters = Walk<Parameters>(element.Parameters);
            var body = Walk<Body>(element.FunctionBody);

            element.Value = new Declaration.Function(element, prelude, type, name, parameters, body);
        }

        protected override void Visit(CAttributeDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var type = Walk<Type>(element.Type);
            var name = Walk<Name>(element.Name);
            var body = Walk<Body>(element.AttributeBody);

            element.Value = new Declaration.Attribute(element, prelude, type, name, body);
        }

        protected override void Visit(CClassDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var parameters = Walk<Parameters>(element.Parameters);
            var extends = Walk<Type>(element.Extends);
            var cases = Walk<Types>(element.CaseTypes);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Class(element, prelude, name, parameters, extends, cases, body);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            var prelude = Walk<Prelude>(element.Prelude);
            var name = Walk<Name>(element.Name);
            var extends = Walk<Type>(element.Extends);
            var body = Walk<Body>(element.BlockBody);

            element.Value = new Declaration.Object(element, prelude, name, extends, body);
        }

        protected override void Visit(CPath element)
        {
            element.Value = new Path(element, WalkMany<Reference>(element));
        }

        protected override void Visit(CReference element)
        {
            var name = Walk<Name>(element.Name);
            var arguments = Walk<GenericArguments>(element.GenericArguments);

            element.Value = new Reference(element, name, arguments);
        }


        protected override void Visit(CParameters element)
        {
            element.Value = Walk<Parameters>(element.ParameterList);
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

        protected override void Visit(CBlockBody element)
        {
            var declarations = Walk<Declarations>(element.Declarations);
            var statements = Walk<Statements>(element.Statements);

            element.Value = new Body.Block(element, declarations, statements);
        }

        protected override void Visit(CExpressionBody element)
        {
            if (Exists(element.FunctionSpecifier))
            {
                var expression = Walk<Expression>(element.FunctionSpecifier)!;
                element.Value = new Body.Function(element, expression);
            }
            else
            {
                element.Value = new Body.Null(element);
            }
        }

        protected override void Visit(CStatements element)
        {
            element.Value = new Statements(element, WalkMany<Statement>(element));
        }

        protected override void Visit(CReturnStatement element)
        {
            element.Value = new Statement.Return(element, Walk<Expression>(element.Expression));
        }

        protected override void Visit(CAddExpression element)
        {
            var left = Walk<Expression>(element.AddlevelExpression);
            var right = Walk<Expression>(element.MullevelExpression);

            element.Value = new Expression.Add(element, left, right);
        }

        protected override void Visit(CCaseTypes element)
        {
            element.Value = Walk<Types>(element.CaseTypeList);
        }

        protected override void Visit(CCaseTypeList element)
        {
            element.Value = new Types(element, WalkMany<Type>(element));
        }

        protected override void Visit(CClassReference element)
        {
            element.Value = new Meta.ClassReference(element, Walk<Names>(element.Names));
        }

        protected override void Visit(CInterfaceReference element)
        {
            element.Value = new Meta.InterfaceReference(element, Walk<Names>(element.Names));
        }
    }
}
