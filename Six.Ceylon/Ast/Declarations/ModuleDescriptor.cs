using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class ModuleDescriptor : Node, Declaration
    {
        public ModuleDescriptor(Annotations annotations, DottedName name, ModuleSpecifier? specifier, ModuleVersion version, ModuleBody body)
        {
            Annotations = annotations;
            Name = name;
            Specifier = specifier;
            Version = version;
            Body = body;
        }

        public Annotations Annotations { get; }
        public DottedName Name { get; }
        public ModuleSpecifier? Specifier { get; }
        public ModuleVersion Version { get; }
        public ModuleBody Body { get; }
    }

    public interface ModuleDesignator : INode
    {
    }

    public sealed class ModuleSpecifier : Node, ModuleDesignator
    {
        public ModuleSpecifier(Repository repository, ModuleName name, ModuleArtifact? artifact, ModuleClassifier? classifier)
        {
            Repository = repository;
            Name = name;
            Artifact = artifact;
            Classifier = classifier;
        }

        public Repository Repository { get; }
        public ModuleName Name { get; }
        public ModuleArtifact? Artifact { get; }
        public ModuleClassifier? Classifier { get; }
    }

    public sealed class Repository : Node
    {
        public Repository(Name name)
        {
            Name = name;
        }

        public Name Name { get; }
    }

    public sealed class ModuleName : Node, ModuleDesignator
    {
        public ModuleName(String literal)
        {
            Literal = literal;
        }

        public ModuleName(DottedName name)
        {
            Name = name;
        }

        public String? Literal { get; }
        public DottedName? Name { get; }
    }

    public sealed class ModuleBody : NodeList<ModuleImport>
    {
        public ModuleBody(IEnumerable<ModuleImport> items) : base(items)
        {
        }
    }

    public sealed class ModuleImport : Node
    {
        public ModuleImport(Annotations annotations, ModuleDesignator designator, ModuleVersion version)
        {
            Annotations = annotations;
            Designator = designator;
            Version = version;
        }

        public Annotations Annotations { get; }
        public ModuleDesignator Designator { get; }
        public ModuleVersion Version { get; }
    }

    public sealed class ModuleVersion : Node
    {
        public ModuleVersion(String @string)
        {
            String = @string;
        }

        public String String { get; }
    }

    public sealed class ModuleClassifier : Node
    {
        public ModuleClassifier(String literal)
        {
            Literal = literal;
        }

        public String Literal { get; }
    }

    public sealed class ModuleArtifact : Node
    {
        public ModuleArtifact(String literal)
        {
            Literal = literal;
        }

        public String Literal { get; }
    }
}
