/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
namespace six.core;

"""
A [[Range]] of adjacent [[Enumerable]] values generated by two endpoints: [[first]] and [[last]]. The range includes
both endpoints, and all values falling _between_ the endpoints.
"""
by ("Gavin") see (class Measure, interface Enumerable)
final serializable
shared class Span<Element>(first, last) extends Range<Element>() given Element satisfies Enumerable<Element>
{
    "The start of the range."
    shared actual Element first;
    
    "The end of the range."
    shared actual Element last;
    
    string => first.string + ".." + last.string;
    
    increasing = last.offsetSign(first) >= 0;
    
    decreasing => !increasing;
    
    "Determines if the range is of recursive values, that is, if successors wrap back on themselves. All recursive ranges
     are [[increasing]]."
    Boolean recursive
        =   first.offsetSign(first.successor) > 0 && last.predecessor.offsetSign(last) > 0;
    
    Element next(Element x)
        =>  increasing 
            then x.successor
            else x.predecessor;
    
    Element nextStep(Element x, Integer step)
        =>  increasing 
            then x.neighbour(step)
            else x.neighbour(-step);
    
    Element fromFirst(Integer offset)
        =>  increasing 
            then first.neighbour(offset)
            else first.neighbour(-offset);
    
    Boolean afterLast(Element x)
        =>  increasing 
            then x.offsetSign(last) > 0
            else x.offsetSign(last) < 0;
    
    Boolean beforeLast(Element x)
        =>  increasing 
            then x.offsetSign(last) < 0
            else x.offsetSign(last) > 0;
    
    Boolean beforeFirst(Element x)
        =>  increasing 
            then x.offsetSign(first) < 0
            else x.offsetSign(first) > 0;
    
    Boolean afterFirst(Element x)
        =>  increasing 
            then x.offsetSign(first) > 0
            else x.offsetSign(first) < 0;
    
    shared actual Integer size
    {
        value lastIndex = last.offset(first).magnitude;
        if (lastIndex<runtime.maxIntegerValue)
        {
            return lastIndex + 1;
        }
        else
        {
            throw OverflowException("size of range");
        }
    }
    
    longerThan(Integer length) 
        =>  if (length < 1) then true
            else if (recursive) then size > length
            else beforeLast(fromFirst(length - 1));
    
    shorterThan(Integer length)
        =>  if (length < 1) then true
            else if (recursive) then size < length
            else afterLast(fromFirst(length - 1));
    
    lastIndex => size - 1;
    
    rest => first == last then [] else next(first)..last;
    
    """
    This range in reverse, with [[first]] and [[last]] interchanged.
    
    For any two range endpoints, `x` and `y`: 
    
        `(x..y).reversed == y..x`
    
    except for [[recursive]] ranges, where the elements are evaluated and collected into a new sequence.
    """
    //TODO: we should have a way to produce a decreasing recursive range
    shared actual 
    [Element+] reversed
        =>  recursive 
            then super.reversed
            else last..first;
    
    "The element of the range that occurs [[index]] values after the start of the range."
    shared actual 
    Element? getFromFirst(Integer index)
    {
        if (index < 0)
        {
            return null;
        }
        else if (recursive)
        {
            return index < size then fromFirst(index);
        }
        else
        {
            value result = fromFirst(index);
            return !afterLast(result) then result;
        }
    }
    
    """
    An iterator for the elements of the range. The returned iterator produces elements from [[first]] and continues
    producing elements until it reaches an element whose `offset` from [[last]] is zero.
    """
    shared actual 
    Iterator<Element> iterator() 
        =>  object satisfies Iterator<Element>
            {
                variable Boolean firstTime = true;
                variable Element|Finished element = first;
                shared actual Element|Finished next()
                {
                    if (!is Finished c = element)
                    {
                        Element result;
                        if (firstTime)
                        {
                            firstTime = false;
                            result = c;
                        }
                        else
                        {
                            result = outer.next(c);
                        }
                        if (result.offset(last) == 0)
                        {
                            this.element = finished;
                        }
                        else
                        {
                            this.element  = result;
                        }
                        return result;
                    }
                    else
                    {
                        return element ;
                    }
                }
            
                string => "(``outer``).iterator()";
            };
    
    shared actual 
    {Element+} by(Integer step)
    {
        "step size must be greater than zero"
        assert (step > 0);
        return step == 1 then this else By(step);
    }
    
    shifted(Integer shift)
        =>  shift == 0
            then this
            else Span(first.neighbour(shift), last.neighbour(shift));
    
    containsElement(Element x)
        =>  recursive 
            then x.offset(first) <= last.offset(first)
            else !afterLast(x) && !beforeFirst(x);
    
    shared actual 
    Integer count(Boolean selecting(Element element))
    {
        variable value element = first;
        variable value count = 0;
        while (containsElement(element))
        {
            if (selecting(element))
            {
                count++;
            }
            element = next(element);
        }
        return count;
    }
    
    shared actual 
    Boolean includesRange(Range<Element> range)
    {
        switch (range)
        case (is Span<Element>)
        {
            if (recursive)
            {
                return range.first.offset(first) < size && range.last.offset(first) < size;
            }
            else
            {
                return increasing == range.increasing && !range.afterFirst(first) && !range.beforeLast(last);
            }
        }
        case (is Measure<Element>)
        {
            if (decreasing)
            {
                return false;
            }
            else
            {
                value offset = range.first.offset(first);
                return 0 <= offset <= size - range.size;
            }
        }
    }
    
    shared actual 
    Boolean equals(Object that)
    {
        if (is Span<out Object> that)
        {
            //optimize for another Span
            return that.first == first && that.last == last;
        }
        else if (is Measure<out Object> that)
        {
            return increasing && that.first == first && that.size == size;
        }
        else
        {
            //it might be another sort of List
            return super.equals(that);
        }
    }
    
    class By(Integer step) satisfies {Element+}
    {
        size => 1 + (outer.size - 1) / step;
        
        first => outer.first;
        
        string => "(``outer``).by(``step``)";
        
        shared actual 
        Iterator<Element> iterator()
        {
            if (recursive)
            {
                return object satisfies Iterator<Element>
                {
                    variable value count = 0;
                    variable value current = first;
                    shared actual Element|Finished next()
                    {
                        if (++count > size)
                        {
                            return finished;
                        }
                        else
                        {
                            value result = current;
                            current = current.neighbour(step);
                            return result;
                        }
                    }
                    string => "``outer``.iterator()";
                };
            }
            else
            {
                return object satisfies Iterator<Element>
                {
                    variable Element|Finished current = first;
                    variable value firstTime = true;
                    shared actual Element|Finished next()
                    {
                        if (firstTime)
                        {
                            firstTime = false;
                            return current;
                        }
                        else
                        {
                            if (is Element c=current)
                            {
                                value r = nextStep(c, step);
                                if (!containsElement(r))
                                {
                                    current = finished;
                                }
                                else
                                {
                                    current = r;
                                }
                            }
                            return current;
                        }
                    }
                    string => "``outer``.iterator()";
                };
            }
        }
    }
    
    shared actual 
    [Element*] measure(Integer from, Integer length)
        =>  length <= 0 
            then [] 
            else span(from, from + length - 1);
    
    shared actual 
    [Element*] span(Integer from, Integer to)
    {
        if (from <= to)
        {
            if (to < 0 || !longerThan(from))
            {
                return [];
            }
            else
            {
                return (this[from] else first)..(this[to] else last);
            }
        }
        else
        {
            if (from < 0 || !longerThan(to))
            {
                return [];
            }
            else
            {
                value range = (this[to] else first)..(this[from] else last);
                return range.reversed;
            }
        }
    }
    
    shared actual 
    [Element*] spanFrom(Integer from)
    {
        if (from <= 0)
        {
            return this;
        }
        else if (longerThan(from))
        {
            assert (exists first = this[from]);
            return first..last;
        }
        else
        {
            return [];
        }
    }
    
    shared actual 
    [Element*] spanTo(Integer to)
    {
        if (to < 0)
        {
            return [];
        }
        else if (longerThan(to + 1))
        {
            assert (exists last = this[to]);
            return first..last;
        }
        else
        {
            return this;
        }
    }
    
    shared actual void each(void step(Element element))
    {
        variable value current = first;
        while (true)
        {
            step(current);
            if (current.offset(last) == 0)
            {
                break;
            }
            else
            {
                current = next(current);
            }
        }
    }
}

