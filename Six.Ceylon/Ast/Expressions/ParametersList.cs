using System.Collections.Generic;

namespace Six.Ceylon.Ast
{
    public sealed class ParametersList : NodeList<Parameters>
    {
        public ParametersList(IEnumerable<Parameters> items) : base(items)
        {
        }
    }
    public sealed class Parameters : NodeList<Parameter>
    {
        public Parameters(IEnumerable<Parameter> items) : base(items)
        {
        }
    }

    public interface Parameter : INode
    {
    }

    public sealed class CallableParameter : Node, Parameter
    {
        public CallableParameter(Annotations annotations, Type prefix, Name name, IEnumerable<Parameters> parameters)
        {
            Annotations = annotations;
            Prefix = prefix;
            Name = name;
            Parameters = new ParametersList(parameters);
        }

        public Annotations Annotations { get; }
        public Type Prefix { get; }
        public Name Name { get; }
        public ParametersList Parameters { get; }
    }

    public sealed class DefaultedParameter : Node, Parameter
    {
        public DefaultedParameter(Parameter parameter, Specifier specifier)
        {
            Parameter = parameter;
            Specifier = specifier;
        }

        public Parameter Parameter { get; }
        public Specifier Specifier { get; }
    }

    public sealed class ValueParameter : Node, Parameter
    {
        public ValueParameter(Annotations annotations, Type prefix, Name memberName)
        {
            Annotations = annotations;
            Prefix = prefix;
            MemberName = memberName;
        }

        public Annotations Annotations { get; }
        public Type Prefix { get; }
        public Name MemberName { get; }
    }

    public sealed class VariadicParameter : Node, Parameter
    {
        public VariadicParameter(Annotations annotations, VariadicType type, Name name)
        {
            Annotations = annotations;
            Type = type;
            Name = name;
        }

        public Annotations Annotations { get; }
        public VariadicType Type { get; }
        public Name Name { get; }
    }
}
