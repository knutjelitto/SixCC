#pragma warning disable IDE1006 // Naming Styles

namespace Six.Ceylon.Model
{
    public interface IAliasDeclaration : INestableDeclaration, IGenericDeclaration
    {
        IOpenType extendedType { get; }
    }

    public interface IAnnotatedDeclaration : IDeclaration, IAnnotated
    {
        Sequential<T> annotations<T>() where T : IAnnotation;
    }

    public interface ICallableConstructorDeclaration : IFunctionalDeclaration, IConstructorDeclaration
    {
        bool @abstract { get; }
        bool defaultConstructor { get; } 

/*==========================*/
    }

    public interface IClassDeclaration : IClassOrIntefaceDeclaration
    {
    }

    public interface IClassOrIntefaceDeclaration : INestableDeclaration, IGenericDeclaration
    {
    }

    public interface IClassWithContructorsDeclaration
    {
    }

    public interface IClassWithInitializerDeclaration
    {
    }

    public interface IConstructorDeclaration
    {
    }

    public interface IDeclaration
    {
    }

    public interface IFunctionalDeclaration
    {
    }

    public interface IFunctionDeclaration
    {
    }

    public interface IFunctionOrValueDeclaration
    {
    }

    public interface IGenericDeclaration
    {
        Sequential<ITypeParameter> typeParameterDeclarations { get; }
        ITypeParameter? getTypeParameterDeclaration(string name);
    }

    public interface IGettableDeclaration
    {
    }

    public interface IInterfaceDeclaration
    {
    }

    public interface IModule
    {
    }

    public interface IPackage
    {
    }

    public interface IImport
    {
    }

    public interface INestableDeclaration
    {
    }

    public interface IOpenClassOrInterfaceType
    {
    }

    public interface IOpenClassType
    {
    }

    public interface IOpenInterfaceType
    {
    }

    public interface IOpenIntersectionType
    {
    }

    public interface IOpenType
    {
    }

    public interface IOpenTypeArgument
    {
    }

    public interface IOpenTypeVariable
    {
    }

    public interface IOpenUnion
    {
    }

    public interface ISetterDeclaration
    {
    }

    public interface ITypedDeclaration
    {
    }

    public interface ITypeParameter
    {
    }

    public interface IValueConstructorDeclaration
    {
    }

    public interface IValueDeclaration
    {
    }

    public interface IVariance
    {
    }
}