"""
Produces a [[Range]] of adjacent [[Enumerable]] values generated by two endpoints: [[first]] and [[last]]. The range
includes both endpoints, and all values falling _between_ the endpoints.

- For a recursive enumerable type, a value falls between the endpoints if its [[offset|Enumerable.offset]] from  `first`
  is less than the offset of `last` from `first`.
- For a linear enumerable type, a value falls between the endpoints if the [[sign of its offset|Enumerable.offsetSign]]
  from `first` is the same as the sign of the offset of `last` from `first` and the sign of its offset from `last` is
  the opposite of the sign of the offset of `last` from `first`.

More precisely, if `x`, `first`, and `last` are of `Enumerable` type `X`, then `x in first..last` if and  only if:

- `X` is recursive and `x.offset(first)<last.offset(first)`,
or
- `X` is linear and 
  `x.offsetSign(first)==last.offsetSign(first)` and
  `x.offsetSign(last)==-last.offsetSign(first)`.

For a linear enumerable type, a range is either [[increasing|Range.increasing]] or [[decreasing|Range.decreasing]]:

- in an increasing range, a value occurs before its [[successor|Ordinal.successor]] and after its
  [[predecessor|Ordinal.predecessor]], but
- in a decreasing range, a value occurs after its `successor` and before its `predecessor`.

The direction of the range depends upon the sign of the offset of `last` from `first`: 

- if `last.offsetSign(first) >= 0` the range is increasing,
but
- if `last.offsetSign(first) < 0`, the range is decreasing.

A range for a recursive enumerable type is always increasing.

The _span operator_ `..` is an abbreviation for `span()`:

    for (i in min..max) { ... }
    if (char in 'A'..'Z') { ... }

The span operator accepts the first and last values of the range. It may produce an increasing range:

    0..5    // [0, 1, 2, 3, 4, 5]
    0..0    // [0]

Or it may produce a decreasing range:

    5..0    // [5, 4, 3, 2, 1, 0]
    0..-5   // [0, -1, -2, -3, -4, -5]
"""
since("1.1.0")
shared Range<Element> span<Element>(Element first, Element last)
    given Element satisfies Enumerable<Element>
    => Span(first, last);
