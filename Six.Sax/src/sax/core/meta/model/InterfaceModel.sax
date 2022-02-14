namespace sax.core.meta.model;

using sax.core.meta.declaration
{
    InterfaceDeclaration
}

"""
An interface model represents the model of a Ceylon interface that you can
inspect.

An interface model can be either a toplevel [[Interface]] or a member
[[MemberInterface]].
"""
shared sealed interface InterfaceModel<out Type=Anything> is ClassOrInterface<Type>
{
    
    """
    The declaration model of this class, which is necessarily an
    [[InterfaceDeclaration]].
    """
    shared formal actual InterfaceDeclaration declaration;
}
