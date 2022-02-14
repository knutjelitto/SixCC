namespace sax.core.meta.declaration;

using sax.core.meta.model
{
    Type,
    Function, 
    Method
}

"""
Abstraction over declarations which can be invoked, namely functions, methods
and constructors
"""
shared sealed interface FunctionDeclaration is FunctionOrValueDeclaration & FunctionalDeclaration
{    
    shared actual formal Function<Return, Arguments> apply<Return=Anything, Arguments=Nothing>(Type* typeArguments)
        where Arguments is Anything[];
    
    shared actual formal Method<Container, Return, Arguments> memberApply<Container=Nothing, Return=Anything, Arguments=Nothing>(Type<Object> containerType, Type* typeArguments)
        where Arguments is Anything[];
}
