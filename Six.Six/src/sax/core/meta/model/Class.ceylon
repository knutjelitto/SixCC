namespace sax.core.meta.model;

"""
A class model represents the model of a Ceylon class that you can instantiate
and inspect.

A class is a toplevel type, declared on a package.

This is a [[ClassModel]] that you can also invoke to instantiate new instances
of the class:

    shared class Foo(String name)
    {
        shared String hello => "Hello "+name;
    }

    void test()
    {
        Class<Foo,[String]> c = `Foo`;
        // This will print: Hello Stef
        print(c("Stef").hello);
    }
"""
shared sealed interface Class<out Type=Anything, in Arguments=Nothing>
    is ClassModel<Type, Arguments> & Applicable<Type, Arguments>
    where Arguments is Anything[]
{    
    """
    A model of the default constructor (for a class with constructors) or class
    initializer (for a class with a parameter list), or null if the class has
    constructors, but lacks a default constructor.
    """
    shared actual formal CallableConstructor<Type, Arguments>? defaultConstructor;
    
    """
    The constructor with the given name, or null if this class lacks a constructor
    of the given name.
    """
    shared actual formal CallableConstructor<Type, Arguments>|ValueConstructor<Type>? getConstructor<Arguments>(String name)
        where Arguments is Anything[];
}
