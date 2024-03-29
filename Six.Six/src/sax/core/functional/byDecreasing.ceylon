namespace sax.core;

"""
Produces a comparator function which orders elements in decreasing order
according to the [[Comparable]] value returned by the given [[comparable]]
function.

    "Hello World!".sort(byDecreasing(Character.lowercased))

This function is intended for use with [[Iterable.sort]] and [[Iterable.max]].
"""
see (function byIncreasing, function decreasing, function Iterable.max, function Iterable.sort)
tagged("Functions", "Comparisons")
shared function Comparison byDecreasing<Element,Value>(Value comparable(Element e))(Element x, Element y)
    where Value is Comparable<Value>
=> comparable(y) <=> comparable(x);

"""
A comparator function which orders elements in decreasing
[[natural order|Comparable]].

    "Hello World!".sort(decreasing)

This function is intended for use with [[Iterable.sort]] and [[Iterable.max]].
"""
see (function increasing, function byDecreasing, function Iterable.max, function Iterable.sort)
tagged("Comparisons")
shared function Comparison decreasing<Element>(Element x, Element y)
    where Element is Comparable<Element> 
=> y <=> x;

"""
A comparator function which orders [[entries|Entry]] by decreasing
[[natural order|Comparable]] of their [[keys|Entry.key]].
    
This function is intended for use with [[Iterable.sort]] and [[Iterable.max]].
"""
tagged("Comparisons")
shared function Comparison decreasingKey<Key>(Key->Anything x, Key->Anything y)
    where Key is Comparable<Key>
=> y.key <=> x.key;

"""
A comparator function which orders [[entries|Entry]] by 
decreasing [[natural order|Comparable]] of their 
[[items|Entry.item]].
    
This function is intended for use with [[Iterable.sort]]
and [[Iterable.max]].
"""
tagged("Comparisons")
shared Comparison decreasingItem<Item>(Object->Item x, Object->Item y)
    where Item is Comparable<Item>
=> y.item <=> x.item;
