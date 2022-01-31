using Six.Ceylon.Ast;
using static Six.Ceylon.CeylonTree;

namespace Six.Ceylon
{
    public partial class CeylonVisitor
    {
        protected override void Visit(CTopDeclarations element)
        {
            element.Value = new Declarations(WalkMany<Decl>(element));
        }

        protected override void Visit(CAliasDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.TypeName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Type>(element.OptionalTypeSpecifier);

            element.Value = new Decl.Alias(annotations, name, typeParameters, constraints, definition);
        }

        protected override void Visit(CClassDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.TypeName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var parameters = Walk<Parameters>(element.Parameters);
            var caseType = Walk<CaseTypes>(element.CaseTypes);
            var extended = Walk<Extended>(element.ExtendedType);
            var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Expr.Specifier>(element.ClassDefinition);

            element.Value = new Decl.Class(annotations, name, typeParameters, parameters, caseType, extended, satisfied, constraints, definition);
        }

        protected override void Visit(CInterfaceDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.TypeName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var caseType = Walk<CaseTypes>(element.CaseTypes);
            var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Expr.Specifier>(element.InterfaceDefinition);

            element.Value = new Decl.Interface(annotations, name, typeParameters, caseType, satisfied, constraints, definition);
        }

        protected override void Visit(CObjectDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var extended = Walk<Extended>(element.ExtendedType);
            var satisfied = Walk<Satisfied>(element.SatisfiedTypes);
            var definition = Walk<Block>(element.Block);

            element.Value = new Decl.Object(annotations, name, extended, satisfied, definition);
        }

        protected override void Visit(CConstructorDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var parameters = Walk<Parameters>(element.Parameters);
            var instantiation = Walk<Instantiation>(element.DelegatedConstructor);
            var definition = Walk<Block>(element.Block);

            element.Value = new Decl.Constructor(annotations, name, parameters, instantiation, definition);
        }

        protected override void Visit(CEnumeratedObjectDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var instantiation = Walk<Instantiation>(element.DelegatedConstructor);
            var definition = Walk<Block>(element.Block);

            element.Value = new Decl.Enumerated(annotations, name, instantiation, definition);
        }

        protected override void Visit(CTypedMethodDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var type = Walk<Type>(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters));
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Expr.Specifier>(element.MethodDefinition);

            element.Value = new Decl.TypedMethod(type, annotations, name, typeParameters, parameters, constraints, definition);
        }

        protected override void Visit(CVoidMethodDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters));
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Expr.Specifier>(element.MethodDefinition);

            element.Value = new Decl.VoidMethod(annotations, name, typeParameters, parameters, constraints, definition);
        }

        protected override void Visit(CInferredMethodDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var typeParameters = Walk<TypeParameterList>(element.TypeParameters);
            var parameters = new ParametersList(WalkMany<Parameters>(element.Parameters));
            var constraints = Walk<TypeConstraintList>(element.TypeConstraints);
            var definition = Walk<Expr.Specifier>(element.MethodDefinition);

            element.Value = new Decl.InferredMethod(annotations, name, typeParameters, parameters, constraints, definition);
        }

        protected override void Visit(CTypedAttributeDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var type = Walk<Type>(element.VariadicType);
            var name = Walk<Identifier>(element.MemberName);
            var definition = Walk<Expr.Specifier>(element.AttributeDefinition);

            element.Value = new Decl.TypedAttribute(type, annotations, name, definition);
        }

        protected override void Visit(CInferredAttributeDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var definition = Walk<Expr.Specifier>(element.AttributeDefinition);

            element.Value = new Decl.InferredAttribute(annotations, name, definition);
        }

        protected override void Visit(CSetterDeclaration element)
        {
            var annotations = Walk<Annotations>(element.Annotations);
            var name = Walk<Identifier>(element.MemberName);
            var definition = Walk<Expr.Specifier>(element.SetterDefinition);

            element.Value = new Decl.Setter(annotations, name, definition);
        }
    }
}
