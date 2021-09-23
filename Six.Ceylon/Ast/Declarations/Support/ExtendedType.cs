namespace Six.Ceylon.Ast
{
    public sealed class ExtendedType : Node
    {
        public ExtendedType(ExtensionConstruction extensionConstruction)
        {
            ExtensionConstruction = extensionConstruction;
        }

        public ExtensionConstruction ExtensionConstruction { get; }
    }

    public abstract class ExtensionConstruction : Node
    {
    }

    public sealed class Extension : ExtensionConstruction
    {
        public Extension(Qualifier? qualifier, NamesWithArguments names, PositionalArguments? arguments)
        {
            Qualifier = qualifier;
            Names = names;
            Arguments = arguments;
        }

        public Qualifier? Qualifier { get; }
        public NamesWithArguments Names { get; }
        public PositionalArguments? Arguments { get; }
    }

    public abstract class Construction : ExtensionConstruction
    {

    }

    public abstract class ExtensionBase : Node
    {
    }

    public sealed class BaseExtension : ExtensionBase
    {
        public BaseExtension(PackageQualifier? qualifier, NameWithArguments nameWithArguments)
        {
            Qualifier = qualifier;
            NameWithArguments = nameWithArguments;
        }

        public PackageQualifier? Qualifier { get; }
        public NameWithArguments NameWithArguments { get; }
    }

    public sealed class SuperExtension : ExtensionBase
    {

    }
}
